# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_gateway_spi.client import Client as SPIClient
from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.project_1_0 import models as dingtalkproject__1__0_models
from alibabacloud_tea_util import models as util_models
from alibabacloud_openapi_util.client import Client as OpenApiUtilClient


class Client(OpenApiClient):
    """
    *\
    """
    _client: SPIClient = None

    def __init__(
        self, 
        config: open_api_models.Config,
    ):
        super().__init__(config)
        self._client = GatewayClientClient()
        self._spi = self._client
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def add_project_member_with_options(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.AddProjectMemberRequest,
        headers: dingtalkproject__1__0_models.AddProjectMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.AddProjectMemberResponse:
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
            action='AddProjectMember',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/projects/{project_id}/members',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.AddProjectMemberResponse(),
            self.execute(params, req, runtime)
        )

    async def add_project_member_with_options_async(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.AddProjectMemberRequest,
        headers: dingtalkproject__1__0_models.AddProjectMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.AddProjectMemberResponse:
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
            action='AddProjectMember',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/projects/{project_id}/members',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.AddProjectMemberResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_project_member(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.AddProjectMemberRequest,
    ) -> dingtalkproject__1__0_models.AddProjectMemberResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.AddProjectMemberHeaders()
        return self.add_project_member_with_options(user_id, project_id, request, headers, runtime)

    async def add_project_member_async(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.AddProjectMemberRequest,
    ) -> dingtalkproject__1__0_models.AddProjectMemberResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.AddProjectMemberHeaders()
        return await self.add_project_member_with_options_async(user_id, project_id, request, headers, runtime)

    def archive_project_with_options(
        self,
        user_id: str,
        project_id: str,
        headers: dingtalkproject__1__0_models.ArchiveProjectHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.ArchiveProjectResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='ArchiveProject',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/projects/{project_id}/archive',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.ArchiveProjectResponse(),
            self.execute(params, req, runtime)
        )

    async def archive_project_with_options_async(
        self,
        user_id: str,
        project_id: str,
        headers: dingtalkproject__1__0_models.ArchiveProjectHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.ArchiveProjectResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='ArchiveProject',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/projects/{project_id}/archive',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.ArchiveProjectResponse(),
            await self.execute_async(params, req, runtime)
        )

    def archive_project(
        self,
        user_id: str,
        project_id: str,
    ) -> dingtalkproject__1__0_models.ArchiveProjectResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.ArchiveProjectHeaders()
        return self.archive_project_with_options(user_id, project_id, headers, runtime)

    async def archive_project_async(
        self,
        user_id: str,
        project_id: str,
    ) -> dingtalkproject__1__0_models.ArchiveProjectResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.ArchiveProjectHeaders()
        return await self.archive_project_with_options_async(user_id, project_id, headers, runtime)

    def archive_task_with_options(
        self,
        user_id: str,
        task_id: str,
        headers: dingtalkproject__1__0_models.ArchiveTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.ArchiveTaskResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='ArchiveTask',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/tasks/{task_id}/archive',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.ArchiveTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def archive_task_with_options_async(
        self,
        user_id: str,
        task_id: str,
        headers: dingtalkproject__1__0_models.ArchiveTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.ArchiveTaskResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='ArchiveTask',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/tasks/{task_id}/archive',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.ArchiveTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def archive_task(
        self,
        user_id: str,
        task_id: str,
    ) -> dingtalkproject__1__0_models.ArchiveTaskResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.ArchiveTaskHeaders()
        return self.archive_task_with_options(user_id, task_id, headers, runtime)

    async def archive_task_async(
        self,
        user_id: str,
        task_id: str,
    ) -> dingtalkproject__1__0_models.ArchiveTaskResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.ArchiveTaskHeaders()
        return await self.archive_task_with_options_async(user_id, task_id, headers, runtime)

    def create_organization_task_with_options(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.CreateOrganizationTaskRequest,
        headers: dingtalkproject__1__0_models.CreateOrganizationTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.CreateOrganizationTaskResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.create_time):
            body['createTime'] = request.create_time
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
        if not UtilClient.is_unset(request.priority):
            body['priority'] = request.priority
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
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/organizations/users/{user_id}/tasks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.CreateOrganizationTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def create_organization_task_with_options_async(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.CreateOrganizationTaskRequest,
        headers: dingtalkproject__1__0_models.CreateOrganizationTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.CreateOrganizationTaskResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.create_time):
            body['createTime'] = request.create_time
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
        if not UtilClient.is_unset(request.priority):
            body['priority'] = request.priority
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
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/organizations/users/{user_id}/tasks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.CreateOrganizationTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_organization_task(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.CreateOrganizationTaskRequest,
    ) -> dingtalkproject__1__0_models.CreateOrganizationTaskResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.CreateOrganizationTaskHeaders()
        return self.create_organization_task_with_options(user_id, request, headers, runtime)

    async def create_organization_task_async(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.CreateOrganizationTaskRequest,
    ) -> dingtalkproject__1__0_models.CreateOrganizationTaskResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.CreateOrganizationTaskHeaders()
        return await self.create_organization_task_with_options_async(user_id, request, headers, runtime)

    def create_plan_time_with_options(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.CreatePlanTimeRequest,
        headers: dingtalkproject__1__0_models.CreatePlanTimeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.CreatePlanTimeResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.tenant_type):
            query['tenantType'] = request.tenant_type
        body = {}
        if not UtilClient.is_unset(request.end_date):
            body['endDate'] = request.end_date
        if not UtilClient.is_unset(request.executor_id):
            body['executorId'] = request.executor_id
        if not UtilClient.is_unset(request.includes_holidays):
            body['includesHolidays'] = request.includes_holidays
        if not UtilClient.is_unset(request.is_duration):
            body['isDuration'] = request.is_duration
        if not UtilClient.is_unset(request.object_id):
            body['objectId'] = request.object_id
        if not UtilClient.is_unset(request.object_type):
            body['objectType'] = request.object_type
        if not UtilClient.is_unset(request.plan_time):
            body['planTime'] = request.plan_time
        if not UtilClient.is_unset(request.start_date):
            body['startDate'] = request.start_date
        if not UtilClient.is_unset(request.submitter_id):
            body['submitterId'] = request.submitter_id
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
            action='CreatePlanTime',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/planTimes',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.CreatePlanTimeResponse(),
            self.execute(params, req, runtime)
        )

    async def create_plan_time_with_options_async(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.CreatePlanTimeRequest,
        headers: dingtalkproject__1__0_models.CreatePlanTimeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.CreatePlanTimeResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.tenant_type):
            query['tenantType'] = request.tenant_type
        body = {}
        if not UtilClient.is_unset(request.end_date):
            body['endDate'] = request.end_date
        if not UtilClient.is_unset(request.executor_id):
            body['executorId'] = request.executor_id
        if not UtilClient.is_unset(request.includes_holidays):
            body['includesHolidays'] = request.includes_holidays
        if not UtilClient.is_unset(request.is_duration):
            body['isDuration'] = request.is_duration
        if not UtilClient.is_unset(request.object_id):
            body['objectId'] = request.object_id
        if not UtilClient.is_unset(request.object_type):
            body['objectType'] = request.object_type
        if not UtilClient.is_unset(request.plan_time):
            body['planTime'] = request.plan_time
        if not UtilClient.is_unset(request.start_date):
            body['startDate'] = request.start_date
        if not UtilClient.is_unset(request.submitter_id):
            body['submitterId'] = request.submitter_id
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
            action='CreatePlanTime',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/planTimes',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.CreatePlanTimeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_plan_time(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.CreatePlanTimeRequest,
    ) -> dingtalkproject__1__0_models.CreatePlanTimeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.CreatePlanTimeHeaders()
        return self.create_plan_time_with_options(user_id, request, headers, runtime)

    async def create_plan_time_async(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.CreatePlanTimeRequest,
    ) -> dingtalkproject__1__0_models.CreatePlanTimeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.CreatePlanTimeHeaders()
        return await self.create_plan_time_with_options_async(user_id, request, headers, runtime)

    def create_project_with_options(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.CreateProjectRequest,
        headers: dingtalkproject__1__0_models.CreateProjectHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.CreateProjectResponse:
        UtilClient.validate_model(request)
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
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateProject',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/projects',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.CreateProjectResponse(),
            self.execute(params, req, runtime)
        )

    async def create_project_with_options_async(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.CreateProjectRequest,
        headers: dingtalkproject__1__0_models.CreateProjectHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.CreateProjectResponse:
        UtilClient.validate_model(request)
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
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateProject',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/projects',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.CreateProjectResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_project(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.CreateProjectRequest,
    ) -> dingtalkproject__1__0_models.CreateProjectResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.CreateProjectHeaders()
        return self.create_project_with_options(user_id, request, headers, runtime)

    async def create_project_async(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.CreateProjectRequest,
    ) -> dingtalkproject__1__0_models.CreateProjectResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.CreateProjectHeaders()
        return await self.create_project_with_options_async(user_id, request, headers, runtime)

    def create_project_by_template_with_options(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.CreateProjectByTemplateRequest,
        headers: dingtalkproject__1__0_models.CreateProjectByTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.CreateProjectByTemplateResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
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
            action='CreateProjectByTemplate',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/templates/projects',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.CreateProjectByTemplateResponse(),
            self.execute(params, req, runtime)
        )

    async def create_project_by_template_with_options_async(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.CreateProjectByTemplateRequest,
        headers: dingtalkproject__1__0_models.CreateProjectByTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.CreateProjectByTemplateResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
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
            action='CreateProjectByTemplate',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/templates/projects',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.CreateProjectByTemplateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_project_by_template(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.CreateProjectByTemplateRequest,
    ) -> dingtalkproject__1__0_models.CreateProjectByTemplateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.CreateProjectByTemplateHeaders()
        return self.create_project_by_template_with_options(user_id, request, headers, runtime)

    async def create_project_by_template_async(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.CreateProjectByTemplateRequest,
    ) -> dingtalkproject__1__0_models.CreateProjectByTemplateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.CreateProjectByTemplateHeaders()
        return await self.create_project_by_template_with_options_async(user_id, request, headers, runtime)

    def create_project_customfield_status_with_options(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.CreateProjectCustomfieldStatusRequest,
        headers: dingtalkproject__1__0_models.CreateProjectCustomfieldStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.CreateProjectCustomfieldStatusResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.custom_field_id):
            body['customFieldId'] = request.custom_field_id
        if not UtilClient.is_unset(request.custom_field_instance_id):
            body['customFieldInstanceId'] = request.custom_field_instance_id
        if not UtilClient.is_unset(request.custom_field_name):
            body['customFieldName'] = request.custom_field_name
        if not UtilClient.is_unset(request.value):
            body['value'] = request.value
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
            action='CreateProjectCustomfieldStatus',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/projects/{project_id}/customfields',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.CreateProjectCustomfieldStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def create_project_customfield_status_with_options_async(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.CreateProjectCustomfieldStatusRequest,
        headers: dingtalkproject__1__0_models.CreateProjectCustomfieldStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.CreateProjectCustomfieldStatusResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.custom_field_id):
            body['customFieldId'] = request.custom_field_id
        if not UtilClient.is_unset(request.custom_field_instance_id):
            body['customFieldInstanceId'] = request.custom_field_instance_id
        if not UtilClient.is_unset(request.custom_field_name):
            body['customFieldName'] = request.custom_field_name
        if not UtilClient.is_unset(request.value):
            body['value'] = request.value
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
            action='CreateProjectCustomfieldStatus',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/projects/{project_id}/customfields',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.CreateProjectCustomfieldStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_project_customfield_status(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.CreateProjectCustomfieldStatusRequest,
    ) -> dingtalkproject__1__0_models.CreateProjectCustomfieldStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.CreateProjectCustomfieldStatusHeaders()
        return self.create_project_customfield_status_with_options(user_id, project_id, request, headers, runtime)

    async def create_project_customfield_status_async(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.CreateProjectCustomfieldStatusRequest,
    ) -> dingtalkproject__1__0_models.CreateProjectCustomfieldStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.CreateProjectCustomfieldStatusHeaders()
        return await self.create_project_customfield_status_with_options_async(user_id, project_id, request, headers, runtime)

    def create_task_with_options(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.CreateTaskRequest,
        headers: dingtalkproject__1__0_models.CreateTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.CreateTaskResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.customfields):
            body['customfields'] = request.customfields
        if not UtilClient.is_unset(request.due_date):
            body['dueDate'] = request.due_date
        if not UtilClient.is_unset(request.executor_id):
            body['executorId'] = request.executor_id
        if not UtilClient.is_unset(request.note):
            body['note'] = request.note
        if not UtilClient.is_unset(request.parent_task_id):
            body['parentTaskId'] = request.parent_task_id
        if not UtilClient.is_unset(request.priority):
            body['priority'] = request.priority
        if not UtilClient.is_unset(request.project_id):
            body['projectId'] = request.project_id
        if not UtilClient.is_unset(request.scenariofieldconfig_id):
            body['scenariofieldconfigId'] = request.scenariofieldconfig_id
        if not UtilClient.is_unset(request.stage_id):
            body['stageId'] = request.stage_id
        if not UtilClient.is_unset(request.start_date):
            body['startDate'] = request.start_date
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
            action='CreateTask',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/tasks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.CreateTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def create_task_with_options_async(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.CreateTaskRequest,
        headers: dingtalkproject__1__0_models.CreateTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.CreateTaskResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.customfields):
            body['customfields'] = request.customfields
        if not UtilClient.is_unset(request.due_date):
            body['dueDate'] = request.due_date
        if not UtilClient.is_unset(request.executor_id):
            body['executorId'] = request.executor_id
        if not UtilClient.is_unset(request.note):
            body['note'] = request.note
        if not UtilClient.is_unset(request.parent_task_id):
            body['parentTaskId'] = request.parent_task_id
        if not UtilClient.is_unset(request.priority):
            body['priority'] = request.priority
        if not UtilClient.is_unset(request.project_id):
            body['projectId'] = request.project_id
        if not UtilClient.is_unset(request.scenariofieldconfig_id):
            body['scenariofieldconfigId'] = request.scenariofieldconfig_id
        if not UtilClient.is_unset(request.stage_id):
            body['stageId'] = request.stage_id
        if not UtilClient.is_unset(request.start_date):
            body['startDate'] = request.start_date
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
            action='CreateTask',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/tasks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.CreateTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_task(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.CreateTaskRequest,
    ) -> dingtalkproject__1__0_models.CreateTaskResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.CreateTaskHeaders()
        return self.create_task_with_options(user_id, request, headers, runtime)

    async def create_task_async(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.CreateTaskRequest,
    ) -> dingtalkproject__1__0_models.CreateTaskResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.CreateTaskHeaders()
        return await self.create_task_with_options_async(user_id, request, headers, runtime)

    def create_task_object_link_with_options(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.CreateTaskObjectLinkRequest,
        headers: dingtalkproject__1__0_models.CreateTaskObjectLinkHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.CreateTaskObjectLinkResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.linked_data):
            body['linkedData'] = request.linked_data
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
            action='CreateTaskObjectLink',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/tasks/{task_id}/objectLinks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.CreateTaskObjectLinkResponse(),
            self.execute(params, req, runtime)
        )

    async def create_task_object_link_with_options_async(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.CreateTaskObjectLinkRequest,
        headers: dingtalkproject__1__0_models.CreateTaskObjectLinkHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.CreateTaskObjectLinkResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.linked_data):
            body['linkedData'] = request.linked_data
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
            action='CreateTaskObjectLink',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/tasks/{task_id}/objectLinks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.CreateTaskObjectLinkResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_task_object_link(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.CreateTaskObjectLinkRequest,
    ) -> dingtalkproject__1__0_models.CreateTaskObjectLinkResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.CreateTaskObjectLinkHeaders()
        return self.create_task_object_link_with_options(user_id, task_id, request, headers, runtime)

    async def create_task_object_link_async(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.CreateTaskObjectLinkRequest,
    ) -> dingtalkproject__1__0_models.CreateTaskObjectLinkResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.CreateTaskObjectLinkHeaders()
        return await self.create_task_object_link_with_options_async(user_id, task_id, request, headers, runtime)

    def create_work_time_with_options(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.CreateWorkTimeRequest,
        headers: dingtalkproject__1__0_models.CreateWorkTimeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.CreateWorkTimeResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.tenant_type):
            query['tenantType'] = request.tenant_type
        body = {}
        if not UtilClient.is_unset(request.end_date):
            body['endDate'] = request.end_date
        if not UtilClient.is_unset(request.executor_id):
            body['executorId'] = request.executor_id
        if not UtilClient.is_unset(request.includes_holidays):
            body['includesHolidays'] = request.includes_holidays
        if not UtilClient.is_unset(request.is_duration):
            body['isDuration'] = request.is_duration
        if not UtilClient.is_unset(request.object_id):
            body['objectId'] = request.object_id
        if not UtilClient.is_unset(request.object_type):
            body['objectType'] = request.object_type
        if not UtilClient.is_unset(request.start_date):
            body['startDate'] = request.start_date
        if not UtilClient.is_unset(request.submitter_id):
            body['submitterId'] = request.submitter_id
        if not UtilClient.is_unset(request.work_time):
            body['workTime'] = request.work_time
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
            action='CreateWorkTime',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/workTimes',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.CreateWorkTimeResponse(),
            self.execute(params, req, runtime)
        )

    async def create_work_time_with_options_async(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.CreateWorkTimeRequest,
        headers: dingtalkproject__1__0_models.CreateWorkTimeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.CreateWorkTimeResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.tenant_type):
            query['tenantType'] = request.tenant_type
        body = {}
        if not UtilClient.is_unset(request.end_date):
            body['endDate'] = request.end_date
        if not UtilClient.is_unset(request.executor_id):
            body['executorId'] = request.executor_id
        if not UtilClient.is_unset(request.includes_holidays):
            body['includesHolidays'] = request.includes_holidays
        if not UtilClient.is_unset(request.is_duration):
            body['isDuration'] = request.is_duration
        if not UtilClient.is_unset(request.object_id):
            body['objectId'] = request.object_id
        if not UtilClient.is_unset(request.object_type):
            body['objectType'] = request.object_type
        if not UtilClient.is_unset(request.start_date):
            body['startDate'] = request.start_date
        if not UtilClient.is_unset(request.submitter_id):
            body['submitterId'] = request.submitter_id
        if not UtilClient.is_unset(request.work_time):
            body['workTime'] = request.work_time
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
            action='CreateWorkTime',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/workTimes',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.CreateWorkTimeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_work_time(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.CreateWorkTimeRequest,
    ) -> dingtalkproject__1__0_models.CreateWorkTimeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.CreateWorkTimeHeaders()
        return self.create_work_time_with_options(user_id, request, headers, runtime)

    async def create_work_time_async(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.CreateWorkTimeRequest,
    ) -> dingtalkproject__1__0_models.CreateWorkTimeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.CreateWorkTimeHeaders()
        return await self.create_work_time_with_options_async(user_id, request, headers, runtime)

    def create_work_time_approve_with_options(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.CreateWorkTimeApproveRequest,
        headers: dingtalkproject__1__0_models.CreateWorkTimeApproveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.CreateWorkTimeApproveResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.work_time_ids):
            body['workTimeIds'] = request.work_time_ids
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
            action='CreateWorkTimeApprove',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/workTimes/approvals',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.CreateWorkTimeApproveResponse(),
            self.execute(params, req, runtime)
        )

    async def create_work_time_approve_with_options_async(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.CreateWorkTimeApproveRequest,
        headers: dingtalkproject__1__0_models.CreateWorkTimeApproveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.CreateWorkTimeApproveResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.work_time_ids):
            body['workTimeIds'] = request.work_time_ids
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
            action='CreateWorkTimeApprove',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/workTimes/approvals',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.CreateWorkTimeApproveResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_work_time_approve(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.CreateWorkTimeApproveRequest,
    ) -> dingtalkproject__1__0_models.CreateWorkTimeApproveResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.CreateWorkTimeApproveHeaders()
        return self.create_work_time_approve_with_options(user_id, request, headers, runtime)

    async def create_work_time_approve_async(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.CreateWorkTimeApproveRequest,
    ) -> dingtalkproject__1__0_models.CreateWorkTimeApproveResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.CreateWorkTimeApproveHeaders()
        return await self.create_work_time_approve_with_options_async(user_id, request, headers, runtime)

    def delete_project_member_with_options(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.DeleteProjectMemberRequest,
        headers: dingtalkproject__1__0_models.DeleteProjectMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.DeleteProjectMemberResponse:
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
            action='DeleteProjectMember',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/projects/{project_id}/members/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.DeleteProjectMemberResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_project_member_with_options_async(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.DeleteProjectMemberRequest,
        headers: dingtalkproject__1__0_models.DeleteProjectMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.DeleteProjectMemberResponse:
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
            action='DeleteProjectMember',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/projects/{project_id}/members/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.DeleteProjectMemberResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_project_member(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.DeleteProjectMemberRequest,
    ) -> dingtalkproject__1__0_models.DeleteProjectMemberResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.DeleteProjectMemberHeaders()
        return self.delete_project_member_with_options(user_id, project_id, request, headers, runtime)

    async def delete_project_member_async(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.DeleteProjectMemberRequest,
    ) -> dingtalkproject__1__0_models.DeleteProjectMemberResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.DeleteProjectMemberHeaders()
        return await self.delete_project_member_with_options_async(user_id, project_id, request, headers, runtime)

    def delete_task_with_options(
        self,
        user_id: str,
        task_id: str,
        headers: dingtalkproject__1__0_models.DeleteTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.DeleteTaskResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='DeleteTask',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/tasks/{task_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.DeleteTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_task_with_options_async(
        self,
        user_id: str,
        task_id: str,
        headers: dingtalkproject__1__0_models.DeleteTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.DeleteTaskResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='DeleteTask',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/tasks/{task_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.DeleteTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_task(
        self,
        user_id: str,
        task_id: str,
    ) -> dingtalkproject__1__0_models.DeleteTaskResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.DeleteTaskHeaders()
        return self.delete_task_with_options(user_id, task_id, headers, runtime)

    async def delete_task_async(
        self,
        user_id: str,
        task_id: str,
    ) -> dingtalkproject__1__0_models.DeleteTaskResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.DeleteTaskHeaders()
        return await self.delete_task_with_options_async(user_id, task_id, headers, runtime)

    def get_depts_by_org_id_with_options(
        self,
        request: dingtalkproject__1__0_models.GetDeptsByOrgIdRequest,
        headers: dingtalkproject__1__0_models.GetDeptsByOrgIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.GetDeptsByOrgIdResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.ding_access_token_type):
            real_headers['dingAccessTokenType'] = UtilClient.to_jsonstring(headers.ding_access_token_type)
        if not UtilClient.is_unset(headers.ding_org_id):
            real_headers['dingOrgId'] = UtilClient.to_jsonstring(headers.ding_org_id)
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetDeptsByOrgId',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/orgs/depts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetDeptsByOrgIdResponse(),
            self.execute(params, req, runtime)
        )

    async def get_depts_by_org_id_with_options_async(
        self,
        request: dingtalkproject__1__0_models.GetDeptsByOrgIdRequest,
        headers: dingtalkproject__1__0_models.GetDeptsByOrgIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.GetDeptsByOrgIdResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.ding_access_token_type):
            real_headers['dingAccessTokenType'] = UtilClient.to_jsonstring(headers.ding_access_token_type)
        if not UtilClient.is_unset(headers.ding_org_id):
            real_headers['dingOrgId'] = UtilClient.to_jsonstring(headers.ding_org_id)
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetDeptsByOrgId',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/orgs/depts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetDeptsByOrgIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_depts_by_org_id(
        self,
        request: dingtalkproject__1__0_models.GetDeptsByOrgIdRequest,
    ) -> dingtalkproject__1__0_models.GetDeptsByOrgIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.GetDeptsByOrgIdHeaders()
        return self.get_depts_by_org_id_with_options(request, headers, runtime)

    async def get_depts_by_org_id_async(
        self,
        request: dingtalkproject__1__0_models.GetDeptsByOrgIdRequest,
    ) -> dingtalkproject__1__0_models.GetDeptsByOrgIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.GetDeptsByOrgIdHeaders()
        return await self.get_depts_by_org_id_with_options_async(request, headers, runtime)

    def get_emps_by_org_id_with_options(
        self,
        request: dingtalkproject__1__0_models.GetEmpsByOrgIdRequest,
        headers: dingtalkproject__1__0_models.GetEmpsByOrgIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.GetEmpsByOrgIdResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.need_dept):
            query['needDept'] = request.need_dept
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.ding_access_token_type):
            real_headers['dingAccessTokenType'] = UtilClient.to_jsonstring(headers.ding_access_token_type)
        if not UtilClient.is_unset(headers.ding_org_id):
            real_headers['dingOrgId'] = UtilClient.to_jsonstring(headers.ding_org_id)
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetEmpsByOrgId',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/orgs/employees',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetEmpsByOrgIdResponse(),
            self.execute(params, req, runtime)
        )

    async def get_emps_by_org_id_with_options_async(
        self,
        request: dingtalkproject__1__0_models.GetEmpsByOrgIdRequest,
        headers: dingtalkproject__1__0_models.GetEmpsByOrgIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.GetEmpsByOrgIdResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.need_dept):
            query['needDept'] = request.need_dept
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.ding_access_token_type):
            real_headers['dingAccessTokenType'] = UtilClient.to_jsonstring(headers.ding_access_token_type)
        if not UtilClient.is_unset(headers.ding_org_id):
            real_headers['dingOrgId'] = UtilClient.to_jsonstring(headers.ding_org_id)
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetEmpsByOrgId',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/orgs/employees',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetEmpsByOrgIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_emps_by_org_id(
        self,
        request: dingtalkproject__1__0_models.GetEmpsByOrgIdRequest,
    ) -> dingtalkproject__1__0_models.GetEmpsByOrgIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.GetEmpsByOrgIdHeaders()
        return self.get_emps_by_org_id_with_options(request, headers, runtime)

    async def get_emps_by_org_id_async(
        self,
        request: dingtalkproject__1__0_models.GetEmpsByOrgIdRequest,
    ) -> dingtalkproject__1__0_models.GetEmpsByOrgIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.GetEmpsByOrgIdHeaders()
        return await self.get_emps_by_org_id_with_options_async(request, headers, runtime)

    def get_organizatio_task_by_ids_with_options(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.GetOrganizatioTaskByIdsRequest,
        headers: dingtalkproject__1__0_models.GetOrganizatioTaskByIdsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.GetOrganizatioTaskByIdsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.task_ids):
            query['taskIds'] = request.task_ids
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
            action='GetOrganizatioTaskByIds',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/organizations/users/{user_id}/tasks',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetOrganizatioTaskByIdsResponse(),
            self.execute(params, req, runtime)
        )

    async def get_organizatio_task_by_ids_with_options_async(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.GetOrganizatioTaskByIdsRequest,
        headers: dingtalkproject__1__0_models.GetOrganizatioTaskByIdsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.GetOrganizatioTaskByIdsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.task_ids):
            query['taskIds'] = request.task_ids
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
            action='GetOrganizatioTaskByIds',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/organizations/users/{user_id}/tasks',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetOrganizatioTaskByIdsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_organizatio_task_by_ids(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.GetOrganizatioTaskByIdsRequest,
    ) -> dingtalkproject__1__0_models.GetOrganizatioTaskByIdsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.GetOrganizatioTaskByIdsHeaders()
        return self.get_organizatio_task_by_ids_with_options(user_id, request, headers, runtime)

    async def get_organizatio_task_by_ids_async(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.GetOrganizatioTaskByIdsRequest,
    ) -> dingtalkproject__1__0_models.GetOrganizatioTaskByIdsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.GetOrganizatioTaskByIdsHeaders()
        return await self.get_organizatio_task_by_ids_with_options_async(user_id, request, headers, runtime)

    def get_organization_priority_list_with_options(
        self,
        user_id: str,
        headers: dingtalkproject__1__0_models.GetOrganizationPriorityListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.GetOrganizationPriorityListResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetOrganizationPriorityList',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/organizations/users/{user_id}/priorities',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetOrganizationPriorityListResponse(),
            self.execute(params, req, runtime)
        )

    async def get_organization_priority_list_with_options_async(
        self,
        user_id: str,
        headers: dingtalkproject__1__0_models.GetOrganizationPriorityListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.GetOrganizationPriorityListResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetOrganizationPriorityList',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/organizations/users/{user_id}/priorities',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetOrganizationPriorityListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_organization_priority_list(
        self,
        user_id: str,
    ) -> dingtalkproject__1__0_models.GetOrganizationPriorityListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.GetOrganizationPriorityListHeaders()
        return self.get_organization_priority_list_with_options(user_id, headers, runtime)

    async def get_organization_priority_list_async(
        self,
        user_id: str,
    ) -> dingtalkproject__1__0_models.GetOrganizationPriorityListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.GetOrganizationPriorityListHeaders()
        return await self.get_organization_priority_list_with_options_async(user_id, headers, runtime)

    def get_organization_task_with_options(
        self,
        task_id: str,
        user_id: str,
        headers: dingtalkproject__1__0_models.GetOrganizationTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.GetOrganizationTaskResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetOrganizationTask',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/organizations/users/{user_id}/tasks/{task_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetOrganizationTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def get_organization_task_with_options_async(
        self,
        task_id: str,
        user_id: str,
        headers: dingtalkproject__1__0_models.GetOrganizationTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.GetOrganizationTaskResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetOrganizationTask',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/organizations/users/{user_id}/tasks/{task_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetOrganizationTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_organization_task(
        self,
        task_id: str,
        user_id: str,
    ) -> dingtalkproject__1__0_models.GetOrganizationTaskResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.GetOrganizationTaskHeaders()
        return self.get_organization_task_with_options(task_id, user_id, headers, runtime)

    async def get_organization_task_async(
        self,
        task_id: str,
        user_id: str,
    ) -> dingtalkproject__1__0_models.GetOrganizationTaskResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.GetOrganizationTaskHeaders()
        return await self.get_organization_task_with_options_async(task_id, user_id, headers, runtime)

    def get_project_group_with_options(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.GetProjectGroupRequest,
        headers: dingtalkproject__1__0_models.GetProjectGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.GetProjectGroupResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.viewer_id):
            query['viewerId'] = request.viewer_id
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
            action='GetProjectGroup',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/organizations/users/{user_id}/groups',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetProjectGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def get_project_group_with_options_async(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.GetProjectGroupRequest,
        headers: dingtalkproject__1__0_models.GetProjectGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.GetProjectGroupResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.viewer_id):
            query['viewerId'] = request.viewer_id
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
            action='GetProjectGroup',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/organizations/users/{user_id}/groups',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetProjectGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_project_group(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.GetProjectGroupRequest,
    ) -> dingtalkproject__1__0_models.GetProjectGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.GetProjectGroupHeaders()
        return self.get_project_group_with_options(user_id, request, headers, runtime)

    async def get_project_group_async(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.GetProjectGroupRequest,
    ) -> dingtalkproject__1__0_models.GetProjectGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.GetProjectGroupHeaders()
        return await self.get_project_group_with_options_async(user_id, request, headers, runtime)

    def get_project_memebers_with_options(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.GetProjectMemebersRequest,
        headers: dingtalkproject__1__0_models.GetProjectMemebersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.GetProjectMemebersResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.project_role_id):
            query['projectRoleId'] = request.project_role_id
        if not UtilClient.is_unset(request.skip):
            query['skip'] = request.skip
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
            action='GetProjectMemebers',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/projects/{project_id}/members',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetProjectMemebersResponse(),
            self.execute(params, req, runtime)
        )

    async def get_project_memebers_with_options_async(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.GetProjectMemebersRequest,
        headers: dingtalkproject__1__0_models.GetProjectMemebersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.GetProjectMemebersResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.project_role_id):
            query['projectRoleId'] = request.project_role_id
        if not UtilClient.is_unset(request.skip):
            query['skip'] = request.skip
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
            action='GetProjectMemebers',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/projects/{project_id}/members',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetProjectMemebersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_project_memebers(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.GetProjectMemebersRequest,
    ) -> dingtalkproject__1__0_models.GetProjectMemebersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.GetProjectMemebersHeaders()
        return self.get_project_memebers_with_options(user_id, project_id, request, headers, runtime)

    async def get_project_memebers_async(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.GetProjectMemebersRequest,
    ) -> dingtalkproject__1__0_models.GetProjectMemebersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.GetProjectMemebersHeaders()
        return await self.get_project_memebers_with_options_async(user_id, project_id, request, headers, runtime)

    def get_project_status_list_with_options(
        self,
        user_id: str,
        project_id: str,
        headers: dingtalkproject__1__0_models.GetProjectStatusListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.GetProjectStatusListResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetProjectStatusList',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/projects/{project_id}/statuses',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetProjectStatusListResponse(),
            self.execute(params, req, runtime)
        )

    async def get_project_status_list_with_options_async(
        self,
        user_id: str,
        project_id: str,
        headers: dingtalkproject__1__0_models.GetProjectStatusListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.GetProjectStatusListResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetProjectStatusList',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/projects/{project_id}/statuses',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetProjectStatusListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_project_status_list(
        self,
        user_id: str,
        project_id: str,
    ) -> dingtalkproject__1__0_models.GetProjectStatusListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.GetProjectStatusListHeaders()
        return self.get_project_status_list_with_options(user_id, project_id, headers, runtime)

    async def get_project_status_list_async(
        self,
        user_id: str,
        project_id: str,
    ) -> dingtalkproject__1__0_models.GetProjectStatusListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.GetProjectStatusListHeaders()
        return await self.get_project_status_list_with_options_async(user_id, project_id, headers, runtime)

    def get_task_by_ids_with_options(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.GetTaskByIdsRequest,
        headers: dingtalkproject__1__0_models.GetTaskByIdsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.GetTaskByIdsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.parent_task_id):
            query['parentTaskId'] = request.parent_task_id
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
            action='GetTaskByIds',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/tasks',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetTaskByIdsResponse(),
            self.execute(params, req, runtime)
        )

    async def get_task_by_ids_with_options_async(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.GetTaskByIdsRequest,
        headers: dingtalkproject__1__0_models.GetTaskByIdsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.GetTaskByIdsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.parent_task_id):
            query['parentTaskId'] = request.parent_task_id
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
            action='GetTaskByIds',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/tasks',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetTaskByIdsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_task_by_ids(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.GetTaskByIdsRequest,
    ) -> dingtalkproject__1__0_models.GetTaskByIdsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.GetTaskByIdsHeaders()
        return self.get_task_by_ids_with_options(user_id, request, headers, runtime)

    async def get_task_by_ids_async(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.GetTaskByIdsRequest,
    ) -> dingtalkproject__1__0_models.GetTaskByIdsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.GetTaskByIdsHeaders()
        return await self.get_task_by_ids_with_options_async(user_id, request, headers, runtime)

    def get_tb_org_id_by_ding_org_id_with_options(
        self,
        request: dingtalkproject__1__0_models.GetTbOrgIdByDingOrgIdRequest,
        headers: dingtalkproject__1__0_models.GetTbOrgIdByDingOrgIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.GetTbOrgIdByDingOrgIdResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.opt_user_id):
            query['optUserId'] = request.opt_user_id
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
            action='GetTbOrgIdByDingOrgId',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/teambition/organizations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetTbOrgIdByDingOrgIdResponse(),
            self.execute(params, req, runtime)
        )

    async def get_tb_org_id_by_ding_org_id_with_options_async(
        self,
        request: dingtalkproject__1__0_models.GetTbOrgIdByDingOrgIdRequest,
        headers: dingtalkproject__1__0_models.GetTbOrgIdByDingOrgIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.GetTbOrgIdByDingOrgIdResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.opt_user_id):
            query['optUserId'] = request.opt_user_id
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
            action='GetTbOrgIdByDingOrgId',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/teambition/organizations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetTbOrgIdByDingOrgIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_tb_org_id_by_ding_org_id(
        self,
        request: dingtalkproject__1__0_models.GetTbOrgIdByDingOrgIdRequest,
    ) -> dingtalkproject__1__0_models.GetTbOrgIdByDingOrgIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.GetTbOrgIdByDingOrgIdHeaders()
        return self.get_tb_org_id_by_ding_org_id_with_options(request, headers, runtime)

    async def get_tb_org_id_by_ding_org_id_async(
        self,
        request: dingtalkproject__1__0_models.GetTbOrgIdByDingOrgIdRequest,
    ) -> dingtalkproject__1__0_models.GetTbOrgIdByDingOrgIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.GetTbOrgIdByDingOrgIdHeaders()
        return await self.get_tb_org_id_by_ding_org_id_with_options_async(request, headers, runtime)

    def get_tb_project_gray_with_options(
        self,
        request: dingtalkproject__1__0_models.GetTbProjectGrayRequest,
        headers: dingtalkproject__1__0_models.GetTbProjectGrayHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.GetTbProjectGrayResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.label):
            body['label'] = request.label
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.ding_access_token_type):
            real_headers['dingAccessTokenType'] = UtilClient.to_jsonstring(headers.ding_access_token_type)
        if not UtilClient.is_unset(headers.ding_corp_id):
            real_headers['dingCorpId'] = UtilClient.to_jsonstring(headers.ding_corp_id)
        if not UtilClient.is_unset(headers.ding_isv_org_id):
            real_headers['dingIsvOrgId'] = UtilClient.to_jsonstring(headers.ding_isv_org_id)
        if not UtilClient.is_unset(headers.ding_org_id):
            real_headers['dingOrgId'] = UtilClient.to_jsonstring(headers.ding_org_id)
        if not UtilClient.is_unset(headers.ding_suite_key):
            real_headers['dingSuiteKey'] = UtilClient.to_jsonstring(headers.ding_suite_key)
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetTbProjectGray',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/projects/gray',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetTbProjectGrayResponse(),
            self.execute(params, req, runtime)
        )

    async def get_tb_project_gray_with_options_async(
        self,
        request: dingtalkproject__1__0_models.GetTbProjectGrayRequest,
        headers: dingtalkproject__1__0_models.GetTbProjectGrayHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.GetTbProjectGrayResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.label):
            body['label'] = request.label
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.ding_access_token_type):
            real_headers['dingAccessTokenType'] = UtilClient.to_jsonstring(headers.ding_access_token_type)
        if not UtilClient.is_unset(headers.ding_corp_id):
            real_headers['dingCorpId'] = UtilClient.to_jsonstring(headers.ding_corp_id)
        if not UtilClient.is_unset(headers.ding_isv_org_id):
            real_headers['dingIsvOrgId'] = UtilClient.to_jsonstring(headers.ding_isv_org_id)
        if not UtilClient.is_unset(headers.ding_org_id):
            real_headers['dingOrgId'] = UtilClient.to_jsonstring(headers.ding_org_id)
        if not UtilClient.is_unset(headers.ding_suite_key):
            real_headers['dingSuiteKey'] = UtilClient.to_jsonstring(headers.ding_suite_key)
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetTbProjectGray',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/projects/gray',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetTbProjectGrayResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_tb_project_gray(
        self,
        request: dingtalkproject__1__0_models.GetTbProjectGrayRequest,
    ) -> dingtalkproject__1__0_models.GetTbProjectGrayResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.GetTbProjectGrayHeaders()
        return self.get_tb_project_gray_with_options(request, headers, runtime)

    async def get_tb_project_gray_async(
        self,
        request: dingtalkproject__1__0_models.GetTbProjectGrayRequest,
    ) -> dingtalkproject__1__0_models.GetTbProjectGrayResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.GetTbProjectGrayHeaders()
        return await self.get_tb_project_gray_with_options_async(request, headers, runtime)

    def get_tb_project_source_with_options(
        self,
        headers: dingtalkproject__1__0_models.GetTbProjectSourceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.GetTbProjectSourceResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.ding_access_token_type):
            real_headers['dingAccessTokenType'] = UtilClient.to_jsonstring(headers.ding_access_token_type)
        if not UtilClient.is_unset(headers.ding_corp_id):
            real_headers['dingCorpId'] = UtilClient.to_jsonstring(headers.ding_corp_id)
        if not UtilClient.is_unset(headers.ding_isv_org_id):
            real_headers['dingIsvOrgId'] = UtilClient.to_jsonstring(headers.ding_isv_org_id)
        if not UtilClient.is_unset(headers.ding_org_id):
            real_headers['dingOrgId'] = UtilClient.to_jsonstring(headers.ding_org_id)
        if not UtilClient.is_unset(headers.ding_suite_key):
            real_headers['dingSuiteKey'] = UtilClient.to_jsonstring(headers.ding_suite_key)
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetTbProjectSource',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/projects/source',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetTbProjectSourceResponse(),
            self.execute(params, req, runtime)
        )

    async def get_tb_project_source_with_options_async(
        self,
        headers: dingtalkproject__1__0_models.GetTbProjectSourceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.GetTbProjectSourceResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.ding_access_token_type):
            real_headers['dingAccessTokenType'] = UtilClient.to_jsonstring(headers.ding_access_token_type)
        if not UtilClient.is_unset(headers.ding_corp_id):
            real_headers['dingCorpId'] = UtilClient.to_jsonstring(headers.ding_corp_id)
        if not UtilClient.is_unset(headers.ding_isv_org_id):
            real_headers['dingIsvOrgId'] = UtilClient.to_jsonstring(headers.ding_isv_org_id)
        if not UtilClient.is_unset(headers.ding_org_id):
            real_headers['dingOrgId'] = UtilClient.to_jsonstring(headers.ding_org_id)
        if not UtilClient.is_unset(headers.ding_suite_key):
            real_headers['dingSuiteKey'] = UtilClient.to_jsonstring(headers.ding_suite_key)
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetTbProjectSource',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/projects/source',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetTbProjectSourceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_tb_project_source(self) -> dingtalkproject__1__0_models.GetTbProjectSourceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.GetTbProjectSourceHeaders()
        return self.get_tb_project_source_with_options(headers, runtime)

    async def get_tb_project_source_async(self) -> dingtalkproject__1__0_models.GetTbProjectSourceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.GetTbProjectSourceHeaders()
        return await self.get_tb_project_source_with_options_async(headers, runtime)

    def get_tb_user_id_by_staff_id_with_options(
        self,
        request: dingtalkproject__1__0_models.GetTbUserIdByStaffIdRequest,
        headers: dingtalkproject__1__0_models.GetTbUserIdByStaffIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.GetTbUserIdByStaffIdResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.opt_user_id):
            query['optUserId'] = request.opt_user_id
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
            action='GetTbUserIdByStaffId',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/teambition/users',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetTbUserIdByStaffIdResponse(),
            self.execute(params, req, runtime)
        )

    async def get_tb_user_id_by_staff_id_with_options_async(
        self,
        request: dingtalkproject__1__0_models.GetTbUserIdByStaffIdRequest,
        headers: dingtalkproject__1__0_models.GetTbUserIdByStaffIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.GetTbUserIdByStaffIdResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.opt_user_id):
            query['optUserId'] = request.opt_user_id
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
            action='GetTbUserIdByStaffId',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/teambition/users',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetTbUserIdByStaffIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_tb_user_id_by_staff_id(
        self,
        request: dingtalkproject__1__0_models.GetTbUserIdByStaffIdRequest,
    ) -> dingtalkproject__1__0_models.GetTbUserIdByStaffIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.GetTbUserIdByStaffIdHeaders()
        return self.get_tb_user_id_by_staff_id_with_options(request, headers, runtime)

    async def get_tb_user_id_by_staff_id_async(
        self,
        request: dingtalkproject__1__0_models.GetTbUserIdByStaffIdRequest,
    ) -> dingtalkproject__1__0_models.GetTbUserIdByStaffIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.GetTbUserIdByStaffIdHeaders()
        return await self.get_tb_user_id_by_staff_id_with_options_async(request, headers, runtime)

    def get_user_joined_project_with_options(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.GetUserJoinedProjectRequest,
        headers: dingtalkproject__1__0_models.GetUserJoinedProjectHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.GetUserJoinedProjectResponse:
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
            action='GetUserJoinedProject',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/joinProjects',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetUserJoinedProjectResponse(),
            self.execute(params, req, runtime)
        )

    async def get_user_joined_project_with_options_async(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.GetUserJoinedProjectRequest,
        headers: dingtalkproject__1__0_models.GetUserJoinedProjectHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.GetUserJoinedProjectResponse:
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
            action='GetUserJoinedProject',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/joinProjects',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetUserJoinedProjectResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_user_joined_project(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.GetUserJoinedProjectRequest,
    ) -> dingtalkproject__1__0_models.GetUserJoinedProjectResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.GetUserJoinedProjectHeaders()
        return self.get_user_joined_project_with_options(user_id, request, headers, runtime)

    async def get_user_joined_project_async(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.GetUserJoinedProjectRequest,
    ) -> dingtalkproject__1__0_models.GetUserJoinedProjectResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.GetUserJoinedProjectHeaders()
        return await self.get_user_joined_project_with_options_async(user_id, request, headers, runtime)

    def query_project_with_options(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.QueryProjectRequest,
        headers: dingtalkproject__1__0_models.QueryProjectHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.QueryProjectResponse:
        UtilClient.validate_model(request)
        query = {}
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
            action='QueryProject',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/projects/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.QueryProjectResponse(),
            self.execute(params, req, runtime)
        )

    async def query_project_with_options_async(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.QueryProjectRequest,
        headers: dingtalkproject__1__0_models.QueryProjectHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.QueryProjectResponse:
        UtilClient.validate_model(request)
        query = {}
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
            action='QueryProject',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/projects/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.QueryProjectResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_project(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.QueryProjectRequest,
    ) -> dingtalkproject__1__0_models.QueryProjectResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.QueryProjectHeaders()
        return self.query_project_with_options(user_id, request, headers, runtime)

    async def query_project_async(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.QueryProjectRequest,
    ) -> dingtalkproject__1__0_models.QueryProjectResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.QueryProjectHeaders()
        return await self.query_project_with_options_async(user_id, request, headers, runtime)

    def query_task_of_project_with_options(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.QueryTaskOfProjectRequest,
        headers: dingtalkproject__1__0_models.QueryTaskOfProjectHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.QueryTaskOfProjectResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.query):
            query['query'] = request.query
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
            action='QueryTaskOfProject',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/projectIds/{project_id}/tasks',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.QueryTaskOfProjectResponse(),
            self.execute(params, req, runtime)
        )

    async def query_task_of_project_with_options_async(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.QueryTaskOfProjectRequest,
        headers: dingtalkproject__1__0_models.QueryTaskOfProjectHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.QueryTaskOfProjectResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.query):
            query['query'] = request.query
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
            action='QueryTaskOfProject',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/projectIds/{project_id}/tasks',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.QueryTaskOfProjectResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_task_of_project(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.QueryTaskOfProjectRequest,
    ) -> dingtalkproject__1__0_models.QueryTaskOfProjectResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.QueryTaskOfProjectHeaders()
        return self.query_task_of_project_with_options(user_id, project_id, request, headers, runtime)

    async def query_task_of_project_async(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.QueryTaskOfProjectRequest,
    ) -> dingtalkproject__1__0_models.QueryTaskOfProjectResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.QueryTaskOfProjectHeaders()
        return await self.query_task_of_project_with_options_async(user_id, project_id, request, headers, runtime)

    def seach_task_stage_with_options(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.SeachTaskStageRequest,
        headers: dingtalkproject__1__0_models.SeachTaskStageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.SeachTaskStageResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.query):
            query['query'] = request.query
        if not UtilClient.is_unset(request.task_list_id):
            query['taskListId'] = request.task_list_id
        if not UtilClient.is_unset(request.task_stage_ids):
            query['taskStageIds'] = request.task_stage_ids
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
            action='SeachTaskStage',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/projects/{project_id}/taskStages/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.SeachTaskStageResponse(),
            self.execute(params, req, runtime)
        )

    async def seach_task_stage_with_options_async(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.SeachTaskStageRequest,
        headers: dingtalkproject__1__0_models.SeachTaskStageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.SeachTaskStageResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.query):
            query['query'] = request.query
        if not UtilClient.is_unset(request.task_list_id):
            query['taskListId'] = request.task_list_id
        if not UtilClient.is_unset(request.task_stage_ids):
            query['taskStageIds'] = request.task_stage_ids
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
            action='SeachTaskStage',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/projects/{project_id}/taskStages/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.SeachTaskStageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def seach_task_stage(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.SeachTaskStageRequest,
    ) -> dingtalkproject__1__0_models.SeachTaskStageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.SeachTaskStageHeaders()
        return self.seach_task_stage_with_options(user_id, project_id, request, headers, runtime)

    async def seach_task_stage_async(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.SeachTaskStageRequest,
    ) -> dingtalkproject__1__0_models.SeachTaskStageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.SeachTaskStageHeaders()
        return await self.seach_task_stage_with_options_async(user_id, project_id, request, headers, runtime)

    def search_all_tasks_by_tql_with_options(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.SearchAllTasksByTqlRequest,
        headers: dingtalkproject__1__0_models.SearchAllTasksByTqlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.SearchAllTasksByTqlResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.tql):
            query['tql'] = request.tql
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
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/tql/tasks/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.SearchAllTasksByTqlResponse(),
            self.execute(params, req, runtime)
        )

    async def search_all_tasks_by_tql_with_options_async(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.SearchAllTasksByTqlRequest,
        headers: dingtalkproject__1__0_models.SearchAllTasksByTqlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.SearchAllTasksByTqlResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.tql):
            query['tql'] = request.tql
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
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/tql/tasks/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.SearchAllTasksByTqlResponse(),
            await self.execute_async(params, req, runtime)
        )

    def search_all_tasks_by_tql(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.SearchAllTasksByTqlRequest,
    ) -> dingtalkproject__1__0_models.SearchAllTasksByTqlResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.SearchAllTasksByTqlHeaders()
        return self.search_all_tasks_by_tql_with_options(user_id, request, headers, runtime)

    async def search_all_tasks_by_tql_async(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.SearchAllTasksByTqlRequest,
    ) -> dingtalkproject__1__0_models.SearchAllTasksByTqlResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.SearchAllTasksByTqlHeaders()
        return await self.search_all_tasks_by_tql_with_options_async(user_id, request, headers, runtime)

    def search_oranization_customfield_with_options(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.SearchOranizationCustomfieldRequest,
        headers: dingtalkproject__1__0_models.SearchOranizationCustomfieldHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.SearchOranizationCustomfieldResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.custom_field_ids):
            query['customFieldIds'] = request.custom_field_ids
        if not UtilClient.is_unset(request.instance_ids):
            query['instanceIds'] = request.instance_ids
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.project_ids):
            query['projectIds'] = request.project_ids
        if not UtilClient.is_unset(request.query):
            query['query'] = request.query
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
            action='SearchOranizationCustomfield',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/organizations/users/{user_id}/customfields/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.SearchOranizationCustomfieldResponse(),
            self.execute(params, req, runtime)
        )

    async def search_oranization_customfield_with_options_async(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.SearchOranizationCustomfieldRequest,
        headers: dingtalkproject__1__0_models.SearchOranizationCustomfieldHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.SearchOranizationCustomfieldResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.custom_field_ids):
            query['customFieldIds'] = request.custom_field_ids
        if not UtilClient.is_unset(request.instance_ids):
            query['instanceIds'] = request.instance_ids
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.project_ids):
            query['projectIds'] = request.project_ids
        if not UtilClient.is_unset(request.query):
            query['query'] = request.query
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
            action='SearchOranizationCustomfield',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/organizations/users/{user_id}/customfields/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.SearchOranizationCustomfieldResponse(),
            await self.execute_async(params, req, runtime)
        )

    def search_oranization_customfield(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.SearchOranizationCustomfieldRequest,
    ) -> dingtalkproject__1__0_models.SearchOranizationCustomfieldResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.SearchOranizationCustomfieldHeaders()
        return self.search_oranization_customfield_with_options(user_id, request, headers, runtime)

    async def search_oranization_customfield_async(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.SearchOranizationCustomfieldRequest,
    ) -> dingtalkproject__1__0_models.SearchOranizationCustomfieldResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.SearchOranizationCustomfieldHeaders()
        return await self.search_oranization_customfield_with_options_async(user_id, request, headers, runtime)

    def search_project_customfield_with_options(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.SearchProjectCustomfieldRequest,
        headers: dingtalkproject__1__0_models.SearchProjectCustomfieldHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.SearchProjectCustomfieldResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.custom_field_ids):
            query['customFieldIds'] = request.custom_field_ids
        if not UtilClient.is_unset(request.instance_ids):
            query['instanceIds'] = request.instance_ids
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.query):
            query['query'] = request.query
        if not UtilClient.is_unset(request.scenario_field_config_id):
            query['scenarioFieldConfigId'] = request.scenario_field_config_id
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
            action='SearchProjectCustomfield',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/projects/{project_id}/customfields/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.SearchProjectCustomfieldResponse(),
            self.execute(params, req, runtime)
        )

    async def search_project_customfield_with_options_async(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.SearchProjectCustomfieldRequest,
        headers: dingtalkproject__1__0_models.SearchProjectCustomfieldHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.SearchProjectCustomfieldResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.custom_field_ids):
            query['customFieldIds'] = request.custom_field_ids
        if not UtilClient.is_unset(request.instance_ids):
            query['instanceIds'] = request.instance_ids
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.query):
            query['query'] = request.query
        if not UtilClient.is_unset(request.scenario_field_config_id):
            query['scenarioFieldConfigId'] = request.scenario_field_config_id
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
            action='SearchProjectCustomfield',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/projects/{project_id}/customfields/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.SearchProjectCustomfieldResponse(),
            await self.execute_async(params, req, runtime)
        )

    def search_project_customfield(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.SearchProjectCustomfieldRequest,
    ) -> dingtalkproject__1__0_models.SearchProjectCustomfieldResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.SearchProjectCustomfieldHeaders()
        return self.search_project_customfield_with_options(user_id, project_id, request, headers, runtime)

    async def search_project_customfield_async(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.SearchProjectCustomfieldRequest,
    ) -> dingtalkproject__1__0_models.SearchProjectCustomfieldResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.SearchProjectCustomfieldHeaders()
        return await self.search_project_customfield_with_options_async(user_id, project_id, request, headers, runtime)

    def search_project_template_with_options(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.SearchProjectTemplateRequest,
        headers: dingtalkproject__1__0_models.SearchProjectTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.SearchProjectTemplateResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.keyword):
            query['keyword'] = request.keyword
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
            action='SearchProjectTemplate',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/organizations/users/{user_id}/templates',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.SearchProjectTemplateResponse(),
            self.execute(params, req, runtime)
        )

    async def search_project_template_with_options_async(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.SearchProjectTemplateRequest,
        headers: dingtalkproject__1__0_models.SearchProjectTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.SearchProjectTemplateResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.keyword):
            query['keyword'] = request.keyword
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
            action='SearchProjectTemplate',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/organizations/users/{user_id}/templates',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.SearchProjectTemplateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def search_project_template(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.SearchProjectTemplateRequest,
    ) -> dingtalkproject__1__0_models.SearchProjectTemplateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.SearchProjectTemplateHeaders()
        return self.search_project_template_with_options(user_id, request, headers, runtime)

    async def search_project_template_async(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.SearchProjectTemplateRequest,
    ) -> dingtalkproject__1__0_models.SearchProjectTemplateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.SearchProjectTemplateHeaders()
        return await self.search_project_template_with_options_async(user_id, request, headers, runtime)

    def search_task_flow_with_options(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.SearchTaskFlowRequest,
        headers: dingtalkproject__1__0_models.SearchTaskFlowHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.SearchTaskFlowResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.query):
            query['query'] = request.query
        if not UtilClient.is_unset(request.taskflow_ids):
            query['taskflowIds'] = request.taskflow_ids
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
            action='SearchTaskFlow',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/projects/{project_id}/taskflows/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.SearchTaskFlowResponse(),
            self.execute(params, req, runtime)
        )

    async def search_task_flow_with_options_async(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.SearchTaskFlowRequest,
        headers: dingtalkproject__1__0_models.SearchTaskFlowHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.SearchTaskFlowResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.query):
            query['query'] = request.query
        if not UtilClient.is_unset(request.taskflow_ids):
            query['taskflowIds'] = request.taskflow_ids
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
            action='SearchTaskFlow',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/projects/{project_id}/taskflows/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.SearchTaskFlowResponse(),
            await self.execute_async(params, req, runtime)
        )

    def search_task_flow(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.SearchTaskFlowRequest,
    ) -> dingtalkproject__1__0_models.SearchTaskFlowResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.SearchTaskFlowHeaders()
        return self.search_task_flow_with_options(user_id, project_id, request, headers, runtime)

    async def search_task_flow_async(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.SearchTaskFlowRequest,
    ) -> dingtalkproject__1__0_models.SearchTaskFlowResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.SearchTaskFlowHeaders()
        return await self.search_task_flow_with_options_async(user_id, project_id, request, headers, runtime)

    def search_task_list_with_options(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.SearchTaskListRequest,
        headers: dingtalkproject__1__0_models.SearchTaskListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.SearchTaskListResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.query):
            query['query'] = request.query
        if not UtilClient.is_unset(request.task_list_ids):
            query['taskListIds'] = request.task_list_ids
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
            action='SearchTaskList',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/projects/{project_id}/taskLists/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.SearchTaskListResponse(),
            self.execute(params, req, runtime)
        )

    async def search_task_list_with_options_async(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.SearchTaskListRequest,
        headers: dingtalkproject__1__0_models.SearchTaskListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.SearchTaskListResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.query):
            query['query'] = request.query
        if not UtilClient.is_unset(request.task_list_ids):
            query['taskListIds'] = request.task_list_ids
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
            action='SearchTaskList',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/projects/{project_id}/taskLists/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.SearchTaskListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def search_task_list(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.SearchTaskListRequest,
    ) -> dingtalkproject__1__0_models.SearchTaskListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.SearchTaskListHeaders()
        return self.search_task_list_with_options(user_id, project_id, request, headers, runtime)

    async def search_task_list_async(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.SearchTaskListRequest,
    ) -> dingtalkproject__1__0_models.SearchTaskListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.SearchTaskListHeaders()
        return await self.search_task_list_with_options_async(user_id, project_id, request, headers, runtime)

    def search_taskflow_status_with_options(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.SearchTaskflowStatusRequest,
        headers: dingtalkproject__1__0_models.SearchTaskflowStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.SearchTaskflowStatusResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.query):
            query['query'] = request.query
        if not UtilClient.is_unset(request.tf_ids):
            query['tfIds'] = request.tf_ids
        if not UtilClient.is_unset(request.tfs_ids):
            query['tfsIds'] = request.tfs_ids
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
            action='SearchTaskflowStatus',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/projects/{project_id}/taskflowStatuses/search',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.SearchTaskflowStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def search_taskflow_status_with_options_async(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.SearchTaskflowStatusRequest,
        headers: dingtalkproject__1__0_models.SearchTaskflowStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.SearchTaskflowStatusResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.query):
            query['query'] = request.query
        if not UtilClient.is_unset(request.tf_ids):
            query['tfIds'] = request.tf_ids
        if not UtilClient.is_unset(request.tfs_ids):
            query['tfsIds'] = request.tfs_ids
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
            action='SearchTaskflowStatus',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/projects/{project_id}/taskflowStatuses/search',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.SearchTaskflowStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def search_taskflow_status(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.SearchTaskflowStatusRequest,
    ) -> dingtalkproject__1__0_models.SearchTaskflowStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.SearchTaskflowStatusHeaders()
        return self.search_taskflow_status_with_options(user_id, project_id, request, headers, runtime)

    async def search_taskflow_status_async(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.SearchTaskflowStatusRequest,
    ) -> dingtalkproject__1__0_models.SearchTaskflowStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.SearchTaskflowStatusHeaders()
        return await self.search_taskflow_status_with_options_async(user_id, project_id, request, headers, runtime)

    def search_user_task_with_options(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.SearchUserTaskRequest,
        headers: dingtalkproject__1__0_models.SearchUserTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.SearchUserTaskResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.role_types):
            query['roleTypes'] = request.role_types
        if not UtilClient.is_unset(request.tql):
            query['tql'] = request.tql
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
            action='SearchUserTask',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/tasks/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.SearchUserTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def search_user_task_with_options_async(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.SearchUserTaskRequest,
        headers: dingtalkproject__1__0_models.SearchUserTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.SearchUserTaskResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.role_types):
            query['roleTypes'] = request.role_types
        if not UtilClient.is_unset(request.tql):
            query['tql'] = request.tql
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
            action='SearchUserTask',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/tasks/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.SearchUserTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def search_user_task(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.SearchUserTaskRequest,
    ) -> dingtalkproject__1__0_models.SearchUserTaskResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.SearchUserTaskHeaders()
        return self.search_user_task_with_options(user_id, request, headers, runtime)

    async def search_user_task_async(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.SearchUserTaskRequest,
    ) -> dingtalkproject__1__0_models.SearchUserTaskResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.SearchUserTaskHeaders()
        return await self.search_user_task_with_options_async(user_id, request, headers, runtime)

    def suspend_project_with_options(
        self,
        project_id: str,
        user_id: str,
        headers: dingtalkproject__1__0_models.SuspendProjectHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.SuspendProjectResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='SuspendProject',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/projects/{project_id}/suspend',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.SuspendProjectResponse(),
            self.execute(params, req, runtime)
        )

    async def suspend_project_with_options_async(
        self,
        project_id: str,
        user_id: str,
        headers: dingtalkproject__1__0_models.SuspendProjectHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.SuspendProjectResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='SuspendProject',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/projects/{project_id}/suspend',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.SuspendProjectResponse(),
            await self.execute_async(params, req, runtime)
        )

    def suspend_project(
        self,
        project_id: str,
        user_id: str,
    ) -> dingtalkproject__1__0_models.SuspendProjectResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.SuspendProjectHeaders()
        return self.suspend_project_with_options(project_id, user_id, headers, runtime)

    async def suspend_project_async(
        self,
        project_id: str,
        user_id: str,
    ) -> dingtalkproject__1__0_models.SuspendProjectResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.SuspendProjectHeaders()
        return await self.suspend_project_with_options_async(project_id, user_id, headers, runtime)

    def un_suspend_project_with_options(
        self,
        project_id: str,
        user_id: str,
        headers: dingtalkproject__1__0_models.UnSuspendProjectHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UnSuspendProjectResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='UnSuspendProject',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/projects/{project_id}/unsuspend',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UnSuspendProjectResponse(),
            self.execute(params, req, runtime)
        )

    async def un_suspend_project_with_options_async(
        self,
        project_id: str,
        user_id: str,
        headers: dingtalkproject__1__0_models.UnSuspendProjectHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UnSuspendProjectResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='UnSuspendProject',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/projects/{project_id}/unsuspend',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UnSuspendProjectResponse(),
            await self.execute_async(params, req, runtime)
        )

    def un_suspend_project(
        self,
        project_id: str,
        user_id: str,
    ) -> dingtalkproject__1__0_models.UnSuspendProjectResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.UnSuspendProjectHeaders()
        return self.un_suspend_project_with_options(project_id, user_id, headers, runtime)

    async def un_suspend_project_async(
        self,
        project_id: str,
        user_id: str,
    ) -> dingtalkproject__1__0_models.UnSuspendProjectResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.UnSuspendProjectHeaders()
        return await self.un_suspend_project_with_options_async(project_id, user_id, headers, runtime)

    def update_customfield_value_with_options(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateCustomfieldValueRequest,
        headers: dingtalkproject__1__0_models.UpdateCustomfieldValueHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateCustomfieldValueResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.custom_field_id):
            body['customFieldId'] = request.custom_field_id
        if not UtilClient.is_unset(request.custom_field_name):
            body['customFieldName'] = request.custom_field_name
        if not UtilClient.is_unset(request.value):
            body['value'] = request.value
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
            action='UpdateCustomfieldValue',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/tasks/{task_id}/customFields',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateCustomfieldValueResponse(),
            self.execute(params, req, runtime)
        )

    async def update_customfield_value_with_options_async(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateCustomfieldValueRequest,
        headers: dingtalkproject__1__0_models.UpdateCustomfieldValueHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateCustomfieldValueResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.custom_field_id):
            body['customFieldId'] = request.custom_field_id
        if not UtilClient.is_unset(request.custom_field_name):
            body['customFieldName'] = request.custom_field_name
        if not UtilClient.is_unset(request.value):
            body['value'] = request.value
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
            action='UpdateCustomfieldValue',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/tasks/{task_id}/customFields',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateCustomfieldValueResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_customfield_value(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateCustomfieldValueRequest,
    ) -> dingtalkproject__1__0_models.UpdateCustomfieldValueResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.UpdateCustomfieldValueHeaders()
        return self.update_customfield_value_with_options(user_id, task_id, request, headers, runtime)

    async def update_customfield_value_async(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateCustomfieldValueRequest,
    ) -> dingtalkproject__1__0_models.UpdateCustomfieldValueResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.UpdateCustomfieldValueHeaders()
        return await self.update_customfield_value_with_options_async(user_id, task_id, request, headers, runtime)

    def update_organization_task_content_with_options(
        self,
        task_id: str,
        user_id: str,
        request: dingtalkproject__1__0_models.UpdateOrganizationTaskContentRequest,
        headers: dingtalkproject__1__0_models.UpdateOrganizationTaskContentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateOrganizationTaskContentResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.disable_activity):
            body['disableActivity'] = request.disable_activity
        if not UtilClient.is_unset(request.disable_notification):
            body['disableNotification'] = request.disable_notification
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
            action='UpdateOrganizationTaskContent',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/organizations/users/{user_id}/tasks/{task_id}/contents',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateOrganizationTaskContentResponse(),
            self.execute(params, req, runtime)
        )

    async def update_organization_task_content_with_options_async(
        self,
        task_id: str,
        user_id: str,
        request: dingtalkproject__1__0_models.UpdateOrganizationTaskContentRequest,
        headers: dingtalkproject__1__0_models.UpdateOrganizationTaskContentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateOrganizationTaskContentResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.disable_activity):
            body['disableActivity'] = request.disable_activity
        if not UtilClient.is_unset(request.disable_notification):
            body['disableNotification'] = request.disable_notification
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
            action='UpdateOrganizationTaskContent',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/organizations/users/{user_id}/tasks/{task_id}/contents',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateOrganizationTaskContentResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_organization_task_content(
        self,
        task_id: str,
        user_id: str,
        request: dingtalkproject__1__0_models.UpdateOrganizationTaskContentRequest,
    ) -> dingtalkproject__1__0_models.UpdateOrganizationTaskContentResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.UpdateOrganizationTaskContentHeaders()
        return self.update_organization_task_content_with_options(task_id, user_id, request, headers, runtime)

    async def update_organization_task_content_async(
        self,
        task_id: str,
        user_id: str,
        request: dingtalkproject__1__0_models.UpdateOrganizationTaskContentRequest,
    ) -> dingtalkproject__1__0_models.UpdateOrganizationTaskContentResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.UpdateOrganizationTaskContentHeaders()
        return await self.update_organization_task_content_with_options_async(task_id, user_id, request, headers, runtime)

    def update_organization_task_due_date_with_options(
        self,
        task_id: str,
        user_id: str,
        request: dingtalkproject__1__0_models.UpdateOrganizationTaskDueDateRequest,
        headers: dingtalkproject__1__0_models.UpdateOrganizationTaskDueDateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateOrganizationTaskDueDateResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.disable_activity):
            body['disableActivity'] = request.disable_activity
        if not UtilClient.is_unset(request.disable_notification):
            body['disableNotification'] = request.disable_notification
        if not UtilClient.is_unset(request.due_date):
            body['dueDate'] = request.due_date
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
            action='UpdateOrganizationTaskDueDate',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/organizations/users/{user_id}/tasks/{task_id}/dueDates',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateOrganizationTaskDueDateResponse(),
            self.execute(params, req, runtime)
        )

    async def update_organization_task_due_date_with_options_async(
        self,
        task_id: str,
        user_id: str,
        request: dingtalkproject__1__0_models.UpdateOrganizationTaskDueDateRequest,
        headers: dingtalkproject__1__0_models.UpdateOrganizationTaskDueDateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateOrganizationTaskDueDateResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.disable_activity):
            body['disableActivity'] = request.disable_activity
        if not UtilClient.is_unset(request.disable_notification):
            body['disableNotification'] = request.disable_notification
        if not UtilClient.is_unset(request.due_date):
            body['dueDate'] = request.due_date
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
            action='UpdateOrganizationTaskDueDate',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/organizations/users/{user_id}/tasks/{task_id}/dueDates',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateOrganizationTaskDueDateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_organization_task_due_date(
        self,
        task_id: str,
        user_id: str,
        request: dingtalkproject__1__0_models.UpdateOrganizationTaskDueDateRequest,
    ) -> dingtalkproject__1__0_models.UpdateOrganizationTaskDueDateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.UpdateOrganizationTaskDueDateHeaders()
        return self.update_organization_task_due_date_with_options(task_id, user_id, request, headers, runtime)

    async def update_organization_task_due_date_async(
        self,
        task_id: str,
        user_id: str,
        request: dingtalkproject__1__0_models.UpdateOrganizationTaskDueDateRequest,
    ) -> dingtalkproject__1__0_models.UpdateOrganizationTaskDueDateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.UpdateOrganizationTaskDueDateHeaders()
        return await self.update_organization_task_due_date_with_options_async(task_id, user_id, request, headers, runtime)

    def update_organization_task_executor_with_options(
        self,
        task_id: str,
        user_id: str,
        request: dingtalkproject__1__0_models.UpdateOrganizationTaskExecutorRequest,
        headers: dingtalkproject__1__0_models.UpdateOrganizationTaskExecutorHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateOrganizationTaskExecutorResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.disable_activity):
            body['disableActivity'] = request.disable_activity
        if not UtilClient.is_unset(request.disable_notification):
            body['disableNotification'] = request.disable_notification
        if not UtilClient.is_unset(request.executor_id):
            body['executorId'] = request.executor_id
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
            action='UpdateOrganizationTaskExecutor',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/organizations/users/{user_id}/tasks/{task_id}/executors',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateOrganizationTaskExecutorResponse(),
            self.execute(params, req, runtime)
        )

    async def update_organization_task_executor_with_options_async(
        self,
        task_id: str,
        user_id: str,
        request: dingtalkproject__1__0_models.UpdateOrganizationTaskExecutorRequest,
        headers: dingtalkproject__1__0_models.UpdateOrganizationTaskExecutorHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateOrganizationTaskExecutorResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.disable_activity):
            body['disableActivity'] = request.disable_activity
        if not UtilClient.is_unset(request.disable_notification):
            body['disableNotification'] = request.disable_notification
        if not UtilClient.is_unset(request.executor_id):
            body['executorId'] = request.executor_id
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
            action='UpdateOrganizationTaskExecutor',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/organizations/users/{user_id}/tasks/{task_id}/executors',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateOrganizationTaskExecutorResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_organization_task_executor(
        self,
        task_id: str,
        user_id: str,
        request: dingtalkproject__1__0_models.UpdateOrganizationTaskExecutorRequest,
    ) -> dingtalkproject__1__0_models.UpdateOrganizationTaskExecutorResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.UpdateOrganizationTaskExecutorHeaders()
        return self.update_organization_task_executor_with_options(task_id, user_id, request, headers, runtime)

    async def update_organization_task_executor_async(
        self,
        task_id: str,
        user_id: str,
        request: dingtalkproject__1__0_models.UpdateOrganizationTaskExecutorRequest,
    ) -> dingtalkproject__1__0_models.UpdateOrganizationTaskExecutorResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.UpdateOrganizationTaskExecutorHeaders()
        return await self.update_organization_task_executor_with_options_async(task_id, user_id, request, headers, runtime)

    def update_organization_task_involve_members_with_options(
        self,
        task_id: str,
        user_id: str,
        request: dingtalkproject__1__0_models.UpdateOrganizationTaskInvolveMembersRequest,
        headers: dingtalkproject__1__0_models.UpdateOrganizationTaskInvolveMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateOrganizationTaskInvolveMembersResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.add_involvers):
            body['addInvolvers'] = request.add_involvers
        if not UtilClient.is_unset(request.del_involvers):
            body['delInvolvers'] = request.del_involvers
        if not UtilClient.is_unset(request.disable_activity):
            body['disableActivity'] = request.disable_activity
        if not UtilClient.is_unset(request.disable_notification):
            body['disableNotification'] = request.disable_notification
        if not UtilClient.is_unset(request.involve_members):
            body['involveMembers'] = request.involve_members
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
            action='UpdateOrganizationTaskInvolveMembers',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/organizations/users/{user_id}/tasks/{task_id}/involveMembers',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateOrganizationTaskInvolveMembersResponse(),
            self.execute(params, req, runtime)
        )

    async def update_organization_task_involve_members_with_options_async(
        self,
        task_id: str,
        user_id: str,
        request: dingtalkproject__1__0_models.UpdateOrganizationTaskInvolveMembersRequest,
        headers: dingtalkproject__1__0_models.UpdateOrganizationTaskInvolveMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateOrganizationTaskInvolveMembersResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.add_involvers):
            body['addInvolvers'] = request.add_involvers
        if not UtilClient.is_unset(request.del_involvers):
            body['delInvolvers'] = request.del_involvers
        if not UtilClient.is_unset(request.disable_activity):
            body['disableActivity'] = request.disable_activity
        if not UtilClient.is_unset(request.disable_notification):
            body['disableNotification'] = request.disable_notification
        if not UtilClient.is_unset(request.involve_members):
            body['involveMembers'] = request.involve_members
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
            action='UpdateOrganizationTaskInvolveMembers',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/organizations/users/{user_id}/tasks/{task_id}/involveMembers',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateOrganizationTaskInvolveMembersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_organization_task_involve_members(
        self,
        task_id: str,
        user_id: str,
        request: dingtalkproject__1__0_models.UpdateOrganizationTaskInvolveMembersRequest,
    ) -> dingtalkproject__1__0_models.UpdateOrganizationTaskInvolveMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.UpdateOrganizationTaskInvolveMembersHeaders()
        return self.update_organization_task_involve_members_with_options(task_id, user_id, request, headers, runtime)

    async def update_organization_task_involve_members_async(
        self,
        task_id: str,
        user_id: str,
        request: dingtalkproject__1__0_models.UpdateOrganizationTaskInvolveMembersRequest,
    ) -> dingtalkproject__1__0_models.UpdateOrganizationTaskInvolveMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.UpdateOrganizationTaskInvolveMembersHeaders()
        return await self.update_organization_task_involve_members_with_options_async(task_id, user_id, request, headers, runtime)

    def update_organization_task_note_with_options(
        self,
        task_id: str,
        user_id: str,
        request: dingtalkproject__1__0_models.UpdateOrganizationTaskNoteRequest,
        headers: dingtalkproject__1__0_models.UpdateOrganizationTaskNoteHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateOrganizationTaskNoteResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.disable_activity):
            body['disableActivity'] = request.disable_activity
        if not UtilClient.is_unset(request.disable_notification):
            body['disableNotification'] = request.disable_notification
        if not UtilClient.is_unset(request.note):
            body['note'] = request.note
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
            action='UpdateOrganizationTaskNote',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/organizations/users/{user_id}/tasks/{task_id}/notes',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateOrganizationTaskNoteResponse(),
            self.execute(params, req, runtime)
        )

    async def update_organization_task_note_with_options_async(
        self,
        task_id: str,
        user_id: str,
        request: dingtalkproject__1__0_models.UpdateOrganizationTaskNoteRequest,
        headers: dingtalkproject__1__0_models.UpdateOrganizationTaskNoteHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateOrganizationTaskNoteResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.disable_activity):
            body['disableActivity'] = request.disable_activity
        if not UtilClient.is_unset(request.disable_notification):
            body['disableNotification'] = request.disable_notification
        if not UtilClient.is_unset(request.note):
            body['note'] = request.note
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
            action='UpdateOrganizationTaskNote',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/organizations/users/{user_id}/tasks/{task_id}/notes',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateOrganizationTaskNoteResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_organization_task_note(
        self,
        task_id: str,
        user_id: str,
        request: dingtalkproject__1__0_models.UpdateOrganizationTaskNoteRequest,
    ) -> dingtalkproject__1__0_models.UpdateOrganizationTaskNoteResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.UpdateOrganizationTaskNoteHeaders()
        return self.update_organization_task_note_with_options(task_id, user_id, request, headers, runtime)

    async def update_organization_task_note_async(
        self,
        task_id: str,
        user_id: str,
        request: dingtalkproject__1__0_models.UpdateOrganizationTaskNoteRequest,
    ) -> dingtalkproject__1__0_models.UpdateOrganizationTaskNoteResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.UpdateOrganizationTaskNoteHeaders()
        return await self.update_organization_task_note_with_options_async(task_id, user_id, request, headers, runtime)

    def update_organization_task_priority_with_options(
        self,
        task_id: str,
        user_id: str,
        request: dingtalkproject__1__0_models.UpdateOrganizationTaskPriorityRequest,
        headers: dingtalkproject__1__0_models.UpdateOrganizationTaskPriorityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateOrganizationTaskPriorityResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.disable_activity):
            body['disableActivity'] = request.disable_activity
        if not UtilClient.is_unset(request.disable_notification):
            body['disableNotification'] = request.disable_notification
        if not UtilClient.is_unset(request.priority):
            body['priority'] = request.priority
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
            action='UpdateOrganizationTaskPriority',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/organizations/users/{user_id}/tasks/{task_id}/priorities',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateOrganizationTaskPriorityResponse(),
            self.execute(params, req, runtime)
        )

    async def update_organization_task_priority_with_options_async(
        self,
        task_id: str,
        user_id: str,
        request: dingtalkproject__1__0_models.UpdateOrganizationTaskPriorityRequest,
        headers: dingtalkproject__1__0_models.UpdateOrganizationTaskPriorityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateOrganizationTaskPriorityResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.disable_activity):
            body['disableActivity'] = request.disable_activity
        if not UtilClient.is_unset(request.disable_notification):
            body['disableNotification'] = request.disable_notification
        if not UtilClient.is_unset(request.priority):
            body['priority'] = request.priority
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
            action='UpdateOrganizationTaskPriority',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/organizations/users/{user_id}/tasks/{task_id}/priorities',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateOrganizationTaskPriorityResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_organization_task_priority(
        self,
        task_id: str,
        user_id: str,
        request: dingtalkproject__1__0_models.UpdateOrganizationTaskPriorityRequest,
    ) -> dingtalkproject__1__0_models.UpdateOrganizationTaskPriorityResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.UpdateOrganizationTaskPriorityHeaders()
        return self.update_organization_task_priority_with_options(task_id, user_id, request, headers, runtime)

    async def update_organization_task_priority_async(
        self,
        task_id: str,
        user_id: str,
        request: dingtalkproject__1__0_models.UpdateOrganizationTaskPriorityRequest,
    ) -> dingtalkproject__1__0_models.UpdateOrganizationTaskPriorityResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.UpdateOrganizationTaskPriorityHeaders()
        return await self.update_organization_task_priority_with_options_async(task_id, user_id, request, headers, runtime)

    def update_organization_task_status_with_options(
        self,
        task_id: str,
        user_id: str,
        request: dingtalkproject__1__0_models.UpdateOrganizationTaskStatusRequest,
        headers: dingtalkproject__1__0_models.UpdateOrganizationTaskStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateOrganizationTaskStatusResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.disable_activity):
            body['disableActivity'] = request.disable_activity
        if not UtilClient.is_unset(request.disable_notification):
            body['disableNotification'] = request.disable_notification
        if not UtilClient.is_unset(request.is_done):
            body['isDone'] = request.is_done
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
            action='UpdateOrganizationTaskStatus',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/organizations/users/{user_id}/tasks/{task_id}/states',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateOrganizationTaskStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def update_organization_task_status_with_options_async(
        self,
        task_id: str,
        user_id: str,
        request: dingtalkproject__1__0_models.UpdateOrganizationTaskStatusRequest,
        headers: dingtalkproject__1__0_models.UpdateOrganizationTaskStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateOrganizationTaskStatusResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.disable_activity):
            body['disableActivity'] = request.disable_activity
        if not UtilClient.is_unset(request.disable_notification):
            body['disableNotification'] = request.disable_notification
        if not UtilClient.is_unset(request.is_done):
            body['isDone'] = request.is_done
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
            action='UpdateOrganizationTaskStatus',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/organizations/users/{user_id}/tasks/{task_id}/states',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateOrganizationTaskStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_organization_task_status(
        self,
        task_id: str,
        user_id: str,
        request: dingtalkproject__1__0_models.UpdateOrganizationTaskStatusRequest,
    ) -> dingtalkproject__1__0_models.UpdateOrganizationTaskStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.UpdateOrganizationTaskStatusHeaders()
        return self.update_organization_task_status_with_options(task_id, user_id, request, headers, runtime)

    async def update_organization_task_status_async(
        self,
        task_id: str,
        user_id: str,
        request: dingtalkproject__1__0_models.UpdateOrganizationTaskStatusRequest,
    ) -> dingtalkproject__1__0_models.UpdateOrganizationTaskStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.UpdateOrganizationTaskStatusHeaders()
        return await self.update_organization_task_status_with_options_async(task_id, user_id, request, headers, runtime)

    def update_project_group_with_options(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.UpdateProjectGroupRequest,
        headers: dingtalkproject__1__0_models.UpdateProjectGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateProjectGroupResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.add_project_group_ids):
            body['addProjectGroupIds'] = request.add_project_group_ids
        if not UtilClient.is_unset(request.del_project_group_ids):
            body['delProjectGroupIds'] = request.del_project_group_ids
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
            action='UpdateProjectGroup',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/projects/{project_id}/groups',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateProjectGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def update_project_group_with_options_async(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.UpdateProjectGroupRequest,
        headers: dingtalkproject__1__0_models.UpdateProjectGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateProjectGroupResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.add_project_group_ids):
            body['addProjectGroupIds'] = request.add_project_group_ids
        if not UtilClient.is_unset(request.del_project_group_ids):
            body['delProjectGroupIds'] = request.del_project_group_ids
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
            action='UpdateProjectGroup',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/projects/{project_id}/groups',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateProjectGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_project_group(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.UpdateProjectGroupRequest,
    ) -> dingtalkproject__1__0_models.UpdateProjectGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.UpdateProjectGroupHeaders()
        return self.update_project_group_with_options(user_id, project_id, request, headers, runtime)

    async def update_project_group_async(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.UpdateProjectGroupRequest,
    ) -> dingtalkproject__1__0_models.UpdateProjectGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.UpdateProjectGroupHeaders()
        return await self.update_project_group_with_options_async(user_id, project_id, request, headers, runtime)

    def update_task_content_with_options(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateTaskContentRequest,
        headers: dingtalkproject__1__0_models.UpdateTaskContentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateTaskContentResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
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
            action='UpdateTaskContent',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/tasks/{task_id}/contents',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateTaskContentResponse(),
            self.execute(params, req, runtime)
        )

    async def update_task_content_with_options_async(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateTaskContentRequest,
        headers: dingtalkproject__1__0_models.UpdateTaskContentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateTaskContentResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
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
            action='UpdateTaskContent',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/tasks/{task_id}/contents',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateTaskContentResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_task_content(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateTaskContentRequest,
    ) -> dingtalkproject__1__0_models.UpdateTaskContentResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.UpdateTaskContentHeaders()
        return self.update_task_content_with_options(user_id, task_id, request, headers, runtime)

    async def update_task_content_async(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateTaskContentRequest,
    ) -> dingtalkproject__1__0_models.UpdateTaskContentResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.UpdateTaskContentHeaders()
        return await self.update_task_content_with_options_async(user_id, task_id, request, headers, runtime)

    def update_task_due_date_with_options(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateTaskDueDateRequest,
        headers: dingtalkproject__1__0_models.UpdateTaskDueDateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateTaskDueDateResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.due_date):
            body['dueDate'] = request.due_date
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
            action='UpdateTaskDueDate',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/tasks/{task_id}/dueDates',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateTaskDueDateResponse(),
            self.execute(params, req, runtime)
        )

    async def update_task_due_date_with_options_async(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateTaskDueDateRequest,
        headers: dingtalkproject__1__0_models.UpdateTaskDueDateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateTaskDueDateResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.due_date):
            body['dueDate'] = request.due_date
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
            action='UpdateTaskDueDate',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/tasks/{task_id}/dueDates',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateTaskDueDateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_task_due_date(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateTaskDueDateRequest,
    ) -> dingtalkproject__1__0_models.UpdateTaskDueDateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.UpdateTaskDueDateHeaders()
        return self.update_task_due_date_with_options(user_id, task_id, request, headers, runtime)

    async def update_task_due_date_async(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateTaskDueDateRequest,
    ) -> dingtalkproject__1__0_models.UpdateTaskDueDateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.UpdateTaskDueDateHeaders()
        return await self.update_task_due_date_with_options_async(user_id, task_id, request, headers, runtime)

    def update_task_executor_with_options(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateTaskExecutorRequest,
        headers: dingtalkproject__1__0_models.UpdateTaskExecutorHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateTaskExecutorResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.executor_id):
            body['executorId'] = request.executor_id
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
            action='UpdateTaskExecutor',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/tasks/{task_id}/executors',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateTaskExecutorResponse(),
            self.execute(params, req, runtime)
        )

    async def update_task_executor_with_options_async(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateTaskExecutorRequest,
        headers: dingtalkproject__1__0_models.UpdateTaskExecutorHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateTaskExecutorResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.executor_id):
            body['executorId'] = request.executor_id
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
            action='UpdateTaskExecutor',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/tasks/{task_id}/executors',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateTaskExecutorResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_task_executor(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateTaskExecutorRequest,
    ) -> dingtalkproject__1__0_models.UpdateTaskExecutorResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.UpdateTaskExecutorHeaders()
        return self.update_task_executor_with_options(user_id, task_id, request, headers, runtime)

    async def update_task_executor_async(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateTaskExecutorRequest,
    ) -> dingtalkproject__1__0_models.UpdateTaskExecutorResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.UpdateTaskExecutorHeaders()
        return await self.update_task_executor_with_options_async(user_id, task_id, request, headers, runtime)

    def update_task_involvemembers_with_options(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateTaskInvolvemembersRequest,
        headers: dingtalkproject__1__0_models.UpdateTaskInvolvemembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateTaskInvolvemembersResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.add_involvers):
            body['addInvolvers'] = request.add_involvers
        if not UtilClient.is_unset(request.del_involvers):
            body['delInvolvers'] = request.del_involvers
        if not UtilClient.is_unset(request.involve_members):
            body['involveMembers'] = request.involve_members
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
            action='UpdateTaskInvolvemembers',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/tasks/{task_id}/involveMembers',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateTaskInvolvemembersResponse(),
            self.execute(params, req, runtime)
        )

    async def update_task_involvemembers_with_options_async(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateTaskInvolvemembersRequest,
        headers: dingtalkproject__1__0_models.UpdateTaskInvolvemembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateTaskInvolvemembersResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.add_involvers):
            body['addInvolvers'] = request.add_involvers
        if not UtilClient.is_unset(request.del_involvers):
            body['delInvolvers'] = request.del_involvers
        if not UtilClient.is_unset(request.involve_members):
            body['involveMembers'] = request.involve_members
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
            action='UpdateTaskInvolvemembers',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/tasks/{task_id}/involveMembers',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateTaskInvolvemembersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_task_involvemembers(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateTaskInvolvemembersRequest,
    ) -> dingtalkproject__1__0_models.UpdateTaskInvolvemembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.UpdateTaskInvolvemembersHeaders()
        return self.update_task_involvemembers_with_options(user_id, task_id, request, headers, runtime)

    async def update_task_involvemembers_async(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateTaskInvolvemembersRequest,
    ) -> dingtalkproject__1__0_models.UpdateTaskInvolvemembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.UpdateTaskInvolvemembersHeaders()
        return await self.update_task_involvemembers_with_options_async(user_id, task_id, request, headers, runtime)

    def update_task_note_with_options(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateTaskNoteRequest,
        headers: dingtalkproject__1__0_models.UpdateTaskNoteHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateTaskNoteResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.note):
            body['note'] = request.note
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
            action='UpdateTaskNote',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/tasks/{task_id}/notes',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateTaskNoteResponse(),
            self.execute(params, req, runtime)
        )

    async def update_task_note_with_options_async(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateTaskNoteRequest,
        headers: dingtalkproject__1__0_models.UpdateTaskNoteHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateTaskNoteResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.note):
            body['note'] = request.note
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
            action='UpdateTaskNote',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/tasks/{task_id}/notes',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateTaskNoteResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_task_note(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateTaskNoteRequest,
    ) -> dingtalkproject__1__0_models.UpdateTaskNoteResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.UpdateTaskNoteHeaders()
        return self.update_task_note_with_options(user_id, task_id, request, headers, runtime)

    async def update_task_note_async(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateTaskNoteRequest,
    ) -> dingtalkproject__1__0_models.UpdateTaskNoteResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.UpdateTaskNoteHeaders()
        return await self.update_task_note_with_options_async(user_id, task_id, request, headers, runtime)

    def update_task_priority_with_options(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateTaskPriorityRequest,
        headers: dingtalkproject__1__0_models.UpdateTaskPriorityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateTaskPriorityResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.priority):
            body['priority'] = request.priority
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
            action='UpdateTaskPriority',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/tasks/{task_id}/priorities',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateTaskPriorityResponse(),
            self.execute(params, req, runtime)
        )

    async def update_task_priority_with_options_async(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateTaskPriorityRequest,
        headers: dingtalkproject__1__0_models.UpdateTaskPriorityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateTaskPriorityResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.priority):
            body['priority'] = request.priority
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
            action='UpdateTaskPriority',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/tasks/{task_id}/priorities',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateTaskPriorityResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_task_priority(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateTaskPriorityRequest,
    ) -> dingtalkproject__1__0_models.UpdateTaskPriorityResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.UpdateTaskPriorityHeaders()
        return self.update_task_priority_with_options(user_id, task_id, request, headers, runtime)

    async def update_task_priority_async(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateTaskPriorityRequest,
    ) -> dingtalkproject__1__0_models.UpdateTaskPriorityResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.UpdateTaskPriorityHeaders()
        return await self.update_task_priority_with_options_async(user_id, task_id, request, headers, runtime)

    def update_task_stage_with_options(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateTaskStageRequest,
        headers: dingtalkproject__1__0_models.UpdateTaskStageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateTaskStageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.task_stage_id):
            body['taskStageId'] = request.task_stage_id
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
            action='UpdateTaskStage',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/tasks/{task_id}/stages',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateTaskStageResponse(),
            self.execute(params, req, runtime)
        )

    async def update_task_stage_with_options_async(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateTaskStageRequest,
        headers: dingtalkproject__1__0_models.UpdateTaskStageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateTaskStageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.task_stage_id):
            body['taskStageId'] = request.task_stage_id
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
            action='UpdateTaskStage',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/tasks/{task_id}/stages',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateTaskStageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_task_stage(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateTaskStageRequest,
    ) -> dingtalkproject__1__0_models.UpdateTaskStageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.UpdateTaskStageHeaders()
        return self.update_task_stage_with_options(user_id, task_id, request, headers, runtime)

    async def update_task_stage_async(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateTaskStageRequest,
    ) -> dingtalkproject__1__0_models.UpdateTaskStageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.UpdateTaskStageHeaders()
        return await self.update_task_stage_with_options_async(user_id, task_id, request, headers, runtime)

    def update_task_startdate_with_options(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateTaskStartdateRequest,
        headers: dingtalkproject__1__0_models.UpdateTaskStartdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateTaskStartdateResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.start_date):
            body['startDate'] = request.start_date
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
            action='UpdateTaskStartdate',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/tasks/{task_id}/startDates',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateTaskStartdateResponse(),
            self.execute(params, req, runtime)
        )

    async def update_task_startdate_with_options_async(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateTaskStartdateRequest,
        headers: dingtalkproject__1__0_models.UpdateTaskStartdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateTaskStartdateResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.start_date):
            body['startDate'] = request.start_date
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
            action='UpdateTaskStartdate',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/tasks/{task_id}/startDates',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateTaskStartdateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_task_startdate(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateTaskStartdateRequest,
    ) -> dingtalkproject__1__0_models.UpdateTaskStartdateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.UpdateTaskStartdateHeaders()
        return self.update_task_startdate_with_options(user_id, task_id, request, headers, runtime)

    async def update_task_startdate_async(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateTaskStartdateRequest,
    ) -> dingtalkproject__1__0_models.UpdateTaskStartdateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.UpdateTaskStartdateHeaders()
        return await self.update_task_startdate_with_options_async(user_id, task_id, request, headers, runtime)

    def update_task_taskflowstatus_with_options(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateTaskTaskflowstatusRequest,
        headers: dingtalkproject__1__0_models.UpdateTaskTaskflowstatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateTaskTaskflowstatusResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.taskflow_status_id):
            body['taskflowStatusId'] = request.taskflow_status_id
        if not UtilClient.is_unset(request.taskflow_status_update_note):
            body['taskflowStatusUpdateNote'] = request.taskflow_status_update_note
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
            action='UpdateTaskTaskflowstatus',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/tasks/{task_id}/taskflowStatuses',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateTaskTaskflowstatusResponse(),
            self.execute(params, req, runtime)
        )

    async def update_task_taskflowstatus_with_options_async(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateTaskTaskflowstatusRequest,
        headers: dingtalkproject__1__0_models.UpdateTaskTaskflowstatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateTaskTaskflowstatusResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.taskflow_status_id):
            body['taskflowStatusId'] = request.taskflow_status_id
        if not UtilClient.is_unset(request.taskflow_status_update_note):
            body['taskflowStatusUpdateNote'] = request.taskflow_status_update_note
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
            action='UpdateTaskTaskflowstatus',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/tasks/{task_id}/taskflowStatuses',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateTaskTaskflowstatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_task_taskflowstatus(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateTaskTaskflowstatusRequest,
    ) -> dingtalkproject__1__0_models.UpdateTaskTaskflowstatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.UpdateTaskTaskflowstatusHeaders()
        return self.update_task_taskflowstatus_with_options(user_id, task_id, request, headers, runtime)

    async def update_task_taskflowstatus_async(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateTaskTaskflowstatusRequest,
    ) -> dingtalkproject__1__0_models.UpdateTaskTaskflowstatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.UpdateTaskTaskflowstatusHeaders()
        return await self.update_task_taskflowstatus_with_options_async(user_id, task_id, request, headers, runtime)

    def update_work_time_approve_with_options(
        self,
        user_id: str,
        approve_open_id: str,
        request: dingtalkproject__1__0_models.UpdateWorkTimeApproveRequest,
        headers: dingtalkproject__1__0_models.UpdateWorkTimeApproveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateWorkTimeApproveResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.finish_time):
            body['finishTime'] = request.finish_time
        if not UtilClient.is_unset(request.instance_id):
            body['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.submit_time):
            body['submitTime'] = request.submit_time
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.url):
            body['url'] = request.url
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
            action='UpdateWorkTimeApprove',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/workTimes/approvals/{approve_open_id}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateWorkTimeApproveResponse(),
            self.execute(params, req, runtime)
        )

    async def update_work_time_approve_with_options_async(
        self,
        user_id: str,
        approve_open_id: str,
        request: dingtalkproject__1__0_models.UpdateWorkTimeApproveRequest,
        headers: dingtalkproject__1__0_models.UpdateWorkTimeApproveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateWorkTimeApproveResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.finish_time):
            body['finishTime'] = request.finish_time
        if not UtilClient.is_unset(request.instance_id):
            body['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.submit_time):
            body['submitTime'] = request.submit_time
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.url):
            body['url'] = request.url
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
            action='UpdateWorkTimeApprove',
            version='project_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/project/users/{user_id}/workTimes/approvals/{approve_open_id}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateWorkTimeApproveResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_work_time_approve(
        self,
        user_id: str,
        approve_open_id: str,
        request: dingtalkproject__1__0_models.UpdateWorkTimeApproveRequest,
    ) -> dingtalkproject__1__0_models.UpdateWorkTimeApproveResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.UpdateWorkTimeApproveHeaders()
        return self.update_work_time_approve_with_options(user_id, approve_open_id, request, headers, runtime)

    async def update_work_time_approve_async(
        self,
        user_id: str,
        approve_open_id: str,
        request: dingtalkproject__1__0_models.UpdateWorkTimeApproveRequest,
    ) -> dingtalkproject__1__0_models.UpdateWorkTimeApproveResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.UpdateWorkTimeApproveHeaders()
        return await self.update_work_time_approve_with_options_async(user_id, approve_open_id, request, headers, runtime)
