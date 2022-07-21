# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List, Any


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
        body: AutoOpenDingTalkConnectResponseBody = None,
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
            temp_model = AutoOpenDingTalkConnectResponseBody()
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
        # 酷应用编码
        self.cool_app_code = cool_app_code
        # 本次读取的最大数据记录数量（该入参传入值小于钉钉阈值时返回全部）
        self.max_results = max_results
        # 标记当前开始读取的位置，置空表示从头开始
        self.next_token = next_token
        # 开放群ID
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
        # 是否还有更多数据
        self.has_more = has_more
        # 群成员员工号
        self.member_user_ids = member_user_ids
        # 下一次请求的游标
        self.next_token = next_token
        # result
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
        body: BatchQueryGroupMemberResponseBody = None,
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
        # 模板构建的action：含create、save、deploy
        self.action = action
        # 模板构建的dto对象
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
        # 模板构建的dto对象
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
        body: CardTemplateBuildActionResponseBody = None,
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
            temp_model = CardTemplateBuildActionResponseBody()
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
        # openConversationId
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
        body: ChatIdToOpenConversationIdResponseBody = None,
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
        # 开放群ID
        self.open_conversation_id = open_conversation_id
        # 设置2添加为管理员，设置3删除该管理员
        self.role = role
        # 企业员工工号列表
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
        # result
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
        body: ChatSubAdminUpdateResponseBody = None,
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
            temp_model = ChatSubAdminUpdateResponseBody()
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
        # 钉外人员业务Id
        self.app_user_id = app_user_id
        # 群头像
        self.group_avatar = group_avatar
        # 群名称
        self.group_name = group_name
        # 钉外群主业务Id
        self.group_owner_id = group_owner_id
        # 群模板
        self.group_template_id = group_template_id
        # 操作者的钉钉Id
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
        open_conversation_id: str = None,
    ):
        # 群会话Id
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


class CreateCoupleGroupConversationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateCoupleGroupConversationResponseBody = None,
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
        group_template_id: str = None,
        operator_id: str = None,
        user_ids: List[str] = None,
    ):
        # C端客户成员列表
        self.app_user_ids = app_user_ids
        # 群头像
        self.group_avatar = group_avatar
        # 群名称
        self.group_name = group_name
        # 群主钉钉Id
        self.group_owner_id = group_owner_id
        # 群模板
        self.group_template_id = group_template_id
        # 操作者的钉钉Id
        self.operator_id = operator_id
        # B端客服成员列表
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
        open_conversation_id: str = None,
        user_ids: List[str] = None,
    ):
        # 添加成功的C端客户列表
        self.app_user_ids = app_user_ids
        # 群会话Id
        self.open_conversation_id = open_conversation_id
        # 添加成功的B端客服列表
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
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUserIds') is not None:
            self.app_user_ids = m.get('appUserIds')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class CreateGroupConversationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateGroupConversationResponseBody = None,
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
        # 客户头像链接
        self.app_user_avatar = app_user_avatar
        # 客户头像类型，取值：
        # 1：http
        self.app_user_avatar_media_type = app_user_avatar_media_type
        # 客户动态
        self.app_user_dynamics = app_user_dynamics
        # 客户业务系统唯一标识
        self.app_user_id = app_user_id
        # 客户手机号
        self.app_user_mobile = app_user_mobile
        # 客户名称
        self.app_user_name = app_user_name
        # 客户渠道code
        self.channel_code = channel_code
        # 客服钉钉Id
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
        signature: str = None,
    ):
        # bc关系列表
        self.interconnections = interconnections
        # 参数签名
        self.signature = signature

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
        if self.signature is not None:
            result['signature'] = self.signature
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.interconnections = []
        if m.get('interconnections') is not None:
            for k in m.get('interconnections'):
                temp_model = CreateInterconnectionRequestInterconnections()
                self.interconnections.append(temp_model.from_map(k))
        if m.get('signature') is not None:
            self.signature = m.get('signature')
        return self


class CreateInterconnectionResponseBodyResults(TeaModel):
    def __init__(
        self,
        app_user_id: str = None,
        user_id: str = None,
    ):
        # 客户业务身份唯一标识
        self.app_user_id = app_user_id
        # 客服钉钉Id
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


class CreateInterconnectionResponseBody(TeaModel):
    def __init__(
        self,
        results: List[CreateInterconnectionResponseBodyResults] = None,
    ):
        # 失败的bc关系列表
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
        body: CreateInterconnectionResponseBody = None,
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
            temp_model = CreateInterconnectionResponseBody()
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
        # 钉外用户在业务系统内的唯一标识
        self.app_user_id = app_user_id
        # 外部业务唯一标识（店铺唯一标识）
        self.business_unique_key = business_unique_key
        # 群头像
        self.group_avatar = group_avatar
        # 群名称
        self.group_name = group_name
        # 群模板
        self.group_template_id = group_template_id
        # 操作者在业务系统内的唯一标识
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
        open_conversation_id: str = None,
    ):
        # 群会话Id
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


class CreateStoreGroupConversationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateStoreGroupConversationResponseBody = None,
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
            temp_model = CreateStoreGroupConversationResponseBody()
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
        open_conversation_id: str = None,
        source_code: str = None,
        user_id: str = None,
    ):
        # C端用户在业务账号体系内的用户userid，长度限制为1~64个字符。
        self.app_user_id = app_user_id
        # C端客户渠道code。
        self.channel_code = channel_code
        # 群会话Id。
        self.open_conversation_id = open_conversation_id
        # C端客户标识。
        self.source_code = source_code
        # B端用户的钉钉userId。
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
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.source_code is not None:
            result['sourceCode'] = self.source_code
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUserId') is not None:
            self.app_user_id = m.get('appUserId')
        if m.get('channelCode') is not None:
            self.channel_code = m.get('channelCode')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('sourceCode') is not None:
            self.source_code = m.get('sourceCode')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetConversationUrlResponseBody(TeaModel):
    def __init__(
        self,
        url: str = None,
    ):
        # 会话url
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
        body: GetConversationUrlResponseBody = None,
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
            temp_model = GetConversationUrlResponseBody()
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
        # appUserAvatar
        self.app_user_avatar = app_user_avatar
        # appUserAvatarType
        self.app_user_avatar_type = app_user_avatar_type
        # appUserId
        self.app_user_id = app_user_id
        # appUserMobileNumber
        self.app_user_mobile_number = app_user_mobile_number
        # appUserName
        self.app_user_name = app_user_name
        # msgPageType
        self.msg_page_type = msg_page_type
        # qrCode
        self.qr_code = qr_code
        # signature
        self.signature = signature
        # sourceCode
        self.source_code = source_code
        # sourceType
        self.source_type = source_type
        # userId
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
        # 会话url
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
        body: GetInterconnectionUrlResponseBody = None,
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
            temp_model = GetInterconnectionUrlResponseBody()
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
        # 酷应用编码
        self.cool_app_code = cool_app_code
        # 开放群ID
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
        success: bool = None,
        template_id: str = None,
        title: str = None,
    ):
        # 群url
        self.group_url = group_url
        # 群头像mediaId
        self.icon = icon
        # 开放群id
        self.open_conversation_id = open_conversation_id
        # 群主员工id
        self.owner_user_id = owner_user_id
        # result
        self.success = success
        # 场景群模板ID
        self.template_id = template_id
        # 群名称
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
        body: GetSceneGroupInfoResponseBody = None,
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
        # 酷应用编码
        self.cool_app_code = cool_app_code
        # 分页游标，首页传0
        self.cursor = cursor
        # 开放群ID
        self.open_conversation_id = open_conversation_id
        # 本次查询返回数量上限（该入参传入值小于钉钉阈值时不启用）
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
        # 是否还有更多数据
        self.has_more = has_more
        # 群成员员工号
        self.member_user_ids = member_user_ids
        # 下一次请求的游标
        self.next_cursor = next_cursor
        # result
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
        body: GetSceneGroupMembersResponseBody = None,
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
            temp_model = GetSceneGroupMembersResponseBody()
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
        # 禁言模式
        self.ban_words_mode = ban_words_mode
        # 开放群id
        self.open_conversation_id = open_conversation_id
        # 扩展参数
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
        # 有效生命周期
        self.effective_duration = effective_duration
        # 开放的群id
        self.open_conversation_id = open_conversation_id
        # 当前操作人工号
        self.operator = operator
        # 扩展参数
        self.options = options
        # 目标容量
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
        # 实际价格
        self.actual_price = actual_price
        # 群创建时间
        self.created_at = created_at
        # 当前容量
        self.current_capacity = current_capacity
        # 当前容量生效至何时
        self.current_effect_until = current_effect_until
        # 折扣
        self.discount = discount
        # 扩展信息
        self.ext_info = ext_info
        # 群主userId
        self.group_owner = group_owner
        # 群标题
        self.group_title = group_title
        # 标价
        self.marked_price = marked_price
        # 群人数
        self.member_count = member_count
        # 开放的群id
        self.open_conversation_id = open_conversation_id
        # 当前操作人工号
        self.operator = operator
        # 目标容量
        self.target_capacity = target_capacity
        # 目标容量生效至何时
        self.target_effect_until = target_effect_until
        # 校验令牌
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
        body: GroupCapacityInquiryResponseBody = None,
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
        # 操作人工号
        self.operator = operator
        # 订单号
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


class GroupCapacityOrderConfirmResponse(TeaModel):
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
        # 实际价格
        self.actual_price = actual_price
        # 当前容量
        self.current_capacity = current_capacity
        # 当前操当前容量生效至何时
        self.current_effect_until = current_effect_until
        # 折扣
        self.discount = discount
        # 扩展信息
        self.ext_info = ext_info
        # 标价
        self.marked_price = marked_price
        # 开放的群id
        self.open_conversation_id = open_conversation_id
        # 当前操作人工号
        self.operator = operator
        # 目标容量
        self.target_capacity = target_capacity
        # 目标容量生效至何时
        self.target_effect_until = target_effect_until
        # 校验令牌
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
        # 实际价格
        self.actual_price = actual_price
        # 当前容量
        self.current_capacity = current_capacity
        # 当前容量生效至何时
        self.current_effect_until = current_effect_until
        # 折扣
        self.discount = discount
        # 扩展信息
        self.ext_info = ext_info
        # 标价
        self.marked_price = marked_price
        # 群标识
        self.open_conversation_id = open_conversation_id
        # 当前操作人工号
        self.operator = operator
        # 订单号
        self.order_id = order_id
        # 目标容量
        self.target_capacity = target_capacity
        # 目标容量生效至何时
        self.target_effect_until = target_effect_until
        # 校验令牌
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
        body: GroupCapacityOrderPlaceResponseBody = None,
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
        # 建群时间不早于（辅助性条件，结合非排他条件使用）
        self.created_after = created_after
        # 群号
        self.group_id = group_id
        # 群成员样例工号列表
        self.group_member_samples = group_member_samples
        # 群主工号
        self.group_owner = group_owner
        # 群标题关键词列表
        self.group_title_keywords = group_title_keywords
        # 群链接
        self.group_url = group_url
        # 分页拉取的页大小, 最大不可超过1000
        self.max_results = max_results
        # 群成员数下限（辅助性条件，结合非排他条件使用）
        self.members_over = members_over
        # 分页拉取游标, 若不指定，则从头开始拉
        self.next_token = next_token
        # 开放群id
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
        # 禁言模式
        self.ban_words_mode = ban_words_mode
        # 群容量
        self.capacity = capacity
        # 群创建时间
        self.created_at = created_at
        # 扩展信息
        self.ext_info = ext_info
        self.group_admin_list = group_admin_list
        # 群主userid
        self.group_owner = group_owner
        # 群标题
        self.group_title = group_title
        # 当前群人数
        self.member_count = member_count
        # 开放的群id
        self.open_conversation_id = open_conversation_id
        # 群类型
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
        # 群信息列表
        self.group_info_list = group_info_list
        # 分页拉取时, 是否还有更多
        self.has_more = has_more
        # 分页拉取游标, 请求下一页时回传
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
        body: GroupManageQueryResponseBody = None,
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
        # 群容量限定值
        self.capacity_limit = capacity_limit
        # 开放群id
        self.open_conversation_id = open_conversation_id
        # 扩展参数
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
        # 卡片模板内容替换参数-多媒体类型
        self.card_media_id_param_map = card_media_id_param_map
        # 卡片模板内容替换参数-普通文本类型
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
        # 可控制卡片回调时的路由Key，用于指定特定的callbackUrl【可空：不填写默认用企业的回调地址】
        self.callback_route_key = callback_route_key
        self.card_data = card_data
        # 卡片模板ID
        self.card_template_id = card_template_id
        # 【robotCode & chatBotId二选一必填】机器人ID（企业机器人）
        self.chat_bot_id = chat_bot_id
        # 发送的会话类型：单聊-0, 群聊-1（单聊时：openConversationId不用填写；receiverUserIdList填写有且一个员工号）
        self.conversation_type = conversation_type
        # 接收卡片的群的openConversationId
        self.open_conversation_id = open_conversation_id
        # 唯一标识一张卡片的外部ID（卡片幂等ID，可用于更新或重复发送同一卡片到多个群会话）
        self.out_track_id = out_track_id
        # 指定用户可见的按钮列表（key：用户userId；value：用户数据）
        self.private_data = private_data
        # 是否开启卡片纯拉模式
        self.pull_strategy = pull_strategy
        # 接收人userId列表
        self.receiver_user_id_list = receiver_user_id_list
        # 【robotCode & chatBotId二选一必填】机器人编码（群模板机器人）
        self.robot_code = robot_code
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
        # 用于业务方后续查看已读列表的查询key
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
        body: InteractiveCardCreateInstanceResponseBody = None,
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
            temp_model = InteractiveCardCreateInstanceResponseBody()
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
        # 酷应用编码
        self.cool_app_code = cool_app_code
        # 群的openConversationId
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
        # 群内总人数
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
        body: QueryGroupInfoByMemberAuthResponseBody = None,
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
        # 群会话Id
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
        # 群成员头像
        self.group_member_avatar = group_member_avatar
        # 群成员动态信息
        self.group_member_dynamics = group_member_dynamics
        # 群成员Id
        self.group_member_id = group_member_id
        # 群成员名称
        self.group_member_name = group_member_name
        # 群成员类型
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
        # 群成员列表
        self.group_members = group_members
        # 群会话Id
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
        body: QueryGroupMemberResponseBody = None,
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
        # 酷应用编码
        self.cool_app_code = cool_app_code
        # 群的openConversationId
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
        # 群内昵称
        # 
        self.group_nick_name = group_nick_name
        # 企业内成员姓名
        self.org_name = org_name
        # 头像url
        self.profile_photo_url = profile_photo_url
        # 员工id
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
        # 群成员列表
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
        body: QueryGroupMemberByMemberAuthResponseBody = None,
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
        # 开放的会话ID
        self.open_conversation_id = open_conversation_id
        # 群成员的员工工号
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
        # 禁言结束时间
        self.mute_end_time = mute_end_time
        # 禁言开始时间
        self.mute_start_time = mute_start_time
        # 成员禁言状态
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
        # 群禁言状态
        self.group_mute_mode = group_mute_mode
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
        body: QueryGroupMuteStatusResponseBody = None,
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
            temp_model = QueryGroupMuteStatusResponseBody()
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
        # 开放群ID
        self.open_conversation_id = open_conversation_id
        # 开放群角色id
        self.open_role_id = open_role_id
        # 时间戳
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
        # userIds
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
        body: QueryMembersOfGroupRoleResponseBody = None,
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
            temp_model = QueryMembersOfGroupRoleResponseBody()
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
        # 客户appUserId
        self.app_user_id = app_user_id
        # 客服钉钉Id
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
        # 群成员列表
        self.group_members = group_members
        # 群模版Id
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
        # 客户appUserId
        self.app_user_id = app_user_id
        # 群会话Id
        self.open_conversation_id = open_conversation_id
        # 客服钉钉Id
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
        # 群会话列表
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
        body: QuerySingleGroupResponseBody = None,
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
        # C端客户appUserId
        self.app_user_id = app_user_id
        # 群会话Id列表
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
        # 群会话Id
        self.open_conversation_id = open_conversation_id
        # 未读消息数
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
        # 未读消息数
        self.un_read_count = un_read_count
        # 未读消息列表
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
        body: QueryUnReadMessageResponseBody = None,
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
            temp_model = QueryUnReadMessageResponseBody()
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
        # 卡片模板内容替换参数-多媒体类型
        self.card_media_id_param_map = card_media_id_param_map
        # 卡片模板内容替换参数-普通文本类型
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
        # 是否支持转发
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
        open_conversation_id: str = None,
        out_track_id: str = None,
        private_data: Dict[str, PrivateDataValue] = None,
        receiver_user_id_list: List[str] = None,
        robot_code: str = None,
        user_id_type: int = None,
    ):
        # 消息@人，{123456:"钉三多"}，key：根据userIdType来设置，【特殊设置：如果key、value都为"@ALL"则判断at所有人】
        self.at_open_ids = at_open_ids
        # 可控制卡片回调时的路由Key，用于指定特定的callbackUrl【可空：不填写默认用企业的回调地址】
        self.callback_route_key = callback_route_key
        # 卡片公共主体部分数据
        self.card_data = card_data
        # 卡片属性
        self.card_options = card_options
        # 卡片模板ID
        self.card_template_id = card_template_id
        # 【robotCode & chatBotId二选一必填】机器人ID（企业机器人）
        self.chat_bot_id = chat_bot_id
        # 发送的会话类型：单聊-0, 群聊-1（单聊时：openConversationId不用填写；receiverUserIdList填写有且一个员工号）
        self.conversation_type = conversation_type
        # 接收卡片的群的openConversationId
        self.open_conversation_id = open_conversation_id
        # 唯一标识一张卡片的外部ID（卡片幂等ID，可用于更新或重复发送同一卡片到多个群会话）
        self.out_track_id = out_track_id
        # 卡片用户私有差异部分数据（如卡片不同人显示不同按钮；key：用户userId；value：用户数据变量）
        self.private_data = private_data
        # 互动卡片消息需要群会话部分人可见时的接收人列表，不填写默认群会话所有人可见
        self.receiver_user_id_list = receiver_user_id_list
        # 【robotCode & chatBotId二选一必填】机器人编码（群模板机器人）
        self.robot_code = robot_code
        # 用户ID类型：1：userId模式【默认】；2：unionId模式；对应receiverUserIdList、privateData字段关于用户id的值填写方式
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
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.out_track_id is not None:
            result['outTrackId'] = self.out_track_id
        result['privateData'] = {}
        if self.private_data is not None:
            for k, v in self.private_data.items():
                result['privateData'][k] = v.to_map()
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
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('outTrackId') is not None:
            self.out_track_id = m.get('outTrackId')
        self.private_data = {}
        if m.get('privateData') is not None:
            for k, v in m.get('privateData').items():
                temp_model = PrivateDataValue()
                self.private_data[k] = temp_model.from_map(v)
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
        # 用于业务方后续查看已读列表的查询key
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
        # 创建卡片结果
        self.result = result
        # success
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
            temp_model = SendInteractiveCardResponseBody()
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
        # 是否@所有人
        self.at_all = at_all
        # 消息@人，JSON格式：[{"nickName":"张三","userId":"userId0001"},{"nickName":"李四","unionId":"unionId001"}]
        self.at_user_list_json = at_user_list_json
        # 卡片特殊属性json串
        self.card_property_json = card_property_json
        # 消息仅部分人可见的接收人列表【可空：为空则群所有人可见】，JSON格式：[{"userId":"userId0001"},{"unionId":"unionId001"}]
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
        robot_code: str = None,
        send_options: SendRobotInteractiveCardRequestSendOptions = None,
        single_chat_receiver: str = None,
        union_id_private_data_map: str = None,
        user_id_private_data_map: str = None,
    ):
        # 可交互卡片回调的url【可空：不填写无需回调】
        self.callback_url = callback_url
        # 唯一标识一张卡片的外部ID（卡片幂等ID，可用于更新或重复发送同一卡片到多个群会话）【备注：同一个outTrackId重复创建，卡片数据不覆盖更新】
        self.card_biz_id = card_biz_id
        # 卡片模板-文本内容参数（卡片json结构体）
        self.card_data = card_data
        # 卡片搭建平台模板ID
        self.card_template_id = card_template_id
        # 【openConversationId & singleChatReceiver 二选一必填】接收卡片的加密群ID，特指多人群会话（非单聊）
        self.open_conversation_id = open_conversation_id
        # 机器人代码，群模板机器人网页有机器人ID；企业内部机器人为机器人appKey，企业三方机器人有robotCode
        self.robot_code = robot_code
        # 互动卡片发送选项
        self.send_options = send_options
        # 【openConversationId & singleChatReceiver 二选一必填】单聊会话接受者json串
        self.single_chat_receiver = single_chat_receiver
        # 卡片模板-userId差异用户参数（json结构体）
        self.union_id_private_data_map = union_id_private_data_map
        # 卡片模板-userId差异用户参数（json结构体）
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
        # 用于业务方后续查看已读列表的查询key
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
        body: SendRobotInteractiveCardResponseBody = None,
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
            temp_model = SendRobotInteractiveCardResponseBody()
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
        # 是否@所有人
        self.at_all = at_all
        # 消息@人，JSON格式：[{"nickName":"张三","userId":"userId0001"},{"nickName":"李四","unionId":"unionId001"}]
        self.at_user_list_json = at_user_list_json
        # 卡片特殊属性json串
        self.card_property_json = card_property_json
        # 消息仅部分人可见的接收人列表【可空：为空则群所有人可见】，JSON格式：[{"userId":"userId0001"},{"unionId":"unionId001"}]
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
        # 可控制卡片回调的url【可空：不填写无需回调】
        self.callback_url = callback_url
        # 卡片模板-文本内容参数（卡片json结构体）
        self.card_data = card_data
        # 卡片内容模板ID，响应模板目前有：TuWenCard01、TuWenCard02、TuWenCard03、TuWenCard04 4种
        self.card_template_id = card_template_id
        # 【openConversationId & singleChatReceiver 二选一必填】接收卡片的加密群ID，特指多人群会话（非单聊）
        self.open_conversation_id = open_conversation_id
        # 唯一标识一张卡片的外部ID（卡片幂等ID，可用于更新或重复发送同一卡片到多个群会话）【备注：同一个outTrackId重复创建，卡片数据不覆盖更新】
        self.out_track_id = out_track_id
        # 机器人代码，群模板机器人网页有机器人ID；企业内部机器人为机器人appKey，企业三方机器人有robotCode
        self.robot_code = robot_code
        # 互动卡片发送选项
        self.send_options = send_options
        # 【openConversationId & singleChatReceiver 二选一必填】单聊会话接受者json串
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
        # 用于业务方后续查看已读列表的查询key
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
        body: SendTemplateInteractiveCardResponseBody = None,
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
            temp_model = SendTemplateInteractiveCardResponseBody()
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
        # 发送的会话类型：单聊-0, 群聊-1
        self.conversation_type = conversation_type
        # 酷应用编码
        self.cool_app_code = cool_app_code
        # 接收卡片的群的openConversationId
        self.open_conversation_id = open_conversation_id
        # 唯一标识一张卡片的外部ID（卡片幂等ID，可用于更新或重复发送同一卡片到多个群会话）
        self.out_track_id = out_track_id
        # 接收人的员工号列表
        self.receiver_user_id_list = receiver_user_id_list
        # 机器人编码
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
        # 发送的会话类型：单聊-0, 群聊-1
        self.conversation_type = conversation_type
        # 酷应用编码
        self.cool_app_code = cool_app_code
        # 吊顶的过期时间（绝对时间）
        self.expired_time = expired_time
        # 接收卡片的群的openConversationId
        self.open_conversation_id = open_conversation_id
        # 唯一标识一张卡片的外部ID（卡片幂等ID，可用于更新或重复发送同一卡片到多个群会话）
        self.out_track_id = out_track_id
        # 期望吊顶的端（多个"|"隔开，如："ios|win|"）
        self.platforms = platforms
        # 接收人的员工号列表
        self.receiver_user_id_list = receiver_user_id_list
        # 机器人编码
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
        # 群头像地址
        self.group_avatar = group_avatar
        # 群会话id
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
        # 新头像
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
        body: UpdateGroupAvatarResponseBody = None,
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
        # 群名称
        self.group_name = group_name
        # 群会话id
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
        # Id of the request
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
        body: UpdateGroupNameResponseBody = None,
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
        # 开放群ID
        self.open_conversation_id = open_conversation_id
        # 群权限项
        self.permission_group = permission_group
        # 状态,0-关闭，1-开启
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
        # result
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
        body: UpdateGroupPermissionResponseBody = None,
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
        # 开放群ID
        self.open_conversation_id = open_conversation_id
        # 2-群管理员 3-普通群成员
        self.role = role
        # 用户ID清单
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
        # success
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
        body: UpdateGroupSubAdminResponseBody = None,
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
        # 卡片模板内容替换参数-多媒体类型
        self.card_media_id_param_map = card_media_id_param_map
        # 卡片模板内容替换参数-普通文本类型
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
        # 按key更新cardData数据(不填默认覆盖更新)
        self.update_card_data_by_key = update_card_data_by_key
        # 按key更新privateData用户数据(不填默认覆盖更新)
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
        # 卡片公共主体部分数据
        self.card_data = card_data
        # 发送可交互卡片的一些功能选项
        self.card_options = card_options
        # 唯一标识一张卡片的外部ID
        self.out_track_id = out_track_id
        # 卡片用户私有差异部分数据（如卡片不同人显示不同按钮；key：用户userId；value：用户数据变量）
        self.private_data = private_data
        # 用户ID类型：1：userId模式【默认】；2：unionId模式；对应receiverUserIdList、privateData字段关于用户id的值填写方式
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
        # result
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
        # 禁言持续时长（单位：毫秒）
        self.mute_duration = mute_duration
        # 禁言状态(0表示取消禁言，1表示禁言)
        self.mute_status = mute_status
        # 开放群id
        self.open_conversation_id = open_conversation_id
        # 需要禁言或取消禁言的群成员列表
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
        # 群昵称
        self.group_nick = group_nick
        # 开放群ID
        self.open_conversation_id = open_conversation_id
        # 用户ID
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
        # result
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
        body: UpdateMemberGroupNickResponseBody = None,
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
            temp_model = UpdateMemberGroupNickResponseBody()
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
        # 按key更新数据(默认全量更新)
        self.update_card_data_by_key = update_card_data_by_key
        # 按key更新用户数据(默认全量更新)
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
        # 唯一标识一张卡片的外部ID（卡片幂等ID，可用于更新或重复发送同一卡片到多个群会话）【备注：同一个outTrackId重复创建，卡片数据不覆盖更新】
        self.card_biz_id = card_biz_id
        # 卡片模板-文本内容参数（卡片json结构体）
        self.card_data = card_data
        # 卡片模板-userId差异用户参数（json结构体）
        self.union_id_private_data_map = union_id_private_data_map
        # 互动卡片更新选项
        self.update_options = update_options
        # 卡片模板-userId差异用户参数（json结构体）
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
        # 用于业务方后续查看已读列表的查询key
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
        body: UpdateRobotInteractiveCardResponseBody = None,
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
            temp_model = UpdateRobotInteractiveCardResponseBody()
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
        # 开放群ID
        self.open_conversation_id = open_conversation_id
        # 群角色列表
        self.open_role_ids = open_role_ids
        # 用户ID
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
        # result
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
        body: UpdateTheGroupRolesOfGroupMemberResponseBody = None,
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
            temp_model = UpdateTheGroupRolesOfGroupMemberResponseBody()
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
        # C端客户成员列表
        self.app_user_ids = app_user_ids
        # 群会话Id
        self.open_conversation_id = open_conversation_id
        # 操作者钉钉Id
        self.operator_id = operator_id
        # B端客服成员列表
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
        # 拉取成功的C端客户列表
        self.app_user_ids = app_user_ids
        # 拉取成功的B端客服列表
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
        body: AddGroupMemberResponseBody = None,
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
        # C端客户成员列表
        self.app_user_ids = app_user_ids
        # 群会话Id
        self.open_conversation_id = open_conversation_id
        # 操作者钉钉Id
        self.operator_id = operator_id
        # B端客服成员列表
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


class RemoveGroupMemberResponse(TeaModel):
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
        # 客服oauth2.0授权码
        self.code = code
        # 消息内容
        self.message = message
        # 消息类型
        self.message_type = message_type
        # 群会话Id
        self.open_conversation_id = open_conversation_id
        # C端客户appUserId
        self.receiver_id = receiver_id
        # B端客服钉钉Id
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
        # 发送消息请求Id
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
        body: SendDingMessageResponseBody = None,
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
    ):
        # 消息内容
        self.message = message
        # 消息类型
        self.message_type = message_type
        # 群会话Id
        self.open_conversation_id = open_conversation_id
        # B端客服钉钉Id
        self.receiver_id = receiver_id
        # C端客户appUserId
        self.sender_id = sender_id

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
        return self


class SendMessageResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        # 发送消息请求Id
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
        body: SendMessageResponseBody = None,
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
            temp_model = SendMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


