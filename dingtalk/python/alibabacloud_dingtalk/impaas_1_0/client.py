# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalkimpaas_1_0 import models as dingtalkimpaas__1__0_models
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

    def get_conversation_id(
        self,
        request: dingtalkimpaas__1__0_models.GetConversationIdRequest,
    ) -> dingtalkimpaas__1__0_models.GetConversationIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.GetConversationIdHeaders()
        return self.get_conversation_id_with_options(request, headers, runtime)

    async def get_conversation_id_async(
        self,
        request: dingtalkimpaas__1__0_models.GetConversationIdRequest,
    ) -> dingtalkimpaas__1__0_models.GetConversationIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.GetConversationIdHeaders()
        return await self.get_conversation_id_with_options_async(request, headers, runtime)

    def get_conversation_id_with_options(
        self,
        request: dingtalkimpaas__1__0_models.GetConversationIdRequest,
        headers: dingtalkimpaas__1__0_models.GetConversationIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.GetConversationIdResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.app_uid):
            body['appUid'] = request.app_uid
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.GetConversationIdResponse(),
            self.do_roarequest('GetConversationId', 'impaas_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/impaas/interconnections/conversations', 'json', req, runtime)
        )

    async def get_conversation_id_with_options_async(
        self,
        request: dingtalkimpaas__1__0_models.GetConversationIdRequest,
        headers: dingtalkimpaas__1__0_models.GetConversationIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.GetConversationIdResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.app_uid):
            body['appUid'] = request.app_uid
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.GetConversationIdResponse(),
            await self.do_roarequest_async('GetConversationId', 'impaas_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/impaas/interconnections/conversations', 'json', req, runtime)
        )

    def recall_message(
        self,
        request: dingtalkimpaas__1__0_models.RecallMessageRequest,
    ) -> dingtalkimpaas__1__0_models.RecallMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.RecallMessageHeaders()
        return self.recall_message_with_options(request, headers, runtime)

    async def recall_message_async(
        self,
        request: dingtalkimpaas__1__0_models.RecallMessageRequest,
    ) -> dingtalkimpaas__1__0_models.RecallMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.RecallMessageHeaders()
        return await self.recall_message_with_options_async(request, headers, runtime)

    def recall_message_with_options(
        self,
        request: dingtalkimpaas__1__0_models.RecallMessageRequest,
        headers: dingtalkimpaas__1__0_models.RecallMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.RecallMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator_uid):
            body['operatorUid'] = request.operator_uid
        if not UtilClient.is_unset(request.message_id):
            body['messageId'] = request.message_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.RecallMessageResponse(),
            self.do_roarequest('RecallMessage', 'impaas_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/impaas/interconnections/messages/recall', 'none', req, runtime)
        )

    async def recall_message_with_options_async(
        self,
        request: dingtalkimpaas__1__0_models.RecallMessageRequest,
        headers: dingtalkimpaas__1__0_models.RecallMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.RecallMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator_uid):
            body['operatorUid'] = request.operator_uid
        if not UtilClient.is_unset(request.message_id):
            body['messageId'] = request.message_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.RecallMessageResponse(),
            await self.do_roarequest_async('RecallMessage', 'impaas_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/impaas/interconnections/messages/recall', 'none', req, runtime)
        )

    def get_media_url(
        self,
        request: dingtalkimpaas__1__0_models.GetMediaUrlRequest,
    ) -> dingtalkimpaas__1__0_models.GetMediaUrlResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.GetMediaUrlHeaders()
        return self.get_media_url_with_options(request, headers, runtime)

    async def get_media_url_async(
        self,
        request: dingtalkimpaas__1__0_models.GetMediaUrlRequest,
    ) -> dingtalkimpaas__1__0_models.GetMediaUrlResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.GetMediaUrlHeaders()
        return await self.get_media_url_with_options_async(request, headers, runtime)

    def get_media_url_with_options(
        self,
        request: dingtalkimpaas__1__0_models.GetMediaUrlRequest,
        headers: dingtalkimpaas__1__0_models.GetMediaUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.GetMediaUrlResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.media_id):
            body['mediaId'] = request.media_id
        if not UtilClient.is_unset(request.url_expire_time):
            body['urlExpireTime'] = request.url_expire_time
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.GetMediaUrlResponse(),
            self.do_roarequest('GetMediaUrl', 'impaas_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/impaas/interconnections/medium/urls', 'json', req, runtime)
        )

    async def get_media_url_with_options_async(
        self,
        request: dingtalkimpaas__1__0_models.GetMediaUrlRequest,
        headers: dingtalkimpaas__1__0_models.GetMediaUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.GetMediaUrlResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.media_id):
            body['mediaId'] = request.media_id
        if not UtilClient.is_unset(request.url_expire_time):
            body['urlExpireTime'] = request.url_expire_time
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.GetMediaUrlResponse(),
            await self.do_roarequest_async('GetMediaUrl', 'impaas_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/impaas/interconnections/medium/urls', 'json', req, runtime)
        )

    def read_message(
        self,
        request: dingtalkimpaas__1__0_models.ReadMessageRequest,
    ) -> dingtalkimpaas__1__0_models.ReadMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.ReadMessageHeaders()
        return self.read_message_with_options(request, headers, runtime)

    async def read_message_async(
        self,
        request: dingtalkimpaas__1__0_models.ReadMessageRequest,
    ) -> dingtalkimpaas__1__0_models.ReadMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.ReadMessageHeaders()
        return await self.read_message_with_options_async(request, headers, runtime)

    def read_message_with_options(
        self,
        request: dingtalkimpaas__1__0_models.ReadMessageRequest,
        headers: dingtalkimpaas__1__0_models.ReadMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.ReadMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator_uid):
            body['operatorUid'] = request.operator_uid
        if not UtilClient.is_unset(request.message_id):
            body['messageId'] = request.message_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.ReadMessageResponse(),
            self.do_roarequest('ReadMessage', 'impaas_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/impaas/interconnections/messages/read', 'none', req, runtime)
        )

    async def read_message_with_options_async(
        self,
        request: dingtalkimpaas__1__0_models.ReadMessageRequest,
        headers: dingtalkimpaas__1__0_models.ReadMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.ReadMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator_uid):
            body['operatorUid'] = request.operator_uid
        if not UtilClient.is_unset(request.message_id):
            body['messageId'] = request.message_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.ReadMessageResponse(),
            await self.do_roarequest_async('ReadMessage', 'impaas_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/impaas/interconnections/messages/read', 'none', req, runtime)
        )

    def add_profile(
        self,
        request: dingtalkimpaas__1__0_models.AddProfileRequest,
    ) -> dingtalkimpaas__1__0_models.AddProfileResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.AddProfileHeaders()
        return self.add_profile_with_options(request, headers, runtime)

    async def add_profile_async(
        self,
        request: dingtalkimpaas__1__0_models.AddProfileRequest,
    ) -> dingtalkimpaas__1__0_models.AddProfileResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.AddProfileHeaders()
        return await self.add_profile_with_options_async(request, headers, runtime)

    def add_profile_with_options(
        self,
        request: dingtalkimpaas__1__0_models.AddProfileRequest,
        headers: dingtalkimpaas__1__0_models.AddProfileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.AddProfileResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.nick):
            body['nick'] = request.nick
        if not UtilClient.is_unset(request.avatar_media_id):
            body['avatarMediaId'] = request.avatar_media_id
        if not UtilClient.is_unset(request.app_uid):
            body['appUid'] = request.app_uid
        if not UtilClient.is_unset(request.mobile_number):
            body['mobileNumber'] = request.mobile_number
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.AddProfileResponse(),
            self.do_roarequest('AddProfile', 'impaas_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/impaas/interconnections/users/profiles', 'none', req, runtime)
        )

    async def add_profile_with_options_async(
        self,
        request: dingtalkimpaas__1__0_models.AddProfileRequest,
        headers: dingtalkimpaas__1__0_models.AddProfileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.AddProfileResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.nick):
            body['nick'] = request.nick
        if not UtilClient.is_unset(request.avatar_media_id):
            body['avatarMediaId'] = request.avatar_media_id
        if not UtilClient.is_unset(request.app_uid):
            body['appUid'] = request.app_uid
        if not UtilClient.is_unset(request.mobile_number):
            body['mobileNumber'] = request.mobile_number
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.AddProfileResponse(),
            await self.do_roarequest_async('AddProfile', 'impaas_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/impaas/interconnections/users/profiles', 'none', req, runtime)
        )

    def send_message(
        self,
        request: dingtalkimpaas__1__0_models.SendMessageRequest,
    ) -> dingtalkimpaas__1__0_models.SendMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.SendMessageHeaders()
        return self.send_message_with_options(request, headers, runtime)

    async def send_message_async(
        self,
        request: dingtalkimpaas__1__0_models.SendMessageRequest,
    ) -> dingtalkimpaas__1__0_models.SendMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkimpaas__1__0_models.SendMessageHeaders()
        return await self.send_message_with_options_async(request, headers, runtime)

    def send_message_with_options(
        self,
        request: dingtalkimpaas__1__0_models.SendMessageRequest,
        headers: dingtalkimpaas__1__0_models.SendMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.SendMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.sender_uid):
            body['senderUid'] = request.sender_uid
        if not UtilClient.is_unset(request.receiver_uid):
            body['receiverUid'] = request.receiver_uid
        if not UtilClient.is_unset(request.conversation_id):
            body['conversationId'] = request.conversation_id
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.uuid):
            body['uuid'] = request.uuid
        if not UtilClient.is_unset(request.create_time):
            body['createTime'] = request.create_time
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.SendMessageResponse(),
            self.do_roarequest('SendMessage', 'impaas_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/impaas/interconnections/messages/send', 'json', req, runtime)
        )

    async def send_message_with_options_async(
        self,
        request: dingtalkimpaas__1__0_models.SendMessageRequest,
        headers: dingtalkimpaas__1__0_models.SendMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkimpaas__1__0_models.SendMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.sender_uid):
            body['senderUid'] = request.sender_uid
        if not UtilClient.is_unset(request.receiver_uid):
            body['receiverUid'] = request.receiver_uid
        if not UtilClient.is_unset(request.conversation_id):
            body['conversationId'] = request.conversation_id
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.uuid):
            body['uuid'] = request.uuid
        if not UtilClient.is_unset(request.create_time):
            body['createTime'] = request.create_time
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkimpaas__1__0_models.SendMessageResponse(),
            await self.do_roarequest_async('SendMessage', 'impaas_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/impaas/interconnections/messages/send', 'json', req, runtime)
        )
