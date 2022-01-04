# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class MachineUsersUpdateHeaders(TeaModel):
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


class MachineUsersUpdateRequest(TeaModel):
    def __init__(
        self,
        del_user_ids: List[str] = None,
        device_ids: List[str] = None,
        add_user_ids: List[str] = None,
        dev_ids: List[int] = None,
        ding_token_grant_type: int = None,
        ding_suite_key: str = None,
        ding_corp_id: str = None,
        ding_org_id: int = None,
        ding_isv_org_id: int = None,
    ):
        # 移除的员工id列表
        self.del_user_ids = del_user_ids
        # 设备唯一标识id列表，字符串数组
        self.device_ids = device_ids
        # 新增的员工id列表
        self.add_user_ids = add_user_ids
        # 设备唯一标识id列表，Long数组
        self.dev_ids = dev_ids
        self.ding_token_grant_type = ding_token_grant_type
        self.ding_suite_key = ding_suite_key
        self.ding_corp_id = ding_corp_id
        self.ding_org_id = ding_org_id
        self.ding_isv_org_id = ding_isv_org_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.del_user_ids is not None:
            result['delUserIds'] = self.del_user_ids
        if self.device_ids is not None:
            result['deviceIds'] = self.device_ids
        if self.add_user_ids is not None:
            result['addUserIds'] = self.add_user_ids
        if self.dev_ids is not None:
            result['devIds'] = self.dev_ids
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_corp_id is not None:
            result['dingCorpId'] = self.ding_corp_id
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('delUserIds') is not None:
            self.del_user_ids = m.get('delUserIds')
        if m.get('deviceIds') is not None:
            self.device_ids = m.get('deviceIds')
        if m.get('addUserIds') is not None:
            self.add_user_ids = m.get('addUserIds')
        if m.get('devIds') is not None:
            self.dev_ids = m.get('devIds')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingCorpId') is not None:
            self.ding_corp_id = m.get('dingCorpId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        return self


class MachineUsersUpdateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        return self


class AddDeviceVideoConferenceMembersHeaders(TeaModel):
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


class AddDeviceVideoConferenceMembersRequest(TeaModel):
    def __init__(
        self,
        user_ids: List[str] = None,
    ):
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class AddDeviceVideoConferenceMembersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        return self


class CreateDeviceVideoConferenceHeaders(TeaModel):
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


class CreateDeviceVideoConferenceRequest(TeaModel):
    def __init__(
        self,
        user_ids: List[str] = None,
    ):
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class CreateDeviceVideoConferenceResponseBody(TeaModel):
    def __init__(
        self,
        conference_id: str = None,
        code: str = None,
    ):
        # 会议id
        self.conference_id = conference_id
        # 入会口令
        self.code = code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conference_id is not None:
            result['conferenceId'] = self.conference_id
        if self.code is not None:
            result['code'] = self.code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conferenceId') is not None:
            self.conference_id = m.get('conferenceId')
        if m.get('code') is not None:
            self.code = m.get('code')
        return self


class CreateDeviceVideoConferenceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateDeviceVideoConferenceResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
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
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = CreateDeviceVideoConferenceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryDeviceVideoConferenceBookHeaders(TeaModel):
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


class QueryDeviceVideoConferenceBookResponseBody(TeaModel):
    def __init__(
        self,
        code: str = None,
        conference_id: str = None,
    ):
        # 入会口令
        self.code = code
        # 会议id
        self.conference_id = conference_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.conference_id is not None:
            result['conferenceId'] = self.conference_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('conferenceId') is not None:
            self.conference_id = m.get('conferenceId')
        return self


class QueryDeviceVideoConferenceBookResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryDeviceVideoConferenceBookResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
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
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = QueryDeviceVideoConferenceBookResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class MachineManagerUpdateHeaders(TeaModel):
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


class MachineManagerUpdateRequestAtmManagerRightMap(TeaModel):
    def __init__(
        self,
        attendance_person_manage: bool = None,
        finger_punch_manage: bool = None,
        face_punch_manage: bool = None,
        bluetooth_punch_manage: bool = None,
        device_settings: bool = None,
        device_reset: bool = None,
    ):
        # 添加/删除考勤人员。
        self.attendance_person_manage = attendance_person_manage
        # 指纹打卡管理。
        self.finger_punch_manage = finger_punch_manage
        # 人脸打卡管理。
        self.face_punch_manage = face_punch_manage
        # 蓝牙打卡管理。
        self.bluetooth_punch_manage = bluetooth_punch_manage
        # 设备设置。
        self.device_settings = device_settings
        # 设备解绑并重置。
        self.device_reset = device_reset

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.attendance_person_manage is not None:
            result['attendancePersonManage'] = self.attendance_person_manage
        if self.finger_punch_manage is not None:
            result['fingerPunchManage'] = self.finger_punch_manage
        if self.face_punch_manage is not None:
            result['facePunchManage'] = self.face_punch_manage
        if self.bluetooth_punch_manage is not None:
            result['bluetoothPunchManage'] = self.bluetooth_punch_manage
        if self.device_settings is not None:
            result['deviceSettings'] = self.device_settings
        if self.device_reset is not None:
            result['deviceReset'] = self.device_reset
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('attendancePersonManage') is not None:
            self.attendance_person_manage = m.get('attendancePersonManage')
        if m.get('fingerPunchManage') is not None:
            self.finger_punch_manage = m.get('fingerPunchManage')
        if m.get('facePunchManage') is not None:
            self.face_punch_manage = m.get('facePunchManage')
        if m.get('bluetoothPunchManage') is not None:
            self.bluetooth_punch_manage = m.get('bluetoothPunchManage')
        if m.get('deviceSettings') is not None:
            self.device_settings = m.get('deviceSettings')
        if m.get('deviceReset') is not None:
            self.device_reset = m.get('deviceReset')
        return self


class MachineManagerUpdateRequest(TeaModel):
    def __init__(
        self,
        device_id: int = None,
        user_id: str = None,
        scope_dept_ids: List[int] = None,
        atm_manager_right_map: MachineManagerUpdateRequestAtmManagerRightMap = None,
        ding_token_grant_type: int = None,
        ding_suite_key: str = None,
        ding_corp_id: str = None,
        ding_org_id: int = None,
        ding_isv_org_id: int = None,
    ):
        # 设备id。
        self.device_id = device_id
        # 设备管理员的userId。
        self.user_id = user_id
        # 权限范围：可管理的部门id列表，-1表示全公司
        self.scope_dept_ids = scope_dept_ids
        # 设备管理员权限点。
        self.atm_manager_right_map = atm_manager_right_map
        self.ding_token_grant_type = ding_token_grant_type
        self.ding_suite_key = ding_suite_key
        self.ding_corp_id = ding_corp_id
        self.ding_org_id = ding_org_id
        self.ding_isv_org_id = ding_isv_org_id

    def validate(self):
        if self.atm_manager_right_map:
            self.atm_manager_right_map.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_id is not None:
            result['deviceId'] = self.device_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.scope_dept_ids is not None:
            result['scopeDeptIds'] = self.scope_dept_ids
        if self.atm_manager_right_map is not None:
            result['atmManagerRightMap'] = self.atm_manager_right_map.to_map()
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_corp_id is not None:
            result['dingCorpId'] = self.ding_corp_id
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceId') is not None:
            self.device_id = m.get('deviceId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('scopeDeptIds') is not None:
            self.scope_dept_ids = m.get('scopeDeptIds')
        if m.get('atmManagerRightMap') is not None:
            temp_model = MachineManagerUpdateRequestAtmManagerRightMap()
            self.atm_manager_right_map = temp_model.from_map(m['atmManagerRightMap'])
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingCorpId') is not None:
            self.ding_corp_id = m.get('dingCorpId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        return self


class MachineManagerUpdateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        return self


class KickDeviceVideoConferenceMembersHeaders(TeaModel):
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


class KickDeviceVideoConferenceMembersRequest(TeaModel):
    def __init__(
        self,
        user_ids: List[str] = None,
    ):
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class KickDeviceVideoConferenceMembersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        return self


class ExtractFacialFeatureHeaders(TeaModel):
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


class ExtractFacialFeatureRequest(TeaModel):
    def __init__(
        self,
        userid: str = None,
        media_id: str = None,
    ):
        self.userid = userid
        self.media_id = media_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.userid is not None:
            result['userid'] = self.userid
        if self.media_id is not None:
            result['mediaId'] = self.media_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userid') is not None:
            self.userid = m.get('userid')
        if m.get('mediaId') is not None:
            self.media_id = m.get('mediaId')
        return self


class ExtractFacialFeatureResponseBody(TeaModel):
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


class ExtractFacialFeatureResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ExtractFacialFeatureResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
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
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            temp_model = ExtractFacialFeatureResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


