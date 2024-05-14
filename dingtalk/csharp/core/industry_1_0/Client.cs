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


        /**
         * @summary 商机匹配
         *
         * @param request BusinessMatchRequest
         * @param headers BusinessMatchHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BusinessMatchResponse
         */
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

        /**
         * @summary 商机匹配
         *
         * @param request BusinessMatchRequest
         * @param headers BusinessMatchHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BusinessMatchResponse
         */
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

        /**
         * @summary 商机匹配
         *
         * @param request BusinessMatchRequest
         * @return BusinessMatchResponse
         */
        public BusinessMatchResponse BusinessMatch(BusinessMatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BusinessMatchHeaders headers = new BusinessMatchHeaders();
            return BusinessMatchWithOptions(request, headers, runtime);
        }

        /**
         * @summary 商机匹配
         *
         * @param request BusinessMatchRequest
         * @return BusinessMatchResponse
         */
        public async Task<BusinessMatchResponse> BusinessMatchAsync(BusinessMatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BusinessMatchHeaders headers = new BusinessMatchHeaders();
            return await BusinessMatchWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 商机匹配结果查询
         *
         * @param request BusinessMatchResultRequest
         * @param headers BusinessMatchResultHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BusinessMatchResultResponse
         */
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

        /**
         * @summary 商机匹配结果查询
         *
         * @param request BusinessMatchResultRequest
         * @param headers BusinessMatchResultHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BusinessMatchResultResponse
         */
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

        /**
         * @summary 商机匹配结果查询
         *
         * @param request BusinessMatchResultRequest
         * @return BusinessMatchResultResponse
         */
        public BusinessMatchResultResponse BusinessMatchResult(BusinessMatchResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BusinessMatchResultHeaders headers = new BusinessMatchResultHeaders();
            return BusinessMatchResultWithOptions(request, headers, runtime);
        }

        /**
         * @summary 商机匹配结果查询
         *
         * @param request BusinessMatchResultRequest
         * @return BusinessMatchResultResponse
         */
        public async Task<BusinessMatchResultResponse> BusinessMatchResultAsync(BusinessMatchResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BusinessMatchResultHeaders headers = new BusinessMatchResultHeaders();
            return await BusinessMatchResultWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 添加租客下成员
         *
         * @param request CampusAddRenterMemberRequest
         * @param headers CampusAddRenterMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CampusAddRenterMemberResponse
         */
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

        /**
         * @summary 添加租客下成员
         *
         * @param request CampusAddRenterMemberRequest
         * @param headers CampusAddRenterMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CampusAddRenterMemberResponse
         */
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

        /**
         * @summary 添加租客下成员
         *
         * @param request CampusAddRenterMemberRequest
         * @return CampusAddRenterMemberResponse
         */
        public CampusAddRenterMemberResponse CampusAddRenterMember(CampusAddRenterMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusAddRenterMemberHeaders headers = new CampusAddRenterMemberHeaders();
            return CampusAddRenterMemberWithOptions(request, headers, runtime);
        }

        /**
         * @summary 添加租客下成员
         *
         * @param request CampusAddRenterMemberRequest
         * @return CampusAddRenterMemberResponse
         */
        public async Task<CampusAddRenterMemberResponse> CampusAddRenterMemberAsync(CampusAddRenterMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusAddRenterMemberHeaders headers = new CampusAddRenterMemberHeaders();
            return await CampusAddRenterMemberWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建园区
         *
         * @param request CampusCreateCampusRequest
         * @param headers CampusCreateCampusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CampusCreateCampusResponse
         */
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

        /**
         * @summary 创建园区
         *
         * @param request CampusCreateCampusRequest
         * @param headers CampusCreateCampusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CampusCreateCampusResponse
         */
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

        /**
         * @summary 创建园区
         *
         * @param request CampusCreateCampusRequest
         * @return CampusCreateCampusResponse
         */
        public CampusCreateCampusResponse CampusCreateCampus(CampusCreateCampusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusCreateCampusHeaders headers = new CampusCreateCampusHeaders();
            return CampusCreateCampusWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建园区
         *
         * @param request CampusCreateCampusRequest
         * @return CampusCreateCampusResponse
         */
        public async Task<CampusCreateCampusResponse> CampusCreateCampusAsync(CampusCreateCampusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusCreateCampusHeaders headers = new CampusCreateCampusHeaders();
            return await CampusCreateCampusWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建园区项目组
         *
         * @param request CampusCreateCampusGroupRequest
         * @param headers CampusCreateCampusGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CampusCreateCampusGroupResponse
         */
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

        /**
         * @summary 创建园区项目组
         *
         * @param request CampusCreateCampusGroupRequest
         * @param headers CampusCreateCampusGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CampusCreateCampusGroupResponse
         */
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

        /**
         * @summary 创建园区项目组
         *
         * @param request CampusCreateCampusGroupRequest
         * @return CampusCreateCampusGroupResponse
         */
        public CampusCreateCampusGroupResponse CampusCreateCampusGroup(CampusCreateCampusGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusCreateCampusGroupHeaders headers = new CampusCreateCampusGroupHeaders();
            return CampusCreateCampusGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建园区项目组
         *
         * @param request CampusCreateCampusGroupRequest
         * @return CampusCreateCampusGroupResponse
         */
        public async Task<CampusCreateCampusGroupResponse> CampusCreateCampusGroupAsync(CampusCreateCampusGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusCreateCampusGroupHeaders headers = new CampusCreateCampusGroupHeaders();
            return await CampusCreateCampusGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建租客
         *
         * @param request CampusCreateRenterRequest
         * @param headers CampusCreateRenterHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CampusCreateRenterResponse
         */
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

        /**
         * @summary 创建租客
         *
         * @param request CampusCreateRenterRequest
         * @param headers CampusCreateRenterHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CampusCreateRenterResponse
         */
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

        /**
         * @summary 创建租客
         *
         * @param request CampusCreateRenterRequest
         * @return CampusCreateRenterResponse
         */
        public CampusCreateRenterResponse CampusCreateRenter(CampusCreateRenterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusCreateRenterHeaders headers = new CampusCreateRenterHeaders();
            return CampusCreateRenterWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建租客
         *
         * @param request CampusCreateRenterRequest
         * @return CampusCreateRenterResponse
         */
        public async Task<CampusCreateRenterResponse> CampusCreateRenterAsync(CampusCreateRenterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusCreateRenterHeaders headers = new CampusCreateRenterHeaders();
            return await CampusCreateRenterWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 移除租客人员
         *
         * @param request CampusDelRenterMemberRequest
         * @param headers CampusDelRenterMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CampusDelRenterMemberResponse
         */
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

        /**
         * @summary 移除租客人员
         *
         * @param request CampusDelRenterMemberRequest
         * @param headers CampusDelRenterMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CampusDelRenterMemberResponse
         */
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

        /**
         * @summary 移除租客人员
         *
         * @param request CampusDelRenterMemberRequest
         * @return CampusDelRenterMemberResponse
         */
        public CampusDelRenterMemberResponse CampusDelRenterMember(CampusDelRenterMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusDelRenterMemberHeaders headers = new CampusDelRenterMemberHeaders();
            return CampusDelRenterMemberWithOptions(request, headers, runtime);
        }

        /**
         * @summary 移除租客人员
         *
         * @param request CampusDelRenterMemberRequest
         * @return CampusDelRenterMemberResponse
         */
        public async Task<CampusDelRenterMemberResponse> CampusDelRenterMemberAsync(CampusDelRenterMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusDelRenterMemberHeaders headers = new CampusDelRenterMemberHeaders();
            return await CampusDelRenterMemberWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除园区项目组
         *
         * @param request CampusDeleteCampusGroupRequest
         * @param headers CampusDeleteCampusGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CampusDeleteCampusGroupResponse
         */
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

        /**
         * @summary 删除园区项目组
         *
         * @param request CampusDeleteCampusGroupRequest
         * @param headers CampusDeleteCampusGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CampusDeleteCampusGroupResponse
         */
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

        /**
         * @summary 删除园区项目组
         *
         * @param request CampusDeleteCampusGroupRequest
         * @return CampusDeleteCampusGroupResponse
         */
        public CampusDeleteCampusGroupResponse CampusDeleteCampusGroup(CampusDeleteCampusGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusDeleteCampusGroupHeaders headers = new CampusDeleteCampusGroupHeaders();
            return CampusDeleteCampusGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除园区项目组
         *
         * @param request CampusDeleteCampusGroupRequest
         * @return CampusDeleteCampusGroupResponse
         */
        public async Task<CampusDeleteCampusGroupResponse> CampusDeleteCampusGroupAsync(CampusDeleteCampusGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusDeleteCampusGroupHeaders headers = new CampusDeleteCampusGroupHeaders();
            return await CampusDeleteCampusGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除租客
         *
         * @param request CampusDeleteRenterRequest
         * @param headers CampusDeleteRenterHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CampusDeleteRenterResponse
         */
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

        /**
         * @summary 删除租客
         *
         * @param request CampusDeleteRenterRequest
         * @param headers CampusDeleteRenterHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CampusDeleteRenterResponse
         */
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

        /**
         * @summary 删除租客
         *
         * @param request CampusDeleteRenterRequest
         * @return CampusDeleteRenterResponse
         */
        public CampusDeleteRenterResponse CampusDeleteRenter(CampusDeleteRenterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusDeleteRenterHeaders headers = new CampusDeleteRenterHeaders();
            return CampusDeleteRenterWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除租客
         *
         * @param request CampusDeleteRenterRequest
         * @return CampusDeleteRenterResponse
         */
        public async Task<CampusDeleteRenterResponse> CampusDeleteRenterAsync(CampusDeleteRenterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusDeleteRenterHeaders headers = new CampusDeleteRenterHeaders();
            return await CampusDeleteRenterWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询园区详情
         *
         * @param request CampusGetCampusRequest
         * @param headers CampusGetCampusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CampusGetCampusResponse
         */
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

        /**
         * @summary 查询园区详情
         *
         * @param request CampusGetCampusRequest
         * @param headers CampusGetCampusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CampusGetCampusResponse
         */
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

        /**
         * @summary 查询园区详情
         *
         * @param request CampusGetCampusRequest
         * @return CampusGetCampusResponse
         */
        public CampusGetCampusResponse CampusGetCampus(CampusGetCampusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusGetCampusHeaders headers = new CampusGetCampusHeaders();
            return CampusGetCampusWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询园区详情
         *
         * @param request CampusGetCampusRequest
         * @return CampusGetCampusResponse
         */
        public async Task<CampusGetCampusResponse> CampusGetCampusAsync(CampusGetCampusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusGetCampusHeaders headers = new CampusGetCampusHeaders();
            return await CampusGetCampusWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询园区项目组详情
         *
         * @param request CampusGetCampusGroupRequest
         * @param headers CampusGetCampusGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CampusGetCampusGroupResponse
         */
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

        /**
         * @summary 查询园区项目组详情
         *
         * @param request CampusGetCampusGroupRequest
         * @param headers CampusGetCampusGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CampusGetCampusGroupResponse
         */
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

        /**
         * @summary 查询园区项目组详情
         *
         * @param request CampusGetCampusGroupRequest
         * @return CampusGetCampusGroupResponse
         */
        public CampusGetCampusGroupResponse CampusGetCampusGroup(CampusGetCampusGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusGetCampusGroupHeaders headers = new CampusGetCampusGroupHeaders();
            return CampusGetCampusGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询园区项目组详情
         *
         * @param request CampusGetCampusGroupRequest
         * @return CampusGetCampusGroupResponse
         */
        public async Task<CampusGetCampusGroupResponse> CampusGetCampusGroupAsync(CampusGetCampusGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusGetCampusGroupHeaders headers = new CampusGetCampusGroupHeaders();
            return await CampusGetCampusGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取租客详情
         *
         * @param request CampusGetRenterRequest
         * @param headers CampusGetRenterHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CampusGetRenterResponse
         */
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

        /**
         * @summary 获取租客详情
         *
         * @param request CampusGetRenterRequest
         * @param headers CampusGetRenterHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CampusGetRenterResponse
         */
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

        /**
         * @summary 获取租客详情
         *
         * @param request CampusGetRenterRequest
         * @return CampusGetRenterResponse
         */
        public CampusGetRenterResponse CampusGetRenter(CampusGetRenterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusGetRenterHeaders headers = new CampusGetRenterHeaders();
            return CampusGetRenterWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取租客详情
         *
         * @param request CampusGetRenterRequest
         * @return CampusGetRenterResponse
         */
        public async Task<CampusGetRenterResponse> CampusGetRenterAsync(CampusGetRenterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusGetRenterHeaders headers = new CampusGetRenterHeaders();
            return await CampusGetRenterWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询租客指定成员信息
         *
         * @param request CampusGetRenterMemberRequest
         * @param headers CampusGetRenterMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CampusGetRenterMemberResponse
         */
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

        /**
         * @summary 查询租客指定成员信息
         *
         * @param request CampusGetRenterMemberRequest
         * @param headers CampusGetRenterMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CampusGetRenterMemberResponse
         */
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

        /**
         * @summary 查询租客指定成员信息
         *
         * @param request CampusGetRenterMemberRequest
         * @return CampusGetRenterMemberResponse
         */
        public CampusGetRenterMemberResponse CampusGetRenterMember(CampusGetRenterMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusGetRenterMemberHeaders headers = new CampusGetRenterMemberHeaders();
            return CampusGetRenterMemberWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询租客指定成员信息
         *
         * @param request CampusGetRenterMemberRequest
         * @return CampusGetRenterMemberResponse
         */
        public async Task<CampusGetRenterMemberResponse> CampusGetRenterMemberAsync(CampusGetRenterMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusGetRenterMemberHeaders headers = new CampusGetRenterMemberHeaders();
            return await CampusGetRenterMemberWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询园区列表
         *
         * @param request CampusListCampusRequest
         * @param headers CampusListCampusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CampusListCampusResponse
         */
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

        /**
         * @summary 查询园区列表
         *
         * @param request CampusListCampusRequest
         * @param headers CampusListCampusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CampusListCampusResponse
         */
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

        /**
         * @summary 查询园区列表
         *
         * @param request CampusListCampusRequest
         * @return CampusListCampusResponse
         */
        public CampusListCampusResponse CampusListCampus(CampusListCampusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusListCampusHeaders headers = new CampusListCampusHeaders();
            return CampusListCampusWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询园区列表
         *
         * @param request CampusListCampusRequest
         * @return CampusListCampusResponse
         */
        public async Task<CampusListCampusResponse> CampusListCampusAsync(CampusListCampusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusListCampusHeaders headers = new CampusListCampusHeaders();
            return await CampusListCampusWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询园区项目组列表
         *
         * @param headers CampusListCampusGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CampusListCampusGroupResponse
         */
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

        /**
         * @summary 查询园区项目组列表
         *
         * @param headers CampusListCampusGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CampusListCampusGroupResponse
         */
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

        /**
         * @summary 查询园区项目组列表
         *
         * @return CampusListCampusGroupResponse
         */
        public CampusListCampusGroupResponse CampusListCampusGroup()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusListCampusGroupHeaders headers = new CampusListCampusGroupHeaders();
            return CampusListCampusGroupWithOptions(headers, runtime);
        }

        /**
         * @summary 查询园区项目组列表
         *
         * @return CampusListCampusGroupResponse
         */
        public async Task<CampusListCampusGroupResponse> CampusListCampusGroupAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusListCampusGroupHeaders headers = new CampusListCampusGroupHeaders();
            return await CampusListCampusGroupWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 获取租客列表
         *
         * @param headers CampusListRenterHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CampusListRenterResponse
         */
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

        /**
         * @summary 获取租客列表
         *
         * @param headers CampusListRenterHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CampusListRenterResponse
         */
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

        /**
         * @summary 获取租客列表
         *
         * @return CampusListRenterResponse
         */
        public CampusListRenterResponse CampusListRenter()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusListRenterHeaders headers = new CampusListRenterHeaders();
            return CampusListRenterWithOptions(headers, runtime);
        }

        /**
         * @summary 获取租客列表
         *
         * @return CampusListRenterResponse
         */
        public async Task<CampusListRenterResponse> CampusListRenterAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusListRenterHeaders headers = new CampusListRenterHeaders();
            return await CampusListRenterWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 查询租客下所有成员
         *
         * @param request CampusListRenterMembersRequest
         * @param headers CampusListRenterMembersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CampusListRenterMembersResponse
         */
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

        /**
         * @summary 查询租客下所有成员
         *
         * @param request CampusListRenterMembersRequest
         * @param headers CampusListRenterMembersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CampusListRenterMembersResponse
         */
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

        /**
         * @summary 查询租客下所有成员
         *
         * @param request CampusListRenterMembersRequest
         * @return CampusListRenterMembersResponse
         */
        public CampusListRenterMembersResponse CampusListRenterMembers(CampusListRenterMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusListRenterMembersHeaders headers = new CampusListRenterMembersHeaders();
            return CampusListRenterMembersWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询租客下所有成员
         *
         * @param request CampusListRenterMembersRequest
         * @return CampusListRenterMembersResponse
         */
        public async Task<CampusListRenterMembersResponse> CampusListRenterMembersAsync(CampusListRenterMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusListRenterMembersHeaders headers = new CampusListRenterMembersHeaders();
            return await CampusListRenterMembersWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新园区项目
         *
         * @param request CampusUpdateCampusRequest
         * @param headers CampusUpdateCampusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CampusUpdateCampusResponse
         */
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

        /**
         * @summary 更新园区项目
         *
         * @param request CampusUpdateCampusRequest
         * @param headers CampusUpdateCampusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CampusUpdateCampusResponse
         */
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

        /**
         * @summary 更新园区项目
         *
         * @param request CampusUpdateCampusRequest
         * @return CampusUpdateCampusResponse
         */
        public CampusUpdateCampusResponse CampusUpdateCampus(CampusUpdateCampusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusUpdateCampusHeaders headers = new CampusUpdateCampusHeaders();
            return CampusUpdateCampusWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新园区项目
         *
         * @param request CampusUpdateCampusRequest
         * @return CampusUpdateCampusResponse
         */
        public async Task<CampusUpdateCampusResponse> CampusUpdateCampusAsync(CampusUpdateCampusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusUpdateCampusHeaders headers = new CampusUpdateCampusHeaders();
            return await CampusUpdateCampusWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新园区项目组
         *
         * @param request CampusUpdateCampusGroupRequest
         * @param headers CampusUpdateCampusGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CampusUpdateCampusGroupResponse
         */
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

        /**
         * @summary 更新园区项目组
         *
         * @param request CampusUpdateCampusGroupRequest
         * @param headers CampusUpdateCampusGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CampusUpdateCampusGroupResponse
         */
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

        /**
         * @summary 更新园区项目组
         *
         * @param request CampusUpdateCampusGroupRequest
         * @return CampusUpdateCampusGroupResponse
         */
        public CampusUpdateCampusGroupResponse CampusUpdateCampusGroup(CampusUpdateCampusGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusUpdateCampusGroupHeaders headers = new CampusUpdateCampusGroupHeaders();
            return CampusUpdateCampusGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新园区项目组
         *
         * @param request CampusUpdateCampusGroupRequest
         * @return CampusUpdateCampusGroupResponse
         */
        public async Task<CampusUpdateCampusGroupResponse> CampusUpdateCampusGroupAsync(CampusUpdateCampusGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusUpdateCampusGroupHeaders headers = new CampusUpdateCampusGroupHeaders();
            return await CampusUpdateCampusGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新租客
         *
         * @param request CampusUpdateRenterRequest
         * @param headers CampusUpdateRenterHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CampusUpdateRenterResponse
         */
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

        /**
         * @summary 更新租客
         *
         * @param request CampusUpdateRenterRequest
         * @param headers CampusUpdateRenterHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CampusUpdateRenterResponse
         */
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

        /**
         * @summary 更新租客
         *
         * @param request CampusUpdateRenterRequest
         * @return CampusUpdateRenterResponse
         */
        public CampusUpdateRenterResponse CampusUpdateRenter(CampusUpdateRenterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusUpdateRenterHeaders headers = new CampusUpdateRenterHeaders();
            return CampusUpdateRenterWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新租客
         *
         * @param request CampusUpdateRenterRequest
         * @return CampusUpdateRenterResponse
         */
        public async Task<CampusUpdateRenterResponse> CampusUpdateRenterAsync(CampusUpdateRenterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusUpdateRenterHeaders headers = new CampusUpdateRenterHeaders();
            return await CampusUpdateRenterWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新租客下成员
         *
         * @param request CampusUpdateRenterMemberRequest
         * @param headers CampusUpdateRenterMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CampusUpdateRenterMemberResponse
         */
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

        /**
         * @summary 更新租客下成员
         *
         * @param request CampusUpdateRenterMemberRequest
         * @param headers CampusUpdateRenterMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CampusUpdateRenterMemberResponse
         */
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

        /**
         * @summary 更新租客下成员
         *
         * @param request CampusUpdateRenterMemberRequest
         * @return CampusUpdateRenterMemberResponse
         */
        public CampusUpdateRenterMemberResponse CampusUpdateRenterMember(CampusUpdateRenterMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusUpdateRenterMemberHeaders headers = new CampusUpdateRenterMemberHeaders();
            return CampusUpdateRenterMemberWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新租客下成员
         *
         * @param request CampusUpdateRenterMemberRequest
         * @return CampusUpdateRenterMemberResponse
         */
        public async Task<CampusUpdateRenterMemberResponse> CampusUpdateRenterMemberAsync(CampusUpdateRenterMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusUpdateRenterMemberHeaders headers = new CampusUpdateRenterMemberHeaders();
            return await CampusUpdateRenterMemberWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary ChatForm查询表单识别结果
         *
         * @param request ChatFormGetDataForApiAccessRequest
         * @param headers ChatFormGetDataForApiAccessHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChatFormGetDataForApiAccessResponse
         */
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

        /**
         * @summary ChatForm查询表单识别结果
         *
         * @param request ChatFormGetDataForApiAccessRequest
         * @param headers ChatFormGetDataForApiAccessHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChatFormGetDataForApiAccessResponse
         */
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

        /**
         * @summary ChatForm查询表单识别结果
         *
         * @param request ChatFormGetDataForApiAccessRequest
         * @return ChatFormGetDataForApiAccessResponse
         */
        public ChatFormGetDataForApiAccessResponse ChatFormGetDataForApiAccess(ChatFormGetDataForApiAccessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatFormGetDataForApiAccessHeaders headers = new ChatFormGetDataForApiAccessHeaders();
            return ChatFormGetDataForApiAccessWithOptions(request, headers, runtime);
        }

        /**
         * @summary ChatForm查询表单识别结果
         *
         * @param request ChatFormGetDataForApiAccessRequest
         * @return ChatFormGetDataForApiAccessResponse
         */
        public async Task<ChatFormGetDataForApiAccessResponse> ChatFormGetDataForApiAccessAsync(ChatFormGetDataForApiAccessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatFormGetDataForApiAccessHeaders headers = new ChatFormGetDataForApiAccessHeaders();
            return await ChatFormGetDataForApiAccessWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 新增普通文件
         *
         * @param request ChatMemoAddGeneralFileRequest
         * @param headers ChatMemoAddGeneralFileHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChatMemoAddGeneralFileResponse
         */
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

        /**
         * @summary 新增普通文件
         *
         * @param request ChatMemoAddGeneralFileRequest
         * @param headers ChatMemoAddGeneralFileHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChatMemoAddGeneralFileResponse
         */
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

        /**
         * @summary 新增普通文件
         *
         * @param request ChatMemoAddGeneralFileRequest
         * @return ChatMemoAddGeneralFileResponse
         */
        public ChatMemoAddGeneralFileResponse ChatMemoAddGeneralFile(ChatMemoAddGeneralFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatMemoAddGeneralFileHeaders headers = new ChatMemoAddGeneralFileHeaders();
            return ChatMemoAddGeneralFileWithOptions(request, headers, runtime);
        }

        /**
         * @summary 新增普通文件
         *
         * @param request ChatMemoAddGeneralFileRequest
         * @return ChatMemoAddGeneralFileResponse
         */
        public async Task<ChatMemoAddGeneralFileResponse> ChatMemoAddGeneralFileAsync(ChatMemoAddGeneralFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatMemoAddGeneralFileHeaders headers = new ChatMemoAddGeneralFileHeaders();
            return await ChatMemoAddGeneralFileWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除普通文件
         *
         * @param request ChatMemoDeleteGeneralFileRequest
         * @param headers ChatMemoDeleteGeneralFileHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChatMemoDeleteGeneralFileResponse
         */
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

        /**
         * @summary 删除普通文件
         *
         * @param request ChatMemoDeleteGeneralFileRequest
         * @param headers ChatMemoDeleteGeneralFileHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChatMemoDeleteGeneralFileResponse
         */
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

        /**
         * @summary 删除普通文件
         *
         * @param request ChatMemoDeleteGeneralFileRequest
         * @return ChatMemoDeleteGeneralFileResponse
         */
        public ChatMemoDeleteGeneralFileResponse ChatMemoDeleteGeneralFile(ChatMemoDeleteGeneralFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatMemoDeleteGeneralFileHeaders headers = new ChatMemoDeleteGeneralFileHeaders();
            return ChatMemoDeleteGeneralFileWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除普通文件
         *
         * @param request ChatMemoDeleteGeneralFileRequest
         * @return ChatMemoDeleteGeneralFileResponse
         */
        public async Task<ChatMemoDeleteGeneralFileResponse> ChatMemoDeleteGeneralFileAsync(ChatMemoDeleteGeneralFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatMemoDeleteGeneralFileHeaders headers = new ChatMemoDeleteGeneralFileHeaders();
            return await ChatMemoDeleteGeneralFileWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 新增 FAQ
         *
         * @param request ChatMemoFaqAddRequest
         * @param headers ChatMemoFaqAddHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChatMemoFaqAddResponse
         */
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

        /**
         * @summary 新增 FAQ
         *
         * @param request ChatMemoFaqAddRequest
         * @param headers ChatMemoFaqAddHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChatMemoFaqAddResponse
         */
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

        /**
         * @summary 新增 FAQ
         *
         * @param request ChatMemoFaqAddRequest
         * @return ChatMemoFaqAddResponse
         */
        public ChatMemoFaqAddResponse ChatMemoFaqAdd(ChatMemoFaqAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatMemoFaqAddHeaders headers = new ChatMemoFaqAddHeaders();
            return ChatMemoFaqAddWithOptions(request, headers, runtime);
        }

        /**
         * @summary 新增 FAQ
         *
         * @param request ChatMemoFaqAddRequest
         * @return ChatMemoFaqAddResponse
         */
        public async Task<ChatMemoFaqAddResponse> ChatMemoFaqAddAsync(ChatMemoFaqAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatMemoFaqAddHeaders headers = new ChatMemoFaqAddHeaders();
            return await ChatMemoFaqAddWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除指定数据集中的FAQ
         *
         * @param request ChatMemoFaqDeleteRequest
         * @param headers ChatMemoFaqDeleteHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChatMemoFaqDeleteResponse
         */
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

        /**
         * @summary 删除指定数据集中的FAQ
         *
         * @param request ChatMemoFaqDeleteRequest
         * @param headers ChatMemoFaqDeleteHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChatMemoFaqDeleteResponse
         */
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

        /**
         * @summary 删除指定数据集中的FAQ
         *
         * @param request ChatMemoFaqDeleteRequest
         * @return ChatMemoFaqDeleteResponse
         */
        public ChatMemoFaqDeleteResponse ChatMemoFaqDelete(ChatMemoFaqDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatMemoFaqDeleteHeaders headers = new ChatMemoFaqDeleteHeaders();
            return ChatMemoFaqDeleteWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除指定数据集中的FAQ
         *
         * @param request ChatMemoFaqDeleteRequest
         * @return ChatMemoFaqDeleteResponse
         */
        public async Task<ChatMemoFaqDeleteResponse> ChatMemoFaqDeleteAsync(ChatMemoFaqDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatMemoFaqDeleteHeaders headers = new ChatMemoFaqDeleteHeaders();
            return await ChatMemoFaqDeleteWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询指定数据集中的FAQ列表
         *
         * @param request ChatMemoFaqListRequest
         * @param headers ChatMemoFaqListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChatMemoFaqListResponse
         */
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

        /**
         * @summary 查询指定数据集中的FAQ列表
         *
         * @param request ChatMemoFaqListRequest
         * @param headers ChatMemoFaqListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChatMemoFaqListResponse
         */
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

        /**
         * @summary 查询指定数据集中的FAQ列表
         *
         * @param request ChatMemoFaqListRequest
         * @return ChatMemoFaqListResponse
         */
        public ChatMemoFaqListResponse ChatMemoFaqList(ChatMemoFaqListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatMemoFaqListHeaders headers = new ChatMemoFaqListHeaders();
            return ChatMemoFaqListWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询指定数据集中的FAQ列表
         *
         * @param request ChatMemoFaqListRequest
         * @return ChatMemoFaqListResponse
         */
        public async Task<ChatMemoFaqListResponse> ChatMemoFaqListAsync(ChatMemoFaqListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatMemoFaqListHeaders headers = new ChatMemoFaqListHeaders();
            return await ChatMemoFaqListWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询指定数据集中的文件列表
         *
         * @param request ChatMemoGetFileListRequest
         * @param headers ChatMemoGetFileListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChatMemoGetFileListResponse
         */
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

        /**
         * @summary 查询指定数据集中的文件列表
         *
         * @param request ChatMemoGetFileListRequest
         * @param headers ChatMemoGetFileListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChatMemoGetFileListResponse
         */
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

        /**
         * @summary 查询指定数据集中的文件列表
         *
         * @param request ChatMemoGetFileListRequest
         * @return ChatMemoGetFileListResponse
         */
        public ChatMemoGetFileListResponse ChatMemoGetFileList(ChatMemoGetFileListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatMemoGetFileListHeaders headers = new ChatMemoGetFileListHeaders();
            return ChatMemoGetFileListWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询指定数据集中的文件列表
         *
         * @param request ChatMemoGetFileListRequest
         * @return ChatMemoGetFileListResponse
         */
        public async Task<ChatMemoGetFileListResponse> ChatMemoGetFileListAsync(ChatMemoGetFileListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatMemoGetFileListHeaders headers = new ChatMemoGetFileListHeaders();
            return await ChatMemoGetFileListWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取文件状态
         *
         * @param request ChatMemoGetFileStatusRequest
         * @param headers ChatMemoGetFileStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChatMemoGetFileStatusResponse
         */
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

        /**
         * @summary 获取文件状态
         *
         * @param request ChatMemoGetFileStatusRequest
         * @param headers ChatMemoGetFileStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChatMemoGetFileStatusResponse
         */
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

        /**
         * @summary 获取文件状态
         *
         * @param request ChatMemoGetFileStatusRequest
         * @return ChatMemoGetFileStatusResponse
         */
        public ChatMemoGetFileStatusResponse ChatMemoGetFileStatus(ChatMemoGetFileStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatMemoGetFileStatusHeaders headers = new ChatMemoGetFileStatusHeaders();
            return ChatMemoGetFileStatusWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取文件状态
         *
         * @param request ChatMemoGetFileStatusRequest
         * @return ChatMemoGetFileStatusResponse
         */
        public async Task<ChatMemoGetFileStatusResponse> ChatMemoGetFileStatusAsync(ChatMemoGetFileStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatMemoGetFileStatusHeaders headers = new ChatMemoGetFileStatusHeaders();
            return await ChatMemoGetFileStatusWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 开启学段/学院/年级/专业\系/班级群
         *
         * @param request CollegeActiveCollegeDeptGroupRequest
         * @param headers CollegeActiveCollegeDeptGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeActiveCollegeDeptGroupResponse
         */
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

        /**
         * @summary 开启学段/学院/年级/专业\系/班级群
         *
         * @param request CollegeActiveCollegeDeptGroupRequest
         * @param headers CollegeActiveCollegeDeptGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeActiveCollegeDeptGroupResponse
         */
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

        /**
         * @summary 开启学段/学院/年级/专业\系/班级群
         *
         * @param request CollegeActiveCollegeDeptGroupRequest
         * @return CollegeActiveCollegeDeptGroupResponse
         */
        public CollegeActiveCollegeDeptGroupResponse CollegeActiveCollegeDeptGroup(CollegeActiveCollegeDeptGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeActiveCollegeDeptGroupHeaders headers = new CollegeActiveCollegeDeptGroupHeaders();
            return CollegeActiveCollegeDeptGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary 开启学段/学院/年级/专业\系/班级群
         *
         * @param request CollegeActiveCollegeDeptGroupRequest
         * @return CollegeActiveCollegeDeptGroupResponse
         */
        public async Task<CollegeActiveCollegeDeptGroupResponse> CollegeActiveCollegeDeptGroupAsync(CollegeActiveCollegeDeptGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeActiveCollegeDeptGroupHeaders headers = new CollegeActiveCollegeDeptGroupHeaders();
            return await CollegeActiveCollegeDeptGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建学段/学院/年级/专业\系/班级
         *
         * @param request CollegeAddCollegeDeptRequest
         * @param headers CollegeAddCollegeDeptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeAddCollegeDeptResponse
         */
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

        /**
         * @summary 创建学段/学院/年级/专业\系/班级
         *
         * @param request CollegeAddCollegeDeptRequest
         * @param headers CollegeAddCollegeDeptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeAddCollegeDeptResponse
         */
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

        /**
         * @summary 创建学段/学院/年级/专业\系/班级
         *
         * @param request CollegeAddCollegeDeptRequest
         * @return CollegeAddCollegeDeptResponse
         */
        public CollegeAddCollegeDeptResponse CollegeAddCollegeDept(CollegeAddCollegeDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeAddCollegeDeptHeaders headers = new CollegeAddCollegeDeptHeaders();
            return CollegeAddCollegeDeptWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建学段/学院/年级/专业\系/班级
         *
         * @param request CollegeAddCollegeDeptRequest
         * @return CollegeAddCollegeDeptResponse
         */
        public async Task<CollegeAddCollegeDeptResponse> CollegeAddCollegeDeptAsync(CollegeAddCollegeDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeAddCollegeDeptHeaders headers = new CollegeAddCollegeDeptHeaders();
            return await CollegeAddCollegeDeptWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 往部门中添加负责人
         *
         * @param request CollegeAddManagerRequest
         * @param headers CollegeAddManagerHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeAddManagerResponse
         */
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

        /**
         * @summary 往部门中添加负责人
         *
         * @param request CollegeAddManagerRequest
         * @param headers CollegeAddManagerHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeAddManagerResponse
         */
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

        /**
         * @summary 往部门中添加负责人
         *
         * @param request CollegeAddManagerRequest
         * @return CollegeAddManagerResponse
         */
        public CollegeAddManagerResponse CollegeAddManager(CollegeAddManagerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeAddManagerHeaders headers = new CollegeAddManagerHeaders();
            return CollegeAddManagerWithOptions(request, headers, runtime);
        }

        /**
         * @summary 往部门中添加负责人
         *
         * @param request CollegeAddManagerRequest
         * @return CollegeAddManagerResponse
         */
        public async Task<CollegeAddManagerResponse> CollegeAddManagerAsync(CollegeAddManagerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeAddManagerHeaders headers = new CollegeAddManagerHeaders();
            return await CollegeAddManagerWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 在班级中添加人员
         *
         * @param request CollegeAddStudentRequest
         * @param headers CollegeAddStudentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeAddStudentResponse
         */
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

        /**
         * @summary 在班级中添加人员
         *
         * @param request CollegeAddStudentRequest
         * @param headers CollegeAddStudentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeAddStudentResponse
         */
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

        /**
         * @summary 在班级中添加人员
         *
         * @param request CollegeAddStudentRequest
         * @return CollegeAddStudentResponse
         */
        public CollegeAddStudentResponse CollegeAddStudent(CollegeAddStudentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeAddStudentHeaders headers = new CollegeAddStudentHeaders();
            return CollegeAddStudentWithOptions(request, headers, runtime);
        }

        /**
         * @summary 在班级中添加人员
         *
         * @param request CollegeAddStudentRequest
         * @return CollegeAddStudentResponse
         */
        public async Task<CollegeAddStudentResponse> CollegeAddStudentAsync(CollegeAddStudentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeAddStudentHeaders headers = new CollegeAddStudentHeaders();
            return await CollegeAddStudentWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 移动学生到其他部门
         *
         * @param request CollegeChangeStudentDeptRequest
         * @param headers CollegeChangeStudentDeptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeChangeStudentDeptResponse
         */
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

        /**
         * @summary 移动学生到其他部门
         *
         * @param request CollegeChangeStudentDeptRequest
         * @param headers CollegeChangeStudentDeptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeChangeStudentDeptResponse
         */
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

        /**
         * @summary 移动学生到其他部门
         *
         * @param request CollegeChangeStudentDeptRequest
         * @return CollegeChangeStudentDeptResponse
         */
        public CollegeChangeStudentDeptResponse CollegeChangeStudentDept(CollegeChangeStudentDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeChangeStudentDeptHeaders headers = new CollegeChangeStudentDeptHeaders();
            return CollegeChangeStudentDeptWithOptions(request, headers, runtime);
        }

        /**
         * @summary 移动学生到其他部门
         *
         * @param request CollegeChangeStudentDeptRequest
         * @return CollegeChangeStudentDeptResponse
         */
        public async Task<CollegeChangeStudentDeptResponse> CollegeChangeStudentDeptAsync(CollegeChangeStudentDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeChangeStudentDeptHeaders headers = new CollegeChangeStudentDeptHeaders();
            return await CollegeChangeStudentDeptWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除学段/学院/年级/专业\系/班级
         *
         * @param request CollegeDeleteCollegeDeptRequest
         * @param headers CollegeDeleteCollegeDeptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeDeleteCollegeDeptResponse
         */
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

        /**
         * @summary 删除学段/学院/年级/专业\系/班级
         *
         * @param request CollegeDeleteCollegeDeptRequest
         * @param headers CollegeDeleteCollegeDeptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeDeleteCollegeDeptResponse
         */
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

        /**
         * @summary 删除学段/学院/年级/专业\系/班级
         *
         * @param request CollegeDeleteCollegeDeptRequest
         * @return CollegeDeleteCollegeDeptResponse
         */
        public CollegeDeleteCollegeDeptResponse CollegeDeleteCollegeDept(CollegeDeleteCollegeDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeDeleteCollegeDeptHeaders headers = new CollegeDeleteCollegeDeptHeaders();
            return CollegeDeleteCollegeDeptWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除学段/学院/年级/专业\系/班级
         *
         * @param request CollegeDeleteCollegeDeptRequest
         * @return CollegeDeleteCollegeDeptResponse
         */
        public async Task<CollegeDeleteCollegeDeptResponse> CollegeDeleteCollegeDeptAsync(CollegeDeleteCollegeDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeDeleteCollegeDeptHeaders headers = new CollegeDeleteCollegeDeptHeaders();
            return await CollegeDeleteCollegeDeptWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取下级节点列表
         *
         * @param request CollegeListCollegeSubDeptRequest
         * @param headers CollegeListCollegeSubDeptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeListCollegeSubDeptResponse
         */
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

        /**
         * @summary 获取下级节点列表
         *
         * @param request CollegeListCollegeSubDeptRequest
         * @param headers CollegeListCollegeSubDeptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeListCollegeSubDeptResponse
         */
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

        /**
         * @summary 获取下级节点列表
         *
         * @param request CollegeListCollegeSubDeptRequest
         * @return CollegeListCollegeSubDeptResponse
         */
        public CollegeListCollegeSubDeptResponse CollegeListCollegeSubDept(CollegeListCollegeSubDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeListCollegeSubDeptHeaders headers = new CollegeListCollegeSubDeptHeaders();
            return CollegeListCollegeSubDeptWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取下级节点列表
         *
         * @param request CollegeListCollegeSubDeptRequest
         * @return CollegeListCollegeSubDeptResponse
         */
        public async Task<CollegeListCollegeSubDeptResponse> CollegeListCollegeSubDeptAsync(CollegeListCollegeSubDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeListCollegeSubDeptHeaders headers = new CollegeListCollegeSubDeptHeaders();
            return await CollegeListCollegeSubDeptWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取部门下所有负责人列表
         *
         * @param request CollegeListDeptManagerRequest
         * @param headers CollegeListDeptManagerHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeListDeptManagerResponse
         */
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

        /**
         * @summary 获取部门下所有负责人列表
         *
         * @param request CollegeListDeptManagerRequest
         * @param headers CollegeListDeptManagerHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeListDeptManagerResponse
         */
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

        /**
         * @summary 获取部门下所有负责人列表
         *
         * @param request CollegeListDeptManagerRequest
         * @return CollegeListDeptManagerResponse
         */
        public CollegeListDeptManagerResponse CollegeListDeptManager(CollegeListDeptManagerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeListDeptManagerHeaders headers = new CollegeListDeptManagerHeaders();
            return CollegeListDeptManagerWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取部门下所有负责人列表
         *
         * @param request CollegeListDeptManagerRequest
         * @return CollegeListDeptManagerResponse
         */
        public async Task<CollegeListDeptManagerResponse> CollegeListDeptManagerAsync(CollegeListDeptManagerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeListDeptManagerHeaders headers = new CollegeListDeptManagerHeaders();
            return await CollegeListDeptManagerWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 分页获取班级下所有学生列表
         *
         * @param request CollegeListStudentInfoRequest
         * @param headers CollegeListStudentInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeListStudentInfoResponse
         */
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

        /**
         * @summary 分页获取班级下所有学生列表
         *
         * @param request CollegeListStudentInfoRequest
         * @param headers CollegeListStudentInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeListStudentInfoResponse
         */
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

        /**
         * @summary 分页获取班级下所有学生列表
         *
         * @param request CollegeListStudentInfoRequest
         * @return CollegeListStudentInfoResponse
         */
        public CollegeListStudentInfoResponse CollegeListStudentInfo(CollegeListStudentInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeListStudentInfoHeaders headers = new CollegeListStudentInfoHeaders();
            return CollegeListStudentInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 分页获取班级下所有学生列表
         *
         * @param request CollegeListStudentInfoRequest
         * @return CollegeListStudentInfoResponse
         */
        public async Task<CollegeListStudentInfoResponse> CollegeListStudentInfoAsync(CollegeListStudentInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeListStudentInfoHeaders headers = new CollegeListStudentInfoHeaders();
            return await CollegeListStudentInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 分页查询未加入组织的学生列表
         *
         * @param request CollegeListUncheckedStudentRequest
         * @param headers CollegeListUncheckedStudentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeListUncheckedStudentResponse
         */
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

        /**
         * @summary 分页查询未加入组织的学生列表
         *
         * @param request CollegeListUncheckedStudentRequest
         * @param headers CollegeListUncheckedStudentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeListUncheckedStudentResponse
         */
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

        /**
         * @summary 分页查询未加入组织的学生列表
         *
         * @param request CollegeListUncheckedStudentRequest
         * @return CollegeListUncheckedStudentResponse
         */
        public CollegeListUncheckedStudentResponse CollegeListUncheckedStudent(CollegeListUncheckedStudentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeListUncheckedStudentHeaders headers = new CollegeListUncheckedStudentHeaders();
            return CollegeListUncheckedStudentWithOptions(request, headers, runtime);
        }

        /**
         * @summary 分页查询未加入组织的学生列表
         *
         * @param request CollegeListUncheckedStudentRequest
         * @return CollegeListUncheckedStudentResponse
         */
        public async Task<CollegeListUncheckedStudentResponse> CollegeListUncheckedStudentAsync(CollegeListUncheckedStudentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeListUncheckedStudentHeaders headers = new CollegeListUncheckedStudentHeaders();
            return await CollegeListUncheckedStudentWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取学段/学院/年级/专业\系/班级群群信息
         *
         * @param request CollegeQueryCollegeDeptGroupInfoRequest
         * @param headers CollegeQueryCollegeDeptGroupInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeQueryCollegeDeptGroupInfoResponse
         */
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

        /**
         * @summary 获取学段/学院/年级/专业\系/班级群群信息
         *
         * @param request CollegeQueryCollegeDeptGroupInfoRequest
         * @param headers CollegeQueryCollegeDeptGroupInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeQueryCollegeDeptGroupInfoResponse
         */
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

        /**
         * @summary 获取学段/学院/年级/专业\系/班级群群信息
         *
         * @param request CollegeQueryCollegeDeptGroupInfoRequest
         * @return CollegeQueryCollegeDeptGroupInfoResponse
         */
        public CollegeQueryCollegeDeptGroupInfoResponse CollegeQueryCollegeDeptGroupInfo(CollegeQueryCollegeDeptGroupInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeQueryCollegeDeptGroupInfoHeaders headers = new CollegeQueryCollegeDeptGroupInfoHeaders();
            return CollegeQueryCollegeDeptGroupInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取学段/学院/年级/专业\系/班级群群信息
         *
         * @param request CollegeQueryCollegeDeptGroupInfoRequest
         * @return CollegeQueryCollegeDeptGroupInfoResponse
         */
        public async Task<CollegeQueryCollegeDeptGroupInfoResponse> CollegeQueryCollegeDeptGroupInfoAsync(CollegeQueryCollegeDeptGroupInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeQueryCollegeDeptGroupInfoHeaders headers = new CollegeQueryCollegeDeptGroupInfoHeaders();
            return await CollegeQueryCollegeDeptGroupInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取学段/学院/年级/专业\系/班级信息
         *
         * @param request CollegeQueryCollegeDeptInfoRequest
         * @param headers CollegeQueryCollegeDeptInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeQueryCollegeDeptInfoResponse
         */
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

        /**
         * @summary 获取学段/学院/年级/专业\系/班级信息
         *
         * @param request CollegeQueryCollegeDeptInfoRequest
         * @param headers CollegeQueryCollegeDeptInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeQueryCollegeDeptInfoResponse
         */
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

        /**
         * @summary 获取学段/学院/年级/专业\系/班级信息
         *
         * @param request CollegeQueryCollegeDeptInfoRequest
         * @return CollegeQueryCollegeDeptInfoResponse
         */
        public CollegeQueryCollegeDeptInfoResponse CollegeQueryCollegeDeptInfo(CollegeQueryCollegeDeptInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeQueryCollegeDeptInfoHeaders headers = new CollegeQueryCollegeDeptInfoHeaders();
            return CollegeQueryCollegeDeptInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取学段/学院/年级/专业\系/班级信息
         *
         * @param request CollegeQueryCollegeDeptInfoRequest
         * @return CollegeQueryCollegeDeptInfoResponse
         */
        public async Task<CollegeQueryCollegeDeptInfoResponse> CollegeQueryCollegeDeptInfoAsync(CollegeQueryCollegeDeptInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeQueryCollegeDeptInfoHeaders headers = new CollegeQueryCollegeDeptInfoHeaders();
            return await CollegeQueryCollegeDeptInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取指定部门下指定学生的信息
         *
         * @param request CollegeQueryStudentInfoByDeptRequest
         * @param headers CollegeQueryStudentInfoByDeptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeQueryStudentInfoByDeptResponse
         */
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

        /**
         * @summary 获取指定部门下指定学生的信息
         *
         * @param request CollegeQueryStudentInfoByDeptRequest
         * @param headers CollegeQueryStudentInfoByDeptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeQueryStudentInfoByDeptResponse
         */
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

        /**
         * @summary 获取指定部门下指定学生的信息
         *
         * @param request CollegeQueryStudentInfoByDeptRequest
         * @return CollegeQueryStudentInfoByDeptResponse
         */
        public CollegeQueryStudentInfoByDeptResponse CollegeQueryStudentInfoByDept(CollegeQueryStudentInfoByDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeQueryStudentInfoByDeptHeaders headers = new CollegeQueryStudentInfoByDeptHeaders();
            return CollegeQueryStudentInfoByDeptWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取指定部门下指定学生的信息
         *
         * @param request CollegeQueryStudentInfoByDeptRequest
         * @return CollegeQueryStudentInfoByDeptResponse
         */
        public async Task<CollegeQueryStudentInfoByDeptResponse> CollegeQueryStudentInfoByDeptAsync(CollegeQueryStudentInfoByDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeQueryStudentInfoByDeptHeaders headers = new CollegeQueryStudentInfoByDeptHeaders();
            return await CollegeQueryStudentInfoByDeptWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 根据手机号查询学生信息
         *
         * @param request CollegeQueryStudentInfoByMobileRequest
         * @param headers CollegeQueryStudentInfoByMobileHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeQueryStudentInfoByMobileResponse
         */
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

        /**
         * @summary 根据手机号查询学生信息
         *
         * @param request CollegeQueryStudentInfoByMobileRequest
         * @param headers CollegeQueryStudentInfoByMobileHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeQueryStudentInfoByMobileResponse
         */
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

        /**
         * @summary 根据手机号查询学生信息
         *
         * @param request CollegeQueryStudentInfoByMobileRequest
         * @return CollegeQueryStudentInfoByMobileResponse
         */
        public CollegeQueryStudentInfoByMobileResponse CollegeQueryStudentInfoByMobile(CollegeQueryStudentInfoByMobileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeQueryStudentInfoByMobileHeaders headers = new CollegeQueryStudentInfoByMobileHeaders();
            return CollegeQueryStudentInfoByMobileWithOptions(request, headers, runtime);
        }

        /**
         * @summary 根据手机号查询学生信息
         *
         * @param request CollegeQueryStudentInfoByMobileRequest
         * @return CollegeQueryStudentInfoByMobileResponse
         */
        public async Task<CollegeQueryStudentInfoByMobileResponse> CollegeQueryStudentInfoByMobileAsync(CollegeQueryStudentInfoByMobileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeQueryStudentInfoByMobileHeaders headers = new CollegeQueryStudentInfoByMobileHeaders();
            return await CollegeQueryStudentInfoByMobileWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 根据studentId查询学生信息
         *
         * @param request CollegeQueryStudentInfoByStudentIdRequest
         * @param headers CollegeQueryStudentInfoByStudentIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeQueryStudentInfoByStudentIdResponse
         */
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

        /**
         * @summary 根据studentId查询学生信息
         *
         * @param request CollegeQueryStudentInfoByStudentIdRequest
         * @param headers CollegeQueryStudentInfoByStudentIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeQueryStudentInfoByStudentIdResponse
         */
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

        /**
         * @summary 根据studentId查询学生信息
         *
         * @param request CollegeQueryStudentInfoByStudentIdRequest
         * @return CollegeQueryStudentInfoByStudentIdResponse
         */
        public CollegeQueryStudentInfoByStudentIdResponse CollegeQueryStudentInfoByStudentId(CollegeQueryStudentInfoByStudentIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeQueryStudentInfoByStudentIdHeaders headers = new CollegeQueryStudentInfoByStudentIdHeaders();
            return CollegeQueryStudentInfoByStudentIdWithOptions(request, headers, runtime);
        }

        /**
         * @summary 根据studentId查询学生信息
         *
         * @param request CollegeQueryStudentInfoByStudentIdRequest
         * @return CollegeQueryStudentInfoByStudentIdResponse
         */
        public async Task<CollegeQueryStudentInfoByStudentIdResponse> CollegeQueryStudentInfoByStudentIdAsync(CollegeQueryStudentInfoByStudentIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeQueryStudentInfoByStudentIdHeaders headers = new CollegeQueryStudentInfoByStudentIdHeaders();
            return await CollegeQueryStudentInfoByStudentIdWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 从部门中移除负责人
         *
         * @param request CollegeRemoveManagerRequest
         * @param headers CollegeRemoveManagerHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeRemoveManagerResponse
         */
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

        /**
         * @summary 从部门中移除负责人
         *
         * @param request CollegeRemoveManagerRequest
         * @param headers CollegeRemoveManagerHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeRemoveManagerResponse
         */
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

        /**
         * @summary 从部门中移除负责人
         *
         * @param request CollegeRemoveManagerRequest
         * @return CollegeRemoveManagerResponse
         */
        public CollegeRemoveManagerResponse CollegeRemoveManager(CollegeRemoveManagerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeRemoveManagerHeaders headers = new CollegeRemoveManagerHeaders();
            return CollegeRemoveManagerWithOptions(request, headers, runtime);
        }

        /**
         * @summary 从部门中移除负责人
         *
         * @param request CollegeRemoveManagerRequest
         * @return CollegeRemoveManagerResponse
         */
        public async Task<CollegeRemoveManagerResponse> CollegeRemoveManagerAsync(CollegeRemoveManagerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeRemoveManagerHeaders headers = new CollegeRemoveManagerHeaders();
            return await CollegeRemoveManagerWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 从部门中移除学生
         *
         * @param request CollegeRemoveStudentRequest
         * @param headers CollegeRemoveStudentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeRemoveStudentResponse
         */
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

        /**
         * @summary 从部门中移除学生
         *
         * @param request CollegeRemoveStudentRequest
         * @param headers CollegeRemoveStudentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeRemoveStudentResponse
         */
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

        /**
         * @summary 从部门中移除学生
         *
         * @param request CollegeRemoveStudentRequest
         * @return CollegeRemoveStudentResponse
         */
        public CollegeRemoveStudentResponse CollegeRemoveStudent(CollegeRemoveStudentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeRemoveStudentHeaders headers = new CollegeRemoveStudentHeaders();
            return CollegeRemoveStudentWithOptions(request, headers, runtime);
        }

        /**
         * @summary 从部门中移除学生
         *
         * @param request CollegeRemoveStudentRequest
         * @return CollegeRemoveStudentResponse
         */
        public async Task<CollegeRemoveStudentResponse> CollegeRemoveStudentAsync(CollegeRemoveStudentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeRemoveStudentHeaders headers = new CollegeRemoveStudentHeaders();
            return await CollegeRemoveStudentWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 编辑学段/学院/年级/专业\系/班级
         *
         * @param request CollegeUpdateCollegeDeptRequest
         * @param headers CollegeUpdateCollegeDeptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeUpdateCollegeDeptResponse
         */
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

        /**
         * @summary 编辑学段/学院/年级/专业\系/班级
         *
         * @param request CollegeUpdateCollegeDeptRequest
         * @param headers CollegeUpdateCollegeDeptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeUpdateCollegeDeptResponse
         */
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

        /**
         * @summary 编辑学段/学院/年级/专业\系/班级
         *
         * @param request CollegeUpdateCollegeDeptRequest
         * @return CollegeUpdateCollegeDeptResponse
         */
        public CollegeUpdateCollegeDeptResponse CollegeUpdateCollegeDept(CollegeUpdateCollegeDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeUpdateCollegeDeptHeaders headers = new CollegeUpdateCollegeDeptHeaders();
            return CollegeUpdateCollegeDeptWithOptions(request, headers, runtime);
        }

        /**
         * @summary 编辑学段/学院/年级/专业\系/班级
         *
         * @param request CollegeUpdateCollegeDeptRequest
         * @return CollegeUpdateCollegeDeptResponse
         */
        public async Task<CollegeUpdateCollegeDeptResponse> CollegeUpdateCollegeDeptAsync(CollegeUpdateCollegeDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeUpdateCollegeDeptHeaders headers = new CollegeUpdateCollegeDeptHeaders();
            return await CollegeUpdateCollegeDeptWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新学生的部门相关信息
         *
         * @param request CollegeUpdateStudentDeptInfoRequest
         * @param headers CollegeUpdateStudentDeptInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeUpdateStudentDeptInfoResponse
         */
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

        /**
         * @summary 更新学生的部门相关信息
         *
         * @param request CollegeUpdateStudentDeptInfoRequest
         * @param headers CollegeUpdateStudentDeptInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeUpdateStudentDeptInfoResponse
         */
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

        /**
         * @summary 更新学生的部门相关信息
         *
         * @param request CollegeUpdateStudentDeptInfoRequest
         * @return CollegeUpdateStudentDeptInfoResponse
         */
        public CollegeUpdateStudentDeptInfoResponse CollegeUpdateStudentDeptInfo(CollegeUpdateStudentDeptInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeUpdateStudentDeptInfoHeaders headers = new CollegeUpdateStudentDeptInfoHeaders();
            return CollegeUpdateStudentDeptInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新学生的部门相关信息
         *
         * @param request CollegeUpdateStudentDeptInfoRequest
         * @return CollegeUpdateStudentDeptInfoResponse
         */
        public async Task<CollegeUpdateStudentDeptInfoResponse> CollegeUpdateStudentDeptInfoAsync(CollegeUpdateStudentDeptInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeUpdateStudentDeptInfoHeaders headers = new CollegeUpdateStudentDeptInfoHeaders();
            return await CollegeUpdateStudentDeptInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新班级下学生信息
         *
         * @param request CollegeUpdateStudentInfoRequest
         * @param headers CollegeUpdateStudentInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeUpdateStudentInfoResponse
         */
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

        /**
         * @summary 更新班级下学生信息
         *
         * @param request CollegeUpdateStudentInfoRequest
         * @param headers CollegeUpdateStudentInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeUpdateStudentInfoResponse
         */
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

        /**
         * @summary 更新班级下学生信息
         *
         * @param request CollegeUpdateStudentInfoRequest
         * @return CollegeUpdateStudentInfoResponse
         */
        public CollegeUpdateStudentInfoResponse CollegeUpdateStudentInfo(CollegeUpdateStudentInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeUpdateStudentInfoHeaders headers = new CollegeUpdateStudentInfoHeaders();
            return CollegeUpdateStudentInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新班级下学生信息
         *
         * @param request CollegeUpdateStudentInfoRequest
         * @return CollegeUpdateStudentInfoResponse
         */
        public async Task<CollegeUpdateStudentInfoResponse> CollegeUpdateStudentInfoAsync(CollegeUpdateStudentInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeUpdateStudentInfoHeaders headers = new CollegeUpdateStudentInfoHeaders();
            return await CollegeUpdateStudentInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 修改学生手机号
         *
         * @param request CollegeUpdateStudentMoblieRequest
         * @param headers CollegeUpdateStudentMoblieHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeUpdateStudentMoblieResponse
         */
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

        /**
         * @summary 修改学生手机号
         *
         * @param request CollegeUpdateStudentMoblieRequest
         * @param headers CollegeUpdateStudentMoblieHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CollegeUpdateStudentMoblieResponse
         */
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

        /**
         * @summary 修改学生手机号
         *
         * @param request CollegeUpdateStudentMoblieRequest
         * @return CollegeUpdateStudentMoblieResponse
         */
        public CollegeUpdateStudentMoblieResponse CollegeUpdateStudentMoblie(CollegeUpdateStudentMoblieRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeUpdateStudentMoblieHeaders headers = new CollegeUpdateStudentMoblieHeaders();
            return CollegeUpdateStudentMoblieWithOptions(request, headers, runtime);
        }

        /**
         * @summary 修改学生手机号
         *
         * @param request CollegeUpdateStudentMoblieRequest
         * @return CollegeUpdateStudentMoblieResponse
         */
        public async Task<CollegeUpdateStudentMoblieResponse> CollegeUpdateStudentMoblieAsync(CollegeUpdateStudentMoblieRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeUpdateStudentMoblieHeaders headers = new CollegeUpdateStudentMoblieHeaders();
            return await CollegeUpdateStudentMoblieWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建自定义通讯录
         *
         * @param request CustomizeContactCreateRequest
         * @param headers CustomizeContactCreateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CustomizeContactCreateResponse
         */
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

        /**
         * @summary 创建自定义通讯录
         *
         * @param request CustomizeContactCreateRequest
         * @param headers CustomizeContactCreateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CustomizeContactCreateResponse
         */
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

        /**
         * @summary 创建自定义通讯录
         *
         * @param request CustomizeContactCreateRequest
         * @return CustomizeContactCreateResponse
         */
        public CustomizeContactCreateResponse CustomizeContactCreate(CustomizeContactCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactCreateHeaders headers = new CustomizeContactCreateHeaders();
            return CustomizeContactCreateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建自定义通讯录
         *
         * @param request CustomizeContactCreateRequest
         * @return CustomizeContactCreateResponse
         */
        public async Task<CustomizeContactCreateResponse> CustomizeContactCreateAsync(CustomizeContactCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactCreateHeaders headers = new CustomizeContactCreateHeaders();
            return await CustomizeContactCreateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除自定义通讯录
         *
         * @param request CustomizeContactDeleteRequest
         * @param headers CustomizeContactDeleteHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CustomizeContactDeleteResponse
         */
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

        /**
         * @summary 删除自定义通讯录
         *
         * @param request CustomizeContactDeleteRequest
         * @param headers CustomizeContactDeleteHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CustomizeContactDeleteResponse
         */
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

        /**
         * @summary 删除自定义通讯录
         *
         * @param request CustomizeContactDeleteRequest
         * @return CustomizeContactDeleteResponse
         */
        public CustomizeContactDeleteResponse CustomizeContactDelete(CustomizeContactDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactDeleteHeaders headers = new CustomizeContactDeleteHeaders();
            return CustomizeContactDeleteWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除自定义通讯录
         *
         * @param request CustomizeContactDeleteRequest
         * @return CustomizeContactDeleteResponse
         */
        public async Task<CustomizeContactDeleteResponse> CustomizeContactDeleteAsync(CustomizeContactDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactDeleteHeaders headers = new CustomizeContactDeleteHeaders();
            return await CustomizeContactDeleteWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建部门
         *
         * @param request CustomizeContactDeptCreateRequest
         * @param headers CustomizeContactDeptCreateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CustomizeContactDeptCreateResponse
         */
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

        /**
         * @summary 创建部门
         *
         * @param request CustomizeContactDeptCreateRequest
         * @param headers CustomizeContactDeptCreateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CustomizeContactDeptCreateResponse
         */
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

        /**
         * @summary 创建部门
         *
         * @param request CustomizeContactDeptCreateRequest
         * @return CustomizeContactDeptCreateResponse
         */
        public CustomizeContactDeptCreateResponse CustomizeContactDeptCreate(CustomizeContactDeptCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactDeptCreateHeaders headers = new CustomizeContactDeptCreateHeaders();
            return CustomizeContactDeptCreateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建部门
         *
         * @param request CustomizeContactDeptCreateRequest
         * @return CustomizeContactDeptCreateResponse
         */
        public async Task<CustomizeContactDeptCreateResponse> CustomizeContactDeptCreateAsync(CustomizeContactDeptCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactDeptCreateHeaders headers = new CustomizeContactDeptCreateHeaders();
            return await CustomizeContactDeptCreateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除部门
         *
         * @param request CustomizeContactDeptDeleteRequest
         * @param headers CustomizeContactDeptDeleteHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CustomizeContactDeptDeleteResponse
         */
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

        /**
         * @summary 删除部门
         *
         * @param request CustomizeContactDeptDeleteRequest
         * @param headers CustomizeContactDeptDeleteHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CustomizeContactDeptDeleteResponse
         */
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

        /**
         * @summary 删除部门
         *
         * @param request CustomizeContactDeptDeleteRequest
         * @return CustomizeContactDeptDeleteResponse
         */
        public CustomizeContactDeptDeleteResponse CustomizeContactDeptDelete(CustomizeContactDeptDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactDeptDeleteHeaders headers = new CustomizeContactDeptDeleteHeaders();
            return CustomizeContactDeptDeleteWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除部门
         *
         * @param request CustomizeContactDeptDeleteRequest
         * @return CustomizeContactDeptDeleteResponse
         */
        public async Task<CustomizeContactDeptDeleteResponse> CustomizeContactDeptDeleteAsync(CustomizeContactDeptDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactDeptDeleteHeaders headers = new CustomizeContactDeptDeleteHeaders();
            return await CustomizeContactDeptDeleteWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建自定义通讯录某个部门的部门群
         *
         * @param request CustomizeContactDeptGroupCreateRequest
         * @param headers CustomizeContactDeptGroupCreateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CustomizeContactDeptGroupCreateResponse
         */
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

        /**
         * @summary 创建自定义通讯录某个部门的部门群
         *
         * @param request CustomizeContactDeptGroupCreateRequest
         * @param headers CustomizeContactDeptGroupCreateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CustomizeContactDeptGroupCreateResponse
         */
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

        /**
         * @summary 创建自定义通讯录某个部门的部门群
         *
         * @param request CustomizeContactDeptGroupCreateRequest
         * @return CustomizeContactDeptGroupCreateResponse
         */
        public CustomizeContactDeptGroupCreateResponse CustomizeContactDeptGroupCreate(CustomizeContactDeptGroupCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactDeptGroupCreateHeaders headers = new CustomizeContactDeptGroupCreateHeaders();
            return CustomizeContactDeptGroupCreateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建自定义通讯录某个部门的部门群
         *
         * @param request CustomizeContactDeptGroupCreateRequest
         * @return CustomizeContactDeptGroupCreateResponse
         */
        public async Task<CustomizeContactDeptGroupCreateResponse> CustomizeContactDeptGroupCreateAsync(CustomizeContactDeptGroupCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactDeptGroupCreateHeaders headers = new CustomizeContactDeptGroupCreateHeaders();
            return await CustomizeContactDeptGroupCreateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取部门详情
         *
         * @param request CustomizeContactDeptInfoRequest
         * @param headers CustomizeContactDeptInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CustomizeContactDeptInfoResponse
         */
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

        /**
         * @summary 获取部门详情
         *
         * @param request CustomizeContactDeptInfoRequest
         * @param headers CustomizeContactDeptInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CustomizeContactDeptInfoResponse
         */
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

        /**
         * @summary 获取部门详情
         *
         * @param request CustomizeContactDeptInfoRequest
         * @return CustomizeContactDeptInfoResponse
         */
        public CustomizeContactDeptInfoResponse CustomizeContactDeptInfo(CustomizeContactDeptInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactDeptInfoHeaders headers = new CustomizeContactDeptInfoHeaders();
            return CustomizeContactDeptInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取部门详情
         *
         * @param request CustomizeContactDeptInfoRequest
         * @return CustomizeContactDeptInfoResponse
         */
        public async Task<CustomizeContactDeptInfoResponse> CustomizeContactDeptInfoAsync(CustomizeContactDeptInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactDeptInfoHeaders headers = new CustomizeContactDeptInfoHeaders();
            return await CustomizeContactDeptInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取子部门列表
         *
         * @param request CustomizeContactDeptListRequest
         * @param headers CustomizeContactDeptListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CustomizeContactDeptListResponse
         */
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

        /**
         * @summary 获取子部门列表
         *
         * @param request CustomizeContactDeptListRequest
         * @param headers CustomizeContactDeptListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CustomizeContactDeptListResponse
         */
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

        /**
         * @summary 获取子部门列表
         *
         * @param request CustomizeContactDeptListRequest
         * @return CustomizeContactDeptListResponse
         */
        public CustomizeContactDeptListResponse CustomizeContactDeptList(CustomizeContactDeptListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactDeptListHeaders headers = new CustomizeContactDeptListHeaders();
            return CustomizeContactDeptListWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取子部门列表
         *
         * @param request CustomizeContactDeptListRequest
         * @return CustomizeContactDeptListResponse
         */
        public async Task<CustomizeContactDeptListResponse> CustomizeContactDeptListAsync(CustomizeContactDeptListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactDeptListHeaders headers = new CustomizeContactDeptListHeaders();
            return await CustomizeContactDeptListWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新部门
         *
         * @param request CustomizeContactDeptUpdateRequest
         * @param headers CustomizeContactDeptUpdateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CustomizeContactDeptUpdateResponse
         */
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

        /**
         * @summary 更新部门
         *
         * @param request CustomizeContactDeptUpdateRequest
         * @param headers CustomizeContactDeptUpdateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CustomizeContactDeptUpdateResponse
         */
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

        /**
         * @summary 更新部门
         *
         * @param request CustomizeContactDeptUpdateRequest
         * @return CustomizeContactDeptUpdateResponse
         */
        public CustomizeContactDeptUpdateResponse CustomizeContactDeptUpdate(CustomizeContactDeptUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactDeptUpdateHeaders headers = new CustomizeContactDeptUpdateHeaders();
            return CustomizeContactDeptUpdateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新部门
         *
         * @param request CustomizeContactDeptUpdateRequest
         * @return CustomizeContactDeptUpdateResponse
         */
        public async Task<CustomizeContactDeptUpdateResponse> CustomizeContactDeptUpdateAsync(CustomizeContactDeptUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactDeptUpdateHeaders headers = new CustomizeContactDeptUpdateHeaders();
            return await CustomizeContactDeptUpdateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 普通部门下添加人员
         *
         * @param request CustomizeContactEmpAddRequest
         * @param headers CustomizeContactEmpAddHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CustomizeContactEmpAddResponse
         */
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

        /**
         * @summary 普通部门下添加人员
         *
         * @param request CustomizeContactEmpAddRequest
         * @param headers CustomizeContactEmpAddHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CustomizeContactEmpAddResponse
         */
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

        /**
         * @summary 普通部门下添加人员
         *
         * @param request CustomizeContactEmpAddRequest
         * @return CustomizeContactEmpAddResponse
         */
        public CustomizeContactEmpAddResponse CustomizeContactEmpAdd(CustomizeContactEmpAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactEmpAddHeaders headers = new CustomizeContactEmpAddHeaders();
            return CustomizeContactEmpAddWithOptions(request, headers, runtime);
        }

        /**
         * @summary 普通部门下添加人员
         *
         * @param request CustomizeContactEmpAddRequest
         * @return CustomizeContactEmpAddResponse
         */
        public async Task<CustomizeContactEmpAddResponse> CustomizeContactEmpAddAsync(CustomizeContactEmpAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactEmpAddHeaders headers = new CustomizeContactEmpAddHeaders();
            return await CustomizeContactEmpAddWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 普通部门下移除人员
         *
         * @param request CustomizeContactEmpDeleteRequest
         * @param headers CustomizeContactEmpDeleteHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CustomizeContactEmpDeleteResponse
         */
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

        /**
         * @summary 普通部门下移除人员
         *
         * @param request CustomizeContactEmpDeleteRequest
         * @param headers CustomizeContactEmpDeleteHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CustomizeContactEmpDeleteResponse
         */
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

        /**
         * @summary 普通部门下移除人员
         *
         * @param request CustomizeContactEmpDeleteRequest
         * @return CustomizeContactEmpDeleteResponse
         */
        public CustomizeContactEmpDeleteResponse CustomizeContactEmpDelete(CustomizeContactEmpDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactEmpDeleteHeaders headers = new CustomizeContactEmpDeleteHeaders();
            return CustomizeContactEmpDeleteWithOptions(request, headers, runtime);
        }

        /**
         * @summary 普通部门下移除人员
         *
         * @param request CustomizeContactEmpDeleteRequest
         * @return CustomizeContactEmpDeleteResponse
         */
        public async Task<CustomizeContactEmpDeleteResponse> CustomizeContactEmpDeleteAsync(CustomizeContactEmpDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactEmpDeleteHeaders headers = new CustomizeContactEmpDeleteHeaders();
            return await CustomizeContactEmpDeleteWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询部门下人员
         *
         * @param request CustomizeContactEmpListRequest
         * @param headers CustomizeContactEmpListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CustomizeContactEmpListResponse
         */
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

        /**
         * @summary 查询部门下人员
         *
         * @param request CustomizeContactEmpListRequest
         * @param headers CustomizeContactEmpListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CustomizeContactEmpListResponse
         */
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

        /**
         * @summary 查询部门下人员
         *
         * @param request CustomizeContactEmpListRequest
         * @return CustomizeContactEmpListResponse
         */
        public CustomizeContactEmpListResponse CustomizeContactEmpList(CustomizeContactEmpListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactEmpListHeaders headers = new CustomizeContactEmpListHeaders();
            return CustomizeContactEmpListWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询部门下人员
         *
         * @param request CustomizeContactEmpListRequest
         * @return CustomizeContactEmpListResponse
         */
        public async Task<CustomizeContactEmpListResponse> CustomizeContactEmpListAsync(CustomizeContactEmpListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactEmpListHeaders headers = new CustomizeContactEmpListHeaders();
            return await CustomizeContactEmpListWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取自定义通讯录列表
         *
         * @param headers CustomizeContactListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CustomizeContactListResponse
         */
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

        /**
         * @summary 获取自定义通讯录列表
         *
         * @param headers CustomizeContactListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CustomizeContactListResponse
         */
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

        /**
         * @summary 获取自定义通讯录列表
         *
         * @return CustomizeContactListResponse
         */
        public CustomizeContactListResponse CustomizeContactList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactListHeaders headers = new CustomizeContactListHeaders();
            return CustomizeContactListWithOptions(headers, runtime);
        }

        /**
         * @summary 获取自定义通讯录列表
         *
         * @return CustomizeContactListResponse
         */
        public async Task<CustomizeContactListResponse> CustomizeContactListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactListHeaders headers = new CustomizeContactListHeaders();
            return await CustomizeContactListWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 更新自定义通讯录
         *
         * @param request CustomizeContactUpdateRequest
         * @param headers CustomizeContactUpdateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CustomizeContactUpdateResponse
         */
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

        /**
         * @summary 更新自定义通讯录
         *
         * @param request CustomizeContactUpdateRequest
         * @param headers CustomizeContactUpdateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CustomizeContactUpdateResponse
         */
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

        /**
         * @summary 更新自定义通讯录
         *
         * @param request CustomizeContactUpdateRequest
         * @return CustomizeContactUpdateResponse
         */
        public CustomizeContactUpdateResponse CustomizeContactUpdate(CustomizeContactUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactUpdateHeaders headers = new CustomizeContactUpdateHeaders();
            return CustomizeContactUpdateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新自定义通讯录
         *
         * @param request CustomizeContactUpdateRequest
         * @return CustomizeContactUpdateResponse
         */
        public async Task<CustomizeContactUpdateResponse> CustomizeContactUpdateAsync(CustomizeContactUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactUpdateHeaders headers = new CustomizeContactUpdateHeaders();
            return await CustomizeContactUpdateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 门店通业务消息推送
         *
         * @param tmpReq DIgitalStoreMessagePushRequest
         * @param headers DIgitalStoreMessagePushHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DIgitalStoreMessagePushResponse
         */
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

        /**
         * @summary 门店通业务消息推送
         *
         * @param tmpReq DIgitalStoreMessagePushRequest
         * @param headers DIgitalStoreMessagePushHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DIgitalStoreMessagePushResponse
         */
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

        /**
         * @summary 门店通业务消息推送
         *
         * @param request DIgitalStoreMessagePushRequest
         * @return DIgitalStoreMessagePushResponse
         */
        public DIgitalStoreMessagePushResponse DIgitalStoreMessagePush(DIgitalStoreMessagePushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DIgitalStoreMessagePushHeaders headers = new DIgitalStoreMessagePushHeaders();
            return DIgitalStoreMessagePushWithOptions(request, headers, runtime);
        }

        /**
         * @summary 门店通业务消息推送
         *
         * @param request DIgitalStoreMessagePushRequest
         * @return DIgitalStoreMessagePushResponse
         */
        public async Task<DIgitalStoreMessagePushResponse> DIgitalStoreMessagePushAsync(DIgitalStoreMessagePushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DIgitalStoreMessagePushHeaders headers = new DIgitalStoreMessagePushHeaders();
            return await DIgitalStoreMessagePushWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 群运营-场景卡片发送记录列表
         *
         * @param request DigitalStoreCardRecordRequest
         * @param headers DigitalStoreCardRecordHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DigitalStoreCardRecordResponse
         */
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

        /**
         * @summary 群运营-场景卡片发送记录列表
         *
         * @param request DigitalStoreCardRecordRequest
         * @param headers DigitalStoreCardRecordHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DigitalStoreCardRecordResponse
         */
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

        /**
         * @summary 群运营-场景卡片发送记录列表
         *
         * @param request DigitalStoreCardRecordRequest
         * @return DigitalStoreCardRecordResponse
         */
        public DigitalStoreCardRecordResponse DigitalStoreCardRecord(DigitalStoreCardRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreCardRecordHeaders headers = new DigitalStoreCardRecordHeaders();
            return DigitalStoreCardRecordWithOptions(request, headers, runtime);
        }

        /**
         * @summary 群运营-场景卡片发送记录列表
         *
         * @param request DigitalStoreCardRecordRequest
         * @return DigitalStoreCardRecordResponse
         */
        public async Task<DigitalStoreCardRecordResponse> DigitalStoreCardRecordAsync(DigitalStoreCardRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreCardRecordHeaders headers = new DigitalStoreCardRecordHeaders();
            return await DigitalStoreCardRecordWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询组织中门店通通讯录基础信息
         *
         * @param headers DigitalStoreContactInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DigitalStoreContactInfoResponse
         */
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

        /**
         * @summary 查询组织中门店通通讯录基础信息
         *
         * @param headers DigitalStoreContactInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DigitalStoreContactInfoResponse
         */
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

        /**
         * @summary 查询组织中门店通通讯录基础信息
         *
         * @return DigitalStoreContactInfoResponse
         */
        public DigitalStoreContactInfoResponse DigitalStoreContactInfo()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreContactInfoHeaders headers = new DigitalStoreContactInfoHeaders();
            return DigitalStoreContactInfoWithOptions(headers, runtime);
        }

        /**
         * @summary 查询组织中门店通通讯录基础信息
         *
         * @return DigitalStoreContactInfoResponse
         */
        public async Task<DigitalStoreContactInfoResponse> DigitalStoreContactInfoAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreContactInfoHeaders headers = new DigitalStoreContactInfoHeaders();
            return await DigitalStoreContactInfoWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 获取门店通相关会话列表（区域群、门店群）
         *
         * @param request DigitalStoreConversationsRequest
         * @param headers DigitalStoreConversationsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DigitalStoreConversationsResponse
         */
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

        /**
         * @summary 获取门店通相关会话列表（区域群、门店群）
         *
         * @param request DigitalStoreConversationsRequest
         * @param headers DigitalStoreConversationsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DigitalStoreConversationsResponse
         */
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

        /**
         * @summary 获取门店通相关会话列表（区域群、门店群）
         *
         * @param request DigitalStoreConversationsRequest
         * @return DigitalStoreConversationsResponse
         */
        public DigitalStoreConversationsResponse DigitalStoreConversations(DigitalStoreConversationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreConversationsHeaders headers = new DigitalStoreConversationsHeaders();
            return DigitalStoreConversationsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取门店通相关会话列表（区域群、门店群）
         *
         * @param request DigitalStoreConversationsRequest
         * @return DigitalStoreConversationsResponse
         */
        public async Task<DigitalStoreConversationsResponse> DigitalStoreConversationsAsync(DigitalStoreConversationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreConversationsHeaders headers = new DigitalStoreConversationsHeaders();
            return await DigitalStoreConversationsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 群运营-数据监控-导出列表
         *
         * @param request DigitalStoreExportCardRecordRequest
         * @param headers DigitalStoreExportCardRecordHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DigitalStoreExportCardRecordResponse
         */
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

        /**
         * @summary 群运营-数据监控-导出列表
         *
         * @param request DigitalStoreExportCardRecordRequest
         * @param headers DigitalStoreExportCardRecordHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DigitalStoreExportCardRecordResponse
         */
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

        /**
         * @summary 群运营-数据监控-导出列表
         *
         * @param request DigitalStoreExportCardRecordRequest
         * @return DigitalStoreExportCardRecordResponse
         */
        public DigitalStoreExportCardRecordResponse DigitalStoreExportCardRecord(DigitalStoreExportCardRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreExportCardRecordHeaders headers = new DigitalStoreExportCardRecordHeaders();
            return DigitalStoreExportCardRecordWithOptions(request, headers, runtime);
        }

        /**
         * @summary 群运营-数据监控-导出列表
         *
         * @param request DigitalStoreExportCardRecordRequest
         * @return DigitalStoreExportCardRecordResponse
         */
        public async Task<DigitalStoreExportCardRecordResponse> DigitalStoreExportCardRecordAsync(DigitalStoreExportCardRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreExportCardRecordHeaders headers = new DigitalStoreExportCardRecordHeaders();
            return await DigitalStoreExportCardRecordWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 群运营-数据监控-导出明细
         *
         * @param request DigitalStoreExportCardRecordDetailRequest
         * @param headers DigitalStoreExportCardRecordDetailHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DigitalStoreExportCardRecordDetailResponse
         */
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

        /**
         * @summary 群运营-数据监控-导出明细
         *
         * @param request DigitalStoreExportCardRecordDetailRequest
         * @param headers DigitalStoreExportCardRecordDetailHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DigitalStoreExportCardRecordDetailResponse
         */
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

        /**
         * @summary 群运营-数据监控-导出明细
         *
         * @param request DigitalStoreExportCardRecordDetailRequest
         * @return DigitalStoreExportCardRecordDetailResponse
         */
        public DigitalStoreExportCardRecordDetailResponse DigitalStoreExportCardRecordDetail(DigitalStoreExportCardRecordDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreExportCardRecordDetailHeaders headers = new DigitalStoreExportCardRecordDetailHeaders();
            return DigitalStoreExportCardRecordDetailWithOptions(request, headers, runtime);
        }

        /**
         * @summary 群运营-数据监控-导出明细
         *
         * @param request DigitalStoreExportCardRecordDetailRequest
         * @return DigitalStoreExportCardRecordDetailResponse
         */
        public async Task<DigitalStoreExportCardRecordDetailResponse> DigitalStoreExportCardRecordDetailAsync(DigitalStoreExportCardRecordDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreExportCardRecordDetailHeaders headers = new DigitalStoreExportCardRecordDetailHeaders();
            return await DigitalStoreExportCardRecordDetailWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询门店通中的门店分组详情
         *
         * @param request DigitalStoreGroupInfoRequest
         * @param headers DigitalStoreGroupInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DigitalStoreGroupInfoResponse
         */
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

        /**
         * @summary 查询门店通中的门店分组详情
         *
         * @param request DigitalStoreGroupInfoRequest
         * @param headers DigitalStoreGroupInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DigitalStoreGroupInfoResponse
         */
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

        /**
         * @summary 查询门店通中的门店分组详情
         *
         * @param request DigitalStoreGroupInfoRequest
         * @return DigitalStoreGroupInfoResponse
         */
        public DigitalStoreGroupInfoResponse DigitalStoreGroupInfo(DigitalStoreGroupInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreGroupInfoHeaders headers = new DigitalStoreGroupInfoHeaders();
            return DigitalStoreGroupInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询门店通中的门店分组详情
         *
         * @param request DigitalStoreGroupInfoRequest
         * @return DigitalStoreGroupInfoResponse
         */
        public async Task<DigitalStoreGroupInfoResponse> DigitalStoreGroupInfoAsync(DigitalStoreGroupInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreGroupInfoHeaders headers = new DigitalStoreGroupInfoHeaders();
            return await DigitalStoreGroupInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询门店通中的分组列表
         *
         * @param headers DigitalStoreGroupsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DigitalStoreGroupsResponse
         */
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

        /**
         * @summary 查询门店通中的分组列表
         *
         * @param headers DigitalStoreGroupsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DigitalStoreGroupsResponse
         */
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

        /**
         * @summary 查询门店通中的分组列表
         *
         * @return DigitalStoreGroupsResponse
         */
        public DigitalStoreGroupsResponse DigitalStoreGroups()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreGroupsHeaders headers = new DigitalStoreGroupsHeaders();
            return DigitalStoreGroupsWithOptions(headers, runtime);
        }

        /**
         * @summary 查询门店通中的分组列表
         *
         * @return DigitalStoreGroupsResponse
         */
        public async Task<DigitalStoreGroupsResponse> DigitalStoreGroupsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreGroupsHeaders headers = new DigitalStoreGroupsHeaders();
            return await DigitalStoreGroupsWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 查询门店通讯录某个节点信息
         *
         * @param request DigitalStoreNodeInfoRequest
         * @param headers DigitalStoreNodeInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DigitalStoreNodeInfoResponse
         */
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

        /**
         * @summary 查询门店通讯录某个节点信息
         *
         * @param request DigitalStoreNodeInfoRequest
         * @param headers DigitalStoreNodeInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DigitalStoreNodeInfoResponse
         */
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

        /**
         * @summary 查询门店通讯录某个节点信息
         *
         * @param request DigitalStoreNodeInfoRequest
         * @return DigitalStoreNodeInfoResponse
         */
        public DigitalStoreNodeInfoResponse DigitalStoreNodeInfo(DigitalStoreNodeInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreNodeInfoHeaders headers = new DigitalStoreNodeInfoHeaders();
            return DigitalStoreNodeInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询门店通讯录某个节点信息
         *
         * @param request DigitalStoreNodeInfoRequest
         * @return DigitalStoreNodeInfoResponse
         */
        public async Task<DigitalStoreNodeInfoResponse> DigitalStoreNodeInfoAsync(DigitalStoreNodeInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreNodeInfoHeaders headers = new DigitalStoreNodeInfoHeaders();
            return await DigitalStoreNodeInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 门店通权益信息查询
         *
         * @param headers DigitalStoreRightsInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DigitalStoreRightsInfoResponse
         */
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

        /**
         * @summary 门店通权益信息查询
         *
         * @param headers DigitalStoreRightsInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DigitalStoreRightsInfoResponse
         */
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

        /**
         * @summary 门店通权益信息查询
         *
         * @return DigitalStoreRightsInfoResponse
         */
        public DigitalStoreRightsInfoResponse DigitalStoreRightsInfo()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreRightsInfoHeaders headers = new DigitalStoreRightsInfoHeaders();
            return DigitalStoreRightsInfoWithOptions(headers, runtime);
        }

        /**
         * @summary 门店通权益信息查询
         *
         * @return DigitalStoreRightsInfoResponse
         */
        public async Task<DigitalStoreRightsInfoResponse> DigitalStoreRightsInfoAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreRightsInfoHeaders headers = new DigitalStoreRightsInfoHeaders();
            return await DigitalStoreRightsInfoWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 查询门店通中的角色列表
         *
         * @param headers DigitalStoreRolesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DigitalStoreRolesResponse
         */
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

        /**
         * @summary 查询门店通中的角色列表
         *
         * @param headers DigitalStoreRolesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DigitalStoreRolesResponse
         */
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

        /**
         * @summary 查询门店通中的角色列表
         *
         * @return DigitalStoreRolesResponse
         */
        public DigitalStoreRolesResponse DigitalStoreRoles()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreRolesHeaders headers = new DigitalStoreRolesHeaders();
            return DigitalStoreRolesWithOptions(headers, runtime);
        }

        /**
         * @summary 查询门店通中的角色列表
         *
         * @return DigitalStoreRolesResponse
         */
        public async Task<DigitalStoreRolesResponse> DigitalStoreRolesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreRolesHeaders headers = new DigitalStoreRolesHeaders();
            return await DigitalStoreRolesWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 获取门店通场景群的业务范围
         *
         * @param request DigitalStoreSceneScopeRequest
         * @param headers DigitalStoreSceneScopeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DigitalStoreSceneScopeResponse
         */
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

        /**
         * @summary 获取门店通场景群的业务范围
         *
         * @param request DigitalStoreSceneScopeRequest
         * @param headers DigitalStoreSceneScopeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DigitalStoreSceneScopeResponse
         */
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

        /**
         * @summary 获取门店通场景群的业务范围
         *
         * @param request DigitalStoreSceneScopeRequest
         * @return DigitalStoreSceneScopeResponse
         */
        public DigitalStoreSceneScopeResponse DigitalStoreSceneScope(DigitalStoreSceneScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreSceneScopeHeaders headers = new DigitalStoreSceneScopeHeaders();
            return DigitalStoreSceneScopeWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取门店通场景群的业务范围
         *
         * @param request DigitalStoreSceneScopeRequest
         * @return DigitalStoreSceneScopeResponse
         */
        public async Task<DigitalStoreSceneScopeResponse> DigitalStoreSceneScopeAsync(DigitalStoreSceneScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreSceneScopeHeaders headers = new DigitalStoreSceneScopeHeaders();
            return await DigitalStoreSceneScopeWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询门店通中的门店详情
         *
         * @param request DigitalStoreStoreInfoRequest
         * @param headers DigitalStoreStoreInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DigitalStoreStoreInfoResponse
         */
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

        /**
         * @summary 查询门店通中的门店详情
         *
         * @param request DigitalStoreStoreInfoRequest
         * @param headers DigitalStoreStoreInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DigitalStoreStoreInfoResponse
         */
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

        /**
         * @summary 查询门店通中的门店详情
         *
         * @param request DigitalStoreStoreInfoRequest
         * @return DigitalStoreStoreInfoResponse
         */
        public DigitalStoreStoreInfoResponse DigitalStoreStoreInfo(DigitalStoreStoreInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreStoreInfoHeaders headers = new DigitalStoreStoreInfoHeaders();
            return DigitalStoreStoreInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询门店通中的门店详情
         *
         * @param request DigitalStoreStoreInfoRequest
         * @return DigitalStoreStoreInfoResponse
         */
        public async Task<DigitalStoreStoreInfoResponse> DigitalStoreStoreInfoAsync(DigitalStoreStoreInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreStoreInfoHeaders headers = new DigitalStoreStoreInfoHeaders();
            return await DigitalStoreStoreInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询门店通讯录某个节点下的子节点
         *
         * @param request DigitalStoreSubNodesRequest
         * @param headers DigitalStoreSubNodesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DigitalStoreSubNodesResponse
         */
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

        /**
         * @summary 查询门店通讯录某个节点下的子节点
         *
         * @param request DigitalStoreSubNodesRequest
         * @param headers DigitalStoreSubNodesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DigitalStoreSubNodesResponse
         */
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

        /**
         * @summary 查询门店通讯录某个节点下的子节点
         *
         * @param request DigitalStoreSubNodesRequest
         * @return DigitalStoreSubNodesResponse
         */
        public DigitalStoreSubNodesResponse DigitalStoreSubNodes(DigitalStoreSubNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreSubNodesHeaders headers = new DigitalStoreSubNodesHeaders();
            return DigitalStoreSubNodesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询门店通讯录某个节点下的子节点
         *
         * @param request DigitalStoreSubNodesRequest
         * @return DigitalStoreSubNodesResponse
         */
        public async Task<DigitalStoreSubNodesResponse> DigitalStoreSubNodesAsync(DigitalStoreSubNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreSubNodesHeaders headers = new DigitalStoreSubNodesHeaders();
            return await DigitalStoreSubNodesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 修改人员管辖范围以及所属角色
         *
         * @param request DigitalStoreUpdateAuthInfoRequest
         * @param headers DigitalStoreUpdateAuthInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DigitalStoreUpdateAuthInfoResponse
         */
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

        /**
         * @summary 修改人员管辖范围以及所属角色
         *
         * @param request DigitalStoreUpdateAuthInfoRequest
         * @param headers DigitalStoreUpdateAuthInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DigitalStoreUpdateAuthInfoResponse
         */
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

        /**
         * @summary 修改人员管辖范围以及所属角色
         *
         * @param request DigitalStoreUpdateAuthInfoRequest
         * @return DigitalStoreUpdateAuthInfoResponse
         */
        public DigitalStoreUpdateAuthInfoResponse DigitalStoreUpdateAuthInfo(DigitalStoreUpdateAuthInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreUpdateAuthInfoHeaders headers = new DigitalStoreUpdateAuthInfoHeaders();
            return DigitalStoreUpdateAuthInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 修改人员管辖范围以及所属角色
         *
         * @param request DigitalStoreUpdateAuthInfoRequest
         * @return DigitalStoreUpdateAuthInfoResponse
         */
        public async Task<DigitalStoreUpdateAuthInfoResponse> DigitalStoreUpdateAuthInfoAsync(DigitalStoreUpdateAuthInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreUpdateAuthInfoHeaders headers = new DigitalStoreUpdateAuthInfoHeaders();
            return await DigitalStoreUpdateAuthInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询门店通讯录人员信息
         *
         * @param request DigitalStoreUserInfoRequest
         * @param headers DigitalStoreUserInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DigitalStoreUserInfoResponse
         */
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

        /**
         * @summary 查询门店通讯录人员信息
         *
         * @param request DigitalStoreUserInfoRequest
         * @param headers DigitalStoreUserInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DigitalStoreUserInfoResponse
         */
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

        /**
         * @summary 查询门店通讯录人员信息
         *
         * @param request DigitalStoreUserInfoRequest
         * @return DigitalStoreUserInfoResponse
         */
        public DigitalStoreUserInfoResponse DigitalStoreUserInfo(DigitalStoreUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreUserInfoHeaders headers = new DigitalStoreUserInfoHeaders();
            return DigitalStoreUserInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询门店通讯录人员信息
         *
         * @param request DigitalStoreUserInfoRequest
         * @return DigitalStoreUserInfoResponse
         */
        public async Task<DigitalStoreUserInfoResponse> DigitalStoreUserInfoAsync(DigitalStoreUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreUserInfoHeaders headers = new DigitalStoreUserInfoHeaders();
            return await DigitalStoreUserInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询门店通讯录某个节点下的所有人员
         *
         * @param request DigitalStoreUsersRequest
         * @param headers DigitalStoreUsersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DigitalStoreUsersResponse
         */
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

        /**
         * @summary 查询门店通讯录某个节点下的所有人员
         *
         * @param request DigitalStoreUsersRequest
         * @param headers DigitalStoreUsersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DigitalStoreUsersResponse
         */
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

        /**
         * @summary 查询门店通讯录某个节点下的所有人员
         *
         * @param request DigitalStoreUsersRequest
         * @return DigitalStoreUsersResponse
         */
        public DigitalStoreUsersResponse DigitalStoreUsers(DigitalStoreUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreUsersHeaders headers = new DigitalStoreUsersHeaders();
            return DigitalStoreUsersWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询门店通讯录某个节点下的所有人员
         *
         * @param request DigitalStoreUsersRequest
         * @return DigitalStoreUsersResponse
         */
        public async Task<DigitalStoreUsersResponse> DigitalStoreUsersAsync(DigitalStoreUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreUsersHeaders headers = new DigitalStoreUsersHeaders();
            return await DigitalStoreUsersWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 群运营-数据监控-查询导出任务的记录列表
         *
         * @param request DigitalStorelistExportTaskRecordRequest
         * @param headers DigitalStorelistExportTaskRecordHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DigitalStorelistExportTaskRecordResponse
         */
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

        /**
         * @summary 群运营-数据监控-查询导出任务的记录列表
         *
         * @param request DigitalStorelistExportTaskRecordRequest
         * @param headers DigitalStorelistExportTaskRecordHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DigitalStorelistExportTaskRecordResponse
         */
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

        /**
         * @summary 群运营-数据监控-查询导出任务的记录列表
         *
         * @param request DigitalStorelistExportTaskRecordRequest
         * @return DigitalStorelistExportTaskRecordResponse
         */
        public DigitalStorelistExportTaskRecordResponse DigitalStorelistExportTaskRecord(DigitalStorelistExportTaskRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStorelistExportTaskRecordHeaders headers = new DigitalStorelistExportTaskRecordHeaders();
            return DigitalStorelistExportTaskRecordWithOptions(request, headers, runtime);
        }

        /**
         * @summary 群运营-数据监控-查询导出任务的记录列表
         *
         * @param request DigitalStorelistExportTaskRecordRequest
         * @return DigitalStorelistExportTaskRecordResponse
         */
        public async Task<DigitalStorelistExportTaskRecordResponse> DigitalStorelistExportTaskRecordAsync(DigitalStorelistExportTaskRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStorelistExportTaskRecordHeaders headers = new DigitalStorelistExportTaskRecordHeaders();
            return await DigitalStorelistExportTaskRecordWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询启用了当前应用的外部协作组织
         *
         * @param request ExternalQueryExternalAppOrgsRequest
         * @param headers ExternalQueryExternalAppOrgsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExternalQueryExternalAppOrgsResponse
         */
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

        /**
         * @summary 查询启用了当前应用的外部协作组织
         *
         * @param request ExternalQueryExternalAppOrgsRequest
         * @param headers ExternalQueryExternalAppOrgsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExternalQueryExternalAppOrgsResponse
         */
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

        /**
         * @summary 查询启用了当前应用的外部协作组织
         *
         * @param request ExternalQueryExternalAppOrgsRequest
         * @return ExternalQueryExternalAppOrgsResponse
         */
        public ExternalQueryExternalAppOrgsResponse ExternalQueryExternalAppOrgs(ExternalQueryExternalAppOrgsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExternalQueryExternalAppOrgsHeaders headers = new ExternalQueryExternalAppOrgsHeaders();
            return ExternalQueryExternalAppOrgsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询启用了当前应用的外部协作组织
         *
         * @param request ExternalQueryExternalAppOrgsRequest
         * @return ExternalQueryExternalAppOrgsResponse
         */
        public async Task<ExternalQueryExternalAppOrgsResponse> ExternalQueryExternalAppOrgsAsync(ExternalQueryExternalAppOrgsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExternalQueryExternalAppOrgsHeaders headers = new ExternalQueryExternalAppOrgsHeaders();
            return await ExternalQueryExternalAppOrgsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询归属的主组织
         *
         * @param request ExternalQueryExternalBelongMainOrgRequest
         * @param headers ExternalQueryExternalBelongMainOrgHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExternalQueryExternalBelongMainOrgResponse
         */
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

        /**
         * @summary 查询归属的主组织
         *
         * @param request ExternalQueryExternalBelongMainOrgRequest
         * @param headers ExternalQueryExternalBelongMainOrgHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExternalQueryExternalBelongMainOrgResponse
         */
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

        /**
         * @summary 查询归属的主组织
         *
         * @param request ExternalQueryExternalBelongMainOrgRequest
         * @return ExternalQueryExternalBelongMainOrgResponse
         */
        public ExternalQueryExternalBelongMainOrgResponse ExternalQueryExternalBelongMainOrg(ExternalQueryExternalBelongMainOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExternalQueryExternalBelongMainOrgHeaders headers = new ExternalQueryExternalBelongMainOrgHeaders();
            return ExternalQueryExternalBelongMainOrgWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询归属的主组织
         *
         * @param request ExternalQueryExternalBelongMainOrgRequest
         * @return ExternalQueryExternalBelongMainOrgResponse
         */
        public async Task<ExternalQueryExternalBelongMainOrgResponse> ExternalQueryExternalBelongMainOrgAsync(ExternalQueryExternalBelongMainOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExternalQueryExternalBelongMainOrgHeaders headers = new ExternalQueryExternalBelongMainOrgHeaders();
            return await ExternalQueryExternalBelongMainOrgWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询外部协作组织
         *
         * @param request ExternalQueryExternalOrgsRequest
         * @param headers ExternalQueryExternalOrgsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExternalQueryExternalOrgsResponse
         */
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

        /**
         * @summary 查询外部协作组织
         *
         * @param request ExternalQueryExternalOrgsRequest
         * @param headers ExternalQueryExternalOrgsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExternalQueryExternalOrgsResponse
         */
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

        /**
         * @summary 查询外部协作组织
         *
         * @param request ExternalQueryExternalOrgsRequest
         * @return ExternalQueryExternalOrgsResponse
         */
        public ExternalQueryExternalOrgsResponse ExternalQueryExternalOrgs(ExternalQueryExternalOrgsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExternalQueryExternalOrgsHeaders headers = new ExternalQueryExternalOrgsHeaders();
            return ExternalQueryExternalOrgsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询外部协作组织
         *
         * @param request ExternalQueryExternalOrgsRequest
         * @return ExternalQueryExternalOrgsResponse
         */
        public async Task<ExternalQueryExternalOrgsResponse> ExternalQueryExternalOrgsAsync(ExternalQueryExternalOrgsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExternalQueryExternalOrgsHeaders headers = new ExternalQueryExternalOrgsHeaders();
            return await ExternalQueryExternalOrgsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 医疗数据对账
         *
         * @param request HospitalDataCheckRequest
         * @param headers HospitalDataCheckHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return HospitalDataCheckResponse
         */
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

        /**
         * @summary 医疗数据对账
         *
         * @param request HospitalDataCheckRequest
         * @param headers HospitalDataCheckHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return HospitalDataCheckResponse
         */
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

        /**
         * @summary 医疗数据对账
         *
         * @param request HospitalDataCheckRequest
         * @return HospitalDataCheckResponse
         */
        public HospitalDataCheckResponse HospitalDataCheck(HospitalDataCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HospitalDataCheckHeaders headers = new HospitalDataCheckHeaders();
            return HospitalDataCheckWithOptions(request, headers, runtime);
        }

        /**
         * @summary 医疗数据对账
         *
         * @param request HospitalDataCheckRequest
         * @return HospitalDataCheckResponse
         */
        public async Task<HospitalDataCheckResponse> HospitalDataCheckAsync(HospitalDataCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HospitalDataCheckHeaders headers = new HospitalDataCheckHeaders();
            return await HospitalDataCheckWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 行业化制造业事件中心
         *
         * @param request IndustryManufactureCommonEventRequest
         * @param headers IndustryManufactureCommonEventHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return IndustryManufactureCommonEventResponse
         */
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

        /**
         * @summary 行业化制造业事件中心
         *
         * @param request IndustryManufactureCommonEventRequest
         * @param headers IndustryManufactureCommonEventHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return IndustryManufactureCommonEventResponse
         */
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

        /**
         * @summary 行业化制造业事件中心
         *
         * @param request IndustryManufactureCommonEventRequest
         * @return IndustryManufactureCommonEventResponse
         */
        public IndustryManufactureCommonEventResponse IndustryManufactureCommonEvent(IndustryManufactureCommonEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureCommonEventHeaders headers = new IndustryManufactureCommonEventHeaders();
            return IndustryManufactureCommonEventWithOptions(request, headers, runtime);
        }

        /**
         * @summary 行业化制造业事件中心
         *
         * @param request IndustryManufactureCommonEventRequest
         * @return IndustryManufactureCommonEventResponse
         */
        public async Task<IndustryManufactureCommonEventResponse> IndustryManufactureCommonEventAsync(IndustryManufactureCommonEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureCommonEventHeaders headers = new IndustryManufactureCommonEventHeaders();
            return await IndustryManufactureCommonEventWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 物料成本开放服务
         *
         * @param request IndustryManufactureCostRecordListGetRequest
         * @param headers IndustryManufactureCostRecordListGetHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return IndustryManufactureCostRecordListGetResponse
         */
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

        /**
         * @summary 物料成本开放服务
         *
         * @param request IndustryManufactureCostRecordListGetRequest
         * @param headers IndustryManufactureCostRecordListGetHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return IndustryManufactureCostRecordListGetResponse
         */
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

        /**
         * @summary 物料成本开放服务
         *
         * @param request IndustryManufactureCostRecordListGetRequest
         * @return IndustryManufactureCostRecordListGetResponse
         */
        public IndustryManufactureCostRecordListGetResponse IndustryManufactureCostRecordListGet(IndustryManufactureCostRecordListGetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureCostRecordListGetHeaders headers = new IndustryManufactureCostRecordListGetHeaders();
            return IndustryManufactureCostRecordListGetWithOptions(request, headers, runtime);
        }

        /**
         * @summary 物料成本开放服务
         *
         * @param request IndustryManufactureCostRecordListGetRequest
         * @return IndustryManufactureCostRecordListGetResponse
         */
        public async Task<IndustryManufactureCostRecordListGetResponse> IndustryManufactureCostRecordListGetAsync(IndustryManufactureCostRecordListGetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureCostRecordListGetHeaders headers = new IndustryManufactureCostRecordListGetHeaders();
            return await IndustryManufactureCostRecordListGetWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 费用服务
         *
         * @param request IndustryManufactureFeeListGetRequest
         * @param headers IndustryManufactureFeeListGetHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return IndustryManufactureFeeListGetResponse
         */
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

        /**
         * @summary 费用服务
         *
         * @param request IndustryManufactureFeeListGetRequest
         * @param headers IndustryManufactureFeeListGetHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return IndustryManufactureFeeListGetResponse
         */
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

        /**
         * @summary 费用服务
         *
         * @param request IndustryManufactureFeeListGetRequest
         * @return IndustryManufactureFeeListGetResponse
         */
        public IndustryManufactureFeeListGetResponse IndustryManufactureFeeListGet(IndustryManufactureFeeListGetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureFeeListGetHeaders headers = new IndustryManufactureFeeListGetHeaders();
            return IndustryManufactureFeeListGetWithOptions(request, headers, runtime);
        }

        /**
         * @summary 费用服务
         *
         * @param request IndustryManufactureFeeListGetRequest
         * @return IndustryManufactureFeeListGetResponse
         */
        public async Task<IndustryManufactureFeeListGetResponse> IndustryManufactureFeeListGetAsync(IndustryManufactureFeeListGetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureFeeListGetHeaders headers = new IndustryManufactureFeeListGetHeaders();
            return await IndustryManufactureFeeListGetWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 行业化-制造业工价接口
         *
         * @param request IndustryManufactureLabourCostRequest
         * @param headers IndustryManufactureLabourCostHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return IndustryManufactureLabourCostResponse
         */
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

        /**
         * @summary 行业化-制造业工价接口
         *
         * @param request IndustryManufactureLabourCostRequest
         * @param headers IndustryManufactureLabourCostHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return IndustryManufactureLabourCostResponse
         */
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

        /**
         * @summary 行业化-制造业工价接口
         *
         * @param request IndustryManufactureLabourCostRequest
         * @return IndustryManufactureLabourCostResponse
         */
        public IndustryManufactureLabourCostResponse IndustryManufactureLabourCost(IndustryManufactureLabourCostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureLabourCostHeaders headers = new IndustryManufactureLabourCostHeaders();
            return IndustryManufactureLabourCostWithOptions(request, headers, runtime);
        }

        /**
         * @summary 行业化-制造业工价接口
         *
         * @param request IndustryManufactureLabourCostRequest
         * @return IndustryManufactureLabourCostResponse
         */
        public async Task<IndustryManufactureLabourCostResponse> IndustryManufactureLabourCostAsync(IndustryManufactureLabourCostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureLabourCostHeaders headers = new IndustryManufactureLabourCostHeaders();
            return await IndustryManufactureLabourCostWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询行业物料列表
         *
         * @param request IndustryManufactureMaterialListRequest
         * @param headers IndustryManufactureMaterialListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return IndustryManufactureMaterialListResponse
         */
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

        /**
         * @summary 查询行业物料列表
         *
         * @param request IndustryManufactureMaterialListRequest
         * @param headers IndustryManufactureMaterialListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return IndustryManufactureMaterialListResponse
         */
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

        /**
         * @summary 查询行业物料列表
         *
         * @param request IndustryManufactureMaterialListRequest
         * @return IndustryManufactureMaterialListResponse
         */
        public IndustryManufactureMaterialListResponse IndustryManufactureMaterialList(IndustryManufactureMaterialListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureMaterialListHeaders headers = new IndustryManufactureMaterialListHeaders();
            return IndustryManufactureMaterialListWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询行业物料列表
         *
         * @param request IndustryManufactureMaterialListRequest
         * @return IndustryManufactureMaterialListResponse
         */
        public async Task<IndustryManufactureMaterialListResponse> IndustryManufactureMaterialListAsync(IndustryManufactureMaterialListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureMaterialListHeaders headers = new IndustryManufactureMaterialListHeaders();
            return await IndustryManufactureMaterialListWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 派工任务管理
         *
         * @param request IndustryManufactureMesDispatchTaskRequest
         * @param headers IndustryManufactureMesDispatchTaskHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return IndustryManufactureMesDispatchTaskResponse
         */
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

        /**
         * @summary 派工任务管理
         *
         * @param request IndustryManufactureMesDispatchTaskRequest
         * @param headers IndustryManufactureMesDispatchTaskHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return IndustryManufactureMesDispatchTaskResponse
         */
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

        /**
         * @summary 派工任务管理
         *
         * @param request IndustryManufactureMesDispatchTaskRequest
         * @return IndustryManufactureMesDispatchTaskResponse
         */
        public IndustryManufactureMesDispatchTaskResponse IndustryManufactureMesDispatchTask(IndustryManufactureMesDispatchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureMesDispatchTaskHeaders headers = new IndustryManufactureMesDispatchTaskHeaders();
            return IndustryManufactureMesDispatchTaskWithOptions(request, headers, runtime);
        }

        /**
         * @summary 派工任务管理
         *
         * @param request IndustryManufactureMesDispatchTaskRequest
         * @return IndustryManufactureMesDispatchTaskResponse
         */
        public async Task<IndustryManufactureMesDispatchTaskResponse> IndustryManufactureMesDispatchTaskAsync(IndustryManufactureMesDispatchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureMesDispatchTaskHeaders headers = new IndustryManufactureMesDispatchTaskHeaders();
            return await IndustryManufactureMesDispatchTaskWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary MES系统物料管理
         *
         * @param request IndustryManufactureMesMaterialRequest
         * @param headers IndustryManufactureMesMaterialHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return IndustryManufactureMesMaterialResponse
         */
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

        /**
         * @summary MES系统物料管理
         *
         * @param request IndustryManufactureMesMaterialRequest
         * @param headers IndustryManufactureMesMaterialHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return IndustryManufactureMesMaterialResponse
         */
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

        /**
         * @summary MES系统物料管理
         *
         * @param request IndustryManufactureMesMaterialRequest
         * @return IndustryManufactureMesMaterialResponse
         */
        public IndustryManufactureMesMaterialResponse IndustryManufactureMesMaterial(IndustryManufactureMesMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureMesMaterialHeaders headers = new IndustryManufactureMesMaterialHeaders();
            return IndustryManufactureMesMaterialWithOptions(request, headers, runtime);
        }

        /**
         * @summary MES系统物料管理
         *
         * @param request IndustryManufactureMesMaterialRequest
         * @return IndustryManufactureMesMaterialResponse
         */
        public async Task<IndustryManufactureMesMaterialResponse> IndustryManufactureMesMaterialAsync(IndustryManufactureMesMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureMesMaterialHeaders headers = new IndustryManufactureMesMaterialHeaders();
            return await IndustryManufactureMesMaterialWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 生产委外工单管理
         *
         * @param request IndustryManufactureMesOutPlanRequest
         * @param headers IndustryManufactureMesOutPlanHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return IndustryManufactureMesOutPlanResponse
         */
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

        /**
         * @summary 生产委外工单管理
         *
         * @param request IndustryManufactureMesOutPlanRequest
         * @param headers IndustryManufactureMesOutPlanHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return IndustryManufactureMesOutPlanResponse
         */
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

        /**
         * @summary 生产委外工单管理
         *
         * @param request IndustryManufactureMesOutPlanRequest
         * @return IndustryManufactureMesOutPlanResponse
         */
        public IndustryManufactureMesOutPlanResponse IndustryManufactureMesOutPlan(IndustryManufactureMesOutPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureMesOutPlanHeaders headers = new IndustryManufactureMesOutPlanHeaders();
            return IndustryManufactureMesOutPlanWithOptions(request, headers, runtime);
        }

        /**
         * @summary 生产委外工单管理
         *
         * @param request IndustryManufactureMesOutPlanRequest
         * @return IndustryManufactureMesOutPlanResponse
         */
        public async Task<IndustryManufactureMesOutPlanResponse> IndustryManufactureMesOutPlanAsync(IndustryManufactureMesOutPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureMesOutPlanHeaders headers = new IndustryManufactureMesOutPlanHeaders();
            return await IndustryManufactureMesOutPlanWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 生产报工管理
         *
         * @param request IndustryManufactureMesOutputRequest
         * @param headers IndustryManufactureMesOutputHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return IndustryManufactureMesOutputResponse
         */
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

        /**
         * @summary 生产报工管理
         *
         * @param request IndustryManufactureMesOutputRequest
         * @param headers IndustryManufactureMesOutputHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return IndustryManufactureMesOutputResponse
         */
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

        /**
         * @summary 生产报工管理
         *
         * @param request IndustryManufactureMesOutputRequest
         * @return IndustryManufactureMesOutputResponse
         */
        public IndustryManufactureMesOutputResponse IndustryManufactureMesOutput(IndustryManufactureMesOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureMesOutputHeaders headers = new IndustryManufactureMesOutputHeaders();
            return IndustryManufactureMesOutputWithOptions(request, headers, runtime);
        }

        /**
         * @summary 生产报工管理
         *
         * @param request IndustryManufactureMesOutputRequest
         * @return IndustryManufactureMesOutputResponse
         */
        public async Task<IndustryManufactureMesOutputResponse> IndustryManufactureMesOutputAsync(IndustryManufactureMesOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureMesOutputHeaders headers = new IndustryManufactureMesOutputHeaders();
            return await IndustryManufactureMesOutputWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary MES系统工序管理
         *
         * @param request IndustryManufactureMesProcessRequest
         * @param headers IndustryManufactureMesProcessHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return IndustryManufactureMesProcessResponse
         */
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

        /**
         * @summary MES系统工序管理
         *
         * @param request IndustryManufactureMesProcessRequest
         * @param headers IndustryManufactureMesProcessHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return IndustryManufactureMesProcessResponse
         */
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

        /**
         * @summary MES系统工序管理
         *
         * @param request IndustryManufactureMesProcessRequest
         * @return IndustryManufactureMesProcessResponse
         */
        public IndustryManufactureMesProcessResponse IndustryManufactureMesProcess(IndustryManufactureMesProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureMesProcessHeaders headers = new IndustryManufactureMesProcessHeaders();
            return IndustryManufactureMesProcessWithOptions(request, headers, runtime);
        }

        /**
         * @summary MES系统工序管理
         *
         * @param request IndustryManufactureMesProcessRequest
         * @return IndustryManufactureMesProcessResponse
         */
        public async Task<IndustryManufactureMesProcessResponse> IndustryManufactureMesProcessAsync(IndustryManufactureMesProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureMesProcessHeaders headers = new IndustryManufactureMesProcessHeaders();
            return await IndustryManufactureMesProcessWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 生产工单管理
         *
         * @param request IndustryManufactureMesProductionPlanRequest
         * @param headers IndustryManufactureMesProductionPlanHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return IndustryManufactureMesProductionPlanResponse
         */
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

        /**
         * @summary 生产工单管理
         *
         * @param request IndustryManufactureMesProductionPlanRequest
         * @param headers IndustryManufactureMesProductionPlanHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return IndustryManufactureMesProductionPlanResponse
         */
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

        /**
         * @summary 生产工单管理
         *
         * @param request IndustryManufactureMesProductionPlanRequest
         * @return IndustryManufactureMesProductionPlanResponse
         */
        public IndustryManufactureMesProductionPlanResponse IndustryManufactureMesProductionPlan(IndustryManufactureMesProductionPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureMesProductionPlanHeaders headers = new IndustryManufactureMesProductionPlanHeaders();
            return IndustryManufactureMesProductionPlanWithOptions(request, headers, runtime);
        }

        /**
         * @summary 生产工单管理
         *
         * @param request IndustryManufactureMesProductionPlanRequest
         * @return IndustryManufactureMesProductionPlanResponse
         */
        public async Task<IndustryManufactureMesProductionPlanResponse> IndustryManufactureMesProductionPlanAsync(IndustryManufactureMesProductionPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureMesProductionPlanHeaders headers = new IndustryManufactureMesProductionPlanHeaders();
            return await IndustryManufactureMesProductionPlanWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 生产委外合作班组管理
         *
         * @param request IndustryManufactureMesSubCooperationTeamRequest
         * @param headers IndustryManufactureMesSubCooperationTeamHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return IndustryManufactureMesSubCooperationTeamResponse
         */
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

        /**
         * @summary 生产委外合作班组管理
         *
         * @param request IndustryManufactureMesSubCooperationTeamRequest
         * @param headers IndustryManufactureMesSubCooperationTeamHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return IndustryManufactureMesSubCooperationTeamResponse
         */
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

        /**
         * @summary 生产委外合作班组管理
         *
         * @param request IndustryManufactureMesSubCooperationTeamRequest
         * @return IndustryManufactureMesSubCooperationTeamResponse
         */
        public IndustryManufactureMesSubCooperationTeamResponse IndustryManufactureMesSubCooperationTeam(IndustryManufactureMesSubCooperationTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureMesSubCooperationTeamHeaders headers = new IndustryManufactureMesSubCooperationTeamHeaders();
            return IndustryManufactureMesSubCooperationTeamWithOptions(request, headers, runtime);
        }

        /**
         * @summary 生产委外合作班组管理
         *
         * @param request IndustryManufactureMesSubCooperationTeamRequest
         * @return IndustryManufactureMesSubCooperationTeamResponse
         */
        public async Task<IndustryManufactureMesSubCooperationTeamResponse> IndustryManufactureMesSubCooperationTeamAsync(IndustryManufactureMesSubCooperationTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureMesSubCooperationTeamHeaders headers = new IndustryManufactureMesSubCooperationTeamHeaders();
            return await IndustryManufactureMesSubCooperationTeamWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary MES系统班组管理
         *
         * @param request IndustryManufactureMesTeamMgmtRequest
         * @param headers IndustryManufactureMesTeamMgmtHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return IndustryManufactureMesTeamMgmtResponse
         */
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

        /**
         * @summary MES系统班组管理
         *
         * @param request IndustryManufactureMesTeamMgmtRequest
         * @param headers IndustryManufactureMesTeamMgmtHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return IndustryManufactureMesTeamMgmtResponse
         */
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

        /**
         * @summary MES系统班组管理
         *
         * @param request IndustryManufactureMesTeamMgmtRequest
         * @return IndustryManufactureMesTeamMgmtResponse
         */
        public IndustryManufactureMesTeamMgmtResponse IndustryManufactureMesTeamMgmt(IndustryManufactureMesTeamMgmtRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureMesTeamMgmtHeaders headers = new IndustryManufactureMesTeamMgmtHeaders();
            return IndustryManufactureMesTeamMgmtWithOptions(request, headers, runtime);
        }

        /**
         * @summary MES系统班组管理
         *
         * @param request IndustryManufactureMesTeamMgmtRequest
         * @return IndustryManufactureMesTeamMgmtResponse
         */
        public async Task<IndustryManufactureMesTeamMgmtResponse> IndustryManufactureMesTeamMgmtAsync(IndustryManufactureMesTeamMgmtRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureMesTeamMgmtHeaders headers = new IndustryManufactureMesTeamMgmtHeaders();
            return await IndustryManufactureMesTeamMgmtWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 物料成本查询服务
         *
         * @param request IndustryMmanufactureMaterialCostGetRequest
         * @param headers IndustryMmanufactureMaterialCostGetHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return IndustryMmanufactureMaterialCostGetResponse
         */
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

        /**
         * @summary 物料成本查询服务
         *
         * @param request IndustryMmanufactureMaterialCostGetRequest
         * @param headers IndustryMmanufactureMaterialCostGetHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return IndustryMmanufactureMaterialCostGetResponse
         */
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

        /**
         * @summary 物料成本查询服务
         *
         * @param request IndustryMmanufactureMaterialCostGetRequest
         * @return IndustryMmanufactureMaterialCostGetResponse
         */
        public IndustryMmanufactureMaterialCostGetResponse IndustryMmanufactureMaterialCostGet(IndustryMmanufactureMaterialCostGetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryMmanufactureMaterialCostGetHeaders headers = new IndustryMmanufactureMaterialCostGetHeaders();
            return IndustryMmanufactureMaterialCostGetWithOptions(request, headers, runtime);
        }

        /**
         * @summary 物料成本查询服务
         *
         * @param request IndustryMmanufactureMaterialCostGetRequest
         * @return IndustryMmanufactureMaterialCostGetResponse
         */
        public async Task<IndustryMmanufactureMaterialCostGetResponse> IndustryMmanufactureMaterialCostGetAsync(IndustryMmanufactureMaterialCostGetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryMmanufactureMaterialCostGetHeaders headers = new IndustryMmanufactureMaterialCostGetHeaders();
            return await IndustryMmanufactureMaterialCostGetWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 提供text和card两种形式工作通知消息
         *
         * @param request PushDingMessageRequest
         * @param headers PushDingMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PushDingMessageResponse
         */
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

        /**
         * @summary 提供text和card两种形式工作通知消息
         *
         * @param request PushDingMessageRequest
         * @param headers PushDingMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PushDingMessageResponse
         */
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

        /**
         * @summary 提供text和card两种形式工作通知消息
         *
         * @param request PushDingMessageRequest
         * @return PushDingMessageResponse
         */
        public PushDingMessageResponse PushDingMessage(PushDingMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushDingMessageHeaders headers = new PushDingMessageHeaders();
            return PushDingMessageWithOptions(request, headers, runtime);
        }

        /**
         * @summary 提供text和card两种形式工作通知消息
         *
         * @param request PushDingMessageRequest
         * @return PushDingMessageResponse
         */
        public async Task<PushDingMessageResponse> PushDingMessageAsync(PushDingMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushDingMessageHeaders headers = new PushDingMessageHeaders();
            return await PushDingMessageWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取当前组织下的所有科室
         *
         * @param request QueryAllDepartmentRequest
         * @param headers QueryAllDepartmentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAllDepartmentResponse
         */
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

        /**
         * @summary 获取当前组织下的所有科室
         *
         * @param request QueryAllDepartmentRequest
         * @param headers QueryAllDepartmentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAllDepartmentResponse
         */
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

        /**
         * @summary 获取当前组织下的所有科室
         *
         * @param request QueryAllDepartmentRequest
         * @return QueryAllDepartmentResponse
         */
        public QueryAllDepartmentResponse QueryAllDepartment(QueryAllDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllDepartmentHeaders headers = new QueryAllDepartmentHeaders();
            return QueryAllDepartmentWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取当前组织下的所有科室
         *
         * @param request QueryAllDepartmentRequest
         * @return QueryAllDepartmentResponse
         */
        public async Task<QueryAllDepartmentResponse> QueryAllDepartmentAsync(QueryAllDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllDepartmentHeaders headers = new QueryAllDepartmentHeaders();
            return await QueryAllDepartmentWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询医院下的所有医生
         *
         * @param request QueryAllDoctorsRequest
         * @param headers QueryAllDoctorsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAllDoctorsResponse
         */
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

        /**
         * @summary 查询医院下的所有医生
         *
         * @param request QueryAllDoctorsRequest
         * @param headers QueryAllDoctorsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAllDoctorsResponse
         */
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

        /**
         * @summary 查询医院下的所有医生
         *
         * @param request QueryAllDoctorsRequest
         * @return QueryAllDoctorsResponse
         */
        public QueryAllDoctorsResponse QueryAllDoctors(QueryAllDoctorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllDoctorsHeaders headers = new QueryAllDoctorsHeaders();
            return QueryAllDoctorsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询医院下的所有医生
         *
         * @param request QueryAllDoctorsRequest
         * @return QueryAllDoctorsResponse
         */
        public async Task<QueryAllDoctorsResponse> QueryAllDoctorsAsync(QueryAllDoctorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllDoctorsHeaders headers = new QueryAllDoctorsHeaders();
            return await QueryAllDoctorsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询所有医疗组
         *
         * @param request QueryAllGroupRequest
         * @param headers QueryAllGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAllGroupResponse
         */
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

        /**
         * @summary 查询所有医疗组
         *
         * @param request QueryAllGroupRequest
         * @param headers QueryAllGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAllGroupResponse
         */
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

        /**
         * @summary 查询所有医疗组
         *
         * @param request QueryAllGroupRequest
         * @return QueryAllGroupResponse
         */
        public QueryAllGroupResponse QueryAllGroup(QueryAllGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllGroupHeaders headers = new QueryAllGroupHeaders();
            return QueryAllGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询所有医疗组
         *
         * @param request QueryAllGroupRequest
         * @return QueryAllGroupResponse
         */
        public async Task<QueryAllGroupResponse> QueryAllGroupAsync(QueryAllGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllGroupHeaders headers = new QueryAllGroupHeaders();
            return await QueryAllGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询科室下的所有医疗组
         *
         * @param request QueryAllGroupsInDeptRequest
         * @param headers QueryAllGroupsInDeptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAllGroupsInDeptResponse
         */
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

        /**
         * @summary 查询科室下的所有医疗组
         *
         * @param request QueryAllGroupsInDeptRequest
         * @param headers QueryAllGroupsInDeptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAllGroupsInDeptResponse
         */
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

        /**
         * @summary 查询科室下的所有医疗组
         *
         * @param request QueryAllGroupsInDeptRequest
         * @return QueryAllGroupsInDeptResponse
         */
        public QueryAllGroupsInDeptResponse QueryAllGroupsInDept(string deptId, QueryAllGroupsInDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllGroupsInDeptHeaders headers = new QueryAllGroupsInDeptHeaders();
            return QueryAllGroupsInDeptWithOptions(deptId, request, headers, runtime);
        }

        /**
         * @summary 查询科室下的所有医疗组
         *
         * @param request QueryAllGroupsInDeptRequest
         * @return QueryAllGroupsInDeptResponse
         */
        public async Task<QueryAllGroupsInDeptResponse> QueryAllGroupsInDeptAsync(string deptId, QueryAllGroupsInDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllGroupsInDeptHeaders headers = new QueryAllGroupsInDeptHeaders();
            return await QueryAllGroupsInDeptWithOptionsAsync(deptId, request, headers, runtime);
        }

        /**
         * @summary 查询科室下的所有人员
         *
         * @param request QueryAllMemberByDeptRequest
         * @param headers QueryAllMemberByDeptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAllMemberByDeptResponse
         */
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

        /**
         * @summary 查询科室下的所有人员
         *
         * @param request QueryAllMemberByDeptRequest
         * @param headers QueryAllMemberByDeptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAllMemberByDeptResponse
         */
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

        /**
         * @summary 查询科室下的所有人员
         *
         * @param request QueryAllMemberByDeptRequest
         * @return QueryAllMemberByDeptResponse
         */
        public QueryAllMemberByDeptResponse QueryAllMemberByDept(string deptId, QueryAllMemberByDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllMemberByDeptHeaders headers = new QueryAllMemberByDeptHeaders();
            return QueryAllMemberByDeptWithOptions(deptId, request, headers, runtime);
        }

        /**
         * @summary 查询科室下的所有人员
         *
         * @param request QueryAllMemberByDeptRequest
         * @return QueryAllMemberByDeptResponse
         */
        public async Task<QueryAllMemberByDeptResponse> QueryAllMemberByDeptAsync(string deptId, QueryAllMemberByDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllMemberByDeptHeaders headers = new QueryAllMemberByDeptHeaders();
            return await QueryAllMemberByDeptWithOptionsAsync(deptId, request, headers, runtime);
        }

        /**
         * @summary 获取医疗组下面的所有成员
         *
         * @param request QueryAllMemberByGroupRequest
         * @param headers QueryAllMemberByGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAllMemberByGroupResponse
         */
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

        /**
         * @summary 获取医疗组下面的所有成员
         *
         * @param request QueryAllMemberByGroupRequest
         * @param headers QueryAllMemberByGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAllMemberByGroupResponse
         */
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

        /**
         * @summary 获取医疗组下面的所有成员
         *
         * @param request QueryAllMemberByGroupRequest
         * @return QueryAllMemberByGroupResponse
         */
        public QueryAllMemberByGroupResponse QueryAllMemberByGroup(string groupId, QueryAllMemberByGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllMemberByGroupHeaders headers = new QueryAllMemberByGroupHeaders();
            return QueryAllMemberByGroupWithOptions(groupId, request, headers, runtime);
        }

        /**
         * @summary 获取医疗组下面的所有成员
         *
         * @param request QueryAllMemberByGroupRequest
         * @return QueryAllMemberByGroupResponse
         */
        public async Task<QueryAllMemberByGroupResponse> QueryAllMemberByGroupAsync(string groupId, QueryAllMemberByGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllMemberByGroupHeaders headers = new QueryAllMemberByGroupHeaders();
            return await QueryAllMemberByGroupWithOptionsAsync(groupId, request, headers, runtime);
        }

        /**
         * @summary 获取当前企业医疗通讯录的业务操作日志
         *
         * @param request QueryBizOptLogRequest
         * @param headers QueryBizOptLogHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryBizOptLogResponse
         */
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

        /**
         * @summary 获取当前企业医疗通讯录的业务操作日志
         *
         * @param request QueryBizOptLogRequest
         * @param headers QueryBizOptLogHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryBizOptLogResponse
         */
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

        /**
         * @summary 获取当前企业医疗通讯录的业务操作日志
         *
         * @param request QueryBizOptLogRequest
         * @return QueryBizOptLogResponse
         */
        public QueryBizOptLogResponse QueryBizOptLog(QueryBizOptLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBizOptLogHeaders headers = new QueryBizOptLogHeaders();
            return QueryBizOptLogWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取当前企业医疗通讯录的业务操作日志
         *
         * @param request QueryBizOptLogRequest
         * @return QueryBizOptLogResponse
         */
        public async Task<QueryBizOptLogResponse> QueryBizOptLogAsync(QueryBizOptLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBizOptLogHeaders headers = new QueryBizOptLogHeaders();
            return await QueryBizOptLogWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询科室和医疗组的扩展信息
         *
         * @param request QueryDepartmentExtendInfoRequest
         * @param headers QueryDepartmentExtendInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDepartmentExtendInfoResponse
         */
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

        /**
         * @summary 查询科室和医疗组的扩展信息
         *
         * @param request QueryDepartmentExtendInfoRequest
         * @param headers QueryDepartmentExtendInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDepartmentExtendInfoResponse
         */
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

        /**
         * @summary 查询科室和医疗组的扩展信息
         *
         * @param request QueryDepartmentExtendInfoRequest
         * @return QueryDepartmentExtendInfoResponse
         */
        public QueryDepartmentExtendInfoResponse QueryDepartmentExtendInfo(QueryDepartmentExtendInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDepartmentExtendInfoHeaders headers = new QueryDepartmentExtendInfoHeaders();
            return QueryDepartmentExtendInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询科室和医疗组的扩展信息
         *
         * @param request QueryDepartmentExtendInfoRequest
         * @return QueryDepartmentExtendInfoResponse
         */
        public async Task<QueryDepartmentExtendInfoResponse> QueryDepartmentExtendInfoAsync(QueryDepartmentExtendInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDepartmentExtendInfoHeaders headers = new QueryDepartmentExtendInfoHeaders();
            return await QueryDepartmentExtendInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询部门详情
         *
         * @param headers QueryDepartmentInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDepartmentInfoResponse
         */
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

        /**
         * @summary 查询部门详情
         *
         * @param headers QueryDepartmentInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDepartmentInfoResponse
         */
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

        /**
         * @summary 查询部门详情
         *
         * @return QueryDepartmentInfoResponse
         */
        public QueryDepartmentInfoResponse QueryDepartmentInfo(string deptId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDepartmentInfoHeaders headers = new QueryDepartmentInfoHeaders();
            return QueryDepartmentInfoWithOptions(deptId, headers, runtime);
        }

        /**
         * @summary 查询部门详情
         *
         * @return QueryDepartmentInfoResponse
         */
        public async Task<QueryDepartmentInfoResponse> QueryDepartmentInfoAsync(string deptId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDepartmentInfoHeaders headers = new QueryDepartmentInfoHeaders();
            return await QueryDepartmentInfoWithOptionsAsync(deptId, headers, runtime);
        }

        /**
         * @summary 通过工号查询人员信息
         *
         * @param request QueryDoctorDetailsByJobNumberRequest
         * @param headers QueryDoctorDetailsByJobNumberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDoctorDetailsByJobNumberResponse
         */
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

        /**
         * @summary 通过工号查询人员信息
         *
         * @param request QueryDoctorDetailsByJobNumberRequest
         * @param headers QueryDoctorDetailsByJobNumberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDoctorDetailsByJobNumberResponse
         */
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

        /**
         * @summary 通过工号查询人员信息
         *
         * @param request QueryDoctorDetailsByJobNumberRequest
         * @return QueryDoctorDetailsByJobNumberResponse
         */
        public QueryDoctorDetailsByJobNumberResponse QueryDoctorDetailsByJobNumber(string jobNumber, QueryDoctorDetailsByJobNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDoctorDetailsByJobNumberHeaders headers = new QueryDoctorDetailsByJobNumberHeaders();
            return QueryDoctorDetailsByJobNumberWithOptions(jobNumber, request, headers, runtime);
        }

        /**
         * @summary 通过工号查询人员信息
         *
         * @param request QueryDoctorDetailsByJobNumberRequest
         * @return QueryDoctorDetailsByJobNumberResponse
         */
        public async Task<QueryDoctorDetailsByJobNumberResponse> QueryDoctorDetailsByJobNumberAsync(string jobNumber, QueryDoctorDetailsByJobNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDoctorDetailsByJobNumberHeaders headers = new QueryDoctorDetailsByJobNumberHeaders();
            return await QueryDoctorDetailsByJobNumberWithOptionsAsync(jobNumber, request, headers, runtime);
        }

        /**
         * @summary 获取医疗组详情
         *
         * @param headers QueryGroupInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryGroupInfoResponse
         */
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

        /**
         * @summary 获取医疗组详情
         *
         * @param headers QueryGroupInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryGroupInfoResponse
         */
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

        /**
         * @summary 获取医疗组详情
         *
         * @return QueryGroupInfoResponse
         */
        public QueryGroupInfoResponse QueryGroupInfo(string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGroupInfoHeaders headers = new QueryGroupInfoHeaders();
            return QueryGroupInfoWithOptions(groupId, headers, runtime);
        }

        /**
         * @summary 获取医疗组详情
         *
         * @return QueryGroupInfoResponse
         */
        public async Task<QueryGroupInfoResponse> QueryGroupInfoAsync(string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGroupInfoHeaders headers = new QueryGroupInfoHeaders();
            return await QueryGroupInfoWithOptionsAsync(groupId, headers, runtime);
        }

        /**
         * @summary 查询医院的院区和病区信息
         *
         * @param request QueryHospitalDistrictInfoRequest
         * @param headers QueryHospitalDistrictInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryHospitalDistrictInfoResponse
         */
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

        /**
         * @summary 查询医院的院区和病区信息
         *
         * @param request QueryHospitalDistrictInfoRequest
         * @param headers QueryHospitalDistrictInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryHospitalDistrictInfoResponse
         */
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

        /**
         * @summary 查询医院的院区和病区信息
         *
         * @param request QueryHospitalDistrictInfoRequest
         * @return QueryHospitalDistrictInfoResponse
         */
        public QueryHospitalDistrictInfoResponse QueryHospitalDistrictInfo(QueryHospitalDistrictInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryHospitalDistrictInfoHeaders headers = new QueryHospitalDistrictInfoHeaders();
            return QueryHospitalDistrictInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询医院的院区和病区信息
         *
         * @param request QueryHospitalDistrictInfoRequest
         * @return QueryHospitalDistrictInfoResponse
         */
        public async Task<QueryHospitalDistrictInfoResponse> QueryHospitalDistrictInfoAsync(QueryHospitalDistrictInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryHospitalDistrictInfoHeaders headers = new QueryHospitalDistrictInfoHeaders();
            return await QueryHospitalDistrictInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询医院所有角色的人员
         *
         * @param request QueryHospitalRoleUserInfoRequest
         * @param headers QueryHospitalRoleUserInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryHospitalRoleUserInfoResponse
         */
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

        /**
         * @summary 查询医院所有角色的人员
         *
         * @param request QueryHospitalRoleUserInfoRequest
         * @param headers QueryHospitalRoleUserInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryHospitalRoleUserInfoResponse
         */
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

        /**
         * @summary 查询医院所有角色的人员
         *
         * @param request QueryHospitalRoleUserInfoRequest
         * @return QueryHospitalRoleUserInfoResponse
         */
        public QueryHospitalRoleUserInfoResponse QueryHospitalRoleUserInfo(QueryHospitalRoleUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryHospitalRoleUserInfoHeaders headers = new QueryHospitalRoleUserInfoHeaders();
            return QueryHospitalRoleUserInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询医院所有角色的人员
         *
         * @param request QueryHospitalRoleUserInfoRequest
         * @return QueryHospitalRoleUserInfoResponse
         */
        public async Task<QueryHospitalRoleUserInfoResponse> QueryHospitalRoleUserInfoAsync(QueryHospitalRoleUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryHospitalRoleUserInfoHeaders headers = new QueryHospitalRoleUserInfoHeaders();
            return await QueryHospitalRoleUserInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询医院的角色
         *
         * @param headers QueryHospitalRolesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryHospitalRolesResponse
         */
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

        /**
         * @summary 查询医院的角色
         *
         * @param headers QueryHospitalRolesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryHospitalRolesResponse
         */
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

        /**
         * @summary 查询医院的角色
         *
         * @return QueryHospitalRolesResponse
         */
        public QueryHospitalRolesResponse QueryHospitalRoles()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryHospitalRolesHeaders headers = new QueryHospitalRolesHeaders();
            return QueryHospitalRolesWithOptions(headers, runtime);
        }

        /**
         * @summary 查询医院的角色
         *
         * @return QueryHospitalRolesResponse
         */
        public async Task<QueryHospitalRolesResponse> QueryHospitalRolesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryHospitalRolesHeaders headers = new QueryHospitalRolesHeaders();
            return await QueryHospitalRolesWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 查询职称字典表
         *
         * @param headers QueryJobCodeDictionaryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryJobCodeDictionaryResponse
         */
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

        /**
         * @summary 查询职称字典表
         *
         * @param headers QueryJobCodeDictionaryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryJobCodeDictionaryResponse
         */
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

        /**
         * @summary 查询职称字典表
         *
         * @return QueryJobCodeDictionaryResponse
         */
        public QueryJobCodeDictionaryResponse QueryJobCodeDictionary()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryJobCodeDictionaryHeaders headers = new QueryJobCodeDictionaryHeaders();
            return QueryJobCodeDictionaryWithOptions(headers, runtime);
        }

        /**
         * @summary 查询职称字典表
         *
         * @return QueryJobCodeDictionaryResponse
         */
        public async Task<QueryJobCodeDictionaryResponse> QueryJobCodeDictionaryAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryJobCodeDictionaryHeaders headers = new QueryJobCodeDictionaryHeaders();
            return await QueryJobCodeDictionaryWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 查询工作状态字典表
         *
         * @param headers QueryJobStatusCodeDictionaryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryJobStatusCodeDictionaryResponse
         */
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

        /**
         * @summary 查询工作状态字典表
         *
         * @param headers QueryJobStatusCodeDictionaryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryJobStatusCodeDictionaryResponse
         */
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

        /**
         * @summary 查询工作状态字典表
         *
         * @return QueryJobStatusCodeDictionaryResponse
         */
        public QueryJobStatusCodeDictionaryResponse QueryJobStatusCodeDictionary()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryJobStatusCodeDictionaryHeaders headers = new QueryJobStatusCodeDictionaryHeaders();
            return QueryJobStatusCodeDictionaryWithOptions(headers, runtime);
        }

        /**
         * @summary 查询工作状态字典表
         *
         * @return QueryJobStatusCodeDictionaryResponse
         */
        public async Task<QueryJobStatusCodeDictionaryResponse> QueryJobStatusCodeDictionaryAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryJobStatusCodeDictionaryHeaders headers = new QueryJobStatusCodeDictionaryHeaders();
            return await QueryJobStatusCodeDictionaryWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 查询医疗行业事件
         *
         * @param headers QueryMedicalEventsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMedicalEventsResponse
         */
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

        /**
         * @summary 查询医疗行业事件
         *
         * @param headers QueryMedicalEventsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMedicalEventsResponse
         */
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

        /**
         * @summary 查询医疗行业事件
         *
         * @return QueryMedicalEventsResponse
         */
        public QueryMedicalEventsResponse QueryMedicalEvents()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMedicalEventsHeaders headers = new QueryMedicalEventsHeaders();
            return QueryMedicalEventsWithOptions(headers, runtime);
        }

        /**
         * @summary 查询医疗行业事件
         *
         * @return QueryMedicalEventsResponse
         */
        public async Task<QueryMedicalEventsResponse> QueryMedicalEventsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMedicalEventsHeaders headers = new QueryMedicalEventsHeaders();
            return await QueryMedicalEventsWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 查询用户的证书
         *
         * @param request QueryUserCredentialsRequest
         * @param headers QueryUserCredentialsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserCredentialsResponse
         */
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

        /**
         * @summary 查询用户的证书
         *
         * @param request QueryUserCredentialsRequest
         * @param headers QueryUserCredentialsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserCredentialsResponse
         */
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

        /**
         * @summary 查询用户的证书
         *
         * @param request QueryUserCredentialsRequest
         * @return QueryUserCredentialsResponse
         */
        public QueryUserCredentialsResponse QueryUserCredentials(QueryUserCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserCredentialsHeaders headers = new QueryUserCredentialsHeaders();
            return QueryUserCredentialsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询用户的证书
         *
         * @param request QueryUserCredentialsRequest
         * @return QueryUserCredentialsResponse
         */
        public async Task<QueryUserCredentialsResponse> QueryUserCredentialsAsync(QueryUserCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserCredentialsHeaders headers = new QueryUserCredentialsHeaders();
            return await QueryUserCredentialsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询人员的扩展信息
         *
         * @param headers QueryUserExtInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserExtInfoResponse
         */
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

        /**
         * @summary 查询人员的扩展信息
         *
         * @param headers QueryUserExtInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserExtInfoResponse
         */
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

        /**
         * @summary 查询人员的扩展信息
         *
         * @return QueryUserExtInfoResponse
         */
        public QueryUserExtInfoResponse QueryUserExtInfo(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserExtInfoHeaders headers = new QueryUserExtInfoHeaders();
            return QueryUserExtInfoWithOptions(userId, headers, runtime);
        }

        /**
         * @summary 查询人员的扩展信息
         *
         * @return QueryUserExtInfoResponse
         */
        public async Task<QueryUserExtInfoResponse> QueryUserExtInfoAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserExtInfoHeaders headers = new QueryUserExtInfoHeaders();
            return await QueryUserExtInfoWithOptionsAsync(userId, headers, runtime);
        }

        /**
         * @summary 获取用户拓展字段
         *
         * @param request QueryUserExtendValuesRequest
         * @param headers QueryUserExtendValuesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserExtendValuesResponse
         */
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

        /**
         * @summary 获取用户拓展字段
         *
         * @param request QueryUserExtendValuesRequest
         * @param headers QueryUserExtendValuesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserExtendValuesResponse
         */
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

        /**
         * @summary 获取用户拓展字段
         *
         * @param request QueryUserExtendValuesRequest
         * @return QueryUserExtendValuesResponse
         */
        public QueryUserExtendValuesResponse QueryUserExtendValues(QueryUserExtendValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserExtendValuesHeaders headers = new QueryUserExtendValuesHeaders();
            return QueryUserExtendValuesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取用户拓展字段
         *
         * @param request QueryUserExtendValuesRequest
         * @return QueryUserExtendValuesResponse
         */
        public async Task<QueryUserExtendValuesResponse> QueryUserExtendValuesAsync(QueryUserExtendValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserExtendValuesHeaders headers = new QueryUserExtendValuesHeaders();
            return await QueryUserExtendValuesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询人员详情
         *
         * @param request QueryUserInfoRequest
         * @param headers QueryUserInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserInfoResponse
         */
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

        /**
         * @summary 查询人员详情
         *
         * @param request QueryUserInfoRequest
         * @param headers QueryUserInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserInfoResponse
         */
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

        /**
         * @summary 查询人员详情
         *
         * @param request QueryUserInfoRequest
         * @return QueryUserInfoResponse
         */
        public QueryUserInfoResponse QueryUserInfo(string userId, QueryUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserInfoHeaders headers = new QueryUserInfoHeaders();
            return QueryUserInfoWithOptions(userId, request, headers, runtime);
        }

        /**
         * @summary 查询人员详情
         *
         * @param request QueryUserInfoRequest
         * @return QueryUserInfoResponse
         */
        public async Task<QueryUserInfoResponse> QueryUserInfoAsync(string userId, QueryUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserInfoHeaders headers = new QueryUserInfoHeaders();
            return await QueryUserInfoWithOptionsAsync(userId, request, headers, runtime);
        }

        /**
         * @summary 查询人员属性字典表
         *
         * @param headers QueryUserProbCodeDictionaryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserProbCodeDictionaryResponse
         */
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

        /**
         * @summary 查询人员属性字典表
         *
         * @param headers QueryUserProbCodeDictionaryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserProbCodeDictionaryResponse
         */
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

        /**
         * @summary 查询人员属性字典表
         *
         * @return QueryUserProbCodeDictionaryResponse
         */
        public QueryUserProbCodeDictionaryResponse QueryUserProbCodeDictionary()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserProbCodeDictionaryHeaders headers = new QueryUserProbCodeDictionaryHeaders();
            return QueryUserProbCodeDictionaryWithOptions(headers, runtime);
        }

        /**
         * @summary 查询人员属性字典表
         *
         * @return QueryUserProbCodeDictionaryResponse
         */
        public async Task<QueryUserProbCodeDictionaryResponse> QueryUserProbCodeDictionaryAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserProbCodeDictionaryHeaders headers = new QueryUserProbCodeDictionaryHeaders();
            return await QueryUserProbCodeDictionaryWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 查询人员权限
         *
         * @param headers QueryUserRolesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserRolesResponse
         */
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

        /**
         * @summary 查询人员权限
         *
         * @param headers QueryUserRolesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserRolesResponse
         */
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

        /**
         * @summary 查询人员权限
         *
         * @return QueryUserRolesResponse
         */
        public QueryUserRolesResponse QueryUserRoles(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserRolesHeaders headers = new QueryUserRolesHeaders();
            return QueryUserRolesWithOptions(userId, headers, runtime);
        }

        /**
         * @summary 查询人员权限
         *
         * @return QueryUserRolesResponse
         */
        public async Task<QueryUserRolesResponse> QueryUserRolesAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserRolesHeaders headers = new QueryUserRolesHeaders();
            return await QueryUserRolesWithOptionsAsync(userId, headers, runtime);
        }

        /**
         * @summary 保存用户拓展字段
         *
         * @param request SaveUserExtendValuesRequest
         * @param headers SaveUserExtendValuesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveUserExtendValuesResponse
         */
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

        /**
         * @summary 保存用户拓展字段
         *
         * @param request SaveUserExtendValuesRequest
         * @param headers SaveUserExtendValuesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveUserExtendValuesResponse
         */
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

        /**
         * @summary 保存用户拓展字段
         *
         * @param request SaveUserExtendValuesRequest
         * @return SaveUserExtendValuesResponse
         */
        public SaveUserExtendValuesResponse SaveUserExtendValues(string userId, SaveUserExtendValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveUserExtendValuesHeaders headers = new SaveUserExtendValuesHeaders();
            return SaveUserExtendValuesWithOptions(userId, request, headers, runtime);
        }

        /**
         * @summary 保存用户拓展字段
         *
         * @param request SaveUserExtendValuesRequest
         * @return SaveUserExtendValuesResponse
         */
        public async Task<SaveUserExtendValuesResponse> SaveUserExtendValuesAsync(string userId, SaveUserExtendValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveUserExtendValuesHeaders headers = new SaveUserExtendValuesHeaders();
            return await SaveUserExtendValuesWithOptionsAsync(userId, request, headers, runtime);
        }

        /**
         * @summary 增加角色或角色组
         *
         * @param request SupplAddRoleRequest
         * @param headers SupplAddRoleHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplAddRoleResponse
         */
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

        /**
         * @summary 增加角色或角色组
         *
         * @param request SupplAddRoleRequest
         * @param headers SupplAddRoleHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplAddRoleResponse
         */
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

        /**
         * @summary 增加角色或角色组
         *
         * @param request SupplAddRoleRequest
         * @return SupplAddRoleResponse
         */
        public SupplAddRoleResponse SupplAddRole(SupplAddRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplAddRoleHeaders headers = new SupplAddRoleHeaders();
            return SupplAddRoleWithOptions(request, headers, runtime);
        }

        /**
         * @summary 增加角色或角色组
         *
         * @param request SupplAddRoleRequest
         * @return SupplAddRoleResponse
         */
        public async Task<SupplAddRoleResponse> SupplAddRoleAsync(SupplAddRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplAddRoleHeaders headers = new SupplAddRoleHeaders();
            return await SupplAddRoleWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 新增供应链节点
         *
         * @param request SupplyAddDeptRequest
         * @param headers SupplyAddDeptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyAddDeptResponse
         */
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

        /**
         * @summary 新增供应链节点
         *
         * @param request SupplyAddDeptRequest
         * @param headers SupplyAddDeptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyAddDeptResponse
         */
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

        /**
         * @summary 新增供应链节点
         *
         * @param request SupplyAddDeptRequest
         * @return SupplyAddDeptResponse
         */
        public SupplyAddDeptResponse SupplyAddDept(SupplyAddDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyAddDeptHeaders headers = new SupplyAddDeptHeaders();
            return SupplyAddDeptWithOptions(request, headers, runtime);
        }

        /**
         * @summary 新增供应链节点
         *
         * @param request SupplyAddDeptRequest
         * @return SupplyAddDeptResponse
         */
        public async Task<SupplyAddDeptResponse> SupplyAddDeptAsync(SupplyAddDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyAddDeptHeaders headers = new SupplyAddDeptHeaders();
            return await SupplyAddDeptWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 添加供应商人员
         *
         * @param request SupplyAddMemberRequest
         * @param headers SupplyAddMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyAddMemberResponse
         */
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

        /**
         * @summary 添加供应商人员
         *
         * @param request SupplyAddMemberRequest
         * @param headers SupplyAddMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyAddMemberResponse
         */
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

        /**
         * @summary 添加供应商人员
         *
         * @param request SupplyAddMemberRequest
         * @return SupplyAddMemberResponse
         */
        public SupplyAddMemberResponse SupplyAddMember(SupplyAddMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyAddMemberHeaders headers = new SupplyAddMemberHeaders();
            return SupplyAddMemberWithOptions(request, headers, runtime);
        }

        /**
         * @summary 添加供应商人员
         *
         * @param request SupplyAddMemberRequest
         * @return SupplyAddMemberResponse
         */
        public async Task<SupplyAddMemberResponse> SupplyAddMemberAsync(SupplyAddMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyAddMemberHeaders headers = new SupplyAddMemberHeaders();
            return await SupplyAddMemberWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 添加伙伴负责人
         *
         * @param request SupplyAddPartnerAdminsRequest
         * @param headers SupplyAddPartnerAdminsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyAddPartnerAdminsResponse
         */
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

        /**
         * @summary 添加伙伴负责人
         *
         * @param request SupplyAddPartnerAdminsRequest
         * @param headers SupplyAddPartnerAdminsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyAddPartnerAdminsResponse
         */
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

        /**
         * @summary 添加伙伴负责人
         *
         * @param request SupplyAddPartnerAdminsRequest
         * @return SupplyAddPartnerAdminsResponse
         */
        public SupplyAddPartnerAdminsResponse SupplyAddPartnerAdmins(SupplyAddPartnerAdminsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyAddPartnerAdminsHeaders headers = new SupplyAddPartnerAdminsHeaders();
            return SupplyAddPartnerAdminsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 添加伙伴负责人
         *
         * @param request SupplyAddPartnerAdminsRequest
         * @return SupplyAddPartnerAdminsResponse
         */
        public async Task<SupplyAddPartnerAdminsResponse> SupplyAddPartnerAdminsAsync(SupplyAddPartnerAdminsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyAddPartnerAdminsHeaders headers = new SupplyAddPartnerAdminsHeaders();
            return await SupplyAddPartnerAdminsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 添加伙伴的对接人或对接部门
         *
         * @param request SupplyAddPartnerManagersRequest
         * @param headers SupplyAddPartnerManagersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyAddPartnerManagersResponse
         */
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

        /**
         * @summary 添加伙伴的对接人或对接部门
         *
         * @param request SupplyAddPartnerManagersRequest
         * @param headers SupplyAddPartnerManagersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyAddPartnerManagersResponse
         */
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

        /**
         * @summary 添加伙伴的对接人或对接部门
         *
         * @param request SupplyAddPartnerManagersRequest
         * @return SupplyAddPartnerManagersResponse
         */
        public SupplyAddPartnerManagersResponse SupplyAddPartnerManagers(SupplyAddPartnerManagersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyAddPartnerManagersHeaders headers = new SupplyAddPartnerManagersHeaders();
            return SupplyAddPartnerManagersWithOptions(request, headers, runtime);
        }

        /**
         * @summary 添加伙伴的对接人或对接部门
         *
         * @param request SupplyAddPartnerManagersRequest
         * @return SupplyAddPartnerManagersResponse
         */
        public async Task<SupplyAddPartnerManagersResponse> SupplyAddPartnerManagersAsync(SupplyAddPartnerManagersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyAddPartnerManagersHeaders headers = new SupplyAddPartnerManagersHeaders();
            return await SupplyAddPartnerManagersWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 添加伙伴标签
         *
         * @param request SupplyAddPartnerTypeRequest
         * @param headers SupplyAddPartnerTypeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyAddPartnerTypeResponse
         */
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

        /**
         * @summary 添加伙伴标签
         *
         * @param request SupplyAddPartnerTypeRequest
         * @param headers SupplyAddPartnerTypeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyAddPartnerTypeResponse
         */
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

        /**
         * @summary 添加伙伴标签
         *
         * @param request SupplyAddPartnerTypeRequest
         * @return SupplyAddPartnerTypeResponse
         */
        public SupplyAddPartnerTypeResponse SupplyAddPartnerType(SupplyAddPartnerTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyAddPartnerTypeHeaders headers = new SupplyAddPartnerTypeHeaders();
            return SupplyAddPartnerTypeWithOptions(request, headers, runtime);
        }

        /**
         * @summary 添加伙伴标签
         *
         * @param request SupplyAddPartnerTypeRequest
         * @return SupplyAddPartnerTypeResponse
         */
        public async Task<SupplyAddPartnerTypeResponse> SupplyAddPartnerTypeAsync(SupplyAddPartnerTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyAddPartnerTypeHeaders headers = new SupplyAddPartnerTypeHeaders();
            return await SupplyAddPartnerTypeWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary  删除上下游节点
         *
         * @param request SupplyChainDeleteDeptRequest
         * @param headers SupplyChainDeleteDeptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyChainDeleteDeptResponse
         */
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

        /**
         * @summary  删除上下游节点
         *
         * @param request SupplyChainDeleteDeptRequest
         * @param headers SupplyChainDeleteDeptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyChainDeleteDeptResponse
         */
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

        /**
         * @summary  删除上下游节点
         *
         * @param request SupplyChainDeleteDeptRequest
         * @return SupplyChainDeleteDeptResponse
         */
        public SupplyChainDeleteDeptResponse SupplyChainDeleteDept(SupplyChainDeleteDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyChainDeleteDeptHeaders headers = new SupplyChainDeleteDeptHeaders();
            return SupplyChainDeleteDeptWithOptions(request, headers, runtime);
        }

        /**
         * @summary  删除上下游节点
         *
         * @param request SupplyChainDeleteDeptRequest
         * @return SupplyChainDeleteDeptResponse
         */
        public async Task<SupplyChainDeleteDeptResponse> SupplyChainDeleteDeptAsync(SupplyChainDeleteDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyChainDeleteDeptHeaders headers = new SupplyChainDeleteDeptHeaders();
            return await SupplyChainDeleteDeptWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询上下游节点信息
         *
         * @param request SupplyChainQueryDeptInfoRequest
         * @param headers SupplyChainQueryDeptInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyChainQueryDeptInfoResponse
         */
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

        /**
         * @summary 查询上下游节点信息
         *
         * @param request SupplyChainQueryDeptInfoRequest
         * @param headers SupplyChainQueryDeptInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyChainQueryDeptInfoResponse
         */
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

        /**
         * @summary 查询上下游节点信息
         *
         * @param request SupplyChainQueryDeptInfoRequest
         * @return SupplyChainQueryDeptInfoResponse
         */
        public SupplyChainQueryDeptInfoResponse SupplyChainQueryDeptInfo(SupplyChainQueryDeptInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyChainQueryDeptInfoHeaders headers = new SupplyChainQueryDeptInfoHeaders();
            return SupplyChainQueryDeptInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询上下游节点信息
         *
         * @param request SupplyChainQueryDeptInfoRequest
         * @return SupplyChainQueryDeptInfoResponse
         */
        public async Task<SupplyChainQueryDeptInfoResponse> SupplyChainQueryDeptInfoAsync(SupplyChainQueryDeptInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyChainQueryDeptInfoHeaders headers = new SupplyChainQueryDeptInfoHeaders();
            return await SupplyChainQueryDeptInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新上下游节点信息
         *
         * @param request SupplyChainUpdateDeptInfoRequest
         * @param headers SupplyChainUpdateDeptInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyChainUpdateDeptInfoResponse
         */
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

        /**
         * @summary 更新上下游节点信息
         *
         * @param request SupplyChainUpdateDeptInfoRequest
         * @param headers SupplyChainUpdateDeptInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyChainUpdateDeptInfoResponse
         */
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

        /**
         * @summary 更新上下游节点信息
         *
         * @param request SupplyChainUpdateDeptInfoRequest
         * @return SupplyChainUpdateDeptInfoResponse
         */
        public SupplyChainUpdateDeptInfoResponse SupplyChainUpdateDeptInfo(SupplyChainUpdateDeptInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyChainUpdateDeptInfoHeaders headers = new SupplyChainUpdateDeptInfoHeaders();
            return SupplyChainUpdateDeptInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新上下游节点信息
         *
         * @param request SupplyChainUpdateDeptInfoRequest
         * @return SupplyChainUpdateDeptInfoResponse
         */
        public async Task<SupplyChainUpdateDeptInfoResponse> SupplyChainUpdateDeptInfoAsync(SupplyChainUpdateDeptInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyChainUpdateDeptInfoHeaders headers = new SupplyChainUpdateDeptInfoHeaders();
            return await SupplyChainUpdateDeptInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除伙伴成员
         *
         * @param request SupplyDeleteMemberRequest
         * @param headers SupplyDeleteMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyDeleteMemberResponse
         */
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

        /**
         * @summary 删除伙伴成员
         *
         * @param request SupplyDeleteMemberRequest
         * @param headers SupplyDeleteMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyDeleteMemberResponse
         */
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

        /**
         * @summary 删除伙伴成员
         *
         * @param request SupplyDeleteMemberRequest
         * @return SupplyDeleteMemberResponse
         */
        public SupplyDeleteMemberResponse SupplyDeleteMember(SupplyDeleteMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyDeleteMemberHeaders headers = new SupplyDeleteMemberHeaders();
            return SupplyDeleteMemberWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除伙伴成员
         *
         * @param request SupplyDeleteMemberRequest
         * @return SupplyDeleteMemberResponse
         */
        public async Task<SupplyDeleteMemberResponse> SupplyDeleteMemberAsync(SupplyDeleteMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyDeleteMemberHeaders headers = new SupplyDeleteMemberHeaders();
            return await SupplyDeleteMemberWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除伙伴负责人
         *
         * @param request SupplyDeletePartnerAdminsRequest
         * @param headers SupplyDeletePartnerAdminsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyDeletePartnerAdminsResponse
         */
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

        /**
         * @summary 删除伙伴负责人
         *
         * @param request SupplyDeletePartnerAdminsRequest
         * @param headers SupplyDeletePartnerAdminsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyDeletePartnerAdminsResponse
         */
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

        /**
         * @summary 删除伙伴负责人
         *
         * @param request SupplyDeletePartnerAdminsRequest
         * @return SupplyDeletePartnerAdminsResponse
         */
        public SupplyDeletePartnerAdminsResponse SupplyDeletePartnerAdmins(SupplyDeletePartnerAdminsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyDeletePartnerAdminsHeaders headers = new SupplyDeletePartnerAdminsHeaders();
            return SupplyDeletePartnerAdminsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除伙伴负责人
         *
         * @param request SupplyDeletePartnerAdminsRequest
         * @return SupplyDeletePartnerAdminsResponse
         */
        public async Task<SupplyDeletePartnerAdminsResponse> SupplyDeletePartnerAdminsAsync(SupplyDeletePartnerAdminsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyDeletePartnerAdminsHeaders headers = new SupplyDeletePartnerAdminsHeaders();
            return await SupplyDeletePartnerAdminsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 移除伙伴的对接人或对接部门
         *
         * @param request SupplyDeletePartnerManagersRequest
         * @param headers SupplyDeletePartnerManagersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyDeletePartnerManagersResponse
         */
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

        /**
         * @summary 移除伙伴的对接人或对接部门
         *
         * @param request SupplyDeletePartnerManagersRequest
         * @param headers SupplyDeletePartnerManagersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyDeletePartnerManagersResponse
         */
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

        /**
         * @summary 移除伙伴的对接人或对接部门
         *
         * @param request SupplyDeletePartnerManagersRequest
         * @return SupplyDeletePartnerManagersResponse
         */
        public SupplyDeletePartnerManagersResponse SupplyDeletePartnerManagers(SupplyDeletePartnerManagersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyDeletePartnerManagersHeaders headers = new SupplyDeletePartnerManagersHeaders();
            return SupplyDeletePartnerManagersWithOptions(request, headers, runtime);
        }

        /**
         * @summary 移除伙伴的对接人或对接部门
         *
         * @param request SupplyDeletePartnerManagersRequest
         * @return SupplyDeletePartnerManagersResponse
         */
        public async Task<SupplyDeletePartnerManagersResponse> SupplyDeletePartnerManagersAsync(SupplyDeletePartnerManagersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyDeletePartnerManagersHeaders headers = new SupplyDeletePartnerManagersHeaders();
            return await SupplyDeletePartnerManagersWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除伙伴标签
         *
         * @param request SupplyDeletePartnerTypeRequest
         * @param headers SupplyDeletePartnerTypeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyDeletePartnerTypeResponse
         */
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

        /**
         * @summary 删除伙伴标签
         *
         * @param request SupplyDeletePartnerTypeRequest
         * @param headers SupplyDeletePartnerTypeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyDeletePartnerTypeResponse
         */
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

        /**
         * @summary 删除伙伴标签
         *
         * @param request SupplyDeletePartnerTypeRequest
         * @return SupplyDeletePartnerTypeResponse
         */
        public SupplyDeletePartnerTypeResponse SupplyDeletePartnerType(SupplyDeletePartnerTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyDeletePartnerTypeHeaders headers = new SupplyDeletePartnerTypeHeaders();
            return SupplyDeletePartnerTypeWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除伙伴标签
         *
         * @param request SupplyDeletePartnerTypeRequest
         * @return SupplyDeletePartnerTypeResponse
         */
        public async Task<SupplyDeletePartnerTypeResponse> SupplyDeletePartnerTypeAsync(SupplyDeletePartnerTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyDeletePartnerTypeHeaders headers = new SupplyDeletePartnerTypeHeaders();
            return await SupplyDeletePartnerTypeWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除角色或角色组
         *
         * @param request SupplyDeleteRoleRequest
         * @param headers SupplyDeleteRoleHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyDeleteRoleResponse
         */
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

        /**
         * @summary 删除角色或角色组
         *
         * @param request SupplyDeleteRoleRequest
         * @param headers SupplyDeleteRoleHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyDeleteRoleResponse
         */
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

        /**
         * @summary 删除角色或角色组
         *
         * @param request SupplyDeleteRoleRequest
         * @return SupplyDeleteRoleResponse
         */
        public SupplyDeleteRoleResponse SupplyDeleteRole(SupplyDeleteRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyDeleteRoleHeaders headers = new SupplyDeleteRoleHeaders();
            return SupplyDeleteRoleWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除角色或角色组
         *
         * @param request SupplyDeleteRoleRequest
         * @return SupplyDeleteRoleResponse
         */
        public async Task<SupplyDeleteRoleResponse> SupplyDeleteRoleAsync(SupplyDeleteRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyDeleteRoleHeaders headers = new SupplyDeleteRoleHeaders();
            return await SupplyDeleteRoleWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取供应链成员信息
         *
         * @param request SupplyGetMemberRequest
         * @param headers SupplyGetMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyGetMemberResponse
         */
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

        /**
         * @summary 获取供应链成员信息
         *
         * @param request SupplyGetMemberRequest
         * @param headers SupplyGetMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyGetMemberResponse
         */
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

        /**
         * @summary 获取供应链成员信息
         *
         * @param request SupplyGetMemberRequest
         * @return SupplyGetMemberResponse
         */
        public SupplyGetMemberResponse SupplyGetMember(SupplyGetMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyGetMemberHeaders headers = new SupplyGetMemberHeaders();
            return SupplyGetMemberWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取供应链成员信息
         *
         * @param request SupplyGetMemberRequest
         * @return SupplyGetMemberResponse
         */
        public async Task<SupplyGetMemberResponse> SupplyGetMemberAsync(SupplyGetMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyGetMemberHeaders headers = new SupplyGetMemberHeaders();
            return await SupplyGetMemberWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取供应链部门下成员
         *
         * @param request SupplyListDeptMembersRequest
         * @param headers SupplyListDeptMembersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyListDeptMembersResponse
         */
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

        /**
         * @summary 获取供应链部门下成员
         *
         * @param request SupplyListDeptMembersRequest
         * @param headers SupplyListDeptMembersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyListDeptMembersResponse
         */
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

        /**
         * @summary 获取供应链部门下成员
         *
         * @param request SupplyListDeptMembersRequest
         * @return SupplyListDeptMembersResponse
         */
        public SupplyListDeptMembersResponse SupplyListDeptMembers(SupplyListDeptMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyListDeptMembersHeaders headers = new SupplyListDeptMembersHeaders();
            return SupplyListDeptMembersWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取供应链部门下成员
         *
         * @param request SupplyListDeptMembersRequest
         * @return SupplyListDeptMembersResponse
         */
        public async Task<SupplyListDeptMembersResponse> SupplyListDeptMembersAsync(SupplyListDeptMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyListDeptMembersHeaders headers = new SupplyListDeptMembersHeaders();
            return await SupplyListDeptMembersWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取伙伴负责人列表
         *
         * @param request SupplyListPartnerAdminsRequest
         * @param headers SupplyListPartnerAdminsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyListPartnerAdminsResponse
         */
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

        /**
         * @summary 获取伙伴负责人列表
         *
         * @param request SupplyListPartnerAdminsRequest
         * @param headers SupplyListPartnerAdminsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyListPartnerAdminsResponse
         */
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

        /**
         * @summary 获取伙伴负责人列表
         *
         * @param request SupplyListPartnerAdminsRequest
         * @return SupplyListPartnerAdminsResponse
         */
        public SupplyListPartnerAdminsResponse SupplyListPartnerAdmins(SupplyListPartnerAdminsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyListPartnerAdminsHeaders headers = new SupplyListPartnerAdminsHeaders();
            return SupplyListPartnerAdminsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取伙伴负责人列表
         *
         * @param request SupplyListPartnerAdminsRequest
         * @return SupplyListPartnerAdminsResponse
         */
        public async Task<SupplyListPartnerAdminsResponse> SupplyListPartnerAdminsAsync(SupplyListPartnerAdminsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyListPartnerAdminsHeaders headers = new SupplyListPartnerAdminsHeaders();
            return await SupplyListPartnerAdminsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取伙伴的对接人/对接部门
         *
         * @param request SupplyListPartnerManagersRequest
         * @param headers SupplyListPartnerManagersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyListPartnerManagersResponse
         */
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

        /**
         * @summary 获取伙伴的对接人/对接部门
         *
         * @param request SupplyListPartnerManagersRequest
         * @param headers SupplyListPartnerManagersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyListPartnerManagersResponse
         */
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

        /**
         * @summary 获取伙伴的对接人/对接部门
         *
         * @param request SupplyListPartnerManagersRequest
         * @return SupplyListPartnerManagersResponse
         */
        public SupplyListPartnerManagersResponse SupplyListPartnerManagers(SupplyListPartnerManagersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyListPartnerManagersHeaders headers = new SupplyListPartnerManagersHeaders();
            return SupplyListPartnerManagersWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取伙伴的对接人/对接部门
         *
         * @param request SupplyListPartnerManagersRequest
         * @return SupplyListPartnerManagersResponse
         */
        public async Task<SupplyListPartnerManagersResponse> SupplyListPartnerManagersAsync(SupplyListPartnerManagersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyListPartnerManagersHeaders headers = new SupplyListPartnerManagersHeaders();
            return await SupplyListPartnerManagersWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询下级伙伴标签
         *
         * @param request SupplyListPartnerTypeRequest
         * @param headers SupplyListPartnerTypeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyListPartnerTypeResponse
         */
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

        /**
         * @summary 查询下级伙伴标签
         *
         * @param request SupplyListPartnerTypeRequest
         * @param headers SupplyListPartnerTypeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyListPartnerTypeResponse
         */
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

        /**
         * @summary 查询下级伙伴标签
         *
         * @param request SupplyListPartnerTypeRequest
         * @return SupplyListPartnerTypeResponse
         */
        public SupplyListPartnerTypeResponse SupplyListPartnerType(SupplyListPartnerTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyListPartnerTypeHeaders headers = new SupplyListPartnerTypeHeaders();
            return SupplyListPartnerTypeWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询下级伙伴标签
         *
         * @param request SupplyListPartnerTypeRequest
         * @return SupplyListPartnerTypeResponse
         */
        public async Task<SupplyListPartnerTypeResponse> SupplyListPartnerTypeAsync(SupplyListPartnerTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyListPartnerTypeHeaders headers = new SupplyListPartnerTypeHeaders();
            return await SupplyListPartnerTypeWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询角色组或角色
         *
         * @param request SupplyListRoleRequest
         * @param headers SupplyListRoleHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyListRoleResponse
         */
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

        /**
         * @summary 查询角色组或角色
         *
         * @param request SupplyListRoleRequest
         * @param headers SupplyListRoleHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyListRoleResponse
         */
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

        /**
         * @summary 查询角色组或角色
         *
         * @param request SupplyListRoleRequest
         * @return SupplyListRoleResponse
         */
        public SupplyListRoleResponse SupplyListRole(SupplyListRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyListRoleHeaders headers = new SupplyListRoleHeaders();
            return SupplyListRoleWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询角色组或角色
         *
         * @param request SupplyListRoleRequest
         * @return SupplyListRoleResponse
         */
        public async Task<SupplyListRoleResponse> SupplyListRoleAsync(SupplyListRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyListRoleHeaders headers = new SupplyListRoleHeaders();
            return await SupplyListRoleWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询下级节点列表
         *
         * @param request SupplyListSubDeptRequest
         * @param headers SupplyListSubDeptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyListSubDeptResponse
         */
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

        /**
         * @summary 查询下级节点列表
         *
         * @param request SupplyListSubDeptRequest
         * @param headers SupplyListSubDeptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyListSubDeptResponse
         */
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

        /**
         * @summary 查询下级节点列表
         *
         * @param request SupplyListSubDeptRequest
         * @return SupplyListSubDeptResponse
         */
        public SupplyListSubDeptResponse SupplyListSubDept(SupplyListSubDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyListSubDeptHeaders headers = new SupplyListSubDeptHeaders();
            return SupplyListSubDeptWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询下级节点列表
         *
         * @param request SupplyListSubDeptRequest
         * @return SupplyListSubDeptResponse
         */
        public async Task<SupplyListSubDeptResponse> SupplyListSubDeptAsync(SupplyListSubDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyListSubDeptHeaders headers = new SupplyListSubDeptHeaders();
            return await SupplyListSubDeptWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询伙伴标签
         *
         * @param request SupplyQueryPartnerTypeRequest
         * @param headers SupplyQueryPartnerTypeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyQueryPartnerTypeResponse
         */
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

        /**
         * @summary 查询伙伴标签
         *
         * @param request SupplyQueryPartnerTypeRequest
         * @param headers SupplyQueryPartnerTypeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyQueryPartnerTypeResponse
         */
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

        /**
         * @summary 查询伙伴标签
         *
         * @param request SupplyQueryPartnerTypeRequest
         * @return SupplyQueryPartnerTypeResponse
         */
        public SupplyQueryPartnerTypeResponse SupplyQueryPartnerType(SupplyQueryPartnerTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyQueryPartnerTypeHeaders headers = new SupplyQueryPartnerTypeHeaders();
            return SupplyQueryPartnerTypeWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询伙伴标签
         *
         * @param request SupplyQueryPartnerTypeRequest
         * @return SupplyQueryPartnerTypeResponse
         */
        public async Task<SupplyQueryPartnerTypeResponse> SupplyQueryPartnerTypeAsync(SupplyQueryPartnerTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyQueryPartnerTypeHeaders headers = new SupplyQueryPartnerTypeHeaders();
            return await SupplyQueryPartnerTypeWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新供应商人员信息
         *
         * @param request SupplyUpdateMemberRequest
         * @param headers SupplyUpdateMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyUpdateMemberResponse
         */
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

        /**
         * @summary 更新供应商人员信息
         *
         * @param request SupplyUpdateMemberRequest
         * @param headers SupplyUpdateMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyUpdateMemberResponse
         */
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

        /**
         * @summary 更新供应商人员信息
         *
         * @param request SupplyUpdateMemberRequest
         * @return SupplyUpdateMemberResponse
         */
        public SupplyUpdateMemberResponse SupplyUpdateMember(SupplyUpdateMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyUpdateMemberHeaders headers = new SupplyUpdateMemberHeaders();
            return SupplyUpdateMemberWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新供应商人员信息
         *
         * @param request SupplyUpdateMemberRequest
         * @return SupplyUpdateMemberResponse
         */
        public async Task<SupplyUpdateMemberResponse> SupplyUpdateMemberAsync(SupplyUpdateMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyUpdateMemberHeaders headers = new SupplyUpdateMemberHeaders();
            return await SupplyUpdateMemberWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新伙伴标签
         *
         * @param request SupplyUpdatePartnerTypeRequest
         * @param headers SupplyUpdatePartnerTypeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyUpdatePartnerTypeResponse
         */
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

        /**
         * @summary 更新伙伴标签
         *
         * @param request SupplyUpdatePartnerTypeRequest
         * @param headers SupplyUpdatePartnerTypeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyUpdatePartnerTypeResponse
         */
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

        /**
         * @summary 更新伙伴标签
         *
         * @param request SupplyUpdatePartnerTypeRequest
         * @return SupplyUpdatePartnerTypeResponse
         */
        public SupplyUpdatePartnerTypeResponse SupplyUpdatePartnerType(SupplyUpdatePartnerTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyUpdatePartnerTypeHeaders headers = new SupplyUpdatePartnerTypeHeaders();
            return SupplyUpdatePartnerTypeWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新伙伴标签
         *
         * @param request SupplyUpdatePartnerTypeRequest
         * @return SupplyUpdatePartnerTypeResponse
         */
        public async Task<SupplyUpdatePartnerTypeResponse> SupplyUpdatePartnerTypeAsync(SupplyUpdatePartnerTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyUpdatePartnerTypeHeaders headers = new SupplyUpdatePartnerTypeHeaders();
            return await SupplyUpdatePartnerTypeWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新角色或角色组
         *
         * @param request SupplyUpdateRoleRequest
         * @param headers SupplyUpdateRoleHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyUpdateRoleResponse
         */
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

        /**
         * @summary 更新角色或角色组
         *
         * @param request SupplyUpdateRoleRequest
         * @param headers SupplyUpdateRoleHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SupplyUpdateRoleResponse
         */
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

        /**
         * @summary 更新角色或角色组
         *
         * @param request SupplyUpdateRoleRequest
         * @return SupplyUpdateRoleResponse
         */
        public SupplyUpdateRoleResponse SupplyUpdateRole(SupplyUpdateRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyUpdateRoleHeaders headers = new SupplyUpdateRoleHeaders();
            return SupplyUpdateRoleWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新角色或角色组
         *
         * @param request SupplyUpdateRoleRequest
         * @return SupplyUpdateRoleResponse
         */
        public async Task<SupplyUpdateRoleResponse> SupplyUpdateRoleAsync(SupplyUpdateRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyUpdateRoleHeaders headers = new SupplyUpdateRoleHeaders();
            return await SupplyUpdateRoleWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新医疗用户扩展信息
         *
         * @param request UpdateUserExtendInfoRequest
         * @param headers UpdateUserExtendInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUserExtendInfoResponse
         */
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

        /**
         * @summary 更新医疗用户扩展信息
         *
         * @param request UpdateUserExtendInfoRequest
         * @param headers UpdateUserExtendInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUserExtendInfoResponse
         */
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

        /**
         * @summary 更新医疗用户扩展信息
         *
         * @param request UpdateUserExtendInfoRequest
         * @return UpdateUserExtendInfoResponse
         */
        public UpdateUserExtendInfoResponse UpdateUserExtendInfo(string userId, UpdateUserExtendInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateUserExtendInfoHeaders headers = new UpdateUserExtendInfoHeaders();
            return UpdateUserExtendInfoWithOptions(userId, request, headers, runtime);
        }

        /**
         * @summary 更新医疗用户扩展信息
         *
         * @param request UpdateUserExtendInfoRequest
         * @return UpdateUserExtendInfoResponse
         */
        public async Task<UpdateUserExtendInfoResponse> UpdateUserExtendInfoAsync(string userId, UpdateUserExtendInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateUserExtendInfoHeaders headers = new UpdateUserExtendInfoHeaders();
            return await UpdateUserExtendInfoWithOptionsAsync(userId, request, headers, runtime);
        }

    }
}
