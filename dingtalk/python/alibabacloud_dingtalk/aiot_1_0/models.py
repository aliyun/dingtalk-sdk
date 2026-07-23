# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Any, Dict, List


class PropertiesValue(TeaModel):
    def __init__(
        self,
        value: Any = None,
        timestamp: str = None,
    ):
        self.value = value
        self.timestamp = timestamp

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.value is not None:
            result['value'] = self.value
        if self.timestamp is not None:
            result['timestamp'] = self.timestamp
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('value') is not None:
            self.value = m.get('value')
        if m.get('timestamp') is not None:
            self.timestamp = m.get('timestamp')
        return self


class CheckDeviceUpdateHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class CheckDeviceUpdateRequestBody(TeaModel):
    def __init__(
        self,
        current_version: str = None,
        module_name: str = None,
    ):
        self.current_version = current_version
        # This parameter is required.
        self.module_name = module_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.current_version is not None:
            result['currentVersion'] = self.current_version
        if self.module_name is not None:
            result['moduleName'] = self.module_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('currentVersion') is not None:
            self.current_version = m.get('currentVersion')
        if m.get('moduleName') is not None:
            self.module_name = m.get('moduleName')
        return self


class CheckDeviceUpdateRequest(TeaModel):
    def __init__(
        self,
        body: List[CheckDeviceUpdateRequestBody] = None,
    ):
        # This parameter is required.
        self.body = body

    def validate(self):
        if self.body:
            for k in self.body:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['body'] = []
        if self.body is not None:
            for k in self.body:
                result['body'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.body = []
        if m.get('body') is not None:
            for k in m.get('body'):
                temp_model = CheckDeviceUpdateRequestBody()
                self.body.append(temp_model.from_map(k))
        return self


class CheckDeviceUpdateResponseBodyModules(TeaModel):
    def __init__(
        self,
        checksum: str = None,
        checksum_algorithm: str = None,
        critical_next: str = None,
        current_version: str = None,
        file_url: str = None,
        latest: str = None,
        module_name: str = None,
        notice_en: str = None,
        notice_zh: str = None,
        upgrade_mode: str = None,
    ):
        self.checksum = checksum
        self.checksum_algorithm = checksum_algorithm
        self.critical_next = critical_next
        self.current_version = current_version
        self.file_url = file_url
        self.latest = latest
        self.module_name = module_name
        self.notice_en = notice_en
        self.notice_zh = notice_zh
        self.upgrade_mode = upgrade_mode

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.checksum is not None:
            result['checksum'] = self.checksum
        if self.checksum_algorithm is not None:
            result['checksumAlgorithm'] = self.checksum_algorithm
        if self.critical_next is not None:
            result['criticalNext'] = self.critical_next
        if self.current_version is not None:
            result['currentVersion'] = self.current_version
        if self.file_url is not None:
            result['fileUrl'] = self.file_url
        if self.latest is not None:
            result['latest'] = self.latest
        if self.module_name is not None:
            result['moduleName'] = self.module_name
        if self.notice_en is not None:
            result['noticeEn'] = self.notice_en
        if self.notice_zh is not None:
            result['noticeZh'] = self.notice_zh
        if self.upgrade_mode is not None:
            result['upgradeMode'] = self.upgrade_mode
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('checksum') is not None:
            self.checksum = m.get('checksum')
        if m.get('checksumAlgorithm') is not None:
            self.checksum_algorithm = m.get('checksumAlgorithm')
        if m.get('criticalNext') is not None:
            self.critical_next = m.get('criticalNext')
        if m.get('currentVersion') is not None:
            self.current_version = m.get('currentVersion')
        if m.get('fileUrl') is not None:
            self.file_url = m.get('fileUrl')
        if m.get('latest') is not None:
            self.latest = m.get('latest')
        if m.get('moduleName') is not None:
            self.module_name = m.get('moduleName')
        if m.get('noticeEn') is not None:
            self.notice_en = m.get('noticeEn')
        if m.get('noticeZh') is not None:
            self.notice_zh = m.get('noticeZh')
        if m.get('upgradeMode') is not None:
            self.upgrade_mode = m.get('upgradeMode')
        return self


class CheckDeviceUpdateResponseBody(TeaModel):
    def __init__(
        self,
        modules: List[CheckDeviceUpdateResponseBodyModules] = None,
    ):
        self.modules = modules

    def validate(self):
        if self.modules:
            for k in self.modules:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['modules'] = []
        if self.modules is not None:
            for k in self.modules:
                result['modules'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.modules = []
        if m.get('modules') is not None:
            for k in m.get('modules'):
                temp_model = CheckDeviceUpdateResponseBodyModules()
                self.modules.append(temp_model.from_map(k))
        return self


class CheckDeviceUpdateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CheckDeviceUpdateResponseBody = None,
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
            temp_model = CheckDeviceUpdateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ConfirmFirmwareUpgradeHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class ConfirmFirmwareUpgradeRequest(TeaModel):
    def __init__(
        self,
        module_name: str = None,
    ):
        self.module_name = module_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.module_name is not None:
            result['moduleName'] = self.module_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('moduleName') is not None:
            self.module_name = m.get('moduleName')
        return self


class ConfirmFirmwareUpgradeResponseBody(TeaModel):
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


class ConfirmFirmwareUpgradeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ConfirmFirmwareUpgradeResponseBody = None,
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
            temp_model = ConfirmFirmwareUpgradeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetDeviceDetailHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetDeviceDetailRequest(TeaModel):
    def __init__(
        self,
        device_name: str = None,
        product_key: str = None,
    ):
        # This parameter is required.
        self.device_name = device_name
        # This parameter is required.
        self.product_key = product_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_name is not None:
            result['deviceName'] = self.device_name
        if self.product_key is not None:
            result['productKey'] = self.product_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceName') is not None:
            self.device_name = m.get('deviceName')
        if m.get('productKey') is not None:
            self.product_key = m.get('productKey')
        return self


class GetDeviceDetailResponseBody(TeaModel):
    def __init__(
        self,
        activated_at: str = None,
        connectivity: str = None,
        last_offline_time: str = None,
        last_online_time: str = None,
        status: str = None,
    ):
        self.activated_at = activated_at
        self.connectivity = connectivity
        self.last_offline_time = last_offline_time
        self.last_online_time = last_online_time
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.activated_at is not None:
            result['activatedAt'] = self.activated_at
        if self.connectivity is not None:
            result['connectivity'] = self.connectivity
        if self.last_offline_time is not None:
            result['lastOfflineTime'] = self.last_offline_time
        if self.last_online_time is not None:
            result['lastOnlineTime'] = self.last_online_time
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activatedAt') is not None:
            self.activated_at = m.get('activatedAt')
        if m.get('connectivity') is not None:
            self.connectivity = m.get('connectivity')
        if m.get('lastOfflineTime') is not None:
            self.last_offline_time = m.get('lastOfflineTime')
        if m.get('lastOnlineTime') is not None:
            self.last_online_time = m.get('lastOnlineTime')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class GetDeviceDetailResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetDeviceDetailResponseBody = None,
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
            temp_model = GetDeviceDetailResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetDevicePropertiesHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetDevicePropertiesRequest(TeaModel):
    def __init__(
        self,
        body: List[str] = None,
    ):
        # This parameter is required.
        self.body = body

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.body is not None:
            result['body'] = self.body
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('body') is not None:
            self.body = m.get('body')
        return self


class GetDevicePropertiesResponseBody(TeaModel):
    def __init__(
        self,
        device_name: str = None,
        product_key: str = None,
        properties: Dict[str, PropertiesValue] = None,
        snapshot_at: str = None,
    ):
        self.device_name = device_name
        self.product_key = product_key
        self.properties = properties
        self.snapshot_at = snapshot_at

    def validate(self):
        if self.properties:
            for v in self.properties.values():
                if v:
                    v.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_name is not None:
            result['deviceName'] = self.device_name
        if self.product_key is not None:
            result['productKey'] = self.product_key
        result['properties'] = {}
        if self.properties is not None:
            for k, v in self.properties.items():
                result['properties'][k] = v.to_map()
        if self.snapshot_at is not None:
            result['snapshotAt'] = self.snapshot_at
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceName') is not None:
            self.device_name = m.get('deviceName')
        if m.get('productKey') is not None:
            self.product_key = m.get('productKey')
        self.properties = {}
        if m.get('properties') is not None:
            for k, v in m.get('properties').items():
                temp_model = PropertiesValue()
                self.properties[k] = temp_model.from_map(v)
        if m.get('snapshotAt') is not None:
            self.snapshot_at = m.get('snapshotAt')
        return self


class GetDevicePropertiesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetDevicePropertiesResponseBody = None,
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
            temp_model = GetDevicePropertiesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetServiceInvocationHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetServiceInvocationRequest(TeaModel):
    def __init__(
        self,
        invocation_id: str = None,
    ):
        # This parameter is required.
        self.invocation_id = invocation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.invocation_id is not None:
            result['invocationId'] = self.invocation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('invocationId') is not None:
            self.invocation_id = m.get('invocationId')
        return self


class GetServiceInvocationResponseBody(TeaModel):
    def __init__(
        self,
        completed_at: str = None,
        created_at: str = None,
        device_name: str = None,
        error_code: str = None,
        error_msg: str = None,
        identifier: str = None,
        invocation_id: str = None,
        output_data: Dict[str, Any] = None,
        processing_time_ms: int = None,
        product_key: str = None,
        status: str = None,
    ):
        self.completed_at = completed_at
        self.created_at = created_at
        self.device_name = device_name
        self.error_code = error_code
        self.error_msg = error_msg
        self.identifier = identifier
        self.invocation_id = invocation_id
        self.output_data = output_data
        self.processing_time_ms = processing_time_ms
        self.product_key = product_key
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.completed_at is not None:
            result['completedAt'] = self.completed_at
        if self.created_at is not None:
            result['createdAt'] = self.created_at
        if self.device_name is not None:
            result['deviceName'] = self.device_name
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.identifier is not None:
            result['identifier'] = self.identifier
        if self.invocation_id is not None:
            result['invocationId'] = self.invocation_id
        if self.output_data is not None:
            result['outputData'] = self.output_data
        if self.processing_time_ms is not None:
            result['processingTimeMs'] = self.processing_time_ms
        if self.product_key is not None:
            result['productKey'] = self.product_key
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('completedAt') is not None:
            self.completed_at = m.get('completedAt')
        if m.get('createdAt') is not None:
            self.created_at = m.get('createdAt')
        if m.get('deviceName') is not None:
            self.device_name = m.get('deviceName')
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('identifier') is not None:
            self.identifier = m.get('identifier')
        if m.get('invocationId') is not None:
            self.invocation_id = m.get('invocationId')
        if m.get('outputData') is not None:
            self.output_data = m.get('outputData')
        if m.get('processingTimeMs') is not None:
            self.processing_time_ms = m.get('processingTimeMs')
        if m.get('productKey') is not None:
            self.product_key = m.get('productKey')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class GetServiceInvocationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetServiceInvocationResponseBody = None,
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
            temp_model = GetServiceInvocationResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class InvokeDeviceServiceHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class InvokeDeviceServiceRequest(TeaModel):
    def __init__(
        self,
        args: Dict[str, Any] = None,
        timeout_seconds: int = None,
    ):
        self.args = args
        self.timeout_seconds = timeout_seconds

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.args is not None:
            result['args'] = self.args
        if self.timeout_seconds is not None:
            result['timeoutSeconds'] = self.timeout_seconds
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('args') is not None:
            self.args = m.get('args')
        if m.get('timeoutSeconds') is not None:
            self.timeout_seconds = m.get('timeoutSeconds')
        return self


class InvokeDeviceServiceResponseBody(TeaModel):
    def __init__(
        self,
        error_code: str = None,
        error_msg: str = None,
        invocation_id: str = None,
        output_data: Dict[str, Any] = None,
        status: str = None,
    ):
        self.error_code = error_code
        self.error_msg = error_msg
        self.invocation_id = invocation_id
        self.output_data = output_data
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.invocation_id is not None:
            result['invocationId'] = self.invocation_id
        if self.output_data is not None:
            result['outputData'] = self.output_data
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('invocationId') is not None:
            self.invocation_id = m.get('invocationId')
        if m.get('outputData') is not None:
            self.output_data = m.get('outputData')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class InvokeDeviceServiceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: InvokeDeviceServiceResponseBody = None,
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
            temp_model = InvokeDeviceServiceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SetDevicePropertiesHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class SetDevicePropertiesRequest(TeaModel):
    def __init__(
        self,
        body: Dict[str, Any] = None,
    ):
        # This parameter is required.
        self.body = body

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.body is not None:
            result['body'] = self.body
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('body') is not None:
            self.body = m.get('body')
        return self


class SetDevicePropertiesResponseBody(TeaModel):
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


class SetDevicePropertiesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SetDevicePropertiesResponseBody = None,
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
            temp_model = SetDevicePropertiesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


