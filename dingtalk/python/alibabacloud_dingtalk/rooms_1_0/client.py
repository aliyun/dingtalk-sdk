# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
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
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

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

    def create_meeting_room_with_options(
        self,
        request: dingtalkrooms__1__0_models.CreateMeetingRoomRequest,
        headers: dingtalkrooms__1__0_models.CreateMeetingRoomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.CreateMeetingRoomResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_id):
            body['groupId'] = request.group_id
        if not UtilClient.is_unset(request.isv_room_id):
            body['isvRoomId'] = request.isv_room_id
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
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.CreateMeetingRoomResponse(),
            self.do_roarequest('CreateMeetingRoom', 'rooms_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/rooms/meetingrooms', 'json', req, runtime)
        )

    async def create_meeting_room_with_options_async(
        self,
        request: dingtalkrooms__1__0_models.CreateMeetingRoomRequest,
        headers: dingtalkrooms__1__0_models.CreateMeetingRoomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.CreateMeetingRoomResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_id):
            body['groupId'] = request.group_id
        if not UtilClient.is_unset(request.isv_room_id):
            body['isvRoomId'] = request.isv_room_id
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
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.CreateMeetingRoomResponse(),
            await self.do_roarequest_async('CreateMeetingRoom', 'rooms_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/rooms/meetingrooms', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.CreateMeetingRoomGroupResponse(),
            self.do_roarequest('CreateMeetingRoomGroup', 'rooms_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/rooms/groups', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.CreateMeetingRoomGroupResponse(),
            await self.do_roarequest_async('CreateMeetingRoomGroup', 'rooms_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/rooms/groups', 'json', req, runtime)
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

    def delete_meeting_room_with_options(
        self,
        room_id: str,
        request: dingtalkrooms__1__0_models.DeleteMeetingRoomRequest,
        headers: dingtalkrooms__1__0_models.DeleteMeetingRoomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.DeleteMeetingRoomResponse:
        UtilClient.validate_model(request)
        room_id = OpenApiUtilClient.get_encode_param(room_id)
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
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.DeleteMeetingRoomResponse(),
            self.do_roarequest('DeleteMeetingRoom', 'rooms_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/rooms/meetingRooms/{room_id}', 'json', req, runtime)
        )

    async def delete_meeting_room_with_options_async(
        self,
        room_id: str,
        request: dingtalkrooms__1__0_models.DeleteMeetingRoomRequest,
        headers: dingtalkrooms__1__0_models.DeleteMeetingRoomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.DeleteMeetingRoomResponse:
        UtilClient.validate_model(request)
        room_id = OpenApiUtilClient.get_encode_param(room_id)
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
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.DeleteMeetingRoomResponse(),
            await self.do_roarequest_async('DeleteMeetingRoom', 'rooms_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/rooms/meetingRooms/{room_id}', 'json', req, runtime)
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

    def delete_meeting_room_group_with_options(
        self,
        group_id: str,
        request: dingtalkrooms__1__0_models.DeleteMeetingRoomGroupRequest,
        headers: dingtalkrooms__1__0_models.DeleteMeetingRoomGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.DeleteMeetingRoomGroupResponse:
        UtilClient.validate_model(request)
        group_id = OpenApiUtilClient.get_encode_param(group_id)
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
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.DeleteMeetingRoomGroupResponse(),
            self.do_roarequest('DeleteMeetingRoomGroup', 'rooms_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/rooms/groups/{group_id}', 'json', req, runtime)
        )

    async def delete_meeting_room_group_with_options_async(
        self,
        group_id: str,
        request: dingtalkrooms__1__0_models.DeleteMeetingRoomGroupRequest,
        headers: dingtalkrooms__1__0_models.DeleteMeetingRoomGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.DeleteMeetingRoomGroupResponse:
        UtilClient.validate_model(request)
        group_id = OpenApiUtilClient.get_encode_param(group_id)
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
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.DeleteMeetingRoomGroupResponse(),
            await self.do_roarequest_async('DeleteMeetingRoomGroup', 'rooms_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/rooms/groups/{group_id}', 'json', req, runtime)
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

    def query_device_ip_by_code_with_options(
        self,
        share_code: str,
        request: dingtalkrooms__1__0_models.QueryDeviceIpByCodeRequest,
        headers: dingtalkrooms__1__0_models.QueryDeviceIpByCodeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.QueryDeviceIpByCodeResponse:
        UtilClient.validate_model(request)
        share_code = OpenApiUtilClient.get_encode_param(share_code)
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
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.QueryDeviceIpByCodeResponse(),
            self.do_roarequest('QueryDeviceIpByCode', 'rooms_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/rooms/devices/shareCodes/{share_code}', 'json', req, runtime)
        )

    async def query_device_ip_by_code_with_options_async(
        self,
        share_code: str,
        request: dingtalkrooms__1__0_models.QueryDeviceIpByCodeRequest,
        headers: dingtalkrooms__1__0_models.QueryDeviceIpByCodeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.QueryDeviceIpByCodeResponse:
        UtilClient.validate_model(request)
        share_code = OpenApiUtilClient.get_encode_param(share_code)
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
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.QueryDeviceIpByCodeResponse(),
            await self.do_roarequest_async('QueryDeviceIpByCode', 'rooms_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/rooms/devices/shareCodes/{share_code}', 'json', req, runtime)
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

    def query_meeting_room_with_options(
        self,
        room_id: str,
        request: dingtalkrooms__1__0_models.QueryMeetingRoomRequest,
        headers: dingtalkrooms__1__0_models.QueryMeetingRoomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.QueryMeetingRoomResponse:
        UtilClient.validate_model(request)
        room_id = OpenApiUtilClient.get_encode_param(room_id)
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
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.QueryMeetingRoomResponse(),
            self.do_roarequest('QueryMeetingRoom', 'rooms_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/rooms/meetingRooms/{room_id}', 'json', req, runtime)
        )

    async def query_meeting_room_with_options_async(
        self,
        room_id: str,
        request: dingtalkrooms__1__0_models.QueryMeetingRoomRequest,
        headers: dingtalkrooms__1__0_models.QueryMeetingRoomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.QueryMeetingRoomResponse:
        UtilClient.validate_model(request)
        room_id = OpenApiUtilClient.get_encode_param(room_id)
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
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.QueryMeetingRoomResponse(),
            await self.do_roarequest_async('QueryMeetingRoom', 'rooms_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/rooms/meetingRooms/{room_id}', 'json', req, runtime)
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

    def query_meeting_room_group_with_options(
        self,
        group_id: str,
        request: dingtalkrooms__1__0_models.QueryMeetingRoomGroupRequest,
        headers: dingtalkrooms__1__0_models.QueryMeetingRoomGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.QueryMeetingRoomGroupResponse:
        UtilClient.validate_model(request)
        group_id = OpenApiUtilClient.get_encode_param(group_id)
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
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.QueryMeetingRoomGroupResponse(),
            self.do_roarequest('QueryMeetingRoomGroup', 'rooms_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/rooms/groups/{group_id}', 'json', req, runtime)
        )

    async def query_meeting_room_group_with_options_async(
        self,
        group_id: str,
        request: dingtalkrooms__1__0_models.QueryMeetingRoomGroupRequest,
        headers: dingtalkrooms__1__0_models.QueryMeetingRoomGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.QueryMeetingRoomGroupResponse:
        UtilClient.validate_model(request)
        group_id = OpenApiUtilClient.get_encode_param(group_id)
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
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.QueryMeetingRoomGroupResponse(),
            await self.do_roarequest_async('QueryMeetingRoomGroup', 'rooms_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/rooms/groups/{group_id}', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.QueryMeetingRoomGroupListResponse(),
            self.do_roarequest('QueryMeetingRoomGroupList', 'rooms_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/rooms/groupLists', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.QueryMeetingRoomGroupListResponse(),
            await self.do_roarequest_async('QueryMeetingRoomGroupList', 'rooms_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/rooms/groupLists', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.QueryMeetingRoomListResponse(),
            self.do_roarequest('QueryMeetingRoomList', 'rooms_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/rooms/meetingRoomLists', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.QueryMeetingRoomListResponse(),
            await self.do_roarequest_async('QueryMeetingRoomList', 'rooms_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/rooms/meetingRoomLists', 'json', req, runtime)
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

    def update_meeting_room_with_options(
        self,
        request: dingtalkrooms__1__0_models.UpdateMeetingRoomRequest,
        headers: dingtalkrooms__1__0_models.UpdateMeetingRoomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.UpdateMeetingRoomResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_id):
            body['groupId'] = request.group_id
        if not UtilClient.is_unset(request.isv_room_id):
            body['isvRoomId'] = request.isv_room_id
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
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.UpdateMeetingRoomResponse(),
            self.do_roarequest('UpdateMeetingRoom', 'rooms_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/rooms/meetingRooms', 'json', req, runtime)
        )

    async def update_meeting_room_with_options_async(
        self,
        request: dingtalkrooms__1__0_models.UpdateMeetingRoomRequest,
        headers: dingtalkrooms__1__0_models.UpdateMeetingRoomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkrooms__1__0_models.UpdateMeetingRoomResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_id):
            body['groupId'] = request.group_id
        if not UtilClient.is_unset(request.isv_room_id):
            body['isvRoomId'] = request.isv_room_id
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
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.UpdateMeetingRoomResponse(),
            await self.do_roarequest_async('UpdateMeetingRoom', 'rooms_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/rooms/meetingRooms', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.UpdateMeetingRoomGroupResponse(),
            self.do_roarequest('UpdateMeetingRoomGroup', 'rooms_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/rooms/groups', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkrooms__1__0_models.UpdateMeetingRoomGroupResponse(),
            await self.do_roarequest_async('UpdateMeetingRoomGroup', 'rooms_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/rooms/groups', 'json', req, runtime)
        )
