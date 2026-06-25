# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class ActivateMcpHeaders(TeaModel):
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


class ActivateMcpRequest(TeaModel):
    def __init__(
        self,
        mcp_id: int = None,
        source: str = None,
    ):
        # This parameter is required.
        self.mcp_id = mcp_id
        self.source = source

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.mcp_id is not None:
            result['mcpId'] = self.mcp_id
        if self.source is not None:
            result['source'] = self.source
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('mcpId') is not None:
            self.mcp_id = m.get('mcpId')
        if m.get('source') is not None:
            self.source = m.get('source')
        return self


class ActivateMcpResponseBody(TeaModel):
    def __init__(
        self,
        instance_id: str = None,
        json_config: str = None,
        url: str = None,
    ):
        self.instance_id = instance_id
        self.json_config = json_config
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.json_config is not None:
            result['jsonConfig'] = self.json_config
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('jsonConfig') is not None:
            self.json_config = m.get('jsonConfig')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class ActivateMcpResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ActivateMcpResponseBody = None,
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
            temp_model = ActivateMcpResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteMcpHeaders(TeaModel):
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


class DeleteMcpRequest(TeaModel):
    def __init__(
        self,
        instance_id: str = None,
    ):
        self.instance_id = instance_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        return self


class DeleteMcpResponseBody(TeaModel):
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


class DeleteMcpResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteMcpResponseBody = None,
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
            temp_model = DeleteMcpResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetMcpDetailHeaders(TeaModel):
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


class GetMcpDetailResponseBodyCategories(TeaModel):
    def __init__(
        self,
        code: str = None,
        display_name: str = None,
    ):
        self.code = code
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.display_name is not None:
            result['displayName'] = self.display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        return self


class GetMcpDetailResponseBodyTools(TeaModel):
    def __init__(
        self,
        description: str = None,
        display_name: str = None,
        input_schema: str = None,
        name: str = None,
        output_schema: str = None,
    ):
        self.description = description
        self.display_name = display_name
        self.input_schema = input_schema
        self.name = name
        self.output_schema = output_schema

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.description is not None:
            result['description'] = self.description
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.input_schema is not None:
            result['inputSchema'] = self.input_schema
        if self.name is not None:
            result['name'] = self.name
        if self.output_schema is not None:
            result['outputSchema'] = self.output_schema
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('inputSchema') is not None:
            self.input_schema = m.get('inputSchema')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('outputSchema') is not None:
            self.output_schema = m.get('outputSchema')
        return self


class GetMcpDetailResponseBody(TeaModel):
    def __init__(
        self,
        categories: List[GetMcpDetailResponseBodyCategories] = None,
        charged: bool = None,
        description: str = None,
        detail_url: str = None,
        icon: str = None,
        introduction: str = None,
        mcp_id: str = None,
        name: str = None,
        tools: List[GetMcpDetailResponseBodyTools] = None,
    ):
        self.categories = categories
        self.charged = charged
        self.description = description
        self.detail_url = detail_url
        self.icon = icon
        self.introduction = introduction
        self.mcp_id = mcp_id
        self.name = name
        self.tools = tools

    def validate(self):
        if self.categories:
            for k in self.categories:
                if k:
                    k.validate()
        if self.tools:
            for k in self.tools:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['categories'] = []
        if self.categories is not None:
            for k in self.categories:
                result['categories'].append(k.to_map() if k else None)
        if self.charged is not None:
            result['charged'] = self.charged
        if self.description is not None:
            result['description'] = self.description
        if self.detail_url is not None:
            result['detailUrl'] = self.detail_url
        if self.icon is not None:
            result['icon'] = self.icon
        if self.introduction is not None:
            result['introduction'] = self.introduction
        if self.mcp_id is not None:
            result['mcpId'] = self.mcp_id
        if self.name is not None:
            result['name'] = self.name
        result['tools'] = []
        if self.tools is not None:
            for k in self.tools:
                result['tools'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.categories = []
        if m.get('categories') is not None:
            for k in m.get('categories'):
                temp_model = GetMcpDetailResponseBodyCategories()
                self.categories.append(temp_model.from_map(k))
        if m.get('charged') is not None:
            self.charged = m.get('charged')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('detailUrl') is not None:
            self.detail_url = m.get('detailUrl')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('introduction') is not None:
            self.introduction = m.get('introduction')
        if m.get('mcpId') is not None:
            self.mcp_id = m.get('mcpId')
        if m.get('name') is not None:
            self.name = m.get('name')
        self.tools = []
        if m.get('tools') is not None:
            for k in m.get('tools'):
                temp_model = GetMcpDetailResponseBodyTools()
                self.tools.append(temp_model.from_map(k))
        return self


class GetMcpDetailResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetMcpDetailResponseBody = None,
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
            temp_model = GetMcpDetailResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetSkillDetailHeaders(TeaModel):
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


class GetSkillDetailResponseBodyCategories(TeaModel):
    def __init__(
        self,
        code: str = None,
        display_name: str = None,
    ):
        self.code = code
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.display_name is not None:
            result['displayName'] = self.display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        return self


class GetSkillDetailResponseBodyDependencies(TeaModel):
    def __init__(
        self,
        display_name: str = None,
        ref_id: str = None,
        required: bool = None,
        type: str = None,
    ):
        self.display_name = display_name
        self.ref_id = ref_id
        self.required = required
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.ref_id is not None:
            result['refId'] = self.ref_id
        if self.required is not None:
            result['required'] = self.required
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('refId') is not None:
            self.ref_id = m.get('refId')
        if m.get('required') is not None:
            self.required = m.get('required')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class GetSkillDetailResponseBody(TeaModel):
    def __init__(
        self,
        categories: List[GetSkillDetailResponseBodyCategories] = None,
        dependencies: List[GetSkillDetailResponseBodyDependencies] = None,
        description: str = None,
        detail_url: str = None,
        icon: str = None,
        introduction: str = None,
        name: str = None,
        package_url: str = None,
        skill_id: str = None,
    ):
        self.categories = categories
        self.dependencies = dependencies
        self.description = description
        self.detail_url = detail_url
        self.icon = icon
        self.introduction = introduction
        self.name = name
        self.package_url = package_url
        self.skill_id = skill_id

    def validate(self):
        if self.categories:
            for k in self.categories:
                if k:
                    k.validate()
        if self.dependencies:
            for k in self.dependencies:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['categories'] = []
        if self.categories is not None:
            for k in self.categories:
                result['categories'].append(k.to_map() if k else None)
        result['dependencies'] = []
        if self.dependencies is not None:
            for k in self.dependencies:
                result['dependencies'].append(k.to_map() if k else None)
        if self.description is not None:
            result['description'] = self.description
        if self.detail_url is not None:
            result['detailUrl'] = self.detail_url
        if self.icon is not None:
            result['icon'] = self.icon
        if self.introduction is not None:
            result['introduction'] = self.introduction
        if self.name is not None:
            result['name'] = self.name
        if self.package_url is not None:
            result['packageUrl'] = self.package_url
        if self.skill_id is not None:
            result['skillId'] = self.skill_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.categories = []
        if m.get('categories') is not None:
            for k in m.get('categories'):
                temp_model = GetSkillDetailResponseBodyCategories()
                self.categories.append(temp_model.from_map(k))
        self.dependencies = []
        if m.get('dependencies') is not None:
            for k in m.get('dependencies'):
                temp_model = GetSkillDetailResponseBodyDependencies()
                self.dependencies.append(temp_model.from_map(k))
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('detailUrl') is not None:
            self.detail_url = m.get('detailUrl')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('introduction') is not None:
            self.introduction = m.get('introduction')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('packageUrl') is not None:
            self.package_url = m.get('packageUrl')
        if m.get('skillId') is not None:
            self.skill_id = m.get('skillId')
        return self


class GetSkillDetailResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetSkillDetailResponseBody = None,
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
            temp_model = GetSkillDetailResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListMarketMcpsHeaders(TeaModel):
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


class ListMarketMcpsRequest(TeaModel):
    def __init__(
        self,
        page: int = None,
        page_size: int = None,
    ):
        self.page = page
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page is not None:
            result['page'] = self.page
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('page') is not None:
            self.page = m.get('page')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class ListMarketMcpsResponseBodyItemsCategories(TeaModel):
    def __init__(
        self,
        code: str = None,
        display_name: str = None,
    ):
        self.code = code
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.display_name is not None:
            result['displayName'] = self.display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        return self


class ListMarketMcpsResponseBodyItems(TeaModel):
    def __init__(
        self,
        categories: List[ListMarketMcpsResponseBodyItemsCategories] = None,
        charged: bool = None,
        description: str = None,
        detail_url: str = None,
        icon: str = None,
        mcp_id: str = None,
        name: str = None,
    ):
        self.categories = categories
        self.charged = charged
        self.description = description
        self.detail_url = detail_url
        self.icon = icon
        self.mcp_id = mcp_id
        self.name = name

    def validate(self):
        if self.categories:
            for k in self.categories:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['categories'] = []
        if self.categories is not None:
            for k in self.categories:
                result['categories'].append(k.to_map() if k else None)
        if self.charged is not None:
            result['charged'] = self.charged
        if self.description is not None:
            result['description'] = self.description
        if self.detail_url is not None:
            result['detailUrl'] = self.detail_url
        if self.icon is not None:
            result['icon'] = self.icon
        if self.mcp_id is not None:
            result['mcpId'] = self.mcp_id
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.categories = []
        if m.get('categories') is not None:
            for k in m.get('categories'):
                temp_model = ListMarketMcpsResponseBodyItemsCategories()
                self.categories.append(temp_model.from_map(k))
        if m.get('charged') is not None:
            self.charged = m.get('charged')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('detailUrl') is not None:
            self.detail_url = m.get('detailUrl')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('mcpId') is not None:
            self.mcp_id = m.get('mcpId')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class ListMarketMcpsResponseBody(TeaModel):
    def __init__(
        self,
        items: List[ListMarketMcpsResponseBodyItems] = None,
        page: int = None,
        page_size: int = None,
        total: int = None,
    ):
        self.items = items
        self.page = page
        self.page_size = page_size
        self.total = total

    def validate(self):
        if self.items:
            for k in self.items:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        if self.page is not None:
            result['page'] = self.page
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.items = []
        if m.get('items') is not None:
            for k in m.get('items'):
                temp_model = ListMarketMcpsResponseBodyItems()
                self.items.append(temp_model.from_map(k))
        if m.get('page') is not None:
            self.page = m.get('page')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class ListMarketMcpsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListMarketMcpsResponseBody = None,
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
            temp_model = ListMarketMcpsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListSkillsHeaders(TeaModel):
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


class ListSkillsRequest(TeaModel):
    def __init__(
        self,
        page: int = None,
        page_size: int = None,
    ):
        self.page = page
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page is not None:
            result['page'] = self.page
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('page') is not None:
            self.page = m.get('page')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class ListSkillsResponseBodyItemsCategories(TeaModel):
    def __init__(
        self,
        code: str = None,
        display_name: str = None,
    ):
        self.code = code
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.display_name is not None:
            result['displayName'] = self.display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        return self


class ListSkillsResponseBodyItems(TeaModel):
    def __init__(
        self,
        categories: List[ListSkillsResponseBodyItemsCategories] = None,
        description: str = None,
        detail_url: str = None,
        icon: str = None,
        name: str = None,
        skill_id: str = None,
    ):
        self.categories = categories
        self.description = description
        self.detail_url = detail_url
        self.icon = icon
        self.name = name
        self.skill_id = skill_id

    def validate(self):
        if self.categories:
            for k in self.categories:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['categories'] = []
        if self.categories is not None:
            for k in self.categories:
                result['categories'].append(k.to_map() if k else None)
        if self.description is not None:
            result['description'] = self.description
        if self.detail_url is not None:
            result['detailUrl'] = self.detail_url
        if self.icon is not None:
            result['icon'] = self.icon
        if self.name is not None:
            result['name'] = self.name
        if self.skill_id is not None:
            result['skillId'] = self.skill_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.categories = []
        if m.get('categories') is not None:
            for k in m.get('categories'):
                temp_model = ListSkillsResponseBodyItemsCategories()
                self.categories.append(temp_model.from_map(k))
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('detailUrl') is not None:
            self.detail_url = m.get('detailUrl')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('skillId') is not None:
            self.skill_id = m.get('skillId')
        return self


class ListSkillsResponseBody(TeaModel):
    def __init__(
        self,
        items: List[ListSkillsResponseBodyItems] = None,
        page: int = None,
        page_size: int = None,
        total: int = None,
    ):
        self.items = items
        self.page = page
        self.page_size = page_size
        self.total = total

    def validate(self):
        if self.items:
            for k in self.items:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        if self.page is not None:
            result['page'] = self.page
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.items = []
        if m.get('items') is not None:
            for k in m.get('items'):
                temp_model = ListSkillsResponseBodyItems()
                self.items.append(temp_model.from_map(k))
        if m.get('page') is not None:
            self.page = m.get('page')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class ListSkillsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListSkillsResponseBody = None,
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
            temp_model = ListSkillsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


