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


class CreateTicketRequestProperties(TeaModel):
    def __init__(
        self,
        name: str = None,
        value: str = None,
    ):
        self.name = name
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class CreateTicketRequest(TeaModel):
    def __init__(
        self,
        source_id: str = None,
        foreign_id: str = None,
        foreign_name: str = None,
        open_instance_id: str = None,
        production_type: int = None,
        template_id: str = None,
        title: str = None,
        properties: List[CreateTicketRequestProperties] = None,
    ):
        # 会员来源
        self.source_id = source_id
        # 第三方会员ID
        self.foreign_id = foreign_id
        # 第三方会员名称
        self.foreign_name = foreign_name
        # 实例ID
        self.open_instance_id = open_instance_id
        # 智能客服产品
        self.production_type = production_type
        # 工单模板ID
        self.template_id = template_id
        # 工单标题
        self.title = title
        # 工单表单
        self.properties = properties

    def validate(self):
        if self.properties:
            for k in self.properties:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.source_id is not None:
            result['sourceId'] = self.source_id
        if self.foreign_id is not None:
            result['foreignId'] = self.foreign_id
        if self.foreign_name is not None:
            result['foreignName'] = self.foreign_name
        if self.open_instance_id is not None:
            result['openInstanceId'] = self.open_instance_id
        if self.production_type is not None:
            result['productionType'] = self.production_type
        if self.template_id is not None:
            result['templateId'] = self.template_id
        if self.title is not None:
            result['title'] = self.title
        result['properties'] = []
        if self.properties is not None:
            for k in self.properties:
                result['properties'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sourceId') is not None:
            self.source_id = m.get('sourceId')
        if m.get('foreignId') is not None:
            self.foreign_id = m.get('foreignId')
        if m.get('foreignName') is not None:
            self.foreign_name = m.get('foreignName')
        if m.get('openInstanceId') is not None:
            self.open_instance_id = m.get('openInstanceId')
        if m.get('productionType') is not None:
            self.production_type = m.get('productionType')
        if m.get('templateId') is not None:
            self.template_id = m.get('templateId')
        if m.get('title') is not None:
            self.title = m.get('title')
        self.properties = []
        if m.get('properties') is not None:
            for k in m.get('properties'):
                temp_model = CreateTicketRequestProperties()
                self.properties.append(temp_model.from_map(k))
        return self


class CreateTicketResponseBody(TeaModel):
    def __init__(
        self,
        ticket_id: str = None,
    ):
        # 新创建工单ID
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


class CreateTicketResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateTicketResponseBody = None,
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
            temp_model = CreateTicketResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


