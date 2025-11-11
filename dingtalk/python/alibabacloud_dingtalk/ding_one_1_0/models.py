# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List, Any


class DeleteFeedHeaders(TeaModel):
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


class DeleteFeedRequest(TeaModel):
    def __init__(
        self,
        feed_id: str = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.feed_id = feed_id
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.feed_id is not None:
            result['feedId'] = self.feed_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('feedId') is not None:
            self.feed_id = m.get('feedId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class DeleteFeedResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        self.request_id = request_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class DeleteFeedResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteFeedResponseBody = None,
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
            temp_model = DeleteFeedResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


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


class PushFeedHeaders(TeaModel):
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


class PushFeedRequestContentDslTemplateContent(TeaModel):
    def __init__(
        self,
        apply_url: str = None,
        body: str = None,
    ):
        # This parameter is required.
        self.apply_url = apply_url
        # This parameter is required.
        self.body = body

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.apply_url is not None:
            result['applyUrl'] = self.apply_url
        if self.body is not None:
            result['body'] = self.body
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('applyUrl') is not None:
            self.apply_url = m.get('applyUrl')
        if m.get('body') is not None:
            self.body = m.get('body')
        return self


class PushFeedRequestContent(TeaModel):
    def __init__(
        self,
        content_type: str = None,
        dsl_template_content: PushFeedRequestContentDslTemplateContent = None,
    ):
        # This parameter is required.
        self.content_type = content_type
        # This parameter is required.
        self.dsl_template_content = dsl_template_content

    def validate(self):
        if self.dsl_template_content:
            self.dsl_template_content.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content_type is not None:
            result['contentType'] = self.content_type
        if self.dsl_template_content is not None:
            result['dslTemplateContent'] = self.dsl_template_content.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('contentType') is not None:
            self.content_type = m.get('contentType')
        if m.get('dslTemplateContent') is not None:
            temp_model = PushFeedRequestContentDslTemplateContent()
            self.dsl_template_content = temp_model.from_map(m['dslTemplateContent'])
        return self


class PushFeedRequest(TeaModel):
    def __init__(
        self,
        content: PushFeedRequestContent = None,
        expire_time: int = None,
        feed_feature: Dict[str, Any] = None,
        idempotent_key: str = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.content = content
        # This parameter is required.
        self.expire_time = expire_time
        # This parameter is required.
        self.feed_feature = feed_feature
        # This parameter is required.
        self.idempotent_key = idempotent_key
        # This parameter is required.
        self.union_id = union_id

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
        if self.expire_time is not None:
            result['expireTime'] = self.expire_time
        if self.feed_feature is not None:
            result['feedFeature'] = self.feed_feature
        if self.idempotent_key is not None:
            result['idempotentKey'] = self.idempotent_key
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            temp_model = PushFeedRequestContent()
            self.content = temp_model.from_map(m['content'])
        if m.get('expireTime') is not None:
            self.expire_time = m.get('expireTime')
        if m.get('feedFeature') is not None:
            self.feed_feature = m.get('feedFeature')
        if m.get('idempotentKey') is not None:
            self.idempotent_key = m.get('idempotentKey')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class PushFeedResponseBodyResult(TeaModel):
    def __init__(
        self,
        feed_id: str = None,
    ):
        self.feed_id = feed_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.feed_id is not None:
            result['feedId'] = self.feed_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('feedId') is not None:
            self.feed_id = m.get('feedId')
        return self


class PushFeedResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: PushFeedResponseBodyResult = None,
    ):
        self.request_id = request_id
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            temp_model = PushFeedResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class PushFeedResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PushFeedResponseBody = None,
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
            temp_model = PushFeedResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateFeedContentHeaders(TeaModel):
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


class UpdateFeedContentRequestContentDslTemplateContent(TeaModel):
    def __init__(
        self,
        apply_url: str = None,
        body: str = None,
    ):
        # This parameter is required.
        self.apply_url = apply_url
        # This parameter is required.
        self.body = body

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.apply_url is not None:
            result['applyUrl'] = self.apply_url
        if self.body is not None:
            result['body'] = self.body
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('applyUrl') is not None:
            self.apply_url = m.get('applyUrl')
        if m.get('body') is not None:
            self.body = m.get('body')
        return self


class UpdateFeedContentRequestContent(TeaModel):
    def __init__(
        self,
        content_type: str = None,
        dsl_template_content: UpdateFeedContentRequestContentDslTemplateContent = None,
    ):
        # This parameter is required.
        self.content_type = content_type
        # This parameter is required.
        self.dsl_template_content = dsl_template_content

    def validate(self):
        if self.dsl_template_content:
            self.dsl_template_content.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content_type is not None:
            result['contentType'] = self.content_type
        if self.dsl_template_content is not None:
            result['dslTemplateContent'] = self.dsl_template_content.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('contentType') is not None:
            self.content_type = m.get('contentType')
        if m.get('dslTemplateContent') is not None:
            temp_model = UpdateFeedContentRequestContentDslTemplateContent()
            self.dsl_template_content = temp_model.from_map(m['dslTemplateContent'])
        return self


class UpdateFeedContentRequest(TeaModel):
    def __init__(
        self,
        content: UpdateFeedContentRequestContent = None,
        feed_id: str = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.content = content
        # This parameter is required.
        self.feed_id = feed_id
        # This parameter is required.
        self.union_id = union_id

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
        if self.feed_id is not None:
            result['feedId'] = self.feed_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            temp_model = UpdateFeedContentRequestContent()
            self.content = temp_model.from_map(m['content'])
        if m.get('feedId') is not None:
            self.feed_id = m.get('feedId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class UpdateFeedContentResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        self.request_id = request_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class UpdateFeedContentResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateFeedContentResponseBody = None,
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
            temp_model = UpdateFeedContentResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateFeedExpireTimeHeaders(TeaModel):
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


class UpdateFeedExpireTimeRequest(TeaModel):
    def __init__(
        self,
        expire_time: int = None,
        feed_id: str = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.expire_time = expire_time
        # This parameter is required.
        self.feed_id = feed_id
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.expire_time is not None:
            result['expireTime'] = self.expire_time
        if self.feed_id is not None:
            result['feedId'] = self.feed_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('expireTime') is not None:
            self.expire_time = m.get('expireTime')
        if m.get('feedId') is not None:
            self.feed_id = m.get('feedId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class UpdateFeedExpireTimeResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        self.request_id = request_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class UpdateFeedExpireTimeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateFeedExpireTimeResponseBody = None,
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
            temp_model = UpdateFeedExpireTimeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


