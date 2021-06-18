# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class CreateInnerAppHeaders(TeaModel):
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


class CreateInnerAppRequest(TeaModel):
    def __init__(
        self,
        op_union_id: str = None,
        ecological_corp_id: str = None,
        name: str = None,
        desc: str = None,
        icon: str = None,
        homepage_link: str = None,
        pc_homepage_link: str = None,
        omp_link: str = None,
        ip_white_list: List[str] = None,
        scope_type: str = None,
    ):
        # 创建人unionId
        self.op_union_id = op_union_id
        # 关联组织corpId
        self.ecological_corp_id = ecological_corp_id
        # 应用名称
        self.name = name
        # 应用描述
        self.desc = desc
        # 应用图标
        self.icon = icon
        # 应用首页地址
        self.homepage_link = homepage_link
        # 应用PC端地址
        self.pc_homepage_link = pc_homepage_link
        # 应用管理后台地址
        self.omp_link = omp_link
        # 服务器出口ip白名单
        self.ip_white_list = ip_white_list
        # 权限类型
        self.scope_type = scope_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.op_union_id is not None:
            result['opUnionId'] = self.op_union_id
        if self.ecological_corp_id is not None:
            result['ecologicalCorpId'] = self.ecological_corp_id
        if self.name is not None:
            result['name'] = self.name
        if self.desc is not None:
            result['desc'] = self.desc
        if self.icon is not None:
            result['icon'] = self.icon
        if self.homepage_link is not None:
            result['homepageLink'] = self.homepage_link
        if self.pc_homepage_link is not None:
            result['pcHomepageLink'] = self.pc_homepage_link
        if self.omp_link is not None:
            result['ompLink'] = self.omp_link
        if self.ip_white_list is not None:
            result['ipWhiteList'] = self.ip_white_list
        if self.scope_type is not None:
            result['scopeType'] = self.scope_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('opUnionId') is not None:
            self.op_union_id = m.get('opUnionId')
        if m.get('ecologicalCorpId') is not None:
            self.ecological_corp_id = m.get('ecologicalCorpId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('desc') is not None:
            self.desc = m.get('desc')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('homepageLink') is not None:
            self.homepage_link = m.get('homepageLink')
        if m.get('pcHomepageLink') is not None:
            self.pc_homepage_link = m.get('pcHomepageLink')
        if m.get('ompLink') is not None:
            self.omp_link = m.get('ompLink')
        if m.get('ipWhiteList') is not None:
            self.ip_white_list = m.get('ipWhiteList')
        if m.get('scopeType') is not None:
            self.scope_type = m.get('scopeType')
        return self


class CreateInnerAppResponseBody(TeaModel):
    def __init__(
        self,
        agent_id: int = None,
        app_key: str = None,
        app_secret: str = None,
    ):
        # 应用id
        self.agent_id = agent_id
        self.app_key = app_key
        self.app_secret = app_secret

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        if self.app_key is not None:
            result['appKey'] = self.app_key
        if self.app_secret is not None:
            result['appSecret'] = self.app_secret
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        if m.get('appKey') is not None:
            self.app_key = m.get('appKey')
        if m.get('appSecret') is not None:
            self.app_secret = m.get('appSecret')
        return self


class CreateInnerAppResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateInnerAppResponseBody = None,
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
            temp_model = CreateInnerAppResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetInnerAppHeaders(TeaModel):
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


class GetInnerAppRequest(TeaModel):
    def __init__(
        self,
        op_union_id: str = None,
        ecological_corp_id: str = None,
    ):
        # 操作人unionId
        self.op_union_id = op_union_id
        # 关联组织corpId
        self.ecological_corp_id = ecological_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.op_union_id is not None:
            result['opUnionId'] = self.op_union_id
        if self.ecological_corp_id is not None:
            result['ecologicalCorpId'] = self.ecological_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('opUnionId') is not None:
            self.op_union_id = m.get('opUnionId')
        if m.get('ecologicalCorpId') is not None:
            self.ecological_corp_id = m.get('ecologicalCorpId')
        return self


class GetInnerAppResponseBody(TeaModel):
    def __init__(
        self,
        agent_id: int = None,
        name: str = None,
        desc: str = None,
        icon: str = None,
        homepage_link: str = None,
        pc_homepage_link: str = None,
        omp_link: str = None,
        app_key: str = None,
        app_secret: str = None,
        ip_white_list: List[str] = None,
    ):
        # 应用id
        self.agent_id = agent_id
        # 应用名称
        self.name = name
        # 应用描述
        self.desc = desc
        # 应用图标
        self.icon = icon
        # 应用移动端首页地址
        self.homepage_link = homepage_link
        # 应用PC端首页地址
        self.pc_homepage_link = pc_homepage_link
        # 应用管理后台地址
        self.omp_link = omp_link
        # 应用的appkey
        self.app_key = app_key
        # 应用的secret
        self.app_secret = app_secret
        # 服务器出口ip
        self.ip_white_list = ip_white_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        if self.name is not None:
            result['name'] = self.name
        if self.desc is not None:
            result['desc'] = self.desc
        if self.icon is not None:
            result['icon'] = self.icon
        if self.homepage_link is not None:
            result['homepageLink'] = self.homepage_link
        if self.pc_homepage_link is not None:
            result['pcHomepageLink'] = self.pc_homepage_link
        if self.omp_link is not None:
            result['ompLink'] = self.omp_link
        if self.app_key is not None:
            result['appKey'] = self.app_key
        if self.app_secret is not None:
            result['appSecret'] = self.app_secret
        if self.ip_white_list is not None:
            result['ipWhiteList'] = self.ip_white_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('desc') is not None:
            self.desc = m.get('desc')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('homepageLink') is not None:
            self.homepage_link = m.get('homepageLink')
        if m.get('pcHomepageLink') is not None:
            self.pc_homepage_link = m.get('pcHomepageLink')
        if m.get('ompLink') is not None:
            self.omp_link = m.get('ompLink')
        if m.get('appKey') is not None:
            self.app_key = m.get('appKey')
        if m.get('appSecret') is not None:
            self.app_secret = m.get('appSecret')
        if m.get('ipWhiteList') is not None:
            self.ip_white_list = m.get('ipWhiteList')
        return self


class GetInnerAppResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetInnerAppResponseBody = None,
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
            temp_model = GetInnerAppResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RegisterCustomAppRoleHeaders(TeaModel):
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


class RegisterCustomAppRoleRequest(TeaModel):
    def __init__(
        self,
        op_user_id: str = None,
        role_name: str = None,
        can_manage_role: bool = None,
    ):
        # 执行用户userId
        self.op_user_id = op_user_id
        # 角色名称
        self.role_name = role_name
        # 是否拥有管理角色的权限，可不传，默认false
        self.can_manage_role = can_manage_role

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.role_name is not None:
            result['roleName'] = self.role_name
        if self.can_manage_role is not None:
            result['canManageRole'] = self.can_manage_role
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('roleName') is not None:
            self.role_name = m.get('roleName')
        if m.get('canManageRole') is not None:
            self.can_manage_role = m.get('canManageRole')
        return self


class RegisterCustomAppRoleResponseBody(TeaModel):
    def __init__(
        self,
        role_id: int = None,
        scope_version: int = None,
    ):
        # 角色id
        self.role_id = role_id
        # 角色版本号
        self.scope_version = scope_version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.role_id is not None:
            result['roleId'] = self.role_id
        if self.scope_version is not None:
            result['scopeVersion'] = self.scope_version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('roleId') is not None:
            self.role_id = m.get('roleId')
        if m.get('scopeVersion') is not None:
            self.scope_version = m.get('scopeVersion')
        return self


class RegisterCustomAppRoleResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: RegisterCustomAppRoleResponseBody = None,
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
            temp_model = RegisterCustomAppRoleResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateApaasAppHeaders(TeaModel):
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


class UpdateApaasAppRequest(TeaModel):
    def __init__(
        self,
        app_name: str = None,
        app_icon: str = None,
        app_status: int = None,
        op_user_id: str = None,
        biz_app_id: str = None,
    ):
        self.app_name = app_name
        self.app_icon = app_icon
        self.app_status = app_status
        self.op_user_id = op_user_id
        self.biz_app_id = biz_app_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_name is not None:
            result['appName'] = self.app_name
        if self.app_icon is not None:
            result['appIcon'] = self.app_icon
        if self.app_status is not None:
            result['appStatus'] = self.app_status
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.biz_app_id is not None:
            result['bizAppId'] = self.biz_app_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appName') is not None:
            self.app_name = m.get('appName')
        if m.get('appIcon') is not None:
            self.app_icon = m.get('appIcon')
        if m.get('appStatus') is not None:
            self.app_status = m.get('appStatus')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('bizAppId') is not None:
            self.biz_app_id = m.get('bizAppId')
        return self


class UpdateApaasAppResponseBody(TeaModel):
    def __init__(
        self,
        agent_id: int = None,
        biz_app_id: str = None,
    ):
        # 钉钉侧应用id
        self.agent_id = agent_id
        # ISV侧应用id
        self.biz_app_id = biz_app_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        if self.biz_app_id is not None:
            result['bizAppId'] = self.biz_app_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        if m.get('bizAppId') is not None:
            self.biz_app_id = m.get('bizAppId')
        return self


class UpdateApaasAppResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateApaasAppResponseBody = None,
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
            temp_model = UpdateApaasAppResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AddAppRolesToMemberHeaders(TeaModel):
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


class AddAppRolesToMemberRequestRoleList(TeaModel):
    def __init__(
        self,
        role_id: int = None,
        scope_version: int = None,
    ):
        # 角色ID
        self.role_id = role_id
        # 角色范围版本号
        self.scope_version = scope_version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.role_id is not None:
            result['roleId'] = self.role_id
        if self.scope_version is not None:
            result['scopeVersion'] = self.scope_version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('roleId') is not None:
            self.role_id = m.get('roleId')
        if m.get('scopeVersion') is not None:
            self.scope_version = m.get('scopeVersion')
        return self


class AddAppRolesToMemberRequest(TeaModel):
    def __init__(
        self,
        op_user_id: str = None,
        member_id: str = None,
        member_type: str = None,
        role_list: List[AddAppRolesToMemberRequestRoleList] = None,
    ):
        # 执行用户userId
        self.op_user_id = op_user_id
        # 人员id
        self.member_id = member_id
        # 人员类型，“DEPT”表示部门，“USER”表示员工
        self.member_type = member_type
        # 角色Id列表
        self.role_list = role_list

    def validate(self):
        if self.role_list:
            for k in self.role_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.member_id is not None:
            result['memberId'] = self.member_id
        if self.member_type is not None:
            result['memberType'] = self.member_type
        result['roleList'] = []
        if self.role_list is not None:
            for k in self.role_list:
                result['roleList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('memberId') is not None:
            self.member_id = m.get('memberId')
        if m.get('memberType') is not None:
            self.member_type = m.get('memberType')
        self.role_list = []
        if m.get('roleList') is not None:
            for k in m.get('roleList'):
                temp_model = AddAppRolesToMemberRequestRoleList()
                self.role_list.append(temp_model.from_map(k))
        return self


class AddAppRolesToMemberResponseBodyResult(TeaModel):
    def __init__(
        self,
        role_id: int = None,
        latest_scope_version: int = None,
        success: bool = None,
        sub_error_code: str = None,
        sub_error_msg: str = None,
    ):
        # 角色id
        self.role_id = role_id
        # 角色范围最新版本号
        self.latest_scope_version = latest_scope_version
        # 角色添加结果，true: 成功，false: 失败
        self.success = success
        self.sub_error_code = sub_error_code
        self.sub_error_msg = sub_error_msg

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.role_id is not None:
            result['roleId'] = self.role_id
        if self.latest_scope_version is not None:
            result['latestScopeVersion'] = self.latest_scope_version
        if self.success is not None:
            result['success'] = self.success
        if self.sub_error_code is not None:
            result['subErrorCode'] = self.sub_error_code
        if self.sub_error_msg is not None:
            result['subErrorMsg'] = self.sub_error_msg
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('roleId') is not None:
            self.role_id = m.get('roleId')
        if m.get('latestScopeVersion') is not None:
            self.latest_scope_version = m.get('latestScopeVersion')
        if m.get('success') is not None:
            self.success = m.get('success')
        if m.get('subErrorCode') is not None:
            self.sub_error_code = m.get('subErrorCode')
        if m.get('subErrorMsg') is not None:
            self.sub_error_msg = m.get('subErrorMsg')
        return self


class AddAppRolesToMemberResponseBody(TeaModel):
    def __init__(
        self,
        result: List[AddAppRolesToMemberResponseBodyResult] = None,
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
                temp_model = AddAppRolesToMemberResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class AddAppRolesToMemberResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: AddAppRolesToMemberResponseBody = None,
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
            temp_model = AddAppRolesToMemberResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetAppRoleScopeByRoleIdHeaders(TeaModel):
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


class GetAppRoleScopeByRoleIdResponseBody(TeaModel):
    def __init__(
        self,
        role_name: str = None,
        role_id: int = None,
        scope_type: str = None,
        dept_id_list: List[int] = None,
        user_id_list: List[str] = None,
        scope_version: str = None,
        can_manage_role: bool = None,
    ):
        # 角色名称
        self.role_name = role_name
        # 角色id
        self.role_id = role_id
        # 角色范围类型，“ALL_VISIBLE”表示全员，“PART_VISIBLE”表示部分
        self.scope_type = scope_type
        # 部门id列表
        self.dept_id_list = dept_id_list
        # 员工userId列表
        self.user_id_list = user_id_list
        # 角色范围版本号
        self.scope_version = scope_version
        # 是否拥有角色管理权限，默认false
        self.can_manage_role = can_manage_role

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.role_name is not None:
            result['roleName'] = self.role_name
        if self.role_id is not None:
            result['roleId'] = self.role_id
        if self.scope_type is not None:
            result['scopeType'] = self.scope_type
        if self.dept_id_list is not None:
            result['deptIdList'] = self.dept_id_list
        if self.user_id_list is not None:
            result['userIdList'] = self.user_id_list
        if self.scope_version is not None:
            result['scopeVersion'] = self.scope_version
        if self.can_manage_role is not None:
            result['canManageRole'] = self.can_manage_role
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('roleName') is not None:
            self.role_name = m.get('roleName')
        if m.get('roleId') is not None:
            self.role_id = m.get('roleId')
        if m.get('scopeType') is not None:
            self.scope_type = m.get('scopeType')
        if m.get('deptIdList') is not None:
            self.dept_id_list = m.get('deptIdList')
        if m.get('userIdList') is not None:
            self.user_id_list = m.get('userIdList')
        if m.get('scopeVersion') is not None:
            self.scope_version = m.get('scopeVersion')
        if m.get('canManageRole') is not None:
            self.can_manage_role = m.get('canManageRole')
        return self


class GetAppRoleScopeByRoleIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetAppRoleScopeByRoleIdResponseBody = None,
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
            temp_model = GetAppRoleScopeByRoleIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListRoleInfoByUserHeaders(TeaModel):
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


class ListRoleInfoByUserResponseBodyResult(TeaModel):
    def __init__(
        self,
        role_name: str = None,
        role_id: int = None,
        can_manage_role: bool = None,
    ):
        # 角色名称
        self.role_name = role_name
        # 角色id
        self.role_id = role_id
        # 是否拥有角色管理权限，默认false
        self.can_manage_role = can_manage_role

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.role_name is not None:
            result['roleName'] = self.role_name
        if self.role_id is not None:
            result['roleId'] = self.role_id
        if self.can_manage_role is not None:
            result['canManageRole'] = self.can_manage_role
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('roleName') is not None:
            self.role_name = m.get('roleName')
        if m.get('roleId') is not None:
            self.role_id = m.get('roleId')
        if m.get('canManageRole') is not None:
            self.can_manage_role = m.get('canManageRole')
        return self


class ListRoleInfoByUserResponseBody(TeaModel):
    def __init__(
        self,
        result: List[ListRoleInfoByUserResponseBodyResult] = None,
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
                temp_model = ListRoleInfoByUserResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class ListRoleInfoByUserResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListRoleInfoByUserResponseBody = None,
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
            temp_model = ListRoleInfoByUserResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListInnerAppHeaders(TeaModel):
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


class ListInnerAppRequest(TeaModel):
    def __init__(
        self,
        ecological_corp_id: str = None,
    ):
        # 合作空间corpId
        self.ecological_corp_id = ecological_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ecological_corp_id is not None:
            result['ecologicalCorpId'] = self.ecological_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('ecologicalCorpId') is not None:
            self.ecological_corp_id = m.get('ecologicalCorpId')
        return self


class ListInnerAppResponseBodyAppList(TeaModel):
    def __init__(
        self,
        agent_id: int = None,
        name: str = None,
        desc: str = None,
        icon: str = None,
        homepage_link: str = None,
        pc_homepage_link: str = None,
        omp_link: str = None,
    ):
        # 应用id
        self.agent_id = agent_id
        # 应用名称
        self.name = name
        # 应用描述
        self.desc = desc
        # 应用图标
        self.icon = icon
        # 应用移动端首页地址
        self.homepage_link = homepage_link
        # 应用PC端首页地址
        self.pc_homepage_link = pc_homepage_link
        # 应用管理后台地址
        self.omp_link = omp_link

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        if self.name is not None:
            result['name'] = self.name
        if self.desc is not None:
            result['desc'] = self.desc
        if self.icon is not None:
            result['icon'] = self.icon
        if self.homepage_link is not None:
            result['homepageLink'] = self.homepage_link
        if self.pc_homepage_link is not None:
            result['pcHomepageLink'] = self.pc_homepage_link
        if self.omp_link is not None:
            result['ompLink'] = self.omp_link
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('desc') is not None:
            self.desc = m.get('desc')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('homepageLink') is not None:
            self.homepage_link = m.get('homepageLink')
        if m.get('pcHomepageLink') is not None:
            self.pc_homepage_link = m.get('pcHomepageLink')
        if m.get('ompLink') is not None:
            self.omp_link = m.get('ompLink')
        return self


class ListInnerAppResponseBody(TeaModel):
    def __init__(
        self,
        app_list: List[ListInnerAppResponseBodyAppList] = None,
    ):
        # 应用列表
        self.app_list = app_list

    def validate(self):
        if self.app_list:
            for k in self.app_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['appList'] = []
        if self.app_list is not None:
            for k in self.app_list:
                result['appList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.app_list = []
        if m.get('appList') is not None:
            for k in m.get('appList'):
                temp_model = ListInnerAppResponseBodyAppList()
                self.app_list.append(temp_model.from_map(k))
        return self


class ListInnerAppResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListInnerAppResponseBody = None,
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
            temp_model = ListInnerAppResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RemoveMemberForAppRoleHeaders(TeaModel):
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


class RemoveMemberForAppRoleRequest(TeaModel):
    def __init__(
        self,
        op_user_id: str = None,
        scope_version: int = None,
        dept_id_list: List[int] = None,
        user_id_list: List[str] = None,
    ):
        # 执行用户userId
        self.op_user_id = op_user_id
        # 角色范围版本号
        self.scope_version = scope_version
        # 部门id列表
        self.dept_id_list = dept_id_list
        # 员工userId列表
        self.user_id_list = user_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.scope_version is not None:
            result['scopeVersion'] = self.scope_version
        if self.dept_id_list is not None:
            result['deptIdList'] = self.dept_id_list
        if self.user_id_list is not None:
            result['userIdList'] = self.user_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('scopeVersion') is not None:
            self.scope_version = m.get('scopeVersion')
        if m.get('deptIdList') is not None:
            self.dept_id_list = m.get('deptIdList')
        if m.get('userIdList') is not None:
            self.user_id_list = m.get('userIdList')
        return self


class RemoveMemberForAppRoleResponseBody(TeaModel):
    def __init__(
        self,
        latest_scope_version: int = None,
    ):
        # 角色最新版本号
        self.latest_scope_version = latest_scope_version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.latest_scope_version is not None:
            result['latestScopeVersion'] = self.latest_scope_version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('latestScopeVersion') is not None:
            self.latest_scope_version = m.get('latestScopeVersion')
        return self


class RemoveMemberForAppRoleResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: RemoveMemberForAppRoleResponseBody = None,
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
            temp_model = RemoveMemberForAppRoleResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateInnerAppHeaders(TeaModel):
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


class UpdateInnerAppRequest(TeaModel):
    def __init__(
        self,
        op_union_id: str = None,
        ecological_corp_id: str = None,
        name: str = None,
        desc: str = None,
        icon: str = None,
        homepage_link: str = None,
        pc_homepage_link: str = None,
        omp_link: str = None,
        ip_white_list: List[str] = None,
    ):
        # 创建人unionId
        self.op_union_id = op_union_id
        # 关联组织corpId
        self.ecological_corp_id = ecological_corp_id
        # 应用名称
        self.name = name
        # 应用描述
        self.desc = desc
        # 应用图标
        self.icon = icon
        # 应用首页地址
        self.homepage_link = homepage_link
        # 应用PC端地址
        self.pc_homepage_link = pc_homepage_link
        # 应用管理后台地址
        self.omp_link = omp_link
        # 服务器出口ip白名单
        self.ip_white_list = ip_white_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.op_union_id is not None:
            result['opUnionId'] = self.op_union_id
        if self.ecological_corp_id is not None:
            result['ecologicalCorpId'] = self.ecological_corp_id
        if self.name is not None:
            result['name'] = self.name
        if self.desc is not None:
            result['desc'] = self.desc
        if self.icon is not None:
            result['icon'] = self.icon
        if self.homepage_link is not None:
            result['homepageLink'] = self.homepage_link
        if self.pc_homepage_link is not None:
            result['pcHomepageLink'] = self.pc_homepage_link
        if self.omp_link is not None:
            result['ompLink'] = self.omp_link
        if self.ip_white_list is not None:
            result['ipWhiteList'] = self.ip_white_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('opUnionId') is not None:
            self.op_union_id = m.get('opUnionId')
        if m.get('ecologicalCorpId') is not None:
            self.ecological_corp_id = m.get('ecologicalCorpId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('desc') is not None:
            self.desc = m.get('desc')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('homepageLink') is not None:
            self.homepage_link = m.get('homepageLink')
        if m.get('pcHomepageLink') is not None:
            self.pc_homepage_link = m.get('pcHomepageLink')
        if m.get('ompLink') is not None:
            self.omp_link = m.get('ompLink')
        if m.get('ipWhiteList') is not None:
            self.ip_white_list = m.get('ipWhiteList')
        return self


class UpdateInnerAppResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        # 更新结果
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class UpdateInnerAppResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateInnerAppResponseBody = None,
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
            temp_model = UpdateInnerAppResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AddMemberToAppRoleHeaders(TeaModel):
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


class AddMemberToAppRoleRequest(TeaModel):
    def __init__(
        self,
        op_user_id: str = None,
        scope_version: int = None,
        dept_id_list: List[int] = None,
        user_id_list: List[str] = None,
    ):
        # 执行用户userId
        self.op_user_id = op_user_id
        # 角色范围版本号
        self.scope_version = scope_version
        # 部门id列表
        self.dept_id_list = dept_id_list
        # 员工userId列表
        self.user_id_list = user_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.scope_version is not None:
            result['scopeVersion'] = self.scope_version
        if self.dept_id_list is not None:
            result['deptIdList'] = self.dept_id_list
        if self.user_id_list is not None:
            result['userIdList'] = self.user_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('scopeVersion') is not None:
            self.scope_version = m.get('scopeVersion')
        if m.get('deptIdList') is not None:
            self.dept_id_list = m.get('deptIdList')
        if m.get('userIdList') is not None:
            self.user_id_list = m.get('userIdList')
        return self


class AddMemberToAppRoleResponseBody(TeaModel):
    def __init__(
        self,
        latest_scope_version: int = None,
    ):
        # 角色范围最新版本号
        self.latest_scope_version = latest_scope_version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.latest_scope_version is not None:
            result['latestScopeVersion'] = self.latest_scope_version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('latestScopeVersion') is not None:
            self.latest_scope_version = m.get('latestScopeVersion')
        return self


class AddMemberToAppRoleResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: AddMemberToAppRoleResponseBody = None,
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
            temp_model = AddMemberToAppRoleResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListAppRoleScopesHeaders(TeaModel):
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


class ListAppRoleScopesRequest(TeaModel):
    def __init__(
        self,
        next_token: int = None,
        size: int = None,
    ):
        # 起始点，默认0
        self.next_token = next_token
        # 数据量，默认20，最大50
        self.size = size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.size is not None:
            result['size'] = self.size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('size') is not None:
            self.size = m.get('size')
        return self


class ListAppRoleScopesResponseBodyDataList(TeaModel):
    def __init__(
        self,
        role_name: str = None,
        role_id: int = None,
        scope_type: str = None,
        dept_id_list: List[int] = None,
        user_id_list: List[str] = None,
        scope_version: int = None,
        can_manage_role: bool = None,
    ):
        # 角色名称
        self.role_name = role_name
        # 角色Id
        self.role_id = role_id
        # 角色范围类型，“ALL_VISIBLE”表示全员，“PART_VISIBLE”表示部分
        self.scope_type = scope_type
        # 部门id列表
        self.dept_id_list = dept_id_list
        # 员工userId列表
        self.user_id_list = user_id_list
        # 角色范围最新版本号
        self.scope_version = scope_version
        # 是否拥有角色管理权限，默认false
        self.can_manage_role = can_manage_role

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.role_name is not None:
            result['roleName'] = self.role_name
        if self.role_id is not None:
            result['roleId'] = self.role_id
        if self.scope_type is not None:
            result['scopeType'] = self.scope_type
        if self.dept_id_list is not None:
            result['deptIdList'] = self.dept_id_list
        if self.user_id_list is not None:
            result['userIdList'] = self.user_id_list
        if self.scope_version is not None:
            result['scopeVersion'] = self.scope_version
        if self.can_manage_role is not None:
            result['canManageRole'] = self.can_manage_role
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('roleName') is not None:
            self.role_name = m.get('roleName')
        if m.get('roleId') is not None:
            self.role_id = m.get('roleId')
        if m.get('scopeType') is not None:
            self.scope_type = m.get('scopeType')
        if m.get('deptIdList') is not None:
            self.dept_id_list = m.get('deptIdList')
        if m.get('userIdList') is not None:
            self.user_id_list = m.get('userIdList')
        if m.get('scopeVersion') is not None:
            self.scope_version = m.get('scopeVersion')
        if m.get('canManageRole') is not None:
            self.can_manage_role = m.get('canManageRole')
        return self


class ListAppRoleScopesResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        next_token: int = None,
        data_list: List[ListAppRoleScopesResponseBodyDataList] = None,
    ):
        # 是否还有数据，true: 还有；false: 已经全部拉取完成
        self.has_more = has_more
        # 下一次请求的起始点
        self.next_token = next_token
        # 数据列表
        self.data_list = data_list

    def validate(self):
        if self.data_list:
            for k in self.data_list:
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
        result['dataList'] = []
        if self.data_list is not None:
            for k in self.data_list:
                result['dataList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.data_list = []
        if m.get('dataList') is not None:
            for k in m.get('dataList'):
                temp_model = ListAppRoleScopesResponseBodyDataList()
                self.data_list.append(temp_model.from_map(k))
        return self


class ListAppRoleScopesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListAppRoleScopesResponseBody = None,
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
            temp_model = ListAppRoleScopesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AddAppToWorkBenchGroupHeaders(TeaModel):
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


class AddAppToWorkBenchGroupRequest(TeaModel):
    def __init__(
        self,
        op_union_id: str = None,
        ecological_corp_id: str = None,
        component_id: str = None,
    ):
        # 创建人unionId
        self.op_union_id = op_union_id
        # 关联组织corpId
        self.ecological_corp_id = ecological_corp_id
        # 工作台分组id
        self.component_id = component_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.op_union_id is not None:
            result['opUnionId'] = self.op_union_id
        if self.ecological_corp_id is not None:
            result['ecologicalCorpId'] = self.ecological_corp_id
        if self.component_id is not None:
            result['componentId'] = self.component_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('opUnionId') is not None:
            self.op_union_id = m.get('opUnionId')
        if m.get('ecologicalCorpId') is not None:
            self.ecological_corp_id = m.get('ecologicalCorpId')
        if m.get('componentId') is not None:
            self.component_id = m.get('componentId')
        return self


class AddAppToWorkBenchGroupResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        # 更新结果
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class AddAppToWorkBenchGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: AddAppToWorkBenchGroupResponseBody = None,
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
            temp_model = AddAppToWorkBenchGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RebuildRoleScopeForAppRoleHeaders(TeaModel):
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


class RebuildRoleScopeForAppRoleRequest(TeaModel):
    def __init__(
        self,
        op_user_id: str = None,
        scope_version: int = None,
        scope_type: str = None,
        dept_id_list: List[int] = None,
        user_id_list: List[str] = None,
    ):
        # 执行用户userId
        self.op_user_id = op_user_id
        # 角色范围最新版本号
        self.scope_version = scope_version
        # 角色范围类型，“ALL_VISIBLE”表示全员，“PART_VISIBLE”表示部分
        self.scope_type = scope_type
        # 部门id列表
        self.dept_id_list = dept_id_list
        # 员工userId列表
        self.user_id_list = user_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.scope_version is not None:
            result['scopeVersion'] = self.scope_version
        if self.scope_type is not None:
            result['scopeType'] = self.scope_type
        if self.dept_id_list is not None:
            result['deptIdList'] = self.dept_id_list
        if self.user_id_list is not None:
            result['userIdList'] = self.user_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('scopeVersion') is not None:
            self.scope_version = m.get('scopeVersion')
        if m.get('scopeType') is not None:
            self.scope_type = m.get('scopeType')
        if m.get('deptIdList') is not None:
            self.dept_id_list = m.get('deptIdList')
        if m.get('userIdList') is not None:
            self.user_id_list = m.get('userIdList')
        return self


class RebuildRoleScopeForAppRoleResponseBody(TeaModel):
    def __init__(
        self,
        latest_scope_version: int = None,
    ):
        # 角色范围最新版本号
        self.latest_scope_version = latest_scope_version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.latest_scope_version is not None:
            result['latestScopeVersion'] = self.latest_scope_version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('latestScopeVersion') is not None:
            self.latest_scope_version = m.get('latestScopeVersion')
        return self


class RebuildRoleScopeForAppRoleResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: RebuildRoleScopeForAppRoleResponseBody = None,
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
            temp_model = RebuildRoleScopeForAppRoleResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RemoveApaasAppHeaders(TeaModel):
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


class RemoveApaasAppRequest(TeaModel):
    def __init__(
        self,
        op_user_id: str = None,
        biz_app_id: str = None,
    ):
        self.op_user_id = op_user_id
        self.biz_app_id = biz_app_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.biz_app_id is not None:
            result['bizAppId'] = self.biz_app_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('bizAppId') is not None:
            self.biz_app_id = m.get('bizAppId')
        return self


class RemoveApaasAppResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        # 结果
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class RemoveApaasAppResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: RemoveApaasAppResponseBody = None,
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
            temp_model = RemoveApaasAppResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteAppRoleHeaders(TeaModel):
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


class DeleteAppRoleRequest(TeaModel):
    def __init__(
        self,
        op_user_id: str = None,
    ):
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class DeleteAppRoleResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        # 删除结果
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class DeleteAppRoleResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DeleteAppRoleResponseBody = None,
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
            temp_model = DeleteAppRoleResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateApaasAppHeaders(TeaModel):
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


class CreateApaasAppRequest(TeaModel):
    def __init__(
        self,
        app_name: str = None,
        app_desc: str = None,
        app_icon: str = None,
        homepage_link: str = None,
        pc_homepage_link: str = None,
        omp_link: str = None,
        homepage_edit_link: str = None,
        pc_homepage_edit_link: str = None,
        op_user_id: str = None,
        biz_app_id: str = None,
        template_key: str = None,
    ):
        self.app_name = app_name
        self.app_desc = app_desc
        self.app_icon = app_icon
        self.homepage_link = homepage_link
        self.pc_homepage_link = pc_homepage_link
        self.omp_link = omp_link
        self.homepage_edit_link = homepage_edit_link
        self.pc_homepage_edit_link = pc_homepage_edit_link
        self.op_user_id = op_user_id
        self.biz_app_id = biz_app_id
        self.template_key = template_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_name is not None:
            result['appName'] = self.app_name
        if self.app_desc is not None:
            result['appDesc'] = self.app_desc
        if self.app_icon is not None:
            result['appIcon'] = self.app_icon
        if self.homepage_link is not None:
            result['homepageLink'] = self.homepage_link
        if self.pc_homepage_link is not None:
            result['pcHomepageLink'] = self.pc_homepage_link
        if self.omp_link is not None:
            result['ompLink'] = self.omp_link
        if self.homepage_edit_link is not None:
            result['homepageEditLink'] = self.homepage_edit_link
        if self.pc_homepage_edit_link is not None:
            result['pcHomepageEditLink'] = self.pc_homepage_edit_link
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.biz_app_id is not None:
            result['bizAppId'] = self.biz_app_id
        if self.template_key is not None:
            result['templateKey'] = self.template_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appName') is not None:
            self.app_name = m.get('appName')
        if m.get('appDesc') is not None:
            self.app_desc = m.get('appDesc')
        if m.get('appIcon') is not None:
            self.app_icon = m.get('appIcon')
        if m.get('homepageLink') is not None:
            self.homepage_link = m.get('homepageLink')
        if m.get('pcHomepageLink') is not None:
            self.pc_homepage_link = m.get('pcHomepageLink')
        if m.get('ompLink') is not None:
            self.omp_link = m.get('ompLink')
        if m.get('homepageEditLink') is not None:
            self.homepage_edit_link = m.get('homepageEditLink')
        if m.get('pcHomepageEditLink') is not None:
            self.pc_homepage_edit_link = m.get('pcHomepageEditLink')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('bizAppId') is not None:
            self.biz_app_id = m.get('bizAppId')
        if m.get('templateKey') is not None:
            self.template_key = m.get('templateKey')
        return self


class CreateApaasAppResponseBody(TeaModel):
    def __init__(
        self,
        agent_id: int = None,
        biz_app_id: str = None,
    ):
        # 钉钉侧应用id
        self.agent_id = agent_id
        # ISV侧应用id
        self.biz_app_id = biz_app_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        if self.biz_app_id is not None:
            result['bizAppId'] = self.biz_app_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        if m.get('bizAppId') is not None:
            self.biz_app_id = m.get('bizAppId')
        return self


class CreateApaasAppResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateApaasAppResponseBody = None,
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
            temp_model = CreateApaasAppResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteInnerAppHeaders(TeaModel):
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


class DeleteInnerAppRequest(TeaModel):
    def __init__(
        self,
        op_union_id: str = None,
        ecological_corp_id: str = None,
    ):
        # 操作人unionId
        self.op_union_id = op_union_id
        # 合作空间corpId
        self.ecological_corp_id = ecological_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.op_union_id is not None:
            result['opUnionId'] = self.op_union_id
        if self.ecological_corp_id is not None:
            result['ecologicalCorpId'] = self.ecological_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('opUnionId') is not None:
            self.op_union_id = m.get('opUnionId')
        if m.get('ecologicalCorpId') is not None:
            self.ecological_corp_id = m.get('ecologicalCorpId')
        return self


class DeleteInnerAppResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        # 删除结果
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class DeleteInnerAppResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DeleteInnerAppResponseBody = None,
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
            temp_model = DeleteInnerAppResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateAppRoleInfoHeaders(TeaModel):
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


class UpdateAppRoleInfoRequest(TeaModel):
    def __init__(
        self,
        op_user_id: str = None,
        new_role_name: str = None,
        can_manage_role: bool = None,
    ):
        # 执行用户userId
        self.op_user_id = op_user_id
        # 变更角色名称，可不传，不传则不变
        self.new_role_name = new_role_name
        # 变更角色管理权限，可不传，不传则不变
        self.can_manage_role = can_manage_role

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.new_role_name is not None:
            result['newRoleName'] = self.new_role_name
        if self.can_manage_role is not None:
            result['canManageRole'] = self.can_manage_role
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('newRoleName') is not None:
            self.new_role_name = m.get('newRoleName')
        if m.get('canManageRole') is not None:
            self.can_manage_role = m.get('canManageRole')
        return self


class UpdateAppRoleInfoResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        # 更新结果
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class UpdateAppRoleInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateAppRoleInfoResponseBody = None,
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
            temp_model = UpdateAppRoleInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


