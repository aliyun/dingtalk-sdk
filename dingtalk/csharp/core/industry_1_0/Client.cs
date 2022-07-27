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

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
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
            return TeaModel.ToObject<CampusAddRenterMemberResponse>(DoROARequest("CampusAddRenterMember", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/campuses/renters/members", "json", req, runtime));
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
            return TeaModel.ToObject<CampusAddRenterMemberResponse>(await DoROARequestAsync("CampusAddRenterMember", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/campuses/renters/members", "json", req, runtime));
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
            return TeaModel.ToObject<CampusCreateCampusResponse>(DoROARequest("CampusCreateCampus", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/campuses/projects", "json", req, runtime));
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
            return TeaModel.ToObject<CampusCreateCampusResponse>(await DoROARequestAsync("CampusCreateCampus", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/campuses/projects", "json", req, runtime));
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
            return TeaModel.ToObject<CampusCreateCampusGroupResponse>(DoROARequest("CampusCreateCampusGroup", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/campuses/projects/groups", "json", req, runtime));
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
            return TeaModel.ToObject<CampusCreateCampusGroupResponse>(await DoROARequestAsync("CampusCreateCampusGroup", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/campuses/projects/groups", "json", req, runtime));
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
            return TeaModel.ToObject<CampusCreateRenterResponse>(DoROARequest("CampusCreateRenter", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/campuses/renters", "json", req, runtime));
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
            return TeaModel.ToObject<CampusCreateRenterResponse>(await DoROARequestAsync("CampusCreateRenter", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/campuses/renters", "json", req, runtime));
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
            return TeaModel.ToObject<CampusDelRenterMemberResponse>(DoROARequest("CampusDelRenterMember", "industry_1.0", "HTTP", "DELETE", "AK", "/v1.0/industry/campuses/renters/members", "json", req, runtime));
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
            return TeaModel.ToObject<CampusDelRenterMemberResponse>(await DoROARequestAsync("CampusDelRenterMember", "industry_1.0", "HTTP", "DELETE", "AK", "/v1.0/industry/campuses/renters/members", "json", req, runtime));
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
            return TeaModel.ToObject<CampusDeleteCampusGroupResponse>(DoROARequest("CampusDeleteCampusGroup", "industry_1.0", "HTTP", "DELETE", "AK", "/v1.0/industry/campuses/projects/groups", "json", req, runtime));
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
            return TeaModel.ToObject<CampusDeleteCampusGroupResponse>(await DoROARequestAsync("CampusDeleteCampusGroup", "industry_1.0", "HTTP", "DELETE", "AK", "/v1.0/industry/campuses/projects/groups", "json", req, runtime));
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
            return TeaModel.ToObject<CampusDeleteRenterResponse>(DoROARequest("CampusDeleteRenter", "industry_1.0", "HTTP", "DELETE", "AK", "/v1.0/industry/campuses/renters", "none", req, runtime));
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
            return TeaModel.ToObject<CampusDeleteRenterResponse>(await DoROARequestAsync("CampusDeleteRenter", "industry_1.0", "HTTP", "DELETE", "AK", "/v1.0/industry/campuses/renters", "none", req, runtime));
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
            return TeaModel.ToObject<CampusGetCampusResponse>(DoROARequest("CampusGetCampus", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/campuses/projectInfos", "json", req, runtime));
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
            return TeaModel.ToObject<CampusGetCampusResponse>(await DoROARequestAsync("CampusGetCampus", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/campuses/projectInfos", "json", req, runtime));
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
            return TeaModel.ToObject<CampusGetCampusGroupResponse>(DoROARequest("CampusGetCampusGroup", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/campuses/projects/groupInfos", "json", req, runtime));
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
            return TeaModel.ToObject<CampusGetCampusGroupResponse>(await DoROARequestAsync("CampusGetCampusGroup", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/campuses/projects/groupInfos", "json", req, runtime));
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
            return TeaModel.ToObject<CampusGetRenterResponse>(DoROARequest("CampusGetRenter", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/campuses/renterInfos", "json", req, runtime));
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
            return TeaModel.ToObject<CampusGetRenterResponse>(await DoROARequestAsync("CampusGetRenter", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/campuses/renterInfos", "json", req, runtime));
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
            return TeaModel.ToObject<CampusGetRenterMemberResponse>(DoROARequest("CampusGetRenterMember", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/campuses/renters/memberInfos", "json", req, runtime));
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
            return TeaModel.ToObject<CampusGetRenterMemberResponse>(await DoROARequestAsync("CampusGetRenterMember", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/campuses/renters/memberInfos", "json", req, runtime));
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
            return TeaModel.ToObject<CampusListCampusResponse>(DoROARequest("CampusListCampus", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/campuses/projects", "json", req, runtime));
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
            return TeaModel.ToObject<CampusListCampusResponse>(await DoROARequestAsync("CampusListCampus", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/campuses/projects", "json", req, runtime));
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
            return TeaModel.ToObject<CampusListCampusGroupResponse>(DoROARequest("CampusListCampusGroup", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/campuses/projects/groups", "json", req, runtime));
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
            return TeaModel.ToObject<CampusListCampusGroupResponse>(await DoROARequestAsync("CampusListCampusGroup", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/campuses/projects/groups", "json", req, runtime));
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
            return TeaModel.ToObject<CampusListRenterResponse>(DoROARequest("CampusListRenter", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/campuses/renters", "json", req, runtime));
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
            return TeaModel.ToObject<CampusListRenterResponse>(await DoROARequestAsync("CampusListRenter", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/campuses/renters", "json", req, runtime));
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
            return TeaModel.ToObject<CampusListRenterMembersResponse>(DoROARequest("CampusListRenterMembers", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/campuses/renters/members", "json", req, runtime));
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
            return TeaModel.ToObject<CampusListRenterMembersResponse>(await DoROARequestAsync("CampusListRenterMembers", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/campuses/renters/members", "json", req, runtime));
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
            return TeaModel.ToObject<CampusUpdateCampusResponse>(DoROARequest("CampusUpdateCampus", "industry_1.0", "HTTP", "PUT", "AK", "/v1.0/industry/campuses/projects", "json", req, runtime));
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
            return TeaModel.ToObject<CampusUpdateCampusResponse>(await DoROARequestAsync("CampusUpdateCampus", "industry_1.0", "HTTP", "PUT", "AK", "/v1.0/industry/campuses/projects", "json", req, runtime));
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
            return TeaModel.ToObject<CampusUpdateCampusGroupResponse>(DoROARequest("CampusUpdateCampusGroup", "industry_1.0", "HTTP", "PUT", "AK", "/v1.0/industry/campuses/projects/groups", "json", req, runtime));
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
            return TeaModel.ToObject<CampusUpdateCampusGroupResponse>(await DoROARequestAsync("CampusUpdateCampusGroup", "industry_1.0", "HTTP", "PUT", "AK", "/v1.0/industry/campuses/projects/groups", "json", req, runtime));
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
            return TeaModel.ToObject<CampusUpdateRenterResponse>(DoROARequest("CampusUpdateRenter", "industry_1.0", "HTTP", "PUT", "AK", "/v1.0/industry/campuses/renters", "json", req, runtime));
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
            return TeaModel.ToObject<CampusUpdateRenterResponse>(await DoROARequestAsync("CampusUpdateRenter", "industry_1.0", "HTTP", "PUT", "AK", "/v1.0/industry/campuses/renters", "json", req, runtime));
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
            return TeaModel.ToObject<CampusUpdateRenterMemberResponse>(DoROARequest("CampusUpdateRenterMember", "industry_1.0", "HTTP", "PUT", "AK", "/v1.0/industry/campuses/renters/members", "json", req, runtime));
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
            return TeaModel.ToObject<CampusUpdateRenterMemberResponse>(await DoROARequestAsync("CampusUpdateRenterMember", "industry_1.0", "HTTP", "PUT", "AK", "/v1.0/industry/campuses/renters/members", "json", req, runtime));
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
            return TeaModel.ToObject<CustomizeContactCreateResponse>(DoROARequest("CustomizeContactCreate", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/customizations/contacts", "json", req, runtime));
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
            return TeaModel.ToObject<CustomizeContactCreateResponse>(await DoROARequestAsync("CustomizeContactCreate", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/customizations/contacts", "json", req, runtime));
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
            return TeaModel.ToObject<CustomizeContactDeleteResponse>(DoROARequest("CustomizeContactDelete", "industry_1.0", "HTTP", "DELETE", "AK", "/v1.0/industry/customizations/contacts", "json", req, runtime));
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
            return TeaModel.ToObject<CustomizeContactDeleteResponse>(await DoROARequestAsync("CustomizeContactDelete", "industry_1.0", "HTTP", "DELETE", "AK", "/v1.0/industry/customizations/contacts", "json", req, runtime));
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
            return TeaModel.ToObject<CustomizeContactDeptCreateResponse>(DoROARequest("CustomizeContactDeptCreate", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/customizations/departments", "json", req, runtime));
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
            return TeaModel.ToObject<CustomizeContactDeptCreateResponse>(await DoROARequestAsync("CustomizeContactDeptCreate", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/customizations/departments", "json", req, runtime));
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
            return TeaModel.ToObject<CustomizeContactDeptDeleteResponse>(DoROARequest("CustomizeContactDeptDelete", "industry_1.0", "HTTP", "DELETE", "AK", "/v1.0/industry/customizations/departments", "json", req, runtime));
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
            return TeaModel.ToObject<CustomizeContactDeptDeleteResponse>(await DoROARequestAsync("CustomizeContactDeptDelete", "industry_1.0", "HTTP", "DELETE", "AK", "/v1.0/industry/customizations/departments", "json", req, runtime));
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
            return TeaModel.ToObject<CustomizeContactDeptInfoResponse>(DoROARequest("CustomizeContactDeptInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/customizations/departments", "json", req, runtime));
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
            return TeaModel.ToObject<CustomizeContactDeptInfoResponse>(await DoROARequestAsync("CustomizeContactDeptInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/customizations/departments", "json", req, runtime));
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
            return TeaModel.ToObject<CustomizeContactDeptListResponse>(DoROARequest("CustomizeContactDeptList", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/customizations/subsidiaryDepartments", "json", req, runtime));
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
            return TeaModel.ToObject<CustomizeContactDeptListResponse>(await DoROARequestAsync("CustomizeContactDeptList", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/customizations/subsidiaryDepartments", "json", req, runtime));
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
            return TeaModel.ToObject<CustomizeContactDeptUpdateResponse>(DoROARequest("CustomizeContactDeptUpdate", "industry_1.0", "HTTP", "PUT", "AK", "/v1.0/industry/customizations/departments", "json", req, runtime));
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
            return TeaModel.ToObject<CustomizeContactDeptUpdateResponse>(await DoROARequestAsync("CustomizeContactDeptUpdate", "industry_1.0", "HTTP", "PUT", "AK", "/v1.0/industry/customizations/departments", "json", req, runtime));
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
            return TeaModel.ToObject<CustomizeContactEmpAddResponse>(DoROARequest("CustomizeContactEmpAdd", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/customizations/users", "json", req, runtime));
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
            return TeaModel.ToObject<CustomizeContactEmpAddResponse>(await DoROARequestAsync("CustomizeContactEmpAdd", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/customizations/users", "json", req, runtime));
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
            return TeaModel.ToObject<CustomizeContactEmpDeleteResponse>(DoROARequest("CustomizeContactEmpDelete", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/customizations/users/remove", "json", req, runtime));
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
            return TeaModel.ToObject<CustomizeContactEmpDeleteResponse>(await DoROARequestAsync("CustomizeContactEmpDelete", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/customizations/users/remove", "json", req, runtime));
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
            return TeaModel.ToObject<CustomizeContactEmpListResponse>(DoROARequest("CustomizeContactEmpList", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/customizations/users", "json", req, runtime));
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
            return TeaModel.ToObject<CustomizeContactEmpListResponse>(await DoROARequestAsync("CustomizeContactEmpList", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/customizations/users", "json", req, runtime));
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
            return TeaModel.ToObject<CustomizeContactListResponse>(DoROARequest("CustomizeContactList", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/customizations/contacts", "json", req, runtime));
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
            return TeaModel.ToObject<CustomizeContactListResponse>(await DoROARequestAsync("CustomizeContactList", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/customizations/contacts", "json", req, runtime));
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
            return TeaModel.ToObject<CustomizeContactUpdateResponse>(DoROARequest("CustomizeContactUpdate", "industry_1.0", "HTTP", "PUT", "AK", "/v1.0/industry/customizations/contacts", "json", req, runtime));
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
            return TeaModel.ToObject<CustomizeContactUpdateResponse>(await DoROARequestAsync("CustomizeContactUpdate", "industry_1.0", "HTTP", "PUT", "AK", "/v1.0/industry/customizations/contacts", "json", req, runtime));
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
            return TeaModel.ToObject<DigitalStoreContactInfoResponse>(DoROARequest("DigitalStoreContactInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/digitalStores/contactInfos", "json", req, runtime));
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
            return TeaModel.ToObject<DigitalStoreContactInfoResponse>(await DoROARequestAsync("DigitalStoreContactInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/digitalStores/contactInfos", "json", req, runtime));
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
            return TeaModel.ToObject<DigitalStoreGroupInfoResponse>(DoROARequest("DigitalStoreGroupInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/digitalStores/groupInfos", "json", req, runtime));
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
            return TeaModel.ToObject<DigitalStoreGroupInfoResponse>(await DoROARequestAsync("DigitalStoreGroupInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/digitalStores/groupInfos", "json", req, runtime));
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
            return TeaModel.ToObject<DigitalStoreGroupsResponse>(DoROARequest("DigitalStoreGroups", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/digitalStores/groups", "json", req, runtime));
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
            return TeaModel.ToObject<DigitalStoreGroupsResponse>(await DoROARequestAsync("DigitalStoreGroups", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/digitalStores/groups", "json", req, runtime));
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
            return TeaModel.ToObject<DigitalStoreNodeInfoResponse>(DoROARequest("DigitalStoreNodeInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/digitalStores/nodeInfos", "json", req, runtime));
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
            return TeaModel.ToObject<DigitalStoreNodeInfoResponse>(await DoROARequestAsync("DigitalStoreNodeInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/digitalStores/nodeInfos", "json", req, runtime));
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
            return TeaModel.ToObject<DigitalStoreRightsInfoResponse>(DoROARequest("DigitalStoreRightsInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/digitalStores/rightsInfos", "json", req, runtime));
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
            return TeaModel.ToObject<DigitalStoreRightsInfoResponse>(await DoROARequestAsync("DigitalStoreRightsInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/digitalStores/rightsInfos", "json", req, runtime));
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
            return TeaModel.ToObject<DigitalStoreRolesResponse>(DoROARequest("DigitalStoreRoles", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/digitalStores/roles", "json", req, runtime));
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
            return TeaModel.ToObject<DigitalStoreRolesResponse>(await DoROARequestAsync("DigitalStoreRoles", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/digitalStores/roles", "json", req, runtime));
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
            return TeaModel.ToObject<DigitalStoreStoreInfoResponse>(DoROARequest("DigitalStoreStoreInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/digitalStores/storeInfos", "json", req, runtime));
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
            return TeaModel.ToObject<DigitalStoreStoreInfoResponse>(await DoROARequestAsync("DigitalStoreStoreInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/digitalStores/storeInfos", "json", req, runtime));
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
            return TeaModel.ToObject<DigitalStoreSubNodesResponse>(DoROARequest("DigitalStoreSubNodes", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/digitalStores/subsidiaryNodes", "json", req, runtime));
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
            return TeaModel.ToObject<DigitalStoreSubNodesResponse>(await DoROARequestAsync("DigitalStoreSubNodes", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/digitalStores/subsidiaryNodes", "json", req, runtime));
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
            return TeaModel.ToObject<DigitalStoreUserInfoResponse>(DoROARequest("DigitalStoreUserInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/digitalStores/userInfos", "json", req, runtime));
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
            return TeaModel.ToObject<DigitalStoreUserInfoResponse>(await DoROARequestAsync("DigitalStoreUserInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/digitalStores/userInfos", "json", req, runtime));
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
            return TeaModel.ToObject<DigitalStoreUsersResponse>(DoROARequest("DigitalStoreUsers", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/digitalStores/nodes/users", "json", req, runtime));
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
            return TeaModel.ToObject<DigitalStoreUsersResponse>(await DoROARequestAsync("DigitalStoreUsers", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/digitalStores/nodes/users", "json", req, runtime));
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
            return TeaModel.ToObject<ExternalQueryExternalAppOrgsResponse>(DoROARequest("ExternalQueryExternalAppOrgs", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/externals/apps/organizations", "json", req, runtime));
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
            return TeaModel.ToObject<ExternalQueryExternalAppOrgsResponse>(await DoROARequestAsync("ExternalQueryExternalAppOrgs", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/externals/apps/organizations", "json", req, runtime));
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
            return TeaModel.ToObject<ExternalQueryExternalBelongMainOrgResponse>(DoROARequest("ExternalQueryExternalBelongMainOrg", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/externals/attributions/masterOrganizations", "json", req, runtime));
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
            return TeaModel.ToObject<ExternalQueryExternalBelongMainOrgResponse>(await DoROARequestAsync("ExternalQueryExternalBelongMainOrg", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/externals/attributions/masterOrganizations", "json", req, runtime));
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
            return TeaModel.ToObject<ExternalQueryExternalOrgsResponse>(DoROARequest("ExternalQueryExternalOrgs", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/externals/organizations", "json", req, runtime));
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
            return TeaModel.ToObject<ExternalQueryExternalOrgsResponse>(await DoROARequestAsync("ExternalQueryExternalOrgs", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/externals/organizations", "json", req, runtime));
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
            return TeaModel.ToObject<IndustryManufactureCommonEventResponse>(DoROARequest("IndustryManufactureCommonEvent", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufacturing/bases/commons/events", "json", req, runtime));
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
            return TeaModel.ToObject<IndustryManufactureCommonEventResponse>(await DoROARequestAsync("IndustryManufactureCommonEvent", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufacturing/bases/commons/events", "json", req, runtime));
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
            return TeaModel.ToObject<IndustryManufactureCostRecordListGetResponse>(DoROARequest("IndustryManufactureCostRecordListGet", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufactures/materialCostRecords/query", "json", req, runtime));
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
            return TeaModel.ToObject<IndustryManufactureCostRecordListGetResponse>(await DoROARequestAsync("IndustryManufactureCostRecordListGet", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufactures/materialCostRecords/query", "json", req, runtime));
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
            return TeaModel.ToObject<IndustryManufactureFeeListGetResponse>(DoROARequest("IndustryManufactureFeeListGet", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufactures/fees/query", "json", req, runtime));
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
            return TeaModel.ToObject<IndustryManufactureFeeListGetResponse>(await DoROARequestAsync("IndustryManufactureFeeListGet", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufactures/fees/query", "json", req, runtime));
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
            return TeaModel.ToObject<IndustryManufactureLabourCostResponse>(DoROARequest("IndustryManufactureLabourCost", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufactures/labourCosts/query", "json", req, runtime));
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
            return TeaModel.ToObject<IndustryManufactureLabourCostResponse>(await DoROARequestAsync("IndustryManufactureLabourCost", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufactures/labourCosts/query", "json", req, runtime));
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
            return TeaModel.ToObject<IndustryManufactureMaterialListResponse>(DoROARequest("IndustryManufactureMaterialList", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufactures/materials/query", "json", req, runtime));
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
            return TeaModel.ToObject<IndustryManufactureMaterialListResponse>(await DoROARequestAsync("IndustryManufactureMaterialList", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufactures/materials/query", "json", req, runtime));
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
            return TeaModel.ToObject<IndustryManufactureMesMaterialResponse>(DoROARequest("IndustryManufactureMesMaterial", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufacturings/materials/manage", "json", req, runtime));
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
            return TeaModel.ToObject<IndustryManufactureMesMaterialResponse>(await DoROARequestAsync("IndustryManufactureMesMaterial", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufacturings/materials/manage", "json", req, runtime));
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
            return TeaModel.ToObject<IndustryManufactureMesProcessResponse>(DoROARequest("IndustryManufactureMesProcess", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufacturings/processes/manage", "json", req, runtime));
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
            return TeaModel.ToObject<IndustryManufactureMesProcessResponse>(await DoROARequestAsync("IndustryManufactureMesProcess", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufacturings/processes/manage", "json", req, runtime));
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
            return TeaModel.ToObject<IndustryManufactureMesProductionPlanResponse>(DoROARequest("IndustryManufactureMesProductionPlan", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufacturings/productionPlans/manage", "json", req, runtime));
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
            return TeaModel.ToObject<IndustryManufactureMesProductionPlanResponse>(await DoROARequestAsync("IndustryManufactureMesProductionPlan", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufacturings/productionPlans/manage", "json", req, runtime));
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
            return TeaModel.ToObject<IndustryManufactureMesTeamMgmtResponse>(DoROARequest("IndustryManufactureMesTeamMgmt", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufacturing/base/data/team", "json", req, runtime));
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
            return TeaModel.ToObject<IndustryManufactureMesTeamMgmtResponse>(await DoROARequestAsync("IndustryManufactureMesTeamMgmt", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufacturing/base/data/team", "json", req, runtime));
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
            return TeaModel.ToObject<IndustryMmanufactureMaterialCostGetResponse>(DoROARequest("IndustryMmanufactureMaterialCostGet", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufactures/base/materialCosts/query", "json", req, runtime));
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
            return TeaModel.ToObject<IndustryMmanufactureMaterialCostGetResponse>(await DoROARequestAsync("IndustryMmanufactureMaterialCostGet", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufactures/base/materialCosts/query", "json", req, runtime));
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
            return TeaModel.ToObject<PushDingMessageResponse>(DoROARequest("PushDingMessage", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/works/notice", "json", req, runtime));
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
            return TeaModel.ToObject<PushDingMessageResponse>(await DoROARequestAsync("PushDingMessage", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/works/notice", "json", req, runtime));
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
            return TeaModel.ToObject<QueryAllDepartmentResponse>(DoROARequest("QueryAllDepartment", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/departments", "json", req, runtime));
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
            return TeaModel.ToObject<QueryAllDepartmentResponse>(await DoROARequestAsync("QueryAllDepartment", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/departments", "json", req, runtime));
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
            return TeaModel.ToObject<QueryAllDoctorsResponse>(DoROARequest("QueryAllDoctors", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/doctors", "json", req, runtime));
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
            return TeaModel.ToObject<QueryAllDoctorsResponse>(await DoROARequestAsync("QueryAllDoctors", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/doctors", "json", req, runtime));
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
            return TeaModel.ToObject<QueryAllGroupResponse>(DoROARequest("QueryAllGroup", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/groups", "json", req, runtime));
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
            return TeaModel.ToObject<QueryAllGroupResponse>(await DoROARequestAsync("QueryAllGroup", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/groups", "json", req, runtime));
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

        public QueryAllGroupsInDeptResponse QueryAllGroupsInDeptWithOptions(string deptId, QueryAllGroupsInDeptRequest request, QueryAllGroupsInDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            deptId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deptId);
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
            return TeaModel.ToObject<QueryAllGroupsInDeptResponse>(DoROARequest("QueryAllGroupsInDept", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/departments/" + deptId + "/groups", "json", req, runtime));
        }

        public async Task<QueryAllGroupsInDeptResponse> QueryAllGroupsInDeptWithOptionsAsync(string deptId, QueryAllGroupsInDeptRequest request, QueryAllGroupsInDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            deptId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deptId);
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
            return TeaModel.ToObject<QueryAllGroupsInDeptResponse>(await DoROARequestAsync("QueryAllGroupsInDept", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/departments/" + deptId + "/groups", "json", req, runtime));
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

        public QueryAllMemberByDeptResponse QueryAllMemberByDeptWithOptions(string deptId, QueryAllMemberByDeptRequest request, QueryAllMemberByDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            deptId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deptId);
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
            return TeaModel.ToObject<QueryAllMemberByDeptResponse>(DoROARequest("QueryAllMemberByDept", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/departments/" + deptId + "/members", "json", req, runtime));
        }

        public async Task<QueryAllMemberByDeptResponse> QueryAllMemberByDeptWithOptionsAsync(string deptId, QueryAllMemberByDeptRequest request, QueryAllMemberByDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            deptId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deptId);
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
            return TeaModel.ToObject<QueryAllMemberByDeptResponse>(await DoROARequestAsync("QueryAllMemberByDept", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/departments/" + deptId + "/members", "json", req, runtime));
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

        public QueryAllMemberByGroupResponse QueryAllMemberByGroupWithOptions(string groupId, QueryAllMemberByGroupRequest request, QueryAllMemberByGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            groupId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId);
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
            return TeaModel.ToObject<QueryAllMemberByGroupResponse>(DoROARequest("QueryAllMemberByGroup", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/groups/" + groupId + "/members", "json", req, runtime));
        }

        public async Task<QueryAllMemberByGroupResponse> QueryAllMemberByGroupWithOptionsAsync(string groupId, QueryAllMemberByGroupRequest request, QueryAllMemberByGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            groupId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId);
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
            return TeaModel.ToObject<QueryAllMemberByGroupResponse>(await DoROARequestAsync("QueryAllMemberByGroup", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/groups/" + groupId + "/members", "json", req, runtime));
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
            return TeaModel.ToObject<QueryBizOptLogResponse>(DoROARequest("QueryBizOptLog", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/bizOptLogs", "json", req, runtime));
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
            return TeaModel.ToObject<QueryBizOptLogResponse>(await DoROARequestAsync("QueryBizOptLog", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/bizOptLogs", "json", req, runtime));
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
            return TeaModel.ToObject<QueryDepartmentExtendInfoResponse>(DoROARequest("QueryDepartmentExtendInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/departments/extensions/infos", "json", req, runtime));
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
            return TeaModel.ToObject<QueryDepartmentExtendInfoResponse>(await DoROARequestAsync("QueryDepartmentExtendInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/departments/extensions/infos", "json", req, runtime));
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

        public QueryDepartmentInfoResponse QueryDepartmentInfoWithOptions(string deptId, QueryDepartmentInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            deptId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deptId);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<QueryDepartmentInfoResponse>(DoROARequest("QueryDepartmentInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/departments/" + deptId, "json", req, runtime));
        }

        public async Task<QueryDepartmentInfoResponse> QueryDepartmentInfoWithOptionsAsync(string deptId, QueryDepartmentInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            deptId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deptId);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<QueryDepartmentInfoResponse>(await DoROARequestAsync("QueryDepartmentInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/departments/" + deptId, "json", req, runtime));
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

        public QueryGroupInfoResponse QueryGroupInfoWithOptions(string groupId, QueryGroupInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            groupId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<QueryGroupInfoResponse>(DoROARequest("QueryGroupInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/groups/" + groupId, "json", req, runtime));
        }

        public async Task<QueryGroupInfoResponse> QueryGroupInfoWithOptionsAsync(string groupId, QueryGroupInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            groupId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<QueryGroupInfoResponse>(await DoROARequestAsync("QueryGroupInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/groups/" + groupId, "json", req, runtime));
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
            return TeaModel.ToObject<QueryHospitalDistrictInfoResponse>(DoROARequest("QueryHospitalDistrictInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/districts", "json", req, runtime));
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
            return TeaModel.ToObject<QueryHospitalDistrictInfoResponse>(await DoROARequestAsync("QueryHospitalDistrictInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/districts", "json", req, runtime));
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
            return TeaModel.ToObject<QueryHospitalRoleUserInfoResponse>(DoROARequest("QueryHospitalRoleUserInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/roles/userInfos", "json", req, runtime));
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
            return TeaModel.ToObject<QueryHospitalRoleUserInfoResponse>(await DoROARequestAsync("QueryHospitalRoleUserInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/roles/userInfos", "json", req, runtime));
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
            return TeaModel.ToObject<QueryHospitalRolesResponse>(DoROARequest("QueryHospitalRoles", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/roles", "json", req, runtime));
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
            return TeaModel.ToObject<QueryHospitalRolesResponse>(await DoROARequestAsync("QueryHospitalRoles", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/roles", "json", req, runtime));
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
            return TeaModel.ToObject<QueryJobCodeDictionaryResponse>(DoROARequest("QueryJobCodeDictionary", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/jobCodes", "json", req, runtime));
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
            return TeaModel.ToObject<QueryJobCodeDictionaryResponse>(await DoROARequestAsync("QueryJobCodeDictionary", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/jobCodes", "json", req, runtime));
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
            return TeaModel.ToObject<QueryJobStatusCodeDictionaryResponse>(DoROARequest("QueryJobStatusCodeDictionary", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/jobStatusCodes", "json", req, runtime));
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
            return TeaModel.ToObject<QueryJobStatusCodeDictionaryResponse>(await DoROARequestAsync("QueryJobStatusCodeDictionary", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/jobStatusCodes", "json", req, runtime));
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
            return TeaModel.ToObject<QueryMedicalEventsResponse>(DoROARequest("QueryMedicalEvents", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/events", "json", req, runtime));
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
            return TeaModel.ToObject<QueryMedicalEventsResponse>(await DoROARequestAsync("QueryMedicalEvents", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/events", "json", req, runtime));
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
            return TeaModel.ToObject<QueryUserCredentialsResponse>(DoROARequest("QueryUserCredentials", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/medicals/users/credentials/query", "json", req, runtime));
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
            return TeaModel.ToObject<QueryUserCredentialsResponse>(await DoROARequestAsync("QueryUserCredentials", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/medicals/users/credentials/query", "json", req, runtime));
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

        public QueryUserExtInfoResponse QueryUserExtInfoWithOptions(string userId, QueryUserExtInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<QueryUserExtInfoResponse>(DoROARequest("QueryUserExtInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/users/" + userId + "/extInfos", "json", req, runtime));
        }

        public async Task<QueryUserExtInfoResponse> QueryUserExtInfoWithOptionsAsync(string userId, QueryUserExtInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<QueryUserExtInfoResponse>(await DoROARequestAsync("QueryUserExtInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/users/" + userId + "/extInfos", "json", req, runtime));
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
            return TeaModel.ToObject<QueryUserExtendValuesResponse>(DoROARequest("QueryUserExtendValues", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/medicals/users/extends/query", "json", req, runtime));
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
            return TeaModel.ToObject<QueryUserExtendValuesResponse>(await DoROARequestAsync("QueryUserExtendValues", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/medicals/users/extends/query", "json", req, runtime));
        }

        public QueryUserInfoResponse QueryUserInfo(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserInfoHeaders headers = new QueryUserInfoHeaders();
            return QueryUserInfoWithOptions(userId, headers, runtime);
        }

        public async Task<QueryUserInfoResponse> QueryUserInfoAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserInfoHeaders headers = new QueryUserInfoHeaders();
            return await QueryUserInfoWithOptionsAsync(userId, headers, runtime);
        }

        public QueryUserInfoResponse QueryUserInfoWithOptions(string userId, QueryUserInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<QueryUserInfoResponse>(DoROARequest("QueryUserInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/users/" + userId, "json", req, runtime));
        }

        public async Task<QueryUserInfoResponse> QueryUserInfoWithOptionsAsync(string userId, QueryUserInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<QueryUserInfoResponse>(await DoROARequestAsync("QueryUserInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/users/" + userId, "json", req, runtime));
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
            return TeaModel.ToObject<QueryUserProbCodeDictionaryResponse>(DoROARequest("QueryUserProbCodeDictionary", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/userProbCodes", "json", req, runtime));
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
            return TeaModel.ToObject<QueryUserProbCodeDictionaryResponse>(await DoROARequestAsync("QueryUserProbCodeDictionary", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/userProbCodes", "json", req, runtime));
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

        public QueryUserRolesResponse QueryUserRolesWithOptions(string userId, QueryUserRolesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<QueryUserRolesResponse>(DoROARequest("QueryUserRoles", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/users/" + userId + "/roles", "json", req, runtime));
        }

        public async Task<QueryUserRolesResponse> QueryUserRolesWithOptionsAsync(string userId, QueryUserRolesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            return TeaModel.ToObject<QueryUserRolesResponse>(await DoROARequestAsync("QueryUserRoles", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/users/" + userId + "/roles", "json", req, runtime));
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

        public SaveUserExtendValuesResponse SaveUserExtendValuesWithOptions(string userId, SaveUserExtendValuesRequest request, SaveUserExtendValuesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
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
            return TeaModel.ToObject<SaveUserExtendValuesResponse>(DoROARequest("SaveUserExtendValues", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/medicals/users/" + userId + "/extends", "json", req, runtime));
        }

        public async Task<SaveUserExtendValuesResponse> SaveUserExtendValuesWithOptionsAsync(string userId, SaveUserExtendValuesRequest request, SaveUserExtendValuesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
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
            return TeaModel.ToObject<SaveUserExtendValuesResponse>(await DoROARequestAsync("SaveUserExtendValues", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/medicals/users/" + userId + "/extends", "json", req, runtime));
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

        public UpdateUserExtendInfoResponse UpdateUserExtendInfoWithOptions(string userId, UpdateUserExtendInfoRequest request, UpdateUserExtendInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
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
            return TeaModel.ToObject<UpdateUserExtendInfoResponse>(DoROARequest("UpdateUserExtendInfo", "industry_1.0", "HTTP", "PUT", "AK", "/v1.0/industry/medicals/users/" + userId + "/extInfos", "none", req, runtime));
        }

        public async Task<UpdateUserExtendInfoResponse> UpdateUserExtendInfoWithOptionsAsync(string userId, UpdateUserExtendInfoRequest request, UpdateUserExtendInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
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
            return TeaModel.ToObject<UpdateUserExtendInfoResponse>(await DoROARequestAsync("UpdateUserExtendInfo", "industry_1.0", "HTTP", "PUT", "AK", "/v1.0/industry/medicals/users/" + userId + "/extInfos", "none", req, runtime));
        }

    }
}
