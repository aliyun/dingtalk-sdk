# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import List, Dict, Any


class ConversationCategoryModel(TeaModel):
    def __init__(
        self,
        category_id: int = None,
        category_name: str = None,
        children: List['ConversationCategoryModel'] = None,
        level_num: int = None,
        order: int = None,
    ):
        # This parameter is required.
        self.category_id = category_id
        # This parameter is required.
        self.category_name = category_name
        self.children = children
        # This parameter is required.
        self.level_num = level_num
        # This parameter is required.
        self.order = order

    def validate(self):
        if self.children:
            for k in self.children:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.category_id is not None:
            result['categoryId'] = self.category_id
        if self.category_name is not None:
            result['categoryName'] = self.category_name
        result['children'] = []
        if self.children is not None:
            for k in self.children:
                result['children'].append(k.to_map() if k else None)
        if self.level_num is not None:
            result['levelNum'] = self.level_num
        if self.order is not None:
            result['order'] = self.order
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('categoryId') is not None:
            self.category_id = m.get('categoryId')
        if m.get('categoryName') is not None:
            self.category_name = m.get('categoryName')
        self.children = []
        if m.get('children') is not None:
            for k in m.get('children'):
                temp_model = ConversationCategoryModel()
                self.children.append(temp_model.from_map(k))
        if m.get('levelNum') is not None:
            self.level_num = m.get('levelNum')
        if m.get('order') is not None:
            self.order = m.get('order')
        return self


class AddOrgHeaders(TeaModel):
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


class AddOrgRequest(TeaModel):
    def __init__(
        self,
        city: str = None,
        industry: str = None,
        industry_code: int = None,
        mobile_num: str = None,
        name: str = None,
        province: str = None,
    ):
        self.city = city
        self.industry = industry
        self.industry_code = industry_code
        # This parameter is required.
        self.mobile_num = mobile_num
        # This parameter is required.
        self.name = name
        self.province = province

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.city is not None:
            result['city'] = self.city
        if self.industry is not None:
            result['industry'] = self.industry
        if self.industry_code is not None:
            result['industryCode'] = self.industry_code
        if self.mobile_num is not None:
            result['mobileNum'] = self.mobile_num
        if self.name is not None:
            result['name'] = self.name
        if self.province is not None:
            result['province'] = self.province
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('city') is not None:
            self.city = m.get('city')
        if m.get('industry') is not None:
            self.industry = m.get('industry')
        if m.get('industryCode') is not None:
            self.industry_code = m.get('industryCode')
        if m.get('mobileNum') is not None:
            self.mobile_num = m.get('mobileNum')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('province') is not None:
            self.province = m.get('province')
        return self


class AddOrgResponseBody(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
    ):
        self.corp_id = corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        return self


class AddOrgResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AddOrgResponseBody = None,
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
            temp_model = AddOrgResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ApproveProcessCallbackHeaders(TeaModel):
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


class ApproveProcessCallbackRequestRequest(TeaModel):
    def __init__(
        self,
        approve_result: str = None,
        approve_type: str = None,
        approvers: List[str] = None,
        create_time: int = None,
        event_type: str = None,
        finish_time: int = None,
        params: str = None,
        process_instance_id: str = None,
        title: str = None,
    ):
        # This parameter is required.
        self.approve_result = approve_result
        # This parameter is required.
        self.approve_type = approve_type
        self.approvers = approvers
        # This parameter is required.
        self.create_time = create_time
        # This parameter is required.
        self.event_type = event_type
        # This parameter is required.
        self.finish_time = finish_time
        self.params = params
        # This parameter is required.
        self.process_instance_id = process_instance_id
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.approve_result is not None:
            result['approveResult'] = self.approve_result
        if self.approve_type is not None:
            result['approveType'] = self.approve_type
        if self.approvers is not None:
            result['approvers'] = self.approvers
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.event_type is not None:
            result['eventType'] = self.event_type
        if self.finish_time is not None:
            result['finishTime'] = self.finish_time
        if self.params is not None:
            result['params'] = self.params
        if self.process_instance_id is not None:
            result['processInstanceId'] = self.process_instance_id
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('approveResult') is not None:
            self.approve_result = m.get('approveResult')
        if m.get('approveType') is not None:
            self.approve_type = m.get('approveType')
        if m.get('approvers') is not None:
            self.approvers = m.get('approvers')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('eventType') is not None:
            self.event_type = m.get('eventType')
        if m.get('finishTime') is not None:
            self.finish_time = m.get('finishTime')
        if m.get('params') is not None:
            self.params = m.get('params')
        if m.get('processInstanceId') is not None:
            self.process_instance_id = m.get('processInstanceId')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class ApproveProcessCallbackRequest(TeaModel):
    def __init__(
        self,
        access_key_id: str = None,
        access_key_secret: str = None,
        request: ApproveProcessCallbackRequestRequest = None,
        target_corp_id: str = None,
    ):
        # This parameter is required.
        self.access_key_id = access_key_id
        # This parameter is required.
        self.access_key_secret = access_key_secret
        # This parameter is required.
        self.request = request
        self.target_corp_id = target_corp_id

    def validate(self):
        if self.request:
            self.request.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key_id is not None:
            result['accessKeyId'] = self.access_key_id
        if self.access_key_secret is not None:
            result['accessKeySecret'] = self.access_key_secret
        if self.request is not None:
            result['request'] = self.request.to_map()
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKeyId') is not None:
            self.access_key_id = m.get('accessKeyId')
        if m.get('accessKeySecret') is not None:
            self.access_key_secret = m.get('accessKeySecret')
        if m.get('request') is not None:
            temp_model = ApproveProcessCallbackRequestRequest()
            self.request = temp_model.from_map(m['request'])
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        return self


class ApproveProcessCallbackResponseBody(TeaModel):
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


class ApproveProcessCallbackResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ApproveProcessCallbackResponseBody = None,
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
            temp_model = ApproveProcessCallbackResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BanOrOpenGroupWordsHeaders(TeaModel):
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


class BanOrOpenGroupWordsRequest(TeaModel):
    def __init__(
        self,
        ban_words_type: int = None,
        open_converation_id: str = None,
    ):
        # This parameter is required.
        self.ban_words_type = ban_words_type
        # This parameter is required.
        self.open_converation_id = open_converation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ban_words_type is not None:
            result['banWordsType'] = self.ban_words_type
        if self.open_converation_id is not None:
            result['openConverationId'] = self.open_converation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('banWordsType') is not None:
            self.ban_words_type = m.get('banWordsType')
        if m.get('openConverationId') is not None:
            self.open_converation_id = m.get('openConverationId')
        return self


class BanOrOpenGroupWordsResponseBody(TeaModel):
    def __init__(
        self,
        cause: str = None,
        code: str = None,
    ):
        self.cause = cause
        self.code = code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cause is not None:
            result['cause'] = self.cause
        if self.code is not None:
            result['code'] = self.code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cause') is not None:
            self.cause = m.get('cause')
        if m.get('code') is not None:
            self.code = m.get('code')
        return self


class BanOrOpenGroupWordsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BanOrOpenGroupWordsResponseBody = None,
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
            temp_model = BanOrOpenGroupWordsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateCategoryAndBindingGroupsHeaders(TeaModel):
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


class CreateCategoryAndBindingGroupsRequest(TeaModel):
    def __init__(
        self,
        category_name: str = None,
        group_ids: List[int] = None,
    ):
        self.category_name = category_name
        self.group_ids = group_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.category_name is not None:
            result['categoryName'] = self.category_name
        if self.group_ids is not None:
            result['groupIds'] = self.group_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('categoryName') is not None:
            self.category_name = m.get('categoryName')
        if m.get('groupIds') is not None:
            self.group_ids = m.get('groupIds')
        return self


class CreateCategoryAndBindingGroupsResponseBody(TeaModel):
    def __init__(
        self,
        id: int = None,
    ):
        # This parameter is required.
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


class CreateCategoryAndBindingGroupsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateCategoryAndBindingGroupsResponseBody = None,
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
            temp_model = CreateCategoryAndBindingGroupsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateDlpTaskHeaders(TeaModel):
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


class CreateDlpTaskRequest(TeaModel):
    def __init__(
        self,
        dentry_id: str = None,
        space_id: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.dentry_id = dentry_id
        # This parameter is required.
        self.space_id = space_id
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dentry_id is not None:
            result['dentryId'] = self.dentry_id
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dentryId') is not None:
            self.dentry_id = m.get('dentryId')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CreateDlpTaskResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
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


class CreateDlpTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateDlpTaskResponseBody = None,
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
            temp_model = CreateDlpTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateMessageCategoryHeaders(TeaModel):
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


class CreateMessageCategoryRequest(TeaModel):
    def __init__(
        self,
        category_name: str = None,
        group_ids: List[str] = None,
    ):
        self.category_name = category_name
        self.group_ids = group_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.category_name is not None:
            result['categoryName'] = self.category_name
        if self.group_ids is not None:
            result['groupIds'] = self.group_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('categoryName') is not None:
            self.category_name = m.get('categoryName')
        if m.get('groupIds') is not None:
            self.group_ids = m.get('groupIds')
        return self


class CreateMessageCategoryResponseBody(TeaModel):
    def __init__(
        self,
        id: int = None,
    ):
        # This parameter is required.
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


class CreateMessageCategoryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateMessageCategoryResponseBody = None,
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
            temp_model = CreateMessageCategoryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateRuleHeaders(TeaModel):
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


class CreateRuleRequestCustomPlan(TeaModel):
    def __init__(
        self,
        current_category_list: List[str] = None,
        dept_ids: List[int] = None,
        plan_name: str = None,
        un_select_category_list: List[str] = None,
        user_ids: List[str] = None,
    ):
        self.current_category_list = current_category_list
        self.dept_ids = dept_ids
        self.plan_name = plan_name
        self.un_select_category_list = un_select_category_list
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.current_category_list is not None:
            result['currentCategoryList'] = self.current_category_list
        if self.dept_ids is not None:
            result['deptIds'] = self.dept_ids
        if self.plan_name is not None:
            result['planName'] = self.plan_name
        if self.un_select_category_list is not None:
            result['unSelectCategoryList'] = self.un_select_category_list
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('currentCategoryList') is not None:
            self.current_category_list = m.get('currentCategoryList')
        if m.get('deptIds') is not None:
            self.dept_ids = m.get('deptIds')
        if m.get('planName') is not None:
            self.plan_name = m.get('planName')
        if m.get('unSelectCategoryList') is not None:
            self.un_select_category_list = m.get('unSelectCategoryList')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class CreateRuleRequest(TeaModel):
    def __init__(
        self,
        custom_plan: CreateRuleRequestCustomPlan = None,
    ):
        self.custom_plan = custom_plan

    def validate(self):
        if self.custom_plan:
            self.custom_plan.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.custom_plan is not None:
            result['customPlan'] = self.custom_plan.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customPlan') is not None:
            temp_model = CreateRuleRequestCustomPlan()
            self.custom_plan = temp_model.from_map(m['customPlan'])
        return self


class CreateRuleResponseBody(TeaModel):
    def __init__(
        self,
        id: int = None,
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


class CreateRuleResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateRuleResponseBody = None,
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
            temp_model = CreateRuleResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateTrustedDeviceHeaders(TeaModel):
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


class CreateTrustedDeviceRequest(TeaModel):
    def __init__(
        self,
        did: str = None,
        mac_address: str = None,
        platform: str = None,
        status: int = None,
        user_id: str = None,
    ):
        self.did = did
        self.mac_address = mac_address
        # This parameter is required.
        self.platform = platform
        self.status = status
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.did is not None:
            result['did'] = self.did
        if self.mac_address is not None:
            result['macAddress'] = self.mac_address
        if self.platform is not None:
            result['platform'] = self.platform
        if self.status is not None:
            result['status'] = self.status
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('did') is not None:
            self.did = m.get('did')
        if m.get('macAddress') is not None:
            self.mac_address = m.get('macAddress')
        if m.get('platform') is not None:
            self.platform = m.get('platform')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CreateTrustedDeviceResponseBody(TeaModel):
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


class CreateTrustedDeviceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateTrustedDeviceResponseBody = None,
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
            temp_model = CreateTrustedDeviceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateTrustedDeviceBatchHeaders(TeaModel):
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


class CreateTrustedDeviceBatchRequest(TeaModel):
    def __init__(
        self,
        mac_address_list: List[str] = None,
        platform: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.mac_address_list = mac_address_list
        # This parameter is required.
        self.platform = platform
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.mac_address_list is not None:
            result['macAddressList'] = self.mac_address_list
        if self.platform is not None:
            result['platform'] = self.platform
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('macAddressList') is not None:
            self.mac_address_list = m.get('macAddressList')
        if m.get('platform') is not None:
            self.platform = m.get('platform')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CreateTrustedDeviceBatchResponseBody(TeaModel):
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


class CreateTrustedDeviceBatchResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateTrustedDeviceBatchResponseBody = None,
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
            temp_model = CreateTrustedDeviceBatchResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateVirusScanTaskHeaders(TeaModel):
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


class CreateVirusScanTaskRequest(TeaModel):
    def __init__(
        self,
        dentry_id: str = None,
        download_url: str = None,
        file_md_5: str = None,
        file_name: str = None,
        file_size: int = None,
        source: int = None,
        space_id: str = None,
        user_id: str = None,
    ):
        self.dentry_id = dentry_id
        self.download_url = download_url
        self.file_md_5 = file_md_5
        self.file_name = file_name
        self.file_size = file_size
        # This parameter is required.
        self.source = source
        self.space_id = space_id
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dentry_id is not None:
            result['dentryId'] = self.dentry_id
        if self.download_url is not None:
            result['downloadUrl'] = self.download_url
        if self.file_md_5 is not None:
            result['fileMd5'] = self.file_md_5
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.file_size is not None:
            result['fileSize'] = self.file_size
        if self.source is not None:
            result['source'] = self.source
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dentryId') is not None:
            self.dentry_id = m.get('dentryId')
        if m.get('downloadUrl') is not None:
            self.download_url = m.get('downloadUrl')
        if m.get('fileMd5') is not None:
            self.file_md_5 = m.get('fileMd5')
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('fileSize') is not None:
            self.file_size = m.get('fileSize')
        if m.get('source') is not None:
            self.source = m.get('source')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class CreateVirusScanTaskResponseBody(TeaModel):
    def __init__(
        self,
        task_id: str = None,
    ):
        self.task_id = task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class CreateVirusScanTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateVirusScanTaskResponseBody = None,
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
            temp_model = CreateVirusScanTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DataSyncHeaders(TeaModel):
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


class DataSyncRequest(TeaModel):
    def __init__(
        self,
        sql: str = None,
    ):
        # This parameter is required.
        self.sql = sql

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.sql is not None:
            result['sql'] = self.sql
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sql') is not None:
            self.sql = m.get('sql')
        return self


class DataSyncResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        rows_affected: int = None,
    ):
        self.data_list = data_list
        self.rows_affected = rows_affected

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        if self.rows_affected is not None:
            result['rowsAffected'] = self.rows_affected
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        if m.get('rowsAffected') is not None:
            self.rows_affected = m.get('rowsAffected')
        return self


class DataSyncResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DataSyncResponseBody = None,
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
            temp_model = DataSyncResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteAcrossCloudStroageConfigsHeaders(TeaModel):
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


class DeleteAcrossCloudStroageConfigsResponseBody(TeaModel):
    def __init__(
        self,
        result: bool = None,
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


class DeleteAcrossCloudStroageConfigsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteAcrossCloudStroageConfigsResponseBody = None,
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
            temp_model = DeleteAcrossCloudStroageConfigsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteCommentHeaders(TeaModel):
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


class DeleteCommentResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: bool = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

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
        if self.body is not None:
            result['body'] = self.body
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            self.body = m.get('body')
        return self


class DeleteTrustedDeviceHeaders(TeaModel):
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


class DeleteTrustedDeviceRequest(TeaModel):
    def __init__(
        self,
        id: int = None,
        kick_off: bool = None,
        mac_address: str = None,
        user_id: str = None,
    ):
        self.id = id
        # This parameter is required.
        self.kick_off = kick_off
        self.mac_address = mac_address
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.kick_off is not None:
            result['kickOff'] = self.kick_off
        if self.mac_address is not None:
            result['macAddress'] = self.mac_address
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('kickOff') is not None:
            self.kick_off = m.get('kickOff')
        if m.get('macAddress') is not None:
            self.mac_address = m.get('macAddress')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class DeleteTrustedDeviceResponseBody(TeaModel):
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


class DeleteTrustedDeviceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteTrustedDeviceResponseBody = None,
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
            temp_model = DeleteTrustedDeviceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DistributePartnerAppHeaders(TeaModel):
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


class DistributePartnerAppRequest(TeaModel):
    def __init__(
        self,
        app_id: int = None,
        dept_id: int = None,
        sub_corp_id: str = None,
        type: int = None,
    ):
        # This parameter is required.
        self.app_id = app_id
        self.dept_id = dept_id
        # This parameter is required.
        self.sub_corp_id = sub_corp_id
        # This parameter is required.
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.sub_corp_id is not None:
            result['subCorpId'] = self.sub_corp_id
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('subCorpId') is not None:
            self.sub_corp_id = m.get('subCorpId')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class DistributePartnerAppResponseBody(TeaModel):
    def __init__(
        self,
        invite_url: str = None,
    ):
        self.invite_url = invite_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.invite_url is not None:
            result['inviteUrl'] = self.invite_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('inviteUrl') is not None:
            self.invite_url = m.get('inviteUrl')
        return self


class DistributePartnerAppResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DistributePartnerAppResponseBody = None,
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
            temp_model = DistributePartnerAppResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class EditSecurityConfigMemberHeaders(TeaModel):
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


class EditSecurityConfigMemberRequest(TeaModel):
    def __init__(
        self,
        config_key: str = None,
        operate_type: str = None,
        operate_user_id: str = None,
        user_ids: List[str] = None,
    ):
        # This parameter is required.
        self.config_key = config_key
        # This parameter is required.
        self.operate_type = operate_type
        # This parameter is required.
        self.operate_user_id = operate_user_id
        # This parameter is required.
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.config_key is not None:
            result['configKey'] = self.config_key
        if self.operate_type is not None:
            result['operateType'] = self.operate_type
        if self.operate_user_id is not None:
            result['operateUserId'] = self.operate_user_id
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('configKey') is not None:
            self.config_key = m.get('configKey')
        if m.get('operateType') is not None:
            self.operate_type = m.get('operateType')
        if m.get('operateUserId') is not None:
            self.operate_user_id = m.get('operateUserId')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class EditSecurityConfigMemberResponseBody(TeaModel):
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


class EditSecurityConfigMemberResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: EditSecurityConfigMemberResponseBody = None,
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
            temp_model = EditSecurityConfigMemberResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ExchangeMainAdminHeaders(TeaModel):
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


class ExchangeMainAdminRequest(TeaModel):
    def __init__(
        self,
        new_admin_user_id: str = None,
        old_admin_user_id: str = None,
        target_corp_id: str = None,
    ):
        # This parameter is required.
        self.new_admin_user_id = new_admin_user_id
        # This parameter is required.
        self.old_admin_user_id = old_admin_user_id
        # This parameter is required.
        self.target_corp_id = target_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.new_admin_user_id is not None:
            result['newAdminUserId'] = self.new_admin_user_id
        if self.old_admin_user_id is not None:
            result['oldAdminUserId'] = self.old_admin_user_id
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('newAdminUserId') is not None:
            self.new_admin_user_id = m.get('newAdminUserId')
        if m.get('oldAdminUserId') is not None:
            self.old_admin_user_id = m.get('oldAdminUserId')
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        return self


class ExchangeMainAdminResponseBody(TeaModel):
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


class ExchangeMainAdminResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ExchangeMainAdminResponseBody = None,
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
            temp_model = ExchangeMainAdminResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ExclusiveCreateDingPortalHeaders(TeaModel):
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


class ExclusiveCreateDingPortalRequest(TeaModel):
    def __init__(
        self,
        ding_portal_name: str = None,
        target_corp_id: str = None,
        template_app_uuid: str = None,
        template_corp_id: str = None,
    ):
        self.ding_portal_name = ding_portal_name
        # This parameter is required.
        self.target_corp_id = target_corp_id
        # This parameter is required.
        self.template_app_uuid = template_app_uuid
        # This parameter is required.
        self.template_corp_id = template_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_portal_name is not None:
            result['dingPortalName'] = self.ding_portal_name
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        if self.template_app_uuid is not None:
            result['templateAppUuid'] = self.template_app_uuid
        if self.template_corp_id is not None:
            result['templateCorpId'] = self.template_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingPortalName') is not None:
            self.ding_portal_name = m.get('dingPortalName')
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        if m.get('templateAppUuid') is not None:
            self.template_app_uuid = m.get('templateAppUuid')
        if m.get('templateCorpId') is not None:
            self.template_corp_id = m.get('templateCorpId')
        return self


class ExclusiveCreateDingPortalResponseBody(TeaModel):
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


class ExclusiveCreateDingPortalResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ExclusiveCreateDingPortalResponseBody = None,
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
            temp_model = ExclusiveCreateDingPortalResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class FileStorageActiveStorageHeaders(TeaModel):
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


class FileStorageActiveStorageRequest(TeaModel):
    def __init__(
        self,
        access_key_id: str = None,
        access_key_secret: str = None,
        oss: str = None,
        target_corp_id: str = None,
    ):
        # This parameter is required.
        self.access_key_id = access_key_id
        # This parameter is required.
        self.access_key_secret = access_key_secret
        # This parameter is required.
        self.oss = oss
        # This parameter is required.
        self.target_corp_id = target_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key_id is not None:
            result['accessKeyId'] = self.access_key_id
        if self.access_key_secret is not None:
            result['accessKeySecret'] = self.access_key_secret
        if self.oss is not None:
            result['oss'] = self.oss
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKeyId') is not None:
            self.access_key_id = m.get('accessKeyId')
        if m.get('accessKeySecret') is not None:
            self.access_key_secret = m.get('accessKeySecret')
        if m.get('oss') is not None:
            self.oss = m.get('oss')
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        return self


class FileStorageActiveStorageResponseBody(TeaModel):
    def __init__(
        self,
        create_date: str = None,
        file_storage_open_status: int = None,
        storage_status: int = None,
        used_quota: int = None,
    ):
        self.create_date = create_date
        self.file_storage_open_status = file_storage_open_status
        self.storage_status = storage_status
        self.used_quota = used_quota

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_date is not None:
            result['createDate'] = self.create_date
        if self.file_storage_open_status is not None:
            result['fileStorageOpenStatus'] = self.file_storage_open_status
        if self.storage_status is not None:
            result['storageStatus'] = self.storage_status
        if self.used_quota is not None:
            result['usedQuota'] = self.used_quota
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createDate') is not None:
            self.create_date = m.get('createDate')
        if m.get('fileStorageOpenStatus') is not None:
            self.file_storage_open_status = m.get('fileStorageOpenStatus')
        if m.get('storageStatus') is not None:
            self.storage_status = m.get('storageStatus')
        if m.get('usedQuota') is not None:
            self.used_quota = m.get('usedQuota')
        return self


class FileStorageActiveStorageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: FileStorageActiveStorageResponseBody = None,
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
            temp_model = FileStorageActiveStorageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class FileStorageCheckConnectionHeaders(TeaModel):
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


class FileStorageCheckConnectionRequest(TeaModel):
    def __init__(
        self,
        access_key_id: str = None,
        access_key_secret: str = None,
        oss: str = None,
        target_corp_id: str = None,
    ):
        # This parameter is required.
        self.access_key_id = access_key_id
        # This parameter is required.
        self.access_key_secret = access_key_secret
        # This parameter is required.
        self.oss = oss
        # This parameter is required.
        self.target_corp_id = target_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key_id is not None:
            result['accessKeyId'] = self.access_key_id
        if self.access_key_secret is not None:
            result['accessKeySecret'] = self.access_key_secret
        if self.oss is not None:
            result['oss'] = self.oss
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKeyId') is not None:
            self.access_key_id = m.get('accessKeyId')
        if m.get('accessKeySecret') is not None:
            self.access_key_secret = m.get('accessKeySecret')
        if m.get('oss') is not None:
            self.oss = m.get('oss')
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        return self


class FileStorageCheckConnectionResponseBody(TeaModel):
    def __init__(
        self,
        access_key_id: str = None,
        check_state: int = None,
        oss: str = None,
    ):
        self.access_key_id = access_key_id
        # This parameter is required.
        self.check_state = check_state
        self.oss = oss

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key_id is not None:
            result['accessKeyId'] = self.access_key_id
        if self.check_state is not None:
            result['checkState'] = self.check_state
        if self.oss is not None:
            result['oss'] = self.oss
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKeyId') is not None:
            self.access_key_id = m.get('accessKeyId')
        if m.get('checkState') is not None:
            self.check_state = m.get('checkState')
        if m.get('oss') is not None:
            self.oss = m.get('oss')
        return self


class FileStorageCheckConnectionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: FileStorageCheckConnectionResponseBody = None,
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
            temp_model = FileStorageCheckConnectionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class FileStorageGetQuotaDataHeaders(TeaModel):
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


class FileStorageGetQuotaDataRequest(TeaModel):
    def __init__(
        self,
        end_time: str = None,
        start_time: str = None,
        target_corp_id: str = None,
        type: str = None,
    ):
        # This parameter is required.
        self.end_time = end_time
        # This parameter is required.
        self.start_time = start_time
        # This parameter is required.
        self.target_corp_id = target_corp_id
        # This parameter is required.
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class FileStorageGetQuotaDataResponseBodyQuotaModelList(TeaModel):
    def __init__(
        self,
        statistic_time: str = None,
        used_storage: int = None,
    ):
        # This parameter is required.
        self.statistic_time = statistic_time
        # This parameter is required.
        self.used_storage = used_storage

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.statistic_time is not None:
            result['statisticTime'] = self.statistic_time
        if self.used_storage is not None:
            result['usedStorage'] = self.used_storage
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('statisticTime') is not None:
            self.statistic_time = m.get('statisticTime')
        if m.get('usedStorage') is not None:
            self.used_storage = m.get('usedStorage')
        return self


class FileStorageGetQuotaDataResponseBody(TeaModel):
    def __init__(
        self,
        quota_model_list: List[FileStorageGetQuotaDataResponseBodyQuotaModelList] = None,
    ):
        self.quota_model_list = quota_model_list

    def validate(self):
        if self.quota_model_list:
            for k in self.quota_model_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['quotaModelList'] = []
        if self.quota_model_list is not None:
            for k in self.quota_model_list:
                result['quotaModelList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.quota_model_list = []
        if m.get('quotaModelList') is not None:
            for k in m.get('quotaModelList'):
                temp_model = FileStorageGetQuotaDataResponseBodyQuotaModelList()
                self.quota_model_list.append(temp_model.from_map(k))
        return self


class FileStorageGetQuotaDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: FileStorageGetQuotaDataResponseBody = None,
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
            temp_model = FileStorageGetQuotaDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class FileStorageGetStorageStateHeaders(TeaModel):
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


class FileStorageGetStorageStateRequest(TeaModel):
    def __init__(
        self,
        target_corp_id: str = None,
    ):
        # This parameter is required.
        self.target_corp_id = target_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        return self


class FileStorageGetStorageStateResponseBody(TeaModel):
    def __init__(
        self,
        access_key_id: str = None,
        create_date: str = None,
        file_storage_open_status: int = None,
        oss: str = None,
        storage_status: int = None,
        used_quota: int = None,
    ):
        self.access_key_id = access_key_id
        self.create_date = create_date
        self.file_storage_open_status = file_storage_open_status
        self.oss = oss
        self.storage_status = storage_status
        self.used_quota = used_quota

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key_id is not None:
            result['accessKeyId'] = self.access_key_id
        if self.create_date is not None:
            result['createDate'] = self.create_date
        if self.file_storage_open_status is not None:
            result['fileStorageOpenStatus'] = self.file_storage_open_status
        if self.oss is not None:
            result['oss'] = self.oss
        if self.storage_status is not None:
            result['storageStatus'] = self.storage_status
        if self.used_quota is not None:
            result['usedQuota'] = self.used_quota
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKeyId') is not None:
            self.access_key_id = m.get('accessKeyId')
        if m.get('createDate') is not None:
            self.create_date = m.get('createDate')
        if m.get('fileStorageOpenStatus') is not None:
            self.file_storage_open_status = m.get('fileStorageOpenStatus')
        if m.get('oss') is not None:
            self.oss = m.get('oss')
        if m.get('storageStatus') is not None:
            self.storage_status = m.get('storageStatus')
        if m.get('usedQuota') is not None:
            self.used_quota = m.get('usedQuota')
        return self


class FileStorageGetStorageStateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: FileStorageGetStorageStateResponseBody = None,
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
            temp_model = FileStorageGetStorageStateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class FileStorageUpdateStorageHeaders(TeaModel):
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


class FileStorageUpdateStorageRequest(TeaModel):
    def __init__(
        self,
        access_key_id: str = None,
        access_key_secret: str = None,
        target_corp_id: str = None,
    ):
        # This parameter is required.
        self.access_key_id = access_key_id
        # This parameter is required.
        self.access_key_secret = access_key_secret
        # This parameter is required.
        self.target_corp_id = target_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key_id is not None:
            result['accessKeyId'] = self.access_key_id
        if self.access_key_secret is not None:
            result['accessKeySecret'] = self.access_key_secret
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKeyId') is not None:
            self.access_key_id = m.get('accessKeyId')
        if m.get('accessKeySecret') is not None:
            self.access_key_secret = m.get('accessKeySecret')
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        return self


class FileStorageUpdateStorageResponseBody(TeaModel):
    def __init__(
        self,
        access_key_id: str = None,
        oss: str = None,
    ):
        self.access_key_id = access_key_id
        self.oss = oss

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key_id is not None:
            result['accessKeyId'] = self.access_key_id
        if self.oss is not None:
            result['oss'] = self.oss
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKeyId') is not None:
            self.access_key_id = m.get('accessKeyId')
        if m.get('oss') is not None:
            self.oss = m.get('oss')
        return self


class FileStorageUpdateStorageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: FileStorageUpdateStorageResponseBody = None,
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
            temp_model = FileStorageUpdateStorageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GenerateDarkWaterMarkHeaders(TeaModel):
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


class GenerateDarkWaterMarkRequest(TeaModel):
    def __init__(
        self,
        user_id_list: List[str] = None,
    ):
        # This parameter is required.
        self.user_id_list = user_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id_list is not None:
            result['userIdList'] = self.user_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userIdList') is not None:
            self.user_id_list = m.get('userIdList')
        return self


class GenerateDarkWaterMarkResponseBodyDarkWatermarkVOList(TeaModel):
    def __init__(
        self,
        dark_watermark: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.dark_watermark = dark_watermark
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dark_watermark is not None:
            result['darkWatermark'] = self.dark_watermark
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('darkWatermark') is not None:
            self.dark_watermark = m.get('darkWatermark')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GenerateDarkWaterMarkResponseBody(TeaModel):
    def __init__(
        self,
        dark_watermark_volist: List[GenerateDarkWaterMarkResponseBodyDarkWatermarkVOList] = None,
    ):
        self.dark_watermark_volist = dark_watermark_volist

    def validate(self):
        if self.dark_watermark_volist:
            for k in self.dark_watermark_volist:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['darkWatermarkVOList'] = []
        if self.dark_watermark_volist is not None:
            for k in self.dark_watermark_volist:
                result['darkWatermarkVOList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.dark_watermark_volist = []
        if m.get('darkWatermarkVOList') is not None:
            for k in m.get('darkWatermarkVOList'):
                temp_model = GenerateDarkWaterMarkResponseBodyDarkWatermarkVOList()
                self.dark_watermark_volist.append(temp_model.from_map(k))
        return self


class GenerateDarkWaterMarkResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GenerateDarkWaterMarkResponseBody = None,
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
            temp_model = GenerateDarkWaterMarkResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetAccountTransferListHeaders(TeaModel):
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


class GetAccountTransferListRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        status: int = None,
    ):
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
        self.page_size = page_size
        # This parameter is required.
        self.status = status

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
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class GetAccountTransferListResponseBodyItemList(TeaModel):
    def __init__(
        self,
        dept_name: int = None,
        name: str = None,
        user_id: str = None,
    ):
        self.dept_name = dept_name
        self.name = name
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.name is not None:
            result['name'] = self.name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetAccountTransferListResponseBody(TeaModel):
    def __init__(
        self,
        item_list: List[GetAccountTransferListResponseBodyItemList] = None,
        total_count: int = None,
    ):
        self.item_list = item_list
        self.total_count = total_count

    def validate(self):
        if self.item_list:
            for k in self.item_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['itemList'] = []
        if self.item_list is not None:
            for k in self.item_list:
                result['itemList'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.item_list = []
        if m.get('itemList') is not None:
            for k in m.get('itemList'):
                temp_model = GetAccountTransferListResponseBodyItemList()
                self.item_list.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class GetAccountTransferListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetAccountTransferListResponseBody = None,
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
            temp_model = GetAccountTransferListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetActiveUserSummaryHeaders(TeaModel):
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


class GetActiveUserSummaryResponseBody(TeaModel):
    def __init__(
        self,
        act_usr_cnt_1m: str = None,
    ):
        self.act_usr_cnt_1m = act_usr_cnt_1m

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.act_usr_cnt_1m is not None:
            result['actUsrCnt1m'] = self.act_usr_cnt_1m
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actUsrCnt1m') is not None:
            self.act_usr_cnt_1m = m.get('actUsrCnt1m')
        return self


class GetActiveUserSummaryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetActiveUserSummaryResponseBody = None,
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
            temp_model = GetActiveUserSummaryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetAgentIdByRelatedAppIdHeaders(TeaModel):
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


class GetAgentIdByRelatedAppIdRequest(TeaModel):
    def __init__(
        self,
        app_id: int = None,
        target_corp_id: str = None,
    ):
        # This parameter is required.
        self.app_id = app_id
        # This parameter is required.
        self.target_corp_id = target_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        return self


class GetAgentIdByRelatedAppIdResponseBody(TeaModel):
    def __init__(
        self,
        agent_id: int = None,
    ):
        self.agent_id = agent_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        return self


class GetAgentIdByRelatedAppIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetAgentIdByRelatedAppIdResponseBody = None,
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
            temp_model = GetAgentIdByRelatedAppIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetAllLabelableDeptsHeaders(TeaModel):
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


class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel1(TeaModel):
    def __init__(
        self,
        label_id: int = None,
        label_name: str = None,
        level_num: int = None,
    ):
        # This parameter is required.
        self.label_id = label_id
        # This parameter is required.
        self.label_name = label_name
        # This parameter is required.
        self.level_num = level_num

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.label_id is not None:
            result['labelId'] = self.label_id
        if self.label_name is not None:
            result['labelName'] = self.label_name
        if self.level_num is not None:
            result['levelNum'] = self.level_num
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('labelId') is not None:
            self.label_id = m.get('labelId')
        if m.get('labelName') is not None:
            self.label_name = m.get('labelName')
        if m.get('levelNum') is not None:
            self.level_num = m.get('levelNum')
        return self


class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel2(TeaModel):
    def __init__(
        self,
        label_id: int = None,
        label_name: str = None,
        level_num: int = None,
    ):
        # This parameter is required.
        self.label_id = label_id
        # This parameter is required.
        self.label_name = label_name
        # This parameter is required.
        self.level_num = level_num

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.label_id is not None:
            result['labelId'] = self.label_id
        if self.label_name is not None:
            result['labelName'] = self.label_name
        if self.level_num is not None:
            result['levelNum'] = self.level_num
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('labelId') is not None:
            self.label_id = m.get('labelId')
        if m.get('labelName') is not None:
            self.label_name = m.get('labelName')
        if m.get('levelNum') is not None:
            self.level_num = m.get('levelNum')
        return self


class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel3(TeaModel):
    def __init__(
        self,
        label_id: int = None,
        label_name: str = None,
        level_num: int = None,
    ):
        # This parameter is required.
        self.label_id = label_id
        # This parameter is required.
        self.label_name = label_name
        # This parameter is required.
        self.level_num = level_num

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.label_id is not None:
            result['labelId'] = self.label_id
        if self.label_name is not None:
            result['labelName'] = self.label_name
        if self.level_num is not None:
            result['levelNum'] = self.level_num
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('labelId') is not None:
            self.label_id = m.get('labelId')
        if m.get('labelName') is not None:
            self.label_name = m.get('labelName')
        if m.get('levelNum') is not None:
            self.level_num = m.get('levelNum')
        return self


class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel4(TeaModel):
    def __init__(
        self,
        label_id: int = None,
        label_name: str = None,
        level_num: int = None,
    ):
        # This parameter is required.
        self.label_id = label_id
        # This parameter is required.
        self.label_name = label_name
        # This parameter is required.
        self.level_num = level_num

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.label_id is not None:
            result['labelId'] = self.label_id
        if self.label_name is not None:
            result['labelName'] = self.label_name
        if self.level_num is not None:
            result['levelNum'] = self.level_num
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('labelId') is not None:
            self.label_id = m.get('labelId')
        if m.get('labelName') is not None:
            self.label_name = m.get('labelName')
        if m.get('levelNum') is not None:
            self.level_num = m.get('levelNum')
        return self


class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel5(TeaModel):
    def __init__(
        self,
        label_id: int = None,
        label_name: str = None,
        level_num: int = None,
    ):
        # This parameter is required.
        self.label_id = label_id
        # This parameter is required.
        self.label_name = label_name
        # This parameter is required.
        self.level_num = level_num

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.label_id is not None:
            result['labelId'] = self.label_id
        if self.label_name is not None:
            result['labelName'] = self.label_name
        if self.level_num is not None:
            result['levelNum'] = self.level_num
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('labelId') is not None:
            self.label_id = m.get('labelId')
        if m.get('labelName') is not None:
            self.label_name = m.get('labelName')
        if m.get('levelNum') is not None:
            self.level_num = m.get('levelNum')
        return self


class GetAllLabelableDeptsResponseBodyData(TeaModel):
    def __init__(
        self,
        dept_id: str = None,
        dept_name: str = None,
        member_count: int = None,
        partner_label_volevel_1: GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel1 = None,
        partner_label_volevel_2: GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel2 = None,
        partner_label_volevel_3: GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel3 = None,
        partner_label_volevel_4: GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel4 = None,
        partner_label_volevel_5: GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel5 = None,
        partner_num: str = None,
        super_dept_id: str = None,
    ):
        # This parameter is required.
        self.dept_id = dept_id
        # This parameter is required.
        self.dept_name = dept_name
        # This parameter is required.
        self.member_count = member_count
        # This parameter is required.
        self.partner_label_volevel_1 = partner_label_volevel_1
        # This parameter is required.
        self.partner_label_volevel_2 = partner_label_volevel_2
        # This parameter is required.
        self.partner_label_volevel_3 = partner_label_volevel_3
        # This parameter is required.
        self.partner_label_volevel_4 = partner_label_volevel_4
        # This parameter is required.
        self.partner_label_volevel_5 = partner_label_volevel_5
        # This parameter is required.
        self.partner_num = partner_num
        # This parameter is required.
        self.super_dept_id = super_dept_id

    def validate(self):
        if self.partner_label_volevel_1:
            self.partner_label_volevel_1.validate()
        if self.partner_label_volevel_2:
            self.partner_label_volevel_2.validate()
        if self.partner_label_volevel_3:
            self.partner_label_volevel_3.validate()
        if self.partner_label_volevel_4:
            self.partner_label_volevel_4.validate()
        if self.partner_label_volevel_5:
            self.partner_label_volevel_5.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.member_count is not None:
            result['memberCount'] = self.member_count
        if self.partner_label_volevel_1 is not None:
            result['partnerLabelVOLevel1'] = self.partner_label_volevel_1.to_map()
        if self.partner_label_volevel_2 is not None:
            result['partnerLabelVOLevel2'] = self.partner_label_volevel_2.to_map()
        if self.partner_label_volevel_3 is not None:
            result['partnerLabelVOLevel3'] = self.partner_label_volevel_3.to_map()
        if self.partner_label_volevel_4 is not None:
            result['partnerLabelVOLevel4'] = self.partner_label_volevel_4.to_map()
        if self.partner_label_volevel_5 is not None:
            result['partnerLabelVOLevel5'] = self.partner_label_volevel_5.to_map()
        if self.partner_num is not None:
            result['partnerNum'] = self.partner_num
        if self.super_dept_id is not None:
            result['superDeptId'] = self.super_dept_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('memberCount') is not None:
            self.member_count = m.get('memberCount')
        if m.get('partnerLabelVOLevel1') is not None:
            temp_model = GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel1()
            self.partner_label_volevel_1 = temp_model.from_map(m['partnerLabelVOLevel1'])
        if m.get('partnerLabelVOLevel2') is not None:
            temp_model = GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel2()
            self.partner_label_volevel_2 = temp_model.from_map(m['partnerLabelVOLevel2'])
        if m.get('partnerLabelVOLevel3') is not None:
            temp_model = GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel3()
            self.partner_label_volevel_3 = temp_model.from_map(m['partnerLabelVOLevel3'])
        if m.get('partnerLabelVOLevel4') is not None:
            temp_model = GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel4()
            self.partner_label_volevel_4 = temp_model.from_map(m['partnerLabelVOLevel4'])
        if m.get('partnerLabelVOLevel5') is not None:
            temp_model = GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel5()
            self.partner_label_volevel_5 = temp_model.from_map(m['partnerLabelVOLevel5'])
        if m.get('partnerNum') is not None:
            self.partner_num = m.get('partnerNum')
        if m.get('superDeptId') is not None:
            self.super_dept_id = m.get('superDeptId')
        return self


class GetAllLabelableDeptsResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetAllLabelableDeptsResponseBodyData] = None,
    ):
        # This parameter is required.
        self.data = data

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetAllLabelableDeptsResponseBodyData()
                self.data.append(temp_model.from_map(k))
        return self


class GetAllLabelableDeptsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetAllLabelableDeptsResponseBody = None,
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
            temp_model = GetAllLabelableDeptsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetAppDispatchInfoHeaders(TeaModel):
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


class GetAppDispatchInfoRequest(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        start_time: int = None,
    ):
        self.end_time = end_time
        self.start_time = start_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.start_time is not None:
            result['startTime'] = self.start_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        return self


class GetAppDispatchInfoResponseBodyAndroid(TeaModel):
    def __init__(
        self,
        base_line_version: str = None,
        download_url: str = None,
        in_gray: bool = None,
        pack_time: int = None,
        platform: str = None,
        version: str = None,
    ):
        self.base_line_version = base_line_version
        self.download_url = download_url
        self.in_gray = in_gray
        self.pack_time = pack_time
        self.platform = platform
        self.version = version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.base_line_version is not None:
            result['baseLineVersion'] = self.base_line_version
        if self.download_url is not None:
            result['downloadUrl'] = self.download_url
        if self.in_gray is not None:
            result['inGray'] = self.in_gray
        if self.pack_time is not None:
            result['packTime'] = self.pack_time
        if self.platform is not None:
            result['platform'] = self.platform
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('baseLineVersion') is not None:
            self.base_line_version = m.get('baseLineVersion')
        if m.get('downloadUrl') is not None:
            self.download_url = m.get('downloadUrl')
        if m.get('inGray') is not None:
            self.in_gray = m.get('inGray')
        if m.get('packTime') is not None:
            self.pack_time = m.get('packTime')
        if m.get('platform') is not None:
            self.platform = m.get('platform')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class GetAppDispatchInfoResponseBodyIOSExt(TeaModel):
    def __init__(
        self,
        plist: str = None,
    ):
        self.plist = plist

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.plist is not None:
            result['plist'] = self.plist
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('plist') is not None:
            self.plist = m.get('plist')
        return self


class GetAppDispatchInfoResponseBodyIOS(TeaModel):
    def __init__(
        self,
        base_line_version: str = None,
        download_url: str = None,
        ext: GetAppDispatchInfoResponseBodyIOSExt = None,
        in_gray: bool = None,
        pack_time: int = None,
        platform: str = None,
        version: str = None,
    ):
        self.base_line_version = base_line_version
        self.download_url = download_url
        self.ext = ext
        self.in_gray = in_gray
        self.pack_time = pack_time
        self.platform = platform
        self.version = version

    def validate(self):
        if self.ext:
            self.ext.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.base_line_version is not None:
            result['baseLineVersion'] = self.base_line_version
        if self.download_url is not None:
            result['downloadUrl'] = self.download_url
        if self.ext is not None:
            result['ext'] = self.ext.to_map()
        if self.in_gray is not None:
            result['inGray'] = self.in_gray
        if self.pack_time is not None:
            result['packTime'] = self.pack_time
        if self.platform is not None:
            result['platform'] = self.platform
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('baseLineVersion') is not None:
            self.base_line_version = m.get('baseLineVersion')
        if m.get('downloadUrl') is not None:
            self.download_url = m.get('downloadUrl')
        if m.get('ext') is not None:
            temp_model = GetAppDispatchInfoResponseBodyIOSExt()
            self.ext = temp_model.from_map(m['ext'])
        if m.get('inGray') is not None:
            self.in_gray = m.get('inGray')
        if m.get('packTime') is not None:
            self.pack_time = m.get('packTime')
        if m.get('platform') is not None:
            self.platform = m.get('platform')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class GetAppDispatchInfoResponseBodyMac(TeaModel):
    def __init__(
        self,
        base_line_version: str = None,
        download_url: str = None,
        in_gray: bool = None,
        pack_time: int = None,
        platform: str = None,
        version: str = None,
    ):
        self.base_line_version = base_line_version
        self.download_url = download_url
        self.in_gray = in_gray
        self.pack_time = pack_time
        self.platform = platform
        self.version = version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.base_line_version is not None:
            result['baseLineVersion'] = self.base_line_version
        if self.download_url is not None:
            result['downloadUrl'] = self.download_url
        if self.in_gray is not None:
            result['inGray'] = self.in_gray
        if self.pack_time is not None:
            result['packTime'] = self.pack_time
        if self.platform is not None:
            result['platform'] = self.platform
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('baseLineVersion') is not None:
            self.base_line_version = m.get('baseLineVersion')
        if m.get('downloadUrl') is not None:
            self.download_url = m.get('downloadUrl')
        if m.get('inGray') is not None:
            self.in_gray = m.get('inGray')
        if m.get('packTime') is not None:
            self.pack_time = m.get('packTime')
        if m.get('platform') is not None:
            self.platform = m.get('platform')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class GetAppDispatchInfoResponseBodyWindows(TeaModel):
    def __init__(
        self,
        base_line_version: str = None,
        download_url: str = None,
        in_gray: bool = None,
        pack_time: int = None,
        platform: str = None,
        version: str = None,
    ):
        self.base_line_version = base_line_version
        self.download_url = download_url
        self.in_gray = in_gray
        self.pack_time = pack_time
        self.platform = platform
        self.version = version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.base_line_version is not None:
            result['baseLineVersion'] = self.base_line_version
        if self.download_url is not None:
            result['downloadUrl'] = self.download_url
        if self.in_gray is not None:
            result['inGray'] = self.in_gray
        if self.pack_time is not None:
            result['packTime'] = self.pack_time
        if self.platform is not None:
            result['platform'] = self.platform
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('baseLineVersion') is not None:
            self.base_line_version = m.get('baseLineVersion')
        if m.get('downloadUrl') is not None:
            self.download_url = m.get('downloadUrl')
        if m.get('inGray') is not None:
            self.in_gray = m.get('inGray')
        if m.get('packTime') is not None:
            self.pack_time = m.get('packTime')
        if m.get('platform') is not None:
            self.platform = m.get('platform')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class GetAppDispatchInfoResponseBody(TeaModel):
    def __init__(
        self,
        android: List[GetAppDispatchInfoResponseBodyAndroid] = None,
        i_os: List[GetAppDispatchInfoResponseBodyIOS] = None,
        mac: List[GetAppDispatchInfoResponseBodyMac] = None,
        windows: List[GetAppDispatchInfoResponseBodyWindows] = None,
    ):
        self.android = android
        self.i_os = i_os
        self.mac = mac
        self.windows = windows

    def validate(self):
        if self.android:
            for k in self.android:
                if k:
                    k.validate()
        if self.i_os:
            for k in self.i_os:
                if k:
                    k.validate()
        if self.mac:
            for k in self.mac:
                if k:
                    k.validate()
        if self.windows:
            for k in self.windows:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['android'] = []
        if self.android is not None:
            for k in self.android:
                result['android'].append(k.to_map() if k else None)
        result['iOS'] = []
        if self.i_os is not None:
            for k in self.i_os:
                result['iOS'].append(k.to_map() if k else None)
        result['mac'] = []
        if self.mac is not None:
            for k in self.mac:
                result['mac'].append(k.to_map() if k else None)
        result['windows'] = []
        if self.windows is not None:
            for k in self.windows:
                result['windows'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.android = []
        if m.get('android') is not None:
            for k in m.get('android'):
                temp_model = GetAppDispatchInfoResponseBodyAndroid()
                self.android.append(temp_model.from_map(k))
        self.i_os = []
        if m.get('iOS') is not None:
            for k in m.get('iOS'):
                temp_model = GetAppDispatchInfoResponseBodyIOS()
                self.i_os.append(temp_model.from_map(k))
        self.mac = []
        if m.get('mac') is not None:
            for k in m.get('mac'):
                temp_model = GetAppDispatchInfoResponseBodyMac()
                self.mac.append(temp_model.from_map(k))
        self.windows = []
        if m.get('windows') is not None:
            for k in m.get('windows'):
                temp_model = GetAppDispatchInfoResponseBodyWindows()
                self.windows.append(temp_model.from_map(k))
        return self


class GetAppDispatchInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetAppDispatchInfoResponseBody = None,
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
            temp_model = GetAppDispatchInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetCalenderSummaryHeaders(TeaModel):
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


class GetCalenderSummaryResponseBody(TeaModel):
    def __init__(
        self,
        calendar_create_user_cnt: str = None,
        recv_calendar_user_cnt_1d: str = None,
        use_calendar_user_cnt_1d: str = None,
    ):
        self.calendar_create_user_cnt = calendar_create_user_cnt
        self.recv_calendar_user_cnt_1d = recv_calendar_user_cnt_1d
        self.use_calendar_user_cnt_1d = use_calendar_user_cnt_1d

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.calendar_create_user_cnt is not None:
            result['calendarCreateUserCnt'] = self.calendar_create_user_cnt
        if self.recv_calendar_user_cnt_1d is not None:
            result['recvCalendarUserCnt1d'] = self.recv_calendar_user_cnt_1d
        if self.use_calendar_user_cnt_1d is not None:
            result['useCalendarUserCnt1d'] = self.use_calendar_user_cnt_1d
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('calendarCreateUserCnt') is not None:
            self.calendar_create_user_cnt = m.get('calendarCreateUserCnt')
        if m.get('recvCalendarUserCnt1d') is not None:
            self.recv_calendar_user_cnt_1d = m.get('recvCalendarUserCnt1d')
        if m.get('useCalendarUserCnt1d') is not None:
            self.use_calendar_user_cnt_1d = m.get('useCalendarUserCnt1d')
        return self


class GetCalenderSummaryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetCalenderSummaryResponseBody = None,
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
            temp_model = GetCalenderSummaryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetCommentListHeaders(TeaModel):
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


class GetCommentListRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
    ):
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
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


class GetCommentListResponseBodyData(TeaModel):
    def __init__(
        self,
        comment_id: str = None,
        comment_time: float = None,
        comment_user_name: str = None,
        content: str = None,
    ):
        self.comment_id = comment_id
        self.comment_time = comment_time
        self.comment_user_name = comment_user_name
        self.content = content

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.comment_id is not None:
            result['commentId'] = self.comment_id
        if self.comment_time is not None:
            result['commentTime'] = self.comment_time
        if self.comment_user_name is not None:
            result['commentUserName'] = self.comment_user_name
        if self.content is not None:
            result['content'] = self.content
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commentId') is not None:
            self.comment_id = m.get('commentId')
        if m.get('commentTime') is not None:
            self.comment_time = m.get('commentTime')
        if m.get('commentUserName') is not None:
            self.comment_user_name = m.get('commentUserName')
        if m.get('content') is not None:
            self.content = m.get('content')
        return self


class GetCommentListResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetCommentListResponseBodyData] = None,
        total_count: int = None,
    ):
        # This parameter is required.
        self.data = data
        # This parameter is required.
        self.total_count = total_count

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
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetCommentListResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class GetCommentListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetCommentListResponseBody = None,
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
            temp_model = GetCommentListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetConfBaseInfoByLogicalIdHeaders(TeaModel):
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


class GetConfBaseInfoByLogicalIdRequest(TeaModel):
    def __init__(
        self,
        logical_conference_id: str = None,
    ):
        # This parameter is required.
        self.logical_conference_id = logical_conference_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.logical_conference_id is not None:
            result['logicalConferenceId'] = self.logical_conference_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('logicalConferenceId') is not None:
            self.logical_conference_id = m.get('logicalConferenceId')
        return self


class GetConfBaseInfoByLogicalIdResponseBody(TeaModel):
    def __init__(
        self,
        conference_id: str = None,
        logical_conference_id: str = None,
        nickname: str = None,
        start_time: int = None,
        title: str = None,
        union_id: str = None,
    ):
        self.conference_id = conference_id
        self.logical_conference_id = logical_conference_id
        self.nickname = nickname
        self.start_time = start_time
        self.title = title
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conference_id is not None:
            result['conferenceId'] = self.conference_id
        if self.logical_conference_id is not None:
            result['logicalConferenceId'] = self.logical_conference_id
        if self.nickname is not None:
            result['nickname'] = self.nickname
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.title is not None:
            result['title'] = self.title
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conferenceId') is not None:
            self.conference_id = m.get('conferenceId')
        if m.get('logicalConferenceId') is not None:
            self.logical_conference_id = m.get('logicalConferenceId')
        if m.get('nickname') is not None:
            self.nickname = m.get('nickname')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetConfBaseInfoByLogicalIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetConfBaseInfoByLogicalIdResponseBody = None,
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
            temp_model = GetConfBaseInfoByLogicalIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetConferenceDetailHeaders(TeaModel):
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


class GetConferenceDetailResponseBodyMemberList(TeaModel):
    def __init__(
        self,
        attend_duration: float = None,
        name: str = None,
        staff_id: str = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.attend_duration = attend_duration
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.staff_id = staff_id
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.attend_duration is not None:
            result['attendDuration'] = self.attend_duration
        if self.name is not None:
            result['name'] = self.name
        if self.staff_id is not None:
            result['staffId'] = self.staff_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('attendDuration') is not None:
            self.attend_duration = m.get('attendDuration')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('staffId') is not None:
            self.staff_id = m.get('staffId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetConferenceDetailResponseBody(TeaModel):
    def __init__(
        self,
        attendee_num: int = None,
        attendee_percentage: str = None,
        caller_id: str = None,
        caller_name: str = None,
        conf_start_time: float = None,
        conference_id: str = None,
        duration: float = None,
        member_list: List[GetConferenceDetailResponseBodyMemberList] = None,
        title: str = None,
        total_num: int = None,
    ):
        self.attendee_num = attendee_num
        self.attendee_percentage = attendee_percentage
        self.caller_id = caller_id
        self.caller_name = caller_name
        self.conf_start_time = conf_start_time
        self.conference_id = conference_id
        self.duration = duration
        self.member_list = member_list
        self.title = title
        self.total_num = total_num

    def validate(self):
        if self.member_list:
            for k in self.member_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.attendee_num is not None:
            result['attendeeNum'] = self.attendee_num
        if self.attendee_percentage is not None:
            result['attendeePercentage'] = self.attendee_percentage
        if self.caller_id is not None:
            result['callerId'] = self.caller_id
        if self.caller_name is not None:
            result['callerName'] = self.caller_name
        if self.conf_start_time is not None:
            result['confStartTime'] = self.conf_start_time
        if self.conference_id is not None:
            result['conferenceId'] = self.conference_id
        if self.duration is not None:
            result['duration'] = self.duration
        result['memberList'] = []
        if self.member_list is not None:
            for k in self.member_list:
                result['memberList'].append(k.to_map() if k else None)
        if self.title is not None:
            result['title'] = self.title
        if self.total_num is not None:
            result['totalNum'] = self.total_num
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('attendeeNum') is not None:
            self.attendee_num = m.get('attendeeNum')
        if m.get('attendeePercentage') is not None:
            self.attendee_percentage = m.get('attendeePercentage')
        if m.get('callerId') is not None:
            self.caller_id = m.get('callerId')
        if m.get('callerName') is not None:
            self.caller_name = m.get('callerName')
        if m.get('confStartTime') is not None:
            self.conf_start_time = m.get('confStartTime')
        if m.get('conferenceId') is not None:
            self.conference_id = m.get('conferenceId')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        self.member_list = []
        if m.get('memberList') is not None:
            for k in m.get('memberList'):
                temp_model = GetConferenceDetailResponseBodyMemberList()
                self.member_list.append(temp_model.from_map(k))
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('totalNum') is not None:
            self.total_num = m.get('totalNum')
        return self


class GetConferenceDetailResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetConferenceDetailResponseBody = None,
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
            temp_model = GetConferenceDetailResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetConversationCategoryHeaders(TeaModel):
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


class GetConversationCategoryResponseBody(TeaModel):
    def __init__(
        self,
        result: List[ConversationCategoryModel] = None,
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
                temp_model = ConversationCategoryModel()
                self.result.append(temp_model.from_map(k))
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetConversationCategoryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetConversationCategoryResponseBody = None,
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
            temp_model = GetConversationCategoryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetConversationDetailHeaders(TeaModel):
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


class GetConversationDetailRequest(TeaModel):
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


class GetConversationDetailResponseBodyResultMultipleCategoryList(TeaModel):
    def __init__(
        self,
        category_id: int = None,
        category_name: str = None,
        order: int = None,
    ):
        self.category_id = category_id
        self.category_name = category_name
        self.order = order

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.category_id is not None:
            result['categoryId'] = self.category_id
        if self.category_name is not None:
            result['categoryName'] = self.category_name
        if self.order is not None:
            result['order'] = self.order
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('categoryId') is not None:
            self.category_id = m.get('categoryId')
        if m.get('categoryName') is not None:
            self.category_name = m.get('categoryName')
        if m.get('order') is not None:
            self.order = m.get('order')
        return self


class GetConversationDetailResponseBodyResult(TeaModel):
    def __init__(
        self,
        category_id: int = None,
        category_name: str = None,
        group_code: str = None,
        group_members_cnt: int = None,
        group_name: str = None,
        group_owner_name: str = None,
        group_owner_user_id: str = None,
        is_kp_conversation: bool = None,
        manage_sign: int = None,
        multiple_category_list: List[GetConversationDetailResponseBodyResultMultipleCategoryList] = None,
        open_conversation_id: str = None,
        order: int = None,
        status: int = None,
    ):
        self.category_id = category_id
        self.category_name = category_name
        self.group_code = group_code
        self.group_members_cnt = group_members_cnt
        self.group_name = group_name
        self.group_owner_name = group_owner_name
        self.group_owner_user_id = group_owner_user_id
        self.is_kp_conversation = is_kp_conversation
        self.manage_sign = manage_sign
        self.multiple_category_list = multiple_category_list
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        self.order = order
        self.status = status

    def validate(self):
        if self.multiple_category_list:
            for k in self.multiple_category_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.category_id is not None:
            result['categoryId'] = self.category_id
        if self.category_name is not None:
            result['categoryName'] = self.category_name
        if self.group_code is not None:
            result['groupCode'] = self.group_code
        if self.group_members_cnt is not None:
            result['groupMembersCnt'] = self.group_members_cnt
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.group_owner_name is not None:
            result['groupOwnerName'] = self.group_owner_name
        if self.group_owner_user_id is not None:
            result['groupOwnerUserId'] = self.group_owner_user_id
        if self.is_kp_conversation is not None:
            result['isKpConversation'] = self.is_kp_conversation
        if self.manage_sign is not None:
            result['manageSign'] = self.manage_sign
        result['multipleCategoryList'] = []
        if self.multiple_category_list is not None:
            for k in self.multiple_category_list:
                result['multipleCategoryList'].append(k.to_map() if k else None)
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.order is not None:
            result['order'] = self.order
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('categoryId') is not None:
            self.category_id = m.get('categoryId')
        if m.get('categoryName') is not None:
            self.category_name = m.get('categoryName')
        if m.get('groupCode') is not None:
            self.group_code = m.get('groupCode')
        if m.get('groupMembersCnt') is not None:
            self.group_members_cnt = m.get('groupMembersCnt')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('groupOwnerName') is not None:
            self.group_owner_name = m.get('groupOwnerName')
        if m.get('groupOwnerUserId') is not None:
            self.group_owner_user_id = m.get('groupOwnerUserId')
        if m.get('isKpConversation') is not None:
            self.is_kp_conversation = m.get('isKpConversation')
        if m.get('manageSign') is not None:
            self.manage_sign = m.get('manageSign')
        self.multiple_category_list = []
        if m.get('multipleCategoryList') is not None:
            for k in m.get('multipleCategoryList'):
                temp_model = GetConversationDetailResponseBodyResultMultipleCategoryList()
                self.multiple_category_list.append(temp_model.from_map(k))
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('order') is not None:
            self.order = m.get('order')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class GetConversationDetailResponseBody(TeaModel):
    def __init__(
        self,
        result: GetConversationDetailResponseBodyResult = None,
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
            temp_model = GetConversationDetailResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetConversationDetailResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetConversationDetailResponseBody = None,
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
            temp_model = GetConversationDetailResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetDingReportDeptSummaryHeaders(TeaModel):
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


class GetDingReportDeptSummaryRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: int = None,
    ):
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
        self.next_token = next_token

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class GetDingReportDeptSummaryResponseBodyData(TeaModel):
    def __init__(
        self,
        dept_id: str = None,
        dept_name: str = None,
        ding_report_send_cnt: str = None,
        ding_report_send_usr_cnt: str = None,
    ):
        self.dept_id = dept_id
        self.dept_name = dept_name
        self.ding_report_send_cnt = ding_report_send_cnt
        self.ding_report_send_usr_cnt = ding_report_send_usr_cnt

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.ding_report_send_cnt is not None:
            result['dingReportSendCnt'] = self.ding_report_send_cnt
        if self.ding_report_send_usr_cnt is not None:
            result['dingReportSendUsrCnt'] = self.ding_report_send_usr_cnt
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('dingReportSendCnt') is not None:
            self.ding_report_send_cnt = m.get('dingReportSendCnt')
        if m.get('dingReportSendUsrCnt') is not None:
            self.ding_report_send_usr_cnt = m.get('dingReportSendUsrCnt')
        return self


class GetDingReportDeptSummaryResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetDingReportDeptSummaryResponseBodyData] = None,
        has_more: bool = None,
        next_token: int = None,
    ):
        self.data = data
        self.has_more = has_more
        self.next_token = next_token

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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetDingReportDeptSummaryResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class GetDingReportDeptSummaryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetDingReportDeptSummaryResponseBody = None,
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
            temp_model = GetDingReportDeptSummaryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetDingReportSummaryHeaders(TeaModel):
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


class GetDingReportSummaryResponseBody(TeaModel):
    def __init__(
        self,
        report_comment_user_cnt_1d: str = None,
    ):
        # This parameter is required.
        self.report_comment_user_cnt_1d = report_comment_user_cnt_1d

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.report_comment_user_cnt_1d is not None:
            result['reportCommentUserCnt1d'] = self.report_comment_user_cnt_1d
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('reportCommentUserCnt1d') is not None:
            self.report_comment_user_cnt_1d = m.get('reportCommentUserCnt1d')
        return self


class GetDingReportSummaryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetDingReportSummaryResponseBody = None,
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
            temp_model = GetDingReportSummaryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetDocCreatedDeptSummaryHeaders(TeaModel):
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


class GetDocCreatedDeptSummaryRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: int = None,
    ):
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
        self.next_token = next_token

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class GetDocCreatedDeptSummaryResponseBodyData(TeaModel):
    def __init__(
        self,
        create_doc_user_cnt_1d: str = None,
        dept_id: str = None,
        dept_name: str = None,
        doc_created_cnt: str = None,
    ):
        self.create_doc_user_cnt_1d = create_doc_user_cnt_1d
        self.dept_id = dept_id
        self.dept_name = dept_name
        self.doc_created_cnt = doc_created_cnt

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_doc_user_cnt_1d is not None:
            result['createDocUserCnt1d'] = self.create_doc_user_cnt_1d
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.doc_created_cnt is not None:
            result['docCreatedCnt'] = self.doc_created_cnt
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createDocUserCnt1d') is not None:
            self.create_doc_user_cnt_1d = m.get('createDocUserCnt1d')
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('docCreatedCnt') is not None:
            self.doc_created_cnt = m.get('docCreatedCnt')
        return self


class GetDocCreatedDeptSummaryResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetDocCreatedDeptSummaryResponseBodyData] = None,
        has_more: bool = None,
        next_token: int = None,
    ):
        self.data = data
        self.has_more = has_more
        self.next_token = next_token

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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetDocCreatedDeptSummaryResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class GetDocCreatedDeptSummaryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetDocCreatedDeptSummaryResponseBody = None,
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
            temp_model = GetDocCreatedDeptSummaryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetDocCreatedSummaryHeaders(TeaModel):
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


class GetDocCreatedSummaryResponseBody(TeaModel):
    def __init__(
        self,
        doc_create_user_cnt_1d: str = None,
        doc_created_cnt: str = None,
    ):
        self.doc_create_user_cnt_1d = doc_create_user_cnt_1d
        self.doc_created_cnt = doc_created_cnt

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.doc_create_user_cnt_1d is not None:
            result['docCreateUserCnt1d'] = self.doc_create_user_cnt_1d
        if self.doc_created_cnt is not None:
            result['docCreatedCnt'] = self.doc_created_cnt
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('docCreateUserCnt1d') is not None:
            self.doc_create_user_cnt_1d = m.get('docCreateUserCnt1d')
        if m.get('docCreatedCnt') is not None:
            self.doc_created_cnt = m.get('docCreatedCnt')
        return self


class GetDocCreatedSummaryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetDocCreatedSummaryResponseBody = None,
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
            temp_model = GetDocCreatedSummaryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetExclusiveAccountAllOrgListHeaders(TeaModel):
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


class GetExclusiveAccountAllOrgListRequest(TeaModel):
    def __init__(
        self,
        union_id: str = None,
    ):
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetExclusiveAccountAllOrgListResponseBodyOrgInfoList(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        is_main_org: bool = None,
        logo_url: str = None,
        org_full_name: str = None,
        org_name: str = None,
    ):
        self.corp_id = corp_id
        self.is_main_org = is_main_org
        self.logo_url = logo_url
        self.org_full_name = org_full_name
        self.org_name = org_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.is_main_org is not None:
            result['isMainOrg'] = self.is_main_org
        if self.logo_url is not None:
            result['logoUrl'] = self.logo_url
        if self.org_full_name is not None:
            result['orgFullName'] = self.org_full_name
        if self.org_name is not None:
            result['orgName'] = self.org_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('isMainOrg') is not None:
            self.is_main_org = m.get('isMainOrg')
        if m.get('logoUrl') is not None:
            self.logo_url = m.get('logoUrl')
        if m.get('orgFullName') is not None:
            self.org_full_name = m.get('orgFullName')
        if m.get('orgName') is not None:
            self.org_name = m.get('orgName')
        return self


class GetExclusiveAccountAllOrgListResponseBody(TeaModel):
    def __init__(
        self,
        org_info_list: List[GetExclusiveAccountAllOrgListResponseBodyOrgInfoList] = None,
    ):
        self.org_info_list = org_info_list

    def validate(self):
        if self.org_info_list:
            for k in self.org_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['orgInfoList'] = []
        if self.org_info_list is not None:
            for k in self.org_info_list:
                result['orgInfoList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.org_info_list = []
        if m.get('orgInfoList') is not None:
            for k in m.get('orgInfoList'):
                temp_model = GetExclusiveAccountAllOrgListResponseBodyOrgInfoList()
                self.org_info_list.append(temp_model.from_map(k))
        return self


class GetExclusiveAccountAllOrgListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetExclusiveAccountAllOrgListResponseBody = None,
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
            temp_model = GetExclusiveAccountAllOrgListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetGeneralFormCreatedDeptSummaryHeaders(TeaModel):
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


class GetGeneralFormCreatedDeptSummaryRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: int = None,
    ):
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
        self.next_token = next_token

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class GetGeneralFormCreatedDeptSummaryResponseBodyData(TeaModel):
    def __init__(
        self,
        dept_id: str = None,
        dept_name: str = None,
        general_form_create_cnt_1d: str = None,
        use_general_form_user_cnt_1d: str = None,
    ):
        self.dept_id = dept_id
        self.dept_name = dept_name
        self.general_form_create_cnt_1d = general_form_create_cnt_1d
        self.use_general_form_user_cnt_1d = use_general_form_user_cnt_1d

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.general_form_create_cnt_1d is not None:
            result['generalFormCreateCnt1d'] = self.general_form_create_cnt_1d
        if self.use_general_form_user_cnt_1d is not None:
            result['useGeneralFormUserCnt1d'] = self.use_general_form_user_cnt_1d
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('generalFormCreateCnt1d') is not None:
            self.general_form_create_cnt_1d = m.get('generalFormCreateCnt1d')
        if m.get('useGeneralFormUserCnt1d') is not None:
            self.use_general_form_user_cnt_1d = m.get('useGeneralFormUserCnt1d')
        return self


class GetGeneralFormCreatedDeptSummaryResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetGeneralFormCreatedDeptSummaryResponseBodyData] = None,
        has_more: bool = None,
        next_token: int = None,
    ):
        self.data = data
        self.has_more = has_more
        self.next_token = next_token

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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetGeneralFormCreatedDeptSummaryResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class GetGeneralFormCreatedDeptSummaryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetGeneralFormCreatedDeptSummaryResponseBody = None,
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
            temp_model = GetGeneralFormCreatedDeptSummaryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetGeneralFormCreatedSummaryHeaders(TeaModel):
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


class GetGeneralFormCreatedSummaryResponseBody(TeaModel):
    def __init__(
        self,
        general_form_created_cnt: str = None,
        use_general_form_user_cnt_1d: str = None,
    ):
        self.general_form_created_cnt = general_form_created_cnt
        self.use_general_form_user_cnt_1d = use_general_form_user_cnt_1d

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.general_form_created_cnt is not None:
            result['generalFormCreatedCnt'] = self.general_form_created_cnt
        if self.use_general_form_user_cnt_1d is not None:
            result['useGeneralFormUserCnt1d'] = self.use_general_form_user_cnt_1d
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('generalFormCreatedCnt') is not None:
            self.general_form_created_cnt = m.get('generalFormCreatedCnt')
        if m.get('useGeneralFormUserCnt1d') is not None:
            self.use_general_form_user_cnt_1d = m.get('useGeneralFormUserCnt1d')
        return self


class GetGeneralFormCreatedSummaryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetGeneralFormCreatedSummaryResponseBody = None,
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
            temp_model = GetGeneralFormCreatedSummaryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetGroupActiveInfoHeaders(TeaModel):
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


class GetGroupActiveInfoRequest(TeaModel):
    def __init__(
        self,
        ding_group_id: str = None,
        group_type: int = None,
        page_number: int = None,
        page_size: int = None,
        stat_date: str = None,
    ):
        self.ding_group_id = ding_group_id
        self.group_type = group_type
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
        self.page_size = page_size
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_group_id is not None:
            result['dingGroupId'] = self.ding_group_id
        if self.group_type is not None:
            result['groupType'] = self.group_type
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingGroupId') is not None:
            self.ding_group_id = m.get('dingGroupId')
        if m.get('groupType') is not None:
            self.group_type = m.get('groupType')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class GetGroupActiveInfoResponseBodyData(TeaModel):
    def __init__(
        self,
        ding_group_id: str = None,
        group_create_time: str = None,
        group_create_user_id: str = None,
        group_create_user_name: str = None,
        group_name: str = None,
        group_type: int = None,
        group_user_cnt_1d: int = None,
        open_conv_uv_1d: int = None,
        send_message_cnt_1d: int = None,
        send_message_user_cnt_1d: int = None,
        stat_date: str = None,
    ):
        self.ding_group_id = ding_group_id
        self.group_create_time = group_create_time
        self.group_create_user_id = group_create_user_id
        self.group_create_user_name = group_create_user_name
        self.group_name = group_name
        self.group_type = group_type
        self.group_user_cnt_1d = group_user_cnt_1d
        self.open_conv_uv_1d = open_conv_uv_1d
        self.send_message_cnt_1d = send_message_cnt_1d
        self.send_message_user_cnt_1d = send_message_user_cnt_1d
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_group_id is not None:
            result['dingGroupId'] = self.ding_group_id
        if self.group_create_time is not None:
            result['groupCreateTime'] = self.group_create_time
        if self.group_create_user_id is not None:
            result['groupCreateUserId'] = self.group_create_user_id
        if self.group_create_user_name is not None:
            result['groupCreateUserName'] = self.group_create_user_name
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.group_type is not None:
            result['groupType'] = self.group_type
        if self.group_user_cnt_1d is not None:
            result['groupUserCnt1d'] = self.group_user_cnt_1d
        if self.open_conv_uv_1d is not None:
            result['openConvUv1d'] = self.open_conv_uv_1d
        if self.send_message_cnt_1d is not None:
            result['sendMessageCnt1d'] = self.send_message_cnt_1d
        if self.send_message_user_cnt_1d is not None:
            result['sendMessageUserCnt1d'] = self.send_message_user_cnt_1d
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingGroupId') is not None:
            self.ding_group_id = m.get('dingGroupId')
        if m.get('groupCreateTime') is not None:
            self.group_create_time = m.get('groupCreateTime')
        if m.get('groupCreateUserId') is not None:
            self.group_create_user_id = m.get('groupCreateUserId')
        if m.get('groupCreateUserName') is not None:
            self.group_create_user_name = m.get('groupCreateUserName')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('groupType') is not None:
            self.group_type = m.get('groupType')
        if m.get('groupUserCnt1d') is not None:
            self.group_user_cnt_1d = m.get('groupUserCnt1d')
        if m.get('openConvUv1d') is not None:
            self.open_conv_uv_1d = m.get('openConvUv1d')
        if m.get('sendMessageCnt1d') is not None:
            self.send_message_cnt_1d = m.get('sendMessageCnt1d')
        if m.get('sendMessageUserCnt1d') is not None:
            self.send_message_user_cnt_1d = m.get('sendMessageUserCnt1d')
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class GetGroupActiveInfoResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetGroupActiveInfoResponseBodyData] = None,
        total_count: int = None,
    ):
        # This parameter is required.
        self.data = data
        # This parameter is required.
        self.total_count = total_count

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
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetGroupActiveInfoResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class GetGroupActiveInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetGroupActiveInfoResponseBody = None,
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
            temp_model = GetGroupActiveInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetInActiveUserListHeaders(TeaModel):
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


class GetInActiveUserListRequest(TeaModel):
    def __init__(
        self,
        dept_ids: List[str] = None,
        page_number: int = None,
        page_size: int = None,
        stat_date: str = None,
    ):
        self.dept_ids = dept_ids
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
        self.page_size = page_size
        # This parameter is required.
        self.stat_date = stat_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_ids is not None:
            result['deptIds'] = self.dept_ids
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptIds') is not None:
            self.dept_ids = m.get('deptIds')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class GetInActiveUserListResponseBodyMetaList(TeaModel):
    def __init__(
        self,
        kpi_caliber: str = None,
        kpi_id: str = None,
        kpi_name: str = None,
        period: str = None,
        unit: str = None,
    ):
        # This parameter is required.
        self.kpi_caliber = kpi_caliber
        # This parameter is required.
        self.kpi_id = kpi_id
        # This parameter is required.
        self.kpi_name = kpi_name
        # This parameter is required.
        self.period = period
        # This parameter is required.
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.kpi_caliber is not None:
            result['kpiCaliber'] = self.kpi_caliber
        if self.kpi_id is not None:
            result['kpiId'] = self.kpi_id
        if self.kpi_name is not None:
            result['kpiName'] = self.kpi_name
        if self.period is not None:
            result['period'] = self.period
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('kpiCaliber') is not None:
            self.kpi_caliber = m.get('kpiCaliber')
        if m.get('kpiId') is not None:
            self.kpi_id = m.get('kpiId')
        if m.get('kpiName') is not None:
            self.kpi_name = m.get('kpiName')
        if m.get('period') is not None:
            self.period = m.get('period')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class GetInActiveUserListResponseBody(TeaModel):
    def __init__(
        self,
        data_list: List[Dict[str, Any]] = None,
        meta_list: List[GetInActiveUserListResponseBodyMetaList] = None,
    ):
        self.data_list = data_list
        self.meta_list = meta_list

    def validate(self):
        if self.meta_list:
            for k in self.meta_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data_list is not None:
            result['dataList'] = self.data_list
        result['metaList'] = []
        if self.meta_list is not None:
            for k in self.meta_list:
                result['metaList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dataList') is not None:
            self.data_list = m.get('dataList')
        self.meta_list = []
        if m.get('metaList') is not None:
            for k in m.get('metaList'):
                temp_model = GetInActiveUserListResponseBodyMetaList()
                self.meta_list.append(temp_model.from_map(k))
        return self


class GetInActiveUserListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetInActiveUserListResponseBody = None,
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
            temp_model = GetInActiveUserListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetLastOrgAuthDataHeaders(TeaModel):
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


class GetLastOrgAuthDataRequest(TeaModel):
    def __init__(
        self,
        target_corp_id: str = None,
    ):
        # This parameter is required.
        self.target_corp_id = target_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        return self


class GetLastOrgAuthDataResponseBody(TeaModel):
    def __init__(
        self,
        auth_remark: str = None,
        auth_status: int = None,
    ):
        self.auth_remark = auth_remark
        self.auth_status = auth_status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.auth_remark is not None:
            result['authRemark'] = self.auth_remark
        if self.auth_status is not None:
            result['authStatus'] = self.auth_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('authRemark') is not None:
            self.auth_remark = m.get('authRemark')
        if m.get('authStatus') is not None:
            self.auth_status = m.get('authStatus')
        return self


class GetLastOrgAuthDataResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetLastOrgAuthDataResponseBody = None,
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
            temp_model = GetLastOrgAuthDataResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetMsgConfigHeaders(TeaModel):
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


class GetMsgConfigRequestListDynamicAttr(TeaModel):
    def __init__(
        self,
        attr_code: str = None,
        list_attr_options_code: List[str] = None,
    ):
        self.attr_code = attr_code
        self.list_attr_options_code = list_attr_options_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.attr_code is not None:
            result['attrCode'] = self.attr_code
        if self.list_attr_options_code is not None:
            result['listAttrOptionsCode'] = self.list_attr_options_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('attrCode') is not None:
            self.attr_code = m.get('attrCode')
        if m.get('listAttrOptionsCode') is not None:
            self.list_attr_options_code = m.get('listAttrOptionsCode')
        return self


class GetMsgConfigRequest(TeaModel):
    def __init__(
        self,
        group_topic: str = None,
        group_type: str = None,
        list_dynamic_attr: List[GetMsgConfigRequestListDynamicAttr] = None,
        list_employee_code: List[str] = None,
        list_unit_id: List[int] = None,
        owner_job_no: str = None,
        rule_business_code: str = None,
        rule_category: int = None,
        rule_code: str = None,
        secret_key: str = None,
        sys_code: str = None,
    ):
        self.group_topic = group_topic
        self.group_type = group_type
        self.list_dynamic_attr = list_dynamic_attr
        self.list_employee_code = list_employee_code
        self.list_unit_id = list_unit_id
        self.owner_job_no = owner_job_no
        self.rule_business_code = rule_business_code
        self.rule_category = rule_category
        self.rule_code = rule_code
        # This parameter is required.
        self.secret_key = secret_key
        self.sys_code = sys_code

    def validate(self):
        if self.list_dynamic_attr:
            for k in self.list_dynamic_attr:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_topic is not None:
            result['groupTopic'] = self.group_topic
        if self.group_type is not None:
            result['groupType'] = self.group_type
        result['listDynamicAttr'] = []
        if self.list_dynamic_attr is not None:
            for k in self.list_dynamic_attr:
                result['listDynamicAttr'].append(k.to_map() if k else None)
        if self.list_employee_code is not None:
            result['listEmployeeCode'] = self.list_employee_code
        if self.list_unit_id is not None:
            result['listUnitId'] = self.list_unit_id
        if self.owner_job_no is not None:
            result['ownerJobNo'] = self.owner_job_no
        if self.rule_business_code is not None:
            result['ruleBusinessCode'] = self.rule_business_code
        if self.rule_category is not None:
            result['ruleCategory'] = self.rule_category
        if self.rule_code is not None:
            result['ruleCode'] = self.rule_code
        if self.secret_key is not None:
            result['secretKey'] = self.secret_key
        if self.sys_code is not None:
            result['sysCode'] = self.sys_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupTopic') is not None:
            self.group_topic = m.get('groupTopic')
        if m.get('groupType') is not None:
            self.group_type = m.get('groupType')
        self.list_dynamic_attr = []
        if m.get('listDynamicAttr') is not None:
            for k in m.get('listDynamicAttr'):
                temp_model = GetMsgConfigRequestListDynamicAttr()
                self.list_dynamic_attr.append(temp_model.from_map(k))
        if m.get('listEmployeeCode') is not None:
            self.list_employee_code = m.get('listEmployeeCode')
        if m.get('listUnitId') is not None:
            self.list_unit_id = m.get('listUnitId')
        if m.get('ownerJobNo') is not None:
            self.owner_job_no = m.get('ownerJobNo')
        if m.get('ruleBusinessCode') is not None:
            self.rule_business_code = m.get('ruleBusinessCode')
        if m.get('ruleCategory') is not None:
            self.rule_category = m.get('ruleCategory')
        if m.get('ruleCode') is not None:
            self.rule_code = m.get('ruleCode')
        if m.get('secretKey') is not None:
            self.secret_key = m.get('secretKey')
        if m.get('sysCode') is not None:
            self.sys_code = m.get('sysCode')
        return self


class GetMsgConfigResponseBodyDataGroupAttributesListDynamicAttr(TeaModel):
    def __init__(
        self,
        attr_code: str = None,
        list_attr_options_code: List[str] = None,
    ):
        self.attr_code = attr_code
        self.list_attr_options_code = list_attr_options_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.attr_code is not None:
            result['attrCode'] = self.attr_code
        if self.list_attr_options_code is not None:
            result['listAttrOptionsCode'] = self.list_attr_options_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('attrCode') is not None:
            self.attr_code = m.get('attrCode')
        if m.get('listAttrOptionsCode') is not None:
            self.list_attr_options_code = m.get('listAttrOptionsCode')
        return self


class GetMsgConfigResponseBodyDataGroupAttributesListReceiver(TeaModel):
    def __init__(
        self,
        employee_code: str = None,
        employee_name: str = None,
    ):
        self.employee_code = employee_code
        self.employee_name = employee_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.employee_code is not None:
            result['employeeCode'] = self.employee_code
        if self.employee_name is not None:
            result['employeeName'] = self.employee_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('employeeCode') is not None:
            self.employee_code = m.get('employeeCode')
        if m.get('employeeName') is not None:
            self.employee_name = m.get('employeeName')
        return self


class GetMsgConfigResponseBodyDataGroupAttributes(TeaModel):
    def __init__(
        self,
        config_group_id: int = None,
        corp_id: str = None,
        group_topic: str = None,
        group_type: str = None,
        list_dynamic_attr: List[GetMsgConfigResponseBodyDataGroupAttributesListDynamicAttr] = None,
        list_receiver: List[GetMsgConfigResponseBodyDataGroupAttributesListReceiver] = None,
        open_conversation_id: str = None,
        owner_job_no: str = None,
        sub_rule_code: str = None,
    ):
        self.config_group_id = config_group_id
        self.corp_id = corp_id
        self.group_topic = group_topic
        self.group_type = group_type
        self.list_dynamic_attr = list_dynamic_attr
        self.list_receiver = list_receiver
        self.open_conversation_id = open_conversation_id
        self.owner_job_no = owner_job_no
        self.sub_rule_code = sub_rule_code

    def validate(self):
        if self.list_dynamic_attr:
            for k in self.list_dynamic_attr:
                if k:
                    k.validate()
        if self.list_receiver:
            for k in self.list_receiver:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.config_group_id is not None:
            result['configGroupId'] = self.config_group_id
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.group_topic is not None:
            result['groupTopic'] = self.group_topic
        if self.group_type is not None:
            result['groupType'] = self.group_type
        result['listDynamicAttr'] = []
        if self.list_dynamic_attr is not None:
            for k in self.list_dynamic_attr:
                result['listDynamicAttr'].append(k.to_map() if k else None)
        result['listReceiver'] = []
        if self.list_receiver is not None:
            for k in self.list_receiver:
                result['listReceiver'].append(k.to_map() if k else None)
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.owner_job_no is not None:
            result['ownerJobNo'] = self.owner_job_no
        if self.sub_rule_code is not None:
            result['subRuleCode'] = self.sub_rule_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('configGroupId') is not None:
            self.config_group_id = m.get('configGroupId')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('groupTopic') is not None:
            self.group_topic = m.get('groupTopic')
        if m.get('groupType') is not None:
            self.group_type = m.get('groupType')
        self.list_dynamic_attr = []
        if m.get('listDynamicAttr') is not None:
            for k in m.get('listDynamicAttr'):
                temp_model = GetMsgConfigResponseBodyDataGroupAttributesListDynamicAttr()
                self.list_dynamic_attr.append(temp_model.from_map(k))
        self.list_receiver = []
        if m.get('listReceiver') is not None:
            for k in m.get('listReceiver'):
                temp_model = GetMsgConfigResponseBodyDataGroupAttributesListReceiver()
                self.list_receiver.append(temp_model.from_map(k))
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('ownerJobNo') is not None:
            self.owner_job_no = m.get('ownerJobNo')
        if m.get('subRuleCode') is not None:
            self.sub_rule_code = m.get('subRuleCode')
        return self


class GetMsgConfigResponseBodyDataMsgConfigs(TeaModel):
    def __init__(
        self,
        card_id: str = None,
        corp_id: str = None,
        custom_parameters: str = None,
        msg_content_consis_flag: int = None,
        msg_id: str = None,
        robot_code: str = None,
        rule_business_code: str = None,
        rule_category: int = None,
        rule_code: str = None,
        rule_name: str = None,
        sub_rule_code: str = None,
        system_code: str = None,
        task_batch_no: str = None,
    ):
        self.card_id = card_id
        self.corp_id = corp_id
        self.custom_parameters = custom_parameters
        self.msg_content_consis_flag = msg_content_consis_flag
        self.msg_id = msg_id
        self.robot_code = robot_code
        self.rule_business_code = rule_business_code
        self.rule_category = rule_category
        self.rule_code = rule_code
        self.rule_name = rule_name
        self.sub_rule_code = sub_rule_code
        self.system_code = system_code
        self.task_batch_no = task_batch_no

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.card_id is not None:
            result['cardId'] = self.card_id
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.custom_parameters is not None:
            result['customParameters'] = self.custom_parameters
        if self.msg_content_consis_flag is not None:
            result['msgContentConsisFlag'] = self.msg_content_consis_flag
        if self.msg_id is not None:
            result['msgId'] = self.msg_id
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        if self.rule_business_code is not None:
            result['ruleBusinessCode'] = self.rule_business_code
        if self.rule_category is not None:
            result['ruleCategory'] = self.rule_category
        if self.rule_code is not None:
            result['ruleCode'] = self.rule_code
        if self.rule_name is not None:
            result['ruleName'] = self.rule_name
        if self.sub_rule_code is not None:
            result['subRuleCode'] = self.sub_rule_code
        if self.system_code is not None:
            result['systemCode'] = self.system_code
        if self.task_batch_no is not None:
            result['taskBatchNo'] = self.task_batch_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cardId') is not None:
            self.card_id = m.get('cardId')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('customParameters') is not None:
            self.custom_parameters = m.get('customParameters')
        if m.get('msgContentConsisFlag') is not None:
            self.msg_content_consis_flag = m.get('msgContentConsisFlag')
        if m.get('msgId') is not None:
            self.msg_id = m.get('msgId')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        if m.get('ruleBusinessCode') is not None:
            self.rule_business_code = m.get('ruleBusinessCode')
        if m.get('ruleCategory') is not None:
            self.rule_category = m.get('ruleCategory')
        if m.get('ruleCode') is not None:
            self.rule_code = m.get('ruleCode')
        if m.get('ruleName') is not None:
            self.rule_name = m.get('ruleName')
        if m.get('subRuleCode') is not None:
            self.sub_rule_code = m.get('subRuleCode')
        if m.get('systemCode') is not None:
            self.system_code = m.get('systemCode')
        if m.get('taskBatchNo') is not None:
            self.task_batch_no = m.get('taskBatchNo')
        return self


class GetMsgConfigResponseBodyDataReceiverAttributes(TeaModel):
    def __init__(
        self,
        employee_code: str = None,
    ):
        self.employee_code = employee_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.employee_code is not None:
            result['employeeCode'] = self.employee_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('employeeCode') is not None:
            self.employee_code = m.get('employeeCode')
        return self


class GetMsgConfigResponseBodyDataUnitAttributes(TeaModel):
    def __init__(
        self,
        unit_id: int = None,
    ):
        self.unit_id = unit_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.unit_id is not None:
            result['unitId'] = self.unit_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('unitId') is not None:
            self.unit_id = m.get('unitId')
        return self


class GetMsgConfigResponseBodyData(TeaModel):
    def __init__(
        self,
        group_attributes: List[GetMsgConfigResponseBodyDataGroupAttributes] = None,
        msg_configs: GetMsgConfigResponseBodyDataMsgConfigs = None,
        receiver_attributes: List[GetMsgConfigResponseBodyDataReceiverAttributes] = None,
        unit_attributes: List[GetMsgConfigResponseBodyDataUnitAttributes] = None,
    ):
        self.group_attributes = group_attributes
        self.msg_configs = msg_configs
        self.receiver_attributes = receiver_attributes
        self.unit_attributes = unit_attributes

    def validate(self):
        if self.group_attributes:
            for k in self.group_attributes:
                if k:
                    k.validate()
        if self.msg_configs:
            self.msg_configs.validate()
        if self.receiver_attributes:
            for k in self.receiver_attributes:
                if k:
                    k.validate()
        if self.unit_attributes:
            for k in self.unit_attributes:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['groupAttributes'] = []
        if self.group_attributes is not None:
            for k in self.group_attributes:
                result['groupAttributes'].append(k.to_map() if k else None)
        if self.msg_configs is not None:
            result['msgConfigs'] = self.msg_configs.to_map()
        result['receiverAttributes'] = []
        if self.receiver_attributes is not None:
            for k in self.receiver_attributes:
                result['receiverAttributes'].append(k.to_map() if k else None)
        result['unitAttributes'] = []
        if self.unit_attributes is not None:
            for k in self.unit_attributes:
                result['unitAttributes'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.group_attributes = []
        if m.get('groupAttributes') is not None:
            for k in m.get('groupAttributes'):
                temp_model = GetMsgConfigResponseBodyDataGroupAttributes()
                self.group_attributes.append(temp_model.from_map(k))
        if m.get('msgConfigs') is not None:
            temp_model = GetMsgConfigResponseBodyDataMsgConfigs()
            self.msg_configs = temp_model.from_map(m['msgConfigs'])
        self.receiver_attributes = []
        if m.get('receiverAttributes') is not None:
            for k in m.get('receiverAttributes'):
                temp_model = GetMsgConfigResponseBodyDataReceiverAttributes()
                self.receiver_attributes.append(temp_model.from_map(k))
        self.unit_attributes = []
        if m.get('unitAttributes') is not None:
            for k in m.get('unitAttributes'):
                temp_model = GetMsgConfigResponseBodyDataUnitAttributes()
                self.unit_attributes.append(temp_model.from_map(k))
        return self


class GetMsgConfigResponseBody(TeaModel):
    def __init__(
        self,
        code: int = None,
        data: GetMsgConfigResponseBodyData = None,
        message: str = None,
    ):
        self.code = code
        self.data = data
        self.message = message

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.message is not None:
            result['message'] = self.message
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('data') is not None:
            temp_model = GetMsgConfigResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('message') is not None:
            self.message = m.get('message')
        return self


class GetMsgConfigResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetMsgConfigResponseBody = None,
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
            temp_model = GetMsgConfigResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetMsgLocationHeaders(TeaModel):
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


class GetMsgLocationRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        open_msg_id: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.open_msg_id = open_msg_id
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
        if self.open_msg_id is not None:
            result['openMsgId'] = self.open_msg_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('openMsgId') is not None:
            self.open_msg_id = m.get('openMsgId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetMsgLocationResponseBody(TeaModel):
    def __init__(
        self,
        msg_location_url: str = None,
    ):
        self.msg_location_url = msg_location_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.msg_location_url is not None:
            result['msgLocationUrl'] = self.msg_location_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('msgLocationUrl') is not None:
            self.msg_location_url = m.get('msgLocationUrl')
        return self


class GetMsgLocationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetMsgLocationResponseBody = None,
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
            temp_model = GetMsgLocationResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetOaOperatorLogListHeaders(TeaModel):
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


class GetOaOperatorLogListRequest(TeaModel):
    def __init__(
        self,
        category_list: List[str] = None,
        end_time: int = None,
        op_user_id: str = None,
        page_number: int = None,
        page_size: int = None,
        start_time: int = None,
    ):
        self.category_list = category_list
        # This parameter is required.
        self.end_time = end_time
        self.op_user_id = op_user_id
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
        self.page_size = page_size
        # This parameter is required.
        self.start_time = start_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.category_list is not None:
            result['categoryList'] = self.category_list
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.start_time is not None:
            result['startTime'] = self.start_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('categoryList') is not None:
            self.category_list = m.get('categoryList')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        return self


class GetOaOperatorLogListResponseBodyData(TeaModel):
    def __init__(
        self,
        category_1name: str = None,
        category_2name: str = None,
        content: str = None,
        op_name: str = None,
        op_time: int = None,
        op_user_id: str = None,
    ):
        # This parameter is required.
        self.category_1name = category_1name
        # This parameter is required.
        self.category_2name = category_2name
        # This parameter is required.
        self.content = content
        # This parameter is required.
        self.op_name = op_name
        # This parameter is required.
        self.op_time = op_time
        # This parameter is required.
        self.op_user_id = op_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.category_1name is not None:
            result['category1Name'] = self.category_1name
        if self.category_2name is not None:
            result['category2Name'] = self.category_2name
        if self.content is not None:
            result['content'] = self.content
        if self.op_name is not None:
            result['opName'] = self.op_name
        if self.op_time is not None:
            result['opTime'] = self.op_time
        if self.op_user_id is not None:
            result['opUserId'] = self.op_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('category1Name') is not None:
            self.category_1name = m.get('category1Name')
        if m.get('category2Name') is not None:
            self.category_2name = m.get('category2Name')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('opName') is not None:
            self.op_name = m.get('opName')
        if m.get('opTime') is not None:
            self.op_time = m.get('opTime')
        if m.get('opUserId') is not None:
            self.op_user_id = m.get('opUserId')
        return self


class GetOaOperatorLogListResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetOaOperatorLogListResponseBodyData] = None,
        item_count: int = None,
    ):
        # This parameter is required.
        self.data = data
        # This parameter is required.
        self.item_count = item_count

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
        if self.item_count is not None:
            result['itemCount'] = self.item_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetOaOperatorLogListResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('itemCount') is not None:
            self.item_count = m.get('itemCount')
        return self


class GetOaOperatorLogListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetOaOperatorLogListResponseBody = None,
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
            temp_model = GetOaOperatorLogListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetOutGroupsByPageHeaders(TeaModel):
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


class GetOutGroupsByPageRequest(TeaModel):
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


class GetOutGroupsByPageResponseBodyResponseBodyGroupList(TeaModel):
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


class GetOutGroupsByPageResponseBodyResponseBody(TeaModel):
    def __init__(
        self,
        group_list: List[GetOutGroupsByPageResponseBodyResponseBodyGroupList] = None,
        total: int = None,
    ):
        self.group_list = group_list
        self.total = total

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
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.group_list = []
        if m.get('groupList') is not None:
            for k in m.get('groupList'):
                temp_model = GetOutGroupsByPageResponseBodyResponseBodyGroupList()
                self.group_list.append(temp_model.from_map(k))
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class GetOutGroupsByPageResponseBody(TeaModel):
    def __init__(
        self,
        response_body: GetOutGroupsByPageResponseBodyResponseBody = None,
    ):
        # This parameter is required.
        self.response_body = response_body

    def validate(self):
        if self.response_body:
            self.response_body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.response_body is not None:
            result['responseBody'] = self.response_body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('responseBody') is not None:
            temp_model = GetOutGroupsByPageResponseBodyResponseBody()
            self.response_body = temp_model.from_map(m['responseBody'])
        return self


class GetOutGroupsByPageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetOutGroupsByPageResponseBody = None,
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
            temp_model = GetOutGroupsByPageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetOutsideAuditGroupMessageByPageHeaders(TeaModel):
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


class GetOutsideAuditGroupMessageByPageRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: int = None,
        open_conversation_id: str = None,
    ):
        self.max_results = max_results
        # This parameter is required.
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
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageListSender(TeaModel):
    def __init__(
        self,
        id: str = None,
        id_type: str = None,
        type: str = None,
    ):
        self.id = id
        self.id_type = id_type
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.id_type is not None:
            result['idType'] = self.id_type
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('idType') is not None:
            self.id_type = m.get('idType')
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageList(TeaModel):
    def __init__(
        self,
        content: str = None,
        content_type: str = None,
        create_at: str = None,
        open_conversation_id: str = None,
        sender: GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageListSender = None,
    ):
        self.content = content
        self.content_type = content_type
        self.create_at = create_at
        self.open_conversation_id = open_conversation_id
        self.sender = sender

    def validate(self):
        if self.sender:
            self.sender.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.content_type is not None:
            result['contentType'] = self.content_type
        if self.create_at is not None:
            result['createAt'] = self.create_at
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.sender is not None:
            result['sender'] = self.sender.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('contentType') is not None:
            self.content_type = m.get('contentType')
        if m.get('createAt') is not None:
            self.create_at = m.get('createAt')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('sender') is not None:
            temp_model = GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageListSender()
            self.sender = temp_model.from_map(m['sender'])
        return self


class GetOutsideAuditGroupMessageByPageResponseBodyResponseBody(TeaModel):
    def __init__(
        self,
        message_list: List[GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageList] = None,
        next_token: str = None,
    ):
        self.message_list = message_list
        self.next_token = next_token

    def validate(self):
        if self.message_list:
            for k in self.message_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['messageList'] = []
        if self.message_list is not None:
            for k in self.message_list:
                result['messageList'].append(k.to_map() if k else None)
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.message_list = []
        if m.get('messageList') is not None:
            for k in m.get('messageList'):
                temp_model = GetOutsideAuditGroupMessageByPageResponseBodyResponseBodyMessageList()
                self.message_list.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class GetOutsideAuditGroupMessageByPageResponseBody(TeaModel):
    def __init__(
        self,
        response_body: GetOutsideAuditGroupMessageByPageResponseBodyResponseBody = None,
    ):
        # This parameter is required.
        self.response_body = response_body

    def validate(self):
        if self.response_body:
            self.response_body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.response_body is not None:
            result['responseBody'] = self.response_body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('responseBody') is not None:
            temp_model = GetOutsideAuditGroupMessageByPageResponseBodyResponseBody()
            self.response_body = temp_model.from_map(m['responseBody'])
        return self


class GetOutsideAuditGroupMessageByPageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetOutsideAuditGroupMessageByPageResponseBody = None,
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
            temp_model = GetOutsideAuditGroupMessageByPageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetPartnerTypeByParentIdHeaders(TeaModel):
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


class GetPartnerTypeByParentIdResponseBodyData(TeaModel):
    def __init__(
        self,
        label_id: str = None,
        type_id: float = None,
        type_name: str = None,
    ):
        # This parameter is required.
        self.label_id = label_id
        # This parameter is required.
        self.type_id = type_id
        # This parameter is required.
        self.type_name = type_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.label_id is not None:
            result['labelId'] = self.label_id
        if self.type_id is not None:
            result['typeId'] = self.type_id
        if self.type_name is not None:
            result['typeName'] = self.type_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('labelId') is not None:
            self.label_id = m.get('labelId')
        if m.get('typeId') is not None:
            self.type_id = m.get('typeId')
        if m.get('typeName') is not None:
            self.type_name = m.get('typeName')
        return self


class GetPartnerTypeByParentIdResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetPartnerTypeByParentIdResponseBodyData] = None,
    ):
        # This parameter is required.
        self.data = data

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetPartnerTypeByParentIdResponseBodyData()
                self.data.append(temp_model.from_map(k))
        return self


class GetPartnerTypeByParentIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetPartnerTypeByParentIdResponseBody = None,
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
            temp_model = GetPartnerTypeByParentIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetPublicDevicesHeaders(TeaModel):
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


class GetPublicDevicesRequest(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        mac_address: str = None,
        page_number: int = None,
        page_size: int = None,
        platform: str = None,
        start_time: int = None,
        title: str = None,
    ):
        self.end_time = end_time
        self.mac_address = mac_address
        self.page_number = page_number
        self.page_size = page_size
        self.platform = platform
        self.start_time = start_time
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.mac_address is not None:
            result['macAddress'] = self.mac_address
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.platform is not None:
            result['platform'] = self.platform
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('macAddress') is not None:
            self.mac_address = m.get('macAddress')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('platform') is not None:
            self.platform = m.get('platform')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class GetPublicDevicesResponseBodyDataDeviceDepts(TeaModel):
    def __init__(
        self,
        id: int = None,
        name: str = None,
    ):
        self.id = id
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class GetPublicDevicesResponseBodyDataDeviceRoles(TeaModel):
    def __init__(
        self,
        name: str = None,
        tag_code: str = None,
    ):
        self.name = name
        self.tag_code = tag_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.tag_code is not None:
            result['tagCode'] = self.tag_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('tagCode') is not None:
            self.tag_code = m.get('tagCode')
        return self


class GetPublicDevicesResponseBodyDataDeviceStaffs(TeaModel):
    def __init__(
        self,
        name: str = None,
        user_id: str = None,
    ):
        self.name = name
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetPublicDevicesResponseBodyData(TeaModel):
    def __init__(
        self,
        device_depts: List[GetPublicDevicesResponseBodyDataDeviceDepts] = None,
        device_roles: List[GetPublicDevicesResponseBodyDataDeviceRoles] = None,
        device_scope_type: int = None,
        device_staffs: List[GetPublicDevicesResponseBodyDataDeviceStaffs] = None,
        gmt_create: int = None,
        gmt_modified: int = None,
        mac_address: str = None,
        platform: str = None,
        title: str = None,
    ):
        self.device_depts = device_depts
        self.device_roles = device_roles
        self.device_scope_type = device_scope_type
        self.device_staffs = device_staffs
        self.gmt_create = gmt_create
        self.gmt_modified = gmt_modified
        self.mac_address = mac_address
        self.platform = platform
        self.title = title

    def validate(self):
        if self.device_depts:
            for k in self.device_depts:
                if k:
                    k.validate()
        if self.device_roles:
            for k in self.device_roles:
                if k:
                    k.validate()
        if self.device_staffs:
            for k in self.device_staffs:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['deviceDepts'] = []
        if self.device_depts is not None:
            for k in self.device_depts:
                result['deviceDepts'].append(k.to_map() if k else None)
        result['deviceRoles'] = []
        if self.device_roles is not None:
            for k in self.device_roles:
                result['deviceRoles'].append(k.to_map() if k else None)
        if self.device_scope_type is not None:
            result['deviceScopeType'] = self.device_scope_type
        result['deviceStaffs'] = []
        if self.device_staffs is not None:
            for k in self.device_staffs:
                result['deviceStaffs'].append(k.to_map() if k else None)
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.mac_address is not None:
            result['macAddress'] = self.mac_address
        if self.platform is not None:
            result['platform'] = self.platform
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.device_depts = []
        if m.get('deviceDepts') is not None:
            for k in m.get('deviceDepts'):
                temp_model = GetPublicDevicesResponseBodyDataDeviceDepts()
                self.device_depts.append(temp_model.from_map(k))
        self.device_roles = []
        if m.get('deviceRoles') is not None:
            for k in m.get('deviceRoles'):
                temp_model = GetPublicDevicesResponseBodyDataDeviceRoles()
                self.device_roles.append(temp_model.from_map(k))
        if m.get('deviceScopeType') is not None:
            self.device_scope_type = m.get('deviceScopeType')
        self.device_staffs = []
        if m.get('deviceStaffs') is not None:
            for k in m.get('deviceStaffs'):
                temp_model = GetPublicDevicesResponseBodyDataDeviceStaffs()
                self.device_staffs.append(temp_model.from_map(k))
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('macAddress') is not None:
            self.mac_address = m.get('macAddress')
        if m.get('platform') is not None:
            self.platform = m.get('platform')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class GetPublicDevicesResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetPublicDevicesResponseBodyData] = None,
        data_cnt: int = None,
        total_cnt: int = None,
    ):
        self.data = data
        self.data_cnt = data_cnt
        self.total_cnt = total_cnt

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
        if self.data_cnt is not None:
            result['dataCnt'] = self.data_cnt
        if self.total_cnt is not None:
            result['totalCnt'] = self.total_cnt
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetPublicDevicesResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('dataCnt') is not None:
            self.data_cnt = m.get('dataCnt')
        if m.get('totalCnt') is not None:
            self.total_cnt = m.get('totalCnt')
        return self


class GetPublicDevicesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetPublicDevicesResponseBody = None,
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
            temp_model = GetPublicDevicesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetPublisherSummaryHeaders(TeaModel):
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


class GetPublisherSummaryRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: int = None,
    ):
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
        self.next_token = next_token

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class GetPublisherSummaryResponseBodyData(TeaModel):
    def __init__(
        self,
        publisher_article_cnt_std: str = None,
        publisher_article_pv_cnt_std: str = None,
        publisher_name: str = None,
        union_id: str = None,
    ):
        self.publisher_article_cnt_std = publisher_article_cnt_std
        self.publisher_article_pv_cnt_std = publisher_article_pv_cnt_std
        self.publisher_name = publisher_name
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.publisher_article_cnt_std is not None:
            result['publisherArticleCntStd'] = self.publisher_article_cnt_std
        if self.publisher_article_pv_cnt_std is not None:
            result['publisherArticlePvCntStd'] = self.publisher_article_pv_cnt_std
        if self.publisher_name is not None:
            result['publisherName'] = self.publisher_name
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('publisherArticleCntStd') is not None:
            self.publisher_article_cnt_std = m.get('publisherArticleCntStd')
        if m.get('publisherArticlePvCntStd') is not None:
            self.publisher_article_pv_cnt_std = m.get('publisherArticlePvCntStd')
        if m.get('publisherName') is not None:
            self.publisher_name = m.get('publisherName')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetPublisherSummaryResponseBodyPublisherArticlePvTop5(TeaModel):
    def __init__(
        self,
        name: str = None,
    ):
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class GetPublisherSummaryResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetPublisherSummaryResponseBodyData] = None,
        has_more: bool = None,
        next_token: int = None,
        publisher_article_cnt_std: str = None,
        publisher_article_pv_cnt_std: str = None,
        publisher_article_pv_top_5: List[GetPublisherSummaryResponseBodyPublisherArticlePvTop5] = None,
        publisher_cnt_std: str = None,
    ):
        self.data = data
        self.has_more = has_more
        self.next_token = next_token
        self.publisher_article_cnt_std = publisher_article_cnt_std
        self.publisher_article_pv_cnt_std = publisher_article_pv_cnt_std
        self.publisher_article_pv_top_5 = publisher_article_pv_top_5
        self.publisher_cnt_std = publisher_cnt_std

    def validate(self):
        if self.data:
            for k in self.data:
                if k:
                    k.validate()
        if self.publisher_article_pv_top_5:
            for k in self.publisher_article_pv_top_5:
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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.publisher_article_cnt_std is not None:
            result['publisherArticleCntStd'] = self.publisher_article_cnt_std
        if self.publisher_article_pv_cnt_std is not None:
            result['publisherArticlePvCntStd'] = self.publisher_article_pv_cnt_std
        result['publisherArticlePvTop5'] = []
        if self.publisher_article_pv_top_5 is not None:
            for k in self.publisher_article_pv_top_5:
                result['publisherArticlePvTop5'].append(k.to_map() if k else None)
        if self.publisher_cnt_std is not None:
            result['publisherCntStd'] = self.publisher_cnt_std
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetPublisherSummaryResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('publisherArticleCntStd') is not None:
            self.publisher_article_cnt_std = m.get('publisherArticleCntStd')
        if m.get('publisherArticlePvCntStd') is not None:
            self.publisher_article_pv_cnt_std = m.get('publisherArticlePvCntStd')
        self.publisher_article_pv_top_5 = []
        if m.get('publisherArticlePvTop5') is not None:
            for k in m.get('publisherArticlePvTop5'):
                temp_model = GetPublisherSummaryResponseBodyPublisherArticlePvTop5()
                self.publisher_article_pv_top_5.append(temp_model.from_map(k))
        if m.get('publisherCntStd') is not None:
            self.publisher_cnt_std = m.get('publisherCntStd')
        return self


class GetPublisherSummaryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetPublisherSummaryResponseBody = None,
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
            temp_model = GetPublisherSummaryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetRealPeopleRecordsHeaders(TeaModel):
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


class GetRealPeopleRecordsRequest(TeaModel):
    def __init__(
        self,
        agent_id: int = None,
        from_time: int = None,
        max_results: int = None,
        next_token: int = None,
        person_identification: int = None,
        scene: int = None,
        to_time: int = None,
        user_ids: List[str] = None,
    ):
        self.agent_id = agent_id
        self.from_time = from_time
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
        self.next_token = next_token
        self.person_identification = person_identification
        self.scene = scene
        self.to_time = to_time
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        if self.from_time is not None:
            result['fromTime'] = self.from_time
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.person_identification is not None:
            result['personIdentification'] = self.person_identification
        if self.scene is not None:
            result['scene'] = self.scene
        if self.to_time is not None:
            result['toTime'] = self.to_time
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        if m.get('fromTime') is not None:
            self.from_time = m.get('fromTime')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('personIdentification') is not None:
            self.person_identification = m.get('personIdentification')
        if m.get('scene') is not None:
            self.scene = m.get('scene')
        if m.get('toTime') is not None:
            self.to_time = m.get('toTime')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class GetRealPeopleRecordsResponseBodyData(TeaModel):
    def __init__(
        self,
        agent_id: int = None,
        invoke_time: int = None,
        person_identification: int = None,
        platform: int = None,
        scene: int = None,
        user_id: str = None,
    ):
        self.agent_id = agent_id
        self.invoke_time = invoke_time
        self.person_identification = person_identification
        self.platform = platform
        self.scene = scene
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        if self.invoke_time is not None:
            result['invokeTime'] = self.invoke_time
        if self.person_identification is not None:
            result['personIdentification'] = self.person_identification
        if self.platform is not None:
            result['platform'] = self.platform
        if self.scene is not None:
            result['scene'] = self.scene
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        if m.get('invokeTime') is not None:
            self.invoke_time = m.get('invokeTime')
        if m.get('personIdentification') is not None:
            self.person_identification = m.get('personIdentification')
        if m.get('platform') is not None:
            self.platform = m.get('platform')
        if m.get('scene') is not None:
            self.scene = m.get('scene')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetRealPeopleRecordsResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetRealPeopleRecordsResponseBodyData] = None,
        next_token: int = None,
        total: int = None,
    ):
        self.data = data
        self.next_token = next_token
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
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetRealPeopleRecordsResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class GetRealPeopleRecordsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetRealPeopleRecordsResponseBody = None,
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
            temp_model = GetRealPeopleRecordsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetRecognizeRecordsHeaders(TeaModel):
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


class GetRecognizeRecordsRequest(TeaModel):
    def __init__(
        self,
        agent_id: int = None,
        face_compare_result: int = None,
        from_time: int = None,
        max_results: int = None,
        next_token: int = None,
        to_time: int = None,
        user_ids: List[str] = None,
    ):
        self.agent_id = agent_id
        self.face_compare_result = face_compare_result
        self.from_time = from_time
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
        self.next_token = next_token
        self.to_time = to_time
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        if self.face_compare_result is not None:
            result['faceCompareResult'] = self.face_compare_result
        if self.from_time is not None:
            result['fromTime'] = self.from_time
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.to_time is not None:
            result['toTime'] = self.to_time
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        if m.get('faceCompareResult') is not None:
            self.face_compare_result = m.get('faceCompareResult')
        if m.get('fromTime') is not None:
            self.from_time = m.get('fromTime')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('toTime') is not None:
            self.to_time = m.get('toTime')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class GetRecognizeRecordsResponseBodyData(TeaModel):
    def __init__(
        self,
        agent_id: int = None,
        face_compare_result: int = None,
        invoke_time: int = None,
        platform: int = None,
        user_id: str = None,
    ):
        self.agent_id = agent_id
        self.face_compare_result = face_compare_result
        self.invoke_time = invoke_time
        self.platform = platform
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        if self.face_compare_result is not None:
            result['faceCompareResult'] = self.face_compare_result
        if self.invoke_time is not None:
            result['invokeTime'] = self.invoke_time
        if self.platform is not None:
            result['platform'] = self.platform
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        if m.get('faceCompareResult') is not None:
            self.face_compare_result = m.get('faceCompareResult')
        if m.get('invokeTime') is not None:
            self.invoke_time = m.get('invokeTime')
        if m.get('platform') is not None:
            self.platform = m.get('platform')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetRecognizeRecordsResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetRecognizeRecordsResponseBodyData] = None,
        next_token: int = None,
        total: int = None,
    ):
        self.data = data
        self.next_token = next_token
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
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetRecognizeRecordsResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class GetRecognizeRecordsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetRecognizeRecordsResponseBody = None,
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
            temp_model = GetRecognizeRecordsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetRobotInfoByCodeHeaders(TeaModel):
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


class GetRobotInfoByCodeRequest(TeaModel):
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


class GetRobotInfoByCodeResponseBodyRobotInfoVO(TeaModel):
    def __init__(
        self,
        agent_id: int = None,
        brief: str = None,
        description: str = None,
        name: str = None,
        robot_organization: int = None,
    ):
        self.agent_id = agent_id
        self.brief = brief
        self.description = description
        self.name = name
        self.robot_organization = robot_organization

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        if self.brief is not None:
            result['brief'] = self.brief
        if self.description is not None:
            result['description'] = self.description
        if self.name is not None:
            result['name'] = self.name
        if self.robot_organization is not None:
            result['robotOrganization'] = self.robot_organization
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        if m.get('brief') is not None:
            self.brief = m.get('brief')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('robotOrganization') is not None:
            self.robot_organization = m.get('robotOrganization')
        return self


class GetRobotInfoByCodeResponseBody(TeaModel):
    def __init__(
        self,
        robot_info_vo: GetRobotInfoByCodeResponseBodyRobotInfoVO = None,
    ):
        self.robot_info_vo = robot_info_vo

    def validate(self):
        if self.robot_info_vo:
            self.robot_info_vo.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.robot_info_vo is not None:
            result['robotInfoVO'] = self.robot_info_vo.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('robotInfoVO') is not None:
            temp_model = GetRobotInfoByCodeResponseBodyRobotInfoVO()
            self.robot_info_vo = temp_model.from_map(m['robotInfoVO'])
        return self


class GetRobotInfoByCodeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetRobotInfoByCodeResponseBody = None,
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
            temp_model = GetRobotInfoByCodeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetSecurityConfigMemberHeaders(TeaModel):
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


class GetSecurityConfigMemberRequest(TeaModel):
    def __init__(
        self,
        config_key: str = None,
        max_results: int = None,
        next_token: float = None,
    ):
        # This parameter is required.
        self.config_key = config_key
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
        self.next_token = next_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.config_key is not None:
            result['configKey'] = self.config_key
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('configKey') is not None:
            self.config_key = m.get('configKey')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class GetSecurityConfigMemberResponseBodyResultUserInfos(TeaModel):
    def __init__(
        self,
        name: str = None,
        user_id: str = None,
    ):
        self.name = name
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetSecurityConfigMemberResponseBodyResult(TeaModel):
    def __init__(
        self,
        has_next: bool = None,
        next_token: float = None,
        scope_type: int = None,
        user_infos: List[GetSecurityConfigMemberResponseBodyResultUserInfos] = None,
    ):
        self.has_next = has_next
        self.next_token = next_token
        self.scope_type = scope_type
        self.user_infos = user_infos

    def validate(self):
        if self.user_infos:
            for k in self.user_infos:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_next is not None:
            result['hasNext'] = self.has_next
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.scope_type is not None:
            result['scopeType'] = self.scope_type
        result['userInfos'] = []
        if self.user_infos is not None:
            for k in self.user_infos:
                result['userInfos'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasNext') is not None:
            self.has_next = m.get('hasNext')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('scopeType') is not None:
            self.scope_type = m.get('scopeType')
        self.user_infos = []
        if m.get('userInfos') is not None:
            for k in m.get('userInfos'):
                temp_model = GetSecurityConfigMemberResponseBodyResultUserInfos()
                self.user_infos.append(temp_model.from_map(k))
        return self


class GetSecurityConfigMemberResponseBody(TeaModel):
    def __init__(
        self,
        result: GetSecurityConfigMemberResponseBodyResult = None,
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
            temp_model = GetSecurityConfigMemberResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetSecurityConfigMemberResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetSecurityConfigMemberResponseBody = None,
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
            temp_model = GetSecurityConfigMemberResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetSignedDetailByPageHeaders(TeaModel):
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


class GetSignedDetailByPageRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        sign_status: int = None,
    ):
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
        self.page_size = page_size
        # This parameter is required.
        self.sign_status = sign_status

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
        if self.sign_status is not None:
            result['signStatus'] = self.sign_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('signStatus') is not None:
            self.sign_status = m.get('signStatus')
        return self


class GetSignedDetailByPageResponseBodyAuditSignedDetailDTOList(TeaModel):
    def __init__(
        self,
        dept_name: str = None,
        email: str = None,
        name: str = None,
        phone: str = None,
        roles: str = None,
        staff_id: str = None,
        title: str = None,
    ):
        self.dept_name = dept_name
        self.email = email
        self.name = name
        self.phone = phone
        self.roles = roles
        self.staff_id = staff_id
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        if self.email is not None:
            result['email'] = self.email
        if self.name is not None:
            result['name'] = self.name
        if self.phone is not None:
            result['phone'] = self.phone
        if self.roles is not None:
            result['roles'] = self.roles
        if self.staff_id is not None:
            result['staffId'] = self.staff_id
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        if m.get('email') is not None:
            self.email = m.get('email')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('phone') is not None:
            self.phone = m.get('phone')
        if m.get('roles') is not None:
            self.roles = m.get('roles')
        if m.get('staffId') is not None:
            self.staff_id = m.get('staffId')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class GetSignedDetailByPageResponseBody(TeaModel):
    def __init__(
        self,
        audit_signed_detail_dtolist: List[GetSignedDetailByPageResponseBodyAuditSignedDetailDTOList] = None,
        current_page: int = None,
        page_size: int = None,
        total: int = None,
    ):
        self.audit_signed_detail_dtolist = audit_signed_detail_dtolist
        self.current_page = current_page
        self.page_size = page_size
        self.total = total

    def validate(self):
        if self.audit_signed_detail_dtolist:
            for k in self.audit_signed_detail_dtolist:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['auditSignedDetailDTOList'] = []
        if self.audit_signed_detail_dtolist is not None:
            for k in self.audit_signed_detail_dtolist:
                result['auditSignedDetailDTOList'].append(k.to_map() if k else None)
        if self.current_page is not None:
            result['currentPage'] = self.current_page
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.audit_signed_detail_dtolist = []
        if m.get('auditSignedDetailDTOList') is not None:
            for k in m.get('auditSignedDetailDTOList'):
                temp_model = GetSignedDetailByPageResponseBodyAuditSignedDetailDTOList()
                self.audit_signed_detail_dtolist.append(temp_model.from_map(k))
        if m.get('currentPage') is not None:
            self.current_page = m.get('currentPage')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class GetSignedDetailByPageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetSignedDetailByPageResponseBody = None,
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
            temp_model = GetSignedDetailByPageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetTrustDeviceListHeaders(TeaModel):
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


class GetTrustDeviceListRequest(TeaModel):
    def __init__(
        self,
        gmt_create_end: int = None,
        gmt_create_start: int = None,
        gmt_modified_end: int = None,
        gmt_modified_start: int = None,
        mac_address: str = None,
        page_number: int = None,
        page_size: int = None,
        platform: str = None,
        status: int = None,
        user_ids: List[str] = None,
    ):
        self.gmt_create_end = gmt_create_end
        self.gmt_create_start = gmt_create_start
        self.gmt_modified_end = gmt_modified_end
        self.gmt_modified_start = gmt_modified_start
        self.mac_address = mac_address
        self.page_number = page_number
        self.page_size = page_size
        self.platform = platform
        self.status = status
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.gmt_create_end is not None:
            result['gmtCreateEnd'] = self.gmt_create_end
        if self.gmt_create_start is not None:
            result['gmtCreateStart'] = self.gmt_create_start
        if self.gmt_modified_end is not None:
            result['gmtModifiedEnd'] = self.gmt_modified_end
        if self.gmt_modified_start is not None:
            result['gmtModifiedStart'] = self.gmt_modified_start
        if self.mac_address is not None:
            result['macAddress'] = self.mac_address
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.platform is not None:
            result['platform'] = self.platform
        if self.status is not None:
            result['status'] = self.status
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('gmtCreateEnd') is not None:
            self.gmt_create_end = m.get('gmtCreateEnd')
        if m.get('gmtCreateStart') is not None:
            self.gmt_create_start = m.get('gmtCreateStart')
        if m.get('gmtModifiedEnd') is not None:
            self.gmt_modified_end = m.get('gmtModifiedEnd')
        if m.get('gmtModifiedStart') is not None:
            self.gmt_modified_start = m.get('gmtModifiedStart')
        if m.get('macAddress') is not None:
            self.mac_address = m.get('macAddress')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('platform') is not None:
            self.platform = m.get('platform')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class GetTrustDeviceListResponseBodyData(TeaModel):
    def __init__(
        self,
        create_time: int = None,
        id: int = None,
        mac_address: str = None,
        model: str = None,
        modified_time: int = None,
        platform: str = None,
        status: int = None,
        title: str = None,
        user_id: str = None,
    ):
        self.create_time = create_time
        self.id = id
        self.mac_address = mac_address
        self.model = model
        self.modified_time = modified_time
        self.platform = platform
        self.status = status
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
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.id is not None:
            result['id'] = self.id
        if self.mac_address is not None:
            result['macAddress'] = self.mac_address
        if self.model is not None:
            result['model'] = self.model
        if self.modified_time is not None:
            result['modifiedTime'] = self.modified_time
        if self.platform is not None:
            result['platform'] = self.platform
        if self.status is not None:
            result['status'] = self.status
        if self.title is not None:
            result['title'] = self.title
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('macAddress') is not None:
            self.mac_address = m.get('macAddress')
        if m.get('model') is not None:
            self.model = m.get('model')
        if m.get('modifiedTime') is not None:
            self.modified_time = m.get('modifiedTime')
        if m.get('platform') is not None:
            self.platform = m.get('platform')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetTrustDeviceListResponseBody(TeaModel):
    def __init__(
        self,
        current_page: int = None,
        data: List[GetTrustDeviceListResponseBodyData] = None,
        page_size: int = None,
        total: int = None,
    ):
        self.current_page = current_page
        # This parameter is required.
        self.data = data
        self.page_size = page_size
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
        if self.current_page is not None:
            result['currentPage'] = self.current_page
        result['data'] = []
        if self.data is not None:
            for k in self.data:
                result['data'].append(k.to_map() if k else None)
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.total is not None:
            result['total'] = self.total
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('currentPage') is not None:
            self.current_page = m.get('currentPage')
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetTrustDeviceListResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('total') is not None:
            self.total = m.get('total')
        return self


class GetTrustDeviceListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetTrustDeviceListResponseBody = None,
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
            temp_model = GetTrustDeviceListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetUserAppVersionSummaryHeaders(TeaModel):
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


class GetUserAppVersionSummaryRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: int = None,
    ):
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
        self.next_token = next_token

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class GetUserAppVersionSummaryResponseBodyData(TeaModel):
    def __init__(
        self,
        app_version: str = None,
        client: str = None,
        org_name: str = None,
        stat_date: str = None,
        user_cnt: float = None,
    ):
        self.app_version = app_version
        self.client = client
        self.org_name = org_name
        self.stat_date = stat_date
        self.user_cnt = user_cnt

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_version is not None:
            result['appVersion'] = self.app_version
        if self.client is not None:
            result['client'] = self.client
        if self.org_name is not None:
            result['orgName'] = self.org_name
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        if self.user_cnt is not None:
            result['userCnt'] = self.user_cnt
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appVersion') is not None:
            self.app_version = m.get('appVersion')
        if m.get('client') is not None:
            self.client = m.get('client')
        if m.get('orgName') is not None:
            self.org_name = m.get('orgName')
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        if m.get('userCnt') is not None:
            self.user_cnt = m.get('userCnt')
        return self


class GetUserAppVersionSummaryResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetUserAppVersionSummaryResponseBodyData] = None,
        has_more: bool = None,
        next_token: int = None,
    ):
        self.data = data
        self.has_more = has_more
        self.next_token = next_token

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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetUserAppVersionSummaryResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class GetUserAppVersionSummaryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetUserAppVersionSummaryResponseBody = None,
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
            temp_model = GetUserAppVersionSummaryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetUserFaceStateHeaders(TeaModel):
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


class GetUserFaceStateRequest(TeaModel):
    def __init__(
        self,
        user_ids: List[str] = None,
    ):
        # This parameter is required.
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


class GetUserFaceStateResponseBodyData(TeaModel):
    def __init__(
        self,
        state: int = None,
        user_id: str = None,
    ):
        self.state = state
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.state is not None:
            result['state'] = self.state
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('state') is not None:
            self.state = m.get('state')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetUserFaceStateResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetUserFaceStateResponseBodyData] = None,
    ):
        self.data = data

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetUserFaceStateResponseBodyData()
                self.data.append(temp_model.from_map(k))
        return self


class GetUserFaceStateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetUserFaceStateResponseBody = None,
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
            temp_model = GetUserFaceStateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetUserRealPeopleStateHeaders(TeaModel):
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


class GetUserRealPeopleStateRequest(TeaModel):
    def __init__(
        self,
        user_ids: List[str] = None,
    ):
        # This parameter is required.
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


class GetUserRealPeopleStateResponseBodyData(TeaModel):
    def __init__(
        self,
        state: int = None,
        user_id: str = None,
    ):
        self.state = state
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.state is not None:
            result['state'] = self.state
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('state') is not None:
            self.state = m.get('state')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetUserRealPeopleStateResponseBody(TeaModel):
    def __init__(
        self,
        data: List[GetUserRealPeopleStateResponseBodyData] = None,
    ):
        self.data = data

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = GetUserRealPeopleStateResponseBodyData()
                self.data.append(temp_model.from_map(k))
        return self


class GetUserRealPeopleStateResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetUserRealPeopleStateResponseBody = None,
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
            temp_model = GetUserRealPeopleStateResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetUserStayLengthHeaders(TeaModel):
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


class GetUserStayLengthRequest(TeaModel):
    def __init__(
        self,
        page_number: int = None,
        page_size: int = None,
        stat_date: str = None,
    ):
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
        self.page_size = page_size
        # This parameter is required.
        self.stat_date = stat_date

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
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        return self


class GetUserStayLengthResponseBodyItemList(TeaModel):
    def __init__(
        self,
        name: str = None,
        stat_date: str = None,
        stay_time_len_app_1d: int = None,
        stay_time_len_pc_1d: int = None,
        user_id: str = None,
    ):
        self.name = name
        self.stat_date = stat_date
        self.stay_time_len_app_1d = stay_time_len_app_1d
        self.stay_time_len_pc_1d = stay_time_len_pc_1d
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.stat_date is not None:
            result['statDate'] = self.stat_date
        if self.stay_time_len_app_1d is not None:
            result['stayTimeLenApp1d'] = self.stay_time_len_app_1d
        if self.stay_time_len_pc_1d is not None:
            result['stayTimeLenPc1d'] = self.stay_time_len_pc_1d
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('statDate') is not None:
            self.stat_date = m.get('statDate')
        if m.get('stayTimeLenApp1d') is not None:
            self.stay_time_len_app_1d = m.get('stayTimeLenApp1d')
        if m.get('stayTimeLenPc1d') is not None:
            self.stay_time_len_pc_1d = m.get('stayTimeLenPc1d')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class GetUserStayLengthResponseBody(TeaModel):
    def __init__(
        self,
        item_list: List[GetUserStayLengthResponseBodyItemList] = None,
        total_count: int = None,
    ):
        self.item_list = item_list
        self.total_count = total_count

    def validate(self):
        if self.item_list:
            for k in self.item_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['itemList'] = []
        if self.item_list is not None:
            for k in self.item_list:
                result['itemList'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.item_list = []
        if m.get('itemList') is not None:
            for k in m.get('itemList'):
                temp_model = GetUserStayLengthResponseBodyItemList()
                self.item_list.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class GetUserStayLengthResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetUserStayLengthResponseBody = None,
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
            temp_model = GetUserStayLengthResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetVirusScanResultHeaders(TeaModel):
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


class GetVirusScanResultRequest(TeaModel):
    def __init__(
        self,
        task_id: str = None,
    ):
        # This parameter is required.
        self.task_id = task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class GetVirusScanResultResponseBody(TeaModel):
    def __init__(
        self,
        reason: str = None,
        status: int = None,
    ):
        self.reason = reason
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.reason is not None:
            result['reason'] = self.reason
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('reason') is not None:
            self.reason = m.get('reason')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class GetVirusScanResultResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetVirusScanResultResponseBody = None,
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
            temp_model = GetVirusScanResultResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GroupQueryByAttrHeaders(TeaModel):
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


class GroupQueryByAttrRequestListDynamicAttr(TeaModel):
    def __init__(
        self,
        attr_code: str = None,
        list_attr_options_code: List[str] = None,
    ):
        # This parameter is required.
        self.attr_code = attr_code
        # This parameter is required.
        self.list_attr_options_code = list_attr_options_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.attr_code is not None:
            result['attrCode'] = self.attr_code
        if self.list_attr_options_code is not None:
            result['listAttrOptionsCode'] = self.list_attr_options_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('attrCode') is not None:
            self.attr_code = m.get('attrCode')
        if m.get('listAttrOptionsCode') is not None:
            self.list_attr_options_code = m.get('listAttrOptionsCode')
        return self


class GroupQueryByAttrRequest(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        group_topic: str = None,
        group_type: str = None,
        list_dynamic_attr: List[GroupQueryByAttrRequestListDynamicAttr] = None,
        page_index: int = None,
        page_size: int = None,
        secret_key: str = None,
    ):
        # This parameter is required.
        self.corp_id = corp_id
        self.group_topic = group_topic
        self.group_type = group_type
        self.list_dynamic_attr = list_dynamic_attr
        self.page_index = page_index
        self.page_size = page_size
        # This parameter is required.
        self.secret_key = secret_key

    def validate(self):
        if self.list_dynamic_attr:
            for k in self.list_dynamic_attr:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.group_topic is not None:
            result['groupTopic'] = self.group_topic
        if self.group_type is not None:
            result['groupType'] = self.group_type
        result['listDynamicAttr'] = []
        if self.list_dynamic_attr is not None:
            for k in self.list_dynamic_attr:
                result['listDynamicAttr'].append(k.to_map() if k else None)
        if self.page_index is not None:
            result['pageIndex'] = self.page_index
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.secret_key is not None:
            result['secretKey'] = self.secret_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('groupTopic') is not None:
            self.group_topic = m.get('groupTopic')
        if m.get('groupType') is not None:
            self.group_type = m.get('groupType')
        self.list_dynamic_attr = []
        if m.get('listDynamicAttr') is not None:
            for k in m.get('listDynamicAttr'):
                temp_model = GroupQueryByAttrRequestListDynamicAttr()
                self.list_dynamic_attr.append(temp_model.from_map(k))
        if m.get('pageIndex') is not None:
            self.page_index = m.get('pageIndex')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('secretKey') is not None:
            self.secret_key = m.get('secretKey')
        return self


class GroupQueryByAttrResponseBodyDataList(TeaModel):
    def __init__(
        self,
        group_member_count: int = None,
        group_name: str = None,
        open_conversation_id: str = None,
        owner_job_no: str = None,
        owner_user_name: str = None,
    ):
        self.group_member_count = group_member_count
        self.group_name = group_name
        self.open_conversation_id = open_conversation_id
        self.owner_job_no = owner_job_no
        self.owner_user_name = owner_user_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_member_count is not None:
            result['groupMemberCount'] = self.group_member_count
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.owner_job_no is not None:
            result['ownerJobNo'] = self.owner_job_no
        if self.owner_user_name is not None:
            result['ownerUserName'] = self.owner_user_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupMemberCount') is not None:
            self.group_member_count = m.get('groupMemberCount')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('ownerJobNo') is not None:
            self.owner_job_no = m.get('ownerJobNo')
        if m.get('ownerUserName') is not None:
            self.owner_user_name = m.get('ownerUserName')
        return self


class GroupQueryByAttrResponseBodyData(TeaModel):
    def __init__(
        self,
        counts: int = None,
        list: List[GroupQueryByAttrResponseBodyDataList] = None,
        page_index: int = None,
        page_size: int = None,
    ):
        self.counts = counts
        self.list = list
        self.page_index = page_index
        self.page_size = page_size

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
        if self.counts is not None:
            result['counts'] = self.counts
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        if self.page_index is not None:
            result['pageIndex'] = self.page_index
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('counts') is not None:
            self.counts = m.get('counts')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = GroupQueryByAttrResponseBodyDataList()
                self.list.append(temp_model.from_map(k))
        if m.get('pageIndex') is not None:
            self.page_index = m.get('pageIndex')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class GroupQueryByAttrResponseBody(TeaModel):
    def __init__(
        self,
        code: int = None,
        data: GroupQueryByAttrResponseBodyData = None,
        message: str = None,
    ):
        self.code = code
        self.data = data
        self.message = message

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.message is not None:
            result['message'] = self.message
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('data') is not None:
            temp_model = GroupQueryByAttrResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('message') is not None:
            self.message = m.get('message')
        return self


class GroupQueryByAttrResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GroupQueryByAttrResponseBody = None,
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
            temp_model = GroupQueryByAttrResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GroupQueryByOpenIdHeaders(TeaModel):
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


class GroupQueryByOpenIdRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        secret_key: str = None,
    ):
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.secret_key = secret_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.secret_key is not None:
            result['secretKey'] = self.secret_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('secretKey') is not None:
            self.secret_key = m.get('secretKey')
        return self


class GroupQueryByOpenIdResponseBodyDataListGroupDynamicAttr(TeaModel):
    def __init__(
        self,
        attr_code: str = None,
        list_attr_options_code: List[str] = None,
    ):
        self.attr_code = attr_code
        self.list_attr_options_code = list_attr_options_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.attr_code is not None:
            result['attrCode'] = self.attr_code
        if self.list_attr_options_code is not None:
            result['listAttrOptionsCode'] = self.list_attr_options_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('attrCode') is not None:
            self.attr_code = m.get('attrCode')
        if m.get('listAttrOptionsCode') is not None:
            self.list_attr_options_code = m.get('listAttrOptionsCode')
        return self


class GroupQueryByOpenIdResponseBodyData(TeaModel):
    def __init__(
        self,
        group_name: str = None,
        group_template_id: str = None,
        group_template_name: str = None,
        group_topic: str = None,
        group_type: str = None,
        id: int = None,
        list_group_dynamic_attr: List[GroupQueryByOpenIdResponseBodyDataListGroupDynamicAttr] = None,
        open_conversation_id: str = None,
    ):
        self.group_name = group_name
        self.group_template_id = group_template_id
        self.group_template_name = group_template_name
        self.group_topic = group_topic
        self.group_type = group_type
        self.id = id
        self.list_group_dynamic_attr = list_group_dynamic_attr
        self.open_conversation_id = open_conversation_id

    def validate(self):
        if self.list_group_dynamic_attr:
            for k in self.list_group_dynamic_attr:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.group_template_id is not None:
            result['groupTemplateId'] = self.group_template_id
        if self.group_template_name is not None:
            result['groupTemplateName'] = self.group_template_name
        if self.group_topic is not None:
            result['groupTopic'] = self.group_topic
        if self.group_type is not None:
            result['groupType'] = self.group_type
        if self.id is not None:
            result['id'] = self.id
        result['listGroupDynamicAttr'] = []
        if self.list_group_dynamic_attr is not None:
            for k in self.list_group_dynamic_attr:
                result['listGroupDynamicAttr'].append(k.to_map() if k else None)
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('groupTemplateId') is not None:
            self.group_template_id = m.get('groupTemplateId')
        if m.get('groupTemplateName') is not None:
            self.group_template_name = m.get('groupTemplateName')
        if m.get('groupTopic') is not None:
            self.group_topic = m.get('groupTopic')
        if m.get('groupType') is not None:
            self.group_type = m.get('groupType')
        if m.get('id') is not None:
            self.id = m.get('id')
        self.list_group_dynamic_attr = []
        if m.get('listGroupDynamicAttr') is not None:
            for k in m.get('listGroupDynamicAttr'):
                temp_model = GroupQueryByOpenIdResponseBodyDataListGroupDynamicAttr()
                self.list_group_dynamic_attr.append(temp_model.from_map(k))
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class GroupQueryByOpenIdResponseBody(TeaModel):
    def __init__(
        self,
        code: int = None,
        data: GroupQueryByOpenIdResponseBodyData = None,
        message: str = None,
    ):
        self.code = code
        self.data = data
        self.message = message

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.message is not None:
            result['message'] = self.message
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('data') is not None:
            temp_model = GroupQueryByOpenIdResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('message') is not None:
            self.message = m.get('message')
        return self


class GroupQueryByOpenIdResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GroupQueryByOpenIdResponseBody = None,
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
            temp_model = GroupQueryByOpenIdResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListAuditLogHeaders(TeaModel):
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


class ListAuditLogRequest(TeaModel):
    def __init__(
        self,
        end_date: int = None,
        next_biz_id: int = None,
        next_gmt_create: int = None,
        page_size: int = None,
        start_date: int = None,
    ):
        # This parameter is required.
        self.end_date = end_date
        self.next_biz_id = next_biz_id
        self.next_gmt_create = next_gmt_create
        # This parameter is required.
        self.page_size = page_size
        # This parameter is required.
        self.start_date = start_date

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.next_biz_id is not None:
            result['nextBizId'] = self.next_biz_id
        if self.next_gmt_create is not None:
            result['nextGmtCreate'] = self.next_gmt_create
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.start_date is not None:
            result['startDate'] = self.start_date
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('nextBizId') is not None:
            self.next_biz_id = m.get('nextBizId')
        if m.get('nextGmtCreate') is not None:
            self.next_gmt_create = m.get('nextGmtCreate')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        return self


class ListAuditLogResponseBodyListDocMemberList(TeaModel):
    def __init__(
        self,
        member_name: str = None,
        member_type: int = None,
        member_type_view: str = None,
        permission_role: int = None,
        permission_role_view: str = None,
    ):
        self.member_name = member_name
        self.member_type = member_type
        self.member_type_view = member_type_view
        self.permission_role = permission_role
        self.permission_role_view = permission_role_view

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.member_name is not None:
            result['memberName'] = self.member_name
        if self.member_type is not None:
            result['memberType'] = self.member_type
        if self.member_type_view is not None:
            result['memberTypeView'] = self.member_type_view
        if self.permission_role is not None:
            result['permissionRole'] = self.permission_role
        if self.permission_role_view is not None:
            result['permissionRoleView'] = self.permission_role_view
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('memberName') is not None:
            self.member_name = m.get('memberName')
        if m.get('memberType') is not None:
            self.member_type = m.get('memberType')
        if m.get('memberTypeView') is not None:
            self.member_type_view = m.get('memberTypeView')
        if m.get('permissionRole') is not None:
            self.permission_role = m.get('permissionRole')
        if m.get('permissionRoleView') is not None:
            self.permission_role_view = m.get('permissionRoleView')
        return self


class ListAuditLogResponseBodyListDocReceiverList(TeaModel):
    def __init__(
        self,
        receiver_name: str = None,
        receiver_type: int = None,
        receiver_type_view: str = None,
    ):
        self.receiver_name = receiver_name
        self.receiver_type = receiver_type
        self.receiver_type_view = receiver_type_view

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.receiver_name is not None:
            result['receiverName'] = self.receiver_name
        if self.receiver_type is not None:
            result['receiverType'] = self.receiver_type
        if self.receiver_type_view is not None:
            result['receiverTypeView'] = self.receiver_type_view
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('receiverName') is not None:
            self.receiver_name = m.get('receiverName')
        if m.get('receiverType') is not None:
            self.receiver_type = m.get('receiverType')
        if m.get('receiverTypeView') is not None:
            self.receiver_type_view = m.get('receiverTypeView')
        return self


class ListAuditLogResponseBodyList(TeaModel):
    def __init__(
        self,
        action: int = None,
        action_view: str = None,
        biz_id: str = None,
        doc_member_list: List[ListAuditLogResponseBodyListDocMemberList] = None,
        doc_mobile_url: str = None,
        doc_pc_url: str = None,
        doc_receiver_list: List[ListAuditLogResponseBodyListDocReceiverList] = None,
        gmt_create: int = None,
        gmt_modified: int = None,
        ip_address: str = None,
        operate_module: int = None,
        operate_module_view: str = None,
        operator_name: str = None,
        org_name: str = None,
        platform: int = None,
        platform_view: str = None,
        prev_work_space_id: int = None,
        prev_work_space_mobile_url: str = None,
        prev_work_space_name: str = None,
        prev_work_space_pc_url: str = None,
        real_name: str = None,
        receiver_name: str = None,
        receiver_type: int = None,
        receiver_type_view: str = None,
        resource: str = None,
        resource_extension: str = None,
        resource_size: int = None,
        status: int = None,
        target_space_id: int = None,
        user_id: str = None,
        work_space_id: int = None,
        work_space_mobile_url: str = None,
        work_space_name: str = None,
        work_space_pc_url: str = None,
    ):
        self.action = action
        self.action_view = action_view
        self.biz_id = biz_id
        self.doc_member_list = doc_member_list
        self.doc_mobile_url = doc_mobile_url
        self.doc_pc_url = doc_pc_url
        self.doc_receiver_list = doc_receiver_list
        self.gmt_create = gmt_create
        self.gmt_modified = gmt_modified
        self.ip_address = ip_address
        self.operate_module = operate_module
        self.operate_module_view = operate_module_view
        self.operator_name = operator_name
        self.org_name = org_name
        self.platform = platform
        self.platform_view = platform_view
        self.prev_work_space_id = prev_work_space_id
        self.prev_work_space_mobile_url = prev_work_space_mobile_url
        self.prev_work_space_name = prev_work_space_name
        self.prev_work_space_pc_url = prev_work_space_pc_url
        self.real_name = real_name
        self.receiver_name = receiver_name
        self.receiver_type = receiver_type
        self.receiver_type_view = receiver_type_view
        self.resource = resource
        self.resource_extension = resource_extension
        self.resource_size = resource_size
        self.status = status
        self.target_space_id = target_space_id
        self.user_id = user_id
        self.work_space_id = work_space_id
        self.work_space_mobile_url = work_space_mobile_url
        self.work_space_name = work_space_name
        self.work_space_pc_url = work_space_pc_url

    def validate(self):
        if self.doc_member_list:
            for k in self.doc_member_list:
                if k:
                    k.validate()
        if self.doc_receiver_list:
            for k in self.doc_receiver_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action is not None:
            result['action'] = self.action
        if self.action_view is not None:
            result['actionView'] = self.action_view
        if self.biz_id is not None:
            result['bizId'] = self.biz_id
        result['docMemberList'] = []
        if self.doc_member_list is not None:
            for k in self.doc_member_list:
                result['docMemberList'].append(k.to_map() if k else None)
        if self.doc_mobile_url is not None:
            result['docMobileUrl'] = self.doc_mobile_url
        if self.doc_pc_url is not None:
            result['docPcUrl'] = self.doc_pc_url
        result['docReceiverList'] = []
        if self.doc_receiver_list is not None:
            for k in self.doc_receiver_list:
                result['docReceiverList'].append(k.to_map() if k else None)
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.ip_address is not None:
            result['ipAddress'] = self.ip_address
        if self.operate_module is not None:
            result['operateModule'] = self.operate_module
        if self.operate_module_view is not None:
            result['operateModuleView'] = self.operate_module_view
        if self.operator_name is not None:
            result['operatorName'] = self.operator_name
        if self.org_name is not None:
            result['orgName'] = self.org_name
        if self.platform is not None:
            result['platform'] = self.platform
        if self.platform_view is not None:
            result['platformView'] = self.platform_view
        if self.prev_work_space_id is not None:
            result['prevWorkSpaceId'] = self.prev_work_space_id
        if self.prev_work_space_mobile_url is not None:
            result['prevWorkSpaceMobileUrl'] = self.prev_work_space_mobile_url
        if self.prev_work_space_name is not None:
            result['prevWorkSpaceName'] = self.prev_work_space_name
        if self.prev_work_space_pc_url is not None:
            result['prevWorkSpacePcUrl'] = self.prev_work_space_pc_url
        if self.real_name is not None:
            result['realName'] = self.real_name
        if self.receiver_name is not None:
            result['receiverName'] = self.receiver_name
        if self.receiver_type is not None:
            result['receiverType'] = self.receiver_type
        if self.receiver_type_view is not None:
            result['receiverTypeView'] = self.receiver_type_view
        if self.resource is not None:
            result['resource'] = self.resource
        if self.resource_extension is not None:
            result['resourceExtension'] = self.resource_extension
        if self.resource_size is not None:
            result['resourceSize'] = self.resource_size
        if self.status is not None:
            result['status'] = self.status
        if self.target_space_id is not None:
            result['targetSpaceId'] = self.target_space_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.work_space_id is not None:
            result['workSpaceId'] = self.work_space_id
        if self.work_space_mobile_url is not None:
            result['workSpaceMobileUrl'] = self.work_space_mobile_url
        if self.work_space_name is not None:
            result['workSpaceName'] = self.work_space_name
        if self.work_space_pc_url is not None:
            result['workSpacePcUrl'] = self.work_space_pc_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('action') is not None:
            self.action = m.get('action')
        if m.get('actionView') is not None:
            self.action_view = m.get('actionView')
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        self.doc_member_list = []
        if m.get('docMemberList') is not None:
            for k in m.get('docMemberList'):
                temp_model = ListAuditLogResponseBodyListDocMemberList()
                self.doc_member_list.append(temp_model.from_map(k))
        if m.get('docMobileUrl') is not None:
            self.doc_mobile_url = m.get('docMobileUrl')
        if m.get('docPcUrl') is not None:
            self.doc_pc_url = m.get('docPcUrl')
        self.doc_receiver_list = []
        if m.get('docReceiverList') is not None:
            for k in m.get('docReceiverList'):
                temp_model = ListAuditLogResponseBodyListDocReceiverList()
                self.doc_receiver_list.append(temp_model.from_map(k))
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('ipAddress') is not None:
            self.ip_address = m.get('ipAddress')
        if m.get('operateModule') is not None:
            self.operate_module = m.get('operateModule')
        if m.get('operateModuleView') is not None:
            self.operate_module_view = m.get('operateModuleView')
        if m.get('operatorName') is not None:
            self.operator_name = m.get('operatorName')
        if m.get('orgName') is not None:
            self.org_name = m.get('orgName')
        if m.get('platform') is not None:
            self.platform = m.get('platform')
        if m.get('platformView') is not None:
            self.platform_view = m.get('platformView')
        if m.get('prevWorkSpaceId') is not None:
            self.prev_work_space_id = m.get('prevWorkSpaceId')
        if m.get('prevWorkSpaceMobileUrl') is not None:
            self.prev_work_space_mobile_url = m.get('prevWorkSpaceMobileUrl')
        if m.get('prevWorkSpaceName') is not None:
            self.prev_work_space_name = m.get('prevWorkSpaceName')
        if m.get('prevWorkSpacePcUrl') is not None:
            self.prev_work_space_pc_url = m.get('prevWorkSpacePcUrl')
        if m.get('realName') is not None:
            self.real_name = m.get('realName')
        if m.get('receiverName') is not None:
            self.receiver_name = m.get('receiverName')
        if m.get('receiverType') is not None:
            self.receiver_type = m.get('receiverType')
        if m.get('receiverTypeView') is not None:
            self.receiver_type_view = m.get('receiverTypeView')
        if m.get('resource') is not None:
            self.resource = m.get('resource')
        if m.get('resourceExtension') is not None:
            self.resource_extension = m.get('resourceExtension')
        if m.get('resourceSize') is not None:
            self.resource_size = m.get('resourceSize')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('targetSpaceId') is not None:
            self.target_space_id = m.get('targetSpaceId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('workSpaceId') is not None:
            self.work_space_id = m.get('workSpaceId')
        if m.get('workSpaceMobileUrl') is not None:
            self.work_space_mobile_url = m.get('workSpaceMobileUrl')
        if m.get('workSpaceName') is not None:
            self.work_space_name = m.get('workSpaceName')
        if m.get('workSpacePcUrl') is not None:
            self.work_space_pc_url = m.get('workSpacePcUrl')
        return self


class ListAuditLogResponseBody(TeaModel):
    def __init__(
        self,
        list: List[ListAuditLogResponseBodyList] = None,
    ):
        self.list = list

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
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = ListAuditLogResponseBodyList()
                self.list.append(temp_model.from_map(k))
        return self


class ListAuditLogResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListAuditLogResponseBody = None,
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
            temp_model = ListAuditLogResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListByCodesHeaders(TeaModel):
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


class ListByCodesRequest(TeaModel):
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


class ListByCodesResponseBodyRobotInfoList(TeaModel):
    def __init__(
        self,
        brief: str = None,
        code: str = None,
        create_at: int = None,
        description: str = None,
        dev: str = None,
        icon: str = None,
        modified_at: int = None,
        name: str = None,
        outgoing_token: str = None,
        outgoing_url: str = None,
        preview_media_id: str = None,
        source_url: str = None,
        status: int = None,
    ):
        self.brief = brief
        self.code = code
        self.create_at = create_at
        self.description = description
        self.dev = dev
        self.icon = icon
        self.modified_at = modified_at
        self.name = name
        self.outgoing_token = outgoing_token
        self.outgoing_url = outgoing_url
        self.preview_media_id = preview_media_id
        self.source_url = source_url
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.brief is not None:
            result['brief'] = self.brief
        if self.code is not None:
            result['code'] = self.code
        if self.create_at is not None:
            result['createAt'] = self.create_at
        if self.description is not None:
            result['description'] = self.description
        if self.dev is not None:
            result['dev'] = self.dev
        if self.icon is not None:
            result['icon'] = self.icon
        if self.modified_at is not None:
            result['modifiedAt'] = self.modified_at
        if self.name is not None:
            result['name'] = self.name
        if self.outgoing_token is not None:
            result['outgoingToken'] = self.outgoing_token
        if self.outgoing_url is not None:
            result['outgoingUrl'] = self.outgoing_url
        if self.preview_media_id is not None:
            result['previewMediaId'] = self.preview_media_id
        if self.source_url is not None:
            result['sourceUrl'] = self.source_url
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('brief') is not None:
            self.brief = m.get('brief')
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('createAt') is not None:
            self.create_at = m.get('createAt')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('dev') is not None:
            self.dev = m.get('dev')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('modifiedAt') is not None:
            self.modified_at = m.get('modifiedAt')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('outgoingToken') is not None:
            self.outgoing_token = m.get('outgoingToken')
        if m.get('outgoingUrl') is not None:
            self.outgoing_url = m.get('outgoingUrl')
        if m.get('previewMediaId') is not None:
            self.preview_media_id = m.get('previewMediaId')
        if m.get('sourceUrl') is not None:
            self.source_url = m.get('sourceUrl')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class ListByCodesResponseBody(TeaModel):
    def __init__(
        self,
        robot_info_list: List[ListByCodesResponseBodyRobotInfoList] = None,
    ):
        self.robot_info_list = robot_info_list

    def validate(self):
        if self.robot_info_list:
            for k in self.robot_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['robotInfoList'] = []
        if self.robot_info_list is not None:
            for k in self.robot_info_list:
                result['robotInfoList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.robot_info_list = []
        if m.get('robotInfoList') is not None:
            for k in m.get('robotInfoList'):
                temp_model = ListByCodesResponseBodyRobotInfoList()
                self.robot_info_list.append(temp_model.from_map(k))
        return self


class ListByCodesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListByCodesResponseBody = None,
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
            temp_model = ListByCodesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListByPluginIdsHeaders(TeaModel):
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


class ListByPluginIdsRequest(TeaModel):
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


class ListByPluginIdsResponseBodyPluginInfoList(TeaModel):
    def __init__(
        self,
        app_id: str = None,
        create_at: int = None,
        desc: str = None,
        icons: str = None,
        modified_at: int = None,
        name: str = None,
        pc_url: str = None,
        plugin_id: str = None,
        status: int = None,
        url: str = None,
    ):
        self.app_id = app_id
        self.create_at = create_at
        self.desc = desc
        self.icons = icons
        self.modified_at = modified_at
        self.name = name
        self.pc_url = pc_url
        self.plugin_id = plugin_id
        self.status = status
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.create_at is not None:
            result['createAt'] = self.create_at
        if self.desc is not None:
            result['desc'] = self.desc
        if self.icons is not None:
            result['icons'] = self.icons
        if self.modified_at is not None:
            result['modifiedAt'] = self.modified_at
        if self.name is not None:
            result['name'] = self.name
        if self.pc_url is not None:
            result['pcUrl'] = self.pc_url
        if self.plugin_id is not None:
            result['pluginId'] = self.plugin_id
        if self.status is not None:
            result['status'] = self.status
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('createAt') is not None:
            self.create_at = m.get('createAt')
        if m.get('desc') is not None:
            self.desc = m.get('desc')
        if m.get('icons') is not None:
            self.icons = m.get('icons')
        if m.get('modifiedAt') is not None:
            self.modified_at = m.get('modifiedAt')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('pcUrl') is not None:
            self.pc_url = m.get('pcUrl')
        if m.get('pluginId') is not None:
            self.plugin_id = m.get('pluginId')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class ListByPluginIdsResponseBody(TeaModel):
    def __init__(
        self,
        plugin_info_list: List[ListByPluginIdsResponseBodyPluginInfoList] = None,
    ):
        self.plugin_info_list = plugin_info_list

    def validate(self):
        if self.plugin_info_list:
            for k in self.plugin_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['pluginInfoList'] = []
        if self.plugin_info_list is not None:
            for k in self.plugin_info_list:
                result['pluginInfoList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.plugin_info_list = []
        if m.get('pluginInfoList') is not None:
            for k in m.get('pluginInfoList'):
                temp_model = ListByPluginIdsResponseBodyPluginInfoList()
                self.plugin_info_list.append(temp_model.from_map(k))
        return self


class ListByPluginIdsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListByPluginIdsResponseBody = None,
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
            temp_model = ListByPluginIdsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListCategorysHeaders(TeaModel):
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


class ListCategorysRequestBody(TeaModel):
    def __init__(
        self,
        status: int = None,
    ):
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class ListCategorysRequest(TeaModel):
    def __init__(
        self,
        body: ListCategorysRequestBody = None,
    ):
        # This parameter is required.
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('body') is not None:
            temp_model = ListCategorysRequestBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListCategorysShrinkRequest(TeaModel):
    def __init__(
        self,
        body_shrink: str = None,
    ):
        # This parameter is required.
        self.body_shrink = body_shrink

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.body_shrink is not None:
            result['body'] = self.body_shrink
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('body') is not None:
            self.body_shrink = m.get('body')
        return self


class ListCategorysResponseBody(TeaModel):
    def __init__(
        self,
        detail_model_list: List[Dict[str, str]] = None,
    ):
        self.detail_model_list = detail_model_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.detail_model_list is not None:
            result['detailModelList'] = self.detail_model_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('detailModelList') is not None:
            self.detail_model_list = m.get('detailModelList')
        return self


class ListCategorysResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListCategorysResponseBody = None,
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
            temp_model = ListCategorysResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListJoinOrgInfoHeaders(TeaModel):
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


class ListJoinOrgInfoRequest(TeaModel):
    def __init__(
        self,
        mobile: str = None,
    ):
        # This parameter is required.
        self.mobile = mobile

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.mobile is not None:
            result['mobile'] = self.mobile
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('mobile') is not None:
            self.mobile = m.get('mobile')
        return self


class ListJoinOrgInfoResponseBodyOrgInfoList(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        domain: str = None,
        org_full_name: str = None,
        org_name: int = None,
    ):
        # This parameter is required.
        self.corp_id = corp_id
        # This parameter is required.
        self.domain = domain
        # This parameter is required.
        self.org_full_name = org_full_name
        # This parameter is required.
        self.org_name = org_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.domain is not None:
            result['domain'] = self.domain
        if self.org_full_name is not None:
            result['orgFullName'] = self.org_full_name
        if self.org_name is not None:
            result['orgName'] = self.org_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('domain') is not None:
            self.domain = m.get('domain')
        if m.get('orgFullName') is not None:
            self.org_full_name = m.get('orgFullName')
        if m.get('orgName') is not None:
            self.org_name = m.get('orgName')
        return self


class ListJoinOrgInfoResponseBody(TeaModel):
    def __init__(
        self,
        org_info_list: List[ListJoinOrgInfoResponseBodyOrgInfoList] = None,
    ):
        self.org_info_list = org_info_list

    def validate(self):
        if self.org_info_list:
            for k in self.org_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['orgInfoList'] = []
        if self.org_info_list is not None:
            for k in self.org_info_list:
                result['orgInfoList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.org_info_list = []
        if m.get('orgInfoList') is not None:
            for k in m.get('orgInfoList'):
                temp_model = ListJoinOrgInfoResponseBodyOrgInfoList()
                self.org_info_list.append(temp_model.from_map(k))
        return self


class ListJoinOrgInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListJoinOrgInfoResponseBody = None,
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
            temp_model = ListJoinOrgInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListMiniAppAvailableVersionHeaders(TeaModel):
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


class ListMiniAppAvailableVersionRequest(TeaModel):
    def __init__(
        self,
        mini_app_id: str = None,
        page_number: int = None,
        page_size: int = None,
        version_type_set: List[int] = None,
    ):
        self.mini_app_id = mini_app_id
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
        self.page_size = page_size
        # This parameter is required.
        self.version_type_set = version_type_set

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.mini_app_id is not None:
            result['miniAppId'] = self.mini_app_id
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.version_type_set is not None:
            result['versionTypeSet'] = self.version_type_set
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('miniAppId') is not None:
            self.mini_app_id = m.get('miniAppId')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('versionTypeSet') is not None:
            self.version_type_set = m.get('versionTypeSet')
        return self


class ListMiniAppAvailableVersionResponseBodyList(TeaModel):
    def __init__(
        self,
        build_status: int = None,
        version: str = None,
    ):
        # This parameter is required.
        self.build_status = build_status
        # This parameter is required.
        self.version = version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.build_status is not None:
            result['buildStatus'] = self.build_status
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('buildStatus') is not None:
            self.build_status = m.get('buildStatus')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class ListMiniAppAvailableVersionResponseBody(TeaModel):
    def __init__(
        self,
        list: List[ListMiniAppAvailableVersionResponseBodyList] = None,
    ):
        self.list = list

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
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = ListMiniAppAvailableVersionResponseBodyList()
                self.list.append(temp_model.from_map(k))
        return self


class ListMiniAppAvailableVersionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListMiniAppAvailableVersionResponseBody = None,
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
            temp_model = ListMiniAppAvailableVersionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListMiniAppHistoryVersionHeaders(TeaModel):
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


class ListMiniAppHistoryVersionRequest(TeaModel):
    def __init__(
        self,
        mini_app_id: str = None,
        page_number: int = None,
        page_size: int = None,
    ):
        # This parameter is required.
        self.mini_app_id = mini_app_id
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
        self.page_size = page_size

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.mini_app_id is not None:
            result['miniAppId'] = self.mini_app_id
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('miniAppId') is not None:
            self.mini_app_id = m.get('miniAppId')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class ListMiniAppHistoryVersionResponseBodyList(TeaModel):
    def __init__(
        self,
        build_status: int = None,
        h_5bundle: str = None,
        package_size: str = None,
        package_url: str = None,
        version: str = None,
    ):
        # This parameter is required.
        self.build_status = build_status
        # This parameter is required.
        self.h_5bundle = h_5bundle
        # This parameter is required.
        self.package_size = package_size
        # This parameter is required.
        self.package_url = package_url
        # This parameter is required.
        self.version = version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.build_status is not None:
            result['buildStatus'] = self.build_status
        if self.h_5bundle is not None:
            result['h5Bundle'] = self.h_5bundle
        if self.package_size is not None:
            result['packageSize'] = self.package_size
        if self.package_url is not None:
            result['packageUrl'] = self.package_url
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('buildStatus') is not None:
            self.build_status = m.get('buildStatus')
        if m.get('h5Bundle') is not None:
            self.h_5bundle = m.get('h5Bundle')
        if m.get('packageSize') is not None:
            self.package_size = m.get('packageSize')
        if m.get('packageUrl') is not None:
            self.package_url = m.get('packageUrl')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class ListMiniAppHistoryVersionResponseBody(TeaModel):
    def __init__(
        self,
        list: List[ListMiniAppHistoryVersionResponseBodyList] = None,
    ):
        self.list = list

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
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = ListMiniAppHistoryVersionResponseBodyList()
                self.list.append(temp_model.from_map(k))
        return self


class ListMiniAppHistoryVersionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListMiniAppHistoryVersionResponseBody = None,
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
            temp_model = ListMiniAppHistoryVersionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListPartnerRolesHeaders(TeaModel):
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


class ListPartnerRolesResponseBodyListVisibleDepts(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        name: str = None,
    ):
        # This parameter is required.
        self.dept_id = dept_id
        # This parameter is required.
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class ListPartnerRolesResponseBodyListVisibleUsers(TeaModel):
    def __init__(
        self,
        name: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class ListPartnerRolesResponseBodyListWarningDepts(TeaModel):
    def __init__(
        self,
        dept_id: int = None,
        name: str = None,
    ):
        # This parameter is required.
        self.dept_id = dept_id
        # This parameter is required.
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class ListPartnerRolesResponseBodyListWarningUsers(TeaModel):
    def __init__(
        self,
        name: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class ListPartnerRolesResponseBodyList(TeaModel):
    def __init__(
        self,
        id: int = None,
        is_necessary: int = None,
        name: str = None,
        visible_depts: List[ListPartnerRolesResponseBodyListVisibleDepts] = None,
        visible_users: List[ListPartnerRolesResponseBodyListVisibleUsers] = None,
        warning_depts: List[ListPartnerRolesResponseBodyListWarningDepts] = None,
        warning_users: List[ListPartnerRolesResponseBodyListWarningUsers] = None,
    ):
        self.id = id
        # This parameter is required.
        self.is_necessary = is_necessary
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.visible_depts = visible_depts
        # This parameter is required.
        self.visible_users = visible_users
        # This parameter is required.
        self.warning_depts = warning_depts
        # This parameter is required.
        self.warning_users = warning_users

    def validate(self):
        if self.visible_depts:
            for k in self.visible_depts:
                if k:
                    k.validate()
        if self.visible_users:
            for k in self.visible_users:
                if k:
                    k.validate()
        if self.warning_depts:
            for k in self.warning_depts:
                if k:
                    k.validate()
        if self.warning_users:
            for k in self.warning_users:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.is_necessary is not None:
            result['isNecessary'] = self.is_necessary
        if self.name is not None:
            result['name'] = self.name
        result['visibleDepts'] = []
        if self.visible_depts is not None:
            for k in self.visible_depts:
                result['visibleDepts'].append(k.to_map() if k else None)
        result['visibleUsers'] = []
        if self.visible_users is not None:
            for k in self.visible_users:
                result['visibleUsers'].append(k.to_map() if k else None)
        result['warningDepts'] = []
        if self.warning_depts is not None:
            for k in self.warning_depts:
                result['warningDepts'].append(k.to_map() if k else None)
        result['warningUsers'] = []
        if self.warning_users is not None:
            for k in self.warning_users:
                result['warningUsers'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('isNecessary') is not None:
            self.is_necessary = m.get('isNecessary')
        if m.get('name') is not None:
            self.name = m.get('name')
        self.visible_depts = []
        if m.get('visibleDepts') is not None:
            for k in m.get('visibleDepts'):
                temp_model = ListPartnerRolesResponseBodyListVisibleDepts()
                self.visible_depts.append(temp_model.from_map(k))
        self.visible_users = []
        if m.get('visibleUsers') is not None:
            for k in m.get('visibleUsers'):
                temp_model = ListPartnerRolesResponseBodyListVisibleUsers()
                self.visible_users.append(temp_model.from_map(k))
        self.warning_depts = []
        if m.get('warningDepts') is not None:
            for k in m.get('warningDepts'):
                temp_model = ListPartnerRolesResponseBodyListWarningDepts()
                self.warning_depts.append(temp_model.from_map(k))
        self.warning_users = []
        if m.get('warningUsers') is not None:
            for k in m.get('warningUsers'):
                temp_model = ListPartnerRolesResponseBodyListWarningUsers()
                self.warning_users.append(temp_model.from_map(k))
        return self


class ListPartnerRolesResponseBody(TeaModel):
    def __init__(
        self,
        list: List[ListPartnerRolesResponseBodyList] = None,
    ):
        # This parameter is required.
        self.list = list

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
        result['list'] = []
        if self.list is not None:
            for k in self.list:
                result['list'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = ListPartnerRolesResponseBodyList()
                self.list.append(temp_model.from_map(k))
        return self


class ListPartnerRolesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListPartnerRolesResponseBody = None,
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
            temp_model = ListPartnerRolesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListPunchScheduleByConditionWithPagingHeaders(TeaModel):
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


class ListPunchScheduleByConditionWithPagingRequest(TeaModel):
    def __init__(
        self,
        biz_instance_id: str = None,
        max_results: int = None,
        next_token: int = None,
        schedule_date_end: str = None,
        schedule_date_start: str = None,
        user_id_list: List[str] = None,
    ):
        # This parameter is required.
        self.biz_instance_id = biz_instance_id
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
        self.next_token = next_token
        self.schedule_date_end = schedule_date_end
        self.schedule_date_start = schedule_date_start
        self.user_id_list = user_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_instance_id is not None:
            result['bizInstanceId'] = self.biz_instance_id
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.schedule_date_end is not None:
            result['scheduleDateEnd'] = self.schedule_date_end
        if self.schedule_date_start is not None:
            result['scheduleDateStart'] = self.schedule_date_start
        if self.user_id_list is not None:
            result['userIdList'] = self.user_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizInstanceId') is not None:
            self.biz_instance_id = m.get('bizInstanceId')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('scheduleDateEnd') is not None:
            self.schedule_date_end = m.get('scheduleDateEnd')
        if m.get('scheduleDateStart') is not None:
            self.schedule_date_start = m.get('scheduleDateStart')
        if m.get('userIdList') is not None:
            self.user_id_list = m.get('userIdList')
        return self


class ListPunchScheduleByConditionWithPagingResponseBodyList(TeaModel):
    def __init__(
        self,
        biz_outer_id: str = None,
        position_name: str = None,
        punch_symbol: str = None,
        user_id: str = None,
        user_punch_time: int = None,
    ):
        self.biz_outer_id = biz_outer_id
        self.position_name = position_name
        self.punch_symbol = punch_symbol
        self.user_id = user_id
        self.user_punch_time = user_punch_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_outer_id is not None:
            result['bizOuterId'] = self.biz_outer_id
        if self.position_name is not None:
            result['positionName'] = self.position_name
        if self.punch_symbol is not None:
            result['punchSymbol'] = self.punch_symbol
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.user_punch_time is not None:
            result['userPunchTime'] = self.user_punch_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizOuterId') is not None:
            self.biz_outer_id = m.get('bizOuterId')
        if m.get('positionName') is not None:
            self.position_name = m.get('positionName')
        if m.get('punchSymbol') is not None:
            self.punch_symbol = m.get('punchSymbol')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('userPunchTime') is not None:
            self.user_punch_time = m.get('userPunchTime')
        return self


class ListPunchScheduleByConditionWithPagingResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[ListPunchScheduleByConditionWithPagingResponseBodyList] = None,
        next_token: int = None,
    ):
        self.has_more = has_more
        self.list = list
        self.next_token = next_token

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = ListPunchScheduleByConditionWithPagingResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class ListPunchScheduleByConditionWithPagingResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListPunchScheduleByConditionWithPagingResponseBody = None,
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
            temp_model = ListPunchScheduleByConditionWithPagingResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListRulesHeaders(TeaModel):
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


class ListRulesRequestBody(TeaModel):
    def __init__(
        self,
        status: int = None,
    ):
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class ListRulesRequest(TeaModel):
    def __init__(
        self,
        body: ListRulesRequestBody = None,
    ):
        # This parameter is required.
        self.body = body

    def validate(self):
        if self.body:
            self.body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('body') is not None:
            temp_model = ListRulesRequestBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListRulesShrinkRequest(TeaModel):
    def __init__(
        self,
        body_shrink: str = None,
    ):
        # This parameter is required.
        self.body_shrink = body_shrink

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.body_shrink is not None:
            result['body'] = self.body_shrink
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('body') is not None:
            self.body_shrink = m.get('body')
        return self


class ListRulesResponseBody(TeaModel):
    def __init__(
        self,
        detail_model_list: List[Dict[str, str]] = None,
    ):
        self.detail_model_list = detail_model_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.detail_model_list is not None:
            result['detailModelList'] = self.detail_model_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('detailModelList') is not None:
            self.detail_model_list = m.get('detailModelList')
        return self


class ListRulesResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListRulesResponseBody = None,
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
            temp_model = ListRulesResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class LogoutHeaders(TeaModel):
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


class LogoutRequest(TeaModel):
    def __init__(
        self,
        device_type: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.device_type = device_type
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.device_type is not None:
            result['deviceType'] = self.device_type
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deviceType') is not None:
            self.device_type = m.get('deviceType')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class LogoutResponseBody(TeaModel):
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


class LogoutResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: LogoutResponseBody = None,
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
            temp_model = LogoutResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class OpenBenefitPackageHeaders(TeaModel):
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


class OpenBenefitPackageRequest(TeaModel):
    def __init__(
        self,
        benefit_package: int = None,
        end_date: int = None,
        start_date: int = None,
        target_corp_id: str = None,
    ):
        # This parameter is required.
        self.benefit_package = benefit_package
        # This parameter is required.
        self.end_date = end_date
        # This parameter is required.
        self.start_date = start_date
        # This parameter is required.
        self.target_corp_id = target_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.benefit_package is not None:
            result['benefitPackage'] = self.benefit_package
        if self.end_date is not None:
            result['endDate'] = self.end_date
        if self.start_date is not None:
            result['startDate'] = self.start_date
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('benefitPackage') is not None:
            self.benefit_package = m.get('benefitPackage')
        if m.get('endDate') is not None:
            self.end_date = m.get('endDate')
        if m.get('startDate') is not None:
            self.start_date = m.get('startDate')
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        return self


class OpenBenefitPackageResponseBody(TeaModel):
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


class OpenBenefitPackageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: OpenBenefitPackageResponseBody = None,
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
            temp_model = OpenBenefitPackageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class OpportunitySearchHeaders(TeaModel):
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


class OpportunitySearchRequest(TeaModel):
    def __init__(
        self,
        target_corp_id: str = None,
    ):
        # This parameter is required.
        self.target_corp_id = target_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        return self


class OpportunitySearchResponseBody(TeaModel):
    def __init__(
        self,
        opportunity_exist: bool = None,
    ):
        self.opportunity_exist = opportunity_exist

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.opportunity_exist is not None:
            result['opportunityExist'] = self.opportunity_exist
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('opportunityExist') is not None:
            self.opportunity_exist = m.get('opportunityExist')
        return self


class OpportunitySearchResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: OpportunitySearchResponseBody = None,
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
            temp_model = OpportunitySearchResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PreventCheatingCheckRiskHeaders(TeaModel):
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


class PreventCheatingCheckRiskRequest(TeaModel):
    def __init__(
        self,
        client_ver: str = None,
        platform: str = None,
        platform_ver: str = None,
        sec: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.client_ver = client_ver
        # This parameter is required.
        self.platform = platform
        # This parameter is required.
        self.platform_ver = platform_ver
        # This parameter is required.
        self.sec = sec
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.client_ver is not None:
            result['clientVer'] = self.client_ver
        if self.platform is not None:
            result['platform'] = self.platform
        if self.platform_ver is not None:
            result['platformVer'] = self.platform_ver
        if self.sec is not None:
            result['sec'] = self.sec
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('clientVer') is not None:
            self.client_ver = m.get('clientVer')
        if m.get('platform') is not None:
            self.platform = m.get('platform')
        if m.get('platformVer') is not None:
            self.platform_ver = m.get('platformVer')
        if m.get('sec') is not None:
            self.sec = m.get('sec')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class PreventCheatingCheckRiskResponseBodyResult(TeaModel):
    def __init__(
        self,
        has_risk: bool = None,
        risk_info: Dict[str, str] = None,
    ):
        # This parameter is required.
        self.has_risk = has_risk
        self.risk_info = risk_info

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.has_risk is not None:
            result['hasRisk'] = self.has_risk
        if self.risk_info is not None:
            result['riskInfo'] = self.risk_info
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasRisk') is not None:
            self.has_risk = m.get('hasRisk')
        if m.get('riskInfo') is not None:
            self.risk_info = m.get('riskInfo')
        return self


class PreventCheatingCheckRiskResponseBody(TeaModel):
    def __init__(
        self,
        result: PreventCheatingCheckRiskResponseBodyResult = None,
    ):
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
            temp_model = PreventCheatingCheckRiskResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class PreventCheatingCheckRiskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PreventCheatingCheckRiskResponseBody = None,
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
            temp_model = PreventCheatingCheckRiskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PublishFileChangeNoticeHeaders(TeaModel):
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


class PublishFileChangeNoticeRequest(TeaModel):
    def __init__(
        self,
        file_id: str = None,
        operate_type: str = None,
        operator_union_id: str = None,
        space_id: str = None,
    ):
        # This parameter is required.
        self.file_id = file_id
        self.operate_type = operate_type
        # This parameter is required.
        self.operator_union_id = operator_union_id
        # This parameter is required.
        self.space_id = space_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_id is not None:
            result['fileId'] = self.file_id
        if self.operate_type is not None:
            result['operateType'] = self.operate_type
        if self.operator_union_id is not None:
            result['operatorUnionId'] = self.operator_union_id
        if self.space_id is not None:
            result['spaceId'] = self.space_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileId') is not None:
            self.file_id = m.get('fileId')
        if m.get('operateType') is not None:
            self.operate_type = m.get('operateType')
        if m.get('operatorUnionId') is not None:
            self.operator_union_id = m.get('operatorUnionId')
        if m.get('spaceId') is not None:
            self.space_id = m.get('spaceId')
        return self


class PublishFileChangeNoticeResponse(TeaModel):
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


class PublishRuleHeaders(TeaModel):
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


class PublishRuleRequest(TeaModel):
    def __init__(
        self,
        status: int = None,
    ):
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class PublishRuleResponseBody(TeaModel):
    def __init__(
        self,
        is_publish: bool = None,
    ):
        # This parameter is required.
        self.is_publish = is_publish

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.is_publish is not None:
            result['isPublish'] = self.is_publish
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isPublish') is not None:
            self.is_publish = m.get('isPublish')
        return self


class PublishRuleResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PublishRuleResponseBody = None,
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
            temp_model = PublishRuleResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class PushBadgeHeaders(TeaModel):
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


class PushBadgeRequestBadgeItems(TeaModel):
    def __init__(
        self,
        push_value: str = None,
        user_id: str = None,
    ):
        self.push_value = push_value
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.push_value is not None:
            result['pushValue'] = self.push_value
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pushValue') is not None:
            self.push_value = m.get('pushValue')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class PushBadgeRequest(TeaModel):
    def __init__(
        self,
        agent_id: str = None,
        badge_items: List[PushBadgeRequestBadgeItems] = None,
        push_type: str = None,
    ):
        # This parameter is required.
        self.agent_id = agent_id
        self.badge_items = badge_items
        # This parameter is required.
        self.push_type = push_type

    def validate(self):
        if self.badge_items:
            for k in self.badge_items:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id is not None:
            result['agentId'] = self.agent_id
        result['badgeItems'] = []
        if self.badge_items is not None:
            for k in self.badge_items:
                result['badgeItems'].append(k.to_map() if k else None)
        if self.push_type is not None:
            result['pushType'] = self.push_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentId') is not None:
            self.agent_id = m.get('agentId')
        self.badge_items = []
        if m.get('badgeItems') is not None:
            for k in m.get('badgeItems'):
                temp_model = PushBadgeRequestBadgeItems()
                self.badge_items.append(temp_model.from_map(k))
        if m.get('pushType') is not None:
            self.push_type = m.get('pushType')
        return self


class PushBadgeResponseBody(TeaModel):
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


class PushBadgeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: PushBadgeResponseBody = None,
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
            temp_model = PushBadgeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryAcrossCloudStroageConfigsHeaders(TeaModel):
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


class QueryAcrossCloudStroageConfigsRequest(TeaModel):
    def __init__(
        self,
        target_cloud_type: int = None,
        target_corp_id: str = None,
    ):
        # This parameter is required.
        self.target_cloud_type = target_cloud_type
        # This parameter is required.
        self.target_corp_id = target_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.target_cloud_type is not None:
            result['targetCloudType'] = self.target_cloud_type
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('targetCloudType') is not None:
            self.target_cloud_type = m.get('targetCloudType')
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        return self


class QueryAcrossCloudStroageConfigsResponseBody(TeaModel):
    def __init__(
        self,
        access_key_id: str = None,
        access_key_secret: str = None,
        bucket_name: str = None,
        cloud_type: int = None,
        endpoint: str = None,
    ):
        # This parameter is required.
        self.access_key_id = access_key_id
        # This parameter is required.
        self.access_key_secret = access_key_secret
        # This parameter is required.
        self.bucket_name = bucket_name
        # This parameter is required.
        self.cloud_type = cloud_type
        # This parameter is required.
        self.endpoint = endpoint

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key_id is not None:
            result['accessKeyId'] = self.access_key_id
        if self.access_key_secret is not None:
            result['accessKeySecret'] = self.access_key_secret
        if self.bucket_name is not None:
            result['bucketName'] = self.bucket_name
        if self.cloud_type is not None:
            result['cloudType'] = self.cloud_type
        if self.endpoint is not None:
            result['endpoint'] = self.endpoint
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKeyId') is not None:
            self.access_key_id = m.get('accessKeyId')
        if m.get('accessKeySecret') is not None:
            self.access_key_secret = m.get('accessKeySecret')
        if m.get('bucketName') is not None:
            self.bucket_name = m.get('bucketName')
        if m.get('cloudType') is not None:
            self.cloud_type = m.get('cloudType')
        if m.get('endpoint') is not None:
            self.endpoint = m.get('endpoint')
        return self


class QueryAcrossCloudStroageConfigsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryAcrossCloudStroageConfigsResponseBody = None,
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
            temp_model = QueryAcrossCloudStroageConfigsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryChannelStaffInfoByMobileHeaders(TeaModel):
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


class QueryChannelStaffInfoByMobileRequest(TeaModel):
    def __init__(
        self,
        mobile: str = None,
        target_corp_id: str = None,
    ):
        # This parameter is required.
        self.mobile = mobile
        # This parameter is required.
        self.target_corp_id = target_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.mobile is not None:
            result['mobile'] = self.mobile
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('mobile') is not None:
            self.mobile = m.get('mobile')
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        return self


class QueryChannelStaffInfoByMobileResponseBodyEmpInfo(TeaModel):
    def __init__(
        self,
        name: str = None,
        user_id: str = None,
    ):
        self.name = name
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryChannelStaffInfoByMobileResponseBodyExclusiveAccountEmpInfoList(TeaModel):
    def __init__(
        self,
        name: str = None,
        user_id: str = None,
    ):
        self.name = name
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryChannelStaffInfoByMobileResponseBody(TeaModel):
    def __init__(
        self,
        emp_info: QueryChannelStaffInfoByMobileResponseBodyEmpInfo = None,
        exclusive_account_emp_info_list: List[QueryChannelStaffInfoByMobileResponseBodyExclusiveAccountEmpInfoList] = None,
    ):
        self.emp_info = emp_info
        self.exclusive_account_emp_info_list = exclusive_account_emp_info_list

    def validate(self):
        if self.emp_info:
            self.emp_info.validate()
        if self.exclusive_account_emp_info_list:
            for k in self.exclusive_account_emp_info_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.emp_info is not None:
            result['empInfo'] = self.emp_info.to_map()
        result['exclusiveAccountEmpInfoList'] = []
        if self.exclusive_account_emp_info_list is not None:
            for k in self.exclusive_account_emp_info_list:
                result['exclusiveAccountEmpInfoList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('empInfo') is not None:
            temp_model = QueryChannelStaffInfoByMobileResponseBodyEmpInfo()
            self.emp_info = temp_model.from_map(m['empInfo'])
        self.exclusive_account_emp_info_list = []
        if m.get('exclusiveAccountEmpInfoList') is not None:
            for k in m.get('exclusiveAccountEmpInfoList'):
                temp_model = QueryChannelStaffInfoByMobileResponseBodyExclusiveAccountEmpInfoList()
                self.exclusive_account_emp_info_list.append(temp_model.from_map(k))
        return self


class QueryChannelStaffInfoByMobileResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryChannelStaffInfoByMobileResponseBody = None,
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
            temp_model = QueryChannelStaffInfoByMobileResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryConversationPageHeaders(TeaModel):
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


class QueryConversationPageRequest(TeaModel):
    def __init__(
        self,
        category_id: int = None,
        max_results: int = None,
        next_token: str = None,
    ):
        # This parameter is required.
        self.category_id = category_id
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
        self.next_token = next_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.category_id is not None:
            result['categoryId'] = self.category_id
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('categoryId') is not None:
            self.category_id = m.get('categoryId')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        return self


class QueryConversationPageResponseBodyResultData(TeaModel):
    def __init__(
        self,
        category_id: int = None,
        category_name: str = None,
        group_code: str = None,
        group_members_cnt: int = None,
        group_name: str = None,
        group_owner_name: str = None,
        group_owner_user_id: str = None,
        is_kp_conversation: bool = None,
        manage_sign: int = None,
        open_conversation_id: str = None,
        order: int = None,
        status: int = None,
    ):
        self.category_id = category_id
        self.category_name = category_name
        self.group_code = group_code
        self.group_members_cnt = group_members_cnt
        self.group_name = group_name
        self.group_owner_name = group_owner_name
        self.group_owner_user_id = group_owner_user_id
        self.is_kp_conversation = is_kp_conversation
        self.manage_sign = manage_sign
        self.open_conversation_id = open_conversation_id
        self.order = order
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.category_id is not None:
            result['categoryId'] = self.category_id
        if self.category_name is not None:
            result['categoryName'] = self.category_name
        if self.group_code is not None:
            result['groupCode'] = self.group_code
        if self.group_members_cnt is not None:
            result['groupMembersCnt'] = self.group_members_cnt
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.group_owner_name is not None:
            result['groupOwnerName'] = self.group_owner_name
        if self.group_owner_user_id is not None:
            result['groupOwnerUserId'] = self.group_owner_user_id
        if self.is_kp_conversation is not None:
            result['isKpConversation'] = self.is_kp_conversation
        if self.manage_sign is not None:
            result['manageSign'] = self.manage_sign
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.order is not None:
            result['order'] = self.order
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('categoryId') is not None:
            self.category_id = m.get('categoryId')
        if m.get('categoryName') is not None:
            self.category_name = m.get('categoryName')
        if m.get('groupCode') is not None:
            self.group_code = m.get('groupCode')
        if m.get('groupMembersCnt') is not None:
            self.group_members_cnt = m.get('groupMembersCnt')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('groupOwnerName') is not None:
            self.group_owner_name = m.get('groupOwnerName')
        if m.get('groupOwnerUserId') is not None:
            self.group_owner_user_id = m.get('groupOwnerUserId')
        if m.get('isKpConversation') is not None:
            self.is_kp_conversation = m.get('isKpConversation')
        if m.get('manageSign') is not None:
            self.manage_sign = m.get('manageSign')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('order') is not None:
            self.order = m.get('order')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class QueryConversationPageResponseBodyResult(TeaModel):
    def __init__(
        self,
        data: List[QueryConversationPageResponseBodyResultData] = None,
        max_results: int = None,
        next_token: str = None,
        total_count: int = None,
    ):
        self.data = data
        self.max_results = max_results
        self.next_token = next_token
        self.total_count = total_count

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
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = QueryConversationPageResponseBodyResultData()
                self.data.append(temp_model.from_map(k))
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class QueryConversationPageResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryConversationPageResponseBodyResult = None,
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
            temp_model = QueryConversationPageResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryConversationPageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryConversationPageResponseBody = None,
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
            temp_model = QueryConversationPageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryExclusiveBenefitsHeaders(TeaModel):
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


class QueryExclusiveBenefitsResponseBody(TeaModel):
    def __init__(
        self,
        benefits_list: List[str] = None,
    ):
        self.benefits_list = benefits_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.benefits_list is not None:
            result['benefitsList'] = self.benefits_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('benefitsList') is not None:
            self.benefits_list = m.get('benefitsList')
        return self


class QueryExclusiveBenefitsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryExclusiveBenefitsResponseBody = None,
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
            temp_model = QueryExclusiveBenefitsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryPartnerInfoHeaders(TeaModel):
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


class QueryPartnerInfoResponseBodyPartnerDeptListPartnerLabelModelLevel1(TeaModel):
    def __init__(
        self,
        label_id: int = None,
        labelname: str = None,
    ):
        self.label_id = label_id
        self.labelname = labelname

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.label_id is not None:
            result['labelId'] = self.label_id
        if self.labelname is not None:
            result['labelname'] = self.labelname
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('labelId') is not None:
            self.label_id = m.get('labelId')
        if m.get('labelname') is not None:
            self.labelname = m.get('labelname')
        return self


class QueryPartnerInfoResponseBodyPartnerDeptList(TeaModel):
    def __init__(
        self,
        member_count: int = None,
        partner_label_model_level_1: QueryPartnerInfoResponseBodyPartnerDeptListPartnerLabelModelLevel1 = None,
        partner_num: str = None,
        title: str = None,
        value: str = None,
    ):
        # This parameter is required.
        self.member_count = member_count
        self.partner_label_model_level_1 = partner_label_model_level_1
        self.partner_num = partner_num
        # This parameter is required.
        self.title = title
        # This parameter is required.
        self.value = value

    def validate(self):
        if self.partner_label_model_level_1:
            self.partner_label_model_level_1.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.member_count is not None:
            result['memberCount'] = self.member_count
        if self.partner_label_model_level_1 is not None:
            result['partnerLabelModelLevel1'] = self.partner_label_model_level_1.to_map()
        if self.partner_num is not None:
            result['partnerNum'] = self.partner_num
        if self.title is not None:
            result['title'] = self.title
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('memberCount') is not None:
            self.member_count = m.get('memberCount')
        if m.get('partnerLabelModelLevel1') is not None:
            temp_model = QueryPartnerInfoResponseBodyPartnerDeptListPartnerLabelModelLevel1()
            self.partner_label_model_level_1 = temp_model.from_map(m['partnerLabelModelLevel1'])
        if m.get('partnerNum') is not None:
            self.partner_num = m.get('partnerNum')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class QueryPartnerInfoResponseBodyPartnerLabelList(TeaModel):
    def __init__(
        self,
        id: int = None,
        name: str = None,
    ):
        self.id = id
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.id is not None:
            result['id'] = self.id
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class QueryPartnerInfoResponseBody(TeaModel):
    def __init__(
        self,
        partner_dept_list: List[QueryPartnerInfoResponseBodyPartnerDeptList] = None,
        partner_label_list: List[QueryPartnerInfoResponseBodyPartnerLabelList] = None,
        user_id: str = None,
    ):
        self.partner_dept_list = partner_dept_list
        self.partner_label_list = partner_label_list
        self.user_id = user_id

    def validate(self):
        if self.partner_dept_list:
            for k in self.partner_dept_list:
                if k:
                    k.validate()
        if self.partner_label_list:
            for k in self.partner_label_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['partnerDeptList'] = []
        if self.partner_dept_list is not None:
            for k in self.partner_dept_list:
                result['partnerDeptList'].append(k.to_map() if k else None)
        result['partnerLabelList'] = []
        if self.partner_label_list is not None:
            for k in self.partner_label_list:
                result['partnerLabelList'].append(k.to_map() if k else None)
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.partner_dept_list = []
        if m.get('partnerDeptList') is not None:
            for k in m.get('partnerDeptList'):
                temp_model = QueryPartnerInfoResponseBodyPartnerDeptList()
                self.partner_dept_list.append(temp_model.from_map(k))
        self.partner_label_list = []
        if m.get('partnerLabelList') is not None:
            for k in m.get('partnerLabelList'):
                temp_model = QueryPartnerInfoResponseBodyPartnerLabelList()
                self.partner_label_list.append(temp_model.from_map(k))
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryPartnerInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryPartnerInfoResponseBody = None,
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
            temp_model = QueryPartnerInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryTemplateInfoHeaders(TeaModel):
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


class QueryTemplateInfoResponseBodyAppInfo(TeaModel):
    def __init__(
        self,
        app_icon: str = None,
        app_id: str = None,
        app_name: str = None,
        corp_id: str = None,
    ):
        self.app_icon = app_icon
        self.app_id = app_id
        self.app_name = app_name
        self.corp_id = corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_icon is not None:
            result['appIcon'] = self.app_icon
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.app_name is not None:
            result['appName'] = self.app_name
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appIcon') is not None:
            self.app_icon = m.get('appIcon')
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('appName') is not None:
            self.app_name = m.get('appName')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        return self


class QueryTemplateInfoResponseBodyGrayInfo(TeaModel):
    def __init__(
        self,
        ten_thousand_percent: int = None,
        white_set: List[str] = None,
    ):
        self.ten_thousand_percent = ten_thousand_percent
        self.white_set = white_set

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ten_thousand_percent is not None:
            result['tenThousandPercent'] = self.ten_thousand_percent
        if self.white_set is not None:
            result['whiteSet'] = self.white_set
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('tenThousandPercent') is not None:
            self.ten_thousand_percent = m.get('tenThousandPercent')
        if m.get('whiteSet') is not None:
            self.white_set = m.get('whiteSet')
        return self


class QueryTemplateInfoResponseBodyGroupSettingList(TeaModel):
    def __init__(
        self,
        desc: str = None,
        name: str = None,
        state: bool = None,
    ):
        self.desc = desc
        self.name = name
        self.state = state

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.desc is not None:
            result['desc'] = self.desc
        if self.name is not None:
            result['name'] = self.name
        if self.state is not None:
            result['state'] = self.state
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('desc') is not None:
            self.desc = m.get('desc')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('state') is not None:
            self.state = m.get('state')
        return self


class QueryTemplateInfoResponseBodyParentTemplateDetailVORobotTemplateList(TeaModel):
    def __init__(
        self,
        brief: str = None,
        code: str = None,
        corp_id: str = None,
        create_at: int = None,
        description: str = None,
        dev: str = None,
        group_template_id: str = None,
        icon: str = None,
        modified_at: int = None,
        name: str = None,
        outgoing_token: str = None,
        outgoing_url: str = None,
        preview_media_id: str = None,
        source_url: str = None,
        status: int = None,
    ):
        self.brief = brief
        self.code = code
        self.corp_id = corp_id
        self.create_at = create_at
        self.description = description
        self.dev = dev
        self.group_template_id = group_template_id
        self.icon = icon
        self.modified_at = modified_at
        self.name = name
        self.outgoing_token = outgoing_token
        self.outgoing_url = outgoing_url
        self.preview_media_id = preview_media_id
        self.source_url = source_url
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.brief is not None:
            result['brief'] = self.brief
        if self.code is not None:
            result['code'] = self.code
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.create_at is not None:
            result['createAt'] = self.create_at
        if self.description is not None:
            result['description'] = self.description
        if self.dev is not None:
            result['dev'] = self.dev
        if self.group_template_id is not None:
            result['groupTemplateId'] = self.group_template_id
        if self.icon is not None:
            result['icon'] = self.icon
        if self.modified_at is not None:
            result['modifiedAt'] = self.modified_at
        if self.name is not None:
            result['name'] = self.name
        if self.outgoing_token is not None:
            result['outgoingToken'] = self.outgoing_token
        if self.outgoing_url is not None:
            result['outgoingUrl'] = self.outgoing_url
        if self.preview_media_id is not None:
            result['previewMediaId'] = self.preview_media_id
        if self.source_url is not None:
            result['sourceUrl'] = self.source_url
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('brief') is not None:
            self.brief = m.get('brief')
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('createAt') is not None:
            self.create_at = m.get('createAt')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('dev') is not None:
            self.dev = m.get('dev')
        if m.get('groupTemplateId') is not None:
            self.group_template_id = m.get('groupTemplateId')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('modifiedAt') is not None:
            self.modified_at = m.get('modifiedAt')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('outgoingToken') is not None:
            self.outgoing_token = m.get('outgoingToken')
        if m.get('outgoingUrl') is not None:
            self.outgoing_url = m.get('outgoingUrl')
        if m.get('previewMediaId') is not None:
            self.preview_media_id = m.get('previewMediaId')
        if m.get('sourceUrl') is not None:
            self.source_url = m.get('sourceUrl')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class QueryTemplateInfoResponseBodyParentTemplateDetailVOToolbarPluginList(TeaModel):
    def __init__(
        self,
        app_id: str = None,
        create_at: int = None,
        desc: str = None,
        icons: str = None,
        modified_at: int = None,
        name: str = None,
        pc_url: str = None,
        plugin_id: str = None,
        status: int = None,
        url: str = None,
    ):
        self.app_id = app_id
        self.create_at = create_at
        self.desc = desc
        self.icons = icons
        self.modified_at = modified_at
        self.name = name
        self.pc_url = pc_url
        self.plugin_id = plugin_id
        self.status = status
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_id is not None:
            result['appId'] = self.app_id
        if self.create_at is not None:
            result['createAt'] = self.create_at
        if self.desc is not None:
            result['desc'] = self.desc
        if self.icons is not None:
            result['icons'] = self.icons
        if self.modified_at is not None:
            result['modifiedAt'] = self.modified_at
        if self.name is not None:
            result['name'] = self.name
        if self.pc_url is not None:
            result['pcUrl'] = self.pc_url
        if self.plugin_id is not None:
            result['pluginId'] = self.plugin_id
        if self.status is not None:
            result['status'] = self.status
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appId') is not None:
            self.app_id = m.get('appId')
        if m.get('createAt') is not None:
            self.create_at = m.get('createAt')
        if m.get('desc') is not None:
            self.desc = m.get('desc')
        if m.get('icons') is not None:
            self.icons = m.get('icons')
        if m.get('modifiedAt') is not None:
            self.modified_at = m.get('modifiedAt')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('pcUrl') is not None:
            self.pc_url = m.get('pcUrl')
        if m.get('pluginId') is not None:
            self.plugin_id = m.get('pluginId')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class QueryTemplateInfoResponseBodyParentTemplateDetailVO(TeaModel):
    def __init__(
        self,
        robot_template_list: List[QueryTemplateInfoResponseBodyParentTemplateDetailVORobotTemplateList] = None,
        template_id: str = None,
        toolbar_plugin_list: List[QueryTemplateInfoResponseBodyParentTemplateDetailVOToolbarPluginList] = None,
    ):
        self.robot_template_list = robot_template_list
        self.template_id = template_id
        self.toolbar_plugin_list = toolbar_plugin_list

    def validate(self):
        if self.robot_template_list:
            for k in self.robot_template_list:
                if k:
                    k.validate()
        if self.toolbar_plugin_list:
            for k in self.toolbar_plugin_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['robotTemplateList'] = []
        if self.robot_template_list is not None:
            for k in self.robot_template_list:
                result['robotTemplateList'].append(k.to_map() if k else None)
        if self.template_id is not None:
            result['templateId'] = self.template_id
        result['toolbarPluginList'] = []
        if self.toolbar_plugin_list is not None:
            for k in self.toolbar_plugin_list:
                result['toolbarPluginList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.robot_template_list = []
        if m.get('robotTemplateList') is not None:
            for k in m.get('robotTemplateList'):
                temp_model = QueryTemplateInfoResponseBodyParentTemplateDetailVORobotTemplateList()
                self.robot_template_list.append(temp_model.from_map(k))
        if m.get('templateId') is not None:
            self.template_id = m.get('templateId')
        self.toolbar_plugin_list = []
        if m.get('toolbarPluginList') is not None:
            for k in m.get('toolbarPluginList'):
                temp_model = QueryTemplateInfoResponseBodyParentTemplateDetailVOToolbarPluginList()
                self.toolbar_plugin_list.append(temp_model.from_map(k))
        return self


class QueryTemplateInfoResponseBodyTemplateIntroduction(TeaModel):
    def __init__(
        self,
        banner: str = None,
        detail: str = None,
        title: str = None,
    ):
        self.banner = banner
        self.detail = detail
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.banner is not None:
            result['banner'] = self.banner
        if self.detail is not None:
            result['detail'] = self.detail
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('banner') is not None:
            self.banner = m.get('banner')
        if m.get('detail') is not None:
            self.detail = m.get('detail')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class QueryTemplateInfoResponseBodyTemplateVisibilityDeptIds(TeaModel):
    def __init__(
        self,
        dept_id: str = None,
        dept_name: str = None,
    ):
        self.dept_id = dept_id
        self.dept_name = dept_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.dept_name is not None:
            result['deptName'] = self.dept_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('deptName') is not None:
            self.dept_name = m.get('deptName')
        return self


class QueryTemplateInfoResponseBodyTemplateVisibilityUserIds(TeaModel):
    def __init__(
        self,
        avatar: str = None,
        nick: str = None,
        user_id: str = None,
    ):
        self.avatar = avatar
        self.nick = nick
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.avatar is not None:
            result['avatar'] = self.avatar
        if self.nick is not None:
            result['nick'] = self.nick
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('avatar') is not None:
            self.avatar = m.get('avatar')
        if m.get('nick') is not None:
            self.nick = m.get('nick')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryTemplateInfoResponseBodyTemplateVisibility(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        dept_ids: List[QueryTemplateInfoResponseBodyTemplateVisibilityDeptIds] = None,
        role_ids: List[str] = None,
        user_ids: List[QueryTemplateInfoResponseBodyTemplateVisibilityUserIds] = None,
    ):
        self.corp_id = corp_id
        self.dept_ids = dept_ids
        self.role_ids = role_ids
        self.user_ids = user_ids

    def validate(self):
        if self.dept_ids:
            for k in self.dept_ids:
                if k:
                    k.validate()
        if self.user_ids:
            for k in self.user_ids:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        result['deptIds'] = []
        if self.dept_ids is not None:
            for k in self.dept_ids:
                result['deptIds'].append(k.to_map() if k else None)
        if self.role_ids is not None:
            result['roleIds'] = self.role_ids
        result['userIds'] = []
        if self.user_ids is not None:
            for k in self.user_ids:
                result['userIds'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        self.dept_ids = []
        if m.get('deptIds') is not None:
            for k in m.get('deptIds'):
                temp_model = QueryTemplateInfoResponseBodyTemplateVisibilityDeptIds()
                self.dept_ids.append(temp_model.from_map(k))
        if m.get('roleIds') is not None:
            self.role_ids = m.get('roleIds')
        self.user_ids = []
        if m.get('userIds') is not None:
            for k in m.get('userIds'):
                temp_model = QueryTemplateInfoResponseBodyTemplateVisibilityUserIds()
                self.user_ids.append(temp_model.from_map(k))
        return self


class QueryTemplateInfoResponseBody(TeaModel):
    def __init__(
        self,
        ability_switch: int = None,
        app_info: QueryTemplateInfoResponseBodyAppInfo = None,
        conversation_scope: List[str] = None,
        create_at: int = None,
        description: str = None,
        gray_conversation_ids: List[str] = None,
        gray_info: QueryTemplateInfoResponseBodyGrayInfo = None,
        gray_template_id: str = None,
        group_setting_list: List[QueryTemplateInfoResponseBodyGroupSettingList] = None,
        icon_media_id: str = None,
        modified_at: int = None,
        modify_order_id: int = None,
        modify_status: int = None,
        parent_template_detail_vo: QueryTemplateInfoResponseBodyParentTemplateDetailVO = None,
        publish_sub_state: str = None,
        robot_template_list: List[str] = None,
        status: int = None,
        template_id: str = None,
        template_introduction: QueryTemplateInfoResponseBodyTemplateIntroduction = None,
        template_name: str = None,
        template_type: int = None,
        template_visibility: QueryTemplateInfoResponseBodyTemplateVisibility = None,
        toolbar_plugin_list: List[str] = None,
        version: int = None,
    ):
        self.ability_switch = ability_switch
        self.app_info = app_info
        self.conversation_scope = conversation_scope
        self.create_at = create_at
        self.description = description
        self.gray_conversation_ids = gray_conversation_ids
        self.gray_info = gray_info
        self.gray_template_id = gray_template_id
        self.group_setting_list = group_setting_list
        self.icon_media_id = icon_media_id
        self.modified_at = modified_at
        self.modify_order_id = modify_order_id
        self.modify_status = modify_status
        self.parent_template_detail_vo = parent_template_detail_vo
        self.publish_sub_state = publish_sub_state
        self.robot_template_list = robot_template_list
        self.status = status
        self.template_id = template_id
        self.template_introduction = template_introduction
        self.template_name = template_name
        self.template_type = template_type
        self.template_visibility = template_visibility
        self.toolbar_plugin_list = toolbar_plugin_list
        self.version = version

    def validate(self):
        if self.app_info:
            self.app_info.validate()
        if self.gray_info:
            self.gray_info.validate()
        if self.group_setting_list:
            for k in self.group_setting_list:
                if k:
                    k.validate()
        if self.parent_template_detail_vo:
            self.parent_template_detail_vo.validate()
        if self.template_introduction:
            self.template_introduction.validate()
        if self.template_visibility:
            self.template_visibility.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ability_switch is not None:
            result['abilitySwitch'] = self.ability_switch
        if self.app_info is not None:
            result['appInfo'] = self.app_info.to_map()
        if self.conversation_scope is not None:
            result['conversationScope'] = self.conversation_scope
        if self.create_at is not None:
            result['createAt'] = self.create_at
        if self.description is not None:
            result['description'] = self.description
        if self.gray_conversation_ids is not None:
            result['grayConversationIds'] = self.gray_conversation_ids
        if self.gray_info is not None:
            result['grayInfo'] = self.gray_info.to_map()
        if self.gray_template_id is not None:
            result['grayTemplateId'] = self.gray_template_id
        result['groupSettingList'] = []
        if self.group_setting_list is not None:
            for k in self.group_setting_list:
                result['groupSettingList'].append(k.to_map() if k else None)
        if self.icon_media_id is not None:
            result['iconMediaId'] = self.icon_media_id
        if self.modified_at is not None:
            result['modifiedAt'] = self.modified_at
        if self.modify_order_id is not None:
            result['modifyOrderId'] = self.modify_order_id
        if self.modify_status is not None:
            result['modifyStatus'] = self.modify_status
        if self.parent_template_detail_vo is not None:
            result['parentTemplateDetailVO'] = self.parent_template_detail_vo.to_map()
        if self.publish_sub_state is not None:
            result['publishSubState'] = self.publish_sub_state
        if self.robot_template_list is not None:
            result['robotTemplateList'] = self.robot_template_list
        if self.status is not None:
            result['status'] = self.status
        if self.template_id is not None:
            result['templateId'] = self.template_id
        if self.template_introduction is not None:
            result['templateIntroduction'] = self.template_introduction.to_map()
        if self.template_name is not None:
            result['templateName'] = self.template_name
        if self.template_type is not None:
            result['templateType'] = self.template_type
        if self.template_visibility is not None:
            result['templateVisibility'] = self.template_visibility.to_map()
        if self.toolbar_plugin_list is not None:
            result['toolbarPluginList'] = self.toolbar_plugin_list
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('abilitySwitch') is not None:
            self.ability_switch = m.get('abilitySwitch')
        if m.get('appInfo') is not None:
            temp_model = QueryTemplateInfoResponseBodyAppInfo()
            self.app_info = temp_model.from_map(m['appInfo'])
        if m.get('conversationScope') is not None:
            self.conversation_scope = m.get('conversationScope')
        if m.get('createAt') is not None:
            self.create_at = m.get('createAt')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('grayConversationIds') is not None:
            self.gray_conversation_ids = m.get('grayConversationIds')
        if m.get('grayInfo') is not None:
            temp_model = QueryTemplateInfoResponseBodyGrayInfo()
            self.gray_info = temp_model.from_map(m['grayInfo'])
        if m.get('grayTemplateId') is not None:
            self.gray_template_id = m.get('grayTemplateId')
        self.group_setting_list = []
        if m.get('groupSettingList') is not None:
            for k in m.get('groupSettingList'):
                temp_model = QueryTemplateInfoResponseBodyGroupSettingList()
                self.group_setting_list.append(temp_model.from_map(k))
        if m.get('iconMediaId') is not None:
            self.icon_media_id = m.get('iconMediaId')
        if m.get('modifiedAt') is not None:
            self.modified_at = m.get('modifiedAt')
        if m.get('modifyOrderId') is not None:
            self.modify_order_id = m.get('modifyOrderId')
        if m.get('modifyStatus') is not None:
            self.modify_status = m.get('modifyStatus')
        if m.get('parentTemplateDetailVO') is not None:
            temp_model = QueryTemplateInfoResponseBodyParentTemplateDetailVO()
            self.parent_template_detail_vo = temp_model.from_map(m['parentTemplateDetailVO'])
        if m.get('publishSubState') is not None:
            self.publish_sub_state = m.get('publishSubState')
        if m.get('robotTemplateList') is not None:
            self.robot_template_list = m.get('robotTemplateList')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('templateId') is not None:
            self.template_id = m.get('templateId')
        if m.get('templateIntroduction') is not None:
            temp_model = QueryTemplateInfoResponseBodyTemplateIntroduction()
            self.template_introduction = temp_model.from_map(m['templateIntroduction'])
        if m.get('templateName') is not None:
            self.template_name = m.get('templateName')
        if m.get('templateType') is not None:
            self.template_type = m.get('templateType')
        if m.get('templateVisibility') is not None:
            temp_model = QueryTemplateInfoResponseBodyTemplateVisibility()
            self.template_visibility = temp_model.from_map(m['templateVisibility'])
        if m.get('toolbarPluginList') is not None:
            self.toolbar_plugin_list = m.get('toolbarPluginList')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class QueryTemplateInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryTemplateInfoResponseBody = None,
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
            temp_model = QueryTemplateInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryUserBehaviorHeaders(TeaModel):
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


class QueryUserBehaviorRequest(TeaModel):
    def __init__(
        self,
        end_time: int = None,
        page_number: int = None,
        page_size: int = None,
        platform: int = None,
        start_time: int = None,
        type: int = None,
        user_id: str = None,
    ):
        self.end_time = end_time
        # This parameter is required.
        self.page_number = page_number
        # This parameter is required.
        self.page_size = page_size
        # This parameter is required.
        self.platform = platform
        self.start_time = start_time
        # This parameter is required.
        self.type = type
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.platform is not None:
            result['platform'] = self.platform
        if self.start_time is not None:
            result['startTime'] = self.start_time
        if self.type is not None:
            result['type'] = self.type
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('platform') is not None:
            self.platform = m.get('platform')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryUserBehaviorResponseBodyData(TeaModel):
    def __init__(
        self,
        picture_url: str = None,
        platform: int = None,
        scene: str = None,
        time: int = None,
        type: int = None,
        user_id: str = None,
        user_name: str = None,
    ):
        self.picture_url = picture_url
        self.platform = platform
        self.scene = scene
        self.time = time
        self.type = type
        self.user_id = user_id
        self.user_name = user_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.picture_url is not None:
            result['pictureUrl'] = self.picture_url
        if self.platform is not None:
            result['platform'] = self.platform
        if self.scene is not None:
            result['scene'] = self.scene
        if self.time is not None:
            result['time'] = self.time
        if self.type is not None:
            result['type'] = self.type
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.user_name is not None:
            result['userName'] = self.user_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('pictureUrl') is not None:
            self.picture_url = m.get('pictureUrl')
        if m.get('platform') is not None:
            self.platform = m.get('platform')
        if m.get('scene') is not None:
            self.scene = m.get('scene')
        if m.get('time') is not None:
            self.time = m.get('time')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('userName') is not None:
            self.user_name = m.get('userName')
        return self


class QueryUserBehaviorResponseBody(TeaModel):
    def __init__(
        self,
        data: List[QueryUserBehaviorResponseBodyData] = None,
        data_cnt: int = None,
        total_cnt: int = None,
    ):
        self.data = data
        self.data_cnt = data_cnt
        self.total_cnt = total_cnt

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
        if self.data_cnt is not None:
            result['dataCnt'] = self.data_cnt
        if self.total_cnt is not None:
            result['totalCnt'] = self.total_cnt
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = QueryUserBehaviorResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('dataCnt') is not None:
            self.data_cnt = m.get('dataCnt')
        if m.get('totalCnt') is not None:
            self.total_cnt = m.get('totalCnt')
        return self


class QueryUserBehaviorResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryUserBehaviorResponseBody = None,
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
            temp_model = QueryUserBehaviorResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RollbackMiniAppVersionHeaders(TeaModel):
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


class RollbackMiniAppVersionRequest(TeaModel):
    def __init__(
        self,
        mini_app_id: str = None,
        rollback_version: str = None,
        target_version: str = None,
    ):
        self.mini_app_id = mini_app_id
        self.rollback_version = rollback_version
        self.target_version = target_version

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.mini_app_id is not None:
            result['miniAppId'] = self.mini_app_id
        if self.rollback_version is not None:
            result['rollbackVersion'] = self.rollback_version
        if self.target_version is not None:
            result['targetVersion'] = self.target_version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('miniAppId') is not None:
            self.mini_app_id = m.get('miniAppId')
        if m.get('rollbackVersion') is not None:
            self.rollback_version = m.get('rollbackVersion')
        if m.get('targetVersion') is not None:
            self.target_version = m.get('targetVersion')
        return self


class RollbackMiniAppVersionResponseBody(TeaModel):
    def __init__(
        self,
        cause: str = None,
        code: int = None,
    ):
        self.cause = cause
        self.code = code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cause is not None:
            result['cause'] = self.cause
        if self.code is not None:
            result['code'] = self.code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cause') is not None:
            self.cause = m.get('cause')
        if m.get('code') is not None:
            self.code = m.get('code')
        return self


class RollbackMiniAppVersionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RollbackMiniAppVersionResponseBody = None,
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
            temp_model = RollbackMiniAppVersionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RuleBatchReceiverHeaders(TeaModel):
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


class RuleBatchReceiverRequestDataAttrs(TeaModel):
    def __init__(
        self,
        list_unit_id: List[int] = None,
    ):
        self.list_unit_id = list_unit_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.list_unit_id is not None:
            result['listUnitId'] = self.list_unit_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('listUnitId') is not None:
            self.list_unit_id = m.get('listUnitId')
        return self


class RuleBatchReceiverRequestData(TeaModel):
    def __init__(
        self,
        at_account: str = None,
        attrs: RuleBatchReceiverRequestDataAttrs = None,
        callback_url: str = None,
        card_callback_url: str = None,
        content: Dict[str, dict] = None,
        is_at_all: bool = None,
        receiver_account: str = None,
        receiver_type: int = None,
        serial_number: str = None,
    ):
        self.at_account = at_account
        self.attrs = attrs
        self.callback_url = callback_url
        self.card_callback_url = card_callback_url
        self.content = content
        self.is_at_all = is_at_all
        self.receiver_account = receiver_account
        self.receiver_type = receiver_type
        self.serial_number = serial_number

    def validate(self):
        if self.attrs:
            self.attrs.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.at_account is not None:
            result['atAccount'] = self.at_account
        if self.attrs is not None:
            result['attrs'] = self.attrs.to_map()
        if self.callback_url is not None:
            result['callbackUrl'] = self.callback_url
        if self.card_callback_url is not None:
            result['cardCallbackUrl'] = self.card_callback_url
        if self.content is not None:
            result['content'] = self.content
        if self.is_at_all is not None:
            result['isAtAll'] = self.is_at_all
        if self.receiver_account is not None:
            result['receiverAccount'] = self.receiver_account
        if self.receiver_type is not None:
            result['receiverType'] = self.receiver_type
        if self.serial_number is not None:
            result['serialNumber'] = self.serial_number
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('atAccount') is not None:
            self.at_account = m.get('atAccount')
        if m.get('attrs') is not None:
            temp_model = RuleBatchReceiverRequestDataAttrs()
            self.attrs = temp_model.from_map(m['attrs'])
        if m.get('callbackUrl') is not None:
            self.callback_url = m.get('callbackUrl')
        if m.get('cardCallbackUrl') is not None:
            self.card_callback_url = m.get('cardCallbackUrl')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('isAtAll') is not None:
            self.is_at_all = m.get('isAtAll')
        if m.get('receiverAccount') is not None:
            self.receiver_account = m.get('receiverAccount')
        if m.get('receiverType') is not None:
            self.receiver_type = m.get('receiverType')
        if m.get('serialNumber') is not None:
            self.serial_number = m.get('serialNumber')
        return self


class RuleBatchReceiverRequest(TeaModel):
    def __init__(
        self,
        batch_no: str = None,
        card_options: str = None,
        data: List[RuleBatchReceiverRequestData] = None,
        rule_code: str = None,
        secret_key: str = None,
        special_strategy: bool = None,
        task_batch_no: str = None,
    ):
        self.batch_no = batch_no
        self.card_options = card_options
        self.data = data
        self.rule_code = rule_code
        self.secret_key = secret_key
        self.special_strategy = special_strategy
        self.task_batch_no = task_batch_no

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
        if self.batch_no is not None:
            result['batchNo'] = self.batch_no
        if self.card_options is not None:
            result['cardOptions'] = self.card_options
        result['data'] = []
        if self.data is not None:
            for k in self.data:
                result['data'].append(k.to_map() if k else None)
        if self.rule_code is not None:
            result['ruleCode'] = self.rule_code
        if self.secret_key is not None:
            result['secretKey'] = self.secret_key
        if self.special_strategy is not None:
            result['specialStrategy'] = self.special_strategy
        if self.task_batch_no is not None:
            result['taskBatchNo'] = self.task_batch_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('batchNo') is not None:
            self.batch_no = m.get('batchNo')
        if m.get('cardOptions') is not None:
            self.card_options = m.get('cardOptions')
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = RuleBatchReceiverRequestData()
                self.data.append(temp_model.from_map(k))
        if m.get('ruleCode') is not None:
            self.rule_code = m.get('ruleCode')
        if m.get('secretKey') is not None:
            self.secret_key = m.get('secretKey')
        if m.get('specialStrategy') is not None:
            self.special_strategy = m.get('specialStrategy')
        if m.get('taskBatchNo') is not None:
            self.task_batch_no = m.get('taskBatchNo')
        return self


class RuleBatchReceiverResponseBodyData(TeaModel):
    def __init__(
        self,
        msg_id: str = None,
        serial_number: str = None,
    ):
        self.msg_id = msg_id
        self.serial_number = serial_number

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.msg_id is not None:
            result['msgId'] = self.msg_id
        if self.serial_number is not None:
            result['serialNumber'] = self.serial_number
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('msgId') is not None:
            self.msg_id = m.get('msgId')
        if m.get('serialNumber') is not None:
            self.serial_number = m.get('serialNumber')
        return self


class RuleBatchReceiverResponseBodyRows(TeaModel):
    def __init__(
        self,
        serial_number: str = None,
        msg_id: str = None,
    ):
        self.serial_number = serial_number
        self.msg_id = msg_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.serial_number is not None:
            result['serialNumber'] = self.serial_number
        if self.msg_id is not None:
            result['msgId'] = self.msg_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('serialNumber') is not None:
            self.serial_number = m.get('serialNumber')
        if m.get('msgId') is not None:
            self.msg_id = m.get('msgId')
        return self


class RuleBatchReceiverResponseBody(TeaModel):
    def __init__(
        self,
        code: int = None,
        data: List[RuleBatchReceiverResponseBodyData] = None,
        msg: str = None,
        msg_id: str = None,
        rows: List[List[RuleBatchReceiverResponseBodyRows]] = None,
    ):
        self.code = code
        self.data = data
        self.msg = msg
        self.msg_id = msg_id
        self.rows = rows

    def validate(self):
        if self.data:
            for k in self.data:
                if k:
                    k.validate()
        if self.rows:
            for k in self.rows:
                for k1 in k:
                    if k1:
                        k1.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        result['data'] = []
        if self.data is not None:
            for k in self.data:
                result['data'].append(k.to_map() if k else None)
        if self.msg is not None:
            result['msg'] = self.msg
        if self.msg_id is not None:
            result['msgId'] = self.msg_id
        result['rows'] = []
        if self.rows is not None:
            for k in self.rows:
                l1 = []
                for k1 in k:
                    l1.append(k1.to_map() if k1 else None)
                result['rows'].append(l1)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = RuleBatchReceiverResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('msg') is not None:
            self.msg = m.get('msg')
        if m.get('msgId') is not None:
            self.msg_id = m.get('msgId')
        self.rows = []
        if m.get('rows') is not None:
            for k in m.get('rows'):
                l1 = []
                for k1 in k:
                    temp_model = RuleBatchReceiverResponseBodyRows()
                    l1.append(temp_model.from_map(k1))
                self.rows.append(l1)
        return self


class RuleBatchReceiverResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RuleBatchReceiverResponseBody = None,
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
            temp_model = RuleBatchReceiverResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SaveAcrossCloudStroageConfigsHeaders(TeaModel):
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


class SaveAcrossCloudStroageConfigsRequest(TeaModel):
    def __init__(
        self,
        access_key_id: str = None,
        access_key_secret: str = None,
        bucket_name: str = None,
        cloud_type: int = None,
        endpoint: str = None,
        target_corp_id: str = None,
    ):
        self.access_key_id = access_key_id
        self.access_key_secret = access_key_secret
        self.bucket_name = bucket_name
        # This parameter is required.
        self.cloud_type = cloud_type
        self.endpoint = endpoint
        # This parameter is required.
        self.target_corp_id = target_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key_id is not None:
            result['accessKeyId'] = self.access_key_id
        if self.access_key_secret is not None:
            result['accessKeySecret'] = self.access_key_secret
        if self.bucket_name is not None:
            result['bucketName'] = self.bucket_name
        if self.cloud_type is not None:
            result['cloudType'] = self.cloud_type
        if self.endpoint is not None:
            result['endpoint'] = self.endpoint
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKeyId') is not None:
            self.access_key_id = m.get('accessKeyId')
        if m.get('accessKeySecret') is not None:
            self.access_key_secret = m.get('accessKeySecret')
        if m.get('bucketName') is not None:
            self.bucket_name = m.get('bucketName')
        if m.get('cloudType') is not None:
            self.cloud_type = m.get('cloudType')
        if m.get('endpoint') is not None:
            self.endpoint = m.get('endpoint')
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        return self


class SaveAcrossCloudStroageConfigsResponseBody(TeaModel):
    def __init__(
        self,
        access_key_id: str = None,
        endpoint: str = None,
        state: int = None,
    ):
        self.access_key_id = access_key_id
        # This parameter is required.
        self.endpoint = endpoint
        # This parameter is required.
        self.state = state

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.access_key_id is not None:
            result['accessKeyId'] = self.access_key_id
        if self.endpoint is not None:
            result['endpoint'] = self.endpoint
        if self.state is not None:
            result['state'] = self.state
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKeyId') is not None:
            self.access_key_id = m.get('accessKeyId')
        if m.get('endpoint') is not None:
            self.endpoint = m.get('endpoint')
        if m.get('state') is not None:
            self.state = m.get('state')
        return self


class SaveAcrossCloudStroageConfigsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SaveAcrossCloudStroageConfigsResponseBody = None,
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
            temp_model = SaveAcrossCloudStroageConfigsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SaveAndSubmitAuthInfoHeaders(TeaModel):
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


class SaveAndSubmitAuthInfoRequest(TeaModel):
    def __init__(
        self,
        apply_remark: str = None,
        authorize_media_id: str = None,
        industry: str = None,
        legal_person: str = None,
        legal_person_id_card: str = None,
        license_media_id: str = None,
        loc_city: int = None,
        loc_city_name: str = None,
        loc_province: int = None,
        loc_province_name: str = None,
        mobile_num: str = None,
        org_name: str = None,
        organization_code: str = None,
        organization_code_media_id: str = None,
        regist_location: str = None,
        regist_num: str = None,
        target_corp_id: str = None,
        unified_social_credit: str = None,
    ):
        self.apply_remark = apply_remark
        self.authorize_media_id = authorize_media_id
        # This parameter is required.
        self.industry = industry
        # This parameter is required.
        self.legal_person = legal_person
        # This parameter is required.
        self.legal_person_id_card = legal_person_id_card
        self.license_media_id = license_media_id
        # This parameter is required.
        self.loc_city = loc_city
        # This parameter is required.
        self.loc_city_name = loc_city_name
        # This parameter is required.
        self.loc_province = loc_province
        # This parameter is required.
        self.loc_province_name = loc_province_name
        # This parameter is required.
        self.mobile_num = mobile_num
        # This parameter is required.
        self.org_name = org_name
        self.organization_code = organization_code
        self.organization_code_media_id = organization_code_media_id
        # This parameter is required.
        self.regist_location = regist_location
        self.regist_num = regist_num
        # This parameter is required.
        self.target_corp_id = target_corp_id
        self.unified_social_credit = unified_social_credit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.apply_remark is not None:
            result['applyRemark'] = self.apply_remark
        if self.authorize_media_id is not None:
            result['authorizeMediaId'] = self.authorize_media_id
        if self.industry is not None:
            result['industry'] = self.industry
        if self.legal_person is not None:
            result['legalPerson'] = self.legal_person
        if self.legal_person_id_card is not None:
            result['legalPersonIdCard'] = self.legal_person_id_card
        if self.license_media_id is not None:
            result['licenseMediaId'] = self.license_media_id
        if self.loc_city is not None:
            result['locCity'] = self.loc_city
        if self.loc_city_name is not None:
            result['locCityName'] = self.loc_city_name
        if self.loc_province is not None:
            result['locProvince'] = self.loc_province
        if self.loc_province_name is not None:
            result['locProvinceName'] = self.loc_province_name
        if self.mobile_num is not None:
            result['mobileNum'] = self.mobile_num
        if self.org_name is not None:
            result['orgName'] = self.org_name
        if self.organization_code is not None:
            result['organizationCode'] = self.organization_code
        if self.organization_code_media_id is not None:
            result['organizationCodeMediaId'] = self.organization_code_media_id
        if self.regist_location is not None:
            result['registLocation'] = self.regist_location
        if self.regist_num is not None:
            result['registNum'] = self.regist_num
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        if self.unified_social_credit is not None:
            result['unifiedSocialCredit'] = self.unified_social_credit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('applyRemark') is not None:
            self.apply_remark = m.get('applyRemark')
        if m.get('authorizeMediaId') is not None:
            self.authorize_media_id = m.get('authorizeMediaId')
        if m.get('industry') is not None:
            self.industry = m.get('industry')
        if m.get('legalPerson') is not None:
            self.legal_person = m.get('legalPerson')
        if m.get('legalPersonIdCard') is not None:
            self.legal_person_id_card = m.get('legalPersonIdCard')
        if m.get('licenseMediaId') is not None:
            self.license_media_id = m.get('licenseMediaId')
        if m.get('locCity') is not None:
            self.loc_city = m.get('locCity')
        if m.get('locCityName') is not None:
            self.loc_city_name = m.get('locCityName')
        if m.get('locProvince') is not None:
            self.loc_province = m.get('locProvince')
        if m.get('locProvinceName') is not None:
            self.loc_province_name = m.get('locProvinceName')
        if m.get('mobileNum') is not None:
            self.mobile_num = m.get('mobileNum')
        if m.get('orgName') is not None:
            self.org_name = m.get('orgName')
        if m.get('organizationCode') is not None:
            self.organization_code = m.get('organizationCode')
        if m.get('organizationCodeMediaId') is not None:
            self.organization_code_media_id = m.get('organizationCodeMediaId')
        if m.get('registLocation') is not None:
            self.regist_location = m.get('registLocation')
        if m.get('registNum') is not None:
            self.regist_num = m.get('registNum')
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        if m.get('unifiedSocialCredit') is not None:
            self.unified_social_credit = m.get('unifiedSocialCredit')
        return self


class SaveAndSubmitAuthInfoResponseBody(TeaModel):
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


class SaveAndSubmitAuthInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SaveAndSubmitAuthInfoResponseBody = None,
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
            temp_model = SaveAndSubmitAuthInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SaveOpenTerminalInfoHeaders(TeaModel):
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


class SaveOpenTerminalInfoRequest(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        log_source: str = None,
        log_type: str = None,
        open_ext: str = None,
    ):
        # This parameter is required.
        self.corp_id = corp_id
        # This parameter is required.
        self.log_source = log_source
        # This parameter is required.
        self.log_type = log_type
        # This parameter is required.
        self.open_ext = open_ext

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.log_source is not None:
            result['logSource'] = self.log_source
        if self.log_type is not None:
            result['logType'] = self.log_type
        if self.open_ext is not None:
            result['openExt'] = self.open_ext
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('logSource') is not None:
            self.log_source = m.get('logSource')
        if m.get('logType') is not None:
            self.log_type = m.get('logType')
        if m.get('openExt') is not None:
            self.open_ext = m.get('openExt')
        return self


class SaveOpenTerminalInfoResponseBody(TeaModel):
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


class SaveOpenTerminalInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SaveOpenTerminalInfoResponseBody = None,
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
            temp_model = SaveOpenTerminalInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SaveStorageFunctionSwitchHeaders(TeaModel):
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


class SaveStorageFunctionSwitchRequestFunctionList(TeaModel):
    def __init__(
        self,
        function_key: str = None,
        function_value: str = None,
    ):
        # This parameter is required.
        self.function_key = function_key
        # This parameter is required.
        self.function_value = function_value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.function_key is not None:
            result['functionKey'] = self.function_key
        if self.function_value is not None:
            result['functionValue'] = self.function_value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('functionKey') is not None:
            self.function_key = m.get('functionKey')
        if m.get('functionValue') is not None:
            self.function_value = m.get('functionValue')
        return self


class SaveStorageFunctionSwitchRequest(TeaModel):
    def __init__(
        self,
        function_list: List[SaveStorageFunctionSwitchRequestFunctionList] = None,
        target_corp_id: str = None,
    ):
        # This parameter is required.
        self.function_list = function_list
        # This parameter is required.
        self.target_corp_id = target_corp_id

    def validate(self):
        if self.function_list:
            for k in self.function_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['functionList'] = []
        if self.function_list is not None:
            for k in self.function_list:
                result['functionList'].append(k.to_map() if k else None)
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.function_list = []
        if m.get('functionList') is not None:
            for k in m.get('functionList'):
                temp_model = SaveStorageFunctionSwitchRequestFunctionList()
                self.function_list.append(temp_model.from_map(k))
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        return self


class SaveStorageFunctionSwitchResponseBody(TeaModel):
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


class SaveStorageFunctionSwitchResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SaveStorageFunctionSwitchResponseBody = None,
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
            temp_model = SaveStorageFunctionSwitchResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SaveStorageSwitchHeaders(TeaModel):
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


class SaveStorageSwitchRequest(TeaModel):
    def __init__(
        self,
        open_storage: int = None,
        target_corp_id: str = None,
    ):
        # This parameter is required.
        self.open_storage = open_storage
        # This parameter is required.
        self.target_corp_id = target_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_storage is not None:
            result['openStorage'] = self.open_storage
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openStorage') is not None:
            self.open_storage = m.get('openStorage')
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        return self


class SaveStorageSwitchResponseBody(TeaModel):
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


class SaveStorageSwitchResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SaveStorageSwitchResponseBody = None,
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
            temp_model = SaveStorageSwitchResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SaveWhiteAppHeaders(TeaModel):
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


class SaveWhiteAppRequest(TeaModel):
    def __init__(
        self,
        agent_id_list: List[int] = None,
        agent_id_map: str = None,
        operation: str = None,
    ):
        self.agent_id_list = agent_id_list
        # This parameter is required.
        self.agent_id_map = agent_id_map
        self.operation = operation

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.agent_id_list is not None:
            result['agentIdList'] = self.agent_id_list
        if self.agent_id_map is not None:
            result['agentIdMap'] = self.agent_id_map
        if self.operation is not None:
            result['operation'] = self.operation
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('agentIdList') is not None:
            self.agent_id_list = m.get('agentIdList')
        if m.get('agentIdMap') is not None:
            self.agent_id_map = m.get('agentIdMap')
        if m.get('operation') is not None:
            self.operation = m.get('operation')
        return self


class SaveWhiteAppResponseBody(TeaModel):
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


class SaveWhiteAppResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SaveWhiteAppResponseBody = None,
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
            temp_model = SaveWhiteAppResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SearchOrgInnerGroupInfoHeaders(TeaModel):
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


class SearchOrgInnerGroupInfoRequest(TeaModel):
    def __init__(
        self,
        create_time_end: int = None,
        create_time_start: int = None,
        group_members_count_end: int = None,
        group_members_count_start: int = None,
        group_name: str = None,
        group_owner: str = None,
        last_active_time_end: int = None,
        last_active_time_start: int = None,
        operator_user_id: str = None,
        page_size: int = None,
        page_start: int = None,
        sync_to_dingpan: int = None,
        uuid: str = None,
    ):
        self.create_time_end = create_time_end
        self.create_time_start = create_time_start
        self.group_members_count_end = group_members_count_end
        self.group_members_count_start = group_members_count_start
        self.group_name = group_name
        self.group_owner = group_owner
        self.last_active_time_end = last_active_time_end
        self.last_active_time_start = last_active_time_start
        # This parameter is required.
        self.operator_user_id = operator_user_id
        # This parameter is required.
        self.page_size = page_size
        # This parameter is required.
        self.page_start = page_start
        self.sync_to_dingpan = sync_to_dingpan
        # This parameter is required.
        self.uuid = uuid

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_time_end is not None:
            result['createTimeEnd'] = self.create_time_end
        if self.create_time_start is not None:
            result['createTimeStart'] = self.create_time_start
        if self.group_members_count_end is not None:
            result['groupMembersCountEnd'] = self.group_members_count_end
        if self.group_members_count_start is not None:
            result['groupMembersCountStart'] = self.group_members_count_start
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.group_owner is not None:
            result['groupOwner'] = self.group_owner
        if self.last_active_time_end is not None:
            result['lastActiveTimeEnd'] = self.last_active_time_end
        if self.last_active_time_start is not None:
            result['lastActiveTimeStart'] = self.last_active_time_start
        if self.operator_user_id is not None:
            result['operatorUserId'] = self.operator_user_id
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.page_start is not None:
            result['pageStart'] = self.page_start
        if self.sync_to_dingpan is not None:
            result['syncToDingpan'] = self.sync_to_dingpan
        if self.uuid is not None:
            result['uuid'] = self.uuid
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createTimeEnd') is not None:
            self.create_time_end = m.get('createTimeEnd')
        if m.get('createTimeStart') is not None:
            self.create_time_start = m.get('createTimeStart')
        if m.get('groupMembersCountEnd') is not None:
            self.group_members_count_end = m.get('groupMembersCountEnd')
        if m.get('groupMembersCountStart') is not None:
            self.group_members_count_start = m.get('groupMembersCountStart')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('groupOwner') is not None:
            self.group_owner = m.get('groupOwner')
        if m.get('lastActiveTimeEnd') is not None:
            self.last_active_time_end = m.get('lastActiveTimeEnd')
        if m.get('lastActiveTimeStart') is not None:
            self.last_active_time_start = m.get('lastActiveTimeStart')
        if m.get('operatorUserId') is not None:
            self.operator_user_id = m.get('operatorUserId')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('pageStart') is not None:
            self.page_start = m.get('pageStart')
        if m.get('syncToDingpan') is not None:
            self.sync_to_dingpan = m.get('syncToDingpan')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        return self


class SearchOrgInnerGroupInfoResponseBodyItems(TeaModel):
    def __init__(
        self,
        extensions: Dict[str, str] = None,
        group_admins_count: int = None,
        group_create_time: int = None,
        group_last_active_time: int = None,
        group_last_active_time_show: str = None,
        group_members_count: int = None,
        group_name: str = None,
        group_owner: str = None,
        group_owner_user_id: str = None,
        open_conversation_id: str = None,
        status: int = None,
        sync_to_dingpan: int = None,
        template_id: str = None,
        template_name: str = None,
        used_quota: int = None,
    ):
        self.extensions = extensions
        # This parameter is required.
        self.group_admins_count = group_admins_count
        # This parameter is required.
        self.group_create_time = group_create_time
        # This parameter is required.
        self.group_last_active_time = group_last_active_time
        # This parameter is required.
        self.group_last_active_time_show = group_last_active_time_show
        # This parameter is required.
        self.group_members_count = group_members_count
        # This parameter is required.
        self.group_name = group_name
        # This parameter is required.
        self.group_owner = group_owner
        # This parameter is required.
        self.group_owner_user_id = group_owner_user_id
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.status = status
        # This parameter is required.
        self.sync_to_dingpan = sync_to_dingpan
        # This parameter is required.
        self.template_id = template_id
        # This parameter is required.
        self.template_name = template_name
        # This parameter is required.
        self.used_quota = used_quota

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.extensions is not None:
            result['extensions'] = self.extensions
        if self.group_admins_count is not None:
            result['groupAdminsCount'] = self.group_admins_count
        if self.group_create_time is not None:
            result['groupCreateTime'] = self.group_create_time
        if self.group_last_active_time is not None:
            result['groupLastActiveTime'] = self.group_last_active_time
        if self.group_last_active_time_show is not None:
            result['groupLastActiveTimeShow'] = self.group_last_active_time_show
        if self.group_members_count is not None:
            result['groupMembersCount'] = self.group_members_count
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.group_owner is not None:
            result['groupOwner'] = self.group_owner
        if self.group_owner_user_id is not None:
            result['groupOwnerUserId'] = self.group_owner_user_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.status is not None:
            result['status'] = self.status
        if self.sync_to_dingpan is not None:
            result['syncToDingpan'] = self.sync_to_dingpan
        if self.template_id is not None:
            result['templateId'] = self.template_id
        if self.template_name is not None:
            result['templateName'] = self.template_name
        if self.used_quota is not None:
            result['usedQuota'] = self.used_quota
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('extensions') is not None:
            self.extensions = m.get('extensions')
        if m.get('groupAdminsCount') is not None:
            self.group_admins_count = m.get('groupAdminsCount')
        if m.get('groupCreateTime') is not None:
            self.group_create_time = m.get('groupCreateTime')
        if m.get('groupLastActiveTime') is not None:
            self.group_last_active_time = m.get('groupLastActiveTime')
        if m.get('groupLastActiveTimeShow') is not None:
            self.group_last_active_time_show = m.get('groupLastActiveTimeShow')
        if m.get('groupMembersCount') is not None:
            self.group_members_count = m.get('groupMembersCount')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('groupOwner') is not None:
            self.group_owner = m.get('groupOwner')
        if m.get('groupOwnerUserId') is not None:
            self.group_owner_user_id = m.get('groupOwnerUserId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('syncToDingpan') is not None:
            self.sync_to_dingpan = m.get('syncToDingpan')
        if m.get('templateId') is not None:
            self.template_id = m.get('templateId')
        if m.get('templateName') is not None:
            self.template_name = m.get('templateName')
        if m.get('usedQuota') is not None:
            self.used_quota = m.get('usedQuota')
        return self


class SearchOrgInnerGroupInfoResponseBody(TeaModel):
    def __init__(
        self,
        item_count: int = None,
        items: List[SearchOrgInnerGroupInfoResponseBodyItems] = None,
        total_count: int = None,
    ):
        # This parameter is required.
        self.item_count = item_count
        # This parameter is required.
        self.items = items
        # This parameter is required.
        self.total_count = total_count

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
        if self.item_count is not None:
            result['itemCount'] = self.item_count
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('itemCount') is not None:
            self.item_count = m.get('itemCount')
        self.items = []
        if m.get('items') is not None:
            for k in m.get('items'):
                temp_model = SearchOrgInnerGroupInfoResponseBodyItems()
                self.items.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class SearchOrgInnerGroupInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SearchOrgInnerGroupInfoResponseBody = None,
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
            temp_model = SearchOrgInnerGroupInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SendAppDingHeaders(TeaModel):
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


class SendAppDingRequest(TeaModel):
    def __init__(
        self,
        content: str = None,
        userids: List[str] = None,
    ):
        # This parameter is required.
        self.content = content
        # This parameter is required.
        self.userids = userids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.userids is not None:
            result['userids'] = self.userids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('userids') is not None:
            self.userids = m.get('userids')
        return self


class SendAppDingResponse(TeaModel):
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


class SendInvitationHeaders(TeaModel):
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


class SendInvitationRequest(TeaModel):
    def __init__(
        self,
        dept_id: str = None,
        org_alias: str = None,
        partner_label_id: int = None,
        partner_num: str = None,
        phone: str = None,
    ):
        # This parameter is required.
        self.dept_id = dept_id
        # This parameter is required.
        self.org_alias = org_alias
        # This parameter is required.
        self.partner_label_id = partner_label_id
        # This parameter is required.
        self.partner_num = partner_num
        # This parameter is required.
        self.phone = phone

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.org_alias is not None:
            result['orgAlias'] = self.org_alias
        if self.partner_label_id is not None:
            result['partnerLabelId'] = self.partner_label_id
        if self.partner_num is not None:
            result['partnerNum'] = self.partner_num
        if self.phone is not None:
            result['phone'] = self.phone
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('orgAlias') is not None:
            self.org_alias = m.get('orgAlias')
        if m.get('partnerLabelId') is not None:
            self.partner_label_id = m.get('partnerLabelId')
        if m.get('partnerNum') is not None:
            self.partner_num = m.get('partnerNum')
        if m.get('phone') is not None:
            self.phone = m.get('phone')
        return self


class SendInvitationResponse(TeaModel):
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


class SendPhoneDingHeaders(TeaModel):
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


class SendPhoneDingRequest(TeaModel):
    def __init__(
        self,
        content: str = None,
        userids: List[str] = None,
    ):
        # This parameter is required.
        self.content = content
        # This parameter is required.
        self.userids = userids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.userids is not None:
            result['userids'] = self.userids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('userids') is not None:
            self.userids = m.get('userids')
        return self


class SendPhoneDingResponseBody(TeaModel):
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


class SendPhoneDingResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SendPhoneDingResponseBody = None,
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
            temp_model = SendPhoneDingResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SetConversationCategoryHeaders(TeaModel):
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


class SetConversationCategoryRequest(TeaModel):
    def __init__(
        self,
        category_id: int = None,
        open_conversation_id: str = None,
    ):
        # This parameter is required.
        self.category_id = category_id
        # This parameter is required.
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.category_id is not None:
            result['categoryId'] = self.category_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('categoryId') is not None:
            self.category_id = m.get('categoryId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class SetConversationCategoryResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
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


class SetConversationCategoryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SetConversationCategoryResponseBody = None,
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
            temp_model = SetConversationCategoryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SetConversationTopCategoryHeaders(TeaModel):
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


class SetConversationTopCategoryRequestSetCategoryList(TeaModel):
    def __init__(
        self,
        category_id: int = None,
        order: int = None,
    ):
        # This parameter is required.
        self.category_id = category_id
        self.order = order

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.category_id is not None:
            result['categoryId'] = self.category_id
        if self.order is not None:
            result['order'] = self.order
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('categoryId') is not None:
            self.category_id = m.get('categoryId')
        if m.get('order') is not None:
            self.order = m.get('order')
        return self


class SetConversationTopCategoryRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        set_category_list: List[SetConversationTopCategoryRequestSetCategoryList] = None,
        sign: int = None,
    ):
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        self.set_category_list = set_category_list
        self.sign = sign

    def validate(self):
        if self.set_category_list:
            for k in self.set_category_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        result['setCategoryList'] = []
        if self.set_category_list is not None:
            for k in self.set_category_list:
                result['setCategoryList'].append(k.to_map() if k else None)
        if self.sign is not None:
            result['sign'] = self.sign
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        self.set_category_list = []
        if m.get('setCategoryList') is not None:
            for k in m.get('setCategoryList'):
                temp_model = SetConversationTopCategoryRequestSetCategoryList()
                self.set_category_list.append(temp_model.from_map(k))
        if m.get('sign') is not None:
            self.sign = m.get('sign')
        return self


class SetConversationTopCategoryResponseBody(TeaModel):
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


class SetConversationTopCategoryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SetConversationTopCategoryResponseBody = None,
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
            temp_model = SetConversationTopCategoryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SetDeptPartnerTypeAndNumHeaders(TeaModel):
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


class SetDeptPartnerTypeAndNumRequest(TeaModel):
    def __init__(
        self,
        dept_id: str = None,
        label_ids: List[str] = None,
        partner_num: str = None,
    ):
        # This parameter is required.
        self.dept_id = dept_id
        self.label_ids = label_ids
        self.partner_num = partner_num

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_id is not None:
            result['deptId'] = self.dept_id
        if self.label_ids is not None:
            result['labelIds'] = self.label_ids
        if self.partner_num is not None:
            result['partnerNum'] = self.partner_num
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptId') is not None:
            self.dept_id = m.get('deptId')
        if m.get('labelIds') is not None:
            self.label_ids = m.get('labelIds')
        if m.get('partnerNum') is not None:
            self.partner_num = m.get('partnerNum')
        return self


class SetDeptPartnerTypeAndNumResponse(TeaModel):
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


class SetOrgTopConversationCategoryHeaders(TeaModel):
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


class SetOrgTopConversationCategoryRequestBody(TeaModel):
    def __init__(
        self,
        category_id: int = None,
        category_name: str = None,
        order: int = None,
    ):
        self.category_id = category_id
        # This parameter is required.
        self.category_name = category_name
        self.order = order

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.category_id is not None:
            result['categoryId'] = self.category_id
        if self.category_name is not None:
            result['categoryName'] = self.category_name
        if self.order is not None:
            result['order'] = self.order
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('categoryId') is not None:
            self.category_id = m.get('categoryId')
        if m.get('categoryName') is not None:
            self.category_name = m.get('categoryName')
        if m.get('order') is not None:
            self.order = m.get('order')
        return self


class SetOrgTopConversationCategoryRequest(TeaModel):
    def __init__(
        self,
        body: List[SetOrgTopConversationCategoryRequestBody] = None,
    ):
        self.body = body

    def validate(self):
        if self.body:
            for k in self.body:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['body'] = []
        if self.body is not None:
            for k in self.body:
                result['body'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.body = []
        if m.get('body') is not None:
            for k in m.get('body'):
                temp_model = SetOrgTopConversationCategoryRequestBody()
                self.body.append(temp_model.from_map(k))
        return self


class SetOrgTopConversationCategoryResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
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


class SetOrgTopConversationCategoryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SetOrgTopConversationCategoryResponseBody = None,
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
            temp_model = SetOrgTopConversationCategoryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SpecialRuleBatchReceiverHeaders(TeaModel):
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


class SpecialRuleBatchReceiverRequestDataAttrs(TeaModel):
    def __init__(
        self,
        list_unit_id: List[int] = None,
    ):
        self.list_unit_id = list_unit_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.list_unit_id is not None:
            result['listUnitId'] = self.list_unit_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('listUnitId') is not None:
            self.list_unit_id = m.get('listUnitId')
        return self


class SpecialRuleBatchReceiverRequestData(TeaModel):
    def __init__(
        self,
        at_account: str = None,
        attrs: SpecialRuleBatchReceiverRequestDataAttrs = None,
        callback_url: str = None,
        card_callback_url: str = None,
        content: Dict[str, dict] = None,
        is_at_all: bool = None,
        private_content: Dict[str, dict] = None,
        receiver_account: str = None,
        receiver_type: int = None,
        serial_number: str = None,
    ):
        self.at_account = at_account
        self.attrs = attrs
        self.callback_url = callback_url
        self.card_callback_url = card_callback_url
        self.content = content
        self.is_at_all = is_at_all
        self.private_content = private_content
        self.receiver_account = receiver_account
        self.receiver_type = receiver_type
        self.serial_number = serial_number

    def validate(self):
        if self.attrs:
            self.attrs.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.at_account is not None:
            result['atAccount'] = self.at_account
        if self.attrs is not None:
            result['attrs'] = self.attrs.to_map()
        if self.callback_url is not None:
            result['callbackUrl'] = self.callback_url
        if self.card_callback_url is not None:
            result['cardCallbackUrl'] = self.card_callback_url
        if self.content is not None:
            result['content'] = self.content
        if self.is_at_all is not None:
            result['isAtAll'] = self.is_at_all
        if self.private_content is not None:
            result['privateContent'] = self.private_content
        if self.receiver_account is not None:
            result['receiverAccount'] = self.receiver_account
        if self.receiver_type is not None:
            result['receiverType'] = self.receiver_type
        if self.serial_number is not None:
            result['serialNumber'] = self.serial_number
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('atAccount') is not None:
            self.at_account = m.get('atAccount')
        if m.get('attrs') is not None:
            temp_model = SpecialRuleBatchReceiverRequestDataAttrs()
            self.attrs = temp_model.from_map(m['attrs'])
        if m.get('callbackUrl') is not None:
            self.callback_url = m.get('callbackUrl')
        if m.get('cardCallbackUrl') is not None:
            self.card_callback_url = m.get('cardCallbackUrl')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('isAtAll') is not None:
            self.is_at_all = m.get('isAtAll')
        if m.get('privateContent') is not None:
            self.private_content = m.get('privateContent')
        if m.get('receiverAccount') is not None:
            self.receiver_account = m.get('receiverAccount')
        if m.get('receiverType') is not None:
            self.receiver_type = m.get('receiverType')
        if m.get('serialNumber') is not None:
            self.serial_number = m.get('serialNumber')
        return self


class SpecialRuleBatchReceiverRequest(TeaModel):
    def __init__(
        self,
        batch_no: str = None,
        card_options: str = None,
        data: List[SpecialRuleBatchReceiverRequestData] = None,
        rule_code: str = None,
        secret_key: str = None,
        special_strategy: bool = None,
        task_batch_no: str = None,
    ):
        self.batch_no = batch_no
        self.card_options = card_options
        self.data = data
        self.rule_code = rule_code
        self.secret_key = secret_key
        self.special_strategy = special_strategy
        self.task_batch_no = task_batch_no

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
        if self.batch_no is not None:
            result['batchNo'] = self.batch_no
        if self.card_options is not None:
            result['cardOptions'] = self.card_options
        result['data'] = []
        if self.data is not None:
            for k in self.data:
                result['data'].append(k.to_map() if k else None)
        if self.rule_code is not None:
            result['ruleCode'] = self.rule_code
        if self.secret_key is not None:
            result['secretKey'] = self.secret_key
        if self.special_strategy is not None:
            result['specialStrategy'] = self.special_strategy
        if self.task_batch_no is not None:
            result['taskBatchNo'] = self.task_batch_no
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('batchNo') is not None:
            self.batch_no = m.get('batchNo')
        if m.get('cardOptions') is not None:
            self.card_options = m.get('cardOptions')
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = SpecialRuleBatchReceiverRequestData()
                self.data.append(temp_model.from_map(k))
        if m.get('ruleCode') is not None:
            self.rule_code = m.get('ruleCode')
        if m.get('secretKey') is not None:
            self.secret_key = m.get('secretKey')
        if m.get('specialStrategy') is not None:
            self.special_strategy = m.get('specialStrategy')
        if m.get('taskBatchNo') is not None:
            self.task_batch_no = m.get('taskBatchNo')
        return self


class SpecialRuleBatchReceiverResponseBodyData(TeaModel):
    def __init__(
        self,
        msg_id: str = None,
        serial_number: str = None,
    ):
        self.msg_id = msg_id
        self.serial_number = serial_number

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.msg_id is not None:
            result['msgId'] = self.msg_id
        if self.serial_number is not None:
            result['serialNumber'] = self.serial_number
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('msgId') is not None:
            self.msg_id = m.get('msgId')
        if m.get('serialNumber') is not None:
            self.serial_number = m.get('serialNumber')
        return self


class SpecialRuleBatchReceiverResponseBodyRows(TeaModel):
    def __init__(
        self,
        serial_number: str = None,
        msg_id: str = None,
    ):
        self.serial_number = serial_number
        self.msg_id = msg_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.serial_number is not None:
            result['serialNumber'] = self.serial_number
        if self.msg_id is not None:
            result['msgId'] = self.msg_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('serialNumber') is not None:
            self.serial_number = m.get('serialNumber')
        if m.get('msgId') is not None:
            self.msg_id = m.get('msgId')
        return self


class SpecialRuleBatchReceiverResponseBody(TeaModel):
    def __init__(
        self,
        code: int = None,
        data: List[SpecialRuleBatchReceiverResponseBodyData] = None,
        msg: str = None,
        msg_id: str = None,
        rows: List[List[SpecialRuleBatchReceiverResponseBodyRows]] = None,
    ):
        self.code = code
        self.data = data
        self.msg = msg
        self.msg_id = msg_id
        self.rows = rows

    def validate(self):
        if self.data:
            for k in self.data:
                if k:
                    k.validate()
        if self.rows:
            for k in self.rows:
                for k1 in k:
                    if k1:
                        k1.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        result['data'] = []
        if self.data is not None:
            for k in self.data:
                result['data'].append(k.to_map() if k else None)
        if self.msg is not None:
            result['msg'] = self.msg
        if self.msg_id is not None:
            result['msgId'] = self.msg_id
        result['rows'] = []
        if self.rows is not None:
            for k in self.rows:
                l1 = []
                for k1 in k:
                    l1.append(k1.to_map() if k1 else None)
                result['rows'].append(l1)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = SpecialRuleBatchReceiverResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('msg') is not None:
            self.msg = m.get('msg')
        if m.get('msgId') is not None:
            self.msg_id = m.get('msgId')
        self.rows = []
        if m.get('rows') is not None:
            for k in m.get('rows'):
                l1 = []
                for k1 in k:
                    temp_model = SpecialRuleBatchReceiverResponseBodyRows()
                    l1.append(temp_model.from_map(k1))
                self.rows.append(l1)
        return self


class SpecialRuleBatchReceiverResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SpecialRuleBatchReceiverResponseBody = None,
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
            temp_model = SpecialRuleBatchReceiverResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class TaskInfoAddDelTaskPersonHeaders(TeaModel):
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


class TaskInfoAddDelTaskPersonRequestTaskExecutePersonDTOS(TeaModel):
    def __init__(
        self,
        employee_code: str = None,
        person_type: int = None,
    ):
        self.employee_code = employee_code
        self.person_type = person_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.employee_code is not None:
            result['employeeCode'] = self.employee_code
        if self.person_type is not None:
            result['personType'] = self.person_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('employeeCode') is not None:
            self.employee_code = m.get('employeeCode')
        if m.get('personType') is not None:
            self.person_type = m.get('personType')
        return self


class TaskInfoAddDelTaskPersonRequest(TeaModel):
    def __init__(
        self,
        operate_type: int = None,
        operator_account: str = None,
        out_task_id: str = None,
        proj_id: str = None,
        secret_key: str = None,
        task_execute_person_dtos: List[TaskInfoAddDelTaskPersonRequestTaskExecutePersonDTOS] = None,
    ):
        # This parameter is required.
        self.operate_type = operate_type
        # This parameter is required.
        self.operator_account = operator_account
        # This parameter is required.
        self.out_task_id = out_task_id
        # This parameter is required.
        self.proj_id = proj_id
        # This parameter is required.
        self.secret_key = secret_key
        # This parameter is required.
        self.task_execute_person_dtos = task_execute_person_dtos

    def validate(self):
        if self.task_execute_person_dtos:
            for k in self.task_execute_person_dtos:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operate_type is not None:
            result['operateType'] = self.operate_type
        if self.operator_account is not None:
            result['operatorAccount'] = self.operator_account
        if self.out_task_id is not None:
            result['outTaskId'] = self.out_task_id
        if self.proj_id is not None:
            result['projId'] = self.proj_id
        if self.secret_key is not None:
            result['secretKey'] = self.secret_key
        result['taskExecutePersonDTOS'] = []
        if self.task_execute_person_dtos is not None:
            for k in self.task_execute_person_dtos:
                result['taskExecutePersonDTOS'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operateType') is not None:
            self.operate_type = m.get('operateType')
        if m.get('operatorAccount') is not None:
            self.operator_account = m.get('operatorAccount')
        if m.get('outTaskId') is not None:
            self.out_task_id = m.get('outTaskId')
        if m.get('projId') is not None:
            self.proj_id = m.get('projId')
        if m.get('secretKey') is not None:
            self.secret_key = m.get('secretKey')
        self.task_execute_person_dtos = []
        if m.get('taskExecutePersonDTOS') is not None:
            for k in m.get('taskExecutePersonDTOS'):
                temp_model = TaskInfoAddDelTaskPersonRequestTaskExecutePersonDTOS()
                self.task_execute_person_dtos.append(temp_model.from_map(k))
        return self


class TaskInfoAddDelTaskPersonResponseBody(TeaModel):
    def __init__(
        self,
        code: int = None,
        data: Any = None,
        message: str = None,
    ):
        self.code = code
        self.data = data
        self.message = message

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.data is not None:
            result['data'] = self.data
        if self.message is not None:
            result['message'] = self.message
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('message') is not None:
            self.message = m.get('message')
        return self


class TaskInfoAddDelTaskPersonResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: TaskInfoAddDelTaskPersonResponseBody = None,
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
            temp_model = TaskInfoAddDelTaskPersonResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class TaskInfoCancelOrDelTaskHeaders(TeaModel):
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


class TaskInfoCancelOrDelTaskRequestCardDTO(TeaModel):
    def __init__(
        self,
        at_account: str = None,
        card_callback_url: str = None,
        content: Any = None,
        is_at_all: bool = None,
        receiver_account: str = None,
    ):
        self.at_account = at_account
        self.card_callback_url = card_callback_url
        self.content = content
        self.is_at_all = is_at_all
        self.receiver_account = receiver_account

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.at_account is not None:
            result['atAccount'] = self.at_account
        if self.card_callback_url is not None:
            result['cardCallbackUrl'] = self.card_callback_url
        if self.content is not None:
            result['content'] = self.content
        if self.is_at_all is not None:
            result['isAtAll'] = self.is_at_all
        if self.receiver_account is not None:
            result['receiverAccount'] = self.receiver_account
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('atAccount') is not None:
            self.at_account = m.get('atAccount')
        if m.get('cardCallbackUrl') is not None:
            self.card_callback_url = m.get('cardCallbackUrl')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('isAtAll') is not None:
            self.is_at_all = m.get('isAtAll')
        if m.get('receiverAccount') is not None:
            self.receiver_account = m.get('receiverAccount')
        return self


class TaskInfoCancelOrDelTaskRequestTaskExecutePersonDTOS(TeaModel):
    def __init__(
        self,
        employee_code: str = None,
        person_type: int = None,
    ):
        self.employee_code = employee_code
        self.person_type = person_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.employee_code is not None:
            result['employeeCode'] = self.employee_code
        if self.person_type is not None:
            result['personType'] = self.person_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('employeeCode') is not None:
            self.employee_code = m.get('employeeCode')
        if m.get('personType') is not None:
            self.person_type = m.get('personType')
        return self


class TaskInfoCancelOrDelTaskRequest(TeaModel):
    def __init__(
        self,
        card_dto: TaskInfoCancelOrDelTaskRequestCardDTO = None,
        operator_account: str = None,
        out_task_id: str = None,
        proj_id: str = None,
        secret_key: str = None,
        send_msg_flag: int = None,
        task_execute_person_dtos: List[TaskInfoCancelOrDelTaskRequestTaskExecutePersonDTOS] = None,
    ):
        self.card_dto = card_dto
        # This parameter is required.
        self.operator_account = operator_account
        self.out_task_id = out_task_id
        # This parameter is required.
        self.proj_id = proj_id
        # This parameter is required.
        self.secret_key = secret_key
        self.send_msg_flag = send_msg_flag
        self.task_execute_person_dtos = task_execute_person_dtos

    def validate(self):
        if self.card_dto:
            self.card_dto.validate()
        if self.task_execute_person_dtos:
            for k in self.task_execute_person_dtos:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.card_dto is not None:
            result['cardDTO'] = self.card_dto.to_map()
        if self.operator_account is not None:
            result['operatorAccount'] = self.operator_account
        if self.out_task_id is not None:
            result['outTaskId'] = self.out_task_id
        if self.proj_id is not None:
            result['projId'] = self.proj_id
        if self.secret_key is not None:
            result['secretKey'] = self.secret_key
        if self.send_msg_flag is not None:
            result['sendMsgFlag'] = self.send_msg_flag
        result['taskExecutePersonDTOS'] = []
        if self.task_execute_person_dtos is not None:
            for k in self.task_execute_person_dtos:
                result['taskExecutePersonDTOS'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cardDTO') is not None:
            temp_model = TaskInfoCancelOrDelTaskRequestCardDTO()
            self.card_dto = temp_model.from_map(m['cardDTO'])
        if m.get('operatorAccount') is not None:
            self.operator_account = m.get('operatorAccount')
        if m.get('outTaskId') is not None:
            self.out_task_id = m.get('outTaskId')
        if m.get('projId') is not None:
            self.proj_id = m.get('projId')
        if m.get('secretKey') is not None:
            self.secret_key = m.get('secretKey')
        if m.get('sendMsgFlag') is not None:
            self.send_msg_flag = m.get('sendMsgFlag')
        self.task_execute_person_dtos = []
        if m.get('taskExecutePersonDTOS') is not None:
            for k in m.get('taskExecutePersonDTOS'):
                temp_model = TaskInfoCancelOrDelTaskRequestTaskExecutePersonDTOS()
                self.task_execute_person_dtos.append(temp_model.from_map(k))
        return self


class TaskInfoCancelOrDelTaskResponseBody(TeaModel):
    def __init__(
        self,
        code: int = None,
        data: Any = None,
        message: str = None,
    ):
        self.code = code
        self.data = data
        self.message = message

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.data is not None:
            result['data'] = self.data
        if self.message is not None:
            result['message'] = self.message
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('message') is not None:
            self.message = m.get('message')
        return self


class TaskInfoCancelOrDelTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: TaskInfoCancelOrDelTaskResponseBody = None,
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
            temp_model = TaskInfoCancelOrDelTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class TaskInfoCreateAndStartTaskHeaders(TeaModel):
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


class TaskInfoCreateAndStartTaskRequestAttrListTaskDynamicAttr(TeaModel):
    def __init__(
        self,
        attr_code: str = None,
        list_attr_options_code: List[str] = None,
    ):
        self.attr_code = attr_code
        self.list_attr_options_code = list_attr_options_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.attr_code is not None:
            result['attrCode'] = self.attr_code
        if self.list_attr_options_code is not None:
            result['listAttrOptionsCode'] = self.list_attr_options_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('attrCode') is not None:
            self.attr_code = m.get('attrCode')
        if m.get('listAttrOptionsCode') is not None:
            self.list_attr_options_code = m.get('listAttrOptionsCode')
        return self


class TaskInfoCreateAndStartTaskRequestAttr(TeaModel):
    def __init__(
        self,
        list_task_dynamic_attr: List[TaskInfoCreateAndStartTaskRequestAttrListTaskDynamicAttr] = None,
    ):
        self.list_task_dynamic_attr = list_task_dynamic_attr

    def validate(self):
        if self.list_task_dynamic_attr:
            for k in self.list_task_dynamic_attr:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['listTaskDynamicAttr'] = []
        if self.list_task_dynamic_attr is not None:
            for k in self.list_task_dynamic_attr:
                result['listTaskDynamicAttr'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.list_task_dynamic_attr = []
        if m.get('listTaskDynamicAttr') is not None:
            for k in m.get('listTaskDynamicAttr'):
                temp_model = TaskInfoCreateAndStartTaskRequestAttrListTaskDynamicAttr()
                self.list_task_dynamic_attr.append(temp_model.from_map(k))
        return self


class TaskInfoCreateAndStartTaskRequestBacklogDTOContent(TeaModel):
    def __init__(
        self,
        is_only_show_executor: bool = None,
        priority: int = None,
    ):
        self.is_only_show_executor = is_only_show_executor
        self.priority = priority

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.is_only_show_executor is not None:
            result['isOnlyShowExecutor'] = self.is_only_show_executor
        if self.priority is not None:
            result['priority'] = self.priority
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isOnlyShowExecutor') is not None:
            self.is_only_show_executor = m.get('isOnlyShowExecutor')
        if m.get('priority') is not None:
            self.priority = m.get('priority')
        return self


class TaskInfoCreateAndStartTaskRequestBacklogDTO(TeaModel):
    def __init__(
        self,
        content: TaskInfoCreateAndStartTaskRequestBacklogDTOContent = None,
    ):
        self.content = content

    def validate(self):
        if self.content:
            self.content.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            temp_model = TaskInfoCreateAndStartTaskRequestBacklogDTOContent()
            self.content = temp_model.from_map(m['content'])
        return self


class TaskInfoCreateAndStartTaskRequestCardDTO(TeaModel):
    def __init__(
        self,
        at_account: str = None,
        card_callback_url: str = None,
        content: Any = None,
        is_at_all: bool = None,
        receiver_account: str = None,
    ):
        self.at_account = at_account
        self.card_callback_url = card_callback_url
        self.content = content
        self.is_at_all = is_at_all
        self.receiver_account = receiver_account

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.at_account is not None:
            result['atAccount'] = self.at_account
        if self.card_callback_url is not None:
            result['cardCallbackUrl'] = self.card_callback_url
        if self.content is not None:
            result['content'] = self.content
        if self.is_at_all is not None:
            result['isAtAll'] = self.is_at_all
        if self.receiver_account is not None:
            result['receiverAccount'] = self.receiver_account
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('atAccount') is not None:
            self.at_account = m.get('atAccount')
        if m.get('cardCallbackUrl') is not None:
            self.card_callback_url = m.get('cardCallbackUrl')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('isAtAll') is not None:
            self.is_at_all = m.get('isAtAll')
        if m.get('receiverAccount') is not None:
            self.receiver_account = m.get('receiverAccount')
        return self


class TaskInfoCreateAndStartTaskRequestDetailUrl(TeaModel):
    def __init__(
        self,
        app_url: str = None,
        pc_url: str = None,
    ):
        self.app_url = app_url
        self.pc_url = pc_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_url is not None:
            result['appUrl'] = self.app_url
        if self.pc_url is not None:
            result['pcUrl'] = self.pc_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUrl') is not None:
            self.app_url = m.get('appUrl')
        if m.get('pcUrl') is not None:
            self.pc_url = m.get('pcUrl')
        return self


class TaskInfoCreateAndStartTaskRequestTaskExecutePersonDTOS(TeaModel):
    def __init__(
        self,
        employee_code: str = None,
        person_type: int = None,
    ):
        self.employee_code = employee_code
        self.person_type = person_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.employee_code is not None:
            result['employeeCode'] = self.employee_code
        if self.person_type is not None:
            result['personType'] = self.person_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('employeeCode') is not None:
            self.employee_code = m.get('employeeCode')
        if m.get('personType') is not None:
            self.person_type = m.get('personType')
        return self


class TaskInfoCreateAndStartTaskRequestTaskGroupDTOList(TeaModel):
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


class TaskInfoCreateAndStartTaskRequest(TeaModel):
    def __init__(
        self,
        attr: TaskInfoCreateAndStartTaskRequestAttr = None,
        backlog_dto: TaskInfoCreateAndStartTaskRequestBacklogDTO = None,
        backlog_generate_flag: int = None,
        business_code: str = None,
        canceldel_task_card_id: str = None,
        card_dto: TaskInfoCreateAndStartTaskRequestCardDTO = None,
        custom_flag: int = None,
        detail_url: TaskInfoCreateAndStartTaskRequestDetailUrl = None,
        finish_task_card_id: str = None,
        operator_account: str = None,
        out_task_id: str = None,
        proj_id: str = None,
        robot_code: str = None,
        secret_key: str = None,
        send_msg_flag: int = None,
        sort: int = None,
        start_task_card_id: str = None,
        state: int = None,
        task_content: str = None,
        task_end_time: int = None,
        task_execute_person_dtos: List[TaskInfoCreateAndStartTaskRequestTaskExecutePersonDTOS] = None,
        task_group_dtolist: List[TaskInfoCreateAndStartTaskRequestTaskGroupDTOList] = None,
        task_system: str = None,
        task_templ_code: str = None,
        task_title: str = None,
        task_type: str = None,
        task_url_mobile: str = None,
        task_url_pc: str = None,
        update_task_card_id: str = None,
    ):
        self.attr = attr
        self.backlog_dto = backlog_dto
        self.backlog_generate_flag = backlog_generate_flag
        self.business_code = business_code
        self.canceldel_task_card_id = canceldel_task_card_id
        self.card_dto = card_dto
        # This parameter is required.
        self.custom_flag = custom_flag
        self.detail_url = detail_url
        self.finish_task_card_id = finish_task_card_id
        # This parameter is required.
        self.operator_account = operator_account
        # This parameter is required.
        self.out_task_id = out_task_id
        # This parameter is required.
        self.proj_id = proj_id
        self.robot_code = robot_code
        # This parameter is required.
        self.secret_key = secret_key
        self.send_msg_flag = send_msg_flag
        self.sort = sort
        self.start_task_card_id = start_task_card_id
        self.state = state
        self.task_content = task_content
        self.task_end_time = task_end_time
        self.task_execute_person_dtos = task_execute_person_dtos
        self.task_group_dtolist = task_group_dtolist
        # This parameter is required.
        self.task_system = task_system
        self.task_templ_code = task_templ_code
        # This parameter is required.
        self.task_title = task_title
        # This parameter is required.
        self.task_type = task_type
        self.task_url_mobile = task_url_mobile
        self.task_url_pc = task_url_pc
        self.update_task_card_id = update_task_card_id

    def validate(self):
        if self.attr:
            self.attr.validate()
        if self.backlog_dto:
            self.backlog_dto.validate()
        if self.card_dto:
            self.card_dto.validate()
        if self.detail_url:
            self.detail_url.validate()
        if self.task_execute_person_dtos:
            for k in self.task_execute_person_dtos:
                if k:
                    k.validate()
        if self.task_group_dtolist:
            for k in self.task_group_dtolist:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.attr is not None:
            result['attr'] = self.attr.to_map()
        if self.backlog_dto is not None:
            result['backlogDTO'] = self.backlog_dto.to_map()
        if self.backlog_generate_flag is not None:
            result['backlogGenerateFlag'] = self.backlog_generate_flag
        if self.business_code is not None:
            result['businessCode'] = self.business_code
        if self.canceldel_task_card_id is not None:
            result['canceldelTaskCardId'] = self.canceldel_task_card_id
        if self.card_dto is not None:
            result['cardDTO'] = self.card_dto.to_map()
        if self.custom_flag is not None:
            result['customFlag'] = self.custom_flag
        if self.detail_url is not None:
            result['detailUrl'] = self.detail_url.to_map()
        if self.finish_task_card_id is not None:
            result['finishTaskCardId'] = self.finish_task_card_id
        if self.operator_account is not None:
            result['operatorAccount'] = self.operator_account
        if self.out_task_id is not None:
            result['outTaskId'] = self.out_task_id
        if self.proj_id is not None:
            result['projId'] = self.proj_id
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        if self.secret_key is not None:
            result['secretKey'] = self.secret_key
        if self.send_msg_flag is not None:
            result['sendMsgFlag'] = self.send_msg_flag
        if self.sort is not None:
            result['sort'] = self.sort
        if self.start_task_card_id is not None:
            result['startTaskCardId'] = self.start_task_card_id
        if self.state is not None:
            result['state'] = self.state
        if self.task_content is not None:
            result['taskContent'] = self.task_content
        if self.task_end_time is not None:
            result['taskEndTime'] = self.task_end_time
        result['taskExecutePersonDTOS'] = []
        if self.task_execute_person_dtos is not None:
            for k in self.task_execute_person_dtos:
                result['taskExecutePersonDTOS'].append(k.to_map() if k else None)
        result['taskGroupDTOList'] = []
        if self.task_group_dtolist is not None:
            for k in self.task_group_dtolist:
                result['taskGroupDTOList'].append(k.to_map() if k else None)
        if self.task_system is not None:
            result['taskSystem'] = self.task_system
        if self.task_templ_code is not None:
            result['taskTemplCode'] = self.task_templ_code
        if self.task_title is not None:
            result['taskTitle'] = self.task_title
        if self.task_type is not None:
            result['taskType'] = self.task_type
        if self.task_url_mobile is not None:
            result['taskUrlMobile'] = self.task_url_mobile
        if self.task_url_pc is not None:
            result['taskUrlPc'] = self.task_url_pc
        if self.update_task_card_id is not None:
            result['updateTaskCardId'] = self.update_task_card_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('attr') is not None:
            temp_model = TaskInfoCreateAndStartTaskRequestAttr()
            self.attr = temp_model.from_map(m['attr'])
        if m.get('backlogDTO') is not None:
            temp_model = TaskInfoCreateAndStartTaskRequestBacklogDTO()
            self.backlog_dto = temp_model.from_map(m['backlogDTO'])
        if m.get('backlogGenerateFlag') is not None:
            self.backlog_generate_flag = m.get('backlogGenerateFlag')
        if m.get('businessCode') is not None:
            self.business_code = m.get('businessCode')
        if m.get('canceldelTaskCardId') is not None:
            self.canceldel_task_card_id = m.get('canceldelTaskCardId')
        if m.get('cardDTO') is not None:
            temp_model = TaskInfoCreateAndStartTaskRequestCardDTO()
            self.card_dto = temp_model.from_map(m['cardDTO'])
        if m.get('customFlag') is not None:
            self.custom_flag = m.get('customFlag')
        if m.get('detailUrl') is not None:
            temp_model = TaskInfoCreateAndStartTaskRequestDetailUrl()
            self.detail_url = temp_model.from_map(m['detailUrl'])
        if m.get('finishTaskCardId') is not None:
            self.finish_task_card_id = m.get('finishTaskCardId')
        if m.get('operatorAccount') is not None:
            self.operator_account = m.get('operatorAccount')
        if m.get('outTaskId') is not None:
            self.out_task_id = m.get('outTaskId')
        if m.get('projId') is not None:
            self.proj_id = m.get('projId')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        if m.get('secretKey') is not None:
            self.secret_key = m.get('secretKey')
        if m.get('sendMsgFlag') is not None:
            self.send_msg_flag = m.get('sendMsgFlag')
        if m.get('sort') is not None:
            self.sort = m.get('sort')
        if m.get('startTaskCardId') is not None:
            self.start_task_card_id = m.get('startTaskCardId')
        if m.get('state') is not None:
            self.state = m.get('state')
        if m.get('taskContent') is not None:
            self.task_content = m.get('taskContent')
        if m.get('taskEndTime') is not None:
            self.task_end_time = m.get('taskEndTime')
        self.task_execute_person_dtos = []
        if m.get('taskExecutePersonDTOS') is not None:
            for k in m.get('taskExecutePersonDTOS'):
                temp_model = TaskInfoCreateAndStartTaskRequestTaskExecutePersonDTOS()
                self.task_execute_person_dtos.append(temp_model.from_map(k))
        self.task_group_dtolist = []
        if m.get('taskGroupDTOList') is not None:
            for k in m.get('taskGroupDTOList'):
                temp_model = TaskInfoCreateAndStartTaskRequestTaskGroupDTOList()
                self.task_group_dtolist.append(temp_model.from_map(k))
        if m.get('taskSystem') is not None:
            self.task_system = m.get('taskSystem')
        if m.get('taskTemplCode') is not None:
            self.task_templ_code = m.get('taskTemplCode')
        if m.get('taskTitle') is not None:
            self.task_title = m.get('taskTitle')
        if m.get('taskType') is not None:
            self.task_type = m.get('taskType')
        if m.get('taskUrlMobile') is not None:
            self.task_url_mobile = m.get('taskUrlMobile')
        if m.get('taskUrlPc') is not None:
            self.task_url_pc = m.get('taskUrlPc')
        if m.get('updateTaskCardId') is not None:
            self.update_task_card_id = m.get('updateTaskCardId')
        return self


class TaskInfoCreateAndStartTaskResponseBodyDataGroupVoList(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        open_conversation_id: str = None,
    ):
        self.corp_id = corp_id
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
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class TaskInfoCreateAndStartTaskResponseBodyData(TeaModel):
    def __init__(
        self,
        group_vo_list: List[TaskInfoCreateAndStartTaskResponseBodyDataGroupVoList] = None,
        task_id: str = None,
    ):
        self.group_vo_list = group_vo_list
        self.task_id = task_id

    def validate(self):
        if self.group_vo_list:
            for k in self.group_vo_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['groupVoList'] = []
        if self.group_vo_list is not None:
            for k in self.group_vo_list:
                result['groupVoList'].append(k.to_map() if k else None)
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.group_vo_list = []
        if m.get('groupVoList') is not None:
            for k in m.get('groupVoList'):
                temp_model = TaskInfoCreateAndStartTaskResponseBodyDataGroupVoList()
                self.group_vo_list.append(temp_model.from_map(k))
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class TaskInfoCreateAndStartTaskResponseBody(TeaModel):
    def __init__(
        self,
        code: int = None,
        data: TaskInfoCreateAndStartTaskResponseBodyData = None,
        message: str = None,
    ):
        self.code = code
        self.data = data
        self.message = message

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.message is not None:
            result['message'] = self.message
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('data') is not None:
            temp_model = TaskInfoCreateAndStartTaskResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('message') is not None:
            self.message = m.get('message')
        return self


class TaskInfoCreateAndStartTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: TaskInfoCreateAndStartTaskResponseBody = None,
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
            temp_model = TaskInfoCreateAndStartTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class TaskInfoFinishTaskHeaders(TeaModel):
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


class TaskInfoFinishTaskRequestCardDTO(TeaModel):
    def __init__(
        self,
        at_account: str = None,
        card_callback_url: str = None,
        content: Any = None,
        is_at_all: bool = None,
        receiver_account: str = None,
    ):
        self.at_account = at_account
        self.card_callback_url = card_callback_url
        self.content = content
        self.is_at_all = is_at_all
        self.receiver_account = receiver_account

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.at_account is not None:
            result['atAccount'] = self.at_account
        if self.card_callback_url is not None:
            result['cardCallbackUrl'] = self.card_callback_url
        if self.content is not None:
            result['content'] = self.content
        if self.is_at_all is not None:
            result['isAtAll'] = self.is_at_all
        if self.receiver_account is not None:
            result['receiverAccount'] = self.receiver_account
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('atAccount') is not None:
            self.at_account = m.get('atAccount')
        if m.get('cardCallbackUrl') is not None:
            self.card_callback_url = m.get('cardCallbackUrl')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('isAtAll') is not None:
            self.is_at_all = m.get('isAtAll')
        if m.get('receiverAccount') is not None:
            self.receiver_account = m.get('receiverAccount')
        return self


class TaskInfoFinishTaskRequestTaskExecutePersonDTOS(TeaModel):
    def __init__(
        self,
        employee_code: str = None,
        person_type: int = None,
    ):
        self.employee_code = employee_code
        self.person_type = person_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.employee_code is not None:
            result['employeeCode'] = self.employee_code
        if self.person_type is not None:
            result['personType'] = self.person_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('employeeCode') is not None:
            self.employee_code = m.get('employeeCode')
        if m.get('personType') is not None:
            self.person_type = m.get('personType')
        return self


class TaskInfoFinishTaskRequest(TeaModel):
    def __init__(
        self,
        card_dto: TaskInfoFinishTaskRequestCardDTO = None,
        operator_account: str = None,
        out_task_id: str = None,
        proj_id: str = None,
        secret_key: str = None,
        send_msg_flag: int = None,
        task_execute_person_dtos: List[TaskInfoFinishTaskRequestTaskExecutePersonDTOS] = None,
    ):
        self.card_dto = card_dto
        # This parameter is required.
        self.operator_account = operator_account
        self.out_task_id = out_task_id
        # This parameter is required.
        self.proj_id = proj_id
        # This parameter is required.
        self.secret_key = secret_key
        self.send_msg_flag = send_msg_flag
        self.task_execute_person_dtos = task_execute_person_dtos

    def validate(self):
        if self.card_dto:
            self.card_dto.validate()
        if self.task_execute_person_dtos:
            for k in self.task_execute_person_dtos:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.card_dto is not None:
            result['cardDTO'] = self.card_dto.to_map()
        if self.operator_account is not None:
            result['operatorAccount'] = self.operator_account
        if self.out_task_id is not None:
            result['outTaskId'] = self.out_task_id
        if self.proj_id is not None:
            result['projId'] = self.proj_id
        if self.secret_key is not None:
            result['secretKey'] = self.secret_key
        if self.send_msg_flag is not None:
            result['sendMsgFlag'] = self.send_msg_flag
        result['taskExecutePersonDTOS'] = []
        if self.task_execute_person_dtos is not None:
            for k in self.task_execute_person_dtos:
                result['taskExecutePersonDTOS'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cardDTO') is not None:
            temp_model = TaskInfoFinishTaskRequestCardDTO()
            self.card_dto = temp_model.from_map(m['cardDTO'])
        if m.get('operatorAccount') is not None:
            self.operator_account = m.get('operatorAccount')
        if m.get('outTaskId') is not None:
            self.out_task_id = m.get('outTaskId')
        if m.get('projId') is not None:
            self.proj_id = m.get('projId')
        if m.get('secretKey') is not None:
            self.secret_key = m.get('secretKey')
        if m.get('sendMsgFlag') is not None:
            self.send_msg_flag = m.get('sendMsgFlag')
        self.task_execute_person_dtos = []
        if m.get('taskExecutePersonDTOS') is not None:
            for k in m.get('taskExecutePersonDTOS'):
                temp_model = TaskInfoFinishTaskRequestTaskExecutePersonDTOS()
                self.task_execute_person_dtos.append(temp_model.from_map(k))
        return self


class TaskInfoFinishTaskResponseBody(TeaModel):
    def __init__(
        self,
        code: int = None,
        data: Any = None,
        message: str = None,
    ):
        self.code = code
        self.data = data
        self.message = message

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.data is not None:
            result['data'] = self.data
        if self.message is not None:
            result['message'] = self.message
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('message') is not None:
            self.message = m.get('message')
        return self


class TaskInfoFinishTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: TaskInfoFinishTaskResponseBody = None,
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
            temp_model = TaskInfoFinishTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class TaskInfoUpdateTaskHeaders(TeaModel):
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


class TaskInfoUpdateTaskRequestAttrListTaskDynamicAttr(TeaModel):
    def __init__(
        self,
        attr_code: str = None,
        list_attr_options_code: List[str] = None,
    ):
        self.attr_code = attr_code
        self.list_attr_options_code = list_attr_options_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.attr_code is not None:
            result['attrCode'] = self.attr_code
        if self.list_attr_options_code is not None:
            result['listAttrOptionsCode'] = self.list_attr_options_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('attrCode') is not None:
            self.attr_code = m.get('attrCode')
        if m.get('listAttrOptionsCode') is not None:
            self.list_attr_options_code = m.get('listAttrOptionsCode')
        return self


class TaskInfoUpdateTaskRequestAttr(TeaModel):
    def __init__(
        self,
        list_task_dynamic_attr: List[TaskInfoUpdateTaskRequestAttrListTaskDynamicAttr] = None,
    ):
        self.list_task_dynamic_attr = list_task_dynamic_attr

    def validate(self):
        if self.list_task_dynamic_attr:
            for k in self.list_task_dynamic_attr:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['listTaskDynamicAttr'] = []
        if self.list_task_dynamic_attr is not None:
            for k in self.list_task_dynamic_attr:
                result['listTaskDynamicAttr'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.list_task_dynamic_attr = []
        if m.get('listTaskDynamicAttr') is not None:
            for k in m.get('listTaskDynamicAttr'):
                temp_model = TaskInfoUpdateTaskRequestAttrListTaskDynamicAttr()
                self.list_task_dynamic_attr.append(temp_model.from_map(k))
        return self


class TaskInfoUpdateTaskRequestCardDTO(TeaModel):
    def __init__(
        self,
        at_account: str = None,
        card_callback_url: str = None,
        content: Any = None,
        is_at_all: bool = None,
        receiver_account: str = None,
    ):
        self.at_account = at_account
        self.card_callback_url = card_callback_url
        self.content = content
        self.is_at_all = is_at_all
        self.receiver_account = receiver_account

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.at_account is not None:
            result['atAccount'] = self.at_account
        if self.card_callback_url is not None:
            result['cardCallbackUrl'] = self.card_callback_url
        if self.content is not None:
            result['content'] = self.content
        if self.is_at_all is not None:
            result['isAtAll'] = self.is_at_all
        if self.receiver_account is not None:
            result['receiverAccount'] = self.receiver_account
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('atAccount') is not None:
            self.at_account = m.get('atAccount')
        if m.get('cardCallbackUrl') is not None:
            self.card_callback_url = m.get('cardCallbackUrl')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('isAtAll') is not None:
            self.is_at_all = m.get('isAtAll')
        if m.get('receiverAccount') is not None:
            self.receiver_account = m.get('receiverAccount')
        return self


class TaskInfoUpdateTaskRequestDetailUrl(TeaModel):
    def __init__(
        self,
        app_url: str = None,
        pc_url: str = None,
    ):
        self.app_url = app_url
        self.pc_url = pc_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_url is not None:
            result['appUrl'] = self.app_url
        if self.pc_url is not None:
            result['pcUrl'] = self.pc_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUrl') is not None:
            self.app_url = m.get('appUrl')
        if m.get('pcUrl') is not None:
            self.pc_url = m.get('pcUrl')
        return self


class TaskInfoUpdateTaskRequestTaskExecutePersonDTOS(TeaModel):
    def __init__(
        self,
        employee_code: str = None,
        person_type: int = None,
    ):
        self.employee_code = employee_code
        self.person_type = person_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.employee_code is not None:
            result['employeeCode'] = self.employee_code
        if self.person_type is not None:
            result['personType'] = self.person_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('employeeCode') is not None:
            self.employee_code = m.get('employeeCode')
        if m.get('personType') is not None:
            self.person_type = m.get('personType')
        return self


class TaskInfoUpdateTaskRequest(TeaModel):
    def __init__(
        self,
        attr: TaskInfoUpdateTaskRequestAttr = None,
        canceldel_task_card_id: str = None,
        card_dto: TaskInfoUpdateTaskRequestCardDTO = None,
        detail_url: TaskInfoUpdateTaskRequestDetailUrl = None,
        finish_task_card_id: str = None,
        list_open_conversation_id: List[str] = None,
        operate_type: int = None,
        operator_account: str = None,
        out_task_id: str = None,
        proj_id: str = None,
        secret_key: str = None,
        send_msg_flag: int = None,
        start_task_card_id: str = None,
        task_content: str = None,
        task_end_time: int = None,
        task_execute_person_dtos: List[TaskInfoUpdateTaskRequestTaskExecutePersonDTOS] = None,
        task_title: str = None,
        task_url_mobile: str = None,
        task_url_pc: str = None,
        update_task_card_id: str = None,
    ):
        self.attr = attr
        self.canceldel_task_card_id = canceldel_task_card_id
        self.card_dto = card_dto
        self.detail_url = detail_url
        self.finish_task_card_id = finish_task_card_id
        self.list_open_conversation_id = list_open_conversation_id
        self.operate_type = operate_type
        # This parameter is required.
        self.operator_account = operator_account
        self.out_task_id = out_task_id
        # This parameter is required.
        self.proj_id = proj_id
        # This parameter is required.
        self.secret_key = secret_key
        self.send_msg_flag = send_msg_flag
        self.start_task_card_id = start_task_card_id
        self.task_content = task_content
        self.task_end_time = task_end_time
        self.task_execute_person_dtos = task_execute_person_dtos
        self.task_title = task_title
        self.task_url_mobile = task_url_mobile
        self.task_url_pc = task_url_pc
        self.update_task_card_id = update_task_card_id

    def validate(self):
        if self.attr:
            self.attr.validate()
        if self.card_dto:
            self.card_dto.validate()
        if self.detail_url:
            self.detail_url.validate()
        if self.task_execute_person_dtos:
            for k in self.task_execute_person_dtos:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.attr is not None:
            result['attr'] = self.attr.to_map()
        if self.canceldel_task_card_id is not None:
            result['canceldelTaskCardId'] = self.canceldel_task_card_id
        if self.card_dto is not None:
            result['cardDTO'] = self.card_dto.to_map()
        if self.detail_url is not None:
            result['detailUrl'] = self.detail_url.to_map()
        if self.finish_task_card_id is not None:
            result['finishTaskCardId'] = self.finish_task_card_id
        if self.list_open_conversation_id is not None:
            result['listOpenConversationId'] = self.list_open_conversation_id
        if self.operate_type is not None:
            result['operateType'] = self.operate_type
        if self.operator_account is not None:
            result['operatorAccount'] = self.operator_account
        if self.out_task_id is not None:
            result['outTaskId'] = self.out_task_id
        if self.proj_id is not None:
            result['projId'] = self.proj_id
        if self.secret_key is not None:
            result['secretKey'] = self.secret_key
        if self.send_msg_flag is not None:
            result['sendMsgFlag'] = self.send_msg_flag
        if self.start_task_card_id is not None:
            result['startTaskCardId'] = self.start_task_card_id
        if self.task_content is not None:
            result['taskContent'] = self.task_content
        if self.task_end_time is not None:
            result['taskEndTime'] = self.task_end_time
        result['taskExecutePersonDTOS'] = []
        if self.task_execute_person_dtos is not None:
            for k in self.task_execute_person_dtos:
                result['taskExecutePersonDTOS'].append(k.to_map() if k else None)
        if self.task_title is not None:
            result['taskTitle'] = self.task_title
        if self.task_url_mobile is not None:
            result['taskUrlMobile'] = self.task_url_mobile
        if self.task_url_pc is not None:
            result['taskUrlPc'] = self.task_url_pc
        if self.update_task_card_id is not None:
            result['updateTaskCardId'] = self.update_task_card_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('attr') is not None:
            temp_model = TaskInfoUpdateTaskRequestAttr()
            self.attr = temp_model.from_map(m['attr'])
        if m.get('canceldelTaskCardId') is not None:
            self.canceldel_task_card_id = m.get('canceldelTaskCardId')
        if m.get('cardDTO') is not None:
            temp_model = TaskInfoUpdateTaskRequestCardDTO()
            self.card_dto = temp_model.from_map(m['cardDTO'])
        if m.get('detailUrl') is not None:
            temp_model = TaskInfoUpdateTaskRequestDetailUrl()
            self.detail_url = temp_model.from_map(m['detailUrl'])
        if m.get('finishTaskCardId') is not None:
            self.finish_task_card_id = m.get('finishTaskCardId')
        if m.get('listOpenConversationId') is not None:
            self.list_open_conversation_id = m.get('listOpenConversationId')
        if m.get('operateType') is not None:
            self.operate_type = m.get('operateType')
        if m.get('operatorAccount') is not None:
            self.operator_account = m.get('operatorAccount')
        if m.get('outTaskId') is not None:
            self.out_task_id = m.get('outTaskId')
        if m.get('projId') is not None:
            self.proj_id = m.get('projId')
        if m.get('secretKey') is not None:
            self.secret_key = m.get('secretKey')
        if m.get('sendMsgFlag') is not None:
            self.send_msg_flag = m.get('sendMsgFlag')
        if m.get('startTaskCardId') is not None:
            self.start_task_card_id = m.get('startTaskCardId')
        if m.get('taskContent') is not None:
            self.task_content = m.get('taskContent')
        if m.get('taskEndTime') is not None:
            self.task_end_time = m.get('taskEndTime')
        self.task_execute_person_dtos = []
        if m.get('taskExecutePersonDTOS') is not None:
            for k in m.get('taskExecutePersonDTOS'):
                temp_model = TaskInfoUpdateTaskRequestTaskExecutePersonDTOS()
                self.task_execute_person_dtos.append(temp_model.from_map(k))
        if m.get('taskTitle') is not None:
            self.task_title = m.get('taskTitle')
        if m.get('taskUrlMobile') is not None:
            self.task_url_mobile = m.get('taskUrlMobile')
        if m.get('taskUrlPc') is not None:
            self.task_url_pc = m.get('taskUrlPc')
        if m.get('updateTaskCardId') is not None:
            self.update_task_card_id = m.get('updateTaskCardId')
        return self


class TaskInfoUpdateTaskResponseBodyDataGroupVoList(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        open_conversation_id: str = None,
    ):
        self.corp_id = corp_id
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
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class TaskInfoUpdateTaskResponseBodyData(TeaModel):
    def __init__(
        self,
        group_vo_list: List[TaskInfoUpdateTaskResponseBodyDataGroupVoList] = None,
        task_id: str = None,
    ):
        self.group_vo_list = group_vo_list
        self.task_id = task_id

    def validate(self):
        if self.group_vo_list:
            for k in self.group_vo_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['groupVoList'] = []
        if self.group_vo_list is not None:
            for k in self.group_vo_list:
                result['groupVoList'].append(k.to_map() if k else None)
        if self.task_id is not None:
            result['taskId'] = self.task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.group_vo_list = []
        if m.get('groupVoList') is not None:
            for k in m.get('groupVoList'):
                temp_model = TaskInfoUpdateTaskResponseBodyDataGroupVoList()
                self.group_vo_list.append(temp_model.from_map(k))
        if m.get('taskId') is not None:
            self.task_id = m.get('taskId')
        return self


class TaskInfoUpdateTaskResponseBody(TeaModel):
    def __init__(
        self,
        code: int = None,
        data: TaskInfoUpdateTaskResponseBodyData = None,
        message: str = None,
    ):
        self.code = code
        self.data = data
        self.message = message

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.code is not None:
            result['code'] = self.code
        if self.data is not None:
            result['data'] = self.data.to_map()
        if self.message is not None:
            result['message'] = self.message
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('code') is not None:
            self.code = m.get('code')
        if m.get('data') is not None:
            temp_model = TaskInfoUpdateTaskResponseBodyData()
            self.data = temp_model.from_map(m['data'])
        if m.get('message') is not None:
            self.message = m.get('message')
        return self


class TaskInfoUpdateTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: TaskInfoUpdateTaskResponseBody = None,
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
            temp_model = TaskInfoUpdateTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class TransferExclusiveAccountOrgHeaders(TeaModel):
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


class TransferExclusiveAccountOrgRequest(TeaModel):
    def __init__(
        self,
        is_setting_main_org: bool = None,
        target_corp_id: str = None,
        user_ids: List[str] = None,
    ):
        self.is_setting_main_org = is_setting_main_org
        self.target_corp_id = target_corp_id
        # This parameter is required.
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.is_setting_main_org is not None:
            result['isSettingMainOrg'] = self.is_setting_main_org
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('isSettingMainOrg') is not None:
            self.is_setting_main_org = m.get('isSettingMainOrg')
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class TransferExclusiveAccountOrgResponseBody(TeaModel):
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


class TransferExclusiveAccountOrgResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: TransferExclusiveAccountOrgResponseBody = None,
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
            temp_model = TransferExclusiveAccountOrgResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateCategoryNameHeaders(TeaModel):
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


class UpdateCategoryNameRequest(TeaModel):
    def __init__(
        self,
        current_category_name: str = None,
        target_category_name: str = None,
    ):
        self.current_category_name = current_category_name
        self.target_category_name = target_category_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.current_category_name is not None:
            result['currentCategoryName'] = self.current_category_name
        if self.target_category_name is not None:
            result['targetCategoryName'] = self.target_category_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('currentCategoryName') is not None:
            self.current_category_name = m.get('currentCategoryName')
        if m.get('targetCategoryName') is not None:
            self.target_category_name = m.get('targetCategoryName')
        return self


class UpdateCategoryNameResponseBody(TeaModel):
    def __init__(
        self,
        status: int = None,
    ):
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class UpdateCategoryNameResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateCategoryNameResponseBody = None,
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
            temp_model = UpdateCategoryNameResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateConversationTypeHeaders(TeaModel):
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


class UpdateConversationTypeRequest(TeaModel):
    def __init__(
        self,
        manage_sign: int = None,
        open_conversation_id: str = None,
    ):
        # This parameter is required.
        self.manage_sign = manage_sign
        # This parameter is required.
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.manage_sign is not None:
            result['manageSign'] = self.manage_sign
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('manageSign') is not None:
            self.manage_sign = m.get('manageSign')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class UpdateConversationTypeResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
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


class UpdateConversationTypeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateConversationTypeResponseBody = None,
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
            temp_model = UpdateConversationTypeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateFileStatusHeaders(TeaModel):
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


class UpdateFileStatusRequest(TeaModel):
    def __init__(
        self,
        request_ids: List[str] = None,
        status: int = None,
    ):
        # This parameter is required.
        self.request_ids = request_ids
        # This parameter is required.
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_ids is not None:
            result['requestIds'] = self.request_ids
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestIds') is not None:
            self.request_ids = m.get('requestIds')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class UpdateFileStatusResponseBody(TeaModel):
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


class UpdateFileStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateFileStatusResponseBody = None,
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
            temp_model = UpdateFileStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateMiniAppVersionStatusHeaders(TeaModel):
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


class UpdateMiniAppVersionStatusRequest(TeaModel):
    def __init__(
        self,
        mini_app_id: str = None,
        version: str = None,
        version_type: int = None,
    ):
        # This parameter is required.
        self.mini_app_id = mini_app_id
        self.version = version
        # This parameter is required.
        self.version_type = version_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.mini_app_id is not None:
            result['miniAppId'] = self.mini_app_id
        if self.version is not None:
            result['version'] = self.version
        if self.version_type is not None:
            result['versionType'] = self.version_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('miniAppId') is not None:
            self.mini_app_id = m.get('miniAppId')
        if m.get('version') is not None:
            self.version = m.get('version')
        if m.get('versionType') is not None:
            self.version_type = m.get('versionType')
        return self


class UpdateMiniAppVersionStatusResponseBody(TeaModel):
    def __init__(
        self,
        cause: str = None,
        code: str = None,
    ):
        self.cause = cause
        self.code = code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cause is not None:
            result['cause'] = self.cause
        if self.code is not None:
            result['code'] = self.code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cause') is not None:
            self.cause = m.get('cause')
        if m.get('code') is not None:
            self.code = m.get('code')
        return self


class UpdateMiniAppVersionStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateMiniAppVersionStatusResponseBody = None,
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
            temp_model = UpdateMiniAppVersionStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdatePartnerVisibilityHeaders(TeaModel):
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


class UpdatePartnerVisibilityRequest(TeaModel):
    def __init__(
        self,
        dept_ids: List[int] = None,
        label_id: int = None,
        user_ids: List[str] = None,
    ):
        self.dept_ids = dept_ids
        # This parameter is required.
        self.label_id = label_id
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_ids is not None:
            result['deptIds'] = self.dept_ids
        if self.label_id is not None:
            result['labelId'] = self.label_id
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptIds') is not None:
            self.dept_ids = m.get('deptIds')
        if m.get('labelId') is not None:
            self.label_id = m.get('labelId')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class UpdatePartnerVisibilityResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: bool = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

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
        if self.body is not None:
            result['body'] = self.body
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            self.body = m.get('body')
        return self


class UpdateRealmLicenseHeaders(TeaModel):
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


class UpdateRealmLicenseRequestDetailList(TeaModel):
    def __init__(
        self,
        license_type: int = None,
        user_id: str = None,
    ):
        self.license_type = license_type
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.license_type is not None:
            result['licenseType'] = self.license_type
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('licenseType') is not None:
            self.license_type = m.get('licenseType')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class UpdateRealmLicenseRequest(TeaModel):
    def __init__(
        self,
        detail_list: List[UpdateRealmLicenseRequestDetailList] = None,
    ):
        self.detail_list = detail_list

    def validate(self):
        if self.detail_list:
            for k in self.detail_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['detailList'] = []
        if self.detail_list is not None:
            for k in self.detail_list:
                result['detailList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.detail_list = []
        if m.get('detailList') is not None:
            for k in m.get('detailList'):
                temp_model = UpdateRealmLicenseRequestDetailList()
                self.detail_list.append(temp_model.from_map(k))
        return self


class UpdateRealmLicenseResponseBody(TeaModel):
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


class UpdateRealmLicenseResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateRealmLicenseResponseBody = None,
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
            temp_model = UpdateRealmLicenseResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateRoleVisibilityHeaders(TeaModel):
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


class UpdateRoleVisibilityRequest(TeaModel):
    def __init__(
        self,
        dept_ids: List[int] = None,
        label_id: int = None,
        user_ids: List[str] = None,
    ):
        self.dept_ids = dept_ids
        # This parameter is required.
        self.label_id = label_id
        self.user_ids = user_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_ids is not None:
            result['deptIds'] = self.dept_ids
        if self.label_id is not None:
            result['labelId'] = self.label_id
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptIds') is not None:
            self.dept_ids = m.get('deptIds')
        if m.get('labelId') is not None:
            self.label_id = m.get('labelId')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class UpdateRoleVisibilityResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: bool = None,
    ):
        self.headers = headers
        self.status_code = status_code
        self.body = body

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
        if self.body is not None:
            result['body'] = self.body
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('headers') is not None:
            self.headers = m.get('headers')
        if m.get('statusCode') is not None:
            self.status_code = m.get('statusCode')
        if m.get('body') is not None:
            self.body = m.get('body')
        return self


class UpdateStorageModeHeaders(TeaModel):
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


class UpdateStorageModeRequest(TeaModel):
    def __init__(
        self,
        file_storage_mode: str = None,
        target_corp_id: str = None,
    ):
        self.file_storage_mode = file_storage_mode
        # This parameter is required.
        self.target_corp_id = target_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_storage_mode is not None:
            result['fileStorageMode'] = self.file_storage_mode
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileStorageMode') is not None:
            self.file_storage_mode = m.get('fileStorageMode')
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        return self


class UpdateStorageModeResponseBody(TeaModel):
    def __init__(
        self,
        target_corp_id: str = None,
    ):
        self.target_corp_id = target_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        return self


class UpdateStorageModeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateStorageModeResponseBody = None,
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
            temp_model = UpdateStorageModeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateVoiceMsgCtrlStatusHeaders(TeaModel):
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


class UpdateVoiceMsgCtrlStatusRequestVoiceMsgCtrlInfo(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        open_msg_id: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.open_msg_id = open_msg_id
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
        if self.open_msg_id is not None:
            result['openMsgId'] = self.open_msg_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('openMsgId') is not None:
            self.open_msg_id = m.get('openMsgId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class UpdateVoiceMsgCtrlStatusRequest(TeaModel):
    def __init__(
        self,
        status: int = None,
        voice_msg_ctrl_info: UpdateVoiceMsgCtrlStatusRequestVoiceMsgCtrlInfo = None,
    ):
        # This parameter is required.
        self.status = status
        # This parameter is required.
        self.voice_msg_ctrl_info = voice_msg_ctrl_info

    def validate(self):
        if self.voice_msg_ctrl_info:
            self.voice_msg_ctrl_info.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.status is not None:
            result['status'] = self.status
        if self.voice_msg_ctrl_info is not None:
            result['voiceMsgCtrlInfo'] = self.voice_msg_ctrl_info.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('voiceMsgCtrlInfo') is not None:
            temp_model = UpdateVoiceMsgCtrlStatusRequestVoiceMsgCtrlInfo()
            self.voice_msg_ctrl_info = temp_model.from_map(m['voiceMsgCtrlInfo'])
        return self


class UpdateVoiceMsgCtrlStatusResponseBody(TeaModel):
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


class UpdateVoiceMsgCtrlStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateVoiceMsgCtrlStatusResponseBody = None,
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
            temp_model = UpdateVoiceMsgCtrlStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


