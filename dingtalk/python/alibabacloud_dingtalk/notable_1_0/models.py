# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List, Any


class ToRoleMemberDTOMapValue(TeaModel):
    def __init__(
        self,
        member_id: str = None,
        member_type: str = None,
        member_id_belong_org_id: int = None,
        avatar: str = None,
        name: str = None,
    ):
        # This parameter is required.
        self.member_id = member_id
        # This parameter is required.
        self.member_type = member_type
        # This parameter is required.
        self.member_id_belong_org_id = member_id_belong_org_id
        self.avatar = avatar
        self.name = name

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
        if self.member_id_belong_org_id is not None:
            result['memberIdBelongOrgId'] = self.member_id_belong_org_id
        if self.avatar is not None:
            result['avatar'] = self.avatar
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('memberId') is not None:
            self.member_id = m.get('memberId')
        if m.get('memberType') is not None:
            self.member_type = m.get('memberType')
        if m.get('memberIdBelongOrgId') is not None:
            self.member_id_belong_org_id = m.get('memberIdBelongOrgId')
        if m.get('avatar') is not None:
            self.avatar = m.get('avatar')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class AddRoleMemberHeaders(TeaModel):
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


class AddRoleMemberRequestRoleMemberList(TeaModel):
    def __init__(
        self,
        member_id: str = None,
        member_id_belong_org_id: int = None,
        member_type: str = None,
        role_id: str = None,
    ):
        self.member_id = member_id
        self.member_id_belong_org_id = member_id_belong_org_id
        self.member_type = member_type
        self.role_id = role_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.member_id is not None:
            result['memberId'] = self.member_id
        if self.member_id_belong_org_id is not None:
            result['memberIdBelongOrgId'] = self.member_id_belong_org_id
        if self.member_type is not None:
            result['memberType'] = self.member_type
        if self.role_id is not None:
            result['roleId'] = self.role_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('memberId') is not None:
            self.member_id = m.get('memberId')
        if m.get('memberIdBelongOrgId') is not None:
            self.member_id_belong_org_id = m.get('memberIdBelongOrgId')
        if m.get('memberType') is not None:
            self.member_type = m.get('memberType')
        if m.get('roleId') is not None:
            self.role_id = m.get('roleId')
        return self


class AddRoleMemberRequest(TeaModel):
    def __init__(
        self,
        role_member_list: List[AddRoleMemberRequestRoleMemberList] = None,
        operator_id: str = None,
    ):
        self.role_member_list = role_member_list
        # This parameter is required.
        self.operator_id = operator_id

    def validate(self):
        if self.role_member_list:
            for k in self.role_member_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['roleMemberList'] = []
        if self.role_member_list is not None:
            for k in self.role_member_list:
                result['roleMemberList'].append(k.to_map() if k else None)
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.role_member_list = []
        if m.get('roleMemberList') is not None:
            for k in m.get('roleMemberList'):
                temp_model = AddRoleMemberRequestRoleMemberList()
                self.role_member_list.append(temp_model.from_map(k))
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class AddRoleMemberResponseBody(TeaModel):
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


class AddRoleMemberResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AddRoleMemberResponseBody = None,
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
            temp_model = AddRoleMemberResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ChangeSwitchHeaders(TeaModel):
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


class ChangeSwitchRequest(TeaModel):
    def __init__(
        self,
        value: bool = None,
        operator_id: str = None,
    ):
        # This parameter is required.
        self.value = value
        # This parameter is required.
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.value is not None:
            result['value'] = self.value
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('value') is not None:
            self.value = m.get('value')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class ChangeSwitchResponseBody(TeaModel):
    def __init__(
        self,
        enabled: bool = None,
    ):
        self.enabled = enabled

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.enabled is not None:
            result['enabled'] = self.enabled
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('enabled') is not None:
            self.enabled = m.get('enabled')
        return self


class ChangeSwitchResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ChangeSwitchResponseBody = None,
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
            temp_model = ChangeSwitchResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateFieldHeaders(TeaModel):
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


class CreateFieldRequest(TeaModel):
    def __init__(
        self,
        name: str = None,
        property: Dict[str, Any] = None,
        type: str = None,
        operator_id: str = None,
    ):
        # This parameter is required.
        self.name = name
        self.property = property
        # This parameter is required.
        self.type = type
        # This parameter is required.
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
        if self.property is not None:
            result['property'] = self.property
        if self.type is not None:
            result['type'] = self.type
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('property') is not None:
            self.property = m.get('property')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class CreateFieldResponseBody(TeaModel):
    def __init__(
        self,
        id: str = None,
        name: str = None,
        property: Dict[str, Any] = None,
        type: str = None,
    ):
        self.id = id
        self.name = name
        self.property = property
        self.type = type

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
        if self.property is not None:
            result['property'] = self.property
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('property') is not None:
            self.property = m.get('property')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class CreateFieldResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateFieldResponseBody = None,
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
            temp_model = CreateFieldResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateRoleHeaders(TeaModel):
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


class CreateRoleRequestSubRoles(TeaModel):
    def __init__(
        self,
        auth_level: int = None,
        biz_type: int = None,
        config: str = None,
        gmt_create: int = None,
        id: str = None,
    ):
        self.auth_level = auth_level
        self.biz_type = biz_type
        self.config = config
        self.gmt_create = gmt_create
        self.id = id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.auth_level is not None:
            result['authLevel'] = self.auth_level
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.config is not None:
            result['config'] = self.config
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.id is not None:
            result['id'] = self.id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('authLevel') is not None:
            self.auth_level = m.get('authLevel')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('config') is not None:
            self.config = m.get('config')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('id') is not None:
            self.id = m.get('id')
        return self


class CreateRoleRequest(TeaModel):
    def __init__(
        self,
        flow_type: str = None,
        id: int = None,
        name: str = None,
        role_type: str = None,
        sub_roles: List[CreateRoleRequestSubRoles] = None,
        operator_id: str = None,
    ):
        self.flow_type = flow_type
        self.id = id
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.role_type = role_type
        # This parameter is required.
        self.sub_roles = sub_roles
        # This parameter is required.
        self.operator_id = operator_id

    def validate(self):
        if self.sub_roles:
            for k in self.sub_roles:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.flow_type is not None:
            result['flowType'] = self.flow_type
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.role_type is not None:
            result['roleType'] = self.role_type
        result['subRoles'] = []
        if self.sub_roles is not None:
            for k in self.sub_roles:
                result['subRoles'].append(k.to_map() if k else None)
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('flowType') is not None:
            self.flow_type = m.get('flowType')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('roleType') is not None:
            self.role_type = m.get('roleType')
        self.sub_roles = []
        if m.get('subRoles') is not None:
            for k in m.get('subRoles'):
                temp_model = CreateRoleRequestSubRoles()
                self.sub_roles.append(temp_model.from_map(k))
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class CreateRoleResponseBodySubRoles(TeaModel):
    def __init__(
        self,
        auth_level: int = None,
        biz_type: int = None,
        config: str = None,
        gmt_create: int = None,
        id: str = None,
    ):
        self.auth_level = auth_level
        self.biz_type = biz_type
        self.config = config
        self.gmt_create = gmt_create
        self.id = id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.auth_level is not None:
            result['authLevel'] = self.auth_level
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.config is not None:
            result['config'] = self.config
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.id is not None:
            result['id'] = self.id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('authLevel') is not None:
            self.auth_level = m.get('authLevel')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('config') is not None:
            self.config = m.get('config')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('id') is not None:
            self.id = m.get('id')
        return self


class CreateRoleResponseBody(TeaModel):
    def __init__(
        self,
        flow_type: str = None,
        id: int = None,
        name: str = None,
        role_type: str = None,
        sub_roles: List[CreateRoleResponseBodySubRoles] = None,
    ):
        self.flow_type = flow_type
        self.id = id
        self.name = name
        self.role_type = role_type
        self.sub_roles = sub_roles

    def validate(self):
        if self.sub_roles:
            for k in self.sub_roles:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.flow_type is not None:
            result['flowType'] = self.flow_type
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.role_type is not None:
            result['roleType'] = self.role_type
        result['subRoles'] = []
        if self.sub_roles is not None:
            for k in self.sub_roles:
                result['subRoles'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('flowType') is not None:
            self.flow_type = m.get('flowType')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('roleType') is not None:
            self.role_type = m.get('roleType')
        self.sub_roles = []
        if m.get('subRoles') is not None:
            for k in m.get('subRoles'):
                temp_model = CreateRoleResponseBodySubRoles()
                self.sub_roles.append(temp_model.from_map(k))
        return self


class CreateRoleResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateRoleResponseBody = None,
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
            temp_model = CreateRoleResponseBody()
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


class CreateSheetRequestFields(TeaModel):
    def __init__(
        self,
        name: str = None,
        property: Dict[str, Any] = None,
        type: str = None,
    ):
        # This parameter is required.
        self.name = name
        self.property = property
        # This parameter is required.
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.property is not None:
            result['property'] = self.property
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('property') is not None:
            self.property = m.get('property')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class CreateSheetRequest(TeaModel):
    def __init__(
        self,
        fields: List[CreateSheetRequestFields] = None,
        name: str = None,
        operator_id: str = None,
    ):
        self.fields = fields
        self.name = name
        # This parameter is required.
        self.operator_id = operator_id

    def validate(self):
        if self.fields:
            for k in self.fields:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['fields'] = []
        if self.fields is not None:
            for k in self.fields:
                result['fields'].append(k.to_map() if k else None)
        if self.name is not None:
            result['name'] = self.name
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.fields = []
        if m.get('fields') is not None:
            for k in m.get('fields'):
                temp_model = CreateSheetRequestFields()
                self.fields.append(temp_model.from_map(k))
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


class DeleteFieldHeaders(TeaModel):
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


class DeleteFieldRequest(TeaModel):
    def __init__(
        self,
        operator_id: str = None,
    ):
        # This parameter is required.
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


class DeleteFieldResponseBody(TeaModel):
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


class DeleteFieldResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteFieldResponseBody = None,
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
            temp_model = DeleteFieldResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteRecordsHeaders(TeaModel):
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


class DeleteRecordsRequest(TeaModel):
    def __init__(
        self,
        record_ids: List[str] = None,
        operator_id: str = None,
    ):
        # This parameter is required.
        self.record_ids = record_ids
        # This parameter is required.
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.record_ids is not None:
            result['recordIds'] = self.record_ids
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('recordIds') is not None:
            self.record_ids = m.get('recordIds')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class DeleteRecordsResponseBody(TeaModel):
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


class DeleteRecordsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteRecordsResponseBody = None,
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
            temp_model = DeleteRecordsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteRoleHeaders(TeaModel):
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


class DeleteRoleRequest(TeaModel):
    def __init__(
        self,
        role_id: int = None,
        operator_id: str = None,
    ):
        # This parameter is required.
        self.role_id = role_id
        # This parameter is required.
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.role_id is not None:
            result['roleId'] = self.role_id
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('roleId') is not None:
            self.role_id = m.get('roleId')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class DeleteRoleResponseBody(TeaModel):
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


class DeleteRoleResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteRoleResponseBody = None,
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
            temp_model = DeleteRoleResponseBody()
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
        # This parameter is required.
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


class EnableWorkflowHeaders(TeaModel):
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


class EnableWorkflowRequest(TeaModel):
    def __init__(
        self,
        operator_id: str = None,
    ):
        # This parameter is required.
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


class EnableWorkflowResponseBody(TeaModel):
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


class EnableWorkflowResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: EnableWorkflowResponseBody = None,
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
            temp_model = EnableWorkflowResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ExecuteImportHeaders(TeaModel):
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


class ExecuteImportRequestAppendConfig(TeaModel):
    def __init__(
        self,
        field_mapping: Dict[str, str] = None,
        header_row: int = None,
        src_sheet_name: str = None,
        table_id: str = None,
    ):
        self.field_mapping = field_mapping
        self.header_row = header_row
        self.src_sheet_name = src_sheet_name
        # This parameter is required.
        self.table_id = table_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_mapping is not None:
            result['fieldMapping'] = self.field_mapping
        if self.header_row is not None:
            result['headerRow'] = self.header_row
        if self.src_sheet_name is not None:
            result['srcSheetName'] = self.src_sheet_name
        if self.table_id is not None:
            result['tableId'] = self.table_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldMapping') is not None:
            self.field_mapping = m.get('fieldMapping')
        if m.get('headerRow') is not None:
            self.header_row = m.get('headerRow')
        if m.get('srcSheetName') is not None:
            self.src_sheet_name = m.get('srcSheetName')
        if m.get('tableId') is not None:
            self.table_id = m.get('tableId')
        return self


class ExecuteImportRequestEncryption(TeaModel):
    def __init__(
        self,
        algorithm: str = None,
        encrypted_aes_key: str = None,
        iv: str = None,
        key_version: str = None,
    ):
        self.algorithm = algorithm
        # This parameter is required.
        self.encrypted_aes_key = encrypted_aes_key
        # This parameter is required.
        self.iv = iv
        # This parameter is required.
        self.key_version = key_version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.algorithm is not None:
            result['algorithm'] = self.algorithm
        if self.encrypted_aes_key is not None:
            result['encryptedAesKey'] = self.encrypted_aes_key
        if self.iv is not None:
            result['iv'] = self.iv
        if self.key_version is not None:
            result['keyVersion'] = self.key_version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('algorithm') is not None:
            self.algorithm = m.get('algorithm')
        if m.get('encryptedAesKey') is not None:
            self.encrypted_aes_key = m.get('encryptedAesKey')
        if m.get('iv') is not None:
            self.iv = m.get('iv')
        if m.get('keyVersion') is not None:
            self.key_version = m.get('keyVersion')
        return self


class ExecuteImportRequest(TeaModel):
    def __init__(
        self,
        append_config: ExecuteImportRequestAppendConfig = None,
        encryption: ExecuteImportRequestEncryption = None,
        import_id: str = None,
        operator_id: str = None,
    ):
        self.append_config = append_config
        self.encryption = encryption
        # This parameter is required.
        self.import_id = import_id
        # This parameter is required.
        self.operator_id = operator_id

    def validate(self):
        if self.append_config:
            self.append_config.validate()
        if self.encryption:
            self.encryption.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.append_config is not None:
            result['appendConfig'] = self.append_config.to_map()
        if self.encryption is not None:
            result['encryption'] = self.encryption.to_map()
        if self.import_id is not None:
            result['importId'] = self.import_id
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appendConfig') is not None:
            temp_model = ExecuteImportRequestAppendConfig()
            self.append_config = temp_model.from_map(m['appendConfig'])
        if m.get('encryption') is not None:
            temp_model = ExecuteImportRequestEncryption()
            self.encryption = temp_model.from_map(m['encryption'])
        if m.get('importId') is not None:
            self.import_id = m.get('importId')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class ExecuteImportResponseBody(TeaModel):
    def __init__(
        self,
        import_id: str = None,
        status: str = None,
    ):
        self.import_id = import_id
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.import_id is not None:
            result['importId'] = self.import_id
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('importId') is not None:
            self.import_id = m.get('importId')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class ExecuteImportResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ExecuteImportResponseBody = None,
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
            temp_model = ExecuteImportResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetAllFieldsHeaders(TeaModel):
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


class GetAllFieldsRequest(TeaModel):
    def __init__(
        self,
        operator_id: str = None,
    ):
        # This parameter is required.
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


class GetAllFieldsResponseBodyValue(TeaModel):
    def __init__(
        self,
        id: str = None,
        name: str = None,
        property: Dict[str, Any] = None,
        type: str = None,
    ):
        self.id = id
        self.name = name
        self.property = property
        self.type = type

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
        if self.property is not None:
            result['property'] = self.property
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('property') is not None:
            self.property = m.get('property')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class GetAllFieldsResponseBody(TeaModel):
    def __init__(
        self,
        value: List[GetAllFieldsResponseBodyValue] = None,
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
                temp_model = GetAllFieldsResponseBodyValue()
                self.value.append(temp_model.from_map(k))
        return self


class GetAllFieldsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetAllFieldsResponseBody = None,
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
            temp_model = GetAllFieldsResponseBody()
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
        # This parameter is required.
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


class GetImportEncryptPublicKeyHeaders(TeaModel):
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


class GetImportEncryptPublicKeyRequest(TeaModel):
    def __init__(
        self,
        key_version: str = None,
        operator_id: str = None,
    ):
        self.key_version = key_version
        # This parameter is required.
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.key_version is not None:
            result['keyVersion'] = self.key_version
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('keyVersion') is not None:
            self.key_version = m.get('keyVersion')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class GetImportEncryptPublicKeyResponseBody(TeaModel):
    def __init__(
        self,
        algorithm: str = None,
        expire_at: int = None,
        key_version: str = None,
        public_key_pem: str = None,
    ):
        self.algorithm = algorithm
        self.expire_at = expire_at
        self.key_version = key_version
        self.public_key_pem = public_key_pem

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.algorithm is not None:
            result['algorithm'] = self.algorithm
        if self.expire_at is not None:
            result['expireAt'] = self.expire_at
        if self.key_version is not None:
            result['keyVersion'] = self.key_version
        if self.public_key_pem is not None:
            result['publicKeyPem'] = self.public_key_pem
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('algorithm') is not None:
            self.algorithm = m.get('algorithm')
        if m.get('expireAt') is not None:
            self.expire_at = m.get('expireAt')
        if m.get('keyVersion') is not None:
            self.key_version = m.get('keyVersion')
        if m.get('publicKeyPem') is not None:
            self.public_key_pem = m.get('publicKeyPem')
        return self


class GetImportEncryptPublicKeyResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetImportEncryptPublicKeyResponseBody = None,
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
            temp_model = GetImportEncryptPublicKeyResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetRecordHeaders(TeaModel):
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


class GetRecordRequest(TeaModel):
    def __init__(
        self,
        operator_id: str = None,
    ):
        # This parameter is required.
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


class GetRecordResponseBodyCreatedBy(TeaModel):
    def __init__(
        self,
        union_id: str = None,
    ):
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetRecordResponseBodyLastModifiedBy(TeaModel):
    def __init__(
        self,
        union_id: str = None,
    ):
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetRecordResponseBody(TeaModel):
    def __init__(
        self,
        created_by: GetRecordResponseBodyCreatedBy = None,
        created_time: int = None,
        fields: Dict[str, Any] = None,
        id: str = None,
        last_modified_by: GetRecordResponseBodyLastModifiedBy = None,
        last_modified_time: int = None,
    ):
        self.created_by = created_by
        self.created_time = created_time
        self.fields = fields
        self.id = id
        self.last_modified_by = last_modified_by
        self.last_modified_time = last_modified_time

    def validate(self):
        if self.created_by:
            self.created_by.validate()
        if self.last_modified_by:
            self.last_modified_by.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.created_by is not None:
            result['createdBy'] = self.created_by.to_map()
        if self.created_time is not None:
            result['createdTime'] = self.created_time
        if self.fields is not None:
            result['fields'] = self.fields
        if self.id is not None:
            result['id'] = self.id
        if self.last_modified_by is not None:
            result['lastModifiedBy'] = self.last_modified_by.to_map()
        if self.last_modified_time is not None:
            result['lastModifiedTime'] = self.last_modified_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createdBy') is not None:
            temp_model = GetRecordResponseBodyCreatedBy()
            self.created_by = temp_model.from_map(m['createdBy'])
        if m.get('createdTime') is not None:
            self.created_time = m.get('createdTime')
        if m.get('fields') is not None:
            self.fields = m.get('fields')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('lastModifiedBy') is not None:
            temp_model = GetRecordResponseBodyLastModifiedBy()
            self.last_modified_by = temp_model.from_map(m['lastModifiedBy'])
        if m.get('lastModifiedTime') is not None:
            self.last_modified_time = m.get('lastModifiedTime')
        return self


class GetRecordResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetRecordResponseBody = None,
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
            temp_model = GetRecordResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetRecordsHeaders(TeaModel):
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


class GetRecordsRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        operator_id: str = None,
    ):
        self.max_results = max_results
        self.next_token = next_token
        # This parameter is required.
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


class GetRecordsResponseBodyRecordsCreatedBy(TeaModel):
    def __init__(
        self,
        union_id: str = None,
    ):
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetRecordsResponseBodyRecordsLastModifiedBy(TeaModel):
    def __init__(
        self,
        union_id: str = None,
    ):
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetRecordsResponseBodyRecords(TeaModel):
    def __init__(
        self,
        created_by: GetRecordsResponseBodyRecordsCreatedBy = None,
        created_time: int = None,
        fields: Dict[str, Any] = None,
        id: str = None,
        last_modified_by: GetRecordsResponseBodyRecordsLastModifiedBy = None,
        last_modified_time: int = None,
    ):
        self.created_by = created_by
        self.created_time = created_time
        self.fields = fields
        self.id = id
        self.last_modified_by = last_modified_by
        self.last_modified_time = last_modified_time

    def validate(self):
        if self.created_by:
            self.created_by.validate()
        if self.last_modified_by:
            self.last_modified_by.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.created_by is not None:
            result['createdBy'] = self.created_by.to_map()
        if self.created_time is not None:
            result['createdTime'] = self.created_time
        if self.fields is not None:
            result['fields'] = self.fields
        if self.id is not None:
            result['id'] = self.id
        if self.last_modified_by is not None:
            result['lastModifiedBy'] = self.last_modified_by.to_map()
        if self.last_modified_time is not None:
            result['lastModifiedTime'] = self.last_modified_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createdBy') is not None:
            temp_model = GetRecordsResponseBodyRecordsCreatedBy()
            self.created_by = temp_model.from_map(m['createdBy'])
        if m.get('createdTime') is not None:
            self.created_time = m.get('createdTime')
        if m.get('fields') is not None:
            self.fields = m.get('fields')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('lastModifiedBy') is not None:
            temp_model = GetRecordsResponseBodyRecordsLastModifiedBy()
            self.last_modified_by = temp_model.from_map(m['lastModifiedBy'])
        if m.get('lastModifiedTime') is not None:
            self.last_modified_time = m.get('lastModifiedTime')
        return self


class GetRecordsResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        next_token: str = None,
        records: List[GetRecordsResponseBodyRecords] = None,
    ):
        self.has_more = has_more
        self.next_token = next_token
        self.records = records

    def validate(self):
        if self.records:
            for k in self.records:
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
        result['records'] = []
        if self.records is not None:
            for k in self.records:
                result['records'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.records = []
        if m.get('records') is not None:
            for k in m.get('records'):
                temp_model = GetRecordsResponseBodyRecords()
                self.records.append(temp_model.from_map(k))
        return self


class GetRecordsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetRecordsResponseBody = None,
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
            temp_model = GetRecordsResponseBody()
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
        # This parameter is required.
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


class GetSwitchHeaders(TeaModel):
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


class GetSwitchRequest(TeaModel):
    def __init__(
        self,
        operator_id: str = None,
    ):
        # This parameter is required.
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


class GetSwitchResponseBody(TeaModel):
    def __init__(
        self,
        enabled: bool = None,
    ):
        self.enabled = enabled

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.enabled is not None:
            result['enabled'] = self.enabled
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('enabled') is not None:
            self.enabled = m.get('enabled')
        return self


class GetSwitchResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetSwitchResponseBody = None,
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
            temp_model = GetSwitchResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetUserDocRolesHeaders(TeaModel):
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


class GetUserDocRolesRequest(TeaModel):
    def __init__(
        self,
        operator_id: str = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.operator_id = operator_id
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetUserDocRolesResponseBodyRolesSubRoles(TeaModel):
    def __init__(
        self,
        auth_level: int = None,
        biz_type: int = None,
        config: str = None,
        gmt_create: int = None,
        id: str = None,
    ):
        self.auth_level = auth_level
        self.biz_type = biz_type
        self.config = config
        self.gmt_create = gmt_create
        self.id = id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.auth_level is not None:
            result['authLevel'] = self.auth_level
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.config is not None:
            result['config'] = self.config
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.id is not None:
            result['id'] = self.id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('authLevel') is not None:
            self.auth_level = m.get('authLevel')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('config') is not None:
            self.config = m.get('config')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('id') is not None:
            self.id = m.get('id')
        return self


class GetUserDocRolesResponseBodyRoles(TeaModel):
    def __init__(
        self,
        flow_type: str = None,
        id: int = None,
        name: str = None,
        role_type: str = None,
        sub_roles: List[GetUserDocRolesResponseBodyRolesSubRoles] = None,
    ):
        self.flow_type = flow_type
        self.id = id
        self.name = name
        self.role_type = role_type
        self.sub_roles = sub_roles

    def validate(self):
        if self.sub_roles:
            for k in self.sub_roles:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.flow_type is not None:
            result['flowType'] = self.flow_type
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.role_type is not None:
            result['roleType'] = self.role_type
        result['subRoles'] = []
        if self.sub_roles is not None:
            for k in self.sub_roles:
                result['subRoles'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('flowType') is not None:
            self.flow_type = m.get('flowType')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('roleType') is not None:
            self.role_type = m.get('roleType')
        self.sub_roles = []
        if m.get('subRoles') is not None:
            for k in m.get('subRoles'):
                temp_model = GetUserDocRolesResponseBodyRolesSubRoles()
                self.sub_roles.append(temp_model.from_map(k))
        return self


class GetUserDocRolesResponseBody(TeaModel):
    def __init__(
        self,
        enabled: bool = None,
        roles: List[GetUserDocRolesResponseBodyRoles] = None,
    ):
        self.enabled = enabled
        self.roles = roles

    def validate(self):
        if self.roles:
            for k in self.roles:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.enabled is not None:
            result['enabled'] = self.enabled
        result['roles'] = []
        if self.roles is not None:
            for k in self.roles:
                result['roles'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('enabled') is not None:
            self.enabled = m.get('enabled')
        self.roles = []
        if m.get('roles') is not None:
            for k in m.get('roles'):
                temp_model = GetUserDocRolesResponseBodyRoles()
                self.roles.append(temp_model.from_map(k))
        return self


class GetUserDocRolesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetUserDocRolesResponseBody = None,
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
            temp_model = GetUserDocRolesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class InsertRecordsHeaders(TeaModel):
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


class InsertRecordsRequestRecords(TeaModel):
    def __init__(
        self,
        fields: Dict[str, Any] = None,
    ):
        # This parameter is required.
        self.fields = fields

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.fields is not None:
            result['fields'] = self.fields
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fields') is not None:
            self.fields = m.get('fields')
        return self


class InsertRecordsRequest(TeaModel):
    def __init__(
        self,
        records: List[InsertRecordsRequestRecords] = None,
        client_token: str = None,
        operator_id: str = None,
    ):
        # This parameter is required.
        self.records = records
        self.client_token = client_token
        # This parameter is required.
        self.operator_id = operator_id

    def validate(self):
        if self.records:
            for k in self.records:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['records'] = []
        if self.records is not None:
            for k in self.records:
                result['records'].append(k.to_map() if k else None)
        if self.client_token is not None:
            result['clientToken'] = self.client_token
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.records = []
        if m.get('records') is not None:
            for k in m.get('records'):
                temp_model = InsertRecordsRequestRecords()
                self.records.append(temp_model.from_map(k))
        if m.get('clientToken') is not None:
            self.client_token = m.get('clientToken')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class InsertRecordsResponseBodyValue(TeaModel):
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


class InsertRecordsResponseBody(TeaModel):
    def __init__(
        self,
        value: List[InsertRecordsResponseBodyValue] = None,
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
                temp_model = InsertRecordsResponseBodyValue()
                self.value.append(temp_model.from_map(k))
        return self


class InsertRecordsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: InsertRecordsResponseBody = None,
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
            temp_model = InsertRecordsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListRecordsHeaders(TeaModel):
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


class ListRecordsRequestFilterConditions(TeaModel):
    def __init__(
        self,
        field: str = None,
        operator: str = None,
        value: List[Any] = None,
    ):
        # This parameter is required.
        self.field = field
        # This parameter is required.
        self.operator = operator
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field is not None:
            result['field'] = self.field
        if self.operator is not None:
            result['operator'] = self.operator
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('field') is not None:
            self.field = m.get('field')
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class ListRecordsRequestFilter(TeaModel):
    def __init__(
        self,
        combination: str = None,
        conditions: List[ListRecordsRequestFilterConditions] = None,
    ):
        self.combination = combination
        # This parameter is required.
        self.conditions = conditions

    def validate(self):
        if self.conditions:
            for k in self.conditions:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.combination is not None:
            result['combination'] = self.combination
        result['conditions'] = []
        if self.conditions is not None:
            for k in self.conditions:
                result['conditions'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('combination') is not None:
            self.combination = m.get('combination')
        self.conditions = []
        if m.get('conditions') is not None:
            for k in m.get('conditions'):
                temp_model = ListRecordsRequestFilterConditions()
                self.conditions.append(temp_model.from_map(k))
        return self


class ListRecordsRequest(TeaModel):
    def __init__(
        self,
        field_id_or_names: List[str] = None,
        filter: ListRecordsRequestFilter = None,
        max_results: int = None,
        next_token: str = None,
        operator_id: str = None,
    ):
        self.field_id_or_names = field_id_or_names
        self.filter = filter
        self.max_results = max_results
        self.next_token = next_token
        # This parameter is required.
        self.operator_id = operator_id

    def validate(self):
        if self.filter:
            self.filter.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_id_or_names is not None:
            result['fieldIdOrNames'] = self.field_id_or_names
        if self.filter is not None:
            result['filter'] = self.filter.to_map()
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldIdOrNames') is not None:
            self.field_id_or_names = m.get('fieldIdOrNames')
        if m.get('filter') is not None:
            temp_model = ListRecordsRequestFilter()
            self.filter = temp_model.from_map(m['filter'])
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class ListRecordsResponseBodyRecordsCreatedBy(TeaModel):
    def __init__(
        self,
        union_id: str = None,
    ):
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class ListRecordsResponseBodyRecordsLastModifiedBy(TeaModel):
    def __init__(
        self,
        union_id: str = None,
    ):
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class ListRecordsResponseBodyRecords(TeaModel):
    def __init__(
        self,
        created_by: ListRecordsResponseBodyRecordsCreatedBy = None,
        created_time: int = None,
        fields: Dict[str, Any] = None,
        id: str = None,
        last_modified_by: ListRecordsResponseBodyRecordsLastModifiedBy = None,
        last_modified_time: int = None,
    ):
        self.created_by = created_by
        self.created_time = created_time
        self.fields = fields
        self.id = id
        self.last_modified_by = last_modified_by
        self.last_modified_time = last_modified_time

    def validate(self):
        if self.created_by:
            self.created_by.validate()
        if self.last_modified_by:
            self.last_modified_by.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.created_by is not None:
            result['createdBy'] = self.created_by.to_map()
        if self.created_time is not None:
            result['createdTime'] = self.created_time
        if self.fields is not None:
            result['fields'] = self.fields
        if self.id is not None:
            result['id'] = self.id
        if self.last_modified_by is not None:
            result['lastModifiedBy'] = self.last_modified_by.to_map()
        if self.last_modified_time is not None:
            result['lastModifiedTime'] = self.last_modified_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createdBy') is not None:
            temp_model = ListRecordsResponseBodyRecordsCreatedBy()
            self.created_by = temp_model.from_map(m['createdBy'])
        if m.get('createdTime') is not None:
            self.created_time = m.get('createdTime')
        if m.get('fields') is not None:
            self.fields = m.get('fields')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('lastModifiedBy') is not None:
            temp_model = ListRecordsResponseBodyRecordsLastModifiedBy()
            self.last_modified_by = temp_model.from_map(m['lastModifiedBy'])
        if m.get('lastModifiedTime') is not None:
            self.last_modified_time = m.get('lastModifiedTime')
        return self


class ListRecordsResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        next_token: str = None,
        records: List[ListRecordsResponseBodyRecords] = None,
    ):
        self.has_more = has_more
        self.next_token = next_token
        self.records = records

    def validate(self):
        if self.records:
            for k in self.records:
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
        result['records'] = []
        if self.records is not None:
            for k in self.records:
                result['records'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.records = []
        if m.get('records') is not None:
            for k in m.get('records'):
                temp_model = ListRecordsResponseBodyRecords()
                self.records.append(temp_model.from_map(k))
        return self


class ListRecordsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListRecordsResponseBody = None,
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
            temp_model = ListRecordsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListWorkflowsHeaders(TeaModel):
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


class ListWorkflowsRequest(TeaModel):
    def __init__(
        self,
        limit: int = None,
        offset: int = None,
        operator_id: str = None,
    ):
        self.limit = limit
        self.offset = offset
        # This parameter is required.
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.limit is not None:
            result['limit'] = self.limit
        if self.offset is not None:
            result['offset'] = self.offset
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('limit') is not None:
            self.limit = m.get('limit')
        if m.get('offset') is not None:
            self.offset = m.get('offset')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class ListWorkflowsResponseBodyWorkflows(TeaModel):
    def __init__(
        self,
        description: str = None,
        flow_id: str = None,
        name: str = None,
        status: str = None,
        version_id: str = None,
    ):
        self.description = description
        self.flow_id = flow_id
        self.name = name
        self.status = status
        self.version_id = version_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.description is not None:
            result['description'] = self.description
        if self.flow_id is not None:
            result['flowId'] = self.flow_id
        if self.name is not None:
            result['name'] = self.name
        if self.status is not None:
            result['status'] = self.status
        if self.version_id is not None:
            result['versionId'] = self.version_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('flowId') is not None:
            self.flow_id = m.get('flowId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('versionId') is not None:
            self.version_id = m.get('versionId')
        return self


class ListWorkflowsResponseBody(TeaModel):
    def __init__(
        self,
        total: int = None,
        workflows: List[ListWorkflowsResponseBodyWorkflows] = None,
    ):
        self.total = total
        self.workflows = workflows

    def validate(self):
        if self.workflows:
            for k in self.workflows:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.total is not None:
            result['total'] = self.total
        result['workflows'] = []
        if self.workflows is not None:
            for k in self.workflows:
                result['workflows'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('total') is not None:
            self.total = m.get('total')
        self.workflows = []
        if m.get('workflows') is not None:
            for k in m.get('workflows'):
                temp_model = ListWorkflowsResponseBodyWorkflows()
                self.workflows.append(temp_model.from_map(k))
        return self


class ListWorkflowsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListWorkflowsResponseBody = None,
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
            temp_model = ListWorkflowsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PrepareImportUploadHeaders(TeaModel):
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


class PrepareImportUploadRequest(TeaModel):
    def __init__(
        self,
        file_extension: str = None,
        file_name: str = None,
        file_size: int = None,
        table_names: List[str] = None,
        operator_id: str = None,
    ):
        # This parameter is required.
        self.file_extension = file_extension
        # This parameter is required.
        self.file_name = file_name
        # This parameter is required.
        self.file_size = file_size
        self.table_names = table_names
        # This parameter is required.
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_extension is not None:
            result['fileExtension'] = self.file_extension
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.file_size is not None:
            result['fileSize'] = self.file_size
        if self.table_names is not None:
            result['tableNames'] = self.table_names
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileExtension') is not None:
            self.file_extension = m.get('fileExtension')
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('fileSize') is not None:
            self.file_size = m.get('fileSize')
        if m.get('tableNames') is not None:
            self.table_names = m.get('tableNames')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class PrepareImportUploadResponseBody(TeaModel):
    def __init__(
        self,
        expire_at: int = None,
        import_id: str = None,
        upload_url: str = None,
    ):
        self.expire_at = expire_at
        self.import_id = import_id
        self.upload_url = upload_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.expire_at is not None:
            result['expireAt'] = self.expire_at
        if self.import_id is not None:
            result['importId'] = self.import_id
        if self.upload_url is not None:
            result['uploadUrl'] = self.upload_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('expireAt') is not None:
            self.expire_at = m.get('expireAt')
        if m.get('importId') is not None:
            self.import_id = m.get('importId')
        if m.get('uploadUrl') is not None:
            self.upload_url = m.get('uploadUrl')
        return self


class PrepareImportUploadResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PrepareImportUploadResponseBody = None,
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
            temp_model = PrepareImportUploadResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PrepareSetRichTextHeaders(TeaModel):
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


class PrepareSetRichTextRequest(TeaModel):
    def __init__(
        self,
        markdown: str = None,
        operator_id: str = None,
    ):
        self.markdown = markdown
        # This parameter is required.
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.markdown is not None:
            result['markdown'] = self.markdown
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('markdown') is not None:
            self.markdown = m.get('markdown')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class PrepareSetRichTextResponseBodyUploadInfos(TeaModel):
    def __init__(
        self,
        resource_id: str = None,
        resource_url: str = None,
        upload_url: str = None,
    ):
        self.resource_id = resource_id
        self.resource_url = resource_url
        self.upload_url = upload_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.resource_id is not None:
            result['resourceId'] = self.resource_id
        if self.resource_url is not None:
            result['resourceUrl'] = self.resource_url
        if self.upload_url is not None:
            result['uploadUrl'] = self.upload_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('resourceId') is not None:
            self.resource_id = m.get('resourceId')
        if m.get('resourceUrl') is not None:
            self.resource_url = m.get('resourceUrl')
        if m.get('uploadUrl') is not None:
            self.upload_url = m.get('uploadUrl')
        return self


class PrepareSetRichTextResponseBody(TeaModel):
    def __init__(
        self,
        markdown: str = None,
        upload_infos: List[PrepareSetRichTextResponseBodyUploadInfos] = None,
    ):
        self.markdown = markdown
        self.upload_infos = upload_infos

    def validate(self):
        if self.upload_infos:
            for k in self.upload_infos:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.markdown is not None:
            result['markdown'] = self.markdown
        result['uploadInfos'] = []
        if self.upload_infos is not None:
            for k in self.upload_infos:
                result['uploadInfos'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('markdown') is not None:
            self.markdown = m.get('markdown')
        self.upload_infos = []
        if m.get('uploadInfos') is not None:
            for k in m.get('uploadInfos'):
                temp_model = PrepareSetRichTextResponseBodyUploadInfos()
                self.upload_infos.append(temp_model.from_map(k))
        return self


class PrepareSetRichTextResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PrepareSetRichTextResponseBody = None,
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
            temp_model = PrepareSetRichTextResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryChangedRecordIdsByClientTokenHeaders(TeaModel):
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


class QueryChangedRecordIdsByClientTokenRequest(TeaModel):
    def __init__(
        self,
        client_token: str = None,
        operator_id: str = None,
    ):
        # This parameter is required.
        self.client_token = client_token
        # This parameter is required.
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.client_token is not None:
            result['clientToken'] = self.client_token
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('clientToken') is not None:
            self.client_token = m.get('clientToken')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class QueryChangedRecordIdsByClientTokenResponseBody(TeaModel):
    def __init__(
        self,
        changed_record_ids: Any = None,
    ):
        self.changed_record_ids = changed_record_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.changed_record_ids is not None:
            result['changedRecordIds'] = self.changed_record_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('changedRecordIds') is not None:
            self.changed_record_ids = m.get('changedRecordIds')
        return self


class QueryChangedRecordIdsByClientTokenResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryChangedRecordIdsByClientTokenResponseBody = None,
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
            temp_model = QueryChangedRecordIdsByClientTokenResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryDocAllRolesHeaders(TeaModel):
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


class QueryDocAllRolesRequest(TeaModel):
    def __init__(
        self,
        operator_id: str = None,
    ):
        # This parameter is required.
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


class QueryDocAllRolesResponseBodyAllRolesMembers(TeaModel):
    def __init__(
        self,
        avatar: str = None,
        member_id: str = None,
        member_id_belong_org_id: int = None,
        member_type: str = None,
        name: str = None,
    ):
        self.avatar = avatar
        self.member_id = member_id
        self.member_id_belong_org_id = member_id_belong_org_id
        self.member_type = member_type
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.avatar is not None:
            result['avatar'] = self.avatar
        if self.member_id is not None:
            result['memberId'] = self.member_id
        if self.member_id_belong_org_id is not None:
            result['memberIdBelongOrgId'] = self.member_id_belong_org_id
        if self.member_type is not None:
            result['memberType'] = self.member_type
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('avatar') is not None:
            self.avatar = m.get('avatar')
        if m.get('memberId') is not None:
            self.member_id = m.get('memberId')
        if m.get('memberIdBelongOrgId') is not None:
            self.member_id_belong_org_id = m.get('memberIdBelongOrgId')
        if m.get('memberType') is not None:
            self.member_type = m.get('memberType')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class QueryDocAllRolesResponseBodyAllRolesRoleSubRoles(TeaModel):
    def __init__(
        self,
        auth_level: int = None,
        biz_type: int = None,
        config: str = None,
        gmt_create: int = None,
        id: str = None,
    ):
        self.auth_level = auth_level
        self.biz_type = biz_type
        self.config = config
        self.gmt_create = gmt_create
        self.id = id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.auth_level is not None:
            result['authLevel'] = self.auth_level
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.config is not None:
            result['config'] = self.config
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.id is not None:
            result['id'] = self.id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('authLevel') is not None:
            self.auth_level = m.get('authLevel')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('config') is not None:
            self.config = m.get('config')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('id') is not None:
            self.id = m.get('id')
        return self


class QueryDocAllRolesResponseBodyAllRolesRole(TeaModel):
    def __init__(
        self,
        flow_type: str = None,
        id: int = None,
        name: str = None,
        role_type: str = None,
        sub_roles: List[QueryDocAllRolesResponseBodyAllRolesRoleSubRoles] = None,
    ):
        self.flow_type = flow_type
        self.id = id
        self.name = name
        self.role_type = role_type
        self.sub_roles = sub_roles

    def validate(self):
        if self.sub_roles:
            for k in self.sub_roles:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.flow_type is not None:
            result['flowType'] = self.flow_type
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.role_type is not None:
            result['roleType'] = self.role_type
        result['subRoles'] = []
        if self.sub_roles is not None:
            for k in self.sub_roles:
                result['subRoles'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('flowType') is not None:
            self.flow_type = m.get('flowType')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('roleType') is not None:
            self.role_type = m.get('roleType')
        self.sub_roles = []
        if m.get('subRoles') is not None:
            for k in m.get('subRoles'):
                temp_model = QueryDocAllRolesResponseBodyAllRolesRoleSubRoles()
                self.sub_roles.append(temp_model.from_map(k))
        return self


class QueryDocAllRolesResponseBodyAllRoles(TeaModel):
    def __init__(
        self,
        members: List[QueryDocAllRolesResponseBodyAllRolesMembers] = None,
        role: QueryDocAllRolesResponseBodyAllRolesRole = None,
    ):
        self.members = members
        self.role = role

    def validate(self):
        if self.members:
            for k in self.members:
                if k:
                    k.validate()
        if self.role:
            self.role.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['members'] = []
        if self.members is not None:
            for k in self.members:
                result['members'].append(k.to_map() if k else None)
        if self.role is not None:
            result['role'] = self.role.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.members = []
        if m.get('members') is not None:
            for k in m.get('members'):
                temp_model = QueryDocAllRolesResponseBodyAllRolesMembers()
                self.members.append(temp_model.from_map(k))
        if m.get('role') is not None:
            temp_model = QueryDocAllRolesResponseBodyAllRolesRole()
            self.role = temp_model.from_map(m['role'])
        return self


class QueryDocAllRolesResponseBodyDefaultRole(TeaModel):
    def __init__(
        self,
        mode: int = None,
        role_id: int = None,
    ):
        self.mode = mode
        self.role_id = role_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.mode is not None:
            result['mode'] = self.mode
        if self.role_id is not None:
            result['roleId'] = self.role_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('mode') is not None:
            self.mode = m.get('mode')
        if m.get('roleId') is not None:
            self.role_id = m.get('roleId')
        return self


class QueryDocAllRolesResponseBody(TeaModel):
    def __init__(
        self,
        all_roles: List[QueryDocAllRolesResponseBodyAllRoles] = None,
        default_role: QueryDocAllRolesResponseBodyDefaultRole = None,
        enabled: bool = None,
        system_roles: List[int] = None,
    ):
        self.all_roles = all_roles
        self.default_role = default_role
        self.enabled = enabled
        self.system_roles = system_roles

    def validate(self):
        if self.all_roles:
            for k in self.all_roles:
                if k:
                    k.validate()
        if self.default_role:
            self.default_role.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['allRoles'] = []
        if self.all_roles is not None:
            for k in self.all_roles:
                result['allRoles'].append(k.to_map() if k else None)
        if self.default_role is not None:
            result['defaultRole'] = self.default_role.to_map()
        if self.enabled is not None:
            result['enabled'] = self.enabled
        if self.system_roles is not None:
            result['systemRoles'] = self.system_roles
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.all_roles = []
        if m.get('allRoles') is not None:
            for k in m.get('allRoles'):
                temp_model = QueryDocAllRolesResponseBodyAllRoles()
                self.all_roles.append(temp_model.from_map(k))
        if m.get('defaultRole') is not None:
            temp_model = QueryDocAllRolesResponseBodyDefaultRole()
            self.default_role = temp_model.from_map(m['defaultRole'])
        if m.get('enabled') is not None:
            self.enabled = m.get('enabled')
        if m.get('systemRoles') is not None:
            self.system_roles = m.get('systemRoles')
        return self


class QueryDocAllRolesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryDocAllRolesResponseBody = None,
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
            temp_model = QueryDocAllRolesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryImportStatusHeaders(TeaModel):
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


class QueryImportStatusRequest(TeaModel):
    def __init__(
        self,
        import_id: str = None,
        operator_id: str = None,
    ):
        # This parameter is required.
        self.import_id = import_id
        # This parameter is required.
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.import_id is not None:
            result['importId'] = self.import_id
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('importId') is not None:
            self.import_id = m.get('importId')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class QueryImportStatusResponseBody(TeaModel):
    def __init__(
        self,
        count: int = None,
        error_code: str = None,
        error_message: str = None,
        import_id: str = None,
        phase: str = None,
        status: str = None,
        table_ids: List[str] = None,
    ):
        self.count = count
        self.error_code = error_code
        self.error_message = error_message
        self.import_id = import_id
        self.phase = phase
        self.status = status
        self.table_ids = table_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.count is not None:
            result['count'] = self.count
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.error_message is not None:
            result['errorMessage'] = self.error_message
        if self.import_id is not None:
            result['importId'] = self.import_id
        if self.phase is not None:
            result['phase'] = self.phase
        if self.status is not None:
            result['status'] = self.status
        if self.table_ids is not None:
            result['tableIds'] = self.table_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('count') is not None:
            self.count = m.get('count')
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('errorMessage') is not None:
            self.error_message = m.get('errorMessage')
        if m.get('importId') is not None:
            self.import_id = m.get('importId')
        if m.get('phase') is not None:
            self.phase = m.get('phase')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('tableIds') is not None:
            self.table_ids = m.get('tableIds')
        return self


class QueryImportStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryImportStatusResponseBody = None,
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
            temp_model = QueryImportStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RebuildRoleMembersHeaders(TeaModel):
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


class RebuildRoleMembersRequestDefaultRoleDTO(TeaModel):
    def __init__(
        self,
        mode: int = None,
        role_id: int = None,
    ):
        self.mode = mode
        self.role_id = role_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.mode is not None:
            result['mode'] = self.mode
        if self.role_id is not None:
            result['roleId'] = self.role_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('mode') is not None:
            self.mode = m.get('mode')
        if m.get('roleId') is not None:
            self.role_id = m.get('roleId')
        return self


class RebuildRoleMembersRequest(TeaModel):
    def __init__(
        self,
        default_role_dto: RebuildRoleMembersRequestDefaultRoleDTO = None,
        to_role_member_dtomap: Dict[str, List[ToRoleMemberDTOMapValue]] = None,
        operator_id: str = None,
    ):
        # This parameter is required.
        self.default_role_dto = default_role_dto
        # This parameter is required.
        self.to_role_member_dtomap = to_role_member_dtomap
        # This parameter is required.
        self.operator_id = operator_id

    def validate(self):
        if self.default_role_dto:
            self.default_role_dto.validate()
        if self.to_role_member_dtomap:
            for v in self.to_role_member_dtomap.values():
                for k1 in v:
                    if k1:
                        k1.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.default_role_dto is not None:
            result['defaultRoleDTO'] = self.default_role_dto.to_map()
        result['toRoleMemberDTOMap'] = {}
        if self.to_role_member_dtomap is not None:
            for k, v in self.to_role_member_dtomap.items():
                l1 = []
                for k1 in v:
                    l1.append(k1.to_map() if k1 else None)
                result['toRoleMemberDTOMap'][k] = l1
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('defaultRoleDTO') is not None:
            temp_model = RebuildRoleMembersRequestDefaultRoleDTO()
            self.default_role_dto = temp_model.from_map(m['defaultRoleDTO'])
        self.to_role_member_dtomap = {}
        if m.get('toRoleMemberDTOMap') is not None:
            for k, v in m.get('toRoleMemberDTOMap').items():
                l1 = []
                for k1 in v:
                    temp_model = ToRoleMemberDTOMapValue()
                    l1.append(temp_model.from_map(k1))
                self.to_role_member_dtomap['k'] = l1
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class RebuildRoleMembersResponseBody(TeaModel):
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


class RebuildRoleMembersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RebuildRoleMembersResponseBody = None,
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
            temp_model = RebuildRoleMembersResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class TruncateSheetRecordsHeaders(TeaModel):
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


class TruncateSheetRecordsRequest(TeaModel):
    def __init__(
        self,
        operator_id: str = None,
    ):
        # This parameter is required.
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


class TruncateSheetRecordsResponseBody(TeaModel):
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


class TruncateSheetRecordsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: TruncateSheetRecordsResponseBody = None,
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
            temp_model = TruncateSheetRecordsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateFieldHeaders(TeaModel):
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


class UpdateFieldRequest(TeaModel):
    def __init__(
        self,
        name: str = None,
        property: Dict[str, Any] = None,
        operator_id: str = None,
    ):
        # This parameter is required.
        self.name = name
        self.property = property
        # This parameter is required.
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
        if self.property is not None:
            result['property'] = self.property
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('property') is not None:
            self.property = m.get('property')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class UpdateFieldResponseBody(TeaModel):
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


class UpdateFieldResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateFieldResponseBody = None,
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
            temp_model = UpdateFieldResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateRecordsHeaders(TeaModel):
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


class UpdateRecordsRequestRecords(TeaModel):
    def __init__(
        self,
        fields: Dict[str, Any] = None,
        id: str = None,
    ):
        # This parameter is required.
        self.fields = fields
        # This parameter is required.
        self.id = id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.fields is not None:
            result['fields'] = self.fields
        if self.id is not None:
            result['id'] = self.id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fields') is not None:
            self.fields = m.get('fields')
        if m.get('id') is not None:
            self.id = m.get('id')
        return self


class UpdateRecordsRequest(TeaModel):
    def __init__(
        self,
        records: List[UpdateRecordsRequestRecords] = None,
        operator_id: str = None,
    ):
        # This parameter is required.
        self.records = records
        # This parameter is required.
        self.operator_id = operator_id

    def validate(self):
        if self.records:
            for k in self.records:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['records'] = []
        if self.records is not None:
            for k in self.records:
                result['records'].append(k.to_map() if k else None)
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.records = []
        if m.get('records') is not None:
            for k in m.get('records'):
                temp_model = UpdateRecordsRequestRecords()
                self.records.append(temp_model.from_map(k))
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class UpdateRecordsResponseBodyValue(TeaModel):
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


class UpdateRecordsResponseBody(TeaModel):
    def __init__(
        self,
        value: List[UpdateRecordsResponseBodyValue] = None,
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
                temp_model = UpdateRecordsResponseBodyValue()
                self.value.append(temp_model.from_map(k))
        return self


class UpdateRecordsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateRecordsResponseBody = None,
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
            temp_model = UpdateRecordsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateRoleHeaders(TeaModel):
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


class UpdateRoleRequestSubRoles(TeaModel):
    def __init__(
        self,
        auth_level: int = None,
        biz_type: int = None,
        config: str = None,
        gmt_create: int = None,
        id: str = None,
    ):
        self.auth_level = auth_level
        self.biz_type = biz_type
        self.config = config
        self.gmt_create = gmt_create
        self.id = id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.auth_level is not None:
            result['authLevel'] = self.auth_level
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.config is not None:
            result['config'] = self.config
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.id is not None:
            result['id'] = self.id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('authLevel') is not None:
            self.auth_level = m.get('authLevel')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('config') is not None:
            self.config = m.get('config')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('id') is not None:
            self.id = m.get('id')
        return self


class UpdateRoleRequest(TeaModel):
    def __init__(
        self,
        flow_type: str = None,
        id: int = None,
        name: str = None,
        role_type: str = None,
        sub_roles: List[UpdateRoleRequestSubRoles] = None,
        operator_id: str = None,
    ):
        self.flow_type = flow_type
        # This parameter is required.
        self.id = id
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.role_type = role_type
        # This parameter is required.
        self.sub_roles = sub_roles
        # This parameter is required.
        self.operator_id = operator_id

    def validate(self):
        if self.sub_roles:
            for k in self.sub_roles:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.flow_type is not None:
            result['flowType'] = self.flow_type
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.role_type is not None:
            result['roleType'] = self.role_type
        result['subRoles'] = []
        if self.sub_roles is not None:
            for k in self.sub_roles:
                result['subRoles'].append(k.to_map() if k else None)
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('flowType') is not None:
            self.flow_type = m.get('flowType')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('roleType') is not None:
            self.role_type = m.get('roleType')
        self.sub_roles = []
        if m.get('subRoles') is not None:
            for k in m.get('subRoles'):
                temp_model = UpdateRoleRequestSubRoles()
                self.sub_roles.append(temp_model.from_map(k))
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class UpdateRoleResponseBodySubRoles(TeaModel):
    def __init__(
        self,
        auth_level: int = None,
        biz_type: int = None,
        config: str = None,
        gmt_create: int = None,
        id: str = None,
    ):
        self.auth_level = auth_level
        self.biz_type = biz_type
        self.config = config
        self.gmt_create = gmt_create
        self.id = id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.auth_level is not None:
            result['authLevel'] = self.auth_level
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.config is not None:
            result['config'] = self.config
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.id is not None:
            result['id'] = self.id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('authLevel') is not None:
            self.auth_level = m.get('authLevel')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('config') is not None:
            self.config = m.get('config')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('id') is not None:
            self.id = m.get('id')
        return self


class UpdateRoleResponseBody(TeaModel):
    def __init__(
        self,
        flow_type: str = None,
        id: int = None,
        name: str = None,
        role_type: str = None,
        sub_roles: List[UpdateRoleResponseBodySubRoles] = None,
    ):
        self.flow_type = flow_type
        self.id = id
        self.name = name
        self.role_type = role_type
        self.sub_roles = sub_roles

    def validate(self):
        if self.sub_roles:
            for k in self.sub_roles:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.flow_type is not None:
            result['flowType'] = self.flow_type
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.role_type is not None:
            result['roleType'] = self.role_type
        result['subRoles'] = []
        if self.sub_roles is not None:
            for k in self.sub_roles:
                result['subRoles'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('flowType') is not None:
            self.flow_type = m.get('flowType')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('roleType') is not None:
            self.role_type = m.get('roleType')
        self.sub_roles = []
        if m.get('subRoles') is not None:
            for k in m.get('subRoles'):
                temp_model = UpdateRoleResponseBodySubRoles()
                self.sub_roles.append(temp_model.from_map(k))
        return self


class UpdateRoleResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateRoleResponseBody = None,
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
            temp_model = UpdateRoleResponseBody()
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
        operator_id: str = None,
    ):
        # This parameter is required.
        self.name = name
        # This parameter is required.
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


class UpdateSheetResponseBody(TeaModel):
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


class UpdateSheetResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateSheetResponseBody = None,
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
            temp_model = UpdateSheetResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


