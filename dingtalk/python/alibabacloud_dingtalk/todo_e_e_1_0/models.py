# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class AppCreateEnterpriseTodoTaskHeaders(TeaModel):
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


class AppCreateEnterpriseTodoTaskRequestCustomFields(TeaModel):
    def __init__(
        self,
        field_key: str = None,
        field_link: str = None,
        field_type: str = None,
        field_value: str = None,
        icon: str = None,
    ):
        self.field_key = field_key
        self.field_link = field_link
        self.field_type = field_type
        self.field_value = field_value
        self.icon = icon

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_key is not None:
            result['fieldKey'] = self.field_key
        if self.field_link is not None:
            result['fieldLink'] = self.field_link
        if self.field_type is not None:
            result['fieldType'] = self.field_type
        if self.field_value is not None:
            result['fieldValue'] = self.field_value
        if self.icon is not None:
            result['icon'] = self.icon
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldKey') is not None:
            self.field_key = m.get('fieldKey')
        if m.get('fieldLink') is not None:
            self.field_link = m.get('fieldLink')
        if m.get('fieldType') is not None:
            self.field_type = m.get('fieldType')
        if m.get('fieldValue') is not None:
            self.field_value = m.get('fieldValue')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        return self


class AppCreateEnterpriseTodoTaskRequestDetailUrl(TeaModel):
    def __init__(
        self,
        app_url: str = None,
        web_url: str = None,
    ):
        self.app_url = app_url
        self.web_url = web_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_url is not None:
            result['appUrl'] = self.app_url
        if self.web_url is not None:
            result['webUrl'] = self.web_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUrl') is not None:
            self.app_url = m.get('appUrl')
        if m.get('webUrl') is not None:
            self.web_url = m.get('webUrl')
        return self


class AppCreateEnterpriseTodoTaskRequestNotifyConfigs(TeaModel):
    def __init__(
        self,
        assistance: str = None,
        ding_notify: str = None,
    ):
        self.assistance = assistance
        self.ding_notify = ding_notify

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.assistance is not None:
            result['assistance'] = self.assistance
        if self.ding_notify is not None:
            result['dingNotify'] = self.ding_notify
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('assistance') is not None:
            self.assistance = m.get('assistance')
        if m.get('dingNotify') is not None:
            self.ding_notify = m.get('dingNotify')
        return self


class AppCreateEnterpriseTodoTaskRequest(TeaModel):
    def __init__(
        self,
        biz_category_id: str = None,
        biz_created_time: int = None,
        custom_fields: List[AppCreateEnterpriseTodoTaskRequestCustomFields] = None,
        description: str = None,
        detail_url: AppCreateEnterpriseTodoTaskRequestDetailUrl = None,
        due_time: int = None,
        executor_ids: List[str] = None,
        notify_configs: AppCreateEnterpriseTodoTaskRequestNotifyConfigs = None,
        operator_id: str = None,
        priority: int = None,
        source_id: str = None,
        source_title: str = None,
        subject: str = None,
        toolbar_template_key: str = None,
        type: str = None,
    ):
        self.biz_category_id = biz_category_id
        self.biz_created_time = biz_created_time
        self.custom_fields = custom_fields
        self.description = description
        self.detail_url = detail_url
        self.due_time = due_time
        self.executor_ids = executor_ids
        self.notify_configs = notify_configs
        self.operator_id = operator_id
        self.priority = priority
        self.source_id = source_id
        self.source_title = source_title
        self.subject = subject
        self.toolbar_template_key = toolbar_template_key
        self.type = type

    def validate(self):
        if self.custom_fields:
            for k in self.custom_fields:
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
        if self.biz_category_id is not None:
            result['bizCategoryId'] = self.biz_category_id
        if self.biz_created_time is not None:
            result['bizCreatedTime'] = self.biz_created_time
        result['customFields'] = []
        if self.custom_fields is not None:
            for k in self.custom_fields:
                result['customFields'].append(k.to_map() if k else None)
        if self.description is not None:
            result['description'] = self.description
        if self.detail_url is not None:
            result['detailUrl'] = self.detail_url.to_map()
        if self.due_time is not None:
            result['dueTime'] = self.due_time
        if self.executor_ids is not None:
            result['executorIds'] = self.executor_ids
        if self.notify_configs is not None:
            result['notifyConfigs'] = self.notify_configs.to_map()
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.priority is not None:
            result['priority'] = self.priority
        if self.source_id is not None:
            result['sourceId'] = self.source_id
        if self.source_title is not None:
            result['sourceTitle'] = self.source_title
        if self.subject is not None:
            result['subject'] = self.subject
        if self.toolbar_template_key is not None:
            result['toolbarTemplateKey'] = self.toolbar_template_key
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizCategoryId') is not None:
            self.biz_category_id = m.get('bizCategoryId')
        if m.get('bizCreatedTime') is not None:
            self.biz_created_time = m.get('bizCreatedTime')
        self.custom_fields = []
        if m.get('customFields') is not None:
            for k in m.get('customFields'):
                temp_model = AppCreateEnterpriseTodoTaskRequestCustomFields()
                self.custom_fields.append(temp_model.from_map(k))
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('detailUrl') is not None:
            temp_model = AppCreateEnterpriseTodoTaskRequestDetailUrl()
            self.detail_url = temp_model.from_map(m['detailUrl'])
        if m.get('dueTime') is not None:
            self.due_time = m.get('dueTime')
        if m.get('executorIds') is not None:
            self.executor_ids = m.get('executorIds')
        if m.get('notifyConfigs') is not None:
            temp_model = AppCreateEnterpriseTodoTaskRequestNotifyConfigs()
            self.notify_configs = temp_model.from_map(m['notifyConfigs'])
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('priority') is not None:
            self.priority = m.get('priority')
        if m.get('sourceId') is not None:
            self.source_id = m.get('sourceId')
        if m.get('sourceTitle') is not None:
            self.source_title = m.get('sourceTitle')
        if m.get('subject') is not None:
            self.subject = m.get('subject')
        if m.get('toolbarTemplateKey') is not None:
            self.toolbar_template_key = m.get('toolbarTemplateKey')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class AppCreateEnterpriseTodoTaskResponseBodyDetailUrl(TeaModel):
    def __init__(
        self,
        app_url: str = None,
        web_url: str = None,
    ):
        self.app_url = app_url
        self.web_url = web_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_url is not None:
            result['appUrl'] = self.app_url
        if self.web_url is not None:
            result['webUrl'] = self.web_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUrl') is not None:
            self.app_url = m.get('appUrl')
        if m.get('webUrl') is not None:
            self.web_url = m.get('webUrl')
        return self


class AppCreateEnterpriseTodoTaskResponseBody(TeaModel):
    def __init__(
        self,
        biz_category_id: str = None,
        created_time: int = None,
        creator_id: str = None,
        description: str = None,
        detail_url: AppCreateEnterpriseTodoTaskResponseBodyDetailUrl = None,
        done: bool = None,
        due_time: int = None,
        executor_ids: List[str] = None,
        modified_time: int = None,
        priority: int = None,
        source_id: str = None,
        subject: str = None,
        task_id: str = None,
    ):
        self.biz_category_id = biz_category_id
        self.created_time = created_time
        self.creator_id = creator_id
        self.description = description
        self.detail_url = detail_url
        self.done = done
        self.due_time = due_time
        self.executor_ids = executor_ids
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
        if self.biz_category_id is not None:
            result['bizCategoryId'] = self.biz_category_id
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
        if m.get('bizCategoryId') is not None:
            self.biz_category_id = m.get('bizCategoryId')
        if m.get('createdTime') is not None:
            self.created_time = m.get('createdTime')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('detailUrl') is not None:
            temp_model = AppCreateEnterpriseTodoTaskResponseBodyDetailUrl()
            self.detail_url = temp_model.from_map(m['detailUrl'])
        if m.get('done') is not None:
            self.done = m.get('done')
        if m.get('dueTime') is not None:
            self.due_time = m.get('dueTime')
        if m.get('executorIds') is not None:
            self.executor_ids = m.get('executorIds')
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


class AppCreateEnterpriseTodoTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AppCreateEnterpriseTodoTaskResponseBody = None,
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
            temp_model = AppCreateEnterpriseTodoTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AppDeleteTodoEETaskHeaders(TeaModel):
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


class AppDeleteTodoEETaskRequest(TeaModel):
    def __init__(
        self,
        operator_id: str = None,
        task_ids: List[str] = None,
    ):
        self.operator_id = operator_id
        self.task_ids = task_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.task_ids is not None:
            result['taskIds'] = self.task_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('taskIds') is not None:
            self.task_ids = m.get('taskIds')
        return self


class AppDeleteTodoEETaskResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class AppDeleteTodoEETaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AppDeleteTodoEETaskResponseBody = None,
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
            temp_model = AppDeleteTodoEETaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AppGetUserTaskListHeaders(TeaModel):
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


class AppGetUserTaskListRequest(TeaModel):
    def __init__(
        self,
        done: bool = None,
        operator_id: str = None,
        page_number: int = None,
        page_size: int = None,
        type: str = None,
    ):
        self.done = done
        self.operator_id = operator_id
        self.page_number = page_number
        self.page_size = page_size
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.done is not None:
            result['done'] = self.done
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('done') is not None:
            self.done = m.get('done')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class AppGetUserTaskListResponseBodyDataDetailUrl(TeaModel):
    def __init__(
        self,
        app_url: str = None,
        web_url: str = None,
    ):
        self.app_url = app_url
        self.web_url = web_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_url is not None:
            result['appUrl'] = self.app_url
        if self.web_url is not None:
            result['webUrl'] = self.web_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUrl') is not None:
            self.app_url = m.get('appUrl')
        if m.get('webUrl') is not None:
            self.web_url = m.get('webUrl')
        return self


class AppGetUserTaskListResponseBodyData(TeaModel):
    def __init__(
        self,
        biz_category_id: str = None,
        created_time: int = None,
        description: str = None,
        detail_url: AppGetUserTaskListResponseBodyDataDetailUrl = None,
        done: bool = None,
        due_time: int = None,
        modified_time: int = None,
        operator_id: str = None,
        priority: int = None,
        subject: str = None,
        task_id: str = None,
    ):
        self.biz_category_id = biz_category_id
        self.created_time = created_time
        self.description = description
        self.detail_url = detail_url
        self.done = done
        self.due_time = due_time
        self.modified_time = modified_time
        self.operator_id = operator_id
        self.priority = priority
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
        if self.biz_category_id is not None:
            result['bizCategoryId'] = self.biz_category_id
        if self.created_time is not None:
            result['createdTime'] = self.created_time
        if self.description is not None:
            result['description'] = self.description
        if self.detail_url is not None:
            result['detailUrl'] = self.detail_url.to_map()
        if self.done is not None:
            result['done'] = self.done
        if self.due_time is not None:
            result['dueTime'] = self.due_time
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.priority is not None:
            result['priority'] = self.priority
        if self.subject is not None:
            result['subject'] = self.subject
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizCategoryId') is not None:
            self.biz_category_id = m.get('bizCategoryId')
        if m.get('createdTime') is not None:
            self.created_time = m.get('createdTime')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('detailUrl') is not None:
            temp_model = AppGetUserTaskListResponseBodyDataDetailUrl()
            self.detail_url = temp_model.from_map(m['detailUrl'])
        if m.get('done') is not None:
            self.done = m.get('done')
        if m.get('dueTime') is not None:
            self.due_time = m.get('dueTime')
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('priority') is not None:
            self.priority = m.get('priority')
        if m.get('subject') is not None:
            self.subject = m.get('subject')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class AppGetUserTaskListResponseBody(TeaModel):
    def __init__(
        self,
        data: List[AppGetUserTaskListResponseBodyData] = None,
        has_more: bool = None,
        page_number: int = None,
        page_size: int = None,
        total_count: int = None,
    ):
        self.data = data
        self.has_more = has_more
        self.page_number = page_number
        self.page_size = page_size
        self.total_count = total_count

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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = AppGetUserTaskListResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class AppGetUserTaskListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AppGetUserTaskListResponseBody = None,
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
            temp_model = AppGetUserTaskListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AppUpdateTaskHeaders(TeaModel):
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


class AppUpdateTaskRequest(TeaModel):
    def __init__(
        self,
        biz_created_time: int = None,
        description: str = None,
        done: bool = None,
        due_time: int = None,
        executor_ids: List[str] = None,
        operator_id: str = None,
        subject: str = None,
        task_id: int = None,
        toolbar_template_key: str = None,
    ):
        self.biz_created_time = biz_created_time
        self.description = description
        self.done = done
        self.due_time = due_time
        self.executor_ids = executor_ids
        self.operator_id = operator_id
        self.subject = subject
        self.task_id = task_id
        self.toolbar_template_key = toolbar_template_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_created_time is not None:
            result['bizCreatedTime'] = self.biz_created_time
        if self.description is not None:
            result['description'] = self.description
        if self.done is not None:
            result['done'] = self.done
        if self.due_time is not None:
            result['dueTime'] = self.due_time
        if self.executor_ids is not None:
            result['executorIds'] = self.executor_ids
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.subject is not None:
            result['subject'] = self.subject
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.toolbar_template_key is not None:
            result['toolbarTemplateKey'] = self.toolbar_template_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizCreatedTime') is not None:
            self.biz_created_time = m.get('bizCreatedTime')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('done') is not None:
            self.done = m.get('done')
        if m.get('dueTime') is not None:
            self.due_time = m.get('dueTime')
        if m.get('executorIds') is not None:
            self.executor_ids = m.get('executorIds')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('subject') is not None:
            self.subject = m.get('subject')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('toolbarTemplateKey') is not None:
            self.toolbar_template_key = m.get('toolbarTemplateKey')
        return self


class AppUpdateTaskResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class AppUpdateTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AppUpdateTaskResponseBody = None,
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
            temp_model = AppUpdateTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AppUpdateUserTaskStatusHeaders(TeaModel):
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


class AppUpdateUserTaskStatusRequestUserTaskStatuses(TeaModel):
    def __init__(
        self,
        done: bool = None,
        task_id: str = None,
    ):
        self.done = done
        self.task_id = task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.done is not None:
            result['done'] = self.done
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('done') is not None:
            self.done = m.get('done')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class AppUpdateUserTaskStatusRequest(TeaModel):
    def __init__(
        self,
        operator_id: str = None,
        user_task_statuses: List[AppUpdateUserTaskStatusRequestUserTaskStatuses] = None,
    ):
        self.operator_id = operator_id
        self.user_task_statuses = user_task_statuses

    def validate(self):
        if self.user_task_statuses:
            for k in self.user_task_statuses:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        result['userTaskStatuses'] = []
        if self.user_task_statuses is not None:
            for k in self.user_task_statuses:
                result['userTaskStatuses'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        self.user_task_statuses = []
        if m.get('userTaskStatuses') is not None:
            for k in m.get('userTaskStatuses'):
                temp_model = AppUpdateUserTaskStatusRequestUserTaskStatuses()
                self.user_task_statuses.append(temp_model.from_map(k))
        return self


class AppUpdateUserTaskStatusResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class AppUpdateUserTaskStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AppUpdateUserTaskStatusResponseBody = None,
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
            temp_model = AppUpdateUserTaskStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateEnterpriseTodoTaskHeaders(TeaModel):
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


class CreateEnterpriseTodoTaskRequestCustomFields(TeaModel):
    def __init__(
        self,
        field_key: str = None,
        field_link: str = None,
        field_type: str = None,
        field_value: str = None,
        icon: str = None,
    ):
        self.field_key = field_key
        self.field_link = field_link
        self.field_type = field_type
        self.field_value = field_value
        self.icon = icon

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_key is not None:
            result['fieldKey'] = self.field_key
        if self.field_link is not None:
            result['fieldLink'] = self.field_link
        if self.field_type is not None:
            result['fieldType'] = self.field_type
        if self.field_value is not None:
            result['fieldValue'] = self.field_value
        if self.icon is not None:
            result['icon'] = self.icon
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldKey') is not None:
            self.field_key = m.get('fieldKey')
        if m.get('fieldLink') is not None:
            self.field_link = m.get('fieldLink')
        if m.get('fieldType') is not None:
            self.field_type = m.get('fieldType')
        if m.get('fieldValue') is not None:
            self.field_value = m.get('fieldValue')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        return self


class CreateEnterpriseTodoTaskRequestDetailUrl(TeaModel):
    def __init__(
        self,
        app_url: str = None,
        web_url: str = None,
    ):
        self.app_url = app_url
        self.web_url = web_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_url is not None:
            result['appUrl'] = self.app_url
        if self.web_url is not None:
            result['webUrl'] = self.web_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUrl') is not None:
            self.app_url = m.get('appUrl')
        if m.get('webUrl') is not None:
            self.web_url = m.get('webUrl')
        return self


class CreateEnterpriseTodoTaskRequestNotifyConfigs(TeaModel):
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


class CreateEnterpriseTodoTaskRequest(TeaModel):
    def __init__(
        self,
        biz_category_id: str = None,
        custom_fields: List[CreateEnterpriseTodoTaskRequestCustomFields] = None,
        description: str = None,
        detail_url: CreateEnterpriseTodoTaskRequestDetailUrl = None,
        due_time: int = None,
        executor_ids: List[str] = None,
        notify_configs: CreateEnterpriseTodoTaskRequestNotifyConfigs = None,
        operator_id: str = None,
        priority: int = None,
        source_id: str = None,
        source_title: str = None,
        subject: str = None,
        tracker_ids: List[str] = None,
        type: str = None,
    ):
        self.biz_category_id = biz_category_id
        self.custom_fields = custom_fields
        self.description = description
        self.detail_url = detail_url
        self.due_time = due_time
        self.executor_ids = executor_ids
        self.notify_configs = notify_configs
        self.operator_id = operator_id
        self.priority = priority
        self.source_id = source_id
        self.source_title = source_title
        self.subject = subject
        self.tracker_ids = tracker_ids
        self.type = type

    def validate(self):
        if self.custom_fields:
            for k in self.custom_fields:
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
        if self.biz_category_id is not None:
            result['bizCategoryId'] = self.biz_category_id
        result['customFields'] = []
        if self.custom_fields is not None:
            for k in self.custom_fields:
                result['customFields'].append(k.to_map() if k else None)
        if self.description is not None:
            result['description'] = self.description
        if self.detail_url is not None:
            result['detailUrl'] = self.detail_url.to_map()
        if self.due_time is not None:
            result['dueTime'] = self.due_time
        if self.executor_ids is not None:
            result['executorIds'] = self.executor_ids
        if self.notify_configs is not None:
            result['notifyConfigs'] = self.notify_configs.to_map()
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.priority is not None:
            result['priority'] = self.priority
        if self.source_id is not None:
            result['sourceId'] = self.source_id
        if self.source_title is not None:
            result['sourceTitle'] = self.source_title
        if self.subject is not None:
            result['subject'] = self.subject
        if self.tracker_ids is not None:
            result['trackerIds'] = self.tracker_ids
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizCategoryId') is not None:
            self.biz_category_id = m.get('bizCategoryId')
        self.custom_fields = []
        if m.get('customFields') is not None:
            for k in m.get('customFields'):
                temp_model = CreateEnterpriseTodoTaskRequestCustomFields()
                self.custom_fields.append(temp_model.from_map(k))
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('detailUrl') is not None:
            temp_model = CreateEnterpriseTodoTaskRequestDetailUrl()
            self.detail_url = temp_model.from_map(m['detailUrl'])
        if m.get('dueTime') is not None:
            self.due_time = m.get('dueTime')
        if m.get('executorIds') is not None:
            self.executor_ids = m.get('executorIds')
        if m.get('notifyConfigs') is not None:
            temp_model = CreateEnterpriseTodoTaskRequestNotifyConfigs()
            self.notify_configs = temp_model.from_map(m['notifyConfigs'])
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('priority') is not None:
            self.priority = m.get('priority')
        if m.get('sourceId') is not None:
            self.source_id = m.get('sourceId')
        if m.get('sourceTitle') is not None:
            self.source_title = m.get('sourceTitle')
        if m.get('subject') is not None:
            self.subject = m.get('subject')
        if m.get('trackerIds') is not None:
            self.tracker_ids = m.get('trackerIds')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class CreateEnterpriseTodoTaskResponseBodyDetailUrl(TeaModel):
    def __init__(
        self,
        app_url: str = None,
        web_url: str = None,
    ):
        self.app_url = app_url
        self.web_url = web_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_url is not None:
            result['appUrl'] = self.app_url
        if self.web_url is not None:
            result['webUrl'] = self.web_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUrl') is not None:
            self.app_url = m.get('appUrl')
        if m.get('webUrl') is not None:
            self.web_url = m.get('webUrl')
        return self


class CreateEnterpriseTodoTaskResponseBody(TeaModel):
    def __init__(
        self,
        biz_category_id: str = None,
        created_time: int = None,
        creator_id: str = None,
        description: str = None,
        detail_url: CreateEnterpriseTodoTaskResponseBodyDetailUrl = None,
        done: bool = None,
        due_time: int = None,
        executor_ids: List[str] = None,
        modified_time: int = None,
        source_id: str = None,
        subject: str = None,
        task_id: str = None,
    ):
        self.biz_category_id = biz_category_id
        self.created_time = created_time
        self.creator_id = creator_id
        self.description = description
        self.detail_url = detail_url
        self.done = done
        self.due_time = due_time
        self.executor_ids = executor_ids
        self.modified_time = modified_time
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
        if self.biz_category_id is not None:
            result['bizCategoryId'] = self.biz_category_id
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
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        if self.source_id is not None:
            result['sourceId'] = self.source_id
        if self.subject is not None:
            result['subject'] = self.subject
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizCategoryId') is not None:
            self.biz_category_id = m.get('bizCategoryId')
        if m.get('createdTime') is not None:
            self.created_time = m.get('createdTime')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('detailUrl') is not None:
            temp_model = CreateEnterpriseTodoTaskResponseBodyDetailUrl()
            self.detail_url = temp_model.from_map(m['detailUrl'])
        if m.get('done') is not None:
            self.done = m.get('done')
        if m.get('dueTime') is not None:
            self.due_time = m.get('dueTime')
        if m.get('executorIds') is not None:
            self.executor_ids = m.get('executorIds')
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        if m.get('sourceId') is not None:
            self.source_id = m.get('sourceId')
        if m.get('subject') is not None:
            self.subject = m.get('subject')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class CreateEnterpriseTodoTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateEnterpriseTodoTaskResponseBody = None,
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
            temp_model = CreateEnterpriseTodoTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateStandardTemplateHeaders(TeaModel):
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


class CreateStandardTemplateRequestActions(TeaModel):
    def __init__(
        self,
        action_group: str = None,
        name: str = None,
        need_reason: bool = None,
        need_reason_required: bool = None,
        order: int = None,
        style_type: int = None,
    ):
        self.action_group = action_group
        self.name = name
        self.need_reason = need_reason
        self.need_reason_required = need_reason_required
        self.order = order
        self.style_type = style_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action_group is not None:
            result['actionGroup'] = self.action_group
        if self.name is not None:
            result['name'] = self.name
        if self.need_reason is not None:
            result['needReason'] = self.need_reason
        if self.need_reason_required is not None:
            result['needReasonRequired'] = self.need_reason_required
        if self.order is not None:
            result['order'] = self.order
        if self.style_type is not None:
            result['styleType'] = self.style_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionGroup') is not None:
            self.action_group = m.get('actionGroup')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('needReason') is not None:
            self.need_reason = m.get('needReason')
        if m.get('needReasonRequired') is not None:
            self.need_reason_required = m.get('needReasonRequired')
        if m.get('order') is not None:
            self.order = m.get('order')
        if m.get('styleType') is not None:
            self.style_type = m.get('styleType')
        return self


class CreateStandardTemplateRequestService(TeaModel):
    def __init__(
        self,
        callback_url: str = None,
    ):
        self.callback_url = callback_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.callback_url is not None:
            result['callbackUrl'] = self.callback_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('callbackUrl') is not None:
            self.callback_url = m.get('callbackUrl')
        return self


class CreateStandardTemplateRequest(TeaModel):
    def __init__(
        self,
        actions: List[CreateStandardTemplateRequestActions] = None,
        description: str = None,
        name: str = None,
        operator_id: str = None,
        service: CreateStandardTemplateRequestService = None,
    ):
        self.actions = actions
        self.description = description
        self.name = name
        self.operator_id = operator_id
        self.service = service

    def validate(self):
        if self.actions:
            for k in self.actions:
                if k:
                    k.validate()
        if self.service:
            self.service.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['actions'] = []
        if self.actions is not None:
            for k in self.actions:
                result['actions'].append(k.to_map() if k else None)
        if self.description is not None:
            result['description'] = self.description
        if self.name is not None:
            result['name'] = self.name
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.service is not None:
            result['service'] = self.service.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.actions = []
        if m.get('actions') is not None:
            for k in m.get('actions'):
                temp_model = CreateStandardTemplateRequestActions()
                self.actions.append(temp_model.from_map(k))
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('service') is not None:
            temp_model = CreateStandardTemplateRequestService()
            self.service = temp_model.from_map(m['service'])
        return self


class CreateStandardTemplateResponseBodyActions(TeaModel):
    def __init__(
        self,
        action_key: str = None,
        name: str = None,
        need_reason: bool = None,
        need_reason_required: bool = None,
        order: int = None,
        style_type: int = None,
    ):
        self.action_key = action_key
        self.name = name
        self.need_reason = need_reason
        self.need_reason_required = need_reason_required
        self.order = order
        self.style_type = style_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action_key is not None:
            result['actionKey'] = self.action_key
        if self.name is not None:
            result['name'] = self.name
        if self.need_reason is not None:
            result['needReason'] = self.need_reason
        if self.need_reason_required is not None:
            result['needReasonRequired'] = self.need_reason_required
        if self.order is not None:
            result['order'] = self.order
        if self.style_type is not None:
            result['styleType'] = self.style_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionKey') is not None:
            self.action_key = m.get('actionKey')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('needReason') is not None:
            self.need_reason = m.get('needReason')
        if m.get('needReasonRequired') is not None:
            self.need_reason_required = m.get('needReasonRequired')
        if m.get('order') is not None:
            self.order = m.get('order')
        if m.get('styleType') is not None:
            self.style_type = m.get('styleType')
        return self


class CreateStandardTemplateResponseBody(TeaModel):
    def __init__(
        self,
        actions: List[CreateStandardTemplateResponseBodyActions] = None,
        description: str = None,
        name: str = None,
        template_key: str = None,
    ):
        self.actions = actions
        self.description = description
        self.name = name
        self.template_key = template_key

    def validate(self):
        if self.actions:
            for k in self.actions:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['actions'] = []
        if self.actions is not None:
            for k in self.actions:
                result['actions'].append(k.to_map() if k else None)
        if self.description is not None:
            result['description'] = self.description
        if self.name is not None:
            result['name'] = self.name
        if self.template_key is not None:
            result['templateKey'] = self.template_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.actions = []
        if m.get('actions') is not None:
            for k in m.get('actions'):
                temp_model = CreateStandardTemplateResponseBodyActions()
                self.actions.append(temp_model.from_map(k))
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('templateKey') is not None:
            self.template_key = m.get('templateKey')
        return self


class CreateStandardTemplateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateStandardTemplateResponseBody = None,
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
            temp_model = CreateStandardTemplateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteCategorySourceConfigHeaders(TeaModel):
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


class DeleteCategorySourceConfigRequest(TeaModel):
    def __init__(
        self,
        biz_category_id: str = None,
    ):
        # This parameter is required.
        self.biz_category_id = biz_category_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_category_id is not None:
            result['bizCategoryId'] = self.biz_category_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizCategoryId') is not None:
            self.biz_category_id = m.get('bizCategoryId')
        return self


class DeleteCategorySourceConfigResponseBody(TeaModel):
    def __init__(
        self,
        success: str = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class DeleteCategorySourceConfigResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteCategorySourceConfigResponseBody = None,
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
            temp_model = DeleteCategorySourceConfigResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteTodoEETaskHeaders(TeaModel):
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


class DeleteTodoEETaskRequest(TeaModel):
    def __init__(
        self,
        task_ids: List[str] = None,
    ):
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


class DeleteTodoEETaskResponseBody(TeaModel):
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


class DeleteTodoEETaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteTodoEETaskResponseBody = None,
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
            temp_model = DeleteTodoEETaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetCategorySourceConfigListHeaders(TeaModel):
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


class GetCategorySourceConfigListRequest(TeaModel):
    def __init__(
        self,
        next_token: str = None,
    ):
        self.next_token = next_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class GetCategorySourceConfigListResponseBodyConfigs(TeaModel):
    def __init__(
        self,
        biz_category_id: str = None,
        biz_category_name: str = None,
        config_id: str = None,
    ):
        self.biz_category_id = biz_category_id
        self.biz_category_name = biz_category_name
        self.config_id = config_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_category_id is not None:
            result['bizCategoryId'] = self.biz_category_id
        if self.biz_category_name is not None:
            result['bizCategoryName'] = self.biz_category_name
        if self.config_id is not None:
            result['configId'] = self.config_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizCategoryId') is not None:
            self.biz_category_id = m.get('bizCategoryId')
        if m.get('bizCategoryName') is not None:
            self.biz_category_name = m.get('bizCategoryName')
        if m.get('configId') is not None:
            self.config_id = m.get('configId')
        return self


class GetCategorySourceConfigListResponseBody(TeaModel):
    def __init__(
        self,
        configs: List[GetCategorySourceConfigListResponseBodyConfigs] = None,
        next_token: str = None,
        total_count: int = None,
    ):
        self.configs = configs
        self.next_token = next_token
        self.total_count = total_count

    def validate(self):
        if self.configs:
            for k in self.configs:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['configs'] = []
        if self.configs is not None:
            for k in self.configs:
                result['configs'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.configs = []
        if m.get('configs') is not None:
            for k in m.get('configs'):
                temp_model = GetCategorySourceConfigListResponseBodyConfigs()
                self.configs.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class GetCategorySourceConfigListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetCategorySourceConfigListResponseBody = None,
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
            temp_model = GetCategorySourceConfigListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetTemplateListHeaders(TeaModel):
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


class GetTemplateListRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
    ):
        self.page_number = page_number
        self.page_size = page_size

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class GetTemplateListResponseBodyDataActions(TeaModel):
    def __init__(
        self,
        action_key: str = None,
        description: str = None,
        name: str = None,
        need_reason: bool = None,
        need_reason_required: bool = None,
        order: int = None,
        style_type: int = None,
    ):
        self.action_key = action_key
        self.description = description
        self.name = name
        self.need_reason = need_reason
        self.need_reason_required = need_reason_required
        self.order = order
        self.style_type = style_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action_key is not None:
            result['actionKey'] = self.action_key
        if self.description is not None:
            result['description'] = self.description
        if self.name is not None:
            result['name'] = self.name
        if self.need_reason is not None:
            result['needReason'] = self.need_reason
        if self.need_reason_required is not None:
            result['needReasonRequired'] = self.need_reason_required
        if self.order is not None:
            result['order'] = self.order
        if self.style_type is not None:
            result['styleType'] = self.style_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionKey') is not None:
            self.action_key = m.get('actionKey')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('needReason') is not None:
            self.need_reason = m.get('needReason')
        if m.get('needReasonRequired') is not None:
            self.need_reason_required = m.get('needReasonRequired')
        if m.get('order') is not None:
            self.order = m.get('order')
        if m.get('styleType') is not None:
            self.style_type = m.get('styleType')
        return self


class GetTemplateListResponseBodyData(TeaModel):
    def __init__(
        self,
        actions: List[GetTemplateListResponseBodyDataActions] = None,
        create_time: int = None,
        creator_id: str = None,
        description: str = None,
        modified_time: int = None,
        modifier_id: str = None,
        name: str = None,
        template_key: str = None,
    ):
        self.actions = actions
        self.create_time = create_time
        self.creator_id = creator_id
        self.description = description
        self.modified_time = modified_time
        self.modifier_id = modifier_id
        self.name = name
        self.template_key = template_key

    def validate(self):
        if self.actions:
            for k in self.actions:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['actions'] = []
        if self.actions is not None:
            for k in self.actions:
                result['actions'].append(k.to_map() if k else None)
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.description is not None:
            result['description'] = self.description
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        if self.modifier_id is not None:
            result['modifierId'] = self.modifier_id
        if self.name is not None:
            result['name'] = self.name
        if self.template_key is not None:
            result['templateKey'] = self.template_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.actions = []
        if m.get('actions') is not None:
            for k in m.get('actions'):
                temp_model = GetTemplateListResponseBodyDataActions()
                self.actions.append(temp_model.from_map(k))
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        if m.get('modifierId') is not None:
            self.modifier_id = m.get('modifierId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('templateKey') is not None:
            self.template_key = m.get('templateKey')
        return self


class GetTemplateListResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetTemplateListResponseBodyData] = None,
        page_number: int = None,
        page_size: int = None,
        total_count: int = None,
    ):
        self.data = data
        self.page_number = page_number
        self.page_size = page_size
        self.total_count = total_count

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
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetTemplateListResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class GetTemplateListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetTemplateListResponseBody = None,
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
            temp_model = GetTemplateListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetUserTaskListHeaders(TeaModel):
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


class GetUserTaskListRequest(TeaModel):
    def __init__(
        self,
        done: bool = None,
        page_number: int = None,
        page_size: int = None,
        type: str = None,
    ):
        self.done = done
        self.page_number = page_number
        self.page_size = page_size
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.done is not None:
            result['done'] = self.done
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('done') is not None:
            self.done = m.get('done')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class GetUserTaskListResponseBodyData(TeaModel):
    def __init__(
        self,
        created_time: int = None,
        description: str = None,
        done: bool = None,
        due_time: int = None,
        subject: str = None,
        task_id: str = None,
    ):
        self.created_time = created_time
        self.description = description
        self.done = done
        self.due_time = due_time
        self.subject = subject
        self.task_id = task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.created_time is not None:
            result['createdTime'] = self.created_time
        if self.description is not None:
            result['description'] = self.description
        if self.done is not None:
            result['done'] = self.done
        if self.due_time is not None:
            result['dueTime'] = self.due_time
        if self.subject is not None:
            result['subject'] = self.subject
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createdTime') is not None:
            self.created_time = m.get('createdTime')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('done') is not None:
            self.done = m.get('done')
        if m.get('dueTime') is not None:
            self.due_time = m.get('dueTime')
        if m.get('subject') is not None:
            self.subject = m.get('subject')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class GetUserTaskListResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetUserTaskListResponseBodyData] = None,
        page_number: int = None,
        page_size: int = None,
        total_count: int = None,
    ):
        self.data = data
        self.page_number = page_number
        self.page_size = page_size
        self.total_count = total_count

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
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetUserTaskListResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class GetUserTaskListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetUserTaskListResponseBody = None,
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
            temp_model = GetUserTaskListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryTaskExecutionStatusHeaders(TeaModel):
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


class QueryTaskExecutionStatusRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        task_id: str = None,
    ):
        self.page_number = page_number
        self.page_size = page_size
        # This parameter is required.
        self.task_id = task_id

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
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class QueryTaskExecutionStatusResponseBodyData(TeaModel):
    def __init__(
        self,
        done: bool = None,
        executor_id: str = None,
        finish_date: int = None,
    ):
        self.done = done
        self.executor_id = executor_id
        self.finish_date = finish_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.done is not None:
            result['done'] = self.done
        if self.executor_id is not None:
            result['executorId'] = self.executor_id
        if self.finish_date is not None:
            result['finishDate'] = self.finish_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('done') is not None:
            self.done = m.get('done')
        if m.get('executorId') is not None:
            self.executor_id = m.get('executorId')
        if m.get('finishDate') is not None:
            self.finish_date = m.get('finishDate')
        return self


class QueryTaskExecutionStatusResponseBody(TeaModel):
    def __init__(
        self,
        data: List[QueryTaskExecutionStatusResponseBodyData] = None,
        has_more: bool = None,
        page_number: int = None,
        page_size: int = None,
        total_count: int = None,
    ):
        self.data = data
        self.has_more = has_more
        self.page_number = page_number
        self.page_size = page_size
        self.total_count = total_count

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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = QueryTaskExecutionStatusResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class QueryTaskExecutionStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryTaskExecutionStatusResponseBody = None,
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
            temp_model = QueryTaskExecutionStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RegisterCategorySourceConfigHeaders(TeaModel):
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


class RegisterCategorySourceConfigRequest(TeaModel):
    def __init__(
        self,
        biz_category_id: str = None,
        biz_category_name: str = None,
        operator_id: str = None,
    ):
        # This parameter is required.
        self.biz_category_id = biz_category_id
        # This parameter is required.
        self.biz_category_name = biz_category_name
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_category_id is not None:
            result['bizCategoryId'] = self.biz_category_id
        if self.biz_category_name is not None:
            result['bizCategoryName'] = self.biz_category_name
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizCategoryId') is not None:
            self.biz_category_id = m.get('bizCategoryId')
        if m.get('bizCategoryName') is not None:
            self.biz_category_name = m.get('bizCategoryName')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class RegisterCategorySourceConfigResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class RegisterCategorySourceConfigResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RegisterCategorySourceConfigResponseBody = None,
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
            temp_model = RegisterCategorySourceConfigResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateCategorySourceConfigHeaders(TeaModel):
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


class UpdateCategorySourceConfigRequest(TeaModel):
    def __init__(
        self,
        biz_category_id: str = None,
        biz_category_name: str = None,
        operator_id: str = None,
    ):
        # This parameter is required.
        self.biz_category_id = biz_category_id
        # This parameter is required.
        self.biz_category_name = biz_category_name
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_category_id is not None:
            result['bizCategoryId'] = self.biz_category_id
        if self.biz_category_name is not None:
            result['bizCategoryName'] = self.biz_category_name
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizCategoryId') is not None:
            self.biz_category_id = m.get('bizCategoryId')
        if m.get('bizCategoryName') is not None:
            self.biz_category_name = m.get('bizCategoryName')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class UpdateCategorySourceConfigResponseBody(TeaModel):
    def __init__(
        self,
        success: str = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class UpdateCategorySourceConfigResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateCategorySourceConfigResponseBody = None,
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
            temp_model = UpdateCategorySourceConfigResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateStandardTemplateHeaders(TeaModel):
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


class UpdateStandardTemplateRequestActions(TeaModel):
    def __init__(
        self,
        action_group: str = None,
        name: str = None,
        need_reason: bool = None,
        need_reason_required: bool = None,
        order: int = None,
        style_type: int = None,
    ):
        self.action_group = action_group
        self.name = name
        self.need_reason = need_reason
        self.need_reason_required = need_reason_required
        self.order = order
        self.style_type = style_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action_group is not None:
            result['actionGroup'] = self.action_group
        if self.name is not None:
            result['name'] = self.name
        if self.need_reason is not None:
            result['needReason'] = self.need_reason
        if self.need_reason_required is not None:
            result['needReasonRequired'] = self.need_reason_required
        if self.order is not None:
            result['order'] = self.order
        if self.style_type is not None:
            result['styleType'] = self.style_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionGroup') is not None:
            self.action_group = m.get('actionGroup')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('needReason') is not None:
            self.need_reason = m.get('needReason')
        if m.get('needReasonRequired') is not None:
            self.need_reason_required = m.get('needReasonRequired')
        if m.get('order') is not None:
            self.order = m.get('order')
        if m.get('styleType') is not None:
            self.style_type = m.get('styleType')
        return self


class UpdateStandardTemplateRequestService(TeaModel):
    def __init__(
        self,
        callback_url: str = None,
    ):
        self.callback_url = callback_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.callback_url is not None:
            result['callbackUrl'] = self.callback_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('callbackUrl') is not None:
            self.callback_url = m.get('callbackUrl')
        return self


class UpdateStandardTemplateRequest(TeaModel):
    def __init__(
        self,
        actions: List[UpdateStandardTemplateRequestActions] = None,
        operator_id: str = None,
        service: UpdateStandardTemplateRequestService = None,
        template_key: str = None,
    ):
        self.actions = actions
        self.operator_id = operator_id
        self.service = service
        self.template_key = template_key

    def validate(self):
        if self.actions:
            for k in self.actions:
                if k:
                    k.validate()
        if self.service:
            self.service.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['actions'] = []
        if self.actions is not None:
            for k in self.actions:
                result['actions'].append(k.to_map() if k else None)
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.service is not None:
            result['service'] = self.service.to_map()
        if self.template_key is not None:
            result['templateKey'] = self.template_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.actions = []
        if m.get('actions') is not None:
            for k in m.get('actions'):
                temp_model = UpdateStandardTemplateRequestActions()
                self.actions.append(temp_model.from_map(k))
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('service') is not None:
            temp_model = UpdateStandardTemplateRequestService()
            self.service = temp_model.from_map(m['service'])
        if m.get('templateKey') is not None:
            self.template_key = m.get('templateKey')
        return self


class UpdateStandardTemplateResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class UpdateStandardTemplateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateStandardTemplateResponseBody = None,
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
            temp_model = UpdateStandardTemplateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateTaskHeaders(TeaModel):
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


class UpdateTaskRequest(TeaModel):
    def __init__(
        self,
        description: str = None,
        done: bool = None,
        due_time: int = None,
        executor_ids: List[str] = None,
        subject: str = None,
        task_id: int = None,
    ):
        self.description = description
        self.done = done
        self.due_time = due_time
        self.executor_ids = executor_ids
        self.subject = subject
        self.task_id = task_id

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
        if self.subject is not None:
            result['subject'] = self.subject
        if self.task_id is not None:
            result['taskId'] = self.task_id
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
        if m.get('subject') is not None:
            self.subject = m.get('subject')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class UpdateTaskResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        # This parameter is required.
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


class UpdateTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateTaskResponseBody = None,
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
            temp_model = UpdateTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateUserTaskStatusHeaders(TeaModel):
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


class UpdateUserTaskStatusRequestUserTaskStatuses(TeaModel):
    def __init__(
        self,
        done: bool = None,
        task_id: str = None,
    ):
        self.done = done
        self.task_id = task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.done is not None:
            result['done'] = self.done
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('done') is not None:
            self.done = m.get('done')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class UpdateUserTaskStatusRequest(TeaModel):
    def __init__(
        self,
        operator_id: str = None,
        user_task_statuses: List[UpdateUserTaskStatusRequestUserTaskStatuses] = None,
    ):
        self.operator_id = operator_id
        self.user_task_statuses = user_task_statuses

    def validate(self):
        if self.user_task_statuses:
            for k in self.user_task_statuses:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        result['userTaskStatuses'] = []
        if self.user_task_statuses is not None:
            for k in self.user_task_statuses:
                result['userTaskStatuses'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        self.user_task_statuses = []
        if m.get('userTaskStatuses') is not None:
            for k in m.get('userTaskStatuses'):
                temp_model = UpdateUserTaskStatusRequestUserTaskStatuses()
                self.user_task_statuses.append(temp_model.from_map(k))
        return self


class UpdateUserTaskStatusResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class UpdateUserTaskStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateUserTaskStatusResponseBody = None,
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
            temp_model = UpdateUserTaskStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


