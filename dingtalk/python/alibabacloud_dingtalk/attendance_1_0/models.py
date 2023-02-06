# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List, Any


class AddLeaveTypeHeaders(TeaModel):
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


class AddLeaveTypeRequestLeaveCertificate(TeaModel):
    def __init__(
        self,
        duration: float = None,
        enable: bool = None,
        prompt_information: str = None,
        unit: str = None,
    ):
        # 超过多长时间需提供请假证明
        self.duration = duration
        # 是否开启请假证明
        self.enable = enable
        # 请假提示文案
        self.prompt_information = prompt_information
        # 请假证明单位hour，day
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.duration is not None:
            result['duration'] = self.duration
        if self.enable is not None:
            result['enable'] = self.enable
        if self.prompt_information is not None:
            result['promptInformation'] = self.prompt_information
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('enable') is not None:
            self.enable = m.get('enable')
        if m.get('promptInformation') is not None:
            self.prompt_information = m.get('promptInformation')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class AddLeaveTypeRequestSubmitTimeRule(TeaModel):
    def __init__(
        self,
        enable_time_limit: bool = None,
        time_type: str = None,
        time_unit: str = None,
        time_value: int = None,
    ):
        # 是否开启限时提交功能：仅且为true时开启
        self.enable_time_limit = enable_time_limit
        # 限制类型：before-提前；after-补交
        self.time_type = time_type
        # 时间单位：day-天；hour-小时
        self.time_unit = time_unit
        # 限制值：timeUnit=day时，有效值范围[0~30] 天；timeUnit=hour时，有效值范围[0~24] 小时
        self.time_value = time_value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.enable_time_limit is not None:
            result['enableTimeLimit'] = self.enable_time_limit
        if self.time_type is not None:
            result['timeType'] = self.time_type
        if self.time_unit is not None:
            result['timeUnit'] = self.time_unit
        if self.time_value is not None:
            result['timeValue'] = self.time_value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('enableTimeLimit') is not None:
            self.enable_time_limit = m.get('enableTimeLimit')
        if m.get('timeType') is not None:
            self.time_type = m.get('timeType')
        if m.get('timeUnit') is not None:
            self.time_unit = m.get('timeUnit')
        if m.get('timeValue') is not None:
            self.time_value = m.get('timeValue')
        return self


class AddLeaveTypeRequestVisibilityRules(TeaModel):
    def __init__(
        self,
        type: str = None,
        visible: List[str] = None,
    ):
        # 规则类型：dept-部门；staff-员工；label-角色
        self.type = type
        # 规则数据：当type=staff时，传员工userId列表；当type=dept时，传部门id列表；当type=label时，传角色id列表
        self.visible = visible

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.visible is not None:
            result['visible'] = self.visible
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('visible') is not None:
            self.visible = m.get('visible')
        return self


class AddLeaveTypeRequest(TeaModel):
    def __init__(
        self,
        biz_type: str = None,
        extras: str = None,
        hours_in_per_day: int = None,
        leave_certificate: AddLeaveTypeRequestLeaveCertificate = None,
        leave_name: str = None,
        leave_view_unit: str = None,
        natural_day_leave: bool = None,
        submit_time_rule: AddLeaveTypeRequestSubmitTimeRule = None,
        visibility_rules: List[AddLeaveTypeRequestVisibilityRules] = None,
        op_user_id: str = None,
    ):
        # 假期类型，普通假期或者加班转调休假期。(general_leave、lieu_leave其中一种)
        self.biz_type = biz_type
        # 调休假有效期规则(validity_type:有效类型 absolute_time(绝对时间)、relative_time(相对时间)其中一种 validity_value:延长日期(当validity_type为absolute_time该值该值不为空且满足yy-mm格式 validity_type为relative_time该值为大于1的整数))
        self.extras = extras
        # 每天折算的工作时长(百分之一 例如1天=10小时=1000)
        self.hours_in_per_day = hours_in_per_day
        # 请假证明
        self.leave_certificate = leave_certificate
        # 假期名称
        self.leave_name = leave_name
        # 请假单位，可以按照天半天或者小时请假。(day、halfDay、hour其中一种)
        self.leave_view_unit = leave_view_unit
        # 是否按照自然日统计请假时长，当为false的时候，用户发起请假时候会根据用户在请假时间段内的排班情况来计算请假时长。
        self.natural_day_leave = natural_day_leave
        # 限时提交规则
        self.submit_time_rule = submit_time_rule
        # 适用范围规则列表：哪些部门/员工可以使用该假期类型，不传默认为全公司
        self.visibility_rules = visibility_rules
        # 操作者ID
        self.op_user_id = op_user_id

    def validate(self):
        if self.leave_certificate:
            self.leave_certificate.validate()
        if self.submit_time_rule:
            self.submit_time_rule.validate()
        if self.visibility_rules:
            for k in self.visibility_rules:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.extras is not None:
            result['extras'] = self.extras
        if self.hours_in_per_day is not None:
            result['hoursInPerDay'] = self.hours_in_per_day
        if self.leave_certificate is not None:
            result['leaveCertificate'] = self.leave_certificate.to_map()
        if self.leave_name is not None:
            result['leaveName'] = self.leave_name
        if self.leave_view_unit is not None:
            result['leaveViewUnit'] = self.leave_view_unit
        if self.natural_day_leave is not None:
            result['naturalDayLeave'] = self.natural_day_leave
        if self.submit_time_rule is not None:
            result['submitTimeRule'] = self.submit_time_rule.to_map()
        result['visibilityRules'] = []
        if self.visibility_rules is not None:
            for k in self.visibility_rules:
                result['visibilityRules'].append(k.to_map() if k else None)
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('extras') is not None:
            self.extras = m.get('extras')
        if m.get('hoursInPerDay') is not None:
            self.hours_in_per_day = m.get('hoursInPerDay')
        if m.get('leaveCertificate') is not None:
            temp_model = AddLeaveTypeRequestLeaveCertificate()
            self.leave_certificate = temp_model.from_map(m['leaveCertificate'])
        if m.get('leaveName') is not None:
            self.leave_name = m.get('leaveName')
        if m.get('leaveViewUnit') is not None:
            self.leave_view_unit = m.get('leaveViewUnit')
        if m.get('naturalDayLeave') is not None:
            self.natural_day_leave = m.get('naturalDayLeave')
        if m.get('submitTimeRule') is not None:
            temp_model = AddLeaveTypeRequestSubmitTimeRule()
            self.submit_time_rule = temp_model.from_map(m['submitTimeRule'])
        self.visibility_rules = []
        if m.get('visibilityRules') is not None:
            for k in m.get('visibilityRules'):
                temp_model = AddLeaveTypeRequestVisibilityRules()
                self.visibility_rules.append(temp_model.from_map(k))
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class AddLeaveTypeResponseBodyResultLeaveCertificate(TeaModel):
    def __init__(
        self,
        duration: float = None,
        enable: bool = None,
        prompt_information: str = None,
        unit: str = None,
    ):
        # 超过多长时间需提供请假证明
        self.duration = duration
        # 是否开启请假证明
        self.enable = enable
        # 请假提示文案
        self.prompt_information = prompt_information
        # 请假证明单位hour，day
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.duration is not None:
            result['duration'] = self.duration
        if self.enable is not None:
            result['enable'] = self.enable
        if self.prompt_information is not None:
            result['promptInformation'] = self.prompt_information
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('enable') is not None:
            self.enable = m.get('enable')
        if m.get('promptInformation') is not None:
            self.prompt_information = m.get('promptInformation')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class AddLeaveTypeResponseBodyResultSubmitTimeRule(TeaModel):
    def __init__(
        self,
        enable_time_limit: bool = None,
        time_type: str = None,
        time_unit: str = None,
        time_value: int = None,
    ):
        # 是否开启限时提交功能：仅且为true时开启
        self.enable_time_limit = enable_time_limit
        # 限制类型：before-提前；after-补交
        self.time_type = time_type
        # 时间单位：day-天；hour-小时
        self.time_unit = time_unit
        # 限制值：timeUnit=day时，有效值范围[0~30] 天；timeUnit=hour时，有效值范围[0~24] 小时
        self.time_value = time_value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.enable_time_limit is not None:
            result['enableTimeLimit'] = self.enable_time_limit
        if self.time_type is not None:
            result['timeType'] = self.time_type
        if self.time_unit is not None:
            result['timeUnit'] = self.time_unit
        if self.time_value is not None:
            result['timeValue'] = self.time_value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('enableTimeLimit') is not None:
            self.enable_time_limit = m.get('enableTimeLimit')
        if m.get('timeType') is not None:
            self.time_type = m.get('timeType')
        if m.get('timeUnit') is not None:
            self.time_unit = m.get('timeUnit')
        if m.get('timeValue') is not None:
            self.time_value = m.get('timeValue')
        return self


class AddLeaveTypeResponseBodyResultVisibilityRules(TeaModel):
    def __init__(
        self,
        type: str = None,
        visible: List[str] = None,
    ):
        # 规则类型：dept-部门；staff-员工；label-角色
        self.type = type
        # 规则数据：当type=staff时，传员工userId列表；当type=dept时，传部门id列表；当type=label时，传角色id列表
        self.visible = visible

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.visible is not None:
            result['visible'] = self.visible
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('visible') is not None:
            self.visible = m.get('visible')
        return self


class AddLeaveTypeResponseBodyResult(TeaModel):
    def __init__(
        self,
        biz_type: str = None,
        hours_in_per_day: int = None,
        leave_certificate: AddLeaveTypeResponseBodyResultLeaveCertificate = None,
        leave_code: str = None,
        leave_name: str = None,
        leave_view_unit: str = None,
        natural_day_leave: bool = None,
        submit_time_rule: AddLeaveTypeResponseBodyResultSubmitTimeRule = None,
        visibility_rules: List[AddLeaveTypeResponseBodyResultVisibilityRules] = None,
    ):
        # 假期类型，普通假期或者加班转调休假期。(general_leave、lieu_leave其中一种)
        self.biz_type = biz_type
        # 每天折算的工作时长(百分之一 例如1天=10小时=1000)
        self.hours_in_per_day = hours_in_per_day
        # 请假证明
        self.leave_certificate = leave_certificate
        # 假期类型唯一标识
        self.leave_code = leave_code
        # 假期名称
        self.leave_name = leave_name
        # 请假单位，可以按照天半天或者小时请假。(day、halfDay、hour其中一种)
        self.leave_view_unit = leave_view_unit
        # 是否按照自然日统计请假时长，当为false的时候，用户发起请假时候会根据用户在请假时间段内的排班情况来计算请假时长。
        self.natural_day_leave = natural_day_leave
        # 限时提交规则
        self.submit_time_rule = submit_time_rule
        # 适用范围规则列表：哪些部门/员工可以使用该假期类型，不传默认为全公司
        self.visibility_rules = visibility_rules

    def validate(self):
        if self.leave_certificate:
            self.leave_certificate.validate()
        if self.submit_time_rule:
            self.submit_time_rule.validate()
        if self.visibility_rules:
            for k in self.visibility_rules:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.hours_in_per_day is not None:
            result['hoursInPerDay'] = self.hours_in_per_day
        if self.leave_certificate is not None:
            result['leaveCertificate'] = self.leave_certificate.to_map()
        if self.leave_code is not None:
            result['leaveCode'] = self.leave_code
        if self.leave_name is not None:
            result['leaveName'] = self.leave_name
        if self.leave_view_unit is not None:
            result['leaveViewUnit'] = self.leave_view_unit
        if self.natural_day_leave is not None:
            result['naturalDayLeave'] = self.natural_day_leave
        if self.submit_time_rule is not None:
            result['submitTimeRule'] = self.submit_time_rule.to_map()
        result['visibilityRules'] = []
        if self.visibility_rules is not None:
            for k in self.visibility_rules:
                result['visibilityRules'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('hoursInPerDay') is not None:
            self.hours_in_per_day = m.get('hoursInPerDay')
        if m.get('leaveCertificate') is not None:
            temp_model = AddLeaveTypeResponseBodyResultLeaveCertificate()
            self.leave_certificate = temp_model.from_map(m['leaveCertificate'])
        if m.get('leaveCode') is not None:
            self.leave_code = m.get('leaveCode')
        if m.get('leaveName') is not None:
            self.leave_name = m.get('leaveName')
        if m.get('leaveViewUnit') is not None:
            self.leave_view_unit = m.get('leaveViewUnit')
        if m.get('naturalDayLeave') is not None:
            self.natural_day_leave = m.get('naturalDayLeave')
        if m.get('submitTimeRule') is not None:
            temp_model = AddLeaveTypeResponseBodyResultSubmitTimeRule()
            self.submit_time_rule = temp_model.from_map(m['submitTimeRule'])
        self.visibility_rules = []
        if m.get('visibilityRules') is not None:
            for k in m.get('visibilityRules'):
                temp_model = AddLeaveTypeResponseBodyResultVisibilityRules()
                self.visibility_rules.append(temp_model.from_map(k))
        return self


class AddLeaveTypeResponseBody(TeaModel):
    def __init__(
        self,
        result: AddLeaveTypeResponseBodyResult = None,
    ):
        # 返回参数
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
            temp_model = AddLeaveTypeResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class AddLeaveTypeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: AddLeaveTypeResponseBody = None,
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
            temp_model = AddLeaveTypeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AttendanceBleDevicesAddHeaders(TeaModel):
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


class AttendanceBleDevicesAddRequest(TeaModel):
    def __init__(
        self,
        device_id_list: List[int] = None,
        group_key: str = None,
        op_user_id: str = None,
    ):
        # 蓝牙设备Id列表
        self.device_id_list = device_id_list
        # 考勤组Id
        self.group_key = group_key
        # 操作人Id
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_id_list is not None:
            result['deviceIdList'] = self.device_id_list
        if self.group_key is not None:
            result['groupKey'] = self.group_key
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceIdList') is not None:
            self.device_id_list = m.get('deviceIdList')
        if m.get('groupKey') is not None:
            self.group_key = m.get('groupKey')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class AttendanceBleDevicesAddResponseBodyErrorListFailureList(TeaModel):
    def __init__(
        self,
        device_id: int = None,
        device_name: str = None,
        sn: str = None,
    ):
        # 蓝牙设备Id
        self.device_id = device_id
        # 蓝牙设备名称
        self.device_name = device_name
        # sn
        self.sn = sn

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_id is not None:
            result['deviceId'] = self.device_id
        if self.device_name is not None:
            result['deviceName'] = self.device_name
        if self.sn is not None:
            result['sn'] = self.sn
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceId') is not None:
            self.device_id = m.get('deviceId')
        if m.get('deviceName') is not None:
            self.device_name = m.get('deviceName')
        if m.get('sn') is not None:
            self.sn = m.get('sn')
        return self


class AttendanceBleDevicesAddResponseBodyErrorList(TeaModel):
    def __init__(
        self,
        code: str = None,
        failure_list: List[AttendanceBleDevicesAddResponseBodyErrorListFailureList] = None,
        msg: str = None,
    ):
        # 错误code
        self.code = code
        # 失败蓝牙设备列表
        self.failure_list = failure_list
        # errorMsg
        self.msg = msg

    def validate(self):
        if self.failure_list:
            for k in self.failure_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        result['failureList'] = []
        if self.failure_list is not None:
            for k in self.failure_list:
                result['failureList'].append(k.to_map() if k else None)
        if self.msg is not None:
            result['msg'] = self.msg
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        self.failure_list = []
        if m.get('failureList') is not None:
            for k in m.get('failureList'):
                temp_model = AttendanceBleDevicesAddResponseBodyErrorListFailureList()
                self.failure_list.append(temp_model.from_map(k))
        if m.get('msg') is not None:
            self.msg = m.get('msg')
        return self


class AttendanceBleDevicesAddResponseBodySuccessList(TeaModel):
    def __init__(
        self,
        device_id: int = None,
        device_name: str = None,
        sn: str = None,
    ):
        # 蓝牙设备Id
        self.device_id = device_id
        # 蓝牙设备名称
        self.device_name = device_name
        # sn
        self.sn = sn

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_id is not None:
            result['deviceId'] = self.device_id
        if self.device_name is not None:
            result['deviceName'] = self.device_name
        if self.sn is not None:
            result['sn'] = self.sn
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceId') is not None:
            self.device_id = m.get('deviceId')
        if m.get('deviceName') is not None:
            self.device_name = m.get('deviceName')
        if m.get('sn') is not None:
            self.sn = m.get('sn')
        return self


class AttendanceBleDevicesAddResponseBody(TeaModel):
    def __init__(
        self,
        error_list: List[AttendanceBleDevicesAddResponseBodyErrorList] = None,
        success_list: List[AttendanceBleDevicesAddResponseBodySuccessList] = None,
    ):
        # 添加错误列表
        self.error_list = error_list
        # 添加成功蓝牙设备列表
        self.success_list = success_list

    def validate(self):
        if self.error_list:
            for k in self.error_list:
                if k:
                    k.validate()
        if self.success_list:
            for k in self.success_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['errorList'] = []
        if self.error_list is not None:
            for k in self.error_list:
                result['errorList'].append(k.to_map() if k else None)
        result['successList'] = []
        if self.success_list is not None:
            for k in self.success_list:
                result['successList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.error_list = []
        if m.get('errorList') is not None:
            for k in m.get('errorList'):
                temp_model = AttendanceBleDevicesAddResponseBodyErrorList()
                self.error_list.append(temp_model.from_map(k))
        self.success_list = []
        if m.get('successList') is not None:
            for k in m.get('successList'):
                temp_model = AttendanceBleDevicesAddResponseBodySuccessList()
                self.success_list.append(temp_model.from_map(k))
        return self


class AttendanceBleDevicesAddResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: AttendanceBleDevicesAddResponseBody = None,
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
            temp_model = AttendanceBleDevicesAddResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AttendanceBleDevicesQueryHeaders(TeaModel):
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


class AttendanceBleDevicesQueryRequest(TeaModel):
    def __init__(
        self,
        group_key: str = None,
        op_user_id: str = None,
    ):
        # 考勤组Id
        self.group_key = group_key
        # 操作人Id
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_key is not None:
            result['groupKey'] = self.group_key
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupKey') is not None:
            self.group_key = m.get('groupKey')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class AttendanceBleDevicesQueryResponseBodyResult(TeaModel):
    def __init__(
        self,
        device_id: int = None,
        device_name: str = None,
        sn: str = None,
    ):
        # 蓝牙设备Id
        self.device_id = device_id
        # 蓝牙设备名称
        self.device_name = device_name
        # sn
        self.sn = sn

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_id is not None:
            result['deviceId'] = self.device_id
        if self.device_name is not None:
            result['deviceName'] = self.device_name
        if self.sn is not None:
            result['sn'] = self.sn
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceId') is not None:
            self.device_id = m.get('deviceId')
        if m.get('deviceName') is not None:
            self.device_name = m.get('deviceName')
        if m.get('sn') is not None:
            self.sn = m.get('sn')
        return self


class AttendanceBleDevicesQueryResponseBody(TeaModel):
    def __init__(
        self,
        result: List[AttendanceBleDevicesQueryResponseBodyResult] = None,
    ):
        # 蓝牙列表
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
                temp_model = AttendanceBleDevicesQueryResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class AttendanceBleDevicesQueryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: AttendanceBleDevicesQueryResponseBody = None,
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
            temp_model = AttendanceBleDevicesQueryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AttendanceBleDevicesRemoveHeaders(TeaModel):
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


class AttendanceBleDevicesRemoveRequest(TeaModel):
    def __init__(
        self,
        device_id_list: List[int] = None,
        group_key: str = None,
        op_user_id: str = None,
    ):
        # 蓝牙设备Id列表
        self.device_id_list = device_id_list
        # 考勤组Id
        self.group_key = group_key
        # 操作人id
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_id_list is not None:
            result['deviceIdList'] = self.device_id_list
        if self.group_key is not None:
            result['groupKey'] = self.group_key
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceIdList') is not None:
            self.device_id_list = m.get('deviceIdList')
        if m.get('groupKey') is not None:
            self.group_key = m.get('groupKey')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class AttendanceBleDevicesRemoveResponseBodyErrorList(TeaModel):
    def __init__(
        self,
        code: str = None,
        failure_list: List[int] = None,
        msg: str = None,
    ):
        # 错误code
        self.code = code
        # 移除失败蓝牙设备Id列表
        self.failure_list = failure_list
        # 错误信息
        self.msg = msg

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.failure_list is not None:
            result['failureList'] = self.failure_list
        if self.msg is not None:
            result['msg'] = self.msg
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('failureList') is not None:
            self.failure_list = m.get('failureList')
        if m.get('msg') is not None:
            self.msg = m.get('msg')
        return self


class AttendanceBleDevicesRemoveResponseBody(TeaModel):
    def __init__(
        self,
        error_list: List[AttendanceBleDevicesRemoveResponseBodyErrorList] = None,
        success_list: List[int] = None,
    ):
        # 移出错误列表
        self.error_list = error_list
        # 移除成功蓝牙设备Id列表
        self.success_list = success_list

    def validate(self):
        if self.error_list:
            for k in self.error_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['errorList'] = []
        if self.error_list is not None:
            for k in self.error_list:
                result['errorList'].append(k.to_map() if k else None)
        if self.success_list is not None:
            result['successList'] = self.success_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.error_list = []
        if m.get('errorList') is not None:
            for k in m.get('errorList'):
                temp_model = AttendanceBleDevicesRemoveResponseBodyErrorList()
                self.error_list.append(temp_model.from_map(k))
        if m.get('successList') is not None:
            self.success_list = m.get('successList')
        return self


class AttendanceBleDevicesRemoveResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: AttendanceBleDevicesRemoveResponseBody = None,
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
            temp_model = AttendanceBleDevicesRemoveResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CheckClosingAccountHeaders(TeaModel):
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


class CheckClosingAccountRequestUserTimeRange(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        start_time: int = None,
    ):
        self.end_time = end_time
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
        if self.start_time is not None:
            result['startTime'] = self.start_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        return self


class CheckClosingAccountRequest(TeaModel):
    def __init__(
        self,
        biz_code: str = None,
        user_ids: List[str] = None,
        user_time_range: List[CheckClosingAccountRequestUserTimeRange] = None,
    ):
        # 情景
        self.biz_code = biz_code
        # 员工列表
        self.user_ids = user_ids
        # 时间段
        self.user_time_range = user_time_range

    def validate(self):
        if self.user_time_range:
            for k in self.user_time_range:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_code is not None:
            result['bizCode'] = self.biz_code
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        result['userTimeRange'] = []
        if self.user_time_range is not None:
            for k in self.user_time_range:
                result['userTimeRange'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizCode') is not None:
            self.biz_code = m.get('bizCode')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        self.user_time_range = []
        if m.get('userTimeRange') is not None:
            for k in m.get('userTimeRange'):
                temp_model = CheckClosingAccountRequestUserTimeRange()
                self.user_time_range.append(temp_model.from_map(k))
        return self


class CheckClosingAccountResponseBody(TeaModel):
    def __init__(
        self,
        code: str = None,
        mesage: str = None,
        pass_: bool = None,
    ):
        self.code = code
        self.mesage = mesage
        self.pass_ = pass_

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.mesage is not None:
            result['mesage'] = self.mesage
        if self.pass_ is not None:
            result['pass'] = self.pass_
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('mesage') is not None:
            self.mesage = m.get('mesage')
        if m.get('pass') is not None:
            self.pass_ = m.get('pass')
        return self


class CheckClosingAccountResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CheckClosingAccountResponseBody = None,
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
            temp_model = CheckClosingAccountResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CheckWritePermissionHeaders(TeaModel):
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


class CheckWritePermissionRequest(TeaModel):
    def __init__(
        self,
        category: str = None,
        entity_ids: List[int] = None,
        op_user_id: str = None,
        resource_key: str = None,
    ):
        # category
        self.category = category
        # entityIds
        self.entity_ids = entity_ids
        # opUserId
        self.op_user_id = op_user_id
        # resourceKey
        self.resource_key = resource_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.category is not None:
            result['category'] = self.category
        if self.entity_ids is not None:
            result['entityIds'] = self.entity_ids
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.resource_key is not None:
            result['resourceKey'] = self.resource_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('category') is not None:
            self.category = m.get('category')
        if m.get('entityIds') is not None:
            self.entity_ids = m.get('entityIds')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('resourceKey') is not None:
            self.resource_key = m.get('resourceKey')
        return self


class CheckWritePermissionResponseBody(TeaModel):
    def __init__(
        self,
        entity_permission_map: Dict[str, bool] = None,
    ):
        # entityPermissionMap
        self.entity_permission_map = entity_permission_map

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.entity_permission_map is not None:
            result['entityPermissionMap'] = self.entity_permission_map
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('entityPermissionMap') is not None:
            self.entity_permission_map = m.get('entityPermissionMap')
        return self


class CheckWritePermissionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CheckWritePermissionResponseBody = None,
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
            temp_model = CheckWritePermissionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


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


class CreateApproveRequestPunchParam(TeaModel):
    def __init__(
        self,
        position_id: str = None,
        position_name: str = None,
        position_type: str = None,
        punch_time: int = None,
    ):
        # 地理位置标识：wifi:ssid_macAddress ble: deviceId gps:longitude_latitude
        self.position_id = position_id
        # 地理位置名称
        self.position_name = position_name
        # 地理位置类型：wifi/ble/gps
        self.position_type = position_type
        # 打卡时间，单位毫秒
        self.punch_time = punch_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.position_id is not None:
            result['positionId'] = self.position_id
        if self.position_name is not None:
            result['positionName'] = self.position_name
        if self.position_type is not None:
            result['positionType'] = self.position_type
        if self.punch_time is not None:
            result['punchTime'] = self.punch_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('positionId') is not None:
            self.position_id = m.get('positionId')
        if m.get('positionName') is not None:
            self.position_name = m.get('positionName')
        if m.get('positionType') is not None:
            self.position_type = m.get('positionType')
        if m.get('punchTime') is not None:
            self.punch_time = m.get('punchTime')
        return self


class CreateApproveRequest(TeaModel):
    def __init__(
        self,
        approve_id: str = None,
        op_userid: str = None,
        punch_param: CreateApproveRequestPunchParam = None,
        sub_type: str = None,
        tag_name: str = None,
        userid: str = None,
    ):
        # 三方审批单id，全局唯一
        self.approve_id = approve_id
        # 审批人员工id
        self.op_userid = op_userid
        # 审批单关联的打卡信息
        self.punch_param = punch_param
        # 子类型名称，最大长度20个字符
        self.sub_type = sub_type
        # 审批单类型名称，最大长度20个字符
        self.tag_name = tag_name
        # 员工id
        self.userid = userid

    def validate(self):
        if self.punch_param:
            self.punch_param.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.approve_id is not None:
            result['approveId'] = self.approve_id
        if self.op_userid is not None:
            result['opUserid'] = self.op_userid
        if self.punch_param is not None:
            result['punchParam'] = self.punch_param.to_map()
        if self.sub_type is not None:
            result['subType'] = self.sub_type
        if self.tag_name is not None:
            result['tagName'] = self.tag_name
        if self.userid is not None:
            result['userid'] = self.userid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('approveId') is not None:
            self.approve_id = m.get('approveId')
        if m.get('opUserid') is not None:
            self.op_userid = m.get('opUserid')
        if m.get('punchParam') is not None:
            temp_model = CreateApproveRequestPunchParam()
            self.punch_param = temp_model.from_map(m['punchParam'])
        if m.get('subType') is not None:
            self.sub_type = m.get('subType')
        if m.get('tagName') is not None:
            self.tag_name = m.get('tagName')
        if m.get('userid') is not None:
            self.userid = m.get('userid')
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
        _map = super().to_map()
        if _map is not None:
            return _map

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
            temp_model = CreateApproveResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteWaterMarkTemplateHeaders(TeaModel):
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


class DeleteWaterMarkTemplateRequest(TeaModel):
    def __init__(
        self,
        form_code: str = None,
        form_content: str = None,
        open_conversation_id: str = None,
        system_template: bool = None,
        user_id: str = None,
    ):
        # 模板的表单Code。
        self.form_code = form_code
        # 模板的内容。
        self.form_content = form_content
        # 群会话ID。
        self.open_conversation_id = open_conversation_id
        # 是否是系统模板。
        # - true：是
        # - false：否
        # 
        # 
        self.system_template = system_template
        # 用户的userid。
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.form_code is not None:
            result['formCode'] = self.form_code
        if self.form_content is not None:
            result['formContent'] = self.form_content
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.system_template is not None:
            result['systemTemplate'] = self.system_template
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('formCode') is not None:
            self.form_code = m.get('formCode')
        if m.get('formContent') is not None:
            self.form_content = m.get('formContent')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('systemTemplate') is not None:
            self.system_template = m.get('systemTemplate')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class DeleteWaterMarkTemplateResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
    ):
        # 模板的表单Code。
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


class DeleteWaterMarkTemplateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DeleteWaterMarkTemplateResponseBody = None,
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
            temp_model = DeleteWaterMarkTemplateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DingTalkSecurityCheckHeaders(TeaModel):
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


class DingTalkSecurityCheckRequest(TeaModel):
    def __init__(
        self,
        client_ver: str = None,
        platform: str = None,
        platform_ver: str = None,
        sec: str = None,
        user_id: str = None,
    ):
        # 客户端版本号
        self.client_ver = client_ver
        # 客户端平台类型(iOS,Android)
        self.platform = platform
        # 客户端平台平台版本
        self.platform_ver = platform_ver
        # 加密字符
        self.sec = sec
        # 用户id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.client_ver is not None:
            result['clientVer'] = self.client_ver
        if self.platform is not None:
            result['platform'] = self.platform
        if self.platform_ver is not None:
            result['platformVer'] = self.platform_ver
        if self.sec is not None:
            result['sec'] = self.sec
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('clientVer') is not None:
            self.client_ver = m.get('clientVer')
        if m.get('platform') is not None:
            self.platform = m.get('platform')
        if m.get('platformVer') is not None:
            self.platform_ver = m.get('platformVer')
        if m.get('sec') is not None:
            self.sec = m.get('sec')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class DingTalkSecurityCheckResponseBodyResult(TeaModel):
    def __init__(
        self,
        has_risk: bool = None,
        risk_info: Dict[str, str] = None,
    ):
        # 是否有风险
        self.has_risk = has_risk
        # 风险信息
        self.risk_info = risk_info

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_risk is not None:
            result['hasRisk'] = self.has_risk
        if self.risk_info is not None:
            result['riskInfo'] = self.risk_info
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasRisk') is not None:
            self.has_risk = m.get('hasRisk')
        if m.get('riskInfo') is not None:
            self.risk_info = m.get('riskInfo')
        return self


class DingTalkSecurityCheckResponseBody(TeaModel):
    def __init__(
        self,
        result: DingTalkSecurityCheckResponseBodyResult = None,
    ):
        # 返回参数
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
            temp_model = DingTalkSecurityCheckResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class DingTalkSecurityCheckResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DingTalkSecurityCheckResponseBody = None,
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
            temp_model = DingTalkSecurityCheckResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetATManageScopeHeaders(TeaModel):
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


class GetATManageScopeRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        user_id: str = None,
    ):
        # 单次查询条数，最大200。
        self.max_results = max_results
        # 分页游标。
        self.next_token = next_token
        # 查询用户userId。
        self.user_id = user_id

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
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetATManageScopeResponseBodyResult(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        manage_scope: str = None,
        user_ids: List[str] = None,
    ):
        # 是否有更多数据。  true：有  false：没有
        self.has_more = has_more
        # 可见范围。boss/主管理员/管理范围包含根部门的管理员：all ，管理员/考勤组负责人：partial，无权限：none
        self.manage_scope = manage_scope
        # 员工userid。只有manageScope为partial返回数据。
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.manage_scope is not None:
            result['manageScope'] = self.manage_scope
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('manageScope') is not None:
            self.manage_scope = m.get('manageScope')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class GetATManageScopeResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetATManageScopeResponseBodyResult] = None,
    ):
        # 管理范围。
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
                temp_model = GetATManageScopeResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GetATManageScopeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetATManageScopeResponseBody = None,
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
            temp_model = GetATManageScopeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetAdjustmentsHeaders(TeaModel):
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


class GetAdjustmentsRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
    ):
        self.page_number = page_number
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class GetAdjustmentsResponseBodyResultItems(TeaModel):
    def __init__(
        self,
        id: int = None,
        name: str = None,
        setting_id: int = None,
    ):
        # 补卡规则id
        self.id = id
        # 补卡规则名称
        self.name = name
        self.setting_id = setting_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.setting_id is not None:
            result['settingId'] = self.setting_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('settingId') is not None:
            self.setting_id = m.get('settingId')
        return self


class GetAdjustmentsResponseBodyResult(TeaModel):
    def __init__(
        self,
        items: List[GetAdjustmentsResponseBodyResultItems] = None,
        page_number: int = None,
        total_page: int = None,
    ):
        # 补卡规则集合
        self.items = items
        # 当前页码
        self.page_number = page_number
        # 总页数
        self.total_page = total_page

    def validate(self):
        if self.items:
            for k in self.items:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.total_page is not None:
            result['totalPage'] = self.total_page
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.items = []
        if m.get('items') is not None:
            for k in m.get('items'):
                temp_model = GetAdjustmentsResponseBodyResultItems()
                self.items.append(temp_model.from_map(k))
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('totalPage') is not None:
            self.total_page = m.get('totalPage')
        return self


class GetAdjustmentsResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetAdjustmentsResponseBodyResult] = None,
    ):
        # Id of the request
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
                temp_model = GetAdjustmentsResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GetAdjustmentsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetAdjustmentsResponseBody = None,
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
            temp_model = GetAdjustmentsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetCheckInSchemaTemplateHeaders(TeaModel):
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


class GetCheckInSchemaTemplateRequest(TeaModel):
    def __init__(
        self,
        biz_code: str = None,
        open_conversation_id: str = None,
        scene_code: str = None,
        user_id: str = None,
    ):
        # 业务码：
        # - water_mark_checkin 水印签到
        # 
        # 
        self.biz_code = biz_code
        # 群会话ID。
        self.open_conversation_id = open_conversation_id
        # 场景码：
        # - water_mark_checkin_h3yun 开放场景码
        # 
        # 
        self.scene_code = scene_code
        # 用户的userid。
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_code is not None:
            result['bizCode'] = self.biz_code
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.scene_code is not None:
            result['sceneCode'] = self.scene_code
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizCode') is not None:
            self.biz_code = m.get('bizCode')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('sceneCode') is not None:
            self.scene_code = m.get('sceneCode')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetCheckInSchemaTemplateResponseBodyResultWaterMarkTemplateModels(TeaModel):
    def __init__(
        self,
        can_modify: bool = None,
        form_code: str = None,
        icon: str = None,
        layout_design: str = None,
        scene_code: str = None,
        schema_content: str = None,
        suite_key: str = None,
        system_template: bool = None,
        title: str = None,
        water_mark_id: str = None,
    ):
        # 是否可以修改。
        self.can_modify = can_modify
        # 模板的表单Code。
        self.form_code = form_code
        # 模板的预览图片。
        self.icon = icon
        # 模板的布局信息。
        self.layout_design = layout_design
        # 模板的场景码。
        self.scene_code = scene_code
        # 模板的内容。
        self.schema_content = schema_content
        # suiteKey。
        self.suite_key = suite_key
        # 是否系统模板。
        self.system_template = system_template
        # 模板的标题。
        self.title = title
        # 模板的水印ID。
        self.water_mark_id = water_mark_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.can_modify is not None:
            result['canModify'] = self.can_modify
        if self.form_code is not None:
            result['formCode'] = self.form_code
        if self.icon is not None:
            result['icon'] = self.icon
        if self.layout_design is not None:
            result['layoutDesign'] = self.layout_design
        if self.scene_code is not None:
            result['sceneCode'] = self.scene_code
        if self.schema_content is not None:
            result['schemaContent'] = self.schema_content
        if self.suite_key is not None:
            result['suiteKey'] = self.suite_key
        if self.system_template is not None:
            result['systemTemplate'] = self.system_template
        if self.title is not None:
            result['title'] = self.title
        if self.water_mark_id is not None:
            result['waterMarkId'] = self.water_mark_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('canModify') is not None:
            self.can_modify = m.get('canModify')
        if m.get('formCode') is not None:
            self.form_code = m.get('formCode')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('layoutDesign') is not None:
            self.layout_design = m.get('layoutDesign')
        if m.get('sceneCode') is not None:
            self.scene_code = m.get('sceneCode')
        if m.get('schemaContent') is not None:
            self.schema_content = m.get('schemaContent')
        if m.get('suiteKey') is not None:
            self.suite_key = m.get('suiteKey')
        if m.get('systemTemplate') is not None:
            self.system_template = m.get('systemTemplate')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('waterMarkId') is not None:
            self.water_mark_id = m.get('waterMarkId')
        return self


class GetCheckInSchemaTemplateResponseBodyResult(TeaModel):
    def __init__(
        self,
        biz_code: str = None,
        can_modify_and_add_template: bool = None,
        conversation_admin: bool = None,
        custom_template_max_size: int = None,
        open_conversation_id: str = None,
        show_stat: bool = None,
        template_degrade: bool = None,
        water_mark_template_models: List[GetCheckInSchemaTemplateResponseBodyResultWaterMarkTemplateModels] = None,
    ):
        # 业务码。
        self.biz_code = biz_code
        # 是否可以操作模板。
        self.can_modify_and_add_template = can_modify_and_add_template
        # 是否群管理员。
        self.conversation_admin = conversation_admin
        # 自定义模板的最大数量。
        self.custom_template_max_size = custom_template_max_size
        # 群会话ID。
        self.open_conversation_id = open_conversation_id
        # 是否展示统计入口。
        self.show_stat = show_stat
        # 是否开启水印模板降级。
        self.template_degrade = template_degrade
        # 模板列表。
        self.water_mark_template_models = water_mark_template_models

    def validate(self):
        if self.water_mark_template_models:
            for k in self.water_mark_template_models:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_code is not None:
            result['bizCode'] = self.biz_code
        if self.can_modify_and_add_template is not None:
            result['canModifyAndAddTemplate'] = self.can_modify_and_add_template
        if self.conversation_admin is not None:
            result['conversationAdmin'] = self.conversation_admin
        if self.custom_template_max_size is not None:
            result['customTemplateMaxSize'] = self.custom_template_max_size
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.show_stat is not None:
            result['showStat'] = self.show_stat
        if self.template_degrade is not None:
            result['templateDegrade'] = self.template_degrade
        result['waterMarkTemplateModels'] = []
        if self.water_mark_template_models is not None:
            for k in self.water_mark_template_models:
                result['waterMarkTemplateModels'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizCode') is not None:
            self.biz_code = m.get('bizCode')
        if m.get('canModifyAndAddTemplate') is not None:
            self.can_modify_and_add_template = m.get('canModifyAndAddTemplate')
        if m.get('conversationAdmin') is not None:
            self.conversation_admin = m.get('conversationAdmin')
        if m.get('customTemplateMaxSize') is not None:
            self.custom_template_max_size = m.get('customTemplateMaxSize')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('showStat') is not None:
            self.show_stat = m.get('showStat')
        if m.get('templateDegrade') is not None:
            self.template_degrade = m.get('templateDegrade')
        self.water_mark_template_models = []
        if m.get('waterMarkTemplateModels') is not None:
            for k in m.get('waterMarkTemplateModels'):
                temp_model = GetCheckInSchemaTemplateResponseBodyResultWaterMarkTemplateModels()
                self.water_mark_template_models.append(temp_model.from_map(k))
        return self


class GetCheckInSchemaTemplateResponseBody(TeaModel):
    def __init__(
        self,
        result: GetCheckInSchemaTemplateResponseBodyResult = None,
    ):
        # 返回对象。
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
            temp_model = GetCheckInSchemaTemplateResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetCheckInSchemaTemplateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetCheckInSchemaTemplateResponseBody = None,
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
            temp_model = GetCheckInSchemaTemplateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetClosingAccountsHeaders(TeaModel):
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


class GetClosingAccountsRequest(TeaModel):
    def __init__(
        self,
        user_ids: List[str] = None,
    ):
        # 人员列表
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


class GetClosingAccountsResponseBodyResultClosingAccountModel(TeaModel):
    def __init__(
        self,
        closing_day: int = None,
        closing_hour_minutes: int = None,
        end_day: int = None,
        end_month: int = None,
        start_day: int = None,
        start_month: int = None,
    ):
        # 封账时间-日
        self.closing_day = closing_day
        # 封账时间-时分
        self.closing_hour_minutes = closing_hour_minutes
        # 封账范围-结束日
        self.end_day = end_day
        # 封账范围-结束月
        self.end_month = end_month
        # 封账范围-开始日
        self.start_day = start_day
        # 封账范围-开始月
        self.start_month = start_month

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.closing_day is not None:
            result['closingDay'] = self.closing_day
        if self.closing_hour_minutes is not None:
            result['closingHourMinutes'] = self.closing_hour_minutes
        if self.end_day is not None:
            result['endDay'] = self.end_day
        if self.end_month is not None:
            result['endMonth'] = self.end_month
        if self.start_day is not None:
            result['startDay'] = self.start_day
        if self.start_month is not None:
            result['startMonth'] = self.start_month
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('closingDay') is not None:
            self.closing_day = m.get('closingDay')
        if m.get('closingHourMinutes') is not None:
            self.closing_hour_minutes = m.get('closingHourMinutes')
        if m.get('endDay') is not None:
            self.end_day = m.get('endDay')
        if m.get('endMonth') is not None:
            self.end_month = m.get('endMonth')
        if m.get('startDay') is not None:
            self.start_day = m.get('startDay')
        if m.get('startMonth') is not None:
            self.start_month = m.get('startMonth')
        return self


class GetClosingAccountsResponseBodyResultUnsealClosingAccountModel(TeaModel):
    def __init__(
        self,
        invalid_time_stamp: int = None,
    ):
        # 解封时间点
        self.invalid_time_stamp = invalid_time_stamp

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.invalid_time_stamp is not None:
            result['invalidTimeStamp'] = self.invalid_time_stamp
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('invalidTimeStamp') is not None:
            self.invalid_time_stamp = m.get('invalidTimeStamp')
        return self


class GetClosingAccountsResponseBodyResult(TeaModel):
    def __init__(
        self,
        closing_account_model: GetClosingAccountsResponseBodyResultClosingAccountModel = None,
        switch_on: bool = None,
        unseal_closing_account_model: GetClosingAccountsResponseBodyResultUnsealClosingAccountModel = None,
        user_id: str = None,
    ):
        # 封账规则
        self.closing_account_model = closing_account_model
        # 开关
        self.switch_on = switch_on
        # 解封规则
        self.unseal_closing_account_model = unseal_closing_account_model
        # 人员ID
        self.user_id = user_id

    def validate(self):
        if self.closing_account_model:
            self.closing_account_model.validate()
        if self.unseal_closing_account_model:
            self.unseal_closing_account_model.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.closing_account_model is not None:
            result['closingAccountModel'] = self.closing_account_model.to_map()
        if self.switch_on is not None:
            result['switchOn'] = self.switch_on
        if self.unseal_closing_account_model is not None:
            result['unsealClosingAccountModel'] = self.unseal_closing_account_model.to_map()
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('closingAccountModel') is not None:
            temp_model = GetClosingAccountsResponseBodyResultClosingAccountModel()
            self.closing_account_model = temp_model.from_map(m['closingAccountModel'])
        if m.get('switchOn') is not None:
            self.switch_on = m.get('switchOn')
        if m.get('unsealClosingAccountModel') is not None:
            temp_model = GetClosingAccountsResponseBodyResultUnsealClosingAccountModel()
            self.unseal_closing_account_model = temp_model.from_map(m['unsealClosingAccountModel'])
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetClosingAccountsResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetClosingAccountsResponseBodyResult] = None,
    ):
        # 规则列表
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
                temp_model = GetClosingAccountsResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GetClosingAccountsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetClosingAccountsResponseBody = None,
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
            temp_model = GetClosingAccountsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetLeaveRecordsHeaders(TeaModel):
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


class GetLeaveRecordsRequest(TeaModel):
    def __init__(
        self,
        leave_code: str = None,
        op_user_id: str = None,
        page_number: int = None,
        page_size: int = None,
        user_ids: List[str] = None,
    ):
        # 假期类型唯一标识。
        self.leave_code = leave_code
        # 操作人userId。
        self.op_user_id = op_user_id
        # 分页页码。
        self.page_number = page_number
        # 分页大小。
        self.page_size = page_size
        # 查询员工userId列表。一次最多支持50个。
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.leave_code is not None:
            result['leaveCode'] = self.leave_code
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('leaveCode') is not None:
            self.leave_code = m.get('leaveCode')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class GetLeaveRecordsResponseBodyResultLeaveRecords(TeaModel):
    def __init__(
        self,
        cal_type: str = None,
        end_time: int = None,
        gmt_create: int = None,
        gmt_modified: int = None,
        leave_code: str = None,
        leave_reason: str = None,
        leave_record_type: str = None,
        leave_status: str = None,
        leave_view_unit: str = None,
        quota_id: str = None,
        record_id: str = None,
        record_num_per_day: int = None,
        record_num_per_hour: int = None,
        start_time: int = None,
        user_id: str = None,
    ):
        # 计算类型。
        self.cal_type = cal_type
        # 额度有效期结束时间或请假结束时间，毫秒级时间戳。
        self.end_time = end_time
        # 记录创建时间。
        self.gmt_create = gmt_create
        # 记录修改时间。
        self.gmt_modified = gmt_modified
        # 假期类型唯一标识。
        self.leave_code = leave_code
        # 原因。
        self.leave_reason = leave_reason
        # 假期记录类型。
        self.leave_record_type = leave_record_type
        # 请假状态。
        self.leave_status = leave_status
        # 显示单位。
        self.leave_view_unit = leave_view_unit
        # 额度唯一标识。
        self.quota_id = quota_id
        # 假期记录唯一标识。
        self.record_id = record_id
        # 以天计算的消费额度。
        self.record_num_per_day = record_num_per_day
        # 以小时计算的消费额度。
        self.record_num_per_hour = record_num_per_hour
        # 额度有效期开始时间或请假开始时间，毫秒级时间戳。
        self.start_time = start_time
        # 员工userId。
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cal_type is not None:
            result['calType'] = self.cal_type
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.leave_code is not None:
            result['leaveCode'] = self.leave_code
        if self.leave_reason is not None:
            result['leaveReason'] = self.leave_reason
        if self.leave_record_type is not None:
            result['leaveRecordType'] = self.leave_record_type
        if self.leave_status is not None:
            result['leaveStatus'] = self.leave_status
        if self.leave_view_unit is not None:
            result['leaveViewUnit'] = self.leave_view_unit
        if self.quota_id is not None:
            result['quotaId'] = self.quota_id
        if self.record_id is not None:
            result['recordId'] = self.record_id
        if self.record_num_per_day is not None:
            result['recordNumPerDay'] = self.record_num_per_day
        if self.record_num_per_hour is not None:
            result['recordNumPerHour'] = self.record_num_per_hour
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('calType') is not None:
            self.cal_type = m.get('calType')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('leaveCode') is not None:
            self.leave_code = m.get('leaveCode')
        if m.get('leaveReason') is not None:
            self.leave_reason = m.get('leaveReason')
        if m.get('leaveRecordType') is not None:
            self.leave_record_type = m.get('leaveRecordType')
        if m.get('leaveStatus') is not None:
            self.leave_status = m.get('leaveStatus')
        if m.get('leaveViewUnit') is not None:
            self.leave_view_unit = m.get('leaveViewUnit')
        if m.get('quotaId') is not None:
            self.quota_id = m.get('quotaId')
        if m.get('recordId') is not None:
            self.record_id = m.get('recordId')
        if m.get('recordNumPerDay') is not None:
            self.record_num_per_day = m.get('recordNumPerDay')
        if m.get('recordNumPerHour') is not None:
            self.record_num_per_hour = m.get('recordNumPerHour')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetLeaveRecordsResponseBodyResult(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        leave_records: List[GetLeaveRecordsResponseBodyResultLeaveRecords] = None,
    ):
        # 是否有更多结果。
        self.has_more = has_more
        # 假期消费记录列表。
        self.leave_records = leave_records

    def validate(self):
        if self.leave_records:
            for k in self.leave_records:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['leaveRecords'] = []
        if self.leave_records is not None:
            for k in self.leave_records:
                result['leaveRecords'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.leave_records = []
        if m.get('leaveRecords') is not None:
            for k in m.get('leaveRecords'):
                temp_model = GetLeaveRecordsResponseBodyResultLeaveRecords()
                self.leave_records.append(temp_model.from_map(k))
        return self


class GetLeaveRecordsResponseBody(TeaModel):
    def __init__(
        self,
        result: GetLeaveRecordsResponseBodyResult = None,
        success: bool = None,
    ):
        # 返回结果。
        # 
        self.result = result
        # 是否正确访问。
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
            temp_model = GetLeaveRecordsResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetLeaveRecordsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetLeaveRecordsResponseBody = None,
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
            temp_model = GetLeaveRecordsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetLeaveTypeHeaders(TeaModel):
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


class GetLeaveTypeRequest(TeaModel):
    def __init__(
        self,
        op_user_id: str = None,
        vacation_source: str = None,
    ):
        # 操作者ID
        self.op_user_id = op_user_id
        # 空:开放接口定义假期类型;all:所有假期类型
        self.vacation_source = vacation_source

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.vacation_source is not None:
            result['vacationSource'] = self.vacation_source
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('vacationSource') is not None:
            self.vacation_source = m.get('vacationSource')
        return self


class GetLeaveTypeResponseBodyResultLeaveCertificate(TeaModel):
    def __init__(
        self,
        duration: float = None,
        enable: bool = None,
        prompt_information: str = None,
        unit: str = None,
    ):
        # 超过多长时间需提供请假证明
        self.duration = duration
        # 是否开启请假证明
        self.enable = enable
        # 请假提示文案
        self.prompt_information = prompt_information
        # 请假证明单位hour，day
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.duration is not None:
            result['duration'] = self.duration
        if self.enable is not None:
            result['enable'] = self.enable
        if self.prompt_information is not None:
            result['promptInformation'] = self.prompt_information
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('enable') is not None:
            self.enable = m.get('enable')
        if m.get('promptInformation') is not None:
            self.prompt_information = m.get('promptInformation')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class GetLeaveTypeResponseBodyResultSubmitTimeRule(TeaModel):
    def __init__(
        self,
        enable_time_limit: bool = None,
        time_type: str = None,
        time_unit: str = None,
        time_value: int = None,
    ):
        # 是否开启限时提交功能：仅且为true时开启
        self.enable_time_limit = enable_time_limit
        # 限制类型：before-提前；after-补交
        self.time_type = time_type
        # 时间单位：day-天；hour-小时
        self.time_unit = time_unit
        # 限制值：timeUnit=day时，有效值范围[0~30] 天；timeUnit=hour时，有效值范围[0~24] 小时
        self.time_value = time_value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.enable_time_limit is not None:
            result['enableTimeLimit'] = self.enable_time_limit
        if self.time_type is not None:
            result['timeType'] = self.time_type
        if self.time_unit is not None:
            result['timeUnit'] = self.time_unit
        if self.time_value is not None:
            result['timeValue'] = self.time_value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('enableTimeLimit') is not None:
            self.enable_time_limit = m.get('enableTimeLimit')
        if m.get('timeType') is not None:
            self.time_type = m.get('timeType')
        if m.get('timeUnit') is not None:
            self.time_unit = m.get('timeUnit')
        if m.get('timeValue') is not None:
            self.time_value = m.get('timeValue')
        return self


class GetLeaveTypeResponseBodyResultVisibilityRules(TeaModel):
    def __init__(
        self,
        type: str = None,
        visible: List[str] = None,
    ):
        # 规则类型：dept-部门；staff-员工；label-角色
        self.type = type
        # 规则数据：当type=staff时，传员工userId列表；当type=dept时，传部门id列表；当type=label时，传角色id列表
        self.visible = visible

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.visible is not None:
            result['visible'] = self.visible
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('visible') is not None:
            self.visible = m.get('visible')
        return self


class GetLeaveTypeResponseBodyResult(TeaModel):
    def __init__(
        self,
        biz_type: str = None,
        hours_in_per_day: int = None,
        leave_certificate: GetLeaveTypeResponseBodyResultLeaveCertificate = None,
        leave_code: str = None,
        leave_name: str = None,
        leave_view_unit: str = None,
        natural_day_leave: bool = None,
        source: str = None,
        submit_time_rule: GetLeaveTypeResponseBodyResultSubmitTimeRule = None,
        validity_type: str = None,
        validity_value: str = None,
        visibility_rules: List[GetLeaveTypeResponseBodyResultVisibilityRules] = None,
    ):
        # 假期类型，普通假期或者加班转调休假期。(general_leave、lieu_leave其中一种)
        self.biz_type = biz_type
        # 每天折算的工作时长(百分之一 例如1天=10小时=1000)
        self.hours_in_per_day = hours_in_per_day
        # 请假证明
        self.leave_certificate = leave_certificate
        # 假期类型唯一标识
        self.leave_code = leave_code
        # 假期名称
        self.leave_name = leave_name
        # 请假单位，可以按照天半天或者小时请假。(day、halfDay、hour其中一种)
        self.leave_view_unit = leave_view_unit
        # 是否按照自然日统计请假时长，当为false的时候，用户发起请假时候会根据用户在请假时间段内的排班情况来计算请假时长。
        self.natural_day_leave = natural_day_leave
        # 开放接口自定义的:external oa后台新建的：inner
        self.source = source
        # 限时提交规则
        self.submit_time_rule = submit_time_rule
        # 有效类型 absolute_time(绝对时间)、relative_time(相对时间)其中一种
        self.validity_type = validity_type
        # 延长日期(当validity_type为absolute_time该值该值不为空且满足yy-mm格式 validity_type为relative_time该值为大于1的整数)
        self.validity_value = validity_value
        # 适用范围规则列表：哪些部门/员工可以使用该假期类型，不传默认为全公司
        self.visibility_rules = visibility_rules

    def validate(self):
        if self.leave_certificate:
            self.leave_certificate.validate()
        if self.submit_time_rule:
            self.submit_time_rule.validate()
        if self.visibility_rules:
            for k in self.visibility_rules:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.hours_in_per_day is not None:
            result['hoursInPerDay'] = self.hours_in_per_day
        if self.leave_certificate is not None:
            result['leaveCertificate'] = self.leave_certificate.to_map()
        if self.leave_code is not None:
            result['leaveCode'] = self.leave_code
        if self.leave_name is not None:
            result['leaveName'] = self.leave_name
        if self.leave_view_unit is not None:
            result['leaveViewUnit'] = self.leave_view_unit
        if self.natural_day_leave is not None:
            result['naturalDayLeave'] = self.natural_day_leave
        if self.source is not None:
            result['source'] = self.source
        if self.submit_time_rule is not None:
            result['submitTimeRule'] = self.submit_time_rule.to_map()
        if self.validity_type is not None:
            result['validityType'] = self.validity_type
        if self.validity_value is not None:
            result['validityValue'] = self.validity_value
        result['visibilityRules'] = []
        if self.visibility_rules is not None:
            for k in self.visibility_rules:
                result['visibilityRules'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('hoursInPerDay') is not None:
            self.hours_in_per_day = m.get('hoursInPerDay')
        if m.get('leaveCertificate') is not None:
            temp_model = GetLeaveTypeResponseBodyResultLeaveCertificate()
            self.leave_certificate = temp_model.from_map(m['leaveCertificate'])
        if m.get('leaveCode') is not None:
            self.leave_code = m.get('leaveCode')
        if m.get('leaveName') is not None:
            self.leave_name = m.get('leaveName')
        if m.get('leaveViewUnit') is not None:
            self.leave_view_unit = m.get('leaveViewUnit')
        if m.get('naturalDayLeave') is not None:
            self.natural_day_leave = m.get('naturalDayLeave')
        if m.get('source') is not None:
            self.source = m.get('source')
        if m.get('submitTimeRule') is not None:
            temp_model = GetLeaveTypeResponseBodyResultSubmitTimeRule()
            self.submit_time_rule = temp_model.from_map(m['submitTimeRule'])
        if m.get('validityType') is not None:
            self.validity_type = m.get('validityType')
        if m.get('validityValue') is not None:
            self.validity_value = m.get('validityValue')
        self.visibility_rules = []
        if m.get('visibilityRules') is not None:
            for k in m.get('visibilityRules'):
                temp_model = GetLeaveTypeResponseBodyResultVisibilityRules()
                self.visibility_rules.append(temp_model.from_map(k))
        return self


class GetLeaveTypeResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetLeaveTypeResponseBodyResult] = None,
    ):
        # 返回参数
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
                temp_model = GetLeaveTypeResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GetLeaveTypeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetLeaveTypeResponseBody = None,
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
            temp_model = GetLeaveTypeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetMachineHeaders(TeaModel):
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


class GetMachineResponseBodyResultMachineBluetoothVO(TeaModel):
    def __init__(
        self,
        address: str = None,
        bluetooth_check_with_face: bool = None,
        bluetooth_distance_mode: str = None,
        bluetooth_distance_mode_desc: str = None,
        bluetooth_value: bool = None,
        latitude: float = None,
        limit_user_device_count: bool = None,
        longitude: float = None,
        monitor_location_abnormal: bool = None,
        user_device_count: int = None,
    ):
        # 地址位置描述
        self.address = address
        # 蓝牙打卡人脸识别开关值
        self.bluetooth_check_with_face = bluetooth_check_with_face
        # 蓝牙打卡范围
        self.bluetooth_distance_mode = bluetooth_distance_mode
        # 蓝牙打卡范围描述
        self.bluetooth_distance_mode_desc = bluetooth_distance_mode_desc
        # 蓝牙打卡开关
        self.bluetooth_value = bluetooth_value
        # 纬度
        self.latitude = latitude
        # 是否限制员工常用手机
        self.limit_user_device_count = limit_user_device_count
        # 经度
        self.longitude = longitude
        # 是否打开位置异常监控
        self.monitor_location_abnormal = monitor_location_abnormal
        # 员工常用手机数量
        self.user_device_count = user_device_count

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.address is not None:
            result['address'] = self.address
        if self.bluetooth_check_with_face is not None:
            result['bluetoothCheckWithFace'] = self.bluetooth_check_with_face
        if self.bluetooth_distance_mode is not None:
            result['bluetoothDistanceMode'] = self.bluetooth_distance_mode
        if self.bluetooth_distance_mode_desc is not None:
            result['bluetoothDistanceModeDesc'] = self.bluetooth_distance_mode_desc
        if self.bluetooth_value is not None:
            result['bluetoothValue'] = self.bluetooth_value
        if self.latitude is not None:
            result['latitude'] = self.latitude
        if self.limit_user_device_count is not None:
            result['limitUserDeviceCount'] = self.limit_user_device_count
        if self.longitude is not None:
            result['longitude'] = self.longitude
        if self.monitor_location_abnormal is not None:
            result['monitorLocationAbnormal'] = self.monitor_location_abnormal
        if self.user_device_count is not None:
            result['userDeviceCount'] = self.user_device_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('address') is not None:
            self.address = m.get('address')
        if m.get('bluetoothCheckWithFace') is not None:
            self.bluetooth_check_with_face = m.get('bluetoothCheckWithFace')
        if m.get('bluetoothDistanceMode') is not None:
            self.bluetooth_distance_mode = m.get('bluetoothDistanceMode')
        if m.get('bluetoothDistanceModeDesc') is not None:
            self.bluetooth_distance_mode_desc = m.get('bluetoothDistanceModeDesc')
        if m.get('bluetoothValue') is not None:
            self.bluetooth_value = m.get('bluetoothValue')
        if m.get('latitude') is not None:
            self.latitude = m.get('latitude')
        if m.get('limitUserDeviceCount') is not None:
            self.limit_user_device_count = m.get('limitUserDeviceCount')
        if m.get('longitude') is not None:
            self.longitude = m.get('longitude')
        if m.get('monitorLocationAbnormal') is not None:
            self.monitor_location_abnormal = m.get('monitorLocationAbnormal')
        if m.get('userDeviceCount') is not None:
            self.user_device_count = m.get('userDeviceCount')
        return self


class GetMachineResponseBodyResult(TeaModel):
    def __init__(
        self,
        atm_manager_list: List[str] = None,
        dev_id: int = None,
        device_id: str = None,
        device_name: str = None,
        device_sn: str = None,
        machine_bluetooth_vo: GetMachineResponseBodyResultMachineBluetoothVO = None,
        max_face: int = None,
        net_status: str = None,
        product_name: str = None,
        product_version: str = None,
        voice_mode: int = None,
    ):
        # 设备管理员列表
        self.atm_manager_list = atm_manager_list
        # 设备id (deviceId)
        self.dev_id = dev_id
        # 设备id (deviceUid加密之后)
        self.device_id = device_id
        # 设备名称
        self.device_name = device_name
        # 设备sn号
        self.device_sn = device_sn
        # 考勤机蓝牙相关设置信息
        self.machine_bluetooth_vo = machine_bluetooth_vo
        # 人脸容量
        self.max_face = max_face
        # 网络状态
        self.net_status = net_status
        # 设备类型名称
        self.product_name = product_name
        # 固件版本
        self.product_version = product_version
        # 音量模式
        self.voice_mode = voice_mode

    def validate(self):
        if self.machine_bluetooth_vo:
            self.machine_bluetooth_vo.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.atm_manager_list is not None:
            result['atmManagerList'] = self.atm_manager_list
        if self.dev_id is not None:
            result['devId'] = self.dev_id
        if self.device_id is not None:
            result['deviceId'] = self.device_id
        if self.device_name is not None:
            result['deviceName'] = self.device_name
        if self.device_sn is not None:
            result['deviceSn'] = self.device_sn
        if self.machine_bluetooth_vo is not None:
            result['machineBluetoothVO'] = self.machine_bluetooth_vo.to_map()
        if self.max_face is not None:
            result['maxFace'] = self.max_face
        if self.net_status is not None:
            result['netStatus'] = self.net_status
        if self.product_name is not None:
            result['productName'] = self.product_name
        if self.product_version is not None:
            result['productVersion'] = self.product_version
        if self.voice_mode is not None:
            result['voiceMode'] = self.voice_mode
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('atmManagerList') is not None:
            self.atm_manager_list = m.get('atmManagerList')
        if m.get('devId') is not None:
            self.dev_id = m.get('devId')
        if m.get('deviceId') is not None:
            self.device_id = m.get('deviceId')
        if m.get('deviceName') is not None:
            self.device_name = m.get('deviceName')
        if m.get('deviceSn') is not None:
            self.device_sn = m.get('deviceSn')
        if m.get('machineBluetoothVO') is not None:
            temp_model = GetMachineResponseBodyResultMachineBluetoothVO()
            self.machine_bluetooth_vo = temp_model.from_map(m['machineBluetoothVO'])
        if m.get('maxFace') is not None:
            self.max_face = m.get('maxFace')
        if m.get('netStatus') is not None:
            self.net_status = m.get('netStatus')
        if m.get('productName') is not None:
            self.product_name = m.get('productName')
        if m.get('productVersion') is not None:
            self.product_version = m.get('productVersion')
        if m.get('voiceMode') is not None:
            self.voice_mode = m.get('voiceMode')
        return self


class GetMachineResponseBody(TeaModel):
    def __init__(
        self,
        result: GetMachineResponseBodyResult = None,
    ):
        # 查询结果
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
            temp_model = GetMachineResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetMachineResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetMachineResponseBody = None,
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
            temp_model = GetMachineResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetMachineUserHeaders(TeaModel):
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


class GetMachineUserRequest(TeaModel):
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


class GetMachineUserResponseBodyResultUserList(TeaModel):
    def __init__(
        self,
        has_face: bool = None,
        name: str = None,
        user_id: str = None,
    ):
        self.has_face = has_face
        self.name = name
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_face is not None:
            result['hasFace'] = self.has_face
        if self.name is not None:
            result['name'] = self.name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasFace') is not None:
            self.has_face = m.get('hasFace')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetMachineUserResponseBodyResult(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        next_token: str = None,
        user_list: List[GetMachineUserResponseBodyResultUserList] = None,
    ):
        self.has_more = has_more
        self.next_token = next_token
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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['userList'] = []
        if self.user_list is not None:
            for k in self.user_list:
                result['userList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.user_list = []
        if m.get('userList') is not None:
            for k in m.get('userList'):
                temp_model = GetMachineUserResponseBodyResultUserList()
                self.user_list.append(temp_model.from_map(k))
        return self


class GetMachineUserResponseBody(TeaModel):
    def __init__(
        self,
        result: GetMachineUserResponseBodyResult = None,
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
            temp_model = GetMachineUserResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetMachineUserResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetMachineUserResponseBody = None,
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
            temp_model = GetMachineUserResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetOvertimeSettingHeaders(TeaModel):
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


class GetOvertimeSettingRequest(TeaModel):
    def __init__(
        self,
        overtime_setting_ids: List[int] = None,
    ):
        self.overtime_setting_ids = overtime_setting_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.overtime_setting_ids is not None:
            result['overtimeSettingIds'] = self.overtime_setting_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('overtimeSettingIds') is not None:
            self.overtime_setting_ids = m.get('overtimeSettingIds')
        return self


class GetOvertimeSettingResponseBodyResultOvertimeDivisions(TeaModel):
    def __init__(
        self,
        next_day_type: str = None,
        previous_day_type: str = None,
        time_split_point: str = None,
    ):
        # 后一日类型
        self.next_day_type = next_day_type
        # 前一日类型
        self.previous_day_type = previous_day_type
        # 分割时间点
        self.time_split_point = time_split_point

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_day_type is not None:
            result['nextDayType'] = self.next_day_type
        if self.previous_day_type is not None:
            result['previousDayType'] = self.previous_day_type
        if self.time_split_point is not None:
            result['timeSplitPoint'] = self.time_split_point
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextDayType') is not None:
            self.next_day_type = m.get('nextDayType')
        if m.get('previousDayType') is not None:
            self.previous_day_type = m.get('previousDayType')
        if m.get('timeSplitPoint') is not None:
            self.time_split_point = m.get('timeSplitPoint')
        return self


class GetOvertimeSettingResponseBodyResultWarningSettings(TeaModel):
    def __init__(
        self,
        action: str = None,
        threshold: int = None,
        time: str = None,
    ):
        # 风险预警 或 最大加班时间
        self.action = action
        # 提醒阈值
        self.threshold = threshold
        # 预警类型
        self.time = time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action is not None:
            result['action'] = self.action
        if self.threshold is not None:
            result['threshold'] = self.threshold
        if self.time is not None:
            result['time'] = self.time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('action') is not None:
            self.action = m.get('action')
        if m.get('threshold') is not None:
            self.threshold = m.get('threshold')
        if m.get('time') is not None:
            self.time = m.get('time')
        return self


class ResultDurationSettingsValueSkipTimeByFrames(TeaModel):
    def __init__(
        self,
        start_time: str = None,
        end_time: str = None,
        valid: bool = None,
    ):
        # 开始时间，格式为"HH:mm"
        self.start_time = start_time
        # 结束时间，格式为"HH:mm"
        self.end_time = end_time
        # 是否生效
        self.valid = valid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.valid is not None:
            result['valid'] = self.valid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('valid') is not None:
            self.valid = m.get('valid')
        return self


class ResultDurationSettingsValueSkipTimeByDurations(TeaModel):
    def __init__(
        self,
        duration: int = None,
        minus: int = None,
    ):
        # 每天加班满 x小时，单位 秒
        self.duration = duration
        # 扣除 x小时，单位 秒
        self.minus = minus

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.duration is not None:
            result['duration'] = self.duration
        if self.minus is not None:
            result['minus'] = self.minus
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('minus') is not None:
            self.minus = m.get('minus')
        return self


class ResultDurationSettingsValue(TeaModel):
    def __init__(
        self,
        calc_type: int = None,
        duration_type: int = None,
        overtime_redress: bool = None,
        settings: Dict[str, Any] = None,
        overtime_redress_by: str = None,
        vacation_rate: float = None,
        skip_time: str = None,
        skip_time_by_frames: List[ResultDurationSettingsValueSkipTimeByFrames] = None,
        skip_time_by_durations: List[ResultDurationSettingsValueSkipTimeByDurations] = None,
        holiday_plan_overtime_redress: bool = None,
        holiday_plan_overtime_redress_by: str = None,
        holiday_plan_vacation_rate: float = None,
    ):
        self.calc_type = calc_type
        self.duration_type = duration_type
        # 加班时长计为调休或加班费开关
        self.overtime_redress = overtime_redress
        # 加班开始时间 或 最小加班时间
        self.settings = settings
        # 加班时长计为方式
        self.overtime_redress_by = overtime_redress_by
        # 调休时长计算
        self.vacation_rate = vacation_rate
        # 扣除休息时间
        self.skip_time = skip_time
        # 休息时段
        self.skip_time_by_frames = skip_time_by_frames
        # 加班时长
        self.skip_time_by_durations = skip_time_by_durations
        # 休息日或节假日排班加班时长计为调休或加班费开关
        self.holiday_plan_overtime_redress = holiday_plan_overtime_redress
        # 休息日或节假日排班加班时长计为方式
        self.holiday_plan_overtime_redress_by = holiday_plan_overtime_redress_by
        # 休息日或节假日排班调休时长计算
        self.holiday_plan_vacation_rate = holiday_plan_vacation_rate

    def validate(self):
        if self.skip_time_by_frames:
            for k in self.skip_time_by_frames:
                if k:
                    k.validate()
        if self.skip_time_by_durations:
            for k in self.skip_time_by_durations:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.calc_type is not None:
            result['calcType'] = self.calc_type
        if self.duration_type is not None:
            result['durationType'] = self.duration_type
        if self.overtime_redress is not None:
            result['overtimeRedress'] = self.overtime_redress
        if self.settings is not None:
            result['settings'] = self.settings
        if self.overtime_redress_by is not None:
            result['overtimeRedressBy'] = self.overtime_redress_by
        if self.vacation_rate is not None:
            result['vacationRate'] = self.vacation_rate
        if self.skip_time is not None:
            result['skipTime'] = self.skip_time
        result['skipTimeByFrames'] = []
        if self.skip_time_by_frames is not None:
            for k in self.skip_time_by_frames:
                result['skipTimeByFrames'].append(k.to_map() if k else None)
        result['skipTimeByDurations'] = []
        if self.skip_time_by_durations is not None:
            for k in self.skip_time_by_durations:
                result['skipTimeByDurations'].append(k.to_map() if k else None)
        if self.holiday_plan_overtime_redress is not None:
            result['holidayPlanOvertimeRedress'] = self.holiday_plan_overtime_redress
        if self.holiday_plan_overtime_redress_by is not None:
            result['holidayPlanOvertimeRedressBy'] = self.holiday_plan_overtime_redress_by
        if self.holiday_plan_vacation_rate is not None:
            result['holidayPlanVacationRate'] = self.holiday_plan_vacation_rate
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('calcType') is not None:
            self.calc_type = m.get('calcType')
        if m.get('durationType') is not None:
            self.duration_type = m.get('durationType')
        if m.get('overtimeRedress') is not None:
            self.overtime_redress = m.get('overtimeRedress')
        if m.get('settings') is not None:
            self.settings = m.get('settings')
        if m.get('overtimeRedressBy') is not None:
            self.overtime_redress_by = m.get('overtimeRedressBy')
        if m.get('vacationRate') is not None:
            self.vacation_rate = m.get('vacationRate')
        if m.get('skipTime') is not None:
            self.skip_time = m.get('skipTime')
        self.skip_time_by_frames = []
        if m.get('skipTimeByFrames') is not None:
            for k in m.get('skipTimeByFrames'):
                temp_model = ResultDurationSettingsValueSkipTimeByFrames()
                self.skip_time_by_frames.append(temp_model.from_map(k))
        self.skip_time_by_durations = []
        if m.get('skipTimeByDurations') is not None:
            for k in m.get('skipTimeByDurations'):
                temp_model = ResultDurationSettingsValueSkipTimeByDurations()
                self.skip_time_by_durations.append(temp_model.from_map(k))
        if m.get('holidayPlanOvertimeRedress') is not None:
            self.holiday_plan_overtime_redress = m.get('holidayPlanOvertimeRedress')
        if m.get('holidayPlanOvertimeRedressBy') is not None:
            self.holiday_plan_overtime_redress_by = m.get('holidayPlanOvertimeRedressBy')
        if m.get('holidayPlanVacationRate') is not None:
            self.holiday_plan_vacation_rate = m.get('holidayPlanVacationRate')
        return self


class GetOvertimeSettingResponseBodyResult(TeaModel):
    def __init__(
        self,
        default: bool = None,
        duration_settings: Dict[str, ResultDurationSettingsValue] = None,
        id: int = None,
        name: str = None,
        overtime_divisions: List[GetOvertimeSettingResponseBodyResultOvertimeDivisions] = None,
        setting_id: int = None,
        step_type: int = None,
        step_value: float = None,
        warning_settings: List[GetOvertimeSettingResponseBodyResultWarningSettings] = None,
        work_minutes_per_day: int = None,
    ):
        # 是否默认
        self.default = default
        self.duration_settings = duration_settings
        # 历史加班规则设置id
        self.id = id
        # 规则名称
        self.name = name
        # 时间分割规则
        self.overtime_divisions = overtime_divisions
        # 设置id
        self.setting_id = setting_id
        # 加班时长单位
        self.step_type = step_type
        # 加班时长是否取整 单位 小时
        self.step_value = step_value
        self.warning_settings = warning_settings
        # 日折算时长 单位：分钟
        self.work_minutes_per_day = work_minutes_per_day

    def validate(self):
        if self.duration_settings:
            for v in self.duration_settings.values():
                if v:
                    v.validate()
        if self.overtime_divisions:
            for k in self.overtime_divisions:
                if k:
                    k.validate()
        if self.warning_settings:
            for k in self.warning_settings:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.default is not None:
            result['default'] = self.default
        result['durationSettings'] = {}
        if self.duration_settings is not None:
            for k, v in self.duration_settings.items():
                result['durationSettings'][k] = v.to_map()
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        result['overtimeDivisions'] = []
        if self.overtime_divisions is not None:
            for k in self.overtime_divisions:
                result['overtimeDivisions'].append(k.to_map() if k else None)
        if self.setting_id is not None:
            result['settingId'] = self.setting_id
        if self.step_type is not None:
            result['stepType'] = self.step_type
        if self.step_value is not None:
            result['stepValue'] = self.step_value
        result['warningSettings'] = []
        if self.warning_settings is not None:
            for k in self.warning_settings:
                result['warningSettings'].append(k.to_map() if k else None)
        if self.work_minutes_per_day is not None:
            result['workMinutesPerDay'] = self.work_minutes_per_day
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('default') is not None:
            self.default = m.get('default')
        self.duration_settings = {}
        if m.get('durationSettings') is not None:
            for k, v in m.get('durationSettings').items():
                temp_model = ResultDurationSettingsValue()
                self.duration_settings[k] = temp_model.from_map(v)
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        self.overtime_divisions = []
        if m.get('overtimeDivisions') is not None:
            for k in m.get('overtimeDivisions'):
                temp_model = GetOvertimeSettingResponseBodyResultOvertimeDivisions()
                self.overtime_divisions.append(temp_model.from_map(k))
        if m.get('settingId') is not None:
            self.setting_id = m.get('settingId')
        if m.get('stepType') is not None:
            self.step_type = m.get('stepType')
        if m.get('stepValue') is not None:
            self.step_value = m.get('stepValue')
        self.warning_settings = []
        if m.get('warningSettings') is not None:
            for k in m.get('warningSettings'):
                temp_model = GetOvertimeSettingResponseBodyResultWarningSettings()
                self.warning_settings.append(temp_model.from_map(k))
        if m.get('workMinutesPerDay') is not None:
            self.work_minutes_per_day = m.get('workMinutesPerDay')
        return self


class GetOvertimeSettingResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetOvertimeSettingResponseBodyResult] = None,
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
                temp_model = GetOvertimeSettingResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GetOvertimeSettingResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetOvertimeSettingResponseBody = None,
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
            temp_model = GetOvertimeSettingResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetSimpleOvertimeSettingHeaders(TeaModel):
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


class GetSimpleOvertimeSettingRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
    ):
        self.page_number = page_number
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class GetSimpleOvertimeSettingResponseBodyResultItems(TeaModel):
    def __init__(
        self,
        id: int = None,
        name: str = None,
        setting_id: int = None,
    ):
        # 加班规则id
        self.id = id
        # 加班规则名称
        self.name = name
        self.setting_id = setting_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.setting_id is not None:
            result['settingId'] = self.setting_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('settingId') is not None:
            self.setting_id = m.get('settingId')
        return self


class GetSimpleOvertimeSettingResponseBodyResult(TeaModel):
    def __init__(
        self,
        items: List[GetSimpleOvertimeSettingResponseBodyResultItems] = None,
        page_number: int = None,
        total_page: int = None,
    ):
        # 加班规则集合
        self.items = items
        # 当前页码
        self.page_number = page_number
        # 总页数
        self.total_page = total_page

    def validate(self):
        if self.items:
            for k in self.items:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.total_page is not None:
            result['totalPage'] = self.total_page
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.items = []
        if m.get('items') is not None:
            for k in m.get('items'):
                temp_model = GetSimpleOvertimeSettingResponseBodyResultItems()
                self.items.append(temp_model.from_map(k))
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('totalPage') is not None:
            self.total_page = m.get('totalPage')
        return self


class GetSimpleOvertimeSettingResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetSimpleOvertimeSettingResponseBodyResult] = None,
    ):
        # Id of the request
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
                temp_model = GetSimpleOvertimeSettingResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GetSimpleOvertimeSettingResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetSimpleOvertimeSettingResponseBody = None,
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
            temp_model = GetSimpleOvertimeSettingResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetUserHolidaysHeaders(TeaModel):
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


class GetUserHolidaysRequest(TeaModel):
    def __init__(
        self,
        user_ids: List[str] = None,
        work_date_from: int = None,
        work_date_to: int = None,
    ):
        # 员工列表
        self.user_ids = user_ids
        # 开始日期
        self.work_date_from = work_date_from
        # 结束日期
        self.work_date_to = work_date_to

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        if self.work_date_from is not None:
            result['workDateFrom'] = self.work_date_from
        if self.work_date_to is not None:
            result['workDateTo'] = self.work_date_to
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        if m.get('workDateFrom') is not None:
            self.work_date_from = m.get('workDateFrom')
        if m.get('workDateTo') is not None:
            self.work_date_to = m.get('workDateTo')
        return self


class GetUserHolidaysResponseBodyResultHolidays(TeaModel):
    def __init__(
        self,
        holiday_name: str = None,
        holiday_type: str = None,
        real_work_date: int = None,
        work_date: int = None,
    ):
        # 假期名称
        self.holiday_name = holiday_name
        # 假期类型，festival：法定节假日；rest：调休日；overtime：加班日；
        self.holiday_type = holiday_type
        # 补休日，只有假期类型为加班日时才有值
        self.real_work_date = real_work_date
        # 日期
        self.work_date = work_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.holiday_name is not None:
            result['holidayName'] = self.holiday_name
        if self.holiday_type is not None:
            result['holidayType'] = self.holiday_type
        if self.real_work_date is not None:
            result['realWorkDate'] = self.real_work_date
        if self.work_date is not None:
            result['workDate'] = self.work_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('holidayName') is not None:
            self.holiday_name = m.get('holidayName')
        if m.get('holidayType') is not None:
            self.holiday_type = m.get('holidayType')
        if m.get('realWorkDate') is not None:
            self.real_work_date = m.get('realWorkDate')
        if m.get('workDate') is not None:
            self.work_date = m.get('workDate')
        return self


class GetUserHolidaysResponseBodyResult(TeaModel):
    def __init__(
        self,
        holidays: List[GetUserHolidaysResponseBodyResultHolidays] = None,
        user_id: str = None,
    ):
        # 假期列表
        self.holidays = holidays
        # 员工id
        self.user_id = user_id

    def validate(self):
        if self.holidays:
            for k in self.holidays:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['holidays'] = []
        if self.holidays is not None:
            for k in self.holidays:
                result['holidays'].append(k.to_map() if k else None)
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.holidays = []
        if m.get('holidays') is not None:
            for k in m.get('holidays'):
                temp_model = GetUserHolidaysResponseBodyResultHolidays()
                self.holidays.append(temp_model.from_map(k))
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetUserHolidaysResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetUserHolidaysResponseBodyResult] = None,
    ):
        # 员工假期列表
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
                temp_model = GetUserHolidaysResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GetUserHolidaysResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetUserHolidaysResponseBody = None,
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
            temp_model = GetUserHolidaysResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GroupAddHeaders(TeaModel):
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


class GroupAddRequestBleDeviceList(TeaModel):
    def __init__(
        self,
        device_id: int = None,
    ):
        # 设备ID，调用查询员工智能考勤机列表获取。
        self.device_id = device_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_id is not None:
            result['deviceId'] = self.device_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceId') is not None:
            self.device_id = m.get('deviceId')
        return self


class GroupAddRequestFreeCheckSettingFreeCheckGap(TeaModel):
    def __init__(
        self,
        off_on_check_gap_minutes: int = None,
        on_off_check_gap_minutes: int = None,
    ):
        # 下班打卡最小打卡间隔（单位分钟）。
        self.off_on_check_gap_minutes = off_on_check_gap_minutes
        # 上班打卡最小打卡间隔（单位分钟）。
        self.on_off_check_gap_minutes = on_off_check_gap_minutes

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.off_on_check_gap_minutes is not None:
            result['offOnCheckGapMinutes'] = self.off_on_check_gap_minutes
        if self.on_off_check_gap_minutes is not None:
            result['onOffCheckGapMinutes'] = self.on_off_check_gap_minutes
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('offOnCheckGapMinutes') is not None:
            self.off_on_check_gap_minutes = m.get('offOnCheckGapMinutes')
        if m.get('onOffCheckGapMinutes') is not None:
            self.on_off_check_gap_minutes = m.get('onOffCheckGapMinutes')
        return self


class GroupAddRequestFreeCheckSetting(TeaModel):
    def __init__(
        self,
        free_check_gap: GroupAddRequestFreeCheckSettingFreeCheckGap = None,
    ):
        # 休息日打卡间隔设置。
        self.free_check_gap = free_check_gap

    def validate(self):
        if self.free_check_gap:
            self.free_check_gap.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.free_check_gap is not None:
            result['freeCheckGap'] = self.free_check_gap.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('freeCheckGap') is not None:
            temp_model = GroupAddRequestFreeCheckSettingFreeCheckGap()
            self.free_check_gap = temp_model.from_map(m['freeCheckGap'])
        return self


class GroupAddRequestMembers(TeaModel):
    def __init__(
        self,
        role: str = None,
        type: str = None,
        user_id: str = None,
    ):
        # 角色，固定值Attendance。
        self.role = role
        # 类型，固定值StaffMember。
        self.type = type
        # 用户userid。
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.role is not None:
            result['role'] = self.role
        if self.type is not None:
            result['type'] = self.type
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('role') is not None:
            self.role = m.get('role')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GroupAddRequestPositions(TeaModel):
    def __init__(
        self,
        address: str = None,
        latitude: str = None,
        longitude: str = None,
        offset: int = None,
        title: str = None,
    ):
        # 考勤地址。
        self.address = address
        # 纬度。
        self.latitude = latitude
        # 经度。
        self.longitude = longitude
        # 考勤范围。
        self.offset = offset
        # 考勤标题。
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.address is not None:
            result['address'] = self.address
        if self.latitude is not None:
            result['latitude'] = self.latitude
        if self.longitude is not None:
            result['longitude'] = self.longitude
        if self.offset is not None:
            result['offset'] = self.offset
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('address') is not None:
            self.address = m.get('address')
        if m.get('latitude') is not None:
            self.latitude = m.get('latitude')
        if m.get('longitude') is not None:
            self.longitude = m.get('longitude')
        if m.get('offset') is not None:
            self.offset = m.get('offset')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class GroupAddRequestResourcePermissionMap(TeaModel):
    def __init__(
        self,
        camera_check: str = None,
        check_position_type: str = None,
        check_time: str = None,
        group_member: str = None,
        group_type: str = None,
        out_side_check: str = None,
        over_time_rule: str = None,
        schedule: str = None,
    ):
        # 设置拍照打卡规则。
        self.camera_check = camera_check
        # 设置打卡方式。
        self.check_position_type = check_position_type
        # 设置考勤时间。
        self.check_time = check_time
        # 设置参与考勤人员。
        self.group_member = group_member
        # 设置考勤类型。
        self.group_type = group_type
        # 设置外勤打卡。
        self.out_side_check = out_side_check
        # 设置加班规则。
        self.over_time_rule = over_time_rule
        # 员工排班。
        self.schedule = schedule

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.camera_check is not None:
            result['cameraCheck'] = self.camera_check
        if self.check_position_type is not None:
            result['checkPositionType'] = self.check_position_type
        if self.check_time is not None:
            result['checkTime'] = self.check_time
        if self.group_member is not None:
            result['groupMember'] = self.group_member
        if self.group_type is not None:
            result['groupType'] = self.group_type
        if self.out_side_check is not None:
            result['outSideCheck'] = self.out_side_check
        if self.over_time_rule is not None:
            result['overTimeRule'] = self.over_time_rule
        if self.schedule is not None:
            result['schedule'] = self.schedule
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cameraCheck') is not None:
            self.camera_check = m.get('cameraCheck')
        if m.get('checkPositionType') is not None:
            self.check_position_type = m.get('checkPositionType')
        if m.get('checkTime') is not None:
            self.check_time = m.get('checkTime')
        if m.get('groupMember') is not None:
            self.group_member = m.get('groupMember')
        if m.get('groupType') is not None:
            self.group_type = m.get('groupType')
        if m.get('outSideCheck') is not None:
            self.out_side_check = m.get('outSideCheck')
        if m.get('overTimeRule') is not None:
            self.over_time_rule = m.get('overTimeRule')
        if m.get('schedule') is not None:
            self.schedule = m.get('schedule')
        return self


class GroupAddRequestShiftVOList(TeaModel):
    def __init__(
        self,
        shift_id: int = None,
    ):
        # 班次ID，可通过获取班次摘要信息接口获取。
        self.shift_id = shift_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.shift_id is not None:
            result['shiftId'] = self.shift_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('shiftId') is not None:
            self.shift_id = m.get('shiftId')
        return self


class GroupAddRequestWifis(TeaModel):
    def __init__(
        self,
        mac_addr: str = None,
        ssid: str = None,
    ):
        # mac地址。
        self.mac_addr = mac_addr
        # wifi的ssid。
        self.ssid = ssid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.mac_addr is not None:
            result['macAddr'] = self.mac_addr
        if self.ssid is not None:
            result['ssid'] = self.ssid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('macAddr') is not None:
            self.mac_addr = m.get('macAddr')
        if m.get('ssid') is not None:
            self.ssid = m.get('ssid')
        return self


class GroupAddRequest(TeaModel):
    def __init__(
        self,
        adjustment_setting_id: int = None,
        ble_device_list: List[GroupAddRequestBleDeviceList] = None,
        check_need_healthy_code: bool = None,
        default_class_id: int = None,
        disable_check_when_rest: bool = None,
        disable_check_without_schedule: bool = None,
        enable_camera_check: bool = None,
        enable_emp_select_class: bool = None,
        enable_face_check: bool = None,
        enable_face_strict_mode: bool = None,
        enable_next_day: bool = None,
        enable_out_side_update_normal_check: bool = None,
        enable_outside_apply: bool = None,
        enable_outside_camera_check: bool = None,
        enable_outside_check: bool = None,
        enable_outside_remark: bool = None,
        enable_position_ble: bool = None,
        enable_trim_distance: bool = None,
        forbid_hide_out_side_address: bool = None,
        free_check_setting: GroupAddRequestFreeCheckSetting = None,
        free_check_type_id: int = None,
        freecheck_day_start_min_offset: int = None,
        freecheck_work_days: List[int] = None,
        group_id: int = None,
        group_name: str = None,
        manager_list: List[str] = None,
        members: List[GroupAddRequestMembers] = None,
        modify_member: bool = None,
        offset: int = None,
        open_face_check: bool = None,
        outside_check_approve_mode_id: int = None,
        overtime_setting_id: int = None,
        owner: str = None,
        positions: List[GroupAddRequestPositions] = None,
        resource_permission_map: List[GroupAddRequestResourcePermissionMap] = None,
        shift_volist: List[GroupAddRequestShiftVOList] = None,
        skip_holidays: bool = None,
        special_days: str = None,
        trim_distance: int = None,
        type: str = None,
        wifis: List[GroupAddRequestWifis] = None,
        workday_class_list: List[int] = None,
        op_user_id: str = None,
    ):
        # 补卡规则settingId。
        self.adjustment_setting_id = adjustment_setting_id
        # 蓝牙打卡相关配置信息。
        self.ble_device_list = ble_device_list
        # 打卡是否需要健康码：
        # 
        # true：开启
        # 
        # false：关闭（默认值）
        self.check_need_healthy_code = check_need_healthy_code
        # 默认班次ID。
        # 
        # 说明 固定班制必填，可通过获取班次摘要信息接口获取
        self.default_class_id = default_class_id
        # 休息日打卡是否需审批：
        # 
        # true：需要
        # 
        # false：不需要
        self.disable_check_when_rest = disable_check_when_rest
        # 未排班时是否禁止员工打卡。
        self.disable_check_without_schedule = disable_check_without_schedule
        # 是否开启拍照打卡。
        # 
        # true：开启
        # 
        # false：关闭（默认值）
        self.enable_camera_check = enable_camera_check
        # 未排班时是否允许员工选择班次打卡。
        self.enable_emp_select_class = enable_emp_select_class
        # 是否开启人脸检测。
        # 
        # true：开启
        # 
        # false：关闭（默认值）
        self.enable_face_check = enable_face_check
        # 是否开启真人验证。
        self.enable_face_strict_mode = enable_face_strict_mode
        # 是否第二天生效。
        # true：是
        # false：否
        self.enable_next_day = enable_next_day
        # 是否允许外勤卡更新内勤卡。
        self.enable_out_side_update_normal_check = enable_out_side_update_normal_check
        # 外勤打卡是否需要审批。
        self.enable_outside_apply = enable_outside_apply
        # 是否开启外勤打卡必须拍照。
        # 
        # true：开启
        # 
        # false：关闭（默认值）
        self.enable_outside_camera_check = enable_outside_camera_check
        # 是否可以外勤打卡。
        # 
        # true：允许（默认值）
        # 
        # false：不允许
        self.enable_outside_check = enable_outside_check
        # 外勤打卡是否需要拍照备注。
        self.enable_outside_remark = enable_outside_remark
        # 是否启用蓝牙定位。
        self.enable_position_ble = enable_position_ble
        # 是否允许地点微调距离。
        self.enable_trim_distance = enable_trim_distance
        # 是否禁止员工隐藏详细地址。
        self.forbid_hide_out_side_address = forbid_hide_out_side_address
        # 休息日打卡规则。
        self.free_check_setting = free_check_setting
        # 休息日打卡方式。
        # 0严格打卡模式 
        # 1标准打卡模式
        self.free_check_type_id = free_check_type_id
        # 自由工时考勤组考勤开始时间与当天0点偏移分钟数。
        # 
        # 例如：540表示9:00
        self.freecheck_day_start_min_offset = freecheck_day_start_min_offset
        # 自由工时考勤组工作日。
        # 说明
        # 0表示休息。
        # 数组内的值，从左到右依次代表周日到周六，每日的排班情况。
        self.freecheck_work_days = freecheck_work_days
        # 考勤组ID。
        self.group_id = group_id
        # 考勤组名。
        self.group_name = group_name
        # 考勤组子管理员userid列表。
        self.manager_list = manager_list
        # 考勤组成员相关设置信息。
        self.members = members
        # 是否有修改考勤组成员相关信息。
        self.modify_member = modify_member
        # 考勤范围。
        self.offset = offset
        # 是否开启人脸打卡。
        self.open_face_check = open_face_check
        # 外勤打卡审批模式-1无需审批，0先审批后打卡是1先打卡后审批
        self.outside_check_approve_mode_id = outside_check_approve_mode_id
        # 加班规则settingId。
        self.overtime_setting_id = overtime_setting_id
        # 考勤组负责人。
        self.owner = owner
        # 考勤地点相关设置信息。
        self.positions = positions
        # 子管理员权限范围。
        # 
        # w：可管理
        # 
        # r：可读
        self.resource_permission_map = resource_permission_map
        # 班次相关配置信息。
        self.shift_volist = shift_volist
        # 是否跳过节假日。
        # 
        # true：跳过（默认值）
        # 
        # false：不跳过
        self.skip_holidays = skip_holidays
        # 特殊日期配置。
        self.special_days = special_days
        # 地点微调范围（单位米）。
        self.trim_distance = trim_distance
        # 考勤组类型：
        # 
        # FIXED：固定班制考勤组
        # 
        # TURN：排班制考勤组
        # 
        # NONE：自由工时考勤组
        self.type = type
        # 考勤wifi打卡相关配置信息。
        self.wifis = wifis
        # 周班次列表。
        # 说明
        # 固定班制必填，0表示休息。
        # 数组内的值，从左到右依次代表周日到周六，每日的排班情况。
        self.workday_class_list = workday_class_list
        # 操作人的userid。
        self.op_user_id = op_user_id

    def validate(self):
        if self.ble_device_list:
            for k in self.ble_device_list:
                if k:
                    k.validate()
        if self.free_check_setting:
            self.free_check_setting.validate()
        if self.members:
            for k in self.members:
                if k:
                    k.validate()
        if self.positions:
            for k in self.positions:
                if k:
                    k.validate()
        if self.resource_permission_map:
            for k in self.resource_permission_map:
                if k:
                    k.validate()
        if self.shift_volist:
            for k in self.shift_volist:
                if k:
                    k.validate()
        if self.wifis:
            for k in self.wifis:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.adjustment_setting_id is not None:
            result['adjustmentSettingId'] = self.adjustment_setting_id
        result['bleDeviceList'] = []
        if self.ble_device_list is not None:
            for k in self.ble_device_list:
                result['bleDeviceList'].append(k.to_map() if k else None)
        if self.check_need_healthy_code is not None:
            result['checkNeedHealthyCode'] = self.check_need_healthy_code
        if self.default_class_id is not None:
            result['defaultClassId'] = self.default_class_id
        if self.disable_check_when_rest is not None:
            result['disableCheckWhenRest'] = self.disable_check_when_rest
        if self.disable_check_without_schedule is not None:
            result['disableCheckWithoutSchedule'] = self.disable_check_without_schedule
        if self.enable_camera_check is not None:
            result['enableCameraCheck'] = self.enable_camera_check
        if self.enable_emp_select_class is not None:
            result['enableEmpSelectClass'] = self.enable_emp_select_class
        if self.enable_face_check is not None:
            result['enableFaceCheck'] = self.enable_face_check
        if self.enable_face_strict_mode is not None:
            result['enableFaceStrictMode'] = self.enable_face_strict_mode
        if self.enable_next_day is not None:
            result['enableNextDay'] = self.enable_next_day
        if self.enable_out_side_update_normal_check is not None:
            result['enableOutSideUpdateNormalCheck'] = self.enable_out_side_update_normal_check
        if self.enable_outside_apply is not None:
            result['enableOutsideApply'] = self.enable_outside_apply
        if self.enable_outside_camera_check is not None:
            result['enableOutsideCameraCheck'] = self.enable_outside_camera_check
        if self.enable_outside_check is not None:
            result['enableOutsideCheck'] = self.enable_outside_check
        if self.enable_outside_remark is not None:
            result['enableOutsideRemark'] = self.enable_outside_remark
        if self.enable_position_ble is not None:
            result['enablePositionBle'] = self.enable_position_ble
        if self.enable_trim_distance is not None:
            result['enableTrimDistance'] = self.enable_trim_distance
        if self.forbid_hide_out_side_address is not None:
            result['forbidHideOutSideAddress'] = self.forbid_hide_out_side_address
        if self.free_check_setting is not None:
            result['freeCheckSetting'] = self.free_check_setting.to_map()
        if self.free_check_type_id is not None:
            result['freeCheckTypeId'] = self.free_check_type_id
        if self.freecheck_day_start_min_offset is not None:
            result['freecheckDayStartMinOffset'] = self.freecheck_day_start_min_offset
        if self.freecheck_work_days is not None:
            result['freecheckWorkDays'] = self.freecheck_work_days
        if self.group_id is not None:
            result['groupId'] = self.group_id
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.manager_list is not None:
            result['managerList'] = self.manager_list
        result['members'] = []
        if self.members is not None:
            for k in self.members:
                result['members'].append(k.to_map() if k else None)
        if self.modify_member is not None:
            result['modifyMember'] = self.modify_member
        if self.offset is not None:
            result['offset'] = self.offset
        if self.open_face_check is not None:
            result['openFaceCheck'] = self.open_face_check
        if self.outside_check_approve_mode_id is not None:
            result['outsideCheckApproveModeId'] = self.outside_check_approve_mode_id
        if self.overtime_setting_id is not None:
            result['overtimeSettingId'] = self.overtime_setting_id
        if self.owner is not None:
            result['owner'] = self.owner
        result['positions'] = []
        if self.positions is not None:
            for k in self.positions:
                result['positions'].append(k.to_map() if k else None)
        result['resourcePermissionMap'] = []
        if self.resource_permission_map is not None:
            for k in self.resource_permission_map:
                result['resourcePermissionMap'].append(k.to_map() if k else None)
        result['shiftVOList'] = []
        if self.shift_volist is not None:
            for k in self.shift_volist:
                result['shiftVOList'].append(k.to_map() if k else None)
        if self.skip_holidays is not None:
            result['skipHolidays'] = self.skip_holidays
        if self.special_days is not None:
            result['specialDays'] = self.special_days
        if self.trim_distance is not None:
            result['trimDistance'] = self.trim_distance
        if self.type is not None:
            result['type'] = self.type
        result['wifis'] = []
        if self.wifis is not None:
            for k in self.wifis:
                result['wifis'].append(k.to_map() if k else None)
        if self.workday_class_list is not None:
            result['workdayClassList'] = self.workday_class_list
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('adjustmentSettingId') is not None:
            self.adjustment_setting_id = m.get('adjustmentSettingId')
        self.ble_device_list = []
        if m.get('bleDeviceList') is not None:
            for k in m.get('bleDeviceList'):
                temp_model = GroupAddRequestBleDeviceList()
                self.ble_device_list.append(temp_model.from_map(k))
        if m.get('checkNeedHealthyCode') is not None:
            self.check_need_healthy_code = m.get('checkNeedHealthyCode')
        if m.get('defaultClassId') is not None:
            self.default_class_id = m.get('defaultClassId')
        if m.get('disableCheckWhenRest') is not None:
            self.disable_check_when_rest = m.get('disableCheckWhenRest')
        if m.get('disableCheckWithoutSchedule') is not None:
            self.disable_check_without_schedule = m.get('disableCheckWithoutSchedule')
        if m.get('enableCameraCheck') is not None:
            self.enable_camera_check = m.get('enableCameraCheck')
        if m.get('enableEmpSelectClass') is not None:
            self.enable_emp_select_class = m.get('enableEmpSelectClass')
        if m.get('enableFaceCheck') is not None:
            self.enable_face_check = m.get('enableFaceCheck')
        if m.get('enableFaceStrictMode') is not None:
            self.enable_face_strict_mode = m.get('enableFaceStrictMode')
        if m.get('enableNextDay') is not None:
            self.enable_next_day = m.get('enableNextDay')
        if m.get('enableOutSideUpdateNormalCheck') is not None:
            self.enable_out_side_update_normal_check = m.get('enableOutSideUpdateNormalCheck')
        if m.get('enableOutsideApply') is not None:
            self.enable_outside_apply = m.get('enableOutsideApply')
        if m.get('enableOutsideCameraCheck') is not None:
            self.enable_outside_camera_check = m.get('enableOutsideCameraCheck')
        if m.get('enableOutsideCheck') is not None:
            self.enable_outside_check = m.get('enableOutsideCheck')
        if m.get('enableOutsideRemark') is not None:
            self.enable_outside_remark = m.get('enableOutsideRemark')
        if m.get('enablePositionBle') is not None:
            self.enable_position_ble = m.get('enablePositionBle')
        if m.get('enableTrimDistance') is not None:
            self.enable_trim_distance = m.get('enableTrimDistance')
        if m.get('forbidHideOutSideAddress') is not None:
            self.forbid_hide_out_side_address = m.get('forbidHideOutSideAddress')
        if m.get('freeCheckSetting') is not None:
            temp_model = GroupAddRequestFreeCheckSetting()
            self.free_check_setting = temp_model.from_map(m['freeCheckSetting'])
        if m.get('freeCheckTypeId') is not None:
            self.free_check_type_id = m.get('freeCheckTypeId')
        if m.get('freecheckDayStartMinOffset') is not None:
            self.freecheck_day_start_min_offset = m.get('freecheckDayStartMinOffset')
        if m.get('freecheckWorkDays') is not None:
            self.freecheck_work_days = m.get('freecheckWorkDays')
        if m.get('groupId') is not None:
            self.group_id = m.get('groupId')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('managerList') is not None:
            self.manager_list = m.get('managerList')
        self.members = []
        if m.get('members') is not None:
            for k in m.get('members'):
                temp_model = GroupAddRequestMembers()
                self.members.append(temp_model.from_map(k))
        if m.get('modifyMember') is not None:
            self.modify_member = m.get('modifyMember')
        if m.get('offset') is not None:
            self.offset = m.get('offset')
        if m.get('openFaceCheck') is not None:
            self.open_face_check = m.get('openFaceCheck')
        if m.get('outsideCheckApproveModeId') is not None:
            self.outside_check_approve_mode_id = m.get('outsideCheckApproveModeId')
        if m.get('overtimeSettingId') is not None:
            self.overtime_setting_id = m.get('overtimeSettingId')
        if m.get('owner') is not None:
            self.owner = m.get('owner')
        self.positions = []
        if m.get('positions') is not None:
            for k in m.get('positions'):
                temp_model = GroupAddRequestPositions()
                self.positions.append(temp_model.from_map(k))
        self.resource_permission_map = []
        if m.get('resourcePermissionMap') is not None:
            for k in m.get('resourcePermissionMap'):
                temp_model = GroupAddRequestResourcePermissionMap()
                self.resource_permission_map.append(temp_model.from_map(k))
        self.shift_volist = []
        if m.get('shiftVOList') is not None:
            for k in m.get('shiftVOList'):
                temp_model = GroupAddRequestShiftVOList()
                self.shift_volist.append(temp_model.from_map(k))
        if m.get('skipHolidays') is not None:
            self.skip_holidays = m.get('skipHolidays')
        if m.get('specialDays') is not None:
            self.special_days = m.get('specialDays')
        if m.get('trimDistance') is not None:
            self.trim_distance = m.get('trimDistance')
        if m.get('type') is not None:
            self.type = m.get('type')
        self.wifis = []
        if m.get('wifis') is not None:
            for k in m.get('wifis'):
                temp_model = GroupAddRequestWifis()
                self.wifis.append(temp_model.from_map(k))
        if m.get('workdayClassList') is not None:
            self.workday_class_list = m.get('workdayClassList')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class GroupAddResponseBodyResult(TeaModel):
    def __init__(
        self,
        group_id: int = None,
        group_name: str = None,
    ):
        # 考勤组id
        self.group_id = group_id
        # 考勤组名
        self.group_name = group_name

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupId') is not None:
            self.group_id = m.get('groupId')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        return self


class GroupAddResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GroupAddResponseBodyResult] = None,
    ):
        # Id of the request
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
                temp_model = GroupAddResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GroupAddResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GroupAddResponseBody = None,
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
            temp_model = GroupAddResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GroupUpdateHeaders(TeaModel):
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


class GroupUpdateRequestFreeCheckSettingFreeCheckGap(TeaModel):
    def __init__(
        self,
        off_on_check_gap_minutes: int = None,
        on_off_check_gap_minutes: int = None,
    ):
        # 下班打卡最小打卡间隔（单位分钟）。
        self.off_on_check_gap_minutes = off_on_check_gap_minutes
        # 上班打卡最小打卡间隔（单位分钟）。
        self.on_off_check_gap_minutes = on_off_check_gap_minutes

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.off_on_check_gap_minutes is not None:
            result['offOnCheckGapMinutes'] = self.off_on_check_gap_minutes
        if self.on_off_check_gap_minutes is not None:
            result['onOffCheckGapMinutes'] = self.on_off_check_gap_minutes
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('offOnCheckGapMinutes') is not None:
            self.off_on_check_gap_minutes = m.get('offOnCheckGapMinutes')
        if m.get('onOffCheckGapMinutes') is not None:
            self.on_off_check_gap_minutes = m.get('onOffCheckGapMinutes')
        return self


class GroupUpdateRequestFreeCheckSetting(TeaModel):
    def __init__(
        self,
        free_check_gap: GroupUpdateRequestFreeCheckSettingFreeCheckGap = None,
    ):
        # 休息日打卡间隔设置。
        self.free_check_gap = free_check_gap

    def validate(self):
        if self.free_check_gap:
            self.free_check_gap.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.free_check_gap is not None:
            result['freeCheckGap'] = self.free_check_gap.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('freeCheckGap') is not None:
            temp_model = GroupUpdateRequestFreeCheckSettingFreeCheckGap()
            self.free_check_gap = temp_model.from_map(m['freeCheckGap'])
        return self


class GroupUpdateRequestPositions(TeaModel):
    def __init__(
        self,
        address: str = None,
        latitude: str = None,
        longitude: str = None,
        offset: int = None,
        title: str = None,
    ):
        # 考勤地址。
        self.address = address
        # 纬度。
        self.latitude = latitude
        # 经度。
        self.longitude = longitude
        # 考勤范围。
        self.offset = offset
        # 考勤标题。
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.address is not None:
            result['address'] = self.address
        if self.latitude is not None:
            result['latitude'] = self.latitude
        if self.longitude is not None:
            result['longitude'] = self.longitude
        if self.offset is not None:
            result['offset'] = self.offset
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('address') is not None:
            self.address = m.get('address')
        if m.get('latitude') is not None:
            self.latitude = m.get('latitude')
        if m.get('longitude') is not None:
            self.longitude = m.get('longitude')
        if m.get('offset') is not None:
            self.offset = m.get('offset')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class GroupUpdateRequestResourcePermissionMap(TeaModel):
    def __init__(
        self,
        camera_check: str = None,
        check_position_type: str = None,
        check_time: str = None,
        group_member: str = None,
        group_type: str = None,
        out_side_check: str = None,
        over_time_rule: str = None,
        schedule: str = None,
    ):
        # 设置拍照打卡规则。
        self.camera_check = camera_check
        # 设置打卡方式。
        self.check_position_type = check_position_type
        # 设置考勤时间。
        self.check_time = check_time
        # 设置参与考勤人员。
        self.group_member = group_member
        # 设置考勤类型。
        self.group_type = group_type
        # 设置外勤打卡。
        self.out_side_check = out_side_check
        # 设置加班规则。
        self.over_time_rule = over_time_rule
        # 员工排班。
        self.schedule = schedule

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.camera_check is not None:
            result['cameraCheck'] = self.camera_check
        if self.check_position_type is not None:
            result['checkPositionType'] = self.check_position_type
        if self.check_time is not None:
            result['checkTime'] = self.check_time
        if self.group_member is not None:
            result['groupMember'] = self.group_member
        if self.group_type is not None:
            result['groupType'] = self.group_type
        if self.out_side_check is not None:
            result['outSideCheck'] = self.out_side_check
        if self.over_time_rule is not None:
            result['overTimeRule'] = self.over_time_rule
        if self.schedule is not None:
            result['schedule'] = self.schedule
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cameraCheck') is not None:
            self.camera_check = m.get('cameraCheck')
        if m.get('checkPositionType') is not None:
            self.check_position_type = m.get('checkPositionType')
        if m.get('checkTime') is not None:
            self.check_time = m.get('checkTime')
        if m.get('groupMember') is not None:
            self.group_member = m.get('groupMember')
        if m.get('groupType') is not None:
            self.group_type = m.get('groupType')
        if m.get('outSideCheck') is not None:
            self.out_side_check = m.get('outSideCheck')
        if m.get('overTimeRule') is not None:
            self.over_time_rule = m.get('overTimeRule')
        if m.get('schedule') is not None:
            self.schedule = m.get('schedule')
        return self


class GroupUpdateRequestShiftVOList(TeaModel):
    def __init__(
        self,
        shift_id: int = None,
    ):
        # 班次ID，可通过获取班次摘要信息接口获取。
        self.shift_id = shift_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.shift_id is not None:
            result['shiftId'] = self.shift_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('shiftId') is not None:
            self.shift_id = m.get('shiftId')
        return self


class GroupUpdateRequest(TeaModel):
    def __init__(
        self,
        adjustment_setting_id: int = None,
        disable_check_when_rest: bool = None,
        disable_check_without_schedule: bool = None,
        enable_camera_check: bool = None,
        enable_emp_select_class: bool = None,
        enable_face_check: bool = None,
        enable_face_strict_mode: bool = None,
        enable_out_side_update_normal_check: bool = None,
        enable_outside_apply: bool = None,
        enable_outside_check: bool = None,
        enable_outside_remark: bool = None,
        enable_trim_distance: bool = None,
        forbid_hide_out_side_address: bool = None,
        free_check_setting: GroupUpdateRequestFreeCheckSetting = None,
        free_check_type_id: int = None,
        group_id: int = None,
        group_name: str = None,
        manager_list: List[str] = None,
        offset: int = None,
        open_face_check: bool = None,
        outside_check_approve_mode_id: int = None,
        overtime_setting_id: int = None,
        owner: str = None,
        positions: List[GroupUpdateRequestPositions] = None,
        resource_permission_map: List[GroupUpdateRequestResourcePermissionMap] = None,
        shift_volist: List[GroupUpdateRequestShiftVOList] = None,
        skip_holidays: bool = None,
        trim_distance: int = None,
        workday_class_list: List[int] = None,
        op_user_id: str = None,
    ):
        # 补卡规则settingId。
        self.adjustment_setting_id = adjustment_setting_id
        # 休息日打卡是否需审批：true：需要false：不需要
        self.disable_check_when_rest = disable_check_when_rest
        # 未排班时是否禁止员工打卡。
        self.disable_check_without_schedule = disable_check_without_schedule
        # 是否开启拍照打卡。true：开启false：关闭（默认值）
        self.enable_camera_check = enable_camera_check
        # 未排班时是否允许员工选择班次打卡。
        self.enable_emp_select_class = enable_emp_select_class
        # 是否开启人脸检测。true：开启false：关闭（默认值）
        self.enable_face_check = enable_face_check
        # 是否开启真人验证。
        self.enable_face_strict_mode = enable_face_strict_mode
        # 是否允许外勤卡更新内勤卡。
        self.enable_out_side_update_normal_check = enable_out_side_update_normal_check
        # 外勤打卡是否需要审批。
        self.enable_outside_apply = enable_outside_apply
        # 是否可以外勤打卡。true：允许（默认值）false：不允许
        self.enable_outside_check = enable_outside_check
        # 外勤打卡是否需要拍照备注。
        self.enable_outside_remark = enable_outside_remark
        # 是否允许地点微调距离。
        self.enable_trim_distance = enable_trim_distance
        # 是否禁止员工隐藏详细地址。
        self.forbid_hide_out_side_address = forbid_hide_out_side_address
        # 休息日打卡规则。
        self.free_check_setting = free_check_setting
        # 休息日打卡方式。0严格打卡模式 1标准打卡模式
        self.free_check_type_id = free_check_type_id
        # 考勤组ID。
        self.group_id = group_id
        # 考勤组名。
        self.group_name = group_name
        # 考勤组子管理员userid列表。
        self.manager_list = manager_list
        # 考勤范围。
        self.offset = offset
        # 是否开启人脸打卡。
        self.open_face_check = open_face_check
        # 外勤打卡审批模式-1无需审批，0先审批后打卡是1先打卡后审批
        self.outside_check_approve_mode_id = outside_check_approve_mode_id
        # 加班规则settingId。
        self.overtime_setting_id = overtime_setting_id
        # 考勤组负责人。
        self.owner = owner
        # 考勤地点相关设置信息。
        self.positions = positions
        # 子管理员权限范围。w：可管理r：可读
        self.resource_permission_map = resource_permission_map
        # 班次相关配置信息。
        self.shift_volist = shift_volist
        # 是否跳过节假日。true：跳过（默认值）false：不跳过
        self.skip_holidays = skip_holidays
        # 地点微调范围（单位米）。
        self.trim_distance = trim_distance
        # 周班次列表。说明固定班制必填，0表示休息。数组内的值，从左到右依次代表周日到周六，每日的排班情况。
        self.workday_class_list = workday_class_list
        # 操作人的userid。
        self.op_user_id = op_user_id

    def validate(self):
        if self.free_check_setting:
            self.free_check_setting.validate()
        if self.positions:
            for k in self.positions:
                if k:
                    k.validate()
        if self.resource_permission_map:
            for k in self.resource_permission_map:
                if k:
                    k.validate()
        if self.shift_volist:
            for k in self.shift_volist:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.adjustment_setting_id is not None:
            result['adjustmentSettingId'] = self.adjustment_setting_id
        if self.disable_check_when_rest is not None:
            result['disableCheckWhenRest'] = self.disable_check_when_rest
        if self.disable_check_without_schedule is not None:
            result['disableCheckWithoutSchedule'] = self.disable_check_without_schedule
        if self.enable_camera_check is not None:
            result['enableCameraCheck'] = self.enable_camera_check
        if self.enable_emp_select_class is not None:
            result['enableEmpSelectClass'] = self.enable_emp_select_class
        if self.enable_face_check is not None:
            result['enableFaceCheck'] = self.enable_face_check
        if self.enable_face_strict_mode is not None:
            result['enableFaceStrictMode'] = self.enable_face_strict_mode
        if self.enable_out_side_update_normal_check is not None:
            result['enableOutSideUpdateNormalCheck'] = self.enable_out_side_update_normal_check
        if self.enable_outside_apply is not None:
            result['enableOutsideApply'] = self.enable_outside_apply
        if self.enable_outside_check is not None:
            result['enableOutsideCheck'] = self.enable_outside_check
        if self.enable_outside_remark is not None:
            result['enableOutsideRemark'] = self.enable_outside_remark
        if self.enable_trim_distance is not None:
            result['enableTrimDistance'] = self.enable_trim_distance
        if self.forbid_hide_out_side_address is not None:
            result['forbidHideOutSideAddress'] = self.forbid_hide_out_side_address
        if self.free_check_setting is not None:
            result['freeCheckSetting'] = self.free_check_setting.to_map()
        if self.free_check_type_id is not None:
            result['freeCheckTypeId'] = self.free_check_type_id
        if self.group_id is not None:
            result['groupId'] = self.group_id
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.manager_list is not None:
            result['managerList'] = self.manager_list
        if self.offset is not None:
            result['offset'] = self.offset
        if self.open_face_check is not None:
            result['openFaceCheck'] = self.open_face_check
        if self.outside_check_approve_mode_id is not None:
            result['outsideCheckApproveModeId'] = self.outside_check_approve_mode_id
        if self.overtime_setting_id is not None:
            result['overtimeSettingId'] = self.overtime_setting_id
        if self.owner is not None:
            result['owner'] = self.owner
        result['positions'] = []
        if self.positions is not None:
            for k in self.positions:
                result['positions'].append(k.to_map() if k else None)
        result['resourcePermissionMap'] = []
        if self.resource_permission_map is not None:
            for k in self.resource_permission_map:
                result['resourcePermissionMap'].append(k.to_map() if k else None)
        result['shiftVOList'] = []
        if self.shift_volist is not None:
            for k in self.shift_volist:
                result['shiftVOList'].append(k.to_map() if k else None)
        if self.skip_holidays is not None:
            result['skipHolidays'] = self.skip_holidays
        if self.trim_distance is not None:
            result['trimDistance'] = self.trim_distance
        if self.workday_class_list is not None:
            result['workdayClassList'] = self.workday_class_list
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('adjustmentSettingId') is not None:
            self.adjustment_setting_id = m.get('adjustmentSettingId')
        if m.get('disableCheckWhenRest') is not None:
            self.disable_check_when_rest = m.get('disableCheckWhenRest')
        if m.get('disableCheckWithoutSchedule') is not None:
            self.disable_check_without_schedule = m.get('disableCheckWithoutSchedule')
        if m.get('enableCameraCheck') is not None:
            self.enable_camera_check = m.get('enableCameraCheck')
        if m.get('enableEmpSelectClass') is not None:
            self.enable_emp_select_class = m.get('enableEmpSelectClass')
        if m.get('enableFaceCheck') is not None:
            self.enable_face_check = m.get('enableFaceCheck')
        if m.get('enableFaceStrictMode') is not None:
            self.enable_face_strict_mode = m.get('enableFaceStrictMode')
        if m.get('enableOutSideUpdateNormalCheck') is not None:
            self.enable_out_side_update_normal_check = m.get('enableOutSideUpdateNormalCheck')
        if m.get('enableOutsideApply') is not None:
            self.enable_outside_apply = m.get('enableOutsideApply')
        if m.get('enableOutsideCheck') is not None:
            self.enable_outside_check = m.get('enableOutsideCheck')
        if m.get('enableOutsideRemark') is not None:
            self.enable_outside_remark = m.get('enableOutsideRemark')
        if m.get('enableTrimDistance') is not None:
            self.enable_trim_distance = m.get('enableTrimDistance')
        if m.get('forbidHideOutSideAddress') is not None:
            self.forbid_hide_out_side_address = m.get('forbidHideOutSideAddress')
        if m.get('freeCheckSetting') is not None:
            temp_model = GroupUpdateRequestFreeCheckSetting()
            self.free_check_setting = temp_model.from_map(m['freeCheckSetting'])
        if m.get('freeCheckTypeId') is not None:
            self.free_check_type_id = m.get('freeCheckTypeId')
        if m.get('groupId') is not None:
            self.group_id = m.get('groupId')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('managerList') is not None:
            self.manager_list = m.get('managerList')
        if m.get('offset') is not None:
            self.offset = m.get('offset')
        if m.get('openFaceCheck') is not None:
            self.open_face_check = m.get('openFaceCheck')
        if m.get('outsideCheckApproveModeId') is not None:
            self.outside_check_approve_mode_id = m.get('outsideCheckApproveModeId')
        if m.get('overtimeSettingId') is not None:
            self.overtime_setting_id = m.get('overtimeSettingId')
        if m.get('owner') is not None:
            self.owner = m.get('owner')
        self.positions = []
        if m.get('positions') is not None:
            for k in m.get('positions'):
                temp_model = GroupUpdateRequestPositions()
                self.positions.append(temp_model.from_map(k))
        self.resource_permission_map = []
        if m.get('resourcePermissionMap') is not None:
            for k in m.get('resourcePermissionMap'):
                temp_model = GroupUpdateRequestResourcePermissionMap()
                self.resource_permission_map.append(temp_model.from_map(k))
        self.shift_volist = []
        if m.get('shiftVOList') is not None:
            for k in m.get('shiftVOList'):
                temp_model = GroupUpdateRequestShiftVOList()
                self.shift_volist.append(temp_model.from_map(k))
        if m.get('skipHolidays') is not None:
            self.skip_holidays = m.get('skipHolidays')
        if m.get('trimDistance') is not None:
            self.trim_distance = m.get('trimDistance')
        if m.get('workdayClassList') is not None:
            self.workday_class_list = m.get('workdayClassList')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class GroupUpdateResponseBodyResult(TeaModel):
    def __init__(
        self,
        group_id: int = None,
        group_name: str = None,
    ):
        # 考勤组id
        self.group_id = group_id
        # 考勤组名
        self.group_name = group_name

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupId') is not None:
            self.group_id = m.get('groupId')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        return self


class GroupUpdateResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GroupUpdateResponseBodyResult] = None,
    ):
        # Id of the request
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
                temp_model = GroupUpdateResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GroupUpdateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GroupUpdateResponseBody = None,
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
            temp_model = GroupUpdateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class InitAndGetLeaveALlocationQuotasHeaders(TeaModel):
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


class InitAndGetLeaveALlocationQuotasRequest(TeaModel):
    def __init__(
        self,
        leave_code: str = None,
        op_user_id: str = None,
        user_id: str = None,
    ):
        # 假期类型的标识。
        self.leave_code = leave_code
        # 操作者的userId。
        self.op_user_id = op_user_id
        # 用户id。
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.leave_code is not None:
            result['leaveCode'] = self.leave_code
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('leaveCode') is not None:
            self.leave_code = m.get('leaveCode')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class InitAndGetLeaveALlocationQuotasResponseBodyResult(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        leave_code: str = None,
        quota_cycle: str = None,
        quota_id: str = None,
        quota_num_per_day: int = None,
        quota_num_per_hour: int = None,
        start_time: int = None,
        used_num_per_day: int = None,
        used_num_per_hour: int = None,
        user_id: str = None,
    ):
        # 额度有效期结束时间。
        self.end_time = end_time
        # 假期类型标识。
        self.leave_code = leave_code
        # 年度。
        self.quota_cycle = quota_cycle
        # 余额标识。
        self.quota_id = quota_id
        # 以天计算额度总数。
        self.quota_num_per_day = quota_num_per_day
        # 以小时计算额度总数。
        self.quota_num_per_hour = quota_num_per_hour
        # 额度有效期开始时间。
        self.start_time = start_time
        # 用过的配额天数。
        self.used_num_per_day = used_num_per_day
        # 用过的配额小时数。
        self.used_num_per_hour = used_num_per_hour
        # 用户id。
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.leave_code is not None:
            result['leaveCode'] = self.leave_code
        if self.quota_cycle is not None:
            result['quotaCycle'] = self.quota_cycle
        if self.quota_id is not None:
            result['quotaId'] = self.quota_id
        if self.quota_num_per_day is not None:
            result['quotaNumPerDay'] = self.quota_num_per_day
        if self.quota_num_per_hour is not None:
            result['quotaNumPerHour'] = self.quota_num_per_hour
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.used_num_per_day is not None:
            result['usedNumPerDay'] = self.used_num_per_day
        if self.used_num_per_hour is not None:
            result['usedNumPerHour'] = self.used_num_per_hour
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('leaveCode') is not None:
            self.leave_code = m.get('leaveCode')
        if m.get('quotaCycle') is not None:
            self.quota_cycle = m.get('quotaCycle')
        if m.get('quotaId') is not None:
            self.quota_id = m.get('quotaId')
        if m.get('quotaNumPerDay') is not None:
            self.quota_num_per_day = m.get('quotaNumPerDay')
        if m.get('quotaNumPerHour') is not None:
            self.quota_num_per_hour = m.get('quotaNumPerHour')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('usedNumPerDay') is not None:
            self.used_num_per_day = m.get('usedNumPerDay')
        if m.get('usedNumPerHour') is not None:
            self.used_num_per_hour = m.get('usedNumPerHour')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class InitAndGetLeaveALlocationQuotasResponseBody(TeaModel):
    def __init__(
        self,
        result: List[InitAndGetLeaveALlocationQuotasResponseBodyResult] = None,
    ):
        # 返回结果。
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
                temp_model = InitAndGetLeaveALlocationQuotasResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class InitAndGetLeaveALlocationQuotasResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: InitAndGetLeaveALlocationQuotasResponseBody = None,
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
            temp_model = InitAndGetLeaveALlocationQuotasResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ModifyWaterMarkTemplateHeaders(TeaModel):
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


class ModifyWaterMarkTemplateRequest(TeaModel):
    def __init__(
        self,
        form_code: str = None,
        icon: str = None,
        layout_design_id: str = None,
        schema_content: str = None,
        title: str = None,
        water_mark_id: str = None,
        open_conversation_id: str = None,
        user_id: str = None,
    ):
        # 模板的表单Code。
        self.form_code = form_code
        # 模板的预览图片。
        self.icon = icon
        # 模板的布局ID。
        self.layout_design_id = layout_design_id
        # 模板的内容。
        self.schema_content = schema_content
        # 模板的标题。
        self.title = title
        # 模板的水印ID。
        self.water_mark_id = water_mark_id
        # 群会话ID。
        self.open_conversation_id = open_conversation_id
        # 用户的userid。
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.form_code is not None:
            result['formCode'] = self.form_code
        if self.icon is not None:
            result['icon'] = self.icon
        if self.layout_design_id is not None:
            result['layoutDesignId'] = self.layout_design_id
        if self.schema_content is not None:
            result['schemaContent'] = self.schema_content
        if self.title is not None:
            result['title'] = self.title
        if self.water_mark_id is not None:
            result['waterMarkId'] = self.water_mark_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('formCode') is not None:
            self.form_code = m.get('formCode')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('layoutDesignId') is not None:
            self.layout_design_id = m.get('layoutDesignId')
        if m.get('schemaContent') is not None:
            self.schema_content = m.get('schemaContent')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('waterMarkId') is not None:
            self.water_mark_id = m.get('waterMarkId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class ModifyWaterMarkTemplateResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
    ):
        # Id of the request
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


class ModifyWaterMarkTemplateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ModifyWaterMarkTemplateResponseBody = None,
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
            temp_model = ModifyWaterMarkTemplateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ProcessApproveCreateHeaders(TeaModel):
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


class ProcessApproveCreateRequestPunchParam(TeaModel):
    def __init__(
        self,
        position_id: str = None,
        position_name: str = None,
        position_type: str = None,
        punch_time: int = None,
    ):
        # 地理位置标识：wifi:ssid_macAddress ble: deviceId gps:longitude_latitude
        self.position_id = position_id
        # 地理位置名称
        self.position_name = position_name
        # 地理位置类型：wifi/ble/gps
        self.position_type = position_type
        # 审批单关联的打卡时间，单位毫秒
        self.punch_time = punch_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.position_id is not None:
            result['positionId'] = self.position_id
        if self.position_name is not None:
            result['positionName'] = self.position_name
        if self.position_type is not None:
            result['positionType'] = self.position_type
        if self.punch_time is not None:
            result['punchTime'] = self.punch_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('positionId') is not None:
            self.position_id = m.get('positionId')
        if m.get('positionName') is not None:
            self.position_name = m.get('positionName')
        if m.get('positionType') is not None:
            self.position_type = m.get('positionType')
        if m.get('punchTime') is not None:
            self.punch_time = m.get('punchTime')
        return self


class ProcessApproveCreateRequest(TeaModel):
    def __init__(
        self,
        approve_id: str = None,
        op_user_id: str = None,
        punch_param: ProcessApproveCreateRequestPunchParam = None,
        sub_type: str = None,
        tag_name: str = None,
        user_id: str = None,
    ):
        # 三方审批单id，全局唯一
        self.approve_id = approve_id
        # 审批人员工userId
        self.op_user_id = op_user_id
        # 审批单关联的打卡信息
        self.punch_param = punch_param
        # 审批单子类型名称：调店:shiftGroup
        self.sub_type = sub_type
        # 审批单类型名称
        self.tag_name = tag_name
        # 员工的userId
        self.user_id = user_id

    def validate(self):
        if self.punch_param:
            self.punch_param.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.approve_id is not None:
            result['approveId'] = self.approve_id
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.punch_param is not None:
            result['punchParam'] = self.punch_param.to_map()
        if self.sub_type is not None:
            result['subType'] = self.sub_type
        if self.tag_name is not None:
            result['tagName'] = self.tag_name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('approveId') is not None:
            self.approve_id = m.get('approveId')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('punchParam') is not None:
            temp_model = ProcessApproveCreateRequestPunchParam()
            self.punch_param = temp_model.from_map(m['punchParam'])
        if m.get('subType') is not None:
            self.sub_type = m.get('subType')
        if m.get('tagName') is not None:
            self.tag_name = m.get('tagName')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class ProcessApproveCreateResponseBodyResult(TeaModel):
    def __init__(
        self,
        dingtalk_approve_id: str = None,
    ):
        # 钉钉侧生成的审批单id
        self.dingtalk_approve_id = dingtalk_approve_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dingtalk_approve_id is not None:
            result['dingtalkApproveId'] = self.dingtalk_approve_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingtalkApproveId') is not None:
            self.dingtalk_approve_id = m.get('dingtalkApproveId')
        return self


class ProcessApproveCreateResponseBody(TeaModel):
    def __init__(
        self,
        result: ProcessApproveCreateResponseBodyResult = None,
    ):
        # 审批单返回对象
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
            temp_model = ProcessApproveCreateResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class ProcessApproveCreateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ProcessApproveCreateResponseBody = None,
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
            temp_model = ProcessApproveCreateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SaveCustomWaterMarkTemplateHeaders(TeaModel):
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


class SaveCustomWaterMarkTemplateRequest(TeaModel):
    def __init__(
        self,
        biz_code: str = None,
        icon: str = None,
        layout_design_id: str = None,
        scene_code: str = None,
        schema_content: str = None,
        title: str = None,
        open_conversation_id: str = None,
        user_id: str = None,
    ):
        # 模板的业务码：
        # - water_mark_checkin
        # 
        # 
        self.biz_code = biz_code
        # 模板的预览图片。
        self.icon = icon
        # 模板的布局ID。
        self.layout_design_id = layout_design_id
        # 模板的场景码：
        # - water_mark_checkin_h3yun 开放场景码
        # 
        # 
        self.scene_code = scene_code
        # 模板的内容。
        self.schema_content = schema_content
        # 模板的标题。
        self.title = title
        # 群会话ID。
        self.open_conversation_id = open_conversation_id
        # 用户的userid。
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_code is not None:
            result['bizCode'] = self.biz_code
        if self.icon is not None:
            result['icon'] = self.icon
        if self.layout_design_id is not None:
            result['layoutDesignId'] = self.layout_design_id
        if self.scene_code is not None:
            result['sceneCode'] = self.scene_code
        if self.schema_content is not None:
            result['schemaContent'] = self.schema_content
        if self.title is not None:
            result['title'] = self.title
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizCode') is not None:
            self.biz_code = m.get('bizCode')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('layoutDesignId') is not None:
            self.layout_design_id = m.get('layoutDesignId')
        if m.get('sceneCode') is not None:
            self.scene_code = m.get('sceneCode')
        if m.get('schemaContent') is not None:
            self.schema_content = m.get('schemaContent')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class SaveCustomWaterMarkTemplateResponseBodyResult(TeaModel):
    def __init__(
        self,
        form_code: str = None,
        water_mark_id: str = None,
    ):
        # 模板的表单Code。
        self.form_code = form_code
        # 模板的水印ID。
        self.water_mark_id = water_mark_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.form_code is not None:
            result['formCode'] = self.form_code
        if self.water_mark_id is not None:
            result['waterMarkId'] = self.water_mark_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('formCode') is not None:
            self.form_code = m.get('formCode')
        if m.get('waterMarkId') is not None:
            self.water_mark_id = m.get('waterMarkId')
        return self


class SaveCustomWaterMarkTemplateResponseBody(TeaModel):
    def __init__(
        self,
        result: SaveCustomWaterMarkTemplateResponseBodyResult = None,
    ):
        # 返回对象。
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
            temp_model = SaveCustomWaterMarkTemplateResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class SaveCustomWaterMarkTemplateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SaveCustomWaterMarkTemplateResponseBody = None,
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
            temp_model = SaveCustomWaterMarkTemplateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SyncScheduleInfoHeaders(TeaModel):
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


class SyncScheduleInfoRequestScheduleInfos(TeaModel):
    def __init__(
        self,
        plan_id: int = None,
        position_keys: List[str] = None,
        retain_attendance_check: bool = None,
        wifi_keys: List[str] = None,
    ):
        self.plan_id = plan_id
        self.position_keys = position_keys
        self.retain_attendance_check = retain_attendance_check
        self.wifi_keys = wifi_keys

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.plan_id is not None:
            result['planId'] = self.plan_id
        if self.position_keys is not None:
            result['positionKeys'] = self.position_keys
        if self.retain_attendance_check is not None:
            result['retainAttendanceCheck'] = self.retain_attendance_check
        if self.wifi_keys is not None:
            result['wifiKeys'] = self.wifi_keys
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('planId') is not None:
            self.plan_id = m.get('planId')
        if m.get('positionKeys') is not None:
            self.position_keys = m.get('positionKeys')
        if m.get('retainAttendanceCheck') is not None:
            self.retain_attendance_check = m.get('retainAttendanceCheck')
        if m.get('wifiKeys') is not None:
            self.wifi_keys = m.get('wifiKeys')
        return self


class SyncScheduleInfoRequest(TeaModel):
    def __init__(
        self,
        op_user_id: str = None,
        schedule_infos: List[SyncScheduleInfoRequestScheduleInfos] = None,
    ):
        self.op_user_id = op_user_id
        self.schedule_infos = schedule_infos

    def validate(self):
        if self.schedule_infos:
            for k in self.schedule_infos:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        result['scheduleInfos'] = []
        if self.schedule_infos is not None:
            for k in self.schedule_infos:
                result['scheduleInfos'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        self.schedule_infos = []
        if m.get('scheduleInfos') is not None:
            for k in m.get('scheduleInfos'):
                temp_model = SyncScheduleInfoRequestScheduleInfos()
                self.schedule_infos.append(temp_model.from_map(k))
        return self


class SyncScheduleInfoResponse(TeaModel):
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


class UpdateLeaveTypeHeaders(TeaModel):
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


class UpdateLeaveTypeRequestLeaveCertificate(TeaModel):
    def __init__(
        self,
        duration: float = None,
        enable: bool = None,
        prompt_information: str = None,
        unit: str = None,
    ):
        # 超过多长时间需提供请假证明
        self.duration = duration
        # 是否开启请假证明
        self.enable = enable
        # 请假提示文案
        self.prompt_information = prompt_information
        # 请假证明单位hour，day
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.duration is not None:
            result['duration'] = self.duration
        if self.enable is not None:
            result['enable'] = self.enable
        if self.prompt_information is not None:
            result['promptInformation'] = self.prompt_information
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('enable') is not None:
            self.enable = m.get('enable')
        if m.get('promptInformation') is not None:
            self.prompt_information = m.get('promptInformation')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class UpdateLeaveTypeRequestSubmitTimeRule(TeaModel):
    def __init__(
        self,
        enable_time_limit: bool = None,
        time_type: str = None,
        time_unit: str = None,
        time_value: int = None,
    ):
        # 是否开启限时提交功能：仅且为true时开启
        self.enable_time_limit = enable_time_limit
        # 限制类型：before-提前；after-补交
        self.time_type = time_type
        # 时间单位：day-天；hour-小时
        self.time_unit = time_unit
        # 限制值：timeUnit=day时，有效值范围[0~30] 天；timeUnit=hour时，有效值范围[0~24] 小时
        self.time_value = time_value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.enable_time_limit is not None:
            result['enableTimeLimit'] = self.enable_time_limit
        if self.time_type is not None:
            result['timeType'] = self.time_type
        if self.time_unit is not None:
            result['timeUnit'] = self.time_unit
        if self.time_value is not None:
            result['timeValue'] = self.time_value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('enableTimeLimit') is not None:
            self.enable_time_limit = m.get('enableTimeLimit')
        if m.get('timeType') is not None:
            self.time_type = m.get('timeType')
        if m.get('timeUnit') is not None:
            self.time_unit = m.get('timeUnit')
        if m.get('timeValue') is not None:
            self.time_value = m.get('timeValue')
        return self


class UpdateLeaveTypeRequestVisibilityRules(TeaModel):
    def __init__(
        self,
        type: str = None,
        visible: List[str] = None,
    ):
        # 规则类型：dept-部门；staff-员工；label-角色
        self.type = type
        # 规则数据：当type=staff时，传员工userId列表；当type=dept时，传部门id列表；当type=label时，传角色id列表
        self.visible = visible

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.visible is not None:
            result['visible'] = self.visible
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('visible') is not None:
            self.visible = m.get('visible')
        return self


class UpdateLeaveTypeRequest(TeaModel):
    def __init__(
        self,
        biz_type: str = None,
        extras: str = None,
        hours_in_per_day: int = None,
        leave_certificate: UpdateLeaveTypeRequestLeaveCertificate = None,
        leave_code: str = None,
        leave_name: str = None,
        leave_view_unit: str = None,
        natural_day_leave: bool = None,
        submit_time_rule: UpdateLeaveTypeRequestSubmitTimeRule = None,
        visibility_rules: List[UpdateLeaveTypeRequestVisibilityRules] = None,
        op_user_id: str = None,
    ):
        # 假期类型，普通假期或者加班转调休假期。(general_leave、lieu_leave其中一种)
        self.biz_type = biz_type
        # 调休假有效期规则(validity_type:有效类型 absolute_time(绝对时间)、relative_time(相对时间)其中一种 validity_value:延长日期(当validity_type为absolute_time该值该值不为空且满足yy-mm格式 validity_type为relative_time该值为大于1的整数))
        self.extras = extras
        # 每天折算的工作时长(百分之一 例如1天=10小时=1000)
        self.hours_in_per_day = hours_in_per_day
        # 请假证明
        self.leave_certificate = leave_certificate
        # 假期类型唯一标识
        self.leave_code = leave_code
        # 假期名称
        self.leave_name = leave_name
        # 请假单位，可以按照天半天或者小时请假。(day、halfDay、hour其中一种)
        self.leave_view_unit = leave_view_unit
        # 是否按照自然日统计请假时长，当为false的时候，用户发起请假时候会根据用户在请假时间段内的排班情况来计算请假时长。
        self.natural_day_leave = natural_day_leave
        # 限时提交规则
        self.submit_time_rule = submit_time_rule
        # 适用范围规则列表：哪些部门/员工可以使用该假期类型，不传默认为全公司
        self.visibility_rules = visibility_rules
        # 操作者ID
        self.op_user_id = op_user_id

    def validate(self):
        if self.leave_certificate:
            self.leave_certificate.validate()
        if self.submit_time_rule:
            self.submit_time_rule.validate()
        if self.visibility_rules:
            for k in self.visibility_rules:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.extras is not None:
            result['extras'] = self.extras
        if self.hours_in_per_day is not None:
            result['hoursInPerDay'] = self.hours_in_per_day
        if self.leave_certificate is not None:
            result['leaveCertificate'] = self.leave_certificate.to_map()
        if self.leave_code is not None:
            result['leaveCode'] = self.leave_code
        if self.leave_name is not None:
            result['leaveName'] = self.leave_name
        if self.leave_view_unit is not None:
            result['leaveViewUnit'] = self.leave_view_unit
        if self.natural_day_leave is not None:
            result['naturalDayLeave'] = self.natural_day_leave
        if self.submit_time_rule is not None:
            result['submitTimeRule'] = self.submit_time_rule.to_map()
        result['visibilityRules'] = []
        if self.visibility_rules is not None:
            for k in self.visibility_rules:
                result['visibilityRules'].append(k.to_map() if k else None)
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('extras') is not None:
            self.extras = m.get('extras')
        if m.get('hoursInPerDay') is not None:
            self.hours_in_per_day = m.get('hoursInPerDay')
        if m.get('leaveCertificate') is not None:
            temp_model = UpdateLeaveTypeRequestLeaveCertificate()
            self.leave_certificate = temp_model.from_map(m['leaveCertificate'])
        if m.get('leaveCode') is not None:
            self.leave_code = m.get('leaveCode')
        if m.get('leaveName') is not None:
            self.leave_name = m.get('leaveName')
        if m.get('leaveViewUnit') is not None:
            self.leave_view_unit = m.get('leaveViewUnit')
        if m.get('naturalDayLeave') is not None:
            self.natural_day_leave = m.get('naturalDayLeave')
        if m.get('submitTimeRule') is not None:
            temp_model = UpdateLeaveTypeRequestSubmitTimeRule()
            self.submit_time_rule = temp_model.from_map(m['submitTimeRule'])
        self.visibility_rules = []
        if m.get('visibilityRules') is not None:
            for k in m.get('visibilityRules'):
                temp_model = UpdateLeaveTypeRequestVisibilityRules()
                self.visibility_rules.append(temp_model.from_map(k))
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class UpdateLeaveTypeResponseBodyResultLeaveCertificate(TeaModel):
    def __init__(
        self,
        duration: float = None,
        enable: bool = None,
        prompt_information: str = None,
        unit: str = None,
    ):
        # 超过多长时间需提供请假证明
        self.duration = duration
        # 是否开启请假证明
        self.enable = enable
        # 请假提示文案
        self.prompt_information = prompt_information
        # 请假证明单位hour，day
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.duration is not None:
            result['duration'] = self.duration
        if self.enable is not None:
            result['enable'] = self.enable
        if self.prompt_information is not None:
            result['promptInformation'] = self.prompt_information
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('enable') is not None:
            self.enable = m.get('enable')
        if m.get('promptInformation') is not None:
            self.prompt_information = m.get('promptInformation')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class UpdateLeaveTypeResponseBodyResultSubmitTimeRule(TeaModel):
    def __init__(
        self,
        enable_time_limit: bool = None,
        time_type: str = None,
        time_unit: str = None,
        time_value: int = None,
    ):
        # 是否开启限时提交功能：仅且为true时开启
        self.enable_time_limit = enable_time_limit
        # 限制类型：before-提前；after-补交
        self.time_type = time_type
        # 时间单位：day-天；hour-小时
        self.time_unit = time_unit
        # 限制值：timeUnit=day时，有效值范围[0~30] 天；timeUnit=hour时，有效值范围[0~24] 小时
        self.time_value = time_value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.enable_time_limit is not None:
            result['enableTimeLimit'] = self.enable_time_limit
        if self.time_type is not None:
            result['timeType'] = self.time_type
        if self.time_unit is not None:
            result['timeUnit'] = self.time_unit
        if self.time_value is not None:
            result['timeValue'] = self.time_value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('enableTimeLimit') is not None:
            self.enable_time_limit = m.get('enableTimeLimit')
        if m.get('timeType') is not None:
            self.time_type = m.get('timeType')
        if m.get('timeUnit') is not None:
            self.time_unit = m.get('timeUnit')
        if m.get('timeValue') is not None:
            self.time_value = m.get('timeValue')
        return self


class UpdateLeaveTypeResponseBodyResultVisibilityRules(TeaModel):
    def __init__(
        self,
        type: str = None,
        visible: List[str] = None,
    ):
        # 规则类型：dept-部门；staff-员工；label-角色
        self.type = type
        # 规则数据：当type=staff时，传员工userId列表；当type=dept时，传部门id列表；当type=label时，传角色id列表
        self.visible = visible

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.visible is not None:
            result['visible'] = self.visible
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('visible') is not None:
            self.visible = m.get('visible')
        return self


class UpdateLeaveTypeResponseBodyResult(TeaModel):
    def __init__(
        self,
        biz_type: str = None,
        hours_in_per_day: int = None,
        leave_certificate: UpdateLeaveTypeResponseBodyResultLeaveCertificate = None,
        leave_code: str = None,
        leave_name: str = None,
        leave_view_unit: str = None,
        natural_day_leave: bool = None,
        submit_time_rule: UpdateLeaveTypeResponseBodyResultSubmitTimeRule = None,
        visibility_rules: List[UpdateLeaveTypeResponseBodyResultVisibilityRules] = None,
    ):
        # 假期类型，普通假期或者加班转调休假期。(general_leave、lieu_leave其中一种)
        self.biz_type = biz_type
        # 每天折算的工作时长(百分之一 例如1天=10小时=1000)
        self.hours_in_per_day = hours_in_per_day
        # 请假证明
        self.leave_certificate = leave_certificate
        # 假期类型唯一标识
        self.leave_code = leave_code
        # 假期名称
        self.leave_name = leave_name
        # 请假单位，可以按照天半天或者小时请假。(day、halfDay、hour其中一种)
        self.leave_view_unit = leave_view_unit
        # 是否按照自然日统计请假时长，当为false的时候，用户发起请假时候会根据用户在请假时间段内的排班情况来计算请假时长。
        self.natural_day_leave = natural_day_leave
        # 限时提交规则
        self.submit_time_rule = submit_time_rule
        # 适用范围规则列表：哪些部门/员工可以使用该假期类型，不传默认为全公司
        self.visibility_rules = visibility_rules

    def validate(self):
        if self.leave_certificate:
            self.leave_certificate.validate()
        if self.submit_time_rule:
            self.submit_time_rule.validate()
        if self.visibility_rules:
            for k in self.visibility_rules:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.hours_in_per_day is not None:
            result['hoursInPerDay'] = self.hours_in_per_day
        if self.leave_certificate is not None:
            result['leaveCertificate'] = self.leave_certificate.to_map()
        if self.leave_code is not None:
            result['leaveCode'] = self.leave_code
        if self.leave_name is not None:
            result['leaveName'] = self.leave_name
        if self.leave_view_unit is not None:
            result['leaveViewUnit'] = self.leave_view_unit
        if self.natural_day_leave is not None:
            result['naturalDayLeave'] = self.natural_day_leave
        if self.submit_time_rule is not None:
            result['submitTimeRule'] = self.submit_time_rule.to_map()
        result['visibilityRules'] = []
        if self.visibility_rules is not None:
            for k in self.visibility_rules:
                result['visibilityRules'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('hoursInPerDay') is not None:
            self.hours_in_per_day = m.get('hoursInPerDay')
        if m.get('leaveCertificate') is not None:
            temp_model = UpdateLeaveTypeResponseBodyResultLeaveCertificate()
            self.leave_certificate = temp_model.from_map(m['leaveCertificate'])
        if m.get('leaveCode') is not None:
            self.leave_code = m.get('leaveCode')
        if m.get('leaveName') is not None:
            self.leave_name = m.get('leaveName')
        if m.get('leaveViewUnit') is not None:
            self.leave_view_unit = m.get('leaveViewUnit')
        if m.get('naturalDayLeave') is not None:
            self.natural_day_leave = m.get('naturalDayLeave')
        if m.get('submitTimeRule') is not None:
            temp_model = UpdateLeaveTypeResponseBodyResultSubmitTimeRule()
            self.submit_time_rule = temp_model.from_map(m['submitTimeRule'])
        self.visibility_rules = []
        if m.get('visibilityRules') is not None:
            for k in m.get('visibilityRules'):
                temp_model = UpdateLeaveTypeResponseBodyResultVisibilityRules()
                self.visibility_rules.append(temp_model.from_map(k))
        return self


class UpdateLeaveTypeResponseBody(TeaModel):
    def __init__(
        self,
        result: UpdateLeaveTypeResponseBodyResult = None,
    ):
        # 返回参数
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
            temp_model = UpdateLeaveTypeResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class UpdateLeaveTypeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateLeaveTypeResponseBody = None,
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
            temp_model = UpdateLeaveTypeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


