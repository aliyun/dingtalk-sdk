# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import List, Dict


class CfEmploymentRecordResp(TeaModel):
    def __init__(
        self,
        dept_code: str = None,
        dept_name: str = None,
        employee_status: str = None,
        end_date: str = None,
        is_latest_record: bool = None,
        job_level_name: str = None,
        job_position_code: str = None,
        job_position_name: str = None,
        job_post_code: str = None,
        job_post_name: str = None,
        service_status: str = None,
        service_type: str = None,
        start_date: str = None,
        work_numbers: str = None,
    ):
        # This parameter is required.
        self.dept_code = dept_code
        # This parameter is required.
        self.dept_name = dept_name
        # This parameter is required.
        self.employee_status = employee_status
        # This parameter is required.
        self.end_date = end_date
        # This parameter is required.
        self.is_latest_record = is_latest_record
        # This parameter is required.
        self.job_level_name = job_level_name
        # This parameter is required.
        self.job_position_code = job_position_code
        # This parameter is required.
        self.job_position_name = job_position_name
        # This parameter is required.
        self.job_post_code = job_post_code
        # This parameter is required.
        self.job_post_name = job_post_name
        # This parameter is required.
        self.service_status = service_status
        # This parameter is required.
        self.service_type = service_type
        # This parameter is required.
        self.start_date = start_date
        # This parameter is required.
        self.work_numbers = work_numbers

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_code is not None:
            result['deptCode'] = self.dept_code
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.employee_status is not None:
            result['employeeStatus'] = self.employee_status
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.is_latest_record is not None:
            result['isLatestRecord'] = self.is_latest_record
        if self.job_level_name is not None:
            result['jobLevelName'] = self.job_level_name
        if self.job_position_code is not None:
            result['jobPositionCode'] = self.job_position_code
        if self.job_position_name is not None:
            result['jobPositionName'] = self.job_position_name
        if self.job_post_code is not None:
            result['jobPostCode'] = self.job_post_code
        if self.job_post_name is not None:
            result['jobPostName'] = self.job_post_name
        if self.service_status is not None:
            result['serviceStatus'] = self.service_status
        if self.service_type is not None:
            result['serviceType'] = self.service_type
        if self.start_date is not None:
            result['startDate'] = self.start_date
        if self.work_numbers is not None:
            result['workNumbers'] = self.work_numbers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptCode') is not None:
            self.dept_code = m.get('deptCode')
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('employeeStatus') is not None:
            self.employee_status = m.get('employeeStatus')
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('isLatestRecord') is not None:
            self.is_latest_record = m.get('isLatestRecord')
        if m.get('jobLevelName') is not None:
            self.job_level_name = m.get('jobLevelName')
        if m.get('jobPositionCode') is not None:
            self.job_position_code = m.get('jobPositionCode')
        if m.get('jobPositionName') is not None:
            self.job_position_name = m.get('jobPositionName')
        if m.get('jobPostCode') is not None:
            self.job_post_code = m.get('jobPostCode')
        if m.get('jobPostName') is not None:
            self.job_post_name = m.get('jobPostName')
        if m.get('serviceStatus') is not None:
            self.service_status = m.get('serviceStatus')
        if m.get('serviceType') is not None:
            self.service_type = m.get('serviceType')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        if m.get('workNumbers') is not None:
            self.work_numbers = m.get('workNumbers')
        return self


class CfJobLevelResp(TeaModel):
    def __init__(
        self,
        level: int = None,
        name: str = None,
        start_date: str = None,
        stop_date: str = None,
    ):
        # This parameter is required.
        self.level = level
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.start_date = start_date
        # This parameter is required.
        self.stop_date = stop_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.level is not None:
            result['level'] = self.level
        if self.name is not None:
            result['name'] = self.name
        if self.start_date is not None:
            result['startDate'] = self.start_date
        if self.stop_date is not None:
            result['stopDate'] = self.stop_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('level') is not None:
            self.level = m.get('level')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        if m.get('stopDate') is not None:
            self.stop_date = m.get('stopDate')
        return self


class CfJobPositionResp(TeaModel):
    def __init__(
        self,
        job_position_code: str = None,
        name: str = None,
    ):
        # This parameter is required.
        self.job_position_code = job_position_code
        # This parameter is required.
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.job_position_code is not None:
            result['jobPositionCode'] = self.job_position_code
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('jobPositionCode') is not None:
            self.job_position_code = m.get('jobPositionCode')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class CfJobPostResp(TeaModel):
    def __init__(
        self,
        job_post_code: str = None,
        name: str = None,
    ):
        # This parameter is required.
        self.job_post_code = job_post_code
        # This parameter is required.
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.job_post_code is not None:
            result['jobPostCode'] = self.job_post_code
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('jobPostCode') is not None:
            self.job_post_code = m.get('jobPostCode')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class CfOrgResp(TeaModel):
    def __init__(
        self,
        dept_code: str = None,
        dept_name: str = None,
        level: int = None,
        organization_code_path: str = None,
        organization_path: str = None,
        parent_dept_code: str = None,
    ):
        # This parameter is required.
        self.dept_code = dept_code
        # This parameter is required.
        self.dept_name = dept_name
        # This parameter is required.
        self.level = level
        # This parameter is required.
        self.organization_code_path = organization_code_path
        # This parameter is required.
        self.organization_path = organization_path
        # This parameter is required.
        self.parent_dept_code = parent_dept_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_code is not None:
            result['deptCode'] = self.dept_code
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.level is not None:
            result['level'] = self.level
        if self.organization_code_path is not None:
            result['organizationCodePath'] = self.organization_code_path
        if self.organization_path is not None:
            result['organizationPath'] = self.organization_path
        if self.parent_dept_code is not None:
            result['parentDeptCode'] = self.parent_dept_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptCode') is not None:
            self.dept_code = m.get('deptCode')
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('level') is not None:
            self.level = m.get('level')
        if m.get('organizationCodePath') is not None:
            self.organization_code_path = m.get('organizationCodePath')
        if m.get('organizationPath') is not None:
            self.organization_path = m.get('organizationPath')
        if m.get('parentDeptCode') is not None:
            self.parent_dept_code = m.get('parentDeptCode')
        return self


class CfStaffResp(TeaModel):
    def __init__(
        self,
        dept_code: str = None,
        dept_name: str = None,
        email: str = None,
        mobile: str = None,
        name: str = None,
        nick_name: str = None,
        work_numbers: str = None,
    ):
        # This parameter is required.
        self.dept_code = dept_code
        # This parameter is required.
        self.dept_name = dept_name
        # This parameter is required.
        self.email = email
        # This parameter is required.
        self.mobile = mobile
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.nick_name = nick_name
        # This parameter is required.
        self.work_numbers = work_numbers

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_code is not None:
            result['deptCode'] = self.dept_code
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.email is not None:
            result['email'] = self.email
        if self.mobile is not None:
            result['mobile'] = self.mobile
        if self.name is not None:
            result['name'] = self.name
        if self.nick_name is not None:
            result['nickName'] = self.nick_name
        if self.work_numbers is not None:
            result['workNumbers'] = self.work_numbers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptCode') is not None:
            self.dept_code = m.get('deptCode')
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('email') is not None:
            self.email = m.get('email')
        if m.get('mobile') is not None:
            self.mobile = m.get('mobile')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('nickName') is not None:
            self.nick_name = m.get('nickName')
        if m.get('workNumbers') is not None:
            self.work_numbers = m.get('workNumbers')
        return self


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
        # This parameter is required.
        self.dept_count = dept_count
        # This parameter is required.
        self.no_align_objective_count = no_align_objective_count
        # This parameter is required.
        self.no_key_action_count = no_key_action_count
        # This parameter is required.
        self.objective_align_rate = objective_align_rate
        # This parameter is required.
        self.objective_no_set_count = objective_no_set_count
        # This parameter is required.
        self.objective_risk_count = objective_risk_count
        # This parameter is required.
        self.objective_set_rate = objective_set_rate
        # This parameter is required.
        self.only_one_key_result_count = only_one_key_result_count
        # This parameter is required.
        self.only_one_objective_count = only_one_objective_count
        # This parameter is required.
        self.progress_update_rate_last_15days = progress_update_rate_last_15days
        # This parameter is required.
        self.progress_update_rate_last_30days = progress_update_rate_last_30days
        # This parameter is required.
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
        # This parameter is required.
        self.id = id
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
        # This parameter is required.
        self.length = length
        # This parameter is required.
        self.offset = offset
        # This parameter is required.
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
        # This parameter is required.
        self.id = id
        # This parameter is required.
        self.progress = progress
        # This parameter is required.
        self.status = status
        # This parameter is required.
        self.title = title
        # This parameter is required.
        self.title_mentions = title_mentions
        # This parameter is required.
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
        # This parameter is required.
        self.end_date = end_date
        # This parameter is required.
        self.id = id
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.period_biz_type = period_biz_type
        # This parameter is required.
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
        # This parameter is required.
        self.id = id
        # This parameter is required.
        self.name = name
        # This parameter is required.
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
        # This parameter is required.
        self.executor = executor
        # This parameter is required.
        self.id = id
        # This parameter is required.
        self.key_results = key_results
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.progress = progress
        # This parameter is required.
        self.status = status
        # This parameter is required.
        self.teams = teams
        # This parameter is required.
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
        # This parameter is required.
        self.created = created
        # This parameter is required.
        self.creator = creator
        # This parameter is required.
        self.html_content = html_content
        # This parameter is required.
        self.id = id
        # This parameter is required.
        self.modifier = modifier
        # This parameter is required.
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


class SlsLogResp(TeaModel):
    def __init__(
        self,
        action: str = None,
        entity: str = None,
        header: str = None,
        id: str = None,
        info: str = None,
        operator: str = None,
        tenant: str = None,
        tenant_id: str = None,
        time: int = None,
    ):
        # This parameter is required.
        self.action = action
        # This parameter is required.
        self.entity = entity
        # This parameter is required.
        self.header = header
        # This parameter is required.
        self.id = id
        # This parameter is required.
        self.info = info
        # This parameter is required.
        self.operator = operator
        # This parameter is required.
        self.tenant = tenant
        # This parameter is required.
        self.tenant_id = tenant_id
        # This parameter is required.
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
        if self.entity is not None:
            result['entity'] = self.entity
        if self.header is not None:
            result['header'] = self.header
        if self.id is not None:
            result['id'] = self.id
        if self.info is not None:
            result['info'] = self.info
        if self.operator is not None:
            result['operator'] = self.operator
        if self.tenant is not None:
            result['tenant'] = self.tenant
        if self.tenant_id is not None:
            result['tenantId'] = self.tenant_id
        if self.time is not None:
            result['time'] = self.time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('action') is not None:
            self.action = m.get('action')
        if m.get('entity') is not None:
            self.entity = m.get('entity')
        if m.get('header') is not None:
            self.header = m.get('header')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('info') is not None:
            self.info = m.get('info')
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        if m.get('tenant') is not None:
            self.tenant = m.get('tenant')
        if m.get('tenantId') is not None:
            self.tenant_id = m.get('tenantId')
        if m.get('time') is not None:
            self.time = m.get('time')
        return self


class GetAllJobLevelHeaders(TeaModel):
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


class GetAllJobLevelResponseBody(TeaModel):
    def __init__(
        self,
        content: List[CfJobLevelResp] = None,
        request_id: str = None,
    ):
        self.content = content
        self.request_id = request_id

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = CfJobLevelResp()
                self.content.append(temp_model.from_map(k))
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class GetAllJobLevelResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetAllJobLevelResponseBody = None,
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
            temp_model = GetAllJobLevelResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetAllJobPositionHeaders(TeaModel):
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


class GetAllJobPositionResponseBody(TeaModel):
    def __init__(
        self,
        content: List[CfJobPositionResp] = None,
        request_id: str = None,
    ):
        self.content = content
        self.request_id = request_id

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = CfJobPositionResp()
                self.content.append(temp_model.from_map(k))
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class GetAllJobPositionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetAllJobPositionResponseBody = None,
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
            temp_model = GetAllJobPositionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetAllJobPostHeaders(TeaModel):
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


class GetAllJobPostResponseBody(TeaModel):
    def __init__(
        self,
        content: List[CfJobPostResp] = None,
        request_id: str = None,
    ):
        # This parameter is required.
        self.content = content
        self.request_id = request_id

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = CfJobPostResp()
                self.content.append(temp_model.from_map(k))
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class GetAllJobPostResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetAllJobPostResponseBody = None,
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
            temp_model = GetAllJobPostResponseBody()
            self.body = temp_model.from_map(m['body'])
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
        self.period_ids = period_ids
        # This parameter is required.
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
        status_code: int = None,
        body: GetAnalyzeDataResponseBody = None,
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
            temp_model = GetAnalyzeDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetChildOrgListHeaders(TeaModel):
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


class GetChildOrgListRequest(TeaModel):
    def __init__(
        self,
        dept_code: str = None,
    ):
        # This parameter is required.
        self.dept_code = dept_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_code is not None:
            result['deptCode'] = self.dept_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptCode') is not None:
            self.dept_code = m.get('deptCode')
        return self


class GetChildOrgListResponseBody(TeaModel):
    def __init__(
        self,
        content: List[CfOrgResp] = None,
        request_id: str = None,
    ):
        self.content = content
        self.request_id = request_id

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = CfOrgResp()
                self.content.append(temp_model.from_map(k))
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class GetChildOrgListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetChildOrgListResponseBody = None,
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
            temp_model = GetChildOrgListResponseBody()
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
        self.name = name
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
        self.content = content
        # This parameter is required.
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
        status_code: int = None,
        body: GetEmployeeInfoByWorkNoResponseBody = None,
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
            temp_model = GetEmployeeInfoByWorkNoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetEmploymentRecordByWorkNoHeaders(TeaModel):
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


class GetEmploymentRecordByWorkNoResponseBody(TeaModel):
    def __init__(
        self,
        content: List[CfEmploymentRecordResp] = None,
        request_id: str = None,
    ):
        self.content = content
        self.request_id = request_id

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = CfEmploymentRecordResp()
                self.content.append(temp_model.from_map(k))
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class GetEmploymentRecordByWorkNoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetEmploymentRecordByWorkNoResponseBody = None,
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
            temp_model = GetEmploymentRecordByWorkNoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetJobPositionHeaders(TeaModel):
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


class GetJobPositionRequest(TeaModel):
    def __init__(
        self,
        job_position_code: str = None,
    ):
        # This parameter is required.
        self.job_position_code = job_position_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.job_position_code is not None:
            result['jobPositionCode'] = self.job_position_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('jobPositionCode') is not None:
            self.job_position_code = m.get('jobPositionCode')
        return self


class GetJobPositionResponseBodyContent(TeaModel):
    def __init__(
        self,
        description: str = None,
        establish_date: str = None,
        job_code: str = None,
        job_requirements: str = None,
        name: str = None,
        start_date: str = None,
        stop_date: str = None,
    ):
        self.description = description
        self.establish_date = establish_date
        # This parameter is required.
        self.job_code = job_code
        self.job_requirements = job_requirements
        # This parameter is required.
        self.name = name
        self.start_date = start_date
        self.stop_date = stop_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.description is not None:
            result['description'] = self.description
        if self.establish_date is not None:
            result['establishDate'] = self.establish_date
        if self.job_code is not None:
            result['jobCode'] = self.job_code
        if self.job_requirements is not None:
            result['jobRequirements'] = self.job_requirements
        if self.name is not None:
            result['name'] = self.name
        if self.start_date is not None:
            result['startDate'] = self.start_date
        if self.stop_date is not None:
            result['stopDate'] = self.stop_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('establishDate') is not None:
            self.establish_date = m.get('establishDate')
        if m.get('jobCode') is not None:
            self.job_code = m.get('jobCode')
        if m.get('jobRequirements') is not None:
            self.job_requirements = m.get('jobRequirements')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        if m.get('stopDate') is not None:
            self.stop_date = m.get('stopDate')
        return self


class GetJobPositionResponseBody(TeaModel):
    def __init__(
        self,
        content: GetJobPositionResponseBodyContent = None,
        request_id: str = None,
    ):
        self.content = content
        self.request_id = request_id

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            temp_model = GetJobPositionResponseBodyContent()
            self.content = temp_model.from_map(m['content'])
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class GetJobPositionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetJobPositionResponseBody = None,
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
            temp_model = GetJobPositionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetJobPostHeaders(TeaModel):
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


class GetJobPostRequest(TeaModel):
    def __init__(
        self,
        job_post_code: str = None,
    ):
        # This parameter is required.
        self.job_post_code = job_post_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.job_post_code is not None:
            result['jobPostCode'] = self.job_post_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('jobPostCode') is not None:
            self.job_post_code = m.get('jobPostCode')
        return self


class GetJobPostResponseBodyContent(TeaModel):
    def __init__(
        self,
        code: str = None,
        establish_date: str = None,
        name: str = None,
        start_date: str = None,
        stop_date: str = None,
    ):
        self.code = code
        # This parameter is required.
        self.establish_date = establish_date
        self.name = name
        # This parameter is required.
        self.start_date = start_date
        # This parameter is required.
        self.stop_date = stop_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.establish_date is not None:
            result['establishDate'] = self.establish_date
        if self.name is not None:
            result['name'] = self.name
        if self.start_date is not None:
            result['startDate'] = self.start_date
        if self.stop_date is not None:
            result['stopDate'] = self.stop_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('establishDate') is not None:
            self.establish_date = m.get('establishDate')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        if m.get('stopDate') is not None:
            self.stop_date = m.get('stopDate')
        return self


class GetJobPostResponseBody(TeaModel):
    def __init__(
        self,
        content: GetJobPostResponseBodyContent = None,
        request_id: str = None,
    ):
        self.content = content
        self.request_id = request_id

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            temp_model = GetJobPostResponseBodyContent()
            self.content = temp_model.from_map(m['content'])
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class GetJobPostResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetJobPostResponseBody = None,
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
            temp_model = GetJobPostResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetOrgInfoHeaders(TeaModel):
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


class GetOrgInfoRequest(TeaModel):
    def __init__(
        self,
        dept_code: str = None,
    ):
        # This parameter is required.
        self.dept_code = dept_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_code is not None:
            result['deptCode'] = self.dept_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptCode') is not None:
            self.dept_code = m.get('deptCode')
        return self


class GetOrgInfoResponseBodyContent(TeaModel):
    def __init__(
        self,
        dept_code: str = None,
        dept_name: str = None,
        dept_num: str = None,
        level: str = None,
        organization_code_path: str = None,
        organization_path: str = None,
        parent_dept_code: str = None,
        short_name: str = None,
        start_date: str = None,
        stop_date: str = None,
    ):
        self.dept_code = dept_code
        self.dept_name = dept_name
        self.dept_num = dept_num
        self.level = level
        self.organization_code_path = organization_code_path
        self.organization_path = organization_path
        self.parent_dept_code = parent_dept_code
        self.short_name = short_name
        self.start_date = start_date
        self.stop_date = stop_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_code is not None:
            result['deptCode'] = self.dept_code
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.dept_num is not None:
            result['deptNum'] = self.dept_num
        if self.level is not None:
            result['level'] = self.level
        if self.organization_code_path is not None:
            result['organizationCodePath'] = self.organization_code_path
        if self.organization_path is not None:
            result['organizationPath'] = self.organization_path
        if self.parent_dept_code is not None:
            result['parentDeptCode'] = self.parent_dept_code
        if self.short_name is not None:
            result['shortName'] = self.short_name
        if self.start_date is not None:
            result['startDate'] = self.start_date
        if self.stop_date is not None:
            result['stopDate'] = self.stop_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptCode') is not None:
            self.dept_code = m.get('deptCode')
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('deptNum') is not None:
            self.dept_num = m.get('deptNum')
        if m.get('level') is not None:
            self.level = m.get('level')
        if m.get('organizationCodePath') is not None:
            self.organization_code_path = m.get('organizationCodePath')
        if m.get('organizationPath') is not None:
            self.organization_path = m.get('organizationPath')
        if m.get('parentDeptCode') is not None:
            self.parent_dept_code = m.get('parentDeptCode')
        if m.get('shortName') is not None:
            self.short_name = m.get('shortName')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        if m.get('stopDate') is not None:
            self.stop_date = m.get('stopDate')
        return self


class GetOrgInfoResponseBody(TeaModel):
    def __init__(
        self,
        content: GetOrgInfoResponseBodyContent = None,
        request_id: str = None,
    ):
        self.content = content
        self.request_id = request_id

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            temp_model = GetOrgInfoResponseBodyContent()
            self.content = temp_model.from_map(m['content'])
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class GetOrgInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetOrgInfoResponseBody = None,
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
            temp_model = GetOrgInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetStaffInfoByWorkNoHeaders(TeaModel):
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


class GetStaffInfoByWorkNoRequest(TeaModel):
    def __init__(
        self,
        work_numbers: str = None,
    ):
        # This parameter is required.
        self.work_numbers = work_numbers

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.work_numbers is not None:
            result['workNumbers'] = self.work_numbers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('workNumbers') is not None:
            self.work_numbers = m.get('workNumbers')
        return self


class GetStaffInfoByWorkNoResponseBodyContent(TeaModel):
    def __init__(
        self,
        dept_code: str = None,
        dept_name: str = None,
        email: str = None,
        employ_type: str = None,
        employee_status: str = None,
        job_level_name: str = None,
        job_position_code: str = None,
        job_position_name: str = None,
        job_post_code: str = None,
        job_post_name: str = None,
        mobile: str = None,
        name: str = None,
        nick_name: str = None,
        work_numbers: str = None,
    ):
        # This parameter is required.
        self.dept_code = dept_code
        # This parameter is required.
        self.dept_name = dept_name
        # This parameter is required.
        self.email = email
        self.employ_type = employ_type
        self.employee_status = employee_status
        # This parameter is required.
        self.job_level_name = job_level_name
        self.job_position_code = job_position_code
        self.job_position_name = job_position_name
        # This parameter is required.
        self.job_post_code = job_post_code
        # This parameter is required.
        self.job_post_name = job_post_name
        # This parameter is required.
        self.mobile = mobile
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.nick_name = nick_name
        # This parameter is required.
        self.work_numbers = work_numbers

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_code is not None:
            result['deptCode'] = self.dept_code
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.email is not None:
            result['email'] = self.email
        if self.employ_type is not None:
            result['employType'] = self.employ_type
        if self.employee_status is not None:
            result['employeeStatus'] = self.employee_status
        if self.job_level_name is not None:
            result['jobLevelName'] = self.job_level_name
        if self.job_position_code is not None:
            result['jobPositionCode'] = self.job_position_code
        if self.job_position_name is not None:
            result['jobPositionName'] = self.job_position_name
        if self.job_post_code is not None:
            result['jobPostCode'] = self.job_post_code
        if self.job_post_name is not None:
            result['jobPostName'] = self.job_post_name
        if self.mobile is not None:
            result['mobile'] = self.mobile
        if self.name is not None:
            result['name'] = self.name
        if self.nick_name is not None:
            result['nickName'] = self.nick_name
        if self.work_numbers is not None:
            result['workNumbers'] = self.work_numbers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptCode') is not None:
            self.dept_code = m.get('deptCode')
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('email') is not None:
            self.email = m.get('email')
        if m.get('employType') is not None:
            self.employ_type = m.get('employType')
        if m.get('employeeStatus') is not None:
            self.employee_status = m.get('employeeStatus')
        if m.get('jobLevelName') is not None:
            self.job_level_name = m.get('jobLevelName')
        if m.get('jobPositionCode') is not None:
            self.job_position_code = m.get('jobPositionCode')
        if m.get('jobPositionName') is not None:
            self.job_position_name = m.get('jobPositionName')
        if m.get('jobPostCode') is not None:
            self.job_post_code = m.get('jobPostCode')
        if m.get('jobPostName') is not None:
            self.job_post_name = m.get('jobPostName')
        if m.get('mobile') is not None:
            self.mobile = m.get('mobile')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('nickName') is not None:
            self.nick_name = m.get('nickName')
        if m.get('workNumbers') is not None:
            self.work_numbers = m.get('workNumbers')
        return self


class GetStaffInfoByWorkNoResponseBody(TeaModel):
    def __init__(
        self,
        content: GetStaffInfoByWorkNoResponseBodyContent = None,
        request_id: str = None,
    ):
        self.content = content
        self.request_id = request_id

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            temp_model = GetStaffInfoByWorkNoResponseBodyContent()
            self.content = temp_model.from_map(m['content'])
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class GetStaffInfoByWorkNoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetStaffInfoByWorkNoResponseBody = None,
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
            temp_model = GetStaffInfoByWorkNoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetStaffPageQueryHeaders(TeaModel):
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


class GetStaffPageQueryRequest(TeaModel):
    def __init__(
        self,
        dept_code: str = None,
        name: str = None,
        page_number: int = None,
        page_size: int = None,
        work_no: str = None,
    ):
        self.dept_code = dept_code
        self.name = name
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
        self.page_size = page_size
        self.work_no = work_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_code is not None:
            result['deptCode'] = self.dept_code
        if self.name is not None:
            result['name'] = self.name
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.work_no is not None:
            result['workNo'] = self.work_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptCode') is not None:
            self.dept_code = m.get('deptCode')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('workNo') is not None:
            self.work_no = m.get('workNo')
        return self


class GetStaffPageQueryResponseBodyContent(TeaModel):
    def __init__(
        self,
        data: List[CfStaffResp] = None,
        page_number: int = None,
        page_size: int = None,
        total_count: int = None,
    ):
        self.data = data
        self.page_number = page_number
        self.page_size = page_size
        self.total_count = total_count

    def validate(self):
        if self.data:
            for k in self.data:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['data'] = []
        if self.data is not None:
            for k in self.data:
                result['data'].append(k.to_map() if k else None)
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = CfStaffResp()
                self.data.append(temp_model.from_map(k))
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class GetStaffPageQueryResponseBody(TeaModel):
    def __init__(
        self,
        content: GetStaffPageQueryResponseBodyContent = None,
        request_id: str = None,
    ):
        self.content = content
        self.request_id = request_id

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            temp_model = GetStaffPageQueryResponseBodyContent()
            self.content = temp_model.from_map(m['content'])
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class GetStaffPageQueryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetStaffPageQueryResponseBody = None,
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
            temp_model = GetStaffPageQueryResponseBody()
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
        self.okr_user_id = okr_user_id
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
        status_code: int = None,
        body: GetUserResponseBody = None,
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
        status_code: int = None,
        body: ListAnalyzePeriodsResponseBody = None,
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
        # This parameter is required.
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
        status_code: int = None,
        body: ListObjectiveByIdsResponseBody = None,
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
        self.page_number = page_number
        self.page_size = page_size
        # This parameter is required.
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
        self.content = content
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
        status_code: int = None,
        body: ListObjectiveByUserResponseBody = None,
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
        # This parameter is required.
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
        status_code: int = None,
        body: ListProgressByIdsResponseBody = None,
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
            temp_model = ListProgressByIdsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListSlsLogHeaders(TeaModel):
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


class ListSlsLogRequest(TeaModel):
    def __init__(
        self,
        app_code: str = None,
        end_time: int = None,
        page_number: int = None,
        page_size: int = None,
        start_time: int = None,
    ):
        # This parameter is required.
        self.app_code = app_code
        self.end_time = end_time
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
        self.page_size = page_size
        self.start_time = start_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_code is not None:
            result['appCode'] = self.app_code
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.start_time is not None:
            result['startTime'] = self.start_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appCode') is not None:
            self.app_code = m.get('appCode')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        return self


class ListSlsLogResponseBodyContent(TeaModel):
    def __init__(
        self,
        current_page_size: int = None,
        data: List[SlsLogResp] = None,
        page_number: int = None,
        page_size: int = None,
        pages: int = None,
        total_count: int = None,
    ):
        self.current_page_size = current_page_size
        self.data = data
        self.page_number = page_number
        self.page_size = page_size
        self.pages = pages
        self.total_count = total_count

    def validate(self):
        if self.data:
            for k in self.data:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.current_page_size is not None:
            result['currentPageSize'] = self.current_page_size
        result['data'] = []
        if self.data is not None:
            for k in self.data:
                result['data'].append(k.to_map() if k else None)
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.pages is not None:
            result['pages'] = self.pages
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('currentPageSize') is not None:
            self.current_page_size = m.get('currentPageSize')
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = SlsLogResp()
                self.data.append(temp_model.from_map(k))
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('pages') is not None:
            self.pages = m.get('pages')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class ListSlsLogResponseBody(TeaModel):
    def __init__(
        self,
        content: ListSlsLogResponseBodyContent = None,
        success: bool = None,
    ):
        self.content = content
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
            temp_model = ListSlsLogResponseBodyContent()
            self.content = temp_model.from_map(m['content'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class ListSlsLogResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListSlsLogResponseBody = None,
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
            temp_model = ListSlsLogResponseBody()
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
        # This parameter is required.
        self.objective_id = objective_id
        self.page_number = page_number
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
        status_code: int = None,
        body: PageListObjectiveProgressResponseBody = None,
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
        # This parameter is required.
        self.objective_id = objective_id
        # This parameter is required.
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
        self.content = content
        self.request_id = request_id
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
        status_code: int = None,
        body: TransferUserObjectiveResponseBody = None,
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
            temp_model = TransferUserObjectiveResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


