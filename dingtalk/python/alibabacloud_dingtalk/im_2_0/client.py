# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore
from typing import Dict

from alibabacloud_gateway_spi.client import Client as SPIClient
from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.im_2_0 import models as dingtalkim__2__0_models
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
        self._signature_algorithm = 'v2'
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

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
        params = open_api_models.Params(
            action='CloseTopbox',
            version='im_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/im/topBoxes/close',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__2__0_models.CloseTopboxResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='CloseTopbox',
            version='im_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/im/topBoxes/close',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__2__0_models.CloseTopboxResponse(),
            await self.execute_async(params, req, runtime)
        )

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

    def create_couple_group_with_options(
        self,
        request: dingtalkim__2__0_models.CreateCoupleGroupRequest,
        headers: dingtalkim__2__0_models.CreateCoupleGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__2__0_models.CreateCoupleGroupResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_template_id):
            body['groupTemplateId'] = request.group_template_id
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.users):
            body['users'] = request.users
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
            action='CreateCoupleGroup',
            version='im_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/im/interconnections/couples/groups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__2__0_models.CreateCoupleGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def create_couple_group_with_options_async(
        self,
        request: dingtalkim__2__0_models.CreateCoupleGroupRequest,
        headers: dingtalkim__2__0_models.CreateCoupleGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__2__0_models.CreateCoupleGroupResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_template_id):
            body['groupTemplateId'] = request.group_template_id
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.users):
            body['users'] = request.users
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
            action='CreateCoupleGroup',
            version='im_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/im/interconnections/couples/groups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__2__0_models.CreateCoupleGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_couple_group(
        self,
        request: dingtalkim__2__0_models.CreateCoupleGroupRequest,
    ) -> dingtalkim__2__0_models.CreateCoupleGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__2__0_models.CreateCoupleGroupHeaders()
        return self.create_couple_group_with_options(request, headers, runtime)

    async def create_couple_group_async(
        self,
        request: dingtalkim__2__0_models.CreateCoupleGroupRequest,
    ) -> dingtalkim__2__0_models.CreateCoupleGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__2__0_models.CreateCoupleGroupHeaders()
        return await self.create_couple_group_with_options_async(request, headers, runtime)

    def create_group_with_options(
        self,
        request: dingtalkim__2__0_models.CreateGroupRequest,
        headers: dingtalkim__2__0_models.CreateGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__2__0_models.CreateGroupResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_avatar):
            body['groupAvatar'] = request.group_avatar
        if not UtilClient.is_unset(request.group_name):
            body['groupName'] = request.group_name
        if not UtilClient.is_unset(request.group_template_id):
            body['groupTemplateId'] = request.group_template_id
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.users):
            body['users'] = request.users
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
            action='CreateGroup',
            version='im_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/im/interconnections/groups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__2__0_models.CreateGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def create_group_with_options_async(
        self,
        request: dingtalkim__2__0_models.CreateGroupRequest,
        headers: dingtalkim__2__0_models.CreateGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__2__0_models.CreateGroupResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_avatar):
            body['groupAvatar'] = request.group_avatar
        if not UtilClient.is_unset(request.group_name):
            body['groupName'] = request.group_name
        if not UtilClient.is_unset(request.group_template_id):
            body['groupTemplateId'] = request.group_template_id
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.users):
            body['users'] = request.users
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
            action='CreateGroup',
            version='im_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/im/interconnections/groups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__2__0_models.CreateGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_group(
        self,
        request: dingtalkim__2__0_models.CreateGroupRequest,
    ) -> dingtalkim__2__0_models.CreateGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__2__0_models.CreateGroupHeaders()
        return self.create_group_with_options(request, headers, runtime)

    async def create_group_async(
        self,
        request: dingtalkim__2__0_models.CreateGroupRequest,
    ) -> dingtalkim__2__0_models.CreateGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__2__0_models.CreateGroupHeaders()
        return await self.create_group_with_options_async(request, headers, runtime)

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
        params = open_api_models.Params(
            action='CreateTopbox',
            version='im_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/im/topBoxes',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__2__0_models.CreateTopboxResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='CreateTopbox',
            version='im_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/im/topBoxes',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__2__0_models.CreateTopboxResponse(),
            await self.execute_async(params, req, runtime)
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

    def group_manager_device_market_with_options(
        self,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__2__0_models.GroupManagerDeviceMarketResponse:
        req = open_api_models.OpenApiRequest(
            headers=headers
        )
        params = open_api_models.Params(
            action='GroupManagerDeviceMarket',
            version='im_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/im/group/device/market/manager',
            method='GET',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__2__0_models.GroupManagerDeviceMarketResponse(),
            self.execute(params, req, runtime)
        )

    async def group_manager_device_market_with_options_async(
        self,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__2__0_models.GroupManagerDeviceMarketResponse:
        req = open_api_models.OpenApiRequest(
            headers=headers
        )
        params = open_api_models.Params(
            action='GroupManagerDeviceMarket',
            version='im_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/im/group/device/market/manager',
            method='GET',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__2__0_models.GroupManagerDeviceMarketResponse(),
            await self.execute_async(params, req, runtime)
        )

    def group_manager_device_market(self) -> dingtalkim__2__0_models.GroupManagerDeviceMarketResponse:
        runtime = util_models.RuntimeOptions()
        headers = {}
        return self.group_manager_device_market_with_options(headers, runtime)

    async def group_manager_device_market_async(self) -> dingtalkim__2__0_models.GroupManagerDeviceMarketResponse:
        runtime = util_models.RuntimeOptions()
        headers = {}
        return await self.group_manager_device_market_with_options_async(headers, runtime)
