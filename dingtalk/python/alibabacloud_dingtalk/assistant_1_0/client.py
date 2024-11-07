# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.assistant_1_0 import models as dingtalkassistant__1__0_models
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

    def add_domain_words_with_options(
        self,
        request: dingtalkassistant__1__0_models.AddDomainWordsRequest,
        headers: dingtalkassistant__1__0_models.AddDomainWordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.AddDomainWordsResponse:
        """
        @summary 助理添加专业词汇
        
        @param request: AddDomainWordsRequest
        @param headers: AddDomainWordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddDomainWordsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.assistant_id):
            body['assistantId'] = request.assistant_id
        if not UtilClient.is_unset(request.domain_words):
            body['domainWords'] = request.domain_words
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
            action='AddDomainWords',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/domainWords',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.AddDomainWordsResponse(),
            self.execute(params, req, runtime)
        )

    async def add_domain_words_with_options_async(
        self,
        request: dingtalkassistant__1__0_models.AddDomainWordsRequest,
        headers: dingtalkassistant__1__0_models.AddDomainWordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.AddDomainWordsResponse:
        """
        @summary 助理添加专业词汇
        
        @param request: AddDomainWordsRequest
        @param headers: AddDomainWordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddDomainWordsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.assistant_id):
            body['assistantId'] = request.assistant_id
        if not UtilClient.is_unset(request.domain_words):
            body['domainWords'] = request.domain_words
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
            action='AddDomainWords',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/domainWords',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.AddDomainWordsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_domain_words(
        self,
        request: dingtalkassistant__1__0_models.AddDomainWordsRequest,
    ) -> dingtalkassistant__1__0_models.AddDomainWordsResponse:
        """
        @summary 助理添加专业词汇
        
        @param request: AddDomainWordsRequest
        @return: AddDomainWordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.AddDomainWordsHeaders()
        return self.add_domain_words_with_options(request, headers, runtime)

    async def add_domain_words_async(
        self,
        request: dingtalkassistant__1__0_models.AddDomainWordsRequest,
    ) -> dingtalkassistant__1__0_models.AddDomainWordsResponse:
        """
        @summary 助理添加专业词汇
        
        @param request: AddDomainWordsRequest
        @return: AddDomainWordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.AddDomainWordsHeaders()
        return await self.add_domain_words_with_options_async(request, headers, runtime)

    def create_assistant_with_options(
        self,
        request: dingtalkassistant__1__0_models.CreateAssistantRequest,
        headers: dingtalkassistant__1__0_models.CreateAssistantHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.CreateAssistantResponse:
        """
        @summary 创建AI助理
        
        @param request: CreateAssistantRequest
        @param headers: CreateAssistantHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateAssistantResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.custom_agent_mobile_link):
            body['customAgentMobileLink'] = request.custom_agent_mobile_link
        if not UtilClient.is_unset(request.custom_agent_pclink):
            body['customAgentPCLink'] = request.custom_agent_pclink
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.instructions):
            body['instructions'] = request.instructions
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.operator_union_id):
            body['operatorUnionId'] = request.operator_union_id
        if not UtilClient.is_unset(request.recommend_prompts):
            body['recommendPrompts'] = request.recommend_prompts
        if not UtilClient.is_unset(request.welcome_content):
            body['welcomeContent'] = request.welcome_content
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
            action='CreateAssistant',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/basicInfo',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.CreateAssistantResponse(),
            self.execute(params, req, runtime)
        )

    async def create_assistant_with_options_async(
        self,
        request: dingtalkassistant__1__0_models.CreateAssistantRequest,
        headers: dingtalkassistant__1__0_models.CreateAssistantHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.CreateAssistantResponse:
        """
        @summary 创建AI助理
        
        @param request: CreateAssistantRequest
        @param headers: CreateAssistantHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateAssistantResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.custom_agent_mobile_link):
            body['customAgentMobileLink'] = request.custom_agent_mobile_link
        if not UtilClient.is_unset(request.custom_agent_pclink):
            body['customAgentPCLink'] = request.custom_agent_pclink
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.instructions):
            body['instructions'] = request.instructions
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.operator_union_id):
            body['operatorUnionId'] = request.operator_union_id
        if not UtilClient.is_unset(request.recommend_prompts):
            body['recommendPrompts'] = request.recommend_prompts
        if not UtilClient.is_unset(request.welcome_content):
            body['welcomeContent'] = request.welcome_content
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
            action='CreateAssistant',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/basicInfo',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.CreateAssistantResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_assistant(
        self,
        request: dingtalkassistant__1__0_models.CreateAssistantRequest,
    ) -> dingtalkassistant__1__0_models.CreateAssistantResponse:
        """
        @summary 创建AI助理
        
        @param request: CreateAssistantRequest
        @return: CreateAssistantResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.CreateAssistantHeaders()
        return self.create_assistant_with_options(request, headers, runtime)

    async def create_assistant_async(
        self,
        request: dingtalkassistant__1__0_models.CreateAssistantRequest,
    ) -> dingtalkassistant__1__0_models.CreateAssistantResponse:
        """
        @summary 创建AI助理
        
        @param request: CreateAssistantRequest
        @return: CreateAssistantResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.CreateAssistantHeaders()
        return await self.create_assistant_with_options_async(request, headers, runtime)

    def create_assistant_message_with_options(
        self,
        thread_id: str,
        request: dingtalkassistant__1__0_models.CreateAssistantMessageRequest,
        headers: dingtalkassistant__1__0_models.CreateAssistantMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.CreateAssistantMessageResponse:
        """
        @summary 创建AI助理的消息体
        
        @param request: CreateAssistantMessageRequest
        @param headers: CreateAssistantMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateAssistantMessageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.metadata):
            body['metadata'] = request.metadata
        if not UtilClient.is_unset(request.role):
            body['role'] = request.role
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
            action='CreateAssistantMessage',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/threads/{thread_id}/messages',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.CreateAssistantMessageResponse(),
            self.execute(params, req, runtime)
        )

    async def create_assistant_message_with_options_async(
        self,
        thread_id: str,
        request: dingtalkassistant__1__0_models.CreateAssistantMessageRequest,
        headers: dingtalkassistant__1__0_models.CreateAssistantMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.CreateAssistantMessageResponse:
        """
        @summary 创建AI助理的消息体
        
        @param request: CreateAssistantMessageRequest
        @param headers: CreateAssistantMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateAssistantMessageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.metadata):
            body['metadata'] = request.metadata
        if not UtilClient.is_unset(request.role):
            body['role'] = request.role
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
            action='CreateAssistantMessage',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/threads/{thread_id}/messages',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.CreateAssistantMessageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_assistant_message(
        self,
        thread_id: str,
        request: dingtalkassistant__1__0_models.CreateAssistantMessageRequest,
    ) -> dingtalkassistant__1__0_models.CreateAssistantMessageResponse:
        """
        @summary 创建AI助理的消息体
        
        @param request: CreateAssistantMessageRequest
        @return: CreateAssistantMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.CreateAssistantMessageHeaders()
        return self.create_assistant_message_with_options(thread_id, request, headers, runtime)

    async def create_assistant_message_async(
        self,
        thread_id: str,
        request: dingtalkassistant__1__0_models.CreateAssistantMessageRequest,
    ) -> dingtalkassistant__1__0_models.CreateAssistantMessageResponse:
        """
        @summary 创建AI助理的消息体
        
        @param request: CreateAssistantMessageRequest
        @return: CreateAssistantMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.CreateAssistantMessageHeaders()
        return await self.create_assistant_message_with_options_async(thread_id, request, headers, runtime)

    def create_assistant_run_with_options(
        self,
        thread_id: str,
        request: dingtalkassistant__1__0_models.CreateAssistantRunRequest,
        headers: dingtalkassistant__1__0_models.CreateAssistantRunHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.CreateAssistantRunResponse:
        """
        @summary 创建AI助理的运行任务
        
        @param request: CreateAssistantRunRequest
        @param headers: CreateAssistantRunHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateAssistantRunResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.assistant_id):
            body['assistantId'] = request.assistant_id
        if not UtilClient.is_unset(request.instructions):
            body['instructions'] = request.instructions
        if not UtilClient.is_unset(request.metadata):
            body['metadata'] = request.metadata
        if not UtilClient.is_unset(request.stream):
            body['stream'] = request.stream
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
            action='CreateAssistantRun',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/threads/{thread_id}/runs',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.CreateAssistantRunResponse(),
            self.execute(params, req, runtime)
        )

    async def create_assistant_run_with_options_async(
        self,
        thread_id: str,
        request: dingtalkassistant__1__0_models.CreateAssistantRunRequest,
        headers: dingtalkassistant__1__0_models.CreateAssistantRunHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.CreateAssistantRunResponse:
        """
        @summary 创建AI助理的运行任务
        
        @param request: CreateAssistantRunRequest
        @param headers: CreateAssistantRunHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateAssistantRunResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.assistant_id):
            body['assistantId'] = request.assistant_id
        if not UtilClient.is_unset(request.instructions):
            body['instructions'] = request.instructions
        if not UtilClient.is_unset(request.metadata):
            body['metadata'] = request.metadata
        if not UtilClient.is_unset(request.stream):
            body['stream'] = request.stream
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
            action='CreateAssistantRun',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/threads/{thread_id}/runs',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.CreateAssistantRunResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_assistant_run(
        self,
        thread_id: str,
        request: dingtalkassistant__1__0_models.CreateAssistantRunRequest,
    ) -> dingtalkassistant__1__0_models.CreateAssistantRunResponse:
        """
        @summary 创建AI助理的运行任务
        
        @param request: CreateAssistantRunRequest
        @return: CreateAssistantRunResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.CreateAssistantRunHeaders()
        return self.create_assistant_run_with_options(thread_id, request, headers, runtime)

    async def create_assistant_run_async(
        self,
        thread_id: str,
        request: dingtalkassistant__1__0_models.CreateAssistantRunRequest,
    ) -> dingtalkassistant__1__0_models.CreateAssistantRunResponse:
        """
        @summary 创建AI助理的运行任务
        
        @param request: CreateAssistantRunRequest
        @return: CreateAssistantRunResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.CreateAssistantRunHeaders()
        return await self.create_assistant_run_with_options_async(thread_id, request, headers, runtime)

    def create_assistant_thread_with_options(
        self,
        request: dingtalkassistant__1__0_models.CreateAssistantThreadRequest,
        headers: dingtalkassistant__1__0_models.CreateAssistantThreadHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.CreateAssistantThreadResponse:
        """
        @summary 创建AI助理线程实例
        
        @param request: CreateAssistantThreadRequest
        @param headers: CreateAssistantThreadHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateAssistantThreadResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.metadata):
            body['metadata'] = request.metadata
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
            action='CreateAssistantThread',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/threads',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.CreateAssistantThreadResponse(),
            self.execute(params, req, runtime)
        )

    async def create_assistant_thread_with_options_async(
        self,
        request: dingtalkassistant__1__0_models.CreateAssistantThreadRequest,
        headers: dingtalkassistant__1__0_models.CreateAssistantThreadHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.CreateAssistantThreadResponse:
        """
        @summary 创建AI助理线程实例
        
        @param request: CreateAssistantThreadRequest
        @param headers: CreateAssistantThreadHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateAssistantThreadResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.metadata):
            body['metadata'] = request.metadata
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
            action='CreateAssistantThread',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/threads',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.CreateAssistantThreadResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_assistant_thread(
        self,
        request: dingtalkassistant__1__0_models.CreateAssistantThreadRequest,
    ) -> dingtalkassistant__1__0_models.CreateAssistantThreadResponse:
        """
        @summary 创建AI助理线程实例
        
        @param request: CreateAssistantThreadRequest
        @return: CreateAssistantThreadResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.CreateAssistantThreadHeaders()
        return self.create_assistant_thread_with_options(request, headers, runtime)

    async def create_assistant_thread_async(
        self,
        request: dingtalkassistant__1__0_models.CreateAssistantThreadRequest,
    ) -> dingtalkassistant__1__0_models.CreateAssistantThreadResponse:
        """
        @summary 创建AI助理线程实例
        
        @param request: CreateAssistantThreadRequest
        @return: CreateAssistantThreadResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.CreateAssistantThreadHeaders()
        return await self.create_assistant_thread_with_options_async(request, headers, runtime)

    def delete_assistant_with_options(
        self,
        request: dingtalkassistant__1__0_models.DeleteAssistantRequest,
        headers: dingtalkassistant__1__0_models.DeleteAssistantHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.DeleteAssistantResponse:
        """
        @summary 删除AI助理
        
        @param request: DeleteAssistantRequest
        @param headers: DeleteAssistantHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteAssistantResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.assistant_id):
            query['assistantId'] = request.assistant_id
        if not UtilClient.is_unset(request.operator_union_id):
            query['operatorUnionId'] = request.operator_union_id
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
            action='DeleteAssistant',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/basicInfo',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.DeleteAssistantResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_assistant_with_options_async(
        self,
        request: dingtalkassistant__1__0_models.DeleteAssistantRequest,
        headers: dingtalkassistant__1__0_models.DeleteAssistantHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.DeleteAssistantResponse:
        """
        @summary 删除AI助理
        
        @param request: DeleteAssistantRequest
        @param headers: DeleteAssistantHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteAssistantResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.assistant_id):
            query['assistantId'] = request.assistant_id
        if not UtilClient.is_unset(request.operator_union_id):
            query['operatorUnionId'] = request.operator_union_id
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
            action='DeleteAssistant',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/basicInfo',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.DeleteAssistantResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_assistant(
        self,
        request: dingtalkassistant__1__0_models.DeleteAssistantRequest,
    ) -> dingtalkassistant__1__0_models.DeleteAssistantResponse:
        """
        @summary 删除AI助理
        
        @param request: DeleteAssistantRequest
        @return: DeleteAssistantResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.DeleteAssistantHeaders()
        return self.delete_assistant_with_options(request, headers, runtime)

    async def delete_assistant_async(
        self,
        request: dingtalkassistant__1__0_models.DeleteAssistantRequest,
    ) -> dingtalkassistant__1__0_models.DeleteAssistantResponse:
        """
        @summary 删除AI助理
        
        @param request: DeleteAssistantRequest
        @return: DeleteAssistantResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.DeleteAssistantHeaders()
        return await self.delete_assistant_with_options_async(request, headers, runtime)

    def delete_assistant_message_with_options(
        self,
        thread_id: str,
        message_id: str,
        headers: dingtalkassistant__1__0_models.DeleteAssistantMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.DeleteAssistantMessageResponse:
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
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/threads/{thread_id}/messages/{message_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.DeleteAssistantMessageResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_assistant_message_with_options_async(
        self,
        thread_id: str,
        message_id: str,
        headers: dingtalkassistant__1__0_models.DeleteAssistantMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.DeleteAssistantMessageResponse:
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
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/threads/{thread_id}/messages/{message_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.DeleteAssistantMessageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_assistant_message(
        self,
        thread_id: str,
        message_id: str,
    ) -> dingtalkassistant__1__0_models.DeleteAssistantMessageResponse:
        """
        @summary 删除AI助理的消息体
        
        @return: DeleteAssistantMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.DeleteAssistantMessageHeaders()
        return self.delete_assistant_message_with_options(thread_id, message_id, headers, runtime)

    async def delete_assistant_message_async(
        self,
        thread_id: str,
        message_id: str,
    ) -> dingtalkassistant__1__0_models.DeleteAssistantMessageResponse:
        """
        @summary 删除AI助理的消息体
        
        @return: DeleteAssistantMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.DeleteAssistantMessageHeaders()
        return await self.delete_assistant_message_with_options_async(thread_id, message_id, headers, runtime)

    def delete_assistant_thread_with_options(
        self,
        thread_id: str,
        headers: dingtalkassistant__1__0_models.DeleteAssistantThreadHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.DeleteAssistantThreadResponse:
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
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/threads/{thread_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.DeleteAssistantThreadResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_assistant_thread_with_options_async(
        self,
        thread_id: str,
        headers: dingtalkassistant__1__0_models.DeleteAssistantThreadHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.DeleteAssistantThreadResponse:
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
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/threads/{thread_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.DeleteAssistantThreadResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_assistant_thread(
        self,
        thread_id: str,
    ) -> dingtalkassistant__1__0_models.DeleteAssistantThreadResponse:
        """
        @summary 删除AI助理线程实例
        
        @return: DeleteAssistantThreadResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.DeleteAssistantThreadHeaders()
        return self.delete_assistant_thread_with_options(thread_id, headers, runtime)

    async def delete_assistant_thread_async(
        self,
        thread_id: str,
    ) -> dingtalkassistant__1__0_models.DeleteAssistantThreadResponse:
        """
        @summary 删除AI助理线程实例
        
        @return: DeleteAssistantThreadResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.DeleteAssistantThreadHeaders()
        return await self.delete_assistant_thread_with_options_async(thread_id, headers, runtime)

    def delete_domain_words_with_options(
        self,
        request: dingtalkassistant__1__0_models.DeleteDomainWordsRequest,
        headers: dingtalkassistant__1__0_models.DeleteDomainWordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.DeleteDomainWordsResponse:
        """
        @summary 助理删除专业词汇
        
        @param request: DeleteDomainWordsRequest
        @param headers: DeleteDomainWordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteDomainWordsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.assistant_id):
            body['assistantId'] = request.assistant_id
        if not UtilClient.is_unset(request.domain_words):
            body['domainWords'] = request.domain_words
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
            action='DeleteDomainWords',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/domainWords/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.DeleteDomainWordsResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_domain_words_with_options_async(
        self,
        request: dingtalkassistant__1__0_models.DeleteDomainWordsRequest,
        headers: dingtalkassistant__1__0_models.DeleteDomainWordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.DeleteDomainWordsResponse:
        """
        @summary 助理删除专业词汇
        
        @param request: DeleteDomainWordsRequest
        @param headers: DeleteDomainWordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteDomainWordsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.assistant_id):
            body['assistantId'] = request.assistant_id
        if not UtilClient.is_unset(request.domain_words):
            body['domainWords'] = request.domain_words
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
            action='DeleteDomainWords',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/domainWords/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.DeleteDomainWordsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_domain_words(
        self,
        request: dingtalkassistant__1__0_models.DeleteDomainWordsRequest,
    ) -> dingtalkassistant__1__0_models.DeleteDomainWordsResponse:
        """
        @summary 助理删除专业词汇
        
        @param request: DeleteDomainWordsRequest
        @return: DeleteDomainWordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.DeleteDomainWordsHeaders()
        return self.delete_domain_words_with_options(request, headers, runtime)

    async def delete_domain_words_async(
        self,
        request: dingtalkassistant__1__0_models.DeleteDomainWordsRequest,
    ) -> dingtalkassistant__1__0_models.DeleteDomainWordsResponse:
        """
        @summary 助理删除专业词汇
        
        @param request: DeleteDomainWordsRequest
        @return: DeleteDomainWordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.DeleteDomainWordsHeaders()
        return await self.delete_domain_words_with_options_async(request, headers, runtime)

    def delete_knowledge_with_options(
        self,
        request: dingtalkassistant__1__0_models.DeleteKnowledgeRequest,
        headers: dingtalkassistant__1__0_models.DeleteKnowledgeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.DeleteKnowledgeResponse:
        """
        @summary 删除助理知识
        
        @param request: DeleteKnowledgeRequest
        @param headers: DeleteKnowledgeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteKnowledgeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.assistant_id):
            query['assistantId'] = request.assistant_id
        if not UtilClient.is_unset(request.study_id):
            query['studyId'] = request.study_id
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
            action='DeleteKnowledge',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/knowledges/items',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.DeleteKnowledgeResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_knowledge_with_options_async(
        self,
        request: dingtalkassistant__1__0_models.DeleteKnowledgeRequest,
        headers: dingtalkassistant__1__0_models.DeleteKnowledgeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.DeleteKnowledgeResponse:
        """
        @summary 删除助理知识
        
        @param request: DeleteKnowledgeRequest
        @param headers: DeleteKnowledgeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteKnowledgeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.assistant_id):
            query['assistantId'] = request.assistant_id
        if not UtilClient.is_unset(request.study_id):
            query['studyId'] = request.study_id
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
            action='DeleteKnowledge',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/knowledges/items',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.DeleteKnowledgeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_knowledge(
        self,
        request: dingtalkassistant__1__0_models.DeleteKnowledgeRequest,
    ) -> dingtalkassistant__1__0_models.DeleteKnowledgeResponse:
        """
        @summary 删除助理知识
        
        @param request: DeleteKnowledgeRequest
        @return: DeleteKnowledgeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.DeleteKnowledgeHeaders()
        return self.delete_knowledge_with_options(request, headers, runtime)

    async def delete_knowledge_async(
        self,
        request: dingtalkassistant__1__0_models.DeleteKnowledgeRequest,
    ) -> dingtalkassistant__1__0_models.DeleteKnowledgeResponse:
        """
        @summary 删除助理知识
        
        @param request: DeleteKnowledgeRequest
        @return: DeleteKnowledgeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.DeleteKnowledgeHeaders()
        return await self.delete_knowledge_with_options_async(request, headers, runtime)

    def get_ask_detail_with_options(
        self,
        request: dingtalkassistant__1__0_models.GetAskDetailRequest,
        headers: dingtalkassistant__1__0_models.GetAskDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.GetAskDetailResponse:
        """
        @summary 获取助理问答明细
        
        @param request: GetAskDetailRequest
        @param headers: GetAskDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAskDetailResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.assistant_id):
            query['assistantId'] = request.assistant_id
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.offset):
            query['offset'] = request.offset
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
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
            action='GetAskDetail',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/askDetails',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.GetAskDetailResponse(),
            self.execute(params, req, runtime)
        )

    async def get_ask_detail_with_options_async(
        self,
        request: dingtalkassistant__1__0_models.GetAskDetailRequest,
        headers: dingtalkassistant__1__0_models.GetAskDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.GetAskDetailResponse:
        """
        @summary 获取助理问答明细
        
        @param request: GetAskDetailRequest
        @param headers: GetAskDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAskDetailResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.assistant_id):
            query['assistantId'] = request.assistant_id
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.offset):
            query['offset'] = request.offset
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
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
            action='GetAskDetail',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/askDetails',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.GetAskDetailResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_ask_detail(
        self,
        request: dingtalkassistant__1__0_models.GetAskDetailRequest,
    ) -> dingtalkassistant__1__0_models.GetAskDetailResponse:
        """
        @summary 获取助理问答明细
        
        @param request: GetAskDetailRequest
        @return: GetAskDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.GetAskDetailHeaders()
        return self.get_ask_detail_with_options(request, headers, runtime)

    async def get_ask_detail_async(
        self,
        request: dingtalkassistant__1__0_models.GetAskDetailRequest,
    ) -> dingtalkassistant__1__0_models.GetAskDetailResponse:
        """
        @summary 获取助理问答明细
        
        @param request: GetAskDetailRequest
        @return: GetAskDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.GetAskDetailHeaders()
        return await self.get_ask_detail_with_options_async(request, headers, runtime)

    def get_domain_words_with_options(
        self,
        request: dingtalkassistant__1__0_models.GetDomainWordsRequest,
        headers: dingtalkassistant__1__0_models.GetDomainWordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.GetDomainWordsResponse:
        """
        @summary 获取助理专业词汇
        
        @param request: GetDomainWordsRequest
        @param headers: GetDomainWordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDomainWordsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.assistant_id):
            query['assistantId'] = request.assistant_id
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
            action='GetDomainWords',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/domainWords',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.GetDomainWordsResponse(),
            self.execute(params, req, runtime)
        )

    async def get_domain_words_with_options_async(
        self,
        request: dingtalkassistant__1__0_models.GetDomainWordsRequest,
        headers: dingtalkassistant__1__0_models.GetDomainWordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.GetDomainWordsResponse:
        """
        @summary 获取助理专业词汇
        
        @param request: GetDomainWordsRequest
        @param headers: GetDomainWordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDomainWordsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.assistant_id):
            query['assistantId'] = request.assistant_id
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
            action='GetDomainWords',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/domainWords',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.GetDomainWordsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_domain_words(
        self,
        request: dingtalkassistant__1__0_models.GetDomainWordsRequest,
    ) -> dingtalkassistant__1__0_models.GetDomainWordsResponse:
        """
        @summary 获取助理专业词汇
        
        @param request: GetDomainWordsRequest
        @return: GetDomainWordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.GetDomainWordsHeaders()
        return self.get_domain_words_with_options(request, headers, runtime)

    async def get_domain_words_async(
        self,
        request: dingtalkassistant__1__0_models.GetDomainWordsRequest,
    ) -> dingtalkassistant__1__0_models.GetDomainWordsResponse:
        """
        @summary 获取助理专业词汇
        
        @param request: GetDomainWordsRequest
        @return: GetDomainWordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.GetDomainWordsHeaders()
        return await self.get_domain_words_with_options_async(request, headers, runtime)

    def get_knowledge_list_with_options(
        self,
        request: dingtalkassistant__1__0_models.GetKnowledgeListRequest,
        headers: dingtalkassistant__1__0_models.GetKnowledgeListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.GetKnowledgeListResponse:
        """
        @summary 获取助理知识列表
        
        @param request: GetKnowledgeListRequest
        @param headers: GetKnowledgeListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetKnowledgeListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.assistant_id):
            query['assistantId'] = request.assistant_id
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
            action='GetKnowledgeList',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/knowledges/items',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.GetKnowledgeListResponse(),
            self.execute(params, req, runtime)
        )

    async def get_knowledge_list_with_options_async(
        self,
        request: dingtalkassistant__1__0_models.GetKnowledgeListRequest,
        headers: dingtalkassistant__1__0_models.GetKnowledgeListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.GetKnowledgeListResponse:
        """
        @summary 获取助理知识列表
        
        @param request: GetKnowledgeListRequest
        @param headers: GetKnowledgeListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetKnowledgeListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.assistant_id):
            query['assistantId'] = request.assistant_id
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
            action='GetKnowledgeList',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/knowledges/items',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.GetKnowledgeListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_knowledge_list(
        self,
        request: dingtalkassistant__1__0_models.GetKnowledgeListRequest,
    ) -> dingtalkassistant__1__0_models.GetKnowledgeListResponse:
        """
        @summary 获取助理知识列表
        
        @param request: GetKnowledgeListRequest
        @return: GetKnowledgeListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.GetKnowledgeListHeaders()
        return self.get_knowledge_list_with_options(request, headers, runtime)

    async def get_knowledge_list_async(
        self,
        request: dingtalkassistant__1__0_models.GetKnowledgeListRequest,
    ) -> dingtalkassistant__1__0_models.GetKnowledgeListResponse:
        """
        @summary 获取助理知识列表
        
        @param request: GetKnowledgeListRequest
        @return: GetKnowledgeListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.GetKnowledgeListHeaders()
        return await self.get_knowledge_list_with_options_async(request, headers, runtime)

    def install_assistant_with_options(
        self,
        request: dingtalkassistant__1__0_models.InstallAssistantRequest,
        headers: dingtalkassistant__1__0_models.InstallAssistantHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.InstallAssistantResponse:
        """
        @summary 安装助理
        
        @param request: InstallAssistantRequest
        @param headers: InstallAssistantHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InstallAssistantResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.assistant_id):
            body['assistantId'] = request.assistant_id
        if not UtilClient.is_unset(request.is_all_org_member_visible):
            body['isAllOrgMemberVisible'] = request.is_all_org_member_visible
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
            action='InstallAssistant',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/install',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.InstallAssistantResponse(),
            self.execute(params, req, runtime)
        )

    async def install_assistant_with_options_async(
        self,
        request: dingtalkassistant__1__0_models.InstallAssistantRequest,
        headers: dingtalkassistant__1__0_models.InstallAssistantHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.InstallAssistantResponse:
        """
        @summary 安装助理
        
        @param request: InstallAssistantRequest
        @param headers: InstallAssistantHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InstallAssistantResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.assistant_id):
            body['assistantId'] = request.assistant_id
        if not UtilClient.is_unset(request.is_all_org_member_visible):
            body['isAllOrgMemberVisible'] = request.is_all_org_member_visible
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
            action='InstallAssistant',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/install',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.InstallAssistantResponse(),
            await self.execute_async(params, req, runtime)
        )

    def install_assistant(
        self,
        request: dingtalkassistant__1__0_models.InstallAssistantRequest,
    ) -> dingtalkassistant__1__0_models.InstallAssistantResponse:
        """
        @summary 安装助理
        
        @param request: InstallAssistantRequest
        @return: InstallAssistantResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.InstallAssistantHeaders()
        return self.install_assistant_with_options(request, headers, runtime)

    async def install_assistant_async(
        self,
        request: dingtalkassistant__1__0_models.InstallAssistantRequest,
    ) -> dingtalkassistant__1__0_models.InstallAssistantResponse:
        """
        @summary 安装助理
        
        @param request: InstallAssistantRequest
        @return: InstallAssistantResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.InstallAssistantHeaders()
        return await self.install_assistant_with_options_async(request, headers, runtime)

    def learn_knowledge_with_options(
        self,
        request: dingtalkassistant__1__0_models.LearnKnowledgeRequest,
        headers: dingtalkassistant__1__0_models.LearnKnowledgeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.LearnKnowledgeResponse:
        """
        @summary 助理学习知识
        
        @param request: LearnKnowledgeRequest
        @param headers: LearnKnowledgeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: LearnKnowledgeResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.assistant_id):
            body['assistantId'] = request.assistant_id
        if not UtilClient.is_unset(request.doc_url):
            body['docUrl'] = request.doc_url
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
            action='LearnKnowledge',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/knowledges/items',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.LearnKnowledgeResponse(),
            self.execute(params, req, runtime)
        )

    async def learn_knowledge_with_options_async(
        self,
        request: dingtalkassistant__1__0_models.LearnKnowledgeRequest,
        headers: dingtalkassistant__1__0_models.LearnKnowledgeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.LearnKnowledgeResponse:
        """
        @summary 助理学习知识
        
        @param request: LearnKnowledgeRequest
        @param headers: LearnKnowledgeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: LearnKnowledgeResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.assistant_id):
            body['assistantId'] = request.assistant_id
        if not UtilClient.is_unset(request.doc_url):
            body['docUrl'] = request.doc_url
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
            action='LearnKnowledge',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/knowledges/items',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.LearnKnowledgeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def learn_knowledge(
        self,
        request: dingtalkassistant__1__0_models.LearnKnowledgeRequest,
    ) -> dingtalkassistant__1__0_models.LearnKnowledgeResponse:
        """
        @summary 助理学习知识
        
        @param request: LearnKnowledgeRequest
        @return: LearnKnowledgeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.LearnKnowledgeHeaders()
        return self.learn_knowledge_with_options(request, headers, runtime)

    async def learn_knowledge_async(
        self,
        request: dingtalkassistant__1__0_models.LearnKnowledgeRequest,
    ) -> dingtalkassistant__1__0_models.LearnKnowledgeResponse:
        """
        @summary 助理学习知识
        
        @param request: LearnKnowledgeRequest
        @return: LearnKnowledgeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.LearnKnowledgeHeaders()
        return await self.learn_knowledge_with_options_async(request, headers, runtime)

    def list_assistant_with_options(
        self,
        request: dingtalkassistant__1__0_models.ListAssistantRequest,
        headers: dingtalkassistant__1__0_models.ListAssistantHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.ListAssistantResponse:
        """
        @summary 获取AI助理列表
        
        @param request: ListAssistantRequest
        @param headers: ListAssistantHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListAssistantResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.cursor):
            query['cursor'] = request.cursor
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='ListAssistant',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/list',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.ListAssistantResponse(),
            self.execute(params, req, runtime)
        )

    async def list_assistant_with_options_async(
        self,
        request: dingtalkassistant__1__0_models.ListAssistantRequest,
        headers: dingtalkassistant__1__0_models.ListAssistantHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.ListAssistantResponse:
        """
        @summary 获取AI助理列表
        
        @param request: ListAssistantRequest
        @param headers: ListAssistantHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListAssistantResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.cursor):
            query['cursor'] = request.cursor
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='ListAssistant',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/list',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.ListAssistantResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_assistant(
        self,
        request: dingtalkassistant__1__0_models.ListAssistantRequest,
    ) -> dingtalkassistant__1__0_models.ListAssistantResponse:
        """
        @summary 获取AI助理列表
        
        @param request: ListAssistantRequest
        @return: ListAssistantResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.ListAssistantHeaders()
        return self.list_assistant_with_options(request, headers, runtime)

    async def list_assistant_async(
        self,
        request: dingtalkassistant__1__0_models.ListAssistantRequest,
    ) -> dingtalkassistant__1__0_models.ListAssistantResponse:
        """
        @summary 获取AI助理列表
        
        @param request: ListAssistantRequest
        @return: ListAssistantResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.ListAssistantHeaders()
        return await self.list_assistant_with_options_async(request, headers, runtime)

    def list_assistant_message_with_options(
        self,
        thread_id: str,
        request: dingtalkassistant__1__0_models.ListAssistantMessageRequest,
        headers: dingtalkassistant__1__0_models.ListAssistantMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.ListAssistantMessageResponse:
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
        if not UtilClient.is_unset(request.order):
            query['order'] = request.order
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
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/threads/{thread_id}/messages',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.ListAssistantMessageResponse(),
            self.execute(params, req, runtime)
        )

    async def list_assistant_message_with_options_async(
        self,
        thread_id: str,
        request: dingtalkassistant__1__0_models.ListAssistantMessageRequest,
        headers: dingtalkassistant__1__0_models.ListAssistantMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.ListAssistantMessageResponse:
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
        if not UtilClient.is_unset(request.order):
            query['order'] = request.order
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
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/threads/{thread_id}/messages',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.ListAssistantMessageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_assistant_message(
        self,
        thread_id: str,
        request: dingtalkassistant__1__0_models.ListAssistantMessageRequest,
    ) -> dingtalkassistant__1__0_models.ListAssistantMessageResponse:
        """
        @summary 获取AI助理消息列表
        
        @param request: ListAssistantMessageRequest
        @return: ListAssistantMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.ListAssistantMessageHeaders()
        return self.list_assistant_message_with_options(thread_id, request, headers, runtime)

    async def list_assistant_message_async(
        self,
        thread_id: str,
        request: dingtalkassistant__1__0_models.ListAssistantMessageRequest,
    ) -> dingtalkassistant__1__0_models.ListAssistantMessageResponse:
        """
        @summary 获取AI助理消息列表
        
        @param request: ListAssistantMessageRequest
        @return: ListAssistantMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.ListAssistantMessageHeaders()
        return await self.list_assistant_message_with_options_async(thread_id, request, headers, runtime)

    def list_assistant_run_with_options(
        self,
        thread_id: str,
        request: dingtalkassistant__1__0_models.ListAssistantRunRequest,
        headers: dingtalkassistant__1__0_models.ListAssistantRunHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.ListAssistantRunResponse:
        """
        @summary 获取AI助理的运行任务的列表
        
        @param request: ListAssistantRunRequest
        @param headers: ListAssistantRunHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListAssistantRunResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.limit):
            query['limit'] = request.limit
        if not UtilClient.is_unset(request.order):
            query['order'] = request.order
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
            action='ListAssistantRun',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/threads/{thread_id}/runs',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.ListAssistantRunResponse(),
            self.execute(params, req, runtime)
        )

    async def list_assistant_run_with_options_async(
        self,
        thread_id: str,
        request: dingtalkassistant__1__0_models.ListAssistantRunRequest,
        headers: dingtalkassistant__1__0_models.ListAssistantRunHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.ListAssistantRunResponse:
        """
        @summary 获取AI助理的运行任务的列表
        
        @param request: ListAssistantRunRequest
        @param headers: ListAssistantRunHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListAssistantRunResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.limit):
            query['limit'] = request.limit
        if not UtilClient.is_unset(request.order):
            query['order'] = request.order
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
            action='ListAssistantRun',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/threads/{thread_id}/runs',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.ListAssistantRunResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_assistant_run(
        self,
        thread_id: str,
        request: dingtalkassistant__1__0_models.ListAssistantRunRequest,
    ) -> dingtalkassistant__1__0_models.ListAssistantRunResponse:
        """
        @summary 获取AI助理的运行任务的列表
        
        @param request: ListAssistantRunRequest
        @return: ListAssistantRunResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.ListAssistantRunHeaders()
        return self.list_assistant_run_with_options(thread_id, request, headers, runtime)

    async def list_assistant_run_async(
        self,
        thread_id: str,
        request: dingtalkassistant__1__0_models.ListAssistantRunRequest,
    ) -> dingtalkassistant__1__0_models.ListAssistantRunResponse:
        """
        @summary 获取AI助理的运行任务的列表
        
        @param request: ListAssistantRunRequest
        @return: ListAssistantRunResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.ListAssistantRunHeaders()
        return await self.list_assistant_run_with_options_async(thread_id, request, headers, runtime)

    def list_visible_assistant_with_options(
        self,
        request: dingtalkassistant__1__0_models.ListVisibleAssistantRequest,
        headers: dingtalkassistant__1__0_models.ListVisibleAssistantHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.ListVisibleAssistantResponse:
        """
        @summary 获取用户可见范围的AI助理列表
        
        @param request: ListVisibleAssistantRequest
        @param headers: ListVisibleAssistantHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListVisibleAssistantResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.cursor):
            query['cursor'] = request.cursor
        if not UtilClient.is_unset(request.name):
            query['name'] = request.name
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='ListVisibleAssistant',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/visibleList',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.ListVisibleAssistantResponse(),
            self.execute(params, req, runtime)
        )

    async def list_visible_assistant_with_options_async(
        self,
        request: dingtalkassistant__1__0_models.ListVisibleAssistantRequest,
        headers: dingtalkassistant__1__0_models.ListVisibleAssistantHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.ListVisibleAssistantResponse:
        """
        @summary 获取用户可见范围的AI助理列表
        
        @param request: ListVisibleAssistantRequest
        @param headers: ListVisibleAssistantHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListVisibleAssistantResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.cursor):
            query['cursor'] = request.cursor
        if not UtilClient.is_unset(request.name):
            query['name'] = request.name
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='ListVisibleAssistant',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/visibleList',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.ListVisibleAssistantResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_visible_assistant(
        self,
        request: dingtalkassistant__1__0_models.ListVisibleAssistantRequest,
    ) -> dingtalkassistant__1__0_models.ListVisibleAssistantResponse:
        """
        @summary 获取用户可见范围的AI助理列表
        
        @param request: ListVisibleAssistantRequest
        @return: ListVisibleAssistantResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.ListVisibleAssistantHeaders()
        return self.list_visible_assistant_with_options(request, headers, runtime)

    async def list_visible_assistant_async(
        self,
        request: dingtalkassistant__1__0_models.ListVisibleAssistantRequest,
    ) -> dingtalkassistant__1__0_models.ListVisibleAssistantResponse:
        """
        @summary 获取用户可见范围的AI助理列表
        
        @param request: ListVisibleAssistantRequest
        @return: ListVisibleAssistantResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.ListVisibleAssistantHeaders()
        return await self.list_visible_assistant_with_options_async(request, headers, runtime)

    def relearn_knowledge_with_options(
        self,
        request: dingtalkassistant__1__0_models.RelearnKnowledgeRequest,
        headers: dingtalkassistant__1__0_models.RelearnKnowledgeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.RelearnKnowledgeResponse:
        """
        @summary 助理学习增量知识
        
        @param request: RelearnKnowledgeRequest
        @param headers: RelearnKnowledgeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RelearnKnowledgeResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.assistant_id):
            body['assistantId'] = request.assistant_id
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
            action='RelearnKnowledge',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/knowledges/incrLearning',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.RelearnKnowledgeResponse(),
            self.execute(params, req, runtime)
        )

    async def relearn_knowledge_with_options_async(
        self,
        request: dingtalkassistant__1__0_models.RelearnKnowledgeRequest,
        headers: dingtalkassistant__1__0_models.RelearnKnowledgeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.RelearnKnowledgeResponse:
        """
        @summary 助理学习增量知识
        
        @param request: RelearnKnowledgeRequest
        @param headers: RelearnKnowledgeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RelearnKnowledgeResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.assistant_id):
            body['assistantId'] = request.assistant_id
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
            action='RelearnKnowledge',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/knowledges/incrLearning',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.RelearnKnowledgeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def relearn_knowledge(
        self,
        request: dingtalkassistant__1__0_models.RelearnKnowledgeRequest,
    ) -> dingtalkassistant__1__0_models.RelearnKnowledgeResponse:
        """
        @summary 助理学习增量知识
        
        @param request: RelearnKnowledgeRequest
        @return: RelearnKnowledgeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.RelearnKnowledgeHeaders()
        return self.relearn_knowledge_with_options(request, headers, runtime)

    async def relearn_knowledge_async(
        self,
        request: dingtalkassistant__1__0_models.RelearnKnowledgeRequest,
    ) -> dingtalkassistant__1__0_models.RelearnKnowledgeResponse:
        """
        @summary 助理学习增量知识
        
        @param request: RelearnKnowledgeRequest
        @return: RelearnKnowledgeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.RelearnKnowledgeHeaders()
        return await self.relearn_knowledge_with_options_async(request, headers, runtime)

    def remove_assistant_with_options(
        self,
        request: dingtalkassistant__1__0_models.RemoveAssistantRequest,
        headers: dingtalkassistant__1__0_models.RemoveAssistantHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.RemoveAssistantResponse:
        """
        @summary 卸载助理
        
        @param request: RemoveAssistantRequest
        @param headers: RemoveAssistantHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RemoveAssistantResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.assistant_id):
            body['assistantId'] = request.assistant_id
        if not UtilClient.is_unset(request.operator_union_id):
            body['operatorUnionId'] = request.operator_union_id
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
            action='RemoveAssistant',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/uninstall',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.RemoveAssistantResponse(),
            self.execute(params, req, runtime)
        )

    async def remove_assistant_with_options_async(
        self,
        request: dingtalkassistant__1__0_models.RemoveAssistantRequest,
        headers: dingtalkassistant__1__0_models.RemoveAssistantHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.RemoveAssistantResponse:
        """
        @summary 卸载助理
        
        @param request: RemoveAssistantRequest
        @param headers: RemoveAssistantHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RemoveAssistantResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.assistant_id):
            body['assistantId'] = request.assistant_id
        if not UtilClient.is_unset(request.operator_union_id):
            body['operatorUnionId'] = request.operator_union_id
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
            action='RemoveAssistant',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/uninstall',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.RemoveAssistantResponse(),
            await self.execute_async(params, req, runtime)
        )

    def remove_assistant(
        self,
        request: dingtalkassistant__1__0_models.RemoveAssistantRequest,
    ) -> dingtalkassistant__1__0_models.RemoveAssistantResponse:
        """
        @summary 卸载助理
        
        @param request: RemoveAssistantRequest
        @return: RemoveAssistantResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.RemoveAssistantHeaders()
        return self.remove_assistant_with_options(request, headers, runtime)

    async def remove_assistant_async(
        self,
        request: dingtalkassistant__1__0_models.RemoveAssistantRequest,
    ) -> dingtalkassistant__1__0_models.RemoveAssistantResponse:
        """
        @summary 卸载助理
        
        @param request: RemoveAssistantRequest
        @return: RemoveAssistantResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.RemoveAssistantHeaders()
        return await self.remove_assistant_with_options_async(request, headers, runtime)

    def retrieve_assistant_basic_info_with_options(
        self,
        request: dingtalkassistant__1__0_models.RetrieveAssistantBasicInfoRequest,
        headers: dingtalkassistant__1__0_models.RetrieveAssistantBasicInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.RetrieveAssistantBasicInfoResponse:
        """
        @summary 查询 AI 助理的基本信息
        
        @param request: RetrieveAssistantBasicInfoRequest
        @param headers: RetrieveAssistantBasicInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RetrieveAssistantBasicInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.assistant_id):
            query['assistantId'] = request.assistant_id
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='RetrieveAssistantBasicInfo',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/basicInfo',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.RetrieveAssistantBasicInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def retrieve_assistant_basic_info_with_options_async(
        self,
        request: dingtalkassistant__1__0_models.RetrieveAssistantBasicInfoRequest,
        headers: dingtalkassistant__1__0_models.RetrieveAssistantBasicInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.RetrieveAssistantBasicInfoResponse:
        """
        @summary 查询 AI 助理的基本信息
        
        @param request: RetrieveAssistantBasicInfoRequest
        @param headers: RetrieveAssistantBasicInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RetrieveAssistantBasicInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.assistant_id):
            query['assistantId'] = request.assistant_id
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='RetrieveAssistantBasicInfo',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/basicInfo',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.RetrieveAssistantBasicInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def retrieve_assistant_basic_info(
        self,
        request: dingtalkassistant__1__0_models.RetrieveAssistantBasicInfoRequest,
    ) -> dingtalkassistant__1__0_models.RetrieveAssistantBasicInfoResponse:
        """
        @summary 查询 AI 助理的基本信息
        
        @param request: RetrieveAssistantBasicInfoRequest
        @return: RetrieveAssistantBasicInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.RetrieveAssistantBasicInfoHeaders()
        return self.retrieve_assistant_basic_info_with_options(request, headers, runtime)

    async def retrieve_assistant_basic_info_async(
        self,
        request: dingtalkassistant__1__0_models.RetrieveAssistantBasicInfoRequest,
    ) -> dingtalkassistant__1__0_models.RetrieveAssistantBasicInfoResponse:
        """
        @summary 查询 AI 助理的基本信息
        
        @param request: RetrieveAssistantBasicInfoRequest
        @return: RetrieveAssistantBasicInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.RetrieveAssistantBasicInfoHeaders()
        return await self.retrieve_assistant_basic_info_with_options_async(request, headers, runtime)

    def retrieve_assistant_message_with_options(
        self,
        thread_id: str,
        message_id: str,
        headers: dingtalkassistant__1__0_models.RetrieveAssistantMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.RetrieveAssistantMessageResponse:
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
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/threads/{thread_id}/messages/{message_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.RetrieveAssistantMessageResponse(),
            self.execute(params, req, runtime)
        )

    async def retrieve_assistant_message_with_options_async(
        self,
        thread_id: str,
        message_id: str,
        headers: dingtalkassistant__1__0_models.RetrieveAssistantMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.RetrieveAssistantMessageResponse:
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
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/threads/{thread_id}/messages/{message_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.RetrieveAssistantMessageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def retrieve_assistant_message(
        self,
        thread_id: str,
        message_id: str,
    ) -> dingtalkassistant__1__0_models.RetrieveAssistantMessageResponse:
        """
        @summary 获取AI助理的消息体
        
        @return: RetrieveAssistantMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.RetrieveAssistantMessageHeaders()
        return self.retrieve_assistant_message_with_options(thread_id, message_id, headers, runtime)

    async def retrieve_assistant_message_async(
        self,
        thread_id: str,
        message_id: str,
    ) -> dingtalkassistant__1__0_models.RetrieveAssistantMessageResponse:
        """
        @summary 获取AI助理的消息体
        
        @return: RetrieveAssistantMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.RetrieveAssistantMessageHeaders()
        return await self.retrieve_assistant_message_with_options_async(thread_id, message_id, headers, runtime)

    def retrieve_assistant_run_with_options(
        self,
        thread_id: str,
        run_id: str,
        headers: dingtalkassistant__1__0_models.RetrieveAssistantRunHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.RetrieveAssistantRunResponse:
        """
        @summary 检索AI助理的运行任务
        
        @param headers: RetrieveAssistantRunHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RetrieveAssistantRunResponse
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
            action='RetrieveAssistantRun',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/threads/{thread_id}/runs/{run_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.RetrieveAssistantRunResponse(),
            self.execute(params, req, runtime)
        )

    async def retrieve_assistant_run_with_options_async(
        self,
        thread_id: str,
        run_id: str,
        headers: dingtalkassistant__1__0_models.RetrieveAssistantRunHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.RetrieveAssistantRunResponse:
        """
        @summary 检索AI助理的运行任务
        
        @param headers: RetrieveAssistantRunHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RetrieveAssistantRunResponse
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
            action='RetrieveAssistantRun',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/threads/{thread_id}/runs/{run_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.RetrieveAssistantRunResponse(),
            await self.execute_async(params, req, runtime)
        )

    def retrieve_assistant_run(
        self,
        thread_id: str,
        run_id: str,
    ) -> dingtalkassistant__1__0_models.RetrieveAssistantRunResponse:
        """
        @summary 检索AI助理的运行任务
        
        @return: RetrieveAssistantRunResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.RetrieveAssistantRunHeaders()
        return self.retrieve_assistant_run_with_options(thread_id, run_id, headers, runtime)

    async def retrieve_assistant_run_async(
        self,
        thread_id: str,
        run_id: str,
    ) -> dingtalkassistant__1__0_models.RetrieveAssistantRunResponse:
        """
        @summary 检索AI助理的运行任务
        
        @return: RetrieveAssistantRunResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.RetrieveAssistantRunHeaders()
        return await self.retrieve_assistant_run_with_options_async(thread_id, run_id, headers, runtime)

    def retrieve_assistant_scope_with_options(
        self,
        request: dingtalkassistant__1__0_models.RetrieveAssistantScopeRequest,
        headers: dingtalkassistant__1__0_models.RetrieveAssistantScopeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.RetrieveAssistantScopeResponse:
        """
        @summary 获取助理的使用范围
        
        @param request: RetrieveAssistantScopeRequest
        @param headers: RetrieveAssistantScopeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RetrieveAssistantScopeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.assistant_id):
            query['assistantId'] = request.assistant_id
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
            action='RetrieveAssistantScope',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/scope',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.RetrieveAssistantScopeResponse(),
            self.execute(params, req, runtime)
        )

    async def retrieve_assistant_scope_with_options_async(
        self,
        request: dingtalkassistant__1__0_models.RetrieveAssistantScopeRequest,
        headers: dingtalkassistant__1__0_models.RetrieveAssistantScopeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.RetrieveAssistantScopeResponse:
        """
        @summary 获取助理的使用范围
        
        @param request: RetrieveAssistantScopeRequest
        @param headers: RetrieveAssistantScopeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RetrieveAssistantScopeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.assistant_id):
            query['assistantId'] = request.assistant_id
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
            action='RetrieveAssistantScope',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/scope',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.RetrieveAssistantScopeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def retrieve_assistant_scope(
        self,
        request: dingtalkassistant__1__0_models.RetrieveAssistantScopeRequest,
    ) -> dingtalkassistant__1__0_models.RetrieveAssistantScopeResponse:
        """
        @summary 获取助理的使用范围
        
        @param request: RetrieveAssistantScopeRequest
        @return: RetrieveAssistantScopeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.RetrieveAssistantScopeHeaders()
        return self.retrieve_assistant_scope_with_options(request, headers, runtime)

    async def retrieve_assistant_scope_async(
        self,
        request: dingtalkassistant__1__0_models.RetrieveAssistantScopeRequest,
    ) -> dingtalkassistant__1__0_models.RetrieveAssistantScopeResponse:
        """
        @summary 获取助理的使用范围
        
        @param request: RetrieveAssistantScopeRequest
        @return: RetrieveAssistantScopeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.RetrieveAssistantScopeHeaders()
        return await self.retrieve_assistant_scope_with_options_async(request, headers, runtime)

    def retrieve_assistant_thread_with_options(
        self,
        thread_id: str,
        headers: dingtalkassistant__1__0_models.RetrieveAssistantThreadHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.RetrieveAssistantThreadResponse:
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
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/threads/{thread_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.RetrieveAssistantThreadResponse(),
            self.execute(params, req, runtime)
        )

    async def retrieve_assistant_thread_with_options_async(
        self,
        thread_id: str,
        headers: dingtalkassistant__1__0_models.RetrieveAssistantThreadHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.RetrieveAssistantThreadResponse:
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
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/threads/{thread_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.RetrieveAssistantThreadResponse(),
            await self.execute_async(params, req, runtime)
        )

    def retrieve_assistant_thread(
        self,
        thread_id: str,
    ) -> dingtalkassistant__1__0_models.RetrieveAssistantThreadResponse:
        """
        @summary 检索AI助理线程实例
        
        @return: RetrieveAssistantThreadResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.RetrieveAssistantThreadHeaders()
        return self.retrieve_assistant_thread_with_options(thread_id, headers, runtime)

    async def retrieve_assistant_thread_async(
        self,
        thread_id: str,
    ) -> dingtalkassistant__1__0_models.RetrieveAssistantThreadResponse:
        """
        @summary 检索AI助理线程实例
        
        @return: RetrieveAssistantThreadResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.RetrieveAssistantThreadHeaders()
        return await self.retrieve_assistant_thread_with_options_async(thread_id, headers, runtime)

    def update_assistant_basic_info_with_options(
        self,
        request: dingtalkassistant__1__0_models.UpdateAssistantBasicInfoRequest,
        headers: dingtalkassistant__1__0_models.UpdateAssistantBasicInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.UpdateAssistantBasicInfoResponse:
        """
        @summary 更新AI助理基础信息
        
        @param request: UpdateAssistantBasicInfoRequest
        @param headers: UpdateAssistantBasicInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateAssistantBasicInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.assistant_id):
            body['assistantId'] = request.assistant_id
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.fallback_content):
            body['fallbackContent'] = request.fallback_content
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.instructions):
            body['instructions'] = request.instructions
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.operator_union_id):
            body['operatorUnionId'] = request.operator_union_id
        if not UtilClient.is_unset(request.recommend_prompts):
            body['recommendPrompts'] = request.recommend_prompts
        if not UtilClient.is_unset(request.welcome_content):
            body['welcomeContent'] = request.welcome_content
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
            action='UpdateAssistantBasicInfo',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/basicInfo',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.UpdateAssistantBasicInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def update_assistant_basic_info_with_options_async(
        self,
        request: dingtalkassistant__1__0_models.UpdateAssistantBasicInfoRequest,
        headers: dingtalkassistant__1__0_models.UpdateAssistantBasicInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.UpdateAssistantBasicInfoResponse:
        """
        @summary 更新AI助理基础信息
        
        @param request: UpdateAssistantBasicInfoRequest
        @param headers: UpdateAssistantBasicInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateAssistantBasicInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.assistant_id):
            body['assistantId'] = request.assistant_id
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.fallback_content):
            body['fallbackContent'] = request.fallback_content
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.instructions):
            body['instructions'] = request.instructions
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.operator_union_id):
            body['operatorUnionId'] = request.operator_union_id
        if not UtilClient.is_unset(request.recommend_prompts):
            body['recommendPrompts'] = request.recommend_prompts
        if not UtilClient.is_unset(request.welcome_content):
            body['welcomeContent'] = request.welcome_content
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
            action='UpdateAssistantBasicInfo',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/basicInfo',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.UpdateAssistantBasicInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_assistant_basic_info(
        self,
        request: dingtalkassistant__1__0_models.UpdateAssistantBasicInfoRequest,
    ) -> dingtalkassistant__1__0_models.UpdateAssistantBasicInfoResponse:
        """
        @summary 更新AI助理基础信息
        
        @param request: UpdateAssistantBasicInfoRequest
        @return: UpdateAssistantBasicInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.UpdateAssistantBasicInfoHeaders()
        return self.update_assistant_basic_info_with_options(request, headers, runtime)

    async def update_assistant_basic_info_async(
        self,
        request: dingtalkassistant__1__0_models.UpdateAssistantBasicInfoRequest,
    ) -> dingtalkassistant__1__0_models.UpdateAssistantBasicInfoResponse:
        """
        @summary 更新AI助理基础信息
        
        @param request: UpdateAssistantBasicInfoRequest
        @return: UpdateAssistantBasicInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.UpdateAssistantBasicInfoHeaders()
        return await self.update_assistant_basic_info_with_options_async(request, headers, runtime)

    def update_assistant_scope_with_options(
        self,
        request: dingtalkassistant__1__0_models.UpdateAssistantScopeRequest,
        headers: dingtalkassistant__1__0_models.UpdateAssistantScopeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.UpdateAssistantScopeResponse:
        """
        @summary 更新 AI 助理使用范围
        
        @param request: UpdateAssistantScopeRequest
        @param headers: UpdateAssistantScopeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateAssistantScopeResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.assistant_id):
            body['assistantId'] = request.assistant_id
        if not UtilClient.is_unset(request.operator_union_id):
            body['operatorUnionId'] = request.operator_union_id
        if not UtilClient.is_unset(request.scopes):
            body['scopes'] = request.scopes
        if not UtilClient.is_unset(request.sharing):
            body['sharing'] = request.sharing
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
            action='UpdateAssistantScope',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/scope',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='any'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.UpdateAssistantScopeResponse(),
            self.execute(params, req, runtime)
        )

    async def update_assistant_scope_with_options_async(
        self,
        request: dingtalkassistant__1__0_models.UpdateAssistantScopeRequest,
        headers: dingtalkassistant__1__0_models.UpdateAssistantScopeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkassistant__1__0_models.UpdateAssistantScopeResponse:
        """
        @summary 更新 AI 助理使用范围
        
        @param request: UpdateAssistantScopeRequest
        @param headers: UpdateAssistantScopeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateAssistantScopeResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.assistant_id):
            body['assistantId'] = request.assistant_id
        if not UtilClient.is_unset(request.operator_union_id):
            body['operatorUnionId'] = request.operator_union_id
        if not UtilClient.is_unset(request.scopes):
            body['scopes'] = request.scopes
        if not UtilClient.is_unset(request.sharing):
            body['sharing'] = request.sharing
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
            action='UpdateAssistantScope',
            version='assistant_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/assistant/scope',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='any'
        )
        return TeaCore.from_map(
            dingtalkassistant__1__0_models.UpdateAssistantScopeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_assistant_scope(
        self,
        request: dingtalkassistant__1__0_models.UpdateAssistantScopeRequest,
    ) -> dingtalkassistant__1__0_models.UpdateAssistantScopeResponse:
        """
        @summary 更新 AI 助理使用范围
        
        @param request: UpdateAssistantScopeRequest
        @return: UpdateAssistantScopeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.UpdateAssistantScopeHeaders()
        return self.update_assistant_scope_with_options(request, headers, runtime)

    async def update_assistant_scope_async(
        self,
        request: dingtalkassistant__1__0_models.UpdateAssistantScopeRequest,
    ) -> dingtalkassistant__1__0_models.UpdateAssistantScopeResponse:
        """
        @summary 更新 AI 助理使用范围
        
        @param request: UpdateAssistantScopeRequest
        @return: UpdateAssistantScopeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkassistant__1__0_models.UpdateAssistantScopeHeaders()
        return await self.update_assistant_scope_with_options_async(request, headers, runtime)
