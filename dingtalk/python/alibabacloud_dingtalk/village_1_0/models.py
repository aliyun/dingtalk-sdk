# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class ListSubCorpsHeaders(TeaModel):
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


class ListSubCorpsRequest(TeaModel):
    def __init__(
        self,
        types: str = None,
        sub_corp_id: str = None,
        is_only_direct: bool = None,
    ):
        # 下级指定组织层级列表，组织层级为county,town,community,residential，依次为区/县、乡/镇/街道、社区/村、小区，如果查多个用 '|' 分隔
        self.types = types
        # 真正查询的组织corpId
        self.sub_corp_id = sub_corp_id
        # 是否查询直接下级
        self.is_only_direct = is_only_direct

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.types is not None:
            result['types'] = self.types
        if self.sub_corp_id is not None:
            result['subCorpId'] = self.sub_corp_id
        if self.is_only_direct is not None:
            result['isOnlyDirect'] = self.is_only_direct
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('types') is not None:
            self.types = m.get('types')
        if m.get('subCorpId') is not None:
            self.sub_corp_id = m.get('subCorpId')
        if m.get('isOnlyDirect') is not None:
            self.is_only_direct = m.get('isOnlyDirect')
        return self


class ListSubCorpsResponseBodyResult(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        name: str = None,
        region_type: str = None,
        region_id: str = None,
        region_location: str = None,
        industry_code: int = None,
        industry: str = None,
    ):
        # 企业corpid
        self.corp_id = corp_id
        # 企业名字
        self.name = name
        # 区域类型，值为county,town,community,residential，依次为区/县、乡/镇/街道、社区/村、小区
        self.region_type = region_type
        # 区域码
        self.region_id = region_id
        # 区域详细信息
        self.region_location = region_location
        # 企业行业码
        self.industry_code = industry_code
        # 企业行业名称
        self.industry = industry

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.name is not None:
            result['name'] = self.name
        if self.region_type is not None:
            result['regionType'] = self.region_type
        if self.region_id is not None:
            result['regionId'] = self.region_id
        if self.region_location is not None:
            result['regionLocation'] = self.region_location
        if self.industry_code is not None:
            result['industryCode'] = self.industry_code
        if self.industry is not None:
            result['industry'] = self.industry
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('regionType') is not None:
            self.region_type = m.get('regionType')
        if m.get('regionId') is not None:
            self.region_id = m.get('regionId')
        if m.get('regionLocation') is not None:
            self.region_location = m.get('regionLocation')
        if m.get('industryCode') is not None:
            self.industry_code = m.get('industryCode')
        if m.get('industry') is not None:
            self.industry = m.get('industry')
        return self


class ListSubCorpsResponseBody(TeaModel):
    def __init__(
        self,
        result: List[ListSubCorpsResponseBodyResult] = None,
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
                temp_model = ListSubCorpsResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class ListSubCorpsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListSubCorpsResponseBody = None,
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
            temp_model = ListSubCorpsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetVillageOrgInfoHeaders(TeaModel):
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


class GetVillageOrgInfoResponseBody(TeaModel):
    def __init__(
        self,
        region_type: str = None,
        region_id: str = None,
        region_location: str = None,
    ):
        # 区域类型
        self.region_type = region_type
        # 行政区ID
        self.region_id = region_id
        # 具体的企业区域位置信息
        self.region_location = region_location

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.region_type is not None:
            result['regionType'] = self.region_type
        if self.region_id is not None:
            result['regionId'] = self.region_id
        if self.region_location is not None:
            result['regionLocation'] = self.region_location
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('regionType') is not None:
            self.region_type = m.get('regionType')
        if m.get('regionId') is not None:
            self.region_id = m.get('regionId')
        if m.get('regionLocation') is not None:
            self.region_location = m.get('regionLocation')
        return self


class GetVillageOrgInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetVillageOrgInfoResponseBody = None,
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
            temp_model = GetVillageOrgInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListResidentDeptUsersHeaders(TeaModel):
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


class ListResidentDeptUsersRequest(TeaModel):
    def __init__(
        self,
        sub_corp_id: str = None,
        role: str = None,
        cursor: int = None,
        size: int = None,
    ):
        # 真实请求的组织corpId
        self.sub_corp_id = sub_corp_id
        # 标签
        self.role = role
        # 游标，不传默认1
        self.cursor = cursor
        # 大小
        self.size = size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.sub_corp_id is not None:
            result['subCorpId'] = self.sub_corp_id
        if self.role is not None:
            result['role'] = self.role
        if self.cursor is not None:
            result['cursor'] = self.cursor
        if self.size is not None:
            result['size'] = self.size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('subCorpId') is not None:
            self.sub_corp_id = m.get('subCorpId')
        if m.get('role') is not None:
            self.role = m.get('role')
        if m.get('cursor') is not None:
            self.cursor = m.get('cursor')
        if m.get('size') is not None:
            self.size = m.get('size')
        return self


class ListResidentDeptUsersResponseBodyListRoles(TeaModel):
    def __init__(
        self,
        id: int = None,
        name: str = None,
        tag_code: str = None,
    ):
        # 标签id
        self.id = id
        # 标签名称
        self.name = name
        # 标签名称 tagCode
        self.tag_code = tag_code

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
        if self.tag_code is not None:
            result['tagCode'] = self.tag_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('tagCode') is not None:
            self.tag_code = m.get('tagCode')
        return self


class ListResidentDeptUsersResponseBodyList(TeaModel):
    def __init__(
        self,
        user_id: str = None,
        name: str = None,
        roles: List[ListResidentDeptUsersResponseBodyListRoles] = None,
        feature: str = None,
        union_id: str = None,
    ):
        # 员工id
        self.user_id = user_id
        # 员工名字
        self.name = name
        # 标签列表
        self.roles = roles
        # 员工特征
        self.feature = feature
        # 钉钉唯一标识
        self.union_id = union_id

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
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.name is not None:
            result['name'] = self.name
        result['roles'] = []
        if self.roles is not None:
            for k in self.roles:
                result['roles'].append(k.to_map() if k else None)
        if self.feature is not None:
            result['feature'] = self.feature
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('name') is not None:
            self.name = m.get('name')
        self.roles = []
        if m.get('roles') is not None:
            for k in m.get('roles'):
                temp_model = ListResidentDeptUsersResponseBodyListRoles()
                self.roles.append(temp_model.from_map(k))
        if m.get('feature') is not None:
            self.feature = m.get('feature')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class ListResidentDeptUsersResponseBody(TeaModel):
    def __init__(
        self,
        next_cursor: int = None,
        has_more: bool = None,
        list: List[ListResidentDeptUsersResponseBodyList] = None,
    ):
        # 下一个游标
        self.next_cursor = next_cursor
        # 是否还有更多数据
        self.has_more = has_more
        # 分页数据
        self.list = list

    def validate(self):
        if self.list:
            for k in self.list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_cursor is not None:
            result['nextCursor'] = self.next_cursor
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextCursor') is not None:
            self.next_cursor = m.get('nextCursor')
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = ListResidentDeptUsersResponseBodyList()
                self.list.append(temp_model.from_map(k))
        return self


class ListResidentDeptUsersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListResidentDeptUsersResponseBody = None,
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
            temp_model = ListResidentDeptUsersResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListDeptSimpleUsersHeaders(TeaModel):
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


class ListDeptSimpleUsersRequest(TeaModel):
    def __init__(
        self,
        cursor: int = None,
        size: int = None,
        contain_access_limit: bool = None,
        sub_corp_id: str = None,
        language: str = None,
        order_field: str = None,
    ):
        # cursor
        self.cursor = cursor
        # size
        self.size = size
        # containAccessLimit
        self.contain_access_limit = contain_access_limit
        # subCorpId
        self.sub_corp_id = sub_corp_id
        # language
        self.language = language
        # orderField
        self.order_field = order_field

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cursor is not None:
            result['cursor'] = self.cursor
        if self.size is not None:
            result['size'] = self.size
        if self.contain_access_limit is not None:
            result['containAccessLimit'] = self.contain_access_limit
        if self.sub_corp_id is not None:
            result['subCorpId'] = self.sub_corp_id
        if self.language is not None:
            result['language'] = self.language
        if self.order_field is not None:
            result['orderField'] = self.order_field
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cursor') is not None:
            self.cursor = m.get('cursor')
        if m.get('size') is not None:
            self.size = m.get('size')
        if m.get('containAccessLimit') is not None:
            self.contain_access_limit = m.get('containAccessLimit')
        if m.get('subCorpId') is not None:
            self.sub_corp_id = m.get('subCorpId')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('orderField') is not None:
            self.order_field = m.get('orderField')
        return self


class ListDeptSimpleUsersResponseBodyList(TeaModel):
    def __init__(
        self,
        user_id: str = None,
        name: str = None,
    ):
        self.user_id = user_id
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class ListDeptSimpleUsersResponseBody(TeaModel):
    def __init__(
        self,
        list: List[ListDeptSimpleUsersResponseBodyList] = None,
        total_count: int = None,
        next_cursor: int = None,
        has_more: bool = None,
    ):
        self.list = list
        self.total_count = total_count
        self.next_cursor = next_cursor
        self.has_more = has_more

    def validate(self):
        if self.list:
            for k in self.list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        if self.next_cursor is not None:
            result['nextCursor'] = self.next_cursor
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = ListDeptSimpleUsersResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        if m.get('nextCursor') is not None:
            self.next_cursor = m.get('nextCursor')
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        return self


class ListDeptSimpleUsersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListDeptSimpleUsersResponseBody = None,
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
            temp_model = ListDeptSimpleUsersResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetUserByUnionIdHeaders(TeaModel):
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


class GetUserByUnionIdRequest(TeaModel):
    def __init__(
        self,
        sub_corp_id: str = None,
        union_id: str = None,
        language: str = None,
    ):
        # 真实请求的组织corpId
        self.sub_corp_id = sub_corp_id
        # 人员 id
        self.union_id = union_id
        # 通讯录语言(默认zh_CN另外支持en_US)
        self.language = language

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.sub_corp_id is not None:
            result['subCorpId'] = self.sub_corp_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.language is not None:
            result['language'] = self.language
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('subCorpId') is not None:
            self.sub_corp_id = m.get('subCorpId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('language') is not None:
            self.language = m.get('language')
        return self


class GetUserByUnionIdResponseBody(TeaModel):
    def __init__(
        self,
        contact_type: int = None,
        user_id: str = None,
    ):
        # 联系类型，0表示企业内部员工，1表示企业外部联系人
        self.contact_type = contact_type
        # 用户id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.contact_type is not None:
            result['contactType'] = self.contact_type
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('contactType') is not None:
            self.contact_type = m.get('contactType')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetUserByUnionIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetUserByUnionIdResponseBody = None,
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
            temp_model = GetUserByUnionIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetResidentDeptHeaders(TeaModel):
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


class GetResidentDeptRequest(TeaModel):
    def __init__(
        self,
        sub_corp_id: str = None,
    ):
        # 真实请求的组织corpId
        self.sub_corp_id = sub_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.sub_corp_id is not None:
            result['subCorpId'] = self.sub_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('subCorpId') is not None:
            self.sub_corp_id = m.get('subCorpId')
        return self


class GetResidentDeptResponseBody(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        name: str = None,
        dept_type: str = None,
        contact_type: str = None,
        feature: str = None,
    ):
        # 部门ID
        self.dept_id = dept_id
        # 部门名称
        self.name = name
        # 部门类型
        self.dept_type = dept_type
        # 通讯录架构类型
        self.contact_type = contact_type
        # 部门属性
        self.feature = feature

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.name is not None:
            result['name'] = self.name
        if self.dept_type is not None:
            result['deptType'] = self.dept_type
        if self.contact_type is not None:
            result['contactType'] = self.contact_type
        if self.feature is not None:
            result['feature'] = self.feature
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('deptType') is not None:
            self.dept_type = m.get('deptType')
        if m.get('contactType') is not None:
            self.contact_type = m.get('contactType')
        if m.get('feature') is not None:
            self.feature = m.get('feature')
        return self


class GetResidentDeptResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetResidentDeptResponseBody = None,
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
            temp_model = GetResidentDeptResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetResidentUserInfoHeaders(TeaModel):
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


class GetResidentUserInfoRequest(TeaModel):
    def __init__(
        self,
        sub_corp_id: str = None,
    ):
        # 真实请求的组织corpId
        self.sub_corp_id = sub_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.sub_corp_id is not None:
            result['subCorpId'] = self.sub_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('subCorpId') is not None:
            self.sub_corp_id = m.get('subCorpId')
        return self


class GetResidentUserInfoResponseBodyRoles(TeaModel):
    def __init__(
        self,
        id: int = None,
        name: str = None,
        tag_code: str = None,
    ):
        # 标签id
        self.id = id
        # 标签名称
        self.name = name
        # 标签名称 tagCode
        self.tag_code = tag_code

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
        if self.tag_code is not None:
            result['tagCode'] = self.tag_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('tagCode') is not None:
            self.tag_code = m.get('tagCode')
        return self


class GetResidentUserInfoResponseBody(TeaModel):
    def __init__(
        self,
        userid: str = None,
        name: str = None,
        roles: List[GetResidentUserInfoResponseBodyRoles] = None,
        feature: str = None,
        union_id: str = None,
    ):
        # 员工id
        self.userid = userid
        # 员工名字
        self.name = name
        # 标签列表
        self.roles = roles
        # 员工特征
        self.feature = feature
        # 钉钉唯一标识
        self.union_id = union_id

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
        if self.userid is not None:
            result['userid'] = self.userid
        if self.name is not None:
            result['name'] = self.name
        result['roles'] = []
        if self.roles is not None:
            for k in self.roles:
                result['roles'].append(k.to_map() if k else None)
        if self.feature is not None:
            result['feature'] = self.feature
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userid') is not None:
            self.userid = m.get('userid')
        if m.get('name') is not None:
            self.name = m.get('name')
        self.roles = []
        if m.get('roles') is not None:
            for k in m.get('roles'):
                temp_model = GetResidentUserInfoResponseBodyRoles()
                self.roles.append(temp_model.from_map(k))
        if m.get('feature') is not None:
            self.feature = m.get('feature')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetResidentUserInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetResidentUserInfoResponseBody = None,
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
            temp_model = GetResidentUserInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetDeptHeaders(TeaModel):
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


class GetDeptRequest(TeaModel):
    def __init__(
        self,
        sub_corp_id: str = None,
        language: str = None,
    ):
        # 真实请求的组织corpId
        self.sub_corp_id = sub_corp_id
        # 通讯录语言(默认zh_CN另外支持en_US)
        self.language = language

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.sub_corp_id is not None:
            result['subCorpId'] = self.sub_corp_id
        if self.language is not None:
            result['language'] = self.language
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('subCorpId') is not None:
            self.sub_corp_id = m.get('subCorpId')
        if m.get('language') is not None:
            self.language = m.get('language')
        return self


class GetDeptResponseBody(TeaModel):
    def __init__(
        self,
        order: int = None,
        dept_id: int = None,
        name: str = None,
        parent_id: int = None,
        from_union_org: bool = None,
    ):
        # 在父部门中的次序值
        self.order = order
        # 部门id
        self.dept_id = dept_id
        # 部门名称
        self.name = name
        # 父部门id
        self.parent_id = parent_id
        # 部门是否来自关联组织
        self.from_union_org = from_union_org

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.order is not None:
            result['order'] = self.order
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.name is not None:
            result['name'] = self.name
        if self.parent_id is not None:
            result['parentId'] = self.parent_id
        if self.from_union_org is not None:
            result['fromUnionOrg'] = self.from_union_org
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('order') is not None:
            self.order = m.get('order')
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('parentId') is not None:
            self.parent_id = m.get('parentId')
        if m.get('fromUnionOrg') is not None:
            self.from_union_org = m.get('fromUnionOrg')
        return self


class GetDeptResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetDeptResponseBody = None,
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
            temp_model = GetDeptResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListParentByDeptHeaders(TeaModel):
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


class ListParentByDeptRequest(TeaModel):
    def __init__(
        self,
        sub_corp_id: str = None,
        dept_id: int = None,
    ):
        # 真实请求的组织corpId
        self.sub_corp_id = sub_corp_id
        # 部门id
        self.dept_id = dept_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.sub_corp_id is not None:
            result['subCorpId'] = self.sub_corp_id
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('subCorpId') is not None:
            self.sub_corp_id = m.get('subCorpId')
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        return self


class ListParentByDeptResponseBody(TeaModel):
    def __init__(
        self,
        parent_id_list: List[int] = None,
    ):
        # 父部门列表
        self.parent_id_list = parent_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.parent_id_list is not None:
            result['parentIdList'] = self.parent_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('parentIdList') is not None:
            self.parent_id_list = m.get('parentIdList')
        return self


class ListParentByDeptResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListParentByDeptResponseBody = None,
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
            temp_model = ListParentByDeptResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListDeptUserIdsHeaders(TeaModel):
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


class ListDeptUserIdsRequest(TeaModel):
    def __init__(
        self,
        sub_corp_id: str = None,
    ):
        # subCorpId
        self.sub_corp_id = sub_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.sub_corp_id is not None:
            result['subCorpId'] = self.sub_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('subCorpId') is not None:
            self.sub_corp_id = m.get('subCorpId')
        return self


class ListDeptUserIdsResponseBody(TeaModel):
    def __init__(
        self,
        user_id_list: List[str] = None,
    ):
        self.user_id_list = user_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id_list is not None:
            result['userIdList'] = self.user_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userIdList') is not None:
            self.user_id_list = m.get('userIdList')
        return self


class ListDeptUserIdsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListDeptUserIdsResponseBody = None,
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
            temp_model = ListDeptUserIdsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListSimpleUsersByRoleHeaders(TeaModel):
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


class ListSimpleUsersByRoleRequest(TeaModel):
    def __init__(
        self,
        offset: int = None,
        size: int = None,
        role_id: int = None,
        sub_corp_id: str = None,
    ):
        # cursor
        self.offset = offset
        # size
        self.size = size
        # roleId
        self.role_id = role_id
        # subCorpId
        self.sub_corp_id = sub_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.offset is not None:
            result['offset'] = self.offset
        if self.size is not None:
            result['size'] = self.size
        if self.role_id is not None:
            result['roleId'] = self.role_id
        if self.sub_corp_id is not None:
            result['subCorpId'] = self.sub_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('offset') is not None:
            self.offset = m.get('offset')
        if m.get('size') is not None:
            self.size = m.get('size')
        if m.get('roleId') is not None:
            self.role_id = m.get('roleId')
        if m.get('subCorpId') is not None:
            self.sub_corp_id = m.get('subCorpId')
        return self


class ListSimpleUsersByRoleResponseBodyList(TeaModel):
    def __init__(
        self,
        user_id: str = None,
        union_id: str = None,
        job_number: str = None,
        name: str = None,
    ):
        self.user_id = user_id
        self.union_id = union_id
        self.job_number = job_number
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.job_number is not None:
            result['jobNumber'] = self.job_number
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('jobNumber') is not None:
            self.job_number = m.get('jobNumber')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class ListSimpleUsersByRoleResponseBody(TeaModel):
    def __init__(
        self,
        list: List[ListSimpleUsersByRoleResponseBodyList] = None,
        next_cursor_string: str = None,
        next_cursor: int = None,
        has_more: bool = None,
    ):
        self.list = list
        self.next_cursor_string = next_cursor_string
        self.next_cursor = next_cursor
        self.has_more = has_more

    def validate(self):
        if self.list:
            for k in self.list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        if self.next_cursor_string is not None:
            result['nextCursorString'] = self.next_cursor_string
        if self.next_cursor is not None:
            result['nextCursor'] = self.next_cursor
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = ListSimpleUsersByRoleResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextCursorString') is not None:
            self.next_cursor_string = m.get('nextCursorString')
        if m.get('nextCursor') is not None:
            self.next_cursor = m.get('nextCursor')
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        return self


class ListSimpleUsersByRoleResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListSimpleUsersByRoleResponseBody = None,
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
            temp_model = ListSimpleUsersByRoleResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListResidentSubDeptsHeaders(TeaModel):
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


class ListResidentSubDeptsRequest(TeaModel):
    def __init__(
        self,
        sub_corp_id: str = None,
        cursor: int = None,
        size: int = None,
    ):
        # 真实请求的组织corpId
        self.sub_corp_id = sub_corp_id
        # 游标，不传默认1
        self.cursor = cursor
        # 大小
        self.size = size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.sub_corp_id is not None:
            result['subCorpId'] = self.sub_corp_id
        if self.cursor is not None:
            result['cursor'] = self.cursor
        if self.size is not None:
            result['size'] = self.size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('subCorpId') is not None:
            self.sub_corp_id = m.get('subCorpId')
        if m.get('cursor') is not None:
            self.cursor = m.get('cursor')
        if m.get('size') is not None:
            self.size = m.get('size')
        return self


class ListResidentSubDeptsResponseBodyList(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        name: str = None,
        super_id: int = None,
    ):
        self.dept_id = dept_id
        self.name = name
        self.super_id = super_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.name is not None:
            result['name'] = self.name
        if self.super_id is not None:
            result['superId'] = self.super_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('superId') is not None:
            self.super_id = m.get('superId')
        return self


class ListResidentSubDeptsResponseBody(TeaModel):
    def __init__(
        self,
        list: List[ListResidentSubDeptsResponseBodyList] = None,
        next_cursor: int = None,
        has_more: bool = None,
        total: int = None,
    ):
        self.list = list
        self.next_cursor = next_cursor
        self.has_more = has_more
        self.total = total

    def validate(self):
        if self.list:
            for k in self.list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        if self.next_cursor is not None:
            result['nextCursor'] = self.next_cursor
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = ListResidentSubDeptsResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextCursor') is not None:
            self.next_cursor = m.get('nextCursor')
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class ListResidentSubDeptsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListResidentSubDeptsResponseBody = None,
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
            temp_model = ListResidentSubDeptsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListParentByUserHeaders(TeaModel):
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


class ListParentByUserRequest(TeaModel):
    def __init__(
        self,
        sub_corp_id: str = None,
        user_id: str = None,
    ):
        # 真实请求的组织corpId
        self.sub_corp_id = sub_corp_id
        # 用户userId
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.sub_corp_id is not None:
            result['subCorpId'] = self.sub_corp_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('subCorpId') is not None:
            self.sub_corp_id = m.get('subCorpId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class ListParentByUserResponseBody(TeaModel):
    def __init__(
        self,
        parent_dept_id_list: List[int] = None,
    ):
        # 上级部门id链
        self.parent_dept_id_list = parent_dept_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.parent_dept_id_list is not None:
            result['parentDeptIdList'] = self.parent_dept_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('parentDeptIdList') is not None:
            self.parent_dept_id_list = m.get('parentDeptIdList')
        return self


class ListParentByUserResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListParentByUserResponseBody = None,
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
            temp_model = ListParentByUserResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListSubDeptHeaders(TeaModel):
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


class ListSubDeptRequest(TeaModel):
    def __init__(
        self,
        sub_corp_id: str = None,
        language: str = None,
    ):
        # 真实请求的组织corpId
        self.sub_corp_id = sub_corp_id
        # 通讯录语言(默认zh_CN另外支持en_US)
        self.language = language

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.sub_corp_id is not None:
            result['subCorpId'] = self.sub_corp_id
        if self.language is not None:
            result['language'] = self.language
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('subCorpId') is not None:
            self.sub_corp_id = m.get('subCorpId')
        if m.get('language') is not None:
            self.language = m.get('language')
        return self


class ListSubDeptResponseBodyResult(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        name: str = None,
    ):
        # 部门ID
        self.dept_id = dept_id
        # 部门名称
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class ListSubDeptResponseBody(TeaModel):
    def __init__(
        self,
        result: List[ListSubDeptResponseBodyResult] = None,
    ):
        # 返回列表
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
                temp_model = ListSubDeptResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class ListSubDeptResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListSubDeptResponseBody = None,
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
            temp_model = ListSubDeptResponseBody()
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


class GetUserRequest(TeaModel):
    def __init__(
        self,
        sub_corp_id: str = None,
        language: str = None,
    ):
        # 真实请求的组织corpId
        self.sub_corp_id = sub_corp_id
        # 通讯录语言(默认zh_CN另外支持en_US)
        self.language = language

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.sub_corp_id is not None:
            result['subCorpId'] = self.sub_corp_id
        if self.language is not None:
            result['language'] = self.language
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('subCorpId') is not None:
            self.sub_corp_id = m.get('subCorpId')
        if m.get('language') is not None:
            self.language = m.get('language')
        return self


class GetUserResponseBodyDeptOrderSet(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        order: int = None,
    ):
        # 部门id
        self.dept_id = dept_id
        # 员工在部门中的排序。
        self.order = order

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.order is not None:
            result['order'] = self.order
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('order') is not None:
            self.order = m.get('order')
        return self


class GetUserResponseBodyLeaderInDept(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        leader: bool = None,
    ):
        # 部门 id
        self.dept_id = dept_id
        # 员工在对应的部门中是否领导
        self.leader = leader

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.leader is not None:
            result['leader'] = self.leader
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('leader') is not None:
            self.leader = m.get('leader')
        return self


class GetUserResponseBodyRoleList(TeaModel):
    def __init__(
        self,
        id: int = None,
        name: str = None,
        group_name: str = None,
    ):
        # 角色id
        self.id = id
        # 角色名称
        self.name = name
        # 角色组名称
        self.group_name = group_name

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
        if self.group_name is not None:
            result['groupName'] = self.group_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        return self


class GetUserResponseBodyUnionEmpExtUnionEmpMapList(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        staff_id: str = None,
    ):
        # 企业 id
        self.corp_id = corp_id
        # 员工 id
        self.staff_id = staff_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.staff_id is not None:
            result['staffId'] = self.staff_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('staffId') is not None:
            self.staff_id = m.get('staffId')
        return self


class GetUserResponseBodyUnionEmpExt(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        staff_id: str = None,
        union_emp_map_list: List[GetUserResponseBodyUnionEmpExtUnionEmpMapList] = None,
    ):
        # 企业id
        self.corp_id = corp_id
        # 员工id
        self.staff_id = staff_id
        # 关联映射关系
        self.union_emp_map_list = union_emp_map_list

    def validate(self):
        if self.union_emp_map_list:
            for k in self.union_emp_map_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.staff_id is not None:
            result['staffId'] = self.staff_id
        result['unionEmpMapList'] = []
        if self.union_emp_map_list is not None:
            for k in self.union_emp_map_list:
                result['unionEmpMapList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('staffId') is not None:
            self.staff_id = m.get('staffId')
        self.union_emp_map_list = []
        if m.get('unionEmpMapList') is not None:
            for k in m.get('unionEmpMapList'):
                temp_model = GetUserResponseBodyUnionEmpExtUnionEmpMapList()
                self.union_emp_map_list.append(temp_model.from_map(k))
        return self


class GetUserResponseBody(TeaModel):
    def __init__(
        self,
        user_id: str = None,
        union_id: str = None,
        name: str = None,
        avatar: str = None,
        job_number: str = None,
        title: str = None,
        work_place: str = None,
        remark: str = None,
        dept_id_list: List[int] = None,
        dept_order_set: List[GetUserResponseBodyDeptOrderSet] = None,
        extension: str = None,
        hired_date: int = None,
        active: bool = None,
        real_authed: bool = None,
        senior: bool = None,
        admin: bool = None,
        boss: bool = None,
        exclusive_account: bool = None,
        exclusive_account_type: str = None,
        leader_in_dept: List[GetUserResponseBodyLeaderInDept] = None,
        role_list: List[GetUserResponseBodyRoleList] = None,
        union_emp_ext: GetUserResponseBodyUnionEmpExt = None,
        manager_user_id: str = None,
    ):
        # 用户id
        self.user_id = user_id
        # 员工在当前开发者企业账号范围内的唯一标识
        self.union_id = union_id
        # 姓名
        self.name = name
        # 头像
        self.avatar = avatar
        # 员工工号
        self.job_number = job_number
        # 职位
        self.title = title
        # 办公地点
        self.work_place = work_place
        # 备注
        self.remark = remark
        # 所属部门id列表
        self.dept_id_list = dept_id_list
        # 员工在对应的部门中的排序。
        self.dept_order_set = dept_order_set
        # 扩展属性，长度最大2000个字符。可以设置多种属性（手机上最多显示10个扩展属性，具体显示哪些属性，请到OA管理后台->设置->通讯录信息设置和OA管理后台->设置->手机端显示信息设置）。 该字段的值支持链接类型填写，同时链接支持变量通配符自动替换，目前支持通配符有：userid，corpid。示例： [工位地址](http://www.dingtalk.com?userid=#userid#&corpid=#corpid#)
        self.extension = extension
        # 入职时间，Unix时间戳，单位ms。
        self.hired_date = hired_date
        # 是否激活
        self.active = active
        # 是否实名认证
        self.real_authed = real_authed
        # 是否高管
        self.senior = senior
        # 是否管理员
        self.admin = admin
        # 是否老板
        self.boss = boss
        # 是否专属帐号
        self.exclusive_account = exclusive_account
        # 专属帐号类型：{sso: 企业自定义idp;dingtalk: 钉钉idp}
        self.exclusive_account_type = exclusive_account_type
        # 员工在对应的部门中是否领导。
        self.leader_in_dept = leader_in_dept
        # 角色列表
        self.role_list = role_list
        # 关联信息
        self.union_emp_ext = union_emp_ext
        # 主管的ID，仅限企业内部开发调用
        self.manager_user_id = manager_user_id

    def validate(self):
        if self.dept_order_set:
            for k in self.dept_order_set:
                if k:
                    k.validate()
        if self.leader_in_dept:
            for k in self.leader_in_dept:
                if k:
                    k.validate()
        if self.role_list:
            for k in self.role_list:
                if k:
                    k.validate()
        if self.union_emp_ext:
            self.union_emp_ext.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.name is not None:
            result['name'] = self.name
        if self.avatar is not None:
            result['avatar'] = self.avatar
        if self.job_number is not None:
            result['jobNumber'] = self.job_number
        if self.title is not None:
            result['title'] = self.title
        if self.work_place is not None:
            result['workPlace'] = self.work_place
        if self.remark is not None:
            result['remark'] = self.remark
        if self.dept_id_list is not None:
            result['deptIdList'] = self.dept_id_list
        result['deptOrderSet'] = []
        if self.dept_order_set is not None:
            for k in self.dept_order_set:
                result['deptOrderSet'].append(k.to_map() if k else None)
        if self.extension is not None:
            result['extension'] = self.extension
        if self.hired_date is not None:
            result['hiredDate'] = self.hired_date
        if self.active is not None:
            result['active'] = self.active
        if self.real_authed is not None:
            result['realAuthed'] = self.real_authed
        if self.senior is not None:
            result['senior'] = self.senior
        if self.admin is not None:
            result['admin'] = self.admin
        if self.boss is not None:
            result['boss'] = self.boss
        if self.exclusive_account is not None:
            result['exclusiveAccount'] = self.exclusive_account
        if self.exclusive_account_type is not None:
            result['exclusiveAccountType'] = self.exclusive_account_type
        result['leaderInDept'] = []
        if self.leader_in_dept is not None:
            for k in self.leader_in_dept:
                result['leaderInDept'].append(k.to_map() if k else None)
        result['roleList'] = []
        if self.role_list is not None:
            for k in self.role_list:
                result['roleList'].append(k.to_map() if k else None)
        if self.union_emp_ext is not None:
            result['unionEmpExt'] = self.union_emp_ext.to_map()
        if self.manager_user_id is not None:
            result['managerUserId'] = self.manager_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('avatar') is not None:
            self.avatar = m.get('avatar')
        if m.get('jobNumber') is not None:
            self.job_number = m.get('jobNumber')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('workPlace') is not None:
            self.work_place = m.get('workPlace')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('deptIdList') is not None:
            self.dept_id_list = m.get('deptIdList')
        self.dept_order_set = []
        if m.get('deptOrderSet') is not None:
            for k in m.get('deptOrderSet'):
                temp_model = GetUserResponseBodyDeptOrderSet()
                self.dept_order_set.append(temp_model.from_map(k))
        if m.get('extension') is not None:
            self.extension = m.get('extension')
        if m.get('hiredDate') is not None:
            self.hired_date = m.get('hiredDate')
        if m.get('active') is not None:
            self.active = m.get('active')
        if m.get('realAuthed') is not None:
            self.real_authed = m.get('realAuthed')
        if m.get('senior') is not None:
            self.senior = m.get('senior')
        if m.get('admin') is not None:
            self.admin = m.get('admin')
        if m.get('boss') is not None:
            self.boss = m.get('boss')
        if m.get('exclusiveAccount') is not None:
            self.exclusive_account = m.get('exclusiveAccount')
        if m.get('exclusiveAccountType') is not None:
            self.exclusive_account_type = m.get('exclusiveAccountType')
        self.leader_in_dept = []
        if m.get('leaderInDept') is not None:
            for k in m.get('leaderInDept'):
                temp_model = GetUserResponseBodyLeaderInDept()
                self.leader_in_dept.append(temp_model.from_map(k))
        self.role_list = []
        if m.get('roleList') is not None:
            for k in m.get('roleList'):
                temp_model = GetUserResponseBodyRoleList()
                self.role_list.append(temp_model.from_map(k))
        if m.get('unionEmpExt') is not None:
            temp_model = GetUserResponseBodyUnionEmpExt()
            self.union_emp_ext = temp_model.from_map(m['unionEmpExt'])
        if m.get('managerUserId') is not None:
            self.manager_user_id = m.get('managerUserId')
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


class ListDeptUsersHeaders(TeaModel):
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


class ListDeptUsersRequest(TeaModel):
    def __init__(
        self,
        cursor: int = None,
        size: int = None,
        contain_access_limit: bool = None,
        sub_corp_id: str = None,
        language: str = None,
        order_field: str = None,
    ):
        # cursor
        self.cursor = cursor
        # size
        self.size = size
        # containAccessLimit
        self.contain_access_limit = contain_access_limit
        # subCorpId
        self.sub_corp_id = sub_corp_id
        # language
        self.language = language
        # orderField
        self.order_field = order_field

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cursor is not None:
            result['cursor'] = self.cursor
        if self.size is not None:
            result['size'] = self.size
        if self.contain_access_limit is not None:
            result['containAccessLimit'] = self.contain_access_limit
        if self.sub_corp_id is not None:
            result['subCorpId'] = self.sub_corp_id
        if self.language is not None:
            result['language'] = self.language
        if self.order_field is not None:
            result['orderField'] = self.order_field
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cursor') is not None:
            self.cursor = m.get('cursor')
        if m.get('size') is not None:
            self.size = m.get('size')
        if m.get('containAccessLimit') is not None:
            self.contain_access_limit = m.get('containAccessLimit')
        if m.get('subCorpId') is not None:
            self.sub_corp_id = m.get('subCorpId')
        if m.get('language') is not None:
            self.language = m.get('language')
        if m.get('orderField') is not None:
            self.order_field = m.get('orderField')
        return self


class ListDeptUsersResponseBodyList(TeaModel):
    def __init__(
        self,
        user_id: str = None,
        union_id: str = None,
        job_number: str = None,
        name: str = None,
        dept_id_list: List[int] = None,
        active: bool = None,
    ):
        self.user_id = user_id
        self.union_id = union_id
        self.job_number = job_number
        self.name = name
        self.dept_id_list = dept_id_list
        self.active = active

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.job_number is not None:
            result['jobNumber'] = self.job_number
        if self.name is not None:
            result['name'] = self.name
        if self.dept_id_list is not None:
            result['deptIdList'] = self.dept_id_list
        if self.active is not None:
            result['active'] = self.active
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('jobNumber') is not None:
            self.job_number = m.get('jobNumber')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('deptIdList') is not None:
            self.dept_id_list = m.get('deptIdList')
        if m.get('active') is not None:
            self.active = m.get('active')
        return self


class ListDeptUsersResponseBody(TeaModel):
    def __init__(
        self,
        list: List[ListDeptUsersResponseBodyList] = None,
        next_cursor: int = None,
        has_more: bool = None,
    ):
        self.list = list
        self.next_cursor = next_cursor
        self.has_more = has_more

    def validate(self):
        if self.list:
            for k in self.list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        if self.next_cursor is not None:
            result['nextCursor'] = self.next_cursor
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = ListDeptUsersResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextCursor') is not None:
            self.next_cursor = m.get('nextCursor')
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        return self


class ListDeptUsersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListDeptUsersResponseBody = None,
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
            temp_model = ListDeptUsersResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListResidentUserInfosHeaders(TeaModel):
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


class ListResidentUserInfosRequest(TeaModel):
    def __init__(
        self,
        sub_corp_id: str = None,
        user_ids: List[str] = None,
    ):
        # 真实请求的组织corpId
        self.sub_corp_id = sub_corp_id
        # 用户id列表
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.sub_corp_id is not None:
            result['subCorpId'] = self.sub_corp_id
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('subCorpId') is not None:
            self.sub_corp_id = m.get('subCorpId')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class ListResidentUserInfosShrinkRequest(TeaModel):
    def __init__(
        self,
        sub_corp_id: str = None,
        user_ids_shrink: str = None,
    ):
        # 真实请求的组织corpId
        self.sub_corp_id = sub_corp_id
        # 用户id列表
        self.user_ids_shrink = user_ids_shrink

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.sub_corp_id is not None:
            result['subCorpId'] = self.sub_corp_id
        if self.user_ids_shrink is not None:
            result['userIds'] = self.user_ids_shrink
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('subCorpId') is not None:
            self.sub_corp_id = m.get('subCorpId')
        if m.get('userIds') is not None:
            self.user_ids_shrink = m.get('userIds')
        return self


class ListResidentUserInfosResponseBodyResultRoles(TeaModel):
    def __init__(
        self,
        id: int = None,
        name: str = None,
        tag_code: str = None,
    ):
        # 标签id
        self.id = id
        # 标签名称
        self.name = name
        # 标签名称 tagCode
        self.tag_code = tag_code

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
        if self.tag_code is not None:
            result['tagCode'] = self.tag_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('tagCode') is not None:
            self.tag_code = m.get('tagCode')
        return self


class ListResidentUserInfosResponseBodyResult(TeaModel):
    def __init__(
        self,
        userid: str = None,
        name: str = None,
        roles: List[ListResidentUserInfosResponseBodyResultRoles] = None,
        feature: str = None,
        union_id: str = None,
    ):
        # 员工id
        self.userid = userid
        # 员工名字
        self.name = name
        # 标签列表
        self.roles = roles
        # 员工特征
        self.feature = feature
        # 钉钉唯一标识
        self.union_id = union_id

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
        if self.userid is not None:
            result['userid'] = self.userid
        if self.name is not None:
            result['name'] = self.name
        result['roles'] = []
        if self.roles is not None:
            for k in self.roles:
                result['roles'].append(k.to_map() if k else None)
        if self.feature is not None:
            result['feature'] = self.feature
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userid') is not None:
            self.userid = m.get('userid')
        if m.get('name') is not None:
            self.name = m.get('name')
        self.roles = []
        if m.get('roles') is not None:
            for k in m.get('roles'):
                temp_model = ListResidentUserInfosResponseBodyResultRoles()
                self.roles.append(temp_model.from_map(k))
        if m.get('feature') is not None:
            self.feature = m.get('feature')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class ListResidentUserInfosResponseBody(TeaModel):
    def __init__(
        self,
        result: List[ListResidentUserInfosResponseBodyResult] = None,
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
                temp_model = ListResidentUserInfosResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class ListResidentUserInfosResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListResidentUserInfosResponseBody = None,
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
            temp_model = ListResidentUserInfosResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListSubDeptIdsHeaders(TeaModel):
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


class ListSubDeptIdsRequest(TeaModel):
    def __init__(
        self,
        sub_corp_id: str = None,
    ):
        # 真实请求的组织corpId
        self.sub_corp_id = sub_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.sub_corp_id is not None:
            result['subCorpId'] = self.sub_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('subCorpId') is not None:
            self.sub_corp_id = m.get('subCorpId')
        return self


class ListSubDeptIdsResponseBody(TeaModel):
    def __init__(
        self,
        dept_id_list: List[int] = None,
    ):
        # 部门ID列表
        self.dept_id_list = dept_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id_list is not None:
            result['deptIdList'] = self.dept_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptIdList') is not None:
            self.dept_id_list = m.get('deptIdList')
        return self


class ListSubDeptIdsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListSubDeptIdsResponseBody = None,
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
            temp_model = ListSubDeptIdsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


