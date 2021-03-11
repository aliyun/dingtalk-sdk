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

    }
}
