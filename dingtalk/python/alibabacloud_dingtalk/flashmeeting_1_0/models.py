# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class CreateFlashMeetingHeaders(TeaModel):
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


class CreateFlashMeetingRequest(TeaModel):
    def __init__(
        self,
        creator: str = None,
        event_id: str = None,
        title: str = None,
    ):
        # This parameter is required.
        self.creator = creator
        # This parameter is required.
        self.event_id = event_id
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.creator is not None:
            result['creator'] = self.creator
        if self.event_id is not None:
            result['eventId'] = self.event_id
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('creator') is not None:
            self.creator = m.get('creator')
        if m.get('eventId') is not None:
            self.event_id = m.get('eventId')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class CreateFlashMeetingResponseBody(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        flash_meeting_key: str = None,
        start_time: int = None,
        title: str = None,
        url: str = None,
    ):
        # This parameter is required.
        self.end_time = end_time
        # This parameter is required.
        self.flash_meeting_key = flash_meeting_key
        # This parameter is required.
        self.start_time = start_time
        # This parameter is required.
        self.title = title
        # This parameter is required.
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.flash_meeting_key is not None:
            result['flashMeetingKey'] = self.flash_meeting_key
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.title is not None:
            result['title'] = self.title
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('flashMeetingKey') is not None:
            self.flash_meeting_key = m.get('flashMeetingKey')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class CreateFlashMeetingResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateFlashMeetingResponseBody = None,
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
            temp_model = CreateFlashMeetingResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetShanhuiByCalendarHeaders(TeaModel):
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


class GetShanhuiByCalendarRequest(TeaModel):
    def __init__(
        self,
        event_id: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.event_id = event_id
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.event_id is not None:
            result['eventId'] = self.event_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('eventId') is not None:
            self.event_id = m.get('eventId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetShanhuiByCalendarResponseBodyResultTopics(TeaModel):
    def __init__(
        self,
        doc_key: str = None,
        title: str = None,
    ):
        self.doc_key = doc_key
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.doc_key is not None:
            result['docKey'] = self.doc_key
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('docKey') is not None:
            self.doc_key = m.get('docKey')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class GetShanhuiByCalendarResponseBodyResult(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        flashmeeting_key: str = None,
        has_summary: bool = None,
        start_time: int = None,
        summary_doc_key: str = None,
        title: str = None,
        topics: List[GetShanhuiByCalendarResponseBodyResultTopics] = None,
    ):
        self.end_time = end_time
        # This parameter is required.
        self.flashmeeting_key = flashmeeting_key
        self.has_summary = has_summary
        self.start_time = start_time
        self.summary_doc_key = summary_doc_key
        self.title = title
        self.topics = topics

    def validate(self):
        if self.topics:
            for k in self.topics:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.flashmeeting_key is not None:
            result['flashmeetingKey'] = self.flashmeeting_key
        if self.has_summary is not None:
            result['hasSummary'] = self.has_summary
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.summary_doc_key is not None:
            result['summaryDocKey'] = self.summary_doc_key
        if self.title is not None:
            result['title'] = self.title
        result['topics'] = []
        if self.topics is not None:
            for k in self.topics:
                result['topics'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('flashmeetingKey') is not None:
            self.flashmeeting_key = m.get('flashmeetingKey')
        if m.get('hasSummary') is not None:
            self.has_summary = m.get('hasSummary')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('summaryDocKey') is not None:
            self.summary_doc_key = m.get('summaryDocKey')
        if m.get('title') is not None:
            self.title = m.get('title')
        self.topics = []
        if m.get('topics') is not None:
            for k in m.get('topics'):
                temp_model = GetShanhuiByCalendarResponseBodyResultTopics()
                self.topics.append(temp_model.from_map(k))
        return self


class GetShanhuiByCalendarResponseBody(TeaModel):
    def __init__(
        self,
        result: GetShanhuiByCalendarResponseBodyResult = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = GetShanhuiByCalendarResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetShanhuiByCalendarResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetShanhuiByCalendarResponseBody = None,
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
            temp_model = GetShanhuiByCalendarResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetShanhuiByShanhuiKeyHeaders(TeaModel):
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


class GetShanhuiByShanhuiKeyResponseBodyResultTopics(TeaModel):
    def __init__(
        self,
        doc_key: str = None,
        title: str = None,
    ):
        # This parameter is required.
        self.doc_key = doc_key
        # This parameter is required.
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.doc_key is not None:
            result['docKey'] = self.doc_key
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('docKey') is not None:
            self.doc_key = m.get('docKey')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class GetShanhuiByShanhuiKeyResponseBodyResult(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        event_id: str = None,
        flashmeeting_key: str = None,
        has_summary: bool = None,
        start_time: int = None,
        summary_doc_key: str = None,
        title: str = None,
        topics: List[GetShanhuiByShanhuiKeyResponseBodyResultTopics] = None,
    ):
        self.end_time = end_time
        self.event_id = event_id
        self.flashmeeting_key = flashmeeting_key
        self.has_summary = has_summary
        self.start_time = start_time
        self.summary_doc_key = summary_doc_key
        self.title = title
        self.topics = topics

    def validate(self):
        if self.topics:
            for k in self.topics:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.event_id is not None:
            result['eventId'] = self.event_id
        if self.flashmeeting_key is not None:
            result['flashmeetingKey'] = self.flashmeeting_key
        if self.has_summary is not None:
            result['hasSummary'] = self.has_summary
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.summary_doc_key is not None:
            result['summaryDocKey'] = self.summary_doc_key
        if self.title is not None:
            result['title'] = self.title
        result['topics'] = []
        if self.topics is not None:
            for k in self.topics:
                result['topics'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('eventId') is not None:
            self.event_id = m.get('eventId')
        if m.get('flashmeetingKey') is not None:
            self.flashmeeting_key = m.get('flashmeetingKey')
        if m.get('hasSummary') is not None:
            self.has_summary = m.get('hasSummary')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('summaryDocKey') is not None:
            self.summary_doc_key = m.get('summaryDocKey')
        if m.get('title') is not None:
            self.title = m.get('title')
        self.topics = []
        if m.get('topics') is not None:
            for k in m.get('topics'):
                temp_model = GetShanhuiByShanhuiKeyResponseBodyResultTopics()
                self.topics.append(temp_model.from_map(k))
        return self


class GetShanhuiByShanhuiKeyResponseBody(TeaModel):
    def __init__(
        self,
        result: GetShanhuiByShanhuiKeyResponseBodyResult = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = GetShanhuiByShanhuiKeyResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetShanhuiByShanhuiKeyResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetShanhuiByShanhuiKeyResponseBody = None,
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
            temp_model = GetShanhuiByShanhuiKeyResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetTaskFromShanhuiDocHeaders(TeaModel):
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


class GetTaskFromShanhuiDocRequest(TeaModel):
    def __init__(
        self,
        doc_key: str = None,
        max_results: int = None,
        next_token: int = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.doc_key = doc_key
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
        if self.doc_key is not None:
            result['docKey'] = self.doc_key
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('docKey') is not None:
            self.doc_key = m.get('docKey')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetTaskFromShanhuiDocResponseBodyResultItems(TeaModel):
    def __init__(
        self,
        create_time: int = None,
        deadline: int = None,
        deleted: bool = None,
        priority: int = None,
        task_key: str = None,
        task_status: str = None,
        task_type: str = None,
        title: str = None,
        update_time: int = None,
    ):
        self.create_time = create_time
        self.deadline = deadline
        self.deleted = deleted
        self.priority = priority
        self.task_key = task_key
        self.task_status = task_status
        self.task_type = task_type
        self.title = title
        self.update_time = update_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.deadline is not None:
            result['deadline'] = self.deadline
        if self.deleted is not None:
            result['deleted'] = self.deleted
        if self.priority is not None:
            result['priority'] = self.priority
        if self.task_key is not None:
            result['taskKey'] = self.task_key
        if self.task_status is not None:
            result['taskStatus'] = self.task_status
        if self.task_type is not None:
            result['taskType'] = self.task_type
        if self.title is not None:
            result['title'] = self.title
        if self.update_time is not None:
            result['updateTime'] = self.update_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('deadline') is not None:
            self.deadline = m.get('deadline')
        if m.get('deleted') is not None:
            self.deleted = m.get('deleted')
        if m.get('priority') is not None:
            self.priority = m.get('priority')
        if m.get('taskKey') is not None:
            self.task_key = m.get('taskKey')
        if m.get('taskStatus') is not None:
            self.task_status = m.get('taskStatus')
        if m.get('taskType') is not None:
            self.task_type = m.get('taskType')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('updateTime') is not None:
            self.update_time = m.get('updateTime')
        return self


class GetTaskFromShanhuiDocResponseBodyResult(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        items: List[GetTaskFromShanhuiDocResponseBodyResultItems] = None,
        next_token: str = None,
        total: int = None,
    ):
        self.has_more = has_more
        self.items = items
        self.next_token = next_token
        self.total = total

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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.items = []
        if m.get('items') is not None:
            for k in m.get('items'):
                temp_model = GetTaskFromShanhuiDocResponseBodyResultItems()
                self.items.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class GetTaskFromShanhuiDocResponseBody(TeaModel):
    def __init__(
        self,
        result: GetTaskFromShanhuiDocResponseBodyResult = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

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
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = GetTaskFromShanhuiDocResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetTaskFromShanhuiDocResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetTaskFromShanhuiDocResponseBody = None,
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
            temp_model = GetTaskFromShanhuiDocResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


