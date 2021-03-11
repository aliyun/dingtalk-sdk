// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkattendance_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0
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


        public CreateApproveResponse CreateApprove(CreateApproveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateApproveHeaders headers = new CreateApproveHeaders();
            return CreateApproveWithOptions(request, headers, runtime);
        }

        public async Task<CreateApproveResponse> CreateApproveAsync(CreateApproveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateApproveHeaders headers = new CreateApproveHeaders();
            return await CreateApproveWithOptionsAsync(request, headers, runtime);
        }

        public CreateApproveResponse CreateApproveWithOptions(CreateApproveRequest request, CreateApproveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Userid))
            {
                body["userid"] = request.Userid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                body["tagName"] = request.TagName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubType))
            {
                body["subType"] = request.SubType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PunchParam.ToMap()))
            {
                body["punchParam"] = request.PunchParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApproveId))
            {
                body["approveId"] = request.ApproveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserid))
            {
                body["opUserid"] = request.OpUserid;
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
            return TeaModel.ToObject<CreateApproveResponse>(DoROARequest("CreateApprove", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/approves", "json", req, runtime));
        }

        public async Task<CreateApproveResponse> CreateApproveWithOptionsAsync(CreateApproveRequest request, CreateApproveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Userid))
            {
                body["userid"] = request.Userid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagName))
            {
                body["tagName"] = request.TagName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubType))
            {
                body["subType"] = request.SubType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PunchParam.ToMap()))
            {
                body["punchParam"] = request.PunchParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApproveId))
            {
                body["approveId"] = request.ApproveId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUserid))
            {
                body["opUserid"] = request.OpUserid;
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
            return TeaModel.ToObject<CreateApproveResponse>(await DoROARequestAsync("CreateApprove", "attendance_1.0", "HTTP", "POST", "AK", "/v1.0/attendance/approves", "json", req, runtime));
        }

        public GetUserHolidaysResponse GetUserHolidays(GetUserHolidaysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserHolidaysHeaders headers = new GetUserHolidaysHeaders();
            return GetUserHolidaysWithOptions(request, headers, runtime);
        }

        public async Task<GetUserHolidaysResponse> GetUserHolidaysAsync(GetUserHolidaysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserHolidaysHeaders headers = new GetUserHolidaysHeaders();
            return await GetUserHolidaysWithOptionsAsync(request, headers, runtime);
        }

        public GetUserHolidaysResponse GetUserHolidaysWithOptions(GetUserHolidaysRequest tmpReq, GetUserHolidaysHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetUserHolidaysShrinkRequest request = new GetUserHolidaysShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TopHolidayQueryParam.ToMap()))
            {
                request.TopHolidayQueryParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TopHolidayQueryParam.ToMap(), "topHolidayQueryParam", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopHolidayQueryParamShrink))
            {
                query["topHolidayQueryParam"] = request.TopHolidayQueryParamShrink;
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
            return TeaModel.ToObject<GetUserHolidaysResponse>(DoROARequest("GetUserHolidays", "attendance_1.0", "HTTP", "GET", "AK", "/v1.0/attendance/holidays", "json", req, runtime));
        }

        public async Task<GetUserHolidaysResponse> GetUserHolidaysWithOptionsAsync(GetUserHolidaysRequest tmpReq, GetUserHolidaysHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetUserHolidaysShrinkRequest request = new GetUserHolidaysShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TopHolidayQueryParam.ToMap()))
            {
                request.TopHolidayQueryParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TopHolidayQueryParam.ToMap(), "topHolidayQueryParam", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopHolidayQueryParamShrink))
            {
                query["topHolidayQueryParam"] = request.TopHolidayQueryParamShrink;
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
            return TeaModel.ToObject<GetUserHolidaysResponse>(await DoROARequestAsync("GetUserHolidays", "attendance_1.0", "HTTP", "GET", "AK", "/v1.0/attendance/holidays", "json", req, runtime));
        }

    }
}
