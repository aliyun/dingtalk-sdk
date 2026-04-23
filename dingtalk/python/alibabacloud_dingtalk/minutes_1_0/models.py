# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List, Any


class AdminSearchMinutesHeaders(TeaModel):
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


class AdminSearchMinutesRequest(TeaModel):
    def __init__(
        self,
        creator_union_ids: List[str] = None,
        end_time: int = None,
        next_token: str = None,
        page_size: int = None,
        query: str = None,
        search_type: str = None,
        start_time: int = None,
        union_id: str = None,
    ):
        self.creator_union_ids = creator_union_ids
        self.end_time = end_time
        self.next_token = next_token
        # This parameter is required.
        self.page_size = page_size
        # This parameter is required.
        self.query = query
        self.search_type = search_type
        self.start_time = start_time
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.creator_union_ids is not None:
            result['creatorUnionIds'] = self.creator_union_ids
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.query is not None:
            result['query'] = self.query
        if self.search_type is not None:
            result['searchType'] = self.search_type
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('creatorUnionIds') is not None:
            self.creator_union_ids = m.get('creatorUnionIds')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('query') is not None:
            self.query = m.get('query')
        if m.get('searchType') is not None:
            self.search_type = m.get('searchType')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class AdminSearchMinutesResponseBodyMinutesList(TeaModel):
    def __init__(
        self,
        biz_type: int = None,
        creator_nick: str = None,
        creator_union_id: str = None,
        duration: int = None,
        full_text_summary: str = None,
        original_text: str = None,
        start_time: int = None,
        status: int = None,
        task_uuid: str = None,
        title: str = None,
    ):
        self.biz_type = biz_type
        self.creator_nick = creator_nick
        self.creator_union_id = creator_union_id
        self.duration = duration
        self.full_text_summary = full_text_summary
        self.original_text = original_text
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
        if self.duration is not None:
            result['duration'] = self.duration
        if self.full_text_summary is not None:
            result['fullTextSummary'] = self.full_text_summary
        if self.original_text is not None:
            result['originalText'] = self.original_text
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
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('fullTextSummary') is not None:
            self.full_text_summary = m.get('fullTextSummary')
        if m.get('originalText') is not None:
            self.original_text = m.get('originalText')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('taskUuid') is not None:
            self.task_uuid = m.get('taskUuid')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class AdminSearchMinutesResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        minutes_list: List[AdminSearchMinutesResponseBodyMinutesList] = None,
        next_token: str = None,
    ):
        self.has_more = has_more
        self.minutes_list = minutes_list
        self.next_token = next_token

    def validate(self):
        if self.minutes_list:
            for k in self.minutes_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['minutesList'] = []
        if self.minutes_list is not None:
            for k in self.minutes_list:
                result['minutesList'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.minutes_list = []
        if m.get('minutesList') is not None:
            for k in m.get('minutesList'):
                temp_model = AdminSearchMinutesResponseBodyMinutesList()
                self.minutes_list.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class AdminSearchMinutesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AdminSearchMinutesResponseBody = None,
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
            temp_model = AdminSearchMinutesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


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


class BatchGetVoicePrintIdentifyConfigHeaders(TeaModel):
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


class BatchGetVoicePrintIdentifyConfigRequestItems(TeaModel):
    def __init__(
        self,
        lang: str = None,
        union_id: str = None,
    ):
        self.lang = lang
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.lang is not None:
            result['lang'] = self.lang
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('lang') is not None:
            self.lang = m.get('lang')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class BatchGetVoicePrintIdentifyConfigRequest(TeaModel):
    def __init__(
        self,
        items: List[BatchGetVoicePrintIdentifyConfigRequestItems] = None,
    ):
        # This parameter is required.
        self.items = items

    def validate(self):
        if self.items:
            for k in self.items:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.items = []
        if m.get('items') is not None:
            for k in m.get('items'):
                temp_model = BatchGetVoicePrintIdentifyConfigRequestItems()
                self.items.append(temp_model.from_map(k))
        return self


class BatchGetVoicePrintIdentifyConfigResponseBodyConfigItems(TeaModel):
    def __init__(
        self,
        allow_config_voice_print: bool = None,
        enable_voice_print: bool = None,
        has_voice_print_record: bool = None,
        union_id: str = None,
    ):
        self.allow_config_voice_print = allow_config_voice_print
        self.enable_voice_print = enable_voice_print
        self.has_voice_print_record = has_voice_print_record
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.allow_config_voice_print is not None:
            result['allowConfigVoicePrint'] = self.allow_config_voice_print
        if self.enable_voice_print is not None:
            result['enableVoicePrint'] = self.enable_voice_print
        if self.has_voice_print_record is not None:
            result['hasVoicePrintRecord'] = self.has_voice_print_record
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('allowConfigVoicePrint') is not None:
            self.allow_config_voice_print = m.get('allowConfigVoicePrint')
        if m.get('enableVoicePrint') is not None:
            self.enable_voice_print = m.get('enableVoicePrint')
        if m.get('hasVoicePrintRecord') is not None:
            self.has_voice_print_record = m.get('hasVoicePrintRecord')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class BatchGetVoicePrintIdentifyConfigResponseBody(TeaModel):
    def __init__(
        self,
        config_items: List[BatchGetVoicePrintIdentifyConfigResponseBodyConfigItems] = None,
    ):
        self.config_items = config_items

    def validate(self):
        if self.config_items:
            for k in self.config_items:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['configItems'] = []
        if self.config_items is not None:
            for k in self.config_items:
                result['configItems'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.config_items = []
        if m.get('configItems') is not None:
            for k in m.get('configItems'):
                temp_model = BatchGetVoicePrintIdentifyConfigResponseBodyConfigItems()
                self.config_items.append(temp_model.from_map(k))
        return self


class BatchGetVoicePrintIdentifyConfigResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BatchGetVoicePrintIdentifyConfigResponseBody = None,
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
            temp_model = BatchGetVoicePrintIdentifyConfigResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BatchToggleVoicePrintSwitchStatusHeaders(TeaModel):
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


class BatchToggleVoicePrintSwitchStatusRequestItems(TeaModel):
    def __init__(
        self,
        open: bool = None,
        should_clear_voice_print: bool = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.open = open
        self.should_clear_voice_print = should_clear_voice_print
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open is not None:
            result['open'] = self.open
        if self.should_clear_voice_print is not None:
            result['shouldClearVoicePrint'] = self.should_clear_voice_print
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('open') is not None:
            self.open = m.get('open')
        if m.get('shouldClearVoicePrint') is not None:
            self.should_clear_voice_print = m.get('shouldClearVoicePrint')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class BatchToggleVoicePrintSwitchStatusRequest(TeaModel):
    def __init__(
        self,
        items: List[BatchToggleVoicePrintSwitchStatusRequestItems] = None,
    ):
        # This parameter is required.
        self.items = items

    def validate(self):
        if self.items:
            for k in self.items:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.items = []
        if m.get('items') is not None:
            for k in m.get('items'):
                temp_model = BatchToggleVoicePrintSwitchStatusRequestItems()
                self.items.append(temp_model.from_map(k))
        return self


class BatchToggleVoicePrintSwitchStatusResponseBodyResultItems(TeaModel):
    def __init__(
        self,
        message: str = None,
        success: bool = None,
        union_id: str = None,
    ):
        self.message = message
        self.success = success
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.message is not None:
            result['message'] = self.message
        if self.success is not None:
            result['success'] = self.success
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('message') is not None:
            self.message = m.get('message')
        if m.get('success') is not None:
            self.success = m.get('success')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class BatchToggleVoicePrintSwitchStatusResponseBody(TeaModel):
    def __init__(
        self,
        result_items: List[BatchToggleVoicePrintSwitchStatusResponseBodyResultItems] = None,
    ):
        self.result_items = result_items

    def validate(self):
        if self.result_items:
            for k in self.result_items:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['resultItems'] = []
        if self.result_items is not None:
            for k in self.result_items:
                result['resultItems'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.result_items = []
        if m.get('resultItems') is not None:
            for k in m.get('resultItems'):
                temp_model = BatchToggleVoicePrintSwitchStatusResponseBodyResultItems()
                self.result_items.append(temp_model.from_map(k))
        return self


class BatchToggleVoicePrintSwitchStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BatchToggleVoicePrintSwitchStatusResponseBody = None,
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
            temp_model = BatchToggleVoicePrintSwitchStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateMinutesByUploadFileHeaders(TeaModel):
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


class CreateMinutesByUploadFileRequest(TeaModel):
    def __init__(
        self,
        biz_id: str = None,
        creator_id: str = None,
        custom_prompt: str = None,
        enable_push_card: bool = None,
        hidden_minutes: bool = None,
        media_file_url: str = None,
        media_type: str = None,
        title: str = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.biz_id = biz_id
        # This parameter is required.
        self.creator_id = creator_id
        self.custom_prompt = custom_prompt
        self.enable_push_card = enable_push_card
        self.hidden_minutes = hidden_minutes
        # This parameter is required.
        self.media_file_url = media_file_url
        # This parameter is required.
        self.media_type = media_type
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
        if self.biz_id is not None:
            result['bizId'] = self.biz_id
        if self.creator_id is not None:
            result['creatorId'] = self.creator_id
        if self.custom_prompt is not None:
            result['customPrompt'] = self.custom_prompt
        if self.enable_push_card is not None:
            result['enablePushCard'] = self.enable_push_card
        if self.hidden_minutes is not None:
            result['hiddenMinutes'] = self.hidden_minutes
        if self.media_file_url is not None:
            result['mediaFileUrl'] = self.media_file_url
        if self.media_type is not None:
            result['mediaType'] = self.media_type
        if self.title is not None:
            result['title'] = self.title
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        if m.get('creatorId') is not None:
            self.creator_id = m.get('creatorId')
        if m.get('customPrompt') is not None:
            self.custom_prompt = m.get('customPrompt')
        if m.get('enablePushCard') is not None:
            self.enable_push_card = m.get('enablePushCard')
        if m.get('hiddenMinutes') is not None:
            self.hidden_minutes = m.get('hiddenMinutes')
        if m.get('mediaFileUrl') is not None:
            self.media_file_url = m.get('mediaFileUrl')
        if m.get('mediaType') is not None:
            self.media_type = m.get('mediaType')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class CreateMinutesByUploadFileResponseBody(TeaModel):
    def __init__(
        self,
        biz_id: str = None,
        task_uuid: str = None,
    ):
        self.biz_id = biz_id
        self.task_uuid = task_uuid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_id is not None:
            result['bizId'] = self.biz_id
        if self.task_uuid is not None:
            result['taskUuid'] = self.task_uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        if m.get('taskUuid') is not None:
            self.task_uuid = m.get('taskUuid')
        return self


class CreateMinutesByUploadFileResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateMinutesByUploadFileResponseBody = None,
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
            temp_model = CreateMinutesByUploadFileResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateSmartDeviceAiSummaryHeaders(TeaModel):
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


class CreateSmartDeviceAiSummaryRequest(TeaModel):
    def __init__(
        self,
        agent_id: str = None,
        instance_id: str = None,
        isv_context: str = None,
        open_file_id: str = None,
    ):
        self.agent_id = agent_id
        self.instance_id = instance_id
        self.isv_context = isv_context
        self.open_file_id = open_file_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.isv_context is not None:
            result['isvContext'] = self.isv_context
        if self.open_file_id is not None:
            result['openFileId'] = self.open_file_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('isvContext') is not None:
            self.isv_context = m.get('isvContext')
        if m.get('openFileId') is not None:
            self.open_file_id = m.get('openFileId')
        return self


class CreateSmartDeviceAiSummaryResponseBody(TeaModel):
    def __init__(
        self,
        async_: bool = None,
    ):
        self.async_ = async_

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.async_ is not None:
            result['async'] = self.async_
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('async') is not None:
            self.async_ = m.get('async')
        return self


class CreateSmartDeviceAiSummaryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateSmartDeviceAiSummaryResponseBody = None,
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
            temp_model = CreateSmartDeviceAiSummaryResponseBody()
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


class ExportMinutesTaskResultHeaders(TeaModel):
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


class ExportMinutesTaskResultRequestSummaryExportSetting(TeaModel):
    def __init__(
        self,
        enable_bilingual: bool = None,
        target_lang: str = None,
    ):
        self.enable_bilingual = enable_bilingual
        self.target_lang = target_lang

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.enable_bilingual is not None:
            result['enableBilingual'] = self.enable_bilingual
        if self.target_lang is not None:
            result['targetLang'] = self.target_lang
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('enableBilingual') is not None:
            self.enable_bilingual = m.get('enableBilingual')
        if m.get('targetLang') is not None:
            self.target_lang = m.get('targetLang')
        return self


class ExportMinutesTaskResultRequest(TeaModel):
    def __init__(
        self,
        expire_time: int = None,
        summary_export_setting: ExportMinutesTaskResultRequestSummaryExportSetting = None,
        task_type: str = None,
        task_uuid: str = None,
        union_id: str = None,
    ):
        self.expire_time = expire_time
        self.summary_export_setting = summary_export_setting
        # This parameter is required.
        self.task_type = task_type
        # This parameter is required.
        self.task_uuid = task_uuid
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        if self.summary_export_setting:
            self.summary_export_setting.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.expire_time is not None:
            result['expireTime'] = self.expire_time
        if self.summary_export_setting is not None:
            result['summaryExportSetting'] = self.summary_export_setting.to_map()
        if self.task_type is not None:
            result['taskType'] = self.task_type
        if self.task_uuid is not None:
            result['taskUuid'] = self.task_uuid
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('expireTime') is not None:
            self.expire_time = m.get('expireTime')
        if m.get('summaryExportSetting') is not None:
            temp_model = ExportMinutesTaskResultRequestSummaryExportSetting()
            self.summary_export_setting = temp_model.from_map(m['summaryExportSetting'])
        if m.get('taskType') is not None:
            self.task_type = m.get('taskType')
        if m.get('taskUuid') is not None:
            self.task_uuid = m.get('taskUuid')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class ExportMinutesTaskResultResponseBody(TeaModel):
    def __init__(
        self,
        minutes_doc_url: str = None,
    ):
        self.minutes_doc_url = minutes_doc_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.minutes_doc_url is not None:
            result['minutesDocUrl'] = self.minutes_doc_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('minutesDocUrl') is not None:
            self.minutes_doc_url = m.get('minutesDocUrl')
        return self


class ExportMinutesTaskResultResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ExportMinutesTaskResultResponseBody = None,
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
            temp_model = ExportMinutesTaskResultResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GenerateSummaryHeaders(TeaModel):
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


class GenerateSummaryRequest(TeaModel):
    def __init__(
        self,
        diy_template_version: str = None,
        summary_template_id: str = None,
        summary_template_type: str = None,
        user_context: str = None,
        union_id: str = None,
    ):
        self.diy_template_version = diy_template_version
        # This parameter is required.
        self.summary_template_id = summary_template_id
        # This parameter is required.
        self.summary_template_type = summary_template_type
        self.user_context = user_context
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.diy_template_version is not None:
            result['diyTemplateVersion'] = self.diy_template_version
        if self.summary_template_id is not None:
            result['summaryTemplateId'] = self.summary_template_id
        if self.summary_template_type is not None:
            result['summaryTemplateType'] = self.summary_template_type
        if self.user_context is not None:
            result['userContext'] = self.user_context
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('diyTemplateVersion') is not None:
            self.diy_template_version = m.get('diyTemplateVersion')
        if m.get('summaryTemplateId') is not None:
            self.summary_template_id = m.get('summaryTemplateId')
        if m.get('summaryTemplateType') is not None:
            self.summary_template_type = m.get('summaryTemplateType')
        if m.get('userContext') is not None:
            self.user_context = m.get('userContext')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GenerateSummaryResponseBody(TeaModel):
    def __init__(
        self,
        summary_text: str = None,
        task_uuid: str = None,
    ):
        self.summary_text = summary_text
        self.task_uuid = task_uuid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.summary_text is not None:
            result['summaryText'] = self.summary_text
        if self.task_uuid is not None:
            result['taskUuid'] = self.task_uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('summaryText') is not None:
            self.summary_text = m.get('summaryText')
        if m.get('taskUuid') is not None:
            self.task_uuid = m.get('taskUuid')
        return self


class GenerateSummaryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GenerateSummaryResponseBody = None,
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
            temp_model = GenerateSummaryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class OpenQueryMinutesSummaryHeaders(TeaModel):
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


class OpenQueryMinutesSummaryRequest(TeaModel):
    def __init__(
        self,
        task_uuid: str = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.task_uuid = task_uuid
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.task_uuid is not None:
            result['taskUuid'] = self.task_uuid
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('taskUuid') is not None:
            self.task_uuid = m.get('taskUuid')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class OpenQueryMinutesSummaryResponseBody(TeaModel):
    def __init__(
        self,
        full_summary: str = None,
    ):
        self.full_summary = full_summary

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.full_summary is not None:
            result['fullSummary'] = self.full_summary
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fullSummary') is not None:
            self.full_summary = m.get('fullSummary')
        return self


class OpenQueryMinutesSummaryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: OpenQueryMinutesSummaryResponseBody = None,
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
            temp_model = OpenQueryMinutesSummaryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryBizMinutesHeaders(TeaModel):
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


class QueryBizMinutesRequest(TeaModel):
    def __init__(
        self,
        biz_id: str = None,
        biz_type: int = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.biz_id = biz_id
        # This parameter is required.
        self.biz_type = biz_type
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_id is not None:
            result['bizId'] = self.biz_id
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class QueryBizMinutesResponseBodyMinutesDetails(TeaModel):
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


class QueryBizMinutesResponseBody(TeaModel):
    def __init__(
        self,
        minutes_details: List[QueryBizMinutesResponseBodyMinutesDetails] = None,
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
                temp_model = QueryBizMinutesResponseBodyMinutesDetails()
                self.minutes_details.append(temp_model.from_map(k))
        return self


class QueryBizMinutesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryBizMinutesResponseBody = None,
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
            temp_model = QueryBizMinutesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryCreateMinutesListHeaders(TeaModel):
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


class QueryCreateMinutesListRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        union_id: str = None,
    ):
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
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class QueryCreateMinutesListResponseBodyMinutesDetails(TeaModel):
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


class QueryCreateMinutesListResponseBody(TeaModel):
    def __init__(
        self,
        has_next: bool = None,
        minutes_details: List[QueryCreateMinutesListResponseBodyMinutesDetails] = None,
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
                temp_model = QueryCreateMinutesListResponseBodyMinutesDetails()
                self.minutes_details.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class QueryCreateMinutesListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryCreateMinutesListResponseBody = None,
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
            temp_model = QueryCreateMinutesListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryMinutesBasicInfoHeaders(TeaModel):
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


class QueryMinutesBasicInfoRequest(TeaModel):
    def __init__(
        self,
        task_uuid: str = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.task_uuid = task_uuid
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.task_uuid is not None:
            result['taskUuid'] = self.task_uuid
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('taskUuid') is not None:
            self.task_uuid = m.get('taskUuid')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class QueryMinutesBasicInfoResponseBody(TeaModel):
    def __init__(
        self,
        duration: int = None,
        end_time: int = None,
        start_time: int = None,
        task_creator: str = None,
        task_uuid: str = None,
        title: str = None,
        url: str = None,
    ):
        self.duration = duration
        self.end_time = end_time
        self.start_time = start_time
        self.task_creator = task_creator
        self.task_uuid = task_uuid
        self.title = title
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.duration is not None:
            result['duration'] = self.duration
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.task_creator is not None:
            result['taskCreator'] = self.task_creator
        if self.task_uuid is not None:
            result['taskUuid'] = self.task_uuid
        if self.title is not None:
            result['title'] = self.title
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('taskCreator') is not None:
            self.task_creator = m.get('taskCreator')
        if m.get('taskUuid') is not None:
            self.task_uuid = m.get('taskUuid')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class QueryMinutesBasicInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryMinutesBasicInfoResponseBody = None,
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
            temp_model = QueryMinutesBasicInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryMinutesChaptersHeaders(TeaModel):
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


class QueryMinutesChaptersRequest(TeaModel):
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


class QueryMinutesChaptersResponseBodyChapterList(TeaModel):
    def __init__(
        self,
        content: str = None,
        end_time: int = None,
        start_time: int = None,
        title: str = None,
        uuid: str = None,
    ):
        self.content = content
        self.end_time = end_time
        self.start_time = start_time
        self.title = title
        self.uuid = uuid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.title is not None:
            result['title'] = self.title
        if self.uuid is not None:
            result['uuid'] = self.uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        return self


class QueryMinutesChaptersResponseBody(TeaModel):
    def __init__(
        self,
        chapter_list: List[QueryMinutesChaptersResponseBodyChapterList] = None,
        status: int = None,
    ):
        self.chapter_list = chapter_list
        self.status = status

    def validate(self):
        if self.chapter_list:
            for k in self.chapter_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['chapterList'] = []
        if self.chapter_list is not None:
            for k in self.chapter_list:
                result['chapterList'].append(k.to_map() if k else None)
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.chapter_list = []
        if m.get('chapterList') is not None:
            for k in m.get('chapterList'):
                temp_model = QueryMinutesChaptersResponseBodyChapterList()
                self.chapter_list.append(temp_model.from_map(k))
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class QueryMinutesChaptersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryMinutesChaptersResponseBody = None,
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
            temp_model = QueryMinutesChaptersResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryMinutesKeywordHeaders(TeaModel):
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


class QueryMinutesKeywordRequest(TeaModel):
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


class QueryMinutesKeywordResponseBody(TeaModel):
    def __init__(
        self,
        keywords: List[str] = None,
    ):
        self.keywords = keywords

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.keywords is not None:
            result['keywords'] = self.keywords
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('keywords') is not None:
            self.keywords = m.get('keywords')
        return self


class QueryMinutesKeywordResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryMinutesKeywordResponseBody = None,
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
            temp_model = QueryMinutesKeywordResponseBody()
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


class QueryMinutesTextResponseBodyParagraphListSpeakerDisplay(TeaModel):
    def __init__(
        self,
        avatar_url: str = None,
        nick_name: str = None,
    ):
        self.avatar_url = avatar_url
        self.nick_name = nick_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.avatar_url is not None:
            result['avatarUrl'] = self.avatar_url
        if self.nick_name is not None:
            result['nickName'] = self.nick_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('avatarUrl') is not None:
            self.avatar_url = m.get('avatarUrl')
        if m.get('nickName') is not None:
            self.nick_name = m.get('nickName')
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
        speaker_display: QueryMinutesTextResponseBodyParagraphListSpeakerDisplay = None,
        start_time: int = None,
        sub_speaker_id: str = None,
        union_id: str = None,
    ):
        self.end_time = end_time
        self.nick_name = nick_name
        self.paragraph = paragraph
        self.paragraph_id = paragraph_id
        self.record_id = record_id
        self.sentence_list = sentence_list
        self.speaker_display = speaker_display
        self.start_time = start_time
        self.sub_speaker_id = sub_speaker_id
        self.union_id = union_id

    def validate(self):
        if self.sentence_list:
            for k in self.sentence_list:
                if k:
                    k.validate()
        if self.speaker_display:
            self.speaker_display.validate()

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
        if self.speaker_display is not None:
            result['speakerDisplay'] = self.speaker_display.to_map()
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.sub_speaker_id is not None:
            result['subSpeakerId'] = self.sub_speaker_id
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
        if m.get('speakerDisplay') is not None:
            temp_model = QueryMinutesTextResponseBodyParagraphListSpeakerDisplay()
            self.speaker_display = temp_model.from_map(m['speakerDisplay'])
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('subSpeakerId') is not None:
            self.sub_speaker_id = m.get('subSpeakerId')
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


class QueryMinutesTodoHeaders(TeaModel):
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


class QueryMinutesTodoRequest(TeaModel):
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


class QueryMinutesTodoResponseBodyDingtalkTodoListExecutorList(TeaModel):
    def __init__(
        self,
        avatar: str = None,
        nick: str = None,
        union_id: str = None,
    ):
        self.avatar = avatar
        self.nick = nick
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.avatar is not None:
            result['avatar'] = self.avatar
        if self.nick is not None:
            result['nick'] = self.nick
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('avatar') is not None:
            self.avatar = m.get('avatar')
        if m.get('nick') is not None:
            self.nick = m.get('nick')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class QueryMinutesTodoResponseBodyDingtalkTodoList(TeaModel):
    def __init__(
        self,
        created_time: int = None,
        creator_union_id: str = None,
        deadline: str = None,
        dingtalk_todo_id: str = None,
        executor_list: List[QueryMinutesTodoResponseBodyDingtalkTodoListExecutorList] = None,
        is_done: bool = None,
        minutes_todo_id: str = None,
        title: str = None,
    ):
        self.created_time = created_time
        self.creator_union_id = creator_union_id
        self.deadline = deadline
        self.dingtalk_todo_id = dingtalk_todo_id
        self.executor_list = executor_list
        self.is_done = is_done
        self.minutes_todo_id = minutes_todo_id
        self.title = title

    def validate(self):
        if self.executor_list:
            for k in self.executor_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.created_time is not None:
            result['createdTime'] = self.created_time
        if self.creator_union_id is not None:
            result['creatorUnionId'] = self.creator_union_id
        if self.deadline is not None:
            result['deadline'] = self.deadline
        if self.dingtalk_todo_id is not None:
            result['dingtalkTodoId'] = self.dingtalk_todo_id
        result['executorList'] = []
        if self.executor_list is not None:
            for k in self.executor_list:
                result['executorList'].append(k.to_map() if k else None)
        if self.is_done is not None:
            result['isDone'] = self.is_done
        if self.minutes_todo_id is not None:
            result['minutesTodoId'] = self.minutes_todo_id
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createdTime') is not None:
            self.created_time = m.get('createdTime')
        if m.get('creatorUnionId') is not None:
            self.creator_union_id = m.get('creatorUnionId')
        if m.get('deadline') is not None:
            self.deadline = m.get('deadline')
        if m.get('dingtalkTodoId') is not None:
            self.dingtalk_todo_id = m.get('dingtalkTodoId')
        self.executor_list = []
        if m.get('executorList') is not None:
            for k in m.get('executorList'):
                temp_model = QueryMinutesTodoResponseBodyDingtalkTodoListExecutorList()
                self.executor_list.append(temp_model.from_map(k))
        if m.get('isDone') is not None:
            self.is_done = m.get('isDone')
        if m.get('minutesTodoId') is not None:
            self.minutes_todo_id = m.get('minutesTodoId')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class QueryMinutesTodoResponseBody(TeaModel):
    def __init__(
        self,
        actions: List[str] = None,
        dingtalk_todo_list: List[QueryMinutesTodoResponseBodyDingtalkTodoList] = None,
    ):
        self.actions = actions
        self.dingtalk_todo_list = dingtalk_todo_list

    def validate(self):
        if self.dingtalk_todo_list:
            for k in self.dingtalk_todo_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.actions is not None:
            result['actions'] = self.actions
        result['dingtalkTodoList'] = []
        if self.dingtalk_todo_list is not None:
            for k in self.dingtalk_todo_list:
                result['dingtalkTodoList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actions') is not None:
            self.actions = m.get('actions')
        self.dingtalk_todo_list = []
        if m.get('dingtalkTodoList') is not None:
            for k in m.get('dingtalkTodoList'):
                temp_model = QueryMinutesTodoResponseBodyDingtalkTodoList()
                self.dingtalk_todo_list.append(temp_model.from_map(k))
        return self


class QueryMinutesTodoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryMinutesTodoResponseBody = None,
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
            temp_model = QueryMinutesTodoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryOrgDiyTemplatesHeaders(TeaModel):
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


class QueryOrgDiyTemplatesRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        union_id: str = None,
    ):
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
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class QueryOrgDiyTemplatesResponseBodyDiyTemplates(TeaModel):
    def __init__(
        self,
        accept_times: int = None,
        create_time: int = None,
        creator_nick: str = None,
        creator_union_id: str = None,
        diy_template_brief_intro: str = None,
        diy_template_icon_url: str = None,
        diy_template_key: str = None,
        diy_template_latest_version: int = None,
        diy_template_source: str = None,
        diy_template_title: str = None,
        status: str = None,
    ):
        self.accept_times = accept_times
        self.create_time = create_time
        self.creator_nick = creator_nick
        self.creator_union_id = creator_union_id
        self.diy_template_brief_intro = diy_template_brief_intro
        self.diy_template_icon_url = diy_template_icon_url
        self.diy_template_key = diy_template_key
        self.diy_template_latest_version = diy_template_latest_version
        self.diy_template_source = diy_template_source
        self.diy_template_title = diy_template_title
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.accept_times is not None:
            result['acceptTimes'] = self.accept_times
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.creator_nick is not None:
            result['creatorNick'] = self.creator_nick
        if self.creator_union_id is not None:
            result['creatorUnionId'] = self.creator_union_id
        if self.diy_template_brief_intro is not None:
            result['diyTemplateBriefIntro'] = self.diy_template_brief_intro
        if self.diy_template_icon_url is not None:
            result['diyTemplateIconUrl'] = self.diy_template_icon_url
        if self.diy_template_key is not None:
            result['diyTemplateKey'] = self.diy_template_key
        if self.diy_template_latest_version is not None:
            result['diyTemplateLatestVersion'] = self.diy_template_latest_version
        if self.diy_template_source is not None:
            result['diyTemplateSource'] = self.diy_template_source
        if self.diy_template_title is not None:
            result['diyTemplateTitle'] = self.diy_template_title
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('acceptTimes') is not None:
            self.accept_times = m.get('acceptTimes')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('creatorNick') is not None:
            self.creator_nick = m.get('creatorNick')
        if m.get('creatorUnionId') is not None:
            self.creator_union_id = m.get('creatorUnionId')
        if m.get('diyTemplateBriefIntro') is not None:
            self.diy_template_brief_intro = m.get('diyTemplateBriefIntro')
        if m.get('diyTemplateIconUrl') is not None:
            self.diy_template_icon_url = m.get('diyTemplateIconUrl')
        if m.get('diyTemplateKey') is not None:
            self.diy_template_key = m.get('diyTemplateKey')
        if m.get('diyTemplateLatestVersion') is not None:
            self.diy_template_latest_version = m.get('diyTemplateLatestVersion')
        if m.get('diyTemplateSource') is not None:
            self.diy_template_source = m.get('diyTemplateSource')
        if m.get('diyTemplateTitle') is not None:
            self.diy_template_title = m.get('diyTemplateTitle')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class QueryOrgDiyTemplatesResponseBody(TeaModel):
    def __init__(
        self,
        diy_templates: List[QueryOrgDiyTemplatesResponseBodyDiyTemplates] = None,
        has_next: bool = None,
        next_token: str = None,
        total: int = None,
    ):
        self.diy_templates = diy_templates
        self.has_next = has_next
        self.next_token = next_token
        self.total = total

    def validate(self):
        if self.diy_templates:
            for k in self.diy_templates:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['diyTemplates'] = []
        if self.diy_templates is not None:
            for k in self.diy_templates:
                result['diyTemplates'].append(k.to_map() if k else None)
        if self.has_next is not None:
            result['hasNext'] = self.has_next
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.diy_templates = []
        if m.get('diyTemplates') is not None:
            for k in m.get('diyTemplates'):
                temp_model = QueryOrgDiyTemplatesResponseBodyDiyTemplates()
                self.diy_templates.append(temp_model.from_map(k))
        if m.get('hasNext') is not None:
            self.has_next = m.get('hasNext')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class QueryOrgDiyTemplatesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryOrgDiyTemplatesResponseBody = None,
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
            temp_model = QueryOrgDiyTemplatesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryScheduleConfMinutesHeaders(TeaModel):
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


class QueryScheduleConfMinutesRequest(TeaModel):
    def __init__(
        self,
        event_id: str = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.event_id = event_id
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.event_id is not None:
            result['eventId'] = self.event_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('eventId') is not None:
            self.event_id = m.get('eventId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class QueryScheduleConfMinutesResponseBodyMinutesDetails(TeaModel):
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


class QueryScheduleConfMinutesResponseBody(TeaModel):
    def __init__(
        self,
        minutes_details: List[QueryScheduleConfMinutesResponseBodyMinutesDetails] = None,
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
                temp_model = QueryScheduleConfMinutesResponseBodyMinutesDetails()
                self.minutes_details.append(temp_model.from_map(k))
        return self


class QueryScheduleConfMinutesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryScheduleConfMinutesResponseBody = None,
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
            temp_model = QueryScheduleConfMinutesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QuerySmartDeviceAiSummaryHeaders(TeaModel):
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


class QuerySmartDeviceAiSummaryRequest(TeaModel):
    def __init__(
        self,
        agent_id: str = None,
        open_file_id: str = None,
    ):
        self.agent_id = agent_id
        self.open_file_id = open_file_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        if self.open_file_id is not None:
            result['openFileId'] = self.open_file_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        if m.get('openFileId') is not None:
            self.open_file_id = m.get('openFileId')
        return self


class QuerySmartDeviceAiSummaryResponseBodyAiSummaryList(TeaModel):
    def __init__(
        self,
        agent_id: str = None,
        ai_scene_rule_avatar_url: str = None,
        creator_union_id: str = None,
        instance_id: str = None,
        open_file_id: str = None,
        order: int = None,
        summary: str = None,
        template_id: str = None,
        title: str = None,
    ):
        self.agent_id = agent_id
        self.ai_scene_rule_avatar_url = ai_scene_rule_avatar_url
        self.creator_union_id = creator_union_id
        self.instance_id = instance_id
        self.open_file_id = open_file_id
        self.order = order
        self.summary = summary
        self.template_id = template_id
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        if self.ai_scene_rule_avatar_url is not None:
            result['aiSceneRuleAvatarUrl'] = self.ai_scene_rule_avatar_url
        if self.creator_union_id is not None:
            result['creatorUnionId'] = self.creator_union_id
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.open_file_id is not None:
            result['openFileId'] = self.open_file_id
        if self.order is not None:
            result['order'] = self.order
        if self.summary is not None:
            result['summary'] = self.summary
        if self.template_id is not None:
            result['templateId'] = self.template_id
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        if m.get('aiSceneRuleAvatarUrl') is not None:
            self.ai_scene_rule_avatar_url = m.get('aiSceneRuleAvatarUrl')
        if m.get('creatorUnionId') is not None:
            self.creator_union_id = m.get('creatorUnionId')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('openFileId') is not None:
            self.open_file_id = m.get('openFileId')
        if m.get('order') is not None:
            self.order = m.get('order')
        if m.get('summary') is not None:
            self.summary = m.get('summary')
        if m.get('templateId') is not None:
            self.template_id = m.get('templateId')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class QuerySmartDeviceAiSummaryResponseBody(TeaModel):
    def __init__(
        self,
        ai_summary_list: List[QuerySmartDeviceAiSummaryResponseBodyAiSummaryList] = None,
        state: int = None,
    ):
        self.ai_summary_list = ai_summary_list
        self.state = state

    def validate(self):
        if self.ai_summary_list:
            for k in self.ai_summary_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['aiSummaryList'] = []
        if self.ai_summary_list is not None:
            for k in self.ai_summary_list:
                result['aiSummaryList'].append(k.to_map() if k else None)
        if self.state is not None:
            result['state'] = self.state
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.ai_summary_list = []
        if m.get('aiSummaryList') is not None:
            for k in m.get('aiSummaryList'):
                temp_model = QuerySmartDeviceAiSummaryResponseBodyAiSummaryList()
                self.ai_summary_list.append(temp_model.from_map(k))
        if m.get('state') is not None:
            self.state = m.get('state')
        return self


class QuerySmartDeviceAiSummaryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QuerySmartDeviceAiSummaryResponseBody = None,
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
            temp_model = QuerySmartDeviceAiSummaryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QuerySummaryWithTemplateHeaders(TeaModel):
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


class QuerySummaryWithTemplateRequest(TeaModel):
    def __init__(
        self,
        diy_template_version: str = None,
        summary_template_id: str = None,
        summary_template_type: str = None,
        union_id: str = None,
    ):
        self.diy_template_version = diy_template_version
        # This parameter is required.
        self.summary_template_id = summary_template_id
        # This parameter is required.
        self.summary_template_type = summary_template_type
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.diy_template_version is not None:
            result['diyTemplateVersion'] = self.diy_template_version
        if self.summary_template_id is not None:
            result['summaryTemplateId'] = self.summary_template_id
        if self.summary_template_type is not None:
            result['summaryTemplateType'] = self.summary_template_type
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('diyTemplateVersion') is not None:
            self.diy_template_version = m.get('diyTemplateVersion')
        if m.get('summaryTemplateId') is not None:
            self.summary_template_id = m.get('summaryTemplateId')
        if m.get('summaryTemplateType') is not None:
            self.summary_template_type = m.get('summaryTemplateType')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class QuerySummaryWithTemplateResponseBody(TeaModel):
    def __init__(
        self,
        summary_text: str = None,
    ):
        self.summary_text = summary_text

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.summary_text is not None:
            result['summaryText'] = self.summary_text
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('summaryText') is not None:
            self.summary_text = m.get('summaryText')
        return self


class QuerySummaryWithTemplateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QuerySummaryWithTemplateResponseBody = None,
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
            temp_model = QuerySummaryWithTemplateResponseBody()
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


class QueryUserAvailableDiyTemplatesHeaders(TeaModel):
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


class QueryUserAvailableDiyTemplatesRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        union_id: str = None,
    ):
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
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class QueryUserAvailableDiyTemplatesResponseBodyOrgDiyTemplates(TeaModel):
    def __init__(
        self,
        create_time: int = None,
        diy_template_brief_intro: str = None,
        diy_template_icon_url: str = None,
        diy_template_key: str = None,
        diy_template_latest_version: int = None,
        diy_template_source: str = None,
        diy_template_title: str = None,
        modified_time: int = None,
    ):
        self.create_time = create_time
        self.diy_template_brief_intro = diy_template_brief_intro
        self.diy_template_icon_url = diy_template_icon_url
        self.diy_template_key = diy_template_key
        self.diy_template_latest_version = diy_template_latest_version
        self.diy_template_source = diy_template_source
        self.diy_template_title = diy_template_title
        self.modified_time = modified_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.diy_template_brief_intro is not None:
            result['diyTemplateBriefIntro'] = self.diy_template_brief_intro
        if self.diy_template_icon_url is not None:
            result['diyTemplateIconUrl'] = self.diy_template_icon_url
        if self.diy_template_key is not None:
            result['diyTemplateKey'] = self.diy_template_key
        if self.diy_template_latest_version is not None:
            result['diyTemplateLatestVersion'] = self.diy_template_latest_version
        if self.diy_template_source is not None:
            result['diyTemplateSource'] = self.diy_template_source
        if self.diy_template_title is not None:
            result['diyTemplateTitle'] = self.diy_template_title
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('diyTemplateBriefIntro') is not None:
            self.diy_template_brief_intro = m.get('diyTemplateBriefIntro')
        if m.get('diyTemplateIconUrl') is not None:
            self.diy_template_icon_url = m.get('diyTemplateIconUrl')
        if m.get('diyTemplateKey') is not None:
            self.diy_template_key = m.get('diyTemplateKey')
        if m.get('diyTemplateLatestVersion') is not None:
            self.diy_template_latest_version = m.get('diyTemplateLatestVersion')
        if m.get('diyTemplateSource') is not None:
            self.diy_template_source = m.get('diyTemplateSource')
        if m.get('diyTemplateTitle') is not None:
            self.diy_template_title = m.get('diyTemplateTitle')
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        return self


class QueryUserAvailableDiyTemplatesResponseBodyUserDiyTemplates(TeaModel):
    def __init__(
        self,
        create_time: int = None,
        diy_template_brief_intro: str = None,
        diy_template_icon_url: str = None,
        diy_template_key: str = None,
        diy_template_latest_version: int = None,
        diy_template_source: str = None,
        diy_template_title: str = None,
        modified_time: int = None,
    ):
        self.create_time = create_time
        self.diy_template_brief_intro = diy_template_brief_intro
        self.diy_template_icon_url = diy_template_icon_url
        self.diy_template_key = diy_template_key
        self.diy_template_latest_version = diy_template_latest_version
        self.diy_template_source = diy_template_source
        self.diy_template_title = diy_template_title
        self.modified_time = modified_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.diy_template_brief_intro is not None:
            result['diyTemplateBriefIntro'] = self.diy_template_brief_intro
        if self.diy_template_icon_url is not None:
            result['diyTemplateIconUrl'] = self.diy_template_icon_url
        if self.diy_template_key is not None:
            result['diyTemplateKey'] = self.diy_template_key
        if self.diy_template_latest_version is not None:
            result['diyTemplateLatestVersion'] = self.diy_template_latest_version
        if self.diy_template_source is not None:
            result['diyTemplateSource'] = self.diy_template_source
        if self.diy_template_title is not None:
            result['diyTemplateTitle'] = self.diy_template_title
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('diyTemplateBriefIntro') is not None:
            self.diy_template_brief_intro = m.get('diyTemplateBriefIntro')
        if m.get('diyTemplateIconUrl') is not None:
            self.diy_template_icon_url = m.get('diyTemplateIconUrl')
        if m.get('diyTemplateKey') is not None:
            self.diy_template_key = m.get('diyTemplateKey')
        if m.get('diyTemplateLatestVersion') is not None:
            self.diy_template_latest_version = m.get('diyTemplateLatestVersion')
        if m.get('diyTemplateSource') is not None:
            self.diy_template_source = m.get('diyTemplateSource')
        if m.get('diyTemplateTitle') is not None:
            self.diy_template_title = m.get('diyTemplateTitle')
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        return self


class QueryUserAvailableDiyTemplatesResponseBody(TeaModel):
    def __init__(
        self,
        has_next: bool = None,
        next_token: str = None,
        org_diy_templates: List[QueryUserAvailableDiyTemplatesResponseBodyOrgDiyTemplates] = None,
        user_diy_templates: List[QueryUserAvailableDiyTemplatesResponseBodyUserDiyTemplates] = None,
    ):
        self.has_next = has_next
        self.next_token = next_token
        self.org_diy_templates = org_diy_templates
        self.user_diy_templates = user_diy_templates

    def validate(self):
        if self.org_diy_templates:
            for k in self.org_diy_templates:
                if k:
                    k.validate()
        if self.user_diy_templates:
            for k in self.user_diy_templates:
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
        result['orgDiyTemplates'] = []
        if self.org_diy_templates is not None:
            for k in self.org_diy_templates:
                result['orgDiyTemplates'].append(k.to_map() if k else None)
        result['userDiyTemplates'] = []
        if self.user_diy_templates is not None:
            for k in self.user_diy_templates:
                result['userDiyTemplates'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasNext') is not None:
            self.has_next = m.get('hasNext')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.org_diy_templates = []
        if m.get('orgDiyTemplates') is not None:
            for k in m.get('orgDiyTemplates'):
                temp_model = QueryUserAvailableDiyTemplatesResponseBodyOrgDiyTemplates()
                self.org_diy_templates.append(temp_model.from_map(k))
        self.user_diy_templates = []
        if m.get('userDiyTemplates') is not None:
            for k in m.get('userDiyTemplates'):
                temp_model = QueryUserAvailableDiyTemplatesResponseBodyUserDiyTemplates()
                self.user_diy_templates.append(temp_model.from_map(k))
        return self


class QueryUserAvailableDiyTemplatesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryUserAvailableDiyTemplatesResponseBody = None,
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
            temp_model = QueryUserAvailableDiyTemplatesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryUserMinutesPermissionHeaders(TeaModel):
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


class QueryUserMinutesPermissionResponseBody(TeaModel):
    def __init__(
        self,
        has_permission: bool = None,
        role_type: str = None,
    ):
        self.has_permission = has_permission
        # 角色类型：manager-管理员, owner-所有者, editor-可编辑, read_download-可查看/下载, read-仅查看, none-无权限
        self.role_type = role_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_permission is not None:
            result['hasPermission'] = self.has_permission
        if self.role_type is not None:
            result['roleType'] = self.role_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasPermission') is not None:
            self.has_permission = m.get('hasPermission')
        if m.get('roleType') is not None:
            self.role_type = m.get('roleType')
        return self


class QueryUserMinutesPermissionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryUserMinutesPermissionResponseBody = None,
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
            temp_model = QueryUserMinutesPermissionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RegenerateChaptersHeaders(TeaModel):
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


class RegenerateChaptersRequest(TeaModel):
    def __init__(
        self,
        custom_prompt: str = None,
        task_uuid: str = None,
        union_id: str = None,
    ):
        self.custom_prompt = custom_prompt
        # This parameter is required.
        self.task_uuid = task_uuid
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.custom_prompt is not None:
            result['customPrompt'] = self.custom_prompt
        if self.task_uuid is not None:
            result['taskUuid'] = self.task_uuid
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customPrompt') is not None:
            self.custom_prompt = m.get('customPrompt')
        if m.get('taskUuid') is not None:
            self.task_uuid = m.get('taskUuid')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class RegenerateChaptersResponseBody(TeaModel):
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


class RegenerateChaptersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RegenerateChaptersResponseBody = None,
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
            temp_model = RegenerateChaptersResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SetDetailPageCustomTabHeaders(TeaModel):
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


class SetDetailPageCustomTabRequestCustomTabList(TeaModel):
    def __init__(
        self,
        biz_type: str = None,
        default_locale: str = None,
        name_i18n_map: Dict[str, Any] = None,
        pc_url: str = None,
        url: str = None,
    ):
        # This parameter is required.
        self.biz_type = biz_type
        # This parameter is required.
        self.default_locale = default_locale
        # This parameter is required.
        self.name_i18n_map = name_i18n_map
        self.pc_url = pc_url
        # This parameter is required.
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.default_locale is not None:
            result['defaultLocale'] = self.default_locale
        if self.name_i18n_map is not None:
            result['nameI18nMap'] = self.name_i18n_map
        if self.pc_url is not None:
            result['pcUrl'] = self.pc_url
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('defaultLocale') is not None:
            self.default_locale = m.get('defaultLocale')
        if m.get('nameI18nMap') is not None:
            self.name_i18n_map = m.get('nameI18nMap')
        if m.get('pcUrl') is not None:
            self.pc_url = m.get('pcUrl')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class SetDetailPageCustomTabRequest(TeaModel):
    def __init__(
        self,
        custom_tab_list: List[SetDetailPageCustomTabRequestCustomTabList] = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.custom_tab_list = custom_tab_list
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        if self.custom_tab_list:
            for k in self.custom_tab_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['customTabList'] = []
        if self.custom_tab_list is not None:
            for k in self.custom_tab_list:
                result['customTabList'].append(k.to_map() if k else None)
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.custom_tab_list = []
        if m.get('customTabList') is not None:
            for k in m.get('customTabList'):
                temp_model = SetDetailPageCustomTabRequestCustomTabList()
                self.custom_tab_list.append(temp_model.from_map(k))
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class SetDetailPageCustomTabResponseBody(TeaModel):
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


class SetDetailPageCustomTabResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SetDetailPageCustomTabResponseBody = None,
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
            temp_model = SetDetailPageCustomTabResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SetInProgressCustomTabsHeaders(TeaModel):
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


class SetInProgressCustomTabsRequestCustomTabList(TeaModel):
    def __init__(
        self,
        biz_type: str = None,
        default_locale: str = None,
        name_i18n_map: Dict[str, Any] = None,
        pc_url: str = None,
        tab_id: str = None,
        url: str = None,
    ):
        # This parameter is required.
        self.biz_type = biz_type
        # This parameter is required.
        self.default_locale = default_locale
        # This parameter is required.
        self.name_i18n_map = name_i18n_map
        self.pc_url = pc_url
        self.tab_id = tab_id
        # This parameter is required.
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.default_locale is not None:
            result['defaultLocale'] = self.default_locale
        if self.name_i18n_map is not None:
            result['nameI18nMap'] = self.name_i18n_map
        if self.pc_url is not None:
            result['pcUrl'] = self.pc_url
        if self.tab_id is not None:
            result['tabId'] = self.tab_id
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('defaultLocale') is not None:
            self.default_locale = m.get('defaultLocale')
        if m.get('nameI18nMap') is not None:
            self.name_i18n_map = m.get('nameI18nMap')
        if m.get('pcUrl') is not None:
            self.pc_url = m.get('pcUrl')
        if m.get('tabId') is not None:
            self.tab_id = m.get('tabId')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class SetInProgressCustomTabsRequest(TeaModel):
    def __init__(
        self,
        custom_tab_list: List[SetInProgressCustomTabsRequestCustomTabList] = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.custom_tab_list = custom_tab_list
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        if self.custom_tab_list:
            for k in self.custom_tab_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['customTabList'] = []
        if self.custom_tab_list is not None:
            for k in self.custom_tab_list:
                result['customTabList'].append(k.to_map() if k else None)
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.custom_tab_list = []
        if m.get('customTabList') is not None:
            for k in m.get('customTabList'):
                temp_model = SetInProgressCustomTabsRequestCustomTabList()
                self.custom_tab_list.append(temp_model.from_map(k))
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class SetInProgressCustomTabsResponseBody(TeaModel):
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


class SetInProgressCustomTabsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SetInProgressCustomTabsResponseBody = None,
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
            temp_model = SetInProgressCustomTabsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SetMinutesTodosVisibleHeaders(TeaModel):
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


class SetMinutesTodosVisibleRequest(TeaModel):
    def __init__(
        self,
        todos_visible: bool = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.todos_visible = todos_visible
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.todos_visible is not None:
            result['todosVisible'] = self.todos_visible
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('todosVisible') is not None:
            self.todos_visible = m.get('todosVisible')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class SetMinutesTodosVisibleResponseBody(TeaModel):
    def __init__(
        self,
        task_uuid: str = None,
        todos_visible: bool = None,
    ):
        self.task_uuid = task_uuid
        self.todos_visible = todos_visible

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.task_uuid is not None:
            result['taskUuid'] = self.task_uuid
        if self.todos_visible is not None:
            result['todosVisible'] = self.todos_visible
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('taskUuid') is not None:
            self.task_uuid = m.get('taskUuid')
        if m.get('todosVisible') is not None:
            self.todos_visible = m.get('todosVisible')
        return self


class SetMinutesTodosVisibleResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SetMinutesTodosVisibleResponseBody = None,
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
            temp_model = SetMinutesTodosVisibleResponseBody()
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


class UpdatePermissionHeaders(TeaModel):
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


class UpdatePermissionRequestMemberInfoList(TeaModel):
    def __init__(
        self,
        member_type: int = None,
        member_union_id: str = None,
        policy_id: int = None,
    ):
        self.member_type = member_type
        self.member_union_id = member_union_id
        self.policy_id = policy_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.member_type is not None:
            result['memberType'] = self.member_type
        if self.member_union_id is not None:
            result['memberUnionId'] = self.member_union_id
        if self.policy_id is not None:
            result['policyId'] = self.policy_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('memberType') is not None:
            self.member_type = m.get('memberType')
        if m.get('memberUnionId') is not None:
            self.member_union_id = m.get('memberUnionId')
        if m.get('policyId') is not None:
            self.policy_id = m.get('policyId')
        return self


class UpdatePermissionRequest(TeaModel):
    def __init__(
        self,
        member_info_list: List[UpdatePermissionRequestMemberInfoList] = None,
        op_type: int = None,
        role_code: str = None,
        role_sub_resource_ids: List[str] = None,
        share_scope: int = None,
        union_id: str = None,
    ):
        self.member_info_list = member_info_list
        self.op_type = op_type
        self.role_code = role_code
        self.role_sub_resource_ids = role_sub_resource_ids
        self.share_scope = share_scope
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        if self.member_info_list:
            for k in self.member_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['memberInfoList'] = []
        if self.member_info_list is not None:
            for k in self.member_info_list:
                result['memberInfoList'].append(k.to_map() if k else None)
        if self.op_type is not None:
            result['opType'] = self.op_type
        if self.role_code is not None:
            result['roleCode'] = self.role_code
        if self.role_sub_resource_ids is not None:
            result['roleSubResourceIds'] = self.role_sub_resource_ids
        if self.share_scope is not None:
            result['shareScope'] = self.share_scope
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.member_info_list = []
        if m.get('memberInfoList') is not None:
            for k in m.get('memberInfoList'):
                temp_model = UpdatePermissionRequestMemberInfoList()
                self.member_info_list.append(temp_model.from_map(k))
        if m.get('opType') is not None:
            self.op_type = m.get('opType')
        if m.get('roleCode') is not None:
            self.role_code = m.get('roleCode')
        if m.get('roleSubResourceIds') is not None:
            self.role_sub_resource_ids = m.get('roleSubResourceIds')
        if m.get('shareScope') is not None:
            self.share_scope = m.get('shareScope')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class UpdatePermissionResponseBodyFailMemberInfoList(TeaModel):
    def __init__(
        self,
        member_type: int = None,
        member_union_id: str = None,
        policy_id: int = None,
    ):
        self.member_type = member_type
        self.member_union_id = member_union_id
        self.policy_id = policy_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.member_type is not None:
            result['memberType'] = self.member_type
        if self.member_union_id is not None:
            result['memberUnionId'] = self.member_union_id
        if self.policy_id is not None:
            result['policyId'] = self.policy_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('memberType') is not None:
            self.member_type = m.get('memberType')
        if m.get('memberUnionId') is not None:
            self.member_union_id = m.get('memberUnionId')
        if m.get('policyId') is not None:
            self.policy_id = m.get('policyId')
        return self


class UpdatePermissionResponseBody(TeaModel):
    def __init__(
        self,
        fail_member_info_list: List[UpdatePermissionResponseBodyFailMemberInfoList] = None,
    ):
        self.fail_member_info_list = fail_member_info_list

    def validate(self):
        if self.fail_member_info_list:
            for k in self.fail_member_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['failMemberInfoList'] = []
        if self.fail_member_info_list is not None:
            for k in self.fail_member_info_list:
                result['failMemberInfoList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.fail_member_info_list = []
        if m.get('failMemberInfoList') is not None:
            for k in m.get('failMemberInfoList'):
                temp_model = UpdatePermissionResponseBodyFailMemberInfoList()
                self.fail_member_info_list.append(temp_model.from_map(k))
        return self


class UpdatePermissionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdatePermissionResponseBody = None,
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
            temp_model = UpdatePermissionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


