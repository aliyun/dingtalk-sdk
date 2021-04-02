# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict


class GetTbProjectSourceHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        ding_org_id: str = None,
        ding_isv_org_id: str = None,
        ding_corp_id: str = None,
        ding_suite_key: str = None,
        ding_access_token_type: str = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.ding_org_id = ding_org_id
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_corp_id = ding_corp_id
        self.ding_suite_key = ding_suite_key
        self.ding_access_token_type = ding_access_token_type
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
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_corp_id is not None:
            result['dingCorpId'] = self.ding_corp_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_access_token_type is not None:
            result['dingAccessTokenType'] = self.ding_access_token_type
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingCorpId') is not None:
            self.ding_corp_id = m.get('dingCorpId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingAccessTokenType') is not None:
            self.ding_access_token_type = m.get('dingAccessTokenType')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetTbProjectSourceResponseBody(TeaModel):
    def __init__(
        self,
        install_source: str = None,
    ):
        # 应用安装来源，"0"：来自应用中心，”6“：预安装
        self.install_source = install_source

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.install_source is not None:
            result['installSource'] = self.install_source
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('installSource') is not None:
            self.install_source = m.get('installSource')
        return self


class GetTbProjectSourceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetTbProjectSourceResponseBody = None,
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
            temp_model = GetTbProjectSourceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetTbProjectGrayHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        ding_access_token_type: str = None,
        ding_suite_key: str = None,
        ding_isv_org_id: str = None,
        ding_org_id: str = None,
        ding_corp_id: str = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.ding_access_token_type = ding_access_token_type
        self.ding_suite_key = ding_suite_key
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_org_id = ding_org_id
        self.ding_corp_id = ding_corp_id
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
        if self.ding_access_token_type is not None:
            result['dingAccessTokenType'] = self.ding_access_token_type
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_corp_id is not None:
            result['dingCorpId'] = self.ding_corp_id
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('dingAccessTokenType') is not None:
            self.ding_access_token_type = m.get('dingAccessTokenType')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingCorpId') is not None:
            self.ding_corp_id = m.get('dingCorpId')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetTbProjectGrayRequest(TeaModel):
    def __init__(
        self,
        label: str = None,
    ):
        self.label = label

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.label is not None:
            result['label'] = self.label
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('label') is not None:
            self.label = m.get('label')
        return self


class GetTbProjectGrayResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
        request_id: str = None,
    ):
        # 是否灰度
        self.result = result
        self.request_id = request_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class GetTbProjectGrayResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetTbProjectGrayResponseBody = None,
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
            temp_model = GetTbProjectGrayResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


