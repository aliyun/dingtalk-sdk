# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class CreateActivityHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class CreateActivityRequestDetailAddress(TeaModel):
    def __init__(
        self,
        district: str = None,
        lat: str = None,
        lng: str = None,
        name: str = None,
    ):
        self.district = district
        self.lat = lat
        self.lng = lng
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.district is not None:
            result['district'] = self.district
        if self.lat is not None:
            result['lat'] = self.lat
        if self.lng is not None:
            result['lng'] = self.lng
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('district') is not None:
            self.district = m.get('district')
        if m.get('lat') is not None:
            self.lat = m.get('lat')
        if m.get('lng') is not None:
            self.lng = m.get('lng')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class CreateActivityRequestDetail(TeaModel):
    def __init__(
        self,
        address: CreateActivityRequestDetailAddress = None,
        banner_media_id: str = None,
        end_time: int = None,
        foreign_id: str = None,
        industry: str = None,
        role_name: str = None,
        source: str = None,
        start_time: int = None,
        title: str = None,
        type: int = None,
        url: str = None,
    ):
        self.address = address
        self.banner_media_id = banner_media_id
        self.end_time = end_time
        self.foreign_id = foreign_id
        self.industry = industry
        self.role_name = role_name
        self.source = source
        self.start_time = start_time
        self.title = title
        self.type = type
        self.url = url

    def validate(self):
        if self.address:
            self.address.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.address is not None:
            result['address'] = self.address.to_map()
        if self.banner_media_id is not None:
            result['bannerMediaId'] = self.banner_media_id
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.foreign_id is not None:
            result['foreignId'] = self.foreign_id
        if self.industry is not None:
            result['industry'] = self.industry
        if self.role_name is not None:
            result['roleName'] = self.role_name
        if self.source is not None:
            result['source'] = self.source
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.title is not None:
            result['title'] = self.title
        if self.type is not None:
            result['type'] = self.type
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('address') is not None:
            temp_model = CreateActivityRequestDetailAddress()
            self.address = temp_model.from_map(m['address'])
        if m.get('bannerMediaId') is not None:
            self.banner_media_id = m.get('bannerMediaId')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('foreignId') is not None:
            self.foreign_id = m.get('foreignId')
        if m.get('industry') is not None:
            self.industry = m.get('industry')
        if m.get('roleName') is not None:
            self.role_name = m.get('roleName')
        if m.get('source') is not None:
            self.source = m.get('source')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class CreateActivityRequest(TeaModel):
    def __init__(
        self,
        detail: CreateActivityRequestDetail = None,
    ):
        self.detail = detail

    def validate(self):
        if self.detail:
            self.detail.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.detail is not None:
            result['detail'] = self.detail.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('detail') is not None:
            temp_model = CreateActivityRequestDetail()
            self.detail = temp_model.from_map(m['detail'])
        return self


class CreateActivityResponseBody(TeaModel):
    def __init__(
        self,
        activity_id: str = None,
    ):
        self.activity_id = activity_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.activity_id is not None:
            result['activityId'] = self.activity_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activityId') is not None:
            self.activity_id = m.get('activityId')
        return self


class CreateActivityResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateActivityResponseBody = None,
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
            temp_model = CreateActivityResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListActivityHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class ListActivityRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
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


class ListActivityResponseBodyList(TeaModel):
    def __init__(
        self,
        activity_id: str = None,
        banner_media_id: str = None,
        end_time: int = None,
        foreign_id: str = None,
        start_time: int = None,
        status: str = None,
        title: str = None,
        type: str = None,
        url: str = None,
    ):
        self.activity_id = activity_id
        self.banner_media_id = banner_media_id
        self.end_time = end_time
        self.foreign_id = foreign_id
        self.start_time = start_time
        self.status = status
        self.title = title
        self.type = type
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.activity_id is not None:
            result['activityId'] = self.activity_id
        if self.banner_media_id is not None:
            result['bannerMediaId'] = self.banner_media_id
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.foreign_id is not None:
            result['foreignId'] = self.foreign_id
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.status is not None:
            result['status'] = self.status
        if self.title is not None:
            result['title'] = self.title
        if self.type is not None:
            result['type'] = self.type
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activityId') is not None:
            self.activity_id = m.get('activityId')
        if m.get('bannerMediaId') is not None:
            self.banner_media_id = m.get('bannerMediaId')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('foreignId') is not None:
            self.foreign_id = m.get('foreignId')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class ListActivityResponseBody(TeaModel):
    def __init__(
        self,
        list: List[ListActivityResponseBodyList] = None,
        max_results: str = None,
        next_token: str = None,
    ):
        self.list = list
        self.max_results = max_results
        self.next_token = next_token

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
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = ListActivityResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class ListActivityResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListActivityResponseBody = None,
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
            temp_model = ListActivityResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


