# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.im_2_0 import models as dingtalkim__2__0_models
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

    def close_topbox(
        self,
        request: dingtalkim__2__0_models.CloseTopboxRequest,
    ) -> dingtalkim__2__0_models.CloseTopboxResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__2__0_models.CloseTopboxHeaders()
        return self.close_topbox_with_options(request, headers, runtime)

    async def close_topbox_async(
        self,
        request: dingtalkim__2__0_models.CloseTopboxRequest,
    ) -> dingtalkim__2__0_models.CloseTopboxResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__2__0_models.CloseTopboxHeaders()
        return await self.close_topbox_with_options_async(request, headers, runtime)

    def close_topbox_with_options(
        self,
        request: dingtalkim__2__0_models.CloseTopboxRequest,
        headers: dingtalkim__2__0_models.CloseTopboxHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__2__0_models.CloseTopboxResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.conversation_type):
            body['conversationType'] = request.conversation_type
        if not UtilClient.is_unset(request.cool_app_code):
            body['coolAppCode'] = request.cool_app_code
        if not UtilClient.is_unset(request.group_template_id):
            body['groupTemplateId'] = request.group_template_id
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.out_track_id):
            body['outTrackId'] = request.out_track_id
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
        if not UtilClient.is_unset(request.unoin_id):
            body['unoinId'] = request.unoin_id
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
            dingtalkim__2__0_models.CloseTopboxResponse(),
            self.do_roarequest('CloseTopbox', 'im_2.0', 'HTTP', 'POST', 'AK', f'/v2.0/im/topBoxes/close', 'json', req, runtime)
        )

    async def close_topbox_with_options_async(
        self,
        request: dingtalkim__2__0_models.CloseTopboxRequest,
        headers: dingtalkim__2__0_models.CloseTopboxHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__2__0_models.CloseTopboxResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.conversation_type):
            body['conversationType'] = request.conversation_type
        if not UtilClient.is_unset(request.cool_app_code):
            body['coolAppCode'] = request.cool_app_code
        if not UtilClient.is_unset(request.group_template_id):
            body['groupTemplateId'] = request.group_template_id
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.out_track_id):
            body['outTrackId'] = request.out_track_id
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
        if not UtilClient.is_unset(request.unoin_id):
            body['unoinId'] = request.unoin_id
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
            dingtalkim__2__0_models.CloseTopboxResponse(),
            await self.do_roarequest_async('CloseTopbox', 'im_2.0', 'HTTP', 'POST', 'AK', f'/v2.0/im/topBoxes/close', 'json', req, runtime)
        )

    def create_topbox(
        self,
        request: dingtalkim__2__0_models.CreateTopboxRequest,
    ) -> dingtalkim__2__0_models.CreateTopboxResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__2__0_models.CreateTopboxHeaders()
        return self.create_topbox_with_options(request, headers, runtime)

    async def create_topbox_async(
        self,
        request: dingtalkim__2__0_models.CreateTopboxRequest,
    ) -> dingtalkim__2__0_models.CreateTopboxResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__2__0_models.CreateTopboxHeaders()
        return await self.create_topbox_with_options_async(request, headers, runtime)

    def create_topbox_with_options(
        self,
        request: dingtalkim__2__0_models.CreateTopboxRequest,
        headers: dingtalkim__2__0_models.CreateTopboxHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__2__0_models.CreateTopboxResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.callback_route_key):
            body['callbackRouteKey'] = request.callback_route_key
        if not UtilClient.is_unset(request.card_data):
            body['cardData'] = request.card_data
        if not UtilClient.is_unset(request.card_settings):
            body['cardSettings'] = request.card_settings
        if not UtilClient.is_unset(request.card_template_id):
            body['cardTemplateId'] = request.card_template_id
        if not UtilClient.is_unset(request.conversation_type):
            body['conversationType'] = request.conversation_type
        if not UtilClient.is_unset(request.cool_app_code):
            body['coolAppCode'] = request.cool_app_code
        if not UtilClient.is_unset(request.expired_time):
            body['expiredTime'] = request.expired_time
        if not UtilClient.is_unset(request.group_template_id):
            body['groupTemplateId'] = request.group_template_id
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.out_track_id):
            body['outTrackId'] = request.out_track_id
        if not UtilClient.is_unset(request.platforms):
            body['platforms'] = request.platforms
        if not UtilClient.is_unset(request.receiver_union_id_list):
            body['receiverUnionIdList'] = request.receiver_union_id_list
        if not UtilClient.is_unset(request.receiver_user_id_list):
            body['receiverUserIdList'] = request.receiver_user_id_list
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
        if not UtilClient.is_unset(request.union_id_private_data_map):
            body['unionIdPrivateDataMap'] = request.union_id_private_data_map
        if not UtilClient.is_unset(request.unoin_id):
            body['unoinId'] = request.unoin_id
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.user_id_private_data_map):
            body['userIdPrivateDataMap'] = request.user_id_private_data_map
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
            dingtalkim__2__0_models.CreateTopboxResponse(),
            self.do_roarequest('CreateTopbox', 'im_2.0', 'HTTP', 'POST', 'AK', f'/v2.0/im/topBoxes', 'json', req, runtime)
        )

    async def create_topbox_with_options_async(
        self,
        request: dingtalkim__2__0_models.CreateTopboxRequest,
        headers: dingtalkim__2__0_models.CreateTopboxHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__2__0_models.CreateTopboxResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.callback_route_key):
            body['callbackRouteKey'] = request.callback_route_key
        if not UtilClient.is_unset(request.card_data):
            body['cardData'] = request.card_data
        if not UtilClient.is_unset(request.card_settings):
            body['cardSettings'] = request.card_settings
        if not UtilClient.is_unset(request.card_template_id):
            body['cardTemplateId'] = request.card_template_id
        if not UtilClient.is_unset(request.conversation_type):
            body['conversationType'] = request.conversation_type
        if not UtilClient.is_unset(request.cool_app_code):
            body['coolAppCode'] = request.cool_app_code
        if not UtilClient.is_unset(request.expired_time):
            body['expiredTime'] = request.expired_time
        if not UtilClient.is_unset(request.group_template_id):
            body['groupTemplateId'] = request.group_template_id
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.out_track_id):
            body['outTrackId'] = request.out_track_id
        if not UtilClient.is_unset(request.platforms):
            body['platforms'] = request.platforms
        if not UtilClient.is_unset(request.receiver_union_id_list):
            body['receiverUnionIdList'] = request.receiver_union_id_list
        if not UtilClient.is_unset(request.receiver_user_id_list):
            body['receiverUserIdList'] = request.receiver_user_id_list
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
        if not UtilClient.is_unset(request.union_id_private_data_map):
            body['unionIdPrivateDataMap'] = request.union_id_private_data_map
        if not UtilClient.is_unset(request.unoin_id):
            body['unoinId'] = request.unoin_id
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.user_id_private_data_map):
            body['userIdPrivateDataMap'] = request.user_id_private_data_map
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
            dingtalkim__2__0_models.CreateTopboxResponse(),
            await self.do_roarequest_async('CreateTopbox', 'im_2.0', 'HTTP', 'POST', 'AK', f'/v2.0/im/topBoxes', 'json', req, runtime)
        )
