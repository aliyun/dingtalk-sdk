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
        self.extend = extend
        self.mobile = mobile
        self.name = name
        self.renter_id = renter_id
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
        status_code: int = None,
        body: CampusAddRenterMemberResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.address = address
        self.area = area
        self.belong_project_group_id = belong_project_group_id
        self.campus_name = campus_name
        self.capacity = capacity
        self.city_id = city_id
        self.country = country
        self.county_id = county_id
        self.creator_union_id = creator_union_id
        self.description = description
        self.extend = extend
        self.location = location
        self.order_end_time = order_end_time
        self.order_info = order_info
        self.order_start_time = order_start_time
        self.prov_id = prov_id
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
        self.campus_corp_id = campus_corp_id
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
        status_code: int = None,
        body: CampusCreateCampusResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.extend = extend
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
        status_code: int = None,
        body: CampusCreateCampusGroupResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.credit_code = credit_code
        self.end_time = end_time
        self.extend = extend
        self.name = name
        self.start_time = start_time
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
        status_code: int = None,
        body: CampusCreateRenterResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.renter_id = renter_id
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
        status_code: int = None,
        body: CampusDelRenterMemberResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        status_code: int = None,
        body: CampusDeleteCampusGroupResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        status_code: int = None,
    ):
        self.headers = headers
        self.status_code = status_code

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
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
        self.address = address
        self.area = area
        self.belong_project_group_id = belong_project_group_id
        self.campus_corp_id = campus_corp_id
        self.campus_dept_id = campus_dept_id
        self.campus_name = campus_name
        self.capacity = capacity
        self.city_id = city_id
        self.country = country
        self.county_id = county_id
        self.description = description
        self.extend = extend
        self.location = location
        self.order_end_time = order_end_time
        self.order_info = order_info
        self.order_start_time = order_start_time
        self.prov_id = prov_id
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
        status_code: int = None,
        body: CampusGetCampusResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.extend = extend
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
        status_code: int = None,
        body: CampusGetCampusGroupResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.bind_renter_corp_id = bind_renter_corp_id
        self.bind_time = bind_time
        self.credit_code = credit_code
        self.end_time = end_time
        self.extend = extend
        self.name = name
        self.renter_dept_id = renter_dept_id
        self.start_time = start_time
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
        status_code: int = None,
        body: CampusGetRenterResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.renter_id = renter_id
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
        status_code: int = None,
        body: CampusGetRenterMemberResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.address = address
        self.area = area
        self.belong_project_group_id = belong_project_group_id
        self.campus_corp_id = campus_corp_id
        self.campus_dept_id = campus_dept_id
        self.campus_name = campus_name
        self.city_id = city_id
        self.country = country
        self.county_id = county_id
        self.description = description
        self.extend = extend
        self.location = location
        self.order_end_time = order_end_time
        self.order_info = order_info
        self.order_start_time = order_start_time
        self.prov_id = prov_id
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
        status_code: int = None,
        body: CampusListCampusResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.extend = extend
        self.group_dept_id = group_dept_id
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
        status_code: int = None,
        body: CampusListCampusGroupResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.bind_renter_corp_id = bind_renter_corp_id
        self.bind_time = bind_time
        self.credit_code = credit_code
        self.end_time = end_time
        self.extend = extend
        self.name = name
        self.renter_dept_id = renter_dept_id
        self.start_time = start_time
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
        status_code: int = None,
        body: CampusListRenterResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        status_code: int = None,
        body: CampusListRenterMembersResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.address = address
        self.area = area
        self.belong_project_group_id = belong_project_group_id
        self.campus_dept_id = campus_dept_id
        self.campus_name = campus_name
        self.capacity = capacity
        self.city_id = city_id
        self.country = country
        self.county_id = county_id
        self.description = description
        self.extend = extend
        self.order_end_time = order_end_time
        self.order_info = order_info
        self.order_start_time = order_start_time
        self.prov_id = prov_id
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
        status_code: int = None,
        body: CampusUpdateCampusResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.extend = extend
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
        status_code: int = None,
        body: CampusUpdateCampusGroupResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.credit_code = credit_code
        self.end_time = end_time
        self.extend = extend
        self.name = name
        self.renter_id = renter_id
        self.start_time = start_time
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
        status_code: int = None,
        body: CampusUpdateRenterResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.extend = extend
        self.name = name
        self.renter_id = renter_id
        self.type = type
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
        status_code: int = None,
        body: CampusUpdateRenterMemberResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        status_code: int = None,
        body: CollegeActiveCollegeDeptGroupResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.dept_name = dept_name
        self.dept_type = dept_type
        self.sort_factor = sort_factor
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
        status_code: int = None,
        body: CollegeAddCollegeDeptResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.dept_id = dept_id
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
        status_code: int = None,
        body: CollegeAddManagerResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.dept_id = dept_id
        self.emp_extension = emp_extension
        self.gender = gender
        self.identify_id = identify_id
        self.mobile = mobile
        self.start_year = start_year
        self.student_name = student_name
        self.student_number = student_number
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
        self.ding_member_status = ding_member_status
        self.is_active = is_active
        self.student_id = student_id
        self.union_id = union_id
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
        status_code: int = None,
        body: CollegeAddStudentResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.dept_id = dept_id
        self.new_dept_id = new_dept_id
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
        status_code: int = None,
        body: CollegeChangeStudentDeptResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        status_code: int = None,
        body: CollegeDeleteCollegeDeptResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.dept_id = dept_id
        self.dept_name = dept_name
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
        status_code: int = None,
        body: CollegeListCollegeSubDeptResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.dept_id = dept_id
        self.page_number = page_number
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
        self.is_active = is_active
        self.name = name
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
        self.manager_info_simple_list = manager_info_simple_list
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
        status_code: int = None,
        body: CollegeListDeptManagerResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.dept_id = dept_id
        self.ding_student_status = ding_student_status
        self.page_number = page_number
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
        self.ding_member_status = ding_member_status
        self.is_active = is_active
        self.student_id = student_id
        self.student_name = student_name
        self.union_id = union_id
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
        self.student_info_simple_list = student_info_simple_list
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
        status_code: int = None,
        body: CollegeListStudentInfoResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.dept_id = dept_id
        self.page_number = page_number
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
        self.ding_member_status = ding_member_status
        self.is_active = is_active
        self.student_id = student_id
        self.student_name = student_name
        self.union_id = union_id
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
        self.student_info_simple_list = student_info_simple_list
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
        status_code: int = None,
        body: CollegeListUncheckedStudentResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.group_name = group_name
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
        status_code: int = None,
        body: CollegeQueryCollegeDeptGroupInfoResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.dept_id = dept_id
        self.dept_name = dept_name
        self.dept_type = dept_type
        self.sort_factor = sort_factor
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
        status_code: int = None,
        body: CollegeQueryCollegeDeptInfoResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.dept_id = dept_id
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
        self.dept_id = dept_id
        self.ding_member_status = ding_member_status
        self.emp_extension = emp_extension
        self.gender = gender
        self.identify_id = identify_id
        self.is_active = is_active
        self.start_year = start_year
        self.student_id = student_id
        self.student_name = student_name
        self.student_number = student_number
        self.union_id = union_id
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
        status_code: int = None,
        body: CollegeQueryStudentInfoByDeptResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.dept_id = dept_id
        self.member_type = member_type
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
        self.dept_student_info_list = dept_student_info_list
        self.ding_member_status = ding_member_status
        self.emp_extension = emp_extension
        self.gender = gender
        self.identify_id = identify_id
        self.is_active = is_active
        self.start_year = start_year
        self.student_id = student_id
        self.student_name = student_name
        self.union_id = union_id
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
        status_code: int = None,
        body: CollegeQueryStudentInfoByMobileResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.dept_id = dept_id
        self.member_type = member_type
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
        self.dept_student_info_list = dept_student_info_list
        self.ding_member_status = ding_member_status
        self.emp_extension = emp_extension
        self.gender = gender
        self.identify_id = identify_id
        self.is_active = is_active
        self.start_year = start_year
        self.student_id = student_id
        self.student_name = student_name
        self.union_id = union_id
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
        status_code: int = None,
        body: CollegeQueryStudentInfoByStudentIdResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.dept_id = dept_id
        self.is_force = is_force
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
        status_code: int = None,
        body: CollegeRemoveManagerResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.dept_id = dept_id
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
        status_code: int = None,
        body: CollegeRemoveStudentResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.dept_id = dept_id
        self.dept_name = dept_name
        self.sort_factor = sort_factor
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
        status_code: int = None,
        body: CollegeUpdateCollegeDeptResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.dept_id = dept_id
        self.student_id = student_id
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
        status_code: int = None,
        body: CollegeUpdateStudentDeptInfoResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.emp_extension = emp_extension
        self.gender = gender
        self.identify_id = identify_id
        self.start_year = start_year
        self.student_id = student_id
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
        status_code: int = None,
        body: CollegeUpdateStudentInfoResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.is_force = is_force
        self.new_mobile = new_mobile
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
        status_code: int = None,
        body: CollegeUpdateStudentMoblieResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.manager_id_list = manager_id_list
        self.name = name
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
        self.code = code
        self.name = name
        self.order = order
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
        status_code: int = None,
        body: CustomizeContactCreateResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        status_code: int = None,
        body: CustomizeContactDeleteResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.code = code
        self.manager_id_list = manager_id_list
        self.name = name
        self.order = order
        self.parent_dept_id = parent_dept_id
        self.ref_id = ref_id
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
        status_code: int = None,
        body: CustomizeContactDeptCreateResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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


class CustomizeContactDeptDeleteResponseBody(TeaModel):
    def __init__(
        self,
        content: bool = None,
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


class CustomizeContactDeptDeleteResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CustomizeContactDeptDeleteResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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


class CustomizeContactDeptGroupCreateResponseBody(TeaModel):
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


class CustomizeContactDeptGroupCreateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CustomizeContactDeptGroupCreateResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.code = code
        self.id = id
        self.manager_id_list = manager_id_list
        self.name = name
        self.order = order
        self.parent_dept_id = parent_dept_id
        self.ref_id = ref_id
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
        status_code: int = None,
        body: CustomizeContactDeptInfoResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.code = code
        self.id = id
        self.manager_id_list = manager_id_list
        self.name = name
        self.order = order
        self.parent_dept_id = parent_dept_id
        self.ref_id = ref_id
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
        status_code: int = None,
        body: CustomizeContactDeptListResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.code = code
        self.dept_id = dept_id
        self.manager_id_list = manager_id_list
        self.name = name
        self.order = order
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
        status_code: int = None,
        body: CustomizeContactDeptUpdateResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.code = code
        self.dept_id = dept_id
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
        status_code: int = None,
        body: CustomizeContactEmpAddResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.code = code
        self.dept_id = dept_id
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
        status_code: int = None,
        body: CustomizeContactEmpDeleteResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.name = name
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
        status_code: int = None,
        body: CustomizeContactEmpListResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.code = code
        self.name = name
        self.order = order
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
        status_code: int = None,
        body: CustomizeContactListResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.code = code
        self.manager_id_list = manager_id_list
        self.name = name
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
        status_code: int = None,
        body: CustomizeContactUpdateResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = CustomizeContactUpdateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DIgitalStoreMessagePushHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class DIgitalStoreMessagePushRequestMessageDataList(TeaModel):
    def __init__(
        self,
        callback_key: str = None,
        content: str = None,
        new_card: bool = None,
        out_trace_id: str = None,
        scene_card_code: str = None,
        scene_scope: int = None,
        send_now: bool = None,
    ):
        self.callback_key = callback_key
        self.content = content
        self.new_card = new_card
        self.out_trace_id = out_trace_id
        self.scene_card_code = scene_card_code
        self.scene_scope = scene_scope
        self.send_now = send_now

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.callback_key is not None:
            result['callbackKey'] = self.callback_key
        if self.content is not None:
            result['content'] = self.content
        if self.new_card is not None:
            result['newCard'] = self.new_card
        if self.out_trace_id is not None:
            result['outTraceId'] = self.out_trace_id
        if self.scene_card_code is not None:
            result['sceneCardCode'] = self.scene_card_code
        if self.scene_scope is not None:
            result['sceneScope'] = self.scene_scope
        if self.send_now is not None:
            result['sendNow'] = self.send_now
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('callbackKey') is not None:
            self.callback_key = m.get('callbackKey')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('newCard') is not None:
            self.new_card = m.get('newCard')
        if m.get('outTraceId') is not None:
            self.out_trace_id = m.get('outTraceId')
        if m.get('sceneCardCode') is not None:
            self.scene_card_code = m.get('sceneCardCode')
        if m.get('sceneScope') is not None:
            self.scene_scope = m.get('sceneScope')
        if m.get('sendNow') is not None:
            self.send_now = m.get('sendNow')
        return self


class DIgitalStoreMessagePushRequest(TeaModel):
    def __init__(
        self,
        message_data_list: List[DIgitalStoreMessagePushRequestMessageDataList] = None,
    ):
        self.message_data_list = message_data_list

    def validate(self):
        if self.message_data_list:
            for k in self.message_data_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['messageDataList'] = []
        if self.message_data_list is not None:
            for k in self.message_data_list:
                result['messageDataList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.message_data_list = []
        if m.get('messageDataList') is not None:
            for k in m.get('messageDataList'):
                temp_model = DIgitalStoreMessagePushRequestMessageDataList()
                self.message_data_list.append(temp_model.from_map(k))
        return self


class DIgitalStoreMessagePushShrinkRequest(TeaModel):
    def __init__(
        self,
        message_data_list_shrink: str = None,
    ):
        self.message_data_list_shrink = message_data_list_shrink

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.message_data_list_shrink is not None:
            result['messageDataList'] = self.message_data_list_shrink
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('messageDataList') is not None:
            self.message_data_list_shrink = m.get('messageDataList')
        return self


class DIgitalStoreMessagePushResponseBody(TeaModel):
    def __init__(
        self,
        content: bool = None,
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


class DIgitalStoreMessagePushResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DIgitalStoreMessagePushResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = DIgitalStoreMessagePushResponseBody()
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
        ding_dept_id: int = None,
        name: str = None,
        root_dept_id: int = None,
    ):
        self.code = code
        self.ding_dept_id = ding_dept_id
        self.name = name
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
        if self.ding_dept_id is not None:
            result['dingDeptId'] = self.ding_dept_id
        if self.name is not None:
            result['name'] = self.name
        if self.root_dept_id is not None:
            result['rootDeptId'] = self.root_dept_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('dingDeptId') is not None:
            self.ding_dept_id = m.get('dingDeptId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('rootDeptId') is not None:
            self.root_dept_id = m.get('rootDeptId')
        return self


class DigitalStoreContactInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DigitalStoreContactInfoResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = DigitalStoreContactInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DigitalStoreConversationsHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class DigitalStoreConversationsRequest(TeaModel):
    def __init__(
        self,
        conversation_title: str = None,
        conversation_type: str = None,
    ):
        self.conversation_title = conversation_title
        self.conversation_type = conversation_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conversation_title is not None:
            result['conversationTitle'] = self.conversation_title
        if self.conversation_type is not None:
            result['conversationType'] = self.conversation_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conversationTitle') is not None:
            self.conversation_title = m.get('conversationTitle')
        if m.get('conversationType') is not None:
            self.conversation_type = m.get('conversationType')
        return self


class DigitalStoreConversationsResponseBodyContent(TeaModel):
    def __init__(
        self,
        conversation_title: str = None,
        conversation_type: str = None,
        id: int = None,
    ):
        self.conversation_title = conversation_title
        self.conversation_type = conversation_type
        self.id = id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conversation_title is not None:
            result['conversationTitle'] = self.conversation_title
        if self.conversation_type is not None:
            result['conversationType'] = self.conversation_type
        if self.id is not None:
            result['id'] = self.id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conversationTitle') is not None:
            self.conversation_title = m.get('conversationTitle')
        if m.get('conversationType') is not None:
            self.conversation_type = m.get('conversationType')
        if m.get('id') is not None:
            self.id = m.get('id')
        return self


class DigitalStoreConversationsResponseBody(TeaModel):
    def __init__(
        self,
        content: List[DigitalStoreConversationsResponseBodyContent] = None,
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
                temp_model = DigitalStoreConversationsResponseBodyContent()
                self.content.append(temp_model.from_map(k))
        return self


class DigitalStoreConversationsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DigitalStoreConversationsResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = DigitalStoreConversationsResponseBody()
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
        self.group_id = group_id
        self.group_name = group_name
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
        status_code: int = None,
        body: DigitalStoreGroupInfoResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.group_id = group_id
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
        status_code: int = None,
        body: DigitalStoreGroupsResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.code = code
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
        ding_dept_id: int = None,
        id: int = None,
        name: str = None,
        parent_id: int = None,
        type: int = None,
    ):
        self.ding_dept_id = ding_dept_id
        self.id = id
        self.name = name
        self.parent_id = parent_id
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_dept_id is not None:
            result['dingDeptId'] = self.ding_dept_id
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
        if m.get('dingDeptId') is not None:
            self.ding_dept_id = m.get('dingDeptId')
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
        status_code: int = None,
        body: DigitalStoreNodeInfoResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.end_time = end_time
        self.quantity = quantity
        self.rights_code = rights_code
        self.rights_name = rights_name
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
        status_code: int = None,
        body: DigitalStoreRightsInfoResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        source: str = None,
    ):
        self.level = level
        self.role_code = role_code
        self.role_id = role_id
        self.role_name = role_name
        self.source = source

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
        if self.source is not None:
            result['source'] = self.source
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
        if m.get('source') is not None:
            self.source = m.get('source')
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
        status_code: int = None,
        body: DigitalStoreRolesResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = DigitalStoreRolesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DigitalStoreSceneScopeHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class DigitalStoreSceneScopeRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        scene_code: str = None,
    ):
        self.open_conversation_id = open_conversation_id
        self.scene_code = scene_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.scene_code is not None:
            result['sceneCode'] = self.scene_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('sceneCode') is not None:
            self.scene_code = m.get('sceneCode')
        return self


class DigitalStoreSceneScopeResponseBody(TeaModel):
    def __init__(
        self,
        group_conversation_type: str = None,
        scope_id: int = None,
    ):
        self.group_conversation_type = group_conversation_type
        self.scope_id = scope_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_conversation_type is not None:
            result['groupConversationType'] = self.group_conversation_type
        if self.scope_id is not None:
            result['scopeId'] = self.scope_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupConversationType') is not None:
            self.group_conversation_type = m.get('groupConversationType')
        if m.get('scopeId') is not None:
            self.scope_id = m.get('scopeId')
        return self


class DigitalStoreSceneScopeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DigitalStoreSceneScopeResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = DigitalStoreSceneScopeResponseBody()
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
        self.code = code
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
        ding_dept_id: int = None,
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
        self.address = address
        self.business_hours = business_hours
        self.ding_dept_id = ding_dept_id
        self.latitude = latitude
        self.location_address = location_address
        self.longitude = longitude
        self.name = name
        self.parent_id = parent_id
        self.status = status
        self.store_acreage = store_acreage
        self.store_bandwidth = store_bandwidth
        self.store_code = store_code
        self.store_id = store_id
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
        if self.ding_dept_id is not None:
            result['dingDeptId'] = self.ding_dept_id
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
        if m.get('dingDeptId') is not None:
            self.ding_dept_id = m.get('dingDeptId')
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
        status_code: int = None,
        body: DigitalStoreStoreInfoResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.code = code
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
        ding_dept_id: int = None,
        id: int = None,
        name: str = None,
        parent_id: int = None,
        type: int = None,
    ):
        self.ding_dept_id = ding_dept_id
        self.id = id
        self.name = name
        self.parent_id = parent_id
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_dept_id is not None:
            result['dingDeptId'] = self.ding_dept_id
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
        if m.get('dingDeptId') is not None:
            self.ding_dept_id = m.get('dingDeptId')
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
        status_code: int = None,
        body: DigitalStoreSubNodesResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = DigitalStoreSubNodesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DigitalStoreUpdateAuthInfoHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class DigitalStoreUpdateAuthInfoRequestUpdateUserListRoleList(TeaModel):
    def __init__(
        self,
        role_name: str = None,
        source_role_id: str = None,
    ):
        self.role_name = role_name
        self.source_role_id = source_role_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.role_name is not None:
            result['roleName'] = self.role_name
        if self.source_role_id is not None:
            result['sourceRoleId'] = self.source_role_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('roleName') is not None:
            self.role_name = m.get('roleName')
        if m.get('sourceRoleId') is not None:
            self.source_role_id = m.get('sourceRoleId')
        return self


class DigitalStoreUpdateAuthInfoRequestUpdateUserListUserAuthList(TeaModel):
    def __init__(
        self,
        ding_dept_id: str = None,
        source_dept_id: str = None,
    ):
        self.ding_dept_id = ding_dept_id
        self.source_dept_id = source_dept_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_dept_id is not None:
            result['dingDeptId'] = self.ding_dept_id
        if self.source_dept_id is not None:
            result['sourceDeptId'] = self.source_dept_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingDeptId') is not None:
            self.ding_dept_id = m.get('dingDeptId')
        if m.get('sourceDeptId') is not None:
            self.source_dept_id = m.get('sourceDeptId')
        return self


class DigitalStoreUpdateAuthInfoRequestUpdateUserList(TeaModel):
    def __init__(
        self,
        role_list: List[DigitalStoreUpdateAuthInfoRequestUpdateUserListRoleList] = None,
        user_auth_list: List[DigitalStoreUpdateAuthInfoRequestUpdateUserListUserAuthList] = None,
        user_id: str = None,
    ):
        self.role_list = role_list
        self.user_auth_list = user_auth_list
        self.user_id = user_id

    def validate(self):
        if self.role_list:
            for k in self.role_list:
                if k:
                    k.validate()
        if self.user_auth_list:
            for k in self.user_auth_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['roleList'] = []
        if self.role_list is not None:
            for k in self.role_list:
                result['roleList'].append(k.to_map() if k else None)
        result['userAuthList'] = []
        if self.user_auth_list is not None:
            for k in self.user_auth_list:
                result['userAuthList'].append(k.to_map() if k else None)
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.role_list = []
        if m.get('roleList') is not None:
            for k in m.get('roleList'):
                temp_model = DigitalStoreUpdateAuthInfoRequestUpdateUserListRoleList()
                self.role_list.append(temp_model.from_map(k))
        self.user_auth_list = []
        if m.get('userAuthList') is not None:
            for k in m.get('userAuthList'):
                temp_model = DigitalStoreUpdateAuthInfoRequestUpdateUserListUserAuthList()
                self.user_auth_list.append(temp_model.from_map(k))
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class DigitalStoreUpdateAuthInfoRequest(TeaModel):
    def __init__(
        self,
        update_user_list: List[DigitalStoreUpdateAuthInfoRequestUpdateUserList] = None,
    ):
        self.update_user_list = update_user_list

    def validate(self):
        if self.update_user_list:
            for k in self.update_user_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['updateUserList'] = []
        if self.update_user_list is not None:
            for k in self.update_user_list:
                result['updateUserList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.update_user_list = []
        if m.get('updateUserList') is not None:
            for k in m.get('updateUserList'):
                temp_model = DigitalStoreUpdateAuthInfoRequestUpdateUserList()
                self.update_user_list.append(temp_model.from_map(k))
        return self


class DigitalStoreUpdateAuthInfoResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
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


class DigitalStoreUpdateAuthInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DigitalStoreUpdateAuthInfoResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = DigitalStoreUpdateAuthInfoResponseBody()
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
        self.code = code
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
        role_id_list: List[int] = None,
        scope_list: List[int] = None,
        store_list: List[int] = None,
        user_id: str = None,
    ):
        self.name = name
        self.role_id_list = role_id_list
        self.scope_list = scope_list
        self.store_list = store_list
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
        if self.role_id_list is not None:
            result['roleIdList'] = self.role_id_list
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
        if m.get('roleIdList') is not None:
            self.role_id_list = m.get('roleIdList')
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
        status_code: int = None,
        body: DigitalStoreUserInfoResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.code = code
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
        self.name = name
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
        status_code: int = None,
        body: DigitalStoreUsersResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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


class ExternalQueryExternalAppOrgsResponseBody(TeaModel):
    def __init__(
        self,
        result: List[ExternalQueryExternalAppOrgsResponseBodyResult] = None,
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
                temp_model = ExternalQueryExternalAppOrgsResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class ExternalQueryExternalAppOrgsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ExternalQueryExternalAppOrgsResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        status_code: int = None,
        body: ExternalQueryExternalBelongMainOrgResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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


class ExternalQueryExternalOrgsResponseBody(TeaModel):
    def __init__(
        self,
        result: List[ExternalQueryExternalOrgsResponseBodyResult] = None,
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
                temp_model = ExternalQueryExternalOrgsResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class ExternalQueryExternalOrgsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ExternalQueryExternalOrgsResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.all_dept_count = all_dept_count
        self.all_dept_user_count = all_dept_user_count
        self.all_group_count = all_group_count
        self.all_group_user_count = all_group_user_count
        self.dept_count = dept_count
        self.dept_user_count = dept_user_count
        self.group_count = group_count
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
        self.all_dept_count = all_dept_count
        self.all_dept_user_count = all_dept_user_count
        self.all_group_count = all_group_count
        self.all_group_user_count = all_group_user_count
        self.dept_count = dept_count
        self.dept_user_count = dept_user_count
        self.group_count = group_count
        self.group_user_count = group_user_count
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
        status_code: int = None,
        body: HospitalDataCheckResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.action = action
        self.app_key = app_key
        self.biz_data = biz_data
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
        self.content = content
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
        status_code: int = None,
        body: IndustryManufactureCommonEventResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        status_code: int = None,
        body: IndustryManufactureCostRecordListGetResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        status_code: int = None,
        body: IndustryManufactureFeeListGetResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        status_code: int = None,
        body: IndustryManufactureLabourCostResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        status_code: int = None,
        body: IndustryManufactureMaterialListResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.action = action
        self.app_key = app_key
        self.base_data_name = base_data_name
        self.defects_amount = defects_amount
        self.dispatch_staff_name = dispatch_staff_name
        self.dispatch_staff_no = dispatch_staff_no
        self.fine_amount = fine_amount
        self.overdue = overdue
        self.plan_quantity = plan_quantity
        self.priority = priority
        self.process_name = process_name
        self.process_uuid = process_uuid
        self.product_code = product_code
        self.product_name = product_name
        self.product_specification = product_specification
        self.project_code = project_code
        self.project_id = project_id
        self.project_status = project_status
        self.task_operators = task_operators
        self.task_plan_end_time = task_plan_end_time
        self.task_plan_start_time = task_plan_start_time
        self.task_status = task_status
        self.task_type = task_type
        self.team_id = team_id
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
        status_code: int = None,
        body: IndustryManufactureMesDispatchTaskResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.code = code
        self.name = name
        self.value = value
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
        self.action = action
        self.app_key = app_key
        self.base_data_name = base_data_name
        self.category = category
        self.extend_data = extend_data
        self.product_code = product_code
        self.product_name = product_name
        self.product_specification = product_specification
        self.prop = prop
        self.unit = unit
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
        status_code: int = None,
        body: IndustryManufactureMesMaterialResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.approval_status = approval_status
        self.approver = approver
        self.base_data_name = base_data_name
        self.out_source_project_code = out_source_project_code
        self.out_source_team_id = out_source_team_id
        self.price = price
        self.process_identification_code = process_identification_code
        self.process_uuids = process_uuids
        self.product_code = product_code
        self.product_name = product_name
        self.product_specification = product_specification
        self.project_code = project_code
        self.project_id = project_id
        self.send_plan_quantity = send_plan_quantity
        self.supplier_code = supplier_code
        self.supplier_name = supplier_name
        self.total_wage = total_wage
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
        status_code: int = None,
        body: IndustryManufactureMesOutPlanResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.action = action
        self.app_key = app_key
        self.approve_status = approve_status
        self.base_data_name = base_data_name
        self.defects_amount = defects_amount
        self.defects_reason = defects_reason
        self.fine_amount = fine_amount
        self.has_quality_test = has_quality_test
        self.overdue = overdue
        self.plan_quantity = plan_quantity
        self.priority = priority
        self.process_name = process_name
        self.process_uuid = process_uuid
        self.product_code = product_code
        self.product_name = product_name
        self.product_specification = product_specification
        self.project_code = project_code
        self.project_id = project_id
        self.project_status = project_status
        self.quality_test_status = quality_test_status
        self.task_plan_end_time = task_plan_end_time
        self.task_plan_start_time = task_plan_start_time
        self.task_status = task_status
        self.task_type = task_type
        self.task_uuid = task_uuid
        self.team_id = team_id
        self.user_id = user_id
        self.user_name = user_name
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
        status_code: int = None,
        body: IndustryManufactureMesOutputResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.code = code
        self.name = name
        self.value = value
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
        self.action = action
        self.app_key = app_key
        self.base_data_name = base_data_name
        self.extend_data = extend_data
        self.name = name
        self.need_dispatch = need_dispatch
        self.need_quality_test = need_quality_test
        self.no = no
        self.price = price
        self.prop = prop
        self.remark = remark
        self.sop = sop
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
        status_code: int = None,
        body: IndustryManufactureMesProcessResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.code = code
        self.name = name
        self.value = value
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
        self.action = action
        self.actual_end_time = actual_end_time
        self.actual_start_time = actual_start_time
        self.app_key = app_key
        self.base_data_name = base_data_name
        self.bom_uuid = bom_uuid
        self.events = events
        self.extend_data = extend_data
        self.no = no
        self.overdue = overdue
        self.plan_end_time = plan_end_time
        self.plan_quantity = plan_quantity
        self.plan_start_time = plan_start_time
        self.process_uuids = process_uuids
        self.product_code = product_code
        self.product_name = product_name
        self.product_specification = product_specification
        self.qualified_quantity = qualified_quantity
        self.sell_order_no = sell_order_no
        self.status = status
        self.team_list = team_list
        self.title = title
        self.type = type
        self.unit = unit
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
        status_code: int = None,
        body: IndustryManufactureMesProductionPlanResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.code = code
        self.name = name
        self.value = value
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
        self.name = name
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
        self.name = name
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
        self.action = action
        self.app_key = app_key
        self.base_data_name = base_data_name
        self.events = events
        self.extend_data = extend_data
        self.group_plugins = group_plugins
        self.group_type = group_type
        self.leaders = leaders
        self.members = members
        self.name = name
        self.out_corp_id = out_corp_id
        self.process_ids = process_ids
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
        status_code: int = None,
        body: IndustryManufactureMesSubCooperationTeamResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.code = code
        self.name = name
        self.value = value
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
        self.name = name
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
        self.name = name
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
        self.action = action
        self.app_key = app_key
        self.base_data_name = base_data_name
        self.events = events
        self.extend_data = extend_data
        self.group_config = group_config
        self.group_plugins = group_plugins
        self.group_type = group_type
        self.id = id
        self.leaders = leaders
        self.members = members
        self.name = name
        self.process_ids = process_ids
        self.tag_key = tag_key
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
        status_code: int = None,
        body: IndustryManufactureMesTeamMgmtResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        status_code: int = None,
        body: IndustryMmanufactureMaterialCostGetResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.app_id = app_id
        self.content = content
        self.message_type = message_type
        self.message_url = message_url
        self.picture_url = picture_url
        self.single_title = single_title
        self.single_url = single_url
        self.title = title
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
        status_code: int = None,
        body: PushDingMessageResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.page_number = page_number
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
        self.dept_code = dept_code
        self.dept_name = dept_name
        self.dept_order = dept_order
        self.dept_status = dept_status
        self.dept_type = dept_type
        self.gmt_create_str = gmt_create_str
        self.gmt_modified_str = gmt_modified_str
        self.id = id
        self.name = name
        self.parent_dept_code = parent_dept_code
        self.remark = remark
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
        self.dept_code = dept_code
        self.dept_extend_display_name = dept_extend_display_name
        self.dept_extend_key = dept_extend_key
        self.dept_extend_value = dept_extend_value
        self.gmt_create_str = gmt_create_str
        self.gmt_modified_str = gmt_modified_str
        self.id = id
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
        self.department = department
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
        self.dept_code = dept_code
        self.dept_extend_display_name = dept_extend_display_name
        self.dept_extend_key = dept_extend_key
        self.dept_extend_value = dept_extend_value
        self.gmt_create_str = gmt_create_str
        self.gmt_modified_str = gmt_modified_str
        self.id = id
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
        self.job_number = job_number
        self.name = name
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
        self.dept_id = dept_id
        self.dept_status = dept_status
        self.gmt_create_str = gmt_create_str
        self.gmt_modified_str = gmt_modified_str
        self.id = id
        self.leader = leader
        self.name = name
        self.parent_dept_code = parent_dept_code
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
        self.extend_infos = extend_infos
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
        self.dept_and_ext = dept_and_ext
        self.group_and_ext_list = group_and_ext_list
        self.id = id
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
        self.content = content
        self.current_page = current_page
        self.total_count = total_count
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
        status_code: int = None,
        body: QueryAllDepartmentResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.page_num = page_num
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
        self.assess_group_id = assess_group_id
        self.assess_group_name = assess_group_name
        self.dept_code = dept_code
        self.dept_type = dept_type
        self.gmt_create_str = gmt_create_str
        self.gmt_modified_str = gmt_modified_str
        self.id = id
        self.job_num = job_num
        self.status = status
        self.uid = uid
        self.user_code = user_code
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
        self.content = content
        self.current_page = current_page
        self.total_count = total_count
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
        status_code: int = None,
        body: QueryAllDoctorsResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.page_number = page_number
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
        self.dept_id = dept_id
        self.id = id
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
        self.content = content
        self.current_page = current_page
        self.total_count = total_count
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
        status_code: int = None,
        body: QueryAllGroupResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.page_number = page_number
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
        self.dept_id = dept_id
        self.id = id
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
        self.content = content
        self.current_page = current_page
        self.total_count = total_count
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
        status_code: int = None,
        body: QueryAllGroupsInDeptResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.month_mark = month_mark
        self.page_number = page_number
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
        self.job_num = job_num
        self.uid = uid
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
        self.content = content
        self.current_page = current_page
        self.total_count = total_count
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
        status_code: int = None,
        body: QueryAllMemberByDeptResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.month_mark = month_mark
        self.page_number = page_number
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
        self.job_num = job_num
        self.uid = uid
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
        self.content = content
        self.current_page = current_page
        self.total_count = total_count
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
        status_code: int = None,
        body: QueryAllMemberByGroupResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.max_results = max_results
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
        self.biz_type = biz_type
        self.data_type = data_type
        self.id = id
        self.opt_after_data = opt_after_data
        self.opt_before_data = opt_before_data
        self.opt_biz_type = opt_biz_type
        self.opt_extend = opt_extend
        self.opt_job_number = opt_job_number
        self.opt_object_code = opt_object_code
        self.opt_object_name = opt_object_name
        self.opt_object_user_job_no = opt_object_user_job_no
        self.opt_success = opt_success
        self.opt_time = opt_time
        self.opt_type = opt_type
        self.opt_user_code = opt_user_code
        self.opt_user_name = opt_user_name
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
        self.content = content
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
        status_code: int = None,
        body: QueryBizOptLogResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.dept_code = dept_code
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
        self.dept_code = dept_code
        self.dept_extend_display_name = dept_extend_display_name
        self.dept_extend_key = dept_extend_key
        self.dept_extend_value = dept_extend_value
        self.gmt_create_str = gmt_create_str
        self.gmt_modified_str = gmt_modified_str
        self.id = id
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
        status_code: int = None,
        body: QueryDepartmentExtendInfoResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.dept_code = dept_code
        self.dept_name = dept_name
        self.dept_order = dept_order
        self.dept_status = dept_status
        self.dept_type = dept_type
        self.gmt_create_str = gmt_create_str
        self.gmt_modified_str = gmt_modified_str
        self.id = id
        self.name = name
        self.parent_dept_code = parent_dept_code
        self.remark = remark
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
        self.dept_code = dept_code
        self.dept_extend_display_name = dept_extend_display_name
        self.dept_extend_key = dept_extend_key
        self.dept_extend_value = dept_extend_value
        self.gmt_create_str = gmt_create_str
        self.gmt_modified_str = gmt_modified_str
        self.id = id
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
        self.department = department
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
        status_code: int = None,
        body: QueryDepartmentInfoResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.category_name = category_name
        self.dept_id = dept_id
        self.dept_name = dept_name
        self.gmt_create = gmt_create
        self.gmt_modified = gmt_modified
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
        self.dept_id = dept_id
        self.dept_name = dept_name
        self.group_id = group_id
        self.group_name = group_name
        self.is_assess_group = is_assess_group
        self.is_leader = is_leader
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
        self.code = code
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
        self.code = code
        self.professional_title_category = professional_title_category
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
        self.code = code
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
        self.dept_list = dept_list
        self.group_list = group_list
        self.job_number = job_number
        self.job_status = job_status
        self.professional_title = professional_title
        self.user_id = user_id
        self.user_name = user_name
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
        status_code: int = None,
        body: QueryDoctorDetailsByJobNumberResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.dept_code = dept_code
        self.dept_extend_display_name = dept_extend_display_name
        self.dept_extend_key = dept_extend_key
        self.dept_extend_value = dept_extend_value
        self.gmt_create_str = gmt_create_str
        self.gmt_modified_str = gmt_modified_str
        self.id = id
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
        self.job_number = job_number
        self.name = name
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
        self.dept_id = dept_id
        self.dept_status = dept_status
        self.gmt_create_str = gmt_create_str
        self.gmt_modified_str = gmt_modified_str
        self.id = id
        self.leader = leader
        self.name = name
        self.parent_dept_code = parent_dept_code
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
        self.extend_infos = extend_infos
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
        status_code: int = None,
        body: QueryGroupInfoResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.page_number = page_number
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
        self.address = address
        self.deleted = deleted
        self.district_name = district_name
        self.district_type = district_type
        self.gmt_create = gmt_create
        self.gmt_modified = gmt_modified
        self.id = id
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
        self.content = content
        self.current_page = current_page
        self.total_count = total_count
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
        status_code: int = None,
        body: QueryHospitalDistrictInfoResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.page_number = page_number
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
        self.gmt_create = gmt_create
        self.gmt_modified = gmt_modified
        self.job_number = job_number
        self.role_code = role_code
        self.role_name = role_name
        self.status = status
        self.user_code = user_code
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
        self.content = content
        self.current_page = current_page
        self.total_count = total_count
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
        status_code: int = None,
        body: QueryHospitalRoleUserInfoResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.gmt_create = gmt_create
        self.id = id
        self.is_deleted = is_deleted
        self.read_only = read_only
        self.remark = remark
        self.role_code = role_code
        self.role_name = role_name
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
        status_code: int = None,
        body: QueryHospitalRolesResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.category = category
        self.code = code
        self.display_name = display_name
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
        status_code: int = None,
        body: QueryJobCodeDictionaryResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.category = category
        self.code = code
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
        status_code: int = None,
        body: QueryJobStatusCodeDictionaryResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.code = code
        self.content = content
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
        self.content = content
        self.success = success
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
        status_code: int = None,
        body: QueryMedicalEventsResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.credential_name = credential_name
        self.credential_type = credential_type
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
        self.credential_list = credential_list
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
        status_code: int = None,
        body: QueryUserCredentialsResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.gmt_create = gmt_create
        self.gmt_modified = gmt_modified
        self.status = status
        self.user_code = user_code
        self.user_extend_display_name = user_extend_display_name
        self.user_extend_key = user_extend_key
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
        status_code: int = None,
        body: QueryUserExtInfoResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.user_extend_key = user_extend_key
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
        self.user_code = user_code
        self.user_extend_display_name = user_extend_display_name
        self.user_extend_key = user_extend_key
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
        self.content = content
        self.success = success
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
        status_code: int = None,
        body: QueryUserExtendValuesResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.gmt_create_str = gmt_create_str
        self.gmt_modified_str = gmt_modified_str
        self.id = id
        self.name = name
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
        self.dept_id = dept_id
        self.dept_name = dept_name
        self.gmt_create_str = gmt_create_str
        self.gmt_modified_str = gmt_modified_str
        self.id = id
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
        self.biz_type = biz_type
        self.category = category
        self.code = code
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
        self.biz_type = biz_type
        self.category = category
        self.code = code
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
        self.biz_type = biz_type
        self.category = category
        self.code = code
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
        self.biz_type = biz_type
        self.category = category
        self.code = code
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
        self.comments = comments
        self.dept = dept
        self.group = group
        self.job = job
        self.job_num = job_num
        self.job_status = job_status
        self.job_status_list = job_status_list
        self.uid = uid
        self.user_name = user_name
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
        status_code: int = None,
        body: QueryUserInfoResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.category = category
        self.code = code
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
        status_code: int = None,
        body: QueryUserProbCodeDictionaryResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.role_code = role_code
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
        status_code: int = None,
        body: QueryUserRolesResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
        self.user_display_name = user_display_name
        self.user_extend_key = user_extend_key
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
        status_code: int = None,
        body: SaveUserExtendValuesResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = SaveUserExtendValuesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SupplAddRoleHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class SupplAddRoleRequest(TeaModel):
    def __init__(
        self,
        parent_role_group_id: str = None,
        role_name: str = None,
    ):
        self.parent_role_group_id = parent_role_group_id
        self.role_name = role_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.parent_role_group_id is not None:
            result['parentRoleGroupId'] = self.parent_role_group_id
        if self.role_name is not None:
            result['roleName'] = self.role_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('parentRoleGroupId') is not None:
            self.parent_role_group_id = m.get('parentRoleGroupId')
        if m.get('roleName') is not None:
            self.role_name = m.get('roleName')
        return self


class SupplAddRoleResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
    ):
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


class SupplAddRoleResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SupplAddRoleResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = SupplAddRoleResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SupplyAddDeptHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class SupplyAddDeptRequest(TeaModel):
    def __init__(
        self,
        dept_name: str = None,
        partner_number: str = None,
        super_dept_id: int = None,
        supply_dept_type: str = None,
    ):
        self.dept_name = dept_name
        self.partner_number = partner_number
        self.super_dept_id = super_dept_id
        self.supply_dept_type = supply_dept_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.partner_number is not None:
            result['partnerNumber'] = self.partner_number
        if self.super_dept_id is not None:
            result['superDeptId'] = self.super_dept_id
        if self.supply_dept_type is not None:
            result['supplyDeptType'] = self.supply_dept_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('partnerNumber') is not None:
            self.partner_number = m.get('partnerNumber')
        if m.get('superDeptId') is not None:
            self.super_dept_id = m.get('superDeptId')
        if m.get('supplyDeptType') is not None:
            self.supply_dept_type = m.get('supplyDeptType')
        return self


class SupplyAddDeptResponseBodyResult(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
    ):
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


class SupplyAddDeptResponseBody(TeaModel):
    def __init__(
        self,
        result: SupplyAddDeptResponseBodyResult = None,
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
            temp_model = SupplyAddDeptResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class SupplyAddDeptResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SupplyAddDeptResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = SupplyAddDeptResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SupplyAddMemberHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class SupplyAddMemberRequest(TeaModel):
    def __init__(
        self,
        is_partner_manager: bool = None,
        member_mobile: str = None,
        member_name: str = None,
        member_title: str = None,
        member_work_number: str = None,
        supply_dept_id: int = None,
    ):
        self.is_partner_manager = is_partner_manager
        self.member_mobile = member_mobile
        self.member_name = member_name
        self.member_title = member_title
        self.member_work_number = member_work_number
        self.supply_dept_id = supply_dept_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.is_partner_manager is not None:
            result['isPartnerManager'] = self.is_partner_manager
        if self.member_mobile is not None:
            result['memberMobile'] = self.member_mobile
        if self.member_name is not None:
            result['memberName'] = self.member_name
        if self.member_title is not None:
            result['memberTitle'] = self.member_title
        if self.member_work_number is not None:
            result['memberWorkNumber'] = self.member_work_number
        if self.supply_dept_id is not None:
            result['supplyDeptId'] = self.supply_dept_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isPartnerManager') is not None:
            self.is_partner_manager = m.get('isPartnerManager')
        if m.get('memberMobile') is not None:
            self.member_mobile = m.get('memberMobile')
        if m.get('memberName') is not None:
            self.member_name = m.get('memberName')
        if m.get('memberTitle') is not None:
            self.member_title = m.get('memberTitle')
        if m.get('memberWorkNumber') is not None:
            self.member_work_number = m.get('memberWorkNumber')
        if m.get('supplyDeptId') is not None:
            self.supply_dept_id = m.get('supplyDeptId')
        return self


class SupplyAddMemberResponseBodyResult(TeaModel):
    def __init__(
        self,
        ding_member_status: str = None,
        union_id: str = None,
        user_id: str = None,
    ):
        self.ding_member_status = ding_member_status
        self.union_id = union_id
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
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingMemberStatus') is not None:
            self.ding_member_status = m.get('dingMemberStatus')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class SupplyAddMemberResponseBody(TeaModel):
    def __init__(
        self,
        result: SupplyAddMemberResponseBodyResult = None,
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
            temp_model = SupplyAddMemberResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class SupplyAddMemberResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SupplyAddMemberResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = SupplyAddMemberResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SupplyAddPartnerAdminsHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class SupplyAddPartnerAdminsRequest(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        user_id: str = None,
    ):
        self.dept_id = dept_id
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


class SupplyAddPartnerAdminsResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
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


class SupplyAddPartnerAdminsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SupplyAddPartnerAdminsResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = SupplyAddPartnerAdminsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SupplyAddPartnerManagersHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class SupplyAddPartnerManagersRequest(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        interface_id: str = None,
        interface_type: str = None,
    ):
        self.dept_id = dept_id
        self.interface_id = interface_id
        self.interface_type = interface_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.interface_id is not None:
            result['interfaceId'] = self.interface_id
        if self.interface_type is not None:
            result['interfaceType'] = self.interface_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('interfaceId') is not None:
            self.interface_id = m.get('interfaceId')
        if m.get('interfaceType') is not None:
            self.interface_type = m.get('interfaceType')
        return self


class SupplyAddPartnerManagersResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
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


class SupplyAddPartnerManagersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SupplyAddPartnerManagersResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = SupplyAddPartnerManagersResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SupplyAddPartnerTypeHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class SupplyAddPartnerTypeRequest(TeaModel):
    def __init__(
        self,
        name: str = None,
        super_id: int = None,
    ):
        self.name = name
        self.super_id = super_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.super_id is not None:
            result['superId'] = self.super_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('superId') is not None:
            self.super_id = m.get('superId')
        return self


class SupplyAddPartnerTypeResponseBody(TeaModel):
    def __init__(
        self,
        result: int = None,
    ):
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


class SupplyAddPartnerTypeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SupplyAddPartnerTypeResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = SupplyAddPartnerTypeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SupplyChainDeleteDeptHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class SupplyChainDeleteDeptRequest(TeaModel):
    def __init__(
        self,
        supply_dept_id: int = None,
    ):
        self.supply_dept_id = supply_dept_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.supply_dept_id is not None:
            result['supplyDeptId'] = self.supply_dept_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('supplyDeptId') is not None:
            self.supply_dept_id = m.get('supplyDeptId')
        return self


class SupplyChainDeleteDeptResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
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


class SupplyChainDeleteDeptResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SupplyChainDeleteDeptResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = SupplyChainDeleteDeptResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SupplyChainQueryDeptInfoHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class SupplyChainQueryDeptInfoRequest(TeaModel):
    def __init__(
        self,
        supply_dept_id: int = None,
    ):
        self.supply_dept_id = supply_dept_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.supply_dept_id is not None:
            result['supplyDeptId'] = self.supply_dept_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('supplyDeptId') is not None:
            self.supply_dept_id = m.get('supplyDeptId')
        return self


class SupplyChainQueryDeptInfoResponseBodyResultPartnerTypeInfoList(TeaModel):
    def __init__(
        self,
        id: int = None,
        name: str = None,
        super_id: int = None,
        super_name: str = None,
    ):
        self.id = id
        self.name = name
        self.super_id = super_id
        self.super_name = super_name

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
        if self.super_id is not None:
            result['superId'] = self.super_id
        if self.super_name is not None:
            result['superName'] = self.super_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('superId') is not None:
            self.super_id = m.get('superId')
        if m.get('superName') is not None:
            self.super_name = m.get('superName')
        return self


class SupplyChainQueryDeptInfoResponseBodyResult(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        dept_type: str = None,
        has_sub_dept: bool = None,
        name: str = None,
        partner_number: str = None,
        partner_type_info_list: List[SupplyChainQueryDeptInfoResponseBodyResultPartnerTypeInfoList] = None,
        super_id: int = None,
    ):
        self.dept_id = dept_id
        self.dept_type = dept_type
        self.has_sub_dept = has_sub_dept
        self.name = name
        self.partner_number = partner_number
        self.partner_type_info_list = partner_type_info_list
        self.super_id = super_id

    def validate(self):
        if self.partner_type_info_list:
            for k in self.partner_type_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.dept_type is not None:
            result['deptType'] = self.dept_type
        if self.has_sub_dept is not None:
            result['hasSubDept'] = self.has_sub_dept
        if self.name is not None:
            result['name'] = self.name
        if self.partner_number is not None:
            result['partnerNumber'] = self.partner_number
        result['partnerTypeInfoList'] = []
        if self.partner_type_info_list is not None:
            for k in self.partner_type_info_list:
                result['partnerTypeInfoList'].append(k.to_map() if k else None)
        if self.super_id is not None:
            result['superId'] = self.super_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('deptType') is not None:
            self.dept_type = m.get('deptType')
        if m.get('hasSubDept') is not None:
            self.has_sub_dept = m.get('hasSubDept')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('partnerNumber') is not None:
            self.partner_number = m.get('partnerNumber')
        self.partner_type_info_list = []
        if m.get('partnerTypeInfoList') is not None:
            for k in m.get('partnerTypeInfoList'):
                temp_model = SupplyChainQueryDeptInfoResponseBodyResultPartnerTypeInfoList()
                self.partner_type_info_list.append(temp_model.from_map(k))
        if m.get('superId') is not None:
            self.super_id = m.get('superId')
        return self


class SupplyChainQueryDeptInfoResponseBody(TeaModel):
    def __init__(
        self,
        result: SupplyChainQueryDeptInfoResponseBodyResult = None,
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
            temp_model = SupplyChainQueryDeptInfoResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class SupplyChainQueryDeptInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SupplyChainQueryDeptInfoResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = SupplyChainQueryDeptInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SupplyChainUpdateDeptInfoHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class SupplyChainUpdateDeptInfoRequest(TeaModel):
    def __init__(
        self,
        name: str = None,
        partner_number: str = None,
        partner_type_list: List[int] = None,
        super_id: int = None,
        supply_dept_id: int = None,
    ):
        self.name = name
        self.partner_number = partner_number
        self.partner_type_list = partner_type_list
        self.super_id = super_id
        self.supply_dept_id = supply_dept_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.partner_number is not None:
            result['partnerNumber'] = self.partner_number
        if self.partner_type_list is not None:
            result['partnerTypeList'] = self.partner_type_list
        if self.super_id is not None:
            result['superId'] = self.super_id
        if self.supply_dept_id is not None:
            result['supplyDeptId'] = self.supply_dept_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('partnerNumber') is not None:
            self.partner_number = m.get('partnerNumber')
        if m.get('partnerTypeList') is not None:
            self.partner_type_list = m.get('partnerTypeList')
        if m.get('superId') is not None:
            self.super_id = m.get('superId')
        if m.get('supplyDeptId') is not None:
            self.supply_dept_id = m.get('supplyDeptId')
        return self


class SupplyChainUpdateDeptInfoResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
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


class SupplyChainUpdateDeptInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SupplyChainUpdateDeptInfoResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = SupplyChainUpdateDeptInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SupplyDeleteMemberHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class SupplyDeleteMemberRequest(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        mobile: str = None,
        union_id: str = None,
        user_id: str = None,
    ):
        self.dept_id = dept_id
        self.mobile = mobile
        self.union_id = union_id
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
        if self.mobile is not None:
            result['mobile'] = self.mobile
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('mobile') is not None:
            self.mobile = m.get('mobile')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class SupplyDeleteMemberResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
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


class SupplyDeleteMemberResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SupplyDeleteMemberResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = SupplyDeleteMemberResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SupplyDeletePartnerAdminsHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class SupplyDeletePartnerAdminsRequest(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        user_id: str = None,
    ):
        self.dept_id = dept_id
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


class SupplyDeletePartnerAdminsResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
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


class SupplyDeletePartnerAdminsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SupplyDeletePartnerAdminsResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = SupplyDeletePartnerAdminsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SupplyDeletePartnerManagersHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class SupplyDeletePartnerManagersRequest(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        interface_id: str = None,
        interface_type: str = None,
    ):
        self.dept_id = dept_id
        self.interface_id = interface_id
        self.interface_type = interface_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.interface_id is not None:
            result['interfaceId'] = self.interface_id
        if self.interface_type is not None:
            result['interfaceType'] = self.interface_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('interfaceId') is not None:
            self.interface_id = m.get('interfaceId')
        if m.get('interfaceType') is not None:
            self.interface_type = m.get('interfaceType')
        return self


class SupplyDeletePartnerManagersResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
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


class SupplyDeletePartnerManagersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SupplyDeletePartnerManagersResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = SupplyDeletePartnerManagersResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SupplyDeletePartnerTypeHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class SupplyDeletePartnerTypeRequest(TeaModel):
    def __init__(
        self,
        label_id: int = None,
    ):
        self.label_id = label_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.label_id is not None:
            result['labelId'] = self.label_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('labelId') is not None:
            self.label_id = m.get('labelId')
        return self


class SupplyDeletePartnerTypeResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
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


class SupplyDeletePartnerTypeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SupplyDeletePartnerTypeResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = SupplyDeletePartnerTypeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SupplyDeleteRoleHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class SupplyDeleteRoleRequest(TeaModel):
    def __init__(
        self,
        is_role_group: bool = None,
        role_id: str = None,
    ):
        self.is_role_group = is_role_group
        self.role_id = role_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.is_role_group is not None:
            result['isRoleGroup'] = self.is_role_group
        if self.role_id is not None:
            result['roleId'] = self.role_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isRoleGroup') is not None:
            self.is_role_group = m.get('isRoleGroup')
        if m.get('roleId') is not None:
            self.role_id = m.get('roleId')
        return self


class SupplyDeleteRoleResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
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


class SupplyDeleteRoleResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SupplyDeleteRoleResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = SupplyDeleteRoleResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SupplyGetMemberHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class SupplyGetMemberRequest(TeaModel):
    def __init__(
        self,
        mobile: str = None,
        union_id: str = None,
        user_id: str = None,
    ):
        self.mobile = mobile
        self.union_id = union_id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.mobile is not None:
            result['mobile'] = self.mobile
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('mobile') is not None:
            self.mobile = m.get('mobile')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class SupplyGetMemberResponseBodyResultRoleInfoList(TeaModel):
    def __init__(
        self,
        role_id: str = None,
        role_name: str = None,
    ):
        self.role_id = role_id
        self.role_name = role_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.role_id is not None:
            result['roleId'] = self.role_id
        if self.role_name is not None:
            result['roleName'] = self.role_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('roleId') is not None:
            self.role_id = m.get('roleId')
        if m.get('roleName') is not None:
            self.role_name = m.get('roleName')
        return self


class SupplyGetMemberResponseBodyResult(TeaModel):
    def __init__(
        self,
        dept_id_list: List[int] = None,
        ding_member_status: str = None,
        is_active: bool = None,
        member_name: str = None,
        member_title: str = None,
        member_work_number: str = None,
        role_info_list: List[SupplyGetMemberResponseBodyResultRoleInfoList] = None,
        supply_node_list: List[int] = None,
    ):
        self.dept_id_list = dept_id_list
        self.ding_member_status = ding_member_status
        self.is_active = is_active
        self.member_name = member_name
        self.member_title = member_title
        self.member_work_number = member_work_number
        self.role_info_list = role_info_list
        self.supply_node_list = supply_node_list

    def validate(self):
        if self.role_info_list:
            for k in self.role_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id_list is not None:
            result['deptIdList'] = self.dept_id_list
        if self.ding_member_status is not None:
            result['dingMemberStatus'] = self.ding_member_status
        if self.is_active is not None:
            result['isActive'] = self.is_active
        if self.member_name is not None:
            result['memberName'] = self.member_name
        if self.member_title is not None:
            result['memberTitle'] = self.member_title
        if self.member_work_number is not None:
            result['memberWorkNumber'] = self.member_work_number
        result['roleInfoList'] = []
        if self.role_info_list is not None:
            for k in self.role_info_list:
                result['roleInfoList'].append(k.to_map() if k else None)
        if self.supply_node_list is not None:
            result['supplyNodeList'] = self.supply_node_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptIdList') is not None:
            self.dept_id_list = m.get('deptIdList')
        if m.get('dingMemberStatus') is not None:
            self.ding_member_status = m.get('dingMemberStatus')
        if m.get('isActive') is not None:
            self.is_active = m.get('isActive')
        if m.get('memberName') is not None:
            self.member_name = m.get('memberName')
        if m.get('memberTitle') is not None:
            self.member_title = m.get('memberTitle')
        if m.get('memberWorkNumber') is not None:
            self.member_work_number = m.get('memberWorkNumber')
        self.role_info_list = []
        if m.get('roleInfoList') is not None:
            for k in m.get('roleInfoList'):
                temp_model = SupplyGetMemberResponseBodyResultRoleInfoList()
                self.role_info_list.append(temp_model.from_map(k))
        if m.get('supplyNodeList') is not None:
            self.supply_node_list = m.get('supplyNodeList')
        return self


class SupplyGetMemberResponseBody(TeaModel):
    def __init__(
        self,
        result: SupplyGetMemberResponseBodyResult = None,
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
            temp_model = SupplyGetMemberResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class SupplyGetMemberResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SupplyGetMemberResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = SupplyGetMemberResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SupplyListDeptMembersHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class SupplyListDeptMembersRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        supply_dept_id: int = None,
    ):
        self.page_number = page_number
        self.page_size = page_size
        self.supply_dept_id = supply_dept_id

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
        if self.supply_dept_id is not None:
            result['supplyDeptId'] = self.supply_dept_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('supplyDeptId') is not None:
            self.supply_dept_id = m.get('supplyDeptId')
        return self


class SupplyListDeptMembersResponseBodyList(TeaModel):
    def __init__(
        self,
        ding_member_status: str = None,
        is_active: bool = None,
        member_name: str = None,
        member_title: str = None,
        member_work_number: str = None,
        union_id: str = None,
        user_id: str = None,
    ):
        self.ding_member_status = ding_member_status
        self.is_active = is_active
        self.member_name = member_name
        self.member_title = member_title
        self.member_work_number = member_work_number
        self.union_id = union_id
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
        if self.member_name is not None:
            result['memberName'] = self.member_name
        if self.member_title is not None:
            result['memberTitle'] = self.member_title
        if self.member_work_number is not None:
            result['memberWorkNumber'] = self.member_work_number
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
        if m.get('memberName') is not None:
            self.member_name = m.get('memberName')
        if m.get('memberTitle') is not None:
            self.member_title = m.get('memberTitle')
        if m.get('memberWorkNumber') is not None:
            self.member_work_number = m.get('memberWorkNumber')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class SupplyListDeptMembersResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[SupplyListDeptMembersResponseBodyList] = None,
    ):
        self.has_more = has_more
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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = SupplyListDeptMembersResponseBodyList()
                self.list.append(temp_model.from_map(k))
        return self


class SupplyListDeptMembersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SupplyListDeptMembersResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = SupplyListDeptMembersResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SupplyListPartnerAdminsHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class SupplyListPartnerAdminsRequest(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
    ):
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


class SupplyListPartnerAdminsResponseBodyResult(TeaModel):
    def __init__(
        self,
        name: str = None,
        union_id: str = None,
        user_id: str = None,
    ):
        self.name = name
        self.union_id = union_id
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
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class SupplyListPartnerAdminsResponseBody(TeaModel):
    def __init__(
        self,
        result: List[SupplyListPartnerAdminsResponseBodyResult] = None,
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
                temp_model = SupplyListPartnerAdminsResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class SupplyListPartnerAdminsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SupplyListPartnerAdminsResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = SupplyListPartnerAdminsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SupplyListPartnerManagersHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class SupplyListPartnerManagersRequest(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
    ):
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


class SupplyListPartnerManagersResponseBodyResult(TeaModel):
    def __init__(
        self,
        dept_id: str = None,
        dept_name: str = None,
        interface_type: str = None,
        user_id: str = None,
        user_name: str = None,
    ):
        self.dept_id = dept_id
        self.dept_name = dept_name
        self.interface_type = interface_type
        self.user_id = user_id
        self.user_name = user_name

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
        if self.interface_type is not None:
            result['interfaceType'] = self.interface_type
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.user_name is not None:
            result['userName'] = self.user_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('interfaceType') is not None:
            self.interface_type = m.get('interfaceType')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('userName') is not None:
            self.user_name = m.get('userName')
        return self


class SupplyListPartnerManagersResponseBody(TeaModel):
    def __init__(
        self,
        result: List[SupplyListPartnerManagersResponseBodyResult] = None,
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
                temp_model = SupplyListPartnerManagersResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class SupplyListPartnerManagersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SupplyListPartnerManagersResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = SupplyListPartnerManagersResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SupplyListPartnerTypeHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class SupplyListPartnerTypeRequest(TeaModel):
    def __init__(
        self,
        label_id: int = None,
    ):
        self.label_id = label_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.label_id is not None:
            result['labelId'] = self.label_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('labelId') is not None:
            self.label_id = m.get('labelId')
        return self


class SupplyListPartnerTypeResponseBodyResult(TeaModel):
    def __init__(
        self,
        label_id: int = None,
        name: str = None,
        super_id: int = None,
    ):
        self.label_id = label_id
        self.name = name
        self.super_id = super_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.label_id is not None:
            result['labelId'] = self.label_id
        if self.name is not None:
            result['name'] = self.name
        if self.super_id is not None:
            result['superId'] = self.super_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('labelId') is not None:
            self.label_id = m.get('labelId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('superId') is not None:
            self.super_id = m.get('superId')
        return self


class SupplyListPartnerTypeResponseBody(TeaModel):
    def __init__(
        self,
        result: List[SupplyListPartnerTypeResponseBodyResult] = None,
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
                temp_model = SupplyListPartnerTypeResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class SupplyListPartnerTypeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SupplyListPartnerTypeResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = SupplyListPartnerTypeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SupplyListRoleHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class SupplyListRoleRequest(TeaModel):
    def __init__(
        self,
        parent_role_id: str = None,
    ):
        self.parent_role_id = parent_role_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.parent_role_id is not None:
            result['parentRoleId'] = self.parent_role_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('parentRoleId') is not None:
            self.parent_role_id = m.get('parentRoleId')
        return self


class SupplyListRoleResponseBodyResult(TeaModel):
    def __init__(
        self,
        is_role_group: bool = None,
        role_id: str = None,
        role_name: str = None,
    ):
        self.is_role_group = is_role_group
        self.role_id = role_id
        self.role_name = role_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.is_role_group is not None:
            result['isRoleGroup'] = self.is_role_group
        if self.role_id is not None:
            result['roleId'] = self.role_id
        if self.role_name is not None:
            result['roleName'] = self.role_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isRoleGroup') is not None:
            self.is_role_group = m.get('isRoleGroup')
        if m.get('roleId') is not None:
            self.role_id = m.get('roleId')
        if m.get('roleName') is not None:
            self.role_name = m.get('roleName')
        return self


class SupplyListRoleResponseBody(TeaModel):
    def __init__(
        self,
        result: List[SupplyListRoleResponseBodyResult] = None,
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
                temp_model = SupplyListRoleResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class SupplyListRoleResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SupplyListRoleResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = SupplyListRoleResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SupplyListSubDeptHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class SupplyListSubDeptRequest(TeaModel):
    def __init__(
        self,
        supply_dept_id: int = None,
    ):
        self.supply_dept_id = supply_dept_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.supply_dept_id is not None:
            result['supplyDeptId'] = self.supply_dept_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('supplyDeptId') is not None:
            self.supply_dept_id = m.get('supplyDeptId')
        return self


class SupplyListSubDeptResponseBodyResultPartnerTypeInfoList(TeaModel):
    def __init__(
        self,
        id: int = None,
        name: str = None,
        super_id: int = None,
        super_name: str = None,
    ):
        self.id = id
        self.name = name
        self.super_id = super_id
        self.super_name = super_name

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
        if self.super_id is not None:
            result['superId'] = self.super_id
        if self.super_name is not None:
            result['superName'] = self.super_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('superId') is not None:
            self.super_id = m.get('superId')
        if m.get('superName') is not None:
            self.super_name = m.get('superName')
        return self


class SupplyListSubDeptResponseBodyResult(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        dept_type: str = None,
        has_sub_dept: bool = None,
        name: str = None,
        partner_number: str = None,
        partner_type_info_list: List[SupplyListSubDeptResponseBodyResultPartnerTypeInfoList] = None,
        super_id: int = None,
    ):
        self.dept_id = dept_id
        self.dept_type = dept_type
        self.has_sub_dept = has_sub_dept
        self.name = name
        self.partner_number = partner_number
        self.partner_type_info_list = partner_type_info_list
        self.super_id = super_id

    def validate(self):
        if self.partner_type_info_list:
            for k in self.partner_type_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.dept_type is not None:
            result['deptType'] = self.dept_type
        if self.has_sub_dept is not None:
            result['hasSubDept'] = self.has_sub_dept
        if self.name is not None:
            result['name'] = self.name
        if self.partner_number is not None:
            result['partnerNumber'] = self.partner_number
        result['partnerTypeInfoList'] = []
        if self.partner_type_info_list is not None:
            for k in self.partner_type_info_list:
                result['partnerTypeInfoList'].append(k.to_map() if k else None)
        if self.super_id is not None:
            result['superId'] = self.super_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('deptType') is not None:
            self.dept_type = m.get('deptType')
        if m.get('hasSubDept') is not None:
            self.has_sub_dept = m.get('hasSubDept')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('partnerNumber') is not None:
            self.partner_number = m.get('partnerNumber')
        self.partner_type_info_list = []
        if m.get('partnerTypeInfoList') is not None:
            for k in m.get('partnerTypeInfoList'):
                temp_model = SupplyListSubDeptResponseBodyResultPartnerTypeInfoList()
                self.partner_type_info_list.append(temp_model.from_map(k))
        if m.get('superId') is not None:
            self.super_id = m.get('superId')
        return self


class SupplyListSubDeptResponseBody(TeaModel):
    def __init__(
        self,
        result: List[SupplyListSubDeptResponseBodyResult] = None,
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
                temp_model = SupplyListSubDeptResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class SupplyListSubDeptResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SupplyListSubDeptResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = SupplyListSubDeptResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SupplyQueryPartnerTypeHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class SupplyQueryPartnerTypeRequest(TeaModel):
    def __init__(
        self,
        label_id: int = None,
    ):
        self.label_id = label_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.label_id is not None:
            result['labelId'] = self.label_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('labelId') is not None:
            self.label_id = m.get('labelId')
        return self


class SupplyQueryPartnerTypeResponseBodyResult(TeaModel):
    def __init__(
        self,
        label_id: int = None,
        name: str = None,
        super_id: int = None,
    ):
        self.label_id = label_id
        self.name = name
        self.super_id = super_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.label_id is not None:
            result['labelId'] = self.label_id
        if self.name is not None:
            result['name'] = self.name
        if self.super_id is not None:
            result['superId'] = self.super_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('labelId') is not None:
            self.label_id = m.get('labelId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('superId') is not None:
            self.super_id = m.get('superId')
        return self


class SupplyQueryPartnerTypeResponseBody(TeaModel):
    def __init__(
        self,
        result: SupplyQueryPartnerTypeResponseBodyResult = None,
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
            temp_model = SupplyQueryPartnerTypeResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class SupplyQueryPartnerTypeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SupplyQueryPartnerTypeResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = SupplyQueryPartnerTypeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SupplyUpdateMemberHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class SupplyUpdateMemberRequest(TeaModel):
    def __init__(
        self,
        is_copy_dept: bool = None,
        member_title: str = None,
        member_work_number: str = None,
        mobile: str = None,
        new_dept_id: int = None,
        old_dept_id: int = None,
        role_id_list: List[str] = None,
        union_id: str = None,
        user_id: str = None,
    ):
        self.is_copy_dept = is_copy_dept
        self.member_title = member_title
        self.member_work_number = member_work_number
        self.mobile = mobile
        self.new_dept_id = new_dept_id
        self.old_dept_id = old_dept_id
        self.role_id_list = role_id_list
        self.union_id = union_id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.is_copy_dept is not None:
            result['isCopyDept'] = self.is_copy_dept
        if self.member_title is not None:
            result['memberTitle'] = self.member_title
        if self.member_work_number is not None:
            result['memberWorkNumber'] = self.member_work_number
        if self.mobile is not None:
            result['mobile'] = self.mobile
        if self.new_dept_id is not None:
            result['newDeptId'] = self.new_dept_id
        if self.old_dept_id is not None:
            result['oldDeptId'] = self.old_dept_id
        if self.role_id_list is not None:
            result['roleIdList'] = self.role_id_list
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isCopyDept') is not None:
            self.is_copy_dept = m.get('isCopyDept')
        if m.get('memberTitle') is not None:
            self.member_title = m.get('memberTitle')
        if m.get('memberWorkNumber') is not None:
            self.member_work_number = m.get('memberWorkNumber')
        if m.get('mobile') is not None:
            self.mobile = m.get('mobile')
        if m.get('newDeptId') is not None:
            self.new_dept_id = m.get('newDeptId')
        if m.get('oldDeptId') is not None:
            self.old_dept_id = m.get('oldDeptId')
        if m.get('roleIdList') is not None:
            self.role_id_list = m.get('roleIdList')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class SupplyUpdateMemberResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
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


class SupplyUpdateMemberResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SupplyUpdateMemberResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = SupplyUpdateMemberResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SupplyUpdatePartnerTypeHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class SupplyUpdatePartnerTypeRequest(TeaModel):
    def __init__(
        self,
        label_id: int = None,
        name: str = None,
        super_id: int = None,
    ):
        self.label_id = label_id
        self.name = name
        self.super_id = super_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.label_id is not None:
            result['labelId'] = self.label_id
        if self.name is not None:
            result['name'] = self.name
        if self.super_id is not None:
            result['superId'] = self.super_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('labelId') is not None:
            self.label_id = m.get('labelId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('superId') is not None:
            self.super_id = m.get('superId')
        return self


class SupplyUpdatePartnerTypeResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
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


class SupplyUpdatePartnerTypeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SupplyUpdatePartnerTypeResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = SupplyUpdatePartnerTypeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SupplyUpdateRoleHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class SupplyUpdateRoleRequest(TeaModel):
    def __init__(
        self,
        is_role_group: bool = None,
        role_id: str = None,
        role_name: str = None,
    ):
        self.is_role_group = is_role_group
        self.role_id = role_id
        self.role_name = role_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.is_role_group is not None:
            result['isRoleGroup'] = self.is_role_group
        if self.role_id is not None:
            result['roleId'] = self.role_id
        if self.role_name is not None:
            result['roleName'] = self.role_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isRoleGroup') is not None:
            self.is_role_group = m.get('isRoleGroup')
        if m.get('roleId') is not None:
            self.role_id = m.get('roleId')
        if m.get('roleName') is not None:
            self.role_name = m.get('roleName')
        return self


class SupplyUpdateRoleResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
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


class SupplyUpdateRoleResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SupplyUpdateRoleResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = SupplyUpdateRoleResponseBody()
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
        self.comments = comments
        self.job_code = job_code
        self.job_status_code = job_status_code
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
        status_code: int = None,
    ):
        self.headers = headers
        self.status_code = status_code

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        return self


