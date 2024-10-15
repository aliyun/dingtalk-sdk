// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkconnector_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        com.aliyun.gateway.dingtalk.Client gatewayClient = new com.aliyun.gateway.dingtalk.Client();
        this._spi = gatewayClient;
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    /**
     * <b>summary</b> : 
     * <p>创建执行动作</p>
     * 
     * @param request CreateActionRequest
     * @param headers CreateActionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateActionResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CreateAction"),
            new TeaPair("version", "connector_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/connector/actions"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateActionResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建执行动作</p>
     * 
     * @param request CreateActionRequest
     * @return CreateActionResponse
     */
    public CreateActionResponse createAction(CreateActionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateActionHeaders headers = new CreateActionHeaders();
        return this.createActionWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建连接器</p>
     * 
     * @param request CreateConnectorRequest
     * @param headers CreateConnectorHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateConnectorResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CreateConnector"),
            new TeaPair("version", "connector_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/connector/connectors"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateConnectorResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建连接器</p>
     * 
     * @param request CreateConnectorRequest
     * @return CreateConnectorResponse
     */
    public CreateConnectorResponse createConnector(CreateConnectorRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateConnectorHeaders headers = new CreateConnectorHeaders();
        return this.createConnectorWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建一个用于运行执行动作/集成流的可调用实例</p>
     * 
     * @param request CreateInvocableInstanceRequest
     * @param headers CreateInvocableInstanceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateInvocableInstanceResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CreateInvocableInstance"),
            new TeaPair("version", "connector_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/connector/instances"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateInvocableInstanceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建一个用于运行执行动作/集成流的可调用实例</p>
     * 
     * @param request CreateInvocableInstanceRequest
     * @return CreateInvocableInstanceResponse
     */
    public CreateInvocableInstanceResponse createInvocableInstance(CreateInvocableInstanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateInvocableInstanceHeaders headers = new CreateInvocableInstanceHeaders();
        return this.createInvocableInstanceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建触发器</p>
     * 
     * @param request CreateTriggerRequest
     * @param headers CreateTriggerHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateTriggerResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CreateTrigger"),
            new TeaPair("version", "connector_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/connector/triggers"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateTriggerResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建触发器</p>
     * 
     * @param request CreateTriggerRequest
     * @return CreateTriggerResponse
     */
    public CreateTriggerResponse createTrigger(CreateTriggerRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateTriggerHeaders headers = new CreateTriggerHeaders();
        return this.createTriggerWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取执行动作详情</p>
     * 
     * @param request GetActionDetailRequest
     * @param headers GetActionDetailHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetActionDetailResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetActionDetail"),
            new TeaPair("version", "connector_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/connector/assets/actions/details/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetActionDetailResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取执行动作详情</p>
     * 
     * @param request GetActionDetailRequest
     * @return GetActionDetailResponse
     */
    public GetActionDetailResponse getActionDetail(GetActionDetailRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetActionDetailHeaders headers = new GetActionDetailHeaders();
        return this.getActionDetailWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>调用执行实例</p>
     * 
     * @param request InvokeInstanceRequest
     * @param headers InvokeInstanceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return InvokeInstanceResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "InvokeInstance"),
            new TeaPair("version", "connector_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/connector/instances/invoke"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new InvokeInstanceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>调用执行实例</p>
     * 
     * @param request InvokeInstanceRequest
     * @return InvokeInstanceResponse
     */
    public InvokeInstanceResponse invokeInstance(InvokeInstanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        InvokeInstanceHeaders headers = new InvokeInstanceHeaders();
        return this.invokeInstanceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>分页拉取连接器主数据</p>
     * 
     * @param request PullDataByPageRequest
     * @param headers PullDataByPageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PullDataByPageResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "PullDataByPage"),
            new TeaPair("version", "connector_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/connector/data"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PullDataByPageResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>分页拉取连接器主数据</p>
     * 
     * @param request PullDataByPageRequest
     * @return PullDataByPageResponse
     */
    public PullDataByPageResponse pullDataByPage(PullDataByPageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PullDataByPageHeaders headers = new PullDataByPageHeaders();
        return this.pullDataByPageWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>通过业务主键拉取单条连接器主数据</p>
     * 
     * @param request PullDataByPkRequest
     * @param headers PullDataByPkHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PullDataByPkResponse
     */
    public PullDataByPkResponse pullDataByPkWithOptions(String dataModelId, PullDataByPkRequest request, PullDataByPkHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "PullDataByPk"),
            new TeaPair("version", "connector_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/connector/data/" + dataModelId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PullDataByPkResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>通过业务主键拉取单条连接器主数据</p>
     * 
     * @param request PullDataByPkRequest
     * @return PullDataByPkResponse
     */
    public PullDataByPkResponse pullDataByPk(String dataModelId, PullDataByPkRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PullDataByPkHeaders headers = new PullDataByPkHeaders();
        return this.pullDataByPkWithOptions(dataModelId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>搜索执行动作</p>
     * 
     * @param request SearchActionsRequest
     * @param headers SearchActionsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SearchActionsResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "SearchActions"),
            new TeaPair("version", "connector_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/connector/assets/actions/search"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SearchActionsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>搜索执行动作</p>
     * 
     * @param request SearchActionsRequest
     * @return SearchActionsResponse
     */
    public SearchActionsResponse searchActions(SearchActionsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SearchActionsHeaders headers = new SearchActionsHeaders();
        return this.searchActionsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>搜索连接器</p>
     * 
     * @param request SearchConnectorsRequest
     * @param headers SearchConnectorsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SearchConnectorsResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "SearchConnectors"),
            new TeaPair("version", "connector_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/connector/assets/connectors"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SearchConnectorsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>搜索连接器</p>
     * 
     * @param request SearchConnectorsRequest
     * @return SearchConnectorsResponse
     */
    public SearchConnectorsResponse searchConnectors(SearchConnectorsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SearchConnectorsHeaders headers = new SearchConnectorsHeaders();
        return this.searchConnectorsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>同步连接器数据</p>
     * 
     * @param request SyncDataRequest
     * @param headers SyncDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SyncDataResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "SyncData"),
            new TeaPair("version", "connector_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/connector/triggers/data/sync"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SyncDataResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>同步连接器数据</p>
     * 
     * @param request SyncDataRequest
     * @return SyncDataResponse
     */
    public SyncDataResponse syncData(SyncDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SyncDataHeaders headers = new SyncDataHeaders();
        return this.syncDataWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新执行动作信息</p>
     * 
     * @param request UpdateActionRequest
     * @param headers UpdateActionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateActionResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UpdateAction"),
            new TeaPair("version", "connector_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/connector/actions"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateActionResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新执行动作信息</p>
     * 
     * @param request UpdateActionRequest
     * @return UpdateActionResponse
     */
    public UpdateActionResponse updateAction(UpdateActionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateActionHeaders headers = new UpdateActionHeaders();
        return this.updateActionWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新连接器信息</p>
     * 
     * @param request UpdateConnectorRequest
     * @param headers UpdateConnectorHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateConnectorResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UpdateConnector"),
            new TeaPair("version", "connector_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/connector/connectors"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateConnectorResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新连接器信息</p>
     * 
     * @param request UpdateConnectorRequest
     * @return UpdateConnectorResponse
     */
    public UpdateConnectorResponse updateConnector(UpdateConnectorRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateConnectorHeaders headers = new UpdateConnectorHeaders();
        return this.updateConnectorWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新触发事件信息</p>
     * 
     * @param request UpdateTriggerRequest
     * @param headers UpdateTriggerHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateTriggerResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UpdateTrigger"),
            new TeaPair("version", "connector_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/connector/triggers"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateTriggerResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新触发事件信息</p>
     * 
     * @param request UpdateTriggerRequest
     * @return UpdateTriggerResponse
     */
    public UpdateTriggerResponse updateTrigger(UpdateTriggerRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateTriggerHeaders headers = new UpdateTriggerHeaders();
        return this.updateTriggerWithOptions(request, headers, runtime);
    }
}
