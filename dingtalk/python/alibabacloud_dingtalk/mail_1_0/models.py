# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class CreateUserHeaders(TeaModel):
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


class CreateUserRequest(TeaModel):
    def __init__(
        self,
        email: str = None,
        employee_type: str = None,
        name: str = None,
        password: str = None,
    ):
        # This parameter is required.
        self.email = email
        # This parameter is required.
        self.employee_type = employee_type
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.password = password

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.email is not None:
            result['email'] = self.email
        if self.employee_type is not None:
            result['employeeType'] = self.employee_type
        if self.name is not None:
            result['name'] = self.name
        if self.password is not None:
            result['password'] = self.password
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('email') is not None:
            self.email = m.get('email')
        if m.get('employeeType') is not None:
            self.employee_type = m.get('employeeType')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('password') is not None:
            self.password = m.get('password')
        return self


class CreateUserResponseBody(TeaModel):
    def __init__(
        self,
        email: str = None,
    ):
        self.email = email

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.email is not None:
            result['email'] = self.email
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('email') is not None:
            self.email = m.get('email')
        return self


class CreateUserResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateUserResponseBody = None,
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
            temp_model = CreateUserResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListMailFoldersHeaders(TeaModel):
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


class ListMailFoldersRequest(TeaModel):
    def __init__(
        self,
        folder_id: str = None,
    ):
        self.folder_id = folder_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.folder_id is not None:
            result['folderId'] = self.folder_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('folderId') is not None:
            self.folder_id = m.get('folderId')
        return self


class ListMailFoldersResponseBodyFolders(TeaModel):
    def __init__(
        self,
        child_folder_count: int = None,
        display_name: str = None,
        extensions: Dict[str, str] = None,
        id: str = None,
        parent_folder_id: str = None,
        total_item_count: int = None,
        unread_item_count: int = None,
    ):
        # This parameter is required.
        self.child_folder_count = child_folder_count
        # This parameter is required.
        self.display_name = display_name
        self.extensions = extensions
        # This parameter is required.
        self.id = id
        # This parameter is required.
        self.parent_folder_id = parent_folder_id
        # This parameter is required.
        self.total_item_count = total_item_count
        # This parameter is required.
        self.unread_item_count = unread_item_count

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.child_folder_count is not None:
            result['childFolderCount'] = self.child_folder_count
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.extensions is not None:
            result['extensions'] = self.extensions
        if self.id is not None:
            result['id'] = self.id
        if self.parent_folder_id is not None:
            result['parentFolderId'] = self.parent_folder_id
        if self.total_item_count is not None:
            result['totalItemCount'] = self.total_item_count
        if self.unread_item_count is not None:
            result['unreadItemCount'] = self.unread_item_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('childFolderCount') is not None:
            self.child_folder_count = m.get('childFolderCount')
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('extensions') is not None:
            self.extensions = m.get('extensions')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('parentFolderId') is not None:
            self.parent_folder_id = m.get('parentFolderId')
        if m.get('totalItemCount') is not None:
            self.total_item_count = m.get('totalItemCount')
        if m.get('unreadItemCount') is not None:
            self.unread_item_count = m.get('unreadItemCount')
        return self


class ListMailFoldersResponseBody(TeaModel):
    def __init__(
        self,
        folders: List[ListMailFoldersResponseBodyFolders] = None,
    ):
        self.folders = folders

    def validate(self):
        if self.folders:
            for k in self.folders:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['folders'] = []
        if self.folders is not None:
            for k in self.folders:
                result['folders'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.folders = []
        if m.get('folders') is not None:
            for k in m.get('folders'):
                temp_model = ListMailFoldersResponseBodyFolders()
                self.folders.append(temp_model.from_map(k))
        return self


class ListMailFoldersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListMailFoldersResponseBody = None,
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
            temp_model = ListMailFoldersResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


