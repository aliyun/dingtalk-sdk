# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


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


class AddShareCidListRequest(TeaModel):
    def __init__(
        self,
        group_id_type: int = None,
        group_ids: List[str] = None,
        user_id: str = None,
    ):
        # 传入的群id类型（1 chatId / 2 openConversationId ）
        self.group_id_type = group_id_type
        # 添加的联播群列表
        self.group_ids = group_ids
        # 操作的的组织内id(staffId)
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_id_type is not None:
            result['groupIdType'] = self.group_id_type
        if self.group_ids is not None:
            result['groupIds'] = self.group_ids
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupIdType') is not None:
            self.group_id_type = m.get('groupIdType')
        if m.get('groupIds') is not None:
            self.group_ids = m.get('groupIds')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
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
        _map = super().to_map()
        if _map is not None:
            return _map

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
            temp_model = AddShareCidListResponseBody()
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


class CreateCloudFeedRequest(TeaModel):
    def __init__(
        self,
        cover_url: str = None,
        intro: str = None,
        start_time: int = None,
        title: str = None,
        user_id: str = None,
        video_url: str = None,
    ):
        # 课程封面Url
        self.cover_url = cover_url
        # 课程简介
        self.intro = intro
        # 预计开始的时间戳(未来的时间点)
        self.start_time = start_time
        # 课程标题
        self.title = title
        # 创建课程的主播id（staffId）
        self.user_id = user_id
        # 云导播课程资源的url
        self.video_url = video_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cover_url is not None:
            result['coverUrl'] = self.cover_url
        if self.intro is not None:
            result['intro'] = self.intro
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.title is not None:
            result['title'] = self.title
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.video_url is not None:
            result['videoUrl'] = self.video_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('coverUrl') is not None:
            self.cover_url = m.get('coverUrl')
        if m.get('intro') is not None:
            self.intro = m.get('intro')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
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
            temp_model = CreateCloudFeedResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateLiveHeaders(TeaModel):
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


class CreateLiveRequest(TeaModel):
    def __init__(
        self,
        cover_url: str = None,
        introduction: str = None,
        pre_end_time: int = None,
        pre_start_time: int = None,
        title: str = None,
        union_id: str = None,
    ):
        # 直播封面
        self.cover_url = cover_url
        # 简介
        self.introduction = introduction
        # 预计结束时间
        self.pre_end_time = pre_end_time
        # 预计开播时间
        self.pre_start_time = pre_start_time
        # 标题
        self.title = title
        # 用户id（主播id）
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cover_url is not None:
            result['coverUrl'] = self.cover_url
        if self.introduction is not None:
            result['introduction'] = self.introduction
        if self.pre_end_time is not None:
            result['preEndTime'] = self.pre_end_time
        if self.pre_start_time is not None:
            result['preStartTime'] = self.pre_start_time
        if self.title is not None:
            result['title'] = self.title
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('coverUrl') is not None:
            self.cover_url = m.get('coverUrl')
        if m.get('introduction') is not None:
            self.introduction = m.get('introduction')
        if m.get('preEndTime') is not None:
            self.pre_end_time = m.get('preEndTime')
        if m.get('preStartTime') is not None:
            self.pre_start_time = m.get('preStartTime')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class CreateLiveResponseBodyResult(TeaModel):
    def __init__(
        self,
        live_id: str = None,
    ):
        self.live_id = live_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.live_id is not None:
            result['liveId'] = self.live_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('liveId') is not None:
            self.live_id = m.get('liveId')
        return self


class CreateLiveResponseBody(TeaModel):
    def __init__(
        self,
        result: CreateLiveResponseBodyResult = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = CreateLiveResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class CreateLiveResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateLiveResponseBody = None,
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
            temp_model = CreateLiveResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteLiveHeaders(TeaModel):
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


class DeleteLiveRequest(TeaModel):
    def __init__(
        self,
        live_id: str = None,
        union_id: str = None,
    ):
        # 直播id
        self.live_id = live_id
        # 用户id
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.live_id is not None:
            result['liveId'] = self.live_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('liveId') is not None:
            self.live_id = m.get('liveId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class DeleteLiveResponseBodyResult(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class DeleteLiveResponseBody(TeaModel):
    def __init__(
        self,
        result: DeleteLiveResponseBodyResult = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = DeleteLiveResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class DeleteLiveResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DeleteLiveResponseBody = None,
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
            temp_model = DeleteLiveResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteLiveFeedHeaders(TeaModel):
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


class DeleteLiveFeedRequest(TeaModel):
    def __init__(
        self,
        user_id: str = None,
    ):
        # 用户id（操作者的组织内id）
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class DeleteLiveFeedResponseBody(TeaModel):
    def __init__(
        self,
        has_delete: bool = None,
    ):
        # 是否删除成功
        self.has_delete = has_delete

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_delete is not None:
            result['hasDelete'] = self.has_delete
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasDelete') is not None:
            self.has_delete = m.get('hasDelete')
        return self


class DeleteLiveFeedResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DeleteLiveFeedResponseBody = None,
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
            temp_model = DeleteLiveFeedResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class EditFeedReplayHeaders(TeaModel):
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


class EditFeedReplayRequest(TeaModel):
    def __init__(
        self,
        edit_end_time: int = None,
        edit_start_time: int = None,
        user_id: str = None,
    ):
        # 剪辑的结束位置的时间戳（在原开始结束的时间戳之内）
        self.edit_end_time = edit_end_time
        # 剪辑的起始位置的时间戳（在原开始结束的时间戳之内）
        self.edit_start_time = edit_start_time
        # 用户id(剪辑者的组织内id)
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.edit_end_time is not None:
            result['editEndTime'] = self.edit_end_time
        if self.edit_start_time is not None:
            result['editStartTime'] = self.edit_start_time
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('editEndTime') is not None:
            self.edit_end_time = m.get('editEndTime')
        if m.get('editStartTime') is not None:
            self.edit_start_time = m.get('editStartTime')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class EditFeedReplayResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
    ):
        # 剪辑后的视频地址（含authkey）
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


class EditFeedReplayResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: EditFeedReplayResponseBody = None,
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
            temp_model = EditFeedReplayResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetUserAllLiveListHeaders(TeaModel):
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


class GetUserAllLiveListRequest(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        start_time: int = None,
        statuses: List[int] = None,
        title: str = None,
        page_number: int = None,
        page_size: int = None,
        union_id: str = None,
    ):
        # 筛选直播截止时间
        self.end_time = end_time
        # 筛选直播开始时间
        self.start_time = start_time
        # 直播状态列表
        self.statuses = statuses
        # 筛选直播标题
        self.title = title
        # 第几页，从1开始
        self.page_number = page_number
        # 单次拉去上限，默认40个
        self.page_size = page_size
        # 用户uid
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.statuses is not None:
            result['statuses'] = self.statuses
        if self.title is not None:
            result['title'] = self.title
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('statuses') is not None:
            self.statuses = m.get('statuses')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetUserAllLiveListResponseBodyResultLiveInfoPopModelListExtraInfo(TeaModel):
    def __init__(
        self,
        has_subscribed: bool = None,
        is_forecast_expired: bool = None,
        watch_progress_ms: int = None,
    ):
        # 是否关注
        self.has_subscribed = has_subscribed
        # 预告是否过期
        self.is_forecast_expired = is_forecast_expired
        # 回放观看进度
        self.watch_progress_ms = watch_progress_ms

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_subscribed is not None:
            result['hasSubscribed'] = self.has_subscribed
        if self.is_forecast_expired is not None:
            result['isForecastExpired'] = self.is_forecast_expired
        if self.watch_progress_ms is not None:
            result['watchProgressMs'] = self.watch_progress_ms
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasSubscribed') is not None:
            self.has_subscribed = m.get('hasSubscribed')
        if m.get('isForecastExpired') is not None:
            self.is_forecast_expired = m.get('isForecastExpired')
        if m.get('watchProgressMs') is not None:
            self.watch_progress_ms = m.get('watchProgressMs')
        return self


class GetUserAllLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo(TeaModel):
    def __init__(
        self,
        cover_url: str = None,
        duration: int = None,
        end_time: int = None,
        introduction: str = None,
        live_id: str = None,
        live_play_url: str = None,
        live_status: int = None,
        start_time: int = None,
        subscribe_count: int = None,
        title: str = None,
        union_id: str = None,
        uv: int = None,
    ):
        # 直播封面
        self.cover_url = cover_url
        # 直播时长
        self.duration = duration
        # 直播真实结束时间
        self.end_time = end_time
        # 直播简介
        self.introduction = introduction
        # 直播id
        self.live_id = live_id
        # 直播观看地址
        self.live_play_url = live_play_url
        # 直播状态
        self.live_status = live_status
        # 直播真实开始时间
        self.start_time = start_time
        # 预约人数
        self.subscribe_count = subscribe_count
        # 直播标题
        self.title = title
        # 主播id
        self.union_id = union_id
        # 观看人数
        self.uv = uv

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cover_url is not None:
            result['coverUrl'] = self.cover_url
        if self.duration is not None:
            result['duration'] = self.duration
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.introduction is not None:
            result['introduction'] = self.introduction
        if self.live_id is not None:
            result['liveId'] = self.live_id
        if self.live_play_url is not None:
            result['livePlayUrl'] = self.live_play_url
        if self.live_status is not None:
            result['liveStatus'] = self.live_status
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.subscribe_count is not None:
            result['subscribeCount'] = self.subscribe_count
        if self.title is not None:
            result['title'] = self.title
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.uv is not None:
            result['uv'] = self.uv
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('coverUrl') is not None:
            self.cover_url = m.get('coverUrl')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('introduction') is not None:
            self.introduction = m.get('introduction')
        if m.get('liveId') is not None:
            self.live_id = m.get('liveId')
        if m.get('livePlayUrl') is not None:
            self.live_play_url = m.get('livePlayUrl')
        if m.get('liveStatus') is not None:
            self.live_status = m.get('liveStatus')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('subscribeCount') is not None:
            self.subscribe_count = m.get('subscribeCount')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('uv') is not None:
            self.uv = m.get('uv')
        return self


class GetUserAllLiveListResponseBodyResultLiveInfoPopModelList(TeaModel):
    def __init__(
        self,
        extra_info: GetUserAllLiveListResponseBodyResultLiveInfoPopModelListExtraInfo = None,
        live_basic_info: GetUserAllLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo = None,
    ):
        # 直播额外信息
        self.extra_info = extra_info
        # 直播基础信息
        self.live_basic_info = live_basic_info

    def validate(self):
        if self.extra_info:
            self.extra_info.validate()
        if self.live_basic_info:
            self.live_basic_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.extra_info is not None:
            result['extraInfo'] = self.extra_info.to_map()
        if self.live_basic_info is not None:
            result['liveBasicInfo'] = self.live_basic_info.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('extraInfo') is not None:
            temp_model = GetUserAllLiveListResponseBodyResultLiveInfoPopModelListExtraInfo()
            self.extra_info = temp_model.from_map(m['extraInfo'])
        if m.get('liveBasicInfo') is not None:
            temp_model = GetUserAllLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo()
            self.live_basic_info = temp_model.from_map(m['liveBasicInfo'])
        return self


class GetUserAllLiveListResponseBodyResult(TeaModel):
    def __init__(
        self,
        has_finish: bool = None,
        live_info_pop_model_list: List[GetUserAllLiveListResponseBodyResultLiveInfoPopModelList] = None,
    ):
        # 是否拉取完成
        self.has_finish = has_finish
        # 直播详情
        self.live_info_pop_model_list = live_info_pop_model_list

    def validate(self):
        if self.live_info_pop_model_list:
            for k in self.live_info_pop_model_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_finish is not None:
            result['hasFinish'] = self.has_finish
        result['liveInfoPopModelList'] = []
        if self.live_info_pop_model_list is not None:
            for k in self.live_info_pop_model_list:
                result['liveInfoPopModelList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasFinish') is not None:
            self.has_finish = m.get('hasFinish')
        self.live_info_pop_model_list = []
        if m.get('liveInfoPopModelList') is not None:
            for k in m.get('liveInfoPopModelList'):
                temp_model = GetUserAllLiveListResponseBodyResultLiveInfoPopModelList()
                self.live_info_pop_model_list.append(temp_model.from_map(k))
        return self


class GetUserAllLiveListResponseBody(TeaModel):
    def __init__(
        self,
        result: GetUserAllLiveListResponseBodyResult = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = GetUserAllLiveListResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetUserAllLiveListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetUserAllLiveListResponseBody = None,
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
            temp_model = GetUserAllLiveListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetUserCreateLiveListHeaders(TeaModel):
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


class GetUserCreateLiveListRequest(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        start_time: int = None,
        statuses: List[int] = None,
        title: str = None,
        max_results: int = None,
        next_token: str = None,
        union_id: str = None,
    ):
        # 筛选直播截止时间
        self.end_time = end_time
        # 筛选直播开始时间
        self.start_time = start_time
        # 直播状态列表
        self.statuses = statuses
        # 筛选的直播标题
        self.title = title
        # 单次拉去上限，默认40个
        self.max_results = max_results
        # 分页游标 第一次可不填， 后面填回包的值
        self.next_token = next_token
        # 用户uid
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.statuses is not None:
            result['statuses'] = self.statuses
        if self.title is not None:
            result['title'] = self.title
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('statuses') is not None:
            self.statuses = m.get('statuses')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListHasSubscribed(TeaModel):
    def __init__(
        self,
        has_subscribed: bool = None,
        is_forecast_expired: bool = None,
        watch_progress_ms: int = None,
    ):
        # 是否关注
        self.has_subscribed = has_subscribed
        # 预告是否过期
        self.is_forecast_expired = is_forecast_expired
        # 回放观看进度
        self.watch_progress_ms = watch_progress_ms

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_subscribed is not None:
            result['hasSubscribed'] = self.has_subscribed
        if self.is_forecast_expired is not None:
            result['isForecastExpired'] = self.is_forecast_expired
        if self.watch_progress_ms is not None:
            result['watchProgressMs'] = self.watch_progress_ms
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasSubscribed') is not None:
            self.has_subscribed = m.get('hasSubscribed')
        if m.get('isForecastExpired') is not None:
            self.is_forecast_expired = m.get('isForecastExpired')
        if m.get('watchProgressMs') is not None:
            self.watch_progress_ms = m.get('watchProgressMs')
        return self


class GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo(TeaModel):
    def __init__(
        self,
        cover_url: str = None,
        duration: int = None,
        end_time: int = None,
        introduction: str = None,
        live_id: str = None,
        live_play_url: str = None,
        live_status: int = None,
        start_time: int = None,
        subscribe_count: int = None,
        title: str = None,
        union_id: str = None,
        uv: int = None,
    ):
        # 直播封面
        self.cover_url = cover_url
        # 直播时长
        self.duration = duration
        # 直播真实结束时间
        self.end_time = end_time
        # 直播简介
        self.introduction = introduction
        # 直播id
        self.live_id = live_id
        # 直播观看地址
        self.live_play_url = live_play_url
        # 直播状态
        self.live_status = live_status
        # 直播真实开始时间
        self.start_time = start_time
        # 预约人数
        self.subscribe_count = subscribe_count
        # 直播标题
        self.title = title
        # 主播id
        self.union_id = union_id
        # 观看人数
        self.uv = uv

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cover_url is not None:
            result['coverUrl'] = self.cover_url
        if self.duration is not None:
            result['duration'] = self.duration
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.introduction is not None:
            result['introduction'] = self.introduction
        if self.live_id is not None:
            result['liveId'] = self.live_id
        if self.live_play_url is not None:
            result['livePlayUrl'] = self.live_play_url
        if self.live_status is not None:
            result['liveStatus'] = self.live_status
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.subscribe_count is not None:
            result['subscribeCount'] = self.subscribe_count
        if self.title is not None:
            result['title'] = self.title
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.uv is not None:
            result['uv'] = self.uv
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('coverUrl') is not None:
            self.cover_url = m.get('coverUrl')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('introduction') is not None:
            self.introduction = m.get('introduction')
        if m.get('liveId') is not None:
            self.live_id = m.get('liveId')
        if m.get('livePlayUrl') is not None:
            self.live_play_url = m.get('livePlayUrl')
        if m.get('liveStatus') is not None:
            self.live_status = m.get('liveStatus')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('subscribeCount') is not None:
            self.subscribe_count = m.get('subscribeCount')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('uv') is not None:
            self.uv = m.get('uv')
        return self


class GetUserCreateLiveListResponseBodyResultLiveInfoPopModelList(TeaModel):
    def __init__(
        self,
        has_subscribed: GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListHasSubscribed = None,
        live_basic_info: GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo = None,
    ):
        # 直播额外信息
        self.has_subscribed = has_subscribed
        # 直播基础信息
        self.live_basic_info = live_basic_info

    def validate(self):
        if self.has_subscribed:
            self.has_subscribed.validate()
        if self.live_basic_info:
            self.live_basic_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_subscribed is not None:
            result['hasSubscribed'] = self.has_subscribed.to_map()
        if self.live_basic_info is not None:
            result['liveBasicInfo'] = self.live_basic_info.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasSubscribed') is not None:
            temp_model = GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListHasSubscribed()
            self.has_subscribed = temp_model.from_map(m['hasSubscribed'])
        if m.get('liveBasicInfo') is not None:
            temp_model = GetUserCreateLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo()
            self.live_basic_info = temp_model.from_map(m['liveBasicInfo'])
        return self


class GetUserCreateLiveListResponseBodyResult(TeaModel):
    def __init__(
        self,
        has_finish: bool = None,
        live_info_pop_model_list: List[GetUserCreateLiveListResponseBodyResultLiveInfoPopModelList] = None,
        next_token: str = None,
        total: int = None,
    ):
        # 是否拉取完成
        self.has_finish = has_finish
        # 直播详情
        self.live_info_pop_model_list = live_info_pop_model_list
        # 分页游标 分页时填到请求中
        self.next_token = next_token
        # 总数
        self.total = total

    def validate(self):
        if self.live_info_pop_model_list:
            for k in self.live_info_pop_model_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_finish is not None:
            result['hasFinish'] = self.has_finish
        result['liveInfoPopModelList'] = []
        if self.live_info_pop_model_list is not None:
            for k in self.live_info_pop_model_list:
                result['liveInfoPopModelList'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasFinish') is not None:
            self.has_finish = m.get('hasFinish')
        self.live_info_pop_model_list = []
        if m.get('liveInfoPopModelList') is not None:
            for k in m.get('liveInfoPopModelList'):
                temp_model = GetUserCreateLiveListResponseBodyResultLiveInfoPopModelList()
                self.live_info_pop_model_list.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class GetUserCreateLiveListResponseBody(TeaModel):
    def __init__(
        self,
        result: GetUserCreateLiveListResponseBodyResult = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = GetUserCreateLiveListResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetUserCreateLiveListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetUserCreateLiveListResponseBody = None,
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
            temp_model = GetUserCreateLiveListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetUserWatchLiveListHeaders(TeaModel):
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


class GetUserWatchLiveListRequest(TeaModel):
    def __init__(
        self,
        filter_type: int = None,
        max_results: int = None,
        next_token: str = None,
        union_id: str = None,
    ):
        # 过滤类型，0：不过滤， 1：过滤已经看完的
        self.filter_type = filter_type
        # 单次拉去上限，默认40个
        self.max_results = max_results
        # 分页游标 第一次可不填， 后面填回包的值
        self.next_token = next_token
        # 用户uid
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.filter_type is not None:
            result['filterType'] = self.filter_type
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('filterType') is not None:
            self.filter_type = m.get('filterType')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListExtraInfo(TeaModel):
    def __init__(
        self,
        has_subscribed: bool = None,
        is_forecast_expired: bool = None,
        watch_progress_ms: int = None,
    ):
        # 是否关注
        self.has_subscribed = has_subscribed
        # 预告是否过期
        self.is_forecast_expired = is_forecast_expired
        # 回放观看进度
        self.watch_progress_ms = watch_progress_ms

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_subscribed is not None:
            result['hasSubscribed'] = self.has_subscribed
        if self.is_forecast_expired is not None:
            result['isForecastExpired'] = self.is_forecast_expired
        if self.watch_progress_ms is not None:
            result['watchProgressMs'] = self.watch_progress_ms
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasSubscribed') is not None:
            self.has_subscribed = m.get('hasSubscribed')
        if m.get('isForecastExpired') is not None:
            self.is_forecast_expired = m.get('isForecastExpired')
        if m.get('watchProgressMs') is not None:
            self.watch_progress_ms = m.get('watchProgressMs')
        return self


class GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo(TeaModel):
    def __init__(
        self,
        cover_url: str = None,
        duration: int = None,
        end_time: int = None,
        introduction: str = None,
        live_id: str = None,
        live_play_url: str = None,
        live_status: int = None,
        start_time: int = None,
        subscribe_count: int = None,
        title: str = None,
        union_id: str = None,
        uv: int = None,
    ):
        # 直播封面
        self.cover_url = cover_url
        # 直播时长
        self.duration = duration
        # 直播真实结束时间
        self.end_time = end_time
        # 直播简介
        self.introduction = introduction
        # 直播id
        self.live_id = live_id
        # 直播观看地址
        self.live_play_url = live_play_url
        # 直播状态
        self.live_status = live_status
        # 直播真实开始时间
        self.start_time = start_time
        # 预约人数
        self.subscribe_count = subscribe_count
        # 直播标题
        self.title = title
        # 主播id
        self.union_id = union_id
        # 观看人数
        self.uv = uv

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cover_url is not None:
            result['coverUrl'] = self.cover_url
        if self.duration is not None:
            result['duration'] = self.duration
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.introduction is not None:
            result['introduction'] = self.introduction
        if self.live_id is not None:
            result['liveId'] = self.live_id
        if self.live_play_url is not None:
            result['livePlayUrl'] = self.live_play_url
        if self.live_status is not None:
            result['liveStatus'] = self.live_status
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.subscribe_count is not None:
            result['subscribeCount'] = self.subscribe_count
        if self.title is not None:
            result['title'] = self.title
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.uv is not None:
            result['uv'] = self.uv
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('coverUrl') is not None:
            self.cover_url = m.get('coverUrl')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('introduction') is not None:
            self.introduction = m.get('introduction')
        if m.get('liveId') is not None:
            self.live_id = m.get('liveId')
        if m.get('livePlayUrl') is not None:
            self.live_play_url = m.get('livePlayUrl')
        if m.get('liveStatus') is not None:
            self.live_status = m.get('liveStatus')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('subscribeCount') is not None:
            self.subscribe_count = m.get('subscribeCount')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('uv') is not None:
            self.uv = m.get('uv')
        return self


class GetUserWatchLiveListResponseBodyResultLiveInfoPopModelList(TeaModel):
    def __init__(
        self,
        extra_info: GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListExtraInfo = None,
        live_basic_info: GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo = None,
    ):
        # 直播额外信息
        self.extra_info = extra_info
        # 直播基础信息
        self.live_basic_info = live_basic_info

    def validate(self):
        if self.extra_info:
            self.extra_info.validate()
        if self.live_basic_info:
            self.live_basic_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.extra_info is not None:
            result['extraInfo'] = self.extra_info.to_map()
        if self.live_basic_info is not None:
            result['liveBasicInfo'] = self.live_basic_info.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('extraInfo') is not None:
            temp_model = GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListExtraInfo()
            self.extra_info = temp_model.from_map(m['extraInfo'])
        if m.get('liveBasicInfo') is not None:
            temp_model = GetUserWatchLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo()
            self.live_basic_info = temp_model.from_map(m['liveBasicInfo'])
        return self


class GetUserWatchLiveListResponseBodyResult(TeaModel):
    def __init__(
        self,
        has_finish: bool = None,
        live_info_pop_model_list: List[GetUserWatchLiveListResponseBodyResultLiveInfoPopModelList] = None,
        next_token: str = None,
        total: int = None,
    ):
        # 是否拉取完成
        self.has_finish = has_finish
        # 直播详情
        self.live_info_pop_model_list = live_info_pop_model_list
        # 分页游标 分页时填到请求中
        self.next_token = next_token
        # 总数
        self.total = total

    def validate(self):
        if self.live_info_pop_model_list:
            for k in self.live_info_pop_model_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_finish is not None:
            result['hasFinish'] = self.has_finish
        result['liveInfoPopModelList'] = []
        if self.live_info_pop_model_list is not None:
            for k in self.live_info_pop_model_list:
                result['liveInfoPopModelList'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasFinish') is not None:
            self.has_finish = m.get('hasFinish')
        self.live_info_pop_model_list = []
        if m.get('liveInfoPopModelList') is not None:
            for k in m.get('liveInfoPopModelList'):
                temp_model = GetUserWatchLiveListResponseBodyResultLiveInfoPopModelList()
                self.live_info_pop_model_list.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class GetUserWatchLiveListResponseBody(TeaModel):
    def __init__(
        self,
        result: GetUserWatchLiveListResponseBodyResult = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = GetUserWatchLiveListResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetUserWatchLiveListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetUserWatchLiveListResponseBody = None,
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
            temp_model = GetUserWatchLiveListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ModifyFeedWhiteListHeaders(TeaModel):
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


class ModifyFeedWhiteListRequest(TeaModel):
    def __init__(
        self,
        action: int = None,
        modify_user_list: List[str] = None,
        user_id: str = None,
    ):
        # 操作类型（1 添加白名单 / 2 删除白名单）
        self.action = action
        # 操作的白名单列表
        self.modify_user_list = modify_user_list
        # 用户id（操作者的组织内id）
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action is not None:
            result['action'] = self.action
        if self.modify_user_list is not None:
            result['modifyUserList'] = self.modify_user_list
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('action') is not None:
            self.action = m.get('action')
        if m.get('modifyUserList') is not None:
            self.modify_user_list = m.get('modifyUserList')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class ModifyFeedWhiteListShrinkRequest(TeaModel):
    def __init__(
        self,
        action: int = None,
        modify_user_list_shrink: str = None,
        user_id: str = None,
    ):
        # 操作类型（1 添加白名单 / 2 删除白名单）
        self.action = action
        # 操作的白名单列表
        self.modify_user_list_shrink = modify_user_list_shrink
        # 用户id（操作者的组织内id）
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action is not None:
            result['action'] = self.action
        if self.modify_user_list_shrink is not None:
            result['modifyUserList'] = self.modify_user_list_shrink
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('action') is not None:
            self.action = m.get('action')
        if m.get('modifyUserList') is not None:
            self.modify_user_list_shrink = m.get('modifyUserList')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class ModifyFeedWhiteListResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        # 是否修改成功
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


class ModifyFeedWhiteListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ModifyFeedWhiteListResponseBody = None,
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
            temp_model = ModifyFeedWhiteListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryFeedWhiteListHeaders(TeaModel):
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


class QueryFeedWhiteListRequest(TeaModel):
    def __init__(
        self,
        user_id: str = None,
    ):
        # 用户组织内id（查询该用户是否在白名单列表中）
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryFeedWhiteListResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
    ):
        # 是否在白名单内
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


class QueryFeedWhiteListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryFeedWhiteListResponseBody = None,
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
            temp_model = QueryFeedWhiteListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryLiveInfoHeaders(TeaModel):
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


class QueryLiveInfoRequest(TeaModel):
    def __init__(
        self,
        live_id: str = None,
        union_id: str = None,
    ):
        self.live_id = live_id
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.live_id is not None:
            result['liveId'] = self.live_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('liveId') is not None:
            self.live_id = m.get('liveId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class QueryLiveInfoResponseBodyResultLiveInfo(TeaModel):
    def __init__(
        self,
        cover_url: str = None,
        duration: int = None,
        end_time: int = None,
        introduction: str = None,
        live_id: str = None,
        live_play_url: str = None,
        live_status: int = None,
        start_time: int = None,
        subscribe_count: int = None,
        title: str = None,
        union_id: str = None,
        uv: int = None,
    ):
        # 直播封面
        self.cover_url = cover_url
        # 直播时长
        self.duration = duration
        # 直播真实结束时间
        self.end_time = end_time
        # 直播简介
        self.introduction = introduction
        # 直播id
        self.live_id = live_id
        # 直播观看地址
        self.live_play_url = live_play_url
        # 直播状态
        self.live_status = live_status
        # 直播真实开始时间
        self.start_time = start_time
        # 预约人数
        self.subscribe_count = subscribe_count
        # 直播标题
        self.title = title
        # 主播id
        self.union_id = union_id
        # 观看人数
        self.uv = uv

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cover_url is not None:
            result['coverUrl'] = self.cover_url
        if self.duration is not None:
            result['duration'] = self.duration
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.introduction is not None:
            result['introduction'] = self.introduction
        if self.live_id is not None:
            result['liveId'] = self.live_id
        if self.live_play_url is not None:
            result['livePlayUrl'] = self.live_play_url
        if self.live_status is not None:
            result['liveStatus'] = self.live_status
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.subscribe_count is not None:
            result['subscribeCount'] = self.subscribe_count
        if self.title is not None:
            result['title'] = self.title
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.uv is not None:
            result['uv'] = self.uv
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('coverUrl') is not None:
            self.cover_url = m.get('coverUrl')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('introduction') is not None:
            self.introduction = m.get('introduction')
        if m.get('liveId') is not None:
            self.live_id = m.get('liveId')
        if m.get('livePlayUrl') is not None:
            self.live_play_url = m.get('livePlayUrl')
        if m.get('liveStatus') is not None:
            self.live_status = m.get('liveStatus')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('subscribeCount') is not None:
            self.subscribe_count = m.get('subscribeCount')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('uv') is not None:
            self.uv = m.get('uv')
        return self


class QueryLiveInfoResponseBodyResult(TeaModel):
    def __init__(
        self,
        live_info: QueryLiveInfoResponseBodyResultLiveInfo = None,
    ):
        self.live_info = live_info

    def validate(self):
        if self.live_info:
            self.live_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.live_info is not None:
            result['liveInfo'] = self.live_info.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('liveInfo') is not None:
            temp_model = QueryLiveInfoResponseBodyResultLiveInfo()
            self.live_info = temp_model.from_map(m['liveInfo'])
        return self


class QueryLiveInfoResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryLiveInfoResponseBodyResult = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = QueryLiveInfoResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class QueryLiveInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryLiveInfoResponseBody = None,
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
            temp_model = QueryLiveInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryLiveWatchDetailHeaders(TeaModel):
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


class QueryLiveWatchDetailRequest(TeaModel):
    def __init__(
        self,
        live_id: str = None,
        union_id: str = None,
    ):
        # 直播id
        self.live_id = live_id
        # 用户id
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.live_id is not None:
            result['liveId'] = self.live_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('liveId') is not None:
            self.live_id = m.get('liveId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class QueryLiveWatchDetailResponseBodyResult(TeaModel):
    def __init__(
        self,
        avg_watch_time: int = None,
        live_uv: int = None,
        msg_count: int = None,
        playback_uv: int = None,
        praise_count: int = None,
        pv: int = None,
        total_watch_time: int = None,
        uv: int = None,
    ):
        # 平均观看时长
        self.avg_watch_time = avg_watch_time
        # 观看直播人数
        self.live_uv = live_uv
        # 消息数
        self.msg_count = msg_count
        # 观看回放人数
        self.playback_uv = playback_uv
        # 点赞数
        self.praise_count = praise_count
        # 观看次数
        self.pv = pv
        # 观看总时长
        self.total_watch_time = total_watch_time
        # 观看人数
        self.uv = uv

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.avg_watch_time is not None:
            result['avgWatchTime'] = self.avg_watch_time
        if self.live_uv is not None:
            result['liveUv'] = self.live_uv
        if self.msg_count is not None:
            result['msgCount'] = self.msg_count
        if self.playback_uv is not None:
            result['playbackUv'] = self.playback_uv
        if self.praise_count is not None:
            result['praiseCount'] = self.praise_count
        if self.pv is not None:
            result['pv'] = self.pv
        if self.total_watch_time is not None:
            result['totalWatchTime'] = self.total_watch_time
        if self.uv is not None:
            result['uv'] = self.uv
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('avgWatchTime') is not None:
            self.avg_watch_time = m.get('avgWatchTime')
        if m.get('liveUv') is not None:
            self.live_uv = m.get('liveUv')
        if m.get('msgCount') is not None:
            self.msg_count = m.get('msgCount')
        if m.get('playbackUv') is not None:
            self.playback_uv = m.get('playbackUv')
        if m.get('praiseCount') is not None:
            self.praise_count = m.get('praiseCount')
        if m.get('pv') is not None:
            self.pv = m.get('pv')
        if m.get('totalWatchTime') is not None:
            self.total_watch_time = m.get('totalWatchTime')
        if m.get('uv') is not None:
            self.uv = m.get('uv')
        return self


class QueryLiveWatchDetailResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryLiveWatchDetailResponseBodyResult = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = QueryLiveWatchDetailResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class QueryLiveWatchDetailResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryLiveWatchDetailResponseBody = None,
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
            temp_model = QueryLiveWatchDetailResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryLiveWatchUserListHeaders(TeaModel):
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


class QueryLiveWatchUserListRequest(TeaModel):
    def __init__(
        self,
        live_id: str = None,
        page_number: int = None,
        page_size: int = None,
        union_id: str = None,
    ):
        # 直播id
        self.live_id = live_id
        # 分页起始位置
        self.page_number = page_number
        # 分页大小
        self.page_size = page_size
        # 用户id
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.live_id is not None:
            result['liveId'] = self.live_id
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('liveId') is not None:
            self.live_id = m.get('liveId')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class QueryLiveWatchUserListResponseBodyResultOrgUsesList(TeaModel):
    def __init__(
        self,
        dept_name: str = None,
        name: str = None,
        union_id: str = None,
        user_id: str = None,
        watch_live_time: int = None,
        watch_playback_time: int = None,
        watch_progress_ms: int = None,
    ):
        # 部门名称
        self.dept_name = dept_name
        # 姓名
        self.name = name
        # 用户id
        self.union_id = union_id
        # 员工id
        self.user_id = user_id
        # 观看直播时长
        self.watch_live_time = watch_live_time
        # 观看回放时长
        self.watch_playback_time = watch_playback_time
        # 回放观看进度
        self.watch_progress_ms = watch_progress_ms

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.name is not None:
            result['name'] = self.name
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.watch_live_time is not None:
            result['watchLiveTime'] = self.watch_live_time
        if self.watch_playback_time is not None:
            result['watchPlaybackTime'] = self.watch_playback_time
        if self.watch_progress_ms is not None:
            result['watchProgressMs'] = self.watch_progress_ms
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('watchLiveTime') is not None:
            self.watch_live_time = m.get('watchLiveTime')
        if m.get('watchPlaybackTime') is not None:
            self.watch_playback_time = m.get('watchPlaybackTime')
        if m.get('watchProgressMs') is not None:
            self.watch_progress_ms = m.get('watchProgressMs')
        return self


class QueryLiveWatchUserListResponseBodyResultOutOrgUserList(TeaModel):
    def __init__(
        self,
        name: str = None,
        watch_live_time: int = None,
        watch_playback_time: int = None,
        watch_progress_ms: int = None,
    ):
        # 姓名
        self.name = name
        # 观看直播时长
        self.watch_live_time = watch_live_time
        # 观看回放时长
        self.watch_playback_time = watch_playback_time
        # 回放观看进度
        self.watch_progress_ms = watch_progress_ms

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.watch_live_time is not None:
            result['watchLiveTime'] = self.watch_live_time
        if self.watch_playback_time is not None:
            result['watchPlaybackTime'] = self.watch_playback_time
        if self.watch_progress_ms is not None:
            result['watchProgressMs'] = self.watch_progress_ms
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('watchLiveTime') is not None:
            self.watch_live_time = m.get('watchLiveTime')
        if m.get('watchPlaybackTime') is not None:
            self.watch_playback_time = m.get('watchPlaybackTime')
        if m.get('watchProgressMs') is not None:
            self.watch_progress_ms = m.get('watchProgressMs')
        return self


class QueryLiveWatchUserListResponseBodyResult(TeaModel):
    def __init__(
        self,
        org_uses_list: List[QueryLiveWatchUserListResponseBodyResultOrgUsesList] = None,
        out_org_user_list: List[QueryLiveWatchUserListResponseBodyResultOutOrgUserList] = None,
    ):
        # 组织内的观看用户列表
        self.org_uses_list = org_uses_list
        # 组织外的观看用户列表
        self.out_org_user_list = out_org_user_list

    def validate(self):
        if self.org_uses_list:
            for k in self.org_uses_list:
                if k:
                    k.validate()
        if self.out_org_user_list:
            for k in self.out_org_user_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['orgUsesList'] = []
        if self.org_uses_list is not None:
            for k in self.org_uses_list:
                result['orgUsesList'].append(k.to_map() if k else None)
        result['outOrgUserList'] = []
        if self.out_org_user_list is not None:
            for k in self.out_org_user_list:
                result['outOrgUserList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.org_uses_list = []
        if m.get('orgUsesList') is not None:
            for k in m.get('orgUsesList'):
                temp_model = QueryLiveWatchUserListResponseBodyResultOrgUsesList()
                self.org_uses_list.append(temp_model.from_map(k))
        self.out_org_user_list = []
        if m.get('outOrgUserList') is not None:
            for k in m.get('outOrgUserList'):
                temp_model = QueryLiveWatchUserListResponseBodyResultOutOrgUserList()
                self.out_org_user_list.append(temp_model.from_map(k))
        return self


class QueryLiveWatchUserListResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryLiveWatchUserListResponseBodyResult = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = QueryLiveWatchUserListResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class QueryLiveWatchUserListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryLiveWatchUserListResponseBody = None,
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
            temp_model = QueryLiveWatchUserListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QuerySubscribeStatusHeaders(TeaModel):
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


class QuerySubscribeStatusRequestBody(TeaModel):
    def __init__(
        self,
        live_ids: List[str] = None,
    ):
        # 直播id列表
        self.live_ids = live_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.live_ids is not None:
            result['liveIds'] = self.live_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('liveIds') is not None:
            self.live_ids = m.get('liveIds')
        return self


class QuerySubscribeStatusRequest(TeaModel):
    def __init__(
        self,
        body: QuerySubscribeStatusRequestBody = None,
        union_id: str = None,
    ):
        # post请求体, 开放平台建议以对象形式存储
        self.body = body
        # 用户id（主播id）
        self.union_id = union_id

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.body is not None:
            result['body'] = self.body.to_map()
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('body') is not None:
            temp_model = QuerySubscribeStatusRequestBody()
            self.body = temp_model.from_map(m['body'])
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class QuerySubscribeStatusShrinkRequest(TeaModel):
    def __init__(
        self,
        body_shrink: str = None,
        union_id: str = None,
    ):
        # post请求体, 开放平台建议以对象形式存储
        self.body_shrink = body_shrink
        # 用户id（主播id）
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.body_shrink is not None:
            result['body'] = self.body_shrink
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('body') is not None:
            self.body_shrink = m.get('body')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class QuerySubscribeStatusResponseBodyResultSubscribeStatusDTOS(TeaModel):
    def __init__(
        self,
        live_id: str = None,
        subscribe: bool = None,
    ):
        # 直播uuid
        self.live_id = live_id
        # 是否订阅 true:订阅 false:非订阅
        self.subscribe = subscribe

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.live_id is not None:
            result['liveId'] = self.live_id
        if self.subscribe is not None:
            result['subscribe'] = self.subscribe
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('liveId') is not None:
            self.live_id = m.get('liveId')
        if m.get('subscribe') is not None:
            self.subscribe = m.get('subscribe')
        return self


class QuerySubscribeStatusResponseBodyResult(TeaModel):
    def __init__(
        self,
        subscribe_status_dtos: List[QuerySubscribeStatusResponseBodyResultSubscribeStatusDTOS] = None,
    ):
        # 订阅详情列表
        self.subscribe_status_dtos = subscribe_status_dtos

    def validate(self):
        if self.subscribe_status_dtos:
            for k in self.subscribe_status_dtos:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['subscribeStatusDTOS'] = []
        if self.subscribe_status_dtos is not None:
            for k in self.subscribe_status_dtos:
                result['subscribeStatusDTOS'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.subscribe_status_dtos = []
        if m.get('subscribeStatusDTOS') is not None:
            for k in m.get('subscribeStatusDTOS'):
                temp_model = QuerySubscribeStatusResponseBodyResultSubscribeStatusDTOS()
                self.subscribe_status_dtos.append(temp_model.from_map(k))
        return self


class QuerySubscribeStatusResponseBody(TeaModel):
    def __init__(
        self,
        result: QuerySubscribeStatusResponseBodyResult = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = QuerySubscribeStatusResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class QuerySubscribeStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QuerySubscribeStatusResponseBody = None,
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
            temp_model = QuerySubscribeStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


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
        _map = super().to_map()
        if _map is not None:
            return _map

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
        _map = super().to_map()
        if _map is not None:
            return _map

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
            temp_model = StopCloudFeedResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SubscribeLiveHeaders(TeaModel):
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


class SubscribeLiveRequest(TeaModel):
    def __init__(
        self,
        live_id: str = None,
        subscribe: bool = None,
        union_id: str = None,
    ):
        # 直播uuid
        self.live_id = live_id
        # true:关注 false:取消关注
        self.subscribe = subscribe
        # 用户id
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.live_id is not None:
            result['liveId'] = self.live_id
        if self.subscribe is not None:
            result['subscribe'] = self.subscribe
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('liveId') is not None:
            self.live_id = m.get('liveId')
        if m.get('subscribe') is not None:
            self.subscribe = m.get('subscribe')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class SubscribeLiveResponseBodyResult(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class SubscribeLiveResponseBody(TeaModel):
    def __init__(
        self,
        result: SubscribeLiveResponseBodyResult = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = SubscribeLiveResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class SubscribeLiveResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SubscribeLiveResponseBody = None,
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
            temp_model = SubscribeLiveResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateLiveHeaders(TeaModel):
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


class UpdateLiveRequest(TeaModel):
    def __init__(
        self,
        cover_url: str = None,
        introduction: str = None,
        live_id: str = None,
        pre_end_time: int = None,
        pre_start_time: int = None,
        title: str = None,
        union_id: str = None,
    ):
        # 直播封面
        self.cover_url = cover_url
        # 简介
        self.introduction = introduction
        # 直播id
        self.live_id = live_id
        # 预计结束时间
        self.pre_end_time = pre_end_time
        # 预计开播时间
        self.pre_start_time = pre_start_time
        # 标题
        self.title = title
        # 用户id（主播id）
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cover_url is not None:
            result['coverUrl'] = self.cover_url
        if self.introduction is not None:
            result['introduction'] = self.introduction
        if self.live_id is not None:
            result['liveId'] = self.live_id
        if self.pre_end_time is not None:
            result['preEndTime'] = self.pre_end_time
        if self.pre_start_time is not None:
            result['preStartTime'] = self.pre_start_time
        if self.title is not None:
            result['title'] = self.title
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('coverUrl') is not None:
            self.cover_url = m.get('coverUrl')
        if m.get('introduction') is not None:
            self.introduction = m.get('introduction')
        if m.get('liveId') is not None:
            self.live_id = m.get('liveId')
        if m.get('preEndTime') is not None:
            self.pre_end_time = m.get('preEndTime')
        if m.get('preStartTime') is not None:
            self.pre_start_time = m.get('preStartTime')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class UpdateLiveResponseBodyResult(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class UpdateLiveResponseBody(TeaModel):
    def __init__(
        self,
        result: UpdateLiveResponseBodyResult = None,
    ):
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = UpdateLiveResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class UpdateLiveResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateLiveResponseBody = None,
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
            temp_model = UpdateLiveResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateLiveFeedHeaders(TeaModel):
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


class UpdateLiveFeedRequest(TeaModel):
    def __init__(
        self,
        cover_url: str = None,
        introduction: str = None,
        start_time: int = None,
        title: str = None,
        user_id: str = None,
    ):
        # 封面图url
        self.cover_url = cover_url
        # 课程简介
        self.introduction = introduction
        # 预计开始时间（毫秒值）（课程必须预告状态才可以修改该项）
        self.start_time = start_time
        # 课程标题
        self.title = title
        # 操作者id（修改者的组织内id）
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cover_url is not None:
            result['coverUrl'] = self.cover_url
        if self.introduction is not None:
            result['introduction'] = self.introduction
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.title is not None:
            result['title'] = self.title
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('coverUrl') is not None:
            self.cover_url = m.get('coverUrl')
        if m.get('introduction') is not None:
            self.introduction = m.get('introduction')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class UpdateLiveFeedResponseBody(TeaModel):
    def __init__(
        self,
        has_update: bool = None,
    ):
        # 是否修改成功
        self.has_update = has_update

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_update is not None:
            result['hasUpdate'] = self.has_update
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasUpdate') is not None:
            self.has_update = m.get('hasUpdate')
        return self


class UpdateLiveFeedResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateLiveFeedResponseBody = None,
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
            temp_model = UpdateLiveFeedResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


