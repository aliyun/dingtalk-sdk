# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class DeleteKnowledgeHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class DeleteKnowledgeRequest(TeaModel):
    def __init__(
        self,
        ding_isv_org_id: int = None,
        ding_org_id: int = None,
        ding_suite_key: str = None,
        ding_token_grant_type: int = None,
        open_team_id: str = None,
        library_key: str = None,
        source: str = None,
        source_primary_key: str = None,
    ):
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_org_id = ding_org_id
        self.ding_suite_key = ding_suite_key
        self.ding_token_grant_type = ding_token_grant_type
        # 开放团队ID
        self.open_team_id = open_team_id
        # 知识库的唯一标识 比如:天工知识库ID
        self.library_key = library_key
        # 知识点来源 CCM:天工知识库
        self.source = source
        # 知识点唯一标识
        self.source_primary_key = source_primary_key

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
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.library_key is not None:
            result['libraryKey'] = self.library_key
        if self.source is not None:
            result['source'] = self.source
        if self.source_primary_key is not None:
            result['sourcePrimaryKey'] = self.source_primary_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('libraryKey') is not None:
            self.library_key = m.get('libraryKey')
        if m.get('source') is not None:
            self.source = m.get('source')
        if m.get('sourcePrimaryKey') is not None:
            self.source_primary_key = m.get('sourcePrimaryKey')
        return self


class DeleteKnowledgeResponseBody(TeaModel):
    def __init__(
        self,
        success: bool = None,
    ):
        # 是否成功
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


class DeleteKnowledgeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: DeleteKnowledgeResponseBody = None,
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
            temp_model = DeleteKnowledgeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SearchGroupHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class SearchGroupRequest(TeaModel):
    def __init__(
        self,
        ding_isv_org_id: int = None,
        ding_org_id: int = None,
        ding_suite_key: str = None,
        ding_token_grant_type: int = None,
        open_conversation_id: str = None,
        group_name: str = None,
        open_team_id: str = None,
        open_group_set_id: str = None,
        next_token: str = None,
        max_results: int = None,
    ):
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_org_id = ding_org_id
        self.ding_suite_key = ding_suite_key
        self.ding_token_grant_type = ding_token_grant_type
        # 开放群ID
        self.open_conversation_id = open_conversation_id
        # 群名称
        self.group_name = group_name
        # 开放团队ID
        self.open_team_id = open_team_id
        # 开群组ID
        self.open_group_set_id = open_group_set_id
        # 用来标记当前开始读取的位置，置空表示从头开始。
        self.next_token = next_token
        # 本次读取的最大数据记录数量，此参数为可选参数，用户传入为空时，应该有默认值。应设置最大值限制，最大不超过100
        self.max_results = max_results

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
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.open_group_set_id is not None:
            result['openGroupSetId'] = self.open_group_set_id
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('openGroupSetId') is not None:
            self.open_group_set_id = m.get('openGroupSetId')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        return self


class SearchGroupResponseBodyRecords(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        group_name: str = None,
        open_team_id: str = None,
        open_group_set_id: str = None,
    ):
        # 开放群ID
        self.open_conversation_id = open_conversation_id
        # 群名称
        self.group_name = group_name
        # 开放团队ID
        self.open_team_id = open_team_id
        # 开放群组ID
        self.open_group_set_id = open_group_set_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.open_group_set_id is not None:
            result['openGroupSetId'] = self.open_group_set_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('openGroupSetId') is not None:
            self.open_group_set_id = m.get('openGroupSetId')
        return self


class SearchGroupResponseBody(TeaModel):
    def __init__(
        self,
        total_count: int = None,
        next_token: str = None,
        max_results: int = None,
        records: List[SearchGroupResponseBodyRecords] = None,
    ):
        # 本次请求条件下的数据总量，此参数为可选参数，默认可不返回。本次请求条件下的数据总量，此参数为可选参数，默认可不返回
        self.total_count = total_count
        # 表示当前调用返回读取到的位置，空代表数据已经读取完毕
        self.next_token = next_token
        # 本次请求所返回的最大记录条数。
        self.max_results = max_results
        # 已读未读信息列表
        self.records = records

    def validate(self):
        if self.records:
            for k in self.records:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        result['records'] = []
        if self.records is not None:
            for k in self.records:
                result['records'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        self.records = []
        if m.get('records') is not None:
            for k in m.get('records'):
                temp_model = SearchGroupResponseBodyRecords()
                self.records.append(temp_model.from_map(k))
        return self


class SearchGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SearchGroupResponseBody = None,
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
            temp_model = SearchGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateGroupHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class CreateGroupRequest(TeaModel):
    def __init__(
        self,
        group_biz_id: str = None,
        open_team_id: str = None,
        open_group_set_id: str = None,
        group_name: str = None,
        owner_staff_id: str = None,
        member_staff_ids: List[str] = None,
        group_tag_names: List[str] = None,
        ding_isv_org_id: int = None,
        ding_org_id: int = None,
        ding_suite_key: str = None,
        ding_token_grant_type: int = None,
    ):
        # 业务关联id
        self.group_biz_id = group_biz_id
        # 开放团队ID
        self.open_team_id = open_team_id
        # 开放群组ID
        self.open_group_set_id = open_group_set_id
        # 群名称
        self.group_name = group_name
        # 群主员工ID
        self.owner_staff_id = owner_staff_id
        # 群成员员工ID列表
        self.member_staff_ids = member_staff_ids
        # 群标签
        self.group_tag_names = group_tag_names
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_org_id = ding_org_id
        self.ding_suite_key = ding_suite_key
        self.ding_token_grant_type = ding_token_grant_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_biz_id is not None:
            result['groupBizId'] = self.group_biz_id
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.open_group_set_id is not None:
            result['openGroupSetId'] = self.open_group_set_id
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.owner_staff_id is not None:
            result['ownerStaffId'] = self.owner_staff_id
        if self.member_staff_ids is not None:
            result['memberStaffIds'] = self.member_staff_ids
        if self.group_tag_names is not None:
            result['groupTagNames'] = self.group_tag_names
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupBizId') is not None:
            self.group_biz_id = m.get('groupBizId')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('openGroupSetId') is not None:
            self.open_group_set_id = m.get('openGroupSetId')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('ownerStaffId') is not None:
            self.owner_staff_id = m.get('ownerStaffId')
        if m.get('memberStaffIds') is not None:
            self.member_staff_ids = m.get('memberStaffIds')
        if m.get('groupTagNames') is not None:
            self.group_tag_names = m.get('groupTagNames')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        return self


class CreateGroupResponseBody(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        group_url: str = None,
    ):
        # 开放群ID
        self.open_conversation_id = open_conversation_id
        # 入群url
        self.group_url = group_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.group_url is not None:
            result['groupUrl'] = self.group_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('groupUrl') is not None:
            self.group_url = m.get('groupUrl')
        return self


class CreateGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CreateGroupResponseBody = None,
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
            temp_model = CreateGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SendServiceGroupMessageHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class SendServiceGroupMessageRequestBtns(TeaModel):
    def __init__(
        self,
        action_url: str = None,
        title: str = None,
    ):
        # 跳转地址
        self.action_url = action_url
        # 按钮名称
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action_url is not None:
            result['actionURL'] = self.action_url
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionURL') is not None:
            self.action_url = m.get('actionURL')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class SendServiceGroupMessageRequest(TeaModel):
    def __init__(
        self,
        ding_isv_org_id: int = None,
        ding_org_id: int = None,
        ding_token_grant_type: int = None,
        ding_suite_key: str = None,
        target_open_conversation_id: str = None,
        title: str = None,
        content: str = None,
        is_at_all: bool = None,
        at_mobiles: List[str] = None,
        at_dingtalk_ids: List[str] = None,
        at_union_ids: List[str] = None,
        receiver_mobiles: List[str] = None,
        receiver_dingtalk_ids: List[str] = None,
        receiver_union_ids: List[str] = None,
        message_type: str = None,
        btn_orientation: str = None,
        btns: List[SendServiceGroupMessageRequestBtns] = None,
    ):
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_org_id = ding_org_id
        self.ding_token_grant_type = ding_token_grant_type
        self.ding_suite_key = ding_suite_key
        # 开放群ID
        self.target_open_conversation_id = target_open_conversation_id
        # 标题
        self.title = title
        # 内容
        self.content = content
        # 是否 at所有人
        self.is_at_all = is_at_all
        # at 手机号
        self.at_mobiles = at_mobiles
        # at dingtalkId
        self.at_dingtalk_ids = at_dingtalk_ids
        # at unionIds
        self.at_union_ids = at_union_ids
        # 手机号接收者
        self.receiver_mobiles = receiver_mobiles
        # dingtalkId接收者
        self.receiver_dingtalk_ids = receiver_dingtalk_ids
        # unionId接收者
        self.receiver_union_ids = receiver_union_ids
        # 消息类型：MARKDOWN，ACTIONCARD
        self.message_type = message_type
        # 排列方式：0-按钮竖直排列，1-按钮横向排列
        self.btn_orientation = btn_orientation
        # actionCard按钮
        self.btns = btns

    def validate(self):
        if self.btns:
            for k in self.btns:
                if k:
                    k.validate()

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
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.target_open_conversation_id is not None:
            result['targetOpenConversationId'] = self.target_open_conversation_id
        if self.title is not None:
            result['title'] = self.title
        if self.content is not None:
            result['content'] = self.content
        if self.is_at_all is not None:
            result['isAtAll'] = self.is_at_all
        if self.at_mobiles is not None:
            result['atMobiles'] = self.at_mobiles
        if self.at_dingtalk_ids is not None:
            result['atDingtalkIds'] = self.at_dingtalk_ids
        if self.at_union_ids is not None:
            result['atUnionIds'] = self.at_union_ids
        if self.receiver_mobiles is not None:
            result['receiverMobiles'] = self.receiver_mobiles
        if self.receiver_dingtalk_ids is not None:
            result['receiverDingtalkIds'] = self.receiver_dingtalk_ids
        if self.receiver_union_ids is not None:
            result['receiverUnionIds'] = self.receiver_union_ids
        if self.message_type is not None:
            result['messageType'] = self.message_type
        if self.btn_orientation is not None:
            result['btnOrientation'] = self.btn_orientation
        result['btns'] = []
        if self.btns is not None:
            for k in self.btns:
                result['btns'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('targetOpenConversationId') is not None:
            self.target_open_conversation_id = m.get('targetOpenConversationId')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('isAtAll') is not None:
            self.is_at_all = m.get('isAtAll')
        if m.get('atMobiles') is not None:
            self.at_mobiles = m.get('atMobiles')
        if m.get('atDingtalkIds') is not None:
            self.at_dingtalk_ids = m.get('atDingtalkIds')
        if m.get('atUnionIds') is not None:
            self.at_union_ids = m.get('atUnionIds')
        if m.get('receiverMobiles') is not None:
            self.receiver_mobiles = m.get('receiverMobiles')
        if m.get('receiverDingtalkIds') is not None:
            self.receiver_dingtalk_ids = m.get('receiverDingtalkIds')
        if m.get('receiverUnionIds') is not None:
            self.receiver_union_ids = m.get('receiverUnionIds')
        if m.get('messageType') is not None:
            self.message_type = m.get('messageType')
        if m.get('btnOrientation') is not None:
            self.btn_orientation = m.get('btnOrientation')
        self.btns = []
        if m.get('btns') is not None:
            for k in m.get('btns'):
                temp_model = SendServiceGroupMessageRequestBtns()
                self.btns.append(temp_model.from_map(k))
        return self


class SendServiceGroupMessageResponseBody(TeaModel):
    def __init__(
        self,
        open_msg_task_id: str = None,
    ):
        # 开放消息任务ID
        self.open_msg_task_id = open_msg_task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_msg_task_id is not None:
            result['openMsgTaskId'] = self.open_msg_task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openMsgTaskId') is not None:
            self.open_msg_task_id = m.get('openMsgTaskId')
        return self


class SendServiceGroupMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: SendServiceGroupMessageResponseBody = None,
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
            temp_model = SendServiceGroupMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AddKnowledgeHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class AddKnowledgeRequest(TeaModel):
    def __init__(
        self,
        ding_isv_org_id: int = None,
        ding_org_id: int = None,
        ding_suite_key: str = None,
        ding_token_grant_type: int = None,
        open_team_id: str = None,
        library_key: str = None,
        source: str = None,
        source_primary_key: str = None,
        type: str = None,
        title: str = None,
        content: str = None,
        link_url: str = None,
        version: str = None,
    ):
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_org_id = ding_org_id
        self.ding_suite_key = ding_suite_key
        self.ding_token_grant_type = ding_token_grant_type
        # 开放团队ID
        self.open_team_id = open_team_id
        # 知识库的唯一标识
        self.library_key = library_key
        # 知识点来源
        self.source = source
        # 知识点唯一标识
        self.source_primary_key = source_primary_key
        # 知识点类型 NORMAL：普通型 CARD：卡片 CONDITION：条件
        self.type = type
        # 知识点名称
        self.title = title
        # 知识点内容
        self.content = content
        # CCM的知识点外链
        self.link_url = link_url
        # 知识点版本号
        self.version = version

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
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.library_key is not None:
            result['libraryKey'] = self.library_key
        if self.source is not None:
            result['source'] = self.source
        if self.source_primary_key is not None:
            result['sourcePrimaryKey'] = self.source_primary_key
        if self.type is not None:
            result['type'] = self.type
        if self.title is not None:
            result['title'] = self.title
        if self.content is not None:
            result['content'] = self.content
        if self.link_url is not None:
            result['linkUrl'] = self.link_url
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('libraryKey') is not None:
            self.library_key = m.get('libraryKey')
        if m.get('source') is not None:
            self.source = m.get('source')
        if m.get('sourcePrimaryKey') is not None:
            self.source_primary_key = m.get('sourcePrimaryKey')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('linkUrl') is not None:
            self.link_url = m.get('linkUrl')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class AddKnowledgeResponseBody(TeaModel):
    def __init__(
        self,
        open_knowledge_id: str = None,
    ):
        # 开放知识点ID
        self.open_knowledge_id = open_knowledge_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_knowledge_id is not None:
            result['openKnowledgeId'] = self.open_knowledge_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openKnowledgeId') is not None:
            self.open_knowledge_id = m.get('openKnowledgeId')
        return self


class AddKnowledgeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: AddKnowledgeResponseBody = None,
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
            temp_model = AddKnowledgeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BatchGetGroupSetConfigHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class BatchGetGroupSetConfigRequest(TeaModel):
    def __init__(
        self,
        ding_isv_org_id: int = None,
        ding_org_id: int = None,
        ding_suite_key: str = None,
        ding_token_grant_type: int = None,
        open_team_id: str = None,
        open_group_set_id: str = None,
        config_keys: List[str] = None,
    ):
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_org_id = ding_org_id
        self.ding_suite_key = ding_suite_key
        self.ding_token_grant_type = ding_token_grant_type
        # 开放团队id
        self.open_team_id = open_team_id
        # 开放群组id
        self.open_group_set_id = open_group_set_id
        # 配置项key列表
        self.config_keys = config_keys

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
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.open_group_set_id is not None:
            result['openGroupSetId'] = self.open_group_set_id
        if self.config_keys is not None:
            result['configKeys'] = self.config_keys
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('openGroupSetId') is not None:
            self.open_group_set_id = m.get('openGroupSetId')
        if m.get('configKeys') is not None:
            self.config_keys = m.get('configKeys')
        return self


class BatchGetGroupSetConfigResponseBodyGroupSetConfigs(TeaModel):
    def __init__(
        self,
        config_key: str = None,
        config_value: str = None,
    ):
        # 配置项key
        self.config_key = config_key
        # 配置项值
        self.config_value = config_value

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.config_key is not None:
            result['configKey'] = self.config_key
        if self.config_value is not None:
            result['configValue'] = self.config_value
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('configKey') is not None:
            self.config_key = m.get('configKey')
        if m.get('configValue') is not None:
            self.config_value = m.get('configValue')
        return self


class BatchGetGroupSetConfigResponseBody(TeaModel):
    def __init__(
        self,
        group_set_configs: List[BatchGetGroupSetConfigResponseBodyGroupSetConfigs] = None,
    ):
        # 群粗配置列表
        self.group_set_configs = group_set_configs

    def validate(self):
        if self.group_set_configs:
            for k in self.group_set_configs:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['groupSetConfigs'] = []
        if self.group_set_configs is not None:
            for k in self.group_set_configs:
                result['groupSetConfigs'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.group_set_configs = []
        if m.get('groupSetConfigs') is not None:
            for k in m.get('groupSetConfigs'):
                temp_model = BatchGetGroupSetConfigResponseBodyGroupSetConfigs()
                self.group_set_configs.append(temp_model.from_map(k))
        return self


class BatchGetGroupSetConfigResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: BatchGetGroupSetConfigResponseBody = None,
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
            temp_model = BatchGetGroupSetConfigResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryServiceGroupMessageReadStatusHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryServiceGroupMessageReadStatusRequest(TeaModel):
    def __init__(
        self,
        ding_isv_org_id: int = None,
        ding_org_id: int = None,
        ding_token_grant_type: int = None,
        ding_suite_key: str = None,
        open_team_id: str = None,
        open_conversation_id: str = None,
        open_msg_task_id: str = None,
        next_token: str = None,
        max_results: int = None,
    ):
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_org_id = ding_org_id
        self.ding_token_grant_type = ding_token_grant_type
        self.ding_suite_key = ding_suite_key
        # 开放团队ID
        self.open_team_id = open_team_id
        # 开放群ID
        self.open_conversation_id = open_conversation_id
        # 开放消息ID
        self.open_msg_task_id = open_msg_task_id
        # 用来标记当前开始读取的位置，置空表示从头开始。
        self.next_token = next_token
        # 本次读取的最大数据记录数量，此参数为可选参数，用户传入为空时，应该有默认值。应设置最大值限制，最大不超过100
        self.max_results = max_results

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
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.open_msg_task_id is not None:
            result['openMsgTaskId'] = self.open_msg_task_id
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('openMsgTaskId') is not None:
            self.open_msg_task_id = m.get('openMsgTaskId')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        return self


class QueryServiceGroupMessageReadStatusResponseBodyRecords(TeaModel):
    def __init__(
        self,
        receiver_user_id: str = None,
        receiver_union_id: str = None,
        read_status: int = None,
        receiver_name: str = None,
        receiver_ding_talk_id: str = None,
    ):
        # 已读人员为企业员工则有值
        self.receiver_user_id = receiver_user_id
        # 已读人员为非企业员工则有值
        self.receiver_union_id = receiver_union_id
        # 状态：已读1/未读0
        self.read_status = read_status
        # 接收者昵称
        self.receiver_name = receiver_name
        # 接收者dingtalkId
        self.receiver_ding_talk_id = receiver_ding_talk_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.receiver_user_id is not None:
            result['receiverUserId'] = self.receiver_user_id
        if self.receiver_union_id is not None:
            result['receiverUnionId'] = self.receiver_union_id
        if self.read_status is not None:
            result['readStatus'] = self.read_status
        if self.receiver_name is not None:
            result['receiverName'] = self.receiver_name
        if self.receiver_ding_talk_id is not None:
            result['receiverDingTalkId'] = self.receiver_ding_talk_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('receiverUserId') is not None:
            self.receiver_user_id = m.get('receiverUserId')
        if m.get('receiverUnionId') is not None:
            self.receiver_union_id = m.get('receiverUnionId')
        if m.get('readStatus') is not None:
            self.read_status = m.get('readStatus')
        if m.get('receiverName') is not None:
            self.receiver_name = m.get('receiverName')
        if m.get('receiverDingTalkId') is not None:
            self.receiver_ding_talk_id = m.get('receiverDingTalkId')
        return self


class QueryServiceGroupMessageReadStatusResponseBody(TeaModel):
    def __init__(
        self,
        total_count: int = None,
        next_token: str = None,
        max_results: int = None,
        records: List[QueryServiceGroupMessageReadStatusResponseBodyRecords] = None,
    ):
        # 本次请求条件下的数据总量，此参数为可选参数，默认可不返回。本次请求条件下的数据总量，此参数为可选参数，默认可不返回
        self.total_count = total_count
        # 表示当前调用返回读取到的位置，空代表数据已经读取完毕
        self.next_token = next_token
        # 本次请求所返回的最大记录条数。
        self.max_results = max_results
        # 已读未读信息列表
        self.records = records

    def validate(self):
        if self.records:
            for k in self.records:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        result['records'] = []
        if self.records is not None:
            for k in self.records:
                result['records'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        self.records = []
        if m.get('records') is not None:
            for k in m.get('records'):
                temp_model = QueryServiceGroupMessageReadStatusResponseBodyRecords()
                self.records.append(temp_model.from_map(k))
        return self


class QueryServiceGroupMessageReadStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryServiceGroupMessageReadStatusResponseBody = None,
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
            temp_model = QueryServiceGroupMessageReadStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AddLibraryHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class AddLibraryRequest(TeaModel):
    def __init__(
        self,
        ding_token_grant_type: int = None,
        ding_isv_org_id: int = None,
        ding_suite_key: str = None,
        ding_org_id: int = None,
        open_team_ids: List[str] = None,
        title: str = None,
        description: str = None,
        type: str = None,
        source: str = None,
        source_primary_key: str = None,
        user_id: str = None,
    ):
        self.ding_token_grant_type = ding_token_grant_type
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_suite_key = ding_suite_key
        self.ding_org_id = ding_org_id
        # 团队id列表
        self.open_team_ids = open_team_ids
        # 知识库名称
        self.title = title
        # 知识库描述
        self.description = description
        # 知识库类型 INTERNAL:内部知识库 EXTERNAL:外部知识库
        self.type = type
        # 知识来源
        self.source = source
        # 知识库的唯一性标识
        self.source_primary_key = source_primary_key
        # 员工ID
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.ding_isv_org_id is not None:
            result['dingIsvOrgId'] = self.ding_isv_org_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_org_id is not None:
            result['dingOrgId'] = self.ding_org_id
        if self.open_team_ids is not None:
            result['openTeamIds'] = self.open_team_ids
        if self.title is not None:
            result['title'] = self.title
        if self.description is not None:
            result['description'] = self.description
        if self.type is not None:
            result['type'] = self.type
        if self.source is not None:
            result['source'] = self.source
        if self.source_primary_key is not None:
            result['sourcePrimaryKey'] = self.source_primary_key
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('openTeamIds') is not None:
            self.open_team_ids = m.get('openTeamIds')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('source') is not None:
            self.source = m.get('source')
        if m.get('sourcePrimaryKey') is not None:
            self.source_primary_key = m.get('sourcePrimaryKey')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class AddLibraryResponseBody(TeaModel):
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


class AddLibraryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: AddLibraryResponseBody = None,
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
            temp_model = AddLibraryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListUserTeamsHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class ListUserTeamsResponseBodyTeams(TeaModel):
    def __init__(
        self,
        open_team_id: str = None,
        team_name: str = None,
    ):
        # 开放团队ID
        self.open_team_id = open_team_id
        # 团队名称
        self.team_name = team_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.team_name is not None:
            result['teamName'] = self.team_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('teamName') is not None:
            self.team_name = m.get('teamName')
        return self


class ListUserTeamsResponseBody(TeaModel):
    def __init__(
        self,
        teams: List[ListUserTeamsResponseBodyTeams] = None,
    ):
        # teams
        self.teams = teams

    def validate(self):
        if self.teams:
            for k in self.teams:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['teams'] = []
        if self.teams is not None:
            for k in self.teams:
                result['teams'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.teams = []
        if m.get('teams') is not None:
            for k in m.get('teams'):
                temp_model = ListUserTeamsResponseBodyTeams()
                self.teams.append(temp_model.from_map(k))
        return self


class ListUserTeamsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: ListUserTeamsResponseBody = None,
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
            temp_model = ListUserTeamsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryGroupHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryGroupRequest(TeaModel):
    def __init__(
        self,
        ding_isv_org_id: int = None,
        ding_org_id: int = None,
        ding_suite_key: str = None,
        ding_token_grant_type: int = None,
        open_team_id: str = None,
        open_conversation_id: str = None,
        biz_id: str = None,
    ):
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_org_id = ding_org_id
        self.ding_suite_key = ding_suite_key
        self.ding_token_grant_type = ding_token_grant_type
        # 开放团队ID
        self.open_team_id = open_team_id
        # 开放群ID
        self.open_conversation_id = open_conversation_id
        # 业务关联ID，和开放群ID二选一传
        self.biz_id = biz_id

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
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.biz_id is not None:
            result['bizId'] = self.biz_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        return self


class QueryGroupResponseBody(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        group_name: str = None,
        open_team_id: str = None,
        open_group_set_id: str = None,
        group_url: str = None,
        robot_code: str = None,
        robot_name: str = None,
    ):
        # 开放群ID
        self.open_conversation_id = open_conversation_id
        # 群名称
        self.group_name = group_name
        # 开放团队ID
        self.open_team_id = open_team_id
        # 开放群组ID
        self.open_group_set_id = open_group_set_id
        # 入群URL
        self.group_url = group_url
        # 服务群机器人code
        self.robot_code = robot_code
        # 服务群机器人名称
        self.robot_name = robot_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.open_group_set_id is not None:
            result['openGroupSetId'] = self.open_group_set_id
        if self.group_url is not None:
            result['groupUrl'] = self.group_url
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        if self.robot_name is not None:
            result['robotName'] = self.robot_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('openGroupSetId') is not None:
            self.open_group_set_id = m.get('openGroupSetId')
        if m.get('groupUrl') is not None:
            self.group_url = m.get('groupUrl')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        if m.get('robotName') is not None:
            self.robot_name = m.get('robotName')
        return self


class QueryGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: QueryGroupResponseBody = None,
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
            temp_model = QueryGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CloseHumanSessionHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class CloseHumanSessionRequest(TeaModel):
    def __init__(
        self,
        ding_isv_org_id: int = None,
        ding_org_id: int = None,
        ding_suite_key: str = None,
        ding_token_grant_type: int = None,
        open_team_id: str = None,
        open_conversation_id: str = None,
        visitor_union_id: int = None,
    ):
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_org_id = ding_org_id
        self.ding_suite_key = ding_suite_key
        self.ding_token_grant_type = ding_token_grant_type
        # 开放团队id
        self.open_team_id = open_team_id
        # 开放会话id
        self.open_conversation_id = open_conversation_id
        # 访客unionid
        self.visitor_union_id = visitor_union_id

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
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.visitor_union_id is not None:
            result['visitorUnionId'] = self.visitor_union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingIsvOrgId') is not None:
            self.ding_isv_org_id = m.get('dingIsvOrgId')
        if m.get('dingOrgId') is not None:
            self.ding_org_id = m.get('dingOrgId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('visitorUnionId') is not None:
            self.visitor_union_id = m.get('visitorUnionId')
        return self


class CloseHumanSessionResponseBody(TeaModel):
    def __init__(
        self,
        session_id: int = None,
    ):
        self.session_id = session_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.session_id is not None:
            result['sessionId'] = self.session_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('sessionId') is not None:
            self.session_id = m.get('sessionId')
        return self


class CloseHumanSessionResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        body: CloseHumanSessionResponseBody = None,
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
            temp_model = CloseHumanSessionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


