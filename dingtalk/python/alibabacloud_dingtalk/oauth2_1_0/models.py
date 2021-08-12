# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict


class GetUserTokenRequest(TeaModel):
    def __init__(
        self,
        client_id: str = None,
        client_secret: str = None,
        code: str = None,
        refresh_token: str = None,
        grant_type: str = None,
    ):
        # 应用id
        self.client_id = client_id
        # 应用密码
        self.client_secret = client_secret
        # OAuth 2.0 临时授权码
        self.code = code
        # OAuth 2.0 刷新令牌
        self.refresh_token = refresh_token
        # 分为authorization_code和refresh_token。使用授权码换token，传authorization_code；使用刷新token换用户token，传refresh_token
        self.grant_type = grant_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.client_id is not None:
            result['clientId'] = self.client_id
        if self.client_secret is not None:
            result['clientSecret'] = self.client_secret
        if self.code is not None:
            result['code'] = self.code
        if self.refresh_token is not None:
            result['refreshToken'] = self.refresh_token
        if self.grant_type is not None:
            result['grantType'] = self.grant_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('clientId') is not None:
            self.client_id = m.get('clientId')
        if m.get('clientSecret') is not None:
            self.client_secret = m.get('clientSecret')
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('refreshToken') is not None:
            self.refresh_token = m.get('refreshToken')
        if m.get('grantType') is not None:
            self.grant_type = m.get('grantType')
        return self


class GetUserTokenResponseBody(TeaModel):
    def __init__(
        self,
        access_token: str = None,
        refresh_token: str = None,
        expire_in: int = None,
        corp_id: str = None,
    ):
        # accessToken
        self.access_token = access_token
        # refreshToken
        self.refresh_token = refresh_token
        # 超时时间
        self.expire_in = expire_in
        # 所选企业corpId
        self.corp_id = corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_token is not None:
            result['accessToken'] = self.access_token
        if self.refresh_token is not None:
            result['refreshToken'] = self.refresh_token
        if self.expire_in is not None:
            result['expireIn'] = self.expire_in
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessToken') is not None:
            self.access_token = m.get('accessToken')
        if m.get('refreshToken') is not None:
            self.refresh_token = m.get('refreshToken')
        if m.get('expireIn') is not None:
            self.expire_in = m.get('expireIn')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        return self


class GetUserTokenResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetUserTokenResponseBody = None,
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
            temp_model = GetUserTokenResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetAccessTokenRequest(TeaModel):
    def __init__(
        self,
        app_key: str = None,
        app_secret: str = None,
    ):
        # 应用id
        self.app_key = app_key
        # 应用密码
        self.app_secret = app_secret

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_key is not None:
            result['appKey'] = self.app_key
        if self.app_secret is not None:
            result['appSecret'] = self.app_secret
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appKey') is not None:
            self.app_key = m.get('appKey')
        if m.get('appSecret') is not None:
            self.app_secret = m.get('appSecret')
        return self


class GetAccessTokenResponseBody(TeaModel):
    def __init__(
        self,
        access_token: str = None,
        expire_in: int = None,
    ):
        # accessToken
        self.access_token = access_token
        # 超时时间
        self.expire_in = expire_in

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_token is not None:
            result['accessToken'] = self.access_token
        if self.expire_in is not None:
            result['expireIn'] = self.expire_in
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessToken') is not None:
            self.access_token = m.get('accessToken')
        if m.get('expireIn') is not None:
            self.expire_in = m.get('expireIn')
        return self


class GetAccessTokenResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetAccessTokenResponseBody = None,
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
            temp_model = GetAccessTokenResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetSuiteAccessTokenRequest(TeaModel):
    def __init__(
        self,
        suite_key: str = None,
        suite_secret: str = None,
        suite_ticket: str = None,
    ):
        # 应用id
        self.suite_key = suite_key
        # 应用密码
        self.suite_secret = suite_secret
        # suiteTicket
        self.suite_ticket = suite_ticket

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.suite_key is not None:
            result['suiteKey'] = self.suite_key
        if self.suite_secret is not None:
            result['suiteSecret'] = self.suite_secret
        if self.suite_ticket is not None:
            result['suiteTicket'] = self.suite_ticket
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('suiteKey') is not None:
            self.suite_key = m.get('suiteKey')
        if m.get('suiteSecret') is not None:
            self.suite_secret = m.get('suiteSecret')
        if m.get('suiteTicket') is not None:
            self.suite_ticket = m.get('suiteTicket')
        return self


class GetSuiteAccessTokenResponseBody(TeaModel):
    def __init__(
        self,
        access_token: str = None,
        expire_in: int = None,
    ):
        # accessToken
        self.access_token = access_token
        # 超时时间
        self.expire_in = expire_in

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_token is not None:
            result['accessToken'] = self.access_token
        if self.expire_in is not None:
            result['expireIn'] = self.expire_in
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessToken') is not None:
            self.access_token = m.get('accessToken')
        if m.get('expireIn') is not None:
            self.expire_in = m.get('expireIn')
        return self


class GetSuiteAccessTokenResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetSuiteAccessTokenResponseBody = None,
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
            temp_model = GetSuiteAccessTokenResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetCorpAccessTokenRequest(TeaModel):
    def __init__(
        self,
        suite_key: str = None,
        suite_secret: str = None,
        auth_corp_id: str = None,
        suite_ticket: str = None,
    ):
        # 应用id
        self.suite_key = suite_key
        # 应用密码
        self.suite_secret = suite_secret
        # OAuth 2.0 临时授权码
        self.auth_corp_id = auth_corp_id
        # suiteTicket
        self.suite_ticket = suite_ticket

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.suite_key is not None:
            result['suiteKey'] = self.suite_key
        if self.suite_secret is not None:
            result['suiteSecret'] = self.suite_secret
        if self.auth_corp_id is not None:
            result['authCorpId'] = self.auth_corp_id
        if self.suite_ticket is not None:
            result['suiteTicket'] = self.suite_ticket
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('suiteKey') is not None:
            self.suite_key = m.get('suiteKey')
        if m.get('suiteSecret') is not None:
            self.suite_secret = m.get('suiteSecret')
        if m.get('authCorpId') is not None:
            self.auth_corp_id = m.get('authCorpId')
        if m.get('suiteTicket') is not None:
            self.suite_ticket = m.get('suiteTicket')
        return self


class GetCorpAccessTokenResponseBody(TeaModel):
    def __init__(
        self,
        access_token: str = None,
        expire_in: int = None,
    ):
        # accessToken
        self.access_token = access_token
        # 超时时间
        self.expire_in = expire_in

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_token is not None:
            result['accessToken'] = self.access_token
        if self.expire_in is not None:
            result['expireIn'] = self.expire_in
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessToken') is not None:
            self.access_token = m.get('accessToken')
        if m.get('expireIn') is not None:
            self.expire_in = m.get('expireIn')
        return self


class GetCorpAccessTokenResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetCorpAccessTokenResponseBody = None,
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
            temp_model = GetCorpAccessTokenResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


