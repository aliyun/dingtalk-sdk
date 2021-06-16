// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkworkbench_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkworkbench_1_0
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


        public ListWorkBenchGroupResponse ListWorkBenchGroup(ListWorkBenchGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListWorkBenchGroupHeaders headers = new ListWorkBenchGroupHeaders();
            return ListWorkBenchGroupWithOptions(request, headers, runtime);
        }

        public async Task<ListWorkBenchGroupResponse> ListWorkBenchGroupAsync(ListWorkBenchGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListWorkBenchGroupHeaders headers = new ListWorkBenchGroupHeaders();
            return await ListWorkBenchGroupWithOptionsAsync(request, headers, runtime);
        }

        public ListWorkBenchGroupResponse ListWorkBenchGroupWithOptions(ListWorkBenchGroupRequest request, ListWorkBenchGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUnionId))
            {
                query["opUnionId"] = request.OpUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcologicalCorpId))
            {
                query["ecologicalCorpId"] = request.EcologicalCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                query["groupType"] = request.GroupType;
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
            return TeaModel.ToObject<ListWorkBenchGroupResponse>(DoROARequest("ListWorkBenchGroup", "workbench_1.0", "HTTP", "GET", "AK", "/v1.0/workbench/groups", "json", req, runtime));
        }

        public async Task<ListWorkBenchGroupResponse> ListWorkBenchGroupWithOptionsAsync(ListWorkBenchGroupRequest request, ListWorkBenchGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUnionId))
            {
                query["opUnionId"] = request.OpUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcologicalCorpId))
            {
                query["ecologicalCorpId"] = request.EcologicalCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                query["groupType"] = request.GroupType;
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
            return TeaModel.ToObject<ListWorkBenchGroupResponse>(await DoROARequestAsync("ListWorkBenchGroup", "workbench_1.0", "HTTP", "GET", "AK", "/v1.0/workbench/groups", "json", req, runtime));
        }

        public QueryComponentScopesResponse QueryComponentScopes(string componentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryComponentScopesHeaders headers = new QueryComponentScopesHeaders();
            return QueryComponentScopesWithOptions(componentId, headers, runtime);
        }

        public async Task<QueryComponentScopesResponse> QueryComponentScopesAsync(string componentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryComponentScopesHeaders headers = new QueryComponentScopesHeaders();
            return await QueryComponentScopesWithOptionsAsync(componentId, headers, runtime);
        }

        public QueryComponentScopesResponse QueryComponentScopesWithOptions(string componentId, QueryComponentScopesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<QueryComponentScopesResponse>(DoROARequest("QueryComponentScopes", "workbench_1.0", "HTTP", "GET", "AK", "/v1.0/workbench/components/" + componentId + "/scopes", "json", req, runtime));
        }

        public async Task<QueryComponentScopesResponse> QueryComponentScopesWithOptionsAsync(string componentId, QueryComponentScopesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<QueryComponentScopesResponse>(await DoROARequestAsync("QueryComponentScopes", "workbench_1.0", "HTTP", "GET", "AK", "/v1.0/workbench/components/" + componentId + "/scopes", "json", req, runtime));
        }

        public QueryShortcutScopesResponse QueryShortcutScopes(string shortcutKey)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryShortcutScopesHeaders headers = new QueryShortcutScopesHeaders();
            return QueryShortcutScopesWithOptions(shortcutKey, headers, runtime);
        }

        public async Task<QueryShortcutScopesResponse> QueryShortcutScopesAsync(string shortcutKey)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryShortcutScopesHeaders headers = new QueryShortcutScopesHeaders();
            return await QueryShortcutScopesWithOptionsAsync(shortcutKey, headers, runtime);
        }

        public QueryShortcutScopesResponse QueryShortcutScopesWithOptions(string shortcutKey, QueryShortcutScopesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<QueryShortcutScopesResponse>(DoROARequest("QueryShortcutScopes", "workbench_1.0", "HTTP", "GET", "AK", "/v1.0/workbench/shortcuts/" + shortcutKey + "/scopes", "json", req, runtime));
        }

        public async Task<QueryShortcutScopesResponse> QueryShortcutScopesWithOptionsAsync(string shortcutKey, QueryShortcutScopesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<QueryShortcutScopesResponse>(await DoROARequestAsync("QueryShortcutScopes", "workbench_1.0", "HTTP", "GET", "AK", "/v1.0/workbench/shortcuts/" + shortcutKey + "/scopes", "json", req, runtime));
        }

        public GetPluginPermissionPointResponse GetPluginPermissionPoint(GetPluginPermissionPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPluginPermissionPointHeaders headers = new GetPluginPermissionPointHeaders();
            return GetPluginPermissionPointWithOptions(request, headers, runtime);
        }

        public async Task<GetPluginPermissionPointResponse> GetPluginPermissionPointAsync(GetPluginPermissionPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPluginPermissionPointHeaders headers = new GetPluginPermissionPointHeaders();
            return await GetPluginPermissionPointWithOptionsAsync(request, headers, runtime);
        }

        public GetPluginPermissionPointResponse GetPluginPermissionPointWithOptions(GetPluginPermissionPointRequest request, GetPluginPermissionPointHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                query["miniAppId"] = request.MiniAppId;
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
            return TeaModel.ToObject<GetPluginPermissionPointResponse>(DoROARequest("GetPluginPermissionPoint", "workbench_1.0", "HTTP", "GET", "AK", "/v1.0/workbench/plugins/permissions", "json", req, runtime));
        }

        public async Task<GetPluginPermissionPointResponse> GetPluginPermissionPointWithOptionsAsync(GetPluginPermissionPointRequest request, GetPluginPermissionPointHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                query["miniAppId"] = request.MiniAppId;
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
            return TeaModel.ToObject<GetPluginPermissionPointResponse>(await DoROARequestAsync("GetPluginPermissionPoint", "workbench_1.0", "HTTP", "GET", "AK", "/v1.0/workbench/plugins/permissions", "json", req, runtime));
        }

        public GetPluginRuleCheckInfoResponse GetPluginRuleCheckInfo(GetPluginRuleCheckInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPluginRuleCheckInfoHeaders headers = new GetPluginRuleCheckInfoHeaders();
            return GetPluginRuleCheckInfoWithOptions(request, headers, runtime);
        }

        public async Task<GetPluginRuleCheckInfoResponse> GetPluginRuleCheckInfoAsync(GetPluginRuleCheckInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPluginRuleCheckInfoHeaders headers = new GetPluginRuleCheckInfoHeaders();
            return await GetPluginRuleCheckInfoWithOptionsAsync(request, headers, runtime);
        }

        public GetPluginRuleCheckInfoResponse GetPluginRuleCheckInfoWithOptions(GetPluginRuleCheckInfoRequest request, GetPluginRuleCheckInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                query["miniAppId"] = request.MiniAppId;
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
            return TeaModel.ToObject<GetPluginRuleCheckInfoResponse>(DoROARequest("GetPluginRuleCheckInfo", "workbench_1.0", "HTTP", "GET", "AK", "/v1.0/workbench/plugins/validationRules", "json", req, runtime));
        }

        public async Task<GetPluginRuleCheckInfoResponse> GetPluginRuleCheckInfoWithOptionsAsync(GetPluginRuleCheckInfoRequest request, GetPluginRuleCheckInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                query["miniAppId"] = request.MiniAppId;
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
            return TeaModel.ToObject<GetPluginRuleCheckInfoResponse>(await DoROARequestAsync("GetPluginRuleCheckInfo", "workbench_1.0", "HTTP", "GET", "AK", "/v1.0/workbench/plugins/validationRules", "json", req, runtime));
        }

        public UpdateDingPortalPageScopeResponse UpdateDingPortalPageScope(string pageUuid, string appUuid, UpdateDingPortalPageScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateDingPortalPageScopeHeaders headers = new UpdateDingPortalPageScopeHeaders();
            return UpdateDingPortalPageScopeWithOptions(pageUuid, appUuid, request, headers, runtime);
        }

        public async Task<UpdateDingPortalPageScopeResponse> UpdateDingPortalPageScopeAsync(string pageUuid, string appUuid, UpdateDingPortalPageScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateDingPortalPageScopeHeaders headers = new UpdateDingPortalPageScopeHeaders();
            return await UpdateDingPortalPageScopeWithOptionsAsync(pageUuid, appUuid, request, headers, runtime);
        }

        public UpdateDingPortalPageScopeResponse UpdateDingPortalPageScopeWithOptions(string pageUuid, string appUuid, UpdateDingPortalPageScopeRequest request, UpdateDingPortalPageScopeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Userids))
            {
                body["userids"] = request.Userids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptIds))
            {
                body["deptIds"] = request.DeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleIds))
            {
                body["roleIds"] = request.RoleIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllVisible))
            {
                body["allVisible"] = request.AllVisible;
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
            return TeaModel.ToObject<UpdateDingPortalPageScopeResponse>(DoROARequest("UpdateDingPortalPageScope", "workbench_1.0", "HTTP", "PUT", "AK", "/v1.0/workbench/dingPortals/" + appUuid + "/pageScopes/" + pageUuid, "none", req, runtime));
        }

        public async Task<UpdateDingPortalPageScopeResponse> UpdateDingPortalPageScopeWithOptionsAsync(string pageUuid, string appUuid, UpdateDingPortalPageScopeRequest request, UpdateDingPortalPageScopeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Userids))
            {
                body["userids"] = request.Userids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptIds))
            {
                body["deptIds"] = request.DeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleIds))
            {
                body["roleIds"] = request.RoleIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllVisible))
            {
                body["allVisible"] = request.AllVisible;
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
            return TeaModel.ToObject<UpdateDingPortalPageScopeResponse>(await DoROARequestAsync("UpdateDingPortalPageScope", "workbench_1.0", "HTTP", "PUT", "AK", "/v1.0/workbench/dingPortals/" + appUuid + "/pageScopes/" + pageUuid, "none", req, runtime));
        }

        public GetDingPortalDetailResponse GetDingPortalDetail(string appUuid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDingPortalDetailHeaders headers = new GetDingPortalDetailHeaders();
            return GetDingPortalDetailWithOptions(appUuid, headers, runtime);
        }

        public async Task<GetDingPortalDetailResponse> GetDingPortalDetailAsync(string appUuid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDingPortalDetailHeaders headers = new GetDingPortalDetailHeaders();
            return await GetDingPortalDetailWithOptionsAsync(appUuid, headers, runtime);
        }

        public GetDingPortalDetailResponse GetDingPortalDetailWithOptions(string appUuid, GetDingPortalDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<GetDingPortalDetailResponse>(DoROARequest("GetDingPortalDetail", "workbench_1.0", "HTTP", "GET", "AK", "/v1.0/workbench/dingPortals/" + appUuid, "json", req, runtime));
        }

        public async Task<GetDingPortalDetailResponse> GetDingPortalDetailWithOptionsAsync(string appUuid, GetDingPortalDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<GetDingPortalDetailResponse>(await DoROARequestAsync("GetDingPortalDetail", "workbench_1.0", "HTTP", "GET", "AK", "/v1.0/workbench/dingPortals/" + appUuid, "json", req, runtime));
        }

    }
}
