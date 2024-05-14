// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkproject_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public com.aliyun.gateway.spi.Client _client;
    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._client = new com.aliyun.gateway.dingtalk.Client();
        this._spi = _client;
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    /**
     * @summary 增加项目成员
     *
     * @param request AddProjectMemberRequest
     * @param headers AddProjectMemberHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddProjectMemberResponse
     */
    public AddProjectMemberResponse addProjectMemberWithOptions(String userId, String projectId, AddProjectMemberRequest request, AddProjectMemberHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "AddProjectMember"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/users/" + userId + "/projects/" + projectId + "/members"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddProjectMemberResponse());
    }

    /**
     * @summary 增加项目成员
     *
     * @param request AddProjectMemberRequest
     * @return AddProjectMemberResponse
     */
    public AddProjectMemberResponse addProjectMember(String userId, String projectId, AddProjectMemberRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddProjectMemberHeaders headers = new AddProjectMemberHeaders();
        return this.addProjectMemberWithOptions(userId, projectId, request, headers, runtime);
    }

    /**
     * @summary 项目放入回收站
     *
     * @param headers ArchiveProjectHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ArchiveProjectResponse
     */
    public ArchiveProjectResponse archiveProjectWithOptions(String userId, String projectId, ArchiveProjectHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "ArchiveProject"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/users/" + userId + "/projects/" + projectId + "/archive"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ArchiveProjectResponse());
    }

    /**
     * @summary 项目放入回收站
     *
     * @return ArchiveProjectResponse
     */
    public ArchiveProjectResponse archiveProject(String userId, String projectId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ArchiveProjectHeaders headers = new ArchiveProjectHeaders();
        return this.archiveProjectWithOptions(userId, projectId, headers, runtime);
    }

    /**
     * @summary 任务迁移至回收站
     *
     * @param headers ArchiveTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ArchiveTaskResponse
     */
    public ArchiveTaskResponse archiveTaskWithOptions(String userId, String taskId, ArchiveTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "ArchiveTask"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/users/" + userId + "/tasks/" + taskId + "/archive"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ArchiveTaskResponse());
    }

    /**
     * @summary 任务迁移至回收站
     *
     * @return ArchiveTaskResponse
     */
    public ArchiveTaskResponse archiveTask(String userId, String taskId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ArchiveTaskHeaders headers = new ArchiveTaskHeaders();
        return this.archiveTaskWithOptions(userId, taskId, headers, runtime);
    }

    /**
     * @summary 创建自由任务
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

        if (!com.aliyun.teautil.Common.isUnset(request.createTime)) {
            body.put("createTime", request.createTime);
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

        if (!com.aliyun.teautil.Common.isUnset(request.priority)) {
            body.put("priority", request.priority);
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
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/organizations/users/" + userId + "/tasks"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateOrganizationTaskResponse());
    }

    /**
     * @summary 创建自由任务
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
     * @summary 录入计划工时
     *
     * @param request CreatePlanTimeRequest
     * @param headers CreatePlanTimeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreatePlanTimeResponse
     */
    public CreatePlanTimeResponse createPlanTimeWithOptions(String userId, CreatePlanTimeRequest request, CreatePlanTimeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.tenantType)) {
            query.put("tenantType", request.tenantType);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.endDate)) {
            body.put("endDate", request.endDate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.executorId)) {
            body.put("executorId", request.executorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.includesHolidays)) {
            body.put("includesHolidays", request.includesHolidays);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isDuration)) {
            body.put("isDuration", request.isDuration);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.objectId)) {
            body.put("objectId", request.objectId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.objectType)) {
            body.put("objectType", request.objectType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.planTime)) {
            body.put("planTime", request.planTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startDate)) {
            body.put("startDate", request.startDate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.submitterId)) {
            body.put("submitterId", request.submitterId);
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
            new TeaPair("action", "CreatePlanTime"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/users/" + userId + "/planTimes"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreatePlanTimeResponse());
    }

    /**
     * @summary 录入计划工时
     *
     * @param request CreatePlanTimeRequest
     * @return CreatePlanTimeResponse
     */
    public CreatePlanTimeResponse createPlanTime(String userId, CreatePlanTimeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreatePlanTimeHeaders headers = new CreatePlanTimeHeaders();
        return this.createPlanTimeWithOptions(userId, request, headers, runtime);
    }

    /**
     * @summary 创建项目
     *
     * @param request CreateProjectRequest
     * @param headers CreateProjectHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateProjectResponse
     */
    public CreateProjectResponse createProjectWithOptions(String userId, CreateProjectRequest request, CreateProjectHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CreateProject"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/users/" + userId + "/projects"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateProjectResponse());
    }

    /**
     * @summary 创建项目
     *
     * @param request CreateProjectRequest
     * @return CreateProjectResponse
     */
    public CreateProjectResponse createProject(String userId, CreateProjectRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateProjectHeaders headers = new CreateProjectHeaders();
        return this.createProjectWithOptions(userId, request, headers, runtime);
    }

    /**
     * @summary 根据项目模板创建项目
     *
     * @param request CreateProjectByTemplateRequest
     * @param headers CreateProjectByTemplateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateProjectByTemplateResponse
     */
    public CreateProjectByTemplateResponse createProjectByTemplateWithOptions(String userId, CreateProjectByTemplateRequest request, CreateProjectByTemplateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateId)) {
            body.put("templateId", request.templateId);
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
            new TeaPair("action", "CreateProjectByTemplate"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/users/" + userId + "/templates/projects"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateProjectByTemplateResponse());
    }

    /**
     * @summary 根据项目模板创建项目
     *
     * @param request CreateProjectByTemplateRequest
     * @return CreateProjectByTemplateResponse
     */
    public CreateProjectByTemplateResponse createProjectByTemplate(String userId, CreateProjectByTemplateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateProjectByTemplateHeaders headers = new CreateProjectByTemplateHeaders();
        return this.createProjectByTemplateWithOptions(userId, request, headers, runtime);
    }

    /**
     * @summary 创建或更新项目概览中自定义字段值
     *
     * @param request CreateProjectCustomfieldStatusRequest
     * @param headers CreateProjectCustomfieldStatusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateProjectCustomfieldStatusResponse
     */
    public CreateProjectCustomfieldStatusResponse createProjectCustomfieldStatusWithOptions(String userId, String projectId, CreateProjectCustomfieldStatusRequest request, CreateProjectCustomfieldStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.customFieldId)) {
            body.put("customFieldId", request.customFieldId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.customFieldInstanceId)) {
            body.put("customFieldInstanceId", request.customFieldInstanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.customFieldName)) {
            body.put("customFieldName", request.customFieldName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.value)) {
            body.put("value", request.value);
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
            new TeaPair("action", "CreateProjectCustomfieldStatus"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/users/" + userId + "/projects/" + projectId + "/customfields"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateProjectCustomfieldStatusResponse());
    }

    /**
     * @summary 创建或更新项目概览中自定义字段值
     *
     * @param request CreateProjectCustomfieldStatusRequest
     * @return CreateProjectCustomfieldStatusResponse
     */
    public CreateProjectCustomfieldStatusResponse createProjectCustomfieldStatus(String userId, String projectId, CreateProjectCustomfieldStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateProjectCustomfieldStatusHeaders headers = new CreateProjectCustomfieldStatusHeaders();
        return this.createProjectCustomfieldStatusWithOptions(userId, projectId, request, headers, runtime);
    }

    /**
     * @summary 创建项目任务
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

        if (!com.aliyun.teautil.Common.isUnset(request.parentTaskId)) {
            body.put("parentTaskId", request.parentTaskId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.priority)) {
            body.put("priority", request.priority);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.projectId)) {
            body.put("projectId", request.projectId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scenariofieldconfigId)) {
            body.put("scenariofieldconfigId", request.scenariofieldconfigId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.stageId)) {
            body.put("stageId", request.stageId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startDate)) {
            body.put("startDate", request.startDate);
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
            new TeaPair("action", "CreateTask"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/users/" + userId + "/tasks"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateTaskResponse());
    }

    /**
     * @summary 创建项目任务
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
     * @summary 创建任务关联对象
     *
     * @param request CreateTaskObjectLinkRequest
     * @param headers CreateTaskObjectLinkHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateTaskObjectLinkResponse
     */
    public CreateTaskObjectLinkResponse createTaskObjectLinkWithOptions(String userId, String taskId, CreateTaskObjectLinkRequest request, CreateTaskObjectLinkHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.linkedData)) {
            body.put("linkedData", request.linkedData);
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
            new TeaPair("action", "CreateTaskObjectLink"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/users/" + userId + "/tasks/" + taskId + "/objectLinks"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateTaskObjectLinkResponse());
    }

    /**
     * @summary 创建任务关联对象
     *
     * @param request CreateTaskObjectLinkRequest
     * @return CreateTaskObjectLinkResponse
     */
    public CreateTaskObjectLinkResponse createTaskObjectLink(String userId, String taskId, CreateTaskObjectLinkRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateTaskObjectLinkHeaders headers = new CreateTaskObjectLinkHeaders();
        return this.createTaskObjectLinkWithOptions(userId, taskId, request, headers, runtime);
    }

    /**
     * @summary 录入实际工时接口
     *
     * @param request CreateWorkTimeRequest
     * @param headers CreateWorkTimeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateWorkTimeResponse
     */
    public CreateWorkTimeResponse createWorkTimeWithOptions(String userId, CreateWorkTimeRequest request, CreateWorkTimeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.tenantType)) {
            query.put("tenantType", request.tenantType);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endDate)) {
            body.put("endDate", request.endDate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.executorId)) {
            body.put("executorId", request.executorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.includesHolidays)) {
            body.put("includesHolidays", request.includesHolidays);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isDuration)) {
            body.put("isDuration", request.isDuration);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.objectId)) {
            body.put("objectId", request.objectId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.objectType)) {
            body.put("objectType", request.objectType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startDate)) {
            body.put("startDate", request.startDate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.submitterId)) {
            body.put("submitterId", request.submitterId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.workTime)) {
            body.put("workTime", request.workTime);
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
            new TeaPair("action", "CreateWorkTime"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/users/" + userId + "/workTimes"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateWorkTimeResponse());
    }

    /**
     * @summary 录入实际工时接口
     *
     * @param request CreateWorkTimeRequest
     * @return CreateWorkTimeResponse
     */
    public CreateWorkTimeResponse createWorkTime(String userId, CreateWorkTimeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateWorkTimeHeaders headers = new CreateWorkTimeHeaders();
        return this.createWorkTimeWithOptions(userId, request, headers, runtime);
    }

    /**
     * @summary 创建实际工时审批对象。
     *
     * @param request CreateWorkTimeApproveRequest
     * @param headers CreateWorkTimeApproveHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateWorkTimeApproveResponse
     */
    public CreateWorkTimeApproveResponse createWorkTimeApproveWithOptions(String userId, CreateWorkTimeApproveRequest request, CreateWorkTimeApproveHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.workTimeIds)) {
            body.put("workTimeIds", request.workTimeIds);
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
            new TeaPair("action", "CreateWorkTimeApprove"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/users/" + userId + "/workTimes/approvals"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateWorkTimeApproveResponse());
    }

    /**
     * @summary 创建实际工时审批对象。
     *
     * @param request CreateWorkTimeApproveRequest
     * @return CreateWorkTimeApproveResponse
     */
    public CreateWorkTimeApproveResponse createWorkTimeApprove(String userId, CreateWorkTimeApproveRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateWorkTimeApproveHeaders headers = new CreateWorkTimeApproveHeaders();
        return this.createWorkTimeApproveWithOptions(userId, request, headers, runtime);
    }

    /**
     * @summary 删除项目成员
     *
     * @param request DeleteProjectMemberRequest
     * @param headers DeleteProjectMemberHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteProjectMemberResponse
     */
    public DeleteProjectMemberResponse deleteProjectMemberWithOptions(String userId, String projectId, DeleteProjectMemberRequest request, DeleteProjectMemberHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "DeleteProjectMember"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/users/" + userId + "/projects/" + projectId + "/members/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteProjectMemberResponse());
    }

    /**
     * @summary 删除项目成员
     *
     * @param request DeleteProjectMemberRequest
     * @return DeleteProjectMemberResponse
     */
    public DeleteProjectMemberResponse deleteProjectMember(String userId, String projectId, DeleteProjectMemberRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteProjectMemberHeaders headers = new DeleteProjectMemberHeaders();
        return this.deleteProjectMemberWithOptions(userId, projectId, request, headers, runtime);
    }

    /**
     * @summary 删除任务
     *
     * @param headers DeleteTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteTaskResponse
     */
    public DeleteTaskResponse deleteTaskWithOptions(String userId, String taskId, DeleteTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "DeleteTask"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/users/" + userId + "/tasks/" + taskId + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteTaskResponse());
    }

    /**
     * @summary 删除任务
     *
     * @return DeleteTaskResponse
     */
    public DeleteTaskResponse deleteTask(String userId, String taskId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteTaskHeaders headers = new DeleteTaskHeaders();
        return this.deleteTaskWithOptions(userId, taskId, headers, runtime);
    }

    /**
     * @summary 根据企业Id获取部门
     *
     * @param request GetDeptsByOrgIdRequest
     * @param headers GetDeptsByOrgIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetDeptsByOrgIdResponse
     */
    public GetDeptsByOrgIdResponse getDeptsByOrgIdWithOptions(GetDeptsByOrgIdRequest request, GetDeptsByOrgIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        if (!com.aliyun.teautil.Common.isUnset(headers.dingAccessTokenType)) {
            realHeaders.put("dingAccessTokenType", com.aliyun.teautil.Common.toJSONString(headers.dingAccessTokenType));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.dingOrgId)) {
            realHeaders.put("dingOrgId", com.aliyun.teautil.Common.toJSONString(headers.dingOrgId));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetDeptsByOrgId"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/orgs/depts"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetDeptsByOrgIdResponse());
    }

    /**
     * @summary 根据企业Id获取部门
     *
     * @param request GetDeptsByOrgIdRequest
     * @return GetDeptsByOrgIdResponse
     */
    public GetDeptsByOrgIdResponse getDeptsByOrgId(GetDeptsByOrgIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetDeptsByOrgIdHeaders headers = new GetDeptsByOrgIdHeaders();
        return this.getDeptsByOrgIdWithOptions(request, headers, runtime);
    }

    /**
     * @summary 根据企业Id获取企业内的员工信息
     *
     * @param request GetEmpsByOrgIdRequest
     * @param headers GetEmpsByOrgIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetEmpsByOrgIdResponse
     */
    public GetEmpsByOrgIdResponse getEmpsByOrgIdWithOptions(GetEmpsByOrgIdRequest request, GetEmpsByOrgIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.needDept)) {
            query.put("needDept", request.needDept);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.dingAccessTokenType)) {
            realHeaders.put("dingAccessTokenType", com.aliyun.teautil.Common.toJSONString(headers.dingAccessTokenType));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.dingOrgId)) {
            realHeaders.put("dingOrgId", com.aliyun.teautil.Common.toJSONString(headers.dingOrgId));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetEmpsByOrgId"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/orgs/employees"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetEmpsByOrgIdResponse());
    }

    /**
     * @summary 根据企业Id获取企业内的员工信息
     *
     * @param request GetEmpsByOrgIdRequest
     * @return GetEmpsByOrgIdResponse
     */
    public GetEmpsByOrgIdResponse getEmpsByOrgId(GetEmpsByOrgIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetEmpsByOrgIdHeaders headers = new GetEmpsByOrgIdHeaders();
        return this.getEmpsByOrgIdWithOptions(request, headers, runtime);
    }

    /**
     * @summary 批量获取任务详情
     *
     * @param request GetOrganizatioTaskByIdsRequest
     * @param headers GetOrganizatioTaskByIdsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetOrganizatioTaskByIdsResponse
     */
    public GetOrganizatioTaskByIdsResponse getOrganizatioTaskByIdsWithOptions(String userId, GetOrganizatioTaskByIdsRequest request, GetOrganizatioTaskByIdsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.taskIds)) {
            query.put("taskIds", request.taskIds);
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
            new TeaPair("action", "GetOrganizatioTaskByIds"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/organizations/users/" + userId + "/tasks"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetOrganizatioTaskByIdsResponse());
    }

    /**
     * @summary 批量获取任务详情
     *
     * @param request GetOrganizatioTaskByIdsRequest
     * @return GetOrganizatioTaskByIdsResponse
     */
    public GetOrganizatioTaskByIdsResponse getOrganizatioTaskByIds(String userId, GetOrganizatioTaskByIdsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetOrganizatioTaskByIdsHeaders headers = new GetOrganizatioTaskByIdsHeaders();
        return this.getOrganizatioTaskByIdsWithOptions(userId, request, headers, runtime);
    }

    /**
     * @summary 获取企业优先级列表
     *
     * @param headers GetOrganizationPriorityListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetOrganizationPriorityListResponse
     */
    public GetOrganizationPriorityListResponse getOrganizationPriorityListWithOptions(String userId, GetOrganizationPriorityListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetOrganizationPriorityList"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/organizations/users/" + userId + "/priorities"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetOrganizationPriorityListResponse());
    }

    /**
     * @summary 获取企业优先级列表
     *
     * @return GetOrganizationPriorityListResponse
     */
    public GetOrganizationPriorityListResponse getOrganizationPriorityList(String userId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetOrganizationPriorityListHeaders headers = new GetOrganizationPriorityListHeaders();
        return this.getOrganizationPriorityListWithOptions(userId, headers, runtime);
    }

    /**
     * @summary 获取自由任务详情
     *
     * @param headers GetOrganizationTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetOrganizationTaskResponse
     */
    public GetOrganizationTaskResponse getOrganizationTaskWithOptions(String taskId, String userId, GetOrganizationTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetOrganizationTask"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/organizations/users/" + userId + "/tasks/" + taskId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetOrganizationTaskResponse());
    }

    /**
     * @summary 获取自由任务详情
     *
     * @return GetOrganizationTaskResponse
     */
    public GetOrganizationTaskResponse getOrganizationTask(String taskId, String userId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetOrganizationTaskHeaders headers = new GetOrganizationTaskHeaders();
        return this.getOrganizationTaskWithOptions(taskId, userId, headers, runtime);
    }

    /**
     * @summary 查询可见的项目分组
     *
     * @param request GetProjectGroupRequest
     * @param headers GetProjectGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetProjectGroupResponse
     */
    public GetProjectGroupResponse getProjectGroupWithOptions(String userId, GetProjectGroupRequest request, GetProjectGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.viewerId)) {
            query.put("viewerId", request.viewerId);
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
            new TeaPair("action", "GetProjectGroup"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/organizations/users/" + userId + "/groups"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetProjectGroupResponse());
    }

    /**
     * @summary 查询可见的项目分组
     *
     * @param request GetProjectGroupRequest
     * @return GetProjectGroupResponse
     */
    public GetProjectGroupResponse getProjectGroup(String userId, GetProjectGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetProjectGroupHeaders headers = new GetProjectGroupHeaders();
        return this.getProjectGroupWithOptions(userId, request, headers, runtime);
    }

    /**
     * @summary 获取项目成员
     *
     * @param request GetProjectMemebersRequest
     * @param headers GetProjectMemebersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetProjectMemebersResponse
     */
    public GetProjectMemebersResponse getProjectMemebersWithOptions(String userId, String projectId, GetProjectMemebersRequest request, GetProjectMemebersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.projectRoleId)) {
            query.put("projectRoleId", request.projectRoleId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.skip)) {
            query.put("skip", request.skip);
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
            new TeaPair("action", "GetProjectMemebers"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/users/" + userId + "/projects/" + projectId + "/members"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetProjectMemebersResponse());
    }

    /**
     * @summary 获取项目成员
     *
     * @param request GetProjectMemebersRequest
     * @return GetProjectMemebersResponse
     */
    public GetProjectMemebersResponse getProjectMemebers(String userId, String projectId, GetProjectMemebersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetProjectMemebersHeaders headers = new GetProjectMemebersHeaders();
        return this.getProjectMemebersWithOptions(userId, projectId, request, headers, runtime);
    }

    /**
     * @summary 查询项目状态
     *
     * @param headers GetProjectStatusListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetProjectStatusListResponse
     */
    public GetProjectStatusListResponse getProjectStatusListWithOptions(String userId, String projectId, GetProjectStatusListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetProjectStatusList"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/users/" + userId + "/projects/" + projectId + "/statuses"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetProjectStatusListResponse());
    }

    /**
     * @summary 查询项目状态
     *
     * @return GetProjectStatusListResponse
     */
    public GetProjectStatusListResponse getProjectStatusList(String userId, String projectId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetProjectStatusListHeaders headers = new GetProjectStatusListHeaders();
        return this.getProjectStatusListWithOptions(userId, projectId, headers, runtime);
    }

    /**
     * @summary 获取任务详情
     *
     * @param request GetTaskByIdsRequest
     * @param headers GetTaskByIdsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetTaskByIdsResponse
     */
    public GetTaskByIdsResponse getTaskByIdsWithOptions(String userId, GetTaskByIdsRequest request, GetTaskByIdsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.parentTaskId)) {
            query.put("parentTaskId", request.parentTaskId);
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
            new TeaPair("action", "GetTaskByIds"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/users/" + userId + "/tasks"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetTaskByIdsResponse());
    }

    /**
     * @summary 获取任务详情
     *
     * @param request GetTaskByIdsRequest
     * @return GetTaskByIdsResponse
     */
    public GetTaskByIdsResponse getTaskByIds(String userId, GetTaskByIdsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetTaskByIdsHeaders headers = new GetTaskByIdsHeaders();
        return this.getTaskByIdsWithOptions(userId, request, headers, runtime);
    }

    /**
     * @summary 获取Teambition企业Id
     *
     * @param request GetTbOrgIdByDingOrgIdRequest
     * @param headers GetTbOrgIdByDingOrgIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetTbOrgIdByDingOrgIdResponse
     */
    public GetTbOrgIdByDingOrgIdResponse getTbOrgIdByDingOrgIdWithOptions(GetTbOrgIdByDingOrgIdRequest request, GetTbOrgIdByDingOrgIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.optUserId)) {
            query.put("optUserId", request.optUserId);
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
            new TeaPair("action", "GetTbOrgIdByDingOrgId"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/teambition/organizations"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetTbOrgIdByDingOrgIdResponse());
    }

    /**
     * @summary 获取Teambition企业Id
     *
     * @param request GetTbOrgIdByDingOrgIdRequest
     * @return GetTbOrgIdByDingOrgIdResponse
     */
    public GetTbOrgIdByDingOrgIdResponse getTbOrgIdByDingOrgId(GetTbOrgIdByDingOrgIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetTbOrgIdByDingOrgIdHeaders headers = new GetTbOrgIdByDingOrgIdHeaders();
        return this.getTbOrgIdByDingOrgIdWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取项目灰度标
     *
     * @param request GetTbProjectGrayRequest
     * @param headers GetTbProjectGrayHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetTbProjectGrayResponse
     */
    public GetTbProjectGrayResponse getTbProjectGrayWithOptions(GetTbProjectGrayRequest request, GetTbProjectGrayHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.label)) {
            body.put("label", request.label);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.dingAccessTokenType)) {
            realHeaders.put("dingAccessTokenType", com.aliyun.teautil.Common.toJSONString(headers.dingAccessTokenType));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.dingCorpId)) {
            realHeaders.put("dingCorpId", com.aliyun.teautil.Common.toJSONString(headers.dingCorpId));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.dingIsvOrgId)) {
            realHeaders.put("dingIsvOrgId", com.aliyun.teautil.Common.toJSONString(headers.dingIsvOrgId));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.dingOrgId)) {
            realHeaders.put("dingOrgId", com.aliyun.teautil.Common.toJSONString(headers.dingOrgId));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.dingSuiteKey)) {
            realHeaders.put("dingSuiteKey", com.aliyun.teautil.Common.toJSONString(headers.dingSuiteKey));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetTbProjectGray"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/projects/gray"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetTbProjectGrayResponse());
    }

    /**
     * @summary 获取项目灰度标
     *
     * @param request GetTbProjectGrayRequest
     * @return GetTbProjectGrayResponse
     */
    public GetTbProjectGrayResponse getTbProjectGray(GetTbProjectGrayRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetTbProjectGrayHeaders headers = new GetTbProjectGrayHeaders();
        return this.getTbProjectGrayWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取项目来源
     *
     * @param headers GetTbProjectSourceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetTbProjectSourceResponse
     */
    public GetTbProjectSourceResponse getTbProjectSourceWithOptions(GetTbProjectSourceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.dingAccessTokenType)) {
            realHeaders.put("dingAccessTokenType", com.aliyun.teautil.Common.toJSONString(headers.dingAccessTokenType));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.dingCorpId)) {
            realHeaders.put("dingCorpId", com.aliyun.teautil.Common.toJSONString(headers.dingCorpId));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.dingIsvOrgId)) {
            realHeaders.put("dingIsvOrgId", com.aliyun.teautil.Common.toJSONString(headers.dingIsvOrgId));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.dingOrgId)) {
            realHeaders.put("dingOrgId", com.aliyun.teautil.Common.toJSONString(headers.dingOrgId));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.dingSuiteKey)) {
            realHeaders.put("dingSuiteKey", com.aliyun.teautil.Common.toJSONString(headers.dingSuiteKey));
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetTbProjectSource"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/projects/source"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetTbProjectSourceResponse());
    }

    /**
     * @summary 获取项目来源
     *
     * @return GetTbProjectSourceResponse
     */
    public GetTbProjectSourceResponse getTbProjectSource() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetTbProjectSourceHeaders headers = new GetTbProjectSourceHeaders();
        return this.getTbProjectSourceWithOptions(headers, runtime);
    }

    /**
     * @summary 根据钉钉UserId获取Teambition用户Id
     *
     * @param request GetTbUserIdByStaffIdRequest
     * @param headers GetTbUserIdByStaffIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetTbUserIdByStaffIdResponse
     */
    public GetTbUserIdByStaffIdResponse getTbUserIdByStaffIdWithOptions(GetTbUserIdByStaffIdRequest request, GetTbUserIdByStaffIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.optUserId)) {
            query.put("optUserId", request.optUserId);
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
            new TeaPair("action", "GetTbUserIdByStaffId"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/teambition/users"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetTbUserIdByStaffIdResponse());
    }

    /**
     * @summary 根据钉钉UserId获取Teambition用户Id
     *
     * @param request GetTbUserIdByStaffIdRequest
     * @return GetTbUserIdByStaffIdResponse
     */
    public GetTbUserIdByStaffIdResponse getTbUserIdByStaffId(GetTbUserIdByStaffIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetTbUserIdByStaffIdHeaders headers = new GetTbUserIdByStaffIdHeaders();
        return this.getTbUserIdByStaffIdWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取用户加入的项目
     *
     * @param request GetUserJoinedProjectRequest
     * @param headers GetUserJoinedProjectHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetUserJoinedProjectResponse
     */
    public GetUserJoinedProjectResponse getUserJoinedProjectWithOptions(String userId, GetUserJoinedProjectRequest request, GetUserJoinedProjectHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetUserJoinedProject"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/users/" + userId + "/joinProjects"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetUserJoinedProjectResponse());
    }

    /**
     * @summary 获取用户加入的项目
     *
     * @param request GetUserJoinedProjectRequest
     * @return GetUserJoinedProjectResponse
     */
    public GetUserJoinedProjectResponse getUserJoinedProject(String userId, GetUserJoinedProjectRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetUserJoinedProjectHeaders headers = new GetUserJoinedProjectHeaders();
        return this.getUserJoinedProjectWithOptions(userId, request, headers, runtime);
    }

    /**
     * @summary 查询项目
     *
     * @param request QueryProjectRequest
     * @param headers QueryProjectHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryProjectResponse
     */
    public QueryProjectResponse queryProjectWithOptions(String userId, QueryProjectRequest request, QueryProjectHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryProject"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/users/" + userId + "/projects/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryProjectResponse());
    }

    /**
     * @summary 查询项目
     *
     * @param request QueryProjectRequest
     * @return QueryProjectResponse
     */
    public QueryProjectResponse queryProject(String userId, QueryProjectRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryProjectHeaders headers = new QueryProjectHeaders();
        return this.queryProjectWithOptions(userId, request, headers, runtime);
    }

    /**
     * @summary 查询项目中的任务
     *
     * @param request QueryTaskOfProjectRequest
     * @param headers QueryTaskOfProjectHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryTaskOfProjectResponse
     */
    public QueryTaskOfProjectResponse queryTaskOfProjectWithOptions(String userId, String projectId, QueryTaskOfProjectRequest request, QueryTaskOfProjectHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.query)) {
            query.put("query", request.query);
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
            new TeaPair("action", "QueryTaskOfProject"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/users/" + userId + "/projectIds/" + projectId + "/tasks"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryTaskOfProjectResponse());
    }

    /**
     * @summary 查询项目中的任务
     *
     * @param request QueryTaskOfProjectRequest
     * @return QueryTaskOfProjectResponse
     */
    public QueryTaskOfProjectResponse queryTaskOfProject(String userId, String projectId, QueryTaskOfProjectRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryTaskOfProjectHeaders headers = new QueryTaskOfProjectHeaders();
        return this.queryTaskOfProjectWithOptions(userId, projectId, request, headers, runtime);
    }

    /**
     * @summary 获取任务列表
     *
     * @param request SeachTaskStageRequest
     * @param headers SeachTaskStageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SeachTaskStageResponse
     */
    public SeachTaskStageResponse seachTaskStageWithOptions(String userId, String projectId, SeachTaskStageRequest request, SeachTaskStageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.query)) {
            query.put("query", request.query);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskListId)) {
            query.put("taskListId", request.taskListId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskStageIds)) {
            query.put("taskStageIds", request.taskStageIds);
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
            new TeaPair("action", "SeachTaskStage"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/users/" + userId + "/projects/" + projectId + "/taskStages/search"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SeachTaskStageResponse());
    }

    /**
     * @summary 获取任务列表
     *
     * @param request SeachTaskStageRequest
     * @return SeachTaskStageResponse
     */
    public SeachTaskStageResponse seachTaskStage(String userId, String projectId, SeachTaskStageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SeachTaskStageHeaders headers = new SeachTaskStageHeaders();
        return this.seachTaskStageWithOptions(userId, projectId, request, headers, runtime);
    }

    /**
     * @summary 通过TQL搜索自由任务和项目任务ID。
     *
     * @param request SearchAllTasksByTqlRequest
     * @param headers SearchAllTasksByTqlHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SearchAllTasksByTqlResponse
     */
    public SearchAllTasksByTqlResponse searchAllTasksByTqlWithOptions(String userId, SearchAllTasksByTqlRequest request, SearchAllTasksByTqlHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/users/" + userId + "/tql/tasks/search"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SearchAllTasksByTqlResponse());
    }

    /**
     * @summary 通过TQL搜索自由任务和项目任务ID。
     *
     * @param request SearchAllTasksByTqlRequest
     * @return SearchAllTasksByTqlResponse
     */
    public SearchAllTasksByTqlResponse searchAllTasksByTql(String userId, SearchAllTasksByTqlRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SearchAllTasksByTqlHeaders headers = new SearchAllTasksByTqlHeaders();
        return this.searchAllTasksByTqlWithOptions(userId, request, headers, runtime);
    }

    /**
     * @summary 查询企业自定义字段
     *
     * @param request SearchOranizationCustomfieldRequest
     * @param headers SearchOranizationCustomfieldHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SearchOranizationCustomfieldResponse
     */
    public SearchOranizationCustomfieldResponse searchOranizationCustomfieldWithOptions(String userId, SearchOranizationCustomfieldRequest request, SearchOranizationCustomfieldHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.customFieldIds)) {
            query.put("customFieldIds", request.customFieldIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instanceIds)) {
            query.put("instanceIds", request.instanceIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.projectIds)) {
            query.put("projectIds", request.projectIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.query)) {
            query.put("query", request.query);
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
            new TeaPair("action", "SearchOranizationCustomfield"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/organizations/users/" + userId + "/customfields/search"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SearchOranizationCustomfieldResponse());
    }

    /**
     * @summary 查询企业自定义字段
     *
     * @param request SearchOranizationCustomfieldRequest
     * @return SearchOranizationCustomfieldResponse
     */
    public SearchOranizationCustomfieldResponse searchOranizationCustomfield(String userId, SearchOranizationCustomfieldRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SearchOranizationCustomfieldHeaders headers = new SearchOranizationCustomfieldHeaders();
        return this.searchOranizationCustomfieldWithOptions(userId, request, headers, runtime);
    }

    /**
     * @summary 查询项目自定义字段
     *
     * @param request SearchProjectCustomfieldRequest
     * @param headers SearchProjectCustomfieldHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SearchProjectCustomfieldResponse
     */
    public SearchProjectCustomfieldResponse searchProjectCustomfieldWithOptions(String userId, String projectId, SearchProjectCustomfieldRequest request, SearchProjectCustomfieldHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.customFieldIds)) {
            query.put("customFieldIds", request.customFieldIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instanceIds)) {
            query.put("instanceIds", request.instanceIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.query)) {
            query.put("query", request.query);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scenarioFieldConfigId)) {
            query.put("scenarioFieldConfigId", request.scenarioFieldConfigId);
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
            new TeaPair("action", "SearchProjectCustomfield"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/users/" + userId + "/projects/" + projectId + "/customfields/search"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SearchProjectCustomfieldResponse());
    }

    /**
     * @summary 查询项目自定义字段
     *
     * @param request SearchProjectCustomfieldRequest
     * @return SearchProjectCustomfieldResponse
     */
    public SearchProjectCustomfieldResponse searchProjectCustomfield(String userId, String projectId, SearchProjectCustomfieldRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SearchProjectCustomfieldHeaders headers = new SearchProjectCustomfieldHeaders();
        return this.searchProjectCustomfieldWithOptions(userId, projectId, request, headers, runtime);
    }

    /**
     * @summary 按项目模板名字搜索企业自定义模板
     *
     * @param request SearchProjectTemplateRequest
     * @param headers SearchProjectTemplateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SearchProjectTemplateResponse
     */
    public SearchProjectTemplateResponse searchProjectTemplateWithOptions(String userId, SearchProjectTemplateRequest request, SearchProjectTemplateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.keyword)) {
            query.put("keyword", request.keyword);
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
            new TeaPair("action", "SearchProjectTemplate"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/organizations/users/" + userId + "/templates"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SearchProjectTemplateResponse());
    }

    /**
     * @summary 按项目模板名字搜索企业自定义模板
     *
     * @param request SearchProjectTemplateRequest
     * @return SearchProjectTemplateResponse
     */
    public SearchProjectTemplateResponse searchProjectTemplate(String userId, SearchProjectTemplateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SearchProjectTemplateHeaders headers = new SearchProjectTemplateHeaders();
        return this.searchProjectTemplateWithOptions(userId, request, headers, runtime);
    }

    /**
     * @summary 查询任务工作流
     *
     * @param request SearchTaskFlowRequest
     * @param headers SearchTaskFlowHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SearchTaskFlowResponse
     */
    public SearchTaskFlowResponse searchTaskFlowWithOptions(String userId, String projectId, SearchTaskFlowRequest request, SearchTaskFlowHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.query)) {
            query.put("query", request.query);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskflowIds)) {
            query.put("taskflowIds", request.taskflowIds);
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
            new TeaPair("action", "SearchTaskFlow"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/users/" + userId + "/projects/" + projectId + "/taskflows/search"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SearchTaskFlowResponse());
    }

    /**
     * @summary 查询任务工作流
     *
     * @param request SearchTaskFlowRequest
     * @return SearchTaskFlowResponse
     */
    public SearchTaskFlowResponse searchTaskFlow(String userId, String projectId, SearchTaskFlowRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SearchTaskFlowHeaders headers = new SearchTaskFlowHeaders();
        return this.searchTaskFlowWithOptions(userId, projectId, request, headers, runtime);
    }

    /**
     * @summary 查询任务分组
     *
     * @param request SearchTaskListRequest
     * @param headers SearchTaskListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SearchTaskListResponse
     */
    public SearchTaskListResponse searchTaskListWithOptions(String userId, String projectId, SearchTaskListRequest request, SearchTaskListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.query)) {
            query.put("query", request.query);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskListIds)) {
            query.put("taskListIds", request.taskListIds);
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
            new TeaPair("action", "SearchTaskList"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/users/" + userId + "/projects/" + projectId + "/taskLists/search"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SearchTaskListResponse());
    }

    /**
     * @summary 查询任务分组
     *
     * @param request SearchTaskListRequest
     * @return SearchTaskListResponse
     */
    public SearchTaskListResponse searchTaskList(String userId, String projectId, SearchTaskListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SearchTaskListHeaders headers = new SearchTaskListHeaders();
        return this.searchTaskListWithOptions(userId, projectId, request, headers, runtime);
    }

    /**
     * @summary 搜索任务工作流状态
     *
     * @param request SearchTaskflowStatusRequest
     * @param headers SearchTaskflowStatusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SearchTaskflowStatusResponse
     */
    public SearchTaskflowStatusResponse searchTaskflowStatusWithOptions(String userId, String projectId, SearchTaskflowStatusRequest request, SearchTaskflowStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.query)) {
            query.put("query", request.query);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tfIds)) {
            query.put("tfIds", request.tfIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tfsIds)) {
            query.put("tfsIds", request.tfsIds);
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
            new TeaPair("action", "SearchTaskflowStatus"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/users/" + userId + "/projects/" + projectId + "/taskflowStatuses/search"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SearchTaskflowStatusResponse());
    }

    /**
     * @summary 搜索任务工作流状态
     *
     * @param request SearchTaskflowStatusRequest
     * @return SearchTaskflowStatusResponse
     */
    public SearchTaskflowStatusResponse searchTaskflowStatus(String userId, String projectId, SearchTaskflowStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SearchTaskflowStatusHeaders headers = new SearchTaskflowStatusHeaders();
        return this.searchTaskflowStatusWithOptions(userId, projectId, request, headers, runtime);
    }

    /**
     * @summary 查询用户任务列表
     *
     * @param request SearchUserTaskRequest
     * @param headers SearchUserTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SearchUserTaskResponse
     */
    public SearchUserTaskResponse searchUserTaskWithOptions(String userId, SearchUserTaskRequest request, SearchUserTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roleTypes)) {
            query.put("roleTypes", request.roleTypes);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tql)) {
            query.put("tql", request.tql);
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
            new TeaPair("action", "SearchUserTask"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/users/" + userId + "/tasks/search"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SearchUserTaskResponse());
    }

    /**
     * @summary 查询用户任务列表
     *
     * @param request SearchUserTaskRequest
     * @return SearchUserTaskResponse
     */
    public SearchUserTaskResponse searchUserTask(String userId, SearchUserTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SearchUserTaskHeaders headers = new SearchUserTaskHeaders();
        return this.searchUserTaskWithOptions(userId, request, headers, runtime);
    }

    /**
     * @summary 归档项目
     *
     * @param headers SuspendProjectHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SuspendProjectResponse
     */
    public SuspendProjectResponse suspendProjectWithOptions(String projectId, String userId, SuspendProjectHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "SuspendProject"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/users/" + userId + "/projects/" + projectId + "/suspend"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SuspendProjectResponse());
    }

    /**
     * @summary 归档项目
     *
     * @return SuspendProjectResponse
     */
    public SuspendProjectResponse suspendProject(String projectId, String userId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SuspendProjectHeaders headers = new SuspendProjectHeaders();
        return this.suspendProjectWithOptions(projectId, userId, headers, runtime);
    }

    /**
     * @summary 恢复项目归档
     *
     * @param headers UnSuspendProjectHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UnSuspendProjectResponse
     */
    public UnSuspendProjectResponse unSuspendProjectWithOptions(String projectId, String userId, UnSuspendProjectHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "UnSuspendProject"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/users/" + userId + "/projects/" + projectId + "/unsuspend"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UnSuspendProjectResponse());
    }

    /**
     * @summary 恢复项目归档
     *
     * @return UnSuspendProjectResponse
     */
    public UnSuspendProjectResponse unSuspendProject(String projectId, String userId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UnSuspendProjectHeaders headers = new UnSuspendProjectHeaders();
        return this.unSuspendProjectWithOptions(projectId, userId, headers, runtime);
    }

    /**
     * @summary 更新任务自定义字段的值
     *
     * @param request UpdateCustomfieldValueRequest
     * @param headers UpdateCustomfieldValueHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateCustomfieldValueResponse
     */
    public UpdateCustomfieldValueResponse updateCustomfieldValueWithOptions(String userId, String taskId, UpdateCustomfieldValueRequest request, UpdateCustomfieldValueHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.customFieldId)) {
            body.put("customFieldId", request.customFieldId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.customFieldName)) {
            body.put("customFieldName", request.customFieldName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.value)) {
            body.put("value", request.value);
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
            new TeaPair("action", "UpdateCustomfieldValue"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/users/" + userId + "/tasks/" + taskId + "/customFields"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateCustomfieldValueResponse());
    }

    /**
     * @summary 更新任务自定义字段的值
     *
     * @param request UpdateCustomfieldValueRequest
     * @return UpdateCustomfieldValueResponse
     */
    public UpdateCustomfieldValueResponse updateCustomfieldValue(String userId, String taskId, UpdateCustomfieldValueRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateCustomfieldValueHeaders headers = new UpdateCustomfieldValueHeaders();
        return this.updateCustomfieldValueWithOptions(userId, taskId, request, headers, runtime);
    }

    /**
     * @summary 更改自由任务标题
     *
     * @param request UpdateOrganizationTaskContentRequest
     * @param headers UpdateOrganizationTaskContentHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateOrganizationTaskContentResponse
     */
    public UpdateOrganizationTaskContentResponse updateOrganizationTaskContentWithOptions(String taskId, String userId, UpdateOrganizationTaskContentRequest request, UpdateOrganizationTaskContentHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "UpdateOrganizationTaskContent"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/organizations/users/" + userId + "/tasks/" + taskId + "/contents"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateOrganizationTaskContentResponse());
    }

    /**
     * @summary 更改自由任务标题
     *
     * @param request UpdateOrganizationTaskContentRequest
     * @return UpdateOrganizationTaskContentResponse
     */
    public UpdateOrganizationTaskContentResponse updateOrganizationTaskContent(String taskId, String userId, UpdateOrganizationTaskContentRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateOrganizationTaskContentHeaders headers = new UpdateOrganizationTaskContentHeaders();
        return this.updateOrganizationTaskContentWithOptions(taskId, userId, request, headers, runtime);
    }

    /**
     * @summary 更新自由任务截止时间
     *
     * @param request UpdateOrganizationTaskDueDateRequest
     * @param headers UpdateOrganizationTaskDueDateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateOrganizationTaskDueDateResponse
     */
    public UpdateOrganizationTaskDueDateResponse updateOrganizationTaskDueDateWithOptions(String taskId, String userId, UpdateOrganizationTaskDueDateRequest request, UpdateOrganizationTaskDueDateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.disableActivity)) {
            body.put("disableActivity", request.disableActivity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.disableNotification)) {
            body.put("disableNotification", request.disableNotification);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dueDate)) {
            body.put("dueDate", request.dueDate);
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
            new TeaPair("action", "UpdateOrganizationTaskDueDate"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/organizations/users/" + userId + "/tasks/" + taskId + "/dueDates"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateOrganizationTaskDueDateResponse());
    }

    /**
     * @summary 更新自由任务截止时间
     *
     * @param request UpdateOrganizationTaskDueDateRequest
     * @return UpdateOrganizationTaskDueDateResponse
     */
    public UpdateOrganizationTaskDueDateResponse updateOrganizationTaskDueDate(String taskId, String userId, UpdateOrganizationTaskDueDateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateOrganizationTaskDueDateHeaders headers = new UpdateOrganizationTaskDueDateHeaders();
        return this.updateOrganizationTaskDueDateWithOptions(taskId, userId, request, headers, runtime);
    }

    /**
     * @summary 更改自由任务执行者
     *
     * @param request UpdateOrganizationTaskExecutorRequest
     * @param headers UpdateOrganizationTaskExecutorHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateOrganizationTaskExecutorResponse
     */
    public UpdateOrganizationTaskExecutorResponse updateOrganizationTaskExecutorWithOptions(String taskId, String userId, UpdateOrganizationTaskExecutorRequest request, UpdateOrganizationTaskExecutorHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.disableActivity)) {
            body.put("disableActivity", request.disableActivity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.disableNotification)) {
            body.put("disableNotification", request.disableNotification);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.executorId)) {
            body.put("executorId", request.executorId);
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
            new TeaPair("action", "UpdateOrganizationTaskExecutor"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/organizations/users/" + userId + "/tasks/" + taskId + "/executors"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateOrganizationTaskExecutorResponse());
    }

    /**
     * @summary 更改自由任务执行者
     *
     * @param request UpdateOrganizationTaskExecutorRequest
     * @return UpdateOrganizationTaskExecutorResponse
     */
    public UpdateOrganizationTaskExecutorResponse updateOrganizationTaskExecutor(String taskId, String userId, UpdateOrganizationTaskExecutorRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateOrganizationTaskExecutorHeaders headers = new UpdateOrganizationTaskExecutorHeaders();
        return this.updateOrganizationTaskExecutorWithOptions(taskId, userId, request, headers, runtime);
    }

    /**
     * @summary 更新自由任务参与者
     *
     * @param request UpdateOrganizationTaskInvolveMembersRequest
     * @param headers UpdateOrganizationTaskInvolveMembersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateOrganizationTaskInvolveMembersResponse
     */
    public UpdateOrganizationTaskInvolveMembersResponse updateOrganizationTaskInvolveMembersWithOptions(String taskId, String userId, UpdateOrganizationTaskInvolveMembersRequest request, UpdateOrganizationTaskInvolveMembersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.addInvolvers)) {
            body.put("addInvolvers", request.addInvolvers);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.delInvolvers)) {
            body.put("delInvolvers", request.delInvolvers);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.disableActivity)) {
            body.put("disableActivity", request.disableActivity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.disableNotification)) {
            body.put("disableNotification", request.disableNotification);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.involveMembers)) {
            body.put("involveMembers", request.involveMembers);
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
            new TeaPair("action", "UpdateOrganizationTaskInvolveMembers"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/organizations/users/" + userId + "/tasks/" + taskId + "/involveMembers"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateOrganizationTaskInvolveMembersResponse());
    }

    /**
     * @summary 更新自由任务参与者
     *
     * @param request UpdateOrganizationTaskInvolveMembersRequest
     * @return UpdateOrganizationTaskInvolveMembersResponse
     */
    public UpdateOrganizationTaskInvolveMembersResponse updateOrganizationTaskInvolveMembers(String taskId, String userId, UpdateOrganizationTaskInvolveMembersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateOrganizationTaskInvolveMembersHeaders headers = new UpdateOrganizationTaskInvolveMembersHeaders();
        return this.updateOrganizationTaskInvolveMembersWithOptions(taskId, userId, request, headers, runtime);
    }

    /**
     * @summary 更改自由任务备注
     *
     * @param request UpdateOrganizationTaskNoteRequest
     * @param headers UpdateOrganizationTaskNoteHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateOrganizationTaskNoteResponse
     */
    public UpdateOrganizationTaskNoteResponse updateOrganizationTaskNoteWithOptions(String taskId, String userId, UpdateOrganizationTaskNoteRequest request, UpdateOrganizationTaskNoteHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.disableActivity)) {
            body.put("disableActivity", request.disableActivity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.disableNotification)) {
            body.put("disableNotification", request.disableNotification);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.note)) {
            body.put("note", request.note);
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
            new TeaPair("action", "UpdateOrganizationTaskNote"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/organizations/users/" + userId + "/tasks/" + taskId + "/notes"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateOrganizationTaskNoteResponse());
    }

    /**
     * @summary 更改自由任务备注
     *
     * @param request UpdateOrganizationTaskNoteRequest
     * @return UpdateOrganizationTaskNoteResponse
     */
    public UpdateOrganizationTaskNoteResponse updateOrganizationTaskNote(String taskId, String userId, UpdateOrganizationTaskNoteRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateOrganizationTaskNoteHeaders headers = new UpdateOrganizationTaskNoteHeaders();
        return this.updateOrganizationTaskNoteWithOptions(taskId, userId, request, headers, runtime);
    }

    /**
     * @summary 更新自由任务优先级
     *
     * @param request UpdateOrganizationTaskPriorityRequest
     * @param headers UpdateOrganizationTaskPriorityHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateOrganizationTaskPriorityResponse
     */
    public UpdateOrganizationTaskPriorityResponse updateOrganizationTaskPriorityWithOptions(String taskId, String userId, UpdateOrganizationTaskPriorityRequest request, UpdateOrganizationTaskPriorityHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.disableActivity)) {
            body.put("disableActivity", request.disableActivity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.disableNotification)) {
            body.put("disableNotification", request.disableNotification);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.priority)) {
            body.put("priority", request.priority);
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
            new TeaPair("action", "UpdateOrganizationTaskPriority"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/organizations/users/" + userId + "/tasks/" + taskId + "/priorities"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateOrganizationTaskPriorityResponse());
    }

    /**
     * @summary 更新自由任务优先级
     *
     * @param request UpdateOrganizationTaskPriorityRequest
     * @return UpdateOrganizationTaskPriorityResponse
     */
    public UpdateOrganizationTaskPriorityResponse updateOrganizationTaskPriority(String taskId, String userId, UpdateOrganizationTaskPriorityRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateOrganizationTaskPriorityHeaders headers = new UpdateOrganizationTaskPriorityHeaders();
        return this.updateOrganizationTaskPriorityWithOptions(taskId, userId, request, headers, runtime);
    }

    /**
     * @summary 更改自由任务状态
     *
     * @param request UpdateOrganizationTaskStatusRequest
     * @param headers UpdateOrganizationTaskStatusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateOrganizationTaskStatusResponse
     */
    public UpdateOrganizationTaskStatusResponse updateOrganizationTaskStatusWithOptions(String taskId, String userId, UpdateOrganizationTaskStatusRequest request, UpdateOrganizationTaskStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.disableActivity)) {
            body.put("disableActivity", request.disableActivity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.disableNotification)) {
            body.put("disableNotification", request.disableNotification);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isDone)) {
            body.put("isDone", request.isDone);
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
            new TeaPair("action", "UpdateOrganizationTaskStatus"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/organizations/users/" + userId + "/tasks/" + taskId + "/states"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateOrganizationTaskStatusResponse());
    }

    /**
     * @summary 更改自由任务状态
     *
     * @param request UpdateOrganizationTaskStatusRequest
     * @return UpdateOrganizationTaskStatusResponse
     */
    public UpdateOrganizationTaskStatusResponse updateOrganizationTaskStatus(String taskId, String userId, UpdateOrganizationTaskStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateOrganizationTaskStatusHeaders headers = new UpdateOrganizationTaskStatusHeaders();
        return this.updateOrganizationTaskStatusWithOptions(taskId, userId, request, headers, runtime);
    }

    /**
     * @summary 更新项目的分组
     *
     * @param request UpdateProjectGroupRequest
     * @param headers UpdateProjectGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateProjectGroupResponse
     */
    public UpdateProjectGroupResponse updateProjectGroupWithOptions(String userId, String projectId, UpdateProjectGroupRequest request, UpdateProjectGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.addProjectGroupIds)) {
            body.put("addProjectGroupIds", request.addProjectGroupIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.delProjectGroupIds)) {
            body.put("delProjectGroupIds", request.delProjectGroupIds);
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
            new TeaPair("action", "UpdateProjectGroup"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/users/" + userId + "/projects/" + projectId + "/groups"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateProjectGroupResponse());
    }

    /**
     * @summary 更新项目的分组
     *
     * @param request UpdateProjectGroupRequest
     * @return UpdateProjectGroupResponse
     */
    public UpdateProjectGroupResponse updateProjectGroup(String userId, String projectId, UpdateProjectGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateProjectGroupHeaders headers = new UpdateProjectGroupHeaders();
        return this.updateProjectGroupWithOptions(userId, projectId, request, headers, runtime);
    }

    /**
     * @summary 更新任务标题
     *
     * @param request UpdateTaskContentRequest
     * @param headers UpdateTaskContentHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateTaskContentResponse
     */
    public UpdateTaskContentResponse updateTaskContentWithOptions(String userId, String taskId, UpdateTaskContentRequest request, UpdateTaskContentHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.content)) {
            body.put("content", request.content);
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
            new TeaPair("action", "UpdateTaskContent"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/users/" + userId + "/tasks/" + taskId + "/contents"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateTaskContentResponse());
    }

    /**
     * @summary 更新任务标题
     *
     * @param request UpdateTaskContentRequest
     * @return UpdateTaskContentResponse
     */
    public UpdateTaskContentResponse updateTaskContent(String userId, String taskId, UpdateTaskContentRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateTaskContentHeaders headers = new UpdateTaskContentHeaders();
        return this.updateTaskContentWithOptions(userId, taskId, request, headers, runtime);
    }

    /**
     * @summary 更新任务截止时间
     *
     * @param request UpdateTaskDueDateRequest
     * @param headers UpdateTaskDueDateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateTaskDueDateResponse
     */
    public UpdateTaskDueDateResponse updateTaskDueDateWithOptions(String userId, String taskId, UpdateTaskDueDateRequest request, UpdateTaskDueDateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dueDate)) {
            body.put("dueDate", request.dueDate);
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
            new TeaPair("action", "UpdateTaskDueDate"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/users/" + userId + "/tasks/" + taskId + "/dueDates"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateTaskDueDateResponse());
    }

    /**
     * @summary 更新任务截止时间
     *
     * @param request UpdateTaskDueDateRequest
     * @return UpdateTaskDueDateResponse
     */
    public UpdateTaskDueDateResponse updateTaskDueDate(String userId, String taskId, UpdateTaskDueDateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateTaskDueDateHeaders headers = new UpdateTaskDueDateHeaders();
        return this.updateTaskDueDateWithOptions(userId, taskId, request, headers, runtime);
    }

    /**
     * @summary 更新任务执行者
     *
     * @param request UpdateTaskExecutorRequest
     * @param headers UpdateTaskExecutorHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateTaskExecutorResponse
     */
    public UpdateTaskExecutorResponse updateTaskExecutorWithOptions(String userId, String taskId, UpdateTaskExecutorRequest request, UpdateTaskExecutorHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.executorId)) {
            body.put("executorId", request.executorId);
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
            new TeaPair("action", "UpdateTaskExecutor"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/users/" + userId + "/tasks/" + taskId + "/executors"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateTaskExecutorResponse());
    }

    /**
     * @summary 更新任务执行者
     *
     * @param request UpdateTaskExecutorRequest
     * @return UpdateTaskExecutorResponse
     */
    public UpdateTaskExecutorResponse updateTaskExecutor(String userId, String taskId, UpdateTaskExecutorRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateTaskExecutorHeaders headers = new UpdateTaskExecutorHeaders();
        return this.updateTaskExecutorWithOptions(userId, taskId, request, headers, runtime);
    }

    /**
     * @summary 更新任务参与者
     *
     * @param request UpdateTaskInvolvemembersRequest
     * @param headers UpdateTaskInvolvemembersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateTaskInvolvemembersResponse
     */
    public UpdateTaskInvolvemembersResponse updateTaskInvolvemembersWithOptions(String userId, String taskId, UpdateTaskInvolvemembersRequest request, UpdateTaskInvolvemembersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.addInvolvers)) {
            body.put("addInvolvers", request.addInvolvers);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.delInvolvers)) {
            body.put("delInvolvers", request.delInvolvers);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.involveMembers)) {
            body.put("involveMembers", request.involveMembers);
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
            new TeaPair("action", "UpdateTaskInvolvemembers"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/users/" + userId + "/tasks/" + taskId + "/involveMembers"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateTaskInvolvemembersResponse());
    }

    /**
     * @summary 更新任务参与者
     *
     * @param request UpdateTaskInvolvemembersRequest
     * @return UpdateTaskInvolvemembersResponse
     */
    public UpdateTaskInvolvemembersResponse updateTaskInvolvemembers(String userId, String taskId, UpdateTaskInvolvemembersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateTaskInvolvemembersHeaders headers = new UpdateTaskInvolvemembersHeaders();
        return this.updateTaskInvolvemembersWithOptions(userId, taskId, request, headers, runtime);
    }

    /**
     * @summary 更新任务备注
     *
     * @param request UpdateTaskNoteRequest
     * @param headers UpdateTaskNoteHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateTaskNoteResponse
     */
    public UpdateTaskNoteResponse updateTaskNoteWithOptions(String userId, String taskId, UpdateTaskNoteRequest request, UpdateTaskNoteHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.note)) {
            body.put("note", request.note);
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
            new TeaPair("action", "UpdateTaskNote"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/users/" + userId + "/tasks/" + taskId + "/notes"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateTaskNoteResponse());
    }

    /**
     * @summary 更新任务备注
     *
     * @param request UpdateTaskNoteRequest
     * @return UpdateTaskNoteResponse
     */
    public UpdateTaskNoteResponse updateTaskNote(String userId, String taskId, UpdateTaskNoteRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateTaskNoteHeaders headers = new UpdateTaskNoteHeaders();
        return this.updateTaskNoteWithOptions(userId, taskId, request, headers, runtime);
    }

    /**
     * @summary 更新任务优先级
     *
     * @param request UpdateTaskPriorityRequest
     * @param headers UpdateTaskPriorityHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateTaskPriorityResponse
     */
    public UpdateTaskPriorityResponse updateTaskPriorityWithOptions(String userId, String taskId, UpdateTaskPriorityRequest request, UpdateTaskPriorityHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.priority)) {
            body.put("priority", request.priority);
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
            new TeaPair("action", "UpdateTaskPriority"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/users/" + userId + "/tasks/" + taskId + "/priorities"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateTaskPriorityResponse());
    }

    /**
     * @summary 更新任务优先级
     *
     * @param request UpdateTaskPriorityRequest
     * @return UpdateTaskPriorityResponse
     */
    public UpdateTaskPriorityResponse updateTaskPriority(String userId, String taskId, UpdateTaskPriorityRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateTaskPriorityHeaders headers = new UpdateTaskPriorityHeaders();
        return this.updateTaskPriorityWithOptions(userId, taskId, request, headers, runtime);
    }

    /**
     * @summary 更新任务列表
     *
     * @param request UpdateTaskStageRequest
     * @param headers UpdateTaskStageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateTaskStageResponse
     */
    public UpdateTaskStageResponse updateTaskStageWithOptions(String userId, String taskId, UpdateTaskStageRequest request, UpdateTaskStageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.taskStageId)) {
            body.put("taskStageId", request.taskStageId);
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
            new TeaPair("action", "UpdateTaskStage"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/users/" + userId + "/tasks/" + taskId + "/stages"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateTaskStageResponse());
    }

    /**
     * @summary 更新任务列表
     *
     * @param request UpdateTaskStageRequest
     * @return UpdateTaskStageResponse
     */
    public UpdateTaskStageResponse updateTaskStage(String userId, String taskId, UpdateTaskStageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateTaskStageHeaders headers = new UpdateTaskStageHeaders();
        return this.updateTaskStageWithOptions(userId, taskId, request, headers, runtime);
    }

    /**
     * @summary 更新任务开始时间
     *
     * @param request UpdateTaskStartdateRequest
     * @param headers UpdateTaskStartdateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateTaskStartdateResponse
     */
    public UpdateTaskStartdateResponse updateTaskStartdateWithOptions(String userId, String taskId, UpdateTaskStartdateRequest request, UpdateTaskStartdateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.startDate)) {
            body.put("startDate", request.startDate);
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
            new TeaPair("action", "UpdateTaskStartdate"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/users/" + userId + "/tasks/" + taskId + "/startDates"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateTaskStartdateResponse());
    }

    /**
     * @summary 更新任务开始时间
     *
     * @param request UpdateTaskStartdateRequest
     * @return UpdateTaskStartdateResponse
     */
    public UpdateTaskStartdateResponse updateTaskStartdate(String userId, String taskId, UpdateTaskStartdateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateTaskStartdateHeaders headers = new UpdateTaskStartdateHeaders();
        return this.updateTaskStartdateWithOptions(userId, taskId, request, headers, runtime);
    }

    /**
     * @summary 更新任务工作流状态
     *
     * @param request UpdateTaskTaskflowstatusRequest
     * @param headers UpdateTaskTaskflowstatusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateTaskTaskflowstatusResponse
     */
    public UpdateTaskTaskflowstatusResponse updateTaskTaskflowstatusWithOptions(String userId, String taskId, UpdateTaskTaskflowstatusRequest request, UpdateTaskTaskflowstatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.taskflowStatusId)) {
            body.put("taskflowStatusId", request.taskflowStatusId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskflowStatusUpdateNote)) {
            body.put("taskflowStatusUpdateNote", request.taskflowStatusUpdateNote);
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
            new TeaPair("action", "UpdateTaskTaskflowstatus"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/users/" + userId + "/tasks/" + taskId + "/taskflowStatuses"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateTaskTaskflowstatusResponse());
    }

    /**
     * @summary 更新任务工作流状态
     *
     * @param request UpdateTaskTaskflowstatusRequest
     * @return UpdateTaskTaskflowstatusResponse
     */
    public UpdateTaskTaskflowstatusResponse updateTaskTaskflowstatus(String userId, String taskId, UpdateTaskTaskflowstatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateTaskTaskflowstatusHeaders headers = new UpdateTaskTaskflowstatusHeaders();
        return this.updateTaskTaskflowstatusWithOptions(userId, taskId, request, headers, runtime);
    }

    /**
     * @summary 更新工时审批对象
     *
     * @param request UpdateWorkTimeApproveRequest
     * @param headers UpdateWorkTimeApproveHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateWorkTimeApproveResponse
     */
    public UpdateWorkTimeApproveResponse updateWorkTimeApproveWithOptions(String userId, String approveOpenId, UpdateWorkTimeApproveRequest request, UpdateWorkTimeApproveHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.finishTime)) {
            body.put("finishTime", request.finishTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instanceId)) {
            body.put("instanceId", request.instanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.submitTime)) {
            body.put("submitTime", request.submitTime);
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
            new TeaPair("action", "UpdateWorkTimeApprove"),
            new TeaPair("version", "project_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/project/users/" + userId + "/workTimes/approvals/" + approveOpenId + ""),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateWorkTimeApproveResponse());
    }

    /**
     * @summary 更新工时审批对象
     *
     * @param request UpdateWorkTimeApproveRequest
     * @return UpdateWorkTimeApproveResponse
     */
    public UpdateWorkTimeApproveResponse updateWorkTimeApprove(String userId, String approveOpenId, UpdateWorkTimeApproveRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateWorkTimeApproveHeaders headers = new UpdateWorkTimeApproveHeaders();
        return this.updateWorkTimeApproveWithOptions(userId, approveOpenId, request, headers, runtime);
    }
}
