// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkhrm_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0
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


        public ECertQueryResponse ECertQuery(ECertQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ECertQueryHeaders headers = new ECertQueryHeaders();
            return ECertQueryWithOptions(request, headers, runtime);
        }

        public async Task<ECertQueryResponse> ECertQueryAsync(ECertQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ECertQueryHeaders headers = new ECertQueryHeaders();
            return await ECertQueryWithOptionsAsync(request, headers, runtime);
        }

        public ECertQueryResponse ECertQueryWithOptions(ECertQueryRequest request, ECertQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ECertQueryResponse>(DoROARequest("ECertQuery", "hrm_1.0", "HTTP", "GET", "AK", "/v1.0/hrm/eCerts", "json", req, runtime));
        }

        public async Task<ECertQueryResponse> ECertQueryWithOptionsAsync(ECertQueryRequest request, ECertQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ECertQueryResponse>(await DoROARequestAsync("ECertQuery", "hrm_1.0", "HTTP", "GET", "AK", "/v1.0/hrm/eCerts", "json", req, runtime));
        }

        public QueryJobRanksResponse QueryJobRanks(QueryJobRanksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryJobRanksHeaders headers = new QueryJobRanksHeaders();
            return QueryJobRanksWithOptions(request, headers, runtime);
        }

        public async Task<QueryJobRanksResponse> QueryJobRanksAsync(QueryJobRanksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryJobRanksHeaders headers = new QueryJobRanksHeaders();
            return await QueryJobRanksWithOptionsAsync(request, headers, runtime);
        }

        public QueryJobRanksResponse QueryJobRanksWithOptions(QueryJobRanksRequest request, QueryJobRanksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RankCategoryId))
            {
                query["rankCategoryId"] = request.RankCategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RankCode))
            {
                query["rankCode"] = request.RankCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RankName))
            {
                query["rankName"] = request.RankName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
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
            return TeaModel.ToObject<QueryJobRanksResponse>(DoROARequest("QueryJobRanks", "hrm_1.0", "HTTP", "GET", "AK", "/v1.0/hrm/jobRanks", "json", req, runtime));
        }

        public async Task<QueryJobRanksResponse> QueryJobRanksWithOptionsAsync(QueryJobRanksRequest request, QueryJobRanksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RankCategoryId))
            {
                query["rankCategoryId"] = request.RankCategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RankCode))
            {
                query["rankCode"] = request.RankCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RankName))
            {
                query["rankName"] = request.RankName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
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
            return TeaModel.ToObject<QueryJobRanksResponse>(await DoROARequestAsync("QueryJobRanks", "hrm_1.0", "HTTP", "GET", "AK", "/v1.0/hrm/jobRanks", "json", req, runtime));
        }

        public QueryJobsResponse QueryJobs(QueryJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryJobsHeaders headers = new QueryJobsHeaders();
            return QueryJobsWithOptions(request, headers, runtime);
        }

        public async Task<QueryJobsResponse> QueryJobsAsync(QueryJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryJobsHeaders headers = new QueryJobsHeaders();
            return await QueryJobsWithOptionsAsync(request, headers, runtime);
        }

        public QueryJobsResponse QueryJobsWithOptions(QueryJobsRequest request, QueryJobsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobName))
            {
                query["jobName"] = request.JobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
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
            return TeaModel.ToObject<QueryJobsResponse>(DoROARequest("QueryJobs", "hrm_1.0", "HTTP", "GET", "AK", "/v1.0/hrm/jobs", "json", req, runtime));
        }

        public async Task<QueryJobsResponse> QueryJobsWithOptionsAsync(QueryJobsRequest request, QueryJobsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobName))
            {
                query["jobName"] = request.JobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
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
            return TeaModel.ToObject<QueryJobsResponse>(await DoROARequestAsync("QueryJobs", "hrm_1.0", "HTTP", "GET", "AK", "/v1.0/hrm/jobs", "json", req, runtime));
        }

        public QueryCustomEntryProcessesResponse QueryCustomEntryProcesses(QueryCustomEntryProcessesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCustomEntryProcessesHeaders headers = new QueryCustomEntryProcessesHeaders();
            return QueryCustomEntryProcessesWithOptions(request, headers, runtime);
        }

        public async Task<QueryCustomEntryProcessesResponse> QueryCustomEntryProcessesAsync(QueryCustomEntryProcessesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCustomEntryProcessesHeaders headers = new QueryCustomEntryProcessesHeaders();
            return await QueryCustomEntryProcessesWithOptionsAsync(request, headers, runtime);
        }

        public QueryCustomEntryProcessesResponse QueryCustomEntryProcessesWithOptions(QueryCustomEntryProcessesRequest request, QueryCustomEntryProcessesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateUserId))
            {
                query["operateUserId"] = request.OperateUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
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
            return TeaModel.ToObject<QueryCustomEntryProcessesResponse>(DoROARequest("QueryCustomEntryProcesses", "hrm_1.0", "HTTP", "GET", "AK", "/v1.0/hrm/customEntryProcesses", "json", req, runtime));
        }

        public async Task<QueryCustomEntryProcessesResponse> QueryCustomEntryProcessesWithOptionsAsync(QueryCustomEntryProcessesRequest request, QueryCustomEntryProcessesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateUserId))
            {
                query["operateUserId"] = request.OperateUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
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
            return TeaModel.ToObject<QueryCustomEntryProcessesResponse>(await DoROARequestAsync("QueryCustomEntryProcesses", "hrm_1.0", "HTTP", "GET", "AK", "/v1.0/hrm/customEntryProcesses", "json", req, runtime));
        }

        public AddHrmPreentryResponse AddHrmPreentry(AddHrmPreentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddHrmPreentryHeaders headers = new AddHrmPreentryHeaders();
            return AddHrmPreentryWithOptions(request, headers, runtime);
        }

        public async Task<AddHrmPreentryResponse> AddHrmPreentryAsync(AddHrmPreentryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddHrmPreentryHeaders headers = new AddHrmPreentryHeaders();
            return await AddHrmPreentryWithOptionsAsync(request, headers, runtime);
        }

        public AddHrmPreentryResponse AddHrmPreentryWithOptions(AddHrmPreentryRequest request, AddHrmPreentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreEntryTime))
            {
                body["preEntryTime"] = request.PreEntryTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Groups))
            {
                body["groups"] = request.Groups;
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
            return TeaModel.ToObject<AddHrmPreentryResponse>(DoROARequest("AddHrmPreentry", "hrm_1.0", "HTTP", "POST", "AK", "/v1.0/hrm/preentries", "json", req, runtime));
        }

        public async Task<AddHrmPreentryResponse> AddHrmPreentryWithOptionsAsync(AddHrmPreentryRequest request, AddHrmPreentryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreEntryTime))
            {
                body["preEntryTime"] = request.PreEntryTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Groups))
            {
                body["groups"] = request.Groups;
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
            return TeaModel.ToObject<AddHrmPreentryResponse>(await DoROARequestAsync("AddHrmPreentry", "hrm_1.0", "HTTP", "POST", "AK", "/v1.0/hrm/preentries", "json", req, runtime));
        }

        public QueryPositionsResponse QueryPositions(QueryPositionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPositionsHeaders headers = new QueryPositionsHeaders();
            return QueryPositionsWithOptions(request, headers, runtime);
        }

        public async Task<QueryPositionsResponse> QueryPositionsAsync(QueryPositionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPositionsHeaders headers = new QueryPositionsHeaders();
            return await QueryPositionsWithOptionsAsync(request, headers, runtime);
        }

        public QueryPositionsResponse QueryPositionsWithOptions(QueryPositionsRequest request, QueryPositionsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PositionName))
            {
                body["positionName"] = request.PositionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InCategoryIds))
            {
                body["inCategoryIds"] = request.InCategoryIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InPositionIds))
            {
                body["inPositionIds"] = request.InPositionIds;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<QueryPositionsResponse>(DoROARequest("QueryPositions", "hrm_1.0", "HTTP", "POST", "AK", "/v1.0/hrm/positions/query", "json", req, runtime));
        }

        public async Task<QueryPositionsResponse> QueryPositionsWithOptionsAsync(QueryPositionsRequest request, QueryPositionsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PositionName))
            {
                body["positionName"] = request.PositionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InCategoryIds))
            {
                body["inCategoryIds"] = request.InCategoryIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InPositionIds))
            {
                body["inPositionIds"] = request.InPositionIds;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<QueryPositionsResponse>(await DoROARequestAsync("QueryPositions", "hrm_1.0", "HTTP", "POST", "AK", "/v1.0/hrm/positions/query", "json", req, runtime));
        }

    }
}
