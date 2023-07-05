# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class GetCallBackFaileResultHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetCallBackFaileResultRequest(TeaModel):
    def __init__(
        self,
        begin_time: int = None,
        end_time: int = None,
    ):
        self.begin_time = begin_time
        self.end_time = end_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.begin_time is not None:
            result['beginTime'] = self.begin_time
        if self.end_time is not None:
            result['endTime'] = self.end_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('beginTime') is not None:
            self.begin_time = m.get('beginTime')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        return self


class GetCallBackFaileResultResponseBodyFailedList(TeaModel):
    def __init__(
        self,
        call_back_data: str = None,
        call_back_tag: str = None,
        corp_id: str = None,
        event_time: int = None,
    ):
        self.call_back_data = call_back_data
        self.call_back_tag = call_back_tag
        self.corp_id = corp_id
        self.event_time = event_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.call_back_data is not None:
            result['callBackData'] = self.call_back_data
        if self.call_back_tag is not None:
            result['callBackTag'] = self.call_back_tag
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.event_time is not None:
            result['eventTime'] = self.event_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('callBackData') is not None:
            self.call_back_data = m.get('callBackData')
        if m.get('callBackTag') is not None:
            self.call_back_tag = m.get('callBackTag')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('eventTime') is not None:
            self.event_time = m.get('eventTime')
        return self


class GetCallBackFaileResultResponseBody(TeaModel):
    def __init__(
        self,
        failed_list: List[GetCallBackFaileResultResponseBodyFailedList] = None,
        has_more: bool = None,
    ):
        self.failed_list = failed_list
        self.has_more = has_more

    def validate(self):
        if self.failed_list:
            for k in self.failed_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['failedList'] = []
        if self.failed_list is not None:
            for k in self.failed_list:
                result['failedList'].append(k.to_map() if k else None)
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.failed_list = []
        if m.get('failedList') is not None:
            for k in m.get('failedList'):
                temp_model = GetCallBackFaileResultResponseBodyFailedList()
                self.failed_list.append(temp_model.from_map(k))
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        return self


class GetCallBackFaileResultResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetCallBackFaileResultResponseBody = None,
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
            temp_model = GetCallBackFaileResultResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RePushSuiteTicketRequest(TeaModel):
    def __init__(
        self,
        suite_id: int = None,
        suite_secret: str = None,
    ):
        self.suite_id = suite_id
        self.suite_secret = suite_secret

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.suite_id is not None:
            result['suiteId'] = self.suite_id
        if self.suite_secret is not None:
            result['suiteSecret'] = self.suite_secret
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('suiteId') is not None:
            self.suite_id = m.get('suiteId')
        if m.get('suiteSecret') is not None:
            self.suite_secret = m.get('suiteSecret')
        return self


class RePushSuiteTicketResponseBody(TeaModel):
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


class RePushSuiteTicketResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RePushSuiteTicketResponseBody = None,
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
            temp_model = RePushSuiteTicketResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


