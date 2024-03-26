# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_gateway_spi.client import Client as SPIClient
from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.ai_interaction_1_0 import models as dingtalkai_interaction__1__0_models
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

    def finish_with_options(
        self,
        request: dingtalkai_interaction__1__0_models.FinishRequest,
        headers: dingtalkai_interaction__1__0_models.FinishHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_interaction__1__0_models.FinishResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.conversation_token):
            body['conversationToken'] = request.conversation_token
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
            action='Finish',
            version='aiInteraction_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiInteraction/finish',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_interaction__1__0_models.FinishResponse(),
            self.execute(params, req, runtime)
        )

    async def finish_with_options_async(
        self,
        request: dingtalkai_interaction__1__0_models.FinishRequest,
        headers: dingtalkai_interaction__1__0_models.FinishHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_interaction__1__0_models.FinishResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.conversation_token):
            body['conversationToken'] = request.conversation_token
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
            action='Finish',
            version='aiInteraction_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiInteraction/finish',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_interaction__1__0_models.FinishResponse(),
            await self.execute_async(params, req, runtime)
        )

    def finish(
        self,
        request: dingtalkai_interaction__1__0_models.FinishRequest,
    ) -> dingtalkai_interaction__1__0_models.FinishResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_interaction__1__0_models.FinishHeaders()
        return self.finish_with_options(request, headers, runtime)

    async def finish_async(
        self,
        request: dingtalkai_interaction__1__0_models.FinishRequest,
    ) -> dingtalkai_interaction__1__0_models.FinishResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_interaction__1__0_models.FinishHeaders()
        return await self.finish_with_options_async(request, headers, runtime)

    def prepare_with_options(
        self,
        request: dingtalkai_interaction__1__0_models.PrepareRequest,
        headers: dingtalkai_interaction__1__0_models.PrepareHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_interaction__1__0_models.PrepareResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.content_type):
            body['contentType'] = request.content_type
        if not UtilClient.is_unset(request.conversation_type):
            body['conversationType'] = request.conversation_type
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
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
            action='Prepare',
            version='aiInteraction_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiInteraction/prepare',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_interaction__1__0_models.PrepareResponse(),
            self.execute(params, req, runtime)
        )

    async def prepare_with_options_async(
        self,
        request: dingtalkai_interaction__1__0_models.PrepareRequest,
        headers: dingtalkai_interaction__1__0_models.PrepareHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_interaction__1__0_models.PrepareResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.content_type):
            body['contentType'] = request.content_type
        if not UtilClient.is_unset(request.conversation_type):
            body['conversationType'] = request.conversation_type
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
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
            action='Prepare',
            version='aiInteraction_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiInteraction/prepare',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_interaction__1__0_models.PrepareResponse(),
            await self.execute_async(params, req, runtime)
        )

    def prepare(
        self,
        request: dingtalkai_interaction__1__0_models.PrepareRequest,
    ) -> dingtalkai_interaction__1__0_models.PrepareResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_interaction__1__0_models.PrepareHeaders()
        return self.prepare_with_options(request, headers, runtime)

    async def prepare_async(
        self,
        request: dingtalkai_interaction__1__0_models.PrepareRequest,
    ) -> dingtalkai_interaction__1__0_models.PrepareResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_interaction__1__0_models.PrepareHeaders()
        return await self.prepare_with_options_async(request, headers, runtime)

    def reply_with_options(
        self,
        request: dingtalkai_interaction__1__0_models.ReplyRequest,
        headers: dingtalkai_interaction__1__0_models.ReplyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_interaction__1__0_models.ReplyResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.content_type):
            body['contentType'] = request.content_type
        if not UtilClient.is_unset(request.conversation_token):
            body['conversationToken'] = request.conversation_token
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
            action='Reply',
            version='aiInteraction_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiInteraction/reply',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_interaction__1__0_models.ReplyResponse(),
            self.execute(params, req, runtime)
        )

    async def reply_with_options_async(
        self,
        request: dingtalkai_interaction__1__0_models.ReplyRequest,
        headers: dingtalkai_interaction__1__0_models.ReplyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_interaction__1__0_models.ReplyResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.content_type):
            body['contentType'] = request.content_type
        if not UtilClient.is_unset(request.conversation_token):
            body['conversationToken'] = request.conversation_token
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
            action='Reply',
            version='aiInteraction_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiInteraction/reply',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_interaction__1__0_models.ReplyResponse(),
            await self.execute_async(params, req, runtime)
        )

    def reply(
        self,
        request: dingtalkai_interaction__1__0_models.ReplyRequest,
    ) -> dingtalkai_interaction__1__0_models.ReplyResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_interaction__1__0_models.ReplyHeaders()
        return self.reply_with_options(request, headers, runtime)

    async def reply_async(
        self,
        request: dingtalkai_interaction__1__0_models.ReplyRequest,
    ) -> dingtalkai_interaction__1__0_models.ReplyResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_interaction__1__0_models.ReplyHeaders()
        return await self.reply_with_options_async(request, headers, runtime)

    def update_with_options(
        self,
        request: dingtalkai_interaction__1__0_models.UpdateRequest,
        headers: dingtalkai_interaction__1__0_models.UpdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_interaction__1__0_models.UpdateResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.content_type):
            body['contentType'] = request.content_type
        if not UtilClient.is_unset(request.conversation_token):
            body['conversationToken'] = request.conversation_token
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
            action='Update',
            version='aiInteraction_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiInteraction/update',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_interaction__1__0_models.UpdateResponse(),
            self.execute(params, req, runtime)
        )

    async def update_with_options_async(
        self,
        request: dingtalkai_interaction__1__0_models.UpdateRequest,
        headers: dingtalkai_interaction__1__0_models.UpdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkai_interaction__1__0_models.UpdateResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.content_type):
            body['contentType'] = request.content_type
        if not UtilClient.is_unset(request.conversation_token):
            body['conversationToken'] = request.conversation_token
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
            action='Update',
            version='aiInteraction_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/aiInteraction/update',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkai_interaction__1__0_models.UpdateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update(
        self,
        request: dingtalkai_interaction__1__0_models.UpdateRequest,
    ) -> dingtalkai_interaction__1__0_models.UpdateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_interaction__1__0_models.UpdateHeaders()
        return self.update_with_options(request, headers, runtime)

    async def update_async(
        self,
        request: dingtalkai_interaction__1__0_models.UpdateRequest,
    ) -> dingtalkai_interaction__1__0_models.UpdateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkai_interaction__1__0_models.UpdateHeaders()
        return await self.update_with_options_async(request, headers, runtime)
