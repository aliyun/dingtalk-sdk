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
        location: str = None,
        order_end_time: int = None,
        order_info: str = None,
        order_start_time: int = None,
        prov_id: int = None,
        telephone: str = None,
    ):
        # 园区所在详细地址
        self.address = address
        # 园区面积，单位：平方千米
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
        # 园区经纬度,格式：经度,纬度
        self.location = location
        self.order_end_time = order_end_time
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
        group_id: int = None,
    ):
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


class CollegeActiveCollegeDeptGroupHeaders(TeaModel):
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


class CollegeActiveCollegeDeptGroupRequest(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
    ):
        # 部门id
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


class CollegeActiveCollegeDeptGroupResponseBody(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
    ):
        # 调用时如果满足创建群条件，直接返回 openConversationId
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class CollegeActiveCollegeDeptGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CollegeActiveCollegeDeptGroupResponseBody = None,
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
            temp_model = CollegeActiveCollegeDeptGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CollegeAddCollegeDeptHeaders(TeaModel):
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


class CollegeAddCollegeDeptRequest(TeaModel):
    def __init__(
        self,
        dept_name: str = None,
        dept_type: str = None,
        sort_factor: int = None,
        super_id: int = None,
    ):
        # 部门名称
        self.dept_name = dept_name
        # 部门类型
        self.dept_type = dept_type
        # 排序因子
        self.sort_factor = sort_factor
        # 父部门id
        self.super_id = super_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.dept_type is not None:
            result['deptType'] = self.dept_type
        if self.sort_factor is not None:
            result['sortFactor'] = self.sort_factor
        if self.super_id is not None:
            result['superId'] = self.super_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('deptType') is not None:
            self.dept_type = m.get('deptType')
        if m.get('sortFactor') is not None:
            self.sort_factor = m.get('sortFactor')
        if m.get('superId') is not None:
            self.super_id = m.get('superId')
        return self


class CollegeAddCollegeDeptResponseBody(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
    ):
        # 部门id
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


class CollegeAddCollegeDeptResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CollegeAddCollegeDeptResponseBody = None,
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
            temp_model = CollegeAddCollegeDeptResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CollegeAddManagerHeaders(TeaModel):
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


class CollegeAddManagerRequest(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        user_id: str = None,
    ):
        # 部门id
        self.dept_id = dept_id
        # userId
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CollegeAddManagerResponseBody(TeaModel):
    def __init__(
        self,
        is_successful: bool = None,
    ):
        # 添加负责人是否成功
        self.is_successful = is_successful

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.is_successful is not None:
            result['isSuccessful'] = self.is_successful
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isSuccessful') is not None:
            self.is_successful = m.get('isSuccessful')
        return self


class CollegeAddManagerResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CollegeAddManagerResponseBody = None,
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
            temp_model = CollegeAddManagerResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CollegeAddStudentHeaders(TeaModel):
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


class CollegeAddStudentRequest(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        emp_extension: Dict[str, str] = None,
        gender: str = None,
        identify_id: str = None,
        mobile: str = None,
        start_year: str = None,
        student_name: str = None,
        student_number: str = None,
        user_id: str = None,
    ):
        # 部门编号
        self.dept_id = dept_id
        # 人员拓展信息
        self.emp_extension = emp_extension
        # 性别
        self.gender = gender
        # 身份证号
        self.identify_id = identify_id
        # 手机号
        self.mobile = mobile
        # 入学年月
        self.start_year = start_year
        # 学生姓名
        self.student_name = student_name
        # 学生学号
        self.student_number = student_number
        # userId
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.emp_extension is not None:
            result['empExtension'] = self.emp_extension
        if self.gender is not None:
            result['gender'] = self.gender
        if self.identify_id is not None:
            result['identifyId'] = self.identify_id
        if self.mobile is not None:
            result['mobile'] = self.mobile
        if self.start_year is not None:
            result['startYear'] = self.start_year
        if self.student_name is not None:
            result['studentName'] = self.student_name
        if self.student_number is not None:
            result['studentNumber'] = self.student_number
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('empExtension') is not None:
            self.emp_extension = m.get('empExtension')
        if m.get('gender') is not None:
            self.gender = m.get('gender')
        if m.get('identifyId') is not None:
            self.identify_id = m.get('identifyId')
        if m.get('mobile') is not None:
            self.mobile = m.get('mobile')
        if m.get('startYear') is not None:
            self.start_year = m.get('startYear')
        if m.get('studentName') is not None:
            self.student_name = m.get('studentName')
        if m.get('studentNumber') is not None:
            self.student_number = m.get('studentNumber')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CollegeAddStudentResponseBody(TeaModel):
    def __init__(
        self,
        ding_member_status: str = None,
        is_active: bool = None,
        student_id: int = None,
        union_id: str = None,
        user_id: str = None,
    ):
        # 人员状态
        self.ding_member_status = ding_member_status
        # 账号是否激活
        self.is_active = is_active
        # 学生id
        self.student_id = student_id
        # unionId
        self.union_id = union_id
        # userId
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_member_status is not None:
            result['dingMemberStatus'] = self.ding_member_status
        if self.is_active is not None:
            result['isActive'] = self.is_active
        if self.student_id is not None:
            result['studentId'] = self.student_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingMemberStatus') is not None:
            self.ding_member_status = m.get('dingMemberStatus')
        if m.get('isActive') is not None:
            self.is_active = m.get('isActive')
        if m.get('studentId') is not None:
            self.student_id = m.get('studentId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CollegeAddStudentResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CollegeAddStudentResponseBody = None,
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
            temp_model = CollegeAddStudentResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CollegeChangeStudentDeptHeaders(TeaModel):
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


class CollegeChangeStudentDeptRequest(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        new_dept_id: int = None,
        student_id: int = None,
    ):
        # 部门id
        self.dept_id = dept_id
        # 新部门id
        self.new_dept_id = new_dept_id
        # 学生id
        self.student_id = student_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.new_dept_id is not None:
            result['newDeptId'] = self.new_dept_id
        if self.student_id is not None:
            result['studentId'] = self.student_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('newDeptId') is not None:
            self.new_dept_id = m.get('newDeptId')
        if m.get('studentId') is not None:
            self.student_id = m.get('studentId')
        return self


class CollegeChangeStudentDeptResponseBody(TeaModel):
    def __init__(
        self,
        is_successful: bool = None,
    ):
        # 转移组织是否成功
        self.is_successful = is_successful

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.is_successful is not None:
            result['isSuccessful'] = self.is_successful
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isSuccessful') is not None:
            self.is_successful = m.get('isSuccessful')
        return self


class CollegeChangeStudentDeptResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CollegeChangeStudentDeptResponseBody = None,
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
            temp_model = CollegeChangeStudentDeptResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CollegeDeleteCollegeDeptHeaders(TeaModel):
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


class CollegeDeleteCollegeDeptRequest(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
    ):
        # 部门id
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


class CollegeDeleteCollegeDeptResponseBody(TeaModel):
    def __init__(
        self,
        is_successful: bool = None,
    ):
        # 是否删除成功
        self.is_successful = is_successful

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.is_successful is not None:
            result['isSuccessful'] = self.is_successful
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isSuccessful') is not None:
            self.is_successful = m.get('isSuccessful')
        return self


class CollegeDeleteCollegeDeptResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CollegeDeleteCollegeDeptResponseBody = None,
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
            temp_model = CollegeDeleteCollegeDeptResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CollegeListCollegeSubDeptHeaders(TeaModel):
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


class CollegeListCollegeSubDeptRequest(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
    ):
        # 部门id
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


class CollegeListCollegeSubDeptResponseBodyCollegeDeptInfoSimpleList(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        dept_name: str = None,
        dept_type: str = None,
    ):
        # 部门id
        self.dept_id = dept_id
        # 部门名称
        self.dept_name = dept_name
        # 部门类型
        self.dept_type = dept_type

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
        if self.dept_type is not None:
            result['deptType'] = self.dept_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('deptType') is not None:
            self.dept_type = m.get('deptType')
        return self


class CollegeListCollegeSubDeptResponseBody(TeaModel):
    def __init__(
        self,
        college_dept_info_simple_list: List[CollegeListCollegeSubDeptResponseBodyCollegeDeptInfoSimpleList] = None,
    ):
        # 部门信息列表
        self.college_dept_info_simple_list = college_dept_info_simple_list

    def validate(self):
        if self.college_dept_info_simple_list:
            for k in self.college_dept_info_simple_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['collegeDeptInfoSimpleList'] = []
        if self.college_dept_info_simple_list is not None:
            for k in self.college_dept_info_simple_list:
                result['collegeDeptInfoSimpleList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.college_dept_info_simple_list = []
        if m.get('collegeDeptInfoSimpleList') is not None:
            for k in m.get('collegeDeptInfoSimpleList'):
                temp_model = CollegeListCollegeSubDeptResponseBodyCollegeDeptInfoSimpleList()
                self.college_dept_info_simple_list.append(temp_model.from_map(k))
        return self


class CollegeListCollegeSubDeptResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CollegeListCollegeSubDeptResponseBody = None,
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
            temp_model = CollegeListCollegeSubDeptResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CollegeListDeptManagerHeaders(TeaModel):
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


class CollegeListDeptManagerRequest(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        page_number: int = None,
        page_size: int = None,
    ):
        # 部门id
        self.dept_id = dept_id
        # 页码
        self.page_number = page_number
        # 单页的条目数
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class CollegeListDeptManagerResponseBodyManagerInfoSimpleList(TeaModel):
    def __init__(
        self,
        is_active: bool = None,
        name: str = None,
        user_id: str = None,
    ):
        # 账号是否激活
        self.is_active = is_active
        # 负责人姓名
        self.name = name
        # userId
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.is_active is not None:
            result['isActive'] = self.is_active
        if self.name is not None:
            result['name'] = self.name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isActive') is not None:
            self.is_active = m.get('isActive')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CollegeListDeptManagerResponseBody(TeaModel):
    def __init__(
        self,
        manager_info_simple_list: List[CollegeListDeptManagerResponseBodyManagerInfoSimpleList] = None,
        total_count: int = None,
    ):
        # 负责人信息列表
        self.manager_info_simple_list = manager_info_simple_list
        # 数据总条目数
        self.total_count = total_count

    def validate(self):
        if self.manager_info_simple_list:
            for k in self.manager_info_simple_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['managerInfoSimpleList'] = []
        if self.manager_info_simple_list is not None:
            for k in self.manager_info_simple_list:
                result['managerInfoSimpleList'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.manager_info_simple_list = []
        if m.get('managerInfoSimpleList') is not None:
            for k in m.get('managerInfoSimpleList'):
                temp_model = CollegeListDeptManagerResponseBodyManagerInfoSimpleList()
                self.manager_info_simple_list.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class CollegeListDeptManagerResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CollegeListDeptManagerResponseBody = None,
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
            temp_model = CollegeListDeptManagerResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CollegeListStudentInfoHeaders(TeaModel):
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


class CollegeListStudentInfoRequest(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        ding_student_status: str = None,
        page_number: int = None,
        page_size: int = None,
    ):
        # 部门id
        self.dept_id = dept_id
        # 人员状态
        self.ding_student_status = ding_student_status
        # 当前页数
        self.page_number = page_number
        # 单页的条目数
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.ding_student_status is not None:
            result['dingStudentStatus'] = self.ding_student_status
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('dingStudentStatus') is not None:
            self.ding_student_status = m.get('dingStudentStatus')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class CollegeListStudentInfoResponseBodyStudentInfoSimpleList(TeaModel):
    def __init__(
        self,
        ding_member_status: str = None,
        is_active: bool = None,
        student_id: int = None,
        student_name: str = None,
        union_id: str = None,
        user_id: str = None,
    ):
        # 人员在组织的状态
        self.ding_member_status = ding_member_status
        # 账号是否激活
        self.is_active = is_active
        # 学生id
        self.student_id = student_id
        # 学生姓名
        self.student_name = student_name
        # unionId
        self.union_id = union_id
        # userId
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_member_status is not None:
            result['dingMemberStatus'] = self.ding_member_status
        if self.is_active is not None:
            result['isActive'] = self.is_active
        if self.student_id is not None:
            result['studentId'] = self.student_id
        if self.student_name is not None:
            result['studentName'] = self.student_name
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingMemberStatus') is not None:
            self.ding_member_status = m.get('dingMemberStatus')
        if m.get('isActive') is not None:
            self.is_active = m.get('isActive')
        if m.get('studentId') is not None:
            self.student_id = m.get('studentId')
        if m.get('studentName') is not None:
            self.student_name = m.get('studentName')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CollegeListStudentInfoResponseBody(TeaModel):
    def __init__(
        self,
        student_info_simple_list: List[CollegeListStudentInfoResponseBodyStudentInfoSimpleList] = None,
        total_count: int = None,
    ):
        # 学生信息列表
        self.student_info_simple_list = student_info_simple_list
        # 条目总数
        self.total_count = total_count

    def validate(self):
        if self.student_info_simple_list:
            for k in self.student_info_simple_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['studentInfoSimpleList'] = []
        if self.student_info_simple_list is not None:
            for k in self.student_info_simple_list:
                result['studentInfoSimpleList'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.student_info_simple_list = []
        if m.get('studentInfoSimpleList') is not None:
            for k in m.get('studentInfoSimpleList'):
                temp_model = CollegeListStudentInfoResponseBodyStudentInfoSimpleList()
                self.student_info_simple_list.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class CollegeListStudentInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CollegeListStudentInfoResponseBody = None,
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
            temp_model = CollegeListStudentInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CollegeListUncheckedStudentHeaders(TeaModel):
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


class CollegeListUncheckedStudentRequest(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        page_number: int = None,
        page_size: int = None,
    ):
        # 部门id
        self.dept_id = dept_id
        # 页码
        self.page_number = page_number
        # 分页条目数
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class CollegeListUncheckedStudentResponseBodyStudentInfoSimpleList(TeaModel):
    def __init__(
        self,
        ding_member_status: str = None,
        is_active: bool = None,
        student_id: int = None,
        student_name: str = None,
        union_id: str = None,
        user_id: str = None,
    ):
        # 人员在组织的状态
        self.ding_member_status = ding_member_status
        # 账号是否激活
        self.is_active = is_active
        # 学生id
        self.student_id = student_id
        # 学生姓名
        self.student_name = student_name
        # unionId
        self.union_id = union_id
        # userId
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_member_status is not None:
            result['dingMemberStatus'] = self.ding_member_status
        if self.is_active is not None:
            result['isActive'] = self.is_active
        if self.student_id is not None:
            result['studentId'] = self.student_id
        if self.student_name is not None:
            result['studentName'] = self.student_name
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingMemberStatus') is not None:
            self.ding_member_status = m.get('dingMemberStatus')
        if m.get('isActive') is not None:
            self.is_active = m.get('isActive')
        if m.get('studentId') is not None:
            self.student_id = m.get('studentId')
        if m.get('studentName') is not None:
            self.student_name = m.get('studentName')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CollegeListUncheckedStudentResponseBody(TeaModel):
    def __init__(
        self,
        student_info_simple_list: List[CollegeListUncheckedStudentResponseBodyStudentInfoSimpleList] = None,
        total_count: int = None,
    ):
        # 学生信息列表
        self.student_info_simple_list = student_info_simple_list
        # 条目总数
        self.total_count = total_count

    def validate(self):
        if self.student_info_simple_list:
            for k in self.student_info_simple_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['studentInfoSimpleList'] = []
        if self.student_info_simple_list is not None:
            for k in self.student_info_simple_list:
                result['studentInfoSimpleList'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.student_info_simple_list = []
        if m.get('studentInfoSimpleList') is not None:
            for k in m.get('studentInfoSimpleList'):
                temp_model = CollegeListUncheckedStudentResponseBodyStudentInfoSimpleList()
                self.student_info_simple_list.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class CollegeListUncheckedStudentResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CollegeListUncheckedStudentResponseBody = None,
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
            temp_model = CollegeListUncheckedStudentResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CollegeQueryCollegeDeptGroupInfoHeaders(TeaModel):
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


class CollegeQueryCollegeDeptGroupInfoRequest(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
    ):
        # 部门id
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


class CollegeQueryCollegeDeptGroupInfoResponseBody(TeaModel):
    def __init__(
        self,
        group_name: str = None,
        open_conversation_id: str = None,
    ):
        # 群名称
        self.group_name = group_name
        # 群编号
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class CollegeQueryCollegeDeptGroupInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CollegeQueryCollegeDeptGroupInfoResponseBody = None,
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
            temp_model = CollegeQueryCollegeDeptGroupInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CollegeQueryCollegeDeptInfoHeaders(TeaModel):
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


class CollegeQueryCollegeDeptInfoRequest(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
    ):
        # 部门id
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


class CollegeQueryCollegeDeptInfoResponseBody(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        dept_name: str = None,
        dept_type: str = None,
        sort_factor: int = None,
        super_id: int = None,
    ):
        # 部门id
        self.dept_id = dept_id
        # 部门名称
        self.dept_name = dept_name
        # 部门类型
        self.dept_type = dept_type
        # 排序因子
        self.sort_factor = sort_factor
        # 父部门编号
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
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.dept_type is not None:
            result['deptType'] = self.dept_type
        if self.sort_factor is not None:
            result['sortFactor'] = self.sort_factor
        if self.super_id is not None:
            result['superId'] = self.super_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('deptType') is not None:
            self.dept_type = m.get('deptType')
        if m.get('sortFactor') is not None:
            self.sort_factor = m.get('sortFactor')
        if m.get('superId') is not None:
            self.super_id = m.get('superId')
        return self


class CollegeQueryCollegeDeptInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CollegeQueryCollegeDeptInfoResponseBody = None,
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
            temp_model = CollegeQueryCollegeDeptInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CollegeQueryStudentInfoByDeptHeaders(TeaModel):
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


class CollegeQueryStudentInfoByDeptRequest(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        student_id: int = None,
    ):
        # 部门id
        self.dept_id = dept_id
        # 学生id
        self.student_id = student_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.student_id is not None:
            result['studentId'] = self.student_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('studentId') is not None:
            self.student_id = m.get('studentId')
        return self


class CollegeQueryStudentInfoByDeptResponseBody(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        ding_member_status: str = None,
        emp_extension: Dict[str, Any] = None,
        gender: str = None,
        identify_id: str = None,
        is_active: bool = None,
        start_year: str = None,
        student_id: int = None,
        student_name: str = None,
        student_number: str = None,
        union_id: str = None,
        user_id: str = None,
    ):
        # 部门id
        self.dept_id = dept_id
        # 学生在组织状态
        self.ding_member_status = ding_member_status
        # 人员拓展信息
        self.emp_extension = emp_extension
        # 性别
        self.gender = gender
        # 身份证号
        self.identify_id = identify_id
        # 账号是否激活
        self.is_active = is_active
        # 入学年月
        self.start_year = start_year
        # 学生id
        self.student_id = student_id
        # 学生姓名
        self.student_name = student_name
        # 学生学号
        self.student_number = student_number
        # unionId
        self.union_id = union_id
        # userId
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.ding_member_status is not None:
            result['dingMemberStatus'] = self.ding_member_status
        if self.emp_extension is not None:
            result['empExtension'] = self.emp_extension
        if self.gender is not None:
            result['gender'] = self.gender
        if self.identify_id is not None:
            result['identifyId'] = self.identify_id
        if self.is_active is not None:
            result['isActive'] = self.is_active
        if self.start_year is not None:
            result['startYear'] = self.start_year
        if self.student_id is not None:
            result['studentId'] = self.student_id
        if self.student_name is not None:
            result['studentName'] = self.student_name
        if self.student_number is not None:
            result['studentNumber'] = self.student_number
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('dingMemberStatus') is not None:
            self.ding_member_status = m.get('dingMemberStatus')
        if m.get('empExtension') is not None:
            self.emp_extension = m.get('empExtension')
        if m.get('gender') is not None:
            self.gender = m.get('gender')
        if m.get('identifyId') is not None:
            self.identify_id = m.get('identifyId')
        if m.get('isActive') is not None:
            self.is_active = m.get('isActive')
        if m.get('startYear') is not None:
            self.start_year = m.get('startYear')
        if m.get('studentId') is not None:
            self.student_id = m.get('studentId')
        if m.get('studentName') is not None:
            self.student_name = m.get('studentName')
        if m.get('studentNumber') is not None:
            self.student_number = m.get('studentNumber')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CollegeQueryStudentInfoByDeptResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CollegeQueryStudentInfoByDeptResponseBody = None,
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
            temp_model = CollegeQueryStudentInfoByDeptResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CollegeQueryStudentInfoByMobileHeaders(TeaModel):
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


class CollegeQueryStudentInfoByMobileRequest(TeaModel):
    def __init__(
        self,
        mobile: str = None,
    ):
        # 手机号
        self.mobile = mobile

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.mobile is not None:
            result['mobile'] = self.mobile
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('mobile') is not None:
            self.mobile = m.get('mobile')
        return self


class CollegeQueryStudentInfoByMobileResponseBodyDeptStudentInfoList(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        member_type: str = None,
        student_number: str = None,
    ):
        # 部门id
        self.dept_id = dept_id
        # 人员类别
        self.member_type = member_type
        # 学生学号
        self.student_number = student_number

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.member_type is not None:
            result['memberType'] = self.member_type
        if self.student_number is not None:
            result['studentNumber'] = self.student_number
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('memberType') is not None:
            self.member_type = m.get('memberType')
        if m.get('studentNumber') is not None:
            self.student_number = m.get('studentNumber')
        return self


class CollegeQueryStudentInfoByMobileResponseBody(TeaModel):
    def __init__(
        self,
        dept_student_info_list: List[CollegeQueryStudentInfoByMobileResponseBodyDeptStudentInfoList] = None,
        ding_member_status: str = None,
        emp_extension: Dict[str, Any] = None,
        gender: str = None,
        identify_id: str = None,
        is_active: bool = None,
        start_year: str = None,
        student_id: int = None,
        student_name: str = None,
        union_id: str = None,
        user_id: str = None,
    ):
        # 部门拓展信息列表
        self.dept_student_info_list = dept_student_info_list
        # 学生在组织状态
        self.ding_member_status = ding_member_status
        # 人员拓展信息
        self.emp_extension = emp_extension
        # 性别
        self.gender = gender
        # 身份证号
        self.identify_id = identify_id
        # 账号是否激活
        self.is_active = is_active
        # 入学年月
        self.start_year = start_year
        # 学生id
        self.student_id = student_id
        # 学生姓名
        self.student_name = student_name
        # unionId
        self.union_id = union_id
        # userId
        self.user_id = user_id

    def validate(self):
        if self.dept_student_info_list:
            for k in self.dept_student_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['deptStudentInfoList'] = []
        if self.dept_student_info_list is not None:
            for k in self.dept_student_info_list:
                result['deptStudentInfoList'].append(k.to_map() if k else None)
        if self.ding_member_status is not None:
            result['dingMemberStatus'] = self.ding_member_status
        if self.emp_extension is not None:
            result['empExtension'] = self.emp_extension
        if self.gender is not None:
            result['gender'] = self.gender
        if self.identify_id is not None:
            result['identifyId'] = self.identify_id
        if self.is_active is not None:
            result['isActive'] = self.is_active
        if self.start_year is not None:
            result['startYear'] = self.start_year
        if self.student_id is not None:
            result['studentId'] = self.student_id
        if self.student_name is not None:
            result['studentName'] = self.student_name
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.dept_student_info_list = []
        if m.get('deptStudentInfoList') is not None:
            for k in m.get('deptStudentInfoList'):
                temp_model = CollegeQueryStudentInfoByMobileResponseBodyDeptStudentInfoList()
                self.dept_student_info_list.append(temp_model.from_map(k))
        if m.get('dingMemberStatus') is not None:
            self.ding_member_status = m.get('dingMemberStatus')
        if m.get('empExtension') is not None:
            self.emp_extension = m.get('empExtension')
        if m.get('gender') is not None:
            self.gender = m.get('gender')
        if m.get('identifyId') is not None:
            self.identify_id = m.get('identifyId')
        if m.get('isActive') is not None:
            self.is_active = m.get('isActive')
        if m.get('startYear') is not None:
            self.start_year = m.get('startYear')
        if m.get('studentId') is not None:
            self.student_id = m.get('studentId')
        if m.get('studentName') is not None:
            self.student_name = m.get('studentName')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CollegeQueryStudentInfoByMobileResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CollegeQueryStudentInfoByMobileResponseBody = None,
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
            temp_model = CollegeQueryStudentInfoByMobileResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CollegeQueryStudentInfoByStudentIdHeaders(TeaModel):
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


class CollegeQueryStudentInfoByStudentIdRequest(TeaModel):
    def __init__(
        self,
        student_id: int = None,
    ):
        # 学生id
        self.student_id = student_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.student_id is not None:
            result['studentId'] = self.student_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('studentId') is not None:
            self.student_id = m.get('studentId')
        return self


class CollegeQueryStudentInfoByStudentIdResponseBodyDeptStudentInfoList(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        member_type: str = None,
        student_number: str = None,
    ):
        # 部门id
        self.dept_id = dept_id
        # 人员类别
        self.member_type = member_type
        # 学生学号
        self.student_number = student_number

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.member_type is not None:
            result['memberType'] = self.member_type
        if self.student_number is not None:
            result['studentNumber'] = self.student_number
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('memberType') is not None:
            self.member_type = m.get('memberType')
        if m.get('studentNumber') is not None:
            self.student_number = m.get('studentNumber')
        return self


class CollegeQueryStudentInfoByStudentIdResponseBody(TeaModel):
    def __init__(
        self,
        dept_student_info_list: List[CollegeQueryStudentInfoByStudentIdResponseBodyDeptStudentInfoList] = None,
        ding_member_status: str = None,
        emp_extension: Dict[str, Any] = None,
        gender: str = None,
        identify_id: str = None,
        is_active: bool = None,
        start_year: str = None,
        student_id: int = None,
        student_name: str = None,
        union_id: str = None,
        user_id: str = None,
    ):
        # 部门拓展信息列表
        self.dept_student_info_list = dept_student_info_list
        # 学生在组织状态
        self.ding_member_status = ding_member_status
        # 人员拓展信息
        self.emp_extension = emp_extension
        # 性别
        self.gender = gender
        # 身份证号
        self.identify_id = identify_id
        # 账号是否激活
        self.is_active = is_active
        # 入学年月
        self.start_year = start_year
        # 学生id
        self.student_id = student_id
        # 学生姓名
        self.student_name = student_name
        # unionId
        self.union_id = union_id
        # userId
        self.user_id = user_id

    def validate(self):
        if self.dept_student_info_list:
            for k in self.dept_student_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['deptStudentInfoList'] = []
        if self.dept_student_info_list is not None:
            for k in self.dept_student_info_list:
                result['deptStudentInfoList'].append(k.to_map() if k else None)
        if self.ding_member_status is not None:
            result['dingMemberStatus'] = self.ding_member_status
        if self.emp_extension is not None:
            result['empExtension'] = self.emp_extension
        if self.gender is not None:
            result['gender'] = self.gender
        if self.identify_id is not None:
            result['identifyId'] = self.identify_id
        if self.is_active is not None:
            result['isActive'] = self.is_active
        if self.start_year is not None:
            result['startYear'] = self.start_year
        if self.student_id is not None:
            result['studentId'] = self.student_id
        if self.student_name is not None:
            result['studentName'] = self.student_name
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.dept_student_info_list = []
        if m.get('deptStudentInfoList') is not None:
            for k in m.get('deptStudentInfoList'):
                temp_model = CollegeQueryStudentInfoByStudentIdResponseBodyDeptStudentInfoList()
                self.dept_student_info_list.append(temp_model.from_map(k))
        if m.get('dingMemberStatus') is not None:
            self.ding_member_status = m.get('dingMemberStatus')
        if m.get('empExtension') is not None:
            self.emp_extension = m.get('empExtension')
        if m.get('gender') is not None:
            self.gender = m.get('gender')
        if m.get('identifyId') is not None:
            self.identify_id = m.get('identifyId')
        if m.get('isActive') is not None:
            self.is_active = m.get('isActive')
        if m.get('startYear') is not None:
            self.start_year = m.get('startYear')
        if m.get('studentId') is not None:
            self.student_id = m.get('studentId')
        if m.get('studentName') is not None:
            self.student_name = m.get('studentName')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CollegeQueryStudentInfoByStudentIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CollegeQueryStudentInfoByStudentIdResponseBody = None,
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
            temp_model = CollegeQueryStudentInfoByStudentIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CollegeRemoveManagerHeaders(TeaModel):
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


class CollegeRemoveManagerRequest(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        is_force: bool = None,
        user_id: str = None,
    ):
        # 部门id
        self.dept_id = dept_id
        # 是否强制移除
        self.is_force = is_force
        # userId
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.is_force is not None:
            result['isForce'] = self.is_force
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('isForce') is not None:
            self.is_force = m.get('isForce')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CollegeRemoveManagerResponseBody(TeaModel):
    def __init__(
        self,
        is_successful: bool = None,
    ):
        # 移除负责人是否成功
        self.is_successful = is_successful

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.is_successful is not None:
            result['isSuccessful'] = self.is_successful
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isSuccessful') is not None:
            self.is_successful = m.get('isSuccessful')
        return self


class CollegeRemoveManagerResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CollegeRemoveManagerResponseBody = None,
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
            temp_model = CollegeRemoveManagerResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CollegeRemoveStudentHeaders(TeaModel):
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


class CollegeRemoveStudentRequest(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        student_id: int = None,
    ):
        # 部门id
        self.dept_id = dept_id
        # 学生id
        self.student_id = student_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.student_id is not None:
            result['studentId'] = self.student_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('studentId') is not None:
            self.student_id = m.get('studentId')
        return self


class CollegeRemoveStudentResponseBody(TeaModel):
    def __init__(
        self,
        is_successful: bool = None,
    ):
        # 移除学生是否成功
        self.is_successful = is_successful

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.is_successful is not None:
            result['isSuccessful'] = self.is_successful
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isSuccessful') is not None:
            self.is_successful = m.get('isSuccessful')
        return self


class CollegeRemoveStudentResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CollegeRemoveStudentResponseBody = None,
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
            temp_model = CollegeRemoveStudentResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CollegeUpdateCollegeDeptHeaders(TeaModel):
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


class CollegeUpdateCollegeDeptRequest(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        dept_name: str = None,
        sort_factor: int = None,
        super_id: int = None,
    ):
        # 部门id
        self.dept_id = dept_id
        # 部门名称
        self.dept_name = dept_name
        # 排序因子
        self.sort_factor = sort_factor
        # 父部门id
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
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.sort_factor is not None:
            result['sortFactor'] = self.sort_factor
        if self.super_id is not None:
            result['superId'] = self.super_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('sortFactor') is not None:
            self.sort_factor = m.get('sortFactor')
        if m.get('superId') is not None:
            self.super_id = m.get('superId')
        return self


class CollegeUpdateCollegeDeptResponseBody(TeaModel):
    def __init__(
        self,
        is_successful: bool = None,
    ):
        # 更新部门信息是否成功
        self.is_successful = is_successful

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.is_successful is not None:
            result['isSuccessful'] = self.is_successful
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isSuccessful') is not None:
            self.is_successful = m.get('isSuccessful')
        return self


class CollegeUpdateCollegeDeptResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CollegeUpdateCollegeDeptResponseBody = None,
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
            temp_model = CollegeUpdateCollegeDeptResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CollegeUpdateStudentDeptInfoHeaders(TeaModel):
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


class CollegeUpdateStudentDeptInfoRequest(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        student_id: int = None,
        student_number: str = None,
    ):
        # 部门id
        self.dept_id = dept_id
        # 学生id
        self.student_id = student_id
        # 学号
        self.student_number = student_number

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.student_id is not None:
            result['studentId'] = self.student_id
        if self.student_number is not None:
            result['studentNumber'] = self.student_number
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('studentId') is not None:
            self.student_id = m.get('studentId')
        if m.get('studentNumber') is not None:
            self.student_number = m.get('studentNumber')
        return self


class CollegeUpdateStudentDeptInfoResponseBody(TeaModel):
    def __init__(
        self,
        is_successful: bool = None,
    ):
        # 学生的部门相关信息是否修改成功
        self.is_successful = is_successful

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.is_successful is not None:
            result['isSuccessful'] = self.is_successful
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isSuccessful') is not None:
            self.is_successful = m.get('isSuccessful')
        return self


class CollegeUpdateStudentDeptInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CollegeUpdateStudentDeptInfoResponseBody = None,
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
            temp_model = CollegeUpdateStudentDeptInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CollegeUpdateStudentInfoHeaders(TeaModel):
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


class CollegeUpdateStudentInfoRequest(TeaModel):
    def __init__(
        self,
        emp_extension: Dict[str, str] = None,
        gender: str = None,
        identify_id: str = None,
        start_year: str = None,
        student_id: int = None,
        student_name: str = None,
    ):
        # 人员拓展信息
        self.emp_extension = emp_extension
        # 性别
        self.gender = gender
        # 身份证号
        self.identify_id = identify_id
        # 入学年份
        self.start_year = start_year
        # studentId
        self.student_id = student_id
        # 学生姓名
        self.student_name = student_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.emp_extension is not None:
            result['empExtension'] = self.emp_extension
        if self.gender is not None:
            result['gender'] = self.gender
        if self.identify_id is not None:
            result['identifyId'] = self.identify_id
        if self.start_year is not None:
            result['startYear'] = self.start_year
        if self.student_id is not None:
            result['studentId'] = self.student_id
        if self.student_name is not None:
            result['studentName'] = self.student_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('empExtension') is not None:
            self.emp_extension = m.get('empExtension')
        if m.get('gender') is not None:
            self.gender = m.get('gender')
        if m.get('identifyId') is not None:
            self.identify_id = m.get('identifyId')
        if m.get('startYear') is not None:
            self.start_year = m.get('startYear')
        if m.get('studentId') is not None:
            self.student_id = m.get('studentId')
        if m.get('studentName') is not None:
            self.student_name = m.get('studentName')
        return self


class CollegeUpdateStudentInfoResponseBody(TeaModel):
    def __init__(
        self,
        is_successful: bool = None,
    ):
        # 学生信息是否修改成功
        self.is_successful = is_successful

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.is_successful is not None:
            result['isSuccessful'] = self.is_successful
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isSuccessful') is not None:
            self.is_successful = m.get('isSuccessful')
        return self


class CollegeUpdateStudentInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CollegeUpdateStudentInfoResponseBody = None,
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
            temp_model = CollegeUpdateStudentInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CollegeUpdateStudentMoblieHeaders(TeaModel):
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


class CollegeUpdateStudentMoblieRequest(TeaModel):
    def __init__(
        self,
        is_force: bool = None,
        new_mobile: str = None,
        student_id: int = None,
    ):
        # 是否直接更换
        self.is_force = is_force
        # 修改后的手机号
        self.new_mobile = new_mobile
        # 学生id
        self.student_id = student_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.is_force is not None:
            result['isForce'] = self.is_force
        if self.new_mobile is not None:
            result['newMobile'] = self.new_mobile
        if self.student_id is not None:
            result['studentId'] = self.student_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isForce') is not None:
            self.is_force = m.get('isForce')
        if m.get('newMobile') is not None:
            self.new_mobile = m.get('newMobile')
        if m.get('studentId') is not None:
            self.student_id = m.get('studentId')
        return self


class CollegeUpdateStudentMoblieResponseBody(TeaModel):
    def __init__(
        self,
        update_result: str = None,
    ):
        # 修改结果
        self.update_result = update_result

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.update_result is not None:
            result['updateResult'] = self.update_result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('updateResult') is not None:
            self.update_result = m.get('updateResult')
        return self


class CollegeUpdateStudentMoblieResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CollegeUpdateStudentMoblieResponseBody = None,
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
            temp_model = CollegeUpdateStudentMoblieResponseBody()
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


class CustomizeContactDeptGroupCreateHeaders(TeaModel):
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


class CustomizeContactDeptGroupCreateRequest(TeaModel):
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


class CustomizeContactDeptGroupCreateResponseBody(TeaModel):
    def __init__(
        self,
        content: str = None,
    ):
        # Id of the request
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


class CustomizeContactDeptGroupCreateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CustomizeContactDeptGroupCreateResponseBody = None,
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
            temp_model = CustomizeContactDeptGroupCreateResponseBody()
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


class ExternalQueryExternalAppOrgsHeaders(TeaModel):
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


class ExternalQueryExternalAppOrgsRequest(TeaModel):
    def __init__(
        self,
        external_type: str = None,
    ):
        # 外部组织类型
        self.external_type = external_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.external_type is not None:
            result['externalType'] = self.external_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('externalType') is not None:
            self.external_type = m.get('externalType')
        return self


class ExternalQueryExternalAppOrgsResponseBodyResult(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        corp_name: str = None,
    ):
        # 外部合作组织ID
        self.corp_id = corp_id
        # 外部合作组织名称
        self.corp_name = corp_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.corp_name is not None:
            result['corpName'] = self.corp_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('corpName') is not None:
            self.corp_name = m.get('corpName')
        return self


class ExternalQueryExternalAppOrgsResponseBody(TeaModel):
    def __init__(
        self,
        result: List[ExternalQueryExternalAppOrgsResponseBodyResult] = None,
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
                temp_model = ExternalQueryExternalAppOrgsResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class ExternalQueryExternalAppOrgsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ExternalQueryExternalAppOrgsResponseBody = None,
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
            temp_model = ExternalQueryExternalAppOrgsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ExternalQueryExternalBelongMainOrgHeaders(TeaModel):
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


class ExternalQueryExternalBelongMainOrgRequest(TeaModel):
    def __init__(
        self,
        external_type: str = None,
    ):
        # 外部组织类型
        self.external_type = external_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.external_type is not None:
            result['externalType'] = self.external_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('externalType') is not None:
            self.external_type = m.get('externalType')
        return self


class ExternalQueryExternalBelongMainOrgResponseBody(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        corp_name: str = None,
    ):
        self.corp_id = corp_id
        self.corp_name = corp_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.corp_name is not None:
            result['corpName'] = self.corp_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('corpName') is not None:
            self.corp_name = m.get('corpName')
        return self


class ExternalQueryExternalBelongMainOrgResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ExternalQueryExternalBelongMainOrgResponseBody = None,
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
            temp_model = ExternalQueryExternalBelongMainOrgResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ExternalQueryExternalOrgsHeaders(TeaModel):
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


class ExternalQueryExternalOrgsRequest(TeaModel):
    def __init__(
        self,
        external_type: str = None,
    ):
        # 外部组织类型,ecological:上下游
        self.external_type = external_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.external_type is not None:
            result['externalType'] = self.external_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('externalType') is not None:
            self.external_type = m.get('externalType')
        return self


class ExternalQueryExternalOrgsResponseBodyResult(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        corp_name: str = None,
    ):
        # 外部合作组织ID
        self.corp_id = corp_id
        # 外部合作组织名称
        self.corp_name = corp_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.corp_name is not None:
            result['corpName'] = self.corp_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('corpName') is not None:
            self.corp_name = m.get('corpName')
        return self


class ExternalQueryExternalOrgsResponseBody(TeaModel):
    def __init__(
        self,
        result: List[ExternalQueryExternalOrgsResponseBodyResult] = None,
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
                temp_model = ExternalQueryExternalOrgsResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class ExternalQueryExternalOrgsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ExternalQueryExternalOrgsResponseBody = None,
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
            temp_model = ExternalQueryExternalOrgsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class HospitalDataCheckHeaders(TeaModel):
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


class HospitalDataCheckRequest(TeaModel):
    def __init__(
        self,
        all_dept_count: int = None,
        all_dept_user_count: int = None,
        all_group_count: int = None,
        all_group_user_count: int = None,
        dept_count: int = None,
        dept_user_count: int = None,
        group_count: int = None,
        group_user_count: int = None,
    ):
        # 所有状态的科室数量
        self.all_dept_count = all_dept_count
        # 正常状态的科室人员数量
        self.all_dept_user_count = all_dept_user_count
        # 所有状态的医疗组数量
        self.all_group_count = all_group_count
        # 所有状态的医疗组人员数量
        self.all_group_user_count = all_group_user_count
        # 状态为0的科室数量
        self.dept_count = dept_count
        # 正常状态的科室人员数量
        self.dept_user_count = dept_user_count
        # 正常状态的医疗组数量
        self.group_count = group_count
        # 正常状态的医疗组人员数量
        self.group_user_count = group_user_count

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.all_dept_count is not None:
            result['allDeptCount'] = self.all_dept_count
        if self.all_dept_user_count is not None:
            result['allDeptUserCount'] = self.all_dept_user_count
        if self.all_group_count is not None:
            result['allGroupCount'] = self.all_group_count
        if self.all_group_user_count is not None:
            result['allGroupUserCount'] = self.all_group_user_count
        if self.dept_count is not None:
            result['deptCount'] = self.dept_count
        if self.dept_user_count is not None:
            result['deptUserCount'] = self.dept_user_count
        if self.group_count is not None:
            result['groupCount'] = self.group_count
        if self.group_user_count is not None:
            result['groupUserCount'] = self.group_user_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('allDeptCount') is not None:
            self.all_dept_count = m.get('allDeptCount')
        if m.get('allDeptUserCount') is not None:
            self.all_dept_user_count = m.get('allDeptUserCount')
        if m.get('allGroupCount') is not None:
            self.all_group_count = m.get('allGroupCount')
        if m.get('allGroupUserCount') is not None:
            self.all_group_user_count = m.get('allGroupUserCount')
        if m.get('deptCount') is not None:
            self.dept_count = m.get('deptCount')
        if m.get('deptUserCount') is not None:
            self.dept_user_count = m.get('deptUserCount')
        if m.get('groupCount') is not None:
            self.group_count = m.get('groupCount')
        if m.get('groupUserCount') is not None:
            self.group_user_count = m.get('groupUserCount')
        return self


class HospitalDataCheckResponseBody(TeaModel):
    def __init__(
        self,
        all_dept_count: int = None,
        all_dept_user_count: int = None,
        all_group_count: int = None,
        all_group_user_count: int = None,
        dept_count: int = None,
        dept_user_count: int = None,
        group_count: int = None,
        group_user_count: int = None,
        match: bool = None,
    ):
        # 所有状态的科室数量
        self.all_dept_count = all_dept_count
        # 所有状态的科室人员数量
        self.all_dept_user_count = all_dept_user_count
        # 所有状态的医疗组数量
        self.all_group_count = all_group_count
        # 所有状态的医疗组人员数量
        self.all_group_user_count = all_group_user_count
        # 正常状态的科室数量
        self.dept_count = dept_count
        # 正常状态的科室人员数量
        self.dept_user_count = dept_user_count
        # 正常状态的医疗组数量
        self.group_count = group_count
        # 正常状态的医疗组人员数量
        self.group_user_count = group_user_count
        # 数据是否一致
        self.match = match

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.all_dept_count is not None:
            result['allDeptCount'] = self.all_dept_count
        if self.all_dept_user_count is not None:
            result['allDeptUserCount'] = self.all_dept_user_count
        if self.all_group_count is not None:
            result['allGroupCount'] = self.all_group_count
        if self.all_group_user_count is not None:
            result['allGroupUserCount'] = self.all_group_user_count
        if self.dept_count is not None:
            result['deptCount'] = self.dept_count
        if self.dept_user_count is not None:
            result['deptUserCount'] = self.dept_user_count
        if self.group_count is not None:
            result['groupCount'] = self.group_count
        if self.group_user_count is not None:
            result['groupUserCount'] = self.group_user_count
        if self.match is not None:
            result['match'] = self.match
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('allDeptCount') is not None:
            self.all_dept_count = m.get('allDeptCount')
        if m.get('allDeptUserCount') is not None:
            self.all_dept_user_count = m.get('allDeptUserCount')
        if m.get('allGroupCount') is not None:
            self.all_group_count = m.get('allGroupCount')
        if m.get('allGroupUserCount') is not None:
            self.all_group_user_count = m.get('allGroupUserCount')
        if m.get('deptCount') is not None:
            self.dept_count = m.get('deptCount')
        if m.get('deptUserCount') is not None:
            self.dept_user_count = m.get('deptUserCount')
        if m.get('groupCount') is not None:
            self.group_count = m.get('groupCount')
        if m.get('groupUserCount') is not None:
            self.group_user_count = m.get('groupUserCount')
        if m.get('match') is not None:
            self.match = m.get('match')
        return self


class HospitalDataCheckResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: HospitalDataCheckResponseBody = None,
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
            temp_model = HospitalDataCheckResponseBody()
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


class IndustryManufactureMesDispatchTaskHeaders(TeaModel):
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


class IndustryManufactureMesDispatchTaskRequest(TeaModel):
    def __init__(
        self,
        action: str = None,
        app_key: str = None,
        base_data_name: str = None,
        defects_amount: str = None,
        dispatch_staff_name: str = None,
        dispatch_staff_no: str = None,
        fine_amount: str = None,
        overdue: int = None,
        plan_quantity: int = None,
        priority: int = None,
        process_name: str = None,
        process_uuid: str = None,
        product_code: str = None,
        product_name: str = None,
        product_specification: str = None,
        project_code: str = None,
        project_id: str = None,
        project_status: str = None,
        task_operators: str = None,
        task_plan_end_time: str = None,
        task_plan_start_time: str = None,
        task_status: str = None,
        task_type: str = None,
        team_id: str = None,
        uuid: str = None,
    ):
        # 本次操作的行为
        self.action = action
        # 生态唯一标识, 需要注册
        self.app_key = app_key
        # 主数据名称
        self.base_data_name = base_data_name
        # 不良品总数(多次报工)
        self.defects_amount = defects_amount
        # 派工人名称
        self.dispatch_staff_name = dispatch_staff_name
        # 派工人ID
        self.dispatch_staff_no = dispatch_staff_no
        # 良品总数(多次报工)
        self.fine_amount = fine_amount
        # 任务逾期
        self.overdue = overdue
        # 派工(总)数
        self.plan_quantity = plan_quantity
        # 是否加急
        self.priority = priority
        # 工序名称
        self.process_name = process_name
        # 工序业务唯一标识
        self.process_uuid = process_uuid
        # 产品编号(物料编号)
        self.product_code = product_code
        # 产品名称
        self.product_name = product_name
        # 产品(物料)规格
        self.product_specification = product_specification
        # 工单编号(生产任务单)
        self.project_code = project_code
        # 工单(生产计划单)
        self.project_id = project_id
        # 工单状态
        self.project_status = project_status
        # 任务分配员工列表(生产人员)
        self.task_operators = task_operators
        # 任务计划结束(完成)时间
        self.task_plan_end_time = task_plan_end_time
        # 任务计划开始时间
        self.task_plan_start_time = task_plan_start_time
        # 派工任务状态
        self.task_status = task_status
        # 任务类型(正常和委外)
        self.task_type = task_type
        # 负责班组id
        self.team_id = team_id
        # 本次记录唯一标识
        self.uuid = uuid

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
        if self.base_data_name is not None:
            result['baseDataName'] = self.base_data_name
        if self.defects_amount is not None:
            result['defectsAmount'] = self.defects_amount
        if self.dispatch_staff_name is not None:
            result['dispatchStaffName'] = self.dispatch_staff_name
        if self.dispatch_staff_no is not None:
            result['dispatchStaffNo'] = self.dispatch_staff_no
        if self.fine_amount is not None:
            result['fineAmount'] = self.fine_amount
        if self.overdue is not None:
            result['overdue'] = self.overdue
        if self.plan_quantity is not None:
            result['planQuantity'] = self.plan_quantity
        if self.priority is not None:
            result['priority'] = self.priority
        if self.process_name is not None:
            result['processName'] = self.process_name
        if self.process_uuid is not None:
            result['processUuid'] = self.process_uuid
        if self.product_code is not None:
            result['productCode'] = self.product_code
        if self.product_name is not None:
            result['productName'] = self.product_name
        if self.product_specification is not None:
            result['productSpecification'] = self.product_specification
        if self.project_code is not None:
            result['projectCode'] = self.project_code
        if self.project_id is not None:
            result['projectId'] = self.project_id
        if self.project_status is not None:
            result['projectStatus'] = self.project_status
        if self.task_operators is not None:
            result['taskOperators'] = self.task_operators
        if self.task_plan_end_time is not None:
            result['taskPlanEndTime'] = self.task_plan_end_time
        if self.task_plan_start_time is not None:
            result['taskPlanStartTime'] = self.task_plan_start_time
        if self.task_status is not None:
            result['taskStatus'] = self.task_status
        if self.task_type is not None:
            result['taskType'] = self.task_type
        if self.team_id is not None:
            result['teamId'] = self.team_id
        if self.uuid is not None:
            result['uuid'] = self.uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('action') is not None:
            self.action = m.get('action')
        if m.get('appKey') is not None:
            self.app_key = m.get('appKey')
        if m.get('baseDataName') is not None:
            self.base_data_name = m.get('baseDataName')
        if m.get('defectsAmount') is not None:
            self.defects_amount = m.get('defectsAmount')
        if m.get('dispatchStaffName') is not None:
            self.dispatch_staff_name = m.get('dispatchStaffName')
        if m.get('dispatchStaffNo') is not None:
            self.dispatch_staff_no = m.get('dispatchStaffNo')
        if m.get('fineAmount') is not None:
            self.fine_amount = m.get('fineAmount')
        if m.get('overdue') is not None:
            self.overdue = m.get('overdue')
        if m.get('planQuantity') is not None:
            self.plan_quantity = m.get('planQuantity')
        if m.get('priority') is not None:
            self.priority = m.get('priority')
        if m.get('processName') is not None:
            self.process_name = m.get('processName')
        if m.get('processUuid') is not None:
            self.process_uuid = m.get('processUuid')
        if m.get('productCode') is not None:
            self.product_code = m.get('productCode')
        if m.get('productName') is not None:
            self.product_name = m.get('productName')
        if m.get('productSpecification') is not None:
            self.product_specification = m.get('productSpecification')
        if m.get('projectCode') is not None:
            self.project_code = m.get('projectCode')
        if m.get('projectId') is not None:
            self.project_id = m.get('projectId')
        if m.get('projectStatus') is not None:
            self.project_status = m.get('projectStatus')
        if m.get('taskOperators') is not None:
            self.task_operators = m.get('taskOperators')
        if m.get('taskPlanEndTime') is not None:
            self.task_plan_end_time = m.get('taskPlanEndTime')
        if m.get('taskPlanStartTime') is not None:
            self.task_plan_start_time = m.get('taskPlanStartTime')
        if m.get('taskStatus') is not None:
            self.task_status = m.get('taskStatus')
        if m.get('taskType') is not None:
            self.task_type = m.get('taskType')
        if m.get('teamId') is not None:
            self.team_id = m.get('teamId')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        return self


class IndustryManufactureMesDispatchTaskResponseBodyResult(TeaModel):
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


class IndustryManufactureMesDispatchTaskResponseBody(TeaModel):
    def __init__(
        self,
        result: IndustryManufactureMesDispatchTaskResponseBodyResult = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = IndustryManufactureMesDispatchTaskResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class IndustryManufactureMesDispatchTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: IndustryManufactureMesDispatchTaskResponseBody = None,
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
            temp_model = IndustryManufactureMesDispatchTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class IndustryManufactureMesMaterialHeaders(TeaModel):
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


class IndustryManufactureMesMaterialRequestExtendData(TeaModel):
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
        # 字段实际取值
        self.value = value
        # 字段类型
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


class IndustryManufactureMesMaterialRequest(TeaModel):
    def __init__(
        self,
        action: str = None,
        app_key: str = None,
        base_data_name: str = None,
        category: str = None,
        extend_data: List[IndustryManufactureMesMaterialRequestExtendData] = None,
        product_code: str = None,
        product_name: str = None,
        product_specification: str = None,
        prop: str = None,
        unit: str = None,
        uuid: str = None,
    ):
        # 本次操作的行为
        self.action = action
        # 生态唯一标识
        self.app_key = app_key
        # 主数据名称
        self.base_data_name = base_data_name
        # 物料品类
        self.category = category
        # 扩展字段
        self.extend_data = extend_data
        # 物料编号
        self.product_code = product_code
        # 物料名称
        self.product_name = product_name
        # 物料规格
        self.product_specification = product_specification
        # 物料属性，如原材料/成品/半成品
        self.prop = prop
        # 物料单位
        self.unit = unit
        # 物料唯一标识
        self.uuid = uuid

    def validate(self):
        if self.extend_data:
            for k in self.extend_data:
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
        if self.category is not None:
            result['category'] = self.category
        result['extendData'] = []
        if self.extend_data is not None:
            for k in self.extend_data:
                result['extendData'].append(k.to_map() if k else None)
        if self.product_code is not None:
            result['productCode'] = self.product_code
        if self.product_name is not None:
            result['productName'] = self.product_name
        if self.product_specification is not None:
            result['productSpecification'] = self.product_specification
        if self.prop is not None:
            result['prop'] = self.prop
        if self.unit is not None:
            result['unit'] = self.unit
        if self.uuid is not None:
            result['uuid'] = self.uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('action') is not None:
            self.action = m.get('action')
        if m.get('appKey') is not None:
            self.app_key = m.get('appKey')
        if m.get('baseDataName') is not None:
            self.base_data_name = m.get('baseDataName')
        if m.get('category') is not None:
            self.category = m.get('category')
        self.extend_data = []
        if m.get('extendData') is not None:
            for k in m.get('extendData'):
                temp_model = IndustryManufactureMesMaterialRequestExtendData()
                self.extend_data.append(temp_model.from_map(k))
        if m.get('productCode') is not None:
            self.product_code = m.get('productCode')
        if m.get('productName') is not None:
            self.product_name = m.get('productName')
        if m.get('productSpecification') is not None:
            self.product_specification = m.get('productSpecification')
        if m.get('prop') is not None:
            self.prop = m.get('prop')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        return self


class IndustryManufactureMesMaterialResponseBodyResult(TeaModel):
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


class IndustryManufactureMesMaterialResponseBody(TeaModel):
    def __init__(
        self,
        result: IndustryManufactureMesMaterialResponseBodyResult = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = IndustryManufactureMesMaterialResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class IndustryManufactureMesMaterialResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: IndustryManufactureMesMaterialResponseBody = None,
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
            temp_model = IndustryManufactureMesMaterialResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class IndustryManufactureMesOutPlanHeaders(TeaModel):
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


class IndustryManufactureMesOutPlanRequest(TeaModel):
    def __init__(
        self,
        approval_status: str = None,
        approver: str = None,
        base_data_name: str = None,
        out_source_project_code: str = None,
        out_source_team_id: str = None,
        price: str = None,
        process_identification_code: str = None,
        process_uuids: str = None,
        product_code: str = None,
        product_name: str = None,
        product_specification: str = None,
        project_code: str = None,
        project_id: str = None,
        send_plan_quantity: str = None,
        supplier_code: str = None,
        supplier_name: str = None,
        total_wage: str = None,
        uuid: str = None,
    ):
        # 审批状态
        self.approval_status = approval_status
        # 审批人
        self.approver = approver
        # 主数据名称
        self.base_data_name = base_data_name
        # 委外计划单号
        self.out_source_project_code = out_source_project_code
        # 委外群
        self.out_source_team_id = out_source_team_id
        # 单价（元）
        self.price = price
        # 工序识别码
        self.process_identification_code = process_identification_code
        # 委外的工序列表(多个)
        self.process_uuids = process_uuids
        # 产品代码(物料编号)
        self.product_code = product_code
        # 产品名称
        self.product_name = product_name
        # 规格型号
        self.product_specification = product_specification
        # 工单编号(生产任务单)
        self.project_code = project_code
        # 工单(生产计划单)ID
        self.project_id = project_id
        # 委外计划数
        self.send_plan_quantity = send_plan_quantity
        # 供应商代码
        self.supplier_code = supplier_code
        # 供应商名称
        self.supplier_name = supplier_name
        # 金额（元）
        self.total_wage = total_wage
        # 记录唯一标识
        self.uuid = uuid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.approval_status is not None:
            result['approvalStatus'] = self.approval_status
        if self.approver is not None:
            result['approver'] = self.approver
        if self.base_data_name is not None:
            result['baseDataName'] = self.base_data_name
        if self.out_source_project_code is not None:
            result['outSourceProjectCode'] = self.out_source_project_code
        if self.out_source_team_id is not None:
            result['outSourceTeamId'] = self.out_source_team_id
        if self.price is not None:
            result['price'] = self.price
        if self.process_identification_code is not None:
            result['processIdentificationCode'] = self.process_identification_code
        if self.process_uuids is not None:
            result['processUuids'] = self.process_uuids
        if self.product_code is not None:
            result['productCode'] = self.product_code
        if self.product_name is not None:
            result['productName'] = self.product_name
        if self.product_specification is not None:
            result['productSpecification'] = self.product_specification
        if self.project_code is not None:
            result['projectCode'] = self.project_code
        if self.project_id is not None:
            result['projectId'] = self.project_id
        if self.send_plan_quantity is not None:
            result['sendPlanQuantity'] = self.send_plan_quantity
        if self.supplier_code is not None:
            result['supplierCode'] = self.supplier_code
        if self.supplier_name is not None:
            result['supplierName'] = self.supplier_name
        if self.total_wage is not None:
            result['totalWage'] = self.total_wage
        if self.uuid is not None:
            result['uuid'] = self.uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('approvalStatus') is not None:
            self.approval_status = m.get('approvalStatus')
        if m.get('approver') is not None:
            self.approver = m.get('approver')
        if m.get('baseDataName') is not None:
            self.base_data_name = m.get('baseDataName')
        if m.get('outSourceProjectCode') is not None:
            self.out_source_project_code = m.get('outSourceProjectCode')
        if m.get('outSourceTeamId') is not None:
            self.out_source_team_id = m.get('outSourceTeamId')
        if m.get('price') is not None:
            self.price = m.get('price')
        if m.get('processIdentificationCode') is not None:
            self.process_identification_code = m.get('processIdentificationCode')
        if m.get('processUuids') is not None:
            self.process_uuids = m.get('processUuids')
        if m.get('productCode') is not None:
            self.product_code = m.get('productCode')
        if m.get('productName') is not None:
            self.product_name = m.get('productName')
        if m.get('productSpecification') is not None:
            self.product_specification = m.get('productSpecification')
        if m.get('projectCode') is not None:
            self.project_code = m.get('projectCode')
        if m.get('projectId') is not None:
            self.project_id = m.get('projectId')
        if m.get('sendPlanQuantity') is not None:
            self.send_plan_quantity = m.get('sendPlanQuantity')
        if m.get('supplierCode') is not None:
            self.supplier_code = m.get('supplierCode')
        if m.get('supplierName') is not None:
            self.supplier_name = m.get('supplierName')
        if m.get('totalWage') is not None:
            self.total_wage = m.get('totalWage')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        return self


class IndustryManufactureMesOutPlanResponseBodyResult(TeaModel):
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


class IndustryManufactureMesOutPlanResponseBody(TeaModel):
    def __init__(
        self,
        result: IndustryManufactureMesOutPlanResponseBodyResult = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = IndustryManufactureMesOutPlanResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class IndustryManufactureMesOutPlanResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: IndustryManufactureMesOutPlanResponseBody = None,
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
            temp_model = IndustryManufactureMesOutPlanResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class IndustryManufactureMesOutputHeaders(TeaModel):
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


class IndustryManufactureMesOutputRequest(TeaModel):
    def __init__(
        self,
        action: str = None,
        app_key: str = None,
        approve_status: str = None,
        base_data_name: str = None,
        defects_amount: str = None,
        defects_reason: str = None,
        fine_amount: str = None,
        has_quality_test: str = None,
        overdue: int = None,
        plan_quantity: int = None,
        priority: int = None,
        process_name: str = None,
        process_uuid: str = None,
        product_code: str = None,
        product_name: str = None,
        product_specification: str = None,
        project_code: str = None,
        project_id: str = None,
        project_status: str = None,
        quality_test_status: str = None,
        task_plan_end_time: str = None,
        task_plan_start_time: str = None,
        task_status: str = None,
        task_type: str = None,
        task_uuid: str = None,
        team_id: str = None,
        user_id: str = None,
        user_name: str = None,
        uuid: str = None,
    ):
        # 本次操作的行为
        self.action = action
        # 生态唯一标识, 需要注册
        self.app_key = app_key
        # 审批状态
        self.approve_status = approve_status
        # 主数据名称
        self.base_data_name = base_data_name
        # 不良品总数(多次报工)
        self.defects_amount = defects_amount
        # 不良品原因
        self.defects_reason = defects_reason
        # 良品总数(多次报工)
        self.fine_amount = fine_amount
        # 是否已质检
        self.has_quality_test = has_quality_test
        # 任务逾期
        self.overdue = overdue
        # 派工(总)数
        self.plan_quantity = plan_quantity
        # 是否加急
        self.priority = priority
        # 工序名称
        self.process_name = process_name
        # 工序业务唯一标识
        self.process_uuid = process_uuid
        # 产品编号(物料编号)
        self.product_code = product_code
        # 产品名称
        self.product_name = product_name
        # 产品(物料)规格
        self.product_specification = product_specification
        # 工单编号(生产任务单)
        self.project_code = project_code
        # 工单(生产计划单)
        self.project_id = project_id
        # 工单状态
        self.project_status = project_status
        # 检验状态
        self.quality_test_status = quality_test_status
        # 任务计划结束(完成)时间
        self.task_plan_end_time = task_plan_end_time
        # 任务计划开始时间
        self.task_plan_start_time = task_plan_start_time
        # 派工任务状态
        self.task_status = task_status
        # 报工类型(正常,委外)
        self.task_type = task_type
        # 派工任务唯一标识
        self.task_uuid = task_uuid
        # 负责班组id
        self.team_id = team_id
        # 报工人staffNo(生产人员)
        self.user_id = user_id
        # 派工人名称
        self.user_name = user_name
        # 本次记录唯一标识
        self.uuid = uuid

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
        if self.approve_status is not None:
            result['approveStatus'] = self.approve_status
        if self.base_data_name is not None:
            result['baseDataName'] = self.base_data_name
        if self.defects_amount is not None:
            result['defectsAmount'] = self.defects_amount
        if self.defects_reason is not None:
            result['defectsReason'] = self.defects_reason
        if self.fine_amount is not None:
            result['fineAmount'] = self.fine_amount
        if self.has_quality_test is not None:
            result['hasQualityTest'] = self.has_quality_test
        if self.overdue is not None:
            result['overdue'] = self.overdue
        if self.plan_quantity is not None:
            result['planQuantity'] = self.plan_quantity
        if self.priority is not None:
            result['priority'] = self.priority
        if self.process_name is not None:
            result['processName'] = self.process_name
        if self.process_uuid is not None:
            result['processUuid'] = self.process_uuid
        if self.product_code is not None:
            result['productCode'] = self.product_code
        if self.product_name is not None:
            result['productName'] = self.product_name
        if self.product_specification is not None:
            result['productSpecification'] = self.product_specification
        if self.project_code is not None:
            result['projectCode'] = self.project_code
        if self.project_id is not None:
            result['projectId'] = self.project_id
        if self.project_status is not None:
            result['projectStatus'] = self.project_status
        if self.quality_test_status is not None:
            result['qualityTestStatus'] = self.quality_test_status
        if self.task_plan_end_time is not None:
            result['taskPlanEndTime'] = self.task_plan_end_time
        if self.task_plan_start_time is not None:
            result['taskPlanStartTime'] = self.task_plan_start_time
        if self.task_status is not None:
            result['taskStatus'] = self.task_status
        if self.task_type is not None:
            result['taskType'] = self.task_type
        if self.task_uuid is not None:
            result['taskUuid'] = self.task_uuid
        if self.team_id is not None:
            result['teamId'] = self.team_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.user_name is not None:
            result['userName'] = self.user_name
        if self.uuid is not None:
            result['uuid'] = self.uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('action') is not None:
            self.action = m.get('action')
        if m.get('appKey') is not None:
            self.app_key = m.get('appKey')
        if m.get('approveStatus') is not None:
            self.approve_status = m.get('approveStatus')
        if m.get('baseDataName') is not None:
            self.base_data_name = m.get('baseDataName')
        if m.get('defectsAmount') is not None:
            self.defects_amount = m.get('defectsAmount')
        if m.get('defectsReason') is not None:
            self.defects_reason = m.get('defectsReason')
        if m.get('fineAmount') is not None:
            self.fine_amount = m.get('fineAmount')
        if m.get('hasQualityTest') is not None:
            self.has_quality_test = m.get('hasQualityTest')
        if m.get('overdue') is not None:
            self.overdue = m.get('overdue')
        if m.get('planQuantity') is not None:
            self.plan_quantity = m.get('planQuantity')
        if m.get('priority') is not None:
            self.priority = m.get('priority')
        if m.get('processName') is not None:
            self.process_name = m.get('processName')
        if m.get('processUuid') is not None:
            self.process_uuid = m.get('processUuid')
        if m.get('productCode') is not None:
            self.product_code = m.get('productCode')
        if m.get('productName') is not None:
            self.product_name = m.get('productName')
        if m.get('productSpecification') is not None:
            self.product_specification = m.get('productSpecification')
        if m.get('projectCode') is not None:
            self.project_code = m.get('projectCode')
        if m.get('projectId') is not None:
            self.project_id = m.get('projectId')
        if m.get('projectStatus') is not None:
            self.project_status = m.get('projectStatus')
        if m.get('qualityTestStatus') is not None:
            self.quality_test_status = m.get('qualityTestStatus')
        if m.get('taskPlanEndTime') is not None:
            self.task_plan_end_time = m.get('taskPlanEndTime')
        if m.get('taskPlanStartTime') is not None:
            self.task_plan_start_time = m.get('taskPlanStartTime')
        if m.get('taskStatus') is not None:
            self.task_status = m.get('taskStatus')
        if m.get('taskType') is not None:
            self.task_type = m.get('taskType')
        if m.get('taskUuid') is not None:
            self.task_uuid = m.get('taskUuid')
        if m.get('teamId') is not None:
            self.team_id = m.get('teamId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('userName') is not None:
            self.user_name = m.get('userName')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        return self


class IndustryManufactureMesOutputResponseBodyResult(TeaModel):
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


class IndustryManufactureMesOutputResponseBody(TeaModel):
    def __init__(
        self,
        result: IndustryManufactureMesOutputResponseBodyResult = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = IndustryManufactureMesOutputResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class IndustryManufactureMesOutputResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: IndustryManufactureMesOutputResponseBody = None,
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
            temp_model = IndustryManufactureMesOutputResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class IndustryManufactureMesProcessHeaders(TeaModel):
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


class IndustryManufactureMesProcessRequestExtendData(TeaModel):
    def __init__(
        self,
        code: str = None,
        name: str = None,
        value: str = None,
        value_type: str = None,
    ):
        # 扩展字段唯一标识(英文)
        self.code = code
        # 扩展字段中文描述
        self.name = name
        # 扩展字段实际取值
        self.value = value
        # 扩展字段类型,例如string
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


class IndustryManufactureMesProcessRequest(TeaModel):
    def __init__(
        self,
        action: str = None,
        app_key: str = None,
        base_data_name: str = None,
        extend_data: List[IndustryManufactureMesProcessRequestExtendData] = None,
        name: str = None,
        need_dispatch: str = None,
        need_quality_test: str = None,
        no: str = None,
        price: str = None,
        prop: str = None,
        remark: str = None,
        sop: str = None,
        uuid: str = None,
    ):
        # 本次操作的行为
        self.action = action
        # 生态唯一标识,枚举:opsoft， 需要注册
        self.app_key = app_key
        # 主数据名称
        self.base_data_name = base_data_name
        # 扩展字段
        self.extend_data = extend_data
        # 工序名称
        self.name = name
        # 是否必须派工
        self.need_dispatch = need_dispatch
        # 是否需要质检
        self.need_quality_test = need_quality_test
        # 工序代码
        self.no = no
        # 单价
        self.price = price
        # 工序属性(自制/委外)
        self.prop = prop
        # 备注
        self.remark = remark
        # 操作流程
        self.sop = sop
        # 工序唯一标识
        self.uuid = uuid

    def validate(self):
        if self.extend_data:
            for k in self.extend_data:
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
        result['extendData'] = []
        if self.extend_data is not None:
            for k in self.extend_data:
                result['extendData'].append(k.to_map() if k else None)
        if self.name is not None:
            result['name'] = self.name
        if self.need_dispatch is not None:
            result['needDispatch'] = self.need_dispatch
        if self.need_quality_test is not None:
            result['needQualityTest'] = self.need_quality_test
        if self.no is not None:
            result['no'] = self.no
        if self.price is not None:
            result['price'] = self.price
        if self.prop is not None:
            result['prop'] = self.prop
        if self.remark is not None:
            result['remark'] = self.remark
        if self.sop is not None:
            result['sop'] = self.sop
        if self.uuid is not None:
            result['uuid'] = self.uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('action') is not None:
            self.action = m.get('action')
        if m.get('appKey') is not None:
            self.app_key = m.get('appKey')
        if m.get('baseDataName') is not None:
            self.base_data_name = m.get('baseDataName')
        self.extend_data = []
        if m.get('extendData') is not None:
            for k in m.get('extendData'):
                temp_model = IndustryManufactureMesProcessRequestExtendData()
                self.extend_data.append(temp_model.from_map(k))
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('needDispatch') is not None:
            self.need_dispatch = m.get('needDispatch')
        if m.get('needQualityTest') is not None:
            self.need_quality_test = m.get('needQualityTest')
        if m.get('no') is not None:
            self.no = m.get('no')
        if m.get('price') is not None:
            self.price = m.get('price')
        if m.get('prop') is not None:
            self.prop = m.get('prop')
        if m.get('remark') is not None:
            self.remark = m.get('remark')
        if m.get('sop') is not None:
            self.sop = m.get('sop')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        return self


class IndustryManufactureMesProcessResponseBodyResult(TeaModel):
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


class IndustryManufactureMesProcessResponseBody(TeaModel):
    def __init__(
        self,
        result: IndustryManufactureMesProcessResponseBodyResult = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = IndustryManufactureMesProcessResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class IndustryManufactureMesProcessResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: IndustryManufactureMesProcessResponseBody = None,
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
            temp_model = IndustryManufactureMesProcessResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class IndustryManufactureMesProductionPlanHeaders(TeaModel):
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


class IndustryManufactureMesProductionPlanRequestExtendData(TeaModel):
    def __init__(
        self,
        code: str = None,
        name: str = None,
        value: str = None,
        value_type: str = None,
    ):
        # 字段唯一标识(英文)
        self.code = code
        # 字段中文描述
        self.name = name
        # 当时取值(活的)
        self.value = value
        # 字段类型
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


class IndustryManufactureMesProductionPlanRequest(TeaModel):
    def __init__(
        self,
        action: str = None,
        actual_end_time: str = None,
        actual_start_time: str = None,
        app_key: str = None,
        base_data_name: str = None,
        bom_uuid: str = None,
        events: List[str] = None,
        extend_data: List[IndustryManufactureMesProductionPlanRequestExtendData] = None,
        no: str = None,
        overdue: str = None,
        plan_end_time: str = None,
        plan_quantity: str = None,
        plan_start_time: str = None,
        process_uuids: str = None,
        product_code: str = None,
        product_name: str = None,
        product_specification: str = None,
        qualified_quantity: str = None,
        sell_order_no: str = None,
        status: str = None,
        team_list: str = None,
        title: str = None,
        type: str = None,
        unit: str = None,
        uuid: str = None,
    ):
        # 本次操作的行为
        self.action = action
        # actualEndTime
        self.actual_end_time = actual_end_time
        # actualStartTime
        self.actual_start_time = actual_start_time
        # 生态唯一标识,枚举:opsoft， 需要注册
        self.app_key = app_key
        # 主数据名称
        self.base_data_name = base_data_name
        # BOM业务唯一标识
        self.bom_uuid = bom_uuid
        # 事件列表
        self.events = events
        # 扩展字段
        self.extend_data = extend_data
        # 工单编号(生产订单号)
        self.no = no
        # 任务逾期
        self.overdue = overdue
        # 计划结束时间
        self.plan_end_time = plan_end_time
        # 工单计划数
        self.plan_quantity = plan_quantity
        # 计划开始时间
        self.plan_start_time = plan_start_time
        # 工序列表(有序) 主体
        self.process_uuids = process_uuids
        # 产品代码(物料编号)
        self.product_code = product_code
        # 产品名称
        self.product_name = product_name
        # 规格型号
        self.product_specification = product_specification
        # 最后一道工序完成数量
        self.qualified_quantity = qualified_quantity
        # 销售订单
        self.sell_order_no = sell_order_no
        # 工单状态
        self.status = status
        # 班组信息(有序)
        self.team_list = team_list
        # 工单标题
        self.title = title
        # 工单类型,["NORMAL"(普通),"返工","样品"],默认"NORMAL"
        self.type = type
        # 单位
        self.unit = unit
        # 工单实例的唯一Id
        self.uuid = uuid

    def validate(self):
        if self.extend_data:
            for k in self.extend_data:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action is not None:
            result['action'] = self.action
        if self.actual_end_time is not None:
            result['actualEndTime'] = self.actual_end_time
        if self.actual_start_time is not None:
            result['actualStartTime'] = self.actual_start_time
        if self.app_key is not None:
            result['appKey'] = self.app_key
        if self.base_data_name is not None:
            result['baseDataName'] = self.base_data_name
        if self.bom_uuid is not None:
            result['bomUuid'] = self.bom_uuid
        if self.events is not None:
            result['events'] = self.events
        result['extendData'] = []
        if self.extend_data is not None:
            for k in self.extend_data:
                result['extendData'].append(k.to_map() if k else None)
        if self.no is not None:
            result['no'] = self.no
        if self.overdue is not None:
            result['overdue'] = self.overdue
        if self.plan_end_time is not None:
            result['planEndTime'] = self.plan_end_time
        if self.plan_quantity is not None:
            result['planQuantity'] = self.plan_quantity
        if self.plan_start_time is not None:
            result['planStartTime'] = self.plan_start_time
        if self.process_uuids is not None:
            result['processUuids'] = self.process_uuids
        if self.product_code is not None:
            result['productCode'] = self.product_code
        if self.product_name is not None:
            result['productName'] = self.product_name
        if self.product_specification is not None:
            result['productSpecification'] = self.product_specification
        if self.qualified_quantity is not None:
            result['qualifiedQuantity'] = self.qualified_quantity
        if self.sell_order_no is not None:
            result['sellOrderNo'] = self.sell_order_no
        if self.status is not None:
            result['status'] = self.status
        if self.team_list is not None:
            result['teamList'] = self.team_list
        if self.title is not None:
            result['title'] = self.title
        if self.type is not None:
            result['type'] = self.type
        if self.unit is not None:
            result['unit'] = self.unit
        if self.uuid is not None:
            result['uuid'] = self.uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('action') is not None:
            self.action = m.get('action')
        if m.get('actualEndTime') is not None:
            self.actual_end_time = m.get('actualEndTime')
        if m.get('actualStartTime') is not None:
            self.actual_start_time = m.get('actualStartTime')
        if m.get('appKey') is not None:
            self.app_key = m.get('appKey')
        if m.get('baseDataName') is not None:
            self.base_data_name = m.get('baseDataName')
        if m.get('bomUuid') is not None:
            self.bom_uuid = m.get('bomUuid')
        if m.get('events') is not None:
            self.events = m.get('events')
        self.extend_data = []
        if m.get('extendData') is not None:
            for k in m.get('extendData'):
                temp_model = IndustryManufactureMesProductionPlanRequestExtendData()
                self.extend_data.append(temp_model.from_map(k))
        if m.get('no') is not None:
            self.no = m.get('no')
        if m.get('overdue') is not None:
            self.overdue = m.get('overdue')
        if m.get('planEndTime') is not None:
            self.plan_end_time = m.get('planEndTime')
        if m.get('planQuantity') is not None:
            self.plan_quantity = m.get('planQuantity')
        if m.get('planStartTime') is not None:
            self.plan_start_time = m.get('planStartTime')
        if m.get('processUuids') is not None:
            self.process_uuids = m.get('processUuids')
        if m.get('productCode') is not None:
            self.product_code = m.get('productCode')
        if m.get('productName') is not None:
            self.product_name = m.get('productName')
        if m.get('productSpecification') is not None:
            self.product_specification = m.get('productSpecification')
        if m.get('qualifiedQuantity') is not None:
            self.qualified_quantity = m.get('qualifiedQuantity')
        if m.get('sellOrderNo') is not None:
            self.sell_order_no = m.get('sellOrderNo')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('teamList') is not None:
            self.team_list = m.get('teamList')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        return self


class IndustryManufactureMesProductionPlanResponseBodyResult(TeaModel):
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


class IndustryManufactureMesProductionPlanResponseBody(TeaModel):
    def __init__(
        self,
        result: IndustryManufactureMesProductionPlanResponseBodyResult = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = IndustryManufactureMesProductionPlanResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class IndustryManufactureMesProductionPlanResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: IndustryManufactureMesProductionPlanResponseBody = None,
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
            temp_model = IndustryManufactureMesProductionPlanResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class IndustryManufactureMesSubCooperationTeamHeaders(TeaModel):
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


class IndustryManufactureMesSubCooperationTeamRequestExtendData(TeaModel):
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


class IndustryManufactureMesSubCooperationTeamRequestGroupPlugins(TeaModel):
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


class IndustryManufactureMesSubCooperationTeamRequestLeaders(TeaModel):
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


class IndustryManufactureMesSubCooperationTeamRequestMembers(TeaModel):
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


class IndustryManufactureMesSubCooperationTeamRequest(TeaModel):
    def __init__(
        self,
        action: str = None,
        app_key: str = None,
        base_data_name: str = None,
        events: List[str] = None,
        extend_data: List[IndustryManufactureMesSubCooperationTeamRequestExtendData] = None,
        group_plugins: List[IndustryManufactureMesSubCooperationTeamRequestGroupPlugins] = None,
        group_type: str = None,
        leaders: List[IndustryManufactureMesSubCooperationTeamRequestLeaders] = None,
        members: List[IndustryManufactureMesSubCooperationTeamRequestMembers] = None,
        name: str = None,
        out_corp_id: str = None,
        process_ids: List[str] = None,
        uuid: str = None,
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
        # 群插件列表
        self.group_plugins = group_plugins
        # 群类型，枚举
        self.group_type = group_type
        # 班组长(支持多个)
        self.leaders = leaders
        # 班组成员(群成员)
        self.members = members
        # 班组群名称
        self.name = name
        # 委外合作群所属组织
        self.out_corp_id = out_corp_id
        # 关联的工序
        self.process_ids = process_ids
        # 班组模型实例的唯一Id， 由业务方传递
        self.uuid = uuid

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
        result['groupPlugins'] = []
        if self.group_plugins is not None:
            for k in self.group_plugins:
                result['groupPlugins'].append(k.to_map() if k else None)
        if self.group_type is not None:
            result['groupType'] = self.group_type
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
        if self.out_corp_id is not None:
            result['outCorpId'] = self.out_corp_id
        if self.process_ids is not None:
            result['processIds'] = self.process_ids
        if self.uuid is not None:
            result['uuid'] = self.uuid
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
                temp_model = IndustryManufactureMesSubCooperationTeamRequestExtendData()
                self.extend_data.append(temp_model.from_map(k))
        self.group_plugins = []
        if m.get('groupPlugins') is not None:
            for k in m.get('groupPlugins'):
                temp_model = IndustryManufactureMesSubCooperationTeamRequestGroupPlugins()
                self.group_plugins.append(temp_model.from_map(k))
        if m.get('groupType') is not None:
            self.group_type = m.get('groupType')
        self.leaders = []
        if m.get('leaders') is not None:
            for k in m.get('leaders'):
                temp_model = IndustryManufactureMesSubCooperationTeamRequestLeaders()
                self.leaders.append(temp_model.from_map(k))
        self.members = []
        if m.get('members') is not None:
            for k in m.get('members'):
                temp_model = IndustryManufactureMesSubCooperationTeamRequestMembers()
                self.members.append(temp_model.from_map(k))
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('outCorpId') is not None:
            self.out_corp_id = m.get('outCorpId')
        if m.get('processIds') is not None:
            self.process_ids = m.get('processIds')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        return self


class IndustryManufactureMesSubCooperationTeamResponseBodyResult(TeaModel):
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


class IndustryManufactureMesSubCooperationTeamResponseBody(TeaModel):
    def __init__(
        self,
        result: IndustryManufactureMesSubCooperationTeamResponseBodyResult = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = IndustryManufactureMesSubCooperationTeamResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class IndustryManufactureMesSubCooperationTeamResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: IndustryManufactureMesSubCooperationTeamResponseBody = None,
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
            temp_model = IndustryManufactureMesSubCooperationTeamResponseBody()
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


class QueryDoctorDetailsByJobNumberHeaders(TeaModel):
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


class QueryDoctorDetailsByJobNumberRequest(TeaModel):
    def __init__(
        self,
        month_mark: str = None,
    ):
        # 按月安排
        self.month_mark = month_mark

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.month_mark is not None:
            result['monthMark'] = self.month_mark
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('monthMark') is not None:
            self.month_mark = m.get('monthMark')
        return self


class QueryDoctorDetailsByJobNumberResponseBodyContentDeptList(TeaModel):
    def __init__(
        self,
        category_name: str = None,
        dept_id: int = None,
        dept_name: str = None,
        gmt_create: str = None,
        gmt_modified: str = None,
        relation_id: int = None,
    ):
        # 科室大类名称
        self.category_name = category_name
        # 科室id
        self.dept_id = dept_id
        # 科室名称
        self.dept_name = dept_name
        # 创建时间
        self.gmt_create = gmt_create
        # 修改时间
        self.gmt_modified = gmt_modified
        # 人科关系关联id
        self.relation_id = relation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.category_name is not None:
            result['categoryName'] = self.category_name
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.relation_id is not None:
            result['relationId'] = self.relation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('categoryName') is not None:
            self.category_name = m.get('categoryName')
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('relationId') is not None:
            self.relation_id = m.get('relationId')
        return self


class QueryDoctorDetailsByJobNumberResponseBodyContentGroupList(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        dept_name: str = None,
        group_id: int = None,
        group_name: str = None,
        is_assess_group: str = None,
        is_leader: bool = None,
        relation_id: int = None,
    ):
        # 科室id
        self.dept_id = dept_id
        # 科室名称
        self.dept_name = dept_name
        # 医疗组id
        self.group_id = group_id
        # 医疗组名称
        self.group_name = group_name
        # 用户在该医疗组是否为考核医疗组
        self.is_assess_group = is_assess_group
        # 用户在该医疗组是否为组长
        self.is_leader = is_leader
        # 人组关系关联id
        self.relation_id = relation_id

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
        if self.group_id is not None:
            result['groupId'] = self.group_id
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.is_assess_group is not None:
            result['isAssessGroup'] = self.is_assess_group
        if self.is_leader is not None:
            result['isLeader'] = self.is_leader
        if self.relation_id is not None:
            result['relationId'] = self.relation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('groupId') is not None:
            self.group_id = m.get('groupId')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('isAssessGroup') is not None:
            self.is_assess_group = m.get('isAssessGroup')
        if m.get('isLeader') is not None:
            self.is_leader = m.get('isLeader')
        if m.get('relationId') is not None:
            self.relation_id = m.get('relationId')
        return self


class QueryDoctorDetailsByJobNumberResponseBodyContentJobStatus(TeaModel):
    def __init__(
        self,
        code: str = None,
        status_name: str = None,
    ):
        # 状态编码
        self.code = code
        # 状态名称
        self.status_name = status_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.status_name is not None:
            result['statusName'] = self.status_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('statusName') is not None:
            self.status_name = m.get('statusName')
        return self


class QueryDoctorDetailsByJobNumberResponseBodyContentProfessionalTitle(TeaModel):
    def __init__(
        self,
        code: str = None,
        professional_title_category: str = None,
        professional_title_detail: str = None,
    ):
        # 职称编码
        self.code = code
        # 职称大类
        self.professional_title_category = professional_title_category
        # 职称明细
        self.professional_title_detail = professional_title_detail

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.professional_title_category is not None:
            result['professionalTitleCategory'] = self.professional_title_category
        if self.professional_title_detail is not None:
            result['professionalTitleDetail'] = self.professional_title_detail
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('professionalTitleCategory') is not None:
            self.professional_title_category = m.get('professionalTitleCategory')
        if m.get('professionalTitleDetail') is not None:
            self.professional_title_detail = m.get('professionalTitleDetail')
        return self


class QueryDoctorDetailsByJobNumberResponseBodyContentUserProbList(TeaModel):
    def __init__(
        self,
        code: str = None,
        user_property_name: str = None,
    ):
        # 身份属性编码
        self.code = code
        # 身份属性名称
        self.user_property_name = user_property_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.user_property_name is not None:
            result['userPropertyName'] = self.user_property_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('userPropertyName') is not None:
            self.user_property_name = m.get('userPropertyName')
        return self


class QueryDoctorDetailsByJobNumberResponseBodyContent(TeaModel):
    def __init__(
        self,
        dept_list: List[QueryDoctorDetailsByJobNumberResponseBodyContentDeptList] = None,
        group_list: List[QueryDoctorDetailsByJobNumberResponseBodyContentGroupList] = None,
        job_number: str = None,
        job_status: List[QueryDoctorDetailsByJobNumberResponseBodyContentJobStatus] = None,
        professional_title: QueryDoctorDetailsByJobNumberResponseBodyContentProfessionalTitle = None,
        user_id: str = None,
        user_name: str = None,
        user_prob_list: List[QueryDoctorDetailsByJobNumberResponseBodyContentUserProbList] = None,
    ):
        # 科室列表
        self.dept_list = dept_list
        # 医疗组列表
        self.group_list = group_list
        # 工号
        self.job_number = job_number
        # 状态列表
        self.job_status = job_status
        # 职称
        self.professional_title = professional_title
        # 医生的userId
        self.user_id = user_id
        # 用户名称
        self.user_name = user_name
        # 身份属性
        self.user_prob_list = user_prob_list

    def validate(self):
        if self.dept_list:
            for k in self.dept_list:
                if k:
                    k.validate()
        if self.group_list:
            for k in self.group_list:
                if k:
                    k.validate()
        if self.job_status:
            for k in self.job_status:
                if k:
                    k.validate()
        if self.professional_title:
            self.professional_title.validate()
        if self.user_prob_list:
            for k in self.user_prob_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['deptList'] = []
        if self.dept_list is not None:
            for k in self.dept_list:
                result['deptList'].append(k.to_map() if k else None)
        result['groupList'] = []
        if self.group_list is not None:
            for k in self.group_list:
                result['groupList'].append(k.to_map() if k else None)
        if self.job_number is not None:
            result['jobNumber'] = self.job_number
        result['jobStatus'] = []
        if self.job_status is not None:
            for k in self.job_status:
                result['jobStatus'].append(k.to_map() if k else None)
        if self.professional_title is not None:
            result['professionalTitle'] = self.professional_title.to_map()
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.user_name is not None:
            result['userName'] = self.user_name
        result['userProbList'] = []
        if self.user_prob_list is not None:
            for k in self.user_prob_list:
                result['userProbList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.dept_list = []
        if m.get('deptList') is not None:
            for k in m.get('deptList'):
                temp_model = QueryDoctorDetailsByJobNumberResponseBodyContentDeptList()
                self.dept_list.append(temp_model.from_map(k))
        self.group_list = []
        if m.get('groupList') is not None:
            for k in m.get('groupList'):
                temp_model = QueryDoctorDetailsByJobNumberResponseBodyContentGroupList()
                self.group_list.append(temp_model.from_map(k))
        if m.get('jobNumber') is not None:
            self.job_number = m.get('jobNumber')
        self.job_status = []
        if m.get('jobStatus') is not None:
            for k in m.get('jobStatus'):
                temp_model = QueryDoctorDetailsByJobNumberResponseBodyContentJobStatus()
                self.job_status.append(temp_model.from_map(k))
        if m.get('professionalTitle') is not None:
            temp_model = QueryDoctorDetailsByJobNumberResponseBodyContentProfessionalTitle()
            self.professional_title = temp_model.from_map(m['professionalTitle'])
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('userName') is not None:
            self.user_name = m.get('userName')
        self.user_prob_list = []
        if m.get('userProbList') is not None:
            for k in m.get('userProbList'):
                temp_model = QueryDoctorDetailsByJobNumberResponseBodyContentUserProbList()
                self.user_prob_list.append(temp_model.from_map(k))
        return self


class QueryDoctorDetailsByJobNumberResponseBody(TeaModel):
    def __init__(
        self,
        content: QueryDoctorDetailsByJobNumberResponseBodyContent = None,
    ):
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
            temp_model = QueryDoctorDetailsByJobNumberResponseBodyContent()
            self.content = temp_model.from_map(m['content'])
        return self


class QueryDoctorDetailsByJobNumberResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryDoctorDetailsByJobNumberResponseBody = None,
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
            temp_model = QueryDoctorDetailsByJobNumberResponseBody()
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


class QueryUserInfoRequest(TeaModel):
    def __init__(
        self,
        month_mark: str = None,
    ):
        # 按月标记。不填默认当月。填0为次月。
        self.month_mark = month_mark

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.month_mark is not None:
            result['monthMark'] = self.month_mark
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('monthMark') is not None:
            self.month_mark = m.get('monthMark')
        return self


class QueryUserInfoResponseBodyContentDept(TeaModel):
    def __init__(
        self,
        gmt_create_str: str = None,
        gmt_modified_str: str = None,
        id: int = None,
        name: str = None,
        rel_id: int = None,
    ):
        # 创建时间
        self.gmt_create_str = gmt_create_str
        # 修改时间
        self.gmt_modified_str = gmt_modified_str
        # 科室Id
        self.id = id
        # 科室名称
        self.name = name
        # 人科关联id
        self.rel_id = rel_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.gmt_create_str is not None:
            result['gmtCreateStr'] = self.gmt_create_str
        if self.gmt_modified_str is not None:
            result['gmtModifiedStr'] = self.gmt_modified_str
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.rel_id is not None:
            result['relId'] = self.rel_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('gmtCreateStr') is not None:
            self.gmt_create_str = m.get('gmtCreateStr')
        if m.get('gmtModifiedStr') is not None:
            self.gmt_modified_str = m.get('gmtModifiedStr')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('relId') is not None:
            self.rel_id = m.get('relId')
        return self


class QueryUserInfoResponseBodyContentGroup(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        dept_name: str = None,
        gmt_create_str: str = None,
        gmt_modified_str: str = None,
        id: int = None,
        name: str = None,
        rel_id: int = None,
    ):
        # 医疗组所在科室Id
        self.dept_id = dept_id
        # 医疗组所在科室名称
        self.dept_name = dept_name
        self.gmt_create_str = gmt_create_str
        self.gmt_modified_str = gmt_modified_str
        # 医疗组Id
        self.id = id
        # 医疗组名称
        self.name = name
        self.rel_id = rel_id

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
        if self.gmt_create_str is not None:
            result['gmtCreateStr'] = self.gmt_create_str
        if self.gmt_modified_str is not None:
            result['gmtModifiedStr'] = self.gmt_modified_str
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        if self.rel_id is not None:
            result['relId'] = self.rel_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('gmtCreateStr') is not None:
            self.gmt_create_str = m.get('gmtCreateStr')
        if m.get('gmtModifiedStr') is not None:
            self.gmt_modified_str = m.get('gmtModifiedStr')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('relId') is not None:
            self.rel_id = m.get('relId')
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


