# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class AnalysisReportHeaders(TeaModel):
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


class AnalysisReportRequest(TeaModel):
    def __init__(
        self,
        report_id: str = None,
    ):
        self.report_id = report_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.report_id is not None:
            result['reportId'] = self.report_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('reportId') is not None:
            self.report_id = m.get('reportId')
        return self


class AnalysisReportResponseBodyResultCols(TeaModel):
    def __init__(
        self,
        base_type: str = None,
        name: str = None,
        theme: str = None,
    ):
        self.base_type = base_type
        self.name = name
        self.theme = theme

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.base_type is not None:
            result['baseType'] = self.base_type
        if self.name is not None:
            result['name'] = self.name
        if self.theme is not None:
            result['theme'] = self.theme
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('baseType') is not None:
            self.base_type = m.get('baseType')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('theme') is not None:
            self.theme = m.get('theme')
        return self


class AnalysisReportResponseBodyResultListQuery(TeaModel):
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


class AnalysisReportResponseBodyResultVisualizationSettings(TeaModel):
    def __init__(
        self,
        dimension: int = None,
        type: str = None,
    ):
        self.dimension = dimension
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dimension is not None:
            result['dimension'] = self.dimension
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dimension') is not None:
            self.dimension = m.get('dimension')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class AnalysisReportResponseBodyResult(TeaModel):
    def __init__(
        self,
        cols: List[AnalysisReportResponseBodyResultCols] = None,
        list_query: List[List[AnalysisReportResponseBodyResultListQuery]] = None,
        name: str = None,
        rows: List[List[str]] = None,
        tips: str = None,
        title: str = None,
        visualization_settings: AnalysisReportResponseBodyResultVisualizationSettings = None,
    ):
        self.cols = cols
        self.list_query = list_query
        self.name = name
        self.rows = rows
        self.tips = tips
        self.title = title
        self.visualization_settings = visualization_settings

    def validate(self):
        if self.cols:
            for k in self.cols:
                if k:
                    k.validate()
        if self.list_query:
            for k in self.list_query:
                for k1 in k:
                    if k1:
                        k1.validate()
        if self.visualization_settings:
            self.visualization_settings.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['cols'] = []
        if self.cols is not None:
            for k in self.cols:
                result['cols'].append(k.to_map() if k else None)
        result['listQuery'] = []
        if self.list_query is not None:
            for k in self.list_query:
                l1 = []
                for k1 in k:
                    l1.append(k1.to_map() if k1 else None)
                result['listQuery'].append(l1)
        if self.name is not None:
            result['name'] = self.name
        if self.rows is not None:
            result['rows'] = self.rows
        if self.tips is not None:
            result['tips'] = self.tips
        if self.title is not None:
            result['title'] = self.title
        if self.visualization_settings is not None:
            result['visualizationSettings'] = self.visualization_settings.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.cols = []
        if m.get('cols') is not None:
            for k in m.get('cols'):
                temp_model = AnalysisReportResponseBodyResultCols()
                self.cols.append(temp_model.from_map(k))
        self.list_query = []
        if m.get('listQuery') is not None:
            for k in m.get('listQuery'):
                l1 = []
                for k1 in k:
                    temp_model = AnalysisReportResponseBodyResultListQuery()
                    l1.append(temp_model.from_map(k1))
                self.list_query.append(l1)
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('rows') is not None:
            self.rows = m.get('rows')
        if m.get('tips') is not None:
            self.tips = m.get('tips')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('visualizationSettings') is not None:
            temp_model = AnalysisReportResponseBodyResultVisualizationSettings()
            self.visualization_settings = temp_model.from_map(m['visualizationSettings'])
        return self


class AnalysisReportResponseBody(TeaModel):
    def __init__(
        self,
        result: List[AnalysisReportResponseBodyResult] = None,
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
                temp_model = AnalysisReportResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class AnalysisReportResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AnalysisReportResponseBody = None,
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
            temp_model = AnalysisReportResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateOrganizationTaskHeaders(TeaModel):
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


class CreateOrganizationTaskRequest(TeaModel):
    def __init__(
        self,
        content: str = None,
        disable_activity: bool = None,
        disable_notification: bool = None,
        due_date: str = None,
        executor_id: str = None,
        involve_members: List[str] = None,
        note: str = None,
        visible: str = None,
    ):
        # This parameter is required.
        self.content = content
        self.disable_activity = disable_activity
        self.disable_notification = disable_notification
        self.due_date = due_date
        self.executor_id = executor_id
        self.involve_members = involve_members
        self.note = note
        # This parameter is required.
        self.visible = visible

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.disable_activity is not None:
            result['disableActivity'] = self.disable_activity
        if self.disable_notification is not None:
            result['disableNotification'] = self.disable_notification
        if self.due_date is not None:
            result['dueDate'] = self.due_date
        if self.executor_id is not None:
            result['executorId'] = self.executor_id
        if self.involve_members is not None:
            result['involveMembers'] = self.involve_members
        if self.note is not None:
            result['note'] = self.note
        if self.visible is not None:
            result['visible'] = self.visible
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('disableActivity') is not None:
            self.disable_activity = m.get('disableActivity')
        if m.get('disableNotification') is not None:
            self.disable_notification = m.get('disableNotification')
        if m.get('dueDate') is not None:
            self.due_date = m.get('dueDate')
        if m.get('executorId') is not None:
            self.executor_id = m.get('executorId')
        if m.get('involveMembers') is not None:
            self.involve_members = m.get('involveMembers')
        if m.get('note') is not None:
            self.note = m.get('note')
        if m.get('visible') is not None:
            self.visible = m.get('visible')
        return self


class CreateOrganizationTaskResponseBodyResultCreator(TeaModel):
    def __init__(
        self,
        avatar_url: str = None,
        name: str = None,
        user_id: str = None,
    ):
        self.avatar_url = avatar_url
        self.name = name
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.avatar_url is not None:
            result['avatarUrl'] = self.avatar_url
        if self.name is not None:
            result['name'] = self.name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('avatarUrl') is not None:
            self.avatar_url = m.get('avatarUrl')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CreateOrganizationTaskResponseBodyResultExecutor(TeaModel):
    def __init__(
        self,
        avatar_url: str = None,
        name: str = None,
        user_id: str = None,
    ):
        self.avatar_url = avatar_url
        self.name = name
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.avatar_url is not None:
            result['avatarUrl'] = self.avatar_url
        if self.name is not None:
            result['name'] = self.name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('avatarUrl') is not None:
            self.avatar_url = m.get('avatarUrl')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CreateOrganizationTaskResponseBodyResultInvolvers(TeaModel):
    def __init__(
        self,
        avatar_url: str = None,
        id: str = None,
        name: str = None,
    ):
        self.avatar_url = avatar_url
        self.id = id
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.avatar_url is not None:
            result['avatarUrl'] = self.avatar_url
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('avatarUrl') is not None:
            self.avatar_url = m.get('avatarUrl')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class CreateOrganizationTaskResponseBodyResult(TeaModel):
    def __init__(
        self,
        ancestor_ids: List[str] = None,
        attachments_count: int = None,
        content: str = None,
        created: str = None,
        creator: CreateOrganizationTaskResponseBodyResultCreator = None,
        creator_id: str = None,
        due_date: str = None,
        executor: CreateOrganizationTaskResponseBodyResultExecutor = None,
        executor_id: str = None,
        has_reminder: bool = None,
        id: str = None,
        involve_members: List[str] = None,
        involvers: List[CreateOrganizationTaskResponseBodyResultInvolvers] = None,
        is_deleted: bool = None,
        is_done: str = None,
        note: str = None,
        updated: str = None,
        visible: str = None,
    ):
        self.ancestor_ids = ancestor_ids
        self.attachments_count = attachments_count
        self.content = content
        self.created = created
        self.creator = creator
        self.creator_id = creator_id
        self.due_date = due_date
        self.executor = executor
        self.executor_id = executor_id
        self.has_reminder = has_reminder
        self.id = id
        self.involve_members = involve_members
        self.involvers = involvers
        self.is_deleted = is_deleted
        self.is_done = is_done
        self.note = note
        self.updated = updated
        self.visible = visible

    def validate(self):
        if self.creator:
            self.creator.validate()
        if self.executor:
            self.executor.validate()
        if self.involvers:
            for k in self.involvers:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ancestor_ids is not None:
            result['ancestorIds'] = self.ancestor_ids
        if self.attachments_count is not None:
            result['attachmentsCount'] = self.attachments_count
        if self.content is not None:
            result['content'] = self.content
        if self.created is not None:
            result['created'] = self.created
        if self.creator is not None:
            result['creator'] = self.creator.to_map()
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.due_date is not None:
            result['dueDate'] = self.due_date
        if self.executor is not None:
            result['executor'] = self.executor.to_map()
        if self.executor_id is not None:
            result['executorId'] = self.executor_id
        if self.has_reminder is not None:
            result['hasReminder'] = self.has_reminder
        if self.id is not None:
            result['id'] = self.id
        if self.involve_members is not None:
            result['involveMembers'] = self.involve_members
        result['involvers'] = []
        if self.involvers is not None:
            for k in self.involvers:
                result['involvers'].append(k.to_map() if k else None)
        if self.is_deleted is not None:
            result['isDeleted'] = self.is_deleted
        if self.is_done is not None:
            result['isDone'] = self.is_done
        if self.note is not None:
            result['note'] = self.note
        if self.updated is not None:
            result['updated'] = self.updated
        if self.visible is not None:
            result['visible'] = self.visible
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('ancestorIds') is not None:
            self.ancestor_ids = m.get('ancestorIds')
        if m.get('attachmentsCount') is not None:
            self.attachments_count = m.get('attachmentsCount')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('created') is not None:
            self.created = m.get('created')
        if m.get('creator') is not None:
            temp_model = CreateOrganizationTaskResponseBodyResultCreator()
            self.creator = temp_model.from_map(m['creator'])
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('dueDate') is not None:
            self.due_date = m.get('dueDate')
        if m.get('executor') is not None:
            temp_model = CreateOrganizationTaskResponseBodyResultExecutor()
            self.executor = temp_model.from_map(m['executor'])
        if m.get('executorId') is not None:
            self.executor_id = m.get('executorId')
        if m.get('hasReminder') is not None:
            self.has_reminder = m.get('hasReminder')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('involveMembers') is not None:
            self.involve_members = m.get('involveMembers')
        self.involvers = []
        if m.get('involvers') is not None:
            for k in m.get('involvers'):
                temp_model = CreateOrganizationTaskResponseBodyResultInvolvers()
                self.involvers.append(temp_model.from_map(k))
        if m.get('isDeleted') is not None:
            self.is_deleted = m.get('isDeleted')
        if m.get('isDone') is not None:
            self.is_done = m.get('isDone')
        if m.get('note') is not None:
            self.note = m.get('note')
        if m.get('updated') is not None:
            self.updated = m.get('updated')
        if m.get('visible') is not None:
            self.visible = m.get('visible')
        return self


class CreateOrganizationTaskResponseBody(TeaModel):
    def __init__(
        self,
        result: CreateOrganizationTaskResponseBodyResult = None,
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
            temp_model = CreateOrganizationTaskResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class CreateOrganizationTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateOrganizationTaskResponseBody = None,
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
            temp_model = CreateOrganizationTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateProjectV3Headers(TeaModel):
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


class CreateProjectV3Request(TeaModel):
    def __init__(
        self,
        name: str = None,
        organization_id: str = None,
    ):
        self.name = name
        self.organization_id = organization_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.organization_id is not None:
            result['organizationId'] = self.organization_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('organizationId') is not None:
            self.organization_id = m.get('organizationId')
        return self


class CreateProjectV3ResponseBodyResult(TeaModel):
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


class CreateProjectV3ResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: CreateProjectV3ResponseBodyResult = None,
    ):
        self.request_id = request_id
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            temp_model = CreateProjectV3ResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class CreateProjectV3Response(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateProjectV3ResponseBody = None,
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
            temp_model = CreateProjectV3ResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateTaskHeaders(TeaModel):
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


class CreateTaskRequestCustomfieldsValue(TeaModel):
    def __init__(
        self,
        id: str = None,
        thumb_url: str = None,
        title: str = None,
    ):
        self.id = id
        self.thumb_url = thumb_url
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.thumb_url is not None:
            result['thumbUrl'] = self.thumb_url
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('thumbUrl') is not None:
            self.thumb_url = m.get('thumbUrl')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class CreateTaskRequestCustomfields(TeaModel):
    def __init__(
        self,
        customfield_id: str = None,
        customfield_name: str = None,
        value: List[CreateTaskRequestCustomfieldsValue] = None,
    ):
        self.customfield_id = customfield_id
        self.customfield_name = customfield_name
        self.value = value

    def validate(self):
        if self.value:
            for k in self.value:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.customfield_id is not None:
            result['customfieldId'] = self.customfield_id
        if self.customfield_name is not None:
            result['customfieldName'] = self.customfield_name
        result['value'] = []
        if self.value is not None:
            for k in self.value:
                result['value'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customfieldId') is not None:
            self.customfield_id = m.get('customfieldId')
        if m.get('customfieldName') is not None:
            self.customfield_name = m.get('customfieldName')
        self.value = []
        if m.get('value') is not None:
            for k in m.get('value'):
                temp_model = CreateTaskRequestCustomfieldsValue()
                self.value.append(temp_model.from_map(k))
        return self


class CreateTaskRequest(TeaModel):
    def __init__(
        self,
        content: str = None,
        customfields: List[CreateTaskRequestCustomfields] = None,
        due_date: str = None,
        executor_id: str = None,
        note: str = None,
        project_id: str = None,
    ):
        # This parameter is required.
        self.content = content
        self.customfields = customfields
        self.due_date = due_date
        self.executor_id = executor_id
        self.note = note
        # This parameter is required.
        self.project_id = project_id

    def validate(self):
        if self.customfields:
            for k in self.customfields:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        result['customfields'] = []
        if self.customfields is not None:
            for k in self.customfields:
                result['customfields'].append(k.to_map() if k else None)
        if self.due_date is not None:
            result['dueDate'] = self.due_date
        if self.executor_id is not None:
            result['executorId'] = self.executor_id
        if self.note is not None:
            result['note'] = self.note
        if self.project_id is not None:
            result['projectId'] = self.project_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        self.customfields = []
        if m.get('customfields') is not None:
            for k in m.get('customfields'):
                temp_model = CreateTaskRequestCustomfields()
                self.customfields.append(temp_model.from_map(k))
        if m.get('dueDate') is not None:
            self.due_date = m.get('dueDate')
        if m.get('executorId') is not None:
            self.executor_id = m.get('executorId')
        if m.get('note') is not None:
            self.note = m.get('note')
        if m.get('projectId') is not None:
            self.project_id = m.get('projectId')
        return self


class CreateTaskResponseBodyResultCustomfieldsValue(TeaModel):
    def __init__(
        self,
        title: str = None,
    ):
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class CreateTaskResponseBodyResultCustomfields(TeaModel):
    def __init__(
        self,
        customfield_id: str = None,
        value: List[CreateTaskResponseBodyResultCustomfieldsValue] = None,
    ):
        self.customfield_id = customfield_id
        self.value = value

    def validate(self):
        if self.value:
            for k in self.value:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.customfield_id is not None:
            result['customfieldId'] = self.customfield_id
        result['value'] = []
        if self.value is not None:
            for k in self.value:
                result['value'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customfieldId') is not None:
            self.customfield_id = m.get('customfieldId')
        self.value = []
        if m.get('value') is not None:
            for k in m.get('value'):
                temp_model = CreateTaskResponseBodyResultCustomfieldsValue()
                self.value.append(temp_model.from_map(k))
        return self


class CreateTaskResponseBodyResult(TeaModel):
    def __init__(
        self,
        content: str = None,
        created: str = None,
        creator_id: str = None,
        customfields: List[CreateTaskResponseBodyResultCustomfields] = None,
        due_date: str = None,
        executor_id: str = None,
        involve_members: List[str] = None,
        note: str = None,
        priority: int = None,
        project_id: str = None,
        task_id: str = None,
        updated: str = None,
    ):
        self.content = content
        self.created = created
        self.creator_id = creator_id
        self.customfields = customfields
        self.due_date = due_date
        self.executor_id = executor_id
        self.involve_members = involve_members
        self.note = note
        self.priority = priority
        self.project_id = project_id
        self.task_id = task_id
        self.updated = updated

    def validate(self):
        if self.customfields:
            for k in self.customfields:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.created is not None:
            result['created'] = self.created
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        result['customfields'] = []
        if self.customfields is not None:
            for k in self.customfields:
                result['customfields'].append(k.to_map() if k else None)
        if self.due_date is not None:
            result['dueDate'] = self.due_date
        if self.executor_id is not None:
            result['executorId'] = self.executor_id
        if self.involve_members is not None:
            result['involveMembers'] = self.involve_members
        if self.note is not None:
            result['note'] = self.note
        if self.priority is not None:
            result['priority'] = self.priority
        if self.project_id is not None:
            result['projectId'] = self.project_id
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.updated is not None:
            result['updated'] = self.updated
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('created') is not None:
            self.created = m.get('created')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        self.customfields = []
        if m.get('customfields') is not None:
            for k in m.get('customfields'):
                temp_model = CreateTaskResponseBodyResultCustomfields()
                self.customfields.append(temp_model.from_map(k))
        if m.get('dueDate') is not None:
            self.due_date = m.get('dueDate')
        if m.get('executorId') is not None:
            self.executor_id = m.get('executorId')
        if m.get('involveMembers') is not None:
            self.involve_members = m.get('involveMembers')
        if m.get('note') is not None:
            self.note = m.get('note')
        if m.get('priority') is not None:
            self.priority = m.get('priority')
        if m.get('projectId') is not None:
            self.project_id = m.get('projectId')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('updated') is not None:
            self.updated = m.get('updated')
        return self


class CreateTaskResponseBody(TeaModel):
    def __init__(
        self,
        result: CreateTaskResponseBodyResult = None,
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
            temp_model = CreateTaskResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class CreateTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateTaskResponseBody = None,
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
            temp_model = CreateTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetFreeTaskHeaders(TeaModel):
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


class GetFreeTaskRequest(TeaModel):
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


class GetFreeTaskResponseBodyResult(TeaModel):
    def __init__(
        self,
        accomplished: str = None,
        ancestor_ids: List[str] = None,
        content: str = None,
        created: str = None,
        creator_id: str = None,
        due_date: str = None,
        executor_id: str = None,
        id: str = None,
        involve_members: List[str] = None,
        is_archive: bool = None,
        is_done: bool = None,
        note: str = None,
        organization_id: str = None,
        priority: int = None,
        recurrence: List[str] = None,
        source_id: str = None,
        start_date: str = None,
        tag_ids: List[str] = None,
        unique_id: int = None,
        updated: str = None,
        visible: str = None,
    ):
        self.accomplished = accomplished
        self.ancestor_ids = ancestor_ids
        self.content = content
        self.created = created
        self.creator_id = creator_id
        self.due_date = due_date
        self.executor_id = executor_id
        self.id = id
        self.involve_members = involve_members
        self.is_archive = is_archive
        self.is_done = is_done
        self.note = note
        self.organization_id = organization_id
        self.priority = priority
        self.recurrence = recurrence
        self.source_id = source_id
        self.start_date = start_date
        self.tag_ids = tag_ids
        self.unique_id = unique_id
        self.updated = updated
        self.visible = visible

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.accomplished is not None:
            result['accomplished'] = self.accomplished
        if self.ancestor_ids is not None:
            result['ancestorIds'] = self.ancestor_ids
        if self.content is not None:
            result['content'] = self.content
        if self.created is not None:
            result['created'] = self.created
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.due_date is not None:
            result['dueDate'] = self.due_date
        if self.executor_id is not None:
            result['executorId'] = self.executor_id
        if self.id is not None:
            result['id'] = self.id
        if self.involve_members is not None:
            result['involveMembers'] = self.involve_members
        if self.is_archive is not None:
            result['isArchive'] = self.is_archive
        if self.is_done is not None:
            result['isDone'] = self.is_done
        if self.note is not None:
            result['note'] = self.note
        if self.organization_id is not None:
            result['organizationId'] = self.organization_id
        if self.priority is not None:
            result['priority'] = self.priority
        if self.recurrence is not None:
            result['recurrence'] = self.recurrence
        if self.source_id is not None:
            result['sourceId'] = self.source_id
        if self.start_date is not None:
            result['startDate'] = self.start_date
        if self.tag_ids is not None:
            result['tagIds'] = self.tag_ids
        if self.unique_id is not None:
            result['uniqueId'] = self.unique_id
        if self.updated is not None:
            result['updated'] = self.updated
        if self.visible is not None:
            result['visible'] = self.visible
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accomplished') is not None:
            self.accomplished = m.get('accomplished')
        if m.get('ancestorIds') is not None:
            self.ancestor_ids = m.get('ancestorIds')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('created') is not None:
            self.created = m.get('created')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('dueDate') is not None:
            self.due_date = m.get('dueDate')
        if m.get('executorId') is not None:
            self.executor_id = m.get('executorId')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('involveMembers') is not None:
            self.involve_members = m.get('involveMembers')
        if m.get('isArchive') is not None:
            self.is_archive = m.get('isArchive')
        if m.get('isDone') is not None:
            self.is_done = m.get('isDone')
        if m.get('note') is not None:
            self.note = m.get('note')
        if m.get('organizationId') is not None:
            self.organization_id = m.get('organizationId')
        if m.get('priority') is not None:
            self.priority = m.get('priority')
        if m.get('recurrence') is not None:
            self.recurrence = m.get('recurrence')
        if m.get('sourceId') is not None:
            self.source_id = m.get('sourceId')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        if m.get('tagIds') is not None:
            self.tag_ids = m.get('tagIds')
        if m.get('uniqueId') is not None:
            self.unique_id = m.get('uniqueId')
        if m.get('updated') is not None:
            self.updated = m.get('updated')
        if m.get('visible') is not None:
            self.visible = m.get('visible')
        return self


class GetFreeTaskResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: GetFreeTaskResponseBodyResult = None,
    ):
        self.request_id = request_id
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            temp_model = GetFreeTaskResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetFreeTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetFreeTaskResponseBody = None,
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
            temp_model = GetFreeTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetTbUserIdByDingUserIdHeaders(TeaModel):
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


class GetTbUserIdByDingUserIdRequest(TeaModel):
    def __init__(
        self,
        ding_user_ids: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.ding_user_ids = ding_user_ids
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_user_ids is not None:
            result['dingUserIds'] = self.ding_user_ids
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingUserIds') is not None:
            self.ding_user_ids = m.get('dingUserIds')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetTbUserIdByDingUserIdResponseBodyResult(TeaModel):
    def __init__(
        self,
        dingtalk_user_id: str = None,
        tb_user_id: str = None,
    ):
        self.dingtalk_user_id = dingtalk_user_id
        self.tb_user_id = tb_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dingtalk_user_id is not None:
            result['dingtalkUserId'] = self.dingtalk_user_id
        if self.tb_user_id is not None:
            result['tbUserId'] = self.tb_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingtalkUserId') is not None:
            self.dingtalk_user_id = m.get('dingtalkUserId')
        if m.get('tbUserId') is not None:
            self.tb_user_id = m.get('tbUserId')
        return self


class GetTbUserIdByDingUserIdResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: List[GetTbUserIdByDingUserIdResponseBodyResult] = None,
    ):
        self.request_id = request_id
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
        if self.request_id is not None:
            result['requestId'] = self.request_id
        result['result'] = []
        if self.result is not None:
            for k in self.result:
                result['result'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = GetTbUserIdByDingUserIdResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GetTbUserIdByDingUserIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetTbUserIdByDingUserIdResponseBody = None,
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
            temp_model = GetTbUserIdByDingUserIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetThingOrgIdByDingOrgIdHeaders(TeaModel):
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


class GetThingOrgIdByDingOrgIdResponseBodyResult(TeaModel):
    def __init__(
        self,
        tb_organization_id: str = None,
    ):
        # This parameter is required.
        self.tb_organization_id = tb_organization_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.tb_organization_id is not None:
            result['tbOrganizationId'] = self.tb_organization_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('tbOrganizationId') is not None:
            self.tb_organization_id = m.get('tbOrganizationId')
        return self


class GetThingOrgIdByDingOrgIdResponseBody(TeaModel):
    def __init__(
        self,
        result: GetThingOrgIdByDingOrgIdResponseBodyResult = None,
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
            temp_model = GetThingOrgIdByDingOrgIdResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetThingOrgIdByDingOrgIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetThingOrgIdByDingOrgIdResponseBody = None,
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
            temp_model = GetThingOrgIdByDingOrgIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetUserJoinedProjectsV3Headers(TeaModel):
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


class GetUserJoinedProjectsV3Request(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        project_ids: str = None,
        project_role_levels: str = None,
        sort_by: str = None,
    ):
        self.max_results = max_results
        self.next_token = next_token
        self.project_ids = project_ids
        self.project_role_levels = project_role_levels
        self.sort_by = sort_by

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
        if self.project_ids is not None:
            result['projectIds'] = self.project_ids
        if self.project_role_levels is not None:
            result['projectRoleLevels'] = self.project_role_levels
        if self.sort_by is not None:
            result['sortBy'] = self.sort_by
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('projectIds') is not None:
            self.project_ids = m.get('projectIds')
        if m.get('projectRoleLevels') is not None:
            self.project_role_levels = m.get('projectRoleLevels')
        if m.get('sortBy') is not None:
            self.sort_by = m.get('sortBy')
        return self


class GetUserJoinedProjectsV3ResponseBody(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        request_id: str = None,
        result: List[str] = None,
    ):
        self.next_token = next_token
        self.request_id = request_id
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class GetUserJoinedProjectsV3Response(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetUserJoinedProjectsV3ResponseBody = None,
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
            temp_model = GetUserJoinedProjectsV3ResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListAllTaskViewHeaders(TeaModel):
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


class ListAllTaskViewRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
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


class ListAllTaskViewResponseBodyResultGroupType(TeaModel):
    def __init__(
        self,
        can_create_group: bool = None,
        name: str = None,
        value: str = None,
    ):
        self.can_create_group = can_create_group
        self.name = name
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.can_create_group is not None:
            result['canCreateGroup'] = self.can_create_group
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('canCreateGroup') is not None:
            self.can_create_group = m.get('canCreateGroup')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class ListAllTaskViewResponseBodyResultOrderType(TeaModel):
    def __init__(
        self,
        direction: str = None,
        name: str = None,
        value: str = None,
    ):
        self.direction = direction
        self.name = name
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.direction is not None:
            result['direction'] = self.direction
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('direction') is not None:
            self.direction = m.get('direction')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class ListAllTaskViewResponseBodyResultShowType(TeaModel):
    def __init__(
        self,
        name: str = None,
        value: str = None,
    ):
        self.name = name
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class ListAllTaskViewResponseBodyResultViewSetting(TeaModel):
    def __init__(
        self,
        show_done_task: bool = None,
        show_sub_task: bool = None,
    ):
        self.show_done_task = show_done_task
        self.show_sub_task = show_sub_task

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.show_done_task is not None:
            result['showDoneTask'] = self.show_done_task
        if self.show_sub_task is not None:
            result['showSubTask'] = self.show_sub_task
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('showDoneTask') is not None:
            self.show_done_task = m.get('showDoneTask')
        if m.get('showSubTask') is not None:
            self.show_sub_task = m.get('showSubTask')
        return self


class ListAllTaskViewResponseBodyResult(TeaModel):
    def __init__(
        self,
        bound_to_object_id: str = None,
        bound_to_object_type: str = None,
        created: str = None,
        creator_id: str = None,
        description: str = None,
        group_type: ListAllTaskViewResponseBodyResultGroupType = None,
        id: str = None,
        is_deleted: bool = None,
        name: str = None,
        order_type: ListAllTaskViewResponseBodyResultOrderType = None,
        organization_id: str = None,
        show_type: ListAllTaskViewResponseBodyResultShowType = None,
        updated: str = None,
        view_setting: ListAllTaskViewResponseBodyResultViewSetting = None,
    ):
        self.bound_to_object_id = bound_to_object_id
        self.bound_to_object_type = bound_to_object_type
        self.created = created
        self.creator_id = creator_id
        self.description = description
        self.group_type = group_type
        self.id = id
        self.is_deleted = is_deleted
        self.name = name
        self.order_type = order_type
        self.organization_id = organization_id
        self.show_type = show_type
        self.updated = updated
        self.view_setting = view_setting

    def validate(self):
        if self.group_type:
            self.group_type.validate()
        if self.order_type:
            self.order_type.validate()
        if self.show_type:
            self.show_type.validate()
        if self.view_setting:
            self.view_setting.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.bound_to_object_id is not None:
            result['boundToObjectId'] = self.bound_to_object_id
        if self.bound_to_object_type is not None:
            result['boundToObjectType'] = self.bound_to_object_type
        if self.created is not None:
            result['created'] = self.created
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.description is not None:
            result['description'] = self.description
        if self.group_type is not None:
            result['groupType'] = self.group_type.to_map()
        if self.id is not None:
            result['id'] = self.id
        if self.is_deleted is not None:
            result['isDeleted'] = self.is_deleted
        if self.name is not None:
            result['name'] = self.name
        if self.order_type is not None:
            result['orderType'] = self.order_type.to_map()
        if self.organization_id is not None:
            result['organizationId'] = self.organization_id
        if self.show_type is not None:
            result['showType'] = self.show_type.to_map()
        if self.updated is not None:
            result['updated'] = self.updated
        if self.view_setting is not None:
            result['viewSetting'] = self.view_setting.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('boundToObjectId') is not None:
            self.bound_to_object_id = m.get('boundToObjectId')
        if m.get('boundToObjectType') is not None:
            self.bound_to_object_type = m.get('boundToObjectType')
        if m.get('created') is not None:
            self.created = m.get('created')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('groupType') is not None:
            temp_model = ListAllTaskViewResponseBodyResultGroupType()
            self.group_type = temp_model.from_map(m['groupType'])
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isDeleted') is not None:
            self.is_deleted = m.get('isDeleted')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('orderType') is not None:
            temp_model = ListAllTaskViewResponseBodyResultOrderType()
            self.order_type = temp_model.from_map(m['orderType'])
        if m.get('organizationId') is not None:
            self.organization_id = m.get('organizationId')
        if m.get('showType') is not None:
            temp_model = ListAllTaskViewResponseBodyResultShowType()
            self.show_type = temp_model.from_map(m['showType'])
        if m.get('updated') is not None:
            self.updated = m.get('updated')
        if m.get('viewSetting') is not None:
            temp_model = ListAllTaskViewResponseBodyResultViewSetting()
            self.view_setting = temp_model.from_map(m['viewSetting'])
        return self


class ListAllTaskViewResponseBody(TeaModel):
    def __init__(
        self,
        result: ListAllTaskViewResponseBodyResult = None,
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
            temp_model = ListAllTaskViewResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class ListAllTaskViewResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListAllTaskViewResponseBody = None,
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
            temp_model = ListAllTaskViewResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListMyShortcutViewsHeaders(TeaModel):
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


class ListMyShortcutViewsRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
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


class ListMyShortcutViewsResponseBodyResultGroupType(TeaModel):
    def __init__(
        self,
        can_create_group: bool = None,
        name: str = None,
        value: str = None,
    ):
        self.can_create_group = can_create_group
        self.name = name
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.can_create_group is not None:
            result['canCreateGroup'] = self.can_create_group
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('canCreateGroup') is not None:
            self.can_create_group = m.get('canCreateGroup')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class ListMyShortcutViewsResponseBodyResultOrderType(TeaModel):
    def __init__(
        self,
        direction: str = None,
        name: str = None,
        value: str = None,
    ):
        self.direction = direction
        self.name = name
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.direction is not None:
            result['direction'] = self.direction
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('direction') is not None:
            self.direction = m.get('direction')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class ListMyShortcutViewsResponseBodyResultShowType(TeaModel):
    def __init__(
        self,
        name: str = None,
        value: str = None,
    ):
        self.name = name
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class ListMyShortcutViewsResponseBodyResultViewSetting(TeaModel):
    def __init__(
        self,
        show_done_task: bool = None,
        show_sub_task: bool = None,
    ):
        self.show_done_task = show_done_task
        self.show_sub_task = show_sub_task

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.show_done_task is not None:
            result['showDoneTask'] = self.show_done_task
        if self.show_sub_task is not None:
            result['showSubTask'] = self.show_sub_task
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('showDoneTask') is not None:
            self.show_done_task = m.get('showDoneTask')
        if m.get('showSubTask') is not None:
            self.show_sub_task = m.get('showSubTask')
        return self


class ListMyShortcutViewsResponseBodyResult(TeaModel):
    def __init__(
        self,
        bound_to_object_id: str = None,
        bound_to_object_type: str = None,
        created: str = None,
        creator_id: str = None,
        description: str = None,
        group_type: ListMyShortcutViewsResponseBodyResultGroupType = None,
        id: str = None,
        is_deleted: bool = None,
        name: str = None,
        order_type: ListMyShortcutViewsResponseBodyResultOrderType = None,
        organization_id: str = None,
        show_type: ListMyShortcutViewsResponseBodyResultShowType = None,
        updated: str = None,
        view_setting: ListMyShortcutViewsResponseBodyResultViewSetting = None,
    ):
        self.bound_to_object_id = bound_to_object_id
        self.bound_to_object_type = bound_to_object_type
        self.created = created
        self.creator_id = creator_id
        self.description = description
        self.group_type = group_type
        self.id = id
        self.is_deleted = is_deleted
        self.name = name
        self.order_type = order_type
        self.organization_id = organization_id
        self.show_type = show_type
        self.updated = updated
        self.view_setting = view_setting

    def validate(self):
        if self.group_type:
            self.group_type.validate()
        if self.order_type:
            self.order_type.validate()
        if self.show_type:
            self.show_type.validate()
        if self.view_setting:
            self.view_setting.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.bound_to_object_id is not None:
            result['boundToObjectId'] = self.bound_to_object_id
        if self.bound_to_object_type is not None:
            result['boundToObjectType'] = self.bound_to_object_type
        if self.created is not None:
            result['created'] = self.created
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.description is not None:
            result['description'] = self.description
        if self.group_type is not None:
            result['groupType'] = self.group_type.to_map()
        if self.id is not None:
            result['id'] = self.id
        if self.is_deleted is not None:
            result['isDeleted'] = self.is_deleted
        if self.name is not None:
            result['name'] = self.name
        if self.order_type is not None:
            result['orderType'] = self.order_type.to_map()
        if self.organization_id is not None:
            result['organizationId'] = self.organization_id
        if self.show_type is not None:
            result['showType'] = self.show_type.to_map()
        if self.updated is not None:
            result['updated'] = self.updated
        if self.view_setting is not None:
            result['viewSetting'] = self.view_setting.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('boundToObjectId') is not None:
            self.bound_to_object_id = m.get('boundToObjectId')
        if m.get('boundToObjectType') is not None:
            self.bound_to_object_type = m.get('boundToObjectType')
        if m.get('created') is not None:
            self.created = m.get('created')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('groupType') is not None:
            temp_model = ListMyShortcutViewsResponseBodyResultGroupType()
            self.group_type = temp_model.from_map(m['groupType'])
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isDeleted') is not None:
            self.is_deleted = m.get('isDeleted')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('orderType') is not None:
            temp_model = ListMyShortcutViewsResponseBodyResultOrderType()
            self.order_type = temp_model.from_map(m['orderType'])
        if m.get('organizationId') is not None:
            self.organization_id = m.get('organizationId')
        if m.get('showType') is not None:
            temp_model = ListMyShortcutViewsResponseBodyResultShowType()
            self.show_type = temp_model.from_map(m['showType'])
        if m.get('updated') is not None:
            self.updated = m.get('updated')
        if m.get('viewSetting') is not None:
            temp_model = ListMyShortcutViewsResponseBodyResultViewSetting()
            self.view_setting = temp_model.from_map(m['viewSetting'])
        return self


class ListMyShortcutViewsResponseBody(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        result: List[ListMyShortcutViewsResponseBodyResult] = None,
    ):
        self.next_token = next_token
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
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['result'] = []
        if self.result is not None:
            for k in self.result:
                result['result'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = ListMyShortcutViewsResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class ListMyShortcutViewsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListMyShortcutViewsResponseBody = None,
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
            temp_model = ListMyShortcutViewsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryTaskHeaders(TeaModel):
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


class QueryTaskRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        tql: str = None,
    ):
        self.max_results = max_results
        self.next_token = next_token
        self.tql = tql

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
        if self.tql is not None:
            result['tql'] = self.tql
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('tql') is not None:
            self.tql = m.get('tql')
        return self


class QueryTaskResponseBodyResultCustomfieldsValue(TeaModel):
    def __init__(
        self,
        id: str = None,
        meta_string: str = None,
        title: str = None,
    ):
        self.id = id
        self.meta_string = meta_string
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.meta_string is not None:
            result['metaString'] = self.meta_string
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('metaString') is not None:
            self.meta_string = m.get('metaString')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class QueryTaskResponseBodyResultCustomfields(TeaModel):
    def __init__(
        self,
        cf_id: str = None,
        type: str = None,
        value: List[QueryTaskResponseBodyResultCustomfieldsValue] = None,
    ):
        self.cf_id = cf_id
        self.type = type
        self.value = value

    def validate(self):
        if self.value:
            for k in self.value:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cf_id is not None:
            result['cfId'] = self.cf_id
        if self.type is not None:
            result['type'] = self.type
        result['value'] = []
        if self.value is not None:
            for k in self.value:
                result['value'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cfId') is not None:
            self.cf_id = m.get('cfId')
        if m.get('type') is not None:
            self.type = m.get('type')
        self.value = []
        if m.get('value') is not None:
            for k in m.get('value'):
                temp_model = QueryTaskResponseBodyResultCustomfieldsValue()
                self.value.append(temp_model.from_map(k))
        return self


class QueryTaskResponseBodyResult(TeaModel):
    def __init__(
        self,
        accomplish_time: str = None,
        content: str = None,
        created: str = None,
        creator_id: str = None,
        customfields: List[QueryTaskResponseBodyResultCustomfields] = None,
        due_date: str = None,
        executor_id: str = None,
        id: str = None,
        involve_members: List[str] = None,
        is_done: bool = None,
        note: str = None,
        project_id: str = None,
        task_id: str = None,
        updated: str = None,
    ):
        self.accomplish_time = accomplish_time
        self.content = content
        self.created = created
        self.creator_id = creator_id
        self.customfields = customfields
        self.due_date = due_date
        self.executor_id = executor_id
        self.id = id
        self.involve_members = involve_members
        self.is_done = is_done
        self.note = note
        self.project_id = project_id
        self.task_id = task_id
        self.updated = updated

    def validate(self):
        if self.customfields:
            for k in self.customfields:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.accomplish_time is not None:
            result['accomplishTime'] = self.accomplish_time
        if self.content is not None:
            result['content'] = self.content
        if self.created is not None:
            result['created'] = self.created
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        result['customfields'] = []
        if self.customfields is not None:
            for k in self.customfields:
                result['customfields'].append(k.to_map() if k else None)
        if self.due_date is not None:
            result['dueDate'] = self.due_date
        if self.executor_id is not None:
            result['executorId'] = self.executor_id
        if self.id is not None:
            result['id'] = self.id
        if self.involve_members is not None:
            result['involveMembers'] = self.involve_members
        if self.is_done is not None:
            result['isDone'] = self.is_done
        if self.note is not None:
            result['note'] = self.note
        if self.project_id is not None:
            result['projectId'] = self.project_id
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.updated is not None:
            result['updated'] = self.updated
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accomplishTime') is not None:
            self.accomplish_time = m.get('accomplishTime')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('created') is not None:
            self.created = m.get('created')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        self.customfields = []
        if m.get('customfields') is not None:
            for k in m.get('customfields'):
                temp_model = QueryTaskResponseBodyResultCustomfields()
                self.customfields.append(temp_model.from_map(k))
        if m.get('dueDate') is not None:
            self.due_date = m.get('dueDate')
        if m.get('executorId') is not None:
            self.executor_id = m.get('executorId')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('involveMembers') is not None:
            self.involve_members = m.get('involveMembers')
        if m.get('isDone') is not None:
            self.is_done = m.get('isDone')
        if m.get('note') is not None:
            self.note = m.get('note')
        if m.get('projectId') is not None:
            self.project_id = m.get('projectId')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('updated') is not None:
            self.updated = m.get('updated')
        return self


class QueryTaskResponseBody(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        request_id: str = None,
        result: List[QueryTaskResponseBodyResult] = None,
    ):
        self.next_token = next_token
        self.request_id = request_id
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
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.request_id is not None:
            result['requestId'] = self.request_id
        result['result'] = []
        if self.result is not None:
            for k in self.result:
                result['result'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = QueryTaskResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class QueryTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryTaskResponseBody = None,
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
            temp_model = QueryTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryTasksV3Headers(TeaModel):
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


class QueryTasksV3Request(TeaModel):
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


class QueryTasksV3ResponseBodyResultCustomfieldsValue(TeaModel):
    def __init__(
        self,
        id: str = None,
        meta_string: str = None,
        title: str = None,
    ):
        self.id = id
        self.meta_string = meta_string
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.meta_string is not None:
            result['metaString'] = self.meta_string
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('metaString') is not None:
            self.meta_string = m.get('metaString')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class QueryTasksV3ResponseBodyResultCustomfields(TeaModel):
    def __init__(
        self,
        cf_id: str = None,
        type: str = None,
        value: List[QueryTasksV3ResponseBodyResultCustomfieldsValue] = None,
    ):
        self.cf_id = cf_id
        self.type = type
        self.value = value

    def validate(self):
        if self.value:
            for k in self.value:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cf_id is not None:
            result['cfId'] = self.cf_id
        if self.type is not None:
            result['type'] = self.type
        result['value'] = []
        if self.value is not None:
            for k in self.value:
                result['value'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cfId') is not None:
            self.cf_id = m.get('cfId')
        if m.get('type') is not None:
            self.type = m.get('type')
        self.value = []
        if m.get('value') is not None:
            for k in m.get('value'):
                temp_model = QueryTasksV3ResponseBodyResultCustomfieldsValue()
                self.value.append(temp_model.from_map(k))
        return self


class QueryTasksV3ResponseBodyResult(TeaModel):
    def __init__(
        self,
        accomplish_time: str = None,
        content: str = None,
        created: str = None,
        creator_id: str = None,
        customfields: List[QueryTasksV3ResponseBodyResultCustomfields] = None,
        due_date: str = None,
        executor_id: str = None,
        id: str = None,
        involve_members: List[str] = None,
        is_done: bool = None,
        note: str = None,
        project_id: str = None,
        source_id: str = None,
        task_id: str = None,
        updated: str = None,
    ):
        self.accomplish_time = accomplish_time
        self.content = content
        self.created = created
        self.creator_id = creator_id
        self.customfields = customfields
        self.due_date = due_date
        self.executor_id = executor_id
        self.id = id
        self.involve_members = involve_members
        self.is_done = is_done
        self.note = note
        self.project_id = project_id
        self.source_id = source_id
        self.task_id = task_id
        self.updated = updated

    def validate(self):
        if self.customfields:
            for k in self.customfields:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.accomplish_time is not None:
            result['accomplishTime'] = self.accomplish_time
        if self.content is not None:
            result['content'] = self.content
        if self.created is not None:
            result['created'] = self.created
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        result['customfields'] = []
        if self.customfields is not None:
            for k in self.customfields:
                result['customfields'].append(k.to_map() if k else None)
        if self.due_date is not None:
            result['dueDate'] = self.due_date
        if self.executor_id is not None:
            result['executorId'] = self.executor_id
        if self.id is not None:
            result['id'] = self.id
        if self.involve_members is not None:
            result['involveMembers'] = self.involve_members
        if self.is_done is not None:
            result['isDone'] = self.is_done
        if self.note is not None:
            result['note'] = self.note
        if self.project_id is not None:
            result['projectId'] = self.project_id
        if self.source_id is not None:
            result['sourceId'] = self.source_id
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.updated is not None:
            result['updated'] = self.updated
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accomplishTime') is not None:
            self.accomplish_time = m.get('accomplishTime')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('created') is not None:
            self.created = m.get('created')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        self.customfields = []
        if m.get('customfields') is not None:
            for k in m.get('customfields'):
                temp_model = QueryTasksV3ResponseBodyResultCustomfields()
                self.customfields.append(temp_model.from_map(k))
        if m.get('dueDate') is not None:
            self.due_date = m.get('dueDate')
        if m.get('executorId') is not None:
            self.executor_id = m.get('executorId')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('involveMembers') is not None:
            self.involve_members = m.get('involveMembers')
        if m.get('isDone') is not None:
            self.is_done = m.get('isDone')
        if m.get('note') is not None:
            self.note = m.get('note')
        if m.get('projectId') is not None:
            self.project_id = m.get('projectId')
        if m.get('sourceId') is not None:
            self.source_id = m.get('sourceId')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('updated') is not None:
            self.updated = m.get('updated')
        return self


class QueryTasksV3ResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: List[QueryTasksV3ResponseBodyResult] = None,
    ):
        self.request_id = request_id
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
        if self.request_id is not None:
            result['requestId'] = self.request_id
        result['result'] = []
        if self.result is not None:
            for k in self.result:
                result['result'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = QueryTasksV3ResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class QueryTasksV3Response(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryTasksV3ResponseBody = None,
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
            temp_model = QueryTasksV3ResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SearchAllTasksByTqlHeaders(TeaModel):
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


class SearchAllTasksByTqlRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        tql: str = None,
        user_id: str = None,
    ):
        self.max_results = max_results
        self.next_token = next_token
        self.tql = tql
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
        if self.tql is not None:
            result['tql'] = self.tql
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('tql') is not None:
            self.tql = m.get('tql')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class SearchAllTasksByTqlResponseBody(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        request_id: str = None,
        result: List[str] = None,
        total_size: int = None,
    ):
        self.next_token = next_token
        self.request_id = request_id
        self.result = result
        self.total_size = total_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.result is not None:
            result['result'] = self.result
        if self.total_size is not None:
            result['totalSize'] = self.total_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('totalSize') is not None:
            self.total_size = m.get('totalSize')
        return self


class SearchAllTasksByTqlResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SearchAllTasksByTqlResponseBody = None,
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
            temp_model = SearchAllTasksByTqlResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SearchProjectsV3Headers(TeaModel):
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


class SearchProjectsV3Request(TeaModel):
    def __init__(
        self,
        include_template: bool = None,
        max_results: int = None,
        name: str = None,
        next_token: str = None,
        project_ids: str = None,
        source_id: str = None,
        user_id: str = None,
    ):
        self.include_template = include_template
        self.max_results = max_results
        self.name = name
        self.next_token = next_token
        self.project_ids = project_ids
        self.source_id = source_id
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.include_template is not None:
            result['includeTemplate'] = self.include_template
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.name is not None:
            result['name'] = self.name
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.project_ids is not None:
            result['projectIds'] = self.project_ids
        if self.source_id is not None:
            result['sourceId'] = self.source_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('includeTemplate') is not None:
            self.include_template = m.get('includeTemplate')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('projectIds') is not None:
            self.project_ids = m.get('projectIds')
        if m.get('sourceId') is not None:
            self.source_id = m.get('sourceId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class SearchProjectsV3ResponseBodyResult(TeaModel):
    def __init__(
        self,
        created: str = None,
        creator_id: str = None,
        description: str = None,
        id: str = None,
        is_template: bool = None,
        logo: str = None,
        name: str = None,
        organization_id: str = None,
        source_id: str = None,
        updated: str = None,
    ):
        self.created = created
        self.creator_id = creator_id
        self.description = description
        self.id = id
        self.is_template = is_template
        self.logo = logo
        self.name = name
        self.organization_id = organization_id
        self.source_id = source_id
        self.updated = updated

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.created is not None:
            result['created'] = self.created
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.description is not None:
            result['description'] = self.description
        if self.id is not None:
            result['id'] = self.id
        if self.is_template is not None:
            result['isTemplate'] = self.is_template
        if self.logo is not None:
            result['logo'] = self.logo
        if self.name is not None:
            result['name'] = self.name
        if self.organization_id is not None:
            result['organizationId'] = self.organization_id
        if self.source_id is not None:
            result['sourceId'] = self.source_id
        if self.updated is not None:
            result['updated'] = self.updated
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('created') is not None:
            self.created = m.get('created')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isTemplate') is not None:
            self.is_template = m.get('isTemplate')
        if m.get('logo') is not None:
            self.logo = m.get('logo')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('organizationId') is not None:
            self.organization_id = m.get('organizationId')
        if m.get('sourceId') is not None:
            self.source_id = m.get('sourceId')
        if m.get('updated') is not None:
            self.updated = m.get('updated')
        return self


class SearchProjectsV3ResponseBody(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        request_id: str = None,
        result: List[SearchProjectsV3ResponseBodyResult] = None,
    ):
        self.next_token = next_token
        self.request_id = request_id
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
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.request_id is not None:
            result['requestId'] = self.request_id
        result['result'] = []
        if self.result is not None:
            for k in self.result:
                result['result'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = SearchProjectsV3ResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class SearchProjectsV3Response(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SearchProjectsV3ResponseBody = None,
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
            temp_model = SearchProjectsV3ResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateProjectV3Headers(TeaModel):
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


class UpdateProjectV3Request(TeaModel):
    def __init__(
        self,
        description: str = None,
        name: str = None,
    ):
        self.description = description
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.description is not None:
            result['description'] = self.description
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class UpdateProjectV3ResponseBodyResult(TeaModel):
    def __init__(
        self,
        updated: str = None,
    ):
        self.updated = updated

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.updated is not None:
            result['updated'] = self.updated
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('updated') is not None:
            self.updated = m.get('updated')
        return self


class UpdateProjectV3ResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: UpdateProjectV3ResponseBodyResult = None,
    ):
        self.request_id = request_id
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            temp_model = UpdateProjectV3ResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class UpdateProjectV3Response(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateProjectV3ResponseBody = None,
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
            temp_model = UpdateProjectV3ResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


