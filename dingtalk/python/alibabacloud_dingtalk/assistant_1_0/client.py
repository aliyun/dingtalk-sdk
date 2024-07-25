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
