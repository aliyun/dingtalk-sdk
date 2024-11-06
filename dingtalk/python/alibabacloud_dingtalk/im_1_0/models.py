# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List, Any


class PrivateDataValue(TeaModel):
    def __init__(
        self,
        card_param_map: Dict[str, str] = None,
        card_media_id_param_map: Dict[str, str] = None,
    ):
        self.card_param_map = card_param_map
        self.card_media_id_param_map = card_media_id_param_map

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.card_param_map is not None:
            result['cardParamMap'] = self.card_param_map
        if self.card_media_id_param_map is not None:
            result['cardMediaIdParamMap'] = self.card_media_id_param_map
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cardParamMap') is not None:
            self.card_param_map = m.get('cardParamMap')
        if m.get('cardMediaIdParamMap') is not None:
            self.card_media_id_param_map = m.get('cardMediaIdParamMap')
        return self


class AddOrgTextEmotionHeaders(TeaModel):
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


class AddOrgTextEmotionRequest(TeaModel):
    def __init__(
        self,
        background_media_id: str = None,
        background_media_id_for_panel: str = None,
        dept_id: int = None,
        emotion_name: str = None,
    ):
        # This parameter is required.
        self.background_media_id = background_media_id
        # This parameter is required.
        self.background_media_id_for_panel = background_media_id_for_panel
        # This parameter is required.
        self.dept_id = dept_id
        # This parameter is required.
        self.emotion_name = emotion_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.background_media_id is not None:
            result['backgroundMediaId'] = self.background_media_id
        if self.background_media_id_for_panel is not None:
            result['backgroundMediaIdForPanel'] = self.background_media_id_for_panel
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.emotion_name is not None:
            result['emotionName'] = self.emotion_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('backgroundMediaId') is not None:
            self.background_media_id = m.get('backgroundMediaId')
        if m.get('backgroundMediaIdForPanel') is not None:
            self.background_media_id_for_panel = m.get('backgroundMediaIdForPanel')
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('emotionName') is not None:
            self.emotion_name = m.get('emotionName')
        return self


class AddOrgTextEmotionResponseBodyResult(TeaModel):
    def __init__(
        self,
        emotion_id: str = None,
    ):
        self.emotion_id = emotion_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.emotion_id is not None:
            result['emotionId'] = self.emotion_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('emotionId') is not None:
            self.emotion_id = m.get('emotionId')
        return self


class AddOrgTextEmotionResponseBody(TeaModel):
    def __init__(
        self,
        result: AddOrgTextEmotionResponseBodyResult = None,
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
            temp_model = AddOrgTextEmotionResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class AddOrgTextEmotionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AddOrgTextEmotionResponseBody = None,
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
            temp_model = AddOrgTextEmotionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AddRobotToConversationHeaders(TeaModel):
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


class AddRobotToConversationRequest(TeaModel):
    def __init__(
        self,
        icon: str = None,
        name: str = None,
        open_conversation_id: str = None,
        robot_code: str = None,
    ):
        self.icon = icon
        self.name = name
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.robot_code = robot_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.icon is not None:
            result['icon'] = self.icon
        if self.name is not None:
            result['name'] = self.name
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        return self


class AddRobotToConversationResponseBody(TeaModel):
    def __init__(
        self,
        chat_bot_user_id: str = None,
    ):
        self.chat_bot_user_id = chat_bot_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.chat_bot_user_id is not None:
            result['chatBotUserId'] = self.chat_bot_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('chatBotUserId') is not None:
            self.chat_bot_user_id = m.get('chatBotUserId')
        return self


class AddRobotToConversationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AddRobotToConversationResponseBody = None,
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
            temp_model = AddRobotToConversationResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AddUnfurlingRegisterHeaders(TeaModel):
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


class AddUnfurlingRegisterRequest(TeaModel):
    def __init__(
        self,
        api_secret: str = None,
        app_id: str = None,
        callback_url: str = None,
        card_template_id: str = None,
        domain: str = None,
        path: str = None,
        rule_desc: str = None,
        rule_match_type: int = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.api_secret = api_secret
        # This parameter is required.
        self.app_id = app_id
        # This parameter is required.
        self.callback_url = callback_url
        # This parameter is required.
        self.card_template_id = card_template_id
        # This parameter is required.
        self.domain = domain
        # This parameter is required.
        self.path = path
        self.rule_desc = rule_desc
        # This parameter is required.
        self.rule_match_type = rule_match_type
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.api_secret is not None:
            result['apiSecret'] = self.api_secret
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.callback_url is not None:
            result['callbackUrl'] = self.callback_url
        if self.card_template_id is not None:
            result['cardTemplateId'] = self.card_template_id
        if self.domain is not None:
            result['domain'] = self.domain
        if self.path is not None:
            result['path'] = self.path
        if self.rule_desc is not None:
            result['ruleDesc'] = self.rule_desc
        if self.rule_match_type is not None:
            result['ruleMatchType'] = self.rule_match_type
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('apiSecret') is not None:
            self.api_secret = m.get('apiSecret')
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('callbackUrl') is not None:
            self.callback_url = m.get('callbackUrl')
        if m.get('cardTemplateId') is not None:
            self.card_template_id = m.get('cardTemplateId')
        if m.get('domain') is not None:
            self.domain = m.get('domain')
        if m.get('path') is not None:
            self.path = m.get('path')
        if m.get('ruleDesc') is not None:
            self.rule_desc = m.get('ruleDesc')
        if m.get('ruleMatchType') is not None:
            self.rule_match_type = m.get('ruleMatchType')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class AddUnfurlingRegisterResponseBody(TeaModel):
    def __init__(
        self,
        id: int = None,
        success: bool = None,
    ):
        self.id = id
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class AddUnfurlingRegisterResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AddUnfurlingRegisterResponseBody = None,
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
            temp_model = AddUnfurlingRegisterResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AutoOpenDingTalkConnectHeaders(TeaModel):
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


class AutoOpenDingTalkConnectResponseBody(TeaModel):
    def __init__(
        self,
        message: str = None,
    ):
        self.message = message

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.message is not None:
            result['message'] = self.message
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('message') is not None:
            self.message = m.get('message')
        return self


class AutoOpenDingTalkConnectResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AutoOpenDingTalkConnectResponseBody = None,
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
            temp_model = AutoOpenDingTalkConnectResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BatchQueryFamilySchoolMessageHeaders(TeaModel):
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


class BatchQueryFamilySchoolMessageRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        open_message_ids: List[str] = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.open_message_ids = open_message_ids
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.open_message_ids is not None:
            result['openMessageIds'] = self.open_message_ids
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('openMessageIds') is not None:
            self.open_message_ids = m.get('openMessageIds')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class BatchQueryFamilySchoolMessageResponseBodyMessagesMediaModels(TeaModel):
    def __init__(
        self,
        file_name: str = None,
        file_type: str = None,
        media_id: str = None,
        size: str = None,
        url: str = None,
        video_pic_media_id: str = None,
    ):
        self.file_name = file_name
        self.file_type = file_type
        self.media_id = media_id
        self.size = size
        self.url = url
        self.video_pic_media_id = video_pic_media_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.file_type is not None:
            result['fileType'] = self.file_type
        if self.media_id is not None:
            result['mediaId'] = self.media_id
        if self.size is not None:
            result['size'] = self.size
        if self.url is not None:
            result['url'] = self.url
        if self.video_pic_media_id is not None:
            result['videoPicMediaId'] = self.video_pic_media_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('fileType') is not None:
            self.file_type = m.get('fileType')
        if m.get('mediaId') is not None:
            self.media_id = m.get('mediaId')
        if m.get('size') is not None:
            self.size = m.get('size')
        if m.get('url') is not None:
            self.url = m.get('url')
        if m.get('videoPicMediaId') is not None:
            self.video_pic_media_id = m.get('videoPicMediaId')
        return self


class BatchQueryFamilySchoolMessageResponseBodyMessages(TeaModel):
    def __init__(
        self,
        content_type: int = None,
        create_at: int = None,
        media_models: List[BatchQueryFamilySchoolMessageResponseBodyMessagesMediaModels] = None,
        open_msg_id: str = None,
    ):
        self.content_type = content_type
        self.create_at = create_at
        self.media_models = media_models
        self.open_msg_id = open_msg_id

    def validate(self):
        if self.media_models:
            for k in self.media_models:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content_type is not None:
            result['contentType'] = self.content_type
        if self.create_at is not None:
            result['createAt'] = self.create_at
        result['mediaModels'] = []
        if self.media_models is not None:
            for k in self.media_models:
                result['mediaModels'].append(k.to_map() if k else None)
        if self.open_msg_id is not None:
            result['openMsgId'] = self.open_msg_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('contentType') is not None:
            self.content_type = m.get('contentType')
        if m.get('createAt') is not None:
            self.create_at = m.get('createAt')
        self.media_models = []
        if m.get('mediaModels') is not None:
            for k in m.get('mediaModels'):
                temp_model = BatchQueryFamilySchoolMessageResponseBodyMessagesMediaModels()
                self.media_models.append(temp_model.from_map(k))
        if m.get('openMsgId') is not None:
            self.open_msg_id = m.get('openMsgId')
        return self


class BatchQueryFamilySchoolMessageResponseBody(TeaModel):
    def __init__(
        self,
        messages: List[BatchQueryFamilySchoolMessageResponseBodyMessages] = None,
    ):
        self.messages = messages

    def validate(self):
        if self.messages:
            for k in self.messages:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['messages'] = []
        if self.messages is not None:
            for k in self.messages:
                result['messages'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.messages = []
        if m.get('messages') is not None:
            for k in m.get('messages'):
                temp_model = BatchQueryFamilySchoolMessageResponseBodyMessages()
                self.messages.append(temp_model.from_map(k))
        return self


class BatchQueryFamilySchoolMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BatchQueryFamilySchoolMessageResponseBody = None,
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
            temp_model = BatchQueryFamilySchoolMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BatchQueryGroupMemberHeaders(TeaModel):
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


class BatchQueryGroupMemberRequest(TeaModel):
    def __init__(
        self,
        cool_app_code: str = None,
        max_results: int = None,
        next_token: str = None,
        open_conversation_id: str = None,
    ):
        self.cool_app_code = cool_app_code
        # This parameter is required.
        self.max_results = max_results
        self.next_token = next_token
        # This parameter is required.
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cool_app_code is not None:
            result['coolAppCode'] = self.cool_app_code
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('coolAppCode') is not None:
            self.cool_app_code = m.get('coolAppCode')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class BatchQueryGroupMemberResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        member_user_ids: List[str] = None,
        next_token: str = None,
        success: bool = None,
    ):
        self.has_more = has_more
        self.member_user_ids = member_user_ids
        self.next_token = next_token
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.member_user_ids is not None:
            result['memberUserIds'] = self.member_user_ids
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('memberUserIds') is not None:
            self.member_user_ids = m.get('memberUserIds')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class BatchQueryGroupMemberResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BatchQueryGroupMemberResponseBody = None,
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
            temp_model = BatchQueryGroupMemberResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CardTemplateBuildActionHeaders(TeaModel):
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


class CardTemplateBuildActionRequest(TeaModel):
    def __init__(
        self,
        action: str = None,
        card_template_json: str = None,
    ):
        # This parameter is required.
        self.action = action
        # This parameter is required.
        self.card_template_json = card_template_json

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action is not None:
            result['action'] = self.action
        if self.card_template_json is not None:
            result['cardTemplateJson'] = self.card_template_json
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('action') is not None:
            self.action = m.get('action')
        if m.get('cardTemplateJson') is not None:
            self.card_template_json = m.get('cardTemplateJson')
        return self


class CardTemplateBuildActionResponseBody(TeaModel):
    def __init__(
        self,
        card_template_json: str = None,
    ):
        self.card_template_json = card_template_json

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.card_template_json is not None:
            result['cardTemplateJson'] = self.card_template_json
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cardTemplateJson') is not None:
            self.card_template_json = m.get('cardTemplateJson')
        return self


class CardTemplateBuildActionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CardTemplateBuildActionResponseBody = None,
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
            temp_model = CardTemplateBuildActionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ChangeGroupOwnerHeaders(TeaModel):
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


class ChangeGroupOwnerRequest(TeaModel):
    def __init__(
        self,
        group_owner_id: str = None,
        group_owner_type: int = None,
        open_conversation_id: str = None,
    ):
        # This parameter is required.
        self.group_owner_id = group_owner_id
        # This parameter is required.
        self.group_owner_type = group_owner_type
        # This parameter is required.
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_owner_id is not None:
            result['groupOwnerId'] = self.group_owner_id
        if self.group_owner_type is not None:
            result['groupOwnerType'] = self.group_owner_type
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupOwnerId') is not None:
            self.group_owner_id = m.get('groupOwnerId')
        if m.get('groupOwnerType') is not None:
            self.group_owner_type = m.get('groupOwnerType')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class ChangeGroupOwnerResponseBody(TeaModel):
    def __init__(
        self,
        new_group_owner_id: str = None,
        new_group_owner_type: int = None,
    ):
        self.new_group_owner_id = new_group_owner_id
        self.new_group_owner_type = new_group_owner_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.new_group_owner_id is not None:
            result['newGroupOwnerId'] = self.new_group_owner_id
        if self.new_group_owner_type is not None:
            result['newGroupOwnerType'] = self.new_group_owner_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('newGroupOwnerId') is not None:
            self.new_group_owner_id = m.get('newGroupOwnerId')
        if m.get('newGroupOwnerType') is not None:
            self.new_group_owner_type = m.get('newGroupOwnerType')
        return self


class ChangeGroupOwnerResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ChangeGroupOwnerResponseBody = None,
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
            temp_model = ChangeGroupOwnerResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ChatIdToOpenConversationIdHeaders(TeaModel):
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


class ChatIdToOpenConversationIdResponseBody(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
    ):
        # This parameter is required.
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class ChatIdToOpenConversationIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ChatIdToOpenConversationIdResponseBody = None,
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
            temp_model = ChatIdToOpenConversationIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ChatSubAdminUpdateHeaders(TeaModel):
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


class ChatSubAdminUpdateRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        role: int = None,
        user_ids: List[str] = None,
    ):
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.role = role
        # This parameter is required.
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.role is not None:
            result['role'] = self.role
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('role') is not None:
            self.role = m.get('role')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class ChatSubAdminUpdateResponseBody(TeaModel):
    def __init__(
        self,
        success: str = None,
    ):
        # This parameter is required.
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


class ChatSubAdminUpdateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ChatSubAdminUpdateResponseBody = None,
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
            temp_model = ChatSubAdminUpdateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CheckUserIsGroupMemberHeaders(TeaModel):
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


class CheckUserIsGroupMemberRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
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


class CheckUserIsGroupMemberResponseBody(TeaModel):
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


class CheckUserIsGroupMemberResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CheckUserIsGroupMemberResponseBody = None,
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
            temp_model = CheckUserIsGroupMemberResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CopyUnfurlingRegisterHeaders(TeaModel):
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


class CopyUnfurlingRegisterRequest(TeaModel):
    def __init__(
        self,
        app_id: str = None,
        id: int = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_id = app_id
        # This parameter is required.
        self.id = id
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.id is not None:
            result['id'] = self.id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CopyUnfurlingRegisterResponseBody(TeaModel):
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


class CopyUnfurlingRegisterResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CopyUnfurlingRegisterResponseBody = None,
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
            temp_model = CopyUnfurlingRegisterResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CountOpenMsgSceneGroupsHeaders(TeaModel):
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


class CountOpenMsgSceneGroupsRequest(TeaModel):
    def __init__(
        self,
        template_id: str = None,
    ):
        # This parameter is required.
        self.template_id = template_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.template_id is not None:
            result['templateId'] = self.template_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('templateId') is not None:
            self.template_id = m.get('templateId')
        return self


class CountOpenMsgSceneGroupsResponseBodyResult(TeaModel):
    def __init__(
        self,
        count: int = None,
    ):
        self.count = count

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.count is not None:
            result['count'] = self.count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('count') is not None:
            self.count = m.get('count')
        return self


class CountOpenMsgSceneGroupsResponseBody(TeaModel):
    def __init__(
        self,
        result: CountOpenMsgSceneGroupsResponseBodyResult = None,
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
            temp_model = CountOpenMsgSceneGroupsResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class CountOpenMsgSceneGroupsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CountOpenMsgSceneGroupsResponseBody = None,
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
            temp_model = CountOpenMsgSceneGroupsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CountSceneGroupsByTemplateIdHeaders(TeaModel):
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


class CountSceneGroupsByTemplateIdResponseBody(TeaModel):
    def __init__(
        self,
        count: int = None,
        success: bool = None,
    ):
        self.count = count
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.count is not None:
            result['count'] = self.count
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('count') is not None:
            self.count = m.get('count')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class CountSceneGroupsByTemplateIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CountSceneGroupsByTemplateIdResponseBody = None,
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
            temp_model = CountSceneGroupsByTemplateIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateCoupleGroupConversationHeaders(TeaModel):
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


class CreateCoupleGroupConversationRequest(TeaModel):
    def __init__(
        self,
        app_user_id: str = None,
        group_avatar: str = None,
        group_name: str = None,
        group_owner_id: str = None,
        group_template_id: str = None,
        operator_id: str = None,
    ):
        # This parameter is required.
        self.app_user_id = app_user_id
        self.group_avatar = group_avatar
        # This parameter is required.
        self.group_name = group_name
        # This parameter is required.
        self.group_owner_id = group_owner_id
        # This parameter is required.
        self.group_template_id = group_template_id
        # This parameter is required.
        self.operator_id = operator_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_user_id is not None:
            result['appUserId'] = self.app_user_id
        if self.group_avatar is not None:
            result['groupAvatar'] = self.group_avatar
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.group_owner_id is not None:
            result['groupOwnerId'] = self.group_owner_id
        if self.group_template_id is not None:
            result['groupTemplateId'] = self.group_template_id
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUserId') is not None:
            self.app_user_id = m.get('appUserId')
        if m.get('groupAvatar') is not None:
            self.group_avatar = m.get('groupAvatar')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('groupOwnerId') is not None:
            self.group_owner_id = m.get('groupOwnerId')
        if m.get('groupTemplateId') is not None:
            self.group_template_id = m.get('groupTemplateId')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        return self


class CreateCoupleGroupConversationResponseBody(TeaModel):
    def __init__(
        self,
        conversation_id: str = None,
        open_conversation_id: str = None,
    ):
        # This parameter is required.
        self.conversation_id = conversation_id
        # This parameter is required.
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conversation_id is not None:
            result['conversationId'] = self.conversation_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conversationId') is not None:
            self.conversation_id = m.get('conversationId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class CreateCoupleGroupConversationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateCoupleGroupConversationResponseBody = None,
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
            temp_model = CreateCoupleGroupConversationResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateGroupConversationHeaders(TeaModel):
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


class CreateGroupConversationRequest(TeaModel):
    def __init__(
        self,
        app_user_ids: List[str] = None,
        group_avatar: str = None,
        group_name: str = None,
        group_owner_id: str = None,
        group_owner_type: int = None,
        group_template_id: str = None,
        operator_id: str = None,
        user_ids: List[str] = None,
    ):
        self.app_user_ids = app_user_ids
        self.group_avatar = group_avatar
        # This parameter is required.
        self.group_name = group_name
        # This parameter is required.
        self.group_owner_id = group_owner_id
        self.group_owner_type = group_owner_type
        # This parameter is required.
        self.group_template_id = group_template_id
        # This parameter is required.
        self.operator_id = operator_id
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_user_ids is not None:
            result['appUserIds'] = self.app_user_ids
        if self.group_avatar is not None:
            result['groupAvatar'] = self.group_avatar
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.group_owner_id is not None:
            result['groupOwnerId'] = self.group_owner_id
        if self.group_owner_type is not None:
            result['groupOwnerType'] = self.group_owner_type
        if self.group_template_id is not None:
            result['groupTemplateId'] = self.group_template_id
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUserIds') is not None:
            self.app_user_ids = m.get('appUserIds')
        if m.get('groupAvatar') is not None:
            self.group_avatar = m.get('groupAvatar')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('groupOwnerId') is not None:
            self.group_owner_id = m.get('groupOwnerId')
        if m.get('groupOwnerType') is not None:
            self.group_owner_type = m.get('groupOwnerType')
        if m.get('groupTemplateId') is not None:
            self.group_template_id = m.get('groupTemplateId')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class CreateGroupConversationResponseBody(TeaModel):
    def __init__(
        self,
        app_user_ids: List[str] = None,
        conversation_id: str = None,
        open_conversation_id: str = None,
        user_ids: List[str] = None,
    ):
        # This parameter is required.
        self.app_user_ids = app_user_ids
        # This parameter is required.
        self.conversation_id = conversation_id
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_user_ids is not None:
            result['appUserIds'] = self.app_user_ids
        if self.conversation_id is not None:
            result['conversationId'] = self.conversation_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUserIds') is not None:
            self.app_user_ids = m.get('appUserIds')
        if m.get('conversationId') is not None:
            self.conversation_id = m.get('conversationId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class CreateGroupConversationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateGroupConversationResponseBody = None,
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
            temp_model = CreateGroupConversationResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateInterconnectionHeaders(TeaModel):
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


class CreateInterconnectionRequestInterconnections(TeaModel):
    def __init__(
        self,
        app_user_avatar: str = None,
        app_user_avatar_media_type: int = None,
        app_user_dynamics: str = None,
        app_user_id: str = None,
        app_user_mobile: str = None,
        app_user_name: str = None,
        channel_code: str = None,
        user_id: str = None,
    ):
        self.app_user_avatar = app_user_avatar
        self.app_user_avatar_media_type = app_user_avatar_media_type
        self.app_user_dynamics = app_user_dynamics
        # This parameter is required.
        self.app_user_id = app_user_id
        # This parameter is required.
        self.app_user_mobile = app_user_mobile
        # This parameter is required.
        self.app_user_name = app_user_name
        # This parameter is required.
        self.channel_code = channel_code
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_user_avatar is not None:
            result['appUserAvatar'] = self.app_user_avatar
        if self.app_user_avatar_media_type is not None:
            result['appUserAvatarMediaType'] = self.app_user_avatar_media_type
        if self.app_user_dynamics is not None:
            result['appUserDynamics'] = self.app_user_dynamics
        if self.app_user_id is not None:
            result['appUserId'] = self.app_user_id
        if self.app_user_mobile is not None:
            result['appUserMobile'] = self.app_user_mobile
        if self.app_user_name is not None:
            result['appUserName'] = self.app_user_name
        if self.channel_code is not None:
            result['channelCode'] = self.channel_code
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUserAvatar') is not None:
            self.app_user_avatar = m.get('appUserAvatar')
        if m.get('appUserAvatarMediaType') is not None:
            self.app_user_avatar_media_type = m.get('appUserAvatarMediaType')
        if m.get('appUserDynamics') is not None:
            self.app_user_dynamics = m.get('appUserDynamics')
        if m.get('appUserId') is not None:
            self.app_user_id = m.get('appUserId')
        if m.get('appUserMobile') is not None:
            self.app_user_mobile = m.get('appUserMobile')
        if m.get('appUserName') is not None:
            self.app_user_name = m.get('appUserName')
        if m.get('channelCode') is not None:
            self.channel_code = m.get('channelCode')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CreateInterconnectionRequest(TeaModel):
    def __init__(
        self,
        interconnections: List[CreateInterconnectionRequestInterconnections] = None,
    ):
        # This parameter is required.
        self.interconnections = interconnections

    def validate(self):
        if self.interconnections:
            for k in self.interconnections:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['interconnections'] = []
        if self.interconnections is not None:
            for k in self.interconnections:
                result['interconnections'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.interconnections = []
        if m.get('interconnections') is not None:
            for k in m.get('interconnections'):
                temp_model = CreateInterconnectionRequestInterconnections()
                self.interconnections.append(temp_model.from_map(k))
        return self


class CreateInterconnectionResponseBodyResults(TeaModel):
    def __init__(
        self,
        app_user_id: str = None,
        message: str = None,
        user_id: str = None,
    ):
        self.app_user_id = app_user_id
        self.message = message
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_user_id is not None:
            result['appUserId'] = self.app_user_id
        if self.message is not None:
            result['message'] = self.message
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUserId') is not None:
            self.app_user_id = m.get('appUserId')
        if m.get('message') is not None:
            self.message = m.get('message')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CreateInterconnectionResponseBody(TeaModel):
    def __init__(
        self,
        results: List[CreateInterconnectionResponseBodyResults] = None,
    ):
        self.results = results

    def validate(self):
        if self.results:
            for k in self.results:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['results'] = []
        if self.results is not None:
            for k in self.results:
                result['results'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.results = []
        if m.get('results') is not None:
            for k in m.get('results'):
                temp_model = CreateInterconnectionResponseBodyResults()
                self.results.append(temp_model.from_map(k))
        return self


class CreateInterconnectionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateInterconnectionResponseBody = None,
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
            temp_model = CreateInterconnectionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateSceneGroupConversationHeaders(TeaModel):
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


class CreateSceneGroupConversationRequestManagementOptions(TeaModel):
    def __init__(
        self,
        chat_banned_type: int = None,
        management_type: int = None,
        mention_all_authority: int = None,
        searchable: int = None,
        show_history_type: int = None,
        validation_type: int = None,
    ):
        self.chat_banned_type = chat_banned_type
        self.management_type = management_type
        self.mention_all_authority = mention_all_authority
        self.searchable = searchable
        self.show_history_type = show_history_type
        self.validation_type = validation_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.chat_banned_type is not None:
            result['chatBannedType'] = self.chat_banned_type
        if self.management_type is not None:
            result['managementType'] = self.management_type
        if self.mention_all_authority is not None:
            result['mentionAllAuthority'] = self.mention_all_authority
        if self.searchable is not None:
            result['searchable'] = self.searchable
        if self.show_history_type is not None:
            result['showHistoryType'] = self.show_history_type
        if self.validation_type is not None:
            result['validationType'] = self.validation_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('chatBannedType') is not None:
            self.chat_banned_type = m.get('chatBannedType')
        if m.get('managementType') is not None:
            self.management_type = m.get('managementType')
        if m.get('mentionAllAuthority') is not None:
            self.mention_all_authority = m.get('mentionAllAuthority')
        if m.get('searchable') is not None:
            self.searchable = m.get('searchable')
        if m.get('showHistoryType') is not None:
            self.show_history_type = m.get('showHistoryType')
        if m.get('validationType') is not None:
            self.validation_type = m.get('validationType')
        return self


class CreateSceneGroupConversationRequest(TeaModel):
    def __init__(
        self,
        features: Dict[str, str] = None,
        group_name: str = None,
        group_owner_id: str = None,
        icon: str = None,
        management_options: CreateSceneGroupConversationRequestManagementOptions = None,
        template_id: str = None,
        user_id_list: List[str] = None,
        uuid: str = None,
    ):
        self.features = features
        # This parameter is required.
        self.group_name = group_name
        # This parameter is required.
        self.group_owner_id = group_owner_id
        self.icon = icon
        self.management_options = management_options
        # This parameter is required.
        self.template_id = template_id
        self.user_id_list = user_id_list
        self.uuid = uuid

    def validate(self):
        if self.management_options:
            self.management_options.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.features is not None:
            result['features'] = self.features
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.group_owner_id is not None:
            result['groupOwnerId'] = self.group_owner_id
        if self.icon is not None:
            result['icon'] = self.icon
        if self.management_options is not None:
            result['managementOptions'] = self.management_options.to_map()
        if self.template_id is not None:
            result['templateId'] = self.template_id
        if self.user_id_list is not None:
            result['userIdList'] = self.user_id_list
        if self.uuid is not None:
            result['uuid'] = self.uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('features') is not None:
            self.features = m.get('features')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('groupOwnerId') is not None:
            self.group_owner_id = m.get('groupOwnerId')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('managementOptions') is not None:
            temp_model = CreateSceneGroupConversationRequestManagementOptions()
            self.management_options = temp_model.from_map(m['managementOptions'])
        if m.get('templateId') is not None:
            self.template_id = m.get('templateId')
        if m.get('userIdList') is not None:
            self.user_id_list = m.get('userIdList')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        return self


class CreateSceneGroupConversationResponseBody(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
    ):
        # This parameter is required.
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class CreateSceneGroupConversationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateSceneGroupConversationResponseBody = None,
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
            temp_model = CreateSceneGroupConversationResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateStoreGroupConversationHeaders(TeaModel):
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


class CreateStoreGroupConversationRequest(TeaModel):
    def __init__(
        self,
        app_user_id: str = None,
        business_unique_key: str = None,
        group_avatar: str = None,
        group_name: str = None,
        group_template_id: str = None,
        operator_id: str = None,
        user_ids: List[str] = None,
    ):
        # This parameter is required.
        self.app_user_id = app_user_id
        # This parameter is required.
        self.business_unique_key = business_unique_key
        self.group_avatar = group_avatar
        # This parameter is required.
        self.group_name = group_name
        # This parameter is required.
        self.group_template_id = group_template_id
        # This parameter is required.
        self.operator_id = operator_id
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_user_id is not None:
            result['appUserId'] = self.app_user_id
        if self.business_unique_key is not None:
            result['businessUniqueKey'] = self.business_unique_key
        if self.group_avatar is not None:
            result['groupAvatar'] = self.group_avatar
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.group_template_id is not None:
            result['groupTemplateId'] = self.group_template_id
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUserId') is not None:
            self.app_user_id = m.get('appUserId')
        if m.get('businessUniqueKey') is not None:
            self.business_unique_key = m.get('businessUniqueKey')
        if m.get('groupAvatar') is not None:
            self.group_avatar = m.get('groupAvatar')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('groupTemplateId') is not None:
            self.group_template_id = m.get('groupTemplateId')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class CreateStoreGroupConversationResponseBody(TeaModel):
    def __init__(
        self,
        conversation_id: str = None,
        open_conversation_id: str = None,
    ):
        # This parameter is required.
        self.conversation_id = conversation_id
        # This parameter is required.
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conversation_id is not None:
            result['conversationId'] = self.conversation_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conversationId') is not None:
            self.conversation_id = m.get('conversationId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class CreateStoreGroupConversationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateStoreGroupConversationResponseBody = None,
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
            temp_model = CreateStoreGroupConversationResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DebugUnfurlingRegisterHeaders(TeaModel):
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


class DebugUnfurlingRegisterRequest(TeaModel):
    def __init__(
        self,
        app_id: str = None,
        gray_group_id_list: List[str] = None,
        gray_user_id_list: List[str] = None,
        id: int = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_id = app_id
        self.gray_group_id_list = gray_group_id_list
        self.gray_user_id_list = gray_user_id_list
        # This parameter is required.
        self.id = id
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.gray_group_id_list is not None:
            result['grayGroupIdList'] = self.gray_group_id_list
        if self.gray_user_id_list is not None:
            result['grayUserIdList'] = self.gray_user_id_list
        if self.id is not None:
            result['id'] = self.id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('grayGroupIdList') is not None:
            self.gray_group_id_list = m.get('grayGroupIdList')
        if m.get('grayUserIdList') is not None:
            self.gray_user_id_list = m.get('grayUserIdList')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class DebugUnfurlingRegisterResponseBody(TeaModel):
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


class DebugUnfurlingRegisterResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DebugUnfurlingRegisterResponseBody = None,
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
            temp_model = DebugUnfurlingRegisterResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteOrgTextEmotionHeaders(TeaModel):
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


class DeleteOrgTextEmotionRequest(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        emotion_ids: List[str] = None,
    ):
        # This parameter is required.
        self.dept_id = dept_id
        # This parameter is required.
        self.emotion_ids = emotion_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.emotion_ids is not None:
            result['emotionIds'] = self.emotion_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('emotionIds') is not None:
            self.emotion_ids = m.get('emotionIds')
        return self


class DeleteOrgTextEmotionResponseBody(TeaModel):
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


class DeleteOrgTextEmotionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteOrgTextEmotionResponseBody = None,
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
            temp_model = DeleteOrgTextEmotionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DismissGroupConversationHeaders(TeaModel):
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


class DismissGroupConversationRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
    ):
        # This parameter is required.
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class DismissGroupConversationResponseBody(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
    ):
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class DismissGroupConversationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DismissGroupConversationResponseBody = None,
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
            temp_model = DismissGroupConversationResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetConversationUrlHeaders(TeaModel):
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


class GetConversationUrlRequest(TeaModel):
    def __init__(
        self,
        app_user_id: str = None,
        channel_code: str = None,
        device_id: str = None,
        open_conversation_id: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_user_id = app_user_id
        # This parameter is required.
        self.channel_code = channel_code
        self.device_id = device_id
        self.open_conversation_id = open_conversation_id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_user_id is not None:
            result['appUserId'] = self.app_user_id
        if self.channel_code is not None:
            result['channelCode'] = self.channel_code
        if self.device_id is not None:
            result['deviceId'] = self.device_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUserId') is not None:
            self.app_user_id = m.get('appUserId')
        if m.get('channelCode') is not None:
            self.channel_code = m.get('channelCode')
        if m.get('deviceId') is not None:
            self.device_id = m.get('deviceId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetConversationUrlResponseBody(TeaModel):
    def __init__(
        self,
        url: str = None,
    ):
        # This parameter is required.
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class GetConversationUrlResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetConversationUrlResponseBody = None,
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
            temp_model = GetConversationUrlResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetFamilySchoolConversationMsgHeaders(TeaModel):
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


class GetFamilySchoolConversationMsgRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        msg_types: List[int] = None,
        next_token: int = None,
        open_conversation_id: str = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
        self.msg_types = msg_types
        # This parameter is required.
        self.next_token = next_token
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
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
        if self.msg_types is not None:
            result['msgTypes'] = self.msg_types
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('msgTypes') is not None:
            self.msg_types = m.get('msgTypes')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetFamilySchoolConversationMsgResponseBodyMessagesMediaModels(TeaModel):
    def __init__(
        self,
        file_name: str = None,
        file_type: str = None,
        media_id: str = None,
        size: str = None,
        url: str = None,
        video_pic_media_id: str = None,
    ):
        self.file_name = file_name
        self.file_type = file_type
        self.media_id = media_id
        self.size = size
        self.url = url
        self.video_pic_media_id = video_pic_media_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.file_type is not None:
            result['fileType'] = self.file_type
        if self.media_id is not None:
            result['mediaId'] = self.media_id
        if self.size is not None:
            result['size'] = self.size
        if self.url is not None:
            result['url'] = self.url
        if self.video_pic_media_id is not None:
            result['videoPicMediaId'] = self.video_pic_media_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('fileType') is not None:
            self.file_type = m.get('fileType')
        if m.get('mediaId') is not None:
            self.media_id = m.get('mediaId')
        if m.get('size') is not None:
            self.size = m.get('size')
        if m.get('url') is not None:
            self.url = m.get('url')
        if m.get('videoPicMediaId') is not None:
            self.video_pic_media_id = m.get('videoPicMediaId')
        return self


class GetFamilySchoolConversationMsgResponseBodyMessages(TeaModel):
    def __init__(
        self,
        content_type: int = None,
        create_at: int = None,
        media_models: List[GetFamilySchoolConversationMsgResponseBodyMessagesMediaModels] = None,
        open_msg_id: str = None,
    ):
        self.content_type = content_type
        self.create_at = create_at
        self.media_models = media_models
        self.open_msg_id = open_msg_id

    def validate(self):
        if self.media_models:
            for k in self.media_models:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content_type is not None:
            result['contentType'] = self.content_type
        if self.create_at is not None:
            result['createAt'] = self.create_at
        result['mediaModels'] = []
        if self.media_models is not None:
            for k in self.media_models:
                result['mediaModels'].append(k.to_map() if k else None)
        if self.open_msg_id is not None:
            result['openMsgId'] = self.open_msg_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('contentType') is not None:
            self.content_type = m.get('contentType')
        if m.get('createAt') is not None:
            self.create_at = m.get('createAt')
        self.media_models = []
        if m.get('mediaModels') is not None:
            for k in m.get('mediaModels'):
                temp_model = GetFamilySchoolConversationMsgResponseBodyMessagesMediaModels()
                self.media_models.append(temp_model.from_map(k))
        if m.get('openMsgId') is not None:
            self.open_msg_id = m.get('openMsgId')
        return self


class GetFamilySchoolConversationMsgResponseBody(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        has_more: str = None,
        messages: List[GetFamilySchoolConversationMsgResponseBodyMessages] = None,
        next_token: str = None,
        open_conversation_id: str = None,
    ):
        self.corp_id = corp_id
        self.has_more = has_more
        self.messages = messages
        self.next_token = next_token
        self.open_conversation_id = open_conversation_id

    def validate(self):
        if self.messages:
            for k in self.messages:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['messages'] = []
        if self.messages is not None:
            for k in self.messages:
                result['messages'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.messages = []
        if m.get('messages') is not None:
            for k in m.get('messages'):
                temp_model = GetFamilySchoolConversationMsgResponseBodyMessages()
                self.messages.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class GetFamilySchoolConversationMsgResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetFamilySchoolConversationMsgResponseBody = None,
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
            temp_model = GetFamilySchoolConversationMsgResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetFamilySchoolConversationsHeaders(TeaModel):
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


class GetFamilySchoolConversationsRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: int = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
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


class GetFamilySchoolConversationsResponseBodyGroupInfoList(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        dept_name_chain: List[str] = None,
        group_name: str = None,
        group_type: str = None,
        join_group_time: int = None,
        open_conversation_id: str = None,
    ):
        self.corp_id = corp_id
        self.dept_name_chain = dept_name_chain
        self.group_name = group_name
        self.group_type = group_type
        self.join_group_time = join_group_time
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.dept_name_chain is not None:
            result['deptNameChain'] = self.dept_name_chain
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.group_type is not None:
            result['groupType'] = self.group_type
        if self.join_group_time is not None:
            result['joinGroupTime'] = self.join_group_time
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('deptNameChain') is not None:
            self.dept_name_chain = m.get('deptNameChain')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('groupType') is not None:
            self.group_type = m.get('groupType')
        if m.get('joinGroupTime') is not None:
            self.join_group_time = m.get('joinGroupTime')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class GetFamilySchoolConversationsResponseBody(TeaModel):
    def __init__(
        self,
        group_info_list: List[GetFamilySchoolConversationsResponseBodyGroupInfoList] = None,
        has_more: str = None,
        next_token: str = None,
    ):
        self.group_info_list = group_info_list
        self.has_more = has_more
        self.next_token = next_token

    def validate(self):
        if self.group_info_list:
            for k in self.group_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['groupInfoList'] = []
        if self.group_info_list is not None:
            for k in self.group_info_list:
                result['groupInfoList'].append(k.to_map() if k else None)
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.group_info_list = []
        if m.get('groupInfoList') is not None:
            for k in m.get('groupInfoList'):
                temp_model = GetFamilySchoolConversationsResponseBodyGroupInfoList()
                self.group_info_list.append(temp_model.from_map(k))
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class GetFamilySchoolConversationsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetFamilySchoolConversationsResponseBody = None,
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
            temp_model = GetFamilySchoolConversationsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetInnerGroupMembersHeaders(TeaModel):
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


class GetInnerGroupMembersRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        open_conversation_id: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.max_results = max_results
        self.next_token = next_token
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.user_id = user_id

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
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetInnerGroupMembersResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        next_token: str = None,
        user_ids: List[str] = None,
    ):
        self.has_more = has_more
        self.next_token = next_token
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class GetInnerGroupMembersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetInnerGroupMembersResponseBody = None,
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
            temp_model = GetInnerGroupMembersResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetInterconnectionUrlHeaders(TeaModel):
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


class GetInterconnectionUrlRequest(TeaModel):
    def __init__(
        self,
        app_user_avatar: str = None,
        app_user_avatar_type: int = None,
        app_user_id: str = None,
        app_user_mobile_number: str = None,
        app_user_name: str = None,
        msg_page_type: int = None,
        qr_code: str = None,
        signature: str = None,
        source_code: str = None,
        source_type: int = None,
        user_id: str = None,
    ):
        self.app_user_avatar = app_user_avatar
        self.app_user_avatar_type = app_user_avatar_type
        # This parameter is required.
        self.app_user_id = app_user_id
        # This parameter is required.
        self.app_user_mobile_number = app_user_mobile_number
        # This parameter is required.
        self.app_user_name = app_user_name
        # This parameter is required.
        self.msg_page_type = msg_page_type
        self.qr_code = qr_code
        # This parameter is required.
        self.signature = signature
        # This parameter is required.
        self.source_code = source_code
        # This parameter is required.
        self.source_type = source_type
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_user_avatar is not None:
            result['appUserAvatar'] = self.app_user_avatar
        if self.app_user_avatar_type is not None:
            result['appUserAvatarType'] = self.app_user_avatar_type
        if self.app_user_id is not None:
            result['appUserId'] = self.app_user_id
        if self.app_user_mobile_number is not None:
            result['appUserMobileNumber'] = self.app_user_mobile_number
        if self.app_user_name is not None:
            result['appUserName'] = self.app_user_name
        if self.msg_page_type is not None:
            result['msgPageType'] = self.msg_page_type
        if self.qr_code is not None:
            result['qrCode'] = self.qr_code
        if self.signature is not None:
            result['signature'] = self.signature
        if self.source_code is not None:
            result['sourceCode'] = self.source_code
        if self.source_type is not None:
            result['sourceType'] = self.source_type
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUserAvatar') is not None:
            self.app_user_avatar = m.get('appUserAvatar')
        if m.get('appUserAvatarType') is not None:
            self.app_user_avatar_type = m.get('appUserAvatarType')
        if m.get('appUserId') is not None:
            self.app_user_id = m.get('appUserId')
        if m.get('appUserMobileNumber') is not None:
            self.app_user_mobile_number = m.get('appUserMobileNumber')
        if m.get('appUserName') is not None:
            self.app_user_name = m.get('appUserName')
        if m.get('msgPageType') is not None:
            self.msg_page_type = m.get('msgPageType')
        if m.get('qrCode') is not None:
            self.qr_code = m.get('qrCode')
        if m.get('signature') is not None:
            self.signature = m.get('signature')
        if m.get('sourceCode') is not None:
            self.source_code = m.get('sourceCode')
        if m.get('sourceType') is not None:
            self.source_type = m.get('sourceType')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetInterconnectionUrlResponseBody(TeaModel):
    def __init__(
        self,
        url: str = None,
    ):
        # This parameter is required.
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class GetInterconnectionUrlResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetInterconnectionUrlResponseBody = None,
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
            temp_model = GetInterconnectionUrlResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetNewestInnerGroupsHeaders(TeaModel):
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


class GetNewestInnerGroupsRequest(TeaModel):
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


class GetNewestInnerGroupsResponseBodyGroupInfos(TeaModel):
    def __init__(
        self,
        icon: str = None,
        member_amount: str = None,
        open_conversation_id: str = None,
        title: str = None,
    ):
        self.icon = icon
        self.member_amount = member_amount
        self.open_conversation_id = open_conversation_id
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.icon is not None:
            result['icon'] = self.icon
        if self.member_amount is not None:
            result['memberAmount'] = self.member_amount
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('memberAmount') is not None:
            self.member_amount = m.get('memberAmount')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class GetNewestInnerGroupsResponseBody(TeaModel):
    def __init__(
        self,
        group_infos: List[GetNewestInnerGroupsResponseBodyGroupInfos] = None,
    ):
        self.group_infos = group_infos

    def validate(self):
        if self.group_infos:
            for k in self.group_infos:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['groupInfos'] = []
        if self.group_infos is not None:
            for k in self.group_infos:
                result['groupInfos'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.group_infos = []
        if m.get('groupInfos') is not None:
            for k in m.get('groupInfos'):
                temp_model = GetNewestInnerGroupsResponseBodyGroupInfos()
                self.group_infos.append(temp_model.from_map(k))
        return self


class GetNewestInnerGroupsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetNewestInnerGroupsResponseBody = None,
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
            temp_model = GetNewestInnerGroupsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetSceneGroupInfoHeaders(TeaModel):
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


class GetSceneGroupInfoRequest(TeaModel):
    def __init__(
        self,
        cool_app_code: str = None,
        open_conversation_id: str = None,
    ):
        self.cool_app_code = cool_app_code
        # This parameter is required.
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cool_app_code is not None:
            result['coolAppCode'] = self.cool_app_code
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('coolAppCode') is not None:
            self.cool_app_code = m.get('coolAppCode')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class GetSceneGroupInfoResponseBody(TeaModel):
    def __init__(
        self,
        group_url: str = None,
        icon: str = None,
        open_conversation_id: str = None,
        owner_user_id: str = None,
        status: int = None,
        success: bool = None,
        template_id: str = None,
        title: str = None,
    ):
        self.group_url = group_url
        self.icon = icon
        self.open_conversation_id = open_conversation_id
        self.owner_user_id = owner_user_id
        self.status = status
        self.success = success
        self.template_id = template_id
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_url is not None:
            result['groupUrl'] = self.group_url
        if self.icon is not None:
            result['icon'] = self.icon
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.owner_user_id is not None:
            result['ownerUserId'] = self.owner_user_id
        if self.status is not None:
            result['status'] = self.status
        if self.success is not None:
            result['success'] = self.success
        if self.template_id is not None:
            result['templateId'] = self.template_id
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupUrl') is not None:
            self.group_url = m.get('groupUrl')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('ownerUserId') is not None:
            self.owner_user_id = m.get('ownerUserId')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('success') is not None:
            self.success = m.get('success')
        if m.get('templateId') is not None:
            self.template_id = m.get('templateId')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class GetSceneGroupInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetSceneGroupInfoResponseBody = None,
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
            temp_model = GetSceneGroupInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetSceneGroupMembersHeaders(TeaModel):
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


class GetSceneGroupMembersRequest(TeaModel):
    def __init__(
        self,
        cool_app_code: str = None,
        cursor: str = None,
        open_conversation_id: str = None,
        size: int = None,
    ):
        # This parameter is required.
        self.cool_app_code = cool_app_code
        # This parameter is required.
        self.cursor = cursor
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.size = size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cool_app_code is not None:
            result['coolAppCode'] = self.cool_app_code
        if self.cursor is not None:
            result['cursor'] = self.cursor
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.size is not None:
            result['size'] = self.size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('coolAppCode') is not None:
            self.cool_app_code = m.get('coolAppCode')
        if m.get('cursor') is not None:
            self.cursor = m.get('cursor')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('size') is not None:
            self.size = m.get('size')
        return self


class GetSceneGroupMembersResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        member_user_ids: List[str] = None,
        next_cursor: str = None,
        success: bool = None,
    ):
        self.has_more = has_more
        self.member_user_ids = member_user_ids
        self.next_cursor = next_cursor
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.member_user_ids is not None:
            result['memberUserIds'] = self.member_user_ids
        if self.next_cursor is not None:
            result['nextCursor'] = self.next_cursor
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('memberUserIds') is not None:
            self.member_user_ids = m.get('memberUserIds')
        if m.get('nextCursor') is not None:
            self.next_cursor = m.get('nextCursor')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetSceneGroupMembersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetSceneGroupMembersResponseBody = None,
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
            temp_model = GetSceneGroupMembersResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetSceneGroupTemplateMessageOpenStatusHeaders(TeaModel):
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


class GetSceneGroupTemplateMessageOpenStatusResponseBody(TeaModel):
    def __init__(
        self,
        status: int = None,
        success: bool = None,
    ):
        self.status = status
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.status is not None:
            result['status'] = self.status
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetSceneGroupTemplateMessageOpenStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetSceneGroupTemplateMessageOpenStatusResponseBody = None,
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
            temp_model = GetSceneGroupTemplateMessageOpenStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GroupBanWordsHeaders(TeaModel):
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


class GroupBanWordsRequest(TeaModel):
    def __init__(
        self,
        ban_words_mode: int = None,
        open_conversation_id: str = None,
        options: Dict[str, Any] = None,
    ):
        self.ban_words_mode = ban_words_mode
        self.open_conversation_id = open_conversation_id
        self.options = options

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ban_words_mode is not None:
            result['banWordsMode'] = self.ban_words_mode
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.options is not None:
            result['options'] = self.options
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('banWordsMode') is not None:
            self.ban_words_mode = m.get('banWordsMode')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('options') is not None:
            self.options = m.get('options')
        return self


class GroupBanWordsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
    ):
        self.headers = headers
        self.status_code = status_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        return self


class GroupCapacityInquiryHeaders(TeaModel):
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


class GroupCapacityInquiryRequest(TeaModel):
    def __init__(
        self,
        effective_duration: str = None,
        open_conversation_id: str = None,
        operator: str = None,
        options: Dict[str, Any] = None,
        target_capacity: int = None,
    ):
        self.effective_duration = effective_duration
        self.open_conversation_id = open_conversation_id
        self.operator = operator
        self.options = options
        self.target_capacity = target_capacity

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.effective_duration is not None:
            result['effectiveDuration'] = self.effective_duration
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.operator is not None:
            result['operator'] = self.operator
        if self.options is not None:
            result['options'] = self.options
        if self.target_capacity is not None:
            result['targetCapacity'] = self.target_capacity
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('effectiveDuration') is not None:
            self.effective_duration = m.get('effectiveDuration')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        if m.get('options') is not None:
            self.options = m.get('options')
        if m.get('targetCapacity') is not None:
            self.target_capacity = m.get('targetCapacity')
        return self


class GroupCapacityInquiryResponseBody(TeaModel):
    def __init__(
        self,
        actual_price: int = None,
        created_at: int = None,
        current_capacity: int = None,
        current_effect_until: int = None,
        discount: int = None,
        ext_info: Dict[str, Any] = None,
        group_owner: str = None,
        group_title: str = None,
        marked_price: int = None,
        member_count: int = None,
        open_conversation_id: str = None,
        operator: str = None,
        target_capacity: int = None,
        target_effect_until: int = None,
        token: str = None,
    ):
        self.actual_price = actual_price
        self.created_at = created_at
        self.current_capacity = current_capacity
        self.current_effect_until = current_effect_until
        self.discount = discount
        self.ext_info = ext_info
        self.group_owner = group_owner
        self.group_title = group_title
        self.marked_price = marked_price
        self.member_count = member_count
        self.open_conversation_id = open_conversation_id
        self.operator = operator
        self.target_capacity = target_capacity
        self.target_effect_until = target_effect_until
        self.token = token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.actual_price is not None:
            result['actualPrice'] = self.actual_price
        if self.created_at is not None:
            result['createdAt'] = self.created_at
        if self.current_capacity is not None:
            result['currentCapacity'] = self.current_capacity
        if self.current_effect_until is not None:
            result['currentEffectUntil'] = self.current_effect_until
        if self.discount is not None:
            result['discount'] = self.discount
        if self.ext_info is not None:
            result['extInfo'] = self.ext_info
        if self.group_owner is not None:
            result['groupOwner'] = self.group_owner
        if self.group_title is not None:
            result['groupTitle'] = self.group_title
        if self.marked_price is not None:
            result['markedPrice'] = self.marked_price
        if self.member_count is not None:
            result['memberCount'] = self.member_count
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.operator is not None:
            result['operator'] = self.operator
        if self.target_capacity is not None:
            result['targetCapacity'] = self.target_capacity
        if self.target_effect_until is not None:
            result['targetEffectUntil'] = self.target_effect_until
        if self.token is not None:
            result['token'] = self.token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actualPrice') is not None:
            self.actual_price = m.get('actualPrice')
        if m.get('createdAt') is not None:
            self.created_at = m.get('createdAt')
        if m.get('currentCapacity') is not None:
            self.current_capacity = m.get('currentCapacity')
        if m.get('currentEffectUntil') is not None:
            self.current_effect_until = m.get('currentEffectUntil')
        if m.get('discount') is not None:
            self.discount = m.get('discount')
        if m.get('extInfo') is not None:
            self.ext_info = m.get('extInfo')
        if m.get('groupOwner') is not None:
            self.group_owner = m.get('groupOwner')
        if m.get('groupTitle') is not None:
            self.group_title = m.get('groupTitle')
        if m.get('markedPrice') is not None:
            self.marked_price = m.get('markedPrice')
        if m.get('memberCount') is not None:
            self.member_count = m.get('memberCount')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        if m.get('targetCapacity') is not None:
            self.target_capacity = m.get('targetCapacity')
        if m.get('targetEffectUntil') is not None:
            self.target_effect_until = m.get('targetEffectUntil')
        if m.get('token') is not None:
            self.token = m.get('token')
        return self


class GroupCapacityInquiryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GroupCapacityInquiryResponseBody = None,
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
            temp_model = GroupCapacityInquiryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GroupCapacityOrderConfirmHeaders(TeaModel):
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


class GroupCapacityOrderConfirmRequest(TeaModel):
    def __init__(
        self,
        operator: str = None,
        order_id: str = None,
    ):
        self.operator = operator
        self.order_id = order_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operator is not None:
            result['operator'] = self.operator
        if self.order_id is not None:
            result['orderId'] = self.order_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        if m.get('orderId') is not None:
            self.order_id = m.get('orderId')
        return self


class GroupCapacityOrderConfirmResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        # This parameter is required.
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


class GroupCapacityOrderConfirmResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GroupCapacityOrderConfirmResponseBody = None,
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
            temp_model = GroupCapacityOrderConfirmResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GroupCapacityOrderPlaceHeaders(TeaModel):
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


class GroupCapacityOrderPlaceRequest(TeaModel):
    def __init__(
        self,
        actual_price: int = None,
        current_capacity: int = None,
        current_effect_until: int = None,
        discount: int = None,
        ext_info: Dict[str, Any] = None,
        marked_price: int = None,
        open_conversation_id: str = None,
        operator: str = None,
        target_capacity: int = None,
        target_effect_until: int = None,
        token: str = None,
    ):
        self.actual_price = actual_price
        self.current_capacity = current_capacity
        self.current_effect_until = current_effect_until
        self.discount = discount
        self.ext_info = ext_info
        self.marked_price = marked_price
        self.open_conversation_id = open_conversation_id
        self.operator = operator
        self.target_capacity = target_capacity
        self.target_effect_until = target_effect_until
        self.token = token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.actual_price is not None:
            result['actualPrice'] = self.actual_price
        if self.current_capacity is not None:
            result['currentCapacity'] = self.current_capacity
        if self.current_effect_until is not None:
            result['currentEffectUntil'] = self.current_effect_until
        if self.discount is not None:
            result['discount'] = self.discount
        if self.ext_info is not None:
            result['extInfo'] = self.ext_info
        if self.marked_price is not None:
            result['markedPrice'] = self.marked_price
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.operator is not None:
            result['operator'] = self.operator
        if self.target_capacity is not None:
            result['targetCapacity'] = self.target_capacity
        if self.target_effect_until is not None:
            result['targetEffectUntil'] = self.target_effect_until
        if self.token is not None:
            result['token'] = self.token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actualPrice') is not None:
            self.actual_price = m.get('actualPrice')
        if m.get('currentCapacity') is not None:
            self.current_capacity = m.get('currentCapacity')
        if m.get('currentEffectUntil') is not None:
            self.current_effect_until = m.get('currentEffectUntil')
        if m.get('discount') is not None:
            self.discount = m.get('discount')
        if m.get('extInfo') is not None:
            self.ext_info = m.get('extInfo')
        if m.get('markedPrice') is not None:
            self.marked_price = m.get('markedPrice')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        if m.get('targetCapacity') is not None:
            self.target_capacity = m.get('targetCapacity')
        if m.get('targetEffectUntil') is not None:
            self.target_effect_until = m.get('targetEffectUntil')
        if m.get('token') is not None:
            self.token = m.get('token')
        return self


class GroupCapacityOrderPlaceResponseBody(TeaModel):
    def __init__(
        self,
        actual_price: int = None,
        current_capacity: int = None,
        current_effect_until: int = None,
        discount: int = None,
        ext_info: Dict[str, str] = None,
        marked_price: int = None,
        open_conversation_id: str = None,
        operator: str = None,
        order_id: str = None,
        target_capacity: int = None,
        target_effect_until: int = None,
        token: str = None,
    ):
        self.actual_price = actual_price
        self.current_capacity = current_capacity
        self.current_effect_until = current_effect_until
        self.discount = discount
        self.ext_info = ext_info
        self.marked_price = marked_price
        self.open_conversation_id = open_conversation_id
        self.operator = operator
        self.order_id = order_id
        self.target_capacity = target_capacity
        self.target_effect_until = target_effect_until
        self.token = token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.actual_price is not None:
            result['actualPrice'] = self.actual_price
        if self.current_capacity is not None:
            result['currentCapacity'] = self.current_capacity
        if self.current_effect_until is not None:
            result['currentEffectUntil'] = self.current_effect_until
        if self.discount is not None:
            result['discount'] = self.discount
        if self.ext_info is not None:
            result['extInfo'] = self.ext_info
        if self.marked_price is not None:
            result['markedPrice'] = self.marked_price
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.operator is not None:
            result['operator'] = self.operator
        if self.order_id is not None:
            result['orderId'] = self.order_id
        if self.target_capacity is not None:
            result['targetCapacity'] = self.target_capacity
        if self.target_effect_until is not None:
            result['targetEffectUntil'] = self.target_effect_until
        if self.token is not None:
            result['token'] = self.token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actualPrice') is not None:
            self.actual_price = m.get('actualPrice')
        if m.get('currentCapacity') is not None:
            self.current_capacity = m.get('currentCapacity')
        if m.get('currentEffectUntil') is not None:
            self.current_effect_until = m.get('currentEffectUntil')
        if m.get('discount') is not None:
            self.discount = m.get('discount')
        if m.get('extInfo') is not None:
            self.ext_info = m.get('extInfo')
        if m.get('markedPrice') is not None:
            self.marked_price = m.get('markedPrice')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('operator') is not None:
            self.operator = m.get('operator')
        if m.get('orderId') is not None:
            self.order_id = m.get('orderId')
        if m.get('targetCapacity') is not None:
            self.target_capacity = m.get('targetCapacity')
        if m.get('targetEffectUntil') is not None:
            self.target_effect_until = m.get('targetEffectUntil')
        if m.get('token') is not None:
            self.token = m.get('token')
        return self


class GroupCapacityOrderPlaceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GroupCapacityOrderPlaceResponseBody = None,
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
            temp_model = GroupCapacityOrderPlaceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GroupManageQueryHeaders(TeaModel):
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


class GroupManageQueryRequest(TeaModel):
    def __init__(
        self,
        created_after: int = None,
        group_id: str = None,
        group_member_samples: List[str] = None,
        group_owner: str = None,
        group_title_keywords: List[str] = None,
        group_url: str = None,
        max_results: int = None,
        members_over: int = None,
        next_token: str = None,
        open_conversation_id: str = None,
    ):
        self.created_after = created_after
        self.group_id = group_id
        self.group_member_samples = group_member_samples
        self.group_owner = group_owner
        self.group_title_keywords = group_title_keywords
        self.group_url = group_url
        self.max_results = max_results
        self.members_over = members_over
        self.next_token = next_token
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.created_after is not None:
            result['createdAfter'] = self.created_after
        if self.group_id is not None:
            result['groupId'] = self.group_id
        if self.group_member_samples is not None:
            result['groupMemberSamples'] = self.group_member_samples
        if self.group_owner is not None:
            result['groupOwner'] = self.group_owner
        if self.group_title_keywords is not None:
            result['groupTitleKeywords'] = self.group_title_keywords
        if self.group_url is not None:
            result['groupUrl'] = self.group_url
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.members_over is not None:
            result['membersOver'] = self.members_over
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createdAfter') is not None:
            self.created_after = m.get('createdAfter')
        if m.get('groupId') is not None:
            self.group_id = m.get('groupId')
        if m.get('groupMemberSamples') is not None:
            self.group_member_samples = m.get('groupMemberSamples')
        if m.get('groupOwner') is not None:
            self.group_owner = m.get('groupOwner')
        if m.get('groupTitleKeywords') is not None:
            self.group_title_keywords = m.get('groupTitleKeywords')
        if m.get('groupUrl') is not None:
            self.group_url = m.get('groupUrl')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('membersOver') is not None:
            self.members_over = m.get('membersOver')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class GroupManageQueryResponseBodyGroupInfoList(TeaModel):
    def __init__(
        self,
        ban_words_mode: int = None,
        capacity: int = None,
        created_at: int = None,
        ext_info: Dict[str, Any] = None,
        group_admin_list: List[str] = None,
        group_owner: str = None,
        group_title: str = None,
        member_count: int = None,
        open_conversation_id: str = None,
        type: str = None,
    ):
        self.ban_words_mode = ban_words_mode
        self.capacity = capacity
        self.created_at = created_at
        self.ext_info = ext_info
        self.group_admin_list = group_admin_list
        self.group_owner = group_owner
        self.group_title = group_title
        self.member_count = member_count
        self.open_conversation_id = open_conversation_id
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ban_words_mode is not None:
            result['banWordsMode'] = self.ban_words_mode
        if self.capacity is not None:
            result['capacity'] = self.capacity
        if self.created_at is not None:
            result['createdAt'] = self.created_at
        if self.ext_info is not None:
            result['extInfo'] = self.ext_info
        if self.group_admin_list is not None:
            result['groupAdminList'] = self.group_admin_list
        if self.group_owner is not None:
            result['groupOwner'] = self.group_owner
        if self.group_title is not None:
            result['groupTitle'] = self.group_title
        if self.member_count is not None:
            result['memberCount'] = self.member_count
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('banWordsMode') is not None:
            self.ban_words_mode = m.get('banWordsMode')
        if m.get('capacity') is not None:
            self.capacity = m.get('capacity')
        if m.get('createdAt') is not None:
            self.created_at = m.get('createdAt')
        if m.get('extInfo') is not None:
            self.ext_info = m.get('extInfo')
        if m.get('groupAdminList') is not None:
            self.group_admin_list = m.get('groupAdminList')
        if m.get('groupOwner') is not None:
            self.group_owner = m.get('groupOwner')
        if m.get('groupTitle') is not None:
            self.group_title = m.get('groupTitle')
        if m.get('memberCount') is not None:
            self.member_count = m.get('memberCount')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class GroupManageQueryResponseBody(TeaModel):
    def __init__(
        self,
        group_info_list: List[GroupManageQueryResponseBodyGroupInfoList] = None,
        has_more: bool = None,
        next_token: str = None,
    ):
        self.group_info_list = group_info_list
        self.has_more = has_more
        self.next_token = next_token

    def validate(self):
        if self.group_info_list:
            for k in self.group_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['groupInfoList'] = []
        if self.group_info_list is not None:
            for k in self.group_info_list:
                result['groupInfoList'].append(k.to_map() if k else None)
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.group_info_list = []
        if m.get('groupInfoList') is not None:
            for k in m.get('groupInfoList'):
                temp_model = GroupManageQueryResponseBodyGroupInfoList()
                self.group_info_list.append(temp_model.from_map(k))
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class GroupManageQueryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GroupManageQueryResponseBody = None,
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
            temp_model = GroupManageQueryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GroupManageReduceHeaders(TeaModel):
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


class GroupManageReduceRequest(TeaModel):
    def __init__(
        self,
        capacity_limit: int = None,
        open_conversation_id: str = None,
        options: Dict[str, Any] = None,
    ):
        self.capacity_limit = capacity_limit
        self.open_conversation_id = open_conversation_id
        self.options = options

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.capacity_limit is not None:
            result['capacityLimit'] = self.capacity_limit
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.options is not None:
            result['options'] = self.options
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('capacityLimit') is not None:
            self.capacity_limit = m.get('capacityLimit')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('options') is not None:
            self.options = m.get('options')
        return self


class GroupManageReduceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
    ):
        self.headers = headers
        self.status_code = status_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        return self


class InstallRobotToOrgHeaders(TeaModel):
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


class InstallRobotToOrgRequest(TeaModel):
    def __init__(
        self,
        brief: str = None,
        description: str = None,
        icon: str = None,
        name: str = None,
        outgoing_token: str = None,
        outgoing_url: str = None,
        preview_media_id: str = None,
        robot_code: str = None,
    ):
        # This parameter is required.
        self.brief = brief
        # This parameter is required.
        self.description = description
        # This parameter is required.
        self.icon = icon
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.outgoing_token = outgoing_token
        # This parameter is required.
        self.outgoing_url = outgoing_url
        # This parameter is required.
        self.preview_media_id = preview_media_id
        # This parameter is required.
        self.robot_code = robot_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.brief is not None:
            result['brief'] = self.brief
        if self.description is not None:
            result['description'] = self.description
        if self.icon is not None:
            result['icon'] = self.icon
        if self.name is not None:
            result['name'] = self.name
        if self.outgoing_token is not None:
            result['outgoingToken'] = self.outgoing_token
        if self.outgoing_url is not None:
            result['outgoingUrl'] = self.outgoing_url
        if self.preview_media_id is not None:
            result['previewMediaId'] = self.preview_media_id
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('brief') is not None:
            self.brief = m.get('brief')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('outgoingToken') is not None:
            self.outgoing_token = m.get('outgoingToken')
        if m.get('outgoingUrl') is not None:
            self.outgoing_url = m.get('outgoingUrl')
        if m.get('previewMediaId') is not None:
            self.preview_media_id = m.get('previewMediaId')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        return self


class InstallRobotToOrgResponseBody(TeaModel):
    def __init__(
        self,
        robot_code: str = None,
    ):
        self.robot_code = robot_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        return self


class InstallRobotToOrgResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: InstallRobotToOrgResponseBody = None,
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
            temp_model = InstallRobotToOrgResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class InteractiveCardCreateInstanceHeaders(TeaModel):
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


class InteractiveCardCreateInstanceRequestCardData(TeaModel):
    def __init__(
        self,
        card_media_id_param_map: Dict[str, str] = None,
        card_param_map: Dict[str, str] = None,
    ):
        self.card_media_id_param_map = card_media_id_param_map
        self.card_param_map = card_param_map

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.card_media_id_param_map is not None:
            result['cardMediaIdParamMap'] = self.card_media_id_param_map
        if self.card_param_map is not None:
            result['cardParamMap'] = self.card_param_map
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cardMediaIdParamMap') is not None:
            self.card_media_id_param_map = m.get('cardMediaIdParamMap')
        if m.get('cardParamMap') is not None:
            self.card_param_map = m.get('cardParamMap')
        return self


class InteractiveCardCreateInstanceRequest(TeaModel):
    def __init__(
        self,
        callback_route_key: str = None,
        card_data: InteractiveCardCreateInstanceRequestCardData = None,
        card_template_id: str = None,
        chat_bot_id: str = None,
        conversation_type: int = None,
        open_conversation_id: str = None,
        out_track_id: str = None,
        private_data: Dict[str, PrivateDataValue] = None,
        pull_strategy: bool = None,
        receiver_user_id_list: List[str] = None,
        robot_code: str = None,
        user_id_type: int = None,
    ):
        self.callback_route_key = callback_route_key
        # This parameter is required.
        self.card_data = card_data
        # This parameter is required.
        self.card_template_id = card_template_id
        self.chat_bot_id = chat_bot_id
        # This parameter is required.
        self.conversation_type = conversation_type
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.out_track_id = out_track_id
        self.private_data = private_data
        self.pull_strategy = pull_strategy
        self.receiver_user_id_list = receiver_user_id_list
        self.robot_code = robot_code
        self.user_id_type = user_id_type

    def validate(self):
        if self.card_data:
            self.card_data.validate()
        if self.private_data:
            for v in self.private_data.values():
                if v:
                    v.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.callback_route_key is not None:
            result['callbackRouteKey'] = self.callback_route_key
        if self.card_data is not None:
            result['cardData'] = self.card_data.to_map()
        if self.card_template_id is not None:
            result['cardTemplateId'] = self.card_template_id
        if self.chat_bot_id is not None:
            result['chatBotId'] = self.chat_bot_id
        if self.conversation_type is not None:
            result['conversationType'] = self.conversation_type
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.out_track_id is not None:
            result['outTrackId'] = self.out_track_id
        result['privateData'] = {}
        if self.private_data is not None:
            for k, v in self.private_data.items():
                result['privateData'][k] = v.to_map()
        if self.pull_strategy is not None:
            result['pullStrategy'] = self.pull_strategy
        if self.receiver_user_id_list is not None:
            result['receiverUserIdList'] = self.receiver_user_id_list
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        if self.user_id_type is not None:
            result['userIdType'] = self.user_id_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('callbackRouteKey') is not None:
            self.callback_route_key = m.get('callbackRouteKey')
        if m.get('cardData') is not None:
            temp_model = InteractiveCardCreateInstanceRequestCardData()
            self.card_data = temp_model.from_map(m['cardData'])
        if m.get('cardTemplateId') is not None:
            self.card_template_id = m.get('cardTemplateId')
        if m.get('chatBotId') is not None:
            self.chat_bot_id = m.get('chatBotId')
        if m.get('conversationType') is not None:
            self.conversation_type = m.get('conversationType')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('outTrackId') is not None:
            self.out_track_id = m.get('outTrackId')
        self.private_data = {}
        if m.get('privateData') is not None:
            for k, v in m.get('privateData').items():
                temp_model = PrivateDataValue()
                self.private_data[k] = temp_model.from_map(v)
        if m.get('pullStrategy') is not None:
            self.pull_strategy = m.get('pullStrategy')
        if m.get('receiverUserIdList') is not None:
            self.receiver_user_id_list = m.get('receiverUserIdList')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        if m.get('userIdType') is not None:
            self.user_id_type = m.get('userIdType')
        return self


class InteractiveCardCreateInstanceResponseBody(TeaModel):
    def __init__(
        self,
        process_query_key: str = None,
    ):
        self.process_query_key = process_query_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.process_query_key is not None:
            result['processQueryKey'] = self.process_query_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('processQueryKey') is not None:
            self.process_query_key = m.get('processQueryKey')
        return self


class InteractiveCardCreateInstanceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: InteractiveCardCreateInstanceResponseBody = None,
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
            temp_model = InteractiveCardCreateInstanceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListOrgTextEmotionHeaders(TeaModel):
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


class ListOrgTextEmotionResponseBodyResultEmotions(TeaModel):
    def __init__(
        self,
        background_media_id: str = None,
        background_media_id_for_panel: str = None,
        dept_id: int = None,
        emotion_id: str = None,
        emotion_name: str = None,
        status: int = None,
    ):
        self.background_media_id = background_media_id
        self.background_media_id_for_panel = background_media_id_for_panel
        self.dept_id = dept_id
        self.emotion_id = emotion_id
        self.emotion_name = emotion_name
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.background_media_id is not None:
            result['backgroundMediaId'] = self.background_media_id
        if self.background_media_id_for_panel is not None:
            result['backgroundMediaIdForPanel'] = self.background_media_id_for_panel
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.emotion_id is not None:
            result['emotionId'] = self.emotion_id
        if self.emotion_name is not None:
            result['emotionName'] = self.emotion_name
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('backgroundMediaId') is not None:
            self.background_media_id = m.get('backgroundMediaId')
        if m.get('backgroundMediaIdForPanel') is not None:
            self.background_media_id_for_panel = m.get('backgroundMediaIdForPanel')
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('emotionId') is not None:
            self.emotion_id = m.get('emotionId')
        if m.get('emotionName') is not None:
            self.emotion_name = m.get('emotionName')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class ListOrgTextEmotionResponseBodyResult(TeaModel):
    def __init__(
        self,
        emotions: List[ListOrgTextEmotionResponseBodyResultEmotions] = None,
    ):
        self.emotions = emotions

    def validate(self):
        if self.emotions:
            for k in self.emotions:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['emotions'] = []
        if self.emotions is not None:
            for k in self.emotions:
                result['emotions'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.emotions = []
        if m.get('emotions') is not None:
            for k in m.get('emotions'):
                temp_model = ListOrgTextEmotionResponseBodyResultEmotions()
                self.emotions.append(temp_model.from_map(k))
        return self


class ListOrgTextEmotionResponseBody(TeaModel):
    def __init__(
        self,
        result: ListOrgTextEmotionResponseBodyResult = None,
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
            temp_model = ListOrgTextEmotionResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class ListOrgTextEmotionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListOrgTextEmotionResponseBody = None,
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
            temp_model = ListOrgTextEmotionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListSceneGroupsByTemplateIdHeaders(TeaModel):
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


class ListSceneGroupsByTemplateIdRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
    ):
        # This parameter is required.
        self.page_number = page_number
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class ListSceneGroupsByTemplateIdResponseBody(TeaModel):
    def __init__(
        self,
        open_conversation_ids: List[str] = None,
        success: bool = None,
    ):
        self.open_conversation_ids = open_conversation_ids
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_ids is not None:
            result['openConversationIds'] = self.open_conversation_ids
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationIds') is not None:
            self.open_conversation_ids = m.get('openConversationIds')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class ListSceneGroupsByTemplateIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListSceneGroupsByTemplateIdResponseBody = None,
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
            temp_model = ListSceneGroupsByTemplateIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class OfflineUnfurlingRegisterHeaders(TeaModel):
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


class OfflineUnfurlingRegisterRequest(TeaModel):
    def __init__(
        self,
        app_id: str = None,
        id: int = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_id = app_id
        # This parameter is required.
        self.id = id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.id is not None:
            result['id'] = self.id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class OfflineUnfurlingRegisterResponseBody(TeaModel):
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


class OfflineUnfurlingRegisterResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: OfflineUnfurlingRegisterResponseBody = None,
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
            temp_model = OfflineUnfurlingRegisterResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class OpenGroupRoleAddHeaders(TeaModel):
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


class OpenGroupRoleAddRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        role_name: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.role_name = role_name
        # This parameter is required.
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
        if self.role_name is not None:
            result['roleName'] = self.role_name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('roleName') is not None:
            self.role_name = m.get('roleName')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class OpenGroupRoleAddResponseBodyResult(TeaModel):
    def __init__(
        self,
        open_role_id: str = None,
    ):
        self.open_role_id = open_role_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_role_id is not None:
            result['openRoleId'] = self.open_role_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openRoleId') is not None:
            self.open_role_id = m.get('openRoleId')
        return self


class OpenGroupRoleAddResponseBody(TeaModel):
    def __init__(
        self,
        result: OpenGroupRoleAddResponseBodyResult = None,
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
            temp_model = OpenGroupRoleAddResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class OpenGroupRoleAddResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: OpenGroupRoleAddResponseBody = None,
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
            temp_model = OpenGroupRoleAddResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class OpenGroupRoleQueryHeaders(TeaModel):
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


class OpenGroupRoleQueryRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
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


class OpenGroupRoleQueryResponseBodyResultGroupRoles(TeaModel):
    def __init__(
        self,
        open_role_id: str = None,
        role_name: str = None,
    ):
        self.open_role_id = open_role_id
        self.role_name = role_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_role_id is not None:
            result['openRoleId'] = self.open_role_id
        if self.role_name is not None:
            result['roleName'] = self.role_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openRoleId') is not None:
            self.open_role_id = m.get('openRoleId')
        if m.get('roleName') is not None:
            self.role_name = m.get('roleName')
        return self


class OpenGroupRoleQueryResponseBodyResult(TeaModel):
    def __init__(
        self,
        group_roles: List[OpenGroupRoleQueryResponseBodyResultGroupRoles] = None,
    ):
        self.group_roles = group_roles

    def validate(self):
        if self.group_roles:
            for k in self.group_roles:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['groupRoles'] = []
        if self.group_roles is not None:
            for k in self.group_roles:
                result['groupRoles'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.group_roles = []
        if m.get('groupRoles') is not None:
            for k in m.get('groupRoles'):
                temp_model = OpenGroupRoleQueryResponseBodyResultGroupRoles()
                self.group_roles.append(temp_model.from_map(k))
        return self


class OpenGroupRoleQueryResponseBody(TeaModel):
    def __init__(
        self,
        result: OpenGroupRoleQueryResponseBodyResult = None,
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
            temp_model = OpenGroupRoleQueryResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class OpenGroupRoleQueryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: OpenGroupRoleQueryResponseBody = None,
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
            temp_model = OpenGroupRoleQueryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class OpenGroupRoleRemoveHeaders(TeaModel):
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


class OpenGroupRoleRemoveRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        open_role_id: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.open_role_id = open_role_id
        # This parameter is required.
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
        if self.open_role_id is not None:
            result['openRoleId'] = self.open_role_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('openRoleId') is not None:
            self.open_role_id = m.get('openRoleId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class OpenGroupRoleRemoveResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class OpenGroupRoleRemoveResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: OpenGroupRoleRemoveResponseBody = None,
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
            temp_model = OpenGroupRoleRemoveResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class OpenGroupRoleUpdateHeaders(TeaModel):
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


class OpenGroupRoleUpdateRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        open_role_id: str = None,
        role_name: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.open_role_id = open_role_id
        # This parameter is required.
        self.role_name = role_name
        # This parameter is required.
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
        if self.open_role_id is not None:
            result['openRoleId'] = self.open_role_id
        if self.role_name is not None:
            result['roleName'] = self.role_name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('openRoleId') is not None:
            self.open_role_id = m.get('openRoleId')
        if m.get('roleName') is not None:
            self.role_name = m.get('roleName')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class OpenGroupRoleUpdateResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
        success: bool = None,
    ):
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class OpenGroupRoleUpdateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: OpenGroupRoleUpdateResponseBody = None,
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
            temp_model = OpenGroupRoleUpdateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class OpenGroupUserRoleQueryHeaders(TeaModel):
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


class OpenGroupUserRoleQueryRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        user_id: str = None,
        viewed_user_id: str = None,
    ):
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.user_id = user_id
        # This parameter is required.
        self.viewed_user_id = viewed_user_id

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
        if self.viewed_user_id is not None:
            result['viewedUserId'] = self.viewed_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('viewedUserId') is not None:
            self.viewed_user_id = m.get('viewedUserId')
        return self


class OpenGroupUserRoleQueryResponseBodyResultGroupRoles(TeaModel):
    def __init__(
        self,
        open_role_id: str = None,
        role_name: str = None,
    ):
        self.open_role_id = open_role_id
        self.role_name = role_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_role_id is not None:
            result['openRoleId'] = self.open_role_id
        if self.role_name is not None:
            result['roleName'] = self.role_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openRoleId') is not None:
            self.open_role_id = m.get('openRoleId')
        if m.get('roleName') is not None:
            self.role_name = m.get('roleName')
        return self


class OpenGroupUserRoleQueryResponseBodyResult(TeaModel):
    def __init__(
        self,
        group_roles: List[OpenGroupUserRoleQueryResponseBodyResultGroupRoles] = None,
    ):
        self.group_roles = group_roles

    def validate(self):
        if self.group_roles:
            for k in self.group_roles:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['groupRoles'] = []
        if self.group_roles is not None:
            for k in self.group_roles:
                result['groupRoles'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.group_roles = []
        if m.get('groupRoles') is not None:
            for k in m.get('groupRoles'):
                temp_model = OpenGroupUserRoleQueryResponseBodyResultGroupRoles()
                self.group_roles.append(temp_model.from_map(k))
        return self


class OpenGroupUserRoleQueryResponseBody(TeaModel):
    def __init__(
        self,
        result: OpenGroupUserRoleQueryResponseBodyResult = None,
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
            temp_model = OpenGroupUserRoleQueryResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class OpenGroupUserRoleQueryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: OpenGroupUserRoleQueryResponseBody = None,
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
            temp_model = OpenGroupUserRoleQueryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class OpenInnerGroupTransferToDeptGroupHeaders(TeaModel):
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


class OpenInnerGroupTransferToDeptGroupRequest(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        open_conversation_id: str = None,
    ):
        # This parameter is required.
        self.dept_id = dept_id
        # This parameter is required.
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class OpenInnerGroupTransferToDeptGroupResponseBody(TeaModel):
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


class OpenInnerGroupTransferToDeptGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: OpenInnerGroupTransferToDeptGroupResponseBody = None,
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
            temp_model = OpenInnerGroupTransferToDeptGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class OpenSearchGroupListHeaders(TeaModel):
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


class OpenSearchGroupListRequest(TeaModel):
    def __init__(
        self,
        keyword: str = None,
        user_id: str = None,
    ):
        self.keyword = keyword
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.keyword is not None:
            result['keyword'] = self.keyword
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('keyword') is not None:
            self.keyword = m.get('keyword')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class OpenSearchGroupListResponseBodyResultGroupList(TeaModel):
    def __init__(
        self,
        icon: str = None,
        member_count: int = None,
        open_conversation_id: str = None,
        tag: str = None,
        title: str = None,
    ):
        self.icon = icon
        self.member_count = member_count
        self.open_conversation_id = open_conversation_id
        self.tag = tag
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.icon is not None:
            result['icon'] = self.icon
        if self.member_count is not None:
            result['memberCount'] = self.member_count
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.tag is not None:
            result['tag'] = self.tag
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('memberCount') is not None:
            self.member_count = m.get('memberCount')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('tag') is not None:
            self.tag = m.get('tag')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class OpenSearchGroupListResponseBodyResult(TeaModel):
    def __init__(
        self,
        group_list: List[OpenSearchGroupListResponseBodyResultGroupList] = None,
    ):
        self.group_list = group_list

    def validate(self):
        if self.group_list:
            for k in self.group_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['groupList'] = []
        if self.group_list is not None:
            for k in self.group_list:
                result['groupList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.group_list = []
        if m.get('groupList') is not None:
            for k in m.get('groupList'):
                temp_model = OpenSearchGroupListResponseBodyResultGroupList()
                self.group_list.append(temp_model.from_map(k))
        return self


class OpenSearchGroupListResponseBody(TeaModel):
    def __init__(
        self,
        result: OpenSearchGroupListResponseBodyResult = None,
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
            temp_model = OpenSearchGroupListResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class OpenSearchGroupListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: OpenSearchGroupListResponseBody = None,
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
            temp_model = OpenSearchGroupListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class OpenUserSendCardMessageHeaders(TeaModel):
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


class OpenUserSendCardMessageRequestCardContent(TeaModel):
    def __init__(
        self,
        last_message: str = None,
        out_track_id: str = None,
    ):
        # This parameter is required.
        self.last_message = last_message
        # This parameter is required.
        self.out_track_id = out_track_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.last_message is not None:
            result['lastMessage'] = self.last_message
        if self.out_track_id is not None:
            result['outTrackId'] = self.out_track_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('lastMessage') is not None:
            self.last_message = m.get('lastMessage')
        if m.get('outTrackId') is not None:
            self.out_track_id = m.get('outTrackId')
        return self


class OpenUserSendCardMessageRequest(TeaModel):
    def __init__(
        self,
        card_content: OpenUserSendCardMessageRequestCardContent = None,
        open_conversation_id: str = None,
        receive_user_id: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.card_content = card_content
        self.open_conversation_id = open_conversation_id
        self.receive_user_id = receive_user_id
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        if self.card_content:
            self.card_content.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.card_content is not None:
            result['cardContent'] = self.card_content.to_map()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.receive_user_id is not None:
            result['receiveUserId'] = self.receive_user_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cardContent') is not None:
            temp_model = OpenUserSendCardMessageRequestCardContent()
            self.card_content = temp_model.from_map(m['cardContent'])
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('receiveUserId') is not None:
            self.receive_user_id = m.get('receiveUserId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class OpenUserSendCardMessageResponseBodyResult(TeaModel):
    def __init__(
        self,
        open_task_id: str = None,
    ):
        self.open_task_id = open_task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_task_id is not None:
            result['openTaskId'] = self.open_task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openTaskId') is not None:
            self.open_task_id = m.get('openTaskId')
        return self


class OpenUserSendCardMessageResponseBody(TeaModel):
    def __init__(
        self,
        result: OpenUserSendCardMessageResponseBodyResult = None,
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
            temp_model = OpenUserSendCardMessageResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class OpenUserSendCardMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: OpenUserSendCardMessageResponseBody = None,
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
            temp_model = OpenUserSendCardMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PersonalSendCardMessageHeaders(TeaModel):
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


class PersonalSendCardMessageRequestCardContent(TeaModel):
    def __init__(
        self,
        last_message: str = None,
        out_track_id: str = None,
    ):
        self.last_message = last_message
        self.out_track_id = out_track_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.last_message is not None:
            result['lastMessage'] = self.last_message
        if self.out_track_id is not None:
            result['outTrackId'] = self.out_track_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('lastMessage') is not None:
            self.last_message = m.get('lastMessage')
        if m.get('outTrackId') is not None:
            self.out_track_id = m.get('outTrackId')
        return self


class PersonalSendCardMessageRequest(TeaModel):
    def __init__(
        self,
        at_user_ids: List[str] = None,
        card_content: PersonalSendCardMessageRequestCardContent = None,
        open_conversation_id: str = None,
        receive_user_id: str = None,
    ):
        self.at_user_ids = at_user_ids
        self.card_content = card_content
        self.open_conversation_id = open_conversation_id
        self.receive_user_id = receive_user_id

    def validate(self):
        if self.card_content:
            self.card_content.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.at_user_ids is not None:
            result['atUserIds'] = self.at_user_ids
        if self.card_content is not None:
            result['cardContent'] = self.card_content.to_map()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.receive_user_id is not None:
            result['receiveUserId'] = self.receive_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('atUserIds') is not None:
            self.at_user_ids = m.get('atUserIds')
        if m.get('cardContent') is not None:
            temp_model = PersonalSendCardMessageRequestCardContent()
            self.card_content = temp_model.from_map(m['cardContent'])
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('receiveUserId') is not None:
            self.receive_user_id = m.get('receiveUserId')
        return self


class PersonalSendCardMessageResponseBodyResult(TeaModel):
    def __init__(
        self,
        open_task_id: str = None,
    ):
        self.open_task_id = open_task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_task_id is not None:
            result['openTaskId'] = self.open_task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openTaskId') is not None:
            self.open_task_id = m.get('openTaskId')
        return self


class PersonalSendCardMessageResponseBody(TeaModel):
    def __init__(
        self,
        result: PersonalSendCardMessageResponseBodyResult = None,
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
            temp_model = PersonalSendCardMessageResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class PersonalSendCardMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PersonalSendCardMessageResponseBody = None,
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
            temp_model = PersonalSendCardMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryGroupInfoByMemberAuthHeaders(TeaModel):
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


class QueryGroupInfoByMemberAuthRequest(TeaModel):
    def __init__(
        self,
        cool_app_code: str = None,
        open_conversation_id: str = None,
    ):
        # This parameter is required.
        self.cool_app_code = cool_app_code
        # This parameter is required.
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cool_app_code is not None:
            result['coolAppCode'] = self.cool_app_code
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('coolAppCode') is not None:
            self.cool_app_code = m.get('coolAppCode')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class QueryGroupInfoByMemberAuthResponseBody(TeaModel):
    def __init__(
        self,
        member_count: int = None,
    ):
        self.member_count = member_count

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.member_count is not None:
            result['memberCount'] = self.member_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('memberCount') is not None:
            self.member_count = m.get('memberCount')
        return self


class QueryGroupInfoByMemberAuthResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryGroupInfoByMemberAuthResponseBody = None,
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
            temp_model = QueryGroupInfoByMemberAuthResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryGroupMemberHeaders(TeaModel):
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


class QueryGroupMemberRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
    ):
        # This parameter is required.
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class QueryGroupMemberResponseBodyGroupMembers(TeaModel):
    def __init__(
        self,
        group_member_avatar: str = None,
        group_member_dynamics: str = None,
        group_member_id: str = None,
        group_member_name: str = None,
        group_member_type: int = None,
    ):
        self.group_member_avatar = group_member_avatar
        self.group_member_dynamics = group_member_dynamics
        self.group_member_id = group_member_id
        # This parameter is required.
        self.group_member_name = group_member_name
        # This parameter is required.
        self.group_member_type = group_member_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_member_avatar is not None:
            result['groupMemberAvatar'] = self.group_member_avatar
        if self.group_member_dynamics is not None:
            result['groupMemberDynamics'] = self.group_member_dynamics
        if self.group_member_id is not None:
            result['groupMemberId'] = self.group_member_id
        if self.group_member_name is not None:
            result['groupMemberName'] = self.group_member_name
        if self.group_member_type is not None:
            result['groupMemberType'] = self.group_member_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupMemberAvatar') is not None:
            self.group_member_avatar = m.get('groupMemberAvatar')
        if m.get('groupMemberDynamics') is not None:
            self.group_member_dynamics = m.get('groupMemberDynamics')
        if m.get('groupMemberId') is not None:
            self.group_member_id = m.get('groupMemberId')
        if m.get('groupMemberName') is not None:
            self.group_member_name = m.get('groupMemberName')
        if m.get('groupMemberType') is not None:
            self.group_member_type = m.get('groupMemberType')
        return self


class QueryGroupMemberResponseBody(TeaModel):
    def __init__(
        self,
        group_members: List[QueryGroupMemberResponseBodyGroupMembers] = None,
        open_conversation_id: str = None,
    ):
        # This parameter is required.
        self.group_members = group_members
        # This parameter is required.
        self.open_conversation_id = open_conversation_id

    def validate(self):
        if self.group_members:
            for k in self.group_members:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['groupMembers'] = []
        if self.group_members is not None:
            for k in self.group_members:
                result['groupMembers'].append(k.to_map() if k else None)
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.group_members = []
        if m.get('groupMembers') is not None:
            for k in m.get('groupMembers'):
                temp_model = QueryGroupMemberResponseBodyGroupMembers()
                self.group_members.append(temp_model.from_map(k))
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class QueryGroupMemberResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryGroupMemberResponseBody = None,
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
            temp_model = QueryGroupMemberResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryGroupMemberByMemberAuthHeaders(TeaModel):
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


class QueryGroupMemberByMemberAuthRequest(TeaModel):
    def __init__(
        self,
        cool_app_code: str = None,
        open_conversation_id: str = None,
    ):
        # This parameter is required.
        self.cool_app_code = cool_app_code
        # This parameter is required.
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cool_app_code is not None:
            result['coolAppCode'] = self.cool_app_code
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('coolAppCode') is not None:
            self.cool_app_code = m.get('coolAppCode')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class QueryGroupMemberByMemberAuthResponseBodyGroupMemberList(TeaModel):
    def __init__(
        self,
        group_nick_name: str = None,
        org_name: str = None,
        profile_photo_url: str = None,
        user_id: str = None,
    ):
        self.group_nick_name = group_nick_name
        self.org_name = org_name
        self.profile_photo_url = profile_photo_url
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_nick_name is not None:
            result['groupNickName'] = self.group_nick_name
        if self.org_name is not None:
            result['orgName'] = self.org_name
        if self.profile_photo_url is not None:
            result['profilePhotoUrl'] = self.profile_photo_url
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupNickName') is not None:
            self.group_nick_name = m.get('groupNickName')
        if m.get('orgName') is not None:
            self.org_name = m.get('orgName')
        if m.get('profilePhotoUrl') is not None:
            self.profile_photo_url = m.get('profilePhotoUrl')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryGroupMemberByMemberAuthResponseBody(TeaModel):
    def __init__(
        self,
        group_member_list: List[QueryGroupMemberByMemberAuthResponseBodyGroupMemberList] = None,
    ):
        self.group_member_list = group_member_list

    def validate(self):
        if self.group_member_list:
            for k in self.group_member_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['groupMemberList'] = []
        if self.group_member_list is not None:
            for k in self.group_member_list:
                result['groupMemberList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.group_member_list = []
        if m.get('groupMemberList') is not None:
            for k in m.get('groupMemberList'):
                temp_model = QueryGroupMemberByMemberAuthResponseBodyGroupMemberList()
                self.group_member_list.append(temp_model.from_map(k))
        return self


class QueryGroupMemberByMemberAuthResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryGroupMemberByMemberAuthResponseBody = None,
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
            temp_model = QueryGroupMemberByMemberAuthResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryGroupMuteStatusHeaders(TeaModel):
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


class QueryGroupMuteStatusRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
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


class QueryGroupMuteStatusResponseBodyUserMuteResult(TeaModel):
    def __init__(
        self,
        mute_end_time: int = None,
        mute_start_time: int = None,
        user_mute_mode: bool = None,
    ):
        # This parameter is required.
        self.mute_end_time = mute_end_time
        # This parameter is required.
        self.mute_start_time = mute_start_time
        # This parameter is required.
        self.user_mute_mode = user_mute_mode

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.mute_end_time is not None:
            result['muteEndTime'] = self.mute_end_time
        if self.mute_start_time is not None:
            result['muteStartTime'] = self.mute_start_time
        if self.user_mute_mode is not None:
            result['userMuteMode'] = self.user_mute_mode
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('muteEndTime') is not None:
            self.mute_end_time = m.get('muteEndTime')
        if m.get('muteStartTime') is not None:
            self.mute_start_time = m.get('muteStartTime')
        if m.get('userMuteMode') is not None:
            self.user_mute_mode = m.get('userMuteMode')
        return self


class QueryGroupMuteStatusResponseBody(TeaModel):
    def __init__(
        self,
        group_mute_mode: bool = None,
        user_mute_result: QueryGroupMuteStatusResponseBodyUserMuteResult = None,
    ):
        # This parameter is required.
        self.group_mute_mode = group_mute_mode
        # This parameter is required.
        self.user_mute_result = user_mute_result

    def validate(self):
        if self.user_mute_result:
            self.user_mute_result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_mute_mode is not None:
            result['groupMuteMode'] = self.group_mute_mode
        if self.user_mute_result is not None:
            result['userMuteResult'] = self.user_mute_result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupMuteMode') is not None:
            self.group_mute_mode = m.get('groupMuteMode')
        if m.get('userMuteResult') is not None:
            temp_model = QueryGroupMuteStatusResponseBodyUserMuteResult()
            self.user_mute_result = temp_model.from_map(m['userMuteResult'])
        return self


class QueryGroupMuteStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryGroupMuteStatusResponseBody = None,
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
            temp_model = QueryGroupMuteStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryInnerGroupMemberListHeaders(TeaModel):
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


class QueryInnerGroupMemberListRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: int = None,
        open_conversation_id: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
        self.next_token = next_token
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.user_id = user_id

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
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryInnerGroupMemberListResponseBodyList(TeaModel):
    def __init__(
        self,
        icon: str = None,
        name: str = None,
        nick_name: str = None,
        user_id: str = None,
    ):
        self.icon = icon
        self.name = name
        self.nick_name = nick_name
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.icon is not None:
            result['icon'] = self.icon
        if self.name is not None:
            result['name'] = self.name
        if self.nick_name is not None:
            result['nickName'] = self.nick_name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('nickName') is not None:
            self.nick_name = m.get('nickName')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryInnerGroupMemberListResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[QueryInnerGroupMemberListResponseBodyList] = None,
        next_token: int = None,
        success: bool = None,
    ):
        self.has_more = has_more
        self.list = list
        self.next_token = next_token
        self.success = success

    def validate(self):
        if self.list:
            for k in self.list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = QueryInnerGroupMemberListResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryInnerGroupMemberListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryInnerGroupMemberListResponseBody = None,
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
            temp_model = QueryInnerGroupMemberListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryInnerGroupRecentListHeaders(TeaModel):
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


class QueryInnerGroupRecentListRequest(TeaModel):
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


class QueryInnerGroupRecentListResponseBodyGroupInfos(TeaModel):
    def __init__(
        self,
        icon: str = None,
        member_amount: str = None,
        open_conversation_id: str = None,
        title: str = None,
    ):
        self.icon = icon
        self.member_amount = member_amount
        self.open_conversation_id = open_conversation_id
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.icon is not None:
            result['icon'] = self.icon
        if self.member_amount is not None:
            result['memberAmount'] = self.member_amount
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('memberAmount') is not None:
            self.member_amount = m.get('memberAmount')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class QueryInnerGroupRecentListResponseBody(TeaModel):
    def __init__(
        self,
        group_infos: List[QueryInnerGroupRecentListResponseBodyGroupInfos] = None,
        success: bool = None,
    ):
        self.group_infos = group_infos
        self.success = success

    def validate(self):
        if self.group_infos:
            for k in self.group_infos:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['groupInfos'] = []
        if self.group_infos is not None:
            for k in self.group_infos:
                result['groupInfos'].append(k.to_map() if k else None)
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.group_infos = []
        if m.get('groupInfos') is not None:
            for k in m.get('groupInfos'):
                temp_model = QueryInnerGroupRecentListResponseBodyGroupInfos()
                self.group_infos.append(temp_model.from_map(k))
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryInnerGroupRecentListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryInnerGroupRecentListResponseBody = None,
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
            temp_model = QueryInnerGroupRecentListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryMembersOfGroupRoleHeaders(TeaModel):
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


class QueryMembersOfGroupRoleRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        open_role_id: str = None,
        timestamp: int = None,
    ):
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.open_role_id = open_role_id
        self.timestamp = timestamp

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.open_role_id is not None:
            result['openRoleId'] = self.open_role_id
        if self.timestamp is not None:
            result['timestamp'] = self.timestamp
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('openRoleId') is not None:
            self.open_role_id = m.get('openRoleId')
        if m.get('timestamp') is not None:
            self.timestamp = m.get('timestamp')
        return self


class QueryMembersOfGroupRoleResponseBody(TeaModel):
    def __init__(
        self,
        user_ids: List[str] = None,
    ):
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class QueryMembersOfGroupRoleResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryMembersOfGroupRoleResponseBody = None,
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
            temp_model = QueryMembersOfGroupRoleResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryMessageSendResultHeaders(TeaModel):
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


class QueryMessageSendResultRequest(TeaModel):
    def __init__(
        self,
        open_task_id: str = None,
    ):
        self.open_task_id = open_task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_task_id is not None:
            result['openTaskId'] = self.open_task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openTaskId') is not None:
            self.open_task_id = m.get('openTaskId')
        return self


class QueryMessageSendResultResponseBodyResult(TeaModel):
    def __init__(
        self,
        open_message_id: str = None,
        send_status: int = None,
    ):
        self.open_message_id = open_message_id
        self.send_status = send_status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_message_id is not None:
            result['openMessageId'] = self.open_message_id
        if self.send_status is not None:
            result['sendStatus'] = self.send_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openMessageId') is not None:
            self.open_message_id = m.get('openMessageId')
        if m.get('sendStatus') is not None:
            self.send_status = m.get('sendStatus')
        return self


class QueryMessageSendResultResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryMessageSendResultResponseBodyResult = None,
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
            temp_model = QueryMessageSendResultResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryMessageSendResultResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryMessageSendResultResponseBody = None,
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
            temp_model = QueryMessageSendResultResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryOpenConversationReceiveUserHeaders(TeaModel):
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


class QueryOpenConversationReceiveUserRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        send_user_id: str = None,
    ):
        self.open_conversation_id = open_conversation_id
        self.send_user_id = send_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.send_user_id is not None:
            result['sendUserId'] = self.send_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('sendUserId') is not None:
            self.send_user_id = m.get('sendUserId')
        return self


class QueryOpenConversationReceiveUserResponseBodyResultReceiveUser(TeaModel):
    def __init__(
        self,
        icon: str = None,
        name: str = None,
        nick_name: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.icon = icon
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.nick_name = nick_name
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.icon is not None:
            result['icon'] = self.icon
        if self.name is not None:
            result['name'] = self.name
        if self.nick_name is not None:
            result['nickName'] = self.nick_name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('nickName') is not None:
            self.nick_name = m.get('nickName')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryOpenConversationReceiveUserResponseBodyResult(TeaModel):
    def __init__(
        self,
        receive_user: QueryOpenConversationReceiveUserResponseBodyResultReceiveUser = None,
    ):
        self.receive_user = receive_user

    def validate(self):
        if self.receive_user:
            self.receive_user.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.receive_user is not None:
            result['receiveUser'] = self.receive_user.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('receiveUser') is not None:
            temp_model = QueryOpenConversationReceiveUserResponseBodyResultReceiveUser()
            self.receive_user = temp_model.from_map(m['receiveUser'])
        return self


class QueryOpenConversationReceiveUserResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryOpenConversationReceiveUserResponseBodyResult = None,
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
            temp_model = QueryOpenConversationReceiveUserResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryOpenConversationReceiveUserResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryOpenConversationReceiveUserResponseBody = None,
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
            temp_model = QueryOpenConversationReceiveUserResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryOpenGroupBaseInfoHeaders(TeaModel):
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


class QueryOpenGroupBaseInfoRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
    ):
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class QueryOpenGroupBaseInfoResponseBodyResult(TeaModel):
    def __init__(
        self,
        icon: str = None,
        member_count: int = None,
        open_conversation_id: str = None,
        tag: str = None,
        title: str = None,
    ):
        self.icon = icon
        self.member_count = member_count
        self.open_conversation_id = open_conversation_id
        self.tag = tag
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.icon is not None:
            result['icon'] = self.icon
        if self.member_count is not None:
            result['memberCount'] = self.member_count
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.tag is not None:
            result['tag'] = self.tag
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('memberCount') is not None:
            self.member_count = m.get('memberCount')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('tag') is not None:
            self.tag = m.get('tag')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class QueryOpenGroupBaseInfoResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryOpenGroupBaseInfoResponseBodyResult = None,
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
            temp_model = QueryOpenGroupBaseInfoResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryOpenGroupBaseInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryOpenGroupBaseInfoResponseBody = None,
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
            temp_model = QueryOpenGroupBaseInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryPersonalMessageReadStatusHeaders(TeaModel):
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


class QueryPersonalMessageReadStatusRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        open_message_id: str = None,
    ):
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.open_message_id = open_message_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.open_message_id is not None:
            result['openMessageId'] = self.open_message_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('openMessageId') is not None:
            self.open_message_id = m.get('openMessageId')
        return self


class QueryPersonalMessageReadStatusResponseBodyResultMessageReadInfoList(TeaModel):
    def __init__(
        self,
        read_status: str = None,
        user_id: str = None,
    ):
        self.read_status = read_status
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.read_status is not None:
            result['readStatus'] = self.read_status
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('readStatus') is not None:
            self.read_status = m.get('readStatus')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryPersonalMessageReadStatusResponseBodyResult(TeaModel):
    def __init__(
        self,
        message_read_info_list: List[QueryPersonalMessageReadStatusResponseBodyResultMessageReadInfoList] = None,
    ):
        self.message_read_info_list = message_read_info_list

    def validate(self):
        if self.message_read_info_list:
            for k in self.message_read_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['messageReadInfoList'] = []
        if self.message_read_info_list is not None:
            for k in self.message_read_info_list:
                result['messageReadInfoList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.message_read_info_list = []
        if m.get('messageReadInfoList') is not None:
            for k in m.get('messageReadInfoList'):
                temp_model = QueryPersonalMessageReadStatusResponseBodyResultMessageReadInfoList()
                self.message_read_info_list.append(temp_model.from_map(k))
        return self


class QueryPersonalMessageReadStatusResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryPersonalMessageReadStatusResponseBodyResult = None,
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
            temp_model = QueryPersonalMessageReadStatusResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryPersonalMessageReadStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryPersonalMessageReadStatusResponseBody = None,
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
            temp_model = QueryPersonalMessageReadStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryRecentConversationsHeaders(TeaModel):
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


class QueryRecentConversationsRequest(TeaModel):
    def __init__(
        self,
        only_human: bool = None,
        only_inner_group: bool = None,
        user_id: str = None,
    ):
        self.only_human = only_human
        self.only_inner_group = only_inner_group
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.only_human is not None:
            result['onlyHuman'] = self.only_human
        if self.only_inner_group is not None:
            result['onlyInnerGroup'] = self.only_inner_group
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('onlyHuman') is not None:
            self.only_human = m.get('onlyHuman')
        if m.get('onlyInnerGroup') is not None:
            self.only_inner_group = m.get('onlyInnerGroup')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryRecentConversationsResponseBodyResultConversationList(TeaModel):
    def __init__(
        self,
        conversation_type: int = None,
        icon: str = None,
        member_count: str = None,
        name: str = None,
        nick_name: str = None,
        open_conversation_id: str = None,
        title: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.conversation_type = conversation_type
        # This parameter is required.
        self.icon = icon
        # This parameter is required.
        self.member_count = member_count
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.nick_name = nick_name
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
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
        if self.conversation_type is not None:
            result['conversationType'] = self.conversation_type
        if self.icon is not None:
            result['icon'] = self.icon
        if self.member_count is not None:
            result['memberCount'] = self.member_count
        if self.name is not None:
            result['name'] = self.name
        if self.nick_name is not None:
            result['nickName'] = self.nick_name
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.title is not None:
            result['title'] = self.title
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conversationType') is not None:
            self.conversation_type = m.get('conversationType')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('memberCount') is not None:
            self.member_count = m.get('memberCount')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('nickName') is not None:
            self.nick_name = m.get('nickName')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryRecentConversationsResponseBodyResult(TeaModel):
    def __init__(
        self,
        conversation_list: List[QueryRecentConversationsResponseBodyResultConversationList] = None,
    ):
        self.conversation_list = conversation_list

    def validate(self):
        if self.conversation_list:
            for k in self.conversation_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['conversationList'] = []
        if self.conversation_list is not None:
            for k in self.conversation_list:
                result['conversationList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.conversation_list = []
        if m.get('conversationList') is not None:
            for k in m.get('conversationList'):
                temp_model = QueryRecentConversationsResponseBodyResultConversationList()
                self.conversation_list.append(temp_model.from_map(k))
        return self


class QueryRecentConversationsResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryRecentConversationsResponseBodyResult = None,
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
            temp_model = QueryRecentConversationsResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryRecentConversationsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryRecentConversationsResponseBody = None,
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
            temp_model = QueryRecentConversationsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QuerySceneGroupTemplateRobotHeaders(TeaModel):
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


class QuerySceneGroupTemplateRobotRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        robot_code: str = None,
    ):
        self.open_conversation_id = open_conversation_id
        self.robot_code = robot_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        return self


class QuerySceneGroupTemplateRobotResponseBodyResult(TeaModel):
    def __init__(
        self,
        union_id: str = None,
        user_id: str = None,
    ):
        self.union_id = union_id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QuerySceneGroupTemplateRobotResponseBody(TeaModel):
    def __init__(
        self,
        result: QuerySceneGroupTemplateRobotResponseBodyResult = None,
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
            temp_model = QuerySceneGroupTemplateRobotResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QuerySceneGroupTemplateRobotResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QuerySceneGroupTemplateRobotResponseBody = None,
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
            temp_model = QuerySceneGroupTemplateRobotResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QuerySingleGroupHeaders(TeaModel):
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


class QuerySingleGroupRequestGroupMembers(TeaModel):
    def __init__(
        self,
        app_user_id: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_user_id = app_user_id
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_user_id is not None:
            result['appUserId'] = self.app_user_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUserId') is not None:
            self.app_user_id = m.get('appUserId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QuerySingleGroupRequest(TeaModel):
    def __init__(
        self,
        group_members: List[QuerySingleGroupRequestGroupMembers] = None,
        group_template_id: str = None,
    ):
        # This parameter is required.
        self.group_members = group_members
        # This parameter is required.
        self.group_template_id = group_template_id

    def validate(self):
        if self.group_members:
            for k in self.group_members:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['groupMembers'] = []
        if self.group_members is not None:
            for k in self.group_members:
                result['groupMembers'].append(k.to_map() if k else None)
        if self.group_template_id is not None:
            result['groupTemplateId'] = self.group_template_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.group_members = []
        if m.get('groupMembers') is not None:
            for k in m.get('groupMembers'):
                temp_model = QuerySingleGroupRequestGroupMembers()
                self.group_members.append(temp_model.from_map(k))
        if m.get('groupTemplateId') is not None:
            self.group_template_id = m.get('groupTemplateId')
        return self


class QuerySingleGroupResponseBodyOpenConversations(TeaModel):
    def __init__(
        self,
        app_user_id: str = None,
        open_conversation_id: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_user_id = app_user_id
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_user_id is not None:
            result['appUserId'] = self.app_user_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUserId') is not None:
            self.app_user_id = m.get('appUserId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QuerySingleGroupResponseBody(TeaModel):
    def __init__(
        self,
        open_conversations: List[QuerySingleGroupResponseBodyOpenConversations] = None,
    ):
        # This parameter is required.
        self.open_conversations = open_conversations

    def validate(self):
        if self.open_conversations:
            for k in self.open_conversations:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['openConversations'] = []
        if self.open_conversations is not None:
            for k in self.open_conversations:
                result['openConversations'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.open_conversations = []
        if m.get('openConversations') is not None:
            for k in m.get('openConversations'):
                temp_model = QuerySingleGroupResponseBodyOpenConversations()
                self.open_conversations.append(temp_model.from_map(k))
        return self


class QuerySingleGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QuerySingleGroupResponseBody = None,
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
            temp_model = QuerySingleGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryUnReadMessageHeaders(TeaModel):
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


class QueryUnReadMessageRequest(TeaModel):
    def __init__(
        self,
        app_user_id: str = None,
        open_conversation_ids: List[str] = None,
    ):
        # This parameter is required.
        self.app_user_id = app_user_id
        self.open_conversation_ids = open_conversation_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_user_id is not None:
            result['appUserId'] = self.app_user_id
        if self.open_conversation_ids is not None:
            result['openConversationIds'] = self.open_conversation_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUserId') is not None:
            self.app_user_id = m.get('appUserId')
        if m.get('openConversationIds') is not None:
            self.open_conversation_ids = m.get('openConversationIds')
        return self


class QueryUnReadMessageResponseBodyUnReadItems(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        un_read_count: int = None,
    ):
        self.open_conversation_id = open_conversation_id
        self.un_read_count = un_read_count

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.un_read_count is not None:
            result['unReadCount'] = self.un_read_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('unReadCount') is not None:
            self.un_read_count = m.get('unReadCount')
        return self


class QueryUnReadMessageResponseBody(TeaModel):
    def __init__(
        self,
        un_read_count: int = None,
        un_read_items: List[QueryUnReadMessageResponseBodyUnReadItems] = None,
    ):
        # This parameter is required.
        self.un_read_count = un_read_count
        self.un_read_items = un_read_items

    def validate(self):
        if self.un_read_items:
            for k in self.un_read_items:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.un_read_count is not None:
            result['unReadCount'] = self.un_read_count
        result['unReadItems'] = []
        if self.un_read_items is not None:
            for k in self.un_read_items:
                result['unReadItems'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('unReadCount') is not None:
            self.un_read_count = m.get('unReadCount')
        self.un_read_items = []
        if m.get('unReadItems') is not None:
            for k in m.get('unReadItems'):
                temp_model = QueryUnReadMessageResponseBodyUnReadItems()
                self.un_read_items.append(temp_model.from_map(k))
        return self


class QueryUnReadMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryUnReadMessageResponseBody = None,
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
            temp_model = QueryUnReadMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryUnfurlingRegisterCreatorHeaders(TeaModel):
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


class QueryUnfurlingRegisterCreatorRequest(TeaModel):
    def __init__(
        self,
        domain: str = None,
        path: str = None,
    ):
        # This parameter is required.
        self.domain = domain
        # This parameter is required.
        self.path = path

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.domain is not None:
            result['domain'] = self.domain
        if self.path is not None:
            result['path'] = self.path
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('domain') is not None:
            self.domain = m.get('domain')
        if m.get('path') is not None:
            self.path = m.get('path')
        return self


class QueryUnfurlingRegisterCreatorResponseBodyData(TeaModel):
    def __init__(
        self,
        app_id: str = None,
        creator_user_id: str = None,
        id: int = None,
    ):
        self.app_id = app_id
        self.creator_user_id = creator_user_id
        self.id = id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.creator_user_id is not None:
            result['creatorUserId'] = self.creator_user_id
        if self.id is not None:
            result['id'] = self.id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('creatorUserId') is not None:
            self.creator_user_id = m.get('creatorUserId')
        if m.get('id') is not None:
            self.id = m.get('id')
        return self


class QueryUnfurlingRegisterCreatorResponseBody(TeaModel):
    def __init__(
        self,
        data: QueryUnfurlingRegisterCreatorResponseBodyData = None,
        success: bool = None,
    ):
        self.data = data
        self.success = success

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            temp_model = QueryUnfurlingRegisterCreatorResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryUnfurlingRegisterCreatorResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryUnfurlingRegisterCreatorResponseBody = None,
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
            temp_model = QueryUnfurlingRegisterCreatorResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryUnfurlingRegisterInfoHeaders(TeaModel):
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


class QueryUnfurlingRegisterInfoRequest(TeaModel):
    def __init__(
        self,
        app_id: str = None,
        max_results: int = None,
        next_token: int = None,
    ):
        # This parameter is required.
        self.app_id = app_id
        self.max_results = max_results
        self.next_token = next_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class QueryUnfurlingRegisterInfoResponseBodyList(TeaModel):
    def __init__(
        self,
        api_secret: str = None,
        app_id: str = None,
        app_name: str = None,
        callback_type: int = None,
        callback_url: str = None,
        card_template_id: str = None,
        creator_user_id: str = None,
        domain: str = None,
        gray_group_id_list: List[str] = None,
        gray_user_id_list: List[str] = None,
        hsf_method_name: str = None,
        hsf_service_name: str = None,
        hsf_version: str = None,
        id: int = None,
        path: str = None,
        rule_desc: str = None,
        rule_match_type: int = None,
        status: int = None,
    ):
        self.api_secret = api_secret
        self.app_id = app_id
        self.app_name = app_name
        self.callback_type = callback_type
        self.callback_url = callback_url
        self.card_template_id = card_template_id
        self.creator_user_id = creator_user_id
        self.domain = domain
        self.gray_group_id_list = gray_group_id_list
        self.gray_user_id_list = gray_user_id_list
        self.hsf_method_name = hsf_method_name
        self.hsf_service_name = hsf_service_name
        self.hsf_version = hsf_version
        self.id = id
        self.path = path
        self.rule_desc = rule_desc
        self.rule_match_type = rule_match_type
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.api_secret is not None:
            result['apiSecret'] = self.api_secret
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.app_name is not None:
            result['appName'] = self.app_name
        if self.callback_type is not None:
            result['callbackType'] = self.callback_type
        if self.callback_url is not None:
            result['callbackUrl'] = self.callback_url
        if self.card_template_id is not None:
            result['cardTemplateId'] = self.card_template_id
        if self.creator_user_id is not None:
            result['creatorUserId'] = self.creator_user_id
        if self.domain is not None:
            result['domain'] = self.domain
        if self.gray_group_id_list is not None:
            result['grayGroupIdList'] = self.gray_group_id_list
        if self.gray_user_id_list is not None:
            result['grayUserIdList'] = self.gray_user_id_list
        if self.hsf_method_name is not None:
            result['hsfMethodName'] = self.hsf_method_name
        if self.hsf_service_name is not None:
            result['hsfServiceName'] = self.hsf_service_name
        if self.hsf_version is not None:
            result['hsfVersion'] = self.hsf_version
        if self.id is not None:
            result['id'] = self.id
        if self.path is not None:
            result['path'] = self.path
        if self.rule_desc is not None:
            result['ruleDesc'] = self.rule_desc
        if self.rule_match_type is not None:
            result['ruleMatchType'] = self.rule_match_type
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('apiSecret') is not None:
            self.api_secret = m.get('apiSecret')
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('appName') is not None:
            self.app_name = m.get('appName')
        if m.get('callbackType') is not None:
            self.callback_type = m.get('callbackType')
        if m.get('callbackUrl') is not None:
            self.callback_url = m.get('callbackUrl')
        if m.get('cardTemplateId') is not None:
            self.card_template_id = m.get('cardTemplateId')
        if m.get('creatorUserId') is not None:
            self.creator_user_id = m.get('creatorUserId')
        if m.get('domain') is not None:
            self.domain = m.get('domain')
        if m.get('grayGroupIdList') is not None:
            self.gray_group_id_list = m.get('grayGroupIdList')
        if m.get('grayUserIdList') is not None:
            self.gray_user_id_list = m.get('grayUserIdList')
        if m.get('hsfMethodName') is not None:
            self.hsf_method_name = m.get('hsfMethodName')
        if m.get('hsfServiceName') is not None:
            self.hsf_service_name = m.get('hsfServiceName')
        if m.get('hsfVersion') is not None:
            self.hsf_version = m.get('hsfVersion')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('path') is not None:
            self.path = m.get('path')
        if m.get('ruleDesc') is not None:
            self.rule_desc = m.get('ruleDesc')
        if m.get('ruleMatchType') is not None:
            self.rule_match_type = m.get('ruleMatchType')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class QueryUnfurlingRegisterInfoResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[QueryUnfurlingRegisterInfoResponseBodyList] = None,
        next_token: int = None,
        success: bool = None,
    ):
        self.has_more = has_more
        self.list = list
        self.next_token = next_token
        self.success = success

    def validate(self):
        if self.list:
            for k in self.list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = QueryUnfurlingRegisterInfoResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryUnfurlingRegisterInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryUnfurlingRegisterInfoResponseBody = None,
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
            temp_model = QueryUnfurlingRegisterInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ReleaseUnfurlingRegisterHeaders(TeaModel):
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


class ReleaseUnfurlingRegisterRequest(TeaModel):
    def __init__(
        self,
        app_id: str = None,
        id: int = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_id = app_id
        # This parameter is required.
        self.id = id
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.id is not None:
            result['id'] = self.id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class ReleaseUnfurlingRegisterResponseBody(TeaModel):
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


class ReleaseUnfurlingRegisterResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ReleaseUnfurlingRegisterResponseBody = None,
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
            temp_model = ReleaseUnfurlingRegisterResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RemoveRobotFromConversationHeaders(TeaModel):
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


class RemoveRobotFromConversationRequest(TeaModel):
    def __init__(
        self,
        chat_bot_user_id: str = None,
        open_conversation_id: str = None,
    ):
        # This parameter is required.
        self.chat_bot_user_id = chat_bot_user_id
        # This parameter is required.
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.chat_bot_user_id is not None:
            result['chatBotUserId'] = self.chat_bot_user_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('chatBotUserId') is not None:
            self.chat_bot_user_id = m.get('chatBotUserId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class RemoveRobotFromConversationResponseBody(TeaModel):
    def __init__(
        self,
        chat_bot_user_id: str = None,
    ):
        self.chat_bot_user_id = chat_bot_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.chat_bot_user_id is not None:
            result['chatBotUserId'] = self.chat_bot_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('chatBotUserId') is not None:
            self.chat_bot_user_id = m.get('chatBotUserId')
        return self


class RemoveRobotFromConversationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RemoveRobotFromConversationResponseBody = None,
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
            temp_model = RemoveRobotFromConversationResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SearchInnerGroupsHeaders(TeaModel):
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


class SearchInnerGroupsRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        search_key: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
        self.search_key = search_key
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.search_key is not None:
            result['searchKey'] = self.search_key
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('searchKey') is not None:
            self.search_key = m.get('searchKey')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class SearchInnerGroupsResponseBodyGroupInfos(TeaModel):
    def __init__(
        self,
        icon: str = None,
        member_amount: str = None,
        open_conversation_id: str = None,
        title: str = None,
    ):
        self.icon = icon
        self.member_amount = member_amount
        self.open_conversation_id = open_conversation_id
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.icon is not None:
            result['icon'] = self.icon
        if self.member_amount is not None:
            result['memberAmount'] = self.member_amount
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('memberAmount') is not None:
            self.member_amount = m.get('memberAmount')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class SearchInnerGroupsResponseBody(TeaModel):
    def __init__(
        self,
        group_infos: List[SearchInnerGroupsResponseBodyGroupInfos] = None,
    ):
        self.group_infos = group_infos

    def validate(self):
        if self.group_infos:
            for k in self.group_infos:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['groupInfos'] = []
        if self.group_infos is not None:
            for k in self.group_infos:
                result['groupInfos'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.group_infos = []
        if m.get('groupInfos') is not None:
            for k in m.get('groupInfos'):
                temp_model = SearchInnerGroupsResponseBodyGroupInfos()
                self.group_infos.append(temp_model.from_map(k))
        return self


class SearchInnerGroupsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SearchInnerGroupsResponseBody = None,
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
            temp_model = SearchInnerGroupsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SendInteractiveCardHeaders(TeaModel):
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


class SendInteractiveCardRequestCardData(TeaModel):
    def __init__(
        self,
        card_media_id_param_map: Dict[str, str] = None,
        card_param_map: Dict[str, str] = None,
    ):
        self.card_media_id_param_map = card_media_id_param_map
        self.card_param_map = card_param_map

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.card_media_id_param_map is not None:
            result['cardMediaIdParamMap'] = self.card_media_id_param_map
        if self.card_param_map is not None:
            result['cardParamMap'] = self.card_param_map
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cardMediaIdParamMap') is not None:
            self.card_media_id_param_map = m.get('cardMediaIdParamMap')
        if m.get('cardParamMap') is not None:
            self.card_param_map = m.get('cardParamMap')
        return self


class SendInteractiveCardRequestCardOptions(TeaModel):
    def __init__(
        self,
        support_forward: bool = None,
    ):
        self.support_forward = support_forward

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.support_forward is not None:
            result['supportForward'] = self.support_forward
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('supportForward') is not None:
            self.support_forward = m.get('supportForward')
        return self


class SendInteractiveCardRequest(TeaModel):
    def __init__(
        self,
        at_open_ids: Dict[str, str] = None,
        callback_route_key: str = None,
        card_data: SendInteractiveCardRequestCardData = None,
        card_options: SendInteractiveCardRequestCardOptions = None,
        card_template_id: str = None,
        chat_bot_id: str = None,
        conversation_type: int = None,
        digital_worker_code: str = None,
        open_conversation_id: str = None,
        out_track_id: str = None,
        private_data: Dict[str, PrivateDataValue] = None,
        pull_strategy: bool = None,
        receiver_user_id_list: List[str] = None,
        robot_code: str = None,
        user_id_type: int = None,
    ):
        self.at_open_ids = at_open_ids
        self.callback_route_key = callback_route_key
        # This parameter is required.
        self.card_data = card_data
        self.card_options = card_options
        # This parameter is required.
        self.card_template_id = card_template_id
        self.chat_bot_id = chat_bot_id
        # This parameter is required.
        self.conversation_type = conversation_type
        self.digital_worker_code = digital_worker_code
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.out_track_id = out_track_id
        self.private_data = private_data
        self.pull_strategy = pull_strategy
        self.receiver_user_id_list = receiver_user_id_list
        self.robot_code = robot_code
        self.user_id_type = user_id_type

    def validate(self):
        if self.card_data:
            self.card_data.validate()
        if self.card_options:
            self.card_options.validate()
        if self.private_data:
            for v in self.private_data.values():
                if v:
                    v.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.at_open_ids is not None:
            result['atOpenIds'] = self.at_open_ids
        if self.callback_route_key is not None:
            result['callbackRouteKey'] = self.callback_route_key
        if self.card_data is not None:
            result['cardData'] = self.card_data.to_map()
        if self.card_options is not None:
            result['cardOptions'] = self.card_options.to_map()
        if self.card_template_id is not None:
            result['cardTemplateId'] = self.card_template_id
        if self.chat_bot_id is not None:
            result['chatBotId'] = self.chat_bot_id
        if self.conversation_type is not None:
            result['conversationType'] = self.conversation_type
        if self.digital_worker_code is not None:
            result['digitalWorkerCode'] = self.digital_worker_code
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.out_track_id is not None:
            result['outTrackId'] = self.out_track_id
        result['privateData'] = {}
        if self.private_data is not None:
            for k, v in self.private_data.items():
                result['privateData'][k] = v.to_map()
        if self.pull_strategy is not None:
            result['pullStrategy'] = self.pull_strategy
        if self.receiver_user_id_list is not None:
            result['receiverUserIdList'] = self.receiver_user_id_list
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        if self.user_id_type is not None:
            result['userIdType'] = self.user_id_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('atOpenIds') is not None:
            self.at_open_ids = m.get('atOpenIds')
        if m.get('callbackRouteKey') is not None:
            self.callback_route_key = m.get('callbackRouteKey')
        if m.get('cardData') is not None:
            temp_model = SendInteractiveCardRequestCardData()
            self.card_data = temp_model.from_map(m['cardData'])
        if m.get('cardOptions') is not None:
            temp_model = SendInteractiveCardRequestCardOptions()
            self.card_options = temp_model.from_map(m['cardOptions'])
        if m.get('cardTemplateId') is not None:
            self.card_template_id = m.get('cardTemplateId')
        if m.get('chatBotId') is not None:
            self.chat_bot_id = m.get('chatBotId')
        if m.get('conversationType') is not None:
            self.conversation_type = m.get('conversationType')
        if m.get('digitalWorkerCode') is not None:
            self.digital_worker_code = m.get('digitalWorkerCode')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('outTrackId') is not None:
            self.out_track_id = m.get('outTrackId')
        self.private_data = {}
        if m.get('privateData') is not None:
            for k, v in m.get('privateData').items():
                temp_model = PrivateDataValue()
                self.private_data[k] = temp_model.from_map(v)
        if m.get('pullStrategy') is not None:
            self.pull_strategy = m.get('pullStrategy')
        if m.get('receiverUserIdList') is not None:
            self.receiver_user_id_list = m.get('receiverUserIdList')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        if m.get('userIdType') is not None:
            self.user_id_type = m.get('userIdType')
        return self


class SendInteractiveCardResponseBodyResult(TeaModel):
    def __init__(
        self,
        process_query_key: str = None,
    ):
        # This parameter is required.
        self.process_query_key = process_query_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.process_query_key is not None:
            result['processQueryKey'] = self.process_query_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('processQueryKey') is not None:
            self.process_query_key = m.get('processQueryKey')
        return self


class SendInteractiveCardResponseBody(TeaModel):
    def __init__(
        self,
        result: SendInteractiveCardResponseBodyResult = None,
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
            temp_model = SendInteractiveCardResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class SendInteractiveCardResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SendInteractiveCardResponseBody = None,
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
            temp_model = SendInteractiveCardResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SendOTOInteractiveCardHeaders(TeaModel):
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


class SendOTOInteractiveCardRequestCardData(TeaModel):
    def __init__(
        self,
        card_param_map: Dict[str, str] = None,
    ):
        self.card_param_map = card_param_map

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.card_param_map is not None:
            result['cardParamMap'] = self.card_param_map
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cardParamMap') is not None:
            self.card_param_map = m.get('cardParamMap')
        return self


class SendOTOInteractiveCardRequestCardOptions(TeaModel):
    def __init__(
        self,
        support_forward: bool = None,
    ):
        self.support_forward = support_forward

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.support_forward is not None:
            result['supportForward'] = self.support_forward
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('supportForward') is not None:
            self.support_forward = m.get('supportForward')
        return self


class SendOTOInteractiveCardRequest(TeaModel):
    def __init__(
        self,
        at_open_ids: Dict[str, str] = None,
        callback_route_key: str = None,
        card_data: SendOTOInteractiveCardRequestCardData = None,
        card_options: SendOTOInteractiveCardRequestCardOptions = None,
        card_template_id: str = None,
        open_conversation_id: str = None,
        out_track_id: str = None,
        private_data: Dict[str, PrivateDataValue] = None,
        pull_strategy: bool = None,
        receiver_user_id_list: List[str] = None,
        robot_code: str = None,
        user_id_type: int = None,
    ):
        self.at_open_ids = at_open_ids
        self.callback_route_key = callback_route_key
        # This parameter is required.
        self.card_data = card_data
        self.card_options = card_options
        # This parameter is required.
        self.card_template_id = card_template_id
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.out_track_id = out_track_id
        self.private_data = private_data
        self.pull_strategy = pull_strategy
        self.receiver_user_id_list = receiver_user_id_list
        self.robot_code = robot_code
        self.user_id_type = user_id_type

    def validate(self):
        if self.card_data:
            self.card_data.validate()
        if self.card_options:
            self.card_options.validate()
        if self.private_data:
            for v in self.private_data.values():
                if v:
                    v.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.at_open_ids is not None:
            result['atOpenIds'] = self.at_open_ids
        if self.callback_route_key is not None:
            result['callbackRouteKey'] = self.callback_route_key
        if self.card_data is not None:
            result['cardData'] = self.card_data.to_map()
        if self.card_options is not None:
            result['cardOptions'] = self.card_options.to_map()
        if self.card_template_id is not None:
            result['cardTemplateId'] = self.card_template_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.out_track_id is not None:
            result['outTrackId'] = self.out_track_id
        result['privateData'] = {}
        if self.private_data is not None:
            for k, v in self.private_data.items():
                result['privateData'][k] = v.to_map()
        if self.pull_strategy is not None:
            result['pullStrategy'] = self.pull_strategy
        if self.receiver_user_id_list is not None:
            result['receiverUserIdList'] = self.receiver_user_id_list
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        if self.user_id_type is not None:
            result['userIdType'] = self.user_id_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('atOpenIds') is not None:
            self.at_open_ids = m.get('atOpenIds')
        if m.get('callbackRouteKey') is not None:
            self.callback_route_key = m.get('callbackRouteKey')
        if m.get('cardData') is not None:
            temp_model = SendOTOInteractiveCardRequestCardData()
            self.card_data = temp_model.from_map(m['cardData'])
        if m.get('cardOptions') is not None:
            temp_model = SendOTOInteractiveCardRequestCardOptions()
            self.card_options = temp_model.from_map(m['cardOptions'])
        if m.get('cardTemplateId') is not None:
            self.card_template_id = m.get('cardTemplateId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('outTrackId') is not None:
            self.out_track_id = m.get('outTrackId')
        self.private_data = {}
        if m.get('privateData') is not None:
            for k, v in m.get('privateData').items():
                temp_model = PrivateDataValue()
                self.private_data[k] = temp_model.from_map(v)
        if m.get('pullStrategy') is not None:
            self.pull_strategy = m.get('pullStrategy')
        if m.get('receiverUserIdList') is not None:
            self.receiver_user_id_list = m.get('receiverUserIdList')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        if m.get('userIdType') is not None:
            self.user_id_type = m.get('userIdType')
        return self


class SendOTOInteractiveCardResponseBodyResult(TeaModel):
    def __init__(
        self,
        process_query_key: str = None,
    ):
        # This parameter is required.
        self.process_query_key = process_query_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.process_query_key is not None:
            result['processQueryKey'] = self.process_query_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('processQueryKey') is not None:
            self.process_query_key = m.get('processQueryKey')
        return self


class SendOTOInteractiveCardResponseBody(TeaModel):
    def __init__(
        self,
        result: SendOTOInteractiveCardResponseBodyResult = None,
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
            temp_model = SendOTOInteractiveCardResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class SendOTOInteractiveCardResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SendOTOInteractiveCardResponseBody = None,
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
            temp_model = SendOTOInteractiveCardResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SendPersonalMessageHeaders(TeaModel):
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


class SendPersonalMessageRequest(TeaModel):
    def __init__(
        self,
        content: str = None,
        msg_type: str = None,
        open_conversation_id: str = None,
        receiver_uid: str = None,
    ):
        # This parameter is required.
        self.content = content
        # This parameter is required.
        self.msg_type = msg_type
        self.open_conversation_id = open_conversation_id
        self.receiver_uid = receiver_uid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.msg_type is not None:
            result['msgType'] = self.msg_type
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.receiver_uid is not None:
            result['receiverUid'] = self.receiver_uid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('msgType') is not None:
            self.msg_type = m.get('msgType')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('receiverUid') is not None:
            self.receiver_uid = m.get('receiverUid')
        return self


class SendPersonalMessageResponseBodyResult(TeaModel):
    def __init__(
        self,
        open_task_id: str = None,
    ):
        self.open_task_id = open_task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_task_id is not None:
            result['openTaskId'] = self.open_task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openTaskId') is not None:
            self.open_task_id = m.get('openTaskId')
        return self


class SendPersonalMessageResponseBody(TeaModel):
    def __init__(
        self,
        result: SendPersonalMessageResponseBodyResult = None,
        success: str = None,
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
            temp_model = SendPersonalMessageResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class SendPersonalMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SendPersonalMessageResponseBody = None,
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
            temp_model = SendPersonalMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SendRobotInteractiveCardHeaders(TeaModel):
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


class SendRobotInteractiveCardRequestSendOptions(TeaModel):
    def __init__(
        self,
        at_all: bool = None,
        at_user_list_json: str = None,
        card_property_json: str = None,
        receiver_list_json: str = None,
    ):
        self.at_all = at_all
        self.at_user_list_json = at_user_list_json
        self.card_property_json = card_property_json
        self.receiver_list_json = receiver_list_json

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.at_all is not None:
            result['atAll'] = self.at_all
        if self.at_user_list_json is not None:
            result['atUserListJson'] = self.at_user_list_json
        if self.card_property_json is not None:
            result['cardPropertyJson'] = self.card_property_json
        if self.receiver_list_json is not None:
            result['receiverListJson'] = self.receiver_list_json
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('atAll') is not None:
            self.at_all = m.get('atAll')
        if m.get('atUserListJson') is not None:
            self.at_user_list_json = m.get('atUserListJson')
        if m.get('cardPropertyJson') is not None:
            self.card_property_json = m.get('cardPropertyJson')
        if m.get('receiverListJson') is not None:
            self.receiver_list_json = m.get('receiverListJson')
        return self


class SendRobotInteractiveCardRequest(TeaModel):
    def __init__(
        self,
        callback_url: str = None,
        card_biz_id: str = None,
        card_data: str = None,
        card_template_id: str = None,
        open_conversation_id: str = None,
        pull_strategy: bool = None,
        robot_code: str = None,
        send_options: SendRobotInteractiveCardRequestSendOptions = None,
        single_chat_receiver: str = None,
        union_id_private_data_map: str = None,
        user_id_private_data_map: str = None,
    ):
        self.callback_url = callback_url
        # This parameter is required.
        self.card_biz_id = card_biz_id
        # This parameter is required.
        self.card_data = card_data
        # This parameter is required.
        self.card_template_id = card_template_id
        self.open_conversation_id = open_conversation_id
        self.pull_strategy = pull_strategy
        # This parameter is required.
        self.robot_code = robot_code
        self.send_options = send_options
        self.single_chat_receiver = single_chat_receiver
        self.union_id_private_data_map = union_id_private_data_map
        self.user_id_private_data_map = user_id_private_data_map

    def validate(self):
        if self.send_options:
            self.send_options.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.callback_url is not None:
            result['callbackUrl'] = self.callback_url
        if self.card_biz_id is not None:
            result['cardBizId'] = self.card_biz_id
        if self.card_data is not None:
            result['cardData'] = self.card_data
        if self.card_template_id is not None:
            result['cardTemplateId'] = self.card_template_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.pull_strategy is not None:
            result['pullStrategy'] = self.pull_strategy
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        if self.send_options is not None:
            result['sendOptions'] = self.send_options.to_map()
        if self.single_chat_receiver is not None:
            result['singleChatReceiver'] = self.single_chat_receiver
        if self.union_id_private_data_map is not None:
            result['unionIdPrivateDataMap'] = self.union_id_private_data_map
        if self.user_id_private_data_map is not None:
            result['userIdPrivateDataMap'] = self.user_id_private_data_map
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('callbackUrl') is not None:
            self.callback_url = m.get('callbackUrl')
        if m.get('cardBizId') is not None:
            self.card_biz_id = m.get('cardBizId')
        if m.get('cardData') is not None:
            self.card_data = m.get('cardData')
        if m.get('cardTemplateId') is not None:
            self.card_template_id = m.get('cardTemplateId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('pullStrategy') is not None:
            self.pull_strategy = m.get('pullStrategy')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        if m.get('sendOptions') is not None:
            temp_model = SendRobotInteractiveCardRequestSendOptions()
            self.send_options = temp_model.from_map(m['sendOptions'])
        if m.get('singleChatReceiver') is not None:
            self.single_chat_receiver = m.get('singleChatReceiver')
        if m.get('unionIdPrivateDataMap') is not None:
            self.union_id_private_data_map = m.get('unionIdPrivateDataMap')
        if m.get('userIdPrivateDataMap') is not None:
            self.user_id_private_data_map = m.get('userIdPrivateDataMap')
        return self


class SendRobotInteractiveCardResponseBody(TeaModel):
    def __init__(
        self,
        process_query_key: str = None,
    ):
        self.process_query_key = process_query_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.process_query_key is not None:
            result['processQueryKey'] = self.process_query_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('processQueryKey') is not None:
            self.process_query_key = m.get('processQueryKey')
        return self


class SendRobotInteractiveCardResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SendRobotInteractiveCardResponseBody = None,
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
            temp_model = SendRobotInteractiveCardResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SendRobotMessageHeaders(TeaModel):
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


class SendRobotMessageRequest(TeaModel):
    def __init__(
        self,
        at_all: bool = None,
        at_app_user_id: str = None,
        at_ding_user_id: str = None,
        msg_content: str = None,
        msg_type: str = None,
        open_conversation_ids: List[str] = None,
        robot_code: str = None,
    ):
        self.at_all = at_all
        self.at_app_user_id = at_app_user_id
        self.at_ding_user_id = at_ding_user_id
        # This parameter is required.
        self.msg_content = msg_content
        # This parameter is required.
        self.msg_type = msg_type
        # This parameter is required.
        self.open_conversation_ids = open_conversation_ids
        self.robot_code = robot_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.at_all is not None:
            result['atAll'] = self.at_all
        if self.at_app_user_id is not None:
            result['atAppUserId'] = self.at_app_user_id
        if self.at_ding_user_id is not None:
            result['atDingUserId'] = self.at_ding_user_id
        if self.msg_content is not None:
            result['msgContent'] = self.msg_content
        if self.msg_type is not None:
            result['msgType'] = self.msg_type
        if self.open_conversation_ids is not None:
            result['openConversationIds'] = self.open_conversation_ids
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('atAll') is not None:
            self.at_all = m.get('atAll')
        if m.get('atAppUserId') is not None:
            self.at_app_user_id = m.get('atAppUserId')
        if m.get('atDingUserId') is not None:
            self.at_ding_user_id = m.get('atDingUserId')
        if m.get('msgContent') is not None:
            self.msg_content = m.get('msgContent')
        if m.get('msgType') is not None:
            self.msg_type = m.get('msgType')
        if m.get('openConversationIds') is not None:
            self.open_conversation_ids = m.get('openConversationIds')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        return self


class SendRobotMessageResponseBody(TeaModel):
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


class SendRobotMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SendRobotMessageResponseBody = None,
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
            temp_model = SendRobotMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SendTemplateInteractiveCardHeaders(TeaModel):
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


class SendTemplateInteractiveCardRequestSendOptions(TeaModel):
    def __init__(
        self,
        at_all: bool = None,
        at_user_list_json: str = None,
        card_property_json: str = None,
        receiver_list_json: str = None,
    ):
        self.at_all = at_all
        self.at_user_list_json = at_user_list_json
        self.card_property_json = card_property_json
        self.receiver_list_json = receiver_list_json

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.at_all is not None:
            result['atAll'] = self.at_all
        if self.at_user_list_json is not None:
            result['atUserListJson'] = self.at_user_list_json
        if self.card_property_json is not None:
            result['cardPropertyJson'] = self.card_property_json
        if self.receiver_list_json is not None:
            result['receiverListJson'] = self.receiver_list_json
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('atAll') is not None:
            self.at_all = m.get('atAll')
        if m.get('atUserListJson') is not None:
            self.at_user_list_json = m.get('atUserListJson')
        if m.get('cardPropertyJson') is not None:
            self.card_property_json = m.get('cardPropertyJson')
        if m.get('receiverListJson') is not None:
            self.receiver_list_json = m.get('receiverListJson')
        return self


class SendTemplateInteractiveCardRequest(TeaModel):
    def __init__(
        self,
        callback_url: str = None,
        card_data: str = None,
        card_template_id: str = None,
        open_conversation_id: str = None,
        out_track_id: str = None,
        robot_code: str = None,
        send_options: SendTemplateInteractiveCardRequestSendOptions = None,
        single_chat_receiver: str = None,
    ):
        self.callback_url = callback_url
        # This parameter is required.
        self.card_data = card_data
        # This parameter is required.
        self.card_template_id = card_template_id
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.out_track_id = out_track_id
        # This parameter is required.
        self.robot_code = robot_code
        self.send_options = send_options
        self.single_chat_receiver = single_chat_receiver

    def validate(self):
        if self.send_options:
            self.send_options.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.callback_url is not None:
            result['callbackUrl'] = self.callback_url
        if self.card_data is not None:
            result['cardData'] = self.card_data
        if self.card_template_id is not None:
            result['cardTemplateId'] = self.card_template_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.out_track_id is not None:
            result['outTrackId'] = self.out_track_id
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        if self.send_options is not None:
            result['sendOptions'] = self.send_options.to_map()
        if self.single_chat_receiver is not None:
            result['singleChatReceiver'] = self.single_chat_receiver
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('callbackUrl') is not None:
            self.callback_url = m.get('callbackUrl')
        if m.get('cardData') is not None:
            self.card_data = m.get('cardData')
        if m.get('cardTemplateId') is not None:
            self.card_template_id = m.get('cardTemplateId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('outTrackId') is not None:
            self.out_track_id = m.get('outTrackId')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        if m.get('sendOptions') is not None:
            temp_model = SendTemplateInteractiveCardRequestSendOptions()
            self.send_options = temp_model.from_map(m['sendOptions'])
        if m.get('singleChatReceiver') is not None:
            self.single_chat_receiver = m.get('singleChatReceiver')
        return self


class SendTemplateInteractiveCardResponseBody(TeaModel):
    def __init__(
        self,
        process_query_key: str = None,
    ):
        self.process_query_key = process_query_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.process_query_key is not None:
            result['processQueryKey'] = self.process_query_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('processQueryKey') is not None:
            self.process_query_key = m.get('processQueryKey')
        return self


class SendTemplateInteractiveCardResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SendTemplateInteractiveCardResponseBody = None,
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
            temp_model = SendTemplateInteractiveCardResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SetRightPanelHeaders(TeaModel):
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


class SetRightPanelRequestWebWndParams(TeaModel):
    def __init__(
        self,
        target_url: str = None,
    ):
        # This parameter is required.
        self.target_url = target_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.target_url is not None:
            result['targetURL'] = self.target_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('targetURL') is not None:
            self.target_url = m.get('targetURL')
        return self


class SetRightPanelRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        right_panel_close_permitted: bool = None,
        right_panel_open_status: int = None,
        title: str = None,
        web_wnd_params: SetRightPanelRequestWebWndParams = None,
        width: int = None,
    ):
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.right_panel_close_permitted = right_panel_close_permitted
        # This parameter is required.
        self.right_panel_open_status = right_panel_open_status
        # This parameter is required.
        self.title = title
        # This parameter is required.
        self.web_wnd_params = web_wnd_params
        # This parameter is required.
        self.width = width

    def validate(self):
        if self.web_wnd_params:
            self.web_wnd_params.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.right_panel_close_permitted is not None:
            result['rightPanelClosePermitted'] = self.right_panel_close_permitted
        if self.right_panel_open_status is not None:
            result['rightPanelOpenStatus'] = self.right_panel_open_status
        if self.title is not None:
            result['title'] = self.title
        if self.web_wnd_params is not None:
            result['webWndParams'] = self.web_wnd_params.to_map()
        if self.width is not None:
            result['width'] = self.width
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('rightPanelClosePermitted') is not None:
            self.right_panel_close_permitted = m.get('rightPanelClosePermitted')
        if m.get('rightPanelOpenStatus') is not None:
            self.right_panel_open_status = m.get('rightPanelOpenStatus')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('webWndParams') is not None:
            temp_model = SetRightPanelRequestWebWndParams()
            self.web_wnd_params = temp_model.from_map(m['webWndParams'])
        if m.get('width') is not None:
            self.width = m.get('width')
        return self


class SetRightPanelResponseBody(TeaModel):
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


class SetRightPanelResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SetRightPanelResponseBody = None,
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
            temp_model = SetRightPanelResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class TopboxCloseHeaders(TeaModel):
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


class TopboxCloseRequest(TeaModel):
    def __init__(
        self,
        conversation_type: int = None,
        cool_app_code: str = None,
        open_conversation_id: str = None,
        out_track_id: str = None,
        receiver_user_id_list: List[str] = None,
        robot_code: str = None,
    ):
        self.conversation_type = conversation_type
        self.cool_app_code = cool_app_code
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.out_track_id = out_track_id
        self.receiver_user_id_list = receiver_user_id_list
        self.robot_code = robot_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conversation_type is not None:
            result['conversationType'] = self.conversation_type
        if self.cool_app_code is not None:
            result['coolAppCode'] = self.cool_app_code
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.out_track_id is not None:
            result['outTrackId'] = self.out_track_id
        if self.receiver_user_id_list is not None:
            result['receiverUserIdList'] = self.receiver_user_id_list
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conversationType') is not None:
            self.conversation_type = m.get('conversationType')
        if m.get('coolAppCode') is not None:
            self.cool_app_code = m.get('coolAppCode')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('outTrackId') is not None:
            self.out_track_id = m.get('outTrackId')
        if m.get('receiverUserIdList') is not None:
            self.receiver_user_id_list = m.get('receiverUserIdList')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        return self


class TopboxCloseResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
    ):
        self.headers = headers
        self.status_code = status_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        return self


class TopboxOpenHeaders(TeaModel):
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


class TopboxOpenRequest(TeaModel):
    def __init__(
        self,
        conversation_type: int = None,
        cool_app_code: str = None,
        expired_time: int = None,
        open_conversation_id: str = None,
        out_track_id: str = None,
        platforms: str = None,
        receiver_user_id_list: List[str] = None,
        robot_code: str = None,
    ):
        self.conversation_type = conversation_type
        self.cool_app_code = cool_app_code
        self.expired_time = expired_time
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.out_track_id = out_track_id
        self.platforms = platforms
        self.receiver_user_id_list = receiver_user_id_list
        self.robot_code = robot_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conversation_type is not None:
            result['conversationType'] = self.conversation_type
        if self.cool_app_code is not None:
            result['coolAppCode'] = self.cool_app_code
        if self.expired_time is not None:
            result['expiredTime'] = self.expired_time
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.out_track_id is not None:
            result['outTrackId'] = self.out_track_id
        if self.platforms is not None:
            result['platforms'] = self.platforms
        if self.receiver_user_id_list is not None:
            result['receiverUserIdList'] = self.receiver_user_id_list
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conversationType') is not None:
            self.conversation_type = m.get('conversationType')
        if m.get('coolAppCode') is not None:
            self.cool_app_code = m.get('coolAppCode')
        if m.get('expiredTime') is not None:
            self.expired_time = m.get('expiredTime')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('outTrackId') is not None:
            self.out_track_id = m.get('outTrackId')
        if m.get('platforms') is not None:
            self.platforms = m.get('platforms')
        if m.get('receiverUserIdList') is not None:
            self.receiver_user_id_list = m.get('receiverUserIdList')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        return self


class TopboxOpenResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
    ):
        self.headers = headers
        self.status_code = status_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        return self


class UpdateGroupAvatarHeaders(TeaModel):
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


class UpdateGroupAvatarRequest(TeaModel):
    def __init__(
        self,
        group_avatar: str = None,
        open_conversation_id: str = None,
    ):
        # This parameter is required.
        self.group_avatar = group_avatar
        # This parameter is required.
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_avatar is not None:
            result['groupAvatar'] = self.group_avatar
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupAvatar') is not None:
            self.group_avatar = m.get('groupAvatar')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class UpdateGroupAvatarResponseBody(TeaModel):
    def __init__(
        self,
        new_group_avatar: str = None,
    ):
        # This parameter is required.
        self.new_group_avatar = new_group_avatar

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.new_group_avatar is not None:
            result['newGroupAvatar'] = self.new_group_avatar
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('newGroupAvatar') is not None:
            self.new_group_avatar = m.get('newGroupAvatar')
        return self


class UpdateGroupAvatarResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateGroupAvatarResponseBody = None,
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
            temp_model = UpdateGroupAvatarResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateGroupNameHeaders(TeaModel):
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


class UpdateGroupNameRequest(TeaModel):
    def __init__(
        self,
        group_name: str = None,
        open_conversation_id: str = None,
    ):
        # This parameter is required.
        self.group_name = group_name
        # This parameter is required.
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class UpdateGroupNameResponseBody(TeaModel):
    def __init__(
        self,
        new_group_name: str = None,
    ):
        self.new_group_name = new_group_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.new_group_name is not None:
            result['newGroupName'] = self.new_group_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('newGroupName') is not None:
            self.new_group_name = m.get('newGroupName')
        return self


class UpdateGroupNameResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateGroupNameResponseBody = None,
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
            temp_model = UpdateGroupNameResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateGroupPermissionHeaders(TeaModel):
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


class UpdateGroupPermissionRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        permission_group: str = None,
        status: str = None,
    ):
        self.open_conversation_id = open_conversation_id
        self.permission_group = permission_group
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.permission_group is not None:
            result['permissionGroup'] = self.permission_group
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('permissionGroup') is not None:
            self.permission_group = m.get('permissionGroup')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class UpdateGroupPermissionResponseBody(TeaModel):
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


class UpdateGroupPermissionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateGroupPermissionResponseBody = None,
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
            temp_model = UpdateGroupPermissionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateGroupSubAdminHeaders(TeaModel):
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


class UpdateGroupSubAdminRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        role: int = None,
        user_ids: List[str] = None,
    ):
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.role = role
        # This parameter is required.
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.role is not None:
            result['role'] = self.role
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('role') is not None:
            self.role = m.get('role')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class UpdateGroupSubAdminResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        # This parameter is required.
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


class UpdateGroupSubAdminResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateGroupSubAdminResponseBody = None,
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
            temp_model = UpdateGroupSubAdminResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateInteractiveCardHeaders(TeaModel):
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


class UpdateInteractiveCardRequestCardData(TeaModel):
    def __init__(
        self,
        card_media_id_param_map: Dict[str, str] = None,
        card_param_map: Dict[str, str] = None,
    ):
        self.card_media_id_param_map = card_media_id_param_map
        self.card_param_map = card_param_map

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.card_media_id_param_map is not None:
            result['cardMediaIdParamMap'] = self.card_media_id_param_map
        if self.card_param_map is not None:
            result['cardParamMap'] = self.card_param_map
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cardMediaIdParamMap') is not None:
            self.card_media_id_param_map = m.get('cardMediaIdParamMap')
        if m.get('cardParamMap') is not None:
            self.card_param_map = m.get('cardParamMap')
        return self


class UpdateInteractiveCardRequestCardOptions(TeaModel):
    def __init__(
        self,
        update_card_data_by_key: bool = None,
        update_private_data_by_key: bool = None,
    ):
        self.update_card_data_by_key = update_card_data_by_key
        self.update_private_data_by_key = update_private_data_by_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.update_card_data_by_key is not None:
            result['updateCardDataByKey'] = self.update_card_data_by_key
        if self.update_private_data_by_key is not None:
            result['updatePrivateDataByKey'] = self.update_private_data_by_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('updateCardDataByKey') is not None:
            self.update_card_data_by_key = m.get('updateCardDataByKey')
        if m.get('updatePrivateDataByKey') is not None:
            self.update_private_data_by_key = m.get('updatePrivateDataByKey')
        return self


class UpdateInteractiveCardRequest(TeaModel):
    def __init__(
        self,
        card_data: UpdateInteractiveCardRequestCardData = None,
        card_options: UpdateInteractiveCardRequestCardOptions = None,
        out_track_id: str = None,
        private_data: Dict[str, PrivateDataValue] = None,
        user_id_type: int = None,
    ):
        self.card_data = card_data
        self.card_options = card_options
        self.out_track_id = out_track_id
        self.private_data = private_data
        self.user_id_type = user_id_type

    def validate(self):
        if self.card_data:
            self.card_data.validate()
        if self.card_options:
            self.card_options.validate()
        if self.private_data:
            for v in self.private_data.values():
                if v:
                    v.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.card_data is not None:
            result['cardData'] = self.card_data.to_map()
        if self.card_options is not None:
            result['cardOptions'] = self.card_options.to_map()
        if self.out_track_id is not None:
            result['outTrackId'] = self.out_track_id
        result['privateData'] = {}
        if self.private_data is not None:
            for k, v in self.private_data.items():
                result['privateData'][k] = v.to_map()
        if self.user_id_type is not None:
            result['userIdType'] = self.user_id_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cardData') is not None:
            temp_model = UpdateInteractiveCardRequestCardData()
            self.card_data = temp_model.from_map(m['cardData'])
        if m.get('cardOptions') is not None:
            temp_model = UpdateInteractiveCardRequestCardOptions()
            self.card_options = temp_model.from_map(m['cardOptions'])
        if m.get('outTrackId') is not None:
            self.out_track_id = m.get('outTrackId')
        self.private_data = {}
        if m.get('privateData') is not None:
            for k, v in m.get('privateData').items():
                temp_model = PrivateDataValue()
                self.private_data[k] = temp_model.from_map(v)
        if m.get('userIdType') is not None:
            self.user_id_type = m.get('userIdType')
        return self


class UpdateInteractiveCardResponseBody(TeaModel):
    def __init__(
        self,
        success: str = None,
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


class UpdateInteractiveCardResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateInteractiveCardResponseBody = None,
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
            temp_model = UpdateInteractiveCardResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateMemberBanWordsHeaders(TeaModel):
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


class UpdateMemberBanWordsRequest(TeaModel):
    def __init__(
        self,
        mute_duration: int = None,
        mute_status: int = None,
        open_conversation_id: str = None,
        user_id_list: List[str] = None,
    ):
        # This parameter is required.
        self.mute_duration = mute_duration
        # This parameter is required.
        self.mute_status = mute_status
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.user_id_list = user_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.mute_duration is not None:
            result['muteDuration'] = self.mute_duration
        if self.mute_status is not None:
            result['muteStatus'] = self.mute_status
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.user_id_list is not None:
            result['userIdList'] = self.user_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('muteDuration') is not None:
            self.mute_duration = m.get('muteDuration')
        if m.get('muteStatus') is not None:
            self.mute_status = m.get('muteStatus')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('userIdList') is not None:
            self.user_id_list = m.get('userIdList')
        return self


class UpdateMemberBanWordsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
    ):
        self.headers = headers
        self.status_code = status_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.status_code is not None:
            result['statusCode'] = self.status_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        return self


class UpdateMemberGroupNickHeaders(TeaModel):
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


class UpdateMemberGroupNickRequest(TeaModel):
    def __init__(
        self,
        group_nick: str = None,
        open_conversation_id: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.group_nick = group_nick
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_nick is not None:
            result['groupNick'] = self.group_nick
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupNick') is not None:
            self.group_nick = m.get('groupNick')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class UpdateMemberGroupNickResponseBody(TeaModel):
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


class UpdateMemberGroupNickResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateMemberGroupNickResponseBody = None,
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
            temp_model = UpdateMemberGroupNickResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateRobotInOrgHeaders(TeaModel):
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


class UpdateRobotInOrgRequest(TeaModel):
    def __init__(
        self,
        brief: str = None,
        description: str = None,
        icon: str = None,
        name: str = None,
        outgoing_token: str = None,
        outgoing_url: str = None,
        preview_media_id: str = None,
        robot_code: str = None,
    ):
        self.brief = brief
        self.description = description
        self.icon = icon
        self.name = name
        self.outgoing_token = outgoing_token
        self.outgoing_url = outgoing_url
        self.preview_media_id = preview_media_id
        # This parameter is required.
        self.robot_code = robot_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.brief is not None:
            result['brief'] = self.brief
        if self.description is not None:
            result['description'] = self.description
        if self.icon is not None:
            result['icon'] = self.icon
        if self.name is not None:
            result['name'] = self.name
        if self.outgoing_token is not None:
            result['outgoingToken'] = self.outgoing_token
        if self.outgoing_url is not None:
            result['outgoingUrl'] = self.outgoing_url
        if self.preview_media_id is not None:
            result['previewMediaId'] = self.preview_media_id
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('brief') is not None:
            self.brief = m.get('brief')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('outgoingToken') is not None:
            self.outgoing_token = m.get('outgoingToken')
        if m.get('outgoingUrl') is not None:
            self.outgoing_url = m.get('outgoingUrl')
        if m.get('previewMediaId') is not None:
            self.preview_media_id = m.get('previewMediaId')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        return self


class UpdateRobotInOrgResponseBody(TeaModel):
    def __init__(
        self,
        robot_code: str = None,
    ):
        self.robot_code = robot_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        return self


class UpdateRobotInOrgResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateRobotInOrgResponseBody = None,
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
            temp_model = UpdateRobotInOrgResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateRobotInteractiveCardHeaders(TeaModel):
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


class UpdateRobotInteractiveCardRequestUpdateOptions(TeaModel):
    def __init__(
        self,
        update_card_data_by_key: bool = None,
        update_private_data_by_key: bool = None,
    ):
        self.update_card_data_by_key = update_card_data_by_key
        self.update_private_data_by_key = update_private_data_by_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.update_card_data_by_key is not None:
            result['updateCardDataByKey'] = self.update_card_data_by_key
        if self.update_private_data_by_key is not None:
            result['updatePrivateDataByKey'] = self.update_private_data_by_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('updateCardDataByKey') is not None:
            self.update_card_data_by_key = m.get('updateCardDataByKey')
        if m.get('updatePrivateDataByKey') is not None:
            self.update_private_data_by_key = m.get('updatePrivateDataByKey')
        return self


class UpdateRobotInteractiveCardRequest(TeaModel):
    def __init__(
        self,
        card_biz_id: str = None,
        card_data: str = None,
        union_id_private_data_map: str = None,
        update_options: UpdateRobotInteractiveCardRequestUpdateOptions = None,
        user_id_private_data_map: str = None,
    ):
        # This parameter is required.
        self.card_biz_id = card_biz_id
        self.card_data = card_data
        self.union_id_private_data_map = union_id_private_data_map
        self.update_options = update_options
        self.user_id_private_data_map = user_id_private_data_map

    def validate(self):
        if self.update_options:
            self.update_options.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.card_biz_id is not None:
            result['cardBizId'] = self.card_biz_id
        if self.card_data is not None:
            result['cardData'] = self.card_data
        if self.union_id_private_data_map is not None:
            result['unionIdPrivateDataMap'] = self.union_id_private_data_map
        if self.update_options is not None:
            result['updateOptions'] = self.update_options.to_map()
        if self.user_id_private_data_map is not None:
            result['userIdPrivateDataMap'] = self.user_id_private_data_map
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cardBizId') is not None:
            self.card_biz_id = m.get('cardBizId')
        if m.get('cardData') is not None:
            self.card_data = m.get('cardData')
        if m.get('unionIdPrivateDataMap') is not None:
            self.union_id_private_data_map = m.get('unionIdPrivateDataMap')
        if m.get('updateOptions') is not None:
            temp_model = UpdateRobotInteractiveCardRequestUpdateOptions()
            self.update_options = temp_model.from_map(m['updateOptions'])
        if m.get('userIdPrivateDataMap') is not None:
            self.user_id_private_data_map = m.get('userIdPrivateDataMap')
        return self


class UpdateRobotInteractiveCardResponseBody(TeaModel):
    def __init__(
        self,
        process_query_key: str = None,
    ):
        self.process_query_key = process_query_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.process_query_key is not None:
            result['processQueryKey'] = self.process_query_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('processQueryKey') is not None:
            self.process_query_key = m.get('processQueryKey')
        return self


class UpdateRobotInteractiveCardResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateRobotInteractiveCardResponseBody = None,
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
            temp_model = UpdateRobotInteractiveCardResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateSceneGroupTemplateMessageOpenStatusHeaders(TeaModel):
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


class UpdateSceneGroupTemplateMessageOpenStatusRequest(TeaModel):
    def __init__(
        self,
        status: int = None,
        template_id_list: List[str] = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.status = status
        # This parameter is required.
        self.template_id_list = template_id_list
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.status is not None:
            result['status'] = self.status
        if self.template_id_list is not None:
            result['templateIdList'] = self.template_id_list
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('templateIdList') is not None:
            self.template_id_list = m.get('templateIdList')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class UpdateSceneGroupTemplateMessageOpenStatusResponseBody(TeaModel):
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


class UpdateSceneGroupTemplateMessageOpenStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateSceneGroupTemplateMessageOpenStatusResponseBody = None,
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
            temp_model = UpdateSceneGroupTemplateMessageOpenStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateTheGroupRolesOfGroupMemberHeaders(TeaModel):
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


class UpdateTheGroupRolesOfGroupMemberRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        open_role_ids: List[str] = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        self.open_role_ids = open_role_ids
        # This parameter is required.
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
        if self.open_role_ids is not None:
            result['openRoleIds'] = self.open_role_ids
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('openRoleIds') is not None:
            self.open_role_ids = m.get('openRoleIds')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class UpdateTheGroupRolesOfGroupMemberResponseBody(TeaModel):
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


class UpdateTheGroupRolesOfGroupMemberResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateTheGroupRolesOfGroupMemberResponseBody = None,
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
            temp_model = UpdateTheGroupRolesOfGroupMemberResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateUnfurlingRegisterHeaders(TeaModel):
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


class UpdateUnfurlingRegisterRequest(TeaModel):
    def __init__(
        self,
        api_secret: str = None,
        app_id: str = None,
        callback_url: str = None,
        card_template_id: str = None,
        domain: str = None,
        id: int = None,
        path: str = None,
        rule_desc: str = None,
        rule_match_type: int = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.api_secret = api_secret
        # This parameter is required.
        self.app_id = app_id
        # This parameter is required.
        self.callback_url = callback_url
        # This parameter is required.
        self.card_template_id = card_template_id
        # This parameter is required.
        self.domain = domain
        # This parameter is required.
        self.id = id
        # This parameter is required.
        self.path = path
        self.rule_desc = rule_desc
        # This parameter is required.
        self.rule_match_type = rule_match_type
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.api_secret is not None:
            result['apiSecret'] = self.api_secret
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.callback_url is not None:
            result['callbackUrl'] = self.callback_url
        if self.card_template_id is not None:
            result['cardTemplateId'] = self.card_template_id
        if self.domain is not None:
            result['domain'] = self.domain
        if self.id is not None:
            result['id'] = self.id
        if self.path is not None:
            result['path'] = self.path
        if self.rule_desc is not None:
            result['ruleDesc'] = self.rule_desc
        if self.rule_match_type is not None:
            result['ruleMatchType'] = self.rule_match_type
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('apiSecret') is not None:
            self.api_secret = m.get('apiSecret')
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('callbackUrl') is not None:
            self.callback_url = m.get('callbackUrl')
        if m.get('cardTemplateId') is not None:
            self.card_template_id = m.get('cardTemplateId')
        if m.get('domain') is not None:
            self.domain = m.get('domain')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('path') is not None:
            self.path = m.get('path')
        if m.get('ruleDesc') is not None:
            self.rule_desc = m.get('ruleDesc')
        if m.get('ruleMatchType') is not None:
            self.rule_match_type = m.get('ruleMatchType')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class UpdateUnfurlingRegisterResponseBody(TeaModel):
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


class UpdateUnfurlingRegisterResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateUnfurlingRegisterResponseBody = None,
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
            temp_model = UpdateUnfurlingRegisterResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateUnfurlingRegisterStatusHeaders(TeaModel):
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


class UpdateUnfurlingRegisterStatusRequest(TeaModel):
    def __init__(
        self,
        app_id: str = None,
        id: int = None,
        status: int = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.app_id = app_id
        # This parameter is required.
        self.id = id
        # This parameter is required.
        self.status = status
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.id is not None:
            result['id'] = self.id
        if self.status is not None:
            result['status'] = self.status
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class UpdateUnfurlingRegisterStatusResponseBody(TeaModel):
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


class UpdateUnfurlingRegisterStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateUnfurlingRegisterStatusResponseBody = None,
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
            temp_model = UpdateUnfurlingRegisterStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AddGroupMemberHeaders(TeaModel):
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


class AddGroupMemberRequest(TeaModel):
    def __init__(
        self,
        app_user_ids: List[str] = None,
        open_conversation_id: str = None,
        operator_id: str = None,
        user_ids: List[str] = None,
    ):
        self.app_user_ids = app_user_ids
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.operator_id = operator_id
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_user_ids is not None:
            result['appUserIds'] = self.app_user_ids
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUserIds') is not None:
            self.app_user_ids = m.get('appUserIds')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class AddGroupMemberResponseBody(TeaModel):
    def __init__(
        self,
        app_user_ids: List[str] = None,
        user_ids: List[str] = None,
    ):
        # This parameter is required.
        self.app_user_ids = app_user_ids
        # This parameter is required.
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_user_ids is not None:
            result['appUserIds'] = self.app_user_ids
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUserIds') is not None:
            self.app_user_ids = m.get('appUserIds')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class AddGroupMemberResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AddGroupMemberResponseBody = None,
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
            temp_model = AddGroupMemberResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RemoveGroupMemberHeaders(TeaModel):
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


class RemoveGroupMemberRequest(TeaModel):
    def __init__(
        self,
        app_user_ids: List[str] = None,
        open_conversation_id: str = None,
        operator_id: str = None,
        user_ids: List[str] = None,
    ):
        self.app_user_ids = app_user_ids
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.operator_id = operator_id
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_user_ids is not None:
            result['appUserIds'] = self.app_user_ids
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.operator_id is not None:
            result['operatorId'] = self.operator_id
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUserIds') is not None:
            self.app_user_ids = m.get('appUserIds')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('operatorId') is not None:
            self.operator_id = m.get('operatorId')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class RemoveGroupMemberResponseBody(TeaModel):
    def __init__(
        self,
        message: str = None,
    ):
        # This parameter is required.
        self.message = message

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.message is not None:
            result['message'] = self.message
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('message') is not None:
            self.message = m.get('message')
        return self


class RemoveGroupMemberResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RemoveGroupMemberResponseBody = None,
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
            temp_model = RemoveGroupMemberResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SendDingMessageHeaders(TeaModel):
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


class SendDingMessageRequest(TeaModel):
    def __init__(
        self,
        code: str = None,
        message: str = None,
        message_type: str = None,
        open_conversation_id: str = None,
        receiver_id: str = None,
        sender_id: str = None,
    ):
        # This parameter is required.
        self.code = code
        # This parameter is required.
        self.message = message
        # This parameter is required.
        self.message_type = message_type
        self.open_conversation_id = open_conversation_id
        self.receiver_id = receiver_id
        # This parameter is required.
        self.sender_id = sender_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.message is not None:
            result['message'] = self.message
        if self.message_type is not None:
            result['messageType'] = self.message_type
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.receiver_id is not None:
            result['receiverId'] = self.receiver_id
        if self.sender_id is not None:
            result['senderId'] = self.sender_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('message') is not None:
            self.message = m.get('message')
        if m.get('messageType') is not None:
            self.message_type = m.get('messageType')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('receiverId') is not None:
            self.receiver_id = m.get('receiverId')
        if m.get('senderId') is not None:
            self.sender_id = m.get('senderId')
        return self


class SendDingMessageResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        # This parameter is required.
        self.request_id = request_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class SendDingMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SendDingMessageResponseBody = None,
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
            temp_model = SendDingMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SendMessageHeaders(TeaModel):
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


class SendMessageRequest(TeaModel):
    def __init__(
        self,
        message: str = None,
        message_type: str = None,
        open_conversation_id: str = None,
        receiver_id: str = None,
        sender_id: str = None,
        source_infos: Dict[str, Any] = None,
    ):
        # This parameter is required.
        self.message = message
        # This parameter is required.
        self.message_type = message_type
        self.open_conversation_id = open_conversation_id
        self.receiver_id = receiver_id
        # This parameter is required.
        self.sender_id = sender_id
        self.source_infos = source_infos

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.message is not None:
            result['message'] = self.message
        if self.message_type is not None:
            result['messageType'] = self.message_type
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.receiver_id is not None:
            result['receiverId'] = self.receiver_id
        if self.sender_id is not None:
            result['senderId'] = self.sender_id
        if self.source_infos is not None:
            result['sourceInfos'] = self.source_infos
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('message') is not None:
            self.message = m.get('message')
        if m.get('messageType') is not None:
            self.message_type = m.get('messageType')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('receiverId') is not None:
            self.receiver_id = m.get('receiverId')
        if m.get('senderId') is not None:
            self.sender_id = m.get('senderId')
        if m.get('sourceInfos') is not None:
            self.source_infos = m.get('sourceInfos')
        return self


class SendMessageResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        # This parameter is required.
        self.request_id = request_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class SendMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SendMessageResponseBody = None,
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
            temp_model = SendMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


