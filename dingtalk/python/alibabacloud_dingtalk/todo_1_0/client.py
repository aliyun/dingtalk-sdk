# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.todo_1_0 import models as dingtalktodo__1__0_models
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

    def count_todo_tasks_with_options(
        self,
        union_id: str,
        request: dingtalktodo__1__0_models.CountTodoTasksRequest,
        headers: dingtalktodo__1__0_models.CountTodoTasksHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.CountTodoTasksResponse:
        """
        @summary 查询用户待办计数
        
        @param request: CountTodoTasksRequest
        @param headers: CountTodoTasksHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CountTodoTasksResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.from_due_time):
            body['fromDueTime'] = request.from_due_time
        if not UtilClient.is_unset(request.is_done):
            body['isDone'] = request.is_done
        if not UtilClient.is_unset(request.is_recycled):
            body['isRecycled'] = request.is_recycled
        if not UtilClient.is_unset(request.role_types):
            body['roleTypes'] = request.role_types
        if not UtilClient.is_unset(request.to_due_time):
            body['toDueTime'] = request.to_due_time
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
            action='CountTodoTasks',
            version='todo_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todo/users/{union_id}/tasks/count',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.CountTodoTasksResponse(),
            self.execute(params, req, runtime)
        )

    async def count_todo_tasks_with_options_async(
        self,
        union_id: str,
        request: dingtalktodo__1__0_models.CountTodoTasksRequest,
        headers: dingtalktodo__1__0_models.CountTodoTasksHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.CountTodoTasksResponse:
        """
        @summary 查询用户待办计数
        
        @param request: CountTodoTasksRequest
        @param headers: CountTodoTasksHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CountTodoTasksResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.from_due_time):
            body['fromDueTime'] = request.from_due_time
        if not UtilClient.is_unset(request.is_done):
            body['isDone'] = request.is_done
        if not UtilClient.is_unset(request.is_recycled):
            body['isRecycled'] = request.is_recycled
        if not UtilClient.is_unset(request.role_types):
            body['roleTypes'] = request.role_types
        if not UtilClient.is_unset(request.to_due_time):
            body['toDueTime'] = request.to_due_time
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
            action='CountTodoTasks',
            version='todo_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todo/users/{union_id}/tasks/count',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.CountTodoTasksResponse(),
            await self.execute_async(params, req, runtime)
        )

    def count_todo_tasks(
        self,
        union_id: str,
        request: dingtalktodo__1__0_models.CountTodoTasksRequest,
    ) -> dingtalktodo__1__0_models.CountTodoTasksResponse:
        """
        @summary 查询用户待办计数
        
        @param request: CountTodoTasksRequest
        @return: CountTodoTasksResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.CountTodoTasksHeaders()
        return self.count_todo_tasks_with_options(union_id, request, headers, runtime)

    async def count_todo_tasks_async(
        self,
        union_id: str,
        request: dingtalktodo__1__0_models.CountTodoTasksRequest,
    ) -> dingtalktodo__1__0_models.CountTodoTasksResponse:
        """
        @summary 查询用户待办计数
        
        @param request: CountTodoTasksRequest
        @return: CountTodoTasksResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.CountTodoTasksHeaders()
        return await self.count_todo_tasks_with_options_async(union_id, request, headers, runtime)

    def create_personal_todo_task_with_options(
        self,
        request: dingtalktodo__1__0_models.CreatePersonalTodoTaskRequest,
        headers: dingtalktodo__1__0_models.CreatePersonalTodoTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.CreatePersonalTodoTaskResponse:
        """
        @summary 以用户个人身份创建个人待办
        
        @param request: CreatePersonalTodoTaskRequest
        @param headers: CreatePersonalTodoTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreatePersonalTodoTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.due_time):
            body['dueTime'] = request.due_time
        if not UtilClient.is_unset(request.executor_ids):
            body['executorIds'] = request.executor_ids
        if not UtilClient.is_unset(request.notify_configs):
            body['notifyConfigs'] = request.notify_configs
        if not UtilClient.is_unset(request.participant_ids):
            body['participantIds'] = request.participant_ids
        if not UtilClient.is_unset(request.reminder_time_stamp):
            body['reminderTimeStamp'] = request.reminder_time_stamp
        if not UtilClient.is_unset(request.subject):
            body['subject'] = request.subject
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
            action='CreatePersonalTodoTask',
            version='todo_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todo/users/me/personalTasks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.CreatePersonalTodoTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def create_personal_todo_task_with_options_async(
        self,
        request: dingtalktodo__1__0_models.CreatePersonalTodoTaskRequest,
        headers: dingtalktodo__1__0_models.CreatePersonalTodoTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.CreatePersonalTodoTaskResponse:
        """
        @summary 以用户个人身份创建个人待办
        
        @param request: CreatePersonalTodoTaskRequest
        @param headers: CreatePersonalTodoTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreatePersonalTodoTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.due_time):
            body['dueTime'] = request.due_time
        if not UtilClient.is_unset(request.executor_ids):
            body['executorIds'] = request.executor_ids
        if not UtilClient.is_unset(request.notify_configs):
            body['notifyConfigs'] = request.notify_configs
        if not UtilClient.is_unset(request.participant_ids):
            body['participantIds'] = request.participant_ids
        if not UtilClient.is_unset(request.reminder_time_stamp):
            body['reminderTimeStamp'] = request.reminder_time_stamp
        if not UtilClient.is_unset(request.subject):
            body['subject'] = request.subject
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
            action='CreatePersonalTodoTask',
            version='todo_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todo/users/me/personalTasks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.CreatePersonalTodoTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_personal_todo_task(
        self,
        request: dingtalktodo__1__0_models.CreatePersonalTodoTaskRequest,
    ) -> dingtalktodo__1__0_models.CreatePersonalTodoTaskResponse:
        """
        @summary 以用户个人身份创建个人待办
        
        @param request: CreatePersonalTodoTaskRequest
        @return: CreatePersonalTodoTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.CreatePersonalTodoTaskHeaders()
        return self.create_personal_todo_task_with_options(request, headers, runtime)

    async def create_personal_todo_task_async(
        self,
        request: dingtalktodo__1__0_models.CreatePersonalTodoTaskRequest,
    ) -> dingtalktodo__1__0_models.CreatePersonalTodoTaskResponse:
        """
        @summary 以用户个人身份创建个人待办
        
        @param request: CreatePersonalTodoTaskRequest
        @return: CreatePersonalTodoTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.CreatePersonalTodoTaskHeaders()
        return await self.create_personal_todo_task_with_options_async(request, headers, runtime)

    def create_todo_task_with_options(
        self,
        union_id: str,
        request: dingtalktodo__1__0_models.CreateTodoTaskRequest,
        headers: dingtalktodo__1__0_models.CreateTodoTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.CreateTodoTaskResponse:
        """
        @summary 创建待办
        
        @param request: CreateTodoTaskRequest
        @param headers: CreateTodoTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateTodoTaskResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.action_list):
            body['actionList'] = request.action_list
        if not UtilClient.is_unset(request.biz_category_id):
            body['bizCategoryId'] = request.biz_category_id
        if not UtilClient.is_unset(request.content_field_list):
            body['contentFieldList'] = request.content_field_list
        if not UtilClient.is_unset(request.creator_id):
            body['creatorId'] = request.creator_id
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.detail_url):
            body['detailUrl'] = request.detail_url
        if not UtilClient.is_unset(request.due_time):
            body['dueTime'] = request.due_time
        if not UtilClient.is_unset(request.executor_ids):
            body['executorIds'] = request.executor_ids
        if not UtilClient.is_unset(request.is_only_show_executor):
            body['isOnlyShowExecutor'] = request.is_only_show_executor
        if not UtilClient.is_unset(request.notify_configs):
            body['notifyConfigs'] = request.notify_configs
        if not UtilClient.is_unset(request.participant_ids):
            body['participantIds'] = request.participant_ids
        if not UtilClient.is_unset(request.priority):
            body['priority'] = request.priority
        if not UtilClient.is_unset(request.source_id):
            body['sourceId'] = request.source_id
        if not UtilClient.is_unset(request.subject):
            body['subject'] = request.subject
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
            action='CreateTodoTask',
            version='todo_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todo/users/{union_id}/tasks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.CreateTodoTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def create_todo_task_with_options_async(
        self,
        union_id: str,
        request: dingtalktodo__1__0_models.CreateTodoTaskRequest,
        headers: dingtalktodo__1__0_models.CreateTodoTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.CreateTodoTaskResponse:
        """
        @summary 创建待办
        
        @param request: CreateTodoTaskRequest
        @param headers: CreateTodoTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateTodoTaskResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.action_list):
            body['actionList'] = request.action_list
        if not UtilClient.is_unset(request.biz_category_id):
            body['bizCategoryId'] = request.biz_category_id
        if not UtilClient.is_unset(request.content_field_list):
            body['contentFieldList'] = request.content_field_list
        if not UtilClient.is_unset(request.creator_id):
            body['creatorId'] = request.creator_id
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.detail_url):
            body['detailUrl'] = request.detail_url
        if not UtilClient.is_unset(request.due_time):
            body['dueTime'] = request.due_time
        if not UtilClient.is_unset(request.executor_ids):
            body['executorIds'] = request.executor_ids
        if not UtilClient.is_unset(request.is_only_show_executor):
            body['isOnlyShowExecutor'] = request.is_only_show_executor
        if not UtilClient.is_unset(request.notify_configs):
            body['notifyConfigs'] = request.notify_configs
        if not UtilClient.is_unset(request.participant_ids):
            body['participantIds'] = request.participant_ids
        if not UtilClient.is_unset(request.priority):
            body['priority'] = request.priority
        if not UtilClient.is_unset(request.source_id):
            body['sourceId'] = request.source_id
        if not UtilClient.is_unset(request.subject):
            body['subject'] = request.subject
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
            action='CreateTodoTask',
            version='todo_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todo/users/{union_id}/tasks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.CreateTodoTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_todo_task(
        self,
        union_id: str,
        request: dingtalktodo__1__0_models.CreateTodoTaskRequest,
    ) -> dingtalktodo__1__0_models.CreateTodoTaskResponse:
        """
        @summary 创建待办
        
        @param request: CreateTodoTaskRequest
        @return: CreateTodoTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.CreateTodoTaskHeaders()
        return self.create_todo_task_with_options(union_id, request, headers, runtime)

    async def create_todo_task_async(
        self,
        union_id: str,
        request: dingtalktodo__1__0_models.CreateTodoTaskRequest,
    ) -> dingtalktodo__1__0_models.CreateTodoTaskResponse:
        """
        @summary 创建待办
        
        @param request: CreateTodoTaskRequest
        @return: CreateTodoTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.CreateTodoTaskHeaders()
        return await self.create_todo_task_with_options_async(union_id, request, headers, runtime)

    def create_todo_type_config_with_options(
        self,
        union_id: str,
        request: dingtalktodo__1__0_models.CreateTodoTypeConfigRequest,
        headers: dingtalktodo__1__0_models.CreateTodoTypeConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.CreateTodoTypeConfigResponse:
        """
        @summary 创建待办卡片类型配置
        
        @param request: CreateTodoTypeConfigRequest
        @param headers: CreateTodoTypeConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateTodoTypeConfigResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.action_list):
            body['actionList'] = request.action_list
        if not UtilClient.is_unset(request.card_type):
            body['cardType'] = request.card_type
        if not UtilClient.is_unset(request.content_field_list):
            body['contentFieldList'] = request.content_field_list
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.pc_detail_url_open_mode):
            body['pcDetailUrlOpenMode'] = request.pc_detail_url_open_mode
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
            action='CreateTodoTypeConfig',
            version='todo_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todo/users/{union_id}/configs/types',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.CreateTodoTypeConfigResponse(),
            self.execute(params, req, runtime)
        )

    async def create_todo_type_config_with_options_async(
        self,
        union_id: str,
        request: dingtalktodo__1__0_models.CreateTodoTypeConfigRequest,
        headers: dingtalktodo__1__0_models.CreateTodoTypeConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.CreateTodoTypeConfigResponse:
        """
        @summary 创建待办卡片类型配置
        
        @param request: CreateTodoTypeConfigRequest
        @param headers: CreateTodoTypeConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateTodoTypeConfigResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.action_list):
            body['actionList'] = request.action_list
        if not UtilClient.is_unset(request.card_type):
            body['cardType'] = request.card_type
        if not UtilClient.is_unset(request.content_field_list):
            body['contentFieldList'] = request.content_field_list
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.pc_detail_url_open_mode):
            body['pcDetailUrlOpenMode'] = request.pc_detail_url_open_mode
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
            action='CreateTodoTypeConfig',
            version='todo_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todo/users/{union_id}/configs/types',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.CreateTodoTypeConfigResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_todo_type_config(
        self,
        union_id: str,
        request: dingtalktodo__1__0_models.CreateTodoTypeConfigRequest,
    ) -> dingtalktodo__1__0_models.CreateTodoTypeConfigResponse:
        """
        @summary 创建待办卡片类型配置
        
        @param request: CreateTodoTypeConfigRequest
        @return: CreateTodoTypeConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.CreateTodoTypeConfigHeaders()
        return self.create_todo_type_config_with_options(union_id, request, headers, runtime)

    async def create_todo_type_config_async(
        self,
        union_id: str,
        request: dingtalktodo__1__0_models.CreateTodoTypeConfigRequest,
    ) -> dingtalktodo__1__0_models.CreateTodoTypeConfigResponse:
        """
        @summary 创建待办卡片类型配置
        
        @param request: CreateTodoTypeConfigRequest
        @return: CreateTodoTypeConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.CreateTodoTypeConfigHeaders()
        return await self.create_todo_type_config_with_options_async(union_id, request, headers, runtime)

    def delete_todo_task_with_options(
        self,
        union_id: str,
        task_id: str,
        request: dingtalktodo__1__0_models.DeleteTodoTaskRequest,
        headers: dingtalktodo__1__0_models.DeleteTodoTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.DeleteTodoTaskResponse:
        """
        @summary 删除待办
        
        @param request: DeleteTodoTaskRequest
        @param headers: DeleteTodoTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteTodoTaskResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='DeleteTodoTask',
            version='todo_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todo/users/{union_id}/tasks/{task_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.DeleteTodoTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_todo_task_with_options_async(
        self,
        union_id: str,
        task_id: str,
        request: dingtalktodo__1__0_models.DeleteTodoTaskRequest,
        headers: dingtalktodo__1__0_models.DeleteTodoTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.DeleteTodoTaskResponse:
        """
        @summary 删除待办
        
        @param request: DeleteTodoTaskRequest
        @param headers: DeleteTodoTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteTodoTaskResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='DeleteTodoTask',
            version='todo_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todo/users/{union_id}/tasks/{task_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.DeleteTodoTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_todo_task(
        self,
        union_id: str,
        task_id: str,
        request: dingtalktodo__1__0_models.DeleteTodoTaskRequest,
    ) -> dingtalktodo__1__0_models.DeleteTodoTaskResponse:
        """
        @summary 删除待办
        
        @param request: DeleteTodoTaskRequest
        @return: DeleteTodoTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.DeleteTodoTaskHeaders()
        return self.delete_todo_task_with_options(union_id, task_id, request, headers, runtime)

    async def delete_todo_task_async(
        self,
        union_id: str,
        task_id: str,
        request: dingtalktodo__1__0_models.DeleteTodoTaskRequest,
    ) -> dingtalktodo__1__0_models.DeleteTodoTaskResponse:
        """
        @summary 删除待办
        
        @param request: DeleteTodoTaskRequest
        @return: DeleteTodoTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.DeleteTodoTaskHeaders()
        return await self.delete_todo_task_with_options_async(union_id, task_id, request, headers, runtime)

    def get_todo_task_with_options(
        self,
        union_id: str,
        task_id: str,
        headers: dingtalktodo__1__0_models.GetTodoTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.GetTodoTaskResponse:
        """
        @summary 查询待办
        
        @param headers: GetTodoTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTodoTaskResponse
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
            action='GetTodoTask',
            version='todo_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todo/users/{union_id}/tasks/{task_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.GetTodoTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def get_todo_task_with_options_async(
        self,
        union_id: str,
        task_id: str,
        headers: dingtalktodo__1__0_models.GetTodoTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.GetTodoTaskResponse:
        """
        @summary 查询待办
        
        @param headers: GetTodoTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTodoTaskResponse
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
            action='GetTodoTask',
            version='todo_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todo/users/{union_id}/tasks/{task_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.GetTodoTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_todo_task(
        self,
        union_id: str,
        task_id: str,
    ) -> dingtalktodo__1__0_models.GetTodoTaskResponse:
        """
        @summary 查询待办
        
        @return: GetTodoTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.GetTodoTaskHeaders()
        return self.get_todo_task_with_options(union_id, task_id, headers, runtime)

    async def get_todo_task_async(
        self,
        union_id: str,
        task_id: str,
    ) -> dingtalktodo__1__0_models.GetTodoTaskResponse:
        """
        @summary 查询待办
        
        @return: GetTodoTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.GetTodoTaskHeaders()
        return await self.get_todo_task_with_options_async(union_id, task_id, headers, runtime)

    def get_todo_task_by_source_id_with_options(
        self,
        union_id: str,
        source_id: str,
        headers: dingtalktodo__1__0_models.GetTodoTaskBySourceIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.GetTodoTaskBySourceIdResponse:
        """
        @summary 根据sourceId查询待办详情
        
        @param headers: GetTodoTaskBySourceIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTodoTaskBySourceIdResponse
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
            action='GetTodoTaskBySourceId',
            version='todo_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todo/users/{union_id}/tasks/sources/{source_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.GetTodoTaskBySourceIdResponse(),
            self.execute(params, req, runtime)
        )

    async def get_todo_task_by_source_id_with_options_async(
        self,
        union_id: str,
        source_id: str,
        headers: dingtalktodo__1__0_models.GetTodoTaskBySourceIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.GetTodoTaskBySourceIdResponse:
        """
        @summary 根据sourceId查询待办详情
        
        @param headers: GetTodoTaskBySourceIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTodoTaskBySourceIdResponse
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
            action='GetTodoTaskBySourceId',
            version='todo_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todo/users/{union_id}/tasks/sources/{source_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.GetTodoTaskBySourceIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_todo_task_by_source_id(
        self,
        union_id: str,
        source_id: str,
    ) -> dingtalktodo__1__0_models.GetTodoTaskBySourceIdResponse:
        """
        @summary 根据sourceId查询待办详情
        
        @return: GetTodoTaskBySourceIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.GetTodoTaskBySourceIdHeaders()
        return self.get_todo_task_by_source_id_with_options(union_id, source_id, headers, runtime)

    async def get_todo_task_by_source_id_async(
        self,
        union_id: str,
        source_id: str,
    ) -> dingtalktodo__1__0_models.GetTodoTaskBySourceIdResponse:
        """
        @summary 根据sourceId查询待办详情
        
        @return: GetTodoTaskBySourceIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.GetTodoTaskBySourceIdHeaders()
        return await self.get_todo_task_by_source_id_with_options_async(union_id, source_id, headers, runtime)

    def get_todo_task_detail_with_options(
        self,
        task_id: str,
        union_id: str,
        headers: dingtalktodo__1__0_models.GetTodoTaskDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.GetTodoTaskDetailResponse:
        """
        @summary 专属钉根据待办ID查询待办详情
        
        @param headers: GetTodoTaskDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTodoTaskDetailResponse
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
            action='GetTodoTaskDetail',
            version='todo_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todo/exclusive/users/{union_id}/tasks/{task_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.GetTodoTaskDetailResponse(),
            self.execute(params, req, runtime)
        )

    async def get_todo_task_detail_with_options_async(
        self,
        task_id: str,
        union_id: str,
        headers: dingtalktodo__1__0_models.GetTodoTaskDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.GetTodoTaskDetailResponse:
        """
        @summary 专属钉根据待办ID查询待办详情
        
        @param headers: GetTodoTaskDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTodoTaskDetailResponse
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
            action='GetTodoTaskDetail',
            version='todo_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todo/exclusive/users/{union_id}/tasks/{task_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.GetTodoTaskDetailResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_todo_task_detail(
        self,
        task_id: str,
        union_id: str,
    ) -> dingtalktodo__1__0_models.GetTodoTaskDetailResponse:
        """
        @summary 专属钉根据待办ID查询待办详情
        
        @return: GetTodoTaskDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.GetTodoTaskDetailHeaders()
        return self.get_todo_task_detail_with_options(task_id, union_id, headers, runtime)

    async def get_todo_task_detail_async(
        self,
        task_id: str,
        union_id: str,
    ) -> dingtalktodo__1__0_models.GetTodoTaskDetailResponse:
        """
        @summary 专属钉根据待办ID查询待办详情
        
        @return: GetTodoTaskDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.GetTodoTaskDetailHeaders()
        return await self.get_todo_task_detail_with_options_async(task_id, union_id, headers, runtime)

    def get_todo_type_config_with_options(
        self,
        union_id: str,
        card_type_id: str,
        headers: dingtalktodo__1__0_models.GetTodoTypeConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.GetTodoTypeConfigResponse:
        """
        @summary 根据id获取待办卡片类型配置
        
        @param headers: GetTodoTypeConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTodoTypeConfigResponse
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
            action='GetTodoTypeConfig',
            version='todo_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todo/users/{union_id}/configs/types/{card_type_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.GetTodoTypeConfigResponse(),
            self.execute(params, req, runtime)
        )

    async def get_todo_type_config_with_options_async(
        self,
        union_id: str,
        card_type_id: str,
        headers: dingtalktodo__1__0_models.GetTodoTypeConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.GetTodoTypeConfigResponse:
        """
        @summary 根据id获取待办卡片类型配置
        
        @param headers: GetTodoTypeConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTodoTypeConfigResponse
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
            action='GetTodoTypeConfig',
            version='todo_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todo/users/{union_id}/configs/types/{card_type_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.GetTodoTypeConfigResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_todo_type_config(
        self,
        union_id: str,
        card_type_id: str,
    ) -> dingtalktodo__1__0_models.GetTodoTypeConfigResponse:
        """
        @summary 根据id获取待办卡片类型配置
        
        @return: GetTodoTypeConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.GetTodoTypeConfigHeaders()
        return self.get_todo_type_config_with_options(union_id, card_type_id, headers, runtime)

    async def get_todo_type_config_async(
        self,
        union_id: str,
        card_type_id: str,
    ) -> dingtalktodo__1__0_models.GetTodoTypeConfigResponse:
        """
        @summary 根据id获取待办卡片类型配置
        
        @return: GetTodoTypeConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.GetTodoTypeConfigHeaders()
        return await self.get_todo_type_config_with_options_async(union_id, card_type_id, headers, runtime)

    def query_org_todo_by_user_with_options(
        self,
        union_id: str,
        request: dingtalktodo__1__0_models.QueryOrgTodoByUserRequest,
        headers: dingtalktodo__1__0_models.QueryOrgTodoByUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.QueryOrgTodoByUserResponse:
        """
        @summary 查询用户企业类型待办列表，支持查询当前企业的一方应用、三方应用、自建应用产生的工作待办数据
        
        @param request: QueryOrgTodoByUserRequest
        @param headers: QueryOrgTodoByUserHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryOrgTodoByUserResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.from_due_time):
            body['fromDueTime'] = request.from_due_time
        if not UtilClient.is_unset(request.is_done):
            body['isDone'] = request.is_done
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.order_by):
            body['orderBy'] = request.order_by
        if not UtilClient.is_unset(request.order_direction):
            body['orderDirection'] = request.order_direction
        if not UtilClient.is_unset(request.role_types):
            body['roleTypes'] = request.role_types
        if not UtilClient.is_unset(request.subject):
            body['subject'] = request.subject
        if not UtilClient.is_unset(request.to_due_time):
            body['toDueTime'] = request.to_due_time
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
            action='QueryOrgTodoByUser',
            version='todo_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todo/users/{union_id}/organizations/tasks/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.QueryOrgTodoByUserResponse(),
            self.execute(params, req, runtime)
        )

    async def query_org_todo_by_user_with_options_async(
        self,
        union_id: str,
        request: dingtalktodo__1__0_models.QueryOrgTodoByUserRequest,
        headers: dingtalktodo__1__0_models.QueryOrgTodoByUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.QueryOrgTodoByUserResponse:
        """
        @summary 查询用户企业类型待办列表，支持查询当前企业的一方应用、三方应用、自建应用产生的工作待办数据
        
        @param request: QueryOrgTodoByUserRequest
        @param headers: QueryOrgTodoByUserHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryOrgTodoByUserResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.from_due_time):
            body['fromDueTime'] = request.from_due_time
        if not UtilClient.is_unset(request.is_done):
            body['isDone'] = request.is_done
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.order_by):
            body['orderBy'] = request.order_by
        if not UtilClient.is_unset(request.order_direction):
            body['orderDirection'] = request.order_direction
        if not UtilClient.is_unset(request.role_types):
            body['roleTypes'] = request.role_types
        if not UtilClient.is_unset(request.subject):
            body['subject'] = request.subject
        if not UtilClient.is_unset(request.to_due_time):
            body['toDueTime'] = request.to_due_time
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
            action='QueryOrgTodoByUser',
            version='todo_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todo/users/{union_id}/organizations/tasks/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.QueryOrgTodoByUserResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_org_todo_by_user(
        self,
        union_id: str,
        request: dingtalktodo__1__0_models.QueryOrgTodoByUserRequest,
    ) -> dingtalktodo__1__0_models.QueryOrgTodoByUserResponse:
        """
        @summary 查询用户企业类型待办列表，支持查询当前企业的一方应用、三方应用、自建应用产生的工作待办数据
        
        @param request: QueryOrgTodoByUserRequest
        @return: QueryOrgTodoByUserResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.QueryOrgTodoByUserHeaders()
        return self.query_org_todo_by_user_with_options(union_id, request, headers, runtime)

    async def query_org_todo_by_user_async(
        self,
        union_id: str,
        request: dingtalktodo__1__0_models.QueryOrgTodoByUserRequest,
    ) -> dingtalktodo__1__0_models.QueryOrgTodoByUserResponse:
        """
        @summary 查询用户企业类型待办列表，支持查询当前企业的一方应用、三方应用、自建应用产生的工作待办数据
        
        @param request: QueryOrgTodoByUserRequest
        @return: QueryOrgTodoByUserResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.QueryOrgTodoByUserHeaders()
        return await self.query_org_todo_by_user_with_options_async(union_id, request, headers, runtime)

    def query_org_todo_tasks_with_options(
        self,
        union_id: str,
        request: dingtalktodo__1__0_models.QueryOrgTodoTasksRequest,
        headers: dingtalktodo__1__0_models.QueryOrgTodoTasksHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.QueryOrgTodoTasksResponse:
        """
        @summary 查询企业下用户待办列表
        
        @param request: QueryOrgTodoTasksRequest
        @param headers: QueryOrgTodoTasksHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryOrgTodoTasksResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.is_done):
            body['isDone'] = request.is_done
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
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
            action='QueryOrgTodoTasks',
            version='todo_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todo/users/{union_id}/org/tasks/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.QueryOrgTodoTasksResponse(),
            self.execute(params, req, runtime)
        )

    async def query_org_todo_tasks_with_options_async(
        self,
        union_id: str,
        request: dingtalktodo__1__0_models.QueryOrgTodoTasksRequest,
        headers: dingtalktodo__1__0_models.QueryOrgTodoTasksHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.QueryOrgTodoTasksResponse:
        """
        @summary 查询企业下用户待办列表
        
        @param request: QueryOrgTodoTasksRequest
        @param headers: QueryOrgTodoTasksHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryOrgTodoTasksResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.is_done):
            body['isDone'] = request.is_done
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
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
            action='QueryOrgTodoTasks',
            version='todo_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todo/users/{union_id}/org/tasks/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.QueryOrgTodoTasksResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_org_todo_tasks(
        self,
        union_id: str,
        request: dingtalktodo__1__0_models.QueryOrgTodoTasksRequest,
    ) -> dingtalktodo__1__0_models.QueryOrgTodoTasksResponse:
        """
        @summary 查询企业下用户待办列表
        
        @param request: QueryOrgTodoTasksRequest
        @return: QueryOrgTodoTasksResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.QueryOrgTodoTasksHeaders()
        return self.query_org_todo_tasks_with_options(union_id, request, headers, runtime)

    async def query_org_todo_tasks_async(
        self,
        union_id: str,
        request: dingtalktodo__1__0_models.QueryOrgTodoTasksRequest,
    ) -> dingtalktodo__1__0_models.QueryOrgTodoTasksResponse:
        """
        @summary 查询企业下用户待办列表
        
        @param request: QueryOrgTodoTasksRequest
        @return: QueryOrgTodoTasksResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.QueryOrgTodoTasksHeaders()
        return await self.query_org_todo_tasks_with_options_async(union_id, request, headers, runtime)

    def query_todo_tasks_with_options(
        self,
        union_id: str,
        request: dingtalktodo__1__0_models.QueryTodoTasksRequest,
        headers: dingtalktodo__1__0_models.QueryTodoTasksHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.QueryTodoTasksResponse:
        """
        @summary 查询用户待办列表
        
        @param request: QueryTodoTasksRequest
        @param headers: QueryTodoTasksHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryTodoTasksResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.category):
            body['category'] = request.category
        if not UtilClient.is_unset(request.from_due_time):
            body['fromDueTime'] = request.from_due_time
        if not UtilClient.is_unset(request.is_done):
            body['isDone'] = request.is_done
        if not UtilClient.is_unset(request.is_recycled):
            body['isRecycled'] = request.is_recycled
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.order_by):
            body['orderBy'] = request.order_by
        if not UtilClient.is_unset(request.order_direction):
            body['orderDirection'] = request.order_direction
        if not UtilClient.is_unset(request.role_types):
            body['roleTypes'] = request.role_types
        if not UtilClient.is_unset(request.to_due_time):
            body['toDueTime'] = request.to_due_time
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
            action='QueryTodoTasks',
            version='todo_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todo/users/{union_id}/tasks/list',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.QueryTodoTasksResponse(),
            self.execute(params, req, runtime)
        )

    async def query_todo_tasks_with_options_async(
        self,
        union_id: str,
        request: dingtalktodo__1__0_models.QueryTodoTasksRequest,
        headers: dingtalktodo__1__0_models.QueryTodoTasksHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.QueryTodoTasksResponse:
        """
        @summary 查询用户待办列表
        
        @param request: QueryTodoTasksRequest
        @param headers: QueryTodoTasksHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryTodoTasksResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.category):
            body['category'] = request.category
        if not UtilClient.is_unset(request.from_due_time):
            body['fromDueTime'] = request.from_due_time
        if not UtilClient.is_unset(request.is_done):
            body['isDone'] = request.is_done
        if not UtilClient.is_unset(request.is_recycled):
            body['isRecycled'] = request.is_recycled
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.order_by):
            body['orderBy'] = request.order_by
        if not UtilClient.is_unset(request.order_direction):
            body['orderDirection'] = request.order_direction
        if not UtilClient.is_unset(request.role_types):
            body['roleTypes'] = request.role_types
        if not UtilClient.is_unset(request.to_due_time):
            body['toDueTime'] = request.to_due_time
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
            action='QueryTodoTasks',
            version='todo_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todo/users/{union_id}/tasks/list',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.QueryTodoTasksResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_todo_tasks(
        self,
        union_id: str,
        request: dingtalktodo__1__0_models.QueryTodoTasksRequest,
    ) -> dingtalktodo__1__0_models.QueryTodoTasksResponse:
        """
        @summary 查询用户待办列表
        
        @param request: QueryTodoTasksRequest
        @return: QueryTodoTasksResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.QueryTodoTasksHeaders()
        return self.query_todo_tasks_with_options(union_id, request, headers, runtime)

    async def query_todo_tasks_async(
        self,
        union_id: str,
        request: dingtalktodo__1__0_models.QueryTodoTasksRequest,
    ) -> dingtalktodo__1__0_models.QueryTodoTasksResponse:
        """
        @summary 查询用户待办列表
        
        @param request: QueryTodoTasksRequest
        @return: QueryTodoTasksResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.QueryTodoTasksHeaders()
        return await self.query_todo_tasks_with_options_async(union_id, request, headers, runtime)

    def update_todo_task_with_options(
        self,
        union_id: str,
        task_id: str,
        request: dingtalktodo__1__0_models.UpdateTodoTaskRequest,
        headers: dingtalktodo__1__0_models.UpdateTodoTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.UpdateTodoTaskResponse:
        """
        @summary 更新待办
        
        @param request: UpdateTodoTaskRequest
        @param headers: UpdateTodoTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateTodoTaskResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.done):
            body['done'] = request.done
        if not UtilClient.is_unset(request.due_time):
            body['dueTime'] = request.due_time
        if not UtilClient.is_unset(request.executor_ids):
            body['executorIds'] = request.executor_ids
        if not UtilClient.is_unset(request.participant_ids):
            body['participantIds'] = request.participant_ids
        if not UtilClient.is_unset(request.subject):
            body['subject'] = request.subject
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
            action='UpdateTodoTask',
            version='todo_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todo/users/{union_id}/tasks/{task_id}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.UpdateTodoTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def update_todo_task_with_options_async(
        self,
        union_id: str,
        task_id: str,
        request: dingtalktodo__1__0_models.UpdateTodoTaskRequest,
        headers: dingtalktodo__1__0_models.UpdateTodoTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.UpdateTodoTaskResponse:
        """
        @summary 更新待办
        
        @param request: UpdateTodoTaskRequest
        @param headers: UpdateTodoTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateTodoTaskResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.done):
            body['done'] = request.done
        if not UtilClient.is_unset(request.due_time):
            body['dueTime'] = request.due_time
        if not UtilClient.is_unset(request.executor_ids):
            body['executorIds'] = request.executor_ids
        if not UtilClient.is_unset(request.participant_ids):
            body['participantIds'] = request.participant_ids
        if not UtilClient.is_unset(request.subject):
            body['subject'] = request.subject
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
            action='UpdateTodoTask',
            version='todo_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todo/users/{union_id}/tasks/{task_id}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.UpdateTodoTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_todo_task(
        self,
        union_id: str,
        task_id: str,
        request: dingtalktodo__1__0_models.UpdateTodoTaskRequest,
    ) -> dingtalktodo__1__0_models.UpdateTodoTaskResponse:
        """
        @summary 更新待办
        
        @param request: UpdateTodoTaskRequest
        @return: UpdateTodoTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.UpdateTodoTaskHeaders()
        return self.update_todo_task_with_options(union_id, task_id, request, headers, runtime)

    async def update_todo_task_async(
        self,
        union_id: str,
        task_id: str,
        request: dingtalktodo__1__0_models.UpdateTodoTaskRequest,
    ) -> dingtalktodo__1__0_models.UpdateTodoTaskResponse:
        """
        @summary 更新待办
        
        @param request: UpdateTodoTaskRequest
        @return: UpdateTodoTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.UpdateTodoTaskHeaders()
        return await self.update_todo_task_with_options_async(union_id, task_id, request, headers, runtime)

    def update_todo_task_executor_status_with_options(
        self,
        union_id: str,
        task_id: str,
        request: dingtalktodo__1__0_models.UpdateTodoTaskExecutorStatusRequest,
        headers: dingtalktodo__1__0_models.UpdateTodoTaskExecutorStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.UpdateTodoTaskExecutorStatusResponse:
        """
        @summary 更新待办执行者状态
        
        @param request: UpdateTodoTaskExecutorStatusRequest
        @param headers: UpdateTodoTaskExecutorStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateTodoTaskExecutorStatusResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.executor_status_list):
            body['executorStatusList'] = request.executor_status_list
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
            action='UpdateTodoTaskExecutorStatus',
            version='todo_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todo/users/{union_id}/tasks/{task_id}/executorStatus',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.UpdateTodoTaskExecutorStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def update_todo_task_executor_status_with_options_async(
        self,
        union_id: str,
        task_id: str,
        request: dingtalktodo__1__0_models.UpdateTodoTaskExecutorStatusRequest,
        headers: dingtalktodo__1__0_models.UpdateTodoTaskExecutorStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.UpdateTodoTaskExecutorStatusResponse:
        """
        @summary 更新待办执行者状态
        
        @param request: UpdateTodoTaskExecutorStatusRequest
        @param headers: UpdateTodoTaskExecutorStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateTodoTaskExecutorStatusResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.executor_status_list):
            body['executorStatusList'] = request.executor_status_list
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
            action='UpdateTodoTaskExecutorStatus',
            version='todo_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todo/users/{union_id}/tasks/{task_id}/executorStatus',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.UpdateTodoTaskExecutorStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_todo_task_executor_status(
        self,
        union_id: str,
        task_id: str,
        request: dingtalktodo__1__0_models.UpdateTodoTaskExecutorStatusRequest,
    ) -> dingtalktodo__1__0_models.UpdateTodoTaskExecutorStatusResponse:
        """
        @summary 更新待办执行者状态
        
        @param request: UpdateTodoTaskExecutorStatusRequest
        @return: UpdateTodoTaskExecutorStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.UpdateTodoTaskExecutorStatusHeaders()
        return self.update_todo_task_executor_status_with_options(union_id, task_id, request, headers, runtime)

    async def update_todo_task_executor_status_async(
        self,
        union_id: str,
        task_id: str,
        request: dingtalktodo__1__0_models.UpdateTodoTaskExecutorStatusRequest,
    ) -> dingtalktodo__1__0_models.UpdateTodoTaskExecutorStatusResponse:
        """
        @summary 更新待办执行者状态
        
        @param request: UpdateTodoTaskExecutorStatusRequest
        @return: UpdateTodoTaskExecutorStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.UpdateTodoTaskExecutorStatusHeaders()
        return await self.update_todo_task_executor_status_with_options_async(union_id, task_id, request, headers, runtime)

    def update_todo_type_config_with_options(
        self,
        union_id: str,
        card_type_id: str,
        request: dingtalktodo__1__0_models.UpdateTodoTypeConfigRequest,
        headers: dingtalktodo__1__0_models.UpdateTodoTypeConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.UpdateTodoTypeConfigResponse:
        """
        @summary 更新待办卡片类型配置
        
        @param request: UpdateTodoTypeConfigRequest
        @param headers: UpdateTodoTypeConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateTodoTypeConfigResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.action_list):
            body['actionList'] = request.action_list
        if not UtilClient.is_unset(request.card_type):
            body['cardType'] = request.card_type
        if not UtilClient.is_unset(request.content_field_list):
            body['contentFieldList'] = request.content_field_list
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.pc_detail_url_open_mode):
            body['pcDetailUrlOpenMode'] = request.pc_detail_url_open_mode
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
            action='UpdateTodoTypeConfig',
            version='todo_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todo/users/{union_id}/configs/types/{card_type_id}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.UpdateTodoTypeConfigResponse(),
            self.execute(params, req, runtime)
        )

    async def update_todo_type_config_with_options_async(
        self,
        union_id: str,
        card_type_id: str,
        request: dingtalktodo__1__0_models.UpdateTodoTypeConfigRequest,
        headers: dingtalktodo__1__0_models.UpdateTodoTypeConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.UpdateTodoTypeConfigResponse:
        """
        @summary 更新待办卡片类型配置
        
        @param request: UpdateTodoTypeConfigRequest
        @param headers: UpdateTodoTypeConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateTodoTypeConfigResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.action_list):
            body['actionList'] = request.action_list
        if not UtilClient.is_unset(request.card_type):
            body['cardType'] = request.card_type
        if not UtilClient.is_unset(request.content_field_list):
            body['contentFieldList'] = request.content_field_list
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.pc_detail_url_open_mode):
            body['pcDetailUrlOpenMode'] = request.pc_detail_url_open_mode
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
            action='UpdateTodoTypeConfig',
            version='todo_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todo/users/{union_id}/configs/types/{card_type_id}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.UpdateTodoTypeConfigResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_todo_type_config(
        self,
        union_id: str,
        card_type_id: str,
        request: dingtalktodo__1__0_models.UpdateTodoTypeConfigRequest,
    ) -> dingtalktodo__1__0_models.UpdateTodoTypeConfigResponse:
        """
        @summary 更新待办卡片类型配置
        
        @param request: UpdateTodoTypeConfigRequest
        @return: UpdateTodoTypeConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.UpdateTodoTypeConfigHeaders()
        return self.update_todo_type_config_with_options(union_id, card_type_id, request, headers, runtime)

    async def update_todo_type_config_async(
        self,
        union_id: str,
        card_type_id: str,
        request: dingtalktodo__1__0_models.UpdateTodoTypeConfigRequest,
    ) -> dingtalktodo__1__0_models.UpdateTodoTypeConfigResponse:
        """
        @summary 更新待办卡片类型配置
        
        @param request: UpdateTodoTypeConfigRequest
        @return: UpdateTodoTypeConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.UpdateTodoTypeConfigHeaders()
        return await self.update_todo_type_config_with_options_async(union_id, card_type_id, request, headers, runtime)
