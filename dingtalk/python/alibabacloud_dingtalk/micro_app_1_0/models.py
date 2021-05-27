# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


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


