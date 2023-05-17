# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List, Any


class CountTodoTasksHeaders(TeaModel):
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


class CountTodoTasksRequest(TeaModel):
    def __init__(
        self,
        category: str = None,
        from_due_time: int = None,
        is_done: bool = None,
        is_recycled: bool = None,
        role_types: List[List[str]] = None,
        to_due_time: int = None,
    ):
        self.category = category
        self.from_due_time = from_due_time
        self.is_done = is_done
        self.is_recycled = is_recycled
        self.role_types = role_types
        self.to_due_time = to_due_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.category is not None:
            result['category'] = self.category
        if self.from_due_time is not None:
            result['fromDueTime'] = self.from_due_time
        if self.is_done is not None:
            result['isDone'] = self.is_done
        if self.is_recycled is not None:
            result['isRecycled'] = self.is_recycled
        if self.role_types is not None:
            result['roleTypes'] = self.role_types
        if self.to_due_time is not None:
            result['toDueTime'] = self.to_due_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('category') is not None:
            self.category = m.get('category')
        if m.get('fromDueTime') is not None:
            self.from_due_time = m.get('fromDueTime')
        if m.get('isDone') is not None:
            self.is_done = m.get('isDone')
        if m.get('isRecycled') is not None:
            self.is_recycled = m.get('isRecycled')
        if m.get('roleTypes') is not None:
            self.role_types = m.get('roleTypes')
        if m.get('toDueTime') is not None:
            self.to_due_time = m.get('toDueTime')
        return self


class CountTodoTasksResponseBody(TeaModel):
    def __init__(
        self,
        result: int = None,
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


class CountTodoTasksResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CountTodoTasksResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = CountTodoTasksResponseBody()
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


class CreateTodoTaskRequestActionListParam(TeaModel):
    def __init__(
        self,
        body: str = None,
        header: Dict[str, Any] = None,
    ):
        self.body = body
        self.header = header

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.body is not None:
            result['body'] = self.body
        if self.header is not None:
            result['header'] = self.header
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('body') is not None:
            self.body = m.get('body')
        if m.get('header') is not None:
            self.header = m.get('header')
        return self


class CreateTodoTaskRequestActionList(TeaModel):
    def __init__(
        self,
        action_key: str = None,
        action_type: int = None,
        button_style_type: int = None,
        param: CreateTodoTaskRequestActionListParam = None,
        pc_url: str = None,
        title: str = None,
        url: str = None,
    ):
        self.action_key = action_key
        self.action_type = action_type
        self.button_style_type = button_style_type
        self.param = param
        self.pc_url = pc_url
        self.title = title
        self.url = url

    def validate(self):
        if self.param:
            self.param.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action_key is not None:
            result['actionKey'] = self.action_key
        if self.action_type is not None:
            result['actionType'] = self.action_type
        if self.button_style_type is not None:
            result['buttonStyleType'] = self.button_style_type
        if self.param is not None:
            result['param'] = self.param.to_map()
        if self.pc_url is not None:
            result['pcUrl'] = self.pc_url
        if self.title is not None:
            result['title'] = self.title
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionKey') is not None:
            self.action_key = m.get('actionKey')
        if m.get('actionType') is not None:
            self.action_type = m.get('actionType')
        if m.get('buttonStyleType') is not None:
            self.button_style_type = m.get('buttonStyleType')
        if m.get('param') is not None:
            temp_model = CreateTodoTaskRequestActionListParam()
            self.param = temp_model.from_map(m['param'])
        if m.get('pcUrl') is not None:
            self.pc_url = m.get('pcUrl')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class CreateTodoTaskRequestContentFieldList(TeaModel):
    def __init__(
        self,
        field_key: str = None,
        field_value: str = None,
    ):
        self.field_key = field_key
        self.field_value = field_value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_key is not None:
            result['fieldKey'] = self.field_key
        if self.field_value is not None:
            result['fieldValue'] = self.field_value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldKey') is not None:
            self.field_key = m.get('fieldKey')
        if m.get('fieldValue') is not None:
            self.field_value = m.get('fieldValue')
        return self


class CreateTodoTaskRequestDetailUrl(TeaModel):
    def __init__(
        self,
        app_url: str = None,
        pc_url: str = None,
    ):
        self.app_url = app_url
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


class CreateTodoTaskRequestNotifyConfigs(TeaModel):
    def __init__(
        self,
        ding_notify: str = None,
    ):
        self.ding_notify = ding_notify

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_notify is not None:
            result['dingNotify'] = self.ding_notify
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingNotify') is not None:
            self.ding_notify = m.get('dingNotify')
        return self


class CreateTodoTaskRequest(TeaModel):
    def __init__(
        self,
        action_list: List[CreateTodoTaskRequestActionList] = None,
        biz_category_id: str = None,
        content_field_list: List[CreateTodoTaskRequestContentFieldList] = None,
        creator_id: str = None,
        description: str = None,
        detail_url: CreateTodoTaskRequestDetailUrl = None,
        due_time: int = None,
        executor_ids: List[str] = None,
        is_only_show_executor: bool = None,
        notify_configs: CreateTodoTaskRequestNotifyConfigs = None,
        participant_ids: List[str] = None,
        priority: int = None,
        source_id: str = None,
        subject: str = None,
        operator_id: str = None,
    ):
        self.action_list = action_list
        self.biz_category_id = biz_category_id
        self.content_field_list = content_field_list
        self.creator_id = creator_id
        self.description = description
        self.detail_url = detail_url
        self.due_time = due_time
        self.executor_ids = executor_ids
        self.is_only_show_executor = is_only_show_executor
        self.notify_configs = notify_configs
        self.participant_ids = participant_ids
        self.priority = priority
        self.source_id = source_id
        self.subject = subject
        self.operator_id = operator_id

    def validate(self):
        if self.action_list:
            for k in self.action_list:
                if k:
                    k.validate()
        if self.content_field_list:
            for k in self.content_field_list:
                if k:
                    k.validate()
        if self.detail_url:
            self.detail_url.validate()
        if self.notify_configs:
            self.notify_configs.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['actionList'] = []
        if self.action_list is not None:
            for k in self.action_list:
                result['actionList'].append(k.to_map() if k else None)
        if self.biz_category_id is not None:
            result['bizCategoryId'] = self.biz_category_id
        result['contentFieldList'] = []
        if self.content_field_list is not None:
            for k in self.content_field_list:
                result['contentFieldList'].append(k.to_map() if k else None)
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.description is not None:
            result['description'] = self.description
        if self.detail_url is not None:
            result['detailUrl'] = self.detail_url.to_map()
        if self.due_time is not None:
            result['dueTime'] = self.due_time
        if self.executor_ids is not None:
            result['executorIds'] = self.executor_ids
        if self.is_only_show_executor is not None:
            result['isOnlyShowExecutor'] = self.is_only_show_executor
        if self.notify_configs is not None:
            result['notifyConfigs'] = self.notify_configs.to_map()
        if self.participant_ids is not None:
            result['participantIds'] = self.participant_ids
        if self.priority is not None:
            result['priority'] = self.priority
        if self.source_id is not None:
            result['sourceId'] = self.source_id
        if self.subject is not None:
            result['subject'] = self.subject
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.action_list = []
        if m.get('actionList') is not None:
            for k in m.get('actionList'):
                temp_model = CreateTodoTaskRequestActionList()
                self.action_list.append(temp_model.from_map(k))
        if m.get('bizCategoryId') is not None:
            self.biz_category_id = m.get('bizCategoryId')
        self.content_field_list = []
        if m.get('contentFieldList') is not None:
            for k in m.get('contentFieldList'):
                temp_model = CreateTodoTaskRequestContentFieldList()
                self.content_field_list.append(temp_model.from_map(k))
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('detailUrl') is not None:
            temp_model = CreateTodoTaskRequestDetailUrl()
            self.detail_url = temp_model.from_map(m['detailUrl'])
        if m.get('dueTime') is not None:
            self.due_time = m.get('dueTime')
        if m.get('executorIds') is not None:
            self.executor_ids = m.get('executorIds')
        if m.get('isOnlyShowExecutor') is not None:
            self.is_only_show_executor = m.get('isOnlyShowExecutor')
        if m.get('notifyConfigs') is not None:
            temp_model = CreateTodoTaskRequestNotifyConfigs()
            self.notify_configs = temp_model.from_map(m['notifyConfigs'])
        if m.get('participantIds') is not None:
            self.participant_ids = m.get('participantIds')
        if m.get('priority') is not None:
            self.priority = m.get('priority')
        if m.get('sourceId') is not None:
            self.source_id = m.get('sourceId')
        if m.get('subject') is not None:
            self.subject = m.get('subject')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class CreateTodoTaskResponseBodyContentFieldList(TeaModel):
    def __init__(
        self,
        field_key: str = None,
        field_value: str = None,
    ):
        self.field_key = field_key
        self.field_value = field_value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_key is not None:
            result['fieldKey'] = self.field_key
        if self.field_value is not None:
            result['fieldValue'] = self.field_value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldKey') is not None:
            self.field_key = m.get('fieldKey')
        if m.get('fieldValue') is not None:
            self.field_value = m.get('fieldValue')
        return self


class CreateTodoTaskResponseBodyDetailUrl(TeaModel):
    def __init__(
        self,
        app_url: str = None,
        pc_url: str = None,
    ):
        self.app_url = app_url
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


class CreateTodoTaskResponseBodyNotifyConfigs(TeaModel):
    def __init__(
        self,
        ding_notify: str = None,
    ):
        self.ding_notify = ding_notify

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_notify is not None:
            result['dingNotify'] = self.ding_notify
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingNotify') is not None:
            self.ding_notify = m.get('dingNotify')
        return self


class CreateTodoTaskResponseBody(TeaModel):
    def __init__(
        self,
        biz_tag: str = None,
        content_field_list: List[CreateTodoTaskResponseBodyContentFieldList] = None,
        created_time: int = None,
        creator_id: str = None,
        description: str = None,
        detail_url: CreateTodoTaskResponseBodyDetailUrl = None,
        done: bool = None,
        due_time: int = None,
        executor_ids: List[str] = None,
        finish_time: int = None,
        id: str = None,
        is_only_show_executor: bool = None,
        modified_time: int = None,
        modifier_id: str = None,
        notify_configs: CreateTodoTaskResponseBodyNotifyConfigs = None,
        participant_ids: List[str] = None,
        priority: int = None,
        request_id: str = None,
        source: str = None,
        source_id: str = None,
        start_time: int = None,
        subject: str = None,
    ):
        self.biz_tag = biz_tag
        self.content_field_list = content_field_list
        self.created_time = created_time
        self.creator_id = creator_id
        self.description = description
        self.detail_url = detail_url
        self.done = done
        self.due_time = due_time
        self.executor_ids = executor_ids
        self.finish_time = finish_time
        self.id = id
        self.is_only_show_executor = is_only_show_executor
        self.modified_time = modified_time
        self.modifier_id = modifier_id
        self.notify_configs = notify_configs
        self.participant_ids = participant_ids
        self.priority = priority
        self.request_id = request_id
        self.source = source
        self.source_id = source_id
        self.start_time = start_time
        self.subject = subject

    def validate(self):
        if self.content_field_list:
            for k in self.content_field_list:
                if k:
                    k.validate()
        if self.detail_url:
            self.detail_url.validate()
        if self.notify_configs:
            self.notify_configs.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_tag is not None:
            result['bizTag'] = self.biz_tag
        result['contentFieldList'] = []
        if self.content_field_list is not None:
            for k in self.content_field_list:
                result['contentFieldList'].append(k.to_map() if k else None)
        if self.created_time is not None:
            result['createdTime'] = self.created_time
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.description is not None:
            result['description'] = self.description
        if self.detail_url is not None:
            result['detailUrl'] = self.detail_url.to_map()
        if self.done is not None:
            result['done'] = self.done
        if self.due_time is not None:
            result['dueTime'] = self.due_time
        if self.executor_ids is not None:
            result['executorIds'] = self.executor_ids
        if self.finish_time is not None:
            result['finishTime'] = self.finish_time
        if self.id is not None:
            result['id'] = self.id
        if self.is_only_show_executor is not None:
            result['isOnlyShowExecutor'] = self.is_only_show_executor
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        if self.modifier_id is not None:
            result['modifierId'] = self.modifier_id
        if self.notify_configs is not None:
            result['notifyConfigs'] = self.notify_configs.to_map()
        if self.participant_ids is not None:
            result['participantIds'] = self.participant_ids
        if self.priority is not None:
            result['priority'] = self.priority
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.source is not None:
            result['source'] = self.source
        if self.source_id is not None:
            result['sourceId'] = self.source_id
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.subject is not None:
            result['subject'] = self.subject
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizTag') is not None:
            self.biz_tag = m.get('bizTag')
        self.content_field_list = []
        if m.get('contentFieldList') is not None:
            for k in m.get('contentFieldList'):
                temp_model = CreateTodoTaskResponseBodyContentFieldList()
                self.content_field_list.append(temp_model.from_map(k))
        if m.get('createdTime') is not None:
            self.created_time = m.get('createdTime')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('detailUrl') is not None:
            temp_model = CreateTodoTaskResponseBodyDetailUrl()
            self.detail_url = temp_model.from_map(m['detailUrl'])
        if m.get('done') is not None:
            self.done = m.get('done')
        if m.get('dueTime') is not None:
            self.due_time = m.get('dueTime')
        if m.get('executorIds') is not None:
            self.executor_ids = m.get('executorIds')
        if m.get('finishTime') is not None:
            self.finish_time = m.get('finishTime')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isOnlyShowExecutor') is not None:
            self.is_only_show_executor = m.get('isOnlyShowExecutor')
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        if m.get('modifierId') is not None:
            self.modifier_id = m.get('modifierId')
        if m.get('notifyConfigs') is not None:
            temp_model = CreateTodoTaskResponseBodyNotifyConfigs()
            self.notify_configs = temp_model.from_map(m['notifyConfigs'])
        if m.get('participantIds') is not None:
            self.participant_ids = m.get('participantIds')
        if m.get('priority') is not None:
            self.priority = m.get('priority')
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('source') is not None:
            self.source = m.get('source')
        if m.get('sourceId') is not None:
            self.source_id = m.get('sourceId')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('subject') is not None:
            self.subject = m.get('subject')
        return self


class CreateTodoTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateTodoTaskResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = CreateTodoTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateTodoTypeConfigHeaders(TeaModel):
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


class CreateTodoTypeConfigRequestActionList(TeaModel):
    def __init__(
        self,
        action_key: str = None,
        action_type: int = None,
        button_style_type: int = None,
        name_i18n: Dict[str, Any] = None,
        url: str = None,
    ):
        self.action_key = action_key
        self.action_type = action_type
        self.button_style_type = button_style_type
        self.name_i18n = name_i18n
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action_key is not None:
            result['actionKey'] = self.action_key
        if self.action_type is not None:
            result['actionType'] = self.action_type
        if self.button_style_type is not None:
            result['buttonStyleType'] = self.button_style_type
        if self.name_i18n is not None:
            result['nameI18n'] = self.name_i18n
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionKey') is not None:
            self.action_key = m.get('actionKey')
        if m.get('actionType') is not None:
            self.action_type = m.get('actionType')
        if m.get('buttonStyleType') is not None:
            self.button_style_type = m.get('buttonStyleType')
        if m.get('nameI18n') is not None:
            self.name_i18n = m.get('nameI18n')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class CreateTodoTypeConfigRequestContentFieldList(TeaModel):
    def __init__(
        self,
        field_key: str = None,
        field_type: str = None,
        name_i18n: Dict[str, Any] = None,
    ):
        self.field_key = field_key
        self.field_type = field_type
        self.name_i18n = name_i18n

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_key is not None:
            result['fieldKey'] = self.field_key
        if self.field_type is not None:
            result['fieldType'] = self.field_type
        if self.name_i18n is not None:
            result['nameI18n'] = self.name_i18n
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldKey') is not None:
            self.field_key = m.get('fieldKey')
        if m.get('fieldType') is not None:
            self.field_type = m.get('fieldType')
        if m.get('nameI18n') is not None:
            self.name_i18n = m.get('nameI18n')
        return self


class CreateTodoTypeConfigRequest(TeaModel):
    def __init__(
        self,
        action_list: List[CreateTodoTypeConfigRequestActionList] = None,
        card_type: int = None,
        content_field_list: List[CreateTodoTypeConfigRequestContentFieldList] = None,
        description: str = None,
        icon: str = None,
        pc_detail_url_open_mode: str = None,
        operator_id: str = None,
    ):
        self.action_list = action_list
        self.card_type = card_type
        self.content_field_list = content_field_list
        self.description = description
        self.icon = icon
        self.pc_detail_url_open_mode = pc_detail_url_open_mode
        self.operator_id = operator_id

    def validate(self):
        if self.action_list:
            for k in self.action_list:
                if k:
                    k.validate()
        if self.content_field_list:
            for k in self.content_field_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['actionList'] = []
        if self.action_list is not None:
            for k in self.action_list:
                result['actionList'].append(k.to_map() if k else None)
        if self.card_type is not None:
            result['cardType'] = self.card_type
        result['contentFieldList'] = []
        if self.content_field_list is not None:
            for k in self.content_field_list:
                result['contentFieldList'].append(k.to_map() if k else None)
        if self.description is not None:
            result['description'] = self.description
        if self.icon is not None:
            result['icon'] = self.icon
        if self.pc_detail_url_open_mode is not None:
            result['pcDetailUrlOpenMode'] = self.pc_detail_url_open_mode
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.action_list = []
        if m.get('actionList') is not None:
            for k in m.get('actionList'):
                temp_model = CreateTodoTypeConfigRequestActionList()
                self.action_list.append(temp_model.from_map(k))
        if m.get('cardType') is not None:
            self.card_type = m.get('cardType')
        self.content_field_list = []
        if m.get('contentFieldList') is not None:
            for k in m.get('contentFieldList'):
                temp_model = CreateTodoTypeConfigRequestContentFieldList()
                self.content_field_list.append(temp_model.from_map(k))
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('pcDetailUrlOpenMode') is not None:
            self.pc_detail_url_open_mode = m.get('pcDetailUrlOpenMode')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class CreateTodoTypeConfigResponseBodyActionList(TeaModel):
    def __init__(
        self,
        action_key: str = None,
        action_type: int = None,
        button_style_type: int = None,
        name_i18n: Dict[str, Any] = None,
        url: str = None,
    ):
        self.action_key = action_key
        self.action_type = action_type
        self.button_style_type = button_style_type
        self.name_i18n = name_i18n
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action_key is not None:
            result['actionKey'] = self.action_key
        if self.action_type is not None:
            result['actionType'] = self.action_type
        if self.button_style_type is not None:
            result['buttonStyleType'] = self.button_style_type
        if self.name_i18n is not None:
            result['nameI18n'] = self.name_i18n
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionKey') is not None:
            self.action_key = m.get('actionKey')
        if m.get('actionType') is not None:
            self.action_type = m.get('actionType')
        if m.get('buttonStyleType') is not None:
            self.button_style_type = m.get('buttonStyleType')
        if m.get('nameI18n') is not None:
            self.name_i18n = m.get('nameI18n')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class CreateTodoTypeConfigResponseBodyContentFieldList(TeaModel):
    def __init__(
        self,
        field_key: str = None,
        field_type: str = None,
        name_i18n: Dict[str, Any] = None,
    ):
        self.field_key = field_key
        self.field_type = field_type
        self.name_i18n = name_i18n

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_key is not None:
            result['fieldKey'] = self.field_key
        if self.field_type is not None:
            result['fieldType'] = self.field_type
        if self.name_i18n is not None:
            result['nameI18n'] = self.name_i18n
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldKey') is not None:
            self.field_key = m.get('fieldKey')
        if m.get('fieldType') is not None:
            self.field_type = m.get('fieldType')
        if m.get('nameI18n') is not None:
            self.name_i18n = m.get('nameI18n')
        return self


class CreateTodoTypeConfigResponseBody(TeaModel):
    def __init__(
        self,
        action_list: List[CreateTodoTypeConfigResponseBodyActionList] = None,
        biz_tag: str = None,
        card_type: int = None,
        content_field_list: List[CreateTodoTypeConfigResponseBodyContentFieldList] = None,
        created_time: int = None,
        creator_id: str = None,
        description: str = None,
        icon: str = None,
        id: str = None,
        modified_time: int = None,
        modifier_id: str = None,
        pc_detail_url_open_mode: str = None,
        request_id: str = None,
    ):
        self.action_list = action_list
        self.biz_tag = biz_tag
        self.card_type = card_type
        self.content_field_list = content_field_list
        self.created_time = created_time
        self.creator_id = creator_id
        self.description = description
        self.icon = icon
        self.id = id
        self.modified_time = modified_time
        self.modifier_id = modifier_id
        self.pc_detail_url_open_mode = pc_detail_url_open_mode
        self.request_id = request_id

    def validate(self):
        if self.action_list:
            for k in self.action_list:
                if k:
                    k.validate()
        if self.content_field_list:
            for k in self.content_field_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['actionList'] = []
        if self.action_list is not None:
            for k in self.action_list:
                result['actionList'].append(k.to_map() if k else None)
        if self.biz_tag is not None:
            result['bizTag'] = self.biz_tag
        if self.card_type is not None:
            result['cardType'] = self.card_type
        result['contentFieldList'] = []
        if self.content_field_list is not None:
            for k in self.content_field_list:
                result['contentFieldList'].append(k.to_map() if k else None)
        if self.created_time is not None:
            result['createdTime'] = self.created_time
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.description is not None:
            result['description'] = self.description
        if self.icon is not None:
            result['icon'] = self.icon
        if self.id is not None:
            result['id'] = self.id
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        if self.modifier_id is not None:
            result['modifierId'] = self.modifier_id
        if self.pc_detail_url_open_mode is not None:
            result['pcDetailUrlOpenMode'] = self.pc_detail_url_open_mode
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.action_list = []
        if m.get('actionList') is not None:
            for k in m.get('actionList'):
                temp_model = CreateTodoTypeConfigResponseBodyActionList()
                self.action_list.append(temp_model.from_map(k))
        if m.get('bizTag') is not None:
            self.biz_tag = m.get('bizTag')
        if m.get('cardType') is not None:
            self.card_type = m.get('cardType')
        self.content_field_list = []
        if m.get('contentFieldList') is not None:
            for k in m.get('contentFieldList'):
                temp_model = CreateTodoTypeConfigResponseBodyContentFieldList()
                self.content_field_list.append(temp_model.from_map(k))
        if m.get('createdTime') is not None:
            self.created_time = m.get('createdTime')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        if m.get('modifierId') is not None:
            self.modifier_id = m.get('modifierId')
        if m.get('pcDetailUrlOpenMode') is not None:
            self.pc_detail_url_open_mode = m.get('pcDetailUrlOpenMode')
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class CreateTodoTypeConfigResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateTodoTypeConfigResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = CreateTodoTypeConfigResponseBody()
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


class DeleteTodoTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteTodoTaskResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = DeleteTodoTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


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


class GetTodoTaskResponseBodyDetailUrl(TeaModel):
    def __init__(
        self,
        app_url: str = None,
        pc_url: str = None,
    ):
        self.app_url = app_url
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


class GetTodoTaskResponseBody(TeaModel):
    def __init__(
        self,
        biz_tag: str = None,
        card_type_id: str = None,
        created_time: int = None,
        creator_id: str = None,
        description: str = None,
        detail_url: GetTodoTaskResponseBodyDetailUrl = None,
        done: bool = None,
        due_time: int = None,
        executor_ids: List[str] = None,
        finish_time: int = None,
        id: str = None,
        is_only_show_executor: bool = None,
        modified_time: int = None,
        modifier_id: str = None,
        participant_ids: List[str] = None,
        priority: int = None,
        request_id: str = None,
        source: str = None,
        source_id: str = None,
        start_time: int = None,
        subject: str = None,
        tenant_id: str = None,
        tenant_type: str = None,
    ):
        self.biz_tag = biz_tag
        self.card_type_id = card_type_id
        self.created_time = created_time
        self.creator_id = creator_id
        self.description = description
        self.detail_url = detail_url
        self.done = done
        self.due_time = due_time
        self.executor_ids = executor_ids
        self.finish_time = finish_time
        self.id = id
        self.is_only_show_executor = is_only_show_executor
        self.modified_time = modified_time
        self.modifier_id = modifier_id
        self.participant_ids = participant_ids
        self.priority = priority
        self.request_id = request_id
        self.source = source
        self.source_id = source_id
        self.start_time = start_time
        self.subject = subject
        self.tenant_id = tenant_id
        self.tenant_type = tenant_type

    def validate(self):
        if self.detail_url:
            self.detail_url.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_tag is not None:
            result['bizTag'] = self.biz_tag
        if self.card_type_id is not None:
            result['cardTypeId'] = self.card_type_id
        if self.created_time is not None:
            result['createdTime'] = self.created_time
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.description is not None:
            result['description'] = self.description
        if self.detail_url is not None:
            result['detailUrl'] = self.detail_url.to_map()
        if self.done is not None:
            result['done'] = self.done
        if self.due_time is not None:
            result['dueTime'] = self.due_time
        if self.executor_ids is not None:
            result['executorIds'] = self.executor_ids
        if self.finish_time is not None:
            result['finishTime'] = self.finish_time
        if self.id is not None:
            result['id'] = self.id
        if self.is_only_show_executor is not None:
            result['isOnlyShowExecutor'] = self.is_only_show_executor
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        if self.modifier_id is not None:
            result['modifierId'] = self.modifier_id
        if self.participant_ids is not None:
            result['participantIds'] = self.participant_ids
        if self.priority is not None:
            result['priority'] = self.priority
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.source is not None:
            result['source'] = self.source
        if self.source_id is not None:
            result['sourceId'] = self.source_id
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.subject is not None:
            result['subject'] = self.subject
        if self.tenant_id is not None:
            result['tenantId'] = self.tenant_id
        if self.tenant_type is not None:
            result['tenantType'] = self.tenant_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizTag') is not None:
            self.biz_tag = m.get('bizTag')
        if m.get('cardTypeId') is not None:
            self.card_type_id = m.get('cardTypeId')
        if m.get('createdTime') is not None:
            self.created_time = m.get('createdTime')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('detailUrl') is not None:
            temp_model = GetTodoTaskResponseBodyDetailUrl()
            self.detail_url = temp_model.from_map(m['detailUrl'])
        if m.get('done') is not None:
            self.done = m.get('done')
        if m.get('dueTime') is not None:
            self.due_time = m.get('dueTime')
        if m.get('executorIds') is not None:
            self.executor_ids = m.get('executorIds')
        if m.get('finishTime') is not None:
            self.finish_time = m.get('finishTime')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isOnlyShowExecutor') is not None:
            self.is_only_show_executor = m.get('isOnlyShowExecutor')
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        if m.get('modifierId') is not None:
            self.modifier_id = m.get('modifierId')
        if m.get('participantIds') is not None:
            self.participant_ids = m.get('participantIds')
        if m.get('priority') is not None:
            self.priority = m.get('priority')
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('source') is not None:
            self.source = m.get('source')
        if m.get('sourceId') is not None:
            self.source_id = m.get('sourceId')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('subject') is not None:
            self.subject = m.get('subject')
        if m.get('tenantId') is not None:
            self.tenant_id = m.get('tenantId')
        if m.get('tenantType') is not None:
            self.tenant_type = m.get('tenantType')
        return self


class GetTodoTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetTodoTaskResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = GetTodoTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetTodoTaskBySourceIdHeaders(TeaModel):
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


class GetTodoTaskBySourceIdResponseBodyDetailUrl(TeaModel):
    def __init__(
        self,
        app_url: str = None,
        pc_url: str = None,
    ):
        self.app_url = app_url
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


class GetTodoTaskBySourceIdResponseBody(TeaModel):
    def __init__(
        self,
        biz_tag: str = None,
        created_time: int = None,
        creator_id: str = None,
        description: str = None,
        detail_url: GetTodoTaskBySourceIdResponseBodyDetailUrl = None,
        done: bool = None,
        due_time: int = None,
        executor_ids: List[str] = None,
        finish_time: int = None,
        id: str = None,
        is_only_show_executor: bool = None,
        modified_time: int = None,
        modifier_id: str = None,
        participant_ids: List[str] = None,
        priority: int = None,
        request_id: str = None,
        source: str = None,
        source_id: str = None,
        start_time: int = None,
        subject: str = None,
        tenant_id: str = None,
        tenant_type: str = None,
    ):
        self.biz_tag = biz_tag
        self.created_time = created_time
        self.creator_id = creator_id
        self.description = description
        self.detail_url = detail_url
        self.done = done
        self.due_time = due_time
        self.executor_ids = executor_ids
        self.finish_time = finish_time
        self.id = id
        self.is_only_show_executor = is_only_show_executor
        self.modified_time = modified_time
        self.modifier_id = modifier_id
        self.participant_ids = participant_ids
        self.priority = priority
        self.request_id = request_id
        self.source = source
        self.source_id = source_id
        self.start_time = start_time
        self.subject = subject
        self.tenant_id = tenant_id
        self.tenant_type = tenant_type

    def validate(self):
        if self.detail_url:
            self.detail_url.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_tag is not None:
            result['bizTag'] = self.biz_tag
        if self.created_time is not None:
            result['createdTime'] = self.created_time
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.description is not None:
            result['description'] = self.description
        if self.detail_url is not None:
            result['detailUrl'] = self.detail_url.to_map()
        if self.done is not None:
            result['done'] = self.done
        if self.due_time is not None:
            result['dueTime'] = self.due_time
        if self.executor_ids is not None:
            result['executorIds'] = self.executor_ids
        if self.finish_time is not None:
            result['finishTime'] = self.finish_time
        if self.id is not None:
            result['id'] = self.id
        if self.is_only_show_executor is not None:
            result['isOnlyShowExecutor'] = self.is_only_show_executor
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        if self.modifier_id is not None:
            result['modifierId'] = self.modifier_id
        if self.participant_ids is not None:
            result['participantIds'] = self.participant_ids
        if self.priority is not None:
            result['priority'] = self.priority
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.source is not None:
            result['source'] = self.source
        if self.source_id is not None:
            result['sourceId'] = self.source_id
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.subject is not None:
            result['subject'] = self.subject
        if self.tenant_id is not None:
            result['tenantId'] = self.tenant_id
        if self.tenant_type is not None:
            result['tenantType'] = self.tenant_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizTag') is not None:
            self.biz_tag = m.get('bizTag')
        if m.get('createdTime') is not None:
            self.created_time = m.get('createdTime')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('detailUrl') is not None:
            temp_model = GetTodoTaskBySourceIdResponseBodyDetailUrl()
            self.detail_url = temp_model.from_map(m['detailUrl'])
        if m.get('done') is not None:
            self.done = m.get('done')
        if m.get('dueTime') is not None:
            self.due_time = m.get('dueTime')
        if m.get('executorIds') is not None:
            self.executor_ids = m.get('executorIds')
        if m.get('finishTime') is not None:
            self.finish_time = m.get('finishTime')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isOnlyShowExecutor') is not None:
            self.is_only_show_executor = m.get('isOnlyShowExecutor')
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        if m.get('modifierId') is not None:
            self.modifier_id = m.get('modifierId')
        if m.get('participantIds') is not None:
            self.participant_ids = m.get('participantIds')
        if m.get('priority') is not None:
            self.priority = m.get('priority')
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('source') is not None:
            self.source = m.get('source')
        if m.get('sourceId') is not None:
            self.source_id = m.get('sourceId')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('subject') is not None:
            self.subject = m.get('subject')
        if m.get('tenantId') is not None:
            self.tenant_id = m.get('tenantId')
        if m.get('tenantType') is not None:
            self.tenant_type = m.get('tenantType')
        return self


class GetTodoTaskBySourceIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetTodoTaskBySourceIdResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = GetTodoTaskBySourceIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetTodoTaskDetailHeaders(TeaModel):
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


class GetTodoTaskDetailResponseBodyDetailUrl(TeaModel):
    def __init__(
        self,
        app_url: str = None,
        pc_url: str = None,
    ):
        self.app_url = app_url
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


class GetTodoTaskDetailResponseBodyExecutorStatus(TeaModel):
    def __init__(
        self,
        is_done: bool = None,
        user_id: str = None,
    ):
        self.is_done = is_done
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.is_done is not None:
            result['isDone'] = self.is_done
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isDone') is not None:
            self.is_done = m.get('isDone')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetTodoTaskDetailResponseBodyOrgInfo(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        name: str = None,
    ):
        self.corp_id = corp_id
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class GetTodoTaskDetailResponseBodyTodoCardViewTodoCardContentList(TeaModel):
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


class GetTodoTaskDetailResponseBodyTodoCardView(TeaModel):
    def __init__(
        self,
        action_type: str = None,
        card_type: str = None,
        circle_eltype: str = None,
        content_type: str = None,
        icon: str = None,
        todo_card_content_list: List[GetTodoTaskDetailResponseBodyTodoCardViewTodoCardContentList] = None,
        todo_card_title: str = None,
    ):
        self.action_type = action_type
        self.card_type = card_type
        self.circle_eltype = circle_eltype
        self.content_type = content_type
        self.icon = icon
        self.todo_card_content_list = todo_card_content_list
        self.todo_card_title = todo_card_title

    def validate(self):
        if self.todo_card_content_list:
            for k in self.todo_card_content_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action_type is not None:
            result['actionType'] = self.action_type
        if self.card_type is not None:
            result['cardType'] = self.card_type
        if self.circle_eltype is not None:
            result['circleELType'] = self.circle_eltype
        if self.content_type is not None:
            result['contentType'] = self.content_type
        if self.icon is not None:
            result['icon'] = self.icon
        result['todoCardContentList'] = []
        if self.todo_card_content_list is not None:
            for k in self.todo_card_content_list:
                result['todoCardContentList'].append(k.to_map() if k else None)
        if self.todo_card_title is not None:
            result['todoCardTitle'] = self.todo_card_title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionType') is not None:
            self.action_type = m.get('actionType')
        if m.get('cardType') is not None:
            self.card_type = m.get('cardType')
        if m.get('circleELType') is not None:
            self.circle_eltype = m.get('circleELType')
        if m.get('contentType') is not None:
            self.content_type = m.get('contentType')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        self.todo_card_content_list = []
        if m.get('todoCardContentList') is not None:
            for k in m.get('todoCardContentList'):
                temp_model = GetTodoTaskDetailResponseBodyTodoCardViewTodoCardContentList()
                self.todo_card_content_list.append(temp_model.from_map(k))
        if m.get('todoCardTitle') is not None:
            self.todo_card_title = m.get('todoCardTitle')
        return self


class GetTodoTaskDetailResponseBody(TeaModel):
    def __init__(
        self,
        biz_tag: str = None,
        category: str = None,
        created_time: int = None,
        creator_id: str = None,
        description: str = None,
        detail_url: GetTodoTaskDetailResponseBodyDetailUrl = None,
        done: bool = None,
        due_time: int = None,
        executor_ids: List[str] = None,
        executor_status: List[GetTodoTaskDetailResponseBodyExecutorStatus] = None,
        finish_time: int = None,
        id: str = None,
        is_only_show_executor: bool = None,
        modified_time: int = None,
        modifier_id: str = None,
        org_info: GetTodoTaskDetailResponseBodyOrgInfo = None,
        participant_ids: List[str] = None,
        priority: int = None,
        request_id: str = None,
        source: str = None,
        source_id: str = None,
        start_time: int = None,
        subject: str = None,
        tenant_id: str = None,
        tenant_type: str = None,
        todo_card_view: GetTodoTaskDetailResponseBodyTodoCardView = None,
    ):
        self.biz_tag = biz_tag
        self.category = category
        self.created_time = created_time
        self.creator_id = creator_id
        self.description = description
        self.detail_url = detail_url
        self.done = done
        self.due_time = due_time
        self.executor_ids = executor_ids
        self.executor_status = executor_status
        self.finish_time = finish_time
        self.id = id
        self.is_only_show_executor = is_only_show_executor
        self.modified_time = modified_time
        self.modifier_id = modifier_id
        self.org_info = org_info
        self.participant_ids = participant_ids
        self.priority = priority
        self.request_id = request_id
        self.source = source
        self.source_id = source_id
        self.start_time = start_time
        self.subject = subject
        self.tenant_id = tenant_id
        self.tenant_type = tenant_type
        self.todo_card_view = todo_card_view

    def validate(self):
        if self.detail_url:
            self.detail_url.validate()
        if self.executor_status:
            for k in self.executor_status:
                if k:
                    k.validate()
        if self.org_info:
            self.org_info.validate()
        if self.todo_card_view:
            self.todo_card_view.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_tag is not None:
            result['bizTag'] = self.biz_tag
        if self.category is not None:
            result['category'] = self.category
        if self.created_time is not None:
            result['createdTime'] = self.created_time
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.description is not None:
            result['description'] = self.description
        if self.detail_url is not None:
            result['detailUrl'] = self.detail_url.to_map()
        if self.done is not None:
            result['done'] = self.done
        if self.due_time is not None:
            result['dueTime'] = self.due_time
        if self.executor_ids is not None:
            result['executorIds'] = self.executor_ids
        result['executorStatus'] = []
        if self.executor_status is not None:
            for k in self.executor_status:
                result['executorStatus'].append(k.to_map() if k else None)
        if self.finish_time is not None:
            result['finishTime'] = self.finish_time
        if self.id is not None:
            result['id'] = self.id
        if self.is_only_show_executor is not None:
            result['isOnlyShowExecutor'] = self.is_only_show_executor
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        if self.modifier_id is not None:
            result['modifierId'] = self.modifier_id
        if self.org_info is not None:
            result['orgInfo'] = self.org_info.to_map()
        if self.participant_ids is not None:
            result['participantIds'] = self.participant_ids
        if self.priority is not None:
            result['priority'] = self.priority
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.source is not None:
            result['source'] = self.source
        if self.source_id is not None:
            result['sourceId'] = self.source_id
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.subject is not None:
            result['subject'] = self.subject
        if self.tenant_id is not None:
            result['tenantId'] = self.tenant_id
        if self.tenant_type is not None:
            result['tenantType'] = self.tenant_type
        if self.todo_card_view is not None:
            result['todoCardView'] = self.todo_card_view.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizTag') is not None:
            self.biz_tag = m.get('bizTag')
        if m.get('category') is not None:
            self.category = m.get('category')
        if m.get('createdTime') is not None:
            self.created_time = m.get('createdTime')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('detailUrl') is not None:
            temp_model = GetTodoTaskDetailResponseBodyDetailUrl()
            self.detail_url = temp_model.from_map(m['detailUrl'])
        if m.get('done') is not None:
            self.done = m.get('done')
        if m.get('dueTime') is not None:
            self.due_time = m.get('dueTime')
        if m.get('executorIds') is not None:
            self.executor_ids = m.get('executorIds')
        self.executor_status = []
        if m.get('executorStatus') is not None:
            for k in m.get('executorStatus'):
                temp_model = GetTodoTaskDetailResponseBodyExecutorStatus()
                self.executor_status.append(temp_model.from_map(k))
        if m.get('finishTime') is not None:
            self.finish_time = m.get('finishTime')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isOnlyShowExecutor') is not None:
            self.is_only_show_executor = m.get('isOnlyShowExecutor')
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        if m.get('modifierId') is not None:
            self.modifier_id = m.get('modifierId')
        if m.get('orgInfo') is not None:
            temp_model = GetTodoTaskDetailResponseBodyOrgInfo()
            self.org_info = temp_model.from_map(m['orgInfo'])
        if m.get('participantIds') is not None:
            self.participant_ids = m.get('participantIds')
        if m.get('priority') is not None:
            self.priority = m.get('priority')
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('source') is not None:
            self.source = m.get('source')
        if m.get('sourceId') is not None:
            self.source_id = m.get('sourceId')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('subject') is not None:
            self.subject = m.get('subject')
        if m.get('tenantId') is not None:
            self.tenant_id = m.get('tenantId')
        if m.get('tenantType') is not None:
            self.tenant_type = m.get('tenantType')
        if m.get('todoCardView') is not None:
            temp_model = GetTodoTaskDetailResponseBodyTodoCardView()
            self.todo_card_view = temp_model.from_map(m['todoCardView'])
        return self


class GetTodoTaskDetailResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetTodoTaskDetailResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = GetTodoTaskDetailResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetTodoTypeConfigHeaders(TeaModel):
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


class GetTodoTypeConfigResponseBodyActionList(TeaModel):
    def __init__(
        self,
        action_key: str = None,
        action_type: int = None,
        button_style_type: int = None,
        name_i18n: Dict[str, Any] = None,
        url: str = None,
    ):
        self.action_key = action_key
        self.action_type = action_type
        self.button_style_type = button_style_type
        self.name_i18n = name_i18n
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action_key is not None:
            result['actionKey'] = self.action_key
        if self.action_type is not None:
            result['actionType'] = self.action_type
        if self.button_style_type is not None:
            result['buttonStyleType'] = self.button_style_type
        if self.name_i18n is not None:
            result['nameI18n'] = self.name_i18n
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionKey') is not None:
            self.action_key = m.get('actionKey')
        if m.get('actionType') is not None:
            self.action_type = m.get('actionType')
        if m.get('buttonStyleType') is not None:
            self.button_style_type = m.get('buttonStyleType')
        if m.get('nameI18n') is not None:
            self.name_i18n = m.get('nameI18n')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class GetTodoTypeConfigResponseBodyContentFieldList(TeaModel):
    def __init__(
        self,
        field_key: str = None,
        field_type: str = None,
        name_i18n: Dict[str, Any] = None,
    ):
        self.field_key = field_key
        self.field_type = field_type
        self.name_i18n = name_i18n

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_key is not None:
            result['fieldKey'] = self.field_key
        if self.field_type is not None:
            result['fieldType'] = self.field_type
        if self.name_i18n is not None:
            result['nameI18n'] = self.name_i18n
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldKey') is not None:
            self.field_key = m.get('fieldKey')
        if m.get('fieldType') is not None:
            self.field_type = m.get('fieldType')
        if m.get('nameI18n') is not None:
            self.name_i18n = m.get('nameI18n')
        return self


class GetTodoTypeConfigResponseBody(TeaModel):
    def __init__(
        self,
        action_list: List[GetTodoTypeConfigResponseBodyActionList] = None,
        biz_tag: str = None,
        card_type: int = None,
        content_field_list: List[GetTodoTypeConfigResponseBodyContentFieldList] = None,
        created_time: int = None,
        creator_id: str = None,
        description: str = None,
        icon: str = None,
        id: str = None,
        modified_time: int = None,
        modifier_id: str = None,
        pc_detail_url_open_mode: str = None,
        request_id: str = None,
    ):
        self.action_list = action_list
        self.biz_tag = biz_tag
        self.card_type = card_type
        self.content_field_list = content_field_list
        self.created_time = created_time
        self.creator_id = creator_id
        self.description = description
        self.icon = icon
        self.id = id
        self.modified_time = modified_time
        self.modifier_id = modifier_id
        self.pc_detail_url_open_mode = pc_detail_url_open_mode
        self.request_id = request_id

    def validate(self):
        if self.action_list:
            for k in self.action_list:
                if k:
                    k.validate()
        if self.content_field_list:
            for k in self.content_field_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['actionList'] = []
        if self.action_list is not None:
            for k in self.action_list:
                result['actionList'].append(k.to_map() if k else None)
        if self.biz_tag is not None:
            result['bizTag'] = self.biz_tag
        if self.card_type is not None:
            result['cardType'] = self.card_type
        result['contentFieldList'] = []
        if self.content_field_list is not None:
            for k in self.content_field_list:
                result['contentFieldList'].append(k.to_map() if k else None)
        if self.created_time is not None:
            result['createdTime'] = self.created_time
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.description is not None:
            result['description'] = self.description
        if self.icon is not None:
            result['icon'] = self.icon
        if self.id is not None:
            result['id'] = self.id
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        if self.modifier_id is not None:
            result['modifierId'] = self.modifier_id
        if self.pc_detail_url_open_mode is not None:
            result['pcDetailUrlOpenMode'] = self.pc_detail_url_open_mode
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.action_list = []
        if m.get('actionList') is not None:
            for k in m.get('actionList'):
                temp_model = GetTodoTypeConfigResponseBodyActionList()
                self.action_list.append(temp_model.from_map(k))
        if m.get('bizTag') is not None:
            self.biz_tag = m.get('bizTag')
        if m.get('cardType') is not None:
            self.card_type = m.get('cardType')
        self.content_field_list = []
        if m.get('contentFieldList') is not None:
            for k in m.get('contentFieldList'):
                temp_model = GetTodoTypeConfigResponseBodyContentFieldList()
                self.content_field_list.append(temp_model.from_map(k))
        if m.get('createdTime') is not None:
            self.created_time = m.get('createdTime')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        if m.get('modifierId') is not None:
            self.modifier_id = m.get('modifierId')
        if m.get('pcDetailUrlOpenMode') is not None:
            self.pc_detail_url_open_mode = m.get('pcDetailUrlOpenMode')
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class GetTodoTypeConfigResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetTodoTypeConfigResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = GetTodoTypeConfigResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryOrgTodoByUserHeaders(TeaModel):
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


class QueryOrgTodoByUserRequest(TeaModel):
    def __init__(
        self,
        from_due_time: int = None,
        is_done: bool = None,
        max_results: int = None,
        next_token: str = None,
        role_types: List[List[str]] = None,
        subject: str = None,
        to_due_time: int = None,
    ):
        self.from_due_time = from_due_time
        self.is_done = is_done
        self.max_results = max_results
        self.next_token = next_token
        self.role_types = role_types
        self.subject = subject
        self.to_due_time = to_due_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.from_due_time is not None:
            result['fromDueTime'] = self.from_due_time
        if self.is_done is not None:
            result['isDone'] = self.is_done
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.role_types is not None:
            result['roleTypes'] = self.role_types
        if self.subject is not None:
            result['subject'] = self.subject
        if self.to_due_time is not None:
            result['toDueTime'] = self.to_due_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fromDueTime') is not None:
            self.from_due_time = m.get('fromDueTime')
        if m.get('isDone') is not None:
            self.is_done = m.get('isDone')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('roleTypes') is not None:
            self.role_types = m.get('roleTypes')
        if m.get('subject') is not None:
            self.subject = m.get('subject')
        if m.get('toDueTime') is not None:
            self.to_due_time = m.get('toDueTime')
        return self


class QueryOrgTodoByUserResponseBodyTodoCardsDetailUrl(TeaModel):
    def __init__(
        self,
        app_url: str = None,
        pc_url: str = None,
    ):
        self.app_url = app_url
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


class QueryOrgTodoByUserResponseBodyTodoCards(TeaModel):
    def __init__(
        self,
        biz_tag: str = None,
        created_time: int = None,
        creator_id: str = None,
        detail_url: QueryOrgTodoByUserResponseBodyTodoCardsDetailUrl = None,
        due_time: int = None,
        is_done: bool = None,
        modified_time: int = None,
        priority: int = None,
        source_ext: str = None,
        source_id: str = None,
        subject: str = None,
        task_id: str = None,
    ):
        self.biz_tag = biz_tag
        self.created_time = created_time
        self.creator_id = creator_id
        self.detail_url = detail_url
        self.due_time = due_time
        self.is_done = is_done
        self.modified_time = modified_time
        self.priority = priority
        self.source_ext = source_ext
        self.source_id = source_id
        self.subject = subject
        self.task_id = task_id

    def validate(self):
        if self.detail_url:
            self.detail_url.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_tag is not None:
            result['bizTag'] = self.biz_tag
        if self.created_time is not None:
            result['createdTime'] = self.created_time
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.detail_url is not None:
            result['detailUrl'] = self.detail_url.to_map()
        if self.due_time is not None:
            result['dueTime'] = self.due_time
        if self.is_done is not None:
            result['isDone'] = self.is_done
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        if self.priority is not None:
            result['priority'] = self.priority
        if self.source_ext is not None:
            result['sourceExt'] = self.source_ext
        if self.source_id is not None:
            result['sourceId'] = self.source_id
        if self.subject is not None:
            result['subject'] = self.subject
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizTag') is not None:
            self.biz_tag = m.get('bizTag')
        if m.get('createdTime') is not None:
            self.created_time = m.get('createdTime')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('detailUrl') is not None:
            temp_model = QueryOrgTodoByUserResponseBodyTodoCardsDetailUrl()
            self.detail_url = temp_model.from_map(m['detailUrl'])
        if m.get('dueTime') is not None:
            self.due_time = m.get('dueTime')
        if m.get('isDone') is not None:
            self.is_done = m.get('isDone')
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        if m.get('priority') is not None:
            self.priority = m.get('priority')
        if m.get('sourceExt') is not None:
            self.source_ext = m.get('sourceExt')
        if m.get('sourceId') is not None:
            self.source_id = m.get('sourceId')
        if m.get('subject') is not None:
            self.subject = m.get('subject')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class QueryOrgTodoByUserResponseBody(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        todo_cards: List[QueryOrgTodoByUserResponseBodyTodoCards] = None,
    ):
        self.max_results = max_results
        self.next_token = next_token
        self.todo_cards = todo_cards

    def validate(self):
        if self.todo_cards:
            for k in self.todo_cards:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['todoCards'] = []
        if self.todo_cards is not None:
            for k in self.todo_cards:
                result['todoCards'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.todo_cards = []
        if m.get('todoCards') is not None:
            for k in m.get('todoCards'):
                temp_model = QueryOrgTodoByUserResponseBodyTodoCards()
                self.todo_cards.append(temp_model.from_map(k))
        return self


class QueryOrgTodoByUserResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryOrgTodoByUserResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = QueryOrgTodoByUserResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryOrgTodoTasksHeaders(TeaModel):
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


class QueryOrgTodoTasksRequest(TeaModel):
    def __init__(
        self,
        is_done: bool = None,
        next_token: str = None,
    ):
        self.is_done = is_done
        self.next_token = next_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.is_done is not None:
            result['isDone'] = self.is_done
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isDone') is not None:
            self.is_done = m.get('isDone')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class QueryOrgTodoTasksResponseBodyTodoCardsDetailUrl(TeaModel):
    def __init__(
        self,
        app_url: str = None,
        pc_url: str = None,
    ):
        self.app_url = app_url
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


class QueryOrgTodoTasksResponseBodyTodoCards(TeaModel):
    def __init__(
        self,
        biz_tag: str = None,
        created_time: int = None,
        creator_id: str = None,
        detail_url: QueryOrgTodoTasksResponseBodyTodoCardsDetailUrl = None,
        due_time: int = None,
        is_done: bool = None,
        modified_time: int = None,
        priority: int = None,
        source_id: str = None,
        subject: str = None,
        task_id: str = None,
    ):
        self.biz_tag = biz_tag
        self.created_time = created_time
        self.creator_id = creator_id
        self.detail_url = detail_url
        self.due_time = due_time
        self.is_done = is_done
        self.modified_time = modified_time
        self.priority = priority
        self.source_id = source_id
        self.subject = subject
        self.task_id = task_id

    def validate(self):
        if self.detail_url:
            self.detail_url.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_tag is not None:
            result['bizTag'] = self.biz_tag
        if self.created_time is not None:
            result['createdTime'] = self.created_time
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.detail_url is not None:
            result['detailUrl'] = self.detail_url.to_map()
        if self.due_time is not None:
            result['dueTime'] = self.due_time
        if self.is_done is not None:
            result['isDone'] = self.is_done
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        if self.priority is not None:
            result['priority'] = self.priority
        if self.source_id is not None:
            result['sourceId'] = self.source_id
        if self.subject is not None:
            result['subject'] = self.subject
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizTag') is not None:
            self.biz_tag = m.get('bizTag')
        if m.get('createdTime') is not None:
            self.created_time = m.get('createdTime')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('detailUrl') is not None:
            temp_model = QueryOrgTodoTasksResponseBodyTodoCardsDetailUrl()
            self.detail_url = temp_model.from_map(m['detailUrl'])
        if m.get('dueTime') is not None:
            self.due_time = m.get('dueTime')
        if m.get('isDone') is not None:
            self.is_done = m.get('isDone')
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        if m.get('priority') is not None:
            self.priority = m.get('priority')
        if m.get('sourceId') is not None:
            self.source_id = m.get('sourceId')
        if m.get('subject') is not None:
            self.subject = m.get('subject')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class QueryOrgTodoTasksResponseBody(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        todo_cards: List[QueryOrgTodoTasksResponseBodyTodoCards] = None,
    ):
        self.next_token = next_token
        self.todo_cards = todo_cards

    def validate(self):
        if self.todo_cards:
            for k in self.todo_cards:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['todoCards'] = []
        if self.todo_cards is not None:
            for k in self.todo_cards:
                result['todoCards'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.todo_cards = []
        if m.get('todoCards') is not None:
            for k in m.get('todoCards'):
                temp_model = QueryOrgTodoTasksResponseBodyTodoCards()
                self.todo_cards.append(temp_model.from_map(k))
        return self


class QueryOrgTodoTasksResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryOrgTodoTasksResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = QueryOrgTodoTasksResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryTodoTasksHeaders(TeaModel):
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


class QueryTodoTasksRequest(TeaModel):
    def __init__(
        self,
        category: str = None,
        from_due_time: int = None,
        is_done: bool = None,
        is_recycled: bool = None,
        next_token: str = None,
        order_by: str = None,
        order_direction: str = None,
        role_types: List[List[str]] = None,
        to_due_time: int = None,
    ):
        self.category = category
        self.from_due_time = from_due_time
        self.is_done = is_done
        self.is_recycled = is_recycled
        self.next_token = next_token
        self.order_by = order_by
        self.order_direction = order_direction
        self.role_types = role_types
        self.to_due_time = to_due_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.category is not None:
            result['category'] = self.category
        if self.from_due_time is not None:
            result['fromDueTime'] = self.from_due_time
        if self.is_done is not None:
            result['isDone'] = self.is_done
        if self.is_recycled is not None:
            result['isRecycled'] = self.is_recycled
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.order_by is not None:
            result['orderBy'] = self.order_by
        if self.order_direction is not None:
            result['orderDirection'] = self.order_direction
        if self.role_types is not None:
            result['roleTypes'] = self.role_types
        if self.to_due_time is not None:
            result['toDueTime'] = self.to_due_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('category') is not None:
            self.category = m.get('category')
        if m.get('fromDueTime') is not None:
            self.from_due_time = m.get('fromDueTime')
        if m.get('isDone') is not None:
            self.is_done = m.get('isDone')
        if m.get('isRecycled') is not None:
            self.is_recycled = m.get('isRecycled')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('orderBy') is not None:
            self.order_by = m.get('orderBy')
        if m.get('orderDirection') is not None:
            self.order_direction = m.get('orderDirection')
        if m.get('roleTypes') is not None:
            self.role_types = m.get('roleTypes')
        if m.get('toDueTime') is not None:
            self.to_due_time = m.get('toDueTime')
        return self


class QueryTodoTasksResponseBodyTodoCardsDetailUrl(TeaModel):
    def __init__(
        self,
        app_url: str = None,
        pc_url: str = None,
    ):
        self.app_url = app_url
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


class QueryTodoTasksResponseBodyTodoCardsOrgInfo(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        name: str = None,
    ):
        self.corp_id = corp_id
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class QueryTodoTasksResponseBodyTodoCardsOriginalSource(TeaModel):
    def __init__(
        self,
        source_title: str = None,
    ):
        self.source_title = source_title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.source_title is not None:
            result['sourceTitle'] = self.source_title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sourceTitle') is not None:
            self.source_title = m.get('sourceTitle')
        return self


class QueryTodoTasksResponseBodyTodoCardsTodoCardViewTodoCardContentList(TeaModel):
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


class QueryTodoTasksResponseBodyTodoCardsTodoCardView(TeaModel):
    def __init__(
        self,
        action_type: str = None,
        card_type: str = None,
        circle_eltype: str = None,
        content_type: str = None,
        icon: str = None,
        todo_card_content_list: List[QueryTodoTasksResponseBodyTodoCardsTodoCardViewTodoCardContentList] = None,
        todo_card_title: str = None,
    ):
        self.action_type = action_type
        self.card_type = card_type
        self.circle_eltype = circle_eltype
        self.content_type = content_type
        self.icon = icon
        self.todo_card_content_list = todo_card_content_list
        self.todo_card_title = todo_card_title

    def validate(self):
        if self.todo_card_content_list:
            for k in self.todo_card_content_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action_type is not None:
            result['actionType'] = self.action_type
        if self.card_type is not None:
            result['cardType'] = self.card_type
        if self.circle_eltype is not None:
            result['circleELType'] = self.circle_eltype
        if self.content_type is not None:
            result['contentType'] = self.content_type
        if self.icon is not None:
            result['icon'] = self.icon
        result['todoCardContentList'] = []
        if self.todo_card_content_list is not None:
            for k in self.todo_card_content_list:
                result['todoCardContentList'].append(k.to_map() if k else None)
        if self.todo_card_title is not None:
            result['todoCardTitle'] = self.todo_card_title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionType') is not None:
            self.action_type = m.get('actionType')
        if m.get('cardType') is not None:
            self.card_type = m.get('cardType')
        if m.get('circleELType') is not None:
            self.circle_eltype = m.get('circleELType')
        if m.get('contentType') is not None:
            self.content_type = m.get('contentType')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        self.todo_card_content_list = []
        if m.get('todoCardContentList') is not None:
            for k in m.get('todoCardContentList'):
                temp_model = QueryTodoTasksResponseBodyTodoCardsTodoCardViewTodoCardContentList()
                self.todo_card_content_list.append(temp_model.from_map(k))
        if m.get('todoCardTitle') is not None:
            self.todo_card_title = m.get('todoCardTitle')
        return self


class QueryTodoTasksResponseBodyTodoCards(TeaModel):
    def __init__(
        self,
        biz_tag: str = None,
        category: str = None,
        created_time: int = None,
        creator_id: str = None,
        detail_url: QueryTodoTasksResponseBodyTodoCardsDetailUrl = None,
        due_time: int = None,
        is_done: bool = None,
        modified_time: int = None,
        org_info: QueryTodoTasksResponseBodyTodoCardsOrgInfo = None,
        original_source: QueryTodoTasksResponseBodyTodoCardsOriginalSource = None,
        priority: int = None,
        source_id: str = None,
        subject: str = None,
        task_id: str = None,
        todo_card_view: QueryTodoTasksResponseBodyTodoCardsTodoCardView = None,
        todo_status: str = None,
    ):
        self.biz_tag = biz_tag
        self.category = category
        self.created_time = created_time
        self.creator_id = creator_id
        self.detail_url = detail_url
        self.due_time = due_time
        self.is_done = is_done
        self.modified_time = modified_time
        self.org_info = org_info
        self.original_source = original_source
        self.priority = priority
        self.source_id = source_id
        self.subject = subject
        self.task_id = task_id
        self.todo_card_view = todo_card_view
        self.todo_status = todo_status

    def validate(self):
        if self.detail_url:
            self.detail_url.validate()
        if self.org_info:
            self.org_info.validate()
        if self.original_source:
            self.original_source.validate()
        if self.todo_card_view:
            self.todo_card_view.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_tag is not None:
            result['bizTag'] = self.biz_tag
        if self.category is not None:
            result['category'] = self.category
        if self.created_time is not None:
            result['createdTime'] = self.created_time
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.detail_url is not None:
            result['detailUrl'] = self.detail_url.to_map()
        if self.due_time is not None:
            result['dueTime'] = self.due_time
        if self.is_done is not None:
            result['isDone'] = self.is_done
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        if self.org_info is not None:
            result['orgInfo'] = self.org_info.to_map()
        if self.original_source is not None:
            result['originalSource'] = self.original_source.to_map()
        if self.priority is not None:
            result['priority'] = self.priority
        if self.source_id is not None:
            result['sourceId'] = self.source_id
        if self.subject is not None:
            result['subject'] = self.subject
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.todo_card_view is not None:
            result['todoCardView'] = self.todo_card_view.to_map()
        if self.todo_status is not None:
            result['todoStatus'] = self.todo_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizTag') is not None:
            self.biz_tag = m.get('bizTag')
        if m.get('category') is not None:
            self.category = m.get('category')
        if m.get('createdTime') is not None:
            self.created_time = m.get('createdTime')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('detailUrl') is not None:
            temp_model = QueryTodoTasksResponseBodyTodoCardsDetailUrl()
            self.detail_url = temp_model.from_map(m['detailUrl'])
        if m.get('dueTime') is not None:
            self.due_time = m.get('dueTime')
        if m.get('isDone') is not None:
            self.is_done = m.get('isDone')
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        if m.get('orgInfo') is not None:
            temp_model = QueryTodoTasksResponseBodyTodoCardsOrgInfo()
            self.org_info = temp_model.from_map(m['orgInfo'])
        if m.get('originalSource') is not None:
            temp_model = QueryTodoTasksResponseBodyTodoCardsOriginalSource()
            self.original_source = temp_model.from_map(m['originalSource'])
        if m.get('priority') is not None:
            self.priority = m.get('priority')
        if m.get('sourceId') is not None:
            self.source_id = m.get('sourceId')
        if m.get('subject') is not None:
            self.subject = m.get('subject')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('todoCardView') is not None:
            temp_model = QueryTodoTasksResponseBodyTodoCardsTodoCardView()
            self.todo_card_view = temp_model.from_map(m['todoCardView'])
        if m.get('todoStatus') is not None:
            self.todo_status = m.get('todoStatus')
        return self


class QueryTodoTasksResponseBody(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        todo_cards: List[QueryTodoTasksResponseBodyTodoCards] = None,
        total_count: int = None,
    ):
        self.next_token = next_token
        self.todo_cards = todo_cards
        self.total_count = total_count

    def validate(self):
        if self.todo_cards:
            for k in self.todo_cards:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['todoCards'] = []
        if self.todo_cards is not None:
            for k in self.todo_cards:
                result['todoCards'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.todo_cards = []
        if m.get('todoCards') is not None:
            for k in m.get('todoCards'):
                temp_model = QueryTodoTasksResponseBodyTodoCards()
                self.todo_cards.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class QueryTodoTasksResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryTodoTasksResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = QueryTodoTasksResponseBody()
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


class UpdateTodoTaskRequest(TeaModel):
    def __init__(
        self,
        description: str = None,
        done: bool = None,
        due_time: int = None,
        executor_ids: List[str] = None,
        participant_ids: List[str] = None,
        subject: str = None,
        operator_id: str = None,
    ):
        self.description = description
        self.done = done
        self.due_time = due_time
        self.executor_ids = executor_ids
        self.participant_ids = participant_ids
        self.subject = subject
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.description is not None:
            result['description'] = self.description
        if self.done is not None:
            result['done'] = self.done
        if self.due_time is not None:
            result['dueTime'] = self.due_time
        if self.executor_ids is not None:
            result['executorIds'] = self.executor_ids
        if self.participant_ids is not None:
            result['participantIds'] = self.participant_ids
        if self.subject is not None:
            result['subject'] = self.subject
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('done') is not None:
            self.done = m.get('done')
        if m.get('dueTime') is not None:
            self.due_time = m.get('dueTime')
        if m.get('executorIds') is not None:
            self.executor_ids = m.get('executorIds')
        if m.get('participantIds') is not None:
            self.participant_ids = m.get('participantIds')
        if m.get('subject') is not None:
            self.subject = m.get('subject')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class UpdateTodoTaskResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
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


class UpdateTodoTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateTodoTaskResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = UpdateTodoTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateTodoTaskExecutorStatusHeaders(TeaModel):
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


class UpdateTodoTaskExecutorStatusRequestExecutorStatusList(TeaModel):
    def __init__(
        self,
        id: str = None,
        is_done: bool = None,
    ):
        self.id = id
        self.is_done = is_done

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.is_done is not None:
            result['isDone'] = self.is_done
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isDone') is not None:
            self.is_done = m.get('isDone')
        return self


class UpdateTodoTaskExecutorStatusRequest(TeaModel):
    def __init__(
        self,
        executor_status_list: List[UpdateTodoTaskExecutorStatusRequestExecutorStatusList] = None,
        operator_id: str = None,
    ):
        self.executor_status_list = executor_status_list
        self.operator_id = operator_id

    def validate(self):
        if self.executor_status_list:
            for k in self.executor_status_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['executorStatusList'] = []
        if self.executor_status_list is not None:
            for k in self.executor_status_list:
                result['executorStatusList'].append(k.to_map() if k else None)
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.executor_status_list = []
        if m.get('executorStatusList') is not None:
            for k in m.get('executorStatusList'):
                temp_model = UpdateTodoTaskExecutorStatusRequestExecutorStatusList()
                self.executor_status_list.append(temp_model.from_map(k))
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class UpdateTodoTaskExecutorStatusResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
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


class UpdateTodoTaskExecutorStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateTodoTaskExecutorStatusResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = UpdateTodoTaskExecutorStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateTodoTypeConfigHeaders(TeaModel):
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


class UpdateTodoTypeConfigRequestActionList(TeaModel):
    def __init__(
        self,
        action_key: str = None,
        action_type: int = None,
        button_style_type: int = None,
        name_i18n: Dict[str, Any] = None,
        url: str = None,
    ):
        self.action_key = action_key
        self.action_type = action_type
        self.button_style_type = button_style_type
        self.name_i18n = name_i18n
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action_key is not None:
            result['actionKey'] = self.action_key
        if self.action_type is not None:
            result['actionType'] = self.action_type
        if self.button_style_type is not None:
            result['buttonStyleType'] = self.button_style_type
        if self.name_i18n is not None:
            result['nameI18n'] = self.name_i18n
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionKey') is not None:
            self.action_key = m.get('actionKey')
        if m.get('actionType') is not None:
            self.action_type = m.get('actionType')
        if m.get('buttonStyleType') is not None:
            self.button_style_type = m.get('buttonStyleType')
        if m.get('nameI18n') is not None:
            self.name_i18n = m.get('nameI18n')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class UpdateTodoTypeConfigRequestContentFieldList(TeaModel):
    def __init__(
        self,
        field_key: str = None,
        field_type: str = None,
        name_i18n: Dict[str, Any] = None,
    ):
        self.field_key = field_key
        self.field_type = field_type
        self.name_i18n = name_i18n

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_key is not None:
            result['fieldKey'] = self.field_key
        if self.field_type is not None:
            result['fieldType'] = self.field_type
        if self.name_i18n is not None:
            result['nameI18n'] = self.name_i18n
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldKey') is not None:
            self.field_key = m.get('fieldKey')
        if m.get('fieldType') is not None:
            self.field_type = m.get('fieldType')
        if m.get('nameI18n') is not None:
            self.name_i18n = m.get('nameI18n')
        return self


class UpdateTodoTypeConfigRequest(TeaModel):
    def __init__(
        self,
        action_list: List[UpdateTodoTypeConfigRequestActionList] = None,
        card_type: int = None,
        content_field_list: List[UpdateTodoTypeConfigRequestContentFieldList] = None,
        description: str = None,
        icon: str = None,
        pc_detail_url_open_mode: str = None,
        operator_id: str = None,
    ):
        self.action_list = action_list
        self.card_type = card_type
        self.content_field_list = content_field_list
        self.description = description
        self.icon = icon
        self.pc_detail_url_open_mode = pc_detail_url_open_mode
        self.operator_id = operator_id

    def validate(self):
        if self.action_list:
            for k in self.action_list:
                if k:
                    k.validate()
        if self.content_field_list:
            for k in self.content_field_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['actionList'] = []
        if self.action_list is not None:
            for k in self.action_list:
                result['actionList'].append(k.to_map() if k else None)
        if self.card_type is not None:
            result['cardType'] = self.card_type
        result['contentFieldList'] = []
        if self.content_field_list is not None:
            for k in self.content_field_list:
                result['contentFieldList'].append(k.to_map() if k else None)
        if self.description is not None:
            result['description'] = self.description
        if self.icon is not None:
            result['icon'] = self.icon
        if self.pc_detail_url_open_mode is not None:
            result['pcDetailUrlOpenMode'] = self.pc_detail_url_open_mode
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.action_list = []
        if m.get('actionList') is not None:
            for k in m.get('actionList'):
                temp_model = UpdateTodoTypeConfigRequestActionList()
                self.action_list.append(temp_model.from_map(k))
        if m.get('cardType') is not None:
            self.card_type = m.get('cardType')
        self.content_field_list = []
        if m.get('contentFieldList') is not None:
            for k in m.get('contentFieldList'):
                temp_model = UpdateTodoTypeConfigRequestContentFieldList()
                self.content_field_list.append(temp_model.from_map(k))
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('pcDetailUrlOpenMode') is not None:
            self.pc_detail_url_open_mode = m.get('pcDetailUrlOpenMode')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class UpdateTodoTypeConfigResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
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


class UpdateTodoTypeConfigResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateTodoTypeConfigResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = UpdateTodoTypeConfigResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


