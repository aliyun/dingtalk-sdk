# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class CreateTicketHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class CreateTicketRequestReporters(TeaModel):
    def __init__(
        self,
        carrier: str = None,
        phone: str = None,
        region: str = None,
        role: str = None,
        screenshots: List[str] = None,
        timestamp: int = None,
        uid: str = None,
        version: str = None,
    ):
        self.carrier = carrier
        self.phone = phone
        self.region = region
        self.role = role
        self.screenshots = screenshots
        self.timestamp = timestamp
        self.uid = uid
        self.version = version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.carrier is not None:
            result['carrier'] = self.carrier
        if self.phone is not None:
            result['phone'] = self.phone
        if self.region is not None:
            result['region'] = self.region
        if self.role is not None:
            result['role'] = self.role
        if self.screenshots is not None:
            result['screenshots'] = self.screenshots
        if self.timestamp is not None:
            result['timestamp'] = self.timestamp
        if self.uid is not None:
            result['uid'] = self.uid
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('carrier') is not None:
            self.carrier = m.get('carrier')
        if m.get('phone') is not None:
            self.phone = m.get('phone')
        if m.get('region') is not None:
            self.region = m.get('region')
        if m.get('role') is not None:
            self.role = m.get('role')
        if m.get('screenshots') is not None:
            self.screenshots = m.get('screenshots')
        if m.get('timestamp') is not None:
            self.timestamp = m.get('timestamp')
        if m.get('uid') is not None:
            self.uid = m.get('uid')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class CreateTicketRequest(TeaModel):
    def __init__(
        self,
        description: str = None,
        priority: str = None,
        reporters: List[CreateTicketRequestReporters] = None,
    ):
        # This parameter is required.
        self.description = description
        self.priority = priority
        self.reporters = reporters

    def validate(self):
        if self.reporters:
            for k in self.reporters:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.description is not None:
            result['description'] = self.description
        if self.priority is not None:
            result['priority'] = self.priority
        result['reporters'] = []
        if self.reporters is not None:
            for k in self.reporters:
                result['reporters'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('priority') is not None:
            self.priority = m.get('priority')
        self.reporters = []
        if m.get('reporters') is not None:
            for k in m.get('reporters'):
                temp_model = CreateTicketRequestReporters()
                self.reporters.append(temp_model.from_map(k))
        return self


class CreateTicketShrinkRequest(TeaModel):
    def __init__(
        self,
        description: str = None,
        priority: str = None,
        reporters_shrink: str = None,
    ):
        # This parameter is required.
        self.description = description
        self.priority = priority
        self.reporters_shrink = reporters_shrink

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.description is not None:
            result['description'] = self.description
        if self.priority is not None:
            result['priority'] = self.priority
        if self.reporters_shrink is not None:
            result['reporters'] = self.reporters_shrink
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('priority') is not None:
            self.priority = m.get('priority')
        if m.get('reporters') is not None:
            self.reporters_shrink = m.get('reporters')
        return self


class CreateTicketResponseBodyData(TeaModel):
    def __init__(
        self,
        ticket_id: str = None,
    ):
        self.ticket_id = ticket_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ticket_id is not None:
            result['ticketId'] = self.ticket_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('ticketId') is not None:
            self.ticket_id = m.get('ticketId')
        return self


class CreateTicketResponseBody(TeaModel):
    def __init__(
        self,
        data: CreateTicketResponseBodyData = None,
        request_id: str = None,
        success: bool = None,
    ):
        self.data = data
        self.request_id = request_id
        self.success = success

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            temp_model = CreateTicketResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class CreateTicketResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateTicketResponseBody = None,
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
            temp_model = CreateTicketResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


