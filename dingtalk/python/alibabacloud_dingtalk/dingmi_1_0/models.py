# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List, Any


class AddRobotInstanceToGroupHeaders(TeaModel):
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


class AddRobotInstanceToGroupRequest(TeaModel):
    def __init__(
        self,
        chatbot_id: str = None,
        open_conversation_id: str = None,
    ):
        # This parameter is required.
        self.chatbot_id = chatbot_id
        # This parameter is required.
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.chatbot_id is not None:
            result['chatbotId'] = self.chatbot_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('chatbotId') is not None:
            self.chatbot_id = m.get('chatbotId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class AddRobotInstanceToGroupResponseBody(TeaModel):
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


class AddRobotInstanceToGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AddRobotInstanceToGroupResponseBody = None,
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
            temp_model = AddRobotInstanceToGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AskRobotHeaders(TeaModel):
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


class AskRobotRequest(TeaModel):
    def __init__(
        self,
        ding_user_id: str = None,
        question: str = None,
        robot_app_key: str = None,
        session_uuid: str = None,
    ):
        self.ding_user_id = ding_user_id
        # This parameter is required.
        self.question = question
        # This parameter is required.
        self.robot_app_key = robot_app_key
        self.session_uuid = session_uuid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_user_id is not None:
            result['dingUserId'] = self.ding_user_id
        if self.question is not None:
            result['question'] = self.question
        if self.robot_app_key is not None:
            result['robotAppKey'] = self.robot_app_key
        if self.session_uuid is not None:
            result['sessionUuid'] = self.session_uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingUserId') is not None:
            self.ding_user_id = m.get('dingUserId')
        if m.get('question') is not None:
            self.question = m.get('question')
        if m.get('robotAppKey') is not None:
            self.robot_app_key = m.get('robotAppKey')
        if m.get('sessionUuid') is not None:
            self.session_uuid = m.get('sessionUuid')
        return self


class AskRobotResponseBody(TeaModel):
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


class AskRobotResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AskRobotResponseBody = None,
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
            temp_model = AskRobotResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetDingMeBaseDataHeaders(TeaModel):
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


class GetDingMeBaseDataRequest(TeaModel):
    def __init__(
        self,
        app_key: str = None,
        by_day: bool = None,
        end_day: str = None,
        start_day: str = None,
    ):
        # This parameter is required.
        self.app_key = app_key
        # This parameter is required.
        self.by_day = by_day
        # This parameter is required.
        self.end_day = end_day
        # This parameter is required.
        self.start_day = start_day

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_key is not None:
            result['appKey'] = self.app_key
        if self.by_day is not None:
            result['byDay'] = self.by_day
        if self.end_day is not None:
            result['endDay'] = self.end_day
        if self.start_day is not None:
            result['startDay'] = self.start_day
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appKey') is not None:
            self.app_key = m.get('appKey')
        if m.get('byDay') is not None:
            self.by_day = m.get('byDay')
        if m.get('endDay') is not None:
            self.end_day = m.get('endDay')
        if m.get('startDay') is not None:
            self.start_day = m.get('startDay')
        return self


class GetDingMeBaseDataResponseBody(TeaModel):
    def __init__(
        self,
        from_cache: bool = None,
        rawset: List[Dict[str, str]] = None,
        runtime: int = None,
        tips: Dict[str, Any] = None,
    ):
        # This parameter is required.
        self.from_cache = from_cache
        # This parameter is required.
        self.rawset = rawset
        # This parameter is required.
        self.runtime = runtime
        # This parameter is required.
        self.tips = tips

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.from_cache is not None:
            result['fromCache'] = self.from_cache
        if self.rawset is not None:
            result['rawset'] = self.rawset
        if self.runtime is not None:
            result['runtime'] = self.runtime
        if self.tips is not None:
            result['tips'] = self.tips
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fromCache') is not None:
            self.from_cache = m.get('fromCache')
        if m.get('rawset') is not None:
            self.rawset = m.get('rawset')
        if m.get('runtime') is not None:
            self.runtime = m.get('runtime')
        if m.get('tips') is not None:
            self.tips = m.get('tips')
        return self


class GetDingMeBaseDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetDingMeBaseDataResponseBody = None,
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
            temp_model = GetDingMeBaseDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetIntelligentRobotInfoHeaders(TeaModel):
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


class GetIntelligentRobotInfoRequest(TeaModel):
    def __init__(
        self,
        robot_app_key: str = None,
    ):
        # This parameter is required.
        self.robot_app_key = robot_app_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.robot_app_key is not None:
            result['robotAppKey'] = self.robot_app_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('robotAppKey') is not None:
            self.robot_app_key = m.get('robotAppKey')
        return self


class GetIntelligentRobotInfoResponseBody(TeaModel):
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


class GetIntelligentRobotInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetIntelligentRobotInfoResponseBody = None,
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
            temp_model = GetIntelligentRobotInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetOfficialAccountRobotInfoHeaders(TeaModel):
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


class GetOfficialAccountRobotInfoRequest(TeaModel):
    def __init__(
        self,
        type: str = None,
    ):
        # This parameter is required.
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


class GetOfficialAccountRobotInfoResponseBody(TeaModel):
    def __init__(
        self,
        app_id: int = None,
        brief: str = None,
        description: str = None,
        icon: str = None,
        name: str = None,
        preview_media_url: str = None,
    ):
        # This parameter is required.
        self.app_id = app_id
        # This parameter is required.
        self.brief = brief
        # This parameter is required.
        self.description = description
        # This parameter is required.
        self.icon = icon
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.preview_media_url = preview_media_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.brief is not None:
            result['brief'] = self.brief
        if self.description is not None:
            result['description'] = self.description
        if self.icon is not None:
            result['icon'] = self.icon
        if self.name is not None:
            result['name'] = self.name
        if self.preview_media_url is not None:
            result['previewMediaUrl'] = self.preview_media_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('brief') is not None:
            self.brief = m.get('brief')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('previewMediaUrl') is not None:
            self.preview_media_url = m.get('previewMediaUrl')
        return self


class GetOfficialAccountRobotInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetOfficialAccountRobotInfoResponseBody = None,
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
            temp_model = GetOfficialAccountRobotInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetWebChannelUserTokenHeaders(TeaModel):
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


class GetWebChannelUserTokenRequest(TeaModel):
    def __init__(
        self,
        foreign_id: str = None,
        nick: str = None,
        source: int = None,
    ):
        # This parameter is required.
        self.foreign_id = foreign_id
        # This parameter is required.
        self.nick = nick
        # This parameter is required.
        self.source = source

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.foreign_id is not None:
            result['foreignId'] = self.foreign_id
        if self.nick is not None:
            result['nick'] = self.nick
        if self.source is not None:
            result['source'] = self.source
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('foreignId') is not None:
            self.foreign_id = m.get('foreignId')
        if m.get('nick') is not None:
            self.nick = m.get('nick')
        if m.get('source') is not None:
            self.source = m.get('source')
        return self


class GetWebChannelUserTokenResponseBody(TeaModel):
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


class GetWebChannelUserTokenResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetWebChannelUserTokenResponseBody = None,
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
            temp_model = GetWebChannelUserTokenResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PushCustomerGroupMessageHeaders(TeaModel):
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


class PushCustomerGroupMessageRequest(TeaModel):
    def __init__(
        self,
        conversation_id: str = None,
        msg_key: str = None,
        msg_param: str = None,
    ):
        # This parameter is required.
        self.conversation_id = conversation_id
        # This parameter is required.
        self.msg_key = msg_key
        # This parameter is required.
        self.msg_param = msg_param

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conversation_id is not None:
            result['conversationId'] = self.conversation_id
        if self.msg_key is not None:
            result['msgKey'] = self.msg_key
        if self.msg_param is not None:
            result['msgParam'] = self.msg_param
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conversationId') is not None:
            self.conversation_id = m.get('conversationId')
        if m.get('msgKey') is not None:
            self.msg_key = m.get('msgKey')
        if m.get('msgParam') is not None:
            self.msg_param = m.get('msgParam')
        return self


class PushCustomerGroupMessageResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
    ):
        # This parameter is required.
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


class PushCustomerGroupMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PushCustomerGroupMessageResponseBody = None,
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
            temp_model = PushCustomerGroupMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PushIntelligentRobotGroupMessageHeaders(TeaModel):
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


class PushIntelligentRobotGroupMessageRequest(TeaModel):
    def __init__(
        self,
        chatbot_id: str = None,
        msg_key: str = None,
        msg_param: str = None,
        open_conversation_id: str = None,
    ):
        # This parameter is required.
        self.chatbot_id = chatbot_id
        # This parameter is required.
        self.msg_key = msg_key
        # This parameter is required.
        self.msg_param = msg_param
        # This parameter is required.
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.chatbot_id is not None:
            result['chatbotId'] = self.chatbot_id
        if self.msg_key is not None:
            result['msgKey'] = self.msg_key
        if self.msg_param is not None:
            result['msgParam'] = self.msg_param
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('chatbotId') is not None:
            self.chatbot_id = m.get('chatbotId')
        if m.get('msgKey') is not None:
            self.msg_key = m.get('msgKey')
        if m.get('msgParam') is not None:
            self.msg_param = m.get('msgParam')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class PushIntelligentRobotGroupMessageResponseBody(TeaModel):
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


class PushIntelligentRobotGroupMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PushIntelligentRobotGroupMessageResponseBody = None,
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
            temp_model = PushIntelligentRobotGroupMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PushIntelligentRobotMessageHeaders(TeaModel):
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


class PushIntelligentRobotMessageRequest(TeaModel):
    def __init__(
        self,
        chatbot_id: str = None,
        msg_key: str = None,
        msg_param: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.chatbot_id = chatbot_id
        # This parameter is required.
        self.msg_key = msg_key
        # This parameter is required.
        self.msg_param = msg_param
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.chatbot_id is not None:
            result['chatbotId'] = self.chatbot_id
        if self.msg_key is not None:
            result['msgKey'] = self.msg_key
        if self.msg_param is not None:
            result['msgParam'] = self.msg_param
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('chatbotId') is not None:
            self.chatbot_id = m.get('chatbotId')
        if m.get('msgKey') is not None:
            self.msg_key = m.get('msgKey')
        if m.get('msgParam') is not None:
            self.msg_param = m.get('msgParam')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class PushIntelligentRobotMessageResponseBody(TeaModel):
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


class PushIntelligentRobotMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PushIntelligentRobotMessageResponseBody = None,
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
            temp_model = PushIntelligentRobotMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PushOfficialAccountMessageHeaders(TeaModel):
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


class PushOfficialAccountMessageRequest(TeaModel):
    def __init__(
        self,
        msg_key: str = None,
        msg_param: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.msg_key = msg_key
        # This parameter is required.
        self.msg_param = msg_param
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.msg_key is not None:
            result['msgKey'] = self.msg_key
        if self.msg_param is not None:
            result['msgParam'] = self.msg_param
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('msgKey') is not None:
            self.msg_key = m.get('msgKey')
        if m.get('msgParam') is not None:
            self.msg_param = m.get('msgParam')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class PushOfficialAccountMessageResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
    ):
        # This parameter is required.
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


class PushOfficialAccountMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PushOfficialAccountMessageResponseBody = None,
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
            temp_model = PushOfficialAccountMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PushRobotMessageHeaders(TeaModel):
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


class PushRobotMessageRequest(TeaModel):
    def __init__(
        self,
        chatbot_id: str = None,
        msg_key: str = None,
        msg_param: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.chatbot_id = chatbot_id
        # This parameter is required.
        self.msg_key = msg_key
        # This parameter is required.
        self.msg_param = msg_param
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.chatbot_id is not None:
            result['chatbotId'] = self.chatbot_id
        if self.msg_key is not None:
            result['msgKey'] = self.msg_key
        if self.msg_param is not None:
            result['msgParam'] = self.msg_param
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('chatbotId') is not None:
            self.chatbot_id = m.get('chatbotId')
        if m.get('msgKey') is not None:
            self.msg_key = m.get('msgKey')
        if m.get('msgParam') is not None:
            self.msg_param = m.get('msgParam')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class PushRobotMessageResponseBody(TeaModel):
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


class PushRobotMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PushRobotMessageResponseBody = None,
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
            temp_model = PushRobotMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ReplyRobotHeaders(TeaModel):
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


class ReplyRobotRequest(TeaModel):
    def __init__(
        self,
        proxy_message_str: str = None,
    ):
        # This parameter is required.
        self.proxy_message_str = proxy_message_str

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.proxy_message_str is not None:
            result['proxyMessageStr'] = self.proxy_message_str
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('proxyMessageStr') is not None:
            self.proxy_message_str = m.get('proxyMessageStr')
        return self


class ReplyRobotResponseBody(TeaModel):
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


class ReplyRobotResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ReplyRobotResponseBody = None,
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
            temp_model = ReplyRobotResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateOfficialAccountRobotInfoHeaders(TeaModel):
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


class UpdateOfficialAccountRobotInfoRequest(TeaModel):
    def __init__(
        self,
        avatar: str = None,
        brief: str = None,
        description: str = None,
        name: str = None,
        preview_media_url: str = None,
        type: str = None,
    ):
        # This parameter is required.
        self.avatar = avatar
        # This parameter is required.
        self.brief = brief
        # This parameter is required.
        self.description = description
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.preview_media_url = preview_media_url
        # This parameter is required.
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.avatar is not None:
            result['avatar'] = self.avatar
        if self.brief is not None:
            result['brief'] = self.brief
        if self.description is not None:
            result['description'] = self.description
        if self.name is not None:
            result['name'] = self.name
        if self.preview_media_url is not None:
            result['previewMediaUrl'] = self.preview_media_url
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('avatar') is not None:
            self.avatar = m.get('avatar')
        if m.get('brief') is not None:
            self.brief = m.get('brief')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('previewMediaUrl') is not None:
            self.preview_media_url = m.get('previewMediaUrl')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class UpdateOfficialAccountRobotInfoResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
    ):
        # This parameter is required.
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


class UpdateOfficialAccountRobotInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateOfficialAccountRobotInfoResponseBody = None,
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
            temp_model = UpdateOfficialAccountRobotInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


