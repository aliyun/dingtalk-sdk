// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkalitrip_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkalitrip_1_0
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


        public AddCityCarApplyResponse AddCityCarApply(AddCityCarApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddCityCarApplyHeaders headers = new AddCityCarApplyHeaders();
            return AddCityCarApplyWithOptions(request, headers, runtime);
        }

        public async Task<AddCityCarApplyResponse> AddCityCarApplyAsync(AddCityCarApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddCityCarApplyHeaders headers = new AddCityCarApplyHeaders();
            return await AddCityCarApplyWithOptionsAsync(request, headers, runtime);
        }

        public AddCityCarApplyResponse AddCityCarApplyWithOptions(AddCityCarApplyRequest request, AddCityCarApplyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cause))
            {
                body["cause"] = request.Cause;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                body["city"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Date))
            {
                body["date"] = request.Date;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTokenGrantType))
            {
                body["dingTokenGrantType"] = request.DingTokenGrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinishedDate))
            {
                body["finishedDate"] = request.FinishedDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectCode))
            {
                body["projectCode"] = request.ProjectCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["projectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartApplyId))
            {
                body["thirdPartApplyId"] = request.ThirdPartApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartCostCenterId))
            {
                body["thirdPartCostCenterId"] = request.ThirdPartCostCenterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartInvoiceId))
            {
                body["thirdPartInvoiceId"] = request.ThirdPartInvoiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimesTotal))
            {
                body["timesTotal"] = request.TimesTotal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimesType))
            {
                body["timesType"] = request.TimesType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimesUsed))
            {
                body["timesUsed"] = request.TimesUsed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AddCityCarApplyResponse>(DoROARequest("AddCityCarApply", "alitrip_1.0", "HTTP", "POST", "AK", "/v1.0/alitrip/cityCarApprovals", "json", req, runtime));
        }

        public async Task<AddCityCarApplyResponse> AddCityCarApplyWithOptionsAsync(AddCityCarApplyRequest request, AddCityCarApplyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cause))
            {
                body["cause"] = request.Cause;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                body["city"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Date))
            {
                body["date"] = request.Date;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTokenGrantType))
            {
                body["dingTokenGrantType"] = request.DingTokenGrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinishedDate))
            {
                body["finishedDate"] = request.FinishedDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectCode))
            {
                body["projectCode"] = request.ProjectCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["projectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartApplyId))
            {
                body["thirdPartApplyId"] = request.ThirdPartApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartCostCenterId))
            {
                body["thirdPartCostCenterId"] = request.ThirdPartCostCenterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartInvoiceId))
            {
                body["thirdPartInvoiceId"] = request.ThirdPartInvoiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimesTotal))
            {
                body["timesTotal"] = request.TimesTotal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimesType))
            {
                body["timesType"] = request.TimesType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimesUsed))
            {
                body["timesUsed"] = request.TimesUsed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<AddCityCarApplyResponse>(await DoROARequestAsync("AddCityCarApply", "alitrip_1.0", "HTTP", "POST", "AK", "/v1.0/alitrip/cityCarApprovals", "json", req, runtime));
        }

        public ApproveCityCarApplyResponse ApproveCityCarApply(ApproveCityCarApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ApproveCityCarApplyHeaders headers = new ApproveCityCarApplyHeaders();
            return ApproveCityCarApplyWithOptions(request, headers, runtime);
        }

        public async Task<ApproveCityCarApplyResponse> ApproveCityCarApplyAsync(ApproveCityCarApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ApproveCityCarApplyHeaders headers = new ApproveCityCarApplyHeaders();
            return await ApproveCityCarApplyWithOptionsAsync(request, headers, runtime);
        }

        public ApproveCityCarApplyResponse ApproveCityCarApplyWithOptions(ApproveCityCarApplyRequest request, ApproveCityCarApplyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTokenGrantType))
            {
                body["dingTokenGrantType"] = request.DingTokenGrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateTime))
            {
                body["operateTime"] = request.OperateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartApplyId))
            {
                body["thirdPartApplyId"] = request.ThirdPartApplyId;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ApproveCityCarApplyResponse>(DoROARequest("ApproveCityCarApply", "alitrip_1.0", "HTTP", "PUT", "AK", "/v1.0/alitrip/cityCarApprovals", "json", req, runtime));
        }

        public async Task<ApproveCityCarApplyResponse> ApproveCityCarApplyWithOptionsAsync(ApproveCityCarApplyRequest request, ApproveCityCarApplyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTokenGrantType))
            {
                body["dingTokenGrantType"] = request.DingTokenGrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateTime))
            {
                body["operateTime"] = request.OperateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartApplyId))
            {
                body["thirdPartApplyId"] = request.ThirdPartApplyId;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ApproveCityCarApplyResponse>(await DoROARequestAsync("ApproveCityCarApply", "alitrip_1.0", "HTTP", "PUT", "AK", "/v1.0/alitrip/cityCarApprovals", "json", req, runtime));
        }

        public GetFlightExceedApplyResponse GetFlightExceedApply(GetFlightExceedApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFlightExceedApplyHeaders headers = new GetFlightExceedApplyHeaders();
            return GetFlightExceedApplyWithOptions(request, headers, runtime);
        }

        public async Task<GetFlightExceedApplyResponse> GetFlightExceedApplyAsync(GetFlightExceedApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFlightExceedApplyHeaders headers = new GetFlightExceedApplyHeaders();
            return await GetFlightExceedApplyWithOptionsAsync(request, headers, runtime);
        }

        public GetFlightExceedApplyResponse GetFlightExceedApplyWithOptions(GetFlightExceedApplyRequest request, GetFlightExceedApplyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["applyId"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
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
            return TeaModel.ToObject<GetFlightExceedApplyResponse>(DoROARequest("GetFlightExceedApply", "alitrip_1.0", "HTTP", "GET", "AK", "/v1.0/alitrip/exceedapply/getFlight", "json", req, runtime));
        }

        public async Task<GetFlightExceedApplyResponse> GetFlightExceedApplyWithOptionsAsync(GetFlightExceedApplyRequest request, GetFlightExceedApplyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["applyId"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
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
            return TeaModel.ToObject<GetFlightExceedApplyResponse>(await DoROARequestAsync("GetFlightExceedApply", "alitrip_1.0", "HTTP", "GET", "AK", "/v1.0/alitrip/exceedapply/getFlight", "json", req, runtime));
        }

        public GetHotelExceedApplyResponse GetHotelExceedApply(GetHotelExceedApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelExceedApplyHeaders headers = new GetHotelExceedApplyHeaders();
            return GetHotelExceedApplyWithOptions(request, headers, runtime);
        }

        public async Task<GetHotelExceedApplyResponse> GetHotelExceedApplyAsync(GetHotelExceedApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetHotelExceedApplyHeaders headers = new GetHotelExceedApplyHeaders();
            return await GetHotelExceedApplyWithOptionsAsync(request, headers, runtime);
        }

        public GetHotelExceedApplyResponse GetHotelExceedApplyWithOptions(GetHotelExceedApplyRequest request, GetHotelExceedApplyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["applyId"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
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
            return TeaModel.ToObject<GetHotelExceedApplyResponse>(DoROARequest("GetHotelExceedApply", "alitrip_1.0", "HTTP", "GET", "AK", "/v1.0/alitrip/exceedapply/getHotel", "json", req, runtime));
        }

        public async Task<GetHotelExceedApplyResponse> GetHotelExceedApplyWithOptionsAsync(GetHotelExceedApplyRequest request, GetHotelExceedApplyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["applyId"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
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
            return TeaModel.ToObject<GetHotelExceedApplyResponse>(await DoROARequestAsync("GetHotelExceedApply", "alitrip_1.0", "HTTP", "GET", "AK", "/v1.0/alitrip/exceedapply/getHotel", "json", req, runtime));
        }

        public GetTrainExceedApplyResponse GetTrainExceedApply(GetTrainExceedApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTrainExceedApplyHeaders headers = new GetTrainExceedApplyHeaders();
            return GetTrainExceedApplyWithOptions(request, headers, runtime);
        }

        public async Task<GetTrainExceedApplyResponse> GetTrainExceedApplyAsync(GetTrainExceedApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTrainExceedApplyHeaders headers = new GetTrainExceedApplyHeaders();
            return await GetTrainExceedApplyWithOptionsAsync(request, headers, runtime);
        }

        public GetTrainExceedApplyResponse GetTrainExceedApplyWithOptions(GetTrainExceedApplyRequest request, GetTrainExceedApplyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["applyId"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
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
            return TeaModel.ToObject<GetTrainExceedApplyResponse>(DoROARequest("GetTrainExceedApply", "alitrip_1.0", "HTTP", "GET", "AK", "/v1.0/alitrip/exceedapply/getTrain", "json", req, runtime));
        }

        public async Task<GetTrainExceedApplyResponse> GetTrainExceedApplyWithOptionsAsync(GetTrainExceedApplyRequest request, GetTrainExceedApplyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["applyId"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
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
            return TeaModel.ToObject<GetTrainExceedApplyResponse>(await DoROARequestAsync("GetTrainExceedApply", "alitrip_1.0", "HTTP", "GET", "AK", "/v1.0/alitrip/exceedapply/getTrain", "json", req, runtime));
        }

        public QueryCityCarApplyResponse QueryCityCarApply(QueryCityCarApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCityCarApplyHeaders headers = new QueryCityCarApplyHeaders();
            return QueryCityCarApplyWithOptions(request, headers, runtime);
        }

        public async Task<QueryCityCarApplyResponse> QueryCityCarApplyAsync(QueryCityCarApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCityCarApplyHeaders headers = new QueryCityCarApplyHeaders();
            return await QueryCityCarApplyWithOptionsAsync(request, headers, runtime);
        }

        public QueryCityCarApplyResponse QueryCityCarApplyWithOptions(QueryCityCarApplyRequest request, QueryCityCarApplyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedEndAt))
            {
                query["createdEndAt"] = request.CreatedEndAt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedStartAt))
            {
                query["createdStartAt"] = request.CreatedStartAt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartApplyId))
            {
                query["thirdPartApplyId"] = request.ThirdPartApplyId;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryCityCarApplyResponse>(DoROARequest("QueryCityCarApply", "alitrip_1.0", "HTTP", "GET", "AK", "/v1.0/alitrip/cityCarApprovals", "json", req, runtime));
        }

        public async Task<QueryCityCarApplyResponse> QueryCityCarApplyWithOptionsAsync(QueryCityCarApplyRequest request, QueryCityCarApplyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedEndAt))
            {
                query["createdEndAt"] = request.CreatedEndAt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedStartAt))
            {
                query["createdStartAt"] = request.CreatedStartAt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartApplyId))
            {
                query["thirdPartApplyId"] = request.ThirdPartApplyId;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryCityCarApplyResponse>(await DoROARequestAsync("QueryCityCarApply", "alitrip_1.0", "HTTP", "GET", "AK", "/v1.0/alitrip/cityCarApprovals", "json", req, runtime));
        }

        public QueryUnionOrderResponse QueryUnionOrder(QueryUnionOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUnionOrderHeaders headers = new QueryUnionOrderHeaders();
            return QueryUnionOrderWithOptions(request, headers, runtime);
        }

        public async Task<QueryUnionOrderResponse> QueryUnionOrderAsync(QueryUnionOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUnionOrderHeaders headers = new QueryUnionOrderHeaders();
            return await QueryUnionOrderWithOptionsAsync(request, headers, runtime);
        }

        public QueryUnionOrderResponse QueryUnionOrderWithOptions(QueryUnionOrderRequest request, QueryUnionOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartApplyId))
            {
                query["thirdPartApplyId"] = request.ThirdPartApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionNo))
            {
                query["unionNo"] = request.UnionNo;
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
            return TeaModel.ToObject<QueryUnionOrderResponse>(DoROARequest("QueryUnionOrder", "alitrip_1.0", "HTTP", "GET", "AK", "/v1.0/alitrip/unionOrders", "json", req, runtime));
        }

        public async Task<QueryUnionOrderResponse> QueryUnionOrderWithOptionsAsync(QueryUnionOrderRequest request, QueryUnionOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartApplyId))
            {
                query["thirdPartApplyId"] = request.ThirdPartApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionNo))
            {
                query["unionNo"] = request.UnionNo;
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
            return TeaModel.ToObject<QueryUnionOrderResponse>(await DoROARequestAsync("QueryUnionOrder", "alitrip_1.0", "HTTP", "GET", "AK", "/v1.0/alitrip/unionOrders", "json", req, runtime));
        }

        public SyncExceedApplyResponse SyncExceedApply(SyncExceedApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncExceedApplyHeaders headers = new SyncExceedApplyHeaders();
            return SyncExceedApplyWithOptions(request, headers, runtime);
        }

        public async Task<SyncExceedApplyResponse> SyncExceedApplyAsync(SyncExceedApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncExceedApplyHeaders headers = new SyncExceedApplyHeaders();
            return await SyncExceedApplyWithOptionsAsync(request, headers, runtime);
        }

        public SyncExceedApplyResponse SyncExceedApplyWithOptions(SyncExceedApplyRequest request, SyncExceedApplyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["applyId"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartyFlowId))
            {
                query["thirdpartyFlowId"] = request.ThirdpartyFlowId;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<SyncExceedApplyResponse>(DoROARequest("SyncExceedApply", "alitrip_1.0", "HTTP", "POST", "AK", "/v1.0/alitrip/exceedapply/sync", "json", req, runtime));
        }

        public async Task<SyncExceedApplyResponse> SyncExceedApplyWithOptionsAsync(SyncExceedApplyRequest request, SyncExceedApplyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyId))
            {
                query["applyId"] = request.ApplyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdpartyFlowId))
            {
                query["thirdpartyFlowId"] = request.ThirdpartyFlowId;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<SyncExceedApplyResponse>(await DoROARequestAsync("SyncExceedApply", "alitrip_1.0", "HTTP", "POST", "AK", "/v1.0/alitrip/exceedapply/sync", "json", req, runtime));
        }

    }
}
