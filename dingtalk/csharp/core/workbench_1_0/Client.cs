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
