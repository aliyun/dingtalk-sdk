# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List, Any


class MetricMapValue(TeaModel):
    def __init__(
        self,
        timestamp: int = None,
        send_bit_rate: str = None,
        recv_bit_rate: str = None,
        lost_rate: str = None,
        round_trip_time: str = None,
        audio_send_bit_rate: str = None,
        audio_recv_bit_rate: str = None,
        audio_rec_level: str = None,
        audio_play_level: str = None,
        camera_send_bit_rate: str = None,
        camera_recv_bit_rate: str = None,
        camera_send_resolution_actual: str = None,
        camera_recv_resolution_actual: str = None,
        camera_send_frame: str = None,
        screen_send_bit_rate: str = None,
        camera_recv_frame: str = None,
        screen_recv_bit_rate: str = None,
        screen_send_resolution_actual: str = None,
        screen_recv_resolution_actual: str = None,
        screen_send_frame: str = None,
        screen_recv_frame: str = None,
        audio_jitter_max: str = None,
        audio_jitter_avg: str = None,
    ):
        self.timestamp = timestamp
        self.send_bit_rate = send_bit_rate
        self.recv_bit_rate = recv_bit_rate
        self.lost_rate = lost_rate
        self.round_trip_time = round_trip_time
        self.audio_send_bit_rate = audio_send_bit_rate
        self.audio_recv_bit_rate = audio_recv_bit_rate
        self.audio_rec_level = audio_rec_level
        self.audio_play_level = audio_play_level
        self.camera_send_bit_rate = camera_send_bit_rate
        self.camera_recv_bit_rate = camera_recv_bit_rate
        self.camera_send_resolution_actual = camera_send_resolution_actual
        self.camera_recv_resolution_actual = camera_recv_resolution_actual
        self.camera_send_frame = camera_send_frame
        self.screen_send_bit_rate = screen_send_bit_rate
        self.camera_recv_frame = camera_recv_frame
        self.screen_recv_bit_rate = screen_recv_bit_rate
        self.screen_send_resolution_actual = screen_send_resolution_actual
        self.screen_recv_resolution_actual = screen_recv_resolution_actual
        self.screen_send_frame = screen_send_frame
        self.screen_recv_frame = screen_recv_frame
        self.audio_jitter_max = audio_jitter_max
        self.audio_jitter_avg = audio_jitter_avg

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.timestamp is not None:
            result['timestamp'] = self.timestamp
        if self.send_bit_rate is not None:
            result['sendBitRate'] = self.send_bit_rate
        if self.recv_bit_rate is not None:
            result['recvBitRate'] = self.recv_bit_rate
        if self.lost_rate is not None:
            result['lostRate'] = self.lost_rate
        if self.round_trip_time is not None:
            result['roundTripTime'] = self.round_trip_time
        if self.audio_send_bit_rate is not None:
            result['audioSendBitRate'] = self.audio_send_bit_rate
        if self.audio_recv_bit_rate is not None:
            result['audioRecvBitRate'] = self.audio_recv_bit_rate
        if self.audio_rec_level is not None:
            result['audioRecLevel'] = self.audio_rec_level
        if self.audio_play_level is not None:
            result['audioPlayLevel'] = self.audio_play_level
        if self.camera_send_bit_rate is not None:
            result['cameraSendBitRate'] = self.camera_send_bit_rate
        if self.camera_recv_bit_rate is not None:
            result['cameraRecvBitRate'] = self.camera_recv_bit_rate
        if self.camera_send_resolution_actual is not None:
            result['cameraSendResolutionActual'] = self.camera_send_resolution_actual
        if self.camera_recv_resolution_actual is not None:
            result['cameraRecvResolutionActual'] = self.camera_recv_resolution_actual
        if self.camera_send_frame is not None:
            result['cameraSendFrame'] = self.camera_send_frame
        if self.screen_send_bit_rate is not None:
            result['screenSendBitRate'] = self.screen_send_bit_rate
        if self.camera_recv_frame is not None:
            result['cameraRecvFrame'] = self.camera_recv_frame
        if self.screen_recv_bit_rate is not None:
            result['screenRecvBitRate'] = self.screen_recv_bit_rate
        if self.screen_send_resolution_actual is not None:
            result['screenSendResolutionActual'] = self.screen_send_resolution_actual
        if self.screen_recv_resolution_actual is not None:
            result['screenRecvResolutionActual'] = self.screen_recv_resolution_actual
        if self.screen_send_frame is not None:
            result['screenSendFrame'] = self.screen_send_frame
        if self.screen_recv_frame is not None:
            result['screenRecvFrame'] = self.screen_recv_frame
        if self.audio_jitter_max is not None:
            result['audioJitterMax'] = self.audio_jitter_max
        if self.audio_jitter_avg is not None:
            result['audioJitterAvg'] = self.audio_jitter_avg
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('timestamp') is not None:
            self.timestamp = m.get('timestamp')
        if m.get('sendBitRate') is not None:
            self.send_bit_rate = m.get('sendBitRate')
        if m.get('recvBitRate') is not None:
            self.recv_bit_rate = m.get('recvBitRate')
        if m.get('lostRate') is not None:
            self.lost_rate = m.get('lostRate')
        if m.get('roundTripTime') is not None:
            self.round_trip_time = m.get('roundTripTime')
        if m.get('audioSendBitRate') is not None:
            self.audio_send_bit_rate = m.get('audioSendBitRate')
        if m.get('audioRecvBitRate') is not None:
            self.audio_recv_bit_rate = m.get('audioRecvBitRate')
        if m.get('audioRecLevel') is not None:
            self.audio_rec_level = m.get('audioRecLevel')
        if m.get('audioPlayLevel') is not None:
            self.audio_play_level = m.get('audioPlayLevel')
        if m.get('cameraSendBitRate') is not None:
            self.camera_send_bit_rate = m.get('cameraSendBitRate')
        if m.get('cameraRecvBitRate') is not None:
            self.camera_recv_bit_rate = m.get('cameraRecvBitRate')
        if m.get('cameraSendResolutionActual') is not None:
            self.camera_send_resolution_actual = m.get('cameraSendResolutionActual')
        if m.get('cameraRecvResolutionActual') is not None:
            self.camera_recv_resolution_actual = m.get('cameraRecvResolutionActual')
        if m.get('cameraSendFrame') is not None:
            self.camera_send_frame = m.get('cameraSendFrame')
        if m.get('screenSendBitRate') is not None:
            self.screen_send_bit_rate = m.get('screenSendBitRate')
        if m.get('cameraRecvFrame') is not None:
            self.camera_recv_frame = m.get('cameraRecvFrame')
        if m.get('screenRecvBitRate') is not None:
            self.screen_recv_bit_rate = m.get('screenRecvBitRate')
        if m.get('screenSendResolutionActual') is not None:
            self.screen_send_resolution_actual = m.get('screenSendResolutionActual')
        if m.get('screenRecvResolutionActual') is not None:
            self.screen_recv_resolution_actual = m.get('screenRecvResolutionActual')
        if m.get('screenSendFrame') is not None:
            self.screen_send_frame = m.get('screenSendFrame')
        if m.get('screenRecvFrame') is not None:
            self.screen_recv_frame = m.get('screenRecvFrame')
        if m.get('audioJitterMax') is not None:
            self.audio_jitter_max = m.get('audioJitterMax')
        if m.get('audioJitterAvg') is not None:
            self.audio_jitter_avg = m.get('audioJitterAvg')
        return self


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


class AddRecordPermissionHeaders(TeaModel):
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


class AddRecordPermissionRequest(TeaModel):
    def __init__(
        self,
        biz_type: str = None,
        owner_union_id: str = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.biz_type = biz_type
        # This parameter is required.
        self.owner_union_id = owner_union_id
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.owner_union_id is not None:
            result['ownerUnionId'] = self.owner_union_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('ownerUnionId') is not None:
            self.owner_union_id = m.get('ownerUnionId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class AddRecordPermissionResponseBody(TeaModel):
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


class AddRecordPermissionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AddRecordPermissionResponseBody = None,
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
            temp_model = AddRecordPermissionResponseBody()
            self.body = temp_model.from_map(m['body'])
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
        # This parameter is required.
        self.creator_union_id = creator_union_id
        # This parameter is required.
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
        # This parameter is required.
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
        # This parameter is required.
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
        # This parameter is required.
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
        # This parameter is required.
        self.action = action
        # This parameter is required.
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


class CreateCustomShortLinkHeaders(TeaModel):
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


class CreateCustomShortLinkRequest(TeaModel):
    def __init__(
        self,
        cool_app_code: str = None,
        creator_union_id: str = None,
        extension_app_biz_data: str = None,
        schedule_conference_id: str = None,
        use_extension_app: bool = None,
    ):
        # This parameter is required.
        self.cool_app_code = cool_app_code
        # This parameter is required.
        self.creator_union_id = creator_union_id
        self.extension_app_biz_data = extension_app_biz_data
        # This parameter is required.
        self.schedule_conference_id = schedule_conference_id
        self.use_extension_app = use_extension_app

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cool_app_code is not None:
            result['coolAppCode'] = self.cool_app_code
        if self.creator_union_id is not None:
            result['creatorUnionId'] = self.creator_union_id
        if self.extension_app_biz_data is not None:
            result['extensionAppBizData'] = self.extension_app_biz_data
        if self.schedule_conference_id is not None:
            result['scheduleConferenceId'] = self.schedule_conference_id
        if self.use_extension_app is not None:
            result['useExtensionApp'] = self.use_extension_app
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('coolAppCode') is not None:
            self.cool_app_code = m.get('coolAppCode')
        if m.get('creatorUnionId') is not None:
            self.creator_union_id = m.get('creatorUnionId')
        if m.get('extensionAppBizData') is not None:
            self.extension_app_biz_data = m.get('extensionAppBizData')
        if m.get('scheduleConferenceId') is not None:
            self.schedule_conference_id = m.get('scheduleConferenceId')
        if m.get('useExtensionApp') is not None:
            self.use_extension_app = m.get('useExtensionApp')
        return self


class CreateCustomShortLinkResponseBodyResult(TeaModel):
    def __init__(
        self,
        custom_short_link: str = None,
    ):
        self.custom_short_link = custom_short_link

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.custom_short_link is not None:
            result['customShortLink'] = self.custom_short_link
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customShortLink') is not None:
            self.custom_short_link = m.get('customShortLink')
        return self


class CreateCustomShortLinkResponseBody(TeaModel):
    def __init__(
        self,
        result: CreateCustomShortLinkResponseBodyResult = None,
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
            temp_model = CreateCustomShortLinkResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class CreateCustomShortLinkResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateCustomShortLinkResponseBody = None,
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
            temp_model = CreateCustomShortLinkResponseBody()
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


class CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfOpenRecordSetting(TeaModel):
    def __init__(
        self,
        is_follow_host: bool = None,
        mode: str = None,
        record_auto_start: int = None,
        record_auto_start_type: int = None,
    ):
        self.is_follow_host = is_follow_host
        self.mode = mode
        self.record_auto_start = record_auto_start
        self.record_auto_start_type = record_auto_start_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.is_follow_host is not None:
            result['isFollowHost'] = self.is_follow_host
        if self.mode is not None:
            result['mode'] = self.mode
        if self.record_auto_start is not None:
            result['recordAutoStart'] = self.record_auto_start
        if self.record_auto_start_type is not None:
            result['recordAutoStartType'] = self.record_auto_start_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isFollowHost') is not None:
            self.is_follow_host = m.get('isFollowHost')
        if m.get('mode') is not None:
            self.mode = m.get('mode')
        if m.get('recordAutoStart') is not None:
            self.record_auto_start = m.get('recordAutoStart')
        if m.get('recordAutoStartType') is not None:
            self.record_auto_start_type = m.get('recordAutoStartType')
        return self


class CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings(TeaModel):
    def __init__(
        self,
        auto_open_mode: int = None,
        cool_app_code: str = None,
        extension_app_biz_data: str = None,
    ):
        self.auto_open_mode = auto_open_mode
        self.cool_app_code = cool_app_code
        self.extension_app_biz_data = extension_app_biz_data

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.auto_open_mode is not None:
            result['autoOpenMode'] = self.auto_open_mode
        if self.cool_app_code is not None:
            result['coolAppCode'] = self.cool_app_code
        if self.extension_app_biz_data is not None:
            result['extensionAppBizData'] = self.extension_app_biz_data
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('autoOpenMode') is not None:
            self.auto_open_mode = m.get('autoOpenMode')
        if m.get('coolAppCode') is not None:
            self.cool_app_code = m.get('coolAppCode')
        if m.get('extensionAppBizData') is not None:
            self.extension_app_biz_data = m.get('extensionAppBizData')
        return self


class CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSetting(TeaModel):
    def __init__(
        self,
        cloud_record_owner_union_id: str = None,
        enable_chat: int = None,
        enable_web_anonymous_join: bool = None,
        join_before_host: int = None,
        lock_media_status_mic_mute: int = None,
        lock_nick: int = None,
        minutes_owner_union_id: str = None,
        mozi_conf_extension_app_settings: List[CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings] = None,
        push_all_meeting_records: bool = None,
        push_cloud_record_card: bool = None,
        push_minutes_card: bool = None,
        waiting_room: int = None,
    ):
        self.cloud_record_owner_union_id = cloud_record_owner_union_id
        self.enable_chat = enable_chat
        self.enable_web_anonymous_join = enable_web_anonymous_join
        self.join_before_host = join_before_host
        self.lock_media_status_mic_mute = lock_media_status_mic_mute
        self.lock_nick = lock_nick
        self.minutes_owner_union_id = minutes_owner_union_id
        self.mozi_conf_extension_app_settings = mozi_conf_extension_app_settings
        self.push_all_meeting_records = push_all_meeting_records
        self.push_cloud_record_card = push_cloud_record_card
        self.push_minutes_card = push_minutes_card
        self.waiting_room = waiting_room

    def validate(self):
        if self.mozi_conf_extension_app_settings:
            for k in self.mozi_conf_extension_app_settings:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cloud_record_owner_union_id is not None:
            result['cloudRecordOwnerUnionId'] = self.cloud_record_owner_union_id
        if self.enable_chat is not None:
            result['enableChat'] = self.enable_chat
        if self.enable_web_anonymous_join is not None:
            result['enableWebAnonymousJoin'] = self.enable_web_anonymous_join
        if self.join_before_host is not None:
            result['joinBeforeHost'] = self.join_before_host
        if self.lock_media_status_mic_mute is not None:
            result['lockMediaStatusMicMute'] = self.lock_media_status_mic_mute
        if self.lock_nick is not None:
            result['lockNick'] = self.lock_nick
        if self.minutes_owner_union_id is not None:
            result['minutesOwnerUnionId'] = self.minutes_owner_union_id
        result['moziConfExtensionAppSettings'] = []
        if self.mozi_conf_extension_app_settings is not None:
            for k in self.mozi_conf_extension_app_settings:
                result['moziConfExtensionAppSettings'].append(k.to_map() if k else None)
        if self.push_all_meeting_records is not None:
            result['pushAllMeetingRecords'] = self.push_all_meeting_records
        if self.push_cloud_record_card is not None:
            result['pushCloudRecordCard'] = self.push_cloud_record_card
        if self.push_minutes_card is not None:
            result['pushMinutesCard'] = self.push_minutes_card
        if self.waiting_room is not None:
            result['waitingRoom'] = self.waiting_room
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cloudRecordOwnerUnionId') is not None:
            self.cloud_record_owner_union_id = m.get('cloudRecordOwnerUnionId')
        if m.get('enableChat') is not None:
            self.enable_chat = m.get('enableChat')
        if m.get('enableWebAnonymousJoin') is not None:
            self.enable_web_anonymous_join = m.get('enableWebAnonymousJoin')
        if m.get('joinBeforeHost') is not None:
            self.join_before_host = m.get('joinBeforeHost')
        if m.get('lockMediaStatusMicMute') is not None:
            self.lock_media_status_mic_mute = m.get('lockMediaStatusMicMute')
        if m.get('lockNick') is not None:
            self.lock_nick = m.get('lockNick')
        if m.get('minutesOwnerUnionId') is not None:
            self.minutes_owner_union_id = m.get('minutesOwnerUnionId')
        self.mozi_conf_extension_app_settings = []
        if m.get('moziConfExtensionAppSettings') is not None:
            for k in m.get('moziConfExtensionAppSettings'):
                temp_model = CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings()
                self.mozi_conf_extension_app_settings.append(temp_model.from_map(k))
        if m.get('pushAllMeetingRecords') is not None:
            self.push_all_meeting_records = m.get('pushAllMeetingRecords')
        if m.get('pushCloudRecordCard') is not None:
            self.push_cloud_record_card = m.get('pushCloudRecordCard')
        if m.get('pushMinutesCard') is not None:
            self.push_minutes_card = m.get('pushMinutesCard')
        if m.get('waitingRoom') is not None:
            self.waiting_room = m.get('waitingRoom')
        return self


class CreateScheduleConferenceRequestScheduleConfSettingModel(TeaModel):
    def __init__(
        self,
        cohost_union_ids: List[str] = None,
        conf_allowed_corp_id: str = None,
        host_union_id: str = None,
        lock_room: int = None,
        mozi_conf_open_record_setting: CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfOpenRecordSetting = None,
        mozi_conf_virtual_extra_setting: CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSetting = None,
        mute_on_join: int = None,
        screen_share_forbidden: int = None,
    ):
        self.cohost_union_ids = cohost_union_ids
        self.conf_allowed_corp_id = conf_allowed_corp_id
        self.host_union_id = host_union_id
        self.lock_room = lock_room
        self.mozi_conf_open_record_setting = mozi_conf_open_record_setting
        self.mozi_conf_virtual_extra_setting = mozi_conf_virtual_extra_setting
        self.mute_on_join = mute_on_join
        self.screen_share_forbidden = screen_share_forbidden

    def validate(self):
        if self.mozi_conf_open_record_setting:
            self.mozi_conf_open_record_setting.validate()
        if self.mozi_conf_virtual_extra_setting:
            self.mozi_conf_virtual_extra_setting.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cohost_union_ids is not None:
            result['cohostUnionIds'] = self.cohost_union_ids
        if self.conf_allowed_corp_id is not None:
            result['confAllowedCorpId'] = self.conf_allowed_corp_id
        if self.host_union_id is not None:
            result['hostUnionId'] = self.host_union_id
        if self.lock_room is not None:
            result['lockRoom'] = self.lock_room
        if self.mozi_conf_open_record_setting is not None:
            result['moziConfOpenRecordSetting'] = self.mozi_conf_open_record_setting.to_map()
        if self.mozi_conf_virtual_extra_setting is not None:
            result['moziConfVirtualExtraSetting'] = self.mozi_conf_virtual_extra_setting.to_map()
        if self.mute_on_join is not None:
            result['muteOnJoin'] = self.mute_on_join
        if self.screen_share_forbidden is not None:
            result['screenShareForbidden'] = self.screen_share_forbidden
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cohostUnionIds') is not None:
            self.cohost_union_ids = m.get('cohostUnionIds')
        if m.get('confAllowedCorpId') is not None:
            self.conf_allowed_corp_id = m.get('confAllowedCorpId')
        if m.get('hostUnionId') is not None:
            self.host_union_id = m.get('hostUnionId')
        if m.get('lockRoom') is not None:
            self.lock_room = m.get('lockRoom')
        if m.get('moziConfOpenRecordSetting') is not None:
            temp_model = CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfOpenRecordSetting()
            self.mozi_conf_open_record_setting = temp_model.from_map(m['moziConfOpenRecordSetting'])
        if m.get('moziConfVirtualExtraSetting') is not None:
            temp_model = CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSetting()
            self.mozi_conf_virtual_extra_setting = temp_model.from_map(m['moziConfVirtualExtraSetting'])
        if m.get('muteOnJoin') is not None:
            self.mute_on_join = m.get('muteOnJoin')
        if m.get('screenShareForbidden') is not None:
            self.screen_share_forbidden = m.get('screenShareForbidden')
        return self


class CreateScheduleConferenceRequest(TeaModel):
    def __init__(
        self,
        creator_union_id: str = None,
        end_time: int = None,
        schedule_conf_setting_model: CreateScheduleConferenceRequestScheduleConfSettingModel = None,
        start_time: int = None,
        title: str = None,
    ):
        # This parameter is required.
        self.creator_union_id = creator_union_id
        # This parameter is required.
        self.end_time = end_time
        self.schedule_conf_setting_model = schedule_conf_setting_model
        # This parameter is required.
        self.start_time = start_time
        # This parameter is required.
        self.title = title

    def validate(self):
        if self.schedule_conf_setting_model:
            self.schedule_conf_setting_model.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.creator_union_id is not None:
            result['creatorUnionId'] = self.creator_union_id
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.schedule_conf_setting_model is not None:
            result['scheduleConfSettingModel'] = self.schedule_conf_setting_model.to_map()
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
        if m.get('scheduleConfSettingModel') is not None:
            temp_model = CreateScheduleConferenceRequestScheduleConfSettingModel()
            self.schedule_conf_setting_model = temp_model.from_map(m['scheduleConfSettingModel'])
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
        # This parameter is required.
        self.conf_title = conf_title
        self.invite_caller = invite_caller
        self.invite_user_ids = invite_user_ids
        # This parameter is required.
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
        # This parameter is required.
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
        # This parameter is required.
        self.action = action
        # This parameter is required.
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


class GenerateFlashMinutesDocumentUrlHeaders(TeaModel):
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


class GenerateFlashMinutesDocumentUrlRequest(TeaModel):
    def __init__(
        self,
        biz_type: str = None,
        expire_time: int = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.biz_type = biz_type
        self.expire_time = expire_time
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.expire_time is not None:
            result['expireTime'] = self.expire_time
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('expireTime') is not None:
            self.expire_time = m.get('expireTime')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GenerateFlashMinutesDocumentUrlResponseBody(TeaModel):
    def __init__(
        self,
        minutes_doc_url: str = None,
    ):
        self.minutes_doc_url = minutes_doc_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.minutes_doc_url is not None:
            result['minutesDocUrl'] = self.minutes_doc_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('minutesDocUrl') is not None:
            self.minutes_doc_url = m.get('minutesDocUrl')
        return self


class GenerateFlashMinutesDocumentUrlResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GenerateFlashMinutesDocumentUrlResponseBody = None,
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
            temp_model = GenerateFlashMinutesDocumentUrlResponseBody()
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
        # This parameter is required.
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
        # This parameter is required.
        self.end_time = end_time
        self.free_type = free_type
        self.max_results = max_results
        self.next_token = next_token
        # This parameter is required.
        self.real_data = real_data
        self.scene = scene
        # This parameter is required.
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


class GetUserLastMetricHeaders(TeaModel):
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


class GetUserLastMetricRequest(TeaModel):
    def __init__(
        self,
        union_id_list: List[str] = None,
    ):
        # This parameter is required.
        self.union_id_list = union_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.union_id_list is not None:
            result['unionIdList'] = self.union_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('unionIdList') is not None:
            self.union_id_list = m.get('unionIdList')
        return self


class GetUserLastMetricResponseBody(TeaModel):
    def __init__(
        self,
        metric_map: Dict[str, MetricMapValue] = None,
    ):
        self.metric_map = metric_map

    def validate(self):
        if self.metric_map:
            for v in self.metric_map.values():
                if v:
                    v.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['metricMap'] = {}
        if self.metric_map is not None:
            for k, v in self.metric_map.items():
                result['metricMap'][k] = v.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.metric_map = {}
        if m.get('metricMap') is not None:
            for k, v in m.get('metricMap').items():
                temp_model = MetricMapValue()
                self.metric_map[k] = temp_model.from_map(v)
        return self


class GetUserLastMetricResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetUserLastMetricResponseBody = None,
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
            temp_model = GetUserLastMetricResponseBody()
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
        # This parameter is required.
        self.begin_time = begin_time
        # This parameter is required.
        self.end_time = end_time
        # This parameter is required.
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
        # This parameter is required.
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


class InviteUsersRequestPhoneInviteeList(TeaModel):
    def __init__(
        self,
        invite_client: bool = None,
        nick: str = None,
        phone_number: str = None,
        status_code: str = None,
    ):
        self.invite_client = invite_client
        self.nick = nick
        self.phone_number = phone_number
        self.status_code = status_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.invite_client is not None:
            result['inviteClient'] = self.invite_client
        if self.nick is not None:
            result['nick'] = self.nick
        if self.phone_number is not None:
            result['phoneNumber'] = self.phone_number
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('inviteClient') is not None:
            self.invite_client = m.get('inviteClient')
        if m.get('nick') is not None:
            self.nick = m.get('nick')
        if m.get('phoneNumber') is not None:
            self.phone_number = m.get('phoneNumber')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        return self


class InviteUsersRequest(TeaModel):
    def __init__(
        self,
        invitee_list: List[InviteUsersRequestInviteeList] = None,
        phone_invitee_list: List[InviteUsersRequestPhoneInviteeList] = None,
        union_id: str = None,
    ):
        self.invitee_list = invitee_list
        self.phone_invitee_list = phone_invitee_list
        self.union_id = union_id

    def validate(self):
        if self.invitee_list:
            for k in self.invitee_list:
                if k:
                    k.validate()
        if self.phone_invitee_list:
            for k in self.phone_invitee_list:
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
        result['phoneInviteeList'] = []
        if self.phone_invitee_list is not None:
            for k in self.phone_invitee_list:
                result['phoneInviteeList'].append(k.to_map() if k else None)
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
        self.phone_invitee_list = []
        if m.get('phoneInviteeList') is not None:
            for k in m.get('phoneInviteeList'):
                temp_model = InviteUsersRequestPhoneInviteeList()
                self.phone_invitee_list.append(temp_model.from_map(k))
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
        # This parameter is required.
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
        # This parameter is required.
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


class LockConferenceHeaders(TeaModel):
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


class LockConferenceRequest(TeaModel):
    def __init__(
        self,
        action: str = None,
    ):
        # This parameter is required.
        self.action = action

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action is not None:
            result['action'] = self.action
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('action') is not None:
            self.action = m.get('action')
        return self


class LockConferenceResponseBody(TeaModel):
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


class LockConferenceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: LockConferenceResponseBody = None,
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
            temp_model = LockConferenceResponseBody()
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
        # This parameter is required.
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
        # This parameter is required.
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
        # This parameter is required.
        self.action = action
        # This parameter is required.
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
        # This parameter is required.
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
        # This parameter is required.
        self.media_id = media_id
        # This parameter is required.
        self.region_id = region_id
        # This parameter is required.
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


class QueryConferenceInfoResponseBodyConfInfoExtensionAppSettings(TeaModel):
    def __init__(
        self,
        app_code: str = None,
        app_id: str = None,
        auto_open_mode: int = None,
        extension_app_biz_data: str = None,
    ):
        self.app_code = app_code
        self.app_id = app_id
        self.auto_open_mode = auto_open_mode
        self.extension_app_biz_data = extension_app_biz_data

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_code is not None:
            result['appCode'] = self.app_code
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.auto_open_mode is not None:
            result['autoOpenMode'] = self.auto_open_mode
        if self.extension_app_biz_data is not None:
            result['extensionAppBizData'] = self.extension_app_biz_data
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appCode') is not None:
            self.app_code = m.get('appCode')
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('autoOpenMode') is not None:
            self.auto_open_mode = m.get('autoOpenMode')
        if m.get('extensionAppBizData') is not None:
            self.extension_app_biz_data = m.get('extensionAppBizData')
        return self


class QueryConferenceInfoResponseBodyConfInfo(TeaModel):
    def __init__(
        self,
        active_num: int = None,
        attend_num: int = None,
        biz_type: str = None,
        cloud_record_owner_union_id: str = None,
        cloud_record_status: int = None,
        conf_duration: int = None,
        conference_id: str = None,
        creator_id: str = None,
        creator_nick: str = None,
        end_time: int = None,
        extension_app_settings: List[QueryConferenceInfoResponseBodyConfInfoExtensionAppSettings] = None,
        external_link_url: str = None,
        invited_num: int = None,
        minutes_owner_union_id: str = None,
        minutes_status: int = None,
        room_code: str = None,
        schedule_conference_id: str = None,
        start_time: int = None,
        status: int = None,
        title: str = None,
    ):
        self.active_num = active_num
        self.attend_num = attend_num
        self.biz_type = biz_type
        self.cloud_record_owner_union_id = cloud_record_owner_union_id
        self.cloud_record_status = cloud_record_status
        self.conf_duration = conf_duration
        self.conference_id = conference_id
        self.creator_id = creator_id
        self.creator_nick = creator_nick
        self.end_time = end_time
        self.extension_app_settings = extension_app_settings
        self.external_link_url = external_link_url
        self.invited_num = invited_num
        self.minutes_owner_union_id = minutes_owner_union_id
        self.minutes_status = minutes_status
        self.room_code = room_code
        self.schedule_conference_id = schedule_conference_id
        self.start_time = start_time
        self.status = status
        self.title = title

    def validate(self):
        if self.extension_app_settings:
            for k in self.extension_app_settings:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.active_num is not None:
            result['activeNum'] = self.active_num
        if self.attend_num is not None:
            result['attendNum'] = self.attend_num
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.cloud_record_owner_union_id is not None:
            result['cloudRecordOwnerUnionId'] = self.cloud_record_owner_union_id
        if self.cloud_record_status is not None:
            result['cloudRecordStatus'] = self.cloud_record_status
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
        result['extensionAppSettings'] = []
        if self.extension_app_settings is not None:
            for k in self.extension_app_settings:
                result['extensionAppSettings'].append(k.to_map() if k else None)
        if self.external_link_url is not None:
            result['externalLinkUrl'] = self.external_link_url
        if self.invited_num is not None:
            result['invitedNum'] = self.invited_num
        if self.minutes_owner_union_id is not None:
            result['minutesOwnerUnionId'] = self.minutes_owner_union_id
        if self.minutes_status is not None:
            result['minutesStatus'] = self.minutes_status
        if self.room_code is not None:
            result['roomCode'] = self.room_code
        if self.schedule_conference_id is not None:
            result['scheduleConferenceId'] = self.schedule_conference_id
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
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('cloudRecordOwnerUnionId') is not None:
            self.cloud_record_owner_union_id = m.get('cloudRecordOwnerUnionId')
        if m.get('cloudRecordStatus') is not None:
            self.cloud_record_status = m.get('cloudRecordStatus')
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
        self.extension_app_settings = []
        if m.get('extensionAppSettings') is not None:
            for k in m.get('extensionAppSettings'):
                temp_model = QueryConferenceInfoResponseBodyConfInfoExtensionAppSettings()
                self.extension_app_settings.append(temp_model.from_map(k))
        if m.get('externalLinkUrl') is not None:
            self.external_link_url = m.get('externalLinkUrl')
        if m.get('invitedNum') is not None:
            self.invited_num = m.get('invitedNum')
        if m.get('minutesOwnerUnionId') is not None:
            self.minutes_owner_union_id = m.get('minutesOwnerUnionId')
        if m.get('minutesStatus') is not None:
            self.minutes_status = m.get('minutesStatus')
        if m.get('roomCode') is not None:
            self.room_code = m.get('roomCode')
        if m.get('scheduleConferenceId') is not None:
            self.schedule_conference_id = m.get('scheduleConferenceId')
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
        # This parameter is required.
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


class QueryFlashMinutesSummaryHeaders(TeaModel):
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


class QueryFlashMinutesSummaryRequest(TeaModel):
    def __init__(
        self,
        biz_type: str = None,
        recorder_union_id: str = None,
    ):
        # This parameter is required.
        self.biz_type = biz_type
        # This parameter is required.
        self.recorder_union_id = recorder_union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.recorder_union_id is not None:
            result['recorderUnionId'] = self.recorder_union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('recorderUnionId') is not None:
            self.recorder_union_id = m.get('recorderUnionId')
        return self


class QueryFlashMinutesSummaryResponseBodyFlashMinutesSummarySummary(TeaModel):
    def __init__(
        self,
        end: int = None,
        headline: str = None,
        id: int = None,
        start: int = None,
        summary: str = None,
    ):
        self.end = end
        self.headline = headline
        self.id = id
        self.start = start
        self.summary = summary

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end is not None:
            result['end'] = self.end
        if self.headline is not None:
            result['headline'] = self.headline
        if self.id is not None:
            result['id'] = self.id
        if self.start is not None:
            result['start'] = self.start
        if self.summary is not None:
            result['summary'] = self.summary
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('end') is not None:
            self.end = m.get('end')
        if m.get('headline') is not None:
            self.headline = m.get('headline')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('start') is not None:
            self.start = m.get('start')
        if m.get('summary') is not None:
            self.summary = m.get('summary')
        return self


class QueryFlashMinutesSummaryResponseBodyFlashMinutesSummary(TeaModel):
    def __init__(
        self,
        status: int = None,
        summary: List[QueryFlashMinutesSummaryResponseBodyFlashMinutesSummarySummary] = None,
    ):
        self.status = status
        self.summary = summary

    def validate(self):
        if self.summary:
            for k in self.summary:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.status is not None:
            result['status'] = self.status
        result['summary'] = []
        if self.summary is not None:
            for k in self.summary:
                result['summary'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('status') is not None:
            self.status = m.get('status')
        self.summary = []
        if m.get('summary') is not None:
            for k in m.get('summary'):
                temp_model = QueryFlashMinutesSummaryResponseBodyFlashMinutesSummarySummary()
                self.summary.append(temp_model.from_map(k))
        return self


class QueryFlashMinutesSummaryResponseBody(TeaModel):
    def __init__(
        self,
        flash_minutes_summary: QueryFlashMinutesSummaryResponseBodyFlashMinutesSummary = None,
    ):
        self.flash_minutes_summary = flash_minutes_summary

    def validate(self):
        if self.flash_minutes_summary:
            self.flash_minutes_summary.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.flash_minutes_summary is not None:
            result['flashMinutesSummary'] = self.flash_minutes_summary.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('flashMinutesSummary') is not None:
            temp_model = QueryFlashMinutesSummaryResponseBodyFlashMinutesSummary()
            self.flash_minutes_summary = temp_model.from_map(m['flashMinutesSummary'])
        return self


class QueryFlashMinutesSummaryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryFlashMinutesSummaryResponseBody = None,
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
            temp_model = QueryFlashMinutesSummaryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryMinutesAudioHeaders(TeaModel):
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


class QueryMinutesAudioRequest(TeaModel):
    def __init__(
        self,
        union_id: str = None,
    ):
        # This parameter is required.
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


class QueryMinutesAudioResponseBodyAudioList(TeaModel):
    def __init__(
        self,
        duration: int = None,
        end_time: int = None,
        file_size: int = None,
        play_url: str = None,
        record_id: str = None,
        start_time: int = None,
        union_id: str = None,
    ):
        self.duration = duration
        self.end_time = end_time
        self.file_size = file_size
        self.play_url = play_url
        self.record_id = record_id
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
        if self.play_url is not None:
            result['playUrl'] = self.play_url
        if self.record_id is not None:
            result['recordId'] = self.record_id
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
        if m.get('playUrl') is not None:
            self.play_url = m.get('playUrl')
        if m.get('recordId') is not None:
            self.record_id = m.get('recordId')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class QueryMinutesAudioResponseBody(TeaModel):
    def __init__(
        self,
        audio_list: List[QueryMinutesAudioResponseBodyAudioList] = None,
    ):
        self.audio_list = audio_list

    def validate(self):
        if self.audio_list:
            for k in self.audio_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['audioList'] = []
        if self.audio_list is not None:
            for k in self.audio_list:
                result['audioList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.audio_list = []
        if m.get('audioList') is not None:
            for k in m.get('audioList'):
                temp_model = QueryMinutesAudioResponseBodyAudioList()
                self.audio_list.append(temp_model.from_map(k))
        return self


class QueryMinutesAudioResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryMinutesAudioResponseBody = None,
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
            temp_model = QueryMinutesAudioResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryMinutesSummaryHeaders(TeaModel):
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


class QueryMinutesSummaryRequest(TeaModel):
    def __init__(
        self,
        summary_type_list: List[str] = None,
        union_id: str = None,
    ):
        self.summary_type_list = summary_type_list
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.summary_type_list is not None:
            result['summaryTypeList'] = self.summary_type_list
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('summaryTypeList') is not None:
            self.summary_type_list = m.get('summaryTypeList')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class QueryMinutesSummaryResponseBodySummaryActions(TeaModel):
    def __init__(
        self,
        end: int = None,
        id: int = None,
        sentence_id: int = None,
        start: int = None,
        text: str = None,
    ):
        self.end = end
        self.id = id
        self.sentence_id = sentence_id
        self.start = start
        self.text = text

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end is not None:
            result['end'] = self.end
        if self.id is not None:
            result['id'] = self.id
        if self.sentence_id is not None:
            result['sentenceId'] = self.sentence_id
        if self.start is not None:
            result['start'] = self.start
        if self.text is not None:
            result['text'] = self.text
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('end') is not None:
            self.end = m.get('end')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('sentenceId') is not None:
            self.sentence_id = m.get('sentenceId')
        if m.get('start') is not None:
            self.start = m.get('start')
        if m.get('text') is not None:
            self.text = m.get('text')
        return self


class QueryMinutesSummaryResponseBodySummaryAutoChapters(TeaModel):
    def __init__(
        self,
        end: int = None,
        headline: str = None,
        id: int = None,
        start: int = None,
        summary: str = None,
    ):
        self.end = end
        self.headline = headline
        self.id = id
        self.start = start
        self.summary = summary

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end is not None:
            result['end'] = self.end
        if self.headline is not None:
            result['headline'] = self.headline
        if self.id is not None:
            result['id'] = self.id
        if self.start is not None:
            result['start'] = self.start
        if self.summary is not None:
            result['summary'] = self.summary
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('end') is not None:
            self.end = m.get('end')
        if m.get('headline') is not None:
            self.headline = m.get('headline')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('start') is not None:
            self.start = m.get('start')
        if m.get('summary') is not None:
            self.summary = m.get('summary')
        return self


class QueryMinutesSummaryResponseBodySummaryConversationalSummary(TeaModel):
    def __init__(
        self,
        speaker_id: str = None,
        speaker_name: str = None,
        summary: str = None,
    ):
        self.speaker_id = speaker_id
        self.speaker_name = speaker_name
        self.summary = summary

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.speaker_id is not None:
            result['speakerId'] = self.speaker_id
        if self.speaker_name is not None:
            result['speakerName'] = self.speaker_name
        if self.summary is not None:
            result['summary'] = self.summary
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('speakerId') is not None:
            self.speaker_id = m.get('speakerId')
        if m.get('speakerName') is not None:
            self.speaker_name = m.get('speakerName')
        if m.get('summary') is not None:
            self.summary = m.get('summary')
        return self


class QueryMinutesSummaryResponseBodySummaryKeySentences(TeaModel):
    def __init__(
        self,
        end: int = None,
        id: int = None,
        sentence_id: int = None,
        start: int = None,
        text: str = None,
    ):
        self.end = end
        self.id = id
        self.sentence_id = sentence_id
        self.start = start
        self.text = text

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end is not None:
            result['end'] = self.end
        if self.id is not None:
            result['id'] = self.id
        if self.sentence_id is not None:
            result['sentenceId'] = self.sentence_id
        if self.start is not None:
            result['start'] = self.start
        if self.text is not None:
            result['text'] = self.text
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('end') is not None:
            self.end = m.get('end')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('sentenceId') is not None:
            self.sentence_id = m.get('sentenceId')
        if m.get('start') is not None:
            self.start = m.get('start')
        if m.get('text') is not None:
            self.text = m.get('text')
        return self


class QueryMinutesSummaryResponseBodySummaryQuestionsAnsweringSummary(TeaModel):
    def __init__(
        self,
        answer: str = None,
        question: str = None,
        sentence_ids_of_answer: List[int] = None,
        sentence_ids_of_question: List[int] = None,
    ):
        self.answer = answer
        self.question = question
        self.sentence_ids_of_answer = sentence_ids_of_answer
        self.sentence_ids_of_question = sentence_ids_of_question

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.answer is not None:
            result['answer'] = self.answer
        if self.question is not None:
            result['question'] = self.question
        if self.sentence_ids_of_answer is not None:
            result['sentenceIdsOfAnswer'] = self.sentence_ids_of_answer
        if self.sentence_ids_of_question is not None:
            result['sentenceIdsOfQuestion'] = self.sentence_ids_of_question
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('answer') is not None:
            self.answer = m.get('answer')
        if m.get('question') is not None:
            self.question = m.get('question')
        if m.get('sentenceIdsOfAnswer') is not None:
            self.sentence_ids_of_answer = m.get('sentenceIdsOfAnswer')
        if m.get('sentenceIdsOfQuestion') is not None:
            self.sentence_ids_of_question = m.get('sentenceIdsOfQuestion')
        return self


class QueryMinutesSummaryResponseBodySummary(TeaModel):
    def __init__(
        self,
        actions: List[QueryMinutesSummaryResponseBodySummaryActions] = None,
        auto_chapters: List[QueryMinutesSummaryResponseBodySummaryAutoChapters] = None,
        conversational_summary: List[QueryMinutesSummaryResponseBodySummaryConversationalSummary] = None,
        key_sentences: List[QueryMinutesSummaryResponseBodySummaryKeySentences] = None,
        keywords: List[str] = None,
        paragraph_summary: str = None,
        questions_answering_summary: List[QueryMinutesSummaryResponseBodySummaryQuestionsAnsweringSummary] = None,
    ):
        self.actions = actions
        self.auto_chapters = auto_chapters
        self.conversational_summary = conversational_summary
        self.key_sentences = key_sentences
        self.keywords = keywords
        self.paragraph_summary = paragraph_summary
        self.questions_answering_summary = questions_answering_summary

    def validate(self):
        if self.actions:
            for k in self.actions:
                if k:
                    k.validate()
        if self.auto_chapters:
            for k in self.auto_chapters:
                if k:
                    k.validate()
        if self.conversational_summary:
            for k in self.conversational_summary:
                if k:
                    k.validate()
        if self.key_sentences:
            for k in self.key_sentences:
                if k:
                    k.validate()
        if self.questions_answering_summary:
            for k in self.questions_answering_summary:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['actions'] = []
        if self.actions is not None:
            for k in self.actions:
                result['actions'].append(k.to_map() if k else None)
        result['autoChapters'] = []
        if self.auto_chapters is not None:
            for k in self.auto_chapters:
                result['autoChapters'].append(k.to_map() if k else None)
        result['conversationalSummary'] = []
        if self.conversational_summary is not None:
            for k in self.conversational_summary:
                result['conversationalSummary'].append(k.to_map() if k else None)
        result['keySentences'] = []
        if self.key_sentences is not None:
            for k in self.key_sentences:
                result['keySentences'].append(k.to_map() if k else None)
        if self.keywords is not None:
            result['keywords'] = self.keywords
        if self.paragraph_summary is not None:
            result['paragraphSummary'] = self.paragraph_summary
        result['questionsAnsweringSummary'] = []
        if self.questions_answering_summary is not None:
            for k in self.questions_answering_summary:
                result['questionsAnsweringSummary'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.actions = []
        if m.get('actions') is not None:
            for k in m.get('actions'):
                temp_model = QueryMinutesSummaryResponseBodySummaryActions()
                self.actions.append(temp_model.from_map(k))
        self.auto_chapters = []
        if m.get('autoChapters') is not None:
            for k in m.get('autoChapters'):
                temp_model = QueryMinutesSummaryResponseBodySummaryAutoChapters()
                self.auto_chapters.append(temp_model.from_map(k))
        self.conversational_summary = []
        if m.get('conversationalSummary') is not None:
            for k in m.get('conversationalSummary'):
                temp_model = QueryMinutesSummaryResponseBodySummaryConversationalSummary()
                self.conversational_summary.append(temp_model.from_map(k))
        self.key_sentences = []
        if m.get('keySentences') is not None:
            for k in m.get('keySentences'):
                temp_model = QueryMinutesSummaryResponseBodySummaryKeySentences()
                self.key_sentences.append(temp_model.from_map(k))
        if m.get('keywords') is not None:
            self.keywords = m.get('keywords')
        if m.get('paragraphSummary') is not None:
            self.paragraph_summary = m.get('paragraphSummary')
        self.questions_answering_summary = []
        if m.get('questionsAnsweringSummary') is not None:
            for k in m.get('questionsAnsweringSummary'):
                temp_model = QueryMinutesSummaryResponseBodySummaryQuestionsAnsweringSummary()
                self.questions_answering_summary.append(temp_model.from_map(k))
        return self


class QueryMinutesSummaryResponseBody(TeaModel):
    def __init__(
        self,
        summary: QueryMinutesSummaryResponseBodySummary = None,
    ):
        self.summary = summary

    def validate(self):
        if self.summary:
            self.summary.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.summary is not None:
            result['summary'] = self.summary.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('summary') is not None:
            temp_model = QueryMinutesSummaryResponseBodySummary()
            self.summary = temp_model.from_map(m['summary'])
        return self


class QueryMinutesSummaryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryMinutesSummaryResponseBody = None,
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
            temp_model = QueryMinutesSummaryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryMinutesTextHeaders(TeaModel):
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


class QueryMinutesTextRequest(TeaModel):
    def __init__(
        self,
        direction: str = None,
        max_results: int = None,
        next_token: str = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.direction = direction
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
        if self.direction is not None:
            result['direction'] = self.direction
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
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
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class QueryMinutesTextResponseBodyParagraphListSentenceListWordList(TeaModel):
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


class QueryMinutesTextResponseBodyParagraphListSentenceList(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        sentence: str = None,
        start_time: int = None,
        union_id: str = None,
        word_list: List[QueryMinutesTextResponseBodyParagraphListSentenceListWordList] = None,
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
                temp_model = QueryMinutesTextResponseBodyParagraphListSentenceListWordList()
                self.word_list.append(temp_model.from_map(k))
        return self


class QueryMinutesTextResponseBodyParagraphList(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        nick_name: str = None,
        paragraph: str = None,
        paragraph_id: int = None,
        record_id: int = None,
        sentence_list: List[QueryMinutesTextResponseBodyParagraphListSentenceList] = None,
        start_time: int = None,
        union_id: str = None,
    ):
        self.end_time = end_time
        self.nick_name = nick_name
        self.paragraph = paragraph
        self.paragraph_id = paragraph_id
        self.record_id = record_id
        self.sentence_list = sentence_list
        self.start_time = start_time
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
        if self.nick_name is not None:
            result['nickName'] = self.nick_name
        if self.paragraph is not None:
            result['paragraph'] = self.paragraph
        if self.paragraph_id is not None:
            result['paragraphId'] = self.paragraph_id
        if self.record_id is not None:
            result['recordId'] = self.record_id
        result['sentenceList'] = []
        if self.sentence_list is not None:
            for k in self.sentence_list:
                result['sentenceList'].append(k.to_map() if k else None)
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('nickName') is not None:
            self.nick_name = m.get('nickName')
        if m.get('paragraph') is not None:
            self.paragraph = m.get('paragraph')
        if m.get('paragraphId') is not None:
            self.paragraph_id = m.get('paragraphId')
        if m.get('recordId') is not None:
            self.record_id = m.get('recordId')
        self.sentence_list = []
        if m.get('sentenceList') is not None:
            for k in m.get('sentenceList'):
                temp_model = QueryMinutesTextResponseBodyParagraphListSentenceList()
                self.sentence_list.append(temp_model.from_map(k))
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class QueryMinutesTextResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        next_token: str = None,
        paragraph_list: List[QueryMinutesTextResponseBodyParagraphList] = None,
    ):
        self.has_more = has_more
        self.next_token = next_token
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
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['paragraphList'] = []
        if self.paragraph_list is not None:
            for k in self.paragraph_list:
                result['paragraphList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.paragraph_list = []
        if m.get('paragraphList') is not None:
            for k in m.get('paragraphList'):
                temp_model = QueryMinutesTextResponseBodyParagraphList()
                self.paragraph_list.append(temp_model.from_map(k))
        return self


class QueryMinutesTextResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryMinutesTextResponseBody = None,
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
            temp_model = QueryMinutesTextResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryRecordMinutesUrlHeaders(TeaModel):
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


class QueryRecordMinutesUrlRequest(TeaModel):
    def __init__(
        self,
        biz_type: str = None,
        recorder_union_id: str = None,
    ):
        # This parameter is required.
        self.biz_type = biz_type
        # This parameter is required.
        self.recorder_union_id = recorder_union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.recorder_union_id is not None:
            result['recorderUnionId'] = self.recorder_union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('recorderUnionId') is not None:
            self.recorder_union_id = m.get('recorderUnionId')
        return self


class QueryRecordMinutesUrlResponseBodyRecordMinutesUrls(TeaModel):
    def __init__(
        self,
        record_minutes_url: str = None,
    ):
        self.record_minutes_url = record_minutes_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.record_minutes_url is not None:
            result['recordMinutesUrl'] = self.record_minutes_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('recordMinutesUrl') is not None:
            self.record_minutes_url = m.get('recordMinutesUrl')
        return self


class QueryRecordMinutesUrlResponseBody(TeaModel):
    def __init__(
        self,
        record_minutes_urls: List[QueryRecordMinutesUrlResponseBodyRecordMinutesUrls] = None,
    ):
        self.record_minutes_urls = record_minutes_urls

    def validate(self):
        if self.record_minutes_urls:
            for k in self.record_minutes_urls:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['recordMinutesUrls'] = []
        if self.record_minutes_urls is not None:
            for k in self.record_minutes_urls:
                result['recordMinutesUrls'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.record_minutes_urls = []
        if m.get('recordMinutesUrls') is not None:
            for k in m.get('recordMinutesUrls'):
                temp_model = QueryRecordMinutesUrlResponseBodyRecordMinutesUrls()
                self.record_minutes_urls.append(temp_model.from_map(k))
        return self


class QueryRecordMinutesUrlResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryRecordMinutesUrlResponseBody = None,
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
            temp_model = QueryRecordMinutesUrlResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryScheduleConfSettingsHeaders(TeaModel):
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


class QueryScheduleConfSettingsRequest(TeaModel):
    def __init__(
        self,
        schedule_conference_id: str = None,
    ):
        # This parameter is required.
        self.schedule_conference_id = schedule_conference_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.schedule_conference_id is not None:
            result['scheduleConferenceId'] = self.schedule_conference_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('scheduleConferenceId') is not None:
            self.schedule_conference_id = m.get('scheduleConferenceId')
        return self


class QueryScheduleConfSettingsResponseBodyScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings(TeaModel):
    def __init__(
        self,
        auto_open_mode: str = None,
        client_id: str = None,
        cool_app_code: str = None,
        extension_app_biz_data: str = None,
    ):
        self.auto_open_mode = auto_open_mode
        self.client_id = client_id
        self.cool_app_code = cool_app_code
        self.extension_app_biz_data = extension_app_biz_data

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.auto_open_mode is not None:
            result['autoOpenMode'] = self.auto_open_mode
        if self.client_id is not None:
            result['clientId'] = self.client_id
        if self.cool_app_code is not None:
            result['coolAppCode'] = self.cool_app_code
        if self.extension_app_biz_data is not None:
            result['extensionAppBizData'] = self.extension_app_biz_data
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('autoOpenMode') is not None:
            self.auto_open_mode = m.get('autoOpenMode')
        if m.get('clientId') is not None:
            self.client_id = m.get('clientId')
        if m.get('coolAppCode') is not None:
            self.cool_app_code = m.get('coolAppCode')
        if m.get('extensionAppBizData') is not None:
            self.extension_app_biz_data = m.get('extensionAppBizData')
        return self


class QueryScheduleConfSettingsResponseBodyScheduleConfSettingModelMoziConfVirtualExtraSetting(TeaModel):
    def __init__(
        self,
        enable_chat: int = None,
        enable_web_anonymous_join: bool = None,
        join_before_host: int = None,
        lock_media_status_mic_mute: int = None,
        lock_nick: int = None,
        mozi_conf_extension_app_settings: List[QueryScheduleConfSettingsResponseBodyScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings] = None,
        waiting_room: int = None,
    ):
        self.enable_chat = enable_chat
        self.enable_web_anonymous_join = enable_web_anonymous_join
        self.join_before_host = join_before_host
        self.lock_media_status_mic_mute = lock_media_status_mic_mute
        self.lock_nick = lock_nick
        self.mozi_conf_extension_app_settings = mozi_conf_extension_app_settings
        self.waiting_room = waiting_room

    def validate(self):
        if self.mozi_conf_extension_app_settings:
            for k in self.mozi_conf_extension_app_settings:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.enable_chat is not None:
            result['enableChat'] = self.enable_chat
        if self.enable_web_anonymous_join is not None:
            result['enableWebAnonymousJoin'] = self.enable_web_anonymous_join
        if self.join_before_host is not None:
            result['joinBeforeHost'] = self.join_before_host
        if self.lock_media_status_mic_mute is not None:
            result['lockMediaStatusMicMute'] = self.lock_media_status_mic_mute
        if self.lock_nick is not None:
            result['lockNick'] = self.lock_nick
        result['moziConfExtensionAppSettings'] = []
        if self.mozi_conf_extension_app_settings is not None:
            for k in self.mozi_conf_extension_app_settings:
                result['moziConfExtensionAppSettings'].append(k.to_map() if k else None)
        if self.waiting_room is not None:
            result['waitingRoom'] = self.waiting_room
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('enableChat') is not None:
            self.enable_chat = m.get('enableChat')
        if m.get('enableWebAnonymousJoin') is not None:
            self.enable_web_anonymous_join = m.get('enableWebAnonymousJoin')
        if m.get('joinBeforeHost') is not None:
            self.join_before_host = m.get('joinBeforeHost')
        if m.get('lockMediaStatusMicMute') is not None:
            self.lock_media_status_mic_mute = m.get('lockMediaStatusMicMute')
        if m.get('lockNick') is not None:
            self.lock_nick = m.get('lockNick')
        self.mozi_conf_extension_app_settings = []
        if m.get('moziConfExtensionAppSettings') is not None:
            for k in m.get('moziConfExtensionAppSettings'):
                temp_model = QueryScheduleConfSettingsResponseBodyScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings()
                self.mozi_conf_extension_app_settings.append(temp_model.from_map(k))
        if m.get('waitingRoom') is not None:
            self.waiting_room = m.get('waitingRoom')
        return self


class QueryScheduleConfSettingsResponseBodyScheduleConfSettingModel(TeaModel):
    def __init__(
        self,
        cohost_union_ids: List[str] = None,
        conf_allowed_corp_id: str = None,
        host_union_id: str = None,
        lock_room: int = None,
        mozi_conf_virtual_extra_setting: QueryScheduleConfSettingsResponseBodyScheduleConfSettingModelMoziConfVirtualExtraSetting = None,
        mute_on_join: int = None,
        screen_share_forbidden: int = None,
    ):
        self.cohost_union_ids = cohost_union_ids
        self.conf_allowed_corp_id = conf_allowed_corp_id
        self.host_union_id = host_union_id
        self.lock_room = lock_room
        self.mozi_conf_virtual_extra_setting = mozi_conf_virtual_extra_setting
        self.mute_on_join = mute_on_join
        self.screen_share_forbidden = screen_share_forbidden

    def validate(self):
        if self.mozi_conf_virtual_extra_setting:
            self.mozi_conf_virtual_extra_setting.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cohost_union_ids is not None:
            result['cohostUnionIds'] = self.cohost_union_ids
        if self.conf_allowed_corp_id is not None:
            result['confAllowedCorpId'] = self.conf_allowed_corp_id
        if self.host_union_id is not None:
            result['hostUnionId'] = self.host_union_id
        if self.lock_room is not None:
            result['lockRoom'] = self.lock_room
        if self.mozi_conf_virtual_extra_setting is not None:
            result['moziConfVirtualExtraSetting'] = self.mozi_conf_virtual_extra_setting.to_map()
        if self.mute_on_join is not None:
            result['muteOnJoin'] = self.mute_on_join
        if self.screen_share_forbidden is not None:
            result['screenShareForbidden'] = self.screen_share_forbidden
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cohostUnionIds') is not None:
            self.cohost_union_ids = m.get('cohostUnionIds')
        if m.get('confAllowedCorpId') is not None:
            self.conf_allowed_corp_id = m.get('confAllowedCorpId')
        if m.get('hostUnionId') is not None:
            self.host_union_id = m.get('hostUnionId')
        if m.get('lockRoom') is not None:
            self.lock_room = m.get('lockRoom')
        if m.get('moziConfVirtualExtraSetting') is not None:
            temp_model = QueryScheduleConfSettingsResponseBodyScheduleConfSettingModelMoziConfVirtualExtraSetting()
            self.mozi_conf_virtual_extra_setting = temp_model.from_map(m['moziConfVirtualExtraSetting'])
        if m.get('muteOnJoin') is not None:
            self.mute_on_join = m.get('muteOnJoin')
        if m.get('screenShareForbidden') is not None:
            self.screen_share_forbidden = m.get('screenShareForbidden')
        return self


class QueryScheduleConfSettingsResponseBody(TeaModel):
    def __init__(
        self,
        schedule_conf_setting_model: QueryScheduleConfSettingsResponseBodyScheduleConfSettingModel = None,
    ):
        self.schedule_conf_setting_model = schedule_conf_setting_model

    def validate(self):
        if self.schedule_conf_setting_model:
            self.schedule_conf_setting_model.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.schedule_conf_setting_model is not None:
            result['scheduleConfSettingModel'] = self.schedule_conf_setting_model.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('scheduleConfSettingModel') is not None:
            temp_model = QueryScheduleConfSettingsResponseBodyScheduleConfSettingModel()
            self.schedule_conf_setting_model = temp_model.from_map(m['scheduleConfSettingModel'])
        return self


class QueryScheduleConfSettingsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryScheduleConfSettingsResponseBody = None,
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
            temp_model = QueryScheduleConfSettingsResponseBody()
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
        # This parameter is required.
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
        # This parameter is required.
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
        # This parameter is required.
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
        # This parameter is required.
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


class StartMinutesHeaders(TeaModel):
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


class StartMinutesRequest(TeaModel):
    def __init__(
        self,
        owner_union_id: str = None,
        record_audio: bool = None,
        union_id: str = None,
    ):
        self.owner_union_id = owner_union_id
        self.record_audio = record_audio
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.owner_union_id is not None:
            result['ownerUnionId'] = self.owner_union_id
        if self.record_audio is not None:
            result['recordAudio'] = self.record_audio
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('ownerUnionId') is not None:
            self.owner_union_id = m.get('ownerUnionId')
        if m.get('recordAudio') is not None:
            self.record_audio = m.get('recordAudio')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class StartMinutesResponseBody(TeaModel):
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


class StartMinutesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: StartMinutesResponseBody = None,
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
            temp_model = StartMinutesResponseBody()
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
        # This parameter is required.
        self.mode = mode
        # This parameter is required.
        self.need_host_join = need_host_join
        # This parameter is required.
        self.small_window_position = small_window_position
        # This parameter is required.
        self.stream_name = stream_name
        # This parameter is required.
        self.stream_url_list = stream_url_list
        # This parameter is required.
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
        # This parameter is required.
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


class StopMinutesHeaders(TeaModel):
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


class StopMinutesRequest(TeaModel):
    def __init__(
        self,
        union_id: str = None,
    ):
        # This parameter is required.
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


class StopMinutesResponseBody(TeaModel):
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


class StopMinutesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: StopMinutesResponseBody = None,
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
            temp_model = StopMinutesResponseBody()
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
        # This parameter is required.
        self.stop_all_stream = stop_all_stream
        # This parameter is required.
        self.stream_id = stream_id
        # This parameter is required.
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
        # This parameter is required.
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


class UpdateScheduleConfSettingsHeaders(TeaModel):
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


class UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfOpenRecordSetting(TeaModel):
    def __init__(
        self,
        is_follow_host: bool = None,
        mode: str = None,
        record_auto_start: int = None,
        record_auto_start_type: int = None,
    ):
        self.is_follow_host = is_follow_host
        self.mode = mode
        self.record_auto_start = record_auto_start
        self.record_auto_start_type = record_auto_start_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.is_follow_host is not None:
            result['isFollowHost'] = self.is_follow_host
        if self.mode is not None:
            result['mode'] = self.mode
        if self.record_auto_start is not None:
            result['recordAutoStart'] = self.record_auto_start
        if self.record_auto_start_type is not None:
            result['recordAutoStartType'] = self.record_auto_start_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isFollowHost') is not None:
            self.is_follow_host = m.get('isFollowHost')
        if m.get('mode') is not None:
            self.mode = m.get('mode')
        if m.get('recordAutoStart') is not None:
            self.record_auto_start = m.get('recordAutoStart')
        if m.get('recordAutoStartType') is not None:
            self.record_auto_start_type = m.get('recordAutoStartType')
        return self


class UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings(TeaModel):
    def __init__(
        self,
        auto_open_mode: int = None,
        cool_app_code: str = None,
        extension_app_biz_data: str = None,
    ):
        self.auto_open_mode = auto_open_mode
        self.cool_app_code = cool_app_code
        self.extension_app_biz_data = extension_app_biz_data

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.auto_open_mode is not None:
            result['autoOpenMode'] = self.auto_open_mode
        if self.cool_app_code is not None:
            result['coolAppCode'] = self.cool_app_code
        if self.extension_app_biz_data is not None:
            result['extensionAppBizData'] = self.extension_app_biz_data
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('autoOpenMode') is not None:
            self.auto_open_mode = m.get('autoOpenMode')
        if m.get('coolAppCode') is not None:
            self.cool_app_code = m.get('coolAppCode')
        if m.get('extensionAppBizData') is not None:
            self.extension_app_biz_data = m.get('extensionAppBizData')
        return self


class UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSetting(TeaModel):
    def __init__(
        self,
        cloud_record_owner_union_id: str = None,
        enable_chat: int = None,
        enable_web_anonymous_join: bool = None,
        join_before_host: int = None,
        lock_media_status_mic_mute: int = None,
        lock_nick: int = None,
        minutes_owner_union_id: str = None,
        mozi_conf_extension_app_settings: List[UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings] = None,
        push_all_meeting_records: bool = None,
        push_cloud_record_card: bool = None,
        push_minutes_card: bool = None,
        waiting_room: int = None,
    ):
        self.cloud_record_owner_union_id = cloud_record_owner_union_id
        self.enable_chat = enable_chat
        self.enable_web_anonymous_join = enable_web_anonymous_join
        self.join_before_host = join_before_host
        self.lock_media_status_mic_mute = lock_media_status_mic_mute
        self.lock_nick = lock_nick
        self.minutes_owner_union_id = minutes_owner_union_id
        self.mozi_conf_extension_app_settings = mozi_conf_extension_app_settings
        self.push_all_meeting_records = push_all_meeting_records
        self.push_cloud_record_card = push_cloud_record_card
        self.push_minutes_card = push_minutes_card
        self.waiting_room = waiting_room

    def validate(self):
        if self.mozi_conf_extension_app_settings:
            for k in self.mozi_conf_extension_app_settings:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cloud_record_owner_union_id is not None:
            result['cloudRecordOwnerUnionId'] = self.cloud_record_owner_union_id
        if self.enable_chat is not None:
            result['enableChat'] = self.enable_chat
        if self.enable_web_anonymous_join is not None:
            result['enableWebAnonymousJoin'] = self.enable_web_anonymous_join
        if self.join_before_host is not None:
            result['joinBeforeHost'] = self.join_before_host
        if self.lock_media_status_mic_mute is not None:
            result['lockMediaStatusMicMute'] = self.lock_media_status_mic_mute
        if self.lock_nick is not None:
            result['lockNick'] = self.lock_nick
        if self.minutes_owner_union_id is not None:
            result['minutesOwnerUnionId'] = self.minutes_owner_union_id
        result['moziConfExtensionAppSettings'] = []
        if self.mozi_conf_extension_app_settings is not None:
            for k in self.mozi_conf_extension_app_settings:
                result['moziConfExtensionAppSettings'].append(k.to_map() if k else None)
        if self.push_all_meeting_records is not None:
            result['pushAllMeetingRecords'] = self.push_all_meeting_records
        if self.push_cloud_record_card is not None:
            result['pushCloudRecordCard'] = self.push_cloud_record_card
        if self.push_minutes_card is not None:
            result['pushMinutesCard'] = self.push_minutes_card
        if self.waiting_room is not None:
            result['waitingRoom'] = self.waiting_room
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cloudRecordOwnerUnionId') is not None:
            self.cloud_record_owner_union_id = m.get('cloudRecordOwnerUnionId')
        if m.get('enableChat') is not None:
            self.enable_chat = m.get('enableChat')
        if m.get('enableWebAnonymousJoin') is not None:
            self.enable_web_anonymous_join = m.get('enableWebAnonymousJoin')
        if m.get('joinBeforeHost') is not None:
            self.join_before_host = m.get('joinBeforeHost')
        if m.get('lockMediaStatusMicMute') is not None:
            self.lock_media_status_mic_mute = m.get('lockMediaStatusMicMute')
        if m.get('lockNick') is not None:
            self.lock_nick = m.get('lockNick')
        if m.get('minutesOwnerUnionId') is not None:
            self.minutes_owner_union_id = m.get('minutesOwnerUnionId')
        self.mozi_conf_extension_app_settings = []
        if m.get('moziConfExtensionAppSettings') is not None:
            for k in m.get('moziConfExtensionAppSettings'):
                temp_model = UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings()
                self.mozi_conf_extension_app_settings.append(temp_model.from_map(k))
        if m.get('pushAllMeetingRecords') is not None:
            self.push_all_meeting_records = m.get('pushAllMeetingRecords')
        if m.get('pushCloudRecordCard') is not None:
            self.push_cloud_record_card = m.get('pushCloudRecordCard')
        if m.get('pushMinutesCard') is not None:
            self.push_minutes_card = m.get('pushMinutesCard')
        if m.get('waitingRoom') is not None:
            self.waiting_room = m.get('waitingRoom')
        return self


class UpdateScheduleConfSettingsRequestScheduleConfSettingModel(TeaModel):
    def __init__(
        self,
        cohost_union_ids: List[str] = None,
        conf_allowed_corp_id: str = None,
        host_union_id: str = None,
        lock_room: int = None,
        mozi_conf_open_record_setting: UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfOpenRecordSetting = None,
        mozi_conf_virtual_extra_setting: UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSetting = None,
        mute_on_join: int = None,
        screen_share_forbidden: int = None,
    ):
        self.cohost_union_ids = cohost_union_ids
        self.conf_allowed_corp_id = conf_allowed_corp_id
        self.host_union_id = host_union_id
        self.lock_room = lock_room
        self.mozi_conf_open_record_setting = mozi_conf_open_record_setting
        self.mozi_conf_virtual_extra_setting = mozi_conf_virtual_extra_setting
        self.mute_on_join = mute_on_join
        self.screen_share_forbidden = screen_share_forbidden

    def validate(self):
        if self.mozi_conf_open_record_setting:
            self.mozi_conf_open_record_setting.validate()
        if self.mozi_conf_virtual_extra_setting:
            self.mozi_conf_virtual_extra_setting.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cohost_union_ids is not None:
            result['cohostUnionIds'] = self.cohost_union_ids
        if self.conf_allowed_corp_id is not None:
            result['confAllowedCorpId'] = self.conf_allowed_corp_id
        if self.host_union_id is not None:
            result['hostUnionId'] = self.host_union_id
        if self.lock_room is not None:
            result['lockRoom'] = self.lock_room
        if self.mozi_conf_open_record_setting is not None:
            result['moziConfOpenRecordSetting'] = self.mozi_conf_open_record_setting.to_map()
        if self.mozi_conf_virtual_extra_setting is not None:
            result['moziConfVirtualExtraSetting'] = self.mozi_conf_virtual_extra_setting.to_map()
        if self.mute_on_join is not None:
            result['muteOnJoin'] = self.mute_on_join
        if self.screen_share_forbidden is not None:
            result['screenShareForbidden'] = self.screen_share_forbidden
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cohostUnionIds') is not None:
            self.cohost_union_ids = m.get('cohostUnionIds')
        if m.get('confAllowedCorpId') is not None:
            self.conf_allowed_corp_id = m.get('confAllowedCorpId')
        if m.get('hostUnionId') is not None:
            self.host_union_id = m.get('hostUnionId')
        if m.get('lockRoom') is not None:
            self.lock_room = m.get('lockRoom')
        if m.get('moziConfOpenRecordSetting') is not None:
            temp_model = UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfOpenRecordSetting()
            self.mozi_conf_open_record_setting = temp_model.from_map(m['moziConfOpenRecordSetting'])
        if m.get('moziConfVirtualExtraSetting') is not None:
            temp_model = UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSetting()
            self.mozi_conf_virtual_extra_setting = temp_model.from_map(m['moziConfVirtualExtraSetting'])
        if m.get('muteOnJoin') is not None:
            self.mute_on_join = m.get('muteOnJoin')
        if m.get('screenShareForbidden') is not None:
            self.screen_share_forbidden = m.get('screenShareForbidden')
        return self


class UpdateScheduleConfSettingsRequest(TeaModel):
    def __init__(
        self,
        creator_union_id: str = None,
        schedule_conf_setting_model: UpdateScheduleConfSettingsRequestScheduleConfSettingModel = None,
        schedule_conference_id: str = None,
    ):
        self.creator_union_id = creator_union_id
        self.schedule_conf_setting_model = schedule_conf_setting_model
        self.schedule_conference_id = schedule_conference_id

    def validate(self):
        if self.schedule_conf_setting_model:
            self.schedule_conf_setting_model.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.creator_union_id is not None:
            result['creatorUnionId'] = self.creator_union_id
        if self.schedule_conf_setting_model is not None:
            result['scheduleConfSettingModel'] = self.schedule_conf_setting_model.to_map()
        if self.schedule_conference_id is not None:
            result['scheduleConferenceId'] = self.schedule_conference_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('creatorUnionId') is not None:
            self.creator_union_id = m.get('creatorUnionId')
        if m.get('scheduleConfSettingModel') is not None:
            temp_model = UpdateScheduleConfSettingsRequestScheduleConfSettingModel()
            self.schedule_conf_setting_model = temp_model.from_map(m['scheduleConfSettingModel'])
        if m.get('scheduleConferenceId') is not None:
            self.schedule_conference_id = m.get('scheduleConferenceId')
        return self


class UpdateScheduleConfSettingsResponseBody(TeaModel):
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


class UpdateScheduleConfSettingsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateScheduleConfSettingsResponseBody = None,
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
            temp_model = UpdateScheduleConfSettingsResponseBody()
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
        # This parameter is required.
        self.creator_union_id = creator_union_id
        # This parameter is required.
        self.end_time = end_time
        # This parameter is required.
        self.schedule_conference_id = schedule_conference_id
        # This parameter is required.
        self.start_time = start_time
        # This parameter is required.
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


