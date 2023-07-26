# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class CreateMeetingRoomHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class CreateMeetingRoomRequestRoomLocation(TeaModel):
    def __init__(
        self,
        desc: str = None,
        title: str = None,
    ):
        self.desc = desc
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.desc is not None:
            result['desc'] = self.desc
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('desc') is not None:
            self.desc = m.get('desc')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class CreateMeetingRoomRequest(TeaModel):
    def __init__(
        self,
        group_id: int = None,
        isv_room_id: str = None,
        room_capacity: int = None,
        room_label_ids: List[int] = None,
        room_location: CreateMeetingRoomRequestRoomLocation = None,
        room_name: str = None,
        room_picture: str = None,
        room_status: int = None,
        union_id: str = None,
    ):
        self.group_id = group_id
        self.isv_room_id = isv_room_id
        self.room_capacity = room_capacity
        self.room_label_ids = room_label_ids
        self.room_location = room_location
        self.room_name = room_name
        self.room_picture = room_picture
        self.room_status = room_status
        self.union_id = union_id

    def validate(self):
        if self.room_location:
            self.room_location.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_id is not None:
            result['groupId'] = self.group_id
        if self.isv_room_id is not None:
            result['isvRoomId'] = self.isv_room_id
        if self.room_capacity is not None:
            result['roomCapacity'] = self.room_capacity
        if self.room_label_ids is not None:
            result['roomLabelIds'] = self.room_label_ids
        if self.room_location is not None:
            result['roomLocation'] = self.room_location.to_map()
        if self.room_name is not None:
            result['roomName'] = self.room_name
        if self.room_picture is not None:
            result['roomPicture'] = self.room_picture
        if self.room_status is not None:
            result['roomStatus'] = self.room_status
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupId') is not None:
            self.group_id = m.get('groupId')
        if m.get('isvRoomId') is not None:
            self.isv_room_id = m.get('isvRoomId')
        if m.get('roomCapacity') is not None:
            self.room_capacity = m.get('roomCapacity')
        if m.get('roomLabelIds') is not None:
            self.room_label_ids = m.get('roomLabelIds')
        if m.get('roomLocation') is not None:
            temp_model = CreateMeetingRoomRequestRoomLocation()
            self.room_location = temp_model.from_map(m['roomLocation'])
        if m.get('roomName') is not None:
            self.room_name = m.get('roomName')
        if m.get('roomPicture') is not None:
            self.room_picture = m.get('roomPicture')
        if m.get('roomStatus') is not None:
            self.room_status = m.get('roomStatus')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class CreateMeetingRoomResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
    ):
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class CreateMeetingRoomResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateMeetingRoomResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = CreateMeetingRoomResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateMeetingRoomGroupHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class CreateMeetingRoomGroupRequest(TeaModel):
    def __init__(
        self,
        group_name: str = None,
        parent_group_id: int = None,
        union_id: str = None,
    ):
        self.group_name = group_name
        self.parent_group_id = parent_group_id
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.parent_group_id is not None:
            result['parentGroupId'] = self.parent_group_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('parentGroupId') is not None:
            self.parent_group_id = m.get('parentGroupId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class CreateMeetingRoomGroupResponseBody(TeaModel):
    def __init__(
        self,
        result: int = None,
    ):
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class CreateMeetingRoomGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateMeetingRoomGroupResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = CreateMeetingRoomGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteMeetingRoomHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class DeleteMeetingRoomRequest(TeaModel):
    def __init__(
        self,
        union_id: str = None,
    ):
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class DeleteMeetingRoomResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class DeleteMeetingRoomResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteMeetingRoomResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = DeleteMeetingRoomResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteMeetingRoomGroupHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class DeleteMeetingRoomGroupRequest(TeaModel):
    def __init__(
        self,
        union_id: str = None,
    ):
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class DeleteMeetingRoomGroupResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class DeleteMeetingRoomGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteMeetingRoomGroupResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = DeleteMeetingRoomGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryDeviceIpByCodeHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryDeviceIpByCodeRequest(TeaModel):
    def __init__(
        self,
        device_sn: str = None,
    ):
        self.device_sn = device_sn

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_sn is not None:
            result['deviceSn'] = self.device_sn
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceSn') is not None:
            self.device_sn = m.get('deviceSn')
        return self


class QueryDeviceIpByCodeResponseBodyResult(TeaModel):
    def __init__(
        self,
        device_ip: str = None,
    ):
        self.device_ip = device_ip

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_ip is not None:
            result['deviceIp'] = self.device_ip
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceIp') is not None:
            self.device_ip = m.get('deviceIp')
        return self


class QueryDeviceIpByCodeResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryDeviceIpByCodeResponseBodyResult = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = QueryDeviceIpByCodeResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryDeviceIpByCodeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryDeviceIpByCodeResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = QueryDeviceIpByCodeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryDevicePropertiesHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryDevicePropertiesRequest(TeaModel):
    def __init__(
        self,
        property_names: List[str] = None,
        device_id: str = None,
        device_union_id: str = None,
        operator_union_id: str = None,
    ):
        self.property_names = property_names
        self.device_id = device_id
        self.device_union_id = device_union_id
        self.operator_union_id = operator_union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.property_names is not None:
            result['propertyNames'] = self.property_names
        if self.device_id is not None:
            result['deviceId'] = self.device_id
        if self.device_union_id is not None:
            result['deviceUnionId'] = self.device_union_id
        if self.operator_union_id is not None:
            result['operatorUnionId'] = self.operator_union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('propertyNames') is not None:
            self.property_names = m.get('propertyNames')
        if m.get('deviceId') is not None:
            self.device_id = m.get('deviceId')
        if m.get('deviceUnionId') is not None:
            self.device_union_id = m.get('deviceUnionId')
        if m.get('operatorUnionId') is not None:
            self.operator_union_id = m.get('operatorUnionId')
        return self


class QueryDevicePropertiesResponseBodyResult(TeaModel):
    def __init__(
        self,
        property_name: str = None,
        property_value: str = None,
    ):
        self.property_name = property_name
        self.property_value = property_value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.property_name is not None:
            result['propertyName'] = self.property_name
        if self.property_value is not None:
            result['propertyValue'] = self.property_value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('propertyName') is not None:
            self.property_name = m.get('propertyName')
        if m.get('propertyValue') is not None:
            self.property_value = m.get('propertyValue')
        return self


class QueryDevicePropertiesResponseBody(TeaModel):
    def __init__(
        self,
        result: List[QueryDevicePropertiesResponseBodyResult] = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            for k in self.result:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['result'] = []
        if self.result is not None:
            for k in self.result:
                result['result'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = QueryDevicePropertiesResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class QueryDevicePropertiesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryDevicePropertiesResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = QueryDevicePropertiesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryMeetingRoomHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryMeetingRoomRequest(TeaModel):
    def __init__(
        self,
        union_id: str = None,
    ):
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class QueryMeetingRoomResponseBodyResultRoomGroup(TeaModel):
    def __init__(
        self,
        group_id: int = None,
        group_name: str = None,
        parent_id: int = None,
    ):
        self.group_id = group_id
        self.group_name = group_name
        self.parent_id = parent_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_id is not None:
            result['groupId'] = self.group_id
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.parent_id is not None:
            result['parentId'] = self.parent_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupId') is not None:
            self.group_id = m.get('groupId')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('parentId') is not None:
            self.parent_id = m.get('parentId')
        return self


class QueryMeetingRoomResponseBodyResultRoomLabels(TeaModel):
    def __init__(
        self,
        label_id: int = None,
        label_name: str = None,
    ):
        self.label_id = label_id
        self.label_name = label_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.label_id is not None:
            result['labelId'] = self.label_id
        if self.label_name is not None:
            result['labelName'] = self.label_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('labelId') is not None:
            self.label_id = m.get('labelId')
        if m.get('labelName') is not None:
            self.label_name = m.get('labelName')
        return self


class QueryMeetingRoomResponseBodyResultRoomLocation(TeaModel):
    def __init__(
        self,
        desc: str = None,
        title: str = None,
    ):
        self.desc = desc
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.desc is not None:
            result['desc'] = self.desc
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('desc') is not None:
            self.desc = m.get('desc')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class QueryMeetingRoomResponseBodyResult(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        isv_room_id: str = None,
        room_capacity: int = None,
        room_group: QueryMeetingRoomResponseBodyResultRoomGroup = None,
        room_id: str = None,
        room_labels: List[QueryMeetingRoomResponseBodyResultRoomLabels] = None,
        room_location: QueryMeetingRoomResponseBodyResultRoomLocation = None,
        room_name: str = None,
        room_picture: str = None,
        room_staff_id: str = None,
        room_status: int = None,
    ):
        self.corp_id = corp_id
        self.isv_room_id = isv_room_id
        self.room_capacity = room_capacity
        self.room_group = room_group
        self.room_id = room_id
        self.room_labels = room_labels
        self.room_location = room_location
        self.room_name = room_name
        self.room_picture = room_picture
        self.room_staff_id = room_staff_id
        self.room_status = room_status

    def validate(self):
        if self.room_group:
            self.room_group.validate()
        if self.room_labels:
            for k in self.room_labels:
                if k:
                    k.validate()
        if self.room_location:
            self.room_location.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.isv_room_id is not None:
            result['isvRoomId'] = self.isv_room_id
        if self.room_capacity is not None:
            result['roomCapacity'] = self.room_capacity
        if self.room_group is not None:
            result['roomGroup'] = self.room_group.to_map()
        if self.room_id is not None:
            result['roomId'] = self.room_id
        result['roomLabels'] = []
        if self.room_labels is not None:
            for k in self.room_labels:
                result['roomLabels'].append(k.to_map() if k else None)
        if self.room_location is not None:
            result['roomLocation'] = self.room_location.to_map()
        if self.room_name is not None:
            result['roomName'] = self.room_name
        if self.room_picture is not None:
            result['roomPicture'] = self.room_picture
        if self.room_staff_id is not None:
            result['roomStaffId'] = self.room_staff_id
        if self.room_status is not None:
            result['roomStatus'] = self.room_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('isvRoomId') is not None:
            self.isv_room_id = m.get('isvRoomId')
        if m.get('roomCapacity') is not None:
            self.room_capacity = m.get('roomCapacity')
        if m.get('roomGroup') is not None:
            temp_model = QueryMeetingRoomResponseBodyResultRoomGroup()
            self.room_group = temp_model.from_map(m['roomGroup'])
        if m.get('roomId') is not None:
            self.room_id = m.get('roomId')
        self.room_labels = []
        if m.get('roomLabels') is not None:
            for k in m.get('roomLabels'):
                temp_model = QueryMeetingRoomResponseBodyResultRoomLabels()
                self.room_labels.append(temp_model.from_map(k))
        if m.get('roomLocation') is not None:
            temp_model = QueryMeetingRoomResponseBodyResultRoomLocation()
            self.room_location = temp_model.from_map(m['roomLocation'])
        if m.get('roomName') is not None:
            self.room_name = m.get('roomName')
        if m.get('roomPicture') is not None:
            self.room_picture = m.get('roomPicture')
        if m.get('roomStaffId') is not None:
            self.room_staff_id = m.get('roomStaffId')
        if m.get('roomStatus') is not None:
            self.room_status = m.get('roomStatus')
        return self


class QueryMeetingRoomResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryMeetingRoomResponseBodyResult = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = QueryMeetingRoomResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class QueryMeetingRoomResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryMeetingRoomResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = QueryMeetingRoomResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryMeetingRoomDeviceHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryMeetingRoomDeviceRequest(TeaModel):
    def __init__(
        self,
        device_id: str = None,
        device_union_id: str = None,
        operator_union_id: str = None,
    ):
        self.device_id = device_id
        self.device_union_id = device_union_id
        self.operator_union_id = operator_union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_id is not None:
            result['deviceId'] = self.device_id
        if self.device_union_id is not None:
            result['deviceUnionId'] = self.device_union_id
        if self.operator_union_id is not None:
            result['operatorUnionId'] = self.operator_union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceId') is not None:
            self.device_id = m.get('deviceId')
        if m.get('deviceUnionId') is not None:
            self.device_union_id = m.get('deviceUnionId')
        if m.get('operatorUnionId') is not None:
            self.operator_union_id = m.get('operatorUnionId')
        return self


class QueryMeetingRoomDeviceResponseBodyResultControllers(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        device_id: str = None,
        device_mac: str = None,
        device_model: str = None,
        device_name: str = None,
        device_service_id: int = None,
        device_sn: str = None,
        device_status: str = None,
        device_type: str = None,
        device_union_id: str = None,
        open_room_id: str = None,
        share_code: str = None,
    ):
        self.corp_id = corp_id
        self.device_id = device_id
        self.device_mac = device_mac
        self.device_model = device_model
        self.device_name = device_name
        self.device_service_id = device_service_id
        self.device_sn = device_sn
        self.device_status = device_status
        self.device_type = device_type
        self.device_union_id = device_union_id
        self.open_room_id = open_room_id
        self.share_code = share_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.device_id is not None:
            result['deviceId'] = self.device_id
        if self.device_mac is not None:
            result['deviceMac'] = self.device_mac
        if self.device_model is not None:
            result['deviceModel'] = self.device_model
        if self.device_name is not None:
            result['deviceName'] = self.device_name
        if self.device_service_id is not None:
            result['deviceServiceId'] = self.device_service_id
        if self.device_sn is not None:
            result['deviceSn'] = self.device_sn
        if self.device_status is not None:
            result['deviceStatus'] = self.device_status
        if self.device_type is not None:
            result['deviceType'] = self.device_type
        if self.device_union_id is not None:
            result['deviceUnionId'] = self.device_union_id
        if self.open_room_id is not None:
            result['openRoomId'] = self.open_room_id
        if self.share_code is not None:
            result['shareCode'] = self.share_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('deviceId') is not None:
            self.device_id = m.get('deviceId')
        if m.get('deviceMac') is not None:
            self.device_mac = m.get('deviceMac')
        if m.get('deviceModel') is not None:
            self.device_model = m.get('deviceModel')
        if m.get('deviceName') is not None:
            self.device_name = m.get('deviceName')
        if m.get('deviceServiceId') is not None:
            self.device_service_id = m.get('deviceServiceId')
        if m.get('deviceSn') is not None:
            self.device_sn = m.get('deviceSn')
        if m.get('deviceStatus') is not None:
            self.device_status = m.get('deviceStatus')
        if m.get('deviceType') is not None:
            self.device_type = m.get('deviceType')
        if m.get('deviceUnionId') is not None:
            self.device_union_id = m.get('deviceUnionId')
        if m.get('openRoomId') is not None:
            self.open_room_id = m.get('openRoomId')
        if m.get('shareCode') is not None:
            self.share_code = m.get('shareCode')
        return self


class QueryMeetingRoomDeviceResponseBodyResult(TeaModel):
    def __init__(
        self,
        controllers: List[QueryMeetingRoomDeviceResponseBodyResultControllers] = None,
        corp_id: str = None,
        device_id: str = None,
        device_mac: str = None,
        device_model: str = None,
        device_name: str = None,
        device_service_id: int = None,
        device_sn: str = None,
        device_status: str = None,
        device_type: str = None,
        device_union_id: str = None,
        open_room_id: str = None,
        share_code: str = None,
    ):
        self.controllers = controllers
        self.corp_id = corp_id
        self.device_id = device_id
        self.device_mac = device_mac
        self.device_model = device_model
        self.device_name = device_name
        self.device_service_id = device_service_id
        self.device_sn = device_sn
        self.device_status = device_status
        self.device_type = device_type
        self.device_union_id = device_union_id
        self.open_room_id = open_room_id
        self.share_code = share_code

    def validate(self):
        if self.controllers:
            for k in self.controllers:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['controllers'] = []
        if self.controllers is not None:
            for k in self.controllers:
                result['controllers'].append(k.to_map() if k else None)
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.device_id is not None:
            result['deviceId'] = self.device_id
        if self.device_mac is not None:
            result['deviceMac'] = self.device_mac
        if self.device_model is not None:
            result['deviceModel'] = self.device_model
        if self.device_name is not None:
            result['deviceName'] = self.device_name
        if self.device_service_id is not None:
            result['deviceServiceId'] = self.device_service_id
        if self.device_sn is not None:
            result['deviceSn'] = self.device_sn
        if self.device_status is not None:
            result['deviceStatus'] = self.device_status
        if self.device_type is not None:
            result['deviceType'] = self.device_type
        if self.device_union_id is not None:
            result['deviceUnionId'] = self.device_union_id
        if self.open_room_id is not None:
            result['openRoomId'] = self.open_room_id
        if self.share_code is not None:
            result['shareCode'] = self.share_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.controllers = []
        if m.get('controllers') is not None:
            for k in m.get('controllers'):
                temp_model = QueryMeetingRoomDeviceResponseBodyResultControllers()
                self.controllers.append(temp_model.from_map(k))
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('deviceId') is not None:
            self.device_id = m.get('deviceId')
        if m.get('deviceMac') is not None:
            self.device_mac = m.get('deviceMac')
        if m.get('deviceModel') is not None:
            self.device_model = m.get('deviceModel')
        if m.get('deviceName') is not None:
            self.device_name = m.get('deviceName')
        if m.get('deviceServiceId') is not None:
            self.device_service_id = m.get('deviceServiceId')
        if m.get('deviceSn') is not None:
            self.device_sn = m.get('deviceSn')
        if m.get('deviceStatus') is not None:
            self.device_status = m.get('deviceStatus')
        if m.get('deviceType') is not None:
            self.device_type = m.get('deviceType')
        if m.get('deviceUnionId') is not None:
            self.device_union_id = m.get('deviceUnionId')
        if m.get('openRoomId') is not None:
            self.open_room_id = m.get('openRoomId')
        if m.get('shareCode') is not None:
            self.share_code = m.get('shareCode')
        return self


class QueryMeetingRoomDeviceResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryMeetingRoomDeviceResponseBodyResult = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = QueryMeetingRoomDeviceResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class QueryMeetingRoomDeviceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryMeetingRoomDeviceResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = QueryMeetingRoomDeviceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryMeetingRoomGroupHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryMeetingRoomGroupRequest(TeaModel):
    def __init__(
        self,
        union_id: str = None,
    ):
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class QueryMeetingRoomGroupResponseBody(TeaModel):
    def __init__(
        self,
        group_id: int = None,
        group_name: str = None,
        parent_id: int = None,
    ):
        self.group_id = group_id
        self.group_name = group_name
        self.parent_id = parent_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_id is not None:
            result['groupId'] = self.group_id
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.parent_id is not None:
            result['parentId'] = self.parent_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupId') is not None:
            self.group_id = m.get('groupId')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('parentId') is not None:
            self.parent_id = m.get('parentId')
        return self


class QueryMeetingRoomGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryMeetingRoomGroupResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = QueryMeetingRoomGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryMeetingRoomGroupListHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryMeetingRoomGroupListRequest(TeaModel):
    def __init__(
        self,
        union_id: str = None,
    ):
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class QueryMeetingRoomGroupListResponseBodyResult(TeaModel):
    def __init__(
        self,
        group_id: int = None,
        group_name: str = None,
        parent_id: int = None,
    ):
        self.group_id = group_id
        self.group_name = group_name
        self.parent_id = parent_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_id is not None:
            result['groupId'] = self.group_id
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.parent_id is not None:
            result['parentId'] = self.parent_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupId') is not None:
            self.group_id = m.get('groupId')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('parentId') is not None:
            self.parent_id = m.get('parentId')
        return self


class QueryMeetingRoomGroupListResponseBody(TeaModel):
    def __init__(
        self,
        result: List[QueryMeetingRoomGroupListResponseBodyResult] = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            for k in self.result:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['result'] = []
        if self.result is not None:
            for k in self.result:
                result['result'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = QueryMeetingRoomGroupListResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class QueryMeetingRoomGroupListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryMeetingRoomGroupListResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = QueryMeetingRoomGroupListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryMeetingRoomListHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryMeetingRoomListRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: int = None,
        union_id: str = None,
    ):
        self.max_results = max_results
        self.next_token = next_token
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class QueryMeetingRoomListResponseBodyResultRoomGroup(TeaModel):
    def __init__(
        self,
        group_id: int = None,
        group_name: str = None,
        parent_id: int = None,
    ):
        self.group_id = group_id
        self.group_name = group_name
        self.parent_id = parent_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_id is not None:
            result['groupId'] = self.group_id
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.parent_id is not None:
            result['parentId'] = self.parent_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupId') is not None:
            self.group_id = m.get('groupId')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('parentId') is not None:
            self.parent_id = m.get('parentId')
        return self


class QueryMeetingRoomListResponseBodyResultRoomLabels(TeaModel):
    def __init__(
        self,
        label_id: int = None,
        label_name: str = None,
    ):
        self.label_id = label_id
        self.label_name = label_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.label_id is not None:
            result['labelId'] = self.label_id
        if self.label_name is not None:
            result['labelName'] = self.label_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('labelId') is not None:
            self.label_id = m.get('labelId')
        if m.get('labelName') is not None:
            self.label_name = m.get('labelName')
        return self


class QueryMeetingRoomListResponseBodyResultRoomLocation(TeaModel):
    def __init__(
        self,
        desc: str = None,
        title: str = None,
    ):
        self.desc = desc
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.desc is not None:
            result['desc'] = self.desc
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('desc') is not None:
            self.desc = m.get('desc')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class QueryMeetingRoomListResponseBodyResult(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        isv_room_id: str = None,
        room_capacity: int = None,
        room_group: QueryMeetingRoomListResponseBodyResultRoomGroup = None,
        room_id: str = None,
        room_labels: List[QueryMeetingRoomListResponseBodyResultRoomLabels] = None,
        room_location: QueryMeetingRoomListResponseBodyResultRoomLocation = None,
        room_name: str = None,
        room_picture: str = None,
        room_staff_id: str = None,
        room_status: int = None,
    ):
        self.corp_id = corp_id
        self.isv_room_id = isv_room_id
        self.room_capacity = room_capacity
        self.room_group = room_group
        self.room_id = room_id
        self.room_labels = room_labels
        self.room_location = room_location
        self.room_name = room_name
        self.room_picture = room_picture
        self.room_staff_id = room_staff_id
        self.room_status = room_status

    def validate(self):
        if self.room_group:
            self.room_group.validate()
        if self.room_labels:
            for k in self.room_labels:
                if k:
                    k.validate()
        if self.room_location:
            self.room_location.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.isv_room_id is not None:
            result['isvRoomId'] = self.isv_room_id
        if self.room_capacity is not None:
            result['roomCapacity'] = self.room_capacity
        if self.room_group is not None:
            result['roomGroup'] = self.room_group.to_map()
        if self.room_id is not None:
            result['roomId'] = self.room_id
        result['roomLabels'] = []
        if self.room_labels is not None:
            for k in self.room_labels:
                result['roomLabels'].append(k.to_map() if k else None)
        if self.room_location is not None:
            result['roomLocation'] = self.room_location.to_map()
        if self.room_name is not None:
            result['roomName'] = self.room_name
        if self.room_picture is not None:
            result['roomPicture'] = self.room_picture
        if self.room_staff_id is not None:
            result['roomStaffId'] = self.room_staff_id
        if self.room_status is not None:
            result['roomStatus'] = self.room_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('isvRoomId') is not None:
            self.isv_room_id = m.get('isvRoomId')
        if m.get('roomCapacity') is not None:
            self.room_capacity = m.get('roomCapacity')
        if m.get('roomGroup') is not None:
            temp_model = QueryMeetingRoomListResponseBodyResultRoomGroup()
            self.room_group = temp_model.from_map(m['roomGroup'])
        if m.get('roomId') is not None:
            self.room_id = m.get('roomId')
        self.room_labels = []
        if m.get('roomLabels') is not None:
            for k in m.get('roomLabels'):
                temp_model = QueryMeetingRoomListResponseBodyResultRoomLabels()
                self.room_labels.append(temp_model.from_map(k))
        if m.get('roomLocation') is not None:
            temp_model = QueryMeetingRoomListResponseBodyResultRoomLocation()
            self.room_location = temp_model.from_map(m['roomLocation'])
        if m.get('roomName') is not None:
            self.room_name = m.get('roomName')
        if m.get('roomPicture') is not None:
            self.room_picture = m.get('roomPicture')
        if m.get('roomStaffId') is not None:
            self.room_staff_id = m.get('roomStaffId')
        if m.get('roomStatus') is not None:
            self.room_status = m.get('roomStatus')
        return self


class QueryMeetingRoomListResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        next_token: int = None,
        result: List[QueryMeetingRoomListResponseBodyResult] = None,
    ):
        self.has_more = has_more
        self.next_token = next_token
        self.result = result

    def validate(self):
        if self.result:
            for k in self.result:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['result'] = []
        if self.result is not None:
            for k in self.result:
                result['result'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = QueryMeetingRoomListResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class QueryMeetingRoomListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryMeetingRoomListResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = QueryMeetingRoomListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RemoveSuperUserMeetingRoomHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class RemoveSuperUserMeetingRoomRequest(TeaModel):
    def __init__(
        self,
        room_id: str = None,
        union_id: str = None,
    ):
        self.room_id = room_id
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.room_id is not None:
            result['roomId'] = self.room_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('roomId') is not None:
            self.room_id = m.get('roomId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class RemoveSuperUserMeetingRoomResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class RemoveSuperUserMeetingRoomResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RemoveSuperUserMeetingRoomResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = RemoveSuperUserMeetingRoomResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SetSuperUserMeetingRoomHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class SetSuperUserMeetingRoomRequest(TeaModel):
    def __init__(
        self,
        dept_id_white_list: List[int] = None,
        room_id: str = None,
        union_id: str = None,
        user_id_white_list: List[str] = None,
    ):
        self.dept_id_white_list = dept_id_white_list
        self.room_id = room_id
        self.union_id = union_id
        self.user_id_white_list = user_id_white_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id_white_list is not None:
            result['deptIdWhiteList'] = self.dept_id_white_list
        if self.room_id is not None:
            result['roomId'] = self.room_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.user_id_white_list is not None:
            result['userIdWhiteList'] = self.user_id_white_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptIdWhiteList') is not None:
            self.dept_id_white_list = m.get('deptIdWhiteList')
        if m.get('roomId') is not None:
            self.room_id = m.get('roomId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('userIdWhiteList') is not None:
            self.user_id_white_list = m.get('userIdWhiteList')
        return self


class SetSuperUserMeetingRoomResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class SetSuperUserMeetingRoomResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SetSuperUserMeetingRoomResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = SetSuperUserMeetingRoomResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateMeetingRoomHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class UpdateMeetingRoomRequestRoomLocation(TeaModel):
    def __init__(
        self,
        desc: str = None,
        title: str = None,
    ):
        self.desc = desc
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.desc is not None:
            result['desc'] = self.desc
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('desc') is not None:
            self.desc = m.get('desc')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class UpdateMeetingRoomRequest(TeaModel):
    def __init__(
        self,
        group_id: int = None,
        isv_room_id: str = None,
        room_capacity: int = None,
        room_id: str = None,
        room_label_ids: List[int] = None,
        room_location: UpdateMeetingRoomRequestRoomLocation = None,
        room_name: str = None,
        room_picture: str = None,
        room_status: int = None,
        union_id: str = None,
    ):
        self.group_id = group_id
        self.isv_room_id = isv_room_id
        self.room_capacity = room_capacity
        self.room_id = room_id
        self.room_label_ids = room_label_ids
        self.room_location = room_location
        self.room_name = room_name
        self.room_picture = room_picture
        self.room_status = room_status
        self.union_id = union_id

    def validate(self):
        if self.room_location:
            self.room_location.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_id is not None:
            result['groupId'] = self.group_id
        if self.isv_room_id is not None:
            result['isvRoomId'] = self.isv_room_id
        if self.room_capacity is not None:
            result['roomCapacity'] = self.room_capacity
        if self.room_id is not None:
            result['roomId'] = self.room_id
        if self.room_label_ids is not None:
            result['roomLabelIds'] = self.room_label_ids
        if self.room_location is not None:
            result['roomLocation'] = self.room_location.to_map()
        if self.room_name is not None:
            result['roomName'] = self.room_name
        if self.room_picture is not None:
            result['roomPicture'] = self.room_picture
        if self.room_status is not None:
            result['roomStatus'] = self.room_status
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupId') is not None:
            self.group_id = m.get('groupId')
        if m.get('isvRoomId') is not None:
            self.isv_room_id = m.get('isvRoomId')
        if m.get('roomCapacity') is not None:
            self.room_capacity = m.get('roomCapacity')
        if m.get('roomId') is not None:
            self.room_id = m.get('roomId')
        if m.get('roomLabelIds') is not None:
            self.room_label_ids = m.get('roomLabelIds')
        if m.get('roomLocation') is not None:
            temp_model = UpdateMeetingRoomRequestRoomLocation()
            self.room_location = temp_model.from_map(m['roomLocation'])
        if m.get('roomName') is not None:
            self.room_name = m.get('roomName')
        if m.get('roomPicture') is not None:
            self.room_picture = m.get('roomPicture')
        if m.get('roomStatus') is not None:
            self.room_status = m.get('roomStatus')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class UpdateMeetingRoomResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class UpdateMeetingRoomResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateMeetingRoomResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = UpdateMeetingRoomResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateMeetingRoomGroupHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class UpdateMeetingRoomGroupRequest(TeaModel):
    def __init__(
        self,
        group_id: int = None,
        group_name: str = None,
        union_id: str = None,
    ):
        self.group_id = group_id
        self.group_name = group_name
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_id is not None:
            result['groupId'] = self.group_id
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupId') is not None:
            self.group_id = m.get('groupId')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class UpdateMeetingRoomGroupResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class UpdateMeetingRoomGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateMeetingRoomGroupResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            temp_model = UpdateMeetingRoomGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


