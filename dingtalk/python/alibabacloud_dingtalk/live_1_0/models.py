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
        # This parameter is required.
        self.group_id_type = group_id_type
        # This parameter is required.
        self.group_ids = group_ids
        # This parameter is required.
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
        self.has_share_success = has_share_success
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
        status_code: int = None,
        body: AddShareCidListResponseBody = None,
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
        self.cover_url = cover_url
        self.intro = intro
        # This parameter is required.
        self.start_time = start_time
        # This parameter is required.
        self.title = title
        # This parameter is required.
        self.user_id = user_id
        # This parameter is required.
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
        status_code: int = None,
        body: CreateCloudFeedResponseBody = None,
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
        public_type: int = None,
        title: str = None,
        union_id: str = None,
    ):
        self.cover_url = cover_url
        self.introduction = introduction
        # This parameter is required.
        self.pre_end_time = pre_end_time
        # This parameter is required.
        self.pre_start_time = pre_start_time
        self.public_type = public_type
        # This parameter is required.
        self.title = title
        # This parameter is required.
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
        if self.public_type is not None:
            result['publicType'] = self.public_type
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
        if m.get('publicType') is not None:
            self.public_type = m.get('publicType')
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
        status_code: int = None,
        body: CreateLiveResponseBody = None,
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
        # This parameter is required.
        self.live_id = live_id
        # This parameter is required.
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
        status_code: int = None,
        body: DeleteLiveResponseBody = None,
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
        # This parameter is required.
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
        status_code: int = None,
        body: DeleteLiveFeedResponseBody = None,
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
        # This parameter is required.
        self.edit_end_time = edit_end_time
        # This parameter is required.
        self.edit_start_time = edit_start_time
        # This parameter is required.
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
        status_code: int = None,
        body: EditFeedReplayResponseBody = None,
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
            temp_model = EditFeedReplayResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetGroupLiveListHeaders(TeaModel):
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


class GetGroupLiveListRequestRequestBody(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        open_conversation_id: str = None,
        start_time: int = None,
    ):
        self.end_time = end_time
        self.open_conversation_id = open_conversation_id
        self.start_time = start_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.start_time is not None:
            result['startTime'] = self.start_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        return self


class GetGroupLiveListRequest(TeaModel):
    def __init__(
        self,
        request_body: GetGroupLiveListRequestRequestBody = None,
        union_id: str = None,
    ):
        self.request_body = request_body
        self.union_id = union_id

    def validate(self):
        if self.request_body:
            self.request_body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_body is not None:
            result['requestBody'] = self.request_body.to_map()
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestBody') is not None:
            temp_model = GetGroupLiveListRequestRequestBody()
            self.request_body = temp_model.from_map(m['requestBody'])
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetGroupLiveListShrinkRequest(TeaModel):
    def __init__(
        self,
        request_body_shrink: str = None,
        union_id: str = None,
    ):
        self.request_body_shrink = request_body_shrink
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_body_shrink is not None:
            result['requestBody'] = self.request_body_shrink
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestBody') is not None:
            self.request_body_shrink = m.get('requestBody')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetGroupLiveListResponseBodyResultGroupLiveList(TeaModel):
    def __init__(
        self,
        anchor_nickname: str = None,
        anchor_union_id: str = None,
        live_end_time: int = None,
        live_start_time: int = None,
        live_uuid: str = None,
        title: str = None,
    ):
        self.anchor_nickname = anchor_nickname
        self.anchor_union_id = anchor_union_id
        self.live_end_time = live_end_time
        self.live_start_time = live_start_time
        self.live_uuid = live_uuid
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.anchor_nickname is not None:
            result['anchorNickname'] = self.anchor_nickname
        if self.anchor_union_id is not None:
            result['anchorUnionId'] = self.anchor_union_id
        if self.live_end_time is not None:
            result['liveEndTime'] = self.live_end_time
        if self.live_start_time is not None:
            result['liveStartTime'] = self.live_start_time
        if self.live_uuid is not None:
            result['liveUuid'] = self.live_uuid
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('anchorNickname') is not None:
            self.anchor_nickname = m.get('anchorNickname')
        if m.get('anchorUnionId') is not None:
            self.anchor_union_id = m.get('anchorUnionId')
        if m.get('liveEndTime') is not None:
            self.live_end_time = m.get('liveEndTime')
        if m.get('liveStartTime') is not None:
            self.live_start_time = m.get('liveStartTime')
        if m.get('liveUuid') is not None:
            self.live_uuid = m.get('liveUuid')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class GetGroupLiveListResponseBodyResult(TeaModel):
    def __init__(
        self,
        group_live_list: List[GetGroupLiveListResponseBodyResultGroupLiveList] = None,
    ):
        self.group_live_list = group_live_list

    def validate(self):
        if self.group_live_list:
            for k in self.group_live_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['groupLiveList'] = []
        if self.group_live_list is not None:
            for k in self.group_live_list:
                result['groupLiveList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.group_live_list = []
        if m.get('groupLiveList') is not None:
            for k in m.get('groupLiveList'):
                temp_model = GetGroupLiveListResponseBodyResultGroupLiveList()
                self.group_live_list.append(temp_model.from_map(k))
        return self


class GetGroupLiveListResponseBody(TeaModel):
    def __init__(
        self,
        result: GetGroupLiveListResponseBodyResult = None,
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
            temp_model = GetGroupLiveListResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetGroupLiveListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetGroupLiveListResponseBody = None,
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
            temp_model = GetGroupLiveListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetLiveReplayUrlHeaders(TeaModel):
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


class GetLiveReplayUrlRequest(TeaModel):
    def __init__(
        self,
        live_id: str = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.live_id = live_id
        # This parameter is required.
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


class GetLiveReplayUrlResponseBodyResult(TeaModel):
    def __init__(
        self,
        replay_url: str = None,
    ):
        self.replay_url = replay_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.replay_url is not None:
            result['replayUrl'] = self.replay_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('replayUrl') is not None:
            self.replay_url = m.get('replayUrl')
        return self


class GetLiveReplayUrlResponseBody(TeaModel):
    def __init__(
        self,
        result: GetLiveReplayUrlResponseBodyResult = None,
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
            temp_model = GetLiveReplayUrlResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetLiveReplayUrlResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetLiveReplayUrlResponseBody = None,
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
            temp_model = GetLiveReplayUrlResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetOrgLiveListHeaders(TeaModel):
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


class GetOrgLiveListRequestRequestBody(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        page_number: int = None,
        page_size: int = None,
        start_time: int = None,
        union_id: str = None,
    ):
        self.end_time = end_time
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
        self.page_size = page_size
        self.start_time = start_time
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
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetOrgLiveListRequest(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        request_body: GetOrgLiveListRequestRequestBody = None,
    ):
        # This parameter is required.
        self.corp_id = corp_id
        self.request_body = request_body

    def validate(self):
        if self.request_body:
            self.request_body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.request_body is not None:
            result['requestBody'] = self.request_body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('requestBody') is not None:
            temp_model = GetOrgLiveListRequestRequestBody()
            self.request_body = temp_model.from_map(m['requestBody'])
        return self


class GetOrgLiveListShrinkRequest(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        request_body_shrink: str = None,
    ):
        # This parameter is required.
        self.corp_id = corp_id
        self.request_body_shrink = request_body_shrink

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.request_body_shrink is not None:
            result['requestBody'] = self.request_body_shrink
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('requestBody') is not None:
            self.request_body_shrink = m.get('requestBody')
        return self


class GetOrgLiveListResponseBodyResultNewLiveLiveList(TeaModel):
    def __init__(
        self,
        anchor_nickname: str = None,
        anchor_union_id: str = None,
        live_end_time: int = None,
        live_start_time: int = None,
        live_uuid: str = None,
        share_open_conversation_ids: List[str] = None,
        title: str = None,
    ):
        self.anchor_nickname = anchor_nickname
        self.anchor_union_id = anchor_union_id
        self.live_end_time = live_end_time
        self.live_start_time = live_start_time
        self.live_uuid = live_uuid
        self.share_open_conversation_ids = share_open_conversation_ids
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.anchor_nickname is not None:
            result['anchorNickname'] = self.anchor_nickname
        if self.anchor_union_id is not None:
            result['anchorUnionId'] = self.anchor_union_id
        if self.live_end_time is not None:
            result['liveEndTime'] = self.live_end_time
        if self.live_start_time is not None:
            result['liveStartTime'] = self.live_start_time
        if self.live_uuid is not None:
            result['liveUuid'] = self.live_uuid
        if self.share_open_conversation_ids is not None:
            result['shareOpenConversationIds'] = self.share_open_conversation_ids
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('anchorNickname') is not None:
            self.anchor_nickname = m.get('anchorNickname')
        if m.get('anchorUnionId') is not None:
            self.anchor_union_id = m.get('anchorUnionId')
        if m.get('liveEndTime') is not None:
            self.live_end_time = m.get('liveEndTime')
        if m.get('liveStartTime') is not None:
            self.live_start_time = m.get('liveStartTime')
        if m.get('liveUuid') is not None:
            self.live_uuid = m.get('liveUuid')
        if m.get('shareOpenConversationIds') is not None:
            self.share_open_conversation_ids = m.get('shareOpenConversationIds')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class GetOrgLiveListResponseBodyResultNewLive(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        live_list: List[GetOrgLiveListResponseBodyResultNewLiveLiveList] = None,
        page_number: int = None,
        page_size: int = None,
        total_count: int = None,
    ):
        self.has_more = has_more
        self.live_list = live_list
        self.page_number = page_number
        self.page_size = page_size
        self.total_count = total_count

    def validate(self):
        if self.live_list:
            for k in self.live_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['liveList'] = []
        if self.live_list is not None:
            for k in self.live_list:
                result['liveList'].append(k.to_map() if k else None)
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.live_list = []
        if m.get('liveList') is not None:
            for k in m.get('liveList'):
                temp_model = GetOrgLiveListResponseBodyResultNewLiveLiveList()
                self.live_list.append(temp_model.from_map(k))
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class GetOrgLiveListResponseBodyResultUpdateLiveLiveList(TeaModel):
    def __init__(
        self,
        anchor_nickname: str = None,
        anchor_union_id: str = None,
        live_end_time: int = None,
        live_start_time: int = None,
        live_uuid: str = None,
        title: str = None,
    ):
        self.anchor_nickname = anchor_nickname
        self.anchor_union_id = anchor_union_id
        self.live_end_time = live_end_time
        self.live_start_time = live_start_time
        self.live_uuid = live_uuid
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.anchor_nickname is not None:
            result['anchorNickname'] = self.anchor_nickname
        if self.anchor_union_id is not None:
            result['anchorUnionId'] = self.anchor_union_id
        if self.live_end_time is not None:
            result['liveEndTime'] = self.live_end_time
        if self.live_start_time is not None:
            result['liveStartTime'] = self.live_start_time
        if self.live_uuid is not None:
            result['liveUuid'] = self.live_uuid
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('anchorNickname') is not None:
            self.anchor_nickname = m.get('anchorNickname')
        if m.get('anchorUnionId') is not None:
            self.anchor_union_id = m.get('anchorUnionId')
        if m.get('liveEndTime') is not None:
            self.live_end_time = m.get('liveEndTime')
        if m.get('liveStartTime') is not None:
            self.live_start_time = m.get('liveStartTime')
        if m.get('liveUuid') is not None:
            self.live_uuid = m.get('liveUuid')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class GetOrgLiveListResponseBodyResultUpdateLive(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        live_list: List[GetOrgLiveListResponseBodyResultUpdateLiveLiveList] = None,
        page_number: int = None,
        page_size: int = None,
        total_count: int = None,
    ):
        self.has_more = has_more
        self.live_list = live_list
        self.page_number = page_number
        self.page_size = page_size
        self.total_count = total_count

    def validate(self):
        if self.live_list:
            for k in self.live_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['liveList'] = []
        if self.live_list is not None:
            for k in self.live_list:
                result['liveList'].append(k.to_map() if k else None)
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.live_list = []
        if m.get('liveList') is not None:
            for k in m.get('liveList'):
                temp_model = GetOrgLiveListResponseBodyResultUpdateLiveLiveList()
                self.live_list.append(temp_model.from_map(k))
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class GetOrgLiveListResponseBodyResult(TeaModel):
    def __init__(
        self,
        new_live: GetOrgLiveListResponseBodyResultNewLive = None,
        update_live: GetOrgLiveListResponseBodyResultUpdateLive = None,
    ):
        self.new_live = new_live
        self.update_live = update_live

    def validate(self):
        if self.new_live:
            self.new_live.validate()
        if self.update_live:
            self.update_live.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.new_live is not None:
            result['newLive'] = self.new_live.to_map()
        if self.update_live is not None:
            result['updateLive'] = self.update_live.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('newLive') is not None:
            temp_model = GetOrgLiveListResponseBodyResultNewLive()
            self.new_live = temp_model.from_map(m['newLive'])
        if m.get('updateLive') is not None:
            temp_model = GetOrgLiveListResponseBodyResultUpdateLive()
            self.update_live = temp_model.from_map(m['updateLive'])
        return self


class GetOrgLiveListResponseBody(TeaModel):
    def __init__(
        self,
        result: GetOrgLiveListResponseBodyResult = None,
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
            temp_model = GetOrgLiveListResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetOrgLiveListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetOrgLiveListResponseBody = None,
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
            temp_model = GetOrgLiveListResponseBody()
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
        self.end_time = end_time
        self.start_time = start_time
        self.statuses = statuses
        self.title = title
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
        self.page_size = page_size
        # This parameter is required.
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
        self.has_subscribed = has_subscribed
        self.is_forecast_expired = is_forecast_expired
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
        self.cover_url = cover_url
        self.duration = duration
        self.end_time = end_time
        self.introduction = introduction
        self.live_id = live_id
        self.live_play_url = live_play_url
        self.live_status = live_status
        self.start_time = start_time
        self.subscribe_count = subscribe_count
        self.title = title
        self.union_id = union_id
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
        self.extra_info = extra_info
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
        self.has_finish = has_finish
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
        status_code: int = None,
        body: GetUserAllLiveListResponseBody = None,
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
        self.end_time = end_time
        self.start_time = start_time
        self.statuses = statuses
        self.title = title
        # This parameter is required.
        self.max_results = max_results
        self.next_token = next_token
        # This parameter is required.
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
        self.has_subscribed = has_subscribed
        self.is_forecast_expired = is_forecast_expired
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
        self.cover_url = cover_url
        self.duration = duration
        self.end_time = end_time
        self.introduction = introduction
        self.live_id = live_id
        self.live_play_url = live_play_url
        self.live_status = live_status
        self.start_time = start_time
        self.subscribe_count = subscribe_count
        self.title = title
        self.union_id = union_id
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
        self.has_subscribed = has_subscribed
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
        self.has_finish = has_finish
        self.live_info_pop_model_list = live_info_pop_model_list
        self.next_token = next_token
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
        status_code: int = None,
        body: GetUserCreateLiveListResponseBody = None,
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
        # This parameter is required.
        self.filter_type = filter_type
        # This parameter is required.
        self.max_results = max_results
        self.next_token = next_token
        # This parameter is required.
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
        self.has_subscribed = has_subscribed
        self.is_forecast_expired = is_forecast_expired
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
        self.cover_url = cover_url
        self.duration = duration
        self.end_time = end_time
        self.introduction = introduction
        self.live_id = live_id
        self.live_play_url = live_play_url
        self.live_status = live_status
        self.start_time = start_time
        self.subscribe_count = subscribe_count
        self.title = title
        self.union_id = union_id
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
        self.extra_info = extra_info
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
        self.has_finish = has_finish
        self.live_info_pop_model_list = live_info_pop_model_list
        self.next_token = next_token
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
        status_code: int = None,
        body: GetUserWatchLiveListResponseBody = None,
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
        # This parameter is required.
        self.action = action
        self.modify_user_list = modify_user_list
        # This parameter is required.
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
        # This parameter is required.
        self.action = action
        self.modify_user_list_shrink = modify_user_list_shrink
        # This parameter is required.
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
        status_code: int = None,
        body: ModifyFeedWhiteListResponseBody = None,
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
        # This parameter is required.
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
        status_code: int = None,
        body: QueryFeedWhiteListResponseBody = None,
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
        # This parameter is required.
        self.live_id = live_id
        # This parameter is required.
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
        playback_duration: int = None,
        start_time: int = None,
        subscribe_count: int = None,
        title: str = None,
        union_id: str = None,
        uv: int = None,
    ):
        self.cover_url = cover_url
        self.duration = duration
        self.end_time = end_time
        self.introduction = introduction
        self.live_id = live_id
        self.live_play_url = live_play_url
        self.live_status = live_status
        self.playback_duration = playback_duration
        self.start_time = start_time
        self.subscribe_count = subscribe_count
        self.title = title
        self.union_id = union_id
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
        if self.playback_duration is not None:
            result['playbackDuration'] = self.playback_duration
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
        if m.get('playbackDuration') is not None:
            self.playback_duration = m.get('playbackDuration')
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
        status_code: int = None,
        body: QueryLiveInfoResponseBody = None,
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
        # This parameter is required.
        self.live_id = live_id
        # This parameter is required.
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
        self.avg_watch_time = avg_watch_time
        self.live_uv = live_uv
        self.msg_count = msg_count
        self.playback_uv = playback_uv
        self.praise_count = praise_count
        self.pv = pv
        self.total_watch_time = total_watch_time
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
        status_code: int = None,
        body: QueryLiveWatchDetailResponseBody = None,
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
        # This parameter is required.
        self.live_id = live_id
        self.page_number = page_number
        # This parameter is required.
        self.page_size = page_size
        # This parameter is required.
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
        self.dept_name = dept_name
        self.name = name
        self.union_id = union_id
        self.user_id = user_id
        self.watch_live_time = watch_live_time
        self.watch_playback_time = watch_playback_time
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
        self.name = name
        self.watch_live_time = watch_live_time
        self.watch_playback_time = watch_playback_time
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
        self.org_uses_list = org_uses_list
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
        status_code: int = None,
        body: QueryLiveWatchUserListResponseBody = None,
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
        self.body = body
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
        self.body_shrink = body_shrink
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
        self.live_id = live_id
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
        status_code: int = None,
        body: QuerySubscribeStatusResponseBody = None,
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
        # This parameter is required.
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
        status_code: int = None,
        body: StartCloudFeedResponseBody = None,
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
        # This parameter is required.
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
        status_code: int = None,
        body: StopCloudFeedResponseBody = None,
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
        # This parameter is required.
        self.live_id = live_id
        # This parameter is required.
        self.subscribe = subscribe
        # This parameter is required.
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
        status_code: int = None,
        body: SubscribeLiveResponseBody = None,
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
        self.cover_url = cover_url
        self.introduction = introduction
        # This parameter is required.
        self.live_id = live_id
        self.pre_end_time = pre_end_time
        self.pre_start_time = pre_start_time
        self.title = title
        # This parameter is required.
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
        status_code: int = None,
        body: UpdateLiveResponseBody = None,
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
        self.cover_url = cover_url
        self.introduction = introduction
        self.start_time = start_time
        self.title = title
        # This parameter is required.
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
        status_code: int = None,
        body: UpdateLiveFeedResponseBody = None,
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
            temp_model = UpdateLiveFeedResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


