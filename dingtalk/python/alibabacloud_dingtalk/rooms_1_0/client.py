# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

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

    def create_booking_blacklist_with_options(
        self,
        request: dingtalkrooms__1__0_models.CreateBookingBlacklistRequest,
        headers: dingtalkrooms__1__0_models.CreateBookingBlacklistHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.CreateBookingBlacklistResponse:
        """
        @summary 创建会议室预定黑名单
        
        @param request: CreateBookingBlacklistRequest
        @param headers: CreateBookingBlacklistHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateBookingBlacklistResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.blacklist_union_id):
            body['blacklistUnionId'] = request.blacklist_union_id
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.memo):
            body['memo'] = request.memo
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
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
            action='CreateBookingBlacklist',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/bookings/blacklist',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.CreateBookingBlacklistResponse(),
            self.execute(params, req, runtime)
        )

    async def create_booking_blacklist_with_options_async(
        self,
        request: dingtalkrooms__1__0_models.CreateBookingBlacklistRequest,
        headers: dingtalkrooms__1__0_models.CreateBookingBlacklistHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.CreateBookingBlacklistResponse:
        """
        @summary 创建会议室预定黑名单
        
        @param request: CreateBookingBlacklistRequest
        @param headers: CreateBookingBlacklistHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateBookingBlacklistResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.blacklist_union_id):
            body['blacklistUnionId'] = request.blacklist_union_id
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.memo):
            body['memo'] = request.memo
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
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
            action='CreateBookingBlacklist',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/bookings/blacklist',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.CreateBookingBlacklistResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_booking_blacklist(
        self,
        request: dingtalkrooms__1__0_models.CreateBookingBlacklistRequest,
    ) -> dingtalkrooms__1__0_models.CreateBookingBlacklistResponse:
        """
        @summary 创建会议室预定黑名单
        
        @param request: CreateBookingBlacklistRequest
        @return: CreateBookingBlacklistResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.CreateBookingBlacklistHeaders()
        return self.create_booking_blacklist_with_options(request, headers, runtime)

    async def create_booking_blacklist_async(
        self,
        request: dingtalkrooms__1__0_models.CreateBookingBlacklistRequest,
    ) -> dingtalkrooms__1__0_models.CreateBookingBlacklistResponse:
        """
        @summary 创建会议室预定黑名单
        
        @param request: CreateBookingBlacklistRequest
        @return: CreateBookingBlacklistResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.CreateBookingBlacklistHeaders()
        return await self.create_booking_blacklist_with_options_async(request, headers, runtime)

    def create_device_custom_template_with_options(
        self,
        request: dingtalkrooms__1__0_models.CreateDeviceCustomTemplateRequest,
        headers: dingtalkrooms__1__0_models.CreateDeviceCustomTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.CreateDeviceCustomTemplateResponse:
        """
        @summary 创建自定义屏幕模版
        
        @param request: CreateDeviceCustomTemplateRequest
        @param headers: CreateDeviceCustomTemplateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateDeviceCustomTemplateResponse
        """
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
        """
        @summary 创建自定义屏幕模版
        
        @param request: CreateDeviceCustomTemplateRequest
        @param headers: CreateDeviceCustomTemplateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateDeviceCustomTemplateResponse
        """
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
        """
        @summary 创建自定义屏幕模版
        
        @param request: CreateDeviceCustomTemplateRequest
        @return: CreateDeviceCustomTemplateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.CreateDeviceCustomTemplateHeaders()
        return self.create_device_custom_template_with_options(request, headers, runtime)

    async def create_device_custom_template_async(
        self,
        request: dingtalkrooms__1__0_models.CreateDeviceCustomTemplateRequest,
    ) -> dingtalkrooms__1__0_models.CreateDeviceCustomTemplateResponse:
        """
        @summary 创建自定义屏幕模版
        
        @param request: CreateDeviceCustomTemplateRequest
        @return: CreateDeviceCustomTemplateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.CreateDeviceCustomTemplateHeaders()
        return await self.create_device_custom_template_with_options_async(request, headers, runtime)

    def create_meeting_room_with_options(
        self,
        request: dingtalkrooms__1__0_models.CreateMeetingRoomRequest,
        headers: dingtalkrooms__1__0_models.CreateMeetingRoomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.CreateMeetingRoomResponse:
        """
        @summary 创建智能会议室
        
        @param request: CreateMeetingRoomRequest
        @param headers: CreateMeetingRoomHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateMeetingRoomResponse
        """
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
        """
        @summary 创建智能会议室
        
        @param request: CreateMeetingRoomRequest
        @param headers: CreateMeetingRoomHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateMeetingRoomResponse
        """
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
        """
        @summary 创建智能会议室
        
        @param request: CreateMeetingRoomRequest
        @return: CreateMeetingRoomResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.CreateMeetingRoomHeaders()
        return self.create_meeting_room_with_options(request, headers, runtime)

    async def create_meeting_room_async(
        self,
        request: dingtalkrooms__1__0_models.CreateMeetingRoomRequest,
    ) -> dingtalkrooms__1__0_models.CreateMeetingRoomResponse:
        """
        @summary 创建智能会议室
        
        @param request: CreateMeetingRoomRequest
        @return: CreateMeetingRoomResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.CreateMeetingRoomHeaders()
        return await self.create_meeting_room_with_options_async(request, headers, runtime)

    def create_meeting_room_control_panel_with_options(
        self,
        request: dingtalkrooms__1__0_models.CreateMeetingRoomControlPanelRequest,
        headers: dingtalkrooms__1__0_models.CreateMeetingRoomControlPanelHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.CreateMeetingRoomControlPanelResponse:
        """
        @summary 创建智能会议室IOT配置
        
        @param request: CreateMeetingRoomControlPanelRequest
        @param headers: CreateMeetingRoomControlPanelHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateMeetingRoomControlPanelResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.extra):
            body['extra'] = request.extra
        if not UtilClient.is_unset(request.room_config):
            body['roomConfig'] = request.room_config
        if not UtilClient.is_unset(request.room_id):
            body['roomId'] = request.room_id
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
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
            action='CreateMeetingRoomControlPanel',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/panels',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.CreateMeetingRoomControlPanelResponse(),
            self.execute(params, req, runtime)
        )

    async def create_meeting_room_control_panel_with_options_async(
        self,
        request: dingtalkrooms__1__0_models.CreateMeetingRoomControlPanelRequest,
        headers: dingtalkrooms__1__0_models.CreateMeetingRoomControlPanelHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.CreateMeetingRoomControlPanelResponse:
        """
        @summary 创建智能会议室IOT配置
        
        @param request: CreateMeetingRoomControlPanelRequest
        @param headers: CreateMeetingRoomControlPanelHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateMeetingRoomControlPanelResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.extra):
            body['extra'] = request.extra
        if not UtilClient.is_unset(request.room_config):
            body['roomConfig'] = request.room_config
        if not UtilClient.is_unset(request.room_id):
            body['roomId'] = request.room_id
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
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
            action='CreateMeetingRoomControlPanel',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/panels',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.CreateMeetingRoomControlPanelResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_meeting_room_control_panel(
        self,
        request: dingtalkrooms__1__0_models.CreateMeetingRoomControlPanelRequest,
    ) -> dingtalkrooms__1__0_models.CreateMeetingRoomControlPanelResponse:
        """
        @summary 创建智能会议室IOT配置
        
        @param request: CreateMeetingRoomControlPanelRequest
        @return: CreateMeetingRoomControlPanelResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.CreateMeetingRoomControlPanelHeaders()
        return self.create_meeting_room_control_panel_with_options(request, headers, runtime)

    async def create_meeting_room_control_panel_async(
        self,
        request: dingtalkrooms__1__0_models.CreateMeetingRoomControlPanelRequest,
    ) -> dingtalkrooms__1__0_models.CreateMeetingRoomControlPanelResponse:
        """
        @summary 创建智能会议室IOT配置
        
        @param request: CreateMeetingRoomControlPanelRequest
        @return: CreateMeetingRoomControlPanelResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.CreateMeetingRoomControlPanelHeaders()
        return await self.create_meeting_room_control_panel_with_options_async(request, headers, runtime)

    def create_meeting_room_group_with_options(
        self,
        request: dingtalkrooms__1__0_models.CreateMeetingRoomGroupRequest,
        headers: dingtalkrooms__1__0_models.CreateMeetingRoomGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.CreateMeetingRoomGroupResponse:
        """
        @summary 创建会议室分组
        
        @param request: CreateMeetingRoomGroupRequest
        @param headers: CreateMeetingRoomGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateMeetingRoomGroupResponse
        """
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
        """
        @summary 创建会议室分组
        
        @param request: CreateMeetingRoomGroupRequest
        @param headers: CreateMeetingRoomGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateMeetingRoomGroupResponse
        """
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
        """
        @summary 创建会议室分组
        
        @param request: CreateMeetingRoomGroupRequest
        @return: CreateMeetingRoomGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.CreateMeetingRoomGroupHeaders()
        return self.create_meeting_room_group_with_options(request, headers, runtime)

    async def create_meeting_room_group_async(
        self,
        request: dingtalkrooms__1__0_models.CreateMeetingRoomGroupRequest,
    ) -> dingtalkrooms__1__0_models.CreateMeetingRoomGroupResponse:
        """
        @summary 创建会议室分组
        
        @param request: CreateMeetingRoomGroupRequest
        @return: CreateMeetingRoomGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.CreateMeetingRoomGroupHeaders()
        return await self.create_meeting_room_group_with_options_async(request, headers, runtime)

    def delete_booking_blacklist_with_options(
        self,
        request: dingtalkrooms__1__0_models.DeleteBookingBlacklistRequest,
        headers: dingtalkrooms__1__0_models.DeleteBookingBlacklistHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.DeleteBookingBlacklistResponse:
        """
        @summary 删除会议室预定黑名单
        
        @param request: DeleteBookingBlacklistRequest
        @param headers: DeleteBookingBlacklistHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteBookingBlacklistResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.blacklist_union_ids):
            body['blacklistUnionIds'] = request.blacklist_union_ids
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
            action='DeleteBookingBlacklist',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/bookings/blacklist/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.DeleteBookingBlacklistResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_booking_blacklist_with_options_async(
        self,
        request: dingtalkrooms__1__0_models.DeleteBookingBlacklistRequest,
        headers: dingtalkrooms__1__0_models.DeleteBookingBlacklistHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.DeleteBookingBlacklistResponse:
        """
        @summary 删除会议室预定黑名单
        
        @param request: DeleteBookingBlacklistRequest
        @param headers: DeleteBookingBlacklistHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteBookingBlacklistResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.blacklist_union_ids):
            body['blacklistUnionIds'] = request.blacklist_union_ids
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
            action='DeleteBookingBlacklist',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/bookings/blacklist/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.DeleteBookingBlacklistResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_booking_blacklist(
        self,
        request: dingtalkrooms__1__0_models.DeleteBookingBlacklistRequest,
    ) -> dingtalkrooms__1__0_models.DeleteBookingBlacklistResponse:
        """
        @summary 删除会议室预定黑名单
        
        @param request: DeleteBookingBlacklistRequest
        @return: DeleteBookingBlacklistResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.DeleteBookingBlacklistHeaders()
        return self.delete_booking_blacklist_with_options(request, headers, runtime)

    async def delete_booking_blacklist_async(
        self,
        request: dingtalkrooms__1__0_models.DeleteBookingBlacklistRequest,
    ) -> dingtalkrooms__1__0_models.DeleteBookingBlacklistResponse:
        """
        @summary 删除会议室预定黑名单
        
        @param request: DeleteBookingBlacklistRequest
        @return: DeleteBookingBlacklistResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.DeleteBookingBlacklistHeaders()
        return await self.delete_booking_blacklist_with_options_async(request, headers, runtime)

    def delete_device_custom_template_with_options(
        self,
        request: dingtalkrooms__1__0_models.DeleteDeviceCustomTemplateRequest,
        headers: dingtalkrooms__1__0_models.DeleteDeviceCustomTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.DeleteDeviceCustomTemplateResponse:
        """
        @summary 删除自定义屏幕模板
        
        @param request: DeleteDeviceCustomTemplateRequest
        @param headers: DeleteDeviceCustomTemplateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteDeviceCustomTemplateResponse
        """
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
        """
        @summary 删除自定义屏幕模板
        
        @param request: DeleteDeviceCustomTemplateRequest
        @param headers: DeleteDeviceCustomTemplateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteDeviceCustomTemplateResponse
        """
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
        """
        @summary 删除自定义屏幕模板
        
        @param request: DeleteDeviceCustomTemplateRequest
        @return: DeleteDeviceCustomTemplateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.DeleteDeviceCustomTemplateHeaders()
        return self.delete_device_custom_template_with_options(request, headers, runtime)

    async def delete_device_custom_template_async(
        self,
        request: dingtalkrooms__1__0_models.DeleteDeviceCustomTemplateRequest,
    ) -> dingtalkrooms__1__0_models.DeleteDeviceCustomTemplateResponse:
        """
        @summary 删除自定义屏幕模板
        
        @param request: DeleteDeviceCustomTemplateRequest
        @return: DeleteDeviceCustomTemplateResponse
        """
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
        """
        @summary 删除会议室
        
        @param request: DeleteMeetingRoomRequest
        @param headers: DeleteMeetingRoomHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteMeetingRoomResponse
        """
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
        """
        @summary 删除会议室
        
        @param request: DeleteMeetingRoomRequest
        @param headers: DeleteMeetingRoomHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteMeetingRoomResponse
        """
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
        """
        @summary 删除会议室
        
        @param request: DeleteMeetingRoomRequest
        @return: DeleteMeetingRoomResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.DeleteMeetingRoomHeaders()
        return self.delete_meeting_room_with_options(room_id, request, headers, runtime)

    async def delete_meeting_room_async(
        self,
        room_id: str,
        request: dingtalkrooms__1__0_models.DeleteMeetingRoomRequest,
    ) -> dingtalkrooms__1__0_models.DeleteMeetingRoomResponse:
        """
        @summary 删除会议室
        
        @param request: DeleteMeetingRoomRequest
        @return: DeleteMeetingRoomResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.DeleteMeetingRoomHeaders()
        return await self.delete_meeting_room_with_options_async(room_id, request, headers, runtime)

    def delete_meeting_room_control_panel_with_options(
        self,
        request: dingtalkrooms__1__0_models.DeleteMeetingRoomControlPanelRequest,
        headers: dingtalkrooms__1__0_models.DeleteMeetingRoomControlPanelHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.DeleteMeetingRoomControlPanelResponse:
        """
        @summary 删除会议室配置
        
        @param request: DeleteMeetingRoomControlPanelRequest
        @param headers: DeleteMeetingRoomControlPanelHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteMeetingRoomControlPanelResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.room_ids):
            body['roomIds'] = request.room_ids
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
            action='DeleteMeetingRoomControlPanel',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/panels/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.DeleteMeetingRoomControlPanelResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_meeting_room_control_panel_with_options_async(
        self,
        request: dingtalkrooms__1__0_models.DeleteMeetingRoomControlPanelRequest,
        headers: dingtalkrooms__1__0_models.DeleteMeetingRoomControlPanelHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.DeleteMeetingRoomControlPanelResponse:
        """
        @summary 删除会议室配置
        
        @param request: DeleteMeetingRoomControlPanelRequest
        @param headers: DeleteMeetingRoomControlPanelHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteMeetingRoomControlPanelResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.room_ids):
            body['roomIds'] = request.room_ids
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
            action='DeleteMeetingRoomControlPanel',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/panels/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.DeleteMeetingRoomControlPanelResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_meeting_room_control_panel(
        self,
        request: dingtalkrooms__1__0_models.DeleteMeetingRoomControlPanelRequest,
    ) -> dingtalkrooms__1__0_models.DeleteMeetingRoomControlPanelResponse:
        """
        @summary 删除会议室配置
        
        @param request: DeleteMeetingRoomControlPanelRequest
        @return: DeleteMeetingRoomControlPanelResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.DeleteMeetingRoomControlPanelHeaders()
        return self.delete_meeting_room_control_panel_with_options(request, headers, runtime)

    async def delete_meeting_room_control_panel_async(
        self,
        request: dingtalkrooms__1__0_models.DeleteMeetingRoomControlPanelRequest,
    ) -> dingtalkrooms__1__0_models.DeleteMeetingRoomControlPanelResponse:
        """
        @summary 删除会议室配置
        
        @param request: DeleteMeetingRoomControlPanelRequest
        @return: DeleteMeetingRoomControlPanelResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.DeleteMeetingRoomControlPanelHeaders()
        return await self.delete_meeting_room_control_panel_with_options_async(request, headers, runtime)

    def delete_meeting_room_group_with_options(
        self,
        group_id: str,
        request: dingtalkrooms__1__0_models.DeleteMeetingRoomGroupRequest,
        headers: dingtalkrooms__1__0_models.DeleteMeetingRoomGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.DeleteMeetingRoomGroupResponse:
        """
        @summary 删除会议室分组
        
        @param request: DeleteMeetingRoomGroupRequest
        @param headers: DeleteMeetingRoomGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteMeetingRoomGroupResponse
        """
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
        """
        @summary 删除会议室分组
        
        @param request: DeleteMeetingRoomGroupRequest
        @param headers: DeleteMeetingRoomGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteMeetingRoomGroupResponse
        """
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
        """
        @summary 删除会议室分组
        
        @param request: DeleteMeetingRoomGroupRequest
        @return: DeleteMeetingRoomGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.DeleteMeetingRoomGroupHeaders()
        return self.delete_meeting_room_group_with_options(group_id, request, headers, runtime)

    async def delete_meeting_room_group_async(
        self,
        group_id: str,
        request: dingtalkrooms__1__0_models.DeleteMeetingRoomGroupRequest,
    ) -> dingtalkrooms__1__0_models.DeleteMeetingRoomGroupResponse:
        """
        @summary 删除会议室分组
        
        @param request: DeleteMeetingRoomGroupRequest
        @return: DeleteMeetingRoomGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.DeleteMeetingRoomGroupHeaders()
        return await self.delete_meeting_room_group_with_options_async(group_id, request, headers, runtime)

    def query_device_custom_template_with_options(
        self,
        template_id: str,
        headers: dingtalkrooms__1__0_models.QueryDeviceCustomTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.QueryDeviceCustomTemplateResponse:
        """
        @summary 查询自定义屏幕模板
        
        @param headers: QueryDeviceCustomTemplateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDeviceCustomTemplateResponse
        """
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
        """
        @summary 查询自定义屏幕模板
        
        @param headers: QueryDeviceCustomTemplateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDeviceCustomTemplateResponse
        """
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
        """
        @summary 查询自定义屏幕模板
        
        @return: QueryDeviceCustomTemplateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.QueryDeviceCustomTemplateHeaders()
        return self.query_device_custom_template_with_options(template_id, headers, runtime)

    async def query_device_custom_template_async(
        self,
        template_id: str,
    ) -> dingtalkrooms__1__0_models.QueryDeviceCustomTemplateResponse:
        """
        @summary 查询自定义屏幕模板
        
        @return: QueryDeviceCustomTemplateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.QueryDeviceCustomTemplateHeaders()
        return await self.query_device_custom_template_with_options_async(template_id, headers, runtime)

    def query_device_custom_template_list_with_options(
        self,
        headers: dingtalkrooms__1__0_models.QueryDeviceCustomTemplateListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.QueryDeviceCustomTemplateListResponse:
        """
        @summary 查询自定义屏幕模板列表
        
        @param headers: QueryDeviceCustomTemplateListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDeviceCustomTemplateListResponse
        """
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
        """
        @summary 查询自定义屏幕模板列表
        
        @param headers: QueryDeviceCustomTemplateListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDeviceCustomTemplateListResponse
        """
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
        """
        @summary 查询自定义屏幕模板列表
        
        @return: QueryDeviceCustomTemplateListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.QueryDeviceCustomTemplateListHeaders()
        return self.query_device_custom_template_list_with_options(headers, runtime)

    async def query_device_custom_template_list_async(self) -> dingtalkrooms__1__0_models.QueryDeviceCustomTemplateListResponse:
        """
        @summary 查询自定义屏幕模板列表
        
        @return: QueryDeviceCustomTemplateListResponse
        """
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
        """
        @summary 根据设备投屏码查询设备ip
        
        @param request: QueryDeviceIpByCodeRequest
        @param headers: QueryDeviceIpByCodeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDeviceIpByCodeResponse
        """
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
        """
        @summary 根据设备投屏码查询设备ip
        
        @param request: QueryDeviceIpByCodeRequest
        @param headers: QueryDeviceIpByCodeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDeviceIpByCodeResponse
        """
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
        """
        @summary 根据设备投屏码查询设备ip
        
        @param request: QueryDeviceIpByCodeRequest
        @return: QueryDeviceIpByCodeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.QueryDeviceIpByCodeHeaders()
        return self.query_device_ip_by_code_with_options(share_code, request, headers, runtime)

    async def query_device_ip_by_code_async(
        self,
        share_code: str,
        request: dingtalkrooms__1__0_models.QueryDeviceIpByCodeRequest,
    ) -> dingtalkrooms__1__0_models.QueryDeviceIpByCodeResponse:
        """
        @summary 根据设备投屏码查询设备ip
        
        @param request: QueryDeviceIpByCodeRequest
        @return: QueryDeviceIpByCodeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.QueryDeviceIpByCodeHeaders()
        return await self.query_device_ip_by_code_with_options_async(share_code, request, headers, runtime)

    def query_device_properties_with_options(
        self,
        request: dingtalkrooms__1__0_models.QueryDevicePropertiesRequest,
        headers: dingtalkrooms__1__0_models.QueryDevicePropertiesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.QueryDevicePropertiesResponse:
        """
        @summary 查询设备属性
        
        @param request: QueryDevicePropertiesRequest
        @param headers: QueryDevicePropertiesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDevicePropertiesResponse
        """
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
        """
        @summary 查询设备属性
        
        @param request: QueryDevicePropertiesRequest
        @param headers: QueryDevicePropertiesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDevicePropertiesResponse
        """
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
        """
        @summary 查询设备属性
        
        @param request: QueryDevicePropertiesRequest
        @return: QueryDevicePropertiesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.QueryDevicePropertiesHeaders()
        return self.query_device_properties_with_options(request, headers, runtime)

    async def query_device_properties_async(
        self,
        request: dingtalkrooms__1__0_models.QueryDevicePropertiesRequest,
    ) -> dingtalkrooms__1__0_models.QueryDevicePropertiesResponse:
        """
        @summary 查询设备属性
        
        @param request: QueryDevicePropertiesRequest
        @return: QueryDevicePropertiesResponse
        """
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
        """
        @summary 查询会议室详情
        
        @param request: QueryMeetingRoomRequest
        @param headers: QueryMeetingRoomHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMeetingRoomResponse
        """
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
        """
        @summary 查询会议室详情
        
        @param request: QueryMeetingRoomRequest
        @param headers: QueryMeetingRoomHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMeetingRoomResponse
        """
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
        """
        @summary 查询会议室详情
        
        @param request: QueryMeetingRoomRequest
        @return: QueryMeetingRoomResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.QueryMeetingRoomHeaders()
        return self.query_meeting_room_with_options(room_id, request, headers, runtime)

    async def query_meeting_room_async(
        self,
        room_id: str,
        request: dingtalkrooms__1__0_models.QueryMeetingRoomRequest,
    ) -> dingtalkrooms__1__0_models.QueryMeetingRoomResponse:
        """
        @summary 查询会议室详情
        
        @param request: QueryMeetingRoomRequest
        @return: QueryMeetingRoomResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.QueryMeetingRoomHeaders()
        return await self.query_meeting_room_with_options_async(room_id, request, headers, runtime)

    def query_meeting_room_control_panel_list_with_options(
        self,
        request: dingtalkrooms__1__0_models.QueryMeetingRoomControlPanelListRequest,
        headers: dingtalkrooms__1__0_models.QueryMeetingRoomControlPanelListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.QueryMeetingRoomControlPanelListResponse:
        """
        @summary 获取会议室IOT配置列表
        
        @param request: QueryMeetingRoomControlPanelListRequest
        @param headers: QueryMeetingRoomControlPanelListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMeetingRoomControlPanelListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
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
            action='QueryMeetingRoomControlPanelList',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/panels/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.QueryMeetingRoomControlPanelListResponse(),
            self.execute(params, req, runtime)
        )

    async def query_meeting_room_control_panel_list_with_options_async(
        self,
        request: dingtalkrooms__1__0_models.QueryMeetingRoomControlPanelListRequest,
        headers: dingtalkrooms__1__0_models.QueryMeetingRoomControlPanelListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.QueryMeetingRoomControlPanelListResponse:
        """
        @summary 获取会议室IOT配置列表
        
        @param request: QueryMeetingRoomControlPanelListRequest
        @param headers: QueryMeetingRoomControlPanelListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMeetingRoomControlPanelListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
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
            action='QueryMeetingRoomControlPanelList',
            version='rooms_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/rooms/panels/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.QueryMeetingRoomControlPanelListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_meeting_room_control_panel_list(
        self,
        request: dingtalkrooms__1__0_models.QueryMeetingRoomControlPanelListRequest,
    ) -> dingtalkrooms__1__0_models.QueryMeetingRoomControlPanelListResponse:
        """
        @summary 获取会议室IOT配置列表
        
        @param request: QueryMeetingRoomControlPanelListRequest
        @return: QueryMeetingRoomControlPanelListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.QueryMeetingRoomControlPanelListHeaders()
        return self.query_meeting_room_control_panel_list_with_options(request, headers, runtime)

    async def query_meeting_room_control_panel_list_async(
        self,
        request: dingtalkrooms__1__0_models.QueryMeetingRoomControlPanelListRequest,
    ) -> dingtalkrooms__1__0_models.QueryMeetingRoomControlPanelListResponse:
        """
        @summary 获取会议室IOT配置列表
        
        @param request: QueryMeetingRoomControlPanelListRequest
        @return: QueryMeetingRoomControlPanelListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.QueryMeetingRoomControlPanelListHeaders()
        return await self.query_meeting_room_control_panel_list_with_options_async(request, headers, runtime)

    def query_meeting_room_device_with_options(
        self,
        request: dingtalkrooms__1__0_models.QueryMeetingRoomDeviceRequest,
        headers: dingtalkrooms__1__0_models.QueryMeetingRoomDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.QueryMeetingRoomDeviceResponse:
        """
        @summary 查询设备信息
        
        @param request: QueryMeetingRoomDeviceRequest
        @param headers: QueryMeetingRoomDeviceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMeetingRoomDeviceResponse
        """
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
        """
        @summary 查询设备信息
        
        @param request: QueryMeetingRoomDeviceRequest
        @param headers: QueryMeetingRoomDeviceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMeetingRoomDeviceResponse
        """
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
        """
        @summary 查询设备信息
        
        @param request: QueryMeetingRoomDeviceRequest
        @return: QueryMeetingRoomDeviceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.QueryMeetingRoomDeviceHeaders()
        return self.query_meeting_room_device_with_options(request, headers, runtime)

    async def query_meeting_room_device_async(
        self,
        request: dingtalkrooms__1__0_models.QueryMeetingRoomDeviceRequest,
    ) -> dingtalkrooms__1__0_models.QueryMeetingRoomDeviceResponse:
        """
        @summary 查询设备信息
        
        @param request: QueryMeetingRoomDeviceRequest
        @return: QueryMeetingRoomDeviceResponse
        """
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
        """
        @summary 查询会议室分组信息
        
        @param request: QueryMeetingRoomGroupRequest
        @param headers: QueryMeetingRoomGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMeetingRoomGroupResponse
        """
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
        """
        @summary 查询会议室分组信息
        
        @param request: QueryMeetingRoomGroupRequest
        @param headers: QueryMeetingRoomGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMeetingRoomGroupResponse
        """
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
        """
        @summary 查询会议室分组信息
        
        @param request: QueryMeetingRoomGroupRequest
        @return: QueryMeetingRoomGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.QueryMeetingRoomGroupHeaders()
        return self.query_meeting_room_group_with_options(group_id, request, headers, runtime)

    async def query_meeting_room_group_async(
        self,
        group_id: str,
        request: dingtalkrooms__1__0_models.QueryMeetingRoomGroupRequest,
    ) -> dingtalkrooms__1__0_models.QueryMeetingRoomGroupResponse:
        """
        @summary 查询会议室分组信息
        
        @param request: QueryMeetingRoomGroupRequest
        @return: QueryMeetingRoomGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.QueryMeetingRoomGroupHeaders()
        return await self.query_meeting_room_group_with_options_async(group_id, request, headers, runtime)

    def query_meeting_room_group_list_with_options(
        self,
        request: dingtalkrooms__1__0_models.QueryMeetingRoomGroupListRequest,
        headers: dingtalkrooms__1__0_models.QueryMeetingRoomGroupListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.QueryMeetingRoomGroupListResponse:
        """
        @summary 查询会议室分组列表
        
        @param request: QueryMeetingRoomGroupListRequest
        @param headers: QueryMeetingRoomGroupListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMeetingRoomGroupListResponse
        """
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
        """
        @summary 查询会议室分组列表
        
        @param request: QueryMeetingRoomGroupListRequest
        @param headers: QueryMeetingRoomGroupListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMeetingRoomGroupListResponse
        """
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
        """
        @summary 查询会议室分组列表
        
        @param request: QueryMeetingRoomGroupListRequest
        @return: QueryMeetingRoomGroupListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.QueryMeetingRoomGroupListHeaders()
        return self.query_meeting_room_group_list_with_options(request, headers, runtime)

    async def query_meeting_room_group_list_async(
        self,
        request: dingtalkrooms__1__0_models.QueryMeetingRoomGroupListRequest,
    ) -> dingtalkrooms__1__0_models.QueryMeetingRoomGroupListResponse:
        """
        @summary 查询会议室分组列表
        
        @param request: QueryMeetingRoomGroupListRequest
        @return: QueryMeetingRoomGroupListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.QueryMeetingRoomGroupListHeaders()
        return await self.query_meeting_room_group_list_with_options_async(request, headers, runtime)

    def query_meeting_room_list_with_options(
        self,
        request: dingtalkrooms__1__0_models.QueryMeetingRoomListRequest,
        headers: dingtalkrooms__1__0_models.QueryMeetingRoomListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.QueryMeetingRoomListResponse:
        """
        @summary 查询会议室列表
        
        @param request: QueryMeetingRoomListRequest
        @param headers: QueryMeetingRoomListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMeetingRoomListResponse
        """
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
        """
        @summary 查询会议室列表
        
        @param request: QueryMeetingRoomListRequest
        @param headers: QueryMeetingRoomListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMeetingRoomListResponse
        """
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
        """
        @summary 查询会议室列表
        
        @param request: QueryMeetingRoomListRequest
        @return: QueryMeetingRoomListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.QueryMeetingRoomListHeaders()
        return self.query_meeting_room_list_with_options(request, headers, runtime)

    async def query_meeting_room_list_async(
        self,
        request: dingtalkrooms__1__0_models.QueryMeetingRoomListRequest,
    ) -> dingtalkrooms__1__0_models.QueryMeetingRoomListResponse:
        """
        @summary 查询会议室列表
        
        @param request: QueryMeetingRoomListRequest
        @return: QueryMeetingRoomListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.QueryMeetingRoomListHeaders()
        return await self.query_meeting_room_list_with_options_async(request, headers, runtime)

    def remove_super_user_meeting_room_with_options(
        self,
        request: dingtalkrooms__1__0_models.RemoveSuperUserMeetingRoomRequest,
        headers: dingtalkrooms__1__0_models.RemoveSuperUserMeetingRoomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.RemoveSuperUserMeetingRoomResponse:
        """
        @summary 取消会议室高级用户模式。
        
        @param request: RemoveSuperUserMeetingRoomRequest
        @param headers: RemoveSuperUserMeetingRoomHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RemoveSuperUserMeetingRoomResponse
        """
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
        """
        @summary 取消会议室高级用户模式。
        
        @param request: RemoveSuperUserMeetingRoomRequest
        @param headers: RemoveSuperUserMeetingRoomHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RemoveSuperUserMeetingRoomResponse
        """
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
        """
        @summary 取消会议室高级用户模式。
        
        @param request: RemoveSuperUserMeetingRoomRequest
        @return: RemoveSuperUserMeetingRoomResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.RemoveSuperUserMeetingRoomHeaders()
        return self.remove_super_user_meeting_room_with_options(request, headers, runtime)

    async def remove_super_user_meeting_room_async(
        self,
        request: dingtalkrooms__1__0_models.RemoveSuperUserMeetingRoomRequest,
    ) -> dingtalkrooms__1__0_models.RemoveSuperUserMeetingRoomResponse:
        """
        @summary 取消会议室高级用户模式。
        
        @param request: RemoveSuperUserMeetingRoomRequest
        @return: RemoveSuperUserMeetingRoomResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.RemoveSuperUserMeetingRoomHeaders()
        return await self.remove_super_user_meeting_room_with_options_async(request, headers, runtime)

    def set_super_user_meeting_room_with_options(
        self,
        request: dingtalkrooms__1__0_models.SetSuperUserMeetingRoomRequest,
        headers: dingtalkrooms__1__0_models.SetSuperUserMeetingRoomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.SetSuperUserMeetingRoomResponse:
        """
        @summary 设置会议室成为高级用户模式。只有设置在白名单里的人员或部门，才能呼叫此会议室。
        
        @param request: SetSuperUserMeetingRoomRequest
        @param headers: SetSuperUserMeetingRoomHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SetSuperUserMeetingRoomResponse
        """
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
        """
        @summary 设置会议室成为高级用户模式。只有设置在白名单里的人员或部门，才能呼叫此会议室。
        
        @param request: SetSuperUserMeetingRoomRequest
        @param headers: SetSuperUserMeetingRoomHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SetSuperUserMeetingRoomResponse
        """
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
        """
        @summary 设置会议室成为高级用户模式。只有设置在白名单里的人员或部门，才能呼叫此会议室。
        
        @param request: SetSuperUserMeetingRoomRequest
        @return: SetSuperUserMeetingRoomResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.SetSuperUserMeetingRoomHeaders()
        return self.set_super_user_meeting_room_with_options(request, headers, runtime)

    async def set_super_user_meeting_room_async(
        self,
        request: dingtalkrooms__1__0_models.SetSuperUserMeetingRoomRequest,
    ) -> dingtalkrooms__1__0_models.SetSuperUserMeetingRoomResponse:
        """
        @summary 设置会议室成为高级用户模式。只有设置在白名单里的人员或部门，才能呼叫此会议室。
        
        @param request: SetSuperUserMeetingRoomRequest
        @return: SetSuperUserMeetingRoomResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.SetSuperUserMeetingRoomHeaders()
        return await self.set_super_user_meeting_room_with_options_async(request, headers, runtime)

    def update_device_custom_template_with_options(
        self,
        request: dingtalkrooms__1__0_models.UpdateDeviceCustomTemplateRequest,
        headers: dingtalkrooms__1__0_models.UpdateDeviceCustomTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.UpdateDeviceCustomTemplateResponse:
        """
        @summary 更新自定义屏幕模板
        
        @param request: UpdateDeviceCustomTemplateRequest
        @param headers: UpdateDeviceCustomTemplateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateDeviceCustomTemplateResponse
        """
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
        """
        @summary 更新自定义屏幕模板
        
        @param request: UpdateDeviceCustomTemplateRequest
        @param headers: UpdateDeviceCustomTemplateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateDeviceCustomTemplateResponse
        """
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
        """
        @summary 更新自定义屏幕模板
        
        @param request: UpdateDeviceCustomTemplateRequest
        @return: UpdateDeviceCustomTemplateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.UpdateDeviceCustomTemplateHeaders()
        return self.update_device_custom_template_with_options(request, headers, runtime)

    async def update_device_custom_template_async(
        self,
        request: dingtalkrooms__1__0_models.UpdateDeviceCustomTemplateRequest,
    ) -> dingtalkrooms__1__0_models.UpdateDeviceCustomTemplateResponse:
        """
        @summary 更新自定义屏幕模板
        
        @param request: UpdateDeviceCustomTemplateRequest
        @return: UpdateDeviceCustomTemplateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.UpdateDeviceCustomTemplateHeaders()
        return await self.update_device_custom_template_with_options_async(request, headers, runtime)

    def update_meeting_room_with_options(
        self,
        request: dingtalkrooms__1__0_models.UpdateMeetingRoomRequest,
        headers: dingtalkrooms__1__0_models.UpdateMeetingRoomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.UpdateMeetingRoomResponse:
        """
        @summary 更新会议室信息
        
        @param request: UpdateMeetingRoomRequest
        @param headers: UpdateMeetingRoomHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateMeetingRoomResponse
        """
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
        """
        @summary 更新会议室信息
        
        @param request: UpdateMeetingRoomRequest
        @param headers: UpdateMeetingRoomHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateMeetingRoomResponse
        """
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
        """
        @summary 更新会议室信息
        
        @param request: UpdateMeetingRoomRequest
        @return: UpdateMeetingRoomResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.UpdateMeetingRoomHeaders()
        return self.update_meeting_room_with_options(request, headers, runtime)

    async def update_meeting_room_async(
        self,
        request: dingtalkrooms__1__0_models.UpdateMeetingRoomRequest,
    ) -> dingtalkrooms__1__0_models.UpdateMeetingRoomResponse:
        """
        @summary 更新会议室信息
        
        @param request: UpdateMeetingRoomRequest
        @return: UpdateMeetingRoomResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.UpdateMeetingRoomHeaders()
        return await self.update_meeting_room_with_options_async(request, headers, runtime)

    def update_meeting_room_group_with_options(
        self,
        request: dingtalkrooms__1__0_models.UpdateMeetingRoomGroupRequest,
        headers: dingtalkrooms__1__0_models.UpdateMeetingRoomGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.UpdateMeetingRoomGroupResponse:
        """
        @summary 更新会议室分组
        
        @param request: UpdateMeetingRoomGroupRequest
        @param headers: UpdateMeetingRoomGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateMeetingRoomGroupResponse
        """
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
        """
        @summary 更新会议室分组
        
        @param request: UpdateMeetingRoomGroupRequest
        @param headers: UpdateMeetingRoomGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateMeetingRoomGroupResponse
        """
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
        """
        @summary 更新会议室分组
        
        @param request: UpdateMeetingRoomGroupRequest
        @return: UpdateMeetingRoomGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.UpdateMeetingRoomGroupHeaders()
        return self.update_meeting_room_group_with_options(request, headers, runtime)

    async def update_meeting_room_group_async(
        self,
        request: dingtalkrooms__1__0_models.UpdateMeetingRoomGroupRequest,
    ) -> dingtalkrooms__1__0_models.UpdateMeetingRoomGroupResponse:
        """
        @summary 更新会议室分组
        
        @param request: UpdateMeetingRoomGroupRequest
        @return: UpdateMeetingRoomGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkrooms__1__0_models.UpdateMeetingRoomGroupHeaders()
        return await self.update_meeting_room_group_with_options_async(request, headers, runtime)
