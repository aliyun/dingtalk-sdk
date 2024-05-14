# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class QueryBlackboardReadUnReadHeaders(TeaModel):
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


class QueryBlackboardReadUnReadRequest(TeaModel):
    def __init__(
        self,
        blackboard_id: str = None,
        max_results: int = None,
        next_token: str = None,
        operation_user_id: str = None,
    ):
        # This parameter is required.
        self.blackboard_id = blackboard_id
        # This parameter is required.
        self.max_results = max_results
        self.next_token = next_token
        # This parameter is required.
        self.operation_user_id = operation_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.blackboard_id is not None:
            result['blackboardId'] = self.blackboard_id
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.operation_user_id is not None:
            result['operationUserId'] = self.operation_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('blackboardId') is not None:
            self.blackboard_id = m.get('blackboardId')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('operationUserId') is not None:
            self.operation_user_id = m.get('operationUserId')
        return self


class QueryBlackboardReadUnReadResponseBodyUsers(TeaModel):
    def __init__(
        self,
        read: str = None,
        read_timestamp: int = None,
        user_id: str = None,
    ):
        self.read = read
        self.read_timestamp = read_timestamp
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.read is not None:
            result['read'] = self.read
        if self.read_timestamp is not None:
            result['readTimestamp'] = self.read_timestamp
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('read') is not None:
            self.read = m.get('read')
        if m.get('readTimestamp') is not None:
            self.read_timestamp = m.get('readTimestamp')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryBlackboardReadUnReadResponseBody(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        users: List[QueryBlackboardReadUnReadResponseBodyUsers] = None,
    ):
        self.next_token = next_token
        self.users = users

    def validate(self):
        if self.users:
            for k in self.users:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['users'] = []
        if self.users is not None:
            for k in self.users:
                result['users'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.users = []
        if m.get('users') is not None:
            for k in m.get('users'):
                temp_model = QueryBlackboardReadUnReadResponseBodyUsers()
                self.users.append(temp_model.from_map(k))
        return self


class QueryBlackboardReadUnReadResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryBlackboardReadUnReadResponseBody = None,
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
            temp_model = QueryBlackboardReadUnReadResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryBlackboardSpaceHeaders(TeaModel):
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


class QueryBlackboardSpaceRequest(TeaModel):
    def __init__(
        self,
        operation_user_id: str = None,
    ):
        # This parameter is required.
        self.operation_user_id = operation_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operation_user_id is not None:
            result['operationUserId'] = self.operation_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operationUserId') is not None:
            self.operation_user_id = m.get('operationUserId')
        return self


class QueryBlackboardSpaceResponseBody(TeaModel):
    def __init__(
        self,
        space_id: str = None,
    ):
        self.space_id = space_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        return self


class QueryBlackboardSpaceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryBlackboardSpaceResponseBody = None,
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
            temp_model = QueryBlackboardSpaceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


