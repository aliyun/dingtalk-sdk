# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict


class GetUserHeaders(TeaModel):
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


class GetUserResponseBody(TeaModel):
    def __init__(
        self,
        nick: str = None,
        avatar_url: str = None,
        mobile: str = None,
        open_id: str = None,
        union_id: str = None,
        email: str = None,
    ):
        # 昵称
        self.nick = nick
        # 头像url
        self.avatar_url = avatar_url
        # 手机号
        self.mobile = mobile
        # openId
        self.open_id = open_id
        # unionId
        self.union_id = union_id
        # 个人邮箱
        self.email = email

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.nick is not None:
            result['nick'] = self.nick
        if self.avatar_url is not None:
            result['avatarUrl'] = self.avatar_url
        if self.mobile is not None:
            result['mobile'] = self.mobile
        if self.open_id is not None:
            result['openId'] = self.open_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.email is not None:
            result['email'] = self.email
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nick') is not None:
            self.nick = m.get('nick')
        if m.get('avatarUrl') is not None:
            self.avatar_url = m.get('avatarUrl')
        if m.get('mobile') is not None:
            self.mobile = m.get('mobile')
        if m.get('openId') is not None:
            self.open_id = m.get('openId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('email') is not None:
            self.email = m.get('email')
        return self


class GetUserResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetUserResponseBody = None,
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
            temp_model = GetUserResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetApplyInviteInfoHeaders(TeaModel):
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


class GetApplyInviteInfoRequest(TeaModel):
    def __init__(
        self,
        inviter_user_id: str = None,
        dept_id: int = None,
    ):
        # 邀请者userId
        self.inviter_user_id = inviter_user_id
        # 获取部门邀请链接的部门ID
        self.dept_id = dept_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.inviter_user_id is not None:
            result['inviterUserId'] = self.inviter_user_id
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('inviterUserId') is not None:
            self.inviter_user_id = m.get('inviterUserId')
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        return self


class GetApplyInviteInfoResponseBody(TeaModel):
    def __init__(
        self,
        invite_switch: bool = None,
        search_name_invite: bool = None,
        org_apply_code_invite: bool = None,
        link_invite: bool = None,
        invite_url: str = None,
        audit_type: int = None,
        emp_apply_join_dept: bool = None,
    ):
        # 是否开启邀请
        self.invite_switch = invite_switch
        # 是否开启通过企业名称搜索申请
        self.search_name_invite = search_name_invite
        # 是否开启通过团队号申请加入
        self.org_apply_code_invite = org_apply_code_invite
        # 是否开启通过链接邀请加入
        self.link_invite = link_invite
        # 邀请链接
        self.invite_url = invite_url
        # 仅部门邀请有效： 0-无需审核 1-有权限的子管理员
        self.audit_type = audit_type
        # 是否允许员工扫码加入部门，仅在无需审核的时候有效（已经在组织内的成员通过扫描部门二维码加入某个部门）
        self.emp_apply_join_dept = emp_apply_join_dept

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.invite_switch is not None:
            result['inviteSwitch'] = self.invite_switch
        if self.search_name_invite is not None:
            result['searchNameInvite'] = self.search_name_invite
        if self.org_apply_code_invite is not None:
            result['orgApplyCodeInvite'] = self.org_apply_code_invite
        if self.link_invite is not None:
            result['linkInvite'] = self.link_invite
        if self.invite_url is not None:
            result['inviteUrl'] = self.invite_url
        if self.audit_type is not None:
            result['auditType'] = self.audit_type
        if self.emp_apply_join_dept is not None:
            result['empApplyJoinDept'] = self.emp_apply_join_dept
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('inviteSwitch') is not None:
            self.invite_switch = m.get('inviteSwitch')
        if m.get('searchNameInvite') is not None:
            self.search_name_invite = m.get('searchNameInvite')
        if m.get('orgApplyCodeInvite') is not None:
            self.org_apply_code_invite = m.get('orgApplyCodeInvite')
        if m.get('linkInvite') is not None:
            self.link_invite = m.get('linkInvite')
        if m.get('inviteUrl') is not None:
            self.invite_url = m.get('inviteUrl')
        if m.get('auditType') is not None:
            self.audit_type = m.get('auditType')
        if m.get('empApplyJoinDept') is not None:
            self.emp_apply_join_dept = m.get('empApplyJoinDept')
        return self


class GetApplyInviteInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetApplyInviteInfoResponseBody = None,
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
            temp_model = GetApplyInviteInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


