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
        return self


class AddKnowledgeResponseBodyResult(TeaModel):
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


class AddKnowledgeResponseBody(TeaModel):
    def __init__(
        self,
        result: AddKnowledgeResponseBodyResult = None,
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
            temp_model = AddKnowledgeResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
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


