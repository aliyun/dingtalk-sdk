# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List, Any


class CreateAssistantMessageHeaders(TeaModel):
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


class CreateAssistantMessageRequest(TeaModel):
    def __init__(
        self,
        content: str = None,
        role: str = None,
    ):
        # This parameter is required.
        self.content = content
        # This parameter is required.
        self.role = role

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.role is not None:
            result['role'] = self.role
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('role') is not None:
            self.role = m.get('role')
        return self


class CreateAssistantMessageResponseBody(TeaModel):
    def __init__(
        self,
        assistant_id: str = None,
        created_at: int = None,
        id: str = None,
        object: str = None,
        role: str = None,
        run_id: str = None,
        thread_id: str = None,
    ):
        self.assistant_id = assistant_id
        self.created_at = created_at
        self.id = id
        self.object = object
        self.role = role
        self.run_id = run_id
        self.thread_id = thread_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.assistant_id is not None:
            result['assistantId'] = self.assistant_id
        if self.created_at is not None:
            result['createdAt'] = self.created_at
        if self.id is not None:
            result['id'] = self.id
        if self.object is not None:
            result['object'] = self.object
        if self.role is not None:
            result['role'] = self.role
        if self.run_id is not None:
            result['runId'] = self.run_id
        if self.thread_id is not None:
            result['threadId'] = self.thread_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('assistantId') is not None:
            self.assistant_id = m.get('assistantId')
        if m.get('createdAt') is not None:
            self.created_at = m.get('createdAt')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('object') is not None:
            self.object = m.get('object')
        if m.get('role') is not None:
            self.role = m.get('role')
        if m.get('runId') is not None:
            self.run_id = m.get('runId')
        if m.get('threadId') is not None:
            self.thread_id = m.get('threadId')
        return self


class CreateAssistantMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateAssistantMessageResponseBody = None,
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
            temp_model = CreateAssistantMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateAssistantRunHeaders(TeaModel):
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


class CreateAssistantRunResponseBody(TeaModel):
    def __init__(
        self,
        assistant_id: str = None,
        cancelled_at: int = None,
        completed_at: int = None,
        created_at: int = None,
        expires_at: int = None,
        failed_at: int = None,
        id: str = None,
        last_error_msg: str = None,
        object: str = None,
        started_at: int = None,
        status: str = None,
        thread_id: str = None,
    ):
        self.assistant_id = assistant_id
        self.cancelled_at = cancelled_at
        self.completed_at = completed_at
        self.created_at = created_at
        self.expires_at = expires_at
        self.failed_at = failed_at
        self.id = id
        self.last_error_msg = last_error_msg
        self.object = object
        self.started_at = started_at
        self.status = status
        self.thread_id = thread_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.assistant_id is not None:
            result['assistantId'] = self.assistant_id
        if self.cancelled_at is not None:
            result['cancelledAt'] = self.cancelled_at
        if self.completed_at is not None:
            result['completedAt'] = self.completed_at
        if self.created_at is not None:
            result['createdAt'] = self.created_at
        if self.expires_at is not None:
            result['expiresAt'] = self.expires_at
        if self.failed_at is not None:
            result['failedAt'] = self.failed_at
        if self.id is not None:
            result['id'] = self.id
        if self.last_error_msg is not None:
            result['lastErrorMsg'] = self.last_error_msg
        if self.object is not None:
            result['object'] = self.object
        if self.started_at is not None:
            result['startedAt'] = self.started_at
        if self.status is not None:
            result['status'] = self.status
        if self.thread_id is not None:
            result['threadId'] = self.thread_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('assistantId') is not None:
            self.assistant_id = m.get('assistantId')
        if m.get('cancelledAt') is not None:
            self.cancelled_at = m.get('cancelledAt')
        if m.get('completedAt') is not None:
            self.completed_at = m.get('completedAt')
        if m.get('createdAt') is not None:
            self.created_at = m.get('createdAt')
        if m.get('expiresAt') is not None:
            self.expires_at = m.get('expiresAt')
        if m.get('failedAt') is not None:
            self.failed_at = m.get('failedAt')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('lastErrorMsg') is not None:
            self.last_error_msg = m.get('lastErrorMsg')
        if m.get('object') is not None:
            self.object = m.get('object')
        if m.get('startedAt') is not None:
            self.started_at = m.get('startedAt')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('threadId') is not None:
            self.thread_id = m.get('threadId')
        return self


class CreateAssistantRunResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateAssistantRunResponseBody = None,
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
            temp_model = CreateAssistantRunResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateAssistantThreadHeaders(TeaModel):
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


class CreateAssistantThreadResponseBody(TeaModel):
    def __init__(
        self,
        created_at: int = None,
        id: str = None,
        object: str = None,
    ):
        self.created_at = created_at
        self.id = id
        self.object = object

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.created_at is not None:
            result['createdAt'] = self.created_at
        if self.id is not None:
            result['id'] = self.id
        if self.object is not None:
            result['object'] = self.object
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createdAt') is not None:
            self.created_at = m.get('createdAt')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('object') is not None:
            self.object = m.get('object')
        return self


class CreateAssistantThreadResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateAssistantThreadResponseBody = None,
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
            temp_model = CreateAssistantThreadResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteAssistantMessageHeaders(TeaModel):
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


class DeleteAssistantMessageResponseBody(TeaModel):
    def __init__(
        self,
        deleted: bool = None,
        id: str = None,
        object: str = None,
    ):
        self.deleted = deleted
        self.id = id
        self.object = object

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.deleted is not None:
            result['deleted'] = self.deleted
        if self.id is not None:
            result['id'] = self.id
        if self.object is not None:
            result['object'] = self.object
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deleted') is not None:
            self.deleted = m.get('deleted')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('object') is not None:
            self.object = m.get('object')
        return self


class DeleteAssistantMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteAssistantMessageResponseBody = None,
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
            temp_model = DeleteAssistantMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteAssistantThreadHeaders(TeaModel):
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


class DeleteAssistantThreadResponseBody(TeaModel):
    def __init__(
        self,
        deleted: bool = None,
        id: str = None,
        object: str = None,
    ):
        self.deleted = deleted
        self.id = id
        self.object = object

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.deleted is not None:
            result['deleted'] = self.deleted
        if self.id is not None:
            result['id'] = self.id
        if self.object is not None:
            result['object'] = self.object
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deleted') is not None:
            self.deleted = m.get('deleted')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('object') is not None:
            self.object = m.get('object')
        return self


class DeleteAssistantThreadResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteAssistantThreadResponseBody = None,
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
            temp_model = DeleteAssistantThreadResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListAssistantMessageHeaders(TeaModel):
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


class ListAssistantMessageRequest(TeaModel):
    def __init__(
        self,
        limit: int = None,
        run_id: str = None,
    ):
        self.limit = limit
        self.run_id = run_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.limit is not None:
            result['limit'] = self.limit
        if self.run_id is not None:
            result['runId'] = self.run_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('limit') is not None:
            self.limit = m.get('limit')
        if m.get('runId') is not None:
            self.run_id = m.get('runId')
        return self


class ListAssistantMessageResponseBodyData(TeaModel):
    def __init__(
        self,
        assistant_id: str = None,
        content: List[Any] = None,
        created_at: int = None,
        id: str = None,
        object: str = None,
        role: str = None,
        run_id: str = None,
        thread_id: str = None,
    ):
        self.assistant_id = assistant_id
        self.content = content
        self.created_at = created_at
        self.id = id
        self.object = object
        self.role = role
        self.run_id = run_id
        self.thread_id = thread_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.assistant_id is not None:
            result['assistantId'] = self.assistant_id
        if self.content is not None:
            result['content'] = self.content
        if self.created_at is not None:
            result['createdAt'] = self.created_at
        if self.id is not None:
            result['id'] = self.id
        if self.object is not None:
            result['object'] = self.object
        if self.role is not None:
            result['role'] = self.role
        if self.run_id is not None:
            result['runId'] = self.run_id
        if self.thread_id is not None:
            result['threadId'] = self.thread_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('assistantId') is not None:
            self.assistant_id = m.get('assistantId')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('createdAt') is not None:
            self.created_at = m.get('createdAt')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('object') is not None:
            self.object = m.get('object')
        if m.get('role') is not None:
            self.role = m.get('role')
        if m.get('runId') is not None:
            self.run_id = m.get('runId')
        if m.get('threadId') is not None:
            self.thread_id = m.get('threadId')
        return self


class ListAssistantMessageResponseBody(TeaModel):
    def __init__(
        self,
        data: List[ListAssistantMessageResponseBodyData] = None,
        object: str = None,
    ):
        self.data = data
        self.object = object

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
        if self.object is not None:
            result['object'] = self.object
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = ListAssistantMessageResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('object') is not None:
            self.object = m.get('object')
        return self


class ListAssistantMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListAssistantMessageResponseBody = None,
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
            temp_model = ListAssistantMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RetrieveAssistantMessageHeaders(TeaModel):
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


class RetrieveAssistantMessageResponseBody(TeaModel):
    def __init__(
        self,
        assisant_id: str = None,
        content: List[Any] = None,
        created_at: int = None,
        id: str = None,
        object: str = None,
        role: str = None,
        run_id: str = None,
        thread_id: str = None,
    ):
        self.assisant_id = assisant_id
        self.content = content
        self.created_at = created_at
        self.id = id
        self.object = object
        self.role = role
        self.run_id = run_id
        self.thread_id = thread_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.assisant_id is not None:
            result['assisantId'] = self.assisant_id
        if self.content is not None:
            result['content'] = self.content
        if self.created_at is not None:
            result['createdAt'] = self.created_at
        if self.id is not None:
            result['id'] = self.id
        if self.object is not None:
            result['object'] = self.object
        if self.role is not None:
            result['role'] = self.role
        if self.run_id is not None:
            result['runId'] = self.run_id
        if self.thread_id is not None:
            result['threadId'] = self.thread_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('assisantId') is not None:
            self.assisant_id = m.get('assisantId')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('createdAt') is not None:
            self.created_at = m.get('createdAt')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('object') is not None:
            self.object = m.get('object')
        if m.get('role') is not None:
            self.role = m.get('role')
        if m.get('runId') is not None:
            self.run_id = m.get('runId')
        if m.get('threadId') is not None:
            self.thread_id = m.get('threadId')
        return self


class RetrieveAssistantMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RetrieveAssistantMessageResponseBody = None,
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
            temp_model = RetrieveAssistantMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RetrieveAssistantThreadHeaders(TeaModel):
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


class RetrieveAssistantThreadResponseBody(TeaModel):
    def __init__(
        self,
        created_at: int = None,
        id: str = None,
        object: str = None,
    ):
        self.created_at = created_at
        self.id = id
        self.object = object

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.created_at is not None:
            result['createdAt'] = self.created_at
        if self.id is not None:
            result['id'] = self.id
        if self.object is not None:
            result['object'] = self.object
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createdAt') is not None:
            self.created_at = m.get('createdAt')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('object') is not None:
            self.object = m.get('object')
        return self


class RetrieveAssistantThreadResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RetrieveAssistantThreadResponseBody = None,
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
            temp_model = RetrieveAssistantThreadResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


