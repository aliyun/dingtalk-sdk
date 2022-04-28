# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
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
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def create_group_blackboard(
        self,
        request: dingtalkgroup_blackboard__1__0_models.CreateGroupBlackboardRequest,
    ) -> dingtalkgroup_blackboard__1__0_models.CreateGroupBlackboardResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkgroup_blackboard__1__0_models.CreateGroupBlackboardHeaders()
        return self.create_group_blackboard_with_options(request, headers, runtime)

    async def create_group_blackboard_async(
        self,
        request: dingtalkgroup_blackboard__1__0_models.CreateGroupBlackboardRequest,
    ) -> dingtalkgroup_blackboard__1__0_models.CreateGroupBlackboardResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkgroup_blackboard__1__0_models.CreateGroupBlackboardHeaders()
        return await self.create_group_blackboard_with_options_async(request, headers, runtime)

    def create_group_blackboard_with_options(
        self,
        request: dingtalkgroup_blackboard__1__0_models.CreateGroupBlackboardRequest,
        headers: dingtalkgroup_blackboard__1__0_models.CreateGroupBlackboardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkgroup_blackboard__1__0_models.CreateGroupBlackboardResponse:
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
        return TeaCore.from_map(
            dingtalkgroup_blackboard__1__0_models.CreateGroupBlackboardResponse(),
            self.do_roarequest('CreateGroupBlackboard', 'groupBlackboard_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/groupBlackboard/blackboards', 'json', req, runtime)
        )

    async def create_group_blackboard_with_options_async(
        self,
        request: dingtalkgroup_blackboard__1__0_models.CreateGroupBlackboardRequest,
        headers: dingtalkgroup_blackboard__1__0_models.CreateGroupBlackboardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkgroup_blackboard__1__0_models.CreateGroupBlackboardResponse:
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
        return TeaCore.from_map(
            dingtalkgroup_blackboard__1__0_models.CreateGroupBlackboardResponse(),
            await self.do_roarequest_async('CreateGroupBlackboard', 'groupBlackboard_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/groupBlackboard/blackboards', 'json', req, runtime)
        )

    def delete_group_blackboard(
        self,
        request: dingtalkgroup_blackboard__1__0_models.DeleteGroupBlackboardRequest,
    ) -> dingtalkgroup_blackboard__1__0_models.DeleteGroupBlackboardResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkgroup_blackboard__1__0_models.DeleteGroupBlackboardHeaders()
        return self.delete_group_blackboard_with_options(request, headers, runtime)

    async def delete_group_blackboard_async(
        self,
        request: dingtalkgroup_blackboard__1__0_models.DeleteGroupBlackboardRequest,
    ) -> dingtalkgroup_blackboard__1__0_models.DeleteGroupBlackboardResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkgroup_blackboard__1__0_models.DeleteGroupBlackboardHeaders()
        return await self.delete_group_blackboard_with_options_async(request, headers, runtime)

    def delete_group_blackboard_with_options(
        self,
        request: dingtalkgroup_blackboard__1__0_models.DeleteGroupBlackboardRequest,
        headers: dingtalkgroup_blackboard__1__0_models.DeleteGroupBlackboardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkgroup_blackboard__1__0_models.DeleteGroupBlackboardResponse:
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
        return TeaCore.from_map(
            dingtalkgroup_blackboard__1__0_models.DeleteGroupBlackboardResponse(),
            self.do_roarequest('DeleteGroupBlackboard', 'groupBlackboard_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/groupBlackboard/blackboards/remove', 'json', req, runtime)
        )

    async def delete_group_blackboard_with_options_async(
        self,
        request: dingtalkgroup_blackboard__1__0_models.DeleteGroupBlackboardRequest,
        headers: dingtalkgroup_blackboard__1__0_models.DeleteGroupBlackboardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkgroup_blackboard__1__0_models.DeleteGroupBlackboardResponse:
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
        return TeaCore.from_map(
            dingtalkgroup_blackboard__1__0_models.DeleteGroupBlackboardResponse(),
            await self.do_roarequest_async('DeleteGroupBlackboard', 'groupBlackboard_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/groupBlackboard/blackboards/remove', 'json', req, runtime)
        )
