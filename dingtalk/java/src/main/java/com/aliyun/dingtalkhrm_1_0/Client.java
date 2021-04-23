// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkhrm_1_0.models.*;
import com.aliyun.teautil.*;
import com.aliyun.teautil.models.*;
import com.aliyun.teaopenapi.*;
import com.aliyun.teaopenapi.models.*;
import com.aliyun.openapiutil.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(Config config) throws Exception {
        super(config);
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    public ECertQueryResponse eCertQuery(ECertQueryRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ECertQueryHeaders headers = new ECertQueryHeaders();
        return this.eCertQueryWithOptions(request, headers, runtime);
    }

    public ECertQueryResponse eCertQueryWithOptions(ECertQueryRequest request, ECertQueryHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("ECertQuery", "hrm_1.0", "HTTP", "GET", "AK", "/v1.0/hrm/eCerts", "json", req, runtime), new ECertQueryResponse());
    }

    public QueryCustomEntryProcessesResponse queryCustomEntryProcesses(QueryCustomEntryProcessesRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryCustomEntryProcessesHeaders headers = new QueryCustomEntryProcessesHeaders();
        return this.queryCustomEntryProcessesWithOptions(request, headers, runtime);
    }

    public QueryCustomEntryProcessesResponse queryCustomEntryProcessesWithOptions(QueryCustomEntryProcessesRequest request, QueryCustomEntryProcessesHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operateUserId)) {
            query.put("operateUserId", request.operateUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryCustomEntryProcesses", "hrm_1.0", "HTTP", "GET", "AK", "/v1.0/hrm/customEntryProcesses", "json", req, runtime), new QueryCustomEntryProcessesResponse());
    }

    public AddHrmPreentryResponse addHrmPreentry(AddHrmPreentryRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AddHrmPreentryHeaders headers = new AddHrmPreentryHeaders();
        return this.addHrmPreentryWithOptions(request, headers, runtime);
    }

    public AddHrmPreentryResponse addHrmPreentryWithOptions(AddHrmPreentryRequest request, AddHrmPreentryHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.preEntryTime)) {
            body.put("preEntryTime", request.preEntryTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mobile)) {
            body.put("mobile", request.mobile);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.agentId)) {
            body.put("agentId", request.agentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groups)) {
            body.put("groups", request.groups);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("AddHrmPreentry", "hrm_1.0", "HTTP", "POST", "AK", "/v1.0/hrm/preentries", "json", req, runtime), new AddHrmPreentryResponse());
    }
}
