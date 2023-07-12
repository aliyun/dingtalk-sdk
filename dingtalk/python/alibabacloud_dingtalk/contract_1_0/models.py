# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class EsignQueryGrantInfoHeaders(TeaModel):
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


class EsignQueryGrantInfoRequest(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        extension: Dict[str, str] = None,
        union_id: str = None,
    ):
        self.corp_id = corp_id
        self.extension = extension
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.extension is not None:
            result['extension'] = self.extension
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('extension') is not None:
            self.extension = m.get('extension')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class EsignQueryGrantInfoResponseBodyResult(TeaModel):
    def __init__(
        self,
        legal_person: str = None,
        mobile_phone_number: str = None,
        org_name: str = None,
        state_code: str = None,
        unified_social_credit: str = None,
        user_name: str = None,
    ):
        self.legal_person = legal_person
        self.mobile_phone_number = mobile_phone_number
        self.org_name = org_name
        self.state_code = state_code
        self.unified_social_credit = unified_social_credit
        self.user_name = user_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.legal_person is not None:
            result['legalPerson'] = self.legal_person
        if self.mobile_phone_number is not None:
            result['mobilePhoneNumber'] = self.mobile_phone_number
        if self.org_name is not None:
            result['orgName'] = self.org_name
        if self.state_code is not None:
            result['stateCode'] = self.state_code
        if self.unified_social_credit is not None:
            result['unifiedSocialCredit'] = self.unified_social_credit
        if self.user_name is not None:
            result['userName'] = self.user_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('legalPerson') is not None:
            self.legal_person = m.get('legalPerson')
        if m.get('mobilePhoneNumber') is not None:
            self.mobile_phone_number = m.get('mobilePhoneNumber')
        if m.get('orgName') is not None:
            self.org_name = m.get('orgName')
        if m.get('stateCode') is not None:
            self.state_code = m.get('stateCode')
        if m.get('unifiedSocialCredit') is not None:
            self.unified_social_credit = m.get('unifiedSocialCredit')
        if m.get('userName') is not None:
            self.user_name = m.get('userName')
        return self


class EsignQueryGrantInfoResponseBody(TeaModel):
    def __init__(
        self,
        result: EsignQueryGrantInfoResponseBodyResult = None,
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
            temp_model = EsignQueryGrantInfoResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class EsignQueryGrantInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: EsignQueryGrantInfoResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = EsignQueryGrantInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class EsignQueryIdentityByTicketHeaders(TeaModel):
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


class EsignQueryIdentityByTicketRequest(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        extension: Dict[str, str] = None,
        ticket: str = None,
    ):
        self.corp_id = corp_id
        self.extension = extension
        self.ticket = ticket

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.extension is not None:
            result['extension'] = self.extension
        if self.ticket is not None:
            result['ticket'] = self.ticket
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('extension') is not None:
            self.extension = m.get('extension')
        if m.get('ticket') is not None:
            self.ticket = m.get('ticket')
        return self


class EsignQueryIdentityByTicketResponseBodyResult(TeaModel):
    def __init__(
        self,
        union_id: str = None,
    ):
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


class EsignQueryIdentityByTicketResponseBody(TeaModel):
    def __init__(
        self,
        result: EsignQueryIdentityByTicketResponseBodyResult = None,
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
            temp_model = EsignQueryIdentityByTicketResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class EsignQueryIdentityByTicketResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: EsignQueryIdentityByTicketResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = EsignQueryIdentityByTicketResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class EsignSyncEventHeaders(TeaModel):
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


class EsignSyncEventRequest(TeaModel):
    def __init__(
        self,
        action: str = None,
        corp_id: str = None,
        esign_data: str = None,
        extension: Dict[str, str] = None,
        union_id: str = None,
    ):
        self.action = action
        self.corp_id = corp_id
        self.esign_data = esign_data
        self.extension = extension
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action is not None:
            result['action'] = self.action
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.esign_data is not None:
            result['esignData'] = self.esign_data
        if self.extension is not None:
            result['extension'] = self.extension
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('action') is not None:
            self.action = m.get('action')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('esignData') is not None:
            self.esign_data = m.get('esignData')
        if m.get('extension') is not None:
            self.extension = m.get('extension')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class EsignSyncEventResponseBodyResult(TeaModel):
    def __init__(
        self,
        message: str = None,
    ):
        self.message = message

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.message is not None:
            result['message'] = self.message
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('message') is not None:
            self.message = m.get('message')
        return self


class EsignSyncEventResponseBody(TeaModel):
    def __init__(
        self,
        result: EsignSyncEventResponseBodyResult = None,
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
            temp_model = EsignSyncEventResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class EsignSyncEventResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: EsignSyncEventResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = EsignSyncEventResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryAdvancedContractVersionHeaders(TeaModel):
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


class QueryAdvancedContractVersionRequest(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        extension: Dict[str, str] = None,
    ):
        self.corp_id = corp_id
        self.extension = extension

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.extension is not None:
            result['extension'] = self.extension
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('extension') is not None:
            self.extension = m.get('extension')
        return self


class QueryAdvancedContractVersionResponseBodyResult(TeaModel):
    def __init__(
        self,
        enable_esign_attachment_sign: bool = None,
        extension: Dict[str, str] = None,
        version: str = None,
    ):
        self.enable_esign_attachment_sign = enable_esign_attachment_sign
        self.extension = extension
        self.version = version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.enable_esign_attachment_sign is not None:
            result['enableEsignAttachmentSign'] = self.enable_esign_attachment_sign
        if self.extension is not None:
            result['extension'] = self.extension
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('enableEsignAttachmentSign') is not None:
            self.enable_esign_attachment_sign = m.get('enableEsignAttachmentSign')
        if m.get('extension') is not None:
            self.extension = m.get('extension')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class QueryAdvancedContractVersionResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryAdvancedContractVersionResponseBodyResult = None,
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
            temp_model = QueryAdvancedContractVersionResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryAdvancedContractVersionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryAdvancedContractVersionResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = QueryAdvancedContractVersionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


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
        self.contract_code = contract_code
        self.contract_name = contract_name
        self.create_time = create_time
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
        self.corp_id = corp_id
        self.user_id = user_id
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
        self.corp_id = corp_id
        self.user_id = user_id
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
        self.card_type = card_type
        self.contract_info = contract_info
        self.corp_id = corp_id
        self.extension = extension
        self.process_instance_id = process_instance_id
        self.receive_groups = receive_groups
        self.receivers = receivers
        self.sender = sender
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
        status_code: int = None,
        body: SendContractCardResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = SendContractCardResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


