// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkproject_1_0.models.*;
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


    public AddProjectMemberResponse addProjectMember(String userId, String projectId, AddProjectMemberRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AddProjectMemberHeaders headers = new AddProjectMemberHeaders();
        return this.addProjectMemberWithOptions(userId, projectId, request, headers, runtime);
    }

    public AddProjectMemberResponse addProjectMemberWithOptions(String userId, String projectId, AddProjectMemberRequest request, AddProjectMemberHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        projectId = com.aliyun.openapiutil.Client.getEncodeParam(projectId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("AddProjectMember", "project_1.0", "HTTP", "POST", "AK", "/v1.0/project/users/" + userId + "/projects/" + projectId + "/members", "json", req, runtime), new AddProjectMemberResponse());
    }

    public CreateOrganizationTaskResponse createOrganizationTask(String userId, CreateOrganizationTaskRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateOrganizationTaskHeaders headers = new CreateOrganizationTaskHeaders();
        return this.createOrganizationTaskWithOptions(userId, request, headers, runtime);
    }

    public CreateOrganizationTaskResponse createOrganizationTaskWithOptions(String userId, CreateOrganizationTaskRequest request, CreateOrganizationTaskHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateOrganizationTask", "project_1.0", "HTTP", "POST", "AK", "/v1.0/project/organizations/users/" + userId + "/tasks", "json", req, runtime), new CreateOrganizationTaskResponse());
    }

    public CreateProjectByTemplateResponse createProjectByTemplate(String userId, CreateProjectByTemplateRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateProjectByTemplateHeaders headers = new CreateProjectByTemplateHeaders();
        return this.createProjectByTemplateWithOptions(userId, request, headers, runtime);
    }

    public CreateProjectByTemplateResponse createProjectByTemplateWithOptions(String userId, CreateProjectByTemplateRequest request, CreateProjectByTemplateHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateProjectByTemplate", "project_1.0", "HTTP", "POST", "AK", "/v1.0/project/users/" + userId + "/templates/projects", "json", req, runtime), new CreateProjectByTemplateResponse());
    }

    public CreateTaskResponse createTask(String userId, CreateTaskRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateTaskHeaders headers = new CreateTaskHeaders();
        return this.createTaskWithOptions(userId, request, headers, runtime);
    }

    public CreateTaskResponse createTaskWithOptions(String userId, CreateTaskRequest request, CreateTaskHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
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

        if (!com.aliyun.teautil.Common.isUnset(request.priority)) {
            body.put("priority", request.priority);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateTask", "project_1.0", "HTTP", "POST", "AK", "/v1.0/project/users/" + userId + "/tasks", "json", req, runtime), new CreateTaskResponse());
    }

    public CreateTaskObjectLinkResponse createTaskObjectLink(String userId, String taskId, CreateTaskObjectLinkRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateTaskObjectLinkHeaders headers = new CreateTaskObjectLinkHeaders();
        return this.createTaskObjectLinkWithOptions(userId, taskId, request, headers, runtime);
    }

    public CreateTaskObjectLinkResponse createTaskObjectLinkWithOptions(String userId, String taskId, CreateTaskObjectLinkRequest request, CreateTaskObjectLinkHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        taskId = com.aliyun.openapiutil.Client.getEncodeParam(taskId);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.linkedData))) {
            body.put("linkedData", request.linkedData);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateTaskObjectLink", "project_1.0", "HTTP", "POST", "AK", "/v1.0/project/users/" + userId + "/tasks/" + taskId + "/objectLinks", "json", req, runtime), new CreateTaskObjectLinkResponse());
    }

    public GetDeptsByOrgIdResponse getDeptsByOrgId(GetDeptsByOrgIdRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetDeptsByOrgIdHeaders headers = new GetDeptsByOrgIdHeaders();
        return this.getDeptsByOrgIdWithOptions(request, headers, runtime);
    }

    public GetDeptsByOrgIdResponse getDeptsByOrgIdWithOptions(GetDeptsByOrgIdRequest request, GetDeptsByOrgIdHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetDeptsByOrgId", "project_1.0", "HTTP", "GET", "AK", "/v1.0/project/orgs/depts", "json", req, runtime), new GetDeptsByOrgIdResponse());
    }

    public GetEmpsByOrgIdResponse getEmpsByOrgId(GetEmpsByOrgIdRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetEmpsByOrgIdHeaders headers = new GetEmpsByOrgIdHeaders();
        return this.getEmpsByOrgIdWithOptions(request, headers, runtime);
    }

    public GetEmpsByOrgIdResponse getEmpsByOrgIdWithOptions(GetEmpsByOrgIdRequest request, GetEmpsByOrgIdHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetEmpsByOrgId", "project_1.0", "HTTP", "GET", "AK", "/v1.0/project/orgs/employees", "json", req, runtime), new GetEmpsByOrgIdResponse());
    }

    public GetOrganizatioTaskByIdsResponse getOrganizatioTaskByIds(String userId, GetOrganizatioTaskByIdsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetOrganizatioTaskByIdsHeaders headers = new GetOrganizatioTaskByIdsHeaders();
        return this.getOrganizatioTaskByIdsWithOptions(userId, request, headers, runtime);
    }

    public GetOrganizatioTaskByIdsResponse getOrganizatioTaskByIdsWithOptions(String userId, GetOrganizatioTaskByIdsRequest request, GetOrganizatioTaskByIdsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetOrganizatioTaskByIds", "project_1.0", "HTTP", "GET", "AK", "/v1.0/project/organizations/users/" + userId + "/tasks", "json", req, runtime), new GetOrganizatioTaskByIdsResponse());
    }

    public GetOrganizationPriorityListResponse getOrganizationPriorityList(String userId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetOrganizationPriorityListHeaders headers = new GetOrganizationPriorityListHeaders();
        return this.getOrganizationPriorityListWithOptions(userId, headers, runtime);
    }

    public GetOrganizationPriorityListResponse getOrganizationPriorityListWithOptions(String userId, GetOrganizationPriorityListHeaders headers, RuntimeOptions runtime) throws Exception {
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("GetOrganizationPriorityList", "project_1.0", "HTTP", "GET", "AK", "/v1.0/project/organizations/users/" + userId + "/priorities", "json", req, runtime), new GetOrganizationPriorityListResponse());
    }

    public GetOrganizationTaskResponse getOrganizationTask(String taskId, String userId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetOrganizationTaskHeaders headers = new GetOrganizationTaskHeaders();
        return this.getOrganizationTaskWithOptions(taskId, userId, headers, runtime);
    }

    public GetOrganizationTaskResponse getOrganizationTaskWithOptions(String taskId, String userId, GetOrganizationTaskHeaders headers, RuntimeOptions runtime) throws Exception {
        taskId = com.aliyun.openapiutil.Client.getEncodeParam(taskId);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("GetOrganizationTask", "project_1.0", "HTTP", "GET", "AK", "/v1.0/project/organizations/users/" + userId + "/tasks/" + taskId + "", "json", req, runtime), new GetOrganizationTaskResponse());
    }

    public GetProjectGroupResponse getProjectGroup(String userId, GetProjectGroupRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetProjectGroupHeaders headers = new GetProjectGroupHeaders();
        return this.getProjectGroupWithOptions(userId, request, headers, runtime);
    }

    public GetProjectGroupResponse getProjectGroupWithOptions(String userId, GetProjectGroupRequest request, GetProjectGroupHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetProjectGroup", "project_1.0", "HTTP", "GET", "AK", "/v1.0/project/organizations/users/" + userId + "/groups", "json", req, runtime), new GetProjectGroupResponse());
    }

    public GetTbOrgIdByDingOrgIdResponse getTbOrgIdByDingOrgId(GetTbOrgIdByDingOrgIdRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetTbOrgIdByDingOrgIdHeaders headers = new GetTbOrgIdByDingOrgIdHeaders();
        return this.getTbOrgIdByDingOrgIdWithOptions(request, headers, runtime);
    }

    public GetTbOrgIdByDingOrgIdResponse getTbOrgIdByDingOrgIdWithOptions(GetTbOrgIdByDingOrgIdRequest request, GetTbOrgIdByDingOrgIdHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetTbOrgIdByDingOrgId", "project_1.0", "HTTP", "GET", "AK", "/v1.0/project/teambition/organizations", "json", req, runtime), new GetTbOrgIdByDingOrgIdResponse());
    }

    public GetTbProjectGrayResponse getTbProjectGray(GetTbProjectGrayRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetTbProjectGrayHeaders headers = new GetTbProjectGrayHeaders();
        return this.getTbProjectGrayWithOptions(request, headers, runtime);
    }

    public GetTbProjectGrayResponse getTbProjectGrayWithOptions(GetTbProjectGrayRequest request, GetTbProjectGrayHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("GetTbProjectGray", "project_1.0", "HTTP", "POST", "AK", "/v1.0/project/projects/gray", "json", req, runtime), new GetTbProjectGrayResponse());
    }

    public GetTbProjectSourceResponse getTbProjectSource() throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetTbProjectSourceHeaders headers = new GetTbProjectSourceHeaders();
        return this.getTbProjectSourceWithOptions(headers, runtime);
    }

    public GetTbProjectSourceResponse getTbProjectSourceWithOptions(GetTbProjectSourceHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("GetTbProjectSource", "project_1.0", "HTTP", "POST", "AK", "/v1.0/project/projects/source", "json", req, runtime), new GetTbProjectSourceResponse());
    }

    public GetTbUserIdByStaffIdResponse getTbUserIdByStaffId(GetTbUserIdByStaffIdRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetTbUserIdByStaffIdHeaders headers = new GetTbUserIdByStaffIdHeaders();
        return this.getTbUserIdByStaffIdWithOptions(request, headers, runtime);
    }

    public GetTbUserIdByStaffIdResponse getTbUserIdByStaffIdWithOptions(GetTbUserIdByStaffIdRequest request, GetTbUserIdByStaffIdHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetTbUserIdByStaffId", "project_1.0", "HTTP", "GET", "AK", "/v1.0/project/teambition/users", "json", req, runtime), new GetTbUserIdByStaffIdResponse());
    }

    public SearchProjectTemplateResponse searchProjectTemplate(String userId, SearchProjectTemplateRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        SearchProjectTemplateHeaders headers = new SearchProjectTemplateHeaders();
        return this.searchProjectTemplateWithOptions(userId, request, headers, runtime);
    }

    public SearchProjectTemplateResponse searchProjectTemplateWithOptions(String userId, SearchProjectTemplateRequest request, SearchProjectTemplateHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("SearchProjectTemplate", "project_1.0", "HTTP", "GET", "AK", "/v1.0/project/organizations/users/" + userId + "/templates", "json", req, runtime), new SearchProjectTemplateResponse());
    }

    public UpdateCustomfieldValueResponse updateCustomfieldValue(String userId, String taskId, UpdateCustomfieldValueRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateCustomfieldValueHeaders headers = new UpdateCustomfieldValueHeaders();
        return this.updateCustomfieldValueWithOptions(userId, taskId, request, headers, runtime);
    }

    public UpdateCustomfieldValueResponse updateCustomfieldValueWithOptions(String userId, String taskId, UpdateCustomfieldValueRequest request, UpdateCustomfieldValueHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        taskId = com.aliyun.openapiutil.Client.getEncodeParam(taskId);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.customfieldId)) {
            body.put("customfieldId", request.customfieldId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.customfieldName)) {
            body.put("customfieldName", request.customfieldName);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdateCustomfieldValue", "project_1.0", "HTTP", "PUT", "AK", "/v1.0/project/users/" + userId + "/tasks/" + taskId + "/customFields", "json", req, runtime), new UpdateCustomfieldValueResponse());
    }

    public UpdateOrganizationTaskContentResponse updateOrganizationTaskContent(String taskId, String userId, UpdateOrganizationTaskContentRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateOrganizationTaskContentHeaders headers = new UpdateOrganizationTaskContentHeaders();
        return this.updateOrganizationTaskContentWithOptions(taskId, userId, request, headers, runtime);
    }

    public UpdateOrganizationTaskContentResponse updateOrganizationTaskContentWithOptions(String taskId, String userId, UpdateOrganizationTaskContentRequest request, UpdateOrganizationTaskContentHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        taskId = com.aliyun.openapiutil.Client.getEncodeParam(taskId);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdateOrganizationTaskContent", "project_1.0", "HTTP", "PUT", "AK", "/v1.0/project/organizations/users/" + userId + "/tasks/" + taskId + "/contents", "json", req, runtime), new UpdateOrganizationTaskContentResponse());
    }

    public UpdateOrganizationTaskDueDateResponse updateOrganizationTaskDueDate(String taskId, String userId, UpdateOrganizationTaskDueDateRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateOrganizationTaskDueDateHeaders headers = new UpdateOrganizationTaskDueDateHeaders();
        return this.updateOrganizationTaskDueDateWithOptions(taskId, userId, request, headers, runtime);
    }

    public UpdateOrganizationTaskDueDateResponse updateOrganizationTaskDueDateWithOptions(String taskId, String userId, UpdateOrganizationTaskDueDateRequest request, UpdateOrganizationTaskDueDateHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        taskId = com.aliyun.openapiutil.Client.getEncodeParam(taskId);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdateOrganizationTaskDueDate", "project_1.0", "HTTP", "PUT", "AK", "/v1.0/project/organizations/users/" + userId + "/tasks/" + taskId + "/dueDates", "json", req, runtime), new UpdateOrganizationTaskDueDateResponse());
    }

    public UpdateOrganizationTaskExecutorResponse updateOrganizationTaskExecutor(String taskId, String userId, UpdateOrganizationTaskExecutorRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateOrganizationTaskExecutorHeaders headers = new UpdateOrganizationTaskExecutorHeaders();
        return this.updateOrganizationTaskExecutorWithOptions(taskId, userId, request, headers, runtime);
    }

    public UpdateOrganizationTaskExecutorResponse updateOrganizationTaskExecutorWithOptions(String taskId, String userId, UpdateOrganizationTaskExecutorRequest request, UpdateOrganizationTaskExecutorHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        taskId = com.aliyun.openapiutil.Client.getEncodeParam(taskId);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdateOrganizationTaskExecutor", "project_1.0", "HTTP", "PUT", "AK", "/v1.0/project/organizations/users/" + userId + "/tasks/" + taskId + "/executors", "json", req, runtime), new UpdateOrganizationTaskExecutorResponse());
    }

    public UpdateOrganizationTaskInvolveMembersResponse updateOrganizationTaskInvolveMembers(String taskId, String userId, UpdateOrganizationTaskInvolveMembersRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateOrganizationTaskInvolveMembersHeaders headers = new UpdateOrganizationTaskInvolveMembersHeaders();
        return this.updateOrganizationTaskInvolveMembersWithOptions(taskId, userId, request, headers, runtime);
    }

    public UpdateOrganizationTaskInvolveMembersResponse updateOrganizationTaskInvolveMembersWithOptions(String taskId, String userId, UpdateOrganizationTaskInvolveMembersRequest request, UpdateOrganizationTaskInvolveMembersHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        taskId = com.aliyun.openapiutil.Client.getEncodeParam(taskId);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdateOrganizationTaskInvolveMembers", "project_1.0", "HTTP", "PUT", "AK", "/v1.0/project/organizations/users/" + userId + "/tasks/" + taskId + "/involveMembers", "json", req, runtime), new UpdateOrganizationTaskInvolveMembersResponse());
    }

    public UpdateOrganizationTaskNoteResponse updateOrganizationTaskNote(String taskId, String userId, UpdateOrganizationTaskNoteRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateOrganizationTaskNoteHeaders headers = new UpdateOrganizationTaskNoteHeaders();
        return this.updateOrganizationTaskNoteWithOptions(taskId, userId, request, headers, runtime);
    }

    public UpdateOrganizationTaskNoteResponse updateOrganizationTaskNoteWithOptions(String taskId, String userId, UpdateOrganizationTaskNoteRequest request, UpdateOrganizationTaskNoteHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        taskId = com.aliyun.openapiutil.Client.getEncodeParam(taskId);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdateOrganizationTaskNote", "project_1.0", "HTTP", "PUT", "AK", "/v1.0/project/organizations/users/" + userId + "/tasks/" + taskId + "/notes", "json", req, runtime), new UpdateOrganizationTaskNoteResponse());
    }

    public UpdateOrganizationTaskPriorityResponse updateOrganizationTaskPriority(String taskId, String userId, UpdateOrganizationTaskPriorityRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateOrganizationTaskPriorityHeaders headers = new UpdateOrganizationTaskPriorityHeaders();
        return this.updateOrganizationTaskPriorityWithOptions(taskId, userId, request, headers, runtime);
    }

    public UpdateOrganizationTaskPriorityResponse updateOrganizationTaskPriorityWithOptions(String taskId, String userId, UpdateOrganizationTaskPriorityRequest request, UpdateOrganizationTaskPriorityHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        taskId = com.aliyun.openapiutil.Client.getEncodeParam(taskId);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdateOrganizationTaskPriority", "project_1.0", "HTTP", "PUT", "AK", "/v1.0/project/organizations/users/" + userId + "/tasks/" + taskId + "/priorities", "json", req, runtime), new UpdateOrganizationTaskPriorityResponse());
    }

    public UpdateOrganizationTaskStatusResponse updateOrganizationTaskStatus(String taskId, String userId, UpdateOrganizationTaskStatusRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateOrganizationTaskStatusHeaders headers = new UpdateOrganizationTaskStatusHeaders();
        return this.updateOrganizationTaskStatusWithOptions(taskId, userId, request, headers, runtime);
    }

    public UpdateOrganizationTaskStatusResponse updateOrganizationTaskStatusWithOptions(String taskId, String userId, UpdateOrganizationTaskStatusRequest request, UpdateOrganizationTaskStatusHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        taskId = com.aliyun.openapiutil.Client.getEncodeParam(taskId);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdateOrganizationTaskStatus", "project_1.0", "HTTP", "PUT", "AK", "/v1.0/project/organizations/users/" + userId + "/tasks/" + taskId + "/states", "json", req, runtime), new UpdateOrganizationTaskStatusResponse());
    }

    public UpdateProjectGroupResponse updateProjectGroup(String userId, String projectId, UpdateProjectGroupRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateProjectGroupHeaders headers = new UpdateProjectGroupHeaders();
        return this.updateProjectGroupWithOptions(userId, projectId, request, headers, runtime);
    }

    public UpdateProjectGroupResponse updateProjectGroupWithOptions(String userId, String projectId, UpdateProjectGroupRequest request, UpdateProjectGroupHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        projectId = com.aliyun.openapiutil.Client.getEncodeParam(projectId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdateProjectGroup", "project_1.0", "HTTP", "PUT", "AK", "/v1.0/project/users/" + userId + "/projects/" + projectId + "/groups", "json", req, runtime), new UpdateProjectGroupResponse());
    }
}
