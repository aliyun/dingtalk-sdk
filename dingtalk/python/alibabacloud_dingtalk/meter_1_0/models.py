# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class GetResourceUseInfoHeaders(TeaModel):
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


class GetResourceUseInfoRequest(TeaModel):
    def __init__(
        self,
        benefit_code_list: List[str] = None,
        period: str = None,
    ):
        # This parameter is required.
        self.benefit_code_list = benefit_code_list
        # This parameter is required.
        self.period = period

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.benefit_code_list is not None:
            result['benefitCodeList'] = self.benefit_code_list
        if self.period is not None:
            result['period'] = self.period
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('benefitCodeList') is not None:
            self.benefit_code_list = m.get('benefitCodeList')
        if m.get('period') is not None:
            self.period = m.get('period')
        return self


class GetResourceUseInfoResponseBodyResult(TeaModel):
    def __init__(
        self,
        quota_num: int = None,
        used_num: int = None,
    ):
        self.quota_num = quota_num
        self.used_num = used_num

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.quota_num is not None:
            result['quotaNum'] = self.quota_num
        if self.used_num is not None:
            result['usedNum'] = self.used_num
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('quotaNum') is not None:
            self.quota_num = m.get('quotaNum')
        if m.get('usedNum') is not None:
            self.used_num = m.get('usedNum')
        return self


class GetResourceUseInfoResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetResourceUseInfoResponseBodyResult] = None,
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
                temp_model = GetResourceUseInfoResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class GetResourceUseInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetResourceUseInfoResponseBody = None,
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
            temp_model = GetResourceUseInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


