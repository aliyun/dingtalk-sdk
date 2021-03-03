# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict


class CreateApproveHeaders(TeaModel):
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


class CreateApproveRequestPunchParam(TeaModel):
    def __init__(
        self,
        punch_time: int = None,
        position_id: str = None,
        position_type: str = None,
        position_name: str = None,
    ):
        # 打卡时间，单位毫秒
        self.punch_time = punch_time
        # 地理位置标识：wifi:ssid_macAddress ble: deviceId gps:longitude_latitude
        self.position_id = position_id
        # 地理位置类型：wifi/ble/gps
        self.position_type = position_type
        # 地理位置名称
        self.position_name = position_name

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.punch_time is not None:
            result['punchTime'] = self.punch_time
        if self.position_id is not None:
            result['positionId'] = self.position_id
        if self.position_type is not None:
            result['positionType'] = self.position_type
        if self.position_name is not None:
            result['positionName'] = self.position_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('punchTime') is not None:
            self.punch_time = m.get('punchTime')
        if m.get('positionId') is not None:
            self.position_id = m.get('positionId')
        if m.get('positionType') is not None:
            self.position_type = m.get('positionType')
        if m.get('positionName') is not None:
            self.position_name = m.get('positionName')
        return self


class CreateApproveRequest(TeaModel):
    def __init__(
        self,
        userid: str = None,
        tag_name: str = None,
        sub_type: str = None,
        punch_param: CreateApproveRequestPunchParam = None,
        approve_id: str = None,
        op_userid: str = None,
    ):
        # 员工id
        self.userid = userid
        # 审批单类型名称，最大长度20个字符
        self.tag_name = tag_name
        # 子类型名称，最大长度20个字符
        self.sub_type = sub_type
        # 审批单关联的打卡信息
        self.punch_param = punch_param
        # 三方审批单id，全局唯一
        self.approve_id = approve_id
        # 审批人员工id
        self.op_userid = op_userid

    def validate(self):
        if self.punch_param:
            self.punch_param.validate()

    def to_map(self):
        result = dict()
        if self.userid is not None:
            result['userid'] = self.userid
        if self.tag_name is not None:
            result['tagName'] = self.tag_name
        if self.sub_type is not None:
            result['subType'] = self.sub_type
        if self.punch_param is not None:
            result['punchParam'] = self.punch_param.to_map()
        if self.approve_id is not None:
            result['approveId'] = self.approve_id
        if self.op_userid is not None:
            result['opUserid'] = self.op_userid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userid') is not None:
            self.userid = m.get('userid')
        if m.get('tagName') is not None:
            self.tag_name = m.get('tagName')
        if m.get('subType') is not None:
            self.sub_type = m.get('subType')
        if m.get('punchParam') is not None:
            temp_model = CreateApproveRequestPunchParam()
            self.punch_param = temp_model.from_map(m['punchParam'])
        if m.get('approveId') is not None:
            self.approve_id = m.get('approveId')
        if m.get('opUserid') is not None:
            self.op_userid = m.get('opUserid')
        return self


class CreateApproveResponseBody(TeaModel):
    def __init__(
        self,
        dingtalk_approve_id: str = None,
    ):
        # 返回结果
        self.dingtalk_approve_id = dingtalk_approve_id

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.dingtalk_approve_id is not None:
            result['dingtalkApproveId'] = self.dingtalk_approve_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingtalkApproveId') is not None:
            self.dingtalk_approve_id = m.get('dingtalkApproveId')
        return self


class CreateApproveResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateApproveResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
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
            temp_model = CreateApproveResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


