# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict


class GetDownloadInfoHeaders(TeaModel):
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


class GetDownloadInfoResponseBodyPresignedUrlDownloadInfo(TeaModel):
    def __init__(
        self,
        resource_url: str = None,
        expiration: int = None,
    ):
        # 加签url
        self.resource_url = resource_url
        # 加签url过期时间(分钟)
        self.expiration = expiration

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.resource_url is not None:
            result['resourceUrl'] = self.resource_url
        if self.expiration is not None:
            result['expiration'] = self.expiration
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('resourceUrl') is not None:
            self.resource_url = m.get('resourceUrl')
        if m.get('expiration') is not None:
            self.expiration = m.get('expiration')
        return self


class GetDownloadInfoResponseBody(TeaModel):
    def __init__(
        self,
        presigned_url_download_info: GetDownloadInfoResponseBodyPresignedUrlDownloadInfo = None,
    ):
        # 下载加签url信息
        self.presigned_url_download_info = presigned_url_download_info

    def validate(self):
        if self.presigned_url_download_info:
            self.presigned_url_download_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.presigned_url_download_info is not None:
            result['presignedUrlDownloadInfo'] = self.presigned_url_download_info.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('presignedUrlDownloadInfo') is not None:
            temp_model = GetDownloadInfoResponseBodyPresignedUrlDownloadInfo()
            self.presigned_url_download_info = temp_model.from_map(m['presignedUrlDownloadInfo'])
        return self


class GetDownloadInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetDownloadInfoResponseBody = None,
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
            temp_model = GetDownloadInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


