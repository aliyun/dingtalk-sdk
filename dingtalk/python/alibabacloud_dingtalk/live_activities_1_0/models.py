# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, Any


class PushLiveActivityHeaders(TeaModel):
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


class PushLiveActivityRequestActivityEventData(TeaModel):
    def __init__(
        self,
        i_18n_content_state: Any = None,
        template_id: str = None,
    ):
        self.i_18n_content_state = i_18n_content_state
        self.template_id = template_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.i_18n_content_state is not None:
            result['i18nContentState'] = self.i_18n_content_state
        if self.template_id is not None:
            result['templateId'] = self.template_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('i18nContentState') is not None:
            self.i_18n_content_state = m.get('i18nContentState')
        if m.get('templateId') is not None:
            self.template_id = m.get('templateId')
        return self


class PushLiveActivityRequestActivityEventOption(TeaModel):
    def __init__(
        self,
        dismissal_date: int = None,
        push_type: str = None,
        send_date: int = None,
        stale_date: int = None,
    ):
        self.dismissal_date = dismissal_date
        self.push_type = push_type
        self.send_date = send_date
        self.stale_date = stale_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dismissal_date is not None:
            result['dismissalDate'] = self.dismissal_date
        if self.push_type is not None:
            result['pushType'] = self.push_type
        if self.send_date is not None:
            result['sendDate'] = self.send_date
        if self.stale_date is not None:
            result['staleDate'] = self.stale_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dismissalDate') is not None:
            self.dismissal_date = m.get('dismissalDate')
        if m.get('pushType') is not None:
            self.push_type = m.get('pushType')
        if m.get('sendDate') is not None:
            self.send_date = m.get('sendDate')
        if m.get('staleDate') is not None:
            self.stale_date = m.get('staleDate')
        return self


class PushLiveActivityRequest(TeaModel):
    def __init__(
        self,
        activity_event_data: PushLiveActivityRequestActivityEventData = None,
        activity_event_option: PushLiveActivityRequestActivityEventOption = None,
        activity_id: str = None,
    ):
        self.activity_event_data = activity_event_data
        self.activity_event_option = activity_event_option
        self.activity_id = activity_id

    def validate(self):
        if self.activity_event_data:
            self.activity_event_data.validate()
        if self.activity_event_option:
            self.activity_event_option.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.activity_event_data is not None:
            result['activityEventData'] = self.activity_event_data.to_map()
        if self.activity_event_option is not None:
            result['activityEventOption'] = self.activity_event_option.to_map()
        if self.activity_id is not None:
            result['activityId'] = self.activity_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activityEventData') is not None:
            temp_model = PushLiveActivityRequestActivityEventData()
            self.activity_event_data = temp_model.from_map(m['activityEventData'])
        if m.get('activityEventOption') is not None:
            temp_model = PushLiveActivityRequestActivityEventOption()
            self.activity_event_option = temp_model.from_map(m['activityEventOption'])
        if m.get('activityId') is not None:
            self.activity_id = m.get('activityId')
        return self


class PushLiveActivityResponseBody(TeaModel):
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


class PushLiveActivityResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PushLiveActivityResponseBody = None,
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
            temp_model = PushLiveActivityResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SendLiveActivityHeaders(TeaModel):
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


class SendLiveActivityRequestActivityEventData(TeaModel):
    def __init__(
        self,
        i_18n_content_state: Any = None,
        template_id: str = None,
    ):
        self.i_18n_content_state = i_18n_content_state
        self.template_id = template_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.i_18n_content_state is not None:
            result['i18nContentState'] = self.i_18n_content_state
        if self.template_id is not None:
            result['templateId'] = self.template_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('i18nContentState') is not None:
            self.i_18n_content_state = m.get('i18nContentState')
        if m.get('templateId') is not None:
            self.template_id = m.get('templateId')
        return self


class SendLiveActivityRequestActivityEventOption(TeaModel):
    def __init__(
        self,
        dismissal_date: int = None,
        push_type: str = None,
        send_date: int = None,
        stale_date: int = None,
    ):
        self.dismissal_date = dismissal_date
        self.push_type = push_type
        self.send_date = send_date
        self.stale_date = stale_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dismissal_date is not None:
            result['dismissalDate'] = self.dismissal_date
        if self.push_type is not None:
            result['pushType'] = self.push_type
        if self.send_date is not None:
            result['sendDate'] = self.send_date
        if self.stale_date is not None:
            result['staleDate'] = self.stale_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dismissalDate') is not None:
            self.dismissal_date = m.get('dismissalDate')
        if m.get('pushType') is not None:
            self.push_type = m.get('pushType')
        if m.get('sendDate') is not None:
            self.send_date = m.get('sendDate')
        if m.get('staleDate') is not None:
            self.stale_date = m.get('staleDate')
        return self


class SendLiveActivityRequest(TeaModel):
    def __init__(
        self,
        activity_event_data: SendLiveActivityRequestActivityEventData = None,
        activity_event_option: SendLiveActivityRequestActivityEventOption = None,
        activity_id: str = None,
    ):
        self.activity_event_data = activity_event_data
        self.activity_event_option = activity_event_option
        self.activity_id = activity_id

    def validate(self):
        if self.activity_event_data:
            self.activity_event_data.validate()
        if self.activity_event_option:
            self.activity_event_option.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.activity_event_data is not None:
            result['activityEventData'] = self.activity_event_data.to_map()
        if self.activity_event_option is not None:
            result['activityEventOption'] = self.activity_event_option.to_map()
        if self.activity_id is not None:
            result['activityId'] = self.activity_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('activityEventData') is not None:
            temp_model = SendLiveActivityRequestActivityEventData()
            self.activity_event_data = temp_model.from_map(m['activityEventData'])
        if m.get('activityEventOption') is not None:
            temp_model = SendLiveActivityRequestActivityEventOption()
            self.activity_event_option = temp_model.from_map(m['activityEventOption'])
        if m.get('activityId') is not None:
            self.activity_id = m.get('activityId')
        return self


class SendLiveActivityResponseBody(TeaModel):
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


class SendLiveActivityResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SendLiveActivityResponseBody = None,
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
            temp_model = SendLiveActivityResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


