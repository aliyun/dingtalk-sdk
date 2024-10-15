# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.flashmsg_1_0 import models as dingtalkflashmsg__1__0_models
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

    def add_plugin_rule_with_options(
        self,
        request: dingtalkflashmsg__1__0_models.AddPluginRuleRequest,
        headers: dingtalkflashmsg__1__0_models.AddPluginRuleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkflashmsg__1__0_models.AddPluginRuleResponse:
        """
        @summary 添加插件规则
        
        @param request: AddPluginRuleRequest
        @param headers: AddPluginRuleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddPluginRuleResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.chat_type):
            body['chatType'] = request.chat_type
        if not UtilClient.is_unset(request.code):
            body['code'] = request.code
        if not UtilClient.is_unset(request.item_type):
            body['itemType'] = request.item_type
        if not UtilClient.is_unset(request.rules):
            body['rules'] = request.rules
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='AddPluginRule',
            version='flashmsg_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/flashmsg/plugins',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkflashmsg__1__0_models.AddPluginRuleResponse(),
            self.execute(params, req, runtime)
        )

    async def add_plugin_rule_with_options_async(
        self,
        request: dingtalkflashmsg__1__0_models.AddPluginRuleRequest,
        headers: dingtalkflashmsg__1__0_models.AddPluginRuleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkflashmsg__1__0_models.AddPluginRuleResponse:
        """
        @summary 添加插件规则
        
        @param request: AddPluginRuleRequest
        @param headers: AddPluginRuleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddPluginRuleResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.chat_type):
            body['chatType'] = request.chat_type
        if not UtilClient.is_unset(request.code):
            body['code'] = request.code
        if not UtilClient.is_unset(request.item_type):
            body['itemType'] = request.item_type
        if not UtilClient.is_unset(request.rules):
            body['rules'] = request.rules
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='AddPluginRule',
            version='flashmsg_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/flashmsg/plugins',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkflashmsg__1__0_models.AddPluginRuleResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_plugin_rule(
        self,
        request: dingtalkflashmsg__1__0_models.AddPluginRuleRequest,
    ) -> dingtalkflashmsg__1__0_models.AddPluginRuleResponse:
        """
        @summary 添加插件规则
        
        @param request: AddPluginRuleRequest
        @return: AddPluginRuleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkflashmsg__1__0_models.AddPluginRuleHeaders()
        return self.add_plugin_rule_with_options(request, headers, runtime)

    async def add_plugin_rule_async(
        self,
        request: dingtalkflashmsg__1__0_models.AddPluginRuleRequest,
    ) -> dingtalkflashmsg__1__0_models.AddPluginRuleResponse:
        """
        @summary 添加插件规则
        
        @param request: AddPluginRuleRequest
        @return: AddPluginRuleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkflashmsg__1__0_models.AddPluginRuleHeaders()
        return await self.add_plugin_rule_with_options_async(request, headers, runtime)

    def delete_plguin_rule_with_options(
        self,
        request: dingtalkflashmsg__1__0_models.DeletePlguinRuleRequest,
        headers: dingtalkflashmsg__1__0_models.DeletePlguinRuleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkflashmsg__1__0_models.DeletePlguinRuleResponse:
        """
        @summary 删除插件规则
        
        @param request: DeletePlguinRuleRequest
        @param headers: DeletePlguinRuleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeletePlguinRuleResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_id_list):
            body['bizIdList'] = request.biz_id_list
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='DeletePlguinRule',
            version='flashmsg_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/flashmsg/plugins/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkflashmsg__1__0_models.DeletePlguinRuleResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_plguin_rule_with_options_async(
        self,
        request: dingtalkflashmsg__1__0_models.DeletePlguinRuleRequest,
        headers: dingtalkflashmsg__1__0_models.DeletePlguinRuleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkflashmsg__1__0_models.DeletePlguinRuleResponse:
        """
        @summary 删除插件规则
        
        @param request: DeletePlguinRuleRequest
        @param headers: DeletePlguinRuleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeletePlguinRuleResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_id_list):
            body['bizIdList'] = request.biz_id_list
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
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
            action='DeletePlguinRule',
            version='flashmsg_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/flashmsg/plugins/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkflashmsg__1__0_models.DeletePlguinRuleResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_plguin_rule(
        self,
        request: dingtalkflashmsg__1__0_models.DeletePlguinRuleRequest,
    ) -> dingtalkflashmsg__1__0_models.DeletePlguinRuleResponse:
        """
        @summary 删除插件规则
        
        @param request: DeletePlguinRuleRequest
        @return: DeletePlguinRuleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkflashmsg__1__0_models.DeletePlguinRuleHeaders()
        return self.delete_plguin_rule_with_options(request, headers, runtime)

    async def delete_plguin_rule_async(
        self,
        request: dingtalkflashmsg__1__0_models.DeletePlguinRuleRequest,
    ) -> dingtalkflashmsg__1__0_models.DeletePlguinRuleResponse:
        """
        @summary 删除插件规则
        
        @param request: DeletePlguinRuleRequest
        @return: DeletePlguinRuleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkflashmsg__1__0_models.DeletePlguinRuleHeaders()
        return await self.delete_plguin_rule_with_options_async(request, headers, runtime)

    def get_base_profile_list_with_options(
        self,
        request: dingtalkflashmsg__1__0_models.GetBaseProfileListRequest,
        headers: dingtalkflashmsg__1__0_models.GetBaseProfileListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkflashmsg__1__0_models.GetBaseProfileListResponse:
        """
        @summary 闪读用户基础信息查询
        
        @param request: GetBaseProfileListRequest
        @param headers: GetBaseProfileListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetBaseProfileListResponse
        """
        UtilClient.validate_model(request)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=request.body
        )
        params = open_api_models.Params(
            action='GetBaseProfileList',
            version='flashmsg_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/flashmsg/users/baseInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkflashmsg__1__0_models.GetBaseProfileListResponse(),
            self.execute(params, req, runtime)
        )

    async def get_base_profile_list_with_options_async(
        self,
        request: dingtalkflashmsg__1__0_models.GetBaseProfileListRequest,
        headers: dingtalkflashmsg__1__0_models.GetBaseProfileListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkflashmsg__1__0_models.GetBaseProfileListResponse:
        """
        @summary 闪读用户基础信息查询
        
        @param request: GetBaseProfileListRequest
        @param headers: GetBaseProfileListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetBaseProfileListResponse
        """
        UtilClient.validate_model(request)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=request.body
        )
        params = open_api_models.Params(
            action='GetBaseProfileList',
            version='flashmsg_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/flashmsg/users/baseInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkflashmsg__1__0_models.GetBaseProfileListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_base_profile_list(
        self,
        request: dingtalkflashmsg__1__0_models.GetBaseProfileListRequest,
    ) -> dingtalkflashmsg__1__0_models.GetBaseProfileListResponse:
        """
        @summary 闪读用户基础信息查询
        
        @param request: GetBaseProfileListRequest
        @return: GetBaseProfileListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkflashmsg__1__0_models.GetBaseProfileListHeaders()
        return self.get_base_profile_list_with_options(request, headers, runtime)

    async def get_base_profile_list_async(
        self,
        request: dingtalkflashmsg__1__0_models.GetBaseProfileListRequest,
    ) -> dingtalkflashmsg__1__0_models.GetBaseProfileListResponse:
        """
        @summary 闪读用户基础信息查询
        
        @param request: GetBaseProfileListRequest
        @return: GetBaseProfileListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkflashmsg__1__0_models.GetBaseProfileListHeaders()
        return await self.get_base_profile_list_with_options_async(request, headers, runtime)

    def get_conversation_with_options(
        self,
        request: dingtalkflashmsg__1__0_models.GetConversationRequest,
        headers: dingtalkflashmsg__1__0_models.GetConversationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkflashmsg__1__0_models.GetConversationResponse:
        """
        @summary 获得闪读会话信息
        
        @param request: GetConversationRequest
        @param headers: GetConversationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetConversationResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            query['openConversationId'] = request.open_conversation_id
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
            action='GetConversation',
            version='flashmsg_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/flashmsg/conversations/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkflashmsg__1__0_models.GetConversationResponse(),
            self.execute(params, req, runtime)
        )

    async def get_conversation_with_options_async(
        self,
        request: dingtalkflashmsg__1__0_models.GetConversationRequest,
        headers: dingtalkflashmsg__1__0_models.GetConversationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkflashmsg__1__0_models.GetConversationResponse:
        """
        @summary 获得闪读会话信息
        
        @param request: GetConversationRequest
        @param headers: GetConversationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetConversationResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            query['openConversationId'] = request.open_conversation_id
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
            action='GetConversation',
            version='flashmsg_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/flashmsg/conversations/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkflashmsg__1__0_models.GetConversationResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_conversation(
        self,
        request: dingtalkflashmsg__1__0_models.GetConversationRequest,
    ) -> dingtalkflashmsg__1__0_models.GetConversationResponse:
        """
        @summary 获得闪读会话信息
        
        @param request: GetConversationRequest
        @return: GetConversationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkflashmsg__1__0_models.GetConversationHeaders()
        return self.get_conversation_with_options(request, headers, runtime)

    async def get_conversation_async(
        self,
        request: dingtalkflashmsg__1__0_models.GetConversationRequest,
    ) -> dingtalkflashmsg__1__0_models.GetConversationResponse:
        """
        @summary 获得闪读会话信息
        
        @param request: GetConversationRequest
        @return: GetConversationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkflashmsg__1__0_models.GetConversationHeaders()
        return await self.get_conversation_with_options_async(request, headers, runtime)

    def get_member_list_with_options(
        self,
        request: dingtalkflashmsg__1__0_models.GetMemberListRequest,
        headers: dingtalkflashmsg__1__0_models.GetMemberListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkflashmsg__1__0_models.GetMemberListResponse:
        """
        @summary 获得成员ID列表
        
        @param request: GetMemberListRequest
        @param headers: GetMemberListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetMemberListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            query['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
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
            action='GetMemberList',
            version='flashmsg_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/flashmsg/conversations/memberIdLists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkflashmsg__1__0_models.GetMemberListResponse(),
            self.execute(params, req, runtime)
        )

    async def get_member_list_with_options_async(
        self,
        request: dingtalkflashmsg__1__0_models.GetMemberListRequest,
        headers: dingtalkflashmsg__1__0_models.GetMemberListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkflashmsg__1__0_models.GetMemberListResponse:
        """
        @summary 获得成员ID列表
        
        @param request: GetMemberListRequest
        @param headers: GetMemberListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetMemberListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            query['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
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
            action='GetMemberList',
            version='flashmsg_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/flashmsg/conversations/memberIdLists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkflashmsg__1__0_models.GetMemberListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_member_list(
        self,
        request: dingtalkflashmsg__1__0_models.GetMemberListRequest,
    ) -> dingtalkflashmsg__1__0_models.GetMemberListResponse:
        """
        @summary 获得成员ID列表
        
        @param request: GetMemberListRequest
        @return: GetMemberListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkflashmsg__1__0_models.GetMemberListHeaders()
        return self.get_member_list_with_options(request, headers, runtime)

    async def get_member_list_async(
        self,
        request: dingtalkflashmsg__1__0_models.GetMemberListRequest,
    ) -> dingtalkflashmsg__1__0_models.GetMemberListResponse:
        """
        @summary 获得成员ID列表
        
        @param request: GetMemberListRequest
        @return: GetMemberListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkflashmsg__1__0_models.GetMemberListHeaders()
        return await self.get_member_list_with_options_async(request, headers, runtime)

    def query_plugin_rule_with_options(
        self,
        request: dingtalkflashmsg__1__0_models.QueryPluginRuleRequest,
        headers: dingtalkflashmsg__1__0_models.QueryPluginRuleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkflashmsg__1__0_models.QueryPluginRuleResponse:
        """
        @summary 查询插件规则
        
        @param request: QueryPluginRuleRequest
        @param headers: QueryPluginRuleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryPluginRuleResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.chat_type):
            query['chatType'] = request.chat_type
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        if not UtilClient.is_unset(request.item_id):
            query['itemId'] = request.item_id
        if not UtilClient.is_unset(request.item_type):
            query['itemType'] = request.item_type
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
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
            action='QueryPluginRule',
            version='flashmsg_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/flashmsg/plugins',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkflashmsg__1__0_models.QueryPluginRuleResponse(),
            self.execute(params, req, runtime)
        )

    async def query_plugin_rule_with_options_async(
        self,
        request: dingtalkflashmsg__1__0_models.QueryPluginRuleRequest,
        headers: dingtalkflashmsg__1__0_models.QueryPluginRuleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkflashmsg__1__0_models.QueryPluginRuleResponse:
        """
        @summary 查询插件规则
        
        @param request: QueryPluginRuleRequest
        @param headers: QueryPluginRuleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryPluginRuleResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.chat_type):
            query['chatType'] = request.chat_type
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        if not UtilClient.is_unset(request.item_id):
            query['itemId'] = request.item_id
        if not UtilClient.is_unset(request.item_type):
            query['itemType'] = request.item_type
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
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
            action='QueryPluginRule',
            version='flashmsg_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/flashmsg/plugins',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkflashmsg__1__0_models.QueryPluginRuleResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_plugin_rule(
        self,
        request: dingtalkflashmsg__1__0_models.QueryPluginRuleRequest,
    ) -> dingtalkflashmsg__1__0_models.QueryPluginRuleResponse:
        """
        @summary 查询插件规则
        
        @param request: QueryPluginRuleRequest
        @return: QueryPluginRuleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkflashmsg__1__0_models.QueryPluginRuleHeaders()
        return self.query_plugin_rule_with_options(request, headers, runtime)

    async def query_plugin_rule_async(
        self,
        request: dingtalkflashmsg__1__0_models.QueryPluginRuleRequest,
    ) -> dingtalkflashmsg__1__0_models.QueryPluginRuleResponse:
        """
        @summary 查询插件规则
        
        @param request: QueryPluginRuleRequest
        @return: QueryPluginRuleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkflashmsg__1__0_models.QueryPluginRuleHeaders()
        return await self.query_plugin_rule_with_options_async(request, headers, runtime)

    def send_ding_tip_with_options(
        self,
        request: dingtalkflashmsg__1__0_models.SendDingTipRequest,
        headers: dingtalkflashmsg__1__0_models.SendDingTipHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkflashmsg__1__0_models.SendDingTipResponse:
        """
        @summary 发送Ding提示消息
        
        @param request: SendDingTipRequest
        @param headers: SendDingTipHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendDingTipResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.extension):
            body['extension'] = request.extension
        if not UtilClient.is_unset(request.link):
            body['link'] = request.link
        if not UtilClient.is_unset(request.message_id):
            body['messageId'] = request.message_id
        if not UtilClient.is_unset(request.receiver_user_id):
            body['receiverUserId'] = request.receiver_user_id
        if not UtilClient.is_unset(request.sender_user_id):
            body['senderUserId'] = request.sender_user_id
        if not UtilClient.is_unset(request.text_content):
            body['textContent'] = request.text_content
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
            action='SendDingTip',
            version='flashmsg_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/flashmsg/ding/messages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkflashmsg__1__0_models.SendDingTipResponse(),
            self.execute(params, req, runtime)
        )

    async def send_ding_tip_with_options_async(
        self,
        request: dingtalkflashmsg__1__0_models.SendDingTipRequest,
        headers: dingtalkflashmsg__1__0_models.SendDingTipHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkflashmsg__1__0_models.SendDingTipResponse:
        """
        @summary 发送Ding提示消息
        
        @param request: SendDingTipRequest
        @param headers: SendDingTipHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendDingTipResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.extension):
            body['extension'] = request.extension
        if not UtilClient.is_unset(request.link):
            body['link'] = request.link
        if not UtilClient.is_unset(request.message_id):
            body['messageId'] = request.message_id
        if not UtilClient.is_unset(request.receiver_user_id):
            body['receiverUserId'] = request.receiver_user_id
        if not UtilClient.is_unset(request.sender_user_id):
            body['senderUserId'] = request.sender_user_id
        if not UtilClient.is_unset(request.text_content):
            body['textContent'] = request.text_content
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
            action='SendDingTip',
            version='flashmsg_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/flashmsg/ding/messages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkflashmsg__1__0_models.SendDingTipResponse(),
            await self.execute_async(params, req, runtime)
        )

    def send_ding_tip(
        self,
        request: dingtalkflashmsg__1__0_models.SendDingTipRequest,
    ) -> dingtalkflashmsg__1__0_models.SendDingTipResponse:
        """
        @summary 发送Ding提示消息
        
        @param request: SendDingTipRequest
        @return: SendDingTipResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkflashmsg__1__0_models.SendDingTipHeaders()
        return self.send_ding_tip_with_options(request, headers, runtime)

    async def send_ding_tip_async(
        self,
        request: dingtalkflashmsg__1__0_models.SendDingTipRequest,
    ) -> dingtalkflashmsg__1__0_models.SendDingTipResponse:
        """
        @summary 发送Ding提示消息
        
        @param request: SendDingTipRequest
        @return: SendDingTipResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkflashmsg__1__0_models.SendDingTipHeaders()
        return await self.send_ding_tip_with_options_async(request, headers, runtime)

    def send_message_tip_with_options(
        self,
        request: dingtalkflashmsg__1__0_models.SendMessageTipRequest,
        headers: dingtalkflashmsg__1__0_models.SendMessageTipHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkflashmsg__1__0_models.SendMessageTipResponse:
        """
        @summary 发送闪读消息提示
        
        @param request: SendMessageTipRequest
        @param headers: SendMessageTipHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendMessageTipResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.default_view):
            body['defaultView'] = request.default_view
        if not UtilClient.is_unset(request.message_id):
            body['messageId'] = request.message_id
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.private_field_map):
            body['privateFieldMap'] = request.private_field_map
        if not UtilClient.is_unset(request.public_field):
            body['publicField'] = request.public_field
        if not UtilClient.is_unset(request.receiver_user_id):
            body['receiverUserId'] = request.receiver_user_id
        if not UtilClient.is_unset(request.sender_user_id):
            body['senderUserId'] = request.sender_user_id
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
            action='SendMessageTip',
            version='flashmsg_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/flashmsg/messages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkflashmsg__1__0_models.SendMessageTipResponse(),
            self.execute(params, req, runtime)
        )

    async def send_message_tip_with_options_async(
        self,
        request: dingtalkflashmsg__1__0_models.SendMessageTipRequest,
        headers: dingtalkflashmsg__1__0_models.SendMessageTipHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkflashmsg__1__0_models.SendMessageTipResponse:
        """
        @summary 发送闪读消息提示
        
        @param request: SendMessageTipRequest
        @param headers: SendMessageTipHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendMessageTipResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.default_view):
            body['defaultView'] = request.default_view
        if not UtilClient.is_unset(request.message_id):
            body['messageId'] = request.message_id
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.private_field_map):
            body['privateFieldMap'] = request.private_field_map
        if not UtilClient.is_unset(request.public_field):
            body['publicField'] = request.public_field
        if not UtilClient.is_unset(request.receiver_user_id):
            body['receiverUserId'] = request.receiver_user_id
        if not UtilClient.is_unset(request.sender_user_id):
            body['senderUserId'] = request.sender_user_id
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
            action='SendMessageTip',
            version='flashmsg_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/flashmsg/messages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkflashmsg__1__0_models.SendMessageTipResponse(),
            await self.execute_async(params, req, runtime)
        )

    def send_message_tip(
        self,
        request: dingtalkflashmsg__1__0_models.SendMessageTipRequest,
    ) -> dingtalkflashmsg__1__0_models.SendMessageTipResponse:
        """
        @summary 发送闪读消息提示
        
        @param request: SendMessageTipRequest
        @return: SendMessageTipResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkflashmsg__1__0_models.SendMessageTipHeaders()
        return self.send_message_tip_with_options(request, headers, runtime)

    async def send_message_tip_async(
        self,
        request: dingtalkflashmsg__1__0_models.SendMessageTipRequest,
    ) -> dingtalkflashmsg__1__0_models.SendMessageTipResponse:
        """
        @summary 发送闪读消息提示
        
        @param request: SendMessageTipRequest
        @return: SendMessageTipResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkflashmsg__1__0_models.SendMessageTipHeaders()
        return await self.send_message_tip_with_options_async(request, headers, runtime)
