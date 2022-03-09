# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, BinaryIO, List


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
        owner_id: BinaryIO = None,
    ):
        # 周期 ID
        self.period_id = period_id
        # 对齐目标的 ID
        self.target_id = target_id
        # 用户 ID
        self.owner_id = owner_id

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
        if self.owner_id is not None:
            result['ownerId'] = self.owner_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('periodId') is not None:
            self.period_id = m.get('periodId')
        if m.get('targetId') is not None:
            self.target_id = m.get('targetId')
        if m.get('ownerId') is not None:
            self.owner_id = m.get('ownerId')
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
        code: int = None,
        data: AlignObjectiveResponseBodyData = None,
        message: str = None,
        success: bool = None,
    ):
        # code
        self.code = code
        # data
        self.data = data
        # message
        self.message = message
        # success
        self.success = success

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.message is not None:
            result['message'] = self.message
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('data') is not None:
            temp_model = AlignObjectiveResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('message') is not None:
            self.message = m.get('message')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class AlignObjectiveResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: AlignObjectiveResponseBody = None,
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
            temp_model = AlignObjectiveResponseBody()
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
        objective_ids: List[BinaryIO] = None,
        period_id: BinaryIO = None,
        with_align: bool = None,
        with_kr: bool = None,
        with_progress: bool = None,
        owner_id: str = None,
    ):
        self.objective_ids = objective_ids
        # periodId
        self.period_id = period_id
        # withAlign
        self.with_align = with_align
        # withKr
        self.with_kr = with_kr
        # withProgress
        self.with_progress = with_progress
        # ownerId
        self.owner_id = owner_id

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
        if self.owner_id is not None:
            result['ownerId'] = self.owner_id
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
        if m.get('ownerId') is not None:
            self.owner_id = m.get('ownerId')
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
        id: BinaryIO = None,
        objective_id: BinaryIO = None,
        permission: List[float] = None,
        position: int = None,
        progress: BatchQueryObjectiveResponseBodyDataKrListProgress = None,
        score: float = None,
        weight: float = None,
    ):
        self.content = content
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


class BatchQueryObjectiveResponseBodyDataOwnerDepartment(TeaModel):
    def __init__(
        self,
        id: BinaryIO = None,
        name: BinaryIO = None,
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


class BatchQueryObjectiveResponseBodyDataOwner(TeaModel):
    def __init__(
        self,
        avatar_media_id: BinaryIO = None,
        corp_id: BinaryIO = None,
        department: BatchQueryObjectiveResponseBodyDataOwnerDepartment = None,
        id: BinaryIO = None,
        nickname: BinaryIO = None,
        staff_id: BinaryIO = None,
    ):
        self.avatar_media_id = avatar_media_id
        self.corp_id = corp_id
        self.department = department
        self.id = id
        self.nickname = nickname
        self.staff_id = staff_id

    def validate(self):
        if self.department:
            self.department.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.avatar_media_id is not None:
            result['avatarMediaId'] = self.avatar_media_id
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.department is not None:
            result['department'] = self.department.to_map()
        if self.id is not None:
            result['id'] = self.id
        if self.nickname is not None:
            result['nickname'] = self.nickname
        if self.staff_id is not None:
            result['staffId'] = self.staff_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('avatarMediaId') is not None:
            self.avatar_media_id = m.get('avatarMediaId')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('department') is not None:
            temp_model = BatchQueryObjectiveResponseBodyDataOwnerDepartment()
            self.department = temp_model.from_map(m['department'])
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('nickname') is not None:
            self.nickname = m.get('nickname')
        if m.get('staffId') is not None:
            self.staff_id = m.get('staffId')
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
        code: str = None,
        data: List[BatchQueryObjectiveResponseBodyData] = None,
        message: BinaryIO = None,
        success: bool = None,
    ):
        # code
        self.code = code
        self.data = data
        # message
        self.message = message
        # success
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
        if self.code is not None:
            result['code'] = self.code
        result['data'] = []
        if self.data is not None:
            for k in self.data:
                result['data'].append(k.to_map() if k else None)
        if self.message is not None:
            result['message'] = self.message
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = BatchQueryObjectiveResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('message') is not None:
            self.message = m.get('message')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class BatchQueryObjectiveResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: BatchQueryObjectiveResponseBody = None,
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
            temp_model = BatchQueryObjectiveResponseBody()
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
        content: BinaryIO = None,
        objective_id: BinaryIO = None,
        period_id: BinaryIO = None,
        prev_position: int = None,
        weight: int = None,
        owner_id: BinaryIO = None,
    ):
        self.content = content
        self.objective_id = objective_id
        self.period_id = period_id
        self.prev_position = prev_position
        self.weight = weight
        self.owner_id = owner_id

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
        if self.owner_id is not None:
            result['ownerId'] = self.owner_id
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
        if m.get('ownerId') is not None:
            self.owner_id = m.get('ownerId')
        return self


class CreateKeyResultResponseBodyData(TeaModel):
    def __init__(
        self,
        id: BinaryIO = None,
        position: int = None,
        weight: int = None,
    ):
        self.id = id
        self.position = position
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
        self.data = data
        # Id of the request
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
        body: CreateKeyResultResponseBody = None,
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
        content: BinaryIO = None,
        period_id: BinaryIO = None,
        prev_position: BinaryIO = None,
        user_id: str = None,
    ):
        # content
        self.content = content
        # periodId
        self.period_id = period_id
        # prevPosition
        self.prev_position = prev_position
        # userId
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
    ):
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


class CreateObjectiveResponseBody(TeaModel):
    def __init__(
        self,
        code: int = None,
        data: CreateObjectiveResponseBodyData = None,
        message: str = None,
        success: bool = None,
    ):
        # code
        self.code = code
        # data
        self.data = data
        # message
        self.message = message
        # success
        self.success = success

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.message is not None:
            result['message'] = self.message
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('data') is not None:
            temp_model = CreateObjectiveResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('message') is not None:
            self.message = m.get('message')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class CreateObjectiveResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateObjectiveResponseBody = None,
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
        kr_id: BinaryIO = None,
        owner_id: BinaryIO = None,
    ):
        self.kr_id = kr_id
        self.owner_id = owner_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kr_id is not None:
            result['krId'] = self.kr_id
        if self.owner_id is not None:
            result['ownerId'] = self.owner_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('krId') is not None:
            self.kr_id = m.get('krId')
        if m.get('ownerId') is not None:
            self.owner_id = m.get('ownerId')
        return self


class DeleteKeyResultResponseBody(TeaModel):
    def __init__(
        self,
        data: bool = None,
        success: bool = None,
    ):
        self.data = data
        # is success
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
        body: DeleteKeyResultResponseBody = None,
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
        # userId
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
        code: int = None,
        data: DeleteObjectiveResponseBodyData = None,
        message: str = None,
        success: bool = None,
    ):
        # code
        self.code = code
        # data
        self.data = data
        # message
        self.message = message
        # success
        self.success = success

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.message is not None:
            result['message'] = self.message
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('data') is not None:
            temp_model = DeleteObjectiveResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('message') is not None:
            self.message = m.get('message')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class DeleteObjectiveResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DeleteObjectiveResponseBody = None,
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
            temp_model = DeleteObjectiveResponseBody()
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
        self.end_time = end_time
        self.id = id
        self.is_current = is_current
        self.is_yearly = is_yearly
        self.name = name
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
        # data
        self.data = data
        # success
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
        body: GetPeriodListResponseBody = None,
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
            temp_model = GetPeriodListResponseBody()
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
        owner_id: BinaryIO = None,
        page_number: int = None,
        page_size: int = None,
        period_id: BinaryIO = None,
    ):
        # 归属用户的ID
        self.owner_id = owner_id
        # 页码，默认 为 1
        self.page_number = page_number
        # 每页的个数，默认100
        self.page_size = page_size
        # 周期 ID
        self.period_id = period_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.owner_id is not None:
            result['ownerId'] = self.owner_id
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.period_id is not None:
            result['periodId'] = self.period_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('ownerId') is not None:
            self.owner_id = m.get('ownerId')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('periodId') is not None:
            self.period_id = m.get('periodId')
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
        id: BinaryIO = None,
        objective_id: BinaryIO = None,
        permission: List[float] = None,
        position: int = None,
        progress: GetUserOkrResponseBodyDataListKrListProgress = None,
        score: float = None,
        weight: float = None,
    ):
        self.content = content
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


class GetUserOkrResponseBodyDataListOwnerDepartment(TeaModel):
    def __init__(
        self,
        id: BinaryIO = None,
        name: BinaryIO = None,
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


class GetUserOkrResponseBodyDataListOwner(TeaModel):
    def __init__(
        self,
        avatar_media_id: BinaryIO = None,
        corp_id: BinaryIO = None,
        department: GetUserOkrResponseBodyDataListOwnerDepartment = None,
        id: BinaryIO = None,
        nickname: BinaryIO = None,
        staff_id: BinaryIO = None,
    ):
        self.avatar_media_id = avatar_media_id
        self.corp_id = corp_id
        self.department = department
        self.id = id
        self.nickname = nickname
        self.staff_id = staff_id

    def validate(self):
        if self.department:
            self.department.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.avatar_media_id is not None:
            result['avatarMediaId'] = self.avatar_media_id
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.department is not None:
            result['department'] = self.department.to_map()
        if self.id is not None:
            result['id'] = self.id
        if self.nickname is not None:
            result['nickname'] = self.nickname
        if self.staff_id is not None:
            result['staffId'] = self.staff_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('avatarMediaId') is not None:
            self.avatar_media_id = m.get('avatarMediaId')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('department') is not None:
            temp_model = GetUserOkrResponseBodyDataListOwnerDepartment()
            self.department = temp_model.from_map(m['department'])
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('nickname') is not None:
            self.nickname = m.get('nickname')
        if m.get('staffId') is not None:
            self.staff_id = m.get('staffId')
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
        page_no: int = None,
        page_size: int = None,
        total_count: int = None,
    ):
        self.list = list
        self.page_no = page_no
        self.page_size = page_size
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
        if self.page_no is not None:
            result['pageNo'] = self.page_no
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
        if m.get('pageNo') is not None:
            self.page_no = m.get('pageNo')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class GetUserOkrResponseBody(TeaModel):
    def __init__(
        self,
        code: int = None,
        data: GetUserOkrResponseBodyData = None,
        message: BinaryIO = None,
        success: bool = None,
    ):
        # code
        self.code = code
        # data
        self.data = data
        # message
        self.message = message
        # success
        self.success = success

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.message is not None:
            result['message'] = self.message
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('data') is not None:
            temp_model = GetUserOkrResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('message') is not None:
            self.message = m.get('message')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetUserOkrResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetUserOkrResponseBody = None,
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
            temp_model = GetUserOkrResponseBody()
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
        owner_id: BinaryIO = None,
    ):
        # 周期 ID
        self.period_id = period_id
        # 对齐目标的 ID
        self.target_id = target_id
        # 用户 ID
        self.owner_id = owner_id

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
        if self.owner_id is not None:
            result['ownerId'] = self.owner_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('periodId') is not None:
            self.period_id = m.get('periodId')
        if m.get('targetId') is not None:
            self.target_id = m.get('targetId')
        if m.get('ownerId') is not None:
            self.owner_id = m.get('ownerId')
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
        code: int = None,
        data: UnAlignObjectiveResponseBodyData = None,
        message: str = None,
        success: bool = None,
    ):
        # code
        self.code = code
        # data
        self.data = data
        # message
        self.message = message
        # success
        self.success = success

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.message is not None:
            result['message'] = self.message
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('data') is not None:
            temp_model = UnAlignObjectiveResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('message') is not None:
            self.message = m.get('message')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class UnAlignObjectiveResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UnAlignObjectiveResponseBody = None,
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
        content: BinaryIO = None,
        update_quote_list: List[BinaryIO] = None,
        kr_id: BinaryIO = None,
        operator_uid: BinaryIO = None,
    ):
        self.content = content
        self.update_quote_list = update_quote_list
        # A short description of struct
        self.kr_id = kr_id
        self.operator_uid = operator_uid

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
        if self.operator_uid is not None:
            result['operatorUid'] = self.operator_uid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('updateQuoteList') is not None:
            self.update_quote_list = m.get('updateQuoteList')
        if m.get('krId') is not None:
            self.kr_id = m.get('krId')
        if m.get('operatorUid') is not None:
            self.operator_uid = m.get('operatorUid')
        return self


class UpdateKROfContentResponseBody(TeaModel):
    def __init__(
        self,
        data: bool = None,
        success: bool = None,
    ):
        self.data = data
        # Id of the request
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
        body: UpdateKROfContentResponseBody = None,
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
        kr_id: BinaryIO = None,
        owner_id: BinaryIO = None,
    ):
        self.score = score
        # A short description of struct
        self.kr_id = kr_id
        self.owner_id = owner_id

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
        if self.owner_id is not None:
            result['ownerId'] = self.owner_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('score') is not None:
            self.score = m.get('score')
        if m.get('krId') is not None:
            self.kr_id = m.get('krId')
        if m.get('ownerId') is not None:
            self.owner_id = m.get('ownerId')
        return self


class UpdateKROfScoreResponseBody(TeaModel):
    def __init__(
        self,
        data: int = None,
        success: bool = None,
    ):
        # 目标分数
        self.data = data
        # Id of the request
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


class UpdateKROfScoreResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateKROfScoreResponseBody = None,
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
        kr_id: BinaryIO = None,
        owner_id: BinaryIO = None,
    ):
        self.weight = weight
        # A short description of struct
        self.kr_id = kr_id
        self.owner_id = owner_id

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
        if self.owner_id is not None:
            result['ownerId'] = self.owner_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('weight') is not None:
            self.weight = m.get('weight')
        if m.get('krId') is not None:
            self.kr_id = m.get('krId')
        if m.get('ownerId') is not None:
            self.owner_id = m.get('ownerId')
        return self


class UpdateKROfWeightResponseBodyDataObjectiveProgress(TeaModel):
    def __init__(
        self,
        percent: int = None,
        status: int = None,
    ):
        self.percent = percent
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.percent is not None:
            result['percent'] = self.percent
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('percent') is not None:
            self.percent = m.get('percent')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class UpdateKROfWeightResponseBodyData(TeaModel):
    def __init__(
        self,
        objective_progress: UpdateKROfWeightResponseBodyDataObjectiveProgress = None,
        objective_score: int = None,
    ):
        self.objective_progress = objective_progress
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
        # 目标分数
        self.data = data
        # Id of the request
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
        body: UpdateKROfWeightResponseBody = None,
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
        content: BinaryIO = None,
        user_id: str = None,
    ):
        self.content = content
        # userId
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
        self.id = id
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
        code: int = None,
        data: UpdateObjectiveResponseBodyData = None,
        message: str = None,
        success: bool = None,
    ):
        # code
        self.code = code
        # data
        self.data = data
        # message
        self.message = message
        # success
        self.success = success

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.message is not None:
            result['message'] = self.message
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('data') is not None:
            temp_model = UpdateObjectiveResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('message') is not None:
            self.message = m.get('message')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class UpdateObjectiveResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateObjectiveResponseBody = None,
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
            temp_model = UpdateObjectiveResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


