# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class AddHrmPreentryHeaders(TeaModel):
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


class AddHrmPreentryRequestGroupsSectionsEmpFieldVOList(TeaModel):
    def __init__(
        self,
        field_code: str = None,
        value: str = None,
    ):
        self.field_code = field_code
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_code is not None:
            result['fieldCode'] = self.field_code
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldCode') is not None:
            self.field_code = m.get('fieldCode')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class AddHrmPreentryRequestGroupsSections(TeaModel):
    def __init__(
        self,
        emp_field_volist: List[AddHrmPreentryRequestGroupsSectionsEmpFieldVOList] = None,
        old_index: int = None,
    ):
        self.emp_field_volist = emp_field_volist
        self.old_index = old_index

    def validate(self):
        if self.emp_field_volist:
            for k in self.emp_field_volist:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['empFieldVOList'] = []
        if self.emp_field_volist is not None:
            for k in self.emp_field_volist:
                result['empFieldVOList'].append(k.to_map() if k else None)
        if self.old_index is not None:
            result['oldIndex'] = self.old_index
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.emp_field_volist = []
        if m.get('empFieldVOList') is not None:
            for k in m.get('empFieldVOList'):
                temp_model = AddHrmPreentryRequestGroupsSectionsEmpFieldVOList()
                self.emp_field_volist.append(temp_model.from_map(k))
        if m.get('oldIndex') is not None:
            self.old_index = m.get('oldIndex')
        return self


class AddHrmPreentryRequestGroups(TeaModel):
    def __init__(
        self,
        group_id: str = None,
        sections: List[AddHrmPreentryRequestGroupsSections] = None,
    ):
        self.group_id = group_id
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
        if self.group_id is not None:
            result['groupId'] = self.group_id
        result['sections'] = []
        if self.sections is not None:
            for k in self.sections:
                result['sections'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupId') is not None:
            self.group_id = m.get('groupId')
        self.sections = []
        if m.get('sections') is not None:
            for k in m.get('sections'):
                temp_model = AddHrmPreentryRequestGroupsSections()
                self.sections.append(temp_model.from_map(k))
        return self


class AddHrmPreentryRequest(TeaModel):
    def __init__(
        self,
        agent_id: int = None,
        groups: List[AddHrmPreentryRequestGroups] = None,
        mobile: str = None,
        name: str = None,
        need_send_pre_entry_msg: bool = None,
        pre_entry_time: int = None,
    ):
        self.agent_id = agent_id
        self.groups = groups
        self.mobile = mobile
        self.name = name
        self.need_send_pre_entry_msg = need_send_pre_entry_msg
        self.pre_entry_time = pre_entry_time

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
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        result['groups'] = []
        if self.groups is not None:
            for k in self.groups:
                result['groups'].append(k.to_map() if k else None)
        if self.mobile is not None:
            result['mobile'] = self.mobile
        if self.name is not None:
            result['name'] = self.name
        if self.need_send_pre_entry_msg is not None:
            result['needSendPreEntryMsg'] = self.need_send_pre_entry_msg
        if self.pre_entry_time is not None:
            result['preEntryTime'] = self.pre_entry_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        self.groups = []
        if m.get('groups') is not None:
            for k in m.get('groups'):
                temp_model = AddHrmPreentryRequestGroups()
                self.groups.append(temp_model.from_map(k))
        if m.get('mobile') is not None:
            self.mobile = m.get('mobile')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('needSendPreEntryMsg') is not None:
            self.need_send_pre_entry_msg = m.get('needSendPreEntryMsg')
        if m.get('preEntryTime') is not None:
            self.pre_entry_time = m.get('preEntryTime')
        return self


class AddHrmPreentryResponseBody(TeaModel):
    def __init__(
        self,
        tmp_user_id: str = None,
    ):
        self.tmp_user_id = tmp_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.tmp_user_id is not None:
            result['tmpUserId'] = self.tmp_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('tmpUserId') is not None:
            self.tmp_user_id = m.get('tmpUserId')
        return self


class AddHrmPreentryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AddHrmPreentryResponseBody = None,
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
            temp_model = AddHrmPreentryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeviceMarketManagerResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        self.request_id = request_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class DeviceMarketManagerResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeviceMarketManagerResponseBody = None,
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
            temp_model = DeviceMarketManagerResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeviceMarketOrderManagerResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        self.request_id = request_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class DeviceMarketOrderManagerResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeviceMarketOrderManagerResponseBody = None,
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
            temp_model = DeviceMarketOrderManagerResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ECertQueryHeaders(TeaModel):
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


class ECertQueryRequest(TeaModel):
    def __init__(
        self,
        user_id: str = None,
    ):
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class ECertQueryResponseBody(TeaModel):
    def __init__(
        self,
        cert_no: str = None,
        employ_job_id: str = None,
        employ_job_id_label: str = None,
        employ_position_id: str = None,
        employ_position_id_label: str = None,
        employ_position_rank_id: str = None,
        employ_position_rank_id_label: str = None,
        hired_date: str = None,
        last_work_day: str = None,
        main_dept_id: int = None,
        main_dept_name: str = None,
        name: str = None,
        real_name: str = None,
        termination_reason_passive: List[str] = None,
        termination_reason_voluntary: List[str] = None,
    ):
        self.cert_no = cert_no
        self.employ_job_id = employ_job_id
        self.employ_job_id_label = employ_job_id_label
        self.employ_position_id = employ_position_id
        self.employ_position_id_label = employ_position_id_label
        self.employ_position_rank_id = employ_position_rank_id
        self.employ_position_rank_id_label = employ_position_rank_id_label
        self.hired_date = hired_date
        self.last_work_day = last_work_day
        self.main_dept_id = main_dept_id
        self.main_dept_name = main_dept_name
        self.name = name
        self.real_name = real_name
        self.termination_reason_passive = termination_reason_passive
        self.termination_reason_voluntary = termination_reason_voluntary

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cert_no is not None:
            result['certNO'] = self.cert_no
        if self.employ_job_id is not None:
            result['employJobId'] = self.employ_job_id
        if self.employ_job_id_label is not None:
            result['employJobIdLabel'] = self.employ_job_id_label
        if self.employ_position_id is not None:
            result['employPositionId'] = self.employ_position_id
        if self.employ_position_id_label is not None:
            result['employPositionIdLabel'] = self.employ_position_id_label
        if self.employ_position_rank_id is not None:
            result['employPositionRankId'] = self.employ_position_rank_id
        if self.employ_position_rank_id_label is not None:
            result['employPositionRankIdLabel'] = self.employ_position_rank_id_label
        if self.hired_date is not None:
            result['hiredDate'] = self.hired_date
        if self.last_work_day is not None:
            result['lastWorkDay'] = self.last_work_day
        if self.main_dept_id is not None:
            result['mainDeptId'] = self.main_dept_id
        if self.main_dept_name is not None:
            result['mainDeptName'] = self.main_dept_name
        if self.name is not None:
            result['name'] = self.name
        if self.real_name is not None:
            result['realName'] = self.real_name
        if self.termination_reason_passive is not None:
            result['terminationReasonPassive'] = self.termination_reason_passive
        if self.termination_reason_voluntary is not None:
            result['terminationReasonVoluntary'] = self.termination_reason_voluntary
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('certNO') is not None:
            self.cert_no = m.get('certNO')
        if m.get('employJobId') is not None:
            self.employ_job_id = m.get('employJobId')
        if m.get('employJobIdLabel') is not None:
            self.employ_job_id_label = m.get('employJobIdLabel')
        if m.get('employPositionId') is not None:
            self.employ_position_id = m.get('employPositionId')
        if m.get('employPositionIdLabel') is not None:
            self.employ_position_id_label = m.get('employPositionIdLabel')
        if m.get('employPositionRankId') is not None:
            self.employ_position_rank_id = m.get('employPositionRankId')
        if m.get('employPositionRankIdLabel') is not None:
            self.employ_position_rank_id_label = m.get('employPositionRankIdLabel')
        if m.get('hiredDate') is not None:
            self.hired_date = m.get('hiredDate')
        if m.get('lastWorkDay') is not None:
            self.last_work_day = m.get('lastWorkDay')
        if m.get('mainDeptId') is not None:
            self.main_dept_id = m.get('mainDeptId')
        if m.get('mainDeptName') is not None:
            self.main_dept_name = m.get('mainDeptName')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('realName') is not None:
            self.real_name = m.get('realName')
        if m.get('terminationReasonPassive') is not None:
            self.termination_reason_passive = m.get('terminationReasonPassive')
        if m.get('terminationReasonVoluntary') is not None:
            self.termination_reason_voluntary = m.get('terminationReasonVoluntary')
        return self


class ECertQueryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ECertQueryResponseBody = None,
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
            temp_model = ECertQueryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class EsignRollbackHeaders(TeaModel):
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


class EsignRollbackRequest(TeaModel):
    def __init__(
        self,
        opt_user_id: str = None,
    ):
        self.opt_user_id = opt_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.opt_user_id is not None:
            result['optUserId'] = self.opt_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('optUserId') is not None:
            self.opt_user_id = m.get('optUserId')
        return self


class EsignRollbackResponseBody(TeaModel):
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


class EsignRollbackResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: EsignRollbackResponseBody = None,
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
            temp_model = EsignRollbackResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class HrmProcessRegularHeaders(TeaModel):
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


class HrmProcessRegularRequest(TeaModel):
    def __init__(
        self,
        operation_id: str = None,
        regular_date: int = None,
        remark: str = None,
        user_id: str = None,
    ):
        self.operation_id = operation_id
        self.regular_date = regular_date
        self.remark = remark
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operation_id is not None:
            result['operationId'] = self.operation_id
        if self.regular_date is not None:
            result['regularDate'] = self.regular_date
        if self.remark is not None:
            result['remark'] = self.remark
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operationId') is not None:
            self.operation_id = m.get('operationId')
        if m.get('regularDate') is not None:
            self.regular_date = m.get('regularDate')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class HrmProcessRegularResponseBody(TeaModel):
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


class HrmProcessRegularResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: HrmProcessRegularResponseBody = None,
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
            temp_model = HrmProcessRegularResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class HrmProcessTransferHeaders(TeaModel):
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


class HrmProcessTransferRequest(TeaModel):
    def __init__(
        self,
        dept_ids_after_transfer: List[int] = None,
        job_id_after_transfer: str = None,
        main_dept_id_after_transfer: int = None,
        operate_user_id: str = None,
        position_id_after_transfer: str = None,
        position_level_after_transfer: str = None,
        position_name_after_transfer: str = None,
        rank_id_after_transfer: str = None,
        user_id: str = None,
    ):
        self.dept_ids_after_transfer = dept_ids_after_transfer
        self.job_id_after_transfer = job_id_after_transfer
        self.main_dept_id_after_transfer = main_dept_id_after_transfer
        self.operate_user_id = operate_user_id
        self.position_id_after_transfer = position_id_after_transfer
        self.position_level_after_transfer = position_level_after_transfer
        self.position_name_after_transfer = position_name_after_transfer
        self.rank_id_after_transfer = rank_id_after_transfer
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_ids_after_transfer is not None:
            result['deptIdsAfterTransfer'] = self.dept_ids_after_transfer
        if self.job_id_after_transfer is not None:
            result['jobIdAfterTransfer'] = self.job_id_after_transfer
        if self.main_dept_id_after_transfer is not None:
            result['mainDeptIdAfterTransfer'] = self.main_dept_id_after_transfer
        if self.operate_user_id is not None:
            result['operateUserId'] = self.operate_user_id
        if self.position_id_after_transfer is not None:
            result['positionIdAfterTransfer'] = self.position_id_after_transfer
        if self.position_level_after_transfer is not None:
            result['positionLevelAfterTransfer'] = self.position_level_after_transfer
        if self.position_name_after_transfer is not None:
            result['positionNameAfterTransfer'] = self.position_name_after_transfer
        if self.rank_id_after_transfer is not None:
            result['rankIdAfterTransfer'] = self.rank_id_after_transfer
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptIdsAfterTransfer') is not None:
            self.dept_ids_after_transfer = m.get('deptIdsAfterTransfer')
        if m.get('jobIdAfterTransfer') is not None:
            self.job_id_after_transfer = m.get('jobIdAfterTransfer')
        if m.get('mainDeptIdAfterTransfer') is not None:
            self.main_dept_id_after_transfer = m.get('mainDeptIdAfterTransfer')
        if m.get('operateUserId') is not None:
            self.operate_user_id = m.get('operateUserId')
        if m.get('positionIdAfterTransfer') is not None:
            self.position_id_after_transfer = m.get('positionIdAfterTransfer')
        if m.get('positionLevelAfterTransfer') is not None:
            self.position_level_after_transfer = m.get('positionLevelAfterTransfer')
        if m.get('positionNameAfterTransfer') is not None:
            self.position_name_after_transfer = m.get('positionNameAfterTransfer')
        if m.get('rankIdAfterTransfer') is not None:
            self.rank_id_after_transfer = m.get('rankIdAfterTransfer')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class HrmProcessTransferResponseBody(TeaModel):
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


class HrmProcessTransferResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: HrmProcessTransferResponseBody = None,
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
            temp_model = HrmProcessTransferResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class HrmProcessUpdateTerminationInfoHeaders(TeaModel):
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


class HrmProcessUpdateTerminationInfoRequest(TeaModel):
    def __init__(
        self,
        dismission_memo: str = None,
        last_work_date: int = None,
        user_id: str = None,
    ):
        self.dismission_memo = dismission_memo
        self.last_work_date = last_work_date
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dismission_memo is not None:
            result['dismissionMemo'] = self.dismission_memo
        if self.last_work_date is not None:
            result['lastWorkDate'] = self.last_work_date
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dismissionMemo') is not None:
            self.dismission_memo = m.get('dismissionMemo')
        if m.get('lastWorkDate') is not None:
            self.last_work_date = m.get('lastWorkDate')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class HrmProcessUpdateTerminationInfoResponseBody(TeaModel):
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


class HrmProcessUpdateTerminationInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: HrmProcessUpdateTerminationInfoResponseBody = None,
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
            temp_model = HrmProcessUpdateTerminationInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class MasterDataQueryHeaders(TeaModel):
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


class MasterDataQueryRequestQueryParamsConditionList(TeaModel):
    def __init__(
        self,
        operate: str = None,
        value: str = None,
    ):
        self.operate = operate
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operate is not None:
            result['operate'] = self.operate
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operate') is not None:
            self.operate = m.get('operate')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class MasterDataQueryRequestQueryParams(TeaModel):
    def __init__(
        self,
        condition_list: List[MasterDataQueryRequestQueryParamsConditionList] = None,
        field_code: str = None,
        join_type: str = None,
    ):
        self.condition_list = condition_list
        self.field_code = field_code
        self.join_type = join_type

    def validate(self):
        if self.condition_list:
            for k in self.condition_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['conditionList'] = []
        if self.condition_list is not None:
            for k in self.condition_list:
                result['conditionList'].append(k.to_map() if k else None)
        if self.field_code is not None:
            result['fieldCode'] = self.field_code
        if self.join_type is not None:
            result['joinType'] = self.join_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.condition_list = []
        if m.get('conditionList') is not None:
            for k in m.get('conditionList'):
                temp_model = MasterDataQueryRequestQueryParamsConditionList()
                self.condition_list.append(temp_model.from_map(k))
        if m.get('fieldCode') is not None:
            self.field_code = m.get('fieldCode')
        if m.get('joinType') is not None:
            self.join_type = m.get('joinType')
        return self


class MasterDataQueryRequest(TeaModel):
    def __init__(
        self,
        biz_uk: str = None,
        max_results: int = None,
        next_token: int = None,
        opt_user_id: str = None,
        query_params: List[MasterDataQueryRequestQueryParams] = None,
        relation_ids: List[str] = None,
        scope_code: str = None,
        tenant_id: int = None,
        view_entity_code: str = None,
    ):
        self.biz_uk = biz_uk
        self.max_results = max_results
        self.next_token = next_token
        self.opt_user_id = opt_user_id
        self.query_params = query_params
        self.relation_ids = relation_ids
        self.scope_code = scope_code
        self.tenant_id = tenant_id
        self.view_entity_code = view_entity_code

    def validate(self):
        if self.query_params:
            for k in self.query_params:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_uk is not None:
            result['bizUK'] = self.biz_uk
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.opt_user_id is not None:
            result['optUserId'] = self.opt_user_id
        result['queryParams'] = []
        if self.query_params is not None:
            for k in self.query_params:
                result['queryParams'].append(k.to_map() if k else None)
        if self.relation_ids is not None:
            result['relationIds'] = self.relation_ids
        if self.scope_code is not None:
            result['scopeCode'] = self.scope_code
        if self.tenant_id is not None:
            result['tenantId'] = self.tenant_id
        if self.view_entity_code is not None:
            result['viewEntityCode'] = self.view_entity_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizUK') is not None:
            self.biz_uk = m.get('bizUK')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('optUserId') is not None:
            self.opt_user_id = m.get('optUserId')
        self.query_params = []
        if m.get('queryParams') is not None:
            for k in m.get('queryParams'):
                temp_model = MasterDataQueryRequestQueryParams()
                self.query_params.append(temp_model.from_map(k))
        if m.get('relationIds') is not None:
            self.relation_ids = m.get('relationIds')
        if m.get('scopeCode') is not None:
            self.scope_code = m.get('scopeCode')
        if m.get('tenantId') is not None:
            self.tenant_id = m.get('tenantId')
        if m.get('viewEntityCode') is not None:
            self.view_entity_code = m.get('viewEntityCode')
        return self


class MasterDataQueryResponseBodyResultViewEntityFieldVOListFieldDataVO(TeaModel):
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


class MasterDataQueryResponseBodyResultViewEntityFieldVOList(TeaModel):
    def __init__(
        self,
        field_code: str = None,
        field_data_vo: MasterDataQueryResponseBodyResultViewEntityFieldVOListFieldDataVO = None,
        field_name: str = None,
        field_type: str = None,
    ):
        self.field_code = field_code
        self.field_data_vo = field_data_vo
        self.field_name = field_name
        self.field_type = field_type

    def validate(self):
        if self.field_data_vo:
            self.field_data_vo.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_code is not None:
            result['fieldCode'] = self.field_code
        if self.field_data_vo is not None:
            result['fieldDataVO'] = self.field_data_vo.to_map()
        if self.field_name is not None:
            result['fieldName'] = self.field_name
        if self.field_type is not None:
            result['fieldType'] = self.field_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldCode') is not None:
            self.field_code = m.get('fieldCode')
        if m.get('fieldDataVO') is not None:
            temp_model = MasterDataQueryResponseBodyResultViewEntityFieldVOListFieldDataVO()
            self.field_data_vo = temp_model.from_map(m['fieldDataVO'])
        if m.get('fieldName') is not None:
            self.field_name = m.get('fieldName')
        if m.get('fieldType') is not None:
            self.field_type = m.get('fieldType')
        return self


class MasterDataQueryResponseBodyResult(TeaModel):
    def __init__(
        self,
        outer_id: str = None,
        relation_id: str = None,
        scope_code: str = None,
        view_entity_code: str = None,
        view_entity_field_volist: List[MasterDataQueryResponseBodyResultViewEntityFieldVOList] = None,
    ):
        self.outer_id = outer_id
        self.relation_id = relation_id
        self.scope_code = scope_code
        self.view_entity_code = view_entity_code
        self.view_entity_field_volist = view_entity_field_volist

    def validate(self):
        if self.view_entity_field_volist:
            for k in self.view_entity_field_volist:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.outer_id is not None:
            result['outerId'] = self.outer_id
        if self.relation_id is not None:
            result['relationId'] = self.relation_id
        if self.scope_code is not None:
            result['scopeCode'] = self.scope_code
        if self.view_entity_code is not None:
            result['viewEntityCode'] = self.view_entity_code
        result['viewEntityFieldVOList'] = []
        if self.view_entity_field_volist is not None:
            for k in self.view_entity_field_volist:
                result['viewEntityFieldVOList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('outerId') is not None:
            self.outer_id = m.get('outerId')
        if m.get('relationId') is not None:
            self.relation_id = m.get('relationId')
        if m.get('scopeCode') is not None:
            self.scope_code = m.get('scopeCode')
        if m.get('viewEntityCode') is not None:
            self.view_entity_code = m.get('viewEntityCode')
        self.view_entity_field_volist = []
        if m.get('viewEntityFieldVOList') is not None:
            for k in m.get('viewEntityFieldVOList'):
                temp_model = MasterDataQueryResponseBodyResultViewEntityFieldVOList()
                self.view_entity_field_volist.append(temp_model.from_map(k))
        return self


class MasterDataQueryResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        next_token: int = None,
        result: List[MasterDataQueryResponseBodyResult] = None,
        success: bool = None,
        total: int = None,
    ):
        self.has_more = has_more
        self.next_token = next_token
        self.result = result
        self.success = success
        self.total = total

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
        if self.success is not None:
            result['success'] = self.success
        if self.total is not None:
            result['total'] = self.total
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
                temp_model = MasterDataQueryResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        if m.get('success') is not None:
            self.success = m.get('success')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class MasterDataQueryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: MasterDataQueryResponseBody = None,
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
            temp_model = MasterDataQueryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class MasterDataSaveHeaders(TeaModel):
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


class MasterDataSaveRequestBodyFieldList(TeaModel):
    def __init__(
        self,
        name: str = None,
        value_str: str = None,
    ):
        self.name = name
        self.value_str = value_str

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.value_str is not None:
            result['valueStr'] = self.value_str
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('valueStr') is not None:
            self.value_str = m.get('valueStr')
        return self


class MasterDataSaveRequestBodyScope(TeaModel):
    def __init__(
        self,
        scope_code: str = None,
        version: int = None,
    ):
        self.scope_code = scope_code
        self.version = version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.scope_code is not None:
            result['scopeCode'] = self.scope_code
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('scopeCode') is not None:
            self.scope_code = m.get('scopeCode')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class MasterDataSaveRequestBody(TeaModel):
    def __init__(
        self,
        biz_time: int = None,
        biz_uk: str = None,
        entity_code: str = None,
        field_list: List[MasterDataSaveRequestBodyFieldList] = None,
        scope: MasterDataSaveRequestBodyScope = None,
        user_id: str = None,
    ):
        self.biz_time = biz_time
        self.biz_uk = biz_uk
        self.entity_code = entity_code
        self.field_list = field_list
        self.scope = scope
        self.user_id = user_id

    def validate(self):
        if self.field_list:
            for k in self.field_list:
                if k:
                    k.validate()
        if self.scope:
            self.scope.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_time is not None:
            result['bizTime'] = self.biz_time
        if self.biz_uk is not None:
            result['bizUk'] = self.biz_uk
        if self.entity_code is not None:
            result['entityCode'] = self.entity_code
        result['fieldList'] = []
        if self.field_list is not None:
            for k in self.field_list:
                result['fieldList'].append(k.to_map() if k else None)
        if self.scope is not None:
            result['scope'] = self.scope.to_map()
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizTime') is not None:
            self.biz_time = m.get('bizTime')
        if m.get('bizUk') is not None:
            self.biz_uk = m.get('bizUk')
        if m.get('entityCode') is not None:
            self.entity_code = m.get('entityCode')
        self.field_list = []
        if m.get('fieldList') is not None:
            for k in m.get('fieldList'):
                temp_model = MasterDataSaveRequestBodyFieldList()
                self.field_list.append(temp_model.from_map(k))
        if m.get('scope') is not None:
            temp_model = MasterDataSaveRequestBodyScope()
            self.scope = temp_model.from_map(m['scope'])
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class MasterDataSaveRequest(TeaModel):
    def __init__(
        self,
        body: List[MasterDataSaveRequestBody] = None,
        tenant_id: int = None,
    ):
        self.body = body
        self.tenant_id = tenant_id

    def validate(self):
        if self.body:
            for k in self.body:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['body'] = []
        if self.body is not None:
            for k in self.body:
                result['body'].append(k.to_map() if k else None)
        if self.tenant_id is not None:
            result['tenantId'] = self.tenant_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.body = []
        if m.get('body') is not None:
            for k in m.get('body'):
                temp_model = MasterDataSaveRequestBody()
                self.body.append(temp_model.from_map(k))
        if m.get('tenantId') is not None:
            self.tenant_id = m.get('tenantId')
        return self


class MasterDataSaveResponseBodyFailResult(TeaModel):
    def __init__(
        self,
        biz_uk: str = None,
        error_code: str = None,
        error_msg: str = None,
        success: bool = None,
    ):
        self.biz_uk = biz_uk
        self.error_code = error_code
        self.error_msg = error_msg
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_uk is not None:
            result['bizUk'] = self.biz_uk
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizUk') is not None:
            self.biz_uk = m.get('bizUk')
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class MasterDataSaveResponseBody(TeaModel):
    def __init__(
        self,
        all_success: bool = None,
        fail_result: List[MasterDataSaveResponseBodyFailResult] = None,
    ):
        self.all_success = all_success
        self.fail_result = fail_result

    def validate(self):
        if self.fail_result:
            for k in self.fail_result:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.all_success is not None:
            result['allSuccess'] = self.all_success
        result['failResult'] = []
        if self.fail_result is not None:
            for k in self.fail_result:
                result['failResult'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('allSuccess') is not None:
            self.all_success = m.get('allSuccess')
        self.fail_result = []
        if m.get('failResult') is not None:
            for k in m.get('failResult'):
                temp_model = MasterDataSaveResponseBodyFailResult()
                self.fail_result.append(temp_model.from_map(k))
        return self


class MasterDataSaveResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: MasterDataSaveResponseBody = None,
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
            temp_model = MasterDataSaveResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class MasterDataTenantQueyHeaders(TeaModel):
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


class MasterDataTenantQueyRequest(TeaModel):
    def __init__(
        self,
        entity_code: str = None,
        scope_code: str = None,
    ):
        self.entity_code = entity_code
        self.scope_code = scope_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.entity_code is not None:
            result['entityCode'] = self.entity_code
        if self.scope_code is not None:
            result['scopeCode'] = self.scope_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('entityCode') is not None:
            self.entity_code = m.get('entityCode')
        if m.get('scopeCode') is not None:
            self.scope_code = m.get('scopeCode')
        return self


class MasterDataTenantQueyResponseBodyResult(TeaModel):
    def __init__(
        self,
        has_data: bool = None,
        integrate_data_auth: bool = None,
        name: str = None,
        read_auth: bool = None,
        tenant_id: int = None,
        type: int = None,
    ):
        self.has_data = has_data
        self.integrate_data_auth = integrate_data_auth
        self.name = name
        self.read_auth = read_auth
        self.tenant_id = tenant_id
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_data is not None:
            result['hasData'] = self.has_data
        if self.integrate_data_auth is not None:
            result['integrateDataAuth'] = self.integrate_data_auth
        if self.name is not None:
            result['name'] = self.name
        if self.read_auth is not None:
            result['readAuth'] = self.read_auth
        if self.tenant_id is not None:
            result['tenantId'] = self.tenant_id
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasData') is not None:
            self.has_data = m.get('hasData')
        if m.get('integrateDataAuth') is not None:
            self.integrate_data_auth = m.get('integrateDataAuth')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('readAuth') is not None:
            self.read_auth = m.get('readAuth')
        if m.get('tenantId') is not None:
            self.tenant_id = m.get('tenantId')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class MasterDataTenantQueyResponseBody(TeaModel):
    def __init__(
        self,
        result: List[MasterDataTenantQueyResponseBodyResult] = None,
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
                temp_model = MasterDataTenantQueyResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class MasterDataTenantQueyResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: MasterDataTenantQueyResponseBody = None,
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
            temp_model = MasterDataTenantQueyResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class MasterDatasQueryHeaders(TeaModel):
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


class MasterDatasQueryRequestQueryParamsConditionList(TeaModel):
    def __init__(
        self,
        operate: str = None,
        value: str = None,
    ):
        self.operate = operate
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operate is not None:
            result['operate'] = self.operate
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operate') is not None:
            self.operate = m.get('operate')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class MasterDatasQueryRequestQueryParams(TeaModel):
    def __init__(
        self,
        condition_list: List[MasterDatasQueryRequestQueryParamsConditionList] = None,
        field_code: str = None,
        join_type: str = None,
    ):
        self.condition_list = condition_list
        self.field_code = field_code
        self.join_type = join_type

    def validate(self):
        if self.condition_list:
            for k in self.condition_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['conditionList'] = []
        if self.condition_list is not None:
            for k in self.condition_list:
                result['conditionList'].append(k.to_map() if k else None)
        if self.field_code is not None:
            result['fieldCode'] = self.field_code
        if self.join_type is not None:
            result['joinType'] = self.join_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.condition_list = []
        if m.get('conditionList') is not None:
            for k in m.get('conditionList'):
                temp_model = MasterDatasQueryRequestQueryParamsConditionList()
                self.condition_list.append(temp_model.from_map(k))
        if m.get('fieldCode') is not None:
            self.field_code = m.get('fieldCode')
        if m.get('joinType') is not None:
            self.join_type = m.get('joinType')
        return self


class MasterDatasQueryRequest(TeaModel):
    def __init__(
        self,
        biz_uk: str = None,
        max_results: int = None,
        next_token: int = None,
        query_params: List[MasterDatasQueryRequestQueryParams] = None,
        relation_ids: List[str] = None,
        scope_code: str = None,
        tenant_id: int = None,
        view_entity_code: str = None,
    ):
        self.biz_uk = biz_uk
        self.max_results = max_results
        self.next_token = next_token
        self.query_params = query_params
        self.relation_ids = relation_ids
        self.scope_code = scope_code
        self.tenant_id = tenant_id
        self.view_entity_code = view_entity_code

    def validate(self):
        if self.query_params:
            for k in self.query_params:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_uk is not None:
            result['bizUK'] = self.biz_uk
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['queryParams'] = []
        if self.query_params is not None:
            for k in self.query_params:
                result['queryParams'].append(k.to_map() if k else None)
        if self.relation_ids is not None:
            result['relationIds'] = self.relation_ids
        if self.scope_code is not None:
            result['scopeCode'] = self.scope_code
        if self.tenant_id is not None:
            result['tenantId'] = self.tenant_id
        if self.view_entity_code is not None:
            result['viewEntityCode'] = self.view_entity_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizUK') is not None:
            self.biz_uk = m.get('bizUK')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.query_params = []
        if m.get('queryParams') is not None:
            for k in m.get('queryParams'):
                temp_model = MasterDatasQueryRequestQueryParams()
                self.query_params.append(temp_model.from_map(k))
        if m.get('relationIds') is not None:
            self.relation_ids = m.get('relationIds')
        if m.get('scopeCode') is not None:
            self.scope_code = m.get('scopeCode')
        if m.get('tenantId') is not None:
            self.tenant_id = m.get('tenantId')
        if m.get('viewEntityCode') is not None:
            self.view_entity_code = m.get('viewEntityCode')
        return self


class MasterDatasQueryResponseBodyResultViewEntityFieldVOListFieldDataVO(TeaModel):
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


class MasterDatasQueryResponseBodyResultViewEntityFieldVOList(TeaModel):
    def __init__(
        self,
        field_code: str = None,
        field_data_vo: MasterDatasQueryResponseBodyResultViewEntityFieldVOListFieldDataVO = None,
        field_name: str = None,
        field_type: str = None,
    ):
        self.field_code = field_code
        self.field_data_vo = field_data_vo
        self.field_name = field_name
        self.field_type = field_type

    def validate(self):
        if self.field_data_vo:
            self.field_data_vo.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_code is not None:
            result['fieldCode'] = self.field_code
        if self.field_data_vo is not None:
            result['fieldDataVO'] = self.field_data_vo.to_map()
        if self.field_name is not None:
            result['fieldName'] = self.field_name
        if self.field_type is not None:
            result['fieldType'] = self.field_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldCode') is not None:
            self.field_code = m.get('fieldCode')
        if m.get('fieldDataVO') is not None:
            temp_model = MasterDatasQueryResponseBodyResultViewEntityFieldVOListFieldDataVO()
            self.field_data_vo = temp_model.from_map(m['fieldDataVO'])
        if m.get('fieldName') is not None:
            self.field_name = m.get('fieldName')
        if m.get('fieldType') is not None:
            self.field_type = m.get('fieldType')
        return self


class MasterDatasQueryResponseBodyResult(TeaModel):
    def __init__(
        self,
        outer_id: str = None,
        relation_id: str = None,
        scope_code: str = None,
        view_entity_code: str = None,
        view_entity_field_volist: List[MasterDatasQueryResponseBodyResultViewEntityFieldVOList] = None,
    ):
        self.outer_id = outer_id
        self.relation_id = relation_id
        self.scope_code = scope_code
        self.view_entity_code = view_entity_code
        self.view_entity_field_volist = view_entity_field_volist

    def validate(self):
        if self.view_entity_field_volist:
            for k in self.view_entity_field_volist:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.outer_id is not None:
            result['outerId'] = self.outer_id
        if self.relation_id is not None:
            result['relationId'] = self.relation_id
        if self.scope_code is not None:
            result['scopeCode'] = self.scope_code
        if self.view_entity_code is not None:
            result['viewEntityCode'] = self.view_entity_code
        result['viewEntityFieldVOList'] = []
        if self.view_entity_field_volist is not None:
            for k in self.view_entity_field_volist:
                result['viewEntityFieldVOList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('outerId') is not None:
            self.outer_id = m.get('outerId')
        if m.get('relationId') is not None:
            self.relation_id = m.get('relationId')
        if m.get('scopeCode') is not None:
            self.scope_code = m.get('scopeCode')
        if m.get('viewEntityCode') is not None:
            self.view_entity_code = m.get('viewEntityCode')
        self.view_entity_field_volist = []
        if m.get('viewEntityFieldVOList') is not None:
            for k in m.get('viewEntityFieldVOList'):
                temp_model = MasterDatasQueryResponseBodyResultViewEntityFieldVOList()
                self.view_entity_field_volist.append(temp_model.from_map(k))
        return self


class MasterDatasQueryResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        next_token: int = None,
        result: List[MasterDatasQueryResponseBodyResult] = None,
        success: bool = None,
        total: int = None,
    ):
        self.has_more = has_more
        self.next_token = next_token
        self.result = result
        self.success = success
        self.total = total

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
        if self.success is not None:
            result['success'] = self.success
        if self.total is not None:
            result['total'] = self.total
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
                temp_model = MasterDatasQueryResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        if m.get('success') is not None:
            self.success = m.get('success')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class MasterDatasQueryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: MasterDatasQueryResponseBody = None,
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
            temp_model = MasterDatasQueryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryCustomEntryProcessesHeaders(TeaModel):
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


class QueryCustomEntryProcessesRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: int = None,
        operate_user_id: str = None,
    ):
        self.max_results = max_results
        self.next_token = next_token
        self.operate_user_id = operate_user_id

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
        if self.operate_user_id is not None:
            result['operateUserId'] = self.operate_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('operateUserId') is not None:
            self.operate_user_id = m.get('operateUserId')
        return self


class QueryCustomEntryProcessesResponseBodyList(TeaModel):
    def __init__(
        self,
        form_desc: str = None,
        form_id: str = None,
        form_name: str = None,
        short_url: str = None,
    ):
        self.form_desc = form_desc
        self.form_id = form_id
        self.form_name = form_name
        self.short_url = short_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.form_desc is not None:
            result['formDesc'] = self.form_desc
        if self.form_id is not None:
            result['formId'] = self.form_id
        if self.form_name is not None:
            result['formName'] = self.form_name
        if self.short_url is not None:
            result['shortUrl'] = self.short_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('formDesc') is not None:
            self.form_desc = m.get('formDesc')
        if m.get('formId') is not None:
            self.form_id = m.get('formId')
        if m.get('formName') is not None:
            self.form_name = m.get('formName')
        if m.get('shortUrl') is not None:
            self.short_url = m.get('shortUrl')
        return self


class QueryCustomEntryProcessesResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[QueryCustomEntryProcessesResponseBodyList] = None,
        next_token: int = None,
    ):
        self.has_more = has_more
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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = QueryCustomEntryProcessesResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class QueryCustomEntryProcessesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryCustomEntryProcessesResponseBody = None,
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
            temp_model = QueryCustomEntryProcessesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryDismissionStaffIdListHeaders(TeaModel):
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


class QueryDismissionStaffIdListRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: int = None,
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


class QueryDismissionStaffIdListResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        next_token: int = None,
        user_id_list: List[str] = None,
    ):
        self.has_more = has_more
        self.next_token = next_token
        self.user_id_list = user_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.user_id_list is not None:
            result['userIdList'] = self.user_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('userIdList') is not None:
            self.user_id_list = m.get('userIdList')
        return self


class QueryDismissionStaffIdListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryDismissionStaffIdListResponseBody = None,
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
            temp_model = QueryDismissionStaffIdListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryHrmEmployeeDismissionInfoHeaders(TeaModel):
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


class QueryHrmEmployeeDismissionInfoRequest(TeaModel):
    def __init__(
        self,
        user_id_list: List[str] = None,
    ):
        self.user_id_list = user_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id_list is not None:
            result['userIdList'] = self.user_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userIdList') is not None:
            self.user_id_list = m.get('userIdList')
        return self


class QueryHrmEmployeeDismissionInfoShrinkRequest(TeaModel):
    def __init__(
        self,
        user_id_list_shrink: str = None,
    ):
        self.user_id_list_shrink = user_id_list_shrink

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id_list_shrink is not None:
            result['userIdList'] = self.user_id_list_shrink
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userIdList') is not None:
            self.user_id_list_shrink = m.get('userIdList')
        return self


class QueryHrmEmployeeDismissionInfoResponseBodyResultDeptList(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        dept_path: str = None,
    ):
        self.dept_id = dept_id
        self.dept_path = dept_path

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['dept_id'] = self.dept_id
        if self.dept_path is not None:
            result['dept_path'] = self.dept_path
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dept_id') is not None:
            self.dept_id = m.get('dept_id')
        if m.get('dept_path') is not None:
            self.dept_path = m.get('dept_path')
        return self


class QueryHrmEmployeeDismissionInfoResponseBodyResult(TeaModel):
    def __init__(
        self,
        dept_list: List[QueryHrmEmployeeDismissionInfoResponseBodyResultDeptList] = None,
        handover_user_id: str = None,
        last_work_day: int = None,
        main_dept_id: int = None,
        main_dept_name: str = None,
        name: str = None,
        passive_reason: List[str] = None,
        pre_status: int = None,
        reason_memo: str = None,
        status: int = None,
        user_id: str = None,
        voluntary_reason: List[str] = None,
    ):
        self.dept_list = dept_list
        self.handover_user_id = handover_user_id
        self.last_work_day = last_work_day
        self.main_dept_id = main_dept_id
        self.main_dept_name = main_dept_name
        self.name = name
        self.passive_reason = passive_reason
        self.pre_status = pre_status
        self.reason_memo = reason_memo
        self.status = status
        self.user_id = user_id
        self.voluntary_reason = voluntary_reason

    def validate(self):
        if self.dept_list:
            for k in self.dept_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['deptList'] = []
        if self.dept_list is not None:
            for k in self.dept_list:
                result['deptList'].append(k.to_map() if k else None)
        if self.handover_user_id is not None:
            result['handoverUserId'] = self.handover_user_id
        if self.last_work_day is not None:
            result['lastWorkDay'] = self.last_work_day
        if self.main_dept_id is not None:
            result['mainDeptId'] = self.main_dept_id
        if self.main_dept_name is not None:
            result['mainDeptName'] = self.main_dept_name
        if self.name is not None:
            result['name'] = self.name
        if self.passive_reason is not None:
            result['passiveReason'] = self.passive_reason
        if self.pre_status is not None:
            result['preStatus'] = self.pre_status
        if self.reason_memo is not None:
            result['reasonMemo'] = self.reason_memo
        if self.status is not None:
            result['status'] = self.status
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.voluntary_reason is not None:
            result['voluntaryReason'] = self.voluntary_reason
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.dept_list = []
        if m.get('deptList') is not None:
            for k in m.get('deptList'):
                temp_model = QueryHrmEmployeeDismissionInfoResponseBodyResultDeptList()
                self.dept_list.append(temp_model.from_map(k))
        if m.get('handoverUserId') is not None:
            self.handover_user_id = m.get('handoverUserId')
        if m.get('lastWorkDay') is not None:
            self.last_work_day = m.get('lastWorkDay')
        if m.get('mainDeptId') is not None:
            self.main_dept_id = m.get('mainDeptId')
        if m.get('mainDeptName') is not None:
            self.main_dept_name = m.get('mainDeptName')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('passiveReason') is not None:
            self.passive_reason = m.get('passiveReason')
        if m.get('preStatus') is not None:
            self.pre_status = m.get('preStatus')
        if m.get('reasonMemo') is not None:
            self.reason_memo = m.get('reasonMemo')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('voluntaryReason') is not None:
            self.voluntary_reason = m.get('voluntaryReason')
        return self


class QueryHrmEmployeeDismissionInfoResponseBody(TeaModel):
    def __init__(
        self,
        result: List[QueryHrmEmployeeDismissionInfoResponseBodyResult] = None,
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
                temp_model = QueryHrmEmployeeDismissionInfoResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class QueryHrmEmployeeDismissionInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryHrmEmployeeDismissionInfoResponseBody = None,
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
            temp_model = QueryHrmEmployeeDismissionInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryJobRanksHeaders(TeaModel):
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


class QueryJobRanksRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: int = None,
        rank_category_id: str = None,
        rank_code: str = None,
        rank_name: str = None,
    ):
        self.max_results = max_results
        self.next_token = next_token
        self.rank_category_id = rank_category_id
        self.rank_code = rank_code
        self.rank_name = rank_name

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
        if self.rank_category_id is not None:
            result['rankCategoryId'] = self.rank_category_id
        if self.rank_code is not None:
            result['rankCode'] = self.rank_code
        if self.rank_name is not None:
            result['rankName'] = self.rank_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('rankCategoryId') is not None:
            self.rank_category_id = m.get('rankCategoryId')
        if m.get('rankCode') is not None:
            self.rank_code = m.get('rankCode')
        if m.get('rankName') is not None:
            self.rank_name = m.get('rankName')
        return self


class QueryJobRanksResponseBodyList(TeaModel):
    def __init__(
        self,
        max_job_grade: int = None,
        min_job_grade: int = None,
        rank_category_id: str = None,
        rank_code: str = None,
        rank_description: str = None,
        rank_id: str = None,
        rank_name: str = None,
    ):
        self.max_job_grade = max_job_grade
        self.min_job_grade = min_job_grade
        self.rank_category_id = rank_category_id
        self.rank_code = rank_code
        self.rank_description = rank_description
        self.rank_id = rank_id
        self.rank_name = rank_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.max_job_grade is not None:
            result['maxJobGrade'] = self.max_job_grade
        if self.min_job_grade is not None:
            result['minJobGrade'] = self.min_job_grade
        if self.rank_category_id is not None:
            result['rankCategoryId'] = self.rank_category_id
        if self.rank_code is not None:
            result['rankCode'] = self.rank_code
        if self.rank_description is not None:
            result['rankDescription'] = self.rank_description
        if self.rank_id is not None:
            result['rankId'] = self.rank_id
        if self.rank_name is not None:
            result['rankName'] = self.rank_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxJobGrade') is not None:
            self.max_job_grade = m.get('maxJobGrade')
        if m.get('minJobGrade') is not None:
            self.min_job_grade = m.get('minJobGrade')
        if m.get('rankCategoryId') is not None:
            self.rank_category_id = m.get('rankCategoryId')
        if m.get('rankCode') is not None:
            self.rank_code = m.get('rankCode')
        if m.get('rankDescription') is not None:
            self.rank_description = m.get('rankDescription')
        if m.get('rankId') is not None:
            self.rank_id = m.get('rankId')
        if m.get('rankName') is not None:
            self.rank_name = m.get('rankName')
        return self


class QueryJobRanksResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[QueryJobRanksResponseBodyList] = None,
        next_token: int = None,
    ):
        self.has_more = has_more
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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = QueryJobRanksResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class QueryJobRanksResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryJobRanksResponseBody = None,
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
            temp_model = QueryJobRanksResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryJobsHeaders(TeaModel):
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


class QueryJobsRequest(TeaModel):
    def __init__(
        self,
        job_name: str = None,
        max_results: int = None,
        next_token: int = None,
    ):
        self.job_name = job_name
        self.max_results = max_results
        self.next_token = next_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.job_name is not None:
            result['jobName'] = self.job_name
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('jobName') is not None:
            self.job_name = m.get('jobName')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class QueryJobsResponseBodyList(TeaModel):
    def __init__(
        self,
        job_description: str = None,
        job_id: str = None,
        job_name: str = None,
    ):
        self.job_description = job_description
        self.job_id = job_id
        self.job_name = job_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.job_description is not None:
            result['jobDescription'] = self.job_description
        if self.job_id is not None:
            result['jobId'] = self.job_id
        if self.job_name is not None:
            result['jobName'] = self.job_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('jobDescription') is not None:
            self.job_description = m.get('jobDescription')
        if m.get('jobId') is not None:
            self.job_id = m.get('jobId')
        if m.get('jobName') is not None:
            self.job_name = m.get('jobName')
        return self


class QueryJobsResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[QueryJobsResponseBodyList] = None,
        next_token: int = None,
    ):
        self.has_more = has_more
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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = QueryJobsResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class QueryJobsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryJobsResponseBody = None,
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
            temp_model = QueryJobsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryPositionsHeaders(TeaModel):
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


class QueryPositionsRequest(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        in_category_ids: List[str] = None,
        in_position_ids: List[str] = None,
        position_name: str = None,
        max_results: int = None,
        next_token: int = None,
    ):
        self.dept_id = dept_id
        self.in_category_ids = in_category_ids
        self.in_position_ids = in_position_ids
        self.position_name = position_name
        self.max_results = max_results
        self.next_token = next_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.in_category_ids is not None:
            result['inCategoryIds'] = self.in_category_ids
        if self.in_position_ids is not None:
            result['inPositionIds'] = self.in_position_ids
        if self.position_name is not None:
            result['positionName'] = self.position_name
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('inCategoryIds') is not None:
            self.in_category_ids = m.get('inCategoryIds')
        if m.get('inPositionIds') is not None:
            self.in_position_ids = m.get('inPositionIds')
        if m.get('positionName') is not None:
            self.position_name = m.get('positionName')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class QueryPositionsResponseBodyList(TeaModel):
    def __init__(
        self,
        job_id: str = None,
        position_category_id: str = None,
        position_des: str = None,
        position_id: str = None,
        position_name: str = None,
        rank_id_list: List[str] = None,
        status: int = None,
    ):
        self.job_id = job_id
        self.position_category_id = position_category_id
        self.position_des = position_des
        self.position_id = position_id
        self.position_name = position_name
        self.rank_id_list = rank_id_list
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.job_id is not None:
            result['jobId'] = self.job_id
        if self.position_category_id is not None:
            result['positionCategoryId'] = self.position_category_id
        if self.position_des is not None:
            result['positionDes'] = self.position_des
        if self.position_id is not None:
            result['positionId'] = self.position_id
        if self.position_name is not None:
            result['positionName'] = self.position_name
        if self.rank_id_list is not None:
            result['rankIdList'] = self.rank_id_list
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('jobId') is not None:
            self.job_id = m.get('jobId')
        if m.get('positionCategoryId') is not None:
            self.position_category_id = m.get('positionCategoryId')
        if m.get('positionDes') is not None:
            self.position_des = m.get('positionDes')
        if m.get('positionId') is not None:
            self.position_id = m.get('positionId')
        if m.get('positionName') is not None:
            self.position_name = m.get('positionName')
        if m.get('rankIdList') is not None:
            self.rank_id_list = m.get('rankIdList')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class QueryPositionsResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[QueryPositionsResponseBodyList] = None,
        next_token: int = None,
    ):
        self.has_more = has_more
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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = QueryPositionsResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class QueryPositionsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryPositionsResponseBody = None,
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
            temp_model = QueryPositionsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RosterMetaAvailableFieldListHeaders(TeaModel):
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


class RosterMetaAvailableFieldListRequest(TeaModel):
    def __init__(
        self,
        app_agent_id: int = None,
    ):
        self.app_agent_id = app_agent_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_agent_id is not None:
            result['appAgentId'] = self.app_agent_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appAgentId') is not None:
            self.app_agent_id = m.get('appAgentId')
        return self


class RosterMetaAvailableFieldListResponseBodyResult(TeaModel):
    def __init__(
        self,
        field_code: str = None,
        field_name: str = None,
        field_type: str = None,
        option_text: str = None,
    ):
        self.field_code = field_code
        self.field_name = field_name
        self.field_type = field_type
        self.option_text = option_text

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_code is not None:
            result['fieldCode'] = self.field_code
        if self.field_name is not None:
            result['fieldName'] = self.field_name
        if self.field_type is not None:
            result['fieldType'] = self.field_type
        if self.option_text is not None:
            result['optionText'] = self.option_text
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldCode') is not None:
            self.field_code = m.get('fieldCode')
        if m.get('fieldName') is not None:
            self.field_name = m.get('fieldName')
        if m.get('fieldType') is not None:
            self.field_type = m.get('fieldType')
        if m.get('optionText') is not None:
            self.option_text = m.get('optionText')
        return self


class RosterMetaAvailableFieldListResponseBody(TeaModel):
    def __init__(
        self,
        result: List[RosterMetaAvailableFieldListResponseBodyResult] = None,
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
                temp_model = RosterMetaAvailableFieldListResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class RosterMetaAvailableFieldListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RosterMetaAvailableFieldListResponseBody = None,
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
            temp_model = RosterMetaAvailableFieldListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RosterMetaFieldOptionsUpdateHeaders(TeaModel):
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


class RosterMetaFieldOptionsUpdateRequest(TeaModel):
    def __init__(
        self,
        app_agent_id: int = None,
        field_code: str = None,
        group_id: str = None,
        labels: List[str] = None,
        modify_type: str = None,
    ):
        self.app_agent_id = app_agent_id
        self.field_code = field_code
        self.group_id = group_id
        self.labels = labels
        self.modify_type = modify_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_agent_id is not None:
            result['appAgentId'] = self.app_agent_id
        if self.field_code is not None:
            result['fieldCode'] = self.field_code
        if self.group_id is not None:
            result['groupId'] = self.group_id
        if self.labels is not None:
            result['labels'] = self.labels
        if self.modify_type is not None:
            result['modifyType'] = self.modify_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appAgentId') is not None:
            self.app_agent_id = m.get('appAgentId')
        if m.get('fieldCode') is not None:
            self.field_code = m.get('fieldCode')
        if m.get('groupId') is not None:
            self.group_id = m.get('groupId')
        if m.get('labels') is not None:
            self.labels = m.get('labels')
        if m.get('modifyType') is not None:
            self.modify_type = m.get('modifyType')
        return self


class RosterMetaFieldOptionsUpdateResponseBody(TeaModel):
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


class RosterMetaFieldOptionsUpdateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RosterMetaFieldOptionsUpdateResponseBody = None,
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
            temp_model = RosterMetaFieldOptionsUpdateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SendIsvCardMessageHeaders(TeaModel):
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


class SendIsvCardMessageRequest(TeaModel):
    def __init__(
        self,
        agent_id: int = None,
        biz_id: str = None,
        message_type: str = None,
        receiver_user_ids: List[str] = None,
        scene_type: str = None,
        scope: str = None,
        sender_user_id: str = None,
        value_map: Dict[str, str] = None,
    ):
        self.agent_id = agent_id
        self.biz_id = biz_id
        self.message_type = message_type
        self.receiver_user_ids = receiver_user_ids
        self.scene_type = scene_type
        self.scope = scope
        self.sender_user_id = sender_user_id
        self.value_map = value_map

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        if self.biz_id is not None:
            result['bizId'] = self.biz_id
        if self.message_type is not None:
            result['messageType'] = self.message_type
        if self.receiver_user_ids is not None:
            result['receiverUserIds'] = self.receiver_user_ids
        if self.scene_type is not None:
            result['sceneType'] = self.scene_type
        if self.scope is not None:
            result['scope'] = self.scope
        if self.sender_user_id is not None:
            result['senderUserId'] = self.sender_user_id
        if self.value_map is not None:
            result['valueMap'] = self.value_map
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        if m.get('messageType') is not None:
            self.message_type = m.get('messageType')
        if m.get('receiverUserIds') is not None:
            self.receiver_user_ids = m.get('receiverUserIds')
        if m.get('sceneType') is not None:
            self.scene_type = m.get('sceneType')
        if m.get('scope') is not None:
            self.scope = m.get('scope')
        if m.get('senderUserId') is not None:
            self.sender_user_id = m.get('senderUserId')
        if m.get('valueMap') is not None:
            self.value_map = m.get('valueMap')
        return self


class SendIsvCardMessageResponseBodyHrmInteractiveCardSendResult(TeaModel):
    def __init__(
        self,
        biz_id: str = None,
        error_code: str = None,
        error_msg: str = None,
    ):
        self.biz_id = biz_id
        self.error_code = error_code
        self.error_msg = error_msg

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_id is not None:
            result['bizId'] = self.biz_id
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        return self


class SendIsvCardMessageResponseBody(TeaModel):
    def __init__(
        self,
        error_code: str = None,
        error_msg: str = None,
        hrm_interactive_card_send_result: SendIsvCardMessageResponseBodyHrmInteractiveCardSendResult = None,
        request_id: str = None,
        success: bool = None,
    ):
        self.error_code = error_code
        self.error_msg = error_msg
        self.hrm_interactive_card_send_result = hrm_interactive_card_send_result
        self.request_id = request_id
        self.success = success

    def validate(self):
        if self.hrm_interactive_card_send_result:
            self.hrm_interactive_card_send_result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.hrm_interactive_card_send_result is not None:
            result['hrmInteractiveCardSendResult'] = self.hrm_interactive_card_send_result.to_map()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('hrmInteractiveCardSendResult') is not None:
            temp_model = SendIsvCardMessageResponseBodyHrmInteractiveCardSendResult()
            self.hrm_interactive_card_send_result = temp_model.from_map(m['hrmInteractiveCardSendResult'])
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class SendIsvCardMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SendIsvCardMessageResponseBody = None,
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
            temp_model = SendIsvCardMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SolutionTaskInitHeaders(TeaModel):
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


class SolutionTaskInitRequest(TeaModel):
    def __init__(
        self,
        category: str = None,
        claim_time: int = None,
        description: str = None,
        finish_time: int = None,
        outer_id: str = None,
        status: str = None,
        title: str = None,
        user_id: str = None,
        solution_type: str = None,
    ):
        self.category = category
        self.claim_time = claim_time
        self.description = description
        self.finish_time = finish_time
        self.outer_id = outer_id
        self.status = status
        self.title = title
        self.user_id = user_id
        self.solution_type = solution_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.category is not None:
            result['category'] = self.category
        if self.claim_time is not None:
            result['claimTime'] = self.claim_time
        if self.description is not None:
            result['description'] = self.description
        if self.finish_time is not None:
            result['finishTime'] = self.finish_time
        if self.outer_id is not None:
            result['outerId'] = self.outer_id
        if self.status is not None:
            result['status'] = self.status
        if self.title is not None:
            result['title'] = self.title
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.solution_type is not None:
            result['solutionType'] = self.solution_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('category') is not None:
            self.category = m.get('category')
        if m.get('claimTime') is not None:
            self.claim_time = m.get('claimTime')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('finishTime') is not None:
            self.finish_time = m.get('finishTime')
        if m.get('outerId') is not None:
            self.outer_id = m.get('outerId')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('solutionType') is not None:
            self.solution_type = m.get('solutionType')
        return self


class SolutionTaskInitResponseBody(TeaModel):
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


class SolutionTaskInitResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SolutionTaskInitResponseBody = None,
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
            temp_model = SolutionTaskInitResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SolutionTaskSaveHeaders(TeaModel):
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


class SolutionTaskSaveRequest(TeaModel):
    def __init__(
        self,
        claim_time: int = None,
        description: str = None,
        finish_time: int = None,
        outer_id: str = None,
        solution_instance_id: str = None,
        start_time: int = None,
        status: str = None,
        task_type: str = None,
        template_outer_id: str = None,
        title: str = None,
        user_id: str = None,
        solution_type: str = None,
    ):
        self.claim_time = claim_time
        self.description = description
        self.finish_time = finish_time
        self.outer_id = outer_id
        self.solution_instance_id = solution_instance_id
        self.start_time = start_time
        self.status = status
        self.task_type = task_type
        self.template_outer_id = template_outer_id
        self.title = title
        self.user_id = user_id
        self.solution_type = solution_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.claim_time is not None:
            result['claimTime'] = self.claim_time
        if self.description is not None:
            result['description'] = self.description
        if self.finish_time is not None:
            result['finishTime'] = self.finish_time
        if self.outer_id is not None:
            result['outerId'] = self.outer_id
        if self.solution_instance_id is not None:
            result['solutionInstanceId'] = self.solution_instance_id
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.status is not None:
            result['status'] = self.status
        if self.task_type is not None:
            result['taskType'] = self.task_type
        if self.template_outer_id is not None:
            result['templateOuterId'] = self.template_outer_id
        if self.title is not None:
            result['title'] = self.title
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.solution_type is not None:
            result['solutionType'] = self.solution_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('claimTime') is not None:
            self.claim_time = m.get('claimTime')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('finishTime') is not None:
            self.finish_time = m.get('finishTime')
        if m.get('outerId') is not None:
            self.outer_id = m.get('outerId')
        if m.get('solutionInstanceId') is not None:
            self.solution_instance_id = m.get('solutionInstanceId')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('taskType') is not None:
            self.task_type = m.get('taskType')
        if m.get('templateOuterId') is not None:
            self.template_outer_id = m.get('templateOuterId')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('solutionType') is not None:
            self.solution_type = m.get('solutionType')
        return self


class SolutionTaskSaveResponseBody(TeaModel):
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


class SolutionTaskSaveResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SolutionTaskSaveResponseBody = None,
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
            temp_model = SolutionTaskSaveResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SyncTaskTemplateHeaders(TeaModel):
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


class SyncTaskTemplateRequestTaskScopeVO(TeaModel):
    def __init__(
        self,
        dept_ids: List[int] = None,
        position_ids: List[str] = None,
        role_ids: List[str] = None,
        user_ids: List[str] = None,
    ):
        self.dept_ids = dept_ids
        self.position_ids = position_ids
        self.role_ids = role_ids
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_ids is not None:
            result['deptIds'] = self.dept_ids
        if self.position_ids is not None:
            result['positionIds'] = self.position_ids
        if self.role_ids is not None:
            result['roleIds'] = self.role_ids
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptIds') is not None:
            self.dept_ids = m.get('deptIds')
        if m.get('positionIds') is not None:
            self.position_ids = m.get('positionIds')
        if m.get('roleIds') is not None:
            self.role_ids = m.get('roleIds')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class SyncTaskTemplateRequest(TeaModel):
    def __init__(
        self,
        delete: bool = None,
        des: str = None,
        ext: str = None,
        name: str = None,
        opt_user_id: str = None,
        outer_id: str = None,
        task_scope_vo: SyncTaskTemplateRequestTaskScopeVO = None,
        task_type: str = None,
        solution_type: str = None,
    ):
        self.delete = delete
        self.des = des
        self.ext = ext
        self.name = name
        self.opt_user_id = opt_user_id
        self.outer_id = outer_id
        self.task_scope_vo = task_scope_vo
        self.task_type = task_type
        self.solution_type = solution_type

    def validate(self):
        if self.task_scope_vo:
            self.task_scope_vo.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.delete is not None:
            result['delete'] = self.delete
        if self.des is not None:
            result['des'] = self.des
        if self.ext is not None:
            result['ext'] = self.ext
        if self.name is not None:
            result['name'] = self.name
        if self.opt_user_id is not None:
            result['optUserId'] = self.opt_user_id
        if self.outer_id is not None:
            result['outerId'] = self.outer_id
        if self.task_scope_vo is not None:
            result['taskScopeVO'] = self.task_scope_vo.to_map()
        if self.task_type is not None:
            result['taskType'] = self.task_type
        if self.solution_type is not None:
            result['solutionType'] = self.solution_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('delete') is not None:
            self.delete = m.get('delete')
        if m.get('des') is not None:
            self.des = m.get('des')
        if m.get('ext') is not None:
            self.ext = m.get('ext')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('optUserId') is not None:
            self.opt_user_id = m.get('optUserId')
        if m.get('outerId') is not None:
            self.outer_id = m.get('outerId')
        if m.get('taskScopeVO') is not None:
            temp_model = SyncTaskTemplateRequestTaskScopeVO()
            self.task_scope_vo = temp_model.from_map(m['taskScopeVO'])
        if m.get('taskType') is not None:
            self.task_type = m.get('taskType')
        if m.get('solutionType') is not None:
            self.solution_type = m.get('solutionType')
        return self


class SyncTaskTemplateResponseBody(TeaModel):
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


class SyncTaskTemplateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SyncTaskTemplateResponseBody = None,
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
            temp_model = SyncTaskTemplateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateIsvCardMessageHeaders(TeaModel):
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


class UpdateIsvCardMessageRequest(TeaModel):
    def __init__(
        self,
        agent_id: int = None,
        biz_id: str = None,
        message_type: str = None,
        scene_type: str = None,
        scope: str = None,
        value_map: Dict[str, str] = None,
    ):
        self.agent_id = agent_id
        self.biz_id = biz_id
        self.message_type = message_type
        self.scene_type = scene_type
        self.scope = scope
        self.value_map = value_map

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        if self.biz_id is not None:
            result['bizId'] = self.biz_id
        if self.message_type is not None:
            result['messageType'] = self.message_type
        if self.scene_type is not None:
            result['sceneType'] = self.scene_type
        if self.scope is not None:
            result['scope'] = self.scope
        if self.value_map is not None:
            result['valueMap'] = self.value_map
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        if m.get('messageType') is not None:
            self.message_type = m.get('messageType')
        if m.get('sceneType') is not None:
            self.scene_type = m.get('sceneType')
        if m.get('scope') is not None:
            self.scope = m.get('scope')
        if m.get('valueMap') is not None:
            self.value_map = m.get('valueMap')
        return self


class UpdateIsvCardMessageResponseBody(TeaModel):
    def __init__(
        self,
        error_code: str = None,
        error_msg: str = None,
        request_id: str = None,
        success: bool = None,
    ):
        self.error_code = error_code
        self.error_msg = error_msg
        self.request_id = request_id
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class UpdateIsvCardMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateIsvCardMessageResponseBody = None,
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
            temp_model = UpdateIsvCardMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


