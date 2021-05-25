# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalktodo_1_0 import models as dingtalktodo__1__0_models
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

    def get_todo_type_config(
        self,
        union_id: str,
        card_type_id: str,
    ) -> dingtalktodo__1__0_models.GetTodoTypeConfigResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.GetTodoTypeConfigHeaders()
        return self.get_todo_type_config_with_options(union_id, card_type_id, headers, runtime)

    async def get_todo_type_config_async(
        self,
        union_id: str,
        card_type_id: str,
    ) -> dingtalktodo__1__0_models.GetTodoTypeConfigResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.GetTodoTypeConfigHeaders()
        return await self.get_todo_type_config_with_options_async(union_id, card_type_id, headers, runtime)

    def get_todo_type_config_with_options(
        self,
        union_id: str,
        card_type_id: str,
        headers: dingtalktodo__1__0_models.GetTodoTypeConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.GetTodoTypeConfigResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.GetTodoTypeConfigResponse(),
            self.do_roarequest('GetTodoTypeConfig', 'todo_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/todo/users/{union_id}/configs/types/{card_type_id}', 'json', req, runtime)
        )

    async def get_todo_type_config_with_options_async(
        self,
        union_id: str,
        card_type_id: str,
        headers: dingtalktodo__1__0_models.GetTodoTypeConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.GetTodoTypeConfigResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.GetTodoTypeConfigResponse(),
            await self.do_roarequest_async('GetTodoTypeConfig', 'todo_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/todo/users/{union_id}/configs/types/{card_type_id}', 'json', req, runtime)
        )

    def update_todo_type_config(
        self,
        union_id: str,
        card_type_id: str,
        request: dingtalktodo__1__0_models.UpdateTodoTypeConfigRequest,
    ) -> dingtalktodo__1__0_models.UpdateTodoTypeConfigResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.UpdateTodoTypeConfigHeaders()
        return self.update_todo_type_config_with_options(union_id, card_type_id, request, headers, runtime)

    async def update_todo_type_config_async(
        self,
        union_id: str,
        card_type_id: str,
        request: dingtalktodo__1__0_models.UpdateTodoTypeConfigRequest,
    ) -> dingtalktodo__1__0_models.UpdateTodoTypeConfigResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.UpdateTodoTypeConfigHeaders()
        return await self.update_todo_type_config_with_options_async(union_id, card_type_id, request, headers, runtime)

    def update_todo_type_config_with_options(
        self,
        union_id: str,
        card_type_id: str,
        request: dingtalktodo__1__0_models.UpdateTodoTypeConfigRequest,
        headers: dingtalktodo__1__0_models.UpdateTodoTypeConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.UpdateTodoTypeConfigResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.card_type):
            body['cardType'] = request.card_type
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.pc_detail_url_open_mode):
            body['pcDetailUrlOpenMode'] = request.pc_detail_url_open_mode
        if not UtilClient.is_unset(request.content_field_list):
            body['contentFieldList'] = request.content_field_list
        if not UtilClient.is_unset(request.action_list):
            body['actionList'] = request.action_list
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.UpdateTodoTypeConfigResponse(),
            self.do_roarequest('UpdateTodoTypeConfig', 'todo_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/todo/users/{union_id}/configs/types/{card_type_id}', 'json', req, runtime)
        )

    async def update_todo_type_config_with_options_async(
        self,
        union_id: str,
        card_type_id: str,
        request: dingtalktodo__1__0_models.UpdateTodoTypeConfigRequest,
        headers: dingtalktodo__1__0_models.UpdateTodoTypeConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.UpdateTodoTypeConfigResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.card_type):
            body['cardType'] = request.card_type
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.pc_detail_url_open_mode):
            body['pcDetailUrlOpenMode'] = request.pc_detail_url_open_mode
        if not UtilClient.is_unset(request.content_field_list):
            body['contentFieldList'] = request.content_field_list
        if not UtilClient.is_unset(request.action_list):
            body['actionList'] = request.action_list
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.UpdateTodoTypeConfigResponse(),
            await self.do_roarequest_async('UpdateTodoTypeConfig', 'todo_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/todo/users/{union_id}/configs/types/{card_type_id}', 'json', req, runtime)
        )

    def get_todo_task(
        self,
        union_id: str,
        task_id: str,
    ) -> dingtalktodo__1__0_models.GetTodoTaskResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.GetTodoTaskHeaders()
        return self.get_todo_task_with_options(union_id, task_id, headers, runtime)

    async def get_todo_task_async(
        self,
        union_id: str,
        task_id: str,
    ) -> dingtalktodo__1__0_models.GetTodoTaskResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.GetTodoTaskHeaders()
        return await self.get_todo_task_with_options_async(union_id, task_id, headers, runtime)

    def get_todo_task_with_options(
        self,
        union_id: str,
        task_id: str,
        headers: dingtalktodo__1__0_models.GetTodoTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.GetTodoTaskResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.GetTodoTaskResponse(),
            self.do_roarequest('GetTodoTask', 'todo_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/todo/users/{union_id}/tasks/{task_id}', 'json', req, runtime)
        )

    async def get_todo_task_with_options_async(
        self,
        union_id: str,
        task_id: str,
        headers: dingtalktodo__1__0_models.GetTodoTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.GetTodoTaskResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.GetTodoTaskResponse(),
            await self.do_roarequest_async('GetTodoTask', 'todo_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/todo/users/{union_id}/tasks/{task_id}', 'json', req, runtime)
        )

    def delete_todo_task(
        self,
        union_id: str,
        task_id: str,
        request: dingtalktodo__1__0_models.DeleteTodoTaskRequest,
    ) -> dingtalktodo__1__0_models.DeleteTodoTaskResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.DeleteTodoTaskHeaders()
        return self.delete_todo_task_with_options(union_id, task_id, request, headers, runtime)

    async def delete_todo_task_async(
        self,
        union_id: str,
        task_id: str,
        request: dingtalktodo__1__0_models.DeleteTodoTaskRequest,
    ) -> dingtalktodo__1__0_models.DeleteTodoTaskResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.DeleteTodoTaskHeaders()
        return await self.delete_todo_task_with_options_async(union_id, task_id, request, headers, runtime)

    def delete_todo_task_with_options(
        self,
        union_id: str,
        task_id: str,
        request: dingtalktodo__1__0_models.DeleteTodoTaskRequest,
        headers: dingtalktodo__1__0_models.DeleteTodoTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.DeleteTodoTaskResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.DeleteTodoTaskResponse(),
            self.do_roarequest('DeleteTodoTask', 'todo_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/todo/users/{union_id}/tasks/{task_id}', 'json', req, runtime)
        )

    async def delete_todo_task_with_options_async(
        self,
        union_id: str,
        task_id: str,
        request: dingtalktodo__1__0_models.DeleteTodoTaskRequest,
        headers: dingtalktodo__1__0_models.DeleteTodoTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.DeleteTodoTaskResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.DeleteTodoTaskResponse(),
            await self.do_roarequest_async('DeleteTodoTask', 'todo_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/todo/users/{union_id}/tasks/{task_id}', 'json', req, runtime)
        )

    def create_todo_type_config(
        self,
        union_id: str,
        request: dingtalktodo__1__0_models.CreateTodoTypeConfigRequest,
    ) -> dingtalktodo__1__0_models.CreateTodoTypeConfigResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.CreateTodoTypeConfigHeaders()
        return self.create_todo_type_config_with_options(union_id, request, headers, runtime)

    async def create_todo_type_config_async(
        self,
        union_id: str,
        request: dingtalktodo__1__0_models.CreateTodoTypeConfigRequest,
    ) -> dingtalktodo__1__0_models.CreateTodoTypeConfigResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.CreateTodoTypeConfigHeaders()
        return await self.create_todo_type_config_with_options_async(union_id, request, headers, runtime)

    def create_todo_type_config_with_options(
        self,
        union_id: str,
        request: dingtalktodo__1__0_models.CreateTodoTypeConfigRequest,
        headers: dingtalktodo__1__0_models.CreateTodoTypeConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.CreateTodoTypeConfigResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.card_type):
            body['cardType'] = request.card_type
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.pc_detail_url_open_mode):
            body['pcDetailUrlOpenMode'] = request.pc_detail_url_open_mode
        if not UtilClient.is_unset(request.content_field_list):
            body['contentFieldList'] = request.content_field_list
        if not UtilClient.is_unset(request.action_list):
            body['actionList'] = request.action_list
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.CreateTodoTypeConfigResponse(),
            self.do_roarequest('CreateTodoTypeConfig', 'todo_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/todo/users/{union_id}/configs/types', 'json', req, runtime)
        )

    async def create_todo_type_config_with_options_async(
        self,
        union_id: str,
        request: dingtalktodo__1__0_models.CreateTodoTypeConfigRequest,
        headers: dingtalktodo__1__0_models.CreateTodoTypeConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.CreateTodoTypeConfigResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.card_type):
            body['cardType'] = request.card_type
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.pc_detail_url_open_mode):
            body['pcDetailUrlOpenMode'] = request.pc_detail_url_open_mode
        if not UtilClient.is_unset(request.content_field_list):
            body['contentFieldList'] = request.content_field_list
        if not UtilClient.is_unset(request.action_list):
            body['actionList'] = request.action_list
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.CreateTodoTypeConfigResponse(),
            await self.do_roarequest_async('CreateTodoTypeConfig', 'todo_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/todo/users/{union_id}/configs/types', 'json', req, runtime)
        )

    def update_todo_task(
        self,
        union_id: str,
        task_id: str,
        request: dingtalktodo__1__0_models.UpdateTodoTaskRequest,
    ) -> dingtalktodo__1__0_models.UpdateTodoTaskResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.UpdateTodoTaskHeaders()
        return self.update_todo_task_with_options(union_id, task_id, request, headers, runtime)

    async def update_todo_task_async(
        self,
        union_id: str,
        task_id: str,
        request: dingtalktodo__1__0_models.UpdateTodoTaskRequest,
    ) -> dingtalktodo__1__0_models.UpdateTodoTaskResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.UpdateTodoTaskHeaders()
        return await self.update_todo_task_with_options_async(union_id, task_id, request, headers, runtime)

    def update_todo_task_with_options(
        self,
        union_id: str,
        task_id: str,
        request: dingtalktodo__1__0_models.UpdateTodoTaskRequest,
        headers: dingtalktodo__1__0_models.UpdateTodoTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.UpdateTodoTaskResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.subject):
            body['subject'] = request.subject
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.due_time):
            body['dueTime'] = request.due_time
        if not UtilClient.is_unset(request.done):
            body['done'] = request.done
        if not UtilClient.is_unset(request.executor_ids):
            body['executorIds'] = request.executor_ids
        if not UtilClient.is_unset(request.participant_ids):
            body['participantIds'] = request.participant_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.UpdateTodoTaskResponse(),
            self.do_roarequest('UpdateTodoTask', 'todo_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/todo/users/{union_id}/tasks/{task_id}', 'json', req, runtime)
        )

    async def update_todo_task_with_options_async(
        self,
        union_id: str,
        task_id: str,
        request: dingtalktodo__1__0_models.UpdateTodoTaskRequest,
        headers: dingtalktodo__1__0_models.UpdateTodoTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.UpdateTodoTaskResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.subject):
            body['subject'] = request.subject
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.due_time):
            body['dueTime'] = request.due_time
        if not UtilClient.is_unset(request.done):
            body['done'] = request.done
        if not UtilClient.is_unset(request.executor_ids):
            body['executorIds'] = request.executor_ids
        if not UtilClient.is_unset(request.participant_ids):
            body['participantIds'] = request.participant_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.UpdateTodoTaskResponse(),
            await self.do_roarequest_async('UpdateTodoTask', 'todo_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/todo/users/{union_id}/tasks/{task_id}', 'json', req, runtime)
        )

    def create_todo_task(
        self,
        union_id: str,
        request: dingtalktodo__1__0_models.CreateTodoTaskRequest,
    ) -> dingtalktodo__1__0_models.CreateTodoTaskResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.CreateTodoTaskHeaders()
        return self.create_todo_task_with_options(union_id, request, headers, runtime)

    async def create_todo_task_async(
        self,
        union_id: str,
        request: dingtalktodo__1__0_models.CreateTodoTaskRequest,
    ) -> dingtalktodo__1__0_models.CreateTodoTaskResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo__1__0_models.CreateTodoTaskHeaders()
        return await self.create_todo_task_with_options_async(union_id, request, headers, runtime)

    def create_todo_task_with_options(
        self,
        union_id: str,
        request: dingtalktodo__1__0_models.CreateTodoTaskRequest,
        headers: dingtalktodo__1__0_models.CreateTodoTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.CreateTodoTaskResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.source_id):
            body['sourceId'] = request.source_id
        if not UtilClient.is_unset(request.subject):
            body['subject'] = request.subject
        if not UtilClient.is_unset(request.creator_id):
            body['creatorId'] = request.creator_id
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.due_time):
            body['dueTime'] = request.due_time
        if not UtilClient.is_unset(request.executor_ids):
            body['executorIds'] = request.executor_ids
        if not UtilClient.is_unset(request.participant_ids):
            body['participantIds'] = request.participant_ids
        if not UtilClient.is_unset(request.detail_url):
            body['detailUrl'] = request.detail_url
        if not UtilClient.is_unset(request.card_type_id):
            body['cardTypeId'] = request.card_type_id
        if not UtilClient.is_unset(request.content_field_list):
            body['contentFieldList'] = request.content_field_list
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.CreateTodoTaskResponse(),
            self.do_roarequest('CreateTodoTask', 'todo_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/todo/users/{union_id}/tasks', 'json', req, runtime)
        )

    async def create_todo_task_with_options_async(
        self,
        union_id: str,
        request: dingtalktodo__1__0_models.CreateTodoTaskRequest,
        headers: dingtalktodo__1__0_models.CreateTodoTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo__1__0_models.CreateTodoTaskResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.source_id):
            body['sourceId'] = request.source_id
        if not UtilClient.is_unset(request.subject):
            body['subject'] = request.subject
        if not UtilClient.is_unset(request.creator_id):
            body['creatorId'] = request.creator_id
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.due_time):
            body['dueTime'] = request.due_time
        if not UtilClient.is_unset(request.executor_ids):
            body['executorIds'] = request.executor_ids
        if not UtilClient.is_unset(request.participant_ids):
            body['participantIds'] = request.participant_ids
        if not UtilClient.is_unset(request.detail_url):
            body['detailUrl'] = request.detail_url
        if not UtilClient.is_unset(request.card_type_id):
            body['cardTypeId'] = request.card_type_id
        if not UtilClient.is_unset(request.content_field_list):
            body['contentFieldList'] = request.content_field_list
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalktodo__1__0_models.CreateTodoTaskResponse(),
            await self.do_roarequest_async('CreateTodoTask', 'todo_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/todo/users/{union_id}/tasks', 'json', req, runtime)
        )
