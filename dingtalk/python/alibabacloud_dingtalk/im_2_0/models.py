# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class CloseTopboxHeaders(TeaModel):
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


class CloseTopboxRequest(TeaModel):
    def __init__(
        self,
        conversation_type: int = None,
        cool_app_code: str = None,
        group_template_id: str = None,
        open_conversation_id: str = None,
        out_track_id: str = None,
        robot_code: str = None,
        unoin_id: str = None,
        user_id: str = None,
    ):
        # 会话类型。
        self.conversation_type = conversation_type
        # 酷应用编码。
        self.cool_app_code = cool_app_code
        # 群模板id。
        self.group_template_id = group_template_id
        # 会话id。
        self.open_conversation_id = open_conversation_id
        # 唯一标识一张卡片的外部ID。
        self.out_track_id = out_track_id
        # 单聊助手会话，机器人编码。
        self.robot_code = robot_code
        # 单聊助手会话，用户unionId。
        self.unoin_id = unoin_id
        # 单聊助手会话，用户userId。
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
        if self.cool_app_code is not None:
            result['coolAppCode'] = self.cool_app_code
        if self.group_template_id is not None:
            result['groupTemplateId'] = self.group_template_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.out_track_id is not None:
            result['outTrackId'] = self.out_track_id
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        if self.unoin_id is not None:
            result['unoinId'] = self.unoin_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conversationType') is not None:
            self.conversation_type = m.get('conversationType')
        if m.get('coolAppCode') is not None:
            self.cool_app_code = m.get('coolAppCode')
        if m.get('groupTemplateId') is not None:
            self.group_template_id = m.get('groupTemplateId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('outTrackId') is not None:
            self.out_track_id = m.get('outTrackId')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        if m.get('unoinId') is not None:
            self.unoin_id = m.get('unoinId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CloseTopboxResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        # 请求是否成功。
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


class CloseTopboxResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CloseTopboxResponseBody = None,
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
            temp_model = CloseTopboxResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateTopboxHeaders(TeaModel):
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


class CreateTopboxRequestCardData(TeaModel):
    def __init__(
        self,
        card_param_map: Dict[str, str] = None,
    ):
        # 卡片模板内容替换参数，包含普通文本类型和多媒体类型。
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


class CreateTopboxRequestCardSettings(TeaModel):
    def __init__(
        self,
        pull_strategy: bool = None,
    ):
        # 是否开启卡片纯拉模式。
        self.pull_strategy = pull_strategy

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.pull_strategy is not None:
            result['pullStrategy'] = self.pull_strategy
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pullStrategy') is not None:
            self.pull_strategy = m.get('pullStrategy')
        return self


class UnionIdPrivateDataMapValue(TeaModel):
    def __init__(
        self,
        card_param_map: Dict[str, str] = None,
    ):
        # 卡片模板内容替换参数，包含普通文本类型和多媒体类型。
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


class UserIdPrivateDataMapValue(TeaModel):
    def __init__(
        self,
        card_param_map: Dict[str, str] = None,
    ):
        # 卡片模板内容替换参数，包含普通文本类型和多媒体类型。
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


class CreateTopboxRequest(TeaModel):
    def __init__(
        self,
        callback_route_key: str = None,
        card_data: CreateTopboxRequestCardData = None,
        card_settings: CreateTopboxRequestCardSettings = None,
        card_template_id: str = None,
        conversation_type: int = None,
        cool_app_code: str = None,
        expired_time: int = None,
        group_template_id: str = None,
        open_conversation_id: str = None,
        out_track_id: str = None,
        platforms: str = None,
        receiver_union_id_list: List[str] = None,
        receiver_user_id_list: List[str] = None,
        robot_code: str = None,
        union_id_private_data_map: Dict[str, UnionIdPrivateDataMapValue] = None,
        unoin_id: str = None,
        user_id: str = None,
        user_id_private_data_map: Dict[str, UserIdPrivateDataMapValue] = None,
    ):
        # 可控制卡片回调时的路由Key，用于指定特定的callbackUrl。
        self.callback_route_key = callback_route_key
        # 卡片数据。
        self.card_data = card_data
        # 卡片设置项。
        self.card_settings = card_settings
        # 互动卡片的消息模板ID
        self.card_template_id = card_template_id
        # 会话类型。
        self.conversation_type = conversation_type
        # 酷应用编码。
        self.cool_app_code = cool_app_code
        # 吊顶的过期时间，绝对时间。
        self.expired_time = expired_time
        # 群模板id。
        self.group_template_id = group_template_id
        # 会话id。
        self.open_conversation_id = open_conversation_id
        # 唯一标识一张卡片的外部ID。
        self.out_track_id = out_track_id
        # 期望吊顶的端，如果有多个用“｜”分隔。 例如：ios|mac|android|win表示iOS、MAC、安卓和windows端。
        self.platforms = platforms
        # 吊顶可见者unionId，最多可传100个unionId。
        self.receiver_union_id_list = receiver_union_id_list
        # 吊顶可见者userId，最多可传100个userId。
        self.receiver_user_id_list = receiver_user_id_list
        # 单聊助手会话，机器人编码。
        self.robot_code = robot_code
        # 卡片模板unionId差异用户参数。
        self.union_id_private_data_map = union_id_private_data_map
        # 单聊助手会话，用户unionId。
        self.unoin_id = unoin_id
        # 单聊助手会话，用户userId。
        self.user_id = user_id
        # 卡片模板userId差异用户参数。
        self.user_id_private_data_map = user_id_private_data_map

    def validate(self):
        if self.card_data:
            self.card_data.validate()
        if self.card_settings:
            self.card_settings.validate()
        if self.union_id_private_data_map:
            for v in self.union_id_private_data_map.values():
                if v:
                    v.validate()
        if self.user_id_private_data_map:
            for v in self.user_id_private_data_map.values():
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
        if self.card_settings is not None:
            result['cardSettings'] = self.card_settings.to_map()
        if self.card_template_id is not None:
            result['cardTemplateId'] = self.card_template_id
        if self.conversation_type is not None:
            result['conversationType'] = self.conversation_type
        if self.cool_app_code is not None:
            result['coolAppCode'] = self.cool_app_code
        if self.expired_time is not None:
            result['expiredTime'] = self.expired_time
        if self.group_template_id is not None:
            result['groupTemplateId'] = self.group_template_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.out_track_id is not None:
            result['outTrackId'] = self.out_track_id
        if self.platforms is not None:
            result['platforms'] = self.platforms
        if self.receiver_union_id_list is not None:
            result['receiverUnionIdList'] = self.receiver_union_id_list
        if self.receiver_user_id_list is not None:
            result['receiverUserIdList'] = self.receiver_user_id_list
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        result['unionIdPrivateDataMap'] = {}
        if self.union_id_private_data_map is not None:
            for k, v in self.union_id_private_data_map.items():
                result['unionIdPrivateDataMap'][k] = v.to_map()
        if self.unoin_id is not None:
            result['unoinId'] = self.unoin_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        result['userIdPrivateDataMap'] = {}
        if self.user_id_private_data_map is not None:
            for k, v in self.user_id_private_data_map.items():
                result['userIdPrivateDataMap'][k] = v.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('callbackRouteKey') is not None:
            self.callback_route_key = m.get('callbackRouteKey')
        if m.get('cardData') is not None:
            temp_model = CreateTopboxRequestCardData()
            self.card_data = temp_model.from_map(m['cardData'])
        if m.get('cardSettings') is not None:
            temp_model = CreateTopboxRequestCardSettings()
            self.card_settings = temp_model.from_map(m['cardSettings'])
        if m.get('cardTemplateId') is not None:
            self.card_template_id = m.get('cardTemplateId')
        if m.get('conversationType') is not None:
            self.conversation_type = m.get('conversationType')
        if m.get('coolAppCode') is not None:
            self.cool_app_code = m.get('coolAppCode')
        if m.get('expiredTime') is not None:
            self.expired_time = m.get('expiredTime')
        if m.get('groupTemplateId') is not None:
            self.group_template_id = m.get('groupTemplateId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('outTrackId') is not None:
            self.out_track_id = m.get('outTrackId')
        if m.get('platforms') is not None:
            self.platforms = m.get('platforms')
        if m.get('receiverUnionIdList') is not None:
            self.receiver_union_id_list = m.get('receiverUnionIdList')
        if m.get('receiverUserIdList') is not None:
            self.receiver_user_id_list = m.get('receiverUserIdList')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        self.union_id_private_data_map = {}
        if m.get('unionIdPrivateDataMap') is not None:
            for k, v in m.get('unionIdPrivateDataMap').items():
                temp_model = UnionIdPrivateDataMapValue()
                self.union_id_private_data_map[k] = temp_model.from_map(v)
        if m.get('unoinId') is not None:
            self.unoin_id = m.get('unoinId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        self.user_id_private_data_map = {}
        if m.get('userIdPrivateDataMap') is not None:
            for k, v in m.get('userIdPrivateDataMap').items():
                temp_model = UserIdPrivateDataMapValue()
                self.user_id_private_data_map[k] = temp_model.from_map(v)
        return self


class CreateTopboxResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        # 请求是否成功。
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


class CreateTopboxResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateTopboxResponseBody = None,
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
            temp_model = CreateTopboxResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


