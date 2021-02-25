# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


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
        card_param_map: Dict[str, str] = None,
        card_media_id_param_map: Dict[str, str] = None,
    ):
        # 卡片模板内容替换参数-普通文本类型
        self.card_param_map = card_param_map
        # 卡片模板内容替换参数-多媒体类型
        self.card_media_id_param_map = card_media_id_param_map

    def validate(self):
        pass

    def to_map(self):
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


class PrivateDataValue(TeaModel):
    def __init__(
        self,
        card_param_map: Dict[str, str] = None,
        card_media_id_param_map: Dict[str, str] = None,
    ):
        # 卡片模板内容替换参数-普通文本类型
        self.card_param_map = card_param_map
        # 卡片模板内容替换参数-多媒体类型
        self.card_media_id_param_map = card_media_id_param_map

    def validate(self):
        pass

    def to_map(self):
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


class SendInteractiveCardRequest(TeaModel):
    def __init__(
        self,
        ding_isv_org_id: int = None,
        card_template_id: str = None,
        open_conversation_id: str = None,
        receiver_user_id_list: List[str] = None,
        ding_token_grant_type: int = None,
        out_track_id: str = None,
        ding_suite_key: str = None,
        robot_code: str = None,
        ding_org_id: int = None,
        conversation_type: int = None,
        callback_route_key: str = None,
        card_data: SendInteractiveCardRequestCardData = None,
        private_data: Dict[str, PrivateDataValue] = None,
        ding_oauth_app_id: int = None,
        chat_bot_id: str = None,
        user_id_type: int = None,
    ):
        self.ding_isv_org_id = ding_isv_org_id
        # 卡片模板ID
        self.card_template_id = card_template_id
        # 接收卡片的群的openConversationId
        self.open_conversation_id = open_conversation_id
        # 接收人userId列表
        self.receiver_user_id_list = receiver_user_id_list
        self.ding_token_grant_type = ding_token_grant_type
        # 唯一标识一张卡片的外部ID（卡片幂等ID，可用于更新或重复发送同一卡片到多个群会话）
        self.out_track_id = out_track_id
        self.ding_suite_key = ding_suite_key
        # 【robotCode & chatBotId二选一必填】机器人编码（群模板机器人）
        self.robot_code = robot_code
        self.ding_org_id = ding_org_id
        # 发送的会话类型：单聊-0, 群聊-1（单聊时：openConversationId不用填写；receiverUserIdList填写有且一个员工号）
        self.conversation_type = conversation_type
        # 可控制卡片回调时的路由Key，用于指定特定的callbackUrl【可空：不填写默认用企业的回调地址】
        self.callback_route_key = callback_route_key
        self.card_data = card_data
        # 指定用户可见的按钮列表（key：用户userId；value：用户数据）
        self.private_data = private_data
        self.ding_oauth_app_id = ding_oauth_app_id
        # 【robotCode & chatBotId二选一必填】机器人ID（企业机器人）
        self.chat_bot_id = chat_bot_id
        # 用户ID类型：1：staffId模式【默认】；2：unionId模式；对应receiverUserIdList、privateData字段关于用户id的值填写方式
        self.user_id_type = user_id_type

    def validate(self):
        if self.card_data:
            self.card_data.validate()
        if self.private_data:
            for v in self.private_data.values():
                if v:
                    v.validate()

    def to_map(self):
        result = dict()
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.card_template_id is not None:
            result['cardTemplateId'] = self.card_template_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.receiver_user_id_list is not None:
            result['receiverUserIdList'] = self.receiver_user_id_list
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.out_track_id is not None:
            result['outTrackId'] = self.out_track_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.conversation_type is not None:
            result['conversationType'] = self.conversation_type
        if self.callback_route_key is not None:
            result['callbackRouteKey'] = self.callback_route_key
        if self.card_data is not None:
            result['cardData'] = self.card_data.to_map()
        result['privateData'] = {}
        if self.private_data is not None:
            for k, v in self.private_data.items():
                result['privateData'][k] = v.to_map()
        if self.ding_oauth_app_id is not None:
            result['dingOauthAppId'] = self.ding_oauth_app_id
        if self.chat_bot_id is not None:
            result['chatBotId'] = self.chat_bot_id
        if self.user_id_type is not None:
            result['userIdType'] = self.user_id_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('cardTemplateId') is not None:
            self.card_template_id = m.get('cardTemplateId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('receiverUserIdList') is not None:
            self.receiver_user_id_list = m.get('receiverUserIdList')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('outTrackId') is not None:
            self.out_track_id = m.get('outTrackId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('conversationType') is not None:
            self.conversation_type = m.get('conversationType')
        if m.get('callbackRouteKey') is not None:
            self.callback_route_key = m.get('callbackRouteKey')
        if m.get('cardData') is not None:
            temp_model = SendInteractiveCardRequestCardData()
            self.card_data = temp_model.from_map(m['cardData'])
        self.private_data = {}
        if m.get('privateData') is not None:
            for k, v in m.get('privateData').items():
                temp_model = PrivateDataValue()
                self.private_data[k] = temp_model.from_map(v)
        if m.get('dingOauthAppId') is not None:
            self.ding_oauth_app_id = m.get('dingOauthAppId')
        if m.get('chatBotId') is not None:
            self.chat_bot_id = m.get('chatBotId')
        if m.get('userIdType') is not None:
            self.user_id_type = m.get('userIdType')
        return self


class SendInteractiveCardResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        # 结果
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        result = dict()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class SendInteractiveCardResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SendInteractiveCardResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
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
            temp_model = SendInteractiveCardResponseBody()
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
        card_param_map: Dict[str, str] = None,
        card_media_id_param_map: Dict[str, str] = None,
    ):
        self.card_param_map = card_param_map
        self.card_media_id_param_map = card_media_id_param_map

    def validate(self):
        pass

    def to_map(self):
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


class UpdateInteractiveCardRequest(TeaModel):
    def __init__(
        self,
        out_track_id: str = None,
        card_data: UpdateInteractiveCardRequestCardData = None,
        private_data: Dict[str, PrivateDataValue] = None,
        ding_token_grant_type: int = None,
        ding_org_id: int = None,
        ding_isv_org_id: int = None,
        ding_suite_key: str = None,
        ding_oauth_app_id: int = None,
        user_id_type: int = None,
    ):
        # 唯一标识一张卡片的外部ID
        self.out_track_id = out_track_id
        self.card_data = card_data
        self.private_data = private_data
        self.ding_token_grant_type = ding_token_grant_type
        self.ding_org_id = ding_org_id
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_suite_key = ding_suite_key
        self.ding_oauth_app_id = ding_oauth_app_id
        # 用户ID类型：1：staffId模式【默认】；2：unionId模式；对应receiverUserIdList、privateData字段关于用户id的值填写方式
        self.user_id_type = user_id_type

    def validate(self):
        if self.card_data:
            self.card_data.validate()
        if self.private_data:
            for v in self.private_data.values():
                if v:
                    v.validate()

    def to_map(self):
        result = dict()
        if self.out_track_id is not None:
            result['outTrackId'] = self.out_track_id
        if self.card_data is not None:
            result['cardData'] = self.card_data.to_map()
        result['privateData'] = {}
        if self.private_data is not None:
            for k, v in self.private_data.items():
                result['privateData'][k] = v.to_map()
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_oauth_app_id is not None:
            result['dingOauthAppId'] = self.ding_oauth_app_id
        if self.user_id_type is not None:
            result['userIdType'] = self.user_id_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('outTrackId') is not None:
            self.out_track_id = m.get('outTrackId')
        if m.get('cardData') is not None:
            temp_model = UpdateInteractiveCardRequestCardData()
            self.card_data = temp_model.from_map(m['cardData'])
        self.private_data = {}
        if m.get('privateData') is not None:
            for k, v in m.get('privateData').items():
                temp_model = PrivateDataValue()
                self.private_data[k] = temp_model.from_map(v)
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingOauthAppId') is not None:
            self.ding_oauth_app_id = m.get('dingOauthAppId')
        if m.get('userIdType') is not None:
            self.user_id_type = m.get('userIdType')
        return self


class UpdateInteractiveCardResponseBody(TeaModel):
    def __init__(
        self,
        success: str = None,
    ):
        # result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
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
        body: UpdateInteractiveCardResponseBody = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
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
            temp_model = UpdateInteractiveCardResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


