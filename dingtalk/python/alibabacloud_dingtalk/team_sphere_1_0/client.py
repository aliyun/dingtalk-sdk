# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.team_sphere_1_0 import models as dingtalkteam_sphere__1__0_models
from alibabacloud_tea_util import models as util_models
from alibabacloud_openapi_util.client import Client as OpenApiUtilClient


class Client(OpenApiClient):
    """
    *\
    """
    def __init__(
        self, 
        config: open_api_models.Config,
    ):
        super().__init__(config)
        gateway_client = GatewayClientClient()
        self._spi = gateway_client
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def analysis_report_with_options(
        self,
        user_id: str,
        request: dingtalkteam_sphere__1__0_models.AnalysisReportRequest,
        headers: dingtalkteam_sphere__1__0_models.AnalysisReportHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.AnalysisReportResponse:
        """
        @summary 查询任务概览
        
        @param request: AnalysisReportRequest
        @param headers: AnalysisReportHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AnalysisReportResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.filter):
            body['filter'] = request.filter
        if not UtilClient.is_unset(request.report_id):
            body['reportId'] = request.report_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AnalysisReport',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/users/{user_id}/analyses/report',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.AnalysisReportResponse(),
            self.execute(params, req, runtime)
        )

    async def analysis_report_with_options_async(
        self,
        user_id: str,
        request: dingtalkteam_sphere__1__0_models.AnalysisReportRequest,
        headers: dingtalkteam_sphere__1__0_models.AnalysisReportHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.AnalysisReportResponse:
        """
        @summary 查询任务概览
        
        @param request: AnalysisReportRequest
        @param headers: AnalysisReportHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AnalysisReportResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.filter):
            body['filter'] = request.filter
        if not UtilClient.is_unset(request.report_id):
            body['reportId'] = request.report_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AnalysisReport',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/users/{user_id}/analyses/report',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.AnalysisReportResponse(),
            await self.execute_async(params, req, runtime)
        )

    def analysis_report(
        self,
        user_id: str,
        request: dingtalkteam_sphere__1__0_models.AnalysisReportRequest,
    ) -> dingtalkteam_sphere__1__0_models.AnalysisReportResponse:
        """
        @summary 查询任务概览
        
        @param request: AnalysisReportRequest
        @return: AnalysisReportResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.AnalysisReportHeaders()
        return self.analysis_report_with_options(user_id, request, headers, runtime)

    async def analysis_report_async(
        self,
        user_id: str,
        request: dingtalkteam_sphere__1__0_models.AnalysisReportRequest,
    ) -> dingtalkteam_sphere__1__0_models.AnalysisReportResponse:
        """
        @summary 查询任务概览
        
        @param request: AnalysisReportRequest
        @return: AnalysisReportResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.AnalysisReportHeaders()
        return await self.analysis_report_with_options_async(user_id, request, headers, runtime)

    def create_organization_task_with_options(
        self,
        user_id: str,
        request: dingtalkteam_sphere__1__0_models.CreateOrganizationTaskRequest,
        headers: dingtalkteam_sphere__1__0_models.CreateOrganizationTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.CreateOrganizationTaskResponse:
        """
        @summary 创建自由任务
        
        @param request: CreateOrganizationTaskRequest
        @param headers: CreateOrganizationTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateOrganizationTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.disable_activity):
            body['disableActivity'] = request.disable_activity
        if not UtilClient.is_unset(request.disable_notification):
            body['disableNotification'] = request.disable_notification
        if not UtilClient.is_unset(request.due_date):
            body['dueDate'] = request.due_date
        if not UtilClient.is_unset(request.executor_id):
            body['executorId'] = request.executor_id
        if not UtilClient.is_unset(request.involve_members):
            body['involveMembers'] = request.involve_members
        if not UtilClient.is_unset(request.note):
            body['note'] = request.note
        if not UtilClient.is_unset(request.visible):
            body['visible'] = request.visible
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateOrganizationTask',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/organizations/users/{user_id}/tasks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.CreateOrganizationTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def create_organization_task_with_options_async(
        self,
        user_id: str,
        request: dingtalkteam_sphere__1__0_models.CreateOrganizationTaskRequest,
        headers: dingtalkteam_sphere__1__0_models.CreateOrganizationTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.CreateOrganizationTaskResponse:
        """
        @summary 创建自由任务
        
        @param request: CreateOrganizationTaskRequest
        @param headers: CreateOrganizationTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateOrganizationTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.disable_activity):
            body['disableActivity'] = request.disable_activity
        if not UtilClient.is_unset(request.disable_notification):
            body['disableNotification'] = request.disable_notification
        if not UtilClient.is_unset(request.due_date):
            body['dueDate'] = request.due_date
        if not UtilClient.is_unset(request.executor_id):
            body['executorId'] = request.executor_id
        if not UtilClient.is_unset(request.involve_members):
            body['involveMembers'] = request.involve_members
        if not UtilClient.is_unset(request.note):
            body['note'] = request.note
        if not UtilClient.is_unset(request.visible):
            body['visible'] = request.visible
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateOrganizationTask',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/organizations/users/{user_id}/tasks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.CreateOrganizationTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_organization_task(
        self,
        user_id: str,
        request: dingtalkteam_sphere__1__0_models.CreateOrganizationTaskRequest,
    ) -> dingtalkteam_sphere__1__0_models.CreateOrganizationTaskResponse:
        """
        @summary 创建自由任务
        
        @param request: CreateOrganizationTaskRequest
        @return: CreateOrganizationTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.CreateOrganizationTaskHeaders()
        return self.create_organization_task_with_options(user_id, request, headers, runtime)

    async def create_organization_task_async(
        self,
        user_id: str,
        request: dingtalkteam_sphere__1__0_models.CreateOrganizationTaskRequest,
    ) -> dingtalkteam_sphere__1__0_models.CreateOrganizationTaskResponse:
        """
        @summary 创建自由任务
        
        @param request: CreateOrganizationTaskRequest
        @return: CreateOrganizationTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.CreateOrganizationTaskHeaders()
        return await self.create_organization_task_with_options_async(user_id, request, headers, runtime)

    def create_project_members_v3with_options(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkteam_sphere__1__0_models.CreateProjectMembersV3Request,
        headers: dingtalkteam_sphere__1__0_models.CreateProjectMembersV3Headers,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.CreateProjectMembersV3Response:
        """
        @summary 创建项目成员
        
        @param request: CreateProjectMembersV3Request
        @param headers: CreateProjectMembersV3Headers
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateProjectMembersV3Response
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateProjectMembersV3',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/users/{user_id}/projects/{project_id}/members',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.CreateProjectMembersV3Response(),
            self.execute(params, req, runtime)
        )

    async def create_project_members_v3with_options_async(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkteam_sphere__1__0_models.CreateProjectMembersV3Request,
        headers: dingtalkteam_sphere__1__0_models.CreateProjectMembersV3Headers,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.CreateProjectMembersV3Response:
        """
        @summary 创建项目成员
        
        @param request: CreateProjectMembersV3Request
        @param headers: CreateProjectMembersV3Headers
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateProjectMembersV3Response
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateProjectMembersV3',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/users/{user_id}/projects/{project_id}/members',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.CreateProjectMembersV3Response(),
            await self.execute_async(params, req, runtime)
        )

    def create_project_members_v3(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkteam_sphere__1__0_models.CreateProjectMembersV3Request,
    ) -> dingtalkteam_sphere__1__0_models.CreateProjectMembersV3Response:
        """
        @summary 创建项目成员
        
        @param request: CreateProjectMembersV3Request
        @return: CreateProjectMembersV3Response
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.CreateProjectMembersV3Headers()
        return self.create_project_members_v3with_options(user_id, project_id, request, headers, runtime)

    async def create_project_members_v3_async(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkteam_sphere__1__0_models.CreateProjectMembersV3Request,
    ) -> dingtalkteam_sphere__1__0_models.CreateProjectMembersV3Response:
        """
        @summary 创建项目成员
        
        @param request: CreateProjectMembersV3Request
        @return: CreateProjectMembersV3Response
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.CreateProjectMembersV3Headers()
        return await self.create_project_members_v3with_options_async(user_id, project_id, request, headers, runtime)

    def create_project_v3with_options(
        self,
        user_id: str,
        request: dingtalkteam_sphere__1__0_models.CreateProjectV3Request,
        headers: dingtalkteam_sphere__1__0_models.CreateProjectV3Headers,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.CreateProjectV3Response:
        """
        @summary 创建协作空间。
        
        @param request: CreateProjectV3Request
        @param headers: CreateProjectV3Headers
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateProjectV3Response
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.organization_id):
            query['organizationId'] = request.organization_id
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateProjectV3',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/users/{user_id}/projects',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.CreateProjectV3Response(),
            self.execute(params, req, runtime)
        )

    async def create_project_v3with_options_async(
        self,
        user_id: str,
        request: dingtalkteam_sphere__1__0_models.CreateProjectV3Request,
        headers: dingtalkteam_sphere__1__0_models.CreateProjectV3Headers,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.CreateProjectV3Response:
        """
        @summary 创建协作空间。
        
        @param request: CreateProjectV3Request
        @param headers: CreateProjectV3Headers
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateProjectV3Response
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.organization_id):
            query['organizationId'] = request.organization_id
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateProjectV3',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/users/{user_id}/projects',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.CreateProjectV3Response(),
            await self.execute_async(params, req, runtime)
        )

    def create_project_v3(
        self,
        user_id: str,
        request: dingtalkteam_sphere__1__0_models.CreateProjectV3Request,
    ) -> dingtalkteam_sphere__1__0_models.CreateProjectV3Response:
        """
        @summary 创建协作空间。
        
        @param request: CreateProjectV3Request
        @return: CreateProjectV3Response
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.CreateProjectV3Headers()
        return self.create_project_v3with_options(user_id, request, headers, runtime)

    async def create_project_v3_async(
        self,
        user_id: str,
        request: dingtalkteam_sphere__1__0_models.CreateProjectV3Request,
    ) -> dingtalkteam_sphere__1__0_models.CreateProjectV3Response:
        """
        @summary 创建协作空间。
        
        @param request: CreateProjectV3Request
        @return: CreateProjectV3Response
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.CreateProjectV3Headers()
        return await self.create_project_v3with_options_async(user_id, request, headers, runtime)

    def create_task_with_options(
        self,
        user_id: str,
        request: dingtalkteam_sphere__1__0_models.CreateTaskRequest,
        headers: dingtalkteam_sphere__1__0_models.CreateTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.CreateTaskResponse:
        """
        @summary 创建协作空间任务
        
        @param request: CreateTaskRequest
        @param headers: CreateTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.customfields):
            body['customfields'] = request.customfields
        if not UtilClient.is_unset(request.disable_activity):
            body['disableActivity'] = request.disable_activity
        if not UtilClient.is_unset(request.disable_notification):
            body['disableNotification'] = request.disable_notification
        if not UtilClient.is_unset(request.due_date):
            body['dueDate'] = request.due_date
        if not UtilClient.is_unset(request.executor_id):
            body['executorId'] = request.executor_id
        if not UtilClient.is_unset(request.note):
            body['note'] = request.note
        if not UtilClient.is_unset(request.project_id):
            body['projectId'] = request.project_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateTask',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/users/{user_id}/tasks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.CreateTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def create_task_with_options_async(
        self,
        user_id: str,
        request: dingtalkteam_sphere__1__0_models.CreateTaskRequest,
        headers: dingtalkteam_sphere__1__0_models.CreateTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.CreateTaskResponse:
        """
        @summary 创建协作空间任务
        
        @param request: CreateTaskRequest
        @param headers: CreateTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.customfields):
            body['customfields'] = request.customfields
        if not UtilClient.is_unset(request.disable_activity):
            body['disableActivity'] = request.disable_activity
        if not UtilClient.is_unset(request.disable_notification):
            body['disableNotification'] = request.disable_notification
        if not UtilClient.is_unset(request.due_date):
            body['dueDate'] = request.due_date
        if not UtilClient.is_unset(request.executor_id):
            body['executorId'] = request.executor_id
        if not UtilClient.is_unset(request.note):
            body['note'] = request.note
        if not UtilClient.is_unset(request.project_id):
            body['projectId'] = request.project_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateTask',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/users/{user_id}/tasks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.CreateTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_task(
        self,
        user_id: str,
        request: dingtalkteam_sphere__1__0_models.CreateTaskRequest,
    ) -> dingtalkteam_sphere__1__0_models.CreateTaskResponse:
        """
        @summary 创建协作空间任务
        
        @param request: CreateTaskRequest
        @return: CreateTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.CreateTaskHeaders()
        return self.create_task_with_options(user_id, request, headers, runtime)

    async def create_task_async(
        self,
        user_id: str,
        request: dingtalkteam_sphere__1__0_models.CreateTaskRequest,
    ) -> dingtalkteam_sphere__1__0_models.CreateTaskResponse:
        """
        @summary 创建协作空间任务
        
        @param request: CreateTaskRequest
        @return: CreateTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.CreateTaskHeaders()
        return await self.create_task_with_options_async(user_id, request, headers, runtime)

    def delete_project_members_v3with_options(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkteam_sphere__1__0_models.DeleteProjectMembersV3Request,
        headers: dingtalkteam_sphere__1__0_models.DeleteProjectMembersV3Headers,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.DeleteProjectMembersV3Response:
        """
        @summary 删除项目成员。
        
        @param request: DeleteProjectMembersV3Request
        @param headers: DeleteProjectMembersV3Headers
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteProjectMembersV3Response
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='DeleteProjectMembersV3',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/users/{user_id}/projects/{project_id}/members/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.DeleteProjectMembersV3Response(),
            self.execute(params, req, runtime)
        )

    async def delete_project_members_v3with_options_async(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkteam_sphere__1__0_models.DeleteProjectMembersV3Request,
        headers: dingtalkteam_sphere__1__0_models.DeleteProjectMembersV3Headers,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.DeleteProjectMembersV3Response:
        """
        @summary 删除项目成员。
        
        @param request: DeleteProjectMembersV3Request
        @param headers: DeleteProjectMembersV3Headers
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteProjectMembersV3Response
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='DeleteProjectMembersV3',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/users/{user_id}/projects/{project_id}/members/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.DeleteProjectMembersV3Response(),
            await self.execute_async(params, req, runtime)
        )

    def delete_project_members_v3(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkteam_sphere__1__0_models.DeleteProjectMembersV3Request,
    ) -> dingtalkteam_sphere__1__0_models.DeleteProjectMembersV3Response:
        """
        @summary 删除项目成员。
        
        @param request: DeleteProjectMembersV3Request
        @return: DeleteProjectMembersV3Response
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.DeleteProjectMembersV3Headers()
        return self.delete_project_members_v3with_options(user_id, project_id, request, headers, runtime)

    async def delete_project_members_v3_async(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkteam_sphere__1__0_models.DeleteProjectMembersV3Request,
    ) -> dingtalkteam_sphere__1__0_models.DeleteProjectMembersV3Response:
        """
        @summary 删除项目成员。
        
        @param request: DeleteProjectMembersV3Request
        @return: DeleteProjectMembersV3Response
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.DeleteProjectMembersV3Headers()
        return await self.delete_project_members_v3with_options_async(user_id, project_id, request, headers, runtime)

    def get_footprint_project_with_options(
        self,
        user_id: str,
        headers: dingtalkteam_sphere__1__0_models.GetFootprintProjectHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.GetFootprintProjectResponse:
        """
        @summary 获取最近访问的项目
        
        @param headers: GetFootprintProjectHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetFootprintProjectResponse
        """
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetFootprintProject',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/users/{user_id}/footprints/projects',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.GetFootprintProjectResponse(),
            self.execute(params, req, runtime)
        )

    async def get_footprint_project_with_options_async(
        self,
        user_id: str,
        headers: dingtalkteam_sphere__1__0_models.GetFootprintProjectHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.GetFootprintProjectResponse:
        """
        @summary 获取最近访问的项目
        
        @param headers: GetFootprintProjectHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetFootprintProjectResponse
        """
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetFootprintProject',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/users/{user_id}/footprints/projects',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.GetFootprintProjectResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_footprint_project(
        self,
        user_id: str,
    ) -> dingtalkteam_sphere__1__0_models.GetFootprintProjectResponse:
        """
        @summary 获取最近访问的项目
        
        @return: GetFootprintProjectResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.GetFootprintProjectHeaders()
        return self.get_footprint_project_with_options(user_id, headers, runtime)

    async def get_footprint_project_async(
        self,
        user_id: str,
    ) -> dingtalkteam_sphere__1__0_models.GetFootprintProjectResponse:
        """
        @summary 获取最近访问的项目
        
        @return: GetFootprintProjectResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.GetFootprintProjectHeaders()
        return await self.get_footprint_project_with_options_async(user_id, headers, runtime)

    def get_footprint_task_with_options(
        self,
        user_id: str,
        headers: dingtalkteam_sphere__1__0_models.GetFootprintTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.GetFootprintTaskResponse:
        """
        @summary 获取最近访问的任务
        
        @param headers: GetFootprintTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetFootprintTaskResponse
        """
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetFootprintTask',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/users/{user_id}/footprints/tasks',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.GetFootprintTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def get_footprint_task_with_options_async(
        self,
        user_id: str,
        headers: dingtalkteam_sphere__1__0_models.GetFootprintTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.GetFootprintTaskResponse:
        """
        @summary 获取最近访问的任务
        
        @param headers: GetFootprintTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetFootprintTaskResponse
        """
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetFootprintTask',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/users/{user_id}/footprints/tasks',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.GetFootprintTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_footprint_task(
        self,
        user_id: str,
    ) -> dingtalkteam_sphere__1__0_models.GetFootprintTaskResponse:
        """
        @summary 获取最近访问的任务
        
        @return: GetFootprintTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.GetFootprintTaskHeaders()
        return self.get_footprint_task_with_options(user_id, headers, runtime)

    async def get_footprint_task_async(
        self,
        user_id: str,
    ) -> dingtalkteam_sphere__1__0_models.GetFootprintTaskResponse:
        """
        @summary 获取最近访问的任务
        
        @return: GetFootprintTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.GetFootprintTaskHeaders()
        return await self.get_footprint_task_with_options_async(user_id, headers, runtime)

    def get_free_task_with_options(
        self,
        task_id: str,
        request: dingtalkteam_sphere__1__0_models.GetFreeTaskRequest,
        headers: dingtalkteam_sphere__1__0_models.GetFreeTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.GetFreeTaskResponse:
        """
        @summary 查询轻任务详情。
        
        @param request: GetFreeTaskRequest
        @param headers: GetFreeTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetFreeTaskResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetFreeTask',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/organizations/tasks/{task_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.GetFreeTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def get_free_task_with_options_async(
        self,
        task_id: str,
        request: dingtalkteam_sphere__1__0_models.GetFreeTaskRequest,
        headers: dingtalkteam_sphere__1__0_models.GetFreeTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.GetFreeTaskResponse:
        """
        @summary 查询轻任务详情。
        
        @param request: GetFreeTaskRequest
        @param headers: GetFreeTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetFreeTaskResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetFreeTask',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/organizations/tasks/{task_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.GetFreeTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_free_task(
        self,
        task_id: str,
        request: dingtalkteam_sphere__1__0_models.GetFreeTaskRequest,
    ) -> dingtalkteam_sphere__1__0_models.GetFreeTaskResponse:
        """
        @summary 查询轻任务详情。
        
        @param request: GetFreeTaskRequest
        @return: GetFreeTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.GetFreeTaskHeaders()
        return self.get_free_task_with_options(task_id, request, headers, runtime)

    async def get_free_task_async(
        self,
        task_id: str,
        request: dingtalkteam_sphere__1__0_models.GetFreeTaskRequest,
    ) -> dingtalkteam_sphere__1__0_models.GetFreeTaskResponse:
        """
        @summary 查询轻任务详情。
        
        @param request: GetFreeTaskRequest
        @return: GetFreeTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.GetFreeTaskHeaders()
        return await self.get_free_task_with_options_async(task_id, request, headers, runtime)

    def get_project_members_v3with_options(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkteam_sphere__1__0_models.GetProjectMembersV3Request,
        headers: dingtalkteam_sphere__1__0_models.GetProjectMembersV3Headers,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.GetProjectMembersV3Response:
        """
        @summary 获取协作空间成员列表。
        
        @param request: GetProjectMembersV3Request
        @param headers: GetProjectMembersV3Headers
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetProjectMembersV3Response
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.project_role_id):
            query['projectRoleId'] = request.project_role_id
        if not UtilClient.is_unset(request.user_ids):
            query['userIds'] = request.user_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetProjectMembersV3',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/users/{user_id}/projects/{project_id}/members',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.GetProjectMembersV3Response(),
            self.execute(params, req, runtime)
        )

    async def get_project_members_v3with_options_async(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkteam_sphere__1__0_models.GetProjectMembersV3Request,
        headers: dingtalkteam_sphere__1__0_models.GetProjectMembersV3Headers,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.GetProjectMembersV3Response:
        """
        @summary 获取协作空间成员列表。
        
        @param request: GetProjectMembersV3Request
        @param headers: GetProjectMembersV3Headers
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetProjectMembersV3Response
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.project_role_id):
            query['projectRoleId'] = request.project_role_id
        if not UtilClient.is_unset(request.user_ids):
            query['userIds'] = request.user_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetProjectMembersV3',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/users/{user_id}/projects/{project_id}/members',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.GetProjectMembersV3Response(),
            await self.execute_async(params, req, runtime)
        )

    def get_project_members_v3(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkteam_sphere__1__0_models.GetProjectMembersV3Request,
    ) -> dingtalkteam_sphere__1__0_models.GetProjectMembersV3Response:
        """
        @summary 获取协作空间成员列表。
        
        @param request: GetProjectMembersV3Request
        @return: GetProjectMembersV3Response
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.GetProjectMembersV3Headers()
        return self.get_project_members_v3with_options(user_id, project_id, request, headers, runtime)

    async def get_project_members_v3_async(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkteam_sphere__1__0_models.GetProjectMembersV3Request,
    ) -> dingtalkteam_sphere__1__0_models.GetProjectMembersV3Response:
        """
        @summary 获取协作空间成员列表。
        
        @param request: GetProjectMembersV3Request
        @return: GetProjectMembersV3Response
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.GetProjectMembersV3Headers()
        return await self.get_project_members_v3with_options_async(user_id, project_id, request, headers, runtime)

    def get_project_roles_v3with_options(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkteam_sphere__1__0_models.GetProjectRolesV3Request,
        headers: dingtalkteam_sphere__1__0_models.GetProjectRolesV3Headers,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.GetProjectRolesV3Response:
        """
        @summary 获取项目角色列表。
        
        @param request: GetProjectRolesV3Request
        @param headers: GetProjectRolesV3Headers
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetProjectRolesV3Response
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.include_hidden):
            query['includeHidden'] = request.include_hidden
        if not UtilClient.is_unset(request.level):
            query['level'] = request.level
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetProjectRolesV3',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/users/{user_id}/projects/{project_id}/roles',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.GetProjectRolesV3Response(),
            self.execute(params, req, runtime)
        )

    async def get_project_roles_v3with_options_async(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkteam_sphere__1__0_models.GetProjectRolesV3Request,
        headers: dingtalkteam_sphere__1__0_models.GetProjectRolesV3Headers,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.GetProjectRolesV3Response:
        """
        @summary 获取项目角色列表。
        
        @param request: GetProjectRolesV3Request
        @param headers: GetProjectRolesV3Headers
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetProjectRolesV3Response
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.include_hidden):
            query['includeHidden'] = request.include_hidden
        if not UtilClient.is_unset(request.level):
            query['level'] = request.level
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetProjectRolesV3',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/users/{user_id}/projects/{project_id}/roles',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.GetProjectRolesV3Response(),
            await self.execute_async(params, req, runtime)
        )

    def get_project_roles_v3(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkteam_sphere__1__0_models.GetProjectRolesV3Request,
    ) -> dingtalkteam_sphere__1__0_models.GetProjectRolesV3Response:
        """
        @summary 获取项目角色列表。
        
        @param request: GetProjectRolesV3Request
        @return: GetProjectRolesV3Response
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.GetProjectRolesV3Headers()
        return self.get_project_roles_v3with_options(user_id, project_id, request, headers, runtime)

    async def get_project_roles_v3_async(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkteam_sphere__1__0_models.GetProjectRolesV3Request,
    ) -> dingtalkteam_sphere__1__0_models.GetProjectRolesV3Response:
        """
        @summary 获取项目角色列表。
        
        @param request: GetProjectRolesV3Request
        @return: GetProjectRolesV3Response
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.GetProjectRolesV3Headers()
        return await self.get_project_roles_v3with_options_async(user_id, project_id, request, headers, runtime)

    def get_stared_projects_with_options(
        self,
        user_id: str,
        request: dingtalkteam_sphere__1__0_models.GetStaredProjectsRequest,
        headers: dingtalkteam_sphere__1__0_models.GetStaredProjectsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.GetStaredProjectsResponse:
        """
        @summary 获取用户星标协作空间
        
        @param request: GetStaredProjectsRequest
        @param headers: GetStaredProjectsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetStaredProjectsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.sort_by):
            query['sortBy'] = request.sort_by
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetStaredProjects',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/users/{user_id}/staredProjects',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.GetStaredProjectsResponse(),
            self.execute(params, req, runtime)
        )

    async def get_stared_projects_with_options_async(
        self,
        user_id: str,
        request: dingtalkteam_sphere__1__0_models.GetStaredProjectsRequest,
        headers: dingtalkteam_sphere__1__0_models.GetStaredProjectsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.GetStaredProjectsResponse:
        """
        @summary 获取用户星标协作空间
        
        @param request: GetStaredProjectsRequest
        @param headers: GetStaredProjectsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetStaredProjectsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.sort_by):
            query['sortBy'] = request.sort_by
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetStaredProjects',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/users/{user_id}/staredProjects',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.GetStaredProjectsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_stared_projects(
        self,
        user_id: str,
        request: dingtalkteam_sphere__1__0_models.GetStaredProjectsRequest,
    ) -> dingtalkteam_sphere__1__0_models.GetStaredProjectsResponse:
        """
        @summary 获取用户星标协作空间
        
        @param request: GetStaredProjectsRequest
        @return: GetStaredProjectsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.GetStaredProjectsHeaders()
        return self.get_stared_projects_with_options(user_id, request, headers, runtime)

    async def get_stared_projects_async(
        self,
        user_id: str,
        request: dingtalkteam_sphere__1__0_models.GetStaredProjectsRequest,
    ) -> dingtalkteam_sphere__1__0_models.GetStaredProjectsResponse:
        """
        @summary 获取用户星标协作空间
        
        @param request: GetStaredProjectsRequest
        @return: GetStaredProjectsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.GetStaredProjectsHeaders()
        return await self.get_stared_projects_with_options_async(user_id, request, headers, runtime)

    def get_tb_user_id_by_ding_user_id_with_options(
        self,
        request: dingtalkteam_sphere__1__0_models.GetTbUserIdByDingUserIdRequest,
        headers: dingtalkteam_sphere__1__0_models.GetTbUserIdByDingUserIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.GetTbUserIdByDingUserIdResponse:
        """
        @summary 钉钉 userId 查询 24位长 userId。
        
        @param request: GetTbUserIdByDingUserIdRequest
        @param headers: GetTbUserIdByDingUserIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTbUserIdByDingUserIdResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ding_user_ids):
            query['dingUserIds'] = request.ding_user_ids
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetTbUserIdByDingUserId',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/idmaps/userIds',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.GetTbUserIdByDingUserIdResponse(),
            self.execute(params, req, runtime)
        )

    async def get_tb_user_id_by_ding_user_id_with_options_async(
        self,
        request: dingtalkteam_sphere__1__0_models.GetTbUserIdByDingUserIdRequest,
        headers: dingtalkteam_sphere__1__0_models.GetTbUserIdByDingUserIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.GetTbUserIdByDingUserIdResponse:
        """
        @summary 钉钉 userId 查询 24位长 userId。
        
        @param request: GetTbUserIdByDingUserIdRequest
        @param headers: GetTbUserIdByDingUserIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTbUserIdByDingUserIdResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ding_user_ids):
            query['dingUserIds'] = request.ding_user_ids
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetTbUserIdByDingUserId',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/idmaps/userIds',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.GetTbUserIdByDingUserIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_tb_user_id_by_ding_user_id(
        self,
        request: dingtalkteam_sphere__1__0_models.GetTbUserIdByDingUserIdRequest,
    ) -> dingtalkteam_sphere__1__0_models.GetTbUserIdByDingUserIdResponse:
        """
        @summary 钉钉 userId 查询 24位长 userId。
        
        @param request: GetTbUserIdByDingUserIdRequest
        @return: GetTbUserIdByDingUserIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.GetTbUserIdByDingUserIdHeaders()
        return self.get_tb_user_id_by_ding_user_id_with_options(request, headers, runtime)

    async def get_tb_user_id_by_ding_user_id_async(
        self,
        request: dingtalkteam_sphere__1__0_models.GetTbUserIdByDingUserIdRequest,
    ) -> dingtalkteam_sphere__1__0_models.GetTbUserIdByDingUserIdResponse:
        """
        @summary 钉钉 userId 查询 24位长 userId。
        
        @param request: GetTbUserIdByDingUserIdRequest
        @return: GetTbUserIdByDingUserIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.GetTbUserIdByDingUserIdHeaders()
        return await self.get_tb_user_id_by_ding_user_id_with_options_async(request, headers, runtime)

    def get_thing_org_id_by_ding_org_id_with_options(
        self,
        headers: dingtalkteam_sphere__1__0_models.GetThingOrgIdByDingOrgIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.GetThingOrgIdByDingOrgIdResponse:
        """
        @summary 获取快办企业ID
        
        @param headers: GetThingOrgIdByDingOrgIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetThingOrgIdByDingOrgIdResponse
        """
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetThingOrgIdByDingOrgId',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/organizations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.GetThingOrgIdByDingOrgIdResponse(),
            self.execute(params, req, runtime)
        )

    async def get_thing_org_id_by_ding_org_id_with_options_async(
        self,
        headers: dingtalkteam_sphere__1__0_models.GetThingOrgIdByDingOrgIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.GetThingOrgIdByDingOrgIdResponse:
        """
        @summary 获取快办企业ID
        
        @param headers: GetThingOrgIdByDingOrgIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetThingOrgIdByDingOrgIdResponse
        """
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetThingOrgIdByDingOrgId',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/organizations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.GetThingOrgIdByDingOrgIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_thing_org_id_by_ding_org_id(self) -> dingtalkteam_sphere__1__0_models.GetThingOrgIdByDingOrgIdResponse:
        """
        @summary 获取快办企业ID
        
        @return: GetThingOrgIdByDingOrgIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.GetThingOrgIdByDingOrgIdHeaders()
        return self.get_thing_org_id_by_ding_org_id_with_options(headers, runtime)

    async def get_thing_org_id_by_ding_org_id_async(self) -> dingtalkteam_sphere__1__0_models.GetThingOrgIdByDingOrgIdResponse:
        """
        @summary 获取快办企业ID
        
        @return: GetThingOrgIdByDingOrgIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.GetThingOrgIdByDingOrgIdHeaders()
        return await self.get_thing_org_id_by_ding_org_id_with_options_async(headers, runtime)

    def get_user_joined_projects_v3with_options(
        self,
        user_id: str,
        request: dingtalkteam_sphere__1__0_models.GetUserJoinedProjectsV3Request,
        headers: dingtalkteam_sphere__1__0_models.GetUserJoinedProjectsV3Headers,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.GetUserJoinedProjectsV3Response:
        """
        @summary 获取用户参与项目。
        
        @param request: GetUserJoinedProjectsV3Request
        @param headers: GetUserJoinedProjectsV3Headers
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserJoinedProjectsV3Response
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.project_ids):
            query['projectIds'] = request.project_ids
        if not UtilClient.is_unset(request.project_role_levels):
            query['projectRoleLevels'] = request.project_role_levels
        if not UtilClient.is_unset(request.sort_by):
            query['sortBy'] = request.sort_by
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetUserJoinedProjectsV3',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/users/{user_id}/projects/userJoined',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.GetUserJoinedProjectsV3Response(),
            self.execute(params, req, runtime)
        )

    async def get_user_joined_projects_v3with_options_async(
        self,
        user_id: str,
        request: dingtalkteam_sphere__1__0_models.GetUserJoinedProjectsV3Request,
        headers: dingtalkteam_sphere__1__0_models.GetUserJoinedProjectsV3Headers,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.GetUserJoinedProjectsV3Response:
        """
        @summary 获取用户参与项目。
        
        @param request: GetUserJoinedProjectsV3Request
        @param headers: GetUserJoinedProjectsV3Headers
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserJoinedProjectsV3Response
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.project_ids):
            query['projectIds'] = request.project_ids
        if not UtilClient.is_unset(request.project_role_levels):
            query['projectRoleLevels'] = request.project_role_levels
        if not UtilClient.is_unset(request.sort_by):
            query['sortBy'] = request.sort_by
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetUserJoinedProjectsV3',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/users/{user_id}/projects/userJoined',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.GetUserJoinedProjectsV3Response(),
            await self.execute_async(params, req, runtime)
        )

    def get_user_joined_projects_v3(
        self,
        user_id: str,
        request: dingtalkteam_sphere__1__0_models.GetUserJoinedProjectsV3Request,
    ) -> dingtalkteam_sphere__1__0_models.GetUserJoinedProjectsV3Response:
        """
        @summary 获取用户参与项目。
        
        @param request: GetUserJoinedProjectsV3Request
        @return: GetUserJoinedProjectsV3Response
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.GetUserJoinedProjectsV3Headers()
        return self.get_user_joined_projects_v3with_options(user_id, request, headers, runtime)

    async def get_user_joined_projects_v3_async(
        self,
        user_id: str,
        request: dingtalkteam_sphere__1__0_models.GetUserJoinedProjectsV3Request,
    ) -> dingtalkteam_sphere__1__0_models.GetUserJoinedProjectsV3Response:
        """
        @summary 获取用户参与项目。
        
        @param request: GetUserJoinedProjectsV3Request
        @return: GetUserJoinedProjectsV3Response
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.GetUserJoinedProjectsV3Headers()
        return await self.get_user_joined_projects_v3with_options_async(user_id, request, headers, runtime)

    def list_all_task_view_with_options(
        self,
        user_id: str,
        headers: dingtalkteam_sphere__1__0_models.ListAllTaskViewHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.ListAllTaskViewResponse:
        """
        @summary 获取全部任务
        
        @param headers: ListAllTaskViewHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListAllTaskViewResponse
        """
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='ListAllTaskView',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/users/{user_id}/allTaskViews',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.ListAllTaskViewResponse(),
            self.execute(params, req, runtime)
        )

    async def list_all_task_view_with_options_async(
        self,
        user_id: str,
        headers: dingtalkteam_sphere__1__0_models.ListAllTaskViewHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.ListAllTaskViewResponse:
        """
        @summary 获取全部任务
        
        @param headers: ListAllTaskViewHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListAllTaskViewResponse
        """
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='ListAllTaskView',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/users/{user_id}/allTaskViews',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.ListAllTaskViewResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_all_task_view(
        self,
        user_id: str,
    ) -> dingtalkteam_sphere__1__0_models.ListAllTaskViewResponse:
        """
        @summary 获取全部任务
        
        @return: ListAllTaskViewResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.ListAllTaskViewHeaders()
        return self.list_all_task_view_with_options(user_id, headers, runtime)

    async def list_all_task_view_async(
        self,
        user_id: str,
    ) -> dingtalkteam_sphere__1__0_models.ListAllTaskViewResponse:
        """
        @summary 获取全部任务
        
        @return: ListAllTaskViewResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.ListAllTaskViewHeaders()
        return await self.list_all_task_view_with_options_async(user_id, headers, runtime)

    def list_my_shortcut_views_with_options(
        self,
        user_id: str,
        request: dingtalkteam_sphere__1__0_models.ListMyShortcutViewsRequest,
        headers: dingtalkteam_sphere__1__0_models.ListMyShortcutViewsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.ListMyShortcutViewsResponse:
        """
        @summary 查询我的捷径
        
        @param request: ListMyShortcutViewsRequest
        @param headers: ListMyShortcutViewsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListMyShortcutViewsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='ListMyShortcutViews',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/users/{user_id}/shortcutViews',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.ListMyShortcutViewsResponse(),
            self.execute(params, req, runtime)
        )

    async def list_my_shortcut_views_with_options_async(
        self,
        user_id: str,
        request: dingtalkteam_sphere__1__0_models.ListMyShortcutViewsRequest,
        headers: dingtalkteam_sphere__1__0_models.ListMyShortcutViewsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.ListMyShortcutViewsResponse:
        """
        @summary 查询我的捷径
        
        @param request: ListMyShortcutViewsRequest
        @param headers: ListMyShortcutViewsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListMyShortcutViewsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='ListMyShortcutViews',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/users/{user_id}/shortcutViews',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.ListMyShortcutViewsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_my_shortcut_views(
        self,
        user_id: str,
        request: dingtalkteam_sphere__1__0_models.ListMyShortcutViewsRequest,
    ) -> dingtalkteam_sphere__1__0_models.ListMyShortcutViewsResponse:
        """
        @summary 查询我的捷径
        
        @param request: ListMyShortcutViewsRequest
        @return: ListMyShortcutViewsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.ListMyShortcutViewsHeaders()
        return self.list_my_shortcut_views_with_options(user_id, request, headers, runtime)

    async def list_my_shortcut_views_async(
        self,
        user_id: str,
        request: dingtalkteam_sphere__1__0_models.ListMyShortcutViewsRequest,
    ) -> dingtalkteam_sphere__1__0_models.ListMyShortcutViewsResponse:
        """
        @summary 查询我的捷径
        
        @param request: ListMyShortcutViewsRequest
        @return: ListMyShortcutViewsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.ListMyShortcutViewsHeaders()
        return await self.list_my_shortcut_views_with_options_async(user_id, request, headers, runtime)

    def query_all_task_with_options(
        self,
        user_id: str,
        request: dingtalkteam_sphere__1__0_models.QueryAllTaskRequest,
        headers: dingtalkteam_sphere__1__0_models.QueryAllTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.QueryAllTaskResponse:
        """
        @summary 查询自由任务和项目任务详情。
        
        @param request: QueryAllTaskRequest
        @param headers: QueryAllTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryAllTaskResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.task_id):
            query['taskId'] = request.task_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryAllTask',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/users/{user_id}/tasks/query',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.QueryAllTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def query_all_task_with_options_async(
        self,
        user_id: str,
        request: dingtalkteam_sphere__1__0_models.QueryAllTaskRequest,
        headers: dingtalkteam_sphere__1__0_models.QueryAllTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.QueryAllTaskResponse:
        """
        @summary 查询自由任务和项目任务详情。
        
        @param request: QueryAllTaskRequest
        @param headers: QueryAllTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryAllTaskResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.task_id):
            query['taskId'] = request.task_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryAllTask',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/users/{user_id}/tasks/query',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.QueryAllTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_all_task(
        self,
        user_id: str,
        request: dingtalkteam_sphere__1__0_models.QueryAllTaskRequest,
    ) -> dingtalkteam_sphere__1__0_models.QueryAllTaskResponse:
        """
        @summary 查询自由任务和项目任务详情。
        
        @param request: QueryAllTaskRequest
        @return: QueryAllTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.QueryAllTaskHeaders()
        return self.query_all_task_with_options(user_id, request, headers, runtime)

    async def query_all_task_async(
        self,
        user_id: str,
        request: dingtalkteam_sphere__1__0_models.QueryAllTaskRequest,
    ) -> dingtalkteam_sphere__1__0_models.QueryAllTaskResponse:
        """
        @summary 查询自由任务和项目任务详情。
        
        @param request: QueryAllTaskRequest
        @return: QueryAllTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.QueryAllTaskHeaders()
        return await self.query_all_task_with_options_async(user_id, request, headers, runtime)

    def query_task_with_options(
        self,
        user_id: str,
        request: dingtalkteam_sphere__1__0_models.QueryTaskRequest,
        headers: dingtalkteam_sphere__1__0_models.QueryTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.QueryTaskResponse:
        """
        @summary 查询我的任务
        
        @param request: QueryTaskRequest
        @param headers: QueryTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.tql):
            body['tql'] = request.tql
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='QueryTask',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/users/{user_id}/tasks/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.QueryTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def query_task_with_options_async(
        self,
        user_id: str,
        request: dingtalkteam_sphere__1__0_models.QueryTaskRequest,
        headers: dingtalkteam_sphere__1__0_models.QueryTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.QueryTaskResponse:
        """
        @summary 查询我的任务
        
        @param request: QueryTaskRequest
        @param headers: QueryTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.tql):
            body['tql'] = request.tql
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='QueryTask',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/users/{user_id}/tasks/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.QueryTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_task(
        self,
        user_id: str,
        request: dingtalkteam_sphere__1__0_models.QueryTaskRequest,
    ) -> dingtalkteam_sphere__1__0_models.QueryTaskResponse:
        """
        @summary 查询我的任务
        
        @param request: QueryTaskRequest
        @return: QueryTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.QueryTaskHeaders()
        return self.query_task_with_options(user_id, request, headers, runtime)

    async def query_task_async(
        self,
        user_id: str,
        request: dingtalkteam_sphere__1__0_models.QueryTaskRequest,
    ) -> dingtalkteam_sphere__1__0_models.QueryTaskResponse:
        """
        @summary 查询我的任务
        
        @param request: QueryTaskRequest
        @return: QueryTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.QueryTaskHeaders()
        return await self.query_task_with_options_async(user_id, request, headers, runtime)

    def query_tasks_v3with_options(
        self,
        user_id: str,
        request: dingtalkteam_sphere__1__0_models.QueryTasksV3Request,
        headers: dingtalkteam_sphere__1__0_models.QueryTasksV3Headers,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.QueryTasksV3Response:
        """
        @summary 查询协作空间任务详情。
        
        @param request: QueryTasksV3Request
        @param headers: QueryTasksV3Headers
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryTasksV3Response
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.task_id):
            query['taskId'] = request.task_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryTasksV3',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/user/{user_id}/tasks',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.QueryTasksV3Response(),
            self.execute(params, req, runtime)
        )

    async def query_tasks_v3with_options_async(
        self,
        user_id: str,
        request: dingtalkteam_sphere__1__0_models.QueryTasksV3Request,
        headers: dingtalkteam_sphere__1__0_models.QueryTasksV3Headers,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.QueryTasksV3Response:
        """
        @summary 查询协作空间任务详情。
        
        @param request: QueryTasksV3Request
        @param headers: QueryTasksV3Headers
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryTasksV3Response
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.task_id):
            query['taskId'] = request.task_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryTasksV3',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/user/{user_id}/tasks',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.QueryTasksV3Response(),
            await self.execute_async(params, req, runtime)
        )

    def query_tasks_v3(
        self,
        user_id: str,
        request: dingtalkteam_sphere__1__0_models.QueryTasksV3Request,
    ) -> dingtalkteam_sphere__1__0_models.QueryTasksV3Response:
        """
        @summary 查询协作空间任务详情。
        
        @param request: QueryTasksV3Request
        @return: QueryTasksV3Response
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.QueryTasksV3Headers()
        return self.query_tasks_v3with_options(user_id, request, headers, runtime)

    async def query_tasks_v3_async(
        self,
        user_id: str,
        request: dingtalkteam_sphere__1__0_models.QueryTasksV3Request,
    ) -> dingtalkteam_sphere__1__0_models.QueryTasksV3Response:
        """
        @summary 查询协作空间任务详情。
        
        @param request: QueryTasksV3Request
        @return: QueryTasksV3Response
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.QueryTasksV3Headers()
        return await self.query_tasks_v3with_options_async(user_id, request, headers, runtime)

    def search_all_tasks_by_tql_with_options(
        self,
        request: dingtalkteam_sphere__1__0_models.SearchAllTasksByTqlRequest,
        headers: dingtalkteam_sphere__1__0_models.SearchAllTasksByTqlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.SearchAllTasksByTqlResponse:
        """
        @summary 通过TQL搜索自由任务和协作空间任务ID。
        
        @param request: SearchAllTasksByTqlRequest
        @param headers: SearchAllTasksByTqlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchAllTasksByTqlResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.tql):
            query['tql'] = request.tql
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SearchAllTasksByTql',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/taskIds',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.SearchAllTasksByTqlResponse(),
            self.execute(params, req, runtime)
        )

    async def search_all_tasks_by_tql_with_options_async(
        self,
        request: dingtalkteam_sphere__1__0_models.SearchAllTasksByTqlRequest,
        headers: dingtalkteam_sphere__1__0_models.SearchAllTasksByTqlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.SearchAllTasksByTqlResponse:
        """
        @summary 通过TQL搜索自由任务和协作空间任务ID。
        
        @param request: SearchAllTasksByTqlRequest
        @param headers: SearchAllTasksByTqlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchAllTasksByTqlResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.tql):
            query['tql'] = request.tql
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SearchAllTasksByTql',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/taskIds',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.SearchAllTasksByTqlResponse(),
            await self.execute_async(params, req, runtime)
        )

    def search_all_tasks_by_tql(
        self,
        request: dingtalkteam_sphere__1__0_models.SearchAllTasksByTqlRequest,
    ) -> dingtalkteam_sphere__1__0_models.SearchAllTasksByTqlResponse:
        """
        @summary 通过TQL搜索自由任务和协作空间任务ID。
        
        @param request: SearchAllTasksByTqlRequest
        @return: SearchAllTasksByTqlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.SearchAllTasksByTqlHeaders()
        return self.search_all_tasks_by_tql_with_options(request, headers, runtime)

    async def search_all_tasks_by_tql_async(
        self,
        request: dingtalkteam_sphere__1__0_models.SearchAllTasksByTqlRequest,
    ) -> dingtalkteam_sphere__1__0_models.SearchAllTasksByTqlResponse:
        """
        @summary 通过TQL搜索自由任务和协作空间任务ID。
        
        @param request: SearchAllTasksByTqlRequest
        @return: SearchAllTasksByTqlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.SearchAllTasksByTqlHeaders()
        return await self.search_all_tasks_by_tql_with_options_async(request, headers, runtime)

    def search_project_custom_fileds_v3with_options(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkteam_sphere__1__0_models.SearchProjectCustomFiledsV3Request,
        headers: dingtalkteam_sphere__1__0_models.SearchProjectCustomFiledsV3Headers,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.SearchProjectCustomFiledsV3Response:
        """
        @summary 搜索项目自定义字段。
        
        @param request: SearchProjectCustomFiledsV3Request
        @param headers: SearchProjectCustomFiledsV3Headers
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchProjectCustomFiledsV3Response
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.cf_ids):
            query['cfIds'] = request.cf_ids
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.sfc_id):
            query['sfcId'] = request.sfc_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SearchProjectCustomFiledsV3',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/users/{user_id}/projects/{project_id}/customFields',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.SearchProjectCustomFiledsV3Response(),
            self.execute(params, req, runtime)
        )

    async def search_project_custom_fileds_v3with_options_async(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkteam_sphere__1__0_models.SearchProjectCustomFiledsV3Request,
        headers: dingtalkteam_sphere__1__0_models.SearchProjectCustomFiledsV3Headers,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.SearchProjectCustomFiledsV3Response:
        """
        @summary 搜索项目自定义字段。
        
        @param request: SearchProjectCustomFiledsV3Request
        @param headers: SearchProjectCustomFiledsV3Headers
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchProjectCustomFiledsV3Response
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.cf_ids):
            query['cfIds'] = request.cf_ids
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.sfc_id):
            query['sfcId'] = request.sfc_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SearchProjectCustomFiledsV3',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/users/{user_id}/projects/{project_id}/customFields',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.SearchProjectCustomFiledsV3Response(),
            await self.execute_async(params, req, runtime)
        )

    def search_project_custom_fileds_v3(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkteam_sphere__1__0_models.SearchProjectCustomFiledsV3Request,
    ) -> dingtalkteam_sphere__1__0_models.SearchProjectCustomFiledsV3Response:
        """
        @summary 搜索项目自定义字段。
        
        @param request: SearchProjectCustomFiledsV3Request
        @return: SearchProjectCustomFiledsV3Response
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.SearchProjectCustomFiledsV3Headers()
        return self.search_project_custom_fileds_v3with_options(user_id, project_id, request, headers, runtime)

    async def search_project_custom_fileds_v3_async(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkteam_sphere__1__0_models.SearchProjectCustomFiledsV3Request,
    ) -> dingtalkteam_sphere__1__0_models.SearchProjectCustomFiledsV3Response:
        """
        @summary 搜索项目自定义字段。
        
        @param request: SearchProjectCustomFiledsV3Request
        @return: SearchProjectCustomFiledsV3Response
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.SearchProjectCustomFiledsV3Headers()
        return await self.search_project_custom_fileds_v3with_options_async(user_id, project_id, request, headers, runtime)

    def search_projects_v3with_options(
        self,
        request: dingtalkteam_sphere__1__0_models.SearchProjectsV3Request,
        headers: dingtalkteam_sphere__1__0_models.SearchProjectsV3Headers,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.SearchProjectsV3Response:
        """
        @summary 查询协作空间。
        
        @param request: SearchProjectsV3Request
        @param headers: SearchProjectsV3Headers
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchProjectsV3Response
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.include_template):
            query['includeTemplate'] = request.include_template
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.name):
            query['name'] = request.name
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.project_ids):
            query['projectIds'] = request.project_ids
        if not UtilClient.is_unset(request.source_id):
            query['sourceId'] = request.source_id
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SearchProjectsV3',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/projects',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.SearchProjectsV3Response(),
            self.execute(params, req, runtime)
        )

    async def search_projects_v3with_options_async(
        self,
        request: dingtalkteam_sphere__1__0_models.SearchProjectsV3Request,
        headers: dingtalkteam_sphere__1__0_models.SearchProjectsV3Headers,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.SearchProjectsV3Response:
        """
        @summary 查询协作空间。
        
        @param request: SearchProjectsV3Request
        @param headers: SearchProjectsV3Headers
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchProjectsV3Response
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.include_template):
            query['includeTemplate'] = request.include_template
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.name):
            query['name'] = request.name
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.project_ids):
            query['projectIds'] = request.project_ids
        if not UtilClient.is_unset(request.source_id):
            query['sourceId'] = request.source_id
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SearchProjectsV3',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/projects',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.SearchProjectsV3Response(),
            await self.execute_async(params, req, runtime)
        )

    def search_projects_v3(
        self,
        request: dingtalkteam_sphere__1__0_models.SearchProjectsV3Request,
    ) -> dingtalkteam_sphere__1__0_models.SearchProjectsV3Response:
        """
        @summary 查询协作空间。
        
        @param request: SearchProjectsV3Request
        @return: SearchProjectsV3Response
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.SearchProjectsV3Headers()
        return self.search_projects_v3with_options(request, headers, runtime)

    async def search_projects_v3_async(
        self,
        request: dingtalkteam_sphere__1__0_models.SearchProjectsV3Request,
    ) -> dingtalkteam_sphere__1__0_models.SearchProjectsV3Response:
        """
        @summary 查询协作空间。
        
        @param request: SearchProjectsV3Request
        @return: SearchProjectsV3Response
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.SearchProjectsV3Headers()
        return await self.search_projects_v3with_options_async(request, headers, runtime)

    def update_project_member_role_v3with_options(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkteam_sphere__1__0_models.UpdateProjectMemberRoleV3Request,
        headers: dingtalkteam_sphere__1__0_models.UpdateProjectMemberRoleV3Headers,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.UpdateProjectMemberRoleV3Response:
        """
        @summary 修改项目成员的角色。
        
        @param request: UpdateProjectMemberRoleV3Request
        @param headers: UpdateProjectMemberRoleV3Headers
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateProjectMemberRoleV3Response
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.role_ids):
            body['roleIds'] = request.role_ids
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateProjectMemberRoleV3',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/users/{user_id}/projects/{project_id}/roles/assign',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.UpdateProjectMemberRoleV3Response(),
            self.execute(params, req, runtime)
        )

    async def update_project_member_role_v3with_options_async(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkteam_sphere__1__0_models.UpdateProjectMemberRoleV3Request,
        headers: dingtalkteam_sphere__1__0_models.UpdateProjectMemberRoleV3Headers,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.UpdateProjectMemberRoleV3Response:
        """
        @summary 修改项目成员的角色。
        
        @param request: UpdateProjectMemberRoleV3Request
        @param headers: UpdateProjectMemberRoleV3Headers
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateProjectMemberRoleV3Response
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.role_ids):
            body['roleIds'] = request.role_ids
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateProjectMemberRoleV3',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/users/{user_id}/projects/{project_id}/roles/assign',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.UpdateProjectMemberRoleV3Response(),
            await self.execute_async(params, req, runtime)
        )

    def update_project_member_role_v3(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkteam_sphere__1__0_models.UpdateProjectMemberRoleV3Request,
    ) -> dingtalkteam_sphere__1__0_models.UpdateProjectMemberRoleV3Response:
        """
        @summary 修改项目成员的角色。
        
        @param request: UpdateProjectMemberRoleV3Request
        @return: UpdateProjectMemberRoleV3Response
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.UpdateProjectMemberRoleV3Headers()
        return self.update_project_member_role_v3with_options(user_id, project_id, request, headers, runtime)

    async def update_project_member_role_v3_async(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkteam_sphere__1__0_models.UpdateProjectMemberRoleV3Request,
    ) -> dingtalkteam_sphere__1__0_models.UpdateProjectMemberRoleV3Response:
        """
        @summary 修改项目成员的角色。
        
        @param request: UpdateProjectMemberRoleV3Request
        @return: UpdateProjectMemberRoleV3Response
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.UpdateProjectMemberRoleV3Headers()
        return await self.update_project_member_role_v3with_options_async(user_id, project_id, request, headers, runtime)

    def update_project_v3with_options(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkteam_sphere__1__0_models.UpdateProjectV3Request,
        headers: dingtalkteam_sphere__1__0_models.UpdateProjectV3Headers,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.UpdateProjectV3Response:
        """
        @summary 更新协作空间。
        
        @param request: UpdateProjectV3Request
        @param headers: UpdateProjectV3Headers
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateProjectV3Response
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateProjectV3',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/users/{user_id}/projects/{project_id}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.UpdateProjectV3Response(),
            self.execute(params, req, runtime)
        )

    async def update_project_v3with_options_async(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkteam_sphere__1__0_models.UpdateProjectV3Request,
        headers: dingtalkteam_sphere__1__0_models.UpdateProjectV3Headers,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkteam_sphere__1__0_models.UpdateProjectV3Response:
        """
        @summary 更新协作空间。
        
        @param request: UpdateProjectV3Request
        @param headers: UpdateProjectV3Headers
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateProjectV3Response
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateProjectV3',
            version='teamSphere_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/teamSphere/users/{user_id}/projects/{project_id}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkteam_sphere__1__0_models.UpdateProjectV3Response(),
            await self.execute_async(params, req, runtime)
        )

    def update_project_v3(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkteam_sphere__1__0_models.UpdateProjectV3Request,
    ) -> dingtalkteam_sphere__1__0_models.UpdateProjectV3Response:
        """
        @summary 更新协作空间。
        
        @param request: UpdateProjectV3Request
        @return: UpdateProjectV3Response
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.UpdateProjectV3Headers()
        return self.update_project_v3with_options(user_id, project_id, request, headers, runtime)

    async def update_project_v3_async(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkteam_sphere__1__0_models.UpdateProjectV3Request,
    ) -> dingtalkteam_sphere__1__0_models.UpdateProjectV3Response:
        """
        @summary 更新协作空间。
        
        @param request: UpdateProjectV3Request
        @return: UpdateProjectV3Response
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkteam_sphere__1__0_models.UpdateProjectV3Headers()
        return await self.update_project_v3with_options_async(user_id, project_id, request, headers, runtime)
