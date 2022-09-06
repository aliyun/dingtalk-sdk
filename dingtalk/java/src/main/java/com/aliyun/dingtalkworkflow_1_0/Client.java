// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkworkflow_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    public BatchUpdateProcessInstanceResponse batchUpdateProcessInstance(BatchUpdateProcessInstanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchUpdateProcessInstanceHeaders headers = new BatchUpdateProcessInstanceHeaders();
        return this.batchUpdateProcessInstanceWithOptions(request, headers, runtime);
    }

    public BatchUpdateProcessInstanceResponse batchUpdateProcessInstanceWithOptions(BatchUpdateProcessInstanceRequest request, BatchUpdateProcessInstanceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.updateProcessInstanceRequests)) {
            body.put("updateProcessInstanceRequests", request.updateProcessInstanceRequests);
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
        return TeaModel.toModel(this.doROARequest("BatchUpdateProcessInstance", "workflow_1.0", "HTTP", "PUT", "AK", "/v1.0/workflow/processCentres/instances/batch", "json", req, runtime), new BatchUpdateProcessInstanceResponse());
    }

    public CancelIntegratedTaskResponse cancelIntegratedTask(CancelIntegratedTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CancelIntegratedTaskHeaders headers = new CancelIntegratedTaskHeaders();
        return this.cancelIntegratedTaskWithOptions(request, headers, runtime);
    }

    public CancelIntegratedTaskResponse cancelIntegratedTaskWithOptions(CancelIntegratedTaskRequest request, CancelIntegratedTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.activityId)) {
            body.put("activityId", request.activityId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.activityIds)) {
            body.put("activityIds", request.activityIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processInstanceId)) {
            body.put("processInstanceId", request.processInstanceId);
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
        return TeaModel.toModel(this.doROARequest("CancelIntegratedTask", "workflow_1.0", "HTTP", "POST", "AK", "/v1.0/workflow/processCentres/tasks/cancel", "json", req, runtime), new CancelIntegratedTaskResponse());
    }

    public CopyProcessResponse copyProcess(CopyProcessRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CopyProcessHeaders headers = new CopyProcessHeaders();
        return this.copyProcessWithOptions(request, headers, runtime);
    }

    public CopyProcessResponse copyProcessWithOptions(CopyProcessRequest request, CopyProcessHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.copyOptions))) {
            body.put("copyOptions", request.copyOptions);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourceCorpId)) {
            body.put("sourceCorpId", request.sourceCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourceProcessVOList)) {
            body.put("sourceProcessVOList", request.sourceProcessVOList);
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
        return TeaModel.toModel(this.doROARequest("CopyProcess", "workflow_1.0", "HTTP", "POST", "AK", "/v1.0/workflow/processes/copy", "json", req, runtime), new CopyProcessResponse());
    }

    public CreateIntegratedTaskResponse createIntegratedTask(CreateIntegratedTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateIntegratedTaskHeaders headers = new CreateIntegratedTaskHeaders();
        return this.createIntegratedTaskWithOptions(request, headers, runtime);
    }

    public CreateIntegratedTaskResponse createIntegratedTaskWithOptions(CreateIntegratedTaskRequest request, CreateIntegratedTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.activityId)) {
            body.put("activityId", request.activityId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processInstanceId)) {
            body.put("processInstanceId", request.processInstanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tasks)) {
            body.put("tasks", request.tasks);
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
        return TeaModel.toModel(this.doROARequest("CreateIntegratedTask", "workflow_1.0", "HTTP", "POST", "AK", "/v1.0/workflow/processCentres/tasks", "json", req, runtime), new CreateIntegratedTaskResponse());
    }

    public DeleteProcessResponse deleteProcess(DeleteProcessRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteProcessHeaders headers = new DeleteProcessHeaders();
        return this.deleteProcessWithOptions(request, headers, runtime);
    }

    public DeleteProcessResponse deleteProcessWithOptions(DeleteProcessRequest request, DeleteProcessHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.cleanRunningTask)) {
            query.put("cleanRunningTask", request.cleanRunningTask);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processCode)) {
            query.put("processCode", request.processCode);
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
        return TeaModel.toModel(this.doROARequest("DeleteProcess", "workflow_1.0", "HTTP", "DELETE", "AK", "/v1.0/workflow/processCentres/schemas", "json", req, runtime), new DeleteProcessResponse());
    }

    public FormCreateResponse formCreate(FormCreateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        FormCreateHeaders headers = new FormCreateHeaders();
        return this.formCreateWithOptions(request, headers, runtime);
    }

    public FormCreateResponse formCreateWithOptions(FormCreateRequest request, FormCreateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formComponents)) {
            body.put("formComponents", request.formComponents);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processCode)) {
            body.put("processCode", request.processCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.templateConfig))) {
            body.put("templateConfig", request.templateConfig);
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
        return TeaModel.toModel(this.doROARequest("FormCreate", "workflow_1.0", "HTTP", "POST", "AK", "/v1.0/workflow/forms", "json", req, runtime), new FormCreateResponse());
    }

    public GetCrmProcCodesResponse getCrmProcCodes() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCrmProcCodesHeaders headers = new GetCrmProcCodesHeaders();
        return this.getCrmProcCodesWithOptions(headers, runtime);
    }

    public GetCrmProcCodesResponse getCrmProcCodesWithOptions(GetCrmProcCodesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("GetCrmProcCodes", "workflow_1.0", "HTTP", "GET", "AK", "/v1.0/workflow/crm/processes", "json", req, runtime), new GetCrmProcCodesResponse());
    }

    public GetProcessCodeByNameResponse getProcessCodeByName(GetProcessCodeByNameRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetProcessCodeByNameHeaders headers = new GetProcessCodeByNameHeaders();
        return this.getProcessCodeByNameWithOptions(request, headers, runtime);
    }

    public GetProcessCodeByNameResponse getProcessCodeByNameWithOptions(GetProcessCodeByNameRequest request, GetProcessCodeByNameHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            query.put("name", request.name);
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
        return TeaModel.toModel(this.doROARequest("GetProcessCodeByName", "workflow_1.0", "HTTP", "GET", "AK", "/v1.0/workflow/processCentres/schemaNames/processCodes", "json", req, runtime), new GetProcessCodeByNameResponse());
    }

    public GetProcessConfigResponse getProcessConfig(GetProcessConfigRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetProcessConfigHeaders headers = new GetProcessConfigHeaders();
        return this.getProcessConfigWithOptions(request, headers, runtime);
    }

    public GetProcessConfigResponse getProcessConfigWithOptions(GetProcessConfigRequest request, GetProcessConfigHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.procCode)) {
            query.put("procCode", request.procCode);
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
        return TeaModel.toModel(this.doROARequest("GetProcessConfig", "workflow_1.0", "HTTP", "GET", "AK", "/v1.0/workflow/crm/processes/configurations", "json", req, runtime), new GetProcessConfigResponse());
    }

    public GrantCspaceAuthorizationResponse grantCspaceAuthorization(GrantCspaceAuthorizationRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GrantCspaceAuthorizationHeaders headers = new GrantCspaceAuthorizationHeaders();
        return this.grantCspaceAuthorizationWithOptions(request, headers, runtime);
    }

    public GrantCspaceAuthorizationResponse grantCspaceAuthorizationWithOptions(GrantCspaceAuthorizationRequest request, GrantCspaceAuthorizationHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.durationSeconds)) {
            body.put("durationSeconds", request.durationSeconds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.spaceId)) {
            body.put("spaceId", request.spaceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            body.put("type", request.type);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
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
        return TeaModel.toModel(this.doROARequest("GrantCspaceAuthorization", "workflow_1.0", "HTTP", "POST", "AK", "/v1.0/workflow/spaces/authorize", "none", req, runtime), new GrantCspaceAuthorizationResponse());
    }

    public ProcessForecastResponse processForecast(ProcessForecastRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ProcessForecastHeaders headers = new ProcessForecastHeaders();
        return this.processForecastWithOptions(request, headers, runtime);
    }

    public ProcessForecastResponse processForecastWithOptions(ProcessForecastRequest request, ProcessForecastHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            body.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formComponentValues)) {
            body.put("formComponentValues", request.formComponentValues);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processCode)) {
            body.put("processCode", request.processCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
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
        return TeaModel.toModel(this.doROARequest("ProcessForecast", "workflow_1.0", "HTTP", "POST", "AK", "/v1.0/workflow/processes/forecast", "json", req, runtime), new ProcessForecastResponse());
    }

    public QueryAllFormInstancesResponse queryAllFormInstances(QueryAllFormInstancesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryAllFormInstancesHeaders headers = new QueryAllFormInstancesHeaders();
        return this.queryAllFormInstancesWithOptions(request, headers, runtime);
    }

    public QueryAllFormInstancesResponse queryAllFormInstancesWithOptions(QueryAllFormInstancesRequest request, QueryAllFormInstancesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appUuid)) {
            query.put("appUuid", request.appUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formCode)) {
            query.put("formCode", request.formCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
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
        return TeaModel.toModel(this.doROARequest("QueryAllFormInstances", "workflow_1.0", "HTTP", "GET", "AK", "/v1.0/workflow/forms/pages/instances", "json", req, runtime), new QueryAllFormInstancesResponse());
    }

    public QueryAllProcessInstancesResponse queryAllProcessInstances(QueryAllProcessInstancesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryAllProcessInstancesHeaders headers = new QueryAllProcessInstancesHeaders();
        return this.queryAllProcessInstancesWithOptions(request, headers, runtime);
    }

    public QueryAllProcessInstancesResponse queryAllProcessInstancesWithOptions(QueryAllProcessInstancesRequest request, QueryAllProcessInstancesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appUuid)) {
            query.put("appUuid", request.appUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTimeInMills)) {
            query.put("endTimeInMills", request.endTimeInMills);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processCode)) {
            query.put("processCode", request.processCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTimeInMills)) {
            query.put("startTimeInMills", request.startTimeInMills);
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
        return TeaModel.toModel(this.doROARequest("QueryAllProcessInstances", "workflow_1.0", "HTTP", "GET", "AK", "/v1.0/workflow/processes/pages/instances", "json", req, runtime), new QueryAllProcessInstancesResponse());
    }

    public QueryFormByBizTypeResponse queryFormByBizType(QueryFormByBizTypeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryFormByBizTypeHeaders headers = new QueryFormByBizTypeHeaders();
        return this.queryFormByBizTypeWithOptions(request, headers, runtime);
    }

    public QueryFormByBizTypeResponse queryFormByBizTypeWithOptions(QueryFormByBizTypeRequest request, QueryFormByBizTypeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appUuid)) {
            body.put("appUuid", request.appUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizTypes)) {
            body.put("bizTypes", request.bizTypes);
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
        return TeaModel.toModel(this.doROARequest("QueryFormByBizType", "workflow_1.0", "HTTP", "POST", "AK", "/v1.0/workflow/forms/forminfos/query", "json", req, runtime), new QueryFormByBizTypeResponse());
    }

    public QueryFormInstanceResponse queryFormInstance(QueryFormInstanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryFormInstanceHeaders headers = new QueryFormInstanceHeaders();
        return this.queryFormInstanceWithOptions(request, headers, runtime);
    }

    public QueryFormInstanceResponse queryFormInstanceWithOptions(QueryFormInstanceRequest request, QueryFormInstanceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appUuid)) {
            query.put("appUuid", request.appUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formCode)) {
            query.put("formCode", request.formCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formInstanceId)) {
            query.put("formInstanceId", request.formInstanceId);
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
        return TeaModel.toModel(this.doROARequest("QueryFormInstance", "workflow_1.0", "HTTP", "GET", "AK", "/v1.0/workflow/forms/instances", "json", req, runtime), new QueryFormInstanceResponse());
    }

    public QueryIntegratedTodoTaskResponse queryIntegratedTodoTask(QueryIntegratedTodoTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryIntegratedTodoTaskHeaders headers = new QueryIntegratedTodoTaskHeaders();
        return this.queryIntegratedTodoTaskWithOptions(request, headers, runtime);
    }

    public QueryIntegratedTodoTaskResponse queryIntegratedTodoTaskWithOptions(QueryIntegratedTodoTaskRequest request, QueryIntegratedTodoTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.createBefore)) {
            query.put("createBefore", request.createBefore);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
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
        return TeaModel.toModel(this.doROARequest("QueryIntegratedTodoTask", "workflow_1.0", "HTTP", "GET", "AK", "/v1.0/workflow/processCentres/todoTasks", "json", req, runtime), new QueryIntegratedTodoTaskResponse());
    }

    public QueryProcessByBizCategoryIdResponse queryProcessByBizCategoryId(QueryProcessByBizCategoryIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryProcessByBizCategoryIdHeaders headers = new QueryProcessByBizCategoryIdHeaders();
        return this.queryProcessByBizCategoryIdWithOptions(request, headers, runtime);
    }

    public QueryProcessByBizCategoryIdResponse queryProcessByBizCategoryIdWithOptions(QueryProcessByBizCategoryIdRequest request, QueryProcessByBizCategoryIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizType)) {
            query.put("bizType", request.bizType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
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
        return TeaModel.toModel(this.doROARequest("QueryProcessByBizCategoryId", "workflow_1.0", "HTTP", "GET", "AK", "/v1.0/workflow/processes/categories/templates", "json", req, runtime), new QueryProcessByBizCategoryIdResponse());
    }

    public QuerySchemaByProcessCodeResponse querySchemaByProcessCode(QuerySchemaByProcessCodeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QuerySchemaByProcessCodeHeaders headers = new QuerySchemaByProcessCodeHeaders();
        return this.querySchemaByProcessCodeWithOptions(request, headers, runtime);
    }

    public QuerySchemaByProcessCodeResponse querySchemaByProcessCodeWithOptions(QuerySchemaByProcessCodeRequest request, QuerySchemaByProcessCodeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appUuid)) {
            query.put("appUuid", request.appUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processCode)) {
            query.put("processCode", request.processCode);
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
        return TeaModel.toModel(this.doROARequest("QuerySchemaByProcessCode", "workflow_1.0", "HTTP", "GET", "AK", "/v1.0/workflow/forms/schemas/processCodes", "json", req, runtime), new QuerySchemaByProcessCodeResponse());
    }

    public RedirectWorkflowTaskResponse redirectWorkflowTask(RedirectWorkflowTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RedirectWorkflowTaskHeaders headers = new RedirectWorkflowTaskHeaders();
        return this.redirectWorkflowTaskWithOptions(request, headers, runtime);
    }

    public RedirectWorkflowTaskResponse redirectWorkflowTaskWithOptions(RedirectWorkflowTaskRequest request, RedirectWorkflowTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.actionName)) {
            body.put("actionName", request.actionName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.remark)) {
            body.put("remark", request.remark);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskId)) {
            body.put("taskId", request.taskId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.toUserId)) {
            body.put("toUserId", request.toUserId);
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
        return TeaModel.toModel(this.doROARequest("RedirectWorkflowTask", "workflow_1.0", "HTTP", "POST", "AK", "/v1.0/workflow/tasks/redirect", "json", req, runtime), new RedirectWorkflowTaskResponse());
    }

    public SaveIntegratedInstanceResponse saveIntegratedInstance(SaveIntegratedInstanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SaveIntegratedInstanceHeaders headers = new SaveIntegratedInstanceHeaders();
        return this.saveIntegratedInstanceWithOptions(request, headers, runtime);
    }

    public SaveIntegratedInstanceResponse saveIntegratedInstanceWithOptions(SaveIntegratedInstanceRequest request, SaveIntegratedInstanceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.formComponentValueList)) {
            body.put("formComponentValueList", request.formComponentValueList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.notifiers)) {
            body.put("notifiers", request.notifiers);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.originatorUserId)) {
            body.put("originatorUserId", request.originatorUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processCode)) {
            body.put("processCode", request.processCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.url)) {
            body.put("url", request.url);
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
        return TeaModel.toModel(this.doROARequest("SaveIntegratedInstance", "workflow_1.0", "HTTP", "POST", "AK", "/v1.0/workflow/processCentres/instances", "json", req, runtime), new SaveIntegratedInstanceResponse());
    }

    public SaveProcessResponse saveProcess(SaveProcessRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SaveProcessHeaders headers = new SaveProcessHeaders();
        return this.saveProcessWithOptions(request, headers, runtime);
    }

    public SaveProcessResponse saveProcessWithOptions(SaveProcessRequest request, SaveProcessHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formComponents)) {
            body.put("formComponents", request.formComponents);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processCode)) {
            body.put("processCode", request.processCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.processFeatureConfig))) {
            body.put("processFeatureConfig", request.processFeatureConfig);
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
        return TeaModel.toModel(this.doROARequest("SaveProcess", "workflow_1.0", "HTTP", "POST", "AK", "/v1.0/workflow/processCentres/schemas", "json", req, runtime), new SaveProcessResponse());
    }

    public StartProcessInstanceResponse startProcessInstance(StartProcessInstanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        StartProcessInstanceHeaders headers = new StartProcessInstanceHeaders();
        return this.startProcessInstanceWithOptions(request, headers, runtime);
    }

    public StartProcessInstanceResponse startProcessInstanceWithOptions(StartProcessInstanceRequest request, StartProcessInstanceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.approvers)) {
            body.put("approvers", request.approvers);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ccList)) {
            body.put("ccList", request.ccList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ccPosition)) {
            body.put("ccPosition", request.ccPosition);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            body.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formComponentValues)) {
            body.put("formComponentValues", request.formComponentValues);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.microappAgentId)) {
            body.put("microappAgentId", request.microappAgentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.originatorUserId)) {
            body.put("originatorUserId", request.originatorUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processCode)) {
            body.put("processCode", request.processCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetSelectActioners)) {
            body.put("targetSelectActioners", request.targetSelectActioners);
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
        return TeaModel.toModel(this.doROARequest("StartProcessInstance", "workflow_1.0", "HTTP", "POST", "AK", "/v1.0/workflow/processInstances", "json", req, runtime), new StartProcessInstanceResponse());
    }

    public UpdateIntegratedTaskResponse updateIntegratedTask(UpdateIntegratedTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateIntegratedTaskHeaders headers = new UpdateIntegratedTaskHeaders();
        return this.updateIntegratedTaskWithOptions(request, headers, runtime);
    }

    public UpdateIntegratedTaskResponse updateIntegratedTaskWithOptions(UpdateIntegratedTaskRequest request, UpdateIntegratedTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.processInstanceId)) {
            body.put("processInstanceId", request.processInstanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tasks)) {
            body.put("tasks", request.tasks);
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
        return TeaModel.toModel(this.doROARequest("UpdateIntegratedTask", "workflow_1.0", "HTTP", "PUT", "AK", "/v1.0/workflow/processCentres/tasks", "json", req, runtime), new UpdateIntegratedTaskResponse());
    }

    public UpdateProcessInstanceResponse updateProcessInstance(UpdateProcessInstanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateProcessInstanceHeaders headers = new UpdateProcessInstanceHeaders();
        return this.updateProcessInstanceWithOptions(request, headers, runtime);
    }

    public UpdateProcessInstanceResponse updateProcessInstanceWithOptions(UpdateProcessInstanceRequest request, UpdateProcessInstanceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.processInstanceId)) {
            body.put("processInstanceId", request.processInstanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.result)) {
            body.put("result", request.result);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
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
        return TeaModel.toModel(this.doROARequest("UpdateProcessInstance", "workflow_1.0", "HTTP", "PUT", "AK", "/v1.0/workflow/processCentres/instances", "json", req, runtime), new UpdateProcessInstanceResponse());
    }
}
