# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class SendContractCardHeaders(TeaModel):
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


class SendContractCardRequestContractInfo(TeaModel):
    def __init__(
        self,
        contract_code: str = None,
        contract_name: str = None,
        create_time: int = None,
        sign_user_name: str = None,
    ):
        # 合同编号
        self.contract_code = contract_code
        # 合同名称
        self.contract_name = contract_name
        # 签署时间
        self.create_time = create_time
        # 签署人名称
        self.sign_user_name = sign_user_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.contract_code is not None:
            result['contractCode'] = self.contract_code
        if self.contract_name is not None:
            result['contractName'] = self.contract_name
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.sign_user_name is not None:
            result['signUserName'] = self.sign_user_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('contractCode') is not None:
            self.contract_code = m.get('contractCode')
        if m.get('contractName') is not None:
            self.contract_name = m.get('contractName')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('signUserName') is not None:
            self.sign_user_name = m.get('signUserName')
        return self


class SendContractCardRequestReceivers(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        user_id: str = None,
        user_type: str = None,
    ):
        # 接收者所在组织
        self.corp_id = corp_id
        # 用户id
        self.user_id = user_id
        # 用户类型
        self.user_type = user_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.user_type is not None:
            result['userType'] = self.user_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('userType') is not None:
            self.user_type = m.get('userType')
        return self


class SendContractCardRequestSender(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        user_id: str = None,
        user_type: str = None,
    ):
        # 发起人所在组织
        self.corp_id = corp_id
        # 用户id
        self.user_id = user_id
        # 用户类型
        self.user_type = user_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.user_type is not None:
            result['userType'] = self.user_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('userType') is not None:
            self.user_type = m.get('userType')
        return self


class SendContractCardRequest(TeaModel):
    def __init__(
        self,
        card_type: str = None,
        contract_info: SendContractCardRequestContractInfo = None,
        corp_id: str = None,
        extension: Dict[str, str] = None,
        process_instance_id: str = None,
        receive_groups: List[str] = None,
        receivers: List[SendContractCardRequestReceivers] = None,
        sender: SendContractCardRequestSender = None,
        sync_single_chat: bool = None,
    ):
        # 卡片类型
        self.card_type = card_type
        # 合同信息
        self.contract_info = contract_info
        # 合同的企业id
        self.corp_id = corp_id
        # 额外信息
        self.extension = extension
        # 审批实例id
        self.process_instance_id = process_instance_id
        # 接收群id
        self.receive_groups = receive_groups
        # 接收者
        self.receivers = receivers
        # 发送者
        self.sender = sender
        # 是否同步单聊
        self.sync_single_chat = sync_single_chat

    def validate(self):
        if self.contract_info:
            self.contract_info.validate()
        if self.receivers:
            for k in self.receivers:
                if k:
                    k.validate()
        if self.sender:
            self.sender.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.card_type is not None:
            result['cardType'] = self.card_type
        if self.contract_info is not None:
            result['contractInfo'] = self.contract_info.to_map()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.extension is not None:
            result['extension'] = self.extension
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.receive_groups is not None:
            result['receiveGroups'] = self.receive_groups
        result['receivers'] = []
        if self.receivers is not None:
            for k in self.receivers:
                result['receivers'].append(k.to_map() if k else None)
        if self.sender is not None:
            result['sender'] = self.sender.to_map()
        if self.sync_single_chat is not None:
            result['syncSingleChat'] = self.sync_single_chat
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cardType') is not None:
            self.card_type = m.get('cardType')
        if m.get('contractInfo') is not None:
            temp_model = SendContractCardRequestContractInfo()
            self.contract_info = temp_model.from_map(m['contractInfo'])
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('extension') is not None:
            self.extension = m.get('extension')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('receiveGroups') is not None:
            self.receive_groups = m.get('receiveGroups')
        self.receivers = []
        if m.get('receivers') is not None:
            for k in m.get('receivers'):
                temp_model = SendContractCardRequestReceivers()
                self.receivers.append(temp_model.from_map(k))
        if m.get('sender') is not None:
            temp_model = SendContractCardRequestSender()
            self.sender = temp_model.from_map(m['sender'])
        if m.get('syncSingleChat') is not None:
            self.sync_single_chat = m.get('syncSingleChat')
        return self


class SendContractCardResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        # 成功
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


class SendContractCardResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SendContractCardResponseBody = None,
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
            temp_model = SendContractCardResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


