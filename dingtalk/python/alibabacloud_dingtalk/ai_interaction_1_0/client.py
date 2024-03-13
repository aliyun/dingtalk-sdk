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
