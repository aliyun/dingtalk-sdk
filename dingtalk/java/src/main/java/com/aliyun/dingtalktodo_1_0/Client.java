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


    public GetTodoTypeConfigResponse getTodoTypeConfig(String unionId, String typeId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetTodoTypeConfigHeaders headers = new GetTodoTypeConfigHeaders();
        return this.getTodoTypeConfigWithOptions(unionId, typeId, headers, runtime);
    }

    public GetTodoTypeConfigResponse getTodoTypeConfigWithOptions(String unionId, String typeId, GetTodoTypeConfigHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("GetTodoTypeConfig", "todo_1.0", "HTTP", "GET", "AK", "/v1.0/todo/users/" + unionId + "/configs/types/" + typeId + "", "json", req, runtime), new GetTodoTypeConfigResponse());
    }

    public UpdateTodoTypeConfigResponse updateTodoTypeConfig(String unionId, String typeId, UpdateTodoTypeConfigRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateTodoTypeConfigHeaders headers = new UpdateTodoTypeConfigHeaders();
        return this.updateTodoTypeConfigWithOptions(unionId, typeId, request, headers, runtime);
    }

    public UpdateTodoTypeConfigResponse updateTodoTypeConfigWithOptions(String unionId, String typeId, UpdateTodoTypeConfigRequest request, UpdateTodoTypeConfigHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("UpdateTodoTypeConfig", "todo_1.0", "HTTP", "PUT", "AK", "/v1.0/todo/users/" + unionId + "/configs/types/" + typeId + "", "json", req, runtime), new UpdateTodoTypeConfigResponse());
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

        if (!com.aliyun.teautil.Common.isUnset(request.cardTypeId)) {
            body.put("cardTypeId", request.cardTypeId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.contentFieldList)) {
            body.put("contentFieldList", request.contentFieldList);
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
}
