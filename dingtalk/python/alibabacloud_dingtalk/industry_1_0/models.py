# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List, Any


class CampusAddRenterMemberHeaders(TeaModel):
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


class CampusAddRenterMemberRequest(TeaModel):
    def __init__(
        self,
        extend: str = None,
        mobile: str = None,
        name: str = None,
        renter_id: int = None,
        type: str = None,
    ):
        # 扩展字段
        self.extend = extend
        # 手机号
        self.mobile = mobile
        # 名字
        self.name = name
        # 租客id
        self.renter_id = renter_id
        # 类型
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.extend is not None:
            result['extend'] = self.extend
        if self.mobile is not None:
            result['mobile'] = self.mobile
        if self.name is not None:
            result['name'] = self.name
        if self.renter_id is not None:
            result['renterId'] = self.renter_id
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('extend') is not None:
            self.extend = m.get('extend')
        if m.get('mobile') is not None:
            self.mobile = m.get('mobile')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('renterId') is not None:
            self.renter_id = m.get('renterId')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class CampusAddRenterMemberResponseBody(TeaModel):
    def __init__(
        self,
        union_id: str = None,
        user_id: str = None,
        user_state: str = None,
    ):
        self.union_id = union_id
        self.user_id = user_id
        self.user_state = user_state

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.user_state is not None:
            result['userState'] = self.user_state
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('userState') is not None:
            self.user_state = m.get('userState')
        return self


class CampusAddRenterMemberResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CampusAddRenterMemberResponseBody = None,
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
            temp_model = CampusAddRenterMemberResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CampusCreateCampusHeaders(TeaModel):
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


class CampusCreateCampusRequest(TeaModel):
    def __init__(
        self,
        address: str = None,
        area: float = None,
        belong_project_group_id: int = None,
        campus_name: str = None,
        capacity: int = None,
        city_id: int = None,
        country: str = None,
        county_id: int = None,
        creator_union_id: str = None,
        description: str = None,
        extend: str = None,
        order_info: int = None,
        order_start_time: int = None,
        prov_id: int = None,
        telephone: str = None,
    ):
        # 园区所在详细地址
        self.address = address
        # 园区面积
        self.area = area
        # 归属项目组
        self.belong_project_group_id = belong_project_group_id
        # 园区项目名
        self.campus_name = campus_name
        # 园区容量
        self.capacity = capacity
        # 园区所在市行政编码
        self.city_id = city_id
        # 园区所在国家
        self.country = country
        # 园区所在区行政编码
        self.county_id = county_id
        # 创建人的unionId
        self.creator_union_id = creator_union_id
        # 园区项目描述
        self.description = description
        # 扩展字段
        self.extend = extend
        # 项目订购结束时间
        self.order_info = order_info
        # 项目订购开始时间
        self.order_start_time = order_start_time
        # 园区所在省行政编码
        self.prov_id = prov_id
        # 联系电话
        self.telephone = telephone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.address is not None:
            result['address'] = self.address
        if self.area is not None:
            result['area'] = self.area
        if self.belong_project_group_id is not None:
            result['belongProjectGroupId'] = self.belong_project_group_id
        if self.campus_name is not None:
            result['campusName'] = self.campus_name
        if self.capacity is not None:
            result['capacity'] = self.capacity
        if self.city_id is not None:
            result['cityId'] = self.city_id
        if self.country is not None:
            result['country'] = self.country
        if self.county_id is not None:
            result['countyId'] = self.county_id
        if self.creator_union_id is not None:
            result['creatorUnionId'] = self.creator_union_id
        if self.description is not None:
            result['description'] = self.description
        if self.extend is not None:
            result['extend'] = self.extend
        if self.order_info is not None:
            result['orderInfo'] = self.order_info
        if self.order_start_time is not None:
            result['orderStartTime'] = self.order_start_time
        if self.prov_id is not None:
            result['provId'] = self.prov_id
        if self.telephone is not None:
            result['telephone'] = self.telephone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('address') is not None:
            self.address = m.get('address')
        if m.get('area') is not None:
            self.area = m.get('area')
        if m.get('belongProjectGroupId') is not None:
            self.belong_project_group_id = m.get('belongProjectGroupId')
        if m.get('campusName') is not None:
            self.campus_name = m.get('campusName')
        if m.get('capacity') is not None:
            self.capacity = m.get('capacity')
        if m.get('cityId') is not None:
            self.city_id = m.get('cityId')
        if m.get('country') is not None:
            self.country = m.get('country')
        if m.get('countyId') is not None:
            self.county_id = m.get('countyId')
        if m.get('creatorUnionId') is not None:
            self.creator_union_id = m.get('creatorUnionId')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('extend') is not None:
            self.extend = m.get('extend')
        if m.get('orderInfo') is not None:
            self.order_info = m.get('orderInfo')
        if m.get('orderStartTime') is not None:
            self.order_start_time = m.get('orderStartTime')
        if m.get('provId') is not None:
            self.prov_id = m.get('provId')
        if m.get('telephone') is not None:
            self.telephone = m.get('telephone')
        return self


class CampusCreateCampusResponseBody(TeaModel):
    def __init__(
        self,
        campus_corp_id: str = None,
        campus_dept_id: str = None,
    ):
        # 园区组织ID
        self.campus_corp_id = campus_corp_id
        # 园区部门ID
        self.campus_dept_id = campus_dept_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.campus_corp_id is not None:
            result['campusCorpId'] = self.campus_corp_id
        if self.campus_dept_id is not None:
            result['campusDeptId'] = self.campus_dept_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('campusCorpId') is not None:
            self.campus_corp_id = m.get('campusCorpId')
        if m.get('campusDeptId') is not None:
            self.campus_dept_id = m.get('campusDeptId')
        return self


class CampusCreateCampusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CampusCreateCampusResponseBody = None,
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
            temp_model = CampusCreateCampusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CampusCreateCampusGroupHeaders(TeaModel):
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


class CampusCreateCampusGroupRequest(TeaModel):
    def __init__(
        self,
        extend: str = None,
        name: str = None,
    ):
        # 扩展信息
        self.extend = extend
        # 园区项目组
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.extend is not None:
            result['extend'] = self.extend
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('extend') is not None:
            self.extend = m.get('extend')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class CampusCreateCampusGroupResponseBody(TeaModel):
    def __init__(
        self,
        content: int = None,
    ):
        # 项目组ID
        self.content = content

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        return self


class CampusCreateCampusGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CampusCreateCampusGroupResponseBody = None,
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
            temp_model = CampusCreateCampusGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CampusCreateRenterHeaders(TeaModel):
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


class CampusCreateRenterRequest(TeaModel):
    def __init__(
        self,
        credit_code: str = None,
        end_time: int = None,
        extend: str = None,
        name: str = None,
        start_time: int = None,
        state: int = None,
    ):
        # 企业信用代码
        self.credit_code = credit_code
        # 租期结束时间
        self.end_time = end_time
        # 扩展信息
        self.extend = extend
        # 租客名称
        self.name = name
        # 租期开始时间
        self.start_time = start_time
        # 状态
        self.state = state

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.credit_code is not None:
            result['creditCode'] = self.credit_code
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.extend is not None:
            result['extend'] = self.extend
        if self.name is not None:
            result['name'] = self.name
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.state is not None:
            result['state'] = self.state
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('creditCode') is not None:
            self.credit_code = m.get('creditCode')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('extend') is not None:
            self.extend = m.get('extend')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('state') is not None:
            self.state = m.get('state')
        return self


class CampusCreateRenterResponseBody(TeaModel):
    def __init__(
        self,
        renter_id: str = None,
    ):
        # 租客ID
        self.renter_id = renter_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.renter_id is not None:
            result['renterId'] = self.renter_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('renterId') is not None:
            self.renter_id = m.get('renterId')
        return self


class CampusCreateRenterResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CampusCreateRenterResponseBody = None,
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
            temp_model = CampusCreateRenterResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CampusDelRenterMemberHeaders(TeaModel):
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


class CampusDelRenterMemberRequest(TeaModel):
    def __init__(
        self,
        renter_id: int = None,
        union_id: str = None,
    ):
        # 租客唯一id
        self.renter_id = renter_id
        # 人员唯一标识
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.renter_id is not None:
            result['renterId'] = self.renter_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('renterId') is not None:
            self.renter_id = m.get('renterId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class CampusDelRenterMemberResponseBody(TeaModel):
    def __init__(
        self,
        content: str = None,
    ):
        self.content = content

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        return self


class CampusDelRenterMemberResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CampusDelRenterMemberResponseBody = None,
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
            temp_model = CampusDelRenterMemberResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CampusDeleteCampusGroupHeaders(TeaModel):
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


class CampusDeleteCampusGroupRequest(TeaModel):
    def __init__(
        self,
        campus_project_group_id: int = None,
    ):
        # 园区项目组ID
        self.campus_project_group_id = campus_project_group_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.campus_project_group_id is not None:
            result['campusProjectGroupId'] = self.campus_project_group_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('campusProjectGroupId') is not None:
            self.campus_project_group_id = m.get('campusProjectGroupId')
        return self


class CampusDeleteCampusGroupResponseBody(TeaModel):
    def __init__(
        self,
        content: str = None,
    ):
        # result
        self.content = content

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        return self


class CampusDeleteCampusGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CampusDeleteCampusGroupResponseBody = None,
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
            temp_model = CampusDeleteCampusGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CampusDeleteRenterHeaders(TeaModel):
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


class CampusDeleteRenterRequest(TeaModel):
    def __init__(
        self,
        renter_id: int = None,
    ):
        # 租客ID
        self.renter_id = renter_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.renter_id is not None:
            result['renterId'] = self.renter_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('renterId') is not None:
            self.renter_id = m.get('renterId')
        return self


class CampusDeleteRenterResponse(TeaModel):
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


class CampusGetCampusHeaders(TeaModel):
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


class CampusGetCampusRequest(TeaModel):
    def __init__(
        self,
        campus_dept_id: int = None,
    ):
        # 园区部门ID
        self.campus_dept_id = campus_dept_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.campus_dept_id is not None:
            result['campusDeptId'] = self.campus_dept_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('campusDeptId') is not None:
            self.campus_dept_id = m.get('campusDeptId')
        return self


class CampusGetCampusResponseBody(TeaModel):
    def __init__(
        self,
        address: str = None,
        area: float = None,
        belong_project_group_id: str = None,
        campus_corp_id: str = None,
        campus_dept_id: int = None,
        campus_name: str = None,
        capacity: str = None,
        city_id: int = None,
        country: str = None,
        county_id: int = None,
        description: str = None,
        extend: str = None,
        location: str = None,
        order_end_time: int = None,
        order_info: str = None,
        order_start_time: int = None,
        prov_id: int = None,
        telephone: str = None,
    ):
        # 详细地址
        self.address = address
        # 面积
        self.area = area
        # 项目组ID
        self.belong_project_group_id = belong_project_group_id
        # 园区组织ID
        self.campus_corp_id = campus_corp_id
        # 园区部门ID
        self.campus_dept_id = campus_dept_id
        # 园区名称
        self.campus_name = campus_name
        # 容纳人数
        self.capacity = capacity
        # 市
        self.city_id = city_id
        # 国家
        self.country = country
        # 区
        self.county_id = county_id
        # 描述
        self.description = description
        # 扩展属性
        self.extend = extend
        # 经纬度
        self.location = location
        # 过期时间
        self.order_end_time = order_end_time
        # 购买信息
        self.order_info = order_info
        # 订购时间
        self.order_start_time = order_start_time
        # 省
        self.prov_id = prov_id
        # 电话
        self.telephone = telephone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.address is not None:
            result['address'] = self.address
        if self.area is not None:
            result['area'] = self.area
        if self.belong_project_group_id is not None:
            result['belongProjectGroupId'] = self.belong_project_group_id
        if self.campus_corp_id is not None:
            result['campusCorpId'] = self.campus_corp_id
        if self.campus_dept_id is not None:
            result['campusDeptId'] = self.campus_dept_id
        if self.campus_name is not None:
            result['campusName'] = self.campus_name
        if self.capacity is not None:
            result['capacity'] = self.capacity
        if self.city_id is not None:
            result['cityId'] = self.city_id
        if self.country is not None:
            result['country'] = self.country
        if self.county_id is not None:
            result['countyId'] = self.county_id
        if self.description is not None:
            result['description'] = self.description
        if self.extend is not None:
            result['extend'] = self.extend
        if self.location is not None:
            result['location'] = self.location
        if self.order_end_time is not None:
            result['orderEndTime'] = self.order_end_time
        if self.order_info is not None:
            result['orderInfo'] = self.order_info
        if self.order_start_time is not None:
            result['orderStartTime'] = self.order_start_time
        if self.prov_id is not None:
            result['provId'] = self.prov_id
        if self.telephone is not None:
            result['telephone'] = self.telephone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('address') is not None:
            self.address = m.get('address')
        if m.get('area') is not None:
            self.area = m.get('area')
        if m.get('belongProjectGroupId') is not None:
            self.belong_project_group_id = m.get('belongProjectGroupId')
        if m.get('campusCorpId') is not None:
            self.campus_corp_id = m.get('campusCorpId')
        if m.get('campusDeptId') is not None:
            self.campus_dept_id = m.get('campusDeptId')
        if m.get('campusName') is not None:
            self.campus_name = m.get('campusName')
        if m.get('capacity') is not None:
            self.capacity = m.get('capacity')
        if m.get('cityId') is not None:
            self.city_id = m.get('cityId')
        if m.get('country') is not None:
            self.country = m.get('country')
        if m.get('countyId') is not None:
            self.county_id = m.get('countyId')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('extend') is not None:
            self.extend = m.get('extend')
        if m.get('location') is not None:
            self.location = m.get('location')
        if m.get('orderEndTime') is not None:
            self.order_end_time = m.get('orderEndTime')
        if m.get('orderInfo') is not None:
            self.order_info = m.get('orderInfo')
        if m.get('orderStartTime') is not None:
            self.order_start_time = m.get('orderStartTime')
        if m.get('provId') is not None:
            self.prov_id = m.get('provId')
        if m.get('telephone') is not None:
            self.telephone = m.get('telephone')
        return self


class CampusGetCampusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CampusGetCampusResponseBody = None,
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
            temp_model = CampusGetCampusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CampusGetCampusGroupHeaders(TeaModel):
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


class CampusGetCampusGroupRequest(TeaModel):
    def __init__(
        self,
        group_id: int = None,
    ):
        # 项目组ID
        self.group_id = group_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_id is not None:
            result['groupId'] = self.group_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupId') is not None:
            self.group_id = m.get('groupId')
        return self


class CampusGetCampusGroupResponseBody(TeaModel):
    def __init__(
        self,
        extend: str = None,
        project_group_name: str = None,
    ):
        # 扩展信息
        self.extend = extend
        # 项目名
        self.project_group_name = project_group_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.extend is not None:
            result['extend'] = self.extend
        if self.project_group_name is not None:
            result['projectGroupName'] = self.project_group_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('extend') is not None:
            self.extend = m.get('extend')
        if m.get('projectGroupName') is not None:
            self.project_group_name = m.get('projectGroupName')
        return self


class CampusGetCampusGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CampusGetCampusGroupResponseBody = None,
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
            temp_model = CampusGetCampusGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CampusGetRenterHeaders(TeaModel):
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


class CampusGetRenterRequest(TeaModel):
    def __init__(
        self,
        renter_id: int = None,
    ):
        # 租客ID
        self.renter_id = renter_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.renter_id is not None:
            result['renterId'] = self.renter_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('renterId') is not None:
            self.renter_id = m.get('renterId')
        return self


class CampusGetRenterResponseBody(TeaModel):
    def __init__(
        self,
        bind_renter_corp_id: str = None,
        bind_time: int = None,
        credit_code: str = None,
        end_time: int = None,
        extend: str = None,
        name: str = None,
        renter_dept_id: int = None,
        start_time: int = None,
        state: int = None,
    ):
        # 绑定组织
        self.bind_renter_corp_id = bind_renter_corp_id
        # 绑定时间
        self.bind_time = bind_time
        # 企业信用代码
        self.credit_code = credit_code
        # 结束时间
        self.end_time = end_time
        # 扩展信息
        self.extend = extend
        # 租客名称
        self.name = name
        # 部门iD
        self.renter_dept_id = renter_dept_id
        # 开始时间
        self.start_time = start_time
        # 状态
        self.state = state

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.bind_renter_corp_id is not None:
            result['bindRenterCorpId'] = self.bind_renter_corp_id
        if self.bind_time is not None:
            result['bindTime'] = self.bind_time
        if self.credit_code is not None:
            result['creditCode'] = self.credit_code
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.extend is not None:
            result['extend'] = self.extend
        if self.name is not None:
            result['name'] = self.name
        if self.renter_dept_id is not None:
            result['renterDeptId'] = self.renter_dept_id
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.state is not None:
            result['state'] = self.state
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bindRenterCorpId') is not None:
            self.bind_renter_corp_id = m.get('bindRenterCorpId')
        if m.get('bindTime') is not None:
            self.bind_time = m.get('bindTime')
        if m.get('creditCode') is not None:
            self.credit_code = m.get('creditCode')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('extend') is not None:
            self.extend = m.get('extend')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('renterDeptId') is not None:
            self.renter_dept_id = m.get('renterDeptId')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('state') is not None:
            self.state = m.get('state')
        return self


class CampusGetRenterResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CampusGetRenterResponseBody = None,
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
            temp_model = CampusGetRenterResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CampusGetRenterMemberHeaders(TeaModel):
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


class CampusGetRenterMemberRequest(TeaModel):
    def __init__(
        self,
        renter_id: int = None,
        union_id: str = None,
    ):
        # 租客id
        self.renter_id = renter_id
        # 用户ID
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.renter_id is not None:
            result['renterId'] = self.renter_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('renterId') is not None:
            self.renter_id = m.get('renterId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class CampusGetRenterMemberResponseBody(TeaModel):
    def __init__(
        self,
        extend: str = None,
        invite_state: int = None,
        name: str = None,
        state: str = None,
        type: str = None,
        user_id: str = None,
    ):
        self.extend = extend
        self.invite_state = invite_state
        self.name = name
        self.state = state
        self.type = type
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.extend is not None:
            result['extend'] = self.extend
        if self.invite_state is not None:
            result['inviteState'] = self.invite_state
        if self.name is not None:
            result['name'] = self.name
        if self.state is not None:
            result['state'] = self.state
        if self.type is not None:
            result['type'] = self.type
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('extend') is not None:
            self.extend = m.get('extend')
        if m.get('inviteState') is not None:
            self.invite_state = m.get('inviteState')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('state') is not None:
            self.state = m.get('state')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CampusGetRenterMemberResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CampusGetRenterMemberResponseBody = None,
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
            temp_model = CampusGetRenterMemberResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CampusListCampusHeaders(TeaModel):
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


class CampusListCampusRequest(TeaModel):
    def __init__(
        self,
        group_dept_id: int = None,
    ):
        # 项目组ID
        self.group_dept_id = group_dept_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_dept_id is not None:
            result['groupDeptId'] = self.group_dept_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupDeptId') is not None:
            self.group_dept_id = m.get('groupDeptId')
        return self


class CampusListCampusResponseBodyResult(TeaModel):
    def __init__(
        self,
        address: str = None,
        area: float = None,
        belong_project_group_id: int = None,
        campus_corp_id: str = None,
        campus_dept_id: int = None,
        campus_name: str = None,
        city_id: int = None,
        country: str = None,
        county_id: int = None,
        description: str = None,
        extend: str = None,
        location: str = None,
        order_end_time: int = None,
        order_info: str = None,
        order_start_time: int = None,
        prov_id: int = None,
        telephone: str = None,
    ):
        # 地址
        self.address = address
        # 面积
        self.area = area
        # 项目组ID
        self.belong_project_group_id = belong_project_group_id
        # 园区组织ID
        self.campus_corp_id = campus_corp_id
        # 园区部门ID
        self.campus_dept_id = campus_dept_id
        # 园区名称
        self.campus_name = campus_name
        # 市
        self.city_id = city_id
        # 国家
        self.country = country
        # 区
        self.county_id = county_id
        # 描述
        self.description = description
        # 扩展信息
        self.extend = extend
        # 经纬度
        self.location = location
        # 结束时间
        self.order_end_time = order_end_time
        # 订购信息
        self.order_info = order_info
        # 订购时间
        self.order_start_time = order_start_time
        # 省
        self.prov_id = prov_id
        # 手机号
        self.telephone = telephone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.address is not None:
            result['address'] = self.address
        if self.area is not None:
            result['area'] = self.area
        if self.belong_project_group_id is not None:
            result['belongProjectGroupId'] = self.belong_project_group_id
        if self.campus_corp_id is not None:
            result['campusCorpId'] = self.campus_corp_id
        if self.campus_dept_id is not None:
            result['campusDeptId'] = self.campus_dept_id
        if self.campus_name is not None:
            result['campusName'] = self.campus_name
        if self.city_id is not None:
            result['cityId'] = self.city_id
        if self.country is not None:
            result['country'] = self.country
        if self.county_id is not None:
            result['countyId'] = self.county_id
        if self.description is not None:
            result['description'] = self.description
        if self.extend is not None:
            result['extend'] = self.extend
        if self.location is not None:
            result['location'] = self.location
        if self.order_end_time is not None:
            result['orderEndTime'] = self.order_end_time
        if self.order_info is not None:
            result['orderInfo'] = self.order_info
        if self.order_start_time is not None:
            result['orderStartTime'] = self.order_start_time
        if self.prov_id is not None:
            result['provId'] = self.prov_id
        if self.telephone is not None:
            result['telephone'] = self.telephone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('address') is not None:
            self.address = m.get('address')
        if m.get('area') is not None:
            self.area = m.get('area')
        if m.get('belongProjectGroupId') is not None:
            self.belong_project_group_id = m.get('belongProjectGroupId')
        if m.get('campusCorpId') is not None:
            self.campus_corp_id = m.get('campusCorpId')
        if m.get('campusDeptId') is not None:
            self.campus_dept_id = m.get('campusDeptId')
        if m.get('campusName') is not None:
            self.campus_name = m.get('campusName')
        if m.get('cityId') is not None:
            self.city_id = m.get('cityId')
        if m.get('country') is not None:
            self.country = m.get('country')
        if m.get('countyId') is not None:
            self.county_id = m.get('countyId')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('extend') is not None:
            self.extend = m.get('extend')
        if m.get('location') is not None:
            self.location = m.get('location')
        if m.get('orderEndTime') is not None:
            self.order_end_time = m.get('orderEndTime')
        if m.get('orderInfo') is not None:
            self.order_info = m.get('orderInfo')
        if m.get('orderStartTime') is not None:
            self.order_start_time = m.get('orderStartTime')
        if m.get('provId') is not None:
            self.prov_id = m.get('provId')
        if m.get('telephone') is not None:
            self.telephone = m.get('telephone')
        return self


class CampusListCampusResponseBody(TeaModel):
    def __init__(
        self,
        result: List[CampusListCampusResponseBodyResult] = None,
    ):
        # 返回信息
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
                temp_model = CampusListCampusResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class CampusListCampusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CampusListCampusResponseBody = None,
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
            temp_model = CampusListCampusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CampusListCampusGroupHeaders(TeaModel):
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


class CampusListCampusGroupResponseBodyResult(TeaModel):
    def __init__(
        self,
        extend: str = None,
        group_dept_id: int = None,
        group_name: str = None,
    ):
        # 扩展信息
        self.extend = extend
        # 项目组ID
        self.group_dept_id = group_dept_id
        # 项目组名称
        self.group_name = group_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.extend is not None:
            result['extend'] = self.extend
        if self.group_dept_id is not None:
            result['groupDeptId'] = self.group_dept_id
        if self.group_name is not None:
            result['groupName'] = self.group_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('extend') is not None:
            self.extend = m.get('extend')
        if m.get('groupDeptId') is not None:
            self.group_dept_id = m.get('groupDeptId')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        return self


class CampusListCampusGroupResponseBody(TeaModel):
    def __init__(
        self,
        result: List[CampusListCampusGroupResponseBodyResult] = None,
    ):
        # 返回项目组
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
                temp_model = CampusListCampusGroupResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class CampusListCampusGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CampusListCampusGroupResponseBody = None,
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
            temp_model = CampusListCampusGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CampusListRenterHeaders(TeaModel):
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


class CampusListRenterResponseBodyResult(TeaModel):
    def __init__(
        self,
        bind_renter_corp_id: str = None,
        bind_time: int = None,
        credit_code: str = None,
        end_time: int = None,
        extend: str = None,
        name: str = None,
        renter_dept_id: int = None,
        start_time: int = None,
        state: int = None,
    ):
        # 绑定钉钉组织ID
        self.bind_renter_corp_id = bind_renter_corp_id
        # 绑定时间
        self.bind_time = bind_time
        # 企业信用代码
        self.credit_code = credit_code
        # 到期时间
        self.end_time = end_time
        # 扩展信息
        self.extend = extend
        # 租客名称
        self.name = name
        # 租客部门ID
        self.renter_dept_id = renter_dept_id
        # 起始时间
        self.start_time = start_time
        # 状态
        self.state = state

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.bind_renter_corp_id is not None:
            result['bindRenterCorpId'] = self.bind_renter_corp_id
        if self.bind_time is not None:
            result['bindTime'] = self.bind_time
        if self.credit_code is not None:
            result['creditCode'] = self.credit_code
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.extend is not None:
            result['extend'] = self.extend
        if self.name is not None:
            result['name'] = self.name
        if self.renter_dept_id is not None:
            result['renterDeptId'] = self.renter_dept_id
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.state is not None:
            result['state'] = self.state
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bindRenterCorpId') is not None:
            self.bind_renter_corp_id = m.get('bindRenterCorpId')
        if m.get('bindTime') is not None:
            self.bind_time = m.get('bindTime')
        if m.get('creditCode') is not None:
            self.credit_code = m.get('creditCode')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('extend') is not None:
            self.extend = m.get('extend')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('renterDeptId') is not None:
            self.renter_dept_id = m.get('renterDeptId')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('state') is not None:
            self.state = m.get('state')
        return self


class CampusListRenterResponseBody(TeaModel):
    def __init__(
        self,
        result: List[CampusListRenterResponseBodyResult] = None,
    ):
        # 租客列表
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
                temp_model = CampusListRenterResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class CampusListRenterResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CampusListRenterResponseBody = None,
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
            temp_model = CampusListRenterResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CampusListRenterMembersHeaders(TeaModel):
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


class CampusListRenterMembersRequest(TeaModel):
    def __init__(
        self,
        renter_id: int = None,
    ):
        # 租客id
        self.renter_id = renter_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.renter_id is not None:
            result['renterId'] = self.renter_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('renterId') is not None:
            self.renter_id = m.get('renterId')
        return self


class CampusListRenterMembersResponseBodyResult(TeaModel):
    def __init__(
        self,
        extend: str = None,
        invite_state: str = None,
        name: str = None,
        state: str = None,
        type: str = None,
        union_id: str = None,
        user_id: str = None,
    ):
        self.extend = extend
        self.invite_state = invite_state
        self.name = name
        self.state = state
        self.type = type
        self.union_id = union_id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.extend is not None:
            result['extend'] = self.extend
        if self.invite_state is not None:
            result['inviteState'] = self.invite_state
        if self.name is not None:
            result['name'] = self.name
        if self.state is not None:
            result['state'] = self.state
        if self.type is not None:
            result['type'] = self.type
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('extend') is not None:
            self.extend = m.get('extend')
        if m.get('inviteState') is not None:
            self.invite_state = m.get('inviteState')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('state') is not None:
            self.state = m.get('state')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CampusListRenterMembersResponseBody(TeaModel):
    def __init__(
        self,
        result: List[CampusListRenterMembersResponseBodyResult] = None,
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
                temp_model = CampusListRenterMembersResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class CampusListRenterMembersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CampusListRenterMembersResponseBody = None,
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
            temp_model = CampusListRenterMembersResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CampusUpdateCampusHeaders(TeaModel):
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


class CampusUpdateCampusRequest(TeaModel):
    def __init__(
        self,
        address: str = None,
        area: float = None,
        belong_project_group_id: int = None,
        campus_dept_id: int = None,
        campus_name: str = None,
        capacity: int = None,
        city_id: int = None,
        country: str = None,
        county_id: int = None,
        description: str = None,
        extend: str = None,
        order_end_time: int = None,
        order_info: int = None,
        order_start_time: int = None,
        prov_id: int = None,
        telephone: str = None,
    ):
        # 所在具体地址
        self.address = address
        # 面积
        self.area = area
        # 归属项目组
        self.belong_project_group_id = belong_project_group_id
        # 项目部门id
        self.campus_dept_id = campus_dept_id
        # 园区项目名
        self.campus_name = campus_name
        # 容量
        self.capacity = capacity
        # 所在市行政编码
        self.city_id = city_id
        # 国家
        self.country = country
        # 所在区行政编码
        self.county_id = county_id
        # 园区项目描述
        self.description = description
        # 扩展信息
        self.extend = extend
        # 项目订阅到期时间
        self.order_end_time = order_end_time
        # 购买信息
        self.order_info = order_info
        # 项目订阅开始时间
        self.order_start_time = order_start_time
        # 所在省行政编码
        self.prov_id = prov_id
        # 联系电话
        self.telephone = telephone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.address is not None:
            result['address'] = self.address
        if self.area is not None:
            result['area'] = self.area
        if self.belong_project_group_id is not None:
            result['belongProjectGroupId'] = self.belong_project_group_id
        if self.campus_dept_id is not None:
            result['campusDeptId'] = self.campus_dept_id
        if self.campus_name is not None:
            result['campusName'] = self.campus_name
        if self.capacity is not None:
            result['capacity'] = self.capacity
        if self.city_id is not None:
            result['cityId'] = self.city_id
        if self.country is not None:
            result['country'] = self.country
        if self.county_id is not None:
            result['countyId'] = self.county_id
        if self.description is not None:
            result['description'] = self.description
        if self.extend is not None:
            result['extend'] = self.extend
        if self.order_end_time is not None:
            result['orderEndTime'] = self.order_end_time
        if self.order_info is not None:
            result['orderInfo'] = self.order_info
        if self.order_start_time is not None:
            result['orderStartTime'] = self.order_start_time
        if self.prov_id is not None:
            result['provId'] = self.prov_id
        if self.telephone is not None:
            result['telephone'] = self.telephone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('address') is not None:
            self.address = m.get('address')
        if m.get('area') is not None:
            self.area = m.get('area')
        if m.get('belongProjectGroupId') is not None:
            self.belong_project_group_id = m.get('belongProjectGroupId')
        if m.get('campusDeptId') is not None:
            self.campus_dept_id = m.get('campusDeptId')
        if m.get('campusName') is not None:
            self.campus_name = m.get('campusName')
        if m.get('capacity') is not None:
            self.capacity = m.get('capacity')
        if m.get('cityId') is not None:
            self.city_id = m.get('cityId')
        if m.get('country') is not None:
            self.country = m.get('country')
        if m.get('countyId') is not None:
            self.county_id = m.get('countyId')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('extend') is not None:
            self.extend = m.get('extend')
        if m.get('orderEndTime') is not None:
            self.order_end_time = m.get('orderEndTime')
        if m.get('orderInfo') is not None:
            self.order_info = m.get('orderInfo')
        if m.get('orderStartTime') is not None:
            self.order_start_time = m.get('orderStartTime')
        if m.get('provId') is not None:
            self.prov_id = m.get('provId')
        if m.get('telephone') is not None:
            self.telephone = m.get('telephone')
        return self


class CampusUpdateCampusResponseBody(TeaModel):
    def __init__(
        self,
        content: str = None,
    ):
        self.content = content

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        return self


class CampusUpdateCampusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CampusUpdateCampusResponseBody = None,
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
            temp_model = CampusUpdateCampusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CampusUpdateCampusGroupHeaders(TeaModel):
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


class CampusUpdateCampusGroupRequest(TeaModel):
    def __init__(
        self,
        campus_project_group_id: int = None,
        extend: str = None,
        name: str = None,
    ):
        self.campus_project_group_id = campus_project_group_id
        # 扩展信息
        self.extend = extend
        # 项目组名
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.campus_project_group_id is not None:
            result['campusProjectGroupId'] = self.campus_project_group_id
        if self.extend is not None:
            result['extend'] = self.extend
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('campusProjectGroupId') is not None:
            self.campus_project_group_id = m.get('campusProjectGroupId')
        if m.get('extend') is not None:
            self.extend = m.get('extend')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class CampusUpdateCampusGroupResponseBody(TeaModel):
    def __init__(
        self,
        content: str = None,
    ):
        self.content = content

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        return self


class CampusUpdateCampusGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CampusUpdateCampusGroupResponseBody = None,
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
            temp_model = CampusUpdateCampusGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CampusUpdateRenterHeaders(TeaModel):
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


class CampusUpdateRenterRequest(TeaModel):
    def __init__(
        self,
        credit_code: str = None,
        end_time: int = None,
        extend: str = None,
        name: str = None,
        renter_id: int = None,
        start_time: int = None,
        state: int = None,
    ):
        # 企业信用代码
        self.credit_code = credit_code
        # 租期开始时间
        self.end_time = end_time
        # 扩展字段
        self.extend = extend
        # 租客名字
        self.name = name
        # 租客ID
        self.renter_id = renter_id
        # 租期结束时间
        self.start_time = start_time
        # 启用状态
        self.state = state

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.credit_code is not None:
            result['creditCode'] = self.credit_code
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.extend is not None:
            result['extend'] = self.extend
        if self.name is not None:
            result['name'] = self.name
        if self.renter_id is not None:
            result['renterId'] = self.renter_id
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.state is not None:
            result['state'] = self.state
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('creditCode') is not None:
            self.credit_code = m.get('creditCode')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('extend') is not None:
            self.extend = m.get('extend')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('renterId') is not None:
            self.renter_id = m.get('renterId')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('state') is not None:
            self.state = m.get('state')
        return self


class CampusUpdateRenterResponseBody(TeaModel):
    def __init__(
        self,
        renter_id: str = None,
    ):
        # 租客ID
        self.renter_id = renter_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.renter_id is not None:
            result['renterId'] = self.renter_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('renterId') is not None:
            self.renter_id = m.get('renterId')
        return self


class CampusUpdateRenterResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CampusUpdateRenterResponseBody = None,
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
            temp_model = CampusUpdateRenterResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CampusUpdateRenterMemberHeaders(TeaModel):
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


class CampusUpdateRenterMemberRequest(TeaModel):
    def __init__(
        self,
        extend: str = None,
        name: str = None,
        renter_id: int = None,
        type: str = None,
        union_id: str = None,
    ):
        # 扩展字段
        self.extend = extend
        # 名字
        self.name = name
        # 租客id
        self.renter_id = renter_id
        # 类型
        self.type = type
        # 人员唯一标识
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.extend is not None:
            result['extend'] = self.extend
        if self.name is not None:
            result['name'] = self.name
        if self.renter_id is not None:
            result['renterId'] = self.renter_id
        if self.type is not None:
            result['type'] = self.type
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('extend') is not None:
            self.extend = m.get('extend')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('renterId') is not None:
            self.renter_id = m.get('renterId')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class CampusUpdateRenterMemberResponseBody(TeaModel):
    def __init__(
        self,
        content: str = None,
    ):
        self.content = content

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        return self


class CampusUpdateRenterMemberResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CampusUpdateRenterMemberResponseBody = None,
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
            temp_model = CampusUpdateRenterMemberResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CustomizeContactCreateHeaders(TeaModel):
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


class CustomizeContactCreateRequest(TeaModel):
    def __init__(
        self,
        manager_id_list: List[str] = None,
        name: str = None,
        order: int = None,
    ):
        # 通讯录管理员UserId
        self.manager_id_list = manager_id_list
        # 自定义通讯录名称
        self.name = name
        # 在自定义通讯录列表中的排序
        self.order = order

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.manager_id_list is not None:
            result['managerIdList'] = self.manager_id_list
        if self.name is not None:
            result['name'] = self.name
        if self.order is not None:
            result['order'] = self.order
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('managerIdList') is not None:
            self.manager_id_list = m.get('managerIdList')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('order') is not None:
            self.order = m.get('order')
        return self


class CustomizeContactCreateResponseBodyContent(TeaModel):
    def __init__(
        self,
        code: str = None,
        name: str = None,
        order: int = None,
        root_dept_id: int = None,
    ):
        # 自定义通讯录Code
        self.code = code
        # 自定义通讯录名称
        self.name = name
        # 在自定义通讯录列表中的排序
        self.order = order
        # 根部们Id
        self.root_dept_id = root_dept_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.name is not None:
            result['name'] = self.name
        if self.order is not None:
            result['order'] = self.order
        if self.root_dept_id is not None:
            result['rootDeptId'] = self.root_dept_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('order') is not None:
            self.order = m.get('order')
        if m.get('rootDeptId') is not None:
            self.root_dept_id = m.get('rootDeptId')
        return self


class CustomizeContactCreateResponseBody(TeaModel):
    def __init__(
        self,
        content: CustomizeContactCreateResponseBodyContent = None,
    ):
        # 自定义通讯录信息
        self.content = content

    def validate(self):
        if self.content:
            self.content.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            temp_model = CustomizeContactCreateResponseBodyContent()
            self.content = temp_model.from_map(m['content'])
        return self


class CustomizeContactCreateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CustomizeContactCreateResponseBody = None,
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
            temp_model = CustomizeContactCreateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CustomizeContactDeleteHeaders(TeaModel):
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


class CustomizeContactDeleteRequest(TeaModel):
    def __init__(
        self,
        code: str = None,
    ):
        # 自定义通讯录Code
        self.code = code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        return self


class CustomizeContactDeleteResponseBody(TeaModel):
    def __init__(
        self,
        content: bool = None,
    ):
        # 是否操作成功
        self.content = content

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        return self


class CustomizeContactDeleteResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CustomizeContactDeleteResponseBody = None,
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
            temp_model = CustomizeContactDeleteResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CustomizeContactDeptCreateHeaders(TeaModel):
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


class CustomizeContactDeptCreateRequest(TeaModel):
    def __init__(
        self,
        code: str = None,
        manager_id_list: List[str] = None,
        name: str = None,
        order: int = None,
        parent_dept_id: int = None,
        ref_id: int = None,
        type: int = None,
    ):
        # 自定义通讯录Code
        self.code = code
        # 部门主管列表
        self.manager_id_list = manager_id_list
        # 部门名称
        self.name = name
        # 部门排序
        self.order = order
        # 上级部门Id
        self.parent_dept_id = parent_dept_id
        # 引用的内部通讯录部门Id
        self.ref_id = ref_id
        # 部门类型 0:普通部门 1:引用部门
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.manager_id_list is not None:
            result['managerIdList'] = self.manager_id_list
        if self.name is not None:
            result['name'] = self.name
        if self.order is not None:
            result['order'] = self.order
        if self.parent_dept_id is not None:
            result['parentDeptId'] = self.parent_dept_id
        if self.ref_id is not None:
            result['refId'] = self.ref_id
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('managerIdList') is not None:
            self.manager_id_list = m.get('managerIdList')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('order') is not None:
            self.order = m.get('order')
        if m.get('parentDeptId') is not None:
            self.parent_dept_id = m.get('parentDeptId')
        if m.get('refId') is not None:
            self.ref_id = m.get('refId')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class CustomizeContactDeptCreateResponseBody(TeaModel):
    def __init__(
        self,
        content: int = None,
    ):
        # 部门Id
        self.content = content

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        return self


class CustomizeContactDeptCreateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CustomizeContactDeptCreateResponseBody = None,
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
            temp_model = CustomizeContactDeptCreateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CustomizeContactDeptDeleteHeaders(TeaModel):
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


class CustomizeContactDeptDeleteRequest(TeaModel):
    def __init__(
        self,
        code: str = None,
        dept_id: int = None,
    ):
        # 自定义通讯录Code
        self.code = code
        # 部门Id
        self.dept_id = dept_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        return self


class CustomizeContactDeptDeleteResponseBody(TeaModel):
    def __init__(
        self,
        content: bool = None,
    ):
        # 操作结果
        self.content = content

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        return self


class CustomizeContactDeptDeleteResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CustomizeContactDeptDeleteResponseBody = None,
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
            temp_model = CustomizeContactDeptDeleteResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CustomizeContactDeptInfoHeaders(TeaModel):
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


class CustomizeContactDeptInfoRequest(TeaModel):
    def __init__(
        self,
        code: str = None,
        dept_id: int = None,
    ):
        self.code = code
        self.dept_id = dept_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        return self


class CustomizeContactDeptInfoResponseBodyContent(TeaModel):
    def __init__(
        self,
        code: str = None,
        id: int = None,
        manager_id_list: List[str] = None,
        name: str = None,
        order: int = None,
        parent_dept_id: int = None,
        ref_id: int = None,
        type: int = None,
    ):
        # 自定义通讯录Code
        self.code = code
        # 部门Id
        self.id = id
        # 部门主管列表
        self.manager_id_list = manager_id_list
        # 部门名称
        self.name = name
        # 部门排序
        self.order = order
        # 上级部门Id
        self.parent_dept_id = parent_dept_id
        # 引用的内部通讯录部门Id
        self.ref_id = ref_id
        # 部门类型 0:普通部门 1:引用部门
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.id is not None:
            result['id'] = self.id
        if self.manager_id_list is not None:
            result['managerIdList'] = self.manager_id_list
        if self.name is not None:
            result['name'] = self.name
        if self.order is not None:
            result['order'] = self.order
        if self.parent_dept_id is not None:
            result['parentDeptId'] = self.parent_dept_id
        if self.ref_id is not None:
            result['refId'] = self.ref_id
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('managerIdList') is not None:
            self.manager_id_list = m.get('managerIdList')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('order') is not None:
            self.order = m.get('order')
        if m.get('parentDeptId') is not None:
            self.parent_dept_id = m.get('parentDeptId')
        if m.get('refId') is not None:
            self.ref_id = m.get('refId')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class CustomizeContactDeptInfoResponseBody(TeaModel):
    def __init__(
        self,
        content: CustomizeContactDeptInfoResponseBodyContent = None,
    ):
        # 部门信息
        self.content = content

    def validate(self):
        if self.content:
            self.content.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            temp_model = CustomizeContactDeptInfoResponseBodyContent()
            self.content = temp_model.from_map(m['content'])
        return self


class CustomizeContactDeptInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CustomizeContactDeptInfoResponseBody = None,
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
            temp_model = CustomizeContactDeptInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CustomizeContactDeptListHeaders(TeaModel):
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


class CustomizeContactDeptListRequest(TeaModel):
    def __init__(
        self,
        code: str = None,
        dept_id: int = None,
    ):
        # 自定义通讯录Code
        self.code = code
        # 部门Id
        self.dept_id = dept_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        return self


class CustomizeContactDeptListResponseBodyContent(TeaModel):
    def __init__(
        self,
        code: str = None,
        id: int = None,
        manager_id_list: List[str] = None,
        name: str = None,
        order: int = None,
        parent_dept_id: int = None,
        ref_id: int = None,
        type: int = None,
    ):
        # 自定义通讯录Code
        self.code = code
        # 部门Id
        self.id = id
        # 部门主管列表
        self.manager_id_list = manager_id_list
        # 部门名称
        self.name = name
        # 部门排序
        self.order = order
        # 上级部门Id
        self.parent_dept_id = parent_dept_id
        # 引用的内部通讯录部门Id
        self.ref_id = ref_id
        # 部门类型 0:普通部门 1:引用部门
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.id is not None:
            result['id'] = self.id
        if self.manager_id_list is not None:
            result['managerIdList'] = self.manager_id_list
        if self.name is not None:
            result['name'] = self.name
        if self.order is not None:
            result['order'] = self.order
        if self.parent_dept_id is not None:
            result['parentDeptId'] = self.parent_dept_id
        if self.ref_id is not None:
            result['refId'] = self.ref_id
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('managerIdList') is not None:
            self.manager_id_list = m.get('managerIdList')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('order') is not None:
            self.order = m.get('order')
        if m.get('parentDeptId') is not None:
            self.parent_dept_id = m.get('parentDeptId')
        if m.get('refId') is not None:
            self.ref_id = m.get('refId')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class CustomizeContactDeptListResponseBody(TeaModel):
    def __init__(
        self,
        content: List[CustomizeContactDeptListResponseBodyContent] = None,
    ):
        # 子部门列表
        self.content = content

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = CustomizeContactDeptListResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        return self


class CustomizeContactDeptListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CustomizeContactDeptListResponseBody = None,
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
            temp_model = CustomizeContactDeptListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CustomizeContactDeptUpdateHeaders(TeaModel):
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


class CustomizeContactDeptUpdateRequest(TeaModel):
    def __init__(
        self,
        code: str = None,
        dept_id: int = None,
        manager_id_list: List[str] = None,
        name: str = None,
        order: int = None,
        parent_dept_id: int = None,
    ):
        # 自定义通讯录Code
        self.code = code
        # 部门Id
        self.dept_id = dept_id
        # 部门主管列表
        self.manager_id_list = manager_id_list
        # 部门名称
        self.name = name
        # 部门排序
        self.order = order
        # 上级部门Id
        self.parent_dept_id = parent_dept_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.manager_id_list is not None:
            result['managerIdList'] = self.manager_id_list
        if self.name is not None:
            result['name'] = self.name
        if self.order is not None:
            result['order'] = self.order
        if self.parent_dept_id is not None:
            result['parentDeptId'] = self.parent_dept_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('managerIdList') is not None:
            self.manager_id_list = m.get('managerIdList')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('order') is not None:
            self.order = m.get('order')
        if m.get('parentDeptId') is not None:
            self.parent_dept_id = m.get('parentDeptId')
        return self


class CustomizeContactDeptUpdateResponseBody(TeaModel):
    def __init__(
        self,
        content: int = None,
    ):
        # 部门Id
        self.content = content

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        return self


class CustomizeContactDeptUpdateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CustomizeContactDeptUpdateResponseBody = None,
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
            temp_model = CustomizeContactDeptUpdateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CustomizeContactEmpAddHeaders(TeaModel):
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


class CustomizeContactEmpAddRequest(TeaModel):
    def __init__(
        self,
        code: str = None,
        dept_id: int = None,
        user_id_list: List[str] = None,
    ):
        # 自定义通讯录Code
        self.code = code
        # 部门Id
        self.dept_id = dept_id
        # 人员Id列表
        self.user_id_list = user_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.user_id_list is not None:
            result['userIdList'] = self.user_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('userIdList') is not None:
            self.user_id_list = m.get('userIdList')
        return self


class CustomizeContactEmpAddResponseBody(TeaModel):
    def __init__(
        self,
        content: bool = None,
    ):
        # 操作结果
        self.content = content

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        return self


class CustomizeContactEmpAddResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CustomizeContactEmpAddResponseBody = None,
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
            temp_model = CustomizeContactEmpAddResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CustomizeContactEmpDeleteHeaders(TeaModel):
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


class CustomizeContactEmpDeleteRequest(TeaModel):
    def __init__(
        self,
        code: str = None,
        dept_id: int = None,
        user_id_list: List[str] = None,
    ):
        # 自定义通讯录Code
        self.code = code
        # 部门Id
        self.dept_id = dept_id
        # 人员Id列表
        self.user_id_list = user_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.user_id_list is not None:
            result['userIdList'] = self.user_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('userIdList') is not None:
            self.user_id_list = m.get('userIdList')
        return self


class CustomizeContactEmpDeleteResponseBody(TeaModel):
    def __init__(
        self,
        content: bool = None,
    ):
        # 操作结果
        self.content = content

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        return self


class CustomizeContactEmpDeleteResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CustomizeContactEmpDeleteResponseBody = None,
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
            temp_model = CustomizeContactEmpDeleteResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CustomizeContactEmpListHeaders(TeaModel):
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


class CustomizeContactEmpListRequest(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
    ):
        # 部门Id
        self.dept_id = dept_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        return self


class CustomizeContactEmpListResponseBodyContent(TeaModel):
    def __init__(
        self,
        name: str = None,
        user_id: str = None,
    ):
        # 人员姓名
        self.name = name
        # 人员Id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CustomizeContactEmpListResponseBody(TeaModel):
    def __init__(
        self,
        content: List[CustomizeContactEmpListResponseBodyContent] = None,
    ):
        # 人员信息列表
        self.content = content

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = CustomizeContactEmpListResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        return self


class CustomizeContactEmpListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CustomizeContactEmpListResponseBody = None,
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
            temp_model = CustomizeContactEmpListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CustomizeContactListHeaders(TeaModel):
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


class CustomizeContactListResponseBodyContent(TeaModel):
    def __init__(
        self,
        code: str = None,
        name: str = None,
        order: int = None,
        root_dept_id: int = None,
    ):
        # 自定义通讯录Code
        self.code = code
        # 自定义通讯录名称
        self.name = name
        # 自定义通讯录排序
        self.order = order
        # 跟部门Id
        self.root_dept_id = root_dept_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.name is not None:
            result['name'] = self.name
        if self.order is not None:
            result['order'] = self.order
        if self.root_dept_id is not None:
            result['rootDeptId'] = self.root_dept_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('order') is not None:
            self.order = m.get('order')
        if m.get('rootDeptId') is not None:
            self.root_dept_id = m.get('rootDeptId')
        return self


class CustomizeContactListResponseBody(TeaModel):
    def __init__(
        self,
        content: List[CustomizeContactListResponseBodyContent] = None,
    ):
        # content
        self.content = content

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = CustomizeContactListResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        return self


class CustomizeContactListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CustomizeContactListResponseBody = None,
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
            temp_model = CustomizeContactListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CustomizeContactUpdateHeaders(TeaModel):
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


class CustomizeContactUpdateRequest(TeaModel):
    def __init__(
        self,
        code: str = None,
        manager_id_list: List[str] = None,
        name: str = None,
        order: int = None,
    ):
        # 自定义通讯录Code
        self.code = code
        # 通讯录管理员UserId
        self.manager_id_list = manager_id_list
        # 自定义通讯录名称
        self.name = name
        # 在自定义通讯录列表中的排序
        self.order = order

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.manager_id_list is not None:
            result['managerIdList'] = self.manager_id_list
        if self.name is not None:
            result['name'] = self.name
        if self.order is not None:
            result['order'] = self.order
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('managerIdList') is not None:
            self.manager_id_list = m.get('managerIdList')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('order') is not None:
            self.order = m.get('order')
        return self


class CustomizeContactUpdateResponseBody(TeaModel):
    def __init__(
        self,
        content: bool = None,
    ):
        # 是否操作成功
        self.content = content

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        return self


class CustomizeContactUpdateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CustomizeContactUpdateResponseBody = None,
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
            temp_model = CustomizeContactUpdateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DigitalStoreContactInfoHeaders(TeaModel):
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


class DigitalStoreContactInfoResponseBody(TeaModel):
    def __init__(
        self,
        code: str = None,
        name: str = None,
        root_dept_id: int = None,
    ):
        # 门店通通讯录Code
        self.code = code
        # 门店通通讯录名称
        self.name = name
        # 门店通通讯录根节点Id
        self.root_dept_id = root_dept_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.name is not None:
            result['name'] = self.name
        if self.root_dept_id is not None:
            result['rootDeptId'] = self.root_dept_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('rootDeptId') is not None:
            self.root_dept_id = m.get('rootDeptId')
        return self


class DigitalStoreContactInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DigitalStoreContactInfoResponseBody = None,
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
            temp_model = DigitalStoreContactInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DigitalStoreGroupInfoHeaders(TeaModel):
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


class DigitalStoreGroupInfoRequest(TeaModel):
    def __init__(
        self,
        group_id: int = None,
    ):
        # 门店分组Id
        self.group_id = group_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_id is not None:
            result['groupId'] = self.group_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupId') is not None:
            self.group_id = m.get('groupId')
        return self


class DigitalStoreGroupInfoResponseBody(TeaModel):
    def __init__(
        self,
        group_id: int = None,
        group_name: str = None,
        store_id_list: List[int] = None,
    ):
        # 分组Id
        self.group_id = group_id
        # 分组名称
        self.group_name = group_name
        # 分组中门店Id列表
        self.store_id_list = store_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_id is not None:
            result['groupId'] = self.group_id
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.store_id_list is not None:
            result['storeIdList'] = self.store_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupId') is not None:
            self.group_id = m.get('groupId')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('storeIdList') is not None:
            self.store_id_list = m.get('storeIdList')
        return self


class DigitalStoreGroupInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DigitalStoreGroupInfoResponseBody = None,
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
            temp_model = DigitalStoreGroupInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DigitalStoreGroupsHeaders(TeaModel):
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


class DigitalStoreGroupsResponseBodyContent(TeaModel):
    def __init__(
        self,
        group_id: int = None,
        group_name: str = None,
    ):
        # 分组Id
        self.group_id = group_id
        # 分组名称
        self.group_name = group_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_id is not None:
            result['groupId'] = self.group_id
        if self.group_name is not None:
            result['groupName'] = self.group_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupId') is not None:
            self.group_id = m.get('groupId')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        return self


class DigitalStoreGroupsResponseBody(TeaModel):
    def __init__(
        self,
        content: List[DigitalStoreGroupsResponseBodyContent] = None,
    ):
        self.content = content

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = DigitalStoreGroupsResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        return self


class DigitalStoreGroupsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DigitalStoreGroupsResponseBody = None,
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
            temp_model = DigitalStoreGroupsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DigitalStoreNodeInfoHeaders(TeaModel):
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


class DigitalStoreNodeInfoRequest(TeaModel):
    def __init__(
        self,
        code: str = None,
        node_id: int = None,
    ):
        # 门店通通讯录Code
        self.code = code
        # 节点Id
        self.node_id = node_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.node_id is not None:
            result['nodeId'] = self.node_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('nodeId') is not None:
            self.node_id = m.get('nodeId')
        return self


class DigitalStoreNodeInfoResponseBody(TeaModel):
    def __init__(
        self,
        id: int = None,
        name: str = None,
        parent_id: int = None,
        type: int = None,
    ):
        # 节点Id
        self.id = id
        # 门店名称
        self.name = name
        # 上级节点id
        self.parent_id = parent_id
        # 节点类型
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
        if self.parent_id is not None:
            result['parentId'] = self.parent_id
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('parentId') is not None:
            self.parent_id = m.get('parentId')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class DigitalStoreNodeInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DigitalStoreNodeInfoResponseBody = None,
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
            temp_model = DigitalStoreNodeInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DigitalStoreRightsInfoHeaders(TeaModel):
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


class DigitalStoreRightsInfoResponseBody(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        quantity: int = None,
        rights_code: str = None,
        rights_name: str = None,
        start_time: int = None,
    ):
        # 权益过期时间
        self.end_time = end_time
        # 门店通通讯录根节点Id
        self.quantity = quantity
        # 门店通通讯录名称
        self.rights_code = rights_code
        # 门店通通讯录Code
        self.rights_name = rights_name
        # 权益开始时间
        self.start_time = start_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.quantity is not None:
            result['quantity'] = self.quantity
        if self.rights_code is not None:
            result['rightsCode'] = self.rights_code
        if self.rights_name is not None:
            result['rightsName'] = self.rights_name
        if self.start_time is not None:
            result['startTime'] = self.start_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('quantity') is not None:
            self.quantity = m.get('quantity')
        if m.get('rightsCode') is not None:
            self.rights_code = m.get('rightsCode')
        if m.get('rightsName') is not None:
            self.rights_name = m.get('rightsName')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        return self


class DigitalStoreRightsInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DigitalStoreRightsInfoResponseBody = None,
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
            temp_model = DigitalStoreRightsInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DigitalStoreRolesHeaders(TeaModel):
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


class DigitalStoreRolesResponseBodyContent(TeaModel):
    def __init__(
        self,
        level: int = None,
        role_code: str = None,
        role_id: int = None,
        role_name: str = None,
    ):
        # 优先级
        self.level = level
        # 角色Code
        self.role_code = role_code
        # 角色Id
        self.role_id = role_id
        # 角色名称
        self.role_name = role_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.level is not None:
            result['level'] = self.level
        if self.role_code is not None:
            result['roleCode'] = self.role_code
        if self.role_id is not None:
            result['roleId'] = self.role_id
        if self.role_name is not None:
            result['roleName'] = self.role_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('level') is not None:
            self.level = m.get('level')
        if m.get('roleCode') is not None:
            self.role_code = m.get('roleCode')
        if m.get('roleId') is not None:
            self.role_id = m.get('roleId')
        if m.get('roleName') is not None:
            self.role_name = m.get('roleName')
        return self


class DigitalStoreRolesResponseBody(TeaModel):
    def __init__(
        self,
        content: List[DigitalStoreRolesResponseBodyContent] = None,
    ):
        self.content = content

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = DigitalStoreRolesResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        return self


class DigitalStoreRolesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DigitalStoreRolesResponseBody = None,
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
            temp_model = DigitalStoreRolesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DigitalStoreStoreInfoHeaders(TeaModel):
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


class DigitalStoreStoreInfoRequest(TeaModel):
    def __init__(
        self,
        code: str = None,
        store_id: int = None,
    ):
        # 门店通通讯录Code
        self.code = code
        # 门店Id
        self.store_id = store_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.store_id is not None:
            result['storeId'] = self.store_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('storeId') is not None:
            self.store_id = m.get('storeId')
        return self


class DigitalStoreStoreInfoResponseBody(TeaModel):
    def __init__(
        self,
        address: str = None,
        business_hours: str = None,
        latitude: str = None,
        location_address: str = None,
        longitude: str = None,
        name: str = None,
        parent_id: int = None,
        status: str = None,
        store_acreage: str = None,
        store_bandwidth: str = None,
        store_code: str = None,
        store_id: int = None,
        telephone: str = None,
    ):
        # 门店地址
        self.address = address
        # 营业时间
        self.business_hours = business_hours
        # 纬度
        self.latitude = latitude
        # 定位地址
        self.location_address = location_address
        # 经度
        self.longitude = longitude
        # 门店名称
        self.name = name
        # 上级节点id
        self.parent_id = parent_id
        # 门店状态
        self.status = status
        # 门店面积
        self.store_acreage = store_acreage
        # 门店带宽
        self.store_bandwidth = store_bandwidth
        # 门店编号
        self.store_code = store_code
        # 门店Id
        self.store_id = store_id
        # 门店电话
        self.telephone = telephone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.address is not None:
            result['address'] = self.address
        if self.business_hours is not None:
            result['businessHours'] = self.business_hours
        if self.latitude is not None:
            result['latitude'] = self.latitude
        if self.location_address is not None:
            result['locationAddress'] = self.location_address
        if self.longitude is not None:
            result['longitude'] = self.longitude
        if self.name is not None:
            result['name'] = self.name
        if self.parent_id is not None:
            result['parentId'] = self.parent_id
        if self.status is not None:
            result['status'] = self.status
        if self.store_acreage is not None:
            result['storeAcreage'] = self.store_acreage
        if self.store_bandwidth is not None:
            result['storeBandwidth'] = self.store_bandwidth
        if self.store_code is not None:
            result['storeCode'] = self.store_code
        if self.store_id is not None:
            result['storeId'] = self.store_id
        if self.telephone is not None:
            result['telephone'] = self.telephone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('address') is not None:
            self.address = m.get('address')
        if m.get('businessHours') is not None:
            self.business_hours = m.get('businessHours')
        if m.get('latitude') is not None:
            self.latitude = m.get('latitude')
        if m.get('locationAddress') is not None:
            self.location_address = m.get('locationAddress')
        if m.get('longitude') is not None:
            self.longitude = m.get('longitude')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('parentId') is not None:
            self.parent_id = m.get('parentId')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('storeAcreage') is not None:
            self.store_acreage = m.get('storeAcreage')
        if m.get('storeBandwidth') is not None:
            self.store_bandwidth = m.get('storeBandwidth')
        if m.get('storeCode') is not None:
            self.store_code = m.get('storeCode')
        if m.get('storeId') is not None:
            self.store_id = m.get('storeId')
        if m.get('telephone') is not None:
            self.telephone = m.get('telephone')
        return self


class DigitalStoreStoreInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DigitalStoreStoreInfoResponseBody = None,
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
            temp_model = DigitalStoreStoreInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DigitalStoreSubNodesHeaders(TeaModel):
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


class DigitalStoreSubNodesRequest(TeaModel):
    def __init__(
        self,
        code: str = None,
        node_id: int = None,
    ):
        # 门店通通讯录Code
        self.code = code
        # 节点Id
        self.node_id = node_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.node_id is not None:
            result['nodeId'] = self.node_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('nodeId') is not None:
            self.node_id = m.get('nodeId')
        return self


class DigitalStoreSubNodesResponseBodyContent(TeaModel):
    def __init__(
        self,
        id: int = None,
        name: str = None,
        parent_id: int = None,
        type: int = None,
    ):
        # 节点Id
        self.id = id
        # 门店名称
        self.name = name
        # 上级节点id
        self.parent_id = parent_id
        # 节点类型
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
        if self.parent_id is not None:
            result['parentId'] = self.parent_id
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('parentId') is not None:
            self.parent_id = m.get('parentId')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class DigitalStoreSubNodesResponseBody(TeaModel):
    def __init__(
        self,
        content: List[DigitalStoreSubNodesResponseBodyContent] = None,
    ):
        self.content = content

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = DigitalStoreSubNodesResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        return self


class DigitalStoreSubNodesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DigitalStoreSubNodesResponseBody = None,
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
            temp_model = DigitalStoreSubNodesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DigitalStoreUserInfoHeaders(TeaModel):
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


class DigitalStoreUserInfoRequest(TeaModel):
    def __init__(
        self,
        code: str = None,
        user_id: str = None,
    ):
        # 门店通迅录Code
        self.code = code
        # 人员Id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class DigitalStoreUserInfoResponseBody(TeaModel):
    def __init__(
        self,
        name: str = None,
        scope_list: List[int] = None,
        store_list: List[int] = None,
        user_id: str = None,
    ):
        # 人员名称
        self.name = name
        # 管理范围
        self.scope_list = scope_list
        # 所在节点列表
        self.store_list = store_list
        # 人员Id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.scope_list is not None:
            result['scopeList'] = self.scope_list
        if self.store_list is not None:
            result['storeList'] = self.store_list
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('scopeList') is not None:
            self.scope_list = m.get('scopeList')
        if m.get('storeList') is not None:
            self.store_list = m.get('storeList')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class DigitalStoreUserInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DigitalStoreUserInfoResponseBody = None,
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
            temp_model = DigitalStoreUserInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DigitalStoreUsersHeaders(TeaModel):
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


class DigitalStoreUsersRequest(TeaModel):
    def __init__(
        self,
        code: str = None,
        node_id: int = None,
    ):
        # 门店通通讯录Cod
        self.code = code
        # 节点Id
        self.node_id = node_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.node_id is not None:
            result['nodeId'] = self.node_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('nodeId') is not None:
            self.node_id = m.get('nodeId')
        return self


class DigitalStoreUsersResponseBodyContent(TeaModel):
    def __init__(
        self,
        name: str = None,
        user_id: str = None,
    ):
        # 人员姓名
        self.name = name
        # 人员Id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class DigitalStoreUsersResponseBody(TeaModel):
    def __init__(
        self,
        content: List[DigitalStoreUsersResponseBodyContent] = None,
    ):
        # 人员列表
        self.content = content

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = DigitalStoreUsersResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        return self


class DigitalStoreUsersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DigitalStoreUsersResponseBody = None,
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
            temp_model = DigitalStoreUsersResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class IndustryManufactureCommonEventHeaders(TeaModel):
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


class IndustryManufactureCommonEventRequest(TeaModel):
    def __init__(
        self,
        action: str = None,
        app_key: str = None,
        biz_data: Dict[str, Any] = None,
        event_type: List[str] = None,
    ):
        # add 创建事件/update 更新事件
        self.action = action
        # 应用appkey
        self.app_key = app_key
        self.biz_data = biz_data
        # 事件集合，目前仅1个有效
        self.event_type = event_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action is not None:
            result['action'] = self.action
        if self.app_key is not None:
            result['appKey'] = self.app_key
        if self.biz_data is not None:
            result['bizData'] = self.biz_data
        if self.event_type is not None:
            result['eventType'] = self.event_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('action') is not None:
            self.action = m.get('action')
        if m.get('appKey') is not None:
            self.app_key = m.get('appKey')
        if m.get('bizData') is not None:
            self.biz_data = m.get('bizData')
        if m.get('eventType') is not None:
            self.event_type = m.get('eventType')
        return self


class IndustryManufactureCommonEventResponseBodyResult(TeaModel):
    def __init__(
        self,
        content: str = None,
        http_code: str = None,
    ):
        # 返回内容
        self.content = content
        # 状态码
        self.http_code = http_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.http_code is not None:
            result['httpCode'] = self.http_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('httpCode') is not None:
            self.http_code = m.get('httpCode')
        return self


class IndustryManufactureCommonEventResponseBody(TeaModel):
    def __init__(
        self,
        error_msg: str = None,
        request_id: str = None,
        result: IndustryManufactureCommonEventResponseBodyResult = None,
    ):
        self.error_msg = error_msg
        # Id of the request
        self.request_id = request_id
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            temp_model = IndustryManufactureCommonEventResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class IndustryManufactureCommonEventResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: IndustryManufactureCommonEventResponseBody = None,
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
            temp_model = IndustryManufactureCommonEventResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class IndustryManufactureCostRecordListGetHeaders(TeaModel):
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


class IndustryManufactureCostRecordListGetRequest(TeaModel):
    def __init__(
        self,
        app_id: int = None,
        app_ids: List[int] = None,
        app_name: str = None,
        corp_id: str = None,
        cursor: int = None,
        end_time: int = None,
        instance_id: str = None,
        isv_org_id: int = None,
        material_no: str = None,
        microapp_agent_id: int = None,
        order_no: str = None,
        org_id: int = None,
        page_number: int = None,
        page_size: int = None,
        production_task_no: str = None,
        start_time: int = None,
        suite_key: str = None,
        token_grant_type: int = None,
    ):
        self.app_id = app_id
        self.app_ids = app_ids
        self.app_name = app_name
        self.corp_id = corp_id
        self.cursor = cursor
        self.end_time = end_time
        self.instance_id = instance_id
        self.isv_org_id = isv_org_id
        self.material_no = material_no
        self.microapp_agent_id = microapp_agent_id
        self.order_no = order_no
        self.org_id = org_id
        self.page_number = page_number
        self.page_size = page_size
        self.production_task_no = production_task_no
        self.start_time = start_time
        self.suite_key = suite_key
        self.token_grant_type = token_grant_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.app_ids is not None:
            result['appIds'] = self.app_ids
        if self.app_name is not None:
            result['appName'] = self.app_name
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.cursor is not None:
            result['cursor'] = self.cursor
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.isv_org_id is not None:
            result['isvOrgId'] = self.isv_org_id
        if self.material_no is not None:
            result['materialNo'] = self.material_no
        if self.microapp_agent_id is not None:
            result['microappAgentId'] = self.microapp_agent_id
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        if self.org_id is not None:
            result['orgId'] = self.org_id
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.production_task_no is not None:
            result['productionTaskNo'] = self.production_task_no
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.suite_key is not None:
            result['suiteKey'] = self.suite_key
        if self.token_grant_type is not None:
            result['tokenGrantType'] = self.token_grant_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('appIds') is not None:
            self.app_ids = m.get('appIds')
        if m.get('appName') is not None:
            self.app_name = m.get('appName')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('cursor') is not None:
            self.cursor = m.get('cursor')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('isvOrgId') is not None:
            self.isv_org_id = m.get('isvOrgId')
        if m.get('materialNo') is not None:
            self.material_no = m.get('materialNo')
        if m.get('microappAgentId') is not None:
            self.microapp_agent_id = m.get('microappAgentId')
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        if m.get('orgId') is not None:
            self.org_id = m.get('orgId')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('productionTaskNo') is not None:
            self.production_task_no = m.get('productionTaskNo')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('suiteKey') is not None:
            self.suite_key = m.get('suiteKey')
        if m.get('tokenGrantType') is not None:
            self.token_grant_type = m.get('tokenGrantType')
        return self


class IndustryManufactureCostRecordListGetResponseBodyList(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        count: float = None,
        ext: str = None,
        gmt_create: int = None,
        gmt_modified: int = None,
        instance_id: str = None,
        is_deleted: str = None,
        material_cost_record_no: str = None,
        material_name: str = None,
        material_no: str = None,
        memo: str = None,
        order_no: str = None,
        price: float = None,
        process_code: str = None,
        production_task_no: str = None,
        real_count: float = None,
        real_price: float = None,
        type: str = None,
        unit: str = None,
    ):
        self.corp_id = corp_id
        self.count = count
        self.ext = ext
        self.gmt_create = gmt_create
        self.gmt_modified = gmt_modified
        self.instance_id = instance_id
        self.is_deleted = is_deleted
        self.material_cost_record_no = material_cost_record_no
        self.material_name = material_name
        self.material_no = material_no
        self.memo = memo
        self.order_no = order_no
        self.price = price
        self.process_code = process_code
        self.production_task_no = production_task_no
        self.real_count = real_count
        self.real_price = real_price
        self.type = type
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.count is not None:
            result['count'] = self.count
        if self.ext is not None:
            result['ext'] = self.ext
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.is_deleted is not None:
            result['isDeleted'] = self.is_deleted
        if self.material_cost_record_no is not None:
            result['materialCostRecordNo'] = self.material_cost_record_no
        if self.material_name is not None:
            result['materialName'] = self.material_name
        if self.material_no is not None:
            result['materialNo'] = self.material_no
        if self.memo is not None:
            result['memo'] = self.memo
        if self.order_no is not None:
            result['orderNo'] = self.order_no
        if self.price is not None:
            result['price'] = self.price
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.production_task_no is not None:
            result['productionTaskNo'] = self.production_task_no
        if self.real_count is not None:
            result['realCount'] = self.real_count
        if self.real_price is not None:
            result['realPrice'] = self.real_price
        if self.type is not None:
            result['type'] = self.type
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('count') is not None:
            self.count = m.get('count')
        if m.get('ext') is not None:
            self.ext = m.get('ext')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('isDeleted') is not None:
            self.is_deleted = m.get('isDeleted')
        if m.get('materialCostRecordNo') is not None:
            self.material_cost_record_no = m.get('materialCostRecordNo')
        if m.get('materialName') is not None:
            self.material_name = m.get('materialName')
        if m.get('materialNo') is not None:
            self.material_no = m.get('materialNo')
        if m.get('memo') is not None:
            self.memo = m.get('memo')
        if m.get('orderNo') is not None:
            self.order_no = m.get('orderNo')
        if m.get('price') is not None:
            self.price = m.get('price')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('productionTaskNo') is not None:
            self.production_task_no = m.get('productionTaskNo')
        if m.get('realCount') is not None:
            self.real_count = m.get('realCount')
        if m.get('realPrice') is not None:
            self.real_price = m.get('realPrice')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class IndustryManufactureCostRecordListGetResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[IndustryManufactureCostRecordListGetResponseBodyList] = None,
        next_cursor: int = None,
        total_count: int = None,
    ):
        self.has_more = has_more
        self.list = list
        self.next_cursor = next_cursor
        self.total_count = total_count

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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        if self.next_cursor is not None:
            result['nextCursor'] = self.next_cursor
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = IndustryManufactureCostRecordListGetResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextCursor') is not None:
            self.next_cursor = m.get('nextCursor')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class IndustryManufactureCostRecordListGetResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: IndustryManufactureCostRecordListGetResponseBody = None,
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
            temp_model = IndustryManufactureCostRecordListGetResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class IndustryManufactureFeeListGetHeaders(TeaModel):
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


class IndustryManufactureFeeListGetRequest(TeaModel):
    def __init__(
        self,
        app_id: int = None,
        app_ids: List[int] = None,
        app_name: str = None,
        corp_id: str = None,
        cursor: int = None,
        end_time: int = None,
        isv_org_id: int = None,
        material_no: str = None,
        microapp_agent_id: int = None,
        org_id: int = None,
        page_number: int = None,
        page_size: int = None,
        production_task_no: str = None,
        start_time: int = None,
        suite_key: str = None,
        token_grant_type: int = None,
        type: str = None,
    ):
        self.app_id = app_id
        self.app_ids = app_ids
        self.app_name = app_name
        self.corp_id = corp_id
        self.cursor = cursor
        self.end_time = end_time
        self.isv_org_id = isv_org_id
        self.material_no = material_no
        self.microapp_agent_id = microapp_agent_id
        self.org_id = org_id
        self.page_number = page_number
        self.page_size = page_size
        self.production_task_no = production_task_no
        self.start_time = start_time
        self.suite_key = suite_key
        self.token_grant_type = token_grant_type
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.app_ids is not None:
            result['appIds'] = self.app_ids
        if self.app_name is not None:
            result['appName'] = self.app_name
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.cursor is not None:
            result['cursor'] = self.cursor
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.isv_org_id is not None:
            result['isvOrgId'] = self.isv_org_id
        if self.material_no is not None:
            result['materialNo'] = self.material_no
        if self.microapp_agent_id is not None:
            result['microappAgentId'] = self.microapp_agent_id
        if self.org_id is not None:
            result['orgId'] = self.org_id
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.production_task_no is not None:
            result['productionTaskNo'] = self.production_task_no
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.suite_key is not None:
            result['suiteKey'] = self.suite_key
        if self.token_grant_type is not None:
            result['tokenGrantType'] = self.token_grant_type
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('appIds') is not None:
            self.app_ids = m.get('appIds')
        if m.get('appName') is not None:
            self.app_name = m.get('appName')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('cursor') is not None:
            self.cursor = m.get('cursor')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('isvOrgId') is not None:
            self.isv_org_id = m.get('isvOrgId')
        if m.get('materialNo') is not None:
            self.material_no = m.get('materialNo')
        if m.get('microappAgentId') is not None:
            self.microapp_agent_id = m.get('microappAgentId')
        if m.get('orgId') is not None:
            self.org_id = m.get('orgId')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('productionTaskNo') is not None:
            self.production_task_no = m.get('productionTaskNo')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('suiteKey') is not None:
            self.suite_key = m.get('suiteKey')
        if m.get('tokenGrantType') is not None:
            self.token_grant_type = m.get('tokenGrantType')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class IndustryManufactureFeeListGetResponseBodyList(TeaModel):
    def __init__(
        self,
        amount: str = None,
        corp_id: str = None,
        count: float = None,
        ext: str = None,
        gmt_create: int = None,
        gmt_modified: int = None,
        id: int = None,
        instance_id: str = None,
        is_deleted: str = None,
        material_name: str = None,
        material_no: str = None,
        per_amount: float = None,
        process_code: str = None,
        production_task_no: str = None,
        title: str = None,
        type: str = None,
        unit: str = None,
    ):
        self.amount = amount
        self.corp_id = corp_id
        self.count = count
        self.ext = ext
        self.gmt_create = gmt_create
        self.gmt_modified = gmt_modified
        self.id = id
        self.instance_id = instance_id
        self.is_deleted = is_deleted
        self.material_name = material_name
        self.material_no = material_no
        self.per_amount = per_amount
        self.process_code = process_code
        self.production_task_no = production_task_no
        self.title = title
        self.type = type
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.amount is not None:
            result['amount'] = self.amount
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.count is not None:
            result['count'] = self.count
        if self.ext is not None:
            result['ext'] = self.ext
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.id is not None:
            result['id'] = self.id
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.is_deleted is not None:
            result['isDeleted'] = self.is_deleted
        if self.material_name is not None:
            result['materialName'] = self.material_name
        if self.material_no is not None:
            result['materialNo'] = self.material_no
        if self.per_amount is not None:
            result['perAmount'] = self.per_amount
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.production_task_no is not None:
            result['productionTaskNo'] = self.production_task_no
        if self.title is not None:
            result['title'] = self.title
        if self.type is not None:
            result['type'] = self.type
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('amount') is not None:
            self.amount = m.get('amount')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('count') is not None:
            self.count = m.get('count')
        if m.get('ext') is not None:
            self.ext = m.get('ext')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('isDeleted') is not None:
            self.is_deleted = m.get('isDeleted')
        if m.get('materialName') is not None:
            self.material_name = m.get('materialName')
        if m.get('materialNo') is not None:
            self.material_no = m.get('materialNo')
        if m.get('perAmount') is not None:
            self.per_amount = m.get('perAmount')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('productionTaskNo') is not None:
            self.production_task_no = m.get('productionTaskNo')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class IndustryManufactureFeeListGetResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[IndustryManufactureFeeListGetResponseBodyList] = None,
        next_cursor: int = None,
        total_count: int = None,
    ):
        self.has_more = has_more
        self.list = list
        self.next_cursor = next_cursor
        self.total_count = total_count

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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        if self.next_cursor is not None:
            result['nextCursor'] = self.next_cursor
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = IndustryManufactureFeeListGetResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextCursor') is not None:
            self.next_cursor = m.get('nextCursor')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class IndustryManufactureFeeListGetResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: IndustryManufactureFeeListGetResponseBody = None,
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
            temp_model = IndustryManufactureFeeListGetResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class IndustryManufactureLabourCostHeaders(TeaModel):
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


class IndustryManufactureLabourCostRequest(TeaModel):
    def __init__(
        self,
        app_id: int = None,
        app_ids: List[int] = None,
        app_name: str = None,
        corp_id: str = None,
        cursor: int = None,
        end_time: int = None,
        isv_org_id: str = None,
        material_no: str = None,
        microapp_agent_id: int = None,
        org_id: int = None,
        page_number: int = None,
        page_size: int = None,
        process_no: str = None,
        start_time: int = None,
        suite_key: str = None,
        token_grant_type: int = None,
    ):
        self.app_id = app_id
        self.app_ids = app_ids
        self.app_name = app_name
        self.corp_id = corp_id
        self.cursor = cursor
        self.end_time = end_time
        self.isv_org_id = isv_org_id
        self.material_no = material_no
        self.microapp_agent_id = microapp_agent_id
        self.org_id = org_id
        self.page_number = page_number
        self.page_size = page_size
        self.process_no = process_no
        self.start_time = start_time
        self.suite_key = suite_key
        self.token_grant_type = token_grant_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.app_ids is not None:
            result['appIds'] = self.app_ids
        if self.app_name is not None:
            result['appName'] = self.app_name
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.cursor is not None:
            result['cursor'] = self.cursor
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.isv_org_id is not None:
            result['isvOrgId'] = self.isv_org_id
        if self.material_no is not None:
            result['materialNo'] = self.material_no
        if self.microapp_agent_id is not None:
            result['microappAgentId'] = self.microapp_agent_id
        if self.org_id is not None:
            result['orgId'] = self.org_id
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.process_no is not None:
            result['processNo'] = self.process_no
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.suite_key is not None:
            result['suiteKey'] = self.suite_key
        if self.token_grant_type is not None:
            result['tokenGrantType'] = self.token_grant_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('appIds') is not None:
            self.app_ids = m.get('appIds')
        if m.get('appName') is not None:
            self.app_name = m.get('appName')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('cursor') is not None:
            self.cursor = m.get('cursor')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('isvOrgId') is not None:
            self.isv_org_id = m.get('isvOrgId')
        if m.get('materialNo') is not None:
            self.material_no = m.get('materialNo')
        if m.get('microappAgentId') is not None:
            self.microapp_agent_id = m.get('microappAgentId')
        if m.get('orgId') is not None:
            self.org_id = m.get('orgId')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('processNo') is not None:
            self.process_no = m.get('processNo')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('suiteKey') is not None:
            self.suite_key = m.get('suiteKey')
        if m.get('tokenGrantType') is not None:
            self.token_grant_type = m.get('tokenGrantType')
        return self


class IndustryManufactureLabourCostResponseBodyList(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        ext: str = None,
        gmt_create: int = None,
        gmt_modified: int = None,
        instance_id: str = None,
        labour_cost_name: str = None,
        labour_cost_no: str = None,
        material_name: str = None,
        material_no: str = None,
        process_code: str = None,
        process_name: str = None,
        process_no: str = None,
        qualified_price: float = None,
        un_qualified_info: str = None,
        un_qualified_price_1: float = None,
        un_qualified_price_2: float = None,
        un_qualified_reason_1: str = None,
        un_qualified_reason_2: str = None,
    ):
        self.corp_id = corp_id
        self.ext = ext
        self.gmt_create = gmt_create
        self.gmt_modified = gmt_modified
        self.instance_id = instance_id
        self.labour_cost_name = labour_cost_name
        self.labour_cost_no = labour_cost_no
        self.material_name = material_name
        self.material_no = material_no
        self.process_code = process_code
        self.process_name = process_name
        self.process_no = process_no
        self.qualified_price = qualified_price
        self.un_qualified_info = un_qualified_info
        self.un_qualified_price_1 = un_qualified_price_1
        self.un_qualified_price_2 = un_qualified_price_2
        self.un_qualified_reason_1 = un_qualified_reason_1
        self.un_qualified_reason_2 = un_qualified_reason_2

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.ext is not None:
            result['ext'] = self.ext
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.labour_cost_name is not None:
            result['labourCostName'] = self.labour_cost_name
        if self.labour_cost_no is not None:
            result['labourCostNo'] = self.labour_cost_no
        if self.material_name is not None:
            result['materialName'] = self.material_name
        if self.material_no is not None:
            result['materialNo'] = self.material_no
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.process_name is not None:
            result['processName'] = self.process_name
        if self.process_no is not None:
            result['processNo'] = self.process_no
        if self.qualified_price is not None:
            result['qualifiedPrice'] = self.qualified_price
        if self.un_qualified_info is not None:
            result['unQualifiedInfo'] = self.un_qualified_info
        if self.un_qualified_price_1 is not None:
            result['unQualifiedPrice1'] = self.un_qualified_price_1
        if self.un_qualified_price_2 is not None:
            result['unQualifiedPrice2'] = self.un_qualified_price_2
        if self.un_qualified_reason_1 is not None:
            result['unQualifiedReason1'] = self.un_qualified_reason_1
        if self.un_qualified_reason_2 is not None:
            result['unQualifiedReason2'] = self.un_qualified_reason_2
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('ext') is not None:
            self.ext = m.get('ext')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('labourCostName') is not None:
            self.labour_cost_name = m.get('labourCostName')
        if m.get('labourCostNo') is not None:
            self.labour_cost_no = m.get('labourCostNo')
        if m.get('materialName') is not None:
            self.material_name = m.get('materialName')
        if m.get('materialNo') is not None:
            self.material_no = m.get('materialNo')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('processName') is not None:
            self.process_name = m.get('processName')
        if m.get('processNo') is not None:
            self.process_no = m.get('processNo')
        if m.get('qualifiedPrice') is not None:
            self.qualified_price = m.get('qualifiedPrice')
        if m.get('unQualifiedInfo') is not None:
            self.un_qualified_info = m.get('unQualifiedInfo')
        if m.get('unQualifiedPrice1') is not None:
            self.un_qualified_price_1 = m.get('unQualifiedPrice1')
        if m.get('unQualifiedPrice2') is not None:
            self.un_qualified_price_2 = m.get('unQualifiedPrice2')
        if m.get('unQualifiedReason1') is not None:
            self.un_qualified_reason_1 = m.get('unQualifiedReason1')
        if m.get('unQualifiedReason2') is not None:
            self.un_qualified_reason_2 = m.get('unQualifiedReason2')
        return self


class IndustryManufactureLabourCostResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[IndustryManufactureLabourCostResponseBodyList] = None,
        next_cursor: int = None,
        total_count: int = None,
    ):
        self.has_more = has_more
        self.list = list
        self.next_cursor = next_cursor
        self.total_count = total_count

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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        if self.next_cursor is not None:
            result['nextCursor'] = self.next_cursor
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = IndustryManufactureLabourCostResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextCursor') is not None:
            self.next_cursor = m.get('nextCursor')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class IndustryManufactureLabourCostResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: IndustryManufactureLabourCostResponseBody = None,
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
            temp_model = IndustryManufactureLabourCostResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class IndustryManufactureMaterialListHeaders(TeaModel):
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


class IndustryManufactureMaterialListRequest(TeaModel):
    def __init__(
        self,
        app_id: int = None,
        app_ids: List[int] = None,
        app_name: str = None,
        corp_id: str = None,
        current_page: int = None,
        cursor: int = None,
        end_time: int = None,
        instance_id: str = None,
        isv_org_id: int = None,
        material_no: str = None,
        microapp_agent_id: int = None,
        org_id: int = None,
        page_size: int = None,
        start_time: int = None,
        suite_key: str = None,
        token_grant_type: int = None,
    ):
        self.app_id = app_id
        self.app_ids = app_ids
        self.app_name = app_name
        self.corp_id = corp_id
        self.current_page = current_page
        self.cursor = cursor
        self.end_time = end_time
        self.instance_id = instance_id
        self.isv_org_id = isv_org_id
        self.material_no = material_no
        self.microapp_agent_id = microapp_agent_id
        self.org_id = org_id
        self.page_size = page_size
        self.start_time = start_time
        self.suite_key = suite_key
        self.token_grant_type = token_grant_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.app_ids is not None:
            result['appIds'] = self.app_ids
        if self.app_name is not None:
            result['appName'] = self.app_name
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.current_page is not None:
            result['currentPage'] = self.current_page
        if self.cursor is not None:
            result['cursor'] = self.cursor
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.isv_org_id is not None:
            result['isvOrgId'] = self.isv_org_id
        if self.material_no is not None:
            result['materialNo'] = self.material_no
        if self.microapp_agent_id is not None:
            result['microappAgentId'] = self.microapp_agent_id
        if self.org_id is not None:
            result['orgId'] = self.org_id
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.suite_key is not None:
            result['suiteKey'] = self.suite_key
        if self.token_grant_type is not None:
            result['tokenGrantType'] = self.token_grant_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('appIds') is not None:
            self.app_ids = m.get('appIds')
        if m.get('appName') is not None:
            self.app_name = m.get('appName')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('currentPage') is not None:
            self.current_page = m.get('currentPage')
        if m.get('cursor') is not None:
            self.cursor = m.get('cursor')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('isvOrgId') is not None:
            self.isv_org_id = m.get('isvOrgId')
        if m.get('materialNo') is not None:
            self.material_no = m.get('materialNo')
        if m.get('microappAgentId') is not None:
            self.microapp_agent_id = m.get('microappAgentId')
        if m.get('orgId') is not None:
            self.org_id = m.get('orgId')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('suiteKey') is not None:
            self.suite_key = m.get('suiteKey')
        if m.get('tokenGrantType') is not None:
            self.token_grant_type = m.get('tokenGrantType')
        return self


class IndustryManufactureMaterialListResponseBodyList(TeaModel):
    def __init__(
        self,
        category: str = None,
        corp_id: str = None,
        ext: str = None,
        instance_id: str = None,
        material_name: str = None,
        material_no: str = None,
        process_code: str = None,
        specification: str = None,
        stock_max_warn: float = None,
        stock_min_warn: float = None,
        type: str = None,
        unit: str = None,
    ):
        self.category = category
        self.corp_id = corp_id
        self.ext = ext
        self.instance_id = instance_id
        self.material_name = material_name
        self.material_no = material_no
        self.process_code = process_code
        self.specification = specification
        self.stock_max_warn = stock_max_warn
        self.stock_min_warn = stock_min_warn
        self.type = type
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.category is not None:
            result['category'] = self.category
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.ext is not None:
            result['ext'] = self.ext
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.material_name is not None:
            result['materialName'] = self.material_name
        if self.material_no is not None:
            result['materialNo'] = self.material_no
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.specification is not None:
            result['specification'] = self.specification
        if self.stock_max_warn is not None:
            result['stockMaxWarn'] = self.stock_max_warn
        if self.stock_min_warn is not None:
            result['stockMinWarn'] = self.stock_min_warn
        if self.type is not None:
            result['type'] = self.type
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('category') is not None:
            self.category = m.get('category')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('ext') is not None:
            self.ext = m.get('ext')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('materialName') is not None:
            self.material_name = m.get('materialName')
        if m.get('materialNo') is not None:
            self.material_no = m.get('materialNo')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('specification') is not None:
            self.specification = m.get('specification')
        if m.get('stockMaxWarn') is not None:
            self.stock_max_warn = m.get('stockMaxWarn')
        if m.get('stockMinWarn') is not None:
            self.stock_min_warn = m.get('stockMinWarn')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class IndustryManufactureMaterialListResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[IndustryManufactureMaterialListResponseBodyList] = None,
        next_cursor: int = None,
        total_count: int = None,
    ):
        self.has_more = has_more
        self.list = list
        self.next_cursor = next_cursor
        self.total_count = total_count

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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        if self.next_cursor is not None:
            result['nextCursor'] = self.next_cursor
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = IndustryManufactureMaterialListResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextCursor') is not None:
            self.next_cursor = m.get('nextCursor')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class IndustryManufactureMaterialListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: IndustryManufactureMaterialListResponseBody = None,
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
            temp_model = IndustryManufactureMaterialListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class IndustryManufactureMesTeamMgmtHeaders(TeaModel):
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


class IndustryManufactureMesTeamMgmtRequestExtendData(TeaModel):
    def __init__(
        self,
        code: str = None,
        name: str = None,
        value: str = None,
        value_type: str = None,
    ):
        # 字段唯一标识
        self.code = code
        # 字段中文描述
        self.name = name
        # 字段的取值
        self.value = value
        # 字段的类型(string,number,boolean)
        self.value_type = value_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        if self.value_type is not None:
            result['valueType'] = self.value_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        if m.get('valueType') is not None:
            self.value_type = m.get('valueType')
        return self


class IndustryManufactureMesTeamMgmtRequestGroupPlugins(TeaModel):
    def __init__(
        self,
        label: str = None,
        value: str = None,
    ):
        self.label = label
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.label is not None:
            result['label'] = self.label
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class IndustryManufactureMesTeamMgmtRequestLeaders(TeaModel):
    def __init__(
        self,
        name: str = None,
        user_id: str = None,
    ):
        # 工人姓名
        self.name = name
        # 工人staffNo
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class IndustryManufactureMesTeamMgmtRequestMembers(TeaModel):
    def __init__(
        self,
        name: str = None,
        user_id: str = None,
    ):
        # 工人姓名
        self.name = name
        # 工人staffNo
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class IndustryManufactureMesTeamMgmtRequest(TeaModel):
    def __init__(
        self,
        action: str = None,
        app_key: str = None,
        base_data_name: str = None,
        events: List[str] = None,
        extend_data: List[IndustryManufactureMesTeamMgmtRequestExtendData] = None,
        group_config: Dict[str, Any] = None,
        group_plugins: List[IndustryManufactureMesTeamMgmtRequestGroupPlugins] = None,
        group_type: str = None,
        id: str = None,
        leaders: List[IndustryManufactureMesTeamMgmtRequestLeaders] = None,
        members: List[IndustryManufactureMesTeamMgmtRequestMembers] = None,
        name: str = None,
        process_ids: List[str] = None,
        tag_key: str = None,
        tag_values: List[str] = None,
    ):
        # 本次操作的行为，取值： ● add：增加   -- 创建群 ● update：更新 -- 群成员变更
        self.action = action
        # ISV的唯一标识,由BPaaS分配
        self.app_key = app_key
        # 基础数据名称。比如班组
        self.base_data_name = base_data_name
        # 事件配置列表(启用卡片列表),所有枚举值： 任务分配提醒: TASK_ASSIGN_REMINDER 任务逾期提醒: TASK_OVERDUE_REMINDER 置顶加急任务: STICK_URGET_TASK 报工审批提醒: OUTPUT_APPROVE_REMINDER 报工审批反馈: OUTPUT_APPROVE_RESULT 班组概览 :TEAM_OVERVIEW 我的任务:MYTASK_OVERVIEW     例如： ["STICK_URGET_TASK","OUTPUT_APPROVE_REMINDER"]
        self.events = events
        # 扩展字段
        self.extend_data = extend_data
        # 群配置
        self.group_config = group_config
        # 群插件列表
        self.group_plugins = group_plugins
        # 群类型，枚举
        self.group_type = group_type
        # 班组模型实例的唯一Id， 由业务方传递
        self.id = id
        # 班组长(支持多个)
        self.leaders = leaders
        # 班组成员(群成员)
        self.members = members
        # 班组群名称
        self.name = name
        # 关联的工序
        self.process_ids = process_ids
        # 业务tagKey
        self.tag_key = tag_key
        # 业务tagValues
        self.tag_values = tag_values

    def validate(self):
        if self.extend_data:
            for k in self.extend_data:
                if k:
                    k.validate()
        if self.group_plugins:
            for k in self.group_plugins:
                if k:
                    k.validate()
        if self.leaders:
            for k in self.leaders:
                if k:
                    k.validate()
        if self.members:
            for k in self.members:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action is not None:
            result['action'] = self.action
        if self.app_key is not None:
            result['appKey'] = self.app_key
        if self.base_data_name is not None:
            result['baseDataName'] = self.base_data_name
        if self.events is not None:
            result['events'] = self.events
        result['extendData'] = []
        if self.extend_data is not None:
            for k in self.extend_data:
                result['extendData'].append(k.to_map() if k else None)
        if self.group_config is not None:
            result['groupConfig'] = self.group_config
        result['groupPlugins'] = []
        if self.group_plugins is not None:
            for k in self.group_plugins:
                result['groupPlugins'].append(k.to_map() if k else None)
        if self.group_type is not None:
            result['groupType'] = self.group_type
        if self.id is not None:
            result['id'] = self.id
        result['leaders'] = []
        if self.leaders is not None:
            for k in self.leaders:
                result['leaders'].append(k.to_map() if k else None)
        result['members'] = []
        if self.members is not None:
            for k in self.members:
                result['members'].append(k.to_map() if k else None)
        if self.name is not None:
            result['name'] = self.name
        if self.process_ids is not None:
            result['processIds'] = self.process_ids
        if self.tag_key is not None:
            result['tagKey'] = self.tag_key
        if self.tag_values is not None:
            result['tagValues'] = self.tag_values
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('action') is not None:
            self.action = m.get('action')
        if m.get('appKey') is not None:
            self.app_key = m.get('appKey')
        if m.get('baseDataName') is not None:
            self.base_data_name = m.get('baseDataName')
        if m.get('events') is not None:
            self.events = m.get('events')
        self.extend_data = []
        if m.get('extendData') is not None:
            for k in m.get('extendData'):
                temp_model = IndustryManufactureMesTeamMgmtRequestExtendData()
                self.extend_data.append(temp_model.from_map(k))
        if m.get('groupConfig') is not None:
            self.group_config = m.get('groupConfig')
        self.group_plugins = []
        if m.get('groupPlugins') is not None:
            for k in m.get('groupPlugins'):
                temp_model = IndustryManufactureMesTeamMgmtRequestGroupPlugins()
                self.group_plugins.append(temp_model.from_map(k))
        if m.get('groupType') is not None:
            self.group_type = m.get('groupType')
        if m.get('id') is not None:
            self.id = m.get('id')
        self.leaders = []
        if m.get('leaders') is not None:
            for k in m.get('leaders'):
                temp_model = IndustryManufactureMesTeamMgmtRequestLeaders()
                self.leaders.append(temp_model.from_map(k))
        self.members = []
        if m.get('members') is not None:
            for k in m.get('members'):
                temp_model = IndustryManufactureMesTeamMgmtRequestMembers()
                self.members.append(temp_model.from_map(k))
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('processIds') is not None:
            self.process_ids = m.get('processIds')
        if m.get('tagKey') is not None:
            self.tag_key = m.get('tagKey')
        if m.get('tagValues') is not None:
            self.tag_values = m.get('tagValues')
        return self


class IndustryManufactureMesTeamMgmtResponseBodyResult(TeaModel):
    def __init__(
        self,
        content: str = None,
    ):
        self.content = content

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        return self


class IndustryManufactureMesTeamMgmtResponseBody(TeaModel):
    def __init__(
        self,
        ding_open_errcode: int = None,
        error_msg: str = None,
        result: IndustryManufactureMesTeamMgmtResponseBodyResult = None,
    ):
        self.ding_open_errcode = ding_open_errcode
        self.error_msg = error_msg
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_open_errcode is not None:
            result['dingOpenErrcode'] = self.ding_open_errcode
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingOpenErrcode') is not None:
            self.ding_open_errcode = m.get('dingOpenErrcode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('result') is not None:
            temp_model = IndustryManufactureMesTeamMgmtResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class IndustryManufactureMesTeamMgmtResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: IndustryManufactureMesTeamMgmtResponseBody = None,
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
            temp_model = IndustryManufactureMesTeamMgmtResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class IndustryMmanufactureMaterialCostGetHeaders(TeaModel):
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


class IndustryMmanufactureMaterialCostGetRequest(TeaModel):
    def __init__(
        self,
        app_id: int = None,
        app_ids: List[int] = None,
        app_name: str = None,
        corp_id: str = None,
        cursor: int = None,
        end_time: int = None,
        instance_id: str = None,
        isv_org_id: int = None,
        material_no: str = None,
        microapp_agent_id: int = None,
        org_id: int = None,
        page_number: int = None,
        page_size: int = None,
        start_time: int = None,
        suite_key: str = None,
        token_grant_type: int = None,
    ):
        self.app_id = app_id
        self.app_ids = app_ids
        self.app_name = app_name
        self.corp_id = corp_id
        self.cursor = cursor
        self.end_time = end_time
        self.instance_id = instance_id
        self.isv_org_id = isv_org_id
        self.material_no = material_no
        self.microapp_agent_id = microapp_agent_id
        self.org_id = org_id
        self.page_number = page_number
        self.page_size = page_size
        self.start_time = start_time
        self.suite_key = suite_key
        self.token_grant_type = token_grant_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.app_ids is not None:
            result['appIds'] = self.app_ids
        if self.app_name is not None:
            result['appName'] = self.app_name
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.cursor is not None:
            result['cursor'] = self.cursor
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.isv_org_id is not None:
            result['isvOrgId'] = self.isv_org_id
        if self.material_no is not None:
            result['materialNo'] = self.material_no
        if self.microapp_agent_id is not None:
            result['microappAgentId'] = self.microapp_agent_id
        if self.org_id is not None:
            result['orgId'] = self.org_id
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.suite_key is not None:
            result['suiteKey'] = self.suite_key
        if self.token_grant_type is not None:
            result['tokenGrantType'] = self.token_grant_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('appIds') is not None:
            self.app_ids = m.get('appIds')
        if m.get('appName') is not None:
            self.app_name = m.get('appName')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('cursor') is not None:
            self.cursor = m.get('cursor')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('isvOrgId') is not None:
            self.isv_org_id = m.get('isvOrgId')
        if m.get('materialNo') is not None:
            self.material_no = m.get('materialNo')
        if m.get('microappAgentId') is not None:
            self.microapp_agent_id = m.get('microappAgentId')
        if m.get('orgId') is not None:
            self.org_id = m.get('orgId')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('suiteKey') is not None:
            self.suite_key = m.get('suiteKey')
        if m.get('tokenGrantType') is not None:
            self.token_grant_type = m.get('tokenGrantType')
        return self


class IndustryMmanufactureMaterialCostGetResponseBodyList(TeaModel):
    def __init__(
        self,
        act_price: float = None,
        corp_id: str = None,
        count: float = None,
        ext: str = None,
        gmt_create: int = None,
        gmt_modified: int = None,
        instance_id: str = None,
        material_cost_no: str = None,
        material_name: str = None,
        material_no: str = None,
        memo: str = None,
        price: float = None,
        process_code: str = None,
        unit: str = None,
    ):
        self.act_price = act_price
        self.corp_id = corp_id
        self.count = count
        self.ext = ext
        self.gmt_create = gmt_create
        self.gmt_modified = gmt_modified
        self.instance_id = instance_id
        self.material_cost_no = material_cost_no
        self.material_name = material_name
        self.material_no = material_no
        self.memo = memo
        self.price = price
        self.process_code = process_code
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.act_price is not None:
            result['actPrice'] = self.act_price
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.count is not None:
            result['count'] = self.count
        if self.ext is not None:
            result['ext'] = self.ext
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.material_cost_no is not None:
            result['materialCostNo'] = self.material_cost_no
        if self.material_name is not None:
            result['materialName'] = self.material_name
        if self.material_no is not None:
            result['materialNo'] = self.material_no
        if self.memo is not None:
            result['memo'] = self.memo
        if self.price is not None:
            result['price'] = self.price
        if self.process_code is not None:
            result['processCode'] = self.process_code
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actPrice') is not None:
            self.act_price = m.get('actPrice')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('count') is not None:
            self.count = m.get('count')
        if m.get('ext') is not None:
            self.ext = m.get('ext')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('materialCostNo') is not None:
            self.material_cost_no = m.get('materialCostNo')
        if m.get('materialName') is not None:
            self.material_name = m.get('materialName')
        if m.get('materialNo') is not None:
            self.material_no = m.get('materialNo')
        if m.get('memo') is not None:
            self.memo = m.get('memo')
        if m.get('price') is not None:
            self.price = m.get('price')
        if m.get('processCode') is not None:
            self.process_code = m.get('processCode')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class IndustryMmanufactureMaterialCostGetResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[IndustryMmanufactureMaterialCostGetResponseBodyList] = None,
        next_cursor: int = None,
        total_count: int = None,
    ):
        self.has_more = has_more
        self.list = list
        self.next_cursor = next_cursor
        self.total_count = total_count

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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        if self.next_cursor is not None:
            result['nextCursor'] = self.next_cursor
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = IndustryMmanufactureMaterialCostGetResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextCursor') is not None:
            self.next_cursor = m.get('nextCursor')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class IndustryMmanufactureMaterialCostGetResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: IndustryMmanufactureMaterialCostGetResponseBody = None,
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
            temp_model = IndustryMmanufactureMaterialCostGetResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PushDingMessageHeaders(TeaModel):
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


class PushDingMessageRequest(TeaModel):
    def __init__(
        self,
        app_id: int = None,
        content: str = None,
        message_type: str = None,
        message_url: str = None,
        picture_url: str = None,
        single_title: str = None,
        single_url: str = None,
        title: str = None,
        user_id_list: List[str] = None,
    ):
        # 应用Id，默认是医疗的应用。
        self.app_id = app_id
        # 消息内容，长度不超过500。
        self.content = content
        # 消息类型：CARD:卡片消息；LINK:链接消息；TEXT：文本消息；
        self.message_type = message_type
        # 链接消息时，消息文案下的URL。
        self.message_url = message_url
        # 链接消息时，右侧图片URL。
        self.picture_url = picture_url
        # 卡片消息时，消息下面action的标题，长度不超过20。
        self.single_title = single_title
        # 卡片消息时，消息下面action转跳URL，长度不超过500。
        self.single_url = single_url
        # 消息展示标题，长度不超过100。
        self.title = title
        # 组织下的staffId列表
        self.user_id_list = user_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.content is not None:
            result['content'] = self.content
        if self.message_type is not None:
            result['messageType'] = self.message_type
        if self.message_url is not None:
            result['messageUrl'] = self.message_url
        if self.picture_url is not None:
            result['pictureUrl'] = self.picture_url
        if self.single_title is not None:
            result['singleTitle'] = self.single_title
        if self.single_url is not None:
            result['singleUrl'] = self.single_url
        if self.title is not None:
            result['title'] = self.title
        if self.user_id_list is not None:
            result['userIdList'] = self.user_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('messageType') is not None:
            self.message_type = m.get('messageType')
        if m.get('messageUrl') is not None:
            self.message_url = m.get('messageUrl')
        if m.get('pictureUrl') is not None:
            self.picture_url = m.get('pictureUrl')
        if m.get('singleTitle') is not None:
            self.single_title = m.get('singleTitle')
        if m.get('singleUrl') is not None:
            self.single_url = m.get('singleUrl')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('userIdList') is not None:
            self.user_id_list = m.get('userIdList')
        return self


class PushDingMessageResponseBody(TeaModel):
    def __init__(
        self,
        content: int = None,
        success: bool = None,
    ):
        # 返回1表示当前批次成功
        self.content = content
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class PushDingMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: PushDingMessageResponseBody = None,
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
            temp_model = PushDingMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryAllDepartmentHeaders(TeaModel):
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


class QueryAllDepartmentRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
    ):
        # 分页查询页码
        self.page_number = page_number
        # 分页查询分页大小
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class QueryAllDepartmentResponseBodyContentDeptAndExtDepartment(TeaModel):
    def __init__(
        self,
        dept_code: str = None,
        dept_name: str = None,
        dept_order: int = None,
        dept_status: int = None,
        dept_type: int = None,
        gmt_create_str: str = None,
        gmt_modified_str: str = None,
        id: int = None,
        name: str = None,
        parent_dept_code: str = None,
        remark: str = None,
        ward_id_list: List[int] = None,
    ):
        # 部门code
        self.dept_code = dept_code
        # 科室名称，同name
        self.dept_name = dept_name
        # 排序
        self.dept_order = dept_order
        # 部门状态：0-正常，1-删除
        self.dept_status = dept_status
        # 部门类型：1-科室，2-医疗组
        self.dept_type = dept_type
        # 创建时间
        self.gmt_create_str = gmt_create_str
        # 修改时间
        self.gmt_modified_str = gmt_modified_str
        # 科室ID
        self.id = id
        # 科室名称，同deptName
        self.name = name
        # 父部门code（与dept_code来源保持一致）
        self.parent_dept_code = parent_dept_code
        # 备注
        self.remark = remark
        # 病区id列表
        self.ward_id_list = ward_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_code is not None:
            result['deptCode'] = self.dept_code
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.dept_order is not None:
            result['deptOrder'] = self.dept_order
        if self.dept_status is not None:
            result['deptStatus'] = self.dept_status
        if self.dept_type is not None:
            result['deptType'] = self.dept_type
        if self.gmt_create_str is not None:
            result['gmtCreateStr'] = self.gmt_create_str
        if self.gmt_modified_str is not None:
            result['gmtModifiedStr'] = self.gmt_modified_str
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.parent_dept_code is not None:
            result['parentDeptCode'] = self.parent_dept_code
        if self.remark is not None:
            result['remark'] = self.remark
        if self.ward_id_list is not None:
            result['wardIdList'] = self.ward_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptCode') is not None:
            self.dept_code = m.get('deptCode')
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('deptOrder') is not None:
            self.dept_order = m.get('deptOrder')
        if m.get('deptStatus') is not None:
            self.dept_status = m.get('deptStatus')
        if m.get('deptType') is not None:
            self.dept_type = m.get('deptType')
        if m.get('gmtCreateStr') is not None:
            self.gmt_create_str = m.get('gmtCreateStr')
        if m.get('gmtModifiedStr') is not None:
            self.gmt_modified_str = m.get('gmtModifiedStr')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('parentDeptCode') is not None:
            self.parent_dept_code = m.get('parentDeptCode')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('wardIdList') is not None:
            self.ward_id_list = m.get('wardIdList')
        return self


class QueryAllDepartmentResponseBodyContentDeptAndExtExtendInfos(TeaModel):
    def __init__(
        self,
        dept_code: str = None,
        dept_extend_display_name: str = None,
        dept_extend_key: str = None,
        dept_extend_value: str = None,
        gmt_create_str: str = None,
        gmt_modified_str: str = None,
        id: int = None,
        status: int = None,
    ):
        # 部门code
        self.dept_code = dept_code
        # 科室扩展字段描述
        self.dept_extend_display_name = dept_extend_display_name
        # 科室扩展字段key
        self.dept_extend_key = dept_extend_key
        # 科室扩展字段value
        self.dept_extend_value = dept_extend_value
        # 创建时间
        self.gmt_create_str = gmt_create_str
        # 修改时间
        self.gmt_modified_str = gmt_modified_str
        # 扩展信息id
        self.id = id
        # 0-有效 ，1-无效
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_code is not None:
            result['deptCode'] = self.dept_code
        if self.dept_extend_display_name is not None:
            result['deptExtendDisplayName'] = self.dept_extend_display_name
        if self.dept_extend_key is not None:
            result['deptExtendKey'] = self.dept_extend_key
        if self.dept_extend_value is not None:
            result['deptExtendValue'] = self.dept_extend_value
        if self.gmt_create_str is not None:
            result['gmtCreateStr'] = self.gmt_create_str
        if self.gmt_modified_str is not None:
            result['gmtModifiedStr'] = self.gmt_modified_str
        if self.id is not None:
            result['id'] = self.id
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptCode') is not None:
            self.dept_code = m.get('deptCode')
        if m.get('deptExtendDisplayName') is not None:
            self.dept_extend_display_name = m.get('deptExtendDisplayName')
        if m.get('deptExtendKey') is not None:
            self.dept_extend_key = m.get('deptExtendKey')
        if m.get('deptExtendValue') is not None:
            self.dept_extend_value = m.get('deptExtendValue')
        if m.get('gmtCreateStr') is not None:
            self.gmt_create_str = m.get('gmtCreateStr')
        if m.get('gmtModifiedStr') is not None:
            self.gmt_modified_str = m.get('gmtModifiedStr')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class QueryAllDepartmentResponseBodyContentDeptAndExt(TeaModel):
    def __init__(
        self,
        department: QueryAllDepartmentResponseBodyContentDeptAndExtDepartment = None,
        extend_infos: List[QueryAllDepartmentResponseBodyContentDeptAndExtExtendInfos] = None,
    ):
        # 科室详情
        self.department = department
        # 科室扩展信息列表
        self.extend_infos = extend_infos

    def validate(self):
        if self.department:
            self.department.validate()
        if self.extend_infos:
            for k in self.extend_infos:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.department is not None:
            result['department'] = self.department.to_map()
        result['extendInfos'] = []
        if self.extend_infos is not None:
            for k in self.extend_infos:
                result['extendInfos'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('department') is not None:
            temp_model = QueryAllDepartmentResponseBodyContentDeptAndExtDepartment()
            self.department = temp_model.from_map(m['department'])
        self.extend_infos = []
        if m.get('extendInfos') is not None:
            for k in m.get('extendInfos'):
                temp_model = QueryAllDepartmentResponseBodyContentDeptAndExtExtendInfos()
                self.extend_infos.append(temp_model.from_map(k))
        return self


class QueryAllDepartmentResponseBodyContentGroupAndExtListExtendInfos(TeaModel):
    def __init__(
        self,
        dept_code: str = None,
        dept_extend_display_name: str = None,
        dept_extend_key: str = None,
        dept_extend_value: str = None,
        gmt_create_str: str = None,
        gmt_modified_str: str = None,
        id: int = None,
        status: int = None,
    ):
        # 部门code
        self.dept_code = dept_code
        # 医疗组扩展字段描述
        self.dept_extend_display_name = dept_extend_display_name
        # 医疗组扩展字段key
        self.dept_extend_key = dept_extend_key
        # 医疗组扩展字段value
        self.dept_extend_value = dept_extend_value
        # 创建时间
        self.gmt_create_str = gmt_create_str
        # 修改时间
        self.gmt_modified_str = gmt_modified_str
        # 扩展信息id
        self.id = id
        # 0-有效 ，1-无效
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_code is not None:
            result['deptCode'] = self.dept_code
        if self.dept_extend_display_name is not None:
            result['deptExtendDisplayName'] = self.dept_extend_display_name
        if self.dept_extend_key is not None:
            result['deptExtendKey'] = self.dept_extend_key
        if self.dept_extend_value is not None:
            result['deptExtendValue'] = self.dept_extend_value
        if self.gmt_create_str is not None:
            result['gmtCreateStr'] = self.gmt_create_str
        if self.gmt_modified_str is not None:
            result['gmtModifiedStr'] = self.gmt_modified_str
        if self.id is not None:
            result['id'] = self.id
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptCode') is not None:
            self.dept_code = m.get('deptCode')
        if m.get('deptExtendDisplayName') is not None:
            self.dept_extend_display_name = m.get('deptExtendDisplayName')
        if m.get('deptExtendKey') is not None:
            self.dept_extend_key = m.get('deptExtendKey')
        if m.get('deptExtendValue') is not None:
            self.dept_extend_value = m.get('deptExtendValue')
        if m.get('gmtCreateStr') is not None:
            self.gmt_create_str = m.get('gmtCreateStr')
        if m.get('gmtModifiedStr') is not None:
            self.gmt_modified_str = m.get('gmtModifiedStr')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class QueryAllDepartmentResponseBodyContentGroupAndExtListGroupLeader(TeaModel):
    def __init__(
        self,
        job_number: str = None,
        name: str = None,
        user_id: str = None,
    ):
        # 用户工号
        self.job_number = job_number
        # 姓名
        self.name = name
        # 用户ID
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.job_number is not None:
            result['jobNumber'] = self.job_number
        if self.name is not None:
            result['name'] = self.name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('jobNumber') is not None:
            self.job_number = m.get('jobNumber')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryAllDepartmentResponseBodyContentGroupAndExtListGroup(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        dept_status: int = None,
        gmt_create_str: str = None,
        gmt_modified_str: str = None,
        id: int = None,
        leader: QueryAllDepartmentResponseBodyContentGroupAndExtListGroupLeader = None,
        name: str = None,
        parent_dept_code: str = None,
        remark: str = None,
    ):
        # 科室ID，同parentDeptCode，这里保留是做兼容，原来定义成Long不太好改成了String了
        self.dept_id = dept_id
        # 部门状态：0-正常，1-删除
        self.dept_status = dept_status
        # 创建时间
        self.gmt_create_str = gmt_create_str
        # 修改时间
        self.gmt_modified_str = gmt_modified_str
        # 医疗组ID
        self.id = id
        # 医疗组组长信息
        self.leader = leader
        # 医疗组名称
        self.name = name
        # 父级组织id，这里医疗组的父级就是科室
        self.parent_dept_code = parent_dept_code
        # 备注
        self.remark = remark

    def validate(self):
        if self.leader:
            self.leader.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.dept_status is not None:
            result['deptStatus'] = self.dept_status
        if self.gmt_create_str is not None:
            result['gmtCreateStr'] = self.gmt_create_str
        if self.gmt_modified_str is not None:
            result['gmtModifiedStr'] = self.gmt_modified_str
        if self.id is not None:
            result['id'] = self.id
        if self.leader is not None:
            result['leader'] = self.leader.to_map()
        if self.name is not None:
            result['name'] = self.name
        if self.parent_dept_code is not None:
            result['parentDeptCode'] = self.parent_dept_code
        if self.remark is not None:
            result['remark'] = self.remark
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('deptStatus') is not None:
            self.dept_status = m.get('deptStatus')
        if m.get('gmtCreateStr') is not None:
            self.gmt_create_str = m.get('gmtCreateStr')
        if m.get('gmtModifiedStr') is not None:
            self.gmt_modified_str = m.get('gmtModifiedStr')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('leader') is not None:
            temp_model = QueryAllDepartmentResponseBodyContentGroupAndExtListGroupLeader()
            self.leader = temp_model.from_map(m['leader'])
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('parentDeptCode') is not None:
            self.parent_dept_code = m.get('parentDeptCode')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        return self


class QueryAllDepartmentResponseBodyContentGroupAndExtList(TeaModel):
    def __init__(
        self,
        extend_infos: List[QueryAllDepartmentResponseBodyContentGroupAndExtListExtendInfos] = None,
        group: QueryAllDepartmentResponseBodyContentGroupAndExtListGroup = None,
    ):
        # 医疗组扩展信息列表
        self.extend_infos = extend_infos
        # 医疗组详细信息
        self.group = group

    def validate(self):
        if self.extend_infos:
            for k in self.extend_infos:
                if k:
                    k.validate()
        if self.group:
            self.group.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['extendInfos'] = []
        if self.extend_infos is not None:
            for k in self.extend_infos:
                result['extendInfos'].append(k.to_map() if k else None)
        if self.group is not None:
            result['group'] = self.group.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.extend_infos = []
        if m.get('extendInfos') is not None:
            for k in m.get('extendInfos'):
                temp_model = QueryAllDepartmentResponseBodyContentGroupAndExtListExtendInfos()
                self.extend_infos.append(temp_model.from_map(k))
        if m.get('group') is not None:
            temp_model = QueryAllDepartmentResponseBodyContentGroupAndExtListGroup()
            self.group = temp_model.from_map(m['group'])
        return self


class QueryAllDepartmentResponseBodyContent(TeaModel):
    def __init__(
        self,
        dept_and_ext: QueryAllDepartmentResponseBodyContentDeptAndExt = None,
        group_and_ext_list: List[QueryAllDepartmentResponseBodyContentGroupAndExtList] = None,
        id: int = None,
        name: str = None,
    ):
        # 科室详情
        self.dept_and_ext = dept_and_ext
        # 医疗组列表
        self.group_and_ext_list = group_and_ext_list
        # 科室ID
        self.id = id
        # 科室名称
        self.name = name

    def validate(self):
        if self.dept_and_ext:
            self.dept_and_ext.validate()
        if self.group_and_ext_list:
            for k in self.group_and_ext_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_and_ext is not None:
            result['deptAndExt'] = self.dept_and_ext.to_map()
        result['groupAndExtList'] = []
        if self.group_and_ext_list is not None:
            for k in self.group_and_ext_list:
                result['groupAndExtList'].append(k.to_map() if k else None)
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptAndExt') is not None:
            temp_model = QueryAllDepartmentResponseBodyContentDeptAndExt()
            self.dept_and_ext = temp_model.from_map(m['deptAndExt'])
        self.group_and_ext_list = []
        if m.get('groupAndExtList') is not None:
            for k in m.get('groupAndExtList'):
                temp_model = QueryAllDepartmentResponseBodyContentGroupAndExtList()
                self.group_and_ext_list.append(temp_model.from_map(k))
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class QueryAllDepartmentResponseBody(TeaModel):
    def __init__(
        self,
        content: List[QueryAllDepartmentResponseBodyContent] = None,
        current_page: int = None,
        total_count: int = None,
        total_pages: int = None,
    ):
        # 科室列表
        self.content = content
        # 当前页码
        self.current_page = current_page
        # 数据总量
        self.total_count = total_count
        # 总页数
        self.total_pages = total_pages

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        if self.current_page is not None:
            result['currentPage'] = self.current_page
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        if self.total_pages is not None:
            result['totalPages'] = self.total_pages
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = QueryAllDepartmentResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        if m.get('currentPage') is not None:
            self.current_page = m.get('currentPage')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        if m.get('totalPages') is not None:
            self.total_pages = m.get('totalPages')
        return self


class QueryAllDepartmentResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryAllDepartmentResponseBody = None,
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
            temp_model = QueryAllDepartmentResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryAllDoctorsHeaders(TeaModel):
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


class QueryAllDoctorsRequest(TeaModel):
    def __init__(
        self,
        month_mark: str = None,
        page_num: int = None,
        page_size: int = None,
    ):
        self.month_mark = month_mark
        # 分页查询页码
        self.page_num = page_num
        # 分页查询页容量
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.month_mark is not None:
            result['monthMark'] = self.month_mark
        if self.page_num is not None:
            result['pageNum'] = self.page_num
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('monthMark') is not None:
            self.month_mark = m.get('monthMark')
        if m.get('pageNum') is not None:
            self.page_num = m.get('pageNum')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class QueryAllDoctorsResponseBodyContent(TeaModel):
    def __init__(
        self,
        assess_group_id: str = None,
        assess_group_name: str = None,
        dept_code: str = None,
        dept_type: str = None,
        gmt_create_str: str = None,
        gmt_modified_str: str = None,
        id: int = None,
        job_num: str = None,
        status: int = None,
        uid: str = None,
        user_code: str = None,
        user_name: str = None,
    ):
        # 考核医疗组id
        self.assess_group_id = assess_group_id
        # 考核医疗组名称
        self.assess_group_name = assess_group_name
        # 关联的部门id
        self.dept_code = dept_code
        # 科室医疗组标识
        self.dept_type = dept_type
        # 用户创建时间
        self.gmt_create_str = gmt_create_str
        # 用户最后修改时间
        self.gmt_modified_str = gmt_modified_str
        # 用户id
        self.id = id
        # 工号
        self.job_num = job_num
        # 状态0-有效，1-删除
        self.status = status
        # 租户下staffId
        self.uid = uid
        # 租户内staffId
        self.user_code = user_code
        # 用户名称
        self.user_name = user_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.assess_group_id is not None:
            result['assessGroupId'] = self.assess_group_id
        if self.assess_group_name is not None:
            result['assessGroupName'] = self.assess_group_name
        if self.dept_code is not None:
            result['deptCode'] = self.dept_code
        if self.dept_type is not None:
            result['deptType'] = self.dept_type
        if self.gmt_create_str is not None:
            result['gmtCreateStr'] = self.gmt_create_str
        if self.gmt_modified_str is not None:
            result['gmtModifiedStr'] = self.gmt_modified_str
        if self.id is not None:
            result['id'] = self.id
        if self.job_num is not None:
            result['jobNum'] = self.job_num
        if self.status is not None:
            result['status'] = self.status
        if self.uid is not None:
            result['uid'] = self.uid
        if self.user_code is not None:
            result['userCode'] = self.user_code
        if self.user_name is not None:
            result['userName'] = self.user_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('assessGroupId') is not None:
            self.assess_group_id = m.get('assessGroupId')
        if m.get('assessGroupName') is not None:
            self.assess_group_name = m.get('assessGroupName')
        if m.get('deptCode') is not None:
            self.dept_code = m.get('deptCode')
        if m.get('deptType') is not None:
            self.dept_type = m.get('deptType')
        if m.get('gmtCreateStr') is not None:
            self.gmt_create_str = m.get('gmtCreateStr')
        if m.get('gmtModifiedStr') is not None:
            self.gmt_modified_str = m.get('gmtModifiedStr')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('jobNum') is not None:
            self.job_num = m.get('jobNum')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('uid') is not None:
            self.uid = m.get('uid')
        if m.get('userCode') is not None:
            self.user_code = m.get('userCode')
        if m.get('userName') is not None:
            self.user_name = m.get('userName')
        return self


class QueryAllDoctorsResponseBody(TeaModel):
    def __init__(
        self,
        content: List[QueryAllDoctorsResponseBodyContent] = None,
        current_page: int = None,
        total_count: int = None,
        total_pages: int = None,
    ):
        # 人员列表
        self.content = content
        # 当前页码
        self.current_page = current_page
        # 数据总量
        self.total_count = total_count
        # 总页数
        self.total_pages = total_pages

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        if self.current_page is not None:
            result['currentPage'] = self.current_page
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        if self.total_pages is not None:
            result['totalPages'] = self.total_pages
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = QueryAllDoctorsResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        if m.get('currentPage') is not None:
            self.current_page = m.get('currentPage')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        if m.get('totalPages') is not None:
            self.total_pages = m.get('totalPages')
        return self


class QueryAllDoctorsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryAllDoctorsResponseBody = None,
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
            temp_model = QueryAllDoctorsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryAllGroupHeaders(TeaModel):
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


class QueryAllGroupRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
    ):
        # 分页查询页码
        self.page_number = page_number
        # 分页查询页容量
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class QueryAllGroupResponseBodyContent(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        id: int = None,
        name: str = None,
    ):
        # 所在科室Id
        self.dept_id = dept_id
        # 医疗组Id
        self.id = id
        # 医疗组名称
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
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class QueryAllGroupResponseBody(TeaModel):
    def __init__(
        self,
        content: List[QueryAllGroupResponseBodyContent] = None,
        current_page: int = None,
        total_count: int = None,
        total_pages: int = None,
    ):
        # Id of the request
        self.content = content
        # 当前页码
        self.current_page = current_page
        # 数据总量
        self.total_count = total_count
        # 总页数
        self.total_pages = total_pages

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        if self.current_page is not None:
            result['currentPage'] = self.current_page
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        if self.total_pages is not None:
            result['totalPages'] = self.total_pages
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = QueryAllGroupResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        if m.get('currentPage') is not None:
            self.current_page = m.get('currentPage')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        if m.get('totalPages') is not None:
            self.total_pages = m.get('totalPages')
        return self


class QueryAllGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryAllGroupResponseBody = None,
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
            temp_model = QueryAllGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryAllGroupsInDeptHeaders(TeaModel):
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


class QueryAllGroupsInDeptRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
    ):
        # 分页查询页码
        self.page_number = page_number
        # 分页查询页容量
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class QueryAllGroupsInDeptResponseBodyContent(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        id: int = None,
        name: str = None,
    ):
        # 所在科室Id
        self.dept_id = dept_id
        # 医疗组Id
        self.id = id
        # 医疗组名称
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
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class QueryAllGroupsInDeptResponseBody(TeaModel):
    def __init__(
        self,
        content: List[QueryAllGroupsInDeptResponseBodyContent] = None,
        current_page: int = None,
        total_count: int = None,
        total_pages: int = None,
    ):
        # Id of the request
        self.content = content
        # 当前页码
        self.current_page = current_page
        # 数据总量
        self.total_count = total_count
        # 总页数
        self.total_pages = total_pages

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        if self.current_page is not None:
            result['currentPage'] = self.current_page
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        if self.total_pages is not None:
            result['totalPages'] = self.total_pages
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = QueryAllGroupsInDeptResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        if m.get('currentPage') is not None:
            self.current_page = m.get('currentPage')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        if m.get('totalPages') is not None:
            self.total_pages = m.get('totalPages')
        return self


class QueryAllGroupsInDeptResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryAllGroupsInDeptResponseBody = None,
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
            temp_model = QueryAllGroupsInDeptResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryAllMemberByDeptHeaders(TeaModel):
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


class QueryAllMemberByDeptRequest(TeaModel):
    def __init__(
        self,
        month_mark: str = None,
        page_number: int = None,
        page_size: int = None,
    ):
        # 按月查询标识
        self.month_mark = month_mark
        # 分页查询页码
        self.page_number = page_number
        # 分页查询页容量
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.month_mark is not None:
            result['monthMark'] = self.month_mark
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('monthMark') is not None:
            self.month_mark = m.get('monthMark')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class QueryAllMemberByDeptResponseBodyContent(TeaModel):
    def __init__(
        self,
        job_num: str = None,
        uid: str = None,
        user_name: str = None,
    ):
        # 工号
        self.job_num = job_num
        # 用户Id
        self.uid = uid
        # 用户名称
        self.user_name = user_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.job_num is not None:
            result['jobNum'] = self.job_num
        if self.uid is not None:
            result['uid'] = self.uid
        if self.user_name is not None:
            result['userName'] = self.user_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('jobNum') is not None:
            self.job_num = m.get('jobNum')
        if m.get('uid') is not None:
            self.uid = m.get('uid')
        if m.get('userName') is not None:
            self.user_name = m.get('userName')
        return self


class QueryAllMemberByDeptResponseBody(TeaModel):
    def __init__(
        self,
        content: List[QueryAllMemberByDeptResponseBodyContent] = None,
        current_page: int = None,
        total_count: int = None,
        total_pages: int = None,
    ):
        # 人员列表
        self.content = content
        # 当前页码
        self.current_page = current_page
        # 数据总量
        self.total_count = total_count
        # 总页数
        self.total_pages = total_pages

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        if self.current_page is not None:
            result['currentPage'] = self.current_page
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        if self.total_pages is not None:
            result['totalPages'] = self.total_pages
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = QueryAllMemberByDeptResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        if m.get('currentPage') is not None:
            self.current_page = m.get('currentPage')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        if m.get('totalPages') is not None:
            self.total_pages = m.get('totalPages')
        return self


class QueryAllMemberByDeptResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryAllMemberByDeptResponseBody = None,
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
            temp_model = QueryAllMemberByDeptResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryAllMemberByGroupHeaders(TeaModel):
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


class QueryAllMemberByGroupRequest(TeaModel):
    def __init__(
        self,
        month_mark: str = None,
        page_number: int = None,
        page_size: int = None,
    ):
        # 按月查询标识
        self.month_mark = month_mark
        # 分页查询页码
        self.page_number = page_number
        # 分页查询分页大小
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.month_mark is not None:
            result['monthMark'] = self.month_mark
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('monthMark') is not None:
            self.month_mark = m.get('monthMark')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class QueryAllMemberByGroupResponseBodyContent(TeaModel):
    def __init__(
        self,
        job_num: str = None,
        uid: str = None,
        user_name: str = None,
    ):
        # 工号
        self.job_num = job_num
        # 用户Id
        self.uid = uid
        # 用户名称
        self.user_name = user_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.job_num is not None:
            result['jobNum'] = self.job_num
        if self.uid is not None:
            result['uid'] = self.uid
        if self.user_name is not None:
            result['userName'] = self.user_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('jobNum') is not None:
            self.job_num = m.get('jobNum')
        if m.get('uid') is not None:
            self.uid = m.get('uid')
        if m.get('userName') is not None:
            self.user_name = m.get('userName')
        return self


class QueryAllMemberByGroupResponseBody(TeaModel):
    def __init__(
        self,
        content: List[QueryAllMemberByGroupResponseBodyContent] = None,
        current_page: int = None,
        total_count: int = None,
        total_pages: int = None,
    ):
        # 人员列表
        self.content = content
        # 当前页码
        self.current_page = current_page
        # 数据总量
        self.total_count = total_count
        # 总页数
        self.total_pages = total_pages

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        if self.current_page is not None:
            result['currentPage'] = self.current_page
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        if self.total_pages is not None:
            result['totalPages'] = self.total_pages
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = QueryAllMemberByGroupResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        if m.get('currentPage') is not None:
            self.current_page = m.get('currentPage')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        if m.get('totalPages') is not None:
            self.total_pages = m.get('totalPages')
        return self


class QueryAllMemberByGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryAllMemberByGroupResponseBody = None,
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
            temp_model = QueryAllMemberByGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryBizOptLogHeaders(TeaModel):
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


class QueryBizOptLogRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: int = None,
    ):
        # 每次拉取的数据量，最大200条
        self.max_results = max_results
        # 拉取记录的起始位置，默认从上次拉取的最后位置开始
        self.next_token = next_token

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class QueryBizOptLogResponseBodyContent(TeaModel):
    def __init__(
        self,
        biz_type: int = None,
        data_type: int = None,
        id: int = None,
        opt_after_data: str = None,
        opt_before_data: str = None,
        opt_biz_type: int = None,
        opt_extend: str = None,
        opt_job_number: str = None,
        opt_object_code: str = None,
        opt_object_name: str = None,
        opt_object_user_job_no: str = None,
        opt_success: int = None,
        opt_time: int = None,
        opt_type: int = None,
        opt_user_code: str = None,
        opt_user_name: str = None,
        remark: str = None,
    ):
        # 业务类型
        self.biz_type = biz_type
        # 数据类型
        self.data_type = data_type
        # 日志ID
        self.id = id
        # 操作后对象数据快照，json格式
        self.opt_after_data = opt_after_data
        # 操作前对象数据快照，json格式
        self.opt_before_data = opt_before_data
        # 操作业务类型
        self.opt_biz_type = opt_biz_type
        # 扩展信息，map json格式
        self.opt_extend = opt_extend
        # 操作者工号
        self.opt_job_number = opt_job_number
        # 操作对象code，人员code，或者部门code
        self.opt_object_code = opt_object_code
        # 操作对象名称
        self.opt_object_name = opt_object_name
        # 操作对象人员工号
        self.opt_object_user_job_no = opt_object_user_job_no
        # 操作是否成功
        self.opt_success = opt_success
        # 操作时间 时间戳
        self.opt_time = opt_time
        # 操作类型
        self.opt_type = opt_type
        # 操作用户code
        self.opt_user_code = opt_user_code
        # 操作用户名称
        self.opt_user_name = opt_user_name
        # 备注
        self.remark = remark

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.data_type is not None:
            result['dataType'] = self.data_type
        if self.id is not None:
            result['id'] = self.id
        if self.opt_after_data is not None:
            result['optAfterData'] = self.opt_after_data
        if self.opt_before_data is not None:
            result['optBeforeData'] = self.opt_before_data
        if self.opt_biz_type is not None:
            result['optBizType'] = self.opt_biz_type
        if self.opt_extend is not None:
            result['optExtend'] = self.opt_extend
        if self.opt_job_number is not None:
            result['optJobNumber'] = self.opt_job_number
        if self.opt_object_code is not None:
            result['optObjectCode'] = self.opt_object_code
        if self.opt_object_name is not None:
            result['optObjectName'] = self.opt_object_name
        if self.opt_object_user_job_no is not None:
            result['optObjectUserJobNo'] = self.opt_object_user_job_no
        if self.opt_success is not None:
            result['optSuccess'] = self.opt_success
        if self.opt_time is not None:
            result['optTime'] = self.opt_time
        if self.opt_type is not None:
            result['optType'] = self.opt_type
        if self.opt_user_code is not None:
            result['optUserCode'] = self.opt_user_code
        if self.opt_user_name is not None:
            result['optUserName'] = self.opt_user_name
        if self.remark is not None:
            result['remark'] = self.remark
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('dataType') is not None:
            self.data_type = m.get('dataType')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('optAfterData') is not None:
            self.opt_after_data = m.get('optAfterData')
        if m.get('optBeforeData') is not None:
            self.opt_before_data = m.get('optBeforeData')
        if m.get('optBizType') is not None:
            self.opt_biz_type = m.get('optBizType')
        if m.get('optExtend') is not None:
            self.opt_extend = m.get('optExtend')
        if m.get('optJobNumber') is not None:
            self.opt_job_number = m.get('optJobNumber')
        if m.get('optObjectCode') is not None:
            self.opt_object_code = m.get('optObjectCode')
        if m.get('optObjectName') is not None:
            self.opt_object_name = m.get('optObjectName')
        if m.get('optObjectUserJobNo') is not None:
            self.opt_object_user_job_no = m.get('optObjectUserJobNo')
        if m.get('optSuccess') is not None:
            self.opt_success = m.get('optSuccess')
        if m.get('optTime') is not None:
            self.opt_time = m.get('optTime')
        if m.get('optType') is not None:
            self.opt_type = m.get('optType')
        if m.get('optUserCode') is not None:
            self.opt_user_code = m.get('optUserCode')
        if m.get('optUserName') is not None:
            self.opt_user_name = m.get('optUserName')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        return self


class QueryBizOptLogResponseBody(TeaModel):
    def __init__(
        self,
        content: List[QueryBizOptLogResponseBodyContent] = None,
        next_token: int = None,
    ):
        # content
        self.content = content
        # 下次拉取数据的起始位置
        self.next_token = next_token

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = QueryBizOptLogResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class QueryBizOptLogResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryBizOptLogResponseBody = None,
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
            temp_model = QueryBizOptLogResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryDepartmentExtendInfoHeaders(TeaModel):
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


class QueryDepartmentExtendInfoRequest(TeaModel):
    def __init__(
        self,
        dept_code: int = None,
        prop_code: str = None,
    ):
        # 科室或医疗组code
        self.dept_code = dept_code
        # 扩展属性code
        self.prop_code = prop_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_code is not None:
            result['deptCode'] = self.dept_code
        if self.prop_code is not None:
            result['propCode'] = self.prop_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptCode') is not None:
            self.dept_code = m.get('deptCode')
        if m.get('propCode') is not None:
            self.prop_code = m.get('propCode')
        return self


class QueryDepartmentExtendInfoResponseBodyContent(TeaModel):
    def __init__(
        self,
        dept_code: str = None,
        dept_extend_display_name: str = None,
        dept_extend_key: str = None,
        dept_extend_value: str = None,
        gmt_create_str: str = None,
        gmt_modified_str: str = None,
        id: int = None,
        status: int = None,
    ):
        # 科室或医疗组code
        self.dept_code = dept_code
        # 扩展属性显示名称
        self.dept_extend_display_name = dept_extend_display_name
        # 扩展属性key
        self.dept_extend_key = dept_extend_key
        # 扩展属性value
        self.dept_extend_value = dept_extend_value
        # 创建时间
        self.gmt_create_str = gmt_create_str
        # 修改时间
        self.gmt_modified_str = gmt_modified_str
        # id
        self.id = id
        # 删除标识
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_code is not None:
            result['deptCode'] = self.dept_code
        if self.dept_extend_display_name is not None:
            result['deptExtendDisplayName'] = self.dept_extend_display_name
        if self.dept_extend_key is not None:
            result['deptExtendKey'] = self.dept_extend_key
        if self.dept_extend_value is not None:
            result['deptExtendValue'] = self.dept_extend_value
        if self.gmt_create_str is not None:
            result['gmtCreateStr'] = self.gmt_create_str
        if self.gmt_modified_str is not None:
            result['gmtModifiedStr'] = self.gmt_modified_str
        if self.id is not None:
            result['id'] = self.id
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptCode') is not None:
            self.dept_code = m.get('deptCode')
        if m.get('deptExtendDisplayName') is not None:
            self.dept_extend_display_name = m.get('deptExtendDisplayName')
        if m.get('deptExtendKey') is not None:
            self.dept_extend_key = m.get('deptExtendKey')
        if m.get('deptExtendValue') is not None:
            self.dept_extend_value = m.get('deptExtendValue')
        if m.get('gmtCreateStr') is not None:
            self.gmt_create_str = m.get('gmtCreateStr')
        if m.get('gmtModifiedStr') is not None:
            self.gmt_modified_str = m.get('gmtModifiedStr')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class QueryDepartmentExtendInfoResponseBody(TeaModel):
    def __init__(
        self,
        content: List[QueryDepartmentExtendInfoResponseBodyContent] = None,
    ):
        # 扩展属性列表
        self.content = content

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = QueryDepartmentExtendInfoResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        return self


class QueryDepartmentExtendInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryDepartmentExtendInfoResponseBody = None,
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
            temp_model = QueryDepartmentExtendInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryDepartmentInfoHeaders(TeaModel):
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


class QueryDepartmentInfoResponseBodyContentDepartment(TeaModel):
    def __init__(
        self,
        dept_code: str = None,
        dept_name: str = None,
        dept_order: int = None,
        dept_status: int = None,
        dept_type: int = None,
        gmt_create_str: str = None,
        gmt_modified_str: str = None,
        id: int = None,
        name: str = None,
        parent_dept_code: str = None,
        remark: str = None,
        ward_id_list: List[int] = None,
    ):
        # 科室code
        self.dept_code = dept_code
        # 科室名称
        self.dept_name = dept_name
        # 顺序
        self.dept_order = dept_order
        # 状态
        self.dept_status = dept_status
        # 类型
        self.dept_type = dept_type
        # 创建时间
        self.gmt_create_str = gmt_create_str
        # 修改时间
        self.gmt_modified_str = gmt_modified_str
        # 科室id
        self.id = id
        # 科室名称
        self.name = name
        # 父code
        self.parent_dept_code = parent_dept_code
        # 备注
        self.remark = remark
        # 病区id
        self.ward_id_list = ward_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_code is not None:
            result['deptCode'] = self.dept_code
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.dept_order is not None:
            result['deptOrder'] = self.dept_order
        if self.dept_status is not None:
            result['deptStatus'] = self.dept_status
        if self.dept_type is not None:
            result['deptType'] = self.dept_type
        if self.gmt_create_str is not None:
            result['gmtCreateStr'] = self.gmt_create_str
        if self.gmt_modified_str is not None:
            result['gmtModifiedStr'] = self.gmt_modified_str
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.parent_dept_code is not None:
            result['parentDeptCode'] = self.parent_dept_code
        if self.remark is not None:
            result['remark'] = self.remark
        if self.ward_id_list is not None:
            result['wardIdList'] = self.ward_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptCode') is not None:
            self.dept_code = m.get('deptCode')
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('deptOrder') is not None:
            self.dept_order = m.get('deptOrder')
        if m.get('deptStatus') is not None:
            self.dept_status = m.get('deptStatus')
        if m.get('deptType') is not None:
            self.dept_type = m.get('deptType')
        if m.get('gmtCreateStr') is not None:
            self.gmt_create_str = m.get('gmtCreateStr')
        if m.get('gmtModifiedStr') is not None:
            self.gmt_modified_str = m.get('gmtModifiedStr')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('parentDeptCode') is not None:
            self.parent_dept_code = m.get('parentDeptCode')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('wardIdList') is not None:
            self.ward_id_list = m.get('wardIdList')
        return self


class QueryDepartmentInfoResponseBodyContentExtendInfos(TeaModel):
    def __init__(
        self,
        dept_code: str = None,
        dept_extend_display_name: str = None,
        dept_extend_key: str = None,
        dept_extend_value: str = None,
        gmt_create_str: str = None,
        gmt_modified_str: str = None,
        id: int = None,
        status: int = None,
    ):
        # 部门code
        self.dept_code = dept_code
        # 扩展属性描述
        self.dept_extend_display_name = dept_extend_display_name
        # 扩展属性key
        self.dept_extend_key = dept_extend_key
        # 扩展属性value
        self.dept_extend_value = dept_extend_value
        # 创建时间
        self.gmt_create_str = gmt_create_str
        # 修改时间
        self.gmt_modified_str = gmt_modified_str
        # id
        self.id = id
        # 状态
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_code is not None:
            result['deptCode'] = self.dept_code
        if self.dept_extend_display_name is not None:
            result['deptExtendDisplayName'] = self.dept_extend_display_name
        if self.dept_extend_key is not None:
            result['deptExtendKey'] = self.dept_extend_key
        if self.dept_extend_value is not None:
            result['deptExtendValue'] = self.dept_extend_value
        if self.gmt_create_str is not None:
            result['gmtCreateStr'] = self.gmt_create_str
        if self.gmt_modified_str is not None:
            result['gmtModifiedStr'] = self.gmt_modified_str
        if self.id is not None:
            result['id'] = self.id
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptCode') is not None:
            self.dept_code = m.get('deptCode')
        if m.get('deptExtendDisplayName') is not None:
            self.dept_extend_display_name = m.get('deptExtendDisplayName')
        if m.get('deptExtendKey') is not None:
            self.dept_extend_key = m.get('deptExtendKey')
        if m.get('deptExtendValue') is not None:
            self.dept_extend_value = m.get('deptExtendValue')
        if m.get('gmtCreateStr') is not None:
            self.gmt_create_str = m.get('gmtCreateStr')
        if m.get('gmtModifiedStr') is not None:
            self.gmt_modified_str = m.get('gmtModifiedStr')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class QueryDepartmentInfoResponseBodyContent(TeaModel):
    def __init__(
        self,
        department: QueryDepartmentInfoResponseBodyContentDepartment = None,
        extend_infos: List[QueryDepartmentInfoResponseBodyContentExtendInfos] = None,
    ):
        # 科室列表
        self.department = department
        # 科室扩展属性值
        self.extend_infos = extend_infos

    def validate(self):
        if self.department:
            self.department.validate()
        if self.extend_infos:
            for k in self.extend_infos:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.department is not None:
            result['department'] = self.department.to_map()
        result['extendInfos'] = []
        if self.extend_infos is not None:
            for k in self.extend_infos:
                result['extendInfos'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('department') is not None:
            temp_model = QueryDepartmentInfoResponseBodyContentDepartment()
            self.department = temp_model.from_map(m['department'])
        self.extend_infos = []
        if m.get('extendInfos') is not None:
            for k in m.get('extendInfos'):
                temp_model = QueryDepartmentInfoResponseBodyContentExtendInfos()
                self.extend_infos.append(temp_model.from_map(k))
        return self


class QueryDepartmentInfoResponseBody(TeaModel):
    def __init__(
        self,
        content: QueryDepartmentInfoResponseBodyContent = None,
    ):
        # 科室详情
        self.content = content

    def validate(self):
        if self.content:
            self.content.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            temp_model = QueryDepartmentInfoResponseBodyContent()
            self.content = temp_model.from_map(m['content'])
        return self


class QueryDepartmentInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryDepartmentInfoResponseBody = None,
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
            temp_model = QueryDepartmentInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryGroupInfoHeaders(TeaModel):
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


class QueryGroupInfoResponseBodyContentExtendInfos(TeaModel):
    def __init__(
        self,
        dept_code: str = None,
        dept_extend_display_name: str = None,
        dept_extend_key: str = None,
        dept_extend_value: str = None,
        gmt_create_str: str = None,
        gmt_modified_str: str = None,
        id: int = None,
        status: int = None,
    ):
        # 医疗组code
        self.dept_code = dept_code
        # 扩展属性显示名称
        self.dept_extend_display_name = dept_extend_display_name
        # 扩展属性key
        self.dept_extend_key = dept_extend_key
        # 扩展属性value
        self.dept_extend_value = dept_extend_value
        # 创建时间
        self.gmt_create_str = gmt_create_str
        # 修改时间
        self.gmt_modified_str = gmt_modified_str
        # id
        self.id = id
        # 状态
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_code is not None:
            result['deptCode'] = self.dept_code
        if self.dept_extend_display_name is not None:
            result['deptExtendDisplayName'] = self.dept_extend_display_name
        if self.dept_extend_key is not None:
            result['deptExtendKey'] = self.dept_extend_key
        if self.dept_extend_value is not None:
            result['deptExtendValue'] = self.dept_extend_value
        if self.gmt_create_str is not None:
            result['gmtCreateStr'] = self.gmt_create_str
        if self.gmt_modified_str is not None:
            result['gmtModifiedStr'] = self.gmt_modified_str
        if self.id is not None:
            result['id'] = self.id
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptCode') is not None:
            self.dept_code = m.get('deptCode')
        if m.get('deptExtendDisplayName') is not None:
            self.dept_extend_display_name = m.get('deptExtendDisplayName')
        if m.get('deptExtendKey') is not None:
            self.dept_extend_key = m.get('deptExtendKey')
        if m.get('deptExtendValue') is not None:
            self.dept_extend_value = m.get('deptExtendValue')
        if m.get('gmtCreateStr') is not None:
            self.gmt_create_str = m.get('gmtCreateStr')
        if m.get('gmtModifiedStr') is not None:
            self.gmt_modified_str = m.get('gmtModifiedStr')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class QueryGroupInfoResponseBodyContentGroupLeader(TeaModel):
    def __init__(
        self,
        job_number: str = None,
        name: str = None,
        user_id: str = None,
    ):
        # 工号
        self.job_number = job_number
        # 组长名称
        self.name = name
        # 用户id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.job_number is not None:
            result['jobNumber'] = self.job_number
        if self.name is not None:
            result['name'] = self.name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('jobNumber') is not None:
            self.job_number = m.get('jobNumber')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryGroupInfoResponseBodyContentGroup(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        dept_status: int = None,
        gmt_create_str: str = None,
        gmt_modified_str: str = None,
        id: int = None,
        leader: QueryGroupInfoResponseBodyContentGroupLeader = None,
        name: str = None,
        parent_dept_code: str = None,
        remark: str = None,
    ):
        # 医疗组id
        self.dept_id = dept_id
        # 医疗组状态
        self.dept_status = dept_status
        # 创建时间
        self.gmt_create_str = gmt_create_str
        # 修改时间
        self.gmt_modified_str = gmt_modified_str
        # id
        self.id = id
        # 组长
        self.leader = leader
        # 医疗组名称
        self.name = name
        # 父code
        self.parent_dept_code = parent_dept_code
        # 备注
        self.remark = remark

    def validate(self):
        if self.leader:
            self.leader.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.dept_status is not None:
            result['deptStatus'] = self.dept_status
        if self.gmt_create_str is not None:
            result['gmtCreateStr'] = self.gmt_create_str
        if self.gmt_modified_str is not None:
            result['gmtModifiedStr'] = self.gmt_modified_str
        if self.id is not None:
            result['id'] = self.id
        if self.leader is not None:
            result['leader'] = self.leader.to_map()
        if self.name is not None:
            result['name'] = self.name
        if self.parent_dept_code is not None:
            result['parentDeptCode'] = self.parent_dept_code
        if self.remark is not None:
            result['remark'] = self.remark
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('deptStatus') is not None:
            self.dept_status = m.get('deptStatus')
        if m.get('gmtCreateStr') is not None:
            self.gmt_create_str = m.get('gmtCreateStr')
        if m.get('gmtModifiedStr') is not None:
            self.gmt_modified_str = m.get('gmtModifiedStr')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('leader') is not None:
            temp_model = QueryGroupInfoResponseBodyContentGroupLeader()
            self.leader = temp_model.from_map(m['leader'])
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('parentDeptCode') is not None:
            self.parent_dept_code = m.get('parentDeptCode')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        return self


class QueryGroupInfoResponseBodyContent(TeaModel):
    def __init__(
        self,
        extend_infos: List[QueryGroupInfoResponseBodyContentExtendInfos] = None,
        group: QueryGroupInfoResponseBodyContentGroup = None,
    ):
        # 扩展信息
        self.extend_infos = extend_infos
        # 医疗组
        self.group = group

    def validate(self):
        if self.extend_infos:
            for k in self.extend_infos:
                if k:
                    k.validate()
        if self.group:
            self.group.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['extendInfos'] = []
        if self.extend_infos is not None:
            for k in self.extend_infos:
                result['extendInfos'].append(k.to_map() if k else None)
        if self.group is not None:
            result['group'] = self.group.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.extend_infos = []
        if m.get('extendInfos') is not None:
            for k in m.get('extendInfos'):
                temp_model = QueryGroupInfoResponseBodyContentExtendInfos()
                self.extend_infos.append(temp_model.from_map(k))
        if m.get('group') is not None:
            temp_model = QueryGroupInfoResponseBodyContentGroup()
            self.group = temp_model.from_map(m['group'])
        return self


class QueryGroupInfoResponseBody(TeaModel):
    def __init__(
        self,
        content: QueryGroupInfoResponseBodyContent = None,
    ):
        # 医疗组详情
        self.content = content

    def validate(self):
        if self.content:
            self.content.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            temp_model = QueryGroupInfoResponseBodyContent()
            self.content = temp_model.from_map(m['content'])
        return self


class QueryGroupInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryGroupInfoResponseBody = None,
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
            temp_model = QueryGroupInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryHospitalDistrictInfoHeaders(TeaModel):
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


class QueryHospitalDistrictInfoRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
    ):
        # 分页查询页码
        self.page_number = page_number
        # 分页查询分页大小
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class QueryHospitalDistrictInfoResponseBodyContent(TeaModel):
    def __init__(
        self,
        address: str = None,
        deleted: int = None,
        district_name: str = None,
        district_type: int = None,
        gmt_create: str = None,
        gmt_modified: str = None,
        id: int = None,
        parent_district_id: int = None,
    ):
        # 病区对应的物理地址
        self.address = address
        # 删除，0:正常，其他：已删除
        self.deleted = deleted
        # 院区或病区名称
        self.district_name = district_name
        # 类型，1：院区；2：病区
        self.district_type = district_type
        # 创建时间
        self.gmt_create = gmt_create
        # 修改时间
        self.gmt_modified = gmt_modified
        # 主键
        self.id = id
        # 院区id
        self.parent_district_id = parent_district_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.address is not None:
            result['address'] = self.address
        if self.deleted is not None:
            result['deleted'] = self.deleted
        if self.district_name is not None:
            result['districtName'] = self.district_name
        if self.district_type is not None:
            result['districtType'] = self.district_type
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.id is not None:
            result['id'] = self.id
        if self.parent_district_id is not None:
            result['parentDistrictId'] = self.parent_district_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('address') is not None:
            self.address = m.get('address')
        if m.get('deleted') is not None:
            self.deleted = m.get('deleted')
        if m.get('districtName') is not None:
            self.district_name = m.get('districtName')
        if m.get('districtType') is not None:
            self.district_type = m.get('districtType')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('parentDistrictId') is not None:
            self.parent_district_id = m.get('parentDistrictId')
        return self


class QueryHospitalDistrictInfoResponseBody(TeaModel):
    def __init__(
        self,
        content: List[QueryHospitalDistrictInfoResponseBodyContent] = None,
        current_page: int = None,
        total_count: int = None,
        total_pages: int = None,
    ):
        # 院区病区详情
        self.content = content
        # 当前页码
        self.current_page = current_page
        # 数据总量
        self.total_count = total_count
        # 总页数
        self.total_pages = total_pages

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        if self.current_page is not None:
            result['currentPage'] = self.current_page
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        if self.total_pages is not None:
            result['totalPages'] = self.total_pages
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = QueryHospitalDistrictInfoResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        if m.get('currentPage') is not None:
            self.current_page = m.get('currentPage')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        if m.get('totalPages') is not None:
            self.total_pages = m.get('totalPages')
        return self


class QueryHospitalDistrictInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryHospitalDistrictInfoResponseBody = None,
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
            temp_model = QueryHospitalDistrictInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryHospitalRoleUserInfoHeaders(TeaModel):
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


class QueryHospitalRoleUserInfoRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
    ):
        # 分页查询页码
        self.page_number = page_number
        # 分页查询分页大小
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class QueryHospitalRoleUserInfoResponseBodyContent(TeaModel):
    def __init__(
        self,
        gmt_create: str = None,
        gmt_modified: str = None,
        job_number: str = None,
        role_code: str = None,
        role_name: str = None,
        status: int = None,
        user_code: str = None,
        user_name: str = None,
    ):
        # gmtCreate
        self.gmt_create = gmt_create
        # 修改时间
        self.gmt_modified = gmt_modified
        # 用户工号
        self.job_number = job_number
        # 角色编码
        self.role_code = role_code
        # 角色名称
        self.role_name = role_name
        self.status = status
        # 用户编码
        self.user_code = user_code
        # 用户名称
        self.user_name = user_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.job_number is not None:
            result['jobNumber'] = self.job_number
        if self.role_code is not None:
            result['roleCode'] = self.role_code
        if self.role_name is not None:
            result['roleName'] = self.role_name
        if self.status is not None:
            result['status'] = self.status
        if self.user_code is not None:
            result['userCode'] = self.user_code
        if self.user_name is not None:
            result['userName'] = self.user_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('jobNumber') is not None:
            self.job_number = m.get('jobNumber')
        if m.get('roleCode') is not None:
            self.role_code = m.get('roleCode')
        if m.get('roleName') is not None:
            self.role_name = m.get('roleName')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('userCode') is not None:
            self.user_code = m.get('userCode')
        if m.get('userName') is not None:
            self.user_name = m.get('userName')
        return self


class QueryHospitalRoleUserInfoResponseBody(TeaModel):
    def __init__(
        self,
        content: List[QueryHospitalRoleUserInfoResponseBodyContent] = None,
        current_page: int = None,
        total_count: int = None,
        total_pages: int = None,
    ):
        # 角色人员信息
        self.content = content
        # 当前页码
        self.current_page = current_page
        # 总数量
        self.total_count = total_count
        # 总页数
        self.total_pages = total_pages

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        if self.current_page is not None:
            result['currentPage'] = self.current_page
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        if self.total_pages is not None:
            result['totalPages'] = self.total_pages
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = QueryHospitalRoleUserInfoResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        if m.get('currentPage') is not None:
            self.current_page = m.get('currentPage')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        if m.get('totalPages') is not None:
            self.total_pages = m.get('totalPages')
        return self


class QueryHospitalRoleUserInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryHospitalRoleUserInfoResponseBody = None,
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
            temp_model = QueryHospitalRoleUserInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryHospitalRolesHeaders(TeaModel):
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


class QueryHospitalRolesResponseBodyContent(TeaModel):
    def __init__(
        self,
        gmt_create: str = None,
        id: int = None,
        is_deleted: int = None,
        read_only: int = None,
        remark: str = None,
        role_code: str = None,
        role_name: str = None,
        sort: int = None,
    ):
        # 修改时间
        self.gmt_create = gmt_create
        # 主键
        self.id = id
        # 是否已删除，默认0未删除，1已删除
        self.is_deleted = is_deleted
        # 角色关联权限点是否只读
        self.read_only = read_only
        # 备注
        self.remark = remark
        # 角色编码
        self.role_code = role_code
        # 角色名称
        self.role_name = role_name
        # 排序，数字越小越靠前，默认0
        self.sort = sort

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.id is not None:
            result['id'] = self.id
        if self.is_deleted is not None:
            result['isDeleted'] = self.is_deleted
        if self.read_only is not None:
            result['readOnly'] = self.read_only
        if self.remark is not None:
            result['remark'] = self.remark
        if self.role_code is not None:
            result['roleCode'] = self.role_code
        if self.role_name is not None:
            result['roleName'] = self.role_name
        if self.sort is not None:
            result['sort'] = self.sort
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isDeleted') is not None:
            self.is_deleted = m.get('isDeleted')
        if m.get('readOnly') is not None:
            self.read_only = m.get('readOnly')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('roleCode') is not None:
            self.role_code = m.get('roleCode')
        if m.get('roleName') is not None:
            self.role_name = m.get('roleName')
        if m.get('sort') is not None:
            self.sort = m.get('sort')
        return self


class QueryHospitalRolesResponseBody(TeaModel):
    def __init__(
        self,
        content: List[QueryHospitalRolesResponseBodyContent] = None,
    ):
        # 角色列表
        self.content = content

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = QueryHospitalRolesResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        return self


class QueryHospitalRolesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryHospitalRolesResponseBody = None,
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
            temp_model = QueryHospitalRolesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryJobCodeDictionaryHeaders(TeaModel):
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


class QueryJobCodeDictionaryResponseBodyContent(TeaModel):
    def __init__(
        self,
        category: str = None,
        code: str = None,
        display_name: str = None,
        doctor_type: str = None,
    ):
        # 分类
        self.category = category
        # 固定字段标识
        self.code = code
        # 展示名字
        self.display_name = display_name
        # 1:医师,0:非医师,2:待补充
        self.doctor_type = doctor_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.category is not None:
            result['category'] = self.category
        if self.code is not None:
            result['code'] = self.code
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.doctor_type is not None:
            result['doctorType'] = self.doctor_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('category') is not None:
            self.category = m.get('category')
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('doctorType') is not None:
            self.doctor_type = m.get('doctorType')
        return self


class QueryJobCodeDictionaryResponseBody(TeaModel):
    def __init__(
        self,
        content: List[QueryJobCodeDictionaryResponseBodyContent] = None,
    ):
        # code列表
        self.content = content

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = QueryJobCodeDictionaryResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        return self


class QueryJobCodeDictionaryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryJobCodeDictionaryResponseBody = None,
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
            temp_model = QueryJobCodeDictionaryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryJobStatusCodeDictionaryHeaders(TeaModel):
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


class QueryJobStatusCodeDictionaryResponseBodyContent(TeaModel):
    def __init__(
        self,
        category: str = None,
        code: str = None,
        display_name: str = None,
    ):
        # 分类
        self.category = category
        # 固定字段标识
        self.code = code
        # 展示名字
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.category is not None:
            result['category'] = self.category
        if self.code is not None:
            result['code'] = self.code
        if self.display_name is not None:
            result['displayName'] = self.display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('category') is not None:
            self.category = m.get('category')
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        return self


class QueryJobStatusCodeDictionaryResponseBody(TeaModel):
    def __init__(
        self,
        content: List[QueryJobStatusCodeDictionaryResponseBodyContent] = None,
    ):
        # code列表
        self.content = content

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = QueryJobStatusCodeDictionaryResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        return self


class QueryJobStatusCodeDictionaryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryJobStatusCodeDictionaryResponseBody = None,
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
            temp_model = QueryJobStatusCodeDictionaryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryMedicalEventsHeaders(TeaModel):
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


class QueryMedicalEventsResponseBodyContent(TeaModel):
    def __init__(
        self,
        code: str = None,
        content: str = None,
        event_id: int = None,
    ):
        # 事件code
        self.code = code
        # 事件内容
        self.content = content
        # 事件id
        self.event_id = event_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.content is not None:
            result['content'] = self.content
        if self.event_id is not None:
            result['eventId'] = self.event_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('eventId') is not None:
            self.event_id = m.get('eventId')
        return self


class QueryMedicalEventsResponseBody(TeaModel):
    def __init__(
        self,
        content: List[QueryMedicalEventsResponseBodyContent] = None,
        success: bool = None,
        total_count: int = None,
    ):
        # 事件详情列表
        self.content = content
        # 是否成功
        self.success = success
        # 数据总量
        self.total_count = total_count

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        if self.success is not None:
            result['success'] = self.success
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = QueryMedicalEventsResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        if m.get('success') is not None:
            self.success = m.get('success')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class QueryMedicalEventsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryMedicalEventsResponseBody = None,
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
            temp_model = QueryMedicalEventsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryUserCredentialsHeaders(TeaModel):
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


class QueryUserCredentialsRequest(TeaModel):
    def __init__(
        self,
        user_ids: List[str] = None,
    ):
        # userId列表
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class QueryUserCredentialsResponseBodyContentCredentialList(TeaModel):
    def __init__(
        self,
        credential_name: str = None,
        credential_type: int = None,
        term_of_validity: str = None,
    ):
        # 证书名称
        self.credential_name = credential_name
        # 证书类型
        self.credential_type = credential_type
        # 有效日期
        self.term_of_validity = term_of_validity

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.credential_name is not None:
            result['credentialName'] = self.credential_name
        if self.credential_type is not None:
            result['credentialType'] = self.credential_type
        if self.term_of_validity is not None:
            result['termOfValidity'] = self.term_of_validity
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('credentialName') is not None:
            self.credential_name = m.get('credentialName')
        if m.get('credentialType') is not None:
            self.credential_type = m.get('credentialType')
        if m.get('termOfValidity') is not None:
            self.term_of_validity = m.get('termOfValidity')
        return self


class QueryUserCredentialsResponseBodyContent(TeaModel):
    def __init__(
        self,
        credential_list: List[QueryUserCredentialsResponseBodyContentCredentialList] = None,
        user_id: str = None,
    ):
        # 证书列表
        self.credential_list = credential_list
        # 用户id
        self.user_id = user_id

    def validate(self):
        if self.credential_list:
            for k in self.credential_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['credentialList'] = []
        if self.credential_list is not None:
            for k in self.credential_list:
                result['credentialList'].append(k.to_map() if k else None)
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.credential_list = []
        if m.get('credentialList') is not None:
            for k in m.get('credentialList'):
                temp_model = QueryUserCredentialsResponseBodyContentCredentialList()
                self.credential_list.append(temp_model.from_map(k))
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryUserCredentialsResponseBody(TeaModel):
    def __init__(
        self,
        content: List[QueryUserCredentialsResponseBodyContent] = None,
    ):
        # 人员证书
        self.content = content

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = QueryUserCredentialsResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        return self


class QueryUserCredentialsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryUserCredentialsResponseBody = None,
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
            temp_model = QueryUserCredentialsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryUserExtInfoHeaders(TeaModel):
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


class QueryUserExtInfoResponseBodyContent(TeaModel):
    def __init__(
        self,
        gmt_create: str = None,
        gmt_modified: str = None,
        status: int = None,
        user_code: str = None,
        user_extend_display_name: str = None,
        user_extend_key: str = None,
        user_extend_value: str = None,
    ):
        # 创建时间
        self.gmt_create = gmt_create
        # 修改时间
        self.gmt_modified = gmt_modified
        # 状态：0-有效，1-无效
        self.status = status
        # 用户标识
        self.user_code = user_code
        # 扩展属性描述
        self.user_extend_display_name = user_extend_display_name
        # 扩展属性Key
        self.user_extend_key = user_extend_key
        # 扩展属性值
        self.user_extend_value = user_extend_value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.status is not None:
            result['status'] = self.status
        if self.user_code is not None:
            result['userCode'] = self.user_code
        if self.user_extend_display_name is not None:
            result['userExtendDisplayName'] = self.user_extend_display_name
        if self.user_extend_key is not None:
            result['userExtendKey'] = self.user_extend_key
        if self.user_extend_value is not None:
            result['userExtendValue'] = self.user_extend_value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('userCode') is not None:
            self.user_code = m.get('userCode')
        if m.get('userExtendDisplayName') is not None:
            self.user_extend_display_name = m.get('userExtendDisplayName')
        if m.get('userExtendKey') is not None:
            self.user_extend_key = m.get('userExtendKey')
        if m.get('userExtendValue') is not None:
            self.user_extend_value = m.get('userExtendValue')
        return self


class QueryUserExtInfoResponseBody(TeaModel):
    def __init__(
        self,
        content: List[QueryUserExtInfoResponseBodyContent] = None,
    ):
        # 扩展属性
        self.content = content

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = QueryUserExtInfoResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        return self


class QueryUserExtInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryUserExtInfoResponseBody = None,
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
            temp_model = QueryUserExtInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryUserExtendValuesHeaders(TeaModel):
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


class QueryUserExtendValuesRequest(TeaModel):
    def __init__(
        self,
        user_extend_key: str = None,
        user_ids: List[str] = None,
    ):
        # 用户拓展key
        self.user_extend_key = user_extend_key
        # userId列表
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_extend_key is not None:
            result['userExtendKey'] = self.user_extend_key
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userExtendKey') is not None:
            self.user_extend_key = m.get('userExtendKey')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class QueryUserExtendValuesResponseBodyContent(TeaModel):
    def __init__(
        self,
        user_code: str = None,
        user_extend_display_name: str = None,
        user_extend_key: str = None,
        user_extend_value: str = None,
    ):
        # 用户code
        self.user_code = user_code
        # 扩展字段描述
        self.user_extend_display_name = user_extend_display_name
        # 扩展字段key
        self.user_extend_key = user_extend_key
        # 扩展字段value
        self.user_extend_value = user_extend_value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_code is not None:
            result['userCode'] = self.user_code
        if self.user_extend_display_name is not None:
            result['userExtendDisplayName'] = self.user_extend_display_name
        if self.user_extend_key is not None:
            result['userExtendKey'] = self.user_extend_key
        if self.user_extend_value is not None:
            result['userExtendValue'] = self.user_extend_value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userCode') is not None:
            self.user_code = m.get('userCode')
        if m.get('userExtendDisplayName') is not None:
            self.user_extend_display_name = m.get('userExtendDisplayName')
        if m.get('userExtendKey') is not None:
            self.user_extend_key = m.get('userExtendKey')
        if m.get('userExtendValue') is not None:
            self.user_extend_value = m.get('userExtendValue')
        return self


class QueryUserExtendValuesResponseBody(TeaModel):
    def __init__(
        self,
        content: List[QueryUserExtendValuesResponseBodyContent] = None,
        success: bool = None,
        total_count: int = None,
    ):
        # 人员列表
        self.content = content
        # 是否成功
        self.success = success
        # 数据总量
        self.total_count = total_count

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        if self.success is not None:
            result['success'] = self.success
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = QueryUserExtendValuesResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        if m.get('success') is not None:
            self.success = m.get('success')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class QueryUserExtendValuesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryUserExtendValuesResponseBody = None,
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
            temp_model = QueryUserExtendValuesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryUserInfoHeaders(TeaModel):
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


class QueryUserInfoResponseBodyContentDept(TeaModel):
    def __init__(
        self,
        id: int = None,
        name: str = None,
    ):
        # 科室Id
        self.id = id
        # 科室名称
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


class QueryUserInfoResponseBodyContentGroup(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        dept_name: str = None,
        id: int = None,
        name: str = None,
    ):
        # 医疗组所在科室Id
        self.dept_id = dept_id
        # 医疗组所在科室名称
        self.dept_name = dept_name
        # 医疗组Id
        self.id = id
        # 医疗组名称
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
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class QueryUserInfoResponseBodyContentJob(TeaModel):
    def __init__(
        self,
        biz_type: str = None,
        category: str = None,
        code: str = None,
        display_name: str = None,
    ):
        # 标签类型
        self.biz_type = biz_type
        # 分类
        self.category = category
        # 标签Code
        self.code = code
        # 展示名称
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.category is not None:
            result['category'] = self.category
        if self.code is not None:
            result['code'] = self.code
        if self.display_name is not None:
            result['displayName'] = self.display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('category') is not None:
            self.category = m.get('category')
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        return self


class QueryUserInfoResponseBodyContentJobStatus(TeaModel):
    def __init__(
        self,
        biz_type: str = None,
        category: str = None,
        code: str = None,
        display_name: str = None,
    ):
        # 标签类型
        self.biz_type = biz_type
        # 分类
        self.category = category
        # 标签Code
        self.code = code
        # 展示名称
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.category is not None:
            result['category'] = self.category
        if self.code is not None:
            result['code'] = self.code
        if self.display_name is not None:
            result['displayName'] = self.display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('category') is not None:
            self.category = m.get('category')
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        return self


class QueryUserInfoResponseBodyContentJobStatusList(TeaModel):
    def __init__(
        self,
        biz_type: str = None,
        category: str = None,
        code: str = None,
        display_name: str = None,
    ):
        # 标签类型
        self.biz_type = biz_type
        # 分类
        self.category = category
        # 标签Code
        self.code = code
        # 展示名称
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.category is not None:
            result['category'] = self.category
        if self.code is not None:
            result['code'] = self.code
        if self.display_name is not None:
            result['displayName'] = self.display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('category') is not None:
            self.category = m.get('category')
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        return self


class QueryUserInfoResponseBodyContentUserProb(TeaModel):
    def __init__(
        self,
        biz_type: str = None,
        category: str = None,
        code: str = None,
        display_name: str = None,
    ):
        # 标签类型
        self.biz_type = biz_type
        # 分类
        self.category = category
        # 标签Code
        self.code = code
        # 展示名称
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.category is not None:
            result['category'] = self.category
        if self.code is not None:
            result['code'] = self.code
        if self.display_name is not None:
            result['displayName'] = self.display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('category') is not None:
            self.category = m.get('category')
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        return self


class QueryUserInfoResponseBodyContent(TeaModel):
    def __init__(
        self,
        comments: str = None,
        dept: List[QueryUserInfoResponseBodyContentDept] = None,
        group: List[QueryUserInfoResponseBodyContentGroup] = None,
        job: QueryUserInfoResponseBodyContentJob = None,
        job_num: str = None,
        job_status: QueryUserInfoResponseBodyContentJobStatus = None,
        job_status_list: List[QueryUserInfoResponseBodyContentJobStatusList] = None,
        uid: str = None,
        user_name: str = None,
        user_prob: QueryUserInfoResponseBodyContentUserProb = None,
    ):
        # comments
        self.comments = comments
        # 所在科室
        self.dept = dept
        # 所在医疗组
        self.group = group
        # 职称标签
        self.job = job
        # 工号
        self.job_num = job_num
        # 工作状态标签, 已废弃, 请使用jobStatusList字段
        self.job_status = job_status
        # 工作状态标签
        self.job_status_list = job_status_list
        # 用户Id
        self.uid = uid
        # 用户名称
        self.user_name = user_name
        # 人员属性标签
        self.user_prob = user_prob

    def validate(self):
        if self.dept:
            for k in self.dept:
                if k:
                    k.validate()
        if self.group:
            for k in self.group:
                if k:
                    k.validate()
        if self.job:
            self.job.validate()
        if self.job_status:
            self.job_status.validate()
        if self.job_status_list:
            for k in self.job_status_list:
                if k:
                    k.validate()
        if self.user_prob:
            self.user_prob.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.comments is not None:
            result['comments'] = self.comments
        result['dept'] = []
        if self.dept is not None:
            for k in self.dept:
                result['dept'].append(k.to_map() if k else None)
        result['group'] = []
        if self.group is not None:
            for k in self.group:
                result['group'].append(k.to_map() if k else None)
        if self.job is not None:
            result['job'] = self.job.to_map()
        if self.job_num is not None:
            result['jobNum'] = self.job_num
        if self.job_status is not None:
            result['jobStatus'] = self.job_status.to_map()
        result['jobStatusList'] = []
        if self.job_status_list is not None:
            for k in self.job_status_list:
                result['jobStatusList'].append(k.to_map() if k else None)
        if self.uid is not None:
            result['uid'] = self.uid
        if self.user_name is not None:
            result['userName'] = self.user_name
        if self.user_prob is not None:
            result['userProb'] = self.user_prob.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('comments') is not None:
            self.comments = m.get('comments')
        self.dept = []
        if m.get('dept') is not None:
            for k in m.get('dept'):
                temp_model = QueryUserInfoResponseBodyContentDept()
                self.dept.append(temp_model.from_map(k))
        self.group = []
        if m.get('group') is not None:
            for k in m.get('group'):
                temp_model = QueryUserInfoResponseBodyContentGroup()
                self.group.append(temp_model.from_map(k))
        if m.get('job') is not None:
            temp_model = QueryUserInfoResponseBodyContentJob()
            self.job = temp_model.from_map(m['job'])
        if m.get('jobNum') is not None:
            self.job_num = m.get('jobNum')
        if m.get('jobStatus') is not None:
            temp_model = QueryUserInfoResponseBodyContentJobStatus()
            self.job_status = temp_model.from_map(m['jobStatus'])
        self.job_status_list = []
        if m.get('jobStatusList') is not None:
            for k in m.get('jobStatusList'):
                temp_model = QueryUserInfoResponseBodyContentJobStatusList()
                self.job_status_list.append(temp_model.from_map(k))
        if m.get('uid') is not None:
            self.uid = m.get('uid')
        if m.get('userName') is not None:
            self.user_name = m.get('userName')
        if m.get('userProb') is not None:
            temp_model = QueryUserInfoResponseBodyContentUserProb()
            self.user_prob = temp_model.from_map(m['userProb'])
        return self


class QueryUserInfoResponseBody(TeaModel):
    def __init__(
        self,
        content: QueryUserInfoResponseBodyContent = None,
    ):
        # 人员详情
        self.content = content

    def validate(self):
        if self.content:
            self.content.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            temp_model = QueryUserInfoResponseBodyContent()
            self.content = temp_model.from_map(m['content'])
        return self


class QueryUserInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryUserInfoResponseBody = None,
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
            temp_model = QueryUserInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryUserProbCodeDictionaryHeaders(TeaModel):
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


class QueryUserProbCodeDictionaryResponseBodyContent(TeaModel):
    def __init__(
        self,
        category: str = None,
        code: str = None,
        display_name: str = None,
    ):
        # 分类
        self.category = category
        # 固定字段标识
        self.code = code
        # 展示名字
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.category is not None:
            result['category'] = self.category
        if self.code is not None:
            result['code'] = self.code
        if self.display_name is not None:
            result['displayName'] = self.display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('category') is not None:
            self.category = m.get('category')
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        return self


class QueryUserProbCodeDictionaryResponseBody(TeaModel):
    def __init__(
        self,
        content: List[QueryUserProbCodeDictionaryResponseBodyContent] = None,
    ):
        # code列表
        self.content = content

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = QueryUserProbCodeDictionaryResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        return self


class QueryUserProbCodeDictionaryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryUserProbCodeDictionaryResponseBody = None,
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
            temp_model = QueryUserProbCodeDictionaryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryUserRolesHeaders(TeaModel):
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


class QueryUserRolesResponseBodyContent(TeaModel):
    def __init__(
        self,
        role_code: str = None,
        role_name: str = None,
    ):
        # 角色编码
        self.role_code = role_code
        # 角色名称
        self.role_name = role_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.role_code is not None:
            result['roleCode'] = self.role_code
        if self.role_name is not None:
            result['roleName'] = self.role_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('roleCode') is not None:
            self.role_code = m.get('roleCode')
        if m.get('roleName') is not None:
            self.role_name = m.get('roleName')
        return self


class QueryUserRolesResponseBody(TeaModel):
    def __init__(
        self,
        content: List[QueryUserRolesResponseBodyContent] = None,
    ):
        # 扩展属性
        self.content = content

    def validate(self):
        if self.content:
            for k in self.content:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['content'] = []
        if self.content is not None:
            for k in self.content:
                result['content'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.content = []
        if m.get('content') is not None:
            for k in m.get('content'):
                temp_model = QueryUserRolesResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        return self


class QueryUserRolesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryUserRolesResponseBody = None,
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
            temp_model = QueryUserRolesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SaveUserExtendValuesHeaders(TeaModel):
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


class SaveUserExtendValuesRequest(TeaModel):
    def __init__(
        self,
        user_display_name: str = None,
        user_extend_key: str = None,
        user_extend_value: str = None,
    ):
        # 字段展示名称
        self.user_display_name = user_display_name
        # 用户拓展字段key
        self.user_extend_key = user_extend_key
        # 用户扩展字段value
        self.user_extend_value = user_extend_value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_display_name is not None:
            result['userDisplayName'] = self.user_display_name
        if self.user_extend_key is not None:
            result['userExtendKey'] = self.user_extend_key
        if self.user_extend_value is not None:
            result['userExtendValue'] = self.user_extend_value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userDisplayName') is not None:
            self.user_display_name = m.get('userDisplayName')
        if m.get('userExtendKey') is not None:
            self.user_extend_key = m.get('userExtendKey')
        if m.get('userExtendValue') is not None:
            self.user_extend_value = m.get('userExtendValue')
        return self


class SaveUserExtendValuesResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        # 是否成功
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


class SaveUserExtendValuesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SaveUserExtendValuesResponseBody = None,
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
            temp_model = SaveUserExtendValuesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateUserExtendInfoHeaders(TeaModel):
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


class UpdateUserExtendInfoRequest(TeaModel):
    def __init__(
        self,
        comments: str = None,
        job_code: str = None,
        job_status_code: List[str] = None,
        user_prob_code: str = None,
    ):
        # comments
        self.comments = comments
        # 职称code
        self.job_code = job_code
        # 工作状态code
        self.job_status_code = job_status_code
        # 用户属性code
        self.user_prob_code = user_prob_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.comments is not None:
            result['comments'] = self.comments
        if self.job_code is not None:
            result['jobCode'] = self.job_code
        if self.job_status_code is not None:
            result['jobStatusCode'] = self.job_status_code
        if self.user_prob_code is not None:
            result['userProbCode'] = self.user_prob_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('comments') is not None:
            self.comments = m.get('comments')
        if m.get('jobCode') is not None:
            self.job_code = m.get('jobCode')
        if m.get('jobStatusCode') is not None:
            self.job_status_code = m.get('jobStatusCode')
        if m.get('userProbCode') is not None:
            self.user_prob_code = m.get('userProbCode')
        return self


class UpdateUserExtendInfoResponse(TeaModel):
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


