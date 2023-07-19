# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_gateway_spi.client import Client as SPIClient
from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.robot_1_0 import models as dingtalkrobot__1__0_models
from alibabacloud_tea_util import models as util_models
from alibabacloud_openapi_util.client import Client as OpenApiUtilClient


class Client(OpenApiClient):
    """
    *\
    """
    _client: SPIClient = None

    def __init__(
        self, 
        config: open_api_models.Config,
    ):
        super().__init__(config)
        self._client = GatewayClientClient()
        self._spi = self._client
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def batch_otoquery_with_options(
        self,
        request: dingtalkrobot__1__0_models.BatchOTOQueryRequest,
        headers: dingtalkrobot__1__0_models.BatchOTOQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.BatchOTOQueryResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.process_query_key):
            query['processQueryKey'] = request.process_query_key
        if not UtilClient.is_unset(request.robot_code):
            query['robotCode'] = request.robot_code
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
            action='BatchOTOQuery',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/oToMessages/readStatus',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.BatchOTOQueryResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_otoquery_with_options_async(
        self,
        request: dingtalkrobot__1__0_models.BatchOTOQueryRequest,
        headers: dingtalkrobot__1__0_models.BatchOTOQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.BatchOTOQueryResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.process_query_key):
            query['processQueryKey'] = request.process_query_key
        if not UtilClient.is_unset(request.robot_code):
            query['robotCode'] = request.robot_code
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
            action='BatchOTOQuery',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/oToMessages/readStatus',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.BatchOTOQueryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_otoquery(
        self,
        request: dingtalkrobot__1__0_models.BatchOTOQueryRequest,
    ) -> dingtalkrobot__1__0_models.BatchOTOQueryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.BatchOTOQueryHeaders()
        return self.batch_otoquery_with_options(request, headers, runtime)

    async def batch_otoquery_async(
        self,
        request: dingtalkrobot__1__0_models.BatchOTOQueryRequest,
    ) -> dingtalkrobot__1__0_models.BatchOTOQueryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.BatchOTOQueryHeaders()
        return await self.batch_otoquery_with_options_async(request, headers, runtime)

    def batch_recall_group_with_options(
        self,
        request: dingtalkrobot__1__0_models.BatchRecallGroupRequest,
        headers: dingtalkrobot__1__0_models.BatchRecallGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.BatchRecallGroupResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.chatbot_id):
            body['chatbotId'] = request.chatbot_id
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.process_query_keys):
            body['processQueryKeys'] = request.process_query_keys
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
            action='BatchRecallGroup',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/groupMessages/batchRecall',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.BatchRecallGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_recall_group_with_options_async(
        self,
        request: dingtalkrobot__1__0_models.BatchRecallGroupRequest,
        headers: dingtalkrobot__1__0_models.BatchRecallGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.BatchRecallGroupResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.chatbot_id):
            body['chatbotId'] = request.chatbot_id
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.process_query_keys):
            body['processQueryKeys'] = request.process_query_keys
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
            action='BatchRecallGroup',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/groupMessages/batchRecall',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.BatchRecallGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_recall_group(
        self,
        request: dingtalkrobot__1__0_models.BatchRecallGroupRequest,
    ) -> dingtalkrobot__1__0_models.BatchRecallGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.BatchRecallGroupHeaders()
        return self.batch_recall_group_with_options(request, headers, runtime)

    async def batch_recall_group_async(
        self,
        request: dingtalkrobot__1__0_models.BatchRecallGroupRequest,
    ) -> dingtalkrobot__1__0_models.BatchRecallGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.BatchRecallGroupHeaders()
        return await self.batch_recall_group_with_options_async(request, headers, runtime)

    def batch_recall_otowith_options(
        self,
        request: dingtalkrobot__1__0_models.BatchRecallOTORequest,
        headers: dingtalkrobot__1__0_models.BatchRecallOTOHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.BatchRecallOTOResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.process_query_keys):
            body['processQueryKeys'] = request.process_query_keys
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
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
            action='BatchRecallOTO',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/otoMessages/batchRecall',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.BatchRecallOTOResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_recall_otowith_options_async(
        self,
        request: dingtalkrobot__1__0_models.BatchRecallOTORequest,
        headers: dingtalkrobot__1__0_models.BatchRecallOTOHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.BatchRecallOTOResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.process_query_keys):
            body['processQueryKeys'] = request.process_query_keys
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
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
            action='BatchRecallOTO',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/otoMessages/batchRecall',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.BatchRecallOTOResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_recall_oto(
        self,
        request: dingtalkrobot__1__0_models.BatchRecallOTORequest,
    ) -> dingtalkrobot__1__0_models.BatchRecallOTOResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.BatchRecallOTOHeaders()
        return self.batch_recall_otowith_options(request, headers, runtime)

    async def batch_recall_oto_async(
        self,
        request: dingtalkrobot__1__0_models.BatchRecallOTORequest,
    ) -> dingtalkrobot__1__0_models.BatchRecallOTOResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.BatchRecallOTOHeaders()
        return await self.batch_recall_otowith_options_async(request, headers, runtime)

    def batch_recall_private_chat_with_options(
        self,
        request: dingtalkrobot__1__0_models.BatchRecallPrivateChatRequest,
        headers: dingtalkrobot__1__0_models.BatchRecallPrivateChatHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.BatchRecallPrivateChatResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.process_query_keys):
            body['processQueryKeys'] = request.process_query_keys
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
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
            action='BatchRecallPrivateChat',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/privateChatMessages/batchRecall',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.BatchRecallPrivateChatResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_recall_private_chat_with_options_async(
        self,
        request: dingtalkrobot__1__0_models.BatchRecallPrivateChatRequest,
        headers: dingtalkrobot__1__0_models.BatchRecallPrivateChatHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.BatchRecallPrivateChatResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.process_query_keys):
            body['processQueryKeys'] = request.process_query_keys
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
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
            action='BatchRecallPrivateChat',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/privateChatMessages/batchRecall',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.BatchRecallPrivateChatResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_recall_private_chat(
        self,
        request: dingtalkrobot__1__0_models.BatchRecallPrivateChatRequest,
    ) -> dingtalkrobot__1__0_models.BatchRecallPrivateChatResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.BatchRecallPrivateChatHeaders()
        return self.batch_recall_private_chat_with_options(request, headers, runtime)

    async def batch_recall_private_chat_async(
        self,
        request: dingtalkrobot__1__0_models.BatchRecallPrivateChatRequest,
    ) -> dingtalkrobot__1__0_models.BatchRecallPrivateChatResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.BatchRecallPrivateChatHeaders()
        return await self.batch_recall_private_chat_with_options_async(request, headers, runtime)

    def batch_send_otowith_options(
        self,
        request: dingtalkrobot__1__0_models.BatchSendOTORequest,
        headers: dingtalkrobot__1__0_models.BatchSendOTOHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.BatchSendOTOResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.msg_key):
            body['msgKey'] = request.msg_key
        if not UtilClient.is_unset(request.msg_param):
            body['msgParam'] = request.msg_param
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
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
            action='BatchSendOTO',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/oToMessages/batchSend',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.BatchSendOTOResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_send_otowith_options_async(
        self,
        request: dingtalkrobot__1__0_models.BatchSendOTORequest,
        headers: dingtalkrobot__1__0_models.BatchSendOTOHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.BatchSendOTOResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.msg_key):
            body['msgKey'] = request.msg_key
        if not UtilClient.is_unset(request.msg_param):
            body['msgParam'] = request.msg_param
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
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
            action='BatchSendOTO',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/oToMessages/batchSend',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.BatchSendOTOResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_send_oto(
        self,
        request: dingtalkrobot__1__0_models.BatchSendOTORequest,
    ) -> dingtalkrobot__1__0_models.BatchSendOTOResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.BatchSendOTOHeaders()
        return self.batch_send_otowith_options(request, headers, runtime)

    async def batch_send_oto_async(
        self,
        request: dingtalkrobot__1__0_models.BatchSendOTORequest,
    ) -> dingtalkrobot__1__0_models.BatchSendOTOResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.BatchSendOTOHeaders()
        return await self.batch_send_otowith_options_async(request, headers, runtime)

    def clear_robot_plugin_with_options(
        self,
        request: dingtalkrobot__1__0_models.ClearRobotPluginRequest,
        headers: dingtalkrobot__1__0_models.ClearRobotPluginHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.ClearRobotPluginResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
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
            action='ClearRobotPlugin',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/plugins/clear',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.ClearRobotPluginResponse(),
            self.execute(params, req, runtime)
        )

    async def clear_robot_plugin_with_options_async(
        self,
        request: dingtalkrobot__1__0_models.ClearRobotPluginRequest,
        headers: dingtalkrobot__1__0_models.ClearRobotPluginHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.ClearRobotPluginResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
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
            action='ClearRobotPlugin',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/plugins/clear',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.ClearRobotPluginResponse(),
            await self.execute_async(params, req, runtime)
        )

    def clear_robot_plugin(
        self,
        request: dingtalkrobot__1__0_models.ClearRobotPluginRequest,
    ) -> dingtalkrobot__1__0_models.ClearRobotPluginResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.ClearRobotPluginHeaders()
        return self.clear_robot_plugin_with_options(request, headers, runtime)

    async def clear_robot_plugin_async(
        self,
        request: dingtalkrobot__1__0_models.ClearRobotPluginRequest,
    ) -> dingtalkrobot__1__0_models.ClearRobotPluginResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.ClearRobotPluginHeaders()
        return await self.clear_robot_plugin_with_options_async(request, headers, runtime)

    def execute_robot_ai_skill_with_options(
        self,
        request: dingtalkrobot__1__0_models.ExecuteRobotAiSkillRequest,
        headers: dingtalkrobot__1__0_models.ExecuteRobotAiSkillHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.ExecuteRobotAiSkillResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.context):
            body['context'] = request.context
        if not UtilClient.is_unset(request.input):
            body['input'] = request.input
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
        if not UtilClient.is_unset(request.skill_id):
            body['skillId'] = request.skill_id
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
            action='ExecuteRobotAiSkill',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/aiSkill/execute',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.ExecuteRobotAiSkillResponse(),
            self.execute(params, req, runtime)
        )

    async def execute_robot_ai_skill_with_options_async(
        self,
        request: dingtalkrobot__1__0_models.ExecuteRobotAiSkillRequest,
        headers: dingtalkrobot__1__0_models.ExecuteRobotAiSkillHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.ExecuteRobotAiSkillResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.context):
            body['context'] = request.context
        if not UtilClient.is_unset(request.input):
            body['input'] = request.input
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
        if not UtilClient.is_unset(request.skill_id):
            body['skillId'] = request.skill_id
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
            action='ExecuteRobotAiSkill',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/aiSkill/execute',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.ExecuteRobotAiSkillResponse(),
            await self.execute_async(params, req, runtime)
        )

    def execute_robot_ai_skill(
        self,
        request: dingtalkrobot__1__0_models.ExecuteRobotAiSkillRequest,
    ) -> dingtalkrobot__1__0_models.ExecuteRobotAiSkillResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.ExecuteRobotAiSkillHeaders()
        return self.execute_robot_ai_skill_with_options(request, headers, runtime)

    async def execute_robot_ai_skill_async(
        self,
        request: dingtalkrobot__1__0_models.ExecuteRobotAiSkillRequest,
    ) -> dingtalkrobot__1__0_models.ExecuteRobotAiSkillResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.ExecuteRobotAiSkillHeaders()
        return await self.execute_robot_ai_skill_with_options_async(request, headers, runtime)

    def get_bot_list_in_group_with_options(
        self,
        request: dingtalkrobot__1__0_models.GetBotListInGroupRequest,
        headers: dingtalkrobot__1__0_models.GetBotListInGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.GetBotListInGroupResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
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
            action='GetBotListInGroup',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/groups/robots/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.GetBotListInGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def get_bot_list_in_group_with_options_async(
        self,
        request: dingtalkrobot__1__0_models.GetBotListInGroupRequest,
        headers: dingtalkrobot__1__0_models.GetBotListInGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.GetBotListInGroupResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
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
            action='GetBotListInGroup',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/groups/robots/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.GetBotListInGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_bot_list_in_group(
        self,
        request: dingtalkrobot__1__0_models.GetBotListInGroupRequest,
    ) -> dingtalkrobot__1__0_models.GetBotListInGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.GetBotListInGroupHeaders()
        return self.get_bot_list_in_group_with_options(request, headers, runtime)

    async def get_bot_list_in_group_async(
        self,
        request: dingtalkrobot__1__0_models.GetBotListInGroupRequest,
    ) -> dingtalkrobot__1__0_models.GetBotListInGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.GetBotListInGroupHeaders()
        return await self.get_bot_list_in_group_with_options_async(request, headers, runtime)

    def manage_single_chat_robot_status_with_options(
        self,
        request: dingtalkrobot__1__0_models.ManageSingleChatRobotStatusRequest,
        headers: dingtalkrobot__1__0_models.ManageSingleChatRobotStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.ManageSingleChatRobotStatusResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
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
            action='ManageSingleChatRobotStatus',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/statuses/manage',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.ManageSingleChatRobotStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def manage_single_chat_robot_status_with_options_async(
        self,
        request: dingtalkrobot__1__0_models.ManageSingleChatRobotStatusRequest,
        headers: dingtalkrobot__1__0_models.ManageSingleChatRobotStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.ManageSingleChatRobotStatusResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
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
            action='ManageSingleChatRobotStatus',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/statuses/manage',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.ManageSingleChatRobotStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def manage_single_chat_robot_status(
        self,
        request: dingtalkrobot__1__0_models.ManageSingleChatRobotStatusRequest,
    ) -> dingtalkrobot__1__0_models.ManageSingleChatRobotStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.ManageSingleChatRobotStatusHeaders()
        return self.manage_single_chat_robot_status_with_options(request, headers, runtime)

    async def manage_single_chat_robot_status_async(
        self,
        request: dingtalkrobot__1__0_models.ManageSingleChatRobotStatusRequest,
    ) -> dingtalkrobot__1__0_models.ManageSingleChatRobotStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.ManageSingleChatRobotStatusHeaders()
        return await self.manage_single_chat_robot_status_with_options_async(request, headers, runtime)

    def org_group_query_with_options(
        self,
        request: dingtalkrobot__1__0_models.OrgGroupQueryRequest,
        headers: dingtalkrobot__1__0_models.OrgGroupQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.OrgGroupQueryResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.process_query_key):
            body['processQueryKey'] = request.process_query_key
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
        if not UtilClient.is_unset(request.token):
            body['token'] = request.token
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
            action='OrgGroupQuery',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/groupMessages/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.OrgGroupQueryResponse(),
            self.execute(params, req, runtime)
        )

    async def org_group_query_with_options_async(
        self,
        request: dingtalkrobot__1__0_models.OrgGroupQueryRequest,
        headers: dingtalkrobot__1__0_models.OrgGroupQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.OrgGroupQueryResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.process_query_key):
            body['processQueryKey'] = request.process_query_key
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
        if not UtilClient.is_unset(request.token):
            body['token'] = request.token
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
            action='OrgGroupQuery',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/groupMessages/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.OrgGroupQueryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def org_group_query(
        self,
        request: dingtalkrobot__1__0_models.OrgGroupQueryRequest,
    ) -> dingtalkrobot__1__0_models.OrgGroupQueryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.OrgGroupQueryHeaders()
        return self.org_group_query_with_options(request, headers, runtime)

    async def org_group_query_async(
        self,
        request: dingtalkrobot__1__0_models.OrgGroupQueryRequest,
    ) -> dingtalkrobot__1__0_models.OrgGroupQueryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.OrgGroupQueryHeaders()
        return await self.org_group_query_with_options_async(request, headers, runtime)

    def org_group_recall_with_options(
        self,
        request: dingtalkrobot__1__0_models.OrgGroupRecallRequest,
        headers: dingtalkrobot__1__0_models.OrgGroupRecallHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.OrgGroupRecallResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.process_query_keys):
            body['processQueryKeys'] = request.process_query_keys
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
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
            action='OrgGroupRecall',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/groupMessages/recall',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.OrgGroupRecallResponse(),
            self.execute(params, req, runtime)
        )

    async def org_group_recall_with_options_async(
        self,
        request: dingtalkrobot__1__0_models.OrgGroupRecallRequest,
        headers: dingtalkrobot__1__0_models.OrgGroupRecallHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.OrgGroupRecallResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.process_query_keys):
            body['processQueryKeys'] = request.process_query_keys
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
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
            action='OrgGroupRecall',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/groupMessages/recall',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.OrgGroupRecallResponse(),
            await self.execute_async(params, req, runtime)
        )

    def org_group_recall(
        self,
        request: dingtalkrobot__1__0_models.OrgGroupRecallRequest,
    ) -> dingtalkrobot__1__0_models.OrgGroupRecallResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.OrgGroupRecallHeaders()
        return self.org_group_recall_with_options(request, headers, runtime)

    async def org_group_recall_async(
        self,
        request: dingtalkrobot__1__0_models.OrgGroupRecallRequest,
    ) -> dingtalkrobot__1__0_models.OrgGroupRecallResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.OrgGroupRecallHeaders()
        return await self.org_group_recall_with_options_async(request, headers, runtime)

    def org_group_send_with_options(
        self,
        request: dingtalkrobot__1__0_models.OrgGroupSendRequest,
        headers: dingtalkrobot__1__0_models.OrgGroupSendHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.OrgGroupSendResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.cool_app_code):
            body['coolAppCode'] = request.cool_app_code
        if not UtilClient.is_unset(request.msg_key):
            body['msgKey'] = request.msg_key
        if not UtilClient.is_unset(request.msg_param):
            body['msgParam'] = request.msg_param
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
        if not UtilClient.is_unset(request.token):
            body['token'] = request.token
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
            action='OrgGroupSend',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/groupMessages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.OrgGroupSendResponse(),
            self.execute(params, req, runtime)
        )

    async def org_group_send_with_options_async(
        self,
        request: dingtalkrobot__1__0_models.OrgGroupSendRequest,
        headers: dingtalkrobot__1__0_models.OrgGroupSendHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.OrgGroupSendResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.cool_app_code):
            body['coolAppCode'] = request.cool_app_code
        if not UtilClient.is_unset(request.msg_key):
            body['msgKey'] = request.msg_key
        if not UtilClient.is_unset(request.msg_param):
            body['msgParam'] = request.msg_param
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
        if not UtilClient.is_unset(request.token):
            body['token'] = request.token
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
            action='OrgGroupSend',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/groupMessages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.OrgGroupSendResponse(),
            await self.execute_async(params, req, runtime)
        )

    def org_group_send(
        self,
        request: dingtalkrobot__1__0_models.OrgGroupSendRequest,
    ) -> dingtalkrobot__1__0_models.OrgGroupSendResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.OrgGroupSendHeaders()
        return self.org_group_send_with_options(request, headers, runtime)

    async def org_group_send_async(
        self,
        request: dingtalkrobot__1__0_models.OrgGroupSendRequest,
    ) -> dingtalkrobot__1__0_models.OrgGroupSendResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.OrgGroupSendHeaders()
        return await self.org_group_send_with_options_async(request, headers, runtime)

    def private_chat_query_with_options(
        self,
        request: dingtalkrobot__1__0_models.PrivateChatQueryRequest,
        headers: dingtalkrobot__1__0_models.PrivateChatQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.PrivateChatQueryResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.process_query_key):
            body['processQueryKey'] = request.process_query_key
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
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
            action='PrivateChatQuery',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/privateChatMessages/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.PrivateChatQueryResponse(),
            self.execute(params, req, runtime)
        )

    async def private_chat_query_with_options_async(
        self,
        request: dingtalkrobot__1__0_models.PrivateChatQueryRequest,
        headers: dingtalkrobot__1__0_models.PrivateChatQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.PrivateChatQueryResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.process_query_key):
            body['processQueryKey'] = request.process_query_key
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
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
            action='PrivateChatQuery',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/privateChatMessages/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.PrivateChatQueryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def private_chat_query(
        self,
        request: dingtalkrobot__1__0_models.PrivateChatQueryRequest,
    ) -> dingtalkrobot__1__0_models.PrivateChatQueryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.PrivateChatQueryHeaders()
        return self.private_chat_query_with_options(request, headers, runtime)

    async def private_chat_query_async(
        self,
        request: dingtalkrobot__1__0_models.PrivateChatQueryRequest,
    ) -> dingtalkrobot__1__0_models.PrivateChatQueryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.PrivateChatQueryHeaders()
        return await self.private_chat_query_with_options_async(request, headers, runtime)

    def private_chat_send_with_options(
        self,
        request: dingtalkrobot__1__0_models.PrivateChatSendRequest,
        headers: dingtalkrobot__1__0_models.PrivateChatSendHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.PrivateChatSendResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.cool_app_code):
            body['coolAppCode'] = request.cool_app_code
        if not UtilClient.is_unset(request.msg_key):
            body['msgKey'] = request.msg_key
        if not UtilClient.is_unset(request.msg_param):
            body['msgParam'] = request.msg_param
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
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
            action='PrivateChatSend',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/privateChatMessages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.PrivateChatSendResponse(),
            self.execute(params, req, runtime)
        )

    async def private_chat_send_with_options_async(
        self,
        request: dingtalkrobot__1__0_models.PrivateChatSendRequest,
        headers: dingtalkrobot__1__0_models.PrivateChatSendHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.PrivateChatSendResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.cool_app_code):
            body['coolAppCode'] = request.cool_app_code
        if not UtilClient.is_unset(request.msg_key):
            body['msgKey'] = request.msg_key
        if not UtilClient.is_unset(request.msg_param):
            body['msgParam'] = request.msg_param
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
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
            action='PrivateChatSend',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/privateChatMessages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.PrivateChatSendResponse(),
            await self.execute_async(params, req, runtime)
        )

    def private_chat_send(
        self,
        request: dingtalkrobot__1__0_models.PrivateChatSendRequest,
    ) -> dingtalkrobot__1__0_models.PrivateChatSendResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.PrivateChatSendHeaders()
        return self.private_chat_send_with_options(request, headers, runtime)

    async def private_chat_send_async(
        self,
        request: dingtalkrobot__1__0_models.PrivateChatSendRequest,
    ) -> dingtalkrobot__1__0_models.PrivateChatSendResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.PrivateChatSendHeaders()
        return await self.private_chat_send_with_options_async(request, headers, runtime)

    def query_bot_instance_in_group_info_with_options(
        self,
        request: dingtalkrobot__1__0_models.QueryBotInstanceInGroupInfoRequest,
        headers: dingtalkrobot__1__0_models.QueryBotInstanceInGroupInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.QueryBotInstanceInGroupInfoResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
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
            action='QueryBotInstanceInGroupInfo',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/groups/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.QueryBotInstanceInGroupInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def query_bot_instance_in_group_info_with_options_async(
        self,
        request: dingtalkrobot__1__0_models.QueryBotInstanceInGroupInfoRequest,
        headers: dingtalkrobot__1__0_models.QueryBotInstanceInGroupInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.QueryBotInstanceInGroupInfoResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
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
            action='QueryBotInstanceInGroupInfo',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/groups/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.QueryBotInstanceInGroupInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_bot_instance_in_group_info(
        self,
        request: dingtalkrobot__1__0_models.QueryBotInstanceInGroupInfoRequest,
    ) -> dingtalkrobot__1__0_models.QueryBotInstanceInGroupInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.QueryBotInstanceInGroupInfoHeaders()
        return self.query_bot_instance_in_group_info_with_options(request, headers, runtime)

    async def query_bot_instance_in_group_info_async(
        self,
        request: dingtalkrobot__1__0_models.QueryBotInstanceInGroupInfoRequest,
    ) -> dingtalkrobot__1__0_models.QueryBotInstanceInGroupInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.QueryBotInstanceInGroupInfoHeaders()
        return await self.query_bot_instance_in_group_info_with_options_async(request, headers, runtime)

    def query_robot_plugin_with_options(
        self,
        request: dingtalkrobot__1__0_models.QueryRobotPluginRequest,
        headers: dingtalkrobot__1__0_models.QueryRobotPluginHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.QueryRobotPluginResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
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
            action='QueryRobotPlugin',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/plugins/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.QueryRobotPluginResponse(),
            self.execute(params, req, runtime)
        )

    async def query_robot_plugin_with_options_async(
        self,
        request: dingtalkrobot__1__0_models.QueryRobotPluginRequest,
        headers: dingtalkrobot__1__0_models.QueryRobotPluginHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.QueryRobotPluginResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
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
            action='QueryRobotPlugin',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/plugins/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.QueryRobotPluginResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_robot_plugin(
        self,
        request: dingtalkrobot__1__0_models.QueryRobotPluginRequest,
    ) -> dingtalkrobot__1__0_models.QueryRobotPluginResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.QueryRobotPluginHeaders()
        return self.query_robot_plugin_with_options(request, headers, runtime)

    async def query_robot_plugin_async(
        self,
        request: dingtalkrobot__1__0_models.QueryRobotPluginRequest,
    ) -> dingtalkrobot__1__0_models.QueryRobotPluginResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.QueryRobotPluginHeaders()
        return await self.query_robot_plugin_with_options_async(request, headers, runtime)

    def robot_message_file_download_with_options(
        self,
        request: dingtalkrobot__1__0_models.RobotMessageFileDownloadRequest,
        headers: dingtalkrobot__1__0_models.RobotMessageFileDownloadHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.RobotMessageFileDownloadResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.download_code):
            body['downloadCode'] = request.download_code
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
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
            action='RobotMessageFileDownload',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/messageFiles/download',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.RobotMessageFileDownloadResponse(),
            self.execute(params, req, runtime)
        )

    async def robot_message_file_download_with_options_async(
        self,
        request: dingtalkrobot__1__0_models.RobotMessageFileDownloadRequest,
        headers: dingtalkrobot__1__0_models.RobotMessageFileDownloadHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.RobotMessageFileDownloadResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.download_code):
            body['downloadCode'] = request.download_code
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
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
            action='RobotMessageFileDownload',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/messageFiles/download',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.RobotMessageFileDownloadResponse(),
            await self.execute_async(params, req, runtime)
        )

    def robot_message_file_download(
        self,
        request: dingtalkrobot__1__0_models.RobotMessageFileDownloadRequest,
    ) -> dingtalkrobot__1__0_models.RobotMessageFileDownloadResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.RobotMessageFileDownloadHeaders()
        return self.robot_message_file_download_with_options(request, headers, runtime)

    async def robot_message_file_download_async(
        self,
        request: dingtalkrobot__1__0_models.RobotMessageFileDownloadRequest,
    ) -> dingtalkrobot__1__0_models.RobotMessageFileDownloadResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.RobotMessageFileDownloadHeaders()
        return await self.robot_message_file_download_with_options_async(request, headers, runtime)

    def robot_recall_ding_with_options(
        self,
        request: dingtalkrobot__1__0_models.RobotRecallDingRequest,
        headers: dingtalkrobot__1__0_models.RobotRecallDingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.RobotRecallDingResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_ding_id):
            body['openDingId'] = request.open_ding_id
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
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
            action='RobotRecallDing',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/ding/recall',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.RobotRecallDingResponse(),
            self.execute(params, req, runtime)
        )

    async def robot_recall_ding_with_options_async(
        self,
        request: dingtalkrobot__1__0_models.RobotRecallDingRequest,
        headers: dingtalkrobot__1__0_models.RobotRecallDingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.RobotRecallDingResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_ding_id):
            body['openDingId'] = request.open_ding_id
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
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
            action='RobotRecallDing',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/ding/recall',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.RobotRecallDingResponse(),
            await self.execute_async(params, req, runtime)
        )

    def robot_recall_ding(
        self,
        request: dingtalkrobot__1__0_models.RobotRecallDingRequest,
    ) -> dingtalkrobot__1__0_models.RobotRecallDingResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.RobotRecallDingHeaders()
        return self.robot_recall_ding_with_options(request, headers, runtime)

    async def robot_recall_ding_async(
        self,
        request: dingtalkrobot__1__0_models.RobotRecallDingRequest,
    ) -> dingtalkrobot__1__0_models.RobotRecallDingResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.RobotRecallDingHeaders()
        return await self.robot_recall_ding_with_options_async(request, headers, runtime)

    def robot_send_ding_with_options(
        self,
        request: dingtalkrobot__1__0_models.RobotSendDingRequest,
        headers: dingtalkrobot__1__0_models.RobotSendDingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.RobotSendDingResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.receiver_user_id_list):
            body['receiverUserIdList'] = request.receiver_user_id_list
        if not UtilClient.is_unset(request.remind_type):
            body['remindType'] = request.remind_type
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
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
            action='RobotSendDing',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/ding/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.RobotSendDingResponse(),
            self.execute(params, req, runtime)
        )

    async def robot_send_ding_with_options_async(
        self,
        request: dingtalkrobot__1__0_models.RobotSendDingRequest,
        headers: dingtalkrobot__1__0_models.RobotSendDingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.RobotSendDingResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.receiver_user_id_list):
            body['receiverUserIdList'] = request.receiver_user_id_list
        if not UtilClient.is_unset(request.remind_type):
            body['remindType'] = request.remind_type
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
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
            action='RobotSendDing',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/ding/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.RobotSendDingResponse(),
            await self.execute_async(params, req, runtime)
        )

    def robot_send_ding(
        self,
        request: dingtalkrobot__1__0_models.RobotSendDingRequest,
    ) -> dingtalkrobot__1__0_models.RobotSendDingResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.RobotSendDingHeaders()
        return self.robot_send_ding_with_options(request, headers, runtime)

    async def robot_send_ding_async(
        self,
        request: dingtalkrobot__1__0_models.RobotSendDingRequest,
    ) -> dingtalkrobot__1__0_models.RobotSendDingResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.RobotSendDingHeaders()
        return await self.robot_send_ding_with_options_async(request, headers, runtime)

    def send_robot_ding_message_with_options(
        self,
        request: dingtalkrobot__1__0_models.SendRobotDingMessageRequest,
        headers: dingtalkrobot__1__0_models.SendRobotDingMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.SendRobotDingMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content_params):
            body['contentParams'] = request.content_params
        if not UtilClient.is_unset(request.ding_template_id):
            body['dingTemplateId'] = request.ding_template_id
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.receiver_user_id_list):
            body['receiverUserIdList'] = request.receiver_user_id_list
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
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
            action='SendRobotDingMessage',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/dingMessages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.SendRobotDingMessageResponse(),
            self.execute(params, req, runtime)
        )

    async def send_robot_ding_message_with_options_async(
        self,
        request: dingtalkrobot__1__0_models.SendRobotDingMessageRequest,
        headers: dingtalkrobot__1__0_models.SendRobotDingMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.SendRobotDingMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content_params):
            body['contentParams'] = request.content_params
        if not UtilClient.is_unset(request.ding_template_id):
            body['dingTemplateId'] = request.ding_template_id
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.receiver_user_id_list):
            body['receiverUserIdList'] = request.receiver_user_id_list
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
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
            action='SendRobotDingMessage',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/dingMessages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.SendRobotDingMessageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def send_robot_ding_message(
        self,
        request: dingtalkrobot__1__0_models.SendRobotDingMessageRequest,
    ) -> dingtalkrobot__1__0_models.SendRobotDingMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.SendRobotDingMessageHeaders()
        return self.send_robot_ding_message_with_options(request, headers, runtime)

    async def send_robot_ding_message_async(
        self,
        request: dingtalkrobot__1__0_models.SendRobotDingMessageRequest,
    ) -> dingtalkrobot__1__0_models.SendRobotDingMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.SendRobotDingMessageHeaders()
        return await self.send_robot_ding_message_with_options_async(request, headers, runtime)

    def set_robot_plugin_with_options(
        self,
        request: dingtalkrobot__1__0_models.SetRobotPluginRequest,
        headers: dingtalkrobot__1__0_models.SetRobotPluginHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.SetRobotPluginResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.plugin_info_list):
            body['pluginInfoList'] = request.plugin_info_list
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
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
            action='SetRobotPlugin',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/plugins/set',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.SetRobotPluginResponse(),
            self.execute(params, req, runtime)
        )

    async def set_robot_plugin_with_options_async(
        self,
        request: dingtalkrobot__1__0_models.SetRobotPluginRequest,
        headers: dingtalkrobot__1__0_models.SetRobotPluginHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.SetRobotPluginResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.plugin_info_list):
            body['pluginInfoList'] = request.plugin_info_list
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
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
            action='SetRobotPlugin',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/plugins/set',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.SetRobotPluginResponse(),
            await self.execute_async(params, req, runtime)
        )

    def set_robot_plugin(
        self,
        request: dingtalkrobot__1__0_models.SetRobotPluginRequest,
    ) -> dingtalkrobot__1__0_models.SetRobotPluginResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.SetRobotPluginHeaders()
        return self.set_robot_plugin_with_options(request, headers, runtime)

    async def set_robot_plugin_async(
        self,
        request: dingtalkrobot__1__0_models.SetRobotPluginRequest,
    ) -> dingtalkrobot__1__0_models.SetRobotPluginResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.SetRobotPluginHeaders()
        return await self.set_robot_plugin_with_options_async(request, headers, runtime)

    def update_installed_robot_with_options(
        self,
        request: dingtalkrobot__1__0_models.UpdateInstalledRobotRequest,
        headers: dingtalkrobot__1__0_models.UpdateInstalledRobotHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.UpdateInstalledRobotResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.brief):
            body['brief'] = request.brief
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
        if not UtilClient.is_unset(request.update_type):
            body['updateType'] = request.update_type
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
            action='UpdateInstalledRobot',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/managements/infos',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.UpdateInstalledRobotResponse(),
            self.execute(params, req, runtime)
        )

    async def update_installed_robot_with_options_async(
        self,
        request: dingtalkrobot__1__0_models.UpdateInstalledRobotRequest,
        headers: dingtalkrobot__1__0_models.UpdateInstalledRobotHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrobot__1__0_models.UpdateInstalledRobotResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.brief):
            body['brief'] = request.brief
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
        if not UtilClient.is_unset(request.update_type):
            body['updateType'] = request.update_type
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
            action='UpdateInstalledRobot',
            version='robot_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/robot/managements/infos',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrobot__1__0_models.UpdateInstalledRobotResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_installed_robot(
        self,
        request: dingtalkrobot__1__0_models.UpdateInstalledRobotRequest,
    ) -> dingtalkrobot__1__0_models.UpdateInstalledRobotResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.UpdateInstalledRobotHeaders()
        return self.update_installed_robot_with_options(request, headers, runtime)

    async def update_installed_robot_async(
        self,
        request: dingtalkrobot__1__0_models.UpdateInstalledRobotRequest,
    ) -> dingtalkrobot__1__0_models.UpdateInstalledRobotResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrobot__1__0_models.UpdateInstalledRobotHeaders()
        return await self.update_installed_robot_with_options_async(request, headers, runtime)
