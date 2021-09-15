// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkconnector_1_0.models.*;
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


    public PullDataByPageResponse pullDataByPage(PullDataByPageRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        PullDataByPageHeaders headers = new PullDataByPageHeaders();
        return this.pullDataByPageWithOptions(request, headers, runtime);
    }

    public PullDataByPageResponse pullDataByPageWithOptions(PullDataByPageRequest request, PullDataByPageHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dataModelId)) {
            query.put("dataModelId", request.dataModelId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.datetimeFilterField)) {
            query.put("datetimeFilterField", request.datetimeFilterField);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.minDatetime)) {
            query.put("minDatetime", request.minDatetime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxDatetime)) {
            query.put("maxDatetime", request.maxDatetime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appId)) {
            query.put("appId", request.appId);
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
        return TeaModel.toModel(this.doROARequest("PullDataByPage", "connector_1.0", "HTTP", "GET", "AK", "/v1.0/connector/data", "json", req, runtime), new PullDataByPageResponse());
    }

    public PullDataByPkResponse pullDataByPk(String dataModelId, PullDataByPkRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        PullDataByPkHeaders headers = new PullDataByPkHeaders();
        return this.pullDataByPkWithOptions(dataModelId, request, headers, runtime);
    }

    public PullDataByPkResponse pullDataByPkWithOptions(String dataModelId, PullDataByPkRequest request, PullDataByPkHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        dataModelId = com.aliyun.openapiutil.Client.getEncodeParam(dataModelId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.primaryKey)) {
            query.put("primaryKey", request.primaryKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appId)) {
            query.put("appId", request.appId);
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
        return TeaModel.toModel(this.doROARequest("PullDataByPk", "connector_1.0", "HTTP", "GET", "AK", "/v1.0/connector/data/" + dataModelId + "", "json", req, runtime), new PullDataByPkResponse());
    }

    public SyncDataResponse syncData(SyncDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        SyncDataHeaders headers = new SyncDataHeaders();
        return this.syncDataWithOptions(request, headers, runtime);
    }

    public SyncDataResponse syncDataWithOptions(SyncDataRequest request, SyncDataHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.triggerDataList)) {
            body.put("triggerDataList", request.triggerDataList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appId)) {
            body.put("appId", request.appId);
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
        return TeaModel.toModel(this.doROARequest("SyncData", "connector_1.0", "HTTP", "POST", "AK", "/v1.0/connector/triggers/data/sync", "json", req, runtime), new SyncDataResponse());
    }
}
