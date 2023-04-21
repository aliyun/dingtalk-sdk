# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import List, Dict


class OpenConnectionRequestSubscriptions(TeaModel):
    def __init__(
        self,
        topic: str = None,
        type: str = None,
    ):
        # 订阅的TOPIC
        self.topic = topic
        # 订阅类型
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.topic is not None:
            result['topic'] = self.topic
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('topic') is not None:
            self.topic = m.get('topic')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class OpenConnectionRequest(TeaModel):
    def __init__(
        self,
        client_id: str = None,
        client_secret: str = None,
        subscriptions: List[OpenConnectionRequestSubscriptions] = None,
    ):
        # 企业三方应用为suiteKey
        # 企业自建应用为appKey
        self.client_id = client_id
        # 企业三方应用为suiteSecret
        # 企业自己应用为appSecret
        self.client_secret = client_secret
        self.subscriptions = subscriptions

    def validate(self):
        if self.subscriptions:
            for k in self.subscriptions:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.client_id is not None:
            result['clientId'] = self.client_id
        if self.client_secret is not None:
            result['clientSecret'] = self.client_secret
        result['subscriptions'] = []
        if self.subscriptions is not None:
            for k in self.subscriptions:
                result['subscriptions'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('clientId') is not None:
            self.client_id = m.get('clientId')
        if m.get('clientSecret') is not None:
            self.client_secret = m.get('clientSecret')
        self.subscriptions = []
        if m.get('subscriptions') is not None:
            for k in m.get('subscriptions'):
                temp_model = OpenConnectionRequestSubscriptions()
                self.subscriptions.append(temp_model.from_map(k))
        return self


class OpenConnectionResponseBody(TeaModel):
    def __init__(
        self,
        endpoint: str = None,
        ticket: str = None,
    ):
        # 长连接接入点
        self.endpoint = endpoint
        # 连接ticket
        self.ticket = ticket

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.endpoint is not None:
            result['endpoint'] = self.endpoint
        if self.ticket is not None:
            result['ticket'] = self.ticket
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endpoint') is not None:
            self.endpoint = m.get('endpoint')
        if m.get('ticket') is not None:
            self.ticket = m.get('ticket')
        return self


class OpenConnectionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: OpenConnectionResponseBody = None,
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
            temp_model = OpenConnectionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


