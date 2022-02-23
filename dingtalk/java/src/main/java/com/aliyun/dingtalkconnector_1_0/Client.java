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


    public CreateActionResponse createAction(CreateActionRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateActionHeaders headers = new CreateActionHeaders();
        return this.createActionWithOptions(request, headers, runtime);
    }

    public CreateActionResponse createActionWithOptions(CreateActionRequest request, CreateActionHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.actionInfo)) {
            body.put("actionInfo", request.actionInfo);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateAction", "connector_1.0", "HTTP", "POST", "AK", "/v1.0/connector/actions", "json", req, runtime), new CreateActionResponse());
    }

    public CreateConnectorResponse createConnector(CreateConnectorRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateConnectorHeaders headers = new CreateConnectorHeaders();
        return this.createConnectorWithOptions(request, headers, runtime);
    }

    public CreateConnectorResponse createConnectorWithOptions(CreateConnectorRequest request, CreateConnectorHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.connectorInfo)) {
            body.put("connectorInfo", request.connectorInfo);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateConnector", "connector_1.0", "HTTP", "POST", "AK", "/v1.0/connector/connectors", "json", req, runtime), new CreateConnectorResponse());
    }

    public CreateTriggerResponse createTrigger(CreateTriggerRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateTriggerHeaders headers = new CreateTriggerHeaders();
        return this.createTriggerWithOptions(request, headers, runtime);
    }

    public CreateTriggerResponse createTriggerWithOptions(CreateTriggerRequest request, CreateTriggerHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.triggerInfo)) {
            body.put("triggerInfo", request.triggerInfo);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateTrigger", "connector_1.0", "HTTP", "POST", "AK", "/v1.0/connector/triggers", "json", req, runtime), new CreateTriggerResponse());
    }

    public PullDataByPageResponse pullDataByPage(PullDataByPageRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        PullDataByPageHeaders headers = new PullDataByPageHeaders();
        return this.pullDataByPageWithOptions(request, headers, runtime);
    }

    public PullDataByPageResponse pullDataByPageWithOptions(PullDataByPageRequest request, PullDataByPageHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appId)) {
            query.put("appId", request.appId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dataModelId)) {
            query.put("dataModelId", request.dataModelId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.datetimeFilterField)) {
            query.put("datetimeFilterField", request.datetimeFilterField);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxDatetime)) {
            query.put("maxDatetime", request.maxDatetime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.minDatetime)) {
            query.put("minDatetime", request.minDatetime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
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
        if (!com.aliyun.teautil.Common.isUnset(request.appId)) {
            query.put("appId", request.appId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.primaryKey)) {
            query.put("primaryKey", request.primaryKey);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
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
        if (!com.aliyun.teautil.Common.isUnset(request.appId)) {
            body.put("appId", request.appId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.triggerDataList)) {
            body.put("triggerDataList", request.triggerDataList);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("SyncData", "connector_1.0", "HTTP", "POST", "AK", "/v1.0/connector/triggers/data/sync", "json", req, runtime), new SyncDataResponse());
    }

    public UpdateActionResponse updateAction(UpdateActionRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateActionHeaders headers = new UpdateActionHeaders();
        return this.updateActionWithOptions(request, headers, runtime);
    }

    public UpdateActionResponse updateActionWithOptions(UpdateActionRequest request, UpdateActionHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.actionInfo)) {
            body.put("actionInfo", request.actionInfo);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdateAction", "connector_1.0", "HTTP", "PUT", "AK", "/v1.0/connector/actions", "json", req, runtime), new UpdateActionResponse());
    }

    public UpdateConnectorResponse updateConnector(UpdateConnectorRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateConnectorHeaders headers = new UpdateConnectorHeaders();
        return this.updateConnectorWithOptions(request, headers, runtime);
    }

    public UpdateConnectorResponse updateConnectorWithOptions(UpdateConnectorRequest request, UpdateConnectorHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.connectorInfo)) {
            body.put("connectorInfo", request.connectorInfo);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdateConnector", "connector_1.0", "HTTP", "PUT", "AK", "/v1.0/connector/connectors", "json", req, runtime), new UpdateConnectorResponse());
    }

    public UpdateTriggerResponse updateTrigger(UpdateTriggerRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateTriggerHeaders headers = new UpdateTriggerHeaders();
        return this.updateTriggerWithOptions(request, headers, runtime);
    }

    public UpdateTriggerResponse updateTriggerWithOptions(UpdateTriggerRequest request, UpdateTriggerHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.triggerInfo)) {
            body.put("triggerInfo", request.triggerInfo);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdateTrigger", "connector_1.0", "HTTP", "PUT", "AK", "/v1.0/connector/triggers", "json", req, runtime), new UpdateTriggerResponse());
    }
}
