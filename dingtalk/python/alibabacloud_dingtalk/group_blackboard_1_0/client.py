# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.group_blackboard_1_0 import models as dingtalkgroup_blackboard__1__0_models
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

    def create_group_blackboard_with_options(
        self,
        request: dingtalkgroup_blackboard__1__0_models.CreateGroupBlackboardRequest,
        headers: dingtalkgroup_blackboard__1__0_models.CreateGroupBlackboardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkgroup_blackboard__1__0_models.CreateGroupBlackboardResponse:
        """
        @summary 创建群公告
        
        @param request: CreateGroupBlackboardRequest
        @param headers: CreateGroupBlackboardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateGroupBlackboardResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.send_ding):
            body['sendDing'] = request.send_ding
        if not UtilClient.is_unset(request.sticky):
            body['sticky'] = request.sticky
        if not UtilClient.is_unset(request.unique_id):
            body['uniqueId'] = request.unique_id
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
            action='CreateGroupBlackboard',
            version='groupBlackboard_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/groupBlackboard/blackboards',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkgroup_blackboard__1__0_models.CreateGroupBlackboardResponse(),
            self.execute(params, req, runtime)
        )

    async def create_group_blackboard_with_options_async(
        self,
        request: dingtalkgroup_blackboard__1__0_models.CreateGroupBlackboardRequest,
        headers: dingtalkgroup_blackboard__1__0_models.CreateGroupBlackboardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkgroup_blackboard__1__0_models.CreateGroupBlackboardResponse:
        """
        @summary 创建群公告
        
        @param request: CreateGroupBlackboardRequest
        @param headers: CreateGroupBlackboardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateGroupBlackboardResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.send_ding):
            body['sendDing'] = request.send_ding
        if not UtilClient.is_unset(request.sticky):
            body['sticky'] = request.sticky
        if not UtilClient.is_unset(request.unique_id):
            body['uniqueId'] = request.unique_id
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
            action='CreateGroupBlackboard',
            version='groupBlackboard_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/groupBlackboard/blackboards',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkgroup_blackboard__1__0_models.CreateGroupBlackboardResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_group_blackboard(
        self,
        request: dingtalkgroup_blackboard__1__0_models.CreateGroupBlackboardRequest,
    ) -> dingtalkgroup_blackboard__1__0_models.CreateGroupBlackboardResponse:
        """
        @summary 创建群公告
        
        @param request: CreateGroupBlackboardRequest
        @return: CreateGroupBlackboardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkgroup_blackboard__1__0_models.CreateGroupBlackboardHeaders()
        return self.create_group_blackboard_with_options(request, headers, runtime)

    async def create_group_blackboard_async(
        self,
        request: dingtalkgroup_blackboard__1__0_models.CreateGroupBlackboardRequest,
    ) -> dingtalkgroup_blackboard__1__0_models.CreateGroupBlackboardResponse:
        """
        @summary 创建群公告
        
        @param request: CreateGroupBlackboardRequest
        @return: CreateGroupBlackboardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkgroup_blackboard__1__0_models.CreateGroupBlackboardHeaders()
        return await self.create_group_blackboard_with_options_async(request, headers, runtime)

    def delete_group_blackboard_with_options(
        self,
        request: dingtalkgroup_blackboard__1__0_models.DeleteGroupBlackboardRequest,
        headers: dingtalkgroup_blackboard__1__0_models.DeleteGroupBlackboardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkgroup_blackboard__1__0_models.DeleteGroupBlackboardResponse:
        """
        @summary 删除群公告
        
        @param request: DeleteGroupBlackboardRequest
        @param headers: DeleteGroupBlackboardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteGroupBlackboardResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.data_id):
            body['dataId'] = request.data_id
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
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
            action='DeleteGroupBlackboard',
            version='groupBlackboard_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/groupBlackboard/blackboards/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkgroup_blackboard__1__0_models.DeleteGroupBlackboardResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_group_blackboard_with_options_async(
        self,
        request: dingtalkgroup_blackboard__1__0_models.DeleteGroupBlackboardRequest,
        headers: dingtalkgroup_blackboard__1__0_models.DeleteGroupBlackboardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkgroup_blackboard__1__0_models.DeleteGroupBlackboardResponse:
        """
        @summary 删除群公告
        
        @param request: DeleteGroupBlackboardRequest
        @param headers: DeleteGroupBlackboardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteGroupBlackboardResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.data_id):
            body['dataId'] = request.data_id
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
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
            action='DeleteGroupBlackboard',
            version='groupBlackboard_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/groupBlackboard/blackboards/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkgroup_blackboard__1__0_models.DeleteGroupBlackboardResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_group_blackboard(
        self,
        request: dingtalkgroup_blackboard__1__0_models.DeleteGroupBlackboardRequest,
    ) -> dingtalkgroup_blackboard__1__0_models.DeleteGroupBlackboardResponse:
        """
        @summary 删除群公告
        
        @param request: DeleteGroupBlackboardRequest
        @return: DeleteGroupBlackboardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkgroup_blackboard__1__0_models.DeleteGroupBlackboardHeaders()
        return self.delete_group_blackboard_with_options(request, headers, runtime)

    async def delete_group_blackboard_async(
        self,
        request: dingtalkgroup_blackboard__1__0_models.DeleteGroupBlackboardRequest,
    ) -> dingtalkgroup_blackboard__1__0_models.DeleteGroupBlackboardResponse:
        """
        @summary 删除群公告
        
        @param request: DeleteGroupBlackboardRequest
        @return: DeleteGroupBlackboardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkgroup_blackboard__1__0_models.DeleteGroupBlackboardHeaders()
        return await self.delete_group_blackboard_with_options_async(request, headers, runtime)
