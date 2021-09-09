// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalktodo_1_0.models.*;
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


    public GetTodoTaskDetailResponse getTodoTaskDetail(String taskId, String unionId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetTodoTaskDetailHeaders headers = new GetTodoTaskDetailHeaders();
        return this.getTodoTaskDetailWithOptions(taskId, unionId, headers, runtime);
    }

    public GetTodoTaskDetailResponse getTodoTaskDetailWithOptions(String taskId, String unionId, GetTodoTaskDetailHeaders headers, RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("GetTodoTaskDetail", "todo_1.0", "HTTP", "GET", "AK", "/v1.0/todo/exclusive/users/" + unionId + "/tasks/" + taskId + "", "json", req, runtime), new GetTodoTaskDetailResponse());
    }

    public GetTodoTaskResponse getTodoTask(String unionId, String taskId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetTodoTaskHeaders headers = new GetTodoTaskHeaders();
        return this.getTodoTaskWithOptions(unionId, taskId, headers, runtime);
    }

    public GetTodoTaskResponse getTodoTaskWithOptions(String unionId, String taskId, GetTodoTaskHeaders headers, RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("GetTodoTask", "todo_1.0", "HTTP", "GET", "AK", "/v1.0/todo/users/" + unionId + "/tasks/" + taskId + "", "json", req, runtime), new GetTodoTaskResponse());
    }

    public GetTodoTaskBySourceIdResponse getTodoTaskBySourceId(String unionId, String sourceId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetTodoTaskBySourceIdHeaders headers = new GetTodoTaskBySourceIdHeaders();
        return this.getTodoTaskBySourceIdWithOptions(unionId, sourceId, headers, runtime);
    }

    public GetTodoTaskBySourceIdResponse getTodoTaskBySourceIdWithOptions(String unionId, String sourceId, GetTodoTaskBySourceIdHeaders headers, RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("GetTodoTaskBySourceId", "todo_1.0", "HTTP", "GET", "AK", "/v1.0/todo/users/" + unionId + "/tasks/sources/" + sourceId + "", "json", req, runtime), new GetTodoTaskBySourceIdResponse());
    }

    public CountTodoTasksResponse countTodoTasks(String unionId, CountTodoTasksRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CountTodoTasksHeaders headers = new CountTodoTasksHeaders();
        return this.countTodoTasksWithOptions(unionId, request, headers, runtime);
    }

    public CountTodoTasksResponse countTodoTasksWithOptions(String unionId, CountTodoTasksRequest request, CountTodoTasksHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.isDone)) {
            body.put("isDone", request.isDone);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roleTypes)) {
            body.put("roleTypes", request.roleTypes);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fromDueTime)) {
            body.put("fromDueTime", request.fromDueTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.toDueTime)) {
            body.put("toDueTime", request.toDueTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.category)) {
            body.put("category", request.category);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isRecycled)) {
            body.put("isRecycled", request.isRecycled);
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
        return TeaModel.toModel(this.doROARequest("CountTodoTasks", "todo_1.0", "HTTP", "POST", "AK", "/v1.0/todo/users/" + unionId + "/tasks/count", "json", req, runtime), new CountTodoTasksResponse());
    }

    public QueryOrgTodoTasksResponse queryOrgTodoTasks(String unionId, QueryOrgTodoTasksRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryOrgTodoTasksHeaders headers = new QueryOrgTodoTasksHeaders();
        return this.queryOrgTodoTasksWithOptions(unionId, request, headers, runtime);
    }

    public QueryOrgTodoTasksResponse queryOrgTodoTasksWithOptions(String unionId, QueryOrgTodoTasksRequest request, QueryOrgTodoTasksHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            body.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isDone)) {
            body.put("isDone", request.isDone);
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
        return TeaModel.toModel(this.doROARequest("QueryOrgTodoTasks", "todo_1.0", "HTTP", "POST", "AK", "/v1.0/todo/users/" + unionId + "/org/tasks/query", "json", req, runtime), new QueryOrgTodoTasksResponse());
    }

    public CreateTodoTaskResponse createTodoTask(String unionId, CreateTodoTaskRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateTodoTaskHeaders headers = new CreateTodoTaskHeaders();
        return this.createTodoTaskWithOptions(unionId, request, headers, runtime);
    }

    public CreateTodoTaskResponse createTodoTaskWithOptions(String unionId, CreateTodoTaskRequest request, CreateTodoTaskHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.sourceId)) {
            body.put("sourceId", request.sourceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subject)) {
            body.put("subject", request.subject);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.creatorId)) {
            body.put("creatorId", request.creatorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
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

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.detailUrl))) {
            body.put("detailUrl", request.detailUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.notifyConfigs))) {
            body.put("notifyConfigs", request.notifyConfigs);
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
        return TeaModel.toModel(this.doROARequest("CreateTodoTask", "todo_1.0", "HTTP", "POST", "AK", "/v1.0/todo/users/" + unionId + "/tasks", "json", req, runtime), new CreateTodoTaskResponse());
    }

    public GetTodoTypeConfigResponse getTodoTypeConfig(String unionId, String cardTypeId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetTodoTypeConfigHeaders headers = new GetTodoTypeConfigHeaders();
        return this.getTodoTypeConfigWithOptions(unionId, cardTypeId, headers, runtime);
    }

    public GetTodoTypeConfigResponse getTodoTypeConfigWithOptions(String unionId, String cardTypeId, GetTodoTypeConfigHeaders headers, RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("GetTodoTypeConfig", "todo_1.0", "HTTP", "GET", "AK", "/v1.0/todo/users/" + unionId + "/configs/types/" + cardTypeId + "", "json", req, runtime), new GetTodoTypeConfigResponse());
    }

    public QueryTodoTasksResponse queryTodoTasks(String unionId, QueryTodoTasksRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryTodoTasksHeaders headers = new QueryTodoTasksHeaders();
        return this.queryTodoTasksWithOptions(unionId, request, headers, runtime);
    }

    public QueryTodoTasksResponse queryTodoTasksWithOptions(String unionId, QueryTodoTasksRequest request, QueryTodoTasksHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            body.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderBy)) {
            body.put("orderBy", request.orderBy);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderDirection)) {
            body.put("orderDirection", request.orderDirection);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isDone)) {
            body.put("isDone", request.isDone);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roleTypes)) {
            body.put("roleTypes", request.roleTypes);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fromDueTime)) {
            body.put("fromDueTime", request.fromDueTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.toDueTime)) {
            body.put("toDueTime", request.toDueTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.category)) {
            body.put("category", request.category);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isRecycled)) {
            body.put("isRecycled", request.isRecycled);
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
        return TeaModel.toModel(this.doROARequest("QueryTodoTasks", "todo_1.0", "HTTP", "POST", "AK", "/v1.0/todo/users/" + unionId + "/tasks/list", "json", req, runtime), new QueryTodoTasksResponse());
    }

    public UpdateTodoTypeConfigResponse updateTodoTypeConfig(String unionId, String cardTypeId, UpdateTodoTypeConfigRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateTodoTypeConfigHeaders headers = new UpdateTodoTypeConfigHeaders();
        return this.updateTodoTypeConfigWithOptions(unionId, cardTypeId, request, headers, runtime);
    }

    public UpdateTodoTypeConfigResponse updateTodoTypeConfigWithOptions(String unionId, String cardTypeId, UpdateTodoTypeConfigRequest request, UpdateTodoTypeConfigHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.cardType)) {
            body.put("cardType", request.cardType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.icon)) {
            body.put("icon", request.icon);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pcDetailUrlOpenMode)) {
            body.put("pcDetailUrlOpenMode", request.pcDetailUrlOpenMode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.contentFieldList)) {
            body.put("contentFieldList", request.contentFieldList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.actionList)) {
            body.put("actionList", request.actionList);
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
        return TeaModel.toModel(this.doROARequest("UpdateTodoTypeConfig", "todo_1.0", "HTTP", "PUT", "AK", "/v1.0/todo/users/" + unionId + "/configs/types/" + cardTypeId + "", "json", req, runtime), new UpdateTodoTypeConfigResponse());
    }

    public DeleteTodoTaskResponse deleteTodoTask(String unionId, String taskId, DeleteTodoTaskRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteTodoTaskHeaders headers = new DeleteTodoTaskHeaders();
        return this.deleteTodoTaskWithOptions(unionId, taskId, request, headers, runtime);
    }

    public DeleteTodoTaskResponse deleteTodoTaskWithOptions(String unionId, String taskId, DeleteTodoTaskRequest request, DeleteTodoTaskHeaders headers, RuntimeOptions runtime) throws Exception {
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
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("DeleteTodoTask", "todo_1.0", "HTTP", "DELETE", "AK", "/v1.0/todo/users/" + unionId + "/tasks/" + taskId + "", "json", req, runtime), new DeleteTodoTaskResponse());
    }

    public UpdateTodoTaskExecutorStatusResponse updateTodoTaskExecutorStatus(String unionId, String taskId, UpdateTodoTaskExecutorStatusRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateTodoTaskExecutorStatusHeaders headers = new UpdateTodoTaskExecutorStatusHeaders();
        return this.updateTodoTaskExecutorStatusWithOptions(unionId, taskId, request, headers, runtime);
    }

    public UpdateTodoTaskExecutorStatusResponse updateTodoTaskExecutorStatusWithOptions(String unionId, String taskId, UpdateTodoTaskExecutorStatusRequest request, UpdateTodoTaskExecutorStatusHeaders headers, RuntimeOptions runtime) throws Exception {
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
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdateTodoTaskExecutorStatus", "todo_1.0", "HTTP", "PUT", "AK", "/v1.0/todo/users/" + unionId + "/tasks/" + taskId + "/executorStatus", "json", req, runtime), new UpdateTodoTaskExecutorStatusResponse());
    }

    public CreateTodoTypeConfigResponse createTodoTypeConfig(String unionId, CreateTodoTypeConfigRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateTodoTypeConfigHeaders headers = new CreateTodoTypeConfigHeaders();
        return this.createTodoTypeConfigWithOptions(unionId, request, headers, runtime);
    }

    public CreateTodoTypeConfigResponse createTodoTypeConfigWithOptions(String unionId, CreateTodoTypeConfigRequest request, CreateTodoTypeConfigHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.cardType)) {
            body.put("cardType", request.cardType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.icon)) {
            body.put("icon", request.icon);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pcDetailUrlOpenMode)) {
            body.put("pcDetailUrlOpenMode", request.pcDetailUrlOpenMode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.contentFieldList)) {
            body.put("contentFieldList", request.contentFieldList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.actionList)) {
            body.put("actionList", request.actionList);
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
        return TeaModel.toModel(this.doROARequest("CreateTodoTypeConfig", "todo_1.0", "HTTP", "POST", "AK", "/v1.0/todo/users/" + unionId + "/configs/types", "json", req, runtime), new CreateTodoTypeConfigResponse());
    }

    public UpdateTodoTaskResponse updateTodoTask(String unionId, String taskId, UpdateTodoTaskRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateTodoTaskHeaders headers = new UpdateTodoTaskHeaders();
        return this.updateTodoTaskWithOptions(unionId, taskId, request, headers, runtime);
    }

    public UpdateTodoTaskResponse updateTodoTaskWithOptions(String unionId, String taskId, UpdateTodoTaskRequest request, UpdateTodoTaskHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.subject)) {
            body.put("subject", request.subject);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dueTime)) {
            body.put("dueTime", request.dueTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.done)) {
            body.put("done", request.done);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.executorIds)) {
            body.put("executorIds", request.executorIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.participantIds)) {
            body.put("participantIds", request.participantIds);
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
        return TeaModel.toModel(this.doROARequest("UpdateTodoTask", "todo_1.0", "HTTP", "PUT", "AK", "/v1.0/todo/users/" + unionId + "/tasks/" + taskId + "", "json", req, runtime), new UpdateTodoTaskResponse());
    }
}
