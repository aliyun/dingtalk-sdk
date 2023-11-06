# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_gateway_spi.client import Client as SPIClient
from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.rooms_1_0 import models as dingtalkrooms__1__0_models
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

    def create_device_custom_template_with_options(
        self,
        request: dingtalkrooms__1__0_models.CreateDeviceCustomTemplateRequest,
        headers: dingtalkrooms__1__0_models.CreateDeviceCustomTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.CreateDeviceCustomTemplateResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.bg_img_list):
            body['bgImgList'] = request.bg_img_list
        if not UtilClient.is_unset(request.bg_type):
            body['bgType'] = request.bg_type
        if not UtilClient.is_unset(request.bg_url):
            body['bgUrl'] = request.bg_url
        if not UtilClient.is_unset(request.custom_doc):
            body['customDoc'] = request.custom_doc
        if not UtilClient.is_unset(request.desensitize_user_name):
            body['desensitizeUserName'] = request.desensitize_user_name
        if not UtilClient.is_unset(request.device_union_ids):
            body['deviceUnionIds'] = request.device_union_ids
        if not UtilClient.is_unset(request.group_ids):
            body['groupIds'] = request.group_ids
        if not UtilClient.is_unset(request.hide_server_code_when_projecting):
            body['hideServerCodeWhenProjecting'] = request.hide_server_code_when_projecting
        if not UtilClient.is_unset(request.instruction):
            body['instruction'] = request.instruction
        if not UtilClient.is_unset(request.is_pic_top):
            body['isPicTop'] = request.is_pic_top
        if not UtilClient.is_unset(request.logo):
            body['logo'] = request.logo
        if not UtilClient.is_unset(request.org_name):
            body['orgName'] = request.org_name
        if not UtilClient.is_unset(request.picture_play_interval):
            body['picturePlayInterval'] = request.picture_play_interval
        if not UtilClient.is_unset(request.room_ids):
            body['roomIds'] = request.room_ids
        if not UtilClient.is_unset(request.show_calendar_card):
            body['showCalendarCard'] = request.show_calendar_card
        if not UtilClient.is_unset(request.show_calendar_title):
            body['showCalendarTitle'] = request.show_calendar_title
        if not UtilClient.is_unset(request.show_function_card):
            body['showFunctionCard'] = request.show_function_card
        if not UtilClient.is_unset(request.template_name):
            body['templateName'] = request.template_name
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
            action='CreateDeviceCustomTemplate',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/devices/screens/templates',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.CreateDeviceCustomTemplateResponse(),
            self.execute(params, req, runtime)
        )

    async def create_device_custom_template_with_options_async(
        self,
        request: dingtalkrooms__1__0_models.CreateDeviceCustomTemplateRequest,
        headers: dingtalkrooms__1__0_models.CreateDeviceCustomTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.CreateDeviceCustomTemplateResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.bg_img_list):
            body['bgImgList'] = request.bg_img_list
        if not UtilClient.is_unset(request.bg_type):
            body['bgType'] = request.bg_type
        if not UtilClient.is_unset(request.bg_url):
            body['bgUrl'] = request.bg_url
        if not UtilClient.is_unset(request.custom_doc):
            body['customDoc'] = request.custom_doc
        if not UtilClient.is_unset(request.desensitize_user_name):
            body['desensitizeUserName'] = request.desensitize_user_name
        if not UtilClient.is_unset(request.device_union_ids):
            body['deviceUnionIds'] = request.device_union_ids
        if not UtilClient.is_unset(request.group_ids):
            body['groupIds'] = request.group_ids
        if not UtilClient.is_unset(request.hide_server_code_when_projecting):
            body['hideServerCodeWhenProjecting'] = request.hide_server_code_when_projecting
        if not UtilClient.is_unset(request.instruction):
            body['instruction'] = request.instruction
        if not UtilClient.is_unset(request.is_pic_top):
            body['isPicTop'] = request.is_pic_top
        if not UtilClient.is_unset(request.logo):
            body['logo'] = request.logo
        if not UtilClient.is_unset(request.org_name):
            body['orgName'] = request.org_name
        if not UtilClient.is_unset(request.picture_play_interval):
            body['picturePlayInterval'] = request.picture_play_interval
        if not UtilClient.is_unset(request.room_ids):
            body['roomIds'] = request.room_ids
        if not UtilClient.is_unset(request.show_calendar_card):
            body['showCalendarCard'] = request.show_calendar_card
        if not UtilClient.is_unset(request.show_calendar_title):
            body['showCalendarTitle'] = request.show_calendar_title
        if not UtilClient.is_unset(request.show_function_card):
            body['showFunctionCard'] = request.show_function_card
        if not UtilClient.is_unset(request.template_name):
            body['templateName'] = request.template_name
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
            action='CreateDeviceCustomTemplate',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/devices/screens/templates',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.CreateDeviceCustomTemplateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_device_custom_template(
        self,
        request: dingtalkrooms__1__0_models.CreateDeviceCustomTemplateRequest,
    ) -> dingtalkrooms__1__0_models.CreateDeviceCustomTemplateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.CreateDeviceCustomTemplateHeaders()
        return self.create_device_custom_template_with_options(request, headers, runtime)

    async def create_device_custom_template_async(
        self,
        request: dingtalkrooms__1__0_models.CreateDeviceCustomTemplateRequest,
    ) -> dingtalkrooms__1__0_models.CreateDeviceCustomTemplateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.CreateDeviceCustomTemplateHeaders()
        return await self.create_device_custom_template_with_options_async(request, headers, runtime)

    def create_meeting_room_with_options(
        self,
        request: dingtalkrooms__1__0_models.CreateMeetingRoomRequest,
        headers: dingtalkrooms__1__0_models.CreateMeetingRoomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.CreateMeetingRoomResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.enable_cycle_reservation):
            body['enableCycleReservation'] = request.enable_cycle_reservation
        if not UtilClient.is_unset(request.group_id):
            body['groupId'] = request.group_id
        if not UtilClient.is_unset(request.isv_room_id):
            body['isvRoomId'] = request.isv_room_id
        if not UtilClient.is_unset(request.reservation_authority):
            body['reservationAuthority'] = request.reservation_authority
        if not UtilClient.is_unset(request.room_capacity):
            body['roomCapacity'] = request.room_capacity
        if not UtilClient.is_unset(request.room_label_ids):
            body['roomLabelIds'] = request.room_label_ids
        if not UtilClient.is_unset(request.room_location):
            body['roomLocation'] = request.room_location
        if not UtilClient.is_unset(request.room_name):
            body['roomName'] = request.room_name
        if not UtilClient.is_unset(request.room_picture):
            body['roomPicture'] = request.room_picture
        if not UtilClient.is_unset(request.room_status):
            body['roomStatus'] = request.room_status
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
            action='CreateMeetingRoom',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/meetingrooms',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.CreateMeetingRoomResponse(),
            self.execute(params, req, runtime)
        )

    async def create_meeting_room_with_options_async(
        self,
        request: dingtalkrooms__1__0_models.CreateMeetingRoomRequest,
        headers: dingtalkrooms__1__0_models.CreateMeetingRoomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.CreateMeetingRoomResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.enable_cycle_reservation):
            body['enableCycleReservation'] = request.enable_cycle_reservation
        if not UtilClient.is_unset(request.group_id):
            body['groupId'] = request.group_id
        if not UtilClient.is_unset(request.isv_room_id):
            body['isvRoomId'] = request.isv_room_id
        if not UtilClient.is_unset(request.reservation_authority):
            body['reservationAuthority'] = request.reservation_authority
        if not UtilClient.is_unset(request.room_capacity):
            body['roomCapacity'] = request.room_capacity
        if not UtilClient.is_unset(request.room_label_ids):
            body['roomLabelIds'] = request.room_label_ids
        if not UtilClient.is_unset(request.room_location):
            body['roomLocation'] = request.room_location
        if not UtilClient.is_unset(request.room_name):
            body['roomName'] = request.room_name
        if not UtilClient.is_unset(request.room_picture):
            body['roomPicture'] = request.room_picture
        if not UtilClient.is_unset(request.room_status):
            body['roomStatus'] = request.room_status
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
            action='CreateMeetingRoom',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/meetingrooms',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.CreateMeetingRoomResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_meeting_room(
        self,
        request: dingtalkrooms__1__0_models.CreateMeetingRoomRequest,
    ) -> dingtalkrooms__1__0_models.CreateMeetingRoomResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.CreateMeetingRoomHeaders()
        return self.create_meeting_room_with_options(request, headers, runtime)

    async def create_meeting_room_async(
        self,
        request: dingtalkrooms__1__0_models.CreateMeetingRoomRequest,
    ) -> dingtalkrooms__1__0_models.CreateMeetingRoomResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.CreateMeetingRoomHeaders()
        return await self.create_meeting_room_with_options_async(request, headers, runtime)

    def create_meeting_room_group_with_options(
        self,
        request: dingtalkrooms__1__0_models.CreateMeetingRoomGroupRequest,
        headers: dingtalkrooms__1__0_models.CreateMeetingRoomGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.CreateMeetingRoomGroupResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_name):
            body['groupName'] = request.group_name
        if not UtilClient.is_unset(request.parent_group_id):
            body['parentGroupId'] = request.parent_group_id
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
            action='CreateMeetingRoomGroup',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/groups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.CreateMeetingRoomGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def create_meeting_room_group_with_options_async(
        self,
        request: dingtalkrooms__1__0_models.CreateMeetingRoomGroupRequest,
        headers: dingtalkrooms__1__0_models.CreateMeetingRoomGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.CreateMeetingRoomGroupResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_name):
            body['groupName'] = request.group_name
        if not UtilClient.is_unset(request.parent_group_id):
            body['parentGroupId'] = request.parent_group_id
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
            action='CreateMeetingRoomGroup',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/groups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.CreateMeetingRoomGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_meeting_room_group(
        self,
        request: dingtalkrooms__1__0_models.CreateMeetingRoomGroupRequest,
    ) -> dingtalkrooms__1__0_models.CreateMeetingRoomGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.CreateMeetingRoomGroupHeaders()
        return self.create_meeting_room_group_with_options(request, headers, runtime)

    async def create_meeting_room_group_async(
        self,
        request: dingtalkrooms__1__0_models.CreateMeetingRoomGroupRequest,
    ) -> dingtalkrooms__1__0_models.CreateMeetingRoomGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.CreateMeetingRoomGroupHeaders()
        return await self.create_meeting_room_group_with_options_async(request, headers, runtime)

    def delete_device_custom_template_with_options(
        self,
        request: dingtalkrooms__1__0_models.DeleteDeviceCustomTemplateRequest,
        headers: dingtalkrooms__1__0_models.DeleteDeviceCustomTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.DeleteDeviceCustomTemplateResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
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
            action='DeleteDeviceCustomTemplate',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/devices/screens/templates/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.DeleteDeviceCustomTemplateResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_device_custom_template_with_options_async(
        self,
        request: dingtalkrooms__1__0_models.DeleteDeviceCustomTemplateRequest,
        headers: dingtalkrooms__1__0_models.DeleteDeviceCustomTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.DeleteDeviceCustomTemplateResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
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
            action='DeleteDeviceCustomTemplate',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/devices/screens/templates/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.DeleteDeviceCustomTemplateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_device_custom_template(
        self,
        request: dingtalkrooms__1__0_models.DeleteDeviceCustomTemplateRequest,
    ) -> dingtalkrooms__1__0_models.DeleteDeviceCustomTemplateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.DeleteDeviceCustomTemplateHeaders()
        return self.delete_device_custom_template_with_options(request, headers, runtime)

    async def delete_device_custom_template_async(
        self,
        request: dingtalkrooms__1__0_models.DeleteDeviceCustomTemplateRequest,
    ) -> dingtalkrooms__1__0_models.DeleteDeviceCustomTemplateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.DeleteDeviceCustomTemplateHeaders()
        return await self.delete_device_custom_template_with_options_async(request, headers, runtime)

    def delete_meeting_room_with_options(
        self,
        room_id: str,
        request: dingtalkrooms__1__0_models.DeleteMeetingRoomRequest,
        headers: dingtalkrooms__1__0_models.DeleteMeetingRoomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.DeleteMeetingRoomResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='DeleteMeetingRoom',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/meetingRooms/{room_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.DeleteMeetingRoomResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_meeting_room_with_options_async(
        self,
        room_id: str,
        request: dingtalkrooms__1__0_models.DeleteMeetingRoomRequest,
        headers: dingtalkrooms__1__0_models.DeleteMeetingRoomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.DeleteMeetingRoomResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='DeleteMeetingRoom',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/meetingRooms/{room_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.DeleteMeetingRoomResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_meeting_room(
        self,
        room_id: str,
        request: dingtalkrooms__1__0_models.DeleteMeetingRoomRequest,
    ) -> dingtalkrooms__1__0_models.DeleteMeetingRoomResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.DeleteMeetingRoomHeaders()
        return self.delete_meeting_room_with_options(room_id, request, headers, runtime)

    async def delete_meeting_room_async(
        self,
        room_id: str,
        request: dingtalkrooms__1__0_models.DeleteMeetingRoomRequest,
    ) -> dingtalkrooms__1__0_models.DeleteMeetingRoomResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.DeleteMeetingRoomHeaders()
        return await self.delete_meeting_room_with_options_async(room_id, request, headers, runtime)

    def delete_meeting_room_group_with_options(
        self,
        group_id: str,
        request: dingtalkrooms__1__0_models.DeleteMeetingRoomGroupRequest,
        headers: dingtalkrooms__1__0_models.DeleteMeetingRoomGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.DeleteMeetingRoomGroupResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='DeleteMeetingRoomGroup',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/groups/{group_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.DeleteMeetingRoomGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_meeting_room_group_with_options_async(
        self,
        group_id: str,
        request: dingtalkrooms__1__0_models.DeleteMeetingRoomGroupRequest,
        headers: dingtalkrooms__1__0_models.DeleteMeetingRoomGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.DeleteMeetingRoomGroupResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='DeleteMeetingRoomGroup',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/groups/{group_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.DeleteMeetingRoomGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_meeting_room_group(
        self,
        group_id: str,
        request: dingtalkrooms__1__0_models.DeleteMeetingRoomGroupRequest,
    ) -> dingtalkrooms__1__0_models.DeleteMeetingRoomGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.DeleteMeetingRoomGroupHeaders()
        return self.delete_meeting_room_group_with_options(group_id, request, headers, runtime)

    async def delete_meeting_room_group_async(
        self,
        group_id: str,
        request: dingtalkrooms__1__0_models.DeleteMeetingRoomGroupRequest,
    ) -> dingtalkrooms__1__0_models.DeleteMeetingRoomGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.DeleteMeetingRoomGroupHeaders()
        return await self.delete_meeting_room_group_with_options_async(group_id, request, headers, runtime)

    def query_device_custom_template_with_options(
        self,
        template_id: str,
        headers: dingtalkrooms__1__0_models.QueryDeviceCustomTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.QueryDeviceCustomTemplateResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='QueryDeviceCustomTemplate',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/devices/screens/templates/{template_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.QueryDeviceCustomTemplateResponse(),
            self.execute(params, req, runtime)
        )

    async def query_device_custom_template_with_options_async(
        self,
        template_id: str,
        headers: dingtalkrooms__1__0_models.QueryDeviceCustomTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.QueryDeviceCustomTemplateResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='QueryDeviceCustomTemplate',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/devices/screens/templates/{template_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.QueryDeviceCustomTemplateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_device_custom_template(
        self,
        template_id: str,
    ) -> dingtalkrooms__1__0_models.QueryDeviceCustomTemplateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.QueryDeviceCustomTemplateHeaders()
        return self.query_device_custom_template_with_options(template_id, headers, runtime)

    async def query_device_custom_template_async(
        self,
        template_id: str,
    ) -> dingtalkrooms__1__0_models.QueryDeviceCustomTemplateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.QueryDeviceCustomTemplateHeaders()
        return await self.query_device_custom_template_with_options_async(template_id, headers, runtime)

    def query_device_custom_template_list_with_options(
        self,
        headers: dingtalkrooms__1__0_models.QueryDeviceCustomTemplateListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.QueryDeviceCustomTemplateListResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='QueryDeviceCustomTemplateList',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/devices/screens/templateLists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.QueryDeviceCustomTemplateListResponse(),
            self.execute(params, req, runtime)
        )

    async def query_device_custom_template_list_with_options_async(
        self,
        headers: dingtalkrooms__1__0_models.QueryDeviceCustomTemplateListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.QueryDeviceCustomTemplateListResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='QueryDeviceCustomTemplateList',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/devices/screens/templateLists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.QueryDeviceCustomTemplateListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_device_custom_template_list(self) -> dingtalkrooms__1__0_models.QueryDeviceCustomTemplateListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.QueryDeviceCustomTemplateListHeaders()
        return self.query_device_custom_template_list_with_options(headers, runtime)

    async def query_device_custom_template_list_async(self) -> dingtalkrooms__1__0_models.QueryDeviceCustomTemplateListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.QueryDeviceCustomTemplateListHeaders()
        return await self.query_device_custom_template_list_with_options_async(headers, runtime)

    def query_device_ip_by_code_with_options(
        self,
        share_code: str,
        request: dingtalkrooms__1__0_models.QueryDeviceIpByCodeRequest,
        headers: dingtalkrooms__1__0_models.QueryDeviceIpByCodeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.QueryDeviceIpByCodeResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.device_sn):
            query['deviceSn'] = request.device_sn
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
            action='QueryDeviceIpByCode',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/devices/shareCodes/{share_code}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.QueryDeviceIpByCodeResponse(),
            self.execute(params, req, runtime)
        )

    async def query_device_ip_by_code_with_options_async(
        self,
        share_code: str,
        request: dingtalkrooms__1__0_models.QueryDeviceIpByCodeRequest,
        headers: dingtalkrooms__1__0_models.QueryDeviceIpByCodeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.QueryDeviceIpByCodeResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.device_sn):
            query['deviceSn'] = request.device_sn
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
            action='QueryDeviceIpByCode',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/devices/shareCodes/{share_code}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.QueryDeviceIpByCodeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_device_ip_by_code(
        self,
        share_code: str,
        request: dingtalkrooms__1__0_models.QueryDeviceIpByCodeRequest,
    ) -> dingtalkrooms__1__0_models.QueryDeviceIpByCodeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.QueryDeviceIpByCodeHeaders()
        return self.query_device_ip_by_code_with_options(share_code, request, headers, runtime)

    async def query_device_ip_by_code_async(
        self,
        share_code: str,
        request: dingtalkrooms__1__0_models.QueryDeviceIpByCodeRequest,
    ) -> dingtalkrooms__1__0_models.QueryDeviceIpByCodeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.QueryDeviceIpByCodeHeaders()
        return await self.query_device_ip_by_code_with_options_async(share_code, request, headers, runtime)

    def query_device_properties_with_options(
        self,
        request: dingtalkrooms__1__0_models.QueryDevicePropertiesRequest,
        headers: dingtalkrooms__1__0_models.QueryDevicePropertiesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.QueryDevicePropertiesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.device_id):
            query['deviceId'] = request.device_id
        if not UtilClient.is_unset(request.device_union_id):
            query['deviceUnionId'] = request.device_union_id
        if not UtilClient.is_unset(request.operator_union_id):
            query['operatorUnionId'] = request.operator_union_id
        body = {}
        if not UtilClient.is_unset(request.property_names):
            body['propertyNames'] = request.property_names
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='QueryDeviceProperties',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/devices/properties/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.QueryDevicePropertiesResponse(),
            self.execute(params, req, runtime)
        )

    async def query_device_properties_with_options_async(
        self,
        request: dingtalkrooms__1__0_models.QueryDevicePropertiesRequest,
        headers: dingtalkrooms__1__0_models.QueryDevicePropertiesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.QueryDevicePropertiesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.device_id):
            query['deviceId'] = request.device_id
        if not UtilClient.is_unset(request.device_union_id):
            query['deviceUnionId'] = request.device_union_id
        if not UtilClient.is_unset(request.operator_union_id):
            query['operatorUnionId'] = request.operator_union_id
        body = {}
        if not UtilClient.is_unset(request.property_names):
            body['propertyNames'] = request.property_names
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='QueryDeviceProperties',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/devices/properties/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.QueryDevicePropertiesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_device_properties(
        self,
        request: dingtalkrooms__1__0_models.QueryDevicePropertiesRequest,
    ) -> dingtalkrooms__1__0_models.QueryDevicePropertiesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.QueryDevicePropertiesHeaders()
        return self.query_device_properties_with_options(request, headers, runtime)

    async def query_device_properties_async(
        self,
        request: dingtalkrooms__1__0_models.QueryDevicePropertiesRequest,
    ) -> dingtalkrooms__1__0_models.QueryDevicePropertiesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.QueryDevicePropertiesHeaders()
        return await self.query_device_properties_with_options_async(request, headers, runtime)

    def query_meeting_room_with_options(
        self,
        room_id: str,
        request: dingtalkrooms__1__0_models.QueryMeetingRoomRequest,
        headers: dingtalkrooms__1__0_models.QueryMeetingRoomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.QueryMeetingRoomResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='QueryMeetingRoom',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/meetingRooms/{room_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.QueryMeetingRoomResponse(),
            self.execute(params, req, runtime)
        )

    async def query_meeting_room_with_options_async(
        self,
        room_id: str,
        request: dingtalkrooms__1__0_models.QueryMeetingRoomRequest,
        headers: dingtalkrooms__1__0_models.QueryMeetingRoomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.QueryMeetingRoomResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='QueryMeetingRoom',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/meetingRooms/{room_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.QueryMeetingRoomResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_meeting_room(
        self,
        room_id: str,
        request: dingtalkrooms__1__0_models.QueryMeetingRoomRequest,
    ) -> dingtalkrooms__1__0_models.QueryMeetingRoomResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.QueryMeetingRoomHeaders()
        return self.query_meeting_room_with_options(room_id, request, headers, runtime)

    async def query_meeting_room_async(
        self,
        room_id: str,
        request: dingtalkrooms__1__0_models.QueryMeetingRoomRequest,
    ) -> dingtalkrooms__1__0_models.QueryMeetingRoomResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.QueryMeetingRoomHeaders()
        return await self.query_meeting_room_with_options_async(room_id, request, headers, runtime)

    def query_meeting_room_device_with_options(
        self,
        request: dingtalkrooms__1__0_models.QueryMeetingRoomDeviceRequest,
        headers: dingtalkrooms__1__0_models.QueryMeetingRoomDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.QueryMeetingRoomDeviceResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.device_id):
            query['deviceId'] = request.device_id
        if not UtilClient.is_unset(request.device_union_id):
            query['deviceUnionId'] = request.device_union_id
        if not UtilClient.is_unset(request.operator_union_id):
            query['operatorUnionId'] = request.operator_union_id
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
            action='QueryMeetingRoomDevice',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/devices',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.QueryMeetingRoomDeviceResponse(),
            self.execute(params, req, runtime)
        )

    async def query_meeting_room_device_with_options_async(
        self,
        request: dingtalkrooms__1__0_models.QueryMeetingRoomDeviceRequest,
        headers: dingtalkrooms__1__0_models.QueryMeetingRoomDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.QueryMeetingRoomDeviceResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.device_id):
            query['deviceId'] = request.device_id
        if not UtilClient.is_unset(request.device_union_id):
            query['deviceUnionId'] = request.device_union_id
        if not UtilClient.is_unset(request.operator_union_id):
            query['operatorUnionId'] = request.operator_union_id
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
            action='QueryMeetingRoomDevice',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/devices',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.QueryMeetingRoomDeviceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_meeting_room_device(
        self,
        request: dingtalkrooms__1__0_models.QueryMeetingRoomDeviceRequest,
    ) -> dingtalkrooms__1__0_models.QueryMeetingRoomDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.QueryMeetingRoomDeviceHeaders()
        return self.query_meeting_room_device_with_options(request, headers, runtime)

    async def query_meeting_room_device_async(
        self,
        request: dingtalkrooms__1__0_models.QueryMeetingRoomDeviceRequest,
    ) -> dingtalkrooms__1__0_models.QueryMeetingRoomDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.QueryMeetingRoomDeviceHeaders()
        return await self.query_meeting_room_device_with_options_async(request, headers, runtime)

    def query_meeting_room_group_with_options(
        self,
        group_id: str,
        request: dingtalkrooms__1__0_models.QueryMeetingRoomGroupRequest,
        headers: dingtalkrooms__1__0_models.QueryMeetingRoomGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.QueryMeetingRoomGroupResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='QueryMeetingRoomGroup',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/groups/{group_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.QueryMeetingRoomGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def query_meeting_room_group_with_options_async(
        self,
        group_id: str,
        request: dingtalkrooms__1__0_models.QueryMeetingRoomGroupRequest,
        headers: dingtalkrooms__1__0_models.QueryMeetingRoomGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.QueryMeetingRoomGroupResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='QueryMeetingRoomGroup',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/groups/{group_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.QueryMeetingRoomGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_meeting_room_group(
        self,
        group_id: str,
        request: dingtalkrooms__1__0_models.QueryMeetingRoomGroupRequest,
    ) -> dingtalkrooms__1__0_models.QueryMeetingRoomGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.QueryMeetingRoomGroupHeaders()
        return self.query_meeting_room_group_with_options(group_id, request, headers, runtime)

    async def query_meeting_room_group_async(
        self,
        group_id: str,
        request: dingtalkrooms__1__0_models.QueryMeetingRoomGroupRequest,
    ) -> dingtalkrooms__1__0_models.QueryMeetingRoomGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.QueryMeetingRoomGroupHeaders()
        return await self.query_meeting_room_group_with_options_async(group_id, request, headers, runtime)

    def query_meeting_room_group_list_with_options(
        self,
        request: dingtalkrooms__1__0_models.QueryMeetingRoomGroupListRequest,
        headers: dingtalkrooms__1__0_models.QueryMeetingRoomGroupListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.QueryMeetingRoomGroupListResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='QueryMeetingRoomGroupList',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/groupLists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.QueryMeetingRoomGroupListResponse(),
            self.execute(params, req, runtime)
        )

    async def query_meeting_room_group_list_with_options_async(
        self,
        request: dingtalkrooms__1__0_models.QueryMeetingRoomGroupListRequest,
        headers: dingtalkrooms__1__0_models.QueryMeetingRoomGroupListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.QueryMeetingRoomGroupListResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='QueryMeetingRoomGroupList',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/groupLists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.QueryMeetingRoomGroupListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_meeting_room_group_list(
        self,
        request: dingtalkrooms__1__0_models.QueryMeetingRoomGroupListRequest,
    ) -> dingtalkrooms__1__0_models.QueryMeetingRoomGroupListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.QueryMeetingRoomGroupListHeaders()
        return self.query_meeting_room_group_list_with_options(request, headers, runtime)

    async def query_meeting_room_group_list_async(
        self,
        request: dingtalkrooms__1__0_models.QueryMeetingRoomGroupListRequest,
    ) -> dingtalkrooms__1__0_models.QueryMeetingRoomGroupListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.QueryMeetingRoomGroupListHeaders()
        return await self.query_meeting_room_group_list_with_options_async(request, headers, runtime)

    def query_meeting_room_list_with_options(
        self,
        request: dingtalkrooms__1__0_models.QueryMeetingRoomListRequest,
        headers: dingtalkrooms__1__0_models.QueryMeetingRoomListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.QueryMeetingRoomListResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='QueryMeetingRoomList',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/meetingRoomLists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.QueryMeetingRoomListResponse(),
            self.execute(params, req, runtime)
        )

    async def query_meeting_room_list_with_options_async(
        self,
        request: dingtalkrooms__1__0_models.QueryMeetingRoomListRequest,
        headers: dingtalkrooms__1__0_models.QueryMeetingRoomListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.QueryMeetingRoomListResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='QueryMeetingRoomList',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/meetingRoomLists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.QueryMeetingRoomListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_meeting_room_list(
        self,
        request: dingtalkrooms__1__0_models.QueryMeetingRoomListRequest,
    ) -> dingtalkrooms__1__0_models.QueryMeetingRoomListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.QueryMeetingRoomListHeaders()
        return self.query_meeting_room_list_with_options(request, headers, runtime)

    async def query_meeting_room_list_async(
        self,
        request: dingtalkrooms__1__0_models.QueryMeetingRoomListRequest,
    ) -> dingtalkrooms__1__0_models.QueryMeetingRoomListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.QueryMeetingRoomListHeaders()
        return await self.query_meeting_room_list_with_options_async(request, headers, runtime)

    def remove_super_user_meeting_room_with_options(
        self,
        request: dingtalkrooms__1__0_models.RemoveSuperUserMeetingRoomRequest,
        headers: dingtalkrooms__1__0_models.RemoveSuperUserMeetingRoomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.RemoveSuperUserMeetingRoomResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.room_id):
            query['roomId'] = request.room_id
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='RemoveSuperUserMeetingRoom',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/meetingRooms/superUsers/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.RemoveSuperUserMeetingRoomResponse(),
            self.execute(params, req, runtime)
        )

    async def remove_super_user_meeting_room_with_options_async(
        self,
        request: dingtalkrooms__1__0_models.RemoveSuperUserMeetingRoomRequest,
        headers: dingtalkrooms__1__0_models.RemoveSuperUserMeetingRoomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.RemoveSuperUserMeetingRoomResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.room_id):
            query['roomId'] = request.room_id
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='RemoveSuperUserMeetingRoom',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/meetingRooms/superUsers/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.RemoveSuperUserMeetingRoomResponse(),
            await self.execute_async(params, req, runtime)
        )

    def remove_super_user_meeting_room(
        self,
        request: dingtalkrooms__1__0_models.RemoveSuperUserMeetingRoomRequest,
    ) -> dingtalkrooms__1__0_models.RemoveSuperUserMeetingRoomResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.RemoveSuperUserMeetingRoomHeaders()
        return self.remove_super_user_meeting_room_with_options(request, headers, runtime)

    async def remove_super_user_meeting_room_async(
        self,
        request: dingtalkrooms__1__0_models.RemoveSuperUserMeetingRoomRequest,
    ) -> dingtalkrooms__1__0_models.RemoveSuperUserMeetingRoomResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.RemoveSuperUserMeetingRoomHeaders()
        return await self.remove_super_user_meeting_room_with_options_async(request, headers, runtime)

    def set_super_user_meeting_room_with_options(
        self,
        request: dingtalkrooms__1__0_models.SetSuperUserMeetingRoomRequest,
        headers: dingtalkrooms__1__0_models.SetSuperUserMeetingRoomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.SetSuperUserMeetingRoomResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_id_white_list):
            body['deptIdWhiteList'] = request.dept_id_white_list
        if not UtilClient.is_unset(request.room_id):
            body['roomId'] = request.room_id
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
        if not UtilClient.is_unset(request.user_id_white_list):
            body['userIdWhiteList'] = request.user_id_white_list
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
            action='SetSuperUserMeetingRoom',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/meetingRooms/superUsers/set',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.SetSuperUserMeetingRoomResponse(),
            self.execute(params, req, runtime)
        )

    async def set_super_user_meeting_room_with_options_async(
        self,
        request: dingtalkrooms__1__0_models.SetSuperUserMeetingRoomRequest,
        headers: dingtalkrooms__1__0_models.SetSuperUserMeetingRoomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.SetSuperUserMeetingRoomResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_id_white_list):
            body['deptIdWhiteList'] = request.dept_id_white_list
        if not UtilClient.is_unset(request.room_id):
            body['roomId'] = request.room_id
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
        if not UtilClient.is_unset(request.user_id_white_list):
            body['userIdWhiteList'] = request.user_id_white_list
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
            action='SetSuperUserMeetingRoom',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/meetingRooms/superUsers/set',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.SetSuperUserMeetingRoomResponse(),
            await self.execute_async(params, req, runtime)
        )

    def set_super_user_meeting_room(
        self,
        request: dingtalkrooms__1__0_models.SetSuperUserMeetingRoomRequest,
    ) -> dingtalkrooms__1__0_models.SetSuperUserMeetingRoomResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.SetSuperUserMeetingRoomHeaders()
        return self.set_super_user_meeting_room_with_options(request, headers, runtime)

    async def set_super_user_meeting_room_async(
        self,
        request: dingtalkrooms__1__0_models.SetSuperUserMeetingRoomRequest,
    ) -> dingtalkrooms__1__0_models.SetSuperUserMeetingRoomResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.SetSuperUserMeetingRoomHeaders()
        return await self.set_super_user_meeting_room_with_options_async(request, headers, runtime)

    def update_device_custom_template_with_options(
        self,
        request: dingtalkrooms__1__0_models.UpdateDeviceCustomTemplateRequest,
        headers: dingtalkrooms__1__0_models.UpdateDeviceCustomTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.UpdateDeviceCustomTemplateResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.bg_img_list):
            body['bgImgList'] = request.bg_img_list
        if not UtilClient.is_unset(request.bg_type):
            body['bgType'] = request.bg_type
        if not UtilClient.is_unset(request.bg_url):
            body['bgUrl'] = request.bg_url
        if not UtilClient.is_unset(request.custom_doc):
            body['customDoc'] = request.custom_doc
        if not UtilClient.is_unset(request.desensitize_user_name):
            body['desensitizeUserName'] = request.desensitize_user_name
        if not UtilClient.is_unset(request.device_union_ids):
            body['deviceUnionIds'] = request.device_union_ids
        if not UtilClient.is_unset(request.group_ids):
            body['groupIds'] = request.group_ids
        if not UtilClient.is_unset(request.hide_server_code_when_projecting):
            body['hideServerCodeWhenProjecting'] = request.hide_server_code_when_projecting
        if not UtilClient.is_unset(request.instruction):
            body['instruction'] = request.instruction
        if not UtilClient.is_unset(request.is_pic_top):
            body['isPicTop'] = request.is_pic_top
        if not UtilClient.is_unset(request.logo):
            body['logo'] = request.logo
        if not UtilClient.is_unset(request.org_name):
            body['orgName'] = request.org_name
        if not UtilClient.is_unset(request.picture_play_interval):
            body['picturePlayInterval'] = request.picture_play_interval
        if not UtilClient.is_unset(request.room_ids):
            body['roomIds'] = request.room_ids
        if not UtilClient.is_unset(request.show_calendar_card):
            body['showCalendarCard'] = request.show_calendar_card
        if not UtilClient.is_unset(request.show_calendar_title):
            body['showCalendarTitle'] = request.show_calendar_title
        if not UtilClient.is_unset(request.show_function_card):
            body['showFunctionCard'] = request.show_function_card
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
        if not UtilClient.is_unset(request.template_name):
            body['templateName'] = request.template_name
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
            action='UpdateDeviceCustomTemplate',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/devices/screens/templates',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.UpdateDeviceCustomTemplateResponse(),
            self.execute(params, req, runtime)
        )

    async def update_device_custom_template_with_options_async(
        self,
        request: dingtalkrooms__1__0_models.UpdateDeviceCustomTemplateRequest,
        headers: dingtalkrooms__1__0_models.UpdateDeviceCustomTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.UpdateDeviceCustomTemplateResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.bg_img_list):
            body['bgImgList'] = request.bg_img_list
        if not UtilClient.is_unset(request.bg_type):
            body['bgType'] = request.bg_type
        if not UtilClient.is_unset(request.bg_url):
            body['bgUrl'] = request.bg_url
        if not UtilClient.is_unset(request.custom_doc):
            body['customDoc'] = request.custom_doc
        if not UtilClient.is_unset(request.desensitize_user_name):
            body['desensitizeUserName'] = request.desensitize_user_name
        if not UtilClient.is_unset(request.device_union_ids):
            body['deviceUnionIds'] = request.device_union_ids
        if not UtilClient.is_unset(request.group_ids):
            body['groupIds'] = request.group_ids
        if not UtilClient.is_unset(request.hide_server_code_when_projecting):
            body['hideServerCodeWhenProjecting'] = request.hide_server_code_when_projecting
        if not UtilClient.is_unset(request.instruction):
            body['instruction'] = request.instruction
        if not UtilClient.is_unset(request.is_pic_top):
            body['isPicTop'] = request.is_pic_top
        if not UtilClient.is_unset(request.logo):
            body['logo'] = request.logo
        if not UtilClient.is_unset(request.org_name):
            body['orgName'] = request.org_name
        if not UtilClient.is_unset(request.picture_play_interval):
            body['picturePlayInterval'] = request.picture_play_interval
        if not UtilClient.is_unset(request.room_ids):
            body['roomIds'] = request.room_ids
        if not UtilClient.is_unset(request.show_calendar_card):
            body['showCalendarCard'] = request.show_calendar_card
        if not UtilClient.is_unset(request.show_calendar_title):
            body['showCalendarTitle'] = request.show_calendar_title
        if not UtilClient.is_unset(request.show_function_card):
            body['showFunctionCard'] = request.show_function_card
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
        if not UtilClient.is_unset(request.template_name):
            body['templateName'] = request.template_name
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
            action='UpdateDeviceCustomTemplate',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/devices/screens/templates',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.UpdateDeviceCustomTemplateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_device_custom_template(
        self,
        request: dingtalkrooms__1__0_models.UpdateDeviceCustomTemplateRequest,
    ) -> dingtalkrooms__1__0_models.UpdateDeviceCustomTemplateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.UpdateDeviceCustomTemplateHeaders()
        return self.update_device_custom_template_with_options(request, headers, runtime)

    async def update_device_custom_template_async(
        self,
        request: dingtalkrooms__1__0_models.UpdateDeviceCustomTemplateRequest,
    ) -> dingtalkrooms__1__0_models.UpdateDeviceCustomTemplateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.UpdateDeviceCustomTemplateHeaders()
        return await self.update_device_custom_template_with_options_async(request, headers, runtime)

    def update_meeting_room_with_options(
        self,
        request: dingtalkrooms__1__0_models.UpdateMeetingRoomRequest,
        headers: dingtalkrooms__1__0_models.UpdateMeetingRoomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.UpdateMeetingRoomResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.enable_cycle_reservation):
            body['enableCycleReservation'] = request.enable_cycle_reservation
        if not UtilClient.is_unset(request.group_id):
            body['groupId'] = request.group_id
        if not UtilClient.is_unset(request.isv_room_id):
            body['isvRoomId'] = request.isv_room_id
        if not UtilClient.is_unset(request.reservation_authority):
            body['reservationAuthority'] = request.reservation_authority
        if not UtilClient.is_unset(request.room_capacity):
            body['roomCapacity'] = request.room_capacity
        if not UtilClient.is_unset(request.room_id):
            body['roomId'] = request.room_id
        if not UtilClient.is_unset(request.room_label_ids):
            body['roomLabelIds'] = request.room_label_ids
        if not UtilClient.is_unset(request.room_location):
            body['roomLocation'] = request.room_location
        if not UtilClient.is_unset(request.room_name):
            body['roomName'] = request.room_name
        if not UtilClient.is_unset(request.room_picture):
            body['roomPicture'] = request.room_picture
        if not UtilClient.is_unset(request.room_status):
            body['roomStatus'] = request.room_status
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
            action='UpdateMeetingRoom',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/meetingRooms',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.UpdateMeetingRoomResponse(),
            self.execute(params, req, runtime)
        )

    async def update_meeting_room_with_options_async(
        self,
        request: dingtalkrooms__1__0_models.UpdateMeetingRoomRequest,
        headers: dingtalkrooms__1__0_models.UpdateMeetingRoomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.UpdateMeetingRoomResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.enable_cycle_reservation):
            body['enableCycleReservation'] = request.enable_cycle_reservation
        if not UtilClient.is_unset(request.group_id):
            body['groupId'] = request.group_id
        if not UtilClient.is_unset(request.isv_room_id):
            body['isvRoomId'] = request.isv_room_id
        if not UtilClient.is_unset(request.reservation_authority):
            body['reservationAuthority'] = request.reservation_authority
        if not UtilClient.is_unset(request.room_capacity):
            body['roomCapacity'] = request.room_capacity
        if not UtilClient.is_unset(request.room_id):
            body['roomId'] = request.room_id
        if not UtilClient.is_unset(request.room_label_ids):
            body['roomLabelIds'] = request.room_label_ids
        if not UtilClient.is_unset(request.room_location):
            body['roomLocation'] = request.room_location
        if not UtilClient.is_unset(request.room_name):
            body['roomName'] = request.room_name
        if not UtilClient.is_unset(request.room_picture):
            body['roomPicture'] = request.room_picture
        if not UtilClient.is_unset(request.room_status):
            body['roomStatus'] = request.room_status
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
            action='UpdateMeetingRoom',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/meetingRooms',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.UpdateMeetingRoomResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_meeting_room(
        self,
        request: dingtalkrooms__1__0_models.UpdateMeetingRoomRequest,
    ) -> dingtalkrooms__1__0_models.UpdateMeetingRoomResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.UpdateMeetingRoomHeaders()
        return self.update_meeting_room_with_options(request, headers, runtime)

    async def update_meeting_room_async(
        self,
        request: dingtalkrooms__1__0_models.UpdateMeetingRoomRequest,
    ) -> dingtalkrooms__1__0_models.UpdateMeetingRoomResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.UpdateMeetingRoomHeaders()
        return await self.update_meeting_room_with_options_async(request, headers, runtime)

    def update_meeting_room_group_with_options(
        self,
        request: dingtalkrooms__1__0_models.UpdateMeetingRoomGroupRequest,
        headers: dingtalkrooms__1__0_models.UpdateMeetingRoomGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.UpdateMeetingRoomGroupResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_id):
            body['groupId'] = request.group_id
        if not UtilClient.is_unset(request.group_name):
            body['groupName'] = request.group_name
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
            action='UpdateMeetingRoomGroup',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/groups',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.UpdateMeetingRoomGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def update_meeting_room_group_with_options_async(
        self,
        request: dingtalkrooms__1__0_models.UpdateMeetingRoomGroupRequest,
        headers: dingtalkrooms__1__0_models.UpdateMeetingRoomGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.UpdateMeetingRoomGroupResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_id):
            body['groupId'] = request.group_id
        if not UtilClient.is_unset(request.group_name):
            body['groupName'] = request.group_name
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
            action='UpdateMeetingRoomGroup',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/groups',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.UpdateMeetingRoomGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_meeting_room_group(
        self,
        request: dingtalkrooms__1__0_models.UpdateMeetingRoomGroupRequest,
    ) -> dingtalkrooms__1__0_models.UpdateMeetingRoomGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.UpdateMeetingRoomGroupHeaders()
        return self.update_meeting_room_group_with_options(request, headers, runtime)

    async def update_meeting_room_group_async(
        self,
        request: dingtalkrooms__1__0_models.UpdateMeetingRoomGroupRequest,
    ) -> dingtalkrooms__1__0_models.UpdateMeetingRoomGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.UpdateMeetingRoomGroupHeaders()
        return await self.update_meeting_room_group_with_options_async(request, headers, runtime)
