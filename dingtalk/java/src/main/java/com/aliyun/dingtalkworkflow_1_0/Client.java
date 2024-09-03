// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkworkflow_1_0.models.*;

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
     * <p>授权下载审批钉盘文件</p>
     * 
     * @param request AddApproveDentryAuthRequest
     * @param headers AddApproveDentryAuthHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddApproveDentryAuthResponse
     */
    public AddApproveDentryAuthResponse addApproveDentryAuthWithOptions(AddApproveDentryAuthRequest request, AddApproveDentryAuthHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.fileInfos)) {
            body.put("fileInfos", request.fileInfos);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "AddApproveDentryAuth"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/processInstances/spaces/files/authDownload"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddApproveDentryAuthResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>授权下载审批钉盘文件</p>
     * 
     * @param request AddApproveDentryAuthRequest
     * @return AddApproveDentryAuthResponse
     */
    public AddApproveDentryAuthResponse addApproveDentryAuth(AddApproveDentryAuthRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddApproveDentryAuthHeaders headers = new AddApproveDentryAuthHeaders();
        return this.addApproveDentryAuthWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>添加审批评论</p>
     * 
     * @param request AddProcessInstanceCommentRequest
     * @param headers AddProcessInstanceCommentHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddProcessInstanceCommentResponse
     */
    public AddProcessInstanceCommentResponse addProcessInstanceCommentWithOptions(AddProcessInstanceCommentRequest request, AddProcessInstanceCommentHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.commentUserId)) {
            body.put("commentUserId", request.commentUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.file)) {
            body.put("file", request.file);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processInstanceId)) {
            body.put("processInstanceId", request.processInstanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.text)) {
            body.put("text", request.text);
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
            new TeaPair("action", "AddProcessInstanceComment"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/processInstances/comments"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddProcessInstanceCommentResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>添加审批评论</p>
     * 
     * @param request AddProcessInstanceCommentRequest
     * @return AddProcessInstanceCommentResponse
     */
    public AddProcessInstanceCommentResponse addProcessInstanceComment(AddProcessInstanceCommentRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddProcessInstanceCommentHeaders headers = new AddProcessInstanceCommentHeaders();
        return this.addProcessInstanceCommentWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量同意或拒绝审批任务</p>
     * 
     * @param request BatchExecuteProcessInstancesRequest
     * @param headers BatchExecuteProcessInstancesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchExecuteProcessInstancesResponse
     */
    public BatchExecuteProcessInstancesResponse batchExecuteProcessInstancesWithOptions(BatchExecuteProcessInstancesRequest request, BatchExecuteProcessInstancesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.actionerUserId)) {
            body.put("actionerUserId", request.actionerUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.remark)) {
            body.put("remark", request.remark);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.result)) {
            body.put("result", request.result);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskInfoList)) {
            body.put("taskInfoList", request.taskInfoList);
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
            new TeaPair("action", "BatchExecuteProcessInstances"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/processInstances/batchExecute"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchExecuteProcessInstancesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量同意或拒绝审批任务</p>
     * 
     * @param request BatchExecuteProcessInstancesRequest
     * @return BatchExecuteProcessInstancesResponse
     */
    public BatchExecuteProcessInstancesResponse batchExecuteProcessInstances(BatchExecuteProcessInstancesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchExecuteProcessInstancesHeaders headers = new BatchExecuteProcessInstancesHeaders();
        return this.batchExecuteProcessInstancesWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量流程审批任务转交</p>
     * 
     * @param request BatchTasksRedirectRequest
     * @param headers BatchTasksRedirectHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchTasksRedirectResponse
     */
    public BatchTasksRedirectResponse batchTasksRedirectWithOptions(BatchTasksRedirectRequest request, BatchTasksRedirectHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.handoverUserId)) {
            body.put("handoverUserId", request.handoverUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.managerUserId)) {
            body.put("managerUserId", request.managerUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskIds)) {
            body.put("taskIds", request.taskIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.transfereeUserId)) {
            body.put("transfereeUserId", request.transfereeUserId);
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
            new TeaPair("action", "BatchTasksRedirect"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/tasks/batchRedirect"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchTasksRedirectResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量流程审批任务转交</p>
     * 
     * @param request BatchTasksRedirectRequest
     * @return BatchTasksRedirectResponse
     */
    public BatchTasksRedirectResponse batchTasksRedirect(BatchTasksRedirectRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchTasksRedirectHeaders headers = new BatchTasksRedirectHeaders();
        return this.batchTasksRedirectWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量更新实例状态</p>
     * 
     * @param request BatchUpdateProcessInstanceRequest
     * @param headers BatchUpdateProcessInstanceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchUpdateProcessInstanceResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "BatchUpdateProcessInstance"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/processCentres/instances/batch"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchUpdateProcessInstanceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量更新实例状态</p>
     * 
     * @param request BatchUpdateProcessInstanceRequest
     * @return BatchUpdateProcessInstanceResponse
     */
    public BatchUpdateProcessInstanceResponse batchUpdateProcessInstance(BatchUpdateProcessInstanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchUpdateProcessInstanceHeaders headers = new BatchUpdateProcessInstanceHeaders();
        return this.batchUpdateProcessInstanceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量取消流程中心待处理任务</p>
     * 
     * @param request CancelIntegratedTaskRequest
     * @param headers CancelIntegratedTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CancelIntegratedTaskResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CancelIntegratedTask"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/processCentres/tasks/cancel"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CancelIntegratedTaskResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量取消流程中心待处理任务</p>
     * 
     * @param request CancelIntegratedTaskRequest
     * @return CancelIntegratedTaskResponse
     */
    public CancelIntegratedTaskResponse cancelIntegratedTask(CancelIntegratedTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CancelIntegratedTaskHeaders headers = new CancelIntegratedTaskHeaders();
        return this.cancelIntegratedTaskWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>清理审批数据</p>
     * 
     * @param request CleanProcessDataRequest
     * @param headers CleanProcessDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CleanProcessDataResponse
     */
    public CleanProcessDataResponse cleanProcessDataWithOptions(CleanProcessDataRequest request, CleanProcessDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processCode)) {
            body.put("processCode", request.processCode);
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
            new TeaPair("action", "CleanProcessData"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/processes/clean"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CleanProcessDataResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>清理审批数据</p>
     * 
     * @param request CleanProcessDataRequest
     * @return CleanProcessDataResponse
     */
    public CleanProcessDataResponse cleanProcessData(CleanProcessDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CleanProcessDataHeaders headers = new CleanProcessDataHeaders();
        return this.cleanProcessDataWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>复制审批流</p>
     * 
     * @param request CopyProcessRequest
     * @param headers CopyProcessHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CopyProcessResponse
     */
    public CopyProcessResponse copyProcessWithOptions(CopyProcessRequest request, CopyProcessHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.copyOptions)) {
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CopyProcess"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/processes/copy"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CopyProcessResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>复制审批流</p>
     * 
     * @param request CopyProcessRequest
     * @return CopyProcessResponse
     */
    public CopyProcessResponse copyProcess(CopyProcessRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CopyProcessHeaders headers = new CopyProcessHeaders();
        return this.copyProcessWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建流程中心待处理任务</p>
     * 
     * @param request CreateIntegratedTaskRequest
     * @param headers CreateIntegratedTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateIntegratedTaskResponse
     */
    public CreateIntegratedTaskResponse createIntegratedTaskWithOptions(CreateIntegratedTaskRequest request, CreateIntegratedTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.activityId)) {
            body.put("activityId", request.activityId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.featureConfig)) {
            body.put("featureConfig", request.featureConfig);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CreateIntegratedTask"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/processCentres/tasks"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateIntegratedTaskResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建流程中心待处理任务</p>
     * 
     * @param request CreateIntegratedTaskRequest
     * @return CreateIntegratedTaskResponse
     */
    public CreateIntegratedTaskResponse createIntegratedTask(CreateIntegratedTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateIntegratedTaskHeaders headers = new CreateIntegratedTaskHeaders();
        return this.createIntegratedTaskWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除分组</p>
     * 
     * @param request DeleteDirRequest
     * @param headers DeleteDirHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteDirResponse
     */
    public DeleteDirResponse deleteDirWithOptions(DeleteDirRequest request, DeleteDirHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dirId)) {
            query.put("dirId", request.dirId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operateUserId)) {
            query.put("operateUserId", request.operateUserId);
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
            new TeaPair("action", "DeleteDir"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/processCentres/directories"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteDirResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除分组</p>
     * 
     * @param request DeleteDirRequest
     * @return DeleteDirResponse
     */
    public DeleteDirResponse deleteDir(DeleteDirRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteDirHeaders headers = new DeleteDirHeaders();
        return this.deleteDirWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除模板</p>
     * 
     * @param request DeleteProcessRequest
     * @param headers DeleteProcessHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteProcessResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "DeleteProcess"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/processCentres/schemas"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteProcessResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除模板</p>
     * 
     * @param request DeleteProcessRequest
     * @return DeleteProcessResponse
     */
    public DeleteProcessResponse deleteProcess(DeleteProcessRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteProcessHeaders headers = new DeleteProcessHeaders();
        return this.deleteProcessWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>同意或拒绝审批任务</p>
     * 
     * @param request ExecuteProcessInstanceRequest
     * @param headers ExecuteProcessInstanceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ExecuteProcessInstanceResponse
     */
    public ExecuteProcessInstanceResponse executeProcessInstanceWithOptions(ExecuteProcessInstanceRequest request, ExecuteProcessInstanceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.actionerUserId)) {
            body.put("actionerUserId", request.actionerUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.file)) {
            body.put("file", request.file);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processInstanceId)) {
            body.put("processInstanceId", request.processInstanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.remark)) {
            body.put("remark", request.remark);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.result)) {
            body.put("result", request.result);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskId)) {
            body.put("taskId", request.taskId);
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
            new TeaPair("action", "ExecuteProcessInstance"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/processInstances/execute"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ExecuteProcessInstanceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>同意或拒绝审批任务</p>
     * 
     * @param request ExecuteProcessInstanceRequest
     * @return ExecuteProcessInstanceResponse
     */
    public ExecuteProcessInstanceResponse executeProcessInstance(ExecuteProcessInstanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ExecuteProcessInstanceHeaders headers = new ExecuteProcessInstanceHeaders();
        return this.executeProcessInstanceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建或更新审批表单模板</p>
     * 
     * @param request FormCreateRequest
     * @param headers FormCreateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return FormCreateResponse
     */
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

        if (!com.aliyun.teautil.Common.isUnset(request.templateConfig)) {
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "FormCreate"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/forms"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new FormCreateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建或更新审批表单模板</p>
     * 
     * @param request FormCreateRequest
     * @return FormCreateResponse
     */
    public FormCreateResponse formCreate(FormCreateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        FormCreateHeaders headers = new FormCreateHeaders();
        return this.formCreateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取审批钉盘空间信息</p>
     * 
     * @param request GetAttachmentSpaceRequest
     * @param headers GetAttachmentSpaceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetAttachmentSpaceResponse
     */
    public GetAttachmentSpaceResponse getAttachmentSpaceWithOptions(GetAttachmentSpaceRequest request, GetAttachmentSpaceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.agentId)) {
            body.put("agentId", request.agentId);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetAttachmentSpace"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/processInstances/spaces/infos/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetAttachmentSpaceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取审批钉盘空间信息</p>
     * 
     * @param request GetAttachmentSpaceRequest
     * @return GetAttachmentSpaceResponse
     */
    public GetAttachmentSpaceResponse getAttachmentSpace(GetAttachmentSpaceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetAttachmentSpaceHeaders headers = new GetAttachmentSpaceHeaders();
        return this.getAttachmentSpaceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询已设置为条件的表单组件</p>
     * 
     * @param request GetConditionFormComponentRequest
     * @param headers GetConditionFormComponentHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetConditionFormComponentResponse
     */
    public GetConditionFormComponentResponse getConditionFormComponentWithOptions(GetConditionFormComponentRequest request, GetConditionFormComponentHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.agentId)) {
            query.put("agentId", request.agentId);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetConditionFormComponent"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/processes/conditions/components"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetConditionFormComponentResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询已设置为条件的表单组件</p>
     * 
     * @param request GetConditionFormComponentRequest
     * @return GetConditionFormComponentResponse
     */
    public GetConditionFormComponentResponse getConditionFormComponent(GetConditionFormComponentRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetConditionFormComponentHeaders headers = new GetConditionFormComponentHeaders();
        return this.getConditionFormComponentWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取CRM所有流程code</p>
     * 
     * @param headers GetCrmProcCodesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetCrmProcCodesResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetCrmProcCodes"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/crm/processes"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetCrmProcCodesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取CRM所有流程code</p>
     * @return GetCrmProcCodesResponse
     */
    public GetCrmProcCodesResponse getCrmProcCodes() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCrmProcCodesHeaders headers = new GetCrmProcCodesHeaders();
        return this.getCrmProcCodesWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取表单字段修改历史</p>
     * 
     * @param request GetFieldModifiedHistoryRequest
     * @param headers GetFieldModifiedHistoryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetFieldModifiedHistoryResponse
     */
    public GetFieldModifiedHistoryResponse getFieldModifiedHistoryWithOptions(GetFieldModifiedHistoryRequest request, GetFieldModifiedHistoryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.fieldId)) {
            body.put("fieldId", request.fieldId);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetFieldModifiedHistory"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/processes/fields/modifiedRecords/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetFieldModifiedHistoryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取表单字段修改历史</p>
     * 
     * @param request GetFieldModifiedHistoryRequest
     * @return GetFieldModifiedHistoryResponse
     */
    public GetFieldModifiedHistoryResponse getFieldModifiedHistory(GetFieldModifiedHistoryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetFieldModifiedHistoryHeaders headers = new GetFieldModifiedHistoryHeaders();
        return this.getFieldModifiedHistoryWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取手写签名的下载链接</p>
     * 
     * @param request GetHandSignDownloadUrlRequest
     * @param headers GetHandSignDownloadUrlHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetHandSignDownloadUrlResponse
     */
    public GetHandSignDownloadUrlResponse getHandSignDownloadUrlWithOptions(GetHandSignDownloadUrlRequest request, GetHandSignDownloadUrlHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.handSignToken)) {
            body.put("handSignToken", request.handSignToken);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetHandSignDownloadUrl"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/premium/processInstances/handSigns/downloadUrls/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetHandSignDownloadUrlResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取手写签名的下载链接</p>
     * 
     * @param request GetHandSignDownloadUrlRequest
     * @return GetHandSignDownloadUrlResponse
     */
    public GetHandSignDownloadUrlResponse getHandSignDownloadUrl(GetHandSignDownloadUrlRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetHandSignDownloadUrlHeaders headers = new GetHandSignDownloadUrlHeaders();
        return this.getHandSignDownloadUrlWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取当前企业所有可管理的表单</p>
     * 
     * @param request GetManageProcessByStaffIdRequest
     * @param headers GetManageProcessByStaffIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetManageProcessByStaffIdResponse
     */
    public GetManageProcessByStaffIdResponse getManageProcessByStaffIdWithOptions(GetManageProcessByStaffIdRequest request, GetManageProcessByStaffIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetManageProcessByStaffId"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/processes/managements/templates"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetManageProcessByStaffIdResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取当前企业所有可管理的表单</p>
     * 
     * @param request GetManageProcessByStaffIdRequest
     * @return GetManageProcessByStaffIdResponse
     */
    public GetManageProcessByStaffIdResponse getManageProcessByStaffId(GetManageProcessByStaffIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetManageProcessByStaffIdHeaders headers = new GetManageProcessByStaffIdHeaders();
        return this.getManageProcessByStaffIdWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取模板code</p>
     * 
     * @param request GetProcessCodeByNameRequest
     * @param headers GetProcessCodeByNameHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetProcessCodeByNameResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetProcessCodeByName"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/processCentres/schemaNames/processCodes"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetProcessCodeByNameResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取模板code</p>
     * 
     * @param request GetProcessCodeByNameRequest
     * @return GetProcessCodeByNameResponse
     */
    public GetProcessCodeByNameResponse getProcessCodeByName(GetProcessCodeByNameRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetProcessCodeByNameHeaders headers = new GetProcessCodeByNameHeaders();
        return this.getProcessCodeByNameWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取流程配置</p>
     * 
     * @param request GetProcessConfigRequest
     * @param headers GetProcessConfigHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetProcessConfigResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetProcessConfig"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/crm/processes/configurations"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetProcessConfigResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取流程配置</p>
     * 
     * @param request GetProcessConfigRequest
     * @return GetProcessConfigResponse
     */
    public GetProcessConfigResponse getProcessConfig(GetProcessConfigRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetProcessConfigHeaders headers = new GetProcessConfigHeaders();
        return this.getProcessConfigWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取单个审批实例详情</p>
     * 
     * @param request GetProcessInstanceRequest
     * @param headers GetProcessInstanceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetProcessInstanceResponse
     */
    public GetProcessInstanceResponse getProcessInstanceWithOptions(GetProcessInstanceRequest request, GetProcessInstanceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.processInstanceId)) {
            query.put("processInstanceId", request.processInstanceId);
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
            new TeaPair("action", "GetProcessInstance"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/processInstances"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetProcessInstanceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取单个审批实例详情</p>
     * 
     * @param request GetProcessInstanceRequest
     * @return GetProcessInstanceResponse
     */
    public GetProcessInstanceResponse getProcessInstance(GetProcessInstanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetProcessInstanceHeaders headers = new GetProcessInstanceHeaders();
        return this.getProcessInstanceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取审批单详情高级接口，可以返回审批流程中的手写签名密码消息</p>
     * 
     * @param request GetProcessInstanceWithExtraRequest
     * @param headers GetProcessInstanceWithExtraHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetProcessInstanceWithExtraResponse
     */
    public GetProcessInstanceWithExtraResponse getProcessInstanceWithExtraWithOptions(GetProcessInstanceWithExtraRequest request, GetProcessInstanceWithExtraHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.processInstanceId)) {
            query.put("processInstanceId", request.processInstanceId);
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
            new TeaPair("action", "GetProcessInstanceWithExtra"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/premium/processInstances"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetProcessInstanceWithExtraResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取审批单详情高级接口，可以返回审批流程中的手写签名密码消息</p>
     * 
     * @param request GetProcessInstanceWithExtraRequest
     * @return GetProcessInstanceWithExtraResponse
     */
    public GetProcessInstanceWithExtraResponse getProcessInstanceWithExtra(GetProcessInstanceWithExtraRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetProcessInstanceWithExtraHeaders headers = new GetProcessInstanceWithExtraHeaders();
        return this.getProcessInstanceWithExtraWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据模版code列表批量查询模板最新表单和流程配置</p>
     * 
     * @param tmpReq GetSchemaAndProcessconfigBatchllyRequest
     * @param headers GetSchemaAndProcessconfigBatchllyHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetSchemaAndProcessconfigBatchllyResponse
     */
    public GetSchemaAndProcessconfigBatchllyResponse getSchemaAndProcessconfigBatchllyWithOptions(GetSchemaAndProcessconfigBatchllyRequest tmpReq, GetSchemaAndProcessconfigBatchllyHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(tmpReq);
        GetSchemaAndProcessconfigBatchllyShrinkRequest request = new GetSchemaAndProcessconfigBatchllyShrinkRequest();
        com.aliyun.openapiutil.Client.convert(tmpReq, request);
        if (!com.aliyun.teautil.Common.isUnset(tmpReq.processCodes)) {
            request.processCodesShrink = com.aliyun.openapiutil.Client.arrayToStringWithSpecifiedStyle(tmpReq.processCodes, "processCodes", "json");
        }

        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.processCodesShrink)) {
            query.put("processCodes", request.processCodesShrink);
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
            new TeaPair("action", "GetSchemaAndProcessconfigBatchlly"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/processes/templates/batchQuery"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetSchemaAndProcessconfigBatchllyResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据模版code列表批量查询模板最新表单和流程配置</p>
     * 
     * @param request GetSchemaAndProcessconfigBatchllyRequest
     * @return GetSchemaAndProcessconfigBatchllyResponse
     */
    public GetSchemaAndProcessconfigBatchllyResponse getSchemaAndProcessconfigBatchlly(GetSchemaAndProcessconfigBatchllyRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSchemaAndProcessconfigBatchllyHeaders headers = new GetSchemaAndProcessconfigBatchllyHeaders();
        return this.getSchemaAndProcessconfigBatchllyWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>授权预览审批附件</p>
     * 
     * @param request GetSpaceWithDownloadAuthRequest
     * @param headers GetSpaceWithDownloadAuthHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetSpaceWithDownloadAuthResponse
     */
    public GetSpaceWithDownloadAuthResponse getSpaceWithDownloadAuthWithOptions(GetSpaceWithDownloadAuthRequest request, GetSpaceWithDownloadAuthHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.agentId)) {
            body.put("agentId", request.agentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileId)) {
            body.put("fileId", request.fileId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileIdList)) {
            body.put("fileIdList", request.fileIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processInstanceId)) {
            body.put("processInstanceId", request.processInstanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.withCommentAttatchment)) {
            body.put("withCommentAttatchment", request.withCommentAttatchment);
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
            new TeaPair("action", "GetSpaceWithDownloadAuth"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/processInstances/spaces/authPreview"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetSpaceWithDownloadAuthResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>授权预览审批附件</p>
     * 
     * @param request GetSpaceWithDownloadAuthRequest
     * @return GetSpaceWithDownloadAuthResponse
     */
    public GetSpaceWithDownloadAuthResponse getSpaceWithDownloadAuth(GetSpaceWithDownloadAuthRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSpaceWithDownloadAuthHeaders headers = new GetSpaceWithDownloadAuthHeaders();
        return this.getSpaceWithDownloadAuthWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取用户待审批数量</p>
     * 
     * @param request GetUserTodoTaskSumRequest
     * @param headers GetUserTodoTaskSumHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetUserTodoTaskSumResponse
     */
    public GetUserTodoTaskSumResponse getUserTodoTaskSumWithOptions(GetUserTodoTaskSumRequest request, GetUserTodoTaskSumHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetUserTodoTaskSum"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/processes/todoTasks/numbers"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetUserTodoTaskSumResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取用户待审批数量</p>
     * 
     * @param request GetUserTodoTaskSumRequest
     * @return GetUserTodoTaskSumResponse
     */
    public GetUserTodoTaskSumResponse getUserTodoTaskSum(GetUserTodoTaskSumRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetUserTodoTaskSumHeaders headers = new GetUserTodoTaskSumHeaders();
        return this.getUserTodoTaskSumWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>授权用户钉盘空间权限</p>
     * 
     * @param request GrantCspaceAuthorizationRequest
     * @param headers GrantCspaceAuthorizationHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GrantCspaceAuthorizationResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GrantCspaceAuthorization"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/spaces/authorize"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GrantCspaceAuthorizationResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>授权用户钉盘空间权限</p>
     * 
     * @param request GrantCspaceAuthorizationRequest
     * @return GrantCspaceAuthorizationResponse
     */
    public GrantCspaceAuthorizationResponse grantCspaceAuthorization(GrantCspaceAuthorizationRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GrantCspaceAuthorizationHeaders headers = new GrantCspaceAuthorizationHeaders();
        return this.grantCspaceAuthorizationWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>下载审批附件</p>
     * 
     * @param request GrantProcessInstanceForDownloadFileRequest
     * @param headers GrantProcessInstanceForDownloadFileHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GrantProcessInstanceForDownloadFileResponse
     */
    public GrantProcessInstanceForDownloadFileResponse grantProcessInstanceForDownloadFileWithOptions(GrantProcessInstanceForDownloadFileRequest request, GrantProcessInstanceForDownloadFileHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.fileId)) {
            body.put("fileId", request.fileId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processInstanceId)) {
            body.put("processInstanceId", request.processInstanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.withCommentAttatchment)) {
            body.put("withCommentAttatchment", request.withCommentAttatchment);
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
            new TeaPair("action", "GrantProcessInstanceForDownloadFile"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/processInstances/spaces/files/urls/download"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GrantProcessInstanceForDownloadFileResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>下载审批附件</p>
     * 
     * @param request GrantProcessInstanceForDownloadFileRequest
     * @return GrantProcessInstanceForDownloadFileResponse
     */
    public GrantProcessInstanceForDownloadFileResponse grantProcessInstanceForDownloadFile(GrantProcessInstanceForDownloadFileRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GrantProcessInstanceForDownloadFileHeaders headers = new GrantProcessInstanceForDownloadFileHeaders();
        return this.grantProcessInstanceForDownloadFileWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建或更新分组</p>
     * 
     * @param request InsertOrUpdateDirRequest
     * @param headers InsertOrUpdateDirHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return InsertOrUpdateDirResponse
     */
    public InsertOrUpdateDirResponse insertOrUpdateDirWithOptions(InsertOrUpdateDirRequest request, InsertOrUpdateDirHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizGroup)) {
            body.put("bizGroup", request.bizGroup);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name18n)) {
            body.put("name18n", request.name18n);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operateUserId)) {
            body.put("operateUserId", request.operateUserId);
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
            new TeaPair("action", "InsertOrUpdateDir"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/processCentres/directories"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new InsertOrUpdateDirResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建或更新分组</p>
     * 
     * @param request InsertOrUpdateDirRequest
     * @return InsertOrUpdateDirResponse
     */
    public InsertOrUpdateDirResponse insertOrUpdateDir(InsertOrUpdateDirRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        InsertOrUpdateDirHeaders headers = new InsertOrUpdateDirHeaders();
        return this.insertOrUpdateDirWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>应用安装</p>
     * 
     * @param request InstallAppRequest
     * @param headers InstallAppHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return InstallAppResponse
     */
    public InstallAppResponse installAppWithOptions(InstallAppRequest request, InstallAppHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizGroup)) {
            body.put("bizGroup", request.bizGroup);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.installOption)) {
            body.put("installOption", request.installOption);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourceDirName)) {
            body.put("sourceDirName", request.sourceDirName);
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
            new TeaPair("action", "InstallApp"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/processes/apps/install"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new InstallAppResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>应用安装</p>
     * 
     * @param request InstallAppRequest
     * @return InstallAppResponse
     */
    public InstallAppResponse installApp(InstallAppRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        InstallAppHeaders headers = new InstallAppHeaders();
        return this.installAppWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取审批实例ID列表</p>
     * 
     * @param request ListProcessInstanceIdsRequest
     * @param headers ListProcessInstanceIdsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListProcessInstanceIdsResponse
     */
    public ListProcessInstanceIdsResponse listProcessInstanceIdsWithOptions(ListProcessInstanceIdsRequest request, ListProcessInstanceIdsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            body.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            body.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processCode)) {
            body.put("processCode", request.processCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.statuses)) {
            body.put("statuses", request.statuses);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIds)) {
            body.put("userIds", request.userIds);
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
            new TeaPair("action", "ListProcessInstanceIds"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/processes/instanceIds/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListProcessInstanceIdsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取审批实例ID列表</p>
     * 
     * @param request ListProcessInstanceIdsRequest
     * @return ListProcessInstanceIdsResponse
     */
    public ListProcessInstanceIdsResponse listProcessInstanceIds(ListProcessInstanceIdsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListProcessInstanceIdsHeaders headers = new ListProcessInstanceIdsHeaders();
        return this.listProcessInstanceIdsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询用户待办事项</p>
     * 
     * @param request ListTodoWorkRecordsRequest
     * @param headers ListTodoWorkRecordsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListTodoWorkRecordsResponse
     */
    public ListTodoWorkRecordsResponse listTodoWorkRecordsWithOptions(ListTodoWorkRecordsRequest request, ListTodoWorkRecordsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            query.put("status", request.status);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ListTodoWorkRecords"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/workRecords/todoTasks"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListTodoWorkRecordsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询用户待办事项</p>
     * 
     * @param request ListTodoWorkRecordsRequest
     * @return ListTodoWorkRecordsResponse
     */
    public ListTodoWorkRecordsResponse listTodoWorkRecords(ListTodoWorkRecordsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListTodoWorkRecordsHeaders headers = new ListTodoWorkRecordsHeaders();
        return this.listTodoWorkRecordsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取指定用户可见的审批表单列表</p>
     * 
     * @param request ListUserVisibleBpmsProcessesRequest
     * @param headers ListUserVisibleBpmsProcessesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListUserVisibleBpmsProcessesResponse
     */
    public ListUserVisibleBpmsProcessesResponse listUserVisibleBpmsProcessesWithOptions(ListUserVisibleBpmsProcessesRequest request, ListUserVisibleBpmsProcessesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ListUserVisibleBpmsProcesses"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/processes/userVisibilities/templates"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListUserVisibleBpmsProcessesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取指定用户可见的审批表单列表</p>
     * 
     * @param request ListUserVisibleBpmsProcessesRequest
     * @return ListUserVisibleBpmsProcessesResponse
     */
    public ListUserVisibleBpmsProcessesResponse listUserVisibleBpmsProcesses(ListUserVisibleBpmsProcessesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListUserVisibleBpmsProcessesHeaders headers = new ListUserVisibleBpmsProcessesHeaders();
        return this.listUserVisibleBpmsProcessesWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>分页查询实例数据</p>
     * 
     * @param request PagesExportInstancesRequest
     * @param headers PagesExportInstancesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PagesExportInstancesResponse
     */
    public PagesExportInstancesResponse pagesExportInstancesWithOptions(PagesExportInstancesRequest request, PagesExportInstancesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.endTimeInMills)) {
            query.put("endTimeInMills", request.endTimeInMills);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderBy)) {
            query.put("orderBy", request.orderBy);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processCode)) {
            query.put("processCode", request.processCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTimeInMills)) {
            query.put("startTimeInMills", request.startTimeInMills);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            query.put("status", request.status);
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
            new TeaPair("action", "PagesExportInstances"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/instances/datas"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PagesExportInstancesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>分页查询实例数据</p>
     * 
     * @param request PagesExportInstancesRequest
     * @return PagesExportInstancesResponse
     */
    public PagesExportInstancesResponse pagesExportInstances(PagesExportInstancesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PagesExportInstancesHeaders headers = new PagesExportInstancesHeaders();
        return this.pagesExportInstancesWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量同意或拒绝审批任务(OA高级版专享接口)</p>
     * 
     * @param request PremiumBatchExecuteProcessInstancesRequest
     * @param headers PremiumBatchExecuteProcessInstancesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PremiumBatchExecuteProcessInstancesResponse
     */
    public PremiumBatchExecuteProcessInstancesResponse premiumBatchExecuteProcessInstancesWithOptions(PremiumBatchExecuteProcessInstancesRequest request, PremiumBatchExecuteProcessInstancesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.actionerUserId)) {
            body.put("actionerUserId", request.actionerUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.remark)) {
            body.put("remark", request.remark);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.result)) {
            body.put("result", request.result);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskInfoList)) {
            body.put("taskInfoList", request.taskInfoList);
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
            new TeaPair("action", "PremiumBatchExecuteProcessInstances"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/premium/processInstances/batchExecute"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PremiumBatchExecuteProcessInstancesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量同意或拒绝审批任务(OA高级版专享接口)</p>
     * 
     * @param request PremiumBatchExecuteProcessInstancesRequest
     * @return PremiumBatchExecuteProcessInstancesResponse
     */
    public PremiumBatchExecuteProcessInstancesResponse premiumBatchExecuteProcessInstances(PremiumBatchExecuteProcessInstancesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PremiumBatchExecuteProcessInstancesHeaders headers = new PremiumBatchExecuteProcessInstancesHeaders();
        return this.premiumBatchExecuteProcessInstancesWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除业务分组(高级版专享接口)</p>
     * 
     * @param request PremiumDelDirRequest
     * @param headers PremiumDelDirHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PremiumDelDirResponse
     */
    public PremiumDelDirResponse premiumDelDirWithOptions(PremiumDelDirRequest request, PremiumDelDirHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dirId)) {
            query.put("dirId", request.dirId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operateUserId)) {
            query.put("operateUserId", request.operateUserId);
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
            new TeaPair("action", "PremiumDelDir"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/premium/processCentres/directories"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PremiumDelDirResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除业务分组(高级版专享接口)</p>
     * 
     * @param request PremiumDelDirRequest
     * @return PremiumDelDirResponse
     */
    public PremiumDelDirResponse premiumDelDir(PremiumDelDirRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PremiumDelDirHeaders headers = new PremiumDelDirHeaders();
        return this.premiumDelDirWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询审批中心已处理任务列表(OA高级版专享接口)</p>
     * 
     * @param request PremiumGetDoneTasksRequest
     * @param headers PremiumGetDoneTasksHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PremiumGetDoneTasksResponse
     */
    public PremiumGetDoneTasksResponse premiumGetDoneTasksWithOptions(PremiumGetDoneTasksRequest request, PremiumGetDoneTasksHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "PremiumGetDoneTasks"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/premium/processCentres/doneTasks"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PremiumGetDoneTasksResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询审批中心已处理任务列表(OA高级版专享接口)</p>
     * 
     * @param request PremiumGetDoneTasksRequest
     * @return PremiumGetDoneTasksResponse
     */
    public PremiumGetDoneTasksResponse premiumGetDoneTasks(PremiumGetDoneTasksRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PremiumGetDoneTasksHeaders headers = new PremiumGetDoneTasksHeaders();
        return this.premiumGetDoneTasksWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取字段修改历史(高级版专享接口)</p>
     * 
     * @param request PremiumGetFieldModifiedHistoryRequest
     * @param headers PremiumGetFieldModifiedHistoryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PremiumGetFieldModifiedHistoryResponse
     */
    public PremiumGetFieldModifiedHistoryResponse premiumGetFieldModifiedHistoryWithOptions(PremiumGetFieldModifiedHistoryRequest request, PremiumGetFieldModifiedHistoryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.fieldId)) {
            body.put("fieldId", request.fieldId);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "PremiumGetFieldModifiedHistory"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/premium/processes/fields/modifiedRecords/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PremiumGetFieldModifiedHistoryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取字段修改历史(高级版专享接口)</p>
     * 
     * @param request PremiumGetFieldModifiedHistoryRequest
     * @return PremiumGetFieldModifiedHistoryResponse
     */
    public PremiumGetFieldModifiedHistoryResponse premiumGetFieldModifiedHistory(PremiumGetFieldModifiedHistoryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PremiumGetFieldModifiedHistoryHeaders headers = new PremiumGetFieldModifiedHistoryHeaders();
        return this.premiumGetFieldModifiedHistoryWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询审批中心我收到的实例列表(OA高级版专享接口)</p>
     * 
     * @param request PremiumGetNoticedInstancesRequest
     * @param headers PremiumGetNoticedInstancesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PremiumGetNoticedInstancesResponse
     */
    public PremiumGetNoticedInstancesResponse premiumGetNoticedInstancesWithOptions(PremiumGetNoticedInstancesRequest request, PremiumGetNoticedInstancesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "PremiumGetNoticedInstances"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/premium/processCentres/noticedInstances"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PremiumGetNoticedInstancesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询审批中心我收到的实例列表(OA高级版专享接口)</p>
     * 
     * @param request PremiumGetNoticedInstancesRequest
     * @return PremiumGetNoticedInstancesResponse
     */
    public PremiumGetNoticedInstancesResponse premiumGetNoticedInstances(PremiumGetNoticedInstancesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PremiumGetNoticedInstancesHeaders headers = new PremiumGetNoticedInstancesHeaders();
        return this.premiumGetNoticedInstancesWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据processCode分页获取审批流程数据(高级版专享接口)</p>
     * 
     * @param request PremiumGetProcessInstancesRequest
     * @param headers PremiumGetProcessInstancesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PremiumGetProcessInstancesResponse
     */
    public PremiumGetProcessInstancesResponse premiumGetProcessInstancesWithOptions(PremiumGetProcessInstancesRequest request, PremiumGetProcessInstancesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "PremiumGetProcessInstances"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/premium/processes/pages/instances"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PremiumGetProcessInstancesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据processCode分页获取审批流程数据(高级版专享接口)</p>
     * 
     * @param request PremiumGetProcessInstancesRequest
     * @return PremiumGetProcessInstancesResponse
     */
    public PremiumGetProcessInstancesResponse premiumGetProcessInstances(PremiumGetProcessInstancesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PremiumGetProcessInstancesHeaders headers = new PremiumGetProcessInstancesHeaders();
        return this.premiumGetProcessInstancesWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询审批中心已发起实例列表(OA高级版专享接口)</p>
     * 
     * @param request PremiumGetSubmittedInstancesRequest
     * @param headers PremiumGetSubmittedInstancesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PremiumGetSubmittedInstancesResponse
     */
    public PremiumGetSubmittedInstancesResponse premiumGetSubmittedInstancesWithOptions(PremiumGetSubmittedInstancesRequest request, PremiumGetSubmittedInstancesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "PremiumGetSubmittedInstances"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/premium/processCentres/submittedInstances"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PremiumGetSubmittedInstancesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询审批中心已发起实例列表(OA高级版专享接口)</p>
     * 
     * @param request PremiumGetSubmittedInstancesRequest
     * @return PremiumGetSubmittedInstancesResponse
     */
    public PremiumGetSubmittedInstancesResponse premiumGetSubmittedInstances(PremiumGetSubmittedInstancesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PremiumGetSubmittedInstancesHeaders headers = new PremiumGetSubmittedInstancesHeaders();
        return this.premiumGetSubmittedInstancesWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询审批中心待处理任务列表(OA高级版专享接口)</p>
     * 
     * @param request PremiumGetTodoTasksRequest
     * @param headers PremiumGetTodoTasksHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PremiumGetTodoTasksResponse
     */
    public PremiumGetTodoTasksResponse premiumGetTodoTasksWithOptions(PremiumGetTodoTasksRequest request, PremiumGetTodoTasksHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "PremiumGetTodoTasks"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/premium/processCentres/todoTasks"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PremiumGetTodoTasksResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询审批中心待处理任务列表(OA高级版专享接口)</p>
     * 
     * @param request PremiumGetTodoTasksRequest
     * @return PremiumGetTodoTasksResponse
     */
    public PremiumGetTodoTasksResponse premiumGetTodoTasks(PremiumGetTodoTasksRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PremiumGetTodoTasksHeaders headers = new PremiumGetTodoTasksHeaders();
        return this.premiumGetTodoTasksWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建或更新分组(高级版专享接口)</p>
     * 
     * @param request PremiumInsertOrUpdateDirRequest
     * @param headers PremiumInsertOrUpdateDirHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PremiumInsertOrUpdateDirResponse
     */
    public PremiumInsertOrUpdateDirResponse premiumInsertOrUpdateDirWithOptions(PremiumInsertOrUpdateDirRequest request, PremiumInsertOrUpdateDirHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizGroup)) {
            body.put("bizGroup", request.bizGroup);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name18n)) {
            body.put("name18n", request.name18n);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operateUserId)) {
            body.put("operateUserId", request.operateUserId);
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
            new TeaPair("action", "PremiumInsertOrUpdateDir"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/premium/processCentres/directories"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PremiumInsertOrUpdateDirResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建或更新分组(高级版专享接口)</p>
     * 
     * @param request PremiumInsertOrUpdateDirRequest
     * @return PremiumInsertOrUpdateDirResponse
     */
    public PremiumInsertOrUpdateDirResponse premiumInsertOrUpdateDir(PremiumInsertOrUpdateDirRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PremiumInsertOrUpdateDirHeaders headers = new PremiumInsertOrUpdateDirHeaders();
        return this.premiumInsertOrUpdateDirWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>流程转交待处理任务查询(高级版专享接口)</p>
     * 
     * @param request PremiumQueryTodoTasksByManagerRequest
     * @param headers PremiumQueryTodoTasksByManagerHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PremiumQueryTodoTasksByManagerResponse
     */
    public PremiumQueryTodoTasksByManagerResponse premiumQueryTodoTasksByManagerWithOptions(PremiumQueryTodoTasksByManagerRequest request, PremiumQueryTodoTasksByManagerHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.actionerUserId)) {
            query.put("actionerUserId", request.actionerUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.managerUserId)) {
            query.put("managerUserId", request.managerUserId);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "PremiumQueryTodoTasksByManager"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/premium/tasks/todoTasks"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PremiumQueryTodoTasksByManagerResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>流程转交待处理任务查询(高级版专享接口)</p>
     * 
     * @param request PremiumQueryTodoTasksByManagerRequest
     * @return PremiumQueryTodoTasksByManagerResponse
     */
    public PremiumQueryTodoTasksByManagerResponse premiumQueryTodoTasksByManager(PremiumQueryTodoTasksByManagerRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PremiumQueryTodoTasksByManagerHeaders headers = new PremiumQueryTodoTasksByManagerHeaders();
        return this.premiumQueryTodoTasksByManagerWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量流程审批任务转交(高级版专享接口)</p>
     * 
     * @param request PremiumRedirectTasksByManagerRequest
     * @param headers PremiumRedirectTasksByManagerHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PremiumRedirectTasksByManagerResponse
     */
    public PremiumRedirectTasksByManagerResponse premiumRedirectTasksByManagerWithOptions(PremiumRedirectTasksByManagerRequest request, PremiumRedirectTasksByManagerHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.handoverUserId)) {
            body.put("handoverUserId", request.handoverUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.managerUserId)) {
            body.put("managerUserId", request.managerUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskIds)) {
            body.put("taskIds", request.taskIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.transfereeUserId)) {
            body.put("transfereeUserId", request.transfereeUserId);
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
            new TeaPair("action", "PremiumRedirectTasksByManager"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/premium/tasks/batchRedirect"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PremiumRedirectTasksByManagerResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量流程审批任务转交(高级版专享接口)</p>
     * 
     * @param request PremiumRedirectTasksByManagerRequest
     * @return PremiumRedirectTasksByManagerResponse
     */
    public PremiumRedirectTasksByManagerResponse premiumRedirectTasksByManager(PremiumRedirectTasksByManagerRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PremiumRedirectTasksByManagerHeaders headers = new PremiumRedirectTasksByManagerHeaders();
        return this.premiumRedirectTasksByManagerWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建或更新流程中心外部集成模板(高级版专享接口)</p>
     * 
     * @param request PremiumSaveIntegratedProcessRequest
     * @param headers PremiumSaveIntegratedProcessHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PremiumSaveIntegratedProcessResponse
     */
    public PremiumSaveIntegratedProcessResponse premiumSaveIntegratedProcessWithOptions(PremiumSaveIntegratedProcessRequest request, PremiumSaveIntegratedProcessHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        if (!com.aliyun.teautil.Common.isUnset(request.processFeatureConfig)) {
            body.put("processFeatureConfig", request.processFeatureConfig);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateConfig)) {
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "PremiumSaveIntegratedProcess"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/premium/processCentres/schemas"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PremiumSaveIntegratedProcessResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建或更新流程中心外部集成模板(高级版专享接口)</p>
     * 
     * @param request PremiumSaveIntegratedProcessRequest
     * @return PremiumSaveIntegratedProcessResponse
     */
    public PremiumSaveIntegratedProcessResponse premiumSaveIntegratedProcess(PremiumSaveIntegratedProcessRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PremiumSaveIntegratedProcessHeaders headers = new PremiumSaveIntegratedProcessHeaders();
        return this.premiumSaveIntegratedProcessWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建流程中心外部集成实例(高级版专享接口)</p>
     * 
     * @param request PremiumSaveIntegratedProcessInstanceRequest
     * @param headers PremiumSaveIntegratedProcessInstanceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PremiumSaveIntegratedProcessInstanceResponse
     */
    public PremiumSaveIntegratedProcessInstanceResponse premiumSaveIntegratedProcessInstanceWithOptions(PremiumSaveIntegratedProcessInstanceRequest request, PremiumSaveIntegratedProcessInstanceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizData)) {
            body.put("bizData", request.bizData);
        }

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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "PremiumSaveIntegratedProcessInstance"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/premium/processCentres/instances"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PremiumSaveIntegratedProcessInstanceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建流程中心外部集成实例(高级版专享接口)</p>
     * 
     * @param request PremiumSaveIntegratedProcessInstanceRequest
     * @return PremiumSaveIntegratedProcessInstanceResponse
     */
    public PremiumSaveIntegratedProcessInstanceResponse premiumSaveIntegratedProcessInstance(PremiumSaveIntegratedProcessInstanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PremiumSaveIntegratedProcessInstanceHeaders headers = new PremiumSaveIntegratedProcessInstanceHeaders();
        return this.premiumSaveIntegratedProcessInstanceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建流程中心外部集成待处理任务(高级版专享接口)</p>
     * 
     * @param request PremiumSaveIntegratedTaskRequest
     * @param headers PremiumSaveIntegratedTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PremiumSaveIntegratedTaskResponse
     */
    public PremiumSaveIntegratedTaskResponse premiumSaveIntegratedTaskWithOptions(PremiumSaveIntegratedTaskRequest request, PremiumSaveIntegratedTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.activityId)) {
            body.put("activityId", request.activityId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.featureConfig)) {
            body.put("featureConfig", request.featureConfig);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "PremiumSaveIntegratedTask"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/premium/processCentres/tasks"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PremiumSaveIntegratedTaskResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建流程中心外部集成待处理任务(高级版专享接口)</p>
     * 
     * @param request PremiumSaveIntegratedTaskRequest
     * @return PremiumSaveIntegratedTaskResponse
     */
    public PremiumSaveIntegratedTaskResponse premiumSaveIntegratedTask(PremiumSaveIntegratedTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PremiumSaveIntegratedTaskHeaders headers = new PremiumSaveIntegratedTaskHeaders();
        return this.premiumSaveIntegratedTaskWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>审批流程预测</p>
     * 
     * @param request ProcessForecastRequest
     * @param headers ProcessForecastHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ProcessForecastResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ProcessForecast"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/processes/forecast"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ProcessForecastResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>审批流程预测</p>
     * 
     * @param request ProcessForecastRequest
     * @return ProcessForecastResponse
     */
    public ProcessForecastResponse processForecast(ProcessForecastRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ProcessForecastHeaders headers = new ProcessForecastHeaders();
        return this.processForecastWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据processCode分页获取表单数据</p>
     * 
     * @param request QueryAllFormInstancesRequest
     * @param headers QueryAllFormInstancesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryAllFormInstancesResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryAllFormInstances"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/forms/pages/instances"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryAllFormInstancesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据processCode分页获取表单数据</p>
     * 
     * @param request QueryAllFormInstancesRequest
     * @return QueryAllFormInstancesResponse
     */
    public QueryAllFormInstancesResponse queryAllFormInstances(QueryAllFormInstancesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryAllFormInstancesHeaders headers = new QueryAllFormInstancesHeaders();
        return this.queryAllFormInstancesWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量查询审批流程实例</p>
     * 
     * @param request QueryAllProcessInstancesRequest
     * @param headers QueryAllProcessInstancesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryAllProcessInstancesResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryAllProcessInstances"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/processes/pages/instances"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryAllProcessInstancesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量查询审批流程实例</p>
     * 
     * @param request QueryAllProcessInstancesRequest
     * @return QueryAllProcessInstancesResponse
     */
    public QueryAllProcessInstancesResponse queryAllProcessInstances(QueryAllProcessInstancesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryAllProcessInstancesHeaders headers = new QueryAllProcessInstancesHeaders();
        return this.queryAllProcessInstancesWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据业务标识查询表单描述信息</p>
     * 
     * @param request QueryFormByBizTypeRequest
     * @param headers QueryFormByBizTypeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryFormByBizTypeResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryFormByBizType"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/forms/forminfos/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryFormByBizTypeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据业务标识查询表单描述信息</p>
     * 
     * @param request QueryFormByBizTypeRequest
     * @return QueryFormByBizTypeResponse
     */
    public QueryFormByBizTypeResponse queryFormByBizType(QueryFormByBizTypeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryFormByBizTypeHeaders headers = new QueryFormByBizTypeHeaders();
        return this.queryFormByBizTypeWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询数据表单</p>
     * 
     * @param request QueryFormInstanceRequest
     * @param headers QueryFormInstanceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryFormInstanceResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryFormInstance"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/forms/instances"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryFormInstanceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询数据表单</p>
     * 
     * @param request QueryFormInstanceRequest
     * @return QueryFormInstanceResponse
     */
    public QueryFormInstanceResponse queryFormInstance(QueryFormInstanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryFormInstanceHeaders headers = new QueryFormInstanceHeaders();
        return this.queryFormInstanceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询通过流程中心集成的OA审批任务</p>
     * 
     * @param request QueryIntegratedTodoTaskRequest
     * @param headers QueryIntegratedTodoTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryIntegratedTodoTaskResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryIntegratedTodoTask"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/processCentres/todoTasks"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryIntegratedTodoTaskResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询通过流程中心集成的OA审批任务</p>
     * 
     * @param request QueryIntegratedTodoTaskRequest
     * @return QueryIntegratedTodoTaskResponse
     */
    public QueryIntegratedTodoTaskResponse queryIntegratedTodoTask(QueryIntegratedTodoTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryIntegratedTodoTaskHeaders headers = new QueryIntegratedTodoTaskHeaders();
        return this.queryIntegratedTodoTaskWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据业务标识查询模板</p>
     * 
     * @param request QueryProcessByBizCategoryIdRequest
     * @param headers QueryProcessByBizCategoryIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryProcessByBizCategoryIdResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryProcessByBizCategoryId"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/processes/categories/templates"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryProcessByBizCategoryIdResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据业务标识查询模板</p>
     * 
     * @param request QueryProcessByBizCategoryIdRequest
     * @return QueryProcessByBizCategoryIdResponse
     */
    public QueryProcessByBizCategoryIdResponse queryProcessByBizCategoryId(QueryProcessByBizCategoryIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryProcessByBizCategoryIdHeaders headers = new QueryProcessByBizCategoryIdHeaders();
        return this.queryProcessByBizCategoryIdWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>蓝凌获取schema和流程信息</p>
     * 
     * @param request QuerySchemaAndProcessRequest
     * @param headers QuerySchemaAndProcessHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QuerySchemaAndProcessResponse
     */
    public QuerySchemaAndProcessResponse querySchemaAndProcessWithOptions(QuerySchemaAndProcessRequest request, QuerySchemaAndProcessHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QuerySchemaAndProcess"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/forms/schemaAndProcess"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QuerySchemaAndProcessResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>蓝凌获取schema和流程信息</p>
     * 
     * @param request QuerySchemaAndProcessRequest
     * @return QuerySchemaAndProcessResponse
     */
    public QuerySchemaAndProcessResponse querySchemaAndProcess(QuerySchemaAndProcessRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QuerySchemaAndProcessHeaders headers = new QuerySchemaAndProcessHeaders();
        return this.querySchemaAndProcessWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>通过 processCode 获取表单 schema 信息</p>
     * 
     * @param request QuerySchemaByProcessCodeRequest
     * @param headers QuerySchemaByProcessCodeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QuerySchemaByProcessCodeResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QuerySchemaByProcessCode"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/forms/schemas/processCodes"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QuerySchemaByProcessCodeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>通过 processCode 获取表单 schema 信息</p>
     * 
     * @param request QuerySchemaByProcessCodeRequest
     * @return QuerySchemaByProcessCodeResponse
     */
    public QuerySchemaByProcessCodeResponse querySchemaByProcessCode(QuerySchemaByProcessCodeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QuerySchemaByProcessCodeHeaders headers = new QuerySchemaByProcessCodeHeaders();
        return this.querySchemaByProcessCodeWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>转交OA审批任务</p>
     * 
     * @param request RedirectWorkflowTaskRequest
     * @param headers RedirectWorkflowTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RedirectWorkflowTaskResponse
     */
    public RedirectWorkflowTaskResponse redirectWorkflowTaskWithOptions(RedirectWorkflowTaskRequest request, RedirectWorkflowTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.actionName)) {
            body.put("actionName", request.actionName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.file)) {
            body.put("file", request.file);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operateUserId)) {
            body.put("operateUserId", request.operateUserId);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "RedirectWorkflowTask"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/tasks/redirect"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RedirectWorkflowTaskResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>转交OA审批任务</p>
     * 
     * @param request RedirectWorkflowTaskRequest
     * @return RedirectWorkflowTaskResponse
     */
    public RedirectWorkflowTaskResponse redirectWorkflowTask(RedirectWorkflowTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RedirectWorkflowTaskHeaders headers = new RedirectWorkflowTaskHeaders();
        return this.redirectWorkflowTaskWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建实例</p>
     * 
     * @param request SaveIntegratedInstanceRequest
     * @param headers SaveIntegratedInstanceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SaveIntegratedInstanceResponse
     */
    public SaveIntegratedInstanceResponse saveIntegratedInstanceWithOptions(SaveIntegratedInstanceRequest request, SaveIntegratedInstanceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizData)) {
            body.put("bizData", request.bizData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.featureConfig)) {
            body.put("featureConfig", request.featureConfig);
        }

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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "SaveIntegratedInstance"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/processCentres/instances"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SaveIntegratedInstanceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建实例</p>
     * 
     * @param request SaveIntegratedInstanceRequest
     * @return SaveIntegratedInstanceResponse
     */
    public SaveIntegratedInstanceResponse saveIntegratedInstance(SaveIntegratedInstanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SaveIntegratedInstanceHeaders headers = new SaveIntegratedInstanceHeaders();
        return this.saveIntegratedInstanceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建或更新审批模板</p>
     * 
     * @param request SaveProcessRequest
     * @param headers SaveProcessHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SaveProcessResponse
     */
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

        if (!com.aliyun.teautil.Common.isUnset(request.processFeatureConfig)) {
            body.put("processFeatureConfig", request.processFeatureConfig);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateConfig)) {
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "SaveProcess"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/processCentres/schemas"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SaveProcessResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建或更新审批模板</p>
     * 
     * @param request SaveProcessRequest
     * @return SaveProcessResponse
     */
    public SaveProcessResponse saveProcess(SaveProcessRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SaveProcessHeaders headers = new SaveProcessHeaders();
        return this.saveProcessWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建审批实例</p>
     * 
     * @param request StartProcessInstanceRequest
     * @param headers StartProcessInstanceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return StartProcessInstanceResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "StartProcessInstance"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/processInstances"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new StartProcessInstanceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建审批实例</p>
     * 
     * @param request StartProcessInstanceRequest
     * @return StartProcessInstanceResponse
     */
    public StartProcessInstanceResponse startProcessInstance(StartProcessInstanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        StartProcessInstanceHeaders headers = new StartProcessInstanceHeaders();
        return this.startProcessInstanceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>撤销审批实例</p>
     * 
     * @param request TerminateProcessInstanceRequest
     * @param headers TerminateProcessInstanceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return TerminateProcessInstanceResponse
     */
    public TerminateProcessInstanceResponse terminateProcessInstanceWithOptions(TerminateProcessInstanceRequest request, TerminateProcessInstanceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.isSystem)) {
            body.put("isSystem", request.isSystem);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatingUserId)) {
            body.put("operatingUserId", request.operatingUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processInstanceId)) {
            body.put("processInstanceId", request.processInstanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.remark)) {
            body.put("remark", request.remark);
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
            new TeaPair("action", "TerminateProcessInstance"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/processInstances/terminate"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new TerminateProcessInstanceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>撤销审批实例</p>
     * 
     * @param request TerminateProcessInstanceRequest
     * @return TerminateProcessInstanceResponse
     */
    public TerminateProcessInstanceResponse terminateProcessInstance(TerminateProcessInstanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        TerminateProcessInstanceHeaders headers = new TerminateProcessInstanceHeaders();
        return this.terminateProcessInstanceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>流程转交待处理任务查询</p>
     * 
     * @param request TodoTasksRequest
     * @param headers TodoTasksHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return TodoTasksResponse
     */
    public TodoTasksResponse todoTasksWithOptions(TodoTasksRequest request, TodoTasksHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.actionerUserId)) {
            query.put("actionerUserId", request.actionerUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.managerUserId)) {
            query.put("managerUserId", request.managerUserId);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "TodoTasks"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/tasks/todoTasks"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new TodoTasksResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>流程转交待处理任务查询</p>
     * 
     * @param request TodoTasksRequest
     * @return TodoTasksResponse
     */
    public TodoTasksResponse todoTasks(TodoTasksRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        TodoTasksHeaders headers = new TodoTasksHeaders();
        return this.todoTasksWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新流程中心任务状态</p>
     * 
     * @param request UpdateIntegratedTaskRequest
     * @param headers UpdateIntegratedTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateIntegratedTaskResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UpdateIntegratedTask"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/processCentres/tasks"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateIntegratedTaskResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新流程中心任务状态</p>
     * 
     * @param request UpdateIntegratedTaskRequest
     * @return UpdateIntegratedTaskResponse
     */
    public UpdateIntegratedTaskResponse updateIntegratedTask(UpdateIntegratedTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateIntegratedTaskHeaders headers = new UpdateIntegratedTaskHeaders();
        return this.updateIntegratedTaskWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新实例状态</p>
     * 
     * @param request UpdateProcessInstanceRequest
     * @param headers UpdateProcessInstanceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateProcessInstanceResponse
     */
    public UpdateProcessInstanceResponse updateProcessInstanceWithOptions(UpdateProcessInstanceRequest request, UpdateProcessInstanceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.notifiers)) {
            body.put("notifiers", request.notifiers);
        }

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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UpdateProcessInstance"),
            new TeaPair("version", "workflow_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workflow/processCentres/instances"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateProcessInstanceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新实例状态</p>
     * 
     * @param request UpdateProcessInstanceRequest
     * @return UpdateProcessInstanceResponse
     */
    public UpdateProcessInstanceResponse updateProcessInstance(UpdateProcessInstanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateProcessInstanceHeaders headers = new UpdateProcessInstanceHeaders();
        return this.updateProcessInstanceWithOptions(request, headers, runtime);
    }
}
