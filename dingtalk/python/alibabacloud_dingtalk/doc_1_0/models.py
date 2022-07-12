# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


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
        # 被操作用户unionId
        self.member_id = member_id
        # 用户类型
        self.member_type = member_type
        # 用户权限
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
        # 被操作用户组
        self.members = members
        # 发起操作者unionId
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
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
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
        # 被操作用户unionId
        self.member_id = member_id
        # 用户类型
        self.member_type = member_type
        # 用户权限
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
        # 被操作用户组
        self.members = members
        # 发起操作者unionId
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
        body: AddWorkspaceMembersResponseBody = None,
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
        # 要追加的值
        self.values = values
        # 操作人unionId
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
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
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
        # 查询节点Id
        self.node_ids = node_ids
        # 操作用户unionId
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
        # 节点类型
        self.doc_type = doc_type
        # 最后编辑时间
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
        body: BatchGetWorkspaceDocsResponseBody = None,
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
        # 是否查询最近访问文档
        self.include_recent = include_recent
        # 操作用户unionId
        self.operator_id = operator_id
        # 待查询空间Id
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
        # 最近编辑时间
        self.last_edit_time = last_edit_time
        # 文档名称
        self.name = name
        # 文档Id
        self.node_id = node_id
        # 文档打开url
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
        # 团队空间创建时间
        self.create_time = create_time
        # 团队空间名称
        self.name = name
        # 是否全员公开
        self.org_published = org_published
        # 最近访问列表
        self.recent_list = recent_list
        # 团队空间打开url
        self.url = url
        # 团队空间Id
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
        # 是否有访问团队空间权限
        self.has_permission = has_permission
        # 团队空间信息
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
        # workspace信息
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
        body: BatchGetWorkspacesResponseBody = None,
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
            temp_model = BatchGetWorkspacesResponseBody()
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
        # 工作表名称
        self.name = name
        # 操作人unionId
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
        name: str = None,
        visibility: str = None,
    ):
        # 创建的工作表的名称。当输入参数中的工作表名称在表格中已存在时，可能与输入参数指定的工作表名称不同。
        self.name = name
        # 工作表可见性
        self.visibility = visibility

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('visibility') is not None:
            self.visibility = m.get('visibility')
        return self


class CreateSheetResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateSheetResponseBody = None,
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
        # 团队空间描述
        self.description = description
        # 团队空间名称
        self.name = name
        # 用户id
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
        # 工作空间描述
        self.description = description
        # 工作空间名称
        self.name = name
        # 工作空间打开url
        self.url = url
        # 工作空间id
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
        body: CreateWorkspaceResponseBody = None,
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
        # 文档类型
        self.doc_type = doc_type
        # 文档名
        self.name = name
        # 操作人unionId
        self.operator_id = operator_id
        # 父节点nodeId
        self.parent_node_id = parent_node_id
        # 文档模板id
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
        # 文档docKey
        self.doc_key = doc_key
        # 文档Id
        self.node_id = node_id
        # 文档打开url
        self.url = url
        # 团队空间Id
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
        body: CreateWorkspaceDocResponseBody = None,
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
            temp_model = CreateWorkspaceDocResponseBody()
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
        # 操作人unionId
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


class DeleteSheetResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
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
        # 发起删除请求的用户用户的unionId
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
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
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
        # 被操作用户unionId
        self.member_id = member_id
        # 用户类型
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
        # 被操作用户组
        self.members = members
        # 发起操作者unionId
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
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
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
        # 被操作用户unionId
        self.member_id = member_id
        # 用户类型
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
        # 被操作用户组
        self.members = members
        # 发起操作者unionId
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
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
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
    ):
        # 操作人unionId
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


class GetRangeResponseBody(TeaModel):
    def __init__(
        self,
        display_values: List[str] = None,
        formulas: List[str] = None,
        values: List[str] = None,
    ):
        self.display_values = display_values
        self.formulas = formulas
        # 值
        self.values = values

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_values is not None:
            result['displayValues'] = self.display_values
        if self.formulas is not None:
            result['formulas'] = self.formulas
        if self.values is not None:
            result['values'] = self.values
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayValues') is not None:
            self.display_values = m.get('displayValues')
        if m.get('formulas') is not None:
            self.formulas = m.get('formulas')
        if m.get('values') is not None:
            self.values = m.get('values')
        return self


class GetRangeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetRangeResponseBody = None,
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
        # 查询size
        self.max_results = max_results
        self.next_token = next_token
        # 发起操作用户unionId
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
        # 创建时间
        self.create_time = create_time
        # 节点类型
        self.doc_type = doc_type
        # 是否被删除
        self.is_deleted = is_deleted
        # 内容的最后编辑时间
        self.last_edit_time = last_edit_time
        # 文档Id
        self.node_id = node_id
        # 文档名称
        self.node_name = node_name
        # 文档更新时间，包括重命名、移动、内容编辑等操作都会刷新更新时间
        self.update_time = update_time
        # 文档打开url
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
        # 团队空间打开url
        self.url = url
        # 团队空间Id
        self.workspace_id = workspace_id
        # 团队空间名称
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
        # 文档信息
        self.node_bo = node_bo
        # 团队空间信息
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
        # 查询结果
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
        body: GetRecentEditDocsResponseBody = None,
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
        # 查询size
        self.max_results = max_results
        self.next_token = next_token
        # 发起操作用户unionId
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
        # 创建时间
        self.create_time = create_time
        # 节点类型
        self.doc_type = doc_type
        # 是否被删除
        self.is_deleted = is_deleted
        # 最后编辑时间
        self.last_open_time = last_open_time
        # 文档Id
        self.node_id = node_id
        # 文档名称
        self.node_name = node_name
        # 文档更新时间，包括重命名、移动、内容编辑等操作都会刷新更新时间
        self.update_time = update_time
        # 文档打开url
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
        # 团队空间打开url
        self.url = url
        # 团队空间Id
        self.workspace_id = workspace_id
        # 团队空间名称
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
        # 文档信息
        self.node_bo = node_bo
        # 团队空间信息
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
        # 查询结果
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
        body: GetRecentOpenDocsResponseBody = None,
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
        # 是否查询最近访问文档列表
        self.include_recent = include_recent
        # 发起操作用户unionId
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
        # 文档最后编辑时间
        self.last_edit_time = last_edit_time
        # 文档名称
        self.name = name
        # 文档id
        self.node_id = node_id
        # 文档打开url
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
        # 团队空间创建时间
        self.create_time = create_time
        # 团队空间是否被删除
        self.deleted = deleted
        # 团队空间名称
        self.name = name
        self.owner = owner
        # 团队空间最近访问文档列表
        self.recent_list = recent_list
        # 用户的角色
        self.role = role
        # 团队空间打开url
        self.url = url
        # 团队空间Id
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
        # 团队空间结果集
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
        body: GetRelatedWorkspacesResponseBody = None,
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
        # 操作人unionId
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
        last_non_empty_column: int = None,
        last_non_empty_row: int = None,
        name: str = None,
        visibility: str = None,
    ):
        # 最后一列非空列的位置，从0开始。表为空时返回-1。
        self.last_non_empty_column = last_non_empty_column
        # 最后一行非空行的位置，从0开始。表为空时返回-1。
        self.last_non_empty_row = last_non_empty_row
        # 工作表名称
        self.name = name
        # 工作表可见性
        self.visibility = visibility

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.last_non_empty_column is not None:
            result['lastNonEmptyColumn'] = self.last_non_empty_column
        if self.last_non_empty_row is not None:
            result['lastNonEmptyRow'] = self.last_non_empty_row
        if self.name is not None:
            result['name'] = self.name
        if self.visibility is not None:
            result['visibility'] = self.visibility
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('lastNonEmptyColumn') is not None:
            self.last_non_empty_column = m.get('lastNonEmptyColumn')
        if m.get('lastNonEmptyRow') is not None:
            self.last_non_empty_row = m.get('lastNonEmptyRow')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('visibility') is not None:
            self.visibility = m.get('visibility')
        return self


class GetSheetResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetSheetResponseBody = None,
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
            temp_model = GetSheetResponseBody()
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
        corp_id: str = None,
        is_deleted: bool = None,
        owner: str = None,
        url: str = None,
    ):
        # 团队空间所属企业id
        self.corp_id = corp_id
        self.is_deleted = is_deleted
        self.owner = owner
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.is_deleted is not None:
            result['isDeleted'] = self.is_deleted
        if self.owner is not None:
            result['owner'] = self.owner
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('isDeleted') is not None:
            self.is_deleted = m.get('isDeleted')
        if m.get('owner') is not None:
            self.owner = m.get('owner')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class GetWorkspaceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetWorkspaceResponseBody = None,
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
        # 操作用户unionId
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
        # 节点类型
        self.doc_type = doc_type
        # 最后编辑时间
        self.last_edit_time = last_edit_time
        # 节点名称
        self.name = name
        # 节点Id
        self.node_id = node_id
        # 节点打开url
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
        # 团队空间名称
        self.name = name
        # 团队空间Id
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
        # 是否有权限
        self.has_permission = has_permission
        # 节点信息
        self.node_bo = node_bo
        # 节点所属团队空间信息
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
        body: GetWorkspaceNodeResponseBody = None,
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
            temp_model = GetWorkspaceNodeResponseBody()
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
        # 是否加粗
        self.bold = bold
        # 数据类型
        self.data_type = data_type
        # 字体大小
        self.font_size = font_size
        # 字体大小单位
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
        # 文本内容
        self.content = content
        # 文字样式
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
        # 元素类型
        self.element_type = element_type
        # 文本元素
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
        # 标题样式
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
        # 子节点
        self.children = children
        # 段落样式
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
        # 元素类型标识
        self.block_type = block_type
        # 段落元素
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
        # 头部插入
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
        # 元素数组
        self.blocks = blocks
        # 位置信息
        self.location = location
        # 操作用户unionId
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
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
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
        # 查询模版数量
        self.max_results = max_results
        # 翻页token
        self.next_token = next_token
        # 操作用户unionId
        self.operator_id = operator_id
        # 模版类型
        self.template_type = template_type
        # 团队空间Id
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
        # 模版预览url
        self.cover_url = cover_url
        # 模版创建时间
        self.create_time = create_time
        # 模版对应文档类型
        self.doc_type = doc_type
        # 模版Id
        self.id = id
        # 模版类型
        self.template_type = template_type
        # 模版标题
        self.title = title
        # 模版修改时间
        self.update_time = update_time
        # 模版归属空间Id
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
        # 是否还有更多模版
        self.has_more = has_more
        # 后续结果的偏移
        self.next_token = next_token
        # 模版信息列表
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
        body: ListTemplateResponseBody = None,
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
            temp_model = ListTemplateResponseBody()
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
        match_case: bool = None,
        match_entire_cell: bool = None,
        match_formula_text: bool = None,
        scope: str = None,
        use_reg_exp: bool = None,
    ):
        # 匹配大小写
        self.match_case = match_case
        # 匹配整个单元格
        self.match_entire_cell = match_entire_cell
        # 在公式内搜索
        self.match_formula_text = match_formula_text
        self.scope = scope
        # text是正则表达式
        self.use_reg_exp = use_reg_exp

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
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
        # 查找选项
        self.find_options = find_options
        # 要查找的文本
        self.text = text
        # 操作人unionId
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
        # 找到的单元格的地址，使用A1表示法
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
        body: RangeFindNextResponseBody = None,
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
        # 搜索关键字
        self.keyword = keyword
        # 搜索数量
        self.max_results = max_results
        # 翻页Id
        self.next_token = next_token
        # 发起操作用户unionId
        self.operator_id = operator_id
        # 团队空间Id
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
        # 节点类型
        self.doc_type = doc_type
        # 最近编辑时间
        self.last_edit_time = last_edit_time
        # 节点名称，如果命中了搜索关键词会包含高亮标签
        self.name = name
        # 节点Id
        self.node_id = node_id
        # 节点原始名称
        self.origin_name = origin_name
        # 节点打开url
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
        # 团队空间名称
        self.name = name
        # 团队空间Id
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
        # 是否还有可搜索内容
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
        body: SearchWorkspaceDocsResponseBody = None,
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
            temp_model = SearchWorkspaceDocsResponseBody()
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
        # 超链接类型，可选 "path", "sheet", "range"
        self.type = type
        # 链接地址
        self.link = link
        # 链接文本
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
        hyperlinks: List[List[UpdateRangeRequestHyperlinks]] = None,
        values: List[List[str]] = None,
        operator_id: str = None,
    ):
        # 背景色
        self.background_colors = background_colors
        self.hyperlinks = hyperlinks
        # 值
        self.values = values
        # 操作人unionId
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
        result['hyperlinks'] = []
        if self.hyperlinks is not None:
            for k in self.hyperlinks:
                l1 = []
                for k1 in k:
                    l1.append(k1.to_map() if k1 else None)
                result['hyperlinks'].append(l1)
        if self.values is not None:
            result['values'] = self.values
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('backgroundColors') is not None:
            self.background_colors = m.get('backgroundColors')
        self.hyperlinks = []
        if m.get('hyperlinks') is not None:
            for k in m.get('hyperlinks'):
                l1 = []
                for k1 in k:
                    temp_model = UpdateRangeRequestHyperlinks()
                    l1.append(temp_model.from_map(k1))
                self.hyperlinks.append(l1)
        if m.get('values') is not None:
            self.values = m.get('values')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class UpdateRangeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
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
        # 工作表名称
        self.name = name
        # 工作表可见性
        self.visibility = visibility
        # 操作人unionId
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
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
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
        # 被操作用户unionId
        self.member_id = member_id
        # 用户类型
        self.member_type = member_type
        # 用户权限
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
        # 被操作用户组
        self.members = members
        # 发起操作者unionId
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
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
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
        # 被操作用户unionId
        self.member_id = member_id
        # 用户类型
        self.member_type = member_type
        # 用户权限
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
        # 被操作用户组
        self.members = members
        # 发起操作者unionId
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
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        return self


