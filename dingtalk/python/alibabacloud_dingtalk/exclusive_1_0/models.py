# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List, Any


class AddOrgHeaders(TeaModel):
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


class AddOrgRequest(TeaModel):
    def __init__(
        self,
        mobile_num: str = None,
        name: str = None,
    ):
        # 手机号
        self.mobile_num = mobile_num
        # 组织名称
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.mobile_num is not None:
            result['mobileNum'] = self.mobile_num
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('mobileNum') is not None:
            self.mobile_num = m.get('mobileNum')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class AddOrgResponseBody(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
    ):
        # 组织id
        self.corp_id = corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        return self


class AddOrgResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: AddOrgResponseBody = None,
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
            temp_model = AddOrgResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BanOrOpenGroupWordsHeaders(TeaModel):
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


class BanOrOpenGroupWordsRequest(TeaModel):
    def __init__(
        self,
        ban_words_type: int = None,
        open_converation_id: str = None,
    ):
        # 操作类型:0 不禁言;1:禁言
        self.ban_words_type = ban_words_type
        # 群id
        self.open_converation_id = open_converation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ban_words_type is not None:
            result['banWordsType'] = self.ban_words_type
        if self.open_converation_id is not None:
            result['openConverationId'] = self.open_converation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('banWordsType') is not None:
            self.ban_words_type = m.get('banWordsType')
        if m.get('openConverationId') is not None:
            self.open_converation_id = m.get('openConverationId')
        return self


class BanOrOpenGroupWordsResponseBody(TeaModel):
    def __init__(
        self,
        cause: str = None,
        code: str = None,
    ):
        # 原因
        self.cause = cause
        # 返回码
        self.code = code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cause is not None:
            result['cause'] = self.cause
        if self.code is not None:
            result['code'] = self.code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cause') is not None:
            self.cause = m.get('cause')
        if m.get('code') is not None:
            self.code = m.get('code')
        return self


class BanOrOpenGroupWordsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: BanOrOpenGroupWordsResponseBody = None,
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
            temp_model = BanOrOpenGroupWordsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateTrustedDeviceHeaders(TeaModel):
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


class CreateTrustedDeviceRequest(TeaModel):
    def __init__(
        self,
        did: str = None,
        mac_address: str = None,
        platform: str = None,
        status: int = None,
        user_id: str = None,
    ):
        # 支持SDK集成的设备唯一标识。
        self.did = did
        # mac地址
        self.mac_address = mac_address
        # 平台类型
        self.platform = platform
        # 设备状态
        self.status = status
        # 员工userId
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.did is not None:
            result['did'] = self.did
        if self.mac_address is not None:
            result['macAddress'] = self.mac_address
        if self.platform is not None:
            result['platform'] = self.platform
        if self.status is not None:
            result['status'] = self.status
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('did') is not None:
            self.did = m.get('did')
        if m.get('macAddress') is not None:
            self.mac_address = m.get('macAddress')
        if m.get('platform') is not None:
            self.platform = m.get('platform')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CreateTrustedDeviceResponseBody(TeaModel):
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


class CreateTrustedDeviceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateTrustedDeviceResponseBody = None,
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
            temp_model = CreateTrustedDeviceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateTrustedDeviceBatchHeaders(TeaModel):
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


class CreateTrustedDeviceBatchRequest(TeaModel):
    def __init__(
        self,
        mac_address_list: List[str] = None,
        platform: str = None,
        user_id: str = None,
    ):
        # mac地址列表
        self.mac_address_list = mac_address_list
        # 平台
        self.platform = platform
        # 员工id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.mac_address_list is not None:
            result['macAddressList'] = self.mac_address_list
        if self.platform is not None:
            result['platform'] = self.platform
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('macAddressList') is not None:
            self.mac_address_list = m.get('macAddressList')
        if m.get('platform') is not None:
            self.platform = m.get('platform')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CreateTrustedDeviceBatchResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        # 处理结果
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


class CreateTrustedDeviceBatchResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateTrustedDeviceBatchResponseBody = None,
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
            temp_model = CreateTrustedDeviceBatchResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteAcrossCloudStroageConfigsHeaders(TeaModel):
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


class DeleteAcrossCloudStroageConfigsResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        # 执行结果
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


class DeleteAcrossCloudStroageConfigsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DeleteAcrossCloudStroageConfigsResponseBody = None,
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
            temp_model = DeleteAcrossCloudStroageConfigsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteCommentHeaders(TeaModel):
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


class DeleteCommentResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: bool = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            self.body = m.get('body')
        return self


class DistributePartnerAppHeaders(TeaModel):
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


class DistributePartnerAppRequest(TeaModel):
    def __init__(
        self,
        app_id: int = None,
        dept_id: int = None,
        sub_corp_id: str = None,
        type: int = None,
    ):
        # 应用id
        self.app_id = app_id
        self.dept_id = dept_id
        self.sub_corp_id = sub_corp_id
        # 分发对象类型
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.sub_corp_id is not None:
            result['subCorpId'] = self.sub_corp_id
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('subCorpId') is not None:
            self.sub_corp_id = m.get('subCorpId')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class DistributePartnerAppResponseBody(TeaModel):
    def __init__(
        self,
        invite_url: str = None,
    ):
        # 安装邀请链接
        self.invite_url = invite_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.invite_url is not None:
            result['inviteUrl'] = self.invite_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('inviteUrl') is not None:
            self.invite_url = m.get('inviteUrl')
        return self


class DistributePartnerAppResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DistributePartnerAppResponseBody = None,
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
            temp_model = DistributePartnerAppResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ExclusiveCreateDingPortalHeaders(TeaModel):
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


class ExclusiveCreateDingPortalRequest(TeaModel):
    def __init__(
        self,
        ding_portal_name: str = None,
        target_corp_id: str = None,
        template_app_uuid: str = None,
        template_corp_id: str = None,
    ):
        # 工作台名称。
        self.ding_portal_name = ding_portal_name
        # 被操纵企业ID。
        self.target_corp_id = target_corp_id
        # 模版id。
        self.template_app_uuid = template_app_uuid
        # 模版所属的组织id。
        self.template_corp_id = template_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_portal_name is not None:
            result['dingPortalName'] = self.ding_portal_name
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        if self.template_app_uuid is not None:
            result['templateAppUuid'] = self.template_app_uuid
        if self.template_corp_id is not None:
            result['templateCorpId'] = self.template_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingPortalName') is not None:
            self.ding_portal_name = m.get('dingPortalName')
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        if m.get('templateAppUuid') is not None:
            self.template_app_uuid = m.get('templateAppUuid')
        if m.get('templateCorpId') is not None:
            self.template_corp_id = m.get('templateCorpId')
        return self


class ExclusiveCreateDingPortalResponseBody(TeaModel):
    def __init__(
        self,
        success: str = None,
    ):
        # 是否成功。
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


class ExclusiveCreateDingPortalResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ExclusiveCreateDingPortalResponseBody = None,
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
            temp_model = ExclusiveCreateDingPortalResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class FileStorageActiveStorageHeaders(TeaModel):
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


class FileStorageActiveStorageRequest(TeaModel):
    def __init__(
        self,
        access_key_id: str = None,
        access_key_secret: str = None,
        oss: str = None,
        target_corp_id: str = None,
    ):
        # 密匙id
        self.access_key_id = access_key_id
        # 密匙密码
        self.access_key_secret = access_key_secret
        # 带bucket的oss域名
        self.oss = oss
        # 企业id
        self.target_corp_id = target_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key_id is not None:
            result['accessKeyId'] = self.access_key_id
        if self.access_key_secret is not None:
            result['accessKeySecret'] = self.access_key_secret
        if self.oss is not None:
            result['oss'] = self.oss
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKeyId') is not None:
            self.access_key_id = m.get('accessKeyId')
        if m.get('accessKeySecret') is not None:
            self.access_key_secret = m.get('accessKeySecret')
        if m.get('oss') is not None:
            self.oss = m.get('oss')
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        return self


class FileStorageActiveStorageResponseBody(TeaModel):
    def __init__(
        self,
        create_date: str = None,
        file_storage_open_status: int = None,
        storage_status: int = None,
        used_quota: int = None,
    ):
        # oss开启时间
        self.create_date = create_date
        # 是否开启专属存储 0开启1关闭
        self.file_storage_open_status = file_storage_open_status
        # 存储状态 0正常1异常
        self.storage_status = storage_status
        # 已经使用的容量Bytes
        self.used_quota = used_quota

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_date is not None:
            result['createDate'] = self.create_date
        if self.file_storage_open_status is not None:
            result['fileStorageOpenStatus'] = self.file_storage_open_status
        if self.storage_status is not None:
            result['storageStatus'] = self.storage_status
        if self.used_quota is not None:
            result['usedQuota'] = self.used_quota
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createDate') is not None:
            self.create_date = m.get('createDate')
        if m.get('fileStorageOpenStatus') is not None:
            self.file_storage_open_status = m.get('fileStorageOpenStatus')
        if m.get('storageStatus') is not None:
            self.storage_status = m.get('storageStatus')
        if m.get('usedQuota') is not None:
            self.used_quota = m.get('usedQuota')
        return self


class FileStorageActiveStorageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: FileStorageActiveStorageResponseBody = None,
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
            temp_model = FileStorageActiveStorageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class FileStorageCheckConnectionHeaders(TeaModel):
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


class FileStorageCheckConnectionRequest(TeaModel):
    def __init__(
        self,
        access_key_id: str = None,
        access_key_secret: str = None,
        oss: str = None,
        target_corp_id: str = None,
    ):
        # 密匙id
        self.access_key_id = access_key_id
        # 密匙密码
        self.access_key_secret = access_key_secret
        # 带bucket的oss域名
        self.oss = oss
        # 企业id
        self.target_corp_id = target_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key_id is not None:
            result['accessKeyId'] = self.access_key_id
        if self.access_key_secret is not None:
            result['accessKeySecret'] = self.access_key_secret
        if self.oss is not None:
            result['oss'] = self.oss
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKeyId') is not None:
            self.access_key_id = m.get('accessKeyId')
        if m.get('accessKeySecret') is not None:
            self.access_key_secret = m.get('accessKeySecret')
        if m.get('oss') is not None:
            self.oss = m.get('oss')
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        return self


class FileStorageCheckConnectionResponseBody(TeaModel):
    def __init__(
        self,
        access_key_id: str = None,
        check_state: int = None,
        oss: str = None,
    ):
        # 密匙ID
        self.access_key_id = access_key_id
        # 检测oss状态 0正常1异常
        self.check_state = check_state
        # OSS链接
        self.oss = oss

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key_id is not None:
            result['accessKeyId'] = self.access_key_id
        if self.check_state is not None:
            result['checkState'] = self.check_state
        if self.oss is not None:
            result['oss'] = self.oss
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKeyId') is not None:
            self.access_key_id = m.get('accessKeyId')
        if m.get('checkState') is not None:
            self.check_state = m.get('checkState')
        if m.get('oss') is not None:
            self.oss = m.get('oss')
        return self


class FileStorageCheckConnectionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: FileStorageCheckConnectionResponseBody = None,
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
            temp_model = FileStorageCheckConnectionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class FileStorageGetQuotaDataHeaders(TeaModel):
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


class FileStorageGetQuotaDataRequest(TeaModel):
    def __init__(
        self,
        end_time: str = None,
        start_time: str = None,
        target_corp_id: str = None,
        type: str = None,
    ):
        # 结束时间
        self.end_time = end_time
        # 开始时间
        self.start_time = start_time
        # 企业的corpId
        self.target_corp_id = target_corp_id
        # 查询类型 0按天查询；1按月查询
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class FileStorageGetQuotaDataResponseBodyQuotaModelList(TeaModel):
    def __init__(
        self,
        statistic_time: str = None,
        used_storage: int = None,
    ):
        # 统计时间点
        self.statistic_time = statistic_time
        # 使用的容量（byte）
        self.used_storage = used_storage

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.statistic_time is not None:
            result['statisticTime'] = self.statistic_time
        if self.used_storage is not None:
            result['usedStorage'] = self.used_storage
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statisticTime') is not None:
            self.statistic_time = m.get('statisticTime')
        if m.get('usedStorage') is not None:
            self.used_storage = m.get('usedStorage')
        return self


class FileStorageGetQuotaDataResponseBody(TeaModel):
    def __init__(
        self,
        quota_model_list: List[FileStorageGetQuotaDataResponseBodyQuotaModelList] = None,
    ):
        # 文件存储使用容量列表
        self.quota_model_list = quota_model_list

    def validate(self):
        if self.quota_model_list:
            for k in self.quota_model_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['quotaModelList'] = []
        if self.quota_model_list is not None:
            for k in self.quota_model_list:
                result['quotaModelList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.quota_model_list = []
        if m.get('quotaModelList') is not None:
            for k in m.get('quotaModelList'):
                temp_model = FileStorageGetQuotaDataResponseBodyQuotaModelList()
                self.quota_model_list.append(temp_model.from_map(k))
        return self


class FileStorageGetQuotaDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: FileStorageGetQuotaDataResponseBody = None,
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
            temp_model = FileStorageGetQuotaDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class FileStorageGetStorageStateHeaders(TeaModel):
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


class FileStorageGetStorageStateRequest(TeaModel):
    def __init__(
        self,
        target_corp_id: str = None,
    ):
        # 企业的corpId
        self.target_corp_id = target_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        return self


class FileStorageGetStorageStateResponseBody(TeaModel):
    def __init__(
        self,
        access_key_id: str = None,
        create_date: str = None,
        file_storage_open_status: int = None,
        oss: str = None,
        storage_status: int = None,
        used_quota: int = None,
    ):
        # 密匙ID
        self.access_key_id = access_key_id
        # oss开启时间
        self.create_date = create_date
        # 是否开启专属存储 0开启1关闭
        self.file_storage_open_status = file_storage_open_status
        # OSS链接
        self.oss = oss
        # 存储状态 0正常1异常
        self.storage_status = storage_status
        # 已经使用的容量Bytes
        self.used_quota = used_quota

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key_id is not None:
            result['accessKeyId'] = self.access_key_id
        if self.create_date is not None:
            result['createDate'] = self.create_date
        if self.file_storage_open_status is not None:
            result['fileStorageOpenStatus'] = self.file_storage_open_status
        if self.oss is not None:
            result['oss'] = self.oss
        if self.storage_status is not None:
            result['storageStatus'] = self.storage_status
        if self.used_quota is not None:
            result['usedQuota'] = self.used_quota
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKeyId') is not None:
            self.access_key_id = m.get('accessKeyId')
        if m.get('createDate') is not None:
            self.create_date = m.get('createDate')
        if m.get('fileStorageOpenStatus') is not None:
            self.file_storage_open_status = m.get('fileStorageOpenStatus')
        if m.get('oss') is not None:
            self.oss = m.get('oss')
        if m.get('storageStatus') is not None:
            self.storage_status = m.get('storageStatus')
        if m.get('usedQuota') is not None:
            self.used_quota = m.get('usedQuota')
        return self


class FileStorageGetStorageStateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: FileStorageGetStorageStateResponseBody = None,
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
            temp_model = FileStorageGetStorageStateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class FileStorageUpdateStorageHeaders(TeaModel):
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


class FileStorageUpdateStorageRequest(TeaModel):
    def __init__(
        self,
        access_key_id: str = None,
        access_key_secret: str = None,
        target_corp_id: str = None,
    ):
        # 密匙id
        self.access_key_id = access_key_id
        # 密匙密码
        self.access_key_secret = access_key_secret
        # 企业id
        self.target_corp_id = target_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key_id is not None:
            result['accessKeyId'] = self.access_key_id
        if self.access_key_secret is not None:
            result['accessKeySecret'] = self.access_key_secret
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKeyId') is not None:
            self.access_key_id = m.get('accessKeyId')
        if m.get('accessKeySecret') is not None:
            self.access_key_secret = m.get('accessKeySecret')
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        return self


class FileStorageUpdateStorageResponseBody(TeaModel):
    def __init__(
        self,
        access_key_id: str = None,
        oss: str = None,
    ):
        # 密匙ID
        self.access_key_id = access_key_id
        # OSS链接
        self.oss = oss

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key_id is not None:
            result['accessKeyId'] = self.access_key_id
        if self.oss is not None:
            result['oss'] = self.oss
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKeyId') is not None:
            self.access_key_id = m.get('accessKeyId')
        if m.get('oss') is not None:
            self.oss = m.get('oss')
        return self


class FileStorageUpdateStorageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: FileStorageUpdateStorageResponseBody = None,
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
            temp_model = FileStorageUpdateStorageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GenerateDarkWaterMarkHeaders(TeaModel):
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


class GenerateDarkWaterMarkRequest(TeaModel):
    def __init__(
        self,
        user_id_list: List[str] = None,
    ):
        # 工号列表
        self.user_id_list = user_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id_list is not None:
            result['userIdList'] = self.user_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userIdList') is not None:
            self.user_id_list = m.get('userIdList')
        return self


class GenerateDarkWaterMarkResponseBodyDarkWatermarkVOList(TeaModel):
    def __init__(
        self,
        dark_watermark: str = None,
        user_id: str = None,
    ):
        # 暗水印链接
        self.dark_watermark = dark_watermark
        # 员工工号
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dark_watermark is not None:
            result['darkWatermark'] = self.dark_watermark
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('darkWatermark') is not None:
            self.dark_watermark = m.get('darkWatermark')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GenerateDarkWaterMarkResponseBody(TeaModel):
    def __init__(
        self,
        dark_watermark_volist: List[GenerateDarkWaterMarkResponseBodyDarkWatermarkVOList] = None,
    ):
        # 返回码
        self.dark_watermark_volist = dark_watermark_volist

    def validate(self):
        if self.dark_watermark_volist:
            for k in self.dark_watermark_volist:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['darkWatermarkVOList'] = []
        if self.dark_watermark_volist is not None:
            for k in self.dark_watermark_volist:
                result['darkWatermarkVOList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.dark_watermark_volist = []
        if m.get('darkWatermarkVOList') is not None:
            for k in m.get('darkWatermarkVOList'):
                temp_model = GenerateDarkWaterMarkResponseBodyDarkWatermarkVOList()
                self.dark_watermark_volist.append(temp_model.from_map(k))
        return self


class GenerateDarkWaterMarkResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GenerateDarkWaterMarkResponseBody = None,
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
            temp_model = GenerateDarkWaterMarkResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetAccountTransferListHeaders(TeaModel):
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


class GetAccountTransferListRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        status: int = None,
    ):
        # 分页页数
        self.page_number = page_number
        # 分页大小
        self.page_size = page_size
        # 迁移状态0-未迁移，1-已迁移，2-无需迁移
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class GetAccountTransferListResponseBodyItemList(TeaModel):
    def __init__(
        self,
        dept_name: int = None,
        name: str = None,
        user_id: str = None,
    ):
        # 部门名称
        self.dept_name = dept_name
        # 员工名称
        self.name = name
        # 工号
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.name is not None:
            result['name'] = self.name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetAccountTransferListResponseBody(TeaModel):
    def __init__(
        self,
        item_list: List[GetAccountTransferListResponseBodyItemList] = None,
        total_count: int = None,
    ):
        # 迁移详情数据
        self.item_list = item_list
        # 总数据量
        self.total_count = total_count

    def validate(self):
        if self.item_list:
            for k in self.item_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['itemList'] = []
        if self.item_list is not None:
            for k in self.item_list:
                result['itemList'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.item_list = []
        if m.get('itemList') is not None:
            for k in m.get('itemList'):
                temp_model = GetAccountTransferListResponseBodyItemList()
                self.item_list.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class GetAccountTransferListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetAccountTransferListResponseBody = None,
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
            temp_model = GetAccountTransferListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetActiveUserSummaryHeaders(TeaModel):
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


class GetActiveUserSummaryResponseBody(TeaModel):
    def __init__(
        self,
        act_usr_cnt_1m: str = None,
    ):
        # 月活跃人数
        self.act_usr_cnt_1m = act_usr_cnt_1m

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.act_usr_cnt_1m is not None:
            result['actUsrCnt1m'] = self.act_usr_cnt_1m
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actUsrCnt1m') is not None:
            self.act_usr_cnt_1m = m.get('actUsrCnt1m')
        return self


class GetActiveUserSummaryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetActiveUserSummaryResponseBody = None,
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
            temp_model = GetActiveUserSummaryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetAgentIdByRelatedAppIdHeaders(TeaModel):
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


class GetAgentIdByRelatedAppIdRequest(TeaModel):
    def __init__(
        self,
        app_id: int = None,
        target_corp_id: str = None,
    ):
        # 应用的appId。
        self.app_id = app_id
        # 被查询的组织id。
        self.target_corp_id = target_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        return self


class GetAgentIdByRelatedAppIdResponseBody(TeaModel):
    def __init__(
        self,
        agent_id: int = None,
    ):
        # 微应用agentId。
        self.agent_id = agent_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        return self


class GetAgentIdByRelatedAppIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetAgentIdByRelatedAppIdResponseBody = None,
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
            temp_model = GetAgentIdByRelatedAppIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetAllLabelableDeptsHeaders(TeaModel):
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


class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel1(TeaModel):
    def __init__(
        self,
        label_id: int = None,
        label_name: str = None,
        level_num: int = None,
    ):
        # 伙伴类型id
        self.label_id = label_id
        # 伙伴类型
        self.label_name = label_name
        # 伙伴类型层级
        self.level_num = level_num

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.label_id is not None:
            result['labelId'] = self.label_id
        if self.label_name is not None:
            result['labelName'] = self.label_name
        if self.level_num is not None:
            result['levelNum'] = self.level_num
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('labelId') is not None:
            self.label_id = m.get('labelId')
        if m.get('labelName') is not None:
            self.label_name = m.get('labelName')
        if m.get('levelNum') is not None:
            self.level_num = m.get('levelNum')
        return self


class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel2(TeaModel):
    def __init__(
        self,
        label_id: int = None,
        label_name: str = None,
        level_num: int = None,
    ):
        # 伙伴类型id
        self.label_id = label_id
        # 伙伴类型
        self.label_name = label_name
        # 伙伴类型层级
        self.level_num = level_num

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.label_id is not None:
            result['labelId'] = self.label_id
        if self.label_name is not None:
            result['labelName'] = self.label_name
        if self.level_num is not None:
            result['levelNum'] = self.level_num
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('labelId') is not None:
            self.label_id = m.get('labelId')
        if m.get('labelName') is not None:
            self.label_name = m.get('labelName')
        if m.get('levelNum') is not None:
            self.level_num = m.get('levelNum')
        return self


class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel3(TeaModel):
    def __init__(
        self,
        label_id: int = None,
        label_name: str = None,
        level_num: int = None,
    ):
        # 伙伴类型id
        self.label_id = label_id
        # 伙伴类型
        self.label_name = label_name
        # 伙伴类型层级
        self.level_num = level_num

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.label_id is not None:
            result['labelId'] = self.label_id
        if self.label_name is not None:
            result['labelName'] = self.label_name
        if self.level_num is not None:
            result['levelNum'] = self.level_num
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('labelId') is not None:
            self.label_id = m.get('labelId')
        if m.get('labelName') is not None:
            self.label_name = m.get('labelName')
        if m.get('levelNum') is not None:
            self.level_num = m.get('levelNum')
        return self


class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel4(TeaModel):
    def __init__(
        self,
        label_id: int = None,
        label_name: str = None,
        level_num: int = None,
    ):
        # 伙伴类型id
        self.label_id = label_id
        # 伙伴类型
        self.label_name = label_name
        # 伙伴类型层级
        self.level_num = level_num

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.label_id is not None:
            result['labelId'] = self.label_id
        if self.label_name is not None:
            result['labelName'] = self.label_name
        if self.level_num is not None:
            result['levelNum'] = self.level_num
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('labelId') is not None:
            self.label_id = m.get('labelId')
        if m.get('labelName') is not None:
            self.label_name = m.get('labelName')
        if m.get('levelNum') is not None:
            self.level_num = m.get('levelNum')
        return self


class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel5(TeaModel):
    def __init__(
        self,
        label_id: int = None,
        label_name: str = None,
        level_num: int = None,
    ):
        # 伙伴类型id
        self.label_id = label_id
        # 伙伴类型
        self.label_name = label_name
        # 伙伴类型层级
        self.level_num = level_num

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.label_id is not None:
            result['labelId'] = self.label_id
        if self.label_name is not None:
            result['labelName'] = self.label_name
        if self.level_num is not None:
            result['levelNum'] = self.level_num
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('labelId') is not None:
            self.label_id = m.get('labelId')
        if m.get('labelName') is not None:
            self.label_name = m.get('labelName')
        if m.get('levelNum') is not None:
            self.level_num = m.get('levelNum')
        return self


class GetAllLabelableDeptsResponseBodyData(TeaModel):
    def __init__(
        self,
        dept_id: str = None,
        dept_name: str = None,
        member_count: int = None,
        partner_label_volevel_1: GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel1 = None,
        partner_label_volevel_2: GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel2 = None,
        partner_label_volevel_3: GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel3 = None,
        partner_label_volevel_4: GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel4 = None,
        partner_label_volevel_5: GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel5 = None,
        partner_num: str = None,
        super_dept_id: str = None,
    ):
        # 部门id
        self.dept_id = dept_id
        # 部门名称
        self.dept_name = dept_name
        # 部门人数
        self.member_count = member_count
        # 部门一级伙伴类型
        self.partner_label_volevel_1 = partner_label_volevel_1
        # 部门二级伙伴类型
        self.partner_label_volevel_2 = partner_label_volevel_2
        # 部门三级伙伴类型
        self.partner_label_volevel_3 = partner_label_volevel_3
        # 部门四级伙伴类型
        self.partner_label_volevel_4 = partner_label_volevel_4
        # 部门五级伙伴类型
        self.partner_label_volevel_5 = partner_label_volevel_5
        # 部门伙伴编码
        self.partner_num = partner_num
        # 父部门id
        self.super_dept_id = super_dept_id

    def validate(self):
        if self.partner_label_volevel_1:
            self.partner_label_volevel_1.validate()
        if self.partner_label_volevel_2:
            self.partner_label_volevel_2.validate()
        if self.partner_label_volevel_3:
            self.partner_label_volevel_3.validate()
        if self.partner_label_volevel_4:
            self.partner_label_volevel_4.validate()
        if self.partner_label_volevel_5:
            self.partner_label_volevel_5.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.member_count is not None:
            result['memberCount'] = self.member_count
        if self.partner_label_volevel_1 is not None:
            result['partnerLabelVOLevel1'] = self.partner_label_volevel_1.to_map()
        if self.partner_label_volevel_2 is not None:
            result['partnerLabelVOLevel2'] = self.partner_label_volevel_2.to_map()
        if self.partner_label_volevel_3 is not None:
            result['partnerLabelVOLevel3'] = self.partner_label_volevel_3.to_map()
        if self.partner_label_volevel_4 is not None:
            result['partnerLabelVOLevel4'] = self.partner_label_volevel_4.to_map()
        if self.partner_label_volevel_5 is not None:
            result['partnerLabelVOLevel5'] = self.partner_label_volevel_5.to_map()
        if self.partner_num is not None:
            result['partnerNum'] = self.partner_num
        if self.super_dept_id is not None:
            result['superDeptId'] = self.super_dept_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('memberCount') is not None:
            self.member_count = m.get('memberCount')
        if m.get('partnerLabelVOLevel1') is not None:
            temp_model = GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel1()
            self.partner_label_volevel_1 = temp_model.from_map(m['partnerLabelVOLevel1'])
        if m.get('partnerLabelVOLevel2') is not None:
            temp_model = GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel2()
            self.partner_label_volevel_2 = temp_model.from_map(m['partnerLabelVOLevel2'])
        if m.get('partnerLabelVOLevel3') is not None:
            temp_model = GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel3()
            self.partner_label_volevel_3 = temp_model.from_map(m['partnerLabelVOLevel3'])
        if m.get('partnerLabelVOLevel4') is not None:
            temp_model = GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel4()
            self.partner_label_volevel_4 = temp_model.from_map(m['partnerLabelVOLevel4'])
        if m.get('partnerLabelVOLevel5') is not None:
            temp_model = GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel5()
            self.partner_label_volevel_5 = temp_model.from_map(m['partnerLabelVOLevel5'])
        if m.get('partnerNum') is not None:
            self.partner_num = m.get('partnerNum')
        if m.get('superDeptId') is not None:
            self.super_dept_id = m.get('superDeptId')
        return self


class GetAllLabelableDeptsResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetAllLabelableDeptsResponseBodyData] = None,
    ):
        # 伙伴钉可打标部门列表
        self.data = data

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetAllLabelableDeptsResponseBodyData()
                self.data.append(temp_model.from_map(k))
        return self


class GetAllLabelableDeptsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetAllLabelableDeptsResponseBody = None,
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
            temp_model = GetAllLabelableDeptsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetAppDispatchInfoHeaders(TeaModel):
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


class GetAppDispatchInfoRequest(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        start_time: int = None,
    ):
        # 打包结束日期查询参数
        self.end_time = end_time
        # 打包开始日期查询参数
        self.start_time = start_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.start_time is not None:
            result['startTime'] = self.start_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        return self


class GetAppDispatchInfoResponseBodyAndroid(TeaModel):
    def __init__(
        self,
        base_line_version: str = None,
        download_url: str = None,
        in_gray: bool = None,
        pack_time: int = None,
        platform: str = None,
        version: str = None,
    ):
        # 基线版本
        self.base_line_version = base_line_version
        # 下载地址
        self.download_url = download_url
        # 是否灰度。true 灰度发布中 | false 全量灰度发布。为空则为未发布
        self.in_gray = in_gray
        # 打包时间
        self.pack_time = pack_time
        # 客户端类型
        self.platform = platform
        # 版本号
        self.version = version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.base_line_version is not None:
            result['baseLineVersion'] = self.base_line_version
        if self.download_url is not None:
            result['downloadUrl'] = self.download_url
        if self.in_gray is not None:
            result['inGray'] = self.in_gray
        if self.pack_time is not None:
            result['packTime'] = self.pack_time
        if self.platform is not None:
            result['platform'] = self.platform
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('baseLineVersion') is not None:
            self.base_line_version = m.get('baseLineVersion')
        if m.get('downloadUrl') is not None:
            self.download_url = m.get('downloadUrl')
        if m.get('inGray') is not None:
            self.in_gray = m.get('inGray')
        if m.get('packTime') is not None:
            self.pack_time = m.get('packTime')
        if m.get('platform') is not None:
            self.platform = m.get('platform')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class GetAppDispatchInfoResponseBodyIOSExt(TeaModel):
    def __init__(
        self,
        plist: str = None,
    ):
        # plist下载地址
        self.plist = plist

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.plist is not None:
            result['plist'] = self.plist
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('plist') is not None:
            self.plist = m.get('plist')
        return self


class GetAppDispatchInfoResponseBodyIOS(TeaModel):
    def __init__(
        self,
        base_line_version: str = None,
        download_url: str = None,
        ext: GetAppDispatchInfoResponseBodyIOSExt = None,
        in_gray: bool = None,
        pack_time: int = None,
        platform: str = None,
        version: str = None,
    ):
        # 基线版本
        self.base_line_version = base_line_version
        # 下载地址
        self.download_url = download_url
        self.ext = ext
        # 是否灰度。true 灰度发布中 | false 全量灰度发布。为空则为未发布
        self.in_gray = in_gray
        # 打包时间
        self.pack_time = pack_time
        # 客户端类型
        self.platform = platform
        # 版本号
        self.version = version

    def validate(self):
        if self.ext:
            self.ext.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.base_line_version is not None:
            result['baseLineVersion'] = self.base_line_version
        if self.download_url is not None:
            result['downloadUrl'] = self.download_url
        if self.ext is not None:
            result['ext'] = self.ext.to_map()
        if self.in_gray is not None:
            result['inGray'] = self.in_gray
        if self.pack_time is not None:
            result['packTime'] = self.pack_time
        if self.platform is not None:
            result['platform'] = self.platform
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('baseLineVersion') is not None:
            self.base_line_version = m.get('baseLineVersion')
        if m.get('downloadUrl') is not None:
            self.download_url = m.get('downloadUrl')
        if m.get('ext') is not None:
            temp_model = GetAppDispatchInfoResponseBodyIOSExt()
            self.ext = temp_model.from_map(m['ext'])
        if m.get('inGray') is not None:
            self.in_gray = m.get('inGray')
        if m.get('packTime') is not None:
            self.pack_time = m.get('packTime')
        if m.get('platform') is not None:
            self.platform = m.get('platform')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class GetAppDispatchInfoResponseBodyMac(TeaModel):
    def __init__(
        self,
        base_line_version: str = None,
        download_url: str = None,
        in_gray: bool = None,
        pack_time: int = None,
        platform: str = None,
        version: str = None,
    ):
        # 基线版本
        self.base_line_version = base_line_version
        # 下载地址
        self.download_url = download_url
        # 是否灰度。true 灰度发布中 | false 全量灰度发布。为空则为未发布
        self.in_gray = in_gray
        # 打包时间
        self.pack_time = pack_time
        # 客户端类型
        self.platform = platform
        # 版本号
        self.version = version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.base_line_version is not None:
            result['baseLineVersion'] = self.base_line_version
        if self.download_url is not None:
            result['downloadUrl'] = self.download_url
        if self.in_gray is not None:
            result['inGray'] = self.in_gray
        if self.pack_time is not None:
            result['packTime'] = self.pack_time
        if self.platform is not None:
            result['platform'] = self.platform
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('baseLineVersion') is not None:
            self.base_line_version = m.get('baseLineVersion')
        if m.get('downloadUrl') is not None:
            self.download_url = m.get('downloadUrl')
        if m.get('inGray') is not None:
            self.in_gray = m.get('inGray')
        if m.get('packTime') is not None:
            self.pack_time = m.get('packTime')
        if m.get('platform') is not None:
            self.platform = m.get('platform')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class GetAppDispatchInfoResponseBodyWindows(TeaModel):
    def __init__(
        self,
        base_line_version: str = None,
        download_url: str = None,
        in_gray: bool = None,
        pack_time: int = None,
        platform: str = None,
        version: str = None,
    ):
        # 基线版本
        self.base_line_version = base_line_version
        # 下载地址
        self.download_url = download_url
        # 是否灰度。true 灰度发布中 | false 全量灰度发布。为空则为未发布
        self.in_gray = in_gray
        # 打包时间
        self.pack_time = pack_time
        # 客户端类型
        self.platform = platform
        # 版本号
        self.version = version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.base_line_version is not None:
            result['baseLineVersion'] = self.base_line_version
        if self.download_url is not None:
            result['downloadUrl'] = self.download_url
        if self.in_gray is not None:
            result['inGray'] = self.in_gray
        if self.pack_time is not None:
            result['packTime'] = self.pack_time
        if self.platform is not None:
            result['platform'] = self.platform
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('baseLineVersion') is not None:
            self.base_line_version = m.get('baseLineVersion')
        if m.get('downloadUrl') is not None:
            self.download_url = m.get('downloadUrl')
        if m.get('inGray') is not None:
            self.in_gray = m.get('inGray')
        if m.get('packTime') is not None:
            self.pack_time = m.get('packTime')
        if m.get('platform') is not None:
            self.platform = m.get('platform')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class GetAppDispatchInfoResponseBody(TeaModel):
    def __init__(
        self,
        android: List[GetAppDispatchInfoResponseBodyAndroid] = None,
        i_os: List[GetAppDispatchInfoResponseBodyIOS] = None,
        mac: List[GetAppDispatchInfoResponseBodyMac] = None,
        windows: List[GetAppDispatchInfoResponseBodyWindows] = None,
    ):
        # android打包记录
        self.android = android
        # iOS打包记录
        self.i_os = i_os
        # mac打包记录
        self.mac = mac
        # windows打包记录
        self.windows = windows

    def validate(self):
        if self.android:
            for k in self.android:
                if k:
                    k.validate()
        if self.i_os:
            for k in self.i_os:
                if k:
                    k.validate()
        if self.mac:
            for k in self.mac:
                if k:
                    k.validate()
        if self.windows:
            for k in self.windows:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['android'] = []
        if self.android is not None:
            for k in self.android:
                result['android'].append(k.to_map() if k else None)
        result['iOS'] = []
        if self.i_os is not None:
            for k in self.i_os:
                result['iOS'].append(k.to_map() if k else None)
        result['mac'] = []
        if self.mac is not None:
            for k in self.mac:
                result['mac'].append(k.to_map() if k else None)
        result['windows'] = []
        if self.windows is not None:
            for k in self.windows:
                result['windows'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.android = []
        if m.get('android') is not None:
            for k in m.get('android'):
                temp_model = GetAppDispatchInfoResponseBodyAndroid()
                self.android.append(temp_model.from_map(k))
        self.i_os = []
        if m.get('iOS') is not None:
            for k in m.get('iOS'):
                temp_model = GetAppDispatchInfoResponseBodyIOS()
                self.i_os.append(temp_model.from_map(k))
        self.mac = []
        if m.get('mac') is not None:
            for k in m.get('mac'):
                temp_model = GetAppDispatchInfoResponseBodyMac()
                self.mac.append(temp_model.from_map(k))
        self.windows = []
        if m.get('windows') is not None:
            for k in m.get('windows'):
                temp_model = GetAppDispatchInfoResponseBodyWindows()
                self.windows.append(temp_model.from_map(k))
        return self


class GetAppDispatchInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetAppDispatchInfoResponseBody = None,
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
            temp_model = GetAppDispatchInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetCalenderSummaryHeaders(TeaModel):
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


class GetCalenderSummaryResponseBody(TeaModel):
    def __init__(
        self,
        calendar_create_user_cnt: str = None,
        recv_calendar_user_cnt_1d: str = None,
        use_calendar_user_cnt_1d: str = None,
    ):
        # 最近1天创建日程人数
        self.calendar_create_user_cnt = calendar_create_user_cnt
        # 最近1天接收日程人数
        self.recv_calendar_user_cnt_1d = recv_calendar_user_cnt_1d
        # 最近1天使用日程人数
        self.use_calendar_user_cnt_1d = use_calendar_user_cnt_1d

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.calendar_create_user_cnt is not None:
            result['calendarCreateUserCnt'] = self.calendar_create_user_cnt
        if self.recv_calendar_user_cnt_1d is not None:
            result['recvCalendarUserCnt1d'] = self.recv_calendar_user_cnt_1d
        if self.use_calendar_user_cnt_1d is not None:
            result['useCalendarUserCnt1d'] = self.use_calendar_user_cnt_1d
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('calendarCreateUserCnt') is not None:
            self.calendar_create_user_cnt = m.get('calendarCreateUserCnt')
        if m.get('recvCalendarUserCnt1d') is not None:
            self.recv_calendar_user_cnt_1d = m.get('recvCalendarUserCnt1d')
        if m.get('useCalendarUserCnt1d') is not None:
            self.use_calendar_user_cnt_1d = m.get('useCalendarUserCnt1d')
        return self


class GetCalenderSummaryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetCalenderSummaryResponseBody = None,
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
            temp_model = GetCalenderSummaryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetCommentListHeaders(TeaModel):
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


class GetCommentListRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
    ):
        # 分页起始页
        self.page_number = page_number
        # 分页大小
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class GetCommentListResponseBodyData(TeaModel):
    def __init__(
        self,
        comment_id: str = None,
        comment_time: float = None,
        comment_user_name: str = None,
        content: str = None,
    ):
        # 评论ID
        self.comment_id = comment_id
        # 评论时间
        self.comment_time = comment_time
        # 评论者姓名
        self.comment_user_name = comment_user_name
        # 评论内容
        self.content = content

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.comment_id is not None:
            result['commentId'] = self.comment_id
        if self.comment_time is not None:
            result['commentTime'] = self.comment_time
        if self.comment_user_name is not None:
            result['commentUserName'] = self.comment_user_name
        if self.content is not None:
            result['content'] = self.content
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commentId') is not None:
            self.comment_id = m.get('commentId')
        if m.get('commentTime') is not None:
            self.comment_time = m.get('commentTime')
        if m.get('commentUserName') is not None:
            self.comment_user_name = m.get('commentUserName')
        if m.get('content') is not None:
            self.content = m.get('content')
        return self


class GetCommentListResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetCommentListResponseBodyData] = None,
        total_count: int = None,
    ):
        self.data = data
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
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetCommentListResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class GetCommentListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetCommentListResponseBody = None,
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
            temp_model = GetCommentListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetConfBaseInfoByLogicalIdHeaders(TeaModel):
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


class GetConfBaseInfoByLogicalIdRequest(TeaModel):
    def __init__(
        self,
        logical_conference_id: str = None,
    ):
        # 会议id
        self.logical_conference_id = logical_conference_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.logical_conference_id is not None:
            result['logicalConferenceId'] = self.logical_conference_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('logicalConferenceId') is not None:
            self.logical_conference_id = m.get('logicalConferenceId')
        return self


class GetConfBaseInfoByLogicalIdResponseBody(TeaModel):
    def __init__(
        self,
        conference_id: str = None,
        logical_conference_id: str = None,
        nickname: str = None,
        start_time: int = None,
        title: str = None,
        union_id: str = None,
    ):
        # 会议ID（仅在会议正式开始后才返回该字段）
        self.conference_id = conference_id
        # 会议逻辑id
        self.logical_conference_id = logical_conference_id
        # 会议创建用户昵称
        self.nickname = nickname
        # 开始时间
        self.start_time = start_time
        # 会议标题
        self.title = title
        # 会议创建用户id
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conference_id is not None:
            result['conferenceId'] = self.conference_id
        if self.logical_conference_id is not None:
            result['logicalConferenceId'] = self.logical_conference_id
        if self.nickname is not None:
            result['nickname'] = self.nickname
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.title is not None:
            result['title'] = self.title
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conferenceId') is not None:
            self.conference_id = m.get('conferenceId')
        if m.get('logicalConferenceId') is not None:
            self.logical_conference_id = m.get('logicalConferenceId')
        if m.get('nickname') is not None:
            self.nickname = m.get('nickname')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetConfBaseInfoByLogicalIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetConfBaseInfoByLogicalIdResponseBody = None,
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
            temp_model = GetConfBaseInfoByLogicalIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetConferenceDetailHeaders(TeaModel):
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


class GetConferenceDetailResponseBodyMemberList(TeaModel):
    def __init__(
        self,
        attend_duration: float = None,
        name: str = None,
        staff_id: str = None,
        union_id: str = None,
    ):
        # 参会时长
        self.attend_duration = attend_duration
        # 用户昵称
        self.name = name
        # 员工id
        self.staff_id = staff_id
        # 用户uid
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.attend_duration is not None:
            result['attendDuration'] = self.attend_duration
        if self.name is not None:
            result['name'] = self.name
        if self.staff_id is not None:
            result['staffId'] = self.staff_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('attendDuration') is not None:
            self.attend_duration = m.get('attendDuration')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('staffId') is not None:
            self.staff_id = m.get('staffId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetConferenceDetailResponseBody(TeaModel):
    def __init__(
        self,
        attendee_num: int = None,
        attendee_percentage: str = None,
        caller_id: str = None,
        caller_name: str = None,
        conf_start_time: float = None,
        conference_id: str = None,
        duration: float = None,
        member_list: List[GetConferenceDetailResponseBodyMemberList] = None,
        title: str = None,
        total_num: int = None,
    ):
        # 出席会议人数
        self.attendee_num = attendee_num
        # 出席率
        self.attendee_percentage = attendee_percentage
        # 发起人uid
        self.caller_id = caller_id
        # 发起人昵称
        self.caller_name = caller_name
        # 开始时间
        self.conf_start_time = conf_start_time
        # 会议ID
        self.conference_id = conference_id
        # 持续时间
        self.duration = duration
        # 参会人员列表
        self.member_list = member_list
        # 会议标题
        self.title = title
        # 会议人数
        self.total_num = total_num

    def validate(self):
        if self.member_list:
            for k in self.member_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.attendee_num is not None:
            result['attendeeNum'] = self.attendee_num
        if self.attendee_percentage is not None:
            result['attendeePercentage'] = self.attendee_percentage
        if self.caller_id is not None:
            result['callerId'] = self.caller_id
        if self.caller_name is not None:
            result['callerName'] = self.caller_name
        if self.conf_start_time is not None:
            result['confStartTime'] = self.conf_start_time
        if self.conference_id is not None:
            result['conferenceId'] = self.conference_id
        if self.duration is not None:
            result['duration'] = self.duration
        result['memberList'] = []
        if self.member_list is not None:
            for k in self.member_list:
                result['memberList'].append(k.to_map() if k else None)
        if self.title is not None:
            result['title'] = self.title
        if self.total_num is not None:
            result['totalNum'] = self.total_num
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('attendeeNum') is not None:
            self.attendee_num = m.get('attendeeNum')
        if m.get('attendeePercentage') is not None:
            self.attendee_percentage = m.get('attendeePercentage')
        if m.get('callerId') is not None:
            self.caller_id = m.get('callerId')
        if m.get('callerName') is not None:
            self.caller_name = m.get('callerName')
        if m.get('confStartTime') is not None:
            self.conf_start_time = m.get('confStartTime')
        if m.get('conferenceId') is not None:
            self.conference_id = m.get('conferenceId')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        self.member_list = []
        if m.get('memberList') is not None:
            for k in m.get('memberList'):
                temp_model = GetConferenceDetailResponseBodyMemberList()
                self.member_list.append(temp_model.from_map(k))
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('totalNum') is not None:
            self.total_num = m.get('totalNum')
        return self


class GetConferenceDetailResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetConferenceDetailResponseBody = None,
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
            temp_model = GetConferenceDetailResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetDingReportDeptSummaryHeaders(TeaModel):
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


class GetDingReportDeptSummaryRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: int = None,
    ):
        # 每页包含的数据条数
        self.max_results = max_results
        # 启始数据游标
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
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class GetDingReportDeptSummaryResponseBodyData(TeaModel):
    def __init__(
        self,
        dept_id: str = None,
        dept_name: str = None,
        ding_report_send_cnt: str = None,
        ding_report_send_usr_cnt: str = None,
    ):
        # 部门id
        self.dept_id = dept_id
        # 部门名称
        self.dept_name = dept_name
        # 最近1天累计创建日志数
        self.ding_report_send_cnt = ding_report_send_cnt
        # 最近1天累计创建日志人数
        self.ding_report_send_usr_cnt = ding_report_send_usr_cnt

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.ding_report_send_cnt is not None:
            result['dingReportSendCnt'] = self.ding_report_send_cnt
        if self.ding_report_send_usr_cnt is not None:
            result['dingReportSendUsrCnt'] = self.ding_report_send_usr_cnt
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('dingReportSendCnt') is not None:
            self.ding_report_send_cnt = m.get('dingReportSendCnt')
        if m.get('dingReportSendUsrCnt') is not None:
            self.ding_report_send_usr_cnt = m.get('dingReportSendUsrCnt')
        return self


class GetDingReportDeptSummaryResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetDingReportDeptSummaryResponseBodyData] = None,
        has_more: bool = None,
        next_token: int = None,
    ):
        # 部门维度发布日志信息
        self.data = data
        # 是否有更多数据
        self.has_more = has_more
        # 下一次请求的分页游标
        self.next_token = next_token

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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetDingReportDeptSummaryResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class GetDingReportDeptSummaryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetDingReportDeptSummaryResponseBody = None,
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
            temp_model = GetDingReportDeptSummaryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetDingReportSummaryHeaders(TeaModel):
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


class GetDingReportSummaryResponseBody(TeaModel):
    def __init__(
        self,
        report_comment_user_cnt_1d: str = None,
    ):
        # 最近1天日志评论用户数
        self.report_comment_user_cnt_1d = report_comment_user_cnt_1d

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.report_comment_user_cnt_1d is not None:
            result['reportCommentUserCnt1d'] = self.report_comment_user_cnt_1d
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('reportCommentUserCnt1d') is not None:
            self.report_comment_user_cnt_1d = m.get('reportCommentUserCnt1d')
        return self


class GetDingReportSummaryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetDingReportSummaryResponseBody = None,
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
            temp_model = GetDingReportSummaryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetDocCreatedDeptSummaryHeaders(TeaModel):
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


class GetDocCreatedDeptSummaryRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: int = None,
    ):
        # 每页包含的数据条数
        self.max_results = max_results
        # 启始数据游标
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
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class GetDocCreatedDeptSummaryResponseBodyData(TeaModel):
    def __init__(
        self,
        create_doc_user_cnt_1d: str = None,
        dept_id: str = None,
        dept_name: str = None,
        doc_created_cnt: str = None,
    ):
        # 最近1天创建文档人数
        self.create_doc_user_cnt_1d = create_doc_user_cnt_1d
        # 部门id
        self.dept_id = dept_id
        # 部门名称
        self.dept_name = dept_name
        # 最近1天钉钉文档创建数
        self.doc_created_cnt = doc_created_cnt

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_doc_user_cnt_1d is not None:
            result['createDocUserCnt1d'] = self.create_doc_user_cnt_1d
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.doc_created_cnt is not None:
            result['docCreatedCnt'] = self.doc_created_cnt
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createDocUserCnt1d') is not None:
            self.create_doc_user_cnt_1d = m.get('createDocUserCnt1d')
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('docCreatedCnt') is not None:
            self.doc_created_cnt = m.get('docCreatedCnt')
        return self


class GetDocCreatedDeptSummaryResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetDocCreatedDeptSummaryResponseBodyData] = None,
        has_more: bool = None,
        next_token: int = None,
    ):
        # 部门维度用户创建文档数
        self.data = data
        # 是否有更多数据
        self.has_more = has_more
        # 下一次请求的分页游标
        self.next_token = next_token

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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetDocCreatedDeptSummaryResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class GetDocCreatedDeptSummaryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetDocCreatedDeptSummaryResponseBody = None,
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
            temp_model = GetDocCreatedDeptSummaryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetDocCreatedSummaryHeaders(TeaModel):
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


class GetDocCreatedSummaryResponseBody(TeaModel):
    def __init__(
        self,
        doc_create_user_cnt_1d: str = None,
        doc_created_cnt: str = None,
    ):
        # 最近1天创建文档人数
        self.doc_create_user_cnt_1d = doc_create_user_cnt_1d
        # 最近1天创建文档数
        self.doc_created_cnt = doc_created_cnt

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.doc_create_user_cnt_1d is not None:
            result['docCreateUserCnt1d'] = self.doc_create_user_cnt_1d
        if self.doc_created_cnt is not None:
            result['docCreatedCnt'] = self.doc_created_cnt
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('docCreateUserCnt1d') is not None:
            self.doc_create_user_cnt_1d = m.get('docCreateUserCnt1d')
        if m.get('docCreatedCnt') is not None:
            self.doc_created_cnt = m.get('docCreatedCnt')
        return self


class GetDocCreatedSummaryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetDocCreatedSummaryResponseBody = None,
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
            temp_model = GetDocCreatedSummaryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetExclusiveAccountAllOrgListHeaders(TeaModel):
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


class GetExclusiveAccountAllOrgListRequest(TeaModel):
    def __init__(
        self,
        union_id: str = None,
    ):
        # 用户unionId
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetExclusiveAccountAllOrgListResponseBodyOrgInfoList(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        is_main_org: bool = None,
        logo_url: str = None,
        org_full_name: str = None,
        org_name: str = None,
    ):
        # 组织ID
        self.corp_id = corp_id
        # 是否是主组织
        self.is_main_org = is_main_org
        # 组织图标地址
        self.logo_url = logo_url
        # 组织全称
        self.org_full_name = org_full_name
        # 组织名称
        self.org_name = org_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.is_main_org is not None:
            result['isMainOrg'] = self.is_main_org
        if self.logo_url is not None:
            result['logoUrl'] = self.logo_url
        if self.org_full_name is not None:
            result['orgFullName'] = self.org_full_name
        if self.org_name is not None:
            result['orgName'] = self.org_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('isMainOrg') is not None:
            self.is_main_org = m.get('isMainOrg')
        if m.get('logoUrl') is not None:
            self.logo_url = m.get('logoUrl')
        if m.get('orgFullName') is not None:
            self.org_full_name = m.get('orgFullName')
        if m.get('orgName') is not None:
            self.org_name = m.get('orgName')
        return self


class GetExclusiveAccountAllOrgListResponseBody(TeaModel):
    def __init__(
        self,
        org_info_list: List[GetExclusiveAccountAllOrgListResponseBodyOrgInfoList] = None,
    ):
        # 组织信息列表
        self.org_info_list = org_info_list

    def validate(self):
        if self.org_info_list:
            for k in self.org_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['orgInfoList'] = []
        if self.org_info_list is not None:
            for k in self.org_info_list:
                result['orgInfoList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.org_info_list = []
        if m.get('orgInfoList') is not None:
            for k in m.get('orgInfoList'):
                temp_model = GetExclusiveAccountAllOrgListResponseBodyOrgInfoList()
                self.org_info_list.append(temp_model.from_map(k))
        return self


class GetExclusiveAccountAllOrgListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetExclusiveAccountAllOrgListResponseBody = None,
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
            temp_model = GetExclusiveAccountAllOrgListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetGeneralFormCreatedDeptSummaryHeaders(TeaModel):
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


class GetGeneralFormCreatedDeptSummaryRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: int = None,
    ):
        # 每页包含的数据条数
        self.max_results = max_results
        # 启始数据游标
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
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class GetGeneralFormCreatedDeptSummaryResponseBodyData(TeaModel):
    def __init__(
        self,
        dept_id: str = None,
        dept_name: str = None,
        general_form_create_cnt_1d: str = None,
        use_general_form_user_cnt_1d: str = None,
    ):
        # 部门id
        self.dept_id = dept_id
        # 部门名称
        self.dept_name = dept_name
        # 最近1天累计发布智能填表数
        self.general_form_create_cnt_1d = general_form_create_cnt_1d
        # 最近1天使用智能填表人数
        self.use_general_form_user_cnt_1d = use_general_form_user_cnt_1d

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.general_form_create_cnt_1d is not None:
            result['generalFormCreateCnt1d'] = self.general_form_create_cnt_1d
        if self.use_general_form_user_cnt_1d is not None:
            result['useGeneralFormUserCnt1d'] = self.use_general_form_user_cnt_1d
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('generalFormCreateCnt1d') is not None:
            self.general_form_create_cnt_1d = m.get('generalFormCreateCnt1d')
        if m.get('useGeneralFormUserCnt1d') is not None:
            self.use_general_form_user_cnt_1d = m.get('useGeneralFormUserCnt1d')
        return self


class GetGeneralFormCreatedDeptSummaryResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetGeneralFormCreatedDeptSummaryResponseBodyData] = None,
        has_more: bool = None,
        next_token: int = None,
    ):
        # 用户版本分布情况列表
        self.data = data
        # 是否有更多数据
        self.has_more = has_more
        # 下一次请 求的分页游标
        self.next_token = next_token

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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetGeneralFormCreatedDeptSummaryResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class GetGeneralFormCreatedDeptSummaryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetGeneralFormCreatedDeptSummaryResponseBody = None,
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
            temp_model = GetGeneralFormCreatedDeptSummaryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetGeneralFormCreatedSummaryHeaders(TeaModel):
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


class GetGeneralFormCreatedSummaryResponseBody(TeaModel):
    def __init__(
        self,
        general_form_created_cnt: str = None,
        use_general_form_user_cnt_1d: str = None,
    ):
        # 最近1天智能填表创建数
        self.general_form_created_cnt = general_form_created_cnt
        # 最近1天使用智能填表人数
        self.use_general_form_user_cnt_1d = use_general_form_user_cnt_1d

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.general_form_created_cnt is not None:
            result['generalFormCreatedCnt'] = self.general_form_created_cnt
        if self.use_general_form_user_cnt_1d is not None:
            result['useGeneralFormUserCnt1d'] = self.use_general_form_user_cnt_1d
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('generalFormCreatedCnt') is not None:
            self.general_form_created_cnt = m.get('generalFormCreatedCnt')
        if m.get('useGeneralFormUserCnt1d') is not None:
            self.use_general_form_user_cnt_1d = m.get('useGeneralFormUserCnt1d')
        return self


class GetGeneralFormCreatedSummaryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetGeneralFormCreatedSummaryResponseBody = None,
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
            temp_model = GetGeneralFormCreatedSummaryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetGroupActiveInfoHeaders(TeaModel):
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


class GetGroupActiveInfoRequest(TeaModel):
    def __init__(
        self,
        ding_group_id: str = None,
        group_type: int = None,
        page_number: int = None,
        page_size: int = None,
        stat_date: str = None,
    ):
        # 钉钉群组id
        self.ding_group_id = ding_group_id
        # 群类型：1-全员群，2-部门群，3-（其他）内部群，4-场景群
        self.group_type = group_type
        # 分页起始页
        self.page_number = page_number
        # 分页大小
        self.page_size = page_size
        # 统计日期
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_group_id is not None:
            result['dingGroupId'] = self.ding_group_id
        if self.group_type is not None:
            result['groupType'] = self.group_type
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingGroupId') is not None:
            self.ding_group_id = m.get('dingGroupId')
        if m.get('groupType') is not None:
            self.group_type = m.get('groupType')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class GetGroupActiveInfoResponseBodyData(TeaModel):
    def __init__(
        self,
        ding_group_id: str = None,
        group_create_time: str = None,
        group_create_user_id: str = None,
        group_create_user_name: str = None,
        group_name: str = None,
        group_type: int = None,
        group_user_cnt_1d: int = None,
        open_conv_uv_1d: int = None,
        send_message_cnt_1d: int = None,
        send_message_user_cnt_1d: int = None,
        stat_date: str = None,
    ):
        # 群组id
        self.ding_group_id = ding_group_id
        # 群组创建时间
        self.group_create_time = group_create_time
        # 群组创建用户id
        self.group_create_user_id = group_create_user_id
        # 群组创建用户姓名
        self.group_create_user_name = group_create_user_name
        # 群名称
        self.group_name = group_name
        # 群类型：1-全员群，2-部门群，3-（其他）内部群，4-场景群
        self.group_type = group_type
        # 最近1天群人数
        self.group_user_cnt_1d = group_user_cnt_1d
        # 最近1天打开群人数
        self.open_conv_uv_1d = open_conv_uv_1d
        # 最近1天发消息次数
        self.send_message_cnt_1d = send_message_cnt_1d
        # 最近1天发消息人数
        self.send_message_user_cnt_1d = send_message_user_cnt_1d
        # 统计时间
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_group_id is not None:
            result['dingGroupId'] = self.ding_group_id
        if self.group_create_time is not None:
            result['groupCreateTime'] = self.group_create_time
        if self.group_create_user_id is not None:
            result['groupCreateUserId'] = self.group_create_user_id
        if self.group_create_user_name is not None:
            result['groupCreateUserName'] = self.group_create_user_name
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.group_type is not None:
            result['groupType'] = self.group_type
        if self.group_user_cnt_1d is not None:
            result['groupUserCnt1d'] = self.group_user_cnt_1d
        if self.open_conv_uv_1d is not None:
            result['openConvUv1d'] = self.open_conv_uv_1d
        if self.send_message_cnt_1d is not None:
            result['sendMessageCnt1d'] = self.send_message_cnt_1d
        if self.send_message_user_cnt_1d is not None:
            result['sendMessageUserCnt1d'] = self.send_message_user_cnt_1d
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingGroupId') is not None:
            self.ding_group_id = m.get('dingGroupId')
        if m.get('groupCreateTime') is not None:
            self.group_create_time = m.get('groupCreateTime')
        if m.get('groupCreateUserId') is not None:
            self.group_create_user_id = m.get('groupCreateUserId')
        if m.get('groupCreateUserName') is not None:
            self.group_create_user_name = m.get('groupCreateUserName')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('groupType') is not None:
            self.group_type = m.get('groupType')
        if m.get('groupUserCnt1d') is not None:
            self.group_user_cnt_1d = m.get('groupUserCnt1d')
        if m.get('openConvUv1d') is not None:
            self.open_conv_uv_1d = m.get('openConvUv1d')
        if m.get('sendMessageCnt1d') is not None:
            self.send_message_cnt_1d = m.get('sendMessageCnt1d')
        if m.get('sendMessageUserCnt1d') is not None:
            self.send_message_user_cnt_1d = m.get('sendMessageUserCnt1d')
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class GetGroupActiveInfoResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetGroupActiveInfoResponseBodyData] = None,
        total_count: int = None,
    ):
        self.data = data
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
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetGroupActiveInfoResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class GetGroupActiveInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetGroupActiveInfoResponseBody = None,
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
            temp_model = GetGroupActiveInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetInActiveUserListHeaders(TeaModel):
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


class GetInActiveUserListRequest(TeaModel):
    def __init__(
        self,
        dept_ids: List[str] = None,
        page_number: int = None,
        page_size: int = None,
        stat_date: str = None,
    ):
        self.dept_ids = dept_ids
        self.page_number = page_number
        self.page_size = page_size
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_ids is not None:
            result['deptIds'] = self.dept_ids
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptIds') is not None:
            self.dept_ids = m.get('deptIds')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class GetInActiveUserListResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # 指标口径
        self.kpi_caliber = kpi_caliber
        # 指标ID
        self.kpi_id = kpi_id
        # 指标名称
        self.kpi_name = kpi_name
        # 指标周期
        self.period = period
        # 指标单位
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class GetInActiveUserListResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[GetInActiveUserListResponseBodyMetaList] = None,
    ):
        # 指标数据
        self.data_list = data_list
        # 指标元数据
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = GetInActiveUserListResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class GetInActiveUserListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetInActiveUserListResponseBody = None,
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
            temp_model = GetInActiveUserListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetLastOrgAuthDataHeaders(TeaModel):
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


class GetLastOrgAuthDataRequest(TeaModel):
    def __init__(
        self,
        target_corp_id: str = None,
    ):
        # 企业的corpId
        self.target_corp_id = target_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        return self


class GetLastOrgAuthDataResponseBody(TeaModel):
    def __init__(
        self,
        auth_remark: str = None,
        auth_status: int = None,
    ):
        # 未通过原因
        self.auth_remark = auth_remark
        # 审核状态 0 未提交， 1未审核 2 失败 3通过
        self.auth_status = auth_status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.auth_remark is not None:
            result['authRemark'] = self.auth_remark
        if self.auth_status is not None:
            result['authStatus'] = self.auth_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('authRemark') is not None:
            self.auth_remark = m.get('authRemark')
        if m.get('authStatus') is not None:
            self.auth_status = m.get('authStatus')
        return self


class GetLastOrgAuthDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetLastOrgAuthDataResponseBody = None,
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
            temp_model = GetLastOrgAuthDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetOaOperatorLogListHeaders(TeaModel):
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


class GetOaOperatorLogListRequest(TeaModel):
    def __init__(
        self,
        category_list: List[str] = None,
        end_time: int = None,
        op_user_id: str = None,
        page_number: int = None,
        page_size: int = None,
        start_time: int = None,
    ):
        # 操作分类（一级目录）
        self.category_list = category_list
        # 结束时间
        self.end_time = end_time
        # 操作员userId
        self.op_user_id = op_user_id
        # 分页起始页
        self.page_number = page_number
        # 分页大小
        self.page_size = page_size
        # 起始时间
        self.start_time = start_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.category_list is not None:
            result['categoryList'] = self.category_list
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.start_time is not None:
            result['startTime'] = self.start_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('categoryList') is not None:
            self.category_list = m.get('categoryList')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        return self


class GetOaOperatorLogListResponseBodyData(TeaModel):
    def __init__(
        self,
        category_1name: str = None,
        category_2name: str = None,
        content: str = None,
        op_name: str = None,
        op_time: int = None,
        op_user_id: str = None,
    ):
        # 操作分类（一级）
        self.category_1name = category_1name
        # 操作分类（二级）
        self.category_2name = category_2name
        # 操作详情
        self.content = content
        # 操作员名字
        self.op_name = op_name
        # 操作时间
        self.op_time = op_time
        # 操作员userId
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.category_1name is not None:
            result['category1Name'] = self.category_1name
        if self.category_2name is not None:
            result['category2Name'] = self.category_2name
        if self.content is not None:
            result['content'] = self.content
        if self.op_name is not None:
            result['opName'] = self.op_name
        if self.op_time is not None:
            result['opTime'] = self.op_time
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('category1Name') is not None:
            self.category_1name = m.get('category1Name')
        if m.get('category2Name') is not None:
            self.category_2name = m.get('category2Name')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('opName') is not None:
            self.op_name = m.get('opName')
        if m.get('opTime') is not None:
            self.op_time = m.get('opTime')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class GetOaOperatorLogListResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetOaOperatorLogListResponseBodyData] = None,
        item_count: int = None,
    ):
        self.data = data
        # 当前获取记录数
        self.item_count = item_count

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
        if self.item_count is not None:
            result['itemCount'] = self.item_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetOaOperatorLogListResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('itemCount') is not None:
            self.item_count = m.get('itemCount')
        return self


class GetOaOperatorLogListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetOaOperatorLogListResponseBody = None,
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
            temp_model = GetOaOperatorLogListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetPartnerTypeByParentIdHeaders(TeaModel):
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


class GetPartnerTypeByParentIdResponseBodyData(TeaModel):
    def __init__(
        self,
        label_id: str = None,
        type_id: float = None,
        type_name: str = None,
    ):
        # 子标签id
        self.label_id = label_id
        # 目前无意义
        self.type_id = type_id
        # 子标签名
        self.type_name = type_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.label_id is not None:
            result['labelId'] = self.label_id
        if self.type_id is not None:
            result['typeId'] = self.type_id
        if self.type_name is not None:
            result['typeName'] = self.type_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('labelId') is not None:
            self.label_id = m.get('labelId')
        if m.get('typeId') is not None:
            self.type_id = m.get('typeId')
        if m.get('typeName') is not None:
            self.type_name = m.get('typeName')
        return self


class GetPartnerTypeByParentIdResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetPartnerTypeByParentIdResponseBodyData] = None,
    ):
        # 子标签列表
        self.data = data

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetPartnerTypeByParentIdResponseBodyData()
                self.data.append(temp_model.from_map(k))
        return self


class GetPartnerTypeByParentIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetPartnerTypeByParentIdResponseBody = None,
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
            temp_model = GetPartnerTypeByParentIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetPublisherSummaryHeaders(TeaModel):
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


class GetPublisherSummaryRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: int = None,
    ):
        # 每页包含的数据条数
        self.max_results = max_results
        # 启始数据游标
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
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class GetPublisherSummaryResponseBodyData(TeaModel):
    def __init__(
        self,
        publisher_article_cnt_std: str = None,
        publisher_article_pv_cnt_std: str = None,
        publisher_name: str = None,
        union_id: str = None,
    ):
        # 历史截至当日服务窗文章数
        self.publisher_article_cnt_std = publisher_article_cnt_std
        # 历史截至当日服务窗文章阅读数
        self.publisher_article_pv_cnt_std = publisher_article_pv_cnt_std
        # 服务窗名称
        self.publisher_name = publisher_name
        # 服务窗unionId
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.publisher_article_cnt_std is not None:
            result['publisherArticleCntStd'] = self.publisher_article_cnt_std
        if self.publisher_article_pv_cnt_std is not None:
            result['publisherArticlePvCntStd'] = self.publisher_article_pv_cnt_std
        if self.publisher_name is not None:
            result['publisherName'] = self.publisher_name
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('publisherArticleCntStd') is not None:
            self.publisher_article_cnt_std = m.get('publisherArticleCntStd')
        if m.get('publisherArticlePvCntStd') is not None:
            self.publisher_article_pv_cnt_std = m.get('publisherArticlePvCntStd')
        if m.get('publisherName') is not None:
            self.publisher_name = m.get('publisherName')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetPublisherSummaryResponseBodyPublisherArticlePvTop5(TeaModel):
    def __init__(
        self,
        name: str = None,
    ):
        # 文章名称
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class GetPublisherSummaryResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetPublisherSummaryResponseBodyData] = None,
        has_more: bool = None,
        next_token: int = None,
        publisher_article_cnt_std: str = None,
        publisher_article_pv_cnt_std: str = None,
        publisher_article_pv_top_5: List[GetPublisherSummaryResponseBodyPublisherArticlePvTop5] = None,
        publisher_cnt_std: str = None,
    ):
        # 互动服务窗相关数据
        self.data = data
        # 是否有更多数据
        self.has_more = has_more
        # 下一次请求的分页游标
        self.next_token = next_token
        # 历史截至当日服务窗文章数
        self.publisher_article_cnt_std = publisher_article_cnt_std
        # 历史截至当日服务窗文章阅读数
        self.publisher_article_pv_cnt_std = publisher_article_pv_cnt_std
        # 阅读量最高的5个文章
        self.publisher_article_pv_top_5 = publisher_article_pv_top_5
        # 历史截至当日服务窗数
        self.publisher_cnt_std = publisher_cnt_std

    def validate(self):
        if self.data:
            for k in self.data:
                if k:
                    k.validate()
        if self.publisher_article_pv_top_5:
            for k in self.publisher_article_pv_top_5:
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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.publisher_article_cnt_std is not None:
            result['publisherArticleCntStd'] = self.publisher_article_cnt_std
        if self.publisher_article_pv_cnt_std is not None:
            result['publisherArticlePvCntStd'] = self.publisher_article_pv_cnt_std
        result['publisherArticlePvTop5'] = []
        if self.publisher_article_pv_top_5 is not None:
            for k in self.publisher_article_pv_top_5:
                result['publisherArticlePvTop5'].append(k.to_map() if k else None)
        if self.publisher_cnt_std is not None:
            result['publisherCntStd'] = self.publisher_cnt_std
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetPublisherSummaryResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('publisherArticleCntStd') is not None:
            self.publisher_article_cnt_std = m.get('publisherArticleCntStd')
        if m.get('publisherArticlePvCntStd') is not None:
            self.publisher_article_pv_cnt_std = m.get('publisherArticlePvCntStd')
        self.publisher_article_pv_top_5 = []
        if m.get('publisherArticlePvTop5') is not None:
            for k in m.get('publisherArticlePvTop5'):
                temp_model = GetPublisherSummaryResponseBodyPublisherArticlePvTop5()
                self.publisher_article_pv_top_5.append(temp_model.from_map(k))
        if m.get('publisherCntStd') is not None:
            self.publisher_cnt_std = m.get('publisherCntStd')
        return self


class GetPublisherSummaryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetPublisherSummaryResponseBody = None,
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
            temp_model = GetPublisherSummaryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetRealPeopleRecordsHeaders(TeaModel):
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


class GetRealPeopleRecordsRequest(TeaModel):
    def __init__(
        self,
        agent_id: int = None,
        from_time: int = None,
        max_results: int = None,
        next_token: int = None,
        person_identification: int = None,
        to_time: int = None,
        user_ids: List[str] = None,
    ):
        # 应用唯一标识
        self.agent_id = agent_id
        # 记录开始时间(毫秒时间戳)
        self.from_time = from_time
        # 一页最大值（最大50）
        self.max_results = max_results
        # 查询数据的起始位置，0表示从头开始。
        self.next_token = next_token
        # 实人认证结果 1-成功 2-失败
        self.person_identification = person_identification
        # 记录结束时间(毫秒时间戳)
        self.to_time = to_time
        # 员工userIds
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        if self.from_time is not None:
            result['fromTime'] = self.from_time
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.person_identification is not None:
            result['personIdentification'] = self.person_identification
        if self.to_time is not None:
            result['toTime'] = self.to_time
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        if m.get('fromTime') is not None:
            self.from_time = m.get('fromTime')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('personIdentification') is not None:
            self.person_identification = m.get('personIdentification')
        if m.get('toTime') is not None:
            self.to_time = m.get('toTime')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class GetRealPeopleRecordsResponseBodyData(TeaModel):
    def __init__(
        self,
        agent_id: int = None,
        invoke_time: int = None,
        person_identification: int = None,
        platform: int = None,
        user_id: str = None,
    ):
        # agentId
        self.agent_id = agent_id
        # 接口调用时间(毫秒时间戳)
        self.invoke_time = invoke_time
        # 实人认证结果 1-成功 2-失败
        self.person_identification = person_identification
        # 平台 0-Android 或 1-iOS
        self.platform = platform
        # userId
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        if self.invoke_time is not None:
            result['invokeTime'] = self.invoke_time
        if self.person_identification is not None:
            result['personIdentification'] = self.person_identification
        if self.platform is not None:
            result['platform'] = self.platform
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        if m.get('invokeTime') is not None:
            self.invoke_time = m.get('invokeTime')
        if m.get('personIdentification') is not None:
            self.person_identification = m.get('personIdentification')
        if m.get('platform') is not None:
            self.platform = m.get('platform')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetRealPeopleRecordsResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetRealPeopleRecordsResponseBodyData] = None,
        next_token: int = None,
        total: int = None,
    ):
        # data
        self.data = data
        # 下一次拉取启始值
        self.next_token = next_token
        # 总数据数
        self.total = total

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
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetRealPeopleRecordsResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class GetRealPeopleRecordsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetRealPeopleRecordsResponseBody = None,
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
            temp_model = GetRealPeopleRecordsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetRecognizeRecordsHeaders(TeaModel):
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


class GetRecognizeRecordsRequest(TeaModel):
    def __init__(
        self,
        agent_id: int = None,
        face_compare_result: int = None,
        from_time: int = None,
        max_results: int = None,
        next_token: int = None,
        to_time: int = None,
        user_ids: List[str] = None,
    ):
        # 应用唯一标识
        self.agent_id = agent_id
        # 人脸对比结果 1-成功 2-失败
        self.face_compare_result = face_compare_result
        # 记录开始时间(毫秒时间戳)
        self.from_time = from_time
        # 一页最大值（最大50）
        self.max_results = max_results
        # 查询数据的起始位置，0表示从头开始。
        self.next_token = next_token
        # 记录结束时间(毫秒时间戳)
        self.to_time = to_time
        # 员工userIds
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        if self.face_compare_result is not None:
            result['faceCompareResult'] = self.face_compare_result
        if self.from_time is not None:
            result['fromTime'] = self.from_time
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.to_time is not None:
            result['toTime'] = self.to_time
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        if m.get('faceCompareResult') is not None:
            self.face_compare_result = m.get('faceCompareResult')
        if m.get('fromTime') is not None:
            self.from_time = m.get('fromTime')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('toTime') is not None:
            self.to_time = m.get('toTime')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class GetRecognizeRecordsResponseBodyData(TeaModel):
    def __init__(
        self,
        agent_id: int = None,
        face_compare_result: int = None,
        invoke_time: int = None,
        platform: int = None,
        user_id: str = None,
    ):
        # agentId
        self.agent_id = agent_id
        # 人脸对比结果 1-成功 2-失败
        self.face_compare_result = face_compare_result
        # 接口调用时间(毫秒时间戳)
        self.invoke_time = invoke_time
        # 平台 0-Android 或 1-iOS
        self.platform = platform
        # userId
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        if self.face_compare_result is not None:
            result['faceCompareResult'] = self.face_compare_result
        if self.invoke_time is not None:
            result['invokeTime'] = self.invoke_time
        if self.platform is not None:
            result['platform'] = self.platform
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        if m.get('faceCompareResult') is not None:
            self.face_compare_result = m.get('faceCompareResult')
        if m.get('invokeTime') is not None:
            self.invoke_time = m.get('invokeTime')
        if m.get('platform') is not None:
            self.platform = m.get('platform')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetRecognizeRecordsResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetRecognizeRecordsResponseBodyData] = None,
        next_token: int = None,
        total: int = None,
    ):
        # data
        self.data = data
        # 下一次拉取启始值
        self.next_token = next_token
        # 总数据数
        self.total = total

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
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetRecognizeRecordsResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class GetRecognizeRecordsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetRecognizeRecordsResponseBody = None,
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
            temp_model = GetRecognizeRecordsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetSignedDetailByPageHeaders(TeaModel):
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


class GetSignedDetailByPageRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        sign_status: int = None,
    ):
        # pageStart
        self.page_number = page_number
        # pageSize
        self.page_size = page_size
        # signStatus
        self.sign_status = sign_status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.sign_status is not None:
            result['signStatus'] = self.sign_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('signStatus') is not None:
            self.sign_status = m.get('signStatus')
        return self


class GetSignedDetailByPageResponseBodyAuditSignedDetailDTOList(TeaModel):
    def __init__(
        self,
        dept_name: str = None,
        email: str = None,
        name: str = None,
        phone: str = None,
        roles: str = None,
        staff_id: str = None,
        title: str = None,
    ):
        # 部门名称
        self.dept_name = dept_name
        # 邮件
        self.email = email
        # 员工名称
        self.name = name
        # 手机号
        self.phone = phone
        # 角色
        self.roles = roles
        # 工号
        self.staff_id = staff_id
        # 职位
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.email is not None:
            result['email'] = self.email
        if self.name is not None:
            result['name'] = self.name
        if self.phone is not None:
            result['phone'] = self.phone
        if self.roles is not None:
            result['roles'] = self.roles
        if self.staff_id is not None:
            result['staffId'] = self.staff_id
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('email') is not None:
            self.email = m.get('email')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('phone') is not None:
            self.phone = m.get('phone')
        if m.get('roles') is not None:
            self.roles = m.get('roles')
        if m.get('staffId') is not None:
            self.staff_id = m.get('staffId')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class GetSignedDetailByPageResponseBody(TeaModel):
    def __init__(
        self,
        audit_signed_detail_dtolist: List[GetSignedDetailByPageResponseBodyAuditSignedDetailDTOList] = None,
        current_page: int = None,
        page_size: int = None,
        total: int = None,
    ):
        # 员工信息
        self.audit_signed_detail_dtolist = audit_signed_detail_dtolist
        # 当前页
        self.current_page = current_page
        # 一页数据量
        self.page_size = page_size
        # 总数据量
        self.total = total

    def validate(self):
        if self.audit_signed_detail_dtolist:
            for k in self.audit_signed_detail_dtolist:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['auditSignedDetailDTOList'] = []
        if self.audit_signed_detail_dtolist is not None:
            for k in self.audit_signed_detail_dtolist:
                result['auditSignedDetailDTOList'].append(k.to_map() if k else None)
        if self.current_page is not None:
            result['currentPage'] = self.current_page
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.audit_signed_detail_dtolist = []
        if m.get('auditSignedDetailDTOList') is not None:
            for k in m.get('auditSignedDetailDTOList'):
                temp_model = GetSignedDetailByPageResponseBodyAuditSignedDetailDTOList()
                self.audit_signed_detail_dtolist.append(temp_model.from_map(k))
        if m.get('currentPage') is not None:
            self.current_page = m.get('currentPage')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class GetSignedDetailByPageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetSignedDetailByPageResponseBody = None,
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
            temp_model = GetSignedDetailByPageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetTrustDeviceListHeaders(TeaModel):
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


class GetTrustDeviceListRequest(TeaModel):
    def __init__(
        self,
        user_ids: List[str] = None,
    ):
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


class GetTrustDeviceListResponseBodyData(TeaModel):
    def __init__(
        self,
        create_time: int = None,
        mac_address: str = None,
        model: str = None,
        platform: str = None,
        status: int = None,
        title: str = None,
        user_id: str = None,
    ):
        # 创建时间
        self.create_time = create_time
        # mac地址
        self.mac_address = mac_address
        # 版本信息：Android端: Android,10，IOS端：iOS,12.0.1
        self.model = model
        # 平台类型
        self.platform = platform
        # 设备状态
        self.status = status
        # 设备名称
        self.title = title
        # 员工Id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.mac_address is not None:
            result['macAddress'] = self.mac_address
        if self.model is not None:
            result['model'] = self.model
        if self.platform is not None:
            result['platform'] = self.platform
        if self.status is not None:
            result['status'] = self.status
        if self.title is not None:
            result['title'] = self.title
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('macAddress') is not None:
            self.mac_address = m.get('macAddress')
        if m.get('model') is not None:
            self.model = m.get('model')
        if m.get('platform') is not None:
            self.platform = m.get('platform')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetTrustDeviceListResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetTrustDeviceListResponseBodyData] = None,
    ):
        self.data = data

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetTrustDeviceListResponseBodyData()
                self.data.append(temp_model.from_map(k))
        return self


class GetTrustDeviceListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetTrustDeviceListResponseBody = None,
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
            temp_model = GetTrustDeviceListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetUserAppVersionSummaryHeaders(TeaModel):
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


class GetUserAppVersionSummaryRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: int = None,
    ):
        # 每页包含的数据条数
        self.max_results = max_results
        # 启始数据游标
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
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class GetUserAppVersionSummaryResponseBodyData(TeaModel):
    def __init__(
        self,
        app_version: str = None,
        client: str = None,
        org_name: str = None,
        stat_date: str = None,
        user_cnt: float = None,
    ):
        # 版本信息
        self.app_version = app_version
        # 端信息
        self.client = client
        # 组织名称
        self.org_name = org_name
        # 统计日期
        self.stat_date = stat_date
        # 用户数
        self.user_cnt = user_cnt

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_version is not None:
            result['appVersion'] = self.app_version
        if self.client is not None:
            result['client'] = self.client
        if self.org_name is not None:
            result['orgName'] = self.org_name
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        if self.user_cnt is not None:
            result['userCnt'] = self.user_cnt
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appVersion') is not None:
            self.app_version = m.get('appVersion')
        if m.get('client') is not None:
            self.client = m.get('client')
        if m.get('orgName') is not None:
            self.org_name = m.get('orgName')
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        if m.get('userCnt') is not None:
            self.user_cnt = m.get('userCnt')
        return self


class GetUserAppVersionSummaryResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetUserAppVersionSummaryResponseBodyData] = None,
        has_more: bool = None,
        next_token: int = None,
    ):
        # 用户版本分布情况列表
        self.data = data
        # 是否有更多数据
        self.has_more = has_more
        # 下一次请求的分页游标
        self.next_token = next_token

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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetUserAppVersionSummaryResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class GetUserAppVersionSummaryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetUserAppVersionSummaryResponseBody = None,
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
            temp_model = GetUserAppVersionSummaryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetUserFaceStateHeaders(TeaModel):
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


class GetUserFaceStateRequest(TeaModel):
    def __init__(
        self,
        user_ids: List[str] = None,
    ):
        # userIds
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


class GetUserFaceStateResponseBodyData(TeaModel):
    def __init__(
        self,
        state: int = None,
        user_id: str = None,
    ):
        # 人脸录入状态 1-无人脸 2-有人脸
        self.state = state
        # userId
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.state is not None:
            result['state'] = self.state
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('state') is not None:
            self.state = m.get('state')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetUserFaceStateResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetUserFaceStateResponseBodyData] = None,
    ):
        # data
        self.data = data

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetUserFaceStateResponseBodyData()
                self.data.append(temp_model.from_map(k))
        return self


class GetUserFaceStateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetUserFaceStateResponseBody = None,
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
            temp_model = GetUserFaceStateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetUserRealPeopleStateHeaders(TeaModel):
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


class GetUserRealPeopleStateRequest(TeaModel):
    def __init__(
        self,
        user_ids: List[str] = None,
    ):
        # userIds
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


class GetUserRealPeopleStateResponseBodyData(TeaModel):
    def __init__(
        self,
        state: int = None,
        user_id: str = None,
    ):
        # 认证状态 1-未认证 2-已认证
        self.state = state
        # userId
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.state is not None:
            result['state'] = self.state
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('state') is not None:
            self.state = m.get('state')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetUserRealPeopleStateResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetUserRealPeopleStateResponseBodyData] = None,
    ):
        # data
        self.data = data

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetUserRealPeopleStateResponseBodyData()
                self.data.append(temp_model.from_map(k))
        return self


class GetUserRealPeopleStateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetUserRealPeopleStateResponseBody = None,
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
            temp_model = GetUserRealPeopleStateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetUserStayLengthHeaders(TeaModel):
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


class GetUserStayLengthRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        stat_date: str = None,
    ):
        # 分页页数
        self.page_number = page_number
        # 分页大小
        self.page_size = page_size
        # 统计日期（只保留当前日期的前30天）
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class GetUserStayLengthResponseBodyItemList(TeaModel):
    def __init__(
        self,
        name: str = None,
        stat_date: str = None,
        stay_time_len_app_1d: int = None,
        stay_time_len_pc_1d: int = None,
        user_id: str = None,
    ):
        # 员工名称
        self.name = name
        # 统计日期
        self.stat_date = stat_date
        # 1日app使用时长（秒）
        self.stay_time_len_app_1d = stay_time_len_app_1d
        # 1日PC端使用时长（秒）
        self.stay_time_len_pc_1d = stay_time_len_pc_1d
        # 工号
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        if self.stay_time_len_app_1d is not None:
            result['stayTimeLenApp1d'] = self.stay_time_len_app_1d
        if self.stay_time_len_pc_1d is not None:
            result['stayTimeLenPc1d'] = self.stay_time_len_pc_1d
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        if m.get('stayTimeLenApp1d') is not None:
            self.stay_time_len_app_1d = m.get('stayTimeLenApp1d')
        if m.get('stayTimeLenPc1d') is not None:
            self.stay_time_len_pc_1d = m.get('stayTimeLenPc1d')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetUserStayLengthResponseBody(TeaModel):
    def __init__(
        self,
        item_list: List[GetUserStayLengthResponseBodyItemList] = None,
        total_count: int = None,
    ):
        # 员工使用时长列表
        self.item_list = item_list
        # 总数据量
        self.total_count = total_count

    def validate(self):
        if self.item_list:
            for k in self.item_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['itemList'] = []
        if self.item_list is not None:
            for k in self.item_list:
                result['itemList'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.item_list = []
        if m.get('itemList') is not None:
            for k in m.get('itemList'):
                temp_model = GetUserStayLengthResponseBodyItemList()
                self.item_list.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class GetUserStayLengthResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetUserStayLengthResponseBody = None,
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
            temp_model = GetUserStayLengthResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListAuditLogHeaders(TeaModel):
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


class ListAuditLogRequest(TeaModel):
    def __init__(
        self,
        end_date: int = None,
        next_biz_id: int = None,
        next_gmt_create: int = None,
        page_size: int = None,
        start_date: int = None,
    ):
        # 操作日志截止时间，unix时间戳，单位ms
        self.end_date = end_date
        # 操作记录文件id，作为分页偏移量，与nextGmtCreate一起使用，返回记录的bizId为nextBizId且gmtCreate为nextGmtCreate之后的操作列表，分页查询获取下一页时，传最后一条记录的bizId和gmtCreate。
        self.next_biz_id = next_biz_id
        # 操作记录生成时间，作为分页偏移量，分页查询时必传，unix时间戳，单位ms
        self.next_gmt_create = next_gmt_create
        # 操作列表长度，最大500
        self.page_size = page_size
        # 操作日志起始时间，unix时间戳，单位ms
        self.start_date = start_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.next_biz_id is not None:
            result['nextBizId'] = self.next_biz_id
        if self.next_gmt_create is not None:
            result['nextGmtCreate'] = self.next_gmt_create
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.start_date is not None:
            result['startDate'] = self.start_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('nextBizId') is not None:
            self.next_biz_id = m.get('nextBizId')
        if m.get('nextGmtCreate') is not None:
            self.next_gmt_create = m.get('nextGmtCreate')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        return self


class ListAuditLogResponseBodyListDocMemberList(TeaModel):
    def __init__(
        self,
        member_name: str = None,
        member_type: int = None,
        member_type_view: str = None,
        permission_role: int = None,
        permission_role_view: str = None,
    ):
        # 成员名称
        self.member_name = member_name
        # 成员类型
        self.member_type = member_type
        # 成员类型翻译值
        self.member_type_view = member_type_view
        # 权限类型
        self.permission_role = permission_role
        # 权限类型翻译值
        self.permission_role_view = permission_role_view

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.member_name is not None:
            result['memberName'] = self.member_name
        if self.member_type is not None:
            result['memberType'] = self.member_type
        if self.member_type_view is not None:
            result['memberTypeView'] = self.member_type_view
        if self.permission_role is not None:
            result['permissionRole'] = self.permission_role
        if self.permission_role_view is not None:
            result['permissionRoleView'] = self.permission_role_view
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('memberName') is not None:
            self.member_name = m.get('memberName')
        if m.get('memberType') is not None:
            self.member_type = m.get('memberType')
        if m.get('memberTypeView') is not None:
            self.member_type_view = m.get('memberTypeView')
        if m.get('permissionRole') is not None:
            self.permission_role = m.get('permissionRole')
        if m.get('permissionRoleView') is not None:
            self.permission_role_view = m.get('permissionRoleView')
        return self


class ListAuditLogResponseBodyListDocReceiverList(TeaModel):
    def __init__(
        self,
        receiver_name: str = None,
        receiver_type: int = None,
        receiver_type_view: str = None,
    ):
        # 成员名称
        self.receiver_name = receiver_name
        # 成员类型
        self.receiver_type = receiver_type
        # 成员类型翻译值
        self.receiver_type_view = receiver_type_view

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.receiver_name is not None:
            result['receiverName'] = self.receiver_name
        if self.receiver_type is not None:
            result['receiverType'] = self.receiver_type
        if self.receiver_type_view is not None:
            result['receiverTypeView'] = self.receiver_type_view
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('receiverName') is not None:
            self.receiver_name = m.get('receiverName')
        if m.get('receiverType') is not None:
            self.receiver_type = m.get('receiverType')
        if m.get('receiverTypeView') is not None:
            self.receiver_type_view = m.get('receiverTypeView')
        return self


class ListAuditLogResponseBodyList(TeaModel):
    def __init__(
        self,
        action: int = None,
        action_view: str = None,
        biz_id: str = None,
        doc_member_list: List[ListAuditLogResponseBodyListDocMemberList] = None,
        doc_receiver_list: List[ListAuditLogResponseBodyListDocReceiverList] = None,
        gmt_create: int = None,
        gmt_modified: int = None,
        ip_address: str = None,
        operate_module: int = None,
        operate_module_view: str = None,
        operator_name: str = None,
        org_name: str = None,
        platform: int = None,
        platform_view: str = None,
        real_name: str = None,
        receiver_name: str = None,
        receiver_type: int = None,
        receiver_type_view: str = None,
        resource: str = None,
        resource_extension: str = None,
        resource_size: int = None,
        status: int = None,
        target_space_id: int = None,
        user_id: str = None,
    ):
        # 操作类型
        self.action = action
        # 操作类型翻译值
        self.action_view = action_view
        # 文件id
        self.biz_id = biz_id
        # 接收成员列表，仅分享文档返回
        self.doc_member_list = doc_member_list
        # 成员授权列表，仅文档授权返回
        self.doc_receiver_list = doc_receiver_list
        # 记录生成时间，unix时间戳，单位ms
        self.gmt_create = gmt_create
        # 记录修改时间，unix时间戳，单位ms
        self.gmt_modified = gmt_modified
        # 操作机器ip
        self.ip_address = ip_address
        # 操作来源空间
        self.operate_module = operate_module
        # 操作来源翻译值
        self.operate_module_view = operate_module_view
        # 用户昵称
        self.operator_name = operator_name
        # 文件所属组织名称
        self.org_name = org_name
        # 操作端
        self.platform = platform
        # 操作端翻译值
        self.platform_view = platform_view
        # 用户姓名
        self.real_name = real_name
        # 文件接收方名称
        self.receiver_name = receiver_name
        # 文件接收方类型
        self.receiver_type = receiver_type
        # 文件接收方类型翻译值
        self.receiver_type_view = receiver_type_view
        # test.docx
        self.resource = resource
        # 文件类型
        self.resource_extension = resource_extension
        # 文件大小
        self.resource_size = resource_size
        # 记录状态
        self.status = status
        # 空间id
        self.target_space_id = target_space_id
        # 员工的userId
        self.user_id = user_id

    def validate(self):
        if self.doc_member_list:
            for k in self.doc_member_list:
                if k:
                    k.validate()
        if self.doc_receiver_list:
            for k in self.doc_receiver_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action is not None:
            result['action'] = self.action
        if self.action_view is not None:
            result['actionView'] = self.action_view
        if self.biz_id is not None:
            result['bizId'] = self.biz_id
        result['docMemberList'] = []
        if self.doc_member_list is not None:
            for k in self.doc_member_list:
                result['docMemberList'].append(k.to_map() if k else None)
        result['docReceiverList'] = []
        if self.doc_receiver_list is not None:
            for k in self.doc_receiver_list:
                result['docReceiverList'].append(k.to_map() if k else None)
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.ip_address is not None:
            result['ipAddress'] = self.ip_address
        if self.operate_module is not None:
            result['operateModule'] = self.operate_module
        if self.operate_module_view is not None:
            result['operateModuleView'] = self.operate_module_view
        if self.operator_name is not None:
            result['operatorName'] = self.operator_name
        if self.org_name is not None:
            result['orgName'] = self.org_name
        if self.platform is not None:
            result['platform'] = self.platform
        if self.platform_view is not None:
            result['platformView'] = self.platform_view
        if self.real_name is not None:
            result['realName'] = self.real_name
        if self.receiver_name is not None:
            result['receiverName'] = self.receiver_name
        if self.receiver_type is not None:
            result['receiverType'] = self.receiver_type
        if self.receiver_type_view is not None:
            result['receiverTypeView'] = self.receiver_type_view
        if self.resource is not None:
            result['resource'] = self.resource
        if self.resource_extension is not None:
            result['resourceExtension'] = self.resource_extension
        if self.resource_size is not None:
            result['resourceSize'] = self.resource_size
        if self.status is not None:
            result['status'] = self.status
        if self.target_space_id is not None:
            result['targetSpaceId'] = self.target_space_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('action') is not None:
            self.action = m.get('action')
        if m.get('actionView') is not None:
            self.action_view = m.get('actionView')
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        self.doc_member_list = []
        if m.get('docMemberList') is not None:
            for k in m.get('docMemberList'):
                temp_model = ListAuditLogResponseBodyListDocMemberList()
                self.doc_member_list.append(temp_model.from_map(k))
        self.doc_receiver_list = []
        if m.get('docReceiverList') is not None:
            for k in m.get('docReceiverList'):
                temp_model = ListAuditLogResponseBodyListDocReceiverList()
                self.doc_receiver_list.append(temp_model.from_map(k))
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('ipAddress') is not None:
            self.ip_address = m.get('ipAddress')
        if m.get('operateModule') is not None:
            self.operate_module = m.get('operateModule')
        if m.get('operateModuleView') is not None:
            self.operate_module_view = m.get('operateModuleView')
        if m.get('operatorName') is not None:
            self.operator_name = m.get('operatorName')
        if m.get('orgName') is not None:
            self.org_name = m.get('orgName')
        if m.get('platform') is not None:
            self.platform = m.get('platform')
        if m.get('platformView') is not None:
            self.platform_view = m.get('platformView')
        if m.get('realName') is not None:
            self.real_name = m.get('realName')
        if m.get('receiverName') is not None:
            self.receiver_name = m.get('receiverName')
        if m.get('receiverType') is not None:
            self.receiver_type = m.get('receiverType')
        if m.get('receiverTypeView') is not None:
            self.receiver_type_view = m.get('receiverTypeView')
        if m.get('resource') is not None:
            self.resource = m.get('resource')
        if m.get('resourceExtension') is not None:
            self.resource_extension = m.get('resourceExtension')
        if m.get('resourceSize') is not None:
            self.resource_size = m.get('resourceSize')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('targetSpaceId') is not None:
            self.target_space_id = m.get('targetSpaceId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class ListAuditLogResponseBody(TeaModel):
    def __init__(
        self,
        list: List[ListAuditLogResponseBodyList] = None,
    ):
        # 记录列表
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
                temp_model = ListAuditLogResponseBodyList()
                self.list.append(temp_model.from_map(k))
        return self


class ListAuditLogResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListAuditLogResponseBody = None,
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
            temp_model = ListAuditLogResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListJoinOrgInfoHeaders(TeaModel):
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


class ListJoinOrgInfoRequest(TeaModel):
    def __init__(
        self,
        mobile: str = None,
    ):
        # 手机号码，企业内必须唯一，不可重复。如果是国际号码，请使用+xx-xxxxxx的格式。
        self.mobile = mobile

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.mobile is not None:
            result['mobile'] = self.mobile
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('mobile') is not None:
            self.mobile = m.get('mobile')
        return self


class ListJoinOrgInfoResponseBodyOrgInfoList(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        domain: str = None,
        org_full_name: str = None,
        org_name: int = None,
    ):
        # 组织ID
        self.corp_id = corp_id
        # 组织代码
        self.domain = domain
        # 组织全称
        self.org_full_name = org_full_name
        # 组织名称
        self.org_name = org_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.domain is not None:
            result['domain'] = self.domain
        if self.org_full_name is not None:
            result['orgFullName'] = self.org_full_name
        if self.org_name is not None:
            result['orgName'] = self.org_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('domain') is not None:
            self.domain = m.get('domain')
        if m.get('orgFullName') is not None:
            self.org_full_name = m.get('orgFullName')
        if m.get('orgName') is not None:
            self.org_name = m.get('orgName')
        return self


class ListJoinOrgInfoResponseBody(TeaModel):
    def __init__(
        self,
        org_info_list: List[ListJoinOrgInfoResponseBodyOrgInfoList] = None,
    ):
        # 组织信息列表
        self.org_info_list = org_info_list

    def validate(self):
        if self.org_info_list:
            for k in self.org_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['orgInfoList'] = []
        if self.org_info_list is not None:
            for k in self.org_info_list:
                result['orgInfoList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.org_info_list = []
        if m.get('orgInfoList') is not None:
            for k in m.get('orgInfoList'):
                temp_model = ListJoinOrgInfoResponseBodyOrgInfoList()
                self.org_info_list.append(temp_model.from_map(k))
        return self


class ListJoinOrgInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListJoinOrgInfoResponseBody = None,
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
            temp_model = ListJoinOrgInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListMiniAppAvailableVersionHeaders(TeaModel):
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


class ListMiniAppAvailableVersionRequest(TeaModel):
    def __init__(
        self,
        mini_app_id: str = None,
        page_number: int = None,
        page_size: int = None,
        version_type_set: List[int] = None,
    ):
        # 小程序id
        self.mini_app_id = mini_app_id
        # 分页数1
        self.page_number = page_number
        # 分页大小
        self.page_size = page_size
        # 版本类型列表，0-开发版，1-灰度版，2-发布版，3-体验版
        self.version_type_set = version_type_set

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.mini_app_id is not None:
            result['miniAppId'] = self.mini_app_id
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.version_type_set is not None:
            result['versionTypeSet'] = self.version_type_set
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('miniAppId') is not None:
            self.mini_app_id = m.get('miniAppId')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('versionTypeSet') is not None:
            self.version_type_set = m.get('versionTypeSet')
        return self


class ListMiniAppAvailableVersionResponseBodyList(TeaModel):
    def __init__(
        self,
        build_status: int = None,
        version: str = None,
    ):
        # 打包状态，0-打包中，1-成功，2-失败
        self.build_status = build_status
        # 版本
        self.version = version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.build_status is not None:
            result['buildStatus'] = self.build_status
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('buildStatus') is not None:
            self.build_status = m.get('buildStatus')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class ListMiniAppAvailableVersionResponseBody(TeaModel):
    def __init__(
        self,
        list: List[ListMiniAppAvailableVersionResponseBodyList] = None,
    ):
        # result
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
                temp_model = ListMiniAppAvailableVersionResponseBodyList()
                self.list.append(temp_model.from_map(k))
        return self


class ListMiniAppAvailableVersionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListMiniAppAvailableVersionResponseBody = None,
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
            temp_model = ListMiniAppAvailableVersionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListMiniAppHistoryVersionHeaders(TeaModel):
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


class ListMiniAppHistoryVersionRequest(TeaModel):
    def __init__(
        self,
        mini_app_id: str = None,
        page_number: int = None,
        page_size: int = None,
    ):
        # 小程序id
        self.mini_app_id = mini_app_id
        # 分页码
        self.page_number = page_number
        # 分页大小
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.mini_app_id is not None:
            result['miniAppId'] = self.mini_app_id
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('miniAppId') is not None:
            self.mini_app_id = m.get('miniAppId')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class ListMiniAppHistoryVersionResponseBodyList(TeaModel):
    def __init__(
        self,
        build_status: int = None,
        h_5bundle: str = None,
        package_size: str = None,
        package_url: str = None,
        version: str = None,
    ):
        # 构建状态
        self.build_status = build_status
        # h5Bundle地址
        self.h_5bundle = h_5bundle
        # 包大小
        self.package_size = package_size
        # 包url
        self.package_url = package_url
        # 版本
        self.version = version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.build_status is not None:
            result['buildStatus'] = self.build_status
        if self.h_5bundle is not None:
            result['h5Bundle'] = self.h_5bundle
        if self.package_size is not None:
            result['packageSize'] = self.package_size
        if self.package_url is not None:
            result['packageUrl'] = self.package_url
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('buildStatus') is not None:
            self.build_status = m.get('buildStatus')
        if m.get('h5Bundle') is not None:
            self.h_5bundle = m.get('h5Bundle')
        if m.get('packageSize') is not None:
            self.package_size = m.get('packageSize')
        if m.get('packageUrl') is not None:
            self.package_url = m.get('packageUrl')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class ListMiniAppHistoryVersionResponseBody(TeaModel):
    def __init__(
        self,
        list: List[ListMiniAppHistoryVersionResponseBodyList] = None,
    ):
        # result
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
                temp_model = ListMiniAppHistoryVersionResponseBodyList()
                self.list.append(temp_model.from_map(k))
        return self


class ListMiniAppHistoryVersionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListMiniAppHistoryVersionResponseBody = None,
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
            temp_model = ListMiniAppHistoryVersionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListPartnerRolesHeaders(TeaModel):
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


class ListPartnerRolesResponseBodyListVisibleDepts(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        name: str = None,
    ):
        # 部门id
        self.dept_id = dept_id
        # 部门名称
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class ListPartnerRolesResponseBodyListVisibleUsers(TeaModel):
    def __init__(
        self,
        name: str = None,
        user_id: str = None,
    ):
        # 员工姓名
        self.name = name
        # 员工id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class ListPartnerRolesResponseBodyListWarningDepts(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        name: str = None,
    ):
        # 部门id
        self.dept_id = dept_id
        # 部门名称
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class ListPartnerRolesResponseBodyListWarningUsers(TeaModel):
    def __init__(
        self,
        name: str = None,
        user_id: str = None,
    ):
        # 员工姓名
        self.name = name
        # 员工id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class ListPartnerRolesResponseBodyList(TeaModel):
    def __init__(
        self,
        id: int = None,
        is_necessary: int = None,
        name: str = None,
        visible_depts: List[ListPartnerRolesResponseBodyListVisibleDepts] = None,
        visible_users: List[ListPartnerRolesResponseBodyListVisibleUsers] = None,
        warning_depts: List[ListPartnerRolesResponseBodyListWarningDepts] = None,
        warning_users: List[ListPartnerRolesResponseBodyListWarningUsers] = None,
    ):
        # 角色id
        self.id = id
        # 是否必邀角色
        self.is_necessary = is_necessary
        # 角色名称
        self.name = name
        # 可见部门
        self.visible_depts = visible_depts
        # 可见员工
        self.visible_users = visible_users
        # 预警部门
        self.warning_depts = warning_depts
        # 预警成员
        self.warning_users = warning_users

    def validate(self):
        if self.visible_depts:
            for k in self.visible_depts:
                if k:
                    k.validate()
        if self.visible_users:
            for k in self.visible_users:
                if k:
                    k.validate()
        if self.warning_depts:
            for k in self.warning_depts:
                if k:
                    k.validate()
        if self.warning_users:
            for k in self.warning_users:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.is_necessary is not None:
            result['isNecessary'] = self.is_necessary
        if self.name is not None:
            result['name'] = self.name
        result['visibleDepts'] = []
        if self.visible_depts is not None:
            for k in self.visible_depts:
                result['visibleDepts'].append(k.to_map() if k else None)
        result['visibleUsers'] = []
        if self.visible_users is not None:
            for k in self.visible_users:
                result['visibleUsers'].append(k.to_map() if k else None)
        result['warningDepts'] = []
        if self.warning_depts is not None:
            for k in self.warning_depts:
                result['warningDepts'].append(k.to_map() if k else None)
        result['warningUsers'] = []
        if self.warning_users is not None:
            for k in self.warning_users:
                result['warningUsers'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isNecessary') is not None:
            self.is_necessary = m.get('isNecessary')
        if m.get('name') is not None:
            self.name = m.get('name')
        self.visible_depts = []
        if m.get('visibleDepts') is not None:
            for k in m.get('visibleDepts'):
                temp_model = ListPartnerRolesResponseBodyListVisibleDepts()
                self.visible_depts.append(temp_model.from_map(k))
        self.visible_users = []
        if m.get('visibleUsers') is not None:
            for k in m.get('visibleUsers'):
                temp_model = ListPartnerRolesResponseBodyListVisibleUsers()
                self.visible_users.append(temp_model.from_map(k))
        self.warning_depts = []
        if m.get('warningDepts') is not None:
            for k in m.get('warningDepts'):
                temp_model = ListPartnerRolesResponseBodyListWarningDepts()
                self.warning_depts.append(temp_model.from_map(k))
        self.warning_users = []
        if m.get('warningUsers') is not None:
            for k in m.get('warningUsers'):
                temp_model = ListPartnerRolesResponseBodyListWarningUsers()
                self.warning_users.append(temp_model.from_map(k))
        return self


class ListPartnerRolesResponseBody(TeaModel):
    def __init__(
        self,
        list: List[ListPartnerRolesResponseBodyList] = None,
    ):
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
                temp_model = ListPartnerRolesResponseBodyList()
                self.list.append(temp_model.from_map(k))
        return self


class ListPartnerRolesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListPartnerRolesResponseBody = None,
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
            temp_model = ListPartnerRolesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListPunchScheduleByConditionWithPagingHeaders(TeaModel):
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


class ListPunchScheduleByConditionWithPagingRequest(TeaModel):
    def __init__(
        self,
        biz_instance_id: str = None,
        max_results: int = None,
        next_token: int = None,
        schedule_date_end: str = None,
        schedule_date_start: str = None,
        user_id_list: List[str] = None,
    ):
        # 业务实例id，在该接口中表示打卡机实例id
        self.biz_instance_id = biz_instance_id
        # 分页大小
        self.max_results = max_results
        # 游标位置
        self.next_token = next_token
        # 查询日期结束时间（yyyy-MM-dd)
        self.schedule_date_end = schedule_date_end
        # 查询日期开始时间（yyyy-MM-dd)）
        self.schedule_date_start = schedule_date_start
        # 用户id列表
        self.user_id_list = user_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_instance_id is not None:
            result['bizInstanceId'] = self.biz_instance_id
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.schedule_date_end is not None:
            result['scheduleDateEnd'] = self.schedule_date_end
        if self.schedule_date_start is not None:
            result['scheduleDateStart'] = self.schedule_date_start
        if self.user_id_list is not None:
            result['userIdList'] = self.user_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizInstanceId') is not None:
            self.biz_instance_id = m.get('bizInstanceId')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('scheduleDateEnd') is not None:
            self.schedule_date_end = m.get('scheduleDateEnd')
        if m.get('scheduleDateStart') is not None:
            self.schedule_date_start = m.get('scheduleDateStart')
        if m.get('userIdList') is not None:
            self.user_id_list = m.get('userIdList')
        return self


class ListPunchScheduleByConditionWithPagingResponseBodyList(TeaModel):
    def __init__(
        self,
        biz_outer_id: str = None,
        position_name: str = None,
        punch_symbol: str = None,
        user_id: str = None,
        user_punch_time: int = None,
    ):
        # 巡点业务id，同个巡点id同一个用户最多会有两条记录，一条签到，一条签退
        self.biz_outer_id = biz_outer_id
        # 打卡巡点机名称
        self.position_name = position_name
        # 巡点类型（checkIn-签到，checkOut-签退）
        self.punch_symbol = punch_symbol
        # 用户id
        self.user_id = user_id
        # 用户巡点打卡时间
        self.user_punch_time = user_punch_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_outer_id is not None:
            result['bizOuterId'] = self.biz_outer_id
        if self.position_name is not None:
            result['positionName'] = self.position_name
        if self.punch_symbol is not None:
            result['punchSymbol'] = self.punch_symbol
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.user_punch_time is not None:
            result['userPunchTime'] = self.user_punch_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizOuterId') is not None:
            self.biz_outer_id = m.get('bizOuterId')
        if m.get('positionName') is not None:
            self.position_name = m.get('positionName')
        if m.get('punchSymbol') is not None:
            self.punch_symbol = m.get('punchSymbol')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('userPunchTime') is not None:
            self.user_punch_time = m.get('userPunchTime')
        return self


class ListPunchScheduleByConditionWithPagingResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[ListPunchScheduleByConditionWithPagingResponseBodyList] = None,
        next_token: int = None,
    ):
        # 是否有更多
        self.has_more = has_more
        # 返回列表
        self.list = list
        # 下一次游标位置
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
                temp_model = ListPunchScheduleByConditionWithPagingResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class ListPunchScheduleByConditionWithPagingResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListPunchScheduleByConditionWithPagingResponseBody = None,
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
            temp_model = ListPunchScheduleByConditionWithPagingResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PublishFileChangeNoticeHeaders(TeaModel):
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


class PublishFileChangeNoticeRequest(TeaModel):
    def __init__(
        self,
        file_id: str = None,
        operate_type: str = None,
        operator_union_id: str = None,
        space_id: str = None,
    ):
        # 钉盘文件id
        self.file_id = file_id
        # 操作类型: 1-添加 2-修改
        self.operate_type = operate_type
        # 操作人unionId
        self.operator_union_id = operator_union_id
        # 钉盘spaceId
        self.space_id = space_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_id is not None:
            result['fileId'] = self.file_id
        if self.operate_type is not None:
            result['operateType'] = self.operate_type
        if self.operator_union_id is not None:
            result['operatorUnionId'] = self.operator_union_id
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileId') is not None:
            self.file_id = m.get('fileId')
        if m.get('operateType') is not None:
            self.operate_type = m.get('operateType')
        if m.get('operatorUnionId') is not None:
            self.operator_union_id = m.get('operatorUnionId')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        return self


class PublishFileChangeNoticeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        return self


class PushBadgeHeaders(TeaModel):
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


class PushBadgeRequestBadgeItems(TeaModel):
    def __init__(
        self,
        push_value: str = None,
        user_id: str = None,
    ):
        # 推送的内容（目前仅限数字）
        self.push_value = push_value
        # 员工ID。
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.push_value is not None:
            result['pushValue'] = self.push_value
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pushValue') is not None:
            self.push_value = m.get('pushValue')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class PushBadgeRequest(TeaModel):
    def __init__(
        self,
        agent_id: str = None,
        badge_items: List[PushBadgeRequestBadgeItems] = None,
        push_type: str = None,
    ):
        # 微应用agentId
        self.agent_id = agent_id
        # 推送列表
        self.badge_items = badge_items
        # 推送类型
        self.push_type = push_type

    def validate(self):
        if self.badge_items:
            for k in self.badge_items:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        result['badgeItems'] = []
        if self.badge_items is not None:
            for k in self.badge_items:
                result['badgeItems'].append(k.to_map() if k else None)
        if self.push_type is not None:
            result['pushType'] = self.push_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        self.badge_items = []
        if m.get('badgeItems') is not None:
            for k in m.get('badgeItems'):
                temp_model = PushBadgeRequestBadgeItems()
                self.badge_items.append(temp_model.from_map(k))
        if m.get('pushType') is not None:
            self.push_type = m.get('pushType')
        return self


class PushBadgeResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        # 是否成功
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


class PushBadgeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: PushBadgeResponseBody = None,
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
            temp_model = PushBadgeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryAcrossCloudStroageConfigsHeaders(TeaModel):
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


class QueryAcrossCloudStroageConfigsRequest(TeaModel):
    def __init__(
        self,
        target_cloud_type: int = None,
        target_corp_id: str = None,
    ):
        # 云厂商类型
        self.target_cloud_type = target_cloud_type
        # 企业的corpId
        self.target_corp_id = target_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.target_cloud_type is not None:
            result['targetCloudType'] = self.target_cloud_type
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('targetCloudType') is not None:
            self.target_cloud_type = m.get('targetCloudType')
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        return self


class QueryAcrossCloudStroageConfigsResponseBody(TeaModel):
    def __init__(
        self,
        access_key_id: str = None,
        access_key_secret: str = None,
        bucket_name: str = None,
        cloud_type: int = None,
        endpoint: str = None,
    ):
        # 密匙id
        self.access_key_id = access_key_id
        # 密匙密码
        self.access_key_secret = access_key_secret
        # bucket名称
        self.bucket_name = bucket_name
        # 云厂商类型
        self.cloud_type = cloud_type
        # 存储域名地址
        self.endpoint = endpoint

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key_id is not None:
            result['accessKeyId'] = self.access_key_id
        if self.access_key_secret is not None:
            result['accessKeySecret'] = self.access_key_secret
        if self.bucket_name is not None:
            result['bucketName'] = self.bucket_name
        if self.cloud_type is not None:
            result['cloudType'] = self.cloud_type
        if self.endpoint is not None:
            result['endpoint'] = self.endpoint
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKeyId') is not None:
            self.access_key_id = m.get('accessKeyId')
        if m.get('accessKeySecret') is not None:
            self.access_key_secret = m.get('accessKeySecret')
        if m.get('bucketName') is not None:
            self.bucket_name = m.get('bucketName')
        if m.get('cloudType') is not None:
            self.cloud_type = m.get('cloudType')
        if m.get('endpoint') is not None:
            self.endpoint = m.get('endpoint')
        return self


class QueryAcrossCloudStroageConfigsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryAcrossCloudStroageConfigsResponseBody = None,
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
            temp_model = QueryAcrossCloudStroageConfigsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryPartnerInfoHeaders(TeaModel):
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


class QueryPartnerInfoResponseBodyPartnerDeptListPartnerLabelModelLevel1(TeaModel):
    def __init__(
        self,
        label_id: int = None,
        labelname: str = None,
    ):
        # 标签id
        self.label_id = label_id
        # 标签名称
        self.labelname = labelname

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.label_id is not None:
            result['labelId'] = self.label_id
        if self.labelname is not None:
            result['labelname'] = self.labelname
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('labelId') is not None:
            self.label_id = m.get('labelId')
        if m.get('labelname') is not None:
            self.labelname = m.get('labelname')
        return self


class QueryPartnerInfoResponseBodyPartnerDeptList(TeaModel):
    def __init__(
        self,
        member_count: int = None,
        partner_label_model_level_1: QueryPartnerInfoResponseBodyPartnerDeptListPartnerLabelModelLevel1 = None,
        partner_num: str = None,
        title: str = None,
        value: str = None,
    ):
        # 部门人数
        self.member_count = member_count
        # 一级伙伴类型
        self.partner_label_model_level_1 = partner_label_model_level_1
        # 伙伴编码
        self.partner_num = partner_num
        # 部门名称
        self.title = title
        # 部门id
        self.value = value

    def validate(self):
        if self.partner_label_model_level_1:
            self.partner_label_model_level_1.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.member_count is not None:
            result['memberCount'] = self.member_count
        if self.partner_label_model_level_1 is not None:
            result['partnerLabelModelLevel1'] = self.partner_label_model_level_1.to_map()
        if self.partner_num is not None:
            result['partnerNum'] = self.partner_num
        if self.title is not None:
            result['title'] = self.title
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('memberCount') is not None:
            self.member_count = m.get('memberCount')
        if m.get('partnerLabelModelLevel1') is not None:
            temp_model = QueryPartnerInfoResponseBodyPartnerDeptListPartnerLabelModelLevel1()
            self.partner_label_model_level_1 = temp_model.from_map(m['partnerLabelModelLevel1'])
        if m.get('partnerNum') is not None:
            self.partner_num = m.get('partnerNum')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class QueryPartnerInfoResponseBodyPartnerLabelList(TeaModel):
    def __init__(
        self,
        id: int = None,
        name: str = None,
    ):
        # label id
        self.id = id
        # label value
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class QueryPartnerInfoResponseBody(TeaModel):
    def __init__(
        self,
        partner_dept_list: List[QueryPartnerInfoResponseBodyPartnerDeptList] = None,
        partner_label_list: List[QueryPartnerInfoResponseBodyPartnerLabelList] = None,
        user_id: str = None,
    ):
        # 部门列表
        self.partner_dept_list = partner_dept_list
        # 伙伴标签
        self.partner_label_list = partner_label_list
        # 员工id
        self.user_id = user_id

    def validate(self):
        if self.partner_dept_list:
            for k in self.partner_dept_list:
                if k:
                    k.validate()
        if self.partner_label_list:
            for k in self.partner_label_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['partnerDeptList'] = []
        if self.partner_dept_list is not None:
            for k in self.partner_dept_list:
                result['partnerDeptList'].append(k.to_map() if k else None)
        result['partnerLabelList'] = []
        if self.partner_label_list is not None:
            for k in self.partner_label_list:
                result['partnerLabelList'].append(k.to_map() if k else None)
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.partner_dept_list = []
        if m.get('partnerDeptList') is not None:
            for k in m.get('partnerDeptList'):
                temp_model = QueryPartnerInfoResponseBodyPartnerDeptList()
                self.partner_dept_list.append(temp_model.from_map(k))
        self.partner_label_list = []
        if m.get('partnerLabelList') is not None:
            for k in m.get('partnerLabelList'):
                temp_model = QueryPartnerInfoResponseBodyPartnerLabelList()
                self.partner_label_list.append(temp_model.from_map(k))
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryPartnerInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryPartnerInfoResponseBody = None,
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
            temp_model = QueryPartnerInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RollbackMiniAppVersionHeaders(TeaModel):
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


class RollbackMiniAppVersionRequest(TeaModel):
    def __init__(
        self,
        mini_app_id: str = None,
        rollback_version: str = None,
        target_version: str = None,
    ):
        # 小程序id
        self.mini_app_id = mini_app_id
        # 被回滚版本
        self.rollback_version = rollback_version
        # 回滚到的版本
        self.target_version = target_version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.mini_app_id is not None:
            result['miniAppId'] = self.mini_app_id
        if self.rollback_version is not None:
            result['rollbackVersion'] = self.rollback_version
        if self.target_version is not None:
            result['targetVersion'] = self.target_version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('miniAppId') is not None:
            self.mini_app_id = m.get('miniAppId')
        if m.get('rollbackVersion') is not None:
            self.rollback_version = m.get('rollbackVersion')
        if m.get('targetVersion') is not None:
            self.target_version = m.get('targetVersion')
        return self


class RollbackMiniAppVersionResponseBody(TeaModel):
    def __init__(
        self,
        cause: str = None,
        code: int = None,
    ):
        # 失败原因
        self.cause = cause
        # 结果码
        self.code = code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cause is not None:
            result['cause'] = self.cause
        if self.code is not None:
            result['code'] = self.code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cause') is not None:
            self.cause = m.get('cause')
        if m.get('code') is not None:
            self.code = m.get('code')
        return self


class RollbackMiniAppVersionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: RollbackMiniAppVersionResponseBody = None,
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
            temp_model = RollbackMiniAppVersionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SaveAcrossCloudStroageConfigsHeaders(TeaModel):
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


class SaveAcrossCloudStroageConfigsRequest(TeaModel):
    def __init__(
        self,
        access_key_id: str = None,
        access_key_secret: str = None,
        bucket_name: str = None,
        cloud_type: int = None,
        endpoint: str = None,
        target_corp_id: str = None,
    ):
        # 密匙id
        self.access_key_id = access_key_id
        # 密匙密码
        self.access_key_secret = access_key_secret
        # bucket名称
        self.bucket_name = bucket_name
        # 云厂商类型
        self.cloud_type = cloud_type
        # 存储域名地址
        self.endpoint = endpoint
        # 企业id
        self.target_corp_id = target_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key_id is not None:
            result['accessKeyId'] = self.access_key_id
        if self.access_key_secret is not None:
            result['accessKeySecret'] = self.access_key_secret
        if self.bucket_name is not None:
            result['bucketName'] = self.bucket_name
        if self.cloud_type is not None:
            result['cloudType'] = self.cloud_type
        if self.endpoint is not None:
            result['endpoint'] = self.endpoint
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKeyId') is not None:
            self.access_key_id = m.get('accessKeyId')
        if m.get('accessKeySecret') is not None:
            self.access_key_secret = m.get('accessKeySecret')
        if m.get('bucketName') is not None:
            self.bucket_name = m.get('bucketName')
        if m.get('cloudType') is not None:
            self.cloud_type = m.get('cloudType')
        if m.get('endpoint') is not None:
            self.endpoint = m.get('endpoint')
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        return self


class SaveAcrossCloudStroageConfigsResponseBody(TeaModel):
    def __init__(
        self,
        access_key_id: str = None,
        endpoint: str = None,
        state: int = None,
    ):
        # 密匙ID
        self.access_key_id = access_key_id
        # 存储域名地址
        self.endpoint = endpoint
        # 执行结果
        self.state = state

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key_id is not None:
            result['accessKeyId'] = self.access_key_id
        if self.endpoint is not None:
            result['endpoint'] = self.endpoint
        if self.state is not None:
            result['state'] = self.state
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKeyId') is not None:
            self.access_key_id = m.get('accessKeyId')
        if m.get('endpoint') is not None:
            self.endpoint = m.get('endpoint')
        if m.get('state') is not None:
            self.state = m.get('state')
        return self


class SaveAcrossCloudStroageConfigsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SaveAcrossCloudStroageConfigsResponseBody = None,
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
            temp_model = SaveAcrossCloudStroageConfigsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SaveAndSubmitAuthInfoHeaders(TeaModel):
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


class SaveAndSubmitAuthInfoRequest(TeaModel):
    def __init__(
        self,
        apply_remark: str = None,
        authorize_media_id: str = None,
        industry: str = None,
        legal_person: str = None,
        legal_person_id_card: str = None,
        license_media_id: str = None,
        loc_city: int = None,
        loc_city_name: str = None,
        loc_province: int = None,
        loc_province_name: str = None,
        mobile_num: str = None,
        org_name: str = None,
        organization_code: str = None,
        organization_code_media_id: str = None,
        regist_location: str = None,
        regist_num: str = None,
        target_corp_id: str = None,
        unified_social_credit: str = None,
    ):
        # 申请说明
        self.apply_remark = apply_remark
        # 认证书图片mediaId
        self.authorize_media_id = authorize_media_id
        # 行业
        self.industry = industry
        # 企业法人
        self.legal_person = legal_person
        # 企业法人身份证
        self.legal_person_id_card = legal_person_id_card
        # 营业执照图片mediaId
        self.license_media_id = license_media_id
        # 城市编码
        self.loc_city = loc_city
        # 城市名字
        self.loc_city_name = loc_city_name
        # 省份编码
        self.loc_province = loc_province
        # 省份名字
        self.loc_province_name = loc_province_name
        # 申请人手机号（需要实名认证）
        self.mobile_num = mobile_num
        # 组织名，提交认证的时候可以修改
        self.org_name = org_name
        # 组织机构代码证号（格式11111111-1）
        self.organization_code = organization_code
        # 组织机构代码证图片mediaId
        self.organization_code_media_id = organization_code_media_id
        # 认证企业详细地址
        self.regist_location = regist_location
        # 营业执照注册号（一般15位）
        self.regist_num = regist_num
        # 企业id
        self.target_corp_id = target_corp_id
        # 社会统一信用代码（固定18位）
        self.unified_social_credit = unified_social_credit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.apply_remark is not None:
            result['applyRemark'] = self.apply_remark
        if self.authorize_media_id is not None:
            result['authorizeMediaId'] = self.authorize_media_id
        if self.industry is not None:
            result['industry'] = self.industry
        if self.legal_person is not None:
            result['legalPerson'] = self.legal_person
        if self.legal_person_id_card is not None:
            result['legalPersonIdCard'] = self.legal_person_id_card
        if self.license_media_id is not None:
            result['licenseMediaId'] = self.license_media_id
        if self.loc_city is not None:
            result['locCity'] = self.loc_city
        if self.loc_city_name is not None:
            result['locCityName'] = self.loc_city_name
        if self.loc_province is not None:
            result['locProvince'] = self.loc_province
        if self.loc_province_name is not None:
            result['locProvinceName'] = self.loc_province_name
        if self.mobile_num is not None:
            result['mobileNum'] = self.mobile_num
        if self.org_name is not None:
            result['orgName'] = self.org_name
        if self.organization_code is not None:
            result['organizationCode'] = self.organization_code
        if self.organization_code_media_id is not None:
            result['organizationCodeMediaId'] = self.organization_code_media_id
        if self.regist_location is not None:
            result['registLocation'] = self.regist_location
        if self.regist_num is not None:
            result['registNum'] = self.regist_num
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        if self.unified_social_credit is not None:
            result['unifiedSocialCredit'] = self.unified_social_credit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('applyRemark') is not None:
            self.apply_remark = m.get('applyRemark')
        if m.get('authorizeMediaId') is not None:
            self.authorize_media_id = m.get('authorizeMediaId')
        if m.get('industry') is not None:
            self.industry = m.get('industry')
        if m.get('legalPerson') is not None:
            self.legal_person = m.get('legalPerson')
        if m.get('legalPersonIdCard') is not None:
            self.legal_person_id_card = m.get('legalPersonIdCard')
        if m.get('licenseMediaId') is not None:
            self.license_media_id = m.get('licenseMediaId')
        if m.get('locCity') is not None:
            self.loc_city = m.get('locCity')
        if m.get('locCityName') is not None:
            self.loc_city_name = m.get('locCityName')
        if m.get('locProvince') is not None:
            self.loc_province = m.get('locProvince')
        if m.get('locProvinceName') is not None:
            self.loc_province_name = m.get('locProvinceName')
        if m.get('mobileNum') is not None:
            self.mobile_num = m.get('mobileNum')
        if m.get('orgName') is not None:
            self.org_name = m.get('orgName')
        if m.get('organizationCode') is not None:
            self.organization_code = m.get('organizationCode')
        if m.get('organizationCodeMediaId') is not None:
            self.organization_code_media_id = m.get('organizationCodeMediaId')
        if m.get('registLocation') is not None:
            self.regist_location = m.get('registLocation')
        if m.get('registNum') is not None:
            self.regist_num = m.get('registNum')
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        if m.get('unifiedSocialCredit') is not None:
            self.unified_social_credit = m.get('unifiedSocialCredit')
        return self


class SaveAndSubmitAuthInfoResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        # 是否成功。
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


class SaveAndSubmitAuthInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SaveAndSubmitAuthInfoResponseBody = None,
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
            temp_model = SaveAndSubmitAuthInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SearchOrgInnerGroupInfoHeaders(TeaModel):
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


class SearchOrgInnerGroupInfoRequest(TeaModel):
    def __init__(
        self,
        create_time_end: int = None,
        create_time_start: int = None,
        group_members_count_end: int = None,
        group_members_count_start: int = None,
        group_name: str = None,
        group_owner: str = None,
        last_active_time_end: int = None,
        last_active_time_start: int = None,
        operator_user_id: str = None,
        page_size: int = None,
        page_start: int = None,
        sync_to_dingpan: int = None,
        uuid: str = None,
    ):
        # createTimeEnd
        self.create_time_end = create_time_end
        # createTimeStart
        self.create_time_start = create_time_start
        # groupMembersCntEnd
        self.group_members_count_end = group_members_count_end
        # groupMembersCntStart
        self.group_members_count_start = group_members_count_start
        # groupName
        self.group_name = group_name
        # groupOwner
        self.group_owner = group_owner
        # lastActiveTimeEnd
        self.last_active_time_end = last_active_time_end
        # lastActiveTimeStart
        self.last_active_time_start = last_active_time_start
        # operatorUserId
        self.operator_user_id = operator_user_id
        # pageSize
        self.page_size = page_size
        # pageStart
        self.page_start = page_start
        # syncToDingpan
        self.sync_to_dingpan = sync_to_dingpan
        # uuid
        self.uuid = uuid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_time_end is not None:
            result['createTimeEnd'] = self.create_time_end
        if self.create_time_start is not None:
            result['createTimeStart'] = self.create_time_start
        if self.group_members_count_end is not None:
            result['groupMembersCountEnd'] = self.group_members_count_end
        if self.group_members_count_start is not None:
            result['groupMembersCountStart'] = self.group_members_count_start
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.group_owner is not None:
            result['groupOwner'] = self.group_owner
        if self.last_active_time_end is not None:
            result['lastActiveTimeEnd'] = self.last_active_time_end
        if self.last_active_time_start is not None:
            result['lastActiveTimeStart'] = self.last_active_time_start
        if self.operator_user_id is not None:
            result['operatorUserId'] = self.operator_user_id
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.page_start is not None:
            result['pageStart'] = self.page_start
        if self.sync_to_dingpan is not None:
            result['syncToDingpan'] = self.sync_to_dingpan
        if self.uuid is not None:
            result['uuid'] = self.uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createTimeEnd') is not None:
            self.create_time_end = m.get('createTimeEnd')
        if m.get('createTimeStart') is not None:
            self.create_time_start = m.get('createTimeStart')
        if m.get('groupMembersCountEnd') is not None:
            self.group_members_count_end = m.get('groupMembersCountEnd')
        if m.get('groupMembersCountStart') is not None:
            self.group_members_count_start = m.get('groupMembersCountStart')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('groupOwner') is not None:
            self.group_owner = m.get('groupOwner')
        if m.get('lastActiveTimeEnd') is not None:
            self.last_active_time_end = m.get('lastActiveTimeEnd')
        if m.get('lastActiveTimeStart') is not None:
            self.last_active_time_start = m.get('lastActiveTimeStart')
        if m.get('operatorUserId') is not None:
            self.operator_user_id = m.get('operatorUserId')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('pageStart') is not None:
            self.page_start = m.get('pageStart')
        if m.get('syncToDingpan') is not None:
            self.sync_to_dingpan = m.get('syncToDingpan')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        return self


class SearchOrgInnerGroupInfoResponseBodyItems(TeaModel):
    def __init__(
        self,
        group_admins_count: int = None,
        group_create_time: int = None,
        group_last_active_time: int = None,
        group_last_active_time_show: str = None,
        group_members_count: int = None,
        group_name: str = None,
        group_owner: str = None,
        group_owner_user_id: str = None,
        open_conversation_id: str = None,
        status: int = None,
        sync_to_dingpan: int = None,
        template_id: str = None,
        template_name: str = None,
        used_quota: int = None,
    ):
        self.group_admins_count = group_admins_count
        self.group_create_time = group_create_time
        self.group_last_active_time = group_last_active_time
        self.group_last_active_time_show = group_last_active_time_show
        self.group_members_count = group_members_count
        self.group_name = group_name
        self.group_owner = group_owner
        self.group_owner_user_id = group_owner_user_id
        self.open_conversation_id = open_conversation_id
        self.status = status
        self.sync_to_dingpan = sync_to_dingpan
        self.template_id = template_id
        self.template_name = template_name
        self.used_quota = used_quota

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_admins_count is not None:
            result['groupAdminsCount'] = self.group_admins_count
        if self.group_create_time is not None:
            result['groupCreateTime'] = self.group_create_time
        if self.group_last_active_time is not None:
            result['groupLastActiveTime'] = self.group_last_active_time
        if self.group_last_active_time_show is not None:
            result['groupLastActiveTimeShow'] = self.group_last_active_time_show
        if self.group_members_count is not None:
            result['groupMembersCount'] = self.group_members_count
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.group_owner is not None:
            result['groupOwner'] = self.group_owner
        if self.group_owner_user_id is not None:
            result['groupOwnerUserId'] = self.group_owner_user_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.status is not None:
            result['status'] = self.status
        if self.sync_to_dingpan is not None:
            result['syncToDingpan'] = self.sync_to_dingpan
        if self.template_id is not None:
            result['templateId'] = self.template_id
        if self.template_name is not None:
            result['templateName'] = self.template_name
        if self.used_quota is not None:
            result['usedQuota'] = self.used_quota
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupAdminsCount') is not None:
            self.group_admins_count = m.get('groupAdminsCount')
        if m.get('groupCreateTime') is not None:
            self.group_create_time = m.get('groupCreateTime')
        if m.get('groupLastActiveTime') is not None:
            self.group_last_active_time = m.get('groupLastActiveTime')
        if m.get('groupLastActiveTimeShow') is not None:
            self.group_last_active_time_show = m.get('groupLastActiveTimeShow')
        if m.get('groupMembersCount') is not None:
            self.group_members_count = m.get('groupMembersCount')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('groupOwner') is not None:
            self.group_owner = m.get('groupOwner')
        if m.get('groupOwnerUserId') is not None:
            self.group_owner_user_id = m.get('groupOwnerUserId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('syncToDingpan') is not None:
            self.sync_to_dingpan = m.get('syncToDingpan')
        if m.get('templateId') is not None:
            self.template_id = m.get('templateId')
        if m.get('templateName') is not None:
            self.template_name = m.get('templateName')
        if m.get('usedQuota') is not None:
            self.used_quota = m.get('usedQuota')
        return self


class SearchOrgInnerGroupInfoResponseBody(TeaModel):
    def __init__(
        self,
        item_count: int = None,
        items: List[SearchOrgInnerGroupInfoResponseBodyItems] = None,
        total_count: int = None,
    ):
        self.item_count = item_count
        self.items = items
        self.total_count = total_count

    def validate(self):
        if self.items:
            for k in self.items:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.item_count is not None:
            result['itemCount'] = self.item_count
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('itemCount') is not None:
            self.item_count = m.get('itemCount')
        self.items = []
        if m.get('items') is not None:
            for k in m.get('items'):
                temp_model = SearchOrgInnerGroupInfoResponseBodyItems()
                self.items.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class SearchOrgInnerGroupInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SearchOrgInnerGroupInfoResponseBody = None,
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
            temp_model = SearchOrgInnerGroupInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SendAppDingHeaders(TeaModel):
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


class SendAppDingRequest(TeaModel):
    def __init__(
        self,
        content: str = None,
        userids: List[str] = None,
    ):
        # 消息内容
        self.content = content
        # 接收DING消息的用户列表
        self.userids = userids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.userids is not None:
            result['userids'] = self.userids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('userids') is not None:
            self.userids = m.get('userids')
        return self


class SendAppDingResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        return self


class SendInvitationHeaders(TeaModel):
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


class SendInvitationRequest(TeaModel):
    def __init__(
        self,
        dept_id: str = None,
        org_alias: str = None,
        partner_label_id: int = None,
        partner_num: str = None,
        phone: str = None,
    ):
        # 部门id
        self.dept_id = dept_id
        # 组织别名
        self.org_alias = org_alias
        # 伙伴标签id
        self.partner_label_id = partner_label_id
        # 伙伴编码
        self.partner_num = partner_num
        # 手机号
        self.phone = phone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.org_alias is not None:
            result['orgAlias'] = self.org_alias
        if self.partner_label_id is not None:
            result['partnerLabelId'] = self.partner_label_id
        if self.partner_num is not None:
            result['partnerNum'] = self.partner_num
        if self.phone is not None:
            result['phone'] = self.phone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('orgAlias') is not None:
            self.org_alias = m.get('orgAlias')
        if m.get('partnerLabelId') is not None:
            self.partner_label_id = m.get('partnerLabelId')
        if m.get('partnerNum') is not None:
            self.partner_num = m.get('partnerNum')
        if m.get('phone') is not None:
            self.phone = m.get('phone')
        return self


class SendInvitationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        return self


class SendPhoneDingHeaders(TeaModel):
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


class SendPhoneDingRequest(TeaModel):
    def __init__(
        self,
        content: str = None,
        userids: List[str] = None,
    ):
        # 消息内容
        self.content = content
        # 接收DING消息的用户列表
        self.userids = userids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.userids is not None:
            result['userids'] = self.userids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('userids') is not None:
            self.userids = m.get('userids')
        return self


class SendPhoneDingResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        # 本次操作是否更新成功
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


class SendPhoneDingResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SendPhoneDingResponseBody = None,
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
            temp_model = SendPhoneDingResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SetDeptPartnerTypeAndNumHeaders(TeaModel):
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


class SetDeptPartnerTypeAndNumRequest(TeaModel):
    def __init__(
        self,
        dept_id: str = None,
        label_ids: List[str] = None,
        partner_num: str = None,
    ):
        # 部门id
        self.dept_id = dept_id
        # 伙伴类型id列表
        self.label_ids = label_ids
        # 伙伴编码
        self.partner_num = partner_num

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.label_ids is not None:
            result['labelIds'] = self.label_ids
        if self.partner_num is not None:
            result['partnerNum'] = self.partner_num
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('labelIds') is not None:
            self.label_ids = m.get('labelIds')
        if m.get('partnerNum') is not None:
            self.partner_num = m.get('partnerNum')
        return self


class SetDeptPartnerTypeAndNumResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        return self


class UpdateFileStatusHeaders(TeaModel):
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


class UpdateFileStatusRequest(TeaModel):
    def __init__(
        self,
        request_ids: List[str] = None,
        status: int = None,
    ):
        # 请求id列表
        self.request_ids = request_ids
        # 更新的状态
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_ids is not None:
            result['requestIds'] = self.request_ids
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestIds') is not None:
            self.request_ids = m.get('requestIds')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class UpdateFileStatusResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        # 是否成功
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


class UpdateFileStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateFileStatusResponseBody = None,
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
            temp_model = UpdateFileStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateMiniAppVersionStatusHeaders(TeaModel):
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


class UpdateMiniAppVersionStatusRequest(TeaModel):
    def __init__(
        self,
        mini_app_id: str = None,
        version: str = None,
        version_type: int = None,
    ):
        # 小程序id
        self.mini_app_id = mini_app_id
        # 版本
        self.version = version
        # 版本类型
        self.version_type = version_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.mini_app_id is not None:
            result['miniAppId'] = self.mini_app_id
        if self.version is not None:
            result['version'] = self.version
        if self.version_type is not None:
            result['versionType'] = self.version_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('miniAppId') is not None:
            self.mini_app_id = m.get('miniAppId')
        if m.get('version') is not None:
            self.version = m.get('version')
        if m.get('versionType') is not None:
            self.version_type = m.get('versionType')
        return self


class UpdateMiniAppVersionStatusResponseBody(TeaModel):
    def __init__(
        self,
        cause: str = None,
        code: str = None,
    ):
        # 原因
        self.cause = cause
        # 返回码
        self.code = code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cause is not None:
            result['cause'] = self.cause
        if self.code is not None:
            result['code'] = self.code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cause') is not None:
            self.cause = m.get('cause')
        if m.get('code') is not None:
            self.code = m.get('code')
        return self


class UpdateMiniAppVersionStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateMiniAppVersionStatusResponseBody = None,
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
            temp_model = UpdateMiniAppVersionStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdatePartnerVisibilityHeaders(TeaModel):
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


class UpdatePartnerVisibilityRequest(TeaModel):
    def __init__(
        self,
        dept_ids: List[int] = None,
        label_id: int = None,
        user_ids: List[str] = None,
    ):
        # 可见的部门id
        self.dept_ids = dept_ids
        # 标签id
        self.label_id = label_id
        # 可见的员工id
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_ids is not None:
            result['deptIds'] = self.dept_ids
        if self.label_id is not None:
            result['labelId'] = self.label_id
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptIds') is not None:
            self.dept_ids = m.get('deptIds')
        if m.get('labelId') is not None:
            self.label_id = m.get('labelId')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class UpdatePartnerVisibilityResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: bool = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            self.body = m.get('body')
        return self


class UpdateRoleVisibilityHeaders(TeaModel):
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


class UpdateRoleVisibilityRequest(TeaModel):
    def __init__(
        self,
        dept_ids: List[int] = None,
        label_id: int = None,
        user_ids: List[str] = None,
    ):
        # 可见的部门id
        self.dept_ids = dept_ids
        # 标签id
        self.label_id = label_id
        # 可见的员工id
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_ids is not None:
            result['deptIds'] = self.dept_ids
        if self.label_id is not None:
            result['labelId'] = self.label_id
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptIds') is not None:
            self.dept_ids = m.get('deptIds')
        if m.get('labelId') is not None:
            self.label_id = m.get('labelId')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class UpdateRoleVisibilityResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: bool = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            self.body = m.get('body')
        return self


class UpdateStorageModeHeaders(TeaModel):
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


class UpdateStorageModeRequest(TeaModel):
    def __init__(
        self,
        file_storage_mode: str = None,
        target_corp_id: str = None,
    ):
        # 专属文件跨云存储类型 0：公有模式，1：私有模式，注意，如不更新，则不填写这个字段，字段一旦有值，都会触发原有配置的删除
        self.file_storage_mode = file_storage_mode
        # 企业id
        self.target_corp_id = target_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_storage_mode is not None:
            result['fileStorageMode'] = self.file_storage_mode
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileStorageMode') is not None:
            self.file_storage_mode = m.get('fileStorageMode')
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        return self


class UpdateStorageModeResponseBody(TeaModel):
    def __init__(
        self,
        target_corp_id: str = None,
    ):
        # 组织id
        self.target_corp_id = target_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        return self


class UpdateStorageModeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateStorageModeResponseBody = None,
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
            temp_model = UpdateStorageModeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


