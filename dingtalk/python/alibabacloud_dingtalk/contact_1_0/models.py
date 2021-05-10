# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


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


class GetBranchAuthDataHeaders(TeaModel):
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


class GetBranchAuthDataRequest(TeaModel):
    def __init__(
        self,
        branch_corp_id: str = None,
        code: str = None,
        body: Dict[str, str] = None,
    ):
        # 分支组织corpId
        self.branch_corp_id = branch_corp_id
        # 数据编码
        self.code = code
        # 查询条件
        self.body = body

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.branch_corp_id is not None:
            result['branchCorpId'] = self.branch_corp_id
        if self.code is not None:
            result['code'] = self.code
        if self.body is not None:
            result['body'] = self.body
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('branchCorpId') is not None:
            self.branch_corp_id = m.get('branchCorpId')
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('body') is not None:
            self.body = m.get('body')
        return self


class GetBranchAuthDataResponseBodyResult(TeaModel):
    def __init__(
        self,
        field_code: str = None,
        field_name: str = None,
        field_value: str = None,
    ):
        # 字段code
        self.field_code = field_code
        # 字段名称
        self.field_name = field_name
        # 字段值
        self.field_value = field_value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_code is not None:
            result['fieldCode'] = self.field_code
        if self.field_name is not None:
            result['fieldName'] = self.field_name
        if self.field_value is not None:
            result['fieldValue'] = self.field_value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldCode') is not None:
            self.field_code = m.get('fieldCode')
        if m.get('fieldName') is not None:
            self.field_name = m.get('fieldName')
        if m.get('fieldValue') is not None:
            self.field_value = m.get('fieldValue')
        return self


class GetBranchAuthDataResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetBranchAuthDataResponseBodyResult] = None,
    ):
        # result
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
                temp_model = GetBranchAuthDataResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GetBranchAuthDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetBranchAuthDataResponseBody = None,
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
            temp_model = GetBranchAuthDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetLatestDingIndexHeaders(TeaModel):
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


class GetLatestDingIndexResponseBody(TeaModel):
    def __init__(
        self,
        stat_date: str = None,
        idx_total: float = None,
        idx_efficiency: float = None,
        idx_carbon: float = None,
        idx_monthly_avg: float = None,
    ):
        # 日期
        self.stat_date = stat_date
        # 钉钉指数
        self.idx_total = idx_total
        # 效率指数
        self.idx_efficiency = idx_efficiency
        # 绿色指数
        self.idx_carbon = idx_carbon
        # 钉钉指数月均分
        self.idx_monthly_avg = idx_monthly_avg

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        if self.idx_total is not None:
            result['idxTotal'] = self.idx_total
        if self.idx_efficiency is not None:
            result['idxEfficiency'] = self.idx_efficiency
        if self.idx_carbon is not None:
            result['idxCarbon'] = self.idx_carbon
        if self.idx_monthly_avg is not None:
            result['idxMonthlyAvg'] = self.idx_monthly_avg
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        if m.get('idxTotal') is not None:
            self.idx_total = m.get('idxTotal')
        if m.get('idxEfficiency') is not None:
            self.idx_efficiency = m.get('idxEfficiency')
        if m.get('idxCarbon') is not None:
            self.idx_carbon = m.get('idxCarbon')
        if m.get('idxMonthlyAvg') is not None:
            self.idx_monthly_avg = m.get('idxMonthlyAvg')
        return self


class GetLatestDingIndexResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetLatestDingIndexResponseBody = None,
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
            temp_model = GetLatestDingIndexResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


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


