# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class CreateGroupBlackboardHeaders(TeaModel):
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


class CreateGroupBlackboardRequest(TeaModel):
    def __init__(
        self,
        content: str = None,
        open_conversation_id: str = None,
        send_ding: bool = None,
        sticky: bool = None,
        unique_id: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.content = content
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        self.send_ding = send_ding
        self.sticky = sticky
        # This parameter is required.
        self.unique_id = unique_id
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.send_ding is not None:
            result['sendDing'] = self.send_ding
        if self.sticky is not None:
            result['sticky'] = self.sticky
        if self.unique_id is not None:
            result['uniqueId'] = self.unique_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('sendDing') is not None:
            self.send_ding = m.get('sendDing')
        if m.get('sticky') is not None:
            self.sticky = m.get('sticky')
        if m.get('uniqueId') is not None:
            self.unique_id = m.get('uniqueId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CreateGroupBlackboardResponseBody(TeaModel):
    def __init__(
        self,
        data_id: str = None,
        success: bool = None,
    ):
        self.data_id = data_id
        # This parameter is required.
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_id is not None:
            result['dataId'] = self.data_id
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataId') is not None:
            self.data_id = m.get('dataId')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class CreateGroupBlackboardResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateGroupBlackboardResponseBody = None,
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
            temp_model = CreateGroupBlackboardResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateGroupBlackboardNewHeaders(TeaModel):
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


class CreateGroupBlackboardNewRequest(TeaModel):
    def __init__(
        self,
        content: str = None,
        open_conversation_id: str = None,
        send_ding: bool = None,
        sticky: bool = None,
        unique_id: str = None,
        user_id: str = None,
    ):
        self.content = content
        self.open_conversation_id = open_conversation_id
        self.send_ding = send_ding
        self.sticky = sticky
        self.unique_id = unique_id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.send_ding is not None:
            result['sendDing'] = self.send_ding
        if self.sticky is not None:
            result['sticky'] = self.sticky
        if self.unique_id is not None:
            result['uniqueId'] = self.unique_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('sendDing') is not None:
            self.send_ding = m.get('sendDing')
        if m.get('sticky') is not None:
            self.sticky = m.get('sticky')
        if m.get('uniqueId') is not None:
            self.unique_id = m.get('uniqueId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CreateGroupBlackboardNewResponseBody(TeaModel):
    def __init__(
        self,
        data_id: str = None,
        success: bool = None,
    ):
        self.data_id = data_id
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_id is not None:
            result['dataId'] = self.data_id
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataId') is not None:
            self.data_id = m.get('dataId')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class CreateGroupBlackboardNewResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateGroupBlackboardNewResponseBody = None,
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
            temp_model = CreateGroupBlackboardNewResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteGroupBlackboardHeaders(TeaModel):
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


class DeleteGroupBlackboardRequest(TeaModel):
    def __init__(
        self,
        data_id: str = None,
        open_conversation_id: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.data_id = data_id
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_id is not None:
            result['dataId'] = self.data_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataId') is not None:
            self.data_id = m.get('dataId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class DeleteGroupBlackboardResponseBody(TeaModel):
    def __init__(
        self,
        is_deleted: bool = None,
        success: bool = None,
    ):
        self.is_deleted = is_deleted
        # This parameter is required.
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.is_deleted is not None:
            result['isDeleted'] = self.is_deleted
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isDeleted') is not None:
            self.is_deleted = m.get('isDeleted')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class DeleteGroupBlackboardResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteGroupBlackboardResponseBody = None,
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
            temp_model = DeleteGroupBlackboardResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteGroupBlackboardNewHeaders(TeaModel):
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


class DeleteGroupBlackboardNewRequest(TeaModel):
    def __init__(
        self,
        data_id: str = None,
        open_conversation_id: str = None,
        user_id: str = None,
    ):
        self.data_id = data_id
        self.open_conversation_id = open_conversation_id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_id is not None:
            result['dataId'] = self.data_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataId') is not None:
            self.data_id = m.get('dataId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class DeleteGroupBlackboardNewResponseBody(TeaModel):
    def __init__(
        self,
        is_deleted: bool = None,
        success: bool = None,
    ):
        self.is_deleted = is_deleted
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.is_deleted is not None:
            result['isDeleted'] = self.is_deleted
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isDeleted') is not None:
            self.is_deleted = m.get('isDeleted')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class DeleteGroupBlackboardNewResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteGroupBlackboardNewResponseBody = None,
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
            temp_model = DeleteGroupBlackboardNewResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class EditGroupBlackboardHeaders(TeaModel):
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


class EditGroupBlackboardRequest(TeaModel):
    def __init__(
        self,
        content: str = None,
        data_id: str = None,
        open_conversation_id: str = None,
        sticky: bool = None,
        user_id: str = None,
    ):
        self.content = content
        self.data_id = data_id
        self.open_conversation_id = open_conversation_id
        self.sticky = sticky
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.data_id is not None:
            result['dataId'] = self.data_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.sticky is not None:
            result['sticky'] = self.sticky
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('dataId') is not None:
            self.data_id = m.get('dataId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('sticky') is not None:
            self.sticky = m.get('sticky')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class EditGroupBlackboardResponseBody(TeaModel):
    def __init__(
        self,
        data_id: str = None,
        success: bool = None,
    ):
        self.data_id = data_id
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_id is not None:
            result['dataId'] = self.data_id
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataId') is not None:
            self.data_id = m.get('dataId')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class EditGroupBlackboardResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: EditGroupBlackboardResponseBody = None,
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
            temp_model = EditGroupBlackboardResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetGroupBlackboardHeaders(TeaModel):
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


class GetGroupBlackboardRequest(TeaModel):
    def __init__(
        self,
        data_id: str = None,
        open_conversation_id: str = None,
        user_id: str = None,
    ):
        self.data_id = data_id
        self.open_conversation_id = open_conversation_id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_id is not None:
            result['dataId'] = self.data_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataId') is not None:
            self.data_id = m.get('dataId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetGroupBlackboardResponseBodyResult(TeaModel):
    def __init__(
        self,
        content: str = None,
        data_id: str = None,
        gmt_create: int = None,
        gmt_modified: int = None,
        read_count: int = None,
        sticky: bool = None,
        title: str = None,
        user_id: str = None,
        user_name: str = None,
    ):
        self.content = content
        self.data_id = data_id
        self.gmt_create = gmt_create
        self.gmt_modified = gmt_modified
        self.read_count = read_count
        self.sticky = sticky
        self.title = title
        self.user_id = user_id
        self.user_name = user_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.data_id is not None:
            result['dataId'] = self.data_id
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.read_count is not None:
            result['readCount'] = self.read_count
        if self.sticky is not None:
            result['sticky'] = self.sticky
        if self.title is not None:
            result['title'] = self.title
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.user_name is not None:
            result['userName'] = self.user_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('dataId') is not None:
            self.data_id = m.get('dataId')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('readCount') is not None:
            self.read_count = m.get('readCount')
        if m.get('sticky') is not None:
            self.sticky = m.get('sticky')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('userName') is not None:
            self.user_name = m.get('userName')
        return self


class GetGroupBlackboardResponseBody(TeaModel):
    def __init__(
        self,
        result: GetGroupBlackboardResponseBodyResult = None,
        success: bool = None,
    ):
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
        if self.result is not None:
            result['result'] = self.result.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = GetGroupBlackboardResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetGroupBlackboardResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetGroupBlackboardResponseBody = None,
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
            temp_model = GetGroupBlackboardResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListGroupBlackboardHeaders(TeaModel):
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


class ListGroupBlackboardRequest(TeaModel):
    def __init__(
        self,
        next_page_cursor: str = None,
        open_conversation_id: str = None,
        page_size: int = None,
        user_id: str = None,
    ):
        self.next_page_cursor = next_page_cursor
        self.open_conversation_id = open_conversation_id
        self.page_size = page_size
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_page_cursor is not None:
            result['nextPageCursor'] = self.next_page_cursor
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextPageCursor') is not None:
            self.next_page_cursor = m.get('nextPageCursor')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class ListGroupBlackboardResponseBodyBlackboardList(TeaModel):
    def __init__(
        self,
        content: str = None,
        data_id: str = None,
        gmt_create: int = None,
        gmt_modified: int = None,
        read_count: int = None,
        sticky: bool = None,
        title: str = None,
        user_id: str = None,
        user_name: str = None,
    ):
        self.content = content
        self.data_id = data_id
        self.gmt_create = gmt_create
        self.gmt_modified = gmt_modified
        self.read_count = read_count
        self.sticky = sticky
        self.title = title
        self.user_id = user_id
        self.user_name = user_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.data_id is not None:
            result['dataId'] = self.data_id
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.read_count is not None:
            result['readCount'] = self.read_count
        if self.sticky is not None:
            result['sticky'] = self.sticky
        if self.title is not None:
            result['title'] = self.title
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.user_name is not None:
            result['userName'] = self.user_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('dataId') is not None:
            self.data_id = m.get('dataId')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('readCount') is not None:
            self.read_count = m.get('readCount')
        if m.get('sticky') is not None:
            self.sticky = m.get('sticky')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('userName') is not None:
            self.user_name = m.get('userName')
        return self


class ListGroupBlackboardResponseBody(TeaModel):
    def __init__(
        self,
        blackboard_list: List[ListGroupBlackboardResponseBodyBlackboardList] = None,
        has_more: bool = None,
        next_page_cursor: str = None,
        success: bool = None,
    ):
        self.blackboard_list = blackboard_list
        self.has_more = has_more
        self.next_page_cursor = next_page_cursor
        self.success = success

    def validate(self):
        if self.blackboard_list:
            for k in self.blackboard_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['blackboardList'] = []
        if self.blackboard_list is not None:
            for k in self.blackboard_list:
                result['blackboardList'].append(k.to_map() if k else None)
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.next_page_cursor is not None:
            result['nextPageCursor'] = self.next_page_cursor
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.blackboard_list = []
        if m.get('blackboardList') is not None:
            for k in m.get('blackboardList'):
                temp_model = ListGroupBlackboardResponseBodyBlackboardList()
                self.blackboard_list.append(temp_model.from_map(k))
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextPageCursor') is not None:
            self.next_page_cursor = m.get('nextPageCursor')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class ListGroupBlackboardResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListGroupBlackboardResponseBody = None,
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
            temp_model = ListGroupBlackboardResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


