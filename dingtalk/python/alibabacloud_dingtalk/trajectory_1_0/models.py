# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class QueryAppActiveUsersHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryAppActiveUsersRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        need_position_info: bool = None,
        next_token: int = None,
    ):
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
        self.need_position_info = need_position_info
        # This parameter is required.
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
        if self.need_position_info is not None:
            result['needPositionInfo'] = self.need_position_info
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('needPositionInfo') is not None:
            self.need_position_info = m.get('needPositionInfo')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class QueryAppActiveUsersResponseBodyList(TeaModel):
    def __init__(
        self,
        app_trace_id: str = None,
        latitude: float = None,
        longitude: float = None,
        report_time: int = None,
        start_time: int = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_trace_id = app_trace_id
        # This parameter is required.
        self.latitude = latitude
        # This parameter is required.
        self.longitude = longitude
        # This parameter is required.
        self.report_time = report_time
        # This parameter is required.
        self.start_time = start_time
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_trace_id is not None:
            result['appTraceId'] = self.app_trace_id
        if self.latitude is not None:
            result['latitude'] = self.latitude
        if self.longitude is not None:
            result['longitude'] = self.longitude
        if self.report_time is not None:
            result['reportTime'] = self.report_time
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appTraceId') is not None:
            self.app_trace_id = m.get('appTraceId')
        if m.get('latitude') is not None:
            self.latitude = m.get('latitude')
        if m.get('longitude') is not None:
            self.longitude = m.get('longitude')
        if m.get('reportTime') is not None:
            self.report_time = m.get('reportTime')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryAppActiveUsersResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[QueryAppActiveUsersResponseBodyList] = None,
        next_token: int = None,
        total_count: int = None,
    ):
        # This parameter is required.
        self.has_more = has_more
        # This parameter is required.
        self.list = list
        # This parameter is required.
        self.next_token = next_token
        # This parameter is required.
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
        if self.next_token is not None:
            result['nextToken'] = self.next_token
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
                temp_model = QueryAppActiveUsersResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class QueryAppActiveUsersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryAppActiveUsersResponseBody = None,
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
            temp_model = QueryAppActiveUsersResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryCollectingTraceTaskHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryCollectingTraceTaskRequest(TeaModel):
    def __init__(
        self,
        user_ids: List[str] = None,
    ):
        # This parameter is required.
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


class QueryCollectingTraceTaskResponseBodyList(TeaModel):
    def __init__(
        self,
        app_trace_id: str = None,
        geo_collect_period: int = None,
        geo_report_period: int = None,
        geo_report_status: int = None,
        report_end_time: int = None,
        report_start_time: int = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_trace_id = app_trace_id
        # This parameter is required.
        self.geo_collect_period = geo_collect_period
        # This parameter is required.
        self.geo_report_period = geo_report_period
        # This parameter is required.
        self.geo_report_status = geo_report_status
        # This parameter is required.
        self.report_end_time = report_end_time
        # This parameter is required.
        self.report_start_time = report_start_time
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_trace_id is not None:
            result['appTraceId'] = self.app_trace_id
        if self.geo_collect_period is not None:
            result['geoCollectPeriod'] = self.geo_collect_period
        if self.geo_report_period is not None:
            result['geoReportPeriod'] = self.geo_report_period
        if self.geo_report_status is not None:
            result['geoReportStatus'] = self.geo_report_status
        if self.report_end_time is not None:
            result['reportEndTime'] = self.report_end_time
        if self.report_start_time is not None:
            result['reportStartTime'] = self.report_start_time
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appTraceId') is not None:
            self.app_trace_id = m.get('appTraceId')
        if m.get('geoCollectPeriod') is not None:
            self.geo_collect_period = m.get('geoCollectPeriod')
        if m.get('geoReportPeriod') is not None:
            self.geo_report_period = m.get('geoReportPeriod')
        if m.get('geoReportStatus') is not None:
            self.geo_report_status = m.get('geoReportStatus')
        if m.get('reportEndTime') is not None:
            self.report_end_time = m.get('reportEndTime')
        if m.get('reportStartTime') is not None:
            self.report_start_time = m.get('reportStartTime')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryCollectingTraceTaskResponseBody(TeaModel):
    def __init__(
        self,
        list: List[QueryCollectingTraceTaskResponseBodyList] = None,
    ):
        # This parameter is required.
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
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = QueryCollectingTraceTaskResponseBodyList()
                self.list.append(temp_model.from_map(k))
        return self


class QueryCollectingTraceTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryCollectingTraceTaskResponseBody = None,
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
            temp_model = QueryCollectingTraceTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryPageTraceDataHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryPageTraceDataRequest(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        max_results: int = None,
        next_token: int = None,
        staff_id: str = None,
        start_time: int = None,
        trace_id: str = None,
    ):
        self.end_time = end_time
        # This parameter is required.
        self.max_results = max_results
        self.next_token = next_token
        # This parameter is required.
        self.staff_id = staff_id
        self.start_time = start_time
        self.trace_id = trace_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.staff_id is not None:
            result['staffId'] = self.staff_id
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.trace_id is not None:
            result['traceId'] = self.trace_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('staffId') is not None:
            self.staff_id = m.get('staffId')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('traceId') is not None:
            self.trace_id = m.get('traceId')
        return self


class QueryPageTraceDataResponseBodyListCoordinates(TeaModel):
    def __init__(
        self,
        latitude: float = None,
        longitude: float = None,
    ):
        # This parameter is required.
        self.latitude = latitude
        # This parameter is required.
        self.longitude = longitude

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.latitude is not None:
            result['latitude'] = self.latitude
        if self.longitude is not None:
            result['longitude'] = self.longitude
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('latitude') is not None:
            self.latitude = m.get('latitude')
        if m.get('longitude') is not None:
            self.longitude = m.get('longitude')
        return self


class QueryPageTraceDataResponseBodyList(TeaModel):
    def __init__(
        self,
        coordinates: QueryPageTraceDataResponseBodyListCoordinates = None,
        gmt_location: int = None,
        gmt_upload: int = None,
    ):
        # This parameter is required.
        self.coordinates = coordinates
        # This parameter is required.
        self.gmt_location = gmt_location
        # This parameter is required.
        self.gmt_upload = gmt_upload

    def validate(self):
        if self.coordinates:
            self.coordinates.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.coordinates is not None:
            result['coordinates'] = self.coordinates.to_map()
        if self.gmt_location is not None:
            result['gmtLocation'] = self.gmt_location
        if self.gmt_upload is not None:
            result['gmtUpload'] = self.gmt_upload
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('coordinates') is not None:
            temp_model = QueryPageTraceDataResponseBodyListCoordinates()
            self.coordinates = temp_model.from_map(m['coordinates'])
        if m.get('gmtLocation') is not None:
            self.gmt_location = m.get('gmtLocation')
        if m.get('gmtUpload') is not None:
            self.gmt_upload = m.get('gmtUpload')
        return self


class QueryPageTraceDataResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[QueryPageTraceDataResponseBodyList] = None,
        next_token: int = None,
    ):
        # This parameter is required.
        self.has_more = has_more
        # This parameter is required.
        self.list = list
        # This parameter is required.
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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = QueryPageTraceDataResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class QueryPageTraceDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryPageTraceDataResponseBody = None,
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
            temp_model = QueryPageTraceDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


