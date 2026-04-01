# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import List, Dict


class RetrievalExtendParamsValueSourceUserParams(TeaModel):
    def __init__(
        self,
        nick: str = None,
        staff_id: str = None,
    ):
        self.nick = nick
        self.staff_id = staff_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.nick is not None:
            result['nick'] = self.nick
        if self.staff_id is not None:
            result['staffId'] = self.staff_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nick') is not None:
            self.nick = m.get('nick')
        if m.get('staffId') is not None:
            self.staff_id = m.get('staffId')
        return self


class RetrievalExtendParamsValueTargetUserParams(TeaModel):
    def __init__(
        self,
        nick: str = None,
        staff_id: str = None,
    ):
        self.nick = nick
        self.staff_id = staff_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.nick is not None:
            result['nick'] = self.nick
        if self.staff_id is not None:
            result['staffId'] = self.staff_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nick') is not None:
            self.nick = m.get('nick')
        if m.get('staffId') is not None:
            self.staff_id = m.get('staffId')
        return self


class RetrievalExtendParamsValue(TeaModel):
    def __init__(
        self,
        start_time: int = None,
        end_time: int = None,
        keywords: List[str] = None,
        source_user_params: List[RetrievalExtendParamsValueSourceUserParams] = None,
        target_user_params: List[RetrievalExtendParamsValueTargetUserParams] = None,
    ):
        self.start_time = start_time
        self.end_time = end_time
        self.keywords = keywords
        self.source_user_params = source_user_params
        self.target_user_params = target_user_params

    def validate(self):
        if self.source_user_params:
            for k in self.source_user_params:
                if k:
                    k.validate()
        if self.target_user_params:
            for k in self.target_user_params:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.keywords is not None:
            result['keywords'] = self.keywords
        result['sourceUserParams'] = []
        if self.source_user_params is not None:
            for k in self.source_user_params:
                result['sourceUserParams'].append(k.to_map() if k else None)
        result['targetUserParams'] = []
        if self.target_user_params is not None:
            for k in self.target_user_params:
                result['targetUserParams'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('keywords') is not None:
            self.keywords = m.get('keywords')
        self.source_user_params = []
        if m.get('sourceUserParams') is not None:
            for k in m.get('sourceUserParams'):
                temp_model = RetrievalExtendParamsValueSourceUserParams()
                self.source_user_params.append(temp_model.from_map(k))
        self.target_user_params = []
        if m.get('targetUserParams') is not None:
            for k in m.get('targetUserParams'):
                temp_model = RetrievalExtendParamsValueTargetUserParams()
                self.target_user_params.append(temp_model.from_map(k))
        return self


class FetchLoginStatusDevicesHeaders(TeaModel):
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


class FetchLoginStatusDevicesRequest(TeaModel):
    def __init__(
        self,
        domain: str = None,
        user_id_list: List[str] = None,
    ):
        # This parameter is required.
        self.domain = domain
        # This parameter is required.
        self.user_id_list = user_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.domain is not None:
            result['domain'] = self.domain
        if self.user_id_list is not None:
            result['userIdList'] = self.user_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('domain') is not None:
            self.domain = m.get('domain')
        if m.get('userIdList') is not None:
            self.user_id_list = m.get('userIdList')
        return self


class FetchLoginStatusDevicesResponseBodyResultDeviceList(TeaModel):
    def __init__(
        self,
        action_timestamp: int = None,
        client_type: str = None,
        is_logged_in: bool = None,
        open_device_id: str = None,
    ):
        self.action_timestamp = action_timestamp
        self.client_type = client_type
        self.is_logged_in = is_logged_in
        self.open_device_id = open_device_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action_timestamp is not None:
            result['actionTimestamp'] = self.action_timestamp
        if self.client_type is not None:
            result['clientType'] = self.client_type
        if self.is_logged_in is not None:
            result['isLoggedIn'] = self.is_logged_in
        if self.open_device_id is not None:
            result['openDeviceId'] = self.open_device_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionTimestamp') is not None:
            self.action_timestamp = m.get('actionTimestamp')
        if m.get('clientType') is not None:
            self.client_type = m.get('clientType')
        if m.get('isLoggedIn') is not None:
            self.is_logged_in = m.get('isLoggedIn')
        if m.get('openDeviceId') is not None:
            self.open_device_id = m.get('openDeviceId')
        return self


class FetchLoginStatusDevicesResponseBodyResult(TeaModel):
    def __init__(
        self,
        device_list: List[FetchLoginStatusDevicesResponseBodyResultDeviceList] = None,
        user_id: str = None,
    ):
        self.device_list = device_list
        self.user_id = user_id

    def validate(self):
        if self.device_list:
            for k in self.device_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['deviceList'] = []
        if self.device_list is not None:
            for k in self.device_list:
                result['deviceList'].append(k.to_map() if k else None)
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.device_list = []
        if m.get('deviceList') is not None:
            for k in m.get('deviceList'):
                temp_model = FetchLoginStatusDevicesResponseBodyResultDeviceList()
                self.device_list.append(temp_model.from_map(k))
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class FetchLoginStatusDevicesResponseBody(TeaModel):
    def __init__(
        self,
        error_code: str = None,
        error_msg: str = None,
        result: List[FetchLoginStatusDevicesResponseBodyResult] = None,
        success: bool = None,
    ):
        self.error_code = error_code
        self.error_msg = error_msg
        self.result = result
        self.success = success

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
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        result['result'] = []
        if self.result is not None:
            for k in self.result:
                result['result'].append(k.to_map() if k else None)
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = FetchLoginStatusDevicesResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class FetchLoginStatusDevicesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: FetchLoginStatusDevicesResponseBody = None,
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
            temp_model = FetchLoginStatusDevicesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetAiTaskResultHeaders(TeaModel):
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


class GetAiTaskResultRequest(TeaModel):
    def __init__(
        self,
        task_id: str = None,
    ):
        self.task_id = task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class GetAiTaskResultResponseBody(TeaModel):
    def __init__(
        self,
        content: str = None,
        content_type: str = None,
        error_code: str = None,
        error_msg: str = None,
        success: bool = None,
    ):
        self.content = content
        self.content_type = content_type
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
        if self.content is not None:
            result['content'] = self.content
        if self.content_type is not None:
            result['contentType'] = self.content_type
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('contentType') is not None:
            self.content_type = m.get('contentType')
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetAiTaskResultResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetAiTaskResultResponseBody = None,
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
            temp_model = GetAiTaskResultResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RetrieveHeaders(TeaModel):
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


class RetrieveRequestDragRequestContextEvaluationContext(TeaModel):
    def __init__(
        self,
        source_dentry_id: str = None,
    ):
        self.source_dentry_id = source_dentry_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.source_dentry_id is not None:
            result['sourceDentryId'] = self.source_dentry_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sourceDentryId') is not None:
            self.source_dentry_id = m.get('sourceDentryId')
        return self


class RetrieveRequestDragRequestContext(TeaModel):
    def __init__(
        self,
        evaluation_context: RetrieveRequestDragRequestContextEvaluationContext = None,
    ):
        self.evaluation_context = evaluation_context

    def validate(self):
        if self.evaluation_context:
            self.evaluation_context.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.evaluation_context is not None:
            result['evaluationContext'] = self.evaluation_context.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('evaluationContext') is not None:
            temp_model = RetrieveRequestDragRequestContextEvaluationContext()
            self.evaluation_context = temp_model.from_map(m['evaluationContext'])
        return self


class RetrieveRequest(TeaModel):
    def __init__(
        self,
        answerer: str = None,
        drag_request_context: RetrieveRequestDragRequestContext = None,
        keyword_list: List[str] = None,
        limit: int = None,
        question: str = None,
        retrieval_extend_params: Dict[str, RetrievalExtendParamsValue] = None,
        retrieve_score_threshold: float = None,
        scene: str = None,
        tenant: str = None,
        token_limit: int = None,
    ):
        # This parameter is required.
        self.answerer = answerer
        self.drag_request_context = drag_request_context
        self.keyword_list = keyword_list
        # This parameter is required.
        self.limit = limit
        # This parameter is required.
        self.question = question
        # This parameter is required.
        self.retrieval_extend_params = retrieval_extend_params
        self.retrieve_score_threshold = retrieve_score_threshold
        # This parameter is required.
        self.scene = scene
        # This parameter is required.
        self.tenant = tenant
        self.token_limit = token_limit

    def validate(self):
        if self.drag_request_context:
            self.drag_request_context.validate()
        if self.retrieval_extend_params:
            for v in self.retrieval_extend_params.values():
                if v:
                    v.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.answerer is not None:
            result['answerer'] = self.answerer
        if self.drag_request_context is not None:
            result['dragRequestContext'] = self.drag_request_context.to_map()
        if self.keyword_list is not None:
            result['keywordList'] = self.keyword_list
        if self.limit is not None:
            result['limit'] = self.limit
        if self.question is not None:
            result['question'] = self.question
        result['retrievalExtendParams'] = {}
        if self.retrieval_extend_params is not None:
            for k, v in self.retrieval_extend_params.items():
                result['retrievalExtendParams'][k] = v.to_map()
        if self.retrieve_score_threshold is not None:
            result['retrieveScoreThreshold'] = self.retrieve_score_threshold
        if self.scene is not None:
            result['scene'] = self.scene
        if self.tenant is not None:
            result['tenant'] = self.tenant
        if self.token_limit is not None:
            result['tokenLimit'] = self.token_limit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('answerer') is not None:
            self.answerer = m.get('answerer')
        if m.get('dragRequestContext') is not None:
            temp_model = RetrieveRequestDragRequestContext()
            self.drag_request_context = temp_model.from_map(m['dragRequestContext'])
        if m.get('keywordList') is not None:
            self.keyword_list = m.get('keywordList')
        if m.get('limit') is not None:
            self.limit = m.get('limit')
        if m.get('question') is not None:
            self.question = m.get('question')
        self.retrieval_extend_params = {}
        if m.get('retrievalExtendParams') is not None:
            for k, v in m.get('retrievalExtendParams').items():
                temp_model = RetrievalExtendParamsValue()
                self.retrieval_extend_params[k] = temp_model.from_map(v)
        if m.get('retrieveScoreThreshold') is not None:
            self.retrieve_score_threshold = m.get('retrieveScoreThreshold')
        if m.get('scene') is not None:
            self.scene = m.get('scene')
        if m.get('tenant') is not None:
            self.tenant = m.get('tenant')
        if m.get('tokenLimit') is not None:
            self.token_limit = m.get('tokenLimit')
        return self


class RetrieveResponseBodyResultCalendarsScoreItem(TeaModel):
    def __init__(
        self,
        finally_score: float = None,
        score_map: Dict[str, float] = None,
        score_threshold: float = None,
        selected_branch: List[str] = None,
        selected_category: str = None,
    ):
        self.finally_score = finally_score
        self.score_map = score_map
        self.score_threshold = score_threshold
        self.selected_branch = selected_branch
        self.selected_category = selected_category

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.finally_score is not None:
            result['finallyScore'] = self.finally_score
        if self.score_map is not None:
            result['scoreMap'] = self.score_map
        if self.score_threshold is not None:
            result['scoreThreshold'] = self.score_threshold
        if self.selected_branch is not None:
            result['selectedBranch'] = self.selected_branch
        if self.selected_category is not None:
            result['selectedCategory'] = self.selected_category
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('finallyScore') is not None:
            self.finally_score = m.get('finallyScore')
        if m.get('scoreMap') is not None:
            self.score_map = m.get('scoreMap')
        if m.get('scoreThreshold') is not None:
            self.score_threshold = m.get('scoreThreshold')
        if m.get('selectedBranch') is not None:
            self.selected_branch = m.get('selectedBranch')
        if m.get('selectedCategory') is not None:
            self.selected_category = m.get('selectedCategory')
        return self


class RetrieveResponseBodyResultCalendars(TeaModel):
    def __init__(
        self,
        creator_staff_id: int = None,
        end_time: int = None,
        gmt_create: int = None,
        gmt_modified: int = None,
        icon: str = None,
        match_intimacy: bool = None,
        material: str = None,
        meeting_room: str = None,
        participant_staff_ids: List[str] = None,
        raw_comment: str = None,
        ref_type: str = None,
        score: float = None,
        score_item: RetrieveResponseBodyResultCalendarsScoreItem = None,
        start_time: int = None,
        timestamp: int = None,
        title: str = None,
        type: str = None,
        url: str = None,
    ):
        self.creator_staff_id = creator_staff_id
        self.end_time = end_time
        self.gmt_create = gmt_create
        self.gmt_modified = gmt_modified
        self.icon = icon
        self.match_intimacy = match_intimacy
        self.material = material
        self.meeting_room = meeting_room
        self.participant_staff_ids = participant_staff_ids
        self.raw_comment = raw_comment
        self.ref_type = ref_type
        self.score = score
        self.score_item = score_item
        self.start_time = start_time
        self.timestamp = timestamp
        self.title = title
        self.type = type
        self.url = url

    def validate(self):
        if self.score_item:
            self.score_item.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.creator_staff_id is not None:
            result['creatorStaffId'] = self.creator_staff_id
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.icon is not None:
            result['icon'] = self.icon
        if self.match_intimacy is not None:
            result['matchIntimacy'] = self.match_intimacy
        if self.material is not None:
            result['material'] = self.material
        if self.meeting_room is not None:
            result['meetingRoom'] = self.meeting_room
        if self.participant_staff_ids is not None:
            result['participantStaffIds'] = self.participant_staff_ids
        if self.raw_comment is not None:
            result['rawComment'] = self.raw_comment
        if self.ref_type is not None:
            result['refType'] = self.ref_type
        if self.score is not None:
            result['score'] = self.score
        if self.score_item is not None:
            result['scoreItem'] = self.score_item.to_map()
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.timestamp is not None:
            result['timestamp'] = self.timestamp
        if self.title is not None:
            result['title'] = self.title
        if self.type is not None:
            result['type'] = self.type
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('creatorStaffId') is not None:
            self.creator_staff_id = m.get('creatorStaffId')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('matchIntimacy') is not None:
            self.match_intimacy = m.get('matchIntimacy')
        if m.get('material') is not None:
            self.material = m.get('material')
        if m.get('meetingRoom') is not None:
            self.meeting_room = m.get('meetingRoom')
        if m.get('participantStaffIds') is not None:
            self.participant_staff_ids = m.get('participantStaffIds')
        if m.get('rawComment') is not None:
            self.raw_comment = m.get('rawComment')
        if m.get('refType') is not None:
            self.ref_type = m.get('refType')
        if m.get('score') is not None:
            self.score = m.get('score')
        if m.get('scoreItem') is not None:
            temp_model = RetrieveResponseBodyResultCalendarsScoreItem()
            self.score_item = temp_model.from_map(m['scoreItem'])
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('timestamp') is not None:
            self.timestamp = m.get('timestamp')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class RetrieveResponseBodyResultDingHelperDocsAbleDashboardModel(TeaModel):
    def __init__(
        self,
        chart_name: str = None,
        chart_type: str = None,
        dashboard_name: str = None,
        data: str = None,
        sheet_name: str = None,
        type: str = None,
    ):
        self.chart_name = chart_name
        self.chart_type = chart_type
        self.dashboard_name = dashboard_name
        self.data = data
        self.sheet_name = sheet_name
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.chart_name is not None:
            result['chartName'] = self.chart_name
        if self.chart_type is not None:
            result['chartType'] = self.chart_type
        if self.dashboard_name is not None:
            result['dashboardName'] = self.dashboard_name
        if self.data is not None:
            result['data'] = self.data
        if self.sheet_name is not None:
            result['sheetName'] = self.sheet_name
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('chartName') is not None:
            self.chart_name = m.get('chartName')
        if m.get('chartType') is not None:
            self.chart_type = m.get('chartType')
        if m.get('dashboardName') is not None:
            self.dashboard_name = m.get('dashboardName')
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('sheetName') is not None:
            self.sheet_name = m.get('sheetName')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class RetrieveResponseBodyResultDingHelperDocsScoreItem(TeaModel):
    def __init__(
        self,
        finally_score: float = None,
        score_map: Dict[str, float] = None,
        score_threshold: float = None,
        selected_branch: List[str] = None,
        selected_category: str = None,
    ):
        self.finally_score = finally_score
        self.score_map = score_map
        self.score_threshold = score_threshold
        self.selected_branch = selected_branch
        self.selected_category = selected_category

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.finally_score is not None:
            result['finallyScore'] = self.finally_score
        if self.score_map is not None:
            result['scoreMap'] = self.score_map
        if self.score_threshold is not None:
            result['scoreThreshold'] = self.score_threshold
        if self.selected_branch is not None:
            result['selectedBranch'] = self.selected_branch
        if self.selected_category is not None:
            result['selectedCategory'] = self.selected_category
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('finallyScore') is not None:
            self.finally_score = m.get('finallyScore')
        if m.get('scoreMap') is not None:
            self.score_map = m.get('scoreMap')
        if m.get('scoreThreshold') is not None:
            self.score_threshold = m.get('scoreThreshold')
        if m.get('selectedBranch') is not None:
            self.selected_branch = m.get('selectedBranch')
        if m.get('selectedCategory') is not None:
            self.selected_category = m.get('selectedCategory')
        return self


class RetrieveResponseBodyResultDingHelperDocs(TeaModel):
    def __init__(
        self,
        able_dashboard_model: RetrieveResponseBodyResultDingHelperDocsAbleDashboardModel = None,
        chunk_id: int = None,
        chunk_ids: List[int] = None,
        chunk_model: str = None,
        creator: str = None,
        dentry_uuid: str = None,
        extension: str = None,
        gmt_create: int = None,
        gmt_modified: int = None,
        has_extend_chunk: bool = None,
        icon: str = None,
        match_intimacy: bool = None,
        material: str = None,
        ref_type: str = None,
        score: float = None,
        score_item: RetrieveResponseBodyResultDingHelperDocsScoreItem = None,
        small_2big_text: str = None,
        text: str = None,
        timestamp: int = None,
        title: str = None,
        type: str = None,
        upload_source: str = None,
        url: str = None,
    ):
        self.able_dashboard_model = able_dashboard_model
        self.chunk_id = chunk_id
        self.chunk_ids = chunk_ids
        self.chunk_model = chunk_model
        self.creator = creator
        self.dentry_uuid = dentry_uuid
        self.extension = extension
        self.gmt_create = gmt_create
        self.gmt_modified = gmt_modified
        self.has_extend_chunk = has_extend_chunk
        self.icon = icon
        self.match_intimacy = match_intimacy
        self.material = material
        self.ref_type = ref_type
        self.score = score
        self.score_item = score_item
        self.small_2big_text = small_2big_text
        self.text = text
        self.timestamp = timestamp
        self.title = title
        self.type = type
        self.upload_source = upload_source
        self.url = url

    def validate(self):
        if self.able_dashboard_model:
            self.able_dashboard_model.validate()
        if self.score_item:
            self.score_item.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.able_dashboard_model is not None:
            result['ableDashboardModel'] = self.able_dashboard_model.to_map()
        if self.chunk_id is not None:
            result['chunkId'] = self.chunk_id
        if self.chunk_ids is not None:
            result['chunkIds'] = self.chunk_ids
        if self.chunk_model is not None:
            result['chunkModel'] = self.chunk_model
        if self.creator is not None:
            result['creator'] = self.creator
        if self.dentry_uuid is not None:
            result['dentryUuid'] = self.dentry_uuid
        if self.extension is not None:
            result['extension'] = self.extension
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.has_extend_chunk is not None:
            result['hasExtendChunk'] = self.has_extend_chunk
        if self.icon is not None:
            result['icon'] = self.icon
        if self.match_intimacy is not None:
            result['matchIntimacy'] = self.match_intimacy
        if self.material is not None:
            result['material'] = self.material
        if self.ref_type is not None:
            result['refType'] = self.ref_type
        if self.score is not None:
            result['score'] = self.score
        if self.score_item is not None:
            result['scoreItem'] = self.score_item.to_map()
        if self.small_2big_text is not None:
            result['small2bigText'] = self.small_2big_text
        if self.text is not None:
            result['text'] = self.text
        if self.timestamp is not None:
            result['timestamp'] = self.timestamp
        if self.title is not None:
            result['title'] = self.title
        if self.type is not None:
            result['type'] = self.type
        if self.upload_source is not None:
            result['uploadSource'] = self.upload_source
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('ableDashboardModel') is not None:
            temp_model = RetrieveResponseBodyResultDingHelperDocsAbleDashboardModel()
            self.able_dashboard_model = temp_model.from_map(m['ableDashboardModel'])
        if m.get('chunkId') is not None:
            self.chunk_id = m.get('chunkId')
        if m.get('chunkIds') is not None:
            self.chunk_ids = m.get('chunkIds')
        if m.get('chunkModel') is not None:
            self.chunk_model = m.get('chunkModel')
        if m.get('creator') is not None:
            self.creator = m.get('creator')
        if m.get('dentryUuid') is not None:
            self.dentry_uuid = m.get('dentryUuid')
        if m.get('extension') is not None:
            self.extension = m.get('extension')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('hasExtendChunk') is not None:
            self.has_extend_chunk = m.get('hasExtendChunk')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('matchIntimacy') is not None:
            self.match_intimacy = m.get('matchIntimacy')
        if m.get('material') is not None:
            self.material = m.get('material')
        if m.get('refType') is not None:
            self.ref_type = m.get('refType')
        if m.get('score') is not None:
            self.score = m.get('score')
        if m.get('scoreItem') is not None:
            temp_model = RetrieveResponseBodyResultDingHelperDocsScoreItem()
            self.score_item = temp_model.from_map(m['scoreItem'])
        if m.get('small2bigText') is not None:
            self.small_2big_text = m.get('small2bigText')
        if m.get('text') is not None:
            self.text = m.get('text')
        if m.get('timestamp') is not None:
            self.timestamp = m.get('timestamp')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('uploadSource') is not None:
            self.upload_source = m.get('uploadSource')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class RetrieveResponseBodyResultDocsAbleDashboardModel(TeaModel):
    def __init__(
        self,
        chart_name: str = None,
        chart_type: str = None,
        dashboard_name: str = None,
        data: str = None,
        sheet_name: str = None,
        type: str = None,
    ):
        self.chart_name = chart_name
        self.chart_type = chart_type
        self.dashboard_name = dashboard_name
        self.data = data
        self.sheet_name = sheet_name
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.chart_name is not None:
            result['chartName'] = self.chart_name
        if self.chart_type is not None:
            result['chartType'] = self.chart_type
        if self.dashboard_name is not None:
            result['dashboardName'] = self.dashboard_name
        if self.data is not None:
            result['data'] = self.data
        if self.sheet_name is not None:
            result['sheetName'] = self.sheet_name
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('chartName') is not None:
            self.chart_name = m.get('chartName')
        if m.get('chartType') is not None:
            self.chart_type = m.get('chartType')
        if m.get('dashboardName') is not None:
            self.dashboard_name = m.get('dashboardName')
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('sheetName') is not None:
            self.sheet_name = m.get('sheetName')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class RetrieveResponseBodyResultDocsScoreItem(TeaModel):
    def __init__(
        self,
        finally_score: float = None,
        score_map: Dict[str, float] = None,
        score_threshold: float = None,
        selected_branch: List[str] = None,
        selected_category: str = None,
    ):
        self.finally_score = finally_score
        self.score_map = score_map
        self.score_threshold = score_threshold
        self.selected_branch = selected_branch
        self.selected_category = selected_category

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.finally_score is not None:
            result['finallyScore'] = self.finally_score
        if self.score_map is not None:
            result['scoreMap'] = self.score_map
        if self.score_threshold is not None:
            result['scoreThreshold'] = self.score_threshold
        if self.selected_branch is not None:
            result['selectedBranch'] = self.selected_branch
        if self.selected_category is not None:
            result['selectedCategory'] = self.selected_category
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('finallyScore') is not None:
            self.finally_score = m.get('finallyScore')
        if m.get('scoreMap') is not None:
            self.score_map = m.get('scoreMap')
        if m.get('scoreThreshold') is not None:
            self.score_threshold = m.get('scoreThreshold')
        if m.get('selectedBranch') is not None:
            self.selected_branch = m.get('selectedBranch')
        if m.get('selectedCategory') is not None:
            self.selected_category = m.get('selectedCategory')
        return self


class RetrieveResponseBodyResultDocs(TeaModel):
    def __init__(
        self,
        able_dashboard_model: RetrieveResponseBodyResultDocsAbleDashboardModel = None,
        chunk_id: int = None,
        chunk_ids: List[int] = None,
        chunk_model: str = None,
        creator: str = None,
        dentry_uuid: str = None,
        extension: str = None,
        gmt_create: int = None,
        gmt_modified: int = None,
        has_extend_chunk: bool = None,
        icon: str = None,
        match_intimacy: bool = None,
        material: str = None,
        ref_type: str = None,
        score: float = None,
        score_item: RetrieveResponseBodyResultDocsScoreItem = None,
        small_2big_text: str = None,
        text: str = None,
        timestamp: int = None,
        title: str = None,
        type: str = None,
        upload_source: str = None,
        url: str = None,
    ):
        self.able_dashboard_model = able_dashboard_model
        self.chunk_id = chunk_id
        self.chunk_ids = chunk_ids
        self.chunk_model = chunk_model
        self.creator = creator
        self.dentry_uuid = dentry_uuid
        self.extension = extension
        self.gmt_create = gmt_create
        self.gmt_modified = gmt_modified
        self.has_extend_chunk = has_extend_chunk
        self.icon = icon
        self.match_intimacy = match_intimacy
        self.material = material
        self.ref_type = ref_type
        self.score = score
        self.score_item = score_item
        self.small_2big_text = small_2big_text
        self.text = text
        self.timestamp = timestamp
        self.title = title
        self.type = type
        self.upload_source = upload_source
        self.url = url

    def validate(self):
        if self.able_dashboard_model:
            self.able_dashboard_model.validate()
        if self.score_item:
            self.score_item.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.able_dashboard_model is not None:
            result['ableDashboardModel'] = self.able_dashboard_model.to_map()
        if self.chunk_id is not None:
            result['chunkId'] = self.chunk_id
        if self.chunk_ids is not None:
            result['chunkIds'] = self.chunk_ids
        if self.chunk_model is not None:
            result['chunkModel'] = self.chunk_model
        if self.creator is not None:
            result['creator'] = self.creator
        if self.dentry_uuid is not None:
            result['dentryUuid'] = self.dentry_uuid
        if self.extension is not None:
            result['extension'] = self.extension
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.has_extend_chunk is not None:
            result['hasExtendChunk'] = self.has_extend_chunk
        if self.icon is not None:
            result['icon'] = self.icon
        if self.match_intimacy is not None:
            result['matchIntimacy'] = self.match_intimacy
        if self.material is not None:
            result['material'] = self.material
        if self.ref_type is not None:
            result['refType'] = self.ref_type
        if self.score is not None:
            result['score'] = self.score
        if self.score_item is not None:
            result['scoreItem'] = self.score_item.to_map()
        if self.small_2big_text is not None:
            result['small2bigText'] = self.small_2big_text
        if self.text is not None:
            result['text'] = self.text
        if self.timestamp is not None:
            result['timestamp'] = self.timestamp
        if self.title is not None:
            result['title'] = self.title
        if self.type is not None:
            result['type'] = self.type
        if self.upload_source is not None:
            result['uploadSource'] = self.upload_source
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('ableDashboardModel') is not None:
            temp_model = RetrieveResponseBodyResultDocsAbleDashboardModel()
            self.able_dashboard_model = temp_model.from_map(m['ableDashboardModel'])
        if m.get('chunkId') is not None:
            self.chunk_id = m.get('chunkId')
        if m.get('chunkIds') is not None:
            self.chunk_ids = m.get('chunkIds')
        if m.get('chunkModel') is not None:
            self.chunk_model = m.get('chunkModel')
        if m.get('creator') is not None:
            self.creator = m.get('creator')
        if m.get('dentryUuid') is not None:
            self.dentry_uuid = m.get('dentryUuid')
        if m.get('extension') is not None:
            self.extension = m.get('extension')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('hasExtendChunk') is not None:
            self.has_extend_chunk = m.get('hasExtendChunk')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('matchIntimacy') is not None:
            self.match_intimacy = m.get('matchIntimacy')
        if m.get('material') is not None:
            self.material = m.get('material')
        if m.get('refType') is not None:
            self.ref_type = m.get('refType')
        if m.get('score') is not None:
            self.score = m.get('score')
        if m.get('scoreItem') is not None:
            temp_model = RetrieveResponseBodyResultDocsScoreItem()
            self.score_item = temp_model.from_map(m['scoreItem'])
        if m.get('small2bigText') is not None:
            self.small_2big_text = m.get('small2bigText')
        if m.get('text') is not None:
            self.text = m.get('text')
        if m.get('timestamp') is not None:
            self.timestamp = m.get('timestamp')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('uploadSource') is not None:
            self.upload_source = m.get('uploadSource')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class RetrieveResponseBodyResultFaqsScoreItem(TeaModel):
    def __init__(
        self,
        finally_score: float = None,
        score_map: Dict[str, float] = None,
        score_threshold: float = None,
        selected_branch: List[str] = None,
        selected_category: str = None,
    ):
        self.finally_score = finally_score
        self.score_map = score_map
        self.score_threshold = score_threshold
        self.selected_branch = selected_branch
        self.selected_category = selected_category

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.finally_score is not None:
            result['finallyScore'] = self.finally_score
        if self.score_map is not None:
            result['scoreMap'] = self.score_map
        if self.score_threshold is not None:
            result['scoreThreshold'] = self.score_threshold
        if self.selected_branch is not None:
            result['selectedBranch'] = self.selected_branch
        if self.selected_category is not None:
            result['selectedCategory'] = self.selected_category
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('finallyScore') is not None:
            self.finally_score = m.get('finallyScore')
        if m.get('scoreMap') is not None:
            self.score_map = m.get('scoreMap')
        if m.get('scoreThreshold') is not None:
            self.score_threshold = m.get('scoreThreshold')
        if m.get('selectedBranch') is not None:
            self.selected_branch = m.get('selectedBranch')
        if m.get('selectedCategory') is not None:
            self.selected_category = m.get('selectedCategory')
        return self


class RetrieveResponseBodyResultFaqs(TeaModel):
    def __init__(
        self,
        icon: str = None,
        match_intimacy: bool = None,
        material: str = None,
        ref_type: str = None,
        score: float = None,
        score_item: RetrieveResponseBodyResultFaqsScoreItem = None,
        timestamp: int = None,
        title: str = None,
        type: str = None,
        url: str = None,
    ):
        self.icon = icon
        self.match_intimacy = match_intimacy
        self.material = material
        self.ref_type = ref_type
        self.score = score
        self.score_item = score_item
        self.timestamp = timestamp
        self.title = title
        self.type = type
        self.url = url

    def validate(self):
        if self.score_item:
            self.score_item.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.icon is not None:
            result['icon'] = self.icon
        if self.match_intimacy is not None:
            result['matchIntimacy'] = self.match_intimacy
        if self.material is not None:
            result['material'] = self.material
        if self.ref_type is not None:
            result['refType'] = self.ref_type
        if self.score is not None:
            result['score'] = self.score
        if self.score_item is not None:
            result['scoreItem'] = self.score_item.to_map()
        if self.timestamp is not None:
            result['timestamp'] = self.timestamp
        if self.title is not None:
            result['title'] = self.title
        if self.type is not None:
            result['type'] = self.type
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('matchIntimacy') is not None:
            self.match_intimacy = m.get('matchIntimacy')
        if m.get('material') is not None:
            self.material = m.get('material')
        if m.get('refType') is not None:
            self.ref_type = m.get('refType')
        if m.get('score') is not None:
            self.score = m.get('score')
        if m.get('scoreItem') is not None:
            temp_model = RetrieveResponseBodyResultFaqsScoreItem()
            self.score_item = temp_model.from_map(m['scoreItem'])
        if m.get('timestamp') is not None:
            self.timestamp = m.get('timestamp')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class RetrieveResponseBodyResultFinalResultsScoreItem(TeaModel):
    def __init__(
        self,
        finally_score: float = None,
        score_map: Dict[str, float] = None,
        score_threshold: float = None,
        selected_branch: List[str] = None,
        selected_category: str = None,
    ):
        self.finally_score = finally_score
        self.score_map = score_map
        self.score_threshold = score_threshold
        self.selected_branch = selected_branch
        self.selected_category = selected_category

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.finally_score is not None:
            result['finallyScore'] = self.finally_score
        if self.score_map is not None:
            result['scoreMap'] = self.score_map
        if self.score_threshold is not None:
            result['scoreThreshold'] = self.score_threshold
        if self.selected_branch is not None:
            result['selectedBranch'] = self.selected_branch
        if self.selected_category is not None:
            result['selectedCategory'] = self.selected_category
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('finallyScore') is not None:
            self.finally_score = m.get('finallyScore')
        if m.get('scoreMap') is not None:
            self.score_map = m.get('scoreMap')
        if m.get('scoreThreshold') is not None:
            self.score_threshold = m.get('scoreThreshold')
        if m.get('selectedBranch') is not None:
            self.selected_branch = m.get('selectedBranch')
        if m.get('selectedCategory') is not None:
            self.selected_category = m.get('selectedCategory')
        return self


class RetrieveResponseBodyResultFinalResults(TeaModel):
    def __init__(
        self,
        icon: str = None,
        match_intimacy: bool = None,
        material: str = None,
        ref_type: str = None,
        score: float = None,
        score_item: RetrieveResponseBodyResultFinalResultsScoreItem = None,
        timestamp: int = None,
        title: str = None,
        type: str = None,
        url: str = None,
    ):
        self.icon = icon
        self.match_intimacy = match_intimacy
        self.material = material
        self.ref_type = ref_type
        self.score = score
        self.score_item = score_item
        self.timestamp = timestamp
        self.title = title
        self.type = type
        self.url = url

    def validate(self):
        if self.score_item:
            self.score_item.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.icon is not None:
            result['icon'] = self.icon
        if self.match_intimacy is not None:
            result['matchIntimacy'] = self.match_intimacy
        if self.material is not None:
            result['material'] = self.material
        if self.ref_type is not None:
            result['refType'] = self.ref_type
        if self.score is not None:
            result['score'] = self.score
        if self.score_item is not None:
            result['scoreItem'] = self.score_item.to_map()
        if self.timestamp is not None:
            result['timestamp'] = self.timestamp
        if self.title is not None:
            result['title'] = self.title
        if self.type is not None:
            result['type'] = self.type
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('matchIntimacy') is not None:
            self.match_intimacy = m.get('matchIntimacy')
        if m.get('material') is not None:
            self.material = m.get('material')
        if m.get('refType') is not None:
            self.ref_type = m.get('refType')
        if m.get('score') is not None:
            self.score = m.get('score')
        if m.get('scoreItem') is not None:
            temp_model = RetrieveResponseBodyResultFinalResultsScoreItem()
            self.score_item = temp_model.from_map(m['scoreItem'])
        if m.get('timestamp') is not None:
            self.timestamp = m.get('timestamp')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class RetrieveResponseBodyResultMinutesScoreItem(TeaModel):
    def __init__(
        self,
        finally_score: float = None,
        score_map: Dict[str, float] = None,
        score_threshold: float = None,
        selected_branch: List[str] = None,
        selected_category: str = None,
    ):
        self.finally_score = finally_score
        self.score_map = score_map
        self.score_threshold = score_threshold
        self.selected_branch = selected_branch
        self.selected_category = selected_category

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.finally_score is not None:
            result['finallyScore'] = self.finally_score
        if self.score_map is not None:
            result['scoreMap'] = self.score_map
        if self.score_threshold is not None:
            result['scoreThreshold'] = self.score_threshold
        if self.selected_branch is not None:
            result['selectedBranch'] = self.selected_branch
        if self.selected_category is not None:
            result['selectedCategory'] = self.selected_category
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('finallyScore') is not None:
            self.finally_score = m.get('finallyScore')
        if m.get('scoreMap') is not None:
            self.score_map = m.get('scoreMap')
        if m.get('scoreThreshold') is not None:
            self.score_threshold = m.get('scoreThreshold')
        if m.get('selectedBranch') is not None:
            self.selected_branch = m.get('selectedBranch')
        if m.get('selectedCategory') is not None:
            self.selected_category = m.get('selectedCategory')
        return self


class RetrieveResponseBodyResultMinutes(TeaModel):
    def __init__(
        self,
        corp_id: int = None,
        creator: str = None,
        extension: str = None,
        full_text_summary: str = None,
        gmt_modified: int = None,
        icon: str = None,
        match_intimacy: bool = None,
        material: str = None,
        origin_text: str = None,
        ref_type: str = None,
        score: float = None,
        score_item: RetrieveResponseBodyResultMinutesScoreItem = None,
        timestamp: int = None,
        title: str = None,
        type: str = None,
        url: str = None,
    ):
        self.corp_id = corp_id
        self.creator = creator
        self.extension = extension
        self.full_text_summary = full_text_summary
        self.gmt_modified = gmt_modified
        self.icon = icon
        self.match_intimacy = match_intimacy
        self.material = material
        self.origin_text = origin_text
        self.ref_type = ref_type
        self.score = score
        self.score_item = score_item
        self.timestamp = timestamp
        self.title = title
        self.type = type
        self.url = url

    def validate(self):
        if self.score_item:
            self.score_item.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.creator is not None:
            result['creator'] = self.creator
        if self.extension is not None:
            result['extension'] = self.extension
        if self.full_text_summary is not None:
            result['fullTextSummary'] = self.full_text_summary
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.icon is not None:
            result['icon'] = self.icon
        if self.match_intimacy is not None:
            result['matchIntimacy'] = self.match_intimacy
        if self.material is not None:
            result['material'] = self.material
        if self.origin_text is not None:
            result['originText'] = self.origin_text
        if self.ref_type is not None:
            result['refType'] = self.ref_type
        if self.score is not None:
            result['score'] = self.score
        if self.score_item is not None:
            result['scoreItem'] = self.score_item.to_map()
        if self.timestamp is not None:
            result['timestamp'] = self.timestamp
        if self.title is not None:
            result['title'] = self.title
        if self.type is not None:
            result['type'] = self.type
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('creator') is not None:
            self.creator = m.get('creator')
        if m.get('extension') is not None:
            self.extension = m.get('extension')
        if m.get('fullTextSummary') is not None:
            self.full_text_summary = m.get('fullTextSummary')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('matchIntimacy') is not None:
            self.match_intimacy = m.get('matchIntimacy')
        if m.get('material') is not None:
            self.material = m.get('material')
        if m.get('originText') is not None:
            self.origin_text = m.get('originText')
        if m.get('refType') is not None:
            self.ref_type = m.get('refType')
        if m.get('score') is not None:
            self.score = m.get('score')
        if m.get('scoreItem') is not None:
            temp_model = RetrieveResponseBodyResultMinutesScoreItem()
            self.score_item = temp_model.from_map(m['scoreItem'])
        if m.get('timestamp') is not None:
            self.timestamp = m.get('timestamp')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class RetrieveResponseBodyResultReportsScoreItem(TeaModel):
    def __init__(
        self,
        finally_score: float = None,
        score_map: Dict[str, float] = None,
        score_threshold: float = None,
        selected_branch: List[str] = None,
        selected_category: str = None,
    ):
        self.finally_score = finally_score
        self.score_map = score_map
        self.score_threshold = score_threshold
        self.selected_branch = selected_branch
        self.selected_category = selected_category

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.finally_score is not None:
            result['finallyScore'] = self.finally_score
        if self.score_map is not None:
            result['scoreMap'] = self.score_map
        if self.score_threshold is not None:
            result['scoreThreshold'] = self.score_threshold
        if self.selected_branch is not None:
            result['selectedBranch'] = self.selected_branch
        if self.selected_category is not None:
            result['selectedCategory'] = self.selected_category
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('finallyScore') is not None:
            self.finally_score = m.get('finallyScore')
        if m.get('scoreMap') is not None:
            self.score_map = m.get('scoreMap')
        if m.get('scoreThreshold') is not None:
            self.score_threshold = m.get('scoreThreshold')
        if m.get('selectedBranch') is not None:
            self.selected_branch = m.get('selectedBranch')
        if m.get('selectedCategory') is not None:
            self.selected_category = m.get('selectedCategory')
        return self


class RetrieveResponseBodyResultReports(TeaModel):
    def __init__(
        self,
        content: str = None,
        corp_id: int = None,
        creator: str = None,
        gmt_create: int = None,
        gmt_modified: int = None,
        icon: str = None,
        match_intimacy: bool = None,
        material: str = None,
        ref_type: str = None,
        score: float = None,
        score_item: RetrieveResponseBodyResultReportsScoreItem = None,
        timestamp: int = None,
        title: str = None,
        type: str = None,
        url: str = None,
    ):
        self.content = content
        self.corp_id = corp_id
        self.creator = creator
        self.gmt_create = gmt_create
        self.gmt_modified = gmt_modified
        self.icon = icon
        self.match_intimacy = match_intimacy
        self.material = material
        self.ref_type = ref_type
        self.score = score
        self.score_item = score_item
        self.timestamp = timestamp
        self.title = title
        self.type = type
        self.url = url

    def validate(self):
        if self.score_item:
            self.score_item.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.creator is not None:
            result['creator'] = self.creator
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.icon is not None:
            result['icon'] = self.icon
        if self.match_intimacy is not None:
            result['matchIntimacy'] = self.match_intimacy
        if self.material is not None:
            result['material'] = self.material
        if self.ref_type is not None:
            result['refType'] = self.ref_type
        if self.score is not None:
            result['score'] = self.score
        if self.score_item is not None:
            result['scoreItem'] = self.score_item.to_map()
        if self.timestamp is not None:
            result['timestamp'] = self.timestamp
        if self.title is not None:
            result['title'] = self.title
        if self.type is not None:
            result['type'] = self.type
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('creator') is not None:
            self.creator = m.get('creator')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('matchIntimacy') is not None:
            self.match_intimacy = m.get('matchIntimacy')
        if m.get('material') is not None:
            self.material = m.get('material')
        if m.get('refType') is not None:
            self.ref_type = m.get('refType')
        if m.get('score') is not None:
            self.score = m.get('score')
        if m.get('scoreItem') is not None:
            temp_model = RetrieveResponseBodyResultReportsScoreItem()
            self.score_item = temp_model.from_map(m['scoreItem'])
        if m.get('timestamp') is not None:
            self.timestamp = m.get('timestamp')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class RetrieveResponseBodyResultWikisScoreItem(TeaModel):
    def __init__(
        self,
        finally_score: float = None,
        score_map: Dict[str, float] = None,
        score_threshold: float = None,
        selected_branch: List[str] = None,
        selected_category: str = None,
    ):
        self.finally_score = finally_score
        self.score_map = score_map
        self.score_threshold = score_threshold
        self.selected_branch = selected_branch
        self.selected_category = selected_category

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.finally_score is not None:
            result['finallyScore'] = self.finally_score
        if self.score_map is not None:
            result['scoreMap'] = self.score_map
        if self.score_threshold is not None:
            result['scoreThreshold'] = self.score_threshold
        if self.selected_branch is not None:
            result['selectedBranch'] = self.selected_branch
        if self.selected_category is not None:
            result['selectedCategory'] = self.selected_category
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('finallyScore') is not None:
            self.finally_score = m.get('finallyScore')
        if m.get('scoreMap') is not None:
            self.score_map = m.get('scoreMap')
        if m.get('scoreThreshold') is not None:
            self.score_threshold = m.get('scoreThreshold')
        if m.get('selectedBranch') is not None:
            self.selected_branch = m.get('selectedBranch')
        if m.get('selectedCategory') is not None:
            self.selected_category = m.get('selectedCategory')
        return self


class RetrieveResponseBodyResultWikis(TeaModel):
    def __init__(
        self,
        corp_id: int = None,
        icon: str = None,
        match_intimacy: bool = None,
        material: str = None,
        ref_type: str = None,
        score: float = None,
        score_item: RetrieveResponseBodyResultWikisScoreItem = None,
        timestamp: int = None,
        title: str = None,
        type: str = None,
        url: str = None,
    ):
        self.corp_id = corp_id
        self.icon = icon
        self.match_intimacy = match_intimacy
        self.material = material
        self.ref_type = ref_type
        self.score = score
        self.score_item = score_item
        self.timestamp = timestamp
        self.title = title
        self.type = type
        self.url = url

    def validate(self):
        if self.score_item:
            self.score_item.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.icon is not None:
            result['icon'] = self.icon
        if self.match_intimacy is not None:
            result['matchIntimacy'] = self.match_intimacy
        if self.material is not None:
            result['material'] = self.material
        if self.ref_type is not None:
            result['refType'] = self.ref_type
        if self.score is not None:
            result['score'] = self.score
        if self.score_item is not None:
            result['scoreItem'] = self.score_item.to_map()
        if self.timestamp is not None:
            result['timestamp'] = self.timestamp
        if self.title is not None:
            result['title'] = self.title
        if self.type is not None:
            result['type'] = self.type
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('matchIntimacy') is not None:
            self.match_intimacy = m.get('matchIntimacy')
        if m.get('material') is not None:
            self.material = m.get('material')
        if m.get('refType') is not None:
            self.ref_type = m.get('refType')
        if m.get('score') is not None:
            self.score = m.get('score')
        if m.get('scoreItem') is not None:
            temp_model = RetrieveResponseBodyResultWikisScoreItem()
            self.score_item = temp_model.from_map(m['scoreItem'])
        if m.get('timestamp') is not None:
            self.timestamp = m.get('timestamp')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class RetrieveResponseBodyResult(TeaModel):
    def __init__(
        self,
        calendars: List[RetrieveResponseBodyResultCalendars] = None,
        ding_helper_docs: List[RetrieveResponseBodyResultDingHelperDocs] = None,
        docs: List[RetrieveResponseBodyResultDocs] = None,
        faqs: List[RetrieveResponseBodyResultFaqs] = None,
        final_results: List[RetrieveResponseBodyResultFinalResults] = None,
        minutes: List[RetrieveResponseBodyResultMinutes] = None,
        reports: List[RetrieveResponseBodyResultReports] = None,
        wikis: List[RetrieveResponseBodyResultWikis] = None,
    ):
        self.calendars = calendars
        self.ding_helper_docs = ding_helper_docs
        self.docs = docs
        self.faqs = faqs
        self.final_results = final_results
        self.minutes = minutes
        self.reports = reports
        self.wikis = wikis

    def validate(self):
        if self.calendars:
            for k in self.calendars:
                if k:
                    k.validate()
        if self.ding_helper_docs:
            for k in self.ding_helper_docs:
                if k:
                    k.validate()
        if self.docs:
            for k in self.docs:
                if k:
                    k.validate()
        if self.faqs:
            for k in self.faqs:
                if k:
                    k.validate()
        if self.final_results:
            for k in self.final_results:
                if k:
                    k.validate()
        if self.minutes:
            for k in self.minutes:
                if k:
                    k.validate()
        if self.reports:
            for k in self.reports:
                if k:
                    k.validate()
        if self.wikis:
            for k in self.wikis:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['calendars'] = []
        if self.calendars is not None:
            for k in self.calendars:
                result['calendars'].append(k.to_map() if k else None)
        result['dingHelperDocs'] = []
        if self.ding_helper_docs is not None:
            for k in self.ding_helper_docs:
                result['dingHelperDocs'].append(k.to_map() if k else None)
        result['docs'] = []
        if self.docs is not None:
            for k in self.docs:
                result['docs'].append(k.to_map() if k else None)
        result['faqs'] = []
        if self.faqs is not None:
            for k in self.faqs:
                result['faqs'].append(k.to_map() if k else None)
        result['finalResults'] = []
        if self.final_results is not None:
            for k in self.final_results:
                result['finalResults'].append(k.to_map() if k else None)
        result['minutes'] = []
        if self.minutes is not None:
            for k in self.minutes:
                result['minutes'].append(k.to_map() if k else None)
        result['reports'] = []
        if self.reports is not None:
            for k in self.reports:
                result['reports'].append(k.to_map() if k else None)
        result['wikis'] = []
        if self.wikis is not None:
            for k in self.wikis:
                result['wikis'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.calendars = []
        if m.get('calendars') is not None:
            for k in m.get('calendars'):
                temp_model = RetrieveResponseBodyResultCalendars()
                self.calendars.append(temp_model.from_map(k))
        self.ding_helper_docs = []
        if m.get('dingHelperDocs') is not None:
            for k in m.get('dingHelperDocs'):
                temp_model = RetrieveResponseBodyResultDingHelperDocs()
                self.ding_helper_docs.append(temp_model.from_map(k))
        self.docs = []
        if m.get('docs') is not None:
            for k in m.get('docs'):
                temp_model = RetrieveResponseBodyResultDocs()
                self.docs.append(temp_model.from_map(k))
        self.faqs = []
        if m.get('faqs') is not None:
            for k in m.get('faqs'):
                temp_model = RetrieveResponseBodyResultFaqs()
                self.faqs.append(temp_model.from_map(k))
        self.final_results = []
        if m.get('finalResults') is not None:
            for k in m.get('finalResults'):
                temp_model = RetrieveResponseBodyResultFinalResults()
                self.final_results.append(temp_model.from_map(k))
        self.minutes = []
        if m.get('minutes') is not None:
            for k in m.get('minutes'):
                temp_model = RetrieveResponseBodyResultMinutes()
                self.minutes.append(temp_model.from_map(k))
        self.reports = []
        if m.get('reports') is not None:
            for k in m.get('reports'):
                temp_model = RetrieveResponseBodyResultReports()
                self.reports.append(temp_model.from_map(k))
        self.wikis = []
        if m.get('wikis') is not None:
            for k in m.get('wikis'):
                temp_model = RetrieveResponseBodyResultWikis()
                self.wikis.append(temp_model.from_map(k))
        return self


class RetrieveResponseBody(TeaModel):
    def __init__(
        self,
        error_code: str = None,
        error_msg: str = None,
        result: List[RetrieveResponseBodyResult] = None,
        success: bool = None,
    ):
        self.error_code = error_code
        self.error_msg = error_msg
        self.result = result
        self.success = success

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
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        result['result'] = []
        if self.result is not None:
            for k in self.result:
                result['result'].append(k.to_map() if k else None)
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = RetrieveResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class RetrieveResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RetrieveResponseBody = None,
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
            temp_model = RetrieveResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SubmitAiTaskHeaders(TeaModel):
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


class SubmitAiTaskRequestMessages(TeaModel):
    def __init__(
        self,
        content: str = None,
    ):
        self.content = content

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        return self


class SubmitAiTaskRequest(TeaModel):
    def __init__(
        self,
        messages: List[SubmitAiTaskRequestMessages] = None,
    ):
        self.messages = messages

    def validate(self):
        if self.messages:
            for k in self.messages:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['messages'] = []
        if self.messages is not None:
            for k in self.messages:
                result['messages'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.messages = []
        if m.get('messages') is not None:
            for k in m.get('messages'):
                temp_model = SubmitAiTaskRequestMessages()
                self.messages.append(temp_model.from_map(k))
        return self


class SubmitAiTaskShrinkRequest(TeaModel):
    def __init__(
        self,
        messages_shrink: str = None,
    ):
        self.messages_shrink = messages_shrink

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.messages_shrink is not None:
            result['messages'] = self.messages_shrink
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('messages') is not None:
            self.messages_shrink = m.get('messages')
        return self


class SubmitAiTaskResponseBodyResult(TeaModel):
    def __init__(
        self,
        task_id: str = None,
    ):
        self.task_id = task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class SubmitAiTaskResponseBody(TeaModel):
    def __init__(
        self,
        error_code: str = None,
        error_msg: str = None,
        result: SubmitAiTaskResponseBodyResult = None,
        success: bool = None,
    ):
        self.error_code = error_code
        self.error_msg = error_msg
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
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.result is not None:
            result['result'] = self.result.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('result') is not None:
            temp_model = SubmitAiTaskResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class SubmitAiTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SubmitAiTaskResponseBody = None,
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
            temp_model = SubmitAiTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


