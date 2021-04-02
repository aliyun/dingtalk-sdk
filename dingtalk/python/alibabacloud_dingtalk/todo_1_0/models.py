# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class GetTodoTaskHeaders(TeaModel):
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


class GetTodoTaskResponseBodyReminderRules(TeaModel):
    def __init__(
        self,
        base_time: str = None,
        offset: int = None,
    ):
        # startTime:相对开始时间 // dueTime:相对截止时间 // customTime: 绝对时间
        self.base_time = base_time
        # baseTime 为 startTime 或者 dueTime 时表分钟；比如截止前15分钟为 -15，截止前3小时为 -180;basetime 为 customTime 时为时间戳
        self.offset = offset

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.base_time is not None:
            result['baseTime'] = self.base_time
        if self.offset is not None:
            result['offset'] = self.offset
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('baseTime') is not None:
            self.base_time = m.get('baseTime')
        if m.get('offset') is not None:
            self.offset = m.get('offset')
        return self


class GetTodoTaskResponseBodyReminder(TeaModel):
    def __init__(
        self,
        channel: int = None,
        rules: List[GetTodoTaskResponseBodyReminderRules] = None,
    ):
        # 提醒通道
        self.channel = channel
        # 提醒规则配置
        self.rules = rules

    def validate(self):
        if self.rules:
            for k in self.rules:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.channel is not None:
            result['channel'] = self.channel
        result['rules'] = []
        if self.rules is not None:
            for k in self.rules:
                result['rules'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('channel') is not None:
            self.channel = m.get('channel')
        self.rules = []
        if m.get('rules') is not None:
            for k in m.get('rules'):
                temp_model = GetTodoTaskResponseBodyReminderRules()
                self.rules.append(temp_model.from_map(k))
        return self


class GetTodoTaskResponseBodyDetailUrl(TeaModel):
    def __init__(
        self,
        pc_url: str = None,
        app_url: str = None,
    ):
        # pc端详情页地址
        self.pc_url = pc_url
        # app端详情页地址
        self.app_url = app_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.pc_url is not None:
            result['pcUrl'] = self.pc_url
        if self.app_url is not None:
            result['appUrl'] = self.app_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pcUrl') is not None:
            self.pc_url = m.get('pcUrl')
        if m.get('appUrl') is not None:
            self.app_url = m.get('appUrl')
        return self


class GetTodoTaskResponseBody(TeaModel):
    def __init__(
        self,
        id: str = None,
        subject: str = None,
        description: str = None,
        start_time: int = None,
        due_time: int = None,
        finish_time: int = None,
        done: bool = None,
        executor_ids: List[str] = None,
        participant_ids: List[str] = None,
        reminder: GetTodoTaskResponseBodyReminder = None,
        recurrence: str = None,
        detail_url: GetTodoTaskResponseBodyDetailUrl = None,
        source_id: str = None,
        source: str = None,
        created_time: int = None,
        modified_time: int = None,
        creator_id: str = None,
        modifier_id: str = None,
        tenant_id: str = None,
        biz_tag: str = None,
        request_id: str = None,
    ):
        # id
        self.id = id
        # 标题
        self.subject = subject
        # 描述
        self.description = description
        # 开始时间
        self.start_time = start_time
        # 截止时间
        self.due_time = due_time
        # 完成时间
        self.finish_time = finish_time
        # 完成状态
        self.done = done
        # 执行者列表
        self.executor_ids = executor_ids
        # 参与者列表
        self.participant_ids = participant_ids
        # 提醒规则
        self.reminder = reminder
        # 重复规则
        self.recurrence = recurrence
        # 自定义详情页跳转配置
        self.detail_url = detail_url
        # 业务来源id
        self.source_id = source_id
        # 业务来源
        self.source = source
        # 创建时间
        self.created_time = created_time
        # 更新时间
        self.modified_time = modified_time
        # 创建者id
        self.creator_id = creator_id
        # 更新者id
        self.modifier_id = modifier_id
        # 租户id
        self.tenant_id = tenant_id
        # 接入业务应用标识
        self.biz_tag = biz_tag
        # requestId
        self.request_id = request_id

    def validate(self):
        if self.reminder:
            self.reminder.validate()
        if self.detail_url:
            self.detail_url.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.subject is not None:
            result['subject'] = self.subject
        if self.description is not None:
            result['description'] = self.description
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.due_time is not None:
            result['dueTime'] = self.due_time
        if self.finish_time is not None:
            result['finishTime'] = self.finish_time
        if self.done is not None:
            result['done'] = self.done
        if self.executor_ids is not None:
            result['executorIds'] = self.executor_ids
        if self.participant_ids is not None:
            result['participantIds'] = self.participant_ids
        if self.reminder is not None:
            result['reminder'] = self.reminder.to_map()
        if self.recurrence is not None:
            result['recurrence'] = self.recurrence
        if self.detail_url is not None:
            result['detailUrl'] = self.detail_url.to_map()
        if self.source_id is not None:
            result['sourceId'] = self.source_id
        if self.source is not None:
            result['source'] = self.source
        if self.created_time is not None:
            result['createdTime'] = self.created_time
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.modifier_id is not None:
            result['modifierId'] = self.modifier_id
        if self.tenant_id is not None:
            result['tenantId'] = self.tenant_id
        if self.biz_tag is not None:
            result['bizTag'] = self.biz_tag
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('subject') is not None:
            self.subject = m.get('subject')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('dueTime') is not None:
            self.due_time = m.get('dueTime')
        if m.get('finishTime') is not None:
            self.finish_time = m.get('finishTime')
        if m.get('done') is not None:
            self.done = m.get('done')
        if m.get('executorIds') is not None:
            self.executor_ids = m.get('executorIds')
        if m.get('participantIds') is not None:
            self.participant_ids = m.get('participantIds')
        if m.get('reminder') is not None:
            temp_model = GetTodoTaskResponseBodyReminder()
            self.reminder = temp_model.from_map(m['reminder'])
        if m.get('recurrence') is not None:
            self.recurrence = m.get('recurrence')
        if m.get('detailUrl') is not None:
            temp_model = GetTodoTaskResponseBodyDetailUrl()
            self.detail_url = temp_model.from_map(m['detailUrl'])
        if m.get('sourceId') is not None:
            self.source_id = m.get('sourceId')
        if m.get('source') is not None:
            self.source = m.get('source')
        if m.get('createdTime') is not None:
            self.created_time = m.get('createdTime')
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('modifierId') is not None:
            self.modifier_id = m.get('modifierId')
        if m.get('tenantId') is not None:
            self.tenant_id = m.get('tenantId')
        if m.get('bizTag') is not None:
            self.biz_tag = m.get('bizTag')
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class GetTodoTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetTodoTaskResponseBody = None,
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
            temp_model = GetTodoTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteTodoTaskHeaders(TeaModel):
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


class DeleteTodoTaskRequest(TeaModel):
    def __init__(
        self,
        operator_id: str = None,
    ):
        # 操作者id
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class DeleteTodoTaskResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
        request_id: str = None,
    ):
        # 删除结果
        self.result = result
        # requestId
        self.request_id = request_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class DeleteTodoTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DeleteTodoTaskResponseBody = None,
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
            temp_model = DeleteTodoTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateTodoTaskHeaders(TeaModel):
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


class UpdateTodoTaskRequestDetailUrl(TeaModel):
    def __init__(
        self,
        app_url: str = None,
        pc_url: str = None,
    ):
        # app端详情页url
        self.app_url = app_url
        # pc端详情页url
        self.pc_url = pc_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_url is not None:
            result['appUrl'] = self.app_url
        if self.pc_url is not None:
            result['pcUrl'] = self.pc_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUrl') is not None:
            self.app_url = m.get('appUrl')
        if m.get('pcUrl') is not None:
            self.pc_url = m.get('pcUrl')
        return self


class UpdateTodoTaskRequestReminderRules(TeaModel):
    def __init__(
        self,
        base_time: str = None,
        offset: int = None,
    ):
        # startTime:相对开始时间  											//  					dueTime:相对截止时间 											//						customTime: 绝对时间
        self.base_time = base_time
        # 必须，baseTime 为 startTime 或者 dueTime 时表分钟；比如截止前15分钟为 -15，截止前3小时为 -180;basetime 为 customTime 时为时间戳
        self.offset = offset

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.base_time is not None:
            result['baseTime'] = self.base_time
        if self.offset is not None:
            result['offset'] = self.offset
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('baseTime') is not None:
            self.base_time = m.get('baseTime')
        if m.get('offset') is not None:
            self.offset = m.get('offset')
        return self


class UpdateTodoTaskRequestReminder(TeaModel):
    def __init__(
        self,
        channel: int = None,
        rules: List[UpdateTodoTaskRequestReminderRules] = None,
    ):
        # 提醒通道，1 弹框，2 短信，3 电话
        self.channel = channel
        # 提醒规则列表
        self.rules = rules

    def validate(self):
        if self.rules:
            for k in self.rules:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.channel is not None:
            result['channel'] = self.channel
        result['rules'] = []
        if self.rules is not None:
            for k in self.rules:
                result['rules'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('channel') is not None:
            self.channel = m.get('channel')
        self.rules = []
        if m.get('rules') is not None:
            for k in m.get('rules'):
                temp_model = UpdateTodoTaskRequestReminderRules()
                self.rules.append(temp_model.from_map(k))
        return self


class UpdateTodoTaskRequest(TeaModel):
    def __init__(
        self,
        sucject: str = None,
        description: str = None,
        due_time: int = None,
        done: bool = None,
        executor_ids: List[str] = None,
        participant_ids: List[str] = None,
        detail_url: UpdateTodoTaskRequestDetailUrl = None,
        recurrence: str = None,
        reminder: UpdateTodoTaskRequestReminder = None,
        operator_id: str = None,
    ):
        # 待办标题
        self.sucject = sucject
        # 待办描述备注
        self.description = description
        # 截止时间
        self.due_time = due_time
        # 完成状态
        self.done = done
        # 执行者列表
        self.executor_ids = executor_ids
        # 参与者列表
        self.participant_ids = participant_ids
        # 详情页url跳转地址
        self.detail_url = detail_url
        # 待办重复规则配置
        self.recurrence = recurrence
        # 待办提醒规则配置
        self.reminder = reminder
        # 当前操作者id
        self.operator_id = operator_id

    def validate(self):
        if self.detail_url:
            self.detail_url.validate()
        if self.reminder:
            self.reminder.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.sucject is not None:
            result['sucject'] = self.sucject
        if self.description is not None:
            result['description'] = self.description
        if self.due_time is not None:
            result['dueTime'] = self.due_time
        if self.done is not None:
            result['done'] = self.done
        if self.executor_ids is not None:
            result['executorIds'] = self.executor_ids
        if self.participant_ids is not None:
            result['participantIds'] = self.participant_ids
        if self.detail_url is not None:
            result['detailUrl'] = self.detail_url.to_map()
        if self.recurrence is not None:
            result['recurrence'] = self.recurrence
        if self.reminder is not None:
            result['reminder'] = self.reminder.to_map()
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sucject') is not None:
            self.sucject = m.get('sucject')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('dueTime') is not None:
            self.due_time = m.get('dueTime')
        if m.get('done') is not None:
            self.done = m.get('done')
        if m.get('executorIds') is not None:
            self.executor_ids = m.get('executorIds')
        if m.get('participantIds') is not None:
            self.participant_ids = m.get('participantIds')
        if m.get('detailUrl') is not None:
            temp_model = UpdateTodoTaskRequestDetailUrl()
            self.detail_url = temp_model.from_map(m['detailUrl'])
        if m.get('recurrence') is not None:
            self.recurrence = m.get('recurrence')
        if m.get('reminder') is not None:
            temp_model = UpdateTodoTaskRequestReminder()
            self.reminder = temp_model.from_map(m['reminder'])
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class UpdateTodoTaskResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        # 更新结果
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


class UpdateTodoTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateTodoTaskResponseBody = None,
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
            temp_model = UpdateTodoTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateTodoTaskHeaders(TeaModel):
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


class CreateTodoTaskRequestDetailUrl(TeaModel):
    def __init__(
        self,
        app_url: str = None,
        pc_url: str = None,
    ):
        # app端详情页url
        self.app_url = app_url
        # pc端详情页url
        self.pc_url = pc_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_url is not None:
            result['appUrl'] = self.app_url
        if self.pc_url is not None:
            result['pcUrl'] = self.pc_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUrl') is not None:
            self.app_url = m.get('appUrl')
        if m.get('pcUrl') is not None:
            self.pc_url = m.get('pcUrl')
        return self


class CreateTodoTaskRequestReminderRules(TeaModel):
    def __init__(
        self,
        base_time: str = None,
        offset: int = None,
    ):
        # startTime:相对开始时间  											//  					dueTime:相对截止时间 											//						customTime: 绝对时间
        self.base_time = base_time
        # 必须，baseTime 为 startTime 或者 dueTime 时表分钟；比如截止前15分钟为 -15，截止前3小时为 -180;basetime 为 customTime 时为时间戳
        self.offset = offset

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.base_time is not None:
            result['baseTime'] = self.base_time
        if self.offset is not None:
            result['offset'] = self.offset
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('baseTime') is not None:
            self.base_time = m.get('baseTime')
        if m.get('offset') is not None:
            self.offset = m.get('offset')
        return self


class CreateTodoTaskRequestReminder(TeaModel):
    def __init__(
        self,
        channel: int = None,
        rules: List[CreateTodoTaskRequestReminderRules] = None,
    ):
        # 提醒通道，1 弹框，2 短信，3 电话
        self.channel = channel
        # 提醒规则列表
        self.rules = rules

    def validate(self):
        if self.rules:
            for k in self.rules:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.channel is not None:
            result['channel'] = self.channel
        result['rules'] = []
        if self.rules is not None:
            for k in self.rules:
                result['rules'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('channel') is not None:
            self.channel = m.get('channel')
        self.rules = []
        if m.get('rules') is not None:
            for k in m.get('rules'):
                temp_model = CreateTodoTaskRequestReminderRules()
                self.rules.append(temp_model.from_map(k))
        return self


class CreateTodoTaskRequestNotifyConfigs(TeaModel):
    def __init__(
        self,
        single_chat: str = None,
        group_chat: str = None,
        ding_notify: str = None,
        canlender: str = None,
    ):
        # 是否发送单聊卡片：value:"true/false" （发送则传true）
        self.single_chat = single_chat
        # 是否发送群聊卡片：value:"groupId"（发送则传对应群聊id）
        self.group_chat = group_chat
        # ding通知配置：value:"channel"（1钉弹框通知，2钉短信通知，3钉电话通知）
        self.ding_notify = ding_notify
        # 是否同步到日历：value:"true/false"（同步则传true）
        self.canlender = canlender

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.single_chat is not None:
            result['singleChat'] = self.single_chat
        if self.group_chat is not None:
            result['groupChat'] = self.group_chat
        if self.ding_notify is not None:
            result['dingNotify'] = self.ding_notify
        if self.canlender is not None:
            result['canlender'] = self.canlender
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('singleChat') is not None:
            self.single_chat = m.get('singleChat')
        if m.get('groupChat') is not None:
            self.group_chat = m.get('groupChat')
        if m.get('dingNotify') is not None:
            self.ding_notify = m.get('dingNotify')
        if m.get('canlender') is not None:
            self.canlender = m.get('canlender')
        return self


class CreateTodoTaskRequest(TeaModel):
    def __init__(
        self,
        source_id: str = None,
        subject: str = None,
        creator_id: str = None,
        description: str = None,
        due_time: int = None,
        executor_ids: List[str] = None,
        participant_ids: List[str] = None,
        detail_url: CreateTodoTaskRequestDetailUrl = None,
        recurrence: str = None,
        reminder: CreateTodoTaskRequestReminder = None,
        notify_configs: CreateTodoTaskRequestNotifyConfigs = None,
        operator_id: str = None,
    ):
        # 来源id，接入业务系统侧的唯一标识id
        self.source_id = source_id
        # 待办标题
        self.subject = subject
        # 创建者id
        self.creator_id = creator_id
        # 待办备注描述
        self.description = description
        # 截止时间
        self.due_time = due_time
        # 执行者列表
        self.executor_ids = executor_ids
        # 参与者列表
        self.participant_ids = participant_ids
        # 详情页url跳转地址
        self.detail_url = detail_url
        # 待办重复规则配置
        self.recurrence = recurrence
        # 待办提醒规则配置
        self.reminder = reminder
        # 待办通知配置（包含单聊卡片、ding通知、群聊卡片、同步日历、同步系统消息等通知能力）
        self.notify_configs = notify_configs
        # 当前操作者id
        self.operator_id = operator_id

    def validate(self):
        if self.detail_url:
            self.detail_url.validate()
        if self.reminder:
            self.reminder.validate()
        if self.notify_configs:
            self.notify_configs.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.source_id is not None:
            result['sourceId'] = self.source_id
        if self.subject is not None:
            result['subject'] = self.subject
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.description is not None:
            result['description'] = self.description
        if self.due_time is not None:
            result['dueTime'] = self.due_time
        if self.executor_ids is not None:
            result['executorIds'] = self.executor_ids
        if self.participant_ids is not None:
            result['participantIds'] = self.participant_ids
        if self.detail_url is not None:
            result['detailUrl'] = self.detail_url.to_map()
        if self.recurrence is not None:
            result['recurrence'] = self.recurrence
        if self.reminder is not None:
            result['reminder'] = self.reminder.to_map()
        if self.notify_configs is not None:
            result['notifyConfigs'] = self.notify_configs.to_map()
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sourceId') is not None:
            self.source_id = m.get('sourceId')
        if m.get('subject') is not None:
            self.subject = m.get('subject')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('dueTime') is not None:
            self.due_time = m.get('dueTime')
        if m.get('executorIds') is not None:
            self.executor_ids = m.get('executorIds')
        if m.get('participantIds') is not None:
            self.participant_ids = m.get('participantIds')
        if m.get('detailUrl') is not None:
            temp_model = CreateTodoTaskRequestDetailUrl()
            self.detail_url = temp_model.from_map(m['detailUrl'])
        if m.get('recurrence') is not None:
            self.recurrence = m.get('recurrence')
        if m.get('reminder') is not None:
            temp_model = CreateTodoTaskRequestReminder()
            self.reminder = temp_model.from_map(m['reminder'])
        if m.get('notifyConfigs') is not None:
            temp_model = CreateTodoTaskRequestNotifyConfigs()
            self.notify_configs = temp_model.from_map(m['notifyConfigs'])
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class CreateTodoTaskResponseBodyReminderRules(TeaModel):
    def __init__(
        self,
        base_time: str = None,
        offset: int = None,
    ):
        # 目前支持三种类型：tartDate: 相对开始时间；dueDate: 相对截止时间；customDate: 绝对时间
        self.base_time = base_time
        # 偏移值：baseTime 为 startDate 或者 dueDate 时，offset 为相对分钟的偏移值；baseTime 为 customDate 时，offset 为毫秒时间戳
        self.offset = offset

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.base_time is not None:
            result['baseTime'] = self.base_time
        if self.offset is not None:
            result['offset'] = self.offset
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('baseTime') is not None:
            self.base_time = m.get('baseTime')
        if m.get('offset') is not None:
            self.offset = m.get('offset')
        return self


class CreateTodoTaskResponseBodyReminder(TeaModel):
    def __init__(
        self,
        channel: int = None,
        rules: CreateTodoTaskResponseBodyReminderRules = None,
    ):
        # 提醒通道
        self.channel = channel
        # 提醒规则配置
        self.rules = rules

    def validate(self):
        if self.rules:
            self.rules.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.channel is not None:
            result['channel'] = self.channel
        if self.rules is not None:
            result['rules'] = self.rules.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('channel') is not None:
            self.channel = m.get('channel')
        if m.get('rules') is not None:
            temp_model = CreateTodoTaskResponseBodyReminderRules()
            self.rules = temp_model.from_map(m['rules'])
        return self


class CreateTodoTaskResponseBodyNotifyConfigs(TeaModel):
    def __init__(
        self,
        single_chat: str = None,
        group_chat: str = None,
        ding_notify: str = None,
        canlender: str = None,
    ):
        # 是否发送单聊卡片：value:"true/false" （发送则传true）
        self.single_chat = single_chat
        # 是否发送群聊卡片：value:"groupId"（发送则传对应群聊id）
        self.group_chat = group_chat
        # ding通知配置：value:"channel"（1钉弹框通知，2钉短信通知，3钉电话通知）
        self.ding_notify = ding_notify
        # 是否同步到日历：value:"true/false"（同步则传true）
        self.canlender = canlender

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.single_chat is not None:
            result['singleChat'] = self.single_chat
        if self.group_chat is not None:
            result['groupChat'] = self.group_chat
        if self.ding_notify is not None:
            result['dingNotify'] = self.ding_notify
        if self.canlender is not None:
            result['canlender'] = self.canlender
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('singleChat') is not None:
            self.single_chat = m.get('singleChat')
        if m.get('groupChat') is not None:
            self.group_chat = m.get('groupChat')
        if m.get('dingNotify') is not None:
            self.ding_notify = m.get('dingNotify')
        if m.get('canlender') is not None:
            self.canlender = m.get('canlender')
        return self


class CreateTodoTaskResponseBodyDetailUrl(TeaModel):
    def __init__(
        self,
        pc_url: str = None,
        app_url: str = None,
    ):
        # pc端详情页地址
        self.pc_url = pc_url
        # app端详情页地址
        self.app_url = app_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.pc_url is not None:
            result['pcUrl'] = self.pc_url
        if self.app_url is not None:
            result['appUrl'] = self.app_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pcUrl') is not None:
            self.pc_url = m.get('pcUrl')
        if m.get('appUrl') is not None:
            self.app_url = m.get('appUrl')
        return self


class CreateTodoTaskResponseBody(TeaModel):
    def __init__(
        self,
        id: str = None,
        subject: str = None,
        description: str = None,
        start_time: int = None,
        due_time: int = None,
        finish_time: int = None,
        done: bool = None,
        executor_ids: List[str] = None,
        participant_ids: List[str] = None,
        reminder: CreateTodoTaskResponseBodyReminder = None,
        notify_configs: CreateTodoTaskResponseBodyNotifyConfigs = None,
        detail_url: CreateTodoTaskResponseBodyDetailUrl = None,
        recurrence: str = None,
        source: str = None,
        source_id: str = None,
        created_time: int = None,
        modified_time: int = None,
        creator_id: str = None,
        modifier_id: str = None,
        tenant_id: str = None,
        biz_tag: str = None,
        request_id: str = None,
    ):
        # id
        self.id = id
        # 标题
        self.subject = subject
        # 描述
        self.description = description
        # 开始时间
        self.start_time = start_time
        # 截止时间
        self.due_time = due_time
        # 完成时间
        self.finish_time = finish_time
        # 完成状态
        self.done = done
        # 执行者列表
        self.executor_ids = executor_ids
        # 参与者列表
        self.participant_ids = participant_ids
        # 提醒规则
        self.reminder = reminder
        # 待办通知配置（包含单聊卡片、ding通知、群聊卡片、同步日历、同步系统消息等通知能力）
        self.notify_configs = notify_configs
        # 自定义详情页跳转配置
        self.detail_url = detail_url
        # 重复规则
        self.recurrence = recurrence
        # 业务来源
        self.source = source
        # 业务来源id
        self.source_id = source_id
        # 创建时间
        self.created_time = created_time
        # 更新时间
        self.modified_time = modified_time
        # 创建者
        self.creator_id = creator_id
        # 更新者
        self.modifier_id = modifier_id
        # 租户id
        self.tenant_id = tenant_id
        # 接入应用标识
        self.biz_tag = biz_tag
        # requestId
        self.request_id = request_id

    def validate(self):
        if self.reminder:
            self.reminder.validate()
        if self.notify_configs:
            self.notify_configs.validate()
        if self.detail_url:
            self.detail_url.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.subject is not None:
            result['subject'] = self.subject
        if self.description is not None:
            result['description'] = self.description
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.due_time is not None:
            result['dueTime'] = self.due_time
        if self.finish_time is not None:
            result['finishTime'] = self.finish_time
        if self.done is not None:
            result['done'] = self.done
        if self.executor_ids is not None:
            result['executorIds'] = self.executor_ids
        if self.participant_ids is not None:
            result['participantIds'] = self.participant_ids
        if self.reminder is not None:
            result['reminder'] = self.reminder.to_map()
        if self.notify_configs is not None:
            result['notifyConfigs'] = self.notify_configs.to_map()
        if self.detail_url is not None:
            result['detailUrl'] = self.detail_url.to_map()
        if self.recurrence is not None:
            result['recurrence'] = self.recurrence
        if self.source is not None:
            result['source'] = self.source
        if self.source_id is not None:
            result['sourceId'] = self.source_id
        if self.created_time is not None:
            result['createdTime'] = self.created_time
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.modifier_id is not None:
            result['modifierId'] = self.modifier_id
        if self.tenant_id is not None:
            result['tenantId'] = self.tenant_id
        if self.biz_tag is not None:
            result['bizTag'] = self.biz_tag
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('subject') is not None:
            self.subject = m.get('subject')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('dueTime') is not None:
            self.due_time = m.get('dueTime')
        if m.get('finishTime') is not None:
            self.finish_time = m.get('finishTime')
        if m.get('done') is not None:
            self.done = m.get('done')
        if m.get('executorIds') is not None:
            self.executor_ids = m.get('executorIds')
        if m.get('participantIds') is not None:
            self.participant_ids = m.get('participantIds')
        if m.get('reminder') is not None:
            temp_model = CreateTodoTaskResponseBodyReminder()
            self.reminder = temp_model.from_map(m['reminder'])
        if m.get('notifyConfigs') is not None:
            temp_model = CreateTodoTaskResponseBodyNotifyConfigs()
            self.notify_configs = temp_model.from_map(m['notifyConfigs'])
        if m.get('detailUrl') is not None:
            temp_model = CreateTodoTaskResponseBodyDetailUrl()
            self.detail_url = temp_model.from_map(m['detailUrl'])
        if m.get('recurrence') is not None:
            self.recurrence = m.get('recurrence')
        if m.get('source') is not None:
            self.source = m.get('source')
        if m.get('sourceId') is not None:
            self.source_id = m.get('sourceId')
        if m.get('createdTime') is not None:
            self.created_time = m.get('createdTime')
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('modifierId') is not None:
            self.modifier_id = m.get('modifierId')
        if m.get('tenantId') is not None:
            self.tenant_id = m.get('tenantId')
        if m.get('bizTag') is not None:
            self.biz_tag = m.get('bizTag')
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class CreateTodoTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateTodoTaskResponseBody = None,
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
            temp_model = CreateTodoTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


