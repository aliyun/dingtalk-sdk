// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkbench_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkworkbench_1_0.models.*;
import com.aliyun.teautil.*;
import com.aliyun.teautil.models.*;
import com.aliyun.teaopenapi.*;
import com.aliyun.teaopenapi.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(Config config) throws Exception {
        super(config);
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    public QueryShortcutScopesResponse queryShortcutScopes(String shortcutKey) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryShortcutScopesHeaders headers = new QueryShortcutScopesHeaders();
        return this.queryShortcutScopesWithOptions(shortcutKey, headers, runtime);
    }

    public QueryShortcutScopesResponse queryShortcutScopesWithOptions(String shortcutKey, QueryShortcutScopesHeaders headers, RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("QueryShortcutScopes", "workbench_1.0", "HTTP", "GET", "AK", "/v1.0/workbench/shortcuts/" + shortcutKey + "/scopes", "json", req, runtime), new QueryShortcutScopesResponse());
    }

    public QueryComponentScopesResponse queryComponentScopes(String componentId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryComponentScopesHeaders headers = new QueryComponentScopesHeaders();
        return this.queryComponentScopesWithOptions(componentId, headers, runtime);
    }

    public QueryComponentScopesResponse queryComponentScopesWithOptions(String componentId, QueryComponentScopesHeaders headers, RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("QueryComponentScopes", "workbench_1.0", "HTTP", "GET", "AK", "/v1.0/workbench/components/" + componentId + "/scopes", "json", req, runtime), new QueryComponentScopesResponse());
    }
}
