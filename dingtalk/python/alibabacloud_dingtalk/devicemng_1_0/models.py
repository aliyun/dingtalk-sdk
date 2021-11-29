# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


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
        ding_corp_id: str = None,
        device_key: str = None,
        device_name: str = None,
        department_id: int = None,
        managers: str = None,
        collaborators: str = None,
        description: str = None,
        user_id: str = None,
    ):
        # 组织id
        self.ding_corp_id = ding_corp_id
        # 设备标识
        self.device_key = device_key
        # 设备名称
        self.device_name = device_name
        # 部门id
        self.department_id = department_id
        # 管理员userId列表
        self.managers = managers
        # 协助者userId列表
        self.collaborators = collaborators
        # 设备描述
        self.description = description
        # 创建者userId
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_corp_id is not None:
            result['dingCorpId'] = self.ding_corp_id
        if self.device_key is not None:
            result['deviceKey'] = self.device_key
        if self.device_name is not None:
            result['deviceName'] = self.device_name
        if self.department_id is not None:
            result['departmentId'] = self.department_id
        if self.managers is not None:
            result['managers'] = self.managers
        if self.collaborators is not None:
            result['collaborators'] = self.collaborators
        if self.description is not None:
            result['description'] = self.description
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingCorpId') is not None:
            self.ding_corp_id = m.get('dingCorpId')
        if m.get('deviceKey') is not None:
            self.device_key = m.get('deviceKey')
        if m.get('deviceName') is not None:
            self.device_name = m.get('deviceName')
        if m.get('departmentId') is not None:
            self.department_id = m.get('departmentId')
        if m.get('managers') is not None:
            self.managers = m.get('managers')
        if m.get('collaborators') is not None:
            self.collaborators = m.get('collaborators')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class RegisterDeviceResponseBody(TeaModel):
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


class BatchRegisterDeviceRequestDeviceList(TeaModel):
    def __init__(
        self,
        device_key: str = None,
        device_name: str = None,
        department_id: int = None,
        managers: str = None,
        collaborators: str = None,
        description: str = None,
    ):
        # 设备标识
        self.device_key = device_key
        # 设备名称
        self.device_name = device_name
        # 部门id
        self.department_id = department_id
        # 管理员userId列表
        self.managers = managers
        # 协助者userId列表
        self.collaborators = collaborators
        # 设备描述
        self.description = description

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_key is not None:
            result['deviceKey'] = self.device_key
        if self.device_name is not None:
            result['deviceName'] = self.device_name
        if self.department_id is not None:
            result['departmentId'] = self.department_id
        if self.managers is not None:
            result['managers'] = self.managers
        if self.collaborators is not None:
            result['collaborators'] = self.collaborators
        if self.description is not None:
            result['description'] = self.description
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceKey') is not None:
            self.device_key = m.get('deviceKey')
        if m.get('deviceName') is not None:
            self.device_name = m.get('deviceName')
        if m.get('departmentId') is not None:
            self.department_id = m.get('departmentId')
        if m.get('managers') is not None:
            self.managers = m.get('managers')
        if m.get('collaborators') is not None:
            self.collaborators = m.get('collaborators')
        if m.get('description') is not None:
            self.description = m.get('description')
        return self


class BatchRegisterDeviceRequest(TeaModel):
    def __init__(
        self,
        device_list: List[BatchRegisterDeviceRequestDeviceList] = None,
        ding_corp_id: str = None,
        user_id: str = None,
    ):
        # 设备列表
        self.device_list = device_list
        # 组织id
        self.ding_corp_id = ding_corp_id
        # 创建者userId
        self.user_id = user_id

    def validate(self):
        if self.device_list:
            for k in self.device_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['deviceList'] = []
        if self.device_list is not None:
            for k in self.device_list:
                result['deviceList'].append(k.to_map() if k else None)
        if self.ding_corp_id is not None:
            result['dingCorpId'] = self.ding_corp_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.device_list = []
        if m.get('deviceList') is not None:
            for k in m.get('deviceList'):
                temp_model = BatchRegisterDeviceRequestDeviceList()
                self.device_list.append(temp_model.from_map(k))
        if m.get('dingCorpId') is not None:
            self.ding_corp_id = m.get('dingCorpId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class BatchRegisterDeviceResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
    ):
        # Id of the request
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


class BatchRegisterDeviceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: BatchRegisterDeviceResponseBody = None,
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
            temp_model = BatchRegisterDeviceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeviceDingHeaders(TeaModel):
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


class DeviceDingRequest(TeaModel):
    def __init__(
        self,
        ding_corp_id: str = None,
        params_json: str = None,
        device_key: str = None,
        receiver_user_id_list: List[str] = None,
    ):
        # 钉钉组织id
        self.ding_corp_id = ding_corp_id
        # 消息体动态参数
        self.params_json = params_json
        # 设备标识
        self.device_key = device_key
        # staffId列表
        self.receiver_user_id_list = receiver_user_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_corp_id is not None:
            result['dingCorpId'] = self.ding_corp_id
        if self.params_json is not None:
            result['paramsJson'] = self.params_json
        if self.device_key is not None:
            result['deviceKey'] = self.device_key
        if self.receiver_user_id_list is not None:
            result['receiverUserIdList'] = self.receiver_user_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingCorpId') is not None:
            self.ding_corp_id = m.get('dingCorpId')
        if m.get('paramsJson') is not None:
            self.params_json = m.get('paramsJson')
        if m.get('deviceKey') is not None:
            self.device_key = m.get('deviceKey')
        if m.get('receiverUserIdList') is not None:
            self.receiver_user_id_list = m.get('receiverUserIdList')
        return self


class DeviceDingResponseBody(TeaModel):
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


class DeviceDingResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DeviceDingResponseBody = None,
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
            temp_model = DeviceDingResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateDepartmentHeaders(TeaModel):
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


class CreateDepartmentRequest(TeaModel):
    def __init__(
        self,
        ding_corp_id: str = None,
        department_name: str = None,
        department_type: str = None,
        system_url: str = None,
        auth_type: str = None,
        auth_info: str = None,
        description: str = None,
        biz_ext: str = None,
        user_id: str = None,
    ):
        # 组织id
        self.ding_corp_id = ding_corp_id
        # 部门名称
        self.department_name = department_name
        # 部门类型
        self.department_type = department_type
        # 业务系统地址
        self.system_url = system_url
        # 认证方式
        self.auth_type = auth_type
        # 认证信息
        self.auth_info = auth_info
        # 部门描述
        self.description = description
        # 业务扩展
        self.biz_ext = biz_ext
        # 创建人工号
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_corp_id is not None:
            result['dingCorpId'] = self.ding_corp_id
        if self.department_name is not None:
            result['departmentName'] = self.department_name
        if self.department_type is not None:
            result['departmentType'] = self.department_type
        if self.system_url is not None:
            result['systemUrl'] = self.system_url
        if self.auth_type is not None:
            result['authType'] = self.auth_type
        if self.auth_info is not None:
            result['authInfo'] = self.auth_info
        if self.description is not None:
            result['description'] = self.description
        if self.biz_ext is not None:
            result['bizExt'] = self.biz_ext
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingCorpId') is not None:
            self.ding_corp_id = m.get('dingCorpId')
        if m.get('departmentName') is not None:
            self.department_name = m.get('departmentName')
        if m.get('departmentType') is not None:
            self.department_type = m.get('departmentType')
        if m.get('systemUrl') is not None:
            self.system_url = m.get('systemUrl')
        if m.get('authType') is not None:
            self.auth_type = m.get('authType')
        if m.get('authInfo') is not None:
            self.auth_info = m.get('authInfo')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('bizExt') is not None:
            self.biz_ext = m.get('bizExt')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CreateDepartmentResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
    ):
        # Id of the request
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


class CreateDepartmentResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateDepartmentResponseBody = None,
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
            temp_model = CreateDepartmentResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


