# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List, Any


class AyunOnlienTestRequest(TeaModel):
    def __init__(
        self,
        req_id: str = None,
    ):
        self.req_id = req_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.req_id is not None:
            result['reqId'] = self.req_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('reqId') is not None:
            self.req_id = m.get('reqId')
        return self


class AyunOnlienTestResponseBody(TeaModel):
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


class AyunOnlienTestResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AyunOnlienTestResponseBody = None,
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
            temp_model = AyunOnlienTestResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BatchDeleteDeviceHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class BatchDeleteDeviceRequest(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        device_ids: List[str] = None,
    ):
        self.corp_id = corp_id
        # This parameter is required.
        self.device_ids = device_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.device_ids is not None:
            result['deviceIds'] = self.device_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('deviceIds') is not None:
            self.device_ids = m.get('deviceIds')
        return self


class BatchDeleteDeviceResponseBody(TeaModel):
    def __init__(
        self,
        device_ids: List[str] = None,
    ):
        self.device_ids = device_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_ids is not None:
            result['deviceIds'] = self.device_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceIds') is not None:
            self.device_ids = m.get('deviceIds')
        return self


class BatchDeleteDeviceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BatchDeleteDeviceResponseBody = None,
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
            temp_model = BatchDeleteDeviceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BatchRegisterDeviceHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class BatchRegisterDeviceRequestDevicesLiveUrls(TeaModel):
    def __init__(
        self,
        flv: str = None,
        hls: str = None,
        rtmp: str = None,
    ):
        self.flv = flv
        self.hls = hls
        self.rtmp = rtmp

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.flv is not None:
            result['flv'] = self.flv
        if self.hls is not None:
            result['hls'] = self.hls
        if self.rtmp is not None:
            result['rtmp'] = self.rtmp
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('flv') is not None:
            self.flv = m.get('flv')
        if m.get('hls') is not None:
            self.hls = m.get('hls')
        if m.get('rtmp') is not None:
            self.rtmp = m.get('rtmp')
        return self


class BatchRegisterDeviceRequestDevices(TeaModel):
    def __init__(
        self,
        device_id: str = None,
        device_name: str = None,
        device_status: int = None,
        device_type: str = None,
        device_type_name: str = None,
        extra_data: Dict[str, Any] = None,
        live_urls: BatchRegisterDeviceRequestDevicesLiveUrls = None,
        location: str = None,
        parent_id: str = None,
        product_type: str = None,
    ):
        # This parameter is required.
        self.device_id = device_id
        # This parameter is required.
        self.device_name = device_name
        # This parameter is required.
        self.device_status = device_status
        # This parameter is required.
        self.device_type = device_type
        # This parameter is required.
        self.device_type_name = device_type_name
        self.extra_data = extra_data
        self.live_urls = live_urls
        self.location = location
        self.parent_id = parent_id
        # This parameter is required.
        self.product_type = product_type

    def validate(self):
        if self.live_urls:
            self.live_urls.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_id is not None:
            result['deviceId'] = self.device_id
        if self.device_name is not None:
            result['deviceName'] = self.device_name
        if self.device_status is not None:
            result['deviceStatus'] = self.device_status
        if self.device_type is not None:
            result['deviceType'] = self.device_type
        if self.device_type_name is not None:
            result['deviceTypeName'] = self.device_type_name
        if self.extra_data is not None:
            result['extraData'] = self.extra_data
        if self.live_urls is not None:
            result['liveUrls'] = self.live_urls.to_map()
        if self.location is not None:
            result['location'] = self.location
        if self.parent_id is not None:
            result['parentId'] = self.parent_id
        if self.product_type is not None:
            result['productType'] = self.product_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceId') is not None:
            self.device_id = m.get('deviceId')
        if m.get('deviceName') is not None:
            self.device_name = m.get('deviceName')
        if m.get('deviceStatus') is not None:
            self.device_status = m.get('deviceStatus')
        if m.get('deviceType') is not None:
            self.device_type = m.get('deviceType')
        if m.get('deviceTypeName') is not None:
            self.device_type_name = m.get('deviceTypeName')
        if m.get('extraData') is not None:
            self.extra_data = m.get('extraData')
        if m.get('liveUrls') is not None:
            temp_model = BatchRegisterDeviceRequestDevicesLiveUrls()
            self.live_urls = temp_model.from_map(m['liveUrls'])
        if m.get('location') is not None:
            self.location = m.get('location')
        if m.get('parentId') is not None:
            self.parent_id = m.get('parentId')
        if m.get('productType') is not None:
            self.product_type = m.get('productType')
        return self


class BatchRegisterDeviceRequest(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        devices: List[BatchRegisterDeviceRequestDevices] = None,
    ):
        self.corp_id = corp_id
        # This parameter is required.
        self.devices = devices

    def validate(self):
        if self.devices:
            for k in self.devices:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        result['devices'] = []
        if self.devices is not None:
            for k in self.devices:
                result['devices'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        self.devices = []
        if m.get('devices') is not None:
            for k in m.get('devices'):
                temp_model = BatchRegisterDeviceRequestDevices()
                self.devices.append(temp_model.from_map(k))
        return self


class BatchRegisterDeviceResponseBody(TeaModel):
    def __init__(
        self,
        device_ids: List[str] = None,
    ):
        # This parameter is required.
        self.device_ids = device_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_ids is not None:
            result['deviceIds'] = self.device_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceIds') is not None:
            self.device_ids = m.get('deviceIds')
        return self


class BatchRegisterDeviceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BatchRegisterDeviceResponseBody = None,
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
            temp_model = BatchRegisterDeviceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BatchRegisterEventTypeHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class BatchRegisterEventTypeRequestEventTypes(TeaModel):
    def __init__(
        self,
        event_type: str = None,
        event_type_name: str = None,
    ):
        # This parameter is required.
        self.event_type = event_type
        # This parameter is required.
        self.event_type_name = event_type_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.event_type is not None:
            result['eventType'] = self.event_type
        if self.event_type_name is not None:
            result['eventTypeName'] = self.event_type_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('eventType') is not None:
            self.event_type = m.get('eventType')
        if m.get('eventTypeName') is not None:
            self.event_type_name = m.get('eventTypeName')
        return self


class BatchRegisterEventTypeRequest(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        event_types: List[BatchRegisterEventTypeRequestEventTypes] = None,
    ):
        self.corp_id = corp_id
        # This parameter is required.
        self.event_types = event_types

    def validate(self):
        if self.event_types:
            for k in self.event_types:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        result['eventTypes'] = []
        if self.event_types is not None:
            for k in self.event_types:
                result['eventTypes'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        self.event_types = []
        if m.get('eventTypes') is not None:
            for k in m.get('eventTypes'):
                temp_model = BatchRegisterEventTypeRequestEventTypes()
                self.event_types.append(temp_model.from_map(k))
        return self


class BatchRegisterEventTypeResponseBody(TeaModel):
    def __init__(
        self,
        event_types: List[str] = None,
    ):
        self.event_types = event_types

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.event_types is not None:
            result['eventTypes'] = self.event_types
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('eventTypes') is not None:
            self.event_types = m.get('eventTypes')
        return self


class BatchRegisterEventTypeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BatchRegisterEventTypeResponseBody = None,
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
            temp_model = BatchRegisterEventTypeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BatchUpdateDeviceHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class BatchUpdateDeviceRequestDevicesLiveUrls(TeaModel):
    def __init__(
        self,
        flv: str = None,
        hls: str = None,
        rtmp: str = None,
    ):
        self.flv = flv
        self.hls = hls
        self.rtmp = rtmp

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.flv is not None:
            result['flv'] = self.flv
        if self.hls is not None:
            result['hls'] = self.hls
        if self.rtmp is not None:
            result['rtmp'] = self.rtmp
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('flv') is not None:
            self.flv = m.get('flv')
        if m.get('hls') is not None:
            self.hls = m.get('hls')
        if m.get('rtmp') is not None:
            self.rtmp = m.get('rtmp')
        return self


class BatchUpdateDeviceRequestDevices(TeaModel):
    def __init__(
        self,
        device_id: str = None,
        device_name: str = None,
        device_status: int = None,
        extra_data: Dict[str, Any] = None,
        live_urls: BatchUpdateDeviceRequestDevicesLiveUrls = None,
        location: str = None,
    ):
        # This parameter is required.
        self.device_id = device_id
        self.device_name = device_name
        self.device_status = device_status
        self.extra_data = extra_data
        self.live_urls = live_urls
        self.location = location

    def validate(self):
        if self.live_urls:
            self.live_urls.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_id is not None:
            result['deviceId'] = self.device_id
        if self.device_name is not None:
            result['deviceName'] = self.device_name
        if self.device_status is not None:
            result['deviceStatus'] = self.device_status
        if self.extra_data is not None:
            result['extraData'] = self.extra_data
        if self.live_urls is not None:
            result['liveUrls'] = self.live_urls.to_map()
        if self.location is not None:
            result['location'] = self.location
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceId') is not None:
            self.device_id = m.get('deviceId')
        if m.get('deviceName') is not None:
            self.device_name = m.get('deviceName')
        if m.get('deviceStatus') is not None:
            self.device_status = m.get('deviceStatus')
        if m.get('extraData') is not None:
            self.extra_data = m.get('extraData')
        if m.get('liveUrls') is not None:
            temp_model = BatchUpdateDeviceRequestDevicesLiveUrls()
            self.live_urls = temp_model.from_map(m['liveUrls'])
        if m.get('location') is not None:
            self.location = m.get('location')
        return self


class BatchUpdateDeviceRequest(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        devices: List[BatchUpdateDeviceRequestDevices] = None,
    ):
        self.corp_id = corp_id
        # This parameter is required.
        self.devices = devices

    def validate(self):
        if self.devices:
            for k in self.devices:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        result['devices'] = []
        if self.devices is not None:
            for k in self.devices:
                result['devices'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        self.devices = []
        if m.get('devices') is not None:
            for k in m.get('devices'):
                temp_model = BatchUpdateDeviceRequestDevices()
                self.devices.append(temp_model.from_map(k))
        return self


class BatchUpdateDeviceResponseBody(TeaModel):
    def __init__(
        self,
        device_ids: List[str] = None,
    ):
        # This parameter is required.
        self.device_ids = device_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_ids is not None:
            result['deviceIds'] = self.device_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceIds') is not None:
            self.device_ids = m.get('deviceIds')
        return self


class BatchUpdateDeviceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BatchUpdateDeviceResponseBody = None,
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
            temp_model = BatchUpdateDeviceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BindSystemHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class BindSystemRequest(TeaModel):
    def __init__(
        self,
        auth_code: str = None,
        client_id: str = None,
        client_name: str = None,
        corp_id: str = None,
        extra_data: Dict[str, Any] = None,
    ):
        self.auth_code = auth_code
        # This parameter is required.
        self.client_id = client_id
        # This parameter is required.
        self.client_name = client_name
        # This parameter is required.
        self.corp_id = corp_id
        self.extra_data = extra_data

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.auth_code is not None:
            result['authCode'] = self.auth_code
        if self.client_id is not None:
            result['clientId'] = self.client_id
        if self.client_name is not None:
            result['clientName'] = self.client_name
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.extra_data is not None:
            result['extraData'] = self.extra_data
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('authCode') is not None:
            self.auth_code = m.get('authCode')
        if m.get('clientId') is not None:
            self.client_id = m.get('clientId')
        if m.get('clientName') is not None:
            self.client_name = m.get('clientName')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('extraData') is not None:
            self.extra_data = m.get('extraData')
        return self


class BindSystemResponseBody(TeaModel):
    def __init__(
        self,
        client_id: str = None,
        corp_id: str = None,
    ):
        # This parameter is required.
        self.client_id = client_id
        # This parameter is required.
        self.corp_id = corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.client_id is not None:
            result['clientId'] = self.client_id
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('clientId') is not None:
            self.client_id = m.get('clientId')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        return self


class BindSystemResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BindSystemResponseBody = None,
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
            temp_model = BindSystemResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeviceConferenceHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class DeviceConferenceRequest(TeaModel):
    def __init__(
        self,
        conf_title: str = None,
        conference_id: str = None,
        conference_password: str = None,
        device_ids: List[str] = None,
    ):
        # This parameter is required.
        self.conf_title = conf_title
        self.conference_id = conference_id
        self.conference_password = conference_password
        # This parameter is required.
        self.device_ids = device_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conf_title is not None:
            result['confTitle'] = self.conf_title
        if self.conference_id is not None:
            result['conferenceId'] = self.conference_id
        if self.conference_password is not None:
            result['conferencePassword'] = self.conference_password
        if self.device_ids is not None:
            result['deviceIds'] = self.device_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('confTitle') is not None:
            self.conf_title = m.get('confTitle')
        if m.get('conferenceId') is not None:
            self.conference_id = m.get('conferenceId')
        if m.get('conferencePassword') is not None:
            self.conference_password = m.get('conferencePassword')
        if m.get('deviceIds') is not None:
            self.device_ids = m.get('deviceIds')
        return self


class DeviceConferenceResponseBody(TeaModel):
    def __init__(
        self,
        conference_id: str = None,
    ):
        self.conference_id = conference_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conference_id is not None:
            result['conferenceId'] = self.conference_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conferenceId') is not None:
            self.conference_id = m.get('conferenceId')
        return self


class DeviceConferenceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeviceConferenceResponseBody = None,
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
            temp_model = DeviceConferenceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DiotMamaResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        self.request_id = request_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class DiotMamaResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DiotMamaResponseBody = None,
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
            temp_model = DiotMamaResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DiotMarketManagerTestResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        self.request_id = request_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class DiotMarketManagerTestResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DiotMarketManagerTestResponseBody = None,
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
            temp_model = DiotMarketManagerTestResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DiotSystemMarkTestResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        self.request_id = request_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class DiotSystemMarkTestResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DiotSystemMarkTestResponseBody = None,
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
            temp_model = DiotSystemMarkTestResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DiotMarketManagerResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        self.request_id = request_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class DiotMarketManagerResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DiotMarketManagerResponseBody = None,
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
            temp_model = DiotMarketManagerResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PushEventHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class PushEventRequest(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        device_id: str = None,
        event_id: str = None,
        event_name: str = None,
        event_type: str = None,
        extra_data: Dict[str, Any] = None,
        location: str = None,
        msg: str = None,
        occurrence_time: int = None,
        pic_urls: List[str] = None,
    ):
        self.corp_id = corp_id
        self.device_id = device_id
        # This parameter is required.
        self.event_id = event_id
        # This parameter is required.
        self.event_name = event_name
        # This parameter is required.
        self.event_type = event_type
        self.extra_data = extra_data
        self.location = location
        self.msg = msg
        # This parameter is required.
        self.occurrence_time = occurrence_time
        self.pic_urls = pic_urls

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.device_id is not None:
            result['deviceId'] = self.device_id
        if self.event_id is not None:
            result['eventId'] = self.event_id
        if self.event_name is not None:
            result['eventName'] = self.event_name
        if self.event_type is not None:
            result['eventType'] = self.event_type
        if self.extra_data is not None:
            result['extraData'] = self.extra_data
        if self.location is not None:
            result['location'] = self.location
        if self.msg is not None:
            result['msg'] = self.msg
        if self.occurrence_time is not None:
            result['occurrenceTime'] = self.occurrence_time
        if self.pic_urls is not None:
            result['picUrls'] = self.pic_urls
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('deviceId') is not None:
            self.device_id = m.get('deviceId')
        if m.get('eventId') is not None:
            self.event_id = m.get('eventId')
        if m.get('eventName') is not None:
            self.event_name = m.get('eventName')
        if m.get('eventType') is not None:
            self.event_type = m.get('eventType')
        if m.get('extraData') is not None:
            self.extra_data = m.get('extraData')
        if m.get('location') is not None:
            self.location = m.get('location')
        if m.get('msg') is not None:
            self.msg = m.get('msg')
        if m.get('occurrenceTime') is not None:
            self.occurrence_time = m.get('occurrenceTime')
        if m.get('picUrls') is not None:
            self.pic_urls = m.get('picUrls')
        return self


class PushEventResponseBody(TeaModel):
    def __init__(
        self,
        event_id: str = None,
    ):
        self.event_id = event_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.event_id is not None:
            result['eventId'] = self.event_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('eventId') is not None:
            self.event_id = m.get('eventId')
        return self


class PushEventResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PushEventResponseBody = None,
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
            temp_model = PushEventResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryDeviceHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryDeviceRequest(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        page_number: int = None,
        page_size: int = None,
    ):
        self.corp_id = corp_id
        self.page_number = page_number
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class QueryDeviceResponseBodyDataLiveUrls(TeaModel):
    def __init__(
        self,
        flv: str = None,
        hls: str = None,
        rtmp: str = None,
    ):
        self.flv = flv
        self.hls = hls
        self.rtmp = rtmp

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.flv is not None:
            result['flv'] = self.flv
        if self.hls is not None:
            result['hls'] = self.hls
        if self.rtmp is not None:
            result['rtmp'] = self.rtmp
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('flv') is not None:
            self.flv = m.get('flv')
        if m.get('hls') is not None:
            self.hls = m.get('hls')
        if m.get('rtmp') is not None:
            self.rtmp = m.get('rtmp')
        return self


class QueryDeviceResponseBodyData(TeaModel):
    def __init__(
        self,
        device_id: str = None,
        device_name: str = None,
        device_status: int = None,
        device_type: str = None,
        device_type_name: str = None,
        live_urls: QueryDeviceResponseBodyDataLiveUrls = None,
        location: str = None,
        parent_id: str = None,
        product_type: str = None,
    ):
        # This parameter is required.
        self.device_id = device_id
        self.device_name = device_name
        self.device_status = device_status
        self.device_type = device_type
        self.device_type_name = device_type_name
        self.live_urls = live_urls
        self.location = location
        self.parent_id = parent_id
        self.product_type = product_type

    def validate(self):
        if self.live_urls:
            self.live_urls.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_id is not None:
            result['deviceId'] = self.device_id
        if self.device_name is not None:
            result['deviceName'] = self.device_name
        if self.device_status is not None:
            result['deviceStatus'] = self.device_status
        if self.device_type is not None:
            result['deviceType'] = self.device_type
        if self.device_type_name is not None:
            result['deviceTypeName'] = self.device_type_name
        if self.live_urls is not None:
            result['liveUrls'] = self.live_urls.to_map()
        if self.location is not None:
            result['location'] = self.location
        if self.parent_id is not None:
            result['parentId'] = self.parent_id
        if self.product_type is not None:
            result['productType'] = self.product_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceId') is not None:
            self.device_id = m.get('deviceId')
        if m.get('deviceName') is not None:
            self.device_name = m.get('deviceName')
        if m.get('deviceStatus') is not None:
            self.device_status = m.get('deviceStatus')
        if m.get('deviceType') is not None:
            self.device_type = m.get('deviceType')
        if m.get('deviceTypeName') is not None:
            self.device_type_name = m.get('deviceTypeName')
        if m.get('liveUrls') is not None:
            temp_model = QueryDeviceResponseBodyDataLiveUrls()
            self.live_urls = temp_model.from_map(m['liveUrls'])
        if m.get('location') is not None:
            self.location = m.get('location')
        if m.get('parentId') is not None:
            self.parent_id = m.get('parentId')
        if m.get('productType') is not None:
            self.product_type = m.get('productType')
        return self


class QueryDeviceResponseBody(TeaModel):
    def __init__(
        self,
        data: List[QueryDeviceResponseBodyData] = None,
        page_number: int = None,
        page_size: int = None,
        total_count: int = None,
    ):
        # This parameter is required.
        self.data = data
        self.page_number = page_number
        self.page_size = page_size
        self.total_count = total_count

    def validate(self):
        if self.data:
            for k in self.data:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['data'] = []
        if self.data is not None:
            for k in self.data:
                result['data'].append(k.to_map() if k else None)
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = QueryDeviceResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class QueryDeviceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryDeviceResponseBody = None,
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
            temp_model = QueryDeviceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryDevicePkHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryDevicePkRequest(TeaModel):
    def __init__(
        self,
        device_id: int = None,
    ):
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


class QueryDevicePkResponseBody(TeaModel):
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


class QueryDevicePkResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryDevicePkResponseBody = None,
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
            temp_model = QueryDevicePkResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryEventHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryEventRequest(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        device_id_list: List[str] = None,
        end_time: int = None,
        event_id: str = None,
        event_status_list: List[int] = None,
        event_type_list: List[str] = None,
        page_number: int = None,
        page_size: int = None,
        start_time: int = None,
    ):
        self.corp_id = corp_id
        self.device_id_list = device_id_list
        self.end_time = end_time
        self.event_id = event_id
        self.event_status_list = event_status_list
        self.event_type_list = event_type_list
        self.page_number = page_number
        self.page_size = page_size
        self.start_time = start_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.device_id_list is not None:
            result['deviceIdList'] = self.device_id_list
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.event_id is not None:
            result['eventId'] = self.event_id
        if self.event_status_list is not None:
            result['eventStatusList'] = self.event_status_list
        if self.event_type_list is not None:
            result['eventTypeList'] = self.event_type_list
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.start_time is not None:
            result['startTime'] = self.start_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('deviceIdList') is not None:
            self.device_id_list = m.get('deviceIdList')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('eventId') is not None:
            self.event_id = m.get('eventId')
        if m.get('eventStatusList') is not None:
            self.event_status_list = m.get('eventStatusList')
        if m.get('eventTypeList') is not None:
            self.event_type_list = m.get('eventTypeList')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        return self


class QueryEventResponseBodyData(TeaModel):
    def __init__(
        self,
        event_id: str = None,
        event_name: str = None,
        event_status: int = None,
        event_type: str = None,
        msg: str = None,
        occurrence_time: int = None,
        pic_urls: List[str] = None,
    ):
        self.event_id = event_id
        self.event_name = event_name
        self.event_status = event_status
        self.event_type = event_type
        self.msg = msg
        self.occurrence_time = occurrence_time
        self.pic_urls = pic_urls

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.event_id is not None:
            result['eventId'] = self.event_id
        if self.event_name is not None:
            result['eventName'] = self.event_name
        if self.event_status is not None:
            result['eventStatus'] = self.event_status
        if self.event_type is not None:
            result['eventType'] = self.event_type
        if self.msg is not None:
            result['msg'] = self.msg
        if self.occurrence_time is not None:
            result['occurrenceTime'] = self.occurrence_time
        if self.pic_urls is not None:
            result['picUrls'] = self.pic_urls
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('eventId') is not None:
            self.event_id = m.get('eventId')
        if m.get('eventName') is not None:
            self.event_name = m.get('eventName')
        if m.get('eventStatus') is not None:
            self.event_status = m.get('eventStatus')
        if m.get('eventType') is not None:
            self.event_type = m.get('eventType')
        if m.get('msg') is not None:
            self.msg = m.get('msg')
        if m.get('occurrenceTime') is not None:
            self.occurrence_time = m.get('occurrenceTime')
        if m.get('picUrls') is not None:
            self.pic_urls = m.get('picUrls')
        return self


class QueryEventResponseBody(TeaModel):
    def __init__(
        self,
        data: List[QueryEventResponseBodyData] = None,
        page_number: int = None,
        page_size: int = None,
        total_count: int = None,
    ):
        self.data = data
        self.page_number = page_number
        self.page_size = page_size
        self.total_count = total_count

    def validate(self):
        if self.data:
            for k in self.data:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['data'] = []
        if self.data is not None:
            for k in self.data:
                result['data'].append(k.to_map() if k else None)
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = QueryEventResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class QueryEventResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryEventResponseBody = None,
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
            temp_model = QueryEventResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


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


class RegisterDeviceRequestLiveUrls(TeaModel):
    def __init__(
        self,
        flv: str = None,
        hls: str = None,
        rtmp: str = None,
    ):
        self.flv = flv
        self.hls = hls
        self.rtmp = rtmp

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.flv is not None:
            result['flv'] = self.flv
        if self.hls is not None:
            result['hls'] = self.hls
        if self.rtmp is not None:
            result['rtmp'] = self.rtmp
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('flv') is not None:
            self.flv = m.get('flv')
        if m.get('hls') is not None:
            self.hls = m.get('hls')
        if m.get('rtmp') is not None:
            self.rtmp = m.get('rtmp')
        return self


class RegisterDeviceRequest(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        device_name: str = None,
        device_status: int = None,
        device_type: str = None,
        device_type_name: str = None,
        id: str = None,
        live_urls: RegisterDeviceRequestLiveUrls = None,
        location: str = None,
        nick_name: str = None,
        parent_id: str = None,
        product_type: str = None,
    ):
        self.corp_id = corp_id
        # This parameter is required.
        self.device_name = device_name
        # This parameter is required.
        self.device_status = device_status
        # This parameter is required.
        self.device_type = device_type
        # This parameter is required.
        self.device_type_name = device_type_name
        # This parameter is required.
        self.id = id
        self.live_urls = live_urls
        self.location = location
        self.nick_name = nick_name
        self.parent_id = parent_id
        # This parameter is required.
        self.product_type = product_type

    def validate(self):
        if self.live_urls:
            self.live_urls.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.device_name is not None:
            result['deviceName'] = self.device_name
        if self.device_status is not None:
            result['deviceStatus'] = self.device_status
        if self.device_type is not None:
            result['deviceType'] = self.device_type
        if self.device_type_name is not None:
            result['deviceTypeName'] = self.device_type_name
        if self.id is not None:
            result['id'] = self.id
        if self.live_urls is not None:
            result['liveUrls'] = self.live_urls.to_map()
        if self.location is not None:
            result['location'] = self.location
        if self.nick_name is not None:
            result['nickName'] = self.nick_name
        if self.parent_id is not None:
            result['parentId'] = self.parent_id
        if self.product_type is not None:
            result['productType'] = self.product_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('deviceName') is not None:
            self.device_name = m.get('deviceName')
        if m.get('deviceStatus') is not None:
            self.device_status = m.get('deviceStatus')
        if m.get('deviceType') is not None:
            self.device_type = m.get('deviceType')
        if m.get('deviceTypeName') is not None:
            self.device_type_name = m.get('deviceTypeName')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('liveUrls') is not None:
            temp_model = RegisterDeviceRequestLiveUrls()
            self.live_urls = temp_model.from_map(m['liveUrls'])
        if m.get('location') is not None:
            self.location = m.get('location')
        if m.get('nickName') is not None:
            self.nick_name = m.get('nickName')
        if m.get('parentId') is not None:
            self.parent_id = m.get('parentId')
        if m.get('productType') is not None:
            self.product_type = m.get('productType')
        return self


class RegisterDeviceResponseBody(TeaModel):
    def __init__(
        self,
        device_id: str = None,
    ):
        # This parameter is required.
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
        status_code: int = None,
        body: RegisterDeviceResponseBody = None,
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
            temp_model = RegisterDeviceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpgradeDeviceResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        self.request_id = request_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class UpgradeDeviceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpgradeDeviceResponseBody = None,
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
            temp_model = UpgradeDeviceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class WorkbenchTransformInfoResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        self.request_id = request_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class WorkbenchTransformInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: WorkbenchTransformInfoResponseBody = None,
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
            temp_model = WorkbenchTransformInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


