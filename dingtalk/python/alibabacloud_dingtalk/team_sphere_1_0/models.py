# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


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
        parent_task_id: str = None,
        short_ids: str = None,
        task_id: str = None,
    ):
        self.parent_task_id = parent_task_id
        self.short_ids = short_ids
        self.task_id = task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.parent_task_id is not None:
            result['parentTaskId'] = self.parent_task_id
        if self.short_ids is not None:
            result['shortIds'] = self.short_ids
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('parentTaskId') is not None:
            self.parent_task_id = m.get('parentTaskId')
        if m.get('shortIds') is not None:
            self.short_ids = m.get('shortIds')
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
        ancestor_ids: List[str] = None,
        content: str = None,
        created: str = None,
        creator_id: str = None,
        customfields: List[QueryTasksV3ResponseBodyResultCustomfields] = None,
        due_date: str = None,
        executor_id: str = None,
        id: str = None,
        involve_members: List[str] = None,
        is_archived: bool = None,
        is_done: bool = None,
        note: str = None,
        parent_task_id: str = None,
        priority: int = None,
        progress: int = None,
        project_id: str = None,
        recurrence: List[str] = None,
        sfc_id: str = None,
        source_id: str = None,
        sprint_id: str = None,
        stage_id: str = None,
        start_date: str = None,
        story_point: str = None,
        tag_ids: List[str] = None,
        task_id: str = None,
        tasklist_id: str = None,
        tfs_id: str = None,
        unique_id: str = None,
        updated: str = None,
        visible: str = None,
    ):
        self.accomplish_time = accomplish_time
        self.ancestor_ids = ancestor_ids
        self.content = content
        self.created = created
        self.creator_id = creator_id
        self.customfields = customfields
        self.due_date = due_date
        self.executor_id = executor_id
        self.id = id
        self.involve_members = involve_members
        self.is_archived = is_archived
        self.is_done = is_done
        self.note = note
        self.parent_task_id = parent_task_id
        self.priority = priority
        self.progress = progress
        self.project_id = project_id
        self.recurrence = recurrence
        self.sfc_id = sfc_id
        self.source_id = source_id
        self.sprint_id = sprint_id
        self.stage_id = stage_id
        self.start_date = start_date
        self.story_point = story_point
        self.tag_ids = tag_ids
        self.task_id = task_id
        self.tasklist_id = tasklist_id
        self.tfs_id = tfs_id
        self.unique_id = unique_id
        self.updated = updated
        self.visible = visible

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
        if self.ancestor_ids is not None:
            result['ancestorIds'] = self.ancestor_ids
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
        if self.is_archived is not None:
            result['isArchived'] = self.is_archived
        if self.is_done is not None:
            result['isDone'] = self.is_done
        if self.note is not None:
            result['note'] = self.note
        if self.parent_task_id is not None:
            result['parentTaskId'] = self.parent_task_id
        if self.priority is not None:
            result['priority'] = self.priority
        if self.progress is not None:
            result['progress'] = self.progress
        if self.project_id is not None:
            result['projectId'] = self.project_id
        if self.recurrence is not None:
            result['recurrence'] = self.recurrence
        if self.sfc_id is not None:
            result['sfcId'] = self.sfc_id
        if self.source_id is not None:
            result['sourceId'] = self.source_id
        if self.sprint_id is not None:
            result['sprintId'] = self.sprint_id
        if self.stage_id is not None:
            result['stageId'] = self.stage_id
        if self.start_date is not None:
            result['startDate'] = self.start_date
        if self.story_point is not None:
            result['storyPoint'] = self.story_point
        if self.tag_ids is not None:
            result['tagIds'] = self.tag_ids
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.tasklist_id is not None:
            result['tasklistId'] = self.tasklist_id
        if self.tfs_id is not None:
            result['tfsId'] = self.tfs_id
        if self.unique_id is not None:
            result['uniqueId'] = self.unique_id
        if self.updated is not None:
            result['updated'] = self.updated
        if self.visible is not None:
            result['visible'] = self.visible
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accomplishTime') is not None:
            self.accomplish_time = m.get('accomplishTime')
        if m.get('ancestorIds') is not None:
            self.ancestor_ids = m.get('ancestorIds')
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
        if m.get('isArchived') is not None:
            self.is_archived = m.get('isArchived')
        if m.get('isDone') is not None:
            self.is_done = m.get('isDone')
        if m.get('note') is not None:
            self.note = m.get('note')
        if m.get('parentTaskId') is not None:
            self.parent_task_id = m.get('parentTaskId')
        if m.get('priority') is not None:
            self.priority = m.get('priority')
        if m.get('progress') is not None:
            self.progress = m.get('progress')
        if m.get('projectId') is not None:
            self.project_id = m.get('projectId')
        if m.get('recurrence') is not None:
            self.recurrence = m.get('recurrence')
        if m.get('sfcId') is not None:
            self.sfc_id = m.get('sfcId')
        if m.get('sourceId') is not None:
            self.source_id = m.get('sourceId')
        if m.get('sprintId') is not None:
            self.sprint_id = m.get('sprintId')
        if m.get('stageId') is not None:
            self.stage_id = m.get('stageId')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        if m.get('storyPoint') is not None:
            self.story_point = m.get('storyPoint')
        if m.get('tagIds') is not None:
            self.tag_ids = m.get('tagIds')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('tasklistId') is not None:
            self.tasklist_id = m.get('tasklistId')
        if m.get('tfsId') is not None:
            self.tfs_id = m.get('tfsId')
        if m.get('uniqueId') is not None:
            self.unique_id = m.get('uniqueId')
        if m.get('updated') is not None:
            self.updated = m.get('updated')
        if m.get('visible') is not None:
            self.visible = m.get('visible')
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


class SearchProjectsV3ResponseBodyResultCustomfieldsValue(TeaModel):
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


class SearchProjectsV3ResponseBodyResultCustomfields(TeaModel):
    def __init__(
        self,
        customfield_id: str = None,
        type: str = None,
        value: List[SearchProjectsV3ResponseBodyResultCustomfieldsValue] = None,
    ):
        self.customfield_id = customfield_id
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
        if self.customfield_id is not None:
            result['customfieldId'] = self.customfield_id
        if self.type is not None:
            result['type'] = self.type
        result['value'] = []
        if self.value is not None:
            for k in self.value:
                result['value'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customfieldId') is not None:
            self.customfield_id = m.get('customfieldId')
        if m.get('type') is not None:
            self.type = m.get('type')
        self.value = []
        if m.get('value') is not None:
            for k in m.get('value'):
                temp_model = SearchProjectsV3ResponseBodyResultCustomfieldsValue()
                self.value.append(temp_model.from_map(k))
        return self


class SearchProjectsV3ResponseBodyResult(TeaModel):
    def __init__(
        self,
        created: str = None,
        creator_id: str = None,
        customfields: List[SearchProjectsV3ResponseBodyResultCustomfields] = None,
        description: str = None,
        end_date: str = None,
        id: str = None,
        is_archived: bool = None,
        is_suspended: bool = None,
        is_template: bool = None,
        logo: str = None,
        name: str = None,
        organization_id: str = None,
        source_id: str = None,
        start_date: str = None,
        unique_id_prefix: str = None,
        updated: str = None,
        visibility: str = None,
    ):
        self.created = created
        self.creator_id = creator_id
        self.customfields = customfields
        self.description = description
        self.end_date = end_date
        self.id = id
        self.is_archived = is_archived
        self.is_suspended = is_suspended
        self.is_template = is_template
        self.logo = logo
        self.name = name
        self.organization_id = organization_id
        self.source_id = source_id
        self.start_date = start_date
        self.unique_id_prefix = unique_id_prefix
        self.updated = updated
        self.visibility = visibility

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
        if self.created is not None:
            result['created'] = self.created
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        result['customfields'] = []
        if self.customfields is not None:
            for k in self.customfields:
                result['customfields'].append(k.to_map() if k else None)
        if self.description is not None:
            result['description'] = self.description
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.id is not None:
            result['id'] = self.id
        if self.is_archived is not None:
            result['isArchived'] = self.is_archived
        if self.is_suspended is not None:
            result['isSuspended'] = self.is_suspended
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
        if self.start_date is not None:
            result['startDate'] = self.start_date
        if self.unique_id_prefix is not None:
            result['uniqueIdPrefix'] = self.unique_id_prefix
        if self.updated is not None:
            result['updated'] = self.updated
        if self.visibility is not None:
            result['visibility'] = self.visibility
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('created') is not None:
            self.created = m.get('created')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        self.customfields = []
        if m.get('customfields') is not None:
            for k in m.get('customfields'):
                temp_model = SearchProjectsV3ResponseBodyResultCustomfields()
                self.customfields.append(temp_model.from_map(k))
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isArchived') is not None:
            self.is_archived = m.get('isArchived')
        if m.get('isSuspended') is not None:
            self.is_suspended = m.get('isSuspended')
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
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        if m.get('uniqueIdPrefix') is not None:
            self.unique_id_prefix = m.get('uniqueIdPrefix')
        if m.get('updated') is not None:
            self.updated = m.get('updated')
        if m.get('visibility') is not None:
            self.visibility = m.get('visibility')
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


