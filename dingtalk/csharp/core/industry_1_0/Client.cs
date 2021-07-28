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
            };
            return TeaModel.ToObject<QueryUserInfoResponse>(DoROARequest("QueryUserInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/users/" + userId, "json", req, runtime));
        }

        public async Task<QueryUserInfoResponse> QueryUserInfoWithOptionsAsync(string userId, QueryUserInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            return TeaModel.ToObject<QueryUserInfoResponse>(await DoROARequestAsync("QueryUserInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/users/" + userId, "json", req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
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
            return TeaModel.ToObject<QueryAllMemberByDeptResponse>(DoROARequest("QueryAllMemberByDept", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/departments/" + deptId + "/members", "json", req, runtime));
        }

        public async Task<QueryAllMemberByDeptResponse> QueryAllMemberByDeptWithOptionsAsync(string deptId, QueryAllMemberByDeptRequest request, QueryAllMemberByDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
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
            return TeaModel.ToObject<QueryAllMemberByGroupResponse>(DoROARequest("QueryAllMemberByGroup", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/groups/" + groupId + "/members", "json", req, runtime));
        }

        public async Task<QueryAllMemberByGroupResponse> QueryAllMemberByGroupWithOptionsAsync(string groupId, QueryAllMemberByGroupRequest request, QueryAllMemberByGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
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
            return TeaModel.ToObject<QueryAllMemberByGroupResponse>(await DoROARequestAsync("QueryAllMemberByGroup", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/groups/" + groupId + "/members", "json", req, runtime));
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
            };
            return TeaModel.ToObject<QueryUserRolesResponse>(DoROARequest("QueryUserRoles", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/users/" + userId + "/roles", "json", req, runtime));
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<QueryUserRolesResponse>(await DoROARequestAsync("QueryUserRoles", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/users/" + userId + "/roles", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
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
            return TeaModel.ToObject<QueryAllGroupResponse>(DoROARequest("QueryAllGroup", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/groups", "json", req, runtime));
        }

        public async Task<QueryAllGroupResponse> QueryAllGroupWithOptionsAsync(QueryAllGroupRequest request, QueryAllGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
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
            return TeaModel.ToObject<QueryAllGroupsInDeptResponse>(DoROARequest("QueryAllGroupsInDept", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/departments/" + deptId + "/groups", "json", req, runtime));
        }

        public async Task<QueryAllGroupsInDeptResponse> QueryAllGroupsInDeptWithOptionsAsync(string deptId, QueryAllGroupsInDeptRequest request, QueryAllGroupsInDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
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
            return TeaModel.ToObject<QueryAllGroupsInDeptResponse>(await DoROARequestAsync("QueryAllGroupsInDept", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/departments/" + deptId + "/groups", "json", req, runtime));
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
            return TeaModel.ToObject<QueryBizOptLogResponse>(DoROARequest("QueryBizOptLog", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/bizOptLogs", "json", req, runtime));
        }

        public async Task<QueryBizOptLogResponse> QueryBizOptLogWithOptionsAsync(QueryBizOptLogRequest request, QueryBizOptLogHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<QueryBizOptLogResponse>(await DoROARequestAsync("QueryBizOptLog", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/bizOptLogs", "json", req, runtime));
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<QueryUserProbCodeDictionaryResponse>(await DoROARequestAsync("QueryUserProbCodeDictionary", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/userProbCodes", "json", req, runtime));
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<QueryJobStatusCodeDictionaryResponse>(await DoROARequestAsync("QueryJobStatusCodeDictionary", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/jobStatusCodes", "json", req, runtime));
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
            };
            return TeaModel.ToObject<QueryDepartmentInfoResponse>(DoROARequest("QueryDepartmentInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/departments/" + deptId, "json", req, runtime));
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<QueryDepartmentInfoResponse>(await DoROARequestAsync("QueryDepartmentInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/departments/" + deptId, "json", req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobCode))
            {
                body["jobCode"] = request.JobCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserProbCode))
            {
                body["userProbCode"] = request.UserProbCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobStatusCode))
            {
                body["jobStatusCode"] = request.JobStatusCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comments))
            {
                body["comments"] = request.Comments;
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
            return TeaModel.ToObject<UpdateUserExtendInfoResponse>(DoROARequest("UpdateUserExtendInfo", "industry_1.0", "HTTP", "PUT", "AK", "/v1.0/industry/medicals/users/" + userId + "/extInfos", "none", req, runtime));
        }

        public async Task<UpdateUserExtendInfoResponse> UpdateUserExtendInfoWithOptionsAsync(string userId, UpdateUserExtendInfoRequest request, UpdateUserExtendInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobCode))
            {
                body["jobCode"] = request.JobCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserProbCode))
            {
                body["userProbCode"] = request.UserProbCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobStatusCode))
            {
                body["jobStatusCode"] = request.JobStatusCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comments))
            {
                body["comments"] = request.Comments;
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
            return TeaModel.ToObject<UpdateUserExtendInfoResponse>(await DoROARequestAsync("UpdateUserExtendInfo", "industry_1.0", "HTTP", "PUT", "AK", "/v1.0/industry/medicals/users/" + userId + "/extInfos", "none", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
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
            return TeaModel.ToObject<QueryAllDoctorsResponse>(DoROARequest("QueryAllDoctors", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/doctors", "json", req, runtime));
        }

        public async Task<QueryAllDoctorsResponse> QueryAllDoctorsWithOptionsAsync(QueryAllDoctorsRequest request, QueryAllDoctorsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
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
            return TeaModel.ToObject<QueryAllDoctorsResponse>(await DoROARequestAsync("QueryAllDoctors", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/doctors", "json", req, runtime));
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
            };
            return TeaModel.ToObject<QueryUserExtInfoResponse>(DoROARequest("QueryUserExtInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/users/" + userId + "/extInfos", "json", req, runtime));
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<QueryUserExtInfoResponse>(await DoROARequestAsync("QueryUserExtInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/users/" + userId + "/extInfos", "json", req, runtime));
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<QueryJobCodeDictionaryResponse>(await DoROARequestAsync("QueryJobCodeDictionary", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/jobCodes", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
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
            return TeaModel.ToObject<QueryAllDepartmentResponse>(DoROARequest("QueryAllDepartment", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/departments", "json", req, runtime));
        }

        public async Task<QueryAllDepartmentResponse> QueryAllDepartmentWithOptionsAsync(QueryAllDepartmentRequest request, QueryAllDepartmentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
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
            return TeaModel.ToObject<QueryAllDepartmentResponse>(await DoROARequestAsync("QueryAllDepartment", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/departments", "json", req, runtime));
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
            };
            return TeaModel.ToObject<QueryGroupInfoResponse>(DoROARequest("QueryGroupInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/groups/" + groupId, "json", req, runtime));
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<QueryGroupInfoResponse>(await DoROARequestAsync("QueryGroupInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/groups/" + groupId, "json", req, runtime));
        }

    }
}
