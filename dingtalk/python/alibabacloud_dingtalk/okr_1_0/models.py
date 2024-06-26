# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import List, Dict, BinaryIO


class OpenUserDTO(TeaModel):
    def __init__(
        self,
        ding_user_id: str = None,
        name: str = None,
        user_uid: str = None,
        work_no: str = None,
    ):
        self.ding_user_id = ding_user_id
        self.name = name
        self.user_uid = user_uid
        self.work_no = work_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_user_id is not None:
            result['dingUserId'] = self.ding_user_id
        if self.name is not None:
            result['name'] = self.name
        if self.user_uid is not None:
            result['userUid'] = self.user_uid
        if self.work_no is not None:
            result['workNo'] = self.work_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingUserId') is not None:
            self.ding_user_id = m.get('dingUserId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('userUid') is not None:
            self.user_uid = m.get('userUid')
        if m.get('workNo') is not None:
            self.work_no = m.get('workNo')
        return self


class TitleMention(TeaModel):
    def __init__(
        self,
        length: int = None,
        offset: int = None,
        user: OpenUserDTO = None,
    ):
        self.length = length
        self.offset = offset
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
        kr_id: str = None,
        progress: int = None,
        status: int = None,
        title: str = None,
        title_mentions: List[TitleMention] = None,
        type: int = None,
        weight: float = None,
    ):
        self.kr_id = kr_id
        self.progress = progress
        self.status = status
        self.title = title
        self.title_mentions = title_mentions
        self.type = type
        self.weight = weight

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
        if self.kr_id is not None:
            result['krId'] = self.kr_id
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
        if self.weight is not None:
            result['weight'] = self.weight
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('krId') is not None:
            self.kr_id = m.get('krId')
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
        if m.get('weight') is not None:
            self.weight = m.get('weight')
        return self


class OpenPeriodDTO(TeaModel):
    def __init__(
        self,
        end_date: int = None,
        name_cn: str = None,
        name_en: str = None,
        period_id: str = None,
        start_date: int = None,
        status: int = None,
    ):
        self.end_date = end_date
        self.name_cn = name_cn
        self.name_en = name_en
        # This parameter is required.
        self.period_id = period_id
        self.start_date = start_date
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.name_cn is not None:
            result['nameCn'] = self.name_cn
        if self.name_en is not None:
            result['nameEn'] = self.name_en
        if self.period_id is not None:
            result['periodId'] = self.period_id
        if self.start_date is not None:
            result['startDate'] = self.start_date
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('nameCn') is not None:
            self.name_cn = m.get('nameCn')
        if m.get('nameEn') is not None:
            self.name_en = m.get('nameEn')
        if m.get('periodId') is not None:
            self.period_id = m.get('periodId')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class OpenTeamDTO(TeaModel):
    def __init__(
        self,
        dept_uid: str = None,
        ding_dept_id: str = None,
        name: str = None,
    ):
        self.dept_uid = dept_uid
        self.ding_dept_id = ding_dept_id
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_uid is not None:
            result['deptUid'] = self.dept_uid
        if self.ding_dept_id is not None:
            result['dingDeptId'] = self.ding_dept_id
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptUid') is not None:
            self.dept_uid = m.get('deptUid')
        if m.get('dingDeptId') is not None:
            self.ding_dept_id = m.get('dingDeptId')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class OpenObjectiveDTO(TeaModel):
    def __init__(
        self,
        executor: OpenUserDTO = None,
        key_results: List[OpenKeyResultDTO] = None,
        objective_id: str = None,
        period: OpenPeriodDTO = None,
        progress: int = None,
        status: int = None,
        teams: List[OpenTeamDTO] = None,
        title: str = None,
        weight: float = None,
    ):
        self.executor = executor
        self.key_results = key_results
        self.objective_id = objective_id
        self.period = period
        self.progress = progress
        self.status = status
        self.teams = teams
        self.title = title
        self.weight = weight

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
        result['keyResults'] = []
        if self.key_results is not None:
            for k in self.key_results:
                result['keyResults'].append(k.to_map() if k else None)
        if self.objective_id is not None:
            result['objectiveId'] = self.objective_id
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
        if self.weight is not None:
            result['weight'] = self.weight
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('executor') is not None:
            temp_model = OpenUserDTO()
            self.executor = temp_model.from_map(m['executor'])
        self.key_results = []
        if m.get('keyResults') is not None:
            for k in m.get('keyResults'):
                temp_model = OpenKeyResultDTO()
                self.key_results.append(temp_model.from_map(k))
        if m.get('objectiveId') is not None:
            self.objective_id = m.get('objectiveId')
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
        if m.get('weight') is not None:
            self.weight = m.get('weight')
        return self


class AlignObjectiveHeaders(TeaModel):
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


class AlignObjectiveRequest(TeaModel):
    def __init__(
        self,
        period_id: str = None,
        target_id: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.period_id = period_id
        # This parameter is required.
        self.target_id = target_id
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.period_id is not None:
            result['periodId'] = self.period_id
        if self.target_id is not None:
            result['targetId'] = self.target_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('periodId') is not None:
            self.period_id = m.get('periodId')
        if m.get('targetId') is not None:
            self.target_id = m.get('targetId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class AlignObjectiveResponseBodyData(TeaModel):
    def __init__(
        self,
        align_id: BinaryIO = None,
        id: BinaryIO = None,
    ):
        self.align_id = align_id
        self.id = id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.align_id is not None:
            result['alignId'] = self.align_id
        if self.id is not None:
            result['id'] = self.id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('alignId') is not None:
            self.align_id = m.get('alignId')
        if m.get('id') is not None:
            self.id = m.get('id')
        return self


class AlignObjectiveResponseBody(TeaModel):
    def __init__(
        self,
        data: AlignObjectiveResponseBodyData = None,
        success: bool = None,
    ):
        self.data = data
        # This parameter is required.
        self.success = success

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            temp_model = AlignObjectiveResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class AlignObjectiveResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AlignObjectiveResponseBody = None,
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
            temp_model = AlignObjectiveResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BatchAddPermissionHeaders(TeaModel):
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


class BatchAddPermissionRequestListMember(TeaModel):
    def __init__(
        self,
        id: str = None,
        type: str = None,
    ):
        # This parameter is required.
        self.id = id
        # This parameter is required.
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class BatchAddPermissionRequestList(TeaModel):
    def __init__(
        self,
        member: BatchAddPermissionRequestListMember = None,
        policy_type: int = None,
    ):
        # This parameter is required.
        self.member = member
        # This parameter is required.
        self.policy_type = policy_type

    def validate(self):
        if self.member:
            self.member.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.member is not None:
            result['member'] = self.member.to_map()
        if self.policy_type is not None:
            result['policyType'] = self.policy_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('member') is not None:
            temp_model = BatchAddPermissionRequestListMember()
            self.member = temp_model.from_map(m['member'])
        if m.get('policyType') is not None:
            self.policy_type = m.get('policyType')
        return self


class BatchAddPermissionRequest(TeaModel):
    def __init__(
        self,
        list: List[BatchAddPermissionRequestList] = None,
        target_id: str = None,
        target_type: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.list = list
        # This parameter is required.
        self.target_id = target_id
        # This parameter is required.
        self.target_type = target_type
        # This parameter is required.
        self.user_id = user_id

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
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        if self.target_id is not None:
            result['targetId'] = self.target_id
        if self.target_type is not None:
            result['targetType'] = self.target_type
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = BatchAddPermissionRequestList()
                self.list.append(temp_model.from_map(k))
        if m.get('targetId') is not None:
            self.target_id = m.get('targetId')
        if m.get('targetType') is not None:
            self.target_type = m.get('targetType')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class BatchAddPermissionResponseBodyDataPermissionTreePolicyListMemberList(TeaModel):
    def __init__(
        self,
        id: str = None,
        nickname: str = None,
        type: str = None,
    ):
        # This parameter is required.
        self.id = id
        self.nickname = nickname
        # This parameter is required.
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.nickname is not None:
            result['nickname'] = self.nickname
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('nickname') is not None:
            self.nickname = m.get('nickname')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class BatchAddPermissionResponseBodyDataPermissionTreePolicyList(TeaModel):
    def __init__(
        self,
        member_list: List[BatchAddPermissionResponseBodyDataPermissionTreePolicyListMemberList] = None,
        name: str = None,
        type: int = None,
    ):
        # This parameter is required.
        self.member_list = member_list
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.type = type

    def validate(self):
        if self.member_list:
            for k in self.member_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['memberList'] = []
        if self.member_list is not None:
            for k in self.member_list:
                result['memberList'].append(k.to_map() if k else None)
        if self.name is not None:
            result['name'] = self.name
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.member_list = []
        if m.get('memberList') is not None:
            for k in m.get('memberList'):
                temp_model = BatchAddPermissionResponseBodyDataPermissionTreePolicyListMemberList()
                self.member_list.append(temp_model.from_map(k))
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class BatchAddPermissionResponseBodyDataPermissionTree(TeaModel):
    def __init__(
        self,
        id: str = None,
        policy_list: List[BatchAddPermissionResponseBodyDataPermissionTreePolicyList] = None,
        privacy: str = None,
        type: str = None,
    ):
        # This parameter is required.
        self.id = id
        # This parameter is required.
        self.policy_list = policy_list
        # This parameter is required.
        self.privacy = privacy
        # This parameter is required.
        self.type = type

    def validate(self):
        if self.policy_list:
            for k in self.policy_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        result['policyList'] = []
        if self.policy_list is not None:
            for k in self.policy_list:
                result['policyList'].append(k.to_map() if k else None)
        if self.privacy is not None:
            result['privacy'] = self.privacy
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        self.policy_list = []
        if m.get('policyList') is not None:
            for k in m.get('policyList'):
                temp_model = BatchAddPermissionResponseBodyDataPermissionTreePolicyList()
                self.policy_list.append(temp_model.from_map(k))
        if m.get('privacy') is not None:
            self.privacy = m.get('privacy')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class BatchAddPermissionResponseBodyData(TeaModel):
    def __init__(
        self,
        has_invalid_user: bool = None,
        permission_tree: BatchAddPermissionResponseBodyDataPermissionTree = None,
    ):
        # This parameter is required.
        self.has_invalid_user = has_invalid_user
        # This parameter is required.
        self.permission_tree = permission_tree

    def validate(self):
        if self.permission_tree:
            self.permission_tree.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_invalid_user is not None:
            result['hasInvalidUser'] = self.has_invalid_user
        if self.permission_tree is not None:
            result['permissionTree'] = self.permission_tree.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasInvalidUser') is not None:
            self.has_invalid_user = m.get('hasInvalidUser')
        if m.get('permissionTree') is not None:
            temp_model = BatchAddPermissionResponseBodyDataPermissionTree()
            self.permission_tree = temp_model.from_map(m['permissionTree'])
        return self


class BatchAddPermissionResponseBody(TeaModel):
    def __init__(
        self,
        data: BatchAddPermissionResponseBodyData = None,
        success: bool = None,
    ):
        # This parameter is required.
        self.data = data
        self.success = success

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            temp_model = BatchAddPermissionResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class BatchAddPermissionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BatchAddPermissionResponseBody = None,
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
            temp_model = BatchAddPermissionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BatchQueryObjectiveHeaders(TeaModel):
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


class BatchQueryObjectiveRequest(TeaModel):
    def __init__(
        self,
        objective_ids: List[str] = None,
        period_id: str = None,
        with_align: bool = None,
        with_kr: bool = None,
        with_progress: bool = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.objective_ids = objective_ids
        # This parameter is required.
        self.period_id = period_id
        self.with_align = with_align
        self.with_kr = with_kr
        # This parameter is required.
        self.with_progress = with_progress
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.objective_ids is not None:
            result['objectiveIds'] = self.objective_ids
        if self.period_id is not None:
            result['periodId'] = self.period_id
        if self.with_align is not None:
            result['withAlign'] = self.with_align
        if self.with_kr is not None:
            result['withKr'] = self.with_kr
        if self.with_progress is not None:
            result['withProgress'] = self.with_progress
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('objectiveIds') is not None:
            self.objective_ids = m.get('objectiveIds')
        if m.get('periodId') is not None:
            self.period_id = m.get('periodId')
        if m.get('withAlign') is not None:
            self.with_align = m.get('withAlign')
        if m.get('withKr') is not None:
            self.with_kr = m.get('withKr')
        if m.get('withProgress') is not None:
            self.with_progress = m.get('withProgress')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class BatchQueryObjectiveResponseBodyDataKrListProgress(TeaModel):
    def __init__(
        self,
        percent: int = None,
    ):
        self.percent = percent

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.percent is not None:
            result['percent'] = self.percent
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('percent') is not None:
            self.percent = m.get('percent')
        return self


class BatchQueryObjectiveResponseBodyDataKrList(TeaModel):
    def __init__(
        self,
        content: BinaryIO = None,
        gmt_create: float = None,
        gmt_modified: float = None,
        id: BinaryIO = None,
        objective_id: BinaryIO = None,
        permission: List[float] = None,
        position: int = None,
        progress: BatchQueryObjectiveResponseBodyDataKrListProgress = None,
        score: float = None,
        weight: float = None,
    ):
        self.content = content
        self.gmt_create = gmt_create
        self.gmt_modified = gmt_modified
        # This parameter is required.
        self.id = id
        self.objective_id = objective_id
        self.permission = permission
        self.position = position
        self.progress = progress
        self.score = score
        self.weight = weight

    def validate(self):
        if self.progress:
            self.progress.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.id is not None:
            result['id'] = self.id
        if self.objective_id is not None:
            result['objectiveId'] = self.objective_id
        if self.permission is not None:
            result['permission'] = self.permission
        if self.position is not None:
            result['position'] = self.position
        if self.progress is not None:
            result['progress'] = self.progress.to_map()
        if self.score is not None:
            result['score'] = self.score
        if self.weight is not None:
            result['weight'] = self.weight
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('objectiveId') is not None:
            self.objective_id = m.get('objectiveId')
        if m.get('permission') is not None:
            self.permission = m.get('permission')
        if m.get('position') is not None:
            self.position = m.get('position')
        if m.get('progress') is not None:
            temp_model = BatchQueryObjectiveResponseBodyDataKrListProgress()
            self.progress = temp_model.from_map(m['progress'])
        if m.get('score') is not None:
            self.score = m.get('score')
        if m.get('weight') is not None:
            self.weight = m.get('weight')
        return self


class BatchQueryObjectiveResponseBodyDataOwner(TeaModel):
    def __init__(
        self,
        avatar_media_id: BinaryIO = None,
        corp_id: BinaryIO = None,
        id: BinaryIO = None,
        nickname: BinaryIO = None,
        user_id: BinaryIO = None,
    ):
        self.avatar_media_id = avatar_media_id
        self.corp_id = corp_id
        self.id = id
        self.nickname = nickname
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.avatar_media_id is not None:
            result['avatarMediaId'] = self.avatar_media_id
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.id is not None:
            result['id'] = self.id
        if self.nickname is not None:
            result['nickname'] = self.nickname
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('avatarMediaId') is not None:
            self.avatar_media_id = m.get('avatarMediaId')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('nickname') is not None:
            self.nickname = m.get('nickname')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class BatchQueryObjectiveResponseBodyDataProgress(TeaModel):
    def __init__(
        self,
        percent: int = None,
    ):
        self.percent = percent

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.percent is not None:
            result['percent'] = self.percent
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('percent') is not None:
            self.percent = m.get('percent')
        return self


class BatchQueryObjectiveResponseBodyData(TeaModel):
    def __init__(
        self,
        align_from_ids: List[BinaryIO] = None,
        align_to_ids: List[BinaryIO] = None,
        content: BinaryIO = None,
        gmt_create: float = None,
        gmt_modified: float = None,
        id: BinaryIO = None,
        kr_list: List[BatchQueryObjectiveResponseBodyDataKrList] = None,
        owner: BatchQueryObjectiveResponseBodyDataOwner = None,
        period_id: BinaryIO = None,
        permission: List[float] = None,
        position: int = None,
        progress: BatchQueryObjectiveResponseBodyDataProgress = None,
        progress_percent: float = None,
        published: bool = None,
        score: float = None,
        status: int = None,
        user_id: BinaryIO = None,
        weight: float = None,
    ):
        self.align_from_ids = align_from_ids
        self.align_to_ids = align_to_ids
        self.content = content
        self.gmt_create = gmt_create
        self.gmt_modified = gmt_modified
        self.id = id
        self.kr_list = kr_list
        self.owner = owner
        self.period_id = period_id
        self.permission = permission
        self.position = position
        self.progress = progress
        self.progress_percent = progress_percent
        self.published = published
        self.score = score
        self.status = status
        self.user_id = user_id
        self.weight = weight

    def validate(self):
        if self.kr_list:
            for k in self.kr_list:
                if k:
                    k.validate()
        if self.owner:
            self.owner.validate()
        if self.progress:
            self.progress.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.align_from_ids is not None:
            result['alignFromIds'] = self.align_from_ids
        if self.align_to_ids is not None:
            result['alignToIds'] = self.align_to_ids
        if self.content is not None:
            result['content'] = self.content
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.id is not None:
            result['id'] = self.id
        result['krList'] = []
        if self.kr_list is not None:
            for k in self.kr_list:
                result['krList'].append(k.to_map() if k else None)
        if self.owner is not None:
            result['owner'] = self.owner.to_map()
        if self.period_id is not None:
            result['periodId'] = self.period_id
        if self.permission is not None:
            result['permission'] = self.permission
        if self.position is not None:
            result['position'] = self.position
        if self.progress is not None:
            result['progress'] = self.progress.to_map()
        if self.progress_percent is not None:
            result['progressPercent'] = self.progress_percent
        if self.published is not None:
            result['published'] = self.published
        if self.score is not None:
            result['score'] = self.score
        if self.status is not None:
            result['status'] = self.status
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.weight is not None:
            result['weight'] = self.weight
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('alignFromIds') is not None:
            self.align_from_ids = m.get('alignFromIds')
        if m.get('alignToIds') is not None:
            self.align_to_ids = m.get('alignToIds')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('id') is not None:
            self.id = m.get('id')
        self.kr_list = []
        if m.get('krList') is not None:
            for k in m.get('krList'):
                temp_model = BatchQueryObjectiveResponseBodyDataKrList()
                self.kr_list.append(temp_model.from_map(k))
        if m.get('owner') is not None:
            temp_model = BatchQueryObjectiveResponseBodyDataOwner()
            self.owner = temp_model.from_map(m['owner'])
        if m.get('periodId') is not None:
            self.period_id = m.get('periodId')
        if m.get('permission') is not None:
            self.permission = m.get('permission')
        if m.get('position') is not None:
            self.position = m.get('position')
        if m.get('progress') is not None:
            temp_model = BatchQueryObjectiveResponseBodyDataProgress()
            self.progress = temp_model.from_map(m['progress'])
        if m.get('progressPercent') is not None:
            self.progress_percent = m.get('progressPercent')
        if m.get('published') is not None:
            self.published = m.get('published')
        if m.get('score') is not None:
            self.score = m.get('score')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('weight') is not None:
            self.weight = m.get('weight')
        return self


class BatchQueryObjectiveResponseBody(TeaModel):
    def __init__(
        self,
        data: List[BatchQueryObjectiveResponseBodyData] = None,
        success: bool = None,
    ):
        self.data = data
        # This parameter is required.
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = BatchQueryObjectiveResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class BatchQueryObjectiveResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BatchQueryObjectiveResponseBody = None,
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
            temp_model = BatchQueryObjectiveResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BatchQueryUserHeaders(TeaModel):
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


class BatchQueryUserRequest(TeaModel):
    def __init__(
        self,
        okr_user_ids: List[str] = None,
        user_ids: List[str] = None,
    ):
        self.okr_user_ids = okr_user_ids
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.okr_user_ids is not None:
            result['okrUserIds'] = self.okr_user_ids
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('okrUserIds') is not None:
            self.okr_user_ids = m.get('okrUserIds')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class BatchQueryUserResponseBodyData(TeaModel):
    def __init__(
        self,
        avatar_media_id: BinaryIO = None,
        avatar_url: BinaryIO = None,
        corp_id: BinaryIO = None,
        id: BinaryIO = None,
        nickname: BinaryIO = None,
        user_id: BinaryIO = None,
    ):
        self.avatar_media_id = avatar_media_id
        # This parameter is required.
        self.avatar_url = avatar_url
        self.corp_id = corp_id
        self.id = id
        self.nickname = nickname
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.avatar_media_id is not None:
            result['avatarMediaId'] = self.avatar_media_id
        if self.avatar_url is not None:
            result['avatarUrl'] = self.avatar_url
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.id is not None:
            result['id'] = self.id
        if self.nickname is not None:
            result['nickname'] = self.nickname
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('avatarMediaId') is not None:
            self.avatar_media_id = m.get('avatarMediaId')
        if m.get('avatarUrl') is not None:
            self.avatar_url = m.get('avatarUrl')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('nickname') is not None:
            self.nickname = m.get('nickname')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class BatchQueryUserResponseBody(TeaModel):
    def __init__(
        self,
        data: List[BatchQueryUserResponseBodyData] = None,
        success: bool = None,
    ):
        # This parameter is required.
        self.data = data
        # This parameter is required.
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = BatchQueryUserResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class BatchQueryUserResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BatchQueryUserResponseBody = None,
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
            temp_model = BatchQueryUserResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateKeyResultHeaders(TeaModel):
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


class CreateKeyResultRequest(TeaModel):
    def __init__(
        self,
        content: str = None,
        objective_id: str = None,
        period_id: str = None,
        prev_position: int = None,
        weight: int = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.content = content
        # This parameter is required.
        self.objective_id = objective_id
        # This parameter is required.
        self.period_id = period_id
        self.prev_position = prev_position
        self.weight = weight
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.objective_id is not None:
            result['objectiveId'] = self.objective_id
        if self.period_id is not None:
            result['periodId'] = self.period_id
        if self.prev_position is not None:
            result['prevPosition'] = self.prev_position
        if self.weight is not None:
            result['weight'] = self.weight
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('objectiveId') is not None:
            self.objective_id = m.get('objectiveId')
        if m.get('periodId') is not None:
            self.period_id = m.get('periodId')
        if m.get('prevPosition') is not None:
            self.prev_position = m.get('prevPosition')
        if m.get('weight') is not None:
            self.weight = m.get('weight')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CreateKeyResultResponseBodyData(TeaModel):
    def __init__(
        self,
        id: BinaryIO = None,
        position: int = None,
        weight: int = None,
    ):
        # This parameter is required.
        self.id = id
        # This parameter is required.
        self.position = position
        # This parameter is required.
        self.weight = weight

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.position is not None:
            result['position'] = self.position
        if self.weight is not None:
            result['weight'] = self.weight
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('position') is not None:
            self.position = m.get('position')
        if m.get('weight') is not None:
            self.weight = m.get('weight')
        return self


class CreateKeyResultResponseBody(TeaModel):
    def __init__(
        self,
        data: CreateKeyResultResponseBodyData = None,
        success: bool = None,
    ):
        # This parameter is required.
        self.data = data
        # This parameter is required.
        self.success = success

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            temp_model = CreateKeyResultResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class CreateKeyResultResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateKeyResultResponseBody = None,
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
            temp_model = CreateKeyResultResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateObjectiveHeaders(TeaModel):
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


class CreateObjectiveRequest(TeaModel):
    def __init__(
        self,
        content: str = None,
        period_id: str = None,
        prev_position: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.content = content
        # This parameter is required.
        self.period_id = period_id
        # This parameter is required.
        self.prev_position = prev_position
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.period_id is not None:
            result['periodId'] = self.period_id
        if self.prev_position is not None:
            result['prevPosition'] = self.prev_position
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('periodId') is not None:
            self.period_id = m.get('periodId')
        if m.get('prevPosition') is not None:
            self.prev_position = m.get('prevPosition')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CreateObjectiveResponseBodyData(TeaModel):
    def __init__(
        self,
        id: str = None,
        position: str = None,
    ):
        # This parameter is required.
        self.id = id
        # This parameter is required.
        self.position = position

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.position is not None:
            result['position'] = self.position
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('position') is not None:
            self.position = m.get('position')
        return self


class CreateObjectiveResponseBody(TeaModel):
    def __init__(
        self,
        data: CreateObjectiveResponseBodyData = None,
        success: bool = None,
    ):
        self.data = data
        self.success = success

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            temp_model = CreateObjectiveResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class CreateObjectiveResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateObjectiveResponseBody = None,
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
            temp_model = CreateObjectiveResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteKeyResultHeaders(TeaModel):
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


class DeleteKeyResultRequest(TeaModel):
    def __init__(
        self,
        kr_id: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.kr_id = kr_id
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kr_id is not None:
            result['krId'] = self.kr_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('krId') is not None:
            self.kr_id = m.get('krId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class DeleteKeyResultResponseBody(TeaModel):
    def __init__(
        self,
        data: bool = None,
        success: bool = None,
    ):
        # This parameter is required.
        self.data = data
        # This parameter is required.
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class DeleteKeyResultResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteKeyResultResponseBody = None,
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
            temp_model = DeleteKeyResultResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteObjectiveHeaders(TeaModel):
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


class DeleteObjectiveRequest(TeaModel):
    def __init__(
        self,
        user_id: str = None,
    ):
        # This parameter is required.
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


class DeleteObjectiveResponseBodyData(TeaModel):
    def __init__(
        self,
        id: str = None,
    ):
        # This parameter is required.
        self.id = id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        return self


class DeleteObjectiveResponseBody(TeaModel):
    def __init__(
        self,
        data: DeleteObjectiveResponseBodyData = None,
        success: bool = None,
    ):
        self.data = data
        # This parameter is required.
        self.success = success

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            temp_model = DeleteObjectiveResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class DeleteObjectiveResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteObjectiveResponseBody = None,
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
            temp_model = DeleteObjectiveResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeletePermissionHeaders(TeaModel):
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


class DeletePermissionRequest(TeaModel):
    def __init__(
        self,
        id: str = None,
        policy_type: int = None,
        target_id: str = None,
        target_type: str = None,
        type: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.id = id
        # This parameter is required.
        self.policy_type = policy_type
        # This parameter is required.
        self.target_id = target_id
        # This parameter is required.
        self.target_type = target_type
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
        if self.id is not None:
            result['id'] = self.id
        if self.policy_type is not None:
            result['policyType'] = self.policy_type
        if self.target_id is not None:
            result['targetId'] = self.target_id
        if self.target_type is not None:
            result['targetType'] = self.target_type
        if self.type is not None:
            result['type'] = self.type
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('policyType') is not None:
            self.policy_type = m.get('policyType')
        if m.get('targetId') is not None:
            self.target_id = m.get('targetId')
        if m.get('targetType') is not None:
            self.target_type = m.get('targetType')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class DeletePermissionResponseBodyDataPolicyListMemberList(TeaModel):
    def __init__(
        self,
        id: str = None,
        nickname: str = None,
        type: str = None,
    ):
        # This parameter is required.
        self.id = id
        self.nickname = nickname
        # This parameter is required.
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.nickname is not None:
            result['nickname'] = self.nickname
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('nickname') is not None:
            self.nickname = m.get('nickname')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class DeletePermissionResponseBodyDataPolicyList(TeaModel):
    def __init__(
        self,
        member_list: List[DeletePermissionResponseBodyDataPolicyListMemberList] = None,
        name: str = None,
        type: int = None,
    ):
        # This parameter is required.
        self.member_list = member_list
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.type = type

    def validate(self):
        if self.member_list:
            for k in self.member_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['memberList'] = []
        if self.member_list is not None:
            for k in self.member_list:
                result['memberList'].append(k.to_map() if k else None)
        if self.name is not None:
            result['name'] = self.name
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.member_list = []
        if m.get('memberList') is not None:
            for k in m.get('memberList'):
                temp_model = DeletePermissionResponseBodyDataPolicyListMemberList()
                self.member_list.append(temp_model.from_map(k))
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class DeletePermissionResponseBodyData(TeaModel):
    def __init__(
        self,
        id: str = None,
        policy_list: List[DeletePermissionResponseBodyDataPolicyList] = None,
        privacy: str = None,
        type: str = None,
    ):
        # This parameter is required.
        self.id = id
        # This parameter is required.
        self.policy_list = policy_list
        # This parameter is required.
        self.privacy = privacy
        # This parameter is required.
        self.type = type

    def validate(self):
        if self.policy_list:
            for k in self.policy_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        result['policyList'] = []
        if self.policy_list is not None:
            for k in self.policy_list:
                result['policyList'].append(k.to_map() if k else None)
        if self.privacy is not None:
            result['privacy'] = self.privacy
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        self.policy_list = []
        if m.get('policyList') is not None:
            for k in m.get('policyList'):
                temp_model = DeletePermissionResponseBodyDataPolicyList()
                self.policy_list.append(temp_model.from_map(k))
        if m.get('privacy') is not None:
            self.privacy = m.get('privacy')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class DeletePermissionResponseBody(TeaModel):
    def __init__(
        self,
        data: DeletePermissionResponseBodyData = None,
        success: bool = None,
    ):
        # This parameter is required.
        self.data = data
        self.success = success

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            temp_model = DeletePermissionResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class DeletePermissionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeletePermissionResponseBody = None,
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
            temp_model = DeletePermissionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetPeriodListHeaders(TeaModel):
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


class GetPeriodListResponseBodyDataPeriodList(TeaModel):
    def __init__(
        self,
        end_time: float = None,
        id: BinaryIO = None,
        is_current: bool = None,
        is_yearly: bool = None,
        name: BinaryIO = None,
        start_time: float = None,
    ):
        # This parameter is required.
        self.end_time = end_time
        # This parameter is required.
        self.id = id
        # This parameter is required.
        self.is_current = is_current
        # This parameter is required.
        self.is_yearly = is_yearly
        # This parameter is required.
        self.name = name
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
        if self.id is not None:
            result['id'] = self.id
        if self.is_current is not None:
            result['isCurrent'] = self.is_current
        if self.is_yearly is not None:
            result['isYearly'] = self.is_yearly
        if self.name is not None:
            result['name'] = self.name
        if self.start_time is not None:
            result['startTime'] = self.start_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isCurrent') is not None:
            self.is_current = m.get('isCurrent')
        if m.get('isYearly') is not None:
            self.is_yearly = m.get('isYearly')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        return self


class GetPeriodListResponseBodyData(TeaModel):
    def __init__(
        self,
        period_list: List[GetPeriodListResponseBodyDataPeriodList] = None,
    ):
        # This parameter is required.
        self.period_list = period_list

    def validate(self):
        if self.period_list:
            for k in self.period_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['periodList'] = []
        if self.period_list is not None:
            for k in self.period_list:
                result['periodList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.period_list = []
        if m.get('periodList') is not None:
            for k in m.get('periodList'):
                temp_model = GetPeriodListResponseBodyDataPeriodList()
                self.period_list.append(temp_model.from_map(k))
        return self


class GetPeriodListResponseBody(TeaModel):
    def __init__(
        self,
        data: GetPeriodListResponseBodyData = None,
        success: bool = None,
    ):
        self.data = data
        self.success = success

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            temp_model = GetPeriodListResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetPeriodListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetPeriodListResponseBody = None,
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
            temp_model = GetPeriodListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetPermissionHeaders(TeaModel):
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


class GetPermissionRequest(TeaModel):
    def __init__(
        self,
        target_id: str = None,
        target_type: str = None,
        user_id: str = None,
        with_kr: bool = None,
        with_objective: bool = None,
    ):
        # This parameter is required.
        self.target_id = target_id
        # This parameter is required.
        self.target_type = target_type
        # This parameter is required.
        self.user_id = user_id
        self.with_kr = with_kr
        self.with_objective = with_objective

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.target_id is not None:
            result['targetId'] = self.target_id
        if self.target_type is not None:
            result['targetType'] = self.target_type
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.with_kr is not None:
            result['withKr'] = self.with_kr
        if self.with_objective is not None:
            result['withObjective'] = self.with_objective
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('targetId') is not None:
            self.target_id = m.get('targetId')
        if m.get('targetType') is not None:
            self.target_type = m.get('targetType')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('withKr') is not None:
            self.with_kr = m.get('withKr')
        if m.get('withObjective') is not None:
            self.with_objective = m.get('withObjective')
        return self


class GetPermissionResponseBodyDataPolicyListMemberList(TeaModel):
    def __init__(
        self,
        id: str = None,
        nickname: str = None,
        type: str = None,
    ):
        # This parameter is required.
        self.id = id
        self.nickname = nickname
        # This parameter is required.
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.nickname is not None:
            result['nickname'] = self.nickname
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('nickname') is not None:
            self.nickname = m.get('nickname')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class GetPermissionResponseBodyDataPolicyList(TeaModel):
    def __init__(
        self,
        member_list: List[GetPermissionResponseBodyDataPolicyListMemberList] = None,
        name: str = None,
        type: int = None,
    ):
        # This parameter is required.
        self.member_list = member_list
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.type = type

    def validate(self):
        if self.member_list:
            for k in self.member_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['memberList'] = []
        if self.member_list is not None:
            for k in self.member_list:
                result['memberList'].append(k.to_map() if k else None)
        if self.name is not None:
            result['name'] = self.name
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.member_list = []
        if m.get('memberList') is not None:
            for k in m.get('memberList'):
                temp_model = GetPermissionResponseBodyDataPolicyListMemberList()
                self.member_list.append(temp_model.from_map(k))
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class GetPermissionResponseBodyData(TeaModel):
    def __init__(
        self,
        id: str = None,
        policy_list: List[GetPermissionResponseBodyDataPolicyList] = None,
        privacy: str = None,
        type: str = None,
    ):
        # This parameter is required.
        self.id = id
        # This parameter is required.
        self.policy_list = policy_list
        # This parameter is required.
        self.privacy = privacy
        # This parameter is required.
        self.type = type

    def validate(self):
        if self.policy_list:
            for k in self.policy_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        result['policyList'] = []
        if self.policy_list is not None:
            for k in self.policy_list:
                result['policyList'].append(k.to_map() if k else None)
        if self.privacy is not None:
            result['privacy'] = self.privacy
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        self.policy_list = []
        if m.get('policyList') is not None:
            for k in m.get('policyList'):
                temp_model = GetPermissionResponseBodyDataPolicyList()
                self.policy_list.append(temp_model.from_map(k))
        if m.get('privacy') is not None:
            self.privacy = m.get('privacy')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class GetPermissionResponseBody(TeaModel):
    def __init__(
        self,
        data: GetPermissionResponseBodyData = None,
        success: bool = None,
    ):
        # This parameter is required.
        self.data = data
        self.success = success

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            temp_model = GetPermissionResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetPermissionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetPermissionResponseBody = None,
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
            temp_model = GetPermissionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetUserOkrHeaders(TeaModel):
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


class GetUserOkrRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        period_id: str = None,
        user_id: str = None,
    ):
        self.page_number = page_number
        self.page_size = page_size
        # This parameter is required.
        self.period_id = period_id
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
        if self.period_id is not None:
            result['periodId'] = self.period_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('periodId') is not None:
            self.period_id = m.get('periodId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetUserOkrResponseBodyDataListKrListProgress(TeaModel):
    def __init__(
        self,
        percent: int = None,
    ):
        self.percent = percent

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.percent is not None:
            result['percent'] = self.percent
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('percent') is not None:
            self.percent = m.get('percent')
        return self


class GetUserOkrResponseBodyDataListKrList(TeaModel):
    def __init__(
        self,
        content: BinaryIO = None,
        gmt_create: float = None,
        gmt_modified: float = None,
        id: BinaryIO = None,
        objective_id: BinaryIO = None,
        permission: List[float] = None,
        position: int = None,
        progress: GetUserOkrResponseBodyDataListKrListProgress = None,
        score: float = None,
        weight: float = None,
    ):
        self.content = content
        self.gmt_create = gmt_create
        self.gmt_modified = gmt_modified
        # This parameter is required.
        self.id = id
        self.objective_id = objective_id
        self.permission = permission
        self.position = position
        self.progress = progress
        self.score = score
        self.weight = weight

    def validate(self):
        if self.progress:
            self.progress.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.id is not None:
            result['id'] = self.id
        if self.objective_id is not None:
            result['objectiveId'] = self.objective_id
        if self.permission is not None:
            result['permission'] = self.permission
        if self.position is not None:
            result['position'] = self.position
        if self.progress is not None:
            result['progress'] = self.progress.to_map()
        if self.score is not None:
            result['score'] = self.score
        if self.weight is not None:
            result['weight'] = self.weight
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('objectiveId') is not None:
            self.objective_id = m.get('objectiveId')
        if m.get('permission') is not None:
            self.permission = m.get('permission')
        if m.get('position') is not None:
            self.position = m.get('position')
        if m.get('progress') is not None:
            temp_model = GetUserOkrResponseBodyDataListKrListProgress()
            self.progress = temp_model.from_map(m['progress'])
        if m.get('score') is not None:
            self.score = m.get('score')
        if m.get('weight') is not None:
            self.weight = m.get('weight')
        return self


class GetUserOkrResponseBodyDataListOwner(TeaModel):
    def __init__(
        self,
        avatar_media_id: BinaryIO = None,
        corp_id: BinaryIO = None,
        id: BinaryIO = None,
        nickname: BinaryIO = None,
        user_id: BinaryIO = None,
    ):
        self.avatar_media_id = avatar_media_id
        self.corp_id = corp_id
        self.id = id
        self.nickname = nickname
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.avatar_media_id is not None:
            result['avatarMediaId'] = self.avatar_media_id
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.id is not None:
            result['id'] = self.id
        if self.nickname is not None:
            result['nickname'] = self.nickname
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('avatarMediaId') is not None:
            self.avatar_media_id = m.get('avatarMediaId')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('nickname') is not None:
            self.nickname = m.get('nickname')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetUserOkrResponseBodyDataListProgress(TeaModel):
    def __init__(
        self,
        percent: int = None,
    ):
        self.percent = percent

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.percent is not None:
            result['percent'] = self.percent
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('percent') is not None:
            self.percent = m.get('percent')
        return self


class GetUserOkrResponseBodyDataList(TeaModel):
    def __init__(
        self,
        align_from_ids: List[BinaryIO] = None,
        align_to_ids: List[BinaryIO] = None,
        content: BinaryIO = None,
        gmt_create: float = None,
        gmt_modified: float = None,
        id: BinaryIO = None,
        kr_list: List[GetUserOkrResponseBodyDataListKrList] = None,
        owner: GetUserOkrResponseBodyDataListOwner = None,
        period_id: BinaryIO = None,
        permission: List[float] = None,
        position: int = None,
        progress: GetUserOkrResponseBodyDataListProgress = None,
        progress_percent: float = None,
        published: bool = None,
        score: float = None,
        status: int = None,
        user_id: BinaryIO = None,
        weight: float = None,
    ):
        self.align_from_ids = align_from_ids
        self.align_to_ids = align_to_ids
        self.content = content
        self.gmt_create = gmt_create
        self.gmt_modified = gmt_modified
        self.id = id
        self.kr_list = kr_list
        self.owner = owner
        self.period_id = period_id
        self.permission = permission
        self.position = position
        self.progress = progress
        self.progress_percent = progress_percent
        self.published = published
        self.score = score
        self.status = status
        self.user_id = user_id
        self.weight = weight

    def validate(self):
        if self.kr_list:
            for k in self.kr_list:
                if k:
                    k.validate()
        if self.owner:
            self.owner.validate()
        if self.progress:
            self.progress.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.align_from_ids is not None:
            result['alignFromIds'] = self.align_from_ids
        if self.align_to_ids is not None:
            result['alignToIds'] = self.align_to_ids
        if self.content is not None:
            result['content'] = self.content
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.id is not None:
            result['id'] = self.id
        result['krList'] = []
        if self.kr_list is not None:
            for k in self.kr_list:
                result['krList'].append(k.to_map() if k else None)
        if self.owner is not None:
            result['owner'] = self.owner.to_map()
        if self.period_id is not None:
            result['periodId'] = self.period_id
        if self.permission is not None:
            result['permission'] = self.permission
        if self.position is not None:
            result['position'] = self.position
        if self.progress is not None:
            result['progress'] = self.progress.to_map()
        if self.progress_percent is not None:
            result['progressPercent'] = self.progress_percent
        if self.published is not None:
            result['published'] = self.published
        if self.score is not None:
            result['score'] = self.score
        if self.status is not None:
            result['status'] = self.status
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.weight is not None:
            result['weight'] = self.weight
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('alignFromIds') is not None:
            self.align_from_ids = m.get('alignFromIds')
        if m.get('alignToIds') is not None:
            self.align_to_ids = m.get('alignToIds')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('id') is not None:
            self.id = m.get('id')
        self.kr_list = []
        if m.get('krList') is not None:
            for k in m.get('krList'):
                temp_model = GetUserOkrResponseBodyDataListKrList()
                self.kr_list.append(temp_model.from_map(k))
        if m.get('owner') is not None:
            temp_model = GetUserOkrResponseBodyDataListOwner()
            self.owner = temp_model.from_map(m['owner'])
        if m.get('periodId') is not None:
            self.period_id = m.get('periodId')
        if m.get('permission') is not None:
            self.permission = m.get('permission')
        if m.get('position') is not None:
            self.position = m.get('position')
        if m.get('progress') is not None:
            temp_model = GetUserOkrResponseBodyDataListProgress()
            self.progress = temp_model.from_map(m['progress'])
        if m.get('progressPercent') is not None:
            self.progress_percent = m.get('progressPercent')
        if m.get('published') is not None:
            self.published = m.get('published')
        if m.get('score') is not None:
            self.score = m.get('score')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('weight') is not None:
            self.weight = m.get('weight')
        return self


class GetUserOkrResponseBodyData(TeaModel):
    def __init__(
        self,
        list: List[GetUserOkrResponseBodyDataList] = None,
        page_number: int = None,
        page_size: int = None,
        total_count: int = None,
    ):
        self.list = list
        self.page_number = page_number
        self.page_size = page_size
        # This parameter is required.
        self.total_count = total_count

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
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = GetUserOkrResponseBodyDataList()
                self.list.append(temp_model.from_map(k))
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class GetUserOkrResponseBody(TeaModel):
    def __init__(
        self,
        data: GetUserOkrResponseBodyData = None,
        success: bool = None,
    ):
        self.data = data
        # This parameter is required.
        self.success = success

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            temp_model = GetUserOkrResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetUserOkrResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetUserOkrResponseBody = None,
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
            temp_model = GetUserOkrResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class OkrObjectivesBatchHeaders(TeaModel):
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


class OkrObjectivesBatchRequest(TeaModel):
    def __init__(
        self,
        goods_code: str = None,
        objective_ids: List[str] = None,
    ):
        self.goods_code = goods_code
        self.objective_ids = objective_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.goods_code is not None:
            result['goodsCode'] = self.goods_code
        if self.objective_ids is not None:
            result['objectiveIds'] = self.objective_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('goodsCode') is not None:
            self.goods_code = m.get('goodsCode')
        if m.get('objectiveIds') is not None:
            self.objective_ids = m.get('objectiveIds')
        return self


class OkrObjectivesBatchResponseBody(TeaModel):
    def __init__(
        self,
        content: List[OpenObjectiveDTO] = None,
        success: bool = None,
    ):
        self.content = content
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
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class OkrObjectivesBatchResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: OkrObjectivesBatchResponseBody = None,
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
            temp_model = OkrObjectivesBatchResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class OkrObjectivesByUserHeaders(TeaModel):
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


class OkrObjectivesByUserRequest(TeaModel):
    def __init__(
        self,
        goods_code: str = None,
        page_number: int = None,
        page_size: int = None,
    ):
        self.goods_code = goods_code
        self.page_number = page_number
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.goods_code is not None:
            result['goodsCode'] = self.goods_code
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('goodsCode') is not None:
            self.goods_code = m.get('goodsCode')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class OkrObjectivesByUserResponseBodyContent(TeaModel):
    def __init__(
        self,
        result: List[OpenObjectiveDTO] = None,
        total_count: int = None,
    ):
        self.result = result
        self.total_count = total_count

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
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = OpenObjectiveDTO()
                self.result.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class OkrObjectivesByUserResponseBody(TeaModel):
    def __init__(
        self,
        content: OkrObjectivesByUserResponseBodyContent = None,
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
            temp_model = OkrObjectivesByUserResponseBodyContent()
            self.content = temp_model.from_map(m['content'])
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class OkrObjectivesByUserResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: OkrObjectivesByUserResponseBody = None,
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
            temp_model = OkrObjectivesByUserResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class OkrPeriodsHeaders(TeaModel):
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


class OkrPeriodsRequest(TeaModel):
    def __init__(
        self,
        goods_code: str = None,
        page_number: int = None,
        page_size: int = None,
        status: int = None,
    ):
        self.goods_code = goods_code
        self.page_number = page_number
        self.page_size = page_size
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.goods_code is not None:
            result['goodsCode'] = self.goods_code
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('goodsCode') is not None:
            self.goods_code = m.get('goodsCode')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class OkrPeriodsResponseBodyContent(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        result: List[OpenPeriodDTO] = None,
        total_count: int = None,
    ):
        self.page_number = page_number
        self.page_size = page_size
        self.result = result
        self.total_count = total_count

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
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        result['result'] = []
        if self.result is not None:
            for k in self.result:
                result['result'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = OpenPeriodDTO()
                self.result.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class OkrPeriodsResponseBody(TeaModel):
    def __init__(
        self,
        content: OkrPeriodsResponseBodyContent = None,
        request_id: str = None,
        success: bool = None,
    ):
        self.content = content
        self.request_id = request_id
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
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            temp_model = OkrPeriodsResponseBodyContent()
            self.content = temp_model.from_map(m['content'])
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class OkrPeriodsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: OkrPeriodsResponseBody = None,
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
            temp_model = OkrPeriodsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UnAlignObjectiveHeaders(TeaModel):
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


class UnAlignObjectiveRequest(TeaModel):
    def __init__(
        self,
        period_id: str = None,
        target_id: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.period_id = period_id
        # This parameter is required.
        self.target_id = target_id
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.period_id is not None:
            result['periodId'] = self.period_id
        if self.target_id is not None:
            result['targetId'] = self.target_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('periodId') is not None:
            self.period_id = m.get('periodId')
        if m.get('targetId') is not None:
            self.target_id = m.get('targetId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class UnAlignObjectiveResponseBodyData(TeaModel):
    def __init__(
        self,
        align_id: BinaryIO = None,
        id: BinaryIO = None,
    ):
        self.align_id = align_id
        self.id = id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.align_id is not None:
            result['alignId'] = self.align_id
        if self.id is not None:
            result['id'] = self.id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('alignId') is not None:
            self.align_id = m.get('alignId')
        if m.get('id') is not None:
            self.id = m.get('id')
        return self


class UnAlignObjectiveResponseBody(TeaModel):
    def __init__(
        self,
        data: UnAlignObjectiveResponseBodyData = None,
        success: bool = None,
    ):
        self.data = data
        # This parameter is required.
        self.success = success

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            temp_model = UnAlignObjectiveResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class UnAlignObjectiveResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UnAlignObjectiveResponseBody = None,
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
            temp_model = UnAlignObjectiveResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateKROfContentHeaders(TeaModel):
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


class UpdateKROfContentRequest(TeaModel):
    def __init__(
        self,
        content: str = None,
        update_quote_list: List[str] = None,
        kr_id: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.content = content
        self.update_quote_list = update_quote_list
        # This parameter is required.
        self.kr_id = kr_id
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.update_quote_list is not None:
            result['updateQuoteList'] = self.update_quote_list
        if self.kr_id is not None:
            result['krId'] = self.kr_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('updateQuoteList') is not None:
            self.update_quote_list = m.get('updateQuoteList')
        if m.get('krId') is not None:
            self.kr_id = m.get('krId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class UpdateKROfContentResponseBody(TeaModel):
    def __init__(
        self,
        data: bool = None,
        success: bool = None,
    ):
        # This parameter is required.
        self.data = data
        # This parameter is required.
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class UpdateKROfContentResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateKROfContentResponseBody = None,
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
            temp_model = UpdateKROfContentResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateKROfScoreHeaders(TeaModel):
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


class UpdateKROfScoreRequest(TeaModel):
    def __init__(
        self,
        score: int = None,
        kr_id: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.score = score
        # This parameter is required.
        self.kr_id = kr_id
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.score is not None:
            result['score'] = self.score
        if self.kr_id is not None:
            result['krId'] = self.kr_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('score') is not None:
            self.score = m.get('score')
        if m.get('krId') is not None:
            self.kr_id = m.get('krId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class UpdateKROfScoreResponseBodyData(TeaModel):
    def __init__(
        self,
        objective_score: int = None,
    ):
        # This parameter is required.
        self.objective_score = objective_score

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.objective_score is not None:
            result['objectiveScore'] = self.objective_score
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('objectiveScore') is not None:
            self.objective_score = m.get('objectiveScore')
        return self


class UpdateKROfScoreResponseBody(TeaModel):
    def __init__(
        self,
        data: UpdateKROfScoreResponseBodyData = None,
        success: bool = None,
    ):
        # This parameter is required.
        self.data = data
        # This parameter is required.
        self.success = success

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            temp_model = UpdateKROfScoreResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class UpdateKROfScoreResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateKROfScoreResponseBody = None,
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
            temp_model = UpdateKROfScoreResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateKROfWeightHeaders(TeaModel):
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


class UpdateKROfWeightRequest(TeaModel):
    def __init__(
        self,
        weight: int = None,
        kr_id: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.weight = weight
        # This parameter is required.
        self.kr_id = kr_id
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.weight is not None:
            result['weight'] = self.weight
        if self.kr_id is not None:
            result['krId'] = self.kr_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('weight') is not None:
            self.weight = m.get('weight')
        if m.get('krId') is not None:
            self.kr_id = m.get('krId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class UpdateKROfWeightResponseBodyDataObjectiveProgress(TeaModel):
    def __init__(
        self,
        percent: int = None,
    ):
        # This parameter is required.
        self.percent = percent

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.percent is not None:
            result['percent'] = self.percent
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('percent') is not None:
            self.percent = m.get('percent')
        return self


class UpdateKROfWeightResponseBodyData(TeaModel):
    def __init__(
        self,
        objective_progress: UpdateKROfWeightResponseBodyDataObjectiveProgress = None,
        objective_score: int = None,
    ):
        # This parameter is required.
        self.objective_progress = objective_progress
        # This parameter is required.
        self.objective_score = objective_score

    def validate(self):
        if self.objective_progress:
            self.objective_progress.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.objective_progress is not None:
            result['objectiveProgress'] = self.objective_progress.to_map()
        if self.objective_score is not None:
            result['objectiveScore'] = self.objective_score
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('objectiveProgress') is not None:
            temp_model = UpdateKROfWeightResponseBodyDataObjectiveProgress()
            self.objective_progress = temp_model.from_map(m['objectiveProgress'])
        if m.get('objectiveScore') is not None:
            self.objective_score = m.get('objectiveScore')
        return self


class UpdateKROfWeightResponseBody(TeaModel):
    def __init__(
        self,
        data: UpdateKROfWeightResponseBodyData = None,
        success: bool = None,
    ):
        # This parameter is required.
        self.data = data
        # This parameter is required.
        self.success = success

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            temp_model = UpdateKROfWeightResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class UpdateKROfWeightResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateKROfWeightResponseBody = None,
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
            temp_model = UpdateKROfWeightResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateObjectiveHeaders(TeaModel):
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


class UpdateObjectiveRequest(TeaModel):
    def __init__(
        self,
        content: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.content = content
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class UpdateObjectiveResponseBodyData(TeaModel):
    def __init__(
        self,
        id: str = None,
        position: float = None,
    ):
        # This parameter is required.
        self.id = id
        # This parameter is required.
        self.position = position

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.position is not None:
            result['position'] = self.position
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('position') is not None:
            self.position = m.get('position')
        return self


class UpdateObjectiveResponseBody(TeaModel):
    def __init__(
        self,
        data: UpdateObjectiveResponseBodyData = None,
        success: bool = None,
    ):
        self.data = data
        self.success = success

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            temp_model = UpdateObjectiveResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class UpdateObjectiveResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateObjectiveResponseBody = None,
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
            temp_model = UpdateObjectiveResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdatePrivacyHeaders(TeaModel):
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


class UpdatePrivacyRequest(TeaModel):
    def __init__(
        self,
        privacy: str = None,
        target_id: str = None,
        target_type: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.privacy = privacy
        # This parameter is required.
        self.target_id = target_id
        # This parameter is required.
        self.target_type = target_type
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.privacy is not None:
            result['privacy'] = self.privacy
        if self.target_id is not None:
            result['targetId'] = self.target_id
        if self.target_type is not None:
            result['targetType'] = self.target_type
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('privacy') is not None:
            self.privacy = m.get('privacy')
        if m.get('targetId') is not None:
            self.target_id = m.get('targetId')
        if m.get('targetType') is not None:
            self.target_type = m.get('targetType')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class UpdatePrivacyResponseBodyDataPolicyListMemberList(TeaModel):
    def __init__(
        self,
        id: str = None,
        nickname: str = None,
        type: str = None,
    ):
        # This parameter is required.
        self.id = id
        self.nickname = nickname
        # This parameter is required.
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.nickname is not None:
            result['nickname'] = self.nickname
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('nickname') is not None:
            self.nickname = m.get('nickname')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class UpdatePrivacyResponseBodyDataPolicyList(TeaModel):
    def __init__(
        self,
        member_list: List[UpdatePrivacyResponseBodyDataPolicyListMemberList] = None,
        name: str = None,
        type: int = None,
    ):
        # This parameter is required.
        self.member_list = member_list
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.type = type

    def validate(self):
        if self.member_list:
            for k in self.member_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['memberList'] = []
        if self.member_list is not None:
            for k in self.member_list:
                result['memberList'].append(k.to_map() if k else None)
        if self.name is not None:
            result['name'] = self.name
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.member_list = []
        if m.get('memberList') is not None:
            for k in m.get('memberList'):
                temp_model = UpdatePrivacyResponseBodyDataPolicyListMemberList()
                self.member_list.append(temp_model.from_map(k))
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class UpdatePrivacyResponseBodyData(TeaModel):
    def __init__(
        self,
        id: str = None,
        policy_list: List[UpdatePrivacyResponseBodyDataPolicyList] = None,
        privacy: str = None,
        type: str = None,
    ):
        # This parameter is required.
        self.id = id
        # This parameter is required.
        self.policy_list = policy_list
        # This parameter is required.
        self.privacy = privacy
        # This parameter is required.
        self.type = type

    def validate(self):
        if self.policy_list:
            for k in self.policy_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        result['policyList'] = []
        if self.policy_list is not None:
            for k in self.policy_list:
                result['policyList'].append(k.to_map() if k else None)
        if self.privacy is not None:
            result['privacy'] = self.privacy
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        self.policy_list = []
        if m.get('policyList') is not None:
            for k in m.get('policyList'):
                temp_model = UpdatePrivacyResponseBodyDataPolicyList()
                self.policy_list.append(temp_model.from_map(k))
        if m.get('privacy') is not None:
            self.privacy = m.get('privacy')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class UpdatePrivacyResponseBody(TeaModel):
    def __init__(
        self,
        data: UpdatePrivacyResponseBodyData = None,
        success: bool = None,
    ):
        # This parameter is required.
        self.data = data
        self.success = success

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            temp_model = UpdatePrivacyResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class UpdatePrivacyResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdatePrivacyResponseBody = None,
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
            temp_model = UpdatePrivacyResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


