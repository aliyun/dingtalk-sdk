# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List, Any


class AddAttendeeHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_client_token: str = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_client_token = x_client_token
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
        if self.x_client_token is not None:
            result['x-client-token'] = self.x_client_token
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-client-token') is not None:
            self.x_client_token = m.get('x-client-token')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class AddAttendeeRequestAttendeesToAdd(TeaModel):
    def __init__(
        self,
        id: str = None,
        is_optional: bool = None,
    ):
        self.id = id
        self.is_optional = is_optional

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.is_optional is not None:
            result['isOptional'] = self.is_optional
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isOptional') is not None:
            self.is_optional = m.get('isOptional')
        return self


class AddAttendeeRequest(TeaModel):
    def __init__(
        self,
        attendees_to_add: List[AddAttendeeRequestAttendeesToAdd] = None,
        chat_notification: bool = None,
        push_notification: bool = None,
    ):
        # This parameter is required.
        self.attendees_to_add = attendees_to_add
        self.chat_notification = chat_notification
        self.push_notification = push_notification

    def validate(self):
        if self.attendees_to_add:
            for k in self.attendees_to_add:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['attendeesToAdd'] = []
        if self.attendees_to_add is not None:
            for k in self.attendees_to_add:
                result['attendeesToAdd'].append(k.to_map() if k else None)
        if self.chat_notification is not None:
            result['chatNotification'] = self.chat_notification
        if self.push_notification is not None:
            result['pushNotification'] = self.push_notification
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attendees_to_add = []
        if m.get('attendeesToAdd') is not None:
            for k in m.get('attendeesToAdd'):
                temp_model = AddAttendeeRequestAttendeesToAdd()
                self.attendees_to_add.append(temp_model.from_map(k))
        if m.get('chatNotification') is not None:
            self.chat_notification = m.get('chatNotification')
        if m.get('pushNotification') is not None:
            self.push_notification = m.get('pushNotification')
        return self


class AddAttendeeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
    ):
        self.headers = headers
        self.status_code = status_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        return self


class AddMeetingRoomsHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_client_token: str = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_client_token = x_client_token
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
        if self.x_client_token is not None:
            result['x-client-token'] = self.x_client_token
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-client-token') is not None:
            self.x_client_token = m.get('x-client-token')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class AddMeetingRoomsRequestMeetingRoomsToAdd(TeaModel):
    def __init__(
        self,
        room_id: str = None,
    ):
        self.room_id = room_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.room_id is not None:
            result['roomId'] = self.room_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('roomId') is not None:
            self.room_id = m.get('roomId')
        return self


class AddMeetingRoomsRequest(TeaModel):
    def __init__(
        self,
        meeting_rooms_to_add: List[AddMeetingRoomsRequestMeetingRoomsToAdd] = None,
    ):
        # This parameter is required.
        self.meeting_rooms_to_add = meeting_rooms_to_add

    def validate(self):
        if self.meeting_rooms_to_add:
            for k in self.meeting_rooms_to_add:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['meetingRoomsToAdd'] = []
        if self.meeting_rooms_to_add is not None:
            for k in self.meeting_rooms_to_add:
                result['meetingRoomsToAdd'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.meeting_rooms_to_add = []
        if m.get('meetingRoomsToAdd') is not None:
            for k in m.get('meetingRoomsToAdd'):
                temp_model = AddMeetingRoomsRequestMeetingRoomsToAdd()
                self.meeting_rooms_to_add.append(temp_model.from_map(k))
        return self


class AddMeetingRoomsResponseBody(TeaModel):
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


class AddMeetingRoomsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AddMeetingRoomsResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = AddMeetingRoomsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CancelEventHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_client_token: str = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_client_token = x_client_token
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
        if self.x_client_token is not None:
            result['x-client-token'] = self.x_client_token
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-client-token') is not None:
            self.x_client_token = m.get('x-client-token')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class CancelEventRequest(TeaModel):
    def __init__(
        self,
        scope: str = None,
    ):
        self.scope = scope

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.scope is not None:
            result['scope'] = self.scope
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('scope') is not None:
            self.scope = m.get('scope')
        return self


class CancelEventResponseBody(TeaModel):
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


class CancelEventResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CancelEventResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = CancelEventResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CheckInHeaders(TeaModel):
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


class CheckInResponseBody(TeaModel):
    def __init__(
        self,
        check_in_time: int = None,
    ):
        self.check_in_time = check_in_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.check_in_time is not None:
            result['checkInTime'] = self.check_in_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('checkInTime') is not None:
            self.check_in_time = m.get('checkInTime')
        return self


class CheckInResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CheckInResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = CheckInResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ConvertLegacyEventIdHeaders(TeaModel):
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


class ConvertLegacyEventIdRequest(TeaModel):
    def __init__(
        self,
        legacy_event_ids: List[str] = None,
    ):
        # This parameter is required.
        self.legacy_event_ids = legacy_event_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.legacy_event_ids is not None:
            result['legacyEventIds'] = self.legacy_event_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('legacyEventIds') is not None:
            self.legacy_event_ids = m.get('legacyEventIds')
        return self


class ConvertLegacyEventIdResponseBody(TeaModel):
    def __init__(
        self,
        legacy_event_id_map: Dict[str, Any] = None,
    ):
        self.legacy_event_id_map = legacy_event_id_map

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.legacy_event_id_map is not None:
            result['legacyEventIdMap'] = self.legacy_event_id_map
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('legacyEventIdMap') is not None:
            self.legacy_event_id_map = m.get('legacyEventIdMap')
        return self


class ConvertLegacyEventIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ConvertLegacyEventIdResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = ConvertLegacyEventIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateAclsHeaders(TeaModel):
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


class CreateAclsRequestScope(TeaModel):
    def __init__(
        self,
        scope_type: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.scope_type = scope_type
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.scope_type is not None:
            result['scopeType'] = self.scope_type
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('scopeType') is not None:
            self.scope_type = m.get('scopeType')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CreateAclsRequest(TeaModel):
    def __init__(
        self,
        privilege: str = None,
        scope: CreateAclsRequestScope = None,
        send_msg: bool = None,
    ):
        # This parameter is required.
        self.privilege = privilege
        # This parameter is required.
        self.scope = scope
        # This parameter is required.
        self.send_msg = send_msg

    def validate(self):
        if self.scope:
            self.scope.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.privilege is not None:
            result['privilege'] = self.privilege
        if self.scope is not None:
            result['scope'] = self.scope.to_map()
        if self.send_msg is not None:
            result['sendMsg'] = self.send_msg
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('privilege') is not None:
            self.privilege = m.get('privilege')
        if m.get('scope') is not None:
            temp_model = CreateAclsRequestScope()
            self.scope = temp_model.from_map(m['scope'])
        if m.get('sendMsg') is not None:
            self.send_msg = m.get('sendMsg')
        return self


class CreateAclsResponseBodyScope(TeaModel):
    def __init__(
        self,
        scope_type: str = None,
        user_id: str = None,
    ):
        self.scope_type = scope_type
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.scope_type is not None:
            result['scopeType'] = self.scope_type
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('scopeType') is not None:
            self.scope_type = m.get('scopeType')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CreateAclsResponseBody(TeaModel):
    def __init__(
        self,
        acl_id: str = None,
        privilege: str = None,
        scope: CreateAclsResponseBodyScope = None,
    ):
        self.acl_id = acl_id
        self.privilege = privilege
        self.scope = scope

    def validate(self):
        if self.scope:
            self.scope.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.acl_id is not None:
            result['aclId'] = self.acl_id
        if self.privilege is not None:
            result['privilege'] = self.privilege
        if self.scope is not None:
            result['scope'] = self.scope.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('aclId') is not None:
            self.acl_id = m.get('aclId')
        if m.get('privilege') is not None:
            self.privilege = m.get('privilege')
        if m.get('scope') is not None:
            temp_model = CreateAclsResponseBodyScope()
            self.scope = temp_model.from_map(m['scope'])
        return self


class CreateAclsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateAclsResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = CreateAclsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateEventHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_client_token: str = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_client_token = x_client_token
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
        if self.x_client_token is not None:
            result['x-client-token'] = self.x_client_token
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-client-token') is not None:
            self.x_client_token = m.get('x-client-token')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class CreateEventRequestAttendees(TeaModel):
    def __init__(
        self,
        id: str = None,
        is_optional: bool = None,
    ):
        self.id = id
        self.is_optional = is_optional

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.is_optional is not None:
            result['isOptional'] = self.is_optional
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isOptional') is not None:
            self.is_optional = m.get('isOptional')
        return self


class CreateEventRequestCardInstances(TeaModel):
    def __init__(
        self,
        out_track_id: str = None,
        scenario: str = None,
    ):
        self.out_track_id = out_track_id
        self.scenario = scenario

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.out_track_id is not None:
            result['outTrackId'] = self.out_track_id
        if self.scenario is not None:
            result['scenario'] = self.scenario
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('outTrackId') is not None:
            self.out_track_id = m.get('outTrackId')
        if m.get('scenario') is not None:
            self.scenario = m.get('scenario')
        return self


class CreateEventRequestEnd(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        self.date = date
        self.date_time = date_time
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class CreateEventRequestLocation(TeaModel):
    def __init__(
        self,
        display_name: str = None,
    ):
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        return self


class CreateEventRequestOnlineMeetingInfo(TeaModel):
    def __init__(
        self,
        type: str = None,
    ):
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class CreateEventRequestRecurrencePattern(TeaModel):
    def __init__(
        self,
        day_of_month: int = None,
        days_of_week: str = None,
        first_day_of_week: str = None,
        index: str = None,
        interval: int = None,
        type: str = None,
    ):
        self.day_of_month = day_of_month
        self.days_of_week = days_of_week
        self.first_day_of_week = first_day_of_week
        self.index = index
        self.interval = interval
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        if self.days_of_week is not None:
            result['daysOfWeek'] = self.days_of_week
        if self.first_day_of_week is not None:
            result['firstDayOfWeek'] = self.first_day_of_week
        if self.index is not None:
            result['index'] = self.index
        if self.interval is not None:
            result['interval'] = self.interval
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        if m.get('daysOfWeek') is not None:
            self.days_of_week = m.get('daysOfWeek')
        if m.get('firstDayOfWeek') is not None:
            self.first_day_of_week = m.get('firstDayOfWeek')
        if m.get('index') is not None:
            self.index = m.get('index')
        if m.get('interval') is not None:
            self.interval = m.get('interval')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class CreateEventRequestRecurrenceRange(TeaModel):
    def __init__(
        self,
        end_date: str = None,
        number_of_occurrences: int = None,
        type: str = None,
    ):
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.end_date = end_date
        self.number_of_occurrences = number_of_occurrences
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.number_of_occurrences is not None:
            result['numberOfOccurrences'] = self.number_of_occurrences
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('numberOfOccurrences') is not None:
            self.number_of_occurrences = m.get('numberOfOccurrences')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class CreateEventRequestRecurrence(TeaModel):
    def __init__(
        self,
        pattern: CreateEventRequestRecurrencePattern = None,
        range: CreateEventRequestRecurrenceRange = None,
    ):
        self.pattern = pattern
        self.range = range

    def validate(self):
        if self.pattern:
            self.pattern.validate()
        if self.range:
            self.range.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.pattern is not None:
            result['pattern'] = self.pattern.to_map()
        if self.range is not None:
            result['range'] = self.range.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pattern') is not None:
            temp_model = CreateEventRequestRecurrencePattern()
            self.pattern = temp_model.from_map(m['pattern'])
        if m.get('range') is not None:
            temp_model = CreateEventRequestRecurrenceRange()
            self.range = temp_model.from_map(m['range'])
        return self


class CreateEventRequestReminders(TeaModel):
    def __init__(
        self,
        method: str = None,
        minutes: int = None,
    ):
        self.method = method
        self.minutes = minutes

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.method is not None:
            result['method'] = self.method
        if self.minutes is not None:
            result['minutes'] = self.minutes
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('method') is not None:
            self.method = m.get('method')
        if m.get('minutes') is not None:
            self.minutes = m.get('minutes')
        return self


class CreateEventRequestRichTextDescription(TeaModel):
    def __init__(
        self,
        text: str = None,
    ):
        self.text = text

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.text is not None:
            result['text'] = self.text
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('text') is not None:
            self.text = m.get('text')
        return self


class CreateEventRequestStart(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        self.date = date
        self.date_time = date_time
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class CreateEventRequestUiConfigs(TeaModel):
    def __init__(
        self,
        ui_name: str = None,
        ui_status: str = None,
    ):
        self.ui_name = ui_name
        self.ui_status = ui_status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ui_name is not None:
            result['uiName'] = self.ui_name
        if self.ui_status is not None:
            result['uiStatus'] = self.ui_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('uiName') is not None:
            self.ui_name = m.get('uiName')
        if m.get('uiStatus') is not None:
            self.ui_status = m.get('uiStatus')
        return self


class CreateEventRequest(TeaModel):
    def __init__(
        self,
        attendees: List[CreateEventRequestAttendees] = None,
        card_instances: List[CreateEventRequestCardInstances] = None,
        description: str = None,
        end: CreateEventRequestEnd = None,
        extra: Dict[str, str] = None,
        is_all_day: bool = None,
        location: CreateEventRequestLocation = None,
        online_meeting_info: CreateEventRequestOnlineMeetingInfo = None,
        recurrence: CreateEventRequestRecurrence = None,
        reminders: List[CreateEventRequestReminders] = None,
        rich_text_description: CreateEventRequestRichTextDescription = None,
        start: CreateEventRequestStart = None,
        summary: str = None,
        ui_configs: List[CreateEventRequestUiConfigs] = None,
    ):
        self.attendees = attendees
        self.card_instances = card_instances
        self.description = description
        self.end = end
        self.extra = extra
        self.is_all_day = is_all_day
        self.location = location
        self.online_meeting_info = online_meeting_info
        self.recurrence = recurrence
        self.reminders = reminders
        self.rich_text_description = rich_text_description
        # This parameter is required.
        self.start = start
        # This parameter is required.
        self.summary = summary
        self.ui_configs = ui_configs

    def validate(self):
        if self.attendees:
            for k in self.attendees:
                if k:
                    k.validate()
        if self.card_instances:
            for k in self.card_instances:
                if k:
                    k.validate()
        if self.end:
            self.end.validate()
        if self.location:
            self.location.validate()
        if self.online_meeting_info:
            self.online_meeting_info.validate()
        if self.recurrence:
            self.recurrence.validate()
        if self.reminders:
            for k in self.reminders:
                if k:
                    k.validate()
        if self.rich_text_description:
            self.rich_text_description.validate()
        if self.start:
            self.start.validate()
        if self.ui_configs:
            for k in self.ui_configs:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['attendees'] = []
        if self.attendees is not None:
            for k in self.attendees:
                result['attendees'].append(k.to_map() if k else None)
        result['cardInstances'] = []
        if self.card_instances is not None:
            for k in self.card_instances:
                result['cardInstances'].append(k.to_map() if k else None)
        if self.description is not None:
            result['description'] = self.description
        if self.end is not None:
            result['end'] = self.end.to_map()
        if self.extra is not None:
            result['extra'] = self.extra
        if self.is_all_day is not None:
            result['isAllDay'] = self.is_all_day
        if self.location is not None:
            result['location'] = self.location.to_map()
        if self.online_meeting_info is not None:
            result['onlineMeetingInfo'] = self.online_meeting_info.to_map()
        if self.recurrence is not None:
            result['recurrence'] = self.recurrence.to_map()
        result['reminders'] = []
        if self.reminders is not None:
            for k in self.reminders:
                result['reminders'].append(k.to_map() if k else None)
        if self.rich_text_description is not None:
            result['richTextDescription'] = self.rich_text_description.to_map()
        if self.start is not None:
            result['start'] = self.start.to_map()
        if self.summary is not None:
            result['summary'] = self.summary
        result['uiConfigs'] = []
        if self.ui_configs is not None:
            for k in self.ui_configs:
                result['uiConfigs'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attendees = []
        if m.get('attendees') is not None:
            for k in m.get('attendees'):
                temp_model = CreateEventRequestAttendees()
                self.attendees.append(temp_model.from_map(k))
        self.card_instances = []
        if m.get('cardInstances') is not None:
            for k in m.get('cardInstances'):
                temp_model = CreateEventRequestCardInstances()
                self.card_instances.append(temp_model.from_map(k))
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('end') is not None:
            temp_model = CreateEventRequestEnd()
            self.end = temp_model.from_map(m['end'])
        if m.get('extra') is not None:
            self.extra = m.get('extra')
        if m.get('isAllDay') is not None:
            self.is_all_day = m.get('isAllDay')
        if m.get('location') is not None:
            temp_model = CreateEventRequestLocation()
            self.location = temp_model.from_map(m['location'])
        if m.get('onlineMeetingInfo') is not None:
            temp_model = CreateEventRequestOnlineMeetingInfo()
            self.online_meeting_info = temp_model.from_map(m['onlineMeetingInfo'])
        if m.get('recurrence') is not None:
            temp_model = CreateEventRequestRecurrence()
            self.recurrence = temp_model.from_map(m['recurrence'])
        self.reminders = []
        if m.get('reminders') is not None:
            for k in m.get('reminders'):
                temp_model = CreateEventRequestReminders()
                self.reminders.append(temp_model.from_map(k))
        if m.get('richTextDescription') is not None:
            temp_model = CreateEventRequestRichTextDescription()
            self.rich_text_description = temp_model.from_map(m['richTextDescription'])
        if m.get('start') is not None:
            temp_model = CreateEventRequestStart()
            self.start = temp_model.from_map(m['start'])
        if m.get('summary') is not None:
            self.summary = m.get('summary')
        self.ui_configs = []
        if m.get('uiConfigs') is not None:
            for k in m.get('uiConfigs'):
                temp_model = CreateEventRequestUiConfigs()
                self.ui_configs.append(temp_model.from_map(k))
        return self


class CreateEventResponseBodyAttendees(TeaModel):
    def __init__(
        self,
        display_name: str = None,
        id: str = None,
        is_optional: bool = None,
        response_status: str = None,
        self_: bool = None,
    ):
        self.display_name = display_name
        self.id = id
        self.is_optional = is_optional
        self.response_status = response_status
        self.self_ = self_

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.id is not None:
            result['id'] = self.id
        if self.is_optional is not None:
            result['isOptional'] = self.is_optional
        if self.response_status is not None:
            result['responseStatus'] = self.response_status
        if self.self_ is not None:
            result['self'] = self.self_
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isOptional') is not None:
            self.is_optional = m.get('isOptional')
        if m.get('responseStatus') is not None:
            self.response_status = m.get('responseStatus')
        if m.get('self') is not None:
            self.self_ = m.get('self')
        return self


class CreateEventResponseBodyCardInstances(TeaModel):
    def __init__(
        self,
        out_track_id: str = None,
        scenario: str = None,
    ):
        self.out_track_id = out_track_id
        self.scenario = scenario

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.out_track_id is not None:
            result['outTrackId'] = self.out_track_id
        if self.scenario is not None:
            result['scenario'] = self.scenario
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('outTrackId') is not None:
            self.out_track_id = m.get('outTrackId')
        if m.get('scenario') is not None:
            self.scenario = m.get('scenario')
        return self


class CreateEventResponseBodyEnd(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        self.date = date
        self.date_time = date_time
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class CreateEventResponseBodyLocation(TeaModel):
    def __init__(
        self,
        display_name: str = None,
    ):
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        return self


class CreateEventResponseBodyOnlineMeetingInfo(TeaModel):
    def __init__(
        self,
        conference_id: str = None,
        extra_info: Dict[str, Any] = None,
        type: str = None,
        url: str = None,
    ):
        self.conference_id = conference_id
        self.extra_info = extra_info
        self.type = type
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conference_id is not None:
            result['conferenceId'] = self.conference_id
        if self.extra_info is not None:
            result['extraInfo'] = self.extra_info
        if self.type is not None:
            result['type'] = self.type
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conferenceId') is not None:
            self.conference_id = m.get('conferenceId')
        if m.get('extraInfo') is not None:
            self.extra_info = m.get('extraInfo')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class CreateEventResponseBodyOrganizer(TeaModel):
    def __init__(
        self,
        display_name: str = None,
        id: str = None,
        response_status: str = None,
        self_: bool = None,
    ):
        self.display_name = display_name
        self.id = id
        self.response_status = response_status
        self.self_ = self_

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.id is not None:
            result['id'] = self.id
        if self.response_status is not None:
            result['responseStatus'] = self.response_status
        if self.self_ is not None:
            result['self'] = self.self_
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('responseStatus') is not None:
            self.response_status = m.get('responseStatus')
        if m.get('self') is not None:
            self.self_ = m.get('self')
        return self


class CreateEventResponseBodyRecurrencePattern(TeaModel):
    def __init__(
        self,
        day_of_month: int = None,
        days_of_week: str = None,
        first_day_of_week: str = None,
        index: str = None,
        interval: int = None,
        type: str = None,
    ):
        self.day_of_month = day_of_month
        self.days_of_week = days_of_week
        self.first_day_of_week = first_day_of_week
        self.index = index
        self.interval = interval
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        if self.days_of_week is not None:
            result['daysOfWeek'] = self.days_of_week
        if self.first_day_of_week is not None:
            result['firstDayOfWeek'] = self.first_day_of_week
        if self.index is not None:
            result['index'] = self.index
        if self.interval is not None:
            result['interval'] = self.interval
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        if m.get('daysOfWeek') is not None:
            self.days_of_week = m.get('daysOfWeek')
        if m.get('firstDayOfWeek') is not None:
            self.first_day_of_week = m.get('firstDayOfWeek')
        if m.get('index') is not None:
            self.index = m.get('index')
        if m.get('interval') is not None:
            self.interval = m.get('interval')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class CreateEventResponseBodyRecurrenceRange(TeaModel):
    def __init__(
        self,
        end_date: str = None,
        number_of_occurrences: int = None,
        type: str = None,
    ):
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.end_date = end_date
        self.number_of_occurrences = number_of_occurrences
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.number_of_occurrences is not None:
            result['numberOfOccurrences'] = self.number_of_occurrences
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('numberOfOccurrences') is not None:
            self.number_of_occurrences = m.get('numberOfOccurrences')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class CreateEventResponseBodyRecurrence(TeaModel):
    def __init__(
        self,
        pattern: CreateEventResponseBodyRecurrencePattern = None,
        range: CreateEventResponseBodyRecurrenceRange = None,
    ):
        self.pattern = pattern
        self.range = range

    def validate(self):
        if self.pattern:
            self.pattern.validate()
        if self.range:
            self.range.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.pattern is not None:
            result['pattern'] = self.pattern.to_map()
        if self.range is not None:
            result['range'] = self.range.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pattern') is not None:
            temp_model = CreateEventResponseBodyRecurrencePattern()
            self.pattern = temp_model.from_map(m['pattern'])
        if m.get('range') is not None:
            temp_model = CreateEventResponseBodyRecurrenceRange()
            self.range = temp_model.from_map(m['range'])
        return self


class CreateEventResponseBodyReminders(TeaModel):
    def __init__(
        self,
        method: str = None,
        minutes: str = None,
    ):
        self.method = method
        self.minutes = minutes

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.method is not None:
            result['method'] = self.method
        if self.minutes is not None:
            result['minutes'] = self.minutes
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('method') is not None:
            self.method = m.get('method')
        if m.get('minutes') is not None:
            self.minutes = m.get('minutes')
        return self


class CreateEventResponseBodyRichTextDescription(TeaModel):
    def __init__(
        self,
        text: str = None,
    ):
        self.text = text

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.text is not None:
            result['text'] = self.text
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('text') is not None:
            self.text = m.get('text')
        return self


class CreateEventResponseBodyStart(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        self.date = date
        self.date_time = date_time
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class CreateEventResponseBodyUiConfigs(TeaModel):
    def __init__(
        self,
        ui_name: str = None,
        ui_status: str = None,
    ):
        self.ui_name = ui_name
        self.ui_status = ui_status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ui_name is not None:
            result['uiName'] = self.ui_name
        if self.ui_status is not None:
            result['uiStatus'] = self.ui_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('uiName') is not None:
            self.ui_name = m.get('uiName')
        if m.get('uiStatus') is not None:
            self.ui_status = m.get('uiStatus')
        return self


class CreateEventResponseBody(TeaModel):
    def __init__(
        self,
        attendees: List[CreateEventResponseBodyAttendees] = None,
        card_instances: List[CreateEventResponseBodyCardInstances] = None,
        create_time: str = None,
        description: str = None,
        end: CreateEventResponseBodyEnd = None,
        id: str = None,
        is_all_day: bool = None,
        location: CreateEventResponseBodyLocation = None,
        online_meeting_info: CreateEventResponseBodyOnlineMeetingInfo = None,
        organizer: CreateEventResponseBodyOrganizer = None,
        recurrence: CreateEventResponseBodyRecurrence = None,
        reminders: List[CreateEventResponseBodyReminders] = None,
        rich_text_description: CreateEventResponseBodyRichTextDescription = None,
        start: CreateEventResponseBodyStart = None,
        summary: str = None,
        ui_configs: List[CreateEventResponseBodyUiConfigs] = None,
        update_time: str = None,
    ):
        self.attendees = attendees
        self.card_instances = card_instances
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.create_time = create_time
        self.description = description
        self.end = end
        self.id = id
        self.is_all_day = is_all_day
        self.location = location
        self.online_meeting_info = online_meeting_info
        self.organizer = organizer
        self.recurrence = recurrence
        self.reminders = reminders
        self.rich_text_description = rich_text_description
        # This parameter is required.
        self.start = start
        self.summary = summary
        self.ui_configs = ui_configs
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.update_time = update_time

    def validate(self):
        if self.attendees:
            for k in self.attendees:
                if k:
                    k.validate()
        if self.card_instances:
            for k in self.card_instances:
                if k:
                    k.validate()
        if self.end:
            self.end.validate()
        if self.location:
            self.location.validate()
        if self.online_meeting_info:
            self.online_meeting_info.validate()
        if self.organizer:
            self.organizer.validate()
        if self.recurrence:
            self.recurrence.validate()
        if self.reminders:
            for k in self.reminders:
                if k:
                    k.validate()
        if self.rich_text_description:
            self.rich_text_description.validate()
        if self.start:
            self.start.validate()
        if self.ui_configs:
            for k in self.ui_configs:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['attendees'] = []
        if self.attendees is not None:
            for k in self.attendees:
                result['attendees'].append(k.to_map() if k else None)
        result['cardInstances'] = []
        if self.card_instances is not None:
            for k in self.card_instances:
                result['cardInstances'].append(k.to_map() if k else None)
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.description is not None:
            result['description'] = self.description
        if self.end is not None:
            result['end'] = self.end.to_map()
        if self.id is not None:
            result['id'] = self.id
        if self.is_all_day is not None:
            result['isAllDay'] = self.is_all_day
        if self.location is not None:
            result['location'] = self.location.to_map()
        if self.online_meeting_info is not None:
            result['onlineMeetingInfo'] = self.online_meeting_info.to_map()
        if self.organizer is not None:
            result['organizer'] = self.organizer.to_map()
        if self.recurrence is not None:
            result['recurrence'] = self.recurrence.to_map()
        result['reminders'] = []
        if self.reminders is not None:
            for k in self.reminders:
                result['reminders'].append(k.to_map() if k else None)
        if self.rich_text_description is not None:
            result['richTextDescription'] = self.rich_text_description.to_map()
        if self.start is not None:
            result['start'] = self.start.to_map()
        if self.summary is not None:
            result['summary'] = self.summary
        result['uiConfigs'] = []
        if self.ui_configs is not None:
            for k in self.ui_configs:
                result['uiConfigs'].append(k.to_map() if k else None)
        if self.update_time is not None:
            result['updateTime'] = self.update_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attendees = []
        if m.get('attendees') is not None:
            for k in m.get('attendees'):
                temp_model = CreateEventResponseBodyAttendees()
                self.attendees.append(temp_model.from_map(k))
        self.card_instances = []
        if m.get('cardInstances') is not None:
            for k in m.get('cardInstances'):
                temp_model = CreateEventResponseBodyCardInstances()
                self.card_instances.append(temp_model.from_map(k))
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('end') is not None:
            temp_model = CreateEventResponseBodyEnd()
            self.end = temp_model.from_map(m['end'])
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isAllDay') is not None:
            self.is_all_day = m.get('isAllDay')
        if m.get('location') is not None:
            temp_model = CreateEventResponseBodyLocation()
            self.location = temp_model.from_map(m['location'])
        if m.get('onlineMeetingInfo') is not None:
            temp_model = CreateEventResponseBodyOnlineMeetingInfo()
            self.online_meeting_info = temp_model.from_map(m['onlineMeetingInfo'])
        if m.get('organizer') is not None:
            temp_model = CreateEventResponseBodyOrganizer()
            self.organizer = temp_model.from_map(m['organizer'])
        if m.get('recurrence') is not None:
            temp_model = CreateEventResponseBodyRecurrence()
            self.recurrence = temp_model.from_map(m['recurrence'])
        self.reminders = []
        if m.get('reminders') is not None:
            for k in m.get('reminders'):
                temp_model = CreateEventResponseBodyReminders()
                self.reminders.append(temp_model.from_map(k))
        if m.get('richTextDescription') is not None:
            temp_model = CreateEventResponseBodyRichTextDescription()
            self.rich_text_description = temp_model.from_map(m['richTextDescription'])
        if m.get('start') is not None:
            temp_model = CreateEventResponseBodyStart()
            self.start = temp_model.from_map(m['start'])
        if m.get('summary') is not None:
            self.summary = m.get('summary')
        self.ui_configs = []
        if m.get('uiConfigs') is not None:
            for k in m.get('uiConfigs'):
                temp_model = CreateEventResponseBodyUiConfigs()
                self.ui_configs.append(temp_model.from_map(k))
        if m.get('updateTime') is not None:
            self.update_time = m.get('updateTime')
        return self


class CreateEventResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateEventResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = CreateEventResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateEventByMeHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_client_token: str = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_client_token = x_client_token
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
        if self.x_client_token is not None:
            result['x-client-token'] = self.x_client_token
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-client-token') is not None:
            self.x_client_token = m.get('x-client-token')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class CreateEventByMeRequestAttendees(TeaModel):
    def __init__(
        self,
        id: str = None,
        is_optional: bool = None,
    ):
        self.id = id
        self.is_optional = is_optional

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.is_optional is not None:
            result['isOptional'] = self.is_optional
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isOptional') is not None:
            self.is_optional = m.get('isOptional')
        return self


class CreateEventByMeRequestEnd(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        self.date = date
        self.date_time = date_time
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class CreateEventByMeRequestLocation(TeaModel):
    def __init__(
        self,
        display_name: str = None,
    ):
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        return self


class CreateEventByMeRequestOnlineMeetingInfo(TeaModel):
    def __init__(
        self,
        type: str = None,
    ):
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class CreateEventByMeRequestRecurrencePattern(TeaModel):
    def __init__(
        self,
        day_of_month: int = None,
        days_of_week: str = None,
        first_day_of_week: str = None,
        index: str = None,
        interval: int = None,
        type: str = None,
    ):
        self.day_of_month = day_of_month
        self.days_of_week = days_of_week
        self.first_day_of_week = first_day_of_week
        self.index = index
        self.interval = interval
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        if self.days_of_week is not None:
            result['daysOfWeek'] = self.days_of_week
        if self.first_day_of_week is not None:
            result['firstDayOfWeek'] = self.first_day_of_week
        if self.index is not None:
            result['index'] = self.index
        if self.interval is not None:
            result['interval'] = self.interval
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        if m.get('daysOfWeek') is not None:
            self.days_of_week = m.get('daysOfWeek')
        if m.get('firstDayOfWeek') is not None:
            self.first_day_of_week = m.get('firstDayOfWeek')
        if m.get('index') is not None:
            self.index = m.get('index')
        if m.get('interval') is not None:
            self.interval = m.get('interval')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class CreateEventByMeRequestRecurrenceRange(TeaModel):
    def __init__(
        self,
        end_date: str = None,
        number_of_occurrences: int = None,
        type: str = None,
    ):
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.end_date = end_date
        self.number_of_occurrences = number_of_occurrences
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.number_of_occurrences is not None:
            result['numberOfOccurrences'] = self.number_of_occurrences
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('numberOfOccurrences') is not None:
            self.number_of_occurrences = m.get('numberOfOccurrences')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class CreateEventByMeRequestRecurrence(TeaModel):
    def __init__(
        self,
        pattern: CreateEventByMeRequestRecurrencePattern = None,
        range: CreateEventByMeRequestRecurrenceRange = None,
    ):
        self.pattern = pattern
        self.range = range

    def validate(self):
        if self.pattern:
            self.pattern.validate()
        if self.range:
            self.range.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.pattern is not None:
            result['pattern'] = self.pattern.to_map()
        if self.range is not None:
            result['range'] = self.range.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pattern') is not None:
            temp_model = CreateEventByMeRequestRecurrencePattern()
            self.pattern = temp_model.from_map(m['pattern'])
        if m.get('range') is not None:
            temp_model = CreateEventByMeRequestRecurrenceRange()
            self.range = temp_model.from_map(m['range'])
        return self


class CreateEventByMeRequestReminders(TeaModel):
    def __init__(
        self,
        method: str = None,
        minutes: int = None,
    ):
        self.method = method
        self.minutes = minutes

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.method is not None:
            result['method'] = self.method
        if self.minutes is not None:
            result['minutes'] = self.minutes
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('method') is not None:
            self.method = m.get('method')
        if m.get('minutes') is not None:
            self.minutes = m.get('minutes')
        return self


class CreateEventByMeRequestRichTextDescription(TeaModel):
    def __init__(
        self,
        text: str = None,
    ):
        self.text = text

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.text is not None:
            result['text'] = self.text
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('text') is not None:
            self.text = m.get('text')
        return self


class CreateEventByMeRequestStart(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        self.date = date
        self.date_time = date_time
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class CreateEventByMeRequestUiConfigs(TeaModel):
    def __init__(
        self,
        ui_name: str = None,
        ui_status: str = None,
    ):
        self.ui_name = ui_name
        self.ui_status = ui_status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ui_name is not None:
            result['uiName'] = self.ui_name
        if self.ui_status is not None:
            result['uiStatus'] = self.ui_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('uiName') is not None:
            self.ui_name = m.get('uiName')
        if m.get('uiStatus') is not None:
            self.ui_status = m.get('uiStatus')
        return self


class CreateEventByMeRequest(TeaModel):
    def __init__(
        self,
        attendees: List[CreateEventByMeRequestAttendees] = None,
        description: str = None,
        end: CreateEventByMeRequestEnd = None,
        extra: Dict[str, str] = None,
        is_all_day: bool = None,
        location: CreateEventByMeRequestLocation = None,
        online_meeting_info: CreateEventByMeRequestOnlineMeetingInfo = None,
        recurrence: CreateEventByMeRequestRecurrence = None,
        reminders: List[CreateEventByMeRequestReminders] = None,
        rich_text_description: CreateEventByMeRequestRichTextDescription = None,
        start: CreateEventByMeRequestStart = None,
        summary: str = None,
        ui_configs: List[CreateEventByMeRequestUiConfigs] = None,
    ):
        self.attendees = attendees
        self.description = description
        self.end = end
        self.extra = extra
        self.is_all_day = is_all_day
        self.location = location
        self.online_meeting_info = online_meeting_info
        self.recurrence = recurrence
        self.reminders = reminders
        self.rich_text_description = rich_text_description
        # This parameter is required.
        self.start = start
        # This parameter is required.
        self.summary = summary
        self.ui_configs = ui_configs

    def validate(self):
        if self.attendees:
            for k in self.attendees:
                if k:
                    k.validate()
        if self.end:
            self.end.validate()
        if self.location:
            self.location.validate()
        if self.online_meeting_info:
            self.online_meeting_info.validate()
        if self.recurrence:
            self.recurrence.validate()
        if self.reminders:
            for k in self.reminders:
                if k:
                    k.validate()
        if self.rich_text_description:
            self.rich_text_description.validate()
        if self.start:
            self.start.validate()
        if self.ui_configs:
            for k in self.ui_configs:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['attendees'] = []
        if self.attendees is not None:
            for k in self.attendees:
                result['attendees'].append(k.to_map() if k else None)
        if self.description is not None:
            result['description'] = self.description
        if self.end is not None:
            result['end'] = self.end.to_map()
        if self.extra is not None:
            result['extra'] = self.extra
        if self.is_all_day is not None:
            result['isAllDay'] = self.is_all_day
        if self.location is not None:
            result['location'] = self.location.to_map()
        if self.online_meeting_info is not None:
            result['onlineMeetingInfo'] = self.online_meeting_info.to_map()
        if self.recurrence is not None:
            result['recurrence'] = self.recurrence.to_map()
        result['reminders'] = []
        if self.reminders is not None:
            for k in self.reminders:
                result['reminders'].append(k.to_map() if k else None)
        if self.rich_text_description is not None:
            result['richTextDescription'] = self.rich_text_description.to_map()
        if self.start is not None:
            result['start'] = self.start.to_map()
        if self.summary is not None:
            result['summary'] = self.summary
        result['uiConfigs'] = []
        if self.ui_configs is not None:
            for k in self.ui_configs:
                result['uiConfigs'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attendees = []
        if m.get('attendees') is not None:
            for k in m.get('attendees'):
                temp_model = CreateEventByMeRequestAttendees()
                self.attendees.append(temp_model.from_map(k))
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('end') is not None:
            temp_model = CreateEventByMeRequestEnd()
            self.end = temp_model.from_map(m['end'])
        if m.get('extra') is not None:
            self.extra = m.get('extra')
        if m.get('isAllDay') is not None:
            self.is_all_day = m.get('isAllDay')
        if m.get('location') is not None:
            temp_model = CreateEventByMeRequestLocation()
            self.location = temp_model.from_map(m['location'])
        if m.get('onlineMeetingInfo') is not None:
            temp_model = CreateEventByMeRequestOnlineMeetingInfo()
            self.online_meeting_info = temp_model.from_map(m['onlineMeetingInfo'])
        if m.get('recurrence') is not None:
            temp_model = CreateEventByMeRequestRecurrence()
            self.recurrence = temp_model.from_map(m['recurrence'])
        self.reminders = []
        if m.get('reminders') is not None:
            for k in m.get('reminders'):
                temp_model = CreateEventByMeRequestReminders()
                self.reminders.append(temp_model.from_map(k))
        if m.get('richTextDescription') is not None:
            temp_model = CreateEventByMeRequestRichTextDescription()
            self.rich_text_description = temp_model.from_map(m['richTextDescription'])
        if m.get('start') is not None:
            temp_model = CreateEventByMeRequestStart()
            self.start = temp_model.from_map(m['start'])
        if m.get('summary') is not None:
            self.summary = m.get('summary')
        self.ui_configs = []
        if m.get('uiConfigs') is not None:
            for k in m.get('uiConfigs'):
                temp_model = CreateEventByMeRequestUiConfigs()
                self.ui_configs.append(temp_model.from_map(k))
        return self


class CreateEventByMeResponseBodyAttendees(TeaModel):
    def __init__(
        self,
        display_name: str = None,
        id: str = None,
        is_optional: bool = None,
        response_status: str = None,
        self_: bool = None,
    ):
        self.display_name = display_name
        self.id = id
        self.is_optional = is_optional
        self.response_status = response_status
        self.self_ = self_

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.id is not None:
            result['id'] = self.id
        if self.is_optional is not None:
            result['isOptional'] = self.is_optional
        if self.response_status is not None:
            result['responseStatus'] = self.response_status
        if self.self_ is not None:
            result['self'] = self.self_
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isOptional') is not None:
            self.is_optional = m.get('isOptional')
        if m.get('responseStatus') is not None:
            self.response_status = m.get('responseStatus')
        if m.get('self') is not None:
            self.self_ = m.get('self')
        return self


class CreateEventByMeResponseBodyEnd(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        self.date = date
        self.date_time = date_time
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class CreateEventByMeResponseBodyLocation(TeaModel):
    def __init__(
        self,
        display_name: str = None,
    ):
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        return self


class CreateEventByMeResponseBodyOnlineMeetingInfo(TeaModel):
    def __init__(
        self,
        conference_id: str = None,
        extra_info: Dict[str, Any] = None,
        type: str = None,
        url: str = None,
    ):
        self.conference_id = conference_id
        self.extra_info = extra_info
        self.type = type
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conference_id is not None:
            result['conferenceId'] = self.conference_id
        if self.extra_info is not None:
            result['extraInfo'] = self.extra_info
        if self.type is not None:
            result['type'] = self.type
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conferenceId') is not None:
            self.conference_id = m.get('conferenceId')
        if m.get('extraInfo') is not None:
            self.extra_info = m.get('extraInfo')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class CreateEventByMeResponseBodyOrganizer(TeaModel):
    def __init__(
        self,
        display_name: str = None,
        id: str = None,
        response_status: str = None,
        self_: bool = None,
    ):
        self.display_name = display_name
        self.id = id
        self.response_status = response_status
        self.self_ = self_

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.id is not None:
            result['id'] = self.id
        if self.response_status is not None:
            result['responseStatus'] = self.response_status
        if self.self_ is not None:
            result['self'] = self.self_
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('responseStatus') is not None:
            self.response_status = m.get('responseStatus')
        if m.get('self') is not None:
            self.self_ = m.get('self')
        return self


class CreateEventByMeResponseBodyRecurrencePattern(TeaModel):
    def __init__(
        self,
        day_of_month: int = None,
        days_of_week: str = None,
        first_day_of_week: str = None,
        index: str = None,
        interval: int = None,
        type: str = None,
    ):
        self.day_of_month = day_of_month
        self.days_of_week = days_of_week
        self.first_day_of_week = first_day_of_week
        self.index = index
        self.interval = interval
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        if self.days_of_week is not None:
            result['daysOfWeek'] = self.days_of_week
        if self.first_day_of_week is not None:
            result['firstDayOfWeek'] = self.first_day_of_week
        if self.index is not None:
            result['index'] = self.index
        if self.interval is not None:
            result['interval'] = self.interval
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        if m.get('daysOfWeek') is not None:
            self.days_of_week = m.get('daysOfWeek')
        if m.get('firstDayOfWeek') is not None:
            self.first_day_of_week = m.get('firstDayOfWeek')
        if m.get('index') is not None:
            self.index = m.get('index')
        if m.get('interval') is not None:
            self.interval = m.get('interval')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class CreateEventByMeResponseBodyRecurrenceRange(TeaModel):
    def __init__(
        self,
        end_date: str = None,
        number_of_occurrences: int = None,
        type: str = None,
    ):
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.end_date = end_date
        self.number_of_occurrences = number_of_occurrences
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.number_of_occurrences is not None:
            result['numberOfOccurrences'] = self.number_of_occurrences
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('numberOfOccurrences') is not None:
            self.number_of_occurrences = m.get('numberOfOccurrences')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class CreateEventByMeResponseBodyRecurrence(TeaModel):
    def __init__(
        self,
        pattern: CreateEventByMeResponseBodyRecurrencePattern = None,
        range: CreateEventByMeResponseBodyRecurrenceRange = None,
    ):
        self.pattern = pattern
        self.range = range

    def validate(self):
        if self.pattern:
            self.pattern.validate()
        if self.range:
            self.range.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.pattern is not None:
            result['pattern'] = self.pattern.to_map()
        if self.range is not None:
            result['range'] = self.range.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pattern') is not None:
            temp_model = CreateEventByMeResponseBodyRecurrencePattern()
            self.pattern = temp_model.from_map(m['pattern'])
        if m.get('range') is not None:
            temp_model = CreateEventByMeResponseBodyRecurrenceRange()
            self.range = temp_model.from_map(m['range'])
        return self


class CreateEventByMeResponseBodyReminders(TeaModel):
    def __init__(
        self,
        method: str = None,
        minutes: str = None,
    ):
        self.method = method
        self.minutes = minutes

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.method is not None:
            result['method'] = self.method
        if self.minutes is not None:
            result['minutes'] = self.minutes
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('method') is not None:
            self.method = m.get('method')
        if m.get('minutes') is not None:
            self.minutes = m.get('minutes')
        return self


class CreateEventByMeResponseBodyRichTextDescription(TeaModel):
    def __init__(
        self,
        text: str = None,
    ):
        self.text = text

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.text is not None:
            result['text'] = self.text
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('text') is not None:
            self.text = m.get('text')
        return self


class CreateEventByMeResponseBodyStart(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        self.date = date
        self.date_time = date_time
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class CreateEventByMeResponseBodyUiConfigs(TeaModel):
    def __init__(
        self,
        ui_name: str = None,
        ui_status: str = None,
    ):
        self.ui_name = ui_name
        self.ui_status = ui_status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ui_name is not None:
            result['uiName'] = self.ui_name
        if self.ui_status is not None:
            result['uiStatus'] = self.ui_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('uiName') is not None:
            self.ui_name = m.get('uiName')
        if m.get('uiStatus') is not None:
            self.ui_status = m.get('uiStatus')
        return self


class CreateEventByMeResponseBody(TeaModel):
    def __init__(
        self,
        attendees: List[CreateEventByMeResponseBodyAttendees] = None,
        create_time: str = None,
        description: str = None,
        end: CreateEventByMeResponseBodyEnd = None,
        id: str = None,
        is_all_day: bool = None,
        location: CreateEventByMeResponseBodyLocation = None,
        online_meeting_info: CreateEventByMeResponseBodyOnlineMeetingInfo = None,
        organizer: CreateEventByMeResponseBodyOrganizer = None,
        recurrence: CreateEventByMeResponseBodyRecurrence = None,
        reminders: List[CreateEventByMeResponseBodyReminders] = None,
        rich_text_description: CreateEventByMeResponseBodyRichTextDescription = None,
        start: CreateEventByMeResponseBodyStart = None,
        summary: str = None,
        ui_configs: List[CreateEventByMeResponseBodyUiConfigs] = None,
        update_time: str = None,
    ):
        self.attendees = attendees
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.create_time = create_time
        self.description = description
        self.end = end
        self.id = id
        self.is_all_day = is_all_day
        self.location = location
        self.online_meeting_info = online_meeting_info
        self.organizer = organizer
        self.recurrence = recurrence
        self.reminders = reminders
        self.rich_text_description = rich_text_description
        # This parameter is required.
        self.start = start
        self.summary = summary
        self.ui_configs = ui_configs
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.update_time = update_time

    def validate(self):
        if self.attendees:
            for k in self.attendees:
                if k:
                    k.validate()
        if self.end:
            self.end.validate()
        if self.location:
            self.location.validate()
        if self.online_meeting_info:
            self.online_meeting_info.validate()
        if self.organizer:
            self.organizer.validate()
        if self.recurrence:
            self.recurrence.validate()
        if self.reminders:
            for k in self.reminders:
                if k:
                    k.validate()
        if self.rich_text_description:
            self.rich_text_description.validate()
        if self.start:
            self.start.validate()
        if self.ui_configs:
            for k in self.ui_configs:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['attendees'] = []
        if self.attendees is not None:
            for k in self.attendees:
                result['attendees'].append(k.to_map() if k else None)
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.description is not None:
            result['description'] = self.description
        if self.end is not None:
            result['end'] = self.end.to_map()
        if self.id is not None:
            result['id'] = self.id
        if self.is_all_day is not None:
            result['isAllDay'] = self.is_all_day
        if self.location is not None:
            result['location'] = self.location.to_map()
        if self.online_meeting_info is not None:
            result['onlineMeetingInfo'] = self.online_meeting_info.to_map()
        if self.organizer is not None:
            result['organizer'] = self.organizer.to_map()
        if self.recurrence is not None:
            result['recurrence'] = self.recurrence.to_map()
        result['reminders'] = []
        if self.reminders is not None:
            for k in self.reminders:
                result['reminders'].append(k.to_map() if k else None)
        if self.rich_text_description is not None:
            result['richTextDescription'] = self.rich_text_description.to_map()
        if self.start is not None:
            result['start'] = self.start.to_map()
        if self.summary is not None:
            result['summary'] = self.summary
        result['uiConfigs'] = []
        if self.ui_configs is not None:
            for k in self.ui_configs:
                result['uiConfigs'].append(k.to_map() if k else None)
        if self.update_time is not None:
            result['updateTime'] = self.update_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attendees = []
        if m.get('attendees') is not None:
            for k in m.get('attendees'):
                temp_model = CreateEventByMeResponseBodyAttendees()
                self.attendees.append(temp_model.from_map(k))
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('end') is not None:
            temp_model = CreateEventByMeResponseBodyEnd()
            self.end = temp_model.from_map(m['end'])
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isAllDay') is not None:
            self.is_all_day = m.get('isAllDay')
        if m.get('location') is not None:
            temp_model = CreateEventByMeResponseBodyLocation()
            self.location = temp_model.from_map(m['location'])
        if m.get('onlineMeetingInfo') is not None:
            temp_model = CreateEventByMeResponseBodyOnlineMeetingInfo()
            self.online_meeting_info = temp_model.from_map(m['onlineMeetingInfo'])
        if m.get('organizer') is not None:
            temp_model = CreateEventByMeResponseBodyOrganizer()
            self.organizer = temp_model.from_map(m['organizer'])
        if m.get('recurrence') is not None:
            temp_model = CreateEventByMeResponseBodyRecurrence()
            self.recurrence = temp_model.from_map(m['recurrence'])
        self.reminders = []
        if m.get('reminders') is not None:
            for k in m.get('reminders'):
                temp_model = CreateEventByMeResponseBodyReminders()
                self.reminders.append(temp_model.from_map(k))
        if m.get('richTextDescription') is not None:
            temp_model = CreateEventByMeResponseBodyRichTextDescription()
            self.rich_text_description = temp_model.from_map(m['richTextDescription'])
        if m.get('start') is not None:
            temp_model = CreateEventByMeResponseBodyStart()
            self.start = temp_model.from_map(m['start'])
        if m.get('summary') is not None:
            self.summary = m.get('summary')
        self.ui_configs = []
        if m.get('uiConfigs') is not None:
            for k in m.get('uiConfigs'):
                temp_model = CreateEventByMeResponseBodyUiConfigs()
                self.ui_configs.append(temp_model.from_map(k))
        if m.get('updateTime') is not None:
            self.update_time = m.get('updateTime')
        return self


class CreateEventByMeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateEventByMeResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = CreateEventByMeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateSubscribedCalendarHeaders(TeaModel):
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


class CreateSubscribedCalendarRequestSubscribeScope(TeaModel):
    def __init__(
        self,
        corp_ids: List[str] = None,
        open_conversation_ids: List[str] = None,
        union_ids: List[str] = None,
    ):
        self.corp_ids = corp_ids
        self.open_conversation_ids = open_conversation_ids
        self.union_ids = union_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_ids is not None:
            result['corpIds'] = self.corp_ids
        if self.open_conversation_ids is not None:
            result['openConversationIds'] = self.open_conversation_ids
        if self.union_ids is not None:
            result['unionIds'] = self.union_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpIds') is not None:
            self.corp_ids = m.get('corpIds')
        if m.get('openConversationIds') is not None:
            self.open_conversation_ids = m.get('openConversationIds')
        if m.get('unionIds') is not None:
            self.union_ids = m.get('unionIds')
        return self


class CreateSubscribedCalendarRequest(TeaModel):
    def __init__(
        self,
        description: str = None,
        managers: List[str] = None,
        name: str = None,
        subscribe_scope: CreateSubscribedCalendarRequestSubscribeScope = None,
    ):
        self.description = description
        self.managers = managers
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.subscribe_scope = subscribe_scope

    def validate(self):
        if self.subscribe_scope:
            self.subscribe_scope.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.description is not None:
            result['description'] = self.description
        if self.managers is not None:
            result['managers'] = self.managers
        if self.name is not None:
            result['name'] = self.name
        if self.subscribe_scope is not None:
            result['subscribeScope'] = self.subscribe_scope.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('managers') is not None:
            self.managers = m.get('managers')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('subscribeScope') is not None:
            temp_model = CreateSubscribedCalendarRequestSubscribeScope()
            self.subscribe_scope = temp_model.from_map(m['subscribeScope'])
        return self


class CreateSubscribedCalendarResponseBody(TeaModel):
    def __init__(
        self,
        calendar_id: str = None,
    ):
        self.calendar_id = calendar_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.calendar_id is not None:
            result['calendarId'] = self.calendar_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('calendarId') is not None:
            self.calendar_id = m.get('calendarId')
        return self


class CreateSubscribedCalendarResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateSubscribedCalendarResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = CreateSubscribedCalendarResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteAclHeaders(TeaModel):
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


class DeleteAclResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
    ):
        self.headers = headers
        self.status_code = status_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        return self


class DeleteEventHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_client_token: str = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_client_token = x_client_token
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
        if self.x_client_token is not None:
            result['x-client-token'] = self.x_client_token
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-client-token') is not None:
            self.x_client_token = m.get('x-client-token')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class DeleteEventRequest(TeaModel):
    def __init__(
        self,
        push_notification: bool = None,
    ):
        self.push_notification = push_notification

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.push_notification is not None:
            result['pushNotification'] = self.push_notification
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pushNotification') is not None:
            self.push_notification = m.get('pushNotification')
        return self


class DeleteEventResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
    ):
        self.headers = headers
        self.status_code = status_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        return self


class DeleteSubscribedCalendarHeaders(TeaModel):
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


class DeleteSubscribedCalendarResponseBody(TeaModel):
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


class DeleteSubscribedCalendarResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteSubscribedCalendarResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = DeleteSubscribedCalendarResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GenerateCaldavAccountHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        ding_uid: str = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.ding_uid = ding_uid
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
        if self.ding_uid is not None:
            result['dingUid'] = self.ding_uid
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('dingUid') is not None:
            self.ding_uid = m.get('dingUid')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GenerateCaldavAccountRequest(TeaModel):
    def __init__(
        self,
        device: str = None,
    ):
        # This parameter is required.
        self.device = device

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device is not None:
            result['device'] = self.device
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('device') is not None:
            self.device = m.get('device')
        return self


class GenerateCaldavAccountResponseBody(TeaModel):
    def __init__(
        self,
        password: str = None,
        server_address: str = None,
        username: str = None,
    ):
        self.password = password
        self.server_address = server_address
        self.username = username

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.password is not None:
            result['password'] = self.password
        if self.server_address is not None:
            result['serverAddress'] = self.server_address
        if self.username is not None:
            result['username'] = self.username
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('password') is not None:
            self.password = m.get('password')
        if m.get('serverAddress') is not None:
            self.server_address = m.get('serverAddress')
        if m.get('username') is not None:
            self.username = m.get('username')
        return self


class GenerateCaldavAccountResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GenerateCaldavAccountResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = GenerateCaldavAccountResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetEventHeaders(TeaModel):
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


class GetEventRequest(TeaModel):
    def __init__(
        self,
        max_attendees: int = None,
    ):
        self.max_attendees = max_attendees

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.max_attendees is not None:
            result['maxAttendees'] = self.max_attendees
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxAttendees') is not None:
            self.max_attendees = m.get('maxAttendees')
        return self


class GetEventResponseBodyAttendees(TeaModel):
    def __init__(
        self,
        display_name: str = None,
        id: str = None,
        is_optional: bool = None,
        response_status: str = None,
        self_: bool = None,
    ):
        self.display_name = display_name
        self.id = id
        self.is_optional = is_optional
        self.response_status = response_status
        self.self_ = self_

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.id is not None:
            result['id'] = self.id
        if self.is_optional is not None:
            result['isOptional'] = self.is_optional
        if self.response_status is not None:
            result['responseStatus'] = self.response_status
        if self.self_ is not None:
            result['self'] = self.self_
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isOptional') is not None:
            self.is_optional = m.get('isOptional')
        if m.get('responseStatus') is not None:
            self.response_status = m.get('responseStatus')
        if m.get('self') is not None:
            self.self_ = m.get('self')
        return self


class GetEventResponseBodyCardInstances(TeaModel):
    def __init__(
        self,
        out_track_id: str = None,
        scenario: str = None,
    ):
        self.out_track_id = out_track_id
        self.scenario = scenario

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.out_track_id is not None:
            result['outTrackId'] = self.out_track_id
        if self.scenario is not None:
            result['scenario'] = self.scenario
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('outTrackId') is not None:
            self.out_track_id = m.get('outTrackId')
        if m.get('scenario') is not None:
            self.scenario = m.get('scenario')
        return self


class GetEventResponseBodyCategories(TeaModel):
    def __init__(
        self,
        display_name: str = None,
    ):
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        return self


class GetEventResponseBodyEnd(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        self.date = date
        self.date_time = date_time
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class GetEventResponseBodyExtendedPropertiesSharedProperties(TeaModel):
    def __init__(
        self,
        belong_corp_id: str = None,
        source_open_cid: str = None,
    ):
        self.belong_corp_id = belong_corp_id
        self.source_open_cid = source_open_cid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.belong_corp_id is not None:
            result['belongCorpId'] = self.belong_corp_id
        if self.source_open_cid is not None:
            result['sourceOpenCid'] = self.source_open_cid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('belongCorpId') is not None:
            self.belong_corp_id = m.get('belongCorpId')
        if m.get('sourceOpenCid') is not None:
            self.source_open_cid = m.get('sourceOpenCid')
        return self


class GetEventResponseBodyExtendedProperties(TeaModel):
    def __init__(
        self,
        shared_properties: GetEventResponseBodyExtendedPropertiesSharedProperties = None,
    ):
        self.shared_properties = shared_properties

    def validate(self):
        if self.shared_properties:
            self.shared_properties.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.shared_properties is not None:
            result['sharedProperties'] = self.shared_properties.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sharedProperties') is not None:
            temp_model = GetEventResponseBodyExtendedPropertiesSharedProperties()
            self.shared_properties = temp_model.from_map(m['sharedProperties'])
        return self


class GetEventResponseBodyLocation(TeaModel):
    def __init__(
        self,
        display_name: str = None,
        meeting_rooms: List[str] = None,
    ):
        self.display_name = display_name
        self.meeting_rooms = meeting_rooms

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.meeting_rooms is not None:
            result['meetingRooms'] = self.meeting_rooms
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('meetingRooms') is not None:
            self.meeting_rooms = m.get('meetingRooms')
        return self


class GetEventResponseBodyMeetingRooms(TeaModel):
    def __init__(
        self,
        display_name: str = None,
        response_status: str = None,
        room_id: str = None,
    ):
        self.display_name = display_name
        self.response_status = response_status
        self.room_id = room_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.response_status is not None:
            result['responseStatus'] = self.response_status
        if self.room_id is not None:
            result['roomId'] = self.room_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('responseStatus') is not None:
            self.response_status = m.get('responseStatus')
        if m.get('roomId') is not None:
            self.room_id = m.get('roomId')
        return self


class GetEventResponseBodyOnlineMeetingInfo(TeaModel):
    def __init__(
        self,
        conference_id: str = None,
        extra_info: Dict[str, Any] = None,
        type: str = None,
        url: str = None,
    ):
        self.conference_id = conference_id
        self.extra_info = extra_info
        self.type = type
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conference_id is not None:
            result['conferenceId'] = self.conference_id
        if self.extra_info is not None:
            result['extraInfo'] = self.extra_info
        if self.type is not None:
            result['type'] = self.type
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conferenceId') is not None:
            self.conference_id = m.get('conferenceId')
        if m.get('extraInfo') is not None:
            self.extra_info = m.get('extraInfo')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class GetEventResponseBodyOrganizer(TeaModel):
    def __init__(
        self,
        display_name: str = None,
        id: str = None,
        response_status: str = None,
        self_: bool = None,
    ):
        self.display_name = display_name
        self.id = id
        self.response_status = response_status
        self.self_ = self_

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.id is not None:
            result['id'] = self.id
        if self.response_status is not None:
            result['responseStatus'] = self.response_status
        if self.self_ is not None:
            result['self'] = self.self_
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('responseStatus') is not None:
            self.response_status = m.get('responseStatus')
        if m.get('self') is not None:
            self.self_ = m.get('self')
        return self


class GetEventResponseBodyOriginStart(TeaModel):
    def __init__(
        self,
        date_time: str = None,
    ):
        self.date_time = date_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        return self


class GetEventResponseBodyRecurrencePattern(TeaModel):
    def __init__(
        self,
        day_of_month: int = None,
        days_of_week: str = None,
        first_day_of_week: str = None,
        index: str = None,
        interval: int = None,
        type: str = None,
    ):
        self.day_of_month = day_of_month
        self.days_of_week = days_of_week
        self.first_day_of_week = first_day_of_week
        self.index = index
        self.interval = interval
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        if self.days_of_week is not None:
            result['daysOfWeek'] = self.days_of_week
        if self.first_day_of_week is not None:
            result['firstDayOfWeek'] = self.first_day_of_week
        if self.index is not None:
            result['index'] = self.index
        if self.interval is not None:
            result['interval'] = self.interval
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        if m.get('daysOfWeek') is not None:
            self.days_of_week = m.get('daysOfWeek')
        if m.get('firstDayOfWeek') is not None:
            self.first_day_of_week = m.get('firstDayOfWeek')
        if m.get('index') is not None:
            self.index = m.get('index')
        if m.get('interval') is not None:
            self.interval = m.get('interval')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class GetEventResponseBodyRecurrenceRange(TeaModel):
    def __init__(
        self,
        end_date: str = None,
        number_of_occurrences: int = None,
        type: str = None,
    ):
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.end_date = end_date
        self.number_of_occurrences = number_of_occurrences
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.number_of_occurrences is not None:
            result['numberOfOccurrences'] = self.number_of_occurrences
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('numberOfOccurrences') is not None:
            self.number_of_occurrences = m.get('numberOfOccurrences')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class GetEventResponseBodyRecurrence(TeaModel):
    def __init__(
        self,
        pattern: GetEventResponseBodyRecurrencePattern = None,
        range: GetEventResponseBodyRecurrenceRange = None,
    ):
        self.pattern = pattern
        self.range = range

    def validate(self):
        if self.pattern:
            self.pattern.validate()
        if self.range:
            self.range.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.pattern is not None:
            result['pattern'] = self.pattern.to_map()
        if self.range is not None:
            result['range'] = self.range.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pattern') is not None:
            temp_model = GetEventResponseBodyRecurrencePattern()
            self.pattern = temp_model.from_map(m['pattern'])
        if m.get('range') is not None:
            temp_model = GetEventResponseBodyRecurrenceRange()
            self.range = temp_model.from_map(m['range'])
        return self


class GetEventResponseBodyReminders(TeaModel):
    def __init__(
        self,
        method: str = None,
        minutes: str = None,
    ):
        self.method = method
        self.minutes = minutes

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.method is not None:
            result['method'] = self.method
        if self.minutes is not None:
            result['minutes'] = self.minutes
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('method') is not None:
            self.method = m.get('method')
        if m.get('minutes') is not None:
            self.minutes = m.get('minutes')
        return self


class GetEventResponseBodyRichTextDescription(TeaModel):
    def __init__(
        self,
        text: str = None,
    ):
        self.text = text

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.text is not None:
            result['text'] = self.text
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('text') is not None:
            self.text = m.get('text')
        return self


class GetEventResponseBodyStart(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        self.date = date
        self.date_time = date_time
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class GetEventResponseBodyUiConfigs(TeaModel):
    def __init__(
        self,
        ui_name: str = None,
        ui_status: str = None,
    ):
        self.ui_name = ui_name
        self.ui_status = ui_status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ui_name is not None:
            result['uiName'] = self.ui_name
        if self.ui_status is not None:
            result['uiStatus'] = self.ui_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('uiName') is not None:
            self.ui_name = m.get('uiName')
        if m.get('uiStatus') is not None:
            self.ui_status = m.get('uiStatus')
        return self


class GetEventResponseBody(TeaModel):
    def __init__(
        self,
        attendees: List[GetEventResponseBodyAttendees] = None,
        card_instances: List[GetEventResponseBodyCardInstances] = None,
        categories: List[GetEventResponseBodyCategories] = None,
        create_time: str = None,
        description: str = None,
        end: GetEventResponseBodyEnd = None,
        extended_properties: GetEventResponseBodyExtendedProperties = None,
        id: str = None,
        is_all_day: bool = None,
        location: GetEventResponseBodyLocation = None,
        meeting_rooms: List[GetEventResponseBodyMeetingRooms] = None,
        online_meeting_info: GetEventResponseBodyOnlineMeetingInfo = None,
        organizer: GetEventResponseBodyOrganizer = None,
        origin_start: GetEventResponseBodyOriginStart = None,
        recurrence: GetEventResponseBodyRecurrence = None,
        reminders: List[GetEventResponseBodyReminders] = None,
        rich_text_description: GetEventResponseBodyRichTextDescription = None,
        series_master_id: str = None,
        start: GetEventResponseBodyStart = None,
        status: str = None,
        summary: str = None,
        ui_configs: List[GetEventResponseBodyUiConfigs] = None,
        update_time: str = None,
    ):
        self.attendees = attendees
        self.card_instances = card_instances
        self.categories = categories
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.create_time = create_time
        self.description = description
        self.end = end
        self.extended_properties = extended_properties
        self.id = id
        self.is_all_day = is_all_day
        self.location = location
        self.meeting_rooms = meeting_rooms
        self.online_meeting_info = online_meeting_info
        self.organizer = organizer
        self.origin_start = origin_start
        self.recurrence = recurrence
        self.reminders = reminders
        self.rich_text_description = rich_text_description
        self.series_master_id = series_master_id
        self.start = start
        # This parameter is required.
        self.status = status
        self.summary = summary
        self.ui_configs = ui_configs
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.update_time = update_time

    def validate(self):
        if self.attendees:
            for k in self.attendees:
                if k:
                    k.validate()
        if self.card_instances:
            for k in self.card_instances:
                if k:
                    k.validate()
        if self.categories:
            for k in self.categories:
                if k:
                    k.validate()
        if self.end:
            self.end.validate()
        if self.extended_properties:
            self.extended_properties.validate()
        if self.location:
            self.location.validate()
        if self.meeting_rooms:
            for k in self.meeting_rooms:
                if k:
                    k.validate()
        if self.online_meeting_info:
            self.online_meeting_info.validate()
        if self.organizer:
            self.organizer.validate()
        if self.origin_start:
            self.origin_start.validate()
        if self.recurrence:
            self.recurrence.validate()
        if self.reminders:
            for k in self.reminders:
                if k:
                    k.validate()
        if self.rich_text_description:
            self.rich_text_description.validate()
        if self.start:
            self.start.validate()
        if self.ui_configs:
            for k in self.ui_configs:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['attendees'] = []
        if self.attendees is not None:
            for k in self.attendees:
                result['attendees'].append(k.to_map() if k else None)
        result['cardInstances'] = []
        if self.card_instances is not None:
            for k in self.card_instances:
                result['cardInstances'].append(k.to_map() if k else None)
        result['categories'] = []
        if self.categories is not None:
            for k in self.categories:
                result['categories'].append(k.to_map() if k else None)
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.description is not None:
            result['description'] = self.description
        if self.end is not None:
            result['end'] = self.end.to_map()
        if self.extended_properties is not None:
            result['extendedProperties'] = self.extended_properties.to_map()
        if self.id is not None:
            result['id'] = self.id
        if self.is_all_day is not None:
            result['isAllDay'] = self.is_all_day
        if self.location is not None:
            result['location'] = self.location.to_map()
        result['meetingRooms'] = []
        if self.meeting_rooms is not None:
            for k in self.meeting_rooms:
                result['meetingRooms'].append(k.to_map() if k else None)
        if self.online_meeting_info is not None:
            result['onlineMeetingInfo'] = self.online_meeting_info.to_map()
        if self.organizer is not None:
            result['organizer'] = self.organizer.to_map()
        if self.origin_start is not None:
            result['originStart'] = self.origin_start.to_map()
        if self.recurrence is not None:
            result['recurrence'] = self.recurrence.to_map()
        result['reminders'] = []
        if self.reminders is not None:
            for k in self.reminders:
                result['reminders'].append(k.to_map() if k else None)
        if self.rich_text_description is not None:
            result['richTextDescription'] = self.rich_text_description.to_map()
        if self.series_master_id is not None:
            result['seriesMasterId'] = self.series_master_id
        if self.start is not None:
            result['start'] = self.start.to_map()
        if self.status is not None:
            result['status'] = self.status
        if self.summary is not None:
            result['summary'] = self.summary
        result['uiConfigs'] = []
        if self.ui_configs is not None:
            for k in self.ui_configs:
                result['uiConfigs'].append(k.to_map() if k else None)
        if self.update_time is not None:
            result['updateTime'] = self.update_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attendees = []
        if m.get('attendees') is not None:
            for k in m.get('attendees'):
                temp_model = GetEventResponseBodyAttendees()
                self.attendees.append(temp_model.from_map(k))
        self.card_instances = []
        if m.get('cardInstances') is not None:
            for k in m.get('cardInstances'):
                temp_model = GetEventResponseBodyCardInstances()
                self.card_instances.append(temp_model.from_map(k))
        self.categories = []
        if m.get('categories') is not None:
            for k in m.get('categories'):
                temp_model = GetEventResponseBodyCategories()
                self.categories.append(temp_model.from_map(k))
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('end') is not None:
            temp_model = GetEventResponseBodyEnd()
            self.end = temp_model.from_map(m['end'])
        if m.get('extendedProperties') is not None:
            temp_model = GetEventResponseBodyExtendedProperties()
            self.extended_properties = temp_model.from_map(m['extendedProperties'])
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isAllDay') is not None:
            self.is_all_day = m.get('isAllDay')
        if m.get('location') is not None:
            temp_model = GetEventResponseBodyLocation()
            self.location = temp_model.from_map(m['location'])
        self.meeting_rooms = []
        if m.get('meetingRooms') is not None:
            for k in m.get('meetingRooms'):
                temp_model = GetEventResponseBodyMeetingRooms()
                self.meeting_rooms.append(temp_model.from_map(k))
        if m.get('onlineMeetingInfo') is not None:
            temp_model = GetEventResponseBodyOnlineMeetingInfo()
            self.online_meeting_info = temp_model.from_map(m['onlineMeetingInfo'])
        if m.get('organizer') is not None:
            temp_model = GetEventResponseBodyOrganizer()
            self.organizer = temp_model.from_map(m['organizer'])
        if m.get('originStart') is not None:
            temp_model = GetEventResponseBodyOriginStart()
            self.origin_start = temp_model.from_map(m['originStart'])
        if m.get('recurrence') is not None:
            temp_model = GetEventResponseBodyRecurrence()
            self.recurrence = temp_model.from_map(m['recurrence'])
        self.reminders = []
        if m.get('reminders') is not None:
            for k in m.get('reminders'):
                temp_model = GetEventResponseBodyReminders()
                self.reminders.append(temp_model.from_map(k))
        if m.get('richTextDescription') is not None:
            temp_model = GetEventResponseBodyRichTextDescription()
            self.rich_text_description = temp_model.from_map(m['richTextDescription'])
        if m.get('seriesMasterId') is not None:
            self.series_master_id = m.get('seriesMasterId')
        if m.get('start') is not None:
            temp_model = GetEventResponseBodyStart()
            self.start = temp_model.from_map(m['start'])
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('summary') is not None:
            self.summary = m.get('summary')
        self.ui_configs = []
        if m.get('uiConfigs') is not None:
            for k in m.get('uiConfigs'):
                temp_model = GetEventResponseBodyUiConfigs()
                self.ui_configs.append(temp_model.from_map(k))
        if m.get('updateTime') is not None:
            self.update_time = m.get('updateTime')
        return self


class GetEventResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetEventResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = GetEventResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetMeetingRoomsScheduleHeaders(TeaModel):
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


class GetMeetingRoomsScheduleRequest(TeaModel):
    def __init__(
        self,
        end_time: str = None,
        room_ids: List[str] = None,
        start_time: str = None,
    ):
        # This parameter is required.
        # 
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.end_time = end_time
        # This parameter is required.
        self.room_ids = room_ids
        # This parameter is required.
        # 
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.start_time = start_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.room_ids is not None:
            result['roomIds'] = self.room_ids
        if self.start_time is not None:
            result['startTime'] = self.start_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('roomIds') is not None:
            self.room_ids = m.get('roomIds')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        return self


class GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsEnd(TeaModel):
    def __init__(
        self,
        date_time: str = None,
        time_zone: str = None,
    ):
        self.date_time = date_time
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsOrganizer(TeaModel):
    def __init__(
        self,
        id: str = None,
    ):
        self.id = id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        return self


class GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsStart(TeaModel):
    def __init__(
        self,
        date_time: str = None,
        time_zone: str = None,
    ):
        self.date_time = date_time
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItems(TeaModel):
    def __init__(
        self,
        end: GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsEnd = None,
        event_id: str = None,
        organizer: GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsOrganizer = None,
        start: GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsStart = None,
        status: str = None,
    ):
        self.end = end
        self.event_id = event_id
        self.organizer = organizer
        self.start = start
        self.status = status

    def validate(self):
        if self.end:
            self.end.validate()
        if self.organizer:
            self.organizer.validate()
        if self.start:
            self.start.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end is not None:
            result['end'] = self.end.to_map()
        if self.event_id is not None:
            result['eventId'] = self.event_id
        if self.organizer is not None:
            result['organizer'] = self.organizer.to_map()
        if self.start is not None:
            result['start'] = self.start.to_map()
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('end') is not None:
            temp_model = GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsEnd()
            self.end = temp_model.from_map(m['end'])
        if m.get('eventId') is not None:
            self.event_id = m.get('eventId')
        if m.get('organizer') is not None:
            temp_model = GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsOrganizer()
            self.organizer = temp_model.from_map(m['organizer'])
        if m.get('start') is not None:
            temp_model = GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsStart()
            self.start = temp_model.from_map(m['start'])
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class GetMeetingRoomsScheduleResponseBodyScheduleInformation(TeaModel):
    def __init__(
        self,
        error: str = None,
        room_id: str = None,
        schedule_items: List[GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItems] = None,
    ):
        self.error = error
        self.room_id = room_id
        self.schedule_items = schedule_items

    def validate(self):
        if self.schedule_items:
            for k in self.schedule_items:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.error is not None:
            result['error'] = self.error
        if self.room_id is not None:
            result['roomId'] = self.room_id
        result['scheduleItems'] = []
        if self.schedule_items is not None:
            for k in self.schedule_items:
                result['scheduleItems'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('error') is not None:
            self.error = m.get('error')
        if m.get('roomId') is not None:
            self.room_id = m.get('roomId')
        self.schedule_items = []
        if m.get('scheduleItems') is not None:
            for k in m.get('scheduleItems'):
                temp_model = GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItems()
                self.schedule_items.append(temp_model.from_map(k))
        return self


class GetMeetingRoomsScheduleResponseBody(TeaModel):
    def __init__(
        self,
        schedule_information: List[GetMeetingRoomsScheduleResponseBodyScheduleInformation] = None,
    ):
        self.schedule_information = schedule_information

    def validate(self):
        if self.schedule_information:
            for k in self.schedule_information:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['scheduleInformation'] = []
        if self.schedule_information is not None:
            for k in self.schedule_information:
                result['scheduleInformation'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.schedule_information = []
        if m.get('scheduleInformation') is not None:
            for k in m.get('scheduleInformation'):
                temp_model = GetMeetingRoomsScheduleResponseBodyScheduleInformation()
                self.schedule_information.append(temp_model.from_map(k))
        return self


class GetMeetingRoomsScheduleResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetMeetingRoomsScheduleResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = GetMeetingRoomsScheduleResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetScheduleHeaders(TeaModel):
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


class GetScheduleRequest(TeaModel):
    def __init__(
        self,
        end_time: str = None,
        start_time: str = None,
        user_ids: List[str] = None,
    ):
        # This parameter is required.
        # 
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.end_time = end_time
        # This parameter is required.
        # 
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.start_time = start_time
        # This parameter is required.
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class GetScheduleResponseBodyScheduleInformationScheduleItemsEnd(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        self.date = date
        self.date_time = date_time
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class GetScheduleResponseBodyScheduleInformationScheduleItemsStart(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        self.date = date
        self.date_time = date_time
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class GetScheduleResponseBodyScheduleInformationScheduleItems(TeaModel):
    def __init__(
        self,
        end: GetScheduleResponseBodyScheduleInformationScheduleItemsEnd = None,
        start: GetScheduleResponseBodyScheduleInformationScheduleItemsStart = None,
        status: str = None,
    ):
        self.end = end
        self.start = start
        self.status = status

    def validate(self):
        if self.end:
            self.end.validate()
        if self.start:
            self.start.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end is not None:
            result['end'] = self.end.to_map()
        if self.start is not None:
            result['start'] = self.start.to_map()
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('end') is not None:
            temp_model = GetScheduleResponseBodyScheduleInformationScheduleItemsEnd()
            self.end = temp_model.from_map(m['end'])
        if m.get('start') is not None:
            temp_model = GetScheduleResponseBodyScheduleInformationScheduleItemsStart()
            self.start = temp_model.from_map(m['start'])
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class GetScheduleResponseBodyScheduleInformation(TeaModel):
    def __init__(
        self,
        error: str = None,
        schedule_items: List[GetScheduleResponseBodyScheduleInformationScheduleItems] = None,
        user_id: str = None,
    ):
        self.error = error
        self.schedule_items = schedule_items
        self.user_id = user_id

    def validate(self):
        if self.schedule_items:
            for k in self.schedule_items:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.error is not None:
            result['error'] = self.error
        result['scheduleItems'] = []
        if self.schedule_items is not None:
            for k in self.schedule_items:
                result['scheduleItems'].append(k.to_map() if k else None)
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('error') is not None:
            self.error = m.get('error')
        self.schedule_items = []
        if m.get('scheduleItems') is not None:
            for k in m.get('scheduleItems'):
                temp_model = GetScheduleResponseBodyScheduleInformationScheduleItems()
                self.schedule_items.append(temp_model.from_map(k))
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetScheduleResponseBody(TeaModel):
    def __init__(
        self,
        schedule_information: List[GetScheduleResponseBodyScheduleInformation] = None,
    ):
        self.schedule_information = schedule_information

    def validate(self):
        if self.schedule_information:
            for k in self.schedule_information:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['scheduleInformation'] = []
        if self.schedule_information is not None:
            for k in self.schedule_information:
                result['scheduleInformation'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.schedule_information = []
        if m.get('scheduleInformation') is not None:
            for k in m.get('scheduleInformation'):
                temp_model = GetScheduleResponseBodyScheduleInformation()
                self.schedule_information.append(temp_model.from_map(k))
        return self


class GetScheduleResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetScheduleResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = GetScheduleResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetScheduleByMeHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_client_token: str = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_client_token = x_client_token
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
        if self.x_client_token is not None:
            result['x-client-token'] = self.x_client_token
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-client-token') is not None:
            self.x_client_token = m.get('x-client-token')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetScheduleByMeRequest(TeaModel):
    def __init__(
        self,
        end_time: str = None,
        start_time: str = None,
        user_ids: List[str] = None,
    ):
        # This parameter is required.
        self.end_time = end_time
        # This parameter is required.
        self.start_time = start_time
        # This parameter is required.
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class GetScheduleByMeResponseBodyScheduleInformationScheduleItemsEnd(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        self.date = date
        self.date_time = date_time
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class GetScheduleByMeResponseBodyScheduleInformationScheduleItemsStart(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        self.date = date
        self.date_time = date_time
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class GetScheduleByMeResponseBodyScheduleInformationScheduleItems(TeaModel):
    def __init__(
        self,
        end: GetScheduleByMeResponseBodyScheduleInformationScheduleItemsEnd = None,
        start: GetScheduleByMeResponseBodyScheduleInformationScheduleItemsStart = None,
        status: str = None,
    ):
        self.end = end
        self.start = start
        self.status = status

    def validate(self):
        if self.end:
            self.end.validate()
        if self.start:
            self.start.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end is not None:
            result['end'] = self.end.to_map()
        if self.start is not None:
            result['start'] = self.start.to_map()
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('end') is not None:
            temp_model = GetScheduleByMeResponseBodyScheduleInformationScheduleItemsEnd()
            self.end = temp_model.from_map(m['end'])
        if m.get('start') is not None:
            temp_model = GetScheduleByMeResponseBodyScheduleInformationScheduleItemsStart()
            self.start = temp_model.from_map(m['start'])
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class GetScheduleByMeResponseBodyScheduleInformation(TeaModel):
    def __init__(
        self,
        error: str = None,
        schedule_items: List[GetScheduleByMeResponseBodyScheduleInformationScheduleItems] = None,
        user_id: str = None,
    ):
        self.error = error
        self.schedule_items = schedule_items
        self.user_id = user_id

    def validate(self):
        if self.schedule_items:
            for k in self.schedule_items:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.error is not None:
            result['error'] = self.error
        result['scheduleItems'] = []
        if self.schedule_items is not None:
            for k in self.schedule_items:
                result['scheduleItems'].append(k.to_map() if k else None)
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('error') is not None:
            self.error = m.get('error')
        self.schedule_items = []
        if m.get('scheduleItems') is not None:
            for k in m.get('scheduleItems'):
                temp_model = GetScheduleByMeResponseBodyScheduleInformationScheduleItems()
                self.schedule_items.append(temp_model.from_map(k))
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetScheduleByMeResponseBody(TeaModel):
    def __init__(
        self,
        schedule_information: List[GetScheduleByMeResponseBodyScheduleInformation] = None,
    ):
        self.schedule_information = schedule_information

    def validate(self):
        if self.schedule_information:
            for k in self.schedule_information:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['scheduleInformation'] = []
        if self.schedule_information is not None:
            for k in self.schedule_information:
                result['scheduleInformation'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.schedule_information = []
        if m.get('scheduleInformation') is not None:
            for k in m.get('scheduleInformation'):
                temp_model = GetScheduleByMeResponseBodyScheduleInformation()
                self.schedule_information.append(temp_model.from_map(k))
        return self


class GetScheduleByMeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetScheduleByMeResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = GetScheduleByMeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetSignInLinkHeaders(TeaModel):
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


class GetSignInLinkResponseBody(TeaModel):
    def __init__(
        self,
        sign_in_link: str = None,
    ):
        self.sign_in_link = sign_in_link

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.sign_in_link is not None:
            result['signInLink'] = self.sign_in_link
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('signInLink') is not None:
            self.sign_in_link = m.get('signInLink')
        return self


class GetSignInLinkResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetSignInLinkResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = GetSignInLinkResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetSignInListHeaders(TeaModel):
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


class GetSignInListRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        type: str = None,
    ):
        # This parameter is required.
        self.max_results = max_results
        self.next_token = next_token
        # This parameter is required.
        self.type = type

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
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class GetSignInListResponseBodyUsers(TeaModel):
    def __init__(
        self,
        check_in_time: int = None,
        display_name: str = None,
        user_id: str = None,
    ):
        self.check_in_time = check_in_time
        self.display_name = display_name
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.check_in_time is not None:
            result['checkInTime'] = self.check_in_time
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('checkInTime') is not None:
            self.check_in_time = m.get('checkInTime')
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetSignInListResponseBody(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        users: List[GetSignInListResponseBodyUsers] = None,
    ):
        self.next_token = next_token
        self.users = users

    def validate(self):
        if self.users:
            for k in self.users:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['users'] = []
        if self.users is not None:
            for k in self.users:
                result['users'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.users = []
        if m.get('users') is not None:
            for k in m.get('users'):
                temp_model = GetSignInListResponseBodyUsers()
                self.users.append(temp_model.from_map(k))
        return self


class GetSignInListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetSignInListResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = GetSignInListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetSignOutLinkHeaders(TeaModel):
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


class GetSignOutLinkResponseBody(TeaModel):
    def __init__(
        self,
        sign_out_link: str = None,
    ):
        self.sign_out_link = sign_out_link

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.sign_out_link is not None:
            result['signOutLink'] = self.sign_out_link
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('signOutLink') is not None:
            self.sign_out_link = m.get('signOutLink')
        return self


class GetSignOutLinkResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetSignOutLinkResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = GetSignOutLinkResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetSignOutListHeaders(TeaModel):
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


class GetSignOutListRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        type: str = None,
    ):
        # This parameter is required.
        self.max_results = max_results
        self.next_token = next_token
        # This parameter is required.
        self.type = type

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
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class GetSignOutListResponseBodyUsers(TeaModel):
    def __init__(
        self,
        check_out_time: int = None,
        display_name: str = None,
        user_id: str = None,
    ):
        self.check_out_time = check_out_time
        self.display_name = display_name
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.check_out_time is not None:
            result['checkOutTime'] = self.check_out_time
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('checkOutTime') is not None:
            self.check_out_time = m.get('checkOutTime')
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetSignOutListResponseBody(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        users: List[GetSignOutListResponseBodyUsers] = None,
    ):
        self.next_token = next_token
        self.users = users

    def validate(self):
        if self.users:
            for k in self.users:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['users'] = []
        if self.users is not None:
            for k in self.users:
                result['users'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.users = []
        if m.get('users') is not None:
            for k in m.get('users'):
                temp_model = GetSignOutListResponseBodyUsers()
                self.users.append(temp_model.from_map(k))
        return self


class GetSignOutListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetSignOutListResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = GetSignOutListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetSubscribedCalendarHeaders(TeaModel):
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


class GetSubscribedCalendarResponseBodySubscribeScope(TeaModel):
    def __init__(
        self,
        corp_ids: List[str] = None,
        open_conversation_ids: List[str] = None,
        union_ids: List[str] = None,
    ):
        self.corp_ids = corp_ids
        self.open_conversation_ids = open_conversation_ids
        self.union_ids = union_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_ids is not None:
            result['corpIds'] = self.corp_ids
        if self.open_conversation_ids is not None:
            result['openConversationIds'] = self.open_conversation_ids
        if self.union_ids is not None:
            result['unionIds'] = self.union_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpIds') is not None:
            self.corp_ids = m.get('corpIds')
        if m.get('openConversationIds') is not None:
            self.open_conversation_ids = m.get('openConversationIds')
        if m.get('unionIds') is not None:
            self.union_ids = m.get('unionIds')
        return self


class GetSubscribedCalendarResponseBody(TeaModel):
    def __init__(
        self,
        author: str = None,
        calendar_id: str = None,
        description: str = None,
        managers: List[str] = None,
        name: str = None,
        subscribe_scope: GetSubscribedCalendarResponseBodySubscribeScope = None,
    ):
        self.author = author
        self.calendar_id = calendar_id
        self.description = description
        self.managers = managers
        self.name = name
        self.subscribe_scope = subscribe_scope

    def validate(self):
        if self.subscribe_scope:
            self.subscribe_scope.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.author is not None:
            result['author'] = self.author
        if self.calendar_id is not None:
            result['calendarId'] = self.calendar_id
        if self.description is not None:
            result['description'] = self.description
        if self.managers is not None:
            result['managers'] = self.managers
        if self.name is not None:
            result['name'] = self.name
        if self.subscribe_scope is not None:
            result['subscribeScope'] = self.subscribe_scope.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('author') is not None:
            self.author = m.get('author')
        if m.get('calendarId') is not None:
            self.calendar_id = m.get('calendarId')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('managers') is not None:
            self.managers = m.get('managers')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('subscribeScope') is not None:
            temp_model = GetSubscribedCalendarResponseBodySubscribeScope()
            self.subscribe_scope = temp_model.from_map(m['subscribeScope'])
        return self


class GetSubscribedCalendarResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetSubscribedCalendarResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = GetSubscribedCalendarResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListAclsHeaders(TeaModel):
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


class ListAclsResponseBodyAclsScope(TeaModel):
    def __init__(
        self,
        scope_type: str = None,
        user_id: str = None,
    ):
        self.scope_type = scope_type
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.scope_type is not None:
            result['scopeType'] = self.scope_type
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('scopeType') is not None:
            self.scope_type = m.get('scopeType')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class ListAclsResponseBodyAcls(TeaModel):
    def __init__(
        self,
        acl_id: str = None,
        privilege: str = None,
        scope: ListAclsResponseBodyAclsScope = None,
    ):
        self.acl_id = acl_id
        self.privilege = privilege
        self.scope = scope

    def validate(self):
        if self.scope:
            self.scope.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.acl_id is not None:
            result['aclId'] = self.acl_id
        if self.privilege is not None:
            result['privilege'] = self.privilege
        if self.scope is not None:
            result['scope'] = self.scope.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('aclId') is not None:
            self.acl_id = m.get('aclId')
        if m.get('privilege') is not None:
            self.privilege = m.get('privilege')
        if m.get('scope') is not None:
            temp_model = ListAclsResponseBodyAclsScope()
            self.scope = temp_model.from_map(m['scope'])
        return self


class ListAclsResponseBody(TeaModel):
    def __init__(
        self,
        acls: List[ListAclsResponseBodyAcls] = None,
    ):
        self.acls = acls

    def validate(self):
        if self.acls:
            for k in self.acls:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['acls'] = []
        if self.acls is not None:
            for k in self.acls:
                result['acls'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.acls = []
        if m.get('acls') is not None:
            for k in m.get('acls'):
                temp_model = ListAclsResponseBodyAcls()
                self.acls.append(temp_model.from_map(k))
        return self


class ListAclsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListAclsResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = ListAclsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListAttendeesHeaders(TeaModel):
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


class ListAttendeesRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
    ):
        self.max_results = max_results
        self.next_token = next_token

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class ListAttendeesResponseBodyAttendees(TeaModel):
    def __init__(
        self,
        display_name: str = None,
        id: str = None,
        is_optional: bool = None,
        response_status: str = None,
        self_: bool = None,
    ):
        self.display_name = display_name
        self.id = id
        self.is_optional = is_optional
        self.response_status = response_status
        self.self_ = self_

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.id is not None:
            result['id'] = self.id
        if self.is_optional is not None:
            result['isOptional'] = self.is_optional
        if self.response_status is not None:
            result['responseStatus'] = self.response_status
        if self.self_ is not None:
            result['self'] = self.self_
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isOptional') is not None:
            self.is_optional = m.get('isOptional')
        if m.get('responseStatus') is not None:
            self.response_status = m.get('responseStatus')
        if m.get('self') is not None:
            self.self_ = m.get('self')
        return self


class ListAttendeesResponseBody(TeaModel):
    def __init__(
        self,
        attendees: List[ListAttendeesResponseBodyAttendees] = None,
        next_token: str = None,
    ):
        self.attendees = attendees
        self.next_token = next_token

    def validate(self):
        if self.attendees:
            for k in self.attendees:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['attendees'] = []
        if self.attendees is not None:
            for k in self.attendees:
                result['attendees'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attendees = []
        if m.get('attendees') is not None:
            for k in m.get('attendees'):
                temp_model = ListAttendeesResponseBodyAttendees()
                self.attendees.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class ListAttendeesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListAttendeesResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = ListAttendeesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListCalendarsHeaders(TeaModel):
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


class ListCalendarsResponseBodyResponseCalendars(TeaModel):
    def __init__(
        self,
        description: str = None,
        e_tag: str = None,
        id: str = None,
        privilege: str = None,
        summary: str = None,
        time_zone: str = None,
        type: str = None,
    ):
        self.description = description
        # This parameter is required.
        self.e_tag = e_tag
        # This parameter is required.
        self.id = id
        # This parameter is required.
        self.privilege = privilege
        # This parameter is required.
        self.summary = summary
        self.time_zone = time_zone
        # This parameter is required.
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.description is not None:
            result['description'] = self.description
        if self.e_tag is not None:
            result['eTag'] = self.e_tag
        if self.id is not None:
            result['id'] = self.id
        if self.privilege is not None:
            result['privilege'] = self.privilege
        if self.summary is not None:
            result['summary'] = self.summary
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('eTag') is not None:
            self.e_tag = m.get('eTag')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('privilege') is not None:
            self.privilege = m.get('privilege')
        if m.get('summary') is not None:
            self.summary = m.get('summary')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class ListCalendarsResponseBodyResponse(TeaModel):
    def __init__(
        self,
        calendars: List[ListCalendarsResponseBodyResponseCalendars] = None,
    ):
        # This parameter is required.
        self.calendars = calendars

    def validate(self):
        if self.calendars:
            for k in self.calendars:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['calendars'] = []
        if self.calendars is not None:
            for k in self.calendars:
                result['calendars'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.calendars = []
        if m.get('calendars') is not None:
            for k in m.get('calendars'):
                temp_model = ListCalendarsResponseBodyResponseCalendars()
                self.calendars.append(temp_model.from_map(k))
        return self


class ListCalendarsResponseBody(TeaModel):
    def __init__(
        self,
        response: ListCalendarsResponseBodyResponse = None,
    ):
        self.response = response

    def validate(self):
        if self.response:
            self.response.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.response is not None:
            result['response'] = self.response.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('response') is not None:
            temp_model = ListCalendarsResponseBodyResponse()
            self.response = temp_model.from_map(m['response'])
        return self


class ListCalendarsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListCalendarsResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = ListCalendarsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListEventsHeaders(TeaModel):
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


class ListEventsRequest(TeaModel):
    def __init__(
        self,
        max_attendees: int = None,
        max_results: int = None,
        next_token: str = None,
        series_master_id: str = None,
        show_deleted: bool = None,
        sync_token: str = None,
        time_max: str = None,
        time_min: str = None,
    ):
        self.max_attendees = max_attendees
        self.max_results = max_results
        self.next_token = next_token
        self.series_master_id = series_master_id
        self.show_deleted = show_deleted
        self.sync_token = sync_token
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.time_max = time_max
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.time_min = time_min

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.max_attendees is not None:
            result['maxAttendees'] = self.max_attendees
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.series_master_id is not None:
            result['seriesMasterId'] = self.series_master_id
        if self.show_deleted is not None:
            result['showDeleted'] = self.show_deleted
        if self.sync_token is not None:
            result['syncToken'] = self.sync_token
        if self.time_max is not None:
            result['timeMax'] = self.time_max
        if self.time_min is not None:
            result['timeMin'] = self.time_min
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxAttendees') is not None:
            self.max_attendees = m.get('maxAttendees')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('seriesMasterId') is not None:
            self.series_master_id = m.get('seriesMasterId')
        if m.get('showDeleted') is not None:
            self.show_deleted = m.get('showDeleted')
        if m.get('syncToken') is not None:
            self.sync_token = m.get('syncToken')
        if m.get('timeMax') is not None:
            self.time_max = m.get('timeMax')
        if m.get('timeMin') is not None:
            self.time_min = m.get('timeMin')
        return self


class ListEventsResponseBodyEventsAttendees(TeaModel):
    def __init__(
        self,
        display_name: str = None,
        id: str = None,
        is_optional: bool = None,
        response_status: str = None,
        self_: bool = None,
    ):
        self.display_name = display_name
        self.id = id
        self.is_optional = is_optional
        self.response_status = response_status
        self.self_ = self_

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.id is not None:
            result['id'] = self.id
        if self.is_optional is not None:
            result['isOptional'] = self.is_optional
        if self.response_status is not None:
            result['responseStatus'] = self.response_status
        if self.self_ is not None:
            result['self'] = self.self_
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isOptional') is not None:
            self.is_optional = m.get('isOptional')
        if m.get('responseStatus') is not None:
            self.response_status = m.get('responseStatus')
        if m.get('self') is not None:
            self.self_ = m.get('self')
        return self


class ListEventsResponseBodyEventsCategories(TeaModel):
    def __init__(
        self,
        display_name: str = None,
    ):
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        return self


class ListEventsResponseBodyEventsEnd(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        self.date = date
        self.date_time = date_time
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class ListEventsResponseBodyEventsExtendedPropertiesSharedProperties(TeaModel):
    def __init__(
        self,
        belong_corp_id: str = None,
        source_open_cid: str = None,
    ):
        self.belong_corp_id = belong_corp_id
        self.source_open_cid = source_open_cid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.belong_corp_id is not None:
            result['belongCorpId'] = self.belong_corp_id
        if self.source_open_cid is not None:
            result['sourceOpenCid'] = self.source_open_cid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('belongCorpId') is not None:
            self.belong_corp_id = m.get('belongCorpId')
        if m.get('sourceOpenCid') is not None:
            self.source_open_cid = m.get('sourceOpenCid')
        return self


class ListEventsResponseBodyEventsExtendedProperties(TeaModel):
    def __init__(
        self,
        shared_properties: ListEventsResponseBodyEventsExtendedPropertiesSharedProperties = None,
    ):
        self.shared_properties = shared_properties

    def validate(self):
        if self.shared_properties:
            self.shared_properties.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.shared_properties is not None:
            result['sharedProperties'] = self.shared_properties.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sharedProperties') is not None:
            temp_model = ListEventsResponseBodyEventsExtendedPropertiesSharedProperties()
            self.shared_properties = temp_model.from_map(m['sharedProperties'])
        return self


class ListEventsResponseBodyEventsLocation(TeaModel):
    def __init__(
        self,
        display_name: str = None,
        meeting_rooms: List[str] = None,
    ):
        self.display_name = display_name
        self.meeting_rooms = meeting_rooms

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.meeting_rooms is not None:
            result['meetingRooms'] = self.meeting_rooms
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('meetingRooms') is not None:
            self.meeting_rooms = m.get('meetingRooms')
        return self


class ListEventsResponseBodyEventsMeetingRooms(TeaModel):
    def __init__(
        self,
        display_name: str = None,
        response_status: str = None,
        room_id: str = None,
    ):
        self.display_name = display_name
        self.response_status = response_status
        self.room_id = room_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.response_status is not None:
            result['responseStatus'] = self.response_status
        if self.room_id is not None:
            result['roomId'] = self.room_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('responseStatus') is not None:
            self.response_status = m.get('responseStatus')
        if m.get('roomId') is not None:
            self.room_id = m.get('roomId')
        return self


class ListEventsResponseBodyEventsOnlineMeetingInfo(TeaModel):
    def __init__(
        self,
        conference_id: str = None,
        extra_info: Dict[str, Any] = None,
        type: str = None,
        url: str = None,
    ):
        self.conference_id = conference_id
        self.extra_info = extra_info
        self.type = type
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conference_id is not None:
            result['conferenceId'] = self.conference_id
        if self.extra_info is not None:
            result['extraInfo'] = self.extra_info
        if self.type is not None:
            result['type'] = self.type
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conferenceId') is not None:
            self.conference_id = m.get('conferenceId')
        if m.get('extraInfo') is not None:
            self.extra_info = m.get('extraInfo')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class ListEventsResponseBodyEventsOrganizer(TeaModel):
    def __init__(
        self,
        display_name: str = None,
        id: str = None,
        response_status: str = None,
        self_: bool = None,
    ):
        self.display_name = display_name
        self.id = id
        self.response_status = response_status
        self.self_ = self_

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.id is not None:
            result['id'] = self.id
        if self.response_status is not None:
            result['responseStatus'] = self.response_status
        if self.self_ is not None:
            result['self'] = self.self_
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('responseStatus') is not None:
            self.response_status = m.get('responseStatus')
        if m.get('self') is not None:
            self.self_ = m.get('self')
        return self


class ListEventsResponseBodyEventsOriginStart(TeaModel):
    def __init__(
        self,
        date_time: str = None,
    ):
        self.date_time = date_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        return self


class ListEventsResponseBodyEventsRecurrencePattern(TeaModel):
    def __init__(
        self,
        day_of_month: int = None,
        days_of_week: str = None,
        first_day_of_week: str = None,
        index: str = None,
        interval: int = None,
        type: str = None,
    ):
        self.day_of_month = day_of_month
        self.days_of_week = days_of_week
        self.first_day_of_week = first_day_of_week
        self.index = index
        self.interval = interval
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        if self.days_of_week is not None:
            result['daysOfWeek'] = self.days_of_week
        if self.first_day_of_week is not None:
            result['firstDayOfWeek'] = self.first_day_of_week
        if self.index is not None:
            result['index'] = self.index
        if self.interval is not None:
            result['interval'] = self.interval
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        if m.get('daysOfWeek') is not None:
            self.days_of_week = m.get('daysOfWeek')
        if m.get('firstDayOfWeek') is not None:
            self.first_day_of_week = m.get('firstDayOfWeek')
        if m.get('index') is not None:
            self.index = m.get('index')
        if m.get('interval') is not None:
            self.interval = m.get('interval')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class ListEventsResponseBodyEventsRecurrenceRange(TeaModel):
    def __init__(
        self,
        end_date: str = None,
        number_of_occurrences: int = None,
        type: str = None,
    ):
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.end_date = end_date
        self.number_of_occurrences = number_of_occurrences
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.number_of_occurrences is not None:
            result['numberOfOccurrences'] = self.number_of_occurrences
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('numberOfOccurrences') is not None:
            self.number_of_occurrences = m.get('numberOfOccurrences')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class ListEventsResponseBodyEventsRecurrence(TeaModel):
    def __init__(
        self,
        pattern: ListEventsResponseBodyEventsRecurrencePattern = None,
        range: ListEventsResponseBodyEventsRecurrenceRange = None,
    ):
        self.pattern = pattern
        self.range = range

    def validate(self):
        if self.pattern:
            self.pattern.validate()
        if self.range:
            self.range.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.pattern is not None:
            result['pattern'] = self.pattern.to_map()
        if self.range is not None:
            result['range'] = self.range.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pattern') is not None:
            temp_model = ListEventsResponseBodyEventsRecurrencePattern()
            self.pattern = temp_model.from_map(m['pattern'])
        if m.get('range') is not None:
            temp_model = ListEventsResponseBodyEventsRecurrenceRange()
            self.range = temp_model.from_map(m['range'])
        return self


class ListEventsResponseBodyEventsReminders(TeaModel):
    def __init__(
        self,
        method: str = None,
        minutes: str = None,
    ):
        self.method = method
        self.minutes = minutes

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.method is not None:
            result['method'] = self.method
        if self.minutes is not None:
            result['minutes'] = self.minutes
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('method') is not None:
            self.method = m.get('method')
        if m.get('minutes') is not None:
            self.minutes = m.get('minutes')
        return self


class ListEventsResponseBodyEventsRichTextDescription(TeaModel):
    def __init__(
        self,
        text: str = None,
    ):
        self.text = text

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.text is not None:
            result['text'] = self.text
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('text') is not None:
            self.text = m.get('text')
        return self


class ListEventsResponseBodyEventsStart(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        self.date = date
        self.date_time = date_time
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class ListEventsResponseBodyEvents(TeaModel):
    def __init__(
        self,
        attendees: List[ListEventsResponseBodyEventsAttendees] = None,
        categories: List[ListEventsResponseBodyEventsCategories] = None,
        create_time: str = None,
        description: str = None,
        end: ListEventsResponseBodyEventsEnd = None,
        extended_properties: ListEventsResponseBodyEventsExtendedProperties = None,
        id: str = None,
        is_all_day: bool = None,
        location: ListEventsResponseBodyEventsLocation = None,
        meeting_rooms: List[ListEventsResponseBodyEventsMeetingRooms] = None,
        online_meeting_info: ListEventsResponseBodyEventsOnlineMeetingInfo = None,
        organizer: ListEventsResponseBodyEventsOrganizer = None,
        origin_start: ListEventsResponseBodyEventsOriginStart = None,
        recurrence: ListEventsResponseBodyEventsRecurrence = None,
        reminders: List[ListEventsResponseBodyEventsReminders] = None,
        rich_text_description: ListEventsResponseBodyEventsRichTextDescription = None,
        series_master_id: str = None,
        start: ListEventsResponseBodyEventsStart = None,
        status: str = None,
        summary: str = None,
        update_time: str = None,
    ):
        self.attendees = attendees
        self.categories = categories
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.create_time = create_time
        self.description = description
        self.end = end
        self.extended_properties = extended_properties
        self.id = id
        self.is_all_day = is_all_day
        self.location = location
        self.meeting_rooms = meeting_rooms
        self.online_meeting_info = online_meeting_info
        self.organizer = organizer
        self.origin_start = origin_start
        self.recurrence = recurrence
        self.reminders = reminders
        self.rich_text_description = rich_text_description
        self.series_master_id = series_master_id
        self.start = start
        self.status = status
        self.summary = summary
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.update_time = update_time

    def validate(self):
        if self.attendees:
            for k in self.attendees:
                if k:
                    k.validate()
        if self.categories:
            for k in self.categories:
                if k:
                    k.validate()
        if self.end:
            self.end.validate()
        if self.extended_properties:
            self.extended_properties.validate()
        if self.location:
            self.location.validate()
        if self.meeting_rooms:
            for k in self.meeting_rooms:
                if k:
                    k.validate()
        if self.online_meeting_info:
            self.online_meeting_info.validate()
        if self.organizer:
            self.organizer.validate()
        if self.origin_start:
            self.origin_start.validate()
        if self.recurrence:
            self.recurrence.validate()
        if self.reminders:
            for k in self.reminders:
                if k:
                    k.validate()
        if self.rich_text_description:
            self.rich_text_description.validate()
        if self.start:
            self.start.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['attendees'] = []
        if self.attendees is not None:
            for k in self.attendees:
                result['attendees'].append(k.to_map() if k else None)
        result['categories'] = []
        if self.categories is not None:
            for k in self.categories:
                result['categories'].append(k.to_map() if k else None)
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.description is not None:
            result['description'] = self.description
        if self.end is not None:
            result['end'] = self.end.to_map()
        if self.extended_properties is not None:
            result['extendedProperties'] = self.extended_properties.to_map()
        if self.id is not None:
            result['id'] = self.id
        if self.is_all_day is not None:
            result['isAllDay'] = self.is_all_day
        if self.location is not None:
            result['location'] = self.location.to_map()
        result['meetingRooms'] = []
        if self.meeting_rooms is not None:
            for k in self.meeting_rooms:
                result['meetingRooms'].append(k.to_map() if k else None)
        if self.online_meeting_info is not None:
            result['onlineMeetingInfo'] = self.online_meeting_info.to_map()
        if self.organizer is not None:
            result['organizer'] = self.organizer.to_map()
        if self.origin_start is not None:
            result['originStart'] = self.origin_start.to_map()
        if self.recurrence is not None:
            result['recurrence'] = self.recurrence.to_map()
        result['reminders'] = []
        if self.reminders is not None:
            for k in self.reminders:
                result['reminders'].append(k.to_map() if k else None)
        if self.rich_text_description is not None:
            result['richTextDescription'] = self.rich_text_description.to_map()
        if self.series_master_id is not None:
            result['seriesMasterId'] = self.series_master_id
        if self.start is not None:
            result['start'] = self.start.to_map()
        if self.status is not None:
            result['status'] = self.status
        if self.summary is not None:
            result['summary'] = self.summary
        if self.update_time is not None:
            result['updateTime'] = self.update_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attendees = []
        if m.get('attendees') is not None:
            for k in m.get('attendees'):
                temp_model = ListEventsResponseBodyEventsAttendees()
                self.attendees.append(temp_model.from_map(k))
        self.categories = []
        if m.get('categories') is not None:
            for k in m.get('categories'):
                temp_model = ListEventsResponseBodyEventsCategories()
                self.categories.append(temp_model.from_map(k))
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('end') is not None:
            temp_model = ListEventsResponseBodyEventsEnd()
            self.end = temp_model.from_map(m['end'])
        if m.get('extendedProperties') is not None:
            temp_model = ListEventsResponseBodyEventsExtendedProperties()
            self.extended_properties = temp_model.from_map(m['extendedProperties'])
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isAllDay') is not None:
            self.is_all_day = m.get('isAllDay')
        if m.get('location') is not None:
            temp_model = ListEventsResponseBodyEventsLocation()
            self.location = temp_model.from_map(m['location'])
        self.meeting_rooms = []
        if m.get('meetingRooms') is not None:
            for k in m.get('meetingRooms'):
                temp_model = ListEventsResponseBodyEventsMeetingRooms()
                self.meeting_rooms.append(temp_model.from_map(k))
        if m.get('onlineMeetingInfo') is not None:
            temp_model = ListEventsResponseBodyEventsOnlineMeetingInfo()
            self.online_meeting_info = temp_model.from_map(m['onlineMeetingInfo'])
        if m.get('organizer') is not None:
            temp_model = ListEventsResponseBodyEventsOrganizer()
            self.organizer = temp_model.from_map(m['organizer'])
        if m.get('originStart') is not None:
            temp_model = ListEventsResponseBodyEventsOriginStart()
            self.origin_start = temp_model.from_map(m['originStart'])
        if m.get('recurrence') is not None:
            temp_model = ListEventsResponseBodyEventsRecurrence()
            self.recurrence = temp_model.from_map(m['recurrence'])
        self.reminders = []
        if m.get('reminders') is not None:
            for k in m.get('reminders'):
                temp_model = ListEventsResponseBodyEventsReminders()
                self.reminders.append(temp_model.from_map(k))
        if m.get('richTextDescription') is not None:
            temp_model = ListEventsResponseBodyEventsRichTextDescription()
            self.rich_text_description = temp_model.from_map(m['richTextDescription'])
        if m.get('seriesMasterId') is not None:
            self.series_master_id = m.get('seriesMasterId')
        if m.get('start') is not None:
            temp_model = ListEventsResponseBodyEventsStart()
            self.start = temp_model.from_map(m['start'])
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('summary') is not None:
            self.summary = m.get('summary')
        if m.get('updateTime') is not None:
            self.update_time = m.get('updateTime')
        return self


class ListEventsResponseBody(TeaModel):
    def __init__(
        self,
        events: List[ListEventsResponseBodyEvents] = None,
        next_token: str = None,
        sync_token: str = None,
    ):
        self.events = events
        self.next_token = next_token
        self.sync_token = sync_token

    def validate(self):
        if self.events:
            for k in self.events:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['events'] = []
        if self.events is not None:
            for k in self.events:
                result['events'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.sync_token is not None:
            result['syncToken'] = self.sync_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.events = []
        if m.get('events') is not None:
            for k in m.get('events'):
                temp_model = ListEventsResponseBodyEvents()
                self.events.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('syncToken') is not None:
            self.sync_token = m.get('syncToken')
        return self


class ListEventsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListEventsResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = ListEventsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListEventsInstancesHeaders(TeaModel):
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


class ListEventsInstancesRequest(TeaModel):
    def __init__(
        self,
        max_attendees: int = None,
        max_results: int = None,
        series_master_id: str = None,
        start_recurrence_id: str = None,
    ):
        self.max_attendees = max_attendees
        self.max_results = max_results
        # This parameter is required.
        self.series_master_id = series_master_id
        self.start_recurrence_id = start_recurrence_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.max_attendees is not None:
            result['maxAttendees'] = self.max_attendees
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.series_master_id is not None:
            result['seriesMasterId'] = self.series_master_id
        if self.start_recurrence_id is not None:
            result['startRecurrenceId'] = self.start_recurrence_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxAttendees') is not None:
            self.max_attendees = m.get('maxAttendees')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('seriesMasterId') is not None:
            self.series_master_id = m.get('seriesMasterId')
        if m.get('startRecurrenceId') is not None:
            self.start_recurrence_id = m.get('startRecurrenceId')
        return self


class ListEventsInstancesResponseBodyEventsAttendees(TeaModel):
    def __init__(
        self,
        display_name: str = None,
        id: str = None,
        is_optional: bool = None,
        response_status: str = None,
        self_: bool = None,
    ):
        self.display_name = display_name
        self.id = id
        self.is_optional = is_optional
        self.response_status = response_status
        self.self_ = self_

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.id is not None:
            result['id'] = self.id
        if self.is_optional is not None:
            result['isOptional'] = self.is_optional
        if self.response_status is not None:
            result['responseStatus'] = self.response_status
        if self.self_ is not None:
            result['self'] = self.self_
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isOptional') is not None:
            self.is_optional = m.get('isOptional')
        if m.get('responseStatus') is not None:
            self.response_status = m.get('responseStatus')
        if m.get('self') is not None:
            self.self_ = m.get('self')
        return self


class ListEventsInstancesResponseBodyEventsEnd(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        self.date = date
        self.date_time = date_time
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class ListEventsInstancesResponseBodyEventsExtendedPropertiesSharedProperties(TeaModel):
    def __init__(
        self,
        source_open_cid: str = None,
    ):
        self.source_open_cid = source_open_cid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.source_open_cid is not None:
            result['sourceOpenCid'] = self.source_open_cid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sourceOpenCid') is not None:
            self.source_open_cid = m.get('sourceOpenCid')
        return self


class ListEventsInstancesResponseBodyEventsExtendedProperties(TeaModel):
    def __init__(
        self,
        shared_properties: ListEventsInstancesResponseBodyEventsExtendedPropertiesSharedProperties = None,
    ):
        self.shared_properties = shared_properties

    def validate(self):
        if self.shared_properties:
            self.shared_properties.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.shared_properties is not None:
            result['sharedProperties'] = self.shared_properties.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sharedProperties') is not None:
            temp_model = ListEventsInstancesResponseBodyEventsExtendedPropertiesSharedProperties()
            self.shared_properties = temp_model.from_map(m['sharedProperties'])
        return self


class ListEventsInstancesResponseBodyEventsLocation(TeaModel):
    def __init__(
        self,
        display_name: str = None,
        meeting_rooms: List[str] = None,
    ):
        self.display_name = display_name
        self.meeting_rooms = meeting_rooms

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.meeting_rooms is not None:
            result['meetingRooms'] = self.meeting_rooms
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('meetingRooms') is not None:
            self.meeting_rooms = m.get('meetingRooms')
        return self


class ListEventsInstancesResponseBodyEventsOnlineMeetingInfo(TeaModel):
    def __init__(
        self,
        conference_id: str = None,
        type: str = None,
        url: str = None,
    ):
        self.conference_id = conference_id
        self.type = type
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conference_id is not None:
            result['conferenceId'] = self.conference_id
        if self.type is not None:
            result['type'] = self.type
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conferenceId') is not None:
            self.conference_id = m.get('conferenceId')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class ListEventsInstancesResponseBodyEventsOrganizer(TeaModel):
    def __init__(
        self,
        display_name: str = None,
        id: str = None,
        response_status: str = None,
        self_: bool = None,
    ):
        self.display_name = display_name
        self.id = id
        self.response_status = response_status
        self.self_ = self_

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.id is not None:
            result['id'] = self.id
        if self.response_status is not None:
            result['responseStatus'] = self.response_status
        if self.self_ is not None:
            result['self'] = self.self_
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('responseStatus') is not None:
            self.response_status = m.get('responseStatus')
        if m.get('self') is not None:
            self.self_ = m.get('self')
        return self


class ListEventsInstancesResponseBodyEventsRecurrencePattern(TeaModel):
    def __init__(
        self,
        day_of_month: int = None,
        days_of_week: str = None,
        index: str = None,
        interval: int = None,
        type: str = None,
    ):
        self.day_of_month = day_of_month
        self.days_of_week = days_of_week
        self.index = index
        self.interval = interval
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        if self.days_of_week is not None:
            result['daysOfWeek'] = self.days_of_week
        if self.index is not None:
            result['index'] = self.index
        if self.interval is not None:
            result['interval'] = self.interval
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        if m.get('daysOfWeek') is not None:
            self.days_of_week = m.get('daysOfWeek')
        if m.get('index') is not None:
            self.index = m.get('index')
        if m.get('interval') is not None:
            self.interval = m.get('interval')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class ListEventsInstancesResponseBodyEventsRecurrenceRange(TeaModel):
    def __init__(
        self,
        end_date: str = None,
        number_of_occurrences: int = None,
        type: str = None,
    ):
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.end_date = end_date
        self.number_of_occurrences = number_of_occurrences
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.number_of_occurrences is not None:
            result['numberOfOccurrences'] = self.number_of_occurrences
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('numberOfOccurrences') is not None:
            self.number_of_occurrences = m.get('numberOfOccurrences')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class ListEventsInstancesResponseBodyEventsRecurrence(TeaModel):
    def __init__(
        self,
        pattern: ListEventsInstancesResponseBodyEventsRecurrencePattern = None,
        range: ListEventsInstancesResponseBodyEventsRecurrenceRange = None,
    ):
        self.pattern = pattern
        self.range = range

    def validate(self):
        if self.pattern:
            self.pattern.validate()
        if self.range:
            self.range.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.pattern is not None:
            result['pattern'] = self.pattern.to_map()
        if self.range is not None:
            result['range'] = self.range.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pattern') is not None:
            temp_model = ListEventsInstancesResponseBodyEventsRecurrencePattern()
            self.pattern = temp_model.from_map(m['pattern'])
        if m.get('range') is not None:
            temp_model = ListEventsInstancesResponseBodyEventsRecurrenceRange()
            self.range = temp_model.from_map(m['range'])
        return self


class ListEventsInstancesResponseBodyEventsReminders(TeaModel):
    def __init__(
        self,
        method: str = None,
        minutes: str = None,
    ):
        self.method = method
        self.minutes = minutes

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.method is not None:
            result['method'] = self.method
        if self.minutes is not None:
            result['minutes'] = self.minutes
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('method') is not None:
            self.method = m.get('method')
        if m.get('minutes') is not None:
            self.minutes = m.get('minutes')
        return self


class ListEventsInstancesResponseBodyEventsStart(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        self.date = date
        self.date_time = date_time
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class ListEventsInstancesResponseBodyEvents(TeaModel):
    def __init__(
        self,
        attendees: List[ListEventsInstancesResponseBodyEventsAttendees] = None,
        create_time: str = None,
        description: str = None,
        end: ListEventsInstancesResponseBodyEventsEnd = None,
        extended_properties: ListEventsInstancesResponseBodyEventsExtendedProperties = None,
        id: str = None,
        is_all_day: bool = None,
        location: ListEventsInstancesResponseBodyEventsLocation = None,
        online_meeting_info: ListEventsInstancesResponseBodyEventsOnlineMeetingInfo = None,
        organizer: ListEventsInstancesResponseBodyEventsOrganizer = None,
        recurrence: ListEventsInstancesResponseBodyEventsRecurrence = None,
        reminders: List[ListEventsInstancesResponseBodyEventsReminders] = None,
        series_master_id: str = None,
        start: ListEventsInstancesResponseBodyEventsStart = None,
        status: str = None,
        summary: str = None,
        update_time: str = None,
    ):
        self.attendees = attendees
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.create_time = create_time
        self.description = description
        self.end = end
        self.extended_properties = extended_properties
        self.id = id
        self.is_all_day = is_all_day
        self.location = location
        self.online_meeting_info = online_meeting_info
        self.organizer = organizer
        self.recurrence = recurrence
        self.reminders = reminders
        self.series_master_id = series_master_id
        self.start = start
        self.status = status
        self.summary = summary
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.update_time = update_time

    def validate(self):
        if self.attendees:
            for k in self.attendees:
                if k:
                    k.validate()
        if self.end:
            self.end.validate()
        if self.extended_properties:
            self.extended_properties.validate()
        if self.location:
            self.location.validate()
        if self.online_meeting_info:
            self.online_meeting_info.validate()
        if self.organizer:
            self.organizer.validate()
        if self.recurrence:
            self.recurrence.validate()
        if self.reminders:
            for k in self.reminders:
                if k:
                    k.validate()
        if self.start:
            self.start.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['attendees'] = []
        if self.attendees is not None:
            for k in self.attendees:
                result['attendees'].append(k.to_map() if k else None)
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.description is not None:
            result['description'] = self.description
        if self.end is not None:
            result['end'] = self.end.to_map()
        if self.extended_properties is not None:
            result['extendedProperties'] = self.extended_properties.to_map()
        if self.id is not None:
            result['id'] = self.id
        if self.is_all_day is not None:
            result['isAllDay'] = self.is_all_day
        if self.location is not None:
            result['location'] = self.location.to_map()
        if self.online_meeting_info is not None:
            result['onlineMeetingInfo'] = self.online_meeting_info.to_map()
        if self.organizer is not None:
            result['organizer'] = self.organizer.to_map()
        if self.recurrence is not None:
            result['recurrence'] = self.recurrence.to_map()
        result['reminders'] = []
        if self.reminders is not None:
            for k in self.reminders:
                result['reminders'].append(k.to_map() if k else None)
        if self.series_master_id is not None:
            result['seriesMasterId'] = self.series_master_id
        if self.start is not None:
            result['start'] = self.start.to_map()
        if self.status is not None:
            result['status'] = self.status
        if self.summary is not None:
            result['summary'] = self.summary
        if self.update_time is not None:
            result['updateTime'] = self.update_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attendees = []
        if m.get('attendees') is not None:
            for k in m.get('attendees'):
                temp_model = ListEventsInstancesResponseBodyEventsAttendees()
                self.attendees.append(temp_model.from_map(k))
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('end') is not None:
            temp_model = ListEventsInstancesResponseBodyEventsEnd()
            self.end = temp_model.from_map(m['end'])
        if m.get('extendedProperties') is not None:
            temp_model = ListEventsInstancesResponseBodyEventsExtendedProperties()
            self.extended_properties = temp_model.from_map(m['extendedProperties'])
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isAllDay') is not None:
            self.is_all_day = m.get('isAllDay')
        if m.get('location') is not None:
            temp_model = ListEventsInstancesResponseBodyEventsLocation()
            self.location = temp_model.from_map(m['location'])
        if m.get('onlineMeetingInfo') is not None:
            temp_model = ListEventsInstancesResponseBodyEventsOnlineMeetingInfo()
            self.online_meeting_info = temp_model.from_map(m['onlineMeetingInfo'])
        if m.get('organizer') is not None:
            temp_model = ListEventsInstancesResponseBodyEventsOrganizer()
            self.organizer = temp_model.from_map(m['organizer'])
        if m.get('recurrence') is not None:
            temp_model = ListEventsInstancesResponseBodyEventsRecurrence()
            self.recurrence = temp_model.from_map(m['recurrence'])
        self.reminders = []
        if m.get('reminders') is not None:
            for k in m.get('reminders'):
                temp_model = ListEventsInstancesResponseBodyEventsReminders()
                self.reminders.append(temp_model.from_map(k))
        if m.get('seriesMasterId') is not None:
            self.series_master_id = m.get('seriesMasterId')
        if m.get('start') is not None:
            temp_model = ListEventsInstancesResponseBodyEventsStart()
            self.start = temp_model.from_map(m['start'])
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('summary') is not None:
            self.summary = m.get('summary')
        if m.get('updateTime') is not None:
            self.update_time = m.get('updateTime')
        return self


class ListEventsInstancesResponseBody(TeaModel):
    def __init__(
        self,
        events: List[ListEventsInstancesResponseBodyEvents] = None,
    ):
        self.events = events

    def validate(self):
        if self.events:
            for k in self.events:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['events'] = []
        if self.events is not None:
            for k in self.events:
                result['events'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.events = []
        if m.get('events') is not None:
            for k in m.get('events'):
                temp_model = ListEventsInstancesResponseBodyEvents()
                self.events.append(temp_model.from_map(k))
        return self


class ListEventsInstancesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListEventsInstancesResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = ListEventsInstancesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListEventsViewHeaders(TeaModel):
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


class ListEventsViewRequest(TeaModel):
    def __init__(
        self,
        max_attendees: int = None,
        max_results: int = None,
        next_token: str = None,
        time_max: str = None,
        time_min: str = None,
    ):
        self.max_attendees = max_attendees
        self.max_results = max_results
        self.next_token = next_token
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.time_max = time_max
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.time_min = time_min

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.max_attendees is not None:
            result['maxAttendees'] = self.max_attendees
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.time_max is not None:
            result['timeMax'] = self.time_max
        if self.time_min is not None:
            result['timeMin'] = self.time_min
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxAttendees') is not None:
            self.max_attendees = m.get('maxAttendees')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('timeMax') is not None:
            self.time_max = m.get('timeMax')
        if m.get('timeMin') is not None:
            self.time_min = m.get('timeMin')
        return self


class ListEventsViewResponseBodyEventsAttendees(TeaModel):
    def __init__(
        self,
        display_name: str = None,
        id: str = None,
        is_optional: bool = None,
        response_status: str = None,
        self_: bool = None,
    ):
        self.display_name = display_name
        self.id = id
        self.is_optional = is_optional
        self.response_status = response_status
        self.self_ = self_

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.id is not None:
            result['id'] = self.id
        if self.is_optional is not None:
            result['isOptional'] = self.is_optional
        if self.response_status is not None:
            result['responseStatus'] = self.response_status
        if self.self_ is not None:
            result['self'] = self.self_
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isOptional') is not None:
            self.is_optional = m.get('isOptional')
        if m.get('responseStatus') is not None:
            self.response_status = m.get('responseStatus')
        if m.get('self') is not None:
            self.self_ = m.get('self')
        return self


class ListEventsViewResponseBodyEventsCategories(TeaModel):
    def __init__(
        self,
        display_name: str = None,
    ):
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        return self


class ListEventsViewResponseBodyEventsEnd(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        self.date = date
        self.date_time = date_time
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class ListEventsViewResponseBodyEventsExtendedPropertiesSharedProperties(TeaModel):
    def __init__(
        self,
        belong_corp_id: str = None,
        source_open_cid: str = None,
    ):
        self.belong_corp_id = belong_corp_id
        self.source_open_cid = source_open_cid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.belong_corp_id is not None:
            result['belongCorpId'] = self.belong_corp_id
        if self.source_open_cid is not None:
            result['sourceOpenCid'] = self.source_open_cid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('belongCorpId') is not None:
            self.belong_corp_id = m.get('belongCorpId')
        if m.get('sourceOpenCid') is not None:
            self.source_open_cid = m.get('sourceOpenCid')
        return self


class ListEventsViewResponseBodyEventsExtendedProperties(TeaModel):
    def __init__(
        self,
        shared_properties: ListEventsViewResponseBodyEventsExtendedPropertiesSharedProperties = None,
    ):
        self.shared_properties = shared_properties

    def validate(self):
        if self.shared_properties:
            self.shared_properties.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.shared_properties is not None:
            result['sharedProperties'] = self.shared_properties.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sharedProperties') is not None:
            temp_model = ListEventsViewResponseBodyEventsExtendedPropertiesSharedProperties()
            self.shared_properties = temp_model.from_map(m['sharedProperties'])
        return self


class ListEventsViewResponseBodyEventsLocation(TeaModel):
    def __init__(
        self,
        display_name: str = None,
        meeting_rooms: List[str] = None,
    ):
        self.display_name = display_name
        self.meeting_rooms = meeting_rooms

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.meeting_rooms is not None:
            result['meetingRooms'] = self.meeting_rooms
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('meetingRooms') is not None:
            self.meeting_rooms = m.get('meetingRooms')
        return self


class ListEventsViewResponseBodyEventsMeetingRooms(TeaModel):
    def __init__(
        self,
        display_name: str = None,
        response_status: str = None,
        room_id: str = None,
    ):
        self.display_name = display_name
        self.response_status = response_status
        self.room_id = room_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.response_status is not None:
            result['responseStatus'] = self.response_status
        if self.room_id is not None:
            result['roomId'] = self.room_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('responseStatus') is not None:
            self.response_status = m.get('responseStatus')
        if m.get('roomId') is not None:
            self.room_id = m.get('roomId')
        return self


class ListEventsViewResponseBodyEventsOnlineMeetingInfo(TeaModel):
    def __init__(
        self,
        conference_id: str = None,
        extra_info: Dict[str, Any] = None,
        type: str = None,
        url: str = None,
    ):
        self.conference_id = conference_id
        self.extra_info = extra_info
        self.type = type
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conference_id is not None:
            result['conferenceId'] = self.conference_id
        if self.extra_info is not None:
            result['extraInfo'] = self.extra_info
        if self.type is not None:
            result['type'] = self.type
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conferenceId') is not None:
            self.conference_id = m.get('conferenceId')
        if m.get('extraInfo') is not None:
            self.extra_info = m.get('extraInfo')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class ListEventsViewResponseBodyEventsOrganizer(TeaModel):
    def __init__(
        self,
        display_name: str = None,
        id: str = None,
        response_status: str = None,
        self_: bool = None,
    ):
        self.display_name = display_name
        self.id = id
        self.response_status = response_status
        self.self_ = self_

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.id is not None:
            result['id'] = self.id
        if self.response_status is not None:
            result['responseStatus'] = self.response_status
        if self.self_ is not None:
            result['self'] = self.self_
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('responseStatus') is not None:
            self.response_status = m.get('responseStatus')
        if m.get('self') is not None:
            self.self_ = m.get('self')
        return self


class ListEventsViewResponseBodyEventsOriginStart(TeaModel):
    def __init__(
        self,
        date_time: str = None,
    ):
        self.date_time = date_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        return self


class ListEventsViewResponseBodyEventsRecurrencePattern(TeaModel):
    def __init__(
        self,
        day_of_month: int = None,
        days_of_week: str = None,
        first_day_of_week: str = None,
        index: str = None,
        interval: int = None,
        type: str = None,
    ):
        self.day_of_month = day_of_month
        self.days_of_week = days_of_week
        self.first_day_of_week = first_day_of_week
        self.index = index
        self.interval = interval
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        if self.days_of_week is not None:
            result['daysOfWeek'] = self.days_of_week
        if self.first_day_of_week is not None:
            result['firstDayOfWeek'] = self.first_day_of_week
        if self.index is not None:
            result['index'] = self.index
        if self.interval is not None:
            result['interval'] = self.interval
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        if m.get('daysOfWeek') is not None:
            self.days_of_week = m.get('daysOfWeek')
        if m.get('firstDayOfWeek') is not None:
            self.first_day_of_week = m.get('firstDayOfWeek')
        if m.get('index') is not None:
            self.index = m.get('index')
        if m.get('interval') is not None:
            self.interval = m.get('interval')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class ListEventsViewResponseBodyEventsRecurrenceRange(TeaModel):
    def __init__(
        self,
        end_date: str = None,
        number_of_occurrences: int = None,
        type: str = None,
    ):
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.end_date = end_date
        self.number_of_occurrences = number_of_occurrences
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.number_of_occurrences is not None:
            result['numberOfOccurrences'] = self.number_of_occurrences
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('numberOfOccurrences') is not None:
            self.number_of_occurrences = m.get('numberOfOccurrences')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class ListEventsViewResponseBodyEventsRecurrence(TeaModel):
    def __init__(
        self,
        pattern: ListEventsViewResponseBodyEventsRecurrencePattern = None,
        range: ListEventsViewResponseBodyEventsRecurrenceRange = None,
    ):
        self.pattern = pattern
        self.range = range

    def validate(self):
        if self.pattern:
            self.pattern.validate()
        if self.range:
            self.range.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.pattern is not None:
            result['pattern'] = self.pattern.to_map()
        if self.range is not None:
            result['range'] = self.range.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pattern') is not None:
            temp_model = ListEventsViewResponseBodyEventsRecurrencePattern()
            self.pattern = temp_model.from_map(m['pattern'])
        if m.get('range') is not None:
            temp_model = ListEventsViewResponseBodyEventsRecurrenceRange()
            self.range = temp_model.from_map(m['range'])
        return self


class ListEventsViewResponseBodyEventsRichTextDescription(TeaModel):
    def __init__(
        self,
        text: str = None,
    ):
        self.text = text

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.text is not None:
            result['text'] = self.text
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('text') is not None:
            self.text = m.get('text')
        return self


class ListEventsViewResponseBodyEventsStart(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        self.date = date
        self.date_time = date_time
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class ListEventsViewResponseBodyEvents(TeaModel):
    def __init__(
        self,
        attendees: List[ListEventsViewResponseBodyEventsAttendees] = None,
        categories: List[ListEventsViewResponseBodyEventsCategories] = None,
        create_time: str = None,
        description: str = None,
        end: ListEventsViewResponseBodyEventsEnd = None,
        extended_properties: ListEventsViewResponseBodyEventsExtendedProperties = None,
        id: str = None,
        is_all_day: bool = None,
        location: ListEventsViewResponseBodyEventsLocation = None,
        meeting_rooms: List[ListEventsViewResponseBodyEventsMeetingRooms] = None,
        online_meeting_info: ListEventsViewResponseBodyEventsOnlineMeetingInfo = None,
        organizer: ListEventsViewResponseBodyEventsOrganizer = None,
        origin_start: ListEventsViewResponseBodyEventsOriginStart = None,
        recurrence: ListEventsViewResponseBodyEventsRecurrence = None,
        rich_text_description: ListEventsViewResponseBodyEventsRichTextDescription = None,
        series_master_id: str = None,
        start: ListEventsViewResponseBodyEventsStart = None,
        status: str = None,
        summary: str = None,
        update_time: str = None,
    ):
        self.attendees = attendees
        self.categories = categories
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.create_time = create_time
        self.description = description
        self.end = end
        self.extended_properties = extended_properties
        self.id = id
        self.is_all_day = is_all_day
        self.location = location
        self.meeting_rooms = meeting_rooms
        self.online_meeting_info = online_meeting_info
        self.organizer = organizer
        self.origin_start = origin_start
        self.recurrence = recurrence
        self.rich_text_description = rich_text_description
        self.series_master_id = series_master_id
        self.start = start
        self.status = status
        self.summary = summary
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.update_time = update_time

    def validate(self):
        if self.attendees:
            for k in self.attendees:
                if k:
                    k.validate()
        if self.categories:
            for k in self.categories:
                if k:
                    k.validate()
        if self.end:
            self.end.validate()
        if self.extended_properties:
            self.extended_properties.validate()
        if self.location:
            self.location.validate()
        if self.meeting_rooms:
            for k in self.meeting_rooms:
                if k:
                    k.validate()
        if self.online_meeting_info:
            self.online_meeting_info.validate()
        if self.organizer:
            self.organizer.validate()
        if self.origin_start:
            self.origin_start.validate()
        if self.recurrence:
            self.recurrence.validate()
        if self.rich_text_description:
            self.rich_text_description.validate()
        if self.start:
            self.start.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['attendees'] = []
        if self.attendees is not None:
            for k in self.attendees:
                result['attendees'].append(k.to_map() if k else None)
        result['categories'] = []
        if self.categories is not None:
            for k in self.categories:
                result['categories'].append(k.to_map() if k else None)
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.description is not None:
            result['description'] = self.description
        if self.end is not None:
            result['end'] = self.end.to_map()
        if self.extended_properties is not None:
            result['extendedProperties'] = self.extended_properties.to_map()
        if self.id is not None:
            result['id'] = self.id
        if self.is_all_day is not None:
            result['isAllDay'] = self.is_all_day
        if self.location is not None:
            result['location'] = self.location.to_map()
        result['meetingRooms'] = []
        if self.meeting_rooms is not None:
            for k in self.meeting_rooms:
                result['meetingRooms'].append(k.to_map() if k else None)
        if self.online_meeting_info is not None:
            result['onlineMeetingInfo'] = self.online_meeting_info.to_map()
        if self.organizer is not None:
            result['organizer'] = self.organizer.to_map()
        if self.origin_start is not None:
            result['originStart'] = self.origin_start.to_map()
        if self.recurrence is not None:
            result['recurrence'] = self.recurrence.to_map()
        if self.rich_text_description is not None:
            result['richTextDescription'] = self.rich_text_description.to_map()
        if self.series_master_id is not None:
            result['seriesMasterId'] = self.series_master_id
        if self.start is not None:
            result['start'] = self.start.to_map()
        if self.status is not None:
            result['status'] = self.status
        if self.summary is not None:
            result['summary'] = self.summary
        if self.update_time is not None:
            result['updateTime'] = self.update_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attendees = []
        if m.get('attendees') is not None:
            for k in m.get('attendees'):
                temp_model = ListEventsViewResponseBodyEventsAttendees()
                self.attendees.append(temp_model.from_map(k))
        self.categories = []
        if m.get('categories') is not None:
            for k in m.get('categories'):
                temp_model = ListEventsViewResponseBodyEventsCategories()
                self.categories.append(temp_model.from_map(k))
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('end') is not None:
            temp_model = ListEventsViewResponseBodyEventsEnd()
            self.end = temp_model.from_map(m['end'])
        if m.get('extendedProperties') is not None:
            temp_model = ListEventsViewResponseBodyEventsExtendedProperties()
            self.extended_properties = temp_model.from_map(m['extendedProperties'])
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isAllDay') is not None:
            self.is_all_day = m.get('isAllDay')
        if m.get('location') is not None:
            temp_model = ListEventsViewResponseBodyEventsLocation()
            self.location = temp_model.from_map(m['location'])
        self.meeting_rooms = []
        if m.get('meetingRooms') is not None:
            for k in m.get('meetingRooms'):
                temp_model = ListEventsViewResponseBodyEventsMeetingRooms()
                self.meeting_rooms.append(temp_model.from_map(k))
        if m.get('onlineMeetingInfo') is not None:
            temp_model = ListEventsViewResponseBodyEventsOnlineMeetingInfo()
            self.online_meeting_info = temp_model.from_map(m['onlineMeetingInfo'])
        if m.get('organizer') is not None:
            temp_model = ListEventsViewResponseBodyEventsOrganizer()
            self.organizer = temp_model.from_map(m['organizer'])
        if m.get('originStart') is not None:
            temp_model = ListEventsViewResponseBodyEventsOriginStart()
            self.origin_start = temp_model.from_map(m['originStart'])
        if m.get('recurrence') is not None:
            temp_model = ListEventsViewResponseBodyEventsRecurrence()
            self.recurrence = temp_model.from_map(m['recurrence'])
        if m.get('richTextDescription') is not None:
            temp_model = ListEventsViewResponseBodyEventsRichTextDescription()
            self.rich_text_description = temp_model.from_map(m['richTextDescription'])
        if m.get('seriesMasterId') is not None:
            self.series_master_id = m.get('seriesMasterId')
        if m.get('start') is not None:
            temp_model = ListEventsViewResponseBodyEventsStart()
            self.start = temp_model.from_map(m['start'])
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('summary') is not None:
            self.summary = m.get('summary')
        if m.get('updateTime') is not None:
            self.update_time = m.get('updateTime')
        return self


class ListEventsViewResponseBody(TeaModel):
    def __init__(
        self,
        events: List[ListEventsViewResponseBodyEvents] = None,
        next_token: str = None,
    ):
        self.events = events
        self.next_token = next_token

    def validate(self):
        if self.events:
            for k in self.events:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['events'] = []
        if self.events is not None:
            for k in self.events:
                result['events'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.events = []
        if m.get('events') is not None:
            for k in m.get('events'):
                temp_model = ListEventsViewResponseBodyEvents()
                self.events.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class ListEventsViewResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListEventsViewResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = ListEventsViewResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListEventsViewByMeHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_client_token: str = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_client_token = x_client_token
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
        if self.x_client_token is not None:
            result['x-client-token'] = self.x_client_token
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-client-token') is not None:
            self.x_client_token = m.get('x-client-token')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class ListEventsViewByMeRequest(TeaModel):
    def __init__(
        self,
        max_attendees: int = None,
        max_results: int = None,
        next_token: str = None,
        time_max: str = None,
        time_min: str = None,
    ):
        self.max_attendees = max_attendees
        self.max_results = max_results
        self.next_token = next_token
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.time_max = time_max
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.time_min = time_min

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.max_attendees is not None:
            result['maxAttendees'] = self.max_attendees
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.time_max is not None:
            result['timeMax'] = self.time_max
        if self.time_min is not None:
            result['timeMin'] = self.time_min
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxAttendees') is not None:
            self.max_attendees = m.get('maxAttendees')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('timeMax') is not None:
            self.time_max = m.get('timeMax')
        if m.get('timeMin') is not None:
            self.time_min = m.get('timeMin')
        return self


class ListEventsViewByMeResponseBodyEventsAttendees(TeaModel):
    def __init__(
        self,
        display_name: str = None,
        id: str = None,
        is_optional: bool = None,
        response_status: str = None,
        self_: bool = None,
    ):
        self.display_name = display_name
        self.id = id
        self.is_optional = is_optional
        self.response_status = response_status
        self.self_ = self_

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.id is not None:
            result['id'] = self.id
        if self.is_optional is not None:
            result['isOptional'] = self.is_optional
        if self.response_status is not None:
            result['responseStatus'] = self.response_status
        if self.self_ is not None:
            result['self'] = self.self_
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isOptional') is not None:
            self.is_optional = m.get('isOptional')
        if m.get('responseStatus') is not None:
            self.response_status = m.get('responseStatus')
        if m.get('self') is not None:
            self.self_ = m.get('self')
        return self


class ListEventsViewByMeResponseBodyEventsCategories(TeaModel):
    def __init__(
        self,
        display_name: str = None,
    ):
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        return self


class ListEventsViewByMeResponseBodyEventsEnd(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        self.date = date
        self.date_time = date_time
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class ListEventsViewByMeResponseBodyEventsExtendedPropertiesSharedProperties(TeaModel):
    def __init__(
        self,
        belong_corp_id: str = None,
        source_open_cid: str = None,
    ):
        self.belong_corp_id = belong_corp_id
        self.source_open_cid = source_open_cid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.belong_corp_id is not None:
            result['belongCorpId'] = self.belong_corp_id
        if self.source_open_cid is not None:
            result['sourceOpenCid'] = self.source_open_cid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('belongCorpId') is not None:
            self.belong_corp_id = m.get('belongCorpId')
        if m.get('sourceOpenCid') is not None:
            self.source_open_cid = m.get('sourceOpenCid')
        return self


class ListEventsViewByMeResponseBodyEventsExtendedProperties(TeaModel):
    def __init__(
        self,
        shared_properties: ListEventsViewByMeResponseBodyEventsExtendedPropertiesSharedProperties = None,
    ):
        self.shared_properties = shared_properties

    def validate(self):
        if self.shared_properties:
            self.shared_properties.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.shared_properties is not None:
            result['sharedProperties'] = self.shared_properties.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sharedProperties') is not None:
            temp_model = ListEventsViewByMeResponseBodyEventsExtendedPropertiesSharedProperties()
            self.shared_properties = temp_model.from_map(m['sharedProperties'])
        return self


class ListEventsViewByMeResponseBodyEventsLocation(TeaModel):
    def __init__(
        self,
        display_name: str = None,
        meeting_rooms: List[str] = None,
    ):
        self.display_name = display_name
        self.meeting_rooms = meeting_rooms

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.meeting_rooms is not None:
            result['meetingRooms'] = self.meeting_rooms
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('meetingRooms') is not None:
            self.meeting_rooms = m.get('meetingRooms')
        return self


class ListEventsViewByMeResponseBodyEventsMeetingRooms(TeaModel):
    def __init__(
        self,
        display_name: str = None,
        response_status: str = None,
        room_id: str = None,
    ):
        self.display_name = display_name
        self.response_status = response_status
        self.room_id = room_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.response_status is not None:
            result['responseStatus'] = self.response_status
        if self.room_id is not None:
            result['roomId'] = self.room_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('responseStatus') is not None:
            self.response_status = m.get('responseStatus')
        if m.get('roomId') is not None:
            self.room_id = m.get('roomId')
        return self


class ListEventsViewByMeResponseBodyEventsOnlineMeetingInfo(TeaModel):
    def __init__(
        self,
        conference_id: str = None,
        extra_info: Dict[str, Any] = None,
        type: str = None,
        url: str = None,
    ):
        self.conference_id = conference_id
        self.extra_info = extra_info
        self.type = type
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conference_id is not None:
            result['conferenceId'] = self.conference_id
        if self.extra_info is not None:
            result['extraInfo'] = self.extra_info
        if self.type is not None:
            result['type'] = self.type
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conferenceId') is not None:
            self.conference_id = m.get('conferenceId')
        if m.get('extraInfo') is not None:
            self.extra_info = m.get('extraInfo')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class ListEventsViewByMeResponseBodyEventsOrganizer(TeaModel):
    def __init__(
        self,
        display_name: str = None,
        id: str = None,
        response_status: str = None,
        self_: bool = None,
    ):
        self.display_name = display_name
        self.id = id
        self.response_status = response_status
        self.self_ = self_

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.id is not None:
            result['id'] = self.id
        if self.response_status is not None:
            result['responseStatus'] = self.response_status
        if self.self_ is not None:
            result['self'] = self.self_
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('responseStatus') is not None:
            self.response_status = m.get('responseStatus')
        if m.get('self') is not None:
            self.self_ = m.get('self')
        return self


class ListEventsViewByMeResponseBodyEventsOriginStart(TeaModel):
    def __init__(
        self,
        date_time: str = None,
    ):
        self.date_time = date_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        return self


class ListEventsViewByMeResponseBodyEventsRecurrencePattern(TeaModel):
    def __init__(
        self,
        day_of_month: int = None,
        days_of_week: str = None,
        first_day_of_week: str = None,
        index: str = None,
        interval: int = None,
        type: str = None,
    ):
        self.day_of_month = day_of_month
        self.days_of_week = days_of_week
        self.first_day_of_week = first_day_of_week
        self.index = index
        self.interval = interval
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        if self.days_of_week is not None:
            result['daysOfWeek'] = self.days_of_week
        if self.first_day_of_week is not None:
            result['firstDayOfWeek'] = self.first_day_of_week
        if self.index is not None:
            result['index'] = self.index
        if self.interval is not None:
            result['interval'] = self.interval
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        if m.get('daysOfWeek') is not None:
            self.days_of_week = m.get('daysOfWeek')
        if m.get('firstDayOfWeek') is not None:
            self.first_day_of_week = m.get('firstDayOfWeek')
        if m.get('index') is not None:
            self.index = m.get('index')
        if m.get('interval') is not None:
            self.interval = m.get('interval')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class ListEventsViewByMeResponseBodyEventsRecurrenceRange(TeaModel):
    def __init__(
        self,
        end_date: str = None,
        number_of_occurrences: int = None,
        type: str = None,
    ):
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.end_date = end_date
        self.number_of_occurrences = number_of_occurrences
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.number_of_occurrences is not None:
            result['numberOfOccurrences'] = self.number_of_occurrences
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('numberOfOccurrences') is not None:
            self.number_of_occurrences = m.get('numberOfOccurrences')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class ListEventsViewByMeResponseBodyEventsRecurrence(TeaModel):
    def __init__(
        self,
        pattern: ListEventsViewByMeResponseBodyEventsRecurrencePattern = None,
        range: ListEventsViewByMeResponseBodyEventsRecurrenceRange = None,
    ):
        self.pattern = pattern
        self.range = range

    def validate(self):
        if self.pattern:
            self.pattern.validate()
        if self.range:
            self.range.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.pattern is not None:
            result['pattern'] = self.pattern.to_map()
        if self.range is not None:
            result['range'] = self.range.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pattern') is not None:
            temp_model = ListEventsViewByMeResponseBodyEventsRecurrencePattern()
            self.pattern = temp_model.from_map(m['pattern'])
        if m.get('range') is not None:
            temp_model = ListEventsViewByMeResponseBodyEventsRecurrenceRange()
            self.range = temp_model.from_map(m['range'])
        return self


class ListEventsViewByMeResponseBodyEventsRichTextDescription(TeaModel):
    def __init__(
        self,
        text: str = None,
    ):
        self.text = text

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.text is not None:
            result['text'] = self.text
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('text') is not None:
            self.text = m.get('text')
        return self


class ListEventsViewByMeResponseBodyEventsStart(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        self.date = date
        self.date_time = date_time
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class ListEventsViewByMeResponseBodyEvents(TeaModel):
    def __init__(
        self,
        attendees: List[ListEventsViewByMeResponseBodyEventsAttendees] = None,
        categories: List[ListEventsViewByMeResponseBodyEventsCategories] = None,
        create_time: str = None,
        description: str = None,
        end: ListEventsViewByMeResponseBodyEventsEnd = None,
        extended_properties: ListEventsViewByMeResponseBodyEventsExtendedProperties = None,
        id: str = None,
        is_all_day: bool = None,
        location: ListEventsViewByMeResponseBodyEventsLocation = None,
        meeting_rooms: List[ListEventsViewByMeResponseBodyEventsMeetingRooms] = None,
        online_meeting_info: ListEventsViewByMeResponseBodyEventsOnlineMeetingInfo = None,
        organizer: ListEventsViewByMeResponseBodyEventsOrganizer = None,
        origin_start: ListEventsViewByMeResponseBodyEventsOriginStart = None,
        recurrence: ListEventsViewByMeResponseBodyEventsRecurrence = None,
        rich_text_description: ListEventsViewByMeResponseBodyEventsRichTextDescription = None,
        series_master_id: str = None,
        start: ListEventsViewByMeResponseBodyEventsStart = None,
        status: str = None,
        summary: str = None,
        update_time: str = None,
    ):
        self.attendees = attendees
        self.categories = categories
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.create_time = create_time
        self.description = description
        self.end = end
        self.extended_properties = extended_properties
        self.id = id
        self.is_all_day = is_all_day
        self.location = location
        self.meeting_rooms = meeting_rooms
        self.online_meeting_info = online_meeting_info
        self.organizer = organizer
        self.origin_start = origin_start
        self.recurrence = recurrence
        self.rich_text_description = rich_text_description
        self.series_master_id = series_master_id
        self.start = start
        self.status = status
        self.summary = summary
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.update_time = update_time

    def validate(self):
        if self.attendees:
            for k in self.attendees:
                if k:
                    k.validate()
        if self.categories:
            for k in self.categories:
                if k:
                    k.validate()
        if self.end:
            self.end.validate()
        if self.extended_properties:
            self.extended_properties.validate()
        if self.location:
            self.location.validate()
        if self.meeting_rooms:
            for k in self.meeting_rooms:
                if k:
                    k.validate()
        if self.online_meeting_info:
            self.online_meeting_info.validate()
        if self.organizer:
            self.organizer.validate()
        if self.origin_start:
            self.origin_start.validate()
        if self.recurrence:
            self.recurrence.validate()
        if self.rich_text_description:
            self.rich_text_description.validate()
        if self.start:
            self.start.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['attendees'] = []
        if self.attendees is not None:
            for k in self.attendees:
                result['attendees'].append(k.to_map() if k else None)
        result['categories'] = []
        if self.categories is not None:
            for k in self.categories:
                result['categories'].append(k.to_map() if k else None)
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.description is not None:
            result['description'] = self.description
        if self.end is not None:
            result['end'] = self.end.to_map()
        if self.extended_properties is not None:
            result['extendedProperties'] = self.extended_properties.to_map()
        if self.id is not None:
            result['id'] = self.id
        if self.is_all_day is not None:
            result['isAllDay'] = self.is_all_day
        if self.location is not None:
            result['location'] = self.location.to_map()
        result['meetingRooms'] = []
        if self.meeting_rooms is not None:
            for k in self.meeting_rooms:
                result['meetingRooms'].append(k.to_map() if k else None)
        if self.online_meeting_info is not None:
            result['onlineMeetingInfo'] = self.online_meeting_info.to_map()
        if self.organizer is not None:
            result['organizer'] = self.organizer.to_map()
        if self.origin_start is not None:
            result['originStart'] = self.origin_start.to_map()
        if self.recurrence is not None:
            result['recurrence'] = self.recurrence.to_map()
        if self.rich_text_description is not None:
            result['richTextDescription'] = self.rich_text_description.to_map()
        if self.series_master_id is not None:
            result['seriesMasterId'] = self.series_master_id
        if self.start is not None:
            result['start'] = self.start.to_map()
        if self.status is not None:
            result['status'] = self.status
        if self.summary is not None:
            result['summary'] = self.summary
        if self.update_time is not None:
            result['updateTime'] = self.update_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attendees = []
        if m.get('attendees') is not None:
            for k in m.get('attendees'):
                temp_model = ListEventsViewByMeResponseBodyEventsAttendees()
                self.attendees.append(temp_model.from_map(k))
        self.categories = []
        if m.get('categories') is not None:
            for k in m.get('categories'):
                temp_model = ListEventsViewByMeResponseBodyEventsCategories()
                self.categories.append(temp_model.from_map(k))
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('end') is not None:
            temp_model = ListEventsViewByMeResponseBodyEventsEnd()
            self.end = temp_model.from_map(m['end'])
        if m.get('extendedProperties') is not None:
            temp_model = ListEventsViewByMeResponseBodyEventsExtendedProperties()
            self.extended_properties = temp_model.from_map(m['extendedProperties'])
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isAllDay') is not None:
            self.is_all_day = m.get('isAllDay')
        if m.get('location') is not None:
            temp_model = ListEventsViewByMeResponseBodyEventsLocation()
            self.location = temp_model.from_map(m['location'])
        self.meeting_rooms = []
        if m.get('meetingRooms') is not None:
            for k in m.get('meetingRooms'):
                temp_model = ListEventsViewByMeResponseBodyEventsMeetingRooms()
                self.meeting_rooms.append(temp_model.from_map(k))
        if m.get('onlineMeetingInfo') is not None:
            temp_model = ListEventsViewByMeResponseBodyEventsOnlineMeetingInfo()
            self.online_meeting_info = temp_model.from_map(m['onlineMeetingInfo'])
        if m.get('organizer') is not None:
            temp_model = ListEventsViewByMeResponseBodyEventsOrganizer()
            self.organizer = temp_model.from_map(m['organizer'])
        if m.get('originStart') is not None:
            temp_model = ListEventsViewByMeResponseBodyEventsOriginStart()
            self.origin_start = temp_model.from_map(m['originStart'])
        if m.get('recurrence') is not None:
            temp_model = ListEventsViewByMeResponseBodyEventsRecurrence()
            self.recurrence = temp_model.from_map(m['recurrence'])
        if m.get('richTextDescription') is not None:
            temp_model = ListEventsViewByMeResponseBodyEventsRichTextDescription()
            self.rich_text_description = temp_model.from_map(m['richTextDescription'])
        if m.get('seriesMasterId') is not None:
            self.series_master_id = m.get('seriesMasterId')
        if m.get('start') is not None:
            temp_model = ListEventsViewByMeResponseBodyEventsStart()
            self.start = temp_model.from_map(m['start'])
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('summary') is not None:
            self.summary = m.get('summary')
        if m.get('updateTime') is not None:
            self.update_time = m.get('updateTime')
        return self


class ListEventsViewByMeResponseBody(TeaModel):
    def __init__(
        self,
        events: List[ListEventsViewByMeResponseBodyEvents] = None,
        next_token: str = None,
    ):
        self.events = events
        self.next_token = next_token

    def validate(self):
        if self.events:
            for k in self.events:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['events'] = []
        if self.events is not None:
            for k in self.events:
                result['events'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.events = []
        if m.get('events') is not None:
            for k in m.get('events'):
                temp_model = ListEventsViewByMeResponseBodyEvents()
                self.events.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class ListEventsViewByMeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListEventsViewByMeResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = ListEventsViewByMeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListInstancesHeaders(TeaModel):
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


class ListInstancesRequest(TeaModel):
    def __init__(
        self,
        max_attendees: int = None,
        max_results: int = None,
        next_token: str = None,
        time_max: str = None,
        time_min: str = None,
    ):
        self.max_attendees = max_attendees
        self.max_results = max_results
        self.next_token = next_token
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.time_max = time_max
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.time_min = time_min

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.max_attendees is not None:
            result['maxAttendees'] = self.max_attendees
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.time_max is not None:
            result['timeMax'] = self.time_max
        if self.time_min is not None:
            result['timeMin'] = self.time_min
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxAttendees') is not None:
            self.max_attendees = m.get('maxAttendees')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('timeMax') is not None:
            self.time_max = m.get('timeMax')
        if m.get('timeMin') is not None:
            self.time_min = m.get('timeMin')
        return self


class ListInstancesResponseBodyEventsAttendees(TeaModel):
    def __init__(
        self,
        display_name: str = None,
        id: str = None,
        is_optional: bool = None,
        response_status: str = None,
        self_: bool = None,
    ):
        self.display_name = display_name
        self.id = id
        self.is_optional = is_optional
        self.response_status = response_status
        self.self_ = self_

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.id is not None:
            result['id'] = self.id
        if self.is_optional is not None:
            result['isOptional'] = self.is_optional
        if self.response_status is not None:
            result['responseStatus'] = self.response_status
        if self.self_ is not None:
            result['self'] = self.self_
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isOptional') is not None:
            self.is_optional = m.get('isOptional')
        if m.get('responseStatus') is not None:
            self.response_status = m.get('responseStatus')
        if m.get('self') is not None:
            self.self_ = m.get('self')
        return self


class ListInstancesResponseBodyEventsEnd(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        self.date = date
        self.date_time = date_time
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class ListInstancesResponseBodyEventsExtendedPropertiesSharedProperties(TeaModel):
    def __init__(
        self,
        belong_corp_id: str = None,
        source_open_cid: str = None,
    ):
        self.belong_corp_id = belong_corp_id
        self.source_open_cid = source_open_cid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.belong_corp_id is not None:
            result['belongCorpId'] = self.belong_corp_id
        if self.source_open_cid is not None:
            result['sourceOpenCid'] = self.source_open_cid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('belongCorpId') is not None:
            self.belong_corp_id = m.get('belongCorpId')
        if m.get('sourceOpenCid') is not None:
            self.source_open_cid = m.get('sourceOpenCid')
        return self


class ListInstancesResponseBodyEventsExtendedProperties(TeaModel):
    def __init__(
        self,
        shared_properties: ListInstancesResponseBodyEventsExtendedPropertiesSharedProperties = None,
    ):
        self.shared_properties = shared_properties

    def validate(self):
        if self.shared_properties:
            self.shared_properties.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.shared_properties is not None:
            result['sharedProperties'] = self.shared_properties.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sharedProperties') is not None:
            temp_model = ListInstancesResponseBodyEventsExtendedPropertiesSharedProperties()
            self.shared_properties = temp_model.from_map(m['sharedProperties'])
        return self


class ListInstancesResponseBodyEventsLocation(TeaModel):
    def __init__(
        self,
        display_name: str = None,
    ):
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        return self


class ListInstancesResponseBodyEventsMeetingRooms(TeaModel):
    def __init__(
        self,
        display_name: str = None,
        response_status: str = None,
        room_id: str = None,
    ):
        self.display_name = display_name
        self.response_status = response_status
        self.room_id = room_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.response_status is not None:
            result['responseStatus'] = self.response_status
        if self.room_id is not None:
            result['roomId'] = self.room_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('responseStatus') is not None:
            self.response_status = m.get('responseStatus')
        if m.get('roomId') is not None:
            self.room_id = m.get('roomId')
        return self


class ListInstancesResponseBodyEventsOnlineMeetingInfo(TeaModel):
    def __init__(
        self,
        conference_id: str = None,
        extra_info: Dict[str, Any] = None,
        type: str = None,
        url: str = None,
    ):
        self.conference_id = conference_id
        self.extra_info = extra_info
        self.type = type
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conference_id is not None:
            result['conferenceId'] = self.conference_id
        if self.extra_info is not None:
            result['extraInfo'] = self.extra_info
        if self.type is not None:
            result['type'] = self.type
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conferenceId') is not None:
            self.conference_id = m.get('conferenceId')
        if m.get('extraInfo') is not None:
            self.extra_info = m.get('extraInfo')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class ListInstancesResponseBodyEventsOrganizer(TeaModel):
    def __init__(
        self,
        display_name: str = None,
        id: str = None,
        response_status: str = None,
        self_: bool = None,
    ):
        self.display_name = display_name
        self.id = id
        self.response_status = response_status
        self.self_ = self_

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.id is not None:
            result['id'] = self.id
        if self.response_status is not None:
            result['responseStatus'] = self.response_status
        if self.self_ is not None:
            result['self'] = self.self_
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('responseStatus') is not None:
            self.response_status = m.get('responseStatus')
        if m.get('self') is not None:
            self.self_ = m.get('self')
        return self


class ListInstancesResponseBodyEventsRecurrencePattern(TeaModel):
    def __init__(
        self,
        day_of_month: int = None,
        days_of_week: str = None,
        index: str = None,
        interval: int = None,
        type: str = None,
    ):
        self.day_of_month = day_of_month
        self.days_of_week = days_of_week
        self.index = index
        self.interval = interval
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        if self.days_of_week is not None:
            result['daysOfWeek'] = self.days_of_week
        if self.index is not None:
            result['index'] = self.index
        if self.interval is not None:
            result['interval'] = self.interval
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        if m.get('daysOfWeek') is not None:
            self.days_of_week = m.get('daysOfWeek')
        if m.get('index') is not None:
            self.index = m.get('index')
        if m.get('interval') is not None:
            self.interval = m.get('interval')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class ListInstancesResponseBodyEventsRecurrenceRange(TeaModel):
    def __init__(
        self,
        end_date: str = None,
        number_of_occurrences: int = None,
        type: str = None,
    ):
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.end_date = end_date
        self.number_of_occurrences = number_of_occurrences
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.number_of_occurrences is not None:
            result['numberOfOccurrences'] = self.number_of_occurrences
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('numberOfOccurrences') is not None:
            self.number_of_occurrences = m.get('numberOfOccurrences')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class ListInstancesResponseBodyEventsRecurrence(TeaModel):
    def __init__(
        self,
        pattern: ListInstancesResponseBodyEventsRecurrencePattern = None,
        range: ListInstancesResponseBodyEventsRecurrenceRange = None,
    ):
        self.pattern = pattern
        self.range = range

    def validate(self):
        if self.pattern:
            self.pattern.validate()
        if self.range:
            self.range.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.pattern is not None:
            result['pattern'] = self.pattern.to_map()
        if self.range is not None:
            result['range'] = self.range.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pattern') is not None:
            temp_model = ListInstancesResponseBodyEventsRecurrencePattern()
            self.pattern = temp_model.from_map(m['pattern'])
        if m.get('range') is not None:
            temp_model = ListInstancesResponseBodyEventsRecurrenceRange()
            self.range = temp_model.from_map(m['range'])
        return self


class ListInstancesResponseBodyEventsReminders(TeaModel):
    def __init__(
        self,
        method: str = None,
        minutes: str = None,
    ):
        self.method = method
        self.minutes = minutes

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.method is not None:
            result['method'] = self.method
        if self.minutes is not None:
            result['minutes'] = self.minutes
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('method') is not None:
            self.method = m.get('method')
        if m.get('minutes') is not None:
            self.minutes = m.get('minutes')
        return self


class ListInstancesResponseBodyEventsStart(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        self.date = date
        self.date_time = date_time
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class ListInstancesResponseBodyEvents(TeaModel):
    def __init__(
        self,
        attendees: List[ListInstancesResponseBodyEventsAttendees] = None,
        create_time: str = None,
        description: str = None,
        end: ListInstancesResponseBodyEventsEnd = None,
        extended_properties: ListInstancesResponseBodyEventsExtendedProperties = None,
        id: str = None,
        is_all_day: bool = None,
        location: ListInstancesResponseBodyEventsLocation = None,
        meeting_rooms: List[ListInstancesResponseBodyEventsMeetingRooms] = None,
        online_meeting_info: ListInstancesResponseBodyEventsOnlineMeetingInfo = None,
        organizer: ListInstancesResponseBodyEventsOrganizer = None,
        recurrence: ListInstancesResponseBodyEventsRecurrence = None,
        reminders: List[ListInstancesResponseBodyEventsReminders] = None,
        series_master_id: str = None,
        start: ListInstancesResponseBodyEventsStart = None,
        status: str = None,
        summary: str = None,
        update_time: str = None,
    ):
        self.attendees = attendees
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.create_time = create_time
        self.description = description
        self.end = end
        self.extended_properties = extended_properties
        self.id = id
        self.is_all_day = is_all_day
        self.location = location
        self.meeting_rooms = meeting_rooms
        self.online_meeting_info = online_meeting_info
        self.organizer = organizer
        self.recurrence = recurrence
        self.reminders = reminders
        self.series_master_id = series_master_id
        self.start = start
        self.status = status
        self.summary = summary
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.update_time = update_time

    def validate(self):
        if self.attendees:
            for k in self.attendees:
                if k:
                    k.validate()
        if self.end:
            self.end.validate()
        if self.extended_properties:
            self.extended_properties.validate()
        if self.location:
            self.location.validate()
        if self.meeting_rooms:
            for k in self.meeting_rooms:
                if k:
                    k.validate()
        if self.online_meeting_info:
            self.online_meeting_info.validate()
        if self.organizer:
            self.organizer.validate()
        if self.recurrence:
            self.recurrence.validate()
        if self.reminders:
            for k in self.reminders:
                if k:
                    k.validate()
        if self.start:
            self.start.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['attendees'] = []
        if self.attendees is not None:
            for k in self.attendees:
                result['attendees'].append(k.to_map() if k else None)
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.description is not None:
            result['description'] = self.description
        if self.end is not None:
            result['end'] = self.end.to_map()
        if self.extended_properties is not None:
            result['extendedProperties'] = self.extended_properties.to_map()
        if self.id is not None:
            result['id'] = self.id
        if self.is_all_day is not None:
            result['isAllDay'] = self.is_all_day
        if self.location is not None:
            result['location'] = self.location.to_map()
        result['meetingRooms'] = []
        if self.meeting_rooms is not None:
            for k in self.meeting_rooms:
                result['meetingRooms'].append(k.to_map() if k else None)
        if self.online_meeting_info is not None:
            result['onlineMeetingInfo'] = self.online_meeting_info.to_map()
        if self.organizer is not None:
            result['organizer'] = self.organizer.to_map()
        if self.recurrence is not None:
            result['recurrence'] = self.recurrence.to_map()
        result['reminders'] = []
        if self.reminders is not None:
            for k in self.reminders:
                result['reminders'].append(k.to_map() if k else None)
        if self.series_master_id is not None:
            result['seriesMasterId'] = self.series_master_id
        if self.start is not None:
            result['start'] = self.start.to_map()
        if self.status is not None:
            result['status'] = self.status
        if self.summary is not None:
            result['summary'] = self.summary
        if self.update_time is not None:
            result['updateTime'] = self.update_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attendees = []
        if m.get('attendees') is not None:
            for k in m.get('attendees'):
                temp_model = ListInstancesResponseBodyEventsAttendees()
                self.attendees.append(temp_model.from_map(k))
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('end') is not None:
            temp_model = ListInstancesResponseBodyEventsEnd()
            self.end = temp_model.from_map(m['end'])
        if m.get('extendedProperties') is not None:
            temp_model = ListInstancesResponseBodyEventsExtendedProperties()
            self.extended_properties = temp_model.from_map(m['extendedProperties'])
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isAllDay') is not None:
            self.is_all_day = m.get('isAllDay')
        if m.get('location') is not None:
            temp_model = ListInstancesResponseBodyEventsLocation()
            self.location = temp_model.from_map(m['location'])
        self.meeting_rooms = []
        if m.get('meetingRooms') is not None:
            for k in m.get('meetingRooms'):
                temp_model = ListInstancesResponseBodyEventsMeetingRooms()
                self.meeting_rooms.append(temp_model.from_map(k))
        if m.get('onlineMeetingInfo') is not None:
            temp_model = ListInstancesResponseBodyEventsOnlineMeetingInfo()
            self.online_meeting_info = temp_model.from_map(m['onlineMeetingInfo'])
        if m.get('organizer') is not None:
            temp_model = ListInstancesResponseBodyEventsOrganizer()
            self.organizer = temp_model.from_map(m['organizer'])
        if m.get('recurrence') is not None:
            temp_model = ListInstancesResponseBodyEventsRecurrence()
            self.recurrence = temp_model.from_map(m['recurrence'])
        self.reminders = []
        if m.get('reminders') is not None:
            for k in m.get('reminders'):
                temp_model = ListInstancesResponseBodyEventsReminders()
                self.reminders.append(temp_model.from_map(k))
        if m.get('seriesMasterId') is not None:
            self.series_master_id = m.get('seriesMasterId')
        if m.get('start') is not None:
            temp_model = ListInstancesResponseBodyEventsStart()
            self.start = temp_model.from_map(m['start'])
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('summary') is not None:
            self.summary = m.get('summary')
        if m.get('updateTime') is not None:
            self.update_time = m.get('updateTime')
        return self


class ListInstancesResponseBody(TeaModel):
    def __init__(
        self,
        events: List[ListInstancesResponseBodyEvents] = None,
        next_token: str = None,
    ):
        self.events = events
        self.next_token = next_token

    def validate(self):
        if self.events:
            for k in self.events:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['events'] = []
        if self.events is not None:
            for k in self.events:
                result['events'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.events = []
        if m.get('events') is not None:
            for k in m.get('events'):
                temp_model = ListInstancesResponseBodyEvents()
                self.events.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class ListInstancesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListInstancesResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = ListInstancesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class MeetingRoomRespondHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        user_agent: str = None,
        x_client_token: str = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.user_agent = user_agent
        self.x_client_token = x_client_token
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
        if self.user_agent is not None:
            result['userAgent'] = self.user_agent
        if self.x_client_token is not None:
            result['x-client-token'] = self.x_client_token
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('userAgent') is not None:
            self.user_agent = m.get('userAgent')
        if m.get('x-client-token') is not None:
            self.x_client_token = m.get('x-client-token')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class MeetingRoomRespondRequest(TeaModel):
    def __init__(
        self,
        response_status: str = None,
    ):
        self.response_status = response_status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.response_status is not None:
            result['responseStatus'] = self.response_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('responseStatus') is not None:
            self.response_status = m.get('responseStatus')
        return self


class MeetingRoomRespondResponseBody(TeaModel):
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


class MeetingRoomRespondResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: MeetingRoomRespondResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = MeetingRoomRespondResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PatchEventHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_client_token: str = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_client_token = x_client_token
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
        if self.x_client_token is not None:
            result['x-client-token'] = self.x_client_token
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-client-token') is not None:
            self.x_client_token = m.get('x-client-token')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class PatchEventRequestAttendees(TeaModel):
    def __init__(
        self,
        email: str = None,
        id: str = None,
        is_optional: bool = None,
    ):
        self.email = email
        self.id = id
        self.is_optional = is_optional

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.email is not None:
            result['email'] = self.email
        if self.id is not None:
            result['id'] = self.id
        if self.is_optional is not None:
            result['isOptional'] = self.is_optional
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('email') is not None:
            self.email = m.get('email')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isOptional') is not None:
            self.is_optional = m.get('isOptional')
        return self


class PatchEventRequestCardInstances(TeaModel):
    def __init__(
        self,
        out_track_id: str = None,
        scenario: str = None,
    ):
        self.out_track_id = out_track_id
        self.scenario = scenario

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.out_track_id is not None:
            result['outTrackId'] = self.out_track_id
        if self.scenario is not None:
            result['scenario'] = self.scenario
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('outTrackId') is not None:
            self.out_track_id = m.get('outTrackId')
        if m.get('scenario') is not None:
            self.scenario = m.get('scenario')
        return self


class PatchEventRequestEnd(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        self.date = date
        self.date_time = date_time
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class PatchEventRequestLocation(TeaModel):
    def __init__(
        self,
        display_name: str = None,
    ):
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        return self


class PatchEventRequestOnlineMeetingInfo(TeaModel):
    def __init__(
        self,
        type: str = None,
    ):
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class PatchEventRequestRecurrencePattern(TeaModel):
    def __init__(
        self,
        day_of_month: int = None,
        days_of_week: str = None,
        first_day_of_week: str = None,
        index: str = None,
        interval: int = None,
        type: str = None,
    ):
        self.day_of_month = day_of_month
        self.days_of_week = days_of_week
        self.first_day_of_week = first_day_of_week
        self.index = index
        self.interval = interval
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        if self.days_of_week is not None:
            result['daysOfWeek'] = self.days_of_week
        if self.first_day_of_week is not None:
            result['firstDayOfWeek'] = self.first_day_of_week
        if self.index is not None:
            result['index'] = self.index
        if self.interval is not None:
            result['interval'] = self.interval
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        if m.get('daysOfWeek') is not None:
            self.days_of_week = m.get('daysOfWeek')
        if m.get('firstDayOfWeek') is not None:
            self.first_day_of_week = m.get('firstDayOfWeek')
        if m.get('index') is not None:
            self.index = m.get('index')
        if m.get('interval') is not None:
            self.interval = m.get('interval')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class PatchEventRequestRecurrenceRange(TeaModel):
    def __init__(
        self,
        end_date: str = None,
        number_of_occurrences: int = None,
        type: str = None,
    ):
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.end_date = end_date
        self.number_of_occurrences = number_of_occurrences
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.number_of_occurrences is not None:
            result['numberOfOccurrences'] = self.number_of_occurrences
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('numberOfOccurrences') is not None:
            self.number_of_occurrences = m.get('numberOfOccurrences')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class PatchEventRequestRecurrence(TeaModel):
    def __init__(
        self,
        pattern: PatchEventRequestRecurrencePattern = None,
        range: PatchEventRequestRecurrenceRange = None,
    ):
        self.pattern = pattern
        self.range = range

    def validate(self):
        if self.pattern:
            self.pattern.validate()
        if self.range:
            self.range.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.pattern is not None:
            result['pattern'] = self.pattern.to_map()
        if self.range is not None:
            result['range'] = self.range.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pattern') is not None:
            temp_model = PatchEventRequestRecurrencePattern()
            self.pattern = temp_model.from_map(m['pattern'])
        if m.get('range') is not None:
            temp_model = PatchEventRequestRecurrenceRange()
            self.range = temp_model.from_map(m['range'])
        return self


class PatchEventRequestReminders(TeaModel):
    def __init__(
        self,
        method: str = None,
        minutes: int = None,
    ):
        self.method = method
        self.minutes = minutes

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.method is not None:
            result['method'] = self.method
        if self.minutes is not None:
            result['minutes'] = self.minutes
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('method') is not None:
            self.method = m.get('method')
        if m.get('minutes') is not None:
            self.minutes = m.get('minutes')
        return self


class PatchEventRequestRichTextDescription(TeaModel):
    def __init__(
        self,
        text: str = None,
    ):
        self.text = text

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.text is not None:
            result['text'] = self.text
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('text') is not None:
            self.text = m.get('text')
        return self


class PatchEventRequestStart(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        self.date = date
        self.date_time = date_time
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class PatchEventRequestUiConfigs(TeaModel):
    def __init__(
        self,
        ui_name: str = None,
        ui_status: str = None,
    ):
        # This parameter is required.
        self.ui_name = ui_name
        # This parameter is required.
        self.ui_status = ui_status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ui_name is not None:
            result['uiName'] = self.ui_name
        if self.ui_status is not None:
            result['uiStatus'] = self.ui_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('uiName') is not None:
            self.ui_name = m.get('uiName')
        if m.get('uiStatus') is not None:
            self.ui_status = m.get('uiStatus')
        return self


class PatchEventRequest(TeaModel):
    def __init__(
        self,
        attendees: List[PatchEventRequestAttendees] = None,
        card_instances: List[PatchEventRequestCardInstances] = None,
        description: str = None,
        end: PatchEventRequestEnd = None,
        extra: Dict[str, str] = None,
        id: str = None,
        is_all_day: bool = None,
        location: PatchEventRequestLocation = None,
        online_meeting_info: PatchEventRequestOnlineMeetingInfo = None,
        recurrence: PatchEventRequestRecurrence = None,
        reminders: List[PatchEventRequestReminders] = None,
        rich_text_description: PatchEventRequestRichTextDescription = None,
        start: PatchEventRequestStart = None,
        summary: str = None,
        ui_configs: List[PatchEventRequestUiConfigs] = None,
    ):
        self.attendees = attendees
        self.card_instances = card_instances
        self.description = description
        self.end = end
        self.extra = extra
        # This parameter is required.
        self.id = id
        self.is_all_day = is_all_day
        self.location = location
        self.online_meeting_info = online_meeting_info
        self.recurrence = recurrence
        self.reminders = reminders
        self.rich_text_description = rich_text_description
        self.start = start
        self.summary = summary
        self.ui_configs = ui_configs

    def validate(self):
        if self.attendees:
            for k in self.attendees:
                if k:
                    k.validate()
        if self.card_instances:
            for k in self.card_instances:
                if k:
                    k.validate()
        if self.end:
            self.end.validate()
        if self.location:
            self.location.validate()
        if self.online_meeting_info:
            self.online_meeting_info.validate()
        if self.recurrence:
            self.recurrence.validate()
        if self.reminders:
            for k in self.reminders:
                if k:
                    k.validate()
        if self.rich_text_description:
            self.rich_text_description.validate()
        if self.start:
            self.start.validate()
        if self.ui_configs:
            for k in self.ui_configs:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['attendees'] = []
        if self.attendees is not None:
            for k in self.attendees:
                result['attendees'].append(k.to_map() if k else None)
        result['cardInstances'] = []
        if self.card_instances is not None:
            for k in self.card_instances:
                result['cardInstances'].append(k.to_map() if k else None)
        if self.description is not None:
            result['description'] = self.description
        if self.end is not None:
            result['end'] = self.end.to_map()
        if self.extra is not None:
            result['extra'] = self.extra
        if self.id is not None:
            result['id'] = self.id
        if self.is_all_day is not None:
            result['isAllDay'] = self.is_all_day
        if self.location is not None:
            result['location'] = self.location.to_map()
        if self.online_meeting_info is not None:
            result['onlineMeetingInfo'] = self.online_meeting_info.to_map()
        if self.recurrence is not None:
            result['recurrence'] = self.recurrence.to_map()
        result['reminders'] = []
        if self.reminders is not None:
            for k in self.reminders:
                result['reminders'].append(k.to_map() if k else None)
        if self.rich_text_description is not None:
            result['richTextDescription'] = self.rich_text_description.to_map()
        if self.start is not None:
            result['start'] = self.start.to_map()
        if self.summary is not None:
            result['summary'] = self.summary
        result['uiConfigs'] = []
        if self.ui_configs is not None:
            for k in self.ui_configs:
                result['uiConfigs'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attendees = []
        if m.get('attendees') is not None:
            for k in m.get('attendees'):
                temp_model = PatchEventRequestAttendees()
                self.attendees.append(temp_model.from_map(k))
        self.card_instances = []
        if m.get('cardInstances') is not None:
            for k in m.get('cardInstances'):
                temp_model = PatchEventRequestCardInstances()
                self.card_instances.append(temp_model.from_map(k))
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('end') is not None:
            temp_model = PatchEventRequestEnd()
            self.end = temp_model.from_map(m['end'])
        if m.get('extra') is not None:
            self.extra = m.get('extra')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isAllDay') is not None:
            self.is_all_day = m.get('isAllDay')
        if m.get('location') is not None:
            temp_model = PatchEventRequestLocation()
            self.location = temp_model.from_map(m['location'])
        if m.get('onlineMeetingInfo') is not None:
            temp_model = PatchEventRequestOnlineMeetingInfo()
            self.online_meeting_info = temp_model.from_map(m['onlineMeetingInfo'])
        if m.get('recurrence') is not None:
            temp_model = PatchEventRequestRecurrence()
            self.recurrence = temp_model.from_map(m['recurrence'])
        self.reminders = []
        if m.get('reminders') is not None:
            for k in m.get('reminders'):
                temp_model = PatchEventRequestReminders()
                self.reminders.append(temp_model.from_map(k))
        if m.get('richTextDescription') is not None:
            temp_model = PatchEventRequestRichTextDescription()
            self.rich_text_description = temp_model.from_map(m['richTextDescription'])
        if m.get('start') is not None:
            temp_model = PatchEventRequestStart()
            self.start = temp_model.from_map(m['start'])
        if m.get('summary') is not None:
            self.summary = m.get('summary')
        self.ui_configs = []
        if m.get('uiConfigs') is not None:
            for k in m.get('uiConfigs'):
                temp_model = PatchEventRequestUiConfigs()
                self.ui_configs.append(temp_model.from_map(k))
        return self


class PatchEventResponseBodyAttendees(TeaModel):
    def __init__(
        self,
        display_name: str = None,
        id: str = None,
        is_optional: bool = None,
        response_status: str = None,
        self_: bool = None,
    ):
        self.display_name = display_name
        self.id = id
        self.is_optional = is_optional
        self.response_status = response_status
        self.self_ = self_

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.id is not None:
            result['id'] = self.id
        if self.is_optional is not None:
            result['isOptional'] = self.is_optional
        if self.response_status is not None:
            result['responseStatus'] = self.response_status
        if self.self_ is not None:
            result['self'] = self.self_
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isOptional') is not None:
            self.is_optional = m.get('isOptional')
        if m.get('responseStatus') is not None:
            self.response_status = m.get('responseStatus')
        if m.get('self') is not None:
            self.self_ = m.get('self')
        return self


class PatchEventResponseBodyCardInstances(TeaModel):
    def __init__(
        self,
        out_track_id: str = None,
        scenario: str = None,
    ):
        self.out_track_id = out_track_id
        self.scenario = scenario

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.out_track_id is not None:
            result['outTrackId'] = self.out_track_id
        if self.scenario is not None:
            result['scenario'] = self.scenario
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('outTrackId') is not None:
            self.out_track_id = m.get('outTrackId')
        if m.get('scenario') is not None:
            self.scenario = m.get('scenario')
        return self


class PatchEventResponseBodyEnd(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        self.date = date
        self.date_time = date_time
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class PatchEventResponseBodyLocation(TeaModel):
    def __init__(
        self,
        display_name: str = None,
        meeting_rooms: List[str] = None,
    ):
        self.display_name = display_name
        self.meeting_rooms = meeting_rooms

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.meeting_rooms is not None:
            result['meetingRooms'] = self.meeting_rooms
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('meetingRooms') is not None:
            self.meeting_rooms = m.get('meetingRooms')
        return self


class PatchEventResponseBodyOnlineMeetingInfo(TeaModel):
    def __init__(
        self,
        conference_id: str = None,
        type: str = None,
        url: str = None,
    ):
        self.conference_id = conference_id
        self.type = type
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conference_id is not None:
            result['conferenceId'] = self.conference_id
        if self.type is not None:
            result['type'] = self.type
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conferenceId') is not None:
            self.conference_id = m.get('conferenceId')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class PatchEventResponseBodyOrganizer(TeaModel):
    def __init__(
        self,
        display_name: str = None,
        id: str = None,
        response_status: str = None,
        self_: bool = None,
    ):
        self.display_name = display_name
        self.id = id
        self.response_status = response_status
        self.self_ = self_

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.id is not None:
            result['id'] = self.id
        if self.response_status is not None:
            result['responseStatus'] = self.response_status
        if self.self_ is not None:
            result['self'] = self.self_
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('responseStatus') is not None:
            self.response_status = m.get('responseStatus')
        if m.get('self') is not None:
            self.self_ = m.get('self')
        return self


class PatchEventResponseBodyRecurrencePattern(TeaModel):
    def __init__(
        self,
        day_of_month: int = None,
        days_of_week: str = None,
        first_day_of_week: str = None,
        index: str = None,
        interval: int = None,
        type: str = None,
    ):
        self.day_of_month = day_of_month
        self.days_of_week = days_of_week
        self.first_day_of_week = first_day_of_week
        self.index = index
        self.interval = interval
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        if self.days_of_week is not None:
            result['daysOfWeek'] = self.days_of_week
        if self.first_day_of_week is not None:
            result['firstDayOfWeek'] = self.first_day_of_week
        if self.index is not None:
            result['index'] = self.index
        if self.interval is not None:
            result['interval'] = self.interval
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        if m.get('daysOfWeek') is not None:
            self.days_of_week = m.get('daysOfWeek')
        if m.get('firstDayOfWeek') is not None:
            self.first_day_of_week = m.get('firstDayOfWeek')
        if m.get('index') is not None:
            self.index = m.get('index')
        if m.get('interval') is not None:
            self.interval = m.get('interval')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class PatchEventResponseBodyRecurrenceRange(TeaModel):
    def __init__(
        self,
        end_date: str = None,
        number_of_occurrences: int = None,
        type: str = None,
    ):
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.end_date = end_date
        self.number_of_occurrences = number_of_occurrences
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.number_of_occurrences is not None:
            result['numberOfOccurrences'] = self.number_of_occurrences
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('numberOfOccurrences') is not None:
            self.number_of_occurrences = m.get('numberOfOccurrences')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class PatchEventResponseBodyRecurrence(TeaModel):
    def __init__(
        self,
        pattern: PatchEventResponseBodyRecurrencePattern = None,
        range: PatchEventResponseBodyRecurrenceRange = None,
    ):
        self.pattern = pattern
        self.range = range

    def validate(self):
        if self.pattern:
            self.pattern.validate()
        if self.range:
            self.range.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.pattern is not None:
            result['pattern'] = self.pattern.to_map()
        if self.range is not None:
            result['range'] = self.range.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pattern') is not None:
            temp_model = PatchEventResponseBodyRecurrencePattern()
            self.pattern = temp_model.from_map(m['pattern'])
        if m.get('range') is not None:
            temp_model = PatchEventResponseBodyRecurrenceRange()
            self.range = temp_model.from_map(m['range'])
        return self


class PatchEventResponseBodyReminders(TeaModel):
    def __init__(
        self,
        method: str = None,
        minutes: str = None,
    ):
        self.method = method
        self.minutes = minutes

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.method is not None:
            result['method'] = self.method
        if self.minutes is not None:
            result['minutes'] = self.minutes
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('method') is not None:
            self.method = m.get('method')
        if m.get('minutes') is not None:
            self.minutes = m.get('minutes')
        return self


class PatchEventResponseBodyRichTextDescription(TeaModel):
    def __init__(
        self,
        text: str = None,
    ):
        self.text = text

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.text is not None:
            result['text'] = self.text
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('text') is not None:
            self.text = m.get('text')
        return self


class PatchEventResponseBodyStart(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        self.date = date
        self.date_time = date_time
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class PatchEventResponseBodyUiConfigs(TeaModel):
    def __init__(
        self,
        ui_name: str = None,
        ui_status: str = None,
    ):
        # This parameter is required.
        self.ui_name = ui_name
        # This parameter is required.
        self.ui_status = ui_status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ui_name is not None:
            result['uiName'] = self.ui_name
        if self.ui_status is not None:
            result['uiStatus'] = self.ui_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('uiName') is not None:
            self.ui_name = m.get('uiName')
        if m.get('uiStatus') is not None:
            self.ui_status = m.get('uiStatus')
        return self


class PatchEventResponseBody(TeaModel):
    def __init__(
        self,
        attendees: List[PatchEventResponseBodyAttendees] = None,
        card_instances: List[PatchEventResponseBodyCardInstances] = None,
        create_time: str = None,
        description: str = None,
        end: PatchEventResponseBodyEnd = None,
        id: str = None,
        is_all_day: bool = None,
        location: PatchEventResponseBodyLocation = None,
        online_meeting_info: PatchEventResponseBodyOnlineMeetingInfo = None,
        organizer: PatchEventResponseBodyOrganizer = None,
        recurrence: PatchEventResponseBodyRecurrence = None,
        reminders: List[PatchEventResponseBodyReminders] = None,
        rich_text_description: PatchEventResponseBodyRichTextDescription = None,
        start: PatchEventResponseBodyStart = None,
        summary: str = None,
        ui_configs: List[PatchEventResponseBodyUiConfigs] = None,
        update_time: str = None,
    ):
        self.attendees = attendees
        self.card_instances = card_instances
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.create_time = create_time
        self.description = description
        self.end = end
        self.id = id
        self.is_all_day = is_all_day
        self.location = location
        self.online_meeting_info = online_meeting_info
        self.organizer = organizer
        self.recurrence = recurrence
        self.reminders = reminders
        self.rich_text_description = rich_text_description
        # This parameter is required.
        self.start = start
        self.summary = summary
        self.ui_configs = ui_configs
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.update_time = update_time

    def validate(self):
        if self.attendees:
            for k in self.attendees:
                if k:
                    k.validate()
        if self.card_instances:
            for k in self.card_instances:
                if k:
                    k.validate()
        if self.end:
            self.end.validate()
        if self.location:
            self.location.validate()
        if self.online_meeting_info:
            self.online_meeting_info.validate()
        if self.organizer:
            self.organizer.validate()
        if self.recurrence:
            self.recurrence.validate()
        if self.reminders:
            for k in self.reminders:
                if k:
                    k.validate()
        if self.rich_text_description:
            self.rich_text_description.validate()
        if self.start:
            self.start.validate()
        if self.ui_configs:
            for k in self.ui_configs:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['attendees'] = []
        if self.attendees is not None:
            for k in self.attendees:
                result['attendees'].append(k.to_map() if k else None)
        result['cardInstances'] = []
        if self.card_instances is not None:
            for k in self.card_instances:
                result['cardInstances'].append(k.to_map() if k else None)
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.description is not None:
            result['description'] = self.description
        if self.end is not None:
            result['end'] = self.end.to_map()
        if self.id is not None:
            result['id'] = self.id
        if self.is_all_day is not None:
            result['isAllDay'] = self.is_all_day
        if self.location is not None:
            result['location'] = self.location.to_map()
        if self.online_meeting_info is not None:
            result['onlineMeetingInfo'] = self.online_meeting_info.to_map()
        if self.organizer is not None:
            result['organizer'] = self.organizer.to_map()
        if self.recurrence is not None:
            result['recurrence'] = self.recurrence.to_map()
        result['reminders'] = []
        if self.reminders is not None:
            for k in self.reminders:
                result['reminders'].append(k.to_map() if k else None)
        if self.rich_text_description is not None:
            result['richTextDescription'] = self.rich_text_description.to_map()
        if self.start is not None:
            result['start'] = self.start.to_map()
        if self.summary is not None:
            result['summary'] = self.summary
        result['uiConfigs'] = []
        if self.ui_configs is not None:
            for k in self.ui_configs:
                result['uiConfigs'].append(k.to_map() if k else None)
        if self.update_time is not None:
            result['updateTime'] = self.update_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attendees = []
        if m.get('attendees') is not None:
            for k in m.get('attendees'):
                temp_model = PatchEventResponseBodyAttendees()
                self.attendees.append(temp_model.from_map(k))
        self.card_instances = []
        if m.get('cardInstances') is not None:
            for k in m.get('cardInstances'):
                temp_model = PatchEventResponseBodyCardInstances()
                self.card_instances.append(temp_model.from_map(k))
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('end') is not None:
            temp_model = PatchEventResponseBodyEnd()
            self.end = temp_model.from_map(m['end'])
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isAllDay') is not None:
            self.is_all_day = m.get('isAllDay')
        if m.get('location') is not None:
            temp_model = PatchEventResponseBodyLocation()
            self.location = temp_model.from_map(m['location'])
        if m.get('onlineMeetingInfo') is not None:
            temp_model = PatchEventResponseBodyOnlineMeetingInfo()
            self.online_meeting_info = temp_model.from_map(m['onlineMeetingInfo'])
        if m.get('organizer') is not None:
            temp_model = PatchEventResponseBodyOrganizer()
            self.organizer = temp_model.from_map(m['organizer'])
        if m.get('recurrence') is not None:
            temp_model = PatchEventResponseBodyRecurrence()
            self.recurrence = temp_model.from_map(m['recurrence'])
        self.reminders = []
        if m.get('reminders') is not None:
            for k in m.get('reminders'):
                temp_model = PatchEventResponseBodyReminders()
                self.reminders.append(temp_model.from_map(k))
        if m.get('richTextDescription') is not None:
            temp_model = PatchEventResponseBodyRichTextDescription()
            self.rich_text_description = temp_model.from_map(m['richTextDescription'])
        if m.get('start') is not None:
            temp_model = PatchEventResponseBodyStart()
            self.start = temp_model.from_map(m['start'])
        if m.get('summary') is not None:
            self.summary = m.get('summary')
        self.ui_configs = []
        if m.get('uiConfigs') is not None:
            for k in m.get('uiConfigs'):
                temp_model = PatchEventResponseBodyUiConfigs()
                self.ui_configs.append(temp_model.from_map(k))
        if m.get('updateTime') is not None:
            self.update_time = m.get('updateTime')
        return self


class PatchEventResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PatchEventResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = PatchEventResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RemoveAttendeeHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_client_token: str = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_client_token = x_client_token
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
        if self.x_client_token is not None:
            result['x-client-token'] = self.x_client_token
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-client-token') is not None:
            self.x_client_token = m.get('x-client-token')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class RemoveAttendeeRequestAttendeesToRemove(TeaModel):
    def __init__(
        self,
        id: str = None,
    ):
        self.id = id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        return self


class RemoveAttendeeRequest(TeaModel):
    def __init__(
        self,
        attendees_to_remove: List[RemoveAttendeeRequestAttendeesToRemove] = None,
    ):
        self.attendees_to_remove = attendees_to_remove

    def validate(self):
        if self.attendees_to_remove:
            for k in self.attendees_to_remove:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['attendeesToRemove'] = []
        if self.attendees_to_remove is not None:
            for k in self.attendees_to_remove:
                result['attendeesToRemove'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attendees_to_remove = []
        if m.get('attendeesToRemove') is not None:
            for k in m.get('attendeesToRemove'):
                temp_model = RemoveAttendeeRequestAttendeesToRemove()
                self.attendees_to_remove.append(temp_model.from_map(k))
        return self


class RemoveAttendeeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
    ):
        self.headers = headers
        self.status_code = status_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        return self


class RemoveMeetingRoomsHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_client_token: str = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_client_token = x_client_token
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
        if self.x_client_token is not None:
            result['x-client-token'] = self.x_client_token
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-client-token') is not None:
            self.x_client_token = m.get('x-client-token')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class RemoveMeetingRoomsRequestMeetingRoomsToRemove(TeaModel):
    def __init__(
        self,
        room_id: str = None,
    ):
        self.room_id = room_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.room_id is not None:
            result['roomId'] = self.room_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('roomId') is not None:
            self.room_id = m.get('roomId')
        return self


class RemoveMeetingRoomsRequest(TeaModel):
    def __init__(
        self,
        meeting_rooms_to_remove: List[RemoveMeetingRoomsRequestMeetingRoomsToRemove] = None,
    ):
        self.meeting_rooms_to_remove = meeting_rooms_to_remove

    def validate(self):
        if self.meeting_rooms_to_remove:
            for k in self.meeting_rooms_to_remove:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['meetingRoomsToRemove'] = []
        if self.meeting_rooms_to_remove is not None:
            for k in self.meeting_rooms_to_remove:
                result['meetingRoomsToRemove'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.meeting_rooms_to_remove = []
        if m.get('meetingRoomsToRemove') is not None:
            for k in m.get('meetingRoomsToRemove'):
                temp_model = RemoveMeetingRoomsRequestMeetingRoomsToRemove()
                self.meeting_rooms_to_remove.append(temp_model.from_map(k))
        return self


class RemoveMeetingRoomsResponseBody(TeaModel):
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


class RemoveMeetingRoomsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RemoveMeetingRoomsResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = RemoveMeetingRoomsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RespondEventHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_client_token: str = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_client_token = x_client_token
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
        if self.x_client_token is not None:
            result['x-client-token'] = self.x_client_token
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-client-token') is not None:
            self.x_client_token = m.get('x-client-token')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class RespondEventRequest(TeaModel):
    def __init__(
        self,
        response_status: str = None,
    ):
        # This parameter is required.
        self.response_status = response_status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.response_status is not None:
            result['responseStatus'] = self.response_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('responseStatus') is not None:
            self.response_status = m.get('responseStatus')
        return self


class RespondEventResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
    ):
        self.headers = headers
        self.status_code = status_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        return self


class SignInHeaders(TeaModel):
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


class SignInResponseBody(TeaModel):
    def __init__(
        self,
        check_in_time: int = None,
    ):
        self.check_in_time = check_in_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.check_in_time is not None:
            result['checkInTime'] = self.check_in_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('checkInTime') is not None:
            self.check_in_time = m.get('checkInTime')
        return self


class SignInResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SignInResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = SignInResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SignOutHeaders(TeaModel):
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


class SignOutResponseBody(TeaModel):
    def __init__(
        self,
        check_out_time: int = None,
    ):
        self.check_out_time = check_out_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.check_out_time is not None:
            result['checkOutTime'] = self.check_out_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('checkOutTime') is not None:
            self.check_out_time = m.get('checkOutTime')
        return self


class SignOutResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SignOutResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = SignOutResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SubscribeCalendarHeaders(TeaModel):
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


class SubscribeCalendarResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
    ):
        self.headers = headers
        self.status_code = status_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        return self


class TransferEventHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_client_token: str = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_client_token = x_client_token
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
        if self.x_client_token is not None:
            result['x-client-token'] = self.x_client_token
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-client-token') is not None:
            self.x_client_token = m.get('x-client-token')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class TransferEventRequest(TeaModel):
    def __init__(
        self,
        is_exit_calendar: bool = None,
        need_notify_via_o2o: bool = None,
        new_organizer_id: str = None,
    ):
        self.is_exit_calendar = is_exit_calendar
        self.need_notify_via_o2o = need_notify_via_o2o
        # This parameter is required.
        self.new_organizer_id = new_organizer_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.is_exit_calendar is not None:
            result['isExitCalendar'] = self.is_exit_calendar
        if self.need_notify_via_o2o is not None:
            result['needNotifyViaO2O'] = self.need_notify_via_o2o
        if self.new_organizer_id is not None:
            result['newOrganizerId'] = self.new_organizer_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isExitCalendar') is not None:
            self.is_exit_calendar = m.get('isExitCalendar')
        if m.get('needNotifyViaO2O') is not None:
            self.need_notify_via_o2o = m.get('needNotifyViaO2O')
        if m.get('newOrganizerId') is not None:
            self.new_organizer_id = m.get('newOrganizerId')
        return self


class TransferEventResponseBody(TeaModel):
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


class TransferEventResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: TransferEventResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = TransferEventResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UnsubscribeCalendarHeaders(TeaModel):
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


class UnsubscribeCalendarResponseBody(TeaModel):
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


class UnsubscribeCalendarResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UnsubscribeCalendarResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = UnsubscribeCalendarResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateSubscribedCalendarsHeaders(TeaModel):
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


class UpdateSubscribedCalendarsRequestSubscribeScope(TeaModel):
    def __init__(
        self,
        corp_ids: List[str] = None,
        open_conversation_ids: List[str] = None,
        union_ids: List[str] = None,
    ):
        self.corp_ids = corp_ids
        self.open_conversation_ids = open_conversation_ids
        self.union_ids = union_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_ids is not None:
            result['corpIds'] = self.corp_ids
        if self.open_conversation_ids is not None:
            result['openConversationIds'] = self.open_conversation_ids
        if self.union_ids is not None:
            result['unionIds'] = self.union_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpIds') is not None:
            self.corp_ids = m.get('corpIds')
        if m.get('openConversationIds') is not None:
            self.open_conversation_ids = m.get('openConversationIds')
        if m.get('unionIds') is not None:
            self.union_ids = m.get('unionIds')
        return self


class UpdateSubscribedCalendarsRequest(TeaModel):
    def __init__(
        self,
        description: str = None,
        managers: List[str] = None,
        name: str = None,
        subscribe_scope: UpdateSubscribedCalendarsRequestSubscribeScope = None,
    ):
        self.description = description
        self.managers = managers
        self.name = name
        self.subscribe_scope = subscribe_scope

    def validate(self):
        if self.subscribe_scope:
            self.subscribe_scope.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.description is not None:
            result['description'] = self.description
        if self.managers is not None:
            result['managers'] = self.managers
        if self.name is not None:
            result['name'] = self.name
        if self.subscribe_scope is not None:
            result['subscribeScope'] = self.subscribe_scope.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('managers') is not None:
            self.managers = m.get('managers')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('subscribeScope') is not None:
            temp_model = UpdateSubscribedCalendarsRequestSubscribeScope()
            self.subscribe_scope = temp_model.from_map(m['subscribeScope'])
        return self


class UpdateSubscribedCalendarsResponseBody(TeaModel):
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


class UpdateSubscribedCalendarsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateSubscribedCalendarsResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
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
            temp_model = UpdateSubscribedCalendarsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


