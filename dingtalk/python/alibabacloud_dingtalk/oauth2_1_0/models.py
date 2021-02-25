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
    ):
        # accessToken
        self.access_token = access_token
        # refreshToken
        self.refresh_token = refresh_token
        # 超时时间
        self.expire_in = expire_in

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.access_token is not None:
            result['accessToken'] = self.access_token
        if self.refresh_token is not None:
            result['refreshToken'] = self.refresh_token
        if self.expire_in is not None:
            result['expireIn'] = self.expire_in
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessToken') is not None:
            self.access_token = m.get('accessToken')
        if m.get('refreshToken') is not None:
            self.refresh_token = m.get('refreshToken')
        if m.get('expireIn') is not None:
            self.expire_in = m.get('expireIn')
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


