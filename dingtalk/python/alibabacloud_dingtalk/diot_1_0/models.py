# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict


class RegisterDeviceHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class RegisterDeviceRequest(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        id: str = None,
        device_name: str = None,
        nick_name: str = None,
        location: str = None,
        device_status: int = None,
        device_type: str = None,
        device_type_name: str = None,
        parent_id: str = None,
        product_type: str = None,
        live_url: str = None,
    ):
        # 钉钉组织id
        self.corp_id = corp_id
        # 设备id
        self.id = id
        # 设备名称
        self.device_name = device_name
        # 设备昵称
        self.nick_name = nick_name
        # 设备地址
        self.location = location
        # 设备状态 0:在线 1:离线
        self.device_status = device_status
        # 设备类型
        self.device_type = device_type
        # 设备类型名称
        self.device_type_name = device_type_name
        # 设备父节点id
        self.parent_id = parent_id
        # 设备类型 摄像头:CAMERA 其它:OTHERS
        self.product_type = product_type
        # 视频流地址
        self.live_url = live_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.id is not None:
            result['id'] = self.id
        if self.device_name is not None:
            result['deviceName'] = self.device_name
        if self.nick_name is not None:
            result['nickName'] = self.nick_name
        if self.location is not None:
            result['location'] = self.location
        if self.device_status is not None:
            result['deviceStatus'] = self.device_status
        if self.device_type is not None:
            result['deviceType'] = self.device_type
        if self.device_type_name is not None:
            result['deviceTypeName'] = self.device_type_name
        if self.parent_id is not None:
            result['parentId'] = self.parent_id
        if self.product_type is not None:
            result['productType'] = self.product_type
        if self.live_url is not None:
            result['liveUrl'] = self.live_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('deviceName') is not None:
            self.device_name = m.get('deviceName')
        if m.get('nickName') is not None:
            self.nick_name = m.get('nickName')
        if m.get('location') is not None:
            self.location = m.get('location')
        if m.get('deviceStatus') is not None:
            self.device_status = m.get('deviceStatus')
        if m.get('deviceType') is not None:
            self.device_type = m.get('deviceType')
        if m.get('deviceTypeName') is not None:
            self.device_type_name = m.get('deviceTypeName')
        if m.get('parentId') is not None:
            self.parent_id = m.get('parentId')
        if m.get('productType') is not None:
            self.product_type = m.get('productType')
        if m.get('liveUrl') is not None:
            self.live_url = m.get('liveUrl')
        return self


class RegisterDeviceResponseBody(TeaModel):
    def __init__(
        self,
        device_id: str = None,
    ):
        # 设备id
        self.device_id = device_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_id is not None:
            result['deviceId'] = self.device_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceId') is not None:
            self.device_id = m.get('deviceId')
        return self


class RegisterDeviceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: RegisterDeviceResponseBody = None,
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
            temp_model = RegisterDeviceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


