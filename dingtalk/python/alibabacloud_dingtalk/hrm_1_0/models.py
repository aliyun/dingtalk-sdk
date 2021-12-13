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
        rank_category_id: str = None,
        rank_code: str = None,
        rank_name: str = None,
        next_token: int = None,
        max_results: int = None,
    ):
        # 职级序列
        self.rank_category_id = rank_category_id
        # 职级编码
        self.rank_code = rank_code
        # 职级名称
        self.rank_name = rank_name
        # 标记当前开始读取的位置
        self.next_token = next_token
        # 本次读取的最大数据记录数量
        self.max_results = max_results

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.rank_category_id is not None:
            result['rankCategoryId'] = self.rank_category_id
        if self.rank_code is not None:
            result['rankCode'] = self.rank_code
        if self.rank_name is not None:
            result['rankName'] = self.rank_name
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('rankCategoryId') is not None:
            self.rank_category_id = m.get('rankCategoryId')
        if m.get('rankCode') is not None:
            self.rank_code = m.get('rankCode')
        if m.get('rankName') is not None:
            self.rank_name = m.get('rankName')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        return self


class QueryJobRanksResponseBodyList(TeaModel):
    def __init__(
        self,
        rank_id: str = None,
        rank_category_id: str = None,
        rank_code: str = None,
        rank_name: str = None,
        min_job_grade: int = None,
        max_job_grade: int = None,
        rank_description: str = None,
    ):
        # 职级ID
        self.rank_id = rank_id
        # 职级序列ID
        self.rank_category_id = rank_category_id
        # 职级编码
        self.rank_code = rank_code
        # 职级名称
        self.rank_name = rank_name
        # 最小等级
        self.min_job_grade = min_job_grade
        # 最大等级
        self.max_job_grade = max_job_grade
        # 职级描述
        self.rank_description = rank_description

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.rank_id is not None:
            result['rankId'] = self.rank_id
        if self.rank_category_id is not None:
            result['rankCategoryId'] = self.rank_category_id
        if self.rank_code is not None:
            result['rankCode'] = self.rank_code
        if self.rank_name is not None:
            result['rankName'] = self.rank_name
        if self.min_job_grade is not None:
            result['minJobGrade'] = self.min_job_grade
        if self.max_job_grade is not None:
            result['maxJobGrade'] = self.max_job_grade
        if self.rank_description is not None:
            result['rankDescription'] = self.rank_description
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('rankId') is not None:
            self.rank_id = m.get('rankId')
        if m.get('rankCategoryId') is not None:
            self.rank_category_id = m.get('rankCategoryId')
        if m.get('rankCode') is not None:
            self.rank_code = m.get('rankCode')
        if m.get('rankName') is not None:
            self.rank_name = m.get('rankName')
        if m.get('minJobGrade') is not None:
            self.min_job_grade = m.get('minJobGrade')
        if m.get('maxJobGrade') is not None:
            self.max_job_grade = m.get('maxJobGrade')
        if m.get('rankDescription') is not None:
            self.rank_description = m.get('rankDescription')
        return self


class QueryJobRanksResponseBody(TeaModel):
    def __init__(
        self,
        next_token: int = None,
        has_more: bool = None,
        list: List[QueryJobRanksResponseBodyList] = None,
    ):
        # 表示当前调用返回读取到的位置，空代表数据已经读取完毕
        self.next_token = next_token
        # 是否有更多数据
        self.has_more = has_more
        # 职级列表
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
                temp_model = QueryJobRanksResponseBodyList()
                self.list.append(temp_model.from_map(k))
        return self


class QueryJobRanksResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryJobRanksResponseBody = None,
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
        next_token: int = None,
        max_results: int = None,
    ):
        # 职务名称
        self.job_name = job_name
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
        if self.job_name is not None:
            result['jobName'] = self.job_name
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('jobName') is not None:
            self.job_name = m.get('jobName')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        return self


class QueryJobsResponseBodyList(TeaModel):
    def __init__(
        self,
        job_id: str = None,
        job_name: str = None,
        job_description: str = None,
    ):
        # 职务ID
        self.job_id = job_id
        # 职务名称
        self.job_name = job_name
        # 职务描述
        self.job_description = job_description

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.job_id is not None:
            result['jobId'] = self.job_id
        if self.job_name is not None:
            result['jobName'] = self.job_name
        if self.job_description is not None:
            result['jobDescription'] = self.job_description
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('jobId') is not None:
            self.job_id = m.get('jobId')
        if m.get('jobName') is not None:
            self.job_name = m.get('jobName')
        if m.get('jobDescription') is not None:
            self.job_description = m.get('jobDescription')
        return self


class QueryJobsResponseBody(TeaModel):
    def __init__(
        self,
        next_token: int = None,
        has_more: bool = None,
        list: List[QueryJobsResponseBodyList] = None,
    ):
        # 下次获取数据的起始游标
        self.next_token = next_token
        # 是否有更多数据
        self.has_more = has_more
        # 职务列表
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
                temp_model = QueryJobsResponseBodyList()
                self.list.append(temp_model.from_map(k))
        return self


class QueryJobsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryJobsResponseBody = None,
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
            temp_model = QueryJobsResponseBody()
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
        position_name: str = None,
        in_category_ids: List[str] = None,
        in_position_ids: List[str] = None,
        next_token: int = None,
        max_results: int = None,
    ):
        # 职位名称
        self.position_name = position_name
        # 职位类别列表
        self.in_category_ids = in_category_ids
        # 职位id列表
        self.in_position_ids = in_position_ids
        # 偏移量
        self.next_token = next_token
        # 一次查询获取记录数
        self.max_results = max_results

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.position_name is not None:
            result['positionName'] = self.position_name
        if self.in_category_ids is not None:
            result['inCategoryIds'] = self.in_category_ids
        if self.in_position_ids is not None:
            result['inPositionIds'] = self.in_position_ids
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('positionName') is not None:
            self.position_name = m.get('positionName')
        if m.get('inCategoryIds') is not None:
            self.in_category_ids = m.get('inCategoryIds')
        if m.get('inPositionIds') is not None:
            self.in_position_ids = m.get('inPositionIds')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        return self


class QueryPositionsResponseBodyList(TeaModel):
    def __init__(
        self,
        position_id: str = None,
        position_name: str = None,
        position_category_id: str = None,
        job_id: str = None,
        position_des: str = None,
        rank_id_list: List[str] = None,
        status: int = None,
    ):
        # 职位ID
        self.position_id = position_id
        # 职位名称
        self.position_name = position_name
        # 职位类别ID
        self.position_category_id = position_category_id
        # 所属职务ID
        self.job_id = job_id
        # 职位描述
        self.position_des = position_des
        # 职位对应职级列表
        self.rank_id_list = rank_id_list
        # 职位状态-0，启用；1，停用
        self.status = status

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
        if self.position_category_id is not None:
            result['positionCategoryId'] = self.position_category_id
        if self.job_id is not None:
            result['jobId'] = self.job_id
        if self.position_des is not None:
            result['positionDes'] = self.position_des
        if self.rank_id_list is not None:
            result['rankIdList'] = self.rank_id_list
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('positionId') is not None:
            self.position_id = m.get('positionId')
        if m.get('positionName') is not None:
            self.position_name = m.get('positionName')
        if m.get('positionCategoryId') is not None:
            self.position_category_id = m.get('positionCategoryId')
        if m.get('jobId') is not None:
            self.job_id = m.get('jobId')
        if m.get('positionDes') is not None:
            self.position_des = m.get('positionDes')
        if m.get('rankIdList') is not None:
            self.rank_id_list = m.get('rankIdList')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class QueryPositionsResponseBody(TeaModel):
    def __init__(
        self,
        next_token: int = None,
        has_more: bool = None,
        list: List[QueryPositionsResponseBodyList] = None,
    ):
        # 表示当前调用返回读取到的位置，空代表数据已经读取完毕
        self.next_token = next_token
        # 是否有更多数据
        self.has_more = has_more
        # 职位列表
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
                temp_model = QueryPositionsResponseBodyList()
                self.list.append(temp_model.from_map(k))
        return self


class QueryPositionsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryPositionsResponseBody = None,
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
            temp_model = QueryPositionsResponseBody()
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
        # 字段关系符
        self.operate = operate
        # 操作值
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
        field_code: str = None,
        join_type: str = None,
        condition_list: List[MasterDataQueryRequestQueryParamsConditionList] = None,
    ):
        # 需要筛选的字段
        self.field_code = field_code
        # 筛选条件连接类型
        self.join_type = join_type
        # 筛选条件
        self.condition_list = condition_list

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
        if self.field_code is not None:
            result['fieldCode'] = self.field_code
        if self.join_type is not None:
            result['joinType'] = self.join_type
        result['conditionList'] = []
        if self.condition_list is not None:
            for k in self.condition_list:
                result['conditionList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldCode') is not None:
            self.field_code = m.get('fieldCode')
        if m.get('joinType') is not None:
            self.join_type = m.get('joinType')
        self.condition_list = []
        if m.get('conditionList') is not None:
            for k in m.get('conditionList'):
                temp_model = MasterDataQueryRequestQueryParamsConditionList()
                self.condition_list.append(temp_model.from_map(k))
        return self


class MasterDataQueryRequest(TeaModel):
    def __init__(
        self,
        scope_code: str = None,
        view_entity_code: str = None,
        tenant_id: int = None,
        biz_uk: str = None,
        relation_ids: List[str] = None,
        opt_user_id: str = None,
        next_token: int = None,
        max_results: int = None,
        query_params: List[MasterDataQueryRequestQueryParams] = None,
    ):
        # 领域code 由钉钉分配
        self.scope_code = scope_code
        # 实体code
        self.view_entity_code = view_entity_code
        # 数据生产方的租户id，由钉钉分配
        self.tenant_id = tenant_id
        # 数据唯一键
        self.biz_uk = biz_uk
        # 关联id列表，一般为userId
        self.relation_ids = relation_ids
        # 当前操作人userId
        self.opt_user_id = opt_user_id
        # 分页查询的游标
        self.next_token = next_token
        # 分页查询每页数据条数
        self.max_results = max_results
        # 其他查询条件
        self.query_params = query_params

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
        if self.scope_code is not None:
            result['scopeCode'] = self.scope_code
        if self.view_entity_code is not None:
            result['viewEntityCode'] = self.view_entity_code
        if self.tenant_id is not None:
            result['tenantId'] = self.tenant_id
        if self.biz_uk is not None:
            result['bizUK'] = self.biz_uk
        if self.relation_ids is not None:
            result['relationIds'] = self.relation_ids
        if self.opt_user_id is not None:
            result['optUserId'] = self.opt_user_id
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        result['queryParams'] = []
        if self.query_params is not None:
            for k in self.query_params:
                result['queryParams'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('scopeCode') is not None:
            self.scope_code = m.get('scopeCode')
        if m.get('viewEntityCode') is not None:
            self.view_entity_code = m.get('viewEntityCode')
        if m.get('tenantId') is not None:
            self.tenant_id = m.get('tenantId')
        if m.get('bizUK') is not None:
            self.biz_uk = m.get('bizUK')
        if m.get('relationIds') is not None:
            self.relation_ids = m.get('relationIds')
        if m.get('optUserId') is not None:
            self.opt_user_id = m.get('optUserId')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        self.query_params = []
        if m.get('queryParams') is not None:
            for k in m.get('queryParams'):
                temp_model = MasterDataQueryRequestQueryParams()
                self.query_params.append(temp_model.from_map(k))
        return self


class MasterDataQueryResponseBodyResultViewEntityFieldVOListFieldDataVO(TeaModel):
    def __init__(
        self,
        key: str = None,
        value: str = None,
    ):
        # 字段值的key
        self.key = key
        # 字段值的文本
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
        # 字段code
        self.field_code = field_code
        # 字段值
        self.field_data_vo = field_data_vo
        # 字段名称
        self.field_name = field_name
        # 字段类型
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
        scope_code: str = None,
        view_entity_code: str = None,
        view_entity_field_volist: List[MasterDataQueryResponseBodyResultViewEntityFieldVOList] = None,
        relation_id: str = None,
    ):
        # 唯一id
        self.outer_id = outer_id
        # 领域
        self.scope_code = scope_code
        # 编码
        self.view_entity_code = view_entity_code
        # 字段列表
        self.view_entity_field_volist = view_entity_field_volist
        # 关联id列表，一般为userId
        self.relation_id = relation_id

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
        if self.scope_code is not None:
            result['scopeCode'] = self.scope_code
        if self.view_entity_code is not None:
            result['viewEntityCode'] = self.view_entity_code
        result['viewEntityFieldVOList'] = []
        if self.view_entity_field_volist is not None:
            for k in self.view_entity_field_volist:
                result['viewEntityFieldVOList'].append(k.to_map() if k else None)
        if self.relation_id is not None:
            result['relationId'] = self.relation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('outerId') is not None:
            self.outer_id = m.get('outerId')
        if m.get('scopeCode') is not None:
            self.scope_code = m.get('scopeCode')
        if m.get('viewEntityCode') is not None:
            self.view_entity_code = m.get('viewEntityCode')
        self.view_entity_field_volist = []
        if m.get('viewEntityFieldVOList') is not None:
            for k in m.get('viewEntityFieldVOList'):
                temp_model = MasterDataQueryResponseBodyResultViewEntityFieldVOList()
                self.view_entity_field_volist.append(temp_model.from_map(k))
        if m.get('relationId') is not None:
            self.relation_id = m.get('relationId')
        return self


class MasterDataQueryResponseBody(TeaModel):
    def __init__(
        self,
        total: int = None,
        has_more: bool = None,
        next_token: int = None,
        success: bool = None,
        result: List[MasterDataQueryResponseBodyResult] = None,
    ):
        # 总条目数
        self.total = total
        # 是否还有更多
        self.has_more = has_more
        # 分页游标
        self.next_token = next_token
        # 是否成功
        self.success = success
        # 结果
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
        if self.total is not None:
            result['total'] = self.total
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.success is not None:
            result['success'] = self.success
        result['result'] = []
        if self.result is not None:
            for k in self.result:
                result['result'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('total') is not None:
            self.total = m.get('total')
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('success') is not None:
            self.success = m.get('success')
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = MasterDataQueryResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class MasterDataQueryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: MasterDataQueryResponseBody = None,
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
            temp_model = MasterDataQueryResponseBody()
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


