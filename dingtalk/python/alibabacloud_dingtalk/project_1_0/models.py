# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List, Any


class AddProjectMemberHeaders(TeaModel):
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


class AddProjectMemberRequest(TeaModel):
    def __init__(
        self,
        user_ids: List[str] = None,
    ):
        # This parameter is required.
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class AddProjectMemberResponseBodyResult(TeaModel):
    def __init__(
        self,
        joined: str = None,
        nickname: str = None,
    ):
        self.joined = joined
        self.nickname = nickname

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.joined is not None:
            result['joined'] = self.joined
        if self.nickname is not None:
            result['nickname'] = self.nickname
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('joined') is not None:
            self.joined = m.get('joined')
        if m.get('nickname') is not None:
            self.nickname = m.get('nickname')
        return self


class AddProjectMemberResponseBody(TeaModel):
    def __init__(
        self,
        result: List[AddProjectMemberResponseBodyResult] = None,
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
                temp_model = AddProjectMemberResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class AddProjectMemberResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AddProjectMemberResponseBody = None,
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
            temp_model = AddProjectMemberResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ArchiveProjectHeaders(TeaModel):
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


class ArchiveProjectResponseBodyResult(TeaModel):
    def __init__(
        self,
        is_archived: bool = None,
        updated: str = None,
    ):
        self.is_archived = is_archived
        self.updated = updated

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.is_archived is not None:
            result['isArchived'] = self.is_archived
        if self.updated is not None:
            result['updated'] = self.updated
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isArchived') is not None:
            self.is_archived = m.get('isArchived')
        if m.get('updated') is not None:
            self.updated = m.get('updated')
        return self


class ArchiveProjectResponseBody(TeaModel):
    def __init__(
        self,
        result: ArchiveProjectResponseBodyResult = None,
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
            temp_model = ArchiveProjectResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class ArchiveProjectResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ArchiveProjectResponseBody = None,
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
            temp_model = ArchiveProjectResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ArchiveTaskHeaders(TeaModel):
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


class ArchiveTaskResponseBodyResult(TeaModel):
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


class ArchiveTaskResponseBody(TeaModel):
    def __init__(
        self,
        result: ArchiveTaskResponseBodyResult = None,
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
            temp_model = ArchiveTaskResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class ArchiveTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ArchiveTaskResponseBody = None,
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
            temp_model = ArchiveTaskResponseBody()
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
        create_time: str = None,
        disable_activity: bool = None,
        disable_notification: bool = None,
        due_date: str = None,
        executor_id: str = None,
        involve_members: List[str] = None,
        note: str = None,
        priority: int = None,
        visible: str = None,
    ):
        # This parameter is required.
        self.content = content
        self.create_time = create_time
        self.disable_activity = disable_activity
        self.disable_notification = disable_notification
        self.due_date = due_date
        self.executor_id = executor_id
        self.involve_members = involve_members
        self.note = note
        # This parameter is required.
        self.priority = priority
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
        if self.create_time is not None:
            result['createTime'] = self.create_time
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
        if self.priority is not None:
            result['priority'] = self.priority
        if self.visible is not None:
            result['visible'] = self.visible
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
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
        if m.get('priority') is not None:
            self.priority = m.get('priority')
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
        priority: int = None,
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
        self.priority = priority
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
        if self.priority is not None:
            result['priority'] = self.priority
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
        if m.get('priority') is not None:
            self.priority = m.get('priority')
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


class CreatePlanTimeHeaders(TeaModel):
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


class CreatePlanTimeRequest(TeaModel):
    def __init__(
        self,
        end_date: str = None,
        executor_id: str = None,
        includes_holidays: bool = None,
        is_duration: bool = None,
        object_id: str = None,
        object_type: str = None,
        plan_time: int = None,
        start_date: str = None,
        submitter_id: str = None,
        tenant_type: str = None,
    ):
        # This parameter is required.
        self.end_date = end_date
        # This parameter is required.
        self.executor_id = executor_id
        # This parameter is required.
        self.includes_holidays = includes_holidays
        # This parameter is required.
        self.is_duration = is_duration
        # This parameter is required.
        self.object_id = object_id
        # This parameter is required.
        self.object_type = object_type
        # This parameter is required.
        self.plan_time = plan_time
        # This parameter is required.
        self.start_date = start_date
        # This parameter is required.
        self.submitter_id = submitter_id
        # This parameter is required.
        self.tenant_type = tenant_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.executor_id is not None:
            result['executorId'] = self.executor_id
        if self.includes_holidays is not None:
            result['includesHolidays'] = self.includes_holidays
        if self.is_duration is not None:
            result['isDuration'] = self.is_duration
        if self.object_id is not None:
            result['objectId'] = self.object_id
        if self.object_type is not None:
            result['objectType'] = self.object_type
        if self.plan_time is not None:
            result['planTime'] = self.plan_time
        if self.start_date is not None:
            result['startDate'] = self.start_date
        if self.submitter_id is not None:
            result['submitterId'] = self.submitter_id
        if self.tenant_type is not None:
            result['tenantType'] = self.tenant_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('executorId') is not None:
            self.executor_id = m.get('executorId')
        if m.get('includesHolidays') is not None:
            self.includes_holidays = m.get('includesHolidays')
        if m.get('isDuration') is not None:
            self.is_duration = m.get('isDuration')
        if m.get('objectId') is not None:
            self.object_id = m.get('objectId')
        if m.get('objectType') is not None:
            self.object_type = m.get('objectType')
        if m.get('planTime') is not None:
            self.plan_time = m.get('planTime')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        if m.get('submitterId') is not None:
            self.submitter_id = m.get('submitterId')
        if m.get('tenantType') is not None:
            self.tenant_type = m.get('tenantType')
        return self


class CreatePlanTimeResponseBodyResultBody(TeaModel):
    def __init__(
        self,
        date: str = None,
        object_id: str = None,
        plan_time: int = None,
    ):
        self.date = date
        self.object_id = object_id
        self.plan_time = plan_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.object_id is not None:
            result['objectId'] = self.object_id
        if self.plan_time is not None:
            result['planTime'] = self.plan_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('objectId') is not None:
            self.object_id = m.get('objectId')
        if m.get('planTime') is not None:
            self.plan_time = m.get('planTime')
        return self


class CreatePlanTimeResponseBodyResult(TeaModel):
    def __init__(
        self,
        body: List[CreatePlanTimeResponseBodyResultBody] = None,
        message: str = None,
        ok: bool = None,
    ):
        self.body = body
        self.message = message
        self.ok = ok

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
        if self.message is not None:
            result['message'] = self.message
        if self.ok is not None:
            result['ok'] = self.ok
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.body = []
        if m.get('body') is not None:
            for k in m.get('body'):
                temp_model = CreatePlanTimeResponseBodyResultBody()
                self.body.append(temp_model.from_map(k))
        if m.get('message') is not None:
            self.message = m.get('message')
        if m.get('ok') is not None:
            self.ok = m.get('ok')
        return self


class CreatePlanTimeResponseBody(TeaModel):
    def __init__(
        self,
        result: CreatePlanTimeResponseBodyResult = None,
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
            temp_model = CreatePlanTimeResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class CreatePlanTimeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreatePlanTimeResponseBody = None,
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
            temp_model = CreatePlanTimeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateProjectHeaders(TeaModel):
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


class CreateProjectRequest(TeaModel):
    def __init__(
        self,
        name: str = None,
    ):
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class CreateProjectResponseBodyResultCustomFieldsValue(TeaModel):
    def __init__(
        self,
        custom_field_value_id: str = None,
        meta_string: str = None,
        title: str = None,
    ):
        self.custom_field_value_id = custom_field_value_id
        self.meta_string = meta_string
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.custom_field_value_id is not None:
            result['customFieldValueId'] = self.custom_field_value_id
        if self.meta_string is not None:
            result['metaString'] = self.meta_string
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customFieldValueId') is not None:
            self.custom_field_value_id = m.get('customFieldValueId')
        if m.get('metaString') is not None:
            self.meta_string = m.get('metaString')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class CreateProjectResponseBodyResultCustomFields(TeaModel):
    def __init__(
        self,
        custom_field_id: str = None,
        type: str = None,
        value: List[CreateProjectResponseBodyResultCustomFieldsValue] = None,
    ):
        self.custom_field_id = custom_field_id
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
        if self.custom_field_id is not None:
            result['customFieldId'] = self.custom_field_id
        if self.type is not None:
            result['type'] = self.type
        result['value'] = []
        if self.value is not None:
            for k in self.value:
                result['value'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customFieldId') is not None:
            self.custom_field_id = m.get('customFieldId')
        if m.get('type') is not None:
            self.type = m.get('type')
        self.value = []
        if m.get('value') is not None:
            for k in m.get('value'):
                temp_model = CreateProjectResponseBodyResultCustomFieldsValue()
                self.value.append(temp_model.from_map(k))
        return self


class CreateProjectResponseBodyResult(TeaModel):
    def __init__(
        self,
        created: str = None,
        creator_id: str = None,
        custom_fields: List[CreateProjectResponseBodyResultCustomFields] = None,
        default_collection_id: str = None,
        is_archived: bool = None,
        is_suspended: bool = None,
        is_template: bool = None,
        logo: str = None,
        name: str = None,
        normal_type: str = None,
        project_id: str = None,
        root_collection_id: str = None,
        source_id: str = None,
        unique_id_prefix: str = None,
        updated: str = None,
        visibility: str = None,
    ):
        self.created = created
        self.creator_id = creator_id
        self.custom_fields = custom_fields
        self.default_collection_id = default_collection_id
        self.is_archived = is_archived
        self.is_suspended = is_suspended
        self.is_template = is_template
        self.logo = logo
        self.name = name
        self.normal_type = normal_type
        self.project_id = project_id
        self.root_collection_id = root_collection_id
        self.source_id = source_id
        self.unique_id_prefix = unique_id_prefix
        self.updated = updated
        self.visibility = visibility

    def validate(self):
        if self.custom_fields:
            for k in self.custom_fields:
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
        result['customFields'] = []
        if self.custom_fields is not None:
            for k in self.custom_fields:
                result['customFields'].append(k.to_map() if k else None)
        if self.default_collection_id is not None:
            result['defaultCollectionId'] = self.default_collection_id
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
        if self.normal_type is not None:
            result['normalType'] = self.normal_type
        if self.project_id is not None:
            result['projectId'] = self.project_id
        if self.root_collection_id is not None:
            result['rootCollectionId'] = self.root_collection_id
        if self.source_id is not None:
            result['sourceId'] = self.source_id
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
        self.custom_fields = []
        if m.get('customFields') is not None:
            for k in m.get('customFields'):
                temp_model = CreateProjectResponseBodyResultCustomFields()
                self.custom_fields.append(temp_model.from_map(k))
        if m.get('defaultCollectionId') is not None:
            self.default_collection_id = m.get('defaultCollectionId')
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
        if m.get('normalType') is not None:
            self.normal_type = m.get('normalType')
        if m.get('projectId') is not None:
            self.project_id = m.get('projectId')
        if m.get('rootCollectionId') is not None:
            self.root_collection_id = m.get('rootCollectionId')
        if m.get('sourceId') is not None:
            self.source_id = m.get('sourceId')
        if m.get('uniqueIdPrefix') is not None:
            self.unique_id_prefix = m.get('uniqueIdPrefix')
        if m.get('updated') is not None:
            self.updated = m.get('updated')
        if m.get('visibility') is not None:
            self.visibility = m.get('visibility')
        return self


class CreateProjectResponseBody(TeaModel):
    def __init__(
        self,
        result: CreateProjectResponseBodyResult = None,
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
            temp_model = CreateProjectResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class CreateProjectResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateProjectResponseBody = None,
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
            temp_model = CreateProjectResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateProjectByTemplateHeaders(TeaModel):
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


class CreateProjectByTemplateRequest(TeaModel):
    def __init__(
        self,
        name: str = None,
        template_id: str = None,
    ):
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.template_id = template_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.template_id is not None:
            result['templateId'] = self.template_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('templateId') is not None:
            self.template_id = m.get('templateId')
        return self


class CreateProjectByTemplateResponseBodyResult(TeaModel):
    def __init__(
        self,
        created: str = None,
        id: str = None,
        logo: str = None,
        name: str = None,
    ):
        self.created = created
        self.id = id
        self.logo = logo
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.created is not None:
            result['created'] = self.created
        if self.id is not None:
            result['id'] = self.id
        if self.logo is not None:
            result['logo'] = self.logo
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('created') is not None:
            self.created = m.get('created')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('logo') is not None:
            self.logo = m.get('logo')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class CreateProjectByTemplateResponseBody(TeaModel):
    def __init__(
        self,
        result: CreateProjectByTemplateResponseBodyResult = None,
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
            temp_model = CreateProjectByTemplateResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class CreateProjectByTemplateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateProjectByTemplateResponseBody = None,
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
            temp_model = CreateProjectByTemplateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateProjectCustomfieldStatusHeaders(TeaModel):
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


class CreateProjectCustomfieldStatusRequestValue(TeaModel):
    def __init__(
        self,
        custom_field_value_id: str = None,
        meta_string: str = None,
        title: str = None,
    ):
        self.custom_field_value_id = custom_field_value_id
        self.meta_string = meta_string
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.custom_field_value_id is not None:
            result['customFieldValueId'] = self.custom_field_value_id
        if self.meta_string is not None:
            result['metaString'] = self.meta_string
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customFieldValueId') is not None:
            self.custom_field_value_id = m.get('customFieldValueId')
        if m.get('metaString') is not None:
            self.meta_string = m.get('metaString')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class CreateProjectCustomfieldStatusRequest(TeaModel):
    def __init__(
        self,
        custom_field_id: str = None,
        custom_field_instance_id: str = None,
        custom_field_name: str = None,
        value: List[CreateProjectCustomfieldStatusRequestValue] = None,
    ):
        self.custom_field_id = custom_field_id
        self.custom_field_instance_id = custom_field_instance_id
        self.custom_field_name = custom_field_name
        # This parameter is required.
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
        if self.custom_field_id is not None:
            result['customFieldId'] = self.custom_field_id
        if self.custom_field_instance_id is not None:
            result['customFieldInstanceId'] = self.custom_field_instance_id
        if self.custom_field_name is not None:
            result['customFieldName'] = self.custom_field_name
        result['value'] = []
        if self.value is not None:
            for k in self.value:
                result['value'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customFieldId') is not None:
            self.custom_field_id = m.get('customFieldId')
        if m.get('customFieldInstanceId') is not None:
            self.custom_field_instance_id = m.get('customFieldInstanceId')
        if m.get('customFieldName') is not None:
            self.custom_field_name = m.get('customFieldName')
        self.value = []
        if m.get('value') is not None:
            for k in m.get('value'):
                temp_model = CreateProjectCustomfieldStatusRequestValue()
                self.value.append(temp_model.from_map(k))
        return self


class CreateProjectCustomfieldStatusResponseBodyResultValue(TeaModel):
    def __init__(
        self,
        custom_field_value_id: str = None,
        meta_string: str = None,
        title: str = None,
    ):
        self.custom_field_value_id = custom_field_value_id
        self.meta_string = meta_string
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.custom_field_value_id is not None:
            result['customFieldValueId'] = self.custom_field_value_id
        if self.meta_string is not None:
            result['metaString'] = self.meta_string
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customFieldValueId') is not None:
            self.custom_field_value_id = m.get('customFieldValueId')
        if m.get('metaString') is not None:
            self.meta_string = m.get('metaString')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class CreateProjectCustomfieldStatusResponseBodyResult(TeaModel):
    def __init__(
        self,
        advanced_custom_field_object_type: str = None,
        custom_field_id: str = None,
        name: str = None,
        original_id: str = None,
        type: str = None,
        value: List[CreateProjectCustomfieldStatusResponseBodyResultValue] = None,
    ):
        self.advanced_custom_field_object_type = advanced_custom_field_object_type
        self.custom_field_id = custom_field_id
        self.name = name
        self.original_id = original_id
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
        if self.advanced_custom_field_object_type is not None:
            result['advancedCustomFieldObjectType'] = self.advanced_custom_field_object_type
        if self.custom_field_id is not None:
            result['customFieldId'] = self.custom_field_id
        if self.name is not None:
            result['name'] = self.name
        if self.original_id is not None:
            result['originalId'] = self.original_id
        if self.type is not None:
            result['type'] = self.type
        result['value'] = []
        if self.value is not None:
            for k in self.value:
                result['value'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('advancedCustomFieldObjectType') is not None:
            self.advanced_custom_field_object_type = m.get('advancedCustomFieldObjectType')
        if m.get('customFieldId') is not None:
            self.custom_field_id = m.get('customFieldId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('originalId') is not None:
            self.original_id = m.get('originalId')
        if m.get('type') is not None:
            self.type = m.get('type')
        self.value = []
        if m.get('value') is not None:
            for k in m.get('value'):
                temp_model = CreateProjectCustomfieldStatusResponseBodyResultValue()
                self.value.append(temp_model.from_map(k))
        return self


class CreateProjectCustomfieldStatusResponseBody(TeaModel):
    def __init__(
        self,
        result: CreateProjectCustomfieldStatusResponseBodyResult = None,
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
            temp_model = CreateProjectCustomfieldStatusResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class CreateProjectCustomfieldStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateProjectCustomfieldStatusResponseBody = None,
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
            temp_model = CreateProjectCustomfieldStatusResponseBody()
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
        parent_task_id: str = None,
        priority: int = None,
        project_id: str = None,
        scenariofieldconfig_id: str = None,
        stage_id: str = None,
        start_date: str = None,
        visible: str = None,
    ):
        # This parameter is required.
        self.content = content
        self.customfields = customfields
        self.due_date = due_date
        self.executor_id = executor_id
        self.note = note
        self.parent_task_id = parent_task_id
        self.priority = priority
        # This parameter is required.
        self.project_id = project_id
        self.scenariofieldconfig_id = scenariofieldconfig_id
        self.stage_id = stage_id
        self.start_date = start_date
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
        if self.parent_task_id is not None:
            result['parentTaskId'] = self.parent_task_id
        if self.priority is not None:
            result['priority'] = self.priority
        if self.project_id is not None:
            result['projectId'] = self.project_id
        if self.scenariofieldconfig_id is not None:
            result['scenariofieldconfigId'] = self.scenariofieldconfig_id
        if self.stage_id is not None:
            result['stageId'] = self.stage_id
        if self.start_date is not None:
            result['startDate'] = self.start_date
        if self.visible is not None:
            result['visible'] = self.visible
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
        if m.get('parentTaskId') is not None:
            self.parent_task_id = m.get('parentTaskId')
        if m.get('priority') is not None:
            self.priority = m.get('priority')
        if m.get('projectId') is not None:
            self.project_id = m.get('projectId')
        if m.get('scenariofieldconfigId') is not None:
            self.scenariofieldconfig_id = m.get('scenariofieldconfigId')
        if m.get('stageId') is not None:
            self.stage_id = m.get('stageId')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        if m.get('visible') is not None:
            self.visible = m.get('visible')
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


class CreateTaskObjectLinkHeaders(TeaModel):
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


class CreateTaskObjectLinkRequestLinkedData(TeaModel):
    def __init__(
        self,
        content: str = None,
        thumbnail_url: str = None,
        title: str = None,
        url: str = None,
    ):
        self.content = content
        self.thumbnail_url = thumbnail_url
        # This parameter is required.
        self.title = title
        # This parameter is required.
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.thumbnail_url is not None:
            result['thumbnailUrl'] = self.thumbnail_url
        if self.title is not None:
            result['title'] = self.title
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('thumbnailUrl') is not None:
            self.thumbnail_url = m.get('thumbnailUrl')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class CreateTaskObjectLinkRequest(TeaModel):
    def __init__(
        self,
        linked_data: CreateTaskObjectLinkRequestLinkedData = None,
    ):
        self.linked_data = linked_data

    def validate(self):
        if self.linked_data:
            self.linked_data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.linked_data is not None:
            result['linkedData'] = self.linked_data.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('linkedData') is not None:
            temp_model = CreateTaskObjectLinkRequestLinkedData()
            self.linked_data = temp_model.from_map(m['linkedData'])
        return self


class CreateTaskObjectLinkResponseBodyResult(TeaModel):
    def __init__(
        self,
        created: str = None,
        object_link_id: str = None,
    ):
        self.created = created
        self.object_link_id = object_link_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.created is not None:
            result['created'] = self.created
        if self.object_link_id is not None:
            result['objectLinkId'] = self.object_link_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('created') is not None:
            self.created = m.get('created')
        if m.get('objectLinkId') is not None:
            self.object_link_id = m.get('objectLinkId')
        return self


class CreateTaskObjectLinkResponseBody(TeaModel):
    def __init__(
        self,
        result: CreateTaskObjectLinkResponseBodyResult = None,
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
            temp_model = CreateTaskObjectLinkResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class CreateTaskObjectLinkResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateTaskObjectLinkResponseBody = None,
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
            temp_model = CreateTaskObjectLinkResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateWorkTimeHeaders(TeaModel):
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


class CreateWorkTimeRequest(TeaModel):
    def __init__(
        self,
        description: str = None,
        end_date: str = None,
        executor_id: str = None,
        includes_holidays: bool = None,
        is_duration: bool = None,
        object_id: str = None,
        object_type: str = None,
        start_date: str = None,
        submitter_id: str = None,
        work_time: int = None,
        tenant_type: str = None,
    ):
        self.description = description
        # This parameter is required.
        self.end_date = end_date
        # This parameter is required.
        self.executor_id = executor_id
        # This parameter is required.
        self.includes_holidays = includes_holidays
        # This parameter is required.
        self.is_duration = is_duration
        # This parameter is required.
        self.object_id = object_id
        # This parameter is required.
        self.object_type = object_type
        # This parameter is required.
        self.start_date = start_date
        # This parameter is required.
        self.submitter_id = submitter_id
        # This parameter is required.
        self.work_time = work_time
        # This parameter is required.
        self.tenant_type = tenant_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.description is not None:
            result['description'] = self.description
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.executor_id is not None:
            result['executorId'] = self.executor_id
        if self.includes_holidays is not None:
            result['includesHolidays'] = self.includes_holidays
        if self.is_duration is not None:
            result['isDuration'] = self.is_duration
        if self.object_id is not None:
            result['objectId'] = self.object_id
        if self.object_type is not None:
            result['objectType'] = self.object_type
        if self.start_date is not None:
            result['startDate'] = self.start_date
        if self.submitter_id is not None:
            result['submitterId'] = self.submitter_id
        if self.work_time is not None:
            result['workTime'] = self.work_time
        if self.tenant_type is not None:
            result['tenantType'] = self.tenant_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('executorId') is not None:
            self.executor_id = m.get('executorId')
        if m.get('includesHolidays') is not None:
            self.includes_holidays = m.get('includesHolidays')
        if m.get('isDuration') is not None:
            self.is_duration = m.get('isDuration')
        if m.get('objectId') is not None:
            self.object_id = m.get('objectId')
        if m.get('objectType') is not None:
            self.object_type = m.get('objectType')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        if m.get('submitterId') is not None:
            self.submitter_id = m.get('submitterId')
        if m.get('workTime') is not None:
            self.work_time = m.get('workTime')
        if m.get('tenantType') is not None:
            self.tenant_type = m.get('tenantType')
        return self


class CreateWorkTimeResponseBodyResultBody(TeaModel):
    def __init__(
        self,
        date: str = None,
        task_id: str = None,
        work_time: int = None,
    ):
        self.date = date
        self.task_id = task_id
        self.work_time = work_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.work_time is not None:
            result['workTime'] = self.work_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('workTime') is not None:
            self.work_time = m.get('workTime')
        return self


class CreateWorkTimeResponseBodyResult(TeaModel):
    def __init__(
        self,
        body: List[CreateWorkTimeResponseBodyResultBody] = None,
        message: str = None,
        ok: bool = None,
    ):
        self.body = body
        self.message = message
        self.ok = ok

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
        if self.message is not None:
            result['message'] = self.message
        if self.ok is not None:
            result['ok'] = self.ok
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.body = []
        if m.get('body') is not None:
            for k in m.get('body'):
                temp_model = CreateWorkTimeResponseBodyResultBody()
                self.body.append(temp_model.from_map(k))
        if m.get('message') is not None:
            self.message = m.get('message')
        if m.get('ok') is not None:
            self.ok = m.get('ok')
        return self


class CreateWorkTimeResponseBody(TeaModel):
    def __init__(
        self,
        result: CreateWorkTimeResponseBodyResult = None,
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
            temp_model = CreateWorkTimeResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class CreateWorkTimeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateWorkTimeResponseBody = None,
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
            temp_model = CreateWorkTimeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateWorkTimeApproveHeaders(TeaModel):
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


class CreateWorkTimeApproveRequest(TeaModel):
    def __init__(
        self,
        work_time_ids: List[str] = None,
    ):
        # This parameter is required.
        self.work_time_ids = work_time_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.work_time_ids is not None:
            result['workTimeIds'] = self.work_time_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('workTimeIds') is not None:
            self.work_time_ids = m.get('workTimeIds')
        return self


class CreateWorkTimeApproveResponseBodyResult(TeaModel):
    def __init__(
        self,
        approve_open_id: str = None,
        created_at: str = None,
        creator_id: str = None,
        organization_id: str = None,
        status: str = None,
        task_id: str = None,
        time: int = None,
        updated_at: str = None,
        user_id: str = None,
        work_time_ids: List[str] = None,
    ):
        self.approve_open_id = approve_open_id
        self.created_at = created_at
        self.creator_id = creator_id
        self.organization_id = organization_id
        self.status = status
        self.task_id = task_id
        self.time = time
        self.updated_at = updated_at
        self.user_id = user_id
        self.work_time_ids = work_time_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.approve_open_id is not None:
            result['approveOpenId'] = self.approve_open_id
        if self.created_at is not None:
            result['createdAt'] = self.created_at
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.organization_id is not None:
            result['organizationId'] = self.organization_id
        if self.status is not None:
            result['status'] = self.status
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.time is not None:
            result['time'] = self.time
        if self.updated_at is not None:
            result['updatedAt'] = self.updated_at
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.work_time_ids is not None:
            result['workTimeIds'] = self.work_time_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('approveOpenId') is not None:
            self.approve_open_id = m.get('approveOpenId')
        if m.get('createdAt') is not None:
            self.created_at = m.get('createdAt')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('organizationId') is not None:
            self.organization_id = m.get('organizationId')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('time') is not None:
            self.time = m.get('time')
        if m.get('updatedAt') is not None:
            self.updated_at = m.get('updatedAt')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('workTimeIds') is not None:
            self.work_time_ids = m.get('workTimeIds')
        return self


class CreateWorkTimeApproveResponseBody(TeaModel):
    def __init__(
        self,
        message: str = None,
        request_id: str = None,
        result: CreateWorkTimeApproveResponseBodyResult = None,
    ):
        self.message = message
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
        if self.message is not None:
            result['message'] = self.message
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('message') is not None:
            self.message = m.get('message')
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            temp_model = CreateWorkTimeApproveResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class CreateWorkTimeApproveResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateWorkTimeApproveResponseBody = None,
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
            temp_model = CreateWorkTimeApproveResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteProjectMemberHeaders(TeaModel):
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


class DeleteProjectMemberRequest(TeaModel):
    def __init__(
        self,
        user_ids: List[str] = None,
    ):
        # This parameter is required.
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class DeleteProjectMemberResponseBody(TeaModel):
    def __init__(
        self,
        result: List[str] = None,
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


class DeleteProjectMemberResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteProjectMemberResponseBody = None,
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
            temp_model = DeleteProjectMemberResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteTaskHeaders(TeaModel):
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


class DeleteTaskResponseBody(TeaModel):
    def __init__(
        self,
        result: Dict[str, str] = None,
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


class DeleteTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteTaskResponseBody = None,
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
            temp_model = DeleteTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetDeptsByOrgIdHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        ding_access_token_type: str = None,
        ding_org_id: str = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.ding_access_token_type = ding_access_token_type
        self.ding_org_id = ding_org_id
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
        if self.ding_access_token_type is not None:
            result['dingAccessTokenType'] = self.ding_access_token_type
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('dingAccessTokenType') is not None:
            self.ding_access_token_type = m.get('dingAccessTokenType')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetDeptsByOrgIdRequest(TeaModel):
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


class GetDeptsByOrgIdResponseBodyDeptList(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        name: str = None,
        parent_id: int = None,
    ):
        self.dept_id = dept_id
        self.name = name
        self.parent_id = parent_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['dept_id'] = self.dept_id
        if self.name is not None:
            result['name'] = self.name
        if self.parent_id is not None:
            result['parent_id'] = self.parent_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dept_id') is not None:
            self.dept_id = m.get('dept_id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('parent_id') is not None:
            self.parent_id = m.get('parent_id')
        return self


class GetDeptsByOrgIdResponseBody(TeaModel):
    def __init__(
        self,
        dept_list: List[GetDeptsByOrgIdResponseBodyDeptList] = None,
        has_more: bool = None,
        max_results: int = None,
        next_token: int = None,
    ):
        self.dept_list = dept_list
        self.has_more = has_more
        self.max_results = max_results
        self.next_token = next_token

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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.dept_list = []
        if m.get('deptList') is not None:
            for k in m.get('deptList'):
                temp_model = GetDeptsByOrgIdResponseBodyDeptList()
                self.dept_list.append(temp_model.from_map(k))
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class GetDeptsByOrgIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetDeptsByOrgIdResponseBody = None,
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
            temp_model = GetDeptsByOrgIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetEmpsByOrgIdHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        ding_access_token_type: str = None,
        ding_isv_org_id: str = None,
        ding_org_id: str = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.ding_access_token_type = ding_access_token_type
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_org_id = ding_org_id
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
        if self.ding_access_token_type is not None:
            result['dingAccessTokenType'] = self.ding_access_token_type
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('dingAccessTokenType') is not None:
            self.ding_access_token_type = m.get('dingAccessTokenType')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetEmpsByOrgIdRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        need_dept: bool = None,
        next_token: int = None,
    ):
        self.max_results = max_results
        self.need_dept = need_dept
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
        if self.need_dept is not None:
            result['needDept'] = self.need_dept
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('needDept') is not None:
            self.need_dept = m.get('needDept')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class GetEmpsByOrgIdResponseBodyEmpList(TeaModel):
    def __init__(
        self,
        avatar: str = None,
        dept_id_list: List[int] = None,
        ding_id: str = None,
        name: str = None,
        nick: str = None,
        org_id: int = None,
        position: str = None,
        unionid: str = None,
        userid: str = None,
    ):
        self.avatar = avatar
        self.dept_id_list = dept_id_list
        self.ding_id = ding_id
        self.name = name
        self.nick = nick
        self.org_id = org_id
        self.position = position
        self.unionid = unionid
        self.userid = userid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.avatar is not None:
            result['avatar'] = self.avatar
        if self.dept_id_list is not None:
            result['dept_id_list'] = self.dept_id_list
        if self.ding_id is not None:
            result['dingId'] = self.ding_id
        if self.name is not None:
            result['name'] = self.name
        if self.nick is not None:
            result['nick'] = self.nick
        if self.org_id is not None:
            result['orgId'] = self.org_id
        if self.position is not None:
            result['position'] = self.position
        if self.unionid is not None:
            result['unionid'] = self.unionid
        if self.userid is not None:
            result['userid'] = self.userid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('avatar') is not None:
            self.avatar = m.get('avatar')
        if m.get('dept_id_list') is not None:
            self.dept_id_list = m.get('dept_id_list')
        if m.get('dingId') is not None:
            self.ding_id = m.get('dingId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('nick') is not None:
            self.nick = m.get('nick')
        if m.get('orgId') is not None:
            self.org_id = m.get('orgId')
        if m.get('position') is not None:
            self.position = m.get('position')
        if m.get('unionid') is not None:
            self.unionid = m.get('unionid')
        if m.get('userid') is not None:
            self.userid = m.get('userid')
        return self


class GetEmpsByOrgIdResponseBody(TeaModel):
    def __init__(
        self,
        emp_list: List[GetEmpsByOrgIdResponseBodyEmpList] = None,
        has_more: bool = None,
        next_token: int = None,
    ):
        self.emp_list = emp_list
        self.has_more = has_more
        self.next_token = next_token

    def validate(self):
        if self.emp_list:
            for k in self.emp_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['empList'] = []
        if self.emp_list is not None:
            for k in self.emp_list:
                result['empList'].append(k.to_map() if k else None)
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.emp_list = []
        if m.get('empList') is not None:
            for k in m.get('empList'):
                temp_model = GetEmpsByOrgIdResponseBodyEmpList()
                self.emp_list.append(temp_model.from_map(k))
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class GetEmpsByOrgIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetEmpsByOrgIdResponseBody = None,
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
            temp_model = GetEmpsByOrgIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetOrganizatioTaskByIdsHeaders(TeaModel):
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


class GetOrganizatioTaskByIdsRequest(TeaModel):
    def __init__(
        self,
        task_ids: str = None,
    ):
        # This parameter is required.
        self.task_ids = task_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.task_ids is not None:
            result['taskIds'] = self.task_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('taskIds') is not None:
            self.task_ids = m.get('taskIds')
        return self


class GetOrganizatioTaskByIdsResponseBodyResult(TeaModel):
    def __init__(
        self,
        ancestor_ids: List[str] = None,
        content: str = None,
        created: str = None,
        creator_id: str = None,
        due_date: str = None,
        executor_id: str = None,
        involve_members: List[str] = None,
        is_deleted: bool = None,
        is_done: bool = None,
        labels: List[str] = None,
        note: str = None,
        priority: int = None,
        start_date: str = None,
        task_id: str = None,
        updated: str = None,
        visible: str = None,
    ):
        self.ancestor_ids = ancestor_ids
        self.content = content
        self.created = created
        self.creator_id = creator_id
        self.due_date = due_date
        self.executor_id = executor_id
        self.involve_members = involve_members
        self.is_deleted = is_deleted
        self.is_done = is_done
        self.labels = labels
        self.note = note
        self.priority = priority
        self.start_date = start_date
        self.task_id = task_id
        self.updated = updated
        self.visible = visible

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
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
        if self.involve_members is not None:
            result['involveMembers'] = self.involve_members
        if self.is_deleted is not None:
            result['isDeleted'] = self.is_deleted
        if self.is_done is not None:
            result['isDone'] = self.is_done
        if self.labels is not None:
            result['labels'] = self.labels
        if self.note is not None:
            result['note'] = self.note
        if self.priority is not None:
            result['priority'] = self.priority
        if self.start_date is not None:
            result['startDate'] = self.start_date
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.updated is not None:
            result['updated'] = self.updated
        if self.visible is not None:
            result['visible'] = self.visible
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
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
        if m.get('involveMembers') is not None:
            self.involve_members = m.get('involveMembers')
        if m.get('isDeleted') is not None:
            self.is_deleted = m.get('isDeleted')
        if m.get('isDone') is not None:
            self.is_done = m.get('isDone')
        if m.get('labels') is not None:
            self.labels = m.get('labels')
        if m.get('note') is not None:
            self.note = m.get('note')
        if m.get('priority') is not None:
            self.priority = m.get('priority')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('updated') is not None:
            self.updated = m.get('updated')
        if m.get('visible') is not None:
            self.visible = m.get('visible')
        return self


class GetOrganizatioTaskByIdsResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetOrganizatioTaskByIdsResponseBodyResult] = None,
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
                temp_model = GetOrganizatioTaskByIdsResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GetOrganizatioTaskByIdsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetOrganizatioTaskByIdsResponseBody = None,
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
            temp_model = GetOrganizatioTaskByIdsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetOrganizationPriorityListHeaders(TeaModel):
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


class GetOrganizationPriorityListResponseBodyResult(TeaModel):
    def __init__(
        self,
        color: str = None,
        name: str = None,
        priority: str = None,
        priority_id: str = None,
    ):
        self.color = color
        self.name = name
        self.priority = priority
        self.priority_id = priority_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.color is not None:
            result['color'] = self.color
        if self.name is not None:
            result['name'] = self.name
        if self.priority is not None:
            result['priority'] = self.priority
        if self.priority_id is not None:
            result['priorityId'] = self.priority_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('color') is not None:
            self.color = m.get('color')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('priority') is not None:
            self.priority = m.get('priority')
        if m.get('priorityId') is not None:
            self.priority_id = m.get('priorityId')
        return self


class GetOrganizationPriorityListResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetOrganizationPriorityListResponseBodyResult] = None,
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
                temp_model = GetOrganizationPriorityListResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GetOrganizationPriorityListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetOrganizationPriorityListResponseBody = None,
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
            temp_model = GetOrganizationPriorityListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetOrganizationTaskHeaders(TeaModel):
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


class GetOrganizationTaskResponseBodyResult(TeaModel):
    def __init__(
        self,
        ancestor_ids: List[str] = None,
        content: str = None,
        created: str = None,
        creator_id: str = None,
        due_date: str = None,
        executor_id: str = None,
        involve_members: List[str] = None,
        is_deleted: bool = None,
        is_done: bool = None,
        labels: List[str] = None,
        note: str = None,
        priority: int = None,
        start_date: str = None,
        task_id: str = None,
        updated: str = None,
        visible: str = None,
    ):
        self.ancestor_ids = ancestor_ids
        self.content = content
        self.created = created
        self.creator_id = creator_id
        self.due_date = due_date
        self.executor_id = executor_id
        self.involve_members = involve_members
        self.is_deleted = is_deleted
        self.is_done = is_done
        self.labels = labels
        self.note = note
        self.priority = priority
        self.start_date = start_date
        self.task_id = task_id
        self.updated = updated
        self.visible = visible

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
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
        if self.involve_members is not None:
            result['involveMembers'] = self.involve_members
        if self.is_deleted is not None:
            result['isDeleted'] = self.is_deleted
        if self.is_done is not None:
            result['isDone'] = self.is_done
        if self.labels is not None:
            result['labels'] = self.labels
        if self.note is not None:
            result['note'] = self.note
        if self.priority is not None:
            result['priority'] = self.priority
        if self.start_date is not None:
            result['startDate'] = self.start_date
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.updated is not None:
            result['updated'] = self.updated
        if self.visible is not None:
            result['visible'] = self.visible
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
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
        if m.get('involveMembers') is not None:
            self.involve_members = m.get('involveMembers')
        if m.get('isDeleted') is not None:
            self.is_deleted = m.get('isDeleted')
        if m.get('isDone') is not None:
            self.is_done = m.get('isDone')
        if m.get('labels') is not None:
            self.labels = m.get('labels')
        if m.get('note') is not None:
            self.note = m.get('note')
        if m.get('priority') is not None:
            self.priority = m.get('priority')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('updated') is not None:
            self.updated = m.get('updated')
        if m.get('visible') is not None:
            self.visible = m.get('visible')
        return self


class GetOrganizationTaskResponseBody(TeaModel):
    def __init__(
        self,
        result: GetOrganizationTaskResponseBodyResult = None,
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
            temp_model = GetOrganizationTaskResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetOrganizationTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetOrganizationTaskResponseBody = None,
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
            temp_model = GetOrganizationTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetProjectGroupHeaders(TeaModel):
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


class GetProjectGroupRequest(TeaModel):
    def __init__(
        self,
        page_size: int = None,
        viewer_id: str = None,
    ):
        self.page_size = page_size
        self.viewer_id = viewer_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.viewer_id is not None:
            result['viewerId'] = self.viewer_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('viewerId') is not None:
            self.viewer_id = m.get('viewerId')
        return self


class GetProjectGroupResponseBodyResult(TeaModel):
    def __init__(
        self,
        created: str = None,
        id: str = None,
        name: str = None,
        updated: str = None,
        visible: str = None,
    ):
        self.created = created
        self.id = id
        self.name = name
        self.updated = updated
        self.visible = visible

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.created is not None:
            result['created'] = self.created
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.updated is not None:
            result['updated'] = self.updated
        if self.visible is not None:
            result['visible'] = self.visible
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('created') is not None:
            self.created = m.get('created')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('updated') is not None:
            self.updated = m.get('updated')
        if m.get('visible') is not None:
            self.visible = m.get('visible')
        return self


class GetProjectGroupResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetProjectGroupResponseBodyResult] = None,
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
                temp_model = GetProjectGroupResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GetProjectGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetProjectGroupResponseBody = None,
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
            temp_model = GetProjectGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetProjectMemebersHeaders(TeaModel):
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


class GetProjectMemebersRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        project_role_id: str = None,
        skip: int = None,
        user_ids: str = None,
    ):
        self.max_results = max_results
        self.project_role_id = project_role_id
        self.skip = skip
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.project_role_id is not None:
            result['projectRoleId'] = self.project_role_id
        if self.skip is not None:
            result['skip'] = self.skip
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('projectRoleId') is not None:
            self.project_role_id = m.get('projectRoleId')
        if m.get('skip') is not None:
            self.skip = m.get('skip')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class GetProjectMemebersResponseBodyResult(TeaModel):
    def __init__(
        self,
        member_id: str = None,
        role: int = None,
        role_ids: List[str] = None,
        user_id: str = None,
    ):
        self.member_id = member_id
        self.role = role
        self.role_ids = role_ids
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.member_id is not None:
            result['memberId'] = self.member_id
        if self.role is not None:
            result['role'] = self.role
        if self.role_ids is not None:
            result['roleIds'] = self.role_ids
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('memberId') is not None:
            self.member_id = m.get('memberId')
        if m.get('role') is not None:
            self.role = m.get('role')
        if m.get('roleIds') is not None:
            self.role_ids = m.get('roleIds')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetProjectMemebersResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetProjectMemebersResponseBodyResult] = None,
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
                temp_model = GetProjectMemebersResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GetProjectMemebersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetProjectMemebersResponseBody = None,
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
            temp_model = GetProjectMemebersResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetProjectStatusListHeaders(TeaModel):
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


class GetProjectStatusListResponseBodyResult(TeaModel):
    def __init__(
        self,
        content: str = None,
        created: str = None,
        creator_id: str = None,
        degree: str = None,
        name: str = None,
        project_id: str = None,
    ):
        self.content = content
        self.created = created
        self.creator_id = creator_id
        self.degree = degree
        self.name = name
        self.project_id = project_id

    def validate(self):
        pass

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
        if self.degree is not None:
            result['degree'] = self.degree
        if self.name is not None:
            result['name'] = self.name
        if self.project_id is not None:
            result['projectId'] = self.project_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('created') is not None:
            self.created = m.get('created')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('degree') is not None:
            self.degree = m.get('degree')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('projectId') is not None:
            self.project_id = m.get('projectId')
        return self


class GetProjectStatusListResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetProjectStatusListResponseBodyResult] = None,
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
                temp_model = GetProjectStatusListResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GetProjectStatusListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetProjectStatusListResponseBody = None,
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
            temp_model = GetProjectStatusListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetTaskByIdsHeaders(TeaModel):
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


class GetTaskByIdsRequest(TeaModel):
    def __init__(
        self,
        parent_task_id: str = None,
        task_id: str = None,
    ):
        self.parent_task_id = parent_task_id
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
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('parentTaskId') is not None:
            self.parent_task_id = m.get('parentTaskId')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class GetTaskByIdsResponseBodyResultCustomFieldsValue(TeaModel):
    def __init__(
        self,
        custom_field_value_id: str = None,
        meta_string: str = None,
        title: str = None,
    ):
        self.custom_field_value_id = custom_field_value_id
        self.meta_string = meta_string
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.custom_field_value_id is not None:
            result['customFieldValueId'] = self.custom_field_value_id
        if self.meta_string is not None:
            result['metaString'] = self.meta_string
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customFieldValueId') is not None:
            self.custom_field_value_id = m.get('customFieldValueId')
        if m.get('metaString') is not None:
            self.meta_string = m.get('metaString')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class GetTaskByIdsResponseBodyResultCustomFields(TeaModel):
    def __init__(
        self,
        custom_field_id: str = None,
        type: str = None,
        value: List[GetTaskByIdsResponseBodyResultCustomFieldsValue] = None,
    ):
        self.custom_field_id = custom_field_id
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
        if self.custom_field_id is not None:
            result['customFieldId'] = self.custom_field_id
        if self.type is not None:
            result['type'] = self.type
        result['value'] = []
        if self.value is not None:
            for k in self.value:
                result['value'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customFieldId') is not None:
            self.custom_field_id = m.get('customFieldId')
        if m.get('type') is not None:
            self.type = m.get('type')
        self.value = []
        if m.get('value') is not None:
            for k in m.get('value'):
                temp_model = GetTaskByIdsResponseBodyResultCustomFieldsValue()
                self.value.append(temp_model.from_map(k))
        return self


class GetTaskByIdsResponseBodyResult(TeaModel):
    def __init__(
        self,
        accomplish_time: str = None,
        ancestor_ids: List[str] = None,
        content: str = None,
        created: str = None,
        creator_id: str = None,
        custom_fields: List[GetTaskByIdsResponseBodyResultCustomFields] = None,
        due_date: str = None,
        executor_id: str = None,
        involve_members: List[str] = None,
        is_archived: bool = None,
        is_done: bool = None,
        note: str = None,
        parent_task_id: str = None,
        priority: int = None,
        project_id: str = None,
        recurrence: List[str] = None,
        scenario_field_config_id: str = None,
        sprint_id: str = None,
        start_date: str = None,
        story_point: str = None,
        tag_ids: List[str] = None,
        task_id: str = None,
        task_list_id: str = None,
        task_stage_id: str = None,
        taskflow_status_id: str = None,
        unique_id: str = None,
        updated: str = None,
        visible: str = None,
    ):
        self.accomplish_time = accomplish_time
        self.ancestor_ids = ancestor_ids
        self.content = content
        self.created = created
        self.creator_id = creator_id
        self.custom_fields = custom_fields
        self.due_date = due_date
        self.executor_id = executor_id
        self.involve_members = involve_members
        self.is_archived = is_archived
        self.is_done = is_done
        self.note = note
        self.parent_task_id = parent_task_id
        self.priority = priority
        self.project_id = project_id
        self.recurrence = recurrence
        self.scenario_field_config_id = scenario_field_config_id
        self.sprint_id = sprint_id
        self.start_date = start_date
        self.story_point = story_point
        self.tag_ids = tag_ids
        self.task_id = task_id
        self.task_list_id = task_list_id
        self.task_stage_id = task_stage_id
        self.taskflow_status_id = taskflow_status_id
        self.unique_id = unique_id
        self.updated = updated
        self.visible = visible

    def validate(self):
        if self.custom_fields:
            for k in self.custom_fields:
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
        result['customFields'] = []
        if self.custom_fields is not None:
            for k in self.custom_fields:
                result['customFields'].append(k.to_map() if k else None)
        if self.due_date is not None:
            result['dueDate'] = self.due_date
        if self.executor_id is not None:
            result['executorId'] = self.executor_id
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
        if self.project_id is not None:
            result['projectId'] = self.project_id
        if self.recurrence is not None:
            result['recurrence'] = self.recurrence
        if self.scenario_field_config_id is not None:
            result['scenarioFieldConfigId'] = self.scenario_field_config_id
        if self.sprint_id is not None:
            result['sprintId'] = self.sprint_id
        if self.start_date is not None:
            result['startDate'] = self.start_date
        if self.story_point is not None:
            result['storyPoint'] = self.story_point
        if self.tag_ids is not None:
            result['tagIds'] = self.tag_ids
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.task_list_id is not None:
            result['taskListId'] = self.task_list_id
        if self.task_stage_id is not None:
            result['taskStageId'] = self.task_stage_id
        if self.taskflow_status_id is not None:
            result['taskflowStatusId'] = self.taskflow_status_id
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
        self.custom_fields = []
        if m.get('customFields') is not None:
            for k in m.get('customFields'):
                temp_model = GetTaskByIdsResponseBodyResultCustomFields()
                self.custom_fields.append(temp_model.from_map(k))
        if m.get('dueDate') is not None:
            self.due_date = m.get('dueDate')
        if m.get('executorId') is not None:
            self.executor_id = m.get('executorId')
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
        if m.get('projectId') is not None:
            self.project_id = m.get('projectId')
        if m.get('recurrence') is not None:
            self.recurrence = m.get('recurrence')
        if m.get('scenarioFieldConfigId') is not None:
            self.scenario_field_config_id = m.get('scenarioFieldConfigId')
        if m.get('sprintId') is not None:
            self.sprint_id = m.get('sprintId')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        if m.get('storyPoint') is not None:
            self.story_point = m.get('storyPoint')
        if m.get('tagIds') is not None:
            self.tag_ids = m.get('tagIds')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('taskListId') is not None:
            self.task_list_id = m.get('taskListId')
        if m.get('taskStageId') is not None:
            self.task_stage_id = m.get('taskStageId')
        if m.get('taskflowStatusId') is not None:
            self.taskflow_status_id = m.get('taskflowStatusId')
        if m.get('uniqueId') is not None:
            self.unique_id = m.get('uniqueId')
        if m.get('updated') is not None:
            self.updated = m.get('updated')
        if m.get('visible') is not None:
            self.visible = m.get('visible')
        return self


class GetTaskByIdsResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetTaskByIdsResponseBodyResult] = None,
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
                temp_model = GetTaskByIdsResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GetTaskByIdsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetTaskByIdsResponseBody = None,
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
            temp_model = GetTaskByIdsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetTbOrgIdByDingOrgIdHeaders(TeaModel):
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


class GetTbOrgIdByDingOrgIdRequest(TeaModel):
    def __init__(
        self,
        opt_user_id: str = None,
    ):
        # This parameter is required.
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


class GetTbOrgIdByDingOrgIdResponseBodyResult(TeaModel):
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


class GetTbOrgIdByDingOrgIdResponseBody(TeaModel):
    def __init__(
        self,
        result: GetTbOrgIdByDingOrgIdResponseBodyResult = None,
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
            temp_model = GetTbOrgIdByDingOrgIdResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetTbOrgIdByDingOrgIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetTbOrgIdByDingOrgIdResponseBody = None,
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
            temp_model = GetTbOrgIdByDingOrgIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetTbProjectGrayHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        ding_access_token_type: str = None,
        ding_corp_id: str = None,
        ding_isv_org_id: str = None,
        ding_org_id: str = None,
        ding_suite_key: str = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.ding_access_token_type = ding_access_token_type
        self.ding_corp_id = ding_corp_id
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_org_id = ding_org_id
        self.ding_suite_key = ding_suite_key
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
        if self.ding_access_token_type is not None:
            result['dingAccessTokenType'] = self.ding_access_token_type
        if self.ding_corp_id is not None:
            result['dingCorpId'] = self.ding_corp_id
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('dingAccessTokenType') is not None:
            self.ding_access_token_type = m.get('dingAccessTokenType')
        if m.get('dingCorpId') is not None:
            self.ding_corp_id = m.get('dingCorpId')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetTbProjectGrayRequest(TeaModel):
    def __init__(
        self,
        label: str = None,
    ):
        # This parameter is required.
        self.label = label

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.label is not None:
            result['label'] = self.label
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('label') is not None:
            self.label = m.get('label')
        return self


class GetTbProjectGrayResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: bool = None,
    ):
        self.request_id = request_id
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class GetTbProjectGrayResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetTbProjectGrayResponseBody = None,
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
            temp_model = GetTbProjectGrayResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetTbProjectSourceHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        ding_access_token_type: str = None,
        ding_corp_id: str = None,
        ding_isv_org_id: str = None,
        ding_org_id: str = None,
        ding_suite_key: str = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.ding_access_token_type = ding_access_token_type
        self.ding_corp_id = ding_corp_id
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_org_id = ding_org_id
        self.ding_suite_key = ding_suite_key
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
        if self.ding_access_token_type is not None:
            result['dingAccessTokenType'] = self.ding_access_token_type
        if self.ding_corp_id is not None:
            result['dingCorpId'] = self.ding_corp_id
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('dingAccessTokenType') is not None:
            self.ding_access_token_type = m.get('dingAccessTokenType')
        if m.get('dingCorpId') is not None:
            self.ding_corp_id = m.get('dingCorpId')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetTbProjectSourceResponseBody(TeaModel):
    def __init__(
        self,
        install_source: str = None,
    ):
        self.install_source = install_source

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.install_source is not None:
            result['installSource'] = self.install_source
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('installSource') is not None:
            self.install_source = m.get('installSource')
        return self


class GetTbProjectSourceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetTbProjectSourceResponseBody = None,
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
            temp_model = GetTbProjectSourceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetTbUserIdByStaffIdHeaders(TeaModel):
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


class GetTbUserIdByStaffIdRequest(TeaModel):
    def __init__(
        self,
        opt_user_id: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.opt_user_id = opt_user_id
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.opt_user_id is not None:
            result['optUserId'] = self.opt_user_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('optUserId') is not None:
            self.opt_user_id = m.get('optUserId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetTbUserIdByStaffIdResponseBodyResult(TeaModel):
    def __init__(
        self,
        tb_user_id: str = None,
    ):
        # This parameter is required.
        self.tb_user_id = tb_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.tb_user_id is not None:
            result['tbUserId'] = self.tb_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('tbUserId') is not None:
            self.tb_user_id = m.get('tbUserId')
        return self


class GetTbUserIdByStaffIdResponseBody(TeaModel):
    def __init__(
        self,
        result: GetTbUserIdByStaffIdResponseBodyResult = None,
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
            temp_model = GetTbUserIdByStaffIdResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetTbUserIdByStaffIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetTbUserIdByStaffIdResponseBody = None,
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
            temp_model = GetTbUserIdByStaffIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetUserJoinedProjectHeaders(TeaModel):
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


class GetUserJoinedProjectRequest(TeaModel):
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


class GetUserJoinedProjectResponseBody(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        result: List[str] = None,
    ):
        self.next_token = next_token
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
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class GetUserJoinedProjectResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetUserJoinedProjectResponseBody = None,
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
            temp_model = GetUserJoinedProjectResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryProjectHeaders(TeaModel):
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


class QueryProjectRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        name: str = None,
        next_token: str = None,
        project_ids: str = None,
        source_id: str = None,
    ):
        self.max_results = max_results
        self.name = name
        self.next_token = next_token
        self.project_ids = project_ids
        self.source_id = source_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
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
        return self


class QueryProjectResponseBodyResultCustomFieldsValue(TeaModel):
    def __init__(
        self,
        custom_field_value_id: str = None,
        meta_string: str = None,
        title: str = None,
    ):
        self.custom_field_value_id = custom_field_value_id
        self.meta_string = meta_string
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.custom_field_value_id is not None:
            result['customFieldValueId'] = self.custom_field_value_id
        if self.meta_string is not None:
            result['metaString'] = self.meta_string
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customFieldValueId') is not None:
            self.custom_field_value_id = m.get('customFieldValueId')
        if m.get('metaString') is not None:
            self.meta_string = m.get('metaString')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class QueryProjectResponseBodyResultCustomFields(TeaModel):
    def __init__(
        self,
        custom_field_id: str = None,
        type: str = None,
        value: List[QueryProjectResponseBodyResultCustomFieldsValue] = None,
    ):
        self.custom_field_id = custom_field_id
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
        if self.custom_field_id is not None:
            result['customFieldId'] = self.custom_field_id
        if self.type is not None:
            result['type'] = self.type
        result['value'] = []
        if self.value is not None:
            for k in self.value:
                result['value'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customFieldId') is not None:
            self.custom_field_id = m.get('customFieldId')
        if m.get('type') is not None:
            self.type = m.get('type')
        self.value = []
        if m.get('value') is not None:
            for k in m.get('value'):
                temp_model = QueryProjectResponseBodyResultCustomFieldsValue()
                self.value.append(temp_model.from_map(k))
        return self


class QueryProjectResponseBodyResult(TeaModel):
    def __init__(
        self,
        created: str = None,
        creator_id: str = None,
        custom_fields: List[QueryProjectResponseBodyResultCustomFields] = None,
        description: str = None,
        end_date: str = None,
        is_archived: bool = None,
        is_suspended: bool = None,
        is_template: bool = None,
        logo: str = None,
        name: str = None,
        organization_id: str = None,
        project_id: str = None,
        start_date: str = None,
        unique_id_prefix: str = None,
        updated: str = None,
        visibility: str = None,
    ):
        self.created = created
        self.creator_id = creator_id
        self.custom_fields = custom_fields
        self.description = description
        self.end_date = end_date
        self.is_archived = is_archived
        self.is_suspended = is_suspended
        self.is_template = is_template
        self.logo = logo
        self.name = name
        self.organization_id = organization_id
        self.project_id = project_id
        self.start_date = start_date
        self.unique_id_prefix = unique_id_prefix
        self.updated = updated
        self.visibility = visibility

    def validate(self):
        if self.custom_fields:
            for k in self.custom_fields:
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
        result['customFields'] = []
        if self.custom_fields is not None:
            for k in self.custom_fields:
                result['customFields'].append(k.to_map() if k else None)
        if self.description is not None:
            result['description'] = self.description
        if self.end_date is not None:
            result['endDate'] = self.end_date
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
        if self.project_id is not None:
            result['projectId'] = self.project_id
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
        self.custom_fields = []
        if m.get('customFields') is not None:
            for k in m.get('customFields'):
                temp_model = QueryProjectResponseBodyResultCustomFields()
                self.custom_fields.append(temp_model.from_map(k))
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
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
        if m.get('projectId') is not None:
            self.project_id = m.get('projectId')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        if m.get('uniqueIdPrefix') is not None:
            self.unique_id_prefix = m.get('uniqueIdPrefix')
        if m.get('updated') is not None:
            self.updated = m.get('updated')
        if m.get('visibility') is not None:
            self.visibility = m.get('visibility')
        return self


class QueryProjectResponseBody(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        request_id: str = None,
        result: List[QueryProjectResponseBodyResult] = None,
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
                temp_model = QueryProjectResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class QueryProjectResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryProjectResponseBody = None,
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
            temp_model = QueryProjectResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryTaskOfProjectHeaders(TeaModel):
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


class QueryTaskOfProjectRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        query: str = None,
    ):
        self.max_results = max_results
        self.next_token = next_token
        self.query = query

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
        if self.query is not None:
            result['query'] = self.query
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('query') is not None:
            self.query = m.get('query')
        return self


class QueryTaskOfProjectResponseBodyResultCustomfields(TeaModel):
    def __init__(
        self,
        customfield_id: str = None,
    ):
        self.customfield_id = customfield_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.customfield_id is not None:
            result['customfieldId'] = self.customfield_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customfieldId') is not None:
            self.customfield_id = m.get('customfieldId')
        return self


class QueryTaskOfProjectResponseBodyResult(TeaModel):
    def __init__(
        self,
        accomplished: str = None,
        ancestor_ids: List[str] = None,
        content: str = None,
        created: str = None,
        creator_id: str = None,
        customfields: List[QueryTaskOfProjectResponseBodyResultCustomfields] = None,
        due_date: str = None,
        executor_id: str = None,
        involve_members: List[str] = None,
        is_archived: bool = None,
        is_deleted: bool = None,
        is_done: bool = None,
        labels: List[str] = None,
        note: str = None,
        priority: int = None,
        progress: int = None,
        project_id: str = None,
        scenariofieldconfig_id: str = None,
        sprint_id: str = None,
        stage_id: str = None,
        start_date: str = None,
        story_point: int = None,
        tag_ids: List[str] = None,
        task_id: str = None,
        taskflowstatus_id: str = None,
        updated: str = None,
        visible: str = None,
    ):
        self.accomplished = accomplished
        self.ancestor_ids = ancestor_ids
        self.content = content
        self.created = created
        self.creator_id = creator_id
        self.customfields = customfields
        self.due_date = due_date
        self.executor_id = executor_id
        self.involve_members = involve_members
        self.is_archived = is_archived
        self.is_deleted = is_deleted
        self.is_done = is_done
        self.labels = labels
        self.note = note
        self.priority = priority
        self.progress = progress
        self.project_id = project_id
        self.scenariofieldconfig_id = scenariofieldconfig_id
        self.sprint_id = sprint_id
        self.stage_id = stage_id
        self.start_date = start_date
        self.story_point = story_point
        self.tag_ids = tag_ids
        self.task_id = task_id
        self.taskflowstatus_id = taskflowstatus_id
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
        if self.is_archived is not None:
            result['isArchived'] = self.is_archived
        if self.is_deleted is not None:
            result['isDeleted'] = self.is_deleted
        if self.is_done is not None:
            result['isDone'] = self.is_done
        if self.labels is not None:
            result['labels'] = self.labels
        if self.note is not None:
            result['note'] = self.note
        if self.priority is not None:
            result['priority'] = self.priority
        if self.progress is not None:
            result['progress'] = self.progress
        if self.project_id is not None:
            result['projectId'] = self.project_id
        if self.scenariofieldconfig_id is not None:
            result['scenariofieldconfigId'] = self.scenariofieldconfig_id
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
        if self.taskflowstatus_id is not None:
            result['taskflowstatusId'] = self.taskflowstatus_id
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
        self.customfields = []
        if m.get('customfields') is not None:
            for k in m.get('customfields'):
                temp_model = QueryTaskOfProjectResponseBodyResultCustomfields()
                self.customfields.append(temp_model.from_map(k))
        if m.get('dueDate') is not None:
            self.due_date = m.get('dueDate')
        if m.get('executorId') is not None:
            self.executor_id = m.get('executorId')
        if m.get('involveMembers') is not None:
            self.involve_members = m.get('involveMembers')
        if m.get('isArchived') is not None:
            self.is_archived = m.get('isArchived')
        if m.get('isDeleted') is not None:
            self.is_deleted = m.get('isDeleted')
        if m.get('isDone') is not None:
            self.is_done = m.get('isDone')
        if m.get('labels') is not None:
            self.labels = m.get('labels')
        if m.get('note') is not None:
            self.note = m.get('note')
        if m.get('priority') is not None:
            self.priority = m.get('priority')
        if m.get('progress') is not None:
            self.progress = m.get('progress')
        if m.get('projectId') is not None:
            self.project_id = m.get('projectId')
        if m.get('scenariofieldconfigId') is not None:
            self.scenariofieldconfig_id = m.get('scenariofieldconfigId')
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
        if m.get('taskflowstatusId') is not None:
            self.taskflowstatus_id = m.get('taskflowstatusId')
        if m.get('updated') is not None:
            self.updated = m.get('updated')
        if m.get('visible') is not None:
            self.visible = m.get('visible')
        return self


class QueryTaskOfProjectResponseBody(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        result: List[QueryTaskOfProjectResponseBodyResult] = None,
        total_count: int = None,
    ):
        # This parameter is required.
        self.next_token = next_token
        self.result = result
        # This parameter is required.
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
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['result'] = []
        if self.result is not None:
            for k in self.result:
                result['result'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = QueryTaskOfProjectResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class QueryTaskOfProjectResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryTaskOfProjectResponseBody = None,
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
            temp_model = QueryTaskOfProjectResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SeachTaskStageHeaders(TeaModel):
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


class SeachTaskStageRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        query: str = None,
        task_list_id: str = None,
        task_stage_ids: str = None,
    ):
        self.max_results = max_results
        self.next_token = next_token
        self.query = query
        self.task_list_id = task_list_id
        self.task_stage_ids = task_stage_ids

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
        if self.query is not None:
            result['query'] = self.query
        if self.task_list_id is not None:
            result['taskListId'] = self.task_list_id
        if self.task_stage_ids is not None:
            result['taskStageIds'] = self.task_stage_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('query') is not None:
            self.query = m.get('query')
        if m.get('taskListId') is not None:
            self.task_list_id = m.get('taskListId')
        if m.get('taskStageIds') is not None:
            self.task_stage_ids = m.get('taskStageIds')
        return self


class SeachTaskStageResponseBodyResult(TeaModel):
    def __init__(
        self,
        created: str = None,
        creator_id: str = None,
        description: str = None,
        name: str = None,
        project_id: str = None,
        task_list_id: str = None,
        task_stage_id: str = None,
        updated: str = None,
    ):
        self.created = created
        self.creator_id = creator_id
        self.description = description
        self.name = name
        self.project_id = project_id
        self.task_list_id = task_list_id
        self.task_stage_id = task_stage_id
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
        if self.name is not None:
            result['name'] = self.name
        if self.project_id is not None:
            result['projectId'] = self.project_id
        if self.task_list_id is not None:
            result['taskListId'] = self.task_list_id
        if self.task_stage_id is not None:
            result['taskStageId'] = self.task_stage_id
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
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('projectId') is not None:
            self.project_id = m.get('projectId')
        if m.get('taskListId') is not None:
            self.task_list_id = m.get('taskListId')
        if m.get('taskStageId') is not None:
            self.task_stage_id = m.get('taskStageId')
        if m.get('updated') is not None:
            self.updated = m.get('updated')
        return self


class SeachTaskStageResponseBody(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        result: List[SeachTaskStageResponseBodyResult] = None,
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
                temp_model = SeachTaskStageResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class SeachTaskStageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SeachTaskStageResponseBody = None,
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
            temp_model = SeachTaskStageResponseBody()
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


class SearchOranizationCustomfieldHeaders(TeaModel):
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


class SearchOranizationCustomfieldRequest(TeaModel):
    def __init__(
        self,
        custom_field_ids: str = None,
        instance_ids: str = None,
        max_results: int = None,
        next_token: str = None,
        project_ids: str = None,
        query: str = None,
    ):
        self.custom_field_ids = custom_field_ids
        self.instance_ids = instance_ids
        self.max_results = max_results
        self.next_token = next_token
        self.project_ids = project_ids
        self.query = query

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.custom_field_ids is not None:
            result['customFieldIds'] = self.custom_field_ids
        if self.instance_ids is not None:
            result['instanceIds'] = self.instance_ids
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.project_ids is not None:
            result['projectIds'] = self.project_ids
        if self.query is not None:
            result['query'] = self.query
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customFieldIds') is not None:
            self.custom_field_ids = m.get('customFieldIds')
        if m.get('instanceIds') is not None:
            self.instance_ids = m.get('instanceIds')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('projectIds') is not None:
            self.project_ids = m.get('projectIds')
        if m.get('query') is not None:
            self.query = m.get('query')
        return self


class SearchOranizationCustomfieldResponseBodyResultAdvancedCustomField(TeaModel):
    def __init__(
        self,
        advanced_custom_field_id: str = None,
        name: str = None,
        object_type: str = None,
    ):
        self.advanced_custom_field_id = advanced_custom_field_id
        self.name = name
        self.object_type = object_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.advanced_custom_field_id is not None:
            result['advancedCustomFieldId'] = self.advanced_custom_field_id
        if self.name is not None:
            result['name'] = self.name
        if self.object_type is not None:
            result['objectType'] = self.object_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('advancedCustomFieldId') is not None:
            self.advanced_custom_field_id = m.get('advancedCustomFieldId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('objectType') is not None:
            self.object_type = m.get('objectType')
        return self


class SearchOranizationCustomfieldResponseBodyResultChoices(TeaModel):
    def __init__(
        self,
        choice_id: str = None,
        value: str = None,
    ):
        self.choice_id = choice_id
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.choice_id is not None:
            result['choiceId'] = self.choice_id
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('choiceId') is not None:
            self.choice_id = m.get('choiceId')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class SearchOranizationCustomfieldResponseBodyResult(TeaModel):
    def __init__(
        self,
        advanced_custom_field: SearchOranizationCustomfieldResponseBodyResultAdvancedCustomField = None,
        choices: List[SearchOranizationCustomfieldResponseBodyResultChoices] = None,
        created: str = None,
        creator_id: str = None,
        custom_fields_id: str = None,
        name: str = None,
        payload: Dict[str, Any] = None,
        type: str = None,
    ):
        self.advanced_custom_field = advanced_custom_field
        self.choices = choices
        self.created = created
        self.creator_id = creator_id
        self.custom_fields_id = custom_fields_id
        self.name = name
        self.payload = payload
        self.type = type

    def validate(self):
        if self.advanced_custom_field:
            self.advanced_custom_field.validate()
        if self.choices:
            for k in self.choices:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.advanced_custom_field is not None:
            result['advancedCustomField'] = self.advanced_custom_field.to_map()
        result['choices'] = []
        if self.choices is not None:
            for k in self.choices:
                result['choices'].append(k.to_map() if k else None)
        if self.created is not None:
            result['created'] = self.created
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.custom_fields_id is not None:
            result['customFieldsId'] = self.custom_fields_id
        if self.name is not None:
            result['name'] = self.name
        if self.payload is not None:
            result['payload'] = self.payload
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('advancedCustomField') is not None:
            temp_model = SearchOranizationCustomfieldResponseBodyResultAdvancedCustomField()
            self.advanced_custom_field = temp_model.from_map(m['advancedCustomField'])
        self.choices = []
        if m.get('choices') is not None:
            for k in m.get('choices'):
                temp_model = SearchOranizationCustomfieldResponseBodyResultChoices()
                self.choices.append(temp_model.from_map(k))
        if m.get('created') is not None:
            self.created = m.get('created')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('customFieldsId') is not None:
            self.custom_fields_id = m.get('customFieldsId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('payload') is not None:
            self.payload = m.get('payload')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class SearchOranizationCustomfieldResponseBody(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        result: List[SearchOranizationCustomfieldResponseBodyResult] = None,
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
                temp_model = SearchOranizationCustomfieldResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class SearchOranizationCustomfieldResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SearchOranizationCustomfieldResponseBody = None,
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
            temp_model = SearchOranizationCustomfieldResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SearchProjectCustomfieldHeaders(TeaModel):
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


class SearchProjectCustomfieldRequest(TeaModel):
    def __init__(
        self,
        custom_field_ids: str = None,
        instance_ids: str = None,
        max_results: int = None,
        next_token: str = None,
        query: str = None,
        scenario_field_config_id: str = None,
    ):
        self.custom_field_ids = custom_field_ids
        self.instance_ids = instance_ids
        self.max_results = max_results
        self.next_token = next_token
        self.query = query
        self.scenario_field_config_id = scenario_field_config_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.custom_field_ids is not None:
            result['customFieldIds'] = self.custom_field_ids
        if self.instance_ids is not None:
            result['instanceIds'] = self.instance_ids
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.query is not None:
            result['query'] = self.query
        if self.scenario_field_config_id is not None:
            result['scenarioFieldConfigId'] = self.scenario_field_config_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customFieldIds') is not None:
            self.custom_field_ids = m.get('customFieldIds')
        if m.get('instanceIds') is not None:
            self.instance_ids = m.get('instanceIds')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('query') is not None:
            self.query = m.get('query')
        if m.get('scenarioFieldConfigId') is not None:
            self.scenario_field_config_id = m.get('scenarioFieldConfigId')
        return self


class SearchProjectCustomfieldResponseBodyResultAdvancedCustomField(TeaModel):
    def __init__(
        self,
        advanced_custom_field_id: str = None,
        name: str = None,
        object_type: str = None,
    ):
        self.advanced_custom_field_id = advanced_custom_field_id
        self.name = name
        self.object_type = object_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.advanced_custom_field_id is not None:
            result['advancedCustomFieldId'] = self.advanced_custom_field_id
        if self.name is not None:
            result['name'] = self.name
        if self.object_type is not None:
            result['objectType'] = self.object_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('advancedCustomFieldId') is not None:
            self.advanced_custom_field_id = m.get('advancedCustomFieldId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('objectType') is not None:
            self.object_type = m.get('objectType')
        return self


class SearchProjectCustomfieldResponseBodyResultChoices(TeaModel):
    def __init__(
        self,
        choice_id: str = None,
        value: str = None,
    ):
        self.choice_id = choice_id
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.choice_id is not None:
            result['choiceId'] = self.choice_id
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('choiceId') is not None:
            self.choice_id = m.get('choiceId')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class SearchProjectCustomfieldResponseBodyResult(TeaModel):
    def __init__(
        self,
        advanced_custom_field: SearchProjectCustomfieldResponseBodyResultAdvancedCustomField = None,
        bound_to_object_id: str = None,
        choices: List[SearchProjectCustomfieldResponseBodyResultChoices] = None,
        created: str = None,
        creator_id: str = None,
        custom_field_id: str = None,
        name: str = None,
        original_id: str = None,
        payload: Dict[str, Any] = None,
        type: str = None,
    ):
        self.advanced_custom_field = advanced_custom_field
        self.bound_to_object_id = bound_to_object_id
        self.choices = choices
        self.created = created
        self.creator_id = creator_id
        self.custom_field_id = custom_field_id
        self.name = name
        self.original_id = original_id
        self.payload = payload
        self.type = type

    def validate(self):
        if self.advanced_custom_field:
            self.advanced_custom_field.validate()
        if self.choices:
            for k in self.choices:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.advanced_custom_field is not None:
            result['advancedCustomField'] = self.advanced_custom_field.to_map()
        if self.bound_to_object_id is not None:
            result['boundToObjectId'] = self.bound_to_object_id
        result['choices'] = []
        if self.choices is not None:
            for k in self.choices:
                result['choices'].append(k.to_map() if k else None)
        if self.created is not None:
            result['created'] = self.created
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.custom_field_id is not None:
            result['customFieldId'] = self.custom_field_id
        if self.name is not None:
            result['name'] = self.name
        if self.original_id is not None:
            result['originalId'] = self.original_id
        if self.payload is not None:
            result['payload'] = self.payload
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('advancedCustomField') is not None:
            temp_model = SearchProjectCustomfieldResponseBodyResultAdvancedCustomField()
            self.advanced_custom_field = temp_model.from_map(m['advancedCustomField'])
        if m.get('boundToObjectId') is not None:
            self.bound_to_object_id = m.get('boundToObjectId')
        self.choices = []
        if m.get('choices') is not None:
            for k in m.get('choices'):
                temp_model = SearchProjectCustomfieldResponseBodyResultChoices()
                self.choices.append(temp_model.from_map(k))
        if m.get('created') is not None:
            self.created = m.get('created')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('customFieldId') is not None:
            self.custom_field_id = m.get('customFieldId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('originalId') is not None:
            self.original_id = m.get('originalId')
        if m.get('payload') is not None:
            self.payload = m.get('payload')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class SearchProjectCustomfieldResponseBody(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        result: List[SearchProjectCustomfieldResponseBodyResult] = None,
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
                temp_model = SearchProjectCustomfieldResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class SearchProjectCustomfieldResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SearchProjectCustomfieldResponseBody = None,
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
            temp_model = SearchProjectCustomfieldResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SearchProjectTemplateHeaders(TeaModel):
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


class SearchProjectTemplateRequest(TeaModel):
    def __init__(
        self,
        keyword: str = None,
    ):
        self.keyword = keyword

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.keyword is not None:
            result['keyword'] = self.keyword
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('keyword') is not None:
            self.keyword = m.get('keyword')
        return self


class SearchProjectTemplateResponseBodyResult(TeaModel):
    def __init__(
        self,
        created: str = None,
        description: str = None,
        id: str = None,
        is_deleted: bool = None,
        is_demo: bool = None,
        logo: str = None,
        name: str = None,
        updated: str = None,
        visible: str = None,
    ):
        self.created = created
        self.description = description
        self.id = id
        self.is_deleted = is_deleted
        self.is_demo = is_demo
        self.logo = logo
        self.name = name
        self.updated = updated
        self.visible = visible

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.created is not None:
            result['created'] = self.created
        if self.description is not None:
            result['description'] = self.description
        if self.id is not None:
            result['id'] = self.id
        if self.is_deleted is not None:
            result['isDeleted'] = self.is_deleted
        if self.is_demo is not None:
            result['isDemo'] = self.is_demo
        if self.logo is not None:
            result['logo'] = self.logo
        if self.name is not None:
            result['name'] = self.name
        if self.updated is not None:
            result['updated'] = self.updated
        if self.visible is not None:
            result['visible'] = self.visible
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('created') is not None:
            self.created = m.get('created')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isDeleted') is not None:
            self.is_deleted = m.get('isDeleted')
        if m.get('isDemo') is not None:
            self.is_demo = m.get('isDemo')
        if m.get('logo') is not None:
            self.logo = m.get('logo')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('updated') is not None:
            self.updated = m.get('updated')
        if m.get('visible') is not None:
            self.visible = m.get('visible')
        return self


class SearchProjectTemplateResponseBody(TeaModel):
    def __init__(
        self,
        result: List[SearchProjectTemplateResponseBodyResult] = None,
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
                temp_model = SearchProjectTemplateResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class SearchProjectTemplateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SearchProjectTemplateResponseBody = None,
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
            temp_model = SearchProjectTemplateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SearchTaskFlowHeaders(TeaModel):
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


class SearchTaskFlowRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        query: str = None,
        taskflow_ids: str = None,
    ):
        self.max_results = max_results
        self.next_token = next_token
        self.query = query
        self.taskflow_ids = taskflow_ids

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
        if self.query is not None:
            result['query'] = self.query
        if self.taskflow_ids is not None:
            result['taskflowIds'] = self.taskflow_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('query') is not None:
            self.query = m.get('query')
        if m.get('taskflowIds') is not None:
            self.taskflow_ids = m.get('taskflowIds')
        return self


class SearchTaskFlowResponseBodyResult(TeaModel):
    def __init__(
        self,
        bound_to_object_id: str = None,
        bound_to_object_type: str = None,
        created: str = None,
        creator_id: str = None,
        is_deleted: bool = None,
        name: str = None,
        taskflow_id: str = None,
        updated: str = None,
    ):
        self.bound_to_object_id = bound_to_object_id
        self.bound_to_object_type = bound_to_object_type
        self.created = created
        self.creator_id = creator_id
        self.is_deleted = is_deleted
        self.name = name
        self.taskflow_id = taskflow_id
        self.updated = updated

    def validate(self):
        pass

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
        if self.is_deleted is not None:
            result['isDeleted'] = self.is_deleted
        if self.name is not None:
            result['name'] = self.name
        if self.taskflow_id is not None:
            result['taskflowId'] = self.taskflow_id
        if self.updated is not None:
            result['updated'] = self.updated
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
        if m.get('isDeleted') is not None:
            self.is_deleted = m.get('isDeleted')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('taskflowId') is not None:
            self.taskflow_id = m.get('taskflowId')
        if m.get('updated') is not None:
            self.updated = m.get('updated')
        return self


class SearchTaskFlowResponseBody(TeaModel):
    def __init__(
        self,
        result: List[SearchTaskFlowResponseBodyResult] = None,
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
                temp_model = SearchTaskFlowResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class SearchTaskFlowResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SearchTaskFlowResponseBody = None,
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
            temp_model = SearchTaskFlowResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SearchTaskListHeaders(TeaModel):
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


class SearchTaskListRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        query: str = None,
        task_list_ids: str = None,
    ):
        self.max_results = max_results
        self.next_token = next_token
        self.query = query
        self.task_list_ids = task_list_ids

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
        if self.query is not None:
            result['query'] = self.query
        if self.task_list_ids is not None:
            result['taskListIds'] = self.task_list_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('query') is not None:
            self.query = m.get('query')
        if m.get('taskListIds') is not None:
            self.task_list_ids = m.get('taskListIds')
        return self


class SearchTaskListResponseBodyResult(TeaModel):
    def __init__(
        self,
        created: str = None,
        creator_id: str = None,
        description: str = None,
        project_id: str = None,
        task_list_id: str = None,
        title: str = None,
        updated: str = None,
    ):
        self.created = created
        self.creator_id = creator_id
        self.description = description
        self.project_id = project_id
        self.task_list_id = task_list_id
        self.title = title
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
        if self.project_id is not None:
            result['projectId'] = self.project_id
        if self.task_list_id is not None:
            result['taskListId'] = self.task_list_id
        if self.title is not None:
            result['title'] = self.title
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
        if m.get('projectId') is not None:
            self.project_id = m.get('projectId')
        if m.get('taskListId') is not None:
            self.task_list_id = m.get('taskListId')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('updated') is not None:
            self.updated = m.get('updated')
        return self


class SearchTaskListResponseBody(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        result: List[SearchTaskListResponseBodyResult] = None,
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
                temp_model = SearchTaskListResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class SearchTaskListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SearchTaskListResponseBody = None,
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
            temp_model = SearchTaskListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SearchTaskflowStatusHeaders(TeaModel):
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


class SearchTaskflowStatusRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        query: str = None,
        tf_ids: str = None,
        tfs_ids: str = None,
    ):
        self.max_results = max_results
        self.next_token = next_token
        self.query = query
        self.tf_ids = tf_ids
        self.tfs_ids = tfs_ids

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
        if self.query is not None:
            result['query'] = self.query
        if self.tf_ids is not None:
            result['tfIds'] = self.tf_ids
        if self.tfs_ids is not None:
            result['tfsIds'] = self.tfs_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('query') is not None:
            self.query = m.get('query')
        if m.get('tfIds') is not None:
            self.tf_ids = m.get('tfIds')
        if m.get('tfsIds') is not None:
            self.tfs_ids = m.get('tfsIds')
        return self


class SearchTaskflowStatusResponseBodyResult(TeaModel):
    def __init__(
        self,
        created: str = None,
        creator_id: str = None,
        is_deleted: bool = None,
        is_taskflowstatusruleexector: bool = None,
        kind: str = None,
        name: str = None,
        pos: int = None,
        reject_status_ids: List[str] = None,
        taskflow_id: str = None,
        taskflow_status_id: str = None,
        updated: str = None,
    ):
        self.created = created
        self.creator_id = creator_id
        self.is_deleted = is_deleted
        self.is_taskflowstatusruleexector = is_taskflowstatusruleexector
        self.kind = kind
        self.name = name
        self.pos = pos
        self.reject_status_ids = reject_status_ids
        self.taskflow_id = taskflow_id
        self.taskflow_status_id = taskflow_status_id
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
        if self.is_deleted is not None:
            result['isDeleted'] = self.is_deleted
        if self.is_taskflowstatusruleexector is not None:
            result['isTaskflowstatusruleexector'] = self.is_taskflowstatusruleexector
        if self.kind is not None:
            result['kind'] = self.kind
        if self.name is not None:
            result['name'] = self.name
        if self.pos is not None:
            result['pos'] = self.pos
        if self.reject_status_ids is not None:
            result['rejectStatusIds'] = self.reject_status_ids
        if self.taskflow_id is not None:
            result['taskflowId'] = self.taskflow_id
        if self.taskflow_status_id is not None:
            result['taskflowStatusId'] = self.taskflow_status_id
        if self.updated is not None:
            result['updated'] = self.updated
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('created') is not None:
            self.created = m.get('created')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('isDeleted') is not None:
            self.is_deleted = m.get('isDeleted')
        if m.get('isTaskflowstatusruleexector') is not None:
            self.is_taskflowstatusruleexector = m.get('isTaskflowstatusruleexector')
        if m.get('kind') is not None:
            self.kind = m.get('kind')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('pos') is not None:
            self.pos = m.get('pos')
        if m.get('rejectStatusIds') is not None:
            self.reject_status_ids = m.get('rejectStatusIds')
        if m.get('taskflowId') is not None:
            self.taskflow_id = m.get('taskflowId')
        if m.get('taskflowStatusId') is not None:
            self.taskflow_status_id = m.get('taskflowStatusId')
        if m.get('updated') is not None:
            self.updated = m.get('updated')
        return self


class SearchTaskflowStatusResponseBody(TeaModel):
    def __init__(
        self,
        result: List[SearchTaskflowStatusResponseBodyResult] = None,
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
                temp_model = SearchTaskflowStatusResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class SearchTaskflowStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SearchTaskflowStatusResponseBody = None,
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
            temp_model = SearchTaskflowStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SearchUserTaskHeaders(TeaModel):
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


class SearchUserTaskRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        role_types: str = None,
        tql: str = None,
    ):
        self.max_results = max_results
        self.next_token = next_token
        # This parameter is required.
        self.role_types = role_types
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
        if self.role_types is not None:
            result['roleTypes'] = self.role_types
        if self.tql is not None:
            result['tql'] = self.tql
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('roleTypes') is not None:
            self.role_types = m.get('roleTypes')
        if m.get('tql') is not None:
            self.tql = m.get('tql')
        return self


class SearchUserTaskResponseBodyResultCustomFieldsValue(TeaModel):
    def __init__(
        self,
        custom_field_value_id: str = None,
        meta_string: str = None,
        title: str = None,
    ):
        self.custom_field_value_id = custom_field_value_id
        self.meta_string = meta_string
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.custom_field_value_id is not None:
            result['customFieldValueId'] = self.custom_field_value_id
        if self.meta_string is not None:
            result['metaString'] = self.meta_string
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customFieldValueId') is not None:
            self.custom_field_value_id = m.get('customFieldValueId')
        if m.get('metaString') is not None:
            self.meta_string = m.get('metaString')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class SearchUserTaskResponseBodyResultCustomFields(TeaModel):
    def __init__(
        self,
        custom_field_id: str = None,
        type: str = None,
        value: List[SearchUserTaskResponseBodyResultCustomFieldsValue] = None,
    ):
        self.custom_field_id = custom_field_id
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
        if self.custom_field_id is not None:
            result['customFieldId'] = self.custom_field_id
        if self.type is not None:
            result['type'] = self.type
        result['value'] = []
        if self.value is not None:
            for k in self.value:
                result['value'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customFieldId') is not None:
            self.custom_field_id = m.get('customFieldId')
        if m.get('type') is not None:
            self.type = m.get('type')
        self.value = []
        if m.get('value') is not None:
            for k in m.get('value'):
                temp_model = SearchUserTaskResponseBodyResultCustomFieldsValue()
                self.value.append(temp_model.from_map(k))
        return self


class SearchUserTaskResponseBodyResult(TeaModel):
    def __init__(
        self,
        accomplish_time: str = None,
        ancestor_ids: List[str] = None,
        content: str = None,
        created: str = None,
        creator_id: str = None,
        custom_fields: List[SearchUserTaskResponseBodyResultCustomFields] = None,
        due_date: str = None,
        executor_id: str = None,
        involve_members: List[str] = None,
        is_archived: bool = None,
        is_done: bool = None,
        note: str = None,
        parent_task_id: str = None,
        priority: int = None,
        project_id: str = None,
        recurrence: List[str] = None,
        scenario_field_config_id: str = None,
        sprint_id: str = None,
        start_date: str = None,
        story_point: str = None,
        tag_ids: List[str] = None,
        task_id: str = None,
        task_list_id: str = None,
        task_stage_id: str = None,
        taskflow_status_id: str = None,
        unique_id: str = None,
        updated: str = None,
        visible: str = None,
    ):
        self.accomplish_time = accomplish_time
        self.ancestor_ids = ancestor_ids
        self.content = content
        self.created = created
        self.creator_id = creator_id
        self.custom_fields = custom_fields
        self.due_date = due_date
        self.executor_id = executor_id
        self.involve_members = involve_members
        self.is_archived = is_archived
        self.is_done = is_done
        self.note = note
        self.parent_task_id = parent_task_id
        self.priority = priority
        self.project_id = project_id
        self.recurrence = recurrence
        self.scenario_field_config_id = scenario_field_config_id
        self.sprint_id = sprint_id
        self.start_date = start_date
        self.story_point = story_point
        self.tag_ids = tag_ids
        self.task_id = task_id
        self.task_list_id = task_list_id
        self.task_stage_id = task_stage_id
        self.taskflow_status_id = taskflow_status_id
        self.unique_id = unique_id
        self.updated = updated
        self.visible = visible

    def validate(self):
        if self.custom_fields:
            for k in self.custom_fields:
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
        result['customFields'] = []
        if self.custom_fields is not None:
            for k in self.custom_fields:
                result['customFields'].append(k.to_map() if k else None)
        if self.due_date is not None:
            result['dueDate'] = self.due_date
        if self.executor_id is not None:
            result['executorId'] = self.executor_id
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
        if self.project_id is not None:
            result['projectId'] = self.project_id
        if self.recurrence is not None:
            result['recurrence'] = self.recurrence
        if self.scenario_field_config_id is not None:
            result['scenarioFieldConfigId'] = self.scenario_field_config_id
        if self.sprint_id is not None:
            result['sprintId'] = self.sprint_id
        if self.start_date is not None:
            result['startDate'] = self.start_date
        if self.story_point is not None:
            result['storyPoint'] = self.story_point
        if self.tag_ids is not None:
            result['tagIds'] = self.tag_ids
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.task_list_id is not None:
            result['taskListId'] = self.task_list_id
        if self.task_stage_id is not None:
            result['taskStageId'] = self.task_stage_id
        if self.taskflow_status_id is not None:
            result['taskflowStatusId'] = self.taskflow_status_id
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
        self.custom_fields = []
        if m.get('customFields') is not None:
            for k in m.get('customFields'):
                temp_model = SearchUserTaskResponseBodyResultCustomFields()
                self.custom_fields.append(temp_model.from_map(k))
        if m.get('dueDate') is not None:
            self.due_date = m.get('dueDate')
        if m.get('executorId') is not None:
            self.executor_id = m.get('executorId')
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
        if m.get('projectId') is not None:
            self.project_id = m.get('projectId')
        if m.get('recurrence') is not None:
            self.recurrence = m.get('recurrence')
        if m.get('scenarioFieldConfigId') is not None:
            self.scenario_field_config_id = m.get('scenarioFieldConfigId')
        if m.get('sprintId') is not None:
            self.sprint_id = m.get('sprintId')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        if m.get('storyPoint') is not None:
            self.story_point = m.get('storyPoint')
        if m.get('tagIds') is not None:
            self.tag_ids = m.get('tagIds')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('taskListId') is not None:
            self.task_list_id = m.get('taskListId')
        if m.get('taskStageId') is not None:
            self.task_stage_id = m.get('taskStageId')
        if m.get('taskflowStatusId') is not None:
            self.taskflow_status_id = m.get('taskflowStatusId')
        if m.get('uniqueId') is not None:
            self.unique_id = m.get('uniqueId')
        if m.get('updated') is not None:
            self.updated = m.get('updated')
        if m.get('visible') is not None:
            self.visible = m.get('visible')
        return self


class SearchUserTaskResponseBody(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        request_id: str = None,
        result: List[SearchUserTaskResponseBodyResult] = None,
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
                temp_model = SearchUserTaskResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class SearchUserTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SearchUserTaskResponseBody = None,
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
            temp_model = SearchUserTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SuspendProjectHeaders(TeaModel):
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


class SuspendProjectResponseBodyResult(TeaModel):
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


class SuspendProjectResponseBody(TeaModel):
    def __init__(
        self,
        result: SuspendProjectResponseBodyResult = None,
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
            temp_model = SuspendProjectResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class SuspendProjectResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SuspendProjectResponseBody = None,
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
            temp_model = SuspendProjectResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UnSuspendProjectHeaders(TeaModel):
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


class UnSuspendProjectResponseBodyResult(TeaModel):
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


class UnSuspendProjectResponseBody(TeaModel):
    def __init__(
        self,
        result: UnSuspendProjectResponseBodyResult = None,
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
            temp_model = UnSuspendProjectResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class UnSuspendProjectResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UnSuspendProjectResponseBody = None,
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
            temp_model = UnSuspendProjectResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateCustomfieldValueHeaders(TeaModel):
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


class UpdateCustomfieldValueRequestValue(TeaModel):
    def __init__(
        self,
        title: str = None,
    ):
        # This parameter is required.
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


class UpdateCustomfieldValueRequest(TeaModel):
    def __init__(
        self,
        custom_field_id: str = None,
        custom_field_name: str = None,
        value: List[UpdateCustomfieldValueRequestValue] = None,
    ):
        self.custom_field_id = custom_field_id
        self.custom_field_name = custom_field_name
        # This parameter is required.
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
        if self.custom_field_id is not None:
            result['customFieldId'] = self.custom_field_id
        if self.custom_field_name is not None:
            result['customFieldName'] = self.custom_field_name
        result['value'] = []
        if self.value is not None:
            for k in self.value:
                result['value'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customFieldId') is not None:
            self.custom_field_id = m.get('customFieldId')
        if m.get('customFieldName') is not None:
            self.custom_field_name = m.get('customFieldName')
        self.value = []
        if m.get('value') is not None:
            for k in m.get('value'):
                temp_model = UpdateCustomfieldValueRequestValue()
                self.value.append(temp_model.from_map(k))
        return self


class UpdateCustomfieldValueResponseBodyResultCustomFieldsValue(TeaModel):
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


class UpdateCustomfieldValueResponseBodyResultCustomFields(TeaModel):
    def __init__(
        self,
        custom_field_id: str = None,
        value: List[UpdateCustomfieldValueResponseBodyResultCustomFieldsValue] = None,
    ):
        self.custom_field_id = custom_field_id
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
        if self.custom_field_id is not None:
            result['customFieldId'] = self.custom_field_id
        result['value'] = []
        if self.value is not None:
            for k in self.value:
                result['value'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customFieldId') is not None:
            self.custom_field_id = m.get('customFieldId')
        self.value = []
        if m.get('value') is not None:
            for k in m.get('value'):
                temp_model = UpdateCustomfieldValueResponseBodyResultCustomFieldsValue()
                self.value.append(temp_model.from_map(k))
        return self


class UpdateCustomfieldValueResponseBodyResult(TeaModel):
    def __init__(
        self,
        custom_fields: List[UpdateCustomfieldValueResponseBodyResultCustomFields] = None,
    ):
        self.custom_fields = custom_fields

    def validate(self):
        if self.custom_fields:
            for k in self.custom_fields:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['customFields'] = []
        if self.custom_fields is not None:
            for k in self.custom_fields:
                result['customFields'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.custom_fields = []
        if m.get('customFields') is not None:
            for k in m.get('customFields'):
                temp_model = UpdateCustomfieldValueResponseBodyResultCustomFields()
                self.custom_fields.append(temp_model.from_map(k))
        return self


class UpdateCustomfieldValueResponseBody(TeaModel):
    def __init__(
        self,
        result: UpdateCustomfieldValueResponseBodyResult = None,
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
            temp_model = UpdateCustomfieldValueResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class UpdateCustomfieldValueResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateCustomfieldValueResponseBody = None,
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
            temp_model = UpdateCustomfieldValueResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateOrganizationTaskContentHeaders(TeaModel):
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


class UpdateOrganizationTaskContentRequest(TeaModel):
    def __init__(
        self,
        content: str = None,
        disable_activity: bool = None,
        disable_notification: bool = None,
    ):
        # This parameter is required.
        self.content = content
        self.disable_activity = disable_activity
        self.disable_notification = disable_notification

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('disableActivity') is not None:
            self.disable_activity = m.get('disableActivity')
        if m.get('disableNotification') is not None:
            self.disable_notification = m.get('disableNotification')
        return self


class UpdateOrganizationTaskContentResponseBodyResult(TeaModel):
    def __init__(
        self,
        content: str = None,
        updated: str = None,
    ):
        self.content = content
        self.updated = updated

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.updated is not None:
            result['updated'] = self.updated
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('updated') is not None:
            self.updated = m.get('updated')
        return self


class UpdateOrganizationTaskContentResponseBody(TeaModel):
    def __init__(
        self,
        result: UpdateOrganizationTaskContentResponseBodyResult = None,
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
            temp_model = UpdateOrganizationTaskContentResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class UpdateOrganizationTaskContentResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateOrganizationTaskContentResponseBody = None,
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
            temp_model = UpdateOrganizationTaskContentResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateOrganizationTaskDueDateHeaders(TeaModel):
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


class UpdateOrganizationTaskDueDateRequest(TeaModel):
    def __init__(
        self,
        disable_activity: bool = None,
        disable_notification: bool = None,
        due_date: str = None,
    ):
        self.disable_activity = disable_activity
        self.disable_notification = disable_notification
        # This parameter is required.
        self.due_date = due_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.disable_activity is not None:
            result['disableActivity'] = self.disable_activity
        if self.disable_notification is not None:
            result['disableNotification'] = self.disable_notification
        if self.due_date is not None:
            result['dueDate'] = self.due_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('disableActivity') is not None:
            self.disable_activity = m.get('disableActivity')
        if m.get('disableNotification') is not None:
            self.disable_notification = m.get('disableNotification')
        if m.get('dueDate') is not None:
            self.due_date = m.get('dueDate')
        return self


class UpdateOrganizationTaskDueDateResponseBodyResult(TeaModel):
    def __init__(
        self,
        due_date: str = None,
        update_time: str = None,
    ):
        self.due_date = due_date
        self.update_time = update_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.due_date is not None:
            result['dueDate'] = self.due_date
        if self.update_time is not None:
            result['updateTime'] = self.update_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dueDate') is not None:
            self.due_date = m.get('dueDate')
        if m.get('updateTime') is not None:
            self.update_time = m.get('updateTime')
        return self


class UpdateOrganizationTaskDueDateResponseBody(TeaModel):
    def __init__(
        self,
        result: UpdateOrganizationTaskDueDateResponseBodyResult = None,
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
            temp_model = UpdateOrganizationTaskDueDateResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class UpdateOrganizationTaskDueDateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateOrganizationTaskDueDateResponseBody = None,
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
            temp_model = UpdateOrganizationTaskDueDateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateOrganizationTaskExecutorHeaders(TeaModel):
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


class UpdateOrganizationTaskExecutorRequest(TeaModel):
    def __init__(
        self,
        disable_activity: bool = None,
        disable_notification: bool = None,
        executor_id: str = None,
    ):
        self.disable_activity = disable_activity
        self.disable_notification = disable_notification
        # This parameter is required.
        self.executor_id = executor_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.disable_activity is not None:
            result['disableActivity'] = self.disable_activity
        if self.disable_notification is not None:
            result['disableNotification'] = self.disable_notification
        if self.executor_id is not None:
            result['executorId'] = self.executor_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('disableActivity') is not None:
            self.disable_activity = m.get('disableActivity')
        if m.get('disableNotification') is not None:
            self.disable_notification = m.get('disableNotification')
        if m.get('executorId') is not None:
            self.executor_id = m.get('executorId')
        return self


class UpdateOrganizationTaskExecutorResponseBodyResultExecutor(TeaModel):
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


class UpdateOrganizationTaskExecutorResponseBodyResultInvolvers(TeaModel):
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


class UpdateOrganizationTaskExecutorResponseBodyResult(TeaModel):
    def __init__(
        self,
        executor: UpdateOrganizationTaskExecutorResponseBodyResultExecutor = None,
        executor_id: str = None,
        involvers: List[UpdateOrganizationTaskExecutorResponseBodyResultInvolvers] = None,
        updated: str = None,
    ):
        self.executor = executor
        self.executor_id = executor_id
        self.involvers = involvers
        self.updated = updated

    def validate(self):
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
        if self.executor is not None:
            result['executor'] = self.executor.to_map()
        if self.executor_id is not None:
            result['executorId'] = self.executor_id
        result['involvers'] = []
        if self.involvers is not None:
            for k in self.involvers:
                result['involvers'].append(k.to_map() if k else None)
        if self.updated is not None:
            result['updated'] = self.updated
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('executor') is not None:
            temp_model = UpdateOrganizationTaskExecutorResponseBodyResultExecutor()
            self.executor = temp_model.from_map(m['executor'])
        if m.get('executorId') is not None:
            self.executor_id = m.get('executorId')
        self.involvers = []
        if m.get('involvers') is not None:
            for k in m.get('involvers'):
                temp_model = UpdateOrganizationTaskExecutorResponseBodyResultInvolvers()
                self.involvers.append(temp_model.from_map(k))
        if m.get('updated') is not None:
            self.updated = m.get('updated')
        return self


class UpdateOrganizationTaskExecutorResponseBody(TeaModel):
    def __init__(
        self,
        result: UpdateOrganizationTaskExecutorResponseBodyResult = None,
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
            temp_model = UpdateOrganizationTaskExecutorResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class UpdateOrganizationTaskExecutorResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateOrganizationTaskExecutorResponseBody = None,
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
            temp_model = UpdateOrganizationTaskExecutorResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateOrganizationTaskInvolveMembersHeaders(TeaModel):
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


class UpdateOrganizationTaskInvolveMembersRequest(TeaModel):
    def __init__(
        self,
        add_involvers: List[str] = None,
        del_involvers: List[str] = None,
        disable_activity: bool = None,
        disable_notification: bool = None,
        involve_members: List[str] = None,
    ):
        self.add_involvers = add_involvers
        self.del_involvers = del_involvers
        self.disable_activity = disable_activity
        self.disable_notification = disable_notification
        self.involve_members = involve_members

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.add_involvers is not None:
            result['addInvolvers'] = self.add_involvers
        if self.del_involvers is not None:
            result['delInvolvers'] = self.del_involvers
        if self.disable_activity is not None:
            result['disableActivity'] = self.disable_activity
        if self.disable_notification is not None:
            result['disableNotification'] = self.disable_notification
        if self.involve_members is not None:
            result['involveMembers'] = self.involve_members
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('addInvolvers') is not None:
            self.add_involvers = m.get('addInvolvers')
        if m.get('delInvolvers') is not None:
            self.del_involvers = m.get('delInvolvers')
        if m.get('disableActivity') is not None:
            self.disable_activity = m.get('disableActivity')
        if m.get('disableNotification') is not None:
            self.disable_notification = m.get('disableNotification')
        if m.get('involveMembers') is not None:
            self.involve_members = m.get('involveMembers')
        return self


class UpdateOrganizationTaskInvolveMembersResponseBodyResultInvolvers(TeaModel):
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


class UpdateOrganizationTaskInvolveMembersResponseBodyResult(TeaModel):
    def __init__(
        self,
        involvers: List[UpdateOrganizationTaskInvolveMembersResponseBodyResultInvolvers] = None,
        updated: str = None,
    ):
        self.involvers = involvers
        self.updated = updated

    def validate(self):
        if self.involvers:
            for k in self.involvers:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['involvers'] = []
        if self.involvers is not None:
            for k in self.involvers:
                result['involvers'].append(k.to_map() if k else None)
        if self.updated is not None:
            result['updated'] = self.updated
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.involvers = []
        if m.get('involvers') is not None:
            for k in m.get('involvers'):
                temp_model = UpdateOrganizationTaskInvolveMembersResponseBodyResultInvolvers()
                self.involvers.append(temp_model.from_map(k))
        if m.get('updated') is not None:
            self.updated = m.get('updated')
        return self


class UpdateOrganizationTaskInvolveMembersResponseBody(TeaModel):
    def __init__(
        self,
        result: UpdateOrganizationTaskInvolveMembersResponseBodyResult = None,
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
            temp_model = UpdateOrganizationTaskInvolveMembersResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class UpdateOrganizationTaskInvolveMembersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateOrganizationTaskInvolveMembersResponseBody = None,
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
            temp_model = UpdateOrganizationTaskInvolveMembersResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateOrganizationTaskNoteHeaders(TeaModel):
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


class UpdateOrganizationTaskNoteRequest(TeaModel):
    def __init__(
        self,
        disable_activity: bool = None,
        disable_notification: bool = None,
        note: str = None,
    ):
        self.disable_activity = disable_activity
        self.disable_notification = disable_notification
        # This parameter is required.
        self.note = note

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.disable_activity is not None:
            result['disableActivity'] = self.disable_activity
        if self.disable_notification is not None:
            result['disableNotification'] = self.disable_notification
        if self.note is not None:
            result['note'] = self.note
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('disableActivity') is not None:
            self.disable_activity = m.get('disableActivity')
        if m.get('disableNotification') is not None:
            self.disable_notification = m.get('disableNotification')
        if m.get('note') is not None:
            self.note = m.get('note')
        return self


class UpdateOrganizationTaskNoteResponseBodyResult(TeaModel):
    def __init__(
        self,
        note: str = None,
        updated: str = None,
    ):
        self.note = note
        self.updated = updated

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.note is not None:
            result['note'] = self.note
        if self.updated is not None:
            result['updated'] = self.updated
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('note') is not None:
            self.note = m.get('note')
        if m.get('updated') is not None:
            self.updated = m.get('updated')
        return self


class UpdateOrganizationTaskNoteResponseBody(TeaModel):
    def __init__(
        self,
        result: UpdateOrganizationTaskNoteResponseBodyResult = None,
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
            temp_model = UpdateOrganizationTaskNoteResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class UpdateOrganizationTaskNoteResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateOrganizationTaskNoteResponseBody = None,
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
            temp_model = UpdateOrganizationTaskNoteResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateOrganizationTaskPriorityHeaders(TeaModel):
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


class UpdateOrganizationTaskPriorityRequest(TeaModel):
    def __init__(
        self,
        disable_activity: bool = None,
        disable_notification: bool = None,
        priority: int = None,
    ):
        self.disable_activity = disable_activity
        self.disable_notification = disable_notification
        # This parameter is required.
        self.priority = priority

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.disable_activity is not None:
            result['disableActivity'] = self.disable_activity
        if self.disable_notification is not None:
            result['disableNotification'] = self.disable_notification
        if self.priority is not None:
            result['priority'] = self.priority
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('disableActivity') is not None:
            self.disable_activity = m.get('disableActivity')
        if m.get('disableNotification') is not None:
            self.disable_notification = m.get('disableNotification')
        if m.get('priority') is not None:
            self.priority = m.get('priority')
        return self


class UpdateOrganizationTaskPriorityResponseBodyResult(TeaModel):
    def __init__(
        self,
        priority: int = None,
        updated: str = None,
    ):
        self.priority = priority
        self.updated = updated

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.priority is not None:
            result['priority'] = self.priority
        if self.updated is not None:
            result['updated'] = self.updated
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('priority') is not None:
            self.priority = m.get('priority')
        if m.get('updated') is not None:
            self.updated = m.get('updated')
        return self


class UpdateOrganizationTaskPriorityResponseBody(TeaModel):
    def __init__(
        self,
        result: UpdateOrganizationTaskPriorityResponseBodyResult = None,
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
            temp_model = UpdateOrganizationTaskPriorityResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class UpdateOrganizationTaskPriorityResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateOrganizationTaskPriorityResponseBody = None,
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
            temp_model = UpdateOrganizationTaskPriorityResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateOrganizationTaskStatusHeaders(TeaModel):
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


class UpdateOrganizationTaskStatusRequest(TeaModel):
    def __init__(
        self,
        disable_activity: bool = None,
        disable_notification: bool = None,
        is_done: bool = None,
    ):
        self.disable_activity = disable_activity
        self.disable_notification = disable_notification
        # This parameter is required.
        self.is_done = is_done

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.disable_activity is not None:
            result['disableActivity'] = self.disable_activity
        if self.disable_notification is not None:
            result['disableNotification'] = self.disable_notification
        if self.is_done is not None:
            result['isDone'] = self.is_done
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('disableActivity') is not None:
            self.disable_activity = m.get('disableActivity')
        if m.get('disableNotification') is not None:
            self.disable_notification = m.get('disableNotification')
        if m.get('isDone') is not None:
            self.is_done = m.get('isDone')
        return self


class UpdateOrganizationTaskStatusResponseBodyResult(TeaModel):
    def __init__(
        self,
        is_done: bool = None,
        update_time: str = None,
    ):
        self.is_done = is_done
        self.update_time = update_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.is_done is not None:
            result['isDone'] = self.is_done
        if self.update_time is not None:
            result['updateTime'] = self.update_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isDone') is not None:
            self.is_done = m.get('isDone')
        if m.get('updateTime') is not None:
            self.update_time = m.get('updateTime')
        return self


class UpdateOrganizationTaskStatusResponseBody(TeaModel):
    def __init__(
        self,
        result: UpdateOrganizationTaskStatusResponseBodyResult = None,
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
            temp_model = UpdateOrganizationTaskStatusResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class UpdateOrganizationTaskStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateOrganizationTaskStatusResponseBody = None,
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
            temp_model = UpdateOrganizationTaskStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateProjectGroupHeaders(TeaModel):
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


class UpdateProjectGroupRequest(TeaModel):
    def __init__(
        self,
        add_project_group_ids: List[str] = None,
        del_project_group_ids: List[str] = None,
    ):
        self.add_project_group_ids = add_project_group_ids
        self.del_project_group_ids = del_project_group_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.add_project_group_ids is not None:
            result['addProjectGroupIds'] = self.add_project_group_ids
        if self.del_project_group_ids is not None:
            result['delProjectGroupIds'] = self.del_project_group_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('addProjectGroupIds') is not None:
            self.add_project_group_ids = m.get('addProjectGroupIds')
        if m.get('delProjectGroupIds') is not None:
            self.del_project_group_ids = m.get('delProjectGroupIds')
        return self


class UpdateProjectGroupResponseBodyResult(TeaModel):
    def __init__(
        self,
        ok: bool = None,
    ):
        self.ok = ok

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ok is not None:
            result['ok'] = self.ok
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('ok') is not None:
            self.ok = m.get('ok')
        return self


class UpdateProjectGroupResponseBody(TeaModel):
    def __init__(
        self,
        result: UpdateProjectGroupResponseBodyResult = None,
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
            temp_model = UpdateProjectGroupResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class UpdateProjectGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateProjectGroupResponseBody = None,
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
            temp_model = UpdateProjectGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateTaskContentHeaders(TeaModel):
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


class UpdateTaskContentRequest(TeaModel):
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


class UpdateTaskContentResponseBodyResult(TeaModel):
    def __init__(
        self,
        content: str = None,
        updated: str = None,
    ):
        self.content = content
        self.updated = updated

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.updated is not None:
            result['updated'] = self.updated
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('updated') is not None:
            self.updated = m.get('updated')
        return self


class UpdateTaskContentResponseBody(TeaModel):
    def __init__(
        self,
        result: UpdateTaskContentResponseBodyResult = None,
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
            temp_model = UpdateTaskContentResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class UpdateTaskContentResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateTaskContentResponseBody = None,
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
            temp_model = UpdateTaskContentResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateTaskDueDateHeaders(TeaModel):
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


class UpdateTaskDueDateRequest(TeaModel):
    def __init__(
        self,
        due_date: str = None,
    ):
        self.due_date = due_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.due_date is not None:
            result['dueDate'] = self.due_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dueDate') is not None:
            self.due_date = m.get('dueDate')
        return self


class UpdateTaskDueDateResponseBodyResult(TeaModel):
    def __init__(
        self,
        due_date: str = None,
        updated: str = None,
    ):
        self.due_date = due_date
        self.updated = updated

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.due_date is not None:
            result['dueDate'] = self.due_date
        if self.updated is not None:
            result['updated'] = self.updated
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dueDate') is not None:
            self.due_date = m.get('dueDate')
        if m.get('updated') is not None:
            self.updated = m.get('updated')
        return self


class UpdateTaskDueDateResponseBody(TeaModel):
    def __init__(
        self,
        result: UpdateTaskDueDateResponseBodyResult = None,
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
            temp_model = UpdateTaskDueDateResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class UpdateTaskDueDateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateTaskDueDateResponseBody = None,
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
            temp_model = UpdateTaskDueDateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateTaskExecutorHeaders(TeaModel):
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


class UpdateTaskExecutorRequest(TeaModel):
    def __init__(
        self,
        executor_id: str = None,
    ):
        self.executor_id = executor_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.executor_id is not None:
            result['executorId'] = self.executor_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('executorId') is not None:
            self.executor_id = m.get('executorId')
        return self


class UpdateTaskExecutorResponseBodyResult(TeaModel):
    def __init__(
        self,
        executor_id: str = None,
        updated: str = None,
    ):
        self.executor_id = executor_id
        self.updated = updated

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.executor_id is not None:
            result['executorId'] = self.executor_id
        if self.updated is not None:
            result['updated'] = self.updated
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('executorId') is not None:
            self.executor_id = m.get('executorId')
        if m.get('updated') is not None:
            self.updated = m.get('updated')
        return self


class UpdateTaskExecutorResponseBody(TeaModel):
    def __init__(
        self,
        result: UpdateTaskExecutorResponseBodyResult = None,
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
            temp_model = UpdateTaskExecutorResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class UpdateTaskExecutorResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateTaskExecutorResponseBody = None,
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
            temp_model = UpdateTaskExecutorResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateTaskInvolvemembersHeaders(TeaModel):
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


class UpdateTaskInvolvemembersRequest(TeaModel):
    def __init__(
        self,
        add_involvers: List[str] = None,
        del_involvers: List[str] = None,
        involve_members: List[str] = None,
    ):
        self.add_involvers = add_involvers
        self.del_involvers = del_involvers
        self.involve_members = involve_members

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.add_involvers is not None:
            result['addInvolvers'] = self.add_involvers
        if self.del_involvers is not None:
            result['delInvolvers'] = self.del_involvers
        if self.involve_members is not None:
            result['involveMembers'] = self.involve_members
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('addInvolvers') is not None:
            self.add_involvers = m.get('addInvolvers')
        if m.get('delInvolvers') is not None:
            self.del_involvers = m.get('delInvolvers')
        if m.get('involveMembers') is not None:
            self.involve_members = m.get('involveMembers')
        return self


class UpdateTaskInvolvemembersResponseBodyResult(TeaModel):
    def __init__(
        self,
        involve_members: List[str] = None,
        updated: str = None,
    ):
        self.involve_members = involve_members
        self.updated = updated

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.involve_members is not None:
            result['involveMembers'] = self.involve_members
        if self.updated is not None:
            result['updated'] = self.updated
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('involveMembers') is not None:
            self.involve_members = m.get('involveMembers')
        if m.get('updated') is not None:
            self.updated = m.get('updated')
        return self


class UpdateTaskInvolvemembersResponseBody(TeaModel):
    def __init__(
        self,
        result: UpdateTaskInvolvemembersResponseBodyResult = None,
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
            temp_model = UpdateTaskInvolvemembersResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class UpdateTaskInvolvemembersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateTaskInvolvemembersResponseBody = None,
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
            temp_model = UpdateTaskInvolvemembersResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateTaskNoteHeaders(TeaModel):
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


class UpdateTaskNoteRequest(TeaModel):
    def __init__(
        self,
        note: str = None,
    ):
        self.note = note

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.note is not None:
            result['note'] = self.note
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('note') is not None:
            self.note = m.get('note')
        return self


class UpdateTaskNoteResponseBodyResult(TeaModel):
    def __init__(
        self,
        note: str = None,
        updated: str = None,
    ):
        self.note = note
        self.updated = updated

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.note is not None:
            result['note'] = self.note
        if self.updated is not None:
            result['updated'] = self.updated
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('note') is not None:
            self.note = m.get('note')
        if m.get('updated') is not None:
            self.updated = m.get('updated')
        return self


class UpdateTaskNoteResponseBody(TeaModel):
    def __init__(
        self,
        result: UpdateTaskNoteResponseBodyResult = None,
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
            temp_model = UpdateTaskNoteResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class UpdateTaskNoteResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateTaskNoteResponseBody = None,
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
            temp_model = UpdateTaskNoteResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateTaskPriorityHeaders(TeaModel):
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


class UpdateTaskPriorityRequest(TeaModel):
    def __init__(
        self,
        priority: int = None,
    ):
        self.priority = priority

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.priority is not None:
            result['priority'] = self.priority
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('priority') is not None:
            self.priority = m.get('priority')
        return self


class UpdateTaskPriorityResponseBodyResult(TeaModel):
    def __init__(
        self,
        priority: int = None,
        updated: str = None,
    ):
        self.priority = priority
        self.updated = updated

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.priority is not None:
            result['priority'] = self.priority
        if self.updated is not None:
            result['updated'] = self.updated
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('priority') is not None:
            self.priority = m.get('priority')
        if m.get('updated') is not None:
            self.updated = m.get('updated')
        return self


class UpdateTaskPriorityResponseBody(TeaModel):
    def __init__(
        self,
        result: UpdateTaskPriorityResponseBodyResult = None,
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
            temp_model = UpdateTaskPriorityResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class UpdateTaskPriorityResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateTaskPriorityResponseBody = None,
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
            temp_model = UpdateTaskPriorityResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateTaskStageHeaders(TeaModel):
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


class UpdateTaskStageRequest(TeaModel):
    def __init__(
        self,
        task_stage_id: str = None,
    ):
        self.task_stage_id = task_stage_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.task_stage_id is not None:
            result['taskStageId'] = self.task_stage_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('taskStageId') is not None:
            self.task_stage_id = m.get('taskStageId')
        return self


class UpdateTaskStageResponseBodyResult(TeaModel):
    def __init__(
        self,
        accomplish_time: str = None,
        is_done: bool = None,
        project_id: str = None,
        task_id: str = None,
        task_list_id: str = None,
        task_stage_id: str = None,
        updated: str = None,
    ):
        self.accomplish_time = accomplish_time
        self.is_done = is_done
        self.project_id = project_id
        self.task_id = task_id
        self.task_list_id = task_list_id
        self.task_stage_id = task_stage_id
        self.updated = updated

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.accomplish_time is not None:
            result['accomplishTime'] = self.accomplish_time
        if self.is_done is not None:
            result['isDone'] = self.is_done
        if self.project_id is not None:
            result['projectId'] = self.project_id
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.task_list_id is not None:
            result['taskListId'] = self.task_list_id
        if self.task_stage_id is not None:
            result['taskStageId'] = self.task_stage_id
        if self.updated is not None:
            result['updated'] = self.updated
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accomplishTime') is not None:
            self.accomplish_time = m.get('accomplishTime')
        if m.get('isDone') is not None:
            self.is_done = m.get('isDone')
        if m.get('projectId') is not None:
            self.project_id = m.get('projectId')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('taskListId') is not None:
            self.task_list_id = m.get('taskListId')
        if m.get('taskStageId') is not None:
            self.task_stage_id = m.get('taskStageId')
        if m.get('updated') is not None:
            self.updated = m.get('updated')
        return self


class UpdateTaskStageResponseBody(TeaModel):
    def __init__(
        self,
        result: UpdateTaskStageResponseBodyResult = None,
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
            temp_model = UpdateTaskStageResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class UpdateTaskStageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateTaskStageResponseBody = None,
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
            temp_model = UpdateTaskStageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateTaskStartdateHeaders(TeaModel):
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


class UpdateTaskStartdateRequest(TeaModel):
    def __init__(
        self,
        start_date: str = None,
    ):
        self.start_date = start_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.start_date is not None:
            result['startDate'] = self.start_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        return self


class UpdateTaskStartdateResponseBodyResult(TeaModel):
    def __init__(
        self,
        start_date: str = None,
        updated: str = None,
    ):
        self.start_date = start_date
        self.updated = updated

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.start_date is not None:
            result['startDate'] = self.start_date
        if self.updated is not None:
            result['updated'] = self.updated
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        if m.get('updated') is not None:
            self.updated = m.get('updated')
        return self


class UpdateTaskStartdateResponseBody(TeaModel):
    def __init__(
        self,
        result: UpdateTaskStartdateResponseBodyResult = None,
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
            temp_model = UpdateTaskStartdateResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class UpdateTaskStartdateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateTaskStartdateResponseBody = None,
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
            temp_model = UpdateTaskStartdateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateTaskTaskflowstatusHeaders(TeaModel):
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


class UpdateTaskTaskflowstatusRequest(TeaModel):
    def __init__(
        self,
        taskflow_status_id: str = None,
        taskflow_status_update_note: str = None,
    ):
        self.taskflow_status_id = taskflow_status_id
        self.taskflow_status_update_note = taskflow_status_update_note

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.taskflow_status_id is not None:
            result['taskflowStatusId'] = self.taskflow_status_id
        if self.taskflow_status_update_note is not None:
            result['taskflowStatusUpdateNote'] = self.taskflow_status_update_note
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('taskflowStatusId') is not None:
            self.taskflow_status_id = m.get('taskflowStatusId')
        if m.get('taskflowStatusUpdateNote') is not None:
            self.taskflow_status_update_note = m.get('taskflowStatusUpdateNote')
        return self


class UpdateTaskTaskflowstatusResponseBodyResult(TeaModel):
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


class UpdateTaskTaskflowstatusResponseBody(TeaModel):
    def __init__(
        self,
        result: UpdateTaskTaskflowstatusResponseBodyResult = None,
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
            temp_model = UpdateTaskTaskflowstatusResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class UpdateTaskTaskflowstatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateTaskTaskflowstatusResponseBody = None,
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
            temp_model = UpdateTaskTaskflowstatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateWorkTimeApproveHeaders(TeaModel):
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


class UpdateWorkTimeApproveRequest(TeaModel):
    def __init__(
        self,
        finish_time: str = None,
        instance_id: str = None,
        status: str = None,
        submit_time: str = None,
        title: str = None,
        url: str = None,
    ):
        self.finish_time = finish_time
        self.instance_id = instance_id
        self.status = status
        self.submit_time = submit_time
        self.title = title
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.finish_time is not None:
            result['finishTime'] = self.finish_time
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.status is not None:
            result['status'] = self.status
        if self.submit_time is not None:
            result['submitTime'] = self.submit_time
        if self.title is not None:
            result['title'] = self.title
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('finishTime') is not None:
            self.finish_time = m.get('finishTime')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('submitTime') is not None:
            self.submit_time = m.get('submitTime')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class UpdateWorkTimeApproveResponseBodyResult(TeaModel):
    def __init__(
        self,
        approve_open_id: str = None,
        created_at: str = None,
        creator_id: str = None,
        finish_time: str = None,
        instance_id: str = None,
        organization_id: str = None,
        status: str = None,
        submit_time: str = None,
        task_id: str = None,
        time: int = None,
        title: str = None,
        updated_at: str = None,
        url: str = None,
        user_id: str = None,
        work_time_ids: List[str] = None,
    ):
        self.approve_open_id = approve_open_id
        self.created_at = created_at
        self.creator_id = creator_id
        self.finish_time = finish_time
        self.instance_id = instance_id
        self.organization_id = organization_id
        self.status = status
        self.submit_time = submit_time
        self.task_id = task_id
        self.time = time
        self.title = title
        self.updated_at = updated_at
        self.url = url
        self.user_id = user_id
        self.work_time_ids = work_time_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.approve_open_id is not None:
            result['approveOpenId'] = self.approve_open_id
        if self.created_at is not None:
            result['createdAt'] = self.created_at
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.finish_time is not None:
            result['finishTime'] = self.finish_time
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.organization_id is not None:
            result['organizationId'] = self.organization_id
        if self.status is not None:
            result['status'] = self.status
        if self.submit_time is not None:
            result['submitTime'] = self.submit_time
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.time is not None:
            result['time'] = self.time
        if self.title is not None:
            result['title'] = self.title
        if self.updated_at is not None:
            result['updatedAt'] = self.updated_at
        if self.url is not None:
            result['url'] = self.url
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.work_time_ids is not None:
            result['workTimeIds'] = self.work_time_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('approveOpenId') is not None:
            self.approve_open_id = m.get('approveOpenId')
        if m.get('createdAt') is not None:
            self.created_at = m.get('createdAt')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('finishTime') is not None:
            self.finish_time = m.get('finishTime')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('organizationId') is not None:
            self.organization_id = m.get('organizationId')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('submitTime') is not None:
            self.submit_time = m.get('submitTime')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('time') is not None:
            self.time = m.get('time')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('updatedAt') is not None:
            self.updated_at = m.get('updatedAt')
        if m.get('url') is not None:
            self.url = m.get('url')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('workTimeIds') is not None:
            self.work_time_ids = m.get('workTimeIds')
        return self


class UpdateWorkTimeApproveResponseBody(TeaModel):
    def __init__(
        self,
        message: str = None,
        request_id: str = None,
        result: UpdateWorkTimeApproveResponseBodyResult = None,
    ):
        self.message = message
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
        if self.message is not None:
            result['message'] = self.message
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('message') is not None:
            self.message = m.get('message')
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            temp_model = UpdateWorkTimeApproveResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class UpdateWorkTimeApproveResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateWorkTimeApproveResponseBody = None,
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
            temp_model = UpdateWorkTimeApproveResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


