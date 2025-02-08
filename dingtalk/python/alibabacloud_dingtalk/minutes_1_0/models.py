# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class BatchGetMinutesDetailsHeaders(TeaModel):
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


class BatchGetMinutesDetailsRequest(TeaModel):
    def __init__(
        self,
        task_uuids: List[str] = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.task_uuids = task_uuids
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.task_uuids is not None:
            result['taskUuids'] = self.task_uuids
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('taskUuids') is not None:
            self.task_uuids = m.get('taskUuids')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class BatchGetMinutesDetailsResponseBodyMinutesDetails(TeaModel):
    def __init__(
        self,
        biz_type: int = None,
        creator_nick: str = None,
        creator_union_id: str = None,
        duration_micros: int = None,
        is_deleted: int = None,
        size: int = None,
        start_time: int = None,
        status: int = None,
        task_uuid: str = None,
        title: str = None,
    ):
        self.biz_type = biz_type
        self.creator_nick = creator_nick
        self.creator_union_id = creator_union_id
        self.duration_micros = duration_micros
        self.is_deleted = is_deleted
        self.size = size
        self.start_time = start_time
        self.status = status
        self.task_uuid = task_uuid
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.creator_nick is not None:
            result['creatorNick'] = self.creator_nick
        if self.creator_union_id is not None:
            result['creatorUnionId'] = self.creator_union_id
        if self.duration_micros is not None:
            result['durationMicros'] = self.duration_micros
        if self.is_deleted is not None:
            result['isDeleted'] = self.is_deleted
        if self.size is not None:
            result['size'] = self.size
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.status is not None:
            result['status'] = self.status
        if self.task_uuid is not None:
            result['taskUuid'] = self.task_uuid
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('creatorNick') is not None:
            self.creator_nick = m.get('creatorNick')
        if m.get('creatorUnionId') is not None:
            self.creator_union_id = m.get('creatorUnionId')
        if m.get('durationMicros') is not None:
            self.duration_micros = m.get('durationMicros')
        if m.get('isDeleted') is not None:
            self.is_deleted = m.get('isDeleted')
        if m.get('size') is not None:
            self.size = m.get('size')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('taskUuid') is not None:
            self.task_uuid = m.get('taskUuid')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class BatchGetMinutesDetailsResponseBody(TeaModel):
    def __init__(
        self,
        minutes_details: List[BatchGetMinutesDetailsResponseBodyMinutesDetails] = None,
    ):
        self.minutes_details = minutes_details

    def validate(self):
        if self.minutes_details:
            for k in self.minutes_details:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['minutesDetails'] = []
        if self.minutes_details is not None:
            for k in self.minutes_details:
                result['minutesDetails'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.minutes_details = []
        if m.get('minutesDetails') is not None:
            for k in m.get('minutesDetails'):
                temp_model = BatchGetMinutesDetailsResponseBodyMinutesDetails()
                self.minutes_details.append(temp_model.from_map(k))
        return self


class BatchGetMinutesDetailsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BatchGetMinutesDetailsResponseBody = None,
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
            temp_model = BatchGetMinutesDetailsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteMinutesHeaders(TeaModel):
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


class DeleteMinutesRequest(TeaModel):
    def __init__(
        self,
        union_id: str = None,
    ):
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class DeleteMinutesResponseBody(TeaModel):
    def __init__(
        self,
        task_uuid: str = None,
    ):
        self.task_uuid = task_uuid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.task_uuid is not None:
            result['taskUuid'] = self.task_uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('taskUuid') is not None:
            self.task_uuid = m.get('taskUuid')
        return self


class DeleteMinutesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteMinutesResponseBody = None,
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
            temp_model = DeleteMinutesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryMinutesPlayInfoHeaders(TeaModel):
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


class QueryMinutesPlayInfoRequest(TeaModel):
    def __init__(
        self,
        union_id: str = None,
    ):
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class QueryMinutesPlayInfoResponseBodyPlayInfo(TeaModel):
    def __init__(
        self,
        download_url: str = None,
        duration: str = None,
        media_type: str = None,
        play_url: str = None,
        size: str = None,
        status: str = None,
    ):
        self.download_url = download_url
        self.duration = duration
        self.media_type = media_type
        self.play_url = play_url
        self.size = size
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.download_url is not None:
            result['downloadUrl'] = self.download_url
        if self.duration is not None:
            result['duration'] = self.duration
        if self.media_type is not None:
            result['mediaType'] = self.media_type
        if self.play_url is not None:
            result['playUrl'] = self.play_url
        if self.size is not None:
            result['size'] = self.size
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('downloadUrl') is not None:
            self.download_url = m.get('downloadUrl')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('mediaType') is not None:
            self.media_type = m.get('mediaType')
        if m.get('playUrl') is not None:
            self.play_url = m.get('playUrl')
        if m.get('size') is not None:
            self.size = m.get('size')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class QueryMinutesPlayInfoResponseBody(TeaModel):
    def __init__(
        self,
        play_info: QueryMinutesPlayInfoResponseBodyPlayInfo = None,
    ):
        self.play_info = play_info

    def validate(self):
        if self.play_info:
            self.play_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.play_info is not None:
            result['playInfo'] = self.play_info.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('playInfo') is not None:
            temp_model = QueryMinutesPlayInfoResponseBodyPlayInfo()
            self.play_info = temp_model.from_map(m['playInfo'])
        return self


class QueryMinutesPlayInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryMinutesPlayInfoResponseBody = None,
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
            temp_model = QueryMinutesPlayInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryMinutesShareListHeaders(TeaModel):
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


class QueryMinutesShareListRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        scene: str = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.max_results = max_results
        self.next_token = next_token
        self.scene = scene
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.scene is not None:
            result['scene'] = self.scene
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('scene') is not None:
            self.scene = m.get('scene')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class QueryMinutesShareListResponseBodyMinutesDetails(TeaModel):
    def __init__(
        self,
        biz_type: int = None,
        creator_nick: str = None,
        creator_union_id: str = None,
        duration_micros: int = None,
        is_deleted: int = None,
        size: int = None,
        start_time: int = None,
        status: int = None,
        task_uuid: str = None,
        title: str = None,
    ):
        self.biz_type = biz_type
        self.creator_nick = creator_nick
        self.creator_union_id = creator_union_id
        self.duration_micros = duration_micros
        self.is_deleted = is_deleted
        self.size = size
        self.start_time = start_time
        self.status = status
        self.task_uuid = task_uuid
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.creator_nick is not None:
            result['creatorNick'] = self.creator_nick
        if self.creator_union_id is not None:
            result['creatorUnionId'] = self.creator_union_id
        if self.duration_micros is not None:
            result['durationMicros'] = self.duration_micros
        if self.is_deleted is not None:
            result['isDeleted'] = self.is_deleted
        if self.size is not None:
            result['size'] = self.size
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.status is not None:
            result['status'] = self.status
        if self.task_uuid is not None:
            result['taskUuid'] = self.task_uuid
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('creatorNick') is not None:
            self.creator_nick = m.get('creatorNick')
        if m.get('creatorUnionId') is not None:
            self.creator_union_id = m.get('creatorUnionId')
        if m.get('durationMicros') is not None:
            self.duration_micros = m.get('durationMicros')
        if m.get('isDeleted') is not None:
            self.is_deleted = m.get('isDeleted')
        if m.get('size') is not None:
            self.size = m.get('size')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('taskUuid') is not None:
            self.task_uuid = m.get('taskUuid')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class QueryMinutesShareListResponseBody(TeaModel):
    def __init__(
        self,
        has_next: bool = None,
        minutes_details: List[QueryMinutesShareListResponseBodyMinutesDetails] = None,
        next_token: str = None,
    ):
        self.has_next = has_next
        self.minutes_details = minutes_details
        self.next_token = next_token

    def validate(self):
        if self.minutes_details:
            for k in self.minutes_details:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_next is not None:
            result['hasNext'] = self.has_next
        result['minutesDetails'] = []
        if self.minutes_details is not None:
            for k in self.minutes_details:
                result['minutesDetails'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasNext') is not None:
            self.has_next = m.get('hasNext')
        self.minutes_details = []
        if m.get('minutesDetails') is not None:
            for k in m.get('minutesDetails'):
                temp_model = QueryMinutesShareListResponseBodyMinutesDetails()
                self.minutes_details.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class QueryMinutesShareListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryMinutesShareListResponseBody = None,
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
            temp_model = QueryMinutesShareListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryMinutesStatusHeaders(TeaModel):
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


class QueryMinutesStatusRequest(TeaModel):
    def __init__(
        self,
        union_id: str = None,
    ):
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class QueryMinutesStatusResponseBody(TeaModel):
    def __init__(
        self,
        status: int = None,
    ):
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class QueryMinutesStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryMinutesStatusResponseBody = None,
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
            temp_model = QueryMinutesStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryMinutesTextHeaders(TeaModel):
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


class QueryMinutesTextRequest(TeaModel):
    def __init__(
        self,
        direction: int = None,
        max_results: int = None,
        next_token: str = None,
        union_id: str = None,
    ):
        self.direction = direction
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
        if self.direction is not None:
            result['direction'] = self.direction
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('direction') is not None:
            self.direction = m.get('direction')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class QueryMinutesTextResponseBodyParagraphListSentenceListWordList(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        start_time: int = None,
        word: str = None,
        word_id: str = None,
    ):
        self.end_time = end_time
        self.start_time = start_time
        self.word = word
        self.word_id = word_id

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
        if self.word is not None:
            result['word'] = self.word
        if self.word_id is not None:
            result['wordId'] = self.word_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('word') is not None:
            self.word = m.get('word')
        if m.get('wordId') is not None:
            self.word_id = m.get('wordId')
        return self


class QueryMinutesTextResponseBodyParagraphListSentenceList(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        sentence: str = None,
        start_time: int = None,
        word_list: List[QueryMinutesTextResponseBodyParagraphListSentenceListWordList] = None,
    ):
        self.end_time = end_time
        self.sentence = sentence
        self.start_time = start_time
        self.word_list = word_list

    def validate(self):
        if self.word_list:
            for k in self.word_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.sentence is not None:
            result['sentence'] = self.sentence
        if self.start_time is not None:
            result['startTime'] = self.start_time
        result['wordList'] = []
        if self.word_list is not None:
            for k in self.word_list:
                result['wordList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('sentence') is not None:
            self.sentence = m.get('sentence')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        self.word_list = []
        if m.get('wordList') is not None:
            for k in m.get('wordList'):
                temp_model = QueryMinutesTextResponseBodyParagraphListSentenceListWordList()
                self.word_list.append(temp_model.from_map(k))
        return self


class QueryMinutesTextResponseBodyParagraphList(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        nick_name: str = None,
        paragraph: str = None,
        paragraph_id: int = None,
        record_id: int = None,
        sentence_list: List[QueryMinutesTextResponseBodyParagraphListSentenceList] = None,
        start_time: int = None,
        union_id: str = None,
    ):
        self.end_time = end_time
        self.nick_name = nick_name
        self.paragraph = paragraph
        self.paragraph_id = paragraph_id
        self.record_id = record_id
        self.sentence_list = sentence_list
        self.start_time = start_time
        self.union_id = union_id

    def validate(self):
        if self.sentence_list:
            for k in self.sentence_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.nick_name is not None:
            result['nickName'] = self.nick_name
        if self.paragraph is not None:
            result['paragraph'] = self.paragraph
        if self.paragraph_id is not None:
            result['paragraphId'] = self.paragraph_id
        if self.record_id is not None:
            result['recordId'] = self.record_id
        result['sentenceList'] = []
        if self.sentence_list is not None:
            for k in self.sentence_list:
                result['sentenceList'].append(k.to_map() if k else None)
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('nickName') is not None:
            self.nick_name = m.get('nickName')
        if m.get('paragraph') is not None:
            self.paragraph = m.get('paragraph')
        if m.get('paragraphId') is not None:
            self.paragraph_id = m.get('paragraphId')
        if m.get('recordId') is not None:
            self.record_id = m.get('recordId')
        self.sentence_list = []
        if m.get('sentenceList') is not None:
            for k in m.get('sentenceList'):
                temp_model = QueryMinutesTextResponseBodyParagraphListSentenceList()
                self.sentence_list.append(temp_model.from_map(k))
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class QueryMinutesTextResponseBody(TeaModel):
    def __init__(
        self,
        has_next: bool = None,
        next_token: str = None,
        paragraph_list: List[QueryMinutesTextResponseBodyParagraphList] = None,
    ):
        self.has_next = has_next
        self.next_token = next_token
        self.paragraph_list = paragraph_list

    def validate(self):
        if self.paragraph_list:
            for k in self.paragraph_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_next is not None:
            result['hasNext'] = self.has_next
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['paragraphList'] = []
        if self.paragraph_list is not None:
            for k in self.paragraph_list:
                result['paragraphList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasNext') is not None:
            self.has_next = m.get('hasNext')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.paragraph_list = []
        if m.get('paragraphList') is not None:
            for k in m.get('paragraphList'):
                temp_model = QueryMinutesTextResponseBodyParagraphList()
                self.paragraph_list.append(temp_model.from_map(k))
        return self


class QueryMinutesTextResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryMinutesTextResponseBody = None,
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
            temp_model = QueryMinutesTextResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryUploadVideoPlayInfoHeaders(TeaModel):
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


class QueryUploadVideoPlayInfoRequest(TeaModel):
    def __init__(
        self,
        union_id: str = None,
    ):
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class QueryUploadVideoPlayInfoResponseBodyPlayInfo(TeaModel):
    def __init__(
        self,
        duration: int = None,
        play_url: str = None,
        size: int = None,
        status: str = None,
    ):
        self.duration = duration
        self.play_url = play_url
        self.size = size
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.duration is not None:
            result['duration'] = self.duration
        if self.play_url is not None:
            result['playUrl'] = self.play_url
        if self.size is not None:
            result['size'] = self.size
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('playUrl') is not None:
            self.play_url = m.get('playUrl')
        if m.get('size') is not None:
            self.size = m.get('size')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class QueryUploadVideoPlayInfoResponseBody(TeaModel):
    def __init__(
        self,
        play_info: QueryUploadVideoPlayInfoResponseBodyPlayInfo = None,
    ):
        self.play_info = play_info

    def validate(self):
        if self.play_info:
            self.play_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.play_info is not None:
            result['playInfo'] = self.play_info.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('playInfo') is not None:
            temp_model = QueryUploadVideoPlayInfoResponseBodyPlayInfo()
            self.play_info = temp_model.from_map(m['playInfo'])
        return self


class QueryUploadVideoPlayInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryUploadVideoPlayInfoResponseBody = None,
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
            temp_model = QueryUploadVideoPlayInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateMinutesTitleHeaders(TeaModel):
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


class UpdateMinutesTitleRequest(TeaModel):
    def __init__(
        self,
        title: str = None,
        union_id: str = None,
    ):
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
        if self.title is not None:
            result['title'] = self.title
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class UpdateMinutesTitleResponseBody(TeaModel):
    def __init__(
        self,
        task_uuid: str = None,
        title: str = None,
    ):
        self.task_uuid = task_uuid
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.task_uuid is not None:
            result['taskUuid'] = self.task_uuid
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('taskUuid') is not None:
            self.task_uuid = m.get('taskUuid')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class UpdateMinutesTitleResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateMinutesTitleResponseBody = None,
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
            temp_model = UpdateMinutesTitleResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


