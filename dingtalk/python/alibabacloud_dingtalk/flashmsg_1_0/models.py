# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class PrivateFieldMapValue(TeaModel):
    def __init__(
        self,
        tip_title: str = None,
        is_ding_send: bool = None,
        is_read: bool = None,
        button_status: str = None,
        extension: Dict[str, str] = None,
    ):
        self.tip_title = tip_title
        self.is_ding_send = is_ding_send
        self.is_read = is_read
        self.button_status = button_status
        self.extension = extension

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.tip_title is not None:
            result['tipTitle'] = self.tip_title
        if self.is_ding_send is not None:
            result['isDingSend'] = self.is_ding_send
        if self.is_read is not None:
            result['isRead'] = self.is_read
        if self.button_status is not None:
            result['buttonStatus'] = self.button_status
        if self.extension is not None:
            result['extension'] = self.extension
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('tipTitle') is not None:
            self.tip_title = m.get('tipTitle')
        if m.get('isDingSend') is not None:
            self.is_ding_send = m.get('isDingSend')
        if m.get('isRead') is not None:
            self.is_read = m.get('isRead')
        if m.get('buttonStatus') is not None:
            self.button_status = m.get('buttonStatus')
        if m.get('extension') is not None:
            self.extension = m.get('extension')
        return self


class AddPluginRuleHeaders(TeaModel):
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


class AddPluginRuleRequestRules(TeaModel):
    def __init__(
        self,
        item_id: str = None,
        item_name: str = None,
    ):
        self.item_id = item_id
        self.item_name = item_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.item_id is not None:
            result['itemId'] = self.item_id
        if self.item_name is not None:
            result['itemName'] = self.item_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('itemId') is not None:
            self.item_id = m.get('itemId')
        if m.get('itemName') is not None:
            self.item_name = m.get('itemName')
        return self


class AddPluginRuleRequest(TeaModel):
    def __init__(
        self,
        chat_type: str = None,
        code: str = None,
        item_type: str = None,
        rules: List[AddPluginRuleRequestRules] = None,
        user_id: str = None,
    ):
        self.chat_type = chat_type
        self.code = code
        self.item_type = item_type
        self.rules = rules
        self.user_id = user_id

    def validate(self):
        if self.rules:
            for k in self.rules:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.chat_type is not None:
            result['chatType'] = self.chat_type
        if self.code is not None:
            result['code'] = self.code
        if self.item_type is not None:
            result['itemType'] = self.item_type
        result['rules'] = []
        if self.rules is not None:
            for k in self.rules:
                result['rules'].append(k.to_map() if k else None)
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('chatType') is not None:
            self.chat_type = m.get('chatType')
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('itemType') is not None:
            self.item_type = m.get('itemType')
        self.rules = []
        if m.get('rules') is not None:
            for k in m.get('rules'):
                temp_model = AddPluginRuleRequestRules()
                self.rules.append(temp_model.from_map(k))
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class AddPluginRuleResponseBody(TeaModel):
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


class AddPluginRuleResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AddPluginRuleResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = AddPluginRuleResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeletePlguinRuleHeaders(TeaModel):
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


class DeletePlguinRuleRequest(TeaModel):
    def __init__(
        self,
        biz_id_list: List[str] = None,
        user_id: str = None,
    ):
        self.biz_id_list = biz_id_list
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_id_list is not None:
            result['bizIdList'] = self.biz_id_list
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizIdList') is not None:
            self.biz_id_list = m.get('bizIdList')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class DeletePlguinRuleResponseBody(TeaModel):
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


class DeletePlguinRuleResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeletePlguinRuleResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = DeletePlguinRuleResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetBaseProfileListHeaders(TeaModel):
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


class GetBaseProfileListRequest(TeaModel):
    def __init__(
        self,
        body: List[str] = None,
    ):
        self.body = body

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.body is not None:
            result['body'] = self.body
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('body') is not None:
            self.body = m.get('body')
        return self


class GetBaseProfileListResponseBodyResult(TeaModel):
    def __init__(
        self,
        avatar_media_id: str = None,
        nick: str = None,
        nick_pinyin: str = None,
        user_id: str = None,
    ):
        self.avatar_media_id = avatar_media_id
        self.nick = nick
        self.nick_pinyin = nick_pinyin
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.avatar_media_id is not None:
            result['avatarMediaId'] = self.avatar_media_id
        if self.nick is not None:
            result['nick'] = self.nick
        if self.nick_pinyin is not None:
            result['nickPinyin'] = self.nick_pinyin
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('avatarMediaId') is not None:
            self.avatar_media_id = m.get('avatarMediaId')
        if m.get('nick') is not None:
            self.nick = m.get('nick')
        if m.get('nickPinyin') is not None:
            self.nick_pinyin = m.get('nickPinyin')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetBaseProfileListResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetBaseProfileListResponseBodyResult] = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        if self.result:
            for k in self.result:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['result'] = []
        if self.result is not None:
            for k in self.result:
                result['result'].append(k.to_map() if k else None)
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = GetBaseProfileListResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetBaseProfileListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetBaseProfileListResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = GetBaseProfileListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetConversationHeaders(TeaModel):
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


class GetConversationRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        user_id: str = None,
    ):
        self.open_conversation_id = open_conversation_id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetConversationResponseBodyResult(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        member_count: int = None,
        title: str = None,
    ):
        self.corp_id = corp_id
        self.member_count = member_count
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.member_count is not None:
            result['memberCount'] = self.member_count
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('memberCount') is not None:
            self.member_count = m.get('memberCount')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class GetConversationResponseBody(TeaModel):
    def __init__(
        self,
        result: GetConversationResponseBodyResult = None,
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
            temp_model = GetConversationResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetConversationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetConversationResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = GetConversationResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetMemberListHeaders(TeaModel):
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


class GetMemberListRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        page_number: int = None,
        page_size: int = None,
        user_id: str = None,
    ):
        self.open_conversation_id = open_conversation_id
        self.page_number = page_number
        self.page_size = page_size
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetMemberListResponseBody(TeaModel):
    def __init__(
        self,
        result: List[str] = None,
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


class GetMemberListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetMemberListResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = GetMemberListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryPluginRuleHeaders(TeaModel):
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


class QueryPluginRuleRequest(TeaModel):
    def __init__(
        self,
        chat_type: str = None,
        code: str = None,
        item_id: str = None,
        item_type: str = None,
        page_number: int = None,
        page_size: int = None,
    ):
        self.chat_type = chat_type
        self.code = code
        self.item_id = item_id
        self.item_type = item_type
        self.page_number = page_number
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.chat_type is not None:
            result['chatType'] = self.chat_type
        if self.code is not None:
            result['code'] = self.code
        if self.item_id is not None:
            result['itemId'] = self.item_id
        if self.item_type is not None:
            result['itemType'] = self.item_type
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('chatType') is not None:
            self.chat_type = m.get('chatType')
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('itemId') is not None:
            self.item_id = m.get('itemId')
        if m.get('itemType') is not None:
            self.item_type = m.get('itemType')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class QueryPluginRuleResponseBodyResultData(TeaModel):
    def __init__(
        self,
        biz_id: str = None,
        chat_type: str = None,
        code: str = None,
        gmt_create: str = None,
        item_id: str = None,
        item_name: str = None,
        item_type: str = None,
    ):
        self.biz_id = biz_id
        self.chat_type = chat_type
        self.code = code
        self.gmt_create = gmt_create
        self.item_id = item_id
        self.item_name = item_name
        self.item_type = item_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_id is not None:
            result['bizId'] = self.biz_id
        if self.chat_type is not None:
            result['chatType'] = self.chat_type
        if self.code is not None:
            result['code'] = self.code
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.item_id is not None:
            result['itemId'] = self.item_id
        if self.item_name is not None:
            result['itemName'] = self.item_name
        if self.item_type is not None:
            result['itemType'] = self.item_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        if m.get('chatType') is not None:
            self.chat_type = m.get('chatType')
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('itemId') is not None:
            self.item_id = m.get('itemId')
        if m.get('itemName') is not None:
            self.item_name = m.get('itemName')
        if m.get('itemType') is not None:
            self.item_type = m.get('itemType')
        return self


class QueryPluginRuleResponseBodyResult(TeaModel):
    def __init__(
        self,
        data: List[QueryPluginRuleResponseBodyResultData] = None,
        total: int = None,
    ):
        self.data = data
        self.total = total

    def validate(self):
        if self.data:
            for k in self.data:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['data'] = []
        if self.data is not None:
            for k in self.data:
                result['data'].append(k.to_map() if k else None)
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = QueryPluginRuleResponseBodyResultData()
                self.data.append(temp_model.from_map(k))
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class QueryPluginRuleResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryPluginRuleResponseBodyResult = None,
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
            temp_model = QueryPluginRuleResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryPluginRuleResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryPluginRuleResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = QueryPluginRuleResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SendDingTipHeaders(TeaModel):
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


class SendDingTipRequestLink(TeaModel):
    def __init__(
        self,
        extension: Dict[str, str] = None,
        link_url: str = None,
        pic_media_id: str = None,
        text: str = None,
    ):
        self.extension = extension
        self.link_url = link_url
        self.pic_media_id = pic_media_id
        self.text = text

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.extension is not None:
            result['extension'] = self.extension
        if self.link_url is not None:
            result['linkUrl'] = self.link_url
        if self.pic_media_id is not None:
            result['picMediaId'] = self.pic_media_id
        if self.text is not None:
            result['text'] = self.text
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('extension') is not None:
            self.extension = m.get('extension')
        if m.get('linkUrl') is not None:
            self.link_url = m.get('linkUrl')
        if m.get('picMediaId') is not None:
            self.pic_media_id = m.get('picMediaId')
        if m.get('text') is not None:
            self.text = m.get('text')
        return self


class SendDingTipRequest(TeaModel):
    def __init__(
        self,
        extension: Dict[str, str] = None,
        link: SendDingTipRequestLink = None,
        message_id: str = None,
        receiver_user_id: List[str] = None,
        sender_user_id: str = None,
        text_content: str = None,
    ):
        self.extension = extension
        self.link = link
        self.message_id = message_id
        self.receiver_user_id = receiver_user_id
        self.sender_user_id = sender_user_id
        self.text_content = text_content

    def validate(self):
        if self.link:
            self.link.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.extension is not None:
            result['extension'] = self.extension
        if self.link is not None:
            result['link'] = self.link.to_map()
        if self.message_id is not None:
            result['messageId'] = self.message_id
        if self.receiver_user_id is not None:
            result['receiverUserId'] = self.receiver_user_id
        if self.sender_user_id is not None:
            result['senderUserId'] = self.sender_user_id
        if self.text_content is not None:
            result['textContent'] = self.text_content
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('extension') is not None:
            self.extension = m.get('extension')
        if m.get('link') is not None:
            temp_model = SendDingTipRequestLink()
            self.link = temp_model.from_map(m['link'])
        if m.get('messageId') is not None:
            self.message_id = m.get('messageId')
        if m.get('receiverUserId') is not None:
            self.receiver_user_id = m.get('receiverUserId')
        if m.get('senderUserId') is not None:
            self.sender_user_id = m.get('senderUserId')
        if m.get('textContent') is not None:
            self.text_content = m.get('textContent')
        return self


class SendDingTipResponseBody(TeaModel):
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


class SendDingTipResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SendDingTipResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = SendDingTipResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SendMessageTipHeaders(TeaModel):
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


class SendMessageTipRequestDefaultView(TeaModel):
    def __init__(
        self,
        action_name: str = None,
        action_url: str = None,
        auth_code: str = None,
        auth_media_id: str = None,
        card_title: str = None,
        card_title_color: str = None,
        desc: str = None,
        media_id: str = None,
        need_show_update_tail: str = None,
        summary: str = None,
        title: str = None,
    ):
        self.action_name = action_name
        self.action_url = action_url
        self.auth_code = auth_code
        self.auth_media_id = auth_media_id
        self.card_title = card_title
        self.card_title_color = card_title_color
        self.desc = desc
        self.media_id = media_id
        self.need_show_update_tail = need_show_update_tail
        self.summary = summary
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action_name is not None:
            result['actionName'] = self.action_name
        if self.action_url is not None:
            result['actionUrl'] = self.action_url
        if self.auth_code is not None:
            result['authCode'] = self.auth_code
        if self.auth_media_id is not None:
            result['authMediaId'] = self.auth_media_id
        if self.card_title is not None:
            result['cardTitle'] = self.card_title
        if self.card_title_color is not None:
            result['cardTitleColor'] = self.card_title_color
        if self.desc is not None:
            result['desc'] = self.desc
        if self.media_id is not None:
            result['mediaId'] = self.media_id
        if self.need_show_update_tail is not None:
            result['needShowUpdateTail'] = self.need_show_update_tail
        if self.summary is not None:
            result['summary'] = self.summary
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionName') is not None:
            self.action_name = m.get('actionName')
        if m.get('actionUrl') is not None:
            self.action_url = m.get('actionUrl')
        if m.get('authCode') is not None:
            self.auth_code = m.get('authCode')
        if m.get('authMediaId') is not None:
            self.auth_media_id = m.get('authMediaId')
        if m.get('cardTitle') is not None:
            self.card_title = m.get('cardTitle')
        if m.get('cardTitleColor') is not None:
            self.card_title_color = m.get('cardTitleColor')
        if m.get('desc') is not None:
            self.desc = m.get('desc')
        if m.get('mediaId') is not None:
            self.media_id = m.get('mediaId')
        if m.get('needShowUpdateTail') is not None:
            self.need_show_update_tail = m.get('needShowUpdateTail')
        if m.get('summary') is not None:
            self.summary = m.get('summary')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class SendMessageTipRequestPublicField(TeaModel):
    def __init__(
        self,
        detail_url: str = None,
        duration_desc: str = None,
        extension: Dict[str, str] = None,
        is_expired: bool = None,
        read_action_url: str = None,
        read_progress_desc: str = None,
    ):
        self.detail_url = detail_url
        self.duration_desc = duration_desc
        self.extension = extension
        self.is_expired = is_expired
        self.read_action_url = read_action_url
        self.read_progress_desc = read_progress_desc

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.detail_url is not None:
            result['detailUrl'] = self.detail_url
        if self.duration_desc is not None:
            result['durationDesc'] = self.duration_desc
        if self.extension is not None:
            result['extension'] = self.extension
        if self.is_expired is not None:
            result['isExpired'] = self.is_expired
        if self.read_action_url is not None:
            result['readActionUrl'] = self.read_action_url
        if self.read_progress_desc is not None:
            result['readProgressDesc'] = self.read_progress_desc
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('detailUrl') is not None:
            self.detail_url = m.get('detailUrl')
        if m.get('durationDesc') is not None:
            self.duration_desc = m.get('durationDesc')
        if m.get('extension') is not None:
            self.extension = m.get('extension')
        if m.get('isExpired') is not None:
            self.is_expired = m.get('isExpired')
        if m.get('readActionUrl') is not None:
            self.read_action_url = m.get('readActionUrl')
        if m.get('readProgressDesc') is not None:
            self.read_progress_desc = m.get('readProgressDesc')
        return self


class SendMessageTipRequest(TeaModel):
    def __init__(
        self,
        default_view: SendMessageTipRequestDefaultView = None,
        message_id: str = None,
        open_conversation_id: str = None,
        private_field_map: Dict[str, PrivateFieldMapValue] = None,
        public_field: SendMessageTipRequestPublicField = None,
        receiver_user_id: List[str] = None,
        sender_user_id: str = None,
    ):
        self.default_view = default_view
        self.message_id = message_id
        self.open_conversation_id = open_conversation_id
        self.private_field_map = private_field_map
        self.public_field = public_field
        self.receiver_user_id = receiver_user_id
        self.sender_user_id = sender_user_id

    def validate(self):
        if self.default_view:
            self.default_view.validate()
        if self.private_field_map:
            for v in self.private_field_map.values():
                if v:
                    v.validate()
        if self.public_field:
            self.public_field.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.default_view is not None:
            result['defaultView'] = self.default_view.to_map()
        if self.message_id is not None:
            result['messageId'] = self.message_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        result['privateFieldMap'] = {}
        if self.private_field_map is not None:
            for k, v in self.private_field_map.items():
                result['privateFieldMap'][k] = v.to_map()
        if self.public_field is not None:
            result['publicField'] = self.public_field.to_map()
        if self.receiver_user_id is not None:
            result['receiverUserId'] = self.receiver_user_id
        if self.sender_user_id is not None:
            result['senderUserId'] = self.sender_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('defaultView') is not None:
            temp_model = SendMessageTipRequestDefaultView()
            self.default_view = temp_model.from_map(m['defaultView'])
        if m.get('messageId') is not None:
            self.message_id = m.get('messageId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        self.private_field_map = {}
        if m.get('privateFieldMap') is not None:
            for k, v in m.get('privateFieldMap').items():
                temp_model = PrivateFieldMapValue()
                self.private_field_map[k] = temp_model.from_map(v)
        if m.get('publicField') is not None:
            temp_model = SendMessageTipRequestPublicField()
            self.public_field = temp_model.from_map(m['publicField'])
        if m.get('receiverUserId') is not None:
            self.receiver_user_id = m.get('receiverUserId')
        if m.get('senderUserId') is not None:
            self.sender_user_id = m.get('senderUserId')
        return self


class SendMessageTipResponseBodyResult(TeaModel):
    def __init__(
        self,
        biz_id: str = None,
        card_instance_id: str = None,
    ):
        self.biz_id = biz_id
        self.card_instance_id = card_instance_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_id is not None:
            result['bizId'] = self.biz_id
        if self.card_instance_id is not None:
            result['cardInstanceId'] = self.card_instance_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        if m.get('cardInstanceId') is not None:
            self.card_instance_id = m.get('cardInstanceId')
        return self


class SendMessageTipResponseBody(TeaModel):
    def __init__(
        self,
        result: SendMessageTipResponseBodyResult = None,
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
            temp_model = SendMessageTipResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class SendMessageTipResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SendMessageTipResponseBody = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.status_code, 'status_code')
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
            temp_model = SendMessageTipResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


