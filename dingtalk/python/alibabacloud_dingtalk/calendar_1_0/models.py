# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List, Any


class DeleteEventHeaders(TeaModel):
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


class DeleteEventResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        return self


class RespondEventHeaders(TeaModel):
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


class RespondEventRequest(TeaModel):
    def __init__(
        self,
        response_status: str = None,
    ):
        self.response_status = response_status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.response_status is not None:
            result['responseStatus'] = self.response_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('responseStatus') is not None:
            self.response_status = m.get('responseStatus')
        return self


class RespondEventResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        return self


class ListEventsHeaders(TeaModel):
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


class ListEventsRequest(TeaModel):
    def __init__(
        self,
        time_min: str = None,
        time_max: str = None,
        show_deleted: bool = None,
        max_results: int = None,
        next_token: str = None,
        sync_token: str = None,
    ):
        # 查询开始时间
        self.time_min = time_min
        # 查询截止时间
        self.time_max = time_max
        # 是否返回删除事件
        self.show_deleted = show_deleted
        # 查询返回结果数
        self.max_results = max_results
        # 查询翻页token
        self.next_token = next_token
        # 增量查询token
        self.sync_token = sync_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.time_min is not None:
            result['timeMin'] = self.time_min
        if self.time_max is not None:
            result['timeMax'] = self.time_max
        if self.show_deleted is not None:
            result['showDeleted'] = self.show_deleted
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.sync_token is not None:
            result['syncToken'] = self.sync_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('timeMin') is not None:
            self.time_min = m.get('timeMin')
        if m.get('timeMax') is not None:
            self.time_max = m.get('timeMax')
        if m.get('showDeleted') is not None:
            self.show_deleted = m.get('showDeleted')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('syncToken') is not None:
            self.sync_token = m.get('syncToken')
        return self


class ListEventsResponseBodyEventsStart(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        # 日期，格式：yyyyMMdd
        self.date = date
        # 时间戳，按照ISO 8601格式
        self.date_time = date_time
        # 时区
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class ListEventsResponseBodyEventsEnd(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        self.date = date
        self.date_time = date_time
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class ListEventsResponseBodyEventsRecurrencePattern(TeaModel):
    def __init__(
        self,
        type: str = None,
        day_of_month: int = None,
        days_of_week: str = None,
        index: str = None,
        interval: int = None,
    ):
        # 循环模式类型(type: daily, weekly, absoluteMonthly, relativeMonthly, absoluteYearly, relativeYearly)
        self.type = type
        self.day_of_month = day_of_month
        self.days_of_week = days_of_week
        self.index = index
        self.interval = interval

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        if self.days_of_week is not None:
            result['daysOfWeek'] = self.days_of_week
        if self.index is not None:
            result['index'] = self.index
        if self.interval is not None:
            result['interval'] = self.interval
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        if m.get('daysOfWeek') is not None:
            self.days_of_week = m.get('daysOfWeek')
        if m.get('index') is not None:
            self.index = m.get('index')
        if m.get('interval') is not None:
            self.interval = m.get('interval')
        return self


class ListEventsResponseBodyEventsRecurrenceRange(TeaModel):
    def __init__(
        self,
        type: str = None,
        end_date: str = None,
        number_of_occurrences: int = None,
    ):
        # 范围类型(endDate, noEnd, numbered)
        self.type = type
        self.end_date = end_date
        self.number_of_occurrences = number_of_occurrences

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.number_of_occurrences is not None:
            result['numberOfOccurrences'] = self.number_of_occurrences
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('numberOfOccurrences') is not None:
            self.number_of_occurrences = m.get('numberOfOccurrences')
        return self


class ListEventsResponseBodyEventsRecurrence(TeaModel):
    def __init__(
        self,
        pattern: ListEventsResponseBodyEventsRecurrencePattern = None,
        range: ListEventsResponseBodyEventsRecurrenceRange = None,
    ):
        # 重复模式
        self.pattern = pattern
        # 重复范围
        self.range = range

    def validate(self):
        if self.pattern:
            self.pattern.validate()
        if self.range:
            self.range.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.pattern is not None:
            result['pattern'] = self.pattern.to_map()
        if self.range is not None:
            result['range'] = self.range.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pattern') is not None:
            temp_model = ListEventsResponseBodyEventsRecurrencePattern()
            self.pattern = temp_model.from_map(m['pattern'])
        if m.get('range') is not None:
            temp_model = ListEventsResponseBodyEventsRecurrenceRange()
            self.range = temp_model.from_map(m['range'])
        return self


class ListEventsResponseBodyEventsAttendees(TeaModel):
    def __init__(
        self,
        id: str = None,
        display_name: str = None,
        response_status: str = None,
        self_: bool = None,
    ):
        # 用户id
        self.id = id
        # 用户名
        self.display_name = display_name
        # 回复状态
        self.response_status = response_status
        # 是否是当前登陆用户
        self.self_ = self_

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.response_status is not None:
            result['responseStatus'] = self.response_status
        if self.self_ is not None:
            result['self'] = self.self_
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('responseStatus') is not None:
            self.response_status = m.get('responseStatus')
        if m.get('self') is not None:
            self.self_ = m.get('self')
        return self


class ListEventsResponseBodyEventsOrganizer(TeaModel):
    def __init__(
        self,
        id: str = None,
        display_name: str = None,
        response_status: str = None,
        self_: bool = None,
    ):
        # 用户id
        self.id = id
        # 用户名
        self.display_name = display_name
        # 回复状态
        self.response_status = response_status
        # 是否是当前登陆用户
        self.self_ = self_

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.response_status is not None:
            result['responseStatus'] = self.response_status
        if self.self_ is not None:
            result['self'] = self.self_
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('responseStatus') is not None:
            self.response_status = m.get('responseStatus')
        if m.get('self') is not None:
            self.self_ = m.get('self')
        return self


class ListEventsResponseBodyEventsLocation(TeaModel):
    def __init__(
        self,
        display_name: str = None,
    ):
        # 展示名称
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        return self


class ListEventsResponseBodyEvents(TeaModel):
    def __init__(
        self,
        id: str = None,
        summary: str = None,
        description: str = None,
        start: ListEventsResponseBodyEventsStart = None,
        end: ListEventsResponseBodyEventsEnd = None,
        is_all_day: bool = None,
        recurrence: ListEventsResponseBodyEventsRecurrence = None,
        attendees: List[ListEventsResponseBodyEventsAttendees] = None,
        organizer: ListEventsResponseBodyEventsOrganizer = None,
        location: ListEventsResponseBodyEventsLocation = None,
        series_master_id: str = None,
        create_time: str = None,
        update_time: str = None,
        status: str = None,
    ):
        # 日程事件id
        self.id = id
        # 日程标题
        self.summary = summary
        # 日程描述
        self.description = description
        # 日程开始时间
        self.start = start
        # 日程结束时间
        self.end = end
        # 是否为全天日程
        self.is_all_day = is_all_day
        # 日程重复规则
        self.recurrence = recurrence
        # 日程参与人
        self.attendees = attendees
        # 日程组织人
        self.organizer = organizer
        # 日程地点
        self.location = location
        # 重复日程的主日程id，非重复日程为空
        self.series_master_id = series_master_id
        # 创建时间
        self.create_time = create_time
        # 更新时间
        self.update_time = update_time
        # 日程状态
        self.status = status

    def validate(self):
        if self.start:
            self.start.validate()
        if self.end:
            self.end.validate()
        if self.recurrence:
            self.recurrence.validate()
        if self.attendees:
            for k in self.attendees:
                if k:
                    k.validate()
        if self.organizer:
            self.organizer.validate()
        if self.location:
            self.location.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.summary is not None:
            result['summary'] = self.summary
        if self.description is not None:
            result['description'] = self.description
        if self.start is not None:
            result['start'] = self.start.to_map()
        if self.end is not None:
            result['end'] = self.end.to_map()
        if self.is_all_day is not None:
            result['isAllDay'] = self.is_all_day
        if self.recurrence is not None:
            result['recurrence'] = self.recurrence.to_map()
        result['attendees'] = []
        if self.attendees is not None:
            for k in self.attendees:
                result['attendees'].append(k.to_map() if k else None)
        if self.organizer is not None:
            result['organizer'] = self.organizer.to_map()
        if self.location is not None:
            result['location'] = self.location.to_map()
        if self.series_master_id is not None:
            result['seriesMasterId'] = self.series_master_id
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.update_time is not None:
            result['updateTime'] = self.update_time
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('summary') is not None:
            self.summary = m.get('summary')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('start') is not None:
            temp_model = ListEventsResponseBodyEventsStart()
            self.start = temp_model.from_map(m['start'])
        if m.get('end') is not None:
            temp_model = ListEventsResponseBodyEventsEnd()
            self.end = temp_model.from_map(m['end'])
        if m.get('isAllDay') is not None:
            self.is_all_day = m.get('isAllDay')
        if m.get('recurrence') is not None:
            temp_model = ListEventsResponseBodyEventsRecurrence()
            self.recurrence = temp_model.from_map(m['recurrence'])
        self.attendees = []
        if m.get('attendees') is not None:
            for k in m.get('attendees'):
                temp_model = ListEventsResponseBodyEventsAttendees()
                self.attendees.append(temp_model.from_map(k))
        if m.get('organizer') is not None:
            temp_model = ListEventsResponseBodyEventsOrganizer()
            self.organizer = temp_model.from_map(m['organizer'])
        if m.get('location') is not None:
            temp_model = ListEventsResponseBodyEventsLocation()
            self.location = temp_model.from_map(m['location'])
        if m.get('seriesMasterId') is not None:
            self.series_master_id = m.get('seriesMasterId')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('updateTime') is not None:
            self.update_time = m.get('updateTime')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class ListEventsResponseBody(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        events: List[ListEventsResponseBodyEvents] = None,
        sync_token: str = None,
    ):
        # 翻页token
        self.next_token = next_token
        # 日程
        self.events = events
        # 增量同步token
        self.sync_token = sync_token

    def validate(self):
        if self.events:
            for k in self.events:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['events'] = []
        if self.events is not None:
            for k in self.events:
                result['events'].append(k.to_map() if k else None)
        if self.sync_token is not None:
            result['syncToken'] = self.sync_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.events = []
        if m.get('events') is not None:
            for k in m.get('events'):
                temp_model = ListEventsResponseBodyEvents()
                self.events.append(temp_model.from_map(k))
        if m.get('syncToken') is not None:
            self.sync_token = m.get('syncToken')
        return self


class ListEventsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListEventsResponseBody = None,
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
            temp_model = ListEventsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GenerateCaldavAccountHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        ding_uid: str = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        # 授权本次调用的用户id，该字段有值时认为本次调用已被授权访问该用户可以访问的所有数据
        self.ding_uid = ding_uid
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
        if self.ding_uid is not None:
            result['dingUid'] = self.ding_uid
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('dingUid') is not None:
            self.ding_uid = m.get('dingUid')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GenerateCaldavAccountRequest(TeaModel):
    def __init__(
        self,
        device: str = None,
    ):
        # 设备名称
        self.device = device

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device is not None:
            result['device'] = self.device
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('device') is not None:
            self.device = m.get('device')
        return self


class GenerateCaldavAccountResponseBody(TeaModel):
    def __init__(
        self,
        server_address: str = None,
        username: str = None,
        password: str = None,
    ):
        self.server_address = server_address
        self.username = username
        self.password = password

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.server_address is not None:
            result['serverAddress'] = self.server_address
        if self.username is not None:
            result['username'] = self.username
        if self.password is not None:
            result['password'] = self.password
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('serverAddress') is not None:
            self.server_address = m.get('serverAddress')
        if m.get('username') is not None:
            self.username = m.get('username')
        if m.get('password') is not None:
            self.password = m.get('password')
        return self


class GenerateCaldavAccountResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GenerateCaldavAccountResponseBody = None,
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
            temp_model = GenerateCaldavAccountResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetScheduleHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        ding_org_id: str = None,
        ding_uid: str = None,
        ding_access_token_type: str = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        # 授权本次调用的企业id，该字段有值时认为本次调用已被授权访问该企业下的所有数据
        self.ding_org_id = ding_org_id
        # 授权本次调用的用户id，该字段有值时认为本次调用已被授权访问该用户可以访问的所有数据
        self.ding_uid = ding_uid
        # 授权类型
        self.ding_access_token_type = ding_access_token_type
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
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_uid is not None:
            result['dingUid'] = self.ding_uid
        if self.ding_access_token_type is not None:
            result['dingAccessTokenType'] = self.ding_access_token_type
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingUid') is not None:
            self.ding_uid = m.get('dingUid')
        if m.get('dingAccessTokenType') is not None:
            self.ding_access_token_type = m.get('dingAccessTokenType')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetScheduleRequest(TeaModel):
    def __init__(
        self,
        user_ids: List[str] = None,
        start_time: str = None,
        end_time: str = None,
    ):
        self.user_ids = user_ids
        self.start_time = start_time
        self.end_time = end_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.end_time is not None:
            result['endTime'] = self.end_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        return self


class GetScheduleResponseBodyScheduleInformationScheduleItemsStart(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        self.date = date
        self.date_time = date_time
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class GetScheduleResponseBodyScheduleInformationScheduleItemsEnd(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        self.date = date
        self.date_time = date_time
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class GetScheduleResponseBodyScheduleInformationScheduleItems(TeaModel):
    def __init__(
        self,
        status: str = None,
        start: GetScheduleResponseBodyScheduleInformationScheduleItemsStart = None,
        end: GetScheduleResponseBodyScheduleInformationScheduleItemsEnd = None,
    ):
        self.status = status
        self.start = start
        self.end = end

    def validate(self):
        if self.start:
            self.start.validate()
        if self.end:
            self.end.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.status is not None:
            result['status'] = self.status
        if self.start is not None:
            result['start'] = self.start.to_map()
        if self.end is not None:
            result['end'] = self.end.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('start') is not None:
            temp_model = GetScheduleResponseBodyScheduleInformationScheduleItemsStart()
            self.start = temp_model.from_map(m['start'])
        if m.get('end') is not None:
            temp_model = GetScheduleResponseBodyScheduleInformationScheduleItemsEnd()
            self.end = temp_model.from_map(m['end'])
        return self


class GetScheduleResponseBodyScheduleInformation(TeaModel):
    def __init__(
        self,
        user_id: str = None,
        error: str = None,
        schedule_items: List[GetScheduleResponseBodyScheduleInformationScheduleItems] = None,
    ):
        self.user_id = user_id
        self.error = error
        self.schedule_items = schedule_items

    def validate(self):
        if self.schedule_items:
            for k in self.schedule_items:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.error is not None:
            result['error'] = self.error
        result['scheduleItems'] = []
        if self.schedule_items is not None:
            for k in self.schedule_items:
                result['scheduleItems'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('error') is not None:
            self.error = m.get('error')
        self.schedule_items = []
        if m.get('scheduleItems') is not None:
            for k in m.get('scheduleItems'):
                temp_model = GetScheduleResponseBodyScheduleInformationScheduleItems()
                self.schedule_items.append(temp_model.from_map(k))
        return self


class GetScheduleResponseBody(TeaModel):
    def __init__(
        self,
        schedule_information: List[GetScheduleResponseBodyScheduleInformation] = None,
    ):
        self.schedule_information = schedule_information

    def validate(self):
        if self.schedule_information:
            for k in self.schedule_information:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['scheduleInformation'] = []
        if self.schedule_information is not None:
            for k in self.schedule_information:
                result['scheduleInformation'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.schedule_information = []
        if m.get('scheduleInformation') is not None:
            for k in m.get('scheduleInformation'):
                temp_model = GetScheduleResponseBodyScheduleInformation()
                self.schedule_information.append(temp_model.from_map(k))
        return self


class GetScheduleResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetScheduleResponseBody = None,
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
            temp_model = GetScheduleResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ConvertLegacyEventIdHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        ding_org_id: str = None,
        ding_uid: str = None,
        ding_access_token_type: str = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        # 授权本次调用的企业id，该字段有值时认为本次调用已被授权访问该企业下的所有数据
        self.ding_org_id = ding_org_id
        # 授权本次调用的用户id，该字段有值时认为本次调用已被授权访问该用户可以访问的所有数据
        self.ding_uid = ding_uid
        # 授权类型
        self.ding_access_token_type = ding_access_token_type
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
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_uid is not None:
            result['dingUid'] = self.ding_uid
        if self.ding_access_token_type is not None:
            result['dingAccessTokenType'] = self.ding_access_token_type
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingUid') is not None:
            self.ding_uid = m.get('dingUid')
        if m.get('dingAccessTokenType') is not None:
            self.ding_access_token_type = m.get('dingAccessTokenType')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class ConvertLegacyEventIdRequest(TeaModel):
    def __init__(
        self,
        legacy_event_ids: Dict[str, str] = None,
    ):
        self.legacy_event_ids = legacy_event_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.legacy_event_ids is not None:
            result['legacyEventIds'] = self.legacy_event_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('legacyEventIds') is not None:
            self.legacy_event_ids = m.get('legacyEventIds')
        return self


class ConvertLegacyEventIdResponseBody(TeaModel):
    def __init__(
        self,
        legacy_event_id_map: Dict[str, Any] = None,
    ):
        # legacyEventIdMap
        self.legacy_event_id_map = legacy_event_id_map

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.legacy_event_id_map is not None:
            result['legacyEventIdMap'] = self.legacy_event_id_map
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('legacyEventIdMap') is not None:
            self.legacy_event_id_map = m.get('legacyEventIdMap')
        return self


class ConvertLegacyEventIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ConvertLegacyEventIdResponseBody = None,
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
            temp_model = ConvertLegacyEventIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RemoveAttendeeHeaders(TeaModel):
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


class RemoveAttendeeRequestAttendeesToRemove(TeaModel):
    def __init__(
        self,
        id: str = None,
    ):
        self.id = id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        return self


class RemoveAttendeeRequest(TeaModel):
    def __init__(
        self,
        attendees_to_remove: List[RemoveAttendeeRequestAttendeesToRemove] = None,
    ):
        self.attendees_to_remove = attendees_to_remove

    def validate(self):
        if self.attendees_to_remove:
            for k in self.attendees_to_remove:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['attendeesToRemove'] = []
        if self.attendees_to_remove is not None:
            for k in self.attendees_to_remove:
                result['attendeesToRemove'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attendees_to_remove = []
        if m.get('attendeesToRemove') is not None:
            for k in m.get('attendeesToRemove'):
                temp_model = RemoveAttendeeRequestAttendeesToRemove()
                self.attendees_to_remove.append(temp_model.from_map(k))
        return self


class RemoveAttendeeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        return self


class AddAttendeeHeaders(TeaModel):
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


class AddAttendeeRequestAttendeesToAdd(TeaModel):
    def __init__(
        self,
        id: str = None,
    ):
        self.id = id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        return self


class AddAttendeeRequest(TeaModel):
    def __init__(
        self,
        attendees_to_add: List[AddAttendeeRequestAttendeesToAdd] = None,
    ):
        self.attendees_to_add = attendees_to_add

    def validate(self):
        if self.attendees_to_add:
            for k in self.attendees_to_add:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['attendeesToAdd'] = []
        if self.attendees_to_add is not None:
            for k in self.attendees_to_add:
                result['attendeesToAdd'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attendees_to_add = []
        if m.get('attendeesToAdd') is not None:
            for k in m.get('attendeesToAdd'):
                temp_model = AddAttendeeRequestAttendeesToAdd()
                self.attendees_to_add.append(temp_model.from_map(k))
        return self


class AddAttendeeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
    ):
        self.headers = headers

    def validate(self):
        self.validate_required(self.headers, 'headers')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        return self


class GetEventHeaders(TeaModel):
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


class GetEventResponseBodyStart(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        # 日期，格式：yyyyMMdd
        self.date = date
        # 时间戳，按照ISO 8601格式
        self.date_time = date_time
        # 时区
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class GetEventResponseBodyEnd(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        self.date = date
        self.date_time = date_time
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class GetEventResponseBodyRecurrencePattern(TeaModel):
    def __init__(
        self,
        type: str = None,
        day_of_month: int = None,
        days_of_week: str = None,
        index: str = None,
        interval: int = None,
    ):
        # 循环模式类型(type: daily, weekly, absoluteMonthly, relativeMonthly, absoluteYearly, relativeYearly)
        self.type = type
        self.day_of_month = day_of_month
        self.days_of_week = days_of_week
        self.index = index
        self.interval = interval

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        if self.days_of_week is not None:
            result['daysOfWeek'] = self.days_of_week
        if self.index is not None:
            result['index'] = self.index
        if self.interval is not None:
            result['interval'] = self.interval
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        if m.get('daysOfWeek') is not None:
            self.days_of_week = m.get('daysOfWeek')
        if m.get('index') is not None:
            self.index = m.get('index')
        if m.get('interval') is not None:
            self.interval = m.get('interval')
        return self


class GetEventResponseBodyRecurrenceRange(TeaModel):
    def __init__(
        self,
        type: str = None,
        end_date: str = None,
        number_of_occurrences: int = None,
    ):
        # 范围类型(endDate, noEnd, numbered)
        self.type = type
        self.end_date = end_date
        self.number_of_occurrences = number_of_occurrences

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.number_of_occurrences is not None:
            result['numberOfOccurrences'] = self.number_of_occurrences
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('numberOfOccurrences') is not None:
            self.number_of_occurrences = m.get('numberOfOccurrences')
        return self


class GetEventResponseBodyRecurrence(TeaModel):
    def __init__(
        self,
        pattern: GetEventResponseBodyRecurrencePattern = None,
        range: GetEventResponseBodyRecurrenceRange = None,
    ):
        # 重复模式
        self.pattern = pattern
        # 重复范围
        self.range = range

    def validate(self):
        if self.pattern:
            self.pattern.validate()
        if self.range:
            self.range.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.pattern is not None:
            result['pattern'] = self.pattern.to_map()
        if self.range is not None:
            result['range'] = self.range.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pattern') is not None:
            temp_model = GetEventResponseBodyRecurrencePattern()
            self.pattern = temp_model.from_map(m['pattern'])
        if m.get('range') is not None:
            temp_model = GetEventResponseBodyRecurrenceRange()
            self.range = temp_model.from_map(m['range'])
        return self


class GetEventResponseBodyAttendees(TeaModel):
    def __init__(
        self,
        id: str = None,
        display_name: str = None,
        response_status: str = None,
        self_: bool = None,
    ):
        self.id = id
        # 用户名
        self.display_name = display_name
        # 回复状态
        self.response_status = response_status
        # 是否是当前登陆用户
        self.self_ = self_

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.response_status is not None:
            result['responseStatus'] = self.response_status
        if self.self_ is not None:
            result['self'] = self.self_
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('responseStatus') is not None:
            self.response_status = m.get('responseStatus')
        if m.get('self') is not None:
            self.self_ = m.get('self')
        return self


class GetEventResponseBodyOrganizer(TeaModel):
    def __init__(
        self,
        id: str = None,
        display_name: str = None,
        response_status: str = None,
        self_: bool = None,
    ):
        self.id = id
        # 用户名
        self.display_name = display_name
        # 回复状态
        self.response_status = response_status
        # 是否是当前登陆用户
        self.self_ = self_

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.response_status is not None:
            result['responseStatus'] = self.response_status
        if self.self_ is not None:
            result['self'] = self.self_
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('responseStatus') is not None:
            self.response_status = m.get('responseStatus')
        if m.get('self') is not None:
            self.self_ = m.get('self')
        return self


class GetEventResponseBodyLocation(TeaModel):
    def __init__(
        self,
        display_name: str = None,
    ):
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        return self


class GetEventResponseBody(TeaModel):
    def __init__(
        self,
        id: str = None,
        summary: str = None,
        description: str = None,
        status: str = None,
        start: GetEventResponseBodyStart = None,
        end: GetEventResponseBodyEnd = None,
        is_all_day: bool = None,
        recurrence: GetEventResponseBodyRecurrence = None,
        attendees: List[GetEventResponseBodyAttendees] = None,
        organizer: GetEventResponseBodyOrganizer = None,
        location: GetEventResponseBodyLocation = None,
        series_master_id: str = None,
        create_time: str = None,
        update_time: str = None,
    ):
        self.id = id
        # 日程标题
        self.summary = summary
        # 日程描述
        self.description = description
        # 日程状态
        self.status = status
        # 日程开始时间
        self.start = start
        # 日程结束时间
        self.end = end
        # 是否为全天日程
        self.is_all_day = is_all_day
        self.recurrence = recurrence
        self.attendees = attendees
        self.organizer = organizer
        self.location = location
        # 重复日程的主日程id，非重复日程为空
        self.series_master_id = series_master_id
        # 创建时间
        self.create_time = create_time
        # 更新时间
        self.update_time = update_time

    def validate(self):
        if self.start:
            self.start.validate()
        if self.end:
            self.end.validate()
        if self.recurrence:
            self.recurrence.validate()
        if self.attendees:
            for k in self.attendees:
                if k:
                    k.validate()
        if self.organizer:
            self.organizer.validate()
        if self.location:
            self.location.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.summary is not None:
            result['summary'] = self.summary
        if self.description is not None:
            result['description'] = self.description
        if self.status is not None:
            result['status'] = self.status
        if self.start is not None:
            result['start'] = self.start.to_map()
        if self.end is not None:
            result['end'] = self.end.to_map()
        if self.is_all_day is not None:
            result['isAllDay'] = self.is_all_day
        if self.recurrence is not None:
            result['recurrence'] = self.recurrence.to_map()
        result['attendees'] = []
        if self.attendees is not None:
            for k in self.attendees:
                result['attendees'].append(k.to_map() if k else None)
        if self.organizer is not None:
            result['organizer'] = self.organizer.to_map()
        if self.location is not None:
            result['location'] = self.location.to_map()
        if self.series_master_id is not None:
            result['seriesMasterId'] = self.series_master_id
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.update_time is not None:
            result['updateTime'] = self.update_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('summary') is not None:
            self.summary = m.get('summary')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('start') is not None:
            temp_model = GetEventResponseBodyStart()
            self.start = temp_model.from_map(m['start'])
        if m.get('end') is not None:
            temp_model = GetEventResponseBodyEnd()
            self.end = temp_model.from_map(m['end'])
        if m.get('isAllDay') is not None:
            self.is_all_day = m.get('isAllDay')
        if m.get('recurrence') is not None:
            temp_model = GetEventResponseBodyRecurrence()
            self.recurrence = temp_model.from_map(m['recurrence'])
        self.attendees = []
        if m.get('attendees') is not None:
            for k in m.get('attendees'):
                temp_model = GetEventResponseBodyAttendees()
                self.attendees.append(temp_model.from_map(k))
        if m.get('organizer') is not None:
            temp_model = GetEventResponseBodyOrganizer()
            self.organizer = temp_model.from_map(m['organizer'])
        if m.get('location') is not None:
            temp_model = GetEventResponseBodyLocation()
            self.location = temp_model.from_map(m['location'])
        if m.get('seriesMasterId') is not None:
            self.series_master_id = m.get('seriesMasterId')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('updateTime') is not None:
            self.update_time = m.get('updateTime')
        return self


class GetEventResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetEventResponseBody = None,
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
            temp_model = GetEventResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PatchEventHeaders(TeaModel):
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


class PatchEventRequestStart(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        self.date = date
        self.date_time = date_time
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class PatchEventRequestEnd(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        self.date = date
        self.date_time = date_time
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class PatchEventRequestRecurrencePattern(TeaModel):
    def __init__(
        self,
        type: str = None,
        day_of_month: int = None,
        days_of_week: str = None,
        index: str = None,
        interval: int = None,
    ):
        self.type = type
        self.day_of_month = day_of_month
        self.days_of_week = days_of_week
        self.index = index
        self.interval = interval

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        if self.days_of_week is not None:
            result['daysOfWeek'] = self.days_of_week
        if self.index is not None:
            result['index'] = self.index
        if self.interval is not None:
            result['interval'] = self.interval
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        if m.get('daysOfWeek') is not None:
            self.days_of_week = m.get('daysOfWeek')
        if m.get('index') is not None:
            self.index = m.get('index')
        if m.get('interval') is not None:
            self.interval = m.get('interval')
        return self


class PatchEventRequestRecurrenceRange(TeaModel):
    def __init__(
        self,
        type: str = None,
        end_date: str = None,
        number_of_occurrences: int = None,
    ):
        self.type = type
        self.end_date = end_date
        self.number_of_occurrences = number_of_occurrences

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.number_of_occurrences is not None:
            result['numberOfOccurrences'] = self.number_of_occurrences
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('numberOfOccurrences') is not None:
            self.number_of_occurrences = m.get('numberOfOccurrences')
        return self


class PatchEventRequestRecurrence(TeaModel):
    def __init__(
        self,
        pattern: PatchEventRequestRecurrencePattern = None,
        range: PatchEventRequestRecurrenceRange = None,
    ):
        self.pattern = pattern
        self.range = range

    def validate(self):
        if self.pattern:
            self.pattern.validate()
        if self.range:
            self.range.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.pattern is not None:
            result['pattern'] = self.pattern.to_map()
        if self.range is not None:
            result['range'] = self.range.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pattern') is not None:
            temp_model = PatchEventRequestRecurrencePattern()
            self.pattern = temp_model.from_map(m['pattern'])
        if m.get('range') is not None:
            temp_model = PatchEventRequestRecurrenceRange()
            self.range = temp_model.from_map(m['range'])
        return self


class PatchEventRequestAttendees(TeaModel):
    def __init__(
        self,
        id: str = None,
    ):
        self.id = id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        return self


class PatchEventRequestLocation(TeaModel):
    def __init__(
        self,
        display_name: str = None,
    ):
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        return self


class PatchEventRequestReminders(TeaModel):
    def __init__(
        self,
        method: str = None,
        minutes: int = None,
    ):
        self.method = method
        self.minutes = minutes

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.method is not None:
            result['method'] = self.method
        if self.minutes is not None:
            result['minutes'] = self.minutes
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('method') is not None:
            self.method = m.get('method')
        if m.get('minutes') is not None:
            self.minutes = m.get('minutes')
        return self


class PatchEventRequest(TeaModel):
    def __init__(
        self,
        summary: str = None,
        id: str = None,
        description: str = None,
        start: PatchEventRequestStart = None,
        end: PatchEventRequestEnd = None,
        is_all_day: bool = None,
        recurrence: PatchEventRequestRecurrence = None,
        attendees: List[PatchEventRequestAttendees] = None,
        location: PatchEventRequestLocation = None,
        extra: Dict[str, str] = None,
        reminders: List[PatchEventRequestReminders] = None,
    ):
        # 日程标题
        self.summary = summary
        # 日程id
        self.id = id
        self.description = description
        # 日程开始时间
        self.start = start
        self.end = end
        self.is_all_day = is_all_day
        self.recurrence = recurrence
        self.attendees = attendees
        self.location = location
        # 扩展信息
        self.extra = extra
        self.reminders = reminders

    def validate(self):
        if self.start:
            self.start.validate()
        if self.end:
            self.end.validate()
        if self.recurrence:
            self.recurrence.validate()
        if self.attendees:
            for k in self.attendees:
                if k:
                    k.validate()
        if self.location:
            self.location.validate()
        if self.reminders:
            for k in self.reminders:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.summary is not None:
            result['summary'] = self.summary
        if self.id is not None:
            result['id'] = self.id
        if self.description is not None:
            result['description'] = self.description
        if self.start is not None:
            result['start'] = self.start.to_map()
        if self.end is not None:
            result['end'] = self.end.to_map()
        if self.is_all_day is not None:
            result['isAllDay'] = self.is_all_day
        if self.recurrence is not None:
            result['recurrence'] = self.recurrence.to_map()
        result['attendees'] = []
        if self.attendees is not None:
            for k in self.attendees:
                result['attendees'].append(k.to_map() if k else None)
        if self.location is not None:
            result['location'] = self.location.to_map()
        if self.extra is not None:
            result['extra'] = self.extra
        result['reminders'] = []
        if self.reminders is not None:
            for k in self.reminders:
                result['reminders'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('summary') is not None:
            self.summary = m.get('summary')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('start') is not None:
            temp_model = PatchEventRequestStart()
            self.start = temp_model.from_map(m['start'])
        if m.get('end') is not None:
            temp_model = PatchEventRequestEnd()
            self.end = temp_model.from_map(m['end'])
        if m.get('isAllDay') is not None:
            self.is_all_day = m.get('isAllDay')
        if m.get('recurrence') is not None:
            temp_model = PatchEventRequestRecurrence()
            self.recurrence = temp_model.from_map(m['recurrence'])
        self.attendees = []
        if m.get('attendees') is not None:
            for k in m.get('attendees'):
                temp_model = PatchEventRequestAttendees()
                self.attendees.append(temp_model.from_map(k))
        if m.get('location') is not None:
            temp_model = PatchEventRequestLocation()
            self.location = temp_model.from_map(m['location'])
        if m.get('extra') is not None:
            self.extra = m.get('extra')
        self.reminders = []
        if m.get('reminders') is not None:
            for k in m.get('reminders'):
                temp_model = PatchEventRequestReminders()
                self.reminders.append(temp_model.from_map(k))
        return self


class PatchEventResponseBodyStart(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        self.date = date
        self.date_time = date_time
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class PatchEventResponseBodyEnd(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        self.date = date
        self.date_time = date_time
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class PatchEventResponseBodyRecurrencePattern(TeaModel):
    def __init__(
        self,
        type: str = None,
        day_of_month: int = None,
        days_of_week: str = None,
        index: str = None,
        interval: int = None,
    ):
        self.type = type
        self.day_of_month = day_of_month
        self.days_of_week = days_of_week
        self.index = index
        self.interval = interval

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        if self.days_of_week is not None:
            result['daysOfWeek'] = self.days_of_week
        if self.index is not None:
            result['index'] = self.index
        if self.interval is not None:
            result['interval'] = self.interval
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        if m.get('daysOfWeek') is not None:
            self.days_of_week = m.get('daysOfWeek')
        if m.get('index') is not None:
            self.index = m.get('index')
        if m.get('interval') is not None:
            self.interval = m.get('interval')
        return self


class PatchEventResponseBodyRecurrenceRange(TeaModel):
    def __init__(
        self,
        type: str = None,
        end_date: str = None,
        number_of_occurrences: int = None,
    ):
        self.type = type
        self.end_date = end_date
        self.number_of_occurrences = number_of_occurrences

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.number_of_occurrences is not None:
            result['numberOfOccurrences'] = self.number_of_occurrences
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('numberOfOccurrences') is not None:
            self.number_of_occurrences = m.get('numberOfOccurrences')
        return self


class PatchEventResponseBodyRecurrence(TeaModel):
    def __init__(
        self,
        pattern: PatchEventResponseBodyRecurrencePattern = None,
        range: PatchEventResponseBodyRecurrenceRange = None,
    ):
        self.pattern = pattern
        self.range = range

    def validate(self):
        if self.pattern:
            self.pattern.validate()
        if self.range:
            self.range.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.pattern is not None:
            result['pattern'] = self.pattern.to_map()
        if self.range is not None:
            result['range'] = self.range.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pattern') is not None:
            temp_model = PatchEventResponseBodyRecurrencePattern()
            self.pattern = temp_model.from_map(m['pattern'])
        if m.get('range') is not None:
            temp_model = PatchEventResponseBodyRecurrenceRange()
            self.range = temp_model.from_map(m['range'])
        return self


class PatchEventResponseBodyAttendees(TeaModel):
    def __init__(
        self,
        id: str = None,
        display_name: str = None,
        response_status: str = None,
        self_: bool = None,
    ):
        self.id = id
        # 用户名
        self.display_name = display_name
        # 回复状态
        self.response_status = response_status
        # 是否是当前登陆用户
        self.self_ = self_

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.response_status is not None:
            result['responseStatus'] = self.response_status
        if self.self_ is not None:
            result['self'] = self.self_
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('responseStatus') is not None:
            self.response_status = m.get('responseStatus')
        if m.get('self') is not None:
            self.self_ = m.get('self')
        return self


class PatchEventResponseBodyOrganizer(TeaModel):
    def __init__(
        self,
        id: str = None,
        display_name: str = None,
        response_status: str = None,
        self_: bool = None,
    ):
        self.id = id
        # 用户名
        self.display_name = display_name
        # 回复状态
        self.response_status = response_status
        # 是否是当前登陆用户
        self.self_ = self_

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.response_status is not None:
            result['responseStatus'] = self.response_status
        if self.self_ is not None:
            result['self'] = self.self_
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('responseStatus') is not None:
            self.response_status = m.get('responseStatus')
        if m.get('self') is not None:
            self.self_ = m.get('self')
        return self


class PatchEventResponseBodyLocation(TeaModel):
    def __init__(
        self,
        display_name: str = None,
    ):
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        return self


class PatchEventResponseBody(TeaModel):
    def __init__(
        self,
        id: str = None,
        summary: str = None,
        description: str = None,
        start: PatchEventResponseBodyStart = None,
        end: PatchEventResponseBodyEnd = None,
        is_all_day: bool = None,
        recurrence: PatchEventResponseBodyRecurrence = None,
        attendees: List[PatchEventResponseBodyAttendees] = None,
        organizer: PatchEventResponseBodyOrganizer = None,
        location: PatchEventResponseBodyLocation = None,
        create_time: str = None,
        update_time: str = None,
    ):
        self.id = id
        self.summary = summary
        self.description = description
        # 日程开始时间
        self.start = start
        self.end = end
        self.is_all_day = is_all_day
        self.recurrence = recurrence
        self.attendees = attendees
        self.organizer = organizer
        self.location = location
        # 创建时间
        self.create_time = create_time
        # 更新时间
        self.update_time = update_time

    def validate(self):
        if self.start:
            self.start.validate()
        if self.end:
            self.end.validate()
        if self.recurrence:
            self.recurrence.validate()
        if self.attendees:
            for k in self.attendees:
                if k:
                    k.validate()
        if self.organizer:
            self.organizer.validate()
        if self.location:
            self.location.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.summary is not None:
            result['summary'] = self.summary
        if self.description is not None:
            result['description'] = self.description
        if self.start is not None:
            result['start'] = self.start.to_map()
        if self.end is not None:
            result['end'] = self.end.to_map()
        if self.is_all_day is not None:
            result['isAllDay'] = self.is_all_day
        if self.recurrence is not None:
            result['recurrence'] = self.recurrence.to_map()
        result['attendees'] = []
        if self.attendees is not None:
            for k in self.attendees:
                result['attendees'].append(k.to_map() if k else None)
        if self.organizer is not None:
            result['organizer'] = self.organizer.to_map()
        if self.location is not None:
            result['location'] = self.location.to_map()
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.update_time is not None:
            result['updateTime'] = self.update_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('summary') is not None:
            self.summary = m.get('summary')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('start') is not None:
            temp_model = PatchEventResponseBodyStart()
            self.start = temp_model.from_map(m['start'])
        if m.get('end') is not None:
            temp_model = PatchEventResponseBodyEnd()
            self.end = temp_model.from_map(m['end'])
        if m.get('isAllDay') is not None:
            self.is_all_day = m.get('isAllDay')
        if m.get('recurrence') is not None:
            temp_model = PatchEventResponseBodyRecurrence()
            self.recurrence = temp_model.from_map(m['recurrence'])
        self.attendees = []
        if m.get('attendees') is not None:
            for k in m.get('attendees'):
                temp_model = PatchEventResponseBodyAttendees()
                self.attendees.append(temp_model.from_map(k))
        if m.get('organizer') is not None:
            temp_model = PatchEventResponseBodyOrganizer()
            self.organizer = temp_model.from_map(m['organizer'])
        if m.get('location') is not None:
            temp_model = PatchEventResponseBodyLocation()
            self.location = temp_model.from_map(m['location'])
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('updateTime') is not None:
            self.update_time = m.get('updateTime')
        return self


class PatchEventResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: PatchEventResponseBody = None,
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
            temp_model = PatchEventResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateEventHeaders(TeaModel):
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


class CreateEventRequestStart(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        # 日程开始日期，如果是全天日程必须有值，非全天日程必须留空，格式：yyyy-MM-dd
        self.date = date
        # 日程开始时间，非全天日程必须有值，全天日程必须留空，格式为ISO-8601的date-time格式
        self.date_time = date_time
        # 日程开始时间所属时区，非全天日程必须有值，全天日程必须留空，tz database name格式，参考：https://en.wikipedia.org/wiki/List_of_tz_database_time_zones
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class CreateEventRequestEnd(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        # 日程结束日期，如果是全天日程必须有值，非全天日程必须留空，格式：yyyy-MM-dd
        self.date = date
        # 日程结束时间，非全天日程必须有值，全天日程必须留空，格式为ISO-8601的date-time格式
        self.date_time = date_time
        # 日程结束时间所属时区，非全天日程必须有值，全天日程必须留空，tz database name格式，参考：https://en.wikipedia.org/wiki/List_of_tz_database_time_zones
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class CreateEventRequestRecurrencePattern(TeaModel):
    def __init__(
        self,
        type: str = None,
        day_of_month: int = None,
        days_of_week: str = None,
        index: str = None,
        interval: int = None,
    ):
        # 循环规则类型：  daily：每interval天 weekly：每interval周的第daysOfWeek天 absoluteMonthly：每interval月的第dayOfMonth天 relativeMonthly：每interval月的第index周的第daysOfWeek天 absoluteYearly：每interval年
        # 
        self.type = type
        self.day_of_month = day_of_month
        self.days_of_week = days_of_week
        self.index = index
        self.interval = interval

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        if self.days_of_week is not None:
            result['daysOfWeek'] = self.days_of_week
        if self.index is not None:
            result['index'] = self.index
        if self.interval is not None:
            result['interval'] = self.interval
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        if m.get('daysOfWeek') is not None:
            self.days_of_week = m.get('daysOfWeek')
        if m.get('index') is not None:
            self.index = m.get('index')
        if m.get('interval') is not None:
            self.interval = m.get('interval')
        return self


class CreateEventRequestRecurrenceRange(TeaModel):
    def __init__(
        self,
        type: str = None,
        end_date: str = None,
        number_of_occurrences: int = None,
    ):
        self.type = type
        self.end_date = end_date
        self.number_of_occurrences = number_of_occurrences

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.number_of_occurrences is not None:
            result['numberOfOccurrences'] = self.number_of_occurrences
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('numberOfOccurrences') is not None:
            self.number_of_occurrences = m.get('numberOfOccurrences')
        return self


class CreateEventRequestRecurrence(TeaModel):
    def __init__(
        self,
        pattern: CreateEventRequestRecurrencePattern = None,
        range: CreateEventRequestRecurrenceRange = None,
    ):
        # 循环规则
        self.pattern = pattern
        self.range = range

    def validate(self):
        if self.pattern:
            self.pattern.validate()
        if self.range:
            self.range.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.pattern is not None:
            result['pattern'] = self.pattern.to_map()
        if self.range is not None:
            result['range'] = self.range.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pattern') is not None:
            temp_model = CreateEventRequestRecurrencePattern()
            self.pattern = temp_model.from_map(m['pattern'])
        if m.get('range') is not None:
            temp_model = CreateEventRequestRecurrenceRange()
            self.range = temp_model.from_map(m['range'])
        return self


class CreateEventRequestAttendees(TeaModel):
    def __init__(
        self,
        id: str = None,
    ):
        self.id = id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        return self


class CreateEventRequestLocation(TeaModel):
    def __init__(
        self,
        display_name: str = None,
    ):
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        return self


class CreateEventRequestReminders(TeaModel):
    def __init__(
        self,
        method: str = None,
        minutes: int = None,
    ):
        self.method = method
        self.minutes = minutes

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.method is not None:
            result['method'] = self.method
        if self.minutes is not None:
            result['minutes'] = self.minutes
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('method') is not None:
            self.method = m.get('method')
        if m.get('minutes') is not None:
            self.minutes = m.get('minutes')
        return self


class CreateEventRequestOnlineMeetingInfo(TeaModel):
    def __init__(
        self,
        type: str = None,
    ):
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class CreateEventRequest(TeaModel):
    def __init__(
        self,
        summary: str = None,
        description: str = None,
        start: CreateEventRequestStart = None,
        end: CreateEventRequestEnd = None,
        is_all_day: bool = None,
        recurrence: CreateEventRequestRecurrence = None,
        attendees: List[CreateEventRequestAttendees] = None,
        location: CreateEventRequestLocation = None,
        reminders: List[CreateEventRequestReminders] = None,
        online_meeting_info: CreateEventRequestOnlineMeetingInfo = None,
        extra: Dict[str, str] = None,
    ):
        # 日程标题
        self.summary = summary
        # 日程描述
        self.description = description
        # 日程开始时间
        self.start = start
        # 日程结束时间
        self.end = end
        # 是否为全天日程
        self.is_all_day = is_all_day
        # 日程循环规则
        self.recurrence = recurrence
        self.attendees = attendees
        self.location = location
        self.reminders = reminders
        self.online_meeting_info = online_meeting_info
        # 扩展信息
        self.extra = extra

    def validate(self):
        if self.start:
            self.start.validate()
        if self.end:
            self.end.validate()
        if self.recurrence:
            self.recurrence.validate()
        if self.attendees:
            for k in self.attendees:
                if k:
                    k.validate()
        if self.location:
            self.location.validate()
        if self.reminders:
            for k in self.reminders:
                if k:
                    k.validate()
        if self.online_meeting_info:
            self.online_meeting_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.summary is not None:
            result['summary'] = self.summary
        if self.description is not None:
            result['description'] = self.description
        if self.start is not None:
            result['start'] = self.start.to_map()
        if self.end is not None:
            result['end'] = self.end.to_map()
        if self.is_all_day is not None:
            result['isAllDay'] = self.is_all_day
        if self.recurrence is not None:
            result['recurrence'] = self.recurrence.to_map()
        result['attendees'] = []
        if self.attendees is not None:
            for k in self.attendees:
                result['attendees'].append(k.to_map() if k else None)
        if self.location is not None:
            result['location'] = self.location.to_map()
        result['reminders'] = []
        if self.reminders is not None:
            for k in self.reminders:
                result['reminders'].append(k.to_map() if k else None)
        if self.online_meeting_info is not None:
            result['onlineMeetingInfo'] = self.online_meeting_info.to_map()
        if self.extra is not None:
            result['extra'] = self.extra
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('summary') is not None:
            self.summary = m.get('summary')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('start') is not None:
            temp_model = CreateEventRequestStart()
            self.start = temp_model.from_map(m['start'])
        if m.get('end') is not None:
            temp_model = CreateEventRequestEnd()
            self.end = temp_model.from_map(m['end'])
        if m.get('isAllDay') is not None:
            self.is_all_day = m.get('isAllDay')
        if m.get('recurrence') is not None:
            temp_model = CreateEventRequestRecurrence()
            self.recurrence = temp_model.from_map(m['recurrence'])
        self.attendees = []
        if m.get('attendees') is not None:
            for k in m.get('attendees'):
                temp_model = CreateEventRequestAttendees()
                self.attendees.append(temp_model.from_map(k))
        if m.get('location') is not None:
            temp_model = CreateEventRequestLocation()
            self.location = temp_model.from_map(m['location'])
        self.reminders = []
        if m.get('reminders') is not None:
            for k in m.get('reminders'):
                temp_model = CreateEventRequestReminders()
                self.reminders.append(temp_model.from_map(k))
        if m.get('onlineMeetingInfo') is not None:
            temp_model = CreateEventRequestOnlineMeetingInfo()
            self.online_meeting_info = temp_model.from_map(m['onlineMeetingInfo'])
        if m.get('extra') is not None:
            self.extra = m.get('extra')
        return self


class CreateEventResponseBodyStart(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        self.date = date
        self.date_time = date_time
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class CreateEventResponseBodyEnd(TeaModel):
    def __init__(
        self,
        date: str = None,
        date_time: str = None,
        time_zone: str = None,
    ):
        self.date = date
        self.date_time = date_time
        self.time_zone = time_zone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.date is not None:
            result['date'] = self.date
        if self.date_time is not None:
            result['dateTime'] = self.date_time
        if self.time_zone is not None:
            result['timeZone'] = self.time_zone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('date') is not None:
            self.date = m.get('date')
        if m.get('dateTime') is not None:
            self.date_time = m.get('dateTime')
        if m.get('timeZone') is not None:
            self.time_zone = m.get('timeZone')
        return self


class CreateEventResponseBodyRecurrencePattern(TeaModel):
    def __init__(
        self,
        type: str = None,
        day_of_month: int = None,
        days_of_week: str = None,
        index: str = None,
        interval: int = None,
    ):
        self.type = type
        self.day_of_month = day_of_month
        self.days_of_week = days_of_week
        self.index = index
        self.interval = interval

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.day_of_month is not None:
            result['dayOfMonth'] = self.day_of_month
        if self.days_of_week is not None:
            result['daysOfWeek'] = self.days_of_week
        if self.index is not None:
            result['index'] = self.index
        if self.interval is not None:
            result['interval'] = self.interval
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('dayOfMonth') is not None:
            self.day_of_month = m.get('dayOfMonth')
        if m.get('daysOfWeek') is not None:
            self.days_of_week = m.get('daysOfWeek')
        if m.get('index') is not None:
            self.index = m.get('index')
        if m.get('interval') is not None:
            self.interval = m.get('interval')
        return self


class CreateEventResponseBodyRecurrenceRange(TeaModel):
    def __init__(
        self,
        type: str = None,
        end_date: str = None,
        number_of_occurrences: int = None,
    ):
        self.type = type
        self.end_date = end_date
        self.number_of_occurrences = number_of_occurrences

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.number_of_occurrences is not None:
            result['numberOfOccurrences'] = self.number_of_occurrences
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('numberOfOccurrences') is not None:
            self.number_of_occurrences = m.get('numberOfOccurrences')
        return self


class CreateEventResponseBodyRecurrence(TeaModel):
    def __init__(
        self,
        pattern: CreateEventResponseBodyRecurrencePattern = None,
        range: CreateEventResponseBodyRecurrenceRange = None,
    ):
        self.pattern = pattern
        self.range = range

    def validate(self):
        if self.pattern:
            self.pattern.validate()
        if self.range:
            self.range.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.pattern is not None:
            result['pattern'] = self.pattern.to_map()
        if self.range is not None:
            result['range'] = self.range.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pattern') is not None:
            temp_model = CreateEventResponseBodyRecurrencePattern()
            self.pattern = temp_model.from_map(m['pattern'])
        if m.get('range') is not None:
            temp_model = CreateEventResponseBodyRecurrenceRange()
            self.range = temp_model.from_map(m['range'])
        return self


class CreateEventResponseBodyAttendees(TeaModel):
    def __init__(
        self,
        id: str = None,
        display_name: str = None,
        response_status: str = None,
        self_: bool = None,
    ):
        self.id = id
        self.display_name = display_name
        # 回复状态
        self.response_status = response_status
        self.self_ = self_

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.response_status is not None:
            result['responseStatus'] = self.response_status
        if self.self_ is not None:
            result['self'] = self.self_
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('responseStatus') is not None:
            self.response_status = m.get('responseStatus')
        if m.get('self') is not None:
            self.self_ = m.get('self')
        return self


class CreateEventResponseBodyOrganizer(TeaModel):
    def __init__(
        self,
        id: str = None,
        display_name: str = None,
        response_status: str = None,
        self_: bool = None,
    ):
        self.id = id
        # 用户名
        self.display_name = display_name
        # 回复状态
        self.response_status = response_status
        self.self_ = self_

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.display_name is not None:
            result['displayName'] = self.display_name
        if self.response_status is not None:
            result['responseStatus'] = self.response_status
        if self.self_ is not None:
            result['self'] = self.self_
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        if m.get('responseStatus') is not None:
            self.response_status = m.get('responseStatus')
        if m.get('self') is not None:
            self.self_ = m.get('self')
        return self


class CreateEventResponseBodyLocation(TeaModel):
    def __init__(
        self,
        display_name: str = None,
    ):
        self.display_name = display_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.display_name is not None:
            result['displayName'] = self.display_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('displayName') is not None:
            self.display_name = m.get('displayName')
        return self


class CreateEventResponseBodyReminders(TeaModel):
    def __init__(
        self,
        method: str = None,
        minutes: str = None,
    ):
        self.method = method
        self.minutes = minutes

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.method is not None:
            result['method'] = self.method
        if self.minutes is not None:
            result['minutes'] = self.minutes
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('method') is not None:
            self.method = m.get('method')
        if m.get('minutes') is not None:
            self.minutes = m.get('minutes')
        return self


class CreateEventResponseBodyOnlineMeetingInfo(TeaModel):
    def __init__(
        self,
        type: str = None,
        conference_id: str = None,
        url: str = None,
        extra_info: Dict[str, Any] = None,
    ):
        self.type = type
        self.conference_id = conference_id
        self.url = url
        self.extra_info = extra_info

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.conference_id is not None:
            result['conferenceId'] = self.conference_id
        if self.url is not None:
            result['url'] = self.url
        if self.extra_info is not None:
            result['extraInfo'] = self.extra_info
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('conferenceId') is not None:
            self.conference_id = m.get('conferenceId')
        if m.get('url') is not None:
            self.url = m.get('url')
        if m.get('extraInfo') is not None:
            self.extra_info = m.get('extraInfo')
        return self


class CreateEventResponseBody(TeaModel):
    def __init__(
        self,
        id: str = None,
        summary: str = None,
        description: str = None,
        start: CreateEventResponseBodyStart = None,
        end: CreateEventResponseBodyEnd = None,
        is_all_day: bool = None,
        recurrence: CreateEventResponseBodyRecurrence = None,
        attendees: List[CreateEventResponseBodyAttendees] = None,
        organizer: CreateEventResponseBodyOrganizer = None,
        location: CreateEventResponseBodyLocation = None,
        reminders: List[CreateEventResponseBodyReminders] = None,
        create_time: str = None,
        update_time: str = None,
        online_meeting_info: CreateEventResponseBodyOnlineMeetingInfo = None,
    ):
        self.id = id
        self.summary = summary
        self.description = description
        # 日程开始时间
        self.start = start
        self.end = end
        self.is_all_day = is_all_day
        self.recurrence = recurrence
        self.attendees = attendees
        self.organizer = organizer
        self.location = location
        self.reminders = reminders
        # 创建时间
        self.create_time = create_time
        # 更新时间
        self.update_time = update_time
        self.online_meeting_info = online_meeting_info

    def validate(self):
        if self.start:
            self.start.validate()
        if self.end:
            self.end.validate()
        if self.recurrence:
            self.recurrence.validate()
        if self.attendees:
            for k in self.attendees:
                if k:
                    k.validate()
        if self.organizer:
            self.organizer.validate()
        if self.location:
            self.location.validate()
        if self.reminders:
            for k in self.reminders:
                if k:
                    k.validate()
        if self.online_meeting_info:
            self.online_meeting_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.summary is not None:
            result['summary'] = self.summary
        if self.description is not None:
            result['description'] = self.description
        if self.start is not None:
            result['start'] = self.start.to_map()
        if self.end is not None:
            result['end'] = self.end.to_map()
        if self.is_all_day is not None:
            result['isAllDay'] = self.is_all_day
        if self.recurrence is not None:
            result['recurrence'] = self.recurrence.to_map()
        result['attendees'] = []
        if self.attendees is not None:
            for k in self.attendees:
                result['attendees'].append(k.to_map() if k else None)
        if self.organizer is not None:
            result['organizer'] = self.organizer.to_map()
        if self.location is not None:
            result['location'] = self.location.to_map()
        result['reminders'] = []
        if self.reminders is not None:
            for k in self.reminders:
                result['reminders'].append(k.to_map() if k else None)
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.update_time is not None:
            result['updateTime'] = self.update_time
        if self.online_meeting_info is not None:
            result['onlineMeetingInfo'] = self.online_meeting_info.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('summary') is not None:
            self.summary = m.get('summary')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('start') is not None:
            temp_model = CreateEventResponseBodyStart()
            self.start = temp_model.from_map(m['start'])
        if m.get('end') is not None:
            temp_model = CreateEventResponseBodyEnd()
            self.end = temp_model.from_map(m['end'])
        if m.get('isAllDay') is not None:
            self.is_all_day = m.get('isAllDay')
        if m.get('recurrence') is not None:
            temp_model = CreateEventResponseBodyRecurrence()
            self.recurrence = temp_model.from_map(m['recurrence'])
        self.attendees = []
        if m.get('attendees') is not None:
            for k in m.get('attendees'):
                temp_model = CreateEventResponseBodyAttendees()
                self.attendees.append(temp_model.from_map(k))
        if m.get('organizer') is not None:
            temp_model = CreateEventResponseBodyOrganizer()
            self.organizer = temp_model.from_map(m['organizer'])
        if m.get('location') is not None:
            temp_model = CreateEventResponseBodyLocation()
            self.location = temp_model.from_map(m['location'])
        self.reminders = []
        if m.get('reminders') is not None:
            for k in m.get('reminders'):
                temp_model = CreateEventResponseBodyReminders()
                self.reminders.append(temp_model.from_map(k))
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('updateTime') is not None:
            self.update_time = m.get('updateTime')
        if m.get('onlineMeetingInfo') is not None:
            temp_model = CreateEventResponseBodyOnlineMeetingInfo()
            self.online_meeting_info = temp_model.from_map(m['onlineMeetingInfo'])
        return self


class CreateEventResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateEventResponseBody = None,
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
            temp_model = CreateEventResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


