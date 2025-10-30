# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class GetBlackboardHeaders(TeaModel):
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


class GetBlackboardRequest(TeaModel):
    def __init__(
        self,
        blackboard_id: str = None,
        operation_user_id: str = None,
    ):
        self.blackboard_id = blackboard_id
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
        if self.operation_user_id is not None:
            result['operationUserId'] = self.operation_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('blackboardId') is not None:
            self.blackboard_id = m.get('blackboardId')
        if m.get('operationUserId') is not None:
            self.operation_user_id = m.get('operationUserId')
        return self


class GetBlackboardResponseBodyAttachments(TeaModel):
    def __init__(
        self,
        dentry_id: str = None,
        file_name: str = None,
        file_type: str = None,
        space_id: str = None,
    ):
        self.dentry_id = dentry_id
        self.file_name = file_name
        self.file_type = file_type
        self.space_id = space_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dentry_id is not None:
            result['dentryId'] = self.dentry_id
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.file_type is not None:
            result['fileType'] = self.file_type
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dentryId') is not None:
            self.dentry_id = m.get('dentryId')
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('fileType') is not None:
            self.file_type = m.get('fileType')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        return self


class GetBlackboardResponseBodyDeptList(TeaModel):
    def __init__(
        self,
        dept_id: str = None,
        name: str = None,
    ):
        self.dept_id = dept_id
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class GetBlackboardResponseBodyUserList(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        name: str = None,
        staff_id: str = None,
    ):
        self.corp_id = corp_id
        self.name = name
        self.staff_id = staff_id

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
        if self.staff_id is not None:
            result['staffId'] = self.staff_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('staffId') is not None:
            self.staff_id = m.get('staffId')
        return self


class GetBlackboardResponseBody(TeaModel):
    def __init__(
        self,
        attachments: List[GetBlackboardResponseBodyAttachments] = None,
        category_id: str = None,
        category_name: str = None,
        content: str = None,
        cover_pic_url: str = None,
        dep_name_list: List[str] = None,
        dept_list: List[GetBlackboardResponseBodyDeptList] = None,
        gmt_create: str = None,
        gmt_modified: str = None,
        id: str = None,
        is_push_top: int = None,
        private_level: int = None,
        read_count: int = None,
        sender_staff_id: str = None,
        title: str = None,
        un_read_count: int = None,
        user_list: List[GetBlackboardResponseBodyUserList] = None,
        user_name_list: List[str] = None,
    ):
        self.attachments = attachments
        self.category_id = category_id
        self.category_name = category_name
        self.content = content
        self.cover_pic_url = cover_pic_url
        self.dep_name_list = dep_name_list
        self.dept_list = dept_list
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.gmt_create = gmt_create
        # Use the UTC time format: yyyy-MM-ddTHH:mmZ
        self.gmt_modified = gmt_modified
        self.id = id
        self.is_push_top = is_push_top
        self.private_level = private_level
        self.read_count = read_count
        self.sender_staff_id = sender_staff_id
        self.title = title
        self.un_read_count = un_read_count
        self.user_list = user_list
        self.user_name_list = user_name_list

    def validate(self):
        if self.attachments:
            for k in self.attachments:
                if k:
                    k.validate()
        if self.dept_list:
            for k in self.dept_list:
                if k:
                    k.validate()
        if self.user_list:
            for k in self.user_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['attachments'] = []
        if self.attachments is not None:
            for k in self.attachments:
                result['attachments'].append(k.to_map() if k else None)
        if self.category_id is not None:
            result['categoryId'] = self.category_id
        if self.category_name is not None:
            result['categoryName'] = self.category_name
        if self.content is not None:
            result['content'] = self.content
        if self.cover_pic_url is not None:
            result['coverPicUrl'] = self.cover_pic_url
        if self.dep_name_list is not None:
            result['depNameList'] = self.dep_name_list
        result['deptList'] = []
        if self.dept_list is not None:
            for k in self.dept_list:
                result['deptList'].append(k.to_map() if k else None)
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.id is not None:
            result['id'] = self.id
        if self.is_push_top is not None:
            result['isPushTop'] = self.is_push_top
        if self.private_level is not None:
            result['privateLevel'] = self.private_level
        if self.read_count is not None:
            result['readCount'] = self.read_count
        if self.sender_staff_id is not None:
            result['senderStaffId'] = self.sender_staff_id
        if self.title is not None:
            result['title'] = self.title
        if self.un_read_count is not None:
            result['unReadCount'] = self.un_read_count
        result['userList'] = []
        if self.user_list is not None:
            for k in self.user_list:
                result['userList'].append(k.to_map() if k else None)
        if self.user_name_list is not None:
            result['userNameList'] = self.user_name_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attachments = []
        if m.get('attachments') is not None:
            for k in m.get('attachments'):
                temp_model = GetBlackboardResponseBodyAttachments()
                self.attachments.append(temp_model.from_map(k))
        if m.get('categoryId') is not None:
            self.category_id = m.get('categoryId')
        if m.get('categoryName') is not None:
            self.category_name = m.get('categoryName')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('coverPicUrl') is not None:
            self.cover_pic_url = m.get('coverPicUrl')
        if m.get('depNameList') is not None:
            self.dep_name_list = m.get('depNameList')
        self.dept_list = []
        if m.get('deptList') is not None:
            for k in m.get('deptList'):
                temp_model = GetBlackboardResponseBodyDeptList()
                self.dept_list.append(temp_model.from_map(k))
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isPushTop') is not None:
            self.is_push_top = m.get('isPushTop')
        if m.get('privateLevel') is not None:
            self.private_level = m.get('privateLevel')
        if m.get('readCount') is not None:
            self.read_count = m.get('readCount')
        if m.get('senderStaffId') is not None:
            self.sender_staff_id = m.get('senderStaffId')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('unReadCount') is not None:
            self.un_read_count = m.get('unReadCount')
        self.user_list = []
        if m.get('userList') is not None:
            for k in m.get('userList'):
                temp_model = GetBlackboardResponseBodyUserList()
                self.user_list.append(temp_model.from_map(k))
        if m.get('userNameList') is not None:
            self.user_name_list = m.get('userNameList')
        return self


class GetBlackboardResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetBlackboardResponseBody = None,
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
            temp_model = GetBlackboardResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


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


