# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List


class AddContactMemberToGroupHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class AddContactMemberToGroupRequest(TeaModel):
    def __init__(
        self,
        fission_type: str = None,
        member_union_id: str = None,
        member_user_id: str = None,
        open_conversation_id: str = None,
        open_team_id: str = None,
    ):
        self.fission_type = fission_type
        self.member_union_id = member_union_id
        self.member_user_id = member_user_id
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.open_team_id = open_team_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.fission_type is not None:
            result['fissionType'] = self.fission_type
        if self.member_union_id is not None:
            result['memberUnionId'] = self.member_union_id
        if self.member_user_id is not None:
            result['memberUserId'] = self.member_user_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fissionType') is not None:
            self.fission_type = m.get('fissionType')
        if m.get('memberUnionId') is not None:
            self.member_union_id = m.get('memberUnionId')
        if m.get('memberUserId') is not None:
            self.member_user_id = m.get('memberUserId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        return self


class AddContactMemberToGroupResponseBody(TeaModel):
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


class AddContactMemberToGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AddContactMemberToGroupResponseBody = None,
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
            temp_model = AddContactMemberToGroupResponseBody()
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


class AddKnowledgeRequestAttachmentList(TeaModel):
    def __init__(
        self,
        mime_type: str = None,
        path: str = None,
        size: int = None,
        suffix: str = None,
        title: str = None,
    ):
        self.mime_type = mime_type
        self.path = path
        self.size = size
        self.suffix = suffix
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.mime_type is not None:
            result['mime_type'] = self.mime_type
        if self.path is not None:
            result['path'] = self.path
        if self.size is not None:
            result['size'] = self.size
        if self.suffix is not None:
            result['suffix'] = self.suffix
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('mime_type') is not None:
            self.mime_type = m.get('mime_type')
        if m.get('path') is not None:
            self.path = m.get('path')
        if m.get('size') is not None:
            self.size = m.get('size')
        if m.get('suffix') is not None:
            self.suffix = m.get('suffix')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class AddKnowledgeRequest(TeaModel):
    def __init__(
        self,
        attachment_list: List[AddKnowledgeRequestAttachmentList] = None,
        content: str = None,
        effect_timeend: int = None,
        effect_timestart: int = None,
        ext_title: str = None,
        keyword: str = None,
        library_key: str = None,
        link_url: str = None,
        open_team_id: str = None,
        question_ids: List[int] = None,
        source: str = None,
        source_primary_key: str = None,
        title: str = None,
        type: str = None,
        version: str = None,
    ):
        self.attachment_list = attachment_list
        self.content = content
        self.effect_timeend = effect_timeend
        self.effect_timestart = effect_timestart
        self.ext_title = ext_title
        self.keyword = keyword
        self.library_key = library_key
        self.link_url = link_url
        self.open_team_id = open_team_id
        self.question_ids = question_ids
        self.source = source
        self.source_primary_key = source_primary_key
        self.title = title
        self.type = type
        self.version = version

    def validate(self):
        if self.attachment_list:
            for k in self.attachment_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['attachmentList'] = []
        if self.attachment_list is not None:
            for k in self.attachment_list:
                result['attachmentList'].append(k.to_map() if k else None)
        if self.content is not None:
            result['content'] = self.content
        if self.effect_timeend is not None:
            result['effectTimeend'] = self.effect_timeend
        if self.effect_timestart is not None:
            result['effectTimestart'] = self.effect_timestart
        if self.ext_title is not None:
            result['extTitle'] = self.ext_title
        if self.keyword is not None:
            result['keyword'] = self.keyword
        if self.library_key is not None:
            result['libraryKey'] = self.library_key
        if self.link_url is not None:
            result['linkUrl'] = self.link_url
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.question_ids is not None:
            result['questionIds'] = self.question_ids
        if self.source is not None:
            result['source'] = self.source
        if self.source_primary_key is not None:
            result['sourcePrimaryKey'] = self.source_primary_key
        if self.title is not None:
            result['title'] = self.title
        if self.type is not None:
            result['type'] = self.type
        if self.version is not None:
            result['version'] = self.version
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attachment_list = []
        if m.get('attachmentList') is not None:
            for k in m.get('attachmentList'):
                temp_model = AddKnowledgeRequestAttachmentList()
                self.attachment_list.append(temp_model.from_map(k))
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('effectTimeend') is not None:
            self.effect_timeend = m.get('effectTimeend')
        if m.get('effectTimestart') is not None:
            self.effect_timestart = m.get('effectTimestart')
        if m.get('extTitle') is not None:
            self.ext_title = m.get('extTitle')
        if m.get('keyword') is not None:
            self.keyword = m.get('keyword')
        if m.get('libraryKey') is not None:
            self.library_key = m.get('libraryKey')
        if m.get('linkUrl') is not None:
            self.link_url = m.get('linkUrl')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('questionIds') is not None:
            self.question_ids = m.get('questionIds')
        if m.get('source') is not None:
            self.source = m.get('source')
        if m.get('sourcePrimaryKey') is not None:
            self.source_primary_key = m.get('sourcePrimaryKey')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('version') is not None:
            self.version = m.get('version')
        return self


class AddKnowledgeResponseBody(TeaModel):
    def __init__(
        self,
        open_knowledge_id: str = None,
    ):
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
        status_code: int = None,
        body: AddKnowledgeResponseBody = None,
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
        description: str = None,
        open_team_ids: List[str] = None,
        source: str = None,
        source_primary_key: str = None,
        title: str = None,
        type: str = None,
        user_id: str = None,
    ):
        self.description = description
        self.open_team_ids = open_team_ids
        self.source = source
        self.source_primary_key = source_primary_key
        self.title = title
        self.type = type
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.description is not None:
            result['description'] = self.description
        if self.open_team_ids is not None:
            result['openTeamIds'] = self.open_team_ids
        if self.source is not None:
            result['source'] = self.source
        if self.source_primary_key is not None:
            result['sourcePrimaryKey'] = self.source_primary_key
        if self.title is not None:
            result['title'] = self.title
        if self.type is not None:
            result['type'] = self.type
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('openTeamIds') is not None:
            self.open_team_ids = m.get('openTeamIds')
        if m.get('source') is not None:
            self.source = m.get('source')
        if m.get('sourcePrimaryKey') is not None:
            self.source_primary_key = m.get('sourcePrimaryKey')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class AddLibraryResponseBody(TeaModel):
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


class AddLibraryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AddLibraryResponseBody = None,
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
            temp_model = AddLibraryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AddMemberToServiceGroupHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class AddMemberToServiceGroupRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        open_team_id: str = None,
        user_ids: List[str] = None,
    ):
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.open_team_id = open_team_id
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
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.user_ids is not None:
            result['userIds'] = self.user_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('userIds') is not None:
            self.user_ids = m.get('userIds')
        return self


class AddMemberToServiceGroupResponseBody(TeaModel):
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


class AddMemberToServiceGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AddMemberToServiceGroupResponseBody = None,
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
            temp_model = AddMemberToServiceGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AddOpenCategoryHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class AddOpenCategoryRequest(TeaModel):
    def __init__(
        self,
        library_id: int = None,
        open_team_id: str = None,
        parent_id: int = None,
        title: str = None,
        user_id: str = None,
        user_name: str = None,
    ):
        # This parameter is required.
        self.library_id = library_id
        # This parameter is required.
        self.open_team_id = open_team_id
        self.parent_id = parent_id
        # This parameter is required.
        self.title = title
        # This parameter is required.
        self.user_id = user_id
        # This parameter is required.
        self.user_name = user_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.library_id is not None:
            result['libraryId'] = self.library_id
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.parent_id is not None:
            result['parentId'] = self.parent_id
        if self.title is not None:
            result['title'] = self.title
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.user_name is not None:
            result['userName'] = self.user_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('libraryId') is not None:
            self.library_id = m.get('libraryId')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('parentId') is not None:
            self.parent_id = m.get('parentId')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('userName') is not None:
            self.user_name = m.get('userName')
        return self


class AddOpenCategoryResponseBodyResult(TeaModel):
    def __init__(
        self,
        id: int = None,
        message: str = None,
        success: bool = None,
    ):
        self.id = id
        self.message = message
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
        if self.message is not None:
            result['message'] = self.message
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('message') is not None:
            self.message = m.get('message')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class AddOpenCategoryResponseBody(TeaModel):
    def __init__(
        self,
        result: AddOpenCategoryResponseBodyResult = None,
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
            temp_model = AddOpenCategoryResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class AddOpenCategoryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AddOpenCategoryResponseBody = None,
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
            temp_model = AddOpenCategoryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AddOpenKnowledgeHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class AddOpenKnowledgeRequestAttachments(TeaModel):
    def __init__(
        self,
        mime_type: str = None,
        path: str = None,
        size: float = None,
        suffix: str = None,
        title: str = None,
    ):
        self.mime_type = mime_type
        self.path = path
        self.size = size
        self.suffix = suffix
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.mime_type is not None:
            result['mimeType'] = self.mime_type
        if self.path is not None:
            result['path'] = self.path
        if self.size is not None:
            result['size'] = self.size
        if self.suffix is not None:
            result['suffix'] = self.suffix
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('mimeType') is not None:
            self.mime_type = m.get('mimeType')
        if m.get('path') is not None:
            self.path = m.get('path')
        if m.get('size') is not None:
            self.size = m.get('size')
        if m.get('suffix') is not None:
            self.suffix = m.get('suffix')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class AddOpenKnowledgeRequest(TeaModel):
    def __init__(
        self,
        attachments: List[AddOpenKnowledgeRequestAttachments] = None,
        category_id: int = None,
        content: str = None,
        effect_timeend: str = None,
        effect_timestart: str = None,
        ext_title: str = None,
        keyword: str = None,
        library_id: int = None,
        open_team_id: str = None,
        source: str = None,
        tags: str = None,
        title: str = None,
        type: str = None,
        user_id: str = None,
        user_name: str = None,
    ):
        self.attachments = attachments
        # This parameter is required.
        self.category_id = category_id
        # This parameter is required.
        self.content = content
        self.effect_timeend = effect_timeend
        self.effect_timestart = effect_timestart
        # This parameter is required.
        self.ext_title = ext_title
        self.keyword = keyword
        # This parameter is required.
        self.library_id = library_id
        # This parameter is required.
        self.open_team_id = open_team_id
        # This parameter is required.
        self.source = source
        self.tags = tags
        # This parameter is required.
        self.title = title
        # This parameter is required.
        self.type = type
        # This parameter is required.
        self.user_id = user_id
        # This parameter is required.
        self.user_name = user_name

    def validate(self):
        if self.attachments:
            for k in self.attachments:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['attachments'] = []
        if self.attachments is not None:
            for k in self.attachments:
                result['attachments'].append(k.to_map() if k else None)
        if self.category_id is not None:
            result['categoryId'] = self.category_id
        if self.content is not None:
            result['content'] = self.content
        if self.effect_timeend is not None:
            result['effectTimeend'] = self.effect_timeend
        if self.effect_timestart is not None:
            result['effectTimestart'] = self.effect_timestart
        if self.ext_title is not None:
            result['extTitle'] = self.ext_title
        if self.keyword is not None:
            result['keyword'] = self.keyword
        if self.library_id is not None:
            result['libraryId'] = self.library_id
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.source is not None:
            result['source'] = self.source
        if self.tags is not None:
            result['tags'] = self.tags
        if self.title is not None:
            result['title'] = self.title
        if self.type is not None:
            result['type'] = self.type
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.user_name is not None:
            result['userName'] = self.user_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attachments = []
        if m.get('attachments') is not None:
            for k in m.get('attachments'):
                temp_model = AddOpenKnowledgeRequestAttachments()
                self.attachments.append(temp_model.from_map(k))
        if m.get('categoryId') is not None:
            self.category_id = m.get('categoryId')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('effectTimeend') is not None:
            self.effect_timeend = m.get('effectTimeend')
        if m.get('effectTimestart') is not None:
            self.effect_timestart = m.get('effectTimestart')
        if m.get('extTitle') is not None:
            self.ext_title = m.get('extTitle')
        if m.get('keyword') is not None:
            self.keyword = m.get('keyword')
        if m.get('libraryId') is not None:
            self.library_id = m.get('libraryId')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('source') is not None:
            self.source = m.get('source')
        if m.get('tags') is not None:
            self.tags = m.get('tags')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('userName') is not None:
            self.user_name = m.get('userName')
        return self


class AddOpenKnowledgeResponseBodyResult(TeaModel):
    def __init__(
        self,
        id: int = None,
        message: str = None,
        success: bool = None,
    ):
        self.id = id
        self.message = message
        # This parameter is required.
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
        if self.message is not None:
            result['message'] = self.message
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('message') is not None:
            self.message = m.get('message')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class AddOpenKnowledgeResponseBody(TeaModel):
    def __init__(
        self,
        result: AddOpenKnowledgeResponseBodyResult = None,
        success: bool = None,
    ):
        # This parameter is required.
        self.result = result
        # This parameter is required.
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
            temp_model = AddOpenKnowledgeResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class AddOpenKnowledgeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AddOpenKnowledgeResponseBody = None,
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
            temp_model = AddOpenKnowledgeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AddOpenLibraryHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class AddOpenLibraryRequest(TeaModel):
    def __init__(
        self,
        description: str = None,
        open_team_id: str = None,
        source: str = None,
        title: str = None,
        type: str = None,
        user_id: str = None,
        user_name: str = None,
    ):
        self.description = description
        # This parameter is required.
        self.open_team_id = open_team_id
        # This parameter is required.
        self.source = source
        # This parameter is required.
        self.title = title
        # This parameter is required.
        self.type = type
        # This parameter is required.
        self.user_id = user_id
        # This parameter is required.
        self.user_name = user_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.description is not None:
            result['description'] = self.description
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.source is not None:
            result['source'] = self.source
        if self.title is not None:
            result['title'] = self.title
        if self.type is not None:
            result['type'] = self.type
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.user_name is not None:
            result['userName'] = self.user_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('source') is not None:
            self.source = m.get('source')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('type') is not None:
            self.type = m.get('type')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('userName') is not None:
            self.user_name = m.get('userName')
        return self


class AddOpenLibraryResponseBodyResult(TeaModel):
    def __init__(
        self,
        id: int = None,
        message: str = None,
        success: bool = None,
    ):
        # This parameter is required.
        self.id = id
        self.message = message
        # This parameter is required.
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
        if self.message is not None:
            result['message'] = self.message
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('message') is not None:
            self.message = m.get('message')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class AddOpenLibraryResponseBody(TeaModel):
    def __init__(
        self,
        result: AddOpenLibraryResponseBodyResult = None,
        success: bool = None,
    ):
        # This parameter is required.
        self.result = result
        # This parameter is required.
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
            temp_model = AddOpenLibraryResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class AddOpenLibraryResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AddOpenLibraryResponseBody = None,
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
            temp_model = AddOpenLibraryResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class AddTicketMemoHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class AddTicketMemoRequestTicketMemoAttachments(TeaModel):
    def __init__(
        self,
        file_name: str = None,
        key: str = None,
    ):
        self.file_name = file_name
        self.key = key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.key is not None:
            result['key'] = self.key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('key') is not None:
            self.key = m.get('key')
        return self


class AddTicketMemoRequestTicketMemo(TeaModel):
    def __init__(
        self,
        attachments: List[AddTicketMemoRequestTicketMemoAttachments] = None,
        memo: str = None,
    ):
        self.attachments = attachments
        # This parameter is required.
        self.memo = memo

    def validate(self):
        if self.attachments:
            for k in self.attachments:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['attachments'] = []
        if self.attachments is not None:
            for k in self.attachments:
                result['attachments'].append(k.to_map() if k else None)
        if self.memo is not None:
            result['memo'] = self.memo
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attachments = []
        if m.get('attachments') is not None:
            for k in m.get('attachments'):
                temp_model = AddTicketMemoRequestTicketMemoAttachments()
                self.attachments.append(temp_model.from_map(k))
        if m.get('memo') is not None:
            self.memo = m.get('memo')
        return self


class AddTicketMemoRequest(TeaModel):
    def __init__(
        self,
        open_team_id: str = None,
        open_ticket_id: str = None,
        processor_union_id: str = None,
        ticket_memo: AddTicketMemoRequestTicketMemo = None,
    ):
        # This parameter is required.
        self.open_team_id = open_team_id
        # This parameter is required.
        self.open_ticket_id = open_ticket_id
        # This parameter is required.
        self.processor_union_id = processor_union_id
        self.ticket_memo = ticket_memo

    def validate(self):
        if self.ticket_memo:
            self.ticket_memo.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.open_ticket_id is not None:
            result['openTicketId'] = self.open_ticket_id
        if self.processor_union_id is not None:
            result['processorUnionId'] = self.processor_union_id
        if self.ticket_memo is not None:
            result['ticketMemo'] = self.ticket_memo.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('openTicketId') is not None:
            self.open_ticket_id = m.get('openTicketId')
        if m.get('processorUnionId') is not None:
            self.processor_union_id = m.get('processorUnionId')
        if m.get('ticketMemo') is not None:
            temp_model = AddTicketMemoRequestTicketMemo()
            self.ticket_memo = temp_model.from_map(m['ticketMemo'])
        return self


class AddTicketMemoResponse(TeaModel):
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


class AssignTicketHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class AssignTicketRequestNotify(TeaModel):
    def __init__(
        self,
        group_notice_receiver_union_ids: List[str] = None,
        notice_all_group_member: bool = None,
        work_notice_receiver_union_ids: List[str] = None,
    ):
        self.group_notice_receiver_union_ids = group_notice_receiver_union_ids
        self.notice_all_group_member = notice_all_group_member
        self.work_notice_receiver_union_ids = work_notice_receiver_union_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_notice_receiver_union_ids is not None:
            result['groupNoticeReceiverUnionIds'] = self.group_notice_receiver_union_ids
        if self.notice_all_group_member is not None:
            result['noticeAllGroupMember'] = self.notice_all_group_member
        if self.work_notice_receiver_union_ids is not None:
            result['workNoticeReceiverUnionIds'] = self.work_notice_receiver_union_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupNoticeReceiverUnionIds') is not None:
            self.group_notice_receiver_union_ids = m.get('groupNoticeReceiverUnionIds')
        if m.get('noticeAllGroupMember') is not None:
            self.notice_all_group_member = m.get('noticeAllGroupMember')
        if m.get('workNoticeReceiverUnionIds') is not None:
            self.work_notice_receiver_union_ids = m.get('workNoticeReceiverUnionIds')
        return self


class AssignTicketRequestTicketMemoAttachments(TeaModel):
    def __init__(
        self,
        file_name: str = None,
        key: str = None,
    ):
        self.file_name = file_name
        self.key = key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.key is not None:
            result['key'] = self.key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('key') is not None:
            self.key = m.get('key')
        return self


class AssignTicketRequestTicketMemo(TeaModel):
    def __init__(
        self,
        attachments: List[AssignTicketRequestTicketMemoAttachments] = None,
        memo: str = None,
    ):
        self.attachments = attachments
        # This parameter is required.
        self.memo = memo

    def validate(self):
        if self.attachments:
            for k in self.attachments:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['attachments'] = []
        if self.attachments is not None:
            for k in self.attachments:
                result['attachments'].append(k.to_map() if k else None)
        if self.memo is not None:
            result['memo'] = self.memo
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attachments = []
        if m.get('attachments') is not None:
            for k in m.get('attachments'):
                temp_model = AssignTicketRequestTicketMemoAttachments()
                self.attachments.append(temp_model.from_map(k))
        if m.get('memo') is not None:
            self.memo = m.get('memo')
        return self


class AssignTicketRequest(TeaModel):
    def __init__(
        self,
        notify: AssignTicketRequestNotify = None,
        open_team_id: str = None,
        open_ticket_id: str = None,
        operator_union_id: str = None,
        processor_union_ids: List[str] = None,
        ticket_memo: AssignTicketRequestTicketMemo = None,
    ):
        self.notify = notify
        # This parameter is required.
        self.open_team_id = open_team_id
        # This parameter is required.
        self.open_ticket_id = open_ticket_id
        # This parameter is required.
        self.operator_union_id = operator_union_id
        # This parameter is required.
        self.processor_union_ids = processor_union_ids
        self.ticket_memo = ticket_memo

    def validate(self):
        if self.notify:
            self.notify.validate()
        if self.ticket_memo:
            self.ticket_memo.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.notify is not None:
            result['notify'] = self.notify.to_map()
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.open_ticket_id is not None:
            result['openTicketId'] = self.open_ticket_id
        if self.operator_union_id is not None:
            result['operatorUnionId'] = self.operator_union_id
        if self.processor_union_ids is not None:
            result['processorUnionIds'] = self.processor_union_ids
        if self.ticket_memo is not None:
            result['ticketMemo'] = self.ticket_memo.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('notify') is not None:
            temp_model = AssignTicketRequestNotify()
            self.notify = temp_model.from_map(m['notify'])
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('openTicketId') is not None:
            self.open_ticket_id = m.get('openTicketId')
        if m.get('operatorUnionId') is not None:
            self.operator_union_id = m.get('operatorUnionId')
        if m.get('processorUnionIds') is not None:
            self.processor_union_ids = m.get('processorUnionIds')
        if m.get('ticketMemo') is not None:
            temp_model = AssignTicketRequestTicketMemo()
            self.ticket_memo = temp_model.from_map(m['ticketMemo'])
        return self


class AssignTicketResponse(TeaModel):
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


class BatchBindingGroupBizIdsHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class BatchBindingGroupBizIdsRequestBindingGroupBizIds(TeaModel):
    def __init__(
        self,
        biz_id: str = None,
        open_conversation_id: str = None,
    ):
        # This parameter is required.
        self.biz_id = biz_id
        # This parameter is required.
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_id is not None:
            result['bizId'] = self.biz_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class BatchBindingGroupBizIdsRequest(TeaModel):
    def __init__(
        self,
        binding_group_biz_ids: List[BatchBindingGroupBizIdsRequestBindingGroupBizIds] = None,
        open_team_id: str = None,
    ):
        # This parameter is required.
        self.binding_group_biz_ids = binding_group_biz_ids
        # This parameter is required.
        self.open_team_id = open_team_id

    def validate(self):
        if self.binding_group_biz_ids:
            for k in self.binding_group_biz_ids:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['bindingGroupBizIds'] = []
        if self.binding_group_biz_ids is not None:
            for k in self.binding_group_biz_ids:
                result['bindingGroupBizIds'].append(k.to_map() if k else None)
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.binding_group_biz_ids = []
        if m.get('bindingGroupBizIds') is not None:
            for k in m.get('bindingGroupBizIds'):
                temp_model = BatchBindingGroupBizIdsRequestBindingGroupBizIds()
                self.binding_group_biz_ids.append(temp_model.from_map(k))
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        return self


class BatchBindingGroupBizIdsResponseBody(TeaModel):
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


class BatchBindingGroupBizIdsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BatchBindingGroupBizIdsResponseBody = None,
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
            temp_model = BatchBindingGroupBizIdsResponseBody()
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
        config_keys: List[str] = None,
        open_group_set_id: str = None,
        open_team_id: str = None,
    ):
        # This parameter is required.
        self.config_keys = config_keys
        # This parameter is required.
        self.open_group_set_id = open_group_set_id
        # This parameter is required.
        self.open_team_id = open_team_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.config_keys is not None:
            result['configKeys'] = self.config_keys
        if self.open_group_set_id is not None:
            result['openGroupSetId'] = self.open_group_set_id
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('configKeys') is not None:
            self.config_keys = m.get('configKeys')
        if m.get('openGroupSetId') is not None:
            self.open_group_set_id = m.get('openGroupSetId')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        return self


class BatchGetGroupSetConfigResponseBodyGroupSetConfigs(TeaModel):
    def __init__(
        self,
        config_key: str = None,
        config_value: str = None,
    ):
        # This parameter is required.
        self.config_key = config_key
        # This parameter is required.
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
        status_code: int = None,
        body: BatchGetGroupSetConfigResponseBody = None,
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
            temp_model = BatchGetGroupSetConfigResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BatchQueryCustomerSendTaskHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class BatchQueryCustomerSendTaskRequest(TeaModel):
    def __init__(
        self,
        gmt_create_end: str = None,
        gmt_create_start: str = None,
        max_results: int = None,
        need_rich_statistics: bool = None,
        next_token: str = None,
        open_batch_task_ids: List[str] = None,
        open_team_id: str = None,
        task_name: str = None,
    ):
        self.gmt_create_end = gmt_create_end
        self.gmt_create_start = gmt_create_start
        self.max_results = max_results
        # This parameter is required.
        self.need_rich_statistics = need_rich_statistics
        self.next_token = next_token
        self.open_batch_task_ids = open_batch_task_ids
        # This parameter is required.
        self.open_team_id = open_team_id
        self.task_name = task_name

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
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.need_rich_statistics is not None:
            result['needRichStatistics'] = self.need_rich_statistics
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.open_batch_task_ids is not None:
            result['openBatchTaskIds'] = self.open_batch_task_ids
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.task_name is not None:
            result['taskName'] = self.task_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('gmtCreateEnd') is not None:
            self.gmt_create_end = m.get('gmtCreateEnd')
        if m.get('gmtCreateStart') is not None:
            self.gmt_create_start = m.get('gmtCreateStart')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('needRichStatistics') is not None:
            self.need_rich_statistics = m.get('needRichStatistics')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('openBatchTaskIds') is not None:
            self.open_batch_task_ids = m.get('openBatchTaskIds')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('taskName') is not None:
            self.task_name = m.get('taskName')
        return self


class BatchQueryCustomerSendTaskResponseBodyRecords(TeaModel):
    def __init__(
        self,
        create_name: str = None,
        create_time_str: str = None,
        create_union_id: str = None,
        open_batch_task_id: str = None,
        read_customer_inc: int = None,
        read_user_inc: int = None,
        send_customer_inc: int = None,
        send_message_status: str = None,
        send_task_time_str: str = None,
        send_user_inc: int = None,
        task_name: str = None,
    ):
        self.create_name = create_name
        self.create_time_str = create_time_str
        self.create_union_id = create_union_id
        self.open_batch_task_id = open_batch_task_id
        self.read_customer_inc = read_customer_inc
        self.read_user_inc = read_user_inc
        self.send_customer_inc = send_customer_inc
        self.send_message_status = send_message_status
        self.send_task_time_str = send_task_time_str
        self.send_user_inc = send_user_inc
        self.task_name = task_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_name is not None:
            result['createName'] = self.create_name
        if self.create_time_str is not None:
            result['createTimeStr'] = self.create_time_str
        if self.create_union_id is not None:
            result['createUnionId'] = self.create_union_id
        if self.open_batch_task_id is not None:
            result['openBatchTaskId'] = self.open_batch_task_id
        if self.read_customer_inc is not None:
            result['readCustomerInc'] = self.read_customer_inc
        if self.read_user_inc is not None:
            result['readUserInc'] = self.read_user_inc
        if self.send_customer_inc is not None:
            result['sendCustomerInc'] = self.send_customer_inc
        if self.send_message_status is not None:
            result['sendMessageStatus'] = self.send_message_status
        if self.send_task_time_str is not None:
            result['sendTaskTimeStr'] = self.send_task_time_str
        if self.send_user_inc is not None:
            result['sendUserInc'] = self.send_user_inc
        if self.task_name is not None:
            result['taskName'] = self.task_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createName') is not None:
            self.create_name = m.get('createName')
        if m.get('createTimeStr') is not None:
            self.create_time_str = m.get('createTimeStr')
        if m.get('createUnionId') is not None:
            self.create_union_id = m.get('createUnionId')
        if m.get('openBatchTaskId') is not None:
            self.open_batch_task_id = m.get('openBatchTaskId')
        if m.get('readCustomerInc') is not None:
            self.read_customer_inc = m.get('readCustomerInc')
        if m.get('readUserInc') is not None:
            self.read_user_inc = m.get('readUserInc')
        if m.get('sendCustomerInc') is not None:
            self.send_customer_inc = m.get('sendCustomerInc')
        if m.get('sendMessageStatus') is not None:
            self.send_message_status = m.get('sendMessageStatus')
        if m.get('sendTaskTimeStr') is not None:
            self.send_task_time_str = m.get('sendTaskTimeStr')
        if m.get('sendUserInc') is not None:
            self.send_user_inc = m.get('sendUserInc')
        if m.get('taskName') is not None:
            self.task_name = m.get('taskName')
        return self


class BatchQueryCustomerSendTaskResponseBody(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        records: List[BatchQueryCustomerSendTaskResponseBodyRecords] = None,
        total_count: int = None,
    ):
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
        self.next_token = next_token
        self.records = records
        # This parameter is required.
        self.total_count = total_count

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
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['records'] = []
        if self.records is not None:
            for k in self.records:
                result['records'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.records = []
        if m.get('records') is not None:
            for k in m.get('records'):
                temp_model = BatchQueryCustomerSendTaskResponseBodyRecords()
                self.records.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class BatchQueryCustomerSendTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BatchQueryCustomerSendTaskResponseBody = None,
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
            temp_model = BatchQueryCustomerSendTaskResponseBody()
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
        max_results: int = None,
        next_token: str = None,
        open_conversation_id: str = None,
        open_team_id: str = None,
    ):
        # This parameter is required.
        self.max_results = max_results
        self.next_token = next_token
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.open_team_id = open_team_id

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
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        return self


class BatchQueryGroupMemberResponseBodyRecords(TeaModel):
    def __init__(
        self,
        inner_staff: bool = None,
        nick_name: str = None,
        owner: bool = None,
        union_id: str = None,
        user_id: str = None,
    ):
        self.inner_staff = inner_staff
        self.nick_name = nick_name
        self.owner = owner
        self.union_id = union_id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.inner_staff is not None:
            result['innerStaff'] = self.inner_staff
        if self.nick_name is not None:
            result['nickName'] = self.nick_name
        if self.owner is not None:
            result['owner'] = self.owner
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('innerStaff') is not None:
            self.inner_staff = m.get('innerStaff')
        if m.get('nickName') is not None:
            self.nick_name = m.get('nickName')
        if m.get('owner') is not None:
            self.owner = m.get('owner')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class BatchQueryGroupMemberResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        next_token: str = None,
        open_conversation_id: str = None,
        records: List[BatchQueryGroupMemberResponseBodyRecords] = None,
    ):
        self.has_more = has_more
        self.next_token = next_token
        self.open_conversation_id = open_conversation_id
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
        if self.has_more is not None:
            result['hasMore'] = self.has_more
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        result['records'] = []
        if self.records is not None:
            for k in self.records:
                result['records'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        self.records = []
        if m.get('records') is not None:
            for k in m.get('records'):
                temp_model = BatchQueryGroupMemberResponseBodyRecords()
                self.records.append(temp_model.from_map(k))
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


class BatchQuerySendMessageTaskHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class BatchQuerySendMessageTaskRequest(TeaModel):
    def __init__(
        self,
        get_read_count: bool = None,
        gmt_create_end: str = None,
        gmt_create_start: str = None,
        max_results: int = None,
        next_token: str = None,
        open_group_set_id: str = None,
        open_team_id: str = None,
        task_name: str = None,
    ):
        self.get_read_count = get_read_count
        self.gmt_create_end = gmt_create_end
        self.gmt_create_start = gmt_create_start
        self.max_results = max_results
        self.next_token = next_token
        self.open_group_set_id = open_group_set_id
        # This parameter is required.
        self.open_team_id = open_team_id
        self.task_name = task_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.get_read_count is not None:
            result['getReadCount'] = self.get_read_count
        if self.gmt_create_end is not None:
            result['gmtCreateEnd'] = self.gmt_create_end
        if self.gmt_create_start is not None:
            result['gmtCreateStart'] = self.gmt_create_start
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.open_group_set_id is not None:
            result['openGroupSetId'] = self.open_group_set_id
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.task_name is not None:
            result['taskName'] = self.task_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('getReadCount') is not None:
            self.get_read_count = m.get('getReadCount')
        if m.get('gmtCreateEnd') is not None:
            self.gmt_create_end = m.get('gmtCreateEnd')
        if m.get('gmtCreateStart') is not None:
            self.gmt_create_start = m.get('gmtCreateStart')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('openGroupSetId') is not None:
            self.open_group_set_id = m.get('openGroupSetId')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('taskName') is not None:
            self.task_name = m.get('taskName')
        return self


class BatchQuerySendMessageTaskResponseBodyRecords(TeaModel):
    def __init__(
        self,
        create_name: str = None,
        create_time_str: str = None,
        create_union_id: str = None,
        open_batch_task_id: str = None,
        read_group_inc: int = None,
        send_group_inc: int = None,
        send_message_status: str = None,
        send_task_time_str: str = None,
        task_name: str = None,
    ):
        self.create_name = create_name
        self.create_time_str = create_time_str
        self.create_union_id = create_union_id
        self.open_batch_task_id = open_batch_task_id
        self.read_group_inc = read_group_inc
        self.send_group_inc = send_group_inc
        self.send_message_status = send_message_status
        # This parameter is required.
        self.send_task_time_str = send_task_time_str
        self.task_name = task_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_name is not None:
            result['createName'] = self.create_name
        if self.create_time_str is not None:
            result['createTimeStr'] = self.create_time_str
        if self.create_union_id is not None:
            result['createUnionId'] = self.create_union_id
        if self.open_batch_task_id is not None:
            result['openBatchTaskId'] = self.open_batch_task_id
        if self.read_group_inc is not None:
            result['readGroupInc'] = self.read_group_inc
        if self.send_group_inc is not None:
            result['sendGroupInc'] = self.send_group_inc
        if self.send_message_status is not None:
            result['sendMessageStatus'] = self.send_message_status
        if self.send_task_time_str is not None:
            result['sendTaskTimeStr'] = self.send_task_time_str
        if self.task_name is not None:
            result['taskName'] = self.task_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createName') is not None:
            self.create_name = m.get('createName')
        if m.get('createTimeStr') is not None:
            self.create_time_str = m.get('createTimeStr')
        if m.get('createUnionId') is not None:
            self.create_union_id = m.get('createUnionId')
        if m.get('openBatchTaskId') is not None:
            self.open_batch_task_id = m.get('openBatchTaskId')
        if m.get('readGroupInc') is not None:
            self.read_group_inc = m.get('readGroupInc')
        if m.get('sendGroupInc') is not None:
            self.send_group_inc = m.get('sendGroupInc')
        if m.get('sendMessageStatus') is not None:
            self.send_message_status = m.get('sendMessageStatus')
        if m.get('sendTaskTimeStr') is not None:
            self.send_task_time_str = m.get('sendTaskTimeStr')
        if m.get('taskName') is not None:
            self.task_name = m.get('taskName')
        return self


class BatchQuerySendMessageTaskResponseBody(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        records: List[BatchQuerySendMessageTaskResponseBodyRecords] = None,
        total_count: float = None,
    ):
        self.max_results = max_results
        self.next_token = next_token
        self.records = records
        self.total_count = total_count

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
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['records'] = []
        if self.records is not None:
            for k in self.records:
                result['records'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.records = []
        if m.get('records') is not None:
            for k in m.get('records'):
                temp_model = BatchQuerySendMessageTaskResponseBodyRecords()
                self.records.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class BatchQuerySendMessageTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BatchQuerySendMessageTaskResponseBody = None,
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
            temp_model = BatchQuerySendMessageTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class BoundTemplateToTeamHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class BoundTemplateToTeamRequest(TeaModel):
    def __init__(
        self,
        open_team_id: str = None,
        robot_config: str = None,
        template_desc: str = None,
        template_id: str = None,
        template_name: str = None,
        template_type: str = None,
    ):
        # This parameter is required.
        self.open_team_id = open_team_id
        # This parameter is required.
        self.robot_config = robot_config
        self.template_desc = template_desc
        # This parameter is required.
        self.template_id = template_id
        # This parameter is required.
        self.template_name = template_name
        # This parameter is required.
        self.template_type = template_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.robot_config is not None:
            result['robotConfig'] = self.robot_config
        if self.template_desc is not None:
            result['templateDesc'] = self.template_desc
        if self.template_id is not None:
            result['templateId'] = self.template_id
        if self.template_name is not None:
            result['templateName'] = self.template_name
        if self.template_type is not None:
            result['templateType'] = self.template_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('robotConfig') is not None:
            self.robot_config = m.get('robotConfig')
        if m.get('templateDesc') is not None:
            self.template_desc = m.get('templateDesc')
        if m.get('templateId') is not None:
            self.template_id = m.get('templateId')
        if m.get('templateName') is not None:
            self.template_name = m.get('templateName')
        if m.get('templateType') is not None:
            self.template_type = m.get('templateType')
        return self


class BoundTemplateToTeamResponseBody(TeaModel):
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


class BoundTemplateToTeamResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: BoundTemplateToTeamResponseBody = None,
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
            temp_model = BoundTemplateToTeamResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CancelTicketHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class CancelTicketRequestNotify(TeaModel):
    def __init__(
        self,
        group_notice_receiver_union_ids: List[str] = None,
        notice_all_group_member: bool = None,
        work_notice_receiver_union_ids: List[str] = None,
    ):
        self.group_notice_receiver_union_ids = group_notice_receiver_union_ids
        self.notice_all_group_member = notice_all_group_member
        self.work_notice_receiver_union_ids = work_notice_receiver_union_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_notice_receiver_union_ids is not None:
            result['groupNoticeReceiverUnionIds'] = self.group_notice_receiver_union_ids
        if self.notice_all_group_member is not None:
            result['noticeAllGroupMember'] = self.notice_all_group_member
        if self.work_notice_receiver_union_ids is not None:
            result['workNoticeReceiverUnionIds'] = self.work_notice_receiver_union_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupNoticeReceiverUnionIds') is not None:
            self.group_notice_receiver_union_ids = m.get('groupNoticeReceiverUnionIds')
        if m.get('noticeAllGroupMember') is not None:
            self.notice_all_group_member = m.get('noticeAllGroupMember')
        if m.get('workNoticeReceiverUnionIds') is not None:
            self.work_notice_receiver_union_ids = m.get('workNoticeReceiverUnionIds')
        return self


class CancelTicketRequestTicketMemoAttachments(TeaModel):
    def __init__(
        self,
        file_name: str = None,
        key: str = None,
    ):
        self.file_name = file_name
        self.key = key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.key is not None:
            result['key'] = self.key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('key') is not None:
            self.key = m.get('key')
        return self


class CancelTicketRequestTicketMemo(TeaModel):
    def __init__(
        self,
        attachments: List[CancelTicketRequestTicketMemoAttachments] = None,
        memo: str = None,
    ):
        self.attachments = attachments
        self.memo = memo

    def validate(self):
        if self.attachments:
            for k in self.attachments:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['attachments'] = []
        if self.attachments is not None:
            for k in self.attachments:
                result['attachments'].append(k.to_map() if k else None)
        if self.memo is not None:
            result['memo'] = self.memo
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attachments = []
        if m.get('attachments') is not None:
            for k in m.get('attachments'):
                temp_model = CancelTicketRequestTicketMemoAttachments()
                self.attachments.append(temp_model.from_map(k))
        if m.get('memo') is not None:
            self.memo = m.get('memo')
        return self


class CancelTicketRequest(TeaModel):
    def __init__(
        self,
        notify: CancelTicketRequestNotify = None,
        open_team_id: str = None,
        open_ticket_id: str = None,
        operator_union_id: str = None,
        ticket_memo: CancelTicketRequestTicketMemo = None,
    ):
        self.notify = notify
        # This parameter is required.
        self.open_team_id = open_team_id
        # This parameter is required.
        self.open_ticket_id = open_ticket_id
        self.operator_union_id = operator_union_id
        self.ticket_memo = ticket_memo

    def validate(self):
        if self.notify:
            self.notify.validate()
        if self.ticket_memo:
            self.ticket_memo.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.notify is not None:
            result['notify'] = self.notify.to_map()
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.open_ticket_id is not None:
            result['openTicketId'] = self.open_ticket_id
        if self.operator_union_id is not None:
            result['operatorUnionId'] = self.operator_union_id
        if self.ticket_memo is not None:
            result['ticketMemo'] = self.ticket_memo.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('notify') is not None:
            temp_model = CancelTicketRequestNotify()
            self.notify = temp_model.from_map(m['notify'])
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('openTicketId') is not None:
            self.open_ticket_id = m.get('openTicketId')
        if m.get('operatorUnionId') is not None:
            self.operator_union_id = m.get('operatorUnionId')
        if m.get('ticketMemo') is not None:
            temp_model = CancelTicketRequestTicketMemo()
            self.ticket_memo = temp_model.from_map(m['ticketMemo'])
        return self


class CancelTicketResponse(TeaModel):
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


class CategoryStatisticsHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class CategoryStatisticsRequest(TeaModel):
    def __init__(
        self,
        max_dt: str = None,
        min_dt: str = None,
        open_team_id: str = None,
    ):
        # This parameter is required.
        self.max_dt = max_dt
        # This parameter is required.
        self.min_dt = min_dt
        # This parameter is required.
        self.open_team_id = open_team_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.max_dt is not None:
            result['maxDt'] = self.max_dt
        if self.min_dt is not None:
            result['minDt'] = self.min_dt
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxDt') is not None:
            self.max_dt = m.get('maxDt')
        if m.get('minDt') is not None:
            self.min_dt = m.get('minDt')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        return self


class CategoryStatisticsResponseBodyCategoryStatisticsRecords(TeaModel):
    def __init__(
        self,
        count: int = None,
        last_count: int = None,
        name: str = None,
    ):
        # This parameter is required.
        self.count = count
        # This parameter is required.
        self.last_count = last_count
        # This parameter is required.
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.count is not None:
            result['count'] = self.count
        if self.last_count is not None:
            result['lastCount'] = self.last_count
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('count') is not None:
            self.count = m.get('count')
        if m.get('lastCount') is not None:
            self.last_count = m.get('lastCount')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class CategoryStatisticsResponseBodyCategoryTrend(TeaModel):
    def __init__(
        self,
        count: int = None,
        dt: str = None,
        name: str = None,
    ):
        # This parameter is required.
        self.count = count
        # This parameter is required.
        self.dt = dt
        # This parameter is required.
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.count is not None:
            result['count'] = self.count
        if self.dt is not None:
            result['dt'] = self.dt
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('count') is not None:
            self.count = m.get('count')
        if m.get('dt') is not None:
            self.dt = m.get('dt')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class CategoryStatisticsResponseBody(TeaModel):
    def __init__(
        self,
        category_statistics_records: List[CategoryStatisticsResponseBodyCategoryStatisticsRecords] = None,
        category_trend: List[CategoryStatisticsResponseBodyCategoryTrend] = None,
    ):
        # This parameter is required.
        self.category_statistics_records = category_statistics_records
        # This parameter is required.
        self.category_trend = category_trend

    def validate(self):
        if self.category_statistics_records:
            for k in self.category_statistics_records:
                if k:
                    k.validate()
        if self.category_trend:
            for k in self.category_trend:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['categoryStatisticsRecords'] = []
        if self.category_statistics_records is not None:
            for k in self.category_statistics_records:
                result['categoryStatisticsRecords'].append(k.to_map() if k else None)
        result['categoryTrend'] = []
        if self.category_trend is not None:
            for k in self.category_trend:
                result['categoryTrend'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.category_statistics_records = []
        if m.get('categoryStatisticsRecords') is not None:
            for k in m.get('categoryStatisticsRecords'):
                temp_model = CategoryStatisticsResponseBodyCategoryStatisticsRecords()
                self.category_statistics_records.append(temp_model.from_map(k))
        self.category_trend = []
        if m.get('categoryTrend') is not None:
            for k in m.get('categoryTrend'):
                temp_model = CategoryStatisticsResponseBodyCategoryTrend()
                self.category_trend.append(temp_model.from_map(k))
        return self


class CategoryStatisticsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CategoryStatisticsResponseBody = None,
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
            temp_model = CategoryStatisticsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CloseConversationHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class CloseConversationRequest(TeaModel):
    def __init__(
        self,
        conversation_id: str = None,
        open_team_id: str = None,
        server_tips: str = None,
        service_token: str = None,
        target_channel: str = None,
        visitor_token: str = None,
    ):
        self.conversation_id = conversation_id
        self.open_team_id = open_team_id
        self.server_tips = server_tips
        self.service_token = service_token
        self.target_channel = target_channel
        self.visitor_token = visitor_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conversation_id is not None:
            result['conversationId'] = self.conversation_id
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.server_tips is not None:
            result['serverTips'] = self.server_tips
        if self.service_token is not None:
            result['serviceToken'] = self.service_token
        if self.target_channel is not None:
            result['targetChannel'] = self.target_channel
        if self.visitor_token is not None:
            result['visitorToken'] = self.visitor_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conversationId') is not None:
            self.conversation_id = m.get('conversationId')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('serverTips') is not None:
            self.server_tips = m.get('serverTips')
        if m.get('serviceToken') is not None:
            self.service_token = m.get('serviceToken')
        if m.get('targetChannel') is not None:
            self.target_channel = m.get('targetChannel')
        if m.get('visitorToken') is not None:
            self.visitor_token = m.get('visitorToken')
        return self


class CloseConversationResponseBody(TeaModel):
    def __init__(
        self,
        ding_open_errcode: int = None,
        error_msg: str = None,
        result: bool = None,
        success: bool = None,
    ):
        self.ding_open_errcode = ding_open_errcode
        self.error_msg = error_msg
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_open_errcode is not None:
            result['dingOpenErrcode'] = self.ding_open_errcode
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingOpenErrcode') is not None:
            self.ding_open_errcode = m.get('dingOpenErrcode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class CloseConversationResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CloseConversationResponseBody = None,
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
            temp_model = CloseConversationResponseBody()
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
        open_conversation_id: str = None,
        open_team_id: str = None,
    ):
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.open_team_id = open_team_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        return self


class CloseHumanSessionResponseBody(TeaModel):
    def __init__(
        self,
        session_id: int = None,
    ):
        # This parameter is required.
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
        status_code: int = None,
        body: CloseHumanSessionResponseBody = None,
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
            temp_model = CloseHumanSessionResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ConversationCreatedNotifyHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class ConversationCreatedNotifyRequest(TeaModel):
    def __init__(
        self,
        alipay_user_id: str = None,
        conversation_id: str = None,
        nick_name: str = None,
        open_team_id: str = None,
        server_name: str = None,
        server_tips: str = None,
        service_token: str = None,
        timeout_remind_tips: str = None,
        user_id: str = None,
        visitor_token: str = None,
    ):
        self.alipay_user_id = alipay_user_id
        self.conversation_id = conversation_id
        self.nick_name = nick_name
        self.open_team_id = open_team_id
        self.server_name = server_name
        self.server_tips = server_tips
        self.service_token = service_token
        self.timeout_remind_tips = timeout_remind_tips
        self.user_id = user_id
        self.visitor_token = visitor_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.alipay_user_id is not None:
            result['alipayUserId'] = self.alipay_user_id
        if self.conversation_id is not None:
            result['conversationId'] = self.conversation_id
        if self.nick_name is not None:
            result['nickName'] = self.nick_name
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.server_name is not None:
            result['serverName'] = self.server_name
        if self.server_tips is not None:
            result['serverTips'] = self.server_tips
        if self.service_token is not None:
            result['serviceToken'] = self.service_token
        if self.timeout_remind_tips is not None:
            result['timeoutRemindTips'] = self.timeout_remind_tips
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.visitor_token is not None:
            result['visitorToken'] = self.visitor_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('alipayUserId') is not None:
            self.alipay_user_id = m.get('alipayUserId')
        if m.get('conversationId') is not None:
            self.conversation_id = m.get('conversationId')
        if m.get('nickName') is not None:
            self.nick_name = m.get('nickName')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('serverName') is not None:
            self.server_name = m.get('serverName')
        if m.get('serverTips') is not None:
            self.server_tips = m.get('serverTips')
        if m.get('serviceToken') is not None:
            self.service_token = m.get('serviceToken')
        if m.get('timeoutRemindTips') is not None:
            self.timeout_remind_tips = m.get('timeoutRemindTips')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('visitorToken') is not None:
            self.visitor_token = m.get('visitorToken')
        return self


class ConversationCreatedNotifyResponseBody(TeaModel):
    def __init__(
        self,
        ding_open_errcode: int = None,
        error_msg: str = None,
        result: bool = None,
        success: bool = None,
    ):
        self.ding_open_errcode = ding_open_errcode
        self.error_msg = error_msg
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_open_errcode is not None:
            result['dingOpenErrcode'] = self.ding_open_errcode
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingOpenErrcode') is not None:
            self.ding_open_errcode = m.get('dingOpenErrcode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class ConversationCreatedNotifyResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ConversationCreatedNotifyResponseBody = None,
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
            temp_model = ConversationCreatedNotifyResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ConversationTransferBeginNotifyHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class ConversationTransferBeginNotifyRequest(TeaModel):
    def __init__(
        self,
        conversation_id: str = None,
        memo: str = None,
        open_team_id: str = None,
        service_token: str = None,
        source_skill_group_id: str = None,
        target_skill_group_id: str = None,
    ):
        self.conversation_id = conversation_id
        self.memo = memo
        self.open_team_id = open_team_id
        self.service_token = service_token
        self.source_skill_group_id = source_skill_group_id
        self.target_skill_group_id = target_skill_group_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.conversation_id is not None:
            result['conversationId'] = self.conversation_id
        if self.memo is not None:
            result['memo'] = self.memo
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.service_token is not None:
            result['serviceToken'] = self.service_token
        if self.source_skill_group_id is not None:
            result['sourceSkillGroupId'] = self.source_skill_group_id
        if self.target_skill_group_id is not None:
            result['targetSkillGroupId'] = self.target_skill_group_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('conversationId') is not None:
            self.conversation_id = m.get('conversationId')
        if m.get('memo') is not None:
            self.memo = m.get('memo')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('serviceToken') is not None:
            self.service_token = m.get('serviceToken')
        if m.get('sourceSkillGroupId') is not None:
            self.source_skill_group_id = m.get('sourceSkillGroupId')
        if m.get('targetSkillGroupId') is not None:
            self.target_skill_group_id = m.get('targetSkillGroupId')
        return self


class ConversationTransferBeginNotifyResponseBody(TeaModel):
    def __init__(
        self,
        ding_open_errcode: int = None,
        error_msg: str = None,
        result: bool = None,
        success: bool = None,
    ):
        self.ding_open_errcode = ding_open_errcode
        self.error_msg = error_msg
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_open_errcode is not None:
            result['dingOpenErrcode'] = self.ding_open_errcode
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingOpenErrcode') is not None:
            self.ding_open_errcode = m.get('dingOpenErrcode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class ConversationTransferBeginNotifyResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ConversationTransferBeginNotifyResponseBody = None,
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
            temp_model = ConversationTransferBeginNotifyResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ConversationTransferCompleteNotifyHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class ConversationTransferCompleteNotifyRequest(TeaModel):
    def __init__(
        self,
        alipay_user_id: str = None,
        conversation_id: str = None,
        nick_name: str = None,
        open_team_id: str = None,
        service_token: str = None,
        user_id: str = None,
        visitor_token: str = None,
    ):
        self.alipay_user_id = alipay_user_id
        self.conversation_id = conversation_id
        self.nick_name = nick_name
        self.open_team_id = open_team_id
        self.service_token = service_token
        self.user_id = user_id
        self.visitor_token = visitor_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.alipay_user_id is not None:
            result['alipayUserId'] = self.alipay_user_id
        if self.conversation_id is not None:
            result['conversationId'] = self.conversation_id
        if self.nick_name is not None:
            result['nickName'] = self.nick_name
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.service_token is not None:
            result['serviceToken'] = self.service_token
        if self.user_id is not None:
            result['userId'] = self.user_id
        if self.visitor_token is not None:
            result['visitorToken'] = self.visitor_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('alipayUserId') is not None:
            self.alipay_user_id = m.get('alipayUserId')
        if m.get('conversationId') is not None:
            self.conversation_id = m.get('conversationId')
        if m.get('nickName') is not None:
            self.nick_name = m.get('nickName')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('serviceToken') is not None:
            self.service_token = m.get('serviceToken')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        if m.get('visitorToken') is not None:
            self.visitor_token = m.get('visitorToken')
        return self


class ConversationTransferCompleteNotifyResponseBody(TeaModel):
    def __init__(
        self,
        ding_open_errcode: int = None,
        error_msg: str = None,
        result: bool = None,
        success: bool = None,
    ):
        self.ding_open_errcode = ding_open_errcode
        self.error_msg = error_msg
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_open_errcode is not None:
            result['dingOpenErrcode'] = self.ding_open_errcode
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingOpenErrcode') is not None:
            self.ding_open_errcode = m.get('dingOpenErrcode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class ConversationTransferCompleteNotifyResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ConversationTransferCompleteNotifyResponseBody = None,
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
            temp_model = ConversationTransferCompleteNotifyResponseBody()
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
        group_name: str = None,
        group_tag_names: List[str] = None,
        member_staff_ids: List[str] = None,
        open_group_set_id: str = None,
        open_team_id: str = None,
        owner_staff_id: str = None,
    ):
        self.group_biz_id = group_biz_id
        # This parameter is required.
        self.group_name = group_name
        self.group_tag_names = group_tag_names
        self.member_staff_ids = member_staff_ids
        # This parameter is required.
        self.open_group_set_id = open_group_set_id
        # This parameter is required.
        self.open_team_id = open_team_id
        # This parameter is required.
        self.owner_staff_id = owner_staff_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_biz_id is not None:
            result['groupBizId'] = self.group_biz_id
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.group_tag_names is not None:
            result['groupTagNames'] = self.group_tag_names
        if self.member_staff_ids is not None:
            result['memberStaffIds'] = self.member_staff_ids
        if self.open_group_set_id is not None:
            result['openGroupSetId'] = self.open_group_set_id
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.owner_staff_id is not None:
            result['ownerStaffId'] = self.owner_staff_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupBizId') is not None:
            self.group_biz_id = m.get('groupBizId')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('groupTagNames') is not None:
            self.group_tag_names = m.get('groupTagNames')
        if m.get('memberStaffIds') is not None:
            self.member_staff_ids = m.get('memberStaffIds')
        if m.get('openGroupSetId') is not None:
            self.open_group_set_id = m.get('openGroupSetId')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('ownerStaffId') is not None:
            self.owner_staff_id = m.get('ownerStaffId')
        return self


class CreateGroupResponseBody(TeaModel):
    def __init__(
        self,
        group_url: str = None,
        open_conversation_id: str = None,
    ):
        # This parameter is required.
        self.group_url = group_url
        # This parameter is required.
        self.open_conversation_id = open_conversation_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_url is not None:
            result['groupUrl'] = self.group_url
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupUrl') is not None:
            self.group_url = m.get('groupUrl')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class CreateGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateGroupResponseBody = None,
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
            temp_model = CreateGroupResponseBody()
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
        corp_id: str = None,
        ding_group_id: str = None,
        ding_suite_key: str = None,
        ding_token_grant_type: int = None,
        ding_user_id: str = None,
        ding_user_name: str = None,
        ext_values: str = None,
        open_team_id: str = None,
        server_group_id: str = None,
    ):
        self.corp_id = corp_id
        self.ding_group_id = ding_group_id
        self.ding_suite_key = ding_suite_key
        self.ding_token_grant_type = ding_token_grant_type
        self.ding_user_id = ding_user_id
        self.ding_user_name = ding_user_name
        self.ext_values = ext_values
        self.open_team_id = open_team_id
        self.server_group_id = server_group_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.corp_id is not None:
            result['corpId'] = self.corp_id
        if self.ding_group_id is not None:
            result['dingGroupId'] = self.ding_group_id
        if self.ding_suite_key is not None:
            result['dingSuiteKey'] = self.ding_suite_key
        if self.ding_token_grant_type is not None:
            result['dingTokenGrantType'] = self.ding_token_grant_type
        if self.ding_user_id is not None:
            result['dingUserId'] = self.ding_user_id
        if self.ding_user_name is not None:
            result['dingUserName'] = self.ding_user_name
        if self.ext_values is not None:
            result['extValues'] = self.ext_values
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.server_group_id is not None:
            result['serverGroupId'] = self.server_group_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('corpId') is not None:
            self.corp_id = m.get('corpId')
        if m.get('dingGroupId') is not None:
            self.ding_group_id = m.get('dingGroupId')
        if m.get('dingSuiteKey') is not None:
            self.ding_suite_key = m.get('dingSuiteKey')
        if m.get('dingTokenGrantType') is not None:
            self.ding_token_grant_type = m.get('dingTokenGrantType')
        if m.get('dingUserId') is not None:
            self.ding_user_id = m.get('dingUserId')
        if m.get('dingUserName') is not None:
            self.ding_user_name = m.get('dingUserName')
        if m.get('extValues') is not None:
            self.ext_values = m.get('extValues')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('serverGroupId') is not None:
            self.server_group_id = m.get('serverGroupId')
        return self


class CreateGroupConversationResponseBody(TeaModel):
    def __init__(
        self,
        ding_open_errcode: int = None,
        error_msg: str = None,
        result: str = None,
        success: bool = None,
    ):
        self.ding_open_errcode = ding_open_errcode
        self.error_msg = error_msg
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_open_errcode is not None:
            result['dingOpenErrcode'] = self.ding_open_errcode
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingOpenErrcode') is not None:
            self.ding_open_errcode = m.get('dingOpenErrcode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
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


class CreateGroupSetHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class CreateGroupSetRequest(TeaModel):
    def __init__(
        self,
        group_set_name: str = None,
        group_template_id: str = None,
        open_team_id: str = None,
    ):
        # This parameter is required.
        self.group_set_name = group_set_name
        # This parameter is required.
        self.group_template_id = group_template_id
        # This parameter is required.
        self.open_team_id = open_team_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_set_name is not None:
            result['groupSetName'] = self.group_set_name
        if self.group_template_id is not None:
            result['groupTemplateId'] = self.group_template_id
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupSetName') is not None:
            self.group_set_name = m.get('groupSetName')
        if m.get('groupTemplateId') is not None:
            self.group_template_id = m.get('groupTemplateId')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        return self


class CreateGroupSetResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
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


class CreateGroupSetResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateGroupSetResponseBody = None,
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
            temp_model = CreateGroupSetResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateInstanceHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class CreateInstanceRequest(TeaModel):
    def __init__(
        self,
        channel: str = None,
        external_biz_id: str = None,
        form_code: str = None,
        form_data_list: str = None,
        open_team_id: str = None,
        operator_union_id: str = None,
        owner_union_id: str = None,
    ):
        self.channel = channel
        self.external_biz_id = external_biz_id
        # This parameter is required.
        self.form_code = form_code
        # This parameter is required.
        self.form_data_list = form_data_list
        # This parameter is required.
        self.open_team_id = open_team_id
        self.operator_union_id = operator_union_id
        self.owner_union_id = owner_union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.channel is not None:
            result['channel'] = self.channel
        if self.external_biz_id is not None:
            result['externalBizId'] = self.external_biz_id
        if self.form_code is not None:
            result['formCode'] = self.form_code
        if self.form_data_list is not None:
            result['formDataList'] = self.form_data_list
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.operator_union_id is not None:
            result['operatorUnionId'] = self.operator_union_id
        if self.owner_union_id is not None:
            result['ownerUnionId'] = self.owner_union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('channel') is not None:
            self.channel = m.get('channel')
        if m.get('externalBizId') is not None:
            self.external_biz_id = m.get('externalBizId')
        if m.get('formCode') is not None:
            self.form_code = m.get('formCode')
        if m.get('formDataList') is not None:
            self.form_data_list = m.get('formDataList')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('operatorUnionId') is not None:
            self.operator_union_id = m.get('operatorUnionId')
        if m.get('ownerUnionId') is not None:
            self.owner_union_id = m.get('ownerUnionId')
        return self


class CreateInstanceResponseBody(TeaModel):
    def __init__(
        self,
        open_data_instance_id: str = None,
    ):
        self.open_data_instance_id = open_data_instance_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_data_instance_id is not None:
            result['openDataInstanceId'] = self.open_data_instance_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openDataInstanceId') is not None:
            self.open_data_instance_id = m.get('openDataInstanceId')
        return self


class CreateInstanceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateInstanceResponseBody = None,
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
            temp_model = CreateInstanceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateTeamHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class CreateTeamRequest(TeaModel):
    def __init__(
        self,
        creator_ding_union_id: str = None,
        team_name: str = None,
    ):
        # This parameter is required.
        self.creator_ding_union_id = creator_ding_union_id
        # This parameter is required.
        self.team_name = team_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.creator_ding_union_id is not None:
            result['creatorDingUnionId'] = self.creator_ding_union_id
        if self.team_name is not None:
            result['teamName'] = self.team_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('creatorDingUnionId') is not None:
            self.creator_ding_union_id = m.get('creatorDingUnionId')
        if m.get('teamName') is not None:
            self.team_name = m.get('teamName')
        return self


class CreateTeamResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
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


class CreateTeamResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateTeamResponseBody = None,
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
            temp_model = CreateTeamResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateTicketHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class CreateTicketRequestNotify(TeaModel):
    def __init__(
        self,
        group_notice_receiver_union_ids: List[str] = None,
        notice_all_group_member: bool = None,
        work_notice_receiver_union_ids: List[str] = None,
    ):
        self.group_notice_receiver_union_ids = group_notice_receiver_union_ids
        self.notice_all_group_member = notice_all_group_member
        self.work_notice_receiver_union_ids = work_notice_receiver_union_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_notice_receiver_union_ids is not None:
            result['groupNoticeReceiverUnionIds'] = self.group_notice_receiver_union_ids
        if self.notice_all_group_member is not None:
            result['noticeAllGroupMember'] = self.notice_all_group_member
        if self.work_notice_receiver_union_ids is not None:
            result['workNoticeReceiverUnionIds'] = self.work_notice_receiver_union_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupNoticeReceiverUnionIds') is not None:
            self.group_notice_receiver_union_ids = m.get('groupNoticeReceiverUnionIds')
        if m.get('noticeAllGroupMember') is not None:
            self.notice_all_group_member = m.get('noticeAllGroupMember')
        if m.get('workNoticeReceiverUnionIds') is not None:
            self.work_notice_receiver_union_ids = m.get('workNoticeReceiverUnionIds')
        return self


class CreateTicketRequestSceneContextGroupMsgs(TeaModel):
    def __init__(
        self,
        anchor: bool = None,
        open_msg_id: str = None,
    ):
        self.anchor = anchor
        self.open_msg_id = open_msg_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.anchor is not None:
            result['anchor'] = self.anchor
        if self.open_msg_id is not None:
            result['openMsgId'] = self.open_msg_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('anchor') is not None:
            self.anchor = m.get('anchor')
        if m.get('openMsgId') is not None:
            self.open_msg_id = m.get('openMsgId')
        return self


class CreateTicketRequestSceneContext(TeaModel):
    def __init__(
        self,
        group_msgs: List[CreateTicketRequestSceneContextGroupMsgs] = None,
        open_conversation_id: str = None,
        relevantor_union_ids: List[str] = None,
        topic_id: str = None,
    ):
        self.group_msgs = group_msgs
        self.open_conversation_id = open_conversation_id
        self.relevantor_union_ids = relevantor_union_ids
        self.topic_id = topic_id

    def validate(self):
        if self.group_msgs:
            for k in self.group_msgs:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['groupMsgs'] = []
        if self.group_msgs is not None:
            for k in self.group_msgs:
                result['groupMsgs'].append(k.to_map() if k else None)
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.relevantor_union_ids is not None:
            result['relevantorUnionIds'] = self.relevantor_union_ids
        if self.topic_id is not None:
            result['topicId'] = self.topic_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.group_msgs = []
        if m.get('groupMsgs') is not None:
            for k in m.get('groupMsgs'):
                temp_model = CreateTicketRequestSceneContextGroupMsgs()
                self.group_msgs.append(temp_model.from_map(k))
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('relevantorUnionIds') is not None:
            self.relevantor_union_ids = m.get('relevantorUnionIds')
        if m.get('topicId') is not None:
            self.topic_id = m.get('topicId')
        return self


class CreateTicketRequest(TeaModel):
    def __init__(
        self,
        creator_union_id: str = None,
        custom_fields: str = None,
        notify: CreateTicketRequestNotify = None,
        open_team_id: str = None,
        open_template_biz_id: str = None,
        processor_union_ids: List[str] = None,
        scene: str = None,
        scene_context: CreateTicketRequestSceneContext = None,
        title: str = None,
    ):
        # This parameter is required.
        self.creator_union_id = creator_union_id
        self.custom_fields = custom_fields
        self.notify = notify
        # This parameter is required.
        self.open_team_id = open_team_id
        # This parameter is required.
        self.open_template_biz_id = open_template_biz_id
        # This parameter is required.
        self.processor_union_ids = processor_union_ids
        # This parameter is required.
        self.scene = scene
        self.scene_context = scene_context
        # This parameter is required.
        self.title = title

    def validate(self):
        if self.notify:
            self.notify.validate()
        if self.scene_context:
            self.scene_context.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.creator_union_id is not None:
            result['creatorUnionId'] = self.creator_union_id
        if self.custom_fields is not None:
            result['customFields'] = self.custom_fields
        if self.notify is not None:
            result['notify'] = self.notify.to_map()
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.open_template_biz_id is not None:
            result['openTemplateBizId'] = self.open_template_biz_id
        if self.processor_union_ids is not None:
            result['processorUnionIds'] = self.processor_union_ids
        if self.scene is not None:
            result['scene'] = self.scene
        if self.scene_context is not None:
            result['sceneContext'] = self.scene_context.to_map()
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('creatorUnionId') is not None:
            self.creator_union_id = m.get('creatorUnionId')
        if m.get('customFields') is not None:
            self.custom_fields = m.get('customFields')
        if m.get('notify') is not None:
            temp_model = CreateTicketRequestNotify()
            self.notify = temp_model.from_map(m['notify'])
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('openTemplateBizId') is not None:
            self.open_template_biz_id = m.get('openTemplateBizId')
        if m.get('processorUnionIds') is not None:
            self.processor_union_ids = m.get('processorUnionIds')
        if m.get('scene') is not None:
            self.scene = m.get('scene')
        if m.get('sceneContext') is not None:
            temp_model = CreateTicketRequestSceneContext()
            self.scene_context = temp_model.from_map(m['sceneContext'])
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class CreateTicketResponseBody(TeaModel):
    def __init__(
        self,
        open_ticket_id: str = None,
    ):
        self.open_ticket_id = open_ticket_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_ticket_id is not None:
            result['openTicketId'] = self.open_ticket_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openTicketId') is not None:
            self.open_ticket_id = m.get('openTicketId')
        return self


class CreateTicketResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateTicketResponseBody = None,
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
            temp_model = CreateTicketResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CustomerSendMsgTaskHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class CustomerSendMsgTaskRequestMessageContentBtns(TeaModel):
    def __init__(
        self,
        action_url: str = None,
        title: str = None,
    ):
        self.action_url = action_url
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


class CustomerSendMsgTaskRequestMessageContent(TeaModel):
    def __init__(
        self,
        btns: List[CustomerSendMsgTaskRequestMessageContentBtns] = None,
        content: str = None,
        message_type: str = None,
        title: str = None,
    ):
        self.btns = btns
        # This parameter is required.
        self.content = content
        # This parameter is required.
        self.message_type = message_type
        # This parameter is required.
        self.title = title

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
        result['btns'] = []
        if self.btns is not None:
            for k in self.btns:
                result['btns'].append(k.to_map() if k else None)
        if self.content is not None:
            result['content'] = self.content
        if self.message_type is not None:
            result['messageType'] = self.message_type
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.btns = []
        if m.get('btns') is not None:
            for k in m.get('btns'):
                temp_model = CustomerSendMsgTaskRequestMessageContentBtns()
                self.btns.append(temp_model.from_map(k))
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('messageType') is not None:
            self.message_type = m.get('messageType')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class CustomerSendMsgTaskRequestQueryCustomer(TeaModel):
    def __init__(
        self,
        open_contact_ids: List[str] = None,
        query_type: str = None,
        search_contact_conditions: str = None,
        search_customer_conditions: str = None,
    ):
        self.open_contact_ids = open_contact_ids
        self.query_type = query_type
        self.search_contact_conditions = search_contact_conditions
        self.search_customer_conditions = search_customer_conditions

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_contact_ids is not None:
            result['openContactIds'] = self.open_contact_ids
        if self.query_type is not None:
            result['queryType'] = self.query_type
        if self.search_contact_conditions is not None:
            result['searchContactConditions'] = self.search_contact_conditions
        if self.search_customer_conditions is not None:
            result['searchCustomerConditions'] = self.search_customer_conditions
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openContactIds') is not None:
            self.open_contact_ids = m.get('openContactIds')
        if m.get('queryType') is not None:
            self.query_type = m.get('queryType')
        if m.get('searchContactConditions') is not None:
            self.search_contact_conditions = m.get('searchContactConditions')
        if m.get('searchCustomerConditions') is not None:
            self.search_customer_conditions = m.get('searchCustomerConditions')
        return self


class CustomerSendMsgTaskRequestSendConfigUrlTrackConfig(TeaModel):
    def __init__(
        self,
        title: str = None,
        track_id: str = None,
        track_url: str = None,
    ):
        self.title = title
        self.track_id = track_id
        self.track_url = track_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.title is not None:
            result['title'] = self.title
        if self.track_id is not None:
            result['trackId'] = self.track_id
        if self.track_url is not None:
            result['trackUrl'] = self.track_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('trackId') is not None:
            self.track_id = m.get('trackId')
        if m.get('trackUrl') is not None:
            self.track_url = m.get('trackUrl')
        return self


class CustomerSendMsgTaskRequestSendConfig(TeaModel):
    def __init__(
        self,
        need_url_track: bool = None,
        send_time: str = None,
        send_type: str = None,
        url_track_config: List[CustomerSendMsgTaskRequestSendConfigUrlTrackConfig] = None,
    ):
        # This parameter is required.
        self.need_url_track = need_url_track
        self.send_time = send_time
        # This parameter is required.
        self.send_type = send_type
        self.url_track_config = url_track_config

    def validate(self):
        if self.url_track_config:
            for k in self.url_track_config:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.need_url_track is not None:
            result['needUrlTrack'] = self.need_url_track
        if self.send_time is not None:
            result['sendTime'] = self.send_time
        if self.send_type is not None:
            result['sendType'] = self.send_type
        result['urlTrackConfig'] = []
        if self.url_track_config is not None:
            for k in self.url_track_config:
                result['urlTrackConfig'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('needUrlTrack') is not None:
            self.need_url_track = m.get('needUrlTrack')
        if m.get('sendTime') is not None:
            self.send_time = m.get('sendTime')
        if m.get('sendType') is not None:
            self.send_type = m.get('sendType')
        self.url_track_config = []
        if m.get('urlTrackConfig') is not None:
            for k in m.get('urlTrackConfig'):
                temp_model = CustomerSendMsgTaskRequestSendConfigUrlTrackConfig()
                self.url_track_config.append(temp_model.from_map(k))
        return self


class CustomerSendMsgTaskRequest(TeaModel):
    def __init__(
        self,
        message_content: CustomerSendMsgTaskRequestMessageContent = None,
        open_team_id: str = None,
        query_customer: CustomerSendMsgTaskRequestQueryCustomer = None,
        send_config: CustomerSendMsgTaskRequestSendConfig = None,
        task_name: str = None,
    ):
        # This parameter is required.
        self.message_content = message_content
        # This parameter is required.
        self.open_team_id = open_team_id
        self.query_customer = query_customer
        self.send_config = send_config
        # This parameter is required.
        self.task_name = task_name

    def validate(self):
        if self.message_content:
            self.message_content.validate()
        if self.query_customer:
            self.query_customer.validate()
        if self.send_config:
            self.send_config.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.message_content is not None:
            result['messageContent'] = self.message_content.to_map()
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.query_customer is not None:
            result['queryCustomer'] = self.query_customer.to_map()
        if self.send_config is not None:
            result['sendConfig'] = self.send_config.to_map()
        if self.task_name is not None:
            result['taskName'] = self.task_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('messageContent') is not None:
            temp_model = CustomerSendMsgTaskRequestMessageContent()
            self.message_content = temp_model.from_map(m['messageContent'])
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('queryCustomer') is not None:
            temp_model = CustomerSendMsgTaskRequestQueryCustomer()
            self.query_customer = temp_model.from_map(m['queryCustomer'])
        if m.get('sendConfig') is not None:
            temp_model = CustomerSendMsgTaskRequestSendConfig()
            self.send_config = temp_model.from_map(m['sendConfig'])
        if m.get('taskName') is not None:
            self.task_name = m.get('taskName')
        return self


class CustomerSendMsgTaskResponseBody(TeaModel):
    def __init__(
        self,
        open_batch_task_id: str = None,
    ):
        self.open_batch_task_id = open_batch_task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_batch_task_id is not None:
            result['openBatchTaskId'] = self.open_batch_task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openBatchTaskId') is not None:
            self.open_batch_task_id = m.get('openBatchTaskId')
        return self


class CustomerSendMsgTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CustomerSendMsgTaskResponseBody = None,
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
            temp_model = CustomerSendMsgTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteGroupMembersFromGroupHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class DeleteGroupMembersFromGroupRequest(TeaModel):
    def __init__(
        self,
        delete_group_type: str = None,
        member_union_id: str = None,
        open_conversation_id: str = None,
        open_group_set_id: str = None,
        open_team_id: str = None,
    ):
        # This parameter is required.
        self.delete_group_type = delete_group_type
        # This parameter is required.
        self.member_union_id = member_union_id
        self.open_conversation_id = open_conversation_id
        self.open_group_set_id = open_group_set_id
        # This parameter is required.
        self.open_team_id = open_team_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.delete_group_type is not None:
            result['deleteGroupType'] = self.delete_group_type
        if self.member_union_id is not None:
            result['memberUnionId'] = self.member_union_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.open_group_set_id is not None:
            result['openGroupSetId'] = self.open_group_set_id
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deleteGroupType') is not None:
            self.delete_group_type = m.get('deleteGroupType')
        if m.get('memberUnionId') is not None:
            self.member_union_id = m.get('memberUnionId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('openGroupSetId') is not None:
            self.open_group_set_id = m.get('openGroupSetId')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        return self


class DeleteGroupMembersFromGroupResponseBody(TeaModel):
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


class DeleteGroupMembersFromGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteGroupMembersFromGroupResponseBody = None,
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
            temp_model = DeleteGroupMembersFromGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteInstanceHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class DeleteInstanceRequest(TeaModel):
    def __init__(
        self,
        form_code: str = None,
        open_data_instance_id: str = None,
        open_team_id: str = None,
        operator_union_id: str = None,
    ):
        # This parameter is required.
        self.form_code = form_code
        # This parameter is required.
        self.open_data_instance_id = open_data_instance_id
        # This parameter is required.
        self.open_team_id = open_team_id
        self.operator_union_id = operator_union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.form_code is not None:
            result['formCode'] = self.form_code
        if self.open_data_instance_id is not None:
            result['openDataInstanceId'] = self.open_data_instance_id
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.operator_union_id is not None:
            result['operatorUnionId'] = self.operator_union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('formCode') is not None:
            self.form_code = m.get('formCode')
        if m.get('openDataInstanceId') is not None:
            self.open_data_instance_id = m.get('openDataInstanceId')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('operatorUnionId') is not None:
            self.operator_union_id = m.get('operatorUnionId')
        return self


class DeleteInstanceResponseBody(TeaModel):
    def __init__(
        self,
        open_data_instance_id: str = None,
    ):
        self.open_data_instance_id = open_data_instance_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_data_instance_id is not None:
            result['openDataInstanceId'] = self.open_data_instance_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openDataInstanceId') is not None:
            self.open_data_instance_id = m.get('openDataInstanceId')
        return self


class DeleteInstanceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteInstanceResponseBody = None,
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
            temp_model = DeleteInstanceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


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
        library_key: str = None,
        open_team_id: str = None,
        source: str = None,
        source_primary_key: str = None,
    ):
        self.library_key = library_key
        self.open_team_id = open_team_id
        self.source = source
        self.source_primary_key = source_primary_key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.library_key is not None:
            result['libraryKey'] = self.library_key
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.source is not None:
            result['source'] = self.source
        if self.source_primary_key is not None:
            result['sourcePrimaryKey'] = self.source_primary_key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('libraryKey') is not None:
            self.library_key = m.get('libraryKey')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
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
        status_code: int = None,
        body: DeleteKnowledgeResponseBody = None,
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
            temp_model = DeleteKnowledgeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class EmotionStatisticsHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class EmotionStatisticsRequest(TeaModel):
    def __init__(
        self,
        max_dt: str = None,
        max_emotion: float = None,
        min_dt: str = None,
        min_emotion: float = None,
        open_conversation_ids: str = None,
        open_group_set_id: str = None,
        open_team_id: str = None,
    ):
        # This parameter is required.
        self.max_dt = max_dt
        self.max_emotion = max_emotion
        # This parameter is required.
        self.min_dt = min_dt
        self.min_emotion = min_emotion
        self.open_conversation_ids = open_conversation_ids
        self.open_group_set_id = open_group_set_id
        # This parameter is required.
        self.open_team_id = open_team_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.max_dt is not None:
            result['maxDt'] = self.max_dt
        if self.max_emotion is not None:
            result['maxEmotion'] = self.max_emotion
        if self.min_dt is not None:
            result['minDt'] = self.min_dt
        if self.min_emotion is not None:
            result['minEmotion'] = self.min_emotion
        if self.open_conversation_ids is not None:
            result['openConversationIds'] = self.open_conversation_ids
        if self.open_group_set_id is not None:
            result['openGroupSetId'] = self.open_group_set_id
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxDt') is not None:
            self.max_dt = m.get('maxDt')
        if m.get('maxEmotion') is not None:
            self.max_emotion = m.get('maxEmotion')
        if m.get('minDt') is not None:
            self.min_dt = m.get('minDt')
        if m.get('minEmotion') is not None:
            self.min_emotion = m.get('minEmotion')
        if m.get('openConversationIds') is not None:
            self.open_conversation_ids = m.get('openConversationIds')
        if m.get('openGroupSetId') is not None:
            self.open_group_set_id = m.get('openGroupSetId')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        return self


class EmotionStatisticsResponseBodyEmotionStatisticsRecords(TeaModel):
    def __init__(
        self,
        count: int = None,
        dt: str = None,
        emotion_score: float = None,
    ):
        # This parameter is required.
        self.count = count
        # This parameter is required.
        self.dt = dt
        # This parameter is required.
        self.emotion_score = emotion_score

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.count is not None:
            result['count'] = self.count
        if self.dt is not None:
            result['dt'] = self.dt
        if self.emotion_score is not None:
            result['emotionScore'] = self.emotion_score
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('count') is not None:
            self.count = m.get('count')
        if m.get('dt') is not None:
            self.dt = m.get('dt')
        if m.get('emotionScore') is not None:
            self.emotion_score = m.get('emotionScore')
        return self


class EmotionStatisticsResponseBody(TeaModel):
    def __init__(
        self,
        emotion_statistics_records: List[EmotionStatisticsResponseBodyEmotionStatisticsRecords] = None,
    ):
        # This parameter is required.
        self.emotion_statistics_records = emotion_statistics_records

    def validate(self):
        if self.emotion_statistics_records:
            for k in self.emotion_statistics_records:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['emotionStatisticsRecords'] = []
        if self.emotion_statistics_records is not None:
            for k in self.emotion_statistics_records:
                result['emotionStatisticsRecords'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.emotion_statistics_records = []
        if m.get('emotionStatisticsRecords') is not None:
            for k in m.get('emotionStatisticsRecords'):
                temp_model = EmotionStatisticsResponseBodyEmotionStatisticsRecords()
                self.emotion_statistics_records.append(temp_model.from_map(k))
        return self


class EmotionStatisticsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: EmotionStatisticsResponseBody = None,
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
            temp_model = EmotionStatisticsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class FinishTicketHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class FinishTicketRequestNotify(TeaModel):
    def __init__(
        self,
        group_notice_receiver_union_ids: List[str] = None,
        notice_all_group_member: bool = None,
        work_notice_receiver_union_ids: List[str] = None,
    ):
        self.group_notice_receiver_union_ids = group_notice_receiver_union_ids
        self.notice_all_group_member = notice_all_group_member
        self.work_notice_receiver_union_ids = work_notice_receiver_union_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_notice_receiver_union_ids is not None:
            result['groupNoticeReceiverUnionIds'] = self.group_notice_receiver_union_ids
        if self.notice_all_group_member is not None:
            result['noticeAllGroupMember'] = self.notice_all_group_member
        if self.work_notice_receiver_union_ids is not None:
            result['workNoticeReceiverUnionIds'] = self.work_notice_receiver_union_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupNoticeReceiverUnionIds') is not None:
            self.group_notice_receiver_union_ids = m.get('groupNoticeReceiverUnionIds')
        if m.get('noticeAllGroupMember') is not None:
            self.notice_all_group_member = m.get('noticeAllGroupMember')
        if m.get('workNoticeReceiverUnionIds') is not None:
            self.work_notice_receiver_union_ids = m.get('workNoticeReceiverUnionIds')
        return self


class FinishTicketRequestTicketMemoAttachments(TeaModel):
    def __init__(
        self,
        file_name: str = None,
        key: str = None,
    ):
        self.file_name = file_name
        self.key = key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.key is not None:
            result['key'] = self.key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('key') is not None:
            self.key = m.get('key')
        return self


class FinishTicketRequestTicketMemo(TeaModel):
    def __init__(
        self,
        attachments: List[FinishTicketRequestTicketMemoAttachments] = None,
        memo: str = None,
    ):
        self.attachments = attachments
        # This parameter is required.
        self.memo = memo

    def validate(self):
        if self.attachments:
            for k in self.attachments:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['attachments'] = []
        if self.attachments is not None:
            for k in self.attachments:
                result['attachments'].append(k.to_map() if k else None)
        if self.memo is not None:
            result['memo'] = self.memo
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attachments = []
        if m.get('attachments') is not None:
            for k in m.get('attachments'):
                temp_model = FinishTicketRequestTicketMemoAttachments()
                self.attachments.append(temp_model.from_map(k))
        if m.get('memo') is not None:
            self.memo = m.get('memo')
        return self


class FinishTicketRequest(TeaModel):
    def __init__(
        self,
        notify: FinishTicketRequestNotify = None,
        open_team_id: str = None,
        open_ticket_id: str = None,
        processor_union_id: str = None,
        ticket_memo: FinishTicketRequestTicketMemo = None,
    ):
        self.notify = notify
        # This parameter is required.
        self.open_team_id = open_team_id
        # This parameter is required.
        self.open_ticket_id = open_ticket_id
        # This parameter is required.
        self.processor_union_id = processor_union_id
        # This parameter is required.
        self.ticket_memo = ticket_memo

    def validate(self):
        if self.notify:
            self.notify.validate()
        if self.ticket_memo:
            self.ticket_memo.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.notify is not None:
            result['notify'] = self.notify.to_map()
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.open_ticket_id is not None:
            result['openTicketId'] = self.open_ticket_id
        if self.processor_union_id is not None:
            result['processorUnionId'] = self.processor_union_id
        if self.ticket_memo is not None:
            result['ticketMemo'] = self.ticket_memo.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('notify') is not None:
            temp_model = FinishTicketRequestNotify()
            self.notify = temp_model.from_map(m['notify'])
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('openTicketId') is not None:
            self.open_ticket_id = m.get('openTicketId')
        if m.get('processorUnionId') is not None:
            self.processor_union_id = m.get('processorUnionId')
        if m.get('ticketMemo') is not None:
            temp_model = FinishTicketRequestTicketMemo()
            self.ticket_memo = temp_model.from_map(m['ticketMemo'])
        return self


class FinishTicketResponse(TeaModel):
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


class GetAuthTokenHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetAuthTokenRequest(TeaModel):
    def __init__(
        self,
        channel: str = None,
        effective_time: int = None,
        open_team_id: str = None,
        server_id: str = None,
        server_name: str = None,
    ):
        self.channel = channel
        self.effective_time = effective_time
        self.open_team_id = open_team_id
        self.server_id = server_id
        self.server_name = server_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.channel is not None:
            result['channel'] = self.channel
        if self.effective_time is not None:
            result['effectiveTime'] = self.effective_time
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.server_id is not None:
            result['serverId'] = self.server_id
        if self.server_name is not None:
            result['serverName'] = self.server_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('channel') is not None:
            self.channel = m.get('channel')
        if m.get('effectiveTime') is not None:
            self.effective_time = m.get('effectiveTime')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('serverId') is not None:
            self.server_id = m.get('serverId')
        if m.get('serverName') is not None:
            self.server_name = m.get('serverName')
        return self


class GetAuthTokenResponseBodyResult(TeaModel):
    def __init__(
        self,
        auth_token: str = None,
        channel: str = None,
        effective_time: int = None,
        server_id: str = None,
        server_name: str = None,
    ):
        self.auth_token = auth_token
        self.channel = channel
        self.effective_time = effective_time
        self.server_id = server_id
        self.server_name = server_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.auth_token is not None:
            result['authToken'] = self.auth_token
        if self.channel is not None:
            result['channel'] = self.channel
        if self.effective_time is not None:
            result['effectiveTime'] = self.effective_time
        if self.server_id is not None:
            result['serverId'] = self.server_id
        if self.server_name is not None:
            result['serverName'] = self.server_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('authToken') is not None:
            self.auth_token = m.get('authToken')
        if m.get('channel') is not None:
            self.channel = m.get('channel')
        if m.get('effectiveTime') is not None:
            self.effective_time = m.get('effectiveTime')
        if m.get('serverId') is not None:
            self.server_id = m.get('serverId')
        if m.get('serverName') is not None:
            self.server_name = m.get('serverName')
        return self


class GetAuthTokenResponseBody(TeaModel):
    def __init__(
        self,
        ding_open_errcode: int = None,
        error_msg: str = None,
        result: GetAuthTokenResponseBodyResult = None,
        success: bool = None,
    ):
        self.ding_open_errcode = ding_open_errcode
        self.error_msg = error_msg
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
        if self.ding_open_errcode is not None:
            result['dingOpenErrcode'] = self.ding_open_errcode
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.result is not None:
            result['result'] = self.result.to_map()
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingOpenErrcode') is not None:
            self.ding_open_errcode = m.get('dingOpenErrcode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('result') is not None:
            temp_model = GetAuthTokenResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetAuthTokenResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetAuthTokenResponseBody = None,
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
            temp_model = GetAuthTokenResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetInstancesByIdsHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetInstancesByIdsRequest(TeaModel):
    def __init__(
        self,
        form_code: str = None,
        open_data_instance_id_list: List[str] = None,
        open_team_id: str = None,
    ):
        # This parameter is required.
        self.form_code = form_code
        # This parameter is required.
        self.open_data_instance_id_list = open_data_instance_id_list
        # This parameter is required.
        self.open_team_id = open_team_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.form_code is not None:
            result['formCode'] = self.form_code
        if self.open_data_instance_id_list is not None:
            result['openDataInstanceIdList'] = self.open_data_instance_id_list
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('formCode') is not None:
            self.form_code = m.get('formCode')
        if m.get('openDataInstanceIdList') is not None:
            self.open_data_instance_id_list = m.get('openDataInstanceIdList')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        return self


class GetInstancesByIdsResponseBodyCustomFormInstanceResponseList(TeaModel):
    def __init__(
        self,
        creator_union_id: str = None,
        fields: str = None,
        form_code: str = None,
        gmt_create: str = None,
        gmt_modified: str = None,
        modified_union_id: str = None,
        open_data_instance_id: str = None,
        open_team_id: str = None,
        owner_union_id: str = None,
    ):
        self.creator_union_id = creator_union_id
        self.fields = fields
        # This parameter is required.
        self.form_code = form_code
        # This parameter is required.
        self.gmt_create = gmt_create
        # This parameter is required.
        self.gmt_modified = gmt_modified
        self.modified_union_id = modified_union_id
        self.open_data_instance_id = open_data_instance_id
        # This parameter is required.
        self.open_team_id = open_team_id
        self.owner_union_id = owner_union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.creator_union_id is not None:
            result['creatorUnionId'] = self.creator_union_id
        if self.fields is not None:
            result['fields'] = self.fields
        if self.form_code is not None:
            result['formCode'] = self.form_code
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.modified_union_id is not None:
            result['modifiedUnionId'] = self.modified_union_id
        if self.open_data_instance_id is not None:
            result['openDataInstanceId'] = self.open_data_instance_id
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.owner_union_id is not None:
            result['ownerUnionId'] = self.owner_union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('creatorUnionId') is not None:
            self.creator_union_id = m.get('creatorUnionId')
        if m.get('fields') is not None:
            self.fields = m.get('fields')
        if m.get('formCode') is not None:
            self.form_code = m.get('formCode')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('modifiedUnionId') is not None:
            self.modified_union_id = m.get('modifiedUnionId')
        if m.get('openDataInstanceId') is not None:
            self.open_data_instance_id = m.get('openDataInstanceId')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('ownerUnionId') is not None:
            self.owner_union_id = m.get('ownerUnionId')
        return self


class GetInstancesByIdsResponseBody(TeaModel):
    def __init__(
        self,
        custom_form_instance_response_list: List[GetInstancesByIdsResponseBodyCustomFormInstanceResponseList] = None,
    ):
        self.custom_form_instance_response_list = custom_form_instance_response_list

    def validate(self):
        if self.custom_form_instance_response_list:
            for k in self.custom_form_instance_response_list:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['customFormInstanceResponseList'] = []
        if self.custom_form_instance_response_list is not None:
            for k in self.custom_form_instance_response_list:
                result['customFormInstanceResponseList'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.custom_form_instance_response_list = []
        if m.get('customFormInstanceResponseList') is not None:
            for k in m.get('customFormInstanceResponseList'):
                temp_model = GetInstancesByIdsResponseBodyCustomFormInstanceResponseList()
                self.custom_form_instance_response_list.append(temp_model.from_map(k))
        return self


class GetInstancesByIdsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetInstancesByIdsResponseBody = None,
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
            temp_model = GetInstancesByIdsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetNegativeWordCloudHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetNegativeWordCloudRequest(TeaModel):
    def __init__(
        self,
        open_team_id: str = None,
    ):
        # This parameter is required.
        self.open_team_id = open_team_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        return self


class GetNegativeWordCloudResponseBodyWords(TeaModel):
    def __init__(
        self,
        count: int = None,
        word: str = None,
    ):
        # This parameter is required.
        self.count = count
        # This parameter is required.
        self.word = word

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.count is not None:
            result['count'] = self.count
        if self.word is not None:
            result['word'] = self.word
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('count') is not None:
            self.count = m.get('count')
        if m.get('word') is not None:
            self.word = m.get('word')
        return self


class GetNegativeWordCloudResponseBody(TeaModel):
    def __init__(
        self,
        words: List[GetNegativeWordCloudResponseBodyWords] = None,
    ):
        # This parameter is required.
        self.words = words

    def validate(self):
        if self.words:
            for k in self.words:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['words'] = []
        if self.words is not None:
            for k in self.words:
                result['words'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.words = []
        if m.get('words') is not None:
            for k in m.get('words'):
                temp_model = GetNegativeWordCloudResponseBodyWords()
                self.words.append(temp_model.from_map(k))
        return self


class GetNegativeWordCloudResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetNegativeWordCloudResponseBody = None,
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
            temp_model = GetNegativeWordCloudResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetOssTempUrlHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetOssTempUrlRequest(TeaModel):
    def __init__(
        self,
        fetch_mode: str = None,
        file_name: str = None,
        key: str = None,
        open_team_id: str = None,
    ):
        # This parameter is required.
        self.fetch_mode = fetch_mode
        # This parameter is required.
        self.file_name = file_name
        # This parameter is required.
        self.key = key
        # This parameter is required.
        self.open_team_id = open_team_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.fetch_mode is not None:
            result['fetchMode'] = self.fetch_mode
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.key is not None:
            result['key'] = self.key
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fetchMode') is not None:
            self.fetch_mode = m.get('fetchMode')
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('key') is not None:
            self.key = m.get('key')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        return self


class GetOssTempUrlResponseBody(TeaModel):
    def __init__(
        self,
        url: str = None,
    ):
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


class GetOssTempUrlResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetOssTempUrlResponseBody = None,
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
            temp_model = GetOssTempUrlResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetStoragePolicyHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetStoragePolicyRequest(TeaModel):
    def __init__(
        self,
        biz_type: str = None,
        file_name: str = None,
        file_size: int = None,
        open_team_id: str = None,
    ):
        # This parameter is required.
        self.biz_type = biz_type
        # This parameter is required.
        self.file_name = file_name
        # This parameter is required.
        self.file_size = file_size
        # This parameter is required.
        self.open_team_id = open_team_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_type is not None:
            result['bizType'] = self.biz_type
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.file_size is not None:
            result['fileSize'] = self.file_size
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizType') is not None:
            self.biz_type = m.get('bizType')
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('fileSize') is not None:
            self.file_size = m.get('fileSize')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        return self


class GetStoragePolicyResponseBody(TeaModel):
    def __init__(
        self,
        access_key_id: str = None,
        endpoint: str = None,
        key: str = None,
        policy: str = None,
        signature: str = None,
    ):
        self.access_key_id = access_key_id
        self.endpoint = endpoint
        self.key = key
        self.policy = policy
        self.signature = signature

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
        if self.key is not None:
            result['key'] = self.key
        if self.policy is not None:
            result['policy'] = self.policy
        if self.signature is not None:
            result['signature'] = self.signature
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('accessKeyId') is not None:
            self.access_key_id = m.get('accessKeyId')
        if m.get('endpoint') is not None:
            self.endpoint = m.get('endpoint')
        if m.get('key') is not None:
            self.key = m.get('key')
        if m.get('policy') is not None:
            self.policy = m.get('policy')
        if m.get('signature') is not None:
            self.signature = m.get('signature')
        return self


class GetStoragePolicyResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetStoragePolicyResponseBody = None,
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
            temp_model = GetStoragePolicyResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetTicketHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetTicketRequest(TeaModel):
    def __init__(
        self,
        open_team_id: str = None,
        open_ticket_id: str = None,
    ):
        # This parameter is required.
        self.open_team_id = open_team_id
        # This parameter is required.
        self.open_ticket_id = open_ticket_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.open_ticket_id is not None:
            result['openTicketId'] = self.open_ticket_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('openTicketId') is not None:
            self.open_ticket_id = m.get('openTicketId')
        return self


class GetTicketResponseBodyCreator(TeaModel):
    def __init__(
        self,
        nick_name: str = None,
        union_id: str = None,
    ):
        self.nick_name = nick_name
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.nick_name is not None:
            result['nickName'] = self.nick_name
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nickName') is not None:
            self.nick_name = m.get('nickName')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetTicketResponseBodyProcessor(TeaModel):
    def __init__(
        self,
        nick_name: str = None,
        union_id: str = None,
    ):
        self.nick_name = nick_name
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.nick_name is not None:
            result['nickName'] = self.nick_name
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nickName') is not None:
            self.nick_name = m.get('nickName')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetTicketResponseBodyTakers(TeaModel):
    def __init__(
        self,
        nick_name: str = None,
        union_id: str = None,
    ):
        self.nick_name = nick_name
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.nick_name is not None:
            result['nickName'] = self.nick_name
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nickName') is not None:
            self.nick_name = m.get('nickName')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class GetTicketResponseBodyTemplate(TeaModel):
    def __init__(
        self,
        open_template_biz_id: str = None,
        open_template_id: str = None,
        template_name: str = None,
    ):
        self.open_template_biz_id = open_template_biz_id
        self.open_template_id = open_template_id
        self.template_name = template_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_template_biz_id is not None:
            result['openTemplateBizId'] = self.open_template_biz_id
        if self.open_template_id is not None:
            result['openTemplateId'] = self.open_template_id
        if self.template_name is not None:
            result['templateName'] = self.template_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openTemplateBizId') is not None:
            self.open_template_biz_id = m.get('openTemplateBizId')
        if m.get('openTemplateId') is not None:
            self.open_template_id = m.get('openTemplateId')
        if m.get('templateName') is not None:
            self.template_name = m.get('templateName')
        return self


class GetTicketResponseBody(TeaModel):
    def __init__(
        self,
        create_time: str = None,
        creator: GetTicketResponseBodyCreator = None,
        custom_fields: str = None,
        open_conversation_id: str = None,
        open_ticket_id: str = None,
        processor: GetTicketResponseBodyProcessor = None,
        scene: str = None,
        scene_context: str = None,
        stage: str = None,
        takers: List[GetTicketResponseBodyTakers] = None,
        template: GetTicketResponseBodyTemplate = None,
        title: str = None,
        update_time: str = None,
    ):
        self.create_time = create_time
        self.creator = creator
        self.custom_fields = custom_fields
        self.open_conversation_id = open_conversation_id
        self.open_ticket_id = open_ticket_id
        self.processor = processor
        self.scene = scene
        self.scene_context = scene_context
        self.stage = stage
        self.takers = takers
        self.template = template
        self.title = title
        self.update_time = update_time

    def validate(self):
        if self.creator:
            self.creator.validate()
        if self.processor:
            self.processor.validate()
        if self.takers:
            for k in self.takers:
                if k:
                    k.validate()
        if self.template:
            self.template.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.create_time is not None:
            result['createTime'] = self.create_time
        if self.creator is not None:
            result['creator'] = self.creator.to_map()
        if self.custom_fields is not None:
            result['customFields'] = self.custom_fields
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.open_ticket_id is not None:
            result['openTicketId'] = self.open_ticket_id
        if self.processor is not None:
            result['processor'] = self.processor.to_map()
        if self.scene is not None:
            result['scene'] = self.scene
        if self.scene_context is not None:
            result['sceneContext'] = self.scene_context
        if self.stage is not None:
            result['stage'] = self.stage
        result['takers'] = []
        if self.takers is not None:
            for k in self.takers:
                result['takers'].append(k.to_map() if k else None)
        if self.template is not None:
            result['template'] = self.template.to_map()
        if self.title is not None:
            result['title'] = self.title
        if self.update_time is not None:
            result['updateTime'] = self.update_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createTime') is not None:
            self.create_time = m.get('createTime')
        if m.get('creator') is not None:
            temp_model = GetTicketResponseBodyCreator()
            self.creator = temp_model.from_map(m['creator'])
        if m.get('customFields') is not None:
            self.custom_fields = m.get('customFields')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('openTicketId') is not None:
            self.open_ticket_id = m.get('openTicketId')
        if m.get('processor') is not None:
            temp_model = GetTicketResponseBodyProcessor()
            self.processor = temp_model.from_map(m['processor'])
        if m.get('scene') is not None:
            self.scene = m.get('scene')
        if m.get('sceneContext') is not None:
            self.scene_context = m.get('sceneContext')
        if m.get('stage') is not None:
            self.stage = m.get('stage')
        self.takers = []
        if m.get('takers') is not None:
            for k in m.get('takers'):
                temp_model = GetTicketResponseBodyTakers()
                self.takers.append(temp_model.from_map(k))
        if m.get('template') is not None:
            temp_model = GetTicketResponseBodyTemplate()
            self.template = temp_model.from_map(m['template'])
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('updateTime') is not None:
            self.update_time = m.get('updateTime')
        return self


class GetTicketResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetTicketResponseBody = None,
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
            temp_model = GetTicketResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetWordCloudHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetWordCloudRequest(TeaModel):
    def __init__(
        self,
        open_team_id: str = None,
    ):
        # This parameter is required.
        self.open_team_id = open_team_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        return self


class GetWordCloudResponseBodyWords(TeaModel):
    def __init__(
        self,
        count: int = None,
        word: str = None,
    ):
        # This parameter is required.
        self.count = count
        # This parameter is required.
        self.word = word

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.count is not None:
            result['count'] = self.count
        if self.word is not None:
            result['word'] = self.word
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('count') is not None:
            self.count = m.get('count')
        if m.get('word') is not None:
            self.word = m.get('word')
        return self


class GetWordCloudResponseBody(TeaModel):
    def __init__(
        self,
        words: List[GetWordCloudResponseBodyWords] = None,
    ):
        # This parameter is required.
        self.words = words

    def validate(self):
        if self.words:
            for k in self.words:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['words'] = []
        if self.words is not None:
            for k in self.words:
                result['words'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.words = []
        if m.get('words') is not None:
            for k in m.get('words'):
                temp_model = GetWordCloudResponseBodyWords()
                self.words.append(temp_model.from_map(k))
        return self


class GetWordCloudResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetWordCloudResponseBody = None,
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
            temp_model = GetWordCloudResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GroupStatisticsHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GroupStatisticsRequest(TeaModel):
    def __init__(
        self,
        max_dt: str = None,
        min_dt: str = None,
        open_team_id: str = None,
    ):
        # This parameter is required.
        self.max_dt = max_dt
        # This parameter is required.
        self.min_dt = min_dt
        # This parameter is required.
        self.open_team_id = open_team_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.max_dt is not None:
            result['maxDt'] = self.max_dt
        if self.min_dt is not None:
            result['minDt'] = self.min_dt
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxDt') is not None:
            self.max_dt = m.get('maxDt')
        if m.get('minDt') is not None:
            self.min_dt = m.get('minDt')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        return self


class GroupStatisticsResponseBodyGroupTrend(TeaModel):
    def __init__(
        self,
        count: int = None,
        dt: str = None,
    ):
        # This parameter is required.
        self.count = count
        # This parameter is required.
        self.dt = dt

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.count is not None:
            result['count'] = self.count
        if self.dt is not None:
            result['dt'] = self.dt
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('count') is not None:
            self.count = m.get('count')
        if m.get('dt') is not None:
            self.dt = m.get('dt')
        return self


class GroupStatisticsResponseBody(TeaModel):
    def __init__(
        self,
        group_count: int = None,
        group_trend: List[GroupStatisticsResponseBodyGroupTrend] = None,
        increase_group_count: int = None,
        increase_rate: str = None,
    ):
        # This parameter is required.
        self.group_count = group_count
        # This parameter is required.
        self.group_trend = group_trend
        # This parameter is required.
        self.increase_group_count = increase_group_count
        # This parameter is required.
        self.increase_rate = increase_rate

    def validate(self):
        if self.group_trend:
            for k in self.group_trend:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_count is not None:
            result['groupCount'] = self.group_count
        result['groupTrend'] = []
        if self.group_trend is not None:
            for k in self.group_trend:
                result['groupTrend'].append(k.to_map() if k else None)
        if self.increase_group_count is not None:
            result['increaseGroupCount'] = self.increase_group_count
        if self.increase_rate is not None:
            result['increaseRate'] = self.increase_rate
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupCount') is not None:
            self.group_count = m.get('groupCount')
        self.group_trend = []
        if m.get('groupTrend') is not None:
            for k in m.get('groupTrend'):
                temp_model = GroupStatisticsResponseBodyGroupTrend()
                self.group_trend.append(temp_model.from_map(k))
        if m.get('increaseGroupCount') is not None:
            self.increase_group_count = m.get('increaseGroupCount')
        if m.get('increaseRate') is not None:
            self.increase_rate = m.get('increaseRate')
        return self


class GroupStatisticsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GroupStatisticsResponseBody = None,
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
            temp_model = GroupStatisticsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class IntentionCategoryStatisticsHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class IntentionCategoryStatisticsRequest(TeaModel):
    def __init__(
        self,
        max_dt: str = None,
        min_dt: str = None,
        open_team_id: str = None,
    ):
        # This parameter is required.
        self.max_dt = max_dt
        # This parameter is required.
        self.min_dt = min_dt
        # This parameter is required.
        self.open_team_id = open_team_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.max_dt is not None:
            result['maxDt'] = self.max_dt
        if self.min_dt is not None:
            result['minDt'] = self.min_dt
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxDt') is not None:
            self.max_dt = m.get('maxDt')
        if m.get('minDt') is not None:
            self.min_dt = m.get('minDt')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        return self


class IntentionCategoryStatisticsResponseBodyIntentionCategoryRecords(TeaModel):
    def __init__(
        self,
        ask_count: int = None,
        category_name: str = None,
        dissatisfied_count: int = None,
        error_count: int = None,
        praise_count: int = None,
        suggest_count: int = None,
    ):
        # This parameter is required.
        self.ask_count = ask_count
        # This parameter is required.
        self.category_name = category_name
        # This parameter is required.
        self.dissatisfied_count = dissatisfied_count
        # This parameter is required.
        self.error_count = error_count
        # This parameter is required.
        self.praise_count = praise_count
        # This parameter is required.
        self.suggest_count = suggest_count

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ask_count is not None:
            result['askCount'] = self.ask_count
        if self.category_name is not None:
            result['categoryName'] = self.category_name
        if self.dissatisfied_count is not None:
            result['dissatisfiedCount'] = self.dissatisfied_count
        if self.error_count is not None:
            result['errorCount'] = self.error_count
        if self.praise_count is not None:
            result['praiseCount'] = self.praise_count
        if self.suggest_count is not None:
            result['suggestCount'] = self.suggest_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('askCount') is not None:
            self.ask_count = m.get('askCount')
        if m.get('categoryName') is not None:
            self.category_name = m.get('categoryName')
        if m.get('dissatisfiedCount') is not None:
            self.dissatisfied_count = m.get('dissatisfiedCount')
        if m.get('errorCount') is not None:
            self.error_count = m.get('errorCount')
        if m.get('praiseCount') is not None:
            self.praise_count = m.get('praiseCount')
        if m.get('suggestCount') is not None:
            self.suggest_count = m.get('suggestCount')
        return self


class IntentionCategoryStatisticsResponseBody(TeaModel):
    def __init__(
        self,
        intention_category_records: List[IntentionCategoryStatisticsResponseBodyIntentionCategoryRecords] = None,
    ):
        # This parameter is required.
        self.intention_category_records = intention_category_records

    def validate(self):
        if self.intention_category_records:
            for k in self.intention_category_records:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['intentionCategoryRecords'] = []
        if self.intention_category_records is not None:
            for k in self.intention_category_records:
                result['intentionCategoryRecords'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.intention_category_records = []
        if m.get('intentionCategoryRecords') is not None:
            for k in m.get('intentionCategoryRecords'):
                temp_model = IntentionCategoryStatisticsResponseBodyIntentionCategoryRecords()
                self.intention_category_records.append(temp_model.from_map(k))
        return self


class IntentionCategoryStatisticsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: IntentionCategoryStatisticsResponseBody = None,
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
            temp_model = IntentionCategoryStatisticsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class IntentionStatisticsHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class IntentionStatisticsRequest(TeaModel):
    def __init__(
        self,
        max_dt: str = None,
        min_dt: str = None,
        open_team_id: str = None,
    ):
        # This parameter is required.
        self.max_dt = max_dt
        # This parameter is required.
        self.min_dt = min_dt
        # This parameter is required.
        self.open_team_id = open_team_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.max_dt is not None:
            result['maxDt'] = self.max_dt
        if self.min_dt is not None:
            result['minDt'] = self.min_dt
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxDt') is not None:
            self.max_dt = m.get('maxDt')
        if m.get('minDt') is not None:
            self.min_dt = m.get('minDt')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        return self


class IntentionStatisticsResponseBodyIntentionStatisticsRecords(TeaModel):
    def __init__(
        self,
        count: int = None,
        intention: str = None,
        last_count: int = None,
    ):
        # This parameter is required.
        self.count = count
        # This parameter is required.
        self.intention = intention
        # This parameter is required.
        self.last_count = last_count

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.count is not None:
            result['count'] = self.count
        if self.intention is not None:
            result['intention'] = self.intention
        if self.last_count is not None:
            result['lastCount'] = self.last_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('count') is not None:
            self.count = m.get('count')
        if m.get('intention') is not None:
            self.intention = m.get('intention')
        if m.get('lastCount') is not None:
            self.last_count = m.get('lastCount')
        return self


class IntentionStatisticsResponseBodyIntentionTrend(TeaModel):
    def __init__(
        self,
        count: int = None,
        dt: str = None,
        intention: str = None,
    ):
        # This parameter is required.
        self.count = count
        # This parameter is required.
        self.dt = dt
        # This parameter is required.
        self.intention = intention

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.count is not None:
            result['count'] = self.count
        if self.dt is not None:
            result['dt'] = self.dt
        if self.intention is not None:
            result['intention'] = self.intention
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('count') is not None:
            self.count = m.get('count')
        if m.get('dt') is not None:
            self.dt = m.get('dt')
        if m.get('intention') is not None:
            self.intention = m.get('intention')
        return self


class IntentionStatisticsResponseBody(TeaModel):
    def __init__(
        self,
        intention_statistics_records: List[IntentionStatisticsResponseBodyIntentionStatisticsRecords] = None,
        intention_trend: List[IntentionStatisticsResponseBodyIntentionTrend] = None,
    ):
        # This parameter is required.
        self.intention_statistics_records = intention_statistics_records
        # This parameter is required.
        self.intention_trend = intention_trend

    def validate(self):
        if self.intention_statistics_records:
            for k in self.intention_statistics_records:
                if k:
                    k.validate()
        if self.intention_trend:
            for k in self.intention_trend:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['intentionStatisticsRecords'] = []
        if self.intention_statistics_records is not None:
            for k in self.intention_statistics_records:
                result['intentionStatisticsRecords'].append(k.to_map() if k else None)
        result['intentionTrend'] = []
        if self.intention_trend is not None:
            for k in self.intention_trend:
                result['intentionTrend'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.intention_statistics_records = []
        if m.get('intentionStatisticsRecords') is not None:
            for k in m.get('intentionStatisticsRecords'):
                temp_model = IntentionStatisticsResponseBodyIntentionStatisticsRecords()
                self.intention_statistics_records.append(temp_model.from_map(k))
        self.intention_trend = []
        if m.get('intentionTrend') is not None:
            for k in m.get('intentionTrend'):
                temp_model = IntentionStatisticsResponseBodyIntentionTrend()
                self.intention_trend.append(temp_model.from_map(k))
        return self


class IntentionStatisticsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: IntentionStatisticsResponseBody = None,
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
            temp_model = IntentionStatisticsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListTicketOperateRecordHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class ListTicketOperateRecordRequest(TeaModel):
    def __init__(
        self,
        open_team_id: str = None,
        open_ticket_id: str = None,
    ):
        # This parameter is required.
        self.open_team_id = open_team_id
        # This parameter is required.
        self.open_ticket_id = open_ticket_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.open_ticket_id is not None:
            result['openTicketId'] = self.open_ticket_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('openTicketId') is not None:
            self.open_ticket_id = m.get('openTicketId')
        return self


class ListTicketOperateRecordResponseBodyRecordsOperator(TeaModel):
    def __init__(
        self,
        nick_name: str = None,
        union_id: str = None,
    ):
        self.nick_name = nick_name
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.nick_name is not None:
            result['nickName'] = self.nick_name
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nickName') is not None:
            self.nick_name = m.get('nickName')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class ListTicketOperateRecordResponseBodyRecordsTicketMemoAttachments(TeaModel):
    def __init__(
        self,
        file_name: str = None,
        key: str = None,
    ):
        self.file_name = file_name
        self.key = key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.key is not None:
            result['key'] = self.key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('key') is not None:
            self.key = m.get('key')
        return self


class ListTicketOperateRecordResponseBodyRecordsTicketMemo(TeaModel):
    def __init__(
        self,
        attachments: List[ListTicketOperateRecordResponseBodyRecordsTicketMemoAttachments] = None,
        memo: str = None,
    ):
        self.attachments = attachments
        self.memo = memo

    def validate(self):
        if self.attachments:
            for k in self.attachments:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['attachments'] = []
        if self.attachments is not None:
            for k in self.attachments:
                result['attachments'].append(k.to_map() if k else None)
        if self.memo is not None:
            result['memo'] = self.memo
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attachments = []
        if m.get('attachments') is not None:
            for k in m.get('attachments'):
                temp_model = ListTicketOperateRecordResponseBodyRecordsTicketMemoAttachments()
                self.attachments.append(temp_model.from_map(k))
        if m.get('memo') is not None:
            self.memo = m.get('memo')
        return self


class ListTicketOperateRecordResponseBodyRecords(TeaModel):
    def __init__(
        self,
        open_ticket_id: str = None,
        operate_data: str = None,
        operate_time: str = None,
        operation: str = None,
        operation_display_name: str = None,
        operator: ListTicketOperateRecordResponseBodyRecordsOperator = None,
        ticket_memo: ListTicketOperateRecordResponseBodyRecordsTicketMemo = None,
    ):
        self.open_ticket_id = open_ticket_id
        self.operate_data = operate_data
        self.operate_time = operate_time
        self.operation = operation
        self.operation_display_name = operation_display_name
        self.operator = operator
        self.ticket_memo = ticket_memo

    def validate(self):
        if self.operator:
            self.operator.validate()
        if self.ticket_memo:
            self.ticket_memo.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_ticket_id is not None:
            result['openTicketId'] = self.open_ticket_id
        if self.operate_data is not None:
            result['operateData'] = self.operate_data
        if self.operate_time is not None:
            result['operateTime'] = self.operate_time
        if self.operation is not None:
            result['operation'] = self.operation
        if self.operation_display_name is not None:
            result['operationDisplayName'] = self.operation_display_name
        if self.operator is not None:
            result['operator'] = self.operator.to_map()
        if self.ticket_memo is not None:
            result['ticketMemo'] = self.ticket_memo.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openTicketId') is not None:
            self.open_ticket_id = m.get('openTicketId')
        if m.get('operateData') is not None:
            self.operate_data = m.get('operateData')
        if m.get('operateTime') is not None:
            self.operate_time = m.get('operateTime')
        if m.get('operation') is not None:
            self.operation = m.get('operation')
        if m.get('operationDisplayName') is not None:
            self.operation_display_name = m.get('operationDisplayName')
        if m.get('operator') is not None:
            temp_model = ListTicketOperateRecordResponseBodyRecordsOperator()
            self.operator = temp_model.from_map(m['operator'])
        if m.get('ticketMemo') is not None:
            temp_model = ListTicketOperateRecordResponseBodyRecordsTicketMemo()
            self.ticket_memo = temp_model.from_map(m['ticketMemo'])
        return self


class ListTicketOperateRecordResponseBody(TeaModel):
    def __init__(
        self,
        records: List[ListTicketOperateRecordResponseBodyRecords] = None,
    ):
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
        result['records'] = []
        if self.records is not None:
            for k in self.records:
                result['records'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.records = []
        if m.get('records') is not None:
            for k in m.get('records'):
                temp_model = ListTicketOperateRecordResponseBodyRecords()
                self.records.append(temp_model.from_map(k))
        return self


class ListTicketOperateRecordResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListTicketOperateRecordResponseBody = None,
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
            temp_model = ListTicketOperateRecordResponseBody()
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
        self.open_team_id = open_team_id
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
        status_code: int = None,
        body: ListUserTeamsResponseBody = None,
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
            temp_model = ListUserTeamsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryActiveUsersHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryActiveUsersRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        open_team_id: str = None,
        top_n: int = None,
    ):
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        self.open_team_id = open_team_id
        self.top_n = top_n

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.top_n is not None:
            result['topN'] = self.top_n
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('topN') is not None:
            self.top_n = m.get('topN')
        return self


class QueryActiveUsersResponseBodyActiveUserInfos(TeaModel):
    def __init__(
        self,
        action_index_l14d: float = None,
        action_index_l30d: float = None,
        action_index_l7d: float = None,
        active_score: float = None,
        nick_name: str = None,
        ranking: int = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.action_index_l14d = action_index_l14d
        # This parameter is required.
        self.action_index_l30d = action_index_l30d
        # This parameter is required.
        self.action_index_l7d = action_index_l7d
        # This parameter is required.
        self.active_score = active_score
        # This parameter is required.
        self.nick_name = nick_name
        # This parameter is required.
        self.ranking = ranking
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action_index_l14d is not None:
            result['actionIndexL14d'] = self.action_index_l14d
        if self.action_index_l30d is not None:
            result['actionIndexL30d'] = self.action_index_l30d
        if self.action_index_l7d is not None:
            result['actionIndexL7d'] = self.action_index_l7d
        if self.active_score is not None:
            result['activeScore'] = self.active_score
        if self.nick_name is not None:
            result['nickName'] = self.nick_name
        if self.ranking is not None:
            result['ranking'] = self.ranking
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionIndexL14d') is not None:
            self.action_index_l14d = m.get('actionIndexL14d')
        if m.get('actionIndexL30d') is not None:
            self.action_index_l30d = m.get('actionIndexL30d')
        if m.get('actionIndexL7d') is not None:
            self.action_index_l7d = m.get('actionIndexL7d')
        if m.get('activeScore') is not None:
            self.active_score = m.get('activeScore')
        if m.get('nickName') is not None:
            self.nick_name = m.get('nickName')
        if m.get('ranking') is not None:
            self.ranking = m.get('ranking')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class QueryActiveUsersResponseBody(TeaModel):
    def __init__(
        self,
        active_user_infos: List[QueryActiveUsersResponseBodyActiveUserInfos] = None,
    ):
        # This parameter is required.
        self.active_user_infos = active_user_infos

    def validate(self):
        if self.active_user_infos:
            for k in self.active_user_infos:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['activeUserInfos'] = []
        if self.active_user_infos is not None:
            for k in self.active_user_infos:
                result['activeUserInfos'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.active_user_infos = []
        if m.get('activeUserInfos') is not None:
            for k in m.get('activeUserInfos'):
                temp_model = QueryActiveUsersResponseBodyActiveUserInfos()
                self.active_user_infos.append(temp_model.from_map(k))
        return self


class QueryActiveUsersResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryActiveUsersResponseBody = None,
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
            temp_model = QueryActiveUsersResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryCrmGroupContactHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryCrmGroupContactRequest(TeaModel):
    def __init__(
        self,
        min_result: int = None,
        next_token: str = None,
        open_conversation_id: str = None,
        open_team_id: str = None,
        search_fields: str = None,
    ):
        # This parameter is required.
        self.min_result = min_result
        self.next_token = next_token
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.open_team_id = open_team_id
        # This parameter is required.
        self.search_fields = search_fields

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.min_result is not None:
            result['minResult'] = self.min_result
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.search_fields is not None:
            result['searchFields'] = self.search_fields
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('minResult') is not None:
            self.min_result = m.get('minResult')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('searchFields') is not None:
            self.search_fields = m.get('searchFields')
        return self


class QueryCrmGroupContactResponseBodyRecords(TeaModel):
    def __init__(
        self,
        contact_data: str = None,
        member_union_id: str = None,
        nick_name: str = None,
        user_id: str = None,
    ):
        self.contact_data = contact_data
        self.member_union_id = member_union_id
        self.nick_name = nick_name
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.contact_data is not None:
            result['contactData'] = self.contact_data
        if self.member_union_id is not None:
            result['memberUnionId'] = self.member_union_id
        if self.nick_name is not None:
            result['nickName'] = self.nick_name
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('contactData') is not None:
            self.contact_data = m.get('contactData')
        if m.get('memberUnionId') is not None:
            self.member_union_id = m.get('memberUnionId')
        if m.get('nickName') is not None:
            self.nick_name = m.get('nickName')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryCrmGroupContactResponseBody(TeaModel):
    def __init__(
        self,
        next_token: str = None,
        open_conversation_id: str = None,
        records: List[QueryCrmGroupContactResponseBodyRecords] = None,
    ):
        self.next_token = next_token
        self.open_conversation_id = open_conversation_id
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
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        result['records'] = []
        if self.records is not None:
            for k in self.records:
                result['records'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        self.records = []
        if m.get('records') is not None:
            for k in m.get('records'):
                temp_model = QueryCrmGroupContactResponseBodyRecords()
                self.records.append(temp_model.from_map(k))
        return self


class QueryCrmGroupContactResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryCrmGroupContactResponseBody = None,
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
            temp_model = QueryCrmGroupContactResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryCustomerCardHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryCustomerCardRequest(TeaModel):
    def __init__(
        self,
        json_params: str = None,
        open_team_id: str = None,
    ):
        self.json_params = json_params
        self.open_team_id = open_team_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.json_params is not None:
            result['jsonParams'] = self.json_params
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('jsonParams') is not None:
            self.json_params = m.get('jsonParams')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        return self


class QueryCustomerCardResponseBody(TeaModel):
    def __init__(
        self,
        ding_open_errcode: int = None,
        error_msg: str = None,
        result: bool = None,
        success: bool = None,
    ):
        self.ding_open_errcode = ding_open_errcode
        self.error_msg = error_msg
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_open_errcode is not None:
            result['dingOpenErrcode'] = self.ding_open_errcode
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingOpenErrcode') is not None:
            self.ding_open_errcode = m.get('dingOpenErrcode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueryCustomerCardResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryCustomerCardResponseBody = None,
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
            temp_model = QueryCustomerCardResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryCustomerTaskUserDetailHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryCustomerTaskUserDetailRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        open_batch_task_id: str = None,
        open_team_id: str = None,
        receiver_union_ids: List[str] = None,
    ):
        self.max_results = max_results
        self.next_token = next_token
        # This parameter is required.
        self.open_batch_task_id = open_batch_task_id
        # This parameter is required.
        self.open_team_id = open_team_id
        self.receiver_union_ids = receiver_union_ids

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
        if self.open_batch_task_id is not None:
            result['openBatchTaskId'] = self.open_batch_task_id
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.receiver_union_ids is not None:
            result['receiverUnionIds'] = self.receiver_union_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('openBatchTaskId') is not None:
            self.open_batch_task_id = m.get('openBatchTaskId')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('receiverUnionIds') is not None:
            self.receiver_union_ids = m.get('receiverUnionIds')
        return self


class QueryCustomerTaskUserDetailResponseBodyRecordsEventTrackResponses(TeaModel):
    def __init__(
        self,
        click_time: str = None,
        event_track_id: str = None,
        on_click: bool = None,
        title: str = None,
    ):
        self.click_time = click_time
        self.event_track_id = event_track_id
        self.on_click = on_click
        self.title = title

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.click_time is not None:
            result['clickTime'] = self.click_time
        if self.event_track_id is not None:
            result['eventTrackId'] = self.event_track_id
        if self.on_click is not None:
            result['onClick'] = self.on_click
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('clickTime') is not None:
            self.click_time = m.get('clickTime')
        if m.get('eventTrackId') is not None:
            self.event_track_id = m.get('eventTrackId')
        if m.get('onClick') is not None:
            self.on_click = m.get('onClick')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class QueryCustomerTaskUserDetailResponseBodyRecords(TeaModel):
    def __init__(
        self,
        customer_names: str = None,
        error_code: str = None,
        error_detail: str = None,
        event_track_responses: List[QueryCustomerTaskUserDetailResponseBodyRecordsEventTrackResponses] = None,
        open_batch_task_id: str = None,
        read_status: int = None,
        read_time: str = None,
        receiver_name: str = None,
        receiver_union_id: str = None,
        send_time: str = None,
        status: str = None,
    ):
        self.customer_names = customer_names
        self.error_code = error_code
        self.error_detail = error_detail
        self.event_track_responses = event_track_responses
        self.open_batch_task_id = open_batch_task_id
        self.read_status = read_status
        self.read_time = read_time
        self.receiver_name = receiver_name
        self.receiver_union_id = receiver_union_id
        self.send_time = send_time
        self.status = status

    def validate(self):
        if self.event_track_responses:
            for k in self.event_track_responses:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.customer_names is not None:
            result['customerNames'] = self.customer_names
        if self.error_code is not None:
            result['errorCode'] = self.error_code
        if self.error_detail is not None:
            result['errorDetail'] = self.error_detail
        result['eventTrackResponses'] = []
        if self.event_track_responses is not None:
            for k in self.event_track_responses:
                result['eventTrackResponses'].append(k.to_map() if k else None)
        if self.open_batch_task_id is not None:
            result['openBatchTaskId'] = self.open_batch_task_id
        if self.read_status is not None:
            result['readStatus'] = self.read_status
        if self.read_time is not None:
            result['readTime'] = self.read_time
        if self.receiver_name is not None:
            result['receiverName'] = self.receiver_name
        if self.receiver_union_id is not None:
            result['receiverUnionId'] = self.receiver_union_id
        if self.send_time is not None:
            result['sendTime'] = self.send_time
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customerNames') is not None:
            self.customer_names = m.get('customerNames')
        if m.get('errorCode') is not None:
            self.error_code = m.get('errorCode')
        if m.get('errorDetail') is not None:
            self.error_detail = m.get('errorDetail')
        self.event_track_responses = []
        if m.get('eventTrackResponses') is not None:
            for k in m.get('eventTrackResponses'):
                temp_model = QueryCustomerTaskUserDetailResponseBodyRecordsEventTrackResponses()
                self.event_track_responses.append(temp_model.from_map(k))
        if m.get('openBatchTaskId') is not None:
            self.open_batch_task_id = m.get('openBatchTaskId')
        if m.get('readStatus') is not None:
            self.read_status = m.get('readStatus')
        if m.get('readTime') is not None:
            self.read_time = m.get('readTime')
        if m.get('receiverName') is not None:
            self.receiver_name = m.get('receiverName')
        if m.get('receiverUnionId') is not None:
            self.receiver_union_id = m.get('receiverUnionId')
        if m.get('sendTime') is not None:
            self.send_time = m.get('sendTime')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class QueryCustomerTaskUserDetailResponseBody(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        records: List[QueryCustomerTaskUserDetailResponseBodyRecords] = None,
        total_count: int = None,
    ):
        # This parameter is required.
        self.max_results = max_results
        # This parameter is required.
        self.next_token = next_token
        self.records = records
        self.total_count = total_count

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
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['records'] = []
        if self.records is not None:
            for k in self.records:
                result['records'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.records = []
        if m.get('records') is not None:
            for k in m.get('records'):
                temp_model = QueryCustomerTaskUserDetailResponseBodyRecords()
                self.records.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class QueryCustomerTaskUserDetailResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryCustomerTaskUserDetailResponseBody = None,
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
            temp_model = QueryCustomerTaskUserDetailResponseBody()
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
        biz_id: str = None,
        open_conversation_id: str = None,
        open_team_id: str = None,
    ):
        self.biz_id = biz_id
        self.open_conversation_id = open_conversation_id
        self.open_team_id = open_team_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_id is not None:
            result['bizId'] = self.biz_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        return self


class QueryGroupResponseBody(TeaModel):
    def __init__(
        self,
        biz_id: str = None,
        group_name: str = None,
        group_url: str = None,
        open_conversation_id: str = None,
        open_group_set_id: str = None,
        open_team_id: str = None,
        robot_code: str = None,
        robot_name: str = None,
    ):
        # This parameter is required.
        self.biz_id = biz_id
        # This parameter is required.
        self.group_name = group_name
        # This parameter is required.
        self.group_url = group_url
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.open_group_set_id = open_group_set_id
        # This parameter is required.
        self.open_team_id = open_team_id
        # This parameter is required.
        self.robot_code = robot_code
        # This parameter is required.
        self.robot_name = robot_name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_id is not None:
            result['bizId'] = self.biz_id
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.group_url is not None:
            result['groupUrl'] = self.group_url
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.open_group_set_id is not None:
            result['openGroupSetId'] = self.open_group_set_id
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.robot_code is not None:
            result['robotCode'] = self.robot_code
        if self.robot_name is not None:
            result['robotName'] = self.robot_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('groupUrl') is not None:
            self.group_url = m.get('groupUrl')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('openGroupSetId') is not None:
            self.open_group_set_id = m.get('openGroupSetId')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('robotCode') is not None:
            self.robot_code = m.get('robotCode')
        if m.get('robotName') is not None:
            self.robot_name = m.get('robotName')
        return self


class QueryGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryGroupResponseBody = None,
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
            temp_model = QueryGroupResponseBody()
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
        open_team_id: str = None,
        target_corp_id: str = None,
    ):
        self.open_conversation_id = open_conversation_id
        self.open_team_id = open_team_id
        # This parameter is required.
        self.target_corp_id = target_corp_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.target_corp_id is not None:
            result['targetCorpId'] = self.target_corp_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('targetCorpId') is not None:
            self.target_corp_id = m.get('targetCorpId')
        return self


class QueryGroupMemberResponseBodyResultGroupMemberList(TeaModel):
    def __init__(
        self,
        avatar_media_id: str = None,
        is_user: bool = None,
        nick_name: str = None,
        owner: bool = None,
        union_id: str = None,
        user_id: str = None,
    ):
        self.avatar_media_id = avatar_media_id
        self.is_user = is_user
        self.nick_name = nick_name
        self.owner = owner
        self.union_id = union_id
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.avatar_media_id is not None:
            result['avatarMediaId'] = self.avatar_media_id
        if self.is_user is not None:
            result['isUser'] = self.is_user
        if self.nick_name is not None:
            result['nickName'] = self.nick_name
        if self.owner is not None:
            result['owner'] = self.owner
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('avatarMediaId') is not None:
            self.avatar_media_id = m.get('avatarMediaId')
        if m.get('isUser') is not None:
            self.is_user = m.get('isUser')
        if m.get('nickName') is not None:
            self.nick_name = m.get('nickName')
        if m.get('owner') is not None:
            self.owner = m.get('owner')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class QueryGroupMemberResponseBodyResult(TeaModel):
    def __init__(
        self,
        group_member_list: List[QueryGroupMemberResponseBodyResultGroupMemberList] = None,
        open_conversation_id: str = None,
    ):
        self.group_member_list = group_member_list
        self.open_conversation_id = open_conversation_id

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
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.group_member_list = []
        if m.get('groupMemberList') is not None:
            for k in m.get('groupMemberList'):
                temp_model = QueryGroupMemberResponseBodyResultGroupMemberList()
                self.group_member_list.append(temp_model.from_map(k))
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        return self


class QueryGroupMemberResponseBody(TeaModel):
    def __init__(
        self,
        result: QueryGroupMemberResponseBodyResult = None,
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
            temp_model = QueryGroupMemberResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
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


class QueryGroupSetHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryGroupSetRequest(TeaModel):
    def __init__(
        self,
        open_team_id: str = None,
    ):
        # This parameter is required.
        self.open_team_id = open_team_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        return self


class QueryGroupSetResponseBodyRecords(TeaModel):
    def __init__(
        self,
        gmt_create: str = None,
        gmt_modified: str = None,
        group_set_name: str = None,
        open_group_set_id: str = None,
        template_id: str = None,
    ):
        # This parameter is required.
        self.gmt_create = gmt_create
        # This parameter is required.
        self.gmt_modified = gmt_modified
        # This parameter is required.
        self.group_set_name = group_set_name
        # This parameter is required.
        self.open_group_set_id = open_group_set_id
        # This parameter is required.
        self.template_id = template_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.group_set_name is not None:
            result['groupSetName'] = self.group_set_name
        if self.open_group_set_id is not None:
            result['openGroupSetId'] = self.open_group_set_id
        if self.template_id is not None:
            result['templateId'] = self.template_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('groupSetName') is not None:
            self.group_set_name = m.get('groupSetName')
        if m.get('openGroupSetId') is not None:
            self.open_group_set_id = m.get('openGroupSetId')
        if m.get('templateId') is not None:
            self.template_id = m.get('templateId')
        return self


class QueryGroupSetResponseBody(TeaModel):
    def __init__(
        self,
        records: List[QueryGroupSetResponseBodyRecords] = None,
    ):
        # This parameter is required.
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
        result['records'] = []
        if self.records is not None:
            for k in self.records:
                result['records'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.records = []
        if m.get('records') is not None:
            for k in m.get('records'):
                temp_model = QueryGroupSetResponseBodyRecords()
                self.records.append(temp_model.from_map(k))
        return self


class QueryGroupSetResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryGroupSetResponseBody = None,
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
            temp_model = QueryGroupSetResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueryInstancesByMultiConditionsHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueryInstancesByMultiConditionsRequestSortFields(TeaModel):
    def __init__(
        self,
        field_code: str = None,
        sort_by: str = None,
    ):
        self.field_code = field_code
        self.sort_by = sort_by

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.field_code is not None:
            result['fieldCode'] = self.field_code
        if self.sort_by is not None:
            result['sortBy'] = self.sort_by
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fieldCode') is not None:
            self.field_code = m.get('fieldCode')
        if m.get('sortBy') is not None:
            self.sort_by = m.get('sortBy')
        return self


class QueryInstancesByMultiConditionsRequest(TeaModel):
    def __init__(
        self,
        form_code: str = None,
        max_results: int = None,
        next_token: str = None,
        open_team_id: str = None,
        search_fields: str = None,
        sort_fields: List[QueryInstancesByMultiConditionsRequestSortFields] = None,
    ):
        # This parameter is required.
        self.form_code = form_code
        self.max_results = max_results
        self.next_token = next_token
        # This parameter is required.
        self.open_team_id = open_team_id
        self.search_fields = search_fields
        self.sort_fields = sort_fields

    def validate(self):
        if self.sort_fields:
            for k in self.sort_fields:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.form_code is not None:
            result['formCode'] = self.form_code
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.search_fields is not None:
            result['searchFields'] = self.search_fields
        result['sortFields'] = []
        if self.sort_fields is not None:
            for k in self.sort_fields:
                result['sortFields'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('formCode') is not None:
            self.form_code = m.get('formCode')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('searchFields') is not None:
            self.search_fields = m.get('searchFields')
        self.sort_fields = []
        if m.get('sortFields') is not None:
            for k in m.get('sortFields'):
                temp_model = QueryInstancesByMultiConditionsRequestSortFields()
                self.sort_fields.append(temp_model.from_map(k))
        return self


class QueryInstancesByMultiConditionsResponseBodyRecords(TeaModel):
    def __init__(
        self,
        creator_union_id: str = None,
        fields: str = None,
        form_code: str = None,
        gmt_create: str = None,
        gmt_modified: str = None,
        modified_union_id: str = None,
        open_data_instance_id: str = None,
        open_team_id: str = None,
        owner_union_id: str = None,
    ):
        self.creator_union_id = creator_union_id
        self.fields = fields
        # This parameter is required.
        self.form_code = form_code
        # This parameter is required.
        self.gmt_create = gmt_create
        # This parameter is required.
        self.gmt_modified = gmt_modified
        self.modified_union_id = modified_union_id
        # This parameter is required.
        self.open_data_instance_id = open_data_instance_id
        # This parameter is required.
        self.open_team_id = open_team_id
        self.owner_union_id = owner_union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.creator_union_id is not None:
            result['creatorUnionId'] = self.creator_union_id
        if self.fields is not None:
            result['fields'] = self.fields
        if self.form_code is not None:
            result['formCode'] = self.form_code
        if self.gmt_create is not None:
            result['gmtCreate'] = self.gmt_create
        if self.gmt_modified is not None:
            result['gmtModified'] = self.gmt_modified
        if self.modified_union_id is not None:
            result['modifiedUnionId'] = self.modified_union_id
        if self.open_data_instance_id is not None:
            result['openDataInstanceId'] = self.open_data_instance_id
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.owner_union_id is not None:
            result['ownerUnionId'] = self.owner_union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('creatorUnionId') is not None:
            self.creator_union_id = m.get('creatorUnionId')
        if m.get('fields') is not None:
            self.fields = m.get('fields')
        if m.get('formCode') is not None:
            self.form_code = m.get('formCode')
        if m.get('gmtCreate') is not None:
            self.gmt_create = m.get('gmtCreate')
        if m.get('gmtModified') is not None:
            self.gmt_modified = m.get('gmtModified')
        if m.get('modifiedUnionId') is not None:
            self.modified_union_id = m.get('modifiedUnionId')
        if m.get('openDataInstanceId') is not None:
            self.open_data_instance_id = m.get('openDataInstanceId')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('ownerUnionId') is not None:
            self.owner_union_id = m.get('ownerUnionId')
        return self


class QueryInstancesByMultiConditionsResponseBody(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        records: List[QueryInstancesByMultiConditionsResponseBodyRecords] = None,
        total_count: int = None,
    ):
        # This parameter is required.
        self.max_results = max_results
        self.next_token = next_token
        self.records = records
        # This parameter is required.
        self.total_count = total_count

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
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['records'] = []
        if self.records is not None:
            for k in self.records:
                result['records'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.records = []
        if m.get('records') is not None:
            for k in m.get('records'):
                temp_model = QueryInstancesByMultiConditionsResponseBodyRecords()
                self.records.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class QueryInstancesByMultiConditionsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryInstancesByMultiConditionsResponseBody = None,
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
            temp_model = QueryInstancesByMultiConditionsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QuerySendMsgTaskStatisticsHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QuerySendMsgTaskStatisticsRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        open_batch_task_id: str = None,
        open_team_id: str = None,
    ):
        self.max_results = max_results
        self.next_token = next_token
        # This parameter is required.
        self.open_batch_task_id = open_batch_task_id
        # This parameter is required.
        self.open_team_id = open_team_id

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
        if self.open_batch_task_id is not None:
            result['openBatchTaskId'] = self.open_batch_task_id
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('openBatchTaskId') is not None:
            self.open_batch_task_id = m.get('openBatchTaskId')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        return self


class QuerySendMsgTaskStatisticsResponseBodyRecordsGroup(TeaModel):
    def __init__(
        self,
        biz_id: str = None,
        group_name: str = None,
        group_set_name: str = None,
        open_conversation_id: str = None,
        open_group_set_id: str = None,
        open_team_id: str = None,
    ):
        self.biz_id = biz_id
        self.group_name = group_name
        self.group_set_name = group_set_name
        self.open_conversation_id = open_conversation_id
        self.open_group_set_id = open_group_set_id
        self.open_team_id = open_team_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.biz_id is not None:
            result['bizId'] = self.biz_id
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.group_set_name is not None:
            result['groupSetName'] = self.group_set_name
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.open_group_set_id is not None:
            result['openGroupSetId'] = self.open_group_set_id
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('groupSetName') is not None:
            self.group_set_name = m.get('groupSetName')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('openGroupSetId') is not None:
            self.open_group_set_id = m.get('openGroupSetId')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        return self


class QuerySendMsgTaskStatisticsResponseBodyRecordsGroupUserReadStatistics(TeaModel):
    def __init__(
        self,
        open_batch_task_id: str = None,
        open_conversation_id: str = None,
        read_user_inc: int = None,
        send_user_inc: int = None,
        un_read_user_inc: int = None,
    ):
        self.open_batch_task_id = open_batch_task_id
        self.open_conversation_id = open_conversation_id
        self.read_user_inc = read_user_inc
        self.send_user_inc = send_user_inc
        self.un_read_user_inc = un_read_user_inc

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_batch_task_id is not None:
            result['openBatchTaskId'] = self.open_batch_task_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.read_user_inc is not None:
            result['readUserInc'] = self.read_user_inc
        if self.send_user_inc is not None:
            result['sendUserInc'] = self.send_user_inc
        if self.un_read_user_inc is not None:
            result['unReadUserInc'] = self.un_read_user_inc
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openBatchTaskId') is not None:
            self.open_batch_task_id = m.get('openBatchTaskId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('readUserInc') is not None:
            self.read_user_inc = m.get('readUserInc')
        if m.get('sendUserInc') is not None:
            self.send_user_inc = m.get('sendUserInc')
        if m.get('unReadUserInc') is not None:
            self.un_read_user_inc = m.get('unReadUserInc')
        return self


class QuerySendMsgTaskStatisticsResponseBodyRecords(TeaModel):
    def __init__(
        self,
        error_detail: str = None,
        group: QuerySendMsgTaskStatisticsResponseBodyRecordsGroup = None,
        group_user_read_statistics: QuerySendMsgTaskStatisticsResponseBodyRecordsGroupUserReadStatistics = None,
        open_msg_id: str = None,
        status: str = None,
    ):
        self.error_detail = error_detail
        self.group = group
        self.group_user_read_statistics = group_user_read_statistics
        self.open_msg_id = open_msg_id
        self.status = status

    def validate(self):
        if self.group:
            self.group.validate()
        if self.group_user_read_statistics:
            self.group_user_read_statistics.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.error_detail is not None:
            result['errorDetail'] = self.error_detail
        if self.group is not None:
            result['group'] = self.group.to_map()
        if self.group_user_read_statistics is not None:
            result['groupUserReadStatistics'] = self.group_user_read_statistics.to_map()
        if self.open_msg_id is not None:
            result['openMsgId'] = self.open_msg_id
        if self.status is not None:
            result['status'] = self.status
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('errorDetail') is not None:
            self.error_detail = m.get('errorDetail')
        if m.get('group') is not None:
            temp_model = QuerySendMsgTaskStatisticsResponseBodyRecordsGroup()
            self.group = temp_model.from_map(m['group'])
        if m.get('groupUserReadStatistics') is not None:
            temp_model = QuerySendMsgTaskStatisticsResponseBodyRecordsGroupUserReadStatistics()
            self.group_user_read_statistics = temp_model.from_map(m['groupUserReadStatistics'])
        if m.get('openMsgId') is not None:
            self.open_msg_id = m.get('openMsgId')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class QuerySendMsgTaskStatisticsResponseBody(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        records: List[QuerySendMsgTaskStatisticsResponseBodyRecords] = None,
        total_count: int = None,
    ):
        self.max_results = max_results
        self.next_token = next_token
        self.records = records
        self.total_count = total_count

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
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['records'] = []
        if self.records is not None:
            for k in self.records:
                result['records'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.records = []
        if m.get('records') is not None:
            for k in m.get('records'):
                temp_model = QuerySendMsgTaskStatisticsResponseBodyRecords()
                self.records.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class QuerySendMsgTaskStatisticsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QuerySendMsgTaskStatisticsResponseBody = None,
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
            temp_model = QuerySendMsgTaskStatisticsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QuerySendMsgTaskStatisticsDetailHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QuerySendMsgTaskStatisticsDetailRequest(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        open_batch_task_id: str = None,
        open_conversation_id: str = None,
        open_team_id: str = None,
    ):
        self.max_results = max_results
        self.next_token = next_token
        # This parameter is required.
        self.open_batch_task_id = open_batch_task_id
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.open_team_id = open_team_id

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
        if self.open_batch_task_id is not None:
            result['openBatchTaskId'] = self.open_batch_task_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('openBatchTaskId') is not None:
            self.open_batch_task_id = m.get('openBatchTaskId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        return self


class QuerySendMsgTaskStatisticsDetailResponseBodyRecords(TeaModel):
    def __init__(
        self,
        open_batch_task_id: str = None,
        open_conversation_id: str = None,
        read_status: int = None,
        read_time_str: str = None,
        receiver_name: str = None,
        receiver_union_id: str = None,
    ):
        self.open_batch_task_id = open_batch_task_id
        self.open_conversation_id = open_conversation_id
        self.read_status = read_status
        self.read_time_str = read_time_str
        self.receiver_name = receiver_name
        self.receiver_union_id = receiver_union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_batch_task_id is not None:
            result['openBatchTaskId'] = self.open_batch_task_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.read_status is not None:
            result['readStatus'] = self.read_status
        if self.read_time_str is not None:
            result['readTimeStr'] = self.read_time_str
        if self.receiver_name is not None:
            result['receiverName'] = self.receiver_name
        if self.receiver_union_id is not None:
            result['receiverUnionId'] = self.receiver_union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openBatchTaskId') is not None:
            self.open_batch_task_id = m.get('openBatchTaskId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('readStatus') is not None:
            self.read_status = m.get('readStatus')
        if m.get('readTimeStr') is not None:
            self.read_time_str = m.get('readTimeStr')
        if m.get('receiverName') is not None:
            self.receiver_name = m.get('receiverName')
        if m.get('receiverUnionId') is not None:
            self.receiver_union_id = m.get('receiverUnionId')
        return self


class QuerySendMsgTaskStatisticsDetailResponseBody(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        records: List[QuerySendMsgTaskStatisticsDetailResponseBodyRecords] = None,
        total_count: int = None,
    ):
        self.max_results = max_results
        self.next_token = next_token
        self.records = records
        self.total_count = total_count

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
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['records'] = []
        if self.records is not None:
            for k in self.records:
                result['records'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.records = []
        if m.get('records') is not None:
            for k in m.get('records'):
                temp_model = QuerySendMsgTaskStatisticsDetailResponseBodyRecords()
                self.records.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class QuerySendMsgTaskStatisticsDetailResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QuerySendMsgTaskStatisticsDetailResponseBody = None,
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
            temp_model = QuerySendMsgTaskStatisticsDetailResponseBody()
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
        max_results: int = None,
        next_token: str = None,
        open_conversation_id: str = None,
        open_msg_task_id: str = None,
        open_team_id: str = None,
    ):
        self.max_results = max_results
        self.next_token = next_token
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.open_msg_task_id = open_msg_task_id
        # This parameter is required.
        self.open_team_id = open_team_id

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
        if self.open_msg_task_id is not None:
            result['openMsgTaskId'] = self.open_msg_task_id
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('openMsgTaskId') is not None:
            self.open_msg_task_id = m.get('openMsgTaskId')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        return self


class QueryServiceGroupMessageReadStatusResponseBodyRecords(TeaModel):
    def __init__(
        self,
        read_status: int = None,
        read_time_str: str = None,
        receiver_ding_talk_id: str = None,
        receiver_name: str = None,
        receiver_union_id: str = None,
        receiver_user_id: str = None,
        send_time_str: str = None,
    ):
        self.read_status = read_status
        self.read_time_str = read_time_str
        self.receiver_ding_talk_id = receiver_ding_talk_id
        self.receiver_name = receiver_name
        self.receiver_union_id = receiver_union_id
        self.receiver_user_id = receiver_user_id
        self.send_time_str = send_time_str

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.read_status is not None:
            result['readStatus'] = self.read_status
        if self.read_time_str is not None:
            result['readTimeStr'] = self.read_time_str
        if self.receiver_ding_talk_id is not None:
            result['receiverDingTalkId'] = self.receiver_ding_talk_id
        if self.receiver_name is not None:
            result['receiverName'] = self.receiver_name
        if self.receiver_union_id is not None:
            result['receiverUnionId'] = self.receiver_union_id
        if self.receiver_user_id is not None:
            result['receiverUserId'] = self.receiver_user_id
        if self.send_time_str is not None:
            result['sendTimeStr'] = self.send_time_str
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('readStatus') is not None:
            self.read_status = m.get('readStatus')
        if m.get('readTimeStr') is not None:
            self.read_time_str = m.get('readTimeStr')
        if m.get('receiverDingTalkId') is not None:
            self.receiver_ding_talk_id = m.get('receiverDingTalkId')
        if m.get('receiverName') is not None:
            self.receiver_name = m.get('receiverName')
        if m.get('receiverUnionId') is not None:
            self.receiver_union_id = m.get('receiverUnionId')
        if m.get('receiverUserId') is not None:
            self.receiver_user_id = m.get('receiverUserId')
        if m.get('sendTimeStr') is not None:
            self.send_time_str = m.get('sendTimeStr')
        return self


class QueryServiceGroupMessageReadStatusResponseBody(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        records: List[QueryServiceGroupMessageReadStatusResponseBodyRecords] = None,
        total_count: int = None,
    ):
        self.max_results = max_results
        # This parameter is required.
        self.next_token = next_token
        self.records = records
        self.total_count = total_count

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
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['records'] = []
        if self.records is not None:
            for k in self.records:
                result['records'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.records = []
        if m.get('records') is not None:
            for k in m.get('records'):
                temp_model = QueryServiceGroupMessageReadStatusResponseBodyRecords()
                self.records.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class QueryServiceGroupMessageReadStatusResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueryServiceGroupMessageReadStatusResponseBody = None,
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
            temp_model = QueryServiceGroupMessageReadStatusResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class QueueNotifyHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class QueueNotifyRequest(TeaModel):
    def __init__(
        self,
        estimate_wait_min: int = None,
        open_team_id: str = None,
        queue_place: int = None,
        service_token: str = None,
        target_channel: str = None,
        tips: str = None,
        visitor_token: str = None,
    ):
        self.estimate_wait_min = estimate_wait_min
        self.open_team_id = open_team_id
        self.queue_place = queue_place
        self.service_token = service_token
        self.target_channel = target_channel
        self.tips = tips
        self.visitor_token = visitor_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.estimate_wait_min is not None:
            result['estimateWaitMin'] = self.estimate_wait_min
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.queue_place is not None:
            result['queuePlace'] = self.queue_place
        if self.service_token is not None:
            result['serviceToken'] = self.service_token
        if self.target_channel is not None:
            result['targetChannel'] = self.target_channel
        if self.tips is not None:
            result['tips'] = self.tips
        if self.visitor_token is not None:
            result['visitorToken'] = self.visitor_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('estimateWaitMin') is not None:
            self.estimate_wait_min = m.get('estimateWaitMin')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('queuePlace') is not None:
            self.queue_place = m.get('queuePlace')
        if m.get('serviceToken') is not None:
            self.service_token = m.get('serviceToken')
        if m.get('targetChannel') is not None:
            self.target_channel = m.get('targetChannel')
        if m.get('tips') is not None:
            self.tips = m.get('tips')
        if m.get('visitorToken') is not None:
            self.visitor_token = m.get('visitorToken')
        return self


class QueueNotifyResponseBody(TeaModel):
    def __init__(
        self,
        ding_open_errcode: int = None,
        error_msg: str = None,
        result: bool = None,
        success: bool = None,
    ):
        self.ding_open_errcode = ding_open_errcode
        self.error_msg = error_msg
        self.result = result
        self.success = success

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ding_open_errcode is not None:
            result['dingOpenErrcode'] = self.ding_open_errcode
        if self.error_msg is not None:
            result['errorMsg'] = self.error_msg
        if self.result is not None:
            result['result'] = self.result
        if self.success is not None:
            result['success'] = self.success
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dingOpenErrcode') is not None:
            self.ding_open_errcode = m.get('dingOpenErrcode')
        if m.get('errorMsg') is not None:
            self.error_msg = m.get('errorMsg')
        if m.get('result') is not None:
            self.result = m.get('result')
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class QueueNotifyResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: QueueNotifyResponseBody = None,
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
            temp_model = QueueNotifyResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RemoveContactFromOrgHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class RemoveContactFromOrgRequest(TeaModel):
    def __init__(
        self,
        contact_union_id: str = None,
        open_team_id: str = None,
    ):
        # This parameter is required.
        self.contact_union_id = contact_union_id
        # This parameter is required.
        self.open_team_id = open_team_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.contact_union_id is not None:
            result['contactUnionId'] = self.contact_union_id
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('contactUnionId') is not None:
            self.contact_union_id = m.get('contactUnionId')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        return self


class RemoveContactFromOrgResponseBody(TeaModel):
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


class RemoveContactFromOrgResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RemoveContactFromOrgResponseBody = None,
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
            temp_model = RemoveContactFromOrgResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ReportCustomerDetailHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class ReportCustomerDetailRequest(TeaModel):
    def __init__(
        self,
        has_login: bool = None,
        has_open_conv: bool = None,
        max_dt: str = None,
        min_dt: str = None,
        open_conversation_id: str = None,
        open_team_id: str = None,
        page_number: int = None,
        page_size: int = None,
    ):
        self.has_login = has_login
        self.has_open_conv = has_open_conv
        # This parameter is required.
        self.max_dt = max_dt
        # This parameter is required.
        self.min_dt = min_dt
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.open_team_id = open_team_id
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
        if self.has_login is not None:
            result['hasLogin'] = self.has_login
        if self.has_open_conv is not None:
            result['hasOpenConv'] = self.has_open_conv
        if self.max_dt is not None:
            result['maxDt'] = self.max_dt
        if self.min_dt is not None:
            result['minDt'] = self.min_dt
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasLogin') is not None:
            self.has_login = m.get('hasLogin')
        if m.get('hasOpenConv') is not None:
            self.has_open_conv = m.get('hasOpenConv')
        if m.get('maxDt') is not None:
            self.max_dt = m.get('maxDt')
        if m.get('minDt') is not None:
            self.min_dt = m.get('minDt')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class ReportCustomerDetailResponseBodyRecords(TeaModel):
    def __init__(
        self,
        at_robot_cnt: int = None,
        customer_name: str = None,
        group_name: str = None,
        has_login: bool = None,
        has_open_conv: bool = None,
        send_msg_cnt: int = None,
        union_id: str = None,
        user_id: str = None,
    ):
        # This parameter is required.
        self.at_robot_cnt = at_robot_cnt
        # This parameter is required.
        self.customer_name = customer_name
        # This parameter is required.
        self.group_name = group_name
        # This parameter is required.
        self.has_login = has_login
        # This parameter is required.
        self.has_open_conv = has_open_conv
        # This parameter is required.
        self.send_msg_cnt = send_msg_cnt
        # This parameter is required.
        self.union_id = union_id
        # This parameter is required.
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.at_robot_cnt is not None:
            result['atRobotCnt'] = self.at_robot_cnt
        if self.customer_name is not None:
            result['customerName'] = self.customer_name
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.has_login is not None:
            result['hasLogin'] = self.has_login
        if self.has_open_conv is not None:
            result['hasOpenConv'] = self.has_open_conv
        if self.send_msg_cnt is not None:
            result['sendMsgCnt'] = self.send_msg_cnt
        if self.union_id is not None:
            result['unionId'] = self.union_id
        if self.user_id is not None:
            result['userId'] = self.user_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('atRobotCnt') is not None:
            self.at_robot_cnt = m.get('atRobotCnt')
        if m.get('customerName') is not None:
            self.customer_name = m.get('customerName')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('hasLogin') is not None:
            self.has_login = m.get('hasLogin')
        if m.get('hasOpenConv') is not None:
            self.has_open_conv = m.get('hasOpenConv')
        if m.get('sendMsgCnt') is not None:
            self.send_msg_cnt = m.get('sendMsgCnt')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        if m.get('userId') is not None:
            self.user_id = m.get('userId')
        return self


class ReportCustomerDetailResponseBody(TeaModel):
    def __init__(
        self,
        current_page: int = None,
        page_size: int = None,
        records: List[ReportCustomerDetailResponseBodyRecords] = None,
        total_count: int = None,
    ):
        # This parameter is required.
        self.current_page = current_page
        # This parameter is required.
        self.page_size = page_size
        # This parameter is required.
        self.records = records
        # This parameter is required.
        self.total_count = total_count

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
        if self.current_page is not None:
            result['currentPage'] = self.current_page
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        result['records'] = []
        if self.records is not None:
            for k in self.records:
                result['records'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('currentPage') is not None:
            self.current_page = m.get('currentPage')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        self.records = []
        if m.get('records') is not None:
            for k in m.get('records'):
                temp_model = ReportCustomerDetailResponseBodyRecords()
                self.records.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class ReportCustomerDetailResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ReportCustomerDetailResponseBody = None,
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
            temp_model = ReportCustomerDetailResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ReportCustomerStatisticsHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class ReportCustomerStatisticsRequest(TeaModel):
    def __init__(
        self,
        group_owner_user_ids: List[str] = None,
        group_tags: List[str] = None,
        max_dt: str = None,
        min_dt: str = None,
        open_conversation_ids: List[str] = None,
        open_group_set_id: str = None,
        open_team_id: str = None,
        page_number: int = None,
        page_size: int = None,
    ):
        self.group_owner_user_ids = group_owner_user_ids
        self.group_tags = group_tags
        # This parameter is required.
        self.max_dt = max_dt
        # This parameter is required.
        self.min_dt = min_dt
        self.open_conversation_ids = open_conversation_ids
        self.open_group_set_id = open_group_set_id
        # This parameter is required.
        self.open_team_id = open_team_id
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
        if self.group_owner_user_ids is not None:
            result['groupOwnerUserIds'] = self.group_owner_user_ids
        if self.group_tags is not None:
            result['groupTags'] = self.group_tags
        if self.max_dt is not None:
            result['maxDt'] = self.max_dt
        if self.min_dt is not None:
            result['minDt'] = self.min_dt
        if self.open_conversation_ids is not None:
            result['openConversationIds'] = self.open_conversation_ids
        if self.open_group_set_id is not None:
            result['openGroupSetId'] = self.open_group_set_id
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.page_number is not None:
            result['pageNumber'] = self.page_number
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupOwnerUserIds') is not None:
            self.group_owner_user_ids = m.get('groupOwnerUserIds')
        if m.get('groupTags') is not None:
            self.group_tags = m.get('groupTags')
        if m.get('maxDt') is not None:
            self.max_dt = m.get('maxDt')
        if m.get('minDt') is not None:
            self.min_dt = m.get('minDt')
        if m.get('openConversationIds') is not None:
            self.open_conversation_ids = m.get('openConversationIds')
        if m.get('openGroupSetId') is not None:
            self.open_group_set_id = m.get('openGroupSetId')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('pageNumber') is not None:
            self.page_number = m.get('pageNumber')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        return self


class ReportCustomerStatisticsResponseBodyRecords(TeaModel):
    def __init__(
        self,
        at_robot_cnt: int = None,
        biz_id: str = None,
        customer_cnt: int = None,
        group_name: str = None,
        group_set_name: str = None,
        login_cnt: int = None,
        open_conv_cnt: int = None,
        open_conversation_id: str = None,
        open_group_set_id: str = None,
        send_msg_cnt: int = None,
        sender_cnt: int = None,
    ):
        # This parameter is required.
        self.at_robot_cnt = at_robot_cnt
        self.biz_id = biz_id
        # This parameter is required.
        self.customer_cnt = customer_cnt
        # This parameter is required.
        self.group_name = group_name
        # This parameter is required.
        self.group_set_name = group_set_name
        # This parameter is required.
        self.login_cnt = login_cnt
        # This parameter is required.
        self.open_conv_cnt = open_conv_cnt
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.open_group_set_id = open_group_set_id
        # This parameter is required.
        self.send_msg_cnt = send_msg_cnt
        # This parameter is required.
        self.sender_cnt = sender_cnt

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.at_robot_cnt is not None:
            result['atRobotCnt'] = self.at_robot_cnt
        if self.biz_id is not None:
            result['bizId'] = self.biz_id
        if self.customer_cnt is not None:
            result['customerCnt'] = self.customer_cnt
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.group_set_name is not None:
            result['groupSetName'] = self.group_set_name
        if self.login_cnt is not None:
            result['loginCnt'] = self.login_cnt
        if self.open_conv_cnt is not None:
            result['openConvCnt'] = self.open_conv_cnt
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.open_group_set_id is not None:
            result['openGroupSetId'] = self.open_group_set_id
        if self.send_msg_cnt is not None:
            result['sendMsgCnt'] = self.send_msg_cnt
        if self.sender_cnt is not None:
            result['senderCnt'] = self.sender_cnt
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('atRobotCnt') is not None:
            self.at_robot_cnt = m.get('atRobotCnt')
        if m.get('bizId') is not None:
            self.biz_id = m.get('bizId')
        if m.get('customerCnt') is not None:
            self.customer_cnt = m.get('customerCnt')
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('groupSetName') is not None:
            self.group_set_name = m.get('groupSetName')
        if m.get('loginCnt') is not None:
            self.login_cnt = m.get('loginCnt')
        if m.get('openConvCnt') is not None:
            self.open_conv_cnt = m.get('openConvCnt')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('openGroupSetId') is not None:
            self.open_group_set_id = m.get('openGroupSetId')
        if m.get('sendMsgCnt') is not None:
            self.send_msg_cnt = m.get('sendMsgCnt')
        if m.get('senderCnt') is not None:
            self.sender_cnt = m.get('senderCnt')
        return self


class ReportCustomerStatisticsResponseBody(TeaModel):
    def __init__(
        self,
        current_page: int = None,
        page_size: int = None,
        records: List[ReportCustomerStatisticsResponseBodyRecords] = None,
        total_count: int = None,
    ):
        # This parameter is required.
        self.current_page = current_page
        # This parameter is required.
        self.page_size = page_size
        # This parameter is required.
        self.records = records
        # This parameter is required.
        self.total_count = total_count

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
        if self.current_page is not None:
            result['currentPage'] = self.current_page
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        result['records'] = []
        if self.records is not None:
            for k in self.records:
                result['records'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('currentPage') is not None:
            self.current_page = m.get('currentPage')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        self.records = []
        if m.get('records') is not None:
            for k in m.get('records'):
                temp_model = ReportCustomerStatisticsResponseBodyRecords()
                self.records.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class ReportCustomerStatisticsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ReportCustomerStatisticsResponseBody = None,
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
            temp_model = ReportCustomerStatisticsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ResubmitTicketHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class ResubmitTicketRequestNotify(TeaModel):
    def __init__(
        self,
        group_notice_receiver_union_ids: List[str] = None,
        notice_all_group_member: bool = None,
        work_notice_receiver_union_ids: List[str] = None,
    ):
        self.group_notice_receiver_union_ids = group_notice_receiver_union_ids
        self.notice_all_group_member = notice_all_group_member
        self.work_notice_receiver_union_ids = work_notice_receiver_union_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_notice_receiver_union_ids is not None:
            result['groupNoticeReceiverUnionIds'] = self.group_notice_receiver_union_ids
        if self.notice_all_group_member is not None:
            result['noticeAllGroupMember'] = self.notice_all_group_member
        if self.work_notice_receiver_union_ids is not None:
            result['workNoticeReceiverUnionIds'] = self.work_notice_receiver_union_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupNoticeReceiverUnionIds') is not None:
            self.group_notice_receiver_union_ids = m.get('groupNoticeReceiverUnionIds')
        if m.get('noticeAllGroupMember') is not None:
            self.notice_all_group_member = m.get('noticeAllGroupMember')
        if m.get('workNoticeReceiverUnionIds') is not None:
            self.work_notice_receiver_union_ids = m.get('workNoticeReceiverUnionIds')
        return self


class ResubmitTicketRequestSceneContextGroupMsgs(TeaModel):
    def __init__(
        self,
        anchor: bool = None,
        open_msg_id: str = None,
        topic_id: str = None,
    ):
        self.anchor = anchor
        self.open_msg_id = open_msg_id
        self.topic_id = topic_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.anchor is not None:
            result['anchor'] = self.anchor
        if self.open_msg_id is not None:
            result['openMsgId'] = self.open_msg_id
        if self.topic_id is not None:
            result['topicId'] = self.topic_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('anchor') is not None:
            self.anchor = m.get('anchor')
        if m.get('openMsgId') is not None:
            self.open_msg_id = m.get('openMsgId')
        if m.get('topicId') is not None:
            self.topic_id = m.get('topicId')
        return self


class ResubmitTicketRequestSceneContext(TeaModel):
    def __init__(
        self,
        group_msgs: List[ResubmitTicketRequestSceneContextGroupMsgs] = None,
        open_conversation_id: str = None,
        relevantor_union_ids: List[str] = None,
    ):
        self.group_msgs = group_msgs
        self.open_conversation_id = open_conversation_id
        self.relevantor_union_ids = relevantor_union_ids

    def validate(self):
        if self.group_msgs:
            for k in self.group_msgs:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['groupMsgs'] = []
        if self.group_msgs is not None:
            for k in self.group_msgs:
                result['groupMsgs'].append(k.to_map() if k else None)
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.relevantor_union_ids is not None:
            result['relevantorUnionIds'] = self.relevantor_union_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.group_msgs = []
        if m.get('groupMsgs') is not None:
            for k in m.get('groupMsgs'):
                temp_model = ResubmitTicketRequestSceneContextGroupMsgs()
                self.group_msgs.append(temp_model.from_map(k))
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('relevantorUnionIds') is not None:
            self.relevantor_union_ids = m.get('relevantorUnionIds')
        return self


class ResubmitTicketRequestTicketMemoAttachments(TeaModel):
    def __init__(
        self,
        file_name: str = None,
        key: str = None,
    ):
        self.file_name = file_name
        self.key = key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.key is not None:
            result['key'] = self.key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('key') is not None:
            self.key = m.get('key')
        return self


class ResubmitTicketRequestTicketMemo(TeaModel):
    def __init__(
        self,
        attachments: List[ResubmitTicketRequestTicketMemoAttachments] = None,
        memo: str = None,
    ):
        self.attachments = attachments
        self.memo = memo

    def validate(self):
        if self.attachments:
            for k in self.attachments:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['attachments'] = []
        if self.attachments is not None:
            for k in self.attachments:
                result['attachments'].append(k.to_map() if k else None)
        if self.memo is not None:
            result['memo'] = self.memo
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attachments = []
        if m.get('attachments') is not None:
            for k in m.get('attachments'):
                temp_model = ResubmitTicketRequestTicketMemoAttachments()
                self.attachments.append(temp_model.from_map(k))
        if m.get('memo') is not None:
            self.memo = m.get('memo')
        return self


class ResubmitTicketRequest(TeaModel):
    def __init__(
        self,
        creator_union_id: str = None,
        custom_fields: str = None,
        notify: ResubmitTicketRequestNotify = None,
        open_team_id: str = None,
        open_template_biz_id: str = None,
        open_ticket_id: str = None,
        processor_union_ids: List[str] = None,
        scene: str = None,
        scene_context: ResubmitTicketRequestSceneContext = None,
        ticket_memo: ResubmitTicketRequestTicketMemo = None,
        title: str = None,
    ):
        # This parameter is required.
        self.creator_union_id = creator_union_id
        self.custom_fields = custom_fields
        self.notify = notify
        # This parameter is required.
        self.open_team_id = open_team_id
        # This parameter is required.
        self.open_template_biz_id = open_template_biz_id
        # This parameter is required.
        self.open_ticket_id = open_ticket_id
        # This parameter is required.
        self.processor_union_ids = processor_union_ids
        # This parameter is required.
        self.scene = scene
        self.scene_context = scene_context
        self.ticket_memo = ticket_memo
        # This parameter is required.
        self.title = title

    def validate(self):
        if self.notify:
            self.notify.validate()
        if self.scene_context:
            self.scene_context.validate()
        if self.ticket_memo:
            self.ticket_memo.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.creator_union_id is not None:
            result['creatorUnionId'] = self.creator_union_id
        if self.custom_fields is not None:
            result['customFields'] = self.custom_fields
        if self.notify is not None:
            result['notify'] = self.notify.to_map()
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.open_template_biz_id is not None:
            result['openTemplateBizId'] = self.open_template_biz_id
        if self.open_ticket_id is not None:
            result['openTicketId'] = self.open_ticket_id
        if self.processor_union_ids is not None:
            result['processorUnionIds'] = self.processor_union_ids
        if self.scene is not None:
            result['scene'] = self.scene
        if self.scene_context is not None:
            result['sceneContext'] = self.scene_context.to_map()
        if self.ticket_memo is not None:
            result['ticketMemo'] = self.ticket_memo.to_map()
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('creatorUnionId') is not None:
            self.creator_union_id = m.get('creatorUnionId')
        if m.get('customFields') is not None:
            self.custom_fields = m.get('customFields')
        if m.get('notify') is not None:
            temp_model = ResubmitTicketRequestNotify()
            self.notify = temp_model.from_map(m['notify'])
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('openTemplateBizId') is not None:
            self.open_template_biz_id = m.get('openTemplateBizId')
        if m.get('openTicketId') is not None:
            self.open_ticket_id = m.get('openTicketId')
        if m.get('processorUnionIds') is not None:
            self.processor_union_ids = m.get('processorUnionIds')
        if m.get('scene') is not None:
            self.scene = m.get('scene')
        if m.get('sceneContext') is not None:
            temp_model = ResubmitTicketRequestSceneContext()
            self.scene_context = temp_model.from_map(m['sceneContext'])
        if m.get('ticketMemo') is not None:
            temp_model = ResubmitTicketRequestTicketMemo()
            self.ticket_memo = temp_model.from_map(m['ticketMemo'])
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class ResubmitTicketResponse(TeaModel):
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


class RetractTicketHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class RetractTicketRequestNotify(TeaModel):
    def __init__(
        self,
        group_notice_receiver_union_ids: List[str] = None,
        notice_all_group_member: bool = None,
        work_notice_receiver_union_ids: List[str] = None,
    ):
        self.group_notice_receiver_union_ids = group_notice_receiver_union_ids
        self.notice_all_group_member = notice_all_group_member
        self.work_notice_receiver_union_ids = work_notice_receiver_union_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_notice_receiver_union_ids is not None:
            result['groupNoticeReceiverUnionIds'] = self.group_notice_receiver_union_ids
        if self.notice_all_group_member is not None:
            result['noticeAllGroupMember'] = self.notice_all_group_member
        if self.work_notice_receiver_union_ids is not None:
            result['workNoticeReceiverUnionIds'] = self.work_notice_receiver_union_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupNoticeReceiverUnionIds') is not None:
            self.group_notice_receiver_union_ids = m.get('groupNoticeReceiverUnionIds')
        if m.get('noticeAllGroupMember') is not None:
            self.notice_all_group_member = m.get('noticeAllGroupMember')
        if m.get('workNoticeReceiverUnionIds') is not None:
            self.work_notice_receiver_union_ids = m.get('workNoticeReceiverUnionIds')
        return self


class RetractTicketRequestTicketMemoAttachments(TeaModel):
    def __init__(
        self,
        file_name: str = None,
        key: str = None,
    ):
        self.file_name = file_name
        self.key = key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.key is not None:
            result['key'] = self.key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('key') is not None:
            self.key = m.get('key')
        return self


class RetractTicketRequestTicketMemo(TeaModel):
    def __init__(
        self,
        attachments: List[RetractTicketRequestTicketMemoAttachments] = None,
        memo: str = None,
    ):
        self.attachments = attachments
        self.memo = memo

    def validate(self):
        if self.attachments:
            for k in self.attachments:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['attachments'] = []
        if self.attachments is not None:
            for k in self.attachments:
                result['attachments'].append(k.to_map() if k else None)
        if self.memo is not None:
            result['memo'] = self.memo
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attachments = []
        if m.get('attachments') is not None:
            for k in m.get('attachments'):
                temp_model = RetractTicketRequestTicketMemoAttachments()
                self.attachments.append(temp_model.from_map(k))
        if m.get('memo') is not None:
            self.memo = m.get('memo')
        return self


class RetractTicketRequest(TeaModel):
    def __init__(
        self,
        notify: RetractTicketRequestNotify = None,
        open_team_id: str = None,
        open_ticket_id: str = None,
        operator_union_id: str = None,
        ticket_memo: RetractTicketRequestTicketMemo = None,
    ):
        self.notify = notify
        # This parameter is required.
        self.open_team_id = open_team_id
        # This parameter is required.
        self.open_ticket_id = open_ticket_id
        self.operator_union_id = operator_union_id
        self.ticket_memo = ticket_memo

    def validate(self):
        if self.notify:
            self.notify.validate()
        if self.ticket_memo:
            self.ticket_memo.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.notify is not None:
            result['notify'] = self.notify.to_map()
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.open_ticket_id is not None:
            result['openTicketId'] = self.open_ticket_id
        if self.operator_union_id is not None:
            result['operatorUnionId'] = self.operator_union_id
        if self.ticket_memo is not None:
            result['ticketMemo'] = self.ticket_memo.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('notify') is not None:
            temp_model = RetractTicketRequestNotify()
            self.notify = temp_model.from_map(m['notify'])
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('openTicketId') is not None:
            self.open_ticket_id = m.get('openTicketId')
        if m.get('operatorUnionId') is not None:
            self.operator_union_id = m.get('operatorUnionId')
        if m.get('ticketMemo') is not None:
            temp_model = RetractTicketRequestTicketMemo()
            self.ticket_memo = temp_model.from_map(m['ticketMemo'])
        return self


class RetractTicketResponse(TeaModel):
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


class RobotMessageRecallHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class RobotMessageRecallRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        open_msg_id: str = None,
        open_team_id: str = None,
    ):
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.open_msg_id = open_msg_id
        # This parameter is required.
        self.open_team_id = open_team_id

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
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('openMsgId') is not None:
            self.open_msg_id = m.get('openMsgId')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        return self


class RobotMessageRecallResponseBody(TeaModel):
    def __init__(
        self,
        result: str = None,
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


class RobotMessageRecallResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RobotMessageRecallResponseBody = None,
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
            temp_model = RobotMessageRecallResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SaveFormInstanceHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class SaveFormInstanceRequest(TeaModel):
    def __init__(
        self,
        form_data_list: str = None,
        open_team_id: str = None,
        operator_union_id: str = None,
        owner_union_id: str = None,
    ):
        # This parameter is required.
        self.form_data_list = form_data_list
        # This parameter is required.
        self.open_team_id = open_team_id
        self.operator_union_id = operator_union_id
        self.owner_union_id = owner_union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.form_data_list is not None:
            result['formDataList'] = self.form_data_list
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.operator_union_id is not None:
            result['operatorUnionId'] = self.operator_union_id
        if self.owner_union_id is not None:
            result['ownerUnionId'] = self.owner_union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('formDataList') is not None:
            self.form_data_list = m.get('formDataList')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('operatorUnionId') is not None:
            self.operator_union_id = m.get('operatorUnionId')
        if m.get('ownerUnionId') is not None:
            self.owner_union_id = m.get('ownerUnionId')
        return self


class SaveFormInstanceResponseBody(TeaModel):
    def __init__(
        self,
        open_contact_id: str = None,
        open_customer_id: str = None,
    ):
        self.open_contact_id = open_contact_id
        self.open_customer_id = open_customer_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_contact_id is not None:
            result['openContactId'] = self.open_contact_id
        if self.open_customer_id is not None:
            result['openCustomerId'] = self.open_customer_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openContactId') is not None:
            self.open_contact_id = m.get('openContactId')
        if m.get('openCustomerId') is not None:
            self.open_customer_id = m.get('openCustomerId')
        return self


class SaveFormInstanceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SaveFormInstanceResponseBody = None,
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
            temp_model = SaveFormInstanceResponseBody()
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
        group_name: str = None,
        max_results: int = None,
        next_token: str = None,
        open_conversation_id: str = None,
        open_group_set_id: str = None,
        open_team_id: str = None,
        search_type: str = None,
    ):
        self.group_name = group_name
        self.max_results = max_results
        self.next_token = next_token
        self.open_conversation_id = open_conversation_id
        self.open_group_set_id = open_group_set_id
        self.open_team_id = open_team_id
        self.search_type = search_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.open_group_set_id is not None:
            result['openGroupSetId'] = self.open_group_set_id
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.search_type is not None:
            result['searchType'] = self.search_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('openGroupSetId') is not None:
            self.open_group_set_id = m.get('openGroupSetId')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('searchType') is not None:
            self.search_type = m.get('searchType')
        return self


class SearchGroupResponseBodyRecords(TeaModel):
    def __init__(
        self,
        group_name: str = None,
        group_url: str = None,
        open_conversation_id: str = None,
        open_group_set_id: str = None,
        open_team_id: str = None,
    ):
        # This parameter is required.
        self.group_name = group_name
        # This parameter is required.
        self.group_url = group_url
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        # This parameter is required.
        self.open_group_set_id = open_group_set_id
        # This parameter is required.
        self.open_team_id = open_team_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_name is not None:
            result['groupName'] = self.group_name
        if self.group_url is not None:
            result['groupUrl'] = self.group_url
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.open_group_set_id is not None:
            result['openGroupSetId'] = self.open_group_set_id
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupName') is not None:
            self.group_name = m.get('groupName')
        if m.get('groupUrl') is not None:
            self.group_url = m.get('groupUrl')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('openGroupSetId') is not None:
            self.open_group_set_id = m.get('openGroupSetId')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        return self


class SearchGroupResponseBody(TeaModel):
    def __init__(
        self,
        max_results: int = None,
        next_token: str = None,
        records: List[SearchGroupResponseBodyRecords] = None,
        total_count: int = None,
    ):
        self.max_results = max_results
        # This parameter is required.
        self.next_token = next_token
        self.records = records
        self.total_count = total_count

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
        if self.max_results is not None:
            result['maxResults'] = self.max_results
        if self.next_token is not None:
            result['nextToken'] = self.next_token
        result['records'] = []
        if self.records is not None:
            for k in self.records:
                result['records'].append(k.to_map() if k else None)
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxResults') is not None:
            self.max_results = m.get('maxResults')
        if m.get('nextToken') is not None:
            self.next_token = m.get('nextToken')
        self.records = []
        if m.get('records') is not None:
            for k in m.get('records'):
                temp_model = SearchGroupResponseBodyRecords()
                self.records.append(temp_model.from_map(k))
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class SearchGroupResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SearchGroupResponseBody = None,
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
            temp_model = SearchGroupResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SendMsgByTaskHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class SendMsgByTaskRequestMessageContentBtns(TeaModel):
    def __init__(
        self,
        action_url: str = None,
        title: str = None,
    ):
        self.action_url = action_url
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


class SendMsgByTaskRequestMessageContent(TeaModel):
    def __init__(
        self,
        at_active_member_num: int = None,
        at_active_user: bool = None,
        at_all: bool = None,
        btns: List[SendMsgByTaskRequestMessageContentBtns] = None,
        content: str = None,
        images: List[str] = None,
        message_type: str = None,
        remind: bool = None,
        title: str = None,
        top: bool = None,
    ):
        self.at_active_member_num = at_active_member_num
        self.at_active_user = at_active_user
        self.at_all = at_all
        self.btns = btns
        self.content = content
        self.images = images
        # This parameter is required.
        self.message_type = message_type
        self.remind = remind
        self.title = title
        self.top = top

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
        if self.at_active_member_num is not None:
            result['atActiveMemberNum'] = self.at_active_member_num
        if self.at_active_user is not None:
            result['atActiveUser'] = self.at_active_user
        if self.at_all is not None:
            result['atAll'] = self.at_all
        result['btns'] = []
        if self.btns is not None:
            for k in self.btns:
                result['btns'].append(k.to_map() if k else None)
        if self.content is not None:
            result['content'] = self.content
        if self.images is not None:
            result['images'] = self.images
        if self.message_type is not None:
            result['messageType'] = self.message_type
        if self.remind is not None:
            result['remind'] = self.remind
        if self.title is not None:
            result['title'] = self.title
        if self.top is not None:
            result['top'] = self.top
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('atActiveMemberNum') is not None:
            self.at_active_member_num = m.get('atActiveMemberNum')
        if m.get('atActiveUser') is not None:
            self.at_active_user = m.get('atActiveUser')
        if m.get('atAll') is not None:
            self.at_all = m.get('atAll')
        self.btns = []
        if m.get('btns') is not None:
            for k in m.get('btns'):
                temp_model = SendMsgByTaskRequestMessageContentBtns()
                self.btns.append(temp_model.from_map(k))
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('images') is not None:
            self.images = m.get('images')
        if m.get('messageType') is not None:
            self.message_type = m.get('messageType')
        if m.get('remind') is not None:
            self.remind = m.get('remind')
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('top') is not None:
            self.top = m.get('top')
        return self


class SendMsgByTaskRequestQueryGroup(TeaModel):
    def __init__(
        self,
        group_tag_names: List[str] = None,
        last_active_date_filter_type: str = None,
        last_active_time_end: str = None,
        last_active_time_start: str = None,
        open_conversation_ids: List[str] = None,
        open_group_set_id: str = None,
        query_type: str = None,
    ):
        self.group_tag_names = group_tag_names
        self.last_active_date_filter_type = last_active_date_filter_type
        self.last_active_time_end = last_active_time_end
        self.last_active_time_start = last_active_time_start
        self.open_conversation_ids = open_conversation_ids
        self.open_group_set_id = open_group_set_id
        # This parameter is required.
        self.query_type = query_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_tag_names is not None:
            result['groupTagNames'] = self.group_tag_names
        if self.last_active_date_filter_type is not None:
            result['lastActiveDateFilterType'] = self.last_active_date_filter_type
        if self.last_active_time_end is not None:
            result['lastActiveTimeEnd'] = self.last_active_time_end
        if self.last_active_time_start is not None:
            result['lastActiveTimeStart'] = self.last_active_time_start
        if self.open_conversation_ids is not None:
            result['openConversationIds'] = self.open_conversation_ids
        if self.open_group_set_id is not None:
            result['openGroupSetId'] = self.open_group_set_id
        if self.query_type is not None:
            result['queryType'] = self.query_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupTagNames') is not None:
            self.group_tag_names = m.get('groupTagNames')
        if m.get('lastActiveDateFilterType') is not None:
            self.last_active_date_filter_type = m.get('lastActiveDateFilterType')
        if m.get('lastActiveTimeEnd') is not None:
            self.last_active_time_end = m.get('lastActiveTimeEnd')
        if m.get('lastActiveTimeStart') is not None:
            self.last_active_time_start = m.get('lastActiveTimeStart')
        if m.get('openConversationIds') is not None:
            self.open_conversation_ids = m.get('openConversationIds')
        if m.get('openGroupSetId') is not None:
            self.open_group_set_id = m.get('openGroupSetId')
        if m.get('queryType') is not None:
            self.query_type = m.get('queryType')
        return self


class SendMsgByTaskRequestSendConfigUrlTrackConfig(TeaModel):
    def __init__(
        self,
        title: str = None,
        track_id: str = None,
        track_url: str = None,
    ):
        self.title = title
        self.track_id = track_id
        self.track_url = track_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.title is not None:
            result['title'] = self.title
        if self.track_id is not None:
            result['trackId'] = self.track_id
        if self.track_url is not None:
            result['trackUrl'] = self.track_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('title') is not None:
            self.title = m.get('title')
        if m.get('trackId') is not None:
            self.track_id = m.get('trackId')
        if m.get('trackUrl') is not None:
            self.track_url = m.get('trackUrl')
        return self


class SendMsgByTaskRequestSendConfig(TeaModel):
    def __init__(
        self,
        need_url_track: bool = None,
        send_time: str = None,
        send_type: str = None,
        url_track_config: List[SendMsgByTaskRequestSendConfigUrlTrackConfig] = None,
    ):
        self.need_url_track = need_url_track
        self.send_time = send_time
        # This parameter is required.
        self.send_type = send_type
        self.url_track_config = url_track_config

    def validate(self):
        if self.url_track_config:
            for k in self.url_track_config:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.need_url_track is not None:
            result['needUrlTrack'] = self.need_url_track
        if self.send_time is not None:
            result['sendTime'] = self.send_time
        if self.send_type is not None:
            result['sendType'] = self.send_type
        result['urlTrackConfig'] = []
        if self.url_track_config is not None:
            for k in self.url_track_config:
                result['urlTrackConfig'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('needUrlTrack') is not None:
            self.need_url_track = m.get('needUrlTrack')
        if m.get('sendTime') is not None:
            self.send_time = m.get('sendTime')
        if m.get('sendType') is not None:
            self.send_type = m.get('sendType')
        self.url_track_config = []
        if m.get('urlTrackConfig') is not None:
            for k in m.get('urlTrackConfig'):
                temp_model = SendMsgByTaskRequestSendConfigUrlTrackConfig()
                self.url_track_config.append(temp_model.from_map(k))
        return self


class SendMsgByTaskRequest(TeaModel):
    def __init__(
        self,
        message_content: SendMsgByTaskRequestMessageContent = None,
        open_team_id: str = None,
        query_group: SendMsgByTaskRequestQueryGroup = None,
        send_config: SendMsgByTaskRequestSendConfig = None,
        task_name: str = None,
    ):
        # This parameter is required.
        self.message_content = message_content
        # This parameter is required.
        self.open_team_id = open_team_id
        # This parameter is required.
        self.query_group = query_group
        # This parameter is required.
        self.send_config = send_config
        # This parameter is required.
        self.task_name = task_name

    def validate(self):
        if self.message_content:
            self.message_content.validate()
        if self.query_group:
            self.query_group.validate()
        if self.send_config:
            self.send_config.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.message_content is not None:
            result['messageContent'] = self.message_content.to_map()
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.query_group is not None:
            result['queryGroup'] = self.query_group.to_map()
        if self.send_config is not None:
            result['sendConfig'] = self.send_config.to_map()
        if self.task_name is not None:
            result['taskName'] = self.task_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('messageContent') is not None:
            temp_model = SendMsgByTaskRequestMessageContent()
            self.message_content = temp_model.from_map(m['messageContent'])
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('queryGroup') is not None:
            temp_model = SendMsgByTaskRequestQueryGroup()
            self.query_group = temp_model.from_map(m['queryGroup'])
        if m.get('sendConfig') is not None:
            temp_model = SendMsgByTaskRequestSendConfig()
            self.send_config = temp_model.from_map(m['sendConfig'])
        if m.get('taskName') is not None:
            self.task_name = m.get('taskName')
        return self


class SendMsgByTaskResponseBody(TeaModel):
    def __init__(
        self,
        open_batch_task_id: str = None,
    ):
        self.open_batch_task_id = open_batch_task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_batch_task_id is not None:
            result['openBatchTaskId'] = self.open_batch_task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openBatchTaskId') is not None:
            self.open_batch_task_id = m.get('openBatchTaskId')
        return self


class SendMsgByTaskResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SendMsgByTaskResponseBody = None,
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
            temp_model = SendMsgByTaskResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SendMsgByTaskSupportInviteJoinOrgHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class SendMsgByTaskSupportInviteJoinOrgRequestMessageContentBtns(TeaModel):
    def __init__(
        self,
        action_url: str = None,
        title: str = None,
    ):
        self.action_url = action_url
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


class SendMsgByTaskSupportInviteJoinOrgRequestMessageContent(TeaModel):
    def __init__(
        self,
        btns: List[SendMsgByTaskSupportInviteJoinOrgRequestMessageContentBtns] = None,
        content: str = None,
        message_type: str = None,
        title: str = None,
    ):
        self.btns = btns
        # This parameter is required.
        self.content = content
        # This parameter is required.
        self.message_type = message_type
        # This parameter is required.
        self.title = title

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
        result['btns'] = []
        if self.btns is not None:
            for k in self.btns:
                result['btns'].append(k.to_map() if k else None)
        if self.content is not None:
            result['content'] = self.content
        if self.message_type is not None:
            result['messageType'] = self.message_type
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.btns = []
        if m.get('btns') is not None:
            for k in m.get('btns'):
                temp_model = SendMsgByTaskSupportInviteJoinOrgRequestMessageContentBtns()
                self.btns.append(temp_model.from_map(k))
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('messageType') is not None:
            self.message_type = m.get('messageType')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class SendMsgByTaskSupportInviteJoinOrgRequest(TeaModel):
    def __init__(
        self,
        message_content: SendMsgByTaskSupportInviteJoinOrgRequestMessageContent = None,
        mobile_phones: List[str] = None,
        need_url_track: bool = None,
        open_team_id: str = None,
        send_channel: str = None,
        task_name: str = None,
    ):
        # This parameter is required.
        self.message_content = message_content
        # This parameter is required.
        self.mobile_phones = mobile_phones
        # This parameter is required.
        self.need_url_track = need_url_track
        # This parameter is required.
        self.open_team_id = open_team_id
        # This parameter is required.
        self.send_channel = send_channel
        # This parameter is required.
        self.task_name = task_name

    def validate(self):
        if self.message_content:
            self.message_content.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.message_content is not None:
            result['messageContent'] = self.message_content.to_map()
        if self.mobile_phones is not None:
            result['mobilePhones'] = self.mobile_phones
        if self.need_url_track is not None:
            result['needUrlTrack'] = self.need_url_track
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.send_channel is not None:
            result['sendChannel'] = self.send_channel
        if self.task_name is not None:
            result['taskName'] = self.task_name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('messageContent') is not None:
            temp_model = SendMsgByTaskSupportInviteJoinOrgRequestMessageContent()
            self.message_content = temp_model.from_map(m['messageContent'])
        if m.get('mobilePhones') is not None:
            self.mobile_phones = m.get('mobilePhones')
        if m.get('needUrlTrack') is not None:
            self.need_url_track = m.get('needUrlTrack')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('sendChannel') is not None:
            self.send_channel = m.get('sendChannel')
        if m.get('taskName') is not None:
            self.task_name = m.get('taskName')
        return self


class SendMsgByTaskSupportInviteJoinOrgResponseBody(TeaModel):
    def __init__(
        self,
        open_batch_task_id: str = None,
    ):
        self.open_batch_task_id = open_batch_task_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_batch_task_id is not None:
            result['openBatchTaskId'] = self.open_batch_task_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openBatchTaskId') is not None:
            self.open_batch_task_id = m.get('openBatchTaskId')
        return self


class SendMsgByTaskSupportInviteJoinOrgResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SendMsgByTaskSupportInviteJoinOrgResponseBody = None,
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
            temp_model = SendMsgByTaskSupportInviteJoinOrgResponseBody()
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
        self.action_url = action_url
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
        at_dingtalk_ids: List[str] = None,
        at_mobiles: List[str] = None,
        at_union_ids: List[str] = None,
        btn_orientation: str = None,
        btns: List[SendServiceGroupMessageRequestBtns] = None,
        content: str = None,
        has_content_links: bool = None,
        is_at_all: bool = None,
        message_type: str = None,
        receiver_dingtalk_ids: List[str] = None,
        receiver_mobiles: List[str] = None,
        receiver_union_ids: List[str] = None,
        target_open_conversation_id: str = None,
        title: str = None,
    ):
        self.at_dingtalk_ids = at_dingtalk_ids
        self.at_mobiles = at_mobiles
        self.at_union_ids = at_union_ids
        self.btn_orientation = btn_orientation
        self.btns = btns
        # This parameter is required.
        self.content = content
        self.has_content_links = has_content_links
        self.is_at_all = is_at_all
        # This parameter is required.
        self.message_type = message_type
        self.receiver_dingtalk_ids = receiver_dingtalk_ids
        self.receiver_mobiles = receiver_mobiles
        self.receiver_union_ids = receiver_union_ids
        # This parameter is required.
        self.target_open_conversation_id = target_open_conversation_id
        # This parameter is required.
        self.title = title

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
        if self.at_dingtalk_ids is not None:
            result['atDingtalkIds'] = self.at_dingtalk_ids
        if self.at_mobiles is not None:
            result['atMobiles'] = self.at_mobiles
        if self.at_union_ids is not None:
            result['atUnionIds'] = self.at_union_ids
        if self.btn_orientation is not None:
            result['btnOrientation'] = self.btn_orientation
        result['btns'] = []
        if self.btns is not None:
            for k in self.btns:
                result['btns'].append(k.to_map() if k else None)
        if self.content is not None:
            result['content'] = self.content
        if self.has_content_links is not None:
            result['hasContentLinks'] = self.has_content_links
        if self.is_at_all is not None:
            result['isAtAll'] = self.is_at_all
        if self.message_type is not None:
            result['messageType'] = self.message_type
        if self.receiver_dingtalk_ids is not None:
            result['receiverDingtalkIds'] = self.receiver_dingtalk_ids
        if self.receiver_mobiles is not None:
            result['receiverMobiles'] = self.receiver_mobiles
        if self.receiver_union_ids is not None:
            result['receiverUnionIds'] = self.receiver_union_ids
        if self.target_open_conversation_id is not None:
            result['targetOpenConversationId'] = self.target_open_conversation_id
        if self.title is not None:
            result['title'] = self.title
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('atDingtalkIds') is not None:
            self.at_dingtalk_ids = m.get('atDingtalkIds')
        if m.get('atMobiles') is not None:
            self.at_mobiles = m.get('atMobiles')
        if m.get('atUnionIds') is not None:
            self.at_union_ids = m.get('atUnionIds')
        if m.get('btnOrientation') is not None:
            self.btn_orientation = m.get('btnOrientation')
        self.btns = []
        if m.get('btns') is not None:
            for k in m.get('btns'):
                temp_model = SendServiceGroupMessageRequestBtns()
                self.btns.append(temp_model.from_map(k))
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('hasContentLinks') is not None:
            self.has_content_links = m.get('hasContentLinks')
        if m.get('isAtAll') is not None:
            self.is_at_all = m.get('isAtAll')
        if m.get('messageType') is not None:
            self.message_type = m.get('messageType')
        if m.get('receiverDingtalkIds') is not None:
            self.receiver_dingtalk_ids = m.get('receiverDingtalkIds')
        if m.get('receiverMobiles') is not None:
            self.receiver_mobiles = m.get('receiverMobiles')
        if m.get('receiverUnionIds') is not None:
            self.receiver_union_ids = m.get('receiverUnionIds')
        if m.get('targetOpenConversationId') is not None:
            self.target_open_conversation_id = m.get('targetOpenConversationId')
        if m.get('title') is not None:
            self.title = m.get('title')
        return self


class SendServiceGroupMessageResponseBody(TeaModel):
    def __init__(
        self,
        open_msg_task_id: str = None,
    ):
        # This parameter is required.
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
        status_code: int = None,
        body: SendServiceGroupMessageResponseBody = None,
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
            temp_model = SendServiceGroupMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class SetRobotConfigHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class SetRobotConfigRequest(TeaModel):
    def __init__(
        self,
        ding_isv_org_id: int = None,
        ding_org_id: int = None,
        ding_suite_key: str = None,
        ding_token_grant_type: int = None,
        open_group_set_id: str = None,
        open_team_id: str = None,
        status: str = None,
    ):
        self.ding_isv_org_id = ding_isv_org_id
        self.ding_org_id = ding_org_id
        self.ding_suite_key = ding_suite_key
        self.ding_token_grant_type = ding_token_grant_type
        self.open_group_set_id = open_group_set_id
        self.open_team_id = open_team_id
        self.status = status

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
        if self.open_group_set_id is not None:
            result['openGroupSetId'] = self.open_group_set_id
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.status is not None:
            result['status'] = self.status
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
        if m.get('openGroupSetId') is not None:
            self.open_group_set_id = m.get('openGroupSetId')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('status') is not None:
            self.status = m.get('status')
        return self


class SetRobotConfigResponseBodyResult(TeaModel):
    def __init__(
        self,
        config_key: str = None,
        config_value: str = None,
    ):
        self.config_key = config_key
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


class SetRobotConfigResponseBody(TeaModel):
    def __init__(
        self,
        result: SetRobotConfigResponseBodyResult = None,
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
            temp_model = SetRobotConfigResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        return self


class SetRobotConfigResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: SetRobotConfigResponseBody = None,
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
            temp_model = SetRobotConfigResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class TakeTicketHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class TakeTicketRequest(TeaModel):
    def __init__(
        self,
        open_team_id: str = None,
        open_ticket_id: str = None,
        taker_union_id: str = None,
    ):
        # This parameter is required.
        self.open_team_id = open_team_id
        # This parameter is required.
        self.open_ticket_id = open_ticket_id
        # This parameter is required.
        self.taker_union_id = taker_union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.open_ticket_id is not None:
            result['openTicketId'] = self.open_ticket_id
        if self.taker_union_id is not None:
            result['takerUnionId'] = self.taker_union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('openTicketId') is not None:
            self.open_ticket_id = m.get('openTicketId')
        if m.get('takerUnionId') is not None:
            self.taker_union_id = m.get('takerUnionId')
        return self


class TakeTicketResponse(TeaModel):
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


class TopicStatisticsHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class TopicStatisticsRequest(TeaModel):
    def __init__(
        self,
        max_dt: str = None,
        min_dt: str = None,
        open_conversation_ids: str = None,
        open_team_id: str = None,
        search_content: str = None,
    ):
        # This parameter is required.
        self.max_dt = max_dt
        # This parameter is required.
        self.min_dt = min_dt
        self.open_conversation_ids = open_conversation_ids
        # This parameter is required.
        self.open_team_id = open_team_id
        self.search_content = search_content

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.max_dt is not None:
            result['maxDt'] = self.max_dt
        if self.min_dt is not None:
            result['minDt'] = self.min_dt
        if self.open_conversation_ids is not None:
            result['openConversationIds'] = self.open_conversation_ids
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.search_content is not None:
            result['searchContent'] = self.search_content
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('maxDt') is not None:
            self.max_dt = m.get('maxDt')
        if m.get('minDt') is not None:
            self.min_dt = m.get('minDt')
        if m.get('openConversationIds') is not None:
            self.open_conversation_ids = m.get('openConversationIds')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('searchContent') is not None:
            self.search_content = m.get('searchContent')
        return self


class TopicStatisticsResponseBodyTopicStatisticsRecords(TeaModel):
    def __init__(
        self,
        dt: str = None,
        msg_count: int = None,
        participants_num: int = None,
        topic_num: int = None,
    ):
        # This parameter is required.
        self.dt = dt
        # This parameter is required.
        self.msg_count = msg_count
        # This parameter is required.
        self.participants_num = participants_num
        # This parameter is required.
        self.topic_num = topic_num

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dt is not None:
            result['dt'] = self.dt
        if self.msg_count is not None:
            result['msgCount'] = self.msg_count
        if self.participants_num is not None:
            result['participantsNum'] = self.participants_num
        if self.topic_num is not None:
            result['topicNum'] = self.topic_num
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('dt') is not None:
            self.dt = m.get('dt')
        if m.get('msgCount') is not None:
            self.msg_count = m.get('msgCount')
        if m.get('participantsNum') is not None:
            self.participants_num = m.get('participantsNum')
        if m.get('topicNum') is not None:
            self.topic_num = m.get('topicNum')
        return self


class TopicStatisticsResponseBody(TeaModel):
    def __init__(
        self,
        topic_statistics_records: List[TopicStatisticsResponseBodyTopicStatisticsRecords] = None,
    ):
        # This parameter is required.
        self.topic_statistics_records = topic_statistics_records

    def validate(self):
        if self.topic_statistics_records:
            for k in self.topic_statistics_records:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['topicStatisticsRecords'] = []
        if self.topic_statistics_records is not None:
            for k in self.topic_statistics_records:
                result['topicStatisticsRecords'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.topic_statistics_records = []
        if m.get('topicStatisticsRecords') is not None:
            for k in m.get('topicStatisticsRecords'):
                temp_model = TopicStatisticsResponseBodyTopicStatisticsRecords()
                self.topic_statistics_records.append(temp_model.from_map(k))
        return self


class TopicStatisticsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: TopicStatisticsResponseBody = None,
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
            temp_model = TopicStatisticsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class TransferTicketHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class TransferTicketRequestNotify(TeaModel):
    def __init__(
        self,
        group_notice_receiver_union_ids: List[str] = None,
        notice_all_group_member: bool = None,
        work_notice_receiver_union_ids: List[str] = None,
    ):
        self.group_notice_receiver_union_ids = group_notice_receiver_union_ids
        self.notice_all_group_member = notice_all_group_member
        self.work_notice_receiver_union_ids = work_notice_receiver_union_ids

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.group_notice_receiver_union_ids is not None:
            result['groupNoticeReceiverUnionIds'] = self.group_notice_receiver_union_ids
        if self.notice_all_group_member is not None:
            result['noticeAllGroupMember'] = self.notice_all_group_member
        if self.work_notice_receiver_union_ids is not None:
            result['workNoticeReceiverUnionIds'] = self.work_notice_receiver_union_ids
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('groupNoticeReceiverUnionIds') is not None:
            self.group_notice_receiver_union_ids = m.get('groupNoticeReceiverUnionIds')
        if m.get('noticeAllGroupMember') is not None:
            self.notice_all_group_member = m.get('noticeAllGroupMember')
        if m.get('workNoticeReceiverUnionIds') is not None:
            self.work_notice_receiver_union_ids = m.get('workNoticeReceiverUnionIds')
        return self


class TransferTicketRequestTicketMemoAttachments(TeaModel):
    def __init__(
        self,
        file_name: str = None,
        key: str = None,
    ):
        self.file_name = file_name
        self.key = key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.key is not None:
            result['key'] = self.key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('key') is not None:
            self.key = m.get('key')
        return self


class TransferTicketRequestTicketMemo(TeaModel):
    def __init__(
        self,
        attachments: List[TransferTicketRequestTicketMemoAttachments] = None,
        memo: str = None,
    ):
        self.attachments = attachments
        self.memo = memo

    def validate(self):
        if self.attachments:
            for k in self.attachments:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['attachments'] = []
        if self.attachments is not None:
            for k in self.attachments:
                result['attachments'].append(k.to_map() if k else None)
        if self.memo is not None:
            result['memo'] = self.memo
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attachments = []
        if m.get('attachments') is not None:
            for k in m.get('attachments'):
                temp_model = TransferTicketRequestTicketMemoAttachments()
                self.attachments.append(temp_model.from_map(k))
        if m.get('memo') is not None:
            self.memo = m.get('memo')
        return self


class TransferTicketRequest(TeaModel):
    def __init__(
        self,
        notify: TransferTicketRequestNotify = None,
        open_team_id: str = None,
        open_ticket_id: str = None,
        processor_union_id: str = None,
        processor_union_ids: List[str] = None,
        ticket_memo: TransferTicketRequestTicketMemo = None,
    ):
        self.notify = notify
        # This parameter is required.
        self.open_team_id = open_team_id
        # This parameter is required.
        self.open_ticket_id = open_ticket_id
        # This parameter is required.
        self.processor_union_id = processor_union_id
        # This parameter is required.
        self.processor_union_ids = processor_union_ids
        self.ticket_memo = ticket_memo

    def validate(self):
        if self.notify:
            self.notify.validate()
        if self.ticket_memo:
            self.ticket_memo.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.notify is not None:
            result['notify'] = self.notify.to_map()
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.open_ticket_id is not None:
            result['openTicketId'] = self.open_ticket_id
        if self.processor_union_id is not None:
            result['processorUnionId'] = self.processor_union_id
        if self.processor_union_ids is not None:
            result['processorUnionIds'] = self.processor_union_ids
        if self.ticket_memo is not None:
            result['ticketMemo'] = self.ticket_memo.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('notify') is not None:
            temp_model = TransferTicketRequestNotify()
            self.notify = temp_model.from_map(m['notify'])
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('openTicketId') is not None:
            self.open_ticket_id = m.get('openTicketId')
        if m.get('processorUnionId') is not None:
            self.processor_union_id = m.get('processorUnionId')
        if m.get('processorUnionIds') is not None:
            self.processor_union_ids = m.get('processorUnionIds')
        if m.get('ticketMemo') is not None:
            temp_model = TransferTicketRequestTicketMemo()
            self.ticket_memo = temp_model.from_map(m['ticketMemo'])
        return self


class TransferTicketResponse(TeaModel):
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


class UpdateGroupSetHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class UpdateGroupSetRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        open_group_set_id: str = None,
        open_team_id: str = None,
    ):
        self.open_conversation_id = open_conversation_id
        self.open_group_set_id = open_group_set_id
        self.open_team_id = open_team_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.open_group_set_id is not None:
            result['openGroupSetId'] = self.open_group_set_id
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('openGroupSetId') is not None:
            self.open_group_set_id = m.get('openGroupSetId')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        return self


class UpdateGroupSetResponseBody(TeaModel):
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


class UpdateGroupSetResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateGroupSetResponseBody = None,
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
            temp_model = UpdateGroupSetResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateGroupTagHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class UpdateGroupTagRequest(TeaModel):
    def __init__(
        self,
        open_conversation_ids: List[str] = None,
        tag_names: List[str] = None,
        update_type: str = None,
    ):
        # This parameter is required.
        self.open_conversation_ids = open_conversation_ids
        self.tag_names = tag_names
        # This parameter is required.
        self.update_type = update_type

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_ids is not None:
            result['openConversationIds'] = self.open_conversation_ids
        if self.tag_names is not None:
            result['tagNames'] = self.tag_names
        if self.update_type is not None:
            result['updateType'] = self.update_type
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationIds') is not None:
            self.open_conversation_ids = m.get('openConversationIds')
        if m.get('tagNames') is not None:
            self.tag_names = m.get('tagNames')
        if m.get('updateType') is not None:
            self.update_type = m.get('updateType')
        return self


class UpdateGroupTagResponse(TeaModel):
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


class UpdateInstanceHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class UpdateInstanceRequest(TeaModel):
    def __init__(
        self,
        external_biz_id: str = None,
        form_code: str = None,
        form_data_list: str = None,
        open_data_instance_id: str = None,
        open_team_id: str = None,
        operator_union_id: str = None,
        owner_union_id: str = None,
    ):
        self.external_biz_id = external_biz_id
        # This parameter is required.
        self.form_code = form_code
        # This parameter is required.
        self.form_data_list = form_data_list
        # This parameter is required.
        self.open_data_instance_id = open_data_instance_id
        # This parameter is required.
        self.open_team_id = open_team_id
        self.operator_union_id = operator_union_id
        self.owner_union_id = owner_union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.external_biz_id is not None:
            result['externalBizId'] = self.external_biz_id
        if self.form_code is not None:
            result['formCode'] = self.form_code
        if self.form_data_list is not None:
            result['formDataList'] = self.form_data_list
        if self.open_data_instance_id is not None:
            result['openDataInstanceId'] = self.open_data_instance_id
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.operator_union_id is not None:
            result['operatorUnionId'] = self.operator_union_id
        if self.owner_union_id is not None:
            result['ownerUnionId'] = self.owner_union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('externalBizId') is not None:
            self.external_biz_id = m.get('externalBizId')
        if m.get('formCode') is not None:
            self.form_code = m.get('formCode')
        if m.get('formDataList') is not None:
            self.form_data_list = m.get('formDataList')
        if m.get('openDataInstanceId') is not None:
            self.open_data_instance_id = m.get('openDataInstanceId')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('operatorUnionId') is not None:
            self.operator_union_id = m.get('operatorUnionId')
        if m.get('ownerUnionId') is not None:
            self.owner_union_id = m.get('ownerUnionId')
        return self


class UpdateInstanceResponseBody(TeaModel):
    def __init__(
        self,
        open_data_instance_id: str = None,
    ):
        self.open_data_instance_id = open_data_instance_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_data_instance_id is not None:
            result['openDataInstanceId'] = self.open_data_instance_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openDataInstanceId') is not None:
            self.open_data_instance_id = m.get('openDataInstanceId')
        return self


class UpdateInstanceResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateInstanceResponseBody = None,
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
            temp_model = UpdateInstanceResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateTicketHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class UpdateTicketRequestTicketMemoAttachments(TeaModel):
    def __init__(
        self,
        file_name: str = None,
        key: str = None,
    ):
        self.file_name = file_name
        self.key = key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.key is not None:
            result['key'] = self.key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('key') is not None:
            self.key = m.get('key')
        return self


class UpdateTicketRequestTicketMemo(TeaModel):
    def __init__(
        self,
        attachments: List[UpdateTicketRequestTicketMemoAttachments] = None,
        memo: str = None,
    ):
        self.attachments = attachments
        # This parameter is required.
        self.memo = memo

    def validate(self):
        if self.attachments:
            for k in self.attachments:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['attachments'] = []
        if self.attachments is not None:
            for k in self.attachments:
                result['attachments'].append(k.to_map() if k else None)
        if self.memo is not None:
            result['memo'] = self.memo
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attachments = []
        if m.get('attachments') is not None:
            for k in m.get('attachments'):
                temp_model = UpdateTicketRequestTicketMemoAttachments()
                self.attachments.append(temp_model.from_map(k))
        if m.get('memo') is not None:
            self.memo = m.get('memo')
        return self


class UpdateTicketRequest(TeaModel):
    def __init__(
        self,
        custom_fields: str = None,
        open_team_id: str = None,
        open_ticket_id: str = None,
        processor_union_id: str = None,
        ticket_memo: UpdateTicketRequestTicketMemo = None,
    ):
        self.custom_fields = custom_fields
        # This parameter is required.
        self.open_team_id = open_team_id
        # This parameter is required.
        self.open_ticket_id = open_ticket_id
        # This parameter is required.
        self.processor_union_id = processor_union_id
        # This parameter is required.
        self.ticket_memo = ticket_memo

    def validate(self):
        if self.ticket_memo:
            self.ticket_memo.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.custom_fields is not None:
            result['customFields'] = self.custom_fields
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.open_ticket_id is not None:
            result['openTicketId'] = self.open_ticket_id
        if self.processor_union_id is not None:
            result['processorUnionId'] = self.processor_union_id
        if self.ticket_memo is not None:
            result['ticketMemo'] = self.ticket_memo.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customFields') is not None:
            self.custom_fields = m.get('customFields')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('openTicketId') is not None:
            self.open_ticket_id = m.get('openTicketId')
        if m.get('processorUnionId') is not None:
            self.processor_union_id = m.get('processorUnionId')
        if m.get('ticketMemo') is not None:
            temp_model = UpdateTicketRequestTicketMemo()
            self.ticket_memo = temp_model.from_map(m['ticketMemo'])
        return self


class UpdateTicketResponse(TeaModel):
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


class UpgradeCloudGroupHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class UpgradeCloudGroupRequest(TeaModel):
    def __init__(
        self,
        ccs_instance_id: str = None,
        open_conversation_id: str = None,
        open_group_set_id: str = None,
        open_team_id: str = None,
        template_id: str = None,
    ):
        # This parameter is required.
        self.ccs_instance_id = ccs_instance_id
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        self.open_group_set_id = open_group_set_id
        self.open_team_id = open_team_id
        self.template_id = template_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.ccs_instance_id is not None:
            result['ccsInstanceId'] = self.ccs_instance_id
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.open_group_set_id is not None:
            result['openGroupSetId'] = self.open_group_set_id
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.template_id is not None:
            result['templateId'] = self.template_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('ccsInstanceId') is not None:
            self.ccs_instance_id = m.get('ccsInstanceId')
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('openGroupSetId') is not None:
            self.open_group_set_id = m.get('openGroupSetId')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('templateId') is not None:
            self.template_id = m.get('templateId')
        return self


class UpgradeCloudGroupResponse(TeaModel):
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


class UpgradeNormalGroupHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class UpgradeNormalGroupRequest(TeaModel):
    def __init__(
        self,
        open_conversation_id: str = None,
        open_group_set_id: str = None,
        open_team_id: str = None,
        template_id: str = None,
    ):
        # This parameter is required.
        self.open_conversation_id = open_conversation_id
        self.open_group_set_id = open_group_set_id
        self.open_team_id = open_team_id
        self.template_id = template_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_conversation_id is not None:
            result['openConversationId'] = self.open_conversation_id
        if self.open_group_set_id is not None:
            result['openGroupSetId'] = self.open_group_set_id
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.template_id is not None:
            result['templateId'] = self.template_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openConversationId') is not None:
            self.open_conversation_id = m.get('openConversationId')
        if m.get('openGroupSetId') is not None:
            self.open_group_set_id = m.get('openGroupSetId')
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('templateId') is not None:
            self.template_id = m.get('templateId')
        return self


class UpgradeNormalGroupResponse(TeaModel):
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


class UrgeTicketHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class UrgeTicketRequestTicketMemoAttachments(TeaModel):
    def __init__(
        self,
        file_name: str = None,
        key: str = None,
    ):
        self.file_name = file_name
        self.key = key

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.file_name is not None:
            result['fileName'] = self.file_name
        if self.key is not None:
            result['key'] = self.key
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('fileName') is not None:
            self.file_name = m.get('fileName')
        if m.get('key') is not None:
            self.key = m.get('key')
        return self


class UrgeTicketRequestTicketMemo(TeaModel):
    def __init__(
        self,
        attachments: List[UrgeTicketRequestTicketMemoAttachments] = None,
        memo: str = None,
    ):
        self.attachments = attachments
        # This parameter is required.
        self.memo = memo

    def validate(self):
        if self.attachments:
            for k in self.attachments:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        result['attachments'] = []
        if self.attachments is not None:
            for k in self.attachments:
                result['attachments'].append(k.to_map() if k else None)
        if self.memo is not None:
            result['memo'] = self.memo
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.attachments = []
        if m.get('attachments') is not None:
            for k in m.get('attachments'):
                temp_model = UrgeTicketRequestTicketMemoAttachments()
                self.attachments.append(temp_model.from_map(k))
        if m.get('memo') is not None:
            self.memo = m.get('memo')
        return self


class UrgeTicketRequest(TeaModel):
    def __init__(
        self,
        open_team_id: str = None,
        open_ticket_id: str = None,
        operator_union_id: str = None,
        ticket_memo: UrgeTicketRequestTicketMemo = None,
    ):
        # This parameter is required.
        self.open_team_id = open_team_id
        # This parameter is required.
        self.open_ticket_id = open_ticket_id
        # This parameter is required.
        self.operator_union_id = operator_union_id
        # This parameter is required.
        self.ticket_memo = ticket_memo

    def validate(self):
        if self.ticket_memo:
            self.ticket_memo.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.open_team_id is not None:
            result['openTeamId'] = self.open_team_id
        if self.open_ticket_id is not None:
            result['openTicketId'] = self.open_ticket_id
        if self.operator_union_id is not None:
            result['operatorUnionId'] = self.operator_union_id
        if self.ticket_memo is not None:
            result['ticketMemo'] = self.ticket_memo.to_map()
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('openTeamId') is not None:
            self.open_team_id = m.get('openTeamId')
        if m.get('openTicketId') is not None:
            self.open_ticket_id = m.get('openTicketId')
        if m.get('operatorUnionId') is not None:
            self.operator_union_id = m.get('operatorUnionId')
        if m.get('ticketMemo') is not None:
            temp_model = UrgeTicketRequestTicketMemo()
            self.ticket_memo = temp_model.from_map(m['ticketMemo'])
        return self


class UrgeTicketResponse(TeaModel):
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


