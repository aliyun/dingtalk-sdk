# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict


class GetEmployeeInfoByWorkNoHeaders(TeaModel):
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


class GetEmployeeInfoByWorkNoRequest(TeaModel):
    def __init__(
        self,
        work_no: str = None,
    ):
        # 工号
        self.work_no = work_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.work_no is not None:
            result['workNo'] = self.work_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('workNo') is not None:
            self.work_no = m.get('workNo')
        return self


class GetEmployeeInfoByWorkNoResponseBodyContent(TeaModel):
    def __init__(
        self,
        name: str = None,
        work_no: str = None,
    ):
        # 员工姓名
        self.name = name
        # 员工工号
        self.work_no = work_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.work_no is not None:
            result['workNo'] = self.work_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('workNo') is not None:
            self.work_no = m.get('workNo')
        return self


class GetEmployeeInfoByWorkNoResponseBody(TeaModel):
    def __init__(
        self,
        content: GetEmployeeInfoByWorkNoResponseBodyContent = None,
        success: bool = None,
    ):
        # 请求返回数据对象
        self.content = content
        # 接口请求成功标识,成功为true,失败为false
        self.success = success

    def validate(self):
        if self.content:
            self.content.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            temp_model = GetEmployeeInfoByWorkNoResponseBodyContent()
            self.content = temp_model.from_map(m['content'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetEmployeeInfoByWorkNoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetEmployeeInfoByWorkNoResponseBody = None,
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
            temp_model = GetEmployeeInfoByWorkNoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


