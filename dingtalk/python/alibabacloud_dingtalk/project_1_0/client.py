# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.project_1_0 import models as dingtalkproject__1__0_models
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
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

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

    def add_project_member_with_options(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.AddProjectMemberRequest,
        headers: dingtalkproject__1__0_models.AddProjectMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.AddProjectMemberResponse:
        UtilClient.validate_model(request)
        user_id = OpenApiUtilClient.get_encode_param(user_id)
        project_id = OpenApiUtilClient.get_encode_param(project_id)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.AddProjectMemberResponse(),
            self.do_roarequest('AddProjectMember', 'project_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/project/users/{user_id}/projects/{project_id}/members', 'json', req, runtime)
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
        user_id = OpenApiUtilClient.get_encode_param(user_id)
        project_id = OpenApiUtilClient.get_encode_param(project_id)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.AddProjectMemberResponse(),
            await self.do_roarequest_async('AddProjectMember', 'project_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/project/users/{user_id}/projects/{project_id}/members', 'json', req, runtime)
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

    def create_organization_task_with_options(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.CreateOrganizationTaskRequest,
        headers: dingtalkproject__1__0_models.CreateOrganizationTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.CreateOrganizationTaskResponse:
        UtilClient.validate_model(request)
        user_id = OpenApiUtilClient.get_encode_param(user_id)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.CreateOrganizationTaskResponse(),
            self.do_roarequest('CreateOrganizationTask', 'project_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/project/organizations/users/{user_id}/tasks', 'json', req, runtime)
        )

    async def create_organization_task_with_options_async(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.CreateOrganizationTaskRequest,
        headers: dingtalkproject__1__0_models.CreateOrganizationTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.CreateOrganizationTaskResponse:
        UtilClient.validate_model(request)
        user_id = OpenApiUtilClient.get_encode_param(user_id)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.CreateOrganizationTaskResponse(),
            await self.do_roarequest_async('CreateOrganizationTask', 'project_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/project/organizations/users/{user_id}/tasks', 'json', req, runtime)
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

    def create_project_by_template_with_options(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.CreateProjectByTemplateRequest,
        headers: dingtalkproject__1__0_models.CreateProjectByTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.CreateProjectByTemplateResponse:
        UtilClient.validate_model(request)
        user_id = OpenApiUtilClient.get_encode_param(user_id)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.CreateProjectByTemplateResponse(),
            self.do_roarequest('CreateProjectByTemplate', 'project_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/project/users/{user_id}/templates/projects', 'json', req, runtime)
        )

    async def create_project_by_template_with_options_async(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.CreateProjectByTemplateRequest,
        headers: dingtalkproject__1__0_models.CreateProjectByTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.CreateProjectByTemplateResponse:
        UtilClient.validate_model(request)
        user_id = OpenApiUtilClient.get_encode_param(user_id)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.CreateProjectByTemplateResponse(),
            await self.do_roarequest_async('CreateProjectByTemplate', 'project_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/project/users/{user_id}/templates/projects', 'json', req, runtime)
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

    def create_task_with_options(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.CreateTaskRequest,
        headers: dingtalkproject__1__0_models.CreateTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.CreateTaskResponse:
        UtilClient.validate_model(request)
        user_id = OpenApiUtilClient.get_encode_param(user_id)
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
        if not UtilClient.is_unset(request.priority):
            body['priority'] = request.priority
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.CreateTaskResponse(),
            self.do_roarequest('CreateTask', 'project_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/project/users/{user_id}/tasks', 'json', req, runtime)
        )

    async def create_task_with_options_async(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.CreateTaskRequest,
        headers: dingtalkproject__1__0_models.CreateTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.CreateTaskResponse:
        UtilClient.validate_model(request)
        user_id = OpenApiUtilClient.get_encode_param(user_id)
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
        if not UtilClient.is_unset(request.priority):
            body['priority'] = request.priority
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.CreateTaskResponse(),
            await self.do_roarequest_async('CreateTask', 'project_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/project/users/{user_id}/tasks', 'json', req, runtime)
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

    def create_task_object_link_with_options(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.CreateTaskObjectLinkRequest,
        headers: dingtalkproject__1__0_models.CreateTaskObjectLinkHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.CreateTaskObjectLinkResponse:
        UtilClient.validate_model(request)
        user_id = OpenApiUtilClient.get_encode_param(user_id)
        task_id = OpenApiUtilClient.get_encode_param(task_id)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.CreateTaskObjectLinkResponse(),
            self.do_roarequest('CreateTaskObjectLink', 'project_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/project/users/{user_id}/tasks/{task_id}/objectLinks', 'json', req, runtime)
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
        user_id = OpenApiUtilClient.get_encode_param(user_id)
        task_id = OpenApiUtilClient.get_encode_param(task_id)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.CreateTaskObjectLinkResponse(),
            await self.do_roarequest_async('CreateTaskObjectLink', 'project_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/project/users/{user_id}/tasks/{task_id}/objectLinks', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetDeptsByOrgIdResponse(),
            self.do_roarequest('GetDeptsByOrgId', 'project_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/project/orgs/depts', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetDeptsByOrgIdResponse(),
            await self.do_roarequest_async('GetDeptsByOrgId', 'project_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/project/orgs/depts', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetEmpsByOrgIdResponse(),
            self.do_roarequest('GetEmpsByOrgId', 'project_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/project/orgs/employees', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetEmpsByOrgIdResponse(),
            await self.do_roarequest_async('GetEmpsByOrgId', 'project_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/project/orgs/employees', 'json', req, runtime)
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

    def get_organizatio_task_by_ids_with_options(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.GetOrganizatioTaskByIdsRequest,
        headers: dingtalkproject__1__0_models.GetOrganizatioTaskByIdsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.GetOrganizatioTaskByIdsResponse:
        UtilClient.validate_model(request)
        user_id = OpenApiUtilClient.get_encode_param(user_id)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetOrganizatioTaskByIdsResponse(),
            self.do_roarequest('GetOrganizatioTaskByIds', 'project_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/project/organizations/users/{user_id}/tasks', 'json', req, runtime)
        )

    async def get_organizatio_task_by_ids_with_options_async(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.GetOrganizatioTaskByIdsRequest,
        headers: dingtalkproject__1__0_models.GetOrganizatioTaskByIdsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.GetOrganizatioTaskByIdsResponse:
        UtilClient.validate_model(request)
        user_id = OpenApiUtilClient.get_encode_param(user_id)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetOrganizatioTaskByIdsResponse(),
            await self.do_roarequest_async('GetOrganizatioTaskByIds', 'project_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/project/organizations/users/{user_id}/tasks', 'json', req, runtime)
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

    def get_organization_priority_list_with_options(
        self,
        user_id: str,
        headers: dingtalkproject__1__0_models.GetOrganizationPriorityListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.GetOrganizationPriorityListResponse:
        user_id = OpenApiUtilClient.get_encode_param(user_id)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetOrganizationPriorityListResponse(),
            self.do_roarequest('GetOrganizationPriorityList', 'project_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/project/organizations/users/{user_id}/priorities', 'json', req, runtime)
        )

    async def get_organization_priority_list_with_options_async(
        self,
        user_id: str,
        headers: dingtalkproject__1__0_models.GetOrganizationPriorityListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.GetOrganizationPriorityListResponse:
        user_id = OpenApiUtilClient.get_encode_param(user_id)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetOrganizationPriorityListResponse(),
            await self.do_roarequest_async('GetOrganizationPriorityList', 'project_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/project/organizations/users/{user_id}/priorities', 'json', req, runtime)
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

    def get_organization_task_with_options(
        self,
        task_id: str,
        user_id: str,
        headers: dingtalkproject__1__0_models.GetOrganizationTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.GetOrganizationTaskResponse:
        task_id = OpenApiUtilClient.get_encode_param(task_id)
        user_id = OpenApiUtilClient.get_encode_param(user_id)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetOrganizationTaskResponse(),
            self.do_roarequest('GetOrganizationTask', 'project_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/project/organizations/users/{user_id}/tasks/{task_id}', 'json', req, runtime)
        )

    async def get_organization_task_with_options_async(
        self,
        task_id: str,
        user_id: str,
        headers: dingtalkproject__1__0_models.GetOrganizationTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.GetOrganizationTaskResponse:
        task_id = OpenApiUtilClient.get_encode_param(task_id)
        user_id = OpenApiUtilClient.get_encode_param(user_id)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetOrganizationTaskResponse(),
            await self.do_roarequest_async('GetOrganizationTask', 'project_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/project/organizations/users/{user_id}/tasks/{task_id}', 'json', req, runtime)
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

    def get_project_group_with_options(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.GetProjectGroupRequest,
        headers: dingtalkproject__1__0_models.GetProjectGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.GetProjectGroupResponse:
        UtilClient.validate_model(request)
        user_id = OpenApiUtilClient.get_encode_param(user_id)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetProjectGroupResponse(),
            self.do_roarequest('GetProjectGroup', 'project_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/project/organizations/users/{user_id}/groups', 'json', req, runtime)
        )

    async def get_project_group_with_options_async(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.GetProjectGroupRequest,
        headers: dingtalkproject__1__0_models.GetProjectGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.GetProjectGroupResponse:
        UtilClient.validate_model(request)
        user_id = OpenApiUtilClient.get_encode_param(user_id)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetProjectGroupResponse(),
            await self.do_roarequest_async('GetProjectGroup', 'project_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/project/organizations/users/{user_id}/groups', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetTbOrgIdByDingOrgIdResponse(),
            self.do_roarequest('GetTbOrgIdByDingOrgId', 'project_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/project/teambition/organizations', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetTbOrgIdByDingOrgIdResponse(),
            await self.do_roarequest_async('GetTbOrgIdByDingOrgId', 'project_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/project/teambition/organizations', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetTbProjectGrayResponse(),
            self.do_roarequest('GetTbProjectGray', 'project_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/project/projects/gray', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetTbProjectGrayResponse(),
            await self.do_roarequest_async('GetTbProjectGray', 'project_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/project/projects/gray', 'json', req, runtime)
        )

    def get_tb_project_source(self) -> dingtalkproject__1__0_models.GetTbProjectSourceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.GetTbProjectSourceHeaders()
        return self.get_tb_project_source_with_options(headers, runtime)

    async def get_tb_project_source_async(self) -> dingtalkproject__1__0_models.GetTbProjectSourceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkproject__1__0_models.GetTbProjectSourceHeaders()
        return await self.get_tb_project_source_with_options_async(headers, runtime)

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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetTbProjectSourceResponse(),
            self.do_roarequest('GetTbProjectSource', 'project_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/project/projects/source', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetTbProjectSourceResponse(),
            await self.do_roarequest_async('GetTbProjectSource', 'project_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/project/projects/source', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetTbUserIdByStaffIdResponse(),
            self.do_roarequest('GetTbUserIdByStaffId', 'project_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/project/teambition/users', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.GetTbUserIdByStaffIdResponse(),
            await self.do_roarequest_async('GetTbUserIdByStaffId', 'project_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/project/teambition/users', 'json', req, runtime)
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

    def search_project_template_with_options(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.SearchProjectTemplateRequest,
        headers: dingtalkproject__1__0_models.SearchProjectTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.SearchProjectTemplateResponse:
        UtilClient.validate_model(request)
        user_id = OpenApiUtilClient.get_encode_param(user_id)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.SearchProjectTemplateResponse(),
            self.do_roarequest('SearchProjectTemplate', 'project_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/project/organizations/users/{user_id}/templates', 'json', req, runtime)
        )

    async def search_project_template_with_options_async(
        self,
        user_id: str,
        request: dingtalkproject__1__0_models.SearchProjectTemplateRequest,
        headers: dingtalkproject__1__0_models.SearchProjectTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.SearchProjectTemplateResponse:
        UtilClient.validate_model(request)
        user_id = OpenApiUtilClient.get_encode_param(user_id)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.SearchProjectTemplateResponse(),
            await self.do_roarequest_async('SearchProjectTemplate', 'project_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/project/organizations/users/{user_id}/templates', 'json', req, runtime)
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

    def update_customfield_value_with_options(
        self,
        user_id: str,
        task_id: str,
        request: dingtalkproject__1__0_models.UpdateCustomfieldValueRequest,
        headers: dingtalkproject__1__0_models.UpdateCustomfieldValueHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateCustomfieldValueResponse:
        UtilClient.validate_model(request)
        user_id = OpenApiUtilClient.get_encode_param(user_id)
        task_id = OpenApiUtilClient.get_encode_param(task_id)
        body = {}
        if not UtilClient.is_unset(request.customfield_id):
            body['customfieldId'] = request.customfield_id
        if not UtilClient.is_unset(request.customfield_name):
            body['customfieldName'] = request.customfield_name
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateCustomfieldValueResponse(),
            self.do_roarequest('UpdateCustomfieldValue', 'project_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/project/users/{user_id}/tasks/{task_id}/customFields', 'json', req, runtime)
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
        user_id = OpenApiUtilClient.get_encode_param(user_id)
        task_id = OpenApiUtilClient.get_encode_param(task_id)
        body = {}
        if not UtilClient.is_unset(request.customfield_id):
            body['customfieldId'] = request.customfield_id
        if not UtilClient.is_unset(request.customfield_name):
            body['customfieldName'] = request.customfield_name
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateCustomfieldValueResponse(),
            await self.do_roarequest_async('UpdateCustomfieldValue', 'project_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/project/users/{user_id}/tasks/{task_id}/customFields', 'json', req, runtime)
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

    def update_organization_task_content_with_options(
        self,
        task_id: str,
        user_id: str,
        request: dingtalkproject__1__0_models.UpdateOrganizationTaskContentRequest,
        headers: dingtalkproject__1__0_models.UpdateOrganizationTaskContentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateOrganizationTaskContentResponse:
        UtilClient.validate_model(request)
        task_id = OpenApiUtilClient.get_encode_param(task_id)
        user_id = OpenApiUtilClient.get_encode_param(user_id)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateOrganizationTaskContentResponse(),
            self.do_roarequest('UpdateOrganizationTaskContent', 'project_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/project/organizations/users/{user_id}/tasks/{task_id}/contents', 'json', req, runtime)
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
        task_id = OpenApiUtilClient.get_encode_param(task_id)
        user_id = OpenApiUtilClient.get_encode_param(user_id)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateOrganizationTaskContentResponse(),
            await self.do_roarequest_async('UpdateOrganizationTaskContent', 'project_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/project/organizations/users/{user_id}/tasks/{task_id}/contents', 'json', req, runtime)
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

    def update_organization_task_due_date_with_options(
        self,
        task_id: str,
        user_id: str,
        request: dingtalkproject__1__0_models.UpdateOrganizationTaskDueDateRequest,
        headers: dingtalkproject__1__0_models.UpdateOrganizationTaskDueDateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateOrganizationTaskDueDateResponse:
        UtilClient.validate_model(request)
        task_id = OpenApiUtilClient.get_encode_param(task_id)
        user_id = OpenApiUtilClient.get_encode_param(user_id)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateOrganizationTaskDueDateResponse(),
            self.do_roarequest('UpdateOrganizationTaskDueDate', 'project_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/project/organizations/users/{user_id}/tasks/{task_id}/dueDates', 'json', req, runtime)
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
        task_id = OpenApiUtilClient.get_encode_param(task_id)
        user_id = OpenApiUtilClient.get_encode_param(user_id)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateOrganizationTaskDueDateResponse(),
            await self.do_roarequest_async('UpdateOrganizationTaskDueDate', 'project_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/project/organizations/users/{user_id}/tasks/{task_id}/dueDates', 'json', req, runtime)
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

    def update_organization_task_executor_with_options(
        self,
        task_id: str,
        user_id: str,
        request: dingtalkproject__1__0_models.UpdateOrganizationTaskExecutorRequest,
        headers: dingtalkproject__1__0_models.UpdateOrganizationTaskExecutorHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateOrganizationTaskExecutorResponse:
        UtilClient.validate_model(request)
        task_id = OpenApiUtilClient.get_encode_param(task_id)
        user_id = OpenApiUtilClient.get_encode_param(user_id)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateOrganizationTaskExecutorResponse(),
            self.do_roarequest('UpdateOrganizationTaskExecutor', 'project_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/project/organizations/users/{user_id}/tasks/{task_id}/executors', 'json', req, runtime)
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
        task_id = OpenApiUtilClient.get_encode_param(task_id)
        user_id = OpenApiUtilClient.get_encode_param(user_id)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateOrganizationTaskExecutorResponse(),
            await self.do_roarequest_async('UpdateOrganizationTaskExecutor', 'project_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/project/organizations/users/{user_id}/tasks/{task_id}/executors', 'json', req, runtime)
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

    def update_organization_task_involve_members_with_options(
        self,
        task_id: str,
        user_id: str,
        request: dingtalkproject__1__0_models.UpdateOrganizationTaskInvolveMembersRequest,
        headers: dingtalkproject__1__0_models.UpdateOrganizationTaskInvolveMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateOrganizationTaskInvolveMembersResponse:
        UtilClient.validate_model(request)
        task_id = OpenApiUtilClient.get_encode_param(task_id)
        user_id = OpenApiUtilClient.get_encode_param(user_id)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateOrganizationTaskInvolveMembersResponse(),
            self.do_roarequest('UpdateOrganizationTaskInvolveMembers', 'project_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/project/organizations/users/{user_id}/tasks/{task_id}/involveMembers', 'json', req, runtime)
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
        task_id = OpenApiUtilClient.get_encode_param(task_id)
        user_id = OpenApiUtilClient.get_encode_param(user_id)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateOrganizationTaskInvolveMembersResponse(),
            await self.do_roarequest_async('UpdateOrganizationTaskInvolveMembers', 'project_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/project/organizations/users/{user_id}/tasks/{task_id}/involveMembers', 'json', req, runtime)
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

    def update_organization_task_note_with_options(
        self,
        task_id: str,
        user_id: str,
        request: dingtalkproject__1__0_models.UpdateOrganizationTaskNoteRequest,
        headers: dingtalkproject__1__0_models.UpdateOrganizationTaskNoteHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateOrganizationTaskNoteResponse:
        UtilClient.validate_model(request)
        task_id = OpenApiUtilClient.get_encode_param(task_id)
        user_id = OpenApiUtilClient.get_encode_param(user_id)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateOrganizationTaskNoteResponse(),
            self.do_roarequest('UpdateOrganizationTaskNote', 'project_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/project/organizations/users/{user_id}/tasks/{task_id}/notes', 'json', req, runtime)
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
        task_id = OpenApiUtilClient.get_encode_param(task_id)
        user_id = OpenApiUtilClient.get_encode_param(user_id)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateOrganizationTaskNoteResponse(),
            await self.do_roarequest_async('UpdateOrganizationTaskNote', 'project_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/project/organizations/users/{user_id}/tasks/{task_id}/notes', 'json', req, runtime)
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

    def update_organization_task_priority_with_options(
        self,
        task_id: str,
        user_id: str,
        request: dingtalkproject__1__0_models.UpdateOrganizationTaskPriorityRequest,
        headers: dingtalkproject__1__0_models.UpdateOrganizationTaskPriorityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateOrganizationTaskPriorityResponse:
        UtilClient.validate_model(request)
        task_id = OpenApiUtilClient.get_encode_param(task_id)
        user_id = OpenApiUtilClient.get_encode_param(user_id)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateOrganizationTaskPriorityResponse(),
            self.do_roarequest('UpdateOrganizationTaskPriority', 'project_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/project/organizations/users/{user_id}/tasks/{task_id}/priorities', 'json', req, runtime)
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
        task_id = OpenApiUtilClient.get_encode_param(task_id)
        user_id = OpenApiUtilClient.get_encode_param(user_id)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateOrganizationTaskPriorityResponse(),
            await self.do_roarequest_async('UpdateOrganizationTaskPriority', 'project_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/project/organizations/users/{user_id}/tasks/{task_id}/priorities', 'json', req, runtime)
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

    def update_organization_task_status_with_options(
        self,
        task_id: str,
        user_id: str,
        request: dingtalkproject__1__0_models.UpdateOrganizationTaskStatusRequest,
        headers: dingtalkproject__1__0_models.UpdateOrganizationTaskStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateOrganizationTaskStatusResponse:
        UtilClient.validate_model(request)
        task_id = OpenApiUtilClient.get_encode_param(task_id)
        user_id = OpenApiUtilClient.get_encode_param(user_id)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateOrganizationTaskStatusResponse(),
            self.do_roarequest('UpdateOrganizationTaskStatus', 'project_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/project/organizations/users/{user_id}/tasks/{task_id}/states', 'json', req, runtime)
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
        task_id = OpenApiUtilClient.get_encode_param(task_id)
        user_id = OpenApiUtilClient.get_encode_param(user_id)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateOrganizationTaskStatusResponse(),
            await self.do_roarequest_async('UpdateOrganizationTaskStatus', 'project_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/project/organizations/users/{user_id}/tasks/{task_id}/states', 'json', req, runtime)
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

    def update_project_group_with_options(
        self,
        user_id: str,
        project_id: str,
        request: dingtalkproject__1__0_models.UpdateProjectGroupRequest,
        headers: dingtalkproject__1__0_models.UpdateProjectGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkproject__1__0_models.UpdateProjectGroupResponse:
        UtilClient.validate_model(request)
        user_id = OpenApiUtilClient.get_encode_param(user_id)
        project_id = OpenApiUtilClient.get_encode_param(project_id)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateProjectGroupResponse(),
            self.do_roarequest('UpdateProjectGroup', 'project_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/project/users/{user_id}/projects/{project_id}/groups', 'json', req, runtime)
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
        user_id = OpenApiUtilClient.get_encode_param(user_id)
        project_id = OpenApiUtilClient.get_encode_param(project_id)
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
        return TeaCore.from_map(
            dingtalkproject__1__0_models.UpdateProjectGroupResponse(),
            await self.do_roarequest_async('UpdateProjectGroup', 'project_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/project/users/{user_id}/projects/{project_id}/groups', 'json', req, runtime)
        )
