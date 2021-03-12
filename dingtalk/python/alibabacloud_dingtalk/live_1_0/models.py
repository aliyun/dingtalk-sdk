# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class StartCloudFeedHeaders(TeaModel):
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


class StartCloudFeedRequest(TeaModel):
    def __init__(
        self,
        user_id: str = None,
    ):
        # 操作者的组织内id（staffId）
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class StartCloudFeedResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        # 状态更改是否成功
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class StartCloudFeedResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: StartCloudFeedResponseBody = None,
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
            temp_model = StartCloudFeedResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class StopCloudFeedHeaders(TeaModel):
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


class StopCloudFeedRequest(TeaModel):
    def __init__(
        self,
        user_id: str = None,
    ):
        # 操作者的组织内id（staffId）
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class StopCloudFeedResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        # 状态更改是否成功
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class StopCloudFeedResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: StopCloudFeedResponseBody = None,
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
            temp_model = StopCloudFeedResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateCloudFeedHeaders(TeaModel):
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


class CreateCloudFeedRequest(TeaModel):
    def __init__(
        self,
        title: str = None,
        intro: str = None,
        user_id: str = None,
        start_time: int = None,
        cover_url: str = None,
        video_url: str = None,
    ):
        # 课程标题
        self.title = title
        # 课程简介
        self.intro = intro
        # 创建课程的主播id（staffId）
        self.user_id = user_id
        # 预计开始的时间戳(未来的时间点)
        self.start_time = start_time
        # 课程封面Url
        self.cover_url = cover_url
        # 云导播课程资源的url
        self.video_url = video_url

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.title is not None:
            result['title'] = self.title
        if self.intro is not None:
            result['intro'] = self.intro
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.cover_url is not None:
            result['coverUrl'] = self.cover_url
        if self.video_url is not None:
            result['videoUrl'] = self.video_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('intro') is not None:
            self.intro = m.get('intro')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('coverUrl') is not None:
            self.cover_url = m.get('coverUrl')
        if m.get('videoUrl') is not None:
            self.video_url = m.get('videoUrl')
        return self


class CreateCloudFeedResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
    ):
        # 8c0ed3c3-e125-4a9d-aa40-18ad999398d4
        self.result = result

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.result is not None:
            result['result'] = self.result
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        return self


class CreateCloudFeedResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateCloudFeedResponseBody = None,
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
            temp_model = CreateCloudFeedResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AddShareCidListHeaders(TeaModel):
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


class AddShareCidListRequest(TeaModel):
    def __init__(
        self,
        user_id: str = None,
        group_ids: List[str] = None,
        group_id_type: int = None,
    ):
        # 操作的的组织内id(staffId)
        self.user_id = user_id
        # 添加的联播群列表
        self.group_ids = group_ids
        # 传入的群id类型（1 chatId / 2 openConversationId ）
        self.group_id_type = group_id_type

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.group_ids is not None:
            result['groupIds'] = self.group_ids
        if self.group_id_type is not None:
            result['groupIdType'] = self.group_id_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('groupIds') is not None:
            self.group_ids = m.get('groupIds')
        if m.get('groupIdType') is not None:
            self.group_id_type = m.get('groupIdType')
        return self


class AddShareCidListResponseBody(TeaModel):
    def __init__(
        self,
        has_share_success: bool = None,
        share_success_group_list: List[str] = None,
    ):
        # 是否联播成功
        self.has_share_success = has_share_success
        # 本次请求成功联播的群列表
        self.share_success_group_list = share_success_group_list

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.has_share_success is not None:
            result['hasShareSuccess'] = self.has_share_success
        if self.share_success_group_list is not None:
            result['shareSuccessGroupList'] = self.share_success_group_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasShareSuccess') is not None:
            self.has_share_success = m.get('hasShareSuccess')
        if m.get('shareSuccessGroupList') is not None:
            self.share_success_group_list = m.get('shareSuccessGroupList')
        return self


class AddShareCidListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: AddShareCidListResponseBody = None,
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
            temp_model = AddShareCidListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


