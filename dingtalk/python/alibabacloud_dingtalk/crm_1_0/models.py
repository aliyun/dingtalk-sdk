# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List, Any


class QueryAllCustomerHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryAllCustomerRequest(TeaModel):
    def __init__(
        self,
        ding_isv_org_id: int = None,
        ding_org_id: int = None,
        ding_token_grant_type: int = None,
        ding_corp_id: str = None,
        ding_suite_key: str = None,
        operator_user_id: str = None,
        max_results: int = None,
        next_token: str = None,
        object_type: str = None,
    ):
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_org_id = ding_org_id
        self.ding_token_grant_type = ding_token_grant_type
        self.ding_corp_id = ding_corp_id
        self.ding_suite_key = ding_suite_key
        # 用户ID
        self.operator_user_id = operator_user_id
        # 翻页size
        self.max_results = max_results
        # 分页游标，第一次调用传空或者null
        self.next_token = next_token
        # 数据类型
        self.object_type = object_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.ding_corp_id is not None:
            result['dingCorpId'] = self.ding_corp_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.operator_user_id is not None:
            result['operatorUserId'] = self.operator_user_id
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.object_type is not None:
            result['objectType'] = self.object_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('dingCorpId') is not None:
            self.ding_corp_id = m.get('dingCorpId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('operatorUserId') is not None:
            self.operator_user_id = m.get('operatorUserId')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('objectType') is not None:
            self.object_type = m.get('objectType')
        return self


class QueryAllCustomerResponseBodyResultValuesPermission(TeaModel):
    def __init__(
        self,
        participant_staff_ids: List[str] = None,
        owner_staff_ids: List[str] = None,
    ):
        # 协同人用户ID列表
        self.participant_staff_ids = participant_staff_ids
        # 负责人用户ID列表
        self.owner_staff_ids = owner_staff_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.participant_staff_ids is not None:
            result['participantStaffIds'] = self.participant_staff_ids
        if self.owner_staff_ids is not None:
            result['ownerStaffIds'] = self.owner_staff_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('participantStaffIds') is not None:
            self.participant_staff_ids = m.get('participantStaffIds')
        if m.get('ownerStaffIds') is not None:
            self.owner_staff_ids = m.get('ownerStaffIds')
        return self


class QueryAllCustomerResponseBodyResultValues(TeaModel):
    def __init__(
        self,
        creator_nick: str = None,
        modify_time: str = None,
        creator_user_id: str = None,
        instance_id: str = None,
        data: Dict[str, Any] = None,
        extend_data: Dict[str, Any] = None,
        create_time: str = None,
        org_id: int = None,
        object_type: str = None,
        permission: QueryAllCustomerResponseBodyResultValuesPermission = None,
        process_out_result: str = None,
        process_instance_status: str = None,
    ):
        # 创建记录的用户昵称
        self.creator_nick = creator_nick
        # 记录修改时间
        self.modify_time = modify_time
        # 创建记录的用户ID
        self.creator_user_id = creator_user_id
        # 数据ID
        self.instance_id = instance_id
        # 数据内容
        self.data = data
        # 扩展数据内容
        self.extend_data = extend_data
        # 记录创建时间
        self.create_time = create_time
        # 系统自动生成
        self.org_id = org_id
        # 数据类型
        self.object_type = object_type
        # 数据权限信息
        self.permission = permission
        # 审批结果
        self.process_out_result = process_out_result
        # 审批状态
        self.process_instance_status = process_instance_status

    def validate(self):
        if self.permission:
            self.permission.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.creator_nick is not None:
            result['creatorNick'] = self.creator_nick
        if self.modify_time is not None:
            result['modifyTime'] = self.modify_time
        if self.creator_user_id is not None:
            result['creatorUserId'] = self.creator_user_id
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.data is not None:
            result['data'] = self.data
        if self.extend_data is not None:
            result['extendData'] = self.extend_data
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.org_id is not None:
            result['orgId'] = self.org_id
        if self.object_type is not None:
            result['objectType'] = self.object_type
        if self.permission is not None:
            result['permission'] = self.permission.to_map()
        if self.process_out_result is not None:
            result['processOutResult'] = self.process_out_result
        if self.process_instance_status is not None:
            result['processInstanceStatus'] = self.process_instance_status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('creatorNick') is not None:
            self.creator_nick = m.get('creatorNick')
        if m.get('modifyTime') is not None:
            self.modify_time = m.get('modifyTime')
        if m.get('creatorUserId') is not None:
            self.creator_user_id = m.get('creatorUserId')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('extendData') is not None:
            self.extend_data = m.get('extendData')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('orgId') is not None:
            self.org_id = m.get('orgId')
        if m.get('objectType') is not None:
            self.object_type = m.get('objectType')
        if m.get('permission') is not None:
            temp_model = QueryAllCustomerResponseBodyResultValuesPermission()
            self.permission = temp_model.from_map(m['permission'])
        if m.get('processOutResult') is not None:
            self.process_out_result = m.get('processOutResult')
        if m.get('processInstanceStatus') is not None:
            self.process_instance_status = m.get('processInstanceStatus')
        return self


class QueryAllCustomerResponseBodyResult(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        values: List[QueryAllCustomerResponseBodyResultValues] = None,
        max_results: int = None,
    ):
        # 下一页的游标，为null则表示无数据
        self.next_token = next_token
        # 客户数据节点
        self.values = values
        # 分页大小
        self.max_results = max_results

    def validate(self):
        if self.values:
            for k in self.values:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['values'] = []
        if self.values is not None:
            for k in self.values:
                result['values'].append(k.to_map() if k else None)
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.values = []
        if m.get('values') is not None:
            for k in m.get('values'):
                temp_model = QueryAllCustomerResponseBodyResultValues()
                self.values.append(temp_model.from_map(k))
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        return self


class QueryAllCustomerResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryAllCustomerResponseBodyResult = None,
    ):
        # 分页结果
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
            temp_model = QueryAllCustomerResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class QueryAllCustomerResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryAllCustomerResponseBody = None,
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
            temp_model = QueryAllCustomerResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetOfficialAccountContactsHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetOfficialAccountContactsRequest(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        max_results: int = None,
    ):
        # 取数游标，第一次传0
        self.next_token = next_token
        # 分页大小，最大不超过10
        self.max_results = max_results

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        return self


class GetOfficialAccountContactsResponseBodyValuesContactsPermission(TeaModel):
    def __init__(
        self,
        participant_staff_ids: List[str] = None,
        owner_staff_ids: List[str] = None,
    ):
        # 协同人用户ID列表
        self.participant_staff_ids = participant_staff_ids
        # 负责人用户ID列表
        self.owner_staff_ids = owner_staff_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.participant_staff_ids is not None:
            result['participantStaffIds'] = self.participant_staff_ids
        if self.owner_staff_ids is not None:
            result['ownerStaffIds'] = self.owner_staff_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('participantStaffIds') is not None:
            self.participant_staff_ids = m.get('participantStaffIds')
        if m.get('ownerStaffIds') is not None:
            self.owner_staff_ids = m.get('ownerStaffIds')
        return self


class GetOfficialAccountContactsResponseBodyValuesContacts(TeaModel):
    def __init__(
        self,
        creator_nick: str = None,
        modify_time: str = None,
        create_time: str = None,
        creator_user_id: str = None,
        instance_id: str = None,
        data: Dict[str, Any] = None,
        extend_data: Dict[str, Any] = None,
        permission: GetOfficialAccountContactsResponseBodyValuesContactsPermission = None,
    ):
        # 创建记录的用户昵称
        self.creator_nick = creator_nick
        # 记录修改时间
        self.modify_time = modify_time
        # 记录创建时间
        self.create_time = create_time
        # 创建记录的用户ID
        self.creator_user_id = creator_user_id
        # 数据ID
        self.instance_id = instance_id
        # 数据内容
        self.data = data
        # 扩展数据内容
        self.extend_data = extend_data
        # 数据权限信息
        self.permission = permission

    def validate(self):
        if self.permission:
            self.permission.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.creator_nick is not None:
            result['creatorNick'] = self.creator_nick
        if self.modify_time is not None:
            result['modifyTime'] = self.modify_time
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.creator_user_id is not None:
            result['creatorUserId'] = self.creator_user_id
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.data is not None:
            result['data'] = self.data
        if self.extend_data is not None:
            result['extendData'] = self.extend_data
        if self.permission is not None:
            result['permission'] = self.permission.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('creatorNick') is not None:
            self.creator_nick = m.get('creatorNick')
        if m.get('modifyTime') is not None:
            self.modify_time = m.get('modifyTime')
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('creatorUserId') is not None:
            self.creator_user_id = m.get('creatorUserId')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('extendData') is not None:
            self.extend_data = m.get('extendData')
        if m.get('permission') is not None:
            temp_model = GetOfficialAccountContactsResponseBodyValuesContactsPermission()
            self.permission = temp_model.from_map(m['permission'])
        return self


class GetOfficialAccountContactsResponseBodyValues(TeaModel):
    def __init__(
        self,
        user_id: str = None,
        contacts: List[GetOfficialAccountContactsResponseBodyValuesContacts] = None,
    ):
        # 用户userId
        self.user_id = user_id
        # 用户的联系人数据
        self.contacts = contacts

    def validate(self):
        if self.contacts:
            for k in self.contacts:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.user_id is not None:
            result['userId'] = self.user_id
        result['contacts'] = []
        if self.contacts is not None:
            for k in self.contacts:
                result['contacts'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        self.contacts = []
        if m.get('contacts') is not None:
            for k in m.get('contacts'):
                temp_model = GetOfficialAccountContactsResponseBodyValuesContacts()
                self.contacts.append(temp_model.from_map(k))
        return self


class GetOfficialAccountContactsResponseBody(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        max_results: int = None,
        values: List[GetOfficialAccountContactsResponseBodyValues] = None,
    ):
        # 下一页的游标，为null则表示无数据
        self.next_token = next_token
        # 分页大小
        self.max_results = max_results
        # 客户数据节点
        self.values = values

    def validate(self):
        if self.values:
            for k in self.values:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        result['values'] = []
        if self.values is not None:
            for k in self.values:
                result['values'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        self.values = []
        if m.get('values') is not None:
            for k in m.get('values'):
                temp_model = GetOfficialAccountContactsResponseBodyValues()
                self.values.append(temp_model.from_map(k))
        return self


class GetOfficialAccountContactsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetOfficialAccountContactsResponseBody = None,
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
            temp_model = GetOfficialAccountContactsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ServiceWindowMessageBatchPushHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class ServiceWindowMessageBatchPushRequestDetailMessageBodyText(TeaModel):
    def __init__(
        self,
        content: str = None,
    ):
        self.content = content

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        return self


class ServiceWindowMessageBatchPushRequestDetailMessageBodyMarkdown(TeaModel):
    def __init__(
        self,
        title: str = None,
        text: str = None,
    ):
        self.title = title
        self.text = text

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.title is not None:
            result['title'] = self.title
        if self.text is not None:
            result['text'] = self.text
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('text') is not None:
            self.text = m.get('text')
        return self


class ServiceWindowMessageBatchPushRequestDetailMessageBodyLink(TeaModel):
    def __init__(
        self,
        pic_url: str = None,
        message_url: str = None,
        title: str = None,
        text: str = None,
    ):
        self.pic_url = pic_url
        self.message_url = message_url
        self.title = title
        self.text = text

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.pic_url is not None:
            result['picUrl'] = self.pic_url
        if self.message_url is not None:
            result['messageUrl'] = self.message_url
        if self.title is not None:
            result['title'] = self.title
        if self.text is not None:
            result['text'] = self.text
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('picUrl') is not None:
            self.pic_url = m.get('picUrl')
        if m.get('messageUrl') is not None:
            self.message_url = m.get('messageUrl')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('text') is not None:
            self.text = m.get('text')
        return self


class ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCardButtonList(TeaModel):
    def __init__(
        self,
        title: str = None,
        action_url: str = None,
    ):
        self.title = title
        self.action_url = action_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.title is not None:
            result['title'] = self.title
        if self.action_url is not None:
            result['actionUrl'] = self.action_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('actionUrl') is not None:
            self.action_url = m.get('actionUrl')
        return self


class ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard(TeaModel):
    def __init__(
        self,
        button_orientation: str = None,
        single_url: str = None,
        single_title: str = None,
        markdown: str = None,
        title: str = None,
        button_list: List[ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCardButtonList] = None,
    ):
        self.button_orientation = button_orientation
        self.single_url = single_url
        self.single_title = single_title
        self.markdown = markdown
        self.title = title
        self.button_list = button_list

    def validate(self):
        if self.button_list:
            for k in self.button_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.button_orientation is not None:
            result['buttonOrientation'] = self.button_orientation
        if self.single_url is not None:
            result['singleUrl'] = self.single_url
        if self.single_title is not None:
            result['singleTitle'] = self.single_title
        if self.markdown is not None:
            result['markdown'] = self.markdown
        if self.title is not None:
            result['title'] = self.title
        result['buttonList'] = []
        if self.button_list is not None:
            for k in self.button_list:
                result['buttonList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('buttonOrientation') is not None:
            self.button_orientation = m.get('buttonOrientation')
        if m.get('singleUrl') is not None:
            self.single_url = m.get('singleUrl')
        if m.get('singleTitle') is not None:
            self.single_title = m.get('singleTitle')
        if m.get('markdown') is not None:
            self.markdown = m.get('markdown')
        if m.get('title') is not None:
            self.title = m.get('title')
        self.button_list = []
        if m.get('buttonList') is not None:
            for k in m.get('buttonList'):
                temp_model = ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCardButtonList()
                self.button_list.append(temp_model.from_map(k))
        return self


class ServiceWindowMessageBatchPushRequestDetailMessageBody(TeaModel):
    def __init__(
        self,
        text: ServiceWindowMessageBatchPushRequestDetailMessageBodyText = None,
        markdown: ServiceWindowMessageBatchPushRequestDetailMessageBodyMarkdown = None,
        link: ServiceWindowMessageBatchPushRequestDetailMessageBodyLink = None,
        action_card: ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard = None,
    ):
        self.text = text
        self.markdown = markdown
        self.link = link
        self.action_card = action_card

    def validate(self):
        if self.text:
            self.text.validate()
        if self.markdown:
            self.markdown.validate()
        if self.link:
            self.link.validate()
        if self.action_card:
            self.action_card.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.text is not None:
            result['text'] = self.text.to_map()
        if self.markdown is not None:
            result['markdown'] = self.markdown.to_map()
        if self.link is not None:
            result['link'] = self.link.to_map()
        if self.action_card is not None:
            result['actionCard'] = self.action_card.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('text') is not None:
            temp_model = ServiceWindowMessageBatchPushRequestDetailMessageBodyText()
            self.text = temp_model.from_map(m['text'])
        if m.get('markdown') is not None:
            temp_model = ServiceWindowMessageBatchPushRequestDetailMessageBodyMarkdown()
            self.markdown = temp_model.from_map(m['markdown'])
        if m.get('link') is not None:
            temp_model = ServiceWindowMessageBatchPushRequestDetailMessageBodyLink()
            self.link = temp_model.from_map(m['link'])
        if m.get('actionCard') is not None:
            temp_model = ServiceWindowMessageBatchPushRequestDetailMessageBodyActionCard()
            self.action_card = temp_model.from_map(m['actionCard'])
        return self


class ServiceWindowMessageBatchPushRequestDetail(TeaModel):
    def __init__(
        self,
        msg_type: str = None,
        uuid: str = None,
        biz_request_id: str = None,
        user_id_list: List[str] = None,
        message_body: ServiceWindowMessageBatchPushRequestDetailMessageBody = None,
        send_to_all: bool = None,
    ):
        self.msg_type = msg_type
        self.uuid = uuid
        self.biz_request_id = biz_request_id
        self.user_id_list = user_id_list
        self.message_body = message_body
        self.send_to_all = send_to_all

    def validate(self):
        if self.message_body:
            self.message_body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.msg_type is not None:
            result['msgType'] = self.msg_type
        if self.uuid is not None:
            result['uuid'] = self.uuid
        if self.biz_request_id is not None:
            result['bizRequestId'] = self.biz_request_id
        if self.user_id_list is not None:
            result['userIdList'] = self.user_id_list
        if self.message_body is not None:
            result['messageBody'] = self.message_body.to_map()
        if self.send_to_all is not None:
            result['sendToAll'] = self.send_to_all
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('msgType') is not None:
            self.msg_type = m.get('msgType')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        if m.get('bizRequestId') is not None:
            self.biz_request_id = m.get('bizRequestId')
        if m.get('userIdList') is not None:
            self.user_id_list = m.get('userIdList')
        if m.get('messageBody') is not None:
            temp_model = ServiceWindowMessageBatchPushRequestDetailMessageBody()
            self.message_body = temp_model.from_map(m['messageBody'])
        if m.get('sendToAll') is not None:
            self.send_to_all = m.get('sendToAll')
        return self


class ServiceWindowMessageBatchPushRequest(TeaModel):
    def __init__(
        self,
        detail: ServiceWindowMessageBatchPushRequestDetail = None,
        biz_id: str = None,
        ding_isv_org_id: int = None,
        ding_org_id: int = None,
        ding_token_grant_type: int = None,
        ding_suite_key: str = None,
    ):
        self.detail = detail
        self.biz_id = biz_id
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_org_id = ding_org_id
        self.ding_token_grant_type = ding_token_grant_type
        self.ding_suite_key = ding_suite_key

    def validate(self):
        if self.detail:
            self.detail.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.detail is not None:
            result['detail'] = self.detail.to_map()
        if self.biz_id is not None:
            result['bizId'] = self.biz_id
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('detail') is not None:
            temp_model = ServiceWindowMessageBatchPushRequestDetail()
            self.detail = temp_model.from_map(m['detail'])
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        return self


class ServiceWindowMessageBatchPushResponseBodyResult(TeaModel):
    def __init__(
        self,
        open_push_id: str = None,
    ):
        self.open_push_id = open_push_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_push_id is not None:
            result['openPushId'] = self.open_push_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openPushId') is not None:
            self.open_push_id = m.get('openPushId')
        return self


class ServiceWindowMessageBatchPushResponseBody(TeaModel):
    def __init__(
        self,
        result: ServiceWindowMessageBatchPushResponseBodyResult = None,
        request_id: str = None,
    ):
        # result
        self.result = result
        self.request_id = request_id

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
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = ServiceWindowMessageBatchPushResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class ServiceWindowMessageBatchPushResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ServiceWindowMessageBatchPushResponseBody = None,
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
            temp_model = ServiceWindowMessageBatchPushResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteCrmFormInstanceHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class DeleteCrmFormInstanceRequest(TeaModel):
    def __init__(
        self,
        current_operator_user_id: str = None,
        name: str = None,
    ):
        # 当前操作人id
        self.current_operator_user_id = current_operator_user_id
        # 模版名称
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.current_operator_user_id is not None:
            result['currentOperatorUserId'] = self.current_operator_user_id
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('currentOperatorUserId') is not None:
            self.current_operator_user_id = m.get('currentOperatorUserId')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class DeleteCrmFormInstanceResponseBody(TeaModel):
    def __init__(
        self,
        instance_id: str = None,
    ):
        # 被删除的实例id
        self.instance_id = instance_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        return self


class DeleteCrmFormInstanceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DeleteCrmFormInstanceResponseBody = None,
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
            temp_model = DeleteCrmFormInstanceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SendOfficialAccountOTOMessageHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class SendOfficialAccountOTOMessageRequestDetailMessageBodyText(TeaModel):
    def __init__(
        self,
        content: str = None,
    ):
        # 消息内容，建议500字符以内。
        self.content = content

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        return self


class SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown(TeaModel):
    def __init__(
        self,
        title: str = None,
        text: str = None,
    ):
        # 首屏会话透出的展示内容。
        self.title = title
        # markdown格式的消息，建议500字符以内。
        self.text = text

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.title is not None:
            result['title'] = self.title
        if self.text is not None:
            result['text'] = self.text
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('text') is not None:
            self.text = m.get('text')
        return self


class SendOfficialAccountOTOMessageRequestDetailMessageBodyLink(TeaModel):
    def __init__(
        self,
        pic_url: str = None,
        message_url: str = None,
        title: str = None,
        text: str = None,
    ):
        # 图片地址
        self.pic_url = pic_url
        # 消息点击链接地址，当发送消息为小程序时支持小程序跳转链接。
        self.message_url = message_url
        # 消息标题，建议100字符以内。
        self.title = title
        # 消息描述，建议500字符以内。
        self.text = text

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.pic_url is not None:
            result['picUrl'] = self.pic_url
        if self.message_url is not None:
            result['messageUrl'] = self.message_url
        if self.title is not None:
            result['title'] = self.title
        if self.text is not None:
            result['text'] = self.text
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('picUrl') is not None:
            self.pic_url = m.get('picUrl')
        if m.get('messageUrl') is not None:
            self.message_url = m.get('messageUrl')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('text') is not None:
            self.text = m.get('text')
        return self


class SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList(TeaModel):
    def __init__(
        self,
        title: str = None,
        action_url: str = None,
    ):
        # 使用独立跳转ActionCard样式时的按钮的标题，最长20个字符。
        self.title = title
        # 使用独立跳转ActionCard样式时的跳转链接。
        self.action_url = action_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.title is not None:
            result['title'] = self.title
        if self.action_url is not None:
            result['actionUrl'] = self.action_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('actionUrl') is not None:
            self.action_url = m.get('actionUrl')
        return self


class SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard(TeaModel):
    def __init__(
        self,
        button_orientation: str = None,
        single_url: str = None,
        single_title: str = None,
        markdown: str = None,
        title: str = None,
        button_list: List[SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList] = None,
    ):
        # 按钮排列方式： 0：竖直排列 1：横向排列 必须与buttonList同时设置。
        self.button_orientation = button_orientation
        # 消息点击链接地址，当发送消息为小程序时支持小程序跳转链接，最长500个字符。
        self.single_url = single_url
        # 使用整体跳转ActionCard样式时的标题。必须与singleUrl同时设置，最长20个字符。
        self.single_title = single_title
        # 消息内容，支持markdown，语法参考标准markdown语法。1000个字符以内。
        self.markdown = markdown
        # 透出到会话列表和通知的文案
        self.title = title
        # 使用独立跳转ActionCard样式时的按钮列表；必须与buttonOrientation同时设置，且长度不超过1000字符。
        self.button_list = button_list

    def validate(self):
        if self.button_list:
            for k in self.button_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.button_orientation is not None:
            result['buttonOrientation'] = self.button_orientation
        if self.single_url is not None:
            result['singleUrl'] = self.single_url
        if self.single_title is not None:
            result['singleTitle'] = self.single_title
        if self.markdown is not None:
            result['markdown'] = self.markdown
        if self.title is not None:
            result['title'] = self.title
        result['buttonList'] = []
        if self.button_list is not None:
            for k in self.button_list:
                result['buttonList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('buttonOrientation') is not None:
            self.button_orientation = m.get('buttonOrientation')
        if m.get('singleUrl') is not None:
            self.single_url = m.get('singleUrl')
        if m.get('singleTitle') is not None:
            self.single_title = m.get('singleTitle')
        if m.get('markdown') is not None:
            self.markdown = m.get('markdown')
        if m.get('title') is not None:
            self.title = m.get('title')
        self.button_list = []
        if m.get('buttonList') is not None:
            for k in m.get('buttonList'):
                temp_model = SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList()
                self.button_list.append(temp_model.from_map(k))
        return self


class SendOfficialAccountOTOMessageRequestDetailMessageBody(TeaModel):
    def __init__(
        self,
        text: SendOfficialAccountOTOMessageRequestDetailMessageBodyText = None,
        markdown: SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown = None,
        link: SendOfficialAccountOTOMessageRequestDetailMessageBodyLink = None,
        action_card: SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard = None,
    ):
        # 文本消息体  对于文本类型消息时必填
        self.text = text
        # markdown消息，仅对消息类型为markdown时有效
        self.markdown = markdown
        # 链接消息类型
        self.link = link
        # 卡片消息
        self.action_card = action_card

    def validate(self):
        if self.text:
            self.text.validate()
        if self.markdown:
            self.markdown.validate()
        if self.link:
            self.link.validate()
        if self.action_card:
            self.action_card.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.text is not None:
            result['text'] = self.text.to_map()
        if self.markdown is not None:
            result['markdown'] = self.markdown.to_map()
        if self.link is not None:
            result['link'] = self.link.to_map()
        if self.action_card is not None:
            result['actionCard'] = self.action_card.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('text') is not None:
            temp_model = SendOfficialAccountOTOMessageRequestDetailMessageBodyText()
            self.text = temp_model.from_map(m['text'])
        if m.get('markdown') is not None:
            temp_model = SendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown()
            self.markdown = temp_model.from_map(m['markdown'])
        if m.get('link') is not None:
            temp_model = SendOfficialAccountOTOMessageRequestDetailMessageBodyLink()
            self.link = temp_model.from_map(m['link'])
        if m.get('actionCard') is not None:
            temp_model = SendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard()
            self.action_card = temp_model.from_map(m['actionCard'])
        return self


class SendOfficialAccountOTOMessageRequestDetail(TeaModel):
    def __init__(
        self,
        msg_type: str = None,
        uuid: str = None,
        user_id: str = None,
        message_body: SendOfficialAccountOTOMessageRequestDetailMessageBody = None,
    ):
        # 消息类型
        self.msg_type = msg_type
        # 请求唯一 ID
        self.uuid = uuid
        # 消息接收人id
        self.user_id = user_id
        # 消息体
        self.message_body = message_body

    def validate(self):
        if self.message_body:
            self.message_body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.msg_type is not None:
            result['msgType'] = self.msg_type
        if self.uuid is not None:
            result['uuid'] = self.uuid
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.message_body is not None:
            result['messageBody'] = self.message_body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('msgType') is not None:
            self.msg_type = m.get('msgType')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('messageBody') is not None:
            temp_model = SendOfficialAccountOTOMessageRequestDetailMessageBody()
            self.message_body = temp_model.from_map(m['messageBody'])
        return self


class SendOfficialAccountOTOMessageRequest(TeaModel):
    def __init__(
        self,
        detail: SendOfficialAccountOTOMessageRequestDetail = None,
        biz_id: str = None,
        ding_token_grant_type: int = None,
        ding_isv_org_id: int = None,
        ding_org_id: int = None,
        ding_suite_key: str = None,
    ):
        # 消息详情
        self.detail = detail
        # API调用标识，可选参数
        self.biz_id = biz_id
        self.ding_token_grant_type = ding_token_grant_type
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_org_id = ding_org_id
        self.ding_suite_key = ding_suite_key

    def validate(self):
        if self.detail:
            self.detail.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.detail is not None:
            result['detail'] = self.detail.to_map()
        if self.biz_id is not None:
            result['bizId'] = self.biz_id
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('detail') is not None:
            temp_model = SendOfficialAccountOTOMessageRequestDetail()
            self.detail = temp_model.from_map(m['detail'])
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        return self


class SendOfficialAccountOTOMessageResponseBodyResult(TeaModel):
    def __init__(
        self,
        open_push_id: str = None,
    ):
        # 推送ID
        self.open_push_id = open_push_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_push_id is not None:
            result['openPushId'] = self.open_push_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openPushId') is not None:
            self.open_push_id = m.get('openPushId')
        return self


class SendOfficialAccountOTOMessageResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: SendOfficialAccountOTOMessageResponseBodyResult = None,
    ):
        # Id of the request
        self.request_id = request_id
        # 推送结果
        self.result = result

    def validate(self):
        if self.result:
            self.result.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.request_id is not None:
            result['requestId'] = self.request_id
        if self.result is not None:
            result['result'] = self.result.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        if m.get('result') is not None:
            temp_model = SendOfficialAccountOTOMessageResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class SendOfficialAccountOTOMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SendOfficialAccountOTOMessageResponseBody = None,
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
            temp_model = SendOfficialAccountOTOMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BatchSendOfficialAccountOTOMessageHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyText(TeaModel):
    def __init__(
        self,
        content: str = None,
    ):
        # 消息内容，建议500字符以内。
        self.content = content

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        return self


class BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown(TeaModel):
    def __init__(
        self,
        title: str = None,
        text: str = None,
    ):
        # 首屏会话透出的展示内容。
        self.title = title
        # markdown格式的消息，建议500字符以内。
        self.text = text

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.title is not None:
            result['title'] = self.title
        if self.text is not None:
            result['text'] = self.text
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('text') is not None:
            self.text = m.get('text')
        return self


class BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink(TeaModel):
    def __init__(
        self,
        pic_url: str = None,
        message_url: str = None,
        title: str = None,
        text: str = None,
    ):
        # 图片地址
        self.pic_url = pic_url
        # 消息点击链接地址，当发送消息为小程序时支持小程序跳转链接。
        self.message_url = message_url
        # 消息标题，建议100字符以内。
        self.title = title
        # 消息描述，建议500字符以内。
        self.text = text

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.pic_url is not None:
            result['picUrl'] = self.pic_url
        if self.message_url is not None:
            result['messageUrl'] = self.message_url
        if self.title is not None:
            result['title'] = self.title
        if self.text is not None:
            result['text'] = self.text
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('picUrl') is not None:
            self.pic_url = m.get('picUrl')
        if m.get('messageUrl') is not None:
            self.message_url = m.get('messageUrl')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('text') is not None:
            self.text = m.get('text')
        return self


class BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList(TeaModel):
    def __init__(
        self,
        title: str = None,
        action_url: str = None,
    ):
        # 使用独立跳转ActionCard样式时的按钮的标题，最长20个字符。
        self.title = title
        # 使用独立跳转ActionCard样式时的跳转链接。
        self.action_url = action_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.title is not None:
            result['title'] = self.title
        if self.action_url is not None:
            result['actionUrl'] = self.action_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('actionUrl') is not None:
            self.action_url = m.get('actionUrl')
        return self


class BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard(TeaModel):
    def __init__(
        self,
        button_orientation: str = None,
        single_url: str = None,
        single_title: str = None,
        markdown: str = None,
        title: str = None,
        button_list: List[BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList] = None,
    ):
        # 按钮排列方式： 0：竖直排列 1：横向排列 必须与buttonList同时设置。
        self.button_orientation = button_orientation
        # 消息点击链接地址，当发送消息为小程序时支持小程序跳转链接，最长500个字符。
        self.single_url = single_url
        # 使用整体跳转ActionCard样式时的标题。必须与singleUrl同时设置，最长20个字符。
        self.single_title = single_title
        # 消息内容，支持markdown，语法参考标准markdown语法。1000个字符以内。
        self.markdown = markdown
        # 透出到会话列表和通知的文案
        self.title = title
        # 使用独立跳转ActionCard样式时的按钮列表；必须与buttonOrientation同时设置，且长度不超过1000字符。
        self.button_list = button_list

    def validate(self):
        if self.button_list:
            for k in self.button_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.button_orientation is not None:
            result['buttonOrientation'] = self.button_orientation
        if self.single_url is not None:
            result['singleUrl'] = self.single_url
        if self.single_title is not None:
            result['singleTitle'] = self.single_title
        if self.markdown is not None:
            result['markdown'] = self.markdown
        if self.title is not None:
            result['title'] = self.title
        result['buttonList'] = []
        if self.button_list is not None:
            for k in self.button_list:
                result['buttonList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('buttonOrientation') is not None:
            self.button_orientation = m.get('buttonOrientation')
        if m.get('singleUrl') is not None:
            self.single_url = m.get('singleUrl')
        if m.get('singleTitle') is not None:
            self.single_title = m.get('singleTitle')
        if m.get('markdown') is not None:
            self.markdown = m.get('markdown')
        if m.get('title') is not None:
            self.title = m.get('title')
        self.button_list = []
        if m.get('buttonList') is not None:
            for k in m.get('buttonList'):
                temp_model = BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCardButtonList()
                self.button_list.append(temp_model.from_map(k))
        return self


class BatchSendOfficialAccountOTOMessageRequestDetailMessageBody(TeaModel):
    def __init__(
        self,
        text: BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyText = None,
        markdown: BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown = None,
        link: BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink = None,
        action_card: BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard = None,
    ):
        # 文本消息体  对于文本类型消息时必填
        self.text = text
        # markdown消息，仅对消息类型为markdown时有效
        self.markdown = markdown
        # 链接消息类型
        self.link = link
        # 卡片消息
        self.action_card = action_card

    def validate(self):
        if self.text:
            self.text.validate()
        if self.markdown:
            self.markdown.validate()
        if self.link:
            self.link.validate()
        if self.action_card:
            self.action_card.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.text is not None:
            result['text'] = self.text.to_map()
        if self.markdown is not None:
            result['markdown'] = self.markdown.to_map()
        if self.link is not None:
            result['link'] = self.link.to_map()
        if self.action_card is not None:
            result['actionCard'] = self.action_card.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('text') is not None:
            temp_model = BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyText()
            self.text = temp_model.from_map(m['text'])
        if m.get('markdown') is not None:
            temp_model = BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyMarkdown()
            self.markdown = temp_model.from_map(m['markdown'])
        if m.get('link') is not None:
            temp_model = BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyLink()
            self.link = temp_model.from_map(m['link'])
        if m.get('actionCard') is not None:
            temp_model = BatchSendOfficialAccountOTOMessageRequestDetailMessageBodyActionCard()
            self.action_card = temp_model.from_map(m['actionCard'])
        return self


class BatchSendOfficialAccountOTOMessageRequestDetail(TeaModel):
    def __init__(
        self,
        msg_type: str = None,
        uuid: str = None,
        biz_request_id: str = None,
        user_id_list: List[str] = None,
        message_body: BatchSendOfficialAccountOTOMessageRequestDetailMessageBody = None,
        send_to_all: bool = None,
    ):
        # 消息类型
        self.msg_type = msg_type
        # 消息请求唯一ID
        self.uuid = uuid
        # 业务请求标识，当一次业务请求需要多次调用发送API时可以设置此参数，方便后续跟踪处理。
        self.biz_request_id = biz_request_id
        # 消息接收人列表，最多支持1000人
        self.user_id_list = user_id_list
        # 消息体
        self.message_body = message_body
        # 全员群发
        self.send_to_all = send_to_all

    def validate(self):
        if self.message_body:
            self.message_body.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.msg_type is not None:
            result['msgType'] = self.msg_type
        if self.uuid is not None:
            result['uuid'] = self.uuid
        if self.biz_request_id is not None:
            result['bizRequestId'] = self.biz_request_id
        if self.user_id_list is not None:
            result['userIdList'] = self.user_id_list
        if self.message_body is not None:
            result['messageBody'] = self.message_body.to_map()
        if self.send_to_all is not None:
            result['sendToAll'] = self.send_to_all
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('msgType') is not None:
            self.msg_type = m.get('msgType')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        if m.get('bizRequestId') is not None:
            self.biz_request_id = m.get('bizRequestId')
        if m.get('userIdList') is not None:
            self.user_id_list = m.get('userIdList')
        if m.get('messageBody') is not None:
            temp_model = BatchSendOfficialAccountOTOMessageRequestDetailMessageBody()
            self.message_body = temp_model.from_map(m['messageBody'])
        if m.get('sendToAll') is not None:
            self.send_to_all = m.get('sendToAll')
        return self


class BatchSendOfficialAccountOTOMessageRequest(TeaModel):
    def __init__(
        self,
        detail: BatchSendOfficialAccountOTOMessageRequestDetail = None,
        biz_id: str = None,
        ding_isv_org_id: int = None,
        ding_org_id: int = None,
        ding_token_grant_type: int = None,
        ding_suite_key: str = None,
    ):
        # 消息详情
        self.detail = detail
        # 服务窗授权的调用方标识，可空
        self.biz_id = biz_id
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_org_id = ding_org_id
        self.ding_token_grant_type = ding_token_grant_type
        self.ding_suite_key = ding_suite_key

    def validate(self):
        if self.detail:
            self.detail.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.detail is not None:
            result['detail'] = self.detail.to_map()
        if self.biz_id is not None:
            result['bizId'] = self.biz_id
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('detail') is not None:
            temp_model = BatchSendOfficialAccountOTOMessageRequestDetail()
            self.detail = temp_model.from_map(m['detail'])
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        return self


class BatchSendOfficialAccountOTOMessageResponseBodyResult(TeaModel):
    def __init__(
        self,
        open_push_id: str = None,
    ):
        self.open_push_id = open_push_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_push_id is not None:
            result['openPushId'] = self.open_push_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openPushId') is not None:
            self.open_push_id = m.get('openPushId')
        return self


class BatchSendOfficialAccountOTOMessageResponseBody(TeaModel):
    def __init__(
        self,
        result: BatchSendOfficialAccountOTOMessageResponseBodyResult = None,
        request_id: str = None,
    ):
        # result
        self.result = result
        # 开放API
        self.request_id = request_id

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
        if self.request_id is not None:
            result['requestId'] = self.request_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('result') is not None:
            temp_model = BatchSendOfficialAccountOTOMessageResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('requestId') is not None:
            self.request_id = m.get('requestId')
        return self


class BatchSendOfficialAccountOTOMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: BatchSendOfficialAccountOTOMessageResponseBody = None,
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
            temp_model = BatchSendOfficialAccountOTOMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetOfficialAccountContactInfoHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetOfficialAccountContactInfoResponseBody(TeaModel):
    def __init__(
        self,
        corp_name: str = None,
        mobile: str = None,
        state_code: str = None,
        union_id: str = None,
        auth_items: List[str] = None,
    ):
        # 联系人主企业名称
        self.corp_name = corp_name
        # 手机号
        self.mobile = mobile
        # 手机号国家码
        self.state_code = state_code
        # 联系人的unionId
        self.union_id = union_id
        # 已授权的字段
        self.auth_items = auth_items

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_name is not None:
            result['corpName'] = self.corp_name
        if self.mobile is not None:
            result['mobile'] = self.mobile
        if self.state_code is not None:
            result['stateCode'] = self.state_code
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.auth_items is not None:
            result['authItems'] = self.auth_items
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpName') is not None:
            self.corp_name = m.get('corpName')
        if m.get('mobile') is not None:
            self.mobile = m.get('mobile')
        if m.get('stateCode') is not None:
            self.state_code = m.get('stateCode')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('authItems') is not None:
            self.auth_items = m.get('authItems')
        return self


class GetOfficialAccountContactInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetOfficialAccountContactInfoResponseBody = None,
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
            temp_model = GetOfficialAccountContactInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


