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
     * <p>查询任务概览</p>
     * 
     * @param request AnalysisReportRequest
     * @param headers AnalysisReportHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AnalysisReportResponse
     */
    public AnalysisReportResponse analysisReportWithOptions(String userId, AnalysisReportRequest request, AnalysisReportHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.filter)) {
            body.put("filter", request.filter);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.reportId)) {
            body.put("reportId", request.reportId);
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
            new TeaPair("action", "AnalysisReport"),
            new TeaPair("version", "teamSphere_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/teamSphere/users/" + userId + "/analyses/report"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AnalysisReportResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询任务概览</p>
     * 
     * @param request AnalysisReportRequest
     * @return AnalysisReportResponse
     */
    public AnalysisReportResponse analysisReport(String userId, AnalysisReportRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AnalysisReportHeaders headers = new AnalysisReportHeaders();
        return this.analysisReportWithOptions(userId, request, headers, runtime);
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
     * <p>创建项目成员</p>
     * 
     * @param request CreateProjectMembersV3Request
     * @param headers CreateProjectMembersV3Headers
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateProjectMembersV3Response
     */
    public CreateProjectMembersV3Response createProjectMembersV3WithOptions(String userId, String projectId, CreateProjectMembersV3Request request, CreateProjectMembersV3Headers headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
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
            new TeaPair("action", "CreateProjectMembersV3"),
            new TeaPair("version", "teamSphere_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/teamSphere/users/" + userId + "/projects/" + projectId + "/members"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateProjectMembersV3Response());
    }

    /**
     * <b>summary</b> : 
     * <p>创建项目成员</p>
     * 
     * @param request CreateProjectMembersV3Request
     * @return CreateProjectMembersV3Response
     */
    public CreateProjectMembersV3Response createProjectMembersV3(String userId, String projectId, CreateProjectMembersV3Request request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateProjectMembersV3Headers headers = new CreateProjectMembersV3Headers();
        return this.createProjectMembersV3WithOptions(userId, projectId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建协作空间。</p>
     * 
     * @param request CreateProjectV3Request
     * @param headers CreateProjectV3Headers
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateProjectV3Response
     */
    public CreateProjectV3Response createProjectV3WithOptions(String userId, CreateProjectV3Request request, CreateProjectV3Headers headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.organizationId)) {
            query.put("organizationId", request.organizationId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
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
            new TeaPair("action", "CreateProjectV3"),
            new TeaPair("version", "teamSphere_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/teamSphere/users/" + userId + "/projects"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateProjectV3Response());
    }

    /**
     * <b>summary</b> : 
     * <p>创建协作空间。</p>
     * 
     * @param request CreateProjectV3Request
     * @return CreateProjectV3Response
     */
    public CreateProjectV3Response createProjectV3(String userId, CreateProjectV3Request request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateProjectV3Headers headers = new CreateProjectV3Headers();
        return this.createProjectV3WithOptions(userId, request, headers, runtime);
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
     * <p>删除项目成员。</p>
     * 
     * @param request DeleteProjectMembersV3Request
     * @param headers DeleteProjectMembersV3Headers
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteProjectMembersV3Response
     */
    public DeleteProjectMembersV3Response deleteProjectMembersV3WithOptions(String userId, String projectId, DeleteProjectMembersV3Request request, DeleteProjectMembersV3Headers headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
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
            new TeaPair("action", "DeleteProjectMembersV3"),
            new TeaPair("version", "teamSphere_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/teamSphere/users/" + userId + "/projects/" + projectId + "/members/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteProjectMembersV3Response());
    }

    /**
     * <b>summary</b> : 
     * <p>删除项目成员。</p>
     * 
     * @param request DeleteProjectMembersV3Request
     * @return DeleteProjectMembersV3Response
     */
    public DeleteProjectMembersV3Response deleteProjectMembersV3(String userId, String projectId, DeleteProjectMembersV3Request request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteProjectMembersV3Headers headers = new DeleteProjectMembersV3Headers();
        return this.deleteProjectMembersV3WithOptions(userId, projectId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取最近访问的项目</p>
     * 
     * @param headers GetFootprintProjectHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetFootprintProjectResponse
     */
    public GetFootprintProjectResponse getFootprintProjectWithOptions(String userId, GetFootprintProjectHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetFootprintProject"),
            new TeaPair("version", "teamSphere_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/teamSphere/users/" + userId + "/footprints/projects"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetFootprintProjectResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取最近访问的项目</p>
     * @return GetFootprintProjectResponse
     */
    public GetFootprintProjectResponse getFootprintProject(String userId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetFootprintProjectHeaders headers = new GetFootprintProjectHeaders();
        return this.getFootprintProjectWithOptions(userId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取最近访问的任务</p>
     * 
     * @param headers GetFootprintTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetFootprintTaskResponse
     */
    public GetFootprintTaskResponse getFootprintTaskWithOptions(String userId, GetFootprintTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetFootprintTask"),
            new TeaPair("version", "teamSphere_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/teamSphere/users/" + userId + "/footprints/tasks"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetFootprintTaskResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取最近访问的任务</p>
     * @return GetFootprintTaskResponse
     */
    public GetFootprintTaskResponse getFootprintTask(String userId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetFootprintTaskHeaders headers = new GetFootprintTaskHeaders();
        return this.getFootprintTaskWithOptions(userId, headers, runtime);
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
     * <p>获取协作空间成员列表。</p>
     * 
     * @param request GetProjectMembersV3Request
     * @param headers GetProjectMembersV3Headers
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetProjectMembersV3Response
     */
    public GetProjectMembersV3Response getProjectMembersV3WithOptions(String userId, String projectId, GetProjectMembersV3Request request, GetProjectMembersV3Headers headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.projectRoleId)) {
            query.put("projectRoleId", request.projectRoleId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIds)) {
            query.put("userIds", request.userIds);
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
            new TeaPair("action", "GetProjectMembersV3"),
            new TeaPair("version", "teamSphere_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/teamSphere/users/" + userId + "/projects/" + projectId + "/members"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetProjectMembersV3Response());
    }

    /**
     * <b>summary</b> : 
     * <p>获取协作空间成员列表。</p>
     * 
     * @param request GetProjectMembersV3Request
     * @return GetProjectMembersV3Response
     */
    public GetProjectMembersV3Response getProjectMembersV3(String userId, String projectId, GetProjectMembersV3Request request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetProjectMembersV3Headers headers = new GetProjectMembersV3Headers();
        return this.getProjectMembersV3WithOptions(userId, projectId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取项目角色列表。</p>
     * 
     * @param request GetProjectRolesV3Request
     * @param headers GetProjectRolesV3Headers
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetProjectRolesV3Response
     */
    public GetProjectRolesV3Response getProjectRolesV3WithOptions(String userId, String projectId, GetProjectRolesV3Request request, GetProjectRolesV3Headers headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.includeHidden)) {
            query.put("includeHidden", request.includeHidden);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.level)) {
            query.put("level", request.level);
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
            new TeaPair("action", "GetProjectRolesV3"),
            new TeaPair("version", "teamSphere_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/teamSphere/users/" + userId + "/projects/" + projectId + "/roles"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetProjectRolesV3Response());
    }

    /**
     * <b>summary</b> : 
     * <p>获取项目角色列表。</p>
     * 
     * @param request GetProjectRolesV3Request
     * @return GetProjectRolesV3Response
     */
    public GetProjectRolesV3Response getProjectRolesV3(String userId, String projectId, GetProjectRolesV3Request request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetProjectRolesV3Headers headers = new GetProjectRolesV3Headers();
        return this.getProjectRolesV3WithOptions(userId, projectId, request, headers, runtime);
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
     * <p>获取快办企业ID</p>
     * 
     * @param headers GetThingOrgIdByDingOrgIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetThingOrgIdByDingOrgIdResponse
     */
    public GetThingOrgIdByDingOrgIdResponse getThingOrgIdByDingOrgIdWithOptions(GetThingOrgIdByDingOrgIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetThingOrgIdByDingOrgId"),
            new TeaPair("version", "teamSphere_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/teamSphere/organizations"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetThingOrgIdByDingOrgIdResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取快办企业ID</p>
     * @return GetThingOrgIdByDingOrgIdResponse
     */
    public GetThingOrgIdByDingOrgIdResponse getThingOrgIdByDingOrgId() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetThingOrgIdByDingOrgIdHeaders headers = new GetThingOrgIdByDingOrgIdHeaders();
        return this.getThingOrgIdByDingOrgIdWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取用户参与项目。</p>
     * 
     * @param request GetUserJoinedProjectsV3Request
     * @param headers GetUserJoinedProjectsV3Headers
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetUserJoinedProjectsV3Response
     */
    public GetUserJoinedProjectsV3Response getUserJoinedProjectsV3WithOptions(String userId, GetUserJoinedProjectsV3Request request, GetUserJoinedProjectsV3Headers headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.projectIds)) {
            query.put("projectIds", request.projectIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.projectRoleLevels)) {
            query.put("projectRoleLevels", request.projectRoleLevels);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sortBy)) {
            query.put("sortBy", request.sortBy);
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
            new TeaPair("action", "GetUserJoinedProjectsV3"),
            new TeaPair("version", "teamSphere_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/teamSphere/users/" + userId + "/projects/userJoined"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetUserJoinedProjectsV3Response());
    }

    /**
     * <b>summary</b> : 
     * <p>获取用户参与项目。</p>
     * 
     * @param request GetUserJoinedProjectsV3Request
     * @return GetUserJoinedProjectsV3Response
     */
    public GetUserJoinedProjectsV3Response getUserJoinedProjectsV3(String userId, GetUserJoinedProjectsV3Request request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetUserJoinedProjectsV3Headers headers = new GetUserJoinedProjectsV3Headers();
        return this.getUserJoinedProjectsV3WithOptions(userId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取全部任务</p>
     * 
     * @param headers ListAllTaskViewHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListAllTaskViewResponse
     */
    public ListAllTaskViewResponse listAllTaskViewWithOptions(String userId, ListAllTaskViewHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "ListAllTaskView"),
            new TeaPair("version", "teamSphere_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/teamSphere/users/" + userId + "/allTaskViews"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListAllTaskViewResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取全部任务</p>
     * @return ListAllTaskViewResponse
     */
    public ListAllTaskViewResponse listAllTaskView(String userId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListAllTaskViewHeaders headers = new ListAllTaskViewHeaders();
        return this.listAllTaskViewWithOptions(userId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询我的捷径</p>
     * 
     * @param request ListMyShortcutViewsRequest
     * @param headers ListMyShortcutViewsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListMyShortcutViewsResponse
     */
    public ListMyShortcutViewsResponse listMyShortcutViewsWithOptions(String userId, ListMyShortcutViewsRequest request, ListMyShortcutViewsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "ListMyShortcutViews"),
            new TeaPair("version", "teamSphere_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/teamSphere/users/" + userId + "/shortcutViews"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListMyShortcutViewsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询我的捷径</p>
     * 
     * @param request ListMyShortcutViewsRequest
     * @return ListMyShortcutViewsResponse
     */
    public ListMyShortcutViewsResponse listMyShortcutViews(String userId, ListMyShortcutViewsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListMyShortcutViewsHeaders headers = new ListMyShortcutViewsHeaders();
        return this.listMyShortcutViewsWithOptions(userId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询自由任务和项目任务详情。</p>
     * 
     * @param request QueryAllTaskRequest
     * @param headers QueryAllTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryAllTaskResponse
     */
    public QueryAllTaskResponse queryAllTaskWithOptions(String userId, QueryAllTaskRequest request, QueryAllTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryAllTask"),
            new TeaPair("version", "teamSphere_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/teamSphere/users/" + userId + "/tasks/query"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryAllTaskResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询自由任务和项目任务详情。</p>
     * 
     * @param request QueryAllTaskRequest
     * @return QueryAllTaskResponse
     */
    public QueryAllTaskResponse queryAllTask(String userId, QueryAllTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryAllTaskHeaders headers = new QueryAllTaskHeaders();
        return this.queryAllTaskWithOptions(userId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询我的任务</p>
     * 
     * @param request QueryTaskRequest
     * @param headers QueryTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryTaskResponse
     */
    public QueryTaskResponse queryTaskWithOptions(String userId, QueryTaskRequest request, QueryTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            body.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            body.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tql)) {
            body.put("tql", request.tql);
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
            new TeaPair("action", "QueryTask"),
            new TeaPair("version", "teamSphere_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/teamSphere/users/" + userId + "/tasks/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryTaskResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询我的任务</p>
     * 
     * @param request QueryTaskRequest
     * @return QueryTaskResponse
     */
    public QueryTaskResponse queryTask(String userId, QueryTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryTaskHeaders headers = new QueryTaskHeaders();
        return this.queryTaskWithOptions(userId, request, headers, runtime);
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

    /**
     * <b>summary</b> : 
     * <p>修改项目成员的角色。</p>
     * 
     * @param request UpdateProjectMemberRoleV3Request
     * @param headers UpdateProjectMemberRoleV3Headers
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateProjectMemberRoleV3Response
     */
    public UpdateProjectMemberRoleV3Response updateProjectMemberRoleV3WithOptions(String userId, String projectId, UpdateProjectMemberRoleV3Request request, UpdateProjectMemberRoleV3Headers headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.roleIds)) {
            body.put("roleIds", request.roleIds);
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
            new TeaPair("action", "UpdateProjectMemberRoleV3"),
            new TeaPair("version", "teamSphere_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/teamSphere/users/" + userId + "/projects/" + projectId + "/roles/assign"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateProjectMemberRoleV3Response());
    }

    /**
     * <b>summary</b> : 
     * <p>修改项目成员的角色。</p>
     * 
     * @param request UpdateProjectMemberRoleV3Request
     * @return UpdateProjectMemberRoleV3Response
     */
    public UpdateProjectMemberRoleV3Response updateProjectMemberRoleV3(String userId, String projectId, UpdateProjectMemberRoleV3Request request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateProjectMemberRoleV3Headers headers = new UpdateProjectMemberRoleV3Headers();
        return this.updateProjectMemberRoleV3WithOptions(userId, projectId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新协作空间。</p>
     * 
     * @param request UpdateProjectV3Request
     * @param headers UpdateProjectV3Headers
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateProjectV3Response
     */
    public UpdateProjectV3Response updateProjectV3WithOptions(String userId, String projectId, UpdateProjectV3Request request, UpdateProjectV3Headers headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
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
            new TeaPair("action", "UpdateProjectV3"),
            new TeaPair("version", "teamSphere_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/teamSphere/users/" + userId + "/projects/" + projectId + ""),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateProjectV3Response());
    }

    /**
     * <b>summary</b> : 
     * <p>更新协作空间。</p>
     * 
     * @param request UpdateProjectV3Request
     * @return UpdateProjectV3Response
     */
    public UpdateProjectV3Response updateProjectV3(String userId, String projectId, UpdateProjectV3Request request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateProjectV3Headers headers = new UpdateProjectV3Headers();
        return this.updateProjectV3WithOptions(userId, projectId, request, headers, runtime);
    }
}
