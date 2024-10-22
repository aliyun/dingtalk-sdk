# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, Any, List


class ResultDurationSettingsValueSkipTimeByFrames(TeaModel):
    def __init__(
        self,
        start_time: str = None,
        end_time: str = None,
        valid: bool = None,
    ):
        self.start_time = start_time
        self.end_time = end_time
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
        self.duration = duration
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
        self.overtime_redress = overtime_redress
        self.settings = settings
        self.overtime_redress_by = overtime_redress_by
        self.vacation_rate = vacation_rate
        self.skip_time = skip_time
        self.skip_time_by_frames = skip_time_by_frames
        self.skip_time_by_durations = skip_time_by_durations
        self.holiday_plan_overtime_redress = holiday_plan_overtime_redress
        self.holiday_plan_overtime_redress_by = holiday_plan_overtime_redress_by
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
        self.duration = duration
        self.enable = enable
        self.prompt_information = prompt_information
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
        self.enable_time_limit = enable_time_limit
        self.time_type = time_type
        self.time_unit = time_unit
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
        self.type = type
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
        freedom_leave: bool = None,
        hours_in_per_day: int = None,
        leave_certificate: AddLeaveTypeRequestLeaveCertificate = None,
        leave_hour_ceil: str = None,
        leave_name: str = None,
        leave_time_ceil: bool = None,
        leave_time_ceil_min_unit: str = None,
        leave_view_unit: str = None,
        max_leave_time: int = None,
        min_leave_hour: float = None,
        natural_day_leave: bool = None,
        paid_leave: bool = None,
        submit_time_rule: AddLeaveTypeRequestSubmitTimeRule = None,
        visibility_rules: List[AddLeaveTypeRequestVisibilityRules] = None,
        when_can_leave: str = None,
        op_user_id: str = None,
    ):
        # This parameter is required.
        self.biz_type = biz_type
        self.extras = extras
        self.freedom_leave = freedom_leave
        # This parameter is required.
        self.hours_in_per_day = hours_in_per_day
        self.leave_certificate = leave_certificate
        self.leave_hour_ceil = leave_hour_ceil
        # This parameter is required.
        self.leave_name = leave_name
        self.leave_time_ceil = leave_time_ceil
        self.leave_time_ceil_min_unit = leave_time_ceil_min_unit
        # This parameter is required.
        self.leave_view_unit = leave_view_unit
        self.max_leave_time = max_leave_time
        self.min_leave_hour = min_leave_hour
        # This parameter is required.
        self.natural_day_leave = natural_day_leave
        self.paid_leave = paid_leave
        self.submit_time_rule = submit_time_rule
        self.visibility_rules = visibility_rules
        self.when_can_leave = when_can_leave
        # This parameter is required.
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
        if self.freedom_leave is not None:
            result['freedomLeave'] = self.freedom_leave
        if self.hours_in_per_day is not None:
            result['hoursInPerDay'] = self.hours_in_per_day
        if self.leave_certificate is not None:
            result['leaveCertificate'] = self.leave_certificate.to_map()
        if self.leave_hour_ceil is not None:
            result['leaveHourCeil'] = self.leave_hour_ceil
        if self.leave_name is not None:
            result['leaveName'] = self.leave_name
        if self.leave_time_ceil is not None:
            result['leaveTimeCeil'] = self.leave_time_ceil
        if self.leave_time_ceil_min_unit is not None:
            result['leaveTimeCeilMinUnit'] = self.leave_time_ceil_min_unit
        if self.leave_view_unit is not None:
            result['leaveViewUnit'] = self.leave_view_unit
        if self.max_leave_time is not None:
            result['maxLeaveTime'] = self.max_leave_time
        if self.min_leave_hour is not None:
            result['minLeaveHour'] = self.min_leave_hour
        if self.natural_day_leave is not None:
            result['naturalDayLeave'] = self.natural_day_leave
        if self.paid_leave is not None:
            result['paidLeave'] = self.paid_leave
        if self.submit_time_rule is not None:
            result['submitTimeRule'] = self.submit_time_rule.to_map()
        result['visibilityRules'] = []
        if self.visibility_rules is not None:
            for k in self.visibility_rules:
                result['visibilityRules'].append(k.to_map() if k else None)
        if self.when_can_leave is not None:
            result['whenCanLeave'] = self.when_can_leave
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('extras') is not None:
            self.extras = m.get('extras')
        if m.get('freedomLeave') is not None:
            self.freedom_leave = m.get('freedomLeave')
        if m.get('hoursInPerDay') is not None:
            self.hours_in_per_day = m.get('hoursInPerDay')
        if m.get('leaveCertificate') is not None:
            temp_model = AddLeaveTypeRequestLeaveCertificate()
            self.leave_certificate = temp_model.from_map(m['leaveCertificate'])
        if m.get('leaveHourCeil') is not None:
            self.leave_hour_ceil = m.get('leaveHourCeil')
        if m.get('leaveName') is not None:
            self.leave_name = m.get('leaveName')
        if m.get('leaveTimeCeil') is not None:
            self.leave_time_ceil = m.get('leaveTimeCeil')
        if m.get('leaveTimeCeilMinUnit') is not None:
            self.leave_time_ceil_min_unit = m.get('leaveTimeCeilMinUnit')
        if m.get('leaveViewUnit') is not None:
            self.leave_view_unit = m.get('leaveViewUnit')
        if m.get('maxLeaveTime') is not None:
            self.max_leave_time = m.get('maxLeaveTime')
        if m.get('minLeaveHour') is not None:
            self.min_leave_hour = m.get('minLeaveHour')
        if m.get('naturalDayLeave') is not None:
            self.natural_day_leave = m.get('naturalDayLeave')
        if m.get('paidLeave') is not None:
            self.paid_leave = m.get('paidLeave')
        if m.get('submitTimeRule') is not None:
            temp_model = AddLeaveTypeRequestSubmitTimeRule()
            self.submit_time_rule = temp_model.from_map(m['submitTimeRule'])
        self.visibility_rules = []
        if m.get('visibilityRules') is not None:
            for k in m.get('visibilityRules'):
                temp_model = AddLeaveTypeRequestVisibilityRules()
                self.visibility_rules.append(temp_model.from_map(k))
        if m.get('whenCanLeave') is not None:
            self.when_can_leave = m.get('whenCanLeave')
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
        self.duration = duration
        self.enable = enable
        self.prompt_information = prompt_information
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
        self.enable_time_limit = enable_time_limit
        self.time_type = time_type
        self.time_unit = time_unit
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
        self.type = type
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
        self.biz_type = biz_type
        self.hours_in_per_day = hours_in_per_day
        self.leave_certificate = leave_certificate
        self.leave_code = leave_code
        self.leave_name = leave_name
        self.leave_view_unit = leave_view_unit
        self.natural_day_leave = natural_day_leave
        self.submit_time_rule = submit_time_rule
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
        # This parameter is required.
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
        status_code: int = None,
        body: AddLeaveTypeResponseBody = None,
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
        # This parameter is required.
        self.device_id_list = device_id_list
        # This parameter is required.
        self.group_key = group_key
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
        self.device_id = device_id
        self.device_name = device_name
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
        self.code = code
        self.failure_list = failure_list
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
        self.device_id = device_id
        self.device_name = device_name
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
        self.error_list = error_list
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
        status_code: int = None,
        body: AttendanceBleDevicesAddResponseBody = None,
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
        # This parameter is required.
        self.group_key = group_key
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
        self.device_id = device_id
        self.device_name = device_name
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
        status_code: int = None,
        body: AttendanceBleDevicesQueryResponseBody = None,
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
        # This parameter is required.
        self.device_id_list = device_id_list
        # This parameter is required.
        self.group_key = group_key
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
        self.code = code
        self.failure_list = failure_list
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
        self.error_list = error_list
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
        status_code: int = None,
        body: AttendanceBleDevicesRemoveResponseBody = None,
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
            temp_model = AttendanceBleDevicesRemoveResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BatchBossCheckHeaders(TeaModel):
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


class BatchBossCheckRequestModels(TeaModel):
    def __init__(
        self,
        absent_min: int = None,
        plan_id: int = None,
        remark: str = None,
        time_result: str = None,
    ):
        self.absent_min = absent_min
        # This parameter is required.
        self.plan_id = plan_id
        self.remark = remark
        # This parameter is required.
        self.time_result = time_result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.absent_min is not None:
            result['absentMin'] = self.absent_min
        if self.plan_id is not None:
            result['planId'] = self.plan_id
        if self.remark is not None:
            result['remark'] = self.remark
        if self.time_result is not None:
            result['timeResult'] = self.time_result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('absentMin') is not None:
            self.absent_min = m.get('absentMin')
        if m.get('planId') is not None:
            self.plan_id = m.get('planId')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('timeResult') is not None:
            self.time_result = m.get('timeResult')
        return self


class BatchBossCheckRequest(TeaModel):
    def __init__(
        self,
        models: List[BatchBossCheckRequestModels] = None,
        op_user_id: str = None,
    ):
        self.models = models
        # This parameter is required.
        self.op_user_id = op_user_id

    def validate(self):
        if self.models:
            for k in self.models:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['models'] = []
        if self.models is not None:
            for k in self.models:
                result['models'].append(k.to_map() if k else None)
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.models = []
        if m.get('models') is not None:
            for k in m.get('models'):
                temp_model = BatchBossCheckRequestModels()
                self.models.append(temp_model.from_map(k))
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class BatchBossCheckResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        # This parameter is required.
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


class BatchBossCheckResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BatchBossCheckResponseBody = None,
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
            temp_model = BatchBossCheckResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CalculateDurationHeaders(TeaModel):
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


class CalculateDurationRequest(TeaModel):
    def __init__(
        self,
        biz_type: int = None,
        calculate_model: int = None,
        duration_unit: str = None,
        from_time: str = None,
        leave_code: str = None,
        to_time: str = None,
        user_id: str = None,
    ):
        self.biz_type = biz_type
        self.calculate_model = calculate_model
        self.duration_unit = duration_unit
        self.from_time = from_time
        self.leave_code = leave_code
        self.to_time = to_time
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.calculate_model is not None:
            result['calculateModel'] = self.calculate_model
        if self.duration_unit is not None:
            result['durationUnit'] = self.duration_unit
        if self.from_time is not None:
            result['fromTime'] = self.from_time
        if self.leave_code is not None:
            result['leaveCode'] = self.leave_code
        if self.to_time is not None:
            result['toTime'] = self.to_time
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('calculateModel') is not None:
            self.calculate_model = m.get('calculateModel')
        if m.get('durationUnit') is not None:
            self.duration_unit = m.get('durationUnit')
        if m.get('fromTime') is not None:
            self.from_time = m.get('fromTime')
        if m.get('leaveCode') is not None:
            self.leave_code = m.get('leaveCode')
        if m.get('toTime') is not None:
            self.to_time = m.get('toTime')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CalculateDurationResponseBodyResultDurationDetail(TeaModel):
    def __init__(
        self,
        date: str = None,
        duration: float = None,
    ):
        self.date = date
        self.duration = duration

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.duration is not None:
            result['duration'] = self.duration
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        return self


class CalculateDurationResponseBodyResult(TeaModel):
    def __init__(
        self,
        duration: float = None,
        duration_detail: List[CalculateDurationResponseBodyResultDurationDetail] = None,
    ):
        self.duration = duration
        self.duration_detail = duration_detail

    def validate(self):
        if self.duration_detail:
            for k in self.duration_detail:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.duration is not None:
            result['duration'] = self.duration
        result['durationDetail'] = []
        if self.duration_detail is not None:
            for k in self.duration_detail:
                result['durationDetail'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        self.duration_detail = []
        if m.get('durationDetail') is not None:
            for k in m.get('durationDetail'):
                temp_model = CalculateDurationResponseBodyResultDurationDetail()
                self.duration_detail.append(temp_model.from_map(k))
        return self


class CalculateDurationResponseBody(TeaModel):
    def __init__(
        self,
        result: CalculateDurationResponseBodyResult = None,
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
            temp_model = CalculateDurationResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class CalculateDurationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CalculateDurationResponseBody = None,
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
            temp_model = CalculateDurationResponseBody()
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
        # This parameter is required.
        self.end_time = end_time
        # This parameter is required.
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
        # This parameter is required.
        self.biz_code = biz_code
        # This parameter is required.
        self.user_ids = user_ids
        # This parameter is required.
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
        # This parameter is required.
        self.code = code
        # This parameter is required.
        self.mesage = mesage
        # This parameter is required.
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
        status_code: int = None,
        body: CheckClosingAccountResponseBody = None,
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
        # This parameter is required.
        self.category = category
        # This parameter is required.
        self.entity_ids = entity_ids
        # This parameter is required.
        self.op_user_id = op_user_id
        # This parameter is required.
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
        # This parameter is required.
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
        status_code: int = None,
        body: CheckWritePermissionResponseBody = None,
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
        self.position_id = position_id
        self.position_name = position_name
        self.position_type = position_type
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
        self.approve_id = approve_id
        self.op_userid = op_userid
        self.punch_param = punch_param
        self.sub_type = sub_type
        self.tag_name = tag_name
        # This parameter is required.
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
        status_code: int = None,
        body: CreateApproveResponseBody = None,
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
            temp_model = CreateApproveResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteLeaveRequestHeaders(TeaModel):
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


class DeleteLeaveRequestRequest(TeaModel):
    def __init__(
        self,
        outer_id: str = None,
    ):
        # This parameter is required.
        self.outer_id = outer_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.outer_id is not None:
            result['outerId'] = self.outer_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('outerId') is not None:
            self.outer_id = m.get('outerId')
        return self


class DeleteLeaveRequestResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class DeleteLeaveRequestResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteLeaveRequestResponseBody = None,
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
            temp_model = DeleteLeaveRequestResponseBody()
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
        # This parameter is required.
        self.form_code = form_code
        self.form_content = form_content
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.system_template = system_template
        # This parameter is required.
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
        status_code: int = None,
        body: DeleteWaterMarkTemplateResponseBody = None,
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
        # This parameter is required.
        self.client_ver = client_ver
        # This parameter is required.
        self.platform = platform
        # This parameter is required.
        self.platform_ver = platform_ver
        # This parameter is required.
        self.sec = sec
        # This parameter is required.
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
        self.has_risk = has_risk
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
        # This parameter is required.
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
        status_code: int = None,
        body: DingTalkSecurityCheckResponseBody = None,
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
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
        self.next_token = next_token
        # This parameter is required.
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
        # This parameter is required.
        self.has_more = has_more
        # This parameter is required.
        self.manage_scope = manage_scope
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
        status_code: int = None,
        body: GetATManageScopeResponseBody = None,
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
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
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
        self.id = id
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
        self.items = items
        self.page_number = page_number
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
        result: GetAdjustmentsResponseBodyResult = None,
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
            temp_model = GetAdjustmentsResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetAdjustmentsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetAdjustmentsResponseBody = None,
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
        # This parameter is required.
        self.biz_code = biz_code
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        self.scene_code = scene_code
        # This parameter is required.
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
        self.can_modify = can_modify
        self.form_code = form_code
        self.icon = icon
        self.layout_design = layout_design
        self.scene_code = scene_code
        self.schema_content = schema_content
        self.suite_key = suite_key
        self.system_template = system_template
        self.title = title
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
        self.biz_code = biz_code
        self.can_modify_and_add_template = can_modify_and_add_template
        self.conversation_admin = conversation_admin
        self.custom_template_max_size = custom_template_max_size
        self.open_conversation_id = open_conversation_id
        self.show_stat = show_stat
        self.template_degrade = template_degrade
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
        status_code: int = None,
        body: GetCheckInSchemaTemplateResponseBody = None,
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
            temp_model = GetCheckInSchemaTemplateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetCheckinRecordByUserHeaders(TeaModel):
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


class GetCheckinRecordByUserRequest(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        max_results: int = None,
        next_token: int = None,
        operator_user_id: str = None,
        start_time: int = None,
        user_id_list: List[str] = None,
    ):
        # This parameter is required.
        self.end_time = end_time
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
        self.next_token = next_token
        # This parameter is required.
        self.operator_user_id = operator_user_id
        # This parameter is required.
        self.start_time = start_time
        # This parameter is required.
        self.user_id_list = user_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.operator_user_id is not None:
            result['operatorUserId'] = self.operator_user_id
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.user_id_list is not None:
            result['userIdList'] = self.user_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('operatorUserId') is not None:
            self.operator_user_id = m.get('operatorUserId')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('userIdList') is not None:
            self.user_id_list = m.get('userIdList')
        return self


class GetCheckinRecordByUserResponseBodyResultPageListCustomDataList(TeaModel):
    def __init__(
        self,
        key: str = None,
        label: str = None,
        value: str = None,
    ):
        self.key = key
        self.label = label
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.key is not None:
            result['key'] = self.key
        if self.label is not None:
            result['label'] = self.label
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('key') is not None:
            self.key = m.get('key')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class GetCheckinRecordByUserResponseBodyResultPageList(TeaModel):
    def __init__(
        self,
        checkin_time: int = None,
        custom_data_list: List[GetCheckinRecordByUserResponseBodyResultPageListCustomDataList] = None,
        detail_place: str = None,
        image_list: List[str] = None,
        latitude: str = None,
        longitude: str = None,
        place: str = None,
        remark: str = None,
        user_id: str = None,
        visit_user: str = None,
    ):
        self.checkin_time = checkin_time
        self.custom_data_list = custom_data_list
        self.detail_place = detail_place
        self.image_list = image_list
        self.latitude = latitude
        self.longitude = longitude
        self.place = place
        self.remark = remark
        self.user_id = user_id
        self.visit_user = visit_user

    def validate(self):
        if self.custom_data_list:
            for k in self.custom_data_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.checkin_time is not None:
            result['checkinTime'] = self.checkin_time
        result['customDataList'] = []
        if self.custom_data_list is not None:
            for k in self.custom_data_list:
                result['customDataList'].append(k.to_map() if k else None)
        if self.detail_place is not None:
            result['detailPlace'] = self.detail_place
        if self.image_list is not None:
            result['imageList'] = self.image_list
        if self.latitude is not None:
            result['latitude'] = self.latitude
        if self.longitude is not None:
            result['longitude'] = self.longitude
        if self.place is not None:
            result['place'] = self.place
        if self.remark is not None:
            result['remark'] = self.remark
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.visit_user is not None:
            result['visitUser'] = self.visit_user
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('checkinTime') is not None:
            self.checkin_time = m.get('checkinTime')
        self.custom_data_list = []
        if m.get('customDataList') is not None:
            for k in m.get('customDataList'):
                temp_model = GetCheckinRecordByUserResponseBodyResultPageListCustomDataList()
                self.custom_data_list.append(temp_model.from_map(k))
        if m.get('detailPlace') is not None:
            self.detail_place = m.get('detailPlace')
        if m.get('imageList') is not None:
            self.image_list = m.get('imageList')
        if m.get('latitude') is not None:
            self.latitude = m.get('latitude')
        if m.get('longitude') is not None:
            self.longitude = m.get('longitude')
        if m.get('place') is not None:
            self.place = m.get('place')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('visitUser') is not None:
            self.visit_user = m.get('visitUser')
        return self


class GetCheckinRecordByUserResponseBodyResult(TeaModel):
    def __init__(
        self,
        next_token: int = None,
        page_list: List[GetCheckinRecordByUserResponseBodyResultPageList] = None,
    ):
        self.next_token = next_token
        self.page_list = page_list

    def validate(self):
        if self.page_list:
            for k in self.page_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['pageList'] = []
        if self.page_list is not None:
            for k in self.page_list:
                result['pageList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.page_list = []
        if m.get('pageList') is not None:
            for k in m.get('pageList'):
                temp_model = GetCheckinRecordByUserResponseBodyResultPageList()
                self.page_list.append(temp_model.from_map(k))
        return self


class GetCheckinRecordByUserResponseBody(TeaModel):
    def __init__(
        self,
        result: GetCheckinRecordByUserResponseBodyResult = None,
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
            temp_model = GetCheckinRecordByUserResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetCheckinRecordByUserResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetCheckinRecordByUserResponseBody = None,
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
            temp_model = GetCheckinRecordByUserResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetClassWithDeletedHeaders(TeaModel):
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


class GetClassWithDeletedResponseBodyResultClassSettingRestTimeListBegin(TeaModel):
    def __init__(
        self,
        across: int = None,
        check_time: str = None,
    ):
        self.across = across
        self.check_time = check_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.across is not None:
            result['across'] = self.across
        if self.check_time is not None:
            result['checkTime'] = self.check_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('across') is not None:
            self.across = m.get('across')
        if m.get('checkTime') is not None:
            self.check_time = m.get('checkTime')
        return self


class GetClassWithDeletedResponseBodyResultClassSettingRestTimeListEnd(TeaModel):
    def __init__(
        self,
        across: int = None,
        check_time: str = None,
    ):
        self.across = across
        self.check_time = check_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.across is not None:
            result['across'] = self.across
        if self.check_time is not None:
            result['checkTime'] = self.check_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('across') is not None:
            self.across = m.get('across')
        if m.get('checkTime') is not None:
            self.check_time = m.get('checkTime')
        return self


class GetClassWithDeletedResponseBodyResultClassSettingRestTimeList(TeaModel):
    def __init__(
        self,
        begin: GetClassWithDeletedResponseBodyResultClassSettingRestTimeListBegin = None,
        end: GetClassWithDeletedResponseBodyResultClassSettingRestTimeListEnd = None,
    ):
        self.begin = begin
        self.end = end

    def validate(self):
        if self.begin:
            self.begin.validate()
        if self.end:
            self.end.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.begin is not None:
            result['begin'] = self.begin.to_map()
        if self.end is not None:
            result['end'] = self.end.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('begin') is not None:
            temp_model = GetClassWithDeletedResponseBodyResultClassSettingRestTimeListBegin()
            self.begin = temp_model.from_map(m['begin'])
        if m.get('end') is not None:
            temp_model = GetClassWithDeletedResponseBodyResultClassSettingRestTimeListEnd()
            self.end = temp_model.from_map(m['end'])
        return self


class GetClassWithDeletedResponseBodyResultClassSetting(TeaModel):
    def __init__(
        self,
        class_setting_id: int = None,
        rest_time_list: List[GetClassWithDeletedResponseBodyResultClassSettingRestTimeList] = None,
    ):
        self.class_setting_id = class_setting_id
        self.rest_time_list = rest_time_list

    def validate(self):
        if self.rest_time_list:
            for k in self.rest_time_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.class_setting_id is not None:
            result['classSettingId'] = self.class_setting_id
        result['restTimeList'] = []
        if self.rest_time_list is not None:
            for k in self.rest_time_list:
                result['restTimeList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classSettingId') is not None:
            self.class_setting_id = m.get('classSettingId')
        self.rest_time_list = []
        if m.get('restTimeList') is not None:
            for k in m.get('restTimeList'):
                temp_model = GetClassWithDeletedResponseBodyResultClassSettingRestTimeList()
                self.rest_time_list.append(temp_model.from_map(k))
        return self


class GetClassWithDeletedResponseBodyResultSectionsTimes(TeaModel):
    def __init__(
        self,
        across: int = None,
        begin_min: int = None,
        check_time: str = None,
        check_type: str = None,
        end_min: int = None,
    ):
        self.across = across
        self.begin_min = begin_min
        self.check_time = check_time
        self.check_type = check_type
        self.end_min = end_min

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.across is not None:
            result['across'] = self.across
        if self.begin_min is not None:
            result['beginMin'] = self.begin_min
        if self.check_time is not None:
            result['checkTime'] = self.check_time
        if self.check_type is not None:
            result['checkType'] = self.check_type
        if self.end_min is not None:
            result['endMin'] = self.end_min
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('across') is not None:
            self.across = m.get('across')
        if m.get('beginMin') is not None:
            self.begin_min = m.get('beginMin')
        if m.get('checkTime') is not None:
            self.check_time = m.get('checkTime')
        if m.get('checkType') is not None:
            self.check_type = m.get('checkType')
        if m.get('endMin') is not None:
            self.end_min = m.get('endMin')
        return self


class GetClassWithDeletedResponseBodyResultSections(TeaModel):
    def __init__(
        self,
        times: List[GetClassWithDeletedResponseBodyResultSectionsTimes] = None,
    ):
        self.times = times

    def validate(self):
        if self.times:
            for k in self.times:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['times'] = []
        if self.times is not None:
            for k in self.times:
                result['times'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.times = []
        if m.get('times') is not None:
            for k in m.get('times'):
                temp_model = GetClassWithDeletedResponseBodyResultSectionsTimes()
                self.times.append(temp_model.from_map(k))
        return self


class GetClassWithDeletedResponseBodyResult(TeaModel):
    def __init__(
        self,
        class_id: int = None,
        class_setting: GetClassWithDeletedResponseBodyResultClassSetting = None,
        corp_id: str = None,
        name: str = None,
        sections: List[GetClassWithDeletedResponseBodyResultSections] = None,
        work_days: List[int] = None,
    ):
        self.class_id = class_id
        self.class_setting = class_setting
        self.corp_id = corp_id
        self.name = name
        self.sections = sections
        self.work_days = work_days

    def validate(self):
        if self.class_setting:
            self.class_setting.validate()
        if self.sections:
            for k in self.sections:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.class_id is not None:
            result['classId'] = self.class_id
        if self.class_setting is not None:
            result['classSetting'] = self.class_setting.to_map()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.name is not None:
            result['name'] = self.name
        result['sections'] = []
        if self.sections is not None:
            for k in self.sections:
                result['sections'].append(k.to_map() if k else None)
        if self.work_days is not None:
            result['workDays'] = self.work_days
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classId') is not None:
            self.class_id = m.get('classId')
        if m.get('classSetting') is not None:
            temp_model = GetClassWithDeletedResponseBodyResultClassSetting()
            self.class_setting = temp_model.from_map(m['classSetting'])
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('name') is not None:
            self.name = m.get('name')
        self.sections = []
        if m.get('sections') is not None:
            for k in m.get('sections'):
                temp_model = GetClassWithDeletedResponseBodyResultSections()
                self.sections.append(temp_model.from_map(k))
        if m.get('workDays') is not None:
            self.work_days = m.get('workDays')
        return self


class GetClassWithDeletedResponseBody(TeaModel):
    def __init__(
        self,
        result: GetClassWithDeletedResponseBodyResult = None,
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
            temp_model = GetClassWithDeletedResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetClassWithDeletedResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetClassWithDeletedResponseBody = None,
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
            temp_model = GetClassWithDeletedResponseBody()
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
        # This parameter is required.
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
        # This parameter is required.
        self.closing_day = closing_day
        # This parameter is required.
        self.closing_hour_minutes = closing_hour_minutes
        # This parameter is required.
        self.end_day = end_day
        # This parameter is required.
        self.end_month = end_month
        # This parameter is required.
        self.start_day = start_day
        # This parameter is required.
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
        # This parameter is required.
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
        # This parameter is required.
        self.closing_account_model = closing_account_model
        # This parameter is required.
        self.switch_on = switch_on
        # This parameter is required.
        self.unseal_closing_account_model = unseal_closing_account_model
        # This parameter is required.
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
        # This parameter is required.
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
        status_code: int = None,
        body: GetClosingAccountsResponseBody = None,
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
            temp_model = GetClosingAccountsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetColumnvalsHeaders(TeaModel):
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


class GetColumnvalsRequest(TeaModel):
    def __init__(
        self,
        column_id_list: List[str] = None,
        from_date: int = None,
        to_date: int = None,
        user_ids: List[str] = None,
    ):
        # This parameter is required.
        self.column_id_list = column_id_list
        # This parameter is required.
        self.from_date = from_date
        # This parameter is required.
        self.to_date = to_date
        # This parameter is required.
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.column_id_list is not None:
            result['columnIdList'] = self.column_id_list
        if self.from_date is not None:
            result['fromDate'] = self.from_date
        if self.to_date is not None:
            result['toDate'] = self.to_date
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('columnIdList') is not None:
            self.column_id_list = m.get('columnIdList')
        if m.get('fromDate') is not None:
            self.from_date = m.get('fromDate')
        if m.get('toDate') is not None:
            self.to_date = m.get('toDate')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class GetColumnvalsResponseBodyResultColumnDataColumnValues(TeaModel):
    def __init__(
        self,
        date: int = None,
        value: str = None,
    ):
        self.date = date
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class GetColumnvalsResponseBodyResultColumnData(TeaModel):
    def __init__(
        self,
        column_values: List[GetColumnvalsResponseBodyResultColumnDataColumnValues] = None,
        fixed_value: str = None,
        id: int = None,
    ):
        self.column_values = column_values
        self.fixed_value = fixed_value
        self.id = id

    def validate(self):
        if self.column_values:
            for k in self.column_values:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['columnValues'] = []
        if self.column_values is not None:
            for k in self.column_values:
                result['columnValues'].append(k.to_map() if k else None)
        if self.fixed_value is not None:
            result['fixedValue'] = self.fixed_value
        if self.id is not None:
            result['id'] = self.id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.column_values = []
        if m.get('columnValues') is not None:
            for k in m.get('columnValues'):
                temp_model = GetColumnvalsResponseBodyResultColumnDataColumnValues()
                self.column_values.append(temp_model.from_map(k))
        if m.get('fixedValue') is not None:
            self.fixed_value = m.get('fixedValue')
        if m.get('id') is not None:
            self.id = m.get('id')
        return self


class GetColumnvalsResponseBodyResult(TeaModel):
    def __init__(
        self,
        column_data: List[GetColumnvalsResponseBodyResultColumnData] = None,
        user_id: str = None,
    ):
        self.column_data = column_data
        self.user_id = user_id

    def validate(self):
        if self.column_data:
            for k in self.column_data:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['columnData'] = []
        if self.column_data is not None:
            for k in self.column_data:
                result['columnData'].append(k.to_map() if k else None)
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.column_data = []
        if m.get('columnData') is not None:
            for k in m.get('columnData'):
                temp_model = GetColumnvalsResponseBodyResultColumnData()
                self.column_data.append(temp_model.from_map(k))
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetColumnvalsResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetColumnvalsResponseBodyResult] = None,
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
                temp_model = GetColumnvalsResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GetColumnvalsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetColumnvalsResponseBody = None,
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
            temp_model = GetColumnvalsResponseBody()
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
        # This parameter is required.
        self.leave_code = leave_code
        # This parameter is required.
        self.op_user_id = op_user_id
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
        self.page_size = page_size
        # This parameter is required.
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
        op_user_id: str = None,
        quota_id: str = None,
        record_id: str = None,
        record_num_per_day: int = None,
        record_num_per_hour: int = None,
        start_time: int = None,
        user_id: str = None,
    ):
        self.cal_type = cal_type
        self.end_time = end_time
        self.gmt_create = gmt_create
        self.gmt_modified = gmt_modified
        self.leave_code = leave_code
        self.leave_reason = leave_reason
        self.leave_record_type = leave_record_type
        self.leave_status = leave_status
        self.leave_view_unit = leave_view_unit
        self.op_user_id = op_user_id
        self.quota_id = quota_id
        self.record_id = record_id
        self.record_num_per_day = record_num_per_day
        self.record_num_per_hour = record_num_per_hour
        self.start_time = start_time
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
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
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
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
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
        self.has_more = has_more
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
            temp_model = GetLeaveRecordsResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetLeaveRecordsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetLeaveRecordsResponseBody = None,
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
        # This parameter is required.
        self.op_user_id = op_user_id
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
        self.duration = duration
        self.enable = enable
        self.prompt_information = prompt_information
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
        self.enable_time_limit = enable_time_limit
        self.time_type = time_type
        self.time_unit = time_unit
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
        self.type = type
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
        self.biz_type = biz_type
        self.hours_in_per_day = hours_in_per_day
        self.leave_certificate = leave_certificate
        self.leave_code = leave_code
        self.leave_name = leave_name
        self.leave_view_unit = leave_view_unit
        self.natural_day_leave = natural_day_leave
        self.source = source
        self.submit_time_rule = submit_time_rule
        self.validity_type = validity_type
        self.validity_value = validity_value
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
        # This parameter is required.
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
        status_code: int = None,
        body: GetLeaveTypeResponseBody = None,
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
        # This parameter is required.
        self.address = address
        # This parameter is required.
        self.bluetooth_check_with_face = bluetooth_check_with_face
        # This parameter is required.
        self.bluetooth_distance_mode = bluetooth_distance_mode
        # This parameter is required.
        self.bluetooth_distance_mode_desc = bluetooth_distance_mode_desc
        # This parameter is required.
        self.bluetooth_value = bluetooth_value
        # This parameter is required.
        self.latitude = latitude
        # This parameter is required.
        self.limit_user_device_count = limit_user_device_count
        # This parameter is required.
        self.longitude = longitude
        # This parameter is required.
        self.monitor_location_abnormal = monitor_location_abnormal
        # This parameter is required.
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
        # This parameter is required.
        self.atm_manager_list = atm_manager_list
        # This parameter is required.
        self.dev_id = dev_id
        # This parameter is required.
        self.device_id = device_id
        # This parameter is required.
        self.device_name = device_name
        # This parameter is required.
        self.device_sn = device_sn
        # This parameter is required.
        self.machine_bluetooth_vo = machine_bluetooth_vo
        # This parameter is required.
        self.max_face = max_face
        # This parameter is required.
        self.net_status = net_status
        # This parameter is required.
        self.product_name = product_name
        # This parameter is required.
        self.product_version = product_version
        # This parameter is required.
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
        # This parameter is required.
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
        status_code: int = None,
        body: GetMachineResponseBody = None,
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
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
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
        # This parameter is required.
        self.has_face = has_face
        # This parameter is required.
        self.name = name
        # This parameter is required.
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
        # This parameter is required.
        self.has_more = has_more
        # This parameter is required.
        self.next_token = next_token
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
        # This parameter is required.
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
        status_code: int = None,
        body: GetMachineUserResponseBody = None,
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
            temp_model = GetMachineUserResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetOverdraftInfoHeaders(TeaModel):
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


class GetOverdraftInfoRequest(TeaModel):
    def __init__(
        self,
        leave_code: str = None,
        user_id_list: List[str] = None,
    ):
        # This parameter is required.
        self.leave_code = leave_code
        # This parameter is required.
        self.user_id_list = user_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.leave_code is not None:
            result['leaveCode'] = self.leave_code
        if self.user_id_list is not None:
            result['userIdList'] = self.user_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('leaveCode') is not None:
            self.leave_code = m.get('leaveCode')
        if m.get('userIdList') is not None:
            self.user_id_list = m.get('userIdList')
        return self


class GetOverdraftInfoResponseBodyOverdraftList(TeaModel):
    def __init__(
        self,
        overdraft: int = None,
        unit: str = None,
        user_id: str = None,
    ):
        self.overdraft = overdraft
        self.unit = unit
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.overdraft is not None:
            result['overdraft'] = self.overdraft
        if self.unit is not None:
            result['unit'] = self.unit
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('overdraft') is not None:
            self.overdraft = m.get('overdraft')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetOverdraftInfoResponseBody(TeaModel):
    def __init__(
        self,
        overdraft_list: List[GetOverdraftInfoResponseBodyOverdraftList] = None,
    ):
        self.overdraft_list = overdraft_list

    def validate(self):
        if self.overdraft_list:
            for k in self.overdraft_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['overdraftList'] = []
        if self.overdraft_list is not None:
            for k in self.overdraft_list:
                result['overdraftList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.overdraft_list = []
        if m.get('overdraftList') is not None:
            for k in m.get('overdraftList'):
                temp_model = GetOverdraftInfoResponseBodyOverdraftList()
                self.overdraft_list.append(temp_model.from_map(k))
        return self


class GetOverdraftInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetOverdraftInfoResponseBody = None,
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
            temp_model = GetOverdraftInfoResponseBody()
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
        self.next_day_type = next_day_type
        self.previous_day_type = previous_day_type
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
        self.action = action
        self.threshold = threshold
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
        self.default = default
        self.duration_settings = duration_settings
        # This parameter is required.
        self.id = id
        self.name = name
        self.overtime_divisions = overtime_divisions
        self.setting_id = setting_id
        self.step_type = step_type
        self.step_value = step_value
        self.warning_settings = warning_settings
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
        # This parameter is required.
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
        status_code: int = None,
        body: GetOvertimeSettingResponseBody = None,
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
            temp_model = GetOvertimeSettingResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetShiftHeaders(TeaModel):
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


class GetShiftRequest(TeaModel):
    def __init__(
        self,
        op_user_id: str = None,
        shift_id: int = None,
    ):
        self.op_user_id = op_user_id
        # This parameter is required.
        self.shift_id = shift_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.shift_id is not None:
            result['shiftId'] = self.shift_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('shiftId') is not None:
            self.shift_id = m.get('shiftId')
        return self


class GetShiftResponseBodyResultSectionsPunchesLateBackSettingLateBackPairs(TeaModel):
    def __init__(
        self,
        extra: int = None,
        late: int = None,
    ):
        self.extra = extra
        self.late = late

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.extra is not None:
            result['extra'] = self.extra
        if self.late is not None:
            result['late'] = self.late
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('extra') is not None:
            self.extra = m.get('extra')
        if m.get('late') is not None:
            self.late = m.get('late')
        return self


class GetShiftResponseBodyResultSectionsPunchesLateBackSetting(TeaModel):
    def __init__(
        self,
        late_back_pairs: List[GetShiftResponseBodyResultSectionsPunchesLateBackSettingLateBackPairs] = None,
    ):
        self.late_back_pairs = late_back_pairs

    def validate(self):
        if self.late_back_pairs:
            for k in self.late_back_pairs:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['lateBackPairs'] = []
        if self.late_back_pairs is not None:
            for k in self.late_back_pairs:
                result['lateBackPairs'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.late_back_pairs = []
        if m.get('lateBackPairs') is not None:
            for k in m.get('lateBackPairs'):
                temp_model = GetShiftResponseBodyResultSectionsPunchesLateBackSettingLateBackPairs()
                self.late_back_pairs.append(temp_model.from_map(k))
        return self


class GetShiftResponseBodyResultSectionsPunches(TeaModel):
    def __init__(
        self,
        absenteeism_late_minutes: int = None,
        across: int = None,
        begin_min: int = None,
        check_time: str = None,
        check_type: str = None,
        end_min: int = None,
        flex_minutes: List[int] = None,
        free_check: bool = None,
        late_back_setting: GetShiftResponseBodyResultSectionsPunchesLateBackSetting = None,
        permit_minutes: int = None,
        punche_id: int = None,
        serious_late_minutes: int = None,
    ):
        self.absenteeism_late_minutes = absenteeism_late_minutes
        self.across = across
        self.begin_min = begin_min
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.check_time = check_time
        self.check_type = check_type
        self.end_min = end_min
        self.flex_minutes = flex_minutes
        self.free_check = free_check
        self.late_back_setting = late_back_setting
        self.permit_minutes = permit_minutes
        self.punche_id = punche_id
        self.serious_late_minutes = serious_late_minutes

    def validate(self):
        if self.late_back_setting:
            self.late_back_setting.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.absenteeism_late_minutes is not None:
            result['absenteeismLateMinutes'] = self.absenteeism_late_minutes
        if self.across is not None:
            result['across'] = self.across
        if self.begin_min is not None:
            result['beginMin'] = self.begin_min
        if self.check_time is not None:
            result['checkTime'] = self.check_time
        if self.check_type is not None:
            result['checkType'] = self.check_type
        if self.end_min is not None:
            result['endMin'] = self.end_min
        if self.flex_minutes is not None:
            result['flexMinutes'] = self.flex_minutes
        if self.free_check is not None:
            result['freeCheck'] = self.free_check
        if self.late_back_setting is not None:
            result['lateBackSetting'] = self.late_back_setting.to_map()
        if self.permit_minutes is not None:
            result['permitMinutes'] = self.permit_minutes
        if self.punche_id is not None:
            result['puncheId'] = self.punche_id
        if self.serious_late_minutes is not None:
            result['seriousLateMinutes'] = self.serious_late_minutes
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('absenteeismLateMinutes') is not None:
            self.absenteeism_late_minutes = m.get('absenteeismLateMinutes')
        if m.get('across') is not None:
            self.across = m.get('across')
        if m.get('beginMin') is not None:
            self.begin_min = m.get('beginMin')
        if m.get('checkTime') is not None:
            self.check_time = m.get('checkTime')
        if m.get('checkType') is not None:
            self.check_type = m.get('checkType')
        if m.get('endMin') is not None:
            self.end_min = m.get('endMin')
        if m.get('flexMinutes') is not None:
            self.flex_minutes = m.get('flexMinutes')
        if m.get('freeCheck') is not None:
            self.free_check = m.get('freeCheck')
        if m.get('lateBackSetting') is not None:
            temp_model = GetShiftResponseBodyResultSectionsPunchesLateBackSetting()
            self.late_back_setting = temp_model.from_map(m['lateBackSetting'])
        if m.get('permitMinutes') is not None:
            self.permit_minutes = m.get('permitMinutes')
        if m.get('puncheId') is not None:
            self.punche_id = m.get('puncheId')
        if m.get('seriousLateMinutes') is not None:
            self.serious_late_minutes = m.get('seriousLateMinutes')
        return self


class GetShiftResponseBodyResultSectionsRests(TeaModel):
    def __init__(
        self,
        across: int = None,
        check_time: str = None,
        check_type: str = None,
        rest_id: int = None,
    ):
        self.across = across
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.check_time = check_time
        self.check_type = check_type
        self.rest_id = rest_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.across is not None:
            result['across'] = self.across
        if self.check_time is not None:
            result['checkTime'] = self.check_time
        if self.check_type is not None:
            result['checkType'] = self.check_type
        if self.rest_id is not None:
            result['restId'] = self.rest_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('across') is not None:
            self.across = m.get('across')
        if m.get('checkTime') is not None:
            self.check_time = m.get('checkTime')
        if m.get('checkType') is not None:
            self.check_type = m.get('checkType')
        if m.get('restId') is not None:
            self.rest_id = m.get('restId')
        return self


class GetShiftResponseBodyResultSections(TeaModel):
    def __init__(
        self,
        punches: List[GetShiftResponseBodyResultSectionsPunches] = None,
        rests: List[GetShiftResponseBodyResultSectionsRests] = None,
        section_id: int = None,
    ):
        self.punches = punches
        self.rests = rests
        self.section_id = section_id

    def validate(self):
        if self.punches:
            for k in self.punches:
                if k:
                    k.validate()
        if self.rests:
            for k in self.rests:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['punches'] = []
        if self.punches is not None:
            for k in self.punches:
                result['punches'].append(k.to_map() if k else None)
        result['rests'] = []
        if self.rests is not None:
            for k in self.rests:
                result['rests'].append(k.to_map() if k else None)
        if self.section_id is not None:
            result['sectionId'] = self.section_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.punches = []
        if m.get('punches') is not None:
            for k in m.get('punches'):
                temp_model = GetShiftResponseBodyResultSectionsPunches()
                self.punches.append(temp_model.from_map(k))
        self.rests = []
        if m.get('rests') is not None:
            for k in m.get('rests'):
                temp_model = GetShiftResponseBodyResultSectionsRests()
                self.rests.append(temp_model.from_map(k))
        if m.get('sectionId') is not None:
            self.section_id = m.get('sectionId')
        return self


class GetShiftResponseBodyResultShiftSetting(TeaModel):
    def __init__(
        self,
        attend_days: str = None,
        corp_id: str = None,
        gmt_create: str = None,
        gmt_modified: str = None,
        shift_id: int = None,
        shift_setting_id: int = None,
        work_time_minutes: int = None,
    ):
        self.attend_days = attend_days
        self.corp_id = corp_id
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.gmt_create = gmt_create
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.gmt_modified = gmt_modified
        self.shift_id = shift_id
        self.shift_setting_id = shift_setting_id
        self.work_time_minutes = work_time_minutes

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.attend_days is not None:
            result['attendDays'] = self.attend_days
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.shift_id is not None:
            result['shiftId'] = self.shift_id
        if self.shift_setting_id is not None:
            result['shiftSettingId'] = self.shift_setting_id
        if self.work_time_minutes is not None:
            result['workTimeMinutes'] = self.work_time_minutes
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('attendDays') is not None:
            self.attend_days = m.get('attendDays')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('shiftId') is not None:
            self.shift_id = m.get('shiftId')
        if m.get('shiftSettingId') is not None:
            self.shift_setting_id = m.get('shiftSettingId')
        if m.get('workTimeMinutes') is not None:
            self.work_time_minutes = m.get('workTimeMinutes')
        return self


class GetShiftResponseBodyResult(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        id: int = None,
        name: str = None,
        owner: str = None,
        sections: List[GetShiftResponseBodyResultSections] = None,
        shift_group_id: int = None,
        shift_group_name: str = None,
        shift_setting: GetShiftResponseBodyResultShiftSetting = None,
    ):
        self.corp_id = corp_id
        self.id = id
        self.name = name
        self.owner = owner
        self.sections = sections
        self.shift_group_id = shift_group_id
        self.shift_group_name = shift_group_name
        self.shift_setting = shift_setting

    def validate(self):
        if self.sections:
            for k in self.sections:
                if k:
                    k.validate()
        if self.shift_setting:
            self.shift_setting.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.owner is not None:
            result['owner'] = self.owner
        result['sections'] = []
        if self.sections is not None:
            for k in self.sections:
                result['sections'].append(k.to_map() if k else None)
        if self.shift_group_id is not None:
            result['shiftGroupId'] = self.shift_group_id
        if self.shift_group_name is not None:
            result['shiftGroupName'] = self.shift_group_name
        if self.shift_setting is not None:
            result['shiftSetting'] = self.shift_setting.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('owner') is not None:
            self.owner = m.get('owner')
        self.sections = []
        if m.get('sections') is not None:
            for k in m.get('sections'):
                temp_model = GetShiftResponseBodyResultSections()
                self.sections.append(temp_model.from_map(k))
        if m.get('shiftGroupId') is not None:
            self.shift_group_id = m.get('shiftGroupId')
        if m.get('shiftGroupName') is not None:
            self.shift_group_name = m.get('shiftGroupName')
        if m.get('shiftSetting') is not None:
            temp_model = GetShiftResponseBodyResultShiftSetting()
            self.shift_setting = temp_model.from_map(m['shiftSetting'])
        return self


class GetShiftResponseBody(TeaModel):
    def __init__(
        self,
        result: GetShiftResponseBodyResult = None,
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
            temp_model = GetShiftResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetShiftResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetShiftResponseBody = None,
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
            temp_model = GetShiftResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetSimpleGroupsHeaders(TeaModel):
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


class GetSimpleGroupsRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: int = None,
    ):
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
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


class GetSimpleGroupsResponseBodyResultGroupsSelectedClassSectionsTimes(TeaModel):
    def __init__(
        self,
        across: int = None,
        check_time: str = None,
        check_type: str = None,
    ):
        self.across = across
        self.check_time = check_time
        self.check_type = check_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.across is not None:
            result['across'] = self.across
        if self.check_time is not None:
            result['checkTime'] = self.check_time
        if self.check_type is not None:
            result['checkType'] = self.check_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('across') is not None:
            self.across = m.get('across')
        if m.get('checkTime') is not None:
            self.check_time = m.get('checkTime')
        if m.get('checkType') is not None:
            self.check_type = m.get('checkType')
        return self


class GetSimpleGroupsResponseBodyResultGroupsSelectedClassSections(TeaModel):
    def __init__(
        self,
        times: List[GetSimpleGroupsResponseBodyResultGroupsSelectedClassSectionsTimes] = None,
    ):
        self.times = times

    def validate(self):
        if self.times:
            for k in self.times:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['times'] = []
        if self.times is not None:
            for k in self.times:
                result['times'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.times = []
        if m.get('times') is not None:
            for k in m.get('times'):
                temp_model = GetSimpleGroupsResponseBodyResultGroupsSelectedClassSectionsTimes()
                self.times.append(temp_model.from_map(k))
        return self


class GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeListBegin(TeaModel):
    def __init__(
        self,
        across: int = None,
        check_time: str = None,
    ):
        self.across = across
        self.check_time = check_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.across is not None:
            result['across'] = self.across
        if self.check_time is not None:
            result['checkTime'] = self.check_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('across') is not None:
            self.across = m.get('across')
        if m.get('checkTime') is not None:
            self.check_time = m.get('checkTime')
        return self


class GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeListEnd(TeaModel):
    def __init__(
        self,
        across: int = None,
        check_time: str = None,
    ):
        self.across = across
        self.check_time = check_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.across is not None:
            result['across'] = self.across
        if self.check_time is not None:
            result['checkTime'] = self.check_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('across') is not None:
            self.across = m.get('across')
        if m.get('checkTime') is not None:
            self.check_time = m.get('checkTime')
        return self


class GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeList(TeaModel):
    def __init__(
        self,
        begin: GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeListBegin = None,
        end: GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeListEnd = None,
    ):
        self.begin = begin
        self.end = end

    def validate(self):
        if self.begin:
            self.begin.validate()
        if self.end:
            self.end.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.begin is not None:
            result['begin'] = self.begin.to_map()
        if self.end is not None:
            result['end'] = self.end.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('begin') is not None:
            temp_model = GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeListBegin()
            self.begin = temp_model.from_map(m['begin'])
        if m.get('end') is not None:
            temp_model = GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeListEnd()
            self.end = temp_model.from_map(m['end'])
        return self


class GetSimpleGroupsResponseBodyResultGroupsSelectedClassSetting(TeaModel):
    def __init__(
        self,
        absenteeism_late_minutes: int = None,
        class_setting_id: int = None,
        is_off_duty_free_check: str = None,
        permit_late_minutes: int = None,
        rest_time_list: List[GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeList] = None,
        serious_late_minutes: int = None,
        work_time_minutes: int = None,
    ):
        self.absenteeism_late_minutes = absenteeism_late_minutes
        self.class_setting_id = class_setting_id
        self.is_off_duty_free_check = is_off_duty_free_check
        self.permit_late_minutes = permit_late_minutes
        self.rest_time_list = rest_time_list
        self.serious_late_minutes = serious_late_minutes
        self.work_time_minutes = work_time_minutes

    def validate(self):
        if self.rest_time_list:
            for k in self.rest_time_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.absenteeism_late_minutes is not None:
            result['absenteeismLateMinutes'] = self.absenteeism_late_minutes
        if self.class_setting_id is not None:
            result['classSettingId'] = self.class_setting_id
        if self.is_off_duty_free_check is not None:
            result['isOffDutyFreeCheck'] = self.is_off_duty_free_check
        if self.permit_late_minutes is not None:
            result['permitLateMinutes'] = self.permit_late_minutes
        result['restTimeList'] = []
        if self.rest_time_list is not None:
            for k in self.rest_time_list:
                result['restTimeList'].append(k.to_map() if k else None)
        if self.serious_late_minutes is not None:
            result['seriousLateMinutes'] = self.serious_late_minutes
        if self.work_time_minutes is not None:
            result['workTimeMinutes'] = self.work_time_minutes
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('absenteeismLateMinutes') is not None:
            self.absenteeism_late_minutes = m.get('absenteeismLateMinutes')
        if m.get('classSettingId') is not None:
            self.class_setting_id = m.get('classSettingId')
        if m.get('isOffDutyFreeCheck') is not None:
            self.is_off_duty_free_check = m.get('isOffDutyFreeCheck')
        if m.get('permitLateMinutes') is not None:
            self.permit_late_minutes = m.get('permitLateMinutes')
        self.rest_time_list = []
        if m.get('restTimeList') is not None:
            for k in m.get('restTimeList'):
                temp_model = GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeList()
                self.rest_time_list.append(temp_model.from_map(k))
        if m.get('seriousLateMinutes') is not None:
            self.serious_late_minutes = m.get('seriousLateMinutes')
        if m.get('workTimeMinutes') is not None:
            self.work_time_minutes = m.get('workTimeMinutes')
        return self


class GetSimpleGroupsResponseBodyResultGroupsSelectedClass(TeaModel):
    def __init__(
        self,
        class_id: int = None,
        class_name: str = None,
        sections: List[GetSimpleGroupsResponseBodyResultGroupsSelectedClassSections] = None,
        setting: GetSimpleGroupsResponseBodyResultGroupsSelectedClassSetting = None,
    ):
        self.class_id = class_id
        self.class_name = class_name
        self.sections = sections
        self.setting = setting

    def validate(self):
        if self.sections:
            for k in self.sections:
                if k:
                    k.validate()
        if self.setting:
            self.setting.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.class_id is not None:
            result['classId'] = self.class_id
        if self.class_name is not None:
            result['className'] = self.class_name
        result['sections'] = []
        if self.sections is not None:
            for k in self.sections:
                result['sections'].append(k.to_map() if k else None)
        if self.setting is not None:
            result['setting'] = self.setting.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classId') is not None:
            self.class_id = m.get('classId')
        if m.get('className') is not None:
            self.class_name = m.get('className')
        self.sections = []
        if m.get('sections') is not None:
            for k in m.get('sections'):
                temp_model = GetSimpleGroupsResponseBodyResultGroupsSelectedClassSections()
                self.sections.append(temp_model.from_map(k))
        if m.get('setting') is not None:
            temp_model = GetSimpleGroupsResponseBodyResultGroupsSelectedClassSetting()
            self.setting = temp_model.from_map(m['setting'])
        return self


class GetSimpleGroupsResponseBodyResultGroups(TeaModel):
    def __init__(
        self,
        classes_list: List[str] = None,
        default_class_id: int = None,
        dept_ids: List[int] = None,
        dept_name_list: List[str] = None,
        disable_check_when_rest: bool = None,
        disable_check_without_schedule: bool = None,
        enable_emp_select_class: bool = None,
        free_check_day_start_min_offset: int = None,
        freecheck_work_days: List[int] = None,
        group_id: int = None,
        group_name: str = None,
        is_default: bool = None,
        manager_list: List[str] = None,
        member_count: int = None,
        owner_user_id: str = None,
        selected_class: List[GetSimpleGroupsResponseBodyResultGroupsSelectedClass] = None,
        type: str = None,
        user_ids: List[str] = None,
        work_day_list: List[str] = None,
    ):
        self.classes_list = classes_list
        self.default_class_id = default_class_id
        self.dept_ids = dept_ids
        self.dept_name_list = dept_name_list
        self.disable_check_when_rest = disable_check_when_rest
        self.disable_check_without_schedule = disable_check_without_schedule
        self.enable_emp_select_class = enable_emp_select_class
        self.free_check_day_start_min_offset = free_check_day_start_min_offset
        self.freecheck_work_days = freecheck_work_days
        self.group_id = group_id
        self.group_name = group_name
        self.is_default = is_default
        self.manager_list = manager_list
        self.member_count = member_count
        self.owner_user_id = owner_user_id
        self.selected_class = selected_class
        self.type = type
        self.user_ids = user_ids
        self.work_day_list = work_day_list

    def validate(self):
        if self.selected_class:
            for k in self.selected_class:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.classes_list is not None:
            result['classesList'] = self.classes_list
        if self.default_class_id is not None:
            result['defaultClassId'] = self.default_class_id
        if self.dept_ids is not None:
            result['deptIds'] = self.dept_ids
        if self.dept_name_list is not None:
            result['deptNameList'] = self.dept_name_list
        if self.disable_check_when_rest is not None:
            result['disableCheckWhenRest'] = self.disable_check_when_rest
        if self.disable_check_without_schedule is not None:
            result['disableCheckWithoutSchedule'] = self.disable_check_without_schedule
        if self.enable_emp_select_class is not None:
            result['enableEmpSelectClass'] = self.enable_emp_select_class
        if self.free_check_day_start_min_offset is not None:
            result['freeCheckDayStartMinOffset'] = self.free_check_day_start_min_offset
        if self.freecheck_work_days is not None:
            result['freecheckWorkDays'] = self.freecheck_work_days
        if self.group_id is not None:
            result['groupId'] = self.group_id
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.is_default is not None:
            result['isDefault'] = self.is_default
        if self.manager_list is not None:
            result['managerList'] = self.manager_list
        if self.member_count is not None:
            result['memberCount'] = self.member_count
        if self.owner_user_id is not None:
            result['ownerUserId'] = self.owner_user_id
        result['selectedClass'] = []
        if self.selected_class is not None:
            for k in self.selected_class:
                result['selectedClass'].append(k.to_map() if k else None)
        if self.type is not None:
            result['type'] = self.type
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        if self.work_day_list is not None:
            result['workDayList'] = self.work_day_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('classesList') is not None:
            self.classes_list = m.get('classesList')
        if m.get('defaultClassId') is not None:
            self.default_class_id = m.get('defaultClassId')
        if m.get('deptIds') is not None:
            self.dept_ids = m.get('deptIds')
        if m.get('deptNameList') is not None:
            self.dept_name_list = m.get('deptNameList')
        if m.get('disableCheckWhenRest') is not None:
            self.disable_check_when_rest = m.get('disableCheckWhenRest')
        if m.get('disableCheckWithoutSchedule') is not None:
            self.disable_check_without_schedule = m.get('disableCheckWithoutSchedule')
        if m.get('enableEmpSelectClass') is not None:
            self.enable_emp_select_class = m.get('enableEmpSelectClass')
        if m.get('freeCheckDayStartMinOffset') is not None:
            self.free_check_day_start_min_offset = m.get('freeCheckDayStartMinOffset')
        if m.get('freecheckWorkDays') is not None:
            self.freecheck_work_days = m.get('freecheckWorkDays')
        if m.get('groupId') is not None:
            self.group_id = m.get('groupId')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('isDefault') is not None:
            self.is_default = m.get('isDefault')
        if m.get('managerList') is not None:
            self.manager_list = m.get('managerList')
        if m.get('memberCount') is not None:
            self.member_count = m.get('memberCount')
        if m.get('ownerUserId') is not None:
            self.owner_user_id = m.get('ownerUserId')
        self.selected_class = []
        if m.get('selectedClass') is not None:
            for k in m.get('selectedClass'):
                temp_model = GetSimpleGroupsResponseBodyResultGroupsSelectedClass()
                self.selected_class.append(temp_model.from_map(k))
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        if m.get('workDayList') is not None:
            self.work_day_list = m.get('workDayList')
        return self


class GetSimpleGroupsResponseBodyResult(TeaModel):
    def __init__(
        self,
        groups: List[GetSimpleGroupsResponseBodyResultGroups] = None,
        has_more: bool = None,
    ):
        self.groups = groups
        self.has_more = has_more

    def validate(self):
        if self.groups:
            for k in self.groups:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['groups'] = []
        if self.groups is not None:
            for k in self.groups:
                result['groups'].append(k.to_map() if k else None)
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.groups = []
        if m.get('groups') is not None:
            for k in m.get('groups'):
                temp_model = GetSimpleGroupsResponseBodyResultGroups()
                self.groups.append(temp_model.from_map(k))
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        return self


class GetSimpleGroupsResponseBody(TeaModel):
    def __init__(
        self,
        result: GetSimpleGroupsResponseBodyResult = None,
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
            temp_model = GetSimpleGroupsResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetSimpleGroupsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetSimpleGroupsResponseBody = None,
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
            temp_model = GetSimpleGroupsResponseBody()
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
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
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
        self.id = id
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
        self.items = items
        self.page_number = page_number
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
        result: GetSimpleOvertimeSettingResponseBodyResult = None,
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
            temp_model = GetSimpleOvertimeSettingResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetSimpleOvertimeSettingResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetSimpleOvertimeSettingResponseBody = None,
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
        # This parameter is required.
        self.user_ids = user_ids
        # This parameter is required.
        self.work_date_from = work_date_from
        # This parameter is required.
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
        self.holiday_name = holiday_name
        self.holiday_type = holiday_type
        self.real_work_date = real_work_date
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
        self.holidays = holidays
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
        status_code: int = None,
        body: GetUserHolidaysResponseBody = None,
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
        self.off_on_check_gap_minutes = off_on_check_gap_minutes
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
        delimit_offset_minutes_between_days: int = None,
        free_check_gap: GroupAddRequestFreeCheckSettingFreeCheckGap = None,
    ):
        self.delimit_offset_minutes_between_days = delimit_offset_minutes_between_days
        self.free_check_gap = free_check_gap

    def validate(self):
        if self.free_check_gap:
            self.free_check_gap.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.delimit_offset_minutes_between_days is not None:
            result['delimitOffsetMinutesBetweenDays'] = self.delimit_offset_minutes_between_days
        if self.free_check_gap is not None:
            result['freeCheckGap'] = self.free_check_gap.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('delimitOffsetMinutesBetweenDays') is not None:
            self.delimit_offset_minutes_between_days = m.get('delimitOffsetMinutesBetweenDays')
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
        # This parameter is required.
        self.role = role
        # This parameter is required.
        self.type = type
        # This parameter is required.
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
        self.address = address
        self.latitude = latitude
        self.longitude = longitude
        self.offset = offset
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


class GroupAddRequestShiftVOList(TeaModel):
    def __init__(
        self,
        shift_id: int = None,
    ):
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
        self.mac_addr = mac_addr
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
        only_machine_check: bool = None,
        open_camera_check: bool = None,
        open_face_check: bool = None,
        outside_check_approve_mode_id: int = None,
        overtime_setting_id: int = None,
        owner: str = None,
        positions: List[GroupAddRequestPositions] = None,
        resource_permission_map: Dict[str, Any] = None,
        shift_volist: List[GroupAddRequestShiftVOList] = None,
        skip_holidays: bool = None,
        special_days: str = None,
        trim_distance: int = None,
        type: str = None,
        wifis: List[GroupAddRequestWifis] = None,
        workday_class_list: List[int] = None,
        op_user_id: str = None,
    ):
        self.adjustment_setting_id = adjustment_setting_id
        self.ble_device_list = ble_device_list
        self.check_need_healthy_code = check_need_healthy_code
        self.default_class_id = default_class_id
        self.disable_check_when_rest = disable_check_when_rest
        self.disable_check_without_schedule = disable_check_without_schedule
        self.enable_camera_check = enable_camera_check
        self.enable_emp_select_class = enable_emp_select_class
        self.enable_face_check = enable_face_check
        self.enable_face_strict_mode = enable_face_strict_mode
        self.enable_next_day = enable_next_day
        self.enable_out_side_update_normal_check = enable_out_side_update_normal_check
        self.enable_outside_apply = enable_outside_apply
        self.enable_outside_camera_check = enable_outside_camera_check
        self.enable_outside_check = enable_outside_check
        self.enable_outside_remark = enable_outside_remark
        self.enable_position_ble = enable_position_ble
        self.enable_trim_distance = enable_trim_distance
        self.forbid_hide_out_side_address = forbid_hide_out_side_address
        self.free_check_setting = free_check_setting
        self.free_check_type_id = free_check_type_id
        self.freecheck_day_start_min_offset = freecheck_day_start_min_offset
        self.freecheck_work_days = freecheck_work_days
        self.group_id = group_id
        # This parameter is required.
        self.group_name = group_name
        self.manager_list = manager_list
        # This parameter is required.
        self.members = members
        self.modify_member = modify_member
        self.offset = offset
        self.only_machine_check = only_machine_check
        self.open_camera_check = open_camera_check
        self.open_face_check = open_face_check
        self.outside_check_approve_mode_id = outside_check_approve_mode_id
        self.overtime_setting_id = overtime_setting_id
        self.owner = owner
        self.positions = positions
        self.resource_permission_map = resource_permission_map
        self.shift_volist = shift_volist
        self.skip_holidays = skip_holidays
        self.special_days = special_days
        self.trim_distance = trim_distance
        # This parameter is required.
        self.type = type
        self.wifis = wifis
        self.workday_class_list = workday_class_list
        # This parameter is required.
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
        if self.only_machine_check is not None:
            result['onlyMachineCheck'] = self.only_machine_check
        if self.open_camera_check is not None:
            result['openCameraCheck'] = self.open_camera_check
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
        if self.resource_permission_map is not None:
            result['resourcePermissionMap'] = self.resource_permission_map
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
        if m.get('onlyMachineCheck') is not None:
            self.only_machine_check = m.get('onlyMachineCheck')
        if m.get('openCameraCheck') is not None:
            self.open_camera_check = m.get('openCameraCheck')
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
        if m.get('resourcePermissionMap') is not None:
            self.resource_permission_map = m.get('resourcePermissionMap')
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
        id: int = None,
        name: str = None,
    ):
        self.id = id
        self.name = name

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class GroupAddResponseBody(TeaModel):
    def __init__(
        self,
        result: GroupAddResponseBodyResult = None,
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
            temp_model = GroupAddResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GroupAddResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GroupAddResponseBody = None,
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
        self.off_on_check_gap_minutes = off_on_check_gap_minutes
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
        delimit_offset_minutes_between_days: int = None,
        free_check_gap: GroupUpdateRequestFreeCheckSettingFreeCheckGap = None,
    ):
        self.delimit_offset_minutes_between_days = delimit_offset_minutes_between_days
        self.free_check_gap = free_check_gap

    def validate(self):
        if self.free_check_gap:
            self.free_check_gap.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.delimit_offset_minutes_between_days is not None:
            result['delimitOffsetMinutesBetweenDays'] = self.delimit_offset_minutes_between_days
        if self.free_check_gap is not None:
            result['freeCheckGap'] = self.free_check_gap.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('delimitOffsetMinutesBetweenDays') is not None:
            self.delimit_offset_minutes_between_days = m.get('delimitOffsetMinutesBetweenDays')
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
        self.address = address
        self.latitude = latitude
        self.longitude = longitude
        self.offset = offset
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


class GroupUpdateRequestShiftVOList(TeaModel):
    def __init__(
        self,
        shift_id: int = None,
    ):
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
        freecheck_day_start_min_offset: int = None,
        group_id: int = None,
        group_name: str = None,
        manager_list: List[str] = None,
        offset: int = None,
        only_machine_check: bool = None,
        open_camera_check: bool = None,
        open_face_check: bool = None,
        outside_check_approve_mode_id: int = None,
        overtime_setting_id: int = None,
        owner: str = None,
        positions: List[GroupUpdateRequestPositions] = None,
        resource_permission_map: Dict[str, Any] = None,
        shift_volist: List[GroupUpdateRequestShiftVOList] = None,
        skip_holidays: bool = None,
        trim_distance: int = None,
        workday_class_list: List[int] = None,
        op_user_id: str = None,
    ):
        self.adjustment_setting_id = adjustment_setting_id
        self.disable_check_when_rest = disable_check_when_rest
        self.disable_check_without_schedule = disable_check_without_schedule
        self.enable_camera_check = enable_camera_check
        self.enable_emp_select_class = enable_emp_select_class
        self.enable_face_check = enable_face_check
        self.enable_face_strict_mode = enable_face_strict_mode
        self.enable_out_side_update_normal_check = enable_out_side_update_normal_check
        self.enable_outside_apply = enable_outside_apply
        self.enable_outside_check = enable_outside_check
        self.enable_outside_remark = enable_outside_remark
        self.enable_trim_distance = enable_trim_distance
        self.forbid_hide_out_side_address = forbid_hide_out_side_address
        self.free_check_setting = free_check_setting
        self.free_check_type_id = free_check_type_id
        self.freecheck_day_start_min_offset = freecheck_day_start_min_offset
        self.group_id = group_id
        self.group_name = group_name
        self.manager_list = manager_list
        self.offset = offset
        self.only_machine_check = only_machine_check
        self.open_camera_check = open_camera_check
        self.open_face_check = open_face_check
        self.outside_check_approve_mode_id = outside_check_approve_mode_id
        self.overtime_setting_id = overtime_setting_id
        self.owner = owner
        self.positions = positions
        self.resource_permission_map = resource_permission_map
        self.shift_volist = shift_volist
        self.skip_holidays = skip_holidays
        self.trim_distance = trim_distance
        self.workday_class_list = workday_class_list
        # This parameter is required.
        self.op_user_id = op_user_id

    def validate(self):
        if self.free_check_setting:
            self.free_check_setting.validate()
        if self.positions:
            for k in self.positions:
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
        if self.freecheck_day_start_min_offset is not None:
            result['freecheckDayStartMinOffset'] = self.freecheck_day_start_min_offset
        if self.group_id is not None:
            result['groupId'] = self.group_id
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.manager_list is not None:
            result['managerList'] = self.manager_list
        if self.offset is not None:
            result['offset'] = self.offset
        if self.only_machine_check is not None:
            result['onlyMachineCheck'] = self.only_machine_check
        if self.open_camera_check is not None:
            result['openCameraCheck'] = self.open_camera_check
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
        if self.resource_permission_map is not None:
            result['resourcePermissionMap'] = self.resource_permission_map
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
        if m.get('freecheckDayStartMinOffset') is not None:
            self.freecheck_day_start_min_offset = m.get('freecheckDayStartMinOffset')
        if m.get('groupId') is not None:
            self.group_id = m.get('groupId')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('managerList') is not None:
            self.manager_list = m.get('managerList')
        if m.get('offset') is not None:
            self.offset = m.get('offset')
        if m.get('onlyMachineCheck') is not None:
            self.only_machine_check = m.get('onlyMachineCheck')
        if m.get('openCameraCheck') is not None:
            self.open_camera_check = m.get('openCameraCheck')
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
        if m.get('resourcePermissionMap') is not None:
            self.resource_permission_map = m.get('resourcePermissionMap')
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
        id: int = None,
        name: str = None,
    ):
        self.id = id
        self.name = name

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class GroupUpdateResponseBody(TeaModel):
    def __init__(
        self,
        result: GroupUpdateResponseBodyResult = None,
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
            temp_model = GroupUpdateResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GroupUpdateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GroupUpdateResponseBody = None,
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
        self.leave_code = leave_code
        # This parameter is required.
        self.op_user_id = op_user_id
        # This parameter is required.
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
        self.end_time = end_time
        self.leave_code = leave_code
        self.quota_cycle = quota_cycle
        self.quota_id = quota_id
        self.quota_num_per_day = quota_num_per_day
        self.quota_num_per_hour = quota_num_per_hour
        self.start_time = start_time
        self.used_num_per_day = used_num_per_day
        self.used_num_per_hour = used_num_per_hour
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
        status_code: int = None,
        body: InitAndGetLeaveALlocationQuotasResponseBody = None,
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
            temp_model = InitAndGetLeaveALlocationQuotasResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListApproveByUsersHeaders(TeaModel):
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


class ListApproveByUsersRequest(TeaModel):
    def __init__(
        self,
        biz_types: List[int] = None,
        from_date_time: int = None,
        to_date_time: int = None,
        user_ids: str = None,
    ):
        self.biz_types = biz_types
        self.from_date_time = from_date_time
        self.to_date_time = to_date_time
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_types is not None:
            result['bizTypes'] = self.biz_types
        if self.from_date_time is not None:
            result['fromDateTime'] = self.from_date_time
        if self.to_date_time is not None:
            result['toDateTime'] = self.to_date_time
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizTypes') is not None:
            self.biz_types = m.get('bizTypes')
        if m.get('fromDateTime') is not None:
            self.from_date_time = m.get('fromDateTime')
        if m.get('toDateTime') is not None:
            self.to_date_time = m.get('toDateTime')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class ListApproveByUsersResponseBodyResult(TeaModel):
    def __init__(
        self,
        approve_id: str = None,
        begin_time: str = None,
        biz_type: int = None,
        calculate_model: int = None,
        duration_unit: str = None,
        end_time: str = None,
        sub_type: str = None,
        tag_name: str = None,
        user_id: str = None,
    ):
        self.approve_id = approve_id
        self.begin_time = begin_time
        self.biz_type = biz_type
        self.calculate_model = calculate_model
        self.duration_unit = duration_unit
        self.end_time = end_time
        self.sub_type = sub_type
        self.tag_name = tag_name
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.approve_id is not None:
            result['approveId'] = self.approve_id
        if self.begin_time is not None:
            result['beginTime'] = self.begin_time
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.calculate_model is not None:
            result['calculateModel'] = self.calculate_model
        if self.duration_unit is not None:
            result['durationUnit'] = self.duration_unit
        if self.end_time is not None:
            result['endTime'] = self.end_time
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
        if m.get('beginTime') is not None:
            self.begin_time = m.get('beginTime')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('calculateModel') is not None:
            self.calculate_model = m.get('calculateModel')
        if m.get('durationUnit') is not None:
            self.duration_unit = m.get('durationUnit')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('subType') is not None:
            self.sub_type = m.get('subType')
        if m.get('tagName') is not None:
            self.tag_name = m.get('tagName')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class ListApproveByUsersResponseBody(TeaModel):
    def __init__(
        self,
        result: List[ListApproveByUsersResponseBodyResult] = None,
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
                temp_model = ListApproveByUsersResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class ListApproveByUsersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListApproveByUsersResponseBody = None,
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
            temp_model = ListApproveByUsersResponseBody()
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
        # This parameter is required.
        self.form_code = form_code
        self.icon = icon
        self.layout_design_id = layout_design_id
        # This parameter is required.
        self.schema_content = schema_content
        self.title = title
        self.water_mark_id = water_mark_id
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
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
        status_code: int = None,
        body: ModifyWaterMarkTemplateResponseBody = None,
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
        self.position_id = position_id
        self.position_name = position_name
        self.position_type = position_type
        # This parameter is required.
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
        # This parameter is required.
        self.approve_id = approve_id
        # This parameter is required.
        self.op_user_id = op_user_id
        # This parameter is required.
        self.punch_param = punch_param
        # This parameter is required.
        self.sub_type = sub_type
        # This parameter is required.
        self.tag_name = tag_name
        # This parameter is required.
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
        # This parameter is required.
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
        status_code: int = None,
        body: ProcessApproveCreateResponseBody = None,
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
            temp_model = ProcessApproveCreateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ProcessApproveFinishHeaders(TeaModel):
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


class ProcessApproveFinishRequestTopCalculateApproveDurationParam(TeaModel):
    def __init__(
        self,
        biz_type: int = None,
        calculate_model: int = None,
        duration_unit: str = None,
        from_time: str = None,
        leave_code: str = None,
        to_time: str = None,
    ):
        self.biz_type = biz_type
        self.calculate_model = calculate_model
        self.duration_unit = duration_unit
        self.from_time = from_time
        self.leave_code = leave_code
        self.to_time = to_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.calculate_model is not None:
            result['calculateModel'] = self.calculate_model
        if self.duration_unit is not None:
            result['durationUnit'] = self.duration_unit
        if self.from_time is not None:
            result['fromTime'] = self.from_time
        if self.leave_code is not None:
            result['leaveCode'] = self.leave_code
        if self.to_time is not None:
            result['toTime'] = self.to_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('calculateModel') is not None:
            self.calculate_model = m.get('calculateModel')
        if m.get('durationUnit') is not None:
            self.duration_unit = m.get('durationUnit')
        if m.get('fromTime') is not None:
            self.from_time = m.get('fromTime')
        if m.get('leaveCode') is not None:
            self.leave_code = m.get('leaveCode')
        if m.get('toTime') is not None:
            self.to_time = m.get('toTime')
        return self


class ProcessApproveFinishRequest(TeaModel):
    def __init__(
        self,
        approve_id: str = None,
        jump_url: str = None,
        over_time_to_more: int = None,
        overtime_duration: str = None,
        sub_type: str = None,
        tag_name: str = None,
        top_calculate_approve_duration_param: ProcessApproveFinishRequestTopCalculateApproveDurationParam = None,
        user_id: str = None,
    ):
        self.approve_id = approve_id
        self.jump_url = jump_url
        self.over_time_to_more = over_time_to_more
        self.overtime_duration = overtime_duration
        self.sub_type = sub_type
        self.tag_name = tag_name
        self.top_calculate_approve_duration_param = top_calculate_approve_duration_param
        self.user_id = user_id

    def validate(self):
        if self.top_calculate_approve_duration_param:
            self.top_calculate_approve_duration_param.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.approve_id is not None:
            result['approveId'] = self.approve_id
        if self.jump_url is not None:
            result['jumpUrl'] = self.jump_url
        if self.over_time_to_more is not None:
            result['overTimeToMore'] = self.over_time_to_more
        if self.overtime_duration is not None:
            result['overtimeDuration'] = self.overtime_duration
        if self.sub_type is not None:
            result['subType'] = self.sub_type
        if self.tag_name is not None:
            result['tagName'] = self.tag_name
        if self.top_calculate_approve_duration_param is not None:
            result['topCalculateApproveDurationParam'] = self.top_calculate_approve_duration_param.to_map()
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('approveId') is not None:
            self.approve_id = m.get('approveId')
        if m.get('jumpUrl') is not None:
            self.jump_url = m.get('jumpUrl')
        if m.get('overTimeToMore') is not None:
            self.over_time_to_more = m.get('overTimeToMore')
        if m.get('overtimeDuration') is not None:
            self.overtime_duration = m.get('overtimeDuration')
        if m.get('subType') is not None:
            self.sub_type = m.get('subType')
        if m.get('tagName') is not None:
            self.tag_name = m.get('tagName')
        if m.get('topCalculateApproveDurationParam') is not None:
            temp_model = ProcessApproveFinishRequestTopCalculateApproveDurationParam()
            self.top_calculate_approve_duration_param = temp_model.from_map(m['topCalculateApproveDurationParam'])
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class ProcessApproveFinishResponseBodyResultDurationDetail(TeaModel):
    def __init__(
        self,
        date: str = None,
        duration: float = None,
    ):
        self.date = date
        self.duration = duration

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.duration is not None:
            result['duration'] = self.duration
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        return self


class ProcessApproveFinishResponseBodyResult(TeaModel):
    def __init__(
        self,
        duration: float = None,
        duration_detail: List[ProcessApproveFinishResponseBodyResultDurationDetail] = None,
    ):
        self.duration = duration
        self.duration_detail = duration_detail

    def validate(self):
        if self.duration_detail:
            for k in self.duration_detail:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.duration is not None:
            result['duration'] = self.duration
        result['durationDetail'] = []
        if self.duration_detail is not None:
            for k in self.duration_detail:
                result['durationDetail'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        self.duration_detail = []
        if m.get('durationDetail') is not None:
            for k in m.get('durationDetail'):
                temp_model = ProcessApproveFinishResponseBodyResultDurationDetail()
                self.duration_detail.append(temp_model.from_map(k))
        return self


class ProcessApproveFinishResponseBody(TeaModel):
    def __init__(
        self,
        result: ProcessApproveFinishResponseBodyResult = None,
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
            temp_model = ProcessApproveFinishResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class ProcessApproveFinishResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ProcessApproveFinishResponseBody = None,
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
            temp_model = ProcessApproveFinishResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ReduceQuotaWithLeaveRecordHeaders(TeaModel):
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


class ReduceQuotaWithLeaveRecordRequest(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        leave_code: str = None,
        outer_id: str = None,
        quota_num: int = None,
        reason: str = None,
        start_time: int = None,
    ):
        # This parameter is required.
        self.end_time = end_time
        # This parameter is required.
        self.leave_code = leave_code
        # This parameter is required.
        self.outer_id = outer_id
        # This parameter is required.
        self.quota_num = quota_num
        self.reason = reason
        # This parameter is required.
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
        if self.leave_code is not None:
            result['leaveCode'] = self.leave_code
        if self.outer_id is not None:
            result['outerId'] = self.outer_id
        if self.quota_num is not None:
            result['quotaNum'] = self.quota_num
        if self.reason is not None:
            result['reason'] = self.reason
        if self.start_time is not None:
            result['startTime'] = self.start_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('leaveCode') is not None:
            self.leave_code = m.get('leaveCode')
        if m.get('outerId') is not None:
            self.outer_id = m.get('outerId')
        if m.get('quotaNum') is not None:
            self.quota_num = m.get('quotaNum')
        if m.get('reason') is not None:
            self.reason = m.get('reason')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        return self


class ReduceQuotaWithLeaveRecordResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class ReduceQuotaWithLeaveRecordResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ReduceQuotaWithLeaveRecordResponseBody = None,
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
            temp_model = ReduceQuotaWithLeaveRecordResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RetainLeaveTypesHeaders(TeaModel):
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


class RetainLeaveTypesRequest(TeaModel):
    def __init__(
        self,
        leave_codes: List[str] = None,
        op_user_id: str = None,
        source: int = None,
    ):
        self.leave_codes = leave_codes
        self.op_user_id = op_user_id
        # This parameter is required.
        self.source = source

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.leave_codes is not None:
            result['leaveCodes'] = self.leave_codes
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.source is not None:
            result['source'] = self.source
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('leaveCodes') is not None:
            self.leave_codes = m.get('leaveCodes')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('source') is not None:
            self.source = m.get('source')
        return self


class RetainLeaveTypesResponseBodyResultLeaveCertificate(TeaModel):
    def __init__(
        self,
        duration: float = None,
        enable: bool = None,
        prompt_information: str = None,
        unit: str = None,
    ):
        self.duration = duration
        self.enable = enable
        self.prompt_information = prompt_information
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


class RetainLeaveTypesResponseBodyResultSubmitTimeRule(TeaModel):
    def __init__(
        self,
        enable_time_limit: bool = None,
        time_type: str = None,
        time_unit: str = None,
        time_value: int = None,
    ):
        self.enable_time_limit = enable_time_limit
        self.time_type = time_type
        self.time_unit = time_unit
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


class RetainLeaveTypesResponseBodyResultVisibilityRules(TeaModel):
    def __init__(
        self,
        type: str = None,
        visible: List[str] = None,
    ):
        self.type = type
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


class RetainLeaveTypesResponseBodyResult(TeaModel):
    def __init__(
        self,
        biz_type: str = None,
        hours_in_per_day: int = None,
        leave_certificate: RetainLeaveTypesResponseBodyResultLeaveCertificate = None,
        leave_code: str = None,
        leave_hour_ceil: str = None,
        leave_name: str = None,
        leave_time_ceil: bool = None,
        leave_time_ceil_min_unit: str = None,
        leave_view_unit: str = None,
        lieu_delay_num: int = None,
        lieu_delay_unit: str = None,
        max_leave_time: int = None,
        min_leave_hour: float = None,
        natural_day_leave: bool = None,
        paid_leave: bool = None,
        submit_time_rule: RetainLeaveTypesResponseBodyResultSubmitTimeRule = None,
        visibility_rules: List[RetainLeaveTypesResponseBodyResultVisibilityRules] = None,
        when_can_leave: str = None,
    ):
        self.biz_type = biz_type
        self.hours_in_per_day = hours_in_per_day
        self.leave_certificate = leave_certificate
        self.leave_code = leave_code
        self.leave_hour_ceil = leave_hour_ceil
        self.leave_name = leave_name
        self.leave_time_ceil = leave_time_ceil
        self.leave_time_ceil_min_unit = leave_time_ceil_min_unit
        self.leave_view_unit = leave_view_unit
        self.lieu_delay_num = lieu_delay_num
        self.lieu_delay_unit = lieu_delay_unit
        self.max_leave_time = max_leave_time
        self.min_leave_hour = min_leave_hour
        self.natural_day_leave = natural_day_leave
        self.paid_leave = paid_leave
        self.submit_time_rule = submit_time_rule
        self.visibility_rules = visibility_rules
        self.when_can_leave = when_can_leave

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
        if self.leave_hour_ceil is not None:
            result['leaveHourCeil'] = self.leave_hour_ceil
        if self.leave_name is not None:
            result['leaveName'] = self.leave_name
        if self.leave_time_ceil is not None:
            result['leaveTimeCeil'] = self.leave_time_ceil
        if self.leave_time_ceil_min_unit is not None:
            result['leaveTimeCeilMinUnit'] = self.leave_time_ceil_min_unit
        if self.leave_view_unit is not None:
            result['leaveViewUnit'] = self.leave_view_unit
        if self.lieu_delay_num is not None:
            result['lieuDelayNum'] = self.lieu_delay_num
        if self.lieu_delay_unit is not None:
            result['lieuDelayUnit'] = self.lieu_delay_unit
        if self.max_leave_time is not None:
            result['maxLeaveTime'] = self.max_leave_time
        if self.min_leave_hour is not None:
            result['minLeaveHour'] = self.min_leave_hour
        if self.natural_day_leave is not None:
            result['naturalDayLeave'] = self.natural_day_leave
        if self.paid_leave is not None:
            result['paidLeave'] = self.paid_leave
        if self.submit_time_rule is not None:
            result['submitTimeRule'] = self.submit_time_rule.to_map()
        result['visibilityRules'] = []
        if self.visibility_rules is not None:
            for k in self.visibility_rules:
                result['visibilityRules'].append(k.to_map() if k else None)
        if self.when_can_leave is not None:
            result['whenCanLeave'] = self.when_can_leave
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('hoursInPerDay') is not None:
            self.hours_in_per_day = m.get('hoursInPerDay')
        if m.get('leaveCertificate') is not None:
            temp_model = RetainLeaveTypesResponseBodyResultLeaveCertificate()
            self.leave_certificate = temp_model.from_map(m['leaveCertificate'])
        if m.get('leaveCode') is not None:
            self.leave_code = m.get('leaveCode')
        if m.get('leaveHourCeil') is not None:
            self.leave_hour_ceil = m.get('leaveHourCeil')
        if m.get('leaveName') is not None:
            self.leave_name = m.get('leaveName')
        if m.get('leaveTimeCeil') is not None:
            self.leave_time_ceil = m.get('leaveTimeCeil')
        if m.get('leaveTimeCeilMinUnit') is not None:
            self.leave_time_ceil_min_unit = m.get('leaveTimeCeilMinUnit')
        if m.get('leaveViewUnit') is not None:
            self.leave_view_unit = m.get('leaveViewUnit')
        if m.get('lieuDelayNum') is not None:
            self.lieu_delay_num = m.get('lieuDelayNum')
        if m.get('lieuDelayUnit') is not None:
            self.lieu_delay_unit = m.get('lieuDelayUnit')
        if m.get('maxLeaveTime') is not None:
            self.max_leave_time = m.get('maxLeaveTime')
        if m.get('minLeaveHour') is not None:
            self.min_leave_hour = m.get('minLeaveHour')
        if m.get('naturalDayLeave') is not None:
            self.natural_day_leave = m.get('naturalDayLeave')
        if m.get('paidLeave') is not None:
            self.paid_leave = m.get('paidLeave')
        if m.get('submitTimeRule') is not None:
            temp_model = RetainLeaveTypesResponseBodyResultSubmitTimeRule()
            self.submit_time_rule = temp_model.from_map(m['submitTimeRule'])
        self.visibility_rules = []
        if m.get('visibilityRules') is not None:
            for k in m.get('visibilityRules'):
                temp_model = RetainLeaveTypesResponseBodyResultVisibilityRules()
                self.visibility_rules.append(temp_model.from_map(k))
        if m.get('whenCanLeave') is not None:
            self.when_can_leave = m.get('whenCanLeave')
        return self


class RetainLeaveTypesResponseBody(TeaModel):
    def __init__(
        self,
        result: List[RetainLeaveTypesResponseBodyResult] = None,
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
                temp_model = RetainLeaveTypesResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class RetainLeaveTypesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RetainLeaveTypesResponseBody = None,
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
            temp_model = RetainLeaveTypesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ReverseTrialAdvancedLeaveHeaders(TeaModel):
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


class ReverseTrialAdvancedLeaveRequest(TeaModel):
    def __init__(
        self,
        op_user_id: str = None,
        serv_code: int = None,
    ):
        self.op_user_id = op_user_id
        self.serv_code = serv_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.serv_code is not None:
            result['servCode'] = self.serv_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('servCode') is not None:
            self.serv_code = m.get('servCode')
        return self


class ReverseTrialAdvancedLeaveResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class ReverseTrialAdvancedLeaveResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ReverseTrialAdvancedLeaveResponseBody = None,
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
            temp_model = ReverseTrialAdvancedLeaveResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SalaryThirdDataIntegrationHeaders(TeaModel):
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


class SalaryThirdDataIntegrationRequestItemsBizContents(TeaModel):
    def __init__(
        self,
        key: str = None,
        value: str = None,
    ):
        self.key = key
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.key is not None:
            result['key'] = self.key
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('key') is not None:
            self.key = m.get('key')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class SalaryThirdDataIntegrationRequestItems(TeaModel):
    def __init__(
        self,
        biz_contents: List[SalaryThirdDataIntegrationRequestItemsBizContents] = None,
        biz_date: str = None,
        biz_id: str = None,
        user_id: str = None,
    ):
        self.biz_contents = biz_contents
        # This parameter is required.
        self.biz_date = biz_date
        # This parameter is required.
        self.biz_id = biz_id
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        if self.biz_contents:
            for k in self.biz_contents:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['bizContents'] = []
        if self.biz_contents is not None:
            for k in self.biz_contents:
                result['bizContents'].append(k.to_map() if k else None)
        if self.biz_date is not None:
            result['bizDate'] = self.biz_date
        if self.biz_id is not None:
            result['bizId'] = self.biz_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.biz_contents = []
        if m.get('bizContents') is not None:
            for k in m.get('bizContents'):
                temp_model = SalaryThirdDataIntegrationRequestItemsBizContents()
                self.biz_contents.append(temp_model.from_map(k))
        if m.get('bizDate') is not None:
            self.biz_date = m.get('bizDate')
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class SalaryThirdDataIntegrationRequest(TeaModel):
    def __init__(
        self,
        biz_type: str = None,
        items: List[SalaryThirdDataIntegrationRequestItems] = None,
    ):
        # This parameter is required.
        self.biz_type = biz_type
        self.items = items

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
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        self.items = []
        if m.get('items') is not None:
            for k in m.get('items'):
                temp_model = SalaryThirdDataIntegrationRequestItems()
                self.items.append(temp_model.from_map(k))
        return self


class SalaryThirdDataIntegrationResponseBodyResult(TeaModel):
    def __init__(
        self,
        reason: Dict[str, Any] = None,
    ):
        self.reason = reason

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.reason is not None:
            result['reason'] = self.reason
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('reason') is not None:
            self.reason = m.get('reason')
        return self


class SalaryThirdDataIntegrationResponseBody(TeaModel):
    def __init__(
        self,
        result: SalaryThirdDataIntegrationResponseBodyResult = None,
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
            temp_model = SalaryThirdDataIntegrationResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class SalaryThirdDataIntegrationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SalaryThirdDataIntegrationResponseBody = None,
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
            temp_model = SalaryThirdDataIntegrationResponseBody()
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
        # This parameter is required.
        self.biz_code = biz_code
        # This parameter is required.
        self.icon = icon
        # This parameter is required.
        self.layout_design_id = layout_design_id
        # This parameter is required.
        self.scene_code = scene_code
        # This parameter is required.
        self.schema_content = schema_content
        # This parameter is required.
        self.title = title
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
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
        self.form_code = form_code
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
        status_code: int = None,
        body: SaveCustomWaterMarkTemplateResponseBody = None,
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
            temp_model = SaveCustomWaterMarkTemplateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ShiftAddHeaders(TeaModel):
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


class ShiftAddRequestSectionsTimes(TeaModel):
    def __init__(
        self,
        across: int = None,
        begin_min: int = None,
        check_time: int = None,
        check_type: str = None,
        end_min: int = None,
        flex_minutes: List[int] = None,
        free_check: bool = None,
    ):
        # This parameter is required.
        self.across = across
        self.begin_min = begin_min
        # This parameter is required.
        self.check_time = check_time
        # This parameter is required.
        self.check_type = check_type
        self.end_min = end_min
        self.flex_minutes = flex_minutes
        self.free_check = free_check

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.across is not None:
            result['across'] = self.across
        if self.begin_min is not None:
            result['beginMin'] = self.begin_min
        if self.check_time is not None:
            result['checkTime'] = self.check_time
        if self.check_type is not None:
            result['checkType'] = self.check_type
        if self.end_min is not None:
            result['endMin'] = self.end_min
        if self.flex_minutes is not None:
            result['flexMinutes'] = self.flex_minutes
        if self.free_check is not None:
            result['freeCheck'] = self.free_check
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('across') is not None:
            self.across = m.get('across')
        if m.get('beginMin') is not None:
            self.begin_min = m.get('beginMin')
        if m.get('checkTime') is not None:
            self.check_time = m.get('checkTime')
        if m.get('checkType') is not None:
            self.check_type = m.get('checkType')
        if m.get('endMin') is not None:
            self.end_min = m.get('endMin')
        if m.get('flexMinutes') is not None:
            self.flex_minutes = m.get('flexMinutes')
        if m.get('freeCheck') is not None:
            self.free_check = m.get('freeCheck')
        return self


class ShiftAddRequestSections(TeaModel):
    def __init__(
        self,
        times: List[ShiftAddRequestSectionsTimes] = None,
    ):
        # This parameter is required.
        self.times = times

    def validate(self):
        if self.times:
            for k in self.times:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['times'] = []
        if self.times is not None:
            for k in self.times:
                result['times'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.times = []
        if m.get('times') is not None:
            for k in m.get('times'):
                temp_model = ShiftAddRequestSectionsTimes()
                self.times.append(temp_model.from_map(k))
        return self


class ShiftAddRequestSettingLateBackSettingSections(TeaModel):
    def __init__(
        self,
        extra: int = None,
        late: int = None,
    ):
        self.extra = extra
        self.late = late

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.extra is not None:
            result['extra'] = self.extra
        if self.late is not None:
            result['late'] = self.late
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('extra') is not None:
            self.extra = m.get('extra')
        if m.get('late') is not None:
            self.late = m.get('late')
        return self


class ShiftAddRequestSettingLateBackSetting(TeaModel):
    def __init__(
        self,
        enable: bool = None,
        sections: List[ShiftAddRequestSettingLateBackSettingSections] = None,
    ):
        self.enable = enable
        self.sections = sections

    def validate(self):
        if self.sections:
            for k in self.sections:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.enable is not None:
            result['enable'] = self.enable
        result['sections'] = []
        if self.sections is not None:
            for k in self.sections:
                result['sections'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('enable') is not None:
            self.enable = m.get('enable')
        self.sections = []
        if m.get('sections') is not None:
            for k in m.get('sections'):
                temp_model = ShiftAddRequestSettingLateBackSettingSections()
                self.sections.append(temp_model.from_map(k))
        return self


class ShiftAddRequestSettingTopRestTimeList(TeaModel):
    def __init__(
        self,
        across: int = None,
        check_time: int = None,
        check_type: str = None,
    ):
        self.across = across
        self.check_time = check_time
        self.check_type = check_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.across is not None:
            result['across'] = self.across
        if self.check_time is not None:
            result['checkTime'] = self.check_time
        if self.check_type is not None:
            result['checkType'] = self.check_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('across') is not None:
            self.across = m.get('across')
        if m.get('checkTime') is not None:
            self.check_time = m.get('checkTime')
        if m.get('checkType') is not None:
            self.check_type = m.get('checkType')
        return self


class ShiftAddRequestSetting(TeaModel):
    def __init__(
        self,
        absenteeism_late_minutes: int = None,
        attend_days: float = None,
        demand_work_time_minutes: int = None,
        enable_outside_late_back: bool = None,
        extras: Dict[str, Any] = None,
        is_flexible: bool = None,
        late_back_setting: ShiftAddRequestSettingLateBackSetting = None,
        serious_late_minutes: int = None,
        tags: str = None,
        top_rest_time_list: List[ShiftAddRequestSettingTopRestTimeList] = None,
    ):
        self.absenteeism_late_minutes = absenteeism_late_minutes
        self.attend_days = attend_days
        self.demand_work_time_minutes = demand_work_time_minutes
        self.enable_outside_late_back = enable_outside_late_back
        self.extras = extras
        self.is_flexible = is_flexible
        self.late_back_setting = late_back_setting
        self.serious_late_minutes = serious_late_minutes
        self.tags = tags
        self.top_rest_time_list = top_rest_time_list

    def validate(self):
        if self.late_back_setting:
            self.late_back_setting.validate()
        if self.top_rest_time_list:
            for k in self.top_rest_time_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.absenteeism_late_minutes is not None:
            result['absenteeismLateMinutes'] = self.absenteeism_late_minutes
        if self.attend_days is not None:
            result['attendDays'] = self.attend_days
        if self.demand_work_time_minutes is not None:
            result['demandWorkTimeMinutes'] = self.demand_work_time_minutes
        if self.enable_outside_late_back is not None:
            result['enableOutsideLateBack'] = self.enable_outside_late_back
        if self.extras is not None:
            result['extras'] = self.extras
        if self.is_flexible is not None:
            result['isFlexible'] = self.is_flexible
        if self.late_back_setting is not None:
            result['lateBackSetting'] = self.late_back_setting.to_map()
        if self.serious_late_minutes is not None:
            result['seriousLateMinutes'] = self.serious_late_minutes
        if self.tags is not None:
            result['tags'] = self.tags
        result['topRestTimeList'] = []
        if self.top_rest_time_list is not None:
            for k in self.top_rest_time_list:
                result['topRestTimeList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('absenteeismLateMinutes') is not None:
            self.absenteeism_late_minutes = m.get('absenteeismLateMinutes')
        if m.get('attendDays') is not None:
            self.attend_days = m.get('attendDays')
        if m.get('demandWorkTimeMinutes') is not None:
            self.demand_work_time_minutes = m.get('demandWorkTimeMinutes')
        if m.get('enableOutsideLateBack') is not None:
            self.enable_outside_late_back = m.get('enableOutsideLateBack')
        if m.get('extras') is not None:
            self.extras = m.get('extras')
        if m.get('isFlexible') is not None:
            self.is_flexible = m.get('isFlexible')
        if m.get('lateBackSetting') is not None:
            temp_model = ShiftAddRequestSettingLateBackSetting()
            self.late_back_setting = temp_model.from_map(m['lateBackSetting'])
        if m.get('seriousLateMinutes') is not None:
            self.serious_late_minutes = m.get('seriousLateMinutes')
        if m.get('tags') is not None:
            self.tags = m.get('tags')
        self.top_rest_time_list = []
        if m.get('topRestTimeList') is not None:
            for k in m.get('topRestTimeList'):
                temp_model = ShiftAddRequestSettingTopRestTimeList()
                self.top_rest_time_list.append(temp_model.from_map(k))
        return self


class ShiftAddRequest(TeaModel):
    def __init__(
        self,
        name: str = None,
        owner: str = None,
        sections: List[ShiftAddRequestSections] = None,
        service_id: int = None,
        setting: ShiftAddRequestSetting = None,
        shift_id: int = None,
        op_user_id: str = None,
    ):
        # This parameter is required.
        self.name = name
        self.owner = owner
        # This parameter is required.
        self.sections = sections
        self.service_id = service_id
        self.setting = setting
        self.shift_id = shift_id
        # This parameter is required.
        self.op_user_id = op_user_id

    def validate(self):
        if self.sections:
            for k in self.sections:
                if k:
                    k.validate()
        if self.setting:
            self.setting.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.owner is not None:
            result['owner'] = self.owner
        result['sections'] = []
        if self.sections is not None:
            for k in self.sections:
                result['sections'].append(k.to_map() if k else None)
        if self.service_id is not None:
            result['serviceId'] = self.service_id
        if self.setting is not None:
            result['setting'] = self.setting.to_map()
        if self.shift_id is not None:
            result['shiftId'] = self.shift_id
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('owner') is not None:
            self.owner = m.get('owner')
        self.sections = []
        if m.get('sections') is not None:
            for k in m.get('sections'):
                temp_model = ShiftAddRequestSections()
                self.sections.append(temp_model.from_map(k))
        if m.get('serviceId') is not None:
            self.service_id = m.get('serviceId')
        if m.get('setting') is not None:
            temp_model = ShiftAddRequestSetting()
            self.setting = temp_model.from_map(m['setting'])
        if m.get('shiftId') is not None:
            self.shift_id = m.get('shiftId')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class ShiftAddResponseBodyResult(TeaModel):
    def __init__(
        self,
        name: str = None,
        shift_id: int = None,
    ):
        self.name = name
        self.shift_id = shift_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.shift_id is not None:
            result['shiftId'] = self.shift_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('shiftId') is not None:
            self.shift_id = m.get('shiftId')
        return self


class ShiftAddResponseBody(TeaModel):
    def __init__(
        self,
        result: ShiftAddResponseBodyResult = None,
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
            temp_model = ShiftAddResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class ShiftAddResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ShiftAddResponseBody = None,
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
            temp_model = ShiftAddResponseBody()
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
        # This parameter is required.
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
        # This parameter is required.
        self.op_user_id = op_user_id
        # This parameter is required.
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
        self.duration = duration
        self.enable = enable
        self.prompt_information = prompt_information
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
        self.enable_time_limit = enable_time_limit
        self.time_type = time_type
        self.time_unit = time_unit
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
        self.type = type
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
        # This parameter is required.
        self.biz_type = biz_type
        self.extras = extras
        self.hours_in_per_day = hours_in_per_day
        self.leave_certificate = leave_certificate
        # This parameter is required.
        self.leave_code = leave_code
        self.leave_name = leave_name
        # This parameter is required.
        self.leave_view_unit = leave_view_unit
        self.natural_day_leave = natural_day_leave
        self.submit_time_rule = submit_time_rule
        self.visibility_rules = visibility_rules
        # This parameter is required.
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
        self.duration = duration
        self.enable = enable
        self.prompt_information = prompt_information
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
        self.enable_time_limit = enable_time_limit
        self.time_type = time_type
        self.time_unit = time_unit
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
        self.type = type
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
        self.biz_type = biz_type
        self.hours_in_per_day = hours_in_per_day
        self.leave_certificate = leave_certificate
        self.leave_code = leave_code
        self.leave_name = leave_name
        self.leave_view_unit = leave_view_unit
        self.natural_day_leave = natural_day_leave
        self.submit_time_rule = submit_time_rule
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
        # This parameter is required.
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
        status_code: int = None,
        body: UpdateLeaveTypeResponseBody = None,
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
            temp_model = UpdateLeaveTypeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


