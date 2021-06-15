# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict


class UserTaskReportHeaders(TeaModel):
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


class UserTaskReportRequest(TeaModel):
    def __init__(
        self,
        ding_corp_id: str = None,
        task_tag: str = None,
        operate_date: str = None,
        userid: str = None,
        biz_no: str = None,
    ):
        self.ding_corp_id = ding_corp_id
        # taskTag
        self.task_tag = task_tag
        # operateDate
        self.operate_date = operate_date
        # staffId
        self.userid = userid
        # 业务的幂等ID
        self.biz_no = biz_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_corp_id is not None:
            result['dingCorpId'] = self.ding_corp_id
        if self.task_tag is not None:
            result['taskTag'] = self.task_tag
        if self.operate_date is not None:
            result['operateDate'] = self.operate_date
        if self.userid is not None:
            result['userid'] = self.userid
        if self.biz_no is not None:
            result['bizNo'] = self.biz_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingCorpId') is not None:
            self.ding_corp_id = m.get('dingCorpId')
        if m.get('taskTag') is not None:
            self.task_tag = m.get('taskTag')
        if m.get('operateDate') is not None:
            self.operate_date = m.get('operateDate')
        if m.get('userid') is not None:
            self.userid = m.get('userid')
        if m.get('bizNo') is not None:
            self.biz_no = m.get('bizNo')
        return self


class UserTaskReportResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: bool = None,
    ):
        self.headers = headers
        self.body = body

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('body') is not None:
            self.body = m.get('body')
        return self


class CreateAppGoodsServiceConversationHeaders(TeaModel):
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


class CreateAppGoodsServiceConversationRequest(TeaModel):
    def __init__(
        self,
        order_id: int = None,
        isv_user_id: str = None,
    ):
        self.order_id = order_id
        self.isv_user_id = isv_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.order_id is not None:
            result['orderId'] = self.order_id
        if self.isv_user_id is not None:
            result['isvUserId'] = self.isv_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('orderId') is not None:
            self.order_id = m.get('orderId')
        if m.get('isvUserId') is not None:
            self.isv_user_id = m.get('isvUserId')
        return self


class CreateAppGoodsServiceConversationResponseBody(TeaModel):
    def __init__(
        self,
        conversation_name: str = None,
        new_conversation: bool = None,
    ):
        # 群名称
        self.conversation_name = conversation_name
        # 是否是新群
        self.new_conversation = new_conversation

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conversation_name is not None:
            result['conversationName'] = self.conversation_name
        if self.new_conversation is not None:
            result['newConversation'] = self.new_conversation
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conversationName') is not None:
            self.conversation_name = m.get('conversationName')
        if m.get('newConversation') is not None:
            self.new_conversation = m.get('newConversation')
        return self


class CreateAppGoodsServiceConversationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateAppGoodsServiceConversationResponseBody = None,
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
            temp_model = CreateAppGoodsServiceConversationResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetPersonalExperienceInfoHeaders(TeaModel):
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


class GetPersonalExperienceInfoRequest(TeaModel):
    def __init__(
        self,
        user_id: str = None,
    ):
        # A short description of struct
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


class GetPersonalExperienceInfoResponseBodyResult(TeaModel):
    def __init__(
        self,
        main_corp_id: str = None,
    ):
        # 主组织corpId
        self.main_corp_id = main_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.main_corp_id is not None:
            result['mainCorpId'] = self.main_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('mainCorpId') is not None:
            self.main_corp_id = m.get('mainCorpId')
        return self


class GetPersonalExperienceInfoResponseBody(TeaModel):
    def __init__(
        self,
        result: GetPersonalExperienceInfoResponseBodyResult = None,
    ):
        # 数据对象
        self.result = result

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = GetPersonalExperienceInfoResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetPersonalExperienceInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetPersonalExperienceInfoResponseBody = None,
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
            temp_model = GetPersonalExperienceInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


