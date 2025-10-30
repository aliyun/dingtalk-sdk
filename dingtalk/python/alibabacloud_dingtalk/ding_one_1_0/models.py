# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class DeliverOneFeedHeaders(TeaModel):
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


class DeliverOneFeedRequest(TeaModel):
    def __init__(
        self,
        content: str = None,
        cover_media_id: str = None,
        expire_time: int = None,
        summary: str = None,
        user_ids: List[str] = None,
        video_media_id: str = None,
        video_tags: Dict[str, str] = None,
    ):
        # This parameter is required.
        self.content = content
        # This parameter is required.
        self.cover_media_id = cover_media_id
        self.expire_time = expire_time
        # This parameter is required.
        self.summary = summary
        self.user_ids = user_ids
        # This parameter is required.
        self.video_media_id = video_media_id
        # This parameter is required.
        self.video_tags = video_tags

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.cover_media_id is not None:
            result['coverMediaId'] = self.cover_media_id
        if self.expire_time is not None:
            result['expireTime'] = self.expire_time
        if self.summary is not None:
            result['summary'] = self.summary
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        if self.video_media_id is not None:
            result['videoMediaId'] = self.video_media_id
        if self.video_tags is not None:
            result['videoTags'] = self.video_tags
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('coverMediaId') is not None:
            self.cover_media_id = m.get('coverMediaId')
        if m.get('expireTime') is not None:
            self.expire_time = m.get('expireTime')
        if m.get('summary') is not None:
            self.summary = m.get('summary')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        if m.get('videoMediaId') is not None:
            self.video_media_id = m.get('videoMediaId')
        if m.get('videoTags') is not None:
            self.video_tags = m.get('videoTags')
        return self


class DeliverOneFeedResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
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


class DeliverOneFeedResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeliverOneFeedResponseBody = None,
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
            temp_model = DeliverOneFeedResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


