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
        # 用户ID列表，建议一次不超过10个
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
        body: AddProjectMemberResponseBody = None,
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
        # 是否已放入回收站。
        self.is_archived = is_archived
        # 更新时间。
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
        body: ArchiveProjectResponseBody = None,
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
        # 更新时间。
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
        # 结果
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
        body: ArchiveTaskResponseBody = None,
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
        # 任务标题
        self.content = content
        # 任务创建日期
        self.create_time = create_time
        # 是否禁止动态
        self.disable_activity = disable_activity
        # 是否禁止通知
        self.disable_notification = disable_notification
        # 任务截止日期
        self.due_date = due_date
        # 执行者id
        self.executor_id = executor_id
        # 参与者id
        self.involve_members = involve_members
        # 任务备注
        self.note = note
        # 优先级【-10,0,1,2】中选一个
        self.priority = priority
        # 任务可见性。involves：仅参与者可见。members:所有人可见
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
        # 创建者头像地址
        self.avatar_url = avatar_url
        # 创建者姓名
        self.name = name
        # 创建者id
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
        # 头像地址
        self.avatar_url = avatar_url
        # 姓名
        self.name = name
        # 执行者id
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
        # 头像
        self.avatar_url = avatar_url
        # 用户id
        self.id = id
        # 名字
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
        # 父任务Id
        self.ancestor_ids = ancestor_ids
        # 附件数量
        self.attachments_count = attachments_count
        # 任务标题
        self.content = content
        # 创建时间
        self.created = created
        # 创建者
        self.creator = creator
        # 创建者id
        self.creator_id = creator_id
        # 任务截止日期
        self.due_date = due_date
        # 执行者
        self.executor = executor
        # 执行者id
        self.executor_id = executor_id
        # 是否有提醒
        self.has_reminder = has_reminder
        # 任务id
        self.id = id
        # 参与者id列表
        self.involve_members = involve_members
        # 参与者列表
        self.involvers = involvers
        # 是否删除
        self.is_deleted = is_deleted
        # 是否完成
        self.is_done = is_done
        # 任务备注
        self.note = note
        # 优先级【-10,0,1,2】中选一个
        self.priority = priority
        # 更新时间
        self.updated = updated
        # 任务可见性。involves：仅参与者可见。members:所有人可见
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
        # 返回结果对象
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
        body: CreateOrganizationTaskResponseBody = None,
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
        # 结束时间
        self.end_date = end_date
        # 执行者userid
        self.executor_id = executor_id
        # 是否包含假期
        self.includes_holidays = includes_holidays
        # 是否连续
        self.is_duration = is_duration
        # 对象id，比如任务id
        self.object_id = object_id
        # 对象类型，默认为task
        self.object_type = object_type
        # 计划工时数（单位：毫秒，1小时即为 3600000）
        self.plan_time = plan_time
        # 开始时间
        self.start_date = start_date
        # 工时所属人员userid
        self.submitter_id = submitter_id
        # 接口校验类型，当前默认organization
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
        # 更新工时所属日期
        self.date = date
        # 工时关联的数据id
        self.object_id = object_id
        # 计划工时数
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
        # 执行结果描述
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
        body: CreatePlanTimeResponseBody = None,
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
        # 项目名称。
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


class CreateProjectResponseBodyResultCustomfieldsValue(TeaModel):
    def __init__(
        self,
        fieldvalue_id: str = None,
        meta_string: str = None,
        title: str = None,
    ):
        # 自定义字段值ID。
        self.fieldvalue_id = fieldvalue_id
        # 自定义字段值元属性。
        self.meta_string = meta_string
        # 自定义字段值内容。
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.fieldvalue_id is not None:
            result['fieldvalueId'] = self.fieldvalue_id
        if self.meta_string is not None:
            result['metaString'] = self.meta_string
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldvalueId') is not None:
            self.fieldvalue_id = m.get('fieldvalueId')
        if m.get('metaString') is not None:
            self.meta_string = m.get('metaString')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class CreateProjectResponseBodyResultCustomfields(TeaModel):
    def __init__(
        self,
        customfield_id: str = None,
        type: str = None,
        value: List[CreateProjectResponseBodyResultCustomfieldsValue] = None,
    ):
        # 自定义字段ID。
        self.customfield_id = customfield_id
        # 自定义字段类型。
        self.type = type
        # 自定义字段值列表。
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
                temp_model = CreateProjectResponseBodyResultCustomfieldsValue()
                self.value.append(temp_model.from_map(k))
        return self


class CreateProjectResponseBodyResult(TeaModel):
    def __init__(
        self,
        created: str = None,
        creator_id: str = None,
        customfields: List[CreateProjectResponseBodyResultCustomfields] = None,
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
        # 创建时间。
        self.created = created
        # 创建人ID。
        self.creator_id = creator_id
        # 自定义字段值集合。
        self.customfields = customfields
        # 项目默认文件夹ID。
        self.default_collection_id = default_collection_id
        # 是否在回收站。
        self.is_archived = is_archived
        # 是否归档。
        self.is_suspended = is_suspended
        # 是否为模版项目。
        self.is_template = is_template
        # 项目封面。
        self.logo = logo
        # 项目名称。
        self.name = name
        # 项目类型。
        self.normal_type = normal_type
        # 项目ID。
        self.project_id = project_id
        # 项目根文件夹ID。
        self.root_collection_id = root_collection_id
        # 来源项目ID。
        self.source_id = source_id
        # 任务ID前缀。
        self.unique_id_prefix = unique_id_prefix
        # 更新时间。
        self.updated = updated
        # 项目可见性。
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
        self.customfields = []
        if m.get('customfields') is not None:
            for k in m.get('customfields'):
                temp_model = CreateProjectResponseBodyResultCustomfields()
                self.customfields.append(temp_model.from_map(k))
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
        # 返回结果。
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
        body: CreateProjectResponseBody = None,
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
        # 项目名字
        self.name = name
        # 模板ID
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
        # 创建时间
        self.created = created
        # 项目ID
        self.id = id
        # 项目图标地址
        self.logo = logo
        # 项目名字
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
        # 返回结果对象
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
        body: CreateProjectByTemplateResponseBody = None,
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
        fieldvalue_id: str = None,
        meta_string: str = None,
        title: str = None,
    ):
        # 字段值id。
        self.fieldvalue_id = fieldvalue_id
        # 字段值元信息(json格式)。
        self.meta_string = meta_string
        # 字段值渲染值。
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.fieldvalue_id is not None:
            result['fieldvalueId'] = self.fieldvalue_id
        if self.meta_string is not None:
            result['metaString'] = self.meta_string
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldvalueId') is not None:
            self.fieldvalue_id = m.get('fieldvalueId')
        if m.get('metaString') is not None:
            self.meta_string = m.get('metaString')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class CreateProjectCustomfieldStatusRequest(TeaModel):
    def __init__(
        self,
        customfield_id: str = None,
        customfield_instance_id: str = None,
        customfield_name: str = None,
        value: List[CreateProjectCustomfieldStatusRequestValue] = None,
    ):
        # 自定义字段ID。
        self.customfield_id = customfield_id
        # 自定义字段InstanceId(如果提供自定义字段ID 或者 自定义字段名称 则忽略)。
        self.customfield_instance_id = customfield_instance_id
        # 自定义字段名称(如果提供自定义字段ID 则忽略)。
        self.customfield_name = customfield_name
        # 字段值集合。
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
        if self.customfield_instance_id is not None:
            result['customfieldInstanceId'] = self.customfield_instance_id
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
        if m.get('customfieldInstanceId') is not None:
            self.customfield_instance_id = m.get('customfieldInstanceId')
        if m.get('customfieldName') is not None:
            self.customfield_name = m.get('customfieldName')
        self.value = []
        if m.get('value') is not None:
            for k in m.get('value'):
                temp_model = CreateProjectCustomfieldStatusRequestValue()
                self.value.append(temp_model.from_map(k))
        return self


class CreateProjectCustomfieldStatusResponseBodyResultValue(TeaModel):
    def __init__(
        self,
        fieldvalue_id: str = None,
        meta_string: str = None,
        title: str = None,
    ):
        # 字段值id。
        self.fieldvalue_id = fieldvalue_id
        # 自定义字段值元属性。
        self.meta_string = meta_string
        # 自定义字段值。
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.fieldvalue_id is not None:
            result['fieldvalueId'] = self.fieldvalue_id
        if self.meta_string is not None:
            result['metaString'] = self.meta_string
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldvalueId') is not None:
            self.fieldvalue_id = m.get('fieldvalueId')
        if m.get('metaString') is not None:
            self.meta_string = m.get('metaString')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class CreateProjectCustomfieldStatusResponseBodyResult(TeaModel):
    def __init__(
        self,
        adv_cf_object_type: str = None,
        customfield_id: str = None,
        name: str = None,
        original_id: str = None,
        type: str = None,
        value: List[CreateProjectCustomfieldStatusResponseBodyResultValue] = None,
    ):
        # 高级字段类型名(冗余)。
        self.adv_cf_object_type = adv_cf_object_type
        # 自定义字段ID。
        self.customfield_id = customfield_id
        # 字段名称。
        self.name = name
        # 如果是企业字段，返回企业字段ID。
        self.original_id = original_id
        # 字段类型。
        self.type = type
        # 字段值集合。
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
        if self.adv_cf_object_type is not None:
            result['advCfObjectType'] = self.adv_cf_object_type
        if self.customfield_id is not None:
            result['customfieldId'] = self.customfield_id
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
        if m.get('advCfObjectType') is not None:
            self.adv_cf_object_type = m.get('advCfObjectType')
        if m.get('customfieldId') is not None:
            self.customfield_id = m.get('customfieldId')
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
        # 结果。
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
        body: CreateProjectCustomfieldStatusResponseBody = None,
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
        title: str = None,
    ):
        # 自定义字段显示值
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


class CreateTaskRequestCustomfields(TeaModel):
    def __init__(
        self,
        customfield_id: str = None,
        customfield_name: str = None,
        value: List[CreateTaskRequestCustomfieldsValue] = None,
    ):
        # 自定义字段id
        self.customfield_id = customfield_id
        # 自定义字段名称
        self.customfield_name = customfield_name
        # 自定义字段值
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
        # 任务标题
        self.content = content
        # 自定义字段列表
        self.customfields = customfields
        # 任务截止时间
        self.due_date = due_date
        # 执行者userId
        self.executor_id = executor_id
        # 任务备注
        self.note = note
        # 父任务id。
        self.parent_task_id = parent_task_id
        # 任务优先级
        self.priority = priority
        # 项目id
        self.project_id = project_id
        # 任务类型id，任务类型比如：缺陷、需求。。
        self.scenariofieldconfig_id = scenariofieldconfig_id
        # 任务列id。
        self.stage_id = stage_id
        # 任务开始时间。
        self.start_date = start_date
        # 任务可见性,members,involves。
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
        # 自定义字段显示值
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
        # 自定义字段id
        self.customfield_id = customfield_id
        # 自定义字段值
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
        # 任务标题
        self.content = content
        # 创建时间
        self.created = created
        # 任务创建者userId
        self.creator_id = creator_id
        # 自定义字段列表
        self.customfields = customfields
        # 任务截止时间
        self.due_date = due_date
        # 任务执行者userId
        self.executor_id = executor_id
        # 任务参与者列表
        self.involve_members = involve_members
        # 任务备注
        self.note = note
        # 任务优先级
        self.priority = priority
        # 项目id
        self.project_id = project_id
        # 任务id
        self.task_id = task_id
        # 更新时间
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
        # 返回结果对象
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
        body: CreateTaskResponseBody = None,
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
        # 关联对象描述
        self.content = content
        # 关联对象头像url
        self.thumbnail_url = thumbnail_url
        # 关联对象标题
        self.title = title
        # 关联对象链接url
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
        # 关联链接对象
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
        # 创建时间
        self.created = created
        # 关联对象id
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
        # 返回结果对象
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
        body: CreateTaskObjectLinkResponseBody = None,
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
        # 结束时间
        self.end_date = end_date
        # 执行者userid
        self.executor_id = executor_id
        # 是否包含节假日
        self.includes_holidays = includes_holidays
        # 是否连续
        self.is_duration = is_duration
        # 对象 ID，比如 任务 ID
        self.object_id = object_id
        # 对象类型，默认为 task
        self.object_type = object_type
        # 开始时间
        self.start_date = start_date
        # 工时所属人员userid
        self.submitter_id = submitter_id
        # 实际工时数（单位毫秒，1小时即为3600000）
        self.work_time = work_time
        # 接口校验类型，当前默认organization
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
        # 工时所属日期
        self.date = date
        # 工时关联的数据 ID
        self.task_id = task_id
        # 实际工时
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
        # 执行结果描述
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
        body: CreateWorkTimeResponseBody = None,
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
            temp_model = CreateWorkTimeResponseBody()
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
        # 用户ID。
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
        # 项目成员列表。
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
        body: DeleteProjectMemberResponseBody = None,
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
        # 删除的任务Id
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
        body: DeleteTaskResponseBody = None,
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
        # id
        self.dept_id = dept_id
        # name
        self.name = name
        # parentId
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
        # deptList
        self.dept_list = dept_list
        # hasMore
        self.has_more = has_more
        self.max_results = max_results
        # nextCursor
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
        body: GetDeptsByOrgIdResponseBody = None,
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
            temp_model = GetDeptsByOrgIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetEmpsByOrgIdHeaders(TeaModel):
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
        # avatar
        self.avatar = avatar
        # deptIdList
        self.dept_id_list = dept_id_list
        # dingId
        self.ding_id = ding_id
        # name
        self.name = name
        # nick
        self.nick = nick
        # orgId
        self.org_id = org_id
        self.position = position
        # unionId
        self.unionid = unionid
        # userid
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
        # empList
        self.emp_list = emp_list
        # hasMore
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
        body: GetEmpsByOrgIdResponseBody = None,
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
        # 多个任务id
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
        # 父任务id
        self.ancestor_ids = ancestor_ids
        # 任务标题
        self.content = content
        # 创建时间
        self.created = created
        # 创建者id
        self.creator_id = creator_id
        # 任务截止时间
        self.due_date = due_date
        # 执行者id
        self.executor_id = executor_id
        # 参与者列表
        self.involve_members = involve_members
        # 任务是否已删除
        self.is_deleted = is_deleted
        # 任务是否已完成
        self.is_done = is_done
        # 任务自定义标记
        self.labels = labels
        # 任务备注
        self.note = note
        # 优先级【-10,0,1,2】中选一个
        self.priority = priority
        # 任务开始时间
        self.start_date = start_date
        # 任务id
        self.task_id = task_id
        # 更新时间
        self.updated = updated
        # 任务可见性。involves：仅参与者可见。members:所有人可见
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
        # 返回结构体
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
        body: GetOrganizatioTaskByIdsResponseBody = None,
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
        # 颜色
        self.color = color
        # 名称
        self.name = name
        # 优先级值
        self.priority = priority
        # id
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
        # 优先级列表
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
        body: GetOrganizationPriorityListResponseBody = None,
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
        # 父任务id
        self.ancestor_ids = ancestor_ids
        # 任务标题
        self.content = content
        # 创建时间
        self.created = created
        # 创建者id
        self.creator_id = creator_id
        # 任务截止时间
        self.due_date = due_date
        # 执行者id
        self.executor_id = executor_id
        # 参与者列表
        self.involve_members = involve_members
        # 任务是否已删除
        self.is_deleted = is_deleted
        # 任务是否已完成
        self.is_done = is_done
        # 任务自定义标记
        self.labels = labels
        # 任务备注
        self.note = note
        # 优先级【-10,0,1,2】中选一个
        self.priority = priority
        # 任务开始时间
        self.start_date = start_date
        # 任务id
        self.task_id = task_id
        # 更新时间
        self.updated = updated
        # 任务可见性。involves：仅参与者可见。members:所有人可见
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
        # 返回结构体
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
        body: GetOrganizationTaskResponseBody = None,
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
        # 分页大小，最小1，默认10，最大1000
        self.page_size = page_size
        # 查看者ID
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
        # 创建时间
        self.created = created
        # 分组ID
        self.id = id
        # 分组名字
        self.name = name
        # 更新时间
        self.updated = updated
        # 分组可见性。organization 或者 involves
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
        # 返回结果对象
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
        body: GetProjectGroupResponseBody = None,
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
        # 每页返回最大数量。默认10，最大300。
        self.max_results = max_results
        # 项目角色ID，仅查询拥有该角色的成员，并且仅支持单个角色查询。
        self.project_role_id = project_role_id
        # 跳过的数据数量。
        self.skip = skip
        # 如果传递，仅查询这些用户ID， 用逗号组合。
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
        # 项目成员ID。
        self.member_id = member_id
        # 项目角色，0=成员；1=管理员；2=拥有者。
        self.role = role
        # 项目角色ID列表。
        self.role_ids = role_ids
        # 用户ID。
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
        # 项目成员列表。
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
        body: GetProjectMemebersResponseBody = None,
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
        # 项目状态内容。
        self.content = content
        # 创建时间。
        self.created = created
        # 项目状态创建人ID。
        self.creator_id = creator_id
        # 项目状态指标：'normal','risky','urgent'。
        self.degree = degree
        # 项目状态名称。
        self.name = name
        # 项目ID。
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
        # 项目状态历史列表。
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
        body: GetProjectStatusListResponseBody = None,
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
        # 父任务ID,和taskIds冲突(选其一)。
        self.parent_task_id = parent_task_id
        # 任务ID集合,使用逗号分隔,和parentTaskId冲突(选其一)。
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


class GetTaskByIdsResponseBodyResultCustomfieldsValue(TeaModel):
    def __init__(
        self,
        fieldvalue_id: str = None,
        meta_string: str = None,
        title: str = None,
    ):
        # 字段值ID。
        self.fieldvalue_id = fieldvalue_id
        # 字段值元属性。
        self.meta_string = meta_string
        # 字段值内容。
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.fieldvalue_id is not None:
            result['fieldvalueId'] = self.fieldvalue_id
        if self.meta_string is not None:
            result['metaString'] = self.meta_string
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldvalueId') is not None:
            self.fieldvalue_id = m.get('fieldvalueId')
        if m.get('metaString') is not None:
            self.meta_string = m.get('metaString')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class GetTaskByIdsResponseBodyResultCustomfields(TeaModel):
    def __init__(
        self,
        customfield_id: str = None,
        type: str = None,
        value: List[GetTaskByIdsResponseBodyResultCustomfieldsValue] = None,
    ):
        # 自定义字段ID。
        self.customfield_id = customfield_id
        # 自定义字段类型。
        self.type = type
        # 字段值集合。
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
                temp_model = GetTaskByIdsResponseBodyResultCustomfieldsValue()
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
        customfields: List[GetTaskByIdsResponseBodyResultCustomfields] = None,
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
        scenariofieldconfig_id: str = None,
        sprint_id: str = None,
        stage_id: str = None,
        start_date: str = None,
        story_point: str = None,
        tag_ids: List[str] = None,
        task_id: str = None,
        task_list_id: str = None,
        taskflowstatus_id: str = None,
        unique_id: str = None,
        updated: str = None,
        visible: str = None,
    ):
        # 任务完成时间(UTC)。
        self.accomplish_time = accomplish_time
        # 祖先任务ID列表。
        self.ancestor_ids = ancestor_ids
        # 任务标题。
        self.content = content
        # 创建时间(UTC)。
        self.created = created
        # 创建人ID。
        self.creator_id = creator_id
        # 自定义字段值集合。
        self.customfields = customfields
        # 任务截止时间(UTC)。
        self.due_date = due_date
        # 执行人ID。
        self.executor_id = executor_id
        # 参与者ID集合。
        self.involve_members = involve_members
        # 是否任务放入回收站。
        self.is_archived = is_archived
        # 是否任务已完成。
        self.is_done = is_done
        # 任务备注。
        self.note = note
        # 父任务ID。
        self.parent_task_id = parent_task_id
        # 任务优先级。
        self.priority = priority
        # 项目ID。
        self.project_id = project_id
        # 重复规则列表。
        self.recurrence = recurrence
        # 任务类型ID。
        self.scenariofieldconfig_id = scenariofieldconfig_id
        # 迭代ID。
        self.sprint_id = sprint_id
        # 任务列ID。
        self.stage_id = stage_id
        # 任务开始时间(UTC)。
        self.start_date = start_date
        # StoryPoint。
        self.story_point = story_point
        # 标签ID集合。
        self.tag_ids = tag_ids
        # 任务ID。
        self.task_id = task_id
        # 任务分组ID。
        self.task_list_id = task_list_id
        # 任务状态ID。
        self.taskflowstatus_id = taskflowstatus_id
        # 任务数字ID。
        self.unique_id = unique_id
        # 更新时间(UTC)。
        self.updated = updated
        # 任务隐私性，'involves'表达仅参与者可见; 'members'表达项目成员可见。
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
        if self.task_list_id is not None:
            result['taskListId'] = self.task_list_id
        if self.taskflowstatus_id is not None:
            result['taskflowstatusId'] = self.taskflowstatus_id
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
                temp_model = GetTaskByIdsResponseBodyResultCustomfields()
                self.customfields.append(temp_model.from_map(k))
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
        if m.get('taskListId') is not None:
            self.task_list_id = m.get('taskListId')
        if m.get('taskflowstatusId') is not None:
            self.taskflowstatus_id = m.get('taskflowstatusId')
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
        # 任务详情集合。
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
        body: GetTaskByIdsResponseBody = None,
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
        # 操作者userId
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
        # Teambition企业Id
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
        # 结果对象
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
        body: GetTbOrgIdByDingOrgIdResponseBody = None,
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
        # 是否灰度
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
        body: GetTbProjectGrayResponseBody = None,
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
        # 应用安装来源，"0"：来自应用中心，”6“：预安装
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
        body: GetTbProjectSourceResponseBody = None,
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
        # 操作者userId
        self.opt_user_id = opt_user_id
        # 用户userId
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
        # Teambition用户id
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
        # 结果对象
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
        body: GetTbUserIdByStaffIdResponseBody = None,
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
        # 分页大小。
        self.max_results = max_results
        # 分页标。
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
        total_count: int = None,
    ):
        # 分页标。
        self.next_token = next_token
        # 项目 ID 列表。
        self.result = result
        # 总数。
        self.total_count = total_count

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
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class GetUserJoinedProjectResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetUserJoinedProjectResponseBody = None,
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
        # 分页大小。每页返回最大数量。默认10，最大300。
        self.max_results = max_results
        # 项目名字(模糊匹配)。
        self.name = name
        # 分页标。供分页使用，下一页token，从当前页结果中获取。
        self.next_token = next_token
        # 项目ID集合，逗号分隔。
        self.project_ids = project_ids
        # 原始项目ID。
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


class QueryProjectResponseBodyResultCustomfieldsValue(TeaModel):
    def __init__(
        self,
        fieldvalue_id: str = None,
        meta_string: str = None,
        title: str = None,
    ):
        # 自定义字段值ID。
        self.fieldvalue_id = fieldvalue_id
        # 自定义字段值元属性。
        self.meta_string = meta_string
        # 自定义字段值内容。
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.fieldvalue_id is not None:
            result['fieldvalueId'] = self.fieldvalue_id
        if self.meta_string is not None:
            result['metaString'] = self.meta_string
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldvalueId') is not None:
            self.fieldvalue_id = m.get('fieldvalueId')
        if m.get('metaString') is not None:
            self.meta_string = m.get('metaString')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class QueryProjectResponseBodyResultCustomfields(TeaModel):
    def __init__(
        self,
        customfield_id: str = None,
        type: str = None,
        value: List[QueryProjectResponseBodyResultCustomfieldsValue] = None,
    ):
        # 自定义字段ID。
        self.customfield_id = customfield_id
        # 自定义字段类型。
        self.type = type
        # 自定义字段值列表。
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
                temp_model = QueryProjectResponseBodyResultCustomfieldsValue()
                self.value.append(temp_model.from_map(k))
        return self


class QueryProjectResponseBodyResult(TeaModel):
    def __init__(
        self,
        created: str = None,
        creator_id: str = None,
        customfields: List[QueryProjectResponseBodyResultCustomfields] = None,
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
        # 创建时间。
        self.created = created
        # 创建人ID。
        self.creator_id = creator_id
        # 自定义字段值集合。
        self.customfields = customfields
        # 项目描述。
        self.description = description
        # 项目结束时间。
        self.end_date = end_date
        # 是否放入回收站。
        self.is_archived = is_archived
        # 是否归档。
        self.is_suspended = is_suspended
        # 是模版项目。
        self.is_template = is_template
        # 项目LOGO。
        self.logo = logo
        # 项目名称。
        self.name = name
        # 企业ID。
        self.organization_id = organization_id
        # 项目ID。
        self.project_id = project_id
        # 项目开始时间。
        self.start_date = start_date
        # 任务ID前缀。
        self.unique_id_prefix = unique_id_prefix
        # 更新时间。
        self.updated = updated
        # 可见性，project | organization。
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
        self.customfields = []
        if m.get('customfields') is not None:
            for k in m.get('customfields'):
                temp_model = QueryProjectResponseBodyResultCustomfields()
                self.customfields.append(temp_model.from_map(k))
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
        result: List[QueryProjectResponseBodyResult] = None,
    ):
        # 项目列表。
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
                temp_model = QueryProjectResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class QueryProjectResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryProjectResponseBody = None,
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
        # 每页返回最大数量。默认10，最大500。
        self.max_results = max_results
        # 供分页使用，下一页token，从当前页结果中获取。
        self.next_token = next_token
        # 查询条件。如：“content ~ 标题1” 表示查询任务标题包含“标题1”的任务；“executor=05178xxxxx” 表示执行者是05178xxxx的任务；”involveMembers NOT IN["061xx","06112xx"] AND executorId=0673xxx AND content~标题2“ 表示查询参与者不是”061xx“和”06112xx“ 并且 执行者是0673xxx 并且 标题类似 ”标题2“的所有任务。
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
        # 自定义字段Id。
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
        # 任务完成时间。
        self.accomplished = accomplished
        # 父任务id列表。
        self.ancestor_ids = ancestor_ids
        # 任务标题。
        self.content = content
        # 创建时间。
        self.created = created
        # 创建者id。
        self.creator_id = creator_id
        # 自定义字段id列表。
        self.customfields = customfields
        # 任务截止时间。
        self.due_date = due_date
        # 执行者id。
        self.executor_id = executor_id
        # 参与者列表。
        self.involve_members = involve_members
        # 是否归档。
        self.is_archived = is_archived
        # 是否已删除。
        self.is_deleted = is_deleted
        # 任务是否已完成。
        self.is_done = is_done
        # 任务标签集合。
        self.labels = labels
        # 备注。
        self.note = note
        # 任务优先级。
        self.priority = priority
        # 任务进度。
        self.progress = progress
        # 项目id。
        self.project_id = project_id
        # 任务类型id。
        self.scenariofieldconfig_id = scenariofieldconfig_id
        # 任务迭代id。
        self.sprint_id = sprint_id
        # 任务列表Id。
        self.stage_id = stage_id
        # 任务开始时间。
        self.start_date = start_date
        # 故事点数。
        self.story_point = story_point
        # 标签id集合。
        self.tag_ids = tag_ids
        # 任务id。
        self.task_id = task_id
        # 任务状态id。
        self.taskflowstatus_id = taskflowstatus_id
        # 更新时间。
        self.updated = updated
        # 任务的可见性规则 involves | members。
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
        # 供分页使用，下一页token，从当前页结果中获取。
        self.next_token = next_token
        # 任务对象列表。
        self.result = result
        # 任务总数。
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
        body: QueryTaskOfProjectResponseBody = None,
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
        stage_ids: str = None,
        task_list_id: str = None,
    ):
        # 每页返回最大数量。默认10，最大300。
        self.max_results = max_results
        # 分页标，从上一次请求结果中获取。
        self.next_token = next_token
        # 任务列表名字。
        self.query = query
        # 任务列表 ID 集合，逗号组合。
        self.stage_ids = stage_ids
        # 项目分组ID。
        self.task_list_id = task_list_id

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
        if self.stage_ids is not None:
            result['stageIds'] = self.stage_ids
        if self.task_list_id is not None:
            result['taskListId'] = self.task_list_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('query') is not None:
            self.query = m.get('query')
        if m.get('stageIds') is not None:
            self.stage_ids = m.get('stageIds')
        if m.get('taskListId') is not None:
            self.task_list_id = m.get('taskListId')
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
        # 创建时间。
        self.created = created
        # 创建者用户 ID。
        self.creator_id = creator_id
        # 任务列表名称。
        self.description = description
        # 任务列表名称。
        self.name = name
        # 项目 ID。
        self.project_id = project_id
        # 任务分组 ID。
        self.task_list_id = task_list_id
        # 任务列表 ID。
        self.task_stage_id = task_stage_id
        # 更新时间。
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
        total_count: int = None,
    ):
        # 分页标，供分页使用，下一页token。
        self.next_token = next_token
        # 任务列表列表。
        self.result = result
        # 总数。
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
                temp_model = SeachTaskStageResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class SeachTaskStageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SeachTaskStageResponseBody = None,
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
            temp_model = SeachTaskStageResponseBody()
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
        customfield_ids: str = None,
        instance_ids: str = None,
        max_results: int = None,
        next_token: str = None,
        project_ids: str = None,
        query: str = None,
        scope: str = None,
    ):
        # 自定义字段ID集合，逗号组合。
        self.customfield_ids = customfield_ids
        # 字段InstanceId集合，用逗号组合。
        self.instance_ids = instance_ids
        # 每页返回最大数量。默认10，最大300。
        self.max_results = max_results
        # 供分页使用，下一页token，从当前页结果中获取。
        self.next_token = next_token
        # 过滤出在指定项目中使用的企业字段，当scope=usedInProjectIds有效。多个以逗号隔开。
        self.project_ids = project_ids
        # 过滤字段名字。
        self.query = query
        # 字段应用场景, 可以是 sfcAdd,usedInProjectIds,all 其中一个。
        self.scope = scope

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.customfield_ids is not None:
            result['customfieldIds'] = self.customfield_ids
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
        if self.scope is not None:
            result['scope'] = self.scope
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customfieldIds') is not None:
            self.customfield_ids = m.get('customfieldIds')
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
        if m.get('scope') is not None:
            self.scope = m.get('scope')
        return self


class SearchOranizationCustomfieldResponseBodyResultAdvancedCustomfield(TeaModel):
    def __init__(
        self,
        advanced_customfield_id: str = None,
        name: str = None,
        object_type: str = None,
    ):
        # 字段类型ID。
        self.advanced_customfield_id = advanced_customfield_id
        # 字段类型名称
        self.name = name
        # 字段类型名称2
        self.object_type = object_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.advanced_customfield_id is not None:
            result['advancedCustomfieldId'] = self.advanced_customfield_id
        if self.name is not None:
            result['name'] = self.name
        if self.object_type is not None:
            result['objectType'] = self.object_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('advancedCustomfieldId') is not None:
            self.advanced_customfield_id = m.get('advancedCustomfieldId')
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
        # 选项ID。
        self.choice_id = choice_id
        # 选项值。
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
        advanced_customfield: SearchOranizationCustomfieldResponseBodyResultAdvancedCustomfield = None,
        choices: List[SearchOranizationCustomfieldResponseBodyResultChoices] = None,
        created: str = None,
        creator_id: str = None,
        customfields_id: str = None,
        name: str = None,
        payload: Dict[str, Any] = None,
        type: str = None,
    ):
        # 高级自定义字段。
        self.advanced_customfield = advanced_customfield
        # 如果是单选或多选字段，这里是可选项的值
        self.choices = choices
        # 创建时间。
        self.created = created
        # 创建人ID。
        self.creator_id = creator_id
        # 自定义字段ID。
        self.customfields_id = customfields_id
        # 字段名称。
        self.name = name
        # 用户自定义数据载体，json格式类型任意数据。
        self.payload = payload
        # 字段类型。   'number', // 数字     'date', // 日期     'text', // 文本     'work',     'multipleChoice', // 多选     'dropDown', // 下拉,     'lookup',     'commongroup',     'cascading', // 层级字段     'rtf', // 多行文本/富文本 字段 'lookup2' // 新高级字段
        self.type = type

    def validate(self):
        if self.advanced_customfield:
            self.advanced_customfield.validate()
        if self.choices:
            for k in self.choices:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.advanced_customfield is not None:
            result['advancedCustomfield'] = self.advanced_customfield.to_map()
        result['choices'] = []
        if self.choices is not None:
            for k in self.choices:
                result['choices'].append(k.to_map() if k else None)
        if self.created is not None:
            result['created'] = self.created
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.customfields_id is not None:
            result['customfieldsId'] = self.customfields_id
        if self.name is not None:
            result['name'] = self.name
        if self.payload is not None:
            result['payload'] = self.payload
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('advancedCustomfield') is not None:
            temp_model = SearchOranizationCustomfieldResponseBodyResultAdvancedCustomfield()
            self.advanced_customfield = temp_model.from_map(m['advancedCustomfield'])
        self.choices = []
        if m.get('choices') is not None:
            for k in m.get('choices'):
                temp_model = SearchOranizationCustomfieldResponseBodyResultChoices()
                self.choices.append(temp_model.from_map(k))
        if m.get('created') is not None:
            self.created = m.get('created')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('customfieldsId') is not None:
            self.customfields_id = m.get('customfieldsId')
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
        total_count: int = None,
    ):
        # 供分页使用，下一页token，从当前页结果中获取。
        self.next_token = next_token
        # 自定义字段列表。
        self.result = result
        # 总数。
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
                temp_model = SearchOranizationCustomfieldResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class SearchOranizationCustomfieldResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SearchOranizationCustomfieldResponseBody = None,
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
        customfield_ids: str = None,
        instance_ids: str = None,
        max_results: int = None,
        next_token: str = None,
        query: str = None,
        scenariofieldconfig_id: str = None,
        scope: str = None,
    ):
        # 自定义字段ID集合，逗号组合。
        self.customfield_ids = customfield_ids
        # 字段InstanceId集合，用逗号组合。
        self.instance_ids = instance_ids
        # 每页返回最大数量。默认10，最大500。
        self.max_results = max_results
        # 分页标。
        self.next_token = next_token
        # 过滤字段名字。
        self.query = query
        # 任务类型ID。
        self.scenariofieldconfig_id = scenariofieldconfig_id
        # 字段应用场景, 可以是 taskTableHeader,searcherAdd,taskExportHeader,sfcAdd,kanbanCardAdd,all 其中一个。
        self.scope = scope

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.customfield_ids is not None:
            result['customfieldIds'] = self.customfield_ids
        if self.instance_ids is not None:
            result['instanceIds'] = self.instance_ids
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.query is not None:
            result['query'] = self.query
        if self.scenariofieldconfig_id is not None:
            result['scenariofieldconfigId'] = self.scenariofieldconfig_id
        if self.scope is not None:
            result['scope'] = self.scope
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customfieldIds') is not None:
            self.customfield_ids = m.get('customfieldIds')
        if m.get('instanceIds') is not None:
            self.instance_ids = m.get('instanceIds')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('query') is not None:
            self.query = m.get('query')
        if m.get('scenariofieldconfigId') is not None:
            self.scenariofieldconfig_id = m.get('scenariofieldconfigId')
        if m.get('scope') is not None:
            self.scope = m.get('scope')
        return self


class SearchProjectCustomfieldResponseBodyResultAdvancedCustomfield(TeaModel):
    def __init__(
        self,
        advanced_customfield_id: str = None,
        name: str = None,
        object_type: str = None,
    ):
        # 字段类型ID。
        self.advanced_customfield_id = advanced_customfield_id
        # 字段类型名称
        self.name = name
        # 字段类型名称2。
        self.object_type = object_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.advanced_customfield_id is not None:
            result['advancedCustomfieldId'] = self.advanced_customfield_id
        if self.name is not None:
            result['name'] = self.name
        if self.object_type is not None:
            result['objectType'] = self.object_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('advancedCustomfieldId') is not None:
            self.advanced_customfield_id = m.get('advancedCustomfieldId')
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
        # 选项Id。
        self.choice_id = choice_id
        # 选项值。
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
        advanced_customfield: SearchProjectCustomfieldResponseBodyResultAdvancedCustomfield = None,
        bound_to_object_id: str = None,
        choices: List[SearchProjectCustomfieldResponseBodyResultChoices] = None,
        created: str = None,
        creator_id: str = None,
        customfiled_id: str = None,
        name: str = None,
        original_id: str = None,
        payload: Dict[str, Any] = None,
        type: str = None,
    ):
        # 高级自定义字段。
        self.advanced_customfield = advanced_customfield
        # 绑定的对象Id，此接口为项目ID。
        self.bound_to_object_id = bound_to_object_id
        # 如果是单选或多选字段，这里是可选项的值
        self.choices = choices
        # 创建时间。
        self.created = created
        # 创建人ID。
        self.creator_id = creator_id
        # 自定义字段ID。
        self.customfiled_id = customfiled_id
        # 字段名称。
        self.name = name
        # 如果是企业字段，该字段表达绑定的企业字段ID。
        self.original_id = original_id
        # 用户自定义数据载体，json格式类型任意数据。
        self.payload = payload
        # 字段类型。 'number', // 数字 'date', // 日期 'text', // 文本 'work', 'multipleChoice', // 多选 'dropDown', // 下拉, 'lookup', 'commongroup', 'cascading', // 层级字段 'rtf', // 多行文本/富文本 字段 'lookup2' // 新高级字段
        self.type = type

    def validate(self):
        if self.advanced_customfield:
            self.advanced_customfield.validate()
        if self.choices:
            for k in self.choices:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.advanced_customfield is not None:
            result['advancedCustomfield'] = self.advanced_customfield.to_map()
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
        if self.customfiled_id is not None:
            result['customfiledId'] = self.customfiled_id
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
        if m.get('advancedCustomfield') is not None:
            temp_model = SearchProjectCustomfieldResponseBodyResultAdvancedCustomfield()
            self.advanced_customfield = temp_model.from_map(m['advancedCustomfield'])
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
        if m.get('customfiledId') is not None:
            self.customfiled_id = m.get('customfiledId')
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
        total_count: int = None,
    ):
        # 供分页使用，下一页token，从当前页结果中获取。
        self.next_token = next_token
        # 自定义字段列表。
        self.result = result
        # 总数。
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
                temp_model = SearchProjectCustomfieldResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class SearchProjectCustomfieldResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SearchProjectCustomfieldResponseBody = None,
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
        # 项目模板名关键词
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
        # 创建时间
        self.created = created
        # 模板描述
        self.description = description
        # 模板id
        self.id = id
        # 是否已删除
        self.is_deleted = is_deleted
        # 是否demo模板
        self.is_demo = is_demo
        # 模板log地址
        self.logo = logo
        # 模板名字
        self.name = name
        # 更新时间
        self.updated = updated
        # 模板可见性。organization 或者 involves
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
        # 返回结果对象
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
        body: SearchProjectTemplateResponseBody = None,
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
        # 每页返回最大数量。默认10，最大300。
        self.max_results = max_results
        # 分页标，从上一次请求结果中获取。
        self.next_token = next_token
        # 模糊查询工作流名字。
        self.query = query
        # 工作流ID集合，逗号组合。
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
        # 绑定对象Id，此接口为项目id。
        self.bound_to_object_id = bound_to_object_id
        # 绑定类型，增加项目成员默认是project。
        self.bound_to_object_type = bound_to_object_type
        # 创建时间。
        self.created = created
        # 创建者id。
        self.creator_id = creator_id
        # 是否已删除。
        self.is_deleted = is_deleted
        # 工作流名称。
        self.name = name
        # 工作流ID。
        self.taskflow_id = taskflow_id
        # 更新时间。
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
        # 工作流列表。
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
        body: SearchTaskFlowResponseBody = None,
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
        # 每页返回最大数量。默认10，最大300。
        self.max_results = max_results
        # 分页标，从上一次请求结果中获取。
        self.next_token = next_token
        # 模糊任务分组名字。
        self.query = query
        # 任务分组ID集合，逗号组合。
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
        task_id: str = None,
        title: str = None,
        updated: str = None,
    ):
        # 创建时间。
        self.created = created
        # 创建者用户ID。
        self.creator_id = creator_id
        # 任务分组名称。
        self.description = description
        # 项目ID。
        self.project_id = project_id
        # 任务分组ID。
        self.task_id = task_id
        # 任务分组名称。
        self.title = title
        # 更新时间。
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
        if self.task_id is not None:
            result['taskId'] = self.task_id
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
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
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
        total_count: int = None,
    ):
        # 分页标，供分页使用，下一页token。
        self.next_token = next_token
        # 任务分0组列表。
        self.result = result
        # 总数。
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
                temp_model = SearchTaskListResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class SearchTaskListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SearchTaskListResponseBody = None,
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
        # 每页返回最大数量。默认10，最大300。
        self.max_results = max_results
        # 分页标，从上一次请求结果中获取。
        self.next_token = next_token
        # 模糊查询工作流状态名字。
        self.query = query
        # 工作流ID集合，多个以逗号隔开。
        self.tf_ids = tf_ids
        # 工作流状态ID集合，多个以逗号隔开。
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
        # 创建时间。
        self.created = created
        # 创建者ID。
        self.creator_id = creator_id
        # 是否已删除。
        self.is_deleted = is_deleted
        # 是否特定任务角色才能流转该工作流状态。
        self.is_taskflowstatusruleexector = is_taskflowstatusruleexector
        # 任务工作流状态类型。  start: 开始  end: 结束  unset: 未设置
        self.kind = kind
        # 任务工作流状态名字。
        self.name = name
        # 任务工作流状态位置。
        self.pos = pos
        # 拒绝的工作流状态Id。
        self.reject_status_ids = reject_status_ids
        # 任务工作流ID。
        self.taskflow_id = taskflow_id
        # 任务工作流状态ID。
        self.taskflow_status_id = taskflow_status_id
        # 更新时间。
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
        # 任务工作流状态列表。
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
        body: SearchTaskflowStatusResponseBody = None,
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
        # 每页返回最大数量。默认10，最大100。
        self.max_results = max_results
        # 分页标，从上一次请求结果中获取。
        self.next_token = next_token
        # 用户的任务角色, creator,executor,involveMember 中的一个或多个,以 ','拼接。例如：creator,executor。
        self.role_types = role_types
        # tql，参考项目内的tql使用说明。
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


class SearchUserTaskResponseBodyResultCustomfieldsValue(TeaModel):
    def __init__(
        self,
        fieldvalue_id: str = None,
        meta_string: str = None,
        title: str = None,
    ):
        # 字段值ID。
        self.fieldvalue_id = fieldvalue_id
        # 字段值元属性。
        self.meta_string = meta_string
        # 字段值内容。
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.fieldvalue_id is not None:
            result['fieldvalueId'] = self.fieldvalue_id
        if self.meta_string is not None:
            result['metaString'] = self.meta_string
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldvalueId') is not None:
            self.fieldvalue_id = m.get('fieldvalueId')
        if m.get('metaString') is not None:
            self.meta_string = m.get('metaString')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class SearchUserTaskResponseBodyResultCustomfields(TeaModel):
    def __init__(
        self,
        customfield_id: str = None,
        type: str = None,
        value: List[SearchUserTaskResponseBodyResultCustomfieldsValue] = None,
    ):
        # 自定义字段ID。
        self.customfield_id = customfield_id
        # 自定义字段类型。
        self.type = type
        # 字段值集合。
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
                temp_model = SearchUserTaskResponseBodyResultCustomfieldsValue()
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
        customfields: List[SearchUserTaskResponseBodyResultCustomfields] = None,
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
        scenariofieldconfig_id: str = None,
        sprint_id: str = None,
        stage_id: str = None,
        start_date: str = None,
        story_point: str = None,
        tag_ids: List[str] = None,
        task_id: str = None,
        task_list_id: str = None,
        unique_id: str = None,
        updated: str = None,
        visible: str = None,
    ):
        # 任务完成时间(UTC)。
        self.accomplish_time = accomplish_time
        # 祖先任务ID列表。
        self.ancestor_ids = ancestor_ids
        # 任务标题。
        self.content = content
        # 创建时间(UTC)。
        self.created = created
        # 创建人ID。
        self.creator_id = creator_id
        # 自定义字段值集合。
        self.customfields = customfields
        # 任务截止时间(UTC)。
        self.due_date = due_date
        # 执行人ID。
        self.executor_id = executor_id
        # 参与者ID集合。
        self.involve_members = involve_members
        # 是否任务放入回收站。
        self.is_archived = is_archived
        # 是否任务已完成。
        self.is_done = is_done
        # 任务备注。
        self.note = note
        # 父任务ID。
        self.parent_task_id = parent_task_id
        # 任务优先级。
        self.priority = priority
        # 项目ID。
        self.project_id = project_id
        # 重复规则列表。
        self.recurrence = recurrence
        # 任务类型ID。
        self.scenariofieldconfig_id = scenariofieldconfig_id
        # 迭代ID。
        self.sprint_id = sprint_id
        # 任务列ID。
        self.stage_id = stage_id
        # 任务开始时间(UTC)。
        self.start_date = start_date
        # StoryPoint。
        self.story_point = story_point
        # 标签ID集合。
        self.tag_ids = tag_ids
        # 任务状态ID。
        self.task_id = task_id
        # 任务列表ID。
        self.task_list_id = task_list_id
        # 任务数字ID。
        self.unique_id = unique_id
        # 更新时间(UTC)。
        self.updated = updated
        # 任务隐私性，'involves'表达仅参与者可见; 'members'表达项目成员可见。
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
        if self.task_list_id is not None:
            result['taskListId'] = self.task_list_id
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
                temp_model = SearchUserTaskResponseBodyResultCustomfields()
                self.customfields.append(temp_model.from_map(k))
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
        if m.get('taskListId') is not None:
            self.task_list_id = m.get('taskListId')
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
        result: List[SearchUserTaskResponseBodyResult] = None,
    ):
        # 任务详情集合。
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
                temp_model = SearchUserTaskResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class SearchUserTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SearchUserTaskResponseBody = None,
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
        # 更新时间。
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
        # 返回对象。
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
        body: SuspendProjectResponseBody = None,
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
        # 更新时间。
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
        # 返回对象。
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
        body: UnSuspendProjectResponseBody = None,
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
        # 自定义字段显示值
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
        customfield_id: str = None,
        customfield_name: str = None,
        value: List[UpdateCustomfieldValueRequestValue] = None,
    ):
        # 自定义字段id
        self.customfield_id = customfield_id
        # 自定义字段名
        self.customfield_name = customfield_name
        # 自定义字段值列表，最多10个
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
                temp_model = UpdateCustomfieldValueRequestValue()
                self.value.append(temp_model.from_map(k))
        return self


class UpdateCustomfieldValueResponseBodyResultCustomfieldsValue(TeaModel):
    def __init__(
        self,
        title: str = None,
    ):
        # 自定义字段显示值
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


class UpdateCustomfieldValueResponseBodyResultCustomfields(TeaModel):
    def __init__(
        self,
        customfield_id: str = None,
        value: List[UpdateCustomfieldValueResponseBodyResultCustomfieldsValue] = None,
    ):
        # 自定义字段id
        self.customfield_id = customfield_id
        # 自定义字段值对象
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
                temp_model = UpdateCustomfieldValueResponseBodyResultCustomfieldsValue()
                self.value.append(temp_model.from_map(k))
        return self


class UpdateCustomfieldValueResponseBodyResult(TeaModel):
    def __init__(
        self,
        customfields: List[UpdateCustomfieldValueResponseBodyResultCustomfields] = None,
    ):
        # 自定义字段数组
        self.customfields = customfields

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
        result['customfields'] = []
        if self.customfields is not None:
            for k in self.customfields:
                result['customfields'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.customfields = []
        if m.get('customfields') is not None:
            for k in m.get('customfields'):
                temp_model = UpdateCustomfieldValueResponseBodyResultCustomfields()
                self.customfields.append(temp_model.from_map(k))
        return self


class UpdateCustomfieldValueResponseBody(TeaModel):
    def __init__(
        self,
        result: UpdateCustomfieldValueResponseBodyResult = None,
    ):
        # 返回对象
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
        body: UpdateCustomfieldValueResponseBody = None,
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
        # 任务标题
        self.content = content
        # 是否禁止动态
        self.disable_activity = disable_activity
        # 是否禁止通知
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
        # 任务标题
        self.content = content
        # 更新时间
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
        # 返回对象
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
        body: UpdateOrganizationTaskContentResponseBody = None,
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
        # 是否禁止动态
        self.disable_activity = disable_activity
        # 是否禁止通知
        self.disable_notification = disable_notification
        # 任务截止时间
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
        # 任务截止时间
        self.due_date = due_date
        # 更新时间
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
        # 返回对象
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
        body: UpdateOrganizationTaskDueDateResponseBody = None,
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
        # 头像
        self.avatar_url = avatar_url
        # 名字
        self.name = name
        # 用户uid
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
        # 头像
        self.avatar_url = avatar_url
        # 名字
        self.name = name
        # 用户uid
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
        # 执行者信息
        self.executor = executor
        # 执行者id
        self.executor_id = executor_id
        # 参与者列表
        self.involvers = involvers
        # 更新时间
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
        # 返回对象
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
        body: UpdateOrganizationTaskExecutorResponseBody = None,
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
        # 增加的参与者uid
        self.add_involvers = add_involvers
        # 删除的参与者uid
        self.del_involvers = del_involvers
        # 是否禁用动态
        self.disable_activity = disable_activity
        # 是否禁用通知
        self.disable_notification = disable_notification
        # 所有参与者uid
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
        # 头像
        self.avatar_url = avatar_url
        # 名字
        self.name = name
        # 用户uid
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
        # 参与者列表
        self.involvers = involvers
        # 更新时间
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
        # 返回对象
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
        body: UpdateOrganizationTaskInvolveMembersResponseBody = None,
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
        # 是否禁用动态
        self.disable_activity = disable_activity
        # 是否禁用通知
        self.disable_notification = disable_notification
        # 任务备注
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
        # 任务备注
        self.note = note
        # 更新时间
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
        body: UpdateOrganizationTaskNoteResponseBody = None,
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
        # 是否禁止动态
        self.disable_activity = disable_activity
        # 是否禁止通知
        self.disable_notification = disable_notification
        # 优先级【-10,0,1,2】中的一个值
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
        # 优先级【-10,0,1,2】中的一个
        self.priority = priority
        # 更新时间
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
        # 返回对象
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
        body: UpdateOrganizationTaskPriorityResponseBody = None,
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
        # 是否禁用动态
        self.disable_activity = disable_activity
        # 是否禁用通知
        self.disable_notification = disable_notification
        # true改成完成，false 改成未完成
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
        # 是否已完成
        self.is_done = is_done
        # 更新时间
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
        # 返回对象
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
        body: UpdateOrganizationTaskStatusResponseBody = None,
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
        # 增加到项目分组的Id列表，最多5个
        self.add_project_group_ids = add_project_group_ids
        # 移除项目分组的Id列表，最多5个
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
        # 是否成功
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
        # 结果对象
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
        body: UpdateProjectGroupResponseBody = None,
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
        # 任务标题。
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
        # 任务标题。
        self.content = content
        # 更新时间。
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
        # 结果。
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
        body: UpdateTaskContentResponseBody = None,
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
        # 截止时间。
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
        # 截止时间。
        self.due_date = due_date
        # 更新时间。
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
        # 结果。
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
        body: UpdateTaskDueDateResponseBody = None,
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
        # 执行者用户ID。
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
        # 执行者用户ID。
        self.executor_id = executor_id
        # 更新时间。
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
        # 结果。
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
        body: UpdateTaskExecutorResponseBody = None,
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
        # 新增参与者列表。
        self.add_involvers = add_involvers
        # 移除参与者列表。
        self.del_involvers = del_involvers
        # 更新任务参与者列表。
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
        # 参与者列表。
        self.involve_members = involve_members
        # 更新时间。
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
        # 结果
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
        body: UpdateTaskInvolvemembersResponseBody = None,
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
        # 任务备注。
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
        # 任务备注。
        self.note = note
        # 更新时间。
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
        # 结果
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
        body: UpdateTaskNoteResponseBody = None,
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
        # 优先级。
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
        # 优先级。
        self.priority = priority
        # 更新时间。
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
        body: UpdateTaskPriorityResponseBody = None,
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
        stage_id: str = None,
    ):
        # 任务列表Id。
        self.stage_id = stage_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stage_id is not None:
            result['stageId'] = self.stage_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('stageId') is not None:
            self.stage_id = m.get('stageId')
        return self


class UpdateTaskStageResponseBodyResult(TeaModel):
    def __init__(
        self,
        accomplish_time: str = None,
        is_done: bool = None,
        project_id: str = None,
        stage_id: str = None,
        task_id: str = None,
        task_list_id: str = None,
        updated: str = None,
    ):
        # 任务完成时间(UTC)。
        self.accomplish_time = accomplish_time
        # 是否任务已完成。
        self.is_done = is_done
        # 项目ID。
        self.project_id = project_id
        # 任务列ID。
        self.stage_id = stage_id
        # 任务ID。
        self.task_id = task_id
        # 任务分组ID。
        self.task_list_id = task_list_id
        # 更新时间(UTC)。
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
        if self.stage_id is not None:
            result['stageId'] = self.stage_id
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.task_list_id is not None:
            result['taskListId'] = self.task_list_id
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
        if m.get('stageId') is not None:
            self.stage_id = m.get('stageId')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('taskListId') is not None:
            self.task_list_id = m.get('taskListId')
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
        body: UpdateTaskStageResponseBody = None,
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
        # 任务开始时间。
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
        # 任务开始时间。
        self.start_date = start_date
        # 更新时间。
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
        # 结果
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
        body: UpdateTaskStartdateResponseBody = None,
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
        tfs_update_note: str = None,
    ):
        # 任务状态ID。
        self.taskflow_status_id = taskflow_status_id
        # 任务流转说明。
        self.tfs_update_note = tfs_update_note

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.taskflow_status_id is not None:
            result['taskflowStatusId'] = self.taskflow_status_id
        if self.tfs_update_note is not None:
            result['tfsUpdateNote'] = self.tfs_update_note
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('taskflowStatusId') is not None:
            self.taskflow_status_id = m.get('taskflowStatusId')
        if m.get('tfsUpdateNote') is not None:
            self.tfs_update_note = m.get('tfsUpdateNote')
        return self


class UpdateTaskTaskflowstatusResponseBodyResult(TeaModel):
    def __init__(
        self,
        updated: str = None,
    ):
        # 更新时间。
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
        # 结果。
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
        body: UpdateTaskTaskflowstatusResponseBody = None,
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
            temp_model = UpdateTaskTaskflowstatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


