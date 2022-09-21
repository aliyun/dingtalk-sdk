# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


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
        collaborators: str = None,
        department_id: int = None,
        description: str = None,
        device_key: str = None,
        device_name: str = None,
        managers: str = None,
    ):
        # 协助者userId列表
        self.collaborators = collaborators
        # 部门id
        self.department_id = department_id
        # 设备描述
        self.description = description
        # 设备标识
        self.device_key = device_key
        # 设备名称
        self.device_name = device_name
        # 管理员userId列表
        self.managers = managers

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.collaborators is not None:
            result['collaborators'] = self.collaborators
        if self.department_id is not None:
            result['departmentId'] = self.department_id
        if self.description is not None:
            result['description'] = self.description
        if self.device_key is not None:
            result['deviceKey'] = self.device_key
        if self.device_name is not None:
            result['deviceName'] = self.device_name
        if self.managers is not None:
            result['managers'] = self.managers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('collaborators') is not None:
            self.collaborators = m.get('collaborators')
        if m.get('departmentId') is not None:
            self.department_id = m.get('departmentId')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('deviceKey') is not None:
            self.device_key = m.get('deviceKey')
        if m.get('deviceName') is not None:
            self.device_name = m.get('deviceName')
        if m.get('managers') is not None:
            self.managers = m.get('managers')
        return self


class BatchRegisterDeviceRequest(TeaModel):
    def __init__(
        self,
        device_list: List[BatchRegisterDeviceRequestDeviceList] = None,
        user_id: str = None,
    ):
        # 设备列表
        self.device_list = device_list
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


class ConnectorEventPushHeaders(TeaModel):
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


class ConnectorEventPushRequest(TeaModel):
    def __init__(
        self,
        device_type_uuid: str = None,
        event_name: str = None,
        input: str = None,
    ):
        # 设备类型唯一标识
        self.device_type_uuid = device_type_uuid
        # 事件名称
        self.event_name = event_name
        # 事件入参，json字符串
        self.input = input

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_type_uuid is not None:
            result['deviceTypeUuid'] = self.device_type_uuid
        if self.event_name is not None:
            result['eventName'] = self.event_name
        if self.input is not None:
            result['input'] = self.input
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceTypeUuid') is not None:
            self.device_type_uuid = m.get('deviceTypeUuid')
        if m.get('eventName') is not None:
            self.event_name = m.get('eventName')
        if m.get('input') is not None:
            self.input = m.get('input')
        return self


class ConnectorEventPushResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class ConnectorEventPushResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ConnectorEventPushResponseBody = None,
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
            temp_model = ConnectorEventPushResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateChatRoomHeaders(TeaModel):
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


class CreateChatRoomRequest(TeaModel):
    def __init__(
        self,
        chat_group_name: str = None,
        device_codes: List[str] = None,
        device_type_id: str = None,
        owner_user_id: str = None,
        role_list: List[str] = None,
    ):
        self.chat_group_name = chat_group_name
        self.device_codes = device_codes
        self.device_type_id = device_type_id
        self.owner_user_id = owner_user_id
        self.role_list = role_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.chat_group_name is not None:
            result['chatGroupName'] = self.chat_group_name
        if self.device_codes is not None:
            result['deviceCodes'] = self.device_codes
        if self.device_type_id is not None:
            result['deviceTypeId'] = self.device_type_id
        if self.owner_user_id is not None:
            result['ownerUserId'] = self.owner_user_id
        if self.role_list is not None:
            result['roleList'] = self.role_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('chatGroupName') is not None:
            self.chat_group_name = m.get('chatGroupName')
        if m.get('deviceCodes') is not None:
            self.device_codes = m.get('deviceCodes')
        if m.get('deviceTypeId') is not None:
            self.device_type_id = m.get('deviceTypeId')
        if m.get('ownerUserId') is not None:
            self.owner_user_id = m.get('ownerUserId')
        if m.get('roleList') is not None:
            self.role_list = m.get('roleList')
        return self


class CreateChatRoomResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class CreateChatRoomResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateChatRoomResponseBody = None,
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
            temp_model = CreateChatRoomResponseBody()
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
        auth_info: str = None,
        auth_type: str = None,
        biz_ext: str = None,
        department_name: str = None,
        department_type: str = None,
        description: str = None,
        system_url: str = None,
        user_id: str = None,
    ):
        # 认证信息
        self.auth_info = auth_info
        # 认证方式
        self.auth_type = auth_type
        # 业务扩展
        self.biz_ext = biz_ext
        # 部门名称
        self.department_name = department_name
        # 部门类型
        self.department_type = department_type
        # 部门描述
        self.description = description
        # 业务系统地址
        self.system_url = system_url
        # 创建人工号
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.auth_info is not None:
            result['authInfo'] = self.auth_info
        if self.auth_type is not None:
            result['authType'] = self.auth_type
        if self.biz_ext is not None:
            result['bizExt'] = self.biz_ext
        if self.department_name is not None:
            result['departmentName'] = self.department_name
        if self.department_type is not None:
            result['departmentType'] = self.department_type
        if self.description is not None:
            result['description'] = self.description
        if self.system_url is not None:
            result['systemUrl'] = self.system_url
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('authInfo') is not None:
            self.auth_info = m.get('authInfo')
        if m.get('authType') is not None:
            self.auth_type = m.get('authType')
        if m.get('bizExt') is not None:
            self.biz_ext = m.get('bizExt')
        if m.get('departmentName') is not None:
            self.department_name = m.get('departmentName')
        if m.get('departmentType') is not None:
            self.department_type = m.get('departmentType')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('systemUrl') is not None:
            self.system_url = m.get('systemUrl')
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


class CreateDeviceChatRoomHeaders(TeaModel):
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


class CreateDeviceChatRoomRequest(TeaModel):
    def __init__(
        self,
        chat_type: str = None,
        device_codes: List[str] = None,
        device_uuids: List[str] = None,
        owner_user_id: str = None,
        title: str = None,
        user_ids: List[str] = None,
    ):
        # 场景群类型，不填，为默认普通设备群，示例值--维修群：REPAIR_GROUP，点检群:INSPECT_GROUP,保养群：MAINTAIN_GROUP。
        self.chat_type = chat_type
        # 设备编码，客户侧生成的设备标识，能够唯一标识一个设备，该字段与deviceUuids字段需要二选一，并且不能都填充。
        self.device_codes = device_codes
        # 设备唯一标识，钉钉侧生成的设备标识，能够唯一标识一个设备，该字段与deviceCodes字段需要二选一，并且不能都填充。
        self.device_uuids = device_uuids
        # 群主钉钉账户。
        self.owner_user_id = owner_user_id
        # 设备场景群名称。
        self.title = title
        # 需要被拉入群聊的钉钉账号，可以传多个，通过英文逗号分隔。
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.chat_type is not None:
            result['chatType'] = self.chat_type
        if self.device_codes is not None:
            result['deviceCodes'] = self.device_codes
        if self.device_uuids is not None:
            result['deviceUuids'] = self.device_uuids
        if self.owner_user_id is not None:
            result['ownerUserId'] = self.owner_user_id
        if self.title is not None:
            result['title'] = self.title
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('chatType') is not None:
            self.chat_type = m.get('chatType')
        if m.get('deviceCodes') is not None:
            self.device_codes = m.get('deviceCodes')
        if m.get('deviceUuids') is not None:
            self.device_uuids = m.get('deviceUuids')
        if m.get('ownerUserId') is not None:
            self.owner_user_id = m.get('ownerUserId')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class CreateDeviceChatRoomResponseBodyResult(TeaModel):
    def __init__(
        self,
        chat_id: str = None,
        encoded_cid: str = None,
        open_conversation_id: str = None,
    ):
        self.chat_id = chat_id
        self.encoded_cid = encoded_cid
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.chat_id is not None:
            result['chatId'] = self.chat_id
        if self.encoded_cid is not None:
            result['encodedCid'] = self.encoded_cid
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('chatId') is not None:
            self.chat_id = m.get('chatId')
        if m.get('encodedCid') is not None:
            self.encoded_cid = m.get('encodedCid')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class CreateDeviceChatRoomResponseBody(TeaModel):
    def __init__(
        self,
        result: CreateDeviceChatRoomResponseBodyResult = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = CreateDeviceChatRoomResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class CreateDeviceChatRoomResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateDeviceChatRoomResponseBody = None,
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
            temp_model = CreateDeviceChatRoomResponseBody()
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
        device_key: str = None,
        params_json: str = None,
        receiver_user_id_list: List[str] = None,
    ):
        # 设备标识
        self.device_key = device_key
        # 消息体动态参数
        self.params_json = params_json
        # staffId列表
        self.receiver_user_id_list = receiver_user_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_key is not None:
            result['deviceKey'] = self.device_key
        if self.params_json is not None:
            result['paramsJson'] = self.params_json
        if self.receiver_user_id_list is not None:
            result['receiverUserIdList'] = self.receiver_user_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceKey') is not None:
            self.device_key = m.get('deviceKey')
        if m.get('paramsJson') is not None:
            self.params_json = m.get('paramsJson')
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


class DissolveGroupHeaders(TeaModel):
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


class DissolveGroupRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
    ):
        # 场景群唯一标识，调用创建场景群接口时，会返回该标识。
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class DissolveGroupResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
        success: bool = None,
    ):
        # 接口处理返回结果。
        self.result = result
        # 接口处理是否成功。
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class DissolveGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DissolveGroupResponseBody = None,
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
            temp_model = DissolveGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class EditDeviceAdminHeaders(TeaModel):
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


class EditDeviceAdminRequest(TeaModel):
    def __init__(
        self,
        device_code: str = None,
        role_uuid: str = None,
        user_ids: List[str] = None,
        uuid: str = None,
    ):
        # 需要处理的设备编号。客户侧生成的设备标识，能够唯一标识一个设备，该字段与uuid字段需要二选一，并且不能都填充。
        self.device_code = device_code
        # 角色唯一标识
        self.role_uuid = role_uuid
        # 需要编辑的角色唯一标识，非必填，不传默认为管理员。
        self.user_ids = user_ids
        # 设备唯一标识，钉钉侧生成的设备标识，能够唯一标识一个设备，该字段与deviceCode字段需要二选一，并且不能都填充。
        self.uuid = uuid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_code is not None:
            result['deviceCode'] = self.device_code
        if self.role_uuid is not None:
            result['roleUuid'] = self.role_uuid
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        if self.uuid is not None:
            result['uuid'] = self.uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceCode') is not None:
            self.device_code = m.get('deviceCode')
        if m.get('roleUuid') is not None:
            self.role_uuid = m.get('roleUuid')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        return self


class EditDeviceAdminResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
        success: bool = None,
    ):
        # 接口处理返回结果。
        self.result = result
        # 接口处理是否成功。
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class EditDeviceAdminResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: EditDeviceAdminResponseBody = None,
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
            temp_model = EditDeviceAdminResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetDeviceGroupInfoHeaders(TeaModel):
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


class GetDeviceGroupInfoRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
    ):
        # 开放群唯一标识
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class GetDeviceGroupInfoResponseBodyResultDevices(TeaModel):
    def __init__(
        self,
        device_code: str = None,
        device_name: str = None,
        device_uuid: str = None,
        uuid: str = None,
    ):
        self.device_code = device_code
        self.device_name = device_name
        self.device_uuid = device_uuid
        self.uuid = uuid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_code is not None:
            result['deviceCode'] = self.device_code
        if self.device_name is not None:
            result['deviceName'] = self.device_name
        if self.device_uuid is not None:
            result['deviceUuid'] = self.device_uuid
        if self.uuid is not None:
            result['uuid'] = self.uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceCode') is not None:
            self.device_code = m.get('deviceCode')
        if m.get('deviceName') is not None:
            self.device_name = m.get('deviceName')
        if m.get('deviceUuid') is not None:
            self.device_uuid = m.get('deviceUuid')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        return self


class GetDeviceGroupInfoResponseBodyResult(TeaModel):
    def __init__(
        self,
        devices: List[GetDeviceGroupInfoResponseBodyResultDevices] = None,
        owner_user: str = None,
        sub_admin_users: List[str] = None,
        title: str = None,
        users: Dict[str, str] = None,
    ):
        self.devices = devices
        self.owner_user = owner_user
        self.sub_admin_users = sub_admin_users
        self.title = title
        self.users = users

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
        result['devices'] = []
        if self.devices is not None:
            for k in self.devices:
                result['devices'].append(k.to_map() if k else None)
        if self.owner_user is not None:
            result['ownerUser'] = self.owner_user
        if self.sub_admin_users is not None:
            result['subAdminUsers'] = self.sub_admin_users
        if self.title is not None:
            result['title'] = self.title
        if self.users is not None:
            result['users'] = self.users
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.devices = []
        if m.get('devices') is not None:
            for k in m.get('devices'):
                temp_model = GetDeviceGroupInfoResponseBodyResultDevices()
                self.devices.append(temp_model.from_map(k))
        if m.get('ownerUser') is not None:
            self.owner_user = m.get('ownerUser')
        if m.get('subAdminUsers') is not None:
            self.sub_admin_users = m.get('subAdminUsers')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('users') is not None:
            self.users = m.get('users')
        return self


class GetDeviceGroupInfoResponseBody(TeaModel):
    def __init__(
        self,
        result: GetDeviceGroupInfoResponseBodyResult = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = GetDeviceGroupInfoResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetDeviceGroupInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetDeviceGroupInfoResponseBody = None,
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
            temp_model = GetDeviceGroupInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetWholeDeviceGroupHeaders(TeaModel):
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


class GetWholeDeviceGroupResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetWholeDeviceGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetWholeDeviceGroupResponseBody = None,
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
            temp_model = GetWholeDeviceGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListActivateDevicesHeaders(TeaModel):
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


class ListActivateDevicesRequest(TeaModel):
    def __init__(
        self,
        device_category: int = None,
        device_code: str = None,
        device_type_id: str = None,
        group_id: str = None,
        page_number: int = None,
        page_size: int = None,
    ):
        # 设备分类（0：设备，1 : 助手）
        self.device_category = device_category
        # deviceCode
        self.device_code = device_code
        # deviceTypeId
        self.device_type_id = device_type_id
        # groupId
        self.group_id = group_id
        # pageNo
        self.page_number = page_number
        # pageSize
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_category is not None:
            result['deviceCategory'] = self.device_category
        if self.device_code is not None:
            result['deviceCode'] = self.device_code
        if self.device_type_id is not None:
            result['deviceTypeId'] = self.device_type_id
        if self.group_id is not None:
            result['groupId'] = self.group_id
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceCategory') is not None:
            self.device_category = m.get('deviceCategory')
        if m.get('deviceCode') is not None:
            self.device_code = m.get('deviceCode')
        if m.get('deviceTypeId') is not None:
            self.device_type_id = m.get('deviceTypeId')
        if m.get('groupId') is not None:
            self.group_id = m.get('groupId')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class ListActivateDevicesResponseBodyResult(TeaModel):
    def __init__(
        self,
        biz_ext: str = None,
        device_callback_url: str = None,
        device_category: int = None,
        device_code: str = None,
        device_detail_url: str = None,
        device_name: str = None,
        group_uuid: str = None,
        icon: str = None,
        introduction: str = None,
        type_uuid: str = None,
        uuid: str = None,
    ):
        self.biz_ext = biz_ext
        self.device_callback_url = device_callback_url
        self.device_category = device_category
        self.device_code = device_code
        self.device_detail_url = device_detail_url
        self.device_name = device_name
        self.group_uuid = group_uuid
        self.icon = icon
        self.introduction = introduction
        self.type_uuid = type_uuid
        self.uuid = uuid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_ext is not None:
            result['bizExt'] = self.biz_ext
        if self.device_callback_url is not None:
            result['deviceCallbackUrl'] = self.device_callback_url
        if self.device_category is not None:
            result['deviceCategory'] = self.device_category
        if self.device_code is not None:
            result['deviceCode'] = self.device_code
        if self.device_detail_url is not None:
            result['deviceDetailUrl'] = self.device_detail_url
        if self.device_name is not None:
            result['deviceName'] = self.device_name
        if self.group_uuid is not None:
            result['groupUuid'] = self.group_uuid
        if self.icon is not None:
            result['icon'] = self.icon
        if self.introduction is not None:
            result['introduction'] = self.introduction
        if self.type_uuid is not None:
            result['typeUuid'] = self.type_uuid
        if self.uuid is not None:
            result['uuid'] = self.uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizExt') is not None:
            self.biz_ext = m.get('bizExt')
        if m.get('deviceCallbackUrl') is not None:
            self.device_callback_url = m.get('deviceCallbackUrl')
        if m.get('deviceCategory') is not None:
            self.device_category = m.get('deviceCategory')
        if m.get('deviceCode') is not None:
            self.device_code = m.get('deviceCode')
        if m.get('deviceDetailUrl') is not None:
            self.device_detail_url = m.get('deviceDetailUrl')
        if m.get('deviceName') is not None:
            self.device_name = m.get('deviceName')
        if m.get('groupUuid') is not None:
            self.group_uuid = m.get('groupUuid')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('introduction') is not None:
            self.introduction = m.get('introduction')
        if m.get('typeUuid') is not None:
            self.type_uuid = m.get('typeUuid')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        return self


class ListActivateDevicesResponseBody(TeaModel):
    def __init__(
        self,
        result: List[ListActivateDevicesResponseBodyResult] = None,
        success: bool = None,
        total_count: int = None,
    ):
        self.result = result
        self.success = success
        self.total_count = total_count

    def validate(self):
        if self.result:
            for k in self.result:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['result'] = []
        if self.result is not None:
            for k in self.result:
                result['result'].append(k.to_map() if k else None)
        if self.success is not None:
            result['success'] = self.success
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = ListActivateDevicesResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        if m.get('success') is not None:
            self.success = m.get('success')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class ListActivateDevicesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListActivateDevicesResponseBody = None,
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
            temp_model = ListActivateDevicesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PullDeviceToGroupHeaders(TeaModel):
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


class PullDeviceToGroupRequest(TeaModel):
    def __init__(
        self,
        device_codes: List[str] = None,
        device_uuids: List[str] = None,
        open_conversation_id: str = None,
        operator: str = None,
    ):
        # 设备业务标识
        self.device_codes = device_codes
        # 设备uuid，系统唯一标识
        self.device_uuids = device_uuids
        # 群id，群的唯一标识
        self.open_conversation_id = open_conversation_id
        # 操作人userId
        self.operator = operator

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_codes is not None:
            result['deviceCodes'] = self.device_codes
        if self.device_uuids is not None:
            result['deviceUuids'] = self.device_uuids
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.operator is not None:
            result['operator'] = self.operator
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceCodes') is not None:
            self.device_codes = m.get('deviceCodes')
        if m.get('deviceUuids') is not None:
            self.device_uuids = m.get('deviceUuids')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        return self


class PullDeviceToGroupResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class PullDeviceToGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: PullDeviceToGroupResponseBody = None,
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
            temp_model = PullDeviceToGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PullUserToGroupHeaders(TeaModel):
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


class PullUserToGroupRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        user_ids: List[str] = None,
    ):
        # 开放群唯一标识
        self.open_conversation_id = open_conversation_id
        # 入群用户唯一标识列表
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class PullUserToGroupResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class PullUserToGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: PullUserToGroupResponseBody = None,
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
            temp_model = PullUserToGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RegisterAndActivateDeviceHeaders(TeaModel):
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


class RegisterAndActivateDeviceRequest(TeaModel):
    def __init__(
        self,
        device_callback_url: str = None,
        device_category: int = None,
        device_code: str = None,
        device_detail_url: str = None,
        device_name: str = None,
        introduction: str = None,
        role_uuid: str = None,
        type_uuid: str = None,
        user_ids: List[str] = None,
    ):
        self.device_callback_url = device_callback_url
        # 设备分类（0：设备，1 : 助手）
        self.device_category = device_category
        self.device_code = device_code
        self.device_detail_url = device_detail_url
        self.device_name = device_name
        self.introduction = introduction
        self.role_uuid = role_uuid
        self.type_uuid = type_uuid
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_callback_url is not None:
            result['deviceCallbackUrl'] = self.device_callback_url
        if self.device_category is not None:
            result['deviceCategory'] = self.device_category
        if self.device_code is not None:
            result['deviceCode'] = self.device_code
        if self.device_detail_url is not None:
            result['deviceDetailUrl'] = self.device_detail_url
        if self.device_name is not None:
            result['deviceName'] = self.device_name
        if self.introduction is not None:
            result['introduction'] = self.introduction
        if self.role_uuid is not None:
            result['roleUuid'] = self.role_uuid
        if self.type_uuid is not None:
            result['typeUuid'] = self.type_uuid
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceCallbackUrl') is not None:
            self.device_callback_url = m.get('deviceCallbackUrl')
        if m.get('deviceCategory') is not None:
            self.device_category = m.get('deviceCategory')
        if m.get('deviceCode') is not None:
            self.device_code = m.get('deviceCode')
        if m.get('deviceDetailUrl') is not None:
            self.device_detail_url = m.get('deviceDetailUrl')
        if m.get('deviceName') is not None:
            self.device_name = m.get('deviceName')
        if m.get('introduction') is not None:
            self.introduction = m.get('introduction')
        if m.get('roleUuid') is not None:
            self.role_uuid = m.get('roleUuid')
        if m.get('typeUuid') is not None:
            self.type_uuid = m.get('typeUuid')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class RegisterAndActivateDeviceResponseBodyResult(TeaModel):
    def __init__(
        self,
        device_category: int = None,
        device_code: str = None,
        device_detail_url: str = None,
        device_name: str = None,
        device_uuid: str = None,
        introduction: str = None,
        role_uuid: str = None,
        type_uuid: str = None,
        user_ids: List[str] = None,
    ):
        self.device_category = device_category
        self.device_code = device_code
        self.device_detail_url = device_detail_url
        self.device_name = device_name
        self.device_uuid = device_uuid
        self.introduction = introduction
        self.role_uuid = role_uuid
        self.type_uuid = type_uuid
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_category is not None:
            result['deviceCategory'] = self.device_category
        if self.device_code is not None:
            result['deviceCode'] = self.device_code
        if self.device_detail_url is not None:
            result['deviceDetailUrl'] = self.device_detail_url
        if self.device_name is not None:
            result['deviceName'] = self.device_name
        if self.device_uuid is not None:
            result['deviceUuid'] = self.device_uuid
        if self.introduction is not None:
            result['introduction'] = self.introduction
        if self.role_uuid is not None:
            result['roleUuid'] = self.role_uuid
        if self.type_uuid is not None:
            result['typeUuid'] = self.type_uuid
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceCategory') is not None:
            self.device_category = m.get('deviceCategory')
        if m.get('deviceCode') is not None:
            self.device_code = m.get('deviceCode')
        if m.get('deviceDetailUrl') is not None:
            self.device_detail_url = m.get('deviceDetailUrl')
        if m.get('deviceName') is not None:
            self.device_name = m.get('deviceName')
        if m.get('deviceUuid') is not None:
            self.device_uuid = m.get('deviceUuid')
        if m.get('introduction') is not None:
            self.introduction = m.get('introduction')
        if m.get('roleUuid') is not None:
            self.role_uuid = m.get('roleUuid')
        if m.get('typeUuid') is not None:
            self.type_uuid = m.get('typeUuid')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class RegisterAndActivateDeviceResponseBody(TeaModel):
    def __init__(
        self,
        result: RegisterAndActivateDeviceResponseBodyResult = None,
        success: bool = None,
    ):
        self.result = result
        # Id of the request
        self.success = success

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = RegisterAndActivateDeviceResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class RegisterAndActivateDeviceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: RegisterAndActivateDeviceResponseBody = None,
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
            temp_model = RegisterAndActivateDeviceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RegisterAndActivateDeviceBatchHeaders(TeaModel):
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


class RegisterAndActivateDeviceBatchRequestRegisterAndActivateVOS(TeaModel):
    def __init__(
        self,
        device_callback_url: str = None,
        device_category: int = None,
        device_code: str = None,
        device_detail_url: str = None,
        device_name: str = None,
        group_uuid: str = None,
        introduction: str = None,
        role_uuid: str = None,
        type_uuid: str = None,
        user_ids: List[str] = None,
    ):
        self.device_callback_url = device_callback_url
        # 设备分类（0：设备，1 : 助手）
        self.device_category = device_category
        self.device_code = device_code
        self.device_detail_url = device_detail_url
        self.device_name = device_name
        self.group_uuid = group_uuid
        self.introduction = introduction
        self.role_uuid = role_uuid
        self.type_uuid = type_uuid
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_callback_url is not None:
            result['deviceCallbackUrl'] = self.device_callback_url
        if self.device_category is not None:
            result['deviceCategory'] = self.device_category
        if self.device_code is not None:
            result['deviceCode'] = self.device_code
        if self.device_detail_url is not None:
            result['deviceDetailUrl'] = self.device_detail_url
        if self.device_name is not None:
            result['deviceName'] = self.device_name
        if self.group_uuid is not None:
            result['groupUuid'] = self.group_uuid
        if self.introduction is not None:
            result['introduction'] = self.introduction
        if self.role_uuid is not None:
            result['roleUuid'] = self.role_uuid
        if self.type_uuid is not None:
            result['typeUuid'] = self.type_uuid
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceCallbackUrl') is not None:
            self.device_callback_url = m.get('deviceCallbackUrl')
        if m.get('deviceCategory') is not None:
            self.device_category = m.get('deviceCategory')
        if m.get('deviceCode') is not None:
            self.device_code = m.get('deviceCode')
        if m.get('deviceDetailUrl') is not None:
            self.device_detail_url = m.get('deviceDetailUrl')
        if m.get('deviceName') is not None:
            self.device_name = m.get('deviceName')
        if m.get('groupUuid') is not None:
            self.group_uuid = m.get('groupUuid')
        if m.get('introduction') is not None:
            self.introduction = m.get('introduction')
        if m.get('roleUuid') is not None:
            self.role_uuid = m.get('roleUuid')
        if m.get('typeUuid') is not None:
            self.type_uuid = m.get('typeUuid')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class RegisterAndActivateDeviceBatchRequest(TeaModel):
    def __init__(
        self,
        register_and_activate_vos: List[RegisterAndActivateDeviceBatchRequestRegisterAndActivateVOS] = None,
    ):
        self.register_and_activate_vos = register_and_activate_vos

    def validate(self):
        if self.register_and_activate_vos:
            for k in self.register_and_activate_vos:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['registerAndActivateVOS'] = []
        if self.register_and_activate_vos is not None:
            for k in self.register_and_activate_vos:
                result['registerAndActivateVOS'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.register_and_activate_vos = []
        if m.get('registerAndActivateVOS') is not None:
            for k in m.get('registerAndActivateVOS'):
                temp_model = RegisterAndActivateDeviceBatchRequestRegisterAndActivateVOS()
                self.register_and_activate_vos.append(temp_model.from_map(k))
        return self


class RegisterAndActivateDeviceBatchResponseBodyFailItemsResult(TeaModel):
    def __init__(
        self,
        device_callback_url: str = None,
        device_category: int = None,
        device_code: str = None,
        device_detail_url: str = None,
        device_name: str = None,
        group_uuid: str = None,
        icon: str = None,
        introduction: str = None,
        role_uuid: str = None,
        status: int = None,
        type_uuid: str = None,
        user_ids: List[str] = None,
        uuid: str = None,
    ):
        self.device_callback_url = device_callback_url
        self.device_category = device_category
        self.device_code = device_code
        self.device_detail_url = device_detail_url
        self.device_name = device_name
        self.group_uuid = group_uuid
        self.icon = icon
        self.introduction = introduction
        self.role_uuid = role_uuid
        self.status = status
        self.type_uuid = type_uuid
        self.user_ids = user_ids
        self.uuid = uuid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_callback_url is not None:
            result['deviceCallbackUrl'] = self.device_callback_url
        if self.device_category is not None:
            result['deviceCategory'] = self.device_category
        if self.device_code is not None:
            result['deviceCode'] = self.device_code
        if self.device_detail_url is not None:
            result['deviceDetailUrl'] = self.device_detail_url
        if self.device_name is not None:
            result['deviceName'] = self.device_name
        if self.group_uuid is not None:
            result['groupUuid'] = self.group_uuid
        if self.icon is not None:
            result['icon'] = self.icon
        if self.introduction is not None:
            result['introduction'] = self.introduction
        if self.role_uuid is not None:
            result['roleUuid'] = self.role_uuid
        if self.status is not None:
            result['status'] = self.status
        if self.type_uuid is not None:
            result['typeUuid'] = self.type_uuid
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        if self.uuid is not None:
            result['uuid'] = self.uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceCallbackUrl') is not None:
            self.device_callback_url = m.get('deviceCallbackUrl')
        if m.get('deviceCategory') is not None:
            self.device_category = m.get('deviceCategory')
        if m.get('deviceCode') is not None:
            self.device_code = m.get('deviceCode')
        if m.get('deviceDetailUrl') is not None:
            self.device_detail_url = m.get('deviceDetailUrl')
        if m.get('deviceName') is not None:
            self.device_name = m.get('deviceName')
        if m.get('groupUuid') is not None:
            self.group_uuid = m.get('groupUuid')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('introduction') is not None:
            self.introduction = m.get('introduction')
        if m.get('roleUuid') is not None:
            self.role_uuid = m.get('roleUuid')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('typeUuid') is not None:
            self.type_uuid = m.get('typeUuid')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        return self


class RegisterAndActivateDeviceBatchResponseBodyFailItems(TeaModel):
    def __init__(
        self,
        error_code: str = None,
        error_msg: str = None,
        result: RegisterAndActivateDeviceBatchResponseBodyFailItemsResult = None,
        success: bool = None,
    ):
        self.error_code = error_code
        self.error_msg = error_msg
        self.result = result
        self.success = success

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.result is not None:
            result['result'] = self.result.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('result') is not None:
            temp_model = RegisterAndActivateDeviceBatchResponseBodyFailItemsResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class RegisterAndActivateDeviceBatchResponseBodySuccessItemsResult(TeaModel):
    def __init__(
        self,
        device_callback_url: str = None,
        device_category: int = None,
        device_code: str = None,
        device_detail_url: str = None,
        device_name: str = None,
        group_uuid: str = None,
        icon: str = None,
        introduction: str = None,
        role_uuid: str = None,
        status: int = None,
        type_uuid: str = None,
        user_ids: List[str] = None,
        uuid: str = None,
    ):
        self.device_callback_url = device_callback_url
        self.device_category = device_category
        self.device_code = device_code
        self.device_detail_url = device_detail_url
        self.device_name = device_name
        self.group_uuid = group_uuid
        self.icon = icon
        self.introduction = introduction
        self.role_uuid = role_uuid
        self.status = status
        self.type_uuid = type_uuid
        self.user_ids = user_ids
        self.uuid = uuid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_callback_url is not None:
            result['deviceCallbackUrl'] = self.device_callback_url
        if self.device_category is not None:
            result['deviceCategory'] = self.device_category
        if self.device_code is not None:
            result['deviceCode'] = self.device_code
        if self.device_detail_url is not None:
            result['deviceDetailUrl'] = self.device_detail_url
        if self.device_name is not None:
            result['deviceName'] = self.device_name
        if self.group_uuid is not None:
            result['groupUuid'] = self.group_uuid
        if self.icon is not None:
            result['icon'] = self.icon
        if self.introduction is not None:
            result['introduction'] = self.introduction
        if self.role_uuid is not None:
            result['roleUuid'] = self.role_uuid
        if self.status is not None:
            result['status'] = self.status
        if self.type_uuid is not None:
            result['typeUuid'] = self.type_uuid
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        if self.uuid is not None:
            result['uuid'] = self.uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceCallbackUrl') is not None:
            self.device_callback_url = m.get('deviceCallbackUrl')
        if m.get('deviceCategory') is not None:
            self.device_category = m.get('deviceCategory')
        if m.get('deviceCode') is not None:
            self.device_code = m.get('deviceCode')
        if m.get('deviceDetailUrl') is not None:
            self.device_detail_url = m.get('deviceDetailUrl')
        if m.get('deviceName') is not None:
            self.device_name = m.get('deviceName')
        if m.get('groupUuid') is not None:
            self.group_uuid = m.get('groupUuid')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('introduction') is not None:
            self.introduction = m.get('introduction')
        if m.get('roleUuid') is not None:
            self.role_uuid = m.get('roleUuid')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('typeUuid') is not None:
            self.type_uuid = m.get('typeUuid')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        return self


class RegisterAndActivateDeviceBatchResponseBodySuccessItems(TeaModel):
    def __init__(
        self,
        error_code: str = None,
        error_msg: str = None,
        result: RegisterAndActivateDeviceBatchResponseBodySuccessItemsResult = None,
        success: bool = None,
    ):
        self.error_code = error_code
        self.error_msg = error_msg
        self.result = result
        self.success = success

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.result is not None:
            result['result'] = self.result.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('result') is not None:
            temp_model = RegisterAndActivateDeviceBatchResponseBodySuccessItemsResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class RegisterAndActivateDeviceBatchResponseBody(TeaModel):
    def __init__(
        self,
        fail_items: List[RegisterAndActivateDeviceBatchResponseBodyFailItems] = None,
        success: bool = None,
        success_items: List[RegisterAndActivateDeviceBatchResponseBodySuccessItems] = None,
    ):
        self.fail_items = fail_items
        self.success = success
        self.success_items = success_items

    def validate(self):
        if self.fail_items:
            for k in self.fail_items:
                if k:
                    k.validate()
        if self.success_items:
            for k in self.success_items:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['failItems'] = []
        if self.fail_items is not None:
            for k in self.fail_items:
                result['failItems'].append(k.to_map() if k else None)
        if self.success is not None:
            result['success'] = self.success
        result['successItems'] = []
        if self.success_items is not None:
            for k in self.success_items:
                result['successItems'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.fail_items = []
        if m.get('failItems') is not None:
            for k in m.get('failItems'):
                temp_model = RegisterAndActivateDeviceBatchResponseBodyFailItems()
                self.fail_items.append(temp_model.from_map(k))
        if m.get('success') is not None:
            self.success = m.get('success')
        self.success_items = []
        if m.get('successItems') is not None:
            for k in m.get('successItems'):
                temp_model = RegisterAndActivateDeviceBatchResponseBodySuccessItems()
                self.success_items.append(temp_model.from_map(k))
        return self


class RegisterAndActivateDeviceBatchResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: RegisterAndActivateDeviceBatchResponseBody = None,
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
            temp_model = RegisterAndActivateDeviceBatchResponseBody()
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


class RegisterDeviceRequest(TeaModel):
    def __init__(
        self,
        collaborators: str = None,
        department_id: int = None,
        description: str = None,
        device_key: str = None,
        device_name: str = None,
        managers: str = None,
        user_id: str = None,
    ):
        # 协助者userId列表
        self.collaborators = collaborators
        # 部门id
        self.department_id = department_id
        # 设备描述
        self.description = description
        # 设备标识
        self.device_key = device_key
        # 设备名称
        self.device_name = device_name
        # 管理员userId列表
        self.managers = managers
        # 创建者userId
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.collaborators is not None:
            result['collaborators'] = self.collaborators
        if self.department_id is not None:
            result['departmentId'] = self.department_id
        if self.description is not None:
            result['description'] = self.description
        if self.device_key is not None:
            result['deviceKey'] = self.device_key
        if self.device_name is not None:
            result['deviceName'] = self.device_name
        if self.managers is not None:
            result['managers'] = self.managers
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('collaborators') is not None:
            self.collaborators = m.get('collaborators')
        if m.get('departmentId') is not None:
            self.department_id = m.get('departmentId')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('deviceKey') is not None:
            self.device_key = m.get('deviceKey')
        if m.get('deviceName') is not None:
            self.device_name = m.get('deviceName')
        if m.get('managers') is not None:
            self.managers = m.get('managers')
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


class RemoveDeviceFromGroupHeaders(TeaModel):
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


class RemoveDeviceFromGroupRequest(TeaModel):
    def __init__(
        self,
        device_codes: List[str] = None,
        device_uuids: List[str] = None,
        open_conversation_id: str = None,
        operator: str = None,
    ):
        # 设备编号列表（与设备唯一标识列表二选一）
        self.device_codes = device_codes
        # 设备唯一标识列表（与设备编码列表二选一）
        self.device_uuids = device_uuids
        # 开放群唯一标识
        self.open_conversation_id = open_conversation_id
        # 操作人唯一标识
        self.operator = operator

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_codes is not None:
            result['deviceCodes'] = self.device_codes
        if self.device_uuids is not None:
            result['deviceUuids'] = self.device_uuids
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.operator is not None:
            result['operator'] = self.operator
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceCodes') is not None:
            self.device_codes = m.get('deviceCodes')
        if m.get('deviceUuids') is not None:
            self.device_uuids = m.get('deviceUuids')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        return self


class RemoveDeviceFromGroupResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class RemoveDeviceFromGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: RemoveDeviceFromGroupResponseBody = None,
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
            temp_model = RemoveDeviceFromGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RemoveUserFromGroupHeaders(TeaModel):
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


class RemoveUserFromGroupRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        user_ids: List[str] = None,
    ):
        # 开放群唯一标识
        self.open_conversation_id = open_conversation_id
        # 用户唯一标识列表
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class RemoveUserFromGroupResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class RemoveUserFromGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: RemoveUserFromGroupResponseBody = None,
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
            temp_model = RemoveUserFromGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SendCardHeaders(TeaModel):
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


class SendCardRequest(TeaModel):
    def __init__(
        self,
        biz_id: str = None,
        card_data: str = None,
        device_code: str = None,
        device_uuid: str = None,
        open_conversation_id: str = None,
        part_visible: bool = None,
        receivers: List[str] = None,
        template_id: str = None,
        topbox: bool = None,
        user_id: str = None,
    ):
        # 卡片实例唯一标识
        self.biz_id = biz_id
        # 卡片变量赋值，json结构
        self.card_data = card_data
        # 设备业务标识
        self.device_code = device_code
        # 设备uuid，唯一标识
        self.device_uuid = device_uuid
        # 群id，群的唯一标识
        self.open_conversation_id = open_conversation_id
        # 卡片是否群内部分人员可见
        self.part_visible = part_visible
        # 群内指定人员可见
        self.receivers = receivers
        # 卡片模板唯一标识，开放平台获取
        self.template_id = template_id
        # 是否为吊顶卡片
        self.topbox = topbox
        # 用户通讯录唯一标识
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_id is not None:
            result['bizId'] = self.biz_id
        if self.card_data is not None:
            result['cardData'] = self.card_data
        if self.device_code is not None:
            result['deviceCode'] = self.device_code
        if self.device_uuid is not None:
            result['deviceUuid'] = self.device_uuid
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.part_visible is not None:
            result['partVisible'] = self.part_visible
        if self.receivers is not None:
            result['receivers'] = self.receivers
        if self.template_id is not None:
            result['templateId'] = self.template_id
        if self.topbox is not None:
            result['topbox'] = self.topbox
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        if m.get('cardData') is not None:
            self.card_data = m.get('cardData')
        if m.get('deviceCode') is not None:
            self.device_code = m.get('deviceCode')
        if m.get('deviceUuid') is not None:
            self.device_uuid = m.get('deviceUuid')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('partVisible') is not None:
            self.part_visible = m.get('partVisible')
        if m.get('receivers') is not None:
            self.receivers = m.get('receivers')
        if m.get('templateId') is not None:
            self.template_id = m.get('templateId')
        if m.get('topbox') is not None:
            self.topbox = m.get('topbox')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class SendCardResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
        success: bool = None,
    ):
        # result
        self.result = result
        # success
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class SendCardResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SendCardResponseBody = None,
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
            temp_model = SendCardResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SendMsgHeaders(TeaModel):
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


class SendMsgRequest(TeaModel):
    def __init__(
        self,
        content: str = None,
        device_code: str = None,
        device_uuid: str = None,
        open_conversation_id: str = None,
        user_list: List[str] = None,
    ):
        # 消息内容
        self.content = content
        # 设备业务标识
        self.device_code = device_code
        # 设备唯一系统标识
        self.device_uuid = device_uuid
        # 开放群唯一标识
        self.open_conversation_id = open_conversation_id
        # 用户列表，群聊时为被@的人，单聊时为目标对象
        self.user_list = user_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.device_code is not None:
            result['deviceCode'] = self.device_code
        if self.device_uuid is not None:
            result['deviceUuid'] = self.device_uuid
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.user_list is not None:
            result['userList'] = self.user_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('deviceCode') is not None:
            self.device_code = m.get('deviceCode')
        if m.get('deviceUuid') is not None:
            self.device_uuid = m.get('deviceUuid')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('userList') is not None:
            self.user_list = m.get('userList')
        return self


class SendMsgResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class SendMsgResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SendMsgResponseBody = None,
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
            temp_model = SendMsgResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UninstallDeviceRobotHeaders(TeaModel):
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


class UninstallDeviceRobotRequest(TeaModel):
    def __init__(
        self,
        device_code: str = None,
        uuid: str = None,
    ):
        # 设备编码，客户侧生成的设备标识，能够唯一标识一个设备，该字段与deviceUuid字段需要二选一，并且不能都填充。
        self.device_code = device_code
        # 设备唯一标识，钉钉侧生成的设备标识，能够唯一标识一个设备，该字段与deviceCode字段需要二选一，并且不能都填充。
        self.uuid = uuid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_code is not None:
            result['deviceCode'] = self.device_code
        if self.uuid is not None:
            result['uuid'] = self.uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceCode') is not None:
            self.device_code = m.get('deviceCode')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        return self


class UninstallDeviceRobotResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
        success: bool = None,
    ):
        # 接口处理返回结果，内容为群的唯一标识。
        self.result = result
        # 接口处理是否成功。
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class UninstallDeviceRobotResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UninstallDeviceRobotResponseBody = None,
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
            temp_model = UninstallDeviceRobotResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateCardHeaders(TeaModel):
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


class UpdateCardRequestTips(TeaModel):
    def __init__(
        self,
        cids: str = None,
        content: str = None,
        sender: str = None,
    ):
        # 系统通知的群组
        self.cids = cids
        # 系统通知内容
        self.content = content
        # 发送人
        self.sender = sender

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cids is not None:
            result['cids'] = self.cids
        if self.content is not None:
            result['content'] = self.content
        if self.sender is not None:
            result['sender'] = self.sender
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cids') is not None:
            self.cids = m.get('cids')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('sender') is not None:
            self.sender = m.get('sender')
        return self


class UpdateCardRequest(TeaModel):
    def __init__(
        self,
        biz_id: str = None,
        card_data: str = None,
        tips: UpdateCardRequestTips = None,
    ):
        # 卡片实例唯一标识
        self.biz_id = biz_id
        # 卡片变量赋值，json结构
        self.card_data = card_data
        # 卡片更新群系统通知
        self.tips = tips

    def validate(self):
        if self.tips:
            self.tips.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_id is not None:
            result['bizId'] = self.biz_id
        if self.card_data is not None:
            result['cardData'] = self.card_data
        if self.tips is not None:
            result['tips'] = self.tips.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        if m.get('cardData') is not None:
            self.card_data = m.get('cardData')
        if m.get('tips') is not None:
            temp_model = UpdateCardRequestTips()
            self.tips = temp_model.from_map(m['tips'])
        return self


class UpdateCardResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
        success: bool = None,
    ):
        self.result = result
        # 是否成功
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class UpdateCardResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateCardResponseBody = None,
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
            temp_model = UpdateCardResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UploadEventHeaders(TeaModel):
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


class UploadEventRequest(TeaModel):
    def __init__(
        self,
        content: str = None,
        cover_url: str = None,
        device_code: str = None,
        device_uuid: str = None,
        event_time: str = None,
        event_type: str = None,
        level: str = None,
    ):
        self.content = content
        self.cover_url = cover_url
        self.device_code = device_code
        self.device_uuid = device_uuid
        self.event_time = event_time
        self.event_type = event_type
        self.level = level

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.cover_url is not None:
            result['coverUrl'] = self.cover_url
        if self.device_code is not None:
            result['deviceCode'] = self.device_code
        if self.device_uuid is not None:
            result['deviceUuid'] = self.device_uuid
        if self.event_time is not None:
            result['eventTime'] = self.event_time
        if self.event_type is not None:
            result['eventType'] = self.event_type
        if self.level is not None:
            result['level'] = self.level
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('coverUrl') is not None:
            self.cover_url = m.get('coverUrl')
        if m.get('deviceCode') is not None:
            self.device_code = m.get('deviceCode')
        if m.get('deviceUuid') is not None:
            self.device_uuid = m.get('deviceUuid')
        if m.get('eventTime') is not None:
            self.event_time = m.get('eventTime')
        if m.get('eventType') is not None:
            self.event_type = m.get('eventType')
        if m.get('level') is not None:
            self.level = m.get('level')
        return self


class UploadEventResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class UploadEventResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UploadEventResponseBody = None,
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
            temp_model = UploadEventResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


