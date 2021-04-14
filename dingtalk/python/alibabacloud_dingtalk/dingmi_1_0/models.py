# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List, Any


class GetDingMeBaseDataHeaders(TeaModel):
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


class GetDingMeBaseDataRequest(TeaModel):
    def __init__(
        self,
        app_key: str = None,
        start_day: str = None,
        end_day: str = None,
        by_day: bool = None,
    ):
        # 机器人ID
        self.app_key = app_key
        # 开始时间
        self.start_day = start_day
        # 结束时间
        self.end_day = end_day
        # 是否按天分组
        self.by_day = by_day

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_key is not None:
            result['appKey'] = self.app_key
        if self.start_day is not None:
            result['startDay'] = self.start_day
        if self.end_day is not None:
            result['endDay'] = self.end_day
        if self.by_day is not None:
            result['byDay'] = self.by_day
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appKey') is not None:
            self.app_key = m.get('appKey')
        if m.get('startDay') is not None:
            self.start_day = m.get('startDay')
        if m.get('endDay') is not None:
            self.end_day = m.get('endDay')
        if m.get('byDay') is not None:
            self.by_day = m.get('byDay')
        return self


class GetDingMeBaseDataResponseBody(TeaModel):
    def __init__(
        self,
        from_cache: bool = None,
        runtime: int = None,
        rawset: List[Dict[str, str]] = None,
        tips: Dict[str, Any] = None,
    ):
        # 是否缓存
        self.from_cache = from_cache
        # 运行时间
        self.runtime = runtime
        # 结果集
        self.rawset = rawset
        # 字段解释
        self.tips = tips

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.from_cache is not None:
            result['fromCache'] = self.from_cache
        if self.runtime is not None:
            result['runtime'] = self.runtime
        if self.rawset is not None:
            result['rawset'] = self.rawset
        if self.tips is not None:
            result['tips'] = self.tips
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fromCache') is not None:
            self.from_cache = m.get('fromCache')
        if m.get('runtime') is not None:
            self.runtime = m.get('runtime')
        if m.get('rawset') is not None:
            self.rawset = m.get('rawset')
        if m.get('tips') is not None:
            self.tips = m.get('tips')
        return self


class GetDingMeBaseDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetDingMeBaseDataResponseBody = None,
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
            temp_model = GetDingMeBaseDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


