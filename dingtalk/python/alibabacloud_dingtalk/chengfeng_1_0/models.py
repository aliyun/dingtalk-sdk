# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import List, Dict


class OpenAnalyzeDataDTO(TeaModel):
    def __init__(
        self,
        dept_count: int = None,
        no_align_objective_count: int = None,
        no_key_action_count: int = None,
        objective_align_rate: float = None,
        objective_no_set_count: int = None,
        objective_risk_count: int = None,
        objective_set_rate: float = None,
        only_one_key_result_count: int = None,
        only_one_objective_count: int = None,
        progress_update_rate_last_15days: float = None,
        progress_update_rate_last_30days: float = None,
        progress_update_rate_last_7days: float = None,
    ):
        # 部门总人数
        self.dept_count = dept_count
        # 无对齐O人数
        self.no_align_objective_count = no_align_objective_count
        # 未关联关键行动人数
        self.no_key_action_count = no_key_action_count
        # 目标对齐率
        self.objective_align_rate = objective_align_rate
        # 目标未设定人数
        self.objective_no_set_count = objective_no_set_count
        # 有风险O的人数
        self.objective_risk_count = objective_risk_count
        # 目标设定率
        self.objective_set_rate = objective_set_rate
        # 只有1个KR的人数
        self.only_one_key_result_count = only_one_key_result_count
        # 只有1个O的人数
        self.only_one_objective_count = only_one_objective_count
        # 近15天进展更新率
        self.progress_update_rate_last_15days = progress_update_rate_last_15days
        # 近30天进展更新率
        self.progress_update_rate_last_30days = progress_update_rate_last_30days
        # 近7天进展更新率
        self.progress_update_rate_last_7days = progress_update_rate_last_7days

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_count is not None:
            result['deptCount'] = self.dept_count
        if self.no_align_objective_count is not None:
            result['noAlignObjectiveCount'] = self.no_align_objective_count
        if self.no_key_action_count is not None:
            result['noKeyActionCount'] = self.no_key_action_count
        if self.objective_align_rate is not None:
            result['objectiveAlignRate'] = self.objective_align_rate
        if self.objective_no_set_count is not None:
            result['objectiveNoSetCount'] = self.objective_no_set_count
        if self.objective_risk_count is not None:
            result['objectiveRiskCount'] = self.objective_risk_count
        if self.objective_set_rate is not None:
            result['objectiveSetRate'] = self.objective_set_rate
        if self.only_one_key_result_count is not None:
            result['onlyOneKeyResultCount'] = self.only_one_key_result_count
        if self.only_one_objective_count is not None:
            result['onlyOneObjectiveCount'] = self.only_one_objective_count
        if self.progress_update_rate_last_15days is not None:
            result['progressUpdateRateLast15Days'] = self.progress_update_rate_last_15days
        if self.progress_update_rate_last_30days is not None:
            result['progressUpdateRateLast30Days'] = self.progress_update_rate_last_30days
        if self.progress_update_rate_last_7days is not None:
            result['progressUpdateRateLast7Days'] = self.progress_update_rate_last_7days
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptCount') is not None:
            self.dept_count = m.get('deptCount')
        if m.get('noAlignObjectiveCount') is not None:
            self.no_align_objective_count = m.get('noAlignObjectiveCount')
        if m.get('noKeyActionCount') is not None:
            self.no_key_action_count = m.get('noKeyActionCount')
        if m.get('objectiveAlignRate') is not None:
            self.objective_align_rate = m.get('objectiveAlignRate')
        if m.get('objectiveNoSetCount') is not None:
            self.objective_no_set_count = m.get('objectiveNoSetCount')
        if m.get('objectiveRiskCount') is not None:
            self.objective_risk_count = m.get('objectiveRiskCount')
        if m.get('objectiveSetRate') is not None:
            self.objective_set_rate = m.get('objectiveSetRate')
        if m.get('onlyOneKeyResultCount') is not None:
            self.only_one_key_result_count = m.get('onlyOneKeyResultCount')
        if m.get('onlyOneObjectiveCount') is not None:
            self.only_one_objective_count = m.get('onlyOneObjectiveCount')
        if m.get('progressUpdateRateLast15Days') is not None:
            self.progress_update_rate_last_15days = m.get('progressUpdateRateLast15Days')
        if m.get('progressUpdateRateLast30Days') is not None:
            self.progress_update_rate_last_30days = m.get('progressUpdateRateLast30Days')
        if m.get('progressUpdateRateLast7Days') is not None:
            self.progress_update_rate_last_7days = m.get('progressUpdateRateLast7Days')
        return self


class OpenUserDTO(TeaModel):
    def __init__(
        self,
        id: str = None,
        name: str = None,
        user_id: str = None,
    ):
        # 用户id
        self.id = id
        # 用户名称
        self.name = name
        # 钉钉用户id
        self.user_id = user_id

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
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class TitleMention(TeaModel):
    def __init__(
        self,
        length: int = None,
        offset: int = None,
        user: OpenUserDTO = None,
    ):
        # 结束位置
        self.length = length
        # 开始位置
        self.offset = offset
        # “@人员”对象信息
        self.user = user

    def validate(self):
        if self.user:
            self.user.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.length is not None:
            result['length'] = self.length
        if self.offset is not None:
            result['offset'] = self.offset
        if self.user is not None:
            result['user'] = self.user.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('length') is not None:
            self.length = m.get('length')
        if m.get('offset') is not None:
            self.offset = m.get('offset')
        if m.get('user') is not None:
            temp_model = OpenUserDTO()
            self.user = temp_model.from_map(m['user'])
        return self


class OpenKeyResultDTO(TeaModel):
    def __init__(
        self,
        id: str = None,
        progress: int = None,
        status: int = None,
        title: str = None,
        title_mentions: List[TitleMention] = None,
        type: int = None,
    ):
        # 主键
        self.id = id
        # KR进度
        self.progress = progress
        # KR的状态:1:正常 3:风险
        self.status = status
        # 标题
        self.title = title
        # “@”对象列表
        self.title_mentions = title_mentions
        # KR类型
        self.type = type

    def validate(self):
        if self.title_mentions:
            for k in self.title_mentions:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.progress is not None:
            result['progress'] = self.progress
        if self.status is not None:
            result['status'] = self.status
        if self.title is not None:
            result['title'] = self.title
        result['titleMentions'] = []
        if self.title_mentions is not None:
            for k in self.title_mentions:
                result['titleMentions'].append(k.to_map() if k else None)
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('progress') is not None:
            self.progress = m.get('progress')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('title') is not None:
            self.title = m.get('title')
        self.title_mentions = []
        if m.get('titleMentions') is not None:
            for k in m.get('titleMentions'):
                temp_model = TitleMention()
                self.title_mentions.append(temp_model.from_map(k))
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class OpenPeriodDTO(TeaModel):
    def __init__(
        self,
        end_date: int = None,
        id: str = None,
        name: str = None,
        period_biz_type: str = None,
        start_date: int = None,
    ):
        # 结束日期
        self.end_date = end_date
        # 周期id
        self.id = id
        # 周期名称
        self.name = name
        # 周期类型
        self.period_biz_type = period_biz_type
        # 开始日期
        self.start_date = start_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.period_biz_type is not None:
            result['periodBizType'] = self.period_biz_type
        if self.start_date is not None:
            result['startDate'] = self.start_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('periodBizType') is not None:
            self.period_biz_type = m.get('periodBizType')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        return self


class OpenTeamDTO(TeaModel):
    def __init__(
        self,
        id: str = None,
        name: str = None,
        open_id: str = None,
    ):
        # 部门id
        self.id = id
        # 部门名称
        self.name = name
        # 钉钉对应部门编号
        self.open_id = open_id

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
        if self.open_id is not None:
            result['openId'] = self.open_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('openId') is not None:
            self.open_id = m.get('openId')
        return self


class OpenObjectiveDTO(TeaModel):
    def __init__(
        self,
        executor: OpenUserDTO = None,
        id: str = None,
        key_results: List[OpenKeyResultDTO] = None,
        period: OpenPeriodDTO = None,
        progress: int = None,
        status: int = None,
        teams: List[OpenTeamDTO] = None,
        title: str = None,
    ):
        # 负责人信息
        self.executor = executor
        # 主键
        self.id = id
        # KR列表
        self.key_results = key_results
        # 周期信息
        self.period = period
        # 进度
        self.progress = progress
        # 状态
        self.status = status
        # 团队信息列表
        self.teams = teams
        # 目标标题
        self.title = title

    def validate(self):
        if self.executor:
            self.executor.validate()
        if self.key_results:
            for k in self.key_results:
                if k:
                    k.validate()
        if self.period:
            self.period.validate()
        if self.teams:
            for k in self.teams:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.executor is not None:
            result['executor'] = self.executor.to_map()
        if self.id is not None:
            result['id'] = self.id
        result['keyResults'] = []
        if self.key_results is not None:
            for k in self.key_results:
                result['keyResults'].append(k.to_map() if k else None)
        if self.period is not None:
            result['period'] = self.period.to_map()
        if self.progress is not None:
            result['progress'] = self.progress
        if self.status is not None:
            result['status'] = self.status
        result['teams'] = []
        if self.teams is not None:
            for k in self.teams:
                result['teams'].append(k.to_map() if k else None)
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('executor') is not None:
            temp_model = OpenUserDTO()
            self.executor = temp_model.from_map(m['executor'])
        if m.get('id') is not None:
            self.id = m.get('id')
        self.key_results = []
        if m.get('keyResults') is not None:
            for k in m.get('keyResults'):
                temp_model = OpenKeyResultDTO()
                self.key_results.append(temp_model.from_map(k))
        if m.get('period') is not None:
            temp_model = OpenPeriodDTO()
            self.period = temp_model.from_map(m['period'])
        if m.get('progress') is not None:
            self.progress = m.get('progress')
        if m.get('status') is not None:
            self.status = m.get('status')
        self.teams = []
        if m.get('teams') is not None:
            for k in m.get('teams'):
                temp_model = OpenTeamDTO()
                self.teams.append(temp_model.from_map(k))
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class OpenProgressDTO(TeaModel):
    def __init__(
        self,
        created: int = None,
        creator: OpenUserDTO = None,
        html_content: str = None,
        id: str = None,
        modifier: OpenUserDTO = None,
        updated: int = None,
    ):
        # 创建时间戳
        self.created = created
        # 创建人信息
        self.creator = creator
        # 进展内容
        self.html_content = html_content
        # 主键
        self.id = id
        # 更新人信息
        self.modifier = modifier
        # 更新时间戳
        self.updated = updated

    def validate(self):
        if self.creator:
            self.creator.validate()
        if self.modifier:
            self.modifier.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.created is not None:
            result['created'] = self.created
        if self.creator is not None:
            result['creator'] = self.creator.to_map()
        if self.html_content is not None:
            result['htmlContent'] = self.html_content
        if self.id is not None:
            result['id'] = self.id
        if self.modifier is not None:
            result['modifier'] = self.modifier.to_map()
        if self.updated is not None:
            result['updated'] = self.updated
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('created') is not None:
            self.created = m.get('created')
        if m.get('creator') is not None:
            temp_model = OpenUserDTO()
            self.creator = temp_model.from_map(m['creator'])
        if m.get('htmlContent') is not None:
            self.html_content = m.get('htmlContent')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('modifier') is not None:
            temp_model = OpenUserDTO()
            self.modifier = temp_model.from_map(m['modifier'])
        if m.get('updated') is not None:
            self.updated = m.get('updated')
        return self


class GetAnalyzeDataHeaders(TeaModel):
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


class GetAnalyzeDataRequest(TeaModel):
    def __init__(
        self,
        period_ids: List[str] = None,
        dept_id: str = None,
    ):
        # 周期ID列表
        self.period_ids = period_ids
        # 部门编号(钉钉部门号)
        self.dept_id = dept_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.period_ids is not None:
            result['periodIds'] = self.period_ids
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('periodIds') is not None:
            self.period_ids = m.get('periodIds')
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        return self


class GetAnalyzeDataResponseBody(TeaModel):
    def __init__(
        self,
        content: OpenAnalyzeDataDTO = None,
        request_id: str = None,
        success: bool = None,
    ):
        self.content = content
        # Id of the request
        self.request_id = request_id
        self.success = success

    def validate(self):
        if self.content:
            self.content.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content.to_map()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            temp_model = OpenAnalyzeDataDTO()
            self.content = temp_model.from_map(m['content'])
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetAnalyzeDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetAnalyzeDataResponseBody = None,
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
            temp_model = GetAnalyzeDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetEmployeeInfoByWorkNoHeaders(TeaModel):
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


class GetEmployeeInfoByWorkNoRequest(TeaModel):
    def __init__(
        self,
        work_no: str = None,
    ):
        # 工号
        self.work_no = work_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.work_no is not None:
            result['workNo'] = self.work_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('workNo') is not None:
            self.work_no = m.get('workNo')
        return self


class GetEmployeeInfoByWorkNoResponseBodyContent(TeaModel):
    def __init__(
        self,
        name: str = None,
        work_no: str = None,
    ):
        # 员工姓名
        self.name = name
        # 员工工号
        self.work_no = work_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.work_no is not None:
            result['workNo'] = self.work_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('workNo') is not None:
            self.work_no = m.get('workNo')
        return self


class GetEmployeeInfoByWorkNoResponseBody(TeaModel):
    def __init__(
        self,
        content: GetEmployeeInfoByWorkNoResponseBodyContent = None,
        success: bool = None,
    ):
        # 请求返回数据对象
        self.content = content
        # 接口请求成功标识,成功为true,失败为false
        self.success = success

    def validate(self):
        if self.content:
            self.content.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            temp_model = GetEmployeeInfoByWorkNoResponseBodyContent()
            self.content = temp_model.from_map(m['content'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetEmployeeInfoByWorkNoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetEmployeeInfoByWorkNoResponseBody = None,
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
            temp_model = GetEmployeeInfoByWorkNoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetUserHeaders(TeaModel):
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


class GetUserRequest(TeaModel):
    def __init__(
        self,
        okr_user_id: str = None,
        user_id: str = None,
    ):
        # OKR系统内部用户id
        self.okr_user_id = okr_user_id
        # 钉钉UserId
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.okr_user_id is not None:
            result['okrUserId'] = self.okr_user_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('okrUserId') is not None:
            self.okr_user_id = m.get('okrUserId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetUserResponseBody(TeaModel):
    def __init__(
        self,
        content: OpenUserDTO = None,
        request_id: str = None,
        success: bool = None,
    ):
        self.content = content
        # Id of the request
        self.request_id = request_id
        self.success = success

    def validate(self):
        if self.content:
            self.content.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content.to_map()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            temp_model = OpenUserDTO()
            self.content = temp_model.from_map(m['content'])
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetUserResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetUserResponseBody = None,
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
            temp_model = GetUserResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListAnalyzePeriodsHeaders(TeaModel):
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


class ListAnalyzePeriodsResponseBody(TeaModel):
    def __init__(
        self,
        content: List[OpenPeriodDTO] = None,
        request_id: str = None,
        success: bool = None,
    ):
        self.content = content
        # Id of the request
        self.request_id = request_id
        self.success = success

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = OpenPeriodDTO()
                self.content.append(temp_model.from_map(k))
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class ListAnalyzePeriodsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListAnalyzePeriodsResponseBody = None,
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
            temp_model = ListAnalyzePeriodsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListObjectiveByIdsHeaders(TeaModel):
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


class ListObjectiveByIdsRequest(TeaModel):
    def __init__(
        self,
        objective_ids: List[str] = None,
    ):
        # 目标ID列表
        self.objective_ids = objective_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.objective_ids is not None:
            result['objectiveIds'] = self.objective_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('objectiveIds') is not None:
            self.objective_ids = m.get('objectiveIds')
        return self


class ListObjectiveByIdsResponseBody(TeaModel):
    def __init__(
        self,
        content: List[OpenObjectiveDTO] = None,
        request_id: str = None,
        success: bool = None,
    ):
        self.content = content
        # Id of the request
        self.request_id = request_id
        # 是否成功
        self.success = success

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = OpenObjectiveDTO()
                self.content.append(temp_model.from_map(k))
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class ListObjectiveByIdsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListObjectiveByIdsResponseBody = None,
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
            temp_model = ListObjectiveByIdsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListObjectiveByUserHeaders(TeaModel):
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


class ListObjectiveByUserRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        user_id: str = None,
    ):
        # 页数
        self.page_number = page_number
        # 页大小
        self.page_size = page_size
        # 钉钉userId
        self.user_id = user_id

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
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class ListObjectiveByUserResponseBodyContent(TeaModel):
    def __init__(
        self,
        count: int = None,
        objectives: List[OpenObjectiveDTO] = None,
    ):
        # 总数
        self.count = count
        self.objectives = objectives

    def validate(self):
        if self.objectives:
            for k in self.objectives:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.count is not None:
            result['count'] = self.count
        result['objectives'] = []
        if self.objectives is not None:
            for k in self.objectives:
                result['objectives'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('count') is not None:
            self.count = m.get('count')
        self.objectives = []
        if m.get('objectives') is not None:
            for k in m.get('objectives'):
                temp_model = OpenObjectiveDTO()
                self.objectives.append(temp_model.from_map(k))
        return self


class ListObjectiveByUserResponseBody(TeaModel):
    def __init__(
        self,
        content: ListObjectiveByUserResponseBodyContent = None,
        request_id: str = None,
        success: bool = None,
    ):
        # 请求返回数据对象
        self.content = content
        # Id of the request
        self.request_id = request_id
        # 接口请求是否成功
        self.success = success

    def validate(self):
        if self.content:
            self.content.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content.to_map()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            temp_model = ListObjectiveByUserResponseBodyContent()
            self.content = temp_model.from_map(m['content'])
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class ListObjectiveByUserResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListObjectiveByUserResponseBody = None,
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
            temp_model = ListObjectiveByUserResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListProgressByIdsHeaders(TeaModel):
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


class ListProgressByIdsRequest(TeaModel):
    def __init__(
        self,
        progress_ids: List[str] = None,
    ):
        # 进展ID列表
        self.progress_ids = progress_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.progress_ids is not None:
            result['progressIds'] = self.progress_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('progressIds') is not None:
            self.progress_ids = m.get('progressIds')
        return self


class ListProgressByIdsResponseBody(TeaModel):
    def __init__(
        self,
        content: List[OpenProgressDTO] = None,
        request_id: str = None,
        success: bool = None,
    ):
        self.content = content
        # Id of the request
        self.request_id = request_id
        self.success = success

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = OpenProgressDTO()
                self.content.append(temp_model.from_map(k))
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class ListProgressByIdsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListProgressByIdsResponseBody = None,
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
            temp_model = ListProgressByIdsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PageListObjectiveProgressHeaders(TeaModel):
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


class PageListObjectiveProgressRequest(TeaModel):
    def __init__(
        self,
        objective_id: str = None,
        page_number: int = None,
        page_size: int = None,
    ):
        # 目标id
        self.objective_id = objective_id
        # 页数
        self.page_number = page_number
        # 页大小
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.objective_id is not None:
            result['objectiveId'] = self.objective_id
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('objectiveId') is not None:
            self.objective_id = m.get('objectiveId')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class PageListObjectiveProgressResponseBodyContent(TeaModel):
    def __init__(
        self,
        count: int = None,
        progress_list: List[OpenProgressDTO] = None,
    ):
        self.count = count
        self.progress_list = progress_list

    def validate(self):
        if self.progress_list:
            for k in self.progress_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.count is not None:
            result['count'] = self.count
        result['progressList'] = []
        if self.progress_list is not None:
            for k in self.progress_list:
                result['progressList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('count') is not None:
            self.count = m.get('count')
        self.progress_list = []
        if m.get('progressList') is not None:
            for k in m.get('progressList'):
                temp_model = OpenProgressDTO()
                self.progress_list.append(temp_model.from_map(k))
        return self


class PageListObjectiveProgressResponseBody(TeaModel):
    def __init__(
        self,
        content: PageListObjectiveProgressResponseBodyContent = None,
        request_id: str = None,
        success: bool = None,
    ):
        self.content = content
        # Id of the request
        self.request_id = request_id
        self.success = success

    def validate(self):
        if self.content:
            self.content.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content.to_map()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            temp_model = PageListObjectiveProgressResponseBodyContent()
            self.content = temp_model.from_map(m['content'])
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class PageListObjectiveProgressResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: PageListObjectiveProgressResponseBody = None,
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
            temp_model = PageListObjectiveProgressResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class TransferUserObjectiveHeaders(TeaModel):
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


class TransferUserObjectiveRequest(TeaModel):
    def __init__(
        self,
        objective_id: str = None,
        target_user_id: str = None,
    ):
        # 目标ID
        self.objective_id = objective_id
        # 目标钉钉userId
        self.target_user_id = target_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.objective_id is not None:
            result['objectiveId'] = self.objective_id
        if self.target_user_id is not None:
            result['targetUserId'] = self.target_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('objectiveId') is not None:
            self.objective_id = m.get('objectiveId')
        if m.get('targetUserId') is not None:
            self.target_user_id = m.get('targetUserId')
        return self


class TransferUserObjectiveResponseBody(TeaModel):
    def __init__(
        self,
        content: bool = None,
        request_id: str = None,
        success: bool = None,
    ):
        # 转交是否成功
        self.content = content
        # Id of the request
        self.request_id = request_id
        # 返回结果
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class TransferUserObjectiveResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: TransferUserObjectiveResponseBody = None,
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
            temp_model = TransferUserObjectiveResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


