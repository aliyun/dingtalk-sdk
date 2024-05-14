# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict


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


