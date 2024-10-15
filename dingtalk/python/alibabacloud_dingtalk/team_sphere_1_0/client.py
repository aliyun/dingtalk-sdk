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
        if not UtilClient.is_unset(request.parent_task_id):
            query['parentTaskId'] = request.parent_task_id
        if not UtilClient.is_unset(request.short_ids):
            query['shortIds'] = request.short_ids
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
        if not UtilClient.is_unset(request.parent_task_id):
            query['parentTaskId'] = request.parent_task_id
        if not UtilClient.is_unset(request.short_ids):
            query['shortIds'] = request.short_ids
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
