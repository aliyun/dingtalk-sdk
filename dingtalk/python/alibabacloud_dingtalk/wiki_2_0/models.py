# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class AddTeamHeaders(TeaModel):
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


class AddTeamRequestOptionIcon(TeaModel):
    def __init__(
        self,
        type: str = None,
        value: str = None,
    ):
        self.type = type
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class AddTeamRequestOption(TeaModel):
    def __init__(
        self,
        cover: str = None,
        description: str = None,
        icon: AddTeamRequestOptionIcon = None,
    ):
        self.cover = cover
        self.description = description
        self.icon = icon

    def validate(self):
        if self.icon:
            self.icon.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cover is not None:
            result['cover'] = self.cover
        if self.description is not None:
            result['description'] = self.description
        if self.icon is not None:
            result['icon'] = self.icon.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cover') is not None:
            self.cover = m.get('cover')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('icon') is not None:
            temp_model = AddTeamRequestOptionIcon()
            self.icon = temp_model.from_map(m['icon'])
        return self


class AddTeamRequest(TeaModel):
    def __init__(
        self,
        name: str = None,
        option: AddTeamRequestOption = None,
        operator_id: str = None,
    ):
        self.name = name
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
        if self.name is not None:
            result['name'] = self.name
        if self.option is not None:
            result['option'] = self.option.to_map()
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('option') is not None:
            temp_model = AddTeamRequestOption()
            self.option = temp_model.from_map(m['option'])
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class AddTeamResponseBodyTeamIcon(TeaModel):
    def __init__(
        self,
        type: str = None,
        value: str = None,
    ):
        self.type = type
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class AddTeamResponseBodyTeam(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        cover: str = None,
        create_time: str = None,
        creator_id: str = None,
        description: str = None,
        icon: AddTeamResponseBodyTeamIcon = None,
        modified_time: str = None,
        modifier_id: str = None,
        name: str = None,
        team_id: str = None,
    ):
        self.corp_id = corp_id
        self.cover = cover
        self.create_time = create_time
        self.creator_id = creator_id
        self.description = description
        self.icon = icon
        self.modified_time = modified_time
        self.modifier_id = modifier_id
        self.name = name
        self.team_id = team_id

    def validate(self):
        if self.icon:
            self.icon.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.cover is not None:
            result['cover'] = self.cover
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.description is not None:
            result['description'] = self.description
        if self.icon is not None:
            result['icon'] = self.icon.to_map()
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        if self.modifier_id is not None:
            result['modifierId'] = self.modifier_id
        if self.name is not None:
            result['name'] = self.name
        if self.team_id is not None:
            result['teamId'] = self.team_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('cover') is not None:
            self.cover = m.get('cover')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('icon') is not None:
            temp_model = AddTeamResponseBodyTeamIcon()
            self.icon = temp_model.from_map(m['icon'])
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        if m.get('modifierId') is not None:
            self.modifier_id = m.get('modifierId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('teamId') is not None:
            self.team_id = m.get('teamId')
        return self


class AddTeamResponseBody(TeaModel):
    def __init__(
        self,
        team: AddTeamResponseBodyTeam = None,
    ):
        self.team = team

    def validate(self):
        if self.team:
            self.team.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.team is not None:
            result['team'] = self.team.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('team') is not None:
            temp_model = AddTeamResponseBodyTeam()
            self.team = temp_model.from_map(m['team'])
        return self


class AddTeamResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AddTeamResponseBody = None,
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
            temp_model = AddTeamResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AddWorkspaceHeaders(TeaModel):
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


class AddWorkspaceRequestOption(TeaModel):
    def __init__(
        self,
        description: str = None,
        team_id: str = None,
    ):
        self.description = description
        self.team_id = team_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.description is not None:
            result['description'] = self.description
        if self.team_id is not None:
            result['teamId'] = self.team_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('teamId') is not None:
            self.team_id = m.get('teamId')
        return self


class AddWorkspaceRequest(TeaModel):
    def __init__(
        self,
        name: str = None,
        option: AddWorkspaceRequestOption = None,
        operator_id: str = None,
    ):
        self.name = name
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
        if self.name is not None:
            result['name'] = self.name
        if self.option is not None:
            result['option'] = self.option.to_map()
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('option') is not None:
            temp_model = AddWorkspaceRequestOption()
            self.option = temp_model.from_map(m['option'])
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class AddWorkspaceResponseBodyWorkspaceIcon(TeaModel):
    def __init__(
        self,
        type: str = None,
        value: str = None,
    ):
        self.type = type
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class AddWorkspaceResponseBodyWorkspace(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        cover: str = None,
        create_time: str = None,
        creator_id: str = None,
        description: str = None,
        icon: AddWorkspaceResponseBodyWorkspaceIcon = None,
        modified_time: str = None,
        modifier_id: str = None,
        name: str = None,
        permission_role: str = None,
        root_node_id: str = None,
        team_id: str = None,
        type: str = None,
        url: str = None,
        workspace_id: str = None,
    ):
        self.corp_id = corp_id
        self.cover = cover
        self.create_time = create_time
        self.creator_id = creator_id
        self.description = description
        self.icon = icon
        self.modified_time = modified_time
        self.modifier_id = modifier_id
        self.name = name
        self.permission_role = permission_role
        self.root_node_id = root_node_id
        self.team_id = team_id
        self.type = type
        self.url = url
        self.workspace_id = workspace_id

    def validate(self):
        if self.icon:
            self.icon.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.cover is not None:
            result['cover'] = self.cover
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.description is not None:
            result['description'] = self.description
        if self.icon is not None:
            result['icon'] = self.icon.to_map()
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        if self.modifier_id is not None:
            result['modifierId'] = self.modifier_id
        if self.name is not None:
            result['name'] = self.name
        if self.permission_role is not None:
            result['permissionRole'] = self.permission_role
        if self.root_node_id is not None:
            result['rootNodeId'] = self.root_node_id
        if self.team_id is not None:
            result['teamId'] = self.team_id
        if self.type is not None:
            result['type'] = self.type
        if self.url is not None:
            result['url'] = self.url
        if self.workspace_id is not None:
            result['workspaceId'] = self.workspace_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('cover') is not None:
            self.cover = m.get('cover')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('icon') is not None:
            temp_model = AddWorkspaceResponseBodyWorkspaceIcon()
            self.icon = temp_model.from_map(m['icon'])
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        if m.get('modifierId') is not None:
            self.modifier_id = m.get('modifierId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('permissionRole') is not None:
            self.permission_role = m.get('permissionRole')
        if m.get('rootNodeId') is not None:
            self.root_node_id = m.get('rootNodeId')
        if m.get('teamId') is not None:
            self.team_id = m.get('teamId')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('url') is not None:
            self.url = m.get('url')
        if m.get('workspaceId') is not None:
            self.workspace_id = m.get('workspaceId')
        return self


class AddWorkspaceResponseBody(TeaModel):
    def __init__(
        self,
        workspace: AddWorkspaceResponseBodyWorkspace = None,
    ):
        self.workspace = workspace

    def validate(self):
        if self.workspace:
            self.workspace.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.workspace is not None:
            result['workspace'] = self.workspace.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('workspace') is not None:
            temp_model = AddWorkspaceResponseBodyWorkspace()
            self.workspace = temp_model.from_map(m['workspace'])
        return self


class AddWorkspaceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AddWorkspaceResponseBody = None,
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
            temp_model = AddWorkspaceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteTeamHeaders(TeaModel):
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


class DeleteTeamRequest(TeaModel):
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


class DeleteTeamResponseBody(TeaModel):
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


class DeleteTeamResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteTeamResponseBody = None,
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
            temp_model = DeleteTeamResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetDefaultHandOverUserHeaders(TeaModel):
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


class GetDefaultHandOverUserRequest(TeaModel):
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


class GetDefaultHandOverUserResponseBody(TeaModel):
    def __init__(
        self,
        default_handover_user_id: str = None,
    ):
        self.default_handover_user_id = default_handover_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.default_handover_user_id is not None:
            result['defaultHandoverUserId'] = self.default_handover_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('defaultHandoverUserId') is not None:
            self.default_handover_user_id = m.get('defaultHandoverUserId')
        return self


class GetDefaultHandOverUserResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetDefaultHandOverUserResponseBody = None,
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
            temp_model = GetDefaultHandOverUserResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetMineWorkspaceHeaders(TeaModel):
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


class GetMineWorkspaceRequest(TeaModel):
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


class GetMineWorkspaceResponseBodyWorkspaceIcon(TeaModel):
    def __init__(
        self,
        type: str = None,
        value: str = None,
    ):
        self.type = type
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class GetMineWorkspaceResponseBodyWorkspace(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        cover: str = None,
        create_time: str = None,
        creator_id: str = None,
        description: str = None,
        icon: GetMineWorkspaceResponseBodyWorkspaceIcon = None,
        modified_time: str = None,
        modifier_id: str = None,
        name: str = None,
        permission_role: str = None,
        root_node_id: str = None,
        team_id: str = None,
        type: str = None,
        url: str = None,
        workspace_id: str = None,
    ):
        self.corp_id = corp_id
        self.cover = cover
        self.create_time = create_time
        self.creator_id = creator_id
        self.description = description
        self.icon = icon
        self.modified_time = modified_time
        self.modifier_id = modifier_id
        self.name = name
        self.permission_role = permission_role
        self.root_node_id = root_node_id
        self.team_id = team_id
        self.type = type
        self.url = url
        self.workspace_id = workspace_id

    def validate(self):
        if self.icon:
            self.icon.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.cover is not None:
            result['cover'] = self.cover
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.description is not None:
            result['description'] = self.description
        if self.icon is not None:
            result['icon'] = self.icon.to_map()
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        if self.modifier_id is not None:
            result['modifierId'] = self.modifier_id
        if self.name is not None:
            result['name'] = self.name
        if self.permission_role is not None:
            result['permissionRole'] = self.permission_role
        if self.root_node_id is not None:
            result['rootNodeId'] = self.root_node_id
        if self.team_id is not None:
            result['teamId'] = self.team_id
        if self.type is not None:
            result['type'] = self.type
        if self.url is not None:
            result['url'] = self.url
        if self.workspace_id is not None:
            result['workspaceId'] = self.workspace_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('cover') is not None:
            self.cover = m.get('cover')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('icon') is not None:
            temp_model = GetMineWorkspaceResponseBodyWorkspaceIcon()
            self.icon = temp_model.from_map(m['icon'])
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        if m.get('modifierId') is not None:
            self.modifier_id = m.get('modifierId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('permissionRole') is not None:
            self.permission_role = m.get('permissionRole')
        if m.get('rootNodeId') is not None:
            self.root_node_id = m.get('rootNodeId')
        if m.get('teamId') is not None:
            self.team_id = m.get('teamId')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('url') is not None:
            self.url = m.get('url')
        if m.get('workspaceId') is not None:
            self.workspace_id = m.get('workspaceId')
        return self


class GetMineWorkspaceResponseBody(TeaModel):
    def __init__(
        self,
        workspace: GetMineWorkspaceResponseBodyWorkspace = None,
    ):
        self.workspace = workspace

    def validate(self):
        if self.workspace:
            self.workspace.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.workspace is not None:
            result['workspace'] = self.workspace.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('workspace') is not None:
            temp_model = GetMineWorkspaceResponseBodyWorkspace()
            self.workspace = temp_model.from_map(m['workspace'])
        return self


class GetMineWorkspaceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetMineWorkspaceResponseBody = None,
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
            temp_model = GetMineWorkspaceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetNodeHeaders(TeaModel):
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


class GetNodeRequest(TeaModel):
    def __init__(
        self,
        operator_id: str = None,
        with_permission_role: bool = None,
        with_statistical_info: bool = None,
    ):
        self.operator_id = operator_id
        self.with_permission_role = with_permission_role
        self.with_statistical_info = with_statistical_info

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.with_permission_role is not None:
            result['withPermissionRole'] = self.with_permission_role
        if self.with_statistical_info is not None:
            result['withStatisticalInfo'] = self.with_statistical_info
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('withPermissionRole') is not None:
            self.with_permission_role = m.get('withPermissionRole')
        if m.get('withStatisticalInfo') is not None:
            self.with_statistical_info = m.get('withStatisticalInfo')
        return self


class GetNodeResponseBodyNodeStatisticalInfo(TeaModel):
    def __init__(
        self,
        word_count: int = None,
    ):
        self.word_count = word_count

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.word_count is not None:
            result['wordCount'] = self.word_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('wordCount') is not None:
            self.word_count = m.get('wordCount')
        return self


class GetNodeResponseBodyNode(TeaModel):
    def __init__(
        self,
        category: str = None,
        create_time: str = None,
        creator_id: str = None,
        extension: str = None,
        has_children: bool = None,
        modified_time: str = None,
        modifier_id: str = None,
        name: str = None,
        node_id: str = None,
        permission_role: str = None,
        size: int = None,
        statistical_info: GetNodeResponseBodyNodeStatisticalInfo = None,
        type: str = None,
        url: str = None,
        workspace_id: str = None,
    ):
        self.category = category
        self.create_time = create_time
        self.creator_id = creator_id
        self.extension = extension
        self.has_children = has_children
        self.modified_time = modified_time
        self.modifier_id = modifier_id
        self.name = name
        self.node_id = node_id
        self.permission_role = permission_role
        self.size = size
        self.statistical_info = statistical_info
        self.type = type
        self.url = url
        self.workspace_id = workspace_id

    def validate(self):
        if self.statistical_info:
            self.statistical_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.category is not None:
            result['category'] = self.category
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.extension is not None:
            result['extension'] = self.extension
        if self.has_children is not None:
            result['hasChildren'] = self.has_children
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        if self.modifier_id is not None:
            result['modifierId'] = self.modifier_id
        if self.name is not None:
            result['name'] = self.name
        if self.node_id is not None:
            result['nodeId'] = self.node_id
        if self.permission_role is not None:
            result['permissionRole'] = self.permission_role
        if self.size is not None:
            result['size'] = self.size
        if self.statistical_info is not None:
            result['statisticalInfo'] = self.statistical_info.to_map()
        if self.type is not None:
            result['type'] = self.type
        if self.url is not None:
            result['url'] = self.url
        if self.workspace_id is not None:
            result['workspaceId'] = self.workspace_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('category') is not None:
            self.category = m.get('category')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('extension') is not None:
            self.extension = m.get('extension')
        if m.get('hasChildren') is not None:
            self.has_children = m.get('hasChildren')
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        if m.get('modifierId') is not None:
            self.modifier_id = m.get('modifierId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('nodeId') is not None:
            self.node_id = m.get('nodeId')
        if m.get('permissionRole') is not None:
            self.permission_role = m.get('permissionRole')
        if m.get('size') is not None:
            self.size = m.get('size')
        if m.get('statisticalInfo') is not None:
            temp_model = GetNodeResponseBodyNodeStatisticalInfo()
            self.statistical_info = temp_model.from_map(m['statisticalInfo'])
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('url') is not None:
            self.url = m.get('url')
        if m.get('workspaceId') is not None:
            self.workspace_id = m.get('workspaceId')
        return self


class GetNodeResponseBody(TeaModel):
    def __init__(
        self,
        node: GetNodeResponseBodyNode = None,
    ):
        self.node = node

    def validate(self):
        if self.node:
            self.node.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.node is not None:
            result['node'] = self.node.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('node') is not None:
            temp_model = GetNodeResponseBodyNode()
            self.node = temp_model.from_map(m['node'])
        return self


class GetNodeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetNodeResponseBody = None,
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
            temp_model = GetNodeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetNodeByUrlHeaders(TeaModel):
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


class GetNodeByUrlRequestOption(TeaModel):
    def __init__(
        self,
        with_permission_role: bool = None,
        with_statistical_info: bool = None,
    ):
        self.with_permission_role = with_permission_role
        self.with_statistical_info = with_statistical_info

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.with_permission_role is not None:
            result['withPermissionRole'] = self.with_permission_role
        if self.with_statistical_info is not None:
            result['withStatisticalInfo'] = self.with_statistical_info
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('withPermissionRole') is not None:
            self.with_permission_role = m.get('withPermissionRole')
        if m.get('withStatisticalInfo') is not None:
            self.with_statistical_info = m.get('withStatisticalInfo')
        return self


class GetNodeByUrlRequest(TeaModel):
    def __init__(
        self,
        option: GetNodeByUrlRequestOption = None,
        url: str = None,
        operator_id: str = None,
    ):
        self.option = option
        self.url = url
        self.operator_id = operator_id

    def validate(self):
        if self.option:
            self.option.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.option is not None:
            result['option'] = self.option.to_map()
        if self.url is not None:
            result['url'] = self.url
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('option') is not None:
            temp_model = GetNodeByUrlRequestOption()
            self.option = temp_model.from_map(m['option'])
        if m.get('url') is not None:
            self.url = m.get('url')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class GetNodeByUrlResponseBodyNodeStatisticalInfo(TeaModel):
    def __init__(
        self,
        word_count: int = None,
    ):
        self.word_count = word_count

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.word_count is not None:
            result['wordCount'] = self.word_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('wordCount') is not None:
            self.word_count = m.get('wordCount')
        return self


class GetNodeByUrlResponseBodyNode(TeaModel):
    def __init__(
        self,
        category: str = None,
        create_time: str = None,
        creator_id: str = None,
        extension: str = None,
        has_children: bool = None,
        modified_time: str = None,
        modifier_id: str = None,
        name: str = None,
        node_id: str = None,
        permission_role: str = None,
        size: int = None,
        statistical_info: GetNodeByUrlResponseBodyNodeStatisticalInfo = None,
        type: str = None,
        url: str = None,
        workspace_id: str = None,
    ):
        self.category = category
        self.create_time = create_time
        self.creator_id = creator_id
        self.extension = extension
        self.has_children = has_children
        self.modified_time = modified_time
        self.modifier_id = modifier_id
        self.name = name
        self.node_id = node_id
        self.permission_role = permission_role
        self.size = size
        self.statistical_info = statistical_info
        self.type = type
        self.url = url
        self.workspace_id = workspace_id

    def validate(self):
        if self.statistical_info:
            self.statistical_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.category is not None:
            result['category'] = self.category
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.extension is not None:
            result['extension'] = self.extension
        if self.has_children is not None:
            result['hasChildren'] = self.has_children
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        if self.modifier_id is not None:
            result['modifierId'] = self.modifier_id
        if self.name is not None:
            result['name'] = self.name
        if self.node_id is not None:
            result['nodeId'] = self.node_id
        if self.permission_role is not None:
            result['permissionRole'] = self.permission_role
        if self.size is not None:
            result['size'] = self.size
        if self.statistical_info is not None:
            result['statisticalInfo'] = self.statistical_info.to_map()
        if self.type is not None:
            result['type'] = self.type
        if self.url is not None:
            result['url'] = self.url
        if self.workspace_id is not None:
            result['workspaceId'] = self.workspace_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('category') is not None:
            self.category = m.get('category')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('extension') is not None:
            self.extension = m.get('extension')
        if m.get('hasChildren') is not None:
            self.has_children = m.get('hasChildren')
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        if m.get('modifierId') is not None:
            self.modifier_id = m.get('modifierId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('nodeId') is not None:
            self.node_id = m.get('nodeId')
        if m.get('permissionRole') is not None:
            self.permission_role = m.get('permissionRole')
        if m.get('size') is not None:
            self.size = m.get('size')
        if m.get('statisticalInfo') is not None:
            temp_model = GetNodeByUrlResponseBodyNodeStatisticalInfo()
            self.statistical_info = temp_model.from_map(m['statisticalInfo'])
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('url') is not None:
            self.url = m.get('url')
        if m.get('workspaceId') is not None:
            self.workspace_id = m.get('workspaceId')
        return self


class GetNodeByUrlResponseBody(TeaModel):
    def __init__(
        self,
        node: GetNodeByUrlResponseBodyNode = None,
    ):
        self.node = node

    def validate(self):
        if self.node:
            self.node.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.node is not None:
            result['node'] = self.node.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('node') is not None:
            temp_model = GetNodeByUrlResponseBodyNode()
            self.node = temp_model.from_map(m['node'])
        return self


class GetNodeByUrlResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetNodeByUrlResponseBody = None,
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
            temp_model = GetNodeByUrlResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetNodesHeaders(TeaModel):
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


class GetNodesRequestOption(TeaModel):
    def __init__(
        self,
        with_permission_role: bool = None,
        with_statistical_info: bool = None,
    ):
        self.with_permission_role = with_permission_role
        self.with_statistical_info = with_statistical_info

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.with_permission_role is not None:
            result['withPermissionRole'] = self.with_permission_role
        if self.with_statistical_info is not None:
            result['withStatisticalInfo'] = self.with_statistical_info
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('withPermissionRole') is not None:
            self.with_permission_role = m.get('withPermissionRole')
        if m.get('withStatisticalInfo') is not None:
            self.with_statistical_info = m.get('withStatisticalInfo')
        return self


class GetNodesRequest(TeaModel):
    def __init__(
        self,
        node_ids: List[str] = None,
        option: GetNodesRequestOption = None,
        operator_id: str = None,
    ):
        self.node_ids = node_ids
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
        if self.node_ids is not None:
            result['nodeIds'] = self.node_ids
        if self.option is not None:
            result['option'] = self.option.to_map()
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nodeIds') is not None:
            self.node_ids = m.get('nodeIds')
        if m.get('option') is not None:
            temp_model = GetNodesRequestOption()
            self.option = temp_model.from_map(m['option'])
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class GetNodesResponseBodyNodesStatisticalInfo(TeaModel):
    def __init__(
        self,
        word_count: int = None,
    ):
        self.word_count = word_count

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.word_count is not None:
            result['wordCount'] = self.word_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('wordCount') is not None:
            self.word_count = m.get('wordCount')
        return self


class GetNodesResponseBodyNodes(TeaModel):
    def __init__(
        self,
        category: str = None,
        create_time: str = None,
        creator_id: str = None,
        extension: str = None,
        has_children: bool = None,
        modified_time: str = None,
        modifier_id: str = None,
        name: str = None,
        node_id: str = None,
        permission_role: str = None,
        size: int = None,
        statistical_info: GetNodesResponseBodyNodesStatisticalInfo = None,
        type: str = None,
        url: str = None,
        workspace_id: str = None,
    ):
        self.category = category
        self.create_time = create_time
        self.creator_id = creator_id
        self.extension = extension
        self.has_children = has_children
        self.modified_time = modified_time
        self.modifier_id = modifier_id
        self.name = name
        self.node_id = node_id
        self.permission_role = permission_role
        self.size = size
        self.statistical_info = statistical_info
        self.type = type
        self.url = url
        self.workspace_id = workspace_id

    def validate(self):
        if self.statistical_info:
            self.statistical_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.category is not None:
            result['category'] = self.category
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.extension is not None:
            result['extension'] = self.extension
        if self.has_children is not None:
            result['hasChildren'] = self.has_children
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        if self.modifier_id is not None:
            result['modifierId'] = self.modifier_id
        if self.name is not None:
            result['name'] = self.name
        if self.node_id is not None:
            result['nodeId'] = self.node_id
        if self.permission_role is not None:
            result['permissionRole'] = self.permission_role
        if self.size is not None:
            result['size'] = self.size
        if self.statistical_info is not None:
            result['statisticalInfo'] = self.statistical_info.to_map()
        if self.type is not None:
            result['type'] = self.type
        if self.url is not None:
            result['url'] = self.url
        if self.workspace_id is not None:
            result['workspaceId'] = self.workspace_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('category') is not None:
            self.category = m.get('category')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('extension') is not None:
            self.extension = m.get('extension')
        if m.get('hasChildren') is not None:
            self.has_children = m.get('hasChildren')
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        if m.get('modifierId') is not None:
            self.modifier_id = m.get('modifierId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('nodeId') is not None:
            self.node_id = m.get('nodeId')
        if m.get('permissionRole') is not None:
            self.permission_role = m.get('permissionRole')
        if m.get('size') is not None:
            self.size = m.get('size')
        if m.get('statisticalInfo') is not None:
            temp_model = GetNodesResponseBodyNodesStatisticalInfo()
            self.statistical_info = temp_model.from_map(m['statisticalInfo'])
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('url') is not None:
            self.url = m.get('url')
        if m.get('workspaceId') is not None:
            self.workspace_id = m.get('workspaceId')
        return self


class GetNodesResponseBody(TeaModel):
    def __init__(
        self,
        nodes: List[GetNodesResponseBodyNodes] = None,
    ):
        self.nodes = nodes

    def validate(self):
        if self.nodes:
            for k in self.nodes:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['nodes'] = []
        if self.nodes is not None:
            for k in self.nodes:
                result['nodes'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.nodes = []
        if m.get('nodes') is not None:
            for k in m.get('nodes'):
                temp_model = GetNodesResponseBodyNodes()
                self.nodes.append(temp_model.from_map(k))
        return self


class GetNodesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetNodesResponseBody = None,
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
            temp_model = GetNodesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetTeamHeaders(TeaModel):
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


class GetTeamRequest(TeaModel):
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


class GetTeamResponseBodyTeamIcon(TeaModel):
    def __init__(
        self,
        type: str = None,
        value: str = None,
    ):
        self.type = type
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class GetTeamResponseBodyTeam(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        cover: str = None,
        create_time: str = None,
        creator_id: str = None,
        description: str = None,
        icon: GetTeamResponseBodyTeamIcon = None,
        modified_time: str = None,
        modifier_id: str = None,
        name: str = None,
        team_id: str = None,
    ):
        self.corp_id = corp_id
        self.cover = cover
        self.create_time = create_time
        self.creator_id = creator_id
        self.description = description
        self.icon = icon
        self.modified_time = modified_time
        self.modifier_id = modifier_id
        self.name = name
        self.team_id = team_id

    def validate(self):
        if self.icon:
            self.icon.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.cover is not None:
            result['cover'] = self.cover
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.description is not None:
            result['description'] = self.description
        if self.icon is not None:
            result['icon'] = self.icon.to_map()
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        if self.modifier_id is not None:
            result['modifierId'] = self.modifier_id
        if self.name is not None:
            result['name'] = self.name
        if self.team_id is not None:
            result['teamId'] = self.team_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('cover') is not None:
            self.cover = m.get('cover')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('icon') is not None:
            temp_model = GetTeamResponseBodyTeamIcon()
            self.icon = temp_model.from_map(m['icon'])
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        if m.get('modifierId') is not None:
            self.modifier_id = m.get('modifierId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('teamId') is not None:
            self.team_id = m.get('teamId')
        return self


class GetTeamResponseBody(TeaModel):
    def __init__(
        self,
        team: GetTeamResponseBodyTeam = None,
    ):
        self.team = team

    def validate(self):
        if self.team:
            self.team.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.team is not None:
            result['team'] = self.team.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('team') is not None:
            temp_model = GetTeamResponseBodyTeam()
            self.team = temp_model.from_map(m['team'])
        return self


class GetTeamResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetTeamResponseBody = None,
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
            temp_model = GetTeamResponseBody()
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


class GetWorkspaceRequest(TeaModel):
    def __init__(
        self,
        operator_id: str = None,
        with_permission_role: bool = None,
    ):
        self.operator_id = operator_id
        self.with_permission_role = with_permission_role

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.with_permission_role is not None:
            result['withPermissionRole'] = self.with_permission_role
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('withPermissionRole') is not None:
            self.with_permission_role = m.get('withPermissionRole')
        return self


class GetWorkspaceResponseBodyWorkspaceIcon(TeaModel):
    def __init__(
        self,
        type: str = None,
        value: str = None,
    ):
        self.type = type
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class GetWorkspaceResponseBodyWorkspace(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        cover: str = None,
        create_time: str = None,
        creator_id: str = None,
        description: str = None,
        icon: GetWorkspaceResponseBodyWorkspaceIcon = None,
        modified_time: str = None,
        modifier_id: str = None,
        name: str = None,
        permission_role: str = None,
        root_node_id: str = None,
        team_id: str = None,
        type: str = None,
        url: str = None,
        workspace_id: str = None,
    ):
        self.corp_id = corp_id
        self.cover = cover
        self.create_time = create_time
        self.creator_id = creator_id
        self.description = description
        self.icon = icon
        self.modified_time = modified_time
        self.modifier_id = modifier_id
        self.name = name
        self.permission_role = permission_role
        self.root_node_id = root_node_id
        self.team_id = team_id
        self.type = type
        self.url = url
        self.workspace_id = workspace_id

    def validate(self):
        if self.icon:
            self.icon.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.cover is not None:
            result['cover'] = self.cover
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.description is not None:
            result['description'] = self.description
        if self.icon is not None:
            result['icon'] = self.icon.to_map()
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        if self.modifier_id is not None:
            result['modifierId'] = self.modifier_id
        if self.name is not None:
            result['name'] = self.name
        if self.permission_role is not None:
            result['permissionRole'] = self.permission_role
        if self.root_node_id is not None:
            result['rootNodeId'] = self.root_node_id
        if self.team_id is not None:
            result['teamId'] = self.team_id
        if self.type is not None:
            result['type'] = self.type
        if self.url is not None:
            result['url'] = self.url
        if self.workspace_id is not None:
            result['workspaceId'] = self.workspace_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('cover') is not None:
            self.cover = m.get('cover')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('icon') is not None:
            temp_model = GetWorkspaceResponseBodyWorkspaceIcon()
            self.icon = temp_model.from_map(m['icon'])
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        if m.get('modifierId') is not None:
            self.modifier_id = m.get('modifierId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('permissionRole') is not None:
            self.permission_role = m.get('permissionRole')
        if m.get('rootNodeId') is not None:
            self.root_node_id = m.get('rootNodeId')
        if m.get('teamId') is not None:
            self.team_id = m.get('teamId')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('url') is not None:
            self.url = m.get('url')
        if m.get('workspaceId') is not None:
            self.workspace_id = m.get('workspaceId')
        return self


class GetWorkspaceResponseBody(TeaModel):
    def __init__(
        self,
        workspace: GetWorkspaceResponseBodyWorkspace = None,
    ):
        self.workspace = workspace

    def validate(self):
        if self.workspace:
            self.workspace.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.workspace is not None:
            result['workspace'] = self.workspace.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('workspace') is not None:
            temp_model = GetWorkspaceResponseBodyWorkspace()
            self.workspace = temp_model.from_map(m['workspace'])
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


class GetWorkspacesHeaders(TeaModel):
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


class GetWorkspacesRequestOption(TeaModel):
    def __init__(
        self,
        with_permission_role: bool = None,
    ):
        self.with_permission_role = with_permission_role

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.with_permission_role is not None:
            result['withPermissionRole'] = self.with_permission_role
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('withPermissionRole') is not None:
            self.with_permission_role = m.get('withPermissionRole')
        return self


class GetWorkspacesRequest(TeaModel):
    def __init__(
        self,
        option: GetWorkspacesRequestOption = None,
        workspace_ids: List[str] = None,
        operator_id: str = None,
    ):
        self.option = option
        self.workspace_ids = workspace_ids
        self.operator_id = operator_id

    def validate(self):
        if self.option:
            self.option.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.option is not None:
            result['option'] = self.option.to_map()
        if self.workspace_ids is not None:
            result['workspaceIds'] = self.workspace_ids
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('option') is not None:
            temp_model = GetWorkspacesRequestOption()
            self.option = temp_model.from_map(m['option'])
        if m.get('workspaceIds') is not None:
            self.workspace_ids = m.get('workspaceIds')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class GetWorkspacesResponseBodyWorkspacesIcon(TeaModel):
    def __init__(
        self,
        type: str = None,
        value: str = None,
    ):
        self.type = type
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class GetWorkspacesResponseBodyWorkspaces(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        cover: str = None,
        create_time: str = None,
        creator_id: str = None,
        description: str = None,
        icon: GetWorkspacesResponseBodyWorkspacesIcon = None,
        modified_time: str = None,
        modifier_id: str = None,
        name: str = None,
        permission_role: str = None,
        root_node_id: str = None,
        team_id: str = None,
        type: str = None,
        url: str = None,
        workspace_id: str = None,
    ):
        self.corp_id = corp_id
        self.cover = cover
        self.create_time = create_time
        self.creator_id = creator_id
        self.description = description
        self.icon = icon
        self.modified_time = modified_time
        self.modifier_id = modifier_id
        self.name = name
        self.permission_role = permission_role
        self.root_node_id = root_node_id
        self.team_id = team_id
        self.type = type
        self.url = url
        self.workspace_id = workspace_id

    def validate(self):
        if self.icon:
            self.icon.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.cover is not None:
            result['cover'] = self.cover
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.description is not None:
            result['description'] = self.description
        if self.icon is not None:
            result['icon'] = self.icon.to_map()
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        if self.modifier_id is not None:
            result['modifierId'] = self.modifier_id
        if self.name is not None:
            result['name'] = self.name
        if self.permission_role is not None:
            result['permissionRole'] = self.permission_role
        if self.root_node_id is not None:
            result['rootNodeId'] = self.root_node_id
        if self.team_id is not None:
            result['teamId'] = self.team_id
        if self.type is not None:
            result['type'] = self.type
        if self.url is not None:
            result['url'] = self.url
        if self.workspace_id is not None:
            result['workspaceId'] = self.workspace_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('cover') is not None:
            self.cover = m.get('cover')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('icon') is not None:
            temp_model = GetWorkspacesResponseBodyWorkspacesIcon()
            self.icon = temp_model.from_map(m['icon'])
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        if m.get('modifierId') is not None:
            self.modifier_id = m.get('modifierId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('permissionRole') is not None:
            self.permission_role = m.get('permissionRole')
        if m.get('rootNodeId') is not None:
            self.root_node_id = m.get('rootNodeId')
        if m.get('teamId') is not None:
            self.team_id = m.get('teamId')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('url') is not None:
            self.url = m.get('url')
        if m.get('workspaceId') is not None:
            self.workspace_id = m.get('workspaceId')
        return self


class GetWorkspacesResponseBody(TeaModel):
    def __init__(
        self,
        workspaces: List[GetWorkspacesResponseBodyWorkspaces] = None,
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
                temp_model = GetWorkspacesResponseBodyWorkspaces()
                self.workspaces.append(temp_model.from_map(k))
        return self


class GetWorkspacesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetWorkspacesResponseBody = None,
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
            temp_model = GetWorkspacesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class HandOverWorkspaceHeaders(TeaModel):
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


class HandOverWorkspaceRequest(TeaModel):
    def __init__(
        self,
        source_owner_id: str = None,
        target_owner_id: str = None,
        workspace_id: str = None,
        operator_id: str = None,
    ):
        self.source_owner_id = source_owner_id
        self.target_owner_id = target_owner_id
        self.workspace_id = workspace_id
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.source_owner_id is not None:
            result['sourceOwnerId'] = self.source_owner_id
        if self.target_owner_id is not None:
            result['targetOwnerId'] = self.target_owner_id
        if self.workspace_id is not None:
            result['workspaceId'] = self.workspace_id
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sourceOwnerId') is not None:
            self.source_owner_id = m.get('sourceOwnerId')
        if m.get('targetOwnerId') is not None:
            self.target_owner_id = m.get('targetOwnerId')
        if m.get('workspaceId') is not None:
            self.workspace_id = m.get('workspaceId')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class HandOverWorkspaceResponseBody(TeaModel):
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


class HandOverWorkspaceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: HandOverWorkspaceResponseBody = None,
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
            temp_model = HandOverWorkspaceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListNodesHeaders(TeaModel):
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


class ListNodesRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        operator_id: str = None,
        parent_node_id: str = None,
        with_permission_role: bool = None,
    ):
        self.max_results = max_results
        self.next_token = next_token
        self.operator_id = operator_id
        self.parent_node_id = parent_node_id
        self.with_permission_role = with_permission_role

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
        if self.parent_node_id is not None:
            result['parentNodeId'] = self.parent_node_id
        if self.with_permission_role is not None:
            result['withPermissionRole'] = self.with_permission_role
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('parentNodeId') is not None:
            self.parent_node_id = m.get('parentNodeId')
        if m.get('withPermissionRole') is not None:
            self.with_permission_role = m.get('withPermissionRole')
        return self


class ListNodesResponseBodyNodesStatisticalInfo(TeaModel):
    def __init__(
        self,
        word_count: int = None,
    ):
        self.word_count = word_count

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.word_count is not None:
            result['wordCount'] = self.word_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('wordCount') is not None:
            self.word_count = m.get('wordCount')
        return self


class ListNodesResponseBodyNodes(TeaModel):
    def __init__(
        self,
        category: str = None,
        create_time: str = None,
        creator_id: str = None,
        extension: str = None,
        has_children: bool = None,
        modified_time: str = None,
        modifier_id: str = None,
        name: str = None,
        node_id: str = None,
        permission_role: str = None,
        size: int = None,
        statistical_info: ListNodesResponseBodyNodesStatisticalInfo = None,
        type: str = None,
        url: str = None,
        workspace_id: str = None,
    ):
        self.category = category
        self.create_time = create_time
        self.creator_id = creator_id
        self.extension = extension
        self.has_children = has_children
        self.modified_time = modified_time
        self.modifier_id = modifier_id
        self.name = name
        self.node_id = node_id
        self.permission_role = permission_role
        self.size = size
        self.statistical_info = statistical_info
        self.type = type
        self.url = url
        self.workspace_id = workspace_id

    def validate(self):
        if self.statistical_info:
            self.statistical_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.category is not None:
            result['category'] = self.category
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.extension is not None:
            result['extension'] = self.extension
        if self.has_children is not None:
            result['hasChildren'] = self.has_children
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        if self.modifier_id is not None:
            result['modifierId'] = self.modifier_id
        if self.name is not None:
            result['name'] = self.name
        if self.node_id is not None:
            result['nodeId'] = self.node_id
        if self.permission_role is not None:
            result['permissionRole'] = self.permission_role
        if self.size is not None:
            result['size'] = self.size
        if self.statistical_info is not None:
            result['statisticalInfo'] = self.statistical_info.to_map()
        if self.type is not None:
            result['type'] = self.type
        if self.url is not None:
            result['url'] = self.url
        if self.workspace_id is not None:
            result['workspaceId'] = self.workspace_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('category') is not None:
            self.category = m.get('category')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('extension') is not None:
            self.extension = m.get('extension')
        if m.get('hasChildren') is not None:
            self.has_children = m.get('hasChildren')
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        if m.get('modifierId') is not None:
            self.modifier_id = m.get('modifierId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('nodeId') is not None:
            self.node_id = m.get('nodeId')
        if m.get('permissionRole') is not None:
            self.permission_role = m.get('permissionRole')
        if m.get('size') is not None:
            self.size = m.get('size')
        if m.get('statisticalInfo') is not None:
            temp_model = ListNodesResponseBodyNodesStatisticalInfo()
            self.statistical_info = temp_model.from_map(m['statisticalInfo'])
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('url') is not None:
            self.url = m.get('url')
        if m.get('workspaceId') is not None:
            self.workspace_id = m.get('workspaceId')
        return self


class ListNodesResponseBody(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        nodes: List[ListNodesResponseBodyNodes] = None,
    ):
        self.next_token = next_token
        self.nodes = nodes

    def validate(self):
        if self.nodes:
            for k in self.nodes:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['nodes'] = []
        if self.nodes is not None:
            for k in self.nodes:
                result['nodes'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.nodes = []
        if m.get('nodes') is not None:
            for k in m.get('nodes'):
                temp_model = ListNodesResponseBodyNodes()
                self.nodes.append(temp_model.from_map(k))
        return self


class ListNodesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListNodesResponseBody = None,
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
            temp_model = ListNodesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListTeamsHeaders(TeaModel):
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


class ListTeamsRequest(TeaModel):
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


class ListTeamsResponseBodyTeamsIcon(TeaModel):
    def __init__(
        self,
        type: str = None,
        value: str = None,
    ):
        self.type = type
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class ListTeamsResponseBodyTeams(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        cover: str = None,
        create_time: str = None,
        creator_id: str = None,
        description: str = None,
        icon: ListTeamsResponseBodyTeamsIcon = None,
        modified_time: str = None,
        modifier_id: str = None,
        name: str = None,
        team_id: str = None,
    ):
        self.corp_id = corp_id
        self.cover = cover
        self.create_time = create_time
        self.creator_id = creator_id
        self.description = description
        self.icon = icon
        self.modified_time = modified_time
        self.modifier_id = modifier_id
        self.name = name
        self.team_id = team_id

    def validate(self):
        if self.icon:
            self.icon.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.cover is not None:
            result['cover'] = self.cover
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.description is not None:
            result['description'] = self.description
        if self.icon is not None:
            result['icon'] = self.icon.to_map()
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        if self.modifier_id is not None:
            result['modifierId'] = self.modifier_id
        if self.name is not None:
            result['name'] = self.name
        if self.team_id is not None:
            result['teamId'] = self.team_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('cover') is not None:
            self.cover = m.get('cover')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('icon') is not None:
            temp_model = ListTeamsResponseBodyTeamsIcon()
            self.icon = temp_model.from_map(m['icon'])
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        if m.get('modifierId') is not None:
            self.modifier_id = m.get('modifierId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('teamId') is not None:
            self.team_id = m.get('teamId')
        return self


class ListTeamsResponseBody(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        teams: List[ListTeamsResponseBodyTeams] = None,
    ):
        self.next_token = next_token
        self.teams = teams

    def validate(self):
        if self.teams:
            for k in self.teams:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['teams'] = []
        if self.teams is not None:
            for k in self.teams:
                result['teams'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.teams = []
        if m.get('teams') is not None:
            for k in m.get('teams'):
                temp_model = ListTeamsResponseBodyTeams()
                self.teams.append(temp_model.from_map(k))
        return self


class ListTeamsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListTeamsResponseBody = None,
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
            temp_model = ListTeamsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListWorkspacesHeaders(TeaModel):
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


class ListWorkspacesRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        operator_id: str = None,
        order_by: str = None,
        team_id: str = None,
        with_permission_role: bool = None,
    ):
        self.max_results = max_results
        self.next_token = next_token
        self.operator_id = operator_id
        self.order_by = order_by
        self.team_id = team_id
        self.with_permission_role = with_permission_role

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
        if self.order_by is not None:
            result['orderBy'] = self.order_by
        if self.team_id is not None:
            result['teamId'] = self.team_id
        if self.with_permission_role is not None:
            result['withPermissionRole'] = self.with_permission_role
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('orderBy') is not None:
            self.order_by = m.get('orderBy')
        if m.get('teamId') is not None:
            self.team_id = m.get('teamId')
        if m.get('withPermissionRole') is not None:
            self.with_permission_role = m.get('withPermissionRole')
        return self


class ListWorkspacesResponseBodyWorkspacesIcon(TeaModel):
    def __init__(
        self,
        type: str = None,
        value: str = None,
    ):
        self.type = type
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class ListWorkspacesResponseBodyWorkspaces(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        cover: str = None,
        create_time: str = None,
        creator_id: str = None,
        description: str = None,
        icon: ListWorkspacesResponseBodyWorkspacesIcon = None,
        modified_time: str = None,
        modifier_id: str = None,
        name: str = None,
        permission_role: str = None,
        root_node_id: str = None,
        team_id: str = None,
        type: str = None,
        url: str = None,
        workspace_id: str = None,
    ):
        self.corp_id = corp_id
        self.cover = cover
        self.create_time = create_time
        self.creator_id = creator_id
        self.description = description
        self.icon = icon
        self.modified_time = modified_time
        self.modifier_id = modifier_id
        self.name = name
        self.permission_role = permission_role
        self.root_node_id = root_node_id
        self.team_id = team_id
        self.type = type
        self.url = url
        self.workspace_id = workspace_id

    def validate(self):
        if self.icon:
            self.icon.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.cover is not None:
            result['cover'] = self.cover
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.description is not None:
            result['description'] = self.description
        if self.icon is not None:
            result['icon'] = self.icon.to_map()
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        if self.modifier_id is not None:
            result['modifierId'] = self.modifier_id
        if self.name is not None:
            result['name'] = self.name
        if self.permission_role is not None:
            result['permissionRole'] = self.permission_role
        if self.root_node_id is not None:
            result['rootNodeId'] = self.root_node_id
        if self.team_id is not None:
            result['teamId'] = self.team_id
        if self.type is not None:
            result['type'] = self.type
        if self.url is not None:
            result['url'] = self.url
        if self.workspace_id is not None:
            result['workspaceId'] = self.workspace_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('cover') is not None:
            self.cover = m.get('cover')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('icon') is not None:
            temp_model = ListWorkspacesResponseBodyWorkspacesIcon()
            self.icon = temp_model.from_map(m['icon'])
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        if m.get('modifierId') is not None:
            self.modifier_id = m.get('modifierId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('permissionRole') is not None:
            self.permission_role = m.get('permissionRole')
        if m.get('rootNodeId') is not None:
            self.root_node_id = m.get('rootNodeId')
        if m.get('teamId') is not None:
            self.team_id = m.get('teamId')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('url') is not None:
            self.url = m.get('url')
        if m.get('workspaceId') is not None:
            self.workspace_id = m.get('workspaceId')
        return self


class ListWorkspacesResponseBody(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        workspaces: List[ListWorkspacesResponseBodyWorkspaces] = None,
    ):
        self.next_token = next_token
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
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['workspaces'] = []
        if self.workspaces is not None:
            for k in self.workspaces:
                result['workspaces'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.workspaces = []
        if m.get('workspaces') is not None:
            for k in m.get('workspaces'):
                temp_model = ListWorkspacesResponseBodyWorkspaces()
                self.workspaces.append(temp_model.from_map(k))
        return self


class ListWorkspacesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListWorkspacesResponseBody = None,
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
            temp_model = ListWorkspacesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SetDefaultHandOverUserHeaders(TeaModel):
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


class SetDefaultHandOverUserRequest(TeaModel):
    def __init__(
        self,
        default_handover_user_id: str = None,
        operator_id: str = None,
    ):
        self.default_handover_user_id = default_handover_user_id
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.default_handover_user_id is not None:
            result['defaultHandoverUserId'] = self.default_handover_user_id
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('defaultHandoverUserId') is not None:
            self.default_handover_user_id = m.get('defaultHandoverUserId')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class SetDefaultHandOverUserResponseBody(TeaModel):
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


class SetDefaultHandOverUserResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SetDefaultHandOverUserResponseBody = None,
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
            temp_model = SetDefaultHandOverUserResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


