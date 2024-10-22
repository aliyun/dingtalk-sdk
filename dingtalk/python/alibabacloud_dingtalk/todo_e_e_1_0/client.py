# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.todo_e_e_1_0 import models as dingtalktodo_e_e__1__0_models
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

    def create_enterprise_todo_task_with_options(
        self,
        request: dingtalktodo_e_e__1__0_models.CreateEnterpriseTodoTaskRequest,
        headers: dingtalktodo_e_e__1__0_models.CreateEnterpriseTodoTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo_e_e__1__0_models.CreateEnterpriseTodoTaskResponse:
        """
        @summary 创建企业待办
        
        @param request: CreateEnterpriseTodoTaskRequest
        @param headers: CreateEnterpriseTodoTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateEnterpriseTodoTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_category_id):
            body['bizCategoryId'] = request.biz_category_id
        if not UtilClient.is_unset(request.custom_fields):
            body['customFields'] = request.custom_fields
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.detail_url):
            body['detailUrl'] = request.detail_url
        if not UtilClient.is_unset(request.due_time):
            body['dueTime'] = request.due_time
        if not UtilClient.is_unset(request.executor_ids):
            body['executorIds'] = request.executor_ids
        if not UtilClient.is_unset(request.notify_configs):
            body['notifyConfigs'] = request.notify_configs
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.priority):
            body['priority'] = request.priority
        if not UtilClient.is_unset(request.source_id):
            body['sourceId'] = request.source_id
        if not UtilClient.is_unset(request.source_title):
            body['sourceTitle'] = request.source_title
        if not UtilClient.is_unset(request.subject):
            body['subject'] = request.subject
        if not UtilClient.is_unset(request.tracker_ids):
            body['trackerIds'] = request.tracker_ids
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='CreateEnterpriseTodoTask',
            version='todoEE_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todoEE/users/tasks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo_e_e__1__0_models.CreateEnterpriseTodoTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def create_enterprise_todo_task_with_options_async(
        self,
        request: dingtalktodo_e_e__1__0_models.CreateEnterpriseTodoTaskRequest,
        headers: dingtalktodo_e_e__1__0_models.CreateEnterpriseTodoTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo_e_e__1__0_models.CreateEnterpriseTodoTaskResponse:
        """
        @summary 创建企业待办
        
        @param request: CreateEnterpriseTodoTaskRequest
        @param headers: CreateEnterpriseTodoTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateEnterpriseTodoTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_category_id):
            body['bizCategoryId'] = request.biz_category_id
        if not UtilClient.is_unset(request.custom_fields):
            body['customFields'] = request.custom_fields
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.detail_url):
            body['detailUrl'] = request.detail_url
        if not UtilClient.is_unset(request.due_time):
            body['dueTime'] = request.due_time
        if not UtilClient.is_unset(request.executor_ids):
            body['executorIds'] = request.executor_ids
        if not UtilClient.is_unset(request.notify_configs):
            body['notifyConfigs'] = request.notify_configs
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.priority):
            body['priority'] = request.priority
        if not UtilClient.is_unset(request.source_id):
            body['sourceId'] = request.source_id
        if not UtilClient.is_unset(request.source_title):
            body['sourceTitle'] = request.source_title
        if not UtilClient.is_unset(request.subject):
            body['subject'] = request.subject
        if not UtilClient.is_unset(request.tracker_ids):
            body['trackerIds'] = request.tracker_ids
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='CreateEnterpriseTodoTask',
            version='todoEE_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todoEE/users/tasks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo_e_e__1__0_models.CreateEnterpriseTodoTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_enterprise_todo_task(
        self,
        request: dingtalktodo_e_e__1__0_models.CreateEnterpriseTodoTaskRequest,
    ) -> dingtalktodo_e_e__1__0_models.CreateEnterpriseTodoTaskResponse:
        """
        @summary 创建企业待办
        
        @param request: CreateEnterpriseTodoTaskRequest
        @return: CreateEnterpriseTodoTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo_e_e__1__0_models.CreateEnterpriseTodoTaskHeaders()
        return self.create_enterprise_todo_task_with_options(request, headers, runtime)

    async def create_enterprise_todo_task_async(
        self,
        request: dingtalktodo_e_e__1__0_models.CreateEnterpriseTodoTaskRequest,
    ) -> dingtalktodo_e_e__1__0_models.CreateEnterpriseTodoTaskResponse:
        """
        @summary 创建企业待办
        
        @param request: CreateEnterpriseTodoTaskRequest
        @return: CreateEnterpriseTodoTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo_e_e__1__0_models.CreateEnterpriseTodoTaskHeaders()
        return await self.create_enterprise_todo_task_with_options_async(request, headers, runtime)

    def delete_category_source_config_with_options(
        self,
        request: dingtalktodo_e_e__1__0_models.DeleteCategorySourceConfigRequest,
        headers: dingtalktodo_e_e__1__0_models.DeleteCategorySourceConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo_e_e__1__0_models.DeleteCategorySourceConfigResponse:
        """
        @summary 删除应用类目信息
        
        @param request: DeleteCategorySourceConfigRequest
        @param headers: DeleteCategorySourceConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteCategorySourceConfigResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_category_id):
            body['bizCategoryId'] = request.biz_category_id
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
            action='DeleteCategorySourceConfig',
            version='todoEE_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todoEE/apps/categories/sourceConfigs/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo_e_e__1__0_models.DeleteCategorySourceConfigResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_category_source_config_with_options_async(
        self,
        request: dingtalktodo_e_e__1__0_models.DeleteCategorySourceConfigRequest,
        headers: dingtalktodo_e_e__1__0_models.DeleteCategorySourceConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo_e_e__1__0_models.DeleteCategorySourceConfigResponse:
        """
        @summary 删除应用类目信息
        
        @param request: DeleteCategorySourceConfigRequest
        @param headers: DeleteCategorySourceConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteCategorySourceConfigResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_category_id):
            body['bizCategoryId'] = request.biz_category_id
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
            action='DeleteCategorySourceConfig',
            version='todoEE_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todoEE/apps/categories/sourceConfigs/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo_e_e__1__0_models.DeleteCategorySourceConfigResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_category_source_config(
        self,
        request: dingtalktodo_e_e__1__0_models.DeleteCategorySourceConfigRequest,
    ) -> dingtalktodo_e_e__1__0_models.DeleteCategorySourceConfigResponse:
        """
        @summary 删除应用类目信息
        
        @param request: DeleteCategorySourceConfigRequest
        @return: DeleteCategorySourceConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo_e_e__1__0_models.DeleteCategorySourceConfigHeaders()
        return self.delete_category_source_config_with_options(request, headers, runtime)

    async def delete_category_source_config_async(
        self,
        request: dingtalktodo_e_e__1__0_models.DeleteCategorySourceConfigRequest,
    ) -> dingtalktodo_e_e__1__0_models.DeleteCategorySourceConfigResponse:
        """
        @summary 删除应用类目信息
        
        @param request: DeleteCategorySourceConfigRequest
        @return: DeleteCategorySourceConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo_e_e__1__0_models.DeleteCategorySourceConfigHeaders()
        return await self.delete_category_source_config_with_options_async(request, headers, runtime)

    def delete_todo_eetask_with_options(
        self,
        request: dingtalktodo_e_e__1__0_models.DeleteTodoEETaskRequest,
        headers: dingtalktodo_e_e__1__0_models.DeleteTodoEETaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo_e_e__1__0_models.DeleteTodoEETaskResponse:
        """
        @summary 删除待办
        
        @param request: DeleteTodoEETaskRequest
        @param headers: DeleteTodoEETaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteTodoEETaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.task_ids):
            body['taskIds'] = request.task_ids
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
            action='DeleteTodoEETask',
            version='todoEE_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todoEE/users/tasks/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo_e_e__1__0_models.DeleteTodoEETaskResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_todo_eetask_with_options_async(
        self,
        request: dingtalktodo_e_e__1__0_models.DeleteTodoEETaskRequest,
        headers: dingtalktodo_e_e__1__0_models.DeleteTodoEETaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo_e_e__1__0_models.DeleteTodoEETaskResponse:
        """
        @summary 删除待办
        
        @param request: DeleteTodoEETaskRequest
        @param headers: DeleteTodoEETaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteTodoEETaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.task_ids):
            body['taskIds'] = request.task_ids
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
            action='DeleteTodoEETask',
            version='todoEE_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todoEE/users/tasks/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo_e_e__1__0_models.DeleteTodoEETaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_todo_eetask(
        self,
        request: dingtalktodo_e_e__1__0_models.DeleteTodoEETaskRequest,
    ) -> dingtalktodo_e_e__1__0_models.DeleteTodoEETaskResponse:
        """
        @summary 删除待办
        
        @param request: DeleteTodoEETaskRequest
        @return: DeleteTodoEETaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo_e_e__1__0_models.DeleteTodoEETaskHeaders()
        return self.delete_todo_eetask_with_options(request, headers, runtime)

    async def delete_todo_eetask_async(
        self,
        request: dingtalktodo_e_e__1__0_models.DeleteTodoEETaskRequest,
    ) -> dingtalktodo_e_e__1__0_models.DeleteTodoEETaskResponse:
        """
        @summary 删除待办
        
        @param request: DeleteTodoEETaskRequest
        @return: DeleteTodoEETaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo_e_e__1__0_models.DeleteTodoEETaskHeaders()
        return await self.delete_todo_eetask_with_options_async(request, headers, runtime)

    def get_category_source_config_list_with_options(
        self,
        request: dingtalktodo_e_e__1__0_models.GetCategorySourceConfigListRequest,
        headers: dingtalktodo_e_e__1__0_models.GetCategorySourceConfigListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo_e_e__1__0_models.GetCategorySourceConfigListResponse:
        """
        @summary 查询应用注册类目信息列表
        
        @param request: GetCategorySourceConfigListRequest
        @param headers: GetCategorySourceConfigListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCategorySourceConfigListResponse
        """
        UtilClient.validate_model(request)
        body = {}
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
            action='GetCategorySourceConfigList',
            version='todoEE_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todoEE/apps/categories/sourceConfigs/lists/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo_e_e__1__0_models.GetCategorySourceConfigListResponse(),
            self.execute(params, req, runtime)
        )

    async def get_category_source_config_list_with_options_async(
        self,
        request: dingtalktodo_e_e__1__0_models.GetCategorySourceConfigListRequest,
        headers: dingtalktodo_e_e__1__0_models.GetCategorySourceConfigListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo_e_e__1__0_models.GetCategorySourceConfigListResponse:
        """
        @summary 查询应用注册类目信息列表
        
        @param request: GetCategorySourceConfigListRequest
        @param headers: GetCategorySourceConfigListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCategorySourceConfigListResponse
        """
        UtilClient.validate_model(request)
        body = {}
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
            action='GetCategorySourceConfigList',
            version='todoEE_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todoEE/apps/categories/sourceConfigs/lists/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo_e_e__1__0_models.GetCategorySourceConfigListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_category_source_config_list(
        self,
        request: dingtalktodo_e_e__1__0_models.GetCategorySourceConfigListRequest,
    ) -> dingtalktodo_e_e__1__0_models.GetCategorySourceConfigListResponse:
        """
        @summary 查询应用注册类目信息列表
        
        @param request: GetCategorySourceConfigListRequest
        @return: GetCategorySourceConfigListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo_e_e__1__0_models.GetCategorySourceConfigListHeaders()
        return self.get_category_source_config_list_with_options(request, headers, runtime)

    async def get_category_source_config_list_async(
        self,
        request: dingtalktodo_e_e__1__0_models.GetCategorySourceConfigListRequest,
    ) -> dingtalktodo_e_e__1__0_models.GetCategorySourceConfigListResponse:
        """
        @summary 查询应用注册类目信息列表
        
        @param request: GetCategorySourceConfigListRequest
        @return: GetCategorySourceConfigListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo_e_e__1__0_models.GetCategorySourceConfigListHeaders()
        return await self.get_category_source_config_list_with_options_async(request, headers, runtime)

    def get_user_task_list_with_options(
        self,
        request: dingtalktodo_e_e__1__0_models.GetUserTaskListRequest,
        headers: dingtalktodo_e_e__1__0_models.GetUserTaskListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo_e_e__1__0_models.GetUserTaskListResponse:
        """
        @summary 查询用户待办列表
        
        @param request: GetUserTaskListRequest
        @param headers: GetUserTaskListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserTaskListResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.done):
            body['done'] = request.done
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='GetUserTaskList',
            version='todoEE_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todoEE/users/tasks/list',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo_e_e__1__0_models.GetUserTaskListResponse(),
            self.execute(params, req, runtime)
        )

    async def get_user_task_list_with_options_async(
        self,
        request: dingtalktodo_e_e__1__0_models.GetUserTaskListRequest,
        headers: dingtalktodo_e_e__1__0_models.GetUserTaskListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo_e_e__1__0_models.GetUserTaskListResponse:
        """
        @summary 查询用户待办列表
        
        @param request: GetUserTaskListRequest
        @param headers: GetUserTaskListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserTaskListResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.done):
            body['done'] = request.done
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='GetUserTaskList',
            version='todoEE_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todoEE/users/tasks/list',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo_e_e__1__0_models.GetUserTaskListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_user_task_list(
        self,
        request: dingtalktodo_e_e__1__0_models.GetUserTaskListRequest,
    ) -> dingtalktodo_e_e__1__0_models.GetUserTaskListResponse:
        """
        @summary 查询用户待办列表
        
        @param request: GetUserTaskListRequest
        @return: GetUserTaskListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo_e_e__1__0_models.GetUserTaskListHeaders()
        return self.get_user_task_list_with_options(request, headers, runtime)

    async def get_user_task_list_async(
        self,
        request: dingtalktodo_e_e__1__0_models.GetUserTaskListRequest,
    ) -> dingtalktodo_e_e__1__0_models.GetUserTaskListResponse:
        """
        @summary 查询用户待办列表
        
        @param request: GetUserTaskListRequest
        @return: GetUserTaskListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo_e_e__1__0_models.GetUserTaskListHeaders()
        return await self.get_user_task_list_with_options_async(request, headers, runtime)

    def register_category_source_config_with_options(
        self,
        request: dingtalktodo_e_e__1__0_models.RegisterCategorySourceConfigRequest,
        headers: dingtalktodo_e_e__1__0_models.RegisterCategorySourceConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo_e_e__1__0_models.RegisterCategorySourceConfigResponse:
        """
        @summary 注册应用类目信息
        
        @param request: RegisterCategorySourceConfigRequest
        @param headers: RegisterCategorySourceConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RegisterCategorySourceConfigResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_category_id):
            body['bizCategoryId'] = request.biz_category_id
        if not UtilClient.is_unset(request.biz_category_name):
            body['bizCategoryName'] = request.biz_category_name
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
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
            action='RegisterCategorySourceConfig',
            version='todoEE_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todoEE/apps/categories/sourceConfigs/register',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo_e_e__1__0_models.RegisterCategorySourceConfigResponse(),
            self.execute(params, req, runtime)
        )

    async def register_category_source_config_with_options_async(
        self,
        request: dingtalktodo_e_e__1__0_models.RegisterCategorySourceConfigRequest,
        headers: dingtalktodo_e_e__1__0_models.RegisterCategorySourceConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo_e_e__1__0_models.RegisterCategorySourceConfigResponse:
        """
        @summary 注册应用类目信息
        
        @param request: RegisterCategorySourceConfigRequest
        @param headers: RegisterCategorySourceConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RegisterCategorySourceConfigResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_category_id):
            body['bizCategoryId'] = request.biz_category_id
        if not UtilClient.is_unset(request.biz_category_name):
            body['bizCategoryName'] = request.biz_category_name
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
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
            action='RegisterCategorySourceConfig',
            version='todoEE_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todoEE/apps/categories/sourceConfigs/register',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo_e_e__1__0_models.RegisterCategorySourceConfigResponse(),
            await self.execute_async(params, req, runtime)
        )

    def register_category_source_config(
        self,
        request: dingtalktodo_e_e__1__0_models.RegisterCategorySourceConfigRequest,
    ) -> dingtalktodo_e_e__1__0_models.RegisterCategorySourceConfigResponse:
        """
        @summary 注册应用类目信息
        
        @param request: RegisterCategorySourceConfigRequest
        @return: RegisterCategorySourceConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo_e_e__1__0_models.RegisterCategorySourceConfigHeaders()
        return self.register_category_source_config_with_options(request, headers, runtime)

    async def register_category_source_config_async(
        self,
        request: dingtalktodo_e_e__1__0_models.RegisterCategorySourceConfigRequest,
    ) -> dingtalktodo_e_e__1__0_models.RegisterCategorySourceConfigResponse:
        """
        @summary 注册应用类目信息
        
        @param request: RegisterCategorySourceConfigRequest
        @return: RegisterCategorySourceConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo_e_e__1__0_models.RegisterCategorySourceConfigHeaders()
        return await self.register_category_source_config_with_options_async(request, headers, runtime)

    def update_category_source_config_with_options(
        self,
        request: dingtalktodo_e_e__1__0_models.UpdateCategorySourceConfigRequest,
        headers: dingtalktodo_e_e__1__0_models.UpdateCategorySourceConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo_e_e__1__0_models.UpdateCategorySourceConfigResponse:
        """
        @summary 修改应用类目注册信息
        
        @param request: UpdateCategorySourceConfigRequest
        @param headers: UpdateCategorySourceConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateCategorySourceConfigResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_category_id):
            body['bizCategoryId'] = request.biz_category_id
        if not UtilClient.is_unset(request.biz_category_name):
            body['bizCategoryName'] = request.biz_category_name
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
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
            action='UpdateCategorySourceConfig',
            version='todoEE_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todoEE/apps/categories/sourceConfigs',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo_e_e__1__0_models.UpdateCategorySourceConfigResponse(),
            self.execute(params, req, runtime)
        )

    async def update_category_source_config_with_options_async(
        self,
        request: dingtalktodo_e_e__1__0_models.UpdateCategorySourceConfigRequest,
        headers: dingtalktodo_e_e__1__0_models.UpdateCategorySourceConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo_e_e__1__0_models.UpdateCategorySourceConfigResponse:
        """
        @summary 修改应用类目注册信息
        
        @param request: UpdateCategorySourceConfigRequest
        @param headers: UpdateCategorySourceConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateCategorySourceConfigResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_category_id):
            body['bizCategoryId'] = request.biz_category_id
        if not UtilClient.is_unset(request.biz_category_name):
            body['bizCategoryName'] = request.biz_category_name
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
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
            action='UpdateCategorySourceConfig',
            version='todoEE_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todoEE/apps/categories/sourceConfigs',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo_e_e__1__0_models.UpdateCategorySourceConfigResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_category_source_config(
        self,
        request: dingtalktodo_e_e__1__0_models.UpdateCategorySourceConfigRequest,
    ) -> dingtalktodo_e_e__1__0_models.UpdateCategorySourceConfigResponse:
        """
        @summary 修改应用类目注册信息
        
        @param request: UpdateCategorySourceConfigRequest
        @return: UpdateCategorySourceConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo_e_e__1__0_models.UpdateCategorySourceConfigHeaders()
        return self.update_category_source_config_with_options(request, headers, runtime)

    async def update_category_source_config_async(
        self,
        request: dingtalktodo_e_e__1__0_models.UpdateCategorySourceConfigRequest,
    ) -> dingtalktodo_e_e__1__0_models.UpdateCategorySourceConfigResponse:
        """
        @summary 修改应用类目注册信息
        
        @param request: UpdateCategorySourceConfigRequest
        @return: UpdateCategorySourceConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo_e_e__1__0_models.UpdateCategorySourceConfigHeaders()
        return await self.update_category_source_config_with_options_async(request, headers, runtime)

    def update_task_with_options(
        self,
        request: dingtalktodo_e_e__1__0_models.UpdateTaskRequest,
        headers: dingtalktodo_e_e__1__0_models.UpdateTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo_e_e__1__0_models.UpdateTaskResponse:
        """
        @summary 更新待办信息
        
        @param request: UpdateTaskRequest
        @param headers: UpdateTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.done):
            body['done'] = request.done
        if not UtilClient.is_unset(request.due_time):
            body['dueTime'] = request.due_time
        if not UtilClient.is_unset(request.executor_ids):
            body['executorIds'] = request.executor_ids
        if not UtilClient.is_unset(request.subject):
            body['subject'] = request.subject
        if not UtilClient.is_unset(request.task_id):
            body['taskId'] = request.task_id
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
            action='UpdateTask',
            version='todoEE_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todoEE/users/tasks/infos',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo_e_e__1__0_models.UpdateTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def update_task_with_options_async(
        self,
        request: dingtalktodo_e_e__1__0_models.UpdateTaskRequest,
        headers: dingtalktodo_e_e__1__0_models.UpdateTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo_e_e__1__0_models.UpdateTaskResponse:
        """
        @summary 更新待办信息
        
        @param request: UpdateTaskRequest
        @param headers: UpdateTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.done):
            body['done'] = request.done
        if not UtilClient.is_unset(request.due_time):
            body['dueTime'] = request.due_time
        if not UtilClient.is_unset(request.executor_ids):
            body['executorIds'] = request.executor_ids
        if not UtilClient.is_unset(request.subject):
            body['subject'] = request.subject
        if not UtilClient.is_unset(request.task_id):
            body['taskId'] = request.task_id
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
            action='UpdateTask',
            version='todoEE_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todoEE/users/tasks/infos',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo_e_e__1__0_models.UpdateTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_task(
        self,
        request: dingtalktodo_e_e__1__0_models.UpdateTaskRequest,
    ) -> dingtalktodo_e_e__1__0_models.UpdateTaskResponse:
        """
        @summary 更新待办信息
        
        @param request: UpdateTaskRequest
        @return: UpdateTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo_e_e__1__0_models.UpdateTaskHeaders()
        return self.update_task_with_options(request, headers, runtime)

    async def update_task_async(
        self,
        request: dingtalktodo_e_e__1__0_models.UpdateTaskRequest,
    ) -> dingtalktodo_e_e__1__0_models.UpdateTaskResponse:
        """
        @summary 更新待办信息
        
        @param request: UpdateTaskRequest
        @return: UpdateTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo_e_e__1__0_models.UpdateTaskHeaders()
        return await self.update_task_with_options_async(request, headers, runtime)

    def update_user_task_status_with_options(
        self,
        request: dingtalktodo_e_e__1__0_models.UpdateUserTaskStatusRequest,
        headers: dingtalktodo_e_e__1__0_models.UpdateUserTaskStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo_e_e__1__0_models.UpdateUserTaskStatusResponse:
        """
        @summary 更新用户的待办状态
        
        @param request: UpdateUserTaskStatusRequest
        @param headers: UpdateUserTaskStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateUserTaskStatusResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.user_task_statuses):
            body['userTaskStatuses'] = request.user_task_statuses
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
            action='UpdateUserTaskStatus',
            version='todoEE_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todoEE/users/tasks/statuses',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo_e_e__1__0_models.UpdateUserTaskStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def update_user_task_status_with_options_async(
        self,
        request: dingtalktodo_e_e__1__0_models.UpdateUserTaskStatusRequest,
        headers: dingtalktodo_e_e__1__0_models.UpdateUserTaskStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo_e_e__1__0_models.UpdateUserTaskStatusResponse:
        """
        @summary 更新用户的待办状态
        
        @param request: UpdateUserTaskStatusRequest
        @param headers: UpdateUserTaskStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateUserTaskStatusResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.user_task_statuses):
            body['userTaskStatuses'] = request.user_task_statuses
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
            action='UpdateUserTaskStatus',
            version='todoEE_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todoEE/users/tasks/statuses',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo_e_e__1__0_models.UpdateUserTaskStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_user_task_status(
        self,
        request: dingtalktodo_e_e__1__0_models.UpdateUserTaskStatusRequest,
    ) -> dingtalktodo_e_e__1__0_models.UpdateUserTaskStatusResponse:
        """
        @summary 更新用户的待办状态
        
        @param request: UpdateUserTaskStatusRequest
        @return: UpdateUserTaskStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo_e_e__1__0_models.UpdateUserTaskStatusHeaders()
        return self.update_user_task_status_with_options(request, headers, runtime)

    async def update_user_task_status_async(
        self,
        request: dingtalktodo_e_e__1__0_models.UpdateUserTaskStatusRequest,
    ) -> dingtalktodo_e_e__1__0_models.UpdateUserTaskStatusResponse:
        """
        @summary 更新用户的待办状态
        
        @param request: UpdateUserTaskStatusRequest
        @return: UpdateUserTaskStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo_e_e__1__0_models.UpdateUserTaskStatusHeaders()
        return await self.update_user_task_status_with_options_async(request, headers, runtime)
