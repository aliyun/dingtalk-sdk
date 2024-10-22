// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalktodo_e_e_1_0.models.*;

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
     * <p>创建企业待办</p>
     * 
     * @param request CreateEnterpriseTodoTaskRequest
     * @param headers CreateEnterpriseTodoTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateEnterpriseTodoTaskResponse
     */
    public CreateEnterpriseTodoTaskResponse createEnterpriseTodoTaskWithOptions(CreateEnterpriseTodoTaskRequest request, CreateEnterpriseTodoTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCategoryId)) {
            body.put("bizCategoryId", request.bizCategoryId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.customFields)) {
            body.put("customFields", request.customFields);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.detailUrl)) {
            body.put("detailUrl", request.detailUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dueTime)) {
            body.put("dueTime", request.dueTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.executorIds)) {
            body.put("executorIds", request.executorIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.notifyConfigs)) {
            body.put("notifyConfigs", request.notifyConfigs);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            body.put("operatorId", request.operatorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.priority)) {
            body.put("priority", request.priority);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourceId)) {
            body.put("sourceId", request.sourceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourceTitle)) {
            body.put("sourceTitle", request.sourceTitle);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subject)) {
            body.put("subject", request.subject);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.trackerIds)) {
            body.put("trackerIds", request.trackerIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            body.put("type", request.type);
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
            new TeaPair("action", "CreateEnterpriseTodoTask"),
            new TeaPair("version", "todoEE_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/todoEE/users/tasks"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateEnterpriseTodoTaskResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建企业待办</p>
     * 
     * @param request CreateEnterpriseTodoTaskRequest
     * @return CreateEnterpriseTodoTaskResponse
     */
    public CreateEnterpriseTodoTaskResponse createEnterpriseTodoTask(CreateEnterpriseTodoTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateEnterpriseTodoTaskHeaders headers = new CreateEnterpriseTodoTaskHeaders();
        return this.createEnterpriseTodoTaskWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除应用类目信息</p>
     * 
     * @param request DeleteCategorySourceConfigRequest
     * @param headers DeleteCategorySourceConfigHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteCategorySourceConfigResponse
     */
    public DeleteCategorySourceConfigResponse deleteCategorySourceConfigWithOptions(DeleteCategorySourceConfigRequest request, DeleteCategorySourceConfigHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCategoryId)) {
            body.put("bizCategoryId", request.bizCategoryId);
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
            new TeaPair("action", "DeleteCategorySourceConfig"),
            new TeaPair("version", "todoEE_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/todoEE/apps/categories/sourceConfigs/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteCategorySourceConfigResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除应用类目信息</p>
     * 
     * @param request DeleteCategorySourceConfigRequest
     * @return DeleteCategorySourceConfigResponse
     */
    public DeleteCategorySourceConfigResponse deleteCategorySourceConfig(DeleteCategorySourceConfigRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteCategorySourceConfigHeaders headers = new DeleteCategorySourceConfigHeaders();
        return this.deleteCategorySourceConfigWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除待办</p>
     * 
     * @param request DeleteTodoEETaskRequest
     * @param headers DeleteTodoEETaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteTodoEETaskResponse
     */
    public DeleteTodoEETaskResponse deleteTodoEETaskWithOptions(DeleteTodoEETaskRequest request, DeleteTodoEETaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.taskIds)) {
            body.put("taskIds", request.taskIds);
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
            new TeaPair("action", "DeleteTodoEETask"),
            new TeaPair("version", "todoEE_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/todoEE/users/tasks/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteTodoEETaskResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除待办</p>
     * 
     * @param request DeleteTodoEETaskRequest
     * @return DeleteTodoEETaskResponse
     */
    public DeleteTodoEETaskResponse deleteTodoEETask(DeleteTodoEETaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteTodoEETaskHeaders headers = new DeleteTodoEETaskHeaders();
        return this.deleteTodoEETaskWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询应用注册类目信息列表</p>
     * 
     * @param request GetCategorySourceConfigListRequest
     * @param headers GetCategorySourceConfigListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetCategorySourceConfigListResponse
     */
    public GetCategorySourceConfigListResponse getCategorySourceConfigListWithOptions(GetCategorySourceConfigListRequest request, GetCategorySourceConfigListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
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
            new TeaPair("action", "GetCategorySourceConfigList"),
            new TeaPair("version", "todoEE_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/todoEE/apps/categories/sourceConfigs/lists/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetCategorySourceConfigListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询应用注册类目信息列表</p>
     * 
     * @param request GetCategorySourceConfigListRequest
     * @return GetCategorySourceConfigListResponse
     */
    public GetCategorySourceConfigListResponse getCategorySourceConfigList(GetCategorySourceConfigListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCategorySourceConfigListHeaders headers = new GetCategorySourceConfigListHeaders();
        return this.getCategorySourceConfigListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询用户待办列表</p>
     * 
     * @param request GetUserTaskListRequest
     * @param headers GetUserTaskListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetUserTaskListResponse
     */
    public GetUserTaskListResponse getUserTaskListWithOptions(GetUserTaskListRequest request, GetUserTaskListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.done)) {
            body.put("done", request.done);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            body.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            body.put("type", request.type);
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
            new TeaPair("action", "GetUserTaskList"),
            new TeaPair("version", "todoEE_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/todoEE/users/tasks/list"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetUserTaskListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询用户待办列表</p>
     * 
     * @param request GetUserTaskListRequest
     * @return GetUserTaskListResponse
     */
    public GetUserTaskListResponse getUserTaskList(GetUserTaskListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetUserTaskListHeaders headers = new GetUserTaskListHeaders();
        return this.getUserTaskListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>注册应用类目信息</p>
     * 
     * @param request RegisterCategorySourceConfigRequest
     * @param headers RegisterCategorySourceConfigHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RegisterCategorySourceConfigResponse
     */
    public RegisterCategorySourceConfigResponse registerCategorySourceConfigWithOptions(RegisterCategorySourceConfigRequest request, RegisterCategorySourceConfigHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCategoryId)) {
            body.put("bizCategoryId", request.bizCategoryId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizCategoryName)) {
            body.put("bizCategoryName", request.bizCategoryName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            body.put("operatorId", request.operatorId);
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
            new TeaPair("action", "RegisterCategorySourceConfig"),
            new TeaPair("version", "todoEE_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/todoEE/apps/categories/sourceConfigs/register"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RegisterCategorySourceConfigResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>注册应用类目信息</p>
     * 
     * @param request RegisterCategorySourceConfigRequest
     * @return RegisterCategorySourceConfigResponse
     */
    public RegisterCategorySourceConfigResponse registerCategorySourceConfig(RegisterCategorySourceConfigRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RegisterCategorySourceConfigHeaders headers = new RegisterCategorySourceConfigHeaders();
        return this.registerCategorySourceConfigWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>修改应用类目注册信息</p>
     * 
     * @param request UpdateCategorySourceConfigRequest
     * @param headers UpdateCategorySourceConfigHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateCategorySourceConfigResponse
     */
    public UpdateCategorySourceConfigResponse updateCategorySourceConfigWithOptions(UpdateCategorySourceConfigRequest request, UpdateCategorySourceConfigHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCategoryId)) {
            body.put("bizCategoryId", request.bizCategoryId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizCategoryName)) {
            body.put("bizCategoryName", request.bizCategoryName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            body.put("operatorId", request.operatorId);
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
            new TeaPair("action", "UpdateCategorySourceConfig"),
            new TeaPair("version", "todoEE_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/todoEE/apps/categories/sourceConfigs"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateCategorySourceConfigResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>修改应用类目注册信息</p>
     * 
     * @param request UpdateCategorySourceConfigRequest
     * @return UpdateCategorySourceConfigResponse
     */
    public UpdateCategorySourceConfigResponse updateCategorySourceConfig(UpdateCategorySourceConfigRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateCategorySourceConfigHeaders headers = new UpdateCategorySourceConfigHeaders();
        return this.updateCategorySourceConfigWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新待办信息</p>
     * 
     * @param request UpdateTaskRequest
     * @param headers UpdateTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateTaskResponse
     */
    public UpdateTaskResponse updateTaskWithOptions(UpdateTaskRequest request, UpdateTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.done)) {
            body.put("done", request.done);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dueTime)) {
            body.put("dueTime", request.dueTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.executorIds)) {
            body.put("executorIds", request.executorIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subject)) {
            body.put("subject", request.subject);
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
            new TeaPair("action", "UpdateTask"),
            new TeaPair("version", "todoEE_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/todoEE/users/tasks/infos"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateTaskResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新待办信息</p>
     * 
     * @param request UpdateTaskRequest
     * @return UpdateTaskResponse
     */
    public UpdateTaskResponse updateTask(UpdateTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateTaskHeaders headers = new UpdateTaskHeaders();
        return this.updateTaskWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新用户的待办状态</p>
     * 
     * @param request UpdateUserTaskStatusRequest
     * @param headers UpdateUserTaskStatusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateUserTaskStatusResponse
     */
    public UpdateUserTaskStatusResponse updateUserTaskStatusWithOptions(UpdateUserTaskStatusRequest request, UpdateUserTaskStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            body.put("operatorId", request.operatorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userTaskStatuses)) {
            body.put("userTaskStatuses", request.userTaskStatuses);
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
            new TeaPair("action", "UpdateUserTaskStatus"),
            new TeaPair("version", "todoEE_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/todoEE/users/tasks/statuses"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateUserTaskStatusResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新用户的待办状态</p>
     * 
     * @param request UpdateUserTaskStatusRequest
     * @return UpdateUserTaskStatusResponse
     */
    public UpdateUserTaskStatusResponse updateUserTaskStatus(UpdateUserTaskStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateUserTaskStatusHeaders headers = new UpdateUserTaskStatusHeaders();
        return this.updateUserTaskStatusWithOptions(request, headers, runtime);
    }
}
