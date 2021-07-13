# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


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
        _map = super().to_map()
        if _map is not None:
            return _map

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
        _map = super().to_map()
        if _map is not None:
            return _map

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
        start_time: int = None,
        end_time: int = None,
    ):
        self.start_time = start_time
        self.end_time = end_time

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        return self


class CheckClosingAccountRequest(TeaModel):
    def __init__(
        self,
        user_ids: List[str] = None,
        user_time_range: List[CheckClosingAccountRequestUserTimeRange] = None,
        biz_code: str = None,
    ):
        # 员工列表
        self.user_ids = user_ids
        # 时间段
        self.user_time_range = user_time_range
        # 情景
        self.biz_code = biz_code

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
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        result['userTimeRange'] = []
        if self.user_time_range is not None:
            for k in self.user_time_range:
                result['userTimeRange'].append(k.to_map() if k else None)
        if self.biz_code is not None:
            result['bizCode'] = self.biz_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        self.user_time_range = []
        if m.get('userTimeRange') is not None:
            for k in m.get('userTimeRange'):
                temp_model = CheckClosingAccountRequestUserTimeRange()
                self.user_time_range.append(temp_model.from_map(k))
        if m.get('bizCode') is not None:
            self.biz_code = m.get('bizCode')
        return self


class CheckClosingAccountResponseBody(TeaModel):
    def __init__(
        self,
        mesage: str = None,
        code: str = None,
        pass_: bool = None,
    ):
        self.mesage = mesage
        self.code = code
        self.pass_ = pass_

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.mesage is not None:
            result['mesage'] = self.mesage
        if self.code is not None:
            result['code'] = self.code
        if self.pass_ is not None:
            result['pass'] = self.pass_
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('mesage') is not None:
            self.mesage = m.get('mesage')
        if m.get('code') is not None:
            self.code = m.get('code')
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
        work_date: int = None,
        holiday_name: str = None,
        holiday_type: str = None,
        real_work_date: int = None,
    ):
        # 日期
        self.work_date = work_date
        # 假期名称
        self.holiday_name = holiday_name
        # 假期类型，festival：法定节假日；rest：调休日；overtime：加班日；
        self.holiday_type = holiday_type
        # 补休日，只有假期类型为加班日时才有值
        self.real_work_date = real_work_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.work_date is not None:
            result['workDate'] = self.work_date
        if self.holiday_name is not None:
            result['holidayName'] = self.holiday_name
        if self.holiday_type is not None:
            result['holidayType'] = self.holiday_type
        if self.real_work_date is not None:
            result['realWorkDate'] = self.real_work_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('workDate') is not None:
            self.work_date = m.get('workDate')
        if m.get('holidayName') is not None:
            self.holiday_name = m.get('holidayName')
        if m.get('holidayType') is not None:
            self.holiday_type = m.get('holidayType')
        if m.get('realWorkDate') is not None:
            self.real_work_date = m.get('realWorkDate')
        return self


class GetUserHolidaysResponseBodyResult(TeaModel):
    def __init__(
        self,
        user_id: str = None,
        holidays: List[GetUserHolidaysResponseBodyResultHolidays] = None,
    ):
        # 员工id
        self.user_id = user_id
        # 假期列表
        self.holidays = holidays

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
        if self.user_id is not None:
            result['userId'] = self.user_id
        result['holidays'] = []
        if self.holidays is not None:
            for k in self.holidays:
                result['holidays'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        self.holidays = []
        if m.get('holidays') is not None:
            for k in m.get('holidays'):
                temp_model = GetUserHolidaysResponseBodyResultHolidays()
                self.holidays.append(temp_model.from_map(k))
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
        corp_id: str = None,
        op_user_id: str = None,
        category: str = None,
        resource_key: str = None,
        entity_ids: List[int] = None,
    ):
        # corpId
        self.corp_id = corp_id
        # opUserId
        self.op_user_id = op_user_id
        # category
        self.category = category
        # resourceKey
        self.resource_key = resource_key
        # entityIds
        self.entity_ids = entity_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.category is not None:
            result['category'] = self.category
        if self.resource_key is not None:
            result['resourceKey'] = self.resource_key
        if self.entity_ids is not None:
            result['entityIds'] = self.entity_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('category') is not None:
            self.category = m.get('category')
        if m.get('resourceKey') is not None:
            self.resource_key = m.get('resourceKey')
        if m.get('entityIds') is not None:
            self.entity_ids = m.get('entityIds')
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
        start_month: int = None,
        start_day: int = None,
        end_month: int = None,
        end_day: int = None,
    ):
        # 封账时间-日
        self.closing_day = closing_day
        # 封账时间-时分
        self.closing_hour_minutes = closing_hour_minutes
        # 封账范围-开始月
        self.start_month = start_month
        # 封账范围-开始日
        self.start_day = start_day
        # 封账范围-结束月
        self.end_month = end_month
        # 封账范围-结束日
        self.end_day = end_day

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
        if self.start_month is not None:
            result['startMonth'] = self.start_month
        if self.start_day is not None:
            result['startDay'] = self.start_day
        if self.end_month is not None:
            result['endMonth'] = self.end_month
        if self.end_day is not None:
            result['endDay'] = self.end_day
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('closingDay') is not None:
            self.closing_day = m.get('closingDay')
        if m.get('closingHourMinutes') is not None:
            self.closing_hour_minutes = m.get('closingHourMinutes')
        if m.get('startMonth') is not None:
            self.start_month = m.get('startMonth')
        if m.get('startDay') is not None:
            self.start_day = m.get('startDay')
        if m.get('endMonth') is not None:
            self.end_month = m.get('endMonth')
        if m.get('endDay') is not None:
            self.end_day = m.get('endDay')
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
        user_id: str = None,
        switch_on: bool = None,
        closing_account_model: GetClosingAccountsResponseBodyResultClosingAccountModel = None,
        unseal_closing_account_model: GetClosingAccountsResponseBodyResultUnsealClosingAccountModel = None,
    ):
        # 人员ID
        self.user_id = user_id
        # 开关
        self.switch_on = switch_on
        # 封账规则
        self.closing_account_model = closing_account_model
        # 解封规则
        self.unseal_closing_account_model = unseal_closing_account_model

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
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.switch_on is not None:
            result['switchOn'] = self.switch_on
        if self.closing_account_model is not None:
            result['closingAccountModel'] = self.closing_account_model.to_map()
        if self.unseal_closing_account_model is not None:
            result['unsealClosingAccountModel'] = self.unseal_closing_account_model.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('switchOn') is not None:
            self.switch_on = m.get('switchOn')
        if m.get('closingAccountModel') is not None:
            temp_model = GetClosingAccountsResponseBodyResultClosingAccountModel()
            self.closing_account_model = temp_model.from_map(m['closingAccountModel'])
        if m.get('unsealClosingAccountModel') is not None:
            temp_model = GetClosingAccountsResponseBodyResultUnsealClosingAccountModel()
            self.unseal_closing_account_model = temp_model.from_map(m['unsealClosingAccountModel'])
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


