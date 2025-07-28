# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class AddCallConfigHeaders(TeaModel):
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


class AddCallConfigRequest(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        isv_token: str = None,
        phone_number: str = None,
        scope_type: str = None,
    ):
        # This parameter is required.
        self.corp_id = corp_id
        self.isv_token = isv_token
        self.phone_number = phone_number
        self.scope_type = scope_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.isv_token is not None:
            result['isvToken'] = self.isv_token
        if self.phone_number is not None:
            result['phoneNumber'] = self.phone_number
        if self.scope_type is not None:
            result['scopeType'] = self.scope_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('isvToken') is not None:
            self.isv_token = m.get('isvToken')
        if m.get('phoneNumber') is not None:
            self.phone_number = m.get('phoneNumber')
        if m.get('scopeType') is not None:
            self.scope_type = m.get('scopeType')
        return self


class AddCallConfigResponseBody(TeaModel):
    def __init__(
        self,
        token: str = None,
    ):
        self.token = token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.token is not None:
            result['token'] = self.token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('token') is not None:
            self.token = m.get('token')
        return self


class AddCallConfigResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AddCallConfigResponseBody = None,
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
            temp_model = AddCallConfigResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DelCallConfigHeaders(TeaModel):
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


class DelCallConfigRequest(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        isv_token: str = None,
        phone_number: str = None,
    ):
        self.corp_id = corp_id
        self.isv_token = isv_token
        self.phone_number = phone_number

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.isv_token is not None:
            result['isvToken'] = self.isv_token
        if self.phone_number is not None:
            result['phoneNumber'] = self.phone_number
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('isvToken') is not None:
            self.isv_token = m.get('isvToken')
        if m.get('phoneNumber') is not None:
            self.phone_number = m.get('phoneNumber')
        return self


class DelCallConfigResponseBody(TeaModel):
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


class DelCallConfigResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DelCallConfigResponseBody = None,
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
            temp_model = DelCallConfigResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryCallConfigHeaders(TeaModel):
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


class QueryCallConfigRequest(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        isv_token: str = None,
        phone_number: str = None,
        scope_type: str = None,
    ):
        self.corp_id = corp_id
        self.isv_token = isv_token
        self.phone_number = phone_number
        self.scope_type = scope_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.isv_token is not None:
            result['isvToken'] = self.isv_token
        if self.phone_number is not None:
            result['phoneNumber'] = self.phone_number
        if self.scope_type is not None:
            result['scopeType'] = self.scope_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('isvToken') is not None:
            self.isv_token = m.get('isvToken')
        if m.get('phoneNumber') is not None:
            self.phone_number = m.get('phoneNumber')
        if m.get('scopeType') is not None:
            self.scope_type = m.get('scopeType')
        return self


class QueryCallConfigResponseBodyResult(TeaModel):
    def __init__(
        self,
        account_domain: str = None,
        account_id: str = None,
        call_in_type: int = None,
        call_out_type: int = None,
        create_uid: str = None,
        phone_number: str = None,
        scope_type: str = None,
        show_type: int = None,
        source_type: str = None,
        status: int = None,
    ):
        self.account_domain = account_domain
        self.account_id = account_id
        self.call_in_type = call_in_type
        self.call_out_type = call_out_type
        self.create_uid = create_uid
        self.phone_number = phone_number
        self.scope_type = scope_type
        self.show_type = show_type
        self.source_type = source_type
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_domain is not None:
            result['accountDomain'] = self.account_domain
        if self.account_id is not None:
            result['accountId'] = self.account_id
        if self.call_in_type is not None:
            result['callInType'] = self.call_in_type
        if self.call_out_type is not None:
            result['callOutType'] = self.call_out_type
        if self.create_uid is not None:
            result['createUid'] = self.create_uid
        if self.phone_number is not None:
            result['phoneNumber'] = self.phone_number
        if self.scope_type is not None:
            result['scopeType'] = self.scope_type
        if self.show_type is not None:
            result['showType'] = self.show_type
        if self.source_type is not None:
            result['sourceType'] = self.source_type
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountDomain') is not None:
            self.account_domain = m.get('accountDomain')
        if m.get('accountId') is not None:
            self.account_id = m.get('accountId')
        if m.get('callInType') is not None:
            self.call_in_type = m.get('callInType')
        if m.get('callOutType') is not None:
            self.call_out_type = m.get('callOutType')
        if m.get('createUid') is not None:
            self.create_uid = m.get('createUid')
        if m.get('phoneNumber') is not None:
            self.phone_number = m.get('phoneNumber')
        if m.get('scopeType') is not None:
            self.scope_type = m.get('scopeType')
        if m.get('showType') is not None:
            self.show_type = m.get('showType')
        if m.get('sourceType') is not None:
            self.source_type = m.get('sourceType')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class QueryCallConfigResponseBody(TeaModel):
    def __init__(
        self,
        result: List[QueryCallConfigResponseBodyResult] = None,
    ):
        self.result = result

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = QueryCallConfigResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class QueryCallConfigResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryCallConfigResponseBody = None,
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
            temp_model = QueryCallConfigResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


