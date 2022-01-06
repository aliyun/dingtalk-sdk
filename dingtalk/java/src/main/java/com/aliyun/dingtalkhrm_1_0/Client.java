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

    public MasterDataSaveResponse masterDataSave(MasterDataSaveRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        MasterDataSaveHeaders headers = new MasterDataSaveHeaders();
        return this.masterDataSaveWithOptions(request, headers, runtime);
    }

    public MasterDataSaveResponse masterDataSaveWithOptions(MasterDataSaveRequest request, MasterDataSaveHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.tenantId)) {
            query.put("tenantId", request.tenantId);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.teautil.Common.toArray(request.body))
        ));
        return TeaModel.toModel(this.doROARequest("MasterDataSave", "hrm_1.0", "HTTP", "POST", "AK", "/v1.0/hrm/masters/datas/save", "json", req, runtime), new MasterDataSaveResponse());
    }

    public QueryJobRanksResponse queryJobRanks(QueryJobRanksRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryJobRanksHeaders headers = new QueryJobRanksHeaders();
        return this.queryJobRanksWithOptions(request, headers, runtime);
    }

    public QueryJobRanksResponse queryJobRanksWithOptions(QueryJobRanksRequest request, QueryJobRanksHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.rankCategoryId)) {
            query.put("rankCategoryId", request.rankCategoryId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.rankCode)) {
            query.put("rankCode", request.rankCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.rankName)) {
            query.put("rankName", request.rankName);
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
        return TeaModel.toModel(this.doROARequest("QueryJobRanks", "hrm_1.0", "HTTP", "GET", "AK", "/v1.0/hrm/jobRanks", "json", req, runtime), new QueryJobRanksResponse());
    }

    public QueryJobsResponse queryJobs(QueryJobsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryJobsHeaders headers = new QueryJobsHeaders();
        return this.queryJobsWithOptions(request, headers, runtime);
    }

    public QueryJobsResponse queryJobsWithOptions(QueryJobsRequest request, QueryJobsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.jobName)) {
            query.put("jobName", request.jobName);
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
        return TeaModel.toModel(this.doROARequest("QueryJobs", "hrm_1.0", "HTTP", "GET", "AK", "/v1.0/hrm/jobs", "json", req, runtime), new QueryJobsResponse());
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

    public QueryPositionsResponse queryPositions(QueryPositionsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryPositionsHeaders headers = new QueryPositionsHeaders();
        return this.queryPositionsWithOptions(request, headers, runtime);
    }

    public QueryPositionsResponse queryPositionsWithOptions(QueryPositionsRequest request, QueryPositionsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.positionName)) {
            body.put("positionName", request.positionName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.inCategoryIds)) {
            body.put("inCategoryIds", request.inCategoryIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.inPositionIds)) {
            body.put("inPositionIds", request.inPositionIds);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("QueryPositions", "hrm_1.0", "HTTP", "POST", "AK", "/v1.0/hrm/positions/query", "json", req, runtime), new QueryPositionsResponse());
    }

    public MasterDataQueryResponse masterDataQuery(MasterDataQueryRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        MasterDataQueryHeaders headers = new MasterDataQueryHeaders();
        return this.masterDataQueryWithOptions(request, headers, runtime);
    }

    public MasterDataQueryResponse masterDataQueryWithOptions(MasterDataQueryRequest request, MasterDataQueryHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.scopeCode)) {
            body.put("scopeCode", request.scopeCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.viewEntityCode)) {
            body.put("viewEntityCode", request.viewEntityCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tenantId)) {
            body.put("tenantId", request.tenantId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizUK)) {
            body.put("bizUK", request.bizUK);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.relationIds)) {
            body.put("relationIds", request.relationIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.optUserId)) {
            body.put("optUserId", request.optUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            body.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            body.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.queryParams)) {
            body.put("queryParams", request.queryParams);
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
        return TeaModel.toModel(this.doROARequest("MasterDataQuery", "hrm_1.0", "HTTP", "POST", "AK", "/v1.0/hrm/masters/datas/query", "json", req, runtime), new MasterDataQueryResponse());
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
