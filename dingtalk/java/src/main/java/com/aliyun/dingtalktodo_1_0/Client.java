// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalktodo_1_0.models.*;

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
     * <p>查询用户待办计数</p>
     * 
     * @param request CountTodoTasksRequest
     * @param headers CountTodoTasksHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CountTodoTasksResponse
     */
    public CountTodoTasksResponse countTodoTasksWithOptions(String unionId, CountTodoTasksRequest request, CountTodoTasksHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.fromDueTime)) {
            body.put("fromDueTime", request.fromDueTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isDone)) {
            body.put("isDone", request.isDone);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isRecycled)) {
            body.put("isRecycled", request.isRecycled);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roleTypes)) {
            body.put("roleTypes", request.roleTypes);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.toDueTime)) {
            body.put("toDueTime", request.toDueTime);
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
            new TeaPair("action", "CountTodoTasks"),
            new TeaPair("version", "todo_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/todo/users/" + unionId + "/tasks/count"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CountTodoTasksResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询用户待办计数</p>
     * 
     * @param request CountTodoTasksRequest
     * @return CountTodoTasksResponse
     */
    public CountTodoTasksResponse countTodoTasks(String unionId, CountTodoTasksRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CountTodoTasksHeaders headers = new CountTodoTasksHeaders();
        return this.countTodoTasksWithOptions(unionId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>以用户个人身份创建个人待办</p>
     * 
     * @param request CreatePersonalTodoTaskRequest
     * @param headers CreatePersonalTodoTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreatePersonalTodoTaskResponse
     */
    public CreatePersonalTodoTaskResponse createPersonalTodoTaskWithOptions(CreatePersonalTodoTaskRequest request, CreatePersonalTodoTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
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

        if (!com.aliyun.teautil.Common.isUnset(request.participantIds)) {
            body.put("participantIds", request.participantIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.reminderTimeStamp)) {
            body.put("reminderTimeStamp", request.reminderTimeStamp);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subject)) {
            body.put("subject", request.subject);
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
            new TeaPair("action", "CreatePersonalTodoTask"),
            new TeaPair("version", "todo_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/todo/users/me/personalTasks"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreatePersonalTodoTaskResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>以用户个人身份创建个人待办</p>
     * 
     * @param request CreatePersonalTodoTaskRequest
     * @return CreatePersonalTodoTaskResponse
     */
    public CreatePersonalTodoTaskResponse createPersonalTodoTask(CreatePersonalTodoTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreatePersonalTodoTaskHeaders headers = new CreatePersonalTodoTaskHeaders();
        return this.createPersonalTodoTaskWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建待办</p>
     * 
     * @param request CreateTodoTaskRequest
     * @param headers CreateTodoTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateTodoTaskResponse
     */
    public CreateTodoTaskResponse createTodoTaskWithOptions(String unionId, CreateTodoTaskRequest request, CreateTodoTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.actionList)) {
            body.put("actionList", request.actionList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizCategoryId)) {
            body.put("bizCategoryId", request.bizCategoryId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.contentFieldList)) {
            body.put("contentFieldList", request.contentFieldList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.creatorId)) {
            body.put("creatorId", request.creatorId);
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

        if (!com.aliyun.teautil.Common.isUnset(request.isOnlyShowExecutor)) {
            body.put("isOnlyShowExecutor", request.isOnlyShowExecutor);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.notifyConfigs)) {
            body.put("notifyConfigs", request.notifyConfigs);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.participantIds)) {
            body.put("participantIds", request.participantIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.priority)) {
            body.put("priority", request.priority);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.remindNotifyConfigs)) {
            body.put("remindNotifyConfigs", request.remindNotifyConfigs);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.reminderTimeStamp)) {
            body.put("reminderTimeStamp", request.reminderTimeStamp);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourceId)) {
            body.put("sourceId", request.sourceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subject)) {
            body.put("subject", request.subject);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.todoType)) {
            body.put("todoType", request.todoType);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CreateTodoTask"),
            new TeaPair("version", "todo_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/todo/users/" + unionId + "/tasks"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateTodoTaskResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建待办</p>
     * 
     * @param request CreateTodoTaskRequest
     * @return CreateTodoTaskResponse
     */
    public CreateTodoTaskResponse createTodoTask(String unionId, CreateTodoTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateTodoTaskHeaders headers = new CreateTodoTaskHeaders();
        return this.createTodoTaskWithOptions(unionId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建待办卡片类型配置</p>
     * 
     * @param request CreateTodoTypeConfigRequest
     * @param headers CreateTodoTypeConfigHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateTodoTypeConfigResponse
     */
    public CreateTodoTypeConfigResponse createTodoTypeConfigWithOptions(String unionId, CreateTodoTypeConfigRequest request, CreateTodoTypeConfigHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.actionList)) {
            body.put("actionList", request.actionList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardType)) {
            body.put("cardType", request.cardType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.contentFieldList)) {
            body.put("contentFieldList", request.contentFieldList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.icon)) {
            body.put("icon", request.icon);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pcDetailUrlOpenMode)) {
            body.put("pcDetailUrlOpenMode", request.pcDetailUrlOpenMode);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CreateTodoTypeConfig"),
            new TeaPair("version", "todo_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/todo/users/" + unionId + "/configs/types"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateTodoTypeConfigResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建待办卡片类型配置</p>
     * 
     * @param request CreateTodoTypeConfigRequest
     * @return CreateTodoTypeConfigResponse
     */
    public CreateTodoTypeConfigResponse createTodoTypeConfig(String unionId, CreateTodoTypeConfigRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateTodoTypeConfigHeaders headers = new CreateTodoTypeConfigHeaders();
        return this.createTodoTypeConfigWithOptions(unionId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除待办</p>
     * 
     * @param request DeleteTodoTaskRequest
     * @param headers DeleteTodoTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteTodoTaskResponse
     */
    public DeleteTodoTaskResponse deleteTodoTaskWithOptions(String unionId, String taskId, DeleteTodoTaskRequest request, DeleteTodoTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
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
            new TeaPair("action", "DeleteTodoTask"),
            new TeaPair("version", "todo_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/todo/users/" + unionId + "/tasks/" + taskId + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteTodoTaskResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除待办</p>
     * 
     * @param request DeleteTodoTaskRequest
     * @return DeleteTodoTaskResponse
     */
    public DeleteTodoTaskResponse deleteTodoTask(String unionId, String taskId, DeleteTodoTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteTodoTaskHeaders headers = new DeleteTodoTaskHeaders();
        return this.deleteTodoTaskWithOptions(unionId, taskId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询待办</p>
     * 
     * @param headers GetTodoTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetTodoTaskResponse
     */
    public GetTodoTaskResponse getTodoTaskWithOptions(String unionId, String taskId, GetTodoTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetTodoTask"),
            new TeaPair("version", "todo_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/todo/users/" + unionId + "/tasks/" + taskId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetTodoTaskResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询待办</p>
     * @return GetTodoTaskResponse
     */
    public GetTodoTaskResponse getTodoTask(String unionId, String taskId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetTodoTaskHeaders headers = new GetTodoTaskHeaders();
        return this.getTodoTaskWithOptions(unionId, taskId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据sourceId查询待办详情</p>
     * 
     * @param headers GetTodoTaskBySourceIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetTodoTaskBySourceIdResponse
     */
    public GetTodoTaskBySourceIdResponse getTodoTaskBySourceIdWithOptions(String unionId, String sourceId, GetTodoTaskBySourceIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetTodoTaskBySourceId"),
            new TeaPair("version", "todo_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/todo/users/" + unionId + "/tasks/sources/" + sourceId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetTodoTaskBySourceIdResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据sourceId查询待办详情</p>
     * @return GetTodoTaskBySourceIdResponse
     */
    public GetTodoTaskBySourceIdResponse getTodoTaskBySourceId(String unionId, String sourceId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetTodoTaskBySourceIdHeaders headers = new GetTodoTaskBySourceIdHeaders();
        return this.getTodoTaskBySourceIdWithOptions(unionId, sourceId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>专属钉根据待办ID查询待办详情</p>
     * 
     * @param headers GetTodoTaskDetailHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetTodoTaskDetailResponse
     */
    public GetTodoTaskDetailResponse getTodoTaskDetailWithOptions(String taskId, String unionId, GetTodoTaskDetailHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetTodoTaskDetail"),
            new TeaPair("version", "todo_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/todo/exclusive/users/" + unionId + "/tasks/" + taskId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetTodoTaskDetailResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>专属钉根据待办ID查询待办详情</p>
     * @return GetTodoTaskDetailResponse
     */
    public GetTodoTaskDetailResponse getTodoTaskDetail(String taskId, String unionId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetTodoTaskDetailHeaders headers = new GetTodoTaskDetailHeaders();
        return this.getTodoTaskDetailWithOptions(taskId, unionId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据id获取待办卡片类型配置</p>
     * 
     * @param headers GetTodoTypeConfigHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetTodoTypeConfigResponse
     */
    public GetTodoTypeConfigResponse getTodoTypeConfigWithOptions(String unionId, String cardTypeId, GetTodoTypeConfigHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetTodoTypeConfig"),
            new TeaPair("version", "todo_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/todo/users/" + unionId + "/configs/types/" + cardTypeId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetTodoTypeConfigResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据id获取待办卡片类型配置</p>
     * @return GetTodoTypeConfigResponse
     */
    public GetTodoTypeConfigResponse getTodoTypeConfig(String unionId, String cardTypeId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetTodoTypeConfigHeaders headers = new GetTodoTypeConfigHeaders();
        return this.getTodoTypeConfigWithOptions(unionId, cardTypeId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询待办应用下所有二级分类</p>
     * 
     * @param headers ListAllBizCategoryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListAllBizCategoryResponse
     */
    public ListAllBizCategoryResponse listAllBizCategoryWithOptions(ListAllBizCategoryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "ListAllBizCategory"),
            new TeaPair("version", "todo_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/todo/apps/allBizcategories/list"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListAllBizCategoryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询待办应用下所有二级分类</p>
     * @return ListAllBizCategoryResponse
     */
    public ListAllBizCategoryResponse listAllBizCategory() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListAllBizCategoryHeaders headers = new ListAllBizCategoryHeaders();
        return this.listAllBizCategoryWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询企业配置</p>
     * 
     * @param headers QueryOrgConfigHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryOrgConfigResponse
     */
    public QueryOrgConfigResponse queryOrgConfigWithOptions(QueryOrgConfigHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryOrgConfig"),
            new TeaPair("version", "todo_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/todo/organizations/configs"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryOrgConfigResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询企业配置</p>
     * @return QueryOrgConfigResponse
     */
    public QueryOrgConfigResponse queryOrgConfig() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryOrgConfigHeaders headers = new QueryOrgConfigHeaders();
        return this.queryOrgConfigWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询用户企业类型待办列表，支持查询当前企业的一方应用、三方应用、自建应用产生的工作待办数据</p>
     * 
     * @param request QueryOrgTodoByUserRequest
     * @param headers QueryOrgTodoByUserHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryOrgTodoByUserResponse
     */
    public QueryOrgTodoByUserResponse queryOrgTodoByUserWithOptions(String unionId, QueryOrgTodoByUserRequest request, QueryOrgTodoByUserHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.fromDueTime)) {
            body.put("fromDueTime", request.fromDueTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isDone)) {
            body.put("isDone", request.isDone);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            body.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            body.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderBy)) {
            body.put("orderBy", request.orderBy);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderDirection)) {
            body.put("orderDirection", request.orderDirection);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roleTypes)) {
            body.put("roleTypes", request.roleTypes);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subject)) {
            body.put("subject", request.subject);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.toDueTime)) {
            body.put("toDueTime", request.toDueTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.todoType)) {
            body.put("todoType", request.todoType);
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
            new TeaPair("action", "QueryOrgTodoByUser"),
            new TeaPair("version", "todo_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/todo/users/" + unionId + "/organizations/tasks/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryOrgTodoByUserResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询用户企业类型待办列表，支持查询当前企业的一方应用、三方应用、自建应用产生的工作待办数据</p>
     * 
     * @param request QueryOrgTodoByUserRequest
     * @return QueryOrgTodoByUserResponse
     */
    public QueryOrgTodoByUserResponse queryOrgTodoByUser(String unionId, QueryOrgTodoByUserRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryOrgTodoByUserHeaders headers = new QueryOrgTodoByUserHeaders();
        return this.queryOrgTodoByUserWithOptions(unionId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询企业下用户待办列表</p>
     * 
     * @param request QueryOrgTodoTasksRequest
     * @param headers QueryOrgTodoTasksHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryOrgTodoTasksResponse
     */
    public QueryOrgTodoTasksResponse queryOrgTodoTasksWithOptions(String unionId, QueryOrgTodoTasksRequest request, QueryOrgTodoTasksHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.isDone)) {
            body.put("isDone", request.isDone);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            body.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roleTypes)) {
            body.put("roleTypes", request.roleTypes);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.todoType)) {
            body.put("todoType", request.todoType);
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
            new TeaPair("action", "QueryOrgTodoTasks"),
            new TeaPair("version", "todo_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/todo/users/" + unionId + "/org/tasks/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryOrgTodoTasksResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询企业下用户待办列表</p>
     * 
     * @param request QueryOrgTodoTasksRequest
     * @return QueryOrgTodoTasksResponse
     */
    public QueryOrgTodoTasksResponse queryOrgTodoTasks(String unionId, QueryOrgTodoTasksRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryOrgTodoTasksHeaders headers = new QueryOrgTodoTasksHeaders();
        return this.queryOrgTodoTasksWithOptions(unionId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询用户待办列表</p>
     * 
     * @param request QueryTodoTasksRequest
     * @param headers QueryTodoTasksHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryTodoTasksResponse
     */
    public QueryTodoTasksResponse queryTodoTasksWithOptions(String unionId, QueryTodoTasksRequest request, QueryTodoTasksHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.category)) {
            body.put("category", request.category);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fromDueTime)) {
            body.put("fromDueTime", request.fromDueTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isDone)) {
            body.put("isDone", request.isDone);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isRecycled)) {
            body.put("isRecycled", request.isRecycled);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            body.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderBy)) {
            body.put("orderBy", request.orderBy);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderDirection)) {
            body.put("orderDirection", request.orderDirection);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roleTypes)) {
            body.put("roleTypes", request.roleTypes);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.toDueTime)) {
            body.put("toDueTime", request.toDueTime);
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
            new TeaPair("action", "QueryTodoTasks"),
            new TeaPair("version", "todo_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/todo/users/" + unionId + "/tasks/list"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryTodoTasksResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询用户待办列表</p>
     * 
     * @param request QueryTodoTasksRequest
     * @return QueryTodoTasksResponse
     */
    public QueryTodoTasksResponse queryTodoTasks(String unionId, QueryTodoTasksRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryTodoTasksHeaders headers = new QueryTodoTasksHeaders();
        return this.queryTodoTasksWithOptions(unionId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除二级分类</p>
     * 
     * @param request RemoveBizCategoryRequest
     * @param headers RemoveBizCategoryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RemoveBizCategoryResponse
     */
    public RemoveBizCategoryResponse removeBizCategoryWithOptions(RemoveBizCategoryRequest request, RemoveBizCategoryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCategoryId)) {
            query.put("bizCategoryId", request.bizCategoryId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
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
            new TeaPair("action", "RemoveBizCategory"),
            new TeaPair("version", "todo_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/todo/apps/bizcategories"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RemoveBizCategoryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除二级分类</p>
     * 
     * @param request RemoveBizCategoryRequest
     * @return RemoveBizCategoryResponse
     */
    public RemoveBizCategoryResponse removeBizCategory(RemoveBizCategoryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RemoveBizCategoryHeaders headers = new RemoveBizCategoryHeaders();
        return this.removeBizCategoryWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>保存二级分类</p>
     * 
     * @param request SetBizCategoryRequest
     * @param headers SetBizCategoryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SetBizCategoryResponse
     */
    public SetBizCategoryResponse setBizCategoryWithOptions(SetBizCategoryRequest request, SetBizCategoryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCategoryId)) {
            query.put("bizCategoryId", request.bizCategoryId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            query.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            query.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
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
            new TeaPair("action", "SetBizCategory"),
            new TeaPair("version", "todo_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/todo/apps/bizcategories/save"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SetBizCategoryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>保存二级分类</p>
     * 
     * @param request SetBizCategoryRequest
     * @return SetBizCategoryResponse
     */
    public SetBizCategoryResponse setBizCategory(SetBizCategoryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SetBizCategoryHeaders headers = new SetBizCategoryHeaders();
        return this.setBizCategoryWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>保存企业配置</p>
     * 
     * @param request SetOrgConfigRequest
     * @param headers SetOrgConfigHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SetOrgConfigResponse
     */
    public SetOrgConfigResponse setOrgConfigWithOptions(SetOrgConfigRequest request, SetOrgConfigHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appDisplayStyle)) {
            body.put("appDisplayStyle", request.appDisplayStyle);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.homepageCatalogs)) {
            body.put("homepageCatalogs", request.homepageCatalogs);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            body.put("operatorId", request.operatorId);
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
            new TeaPair("action", "SetOrgConfig"),
            new TeaPair("version", "todo_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/todo/organizations/configs/save"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SetOrgConfigResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>保存企业配置</p>
     * 
     * @param request SetOrgConfigRequest
     * @return SetOrgConfigResponse
     */
    public SetOrgConfigResponse setOrgConfig(SetOrgConfigRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SetOrgConfigHeaders headers = new SetOrgConfigHeaders();
        return this.setOrgConfigWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新待办</p>
     * 
     * @param request UpdateTodoTaskRequest
     * @param headers UpdateTodoTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateTodoTaskResponse
     */
    public UpdateTodoTaskResponse updateTodoTaskWithOptions(String unionId, String taskId, UpdateTodoTaskRequest request, UpdateTodoTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

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

        if (!com.aliyun.teautil.Common.isUnset(request.participantIds)) {
            body.put("participantIds", request.participantIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subject)) {
            body.put("subject", request.subject);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UpdateTodoTask"),
            new TeaPair("version", "todo_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/todo/users/" + unionId + "/tasks/" + taskId + ""),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateTodoTaskResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新待办</p>
     * 
     * @param request UpdateTodoTaskRequest
     * @return UpdateTodoTaskResponse
     */
    public UpdateTodoTaskResponse updateTodoTask(String unionId, String taskId, UpdateTodoTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateTodoTaskHeaders headers = new UpdateTodoTaskHeaders();
        return this.updateTodoTaskWithOptions(unionId, taskId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新待办执行者状态</p>
     * 
     * @param request UpdateTodoTaskExecutorStatusRequest
     * @param headers UpdateTodoTaskExecutorStatusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateTodoTaskExecutorStatusResponse
     */
    public UpdateTodoTaskExecutorStatusResponse updateTodoTaskExecutorStatusWithOptions(String unionId, String taskId, UpdateTodoTaskExecutorStatusRequest request, UpdateTodoTaskExecutorStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.executorStatusList)) {
            body.put("executorStatusList", request.executorStatusList);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UpdateTodoTaskExecutorStatus"),
            new TeaPair("version", "todo_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/todo/users/" + unionId + "/tasks/" + taskId + "/executorStatus"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateTodoTaskExecutorStatusResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新待办执行者状态</p>
     * 
     * @param request UpdateTodoTaskExecutorStatusRequest
     * @return UpdateTodoTaskExecutorStatusResponse
     */
    public UpdateTodoTaskExecutorStatusResponse updateTodoTaskExecutorStatus(String unionId, String taskId, UpdateTodoTaskExecutorStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateTodoTaskExecutorStatusHeaders headers = new UpdateTodoTaskExecutorStatusHeaders();
        return this.updateTodoTaskExecutorStatusWithOptions(unionId, taskId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新待办卡片类型配置</p>
     * 
     * @param request UpdateTodoTypeConfigRequest
     * @param headers UpdateTodoTypeConfigHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateTodoTypeConfigResponse
     */
    public UpdateTodoTypeConfigResponse updateTodoTypeConfigWithOptions(String unionId, String cardTypeId, UpdateTodoTypeConfigRequest request, UpdateTodoTypeConfigHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.actionList)) {
            body.put("actionList", request.actionList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardType)) {
            body.put("cardType", request.cardType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.contentFieldList)) {
            body.put("contentFieldList", request.contentFieldList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.icon)) {
            body.put("icon", request.icon);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pcDetailUrlOpenMode)) {
            body.put("pcDetailUrlOpenMode", request.pcDetailUrlOpenMode);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UpdateTodoTypeConfig"),
            new TeaPair("version", "todo_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/todo/users/" + unionId + "/configs/types/" + cardTypeId + ""),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateTodoTypeConfigResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新待办卡片类型配置</p>
     * 
     * @param request UpdateTodoTypeConfigRequest
     * @return UpdateTodoTypeConfigResponse
     */
    public UpdateTodoTypeConfigResponse updateTodoTypeConfig(String unionId, String cardTypeId, UpdateTodoTypeConfigRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateTodoTypeConfigHeaders headers = new UpdateTodoTypeConfigHeaders();
        return this.updateTodoTypeConfigWithOptions(unionId, cardTypeId, request, headers, runtime);
    }
}
