// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkconnector_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    public CreateActionResponse createAction(CreateActionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateActionHeaders headers = new CreateActionHeaders();
        return this.createActionWithOptions(request, headers, runtime);
    }

    public CreateActionResponse createActionWithOptions(CreateActionRequest request, CreateActionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.actionInfo)) {
            body.put("actionInfo", request.actionInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.integratorFlag)) {
            body.put("integratorFlag", request.integratorFlag);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateAction", "connector_1.0", "HTTP", "POST", "AK", "/v1.0/connector/actions", "json", req, runtime), new CreateActionResponse());
    }

    public CreateConnectorResponse createConnector(CreateConnectorRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateConnectorHeaders headers = new CreateConnectorHeaders();
        return this.createConnectorWithOptions(request, headers, runtime);
    }

    public CreateConnectorResponse createConnectorWithOptions(CreateConnectorRequest request, CreateConnectorHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.connectorInfo)) {
            body.put("connectorInfo", request.connectorInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.integratorFlag)) {
            body.put("integratorFlag", request.integratorFlag);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateConnector", "connector_1.0", "HTTP", "POST", "AK", "/v1.0/connector/connectors", "json", req, runtime), new CreateConnectorResponse());
    }

    public CreateInvocableInstanceResponse createInvocableInstance(CreateInvocableInstanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateInvocableInstanceHeaders headers = new CreateInvocableInstanceHeaders();
        return this.createInvocableInstanceWithOptions(request, headers, runtime);
    }

    public CreateInvocableInstanceResponse createInvocableInstanceWithOptions(CreateInvocableInstanceRequest request, CreateInvocableInstanceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.connectAssetUri)) {
            body.put("connectAssetUri", request.connectAssetUri);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instanceKey)) {
            body.put("instanceKey", request.instanceKey);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateInvocableInstance", "connector_1.0", "HTTP", "POST", "AK", "/v1.0/connector/instances", "json", req, runtime), new CreateInvocableInstanceResponse());
    }

    public CreateTriggerResponse createTrigger(CreateTriggerRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateTriggerHeaders headers = new CreateTriggerHeaders();
        return this.createTriggerWithOptions(request, headers, runtime);
    }

    public CreateTriggerResponse createTriggerWithOptions(CreateTriggerRequest request, CreateTriggerHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.integratorFlag)) {
            body.put("integratorFlag", request.integratorFlag);
        }

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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateTrigger", "connector_1.0", "HTTP", "POST", "AK", "/v1.0/connector/triggers", "json", req, runtime), new CreateTriggerResponse());
    }

    public GetActionDetailResponse getActionDetail(GetActionDetailRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetActionDetailHeaders headers = new GetActionDetailHeaders();
        return this.getActionDetailWithOptions(request, headers, runtime);
    }

    public GetActionDetailResponse getActionDetailWithOptions(GetActionDetailRequest request, GetActionDetailHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.connectAssetUri)) {
            body.put("connectAssetUri", request.connectAssetUri);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("GetActionDetail", "connector_1.0", "HTTP", "POST", "AK", "/v1.0/connector/assets/actions/details/query", "json", req, runtime), new GetActionDetailResponse());
    }

    public InvokeInstanceResponse invokeInstance(InvokeInstanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        InvokeInstanceHeaders headers = new InvokeInstanceHeaders();
        return this.invokeInstanceWithOptions(request, headers, runtime);
    }

    public InvokeInstanceResponse invokeInstanceWithOptions(InvokeInstanceRequest request, InvokeInstanceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.connectAssetUri)) {
            body.put("connectAssetUri", request.connectAssetUri);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.inputJsonString)) {
            body.put("inputJsonString", request.inputJsonString);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instanceKey)) {
            body.put("instanceKey", request.instanceKey);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("InvokeInstance", "connector_1.0", "HTTP", "POST", "AK", "/v1.0/connector/instances/invoke", "json", req, runtime), new InvokeInstanceResponse());
    }

    public PullDataByPageResponse pullDataByPage(PullDataByPageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PullDataByPageHeaders headers = new PullDataByPageHeaders();
        return this.pullDataByPageWithOptions(request, headers, runtime);
    }

    public PullDataByPageResponse pullDataByPageWithOptions(PullDataByPageRequest request, PullDataByPageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("PullDataByPage", "connector_1.0", "HTTP", "GET", "AK", "/v1.0/connector/data", "json", req, runtime), new PullDataByPageResponse());
    }

    public PullDataByPkResponse pullDataByPk(String dataModelId, PullDataByPkRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PullDataByPkHeaders headers = new PullDataByPkHeaders();
        return this.pullDataByPkWithOptions(dataModelId, request, headers, runtime);
    }

    public PullDataByPkResponse pullDataByPkWithOptions(String dataModelId, PullDataByPkRequest request, PullDataByPkHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("PullDataByPk", "connector_1.0", "HTTP", "GET", "AK", "/v1.0/connector/data/" + dataModelId + "", "json", req, runtime), new PullDataByPkResponse());
    }

    public SearchActionsResponse searchActions(SearchActionsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SearchActionsHeaders headers = new SearchActionsHeaders();
        return this.searchActionsWithOptions(request, headers, runtime);
    }

    public SearchActionsResponse searchActionsWithOptions(SearchActionsRequest request, SearchActionsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.connectorId)) {
            body.put("connectorId", request.connectorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.connectorProviderCorpId)) {
            body.put("connectorProviderCorpId", request.connectorProviderCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.integrationTypes)) {
            body.put("integrationTypes", request.integrationTypes);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            body.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            body.put("nextToken", request.nextToken);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("SearchActions", "connector_1.0", "HTTP", "POST", "AK", "/v1.0/connector/assets/actions/search", "json", req, runtime), new SearchActionsResponse());
    }

    public SearchConnectorsResponse searchConnectors(SearchConnectorsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SearchConnectorsHeaders headers = new SearchConnectorsHeaders();
        return this.searchConnectorsWithOptions(request, headers, runtime);
    }

    public SearchConnectorsResponse searchConnectorsWithOptions(SearchConnectorsRequest request, SearchConnectorsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            query.put("type", request.type);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("SearchConnectors", "connector_1.0", "HTTP", "GET", "AK", "/v1.0/connector/assets/connectors", "json", req, runtime), new SearchConnectorsResponse());
    }

    public SyncDataResponse syncData(SyncDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SyncDataHeaders headers = new SyncDataHeaders();
        return this.syncDataWithOptions(request, headers, runtime);
    }

    public SyncDataResponse syncDataWithOptions(SyncDataRequest request, SyncDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("SyncData", "connector_1.0", "HTTP", "POST", "AK", "/v1.0/connector/triggers/data/sync", "json", req, runtime), new SyncDataResponse());
    }

    public UpdateActionResponse updateAction(UpdateActionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateActionHeaders headers = new UpdateActionHeaders();
        return this.updateActionWithOptions(request, headers, runtime);
    }

    public UpdateActionResponse updateActionWithOptions(UpdateActionRequest request, UpdateActionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.actionInfo)) {
            body.put("actionInfo", request.actionInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.integratorFlag)) {
            body.put("integratorFlag", request.integratorFlag);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdateAction", "connector_1.0", "HTTP", "PUT", "AK", "/v1.0/connector/actions", "json", req, runtime), new UpdateActionResponse());
    }

    public UpdateConnectorResponse updateConnector(UpdateConnectorRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateConnectorHeaders headers = new UpdateConnectorHeaders();
        return this.updateConnectorWithOptions(request, headers, runtime);
    }

    public UpdateConnectorResponse updateConnectorWithOptions(UpdateConnectorRequest request, UpdateConnectorHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.connectorInfo)) {
            body.put("connectorInfo", request.connectorInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.integratorFlag)) {
            body.put("integratorFlag", request.integratorFlag);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdateConnector", "connector_1.0", "HTTP", "PUT", "AK", "/v1.0/connector/connectors", "json", req, runtime), new UpdateConnectorResponse());
    }

    public UpdateTriggerResponse updateTrigger(UpdateTriggerRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateTriggerHeaders headers = new UpdateTriggerHeaders();
        return this.updateTriggerWithOptions(request, headers, runtime);
    }

    public UpdateTriggerResponse updateTriggerWithOptions(UpdateTriggerRequest request, UpdateTriggerHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.integratorFlag)) {
            body.put("integratorFlag", request.integratorFlag);
        }

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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdateTrigger", "connector_1.0", "HTTP", "PUT", "AK", "/v1.0/connector/triggers", "json", req, runtime), new UpdateTriggerResponse());
    }
}
