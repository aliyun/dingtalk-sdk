# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


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
        # 用户ID
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
        real_name: str = None,
        cert_no: str = None,
        main_dept_id: int = None,
        main_dept_name: str = None,
        employ_job_id: str = None,
        employ_job_id_label: str = None,
        employ_position_id: str = None,
        employ_position_id_label: str = None,
        employ_position_rank_id: str = None,
        employ_position_rank_id_label: str = None,
        hired_date: str = None,
        last_work_day: str = None,
        termination_reason_voluntary: List[str] = None,
        termination_reason_passive: List[str] = None,
        name: str = None,
    ):
        # 身份证姓名
        self.real_name = real_name
        # 身份证号码
        self.cert_no = cert_no
        # 主部门ID
        self.main_dept_id = main_dept_id
        # 主部门
        self.main_dept_name = main_dept_name
        # 职务ID
        self.employ_job_id = employ_job_id
        # 职务名称
        self.employ_job_id_label = employ_job_id_label
        # 职位ID
        self.employ_position_id = employ_position_id
        # 职位名称
        self.employ_position_id_label = employ_position_id_label
        # 职级ID
        self.employ_position_rank_id = employ_position_rank_id
        # 职级名称
        self.employ_position_rank_id_label = employ_position_rank_id_label
        # 入职日期
        self.hired_date = hired_date
        # 离职日期
        self.last_work_day = last_work_day
        # 主动离职原因
        self.termination_reason_voluntary = termination_reason_voluntary
        # 被动离职原因
        self.termination_reason_passive = termination_reason_passive
        # 姓名
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.real_name is not None:
            result['realName'] = self.real_name
        if self.cert_no is not None:
            result['certNO'] = self.cert_no
        if self.main_dept_id is not None:
            result['mainDeptId'] = self.main_dept_id
        if self.main_dept_name is not None:
            result['mainDeptName'] = self.main_dept_name
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
        if self.termination_reason_voluntary is not None:
            result['terminationReasonVoluntary'] = self.termination_reason_voluntary
        if self.termination_reason_passive is not None:
            result['terminationReasonPassive'] = self.termination_reason_passive
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('realName') is not None:
            self.real_name = m.get('realName')
        if m.get('certNO') is not None:
            self.cert_no = m.get('certNO')
        if m.get('mainDeptId') is not None:
            self.main_dept_id = m.get('mainDeptId')
        if m.get('mainDeptName') is not None:
            self.main_dept_name = m.get('mainDeptName')
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
        if m.get('terminationReasonVoluntary') is not None:
            self.termination_reason_voluntary = m.get('terminationReasonVoluntary')
        if m.get('terminationReasonPassive') is not None:
            self.termination_reason_passive = m.get('terminationReasonPassive')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class ECertQueryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ECertQueryResponseBody = None,
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
            temp_model = ECertQueryResponseBody()
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
        operate_user_id: str = None,
        next_token: int = None,
        max_results: int = None,
    ):
        # 操作人id
        self.operate_user_id = operate_user_id
        # 偏移量
        self.next_token = next_token
        # 最大值
        self.max_results = max_results

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operate_user_id is not None:
            result['operateUserId'] = self.operate_user_id
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operateUserId') is not None:
            self.operate_user_id = m.get('operateUserId')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        return self


class QueryCustomEntryProcessesResponseBodyList(TeaModel):
    def __init__(
        self,
        form_id: str = None,
        form_name: str = None,
        form_desc: str = None,
        short_url: str = None,
    ):
        self.form_id = form_id
        self.form_name = form_name
        self.form_desc = form_desc
        self.short_url = short_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.form_id is not None:
            result['formId'] = self.form_id
        if self.form_name is not None:
            result['formName'] = self.form_name
        if self.form_desc is not None:
            result['formDesc'] = self.form_desc
        if self.short_url is not None:
            result['shortUrl'] = self.short_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('formId') is not None:
            self.form_id = m.get('formId')
        if m.get('formName') is not None:
            self.form_name = m.get('formName')
        if m.get('formDesc') is not None:
            self.form_desc = m.get('formDesc')
        if m.get('shortUrl') is not None:
            self.short_url = m.get('shortUrl')
        return self


class QueryCustomEntryProcessesResponseBody(TeaModel):
    def __init__(
        self,
        next_token: int = None,
        has_more: bool = None,
        list: List[QueryCustomEntryProcessesResponseBodyList] = None,
    ):
        # 下次获取数据的起始游标
        self.next_token = next_token
        # 是否有更多
        self.has_more = has_more
        # 表单信息列表
        self.list = list

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
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = QueryCustomEntryProcessesResponseBodyList()
                self.list.append(temp_model.from_map(k))
        return self


class QueryCustomEntryProcessesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryCustomEntryProcessesResponseBody = None,
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
            temp_model = QueryCustomEntryProcessesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


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
        value: str = None,
        field_code: str = None,
    ):
        self.value = value
        self.field_code = field_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.value is not None:
            result['value'] = self.value
        if self.field_code is not None:
            result['fieldCode'] = self.field_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('value') is not None:
            self.value = m.get('value')
        if m.get('fieldCode') is not None:
            self.field_code = m.get('fieldCode')
        return self


class AddHrmPreentryRequestGroupsSections(TeaModel):
    def __init__(
        self,
        old_index: int = None,
        emp_field_volist: List[AddHrmPreentryRequestGroupsSectionsEmpFieldVOList] = None,
    ):
        self.old_index = old_index
        self.emp_field_volist = emp_field_volist

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
        if self.old_index is not None:
            result['oldIndex'] = self.old_index
        result['empFieldVOList'] = []
        if self.emp_field_volist is not None:
            for k in self.emp_field_volist:
                result['empFieldVOList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('oldIndex') is not None:
            self.old_index = m.get('oldIndex')
        self.emp_field_volist = []
        if m.get('empFieldVOList') is not None:
            for k in m.get('empFieldVOList'):
                temp_model = AddHrmPreentryRequestGroupsSectionsEmpFieldVOList()
                self.emp_field_volist.append(temp_model.from_map(k))
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
        pre_entry_time: int = None,
        name: str = None,
        mobile: str = None,
        agent_id: int = None,
        groups: List[AddHrmPreentryRequestGroups] = None,
    ):
        self.pre_entry_time = pre_entry_time
        self.name = name
        self.mobile = mobile
        self.agent_id = agent_id
        self.groups = groups

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
        if self.pre_entry_time is not None:
            result['preEntryTime'] = self.pre_entry_time
        if self.name is not None:
            result['name'] = self.name
        if self.mobile is not None:
            result['mobile'] = self.mobile
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        result['groups'] = []
        if self.groups is not None:
            for k in self.groups:
                result['groups'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('preEntryTime') is not None:
            self.pre_entry_time = m.get('preEntryTime')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('mobile') is not None:
            self.mobile = m.get('mobile')
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        self.groups = []
        if m.get('groups') is not None:
            for k in m.get('groups'):
                temp_model = AddHrmPreentryRequestGroups()
                self.groups.append(temp_model.from_map(k))
        return self


class AddHrmPreentryResponseBody(TeaModel):
    def __init__(
        self,
        tmp_user_id: str = None,
    ):
        # result
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
        body: AddHrmPreentryResponseBody = None,
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
            temp_model = AddHrmPreentryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


