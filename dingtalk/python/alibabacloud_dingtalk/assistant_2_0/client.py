# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.assistant_2_0 import models as dingtalkassistant__2__0_models
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

    def create_assistant_message_with_options(
        self,
        thread_id: str,
        request: dingtalkassistant__2__0_models.CreateAssistantMessageRequest,
        headers: dingtalkassistant__2__0_models.CreateAssistantMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__2__0_models.CreateAssistantMessageResponse:
        """
        @summary 创建AI助理的消息体
        
        @param request: CreateAssistantMessageRequest
        @param headers: CreateAssistantMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateAssistantMessageResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.content):
            query['content'] = request.content
        if not UtilClient.is_unset(request.role):
            query['role'] = request.role
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
            action='CreateAssistantMessage',
            version='assistant_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/assistant/threads/{thread_id}/messages',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__2__0_models.CreateAssistantMessageResponse(),
            self.execute(params, req, runtime)
        )

    async def create_assistant_message_with_options_async(
        self,
        thread_id: str,
        request: dingtalkassistant__2__0_models.CreateAssistantMessageRequest,
        headers: dingtalkassistant__2__0_models.CreateAssistantMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__2__0_models.CreateAssistantMessageResponse:
        """
        @summary 创建AI助理的消息体
        
        @param request: CreateAssistantMessageRequest
        @param headers: CreateAssistantMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateAssistantMessageResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.content):
            query['content'] = request.content
        if not UtilClient.is_unset(request.role):
            query['role'] = request.role
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
            action='CreateAssistantMessage',
            version='assistant_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/assistant/threads/{thread_id}/messages',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__2__0_models.CreateAssistantMessageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_assistant_message(
        self,
        thread_id: str,
        request: dingtalkassistant__2__0_models.CreateAssistantMessageRequest,
    ) -> dingtalkassistant__2__0_models.CreateAssistantMessageResponse:
        """
        @summary 创建AI助理的消息体
        
        @param request: CreateAssistantMessageRequest
        @return: CreateAssistantMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__2__0_models.CreateAssistantMessageHeaders()
        return self.create_assistant_message_with_options(thread_id, request, headers, runtime)

    async def create_assistant_message_async(
        self,
        thread_id: str,
        request: dingtalkassistant__2__0_models.CreateAssistantMessageRequest,
    ) -> dingtalkassistant__2__0_models.CreateAssistantMessageResponse:
        """
        @summary 创建AI助理的消息体
        
        @param request: CreateAssistantMessageRequest
        @return: CreateAssistantMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__2__0_models.CreateAssistantMessageHeaders()
        return await self.create_assistant_message_with_options_async(thread_id, request, headers, runtime)

    def create_assistant_run_with_options(
        self,
        thread_id: str,
        headers: dingtalkassistant__2__0_models.CreateAssistantRunHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__2__0_models.CreateAssistantRunResponse:
        """
        @summary 创建AI助理的运行任务
        
        @param headers: CreateAssistantRunHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateAssistantRunResponse
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
            action='CreateAssistantRun',
            version='assistant_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/assistant/threads/{thread_id}/runs',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__2__0_models.CreateAssistantRunResponse(),
            self.execute(params, req, runtime)
        )

    async def create_assistant_run_with_options_async(
        self,
        thread_id: str,
        headers: dingtalkassistant__2__0_models.CreateAssistantRunHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__2__0_models.CreateAssistantRunResponse:
        """
        @summary 创建AI助理的运行任务
        
        @param headers: CreateAssistantRunHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateAssistantRunResponse
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
            action='CreateAssistantRun',
            version='assistant_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/assistant/threads/{thread_id}/runs',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__2__0_models.CreateAssistantRunResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_assistant_run(
        self,
        thread_id: str,
    ) -> dingtalkassistant__2__0_models.CreateAssistantRunResponse:
        """
        @summary 创建AI助理的运行任务
        
        @return: CreateAssistantRunResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__2__0_models.CreateAssistantRunHeaders()
        return self.create_assistant_run_with_options(thread_id, headers, runtime)

    async def create_assistant_run_async(
        self,
        thread_id: str,
    ) -> dingtalkassistant__2__0_models.CreateAssistantRunResponse:
        """
        @summary 创建AI助理的运行任务
        
        @return: CreateAssistantRunResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__2__0_models.CreateAssistantRunHeaders()
        return await self.create_assistant_run_with_options_async(thread_id, headers, runtime)

    def create_assistant_thread_with_options(
        self,
        headers: dingtalkassistant__2__0_models.CreateAssistantThreadHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__2__0_models.CreateAssistantThreadResponse:
        """
        @summary 创建AI助理线程实例
        
        @param headers: CreateAssistantThreadHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateAssistantThreadResponse
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
            action='CreateAssistantThread',
            version='assistant_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/assistant/threads',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__2__0_models.CreateAssistantThreadResponse(),
            self.execute(params, req, runtime)
        )

    async def create_assistant_thread_with_options_async(
        self,
        headers: dingtalkassistant__2__0_models.CreateAssistantThreadHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__2__0_models.CreateAssistantThreadResponse:
        """
        @summary 创建AI助理线程实例
        
        @param headers: CreateAssistantThreadHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateAssistantThreadResponse
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
            action='CreateAssistantThread',
            version='assistant_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/assistant/threads',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__2__0_models.CreateAssistantThreadResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_assistant_thread(self) -> dingtalkassistant__2__0_models.CreateAssistantThreadResponse:
        """
        @summary 创建AI助理线程实例
        
        @return: CreateAssistantThreadResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__2__0_models.CreateAssistantThreadHeaders()
        return self.create_assistant_thread_with_options(headers, runtime)

    async def create_assistant_thread_async(self) -> dingtalkassistant__2__0_models.CreateAssistantThreadResponse:
        """
        @summary 创建AI助理线程实例
        
        @return: CreateAssistantThreadResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__2__0_models.CreateAssistantThreadHeaders()
        return await self.create_assistant_thread_with_options_async(headers, runtime)

    def delete_assistant_message_with_options(
        self,
        thread_id: str,
        message_id: str,
        headers: dingtalkassistant__2__0_models.DeleteAssistantMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__2__0_models.DeleteAssistantMessageResponse:
        """
        @summary 删除AI助理的消息体
        
        @param headers: DeleteAssistantMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteAssistantMessageResponse
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
            action='DeleteAssistantMessage',
            version='assistant_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/assistant/threads/{thread_id}/messages/{message_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__2__0_models.DeleteAssistantMessageResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_assistant_message_with_options_async(
        self,
        thread_id: str,
        message_id: str,
        headers: dingtalkassistant__2__0_models.DeleteAssistantMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__2__0_models.DeleteAssistantMessageResponse:
        """
        @summary 删除AI助理的消息体
        
        @param headers: DeleteAssistantMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteAssistantMessageResponse
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
            action='DeleteAssistantMessage',
            version='assistant_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/assistant/threads/{thread_id}/messages/{message_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__2__0_models.DeleteAssistantMessageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_assistant_message(
        self,
        thread_id: str,
        message_id: str,
    ) -> dingtalkassistant__2__0_models.DeleteAssistantMessageResponse:
        """
        @summary 删除AI助理的消息体
        
        @return: DeleteAssistantMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__2__0_models.DeleteAssistantMessageHeaders()
        return self.delete_assistant_message_with_options(thread_id, message_id, headers, runtime)

    async def delete_assistant_message_async(
        self,
        thread_id: str,
        message_id: str,
    ) -> dingtalkassistant__2__0_models.DeleteAssistantMessageResponse:
        """
        @summary 删除AI助理的消息体
        
        @return: DeleteAssistantMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__2__0_models.DeleteAssistantMessageHeaders()
        return await self.delete_assistant_message_with_options_async(thread_id, message_id, headers, runtime)

    def delete_assistant_thread_with_options(
        self,
        thread_id: str,
        headers: dingtalkassistant__2__0_models.DeleteAssistantThreadHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__2__0_models.DeleteAssistantThreadResponse:
        """
        @summary 删除AI助理线程实例
        
        @param headers: DeleteAssistantThreadHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteAssistantThreadResponse
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
            action='DeleteAssistantThread',
            version='assistant_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/assistant/threads/{thread_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__2__0_models.DeleteAssistantThreadResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_assistant_thread_with_options_async(
        self,
        thread_id: str,
        headers: dingtalkassistant__2__0_models.DeleteAssistantThreadHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__2__0_models.DeleteAssistantThreadResponse:
        """
        @summary 删除AI助理线程实例
        
        @param headers: DeleteAssistantThreadHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteAssistantThreadResponse
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
            action='DeleteAssistantThread',
            version='assistant_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/assistant/threads/{thread_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__2__0_models.DeleteAssistantThreadResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_assistant_thread(
        self,
        thread_id: str,
    ) -> dingtalkassistant__2__0_models.DeleteAssistantThreadResponse:
        """
        @summary 删除AI助理线程实例
        
        @return: DeleteAssistantThreadResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__2__0_models.DeleteAssistantThreadHeaders()
        return self.delete_assistant_thread_with_options(thread_id, headers, runtime)

    async def delete_assistant_thread_async(
        self,
        thread_id: str,
    ) -> dingtalkassistant__2__0_models.DeleteAssistantThreadResponse:
        """
        @summary 删除AI助理线程实例
        
        @return: DeleteAssistantThreadResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__2__0_models.DeleteAssistantThreadHeaders()
        return await self.delete_assistant_thread_with_options_async(thread_id, headers, runtime)

    def list_assistant_message_with_options(
        self,
        thread_id: str,
        request: dingtalkassistant__2__0_models.ListAssistantMessageRequest,
        headers: dingtalkassistant__2__0_models.ListAssistantMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__2__0_models.ListAssistantMessageResponse:
        """
        @summary 获取AI助理消息列表
        
        @param request: ListAssistantMessageRequest
        @param headers: ListAssistantMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListAssistantMessageResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.limit):
            query['limit'] = request.limit
        if not UtilClient.is_unset(request.run_id):
            query['runId'] = request.run_id
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
            action='ListAssistantMessage',
            version='assistant_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/assistant/threads/{thread_id}/messages',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__2__0_models.ListAssistantMessageResponse(),
            self.execute(params, req, runtime)
        )

    async def list_assistant_message_with_options_async(
        self,
        thread_id: str,
        request: dingtalkassistant__2__0_models.ListAssistantMessageRequest,
        headers: dingtalkassistant__2__0_models.ListAssistantMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__2__0_models.ListAssistantMessageResponse:
        """
        @summary 获取AI助理消息列表
        
        @param request: ListAssistantMessageRequest
        @param headers: ListAssistantMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListAssistantMessageResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.limit):
            query['limit'] = request.limit
        if not UtilClient.is_unset(request.run_id):
            query['runId'] = request.run_id
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
            action='ListAssistantMessage',
            version='assistant_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/assistant/threads/{thread_id}/messages',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__2__0_models.ListAssistantMessageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_assistant_message(
        self,
        thread_id: str,
        request: dingtalkassistant__2__0_models.ListAssistantMessageRequest,
    ) -> dingtalkassistant__2__0_models.ListAssistantMessageResponse:
        """
        @summary 获取AI助理消息列表
        
        @param request: ListAssistantMessageRequest
        @return: ListAssistantMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__2__0_models.ListAssistantMessageHeaders()
        return self.list_assistant_message_with_options(thread_id, request, headers, runtime)

    async def list_assistant_message_async(
        self,
        thread_id: str,
        request: dingtalkassistant__2__0_models.ListAssistantMessageRequest,
    ) -> dingtalkassistant__2__0_models.ListAssistantMessageResponse:
        """
        @summary 获取AI助理消息列表
        
        @param request: ListAssistantMessageRequest
        @return: ListAssistantMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__2__0_models.ListAssistantMessageHeaders()
        return await self.list_assistant_message_with_options_async(thread_id, request, headers, runtime)

    def retrieve_assistant_message_with_options(
        self,
        thread_id: str,
        message_id: str,
        headers: dingtalkassistant__2__0_models.RetrieveAssistantMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__2__0_models.RetrieveAssistantMessageResponse:
        """
        @summary 获取AI助理的消息体
        
        @param headers: RetrieveAssistantMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RetrieveAssistantMessageResponse
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
            action='RetrieveAssistantMessage',
            version='assistant_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/assistant/threads/{thread_id}/messages/{message_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__2__0_models.RetrieveAssistantMessageResponse(),
            self.execute(params, req, runtime)
        )

    async def retrieve_assistant_message_with_options_async(
        self,
        thread_id: str,
        message_id: str,
        headers: dingtalkassistant__2__0_models.RetrieveAssistantMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__2__0_models.RetrieveAssistantMessageResponse:
        """
        @summary 获取AI助理的消息体
        
        @param headers: RetrieveAssistantMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RetrieveAssistantMessageResponse
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
            action='RetrieveAssistantMessage',
            version='assistant_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/assistant/threads/{thread_id}/messages/{message_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__2__0_models.RetrieveAssistantMessageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def retrieve_assistant_message(
        self,
        thread_id: str,
        message_id: str,
    ) -> dingtalkassistant__2__0_models.RetrieveAssistantMessageResponse:
        """
        @summary 获取AI助理的消息体
        
        @return: RetrieveAssistantMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__2__0_models.RetrieveAssistantMessageHeaders()
        return self.retrieve_assistant_message_with_options(thread_id, message_id, headers, runtime)

    async def retrieve_assistant_message_async(
        self,
        thread_id: str,
        message_id: str,
    ) -> dingtalkassistant__2__0_models.RetrieveAssistantMessageResponse:
        """
        @summary 获取AI助理的消息体
        
        @return: RetrieveAssistantMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__2__0_models.RetrieveAssistantMessageHeaders()
        return await self.retrieve_assistant_message_with_options_async(thread_id, message_id, headers, runtime)

    def retrieve_assistant_thread_with_options(
        self,
        thread_id: str,
        headers: dingtalkassistant__2__0_models.RetrieveAssistantThreadHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__2__0_models.RetrieveAssistantThreadResponse:
        """
        @summary 检索AI助理线程实例
        
        @param headers: RetrieveAssistantThreadHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RetrieveAssistantThreadResponse
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
            action='RetrieveAssistantThread',
            version='assistant_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/assistant/threads/{thread_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__2__0_models.RetrieveAssistantThreadResponse(),
            self.execute(params, req, runtime)
        )

    async def retrieve_assistant_thread_with_options_async(
        self,
        thread_id: str,
        headers: dingtalkassistant__2__0_models.RetrieveAssistantThreadHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__2__0_models.RetrieveAssistantThreadResponse:
        """
        @summary 检索AI助理线程实例
        
        @param headers: RetrieveAssistantThreadHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RetrieveAssistantThreadResponse
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
            action='RetrieveAssistantThread',
            version='assistant_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/assistant/threads/{thread_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__2__0_models.RetrieveAssistantThreadResponse(),
            await self.execute_async(params, req, runtime)
        )

    def retrieve_assistant_thread(
        self,
        thread_id: str,
    ) -> dingtalkassistant__2__0_models.RetrieveAssistantThreadResponse:
        """
        @summary 检索AI助理线程实例
        
        @return: RetrieveAssistantThreadResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__2__0_models.RetrieveAssistantThreadHeaders()
        return self.retrieve_assistant_thread_with_options(thread_id, headers, runtime)

    async def retrieve_assistant_thread_async(
        self,
        thread_id: str,
    ) -> dingtalkassistant__2__0_models.RetrieveAssistantThreadResponse:
        """
        @summary 检索AI助理线程实例
        
        @return: RetrieveAssistantThreadResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__2__0_models.RetrieveAssistantThreadHeaders()
        return await self.retrieve_assistant_thread_with_options_async(thread_id, headers, runtime)
