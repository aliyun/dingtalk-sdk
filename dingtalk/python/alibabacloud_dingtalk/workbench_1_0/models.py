# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class QueryComponentScopesHeaders(TeaModel):
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


class QueryComponentScopesResponseBody(TeaModel):
    def __init__(
        self,
        user_visible_scopes: List[str] = None,
        dept_visible_scopes: List[int] = None,
    ):
        # scopes
        self.user_visible_scopes = user_visible_scopes
        self.dept_visible_scopes = dept_visible_scopes

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_visible_scopes is not None:
            result['userVisibleScopes'] = self.user_visible_scopes
        if self.dept_visible_scopes is not None:
            result['deptVisibleScopes'] = self.dept_visible_scopes
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userVisibleScopes') is not None:
            self.user_visible_scopes = m.get('userVisibleScopes')
        if m.get('deptVisibleScopes') is not None:
            self.dept_visible_scopes = m.get('deptVisibleScopes')
        return self


class QueryComponentScopesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryComponentScopesResponseBody = None,
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
            temp_model = QueryComponentScopesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateDingPortalPageScopeHeaders(TeaModel):
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


class UpdateDingPortalPageScopeRequest(TeaModel):
    def __init__(
        self,
        userids: List[str] = None,
        dept_ids: List[int] = None,
        role_ids: List[int] = None,
        all_visible: bool = None,
    ):
        # 可见用户列表
        self.userids = userids
        # 可见部门列表
        self.dept_ids = dept_ids
        # 可见角色列表
        self.role_ids = role_ids
        # 是否全员可见
        self.all_visible = all_visible

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.userids is not None:
            result['userids'] = self.userids
        if self.dept_ids is not None:
            result['deptIds'] = self.dept_ids
        if self.role_ids is not None:
            result['roleIds'] = self.role_ids
        if self.all_visible is not None:
            result['allVisible'] = self.all_visible
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userids') is not None:
            self.userids = m.get('userids')
        if m.get('deptIds') is not None:
            self.dept_ids = m.get('deptIds')
        if m.get('roleIds') is not None:
            self.role_ids = m.get('roleIds')
        if m.get('allVisible') is not None:
            self.all_visible = m.get('allVisible')
        return self


class UpdateDingPortalPageScopeResponse(TeaModel):
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


class QueryShortcutScopesHeaders(TeaModel):
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


class QueryShortcutScopesResponseBody(TeaModel):
    def __init__(
        self,
        user_visible_scopes: List[str] = None,
        dept_visible_scopes: List[int] = None,
    ):
        # errorMsg
        self.user_visible_scopes = user_visible_scopes
        self.dept_visible_scopes = dept_visible_scopes

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_visible_scopes is not None:
            result['userVisibleScopes'] = self.user_visible_scopes
        if self.dept_visible_scopes is not None:
            result['deptVisibleScopes'] = self.dept_visible_scopes
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userVisibleScopes') is not None:
            self.user_visible_scopes = m.get('userVisibleScopes')
        if m.get('deptVisibleScopes') is not None:
            self.dept_visible_scopes = m.get('deptVisibleScopes')
        return self


class QueryShortcutScopesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryShortcutScopesResponseBody = None,
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
            temp_model = QueryShortcutScopesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetDingPortalDetailHeaders(TeaModel):
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


class GetDingPortalDetailResponseBodyPages(TeaModel):
    def __init__(
        self,
        page_uuid: str = None,
        page_name: str = None,
        userids: List[str] = None,
        dept_ids: List[int] = None,
        role_ids: List[int] = None,
        all_visible: bool = None,
    ):
        # 页面ID
        self.page_uuid = page_uuid
        # 页面名称
        self.page_name = page_name
        # 可见员工 ID 列表
        self.userids = userids
        # 可见部门 ID 铺
        self.dept_ids = dept_ids
        # 可见角色列表
        self.role_ids = role_ids
        # 是否全公司可见
        self.all_visible = all_visible

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_uuid is not None:
            result['pageUuid'] = self.page_uuid
        if self.page_name is not None:
            result['pageName'] = self.page_name
        if self.userids is not None:
            result['userids'] = self.userids
        if self.dept_ids is not None:
            result['deptIds'] = self.dept_ids
        if self.role_ids is not None:
            result['roleIds'] = self.role_ids
        if self.all_visible is not None:
            result['allVisible'] = self.all_visible
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageUuid') is not None:
            self.page_uuid = m.get('pageUuid')
        if m.get('pageName') is not None:
            self.page_name = m.get('pageName')
        if m.get('userids') is not None:
            self.userids = m.get('userids')
        if m.get('deptIds') is not None:
            self.dept_ids = m.get('deptIds')
        if m.get('roleIds') is not None:
            self.role_ids = m.get('roleIds')
        if m.get('allVisible') is not None:
            self.all_visible = m.get('allVisible')
        return self


class GetDingPortalDetailResponseBody(TeaModel):
    def __init__(
        self,
        app_uuid: str = None,
        ding_portal_name: str = None,
        pages: List[GetDingPortalDetailResponseBodyPages] = None,
    ):
        # 工作台ID
        self.app_uuid = app_uuid
        # 工作台名称
        self.ding_portal_name = ding_portal_name
        # 工作台页面信息
        self.pages = pages

    def validate(self):
        if self.pages:
            for k in self.pages:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_uuid is not None:
            result['appUuid'] = self.app_uuid
        if self.ding_portal_name is not None:
            result['dingPortalName'] = self.ding_portal_name
        result['pages'] = []
        if self.pages is not None:
            for k in self.pages:
                result['pages'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUuid') is not None:
            self.app_uuid = m.get('appUuid')
        if m.get('dingPortalName') is not None:
            self.ding_portal_name = m.get('dingPortalName')
        self.pages = []
        if m.get('pages') is not None:
            for k in m.get('pages'):
                temp_model = GetDingPortalDetailResponseBodyPages()
                self.pages.append(temp_model.from_map(k))
        return self


class GetDingPortalDetailResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetDingPortalDetailResponseBody = None,
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
            temp_model = GetDingPortalDetailResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


