# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List, Any


class MemberModelMapValue(TeaModel):
    def __init__(
        self,
        union_id: str = None,
        conference_id: str = None,
        user_nick: str = None,
        join_time: int = None,
        leave_time: int = None,
        duration: int = None,
        attend_status: int = None,
        host: bool = None,
        co_host: bool = None,
        outer_org_member: bool = None,
        pstn_join: bool = None,
        device_type: str = None,
    ):
        self.union_id = union_id
        self.conference_id = conference_id
        self.user_nick = user_nick
        self.join_time = join_time
        self.leave_time = leave_time
        self.duration = duration
        self.attend_status = attend_status
        self.host = host
        self.co_host = co_host
        self.outer_org_member = outer_org_member
        self.pstn_join = pstn_join
        self.device_type = device_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.conference_id is not None:
            result['conferenceId'] = self.conference_id
        if self.user_nick is not None:
            result['userNick'] = self.user_nick
        if self.join_time is not None:
            result['joinTime'] = self.join_time
        if self.leave_time is not None:
            result['leaveTime'] = self.leave_time
        if self.duration is not None:
            result['duration'] = self.duration
        if self.attend_status is not None:
            result['attendStatus'] = self.attend_status
        if self.host is not None:
            result['host'] = self.host
        if self.co_host is not None:
            result['coHost'] = self.co_host
        if self.outer_org_member is not None:
            result['outerOrgMember'] = self.outer_org_member
        if self.pstn_join is not None:
            result['pstnJoin'] = self.pstn_join
        if self.device_type is not None:
            result['deviceType'] = self.device_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('conferenceId') is not None:
            self.conference_id = m.get('conferenceId')
        if m.get('userNick') is not None:
            self.user_nick = m.get('userNick')
        if m.get('joinTime') is not None:
            self.join_time = m.get('joinTime')
        if m.get('leaveTime') is not None:
            self.leave_time = m.get('leaveTime')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('attendStatus') is not None:
            self.attend_status = m.get('attendStatus')
        if m.get('host') is not None:
            self.host = m.get('host')
        if m.get('coHost') is not None:
            self.co_host = m.get('coHost')
        if m.get('outerOrgMember') is not None:
            self.outer_org_member = m.get('outerOrgMember')
        if m.get('pstnJoin') is not None:
            self.pstn_join = m.get('pstnJoin')
        if m.get('deviceType') is not None:
            self.device_type = m.get('deviceType')
        return self


class CancelScheduleConferenceHeaders(TeaModel):
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


class CancelScheduleConferenceRequest(TeaModel):
    def __init__(
        self,
        creator_union_id: str = None,
        schedule_conference_id: str = None,
    ):
        self.creator_union_id = creator_union_id
        self.schedule_conference_id = schedule_conference_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.creator_union_id is not None:
            result['creatorUnionId'] = self.creator_union_id
        if self.schedule_conference_id is not None:
            result['scheduleConferenceId'] = self.schedule_conference_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('creatorUnionId') is not None:
            self.creator_union_id = m.get('creatorUnionId')
        if m.get('scheduleConferenceId') is not None:
            self.schedule_conference_id = m.get('scheduleConferenceId')
        return self


class CancelScheduleConferenceResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class CancelScheduleConferenceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CancelScheduleConferenceResponseBody = None,
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
            temp_model = CancelScheduleConferenceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CloseVideoConferenceHeaders(TeaModel):
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


class CloseVideoConferenceRequest(TeaModel):
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


class CloseVideoConferenceResponseBody(TeaModel):
    def __init__(
        self,
        cause: str = None,
        code: int = None,
    ):
        self.cause = cause
        self.code = code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cause is not None:
            result['cause'] = self.cause
        if self.code is not None:
            result['code'] = self.code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cause') is not None:
            self.cause = m.get('cause')
        if m.get('code') is not None:
            self.code = m.get('code')
        return self


class CloseVideoConferenceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CloseVideoConferenceResponseBody = None,
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
            temp_model = CloseVideoConferenceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CohostsHeaders(TeaModel):
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


class CohostsRequestUserList(TeaModel):
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


class CohostsRequest(TeaModel):
    def __init__(
        self,
        action: str = None,
        user_list: List[CohostsRequestUserList] = None,
    ):
        self.action = action
        self.user_list = user_list

    def validate(self):
        if self.user_list:
            for k in self.user_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action is not None:
            result['action'] = self.action
        result['userList'] = []
        if self.user_list is not None:
            for k in self.user_list:
                result['userList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('action') is not None:
            self.action = m.get('action')
        self.user_list = []
        if m.get('userList') is not None:
            for k in m.get('userList'):
                temp_model = CohostsRequestUserList()
                self.user_list.append(temp_model.from_map(k))
        return self


class CohostsResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class CohostsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CohostsResponseBody = None,
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
            temp_model = CohostsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateScheduleConferenceHeaders(TeaModel):
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


class CreateScheduleConferenceRequest(TeaModel):
    def __init__(
        self,
        creator_union_id: str = None,
        end_time: int = None,
        start_time: int = None,
        title: str = None,
    ):
        self.creator_union_id = creator_union_id
        self.end_time = end_time
        self.start_time = start_time
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.creator_union_id is not None:
            result['creatorUnionId'] = self.creator_union_id
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('creatorUnionId') is not None:
            self.creator_union_id = m.get('creatorUnionId')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class CreateScheduleConferenceResponseBody(TeaModel):
    def __init__(
        self,
        phones: List[str] = None,
        request_id: str = None,
        room_code: str = None,
        schedule_conference_id: str = None,
        url: str = None,
    ):
        self.phones = phones
        self.request_id = request_id
        self.room_code = room_code
        self.schedule_conference_id = schedule_conference_id
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.phones is not None:
            result['phones'] = self.phones
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.room_code is not None:
            result['roomCode'] = self.room_code
        if self.schedule_conference_id is not None:
            result['scheduleConferenceId'] = self.schedule_conference_id
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('phones') is not None:
            self.phones = m.get('phones')
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('roomCode') is not None:
            self.room_code = m.get('roomCode')
        if m.get('scheduleConferenceId') is not None:
            self.schedule_conference_id = m.get('scheduleConferenceId')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class CreateScheduleConferenceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateScheduleConferenceResponseBody = None,
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
            temp_model = CreateScheduleConferenceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateVideoConferenceHeaders(TeaModel):
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


class CreateVideoConferenceRequest(TeaModel):
    def __init__(
        self,
        conf_title: str = None,
        invite_caller: bool = None,
        invite_user_ids: List[str] = None,
        user_id: str = None,
    ):
        self.conf_title = conf_title
        self.invite_caller = invite_caller
        self.invite_user_ids = invite_user_ids
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conf_title is not None:
            result['confTitle'] = self.conf_title
        if self.invite_caller is not None:
            result['inviteCaller'] = self.invite_caller
        if self.invite_user_ids is not None:
            result['inviteUserIds'] = self.invite_user_ids
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('confTitle') is not None:
            self.conf_title = m.get('confTitle')
        if m.get('inviteCaller') is not None:
            self.invite_caller = m.get('inviteCaller')
        if m.get('inviteUserIds') is not None:
            self.invite_user_ids = m.get('inviteUserIds')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CreateVideoConferenceResponseBody(TeaModel):
    def __init__(
        self,
        conference_id: str = None,
        conference_password: str = None,
        external_link_url: str = None,
        host_password: str = None,
        phone_numbers: List[str] = None,
        room_code: str = None,
    ):
        self.conference_id = conference_id
        self.conference_password = conference_password
        self.external_link_url = external_link_url
        self.host_password = host_password
        self.phone_numbers = phone_numbers
        self.room_code = room_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conference_id is not None:
            result['conferenceId'] = self.conference_id
        if self.conference_password is not None:
            result['conferencePassword'] = self.conference_password
        if self.external_link_url is not None:
            result['externalLinkUrl'] = self.external_link_url
        if self.host_password is not None:
            result['hostPassword'] = self.host_password
        if self.phone_numbers is not None:
            result['phoneNumbers'] = self.phone_numbers
        if self.room_code is not None:
            result['roomCode'] = self.room_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conferenceId') is not None:
            self.conference_id = m.get('conferenceId')
        if m.get('conferencePassword') is not None:
            self.conference_password = m.get('conferencePassword')
        if m.get('externalLinkUrl') is not None:
            self.external_link_url = m.get('externalLinkUrl')
        if m.get('hostPassword') is not None:
            self.host_password = m.get('hostPassword')
        if m.get('phoneNumbers') is not None:
            self.phone_numbers = m.get('phoneNumbers')
        if m.get('roomCode') is not None:
            self.room_code = m.get('roomCode')
        return self


class CreateVideoConferenceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateVideoConferenceResponseBody = None,
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
            temp_model = CreateVideoConferenceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class FocusHeaders(TeaModel):
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


class FocusRequest(TeaModel):
    def __init__(
        self,
        action: str = None,
        union_id: str = None,
    ):
        self.action = action
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action is not None:
            result['action'] = self.action
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('action') is not None:
            self.action = m.get('action')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class FocusResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class FocusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: FocusResponseBody = None,
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
            temp_model = FocusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetConfDataByConferenceIdHeaders(TeaModel):
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


class GetConfDataByConferenceIdRequest(TeaModel):
    def __init__(
        self,
        real_data: bool = None,
    ):
        self.real_data = real_data

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.real_data is not None:
            result['realData'] = self.real_data
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('realData') is not None:
            self.real_data = m.get('realData')
        return self


class GetConfDataByConferenceIdResponseBody(TeaModel):
    def __init__(
        self,
        conference_id: str = None,
        creator_id: str = None,
        creator_nick: str = None,
        dept_name: str = None,
        end_time: int = None,
        free_type: str = None,
        scene: str = None,
        start_time: int = None,
        time_length: int = None,
        title: str = None,
        user_count: int = None,
    ):
        self.conference_id = conference_id
        self.creator_id = creator_id
        self.creator_nick = creator_nick
        self.dept_name = dept_name
        self.end_time = end_time
        self.free_type = free_type
        self.scene = scene
        self.start_time = start_time
        self.time_length = time_length
        self.title = title
        self.user_count = user_count

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conference_id is not None:
            result['conferenceId'] = self.conference_id
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.creator_nick is not None:
            result['creatorNick'] = self.creator_nick
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.free_type is not None:
            result['freeType'] = self.free_type
        if self.scene is not None:
            result['scene'] = self.scene
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.time_length is not None:
            result['timeLength'] = self.time_length
        if self.title is not None:
            result['title'] = self.title
        if self.user_count is not None:
            result['userCount'] = self.user_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conferenceId') is not None:
            self.conference_id = m.get('conferenceId')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('creatorNick') is not None:
            self.creator_nick = m.get('creatorNick')
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('freeType') is not None:
            self.free_type = m.get('freeType')
        if m.get('scene') is not None:
            self.scene = m.get('scene')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('timeLength') is not None:
            self.time_length = m.get('timeLength')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('userCount') is not None:
            self.user_count = m.get('userCount')
        return self


class GetConfDataByConferenceIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetConfDataByConferenceIdResponseBody = None,
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
            temp_model = GetConfDataByConferenceIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetConfDetailDataHeaders(TeaModel):
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


class GetConfDetailDataRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        nick: str = None,
    ):
        self.max_results = max_results
        self.next_token = next_token
        self.nick = nick

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
        if self.nick is not None:
            result['nick'] = self.nick
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('nick') is not None:
            self.nick = m.get('nick')
        return self


class GetConfDetailDataResponseBodyList(TeaModel):
    def __init__(
        self,
        belong_org: str = None,
        conference_id: str = None,
        device_type: str = None,
        duration: int = None,
        join_time: int = None,
        leave_time: int = None,
        network_quality: str = None,
        nick: str = None,
        role: str = None,
        session_id: str = None,
        status: str = None,
        union_id: str = None,
        version: str = None,
    ):
        self.belong_org = belong_org
        self.conference_id = conference_id
        self.device_type = device_type
        self.duration = duration
        self.join_time = join_time
        self.leave_time = leave_time
        self.network_quality = network_quality
        self.nick = nick
        self.role = role
        self.session_id = session_id
        self.status = status
        self.union_id = union_id
        self.version = version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.belong_org is not None:
            result['belongOrg'] = self.belong_org
        if self.conference_id is not None:
            result['conferenceId'] = self.conference_id
        if self.device_type is not None:
            result['deviceType'] = self.device_type
        if self.duration is not None:
            result['duration'] = self.duration
        if self.join_time is not None:
            result['joinTime'] = self.join_time
        if self.leave_time is not None:
            result['leaveTime'] = self.leave_time
        if self.network_quality is not None:
            result['networkQuality'] = self.network_quality
        if self.nick is not None:
            result['nick'] = self.nick
        if self.role is not None:
            result['role'] = self.role
        if self.session_id is not None:
            result['sessionId'] = self.session_id
        if self.status is not None:
            result['status'] = self.status
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('belongOrg') is not None:
            self.belong_org = m.get('belongOrg')
        if m.get('conferenceId') is not None:
            self.conference_id = m.get('conferenceId')
        if m.get('deviceType') is not None:
            self.device_type = m.get('deviceType')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('joinTime') is not None:
            self.join_time = m.get('joinTime')
        if m.get('leaveTime') is not None:
            self.leave_time = m.get('leaveTime')
        if m.get('networkQuality') is not None:
            self.network_quality = m.get('networkQuality')
        if m.get('nick') is not None:
            self.nick = m.get('nick')
        if m.get('role') is not None:
            self.role = m.get('role')
        if m.get('sessionId') is not None:
            self.session_id = m.get('sessionId')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class GetConfDetailDataResponseBody(TeaModel):
    def __init__(
        self,
        list: List[GetConfDetailDataResponseBodyList] = None,
        next_token: str = None,
    ):
        self.list = list
        self.next_token = next_token

    def validate(self):
        if self.list:
            for k in self.list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = GetConfDetailDataResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class GetConfDetailDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetConfDetailDataResponseBody = None,
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
            temp_model = GetConfDetailDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetHistoryConfDataListHeaders(TeaModel):
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


class GetHistoryConfDataListRequest(TeaModel):
    def __init__(
        self,
        creator_nike: str = None,
        end_time: int = None,
        free_type: str = None,
        max_results: int = None,
        next_token: str = None,
        real_data: bool = None,
        scene: str = None,
        start_time: int = None,
        title: str = None,
    ):
        self.creator_nike = creator_nike
        self.end_time = end_time
        self.free_type = free_type
        self.max_results = max_results
        self.next_token = next_token
        self.real_data = real_data
        self.scene = scene
        self.start_time = start_time
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.creator_nike is not None:
            result['creatorNike'] = self.creator_nike
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.free_type is not None:
            result['freeType'] = self.free_type
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.real_data is not None:
            result['realData'] = self.real_data
        if self.scene is not None:
            result['scene'] = self.scene
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('creatorNike') is not None:
            self.creator_nike = m.get('creatorNike')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('freeType') is not None:
            self.free_type = m.get('freeType')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('realData') is not None:
            self.real_data = m.get('realData')
        if m.get('scene') is not None:
            self.scene = m.get('scene')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class GetHistoryConfDataListResponseBodyList(TeaModel):
    def __init__(
        self,
        conference_id: str = None,
        creator_id: str = None,
        creator_nick: str = None,
        dept_name: str = None,
        end_time: int = None,
        free_type: str = None,
        scene: str = None,
        start_time: int = None,
        time_length: int = None,
        title: str = None,
        user_count: int = None,
    ):
        self.conference_id = conference_id
        self.creator_id = creator_id
        self.creator_nick = creator_nick
        self.dept_name = dept_name
        self.end_time = end_time
        self.free_type = free_type
        self.scene = scene
        self.start_time = start_time
        self.time_length = time_length
        self.title = title
        self.user_count = user_count

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conference_id is not None:
            result['conferenceId'] = self.conference_id
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.creator_nick is not None:
            result['creatorNick'] = self.creator_nick
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.free_type is not None:
            result['freeType'] = self.free_type
        if self.scene is not None:
            result['scene'] = self.scene
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.time_length is not None:
            result['timeLength'] = self.time_length
        if self.title is not None:
            result['title'] = self.title
        if self.user_count is not None:
            result['userCount'] = self.user_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conferenceId') is not None:
            self.conference_id = m.get('conferenceId')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('creatorNick') is not None:
            self.creator_nick = m.get('creatorNick')
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('freeType') is not None:
            self.free_type = m.get('freeType')
        if m.get('scene') is not None:
            self.scene = m.get('scene')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('timeLength') is not None:
            self.time_length = m.get('timeLength')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('userCount') is not None:
            self.user_count = m.get('userCount')
        return self


class GetHistoryConfDataListResponseBody(TeaModel):
    def __init__(
        self,
        list: List[GetHistoryConfDataListResponseBodyList] = None,
        next_token: str = None,
    ):
        self.list = list
        self.next_token = next_token

    def validate(self):
        if self.list:
            for k in self.list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = GetHistoryConfDataListResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class GetHistoryConfDataListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetHistoryConfDataListResponseBody = None,
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
            temp_model = GetHistoryConfDataListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetUserMetricDataHeaders(TeaModel):
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


class GetUserMetricDataRequest(TeaModel):
    def __init__(
        self,
        begin_time: int = None,
        end_time: int = None,
        union_id: str = None,
    ):
        self.begin_time = begin_time
        self.end_time = end_time
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.begin_time is not None:
            result['beginTime'] = self.begin_time
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('beginTime') is not None:
            self.begin_time = m.get('beginTime')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetUserMetricDataResponseBodyMetricDataList(TeaModel):
    def __init__(
        self,
        audio_play_level: str = None,
        audio_rec_level: str = None,
        audio_recv_bit_rate: str = None,
        audio_send_bit_rate: str = None,
        camera_recv_bit_rate: str = None,
        camera_recv_frame: str = None,
        camera_recv_resolution_actual: str = None,
        camera_send_bit_rate: str = None,
        camera_send_frame: str = None,
        camera_send_resolution_actual: str = None,
        lost_rate: str = None,
        recv_bit_rate: str = None,
        round_trip_time: str = None,
        screen_recv_bit_rate: str = None,
        screen_recv_frame: str = None,
        screen_recv_resolution_actual: str = None,
        screen_send_bit_rate: str = None,
        screen_send_frame: str = None,
        screen_send_resolution_actual: str = None,
        send_bit_rate: str = None,
        timestamp: int = None,
    ):
        self.audio_play_level = audio_play_level
        self.audio_rec_level = audio_rec_level
        self.audio_recv_bit_rate = audio_recv_bit_rate
        self.audio_send_bit_rate = audio_send_bit_rate
        self.camera_recv_bit_rate = camera_recv_bit_rate
        self.camera_recv_frame = camera_recv_frame
        self.camera_recv_resolution_actual = camera_recv_resolution_actual
        self.camera_send_bit_rate = camera_send_bit_rate
        self.camera_send_frame = camera_send_frame
        self.camera_send_resolution_actual = camera_send_resolution_actual
        self.lost_rate = lost_rate
        self.recv_bit_rate = recv_bit_rate
        self.round_trip_time = round_trip_time
        self.screen_recv_bit_rate = screen_recv_bit_rate
        self.screen_recv_frame = screen_recv_frame
        self.screen_recv_resolution_actual = screen_recv_resolution_actual
        self.screen_send_bit_rate = screen_send_bit_rate
        self.screen_send_frame = screen_send_frame
        self.screen_send_resolution_actual = screen_send_resolution_actual
        self.send_bit_rate = send_bit_rate
        self.timestamp = timestamp

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.audio_play_level is not None:
            result['audioPlayLevel'] = self.audio_play_level
        if self.audio_rec_level is not None:
            result['audioRecLevel'] = self.audio_rec_level
        if self.audio_recv_bit_rate is not None:
            result['audioRecvBitRate'] = self.audio_recv_bit_rate
        if self.audio_send_bit_rate is not None:
            result['audioSendBitRate'] = self.audio_send_bit_rate
        if self.camera_recv_bit_rate is not None:
            result['cameraRecvBitRate'] = self.camera_recv_bit_rate
        if self.camera_recv_frame is not None:
            result['cameraRecvFrame'] = self.camera_recv_frame
        if self.camera_recv_resolution_actual is not None:
            result['cameraRecvResolutionActual'] = self.camera_recv_resolution_actual
        if self.camera_send_bit_rate is not None:
            result['cameraSendBitRate'] = self.camera_send_bit_rate
        if self.camera_send_frame is not None:
            result['cameraSendFrame'] = self.camera_send_frame
        if self.camera_send_resolution_actual is not None:
            result['cameraSendResolutionActual'] = self.camera_send_resolution_actual
        if self.lost_rate is not None:
            result['lostRate'] = self.lost_rate
        if self.recv_bit_rate is not None:
            result['recvBitRate'] = self.recv_bit_rate
        if self.round_trip_time is not None:
            result['roundTripTime'] = self.round_trip_time
        if self.screen_recv_bit_rate is not None:
            result['screenRecvBitRate'] = self.screen_recv_bit_rate
        if self.screen_recv_frame is not None:
            result['screenRecvFrame'] = self.screen_recv_frame
        if self.screen_recv_resolution_actual is not None:
            result['screenRecvResolutionActual'] = self.screen_recv_resolution_actual
        if self.screen_send_bit_rate is not None:
            result['screenSendBitRate'] = self.screen_send_bit_rate
        if self.screen_send_frame is not None:
            result['screenSendFrame'] = self.screen_send_frame
        if self.screen_send_resolution_actual is not None:
            result['screenSendResolutionActual'] = self.screen_send_resolution_actual
        if self.send_bit_rate is not None:
            result['sendBitRate'] = self.send_bit_rate
        if self.timestamp is not None:
            result['timestamp'] = self.timestamp
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('audioPlayLevel') is not None:
            self.audio_play_level = m.get('audioPlayLevel')
        if m.get('audioRecLevel') is not None:
            self.audio_rec_level = m.get('audioRecLevel')
        if m.get('audioRecvBitRate') is not None:
            self.audio_recv_bit_rate = m.get('audioRecvBitRate')
        if m.get('audioSendBitRate') is not None:
            self.audio_send_bit_rate = m.get('audioSendBitRate')
        if m.get('cameraRecvBitRate') is not None:
            self.camera_recv_bit_rate = m.get('cameraRecvBitRate')
        if m.get('cameraRecvFrame') is not None:
            self.camera_recv_frame = m.get('cameraRecvFrame')
        if m.get('cameraRecvResolutionActual') is not None:
            self.camera_recv_resolution_actual = m.get('cameraRecvResolutionActual')
        if m.get('cameraSendBitRate') is not None:
            self.camera_send_bit_rate = m.get('cameraSendBitRate')
        if m.get('cameraSendFrame') is not None:
            self.camera_send_frame = m.get('cameraSendFrame')
        if m.get('cameraSendResolutionActual') is not None:
            self.camera_send_resolution_actual = m.get('cameraSendResolutionActual')
        if m.get('lostRate') is not None:
            self.lost_rate = m.get('lostRate')
        if m.get('recvBitRate') is not None:
            self.recv_bit_rate = m.get('recvBitRate')
        if m.get('roundTripTime') is not None:
            self.round_trip_time = m.get('roundTripTime')
        if m.get('screenRecvBitRate') is not None:
            self.screen_recv_bit_rate = m.get('screenRecvBitRate')
        if m.get('screenRecvFrame') is not None:
            self.screen_recv_frame = m.get('screenRecvFrame')
        if m.get('screenRecvResolutionActual') is not None:
            self.screen_recv_resolution_actual = m.get('screenRecvResolutionActual')
        if m.get('screenSendBitRate') is not None:
            self.screen_send_bit_rate = m.get('screenSendBitRate')
        if m.get('screenSendFrame') is not None:
            self.screen_send_frame = m.get('screenSendFrame')
        if m.get('screenSendResolutionActual') is not None:
            self.screen_send_resolution_actual = m.get('screenSendResolutionActual')
        if m.get('sendBitRate') is not None:
            self.send_bit_rate = m.get('sendBitRate')
        if m.get('timestamp') is not None:
            self.timestamp = m.get('timestamp')
        return self


class GetUserMetricDataResponseBody(TeaModel):
    def __init__(
        self,
        metric_data_list: List[GetUserMetricDataResponseBodyMetricDataList] = None,
    ):
        self.metric_data_list = metric_data_list

    def validate(self):
        if self.metric_data_list:
            for k in self.metric_data_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['metricDataList'] = []
        if self.metric_data_list is not None:
            for k in self.metric_data_list:
                result['metricDataList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.metric_data_list = []
        if m.get('metricDataList') is not None:
            for k in m.get('metricDataList'):
                temp_model = GetUserMetricDataResponseBodyMetricDataList()
                self.metric_data_list.append(temp_model.from_map(k))
        return self


class GetUserMetricDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetUserMetricDataResponseBody = None,
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
            temp_model = GetUserMetricDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class InviteUsersHeaders(TeaModel):
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


class InviteUsersRequestInviteeList(TeaModel):
    def __init__(
        self,
        nick: str = None,
        union_id: str = None,
    ):
        self.nick = nick
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.nick is not None:
            result['nick'] = self.nick
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nick') is not None:
            self.nick = m.get('nick')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class InviteUsersRequest(TeaModel):
    def __init__(
        self,
        invitee_list: List[InviteUsersRequestInviteeList] = None,
        union_id: str = None,
    ):
        self.invitee_list = invitee_list
        self.union_id = union_id

    def validate(self):
        if self.invitee_list:
            for k in self.invitee_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['inviteeList'] = []
        if self.invitee_list is not None:
            for k in self.invitee_list:
                result['inviteeList'].append(k.to_map() if k else None)
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.invitee_list = []
        if m.get('inviteeList') is not None:
            for k in m.get('inviteeList'):
                temp_model = InviteUsersRequestInviteeList()
                self.invitee_list.append(temp_model.from_map(k))
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class InviteUsersResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class InviteUsersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: InviteUsersResponseBody = None,
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
            temp_model = InviteUsersResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class KickMembersHeaders(TeaModel):
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


class KickMembersRequestUserList(TeaModel):
    def __init__(
        self,
        participant_id: str = None,
        union_id: str = None,
    ):
        self.participant_id = participant_id
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.participant_id is not None:
            result['participantId'] = self.participant_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('participantId') is not None:
            self.participant_id = m.get('participantId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class KickMembersRequest(TeaModel):
    def __init__(
        self,
        forbidden_rejoin: bool = None,
        user_list: List[KickMembersRequestUserList] = None,
    ):
        self.forbidden_rejoin = forbidden_rejoin
        self.user_list = user_list

    def validate(self):
        if self.user_list:
            for k in self.user_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.forbidden_rejoin is not None:
            result['forbiddenRejoin'] = self.forbidden_rejoin
        result['userList'] = []
        if self.user_list is not None:
            for k in self.user_list:
                result['userList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('forbiddenRejoin') is not None:
            self.forbidden_rejoin = m.get('forbiddenRejoin')
        self.user_list = []
        if m.get('userList') is not None:
            for k in m.get('userList'):
                temp_model = KickMembersRequestUserList()
                self.user_list.append(temp_model.from_map(k))
        return self


class KickMembersResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class KickMembersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: KickMembersResponseBody = None,
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
            temp_model = KickMembersResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class MuteAllHeaders(TeaModel):
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


class MuteAllRequest(TeaModel):
    def __init__(
        self,
        action: str = None,
        force_mute: bool = None,
    ):
        self.action = action
        self.force_mute = force_mute

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action is not None:
            result['action'] = self.action
        if self.force_mute is not None:
            result['forceMute'] = self.force_mute
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('action') is not None:
            self.action = m.get('action')
        if m.get('forceMute') is not None:
            self.force_mute = m.get('forceMute')
        return self


class MuteAllResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class MuteAllResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: MuteAllResponseBody = None,
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
            temp_model = MuteAllResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class MuteMembersHeaders(TeaModel):
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


class MuteMembersRequestUserList(TeaModel):
    def __init__(
        self,
        participant_id: str = None,
        union_id: str = None,
    ):
        self.participant_id = participant_id
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.participant_id is not None:
            result['participantId'] = self.participant_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('participantId') is not None:
            self.participant_id = m.get('participantId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class MuteMembersRequest(TeaModel):
    def __init__(
        self,
        action: str = None,
        user_list: List[MuteMembersRequestUserList] = None,
    ):
        self.action = action
        self.user_list = user_list

    def validate(self):
        if self.user_list:
            for k in self.user_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action is not None:
            result['action'] = self.action
        result['userList'] = []
        if self.user_list is not None:
            for k in self.user_list:
                result['userList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('action') is not None:
            self.action = m.get('action')
        self.user_list = []
        if m.get('userList') is not None:
            for k in m.get('userList'):
                temp_model = MuteMembersRequestUserList()
                self.user_list.append(temp_model.from_map(k))
        return self


class MuteMembersResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class MuteMembersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: MuteMembersResponseBody = None,
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
            temp_model = MuteMembersResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryCloudRecordTextHeaders(TeaModel):
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


class QueryCloudRecordTextRequest(TeaModel):
    def __init__(
        self,
        direction: str = None,
        max_results: int = None,
        next_token: int = None,
        start_time: int = None,
        union_id: str = None,
    ):
        self.direction = direction
        self.max_results = max_results
        self.next_token = next_token
        self.start_time = start_time
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.direction is not None:
            result['direction'] = self.direction
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('direction') is not None:
            self.direction = m.get('direction')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        start_time: int = None,
        word: str = None,
        word_id: str = None,
    ):
        self.end_time = end_time
        self.start_time = start_time
        self.word = word
        self.word_id = word_id

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
        if self.word is not None:
            result['word'] = self.word
        if self.word_id is not None:
            result['wordId'] = self.word_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('word') is not None:
            self.word = m.get('word')
        if m.get('wordId') is not None:
            self.word_id = m.get('wordId')
        return self


class QueryCloudRecordTextResponseBodyParagraphListSentenceList(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        sentence: str = None,
        start_time: int = None,
        union_id: str = None,
        word_list: List[QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList] = None,
    ):
        self.end_time = end_time
        self.sentence = sentence
        self.start_time = start_time
        self.union_id = union_id
        self.word_list = word_list

    def validate(self):
        if self.word_list:
            for k in self.word_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.sentence is not None:
            result['sentence'] = self.sentence
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.union_id is not None:
            result['unionId'] = self.union_id
        result['wordList'] = []
        if self.word_list is not None:
            for k in self.word_list:
                result['wordList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('sentence') is not None:
            self.sentence = m.get('sentence')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        self.word_list = []
        if m.get('wordList') is not None:
            for k in m.get('wordList'):
                temp_model = QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList()
                self.word_list.append(temp_model.from_map(k))
        return self


class QueryCloudRecordTextResponseBodyParagraphList(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        next_ttoken: int = None,
        nick_name: str = None,
        paragraph: str = None,
        record_id: int = None,
        sentence_list: List[QueryCloudRecordTextResponseBodyParagraphListSentenceList] = None,
        start_time: int = None,
        status: int = None,
        union_id: str = None,
    ):
        self.end_time = end_time
        self.next_ttoken = next_ttoken
        self.nick_name = nick_name
        self.paragraph = paragraph
        self.record_id = record_id
        self.sentence_list = sentence_list
        self.start_time = start_time
        self.status = status
        self.union_id = union_id

    def validate(self):
        if self.sentence_list:
            for k in self.sentence_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.next_ttoken is not None:
            result['nextTtoken'] = self.next_ttoken
        if self.nick_name is not None:
            result['nickName'] = self.nick_name
        if self.paragraph is not None:
            result['paragraph'] = self.paragraph
        if self.record_id is not None:
            result['recordId'] = self.record_id
        result['sentenceList'] = []
        if self.sentence_list is not None:
            for k in self.sentence_list:
                result['sentenceList'].append(k.to_map() if k else None)
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.status is not None:
            result['status'] = self.status
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('nextTtoken') is not None:
            self.next_ttoken = m.get('nextTtoken')
        if m.get('nickName') is not None:
            self.nick_name = m.get('nickName')
        if m.get('paragraph') is not None:
            self.paragraph = m.get('paragraph')
        if m.get('recordId') is not None:
            self.record_id = m.get('recordId')
        self.sentence_list = []
        if m.get('sentenceList') is not None:
            for k in m.get('sentenceList'):
                temp_model = QueryCloudRecordTextResponseBodyParagraphListSentenceList()
                self.sentence_list.append(temp_model.from_map(k))
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class QueryCloudRecordTextResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        paragraph_list: List[QueryCloudRecordTextResponseBodyParagraphList] = None,
    ):
        self.has_more = has_more
        self.paragraph_list = paragraph_list

    def validate(self):
        if self.paragraph_list:
            for k in self.paragraph_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['paragraphList'] = []
        if self.paragraph_list is not None:
            for k in self.paragraph_list:
                result['paragraphList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.paragraph_list = []
        if m.get('paragraphList') is not None:
            for k in m.get('paragraphList'):
                temp_model = QueryCloudRecordTextResponseBodyParagraphList()
                self.paragraph_list.append(temp_model.from_map(k))
        return self


class QueryCloudRecordTextResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryCloudRecordTextResponseBody = None,
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
            temp_model = QueryCloudRecordTextResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryCloudRecordVideoHeaders(TeaModel):
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


class QueryCloudRecordVideoRequest(TeaModel):
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


class QueryCloudRecordVideoResponseBodyVideoList(TeaModel):
    def __init__(
        self,
        duration: int = None,
        end_time: int = None,
        file_size: int = None,
        media_id: str = None,
        record_id: str = None,
        record_type: int = None,
        region_id: str = None,
        start_time: int = None,
        union_id: str = None,
    ):
        self.duration = duration
        self.end_time = end_time
        self.file_size = file_size
        self.media_id = media_id
        self.record_id = record_id
        self.record_type = record_type
        self.region_id = region_id
        self.start_time = start_time
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.duration is not None:
            result['duration'] = self.duration
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.file_size is not None:
            result['fileSize'] = self.file_size
        if self.media_id is not None:
            result['mediaId'] = self.media_id
        if self.record_id is not None:
            result['recordId'] = self.record_id
        if self.record_type is not None:
            result['recordType'] = self.record_type
        if self.region_id is not None:
            result['regionId'] = self.region_id
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('fileSize') is not None:
            self.file_size = m.get('fileSize')
        if m.get('mediaId') is not None:
            self.media_id = m.get('mediaId')
        if m.get('recordId') is not None:
            self.record_id = m.get('recordId')
        if m.get('recordType') is not None:
            self.record_type = m.get('recordType')
        if m.get('regionId') is not None:
            self.region_id = m.get('regionId')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class QueryCloudRecordVideoResponseBody(TeaModel):
    def __init__(
        self,
        video_list: List[QueryCloudRecordVideoResponseBodyVideoList] = None,
    ):
        self.video_list = video_list

    def validate(self):
        if self.video_list:
            for k in self.video_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['videoList'] = []
        if self.video_list is not None:
            for k in self.video_list:
                result['videoList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.video_list = []
        if m.get('videoList') is not None:
            for k in m.get('videoList'):
                temp_model = QueryCloudRecordVideoResponseBodyVideoList()
                self.video_list.append(temp_model.from_map(k))
        return self


class QueryCloudRecordVideoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryCloudRecordVideoResponseBody = None,
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
            temp_model = QueryCloudRecordVideoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryCloudRecordVideoPlayInfoHeaders(TeaModel):
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


class QueryCloudRecordVideoPlayInfoRequest(TeaModel):
    def __init__(
        self,
        media_id: str = None,
        region_id: str = None,
        union_id: str = None,
    ):
        self.media_id = media_id
        self.region_id = region_id
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.media_id is not None:
            result['mediaId'] = self.media_id
        if self.region_id is not None:
            result['regionId'] = self.region_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('mediaId') is not None:
            self.media_id = m.get('mediaId')
        if m.get('regionId') is not None:
            self.region_id = m.get('regionId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class QueryCloudRecordVideoPlayInfoResponseBody(TeaModel):
    def __init__(
        self,
        duration: int = None,
        file_size: int = None,
        mp_4file_url: str = None,
        play_url: str = None,
        status: int = None,
    ):
        self.duration = duration
        self.file_size = file_size
        self.mp_4file_url = mp_4file_url
        self.play_url = play_url
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.duration is not None:
            result['duration'] = self.duration
        if self.file_size is not None:
            result['fileSize'] = self.file_size
        if self.mp_4file_url is not None:
            result['mp4FileUrl'] = self.mp_4file_url
        if self.play_url is not None:
            result['playUrl'] = self.play_url
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('fileSize') is not None:
            self.file_size = m.get('fileSize')
        if m.get('mp4FileUrl') is not None:
            self.mp_4file_url = m.get('mp4FileUrl')
        if m.get('playUrl') is not None:
            self.play_url = m.get('playUrl')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class QueryCloudRecordVideoPlayInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryCloudRecordVideoPlayInfoResponseBody = None,
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
            temp_model = QueryCloudRecordVideoPlayInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryConferenceInfoHeaders(TeaModel):
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


class QueryConferenceInfoResponseBodyConfInfo(TeaModel):
    def __init__(
        self,
        active_num: int = None,
        attend_num: int = None,
        conf_duration: int = None,
        conference_id: str = None,
        creator_id: str = None,
        creator_nick: str = None,
        end_time: int = None,
        external_link_url: str = None,
        invited_num: int = None,
        room_code: str = None,
        start_time: int = None,
        status: int = None,
        title: str = None,
    ):
        self.active_num = active_num
        self.attend_num = attend_num
        self.conf_duration = conf_duration
        self.conference_id = conference_id
        self.creator_id = creator_id
        self.creator_nick = creator_nick
        self.end_time = end_time
        self.external_link_url = external_link_url
        self.invited_num = invited_num
        self.room_code = room_code
        self.start_time = start_time
        self.status = status
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.active_num is not None:
            result['activeNum'] = self.active_num
        if self.attend_num is not None:
            result['attendNum'] = self.attend_num
        if self.conf_duration is not None:
            result['confDuration'] = self.conf_duration
        if self.conference_id is not None:
            result['conferenceId'] = self.conference_id
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.creator_nick is not None:
            result['creatorNick'] = self.creator_nick
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.external_link_url is not None:
            result['externalLinkUrl'] = self.external_link_url
        if self.invited_num is not None:
            result['invitedNum'] = self.invited_num
        if self.room_code is not None:
            result['roomCode'] = self.room_code
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.status is not None:
            result['status'] = self.status
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activeNum') is not None:
            self.active_num = m.get('activeNum')
        if m.get('attendNum') is not None:
            self.attend_num = m.get('attendNum')
        if m.get('confDuration') is not None:
            self.conf_duration = m.get('confDuration')
        if m.get('conferenceId') is not None:
            self.conference_id = m.get('conferenceId')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('creatorNick') is not None:
            self.creator_nick = m.get('creatorNick')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('externalLinkUrl') is not None:
            self.external_link_url = m.get('externalLinkUrl')
        if m.get('invitedNum') is not None:
            self.invited_num = m.get('invitedNum')
        if m.get('roomCode') is not None:
            self.room_code = m.get('roomCode')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class QueryConferenceInfoResponseBody(TeaModel):
    def __init__(
        self,
        conf_info: QueryConferenceInfoResponseBodyConfInfo = None,
    ):
        self.conf_info = conf_info

    def validate(self):
        if self.conf_info:
            self.conf_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conf_info is not None:
            result['confInfo'] = self.conf_info.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('confInfo') is not None:
            temp_model = QueryConferenceInfoResponseBodyConfInfo()
            self.conf_info = temp_model.from_map(m['confInfo'])
        return self


class QueryConferenceInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryConferenceInfoResponseBody = None,
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
            temp_model = QueryConferenceInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryConferenceInfoBatchHeaders(TeaModel):
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


class QueryConferenceInfoBatchRequest(TeaModel):
    def __init__(
        self,
        conference_id_list: List[str] = None,
    ):
        self.conference_id_list = conference_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conference_id_list is not None:
            result['conferenceIdList'] = self.conference_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conferenceIdList') is not None:
            self.conference_id_list = m.get('conferenceIdList')
        return self


class QueryConferenceInfoBatchResponseBodyInfosUserList(TeaModel):
    def __init__(
        self,
        attend_status: int = None,
        camera_status: int = None,
        mic_status: int = None,
        nick: str = None,
        reject_description: str = None,
        user_id: str = None,
    ):
        self.attend_status = attend_status
        self.camera_status = camera_status
        self.mic_status = mic_status
        self.nick = nick
        self.reject_description = reject_description
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.attend_status is not None:
            result['attendStatus'] = self.attend_status
        if self.camera_status is not None:
            result['cameraStatus'] = self.camera_status
        if self.mic_status is not None:
            result['micStatus'] = self.mic_status
        if self.nick is not None:
            result['nick'] = self.nick
        if self.reject_description is not None:
            result['rejectDescription'] = self.reject_description
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('attendStatus') is not None:
            self.attend_status = m.get('attendStatus')
        if m.get('cameraStatus') is not None:
            self.camera_status = m.get('cameraStatus')
        if m.get('micStatus') is not None:
            self.mic_status = m.get('micStatus')
        if m.get('nick') is not None:
            self.nick = m.get('nick')
        if m.get('rejectDescription') is not None:
            self.reject_description = m.get('rejectDescription')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryConferenceInfoBatchResponseBodyInfos(TeaModel):
    def __init__(
        self,
        conference_id: str = None,
        media_status: int = None,
        start_time: int = None,
        status: int = None,
        title: str = None,
        user_list: List[QueryConferenceInfoBatchResponseBodyInfosUserList] = None,
    ):
        self.conference_id = conference_id
        self.media_status = media_status
        self.start_time = start_time
        self.status = status
        self.title = title
        self.user_list = user_list

    def validate(self):
        if self.user_list:
            for k in self.user_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conference_id is not None:
            result['conferenceId'] = self.conference_id
        if self.media_status is not None:
            result['mediaStatus'] = self.media_status
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.status is not None:
            result['status'] = self.status
        if self.title is not None:
            result['title'] = self.title
        result['userList'] = []
        if self.user_list is not None:
            for k in self.user_list:
                result['userList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conferenceId') is not None:
            self.conference_id = m.get('conferenceId')
        if m.get('mediaStatus') is not None:
            self.media_status = m.get('mediaStatus')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('title') is not None:
            self.title = m.get('title')
        self.user_list = []
        if m.get('userList') is not None:
            for k in m.get('userList'):
                temp_model = QueryConferenceInfoBatchResponseBodyInfosUserList()
                self.user_list.append(temp_model.from_map(k))
        return self


class QueryConferenceInfoBatchResponseBody(TeaModel):
    def __init__(
        self,
        infos: List[QueryConferenceInfoBatchResponseBodyInfos] = None,
    ):
        self.infos = infos

    def validate(self):
        if self.infos:
            for k in self.infos:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['infos'] = []
        if self.infos is not None:
            for k in self.infos:
                result['infos'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.infos = []
        if m.get('infos') is not None:
            for k in m.get('infos'):
                temp_model = QueryConferenceInfoBatchResponseBodyInfos()
                self.infos.append(temp_model.from_map(k))
        return self


class QueryConferenceInfoBatchResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryConferenceInfoBatchResponseBody = None,
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
            temp_model = QueryConferenceInfoBatchResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryConferenceMembersHeaders(TeaModel):
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


class QueryConferenceMembersRequest(TeaModel):
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


class QueryConferenceMembersResponseBodyMemberModels(TeaModel):
    def __init__(
        self,
        attend_status: int = None,
        co_host: bool = None,
        conference_id: str = None,
        duration: int = None,
        host: bool = None,
        join_time: int = None,
        leave_time: int = None,
        outer_org_member: bool = None,
        pstn_join: bool = None,
        union_id: str = None,
        user_nick: str = None,
    ):
        self.attend_status = attend_status
        self.co_host = co_host
        self.conference_id = conference_id
        self.duration = duration
        self.host = host
        self.join_time = join_time
        self.leave_time = leave_time
        self.outer_org_member = outer_org_member
        self.pstn_join = pstn_join
        self.union_id = union_id
        self.user_nick = user_nick

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.attend_status is not None:
            result['attendStatus'] = self.attend_status
        if self.co_host is not None:
            result['coHost'] = self.co_host
        if self.conference_id is not None:
            result['conferenceId'] = self.conference_id
        if self.duration is not None:
            result['duration'] = self.duration
        if self.host is not None:
            result['host'] = self.host
        if self.join_time is not None:
            result['joinTime'] = self.join_time
        if self.leave_time is not None:
            result['leaveTime'] = self.leave_time
        if self.outer_org_member is not None:
            result['outerOrgMember'] = self.outer_org_member
        if self.pstn_join is not None:
            result['pstnJoin'] = self.pstn_join
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.user_nick is not None:
            result['userNick'] = self.user_nick
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('attendStatus') is not None:
            self.attend_status = m.get('attendStatus')
        if m.get('coHost') is not None:
            self.co_host = m.get('coHost')
        if m.get('conferenceId') is not None:
            self.conference_id = m.get('conferenceId')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('host') is not None:
            self.host = m.get('host')
        if m.get('joinTime') is not None:
            self.join_time = m.get('joinTime')
        if m.get('leaveTime') is not None:
            self.leave_time = m.get('leaveTime')
        if m.get('outerOrgMember') is not None:
            self.outer_org_member = m.get('outerOrgMember')
        if m.get('pstnJoin') is not None:
            self.pstn_join = m.get('pstnJoin')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('userNick') is not None:
            self.user_nick = m.get('userNick')
        return self


class QueryConferenceMembersResponseBody(TeaModel):
    def __init__(
        self,
        member_models: List[QueryConferenceMembersResponseBodyMemberModels] = None,
        next_token: str = None,
        total_count: int = None,
    ):
        self.member_models = member_models
        self.next_token = next_token
        self.total_count = total_count

    def validate(self):
        if self.member_models:
            for k in self.member_models:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['memberModels'] = []
        if self.member_models is not None:
            for k in self.member_models:
                result['memberModels'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.member_models = []
        if m.get('memberModels') is not None:
            for k in m.get('memberModels'):
                temp_model = QueryConferenceMembersResponseBodyMemberModels()
                self.member_models.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class QueryConferenceMembersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryConferenceMembersResponseBody = None,
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
            temp_model = QueryConferenceMembersResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryScheduleConferenceHeaders(TeaModel):
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


class QueryScheduleConferenceRequest(TeaModel):
    def __init__(
        self,
        request_union_id: str = None,
    ):
        self.request_union_id = request_union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_union_id is not None:
            result['requestUnionId'] = self.request_union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestUnionId') is not None:
            self.request_union_id = m.get('requestUnionId')
        return self


class QueryScheduleConferenceResponseBody(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        phones: List[str] = None,
        request_id: str = None,
        room_code: str = None,
        schedule_conference_id: str = None,
        start_time: int = None,
        title: str = None,
        url: str = None,
    ):
        self.end_time = end_time
        self.phones = phones
        self.request_id = request_id
        self.room_code = room_code
        self.schedule_conference_id = schedule_conference_id
        self.start_time = start_time
        self.title = title
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.phones is not None:
            result['phones'] = self.phones
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.room_code is not None:
            result['roomCode'] = self.room_code
        if self.schedule_conference_id is not None:
            result['scheduleConferenceId'] = self.schedule_conference_id
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.title is not None:
            result['title'] = self.title
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('phones') is not None:
            self.phones = m.get('phones')
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('roomCode') is not None:
            self.room_code = m.get('roomCode')
        if m.get('scheduleConferenceId') is not None:
            self.schedule_conference_id = m.get('scheduleConferenceId')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class QueryScheduleConferenceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryScheduleConferenceResponseBody = None,
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
            temp_model = QueryScheduleConferenceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryScheduleConferenceInfoHeaders(TeaModel):
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


class QueryScheduleConferenceInfoRequest(TeaModel):
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


class QueryScheduleConferenceInfoResponseBodyConferenceList(TeaModel):
    def __init__(
        self,
        conference_id: str = None,
        end_time: int = None,
        room_code: str = None,
        start_time: int = None,
        status: int = None,
        title: str = None,
    ):
        self.conference_id = conference_id
        self.end_time = end_time
        self.room_code = room_code
        self.start_time = start_time
        self.status = status
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conference_id is not None:
            result['conferenceId'] = self.conference_id
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.room_code is not None:
            result['roomCode'] = self.room_code
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.status is not None:
            result['status'] = self.status
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conferenceId') is not None:
            self.conference_id = m.get('conferenceId')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('roomCode') is not None:
            self.room_code = m.get('roomCode')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class QueryScheduleConferenceInfoResponseBody(TeaModel):
    def __init__(
        self,
        conference_list: List[QueryScheduleConferenceInfoResponseBodyConferenceList] = None,
        next_token: str = None,
        total_count: int = None,
    ):
        self.conference_list = conference_list
        self.next_token = next_token
        self.total_count = total_count

    def validate(self):
        if self.conference_list:
            for k in self.conference_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['conferenceList'] = []
        if self.conference_list is not None:
            for k in self.conference_list:
                result['conferenceList'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.conference_list = []
        if m.get('conferenceList') is not None:
            for k in m.get('conferenceList'):
                temp_model = QueryScheduleConferenceInfoResponseBodyConferenceList()
                self.conference_list.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class QueryScheduleConferenceInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryScheduleConferenceInfoResponseBody = None,
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
            temp_model = QueryScheduleConferenceInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryUserOnGoingConferenceHeaders(TeaModel):
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


class QueryUserOnGoingConferenceRequest(TeaModel):
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


class QueryUserOnGoingConferenceResponseBody(TeaModel):
    def __init__(
        self,
        member_model_map: Dict[str, MemberModelMapValue] = None,
        on_going_conf_id_list: List[str] = None,
    ):
        self.member_model_map = member_model_map
        self.on_going_conf_id_list = on_going_conf_id_list

    def validate(self):
        if self.member_model_map:
            for v in self.member_model_map.values():
                if v:
                    v.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['memberModelMap'] = {}
        if self.member_model_map is not None:
            for k, v in self.member_model_map.items():
                result['memberModelMap'][k] = v.to_map()
        if self.on_going_conf_id_list is not None:
            result['onGoingConfIdList'] = self.on_going_conf_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.member_model_map = {}
        if m.get('memberModelMap') is not None:
            for k, v in m.get('memberModelMap').items():
                temp_model = MemberModelMapValue()
                self.member_model_map[k] = temp_model.from_map(v)
        if m.get('onGoingConfIdList') is not None:
            self.on_going_conf_id_list = m.get('onGoingConfIdList')
        return self


class QueryUserOnGoingConferenceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryUserOnGoingConferenceResponseBody = None,
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
            temp_model = QueryUserOnGoingConferenceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class StartCloudRecordHeaders(TeaModel):
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


class StartCloudRecordRequest(TeaModel):
    def __init__(
        self,
        mode: str = None,
        small_window_position: str = None,
        union_id: str = None,
    ):
        self.mode = mode
        self.small_window_position = small_window_position
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.mode is not None:
            result['mode'] = self.mode
        if self.small_window_position is not None:
            result['smallWindowPosition'] = self.small_window_position
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('mode') is not None:
            self.mode = m.get('mode')
        if m.get('smallWindowPosition') is not None:
            self.small_window_position = m.get('smallWindowPosition')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class StartCloudRecordResponseBody(TeaModel):
    def __init__(
        self,
        code: str = None,
    ):
        self.code = code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        return self


class StartCloudRecordResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: StartCloudRecordResponseBody = None,
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
            temp_model = StartCloudRecordResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class StartStreamOutHeaders(TeaModel):
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


class StartStreamOutRequest(TeaModel):
    def __init__(
        self,
        mode: str = None,
        need_host_join: bool = None,
        small_window_position: str = None,
        stream_name: str = None,
        stream_url_list: List[str] = None,
        union_id: str = None,
    ):
        self.mode = mode
        self.need_host_join = need_host_join
        self.small_window_position = small_window_position
        self.stream_name = stream_name
        self.stream_url_list = stream_url_list
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.mode is not None:
            result['mode'] = self.mode
        if self.need_host_join is not None:
            result['needHostJoin'] = self.need_host_join
        if self.small_window_position is not None:
            result['smallWindowPosition'] = self.small_window_position
        if self.stream_name is not None:
            result['streamName'] = self.stream_name
        if self.stream_url_list is not None:
            result['streamUrlList'] = self.stream_url_list
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('mode') is not None:
            self.mode = m.get('mode')
        if m.get('needHostJoin') is not None:
            self.need_host_join = m.get('needHostJoin')
        if m.get('smallWindowPosition') is not None:
            self.small_window_position = m.get('smallWindowPosition')
        if m.get('streamName') is not None:
            self.stream_name = m.get('streamName')
        if m.get('streamUrlList') is not None:
            self.stream_url_list = m.get('streamUrlList')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class StartStreamOutResponseBody(TeaModel):
    def __init__(
        self,
        fail_stream_map: Dict[str, Any] = None,
        success_stream_map: Dict[str, Any] = None,
    ):
        self.fail_stream_map = fail_stream_map
        self.success_stream_map = success_stream_map

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.fail_stream_map is not None:
            result['failStreamMap'] = self.fail_stream_map
        if self.success_stream_map is not None:
            result['successStreamMap'] = self.success_stream_map
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('failStreamMap') is not None:
            self.fail_stream_map = m.get('failStreamMap')
        if m.get('successStreamMap') is not None:
            self.success_stream_map = m.get('successStreamMap')
        return self


class StartStreamOutResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: StartStreamOutResponseBody = None,
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
            temp_model = StartStreamOutResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class StopCloudRecordHeaders(TeaModel):
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


class StopCloudRecordRequest(TeaModel):
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


class StopCloudRecordResponseBody(TeaModel):
    def __init__(
        self,
        code: str = None,
    ):
        self.code = code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        return self


class StopCloudRecordResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: StopCloudRecordResponseBody = None,
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
            temp_model = StopCloudRecordResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class StopStreamOutHeaders(TeaModel):
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


class StopStreamOutRequest(TeaModel):
    def __init__(
        self,
        stop_all_stream: bool = None,
        stream_id: str = None,
        union_id: str = None,
    ):
        self.stop_all_stream = stop_all_stream
        self.stream_id = stream_id
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stop_all_stream is not None:
            result['stopAllStream'] = self.stop_all_stream
        if self.stream_id is not None:
            result['streamId'] = self.stream_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('stopAllStream') is not None:
            self.stop_all_stream = m.get('stopAllStream')
        if m.get('streamId') is not None:
            self.stream_id = m.get('streamId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class StopStreamOutResponseBody(TeaModel):
    def __init__(
        self,
        code: str = None,
    ):
        self.code = code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        return self


class StopStreamOutResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: StopStreamOutResponseBody = None,
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
            temp_model = StopStreamOutResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateScheduleConferenceHeaders(TeaModel):
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


class UpdateScheduleConferenceRequest(TeaModel):
    def __init__(
        self,
        creator_union_id: str = None,
        end_time: int = None,
        schedule_conference_id: str = None,
        start_time: int = None,
        title: str = None,
    ):
        self.creator_union_id = creator_union_id
        self.end_time = end_time
        self.schedule_conference_id = schedule_conference_id
        self.start_time = start_time
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.creator_union_id is not None:
            result['creatorUnionId'] = self.creator_union_id
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.schedule_conference_id is not None:
            result['scheduleConferenceId'] = self.schedule_conference_id
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('creatorUnionId') is not None:
            self.creator_union_id = m.get('creatorUnionId')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('scheduleConferenceId') is not None:
            self.schedule_conference_id = m.get('scheduleConferenceId')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class UpdateScheduleConferenceResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class UpdateScheduleConferenceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateScheduleConferenceResponseBody = None,
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
            temp_model = UpdateScheduleConferenceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateVideoConferenceExtInfoHeaders(TeaModel):
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


class UpdateVideoConferenceExtInfoResponseBody(TeaModel):
    def __init__(
        self,
        case: str = None,
        code: str = None,
    ):
        self.case = case
        self.code = code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.case is not None:
            result['case'] = self.case
        if self.code is not None:
            result['code'] = self.code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('case') is not None:
            self.case = m.get('case')
        if m.get('code') is not None:
            self.code = m.get('code')
        return self


class UpdateVideoConferenceExtInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateVideoConferenceExtInfoResponseBody = None,
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
            temp_model = UpdateVideoConferenceExtInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateVideoConferenceSettingHeaders(TeaModel):
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


class UpdateVideoConferenceSettingRequest(TeaModel):
    def __init__(
        self,
        allow_unmute_self: bool = None,
        auto_transfer_host: bool = None,
        forbidden_share_screen: bool = None,
        lock_conference: bool = None,
        mute_all: bool = None,
        only_internal_employees_join: bool = None,
    ):
        self.allow_unmute_self = allow_unmute_self
        self.auto_transfer_host = auto_transfer_host
        self.forbidden_share_screen = forbidden_share_screen
        self.lock_conference = lock_conference
        self.mute_all = mute_all
        self.only_internal_employees_join = only_internal_employees_join

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.allow_unmute_self is not None:
            result['allowUnmuteSelf'] = self.allow_unmute_self
        if self.auto_transfer_host is not None:
            result['autoTransferHost'] = self.auto_transfer_host
        if self.forbidden_share_screen is not None:
            result['forbiddenShareScreen'] = self.forbidden_share_screen
        if self.lock_conference is not None:
            result['lockConference'] = self.lock_conference
        if self.mute_all is not None:
            result['muteAll'] = self.mute_all
        if self.only_internal_employees_join is not None:
            result['onlyInternalEmployeesJoin'] = self.only_internal_employees_join
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('allowUnmuteSelf') is not None:
            self.allow_unmute_self = m.get('allowUnmuteSelf')
        if m.get('autoTransferHost') is not None:
            self.auto_transfer_host = m.get('autoTransferHost')
        if m.get('forbiddenShareScreen') is not None:
            self.forbidden_share_screen = m.get('forbiddenShareScreen')
        if m.get('lockConference') is not None:
            self.lock_conference = m.get('lockConference')
        if m.get('muteAll') is not None:
            self.mute_all = m.get('muteAll')
        if m.get('onlyInternalEmployeesJoin') is not None:
            self.only_internal_employees_join = m.get('onlyInternalEmployeesJoin')
        return self


class UpdateVideoConferenceSettingResponseBody(TeaModel):
    def __init__(
        self,
        case: str = None,
        code: str = None,
    ):
        self.case = case
        self.code = code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.case is not None:
            result['case'] = self.case
        if self.code is not None:
            result['code'] = self.code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('case') is not None:
            self.case = m.get('case')
        if m.get('code') is not None:
            self.code = m.get('code')
        return self


class UpdateVideoConferenceSettingResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateVideoConferenceSettingResponseBody = None,
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
            temp_model = UpdateVideoConferenceSettingResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


