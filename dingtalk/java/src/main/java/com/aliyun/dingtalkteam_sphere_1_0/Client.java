// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkteam_sphere_1_0.models.*;

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
     * <p>创建自由任务</p>
     * 
     * @param request CreateOrganizationTaskRequest
     * @param headers CreateOrganizationTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateOrganizationTaskResponse
     */
    public CreateOrganizationTaskResponse createOrganizationTaskWithOptions(String userId, CreateOrganizationTaskRequest request, CreateOrganizationTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.content)) {
            body.put("content", request.content);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.disableActivity)) {
            body.put("disableActivity", request.disableActivity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.disableNotification)) {
            body.put("disableNotification", request.disableNotification);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dueDate)) {
            body.put("dueDate", request.dueDate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.executorId)) {
            body.put("executorId", request.executorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.involveMembers)) {
            body.put("involveMembers", request.involveMembers);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.note)) {
            body.put("note", request.note);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.visible)) {
            body.put("visible", request.visible);
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
            new TeaPair("action", "CreateOrganizationTask"),
            new TeaPair("version", "teamSphere_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/teamSphere/organizations/users/" + userId + "/tasks"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateOrganizationTaskResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建自由任务</p>
     * 
     * @param request CreateOrganizationTaskRequest
     * @return CreateOrganizationTaskResponse
     */
    public CreateOrganizationTaskResponse createOrganizationTask(String userId, CreateOrganizationTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateOrganizationTaskHeaders headers = new CreateOrganizationTaskHeaders();
        return this.createOrganizationTaskWithOptions(userId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建协作空间任务</p>
     * 
     * @param request CreateTaskRequest
     * @param headers CreateTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateTaskResponse
     */
    public CreateTaskResponse createTaskWithOptions(String userId, CreateTaskRequest request, CreateTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.content)) {
            body.put("content", request.content);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.customfields)) {
            body.put("customfields", request.customfields);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dueDate)) {
            body.put("dueDate", request.dueDate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.executorId)) {
            body.put("executorId", request.executorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.note)) {
            body.put("note", request.note);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.projectId)) {
            body.put("projectId", request.projectId);
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
            new TeaPair("action", "CreateTask"),
            new TeaPair("version", "teamSphere_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/teamSphere/users/" + userId + "/tasks"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateTaskResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建协作空间任务</p>
     * 
     * @param request CreateTaskRequest
     * @return CreateTaskResponse
     */
    public CreateTaskResponse createTask(String userId, CreateTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateTaskHeaders headers = new CreateTaskHeaders();
        return this.createTaskWithOptions(userId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询轻任务详情。</p>
     * 
     * @param request GetFreeTaskRequest
     * @param headers GetFreeTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetFreeTaskResponse
     */
    public GetFreeTaskResponse getFreeTaskWithOptions(String taskId, GetFreeTaskRequest request, GetFreeTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetFreeTask"),
            new TeaPair("version", "teamSphere_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/teamSphere/organizations/tasks/" + taskId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetFreeTaskResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询轻任务详情。</p>
     * 
     * @param request GetFreeTaskRequest
     * @return GetFreeTaskResponse
     */
    public GetFreeTaskResponse getFreeTask(String taskId, GetFreeTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetFreeTaskHeaders headers = new GetFreeTaskHeaders();
        return this.getFreeTaskWithOptions(taskId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>钉钉 userId 查询 24位长 userId。</p>
     * 
     * @param request GetTbUserIdByDingUserIdRequest
     * @param headers GetTbUserIdByDingUserIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetTbUserIdByDingUserIdResponse
     */
    public GetTbUserIdByDingUserIdResponse getTbUserIdByDingUserIdWithOptions(GetTbUserIdByDingUserIdRequest request, GetTbUserIdByDingUserIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingUserIds)) {
            query.put("dingUserIds", request.dingUserIds);
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
            new TeaPair("action", "GetTbUserIdByDingUserId"),
            new TeaPair("version", "teamSphere_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/teamSphere/idmaps/userIds"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetTbUserIdByDingUserIdResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>钉钉 userId 查询 24位长 userId。</p>
     * 
     * @param request GetTbUserIdByDingUserIdRequest
     * @return GetTbUserIdByDingUserIdResponse
     */
    public GetTbUserIdByDingUserIdResponse getTbUserIdByDingUserId(GetTbUserIdByDingUserIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetTbUserIdByDingUserIdHeaders headers = new GetTbUserIdByDingUserIdHeaders();
        return this.getTbUserIdByDingUserIdWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询协作空间任务详情。</p>
     * 
     * @param request QueryTasksV3Request
     * @param headers QueryTasksV3Headers
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryTasksV3Response
     */
    public QueryTasksV3Response queryTasksV3WithOptions(String userId, QueryTasksV3Request request, QueryTasksV3Headers headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.parentTaskId)) {
            query.put("parentTaskId", request.parentTaskId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.shortIds)) {
            query.put("shortIds", request.shortIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskId)) {
            query.put("taskId", request.taskId);
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
            new TeaPair("action", "QueryTasksV3"),
            new TeaPair("version", "teamSphere_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/teamSphere/user/" + userId + "/tasks"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryTasksV3Response());
    }

    /**
     * <b>summary</b> : 
     * <p>查询协作空间任务详情。</p>
     * 
     * @param request QueryTasksV3Request
     * @return QueryTasksV3Response
     */
    public QueryTasksV3Response queryTasksV3(String userId, QueryTasksV3Request request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryTasksV3Headers headers = new QueryTasksV3Headers();
        return this.queryTasksV3WithOptions(userId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>通过TQL搜索自由任务和协作空间任务ID。</p>
     * 
     * @param request SearchAllTasksByTqlRequest
     * @param headers SearchAllTasksByTqlHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SearchAllTasksByTqlResponse
     */
    public SearchAllTasksByTqlResponse searchAllTasksByTqlWithOptions(SearchAllTasksByTqlRequest request, SearchAllTasksByTqlHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tql)) {
            query.put("tql", request.tql);
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
            new TeaPair("action", "SearchAllTasksByTql"),
            new TeaPair("version", "teamSphere_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/teamSphere/taskIds"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SearchAllTasksByTqlResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>通过TQL搜索自由任务和协作空间任务ID。</p>
     * 
     * @param request SearchAllTasksByTqlRequest
     * @return SearchAllTasksByTqlResponse
     */
    public SearchAllTasksByTqlResponse searchAllTasksByTql(SearchAllTasksByTqlRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SearchAllTasksByTqlHeaders headers = new SearchAllTasksByTqlHeaders();
        return this.searchAllTasksByTqlWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询协作空间。</p>
     * 
     * @param request SearchProjectsV3Request
     * @param headers SearchProjectsV3Headers
     * @param runtime runtime options for this request RuntimeOptions
     * @return SearchProjectsV3Response
     */
    public SearchProjectsV3Response searchProjectsV3WithOptions(SearchProjectsV3Request request, SearchProjectsV3Headers headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.includeTemplate)) {
            query.put("includeTemplate", request.includeTemplate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            query.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.projectIds)) {
            query.put("projectIds", request.projectIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourceId)) {
            query.put("sourceId", request.sourceId);
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
            new TeaPair("action", "SearchProjectsV3"),
            new TeaPair("version", "teamSphere_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/teamSphere/projects"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SearchProjectsV3Response());
    }

    /**
     * <b>summary</b> : 
     * <p>查询协作空间。</p>
     * 
     * @param request SearchProjectsV3Request
     * @return SearchProjectsV3Response
     */
    public SearchProjectsV3Response searchProjectsV3(SearchProjectsV3Request request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SearchProjectsV3Headers headers = new SearchProjectsV3Headers();
        return this.searchProjectsV3WithOptions(request, headers, runtime);
    }
}
