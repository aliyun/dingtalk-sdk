# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class CorpInfoHeaders(TeaModel):
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


class CorpInfoResponseBodyData(TeaModel):
    def __init__(
        self,
        real_name: bool = None,
        org_real_name: str = None,
    ):
        self.real_name = real_name
        self.org_real_name = org_real_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.real_name is not None:
            result['realName'] = self.real_name
        if self.org_real_name is not None:
            result['orgRealName'] = self.org_real_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('realName') is not None:
            self.real_name = m.get('realName')
        if m.get('orgRealName') is not None:
            self.org_real_name = m.get('orgRealName')
        return self


class CorpInfoResponseBody(TeaModel):
    def __init__(
        self,
        data: CorpInfoResponseBodyData = None,
        code: int = None,
        message: str = None,
    ):
        self.data = data
        self.code = code
        self.message = message

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.code is not None:
            result['code'] = self.code
        if self.message is not None:
            result['message'] = self.message
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            temp_model = CorpInfoResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('message') is not None:
            self.message = m.get('message')
        return self


class CorpInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CorpInfoResponseBody = None,
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
            temp_model = CorpInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateDeveloperHeaders(TeaModel):
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


class CreateDeveloperRequest(TeaModel):
    def __init__(
        self,
        ding_corp_id: str = None,
        redirect_url: str = None,
        ding_isv_access_token: str = None,
        ding_suite_key: str = None,
    ):
        self.ding_corp_id = ding_corp_id
        self.redirect_url = redirect_url
        self.ding_isv_access_token = ding_isv_access_token
        self.ding_suite_key = ding_suite_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_corp_id is not None:
            result['dingCorpId'] = self.ding_corp_id
        if self.redirect_url is not None:
            result['redirectUrl'] = self.redirect_url
        if self.ding_isv_access_token is not None:
            result['dingIsvAccessToken'] = self.ding_isv_access_token
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingCorpId') is not None:
            self.ding_corp_id = m.get('dingCorpId')
        if m.get('redirectUrl') is not None:
            self.redirect_url = m.get('redirectUrl')
        if m.get('dingIsvAccessToken') is not None:
            self.ding_isv_access_token = m.get('dingIsvAccessToken')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        return self


class CreateDeveloperResponseBody(TeaModel):
    def __init__(
        self,
        code: int = None,
        message: str = None,
        data: bool = None,
    ):
        self.code = code
        self.message = message
        self.data = data

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.message is not None:
            result['message'] = self.message
        if self.data is not None:
            result['data'] = self.data
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('message') is not None:
            self.message = m.get('message')
        if m.get('data') is not None:
            self.data = m.get('data')
        return self


class CreateDeveloperResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateDeveloperResponseBody = None,
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
            temp_model = CreateDeveloperResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetUserRealnameUrlHeaders(TeaModel):
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


class GetUserRealnameUrlRequest(TeaModel):
    def __init__(
        self,
        ding_corp_id: str = None,
        user_id: str = None,
        redirect_url: str = None,
        ding_isv_access_token: str = None,
        ding_suite_key: str = None,
    ):
        self.ding_corp_id = ding_corp_id
        self.user_id = user_id
        self.redirect_url = redirect_url
        self.ding_isv_access_token = ding_isv_access_token
        self.ding_suite_key = ding_suite_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_corp_id is not None:
            result['dingCorpId'] = self.ding_corp_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.redirect_url is not None:
            result['redirectUrl'] = self.redirect_url
        if self.ding_isv_access_token is not None:
            result['dingIsvAccessToken'] = self.ding_isv_access_token
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingCorpId') is not None:
            self.ding_corp_id = m.get('dingCorpId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('redirectUrl') is not None:
            self.redirect_url = m.get('redirectUrl')
        if m.get('dingIsvAccessToken') is not None:
            self.ding_isv_access_token = m.get('dingIsvAccessToken')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        return self


class GetUserRealnameUrlResponseBodyData(TeaModel):
    def __init__(
        self,
        task_id: str = None,
        pc_url: str = None,
        mobile_url: str = None,
    ):
        self.task_id = task_id
        self.pc_url = pc_url
        self.mobile_url = mobile_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.pc_url is not None:
            result['pcUrl'] = self.pc_url
        if self.mobile_url is not None:
            result['mobileUrl'] = self.mobile_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('pcUrl') is not None:
            self.pc_url = m.get('pcUrl')
        if m.get('mobileUrl') is not None:
            self.mobile_url = m.get('mobileUrl')
        return self


class GetUserRealnameUrlResponseBody(TeaModel):
    def __init__(
        self,
        code: int = None,
        message: str = None,
        data: GetUserRealnameUrlResponseBodyData = None,
    ):
        self.code = code
        self.message = message
        self.data = data

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.message is not None:
            result['message'] = self.message
        if self.data is not None:
            result['data'] = self.data.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('message') is not None:
            self.message = m.get('message')
        if m.get('data') is not None:
            temp_model = GetUserRealnameUrlResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        return self


class GetUserRealnameUrlResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetUserRealnameUrlResponseBody = None,
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
            temp_model = GetUserRealnameUrlResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetCorpRealnameUrlHeaders(TeaModel):
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


class GetCorpRealnameUrlRequest(TeaModel):
    def __init__(
        self,
        ding_corp_id: str = None,
        user_id: str = None,
        ding_isv_access_token: str = None,
        ding_suite_key: str = None,
    ):
        self.ding_corp_id = ding_corp_id
        self.user_id = user_id
        self.ding_isv_access_token = ding_isv_access_token
        self.ding_suite_key = ding_suite_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_corp_id is not None:
            result['dingCorpId'] = self.ding_corp_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.ding_isv_access_token is not None:
            result['dingIsvAccessToken'] = self.ding_isv_access_token
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingCorpId') is not None:
            self.ding_corp_id = m.get('dingCorpId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('dingIsvAccessToken') is not None:
            self.ding_isv_access_token = m.get('dingIsvAccessToken')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        return self


class GetCorpRealnameUrlResponseBodyData(TeaModel):
    def __init__(
        self,
        task_id: str = None,
        pc_url: str = None,
        mobile_url: str = None,
    ):
        self.task_id = task_id
        self.pc_url = pc_url
        self.mobile_url = mobile_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.pc_url is not None:
            result['pcUrl'] = self.pc_url
        if self.mobile_url is not None:
            result['mobileUrl'] = self.mobile_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('pcUrl') is not None:
            self.pc_url = m.get('pcUrl')
        if m.get('mobileUrl') is not None:
            self.mobile_url = m.get('mobileUrl')
        return self


class GetCorpRealnameUrlResponseBody(TeaModel):
    def __init__(
        self,
        code: int = None,
        message: str = None,
        data: GetCorpRealnameUrlResponseBodyData = None,
    ):
        self.code = code
        self.message = message
        self.data = data

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.message is not None:
            result['message'] = self.message
        if self.data is not None:
            result['data'] = self.data.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('message') is not None:
            self.message = m.get('message')
        if m.get('data') is not None:
            temp_model = GetCorpRealnameUrlResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        return self


class GetCorpRealnameUrlResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetCorpRealnameUrlResponseBody = None,
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
            temp_model = GetCorpRealnameUrlResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetFileHeaders(TeaModel):
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


class GetFileResponseBodyData(TeaModel):
    def __init__(
        self,
        file_id: str = None,
        name: str = None,
        download_url: str = None,
        size: int = None,
        status: int = None,
        pdf_total_pages: int = None,
    ):
        self.file_id = file_id
        self.name = name
        self.download_url = download_url
        self.size = size
        self.status = status
        self.pdf_total_pages = pdf_total_pages

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_id is not None:
            result['fileId'] = self.file_id
        if self.name is not None:
            result['name'] = self.name
        if self.download_url is not None:
            result['downloadUrl'] = self.download_url
        if self.size is not None:
            result['size'] = self.size
        if self.status is not None:
            result['status'] = self.status
        if self.pdf_total_pages is not None:
            result['pdfTotalPages'] = self.pdf_total_pages
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileId') is not None:
            self.file_id = m.get('fileId')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('downloadUrl') is not None:
            self.download_url = m.get('downloadUrl')
        if m.get('size') is not None:
            self.size = m.get('size')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('pdfTotalPages') is not None:
            self.pdf_total_pages = m.get('pdfTotalPages')
        return self


class GetFileResponseBody(TeaModel):
    def __init__(
        self,
        data: GetFileResponseBodyData = None,
        code: int = None,
        message: str = None,
    ):
        self.data = data
        self.code = code
        self.message = message

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.code is not None:
            result['code'] = self.code
        if self.message is not None:
            result['message'] = self.message
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            temp_model = GetFileResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('message') is not None:
            self.message = m.get('message')
        return self


class GetFileResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetFileResponseBody = None,
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
            temp_model = GetFileResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AuthUrlHeaders(TeaModel):
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


class AuthUrlRequest(TeaModel):
    def __init__(
        self,
        redirect_url: str = None,
        ding_corp_id: str = None,
        ding_isv_access_token: str = None,
        ding_suite_key: str = None,
    ):
        self.redirect_url = redirect_url
        self.ding_corp_id = ding_corp_id
        self.ding_isv_access_token = ding_isv_access_token
        self.ding_suite_key = ding_suite_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.redirect_url is not None:
            result['redirectUrl'] = self.redirect_url
        if self.ding_corp_id is not None:
            result['dingCorpId'] = self.ding_corp_id
        if self.ding_isv_access_token is not None:
            result['dingIsvAccessToken'] = self.ding_isv_access_token
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('redirectUrl') is not None:
            self.redirect_url = m.get('redirectUrl')
        if m.get('dingCorpId') is not None:
            self.ding_corp_id = m.get('dingCorpId')
        if m.get('dingIsvAccessToken') is not None:
            self.ding_isv_access_token = m.get('dingIsvAccessToken')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        return self


class AuthUrlResponseBodyData(TeaModel):
    def __init__(
        self,
        task_id: str = None,
        mobile_url: str = None,
        pc_url: str = None,
    ):
        self.task_id = task_id
        self.mobile_url = mobile_url
        self.pc_url = pc_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.mobile_url is not None:
            result['mobileUrl'] = self.mobile_url
        if self.pc_url is not None:
            result['pcUrl'] = self.pc_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('mobileUrl') is not None:
            self.mobile_url = m.get('mobileUrl')
        if m.get('pcUrl') is not None:
            self.pc_url = m.get('pcUrl')
        return self


class AuthUrlResponseBody(TeaModel):
    def __init__(
        self,
        data: AuthUrlResponseBodyData = None,
        code: int = None,
        message: str = None,
    ):
        self.data = data
        self.code = code
        self.message = message

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.code is not None:
            result['code'] = self.code
        if self.message is not None:
            result['message'] = self.message
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            temp_model = AuthUrlResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('message') is not None:
            self.message = m.get('message')
        return self


class AuthUrlResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: AuthUrlResponseBody = None,
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
            temp_model = AuthUrlResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CancelCorpAuthHeaders(TeaModel):
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


class CancelCorpAuthResponseBodyData(TeaModel):
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


class CancelCorpAuthResponseBody(TeaModel):
    def __init__(
        self,
        data: CancelCorpAuthResponseBodyData = None,
        code: int = None,
        message: str = None,
    ):
        self.data = data
        self.code = code
        self.message = message

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.code is not None:
            result['code'] = self.code
        if self.message is not None:
            result['message'] = self.message
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            temp_model = CancelCorpAuthResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('message') is not None:
            self.message = m.get('message')
        return self


class CancelCorpAuthResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CancelCorpAuthResponseBody = None,
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
            temp_model = CancelCorpAuthResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetSignNoticeUrlHeaders(TeaModel):
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


class GetSignNoticeUrlRequest(TeaModel):
    def __init__(
        self,
        ding_corp_id: str = None,
        task_id: str = None,
        ding_suite_key: str = None,
        ding_isv_access_token: str = None,
    ):
        self.ding_corp_id = ding_corp_id
        self.task_id = task_id
        self.ding_suite_key = ding_suite_key
        self.ding_isv_access_token = ding_isv_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_corp_id is not None:
            result['dingCorpId'] = self.ding_corp_id
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_isv_access_token is not None:
            result['dingIsvAccessToken'] = self.ding_isv_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingCorpId') is not None:
            self.ding_corp_id = m.get('dingCorpId')
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingIsvAccessToken') is not None:
            self.ding_isv_access_token = m.get('dingIsvAccessToken')
        return self


class GetSignNoticeUrlResponseBodyData(TeaModel):
    def __init__(
        self,
        pc_url: str = None,
        mobile_url: str = None,
    ):
        # PC端URL
        self.pc_url = pc_url
        # 移动端URL
        self.mobile_url = mobile_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.pc_url is not None:
            result['pcUrl'] = self.pc_url
        if self.mobile_url is not None:
            result['mobileUrl'] = self.mobile_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pcUrl') is not None:
            self.pc_url = m.get('pcUrl')
        if m.get('mobileUrl') is not None:
            self.mobile_url = m.get('mobileUrl')
        return self


class GetSignNoticeUrlResponseBody(TeaModel):
    def __init__(
        self,
        data: GetSignNoticeUrlResponseBodyData = None,
        code: int = None,
        message: str = None,
    ):
        # 返回数据
        self.data = data
        # 返回错误码
        self.code = code
        # 返回结果信息
        self.message = message

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.code is not None:
            result['code'] = self.code
        if self.message is not None:
            result['message'] = self.message
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            temp_model = GetSignNoticeUrlResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('message') is not None:
            self.message = m.get('message')
        return self


class GetSignNoticeUrlResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetSignNoticeUrlResponseBody = None,
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
            temp_model = GetSignNoticeUrlResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetUploadUrlHeaders(TeaModel):
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


class GetUploadUrlRequest(TeaModel):
    def __init__(
        self,
        ding_corp_id: str = None,
        ding_isv_access_token: str = None,
        ding_suite_key: str = None,
        content_type: str = None,
        content_md_5: str = None,
        convert_2pdf: bool = None,
        file_name: str = None,
        file_size: int = None,
    ):
        self.ding_corp_id = ding_corp_id
        self.ding_isv_access_token = ding_isv_access_token
        self.ding_suite_key = ding_suite_key
        self.content_type = content_type
        self.content_md_5 = content_md_5
        self.convert_2pdf = convert_2pdf
        self.file_name = file_name
        self.file_size = file_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_corp_id is not None:
            result['dingCorpId'] = self.ding_corp_id
        if self.ding_isv_access_token is not None:
            result['dingIsvAccessToken'] = self.ding_isv_access_token
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.content_type is not None:
            result['contentType'] = self.content_type
        if self.content_md_5 is not None:
            result['contentMd5'] = self.content_md_5
        if self.convert_2pdf is not None:
            result['convert2Pdf'] = self.convert_2pdf
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.file_size is not None:
            result['fileSize'] = self.file_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingCorpId') is not None:
            self.ding_corp_id = m.get('dingCorpId')
        if m.get('dingIsvAccessToken') is not None:
            self.ding_isv_access_token = m.get('dingIsvAccessToken')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('contentType') is not None:
            self.content_type = m.get('contentType')
        if m.get('contentMd5') is not None:
            self.content_md_5 = m.get('contentMd5')
        if m.get('convert2Pdf') is not None:
            self.convert_2pdf = m.get('convert2Pdf')
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('fileSize') is not None:
            self.file_size = m.get('fileSize')
        return self


class GetUploadUrlResponseBodyData(TeaModel):
    def __init__(
        self,
        file_id: str = None,
        upload_url: str = None,
    ):
        self.file_id = file_id
        self.upload_url = upload_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_id is not None:
            result['fileId'] = self.file_id
        if self.upload_url is not None:
            result['uploadUrl'] = self.upload_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileId') is not None:
            self.file_id = m.get('fileId')
        if m.get('uploadUrl') is not None:
            self.upload_url = m.get('uploadUrl')
        return self


class GetUploadUrlResponseBody(TeaModel):
    def __init__(
        self,
        code: int = None,
        message: str = None,
        data: GetUploadUrlResponseBodyData = None,
    ):
        self.code = code
        self.message = message
        self.data = data

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.message is not None:
            result['message'] = self.message
        if self.data is not None:
            result['data'] = self.data.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('message') is not None:
            self.message = m.get('message')
        if m.get('data') is not None:
            temp_model = GetUploadUrlResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        return self


class GetUploadUrlResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetUploadUrlResponseBody = None,
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
            temp_model = GetUploadUrlResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListSealApprovalHeaders(TeaModel):
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


class ListSealApprovalRequest(TeaModel):
    def __init__(
        self,
        task_id: str = None,
    ):
        self.task_id = task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class ListSealApprovalResponseBodyDataApprovalNodes(TeaModel):
    def __init__(
        self,
        approver_name: str = None,
        status: str = None,
        start_time: int = None,
        approval_time: int = None,
    ):
        self.approver_name = approver_name
        self.status = status
        self.start_time = start_time
        self.approval_time = approval_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.approver_name is not None:
            result['approverName'] = self.approver_name
        if self.status is not None:
            result['status'] = self.status
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.approval_time is not None:
            result['approvalTime'] = self.approval_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('approverName') is not None:
            self.approver_name = m.get('approverName')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('approvalTime') is not None:
            self.approval_time = m.get('approvalTime')
        return self


class ListSealApprovalResponseBodyData(TeaModel):
    def __init__(
        self,
        approval_name: str = None,
        status: str = None,
        refuse_reason: str = None,
        sponsor_account_name: str = None,
        start_time: int = None,
        end_time: int = None,
        seal_id_img: str = None,
        approval_nodes: List[ListSealApprovalResponseBodyDataApprovalNodes] = None,
    ):
        self.approval_name = approval_name
        self.status = status
        self.refuse_reason = refuse_reason
        self.sponsor_account_name = sponsor_account_name
        self.start_time = start_time
        self.end_time = end_time
        self.seal_id_img = seal_id_img
        self.approval_nodes = approval_nodes

    def validate(self):
        if self.approval_nodes:
            for k in self.approval_nodes:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.approval_name is not None:
            result['approvalName'] = self.approval_name
        if self.status is not None:
            result['status'] = self.status
        if self.refuse_reason is not None:
            result['refuseReason'] = self.refuse_reason
        if self.sponsor_account_name is not None:
            result['sponsorAccountName'] = self.sponsor_account_name
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.seal_id_img is not None:
            result['sealIdImg'] = self.seal_id_img
        result['approvalNodes'] = []
        if self.approval_nodes is not None:
            for k in self.approval_nodes:
                result['approvalNodes'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('approvalName') is not None:
            self.approval_name = m.get('approvalName')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('refuseReason') is not None:
            self.refuse_reason = m.get('refuseReason')
        if m.get('sponsorAccountName') is not None:
            self.sponsor_account_name = m.get('sponsorAccountName')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('sealIdImg') is not None:
            self.seal_id_img = m.get('sealIdImg')
        self.approval_nodes = []
        if m.get('approvalNodes') is not None:
            for k in m.get('approvalNodes'):
                temp_model = ListSealApprovalResponseBodyDataApprovalNodes()
                self.approval_nodes.append(temp_model.from_map(k))
        return self


class ListSealApprovalResponseBody(TeaModel):
    def __init__(
        self,
        data: List[ListSealApprovalResponseBodyData] = None,
        code: int = None,
        message: str = None,
    ):
        self.data = data
        self.code = code
        self.message = message

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
        if self.code is not None:
            result['code'] = self.code
        if self.message is not None:
            result['message'] = self.message
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = ListSealApprovalResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('message') is not None:
            self.message = m.get('message')
        return self


class ListSealApprovalResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListSealApprovalResponseBody = None,
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
            temp_model = ListSealApprovalResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ContractMarginHeaders(TeaModel):
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


class ContractMarginResponseBodyData(TeaModel):
    def __init__(
        self,
        margin: int = None,
    ):
        self.margin = margin

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.margin is not None:
            result['margin'] = self.margin
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('margin') is not None:
            self.margin = m.get('margin')
        return self


class ContractMarginResponseBody(TeaModel):
    def __init__(
        self,
        data: ContractMarginResponseBodyData = None,
        code: int = None,
        message: str = None,
    ):
        self.data = data
        self.code = code
        self.message = message

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.code is not None:
            result['code'] = self.code
        if self.message is not None:
            result['message'] = self.message
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            temp_model = ContractMarginResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('message') is not None:
            self.message = m.get('message')
        return self


class ContractMarginResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ContractMarginResponseBody = None,
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
            temp_model = ContractMarginResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetFlowDetailHeaders(TeaModel):
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


class GetFlowDetailRequest(TeaModel):
    def __init__(
        self,
        task_id: str = None,
    ):
        self.task_id = task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class GetFlowDetailResponseBodyDataLogs(TeaModel):
    def __init__(
        self,
        operator_account_name: str = None,
        log_type: str = None,
        operate_description: str = None,
        operate_time: int = None,
    ):
        self.operator_account_name = operator_account_name
        self.log_type = log_type
        self.operate_description = operate_description
        self.operate_time = operate_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operator_account_name is not None:
            result['operatorAccountName'] = self.operator_account_name
        if self.log_type is not None:
            result['logType'] = self.log_type
        if self.operate_description is not None:
            result['operateDescription'] = self.operate_description
        if self.operate_time is not None:
            result['operateTime'] = self.operate_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operatorAccountName') is not None:
            self.operator_account_name = m.get('operatorAccountName')
        if m.get('logType') is not None:
            self.log_type = m.get('logType')
        if m.get('operateDescription') is not None:
            self.operate_description = m.get('operateDescription')
        if m.get('operateTime') is not None:
            self.operate_time = m.get('operateTime')
        return self


class GetFlowDetailResponseBodyData(TeaModel):
    def __init__(
        self,
        business_sense: str = None,
        flow_status: int = None,
        initiator_authorized_name: str = None,
        initiator_name: str = None,
        logs: List[GetFlowDetailResponseBodyDataLogs] = None,
    ):
        self.business_sense = business_sense
        self.flow_status = flow_status
        self.initiator_authorized_name = initiator_authorized_name
        self.initiator_name = initiator_name
        self.logs = logs

    def validate(self):
        if self.logs:
            for k in self.logs:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.business_sense is not None:
            result['businessSense'] = self.business_sense
        if self.flow_status is not None:
            result['flowStatus'] = self.flow_status
        if self.initiator_authorized_name is not None:
            result['initiatorAuthorizedName'] = self.initiator_authorized_name
        if self.initiator_name is not None:
            result['initiatorName'] = self.initiator_name
        result['logs'] = []
        if self.logs is not None:
            for k in self.logs:
                result['logs'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('businessSense') is not None:
            self.business_sense = m.get('businessSense')
        if m.get('flowStatus') is not None:
            self.flow_status = m.get('flowStatus')
        if m.get('initiatorAuthorizedName') is not None:
            self.initiator_authorized_name = m.get('initiatorAuthorizedName')
        if m.get('initiatorName') is not None:
            self.initiator_name = m.get('initiatorName')
        self.logs = []
        if m.get('logs') is not None:
            for k in m.get('logs'):
                temp_model = GetFlowDetailResponseBodyDataLogs()
                self.logs.append(temp_model.from_map(k))
        return self


class GetFlowDetailResponseBody(TeaModel):
    def __init__(
        self,
        data: GetFlowDetailResponseBodyData = None,
        code: int = None,
        message: str = None,
    ):
        self.data = data
        self.code = code
        self.message = message

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.code is not None:
            result['code'] = self.code
        if self.message is not None:
            result['message'] = self.message
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            temp_model = GetFlowDetailResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('message') is not None:
            self.message = m.get('message')
        return self


class GetFlowDetailResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetFlowDetailResponseBody = None,
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
            temp_model = GetFlowDetailResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetProcessStartUrlHeaders(TeaModel):
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


class GetProcessStartUrlRequestFiles(TeaModel):
    def __init__(
        self,
        file_id: str = None,
        file_name: str = None,
    ):
        self.file_id = file_id
        self.file_name = file_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_id is not None:
            result['fileId'] = self.file_id
        if self.file_name is not None:
            result['fileName'] = self.file_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileId') is not None:
            self.file_id = m.get('fileId')
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        return self


class GetProcessStartUrlRequestParticipants(TeaModel):
    def __init__(
        self,
        account_type: str = None,
        ding_corp_id: str = None,
        sign_requirements: str = None,
        user_id: str = None,
        account: str = None,
        account_name: str = None,
        org_name: str = None,
    ):
        self.account_type = account_type
        self.ding_corp_id = ding_corp_id
        self.sign_requirements = sign_requirements
        self.user_id = user_id
        self.account = account
        self.account_name = account_name
        self.org_name = org_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_type is not None:
            result['accountType'] = self.account_type
        if self.ding_corp_id is not None:
            result['dingCorpId'] = self.ding_corp_id
        if self.sign_requirements is not None:
            result['signRequirements'] = self.sign_requirements
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.account is not None:
            result['account'] = self.account
        if self.account_name is not None:
            result['accountName'] = self.account_name
        if self.org_name is not None:
            result['orgName'] = self.org_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountType') is not None:
            self.account_type = m.get('accountType')
        if m.get('dingCorpId') is not None:
            self.ding_corp_id = m.get('dingCorpId')
        if m.get('signRequirements') is not None:
            self.sign_requirements = m.get('signRequirements')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('account') is not None:
            self.account = m.get('account')
        if m.get('accountName') is not None:
            self.account_name = m.get('accountName')
        if m.get('orgName') is not None:
            self.org_name = m.get('orgName')
        return self


class GetProcessStartUrlRequestSourceInfo(TeaModel):
    def __init__(
        self,
        mobile_url: str = None,
        pc_url: str = None,
        show_text: str = None,
    ):
        self.mobile_url = mobile_url
        self.pc_url = pc_url
        self.show_text = show_text

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.mobile_url is not None:
            result['mobileUrl'] = self.mobile_url
        if self.pc_url is not None:
            result['pcUrl'] = self.pc_url
        if self.show_text is not None:
            result['showText'] = self.show_text
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('mobileUrl') is not None:
            self.mobile_url = m.get('mobileUrl')
        if m.get('pcUrl') is not None:
            self.pc_url = m.get('pcUrl')
        if m.get('showText') is not None:
            self.show_text = m.get('showText')
        return self


class GetProcessStartUrlRequestCcs(TeaModel):
    def __init__(
        self,
        account_type: str = None,
        ding_corp_id: str = None,
        user_id: str = None,
        account: str = None,
        account_name: str = None,
        org_name: str = None,
    ):
        self.account_type = account_type
        self.ding_corp_id = ding_corp_id
        self.user_id = user_id
        self.account = account
        self.account_name = account_name
        self.org_name = org_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.account_type is not None:
            result['accountType'] = self.account_type
        if self.ding_corp_id is not None:
            result['dingCorpId'] = self.ding_corp_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.account is not None:
            result['account'] = self.account
        if self.account_name is not None:
            result['accountName'] = self.account_name
        if self.org_name is not None:
            result['orgName'] = self.org_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accountType') is not None:
            self.account_type = m.get('accountType')
        if m.get('dingCorpId') is not None:
            self.ding_corp_id = m.get('dingCorpId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('account') is not None:
            self.account = m.get('account')
        if m.get('accountName') is not None:
            self.account_name = m.get('accountName')
        if m.get('orgName') is not None:
            self.org_name = m.get('orgName')
        return self


class GetProcessStartUrlRequest(TeaModel):
    def __init__(
        self,
        files: List[GetProcessStartUrlRequestFiles] = None,
        ding_corp_id: str = None,
        initiator_user_id: str = None,
        participants: List[GetProcessStartUrlRequestParticipants] = None,
        redirect_url: str = None,
        source_info: GetProcessStartUrlRequestSourceInfo = None,
        task_name: str = None,
        ccs: List[GetProcessStartUrlRequestCcs] = None,
        ding_isv_access_token: str = None,
        ding_suite_key: str = None,
    ):
        self.files = files
        self.ding_corp_id = ding_corp_id
        self.initiator_user_id = initiator_user_id
        self.participants = participants
        self.redirect_url = redirect_url
        self.source_info = source_info
        self.task_name = task_name
        self.ccs = ccs
        self.ding_isv_access_token = ding_isv_access_token
        self.ding_suite_key = ding_suite_key

    def validate(self):
        if self.files:
            for k in self.files:
                if k:
                    k.validate()
        if self.participants:
            for k in self.participants:
                if k:
                    k.validate()
        if self.source_info:
            self.source_info.validate()
        if self.ccs:
            for k in self.ccs:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['files'] = []
        if self.files is not None:
            for k in self.files:
                result['files'].append(k.to_map() if k else None)
        if self.ding_corp_id is not None:
            result['dingCorpId'] = self.ding_corp_id
        if self.initiator_user_id is not None:
            result['initiatorUserId'] = self.initiator_user_id
        result['participants'] = []
        if self.participants is not None:
            for k in self.participants:
                result['participants'].append(k.to_map() if k else None)
        if self.redirect_url is not None:
            result['redirectUrl'] = self.redirect_url
        if self.source_info is not None:
            result['sourceInfo'] = self.source_info.to_map()
        if self.task_name is not None:
            result['taskName'] = self.task_name
        result['ccs'] = []
        if self.ccs is not None:
            for k in self.ccs:
                result['ccs'].append(k.to_map() if k else None)
        if self.ding_isv_access_token is not None:
            result['dingIsvAccessToken'] = self.ding_isv_access_token
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.files = []
        if m.get('files') is not None:
            for k in m.get('files'):
                temp_model = GetProcessStartUrlRequestFiles()
                self.files.append(temp_model.from_map(k))
        if m.get('dingCorpId') is not None:
            self.ding_corp_id = m.get('dingCorpId')
        if m.get('initiatorUserId') is not None:
            self.initiator_user_id = m.get('initiatorUserId')
        self.participants = []
        if m.get('participants') is not None:
            for k in m.get('participants'):
                temp_model = GetProcessStartUrlRequestParticipants()
                self.participants.append(temp_model.from_map(k))
        if m.get('redirectUrl') is not None:
            self.redirect_url = m.get('redirectUrl')
        if m.get('sourceInfo') is not None:
            temp_model = GetProcessStartUrlRequestSourceInfo()
            self.source_info = temp_model.from_map(m['sourceInfo'])
        if m.get('taskName') is not None:
            self.task_name = m.get('taskName')
        self.ccs = []
        if m.get('ccs') is not None:
            for k in m.get('ccs'):
                temp_model = GetProcessStartUrlRequestCcs()
                self.ccs.append(temp_model.from_map(k))
        if m.get('dingIsvAccessToken') is not None:
            self.ding_isv_access_token = m.get('dingIsvAccessToken')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        return self


class GetProcessStartUrlResponseBodyData(TeaModel):
    def __init__(
        self,
        task_id: str = None,
        pc_url: str = None,
        mobile_url: str = None,
    ):
        self.task_id = task_id
        self.pc_url = pc_url
        self.mobile_url = mobile_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.task_id is not None:
            result['taskId'] = self.task_id
        if self.pc_url is not None:
            result['pcUrl'] = self.pc_url
        if self.mobile_url is not None:
            result['mobileUrl'] = self.mobile_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        if m.get('pcUrl') is not None:
            self.pc_url = m.get('pcUrl')
        if m.get('mobileUrl') is not None:
            self.mobile_url = m.get('mobileUrl')
        return self


class GetProcessStartUrlResponseBody(TeaModel):
    def __init__(
        self,
        message: str = None,
        code: int = None,
        data: GetProcessStartUrlResponseBodyData = None,
    ):
        self.message = message
        self.code = code
        self.data = data

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.message is not None:
            result['message'] = self.message
        if self.code is not None:
            result['code'] = self.code
        if self.data is not None:
            result['data'] = self.data.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('message') is not None:
            self.message = m.get('message')
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('data') is not None:
            temp_model = GetProcessStartUrlResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        return self


class GetProcessStartUrlResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetProcessStartUrlResponseBody = None,
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
            temp_model = GetProcessStartUrlResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CorpConsoleHeaders(TeaModel):
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


class CorpConsoleResponseBodyData(TeaModel):
    def __init__(
        self,
        org_console_url: int = None,
    ):
        self.org_console_url = org_console_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.org_console_url is not None:
            result['orgConsoleUrl'] = self.org_console_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('orgConsoleUrl') is not None:
            self.org_console_url = m.get('orgConsoleUrl')
        return self


class CorpConsoleResponseBody(TeaModel):
    def __init__(
        self,
        data: CorpConsoleResponseBodyData = None,
        code: int = None,
        message: str = None,
    ):
        self.data = data
        self.code = code
        self.message = message

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.code is not None:
            result['code'] = self.code
        if self.message is not None:
            result['message'] = self.message
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            temp_model = CorpConsoleResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('message') is not None:
            self.message = m.get('message')
        return self


class CorpConsoleResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CorpConsoleResponseBody = None,
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
            temp_model = CorpConsoleResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListFlowDocsHeaders(TeaModel):
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


class ListFlowDocsRequest(TeaModel):
    def __init__(
        self,
        task_id: str = None,
    ):
        self.task_id = task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class ListFlowDocsResponseBodyData(TeaModel):
    def __init__(
        self,
        file_id: str = None,
        file_name: str = None,
        file_url: str = None,
    ):
        self.file_id = file_id
        self.file_name = file_name
        self.file_url = file_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_id is not None:
            result['fileId'] = self.file_id
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.file_url is not None:
            result['fileUrl'] = self.file_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileId') is not None:
            self.file_id = m.get('fileId')
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('fileUrl') is not None:
            self.file_url = m.get('fileUrl')
        return self


class ListFlowDocsResponseBody(TeaModel):
    def __init__(
        self,
        data: List[ListFlowDocsResponseBodyData] = None,
        code: int = None,
        message: str = None,
    ):
        self.data = data
        self.code = code
        self.message = message

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
        if self.code is not None:
            result['code'] = self.code
        if self.message is not None:
            result['message'] = self.message
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = ListFlowDocsResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('message') is not None:
            self.message = m.get('message')
        return self


class ListFlowDocsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListFlowDocsResponseBody = None,
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
            temp_model = ListFlowDocsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetUserInfoHeaders(TeaModel):
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


class GetUserInfoResponseBodyData(TeaModel):
    def __init__(
        self,
        real_name: bool = None,
        user_real_name: str = None,
    ):
        self.real_name = real_name
        self.user_real_name = user_real_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.real_name is not None:
            result['realName'] = self.real_name
        if self.user_real_name is not None:
            result['userRealName'] = self.user_real_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('realName') is not None:
            self.real_name = m.get('realName')
        if m.get('userRealName') is not None:
            self.user_real_name = m.get('userRealName')
        return self


class GetUserInfoResponseBody(TeaModel):
    def __init__(
        self,
        data: GetUserInfoResponseBodyData = None,
        code: int = None,
        message: str = None,
    ):
        self.data = data
        self.code = code
        self.message = message

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.code is not None:
            result['code'] = self.code
        if self.message is not None:
            result['message'] = self.message
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            temp_model = GetUserInfoResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('message') is not None:
            self.message = m.get('message')
        return self


class GetUserInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetUserInfoResponseBody = None,
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
            temp_model = GetUserInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetCropStatusHeaders(TeaModel):
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


class GetCropStatusResponseBodyData(TeaModel):
    def __init__(
        self,
        auth_status: str = None,
        install_status: str = None,
    ):
        self.auth_status = auth_status
        self.install_status = install_status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.auth_status is not None:
            result['authStatus'] = self.auth_status
        if self.install_status is not None:
            result['installStatus'] = self.install_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('authStatus') is not None:
            self.auth_status = m.get('authStatus')
        if m.get('installStatus') is not None:
            self.install_status = m.get('installStatus')
        return self


class GetCropStatusResponseBody(TeaModel):
    def __init__(
        self,
        data: GetCropStatusResponseBodyData = None,
        code: int = None,
        message: str = None,
    ):
        self.data = data
        self.code = code
        self.message = message

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.code is not None:
            result['code'] = self.code
        if self.message is not None:
            result['message'] = self.message
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            temp_model = GetCropStatusResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('message') is not None:
            self.message = m.get('message')
        return self


class GetCropStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetCropStatusResponseBody = None,
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
            temp_model = GetCropStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ChannelOrderHeaders(TeaModel):
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


class ChannelOrderRequest(TeaModel):
    def __init__(
        self,
        ding_corp_id: str = None,
        item_code: str = None,
        item_name: str = None,
        order_create_time: int = None,
        order_id: str = None,
        pay_fee: int = None,
        quantity: int = None,
        ding_isv_access_token: str = None,
        ding_suite_key: str = None,
    ):
        self.ding_corp_id = ding_corp_id
        self.item_code = item_code
        self.item_name = item_name
        self.order_create_time = order_create_time
        self.order_id = order_id
        self.pay_fee = pay_fee
        self.quantity = quantity
        self.ding_isv_access_token = ding_isv_access_token
        self.ding_suite_key = ding_suite_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_corp_id is not None:
            result['dingCorpId'] = self.ding_corp_id
        if self.item_code is not None:
            result['itemCode'] = self.item_code
        if self.item_name is not None:
            result['itemName'] = self.item_name
        if self.order_create_time is not None:
            result['orderCreateTime'] = self.order_create_time
        if self.order_id is not None:
            result['orderId'] = self.order_id
        if self.pay_fee is not None:
            result['payFee'] = self.pay_fee
        if self.quantity is not None:
            result['quantity'] = self.quantity
        if self.ding_isv_access_token is not None:
            result['dingIsvAccessToken'] = self.ding_isv_access_token
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingCorpId') is not None:
            self.ding_corp_id = m.get('dingCorpId')
        if m.get('itemCode') is not None:
            self.item_code = m.get('itemCode')
        if m.get('itemName') is not None:
            self.item_name = m.get('itemName')
        if m.get('orderCreateTime') is not None:
            self.order_create_time = m.get('orderCreateTime')
        if m.get('orderId') is not None:
            self.order_id = m.get('orderId')
        if m.get('payFee') is not None:
            self.pay_fee = m.get('payFee')
        if m.get('quantity') is not None:
            self.quantity = m.get('quantity')
        if m.get('dingIsvAccessToken') is not None:
            self.ding_isv_access_token = m.get('dingIsvAccessToken')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        return self


class ChannelOrderResponseBodyData(TeaModel):
    def __init__(
        self,
        esign_order_id: str = None,
    ):
        self.esign_order_id = esign_order_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.esign_order_id is not None:
            result['esignOrderId'] = self.esign_order_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('esignOrderId') is not None:
            self.esign_order_id = m.get('esignOrderId')
        return self


class ChannelOrderResponseBody(TeaModel):
    def __init__(
        self,
        code: int = None,
        message: str = None,
        data: ChannelOrderResponseBodyData = None,
    ):
        self.code = code
        self.message = message
        self.data = data

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.message is not None:
            result['message'] = self.message
        if self.data is not None:
            result['data'] = self.data.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('message') is not None:
            self.message = m.get('message')
        if m.get('data') is not None:
            temp_model = ChannelOrderResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        return self


class ChannelOrderResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ChannelOrderResponseBody = None,
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
            temp_model = ChannelOrderResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class OrderResaleHeaders(TeaModel):
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


class OrderResaleRequest(TeaModel):
    def __init__(
        self,
        ding_corp_id: str = None,
        service_start_time: int = None,
        service_stop_time: int = None,
        order_create_time: int = None,
        order_id: str = None,
        quantity: int = None,
        ding_isv_access_token: str = None,
        ding_suite_key: str = None,
    ):
        self.ding_corp_id = ding_corp_id
        self.service_start_time = service_start_time
        self.service_stop_time = service_stop_time
        self.order_create_time = order_create_time
        self.order_id = order_id
        self.quantity = quantity
        self.ding_isv_access_token = ding_isv_access_token
        self.ding_suite_key = ding_suite_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_corp_id is not None:
            result['dingCorpId'] = self.ding_corp_id
        if self.service_start_time is not None:
            result['serviceStartTime'] = self.service_start_time
        if self.service_stop_time is not None:
            result['serviceStopTime'] = self.service_stop_time
        if self.order_create_time is not None:
            result['orderCreateTime'] = self.order_create_time
        if self.order_id is not None:
            result['orderId'] = self.order_id
        if self.quantity is not None:
            result['quantity'] = self.quantity
        if self.ding_isv_access_token is not None:
            result['dingIsvAccessToken'] = self.ding_isv_access_token
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingCorpId') is not None:
            self.ding_corp_id = m.get('dingCorpId')
        if m.get('serviceStartTime') is not None:
            self.service_start_time = m.get('serviceStartTime')
        if m.get('serviceStopTime') is not None:
            self.service_stop_time = m.get('serviceStopTime')
        if m.get('orderCreateTime') is not None:
            self.order_create_time = m.get('orderCreateTime')
        if m.get('orderId') is not None:
            self.order_id = m.get('orderId')
        if m.get('quantity') is not None:
            self.quantity = m.get('quantity')
        if m.get('dingIsvAccessToken') is not None:
            self.ding_isv_access_token = m.get('dingIsvAccessToken')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        return self


class OrderResaleResponseBodyData(TeaModel):
    def __init__(
        self,
        esign_order_id: str = None,
    ):
        self.esign_order_id = esign_order_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.esign_order_id is not None:
            result['esignOrderId'] = self.esign_order_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('esignOrderId') is not None:
            self.esign_order_id = m.get('esignOrderId')
        return self


class OrderResaleResponseBody(TeaModel):
    def __init__(
        self,
        code: int = None,
        message: str = None,
        data: OrderResaleResponseBodyData = None,
    ):
        self.code = code
        self.message = message
        self.data = data

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.message is not None:
            result['message'] = self.message
        if self.data is not None:
            result['data'] = self.data.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('message') is not None:
            self.message = m.get('message')
        if m.get('data') is not None:
            temp_model = OrderResaleResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        return self


class OrderResaleResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: OrderResaleResponseBody = None,
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
            temp_model = OrderResaleResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetFlowSignDetailHeaders(TeaModel):
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


class GetFlowSignDetailRequest(TeaModel):
    def __init__(
        self,
        task_id: str = None,
    ):
        self.task_id = task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class GetFlowSignDetailResponseBodyDataSigners(TeaModel):
    def __init__(
        self,
        signer_name: str = None,
        sign_status: int = None,
    ):
        self.signer_name = signer_name
        self.sign_status = sign_status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.signer_name is not None:
            result['signerName'] = self.signer_name
        if self.sign_status is not None:
            result['signStatus'] = self.sign_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('signerName') is not None:
            self.signer_name = m.get('signerName')
        if m.get('signStatus') is not None:
            self.sign_status = m.get('signStatus')
        return self


class GetFlowSignDetailResponseBodyData(TeaModel):
    def __init__(
        self,
        business_sense: str = None,
        flow_status: int = None,
        signers: List[GetFlowSignDetailResponseBodyDataSigners] = None,
    ):
        self.business_sense = business_sense
        self.flow_status = flow_status
        self.signers = signers

    def validate(self):
        if self.signers:
            for k in self.signers:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.business_sense is not None:
            result['businessSense'] = self.business_sense
        if self.flow_status is not None:
            result['flowStatus'] = self.flow_status
        result['signers'] = []
        if self.signers is not None:
            for k in self.signers:
                result['signers'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('businessSense') is not None:
            self.business_sense = m.get('businessSense')
        if m.get('flowStatus') is not None:
            self.flow_status = m.get('flowStatus')
        self.signers = []
        if m.get('signers') is not None:
            for k in m.get('signers'):
                temp_model = GetFlowSignDetailResponseBodyDataSigners()
                self.signers.append(temp_model.from_map(k))
        return self


class GetFlowSignDetailResponseBody(TeaModel):
    def __init__(
        self,
        data: GetFlowSignDetailResponseBodyData = None,
        code: int = None,
        message: str = None,
    ):
        self.data = data
        self.code = code
        self.message = message

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.code is not None:
            result['code'] = self.code
        if self.message is not None:
            result['message'] = self.message
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            temp_model = GetFlowSignDetailResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('message') is not None:
            self.message = m.get('message')
        return self


class GetFlowSignDetailResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetFlowSignDetailResponseBody = None,
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
            temp_model = GetFlowSignDetailResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


