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


class CreateTaskRequest(TeaModel):
    def __init__(
        self,
        content: str = None,
        due_date: str = None,
        executor_id: str = None,
        note: str = None,
        priority: int = None,
        project_id: str = None,
    ):
        # 任务标题
        self.content = content
        # 任务截止时间
        self.due_date = due_date
        # 执行者userId
        self.executor_id = executor_id
        # 任务备注
        self.note = note
        # 任务优先级
        self.priority = priority
        # 项目id
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
        if self.due_date is not None:
            result['dueDate'] = self.due_date
        if self.executor_id is not None:
            result['executorId'] = self.executor_id
        if self.note is not None:
            result['note'] = self.note
        if self.priority is not None:
            result['priority'] = self.priority
        if self.project_id is not None:
            result['projectId'] = self.project_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('dueDate') is not None:
            self.due_date = m.get('dueDate')
        if m.get('executorId') is not None:
            self.executor_id = m.get('executorId')
        if m.get('note') is not None:
            self.note = m.get('note')
        if m.get('priority') is not None:
            self.priority = m.get('priority')
        if m.get('projectId') is not None:
            self.project_id = m.get('projectId')
        return self


class CreateTaskResponseBodyResult(TeaModel):
    def __init__(
        self,
        content: str = None,
        created: str = None,
        creator_id: str = None,
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


