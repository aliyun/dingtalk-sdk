// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0
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


        public PostCorpAuthInfoResponse PostCorpAuthInfo()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PostCorpAuthInfoHeaders headers = new PostCorpAuthInfoHeaders();
            return PostCorpAuthInfoWithOptions(headers, runtime);
        }

        public async Task<PostCorpAuthInfoResponse> PostCorpAuthInfoAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PostCorpAuthInfoHeaders headers = new PostCorpAuthInfoHeaders();
            return await PostCorpAuthInfoWithOptionsAsync(headers, runtime);
        }

        public PostCorpAuthInfoResponse PostCorpAuthInfoWithOptions(PostCorpAuthInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<PostCorpAuthInfoResponse>(DoROARequest("PostCorpAuthInfo", "datacenter_1.0", "HTTP", "POST", "AK", "/v1.0/datacenter/corporations/authorize", "json", req, runtime));
        }

        public async Task<PostCorpAuthInfoResponse> PostCorpAuthInfoWithOptionsAsync(PostCorpAuthInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<PostCorpAuthInfoResponse>(await DoROARequestAsync("PostCorpAuthInfo", "datacenter_1.0", "HTTP", "POST", "AK", "/v1.0/datacenter/corporations/authorize", "json", req, runtime));
        }

        public QueryActiveUserStatisticalDataResponse QueryActiveUserStatisticalData(QueryActiveUserStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryActiveUserStatisticalDataHeaders headers = new QueryActiveUserStatisticalDataHeaders();
            return QueryActiveUserStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryActiveUserStatisticalDataResponse> QueryActiveUserStatisticalDataAsync(QueryActiveUserStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryActiveUserStatisticalDataHeaders headers = new QueryActiveUserStatisticalDataHeaders();
            return await QueryActiveUserStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryActiveUserStatisticalDataResponse QueryActiveUserStatisticalDataWithOptions(QueryActiveUserStatisticalDataRequest request, QueryActiveUserStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryActiveUserStatisticalDataResponse>(DoROARequest("QueryActiveUserStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/activeUserData", "json", req, runtime));
        }

        public async Task<QueryActiveUserStatisticalDataResponse> QueryActiveUserStatisticalDataWithOptionsAsync(QueryActiveUserStatisticalDataRequest request, QueryActiveUserStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryActiveUserStatisticalDataResponse>(await DoROARequestAsync("QueryActiveUserStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/activeUserData", "json", req, runtime));
        }

        public QueryAnhmdStatisticalDataResponse QueryAnhmdStatisticalData(QueryAnhmdStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAnhmdStatisticalDataHeaders headers = new QueryAnhmdStatisticalDataHeaders();
            return QueryAnhmdStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryAnhmdStatisticalDataResponse> QueryAnhmdStatisticalDataAsync(QueryAnhmdStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAnhmdStatisticalDataHeaders headers = new QueryAnhmdStatisticalDataHeaders();
            return await QueryAnhmdStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryAnhmdStatisticalDataResponse QueryAnhmdStatisticalDataWithOptions(QueryAnhmdStatisticalDataRequest request, QueryAnhmdStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryAnhmdStatisticalDataResponse>(DoROARequest("QueryAnhmdStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/statisticDatas/anHmd", "json", req, runtime));
        }

        public async Task<QueryAnhmdStatisticalDataResponse> QueryAnhmdStatisticalDataWithOptionsAsync(QueryAnhmdStatisticalDataRequest request, QueryAnhmdStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryAnhmdStatisticalDataResponse>(await DoROARequestAsync("QueryAnhmdStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/statisticDatas/anHmd", "json", req, runtime));
        }

        public QueryApprovalStatisticalDataResponse QueryApprovalStatisticalData(QueryApprovalStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryApprovalStatisticalDataHeaders headers = new QueryApprovalStatisticalDataHeaders();
            return QueryApprovalStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryApprovalStatisticalDataResponse> QueryApprovalStatisticalDataAsync(QueryApprovalStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryApprovalStatisticalDataHeaders headers = new QueryApprovalStatisticalDataHeaders();
            return await QueryApprovalStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryApprovalStatisticalDataResponse QueryApprovalStatisticalDataWithOptions(QueryApprovalStatisticalDataRequest request, QueryApprovalStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryApprovalStatisticalDataResponse>(DoROARequest("QueryApprovalStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/approvalData", "json", req, runtime));
        }

        public async Task<QueryApprovalStatisticalDataResponse> QueryApprovalStatisticalDataWithOptionsAsync(QueryApprovalStatisticalDataRequest request, QueryApprovalStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryApprovalStatisticalDataResponse>(await DoROARequestAsync("QueryApprovalStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/approvalData", "json", req, runtime));
        }

        public QueryAttendanceStatisticalDataResponse QueryAttendanceStatisticalData(QueryAttendanceStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAttendanceStatisticalDataHeaders headers = new QueryAttendanceStatisticalDataHeaders();
            return QueryAttendanceStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryAttendanceStatisticalDataResponse> QueryAttendanceStatisticalDataAsync(QueryAttendanceStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAttendanceStatisticalDataHeaders headers = new QueryAttendanceStatisticalDataHeaders();
            return await QueryAttendanceStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryAttendanceStatisticalDataResponse QueryAttendanceStatisticalDataWithOptions(QueryAttendanceStatisticalDataRequest request, QueryAttendanceStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryAttendanceStatisticalDataResponse>(DoROARequest("QueryAttendanceStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/attendanceData", "json", req, runtime));
        }

        public async Task<QueryAttendanceStatisticalDataResponse> QueryAttendanceStatisticalDataWithOptionsAsync(QueryAttendanceStatisticalDataRequest request, QueryAttendanceStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryAttendanceStatisticalDataResponse>(await DoROARequestAsync("QueryAttendanceStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/attendanceData", "json", req, runtime));
        }

        public QueryBlackboardStatisticalDataResponse QueryBlackboardStatisticalData(QueryBlackboardStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBlackboardStatisticalDataHeaders headers = new QueryBlackboardStatisticalDataHeaders();
            return QueryBlackboardStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryBlackboardStatisticalDataResponse> QueryBlackboardStatisticalDataAsync(QueryBlackboardStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBlackboardStatisticalDataHeaders headers = new QueryBlackboardStatisticalDataHeaders();
            return await QueryBlackboardStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryBlackboardStatisticalDataResponse QueryBlackboardStatisticalDataWithOptions(QueryBlackboardStatisticalDataRequest request, QueryBlackboardStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryBlackboardStatisticalDataResponse>(DoROARequest("QueryBlackboardStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/blackboardData", "json", req, runtime));
        }

        public async Task<QueryBlackboardStatisticalDataResponse> QueryBlackboardStatisticalDataWithOptionsAsync(QueryBlackboardStatisticalDataRequest request, QueryBlackboardStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryBlackboardStatisticalDataResponse>(await DoROARequestAsync("QueryBlackboardStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/blackboardData", "json", req, runtime));
        }

        public QueryCalendarStatisticalDataResponse QueryCalendarStatisticalData(QueryCalendarStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCalendarStatisticalDataHeaders headers = new QueryCalendarStatisticalDataHeaders();
            return QueryCalendarStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryCalendarStatisticalDataResponse> QueryCalendarStatisticalDataAsync(QueryCalendarStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCalendarStatisticalDataHeaders headers = new QueryCalendarStatisticalDataHeaders();
            return await QueryCalendarStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryCalendarStatisticalDataResponse QueryCalendarStatisticalDataWithOptions(QueryCalendarStatisticalDataRequest request, QueryCalendarStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryCalendarStatisticalDataResponse>(DoROARequest("QueryCalendarStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/calendarData", "json", req, runtime));
        }

        public async Task<QueryCalendarStatisticalDataResponse> QueryCalendarStatisticalDataWithOptionsAsync(QueryCalendarStatisticalDataRequest request, QueryCalendarStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryCalendarStatisticalDataResponse>(await DoROARequestAsync("QueryCalendarStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/calendarData", "json", req, runtime));
        }

        public QueryCheckinStatisticalDataResponse QueryCheckinStatisticalData(QueryCheckinStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCheckinStatisticalDataHeaders headers = new QueryCheckinStatisticalDataHeaders();
            return QueryCheckinStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryCheckinStatisticalDataResponse> QueryCheckinStatisticalDataAsync(QueryCheckinStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCheckinStatisticalDataHeaders headers = new QueryCheckinStatisticalDataHeaders();
            return await QueryCheckinStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryCheckinStatisticalDataResponse QueryCheckinStatisticalDataWithOptions(QueryCheckinStatisticalDataRequest request, QueryCheckinStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryCheckinStatisticalDataResponse>(DoROARequest("QueryCheckinStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/checkinData", "json", req, runtime));
        }

        public async Task<QueryCheckinStatisticalDataResponse> QueryCheckinStatisticalDataWithOptionsAsync(QueryCheckinStatisticalDataRequest request, QueryCheckinStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryCheckinStatisticalDataResponse>(await DoROARequestAsync("QueryCheckinStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/checkinData", "json", req, runtime));
        }

        public QueryCircleStatisticalDataResponse QueryCircleStatisticalData(QueryCircleStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCircleStatisticalDataHeaders headers = new QueryCircleStatisticalDataHeaders();
            return QueryCircleStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryCircleStatisticalDataResponse> QueryCircleStatisticalDataAsync(QueryCircleStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCircleStatisticalDataHeaders headers = new QueryCircleStatisticalDataHeaders();
            return await QueryCircleStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryCircleStatisticalDataResponse QueryCircleStatisticalDataWithOptions(QueryCircleStatisticalDataRequest request, QueryCircleStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryCircleStatisticalDataResponse>(DoROARequest("QueryCircleStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/circleData", "json", req, runtime));
        }

        public async Task<QueryCircleStatisticalDataResponse> QueryCircleStatisticalDataWithOptionsAsync(QueryCircleStatisticalDataRequest request, QueryCircleStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryCircleStatisticalDataResponse>(await DoROARequestAsync("QueryCircleStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/circleData", "json", req, runtime));
        }

        public QueryCompanyBasicInfoResponse QueryCompanyBasicInfo(QueryCompanyBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCompanyBasicInfoHeaders headers = new QueryCompanyBasicInfoHeaders();
            return QueryCompanyBasicInfoWithOptions(request, headers, runtime);
        }

        public async Task<QueryCompanyBasicInfoResponse> QueryCompanyBasicInfoAsync(QueryCompanyBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCompanyBasicInfoHeaders headers = new QueryCompanyBasicInfoHeaders();
            return await QueryCompanyBasicInfoWithOptionsAsync(request, headers, runtime);
        }

        public QueryCompanyBasicInfoResponse QueryCompanyBasicInfoWithOptions(QueryCompanyBasicInfoRequest request, QueryCompanyBasicInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
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
            return TeaModel.ToObject<QueryCompanyBasicInfoResponse>(DoROARequest("QueryCompanyBasicInfo", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/companies/basicInfo", "json", req, runtime));
        }

        public async Task<QueryCompanyBasicInfoResponse> QueryCompanyBasicInfoWithOptionsAsync(QueryCompanyBasicInfoRequest request, QueryCompanyBasicInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
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
            return TeaModel.ToObject<QueryCompanyBasicInfoResponse>(await DoROARequestAsync("QueryCompanyBasicInfo", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/companies/basicInfo", "json", req, runtime));
        }

        public QueryDigitalDistrictOrgInfoResponse QueryDigitalDistrictOrgInfo(QueryDigitalDistrictOrgInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDigitalDistrictOrgInfoHeaders headers = new QueryDigitalDistrictOrgInfoHeaders();
            return QueryDigitalDistrictOrgInfoWithOptions(request, headers, runtime);
        }

        public async Task<QueryDigitalDistrictOrgInfoResponse> QueryDigitalDistrictOrgInfoAsync(QueryDigitalDistrictOrgInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDigitalDistrictOrgInfoHeaders headers = new QueryDigitalDistrictOrgInfoHeaders();
            return await QueryDigitalDistrictOrgInfoWithOptionsAsync(request, headers, runtime);
        }

        public QueryDigitalDistrictOrgInfoResponse QueryDigitalDistrictOrgInfoWithOptions(QueryDigitalDistrictOrgInfoRequest request, QueryDigitalDistrictOrgInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpIds))
            {
                body["corpIds"] = request.CorpIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDates))
            {
                body["statDates"] = request.StatDates;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<QueryDigitalDistrictOrgInfoResponse>(DoROARequest("QueryDigitalDistrictOrgInfo", "datacenter_1.0", "HTTP", "POST", "AK", "/v1.0/datacenter/digitalCounty/orgInfos/query", "json", req, runtime));
        }

        public async Task<QueryDigitalDistrictOrgInfoResponse> QueryDigitalDistrictOrgInfoWithOptionsAsync(QueryDigitalDistrictOrgInfoRequest request, QueryDigitalDistrictOrgInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpIds))
            {
                body["corpIds"] = request.CorpIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDates))
            {
                body["statDates"] = request.StatDates;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<QueryDigitalDistrictOrgInfoResponse>(await DoROARequestAsync("QueryDigitalDistrictOrgInfo", "datacenter_1.0", "HTTP", "POST", "AK", "/v1.0/datacenter/digitalCounty/orgInfos/query", "json", req, runtime));
        }

        public QueryDingReciveStatisticalDataResponse QueryDingReciveStatisticalData(QueryDingReciveStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDingReciveStatisticalDataHeaders headers = new QueryDingReciveStatisticalDataHeaders();
            return QueryDingReciveStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryDingReciveStatisticalDataResponse> QueryDingReciveStatisticalDataAsync(QueryDingReciveStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDingReciveStatisticalDataHeaders headers = new QueryDingReciveStatisticalDataHeaders();
            return await QueryDingReciveStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryDingReciveStatisticalDataResponse QueryDingReciveStatisticalDataWithOptions(QueryDingReciveStatisticalDataRequest request, QueryDingReciveStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryDingReciveStatisticalDataResponse>(DoROARequest("QueryDingReciveStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/dingReciveData", "json", req, runtime));
        }

        public async Task<QueryDingReciveStatisticalDataResponse> QueryDingReciveStatisticalDataWithOptionsAsync(QueryDingReciveStatisticalDataRequest request, QueryDingReciveStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryDingReciveStatisticalDataResponse>(await DoROARequestAsync("QueryDingReciveStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/dingReciveData", "json", req, runtime));
        }

        public QueryDingSendStatisticalDataResponse QueryDingSendStatisticalData(QueryDingSendStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDingSendStatisticalDataHeaders headers = new QueryDingSendStatisticalDataHeaders();
            return QueryDingSendStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryDingSendStatisticalDataResponse> QueryDingSendStatisticalDataAsync(QueryDingSendStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDingSendStatisticalDataHeaders headers = new QueryDingSendStatisticalDataHeaders();
            return await QueryDingSendStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryDingSendStatisticalDataResponse QueryDingSendStatisticalDataWithOptions(QueryDingSendStatisticalDataRequest request, QueryDingSendStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryDingSendStatisticalDataResponse>(DoROARequest("QueryDingSendStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/dingSendData", "json", req, runtime));
        }

        public async Task<QueryDingSendStatisticalDataResponse> QueryDingSendStatisticalDataWithOptionsAsync(QueryDingSendStatisticalDataRequest request, QueryDingSendStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryDingSendStatisticalDataResponse>(await DoROARequestAsync("QueryDingSendStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/dingSendData", "json", req, runtime));
        }

        public QueryDocumentStatisticalDataResponse QueryDocumentStatisticalData(QueryDocumentStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDocumentStatisticalDataHeaders headers = new QueryDocumentStatisticalDataHeaders();
            return QueryDocumentStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryDocumentStatisticalDataResponse> QueryDocumentStatisticalDataAsync(QueryDocumentStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDocumentStatisticalDataHeaders headers = new QueryDocumentStatisticalDataHeaders();
            return await QueryDocumentStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryDocumentStatisticalDataResponse QueryDocumentStatisticalDataWithOptions(QueryDocumentStatisticalDataRequest request, QueryDocumentStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryDocumentStatisticalDataResponse>(DoROARequest("QueryDocumentStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/documentData", "json", req, runtime));
        }

        public async Task<QueryDocumentStatisticalDataResponse> QueryDocumentStatisticalDataWithOptionsAsync(QueryDocumentStatisticalDataRequest request, QueryDocumentStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryDocumentStatisticalDataResponse>(await DoROARequestAsync("QueryDocumentStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/documentData", "json", req, runtime));
        }

        public QueryDriveStatisticalDataResponse QueryDriveStatisticalData(QueryDriveStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDriveStatisticalDataHeaders headers = new QueryDriveStatisticalDataHeaders();
            return QueryDriveStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryDriveStatisticalDataResponse> QueryDriveStatisticalDataAsync(QueryDriveStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDriveStatisticalDataHeaders headers = new QueryDriveStatisticalDataHeaders();
            return await QueryDriveStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryDriveStatisticalDataResponse QueryDriveStatisticalDataWithOptions(QueryDriveStatisticalDataRequest request, QueryDriveStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryDriveStatisticalDataResponse>(DoROARequest("QueryDriveStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/driveData", "json", req, runtime));
        }

        public async Task<QueryDriveStatisticalDataResponse> QueryDriveStatisticalDataWithOptionsAsync(QueryDriveStatisticalDataRequest request, QueryDriveStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryDriveStatisticalDataResponse>(await DoROARequestAsync("QueryDriveStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/driveData", "json", req, runtime));
        }

        public QueryEmployeeTypeStatisticalDataResponse QueryEmployeeTypeStatisticalData(QueryEmployeeTypeStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryEmployeeTypeStatisticalDataHeaders headers = new QueryEmployeeTypeStatisticalDataHeaders();
            return QueryEmployeeTypeStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryEmployeeTypeStatisticalDataResponse> QueryEmployeeTypeStatisticalDataAsync(QueryEmployeeTypeStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryEmployeeTypeStatisticalDataHeaders headers = new QueryEmployeeTypeStatisticalDataHeaders();
            return await QueryEmployeeTypeStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryEmployeeTypeStatisticalDataResponse QueryEmployeeTypeStatisticalDataWithOptions(QueryEmployeeTypeStatisticalDataRequest request, QueryEmployeeTypeStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryEmployeeTypeStatisticalDataResponse>(DoROARequest("QueryEmployeeTypeStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/employeeTypeData", "json", req, runtime));
        }

        public async Task<QueryEmployeeTypeStatisticalDataResponse> QueryEmployeeTypeStatisticalDataWithOptionsAsync(QueryEmployeeTypeStatisticalDataRequest request, QueryEmployeeTypeStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryEmployeeTypeStatisticalDataResponse>(await DoROARequestAsync("QueryEmployeeTypeStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/employeeTypeData", "json", req, runtime));
        }

        public QueryGroupLiveStatisticalDataResponse QueryGroupLiveStatisticalData(QueryGroupLiveStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGroupLiveStatisticalDataHeaders headers = new QueryGroupLiveStatisticalDataHeaders();
            return QueryGroupLiveStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryGroupLiveStatisticalDataResponse> QueryGroupLiveStatisticalDataAsync(QueryGroupLiveStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGroupLiveStatisticalDataHeaders headers = new QueryGroupLiveStatisticalDataHeaders();
            return await QueryGroupLiveStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryGroupLiveStatisticalDataResponse QueryGroupLiveStatisticalDataWithOptions(QueryGroupLiveStatisticalDataRequest request, QueryGroupLiveStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryGroupLiveStatisticalDataResponse>(DoROARequest("QueryGroupLiveStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/groupLiveData", "json", req, runtime));
        }

        public async Task<QueryGroupLiveStatisticalDataResponse> QueryGroupLiveStatisticalDataWithOptionsAsync(QueryGroupLiveStatisticalDataRequest request, QueryGroupLiveStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryGroupLiveStatisticalDataResponse>(await DoROARequestAsync("QueryGroupLiveStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/groupLiveData", "json", req, runtime));
        }

        public QueryGroupMessageStatisticalDataResponse QueryGroupMessageStatisticalData(QueryGroupMessageStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGroupMessageStatisticalDataHeaders headers = new QueryGroupMessageStatisticalDataHeaders();
            return QueryGroupMessageStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryGroupMessageStatisticalDataResponse> QueryGroupMessageStatisticalDataAsync(QueryGroupMessageStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGroupMessageStatisticalDataHeaders headers = new QueryGroupMessageStatisticalDataHeaders();
            return await QueryGroupMessageStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryGroupMessageStatisticalDataResponse QueryGroupMessageStatisticalDataWithOptions(QueryGroupMessageStatisticalDataRequest request, QueryGroupMessageStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryGroupMessageStatisticalDataResponse>(DoROARequest("QueryGroupMessageStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/groupMessageData", "json", req, runtime));
        }

        public async Task<QueryGroupMessageStatisticalDataResponse> QueryGroupMessageStatisticalDataWithOptionsAsync(QueryGroupMessageStatisticalDataRequest request, QueryGroupMessageStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryGroupMessageStatisticalDataResponse>(await DoROARequestAsync("QueryGroupMessageStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/groupMessageData", "json", req, runtime));
        }

        public QueryHealthStatisticalDataResponse QueryHealthStatisticalData(QueryHealthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryHealthStatisticalDataHeaders headers = new QueryHealthStatisticalDataHeaders();
            return QueryHealthStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryHealthStatisticalDataResponse> QueryHealthStatisticalDataAsync(QueryHealthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryHealthStatisticalDataHeaders headers = new QueryHealthStatisticalDataHeaders();
            return await QueryHealthStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryHealthStatisticalDataResponse QueryHealthStatisticalDataWithOptions(QueryHealthStatisticalDataRequest request, QueryHealthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryHealthStatisticalDataResponse>(DoROARequest("QueryHealthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/healtheUserData", "json", req, runtime));
        }

        public async Task<QueryHealthStatisticalDataResponse> QueryHealthStatisticalDataWithOptionsAsync(QueryHealthStatisticalDataRequest request, QueryHealthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryHealthStatisticalDataResponse>(await DoROARequestAsync("QueryHealthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/healtheUserData", "json", req, runtime));
        }

        public QueryMailStatisticalDataResponse QueryMailStatisticalData(QueryMailStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMailStatisticalDataHeaders headers = new QueryMailStatisticalDataHeaders();
            return QueryMailStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryMailStatisticalDataResponse> QueryMailStatisticalDataAsync(QueryMailStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMailStatisticalDataHeaders headers = new QueryMailStatisticalDataHeaders();
            return await QueryMailStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryMailStatisticalDataResponse QueryMailStatisticalDataWithOptions(QueryMailStatisticalDataRequest request, QueryMailStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryMailStatisticalDataResponse>(DoROARequest("QueryMailStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/mailData", "json", req, runtime));
        }

        public async Task<QueryMailStatisticalDataResponse> QueryMailStatisticalDataWithOptionsAsync(QueryMailStatisticalDataRequest request, QueryMailStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryMailStatisticalDataResponse>(await DoROARequestAsync("QueryMailStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/mailData", "json", req, runtime));
        }

        public QueryOfficialDataResponse QueryOfficialData(QueryOfficialDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOfficialDataHeaders headers = new QueryOfficialDataHeaders();
            return QueryOfficialDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryOfficialDataResponse> QueryOfficialDataAsync(QueryOfficialDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOfficialDataHeaders headers = new QueryOfficialDataHeaders();
            return await QueryOfficialDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryOfficialDataResponse QueryOfficialDataWithOptions(QueryOfficialDataRequest request, QueryOfficialDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                query["param"] = request.Param;
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
            return TeaModel.ToObject<QueryOfficialDataResponse>(DoROARequest("QueryOfficialData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/datas", "json", req, runtime));
        }

        public async Task<QueryOfficialDataResponse> QueryOfficialDataWithOptionsAsync(QueryOfficialDataRequest request, QueryOfficialDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                query["param"] = request.Param;
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
            return TeaModel.ToObject<QueryOfficialDataResponse>(await DoROARequestAsync("QueryOfficialData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/datas", "json", req, runtime));
        }

        public QueryOfficialDatasetFieldsResponse QueryOfficialDatasetFields(QueryOfficialDatasetFieldsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOfficialDatasetFieldsHeaders headers = new QueryOfficialDatasetFieldsHeaders();
            return QueryOfficialDatasetFieldsWithOptions(request, headers, runtime);
        }

        public async Task<QueryOfficialDatasetFieldsResponse> QueryOfficialDatasetFieldsAsync(QueryOfficialDatasetFieldsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOfficialDatasetFieldsHeaders headers = new QueryOfficialDatasetFieldsHeaders();
            return await QueryOfficialDatasetFieldsWithOptionsAsync(request, headers, runtime);
        }

        public QueryOfficialDatasetFieldsResponse QueryOfficialDatasetFieldsWithOptions(QueryOfficialDatasetFieldsRequest request, QueryOfficialDatasetFieldsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DsId))
            {
                query["dsId"] = request.DsId;
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
            return TeaModel.ToObject<QueryOfficialDatasetFieldsResponse>(DoROARequest("QueryOfficialDatasetFields", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/datasetFields", "json", req, runtime));
        }

        public async Task<QueryOfficialDatasetFieldsResponse> QueryOfficialDatasetFieldsWithOptionsAsync(QueryOfficialDatasetFieldsRequest request, QueryOfficialDatasetFieldsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DsId))
            {
                query["dsId"] = request.DsId;
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
            return TeaModel.ToObject<QueryOfficialDatasetFieldsResponse>(await DoROARequestAsync("QueryOfficialDatasetFields", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/datasetFields", "json", req, runtime));
        }

        public QueryOfficialDatasetListResponse QueryOfficialDatasetList(QueryOfficialDatasetListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOfficialDatasetListHeaders headers = new QueryOfficialDatasetListHeaders();
            return QueryOfficialDatasetListWithOptions(request, headers, runtime);
        }

        public async Task<QueryOfficialDatasetListResponse> QueryOfficialDatasetListAsync(QueryOfficialDatasetListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOfficialDatasetListHeaders headers = new QueryOfficialDatasetListHeaders();
            return await QueryOfficialDatasetListWithOptionsAsync(request, headers, runtime);
        }

        public QueryOfficialDatasetListResponse QueryOfficialDatasetListWithOptions(QueryOfficialDatasetListRequest request, QueryOfficialDatasetListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
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
            return TeaModel.ToObject<QueryOfficialDatasetListResponse>(DoROARequest("QueryOfficialDatasetList", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/datasetLists", "json", req, runtime));
        }

        public async Task<QueryOfficialDatasetListResponse> QueryOfficialDatasetListWithOptionsAsync(QueryOfficialDatasetListRequest request, QueryOfficialDatasetListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
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
            return TeaModel.ToObject<QueryOfficialDatasetListResponse>(await DoROARequestAsync("QueryOfficialDatasetList", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/datasetLists", "json", req, runtime));
        }

        public QueryOnlineUserStatisticalDataResponse QueryOnlineUserStatisticalData(QueryOnlineUserStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOnlineUserStatisticalDataHeaders headers = new QueryOnlineUserStatisticalDataHeaders();
            return QueryOnlineUserStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryOnlineUserStatisticalDataResponse> QueryOnlineUserStatisticalDataAsync(QueryOnlineUserStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOnlineUserStatisticalDataHeaders headers = new QueryOnlineUserStatisticalDataHeaders();
            return await QueryOnlineUserStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryOnlineUserStatisticalDataResponse QueryOnlineUserStatisticalDataWithOptions(QueryOnlineUserStatisticalDataRequest request, QueryOnlineUserStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryOnlineUserStatisticalDataResponse>(DoROARequest("QueryOnlineUserStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/onlineUserData", "json", req, runtime));
        }

        public async Task<QueryOnlineUserStatisticalDataResponse> QueryOnlineUserStatisticalDataWithOptionsAsync(QueryOnlineUserStatisticalDataRequest request, QueryOnlineUserStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryOnlineUserStatisticalDataResponse>(await DoROARequestAsync("QueryOnlineUserStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/onlineUserData", "json", req, runtime));
        }

        public QueryRedEnvelopeReciveStatisticalDataResponse QueryRedEnvelopeReciveStatisticalData(QueryRedEnvelopeReciveStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRedEnvelopeReciveStatisticalDataHeaders headers = new QueryRedEnvelopeReciveStatisticalDataHeaders();
            return QueryRedEnvelopeReciveStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryRedEnvelopeReciveStatisticalDataResponse> QueryRedEnvelopeReciveStatisticalDataAsync(QueryRedEnvelopeReciveStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRedEnvelopeReciveStatisticalDataHeaders headers = new QueryRedEnvelopeReciveStatisticalDataHeaders();
            return await QueryRedEnvelopeReciveStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryRedEnvelopeReciveStatisticalDataResponse QueryRedEnvelopeReciveStatisticalDataWithOptions(QueryRedEnvelopeReciveStatisticalDataRequest request, QueryRedEnvelopeReciveStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryRedEnvelopeReciveStatisticalDataResponse>(DoROARequest("QueryRedEnvelopeReciveStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/redEnvelopeReciveData", "json", req, runtime));
        }

        public async Task<QueryRedEnvelopeReciveStatisticalDataResponse> QueryRedEnvelopeReciveStatisticalDataWithOptionsAsync(QueryRedEnvelopeReciveStatisticalDataRequest request, QueryRedEnvelopeReciveStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryRedEnvelopeReciveStatisticalDataResponse>(await DoROARequestAsync("QueryRedEnvelopeReciveStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/redEnvelopeReciveData", "json", req, runtime));
        }

        public QueryRedEnvelopeSendStatisticalDataResponse QueryRedEnvelopeSendStatisticalData(QueryRedEnvelopeSendStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRedEnvelopeSendStatisticalDataHeaders headers = new QueryRedEnvelopeSendStatisticalDataHeaders();
            return QueryRedEnvelopeSendStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryRedEnvelopeSendStatisticalDataResponse> QueryRedEnvelopeSendStatisticalDataAsync(QueryRedEnvelopeSendStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRedEnvelopeSendStatisticalDataHeaders headers = new QueryRedEnvelopeSendStatisticalDataHeaders();
            return await QueryRedEnvelopeSendStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryRedEnvelopeSendStatisticalDataResponse QueryRedEnvelopeSendStatisticalDataWithOptions(QueryRedEnvelopeSendStatisticalDataRequest request, QueryRedEnvelopeSendStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryRedEnvelopeSendStatisticalDataResponse>(DoROARequest("QueryRedEnvelopeSendStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/redEnvelopeSendData", "json", req, runtime));
        }

        public async Task<QueryRedEnvelopeSendStatisticalDataResponse> QueryRedEnvelopeSendStatisticalDataWithOptionsAsync(QueryRedEnvelopeSendStatisticalDataRequest request, QueryRedEnvelopeSendStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryRedEnvelopeSendStatisticalDataResponse>(await DoROARequestAsync("QueryRedEnvelopeSendStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/redEnvelopeSendData", "json", req, runtime));
        }

        public QueryReportStatisticalDataResponse QueryReportStatisticalData(QueryReportStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryReportStatisticalDataHeaders headers = new QueryReportStatisticalDataHeaders();
            return QueryReportStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryReportStatisticalDataResponse> QueryReportStatisticalDataAsync(QueryReportStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryReportStatisticalDataHeaders headers = new QueryReportStatisticalDataHeaders();
            return await QueryReportStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryReportStatisticalDataResponse QueryReportStatisticalDataWithOptions(QueryReportStatisticalDataRequest request, QueryReportStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryReportStatisticalDataResponse>(DoROARequest("QueryReportStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/reportData", "json", req, runtime));
        }

        public async Task<QueryReportStatisticalDataResponse> QueryReportStatisticalDataWithOptionsAsync(QueryReportStatisticalDataRequest request, QueryReportStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryReportStatisticalDataResponse>(await DoROARequestAsync("QueryReportStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/reportData", "json", req, runtime));
        }

        public QuerySingleMessageStatisticalDataResponse QuerySingleMessageStatisticalData(QuerySingleMessageStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySingleMessageStatisticalDataHeaders headers = new QuerySingleMessageStatisticalDataHeaders();
            return QuerySingleMessageStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QuerySingleMessageStatisticalDataResponse> QuerySingleMessageStatisticalDataAsync(QuerySingleMessageStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySingleMessageStatisticalDataHeaders headers = new QuerySingleMessageStatisticalDataHeaders();
            return await QuerySingleMessageStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QuerySingleMessageStatisticalDataResponse QuerySingleMessageStatisticalDataWithOptions(QuerySingleMessageStatisticalDataRequest request, QuerySingleMessageStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QuerySingleMessageStatisticalDataResponse>(DoROARequest("QuerySingleMessageStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/singleMessagerData", "json", req, runtime));
        }

        public async Task<QuerySingleMessageStatisticalDataResponse> QuerySingleMessageStatisticalDataWithOptionsAsync(QuerySingleMessageStatisticalDataRequest request, QuerySingleMessageStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QuerySingleMessageStatisticalDataResponse>(await DoROARequestAsync("QuerySingleMessageStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/singleMessagerData", "json", req, runtime));
        }

        public QueryTelMeetingStatisticalDataResponse QueryTelMeetingStatisticalData(QueryTelMeetingStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTelMeetingStatisticalDataHeaders headers = new QueryTelMeetingStatisticalDataHeaders();
            return QueryTelMeetingStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryTelMeetingStatisticalDataResponse> QueryTelMeetingStatisticalDataAsync(QueryTelMeetingStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTelMeetingStatisticalDataHeaders headers = new QueryTelMeetingStatisticalDataHeaders();
            return await QueryTelMeetingStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryTelMeetingStatisticalDataResponse QueryTelMeetingStatisticalDataWithOptions(QueryTelMeetingStatisticalDataRequest request, QueryTelMeetingStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryTelMeetingStatisticalDataResponse>(DoROARequest("QueryTelMeetingStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/telMeetingData", "json", req, runtime));
        }

        public async Task<QueryTelMeetingStatisticalDataResponse> QueryTelMeetingStatisticalDataWithOptionsAsync(QueryTelMeetingStatisticalDataRequest request, QueryTelMeetingStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryTelMeetingStatisticalDataResponse>(await DoROARequestAsync("QueryTelMeetingStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/telMeetingData", "json", req, runtime));
        }

        public QueryTodoStatisticalDataResponse QueryTodoStatisticalData(QueryTodoStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTodoStatisticalDataHeaders headers = new QueryTodoStatisticalDataHeaders();
            return QueryTodoStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryTodoStatisticalDataResponse> QueryTodoStatisticalDataAsync(QueryTodoStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTodoStatisticalDataHeaders headers = new QueryTodoStatisticalDataHeaders();
            return await QueryTodoStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryTodoStatisticalDataResponse QueryTodoStatisticalDataWithOptions(QueryTodoStatisticalDataRequest request, QueryTodoStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryTodoStatisticalDataResponse>(DoROARequest("QueryTodoStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/todoUserData", "json", req, runtime));
        }

        public async Task<QueryTodoStatisticalDataResponse> QueryTodoStatisticalDataWithOptionsAsync(QueryTodoStatisticalDataRequest request, QueryTodoStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryTodoStatisticalDataResponse>(await DoROARequestAsync("QueryTodoStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/todoUserData", "json", req, runtime));
        }

        public QueryVedioMeetingStatisticalDataResponse QueryVedioMeetingStatisticalData(QueryVedioMeetingStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryVedioMeetingStatisticalDataHeaders headers = new QueryVedioMeetingStatisticalDataHeaders();
            return QueryVedioMeetingStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryVedioMeetingStatisticalDataResponse> QueryVedioMeetingStatisticalDataAsync(QueryVedioMeetingStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryVedioMeetingStatisticalDataHeaders headers = new QueryVedioMeetingStatisticalDataHeaders();
            return await QueryVedioMeetingStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryVedioMeetingStatisticalDataResponse QueryVedioMeetingStatisticalDataWithOptions(QueryVedioMeetingStatisticalDataRequest request, QueryVedioMeetingStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryVedioMeetingStatisticalDataResponse>(DoROARequest("QueryVedioMeetingStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/vedioMeetingData", "json", req, runtime));
        }

        public async Task<QueryVedioMeetingStatisticalDataResponse> QueryVedioMeetingStatisticalDataWithOptionsAsync(QueryVedioMeetingStatisticalDataRequest request, QueryVedioMeetingStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryVedioMeetingStatisticalDataResponse>(await DoROARequestAsync("QueryVedioMeetingStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/vedioMeetingData", "json", req, runtime));
        }

        public QueryYydActiveDayStatisticalDataResponse QueryYydActiveDayStatisticalData(QueryYydActiveDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydActiveDayStatisticalDataHeaders headers = new QueryYydActiveDayStatisticalDataHeaders();
            return QueryYydActiveDayStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryYydActiveDayStatisticalDataResponse> QueryYydActiveDayStatisticalDataAsync(QueryYydActiveDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydActiveDayStatisticalDataHeaders headers = new QueryYydActiveDayStatisticalDataHeaders();
            return await QueryYydActiveDayStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryYydActiveDayStatisticalDataResponse QueryYydActiveDayStatisticalDataWithOptions(QueryYydActiveDayStatisticalDataRequest request, QueryYydActiveDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydActiveDayStatisticalDataResponse>(DoROARequest("QueryYydActiveDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydActiveDayDatas", "json", req, runtime));
        }

        public async Task<QueryYydActiveDayStatisticalDataResponse> QueryYydActiveDayStatisticalDataWithOptionsAsync(QueryYydActiveDayStatisticalDataRequest request, QueryYydActiveDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydActiveDayStatisticalDataResponse>(await DoROARequestAsync("QueryYydActiveDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydActiveDayDatas", "json", req, runtime));
        }

        public QueryYydActiveMonthStatisticalDataResponse QueryYydActiveMonthStatisticalData(QueryYydActiveMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydActiveMonthStatisticalDataHeaders headers = new QueryYydActiveMonthStatisticalDataHeaders();
            return QueryYydActiveMonthStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryYydActiveMonthStatisticalDataResponse> QueryYydActiveMonthStatisticalDataAsync(QueryYydActiveMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydActiveMonthStatisticalDataHeaders headers = new QueryYydActiveMonthStatisticalDataHeaders();
            return await QueryYydActiveMonthStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryYydActiveMonthStatisticalDataResponse QueryYydActiveMonthStatisticalDataWithOptions(QueryYydActiveMonthStatisticalDataRequest request, QueryYydActiveMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydActiveMonthStatisticalDataResponse>(DoROARequest("QueryYydActiveMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydActiveMonthDatas", "json", req, runtime));
        }

        public async Task<QueryYydActiveMonthStatisticalDataResponse> QueryYydActiveMonthStatisticalDataWithOptionsAsync(QueryYydActiveMonthStatisticalDataRequest request, QueryYydActiveMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydActiveMonthStatisticalDataResponse>(await DoROARequestAsync("QueryYydActiveMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydActiveMonthDatas", "json", req, runtime));
        }

        public QueryYydActiveWeekStatisticalDataResponse QueryYydActiveWeekStatisticalData(QueryYydActiveWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydActiveWeekStatisticalDataHeaders headers = new QueryYydActiveWeekStatisticalDataHeaders();
            return QueryYydActiveWeekStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryYydActiveWeekStatisticalDataResponse> QueryYydActiveWeekStatisticalDataAsync(QueryYydActiveWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydActiveWeekStatisticalDataHeaders headers = new QueryYydActiveWeekStatisticalDataHeaders();
            return await QueryYydActiveWeekStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryYydActiveWeekStatisticalDataResponse QueryYydActiveWeekStatisticalDataWithOptions(QueryYydActiveWeekStatisticalDataRequest request, QueryYydActiveWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydActiveWeekStatisticalDataResponse>(DoROARequest("QueryYydActiveWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydActiveWeekDatas", "json", req, runtime));
        }

        public async Task<QueryYydActiveWeekStatisticalDataResponse> QueryYydActiveWeekStatisticalDataWithOptionsAsync(QueryYydActiveWeekStatisticalDataRequest request, QueryYydActiveWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydActiveWeekStatisticalDataResponse>(await DoROARequestAsync("QueryYydActiveWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydActiveWeekDatas", "json", req, runtime));
        }

        public QueryYydAppDayStatisticalDataResponse QueryYydAppDayStatisticalData(QueryYydAppDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydAppDayStatisticalDataHeaders headers = new QueryYydAppDayStatisticalDataHeaders();
            return QueryYydAppDayStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryYydAppDayStatisticalDataResponse> QueryYydAppDayStatisticalDataAsync(QueryYydAppDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydAppDayStatisticalDataHeaders headers = new QueryYydAppDayStatisticalDataHeaders();
            return await QueryYydAppDayStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryYydAppDayStatisticalDataResponse QueryYydAppDayStatisticalDataWithOptions(QueryYydAppDayStatisticalDataRequest request, QueryYydAppDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydAppDayStatisticalDataResponse>(DoROARequest("QueryYydAppDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydAppDayDatas", "json", req, runtime));
        }

        public async Task<QueryYydAppDayStatisticalDataResponse> QueryYydAppDayStatisticalDataWithOptionsAsync(QueryYydAppDayStatisticalDataRequest request, QueryYydAppDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydAppDayStatisticalDataResponse>(await DoROARequestAsync("QueryYydAppDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydAppDayDatas", "json", req, runtime));
        }

        public QueryYydAppMonthStatisticalDataResponse QueryYydAppMonthStatisticalData(QueryYydAppMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydAppMonthStatisticalDataHeaders headers = new QueryYydAppMonthStatisticalDataHeaders();
            return QueryYydAppMonthStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryYydAppMonthStatisticalDataResponse> QueryYydAppMonthStatisticalDataAsync(QueryYydAppMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydAppMonthStatisticalDataHeaders headers = new QueryYydAppMonthStatisticalDataHeaders();
            return await QueryYydAppMonthStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryYydAppMonthStatisticalDataResponse QueryYydAppMonthStatisticalDataWithOptions(QueryYydAppMonthStatisticalDataRequest request, QueryYydAppMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydAppMonthStatisticalDataResponse>(DoROARequest("QueryYydAppMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydAppMonthDatas", "json", req, runtime));
        }

        public async Task<QueryYydAppMonthStatisticalDataResponse> QueryYydAppMonthStatisticalDataWithOptionsAsync(QueryYydAppMonthStatisticalDataRequest request, QueryYydAppMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydAppMonthStatisticalDataResponse>(await DoROARequestAsync("QueryYydAppMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydAppMonthDatas", "json", req, runtime));
        }

        public QueryYydAppStdStatisticalDataResponse QueryYydAppStdStatisticalData(QueryYydAppStdStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydAppStdStatisticalDataHeaders headers = new QueryYydAppStdStatisticalDataHeaders();
            return QueryYydAppStdStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryYydAppStdStatisticalDataResponse> QueryYydAppStdStatisticalDataAsync(QueryYydAppStdStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydAppStdStatisticalDataHeaders headers = new QueryYydAppStdStatisticalDataHeaders();
            return await QueryYydAppStdStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryYydAppStdStatisticalDataResponse QueryYydAppStdStatisticalDataWithOptions(QueryYydAppStdStatisticalDataRequest request, QueryYydAppStdStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydAppStdStatisticalDataResponse>(DoROARequest("QueryYydAppStdStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydAppStdDatas", "json", req, runtime));
        }

        public async Task<QueryYydAppStdStatisticalDataResponse> QueryYydAppStdStatisticalDataWithOptionsAsync(QueryYydAppStdStatisticalDataRequest request, QueryYydAppStdStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydAppStdStatisticalDataResponse>(await DoROARequestAsync("QueryYydAppStdStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydAppStdDatas", "json", req, runtime));
        }

        public QueryYydAppWeekStatisticalDataResponse QueryYydAppWeekStatisticalData(QueryYydAppWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydAppWeekStatisticalDataHeaders headers = new QueryYydAppWeekStatisticalDataHeaders();
            return QueryYydAppWeekStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryYydAppWeekStatisticalDataResponse> QueryYydAppWeekStatisticalDataAsync(QueryYydAppWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydAppWeekStatisticalDataHeaders headers = new QueryYydAppWeekStatisticalDataHeaders();
            return await QueryYydAppWeekStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryYydAppWeekStatisticalDataResponse QueryYydAppWeekStatisticalDataWithOptions(QueryYydAppWeekStatisticalDataRequest request, QueryYydAppWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydAppWeekStatisticalDataResponse>(DoROARequest("QueryYydAppWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydAppWeekDatas", "json", req, runtime));
        }

        public async Task<QueryYydAppWeekStatisticalDataResponse> QueryYydAppWeekStatisticalDataWithOptionsAsync(QueryYydAppWeekStatisticalDataRequest request, QueryYydAppWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydAppWeekStatisticalDataResponse>(await DoROARequestAsync("QueryYydAppWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydAppWeekDatas", "json", req, runtime));
        }

        public QueryYydCalendarDayStatisticalDataResponse QueryYydCalendarDayStatisticalData(QueryYydCalendarDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydCalendarDayStatisticalDataHeaders headers = new QueryYydCalendarDayStatisticalDataHeaders();
            return QueryYydCalendarDayStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryYydCalendarDayStatisticalDataResponse> QueryYydCalendarDayStatisticalDataAsync(QueryYydCalendarDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydCalendarDayStatisticalDataHeaders headers = new QueryYydCalendarDayStatisticalDataHeaders();
            return await QueryYydCalendarDayStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryYydCalendarDayStatisticalDataResponse QueryYydCalendarDayStatisticalDataWithOptions(QueryYydCalendarDayStatisticalDataRequest request, QueryYydCalendarDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydCalendarDayStatisticalDataResponse>(DoROARequest("QueryYydCalendarDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydCalendarDayDatas", "json", req, runtime));
        }

        public async Task<QueryYydCalendarDayStatisticalDataResponse> QueryYydCalendarDayStatisticalDataWithOptionsAsync(QueryYydCalendarDayStatisticalDataRequest request, QueryYydCalendarDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydCalendarDayStatisticalDataResponse>(await DoROARequestAsync("QueryYydCalendarDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydCalendarDayDatas", "json", req, runtime));
        }

        public QueryYydCalendarMonthStatisticalDataResponse QueryYydCalendarMonthStatisticalData(QueryYydCalendarMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydCalendarMonthStatisticalDataHeaders headers = new QueryYydCalendarMonthStatisticalDataHeaders();
            return QueryYydCalendarMonthStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryYydCalendarMonthStatisticalDataResponse> QueryYydCalendarMonthStatisticalDataAsync(QueryYydCalendarMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydCalendarMonthStatisticalDataHeaders headers = new QueryYydCalendarMonthStatisticalDataHeaders();
            return await QueryYydCalendarMonthStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryYydCalendarMonthStatisticalDataResponse QueryYydCalendarMonthStatisticalDataWithOptions(QueryYydCalendarMonthStatisticalDataRequest request, QueryYydCalendarMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydCalendarMonthStatisticalDataResponse>(DoROARequest("QueryYydCalendarMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydCalendarMonthDatas", "json", req, runtime));
        }

        public async Task<QueryYydCalendarMonthStatisticalDataResponse> QueryYydCalendarMonthStatisticalDataWithOptionsAsync(QueryYydCalendarMonthStatisticalDataRequest request, QueryYydCalendarMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydCalendarMonthStatisticalDataResponse>(await DoROARequestAsync("QueryYydCalendarMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydCalendarMonthDatas", "json", req, runtime));
        }

        public QueryYydCalendarWeekStatisticalDataResponse QueryYydCalendarWeekStatisticalData(QueryYydCalendarWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydCalendarWeekStatisticalDataHeaders headers = new QueryYydCalendarWeekStatisticalDataHeaders();
            return QueryYydCalendarWeekStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryYydCalendarWeekStatisticalDataResponse> QueryYydCalendarWeekStatisticalDataAsync(QueryYydCalendarWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydCalendarWeekStatisticalDataHeaders headers = new QueryYydCalendarWeekStatisticalDataHeaders();
            return await QueryYydCalendarWeekStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryYydCalendarWeekStatisticalDataResponse QueryYydCalendarWeekStatisticalDataWithOptions(QueryYydCalendarWeekStatisticalDataRequest request, QueryYydCalendarWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydCalendarWeekStatisticalDataResponse>(DoROARequest("QueryYydCalendarWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydCalendarWeekDatas", "json", req, runtime));
        }

        public async Task<QueryYydCalendarWeekStatisticalDataResponse> QueryYydCalendarWeekStatisticalDataWithOptionsAsync(QueryYydCalendarWeekStatisticalDataRequest request, QueryYydCalendarWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydCalendarWeekStatisticalDataResponse>(await DoROARequestAsync("QueryYydCalendarWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydCalendarWeekDatas", "json", req, runtime));
        }

        public QueryYydDingMsgDayStatisticalDataResponse QueryYydDingMsgDayStatisticalData(QueryYydDingMsgDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydDingMsgDayStatisticalDataHeaders headers = new QueryYydDingMsgDayStatisticalDataHeaders();
            return QueryYydDingMsgDayStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryYydDingMsgDayStatisticalDataResponse> QueryYydDingMsgDayStatisticalDataAsync(QueryYydDingMsgDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydDingMsgDayStatisticalDataHeaders headers = new QueryYydDingMsgDayStatisticalDataHeaders();
            return await QueryYydDingMsgDayStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryYydDingMsgDayStatisticalDataResponse QueryYydDingMsgDayStatisticalDataWithOptions(QueryYydDingMsgDayStatisticalDataRequest request, QueryYydDingMsgDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydDingMsgDayStatisticalDataResponse>(DoROARequest("QueryYydDingMsgDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydDingMsgDayDatas", "json", req, runtime));
        }

        public async Task<QueryYydDingMsgDayStatisticalDataResponse> QueryYydDingMsgDayStatisticalDataWithOptionsAsync(QueryYydDingMsgDayStatisticalDataRequest request, QueryYydDingMsgDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydDingMsgDayStatisticalDataResponse>(await DoROARequestAsync("QueryYydDingMsgDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydDingMsgDayDatas", "json", req, runtime));
        }

        public QueryYydDingMsgMonthStatisticalDataResponse QueryYydDingMsgMonthStatisticalData(QueryYydDingMsgMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydDingMsgMonthStatisticalDataHeaders headers = new QueryYydDingMsgMonthStatisticalDataHeaders();
            return QueryYydDingMsgMonthStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryYydDingMsgMonthStatisticalDataResponse> QueryYydDingMsgMonthStatisticalDataAsync(QueryYydDingMsgMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydDingMsgMonthStatisticalDataHeaders headers = new QueryYydDingMsgMonthStatisticalDataHeaders();
            return await QueryYydDingMsgMonthStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryYydDingMsgMonthStatisticalDataResponse QueryYydDingMsgMonthStatisticalDataWithOptions(QueryYydDingMsgMonthStatisticalDataRequest request, QueryYydDingMsgMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydDingMsgMonthStatisticalDataResponse>(DoROARequest("QueryYydDingMsgMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydDingMsgMonthDatas", "json", req, runtime));
        }

        public async Task<QueryYydDingMsgMonthStatisticalDataResponse> QueryYydDingMsgMonthStatisticalDataWithOptionsAsync(QueryYydDingMsgMonthStatisticalDataRequest request, QueryYydDingMsgMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydDingMsgMonthStatisticalDataResponse>(await DoROARequestAsync("QueryYydDingMsgMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydDingMsgMonthDatas", "json", req, runtime));
        }

        public QueryYydDingMsgWeekStatisticalDataResponse QueryYydDingMsgWeekStatisticalData(QueryYydDingMsgWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydDingMsgWeekStatisticalDataHeaders headers = new QueryYydDingMsgWeekStatisticalDataHeaders();
            return QueryYydDingMsgWeekStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryYydDingMsgWeekStatisticalDataResponse> QueryYydDingMsgWeekStatisticalDataAsync(QueryYydDingMsgWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydDingMsgWeekStatisticalDataHeaders headers = new QueryYydDingMsgWeekStatisticalDataHeaders();
            return await QueryYydDingMsgWeekStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryYydDingMsgWeekStatisticalDataResponse QueryYydDingMsgWeekStatisticalDataWithOptions(QueryYydDingMsgWeekStatisticalDataRequest request, QueryYydDingMsgWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydDingMsgWeekStatisticalDataResponse>(DoROARequest("QueryYydDingMsgWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydDingMsgWeekDatas", "json", req, runtime));
        }

        public async Task<QueryYydDingMsgWeekStatisticalDataResponse> QueryYydDingMsgWeekStatisticalDataWithOptionsAsync(QueryYydDingMsgWeekStatisticalDataRequest request, QueryYydDingMsgWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydDingMsgWeekStatisticalDataResponse>(await DoROARequestAsync("QueryYydDingMsgWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydDingMsgWeekDatas", "json", req, runtime));
        }

        public QueryYydGroupMsgDayStatisticalDataResponse QueryYydGroupMsgDayStatisticalData(QueryYydGroupMsgDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydGroupMsgDayStatisticalDataHeaders headers = new QueryYydGroupMsgDayStatisticalDataHeaders();
            return QueryYydGroupMsgDayStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryYydGroupMsgDayStatisticalDataResponse> QueryYydGroupMsgDayStatisticalDataAsync(QueryYydGroupMsgDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydGroupMsgDayStatisticalDataHeaders headers = new QueryYydGroupMsgDayStatisticalDataHeaders();
            return await QueryYydGroupMsgDayStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryYydGroupMsgDayStatisticalDataResponse QueryYydGroupMsgDayStatisticalDataWithOptions(QueryYydGroupMsgDayStatisticalDataRequest request, QueryYydGroupMsgDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydGroupMsgDayStatisticalDataResponse>(DoROARequest("QueryYydGroupMsgDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydGroupMsgDayDatas", "json", req, runtime));
        }

        public async Task<QueryYydGroupMsgDayStatisticalDataResponse> QueryYydGroupMsgDayStatisticalDataWithOptionsAsync(QueryYydGroupMsgDayStatisticalDataRequest request, QueryYydGroupMsgDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydGroupMsgDayStatisticalDataResponse>(await DoROARequestAsync("QueryYydGroupMsgDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydGroupMsgDayDatas", "json", req, runtime));
        }

        public QueryYydGroupMsgMonthStatisticalDataResponse QueryYydGroupMsgMonthStatisticalData(QueryYydGroupMsgMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydGroupMsgMonthStatisticalDataHeaders headers = new QueryYydGroupMsgMonthStatisticalDataHeaders();
            return QueryYydGroupMsgMonthStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryYydGroupMsgMonthStatisticalDataResponse> QueryYydGroupMsgMonthStatisticalDataAsync(QueryYydGroupMsgMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydGroupMsgMonthStatisticalDataHeaders headers = new QueryYydGroupMsgMonthStatisticalDataHeaders();
            return await QueryYydGroupMsgMonthStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryYydGroupMsgMonthStatisticalDataResponse QueryYydGroupMsgMonthStatisticalDataWithOptions(QueryYydGroupMsgMonthStatisticalDataRequest request, QueryYydGroupMsgMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydGroupMsgMonthStatisticalDataResponse>(DoROARequest("QueryYydGroupMsgMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydGroupMsgMonthDatas", "json", req, runtime));
        }

        public async Task<QueryYydGroupMsgMonthStatisticalDataResponse> QueryYydGroupMsgMonthStatisticalDataWithOptionsAsync(QueryYydGroupMsgMonthStatisticalDataRequest request, QueryYydGroupMsgMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydGroupMsgMonthStatisticalDataResponse>(await DoROARequestAsync("QueryYydGroupMsgMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydGroupMsgMonthDatas", "json", req, runtime));
        }

        public QueryYydGroupMsgWeekStatisticalDataResponse QueryYydGroupMsgWeekStatisticalData(QueryYydGroupMsgWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydGroupMsgWeekStatisticalDataHeaders headers = new QueryYydGroupMsgWeekStatisticalDataHeaders();
            return QueryYydGroupMsgWeekStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryYydGroupMsgWeekStatisticalDataResponse> QueryYydGroupMsgWeekStatisticalDataAsync(QueryYydGroupMsgWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydGroupMsgWeekStatisticalDataHeaders headers = new QueryYydGroupMsgWeekStatisticalDataHeaders();
            return await QueryYydGroupMsgWeekStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryYydGroupMsgWeekStatisticalDataResponse QueryYydGroupMsgWeekStatisticalDataWithOptions(QueryYydGroupMsgWeekStatisticalDataRequest request, QueryYydGroupMsgWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydGroupMsgWeekStatisticalDataResponse>(DoROARequest("QueryYydGroupMsgWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydGroupMsgWeekDatas", "json", req, runtime));
        }

        public async Task<QueryYydGroupMsgWeekStatisticalDataResponse> QueryYydGroupMsgWeekStatisticalDataWithOptionsAsync(QueryYydGroupMsgWeekStatisticalDataRequest request, QueryYydGroupMsgWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydGroupMsgWeekStatisticalDataResponse>(await DoROARequestAsync("QueryYydGroupMsgWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydGroupMsgWeekDatas", "json", req, runtime));
        }

        public QueryYydLogDayStatisticalDataResponse QueryYydLogDayStatisticalData(QueryYydLogDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydLogDayStatisticalDataHeaders headers = new QueryYydLogDayStatisticalDataHeaders();
            return QueryYydLogDayStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryYydLogDayStatisticalDataResponse> QueryYydLogDayStatisticalDataAsync(QueryYydLogDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydLogDayStatisticalDataHeaders headers = new QueryYydLogDayStatisticalDataHeaders();
            return await QueryYydLogDayStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryYydLogDayStatisticalDataResponse QueryYydLogDayStatisticalDataWithOptions(QueryYydLogDayStatisticalDataRequest request, QueryYydLogDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydLogDayStatisticalDataResponse>(DoROARequest("QueryYydLogDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydLogDayDatas", "json", req, runtime));
        }

        public async Task<QueryYydLogDayStatisticalDataResponse> QueryYydLogDayStatisticalDataWithOptionsAsync(QueryYydLogDayStatisticalDataRequest request, QueryYydLogDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydLogDayStatisticalDataResponse>(await DoROARequestAsync("QueryYydLogDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydLogDayDatas", "json", req, runtime));
        }

        public QueryYydLogMonthStatisticalDataResponse QueryYydLogMonthStatisticalData(QueryYydLogMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydLogMonthStatisticalDataHeaders headers = new QueryYydLogMonthStatisticalDataHeaders();
            return QueryYydLogMonthStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryYydLogMonthStatisticalDataResponse> QueryYydLogMonthStatisticalDataAsync(QueryYydLogMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydLogMonthStatisticalDataHeaders headers = new QueryYydLogMonthStatisticalDataHeaders();
            return await QueryYydLogMonthStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryYydLogMonthStatisticalDataResponse QueryYydLogMonthStatisticalDataWithOptions(QueryYydLogMonthStatisticalDataRequest request, QueryYydLogMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydLogMonthStatisticalDataResponse>(DoROARequest("QueryYydLogMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydLogMonthDatas", "json", req, runtime));
        }

        public async Task<QueryYydLogMonthStatisticalDataResponse> QueryYydLogMonthStatisticalDataWithOptionsAsync(QueryYydLogMonthStatisticalDataRequest request, QueryYydLogMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydLogMonthStatisticalDataResponse>(await DoROARequestAsync("QueryYydLogMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydLogMonthDatas", "json", req, runtime));
        }

        public QueryYydLogWeekStatisticalDataResponse QueryYydLogWeekStatisticalData(QueryYydLogWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydLogWeekStatisticalDataHeaders headers = new QueryYydLogWeekStatisticalDataHeaders();
            return QueryYydLogWeekStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryYydLogWeekStatisticalDataResponse> QueryYydLogWeekStatisticalDataAsync(QueryYydLogWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydLogWeekStatisticalDataHeaders headers = new QueryYydLogWeekStatisticalDataHeaders();
            return await QueryYydLogWeekStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryYydLogWeekStatisticalDataResponse QueryYydLogWeekStatisticalDataWithOptions(QueryYydLogWeekStatisticalDataRequest request, QueryYydLogWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydLogWeekStatisticalDataResponse>(DoROARequest("QueryYydLogWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydLogWeekDatas", "json", req, runtime));
        }

        public async Task<QueryYydLogWeekStatisticalDataResponse> QueryYydLogWeekStatisticalDataWithOptionsAsync(QueryYydLogWeekStatisticalDataRequest request, QueryYydLogWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydLogWeekStatisticalDataResponse>(await DoROARequestAsync("QueryYydLogWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydLogWeekDatas", "json", req, runtime));
        }

        public QueryYydMeetingDayStatisticalDataResponse QueryYydMeetingDayStatisticalData(QueryYydMeetingDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydMeetingDayStatisticalDataHeaders headers = new QueryYydMeetingDayStatisticalDataHeaders();
            return QueryYydMeetingDayStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryYydMeetingDayStatisticalDataResponse> QueryYydMeetingDayStatisticalDataAsync(QueryYydMeetingDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydMeetingDayStatisticalDataHeaders headers = new QueryYydMeetingDayStatisticalDataHeaders();
            return await QueryYydMeetingDayStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryYydMeetingDayStatisticalDataResponse QueryYydMeetingDayStatisticalDataWithOptions(QueryYydMeetingDayStatisticalDataRequest request, QueryYydMeetingDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydMeetingDayStatisticalDataResponse>(DoROARequest("QueryYydMeetingDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydMeetingDayDatas", "json", req, runtime));
        }

        public async Task<QueryYydMeetingDayStatisticalDataResponse> QueryYydMeetingDayStatisticalDataWithOptionsAsync(QueryYydMeetingDayStatisticalDataRequest request, QueryYydMeetingDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydMeetingDayStatisticalDataResponse>(await DoROARequestAsync("QueryYydMeetingDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydMeetingDayDatas", "json", req, runtime));
        }

        public QueryYydMeetingMonthStatisticalDataResponse QueryYydMeetingMonthStatisticalData(QueryYydMeetingMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydMeetingMonthStatisticalDataHeaders headers = new QueryYydMeetingMonthStatisticalDataHeaders();
            return QueryYydMeetingMonthStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryYydMeetingMonthStatisticalDataResponse> QueryYydMeetingMonthStatisticalDataAsync(QueryYydMeetingMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydMeetingMonthStatisticalDataHeaders headers = new QueryYydMeetingMonthStatisticalDataHeaders();
            return await QueryYydMeetingMonthStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryYydMeetingMonthStatisticalDataResponse QueryYydMeetingMonthStatisticalDataWithOptions(QueryYydMeetingMonthStatisticalDataRequest request, QueryYydMeetingMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydMeetingMonthStatisticalDataResponse>(DoROARequest("QueryYydMeetingMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydMeetingMonthDatas", "json", req, runtime));
        }

        public async Task<QueryYydMeetingMonthStatisticalDataResponse> QueryYydMeetingMonthStatisticalDataWithOptionsAsync(QueryYydMeetingMonthStatisticalDataRequest request, QueryYydMeetingMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydMeetingMonthStatisticalDataResponse>(await DoROARequestAsync("QueryYydMeetingMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydMeetingMonthDatas", "json", req, runtime));
        }

        public QueryYydMeetingWeekStatisticalDataResponse QueryYydMeetingWeekStatisticalData(QueryYydMeetingWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydMeetingWeekStatisticalDataHeaders headers = new QueryYydMeetingWeekStatisticalDataHeaders();
            return QueryYydMeetingWeekStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryYydMeetingWeekStatisticalDataResponse> QueryYydMeetingWeekStatisticalDataAsync(QueryYydMeetingWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydMeetingWeekStatisticalDataHeaders headers = new QueryYydMeetingWeekStatisticalDataHeaders();
            return await QueryYydMeetingWeekStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryYydMeetingWeekStatisticalDataResponse QueryYydMeetingWeekStatisticalDataWithOptions(QueryYydMeetingWeekStatisticalDataRequest request, QueryYydMeetingWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydMeetingWeekStatisticalDataResponse>(DoROARequest("QueryYydMeetingWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydMeetingWeekDatas", "json", req, runtime));
        }

        public async Task<QueryYydMeetingWeekStatisticalDataResponse> QueryYydMeetingWeekStatisticalDataWithOptionsAsync(QueryYydMeetingWeekStatisticalDataRequest request, QueryYydMeetingWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydMeetingWeekStatisticalDataResponse>(await DoROARequestAsync("QueryYydMeetingWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydMeetingWeekDatas", "json", req, runtime));
        }

        public QueryYydNoticeDayStatisticalDataResponse QueryYydNoticeDayStatisticalData(QueryYydNoticeDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydNoticeDayStatisticalDataHeaders headers = new QueryYydNoticeDayStatisticalDataHeaders();
            return QueryYydNoticeDayStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryYydNoticeDayStatisticalDataResponse> QueryYydNoticeDayStatisticalDataAsync(QueryYydNoticeDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydNoticeDayStatisticalDataHeaders headers = new QueryYydNoticeDayStatisticalDataHeaders();
            return await QueryYydNoticeDayStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryYydNoticeDayStatisticalDataResponse QueryYydNoticeDayStatisticalDataWithOptions(QueryYydNoticeDayStatisticalDataRequest request, QueryYydNoticeDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydNoticeDayStatisticalDataResponse>(DoROARequest("QueryYydNoticeDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydNoticeDayDatas", "json", req, runtime));
        }

        public async Task<QueryYydNoticeDayStatisticalDataResponse> QueryYydNoticeDayStatisticalDataWithOptionsAsync(QueryYydNoticeDayStatisticalDataRequest request, QueryYydNoticeDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydNoticeDayStatisticalDataResponse>(await DoROARequestAsync("QueryYydNoticeDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydNoticeDayDatas", "json", req, runtime));
        }

        public QueryYydNoticeMonthStatisticalDataResponse QueryYydNoticeMonthStatisticalData(QueryYydNoticeMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydNoticeMonthStatisticalDataHeaders headers = new QueryYydNoticeMonthStatisticalDataHeaders();
            return QueryYydNoticeMonthStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryYydNoticeMonthStatisticalDataResponse> QueryYydNoticeMonthStatisticalDataAsync(QueryYydNoticeMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydNoticeMonthStatisticalDataHeaders headers = new QueryYydNoticeMonthStatisticalDataHeaders();
            return await QueryYydNoticeMonthStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryYydNoticeMonthStatisticalDataResponse QueryYydNoticeMonthStatisticalDataWithOptions(QueryYydNoticeMonthStatisticalDataRequest request, QueryYydNoticeMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydNoticeMonthStatisticalDataResponse>(DoROARequest("QueryYydNoticeMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydNoticeMonthDatas", "json", req, runtime));
        }

        public async Task<QueryYydNoticeMonthStatisticalDataResponse> QueryYydNoticeMonthStatisticalDataWithOptionsAsync(QueryYydNoticeMonthStatisticalDataRequest request, QueryYydNoticeMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydNoticeMonthStatisticalDataResponse>(await DoROARequestAsync("QueryYydNoticeMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydNoticeMonthDatas", "json", req, runtime));
        }

        public QueryYydNoticeWeekStatisticalDataResponse QueryYydNoticeWeekStatisticalData(QueryYydNoticeWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydNoticeWeekStatisticalDataHeaders headers = new QueryYydNoticeWeekStatisticalDataHeaders();
            return QueryYydNoticeWeekStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryYydNoticeWeekStatisticalDataResponse> QueryYydNoticeWeekStatisticalDataAsync(QueryYydNoticeWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydNoticeWeekStatisticalDataHeaders headers = new QueryYydNoticeWeekStatisticalDataHeaders();
            return await QueryYydNoticeWeekStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryYydNoticeWeekStatisticalDataResponse QueryYydNoticeWeekStatisticalDataWithOptions(QueryYydNoticeWeekStatisticalDataRequest request, QueryYydNoticeWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydNoticeWeekStatisticalDataResponse>(DoROARequest("QueryYydNoticeWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydNoticeWeekDatas", "json", req, runtime));
        }

        public async Task<QueryYydNoticeWeekStatisticalDataResponse> QueryYydNoticeWeekStatisticalDataWithOptionsAsync(QueryYydNoticeWeekStatisticalDataRequest request, QueryYydNoticeWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydNoticeWeekStatisticalDataResponse>(await DoROARequestAsync("QueryYydNoticeWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydNoticeWeekDatas", "json", req, runtime));
        }

        public QueryYydSingleMsgDayStatisticalDataResponse QueryYydSingleMsgDayStatisticalData(QueryYydSingleMsgDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydSingleMsgDayStatisticalDataHeaders headers = new QueryYydSingleMsgDayStatisticalDataHeaders();
            return QueryYydSingleMsgDayStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryYydSingleMsgDayStatisticalDataResponse> QueryYydSingleMsgDayStatisticalDataAsync(QueryYydSingleMsgDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydSingleMsgDayStatisticalDataHeaders headers = new QueryYydSingleMsgDayStatisticalDataHeaders();
            return await QueryYydSingleMsgDayStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryYydSingleMsgDayStatisticalDataResponse QueryYydSingleMsgDayStatisticalDataWithOptions(QueryYydSingleMsgDayStatisticalDataRequest request, QueryYydSingleMsgDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydSingleMsgDayStatisticalDataResponse>(DoROARequest("QueryYydSingleMsgDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydSingleMsgDayDatas", "json", req, runtime));
        }

        public async Task<QueryYydSingleMsgDayStatisticalDataResponse> QueryYydSingleMsgDayStatisticalDataWithOptionsAsync(QueryYydSingleMsgDayStatisticalDataRequest request, QueryYydSingleMsgDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydSingleMsgDayStatisticalDataResponse>(await DoROARequestAsync("QueryYydSingleMsgDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydSingleMsgDayDatas", "json", req, runtime));
        }

        public QueryYydSingleMsgMonthStatisticalDataResponse QueryYydSingleMsgMonthStatisticalData(QueryYydSingleMsgMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydSingleMsgMonthStatisticalDataHeaders headers = new QueryYydSingleMsgMonthStatisticalDataHeaders();
            return QueryYydSingleMsgMonthStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryYydSingleMsgMonthStatisticalDataResponse> QueryYydSingleMsgMonthStatisticalDataAsync(QueryYydSingleMsgMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydSingleMsgMonthStatisticalDataHeaders headers = new QueryYydSingleMsgMonthStatisticalDataHeaders();
            return await QueryYydSingleMsgMonthStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryYydSingleMsgMonthStatisticalDataResponse QueryYydSingleMsgMonthStatisticalDataWithOptions(QueryYydSingleMsgMonthStatisticalDataRequest request, QueryYydSingleMsgMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydSingleMsgMonthStatisticalDataResponse>(DoROARequest("QueryYydSingleMsgMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydSingleMsgMonthDatas", "json", req, runtime));
        }

        public async Task<QueryYydSingleMsgMonthStatisticalDataResponse> QueryYydSingleMsgMonthStatisticalDataWithOptionsAsync(QueryYydSingleMsgMonthStatisticalDataRequest request, QueryYydSingleMsgMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydSingleMsgMonthStatisticalDataResponse>(await DoROARequestAsync("QueryYydSingleMsgMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydSingleMsgMonthDatas", "json", req, runtime));
        }

        public QueryYydSingleMsgWeekStatisticalDataResponse QueryYydSingleMsgWeekStatisticalData(QueryYydSingleMsgWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydSingleMsgWeekStatisticalDataHeaders headers = new QueryYydSingleMsgWeekStatisticalDataHeaders();
            return QueryYydSingleMsgWeekStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryYydSingleMsgWeekStatisticalDataResponse> QueryYydSingleMsgWeekStatisticalDataAsync(QueryYydSingleMsgWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydSingleMsgWeekStatisticalDataHeaders headers = new QueryYydSingleMsgWeekStatisticalDataHeaders();
            return await QueryYydSingleMsgWeekStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryYydSingleMsgWeekStatisticalDataResponse QueryYydSingleMsgWeekStatisticalDataWithOptions(QueryYydSingleMsgWeekStatisticalDataRequest request, QueryYydSingleMsgWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydSingleMsgWeekStatisticalDataResponse>(DoROARequest("QueryYydSingleMsgWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydSingleMsgWeekDatas", "json", req, runtime));
        }

        public async Task<QueryYydSingleMsgWeekStatisticalDataResponse> QueryYydSingleMsgWeekStatisticalDataWithOptionsAsync(QueryYydSingleMsgWeekStatisticalDataRequest request, QueryYydSingleMsgWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydSingleMsgWeekStatisticalDataResponse>(await DoROARequestAsync("QueryYydSingleMsgWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydSingleMsgWeekDatas", "json", req, runtime));
        }

        public QueryYydToatlMsgDayStatisticalDataResponse QueryYydToatlMsgDayStatisticalData(QueryYydToatlMsgDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydToatlMsgDayStatisticalDataHeaders headers = new QueryYydToatlMsgDayStatisticalDataHeaders();
            return QueryYydToatlMsgDayStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryYydToatlMsgDayStatisticalDataResponse> QueryYydToatlMsgDayStatisticalDataAsync(QueryYydToatlMsgDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydToatlMsgDayStatisticalDataHeaders headers = new QueryYydToatlMsgDayStatisticalDataHeaders();
            return await QueryYydToatlMsgDayStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryYydToatlMsgDayStatisticalDataResponse QueryYydToatlMsgDayStatisticalDataWithOptions(QueryYydToatlMsgDayStatisticalDataRequest request, QueryYydToatlMsgDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydToatlMsgDayStatisticalDataResponse>(DoROARequest("QueryYydToatlMsgDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydToatlMsgDayDatas", "json", req, runtime));
        }

        public async Task<QueryYydToatlMsgDayStatisticalDataResponse> QueryYydToatlMsgDayStatisticalDataWithOptionsAsync(QueryYydToatlMsgDayStatisticalDataRequest request, QueryYydToatlMsgDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydToatlMsgDayStatisticalDataResponse>(await DoROARequestAsync("QueryYydToatlMsgDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydToatlMsgDayDatas", "json", req, runtime));
        }

        public QueryYydToatlMsgMonthStatisticalDataResponse QueryYydToatlMsgMonthStatisticalData(QueryYydToatlMsgMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydToatlMsgMonthStatisticalDataHeaders headers = new QueryYydToatlMsgMonthStatisticalDataHeaders();
            return QueryYydToatlMsgMonthStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryYydToatlMsgMonthStatisticalDataResponse> QueryYydToatlMsgMonthStatisticalDataAsync(QueryYydToatlMsgMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydToatlMsgMonthStatisticalDataHeaders headers = new QueryYydToatlMsgMonthStatisticalDataHeaders();
            return await QueryYydToatlMsgMonthStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryYydToatlMsgMonthStatisticalDataResponse QueryYydToatlMsgMonthStatisticalDataWithOptions(QueryYydToatlMsgMonthStatisticalDataRequest request, QueryYydToatlMsgMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydToatlMsgMonthStatisticalDataResponse>(DoROARequest("QueryYydToatlMsgMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydToatlMsgMonthDatas", "json", req, runtime));
        }

        public async Task<QueryYydToatlMsgMonthStatisticalDataResponse> QueryYydToatlMsgMonthStatisticalDataWithOptionsAsync(QueryYydToatlMsgMonthStatisticalDataRequest request, QueryYydToatlMsgMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydToatlMsgMonthStatisticalDataResponse>(await DoROARequestAsync("QueryYydToatlMsgMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydToatlMsgMonthDatas", "json", req, runtime));
        }

        public QueryYydToatlMsgWeekStatisticalDataResponse QueryYydToatlMsgWeekStatisticalData(QueryYydToatlMsgWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydToatlMsgWeekStatisticalDataHeaders headers = new QueryYydToatlMsgWeekStatisticalDataHeaders();
            return QueryYydToatlMsgWeekStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryYydToatlMsgWeekStatisticalDataResponse> QueryYydToatlMsgWeekStatisticalDataAsync(QueryYydToatlMsgWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydToatlMsgWeekStatisticalDataHeaders headers = new QueryYydToatlMsgWeekStatisticalDataHeaders();
            return await QueryYydToatlMsgWeekStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryYydToatlMsgWeekStatisticalDataResponse QueryYydToatlMsgWeekStatisticalDataWithOptions(QueryYydToatlMsgWeekStatisticalDataRequest request, QueryYydToatlMsgWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydToatlMsgWeekStatisticalDataResponse>(DoROARequest("QueryYydToatlMsgWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydToatlMsgWeekDatas", "json", req, runtime));
        }

        public async Task<QueryYydToatlMsgWeekStatisticalDataResponse> QueryYydToatlMsgWeekStatisticalDataWithOptionsAsync(QueryYydToatlMsgWeekStatisticalDataRequest request, QueryYydToatlMsgWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydToatlMsgWeekStatisticalDataResponse>(await DoROARequestAsync("QueryYydToatlMsgWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydToatlMsgWeekDatas", "json", req, runtime));
        }

        public QueryYydTodoDayStatisticalDataResponse QueryYydTodoDayStatisticalData(QueryYydTodoDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTodoDayStatisticalDataHeaders headers = new QueryYydTodoDayStatisticalDataHeaders();
            return QueryYydTodoDayStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryYydTodoDayStatisticalDataResponse> QueryYydTodoDayStatisticalDataAsync(QueryYydTodoDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTodoDayStatisticalDataHeaders headers = new QueryYydTodoDayStatisticalDataHeaders();
            return await QueryYydTodoDayStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryYydTodoDayStatisticalDataResponse QueryYydTodoDayStatisticalDataWithOptions(QueryYydTodoDayStatisticalDataRequest request, QueryYydTodoDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydTodoDayStatisticalDataResponse>(DoROARequest("QueryYydTodoDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydTodoDayDatas", "json", req, runtime));
        }

        public async Task<QueryYydTodoDayStatisticalDataResponse> QueryYydTodoDayStatisticalDataWithOptionsAsync(QueryYydTodoDayStatisticalDataRequest request, QueryYydTodoDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydTodoDayStatisticalDataResponse>(await DoROARequestAsync("QueryYydTodoDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydTodoDayDatas", "json", req, runtime));
        }

        public QueryYydTodoMonthStatisticalDataResponse QueryYydTodoMonthStatisticalData(QueryYydTodoMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTodoMonthStatisticalDataHeaders headers = new QueryYydTodoMonthStatisticalDataHeaders();
            return QueryYydTodoMonthStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryYydTodoMonthStatisticalDataResponse> QueryYydTodoMonthStatisticalDataAsync(QueryYydTodoMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTodoMonthStatisticalDataHeaders headers = new QueryYydTodoMonthStatisticalDataHeaders();
            return await QueryYydTodoMonthStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryYydTodoMonthStatisticalDataResponse QueryYydTodoMonthStatisticalDataWithOptions(QueryYydTodoMonthStatisticalDataRequest request, QueryYydTodoMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydTodoMonthStatisticalDataResponse>(DoROARequest("QueryYydTodoMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydTodoMonthDatas", "json", req, runtime));
        }

        public async Task<QueryYydTodoMonthStatisticalDataResponse> QueryYydTodoMonthStatisticalDataWithOptionsAsync(QueryYydTodoMonthStatisticalDataRequest request, QueryYydTodoMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydTodoMonthStatisticalDataResponse>(await DoROARequestAsync("QueryYydTodoMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydTodoMonthDatas", "json", req, runtime));
        }

        public QueryYydTodoWeekStatisticalDataResponse QueryYydTodoWeekStatisticalData(QueryYydTodoWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTodoWeekStatisticalDataHeaders headers = new QueryYydTodoWeekStatisticalDataHeaders();
            return QueryYydTodoWeekStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryYydTodoWeekStatisticalDataResponse> QueryYydTodoWeekStatisticalDataAsync(QueryYydTodoWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTodoWeekStatisticalDataHeaders headers = new QueryYydTodoWeekStatisticalDataHeaders();
            return await QueryYydTodoWeekStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryYydTodoWeekStatisticalDataResponse QueryYydTodoWeekStatisticalDataWithOptions(QueryYydTodoWeekStatisticalDataRequest request, QueryYydTodoWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydTodoWeekStatisticalDataResponse>(DoROARequest("QueryYydTodoWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydTodoWeekDatas", "json", req, runtime));
        }

        public async Task<QueryYydTodoWeekStatisticalDataResponse> QueryYydTodoWeekStatisticalDataWithOptionsAsync(QueryYydTodoWeekStatisticalDataRequest request, QueryYydTodoWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydTodoWeekStatisticalDataResponse>(await DoROARequestAsync("QueryYydTodoWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydTodoWeekDatas", "json", req, runtime));
        }

        public QueryYydTotalDayStatisticalDataResponse QueryYydTotalDayStatisticalData(QueryYydTotalDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTotalDayStatisticalDataHeaders headers = new QueryYydTotalDayStatisticalDataHeaders();
            return QueryYydTotalDayStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryYydTotalDayStatisticalDataResponse> QueryYydTotalDayStatisticalDataAsync(QueryYydTotalDayStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTotalDayStatisticalDataHeaders headers = new QueryYydTotalDayStatisticalDataHeaders();
            return await QueryYydTotalDayStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryYydTotalDayStatisticalDataResponse QueryYydTotalDayStatisticalDataWithOptions(QueryYydTotalDayStatisticalDataRequest request, QueryYydTotalDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydTotalDayStatisticalDataResponse>(DoROARequest("QueryYydTotalDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydTotalDayDatas", "json", req, runtime));
        }

        public async Task<QueryYydTotalDayStatisticalDataResponse> QueryYydTotalDayStatisticalDataWithOptionsAsync(QueryYydTotalDayStatisticalDataRequest request, QueryYydTotalDayStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydTotalDayStatisticalDataResponse>(await DoROARequestAsync("QueryYydTotalDayStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydTotalDayDatas", "json", req, runtime));
        }

        public QueryYydTotalMonthStatisticalDataResponse QueryYydTotalMonthStatisticalData(QueryYydTotalMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTotalMonthStatisticalDataHeaders headers = new QueryYydTotalMonthStatisticalDataHeaders();
            return QueryYydTotalMonthStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryYydTotalMonthStatisticalDataResponse> QueryYydTotalMonthStatisticalDataAsync(QueryYydTotalMonthStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTotalMonthStatisticalDataHeaders headers = new QueryYydTotalMonthStatisticalDataHeaders();
            return await QueryYydTotalMonthStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryYydTotalMonthStatisticalDataResponse QueryYydTotalMonthStatisticalDataWithOptions(QueryYydTotalMonthStatisticalDataRequest request, QueryYydTotalMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydTotalMonthStatisticalDataResponse>(DoROARequest("QueryYydTotalMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydTotalMonthDatas", "json", req, runtime));
        }

        public async Task<QueryYydTotalMonthStatisticalDataResponse> QueryYydTotalMonthStatisticalDataWithOptionsAsync(QueryYydTotalMonthStatisticalDataRequest request, QueryYydTotalMonthStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydTotalMonthStatisticalDataResponse>(await DoROARequestAsync("QueryYydTotalMonthStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydTotalMonthDatas", "json", req, runtime));
        }

        public QueryYydTotalStdStatisticalDataResponse QueryYydTotalStdStatisticalData(QueryYydTotalStdStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTotalStdStatisticalDataHeaders headers = new QueryYydTotalStdStatisticalDataHeaders();
            return QueryYydTotalStdStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryYydTotalStdStatisticalDataResponse> QueryYydTotalStdStatisticalDataAsync(QueryYydTotalStdStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTotalStdStatisticalDataHeaders headers = new QueryYydTotalStdStatisticalDataHeaders();
            return await QueryYydTotalStdStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryYydTotalStdStatisticalDataResponse QueryYydTotalStdStatisticalDataWithOptions(QueryYydTotalStdStatisticalDataRequest request, QueryYydTotalStdStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydTotalStdStatisticalDataResponse>(DoROARequest("QueryYydTotalStdStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydTotalStdDatas", "json", req, runtime));
        }

        public async Task<QueryYydTotalStdStatisticalDataResponse> QueryYydTotalStdStatisticalDataWithOptionsAsync(QueryYydTotalStdStatisticalDataRequest request, QueryYydTotalStdStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydTotalStdStatisticalDataResponse>(await DoROARequestAsync("QueryYydTotalStdStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydTotalStdDatas", "json", req, runtime));
        }

        public QueryYydTotalWeekStatisticalDataResponse QueryYydTotalWeekStatisticalData(QueryYydTotalWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTotalWeekStatisticalDataHeaders headers = new QueryYydTotalWeekStatisticalDataHeaders();
            return QueryYydTotalWeekStatisticalDataWithOptions(request, headers, runtime);
        }

        public async Task<QueryYydTotalWeekStatisticalDataResponse> QueryYydTotalWeekStatisticalDataAsync(QueryYydTotalWeekStatisticalDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryYydTotalWeekStatisticalDataHeaders headers = new QueryYydTotalWeekStatisticalDataHeaders();
            return await QueryYydTotalWeekStatisticalDataWithOptionsAsync(request, headers, runtime);
        }

        public QueryYydTotalWeekStatisticalDataResponse QueryYydTotalWeekStatisticalDataWithOptions(QueryYydTotalWeekStatisticalDataRequest request, QueryYydTotalWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydTotalWeekStatisticalDataResponse>(DoROARequest("QueryYydTotalWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydTotalWeekDatas", "json", req, runtime));
        }

        public async Task<QueryYydTotalWeekStatisticalDataResponse> QueryYydTotalWeekStatisticalDataWithOptionsAsync(QueryYydTotalWeekStatisticalDataRequest request, QueryYydTotalWeekStatisticalDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDate))
            {
                query["statDate"] = request.StatDate;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryYydTotalWeekStatisticalDataResponse>(await DoROARequestAsync("QueryYydTotalWeekStatisticalData", "datacenter_1.0", "HTTP", "GET", "AK", "/v1.0/datacenter/yydTotalWeekDatas", "json", req, runtime));
        }

    }
}
