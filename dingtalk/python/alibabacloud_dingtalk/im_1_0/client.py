# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalkim_1_0 import models as dingtalkim__1__0_models
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

    def send_interactive_card(
        self,
        request: dingtalkim__1__0_models.SendInteractiveCardRequest,
    ) -> dingtalkim__1__0_models.SendInteractiveCardResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.SendInteractiveCardHeaders()
        return self.send_interactive_card_with_options(request, headers, runtime)

    async def send_interactive_card_async(
        self,
        request: dingtalkim__1__0_models.SendInteractiveCardRequest,
    ) -> dingtalkim__1__0_models.SendInteractiveCardResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.SendInteractiveCardHeaders()
        return await self.send_interactive_card_with_options_async(request, headers, runtime)

    def send_interactive_card_with_options(
        self,
        request: dingtalkim__1__0_models.SendInteractiveCardRequest,
        headers: dingtalkim__1__0_models.SendInteractiveCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.SendInteractiveCardResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.card_template_id):
            body['cardTemplateId'] = request.card_template_id
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.receiver_user_id_list):
            body['receiverUserIdList'] = request.receiver_user_id_list
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.out_track_id):
            body['outTrackId'] = request.out_track_id
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.conversation_type):
            body['conversationType'] = request.conversation_type
        if not UtilClient.is_unset(request.callback_route_key):
            body['callbackRouteKey'] = request.callback_route_key
        if not UtilClient.is_unset(request.card_data):
            body['cardData'] = request.card_data
        if not UtilClient.is_unset(request.private_data):
            body['privateData'] = request.private_data
        if not UtilClient.is_unset(request.ding_oauth_app_id):
            body['dingOauthAppId'] = request.ding_oauth_app_id
        if not UtilClient.is_unset(request.chat_bot_id):
            body['chatBotId'] = request.chat_bot_id
        if not UtilClient.is_unset(request.user_id_type):
            body['userIdType'] = request.user_id_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return dingtalkim__1__0_models.SendInteractiveCardResponse().from_map(
            self.do_roarequest('SendInteractiveCard', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/interactiveCards/send', 'json', req, runtime)
        )

    async def send_interactive_card_with_options_async(
        self,
        request: dingtalkim__1__0_models.SendInteractiveCardRequest,
        headers: dingtalkim__1__0_models.SendInteractiveCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.SendInteractiveCardResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.card_template_id):
            body['cardTemplateId'] = request.card_template_id
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.receiver_user_id_list):
            body['receiverUserIdList'] = request.receiver_user_id_list
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.out_track_id):
            body['outTrackId'] = request.out_track_id
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.conversation_type):
            body['conversationType'] = request.conversation_type
        if not UtilClient.is_unset(request.callback_route_key):
            body['callbackRouteKey'] = request.callback_route_key
        if not UtilClient.is_unset(request.card_data):
            body['cardData'] = request.card_data
        if not UtilClient.is_unset(request.private_data):
            body['privateData'] = request.private_data
        if not UtilClient.is_unset(request.ding_oauth_app_id):
            body['dingOauthAppId'] = request.ding_oauth_app_id
        if not UtilClient.is_unset(request.chat_bot_id):
            body['chatBotId'] = request.chat_bot_id
        if not UtilClient.is_unset(request.user_id_type):
            body['userIdType'] = request.user_id_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return dingtalkim__1__0_models.SendInteractiveCardResponse().from_map(
            await self.do_roarequest_async('SendInteractiveCard', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/interactiveCards/send', 'json', req, runtime)
        )

    def update_interactive_card(
        self,
        request: dingtalkim__1__0_models.UpdateInteractiveCardRequest,
    ) -> dingtalkim__1__0_models.UpdateInteractiveCardResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateInteractiveCardHeaders()
        return self.update_interactive_card_with_options(request, headers, runtime)

    async def update_interactive_card_async(
        self,
        request: dingtalkim__1__0_models.UpdateInteractiveCardRequest,
    ) -> dingtalkim__1__0_models.UpdateInteractiveCardResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateInteractiveCardHeaders()
        return await self.update_interactive_card_with_options_async(request, headers, runtime)

    def update_interactive_card_with_options(
        self,
        request: dingtalkim__1__0_models.UpdateInteractiveCardRequest,
        headers: dingtalkim__1__0_models.UpdateInteractiveCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.UpdateInteractiveCardResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.out_track_id):
            body['outTrackId'] = request.out_track_id
        if not UtilClient.is_unset(request.card_data):
            body['cardData'] = request.card_data
        if not UtilClient.is_unset(request.private_data):
            body['privateData'] = request.private_data
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.ding_oauth_app_id):
            body['dingOauthAppId'] = request.ding_oauth_app_id
        if not UtilClient.is_unset(request.user_id_type):
            body['userIdType'] = request.user_id_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return dingtalkim__1__0_models.UpdateInteractiveCardResponse().from_map(
            self.do_roarequest('UpdateInteractiveCard', 'im_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/im/interactiveCards', 'json', req, runtime)
        )

    async def update_interactive_card_with_options_async(
        self,
        request: dingtalkim__1__0_models.UpdateInteractiveCardRequest,
        headers: dingtalkim__1__0_models.UpdateInteractiveCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.UpdateInteractiveCardResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.out_track_id):
            body['outTrackId'] = request.out_track_id
        if not UtilClient.is_unset(request.card_data):
            body['cardData'] = request.card_data
        if not UtilClient.is_unset(request.private_data):
            body['privateData'] = request.private_data
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.ding_oauth_app_id):
            body['dingOauthAppId'] = request.ding_oauth_app_id
        if not UtilClient.is_unset(request.user_id_type):
            body['userIdType'] = request.user_id_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return dingtalkim__1__0_models.UpdateInteractiveCardResponse().from_map(
            await self.do_roarequest_async('UpdateInteractiveCard', 'im_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/im/interactiveCards', 'json', req, runtime)
        )
