# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List, Any


class AttachmentsMapValue(TeaModel):
    def __init__(
        self,
        upload_key: str = None,
        name: str = None,
        media_type: str = None,
    ):
        self.upload_key = upload_key
        self.name = name
        self.media_type = media_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.upload_key is not None:
            result['uploadKey'] = self.upload_key
        if self.name is not None:
            result['name'] = self.name
        if self.media_type is not None:
            result['mediaType'] = self.media_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('uploadKey') is not None:
            self.upload_key = m.get('uploadKey')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('mediaType') is not None:
            self.media_type = m.get('mediaType')
        return self


class AddCommentHeaders(TeaModel):
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


class AddCommentRequestOption(TeaModel):
    def __init__(
        self,
        create_time: str = None,
        extra: Dict[str, str] = None,
    ):
        self.create_time = create_time
        self.extra = extra

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.extra is not None:
            result['extra'] = self.extra
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('extra') is not None:
            self.extra = m.get('extra')
        return self


class AddCommentRequest(TeaModel):
    def __init__(
        self,
        comment_content: str = None,
        comment_type: str = None,
        option: AddCommentRequestOption = None,
        operator_id: str = None,
    ):
        self.comment_content = comment_content
        self.comment_type = comment_type
        self.option = option
        self.operator_id = operator_id

    def validate(self):
        if self.option:
            self.option.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.comment_content is not None:
            result['commentContent'] = self.comment_content
        if self.comment_type is not None:
            result['commentType'] = self.comment_type
        if self.option is not None:
            result['option'] = self.option.to_map()
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commentContent') is not None:
            self.comment_content = m.get('commentContent')
        if m.get('commentType') is not None:
            self.comment_type = m.get('commentType')
        if m.get('option') is not None:
            temp_model = AddCommentRequestOption()
            self.option = temp_model.from_map(m['option'])
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class AddCommentResponseBody(TeaModel):
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


class AddCommentResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AddCommentResponseBody = None,
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
            temp_model = AddCommentResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AddWorkspaceDocMembersHeaders(TeaModel):
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


class AddWorkspaceDocMembersRequestMembers(TeaModel):
    def __init__(
        self,
        member_id: str = None,
        member_type: str = None,
        role_type: str = None,
    ):
        self.member_id = member_id
        self.member_type = member_type
        self.role_type = role_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.member_id is not None:
            result['memberId'] = self.member_id
        if self.member_type is not None:
            result['memberType'] = self.member_type
        if self.role_type is not None:
            result['roleType'] = self.role_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('memberId') is not None:
            self.member_id = m.get('memberId')
        if m.get('memberType') is not None:
            self.member_type = m.get('memberType')
        if m.get('roleType') is not None:
            self.role_type = m.get('roleType')
        return self


class AddWorkspaceDocMembersRequest(TeaModel):
    def __init__(
        self,
        members: List[AddWorkspaceDocMembersRequestMembers] = None,
        operator_id: str = None,
    ):
        self.members = members
        self.operator_id = operator_id

    def validate(self):
        if self.members:
            for k in self.members:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['members'] = []
        if self.members is not None:
            for k in self.members:
                result['members'].append(k.to_map() if k else None)
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.members = []
        if m.get('members') is not None:
            for k in m.get('members'):
                temp_model = AddWorkspaceDocMembersRequestMembers()
                self.members.append(temp_model.from_map(k))
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class AddWorkspaceDocMembersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
    ):
        self.headers = headers
        self.status_code = status_code

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        return self


class AddWorkspaceMembersHeaders(TeaModel):
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


class AddWorkspaceMembersRequestMembers(TeaModel):
    def __init__(
        self,
        member_id: str = None,
        member_type: str = None,
        role_type: str = None,
    ):
        self.member_id = member_id
        self.member_type = member_type
        self.role_type = role_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.member_id is not None:
            result['memberId'] = self.member_id
        if self.member_type is not None:
            result['memberType'] = self.member_type
        if self.role_type is not None:
            result['roleType'] = self.role_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('memberId') is not None:
            self.member_id = m.get('memberId')
        if m.get('memberType') is not None:
            self.member_type = m.get('memberType')
        if m.get('roleType') is not None:
            self.role_type = m.get('roleType')
        return self


class AddWorkspaceMembersRequest(TeaModel):
    def __init__(
        self,
        members: List[AddWorkspaceMembersRequestMembers] = None,
        operator_id: str = None,
    ):
        self.members = members
        self.operator_id = operator_id

    def validate(self):
        if self.members:
            for k in self.members:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['members'] = []
        if self.members is not None:
            for k in self.members:
                result['members'].append(k.to_map() if k else None)
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.members = []
        if m.get('members') is not None:
            for k in m.get('members'):
                temp_model = AddWorkspaceMembersRequestMembers()
                self.members.append(temp_model.from_map(k))
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class AddWorkspaceMembersResponseBody(TeaModel):
    def __init__(
        self,
        not_in_org_list: List[str] = None,
    ):
        self.not_in_org_list = not_in_org_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.not_in_org_list is not None:
            result['notInOrgList'] = self.not_in_org_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('notInOrgList') is not None:
            self.not_in_org_list = m.get('notInOrgList')
        return self


class AddWorkspaceMembersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AddWorkspaceMembersResponseBody = None,
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
            temp_model = AddWorkspaceMembersResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AppendRowsHeaders(TeaModel):
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


class AppendRowsRequest(TeaModel):
    def __init__(
        self,
        values: List[List[str]] = None,
        operator_id: str = None,
    ):
        self.values = values
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.values is not None:
            result['values'] = self.values
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('values') is not None:
            self.values = m.get('values')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class AppendRowsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
    ):
        self.headers = headers
        self.status_code = status_code

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        return self


class BatchHeaders(TeaModel):
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


class BatchRequestRequests(TeaModel):
    def __init__(
        self,
        body: Any = None,
        method: str = None,
        path: str = None,
    ):
        self.body = body
        self.method = method
        self.path = path

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.body is not None:
            result['body'] = self.body
        if self.method is not None:
            result['method'] = self.method
        if self.path is not None:
            result['path'] = self.path
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('body') is not None:
            self.body = m.get('body')
        if m.get('method') is not None:
            self.method = m.get('method')
        if m.get('path') is not None:
            self.path = m.get('path')
        return self


class BatchRequest(TeaModel):
    def __init__(
        self,
        requests: List[BatchRequestRequests] = None,
        operator_id: str = None,
    ):
        self.requests = requests
        self.operator_id = operator_id

    def validate(self):
        if self.requests:
            for k in self.requests:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['requests'] = []
        if self.requests is not None:
            for k in self.requests:
                result['requests'].append(k.to_map() if k else None)
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.requests = []
        if m.get('requests') is not None:
            for k in m.get('requests'):
                temp_model = BatchRequestRequests()
                self.requests.append(temp_model.from_map(k))
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class BatchResponseBody(TeaModel):
    def __init__(
        self,
        responses: List[Any] = None,
    ):
        self.responses = responses

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.responses is not None:
            result['responses'] = self.responses
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('responses') is not None:
            self.responses = m.get('responses')
        return self


class BatchResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BatchResponseBody = None,
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
            temp_model = BatchResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BatchGetWorkspaceDocsHeaders(TeaModel):
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


class BatchGetWorkspaceDocsRequest(TeaModel):
    def __init__(
        self,
        node_ids: List[str] = None,
        operator_id: str = None,
    ):
        self.node_ids = node_ids
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.node_ids is not None:
            result['nodeIds'] = self.node_ids
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nodeIds') is not None:
            self.node_ids = m.get('nodeIds')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class BatchGetWorkspaceDocsResponseBodyResultNodeBO(TeaModel):
    def __init__(
        self,
        deleted: bool = None,
        doc_type: str = None,
        last_edit_time: int = None,
        name: str = None,
        node_id: str = None,
        url: str = None,
    ):
        self.deleted = deleted
        self.doc_type = doc_type
        self.last_edit_time = last_edit_time
        self.name = name
        self.node_id = node_id
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.deleted is not None:
            result['deleted'] = self.deleted
        if self.doc_type is not None:
            result['docType'] = self.doc_type
        if self.last_edit_time is not None:
            result['lastEditTime'] = self.last_edit_time
        if self.name is not None:
            result['name'] = self.name
        if self.node_id is not None:
            result['nodeId'] = self.node_id
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deleted') is not None:
            self.deleted = m.get('deleted')
        if m.get('docType') is not None:
            self.doc_type = m.get('docType')
        if m.get('lastEditTime') is not None:
            self.last_edit_time = m.get('lastEditTime')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('nodeId') is not None:
            self.node_id = m.get('nodeId')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class BatchGetWorkspaceDocsResponseBodyResultWorkspaceBO(TeaModel):
    def __init__(
        self,
        name: str = None,
        workspace_id: str = None,
    ):
        self.name = name
        self.workspace_id = workspace_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.workspace_id is not None:
            result['workspaceId'] = self.workspace_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('workspaceId') is not None:
            self.workspace_id = m.get('workspaceId')
        return self


class BatchGetWorkspaceDocsResponseBodyResult(TeaModel):
    def __init__(
        self,
        has_permission: bool = None,
        node_bo: BatchGetWorkspaceDocsResponseBodyResultNodeBO = None,
        workspace_bo: BatchGetWorkspaceDocsResponseBodyResultWorkspaceBO = None,
    ):
        self.has_permission = has_permission
        self.node_bo = node_bo
        self.workspace_bo = workspace_bo

    def validate(self):
        if self.node_bo:
            self.node_bo.validate()
        if self.workspace_bo:
            self.workspace_bo.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_permission is not None:
            result['hasPermission'] = self.has_permission
        if self.node_bo is not None:
            result['nodeBO'] = self.node_bo.to_map()
        if self.workspace_bo is not None:
            result['workspaceBO'] = self.workspace_bo.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasPermission') is not None:
            self.has_permission = m.get('hasPermission')
        if m.get('nodeBO') is not None:
            temp_model = BatchGetWorkspaceDocsResponseBodyResultNodeBO()
            self.node_bo = temp_model.from_map(m['nodeBO'])
        if m.get('workspaceBO') is not None:
            temp_model = BatchGetWorkspaceDocsResponseBodyResultWorkspaceBO()
            self.workspace_bo = temp_model.from_map(m['workspaceBO'])
        return self


class BatchGetWorkspaceDocsResponseBody(TeaModel):
    def __init__(
        self,
        result: List[BatchGetWorkspaceDocsResponseBodyResult] = None,
    ):
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
                temp_model = BatchGetWorkspaceDocsResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class BatchGetWorkspaceDocsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BatchGetWorkspaceDocsResponseBody = None,
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
            temp_model = BatchGetWorkspaceDocsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BatchGetWorkspacesHeaders(TeaModel):
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


class BatchGetWorkspacesRequest(TeaModel):
    def __init__(
        self,
        include_recent: bool = None,
        operator_id: str = None,
        workspace_ids: List[str] = None,
    ):
        self.include_recent = include_recent
        self.operator_id = operator_id
        self.workspace_ids = workspace_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.include_recent is not None:
            result['includeRecent'] = self.include_recent
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.workspace_ids is not None:
            result['workspaceIds'] = self.workspace_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('includeRecent') is not None:
            self.include_recent = m.get('includeRecent')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('workspaceIds') is not None:
            self.workspace_ids = m.get('workspaceIds')
        return self


class BatchGetWorkspacesResponseBodyWorkspacesWorkspaceRecentList(TeaModel):
    def __init__(
        self,
        last_edit_time: str = None,
        name: str = None,
        node_id: str = None,
        url: str = None,
    ):
        self.last_edit_time = last_edit_time
        self.name = name
        self.node_id = node_id
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.last_edit_time is not None:
            result['lastEditTime'] = self.last_edit_time
        if self.name is not None:
            result['name'] = self.name
        if self.node_id is not None:
            result['nodeId'] = self.node_id
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('lastEditTime') is not None:
            self.last_edit_time = m.get('lastEditTime')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('nodeId') is not None:
            self.node_id = m.get('nodeId')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class BatchGetWorkspacesResponseBodyWorkspacesWorkspace(TeaModel):
    def __init__(
        self,
        create_time: int = None,
        name: str = None,
        org_published: bool = None,
        recent_list: List[BatchGetWorkspacesResponseBodyWorkspacesWorkspaceRecentList] = None,
        url: str = None,
        workspace_id: str = None,
    ):
        self.create_time = create_time
        self.name = name
        self.org_published = org_published
        self.recent_list = recent_list
        self.url = url
        self.workspace_id = workspace_id

    def validate(self):
        if self.recent_list:
            for k in self.recent_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.name is not None:
            result['name'] = self.name
        if self.org_published is not None:
            result['orgPublished'] = self.org_published
        result['recentList'] = []
        if self.recent_list is not None:
            for k in self.recent_list:
                result['recentList'].append(k.to_map() if k else None)
        if self.url is not None:
            result['url'] = self.url
        if self.workspace_id is not None:
            result['workspaceId'] = self.workspace_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('orgPublished') is not None:
            self.org_published = m.get('orgPublished')
        self.recent_list = []
        if m.get('recentList') is not None:
            for k in m.get('recentList'):
                temp_model = BatchGetWorkspacesResponseBodyWorkspacesWorkspaceRecentList()
                self.recent_list.append(temp_model.from_map(k))
        if m.get('url') is not None:
            self.url = m.get('url')
        if m.get('workspaceId') is not None:
            self.workspace_id = m.get('workspaceId')
        return self


class BatchGetWorkspacesResponseBodyWorkspaces(TeaModel):
    def __init__(
        self,
        has_permission: bool = None,
        workspace: BatchGetWorkspacesResponseBodyWorkspacesWorkspace = None,
    ):
        self.has_permission = has_permission
        self.workspace = workspace

    def validate(self):
        if self.workspace:
            self.workspace.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_permission is not None:
            result['hasPermission'] = self.has_permission
        if self.workspace is not None:
            result['workspace'] = self.workspace.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasPermission') is not None:
            self.has_permission = m.get('hasPermission')
        if m.get('workspace') is not None:
            temp_model = BatchGetWorkspacesResponseBodyWorkspacesWorkspace()
            self.workspace = temp_model.from_map(m['workspace'])
        return self


class BatchGetWorkspacesResponseBody(TeaModel):
    def __init__(
        self,
        workspaces: List[BatchGetWorkspacesResponseBodyWorkspaces] = None,
    ):
        self.workspaces = workspaces

    def validate(self):
        if self.workspaces:
            for k in self.workspaces:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['workspaces'] = []
        if self.workspaces is not None:
            for k in self.workspaces:
                result['workspaces'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.workspaces = []
        if m.get('workspaces') is not None:
            for k in m.get('workspaces'):
                temp_model = BatchGetWorkspacesResponseBodyWorkspaces()
                self.workspaces.append(temp_model.from_map(k))
        return self


class BatchGetWorkspacesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BatchGetWorkspacesResponseBody = None,
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
            temp_model = BatchGetWorkspacesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BindCoolAppToSheetHeaders(TeaModel):
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


class BindCoolAppToSheetRequest(TeaModel):
    def __init__(
        self,
        cool_app_code: str = None,
        operator_id: str = None,
    ):
        self.cool_app_code = cool_app_code
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cool_app_code is not None:
            result['coolAppCode'] = self.cool_app_code
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('coolAppCode') is not None:
            self.cool_app_code = m.get('coolAppCode')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class BindCoolAppToSheetResponseBody(TeaModel):
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


class BindCoolAppToSheetResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BindCoolAppToSheetResponseBody = None,
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
            temp_model = BindCoolAppToSheetResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ClearHeaders(TeaModel):
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


class ClearRequest(TeaModel):
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


class ClearResponseBody(TeaModel):
    def __init__(
        self,
        a_1notation: str = None,
    ):
        self.a_1notation = a_1notation

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.a_1notation is not None:
            result['a1Notation'] = self.a_1notation
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('a1Notation') is not None:
            self.a_1notation = m.get('a1Notation')
        return self


class ClearResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ClearResponseBody = None,
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
            temp_model = ClearResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ClearDataHeaders(TeaModel):
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


class ClearDataRequest(TeaModel):
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


class ClearDataResponseBody(TeaModel):
    def __init__(
        self,
        a_1notation: str = None,
    ):
        self.a_1notation = a_1notation

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.a_1notation is not None:
            result['a1Notation'] = self.a_1notation
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('a1Notation') is not None:
            self.a_1notation = m.get('a1Notation')
        return self


class ClearDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ClearDataResponseBody = None,
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
            temp_model = ClearDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateConditionalFormattingRuleHeaders(TeaModel):
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


class CreateConditionalFormattingRuleRequestCellStyle(TeaModel):
    def __init__(
        self,
        background_color: str = None,
    ):
        self.background_color = background_color

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.background_color is not None:
            result['backgroundColor'] = self.background_color
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('backgroundColor') is not None:
            self.background_color = m.get('backgroundColor')
        return self


class CreateConditionalFormattingRuleRequestDuplicateCondition(TeaModel):
    def __init__(
        self,
        operator: str = None,
    ):
        self.operator = operator

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operator is not None:
            result['operator'] = self.operator
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        return self


class CreateConditionalFormattingRuleRequest(TeaModel):
    def __init__(
        self,
        cell_style: CreateConditionalFormattingRuleRequestCellStyle = None,
        duplicate_condition: CreateConditionalFormattingRuleRequestDuplicateCondition = None,
        ranges: List[str] = None,
        operator_id: str = None,
    ):
        self.cell_style = cell_style
        self.duplicate_condition = duplicate_condition
        self.ranges = ranges
        self.operator_id = operator_id

    def validate(self):
        if self.cell_style:
            self.cell_style.validate()
        if self.duplicate_condition:
            self.duplicate_condition.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cell_style is not None:
            result['cellStyle'] = self.cell_style.to_map()
        if self.duplicate_condition is not None:
            result['duplicateCondition'] = self.duplicate_condition.to_map()
        if self.ranges is not None:
            result['ranges'] = self.ranges
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cellStyle') is not None:
            temp_model = CreateConditionalFormattingRuleRequestCellStyle()
            self.cell_style = temp_model.from_map(m['cellStyle'])
        if m.get('duplicateCondition') is not None:
            temp_model = CreateConditionalFormattingRuleRequestDuplicateCondition()
            self.duplicate_condition = temp_model.from_map(m['duplicateCondition'])
        if m.get('ranges') is not None:
            self.ranges = m.get('ranges')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class CreateConditionalFormattingRuleResponseBody(TeaModel):
    def __init__(
        self,
        id: str = None,
    ):
        self.id = id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        return self


class CreateConditionalFormattingRuleResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateConditionalFormattingRuleResponseBody = None,
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
            temp_model = CreateConditionalFormattingRuleResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateDeveloperMetadataHeaders(TeaModel):
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


class CreateDeveloperMetadataRequestAssociatedColumn(TeaModel):
    def __init__(
        self,
        column: int = None,
        sheet: str = None,
    ):
        self.column = column
        self.sheet = sheet

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.column is not None:
            result['column'] = self.column
        if self.sheet is not None:
            result['sheet'] = self.sheet
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('column') is not None:
            self.column = m.get('column')
        if m.get('sheet') is not None:
            self.sheet = m.get('sheet')
        return self


class CreateDeveloperMetadataRequestAssociatedRow(TeaModel):
    def __init__(
        self,
        row: int = None,
        sheet: str = None,
    ):
        self.row = row
        self.sheet = sheet

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.row is not None:
            result['row'] = self.row
        if self.sheet is not None:
            result['sheet'] = self.sheet
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('row') is not None:
            self.row = m.get('row')
        if m.get('sheet') is not None:
            self.sheet = m.get('sheet')
        return self


class CreateDeveloperMetadataRequest(TeaModel):
    def __init__(
        self,
        associated_column: CreateDeveloperMetadataRequestAssociatedColumn = None,
        associated_row: CreateDeveloperMetadataRequestAssociatedRow = None,
        value: str = None,
        operator_id: str = None,
    ):
        self.associated_column = associated_column
        self.associated_row = associated_row
        self.value = value
        self.operator_id = operator_id

    def validate(self):
        if self.associated_column:
            self.associated_column.validate()
        if self.associated_row:
            self.associated_row.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.associated_column is not None:
            result['associatedColumn'] = self.associated_column.to_map()
        if self.associated_row is not None:
            result['associatedRow'] = self.associated_row.to_map()
        if self.value is not None:
            result['value'] = self.value
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('associatedColumn') is not None:
            temp_model = CreateDeveloperMetadataRequestAssociatedColumn()
            self.associated_column = temp_model.from_map(m['associatedColumn'])
        if m.get('associatedRow') is not None:
            temp_model = CreateDeveloperMetadataRequestAssociatedRow()
            self.associated_row = temp_model.from_map(m['associatedRow'])
        if m.get('value') is not None:
            self.value = m.get('value')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class CreateDeveloperMetadataResponseBody(TeaModel):
    def __init__(
        self,
        id: str = None,
    ):
        self.id = id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        return self


class CreateDeveloperMetadataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateDeveloperMetadataResponseBody = None,
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
            temp_model = CreateDeveloperMetadataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateRangeProtectionHeaders(TeaModel):
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


class CreateRangeProtectionRequestEditableSetting(TeaModel):
    def __init__(
        self,
        delete_columns: bool = None,
        delete_rows: bool = None,
        edit_cells: bool = None,
        format_cells: bool = None,
        insert_columns: bool = None,
        insert_rows: bool = None,
        toggle_columns_visibility: bool = None,
        toggle_rows_visibility: bool = None,
    ):
        self.delete_columns = delete_columns
        self.delete_rows = delete_rows
        self.edit_cells = edit_cells
        self.format_cells = format_cells
        self.insert_columns = insert_columns
        self.insert_rows = insert_rows
        self.toggle_columns_visibility = toggle_columns_visibility
        self.toggle_rows_visibility = toggle_rows_visibility

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.delete_columns is not None:
            result['deleteColumns'] = self.delete_columns
        if self.delete_rows is not None:
            result['deleteRows'] = self.delete_rows
        if self.edit_cells is not None:
            result['editCells'] = self.edit_cells
        if self.format_cells is not None:
            result['formatCells'] = self.format_cells
        if self.insert_columns is not None:
            result['insertColumns'] = self.insert_columns
        if self.insert_rows is not None:
            result['insertRows'] = self.insert_rows
        if self.toggle_columns_visibility is not None:
            result['toggleColumnsVisibility'] = self.toggle_columns_visibility
        if self.toggle_rows_visibility is not None:
            result['toggleRowsVisibility'] = self.toggle_rows_visibility
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deleteColumns') is not None:
            self.delete_columns = m.get('deleteColumns')
        if m.get('deleteRows') is not None:
            self.delete_rows = m.get('deleteRows')
        if m.get('editCells') is not None:
            self.edit_cells = m.get('editCells')
        if m.get('formatCells') is not None:
            self.format_cells = m.get('formatCells')
        if m.get('insertColumns') is not None:
            self.insert_columns = m.get('insertColumns')
        if m.get('insertRows') is not None:
            self.insert_rows = m.get('insertRows')
        if m.get('toggleColumnsVisibility') is not None:
            self.toggle_columns_visibility = m.get('toggleColumnsVisibility')
        if m.get('toggleRowsVisibility') is not None:
            self.toggle_rows_visibility = m.get('toggleRowsVisibility')
        return self


class CreateRangeProtectionRequest(TeaModel):
    def __init__(
        self,
        editable_setting: CreateRangeProtectionRequestEditableSetting = None,
        other_user_permission: str = None,
        operator_id: str = None,
    ):
        self.editable_setting = editable_setting
        self.other_user_permission = other_user_permission
        self.operator_id = operator_id

    def validate(self):
        if self.editable_setting:
            self.editable_setting.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.editable_setting is not None:
            result['editableSetting'] = self.editable_setting.to_map()
        if self.other_user_permission is not None:
            result['otherUserPermission'] = self.other_user_permission
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('editableSetting') is not None:
            temp_model = CreateRangeProtectionRequestEditableSetting()
            self.editable_setting = temp_model.from_map(m['editableSetting'])
        if m.get('otherUserPermission') is not None:
            self.other_user_permission = m.get('otherUserPermission')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class CreateRangeProtectionResponseBody(TeaModel):
    def __init__(
        self,
        id: str = None,
    ):
        self.id = id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        return self


class CreateRangeProtectionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateRangeProtectionResponseBody = None,
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
            temp_model = CreateRangeProtectionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateSheetHeaders(TeaModel):
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


class CreateSheetRequest(TeaModel):
    def __init__(
        self,
        name: str = None,
        operator_id: str = None,
    ):
        self.name = name
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class CreateSheetResponseBody(TeaModel):
    def __init__(
        self,
        id: str = None,
        name: str = None,
        visibility: str = None,
    ):
        self.id = id
        self.name = name
        self.visibility = visibility

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.visibility is not None:
            result['visibility'] = self.visibility
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('visibility') is not None:
            self.visibility = m.get('visibility')
        return self


class CreateSheetResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateSheetResponseBody = None,
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
            temp_model = CreateSheetResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateWorkspaceHeaders(TeaModel):
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


class CreateWorkspaceRequest(TeaModel):
    def __init__(
        self,
        description: str = None,
        name: str = None,
        operator_id: str = None,
    ):
        self.description = description
        self.name = name
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
        if self.name is not None:
            result['name'] = self.name
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class CreateWorkspaceResponseBody(TeaModel):
    def __init__(
        self,
        description: str = None,
        name: str = None,
        url: str = None,
        workspace_id: str = None,
    ):
        self.description = description
        self.name = name
        self.url = url
        self.workspace_id = workspace_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.description is not None:
            result['description'] = self.description
        if self.name is not None:
            result['name'] = self.name
        if self.url is not None:
            result['url'] = self.url
        if self.workspace_id is not None:
            result['workspaceId'] = self.workspace_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('url') is not None:
            self.url = m.get('url')
        if m.get('workspaceId') is not None:
            self.workspace_id = m.get('workspaceId')
        return self


class CreateWorkspaceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateWorkspaceResponseBody = None,
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
            temp_model = CreateWorkspaceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateWorkspaceDocHeaders(TeaModel):
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


class CreateWorkspaceDocRequest(TeaModel):
    def __init__(
        self,
        doc_type: str = None,
        name: str = None,
        operator_id: str = None,
        parent_node_id: str = None,
        template_id: str = None,
        template_type: str = None,
    ):
        self.doc_type = doc_type
        self.name = name
        self.operator_id = operator_id
        self.parent_node_id = parent_node_id
        self.template_id = template_id
        self.template_type = template_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.doc_type is not None:
            result['docType'] = self.doc_type
        if self.name is not None:
            result['name'] = self.name
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.parent_node_id is not None:
            result['parentNodeId'] = self.parent_node_id
        if self.template_id is not None:
            result['templateId'] = self.template_id
        if self.template_type is not None:
            result['templateType'] = self.template_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('docType') is not None:
            self.doc_type = m.get('docType')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('parentNodeId') is not None:
            self.parent_node_id = m.get('parentNodeId')
        if m.get('templateId') is not None:
            self.template_id = m.get('templateId')
        if m.get('templateType') is not None:
            self.template_type = m.get('templateType')
        return self


class CreateWorkspaceDocResponseBody(TeaModel):
    def __init__(
        self,
        doc_key: str = None,
        node_id: str = None,
        url: str = None,
        workspace_id: str = None,
    ):
        self.doc_key = doc_key
        self.node_id = node_id
        self.url = url
        self.workspace_id = workspace_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.doc_key is not None:
            result['docKey'] = self.doc_key
        if self.node_id is not None:
            result['nodeId'] = self.node_id
        if self.url is not None:
            result['url'] = self.url
        if self.workspace_id is not None:
            result['workspaceId'] = self.workspace_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('docKey') is not None:
            self.doc_key = m.get('docKey')
        if m.get('nodeId') is not None:
            self.node_id = m.get('nodeId')
        if m.get('url') is not None:
            self.url = m.get('url')
        if m.get('workspaceId') is not None:
            self.workspace_id = m.get('workspaceId')
        return self


class CreateWorkspaceDocResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateWorkspaceDocResponseBody = None,
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
            temp_model = CreateWorkspaceDocResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteColumnsHeaders(TeaModel):
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


class DeleteColumnsRequest(TeaModel):
    def __init__(
        self,
        column: int = None,
        column_count: int = None,
        operator_id: str = None,
    ):
        self.column = column
        self.column_count = column_count
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.column is not None:
            result['column'] = self.column
        if self.column_count is not None:
            result['columnCount'] = self.column_count
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('column') is not None:
            self.column = m.get('column')
        if m.get('columnCount') is not None:
            self.column_count = m.get('columnCount')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class DeleteColumnsResponseBody(TeaModel):
    def __init__(
        self,
        id: str = None,
    ):
        self.id = id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        return self


class DeleteColumnsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteColumnsResponseBody = None,
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
            temp_model = DeleteColumnsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteDropdownListsHeaders(TeaModel):
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


class DeleteDropdownListsRequest(TeaModel):
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


class DeleteDropdownListsResponseBody(TeaModel):
    def __init__(
        self,
        a_1notation: str = None,
    ):
        self.a_1notation = a_1notation

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.a_1notation is not None:
            result['a1Notation'] = self.a_1notation
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('a1Notation') is not None:
            self.a_1notation = m.get('a1Notation')
        return self


class DeleteDropdownListsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteDropdownListsResponseBody = None,
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
            temp_model = DeleteDropdownListsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteRangeProtectionHeaders(TeaModel):
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


class DeleteRangeProtectionRequest(TeaModel):
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


class DeleteRangeProtectionResponseBody(TeaModel):
    def __init__(
        self,
        a_1notation: str = None,
    ):
        self.a_1notation = a_1notation

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.a_1notation is not None:
            result['a1Notation'] = self.a_1notation
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('a1Notation') is not None:
            self.a_1notation = m.get('a1Notation')
        return self


class DeleteRangeProtectionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteRangeProtectionResponseBody = None,
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
            temp_model = DeleteRangeProtectionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteRowsHeaders(TeaModel):
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


class DeleteRowsRequest(TeaModel):
    def __init__(
        self,
        row: int = None,
        row_count: int = None,
        operator_id: str = None,
    ):
        self.row = row
        self.row_count = row_count
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.row is not None:
            result['row'] = self.row
        if self.row_count is not None:
            result['rowCount'] = self.row_count
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('row') is not None:
            self.row = m.get('row')
        if m.get('rowCount') is not None:
            self.row_count = m.get('rowCount')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class DeleteRowsResponseBody(TeaModel):
    def __init__(
        self,
        id: str = None,
    ):
        self.id = id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        return self


class DeleteRowsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteRowsResponseBody = None,
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
            temp_model = DeleteRowsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteSheetHeaders(TeaModel):
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


class DeleteSheetRequest(TeaModel):
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


class DeleteSheetResponseBody(TeaModel):
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


class DeleteSheetResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteSheetResponseBody = None,
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
            temp_model = DeleteSheetResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteWorkspaceDocHeaders(TeaModel):
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


class DeleteWorkspaceDocRequest(TeaModel):
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


class DeleteWorkspaceDocResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
    ):
        self.headers = headers
        self.status_code = status_code

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        return self


class DeleteWorkspaceDocMembersHeaders(TeaModel):
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


class DeleteWorkspaceDocMembersRequestMembers(TeaModel):
    def __init__(
        self,
        member_id: str = None,
        member_type: str = None,
    ):
        self.member_id = member_id
        self.member_type = member_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.member_id is not None:
            result['memberId'] = self.member_id
        if self.member_type is not None:
            result['memberType'] = self.member_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('memberId') is not None:
            self.member_id = m.get('memberId')
        if m.get('memberType') is not None:
            self.member_type = m.get('memberType')
        return self


class DeleteWorkspaceDocMembersRequest(TeaModel):
    def __init__(
        self,
        members: List[DeleteWorkspaceDocMembersRequestMembers] = None,
        operator_id: str = None,
    ):
        self.members = members
        self.operator_id = operator_id

    def validate(self):
        if self.members:
            for k in self.members:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['members'] = []
        if self.members is not None:
            for k in self.members:
                result['members'].append(k.to_map() if k else None)
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.members = []
        if m.get('members') is not None:
            for k in m.get('members'):
                temp_model = DeleteWorkspaceDocMembersRequestMembers()
                self.members.append(temp_model.from_map(k))
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class DeleteWorkspaceDocMembersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
    ):
        self.headers = headers
        self.status_code = status_code

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        return self


class DeleteWorkspaceMembersHeaders(TeaModel):
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


class DeleteWorkspaceMembersRequestMembers(TeaModel):
    def __init__(
        self,
        member_id: str = None,
        member_type: str = None,
    ):
        self.member_id = member_id
        self.member_type = member_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.member_id is not None:
            result['memberId'] = self.member_id
        if self.member_type is not None:
            result['memberType'] = self.member_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('memberId') is not None:
            self.member_id = m.get('memberId')
        if m.get('memberType') is not None:
            self.member_type = m.get('memberType')
        return self


class DeleteWorkspaceMembersRequest(TeaModel):
    def __init__(
        self,
        members: List[DeleteWorkspaceMembersRequestMembers] = None,
        operator_id: str = None,
    ):
        self.members = members
        self.operator_id = operator_id

    def validate(self):
        if self.members:
            for k in self.members:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['members'] = []
        if self.members is not None:
            for k in self.members:
                result['members'].append(k.to_map() if k else None)
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.members = []
        if m.get('members') is not None:
            for k in m.get('members'):
                temp_model = DeleteWorkspaceMembersRequestMembers()
                self.members.append(temp_model.from_map(k))
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class DeleteWorkspaceMembersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
    ):
        self.headers = headers
        self.status_code = status_code

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        return self


class DocAppendParagraphHeaders(TeaModel):
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


class DocAppendParagraphRequest(TeaModel):
    def __init__(
        self,
        element_type: str = None,
        properties: Dict[str, Any] = None,
        operator_id: str = None,
    ):
        self.element_type = element_type
        self.properties = properties
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.element_type is not None:
            result['elementType'] = self.element_type
        if self.properties is not None:
            result['properties'] = self.properties
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('elementType') is not None:
            self.element_type = m.get('elementType')
        if m.get('properties') is not None:
            self.properties = m.get('properties')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class DocAppendParagraphResponseBodyResult(TeaModel):
    def __init__(
        self,
        data: Dict[str, Any] = None,
    ):
        self.data = data

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            self.data = m.get('data')
        return self


class DocAppendParagraphResponseBody(TeaModel):
    def __init__(
        self,
        result: DocAppendParagraphResponseBodyResult = None,
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
            temp_model = DocAppendParagraphResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class DocAppendParagraphResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DocAppendParagraphResponseBody = None,
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
            temp_model = DocAppendParagraphResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DocAppendTextHeaders(TeaModel):
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


class DocAppendTextRequest(TeaModel):
    def __init__(
        self,
        text: str = None,
        operator_id: str = None,
    ):
        self.text = text
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.text is not None:
            result['text'] = self.text
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('text') is not None:
            self.text = m.get('text')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class DocAppendTextResponseBodyResult(TeaModel):
    def __init__(
        self,
        data: Dict[str, Any] = None,
    ):
        self.data = data

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            self.data = m.get('data')
        return self


class DocAppendTextResponseBody(TeaModel):
    def __init__(
        self,
        result: DocAppendTextResponseBodyResult = None,
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
            temp_model = DocAppendTextResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class DocAppendTextResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DocAppendTextResponseBody = None,
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
            temp_model = DocAppendTextResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DocBlocksQueryHeaders(TeaModel):
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


class DocBlocksQueryRequest(TeaModel):
    def __init__(
        self,
        block_type: str = None,
        end_index: int = None,
        operator_id: str = None,
        start_index: int = None,
    ):
        self.block_type = block_type
        self.end_index = end_index
        self.operator_id = operator_id
        self.start_index = start_index

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.block_type is not None:
            result['blockType'] = self.block_type
        if self.end_index is not None:
            result['endIndex'] = self.end_index
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.start_index is not None:
            result['startIndex'] = self.start_index
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('blockType') is not None:
            self.block_type = m.get('blockType')
        if m.get('endIndex') is not None:
            self.end_index = m.get('endIndex')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('startIndex') is not None:
            self.start_index = m.get('startIndex')
        return self


class DocBlocksQueryResponseBodyResult(TeaModel):
    def __init__(
        self,
        data: List[Any] = None,
    ):
        self.data = data

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            self.data = m.get('data')
        return self


class DocBlocksQueryResponseBody(TeaModel):
    def __init__(
        self,
        result: DocBlocksQueryResponseBodyResult = None,
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
            temp_model = DocBlocksQueryResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class DocBlocksQueryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DocBlocksQueryResponseBody = None,
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
            temp_model = DocBlocksQueryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DocDeleteBlockHeaders(TeaModel):
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


class DocDeleteBlockRequest(TeaModel):
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


class DocDeleteBlockResponseBodyResult(TeaModel):
    def __init__(
        self,
        data: Dict[str, Any] = None,
    ):
        self.data = data

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            self.data = m.get('data')
        return self


class DocDeleteBlockResponseBody(TeaModel):
    def __init__(
        self,
        result: DocDeleteBlockResponseBodyResult = None,
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
            temp_model = DocDeleteBlockResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class DocDeleteBlockResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DocDeleteBlockResponseBody = None,
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
            temp_model = DocDeleteBlockResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DocInsertBlocksHeaders(TeaModel):
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


class DocInsertBlocksRequest(TeaModel):
    def __init__(
        self,
        block_id: str = None,
        element: Dict[str, Any] = None,
        index: int = None,
        where: str = None,
        operator_id: str = None,
    ):
        self.block_id = block_id
        self.element = element
        self.index = index
        self.where = where
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.block_id is not None:
            result['blockId'] = self.block_id
        if self.element is not None:
            result['element'] = self.element
        if self.index is not None:
            result['index'] = self.index
        if self.where is not None:
            result['where'] = self.where
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('blockId') is not None:
            self.block_id = m.get('blockId')
        if m.get('element') is not None:
            self.element = m.get('element')
        if m.get('index') is not None:
            self.index = m.get('index')
        if m.get('where') is not None:
            self.where = m.get('where')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class DocInsertBlocksResponseBodyResult(TeaModel):
    def __init__(
        self,
        data: Dict[str, Any] = None,
    ):
        self.data = data

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            self.data = m.get('data')
        return self


class DocInsertBlocksResponseBody(TeaModel):
    def __init__(
        self,
        result: DocInsertBlocksResponseBodyResult = None,
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
            temp_model = DocInsertBlocksResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class DocInsertBlocksResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DocInsertBlocksResponseBody = None,
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
            temp_model = DocInsertBlocksResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DocUpdateContentHeaders(TeaModel):
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


class DocUpdateContentRequest(TeaModel):
    def __init__(
        self,
        content: str = None,
        data_type: str = None,
        operator_id: str = None,
    ):
        self.content = content
        self.data_type = data_type
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.data_type is not None:
            result['dataType'] = self.data_type
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('dataType') is not None:
            self.data_type = m.get('dataType')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class DocUpdateContentResponseBodyResult(TeaModel):
    def __init__(
        self,
        data: Dict[str, Any] = None,
    ):
        self.data = data

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            self.data = m.get('data')
        return self


class DocUpdateContentResponseBody(TeaModel):
    def __init__(
        self,
        result: DocUpdateContentResponseBodyResult = None,
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
            temp_model = DocUpdateContentResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class DocUpdateContentResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DocUpdateContentResponseBody = None,
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
            temp_model = DocUpdateContentResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetAllSheetsHeaders(TeaModel):
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


class GetAllSheetsRequest(TeaModel):
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


class GetAllSheetsResponseBodyValue(TeaModel):
    def __init__(
        self,
        id: str = None,
        name: str = None,
    ):
        self.id = id
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class GetAllSheetsResponseBody(TeaModel):
    def __init__(
        self,
        value: List[GetAllSheetsResponseBodyValue] = None,
    ):
        self.value = value

    def validate(self):
        if self.value:
            for k in self.value:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['value'] = []
        if self.value is not None:
            for k in self.value:
                result['value'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.value = []
        if m.get('value') is not None:
            for k in m.get('value'):
                temp_model = GetAllSheetsResponseBodyValue()
                self.value.append(temp_model.from_map(k))
        return self


class GetAllSheetsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetAllSheetsResponseBody = None,
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
            temp_model = GetAllSheetsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetDeveloperMetadataHeaders(TeaModel):
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


class GetDeveloperMetadataRequest(TeaModel):
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


class GetDeveloperMetadataResponseBodyAssociatedColumn(TeaModel):
    def __init__(
        self,
        column: int = None,
        sheet_id: str = None,
    ):
        self.column = column
        self.sheet_id = sheet_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.column is not None:
            result['column'] = self.column
        if self.sheet_id is not None:
            result['sheetId'] = self.sheet_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('column') is not None:
            self.column = m.get('column')
        if m.get('sheetId') is not None:
            self.sheet_id = m.get('sheetId')
        return self


class GetDeveloperMetadataResponseBodyAssociatedRow(TeaModel):
    def __init__(
        self,
        row: int = None,
        sheet_id: str = None,
    ):
        self.row = row
        self.sheet_id = sheet_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.row is not None:
            result['row'] = self.row
        if self.sheet_id is not None:
            result['sheetId'] = self.sheet_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('row') is not None:
            self.row = m.get('row')
        if m.get('sheetId') is not None:
            self.sheet_id = m.get('sheetId')
        return self


class GetDeveloperMetadataResponseBody(TeaModel):
    def __init__(
        self,
        associated_column: GetDeveloperMetadataResponseBodyAssociatedColumn = None,
        associated_row: GetDeveloperMetadataResponseBodyAssociatedRow = None,
        value: Any = None,
    ):
        self.associated_column = associated_column
        self.associated_row = associated_row
        self.value = value

    def validate(self):
        if self.associated_column:
            self.associated_column.validate()
        if self.associated_row:
            self.associated_row.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.associated_column is not None:
            result['associatedColumn'] = self.associated_column.to_map()
        if self.associated_row is not None:
            result['associatedRow'] = self.associated_row.to_map()
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('associatedColumn') is not None:
            temp_model = GetDeveloperMetadataResponseBodyAssociatedColumn()
            self.associated_column = temp_model.from_map(m['associatedColumn'])
        if m.get('associatedRow') is not None:
            temp_model = GetDeveloperMetadataResponseBodyAssociatedRow()
            self.associated_row = temp_model.from_map(m['associatedRow'])
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class GetDeveloperMetadataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetDeveloperMetadataResponseBody = None,
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
            temp_model = GetDeveloperMetadataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetRangeHeaders(TeaModel):
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


class GetRangeRequest(TeaModel):
    def __init__(
        self,
        operator_id: str = None,
        select: str = None,
    ):
        self.operator_id = operator_id
        self.select = select

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.select is not None:
            result['select'] = self.select
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('select') is not None:
            self.select = m.get('select')
        return self


class GetRangeResponseBodyBackgroundColors(TeaModel):
    def __init__(
        self,
        red: int = None,
        green: int = None,
        blue: int = None,
        hex_string: str = None,
    ):
        self.red = red
        self.green = green
        self.blue = blue
        self.hex_string = hex_string

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.red is not None:
            result['red'] = self.red
        if self.green is not None:
            result['green'] = self.green
        if self.blue is not None:
            result['blue'] = self.blue
        if self.hex_string is not None:
            result['hexString'] = self.hex_string
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('red') is not None:
            self.red = m.get('red')
        if m.get('green') is not None:
            self.green = m.get('green')
        if m.get('blue') is not None:
            self.blue = m.get('blue')
        if m.get('hexString') is not None:
            self.hex_string = m.get('hexString')
        return self


class GetRangeResponseBody(TeaModel):
    def __init__(
        self,
        background_colors: List[List[GetRangeResponseBodyBackgroundColors]] = None,
        display_values: List[List[str]] = None,
        font_sizes: List[List[int]] = None,
        font_weights: List[List[str]] = None,
        formulas: List[List[str]] = None,
        horizontal_alignments: List[List[str]] = None,
        values: List[List[Any]] = None,
        vertical_alignments: List[List[str]] = None,
    ):
        self.background_colors = background_colors
        self.display_values = display_values
        self.font_sizes = font_sizes
        self.font_weights = font_weights
        self.formulas = formulas
        self.horizontal_alignments = horizontal_alignments
        self.values = values
        self.vertical_alignments = vertical_alignments

    def validate(self):
        if self.background_colors:
            for k in self.background_colors:
                for k1 in k:
                    if k1:
                        k1.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['backgroundColors'] = []
        if self.background_colors is not None:
            for k in self.background_colors:
                l1 = []
                for k1 in k:
                    l1.append(k1.to_map() if k1 else None)
                result['backgroundColors'].append(l1)
        if self.display_values is not None:
            result['displayValues'] = self.display_values
        if self.font_sizes is not None:
            result['fontSizes'] = self.font_sizes
        if self.font_weights is not None:
            result['fontWeights'] = self.font_weights
        if self.formulas is not None:
            result['formulas'] = self.formulas
        if self.horizontal_alignments is not None:
            result['horizontalAlignments'] = self.horizontal_alignments
        if self.values is not None:
            result['values'] = self.values
        if self.vertical_alignments is not None:
            result['verticalAlignments'] = self.vertical_alignments
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.background_colors = []
        if m.get('backgroundColors') is not None:
            for k in m.get('backgroundColors'):
                l1 = []
                for k1 in k:
                    temp_model = GetRangeResponseBodyBackgroundColors()
                    l1.append(temp_model.from_map(k1))
                self.background_colors.append(l1)
        if m.get('displayValues') is not None:
            self.display_values = m.get('displayValues')
        if m.get('fontSizes') is not None:
            self.font_sizes = m.get('fontSizes')
        if m.get('fontWeights') is not None:
            self.font_weights = m.get('fontWeights')
        if m.get('formulas') is not None:
            self.formulas = m.get('formulas')
        if m.get('horizontalAlignments') is not None:
            self.horizontal_alignments = m.get('horizontalAlignments')
        if m.get('values') is not None:
            self.values = m.get('values')
        if m.get('verticalAlignments') is not None:
            self.vertical_alignments = m.get('verticalAlignments')
        return self


class GetRangeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetRangeResponseBody = None,
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
            temp_model = GetRangeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetRecentEditDocsHeaders(TeaModel):
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


class GetRecentEditDocsRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        operator_id: str = None,
    ):
        self.max_results = max_results
        self.next_token = next_token
        self.operator_id = operator_id

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
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class GetRecentEditDocsResponseBodyRecentListNodeBO(TeaModel):
    def __init__(
        self,
        create_time: int = None,
        doc_type: str = None,
        is_deleted: bool = None,
        last_edit_time: int = None,
        node_id: str = None,
        node_name: str = None,
        update_time: int = None,
        url: str = None,
    ):
        self.create_time = create_time
        self.doc_type = doc_type
        self.is_deleted = is_deleted
        self.last_edit_time = last_edit_time
        self.node_id = node_id
        self.node_name = node_name
        self.update_time = update_time
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.doc_type is not None:
            result['docType'] = self.doc_type
        if self.is_deleted is not None:
            result['isDeleted'] = self.is_deleted
        if self.last_edit_time is not None:
            result['lastEditTime'] = self.last_edit_time
        if self.node_id is not None:
            result['nodeId'] = self.node_id
        if self.node_name is not None:
            result['nodeName'] = self.node_name
        if self.update_time is not None:
            result['updateTime'] = self.update_time
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('docType') is not None:
            self.doc_type = m.get('docType')
        if m.get('isDeleted') is not None:
            self.is_deleted = m.get('isDeleted')
        if m.get('lastEditTime') is not None:
            self.last_edit_time = m.get('lastEditTime')
        if m.get('nodeId') is not None:
            self.node_id = m.get('nodeId')
        if m.get('nodeName') is not None:
            self.node_name = m.get('nodeName')
        if m.get('updateTime') is not None:
            self.update_time = m.get('updateTime')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class GetRecentEditDocsResponseBodyRecentListWorkspaceBO(TeaModel):
    def __init__(
        self,
        url: str = None,
        workspace_id: str = None,
        workspace_name: str = None,
    ):
        self.url = url
        self.workspace_id = workspace_id
        self.workspace_name = workspace_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.url is not None:
            result['url'] = self.url
        if self.workspace_id is not None:
            result['workspaceId'] = self.workspace_id
        if self.workspace_name is not None:
            result['workspaceName'] = self.workspace_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('url') is not None:
            self.url = m.get('url')
        if m.get('workspaceId') is not None:
            self.workspace_id = m.get('workspaceId')
        if m.get('workspaceName') is not None:
            self.workspace_name = m.get('workspaceName')
        return self


class GetRecentEditDocsResponseBodyRecentList(TeaModel):
    def __init__(
        self,
        node_bo: GetRecentEditDocsResponseBodyRecentListNodeBO = None,
        workspace_bo: GetRecentEditDocsResponseBodyRecentListWorkspaceBO = None,
    ):
        self.node_bo = node_bo
        self.workspace_bo = workspace_bo

    def validate(self):
        if self.node_bo:
            self.node_bo.validate()
        if self.workspace_bo:
            self.workspace_bo.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.node_bo is not None:
            result['nodeBO'] = self.node_bo.to_map()
        if self.workspace_bo is not None:
            result['workspaceBO'] = self.workspace_bo.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nodeBO') is not None:
            temp_model = GetRecentEditDocsResponseBodyRecentListNodeBO()
            self.node_bo = temp_model.from_map(m['nodeBO'])
        if m.get('workspaceBO') is not None:
            temp_model = GetRecentEditDocsResponseBodyRecentListWorkspaceBO()
            self.workspace_bo = temp_model.from_map(m['workspaceBO'])
        return self


class GetRecentEditDocsResponseBody(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        recent_list: List[GetRecentEditDocsResponseBodyRecentList] = None,
    ):
        self.next_token = next_token
        self.recent_list = recent_list

    def validate(self):
        if self.recent_list:
            for k in self.recent_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['recentList'] = []
        if self.recent_list is not None:
            for k in self.recent_list:
                result['recentList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.recent_list = []
        if m.get('recentList') is not None:
            for k in m.get('recentList'):
                temp_model = GetRecentEditDocsResponseBodyRecentList()
                self.recent_list.append(temp_model.from_map(k))
        return self


class GetRecentEditDocsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetRecentEditDocsResponseBody = None,
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
            temp_model = GetRecentEditDocsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetRecentOpenDocsHeaders(TeaModel):
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


class GetRecentOpenDocsRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        operator_id: str = None,
    ):
        self.max_results = max_results
        self.next_token = next_token
        self.operator_id = operator_id

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
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class GetRecentOpenDocsResponseBodyRecentListNodeBO(TeaModel):
    def __init__(
        self,
        create_time: int = None,
        doc_type: str = None,
        is_deleted: bool = None,
        last_open_time: int = None,
        node_id: str = None,
        node_name: str = None,
        update_time: int = None,
        url: str = None,
    ):
        self.create_time = create_time
        self.doc_type = doc_type
        self.is_deleted = is_deleted
        self.last_open_time = last_open_time
        self.node_id = node_id
        self.node_name = node_name
        self.update_time = update_time
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.doc_type is not None:
            result['docType'] = self.doc_type
        if self.is_deleted is not None:
            result['isDeleted'] = self.is_deleted
        if self.last_open_time is not None:
            result['lastOpenTime'] = self.last_open_time
        if self.node_id is not None:
            result['nodeId'] = self.node_id
        if self.node_name is not None:
            result['nodeName'] = self.node_name
        if self.update_time is not None:
            result['updateTime'] = self.update_time
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('docType') is not None:
            self.doc_type = m.get('docType')
        if m.get('isDeleted') is not None:
            self.is_deleted = m.get('isDeleted')
        if m.get('lastOpenTime') is not None:
            self.last_open_time = m.get('lastOpenTime')
        if m.get('nodeId') is not None:
            self.node_id = m.get('nodeId')
        if m.get('nodeName') is not None:
            self.node_name = m.get('nodeName')
        if m.get('updateTime') is not None:
            self.update_time = m.get('updateTime')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class GetRecentOpenDocsResponseBodyRecentListWorkspaceBO(TeaModel):
    def __init__(
        self,
        url: str = None,
        workspace_id: str = None,
        workspace_name: str = None,
    ):
        self.url = url
        self.workspace_id = workspace_id
        self.workspace_name = workspace_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.url is not None:
            result['url'] = self.url
        if self.workspace_id is not None:
            result['workspaceId'] = self.workspace_id
        if self.workspace_name is not None:
            result['workspaceName'] = self.workspace_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('url') is not None:
            self.url = m.get('url')
        if m.get('workspaceId') is not None:
            self.workspace_id = m.get('workspaceId')
        if m.get('workspaceName') is not None:
            self.workspace_name = m.get('workspaceName')
        return self


class GetRecentOpenDocsResponseBodyRecentList(TeaModel):
    def __init__(
        self,
        node_bo: GetRecentOpenDocsResponseBodyRecentListNodeBO = None,
        workspace_bo: GetRecentOpenDocsResponseBodyRecentListWorkspaceBO = None,
    ):
        self.node_bo = node_bo
        self.workspace_bo = workspace_bo

    def validate(self):
        if self.node_bo:
            self.node_bo.validate()
        if self.workspace_bo:
            self.workspace_bo.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.node_bo is not None:
            result['nodeBO'] = self.node_bo.to_map()
        if self.workspace_bo is not None:
            result['workspaceBO'] = self.workspace_bo.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nodeBO') is not None:
            temp_model = GetRecentOpenDocsResponseBodyRecentListNodeBO()
            self.node_bo = temp_model.from_map(m['nodeBO'])
        if m.get('workspaceBO') is not None:
            temp_model = GetRecentOpenDocsResponseBodyRecentListWorkspaceBO()
            self.workspace_bo = temp_model.from_map(m['workspaceBO'])
        return self


class GetRecentOpenDocsResponseBody(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        recent_list: List[GetRecentOpenDocsResponseBodyRecentList] = None,
    ):
        self.next_token = next_token
        self.recent_list = recent_list

    def validate(self):
        if self.recent_list:
            for k in self.recent_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['recentList'] = []
        if self.recent_list is not None:
            for k in self.recent_list:
                result['recentList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.recent_list = []
        if m.get('recentList') is not None:
            for k in m.get('recentList'):
                temp_model = GetRecentOpenDocsResponseBodyRecentList()
                self.recent_list.append(temp_model.from_map(k))
        return self


class GetRecentOpenDocsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetRecentOpenDocsResponseBody = None,
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
            temp_model = GetRecentOpenDocsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetRelatedWorkspacesHeaders(TeaModel):
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


class GetRelatedWorkspacesRequest(TeaModel):
    def __init__(
        self,
        include_recent: bool = None,
        operator_id: str = None,
    ):
        self.include_recent = include_recent
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.include_recent is not None:
            result['includeRecent'] = self.include_recent
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('includeRecent') is not None:
            self.include_recent = m.get('includeRecent')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class GetRelatedWorkspacesResponseBodyWorkspacesRecentList(TeaModel):
    def __init__(
        self,
        last_edit_time: int = None,
        name: str = None,
        node_id: str = None,
        url: str = None,
    ):
        self.last_edit_time = last_edit_time
        self.name = name
        self.node_id = node_id
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.last_edit_time is not None:
            result['lastEditTime'] = self.last_edit_time
        if self.name is not None:
            result['name'] = self.name
        if self.node_id is not None:
            result['nodeId'] = self.node_id
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('lastEditTime') is not None:
            self.last_edit_time = m.get('lastEditTime')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('nodeId') is not None:
            self.node_id = m.get('nodeId')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class GetRelatedWorkspacesResponseBodyWorkspaces(TeaModel):
    def __init__(
        self,
        create_time: int = None,
        deleted: bool = None,
        name: str = None,
        owner: str = None,
        recent_list: List[GetRelatedWorkspacesResponseBodyWorkspacesRecentList] = None,
        role: str = None,
        url: str = None,
        workspace_id: str = None,
    ):
        self.create_time = create_time
        self.deleted = deleted
        self.name = name
        self.owner = owner
        self.recent_list = recent_list
        self.role = role
        self.url = url
        self.workspace_id = workspace_id

    def validate(self):
        if self.recent_list:
            for k in self.recent_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.deleted is not None:
            result['deleted'] = self.deleted
        if self.name is not None:
            result['name'] = self.name
        if self.owner is not None:
            result['owner'] = self.owner
        result['recentList'] = []
        if self.recent_list is not None:
            for k in self.recent_list:
                result['recentList'].append(k.to_map() if k else None)
        if self.role is not None:
            result['role'] = self.role
        if self.url is not None:
            result['url'] = self.url
        if self.workspace_id is not None:
            result['workspaceId'] = self.workspace_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('deleted') is not None:
            self.deleted = m.get('deleted')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('owner') is not None:
            self.owner = m.get('owner')
        self.recent_list = []
        if m.get('recentList') is not None:
            for k in m.get('recentList'):
                temp_model = GetRelatedWorkspacesResponseBodyWorkspacesRecentList()
                self.recent_list.append(temp_model.from_map(k))
        if m.get('role') is not None:
            self.role = m.get('role')
        if m.get('url') is not None:
            self.url = m.get('url')
        if m.get('workspaceId') is not None:
            self.workspace_id = m.get('workspaceId')
        return self


class GetRelatedWorkspacesResponseBody(TeaModel):
    def __init__(
        self,
        workspaces: List[GetRelatedWorkspacesResponseBodyWorkspaces] = None,
    ):
        self.workspaces = workspaces

    def validate(self):
        if self.workspaces:
            for k in self.workspaces:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['workspaces'] = []
        if self.workspaces is not None:
            for k in self.workspaces:
                result['workspaces'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.workspaces = []
        if m.get('workspaces') is not None:
            for k in m.get('workspaces'):
                temp_model = GetRelatedWorkspacesResponseBodyWorkspaces()
                self.workspaces.append(temp_model.from_map(k))
        return self


class GetRelatedWorkspacesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetRelatedWorkspacesResponseBody = None,
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
            temp_model = GetRelatedWorkspacesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetSheetHeaders(TeaModel):
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


class GetSheetRequest(TeaModel):
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


class GetSheetResponseBody(TeaModel):
    def __init__(
        self,
        column_count: int = None,
        id: str = None,
        last_non_empty_column: int = None,
        last_non_empty_row: int = None,
        name: str = None,
        row_count: int = None,
        visibility: str = None,
    ):
        self.column_count = column_count
        self.id = id
        self.last_non_empty_column = last_non_empty_column
        self.last_non_empty_row = last_non_empty_row
        self.name = name
        self.row_count = row_count
        self.visibility = visibility

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.column_count is not None:
            result['columnCount'] = self.column_count
        if self.id is not None:
            result['id'] = self.id
        if self.last_non_empty_column is not None:
            result['lastNonEmptyColumn'] = self.last_non_empty_column
        if self.last_non_empty_row is not None:
            result['lastNonEmptyRow'] = self.last_non_empty_row
        if self.name is not None:
            result['name'] = self.name
        if self.row_count is not None:
            result['rowCount'] = self.row_count
        if self.visibility is not None:
            result['visibility'] = self.visibility
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('columnCount') is not None:
            self.column_count = m.get('columnCount')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('lastNonEmptyColumn') is not None:
            self.last_non_empty_column = m.get('lastNonEmptyColumn')
        if m.get('lastNonEmptyRow') is not None:
            self.last_non_empty_row = m.get('lastNonEmptyRow')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('rowCount') is not None:
            self.row_count = m.get('rowCount')
        if m.get('visibility') is not None:
            self.visibility = m.get('visibility')
        return self


class GetSheetResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetSheetResponseBody = None,
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
            temp_model = GetSheetResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetTemplateByIdHeaders(TeaModel):
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


class GetTemplateByIdRequest(TeaModel):
    def __init__(
        self,
        belong: str = None,
        operator_id: str = None,
    ):
        self.belong = belong
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.belong is not None:
            result['belong'] = self.belong
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('belong') is not None:
            self.belong = m.get('belong')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class GetTemplateByIdResponseBody(TeaModel):
    def __init__(
        self,
        cover_url: str = None,
        create_time: int = None,
        doc_type: str = None,
        id: str = None,
        template_type: str = None,
        title: str = None,
        update_time: int = None,
        workspace_id: str = None,
    ):
        self.cover_url = cover_url
        self.create_time = create_time
        self.doc_type = doc_type
        self.id = id
        self.template_type = template_type
        self.title = title
        self.update_time = update_time
        self.workspace_id = workspace_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cover_url is not None:
            result['coverUrl'] = self.cover_url
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.doc_type is not None:
            result['docType'] = self.doc_type
        if self.id is not None:
            result['id'] = self.id
        if self.template_type is not None:
            result['templateType'] = self.template_type
        if self.title is not None:
            result['title'] = self.title
        if self.update_time is not None:
            result['updateTime'] = self.update_time
        if self.workspace_id is not None:
            result['workspaceId'] = self.workspace_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('coverUrl') is not None:
            self.cover_url = m.get('coverUrl')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('docType') is not None:
            self.doc_type = m.get('docType')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('templateType') is not None:
            self.template_type = m.get('templateType')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('updateTime') is not None:
            self.update_time = m.get('updateTime')
        if m.get('workspaceId') is not None:
            self.workspace_id = m.get('workspaceId')
        return self


class GetTemplateByIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetTemplateByIdResponseBody = None,
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
            temp_model = GetTemplateByIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetWorkspaceHeaders(TeaModel):
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


class GetWorkspaceResponseBody(TeaModel):
    def __init__(
        self,
        is_deleted: bool = None,
        owner: str = None,
        root_dentry_uuid: str = None,
        url: str = None,
    ):
        self.is_deleted = is_deleted
        self.owner = owner
        self.root_dentry_uuid = root_dentry_uuid
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.is_deleted is not None:
            result['isDeleted'] = self.is_deleted
        if self.owner is not None:
            result['owner'] = self.owner
        if self.root_dentry_uuid is not None:
            result['rootDentryUuid'] = self.root_dentry_uuid
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isDeleted') is not None:
            self.is_deleted = m.get('isDeleted')
        if m.get('owner') is not None:
            self.owner = m.get('owner')
        if m.get('rootDentryUuid') is not None:
            self.root_dentry_uuid = m.get('rootDentryUuid')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class GetWorkspaceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetWorkspaceResponseBody = None,
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
            temp_model = GetWorkspaceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetWorkspaceNodeHeaders(TeaModel):
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


class GetWorkspaceNodeRequest(TeaModel):
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


class GetWorkspaceNodeResponseBodyNodeBO(TeaModel):
    def __init__(
        self,
        doc_type: str = None,
        last_edit_time: int = None,
        name: str = None,
        node_id: str = None,
        url: str = None,
    ):
        self.doc_type = doc_type
        self.last_edit_time = last_edit_time
        self.name = name
        self.node_id = node_id
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.doc_type is not None:
            result['docType'] = self.doc_type
        if self.last_edit_time is not None:
            result['lastEditTime'] = self.last_edit_time
        if self.name is not None:
            result['name'] = self.name
        if self.node_id is not None:
            result['nodeId'] = self.node_id
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('docType') is not None:
            self.doc_type = m.get('docType')
        if m.get('lastEditTime') is not None:
            self.last_edit_time = m.get('lastEditTime')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('nodeId') is not None:
            self.node_id = m.get('nodeId')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class GetWorkspaceNodeResponseBodyWorkspaceBO(TeaModel):
    def __init__(
        self,
        name: str = None,
        workspace_id: str = None,
    ):
        self.name = name
        self.workspace_id = workspace_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.workspace_id is not None:
            result['workspaceId'] = self.workspace_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('workspaceId') is not None:
            self.workspace_id = m.get('workspaceId')
        return self


class GetWorkspaceNodeResponseBody(TeaModel):
    def __init__(
        self,
        has_permission: bool = None,
        node_bo: GetWorkspaceNodeResponseBodyNodeBO = None,
        workspace_bo: GetWorkspaceNodeResponseBodyWorkspaceBO = None,
    ):
        self.has_permission = has_permission
        self.node_bo = node_bo
        self.workspace_bo = workspace_bo

    def validate(self):
        if self.node_bo:
            self.node_bo.validate()
        if self.workspace_bo:
            self.workspace_bo.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_permission is not None:
            result['hasPermission'] = self.has_permission
        if self.node_bo is not None:
            result['nodeBO'] = self.node_bo.to_map()
        if self.workspace_bo is not None:
            result['workspaceBO'] = self.workspace_bo.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasPermission') is not None:
            self.has_permission = m.get('hasPermission')
        if m.get('nodeBO') is not None:
            temp_model = GetWorkspaceNodeResponseBodyNodeBO()
            self.node_bo = temp_model.from_map(m['nodeBO'])
        if m.get('workspaceBO') is not None:
            temp_model = GetWorkspaceNodeResponseBodyWorkspaceBO()
            self.workspace_bo = temp_model.from_map(m['workspaceBO'])
        return self


class GetWorkspaceNodeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetWorkspaceNodeResponseBody = None,
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
            temp_model = GetWorkspaceNodeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class InitDocumentHeaders(TeaModel):
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


class InitDocumentRequest(TeaModel):
    def __init__(
        self,
        attachments_map: Dict[str, AttachmentsMapValue] = None,
        import_type: int = None,
        links_key: str = None,
        operator_id: str = None,
    ):
        self.attachments_map = attachments_map
        self.import_type = import_type
        self.links_key = links_key
        self.operator_id = operator_id

    def validate(self):
        if self.attachments_map:
            for v in self.attachments_map.values():
                if v:
                    v.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['attachmentsMap'] = {}
        if self.attachments_map is not None:
            for k, v in self.attachments_map.items():
                result['attachmentsMap'][k] = v.to_map()
        if self.import_type is not None:
            result['importType'] = self.import_type
        if self.links_key is not None:
            result['linksKey'] = self.links_key
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attachments_map = {}
        if m.get('attachmentsMap') is not None:
            for k, v in m.get('attachmentsMap').items():
                temp_model = AttachmentsMapValue()
                self.attachments_map[k] = temp_model.from_map(v)
        if m.get('importType') is not None:
            self.import_type = m.get('importType')
        if m.get('linksKey') is not None:
            self.links_key = m.get('linksKey')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class InitDocumentResponseBody(TeaModel):
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


class InitDocumentResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: InitDocumentResponseBody = None,
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
            temp_model = InitDocumentResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class InsertBlocksHeaders(TeaModel):
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


class InsertBlocksRequestBlocksParagraphChildrenTextTextStyle(TeaModel):
    def __init__(
        self,
        bold: bool = None,
        data_type: str = None,
        font_size: int = None,
        size_unit: str = None,
    ):
        self.bold = bold
        self.data_type = data_type
        self.font_size = font_size
        self.size_unit = size_unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.bold is not None:
            result['bold'] = self.bold
        if self.data_type is not None:
            result['dataType'] = self.data_type
        if self.font_size is not None:
            result['fontSize'] = self.font_size
        if self.size_unit is not None:
            result['sizeUnit'] = self.size_unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bold') is not None:
            self.bold = m.get('bold')
        if m.get('dataType') is not None:
            self.data_type = m.get('dataType')
        if m.get('fontSize') is not None:
            self.font_size = m.get('fontSize')
        if m.get('sizeUnit') is not None:
            self.size_unit = m.get('sizeUnit')
        return self


class InsertBlocksRequestBlocksParagraphChildrenText(TeaModel):
    def __init__(
        self,
        content: str = None,
        text_style: InsertBlocksRequestBlocksParagraphChildrenTextTextStyle = None,
    ):
        self.content = content
        self.text_style = text_style

    def validate(self):
        if self.text_style:
            self.text_style.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.text_style is not None:
            result['textStyle'] = self.text_style.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('textStyle') is not None:
            temp_model = InsertBlocksRequestBlocksParagraphChildrenTextTextStyle()
            self.text_style = temp_model.from_map(m['textStyle'])
        return self


class InsertBlocksRequestBlocksParagraphChildren(TeaModel):
    def __init__(
        self,
        element_type: str = None,
        text: InsertBlocksRequestBlocksParagraphChildrenText = None,
    ):
        self.element_type = element_type
        self.text = text

    def validate(self):
        if self.text:
            self.text.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.element_type is not None:
            result['elementType'] = self.element_type
        if self.text is not None:
            result['text'] = self.text.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('elementType') is not None:
            self.element_type = m.get('elementType')
        if m.get('text') is not None:
            temp_model = InsertBlocksRequestBlocksParagraphChildrenText()
            self.text = temp_model.from_map(m['text'])
        return self


class InsertBlocksRequestBlocksParagraphStyle(TeaModel):
    def __init__(
        self,
        heading_level: str = None,
    ):
        self.heading_level = heading_level

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.heading_level is not None:
            result['headingLevel'] = self.heading_level
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headingLevel') is not None:
            self.heading_level = m.get('headingLevel')
        return self


class InsertBlocksRequestBlocksParagraph(TeaModel):
    def __init__(
        self,
        children: List[InsertBlocksRequestBlocksParagraphChildren] = None,
        style: InsertBlocksRequestBlocksParagraphStyle = None,
    ):
        self.children = children
        self.style = style

    def validate(self):
        if self.children:
            for k in self.children:
                if k:
                    k.validate()
        if self.style:
            self.style.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['children'] = []
        if self.children is not None:
            for k in self.children:
                result['children'].append(k.to_map() if k else None)
        if self.style is not None:
            result['style'] = self.style.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.children = []
        if m.get('children') is not None:
            for k in m.get('children'):
                temp_model = InsertBlocksRequestBlocksParagraphChildren()
                self.children.append(temp_model.from_map(k))
        if m.get('style') is not None:
            temp_model = InsertBlocksRequestBlocksParagraphStyle()
            self.style = temp_model.from_map(m['style'])
        return self


class InsertBlocksRequestBlocks(TeaModel):
    def __init__(
        self,
        block_type: str = None,
        paragraph: InsertBlocksRequestBlocksParagraph = None,
    ):
        self.block_type = block_type
        self.paragraph = paragraph

    def validate(self):
        if self.paragraph:
            self.paragraph.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.block_type is not None:
            result['blockType'] = self.block_type
        if self.paragraph is not None:
            result['paragraph'] = self.paragraph.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('blockType') is not None:
            self.block_type = m.get('blockType')
        if m.get('paragraph') is not None:
            temp_model = InsertBlocksRequestBlocksParagraph()
            self.paragraph = temp_model.from_map(m['paragraph'])
        return self


class InsertBlocksRequestLocation(TeaModel):
    def __init__(
        self,
        head: bool = None,
    ):
        self.head = head

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.head is not None:
            result['head'] = self.head
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('head') is not None:
            self.head = m.get('head')
        return self


class InsertBlocksRequest(TeaModel):
    def __init__(
        self,
        blocks: List[InsertBlocksRequestBlocks] = None,
        location: InsertBlocksRequestLocation = None,
        operator_id: str = None,
    ):
        self.blocks = blocks
        self.location = location
        self.operator_id = operator_id

    def validate(self):
        if self.blocks:
            for k in self.blocks:
                if k:
                    k.validate()
        if self.location:
            self.location.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['blocks'] = []
        if self.blocks is not None:
            for k in self.blocks:
                result['blocks'].append(k.to_map() if k else None)
        if self.location is not None:
            result['location'] = self.location.to_map()
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.blocks = []
        if m.get('blocks') is not None:
            for k in m.get('blocks'):
                temp_model = InsertBlocksRequestBlocks()
                self.blocks.append(temp_model.from_map(k))
        if m.get('location') is not None:
            temp_model = InsertBlocksRequestLocation()
            self.location = temp_model.from_map(m['location'])
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class InsertBlocksResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
    ):
        self.headers = headers
        self.status_code = status_code

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        return self


class InsertColumnsBeforeHeaders(TeaModel):
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


class InsertColumnsBeforeRequest(TeaModel):
    def __init__(
        self,
        column: int = None,
        column_count: int = None,
        operator_id: str = None,
    ):
        self.column = column
        self.column_count = column_count
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.column is not None:
            result['column'] = self.column
        if self.column_count is not None:
            result['columnCount'] = self.column_count
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('column') is not None:
            self.column = m.get('column')
        if m.get('columnCount') is not None:
            self.column_count = m.get('columnCount')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class InsertColumnsBeforeResponseBody(TeaModel):
    def __init__(
        self,
        id: str = None,
    ):
        self.id = id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        return self


class InsertColumnsBeforeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: InsertColumnsBeforeResponseBody = None,
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
            temp_model = InsertColumnsBeforeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class InsertDropdownListsHeaders(TeaModel):
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


class InsertDropdownListsRequestOptions(TeaModel):
    def __init__(
        self,
        color: str = None,
        value: str = None,
    ):
        self.color = color
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.color is not None:
            result['color'] = self.color
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('color') is not None:
            self.color = m.get('color')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class InsertDropdownListsRequest(TeaModel):
    def __init__(
        self,
        options: List[InsertDropdownListsRequestOptions] = None,
        operator_id: str = None,
    ):
        self.options = options
        self.operator_id = operator_id

    def validate(self):
        if self.options:
            for k in self.options:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['options'] = []
        if self.options is not None:
            for k in self.options:
                result['options'].append(k.to_map() if k else None)
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.options = []
        if m.get('options') is not None:
            for k in m.get('options'):
                temp_model = InsertDropdownListsRequestOptions()
                self.options.append(temp_model.from_map(k))
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class InsertDropdownListsResponseBody(TeaModel):
    def __init__(
        self,
        a_1notation: str = None,
    ):
        self.a_1notation = a_1notation

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.a_1notation is not None:
            result['a1Notation'] = self.a_1notation
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('a1Notation') is not None:
            self.a_1notation = m.get('a1Notation')
        return self


class InsertDropdownListsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: InsertDropdownListsResponseBody = None,
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
            temp_model = InsertDropdownListsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class InsertRowsBeforeHeaders(TeaModel):
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


class InsertRowsBeforeRequest(TeaModel):
    def __init__(
        self,
        row: int = None,
        row_count: int = None,
        operator_id: str = None,
    ):
        self.row = row
        self.row_count = row_count
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.row is not None:
            result['row'] = self.row
        if self.row_count is not None:
            result['rowCount'] = self.row_count
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('row') is not None:
            self.row = m.get('row')
        if m.get('rowCount') is not None:
            self.row_count = m.get('rowCount')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class InsertRowsBeforeResponseBody(TeaModel):
    def __init__(
        self,
        id: str = None,
    ):
        self.id = id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        return self


class InsertRowsBeforeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: InsertRowsBeforeResponseBody = None,
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
            temp_model = InsertRowsBeforeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListTemplateHeaders(TeaModel):
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


class ListTemplateRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        operator_id: str = None,
        template_type: str = None,
        workspace_id: str = None,
    ):
        self.max_results = max_results
        self.next_token = next_token
        self.operator_id = operator_id
        self.template_type = template_type
        self.workspace_id = workspace_id

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
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.template_type is not None:
            result['templateType'] = self.template_type
        if self.workspace_id is not None:
            result['workspaceId'] = self.workspace_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('templateType') is not None:
            self.template_type = m.get('templateType')
        if m.get('workspaceId') is not None:
            self.workspace_id = m.get('workspaceId')
        return self


class ListTemplateResponseBodyTemplateList(TeaModel):
    def __init__(
        self,
        cover_url: str = None,
        create_time: int = None,
        doc_type: str = None,
        id: str = None,
        template_type: str = None,
        title: str = None,
        update_time: int = None,
        workspace_id: str = None,
    ):
        self.cover_url = cover_url
        self.create_time = create_time
        self.doc_type = doc_type
        self.id = id
        self.template_type = template_type
        self.title = title
        self.update_time = update_time
        self.workspace_id = workspace_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cover_url is not None:
            result['coverUrl'] = self.cover_url
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.doc_type is not None:
            result['docType'] = self.doc_type
        if self.id is not None:
            result['id'] = self.id
        if self.template_type is not None:
            result['templateType'] = self.template_type
        if self.title is not None:
            result['title'] = self.title
        if self.update_time is not None:
            result['updateTime'] = self.update_time
        if self.workspace_id is not None:
            result['workspaceId'] = self.workspace_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('coverUrl') is not None:
            self.cover_url = m.get('coverUrl')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('docType') is not None:
            self.doc_type = m.get('docType')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('templateType') is not None:
            self.template_type = m.get('templateType')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('updateTime') is not None:
            self.update_time = m.get('updateTime')
        if m.get('workspaceId') is not None:
            self.workspace_id = m.get('workspaceId')
        return self


class ListTemplateResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        next_token: str = None,
        template_list: List[ListTemplateResponseBodyTemplateList] = None,
    ):
        self.has_more = has_more
        self.next_token = next_token
        self.template_list = template_list

    def validate(self):
        if self.template_list:
            for k in self.template_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['templateList'] = []
        if self.template_list is not None:
            for k in self.template_list:
                result['templateList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.template_list = []
        if m.get('templateList') is not None:
            for k in m.get('templateList'):
                temp_model = ListTemplateResponseBodyTemplateList()
                self.template_list.append(temp_model.from_map(k))
        return self


class ListTemplateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListTemplateResponseBody = None,
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
            temp_model = ListTemplateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class MergeRangeHeaders(TeaModel):
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


class MergeRangeRequest(TeaModel):
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


class MergeRangeResponseBody(TeaModel):
    def __init__(
        self,
        a_1notation: str = None,
    ):
        self.a_1notation = a_1notation

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.a_1notation is not None:
            result['a1Notation'] = self.a_1notation
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('a1Notation') is not None:
            self.a_1notation = m.get('a1Notation')
        return self


class MergeRangeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: MergeRangeResponseBody = None,
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
            temp_model = MergeRangeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RangeFindNextHeaders(TeaModel):
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


class RangeFindNextRequestFindOptions(TeaModel):
    def __init__(
        self,
        include_hidden: bool = None,
        match_case: bool = None,
        match_entire_cell: bool = None,
        match_formula_text: bool = None,
        scope: str = None,
        use_reg_exp: bool = None,
    ):
        self.include_hidden = include_hidden
        self.match_case = match_case
        self.match_entire_cell = match_entire_cell
        self.match_formula_text = match_formula_text
        self.scope = scope
        self.use_reg_exp = use_reg_exp

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.include_hidden is not None:
            result['includeHidden'] = self.include_hidden
        if self.match_case is not None:
            result['matchCase'] = self.match_case
        if self.match_entire_cell is not None:
            result['matchEntireCell'] = self.match_entire_cell
        if self.match_formula_text is not None:
            result['matchFormulaText'] = self.match_formula_text
        if self.scope is not None:
            result['scope'] = self.scope
        if self.use_reg_exp is not None:
            result['useRegExp'] = self.use_reg_exp
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('includeHidden') is not None:
            self.include_hidden = m.get('includeHidden')
        if m.get('matchCase') is not None:
            self.match_case = m.get('matchCase')
        if m.get('matchEntireCell') is not None:
            self.match_entire_cell = m.get('matchEntireCell')
        if m.get('matchFormulaText') is not None:
            self.match_formula_text = m.get('matchFormulaText')
        if m.get('scope') is not None:
            self.scope = m.get('scope')
        if m.get('useRegExp') is not None:
            self.use_reg_exp = m.get('useRegExp')
        return self


class RangeFindNextRequest(TeaModel):
    def __init__(
        self,
        find_options: RangeFindNextRequestFindOptions = None,
        text: str = None,
        operator_id: str = None,
    ):
        self.find_options = find_options
        self.text = text
        self.operator_id = operator_id

    def validate(self):
        if self.find_options:
            self.find_options.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.find_options is not None:
            result['findOptions'] = self.find_options.to_map()
        if self.text is not None:
            result['text'] = self.text
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('findOptions') is not None:
            temp_model = RangeFindNextRequestFindOptions()
            self.find_options = temp_model.from_map(m['findOptions'])
        if m.get('text') is not None:
            self.text = m.get('text')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class RangeFindNextResponseBody(TeaModel):
    def __init__(
        self,
        a_1notation: str = None,
    ):
        self.a_1notation = a_1notation

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.a_1notation is not None:
            result['a1Notation'] = self.a_1notation
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('a1Notation') is not None:
            self.a_1notation = m.get('a1Notation')
        return self


class RangeFindNextResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RangeFindNextResponseBody = None,
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
            temp_model = RangeFindNextResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SearchWorkspaceDocsHeaders(TeaModel):
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


class SearchWorkspaceDocsRequest(TeaModel):
    def __init__(
        self,
        keyword: str = None,
        max_results: int = None,
        next_token: str = None,
        operator_id: str = None,
        workspace_id: str = None,
    ):
        self.keyword = keyword
        self.max_results = max_results
        self.next_token = next_token
        self.operator_id = operator_id
        self.workspace_id = workspace_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.keyword is not None:
            result['keyword'] = self.keyword
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.workspace_id is not None:
            result['workspaceId'] = self.workspace_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('keyword') is not None:
            self.keyword = m.get('keyword')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('workspaceId') is not None:
            self.workspace_id = m.get('workspaceId')
        return self


class SearchWorkspaceDocsResponseBodyDocsNodeBO(TeaModel):
    def __init__(
        self,
        doc_type: str = None,
        last_edit_time: int = None,
        name: str = None,
        node_id: str = None,
        origin_name: str = None,
        url: str = None,
    ):
        self.doc_type = doc_type
        self.last_edit_time = last_edit_time
        self.name = name
        self.node_id = node_id
        self.origin_name = origin_name
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.doc_type is not None:
            result['docType'] = self.doc_type
        if self.last_edit_time is not None:
            result['lastEditTime'] = self.last_edit_time
        if self.name is not None:
            result['name'] = self.name
        if self.node_id is not None:
            result['nodeId'] = self.node_id
        if self.origin_name is not None:
            result['originName'] = self.origin_name
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('docType') is not None:
            self.doc_type = m.get('docType')
        if m.get('lastEditTime') is not None:
            self.last_edit_time = m.get('lastEditTime')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('nodeId') is not None:
            self.node_id = m.get('nodeId')
        if m.get('originName') is not None:
            self.origin_name = m.get('originName')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class SearchWorkspaceDocsResponseBodyDocsWorkspaceBO(TeaModel):
    def __init__(
        self,
        name: str = None,
        workspace_id: str = None,
    ):
        self.name = name
        self.workspace_id = workspace_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.workspace_id is not None:
            result['workspaceId'] = self.workspace_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('workspaceId') is not None:
            self.workspace_id = m.get('workspaceId')
        return self


class SearchWorkspaceDocsResponseBodyDocs(TeaModel):
    def __init__(
        self,
        node_bo: SearchWorkspaceDocsResponseBodyDocsNodeBO = None,
        workspace_bo: SearchWorkspaceDocsResponseBodyDocsWorkspaceBO = None,
    ):
        self.node_bo = node_bo
        self.workspace_bo = workspace_bo

    def validate(self):
        if self.node_bo:
            self.node_bo.validate()
        if self.workspace_bo:
            self.workspace_bo.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.node_bo is not None:
            result['nodeBO'] = self.node_bo.to_map()
        if self.workspace_bo is not None:
            result['workspaceBO'] = self.workspace_bo.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nodeBO') is not None:
            temp_model = SearchWorkspaceDocsResponseBodyDocsNodeBO()
            self.node_bo = temp_model.from_map(m['nodeBO'])
        if m.get('workspaceBO') is not None:
            temp_model = SearchWorkspaceDocsResponseBodyDocsWorkspaceBO()
            self.workspace_bo = temp_model.from_map(m['workspaceBO'])
        return self


class SearchWorkspaceDocsResponseBody(TeaModel):
    def __init__(
        self,
        docs: List[SearchWorkspaceDocsResponseBodyDocs] = None,
        has_more: bool = None,
        next_token: str = None,
    ):
        self.docs = docs
        self.has_more = has_more
        self.next_token = next_token

    def validate(self):
        if self.docs:
            for k in self.docs:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['docs'] = []
        if self.docs is not None:
            for k in self.docs:
                result['docs'].append(k.to_map() if k else None)
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.docs = []
        if m.get('docs') is not None:
            for k in m.get('docs'):
                temp_model = SearchWorkspaceDocsResponseBodyDocs()
                self.docs.append(temp_model.from_map(k))
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class SearchWorkspaceDocsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SearchWorkspaceDocsResponseBody = None,
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
            temp_model = SearchWorkspaceDocsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SetColumnWidthHeaders(TeaModel):
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


class SetColumnWidthRequest(TeaModel):
    def __init__(
        self,
        column: int = None,
        width: int = None,
        operator_id: str = None,
    ):
        self.column = column
        self.width = width
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.column is not None:
            result['column'] = self.column
        if self.width is not None:
            result['width'] = self.width
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('column') is not None:
            self.column = m.get('column')
        if m.get('width') is not None:
            self.width = m.get('width')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class SetColumnWidthResponseBody(TeaModel):
    def __init__(
        self,
        sheet_id: str = None,
        sheet_name: str = None,
    ):
        self.sheet_id = sheet_id
        self.sheet_name = sheet_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.sheet_id is not None:
            result['sheetId'] = self.sheet_id
        if self.sheet_name is not None:
            result['sheetName'] = self.sheet_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sheetId') is not None:
            self.sheet_id = m.get('sheetId')
        if m.get('sheetName') is not None:
            self.sheet_name = m.get('sheetName')
        return self


class SetColumnWidthResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SetColumnWidthResponseBody = None,
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
            temp_model = SetColumnWidthResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SetColumnsVisibilityHeaders(TeaModel):
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


class SetColumnsVisibilityRequest(TeaModel):
    def __init__(
        self,
        column: int = None,
        column_count: int = None,
        visibility: str = None,
        operator_id: str = None,
    ):
        self.column = column
        self.column_count = column_count
        self.visibility = visibility
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.column is not None:
            result['column'] = self.column
        if self.column_count is not None:
            result['columnCount'] = self.column_count
        if self.visibility is not None:
            result['visibility'] = self.visibility
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('column') is not None:
            self.column = m.get('column')
        if m.get('columnCount') is not None:
            self.column_count = m.get('columnCount')
        if m.get('visibility') is not None:
            self.visibility = m.get('visibility')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class SetColumnsVisibilityResponseBody(TeaModel):
    def __init__(
        self,
        id: str = None,
    ):
        self.id = id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        return self


class SetColumnsVisibilityResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SetColumnsVisibilityResponseBody = None,
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
            temp_model = SetColumnsVisibilityResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SetRowHeightHeaders(TeaModel):
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


class SetRowHeightRequest(TeaModel):
    def __init__(
        self,
        height: int = None,
        row: int = None,
        operator_id: str = None,
    ):
        self.height = height
        self.row = row
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.height is not None:
            result['height'] = self.height
        if self.row is not None:
            result['row'] = self.row
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('height') is not None:
            self.height = m.get('height')
        if m.get('row') is not None:
            self.row = m.get('row')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class SetRowHeightResponseBody(TeaModel):
    def __init__(
        self,
        sheet_id: str = None,
        sheet_name: str = None,
    ):
        self.sheet_id = sheet_id
        self.sheet_name = sheet_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.sheet_id is not None:
            result['sheetId'] = self.sheet_id
        if self.sheet_name is not None:
            result['sheetName'] = self.sheet_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sheetId') is not None:
            self.sheet_id = m.get('sheetId')
        if m.get('sheetName') is not None:
            self.sheet_name = m.get('sheetName')
        return self


class SetRowHeightResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SetRowHeightResponseBody = None,
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
            temp_model = SetRowHeightResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SetRowsVisibilityHeaders(TeaModel):
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


class SetRowsVisibilityRequest(TeaModel):
    def __init__(
        self,
        row: int = None,
        row_count: int = None,
        visibility: str = None,
        operator_id: str = None,
    ):
        self.row = row
        self.row_count = row_count
        self.visibility = visibility
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.row is not None:
            result['row'] = self.row
        if self.row_count is not None:
            result['rowCount'] = self.row_count
        if self.visibility is not None:
            result['visibility'] = self.visibility
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('row') is not None:
            self.row = m.get('row')
        if m.get('rowCount') is not None:
            self.row_count = m.get('rowCount')
        if m.get('visibility') is not None:
            self.visibility = m.get('visibility')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class SetRowsVisibilityResponseBody(TeaModel):
    def __init__(
        self,
        id: str = None,
    ):
        self.id = id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        return self


class SetRowsVisibilityResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SetRowsVisibilityResponseBody = None,
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
            temp_model = SetRowsVisibilityResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SheetAutofitRowsHeaders(TeaModel):
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


class SheetAutofitRowsRequest(TeaModel):
    def __init__(
        self,
        font_width: int = None,
        row: int = None,
        row_count: int = None,
        operator_id: str = None,
    ):
        self.font_width = font_width
        self.row = row
        self.row_count = row_count
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.font_width is not None:
            result['fontWidth'] = self.font_width
        if self.row is not None:
            result['row'] = self.row
        if self.row_count is not None:
            result['rowCount'] = self.row_count
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fontWidth') is not None:
            self.font_width = m.get('fontWidth')
        if m.get('row') is not None:
            self.row = m.get('row')
        if m.get('rowCount') is not None:
            self.row_count = m.get('rowCount')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class SheetAutofitRowsResponseBody(TeaModel):
    def __init__(
        self,
        id: str = None,
    ):
        self.id = id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        return self


class SheetAutofitRowsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SheetAutofitRowsResponseBody = None,
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
            temp_model = SheetAutofitRowsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SheetFindAllHeaders(TeaModel):
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


class SheetFindAllRequestFindOptions(TeaModel):
    def __init__(
        self,
        include_hidden: bool = None,
        match_case: bool = None,
        match_entire_cell: bool = None,
        match_formula_text: bool = None,
        scope: str = None,
        union_cells: bool = None,
        use_reg_exp: bool = None,
    ):
        self.include_hidden = include_hidden
        self.match_case = match_case
        self.match_entire_cell = match_entire_cell
        self.match_formula_text = match_formula_text
        self.scope = scope
        self.union_cells = union_cells
        self.use_reg_exp = use_reg_exp

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.include_hidden is not None:
            result['includeHidden'] = self.include_hidden
        if self.match_case is not None:
            result['matchCase'] = self.match_case
        if self.match_entire_cell is not None:
            result['matchEntireCell'] = self.match_entire_cell
        if self.match_formula_text is not None:
            result['matchFormulaText'] = self.match_formula_text
        if self.scope is not None:
            result['scope'] = self.scope
        if self.union_cells is not None:
            result['unionCells'] = self.union_cells
        if self.use_reg_exp is not None:
            result['useRegExp'] = self.use_reg_exp
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('includeHidden') is not None:
            self.include_hidden = m.get('includeHidden')
        if m.get('matchCase') is not None:
            self.match_case = m.get('matchCase')
        if m.get('matchEntireCell') is not None:
            self.match_entire_cell = m.get('matchEntireCell')
        if m.get('matchFormulaText') is not None:
            self.match_formula_text = m.get('matchFormulaText')
        if m.get('scope') is not None:
            self.scope = m.get('scope')
        if m.get('unionCells') is not None:
            self.union_cells = m.get('unionCells')
        if m.get('useRegExp') is not None:
            self.use_reg_exp = m.get('useRegExp')
        return self


class SheetFindAllRequest(TeaModel):
    def __init__(
        self,
        find_options: SheetFindAllRequestFindOptions = None,
        text: str = None,
        operator_id: str = None,
        select: str = None,
    ):
        self.find_options = find_options
        self.text = text
        self.operator_id = operator_id
        self.select = select

    def validate(self):
        if self.find_options:
            self.find_options.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.find_options is not None:
            result['findOptions'] = self.find_options.to_map()
        if self.text is not None:
            result['text'] = self.text
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.select is not None:
            result['select'] = self.select
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('findOptions') is not None:
            temp_model = SheetFindAllRequestFindOptions()
            self.find_options = temp_model.from_map(m['findOptions'])
        if m.get('text') is not None:
            self.text = m.get('text')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('select') is not None:
            self.select = m.get('select')
        return self


class SheetFindAllResponseBodyValue(TeaModel):
    def __init__(
        self,
        a_1notation: str = None,
        values: List[List[Any]] = None,
    ):
        self.a_1notation = a_1notation
        self.values = values

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.a_1notation is not None:
            result['a1Notation'] = self.a_1notation
        if self.values is not None:
            result['values'] = self.values
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('a1Notation') is not None:
            self.a_1notation = m.get('a1Notation')
        if m.get('values') is not None:
            self.values = m.get('values')
        return self


class SheetFindAllResponseBody(TeaModel):
    def __init__(
        self,
        value: List[SheetFindAllResponseBodyValue] = None,
    ):
        self.value = value

    def validate(self):
        if self.value:
            for k in self.value:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['value'] = []
        if self.value is not None:
            for k in self.value:
                result['value'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.value = []
        if m.get('value') is not None:
            for k in m.get('value'):
                temp_model = SheetFindAllResponseBodyValue()
                self.value.append(temp_model.from_map(k))
        return self


class SheetFindAllResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SheetFindAllResponseBody = None,
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
            temp_model = SheetFindAllResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UnbindCoolAppToSheetHeaders(TeaModel):
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


class UnbindCoolAppToSheetRequest(TeaModel):
    def __init__(
        self,
        cool_app_code: str = None,
        operator_id: str = None,
    ):
        self.cool_app_code = cool_app_code
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cool_app_code is not None:
            result['coolAppCode'] = self.cool_app_code
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('coolAppCode') is not None:
            self.cool_app_code = m.get('coolAppCode')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class UnbindCoolAppToSheetResponseBody(TeaModel):
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


class UnbindCoolAppToSheetResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UnbindCoolAppToSheetResponseBody = None,
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
            temp_model = UnbindCoolAppToSheetResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateRangeHeaders(TeaModel):
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


class UpdateRangeRequestHyperlinks(TeaModel):
    def __init__(
        self,
        type: str = None,
        link: str = None,
        text: str = None,
    ):
        self.type = type
        self.link = link
        self.text = text

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.link is not None:
            result['link'] = self.link
        if self.text is not None:
            result['text'] = self.text
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('link') is not None:
            self.link = m.get('link')
        if m.get('text') is not None:
            self.text = m.get('text')
        return self


class UpdateRangeRequest(TeaModel):
    def __init__(
        self,
        background_colors: List[List[str]] = None,
        font_sizes: List[List[int]] = None,
        font_weights: List[List[str]] = None,
        horizontal_alignments: List[List[str]] = None,
        hyperlinks: List[List[UpdateRangeRequestHyperlinks]] = None,
        number_format: str = None,
        values: List[List[str]] = None,
        vertical_alignments: List[List[str]] = None,
        operator_id: str = None,
    ):
        self.background_colors = background_colors
        self.font_sizes = font_sizes
        self.font_weights = font_weights
        self.horizontal_alignments = horizontal_alignments
        self.hyperlinks = hyperlinks
        self.number_format = number_format
        self.values = values
        self.vertical_alignments = vertical_alignments
        self.operator_id = operator_id

    def validate(self):
        if self.hyperlinks:
            for k in self.hyperlinks:
                for k1 in k:
                    if k1:
                        k1.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.background_colors is not None:
            result['backgroundColors'] = self.background_colors
        if self.font_sizes is not None:
            result['fontSizes'] = self.font_sizes
        if self.font_weights is not None:
            result['fontWeights'] = self.font_weights
        if self.horizontal_alignments is not None:
            result['horizontalAlignments'] = self.horizontal_alignments
        result['hyperlinks'] = []
        if self.hyperlinks is not None:
            for k in self.hyperlinks:
                l1 = []
                for k1 in k:
                    l1.append(k1.to_map() if k1 else None)
                result['hyperlinks'].append(l1)
        if self.number_format is not None:
            result['numberFormat'] = self.number_format
        if self.values is not None:
            result['values'] = self.values
        if self.vertical_alignments is not None:
            result['verticalAlignments'] = self.vertical_alignments
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('backgroundColors') is not None:
            self.background_colors = m.get('backgroundColors')
        if m.get('fontSizes') is not None:
            self.font_sizes = m.get('fontSizes')
        if m.get('fontWeights') is not None:
            self.font_weights = m.get('fontWeights')
        if m.get('horizontalAlignments') is not None:
            self.horizontal_alignments = m.get('horizontalAlignments')
        self.hyperlinks = []
        if m.get('hyperlinks') is not None:
            for k in m.get('hyperlinks'):
                l1 = []
                for k1 in k:
                    temp_model = UpdateRangeRequestHyperlinks()
                    l1.append(temp_model.from_map(k1))
                self.hyperlinks.append(l1)
        if m.get('numberFormat') is not None:
            self.number_format = m.get('numberFormat')
        if m.get('values') is not None:
            self.values = m.get('values')
        if m.get('verticalAlignments') is not None:
            self.vertical_alignments = m.get('verticalAlignments')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class UpdateRangeResponseBody(TeaModel):
    def __init__(
        self,
        a_1notation: str = None,
    ):
        self.a_1notation = a_1notation

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.a_1notation is not None:
            result['a1Notation'] = self.a_1notation
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('a1Notation') is not None:
            self.a_1notation = m.get('a1Notation')
        return self


class UpdateRangeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateRangeResponseBody = None,
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
            temp_model = UpdateRangeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateSheetHeaders(TeaModel):
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


class UpdateSheetRequest(TeaModel):
    def __init__(
        self,
        name: str = None,
        visibility: str = None,
        operator_id: str = None,
    ):
        self.name = name
        self.visibility = visibility
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.visibility is not None:
            result['visibility'] = self.visibility
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('visibility') is not None:
            self.visibility = m.get('visibility')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class UpdateSheetResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
    ):
        self.headers = headers
        self.status_code = status_code

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        return self


class UpdateWorkspaceDocMembersHeaders(TeaModel):
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


class UpdateWorkspaceDocMembersRequestMembers(TeaModel):
    def __init__(
        self,
        member_id: str = None,
        member_type: str = None,
        role_type: str = None,
    ):
        self.member_id = member_id
        self.member_type = member_type
        self.role_type = role_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.member_id is not None:
            result['memberId'] = self.member_id
        if self.member_type is not None:
            result['memberType'] = self.member_type
        if self.role_type is not None:
            result['roleType'] = self.role_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('memberId') is not None:
            self.member_id = m.get('memberId')
        if m.get('memberType') is not None:
            self.member_type = m.get('memberType')
        if m.get('roleType') is not None:
            self.role_type = m.get('roleType')
        return self


class UpdateWorkspaceDocMembersRequest(TeaModel):
    def __init__(
        self,
        members: List[UpdateWorkspaceDocMembersRequestMembers] = None,
        operator_id: str = None,
    ):
        self.members = members
        self.operator_id = operator_id

    def validate(self):
        if self.members:
            for k in self.members:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['members'] = []
        if self.members is not None:
            for k in self.members:
                result['members'].append(k.to_map() if k else None)
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.members = []
        if m.get('members') is not None:
            for k in m.get('members'):
                temp_model = UpdateWorkspaceDocMembersRequestMembers()
                self.members.append(temp_model.from_map(k))
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class UpdateWorkspaceDocMembersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
    ):
        self.headers = headers
        self.status_code = status_code

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        return self


class UpdateWorkspaceMembersHeaders(TeaModel):
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


class UpdateWorkspaceMembersRequestMembers(TeaModel):
    def __init__(
        self,
        member_id: str = None,
        member_type: str = None,
        role_type: str = None,
    ):
        self.member_id = member_id
        self.member_type = member_type
        self.role_type = role_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.member_id is not None:
            result['memberId'] = self.member_id
        if self.member_type is not None:
            result['memberType'] = self.member_type
        if self.role_type is not None:
            result['roleType'] = self.role_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('memberId') is not None:
            self.member_id = m.get('memberId')
        if m.get('memberType') is not None:
            self.member_type = m.get('memberType')
        if m.get('roleType') is not None:
            self.role_type = m.get('roleType')
        return self


class UpdateWorkspaceMembersRequest(TeaModel):
    def __init__(
        self,
        members: List[UpdateWorkspaceMembersRequestMembers] = None,
        operator_id: str = None,
    ):
        self.members = members
        self.operator_id = operator_id

    def validate(self):
        if self.members:
            for k in self.members:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['members'] = []
        if self.members is not None:
            for k in self.members:
                result['members'].append(k.to_map() if k else None)
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.members = []
        if m.get('members') is not None:
            for k in m.get('members'):
                temp_model = UpdateWorkspaceMembersRequestMembers()
                self.members.append(temp_model.from_map(k))
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class UpdateWorkspaceMembersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
    ):
        self.headers = headers
        self.status_code = status_code

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        return self


