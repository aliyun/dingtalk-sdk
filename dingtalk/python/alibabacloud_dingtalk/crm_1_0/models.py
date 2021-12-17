# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List, Any


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


class GetCrmRolePermissionHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetCrmRolePermissionRequest(TeaModel):
    def __init__(
        self,
        form_code: str = None,
        biz_type: str = None,
    ):
        # 表单标识（formCode & bizType二选一）
        self.form_code = form_code
        # 表单业务标识（formCode & bizType二选一）
        self.biz_type = biz_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.form_code is not None:
            result['formCode'] = self.form_code
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('formCode') is not None:
            self.form_code = m.get('formCode')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        return self


class GetCrmRolePermissionResponseBodyPermissionsRoleMemberList(TeaModel):
    def __init__(
        self,
        name: str = None,
        staff_id: str = None,
        type: str = None,
        member_id: str = None,
    ):
        # 角色名
        self.name = name
        # 角色的userId
        self.staff_id = staff_id
        # 角色类型
        self.type = type
        # 角色值
        self.member_id = member_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.staff_id is not None:
            result['staffId'] = self.staff_id
        if self.type is not None:
            result['type'] = self.type
        if self.member_id is not None:
            result['memberId'] = self.member_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('staffId') is not None:
            self.staff_id = m.get('staffId')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('memberId') is not None:
            self.member_id = m.get('memberId')
        return self


class GetCrmRolePermissionResponseBodyPermissionsManagingScopeListExt(TeaModel):
    def __init__(
        self,
        staff_id_list: List[str] = None,
        dept_id_list: List[float] = None,
    ):
        # 管理员工列表
        self.staff_id_list = staff_id_list
        # 管理部门列表
        self.dept_id_list = dept_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.staff_id_list is not None:
            result['staffIdList'] = self.staff_id_list
        if self.dept_id_list is not None:
            result['deptIdList'] = self.dept_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('staffIdList') is not None:
            self.staff_id_list = m.get('staffIdList')
        if m.get('deptIdList') is not None:
            self.dept_id_list = m.get('deptIdList')
        return self


class GetCrmRolePermissionResponseBodyPermissionsManagingScopeList(TeaModel):
    def __init__(
        self,
        type: str = None,
        manager: bool = None,
        ext: GetCrmRolePermissionResponseBodyPermissionsManagingScopeListExt = None,
    ):
        # 管理范围类型
        self.type = type
        # 是否是主管
        self.manager = manager
        # 扩展信息
        self.ext = ext

    def validate(self):
        if self.ext:
            self.ext.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.manager is not None:
            result['manager'] = self.manager
        if self.ext is not None:
            result['ext'] = self.ext.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('manager') is not None:
            self.manager = m.get('manager')
        if m.get('ext') is not None:
            temp_model = GetCrmRolePermissionResponseBodyPermissionsManagingScopeListExt()
            self.ext = temp_model.from_map(m['ext'])
        return self


class GetCrmRolePermissionResponseBodyPermissionsOperateScopes(TeaModel):
    def __init__(
        self,
        type: str = None,
        has_auth: bool = None,
    ):
        # 操作范围类型
        self.type = type
        # 是否有权限
        self.has_auth = has_auth

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.has_auth is not None:
            result['hasAuth'] = self.has_auth
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('hasAuth') is not None:
            self.has_auth = m.get('hasAuth')
        return self


class GetCrmRolePermissionResponseBodyPermissionsFieldScopes(TeaModel):
    def __init__(
        self,
        field_id: str = None,
        field_actions: List[str] = None,
    ):
        # 字段id
        self.field_id = field_id
        # 字段权限点
        self.field_actions = field_actions

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_id is not None:
            result['fieldId'] = self.field_id
        if self.field_actions is not None:
            result['fieldActions'] = self.field_actions
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldId') is not None:
            self.field_id = m.get('fieldId')
        if m.get('fieldActions') is not None:
            self.field_actions = m.get('fieldActions')
        return self


class GetCrmRolePermissionResponseBodyPermissions(TeaModel):
    def __init__(
        self,
        role_member_list: List[GetCrmRolePermissionResponseBodyPermissionsRoleMemberList] = None,
        managing_scope_list: List[GetCrmRolePermissionResponseBodyPermissionsManagingScopeList] = None,
        default_role: bool = None,
        resource_id: str = None,
        role_name: str = None,
        role_id: float = None,
        operate_scopes: List[GetCrmRolePermissionResponseBodyPermissionsOperateScopes] = None,
        field_scopes: List[GetCrmRolePermissionResponseBodyPermissionsFieldScopes] = None,
    ):
        # 权限组配置
        self.role_member_list = role_member_list
        # 权限组适用范围配置
        self.managing_scope_list = managing_scope_list
        # 是否是默认权限
        self.default_role = default_role
        # 资源id
        self.resource_id = resource_id
        # 权限组名称
        self.role_name = role_name
        # 权限组id
        self.role_id = role_id
        # 操作范围
        self.operate_scopes = operate_scopes
        # 字段权限
        self.field_scopes = field_scopes

    def validate(self):
        if self.role_member_list:
            for k in self.role_member_list:
                if k:
                    k.validate()
        if self.managing_scope_list:
            for k in self.managing_scope_list:
                if k:
                    k.validate()
        if self.operate_scopes:
            for k in self.operate_scopes:
                if k:
                    k.validate()
        if self.field_scopes:
            for k in self.field_scopes:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['roleMemberList'] = []
        if self.role_member_list is not None:
            for k in self.role_member_list:
                result['roleMemberList'].append(k.to_map() if k else None)
        result['managingScopeList'] = []
        if self.managing_scope_list is not None:
            for k in self.managing_scope_list:
                result['managingScopeList'].append(k.to_map() if k else None)
        if self.default_role is not None:
            result['defaultRole'] = self.default_role
        if self.resource_id is not None:
            result['resourceId'] = self.resource_id
        if self.role_name is not None:
            result['roleName'] = self.role_name
        if self.role_id is not None:
            result['roleId'] = self.role_id
        result['operateScopes'] = []
        if self.operate_scopes is not None:
            for k in self.operate_scopes:
                result['operateScopes'].append(k.to_map() if k else None)
        result['fieldScopes'] = []
        if self.field_scopes is not None:
            for k in self.field_scopes:
                result['fieldScopes'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.role_member_list = []
        if m.get('roleMemberList') is not None:
            for k in m.get('roleMemberList'):
                temp_model = GetCrmRolePermissionResponseBodyPermissionsRoleMemberList()
                self.role_member_list.append(temp_model.from_map(k))
        self.managing_scope_list = []
        if m.get('managingScopeList') is not None:
            for k in m.get('managingScopeList'):
                temp_model = GetCrmRolePermissionResponseBodyPermissionsManagingScopeList()
                self.managing_scope_list.append(temp_model.from_map(k))
        if m.get('defaultRole') is not None:
            self.default_role = m.get('defaultRole')
        if m.get('resourceId') is not None:
            self.resource_id = m.get('resourceId')
        if m.get('roleName') is not None:
            self.role_name = m.get('roleName')
        if m.get('roleId') is not None:
            self.role_id = m.get('roleId')
        self.operate_scopes = []
        if m.get('operateScopes') is not None:
            for k in m.get('operateScopes'):
                temp_model = GetCrmRolePermissionResponseBodyPermissionsOperateScopes()
                self.operate_scopes.append(temp_model.from_map(k))
        self.field_scopes = []
        if m.get('fieldScopes') is not None:
            for k in m.get('fieldScopes'):
                temp_model = GetCrmRolePermissionResponseBodyPermissionsFieldScopes()
                self.field_scopes.append(temp_model.from_map(k))
        return self


class GetCrmRolePermissionResponseBody(TeaModel):
    def __init__(
        self,
        permissions: List[GetCrmRolePermissionResponseBodyPermissions] = None,
    ):
        # CRM表单权限配置
        self.permissions = permissions

    def validate(self):
        if self.permissions:
            for k in self.permissions:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['permissions'] = []
        if self.permissions is not None:
            for k in self.permissions:
                result['permissions'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.permissions = []
        if m.get('permissions') is not None:
            for k in m.get('permissions'):
                temp_model = GetCrmRolePermissionResponseBodyPermissions()
                self.permissions.append(temp_model.from_map(k))
        return self


class GetCrmRolePermissionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetCrmRolePermissionResponseBody = None,
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
            temp_model = GetCrmRolePermissionResponseBody()
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
        account_id: str = None,
        ding_isv_org_id: int = None,
        ding_org_id: int = None,
        ding_token_grant_type: int = None,
        ding_suite_key: str = None,
    ):
        # 消息详情
        self.detail = detail
        # 服务窗授权的调用方标识，可空
        self.biz_id = biz_id
        # 服务窗帐号ID
        self.account_id = account_id
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
        if self.account_id is not None:
            result['accountId'] = self.account_id
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
        if m.get('accountId') is not None:
            self.account_id = m.get('accountId')
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
        user_infos: List[str] = None,
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
        # 已授权的字段
        self.user_infos = user_infos

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
        if self.user_infos is not None:
            result['userInfos'] = self.user_infos
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
        if m.get('userInfos') is not None:
            self.user_infos = m.get('userInfos')
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
        # 数据类型（私海个人客户：crm_customer_personal，私海企业客户：crm_customer，公海个人客户：open_customer_personal，公海企业客户：open_customer_org）
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


class UpdateRelationMetaFieldHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class UpdateRelationMetaFieldRequestFieldDTOListPropsOptions(TeaModel):
    def __init__(
        self,
        key: str = None,
        value: str = None,
    ):
        self.key = key
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.key is not None:
            result['key'] = self.key
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('key') is not None:
            self.key = m.get('key')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class UpdateRelationMetaFieldRequestFieldDTOListProps(TeaModel):
    def __init__(
        self,
        field_id: str = None,
        label: str = None,
        label_editable_freeze: bool = None,
        required: bool = None,
        required_editable_freeze: bool = None,
        not_print: str = None,
        content: str = None,
        format: str = None,
        options: List[UpdateRelationMetaFieldRequestFieldDTOListPropsOptions] = None,
        not_upper: str = None,
        unit: str = None,
        placeholder: str = None,
        biz_alias: str = None,
        duration: bool = None,
        choice: int = None,
        disabled: bool = None,
        align: str = None,
        invisible: bool = None,
        pay_enable: bool = None,
        link: str = None,
    ):
        self.field_id = field_id
        self.label = label
        self.label_editable_freeze = label_editable_freeze
        self.required = required
        self.required_editable_freeze = required_editable_freeze
        self.not_print = not_print
        self.content = content
        self.format = format
        self.options = options
        self.not_upper = not_upper
        self.unit = unit
        self.placeholder = placeholder
        self.biz_alias = biz_alias
        self.duration = duration
        self.choice = choice
        self.disabled = disabled
        self.align = align
        self.invisible = invisible
        self.pay_enable = pay_enable
        self.link = link

    def validate(self):
        if self.options:
            for k in self.options:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_id is not None:
            result['fieldId'] = self.field_id
        if self.label is not None:
            result['label'] = self.label
        if self.label_editable_freeze is not None:
            result['labelEditableFreeze'] = self.label_editable_freeze
        if self.required is not None:
            result['required'] = self.required
        if self.required_editable_freeze is not None:
            result['requiredEditableFreeze'] = self.required_editable_freeze
        if self.not_print is not None:
            result['notPrint'] = self.not_print
        if self.content is not None:
            result['content'] = self.content
        if self.format is not None:
            result['format'] = self.format
        result['options'] = []
        if self.options is not None:
            for k in self.options:
                result['options'].append(k.to_map() if k else None)
        if self.not_upper is not None:
            result['notUpper'] = self.not_upper
        if self.unit is not None:
            result['unit'] = self.unit
        if self.placeholder is not None:
            result['placeholder'] = self.placeholder
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.duration is not None:
            result['duration'] = self.duration
        if self.choice is not None:
            result['choice'] = self.choice
        if self.disabled is not None:
            result['disabled'] = self.disabled
        if self.align is not None:
            result['align'] = self.align
        if self.invisible is not None:
            result['invisible'] = self.invisible
        if self.pay_enable is not None:
            result['payEnable'] = self.pay_enable
        if self.link is not None:
            result['link'] = self.link
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldId') is not None:
            self.field_id = m.get('fieldId')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('labelEditableFreeze') is not None:
            self.label_editable_freeze = m.get('labelEditableFreeze')
        if m.get('required') is not None:
            self.required = m.get('required')
        if m.get('requiredEditableFreeze') is not None:
            self.required_editable_freeze = m.get('requiredEditableFreeze')
        if m.get('notPrint') is not None:
            self.not_print = m.get('notPrint')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('format') is not None:
            self.format = m.get('format')
        self.options = []
        if m.get('options') is not None:
            for k in m.get('options'):
                temp_model = UpdateRelationMetaFieldRequestFieldDTOListPropsOptions()
                self.options.append(temp_model.from_map(k))
        if m.get('notUpper') is not None:
            self.not_upper = m.get('notUpper')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('placeholder') is not None:
            self.placeholder = m.get('placeholder')
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('choice') is not None:
            self.choice = m.get('choice')
        if m.get('disabled') is not None:
            self.disabled = m.get('disabled')
        if m.get('align') is not None:
            self.align = m.get('align')
        if m.get('invisible') is not None:
            self.invisible = m.get('invisible')
        if m.get('payEnable') is not None:
            self.pay_enable = m.get('payEnable')
        if m.get('link') is not None:
            self.link = m.get('link')
        return self


class UpdateRelationMetaFieldRequestFieldDTOList(TeaModel):
    def __init__(
        self,
        component_name: str = None,
        props: UpdateRelationMetaFieldRequestFieldDTOListProps = None,
    ):
        self.component_name = component_name
        self.props = props

    def validate(self):
        if self.props:
            self.props.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.component_name is not None:
            result['componentName'] = self.component_name
        if self.props is not None:
            result['props'] = self.props.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('componentName') is not None:
            self.component_name = m.get('componentName')
        if m.get('props') is not None:
            temp_model = UpdateRelationMetaFieldRequestFieldDTOListProps()
            self.props = temp_model.from_map(m['props'])
        return self


class UpdateRelationMetaFieldRequest(TeaModel):
    def __init__(
        self,
        tenant: str = None,
        operator_user_id: str = None,
        relation_type: str = None,
        field_dtolist: List[UpdateRelationMetaFieldRequestFieldDTOList] = None,
    ):
        self.tenant = tenant
        self.operator_user_id = operator_user_id
        self.relation_type = relation_type
        self.field_dtolist = field_dtolist

    def validate(self):
        if self.field_dtolist:
            for k in self.field_dtolist:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.tenant is not None:
            result['tenant'] = self.tenant
        if self.operator_user_id is not None:
            result['operatorUserId'] = self.operator_user_id
        if self.relation_type is not None:
            result['relationType'] = self.relation_type
        result['fieldDTOList'] = []
        if self.field_dtolist is not None:
            for k in self.field_dtolist:
                result['fieldDTOList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('tenant') is not None:
            self.tenant = m.get('tenant')
        if m.get('operatorUserId') is not None:
            self.operator_user_id = m.get('operatorUserId')
        if m.get('relationType') is not None:
            self.relation_type = m.get('relationType')
        self.field_dtolist = []
        if m.get('fieldDTOList') is not None:
            for k in m.get('fieldDTOList'):
                temp_model = UpdateRelationMetaFieldRequestFieldDTOList()
                self.field_dtolist.append(temp_model.from_map(k))
        return self


class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSourceTarget(TeaModel):
    def __init__(
        self,
        app_type: int = None,
        app_uuid: str = None,
        biz_type: str = None,
        form_code: str = None,
    ):
        self.app_type = app_type
        self.app_uuid = app_uuid
        self.biz_type = biz_type
        self.form_code = form_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.app_uuid is not None:
            result['appUuid'] = self.app_uuid
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.form_code is not None:
            result['formCode'] = self.form_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('appUuid') is not None:
            self.app_uuid = m.get('appUuid')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('formCode') is not None:
            self.form_code = m.get('formCode')
        return self


class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSource(TeaModel):
    def __init__(
        self,
        target: UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSourceTarget = None,
        type: str = None,
    ):
        self.target = target
        self.type = type

    def validate(self):
        if self.target:
            self.target.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.target is not None:
            result['target'] = self.target.to_map()
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('target') is not None:
            temp_model = UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSourceTarget()
            self.target = temp_model.from_map(m['target'])
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsOptions(TeaModel):
    def __init__(
        self,
        key: str = None,
        value: str = None,
    ):
        self.key = key
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.key is not None:
            result['key'] = self.key
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('key') is not None:
            self.key = m.get('key')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsStatField(TeaModel):
    def __init__(
        self,
        field_id: str = None,
        label: str = None,
        unit: str = None,
        upper: bool = None,
    ):
        self.field_id = field_id
        self.label = label
        self.unit = unit
        self.upper = upper

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_id is not None:
            result['fieldId'] = self.field_id
        if self.label is not None:
            result['label'] = self.label
        if self.unit is not None:
            result['unit'] = self.unit
        if self.upper is not None:
            result['upper'] = self.upper
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldId') is not None:
            self.field_id = m.get('fieldId')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('upper') is not None:
            self.upper = m.get('upper')
        return self


class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps(TeaModel):
    def __init__(
        self,
        align: str = None,
        biz_alias: str = None,
        choice: int = None,
        content: str = None,
        disabled: bool = None,
        duration: bool = None,
        format: str = None,
        formula: str = None,
        field_id: str = None,
        invisible: bool = None,
        label: str = None,
        link: str = None,
        not_upper: str = None,
        options: List[UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsOptions] = None,
        pay_enable: bool = None,
        placeholder: str = None,
        required: bool = None,
        stat_field: List[UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsStatField] = None,
        unit: str = None,
        vertical_print: bool = None,
    ):
        self.align = align
        self.biz_alias = biz_alias
        self.choice = choice
        self.content = content
        self.disabled = disabled
        self.duration = duration
        self.format = format
        self.formula = formula
        self.field_id = field_id
        self.invisible = invisible
        self.label = label
        self.link = link
        self.not_upper = not_upper
        self.options = options
        self.pay_enable = pay_enable
        self.placeholder = placeholder
        self.required = required
        self.stat_field = stat_field
        self.unit = unit
        self.vertical_print = vertical_print

    def validate(self):
        if self.options:
            for k in self.options:
                if k:
                    k.validate()
        if self.stat_field:
            for k in self.stat_field:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.align is not None:
            result['align'] = self.align
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.choice is not None:
            result['choice'] = self.choice
        if self.content is not None:
            result['content'] = self.content
        if self.disabled is not None:
            result['disabled'] = self.disabled
        if self.duration is not None:
            result['duration'] = self.duration
        if self.format is not None:
            result['format'] = self.format
        if self.formula is not None:
            result['formula'] = self.formula
        if self.field_id is not None:
            result['fieldId'] = self.field_id
        if self.invisible is not None:
            result['invisible'] = self.invisible
        if self.label is not None:
            result['label'] = self.label
        if self.link is not None:
            result['link'] = self.link
        if self.not_upper is not None:
            result['notUpper'] = self.not_upper
        result['options'] = []
        if self.options is not None:
            for k in self.options:
                result['options'].append(k.to_map() if k else None)
        if self.pay_enable is not None:
            result['payEnable'] = self.pay_enable
        if self.placeholder is not None:
            result['placeholder'] = self.placeholder
        if self.required is not None:
            result['required'] = self.required
        result['statField'] = []
        if self.stat_field is not None:
            for k in self.stat_field:
                result['statField'].append(k.to_map() if k else None)
        if self.unit is not None:
            result['unit'] = self.unit
        if self.vertical_print is not None:
            result['verticalPrint'] = self.vertical_print
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('align') is not None:
            self.align = m.get('align')
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('choice') is not None:
            self.choice = m.get('choice')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('disabled') is not None:
            self.disabled = m.get('disabled')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('format') is not None:
            self.format = m.get('format')
        if m.get('formula') is not None:
            self.formula = m.get('formula')
        if m.get('fieldId') is not None:
            self.field_id = m.get('fieldId')
        if m.get('invisible') is not None:
            self.invisible = m.get('invisible')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('link') is not None:
            self.link = m.get('link')
        if m.get('notUpper') is not None:
            self.not_upper = m.get('notUpper')
        self.options = []
        if m.get('options') is not None:
            for k in m.get('options'):
                temp_model = UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsOptions()
                self.options.append(temp_model.from_map(k))
        if m.get('payEnable') is not None:
            self.pay_enable = m.get('payEnable')
        if m.get('placeholder') is not None:
            self.placeholder = m.get('placeholder')
        if m.get('required') is not None:
            self.required = m.get('required')
        self.stat_field = []
        if m.get('statField') is not None:
            for k in m.get('statField'):
                temp_model = UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelatePropsStatField()
                self.stat_field.append(temp_model.from_map(k))
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('verticalPrint') is not None:
            self.vertical_print = m.get('verticalPrint')
        return self


class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFields(TeaModel):
    def __init__(
        self,
        component_name: str = None,
        relate_props: UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps = None,
    ):
        self.component_name = component_name
        self.relate_props = relate_props

    def validate(self):
        if self.relate_props:
            self.relate_props.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.component_name is not None:
            result['componentName'] = self.component_name
        if self.relate_props is not None:
            result['relateProps'] = self.relate_props.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('componentName') is not None:
            self.component_name = m.get('componentName')
        if m.get('relateProps') is not None:
            temp_model = UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFieldsRelateProps()
            self.relate_props = temp_model.from_map(m['relateProps'])
        return self


class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsOptions(TeaModel):
    def __init__(
        self,
        key: str = None,
        value: str = None,
    ):
        self.key = key
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.key is not None:
            result['key'] = self.key
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('key') is not None:
            self.key = m.get('key')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsStatField(TeaModel):
    def __init__(
        self,
        field_id: str = None,
        label: str = None,
        unit: str = None,
        upper: bool = None,
    ):
        self.field_id = field_id
        self.label = label
        self.unit = unit
        self.upper = upper

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_id is not None:
            result['fieldId'] = self.field_id
        if self.label is not None:
            result['label'] = self.label
        if self.unit is not None:
            result['unit'] = self.unit
        if self.upper is not None:
            result['upper'] = self.upper
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldId') is not None:
            self.field_id = m.get('fieldId')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('upper') is not None:
            self.upper = m.get('upper')
        return self


class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps(TeaModel):
    def __init__(
        self,
        align: str = None,
        biz_alias: str = None,
        choice: int = None,
        content: str = None,
        data_source: UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSource = None,
        disabled: bool = None,
        duration: bool = None,
        fields: List[UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFields] = None,
        format: str = None,
        formula: str = None,
        field_id: str = None,
        invisible: bool = None,
        label: str = None,
        label_editable_freeze: bool = None,
        link: str = None,
        not_print: str = None,
        not_upper: str = None,
        options: List[UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsOptions] = None,
        pay_enable: bool = None,
        placeholder: str = None,
        required: bool = None,
        required_editable_freeze: bool = None,
        stat_field: List[UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsStatField] = None,
        unit: str = None,
        vertical_print: bool = None,
    ):
        self.align = align
        self.biz_alias = biz_alias
        self.choice = choice
        self.content = content
        self.data_source = data_source
        self.disabled = disabled
        self.duration = duration
        self.fields = fields
        self.format = format
        self.formula = formula
        self.field_id = field_id
        self.invisible = invisible
        self.label = label
        self.label_editable_freeze = label_editable_freeze
        self.link = link
        self.not_print = not_print
        self.not_upper = not_upper
        self.options = options
        self.pay_enable = pay_enable
        self.placeholder = placeholder
        self.required = required
        self.required_editable_freeze = required_editable_freeze
        self.stat_field = stat_field
        self.unit = unit
        self.vertical_print = vertical_print

    def validate(self):
        if self.data_source:
            self.data_source.validate()
        if self.fields:
            for k in self.fields:
                if k:
                    k.validate()
        if self.options:
            for k in self.options:
                if k:
                    k.validate()
        if self.stat_field:
            for k in self.stat_field:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.align is not None:
            result['align'] = self.align
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.choice is not None:
            result['choice'] = self.choice
        if self.content is not None:
            result['content'] = self.content
        if self.data_source is not None:
            result['dataSource'] = self.data_source.to_map()
        if self.disabled is not None:
            result['disabled'] = self.disabled
        if self.duration is not None:
            result['duration'] = self.duration
        result['fields'] = []
        if self.fields is not None:
            for k in self.fields:
                result['fields'].append(k.to_map() if k else None)
        if self.format is not None:
            result['format'] = self.format
        if self.formula is not None:
            result['formula'] = self.formula
        if self.field_id is not None:
            result['fieldId'] = self.field_id
        if self.invisible is not None:
            result['invisible'] = self.invisible
        if self.label is not None:
            result['label'] = self.label
        if self.label_editable_freeze is not None:
            result['labelEditableFreeze'] = self.label_editable_freeze
        if self.link is not None:
            result['link'] = self.link
        if self.not_print is not None:
            result['notPrint'] = self.not_print
        if self.not_upper is not None:
            result['notUpper'] = self.not_upper
        result['options'] = []
        if self.options is not None:
            for k in self.options:
                result['options'].append(k.to_map() if k else None)
        if self.pay_enable is not None:
            result['payEnable'] = self.pay_enable
        if self.placeholder is not None:
            result['placeholder'] = self.placeholder
        if self.required is not None:
            result['required'] = self.required
        if self.required_editable_freeze is not None:
            result['requiredEditableFreeze'] = self.required_editable_freeze
        result['statField'] = []
        if self.stat_field is not None:
            for k in self.stat_field:
                result['statField'].append(k.to_map() if k else None)
        if self.unit is not None:
            result['unit'] = self.unit
        if self.vertical_print is not None:
            result['verticalPrint'] = self.vertical_print
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('align') is not None:
            self.align = m.get('align')
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('choice') is not None:
            self.choice = m.get('choice')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('dataSource') is not None:
            temp_model = UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsDataSource()
            self.data_source = temp_model.from_map(m['dataSource'])
        if m.get('disabled') is not None:
            self.disabled = m.get('disabled')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        self.fields = []
        if m.get('fields') is not None:
            for k in m.get('fields'):
                temp_model = UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsFields()
                self.fields.append(temp_model.from_map(k))
        if m.get('format') is not None:
            self.format = m.get('format')
        if m.get('formula') is not None:
            self.formula = m.get('formula')
        if m.get('fieldId') is not None:
            self.field_id = m.get('fieldId')
        if m.get('invisible') is not None:
            self.invisible = m.get('invisible')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('labelEditableFreeze') is not None:
            self.label_editable_freeze = m.get('labelEditableFreeze')
        if m.get('link') is not None:
            self.link = m.get('link')
        if m.get('notPrint') is not None:
            self.not_print = m.get('notPrint')
        if m.get('notUpper') is not None:
            self.not_upper = m.get('notUpper')
        self.options = []
        if m.get('options') is not None:
            for k in m.get('options'):
                temp_model = UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsOptions()
                self.options.append(temp_model.from_map(k))
        if m.get('payEnable') is not None:
            self.pay_enable = m.get('payEnable')
        if m.get('placeholder') is not None:
            self.placeholder = m.get('placeholder')
        if m.get('required') is not None:
            self.required = m.get('required')
        if m.get('requiredEditableFreeze') is not None:
            self.required_editable_freeze = m.get('requiredEditableFreeze')
        self.stat_field = []
        if m.get('statField') is not None:
            for k in m.get('statField'):
                temp_model = UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenPropsStatField()
                self.stat_field.append(temp_model.from_map(k))
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('verticalPrint') is not None:
            self.vertical_print = m.get('verticalPrint')
        return self


class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildren(TeaModel):
    def __init__(
        self,
        component_name: str = None,
        props: UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps = None,
    ):
        self.component_name = component_name
        self.props = props

    def validate(self):
        if self.props:
            self.props.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.component_name is not None:
            result['componentName'] = self.component_name
        if self.props is not None:
            result['props'] = self.props.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('componentName') is not None:
            self.component_name = m.get('componentName')
        if m.get('props') is not None:
            temp_model = UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildrenProps()
            self.props = temp_model.from_map(m['props'])
        return self


class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSourceTarget(TeaModel):
    def __init__(
        self,
        app_type: int = None,
        app_uuid: str = None,
        biz_type: str = None,
        form_code: str = None,
    ):
        self.app_type = app_type
        self.app_uuid = app_uuid
        self.biz_type = biz_type
        self.form_code = form_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.app_uuid is not None:
            result['appUuid'] = self.app_uuid
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.form_code is not None:
            result['formCode'] = self.form_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('appUuid') is not None:
            self.app_uuid = m.get('appUuid')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('formCode') is not None:
            self.form_code = m.get('formCode')
        return self


class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSource(TeaModel):
    def __init__(
        self,
        target: UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSourceTarget = None,
        type: str = None,
    ):
        self.target = target
        self.type = type

    def validate(self):
        if self.target:
            self.target.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.target is not None:
            result['target'] = self.target.to_map()
        if self.type is not None:
            result['type'] = self.type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('target') is not None:
            temp_model = UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSourceTarget()
            self.target = temp_model.from_map(m['target'])
        if m.get('type') is not None:
            self.type = m.get('type')
        return self


class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsOptions(TeaModel):
    def __init__(
        self,
        key: str = None,
        value: str = None,
    ):
        self.key = key
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.key is not None:
            result['key'] = self.key
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('key') is not None:
            self.key = m.get('key')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsStatField(TeaModel):
    def __init__(
        self,
        field_id: str = None,
        label: str = None,
        unit: str = None,
        upper: bool = None,
    ):
        self.field_id = field_id
        self.label = label
        self.unit = unit
        self.upper = upper

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_id is not None:
            result['fieldId'] = self.field_id
        if self.label is not None:
            result['label'] = self.label
        if self.unit is not None:
            result['unit'] = self.unit
        if self.upper is not None:
            result['upper'] = self.upper
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldId') is not None:
            self.field_id = m.get('fieldId')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('upper') is not None:
            self.upper = m.get('upper')
        return self


class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps(TeaModel):
    def __init__(
        self,
        align: str = None,
        biz_alias: str = None,
        choice: int = None,
        content: str = None,
        disabled: bool = None,
        duration: str = None,
        format: str = None,
        formula: str = None,
        field_id: str = None,
        invisible: bool = None,
        label: str = None,
        link: str = None,
        not_upper: str = None,
        options: List[UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsOptions] = None,
        pay_enable: bool = None,
        placeholder: str = None,
        required: bool = None,
        stat_field: List[UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsStatField] = None,
        unit: str = None,
        vertical_print: bool = None,
    ):
        self.align = align
        self.biz_alias = biz_alias
        self.choice = choice
        self.content = content
        self.disabled = disabled
        self.duration = duration
        self.format = format
        self.formula = formula
        self.field_id = field_id
        self.invisible = invisible
        self.label = label
        self.link = link
        self.not_upper = not_upper
        self.options = options
        self.pay_enable = pay_enable
        self.placeholder = placeholder
        self.required = required
        self.stat_field = stat_field
        self.unit = unit
        self.vertical_print = vertical_print

    def validate(self):
        if self.options:
            for k in self.options:
                if k:
                    k.validate()
        if self.stat_field:
            for k in self.stat_field:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.align is not None:
            result['align'] = self.align
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.choice is not None:
            result['choice'] = self.choice
        if self.content is not None:
            result['content'] = self.content
        if self.disabled is not None:
            result['disabled'] = self.disabled
        if self.duration is not None:
            result['duration'] = self.duration
        if self.format is not None:
            result['format'] = self.format
        if self.formula is not None:
            result['formula'] = self.formula
        if self.field_id is not None:
            result['fieldId'] = self.field_id
        if self.invisible is not None:
            result['invisible'] = self.invisible
        if self.label is not None:
            result['label'] = self.label
        if self.link is not None:
            result['link'] = self.link
        if self.not_upper is not None:
            result['notUpper'] = self.not_upper
        result['options'] = []
        if self.options is not None:
            for k in self.options:
                result['options'].append(k.to_map() if k else None)
        if self.pay_enable is not None:
            result['payEnable'] = self.pay_enable
        if self.placeholder is not None:
            result['placeholder'] = self.placeholder
        if self.required is not None:
            result['required'] = self.required
        result['statField'] = []
        if self.stat_field is not None:
            for k in self.stat_field:
                result['statField'].append(k.to_map() if k else None)
        if self.unit is not None:
            result['unit'] = self.unit
        if self.vertical_print is not None:
            result['verticalPrint'] = self.vertical_print
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('align') is not None:
            self.align = m.get('align')
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('choice') is not None:
            self.choice = m.get('choice')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('disabled') is not None:
            self.disabled = m.get('disabled')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('format') is not None:
            self.format = m.get('format')
        if m.get('formula') is not None:
            self.formula = m.get('formula')
        if m.get('fieldId') is not None:
            self.field_id = m.get('fieldId')
        if m.get('invisible') is not None:
            self.invisible = m.get('invisible')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('link') is not None:
            self.link = m.get('link')
        if m.get('notUpper') is not None:
            self.not_upper = m.get('notUpper')
        self.options = []
        if m.get('options') is not None:
            for k in m.get('options'):
                temp_model = UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsOptions()
                self.options.append(temp_model.from_map(k))
        if m.get('payEnable') is not None:
            self.pay_enable = m.get('payEnable')
        if m.get('placeholder') is not None:
            self.placeholder = m.get('placeholder')
        if m.get('required') is not None:
            self.required = m.get('required')
        self.stat_field = []
        if m.get('statField') is not None:
            for k in m.get('statField'):
                temp_model = UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelatePropsStatField()
                self.stat_field.append(temp_model.from_map(k))
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('verticalPrint') is not None:
            self.vertical_print = m.get('verticalPrint')
        return self


class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFields(TeaModel):
    def __init__(
        self,
        component_name: str = None,
        relate_props: UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps = None,
    ):
        self.component_name = component_name
        self.relate_props = relate_props

    def validate(self):
        if self.relate_props:
            self.relate_props.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.component_name is not None:
            result['componentName'] = self.component_name
        if self.relate_props is not None:
            result['relateProps'] = self.relate_props.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('componentName') is not None:
            self.component_name = m.get('componentName')
        if m.get('relateProps') is not None:
            temp_model = UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFieldsRelateProps()
            self.relate_props = temp_model.from_map(m['relateProps'])
        return self


class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsOptions(TeaModel):
    def __init__(
        self,
        key: str = None,
        value: str = None,
    ):
        self.key = key
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.key is not None:
            result['key'] = self.key
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('key') is not None:
            self.key = m.get('key')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsStatField(TeaModel):
    def __init__(
        self,
        field_id: str = None,
        label: str = None,
        unit: str = None,
        upper: bool = None,
    ):
        self.field_id = field_id
        self.label = label
        self.unit = unit
        self.upper = upper

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_id is not None:
            result['fieldId'] = self.field_id
        if self.label is not None:
            result['label'] = self.label
        if self.unit is not None:
            result['unit'] = self.unit
        if self.upper is not None:
            result['upper'] = self.upper
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldId') is not None:
            self.field_id = m.get('fieldId')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('upper') is not None:
            self.upper = m.get('upper')
        return self


class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps(TeaModel):
    def __init__(
        self,
        align: str = None,
        biz_alias: str = None,
        choice: int = None,
        content: str = None,
        data_source: UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSource = None,
        disabled: bool = None,
        duration: bool = None,
        fields: List[UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFields] = None,
        format: str = None,
        formula: str = None,
        field_id: str = None,
        invisible: bool = None,
        label: str = None,
        label_editable_freeze: bool = None,
        link: str = None,
        not_print: str = None,
        not_upper: str = None,
        options: List[UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsOptions] = None,
        pay_enable: bool = None,
        placeholder: str = None,
        required: bool = None,
        required_editable_freeze: bool = None,
        stat_field: List[UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsStatField] = None,
        unit: str = None,
        vertical_print: bool = None,
    ):
        self.align = align
        self.biz_alias = biz_alias
        self.choice = choice
        self.content = content
        self.data_source = data_source
        self.disabled = disabled
        self.duration = duration
        self.fields = fields
        self.format = format
        self.formula = formula
        self.field_id = field_id
        self.invisible = invisible
        self.label = label
        self.label_editable_freeze = label_editable_freeze
        self.link = link
        self.not_print = not_print
        self.not_upper = not_upper
        self.options = options
        self.pay_enable = pay_enable
        self.placeholder = placeholder
        self.required = required
        self.required_editable_freeze = required_editable_freeze
        self.stat_field = stat_field
        self.unit = unit
        self.vertical_print = vertical_print

    def validate(self):
        if self.data_source:
            self.data_source.validate()
        if self.fields:
            for k in self.fields:
                if k:
                    k.validate()
        if self.options:
            for k in self.options:
                if k:
                    k.validate()
        if self.stat_field:
            for k in self.stat_field:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.align is not None:
            result['align'] = self.align
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.choice is not None:
            result['choice'] = self.choice
        if self.content is not None:
            result['content'] = self.content
        if self.data_source is not None:
            result['dataSource'] = self.data_source.to_map()
        if self.disabled is not None:
            result['disabled'] = self.disabled
        if self.duration is not None:
            result['duration'] = self.duration
        result['fields'] = []
        if self.fields is not None:
            for k in self.fields:
                result['fields'].append(k.to_map() if k else None)
        if self.format is not None:
            result['format'] = self.format
        if self.formula is not None:
            result['formula'] = self.formula
        if self.field_id is not None:
            result['fieldId'] = self.field_id
        if self.invisible is not None:
            result['invisible'] = self.invisible
        if self.label is not None:
            result['label'] = self.label
        if self.label_editable_freeze is not None:
            result['labelEditableFreeze'] = self.label_editable_freeze
        if self.link is not None:
            result['link'] = self.link
        if self.not_print is not None:
            result['notPrint'] = self.not_print
        if self.not_upper is not None:
            result['notUpper'] = self.not_upper
        result['options'] = []
        if self.options is not None:
            for k in self.options:
                result['options'].append(k.to_map() if k else None)
        if self.pay_enable is not None:
            result['payEnable'] = self.pay_enable
        if self.placeholder is not None:
            result['placeholder'] = self.placeholder
        if self.required is not None:
            result['required'] = self.required
        if self.required_editable_freeze is not None:
            result['requiredEditableFreeze'] = self.required_editable_freeze
        result['statField'] = []
        if self.stat_field is not None:
            for k in self.stat_field:
                result['statField'].append(k.to_map() if k else None)
        if self.unit is not None:
            result['unit'] = self.unit
        if self.vertical_print is not None:
            result['verticalPrint'] = self.vertical_print
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('align') is not None:
            self.align = m.get('align')
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('choice') is not None:
            self.choice = m.get('choice')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('dataSource') is not None:
            temp_model = UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsDataSource()
            self.data_source = temp_model.from_map(m['dataSource'])
        if m.get('disabled') is not None:
            self.disabled = m.get('disabled')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        self.fields = []
        if m.get('fields') is not None:
            for k in m.get('fields'):
                temp_model = UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsFields()
                self.fields.append(temp_model.from_map(k))
        if m.get('format') is not None:
            self.format = m.get('format')
        if m.get('formula') is not None:
            self.formula = m.get('formula')
        if m.get('fieldId') is not None:
            self.field_id = m.get('fieldId')
        if m.get('invisible') is not None:
            self.invisible = m.get('invisible')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('labelEditableFreeze') is not None:
            self.label_editable_freeze = m.get('labelEditableFreeze')
        if m.get('link') is not None:
            self.link = m.get('link')
        if m.get('notPrint') is not None:
            self.not_print = m.get('notPrint')
        if m.get('notUpper') is not None:
            self.not_upper = m.get('notUpper')
        self.options = []
        if m.get('options') is not None:
            for k in m.get('options'):
                temp_model = UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsOptions()
                self.options.append(temp_model.from_map(k))
        if m.get('payEnable') is not None:
            self.pay_enable = m.get('payEnable')
        if m.get('placeholder') is not None:
            self.placeholder = m.get('placeholder')
        if m.get('required') is not None:
            self.required = m.get('required')
        if m.get('requiredEditableFreeze') is not None:
            self.required_editable_freeze = m.get('requiredEditableFreeze')
        self.stat_field = []
        if m.get('statField') is not None:
            for k in m.get('statField'):
                temp_model = UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsPropsStatField()
                self.stat_field.append(temp_model.from_map(k))
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('verticalPrint') is not None:
            self.vertical_print = m.get('verticalPrint')
        return self


class UpdateRelationMetaFieldResponseBodyRelationMetaDTOItems(TeaModel):
    def __init__(
        self,
        children: List[UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildren] = None,
        component_name: str = None,
        props: List[UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps] = None,
    ):
        self.children = children
        self.component_name = component_name
        self.props = props

    def validate(self):
        if self.children:
            for k in self.children:
                if k:
                    k.validate()
        if self.props:
            for k in self.props:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['children'] = []
        if self.children is not None:
            for k in self.children:
                result['children'].append(k.to_map() if k else None)
        if self.component_name is not None:
            result['componentName'] = self.component_name
        result['props'] = []
        if self.props is not None:
            for k in self.props:
                result['props'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.children = []
        if m.get('children') is not None:
            for k in m.get('children'):
                temp_model = UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsChildren()
                self.children.append(temp_model.from_map(k))
        if m.get('componentName') is not None:
            self.component_name = m.get('componentName')
        self.props = []
        if m.get('props') is not None:
            for k in m.get('props'):
                temp_model = UpdateRelationMetaFieldResponseBodyRelationMetaDTOItemsProps()
                self.props.append(temp_model.from_map(k))
        return self


class UpdateRelationMetaFieldResponseBodyRelationMetaDTO(TeaModel):
    def __init__(
        self,
        desc: str = None,
        items: List[UpdateRelationMetaFieldResponseBodyRelationMetaDTOItems] = None,
        name: str = None,
        relation_type: str = None,
    ):
        self.desc = desc
        self.items = items
        self.name = name
        self.relation_type = relation_type

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
        if self.desc is not None:
            result['desc'] = self.desc
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        if self.name is not None:
            result['name'] = self.name
        if self.relation_type is not None:
            result['relationType'] = self.relation_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('desc') is not None:
            self.desc = m.get('desc')
        self.items = []
        if m.get('items') is not None:
            for k in m.get('items'):
                temp_model = UpdateRelationMetaFieldResponseBodyRelationMetaDTOItems()
                self.items.append(temp_model.from_map(k))
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('relationType') is not None:
            self.relation_type = m.get('relationType')
        return self


class UpdateRelationMetaFieldResponseBody(TeaModel):
    def __init__(
        self,
        relation_meta_dto: UpdateRelationMetaFieldResponseBodyRelationMetaDTO = None,
    ):
        self.relation_meta_dto = relation_meta_dto

    def validate(self):
        if self.relation_meta_dto:
            self.relation_meta_dto.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.relation_meta_dto is not None:
            result['relationMetaDTO'] = self.relation_meta_dto.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('relationMetaDTO') is not None:
            temp_model = UpdateRelationMetaFieldResponseBodyRelationMetaDTO()
            self.relation_meta_dto = temp_model.from_map(m['relationMetaDTO'])
        return self


class UpdateRelationMetaFieldResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateRelationMetaFieldResponseBody = None,
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
            temp_model = UpdateRelationMetaFieldResponseBody()
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
        union_id: str = None,
        message_body: SendOfficialAccountOTOMessageRequestDetailMessageBody = None,
    ):
        # 消息类型
        self.msg_type = msg_type
        # 请求唯一 ID
        self.uuid = uuid
        # 消息接收人id
        self.user_id = user_id
        # 消息接收人unionId
        self.union_id = union_id
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
        if self.union_id is not None:
            result['unionId'] = self.union_id
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
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
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
        account_id: str = None,
    ):
        # 消息详情
        self.detail = detail
        # API调用标识，可选参数
        self.biz_id = biz_id
        self.ding_token_grant_type = ding_token_grant_type
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_org_id = ding_org_id
        self.ding_suite_key = ding_suite_key
        # 服务窗帐号ID
        self.account_id = account_id

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
        if self.account_id is not None:
            result['accountId'] = self.account_id
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
        if m.get('accountId') is not None:
            self.account_id = m.get('accountId')
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


class GetOfficialAccountOTOMessageResultHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetOfficialAccountOTOMessageResultRequest(TeaModel):
    def __init__(
        self,
        open_push_id: str = None,
        account_id: str = None,
    ):
        # 推送ID
        self.open_push_id = open_push_id
        self.account_id = account_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_push_id is not None:
            result['openPushId'] = self.open_push_id
        if self.account_id is not None:
            result['accountId'] = self.account_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openPushId') is not None:
            self.open_push_id = m.get('openPushId')
        if m.get('accountId') is not None:
            self.account_id = m.get('accountId')
        return self


class GetOfficialAccountOTOMessageResultResponseBodyResult(TeaModel):
    def __init__(
        self,
        status: int = None,
        read_user_id_list: List[str] = None,
    ):
        # 执行状态： 0：未开始  1：处理中  2：处理完毕
        self.status = status
        # 已读消息的userid列表
        self.read_user_id_list = read_user_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.status is not None:
            result['status'] = self.status
        if self.read_user_id_list is not None:
            result['readUserIdList'] = self.read_user_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('readUserIdList') is not None:
            self.read_user_id_list = m.get('readUserIdList')
        return self


class GetOfficialAccountOTOMessageResultResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: GetOfficialAccountOTOMessageResultResponseBodyResult = None,
    ):
        # Id of the request
        self.request_id = request_id
        # 查询结果
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
            temp_model = GetOfficialAccountOTOMessageResultResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class GetOfficialAccountOTOMessageResultResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: GetOfficialAccountOTOMessageResultResponseBody = None,
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
            temp_model = GetOfficialAccountOTOMessageResultResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DescribeRelationMetaHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class DescribeRelationMetaRequest(TeaModel):
    def __init__(
        self,
        tenant: str = None,
        operator_user_id: str = None,
        relation_types: List[str] = None,
    ):
        self.tenant = tenant
        self.operator_user_id = operator_user_id
        self.relation_types = relation_types

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.tenant is not None:
            result['tenant'] = self.tenant
        if self.operator_user_id is not None:
            result['operatorUserId'] = self.operator_user_id
        if self.relation_types is not None:
            result['relationTypes'] = self.relation_types
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('tenant') is not None:
            self.tenant = m.get('tenant')
        if m.get('operatorUserId') is not None:
            self.operator_user_id = m.get('operatorUserId')
        if m.get('relationTypes') is not None:
            self.relation_types = m.get('relationTypes')
        return self


class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions(TeaModel):
    def __init__(
        self,
        key: str = None,
        value: str = None,
    ):
        # 选项数据主键
        self.key = key
        # 选项显示内容
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.key is not None:
            result['key'] = self.key
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('key') is not None:
            self.key = m.get('key')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions(TeaModel):
    def __init__(
        self,
        key: str = None,
        value: str = None,
    ):
        # 选项数据主键
        self.key = key
        # 选项显示内容
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.key is not None:
            result['key'] = self.key
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('key') is not None:
            self.key = m.get('key')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField(TeaModel):
    def __init__(
        self,
        field_id: str = None,
        label: str = None,
        upper: bool = None,
        unit: str = None,
    ):
        self.field_id = field_id
        self.label = label
        self.upper = upper
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_id is not None:
            result['fieldId'] = self.field_id
        if self.label is not None:
            result['label'] = self.label
        if self.upper is not None:
            result['upper'] = self.upper
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldId') is not None:
            self.field_id = m.get('fieldId')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('upper') is not None:
            self.upper = m.get('upper')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps(TeaModel):
    def __init__(
        self,
        field_id: str = None,
        label: str = None,
        required: bool = None,
        content: str = None,
        format: str = None,
        options: List[DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions] = None,
        not_upper: str = None,
        unit: str = None,
        placeholder: str = None,
        biz_alias: str = None,
        duration: str = None,
        choice: int = None,
        disabled: bool = None,
        align: str = None,
        invisible: bool = None,
        pay_enable: bool = None,
        stat_field: List[DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField] = None,
        link: str = None,
        vertical_print: bool = None,
        formula: str = None,
    ):
        # 字段id
        self.field_id = field_id
        # 字段标题
        self.label = label
        # 字段是否必填
        self.required = required
        # 说明文字内容
        self.content = content
        # 时间格式
        self.format = format
        # 选项内容列表
        self.options = options
        # 是否需要大写 默认是需要
        self.not_upper = not_upper
        # 数字组件/日期区间组件单位属性
        self.unit = unit
        # 界面空值提示占位符 前后端统一用placeholder
        self.placeholder = placeholder
        # 字段别名
        self.biz_alias = biz_alias
        # 是否自动计算时长
        self.duration = duration
        # 内部联系人choice
        self.choice = choice
        # 是否可编辑
        self.disabled = disabled
        # textnote的样式
        self.align = align
        # 隐藏字段
        self.invisible = invisible
        # 是否有支付属性
        self.pay_enable = pay_enable
        # 需要计算总和的明细组件
        self.stat_field = stat_field
        # 说明文案的链接地址
        self.link = link
        # 明细打印排版方式
        self.vertical_print = vertical_print
        # 公式
        self.formula = formula

    def validate(self):
        if self.options:
            for k in self.options:
                if k:
                    k.validate()
        if self.stat_field:
            for k in self.stat_field:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_id is not None:
            result['fieldId'] = self.field_id
        if self.label is not None:
            result['label'] = self.label
        if self.required is not None:
            result['required'] = self.required
        if self.content is not None:
            result['content'] = self.content
        if self.format is not None:
            result['format'] = self.format
        result['options'] = []
        if self.options is not None:
            for k in self.options:
                result['options'].append(k.to_map() if k else None)
        if self.not_upper is not None:
            result['notUpper'] = self.not_upper
        if self.unit is not None:
            result['unit'] = self.unit
        if self.placeholder is not None:
            result['placeholder'] = self.placeholder
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.duration is not None:
            result['duration'] = self.duration
        if self.choice is not None:
            result['choice'] = self.choice
        if self.disabled is not None:
            result['disabled'] = self.disabled
        if self.align is not None:
            result['align'] = self.align
        if self.invisible is not None:
            result['invisible'] = self.invisible
        if self.pay_enable is not None:
            result['payEnable'] = self.pay_enable
        result['statField'] = []
        if self.stat_field is not None:
            for k in self.stat_field:
                result['statField'].append(k.to_map() if k else None)
        if self.link is not None:
            result['link'] = self.link
        if self.vertical_print is not None:
            result['verticalPrint'] = self.vertical_print
        if self.formula is not None:
            result['formula'] = self.formula
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldId') is not None:
            self.field_id = m.get('fieldId')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('required') is not None:
            self.required = m.get('required')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('format') is not None:
            self.format = m.get('format')
        self.options = []
        if m.get('options') is not None:
            for k in m.get('options'):
                temp_model = DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsOptions()
                self.options.append(temp_model.from_map(k))
        if m.get('notUpper') is not None:
            self.not_upper = m.get('notUpper')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('placeholder') is not None:
            self.placeholder = m.get('placeholder')
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('choice') is not None:
            self.choice = m.get('choice')
        if m.get('disabled') is not None:
            self.disabled = m.get('disabled')
        if m.get('align') is not None:
            self.align = m.get('align')
        if m.get('invisible') is not None:
            self.invisible = m.get('invisible')
        if m.get('payEnable') is not None:
            self.pay_enable = m.get('payEnable')
        self.stat_field = []
        if m.get('statField') is not None:
            for k in m.get('statField'):
                temp_model = DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelatePropsStatField()
                self.stat_field.append(temp_model.from_map(k))
        if m.get('link') is not None:
            self.link = m.get('link')
        if m.get('verticalPrint') is not None:
            self.vertical_print = m.get('verticalPrint')
        if m.get('formula') is not None:
            self.formula = m.get('formula')
        return self


class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields(TeaModel):
    def __init__(
        self,
        component_name: str = None,
        relate_props: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps = None,
    ):
        # 字段类型
        self.component_name = component_name
        # 字段属性
        self.relate_props = relate_props

    def validate(self):
        if self.relate_props:
            self.relate_props.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.component_name is not None:
            result['componentName'] = self.component_name
        if self.relate_props is not None:
            result['relateProps'] = self.relate_props.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('componentName') is not None:
            self.component_name = m.get('componentName')
        if m.get('relateProps') is not None:
            temp_model = DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFieldsRelateProps()
            self.relate_props = temp_model.from_map(m['relateProps'])
        return self


class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget(TeaModel):
    def __init__(
        self,
        app_uuid: str = None,
        app_type: int = None,
        biz_type: str = None,
        form_code: str = None,
    ):
        # 应用搭建id
        self.app_uuid = app_uuid
        # 应用类型
        self.app_type = app_type
        # 表单业务标识
        self.biz_type = biz_type
        # 被关联表单的formCode
        self.form_code = form_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_uuid is not None:
            result['appUuid'] = self.app_uuid
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.form_code is not None:
            result['formCode'] = self.form_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUuid') is not None:
            self.app_uuid = m.get('appUuid')
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('formCode') is not None:
            self.form_code = m.get('formCode')
        return self


class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource(TeaModel):
    def __init__(
        self,
        type: str = None,
        target: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget = None,
    ):
        # 关联类型{ "form": 关联表单 }
        self.type = type
        # 关联表单的业务标识
        self.target = target

    def validate(self):
        if self.target:
            self.target.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.target is not None:
            result['target'] = self.target.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('target') is not None:
            temp_model = DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSourceTarget()
            self.target = temp_model.from_map(m['target'])
        return self


class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField(TeaModel):
    def __init__(
        self,
        field_id: str = None,
        label: str = None,
        upper: bool = None,
        unit: str = None,
    ):
        self.field_id = field_id
        self.label = label
        self.upper = upper
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_id is not None:
            result['fieldId'] = self.field_id
        if self.label is not None:
            result['label'] = self.label
        if self.upper is not None:
            result['upper'] = self.upper
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldId') is not None:
            self.field_id = m.get('fieldId')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('upper') is not None:
            self.upper = m.get('upper')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps(TeaModel):
    def __init__(
        self,
        field_id: str = None,
        label: str = None,
        label_editable_freeze: bool = None,
        required: bool = None,
        required_editable_freeze: bool = None,
        not_print: str = None,
        content: str = None,
        format: str = None,
        options: List[DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions] = None,
        not_upper: str = None,
        unit: str = None,
        placeholder: str = None,
        biz_alias: str = None,
        duration: bool = None,
        choice: int = None,
        disabled: bool = None,
        align: str = None,
        fields: List[DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields] = None,
        data_source: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource = None,
        invisible: bool = None,
        pay_enable: bool = None,
        stat_field: List[DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField] = None,
        link: str = None,
        vertical_print: bool = None,
        formula: str = None,
    ):
        # 字段id
        self.field_id = field_id
        # 字段标题
        self.label = label
        # 字段标题是否可修改
        self.label_editable_freeze = label_editable_freeze
        # 字段是否必填
        self.required = required
        # 字段必填是否修改
        self.required_editable_freeze = required_editable_freeze
        # 是否参与打印
        self.not_print = not_print
        # 说明文字内容
        self.content = content
        # 时间格式
        self.format = format
        # 选项内容列表
        self.options = options
        # 是否需要大写 默认是需要
        self.not_upper = not_upper
        # 数字组件/日期区间组件单位属性
        self.unit = unit
        # 界面空值提示占位符 前后端统一用placeholder
        self.placeholder = placeholder
        # 字段别名
        self.biz_alias = biz_alias
        # 是否自动计算时长
        self.duration = duration
        # 内部联系人choice
        self.choice = choice
        # 是否可编辑
        self.disabled = disabled
        # textnote的样式
        self.align = align
        # 关联表单的关联控件显示
        self.fields = fields
        # 关联表单的数据源配置
        self.data_source = data_source
        # 隐藏字段
        self.invisible = invisible
        # 是否有支付属性
        self.pay_enable = pay_enable
        # 需要计算总和的明细组件
        self.stat_field = stat_field
        # 说明文案的链接地址
        self.link = link
        # 明细打印排版方式
        self.vertical_print = vertical_print
        # 公式
        self.formula = formula

    def validate(self):
        if self.options:
            for k in self.options:
                if k:
                    k.validate()
        if self.fields:
            for k in self.fields:
                if k:
                    k.validate()
        if self.data_source:
            self.data_source.validate()
        if self.stat_field:
            for k in self.stat_field:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_id is not None:
            result['fieldId'] = self.field_id
        if self.label is not None:
            result['label'] = self.label
        if self.label_editable_freeze is not None:
            result['labelEditableFreeze'] = self.label_editable_freeze
        if self.required is not None:
            result['required'] = self.required
        if self.required_editable_freeze is not None:
            result['requiredEditableFreeze'] = self.required_editable_freeze
        if self.not_print is not None:
            result['notPrint'] = self.not_print
        if self.content is not None:
            result['content'] = self.content
        if self.format is not None:
            result['format'] = self.format
        result['options'] = []
        if self.options is not None:
            for k in self.options:
                result['options'].append(k.to_map() if k else None)
        if self.not_upper is not None:
            result['notUpper'] = self.not_upper
        if self.unit is not None:
            result['unit'] = self.unit
        if self.placeholder is not None:
            result['placeholder'] = self.placeholder
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.duration is not None:
            result['duration'] = self.duration
        if self.choice is not None:
            result['choice'] = self.choice
        if self.disabled is not None:
            result['disabled'] = self.disabled
        if self.align is not None:
            result['align'] = self.align
        result['fields'] = []
        if self.fields is not None:
            for k in self.fields:
                result['fields'].append(k.to_map() if k else None)
        if self.data_source is not None:
            result['dataSource'] = self.data_source.to_map()
        if self.invisible is not None:
            result['invisible'] = self.invisible
        if self.pay_enable is not None:
            result['payEnable'] = self.pay_enable
        result['statField'] = []
        if self.stat_field is not None:
            for k in self.stat_field:
                result['statField'].append(k.to_map() if k else None)
        if self.link is not None:
            result['link'] = self.link
        if self.vertical_print is not None:
            result['verticalPrint'] = self.vertical_print
        if self.formula is not None:
            result['formula'] = self.formula
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldId') is not None:
            self.field_id = m.get('fieldId')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('labelEditableFreeze') is not None:
            self.label_editable_freeze = m.get('labelEditableFreeze')
        if m.get('required') is not None:
            self.required = m.get('required')
        if m.get('requiredEditableFreeze') is not None:
            self.required_editable_freeze = m.get('requiredEditableFreeze')
        if m.get('notPrint') is not None:
            self.not_print = m.get('notPrint')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('format') is not None:
            self.format = m.get('format')
        self.options = []
        if m.get('options') is not None:
            for k in m.get('options'):
                temp_model = DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsOptions()
                self.options.append(temp_model.from_map(k))
        if m.get('notUpper') is not None:
            self.not_upper = m.get('notUpper')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('placeholder') is not None:
            self.placeholder = m.get('placeholder')
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('choice') is not None:
            self.choice = m.get('choice')
        if m.get('disabled') is not None:
            self.disabled = m.get('disabled')
        if m.get('align') is not None:
            self.align = m.get('align')
        self.fields = []
        if m.get('fields') is not None:
            for k in m.get('fields'):
                temp_model = DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsFields()
                self.fields.append(temp_model.from_map(k))
        if m.get('dataSource') is not None:
            temp_model = DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsDataSource()
            self.data_source = temp_model.from_map(m['dataSource'])
        if m.get('invisible') is not None:
            self.invisible = m.get('invisible')
        if m.get('payEnable') is not None:
            self.pay_enable = m.get('payEnable')
        self.stat_field = []
        if m.get('statField') is not None:
            for k in m.get('statField'):
                temp_model = DescribeRelationMetaResponseBodyRelationMetaDTOListItemsPropsStatField()
                self.stat_field.append(temp_model.from_map(k))
        if m.get('link') is not None:
            self.link = m.get('link')
        if m.get('verticalPrint') is not None:
            self.vertical_print = m.get('verticalPrint')
        if m.get('formula') is not None:
            self.formula = m.get('formula')
        return self


class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions(TeaModel):
    def __init__(
        self,
        key: str = None,
        value: str = None,
    ):
        self.key = key
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.key is not None:
            result['key'] = self.key
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('key') is not None:
            self.key = m.get('key')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions(TeaModel):
    def __init__(
        self,
        key: str = None,
        value: str = None,
    ):
        self.key = key
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.key is not None:
            result['key'] = self.key
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('key') is not None:
            self.key = m.get('key')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField(TeaModel):
    def __init__(
        self,
        field_id: str = None,
        label: str = None,
        upper: bool = None,
        unit: str = None,
    ):
        self.field_id = field_id
        self.label = label
        self.upper = upper
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_id is not None:
            result['fieldId'] = self.field_id
        if self.label is not None:
            result['label'] = self.label
        if self.upper is not None:
            result['upper'] = self.upper
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldId') is not None:
            self.field_id = m.get('fieldId')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('upper') is not None:
            self.upper = m.get('upper')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps(TeaModel):
    def __init__(
        self,
        field_id: str = None,
        label: str = None,
        required: bool = None,
        content: str = None,
        format: str = None,
        options: List[DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions] = None,
        not_upper: str = None,
        unit: str = None,
        placeholder: str = None,
        biz_alias: str = None,
        duration: bool = None,
        choice: int = None,
        disabled: bool = None,
        align: str = None,
        invisible: bool = None,
        pay_enable: bool = None,
        stat_field: List[DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField] = None,
        link: str = None,
        vertical_print: bool = None,
        formula: str = None,
    ):
        self.field_id = field_id
        self.label = label
        self.required = required
        self.content = content
        self.format = format
        self.options = options
        self.not_upper = not_upper
        self.unit = unit
        self.placeholder = placeholder
        self.biz_alias = biz_alias
        self.duration = duration
        self.choice = choice
        self.disabled = disabled
        self.align = align
        self.invisible = invisible
        self.pay_enable = pay_enable
        self.stat_field = stat_field
        self.link = link
        self.vertical_print = vertical_print
        self.formula = formula

    def validate(self):
        if self.options:
            for k in self.options:
                if k:
                    k.validate()
        if self.stat_field:
            for k in self.stat_field:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_id is not None:
            result['fieldId'] = self.field_id
        if self.label is not None:
            result['label'] = self.label
        if self.required is not None:
            result['required'] = self.required
        if self.content is not None:
            result['content'] = self.content
        if self.format is not None:
            result['format'] = self.format
        result['options'] = []
        if self.options is not None:
            for k in self.options:
                result['options'].append(k.to_map() if k else None)
        if self.not_upper is not None:
            result['notUpper'] = self.not_upper
        if self.unit is not None:
            result['unit'] = self.unit
        if self.placeholder is not None:
            result['placeholder'] = self.placeholder
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.duration is not None:
            result['duration'] = self.duration
        if self.choice is not None:
            result['choice'] = self.choice
        if self.disabled is not None:
            result['disabled'] = self.disabled
        if self.align is not None:
            result['align'] = self.align
        if self.invisible is not None:
            result['invisible'] = self.invisible
        if self.pay_enable is not None:
            result['payEnable'] = self.pay_enable
        result['statField'] = []
        if self.stat_field is not None:
            for k in self.stat_field:
                result['statField'].append(k.to_map() if k else None)
        if self.link is not None:
            result['link'] = self.link
        if self.vertical_print is not None:
            result['verticalPrint'] = self.vertical_print
        if self.formula is not None:
            result['formula'] = self.formula
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldId') is not None:
            self.field_id = m.get('fieldId')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('required') is not None:
            self.required = m.get('required')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('format') is not None:
            self.format = m.get('format')
        self.options = []
        if m.get('options') is not None:
            for k in m.get('options'):
                temp_model = DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsOptions()
                self.options.append(temp_model.from_map(k))
        if m.get('notUpper') is not None:
            self.not_upper = m.get('notUpper')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('placeholder') is not None:
            self.placeholder = m.get('placeholder')
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('choice') is not None:
            self.choice = m.get('choice')
        if m.get('disabled') is not None:
            self.disabled = m.get('disabled')
        if m.get('align') is not None:
            self.align = m.get('align')
        if m.get('invisible') is not None:
            self.invisible = m.get('invisible')
        if m.get('payEnable') is not None:
            self.pay_enable = m.get('payEnable')
        self.stat_field = []
        if m.get('statField') is not None:
            for k in m.get('statField'):
                temp_model = DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelatePropsStatField()
                self.stat_field.append(temp_model.from_map(k))
        if m.get('link') is not None:
            self.link = m.get('link')
        if m.get('verticalPrint') is not None:
            self.vertical_print = m.get('verticalPrint')
        if m.get('formula') is not None:
            self.formula = m.get('formula')
        return self


class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields(TeaModel):
    def __init__(
        self,
        component_name: str = None,
        relate_props: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps = None,
    ):
        self.component_name = component_name
        self.relate_props = relate_props

    def validate(self):
        if self.relate_props:
            self.relate_props.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.component_name is not None:
            result['componentName'] = self.component_name
        if self.relate_props is not None:
            result['relateProps'] = self.relate_props.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('componentName') is not None:
            self.component_name = m.get('componentName')
        if m.get('relateProps') is not None:
            temp_model = DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFieldsRelateProps()
            self.relate_props = temp_model.from_map(m['relateProps'])
        return self


class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget(TeaModel):
    def __init__(
        self,
        app_uuid: str = None,
        app_type: int = None,
        biz_type: str = None,
        form_code: str = None,
    ):
        self.app_uuid = app_uuid
        self.app_type = app_type
        self.biz_type = biz_type
        self.form_code = form_code

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.app_uuid is not None:
            result['appUuid'] = self.app_uuid
        if self.app_type is not None:
            result['appType'] = self.app_type
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.form_code is not None:
            result['formCode'] = self.form_code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('appUuid') is not None:
            self.app_uuid = m.get('appUuid')
        if m.get('appType') is not None:
            self.app_type = m.get('appType')
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('formCode') is not None:
            self.form_code = m.get('formCode')
        return self


class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource(TeaModel):
    def __init__(
        self,
        type: str = None,
        target: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget = None,
    ):
        self.type = type
        self.target = target

    def validate(self):
        if self.target:
            self.target.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.type is not None:
            result['type'] = self.type
        if self.target is not None:
            result['target'] = self.target.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('target') is not None:
            temp_model = DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSourceTarget()
            self.target = temp_model.from_map(m['target'])
        return self


class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField(TeaModel):
    def __init__(
        self,
        field_id: str = None,
        label: str = None,
        upper: bool = None,
        unit: str = None,
    ):
        self.field_id = field_id
        self.label = label
        self.upper = upper
        self.unit = unit

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_id is not None:
            result['fieldId'] = self.field_id
        if self.label is not None:
            result['label'] = self.label
        if self.upper is not None:
            result['upper'] = self.upper
        if self.unit is not None:
            result['unit'] = self.unit
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldId') is not None:
            self.field_id = m.get('fieldId')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('upper') is not None:
            self.upper = m.get('upper')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        return self


class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps(TeaModel):
    def __init__(
        self,
        field_id: str = None,
        label: str = None,
        label_editable_freeze: bool = None,
        required: bool = None,
        required_editable_freeze: bool = None,
        not_print: str = None,
        content: str = None,
        format: str = None,
        options: List[DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions] = None,
        not_upper: str = None,
        unit: str = None,
        placeholder: str = None,
        biz_alias: str = None,
        duration: bool = None,
        choice: int = None,
        disabled: bool = None,
        align: str = None,
        fields: List[DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields] = None,
        data_source: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource = None,
        invisible: bool = None,
        pay_enable: bool = None,
        stat_field: List[DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField] = None,
        link: str = None,
        vertical_print: bool = None,
        formula: str = None,
    ):
        self.field_id = field_id
        self.label = label
        self.label_editable_freeze = label_editable_freeze
        self.required = required
        self.required_editable_freeze = required_editable_freeze
        self.not_print = not_print
        self.content = content
        self.format = format
        self.options = options
        self.not_upper = not_upper
        self.unit = unit
        self.placeholder = placeholder
        self.biz_alias = biz_alias
        self.duration = duration
        self.choice = choice
        self.disabled = disabled
        self.align = align
        self.fields = fields
        self.data_source = data_source
        self.invisible = invisible
        self.pay_enable = pay_enable
        self.stat_field = stat_field
        self.link = link
        self.vertical_print = vertical_print
        self.formula = formula

    def validate(self):
        if self.options:
            for k in self.options:
                if k:
                    k.validate()
        if self.fields:
            for k in self.fields:
                if k:
                    k.validate()
        if self.data_source:
            self.data_source.validate()
        if self.stat_field:
            for k in self.stat_field:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_id is not None:
            result['fieldId'] = self.field_id
        if self.label is not None:
            result['label'] = self.label
        if self.label_editable_freeze is not None:
            result['labelEditableFreeze'] = self.label_editable_freeze
        if self.required is not None:
            result['required'] = self.required
        if self.required_editable_freeze is not None:
            result['requiredEditableFreeze'] = self.required_editable_freeze
        if self.not_print is not None:
            result['notPrint'] = self.not_print
        if self.content is not None:
            result['content'] = self.content
        if self.format is not None:
            result['format'] = self.format
        result['options'] = []
        if self.options is not None:
            for k in self.options:
                result['options'].append(k.to_map() if k else None)
        if self.not_upper is not None:
            result['notUpper'] = self.not_upper
        if self.unit is not None:
            result['unit'] = self.unit
        if self.placeholder is not None:
            result['placeholder'] = self.placeholder
        if self.biz_alias is not None:
            result['bizAlias'] = self.biz_alias
        if self.duration is not None:
            result['duration'] = self.duration
        if self.choice is not None:
            result['choice'] = self.choice
        if self.disabled is not None:
            result['disabled'] = self.disabled
        if self.align is not None:
            result['align'] = self.align
        result['fields'] = []
        if self.fields is not None:
            for k in self.fields:
                result['fields'].append(k.to_map() if k else None)
        if self.data_source is not None:
            result['dataSource'] = self.data_source.to_map()
        if self.invisible is not None:
            result['invisible'] = self.invisible
        if self.pay_enable is not None:
            result['payEnable'] = self.pay_enable
        result['statField'] = []
        if self.stat_field is not None:
            for k in self.stat_field:
                result['statField'].append(k.to_map() if k else None)
        if self.link is not None:
            result['link'] = self.link
        if self.vertical_print is not None:
            result['verticalPrint'] = self.vertical_print
        if self.formula is not None:
            result['formula'] = self.formula
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldId') is not None:
            self.field_id = m.get('fieldId')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('labelEditableFreeze') is not None:
            self.label_editable_freeze = m.get('labelEditableFreeze')
        if m.get('required') is not None:
            self.required = m.get('required')
        if m.get('requiredEditableFreeze') is not None:
            self.required_editable_freeze = m.get('requiredEditableFreeze')
        if m.get('notPrint') is not None:
            self.not_print = m.get('notPrint')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('format') is not None:
            self.format = m.get('format')
        self.options = []
        if m.get('options') is not None:
            for k in m.get('options'):
                temp_model = DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsOptions()
                self.options.append(temp_model.from_map(k))
        if m.get('notUpper') is not None:
            self.not_upper = m.get('notUpper')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('placeholder') is not None:
            self.placeholder = m.get('placeholder')
        if m.get('bizAlias') is not None:
            self.biz_alias = m.get('bizAlias')
        if m.get('duration') is not None:
            self.duration = m.get('duration')
        if m.get('choice') is not None:
            self.choice = m.get('choice')
        if m.get('disabled') is not None:
            self.disabled = m.get('disabled')
        if m.get('align') is not None:
            self.align = m.get('align')
        self.fields = []
        if m.get('fields') is not None:
            for k in m.get('fields'):
                temp_model = DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsFields()
                self.fields.append(temp_model.from_map(k))
        if m.get('dataSource') is not None:
            temp_model = DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsDataSource()
            self.data_source = temp_model.from_map(m['dataSource'])
        if m.get('invisible') is not None:
            self.invisible = m.get('invisible')
        if m.get('payEnable') is not None:
            self.pay_enable = m.get('payEnable')
        self.stat_field = []
        if m.get('statField') is not None:
            for k in m.get('statField'):
                temp_model = DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenPropsStatField()
                self.stat_field.append(temp_model.from_map(k))
        if m.get('link') is not None:
            self.link = m.get('link')
        if m.get('verticalPrint') is not None:
            self.vertical_print = m.get('verticalPrint')
        if m.get('formula') is not None:
            self.formula = m.get('formula')
        return self


class DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildren(TeaModel):
    def __init__(
        self,
        component_name: str = None,
        props: DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps = None,
    ):
        self.component_name = component_name
        self.props = props

    def validate(self):
        if self.props:
            self.props.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.component_name is not None:
            result['componentName'] = self.component_name
        if self.props is not None:
            result['props'] = self.props.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('componentName') is not None:
            self.component_name = m.get('componentName')
        if m.get('props') is not None:
            temp_model = DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildrenProps()
            self.props = temp_model.from_map(m['props'])
        return self


class DescribeRelationMetaResponseBodyRelationMetaDTOListItems(TeaModel):
    def __init__(
        self,
        component_name: str = None,
        props: List[DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps] = None,
        children: List[DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildren] = None,
    ):
        # 字段类型
        self.component_name = component_name
        # 字段属性
        self.props = props
        # 子字段列表
        self.children = children

    def validate(self):
        if self.props:
            for k in self.props:
                if k:
                    k.validate()
        if self.children:
            for k in self.children:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.component_name is not None:
            result['componentName'] = self.component_name
        result['props'] = []
        if self.props is not None:
            for k in self.props:
                result['props'].append(k.to_map() if k else None)
        result['children'] = []
        if self.children is not None:
            for k in self.children:
                result['children'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('componentName') is not None:
            self.component_name = m.get('componentName')
        self.props = []
        if m.get('props') is not None:
            for k in m.get('props'):
                temp_model = DescribeRelationMetaResponseBodyRelationMetaDTOListItemsProps()
                self.props.append(temp_model.from_map(k))
        self.children = []
        if m.get('children') is not None:
            for k in m.get('children'):
                temp_model = DescribeRelationMetaResponseBodyRelationMetaDTOListItemsChildren()
                self.children.append(temp_model.from_map(k))
        return self


class DescribeRelationMetaResponseBodyRelationMetaDTOList(TeaModel):
    def __init__(
        self,
        relation_type: str = None,
        name: str = None,
        desc: str = None,
        items: List[DescribeRelationMetaResponseBodyRelationMetaDTOListItems] = None,
    ):
        # 关系类型
        self.relation_type = relation_type
        # 模型结构名称
        self.name = name
        # 模型结构描述
        self.desc = desc
        # 模型结构字段集合
        self.items = items

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
        if self.relation_type is not None:
            result['relationType'] = self.relation_type
        if self.name is not None:
            result['name'] = self.name
        if self.desc is not None:
            result['desc'] = self.desc
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('relationType') is not None:
            self.relation_type = m.get('relationType')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('desc') is not None:
            self.desc = m.get('desc')
        self.items = []
        if m.get('items') is not None:
            for k in m.get('items'):
                temp_model = DescribeRelationMetaResponseBodyRelationMetaDTOListItems()
                self.items.append(temp_model.from_map(k))
        return self


class DescribeRelationMetaResponseBody(TeaModel):
    def __init__(
        self,
        relation_meta_dtolist: List[DescribeRelationMetaResponseBodyRelationMetaDTOList] = None,
    ):
        self.relation_meta_dtolist = relation_meta_dtolist

    def validate(self):
        if self.relation_meta_dtolist:
            for k in self.relation_meta_dtolist:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['relationMetaDTOList'] = []
        if self.relation_meta_dtolist is not None:
            for k in self.relation_meta_dtolist:
                result['relationMetaDTOList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.relation_meta_dtolist = []
        if m.get('relationMetaDTOList') is not None:
            for k in m.get('relationMetaDTOList'):
                temp_model = DescribeRelationMetaResponseBodyRelationMetaDTOList()
                self.relation_meta_dtolist.append(temp_model.from_map(k))
        return self


class DescribeRelationMetaResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DescribeRelationMetaResponseBody = None,
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
            temp_model = DescribeRelationMetaResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AddCrmPersonalCustomerHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class AddCrmPersonalCustomerRequestPermission(TeaModel):
    def __init__(
        self,
        owner_staff_ids: List[str] = None,
        participant_staff_ids: List[str] = None,
    ):
        # 负责人的用户ID
        self.owner_staff_ids = owner_staff_ids
        # 协同人的用户ID
        self.participant_staff_ids = participant_staff_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.owner_staff_ids is not None:
            result['ownerStaffIds'] = self.owner_staff_ids
        if self.participant_staff_ids is not None:
            result['participantStaffIds'] = self.participant_staff_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('ownerStaffIds') is not None:
            self.owner_staff_ids = m.get('ownerStaffIds')
        if m.get('participantStaffIds') is not None:
            self.participant_staff_ids = m.get('participantStaffIds')
        return self


class AddCrmPersonalCustomerRequest(TeaModel):
    def __init__(
        self,
        creator_user_id: str = None,
        creator_nick: str = None,
        data: Dict[str, Any] = None,
        extend_data: Dict[str, Any] = None,
        permission: AddCrmPersonalCustomerRequestPermission = None,
        skip_duplicate_check: bool = None,
        action: str = None,
    ):
        # 记录创建人的用户ID
        self.creator_user_id = creator_user_id
        # 记录创建人的昵称
        self.creator_nick = creator_nick
        # 数据内容
        self.data = data
        # 扩展数据内容
        self.extend_data = extend_data
        # 权限
        self.permission = permission
        # 跳过uk查重
        self.skip_duplicate_check = skip_duplicate_check
        # 公海领取客户：publicDraw 公海分配客户：publicAssign 其余场景：（不用传）
        self.action = action

    def validate(self):
        if self.permission:
            self.permission.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.creator_user_id is not None:
            result['creatorUserId'] = self.creator_user_id
        if self.creator_nick is not None:
            result['creatorNick'] = self.creator_nick
        if self.data is not None:
            result['data'] = self.data
        if self.extend_data is not None:
            result['extendData'] = self.extend_data
        if self.permission is not None:
            result['permission'] = self.permission.to_map()
        if self.skip_duplicate_check is not None:
            result['skipDuplicateCheck'] = self.skip_duplicate_check
        if self.action is not None:
            result['action'] = self.action
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('creatorUserId') is not None:
            self.creator_user_id = m.get('creatorUserId')
        if m.get('creatorNick') is not None:
            self.creator_nick = m.get('creatorNick')
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('extendData') is not None:
            self.extend_data = m.get('extendData')
        if m.get('permission') is not None:
            temp_model = AddCrmPersonalCustomerRequestPermission()
            self.permission = temp_model.from_map(m['permission'])
        if m.get('skipDuplicateCheck') is not None:
            self.skip_duplicate_check = m.get('skipDuplicateCheck')
        if m.get('action') is not None:
            self.action = m.get('action')
        return self


class AddCrmPersonalCustomerResponseBody(TeaModel):
    def __init__(
        self,
        instance_id: str = None,
    ):
        # 客户数据id
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


class AddCrmPersonalCustomerResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: AddCrmPersonalCustomerResponseBody = None,
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
            temp_model = AddCrmPersonalCustomerResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RecallOfficialAccountOTOMessageHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class RecallOfficialAccountOTOMessageRequest(TeaModel):
    def __init__(
        self,
        ding_suite_key: str = None,
        ding_org_id: int = None,
        ding_isv_org_id: int = None,
        ding_token_grant_type: int = None,
        account_id: str = None,
        open_push_id: str = None,
    ):
        self.ding_suite_key = ding_suite_key
        self.ding_org_id = ding_org_id
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_token_grant_type = ding_token_grant_type
        # 帐号ID 可空
        self.account_id = account_id
        # 消息推送时返回的ID
        self.open_push_id = open_push_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.account_id is not None:
            result['accountId'] = self.account_id
        if self.open_push_id is not None:
            result['openPushId'] = self.open_push_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('accountId') is not None:
            self.account_id = m.get('accountId')
        if m.get('openPushId') is not None:
            self.open_push_id = m.get('openPushId')
        return self


class RecallOfficialAccountOTOMessageResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
    ):
        # Id of the request
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


class RecallOfficialAccountOTOMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: RecallOfficialAccountOTOMessageResponseBody = None,
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
            temp_model = RecallOfficialAccountOTOMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DescribeCrmPersonalCustomerObjectMetaHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsSelectOptions(TeaModel):
    def __init__(
        self,
        key: str = None,
        value: str = None,
    ):
        self.key = key
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.key is not None:
            result['key'] = self.key
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('key') is not None:
            self.key = m.get('key')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFieldsSelectOptions(TeaModel):
    def __init__(
        self,
        key: str = None,
        value: str = None,
    ):
        self.key = key
        self.value = value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.key is not None:
            result['key'] = self.key
        if self.value is not None:
            result['value'] = self.value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('key') is not None:
            self.key = m.get('key')
        if m.get('value') is not None:
            self.value = m.get('value')
        return self


class DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields(TeaModel):
    def __init__(
        self,
        label: str = None,
        type: str = None,
        nillable: bool = None,
        unit: str = None,
        format: str = None,
        select_options: List[DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFieldsSelectOptions] = None,
        name: str = None,
    ):
        self.label = label
        self.type = type
        self.nillable = nillable
        self.unit = unit
        self.format = format
        self.select_options = select_options
        self.name = name

    def validate(self):
        if self.select_options:
            for k in self.select_options:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.label is not None:
            result['label'] = self.label
        if self.type is not None:
            result['type'] = self.type
        if self.nillable is not None:
            result['nillable'] = self.nillable
        if self.unit is not None:
            result['unit'] = self.unit
        if self.format is not None:
            result['format'] = self.format
        result['selectOptions'] = []
        if self.select_options is not None:
            for k in self.select_options:
                result['selectOptions'].append(k.to_map() if k else None)
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('nillable') is not None:
            self.nillable = m.get('nillable')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        if m.get('format') is not None:
            self.format = m.get('format')
        self.select_options = []
        if m.get('selectOptions') is not None:
            for k in m.get('selectOptions'):
                temp_model = DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFieldsSelectOptions()
                self.select_options.append(temp_model.from_map(k))
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsRollUpSummaryFields(TeaModel):
    def __init__(
        self,
        name: str = None,
        aggregator: str = None,
    ):
        self.name = name
        self.aggregator = aggregator

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.aggregator is not None:
            result['aggregator'] = self.aggregator
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('aggregator') is not None:
            self.aggregator = m.get('aggregator')
        return self


class DescribeCrmPersonalCustomerObjectMetaResponseBodyFields(TeaModel):
    def __init__(
        self,
        name: str = None,
        customized: bool = None,
        label: str = None,
        type: str = None,
        nillable: bool = None,
        format: str = None,
        unit: str = None,
        select_options: List[DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsSelectOptions] = None,
        quote: bool = None,
        reference_to: str = None,
        reference_fields: List[DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields] = None,
        roll_up_summary_fields: List[DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsRollUpSummaryFields] = None,
    ):
        self.name = name
        self.customized = customized
        self.label = label
        self.type = type
        self.nillable = nillable
        self.format = format
        self.unit = unit
        self.select_options = select_options
        self.quote = quote
        self.reference_to = reference_to
        self.reference_fields = reference_fields
        self.roll_up_summary_fields = roll_up_summary_fields

    def validate(self):
        if self.select_options:
            for k in self.select_options:
                if k:
                    k.validate()
        if self.reference_fields:
            for k in self.reference_fields:
                if k:
                    k.validate()
        if self.roll_up_summary_fields:
            for k in self.roll_up_summary_fields:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.customized is not None:
            result['customized'] = self.customized
        if self.label is not None:
            result['label'] = self.label
        if self.type is not None:
            result['type'] = self.type
        if self.nillable is not None:
            result['nillable'] = self.nillable
        if self.format is not None:
            result['format'] = self.format
        if self.unit is not None:
            result['unit'] = self.unit
        result['selectOptions'] = []
        if self.select_options is not None:
            for k in self.select_options:
                result['selectOptions'].append(k.to_map() if k else None)
        if self.quote is not None:
            result['quote'] = self.quote
        if self.reference_to is not None:
            result['referenceTo'] = self.reference_to
        result['referenceFields'] = []
        if self.reference_fields is not None:
            for k in self.reference_fields:
                result['referenceFields'].append(k.to_map() if k else None)
        result['rollUpSummaryFields'] = []
        if self.roll_up_summary_fields is not None:
            for k in self.roll_up_summary_fields:
                result['rollUpSummaryFields'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('customized') is not None:
            self.customized = m.get('customized')
        if m.get('label') is not None:
            self.label = m.get('label')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('nillable') is not None:
            self.nillable = m.get('nillable')
        if m.get('format') is not None:
            self.format = m.get('format')
        if m.get('unit') is not None:
            self.unit = m.get('unit')
        self.select_options = []
        if m.get('selectOptions') is not None:
            for k in m.get('selectOptions'):
                temp_model = DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsSelectOptions()
                self.select_options.append(temp_model.from_map(k))
        if m.get('quote') is not None:
            self.quote = m.get('quote')
        if m.get('referenceTo') is not None:
            self.reference_to = m.get('referenceTo')
        self.reference_fields = []
        if m.get('referenceFields') is not None:
            for k in m.get('referenceFields'):
                temp_model = DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsReferenceFields()
                self.reference_fields.append(temp_model.from_map(k))
        self.roll_up_summary_fields = []
        if m.get('rollUpSummaryFields') is not None:
            for k in m.get('rollUpSummaryFields'):
                temp_model = DescribeCrmPersonalCustomerObjectMetaResponseBodyFieldsRollUpSummaryFields()
                self.roll_up_summary_fields.append(temp_model.from_map(k))
        return self


class DescribeCrmPersonalCustomerObjectMetaResponseBody(TeaModel):
    def __init__(
        self,
        name: str = None,
        customized: bool = None,
        fields: List[DescribeCrmPersonalCustomerObjectMetaResponseBodyFields] = None,
        status: str = None,
        code: str = None,
    ):
        # 对象名称
        self.name = name
        # 是否自定义对象
        self.customized = customized
        # 字段列表
        self.fields = fields
        # 表单状态
        self.status = status
        # 表单code
        self.code = code

    def validate(self):
        if self.fields:
            for k in self.fields:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.customized is not None:
            result['customized'] = self.customized
        result['fields'] = []
        if self.fields is not None:
            for k in self.fields:
                result['fields'].append(k.to_map() if k else None)
        if self.status is not None:
            result['status'] = self.status
        if self.code is not None:
            result['code'] = self.code
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('customized') is not None:
            self.customized = m.get('customized')
        self.fields = []
        if m.get('fields') is not None:
            for k in m.get('fields'):
                temp_model = DescribeCrmPersonalCustomerObjectMetaResponseBodyFields()
                self.fields.append(temp_model.from_map(k))
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('code') is not None:
            self.code = m.get('code')
        return self


class DescribeCrmPersonalCustomerObjectMetaResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DescribeCrmPersonalCustomerObjectMetaResponseBody = None,
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
            temp_model = DescribeCrmPersonalCustomerObjectMetaResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteCrmPersonalCustomerHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class DeleteCrmPersonalCustomerRequest(TeaModel):
    def __init__(
        self,
        current_operator_user_id: str = None,
    ):
        # 操作人用户ID
        self.current_operator_user_id = current_operator_user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.current_operator_user_id is not None:
            result['currentOperatorUserId'] = self.current_operator_user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('currentOperatorUserId') is not None:
            self.current_operator_user_id = m.get('currentOperatorUserId')
        return self


class DeleteCrmPersonalCustomerResponseBody(TeaModel):
    def __init__(
        self,
        instance_id: str = None,
    ):
        # 客户数据id
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


class DeleteCrmPersonalCustomerResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DeleteCrmPersonalCustomerResponseBody = None,
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
            temp_model = DeleteCrmPersonalCustomerResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AbandonCustomerHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class AbandonCustomerRequest(TeaModel):
    def __init__(
        self,
        operator_user_id: str = None,
        instance_id_list: List[str] = None,
        custom_track_desc: str = None,
        opt_type: str = None,
    ):
        # 操作人staffId，一般为企业员工
        self.operator_user_id = operator_user_id
        # 客户实例 id 数组
        self.instance_id_list = instance_id_list
        # 自定义动态描述
        self.custom_track_desc = custom_track_desc
        # 释放类型：returnPool-退回公海（默认），innerAbandon-仅清除负责人
        self.opt_type = opt_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.operator_user_id is not None:
            result['operatorUserId'] = self.operator_user_id
        if self.instance_id_list is not None:
            result['instanceIdList'] = self.instance_id_list
        if self.custom_track_desc is not None:
            result['customTrackDesc'] = self.custom_track_desc
        if self.opt_type is not None:
            result['optType'] = self.opt_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('operatorUserId') is not None:
            self.operator_user_id = m.get('operatorUserId')
        if m.get('instanceIdList') is not None:
            self.instance_id_list = m.get('instanceIdList')
        if m.get('customTrackDesc') is not None:
            self.custom_track_desc = m.get('customTrackDesc')
        if m.get('optType') is not None:
            self.opt_type = m.get('optType')
        return self


class AbandonCustomerResponseBody(TeaModel):
    def __init__(
        self,
        instance_id_list: List[str] = None,
    ):
        # 成功退回公海的客户实例 id 数组
        self.instance_id_list = instance_id_list

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.instance_id_list is not None:
            result['instanceIdList'] = self.instance_id_list
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('instanceIdList') is not None:
            self.instance_id_list = m.get('instanceIdList')
        return self


class AbandonCustomerResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: AbandonCustomerResponseBody = None,
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
            temp_model = AbandonCustomerResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SendOfficialAccountSNSMessageHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class SendOfficialAccountSNSMessageRequestDetailMessageBodyText(TeaModel):
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


class SendOfficialAccountSNSMessageRequestDetailMessageBodyMarkdown(TeaModel):
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


class SendOfficialAccountSNSMessageRequestDetailMessageBodyLink(TeaModel):
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


class SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCardButtonList(TeaModel):
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


class SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCard(TeaModel):
    def __init__(
        self,
        button_orientation: str = None,
        single_url: str = None,
        single_title: str = None,
        markdown: str = None,
        title: str = None,
        button_list: List[SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCardButtonList] = None,
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
                temp_model = SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCardButtonList()
                self.button_list.append(temp_model.from_map(k))
        return self


class SendOfficialAccountSNSMessageRequestDetailMessageBody(TeaModel):
    def __init__(
        self,
        text: SendOfficialAccountSNSMessageRequestDetailMessageBodyText = None,
        markdown: SendOfficialAccountSNSMessageRequestDetailMessageBodyMarkdown = None,
        link: SendOfficialAccountSNSMessageRequestDetailMessageBodyLink = None,
        action_card: SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCard = None,
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
            temp_model = SendOfficialAccountSNSMessageRequestDetailMessageBodyText()
            self.text = temp_model.from_map(m['text'])
        if m.get('markdown') is not None:
            temp_model = SendOfficialAccountSNSMessageRequestDetailMessageBodyMarkdown()
            self.markdown = temp_model.from_map(m['markdown'])
        if m.get('link') is not None:
            temp_model = SendOfficialAccountSNSMessageRequestDetailMessageBodyLink()
            self.link = temp_model.from_map(m['link'])
        if m.get('actionCard') is not None:
            temp_model = SendOfficialAccountSNSMessageRequestDetailMessageBodyActionCard()
            self.action_card = temp_model.from_map(m['actionCard'])
        return self


class SendOfficialAccountSNSMessageRequestDetail(TeaModel):
    def __init__(
        self,
        msg_type: str = None,
        uuid: str = None,
        message_body: SendOfficialAccountSNSMessageRequestDetailMessageBody = None,
    ):
        # 消息类型
        self.msg_type = msg_type
        # 请求唯一 ID
        self.uuid = uuid
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
        if self.message_body is not None:
            result['messageBody'] = self.message_body.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('msgType') is not None:
            self.msg_type = m.get('msgType')
        if m.get('uuid') is not None:
            self.uuid = m.get('uuid')
        if m.get('messageBody') is not None:
            temp_model = SendOfficialAccountSNSMessageRequestDetailMessageBody()
            self.message_body = temp_model.from_map(m['messageBody'])
        return self


class SendOfficialAccountSNSMessageRequest(TeaModel):
    def __init__(
        self,
        detail: SendOfficialAccountSNSMessageRequestDetail = None,
        biz_id: str = None,
        ding_token_grant_type: int = None,
        ding_client_id: str = None,
        binding_token: str = None,
        ding_uid: int = None,
        ding_open_app_org_id: int = None,
    ):
        # 消息详情
        self.detail = detail
        # API调用标识，可选参数
        self.biz_id = biz_id
        self.ding_token_grant_type = ding_token_grant_type
        self.ding_client_id = ding_client_id
        self.binding_token = binding_token
        self.ding_uid = ding_uid
        self.ding_open_app_org_id = ding_open_app_org_id

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
        if self.ding_client_id is not None:
            result['dingClientId'] = self.ding_client_id
        if self.binding_token is not None:
            result['bindingToken'] = self.binding_token
        if self.ding_uid is not None:
            result['dingUid'] = self.ding_uid
        if self.ding_open_app_org_id is not None:
            result['dingOpenAppOrgId'] = self.ding_open_app_org_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('detail') is not None:
            temp_model = SendOfficialAccountSNSMessageRequestDetail()
            self.detail = temp_model.from_map(m['detail'])
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('dingClientId') is not None:
            self.ding_client_id = m.get('dingClientId')
        if m.get('bindingToken') is not None:
            self.binding_token = m.get('bindingToken')
        if m.get('dingUid') is not None:
            self.ding_uid = m.get('dingUid')
        if m.get('dingOpenAppOrgId') is not None:
            self.ding_open_app_org_id = m.get('dingOpenAppOrgId')
        return self


class SendOfficialAccountSNSMessageResponseBodyResult(TeaModel):
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


class SendOfficialAccountSNSMessageResponseBody(TeaModel):
    def __init__(
        self,
        request_id: str = None,
        result: SendOfficialAccountSNSMessageResponseBodyResult = None,
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
            temp_model = SendOfficialAccountSNSMessageResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class SendOfficialAccountSNSMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SendOfficialAccountSNSMessageResponseBody = None,
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
            temp_model = SendOfficialAccountSNSMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateCrmPersonalCustomerHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class UpdateCrmPersonalCustomerRequestPermission(TeaModel):
    def __init__(
        self,
        owner_staff_ids: List[str] = None,
        participant_staff_ids: List[str] = None,
    ):
        self.owner_staff_ids = owner_staff_ids
        self.participant_staff_ids = participant_staff_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.owner_staff_ids is not None:
            result['ownerStaffIds'] = self.owner_staff_ids
        if self.participant_staff_ids is not None:
            result['participantStaffIds'] = self.participant_staff_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('ownerStaffIds') is not None:
            self.owner_staff_ids = m.get('ownerStaffIds')
        if m.get('participantStaffIds') is not None:
            self.participant_staff_ids = m.get('participantStaffIds')
        return self


class UpdateCrmPersonalCustomerRequest(TeaModel):
    def __init__(
        self,
        instance_id: str = None,
        modifier_user_id: str = None,
        modifier_nick: str = None,
        data: Dict[str, Any] = None,
        extend_data: Dict[str, Any] = None,
        permission: UpdateCrmPersonalCustomerRequestPermission = None,
        skip_duplicate_check: bool = None,
        action: str = None,
    ):
        self.instance_id = instance_id
        self.modifier_user_id = modifier_user_id
        self.modifier_nick = modifier_nick
        self.data = data
        self.extend_data = extend_data
        self.permission = permission
        # 跳过uk查重
        self.skip_duplicate_check = skip_duplicate_check
        # 公海领取客户：publicDraw 公海分配客户：publicAssign 其余场景：（不用传）
        self.action = action

    def validate(self):
        if self.permission:
            self.permission.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.modifier_user_id is not None:
            result['modifierUserId'] = self.modifier_user_id
        if self.modifier_nick is not None:
            result['modifierNick'] = self.modifier_nick
        if self.data is not None:
            result['data'] = self.data
        if self.extend_data is not None:
            result['extendData'] = self.extend_data
        if self.permission is not None:
            result['permission'] = self.permission.to_map()
        if self.skip_duplicate_check is not None:
            result['skipDuplicateCheck'] = self.skip_duplicate_check
        if self.action is not None:
            result['action'] = self.action
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('modifierUserId') is not None:
            self.modifier_user_id = m.get('modifierUserId')
        if m.get('modifierNick') is not None:
            self.modifier_nick = m.get('modifierNick')
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('extendData') is not None:
            self.extend_data = m.get('extendData')
        if m.get('permission') is not None:
            temp_model = UpdateCrmPersonalCustomerRequestPermission()
            self.permission = temp_model.from_map(m['permission'])
        if m.get('skipDuplicateCheck') is not None:
            self.skip_duplicate_check = m.get('skipDuplicateCheck')
        if m.get('action') is not None:
            self.action = m.get('action')
        return self


class UpdateCrmPersonalCustomerResponseBody(TeaModel):
    def __init__(
        self,
        instance_id: str = None,
    ):
        # 客户数据id
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


class UpdateCrmPersonalCustomerResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: UpdateCrmPersonalCustomerResponseBody = None,
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
            temp_model = UpdateCrmPersonalCustomerResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryCrmPersonalCustomerHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryCrmPersonalCustomerRequest(TeaModel):
    def __init__(
        self,
        current_operator_user_id: str = None,
        relation_type: str = None,
        next_token: str = None,
        max_results: int = None,
        query_dsl: str = None,
    ):
        # 用户ID
        self.current_operator_user_id = current_operator_user_id
        self.relation_type = relation_type
        # 分页页码
        self.next_token = next_token
        # 分页条数
        self.max_results = max_results
        # 查询条件
        self.query_dsl = query_dsl

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.current_operator_user_id is not None:
            result['currentOperatorUserId'] = self.current_operator_user_id
        if self.relation_type is not None:
            result['relationType'] = self.relation_type
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.query_dsl is not None:
            result['queryDsl'] = self.query_dsl
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('currentOperatorUserId') is not None:
            self.current_operator_user_id = m.get('currentOperatorUserId')
        if m.get('relationType') is not None:
            self.relation_type = m.get('relationType')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('queryDsl') is not None:
            self.query_dsl = m.get('queryDsl')
        return self


class QueryCrmPersonalCustomerResponseBodyValuesPermission(TeaModel):
    def __init__(
        self,
        owner_staff_ids: List[str] = None,
        participant_staff_ids: List[str] = None,
    ):
        # 负责人用户ID列表
        self.owner_staff_ids = owner_staff_ids
        # 协同人用户ID列表
        self.participant_staff_ids = participant_staff_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.owner_staff_ids is not None:
            result['ownerStaffIds'] = self.owner_staff_ids
        if self.participant_staff_ids is not None:
            result['participantStaffIds'] = self.participant_staff_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('ownerStaffIds') is not None:
            self.owner_staff_ids = m.get('ownerStaffIds')
        if m.get('participantStaffIds') is not None:
            self.participant_staff_ids = m.get('participantStaffIds')
        return self


class QueryCrmPersonalCustomerResponseBodyValues(TeaModel):
    def __init__(
        self,
        instance_id: str = None,
        object_type: str = None,
        creator_user_id: str = None,
        creator_nick: str = None,
        data: Dict[str, Any] = None,
        extend_data: Dict[str, Any] = None,
        permission: QueryCrmPersonalCustomerResponseBodyValuesPermission = None,
        proc_out_result: str = None,
        proc_inst_status: str = None,
        gmt_create: str = None,
        gmt_modified: str = None,
    ):
        # 数据ID
        self.instance_id = instance_id
        # 数据类型
        self.object_type = object_type
        # 创建记录的用户ID
        self.creator_user_id = creator_user_id
        # 创建记录的用户昵称
        self.creator_nick = creator_nick
        # 数据内容
        self.data = data
        # 扩展数据内容
        self.extend_data = extend_data
        # 数据权限信息
        self.permission = permission
        # 审批结果
        self.proc_out_result = proc_out_result
        # 审批状态
        self.proc_inst_status = proc_inst_status
        # 记录创建时间
        self.gmt_create = gmt_create
        # 记录修改时间
        self.gmt_modified = gmt_modified

    def validate(self):
        if self.permission:
            self.permission.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.object_type is not None:
            result['objectType'] = self.object_type
        if self.creator_user_id is not None:
            result['creatorUserId'] = self.creator_user_id
        if self.creator_nick is not None:
            result['creatorNick'] = self.creator_nick
        if self.data is not None:
            result['data'] = self.data
        if self.extend_data is not None:
            result['extendData'] = self.extend_data
        if self.permission is not None:
            result['permission'] = self.permission.to_map()
        if self.proc_out_result is not None:
            result['procOutResult'] = self.proc_out_result
        if self.proc_inst_status is not None:
            result['procInstStatus'] = self.proc_inst_status
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('objectType') is not None:
            self.object_type = m.get('objectType')
        if m.get('creatorUserId') is not None:
            self.creator_user_id = m.get('creatorUserId')
        if m.get('creatorNick') is not None:
            self.creator_nick = m.get('creatorNick')
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('extendData') is not None:
            self.extend_data = m.get('extendData')
        if m.get('permission') is not None:
            temp_model = QueryCrmPersonalCustomerResponseBodyValuesPermission()
            self.permission = temp_model.from_map(m['permission'])
        if m.get('procOutResult') is not None:
            self.proc_out_result = m.get('procOutResult')
        if m.get('procInstStatus') is not None:
            self.proc_inst_status = m.get('procInstStatus')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        return self


class QueryCrmPersonalCustomerResponseBody(TeaModel):
    def __init__(
        self,
        values: List[QueryCrmPersonalCustomerResponseBodyValues] = None,
        has_more: bool = None,
        next_token: str = None,
        max_results: int = None,
    ):
        self.values = values
        self.has_more = has_more
        self.next_token = next_token
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
        result['values'] = []
        if self.values is not None:
            for k in self.values:
                result['values'].append(k.to_map() if k else None)
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.values = []
        if m.get('values') is not None:
            for k in m.get('values'):
                temp_model = QueryCrmPersonalCustomerResponseBodyValues()
                self.values.append(temp_model.from_map(k))
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        return self


class QueryCrmPersonalCustomerResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryCrmPersonalCustomerResponseBody = None,
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
            temp_model = QueryCrmPersonalCustomerResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListCrmPersonalCustomersHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class ListCrmPersonalCustomersRequest(TeaModel):
    def __init__(
        self,
        current_operator_user_id: str = None,
        body: List[str] = None,
    ):
        # 操作人用户ID
        self.current_operator_user_id = current_operator_user_id
        # 数据客户列表
        self.body = body

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.current_operator_user_id is not None:
            result['currentOperatorUserId'] = self.current_operator_user_id
        if self.body is not None:
            result['body'] = self.body
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('currentOperatorUserId') is not None:
            self.current_operator_user_id = m.get('currentOperatorUserId')
        if m.get('body') is not None:
            self.body = m.get('body')
        return self


class ListCrmPersonalCustomersResponseBodyResultPermission(TeaModel):
    def __init__(
        self,
        owner_staff_ids: List[str] = None,
        participant_staff_ids: List[str] = None,
    ):
        self.owner_staff_ids = owner_staff_ids
        self.participant_staff_ids = participant_staff_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.owner_staff_ids is not None:
            result['ownerStaffIds'] = self.owner_staff_ids
        if self.participant_staff_ids is not None:
            result['participantStaffIds'] = self.participant_staff_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('ownerStaffIds') is not None:
            self.owner_staff_ids = m.get('ownerStaffIds')
        if m.get('participantStaffIds') is not None:
            self.participant_staff_ids = m.get('participantStaffIds')
        return self


class ListCrmPersonalCustomersResponseBodyResult(TeaModel):
    def __init__(
        self,
        org_id: int = None,
        instance_id: str = None,
        object_type: str = None,
        creator_user_id: str = None,
        creator_nick: str = None,
        data: Dict[str, Any] = None,
        extend_data: Dict[str, Any] = None,
        permission: ListCrmPersonalCustomersResponseBodyResultPermission = None,
        app_uuid: str = None,
        form_code: str = None,
        proc_out_result: str = None,
        proc_inst_status: str = None,
        gmt_create: str = None,
        gmt_modified: str = None,
    ):
        self.org_id = org_id
        self.instance_id = instance_id
        self.object_type = object_type
        self.creator_user_id = creator_user_id
        self.creator_nick = creator_nick
        self.data = data
        self.extend_data = extend_data
        self.permission = permission
        self.app_uuid = app_uuid
        self.form_code = form_code
        self.proc_out_result = proc_out_result
        self.proc_inst_status = proc_inst_status
        self.gmt_create = gmt_create
        self.gmt_modified = gmt_modified

    def validate(self):
        if self.permission:
            self.permission.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.org_id is not None:
            result['orgId'] = self.org_id
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.object_type is not None:
            result['objectType'] = self.object_type
        if self.creator_user_id is not None:
            result['creatorUserId'] = self.creator_user_id
        if self.creator_nick is not None:
            result['creatorNick'] = self.creator_nick
        if self.data is not None:
            result['data'] = self.data
        if self.extend_data is not None:
            result['extendData'] = self.extend_data
        if self.permission is not None:
            result['permission'] = self.permission.to_map()
        if self.app_uuid is not None:
            result['appUuid'] = self.app_uuid
        if self.form_code is not None:
            result['formCode'] = self.form_code
        if self.proc_out_result is not None:
            result['procOutResult'] = self.proc_out_result
        if self.proc_inst_status is not None:
            result['procInstStatus'] = self.proc_inst_status
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('orgId') is not None:
            self.org_id = m.get('orgId')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('objectType') is not None:
            self.object_type = m.get('objectType')
        if m.get('creatorUserId') is not None:
            self.creator_user_id = m.get('creatorUserId')
        if m.get('creatorNick') is not None:
            self.creator_nick = m.get('creatorNick')
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('extendData') is not None:
            self.extend_data = m.get('extendData')
        if m.get('permission') is not None:
            temp_model = ListCrmPersonalCustomersResponseBodyResultPermission()
            self.permission = temp_model.from_map(m['permission'])
        if m.get('appUuid') is not None:
            self.app_uuid = m.get('appUuid')
        if m.get('formCode') is not None:
            self.form_code = m.get('formCode')
        if m.get('procOutResult') is not None:
            self.proc_out_result = m.get('procOutResult')
        if m.get('procInstStatus') is not None:
            self.proc_inst_status = m.get('procInstStatus')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        return self


class ListCrmPersonalCustomersResponseBody(TeaModel):
    def __init__(
        self,
        result: List[ListCrmPersonalCustomersResponseBodyResult] = None,
    ):
        self.result = result

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
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.result = []
        if m.get('result') is not None:
            for k in m.get('result'):
                temp_model = ListCrmPersonalCustomersResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        return self


class ListCrmPersonalCustomersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListCrmPersonalCustomersResponseBody = None,
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
            temp_model = ListCrmPersonalCustomersResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateCustomerHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class CreateCustomerRequestContacts(TeaModel):
    def __init__(
        self,
        data: Dict[str, Any] = None,
        extend_data: Dict[str, Any] = None,
    ):
        # 联系人表单数据
        self.data = data
        # 联系人扩展数据
        self.extend_data = extend_data

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.data is not None:
            result['data'] = self.data
        if self.extend_data is not None:
            result['extendData'] = self.extend_data
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('extendData') is not None:
            self.extend_data = m.get('extendData')
        return self


class CreateCustomerRequestPermission(TeaModel):
    def __init__(
        self,
        owner_staff_ids: List[str] = None,
        participant_staff_ids: List[str] = None,
    ):
        # 负责人
        self.owner_staff_ids = owner_staff_ids
        # 协同人
        self.participant_staff_ids = participant_staff_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.owner_staff_ids is not None:
            result['ownerStaffIds'] = self.owner_staff_ids
        if self.participant_staff_ids is not None:
            result['participantStaffIds'] = self.participant_staff_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('ownerStaffIds') is not None:
            self.owner_staff_ids = m.get('ownerStaffIds')
        if m.get('participantStaffIds') is not None:
            self.participant_staff_ids = m.get('participantStaffIds')
        return self


class CreateCustomerRequestSaveOption(TeaModel):
    def __init__(
        self,
        subscribe_policy: int = None,
        throw_exception_while_saving_contact_failed: bool = None,
        customer_existed_policy: str = None,
        skip_duplicate_check: bool = None,
    ):
        # 关注配置：0 不处理， 1 自动关注（需要单独申请白名单）
        self.subscribe_policy = subscribe_policy
        # 保存联系人失败时是否阻断
        self.throw_exception_while_saving_contact_failed = throw_exception_while_saving_contact_failed
        # 客户已存在时的处理策略：APPEND_CONTACT_FORCE 直接追加联系人； REJECT 返回失败
        self.customer_existed_policy = customer_existed_policy
        # 跳过uk查重
        self.skip_duplicate_check = skip_duplicate_check

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.subscribe_policy is not None:
            result['subscribePolicy'] = self.subscribe_policy
        if self.throw_exception_while_saving_contact_failed is not None:
            result['throwExceptionWhileSavingContactFailed'] = self.throw_exception_while_saving_contact_failed
        if self.customer_existed_policy is not None:
            result['customerExistedPolicy'] = self.customer_existed_policy
        if self.skip_duplicate_check is not None:
            result['skipDuplicateCheck'] = self.skip_duplicate_check
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('subscribePolicy') is not None:
            self.subscribe_policy = m.get('subscribePolicy')
        if m.get('throwExceptionWhileSavingContactFailed') is not None:
            self.throw_exception_while_saving_contact_failed = m.get('throwExceptionWhileSavingContactFailed')
        if m.get('customerExistedPolicy') is not None:
            self.customer_existed_policy = m.get('customerExistedPolicy')
        if m.get('skipDuplicateCheck') is not None:
            self.skip_duplicate_check = m.get('skipDuplicateCheck')
        return self


class CreateCustomerRequest(TeaModel):
    def __init__(
        self,
        object_type: str = None,
        instance_id: str = None,
        creator_user_id: str = None,
        data: Dict[str, Any] = None,
        extend_data: Dict[str, Any] = None,
        contacts: List[CreateCustomerRequestContacts] = None,
        permission: CreateCustomerRequestPermission = None,
        save_option: CreateCustomerRequestSaveOption = None,
    ):
        # 写入客户类型：个人客户crm_customer_personal; 企业客户crm_customer
        self.object_type = object_type
        # 已存在客户时，添加联系人，可以传入客户的instanceId用作关联绑定
        self.instance_id = instance_id
        # 创建人的userId
        self.creator_user_id = creator_user_id
        # 客户实例数据（表单数据）
        self.data = data
        # 客户实例扩展数据
        self.extend_data = extend_data
        # 关联联系人数据
        self.contacts = contacts
        # 权限
        self.permission = permission
        # 保存配置项
        self.save_option = save_option

    def validate(self):
        if self.contacts:
            for k in self.contacts:
                if k:
                    k.validate()
        if self.permission:
            self.permission.validate()
        if self.save_option:
            self.save_option.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.object_type is not None:
            result['objectType'] = self.object_type
        if self.instance_id is not None:
            result['instanceId'] = self.instance_id
        if self.creator_user_id is not None:
            result['creatorUserId'] = self.creator_user_id
        if self.data is not None:
            result['data'] = self.data
        if self.extend_data is not None:
            result['extendData'] = self.extend_data
        result['contacts'] = []
        if self.contacts is not None:
            for k in self.contacts:
                result['contacts'].append(k.to_map() if k else None)
        if self.permission is not None:
            result['permission'] = self.permission.to_map()
        if self.save_option is not None:
            result['saveOption'] = self.save_option.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('objectType') is not None:
            self.object_type = m.get('objectType')
        if m.get('instanceId') is not None:
            self.instance_id = m.get('instanceId')
        if m.get('creatorUserId') is not None:
            self.creator_user_id = m.get('creatorUserId')
        if m.get('data') is not None:
            self.data = m.get('data')
        if m.get('extendData') is not None:
            self.extend_data = m.get('extendData')
        self.contacts = []
        if m.get('contacts') is not None:
            for k in m.get('contacts'):
                temp_model = CreateCustomerRequestContacts()
                self.contacts.append(temp_model.from_map(k))
        if m.get('permission') is not None:
            temp_model = CreateCustomerRequestPermission()
            self.permission = temp_model.from_map(m['permission'])
        if m.get('saveOption') is not None:
            temp_model = CreateCustomerRequestSaveOption()
            self.save_option = temp_model.from_map(m['saveOption'])
        return self


class CreateCustomerResponseBodyContacts(TeaModel):
    def __init__(
        self,
        contact_instance_id: str = None,
    ):
        # 联系人实例id
        self.contact_instance_id = contact_instance_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.contact_instance_id is not None:
            result['contactInstanceId'] = self.contact_instance_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('contactInstanceId') is not None:
            self.contact_instance_id = m.get('contactInstanceId')
        return self


class CreateCustomerResponseBody(TeaModel):
    def __init__(
        self,
        customer_instance_id: str = None,
        object_type: str = None,
        contacts: List[CreateCustomerResponseBodyContacts] = None,
    ):
        # 客户实例id
        self.customer_instance_id = customer_instance_id
        # 保存客户类型
        self.object_type = object_type
        # 联系人保存结果
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
        if self.customer_instance_id is not None:
            result['customerInstanceId'] = self.customer_instance_id
        if self.object_type is not None:
            result['objectType'] = self.object_type
        result['contacts'] = []
        if self.contacts is not None:
            for k in self.contacts:
                result['contacts'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customerInstanceId') is not None:
            self.customer_instance_id = m.get('customerInstanceId')
        if m.get('objectType') is not None:
            self.object_type = m.get('objectType')
        self.contacts = []
        if m.get('contacts') is not None:
            for k in m.get('contacts'):
                temp_model = CreateCustomerResponseBodyContacts()
                self.contacts.append(temp_model.from_map(k))
        return self


class CreateCustomerResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateCustomerResponseBody = None,
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
            temp_model = CreateCustomerResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryAllTracksHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryAllTracksRequest(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        max_results: int = None,
        order: str = None,
    ):
        # 分页游标
        self.next_token = next_token
        # 分页size
        self.max_results = max_results
        # 排序
        self.order = order

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
        if self.order is not None:
            result['order'] = self.order
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('order') is not None:
            self.order = m.get('order')
        return self


class QueryAllTracksResponseBodyValues(TeaModel):
    def __init__(
        self,
        corp_id: str = None,
        customer_id: str = None,
        type: int = None,
        sub_type: int = None,
        gmt_create: int = None,
        creator: str = None,
        biz_id: str = None,
        id: str = None,
    ):
        # 企业id
        self.corp_id = corp_id
        # 客户id
        self.customer_id = customer_id
        # 动态类型
        self.type = type
        # 动态子类型
        self.sub_type = sub_type
        # 创建时间
        self.gmt_create = gmt_create
        # 创建人userId
        self.creator = creator
        # 动态外键
        self.biz_id = biz_id
        # 动态加密主键
        self.id = id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.customer_id is not None:
            result['customerId'] = self.customer_id
        if self.type is not None:
            result['type'] = self.type
        if self.sub_type is not None:
            result['subType'] = self.sub_type
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.creator is not None:
            result['creator'] = self.creator
        if self.biz_id is not None:
            result['bizId'] = self.biz_id
        if self.id is not None:
            result['id'] = self.id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('customerId') is not None:
            self.customer_id = m.get('customerId')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('subType') is not None:
            self.sub_type = m.get('subType')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('creator') is not None:
            self.creator = m.get('creator')
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        if m.get('id') is not None:
            self.id = m.get('id')
        return self


class QueryAllTracksResponseBody(TeaModel):
    def __init__(
        self,
        values: List[QueryAllTracksResponseBodyValues] = None,
        has_more: bool = None,
        next_token: str = None,
        max_results: int = None,
    ):
        # 客户动态分页数据
        self.values = values
        # 是否还有数据
        self.has_more = has_more
        # 下页翻页起始游标
        self.next_token = next_token
        # 翻页size
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
        result['values'] = []
        if self.values is not None:
            for k in self.values:
                result['values'].append(k.to_map() if k else None)
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.values = []
        if m.get('values') is not None:
            for k in m.get('values'):
                temp_model = QueryAllTracksResponseBodyValues()
                self.values.append(temp_model.from_map(k))
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        return self


class QueryAllTracksResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryAllTracksResponseBody = None,
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
            temp_model = QueryAllTracksResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


